Imports System.IO
Imports System.Data.OleDb

Public Class Form1
    Const strProvider As String = "Microsoft.Jet.OLEDB.4.0"
    Public Property User As String = ""
    Public conn As OleDbConnection
    Public reader As OleDbDataReader = Nothing
    Public intComposeActive As Integer = 0
    Public intForestActive As Integer = 0

    Public dbDir = Application.StartupPath + "\JournalDb.mdb"



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AWTestNJDataSet.MainAccounts' table. You can move, or remove it, as needed.
        btnComposeNew.Enabled = False
        btnClose.Enabled = False
        btnForest.Enabled = False
        btnSave.Enabled = False
        lbSearchResult.Visible = False
        btnCloselist.Visible = False

        bgColor()
        lbAccounts.Visible = False
        labDate.Text = System.DateTime.Today

        'Dim startDate As String
        'startDate = DateTimePicker1.Value.ToString("yyyy/MM/dd") ' or  DateTimePicker1.Value.Date

    End Sub


    Private Sub btnComposeNew_Click(sender As Object, e As EventArgs) Handles btnComposeNew.Click
        Dim child As New JournalEdit
        child.MdiParent = Me ' when I click the button I will make a new clean journalEdit instace as its parent
        child.Opacity = 100
        child.txtJournalHalfDay.Tag = DateTimePicker1.Value.ToShortDateString
        child.Text = DateTimePicker1.Value.ToShortDateString
        child.Show()
        intComposeActive += 1 ' will keep track of how many MDI's are open

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim activeChild As Form = Me.ActiveMdiChild
        If (activeChild Is Nothing) Then
            MessageBox.Show("No Journal Entry to Close")
            Exit Sub
        End If
        activeChild.Close()

    End Sub




    Public Sub bgColor()
        Dim child As Control
        For Each child In Me.Controls
            If TypeOf child Is MdiClient Then
                child.BackColor = ColorTranslator.FromHtml("#EBF4FA")
                Exit For
            End If
        Next
        child = Nothing
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        If btnLogIn.Text Like "Log In" Then
            lookupUsers()

        End If

    End Sub

    Private Sub lookupUsers()
        lbAccounts.Visible = True
        lbAccounts.Items.Clear()

        conn = New OleDbConnection("Provider=" & strProvider & ";Data Source=" & dbDir & ";")
        Try
            conn.Open()

        Catch ex As Exception
        End Try

        Using cmd As New OleDbCommand("SELECT UserName FROM Accounts ", conn)
            reader = cmd.ExecuteReader()
            While reader.Read
                lbAccounts.BeginUpdate()
                lbAccounts.Items.Add(reader.Item("UserName"))
                lbAccounts.EndUpdate()
            End While
            conn.Close()
            reader.Close()

        End Using
    End Sub

    Private Sub lbAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbAccounts.SelectedIndexChanged
        If lbAccounts.SelectedItems.Count > 0 Then
            Dim accountIndex As Integer
            accountIndex = lbAccounts.SelectedIndex()
            User = lbAccounts.Items(accountIndex).ToString
            btnLogIn.Text = "Log In"

        End If
    End Sub


    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If btnLogIn.Text Like "Sign out" Then
            labUserSelected.Text = "Select Your Account"
            btnLogIn.Text = "Log In"
            Exit Sub
        End If

        If btnLogIn.Text Like "Log In" Then
            attemptLogIn()
        End If


    End Sub

    Private Sub btnNewAccount_Click(sender As Object, e As EventArgs) Handles btnNewAccount.Click
        Dim child As New newUser
        child.MdiParent = Me ' when I click the button I will make a new clean journalEdit instace as its parent
        child.Opacity = 100

        child.Location = New Point(300, 300)
        child.Show()

    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        checkDb()



    End Sub

    Private Sub checkDb()
        Dim activeChild As Form = Me.ActiveMdiChild
        Dim tempText As String
        Dim tempDate As String
        Dim needsUpdate As Boolean

        If (activeChild Is Nothing) Then
            MessageBox.Show("No Journal Entry to Save")
            Exit Sub
        End If

        Dim userText As TextBox = TryCast(activeChild.ActiveControl, TextBox)

        Try
            conn = New OleDbConnection("Provider=" & strProvider & ";Data Source=" & dbDir & ";")

            conn.Open()
            Using checkDb As New OleDbCommand
                checkDb.CommandText = "SELECT LogInData FROM Submission WHERE (Submission.LogInData = @tempDay) AND (Submission.UserName = @tempUser )"
                checkDb.Connection = conn
                checkDb.Parameters.Add(New OleDbParameter("@tempDay", activeChild.Text))
                checkDb.Parameters.Add(New OleDbParameter("@tempUser", User))
                'checkDb.ExecuteNonQuery()
                reader = checkDb.ExecuteReader
                If reader.HasRows Then


                    While reader.Read()
                        Dim lDate As String = reader.Item("LogInData")
                        If (lDate Like activeChild.Text) Then
                            saveHistoricalJournal(lDate, userText.Text.ToString)

                            Exit Sub

                        ElseIf (lDate Is Nothing) Then
                            saveNewJournal(activeChild.Text.ToString, userText.Text.ToString)

                            Exit Sub

                        End If

                    End While

                End If
                reader.Close()
                conn.Close()
                saveNewJournal(activeChild.Text.ToString, userText.Text.ToString)
                Exit Sub
            End Using
            reader.Close()
            conn.Close()
        Catch ex As Exception
            reader.Close()
            MsgBox("Sorry and error has occured." & Environment.NewLine & "                Try Again.")

        End Try

    End Sub

    Private Sub haveJournalSave()
        Dim activeChild As Form = Me.ActiveMdiChild
        Dim tempText As String
        Dim tempDate As String
        Dim needsUpdate As Boolean


        If (activeChild Is Nothing) Then
            MessageBox.Show("No Journal Entry to Save")
            Exit Sub
        End If


        If (Not activeChild Is Nothing) Then
            Dim theTextBox As TextBox = TryCast(activeChild.ActiveControl, TextBox) ' will get datafrom last active textbox you selected
            If (Not theTextBox Is Nothing) Then
                tempText = theTextBox.Text

                Dim reader As OleDbDataReader = Nothing
                Dim connectionString As String
                Dim cnn As OleDbConnection
                connectionString = "Provider=" & strProvider & ";Data Source=" & dbDir & ";"
                cnn = New OleDbConnection(connectionString)
                Try
                    cnn.Open()
                    Using cmdUpdate As New OleDbCommand

                        With cmdUpdate
                            cmdUpdate.Connection = cnn
                            cmdUpdate.CommandType = CommandType.Text
                            cmdUpdate.CommandText = "UPDATE Submission Set midDay = @userText WHERE (Submission.LogInData = @tempDay) AND (Submission.UserName = @tempUser )"

                            .Parameters.Add(New OleDbParameter("@userText", tempText))
                            .Parameters.Add(New OleDbParameter("@tempDay", System.DateTime.Today))
                            .Parameters.Add(New OleDbParameter("@tempUser", User))

                            cmdUpdate.ExecuteNonQuery()
                        End With
                        cnn.Close()
                    End Using
                Catch ex As Exception
                    MsgBox("Sorry fatal error.")
                End Try

            End If
        Else
            MsgBox("You need to type more.")
        End If

    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            attemptLogIn()
            e.Handled = True
        End If
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SearchDb()
            e.Handled = True
        End If
    End Sub


    Public Sub attemptLogIn()
        Try
            conn = New OleDbConnection("Provider=" & strProvider & ";Data Source=" & dbDir & ";")

            conn.Open()

            Using getpin As New OleDbCommand("SELECT pinCode FROM Accounts WHERE UserName = @lbUser ", conn)
                getpin.Parameters.Add(New OleDbParameter("@lbUser", User))
                reader = getpin.ExecuteReader
                While reader.Read
                    If (reader.Item("pinCode").ToString Like txtPassword.Text) Then


                        'My.Computer.Audio.Play(My.Resources.yourWmaFile, AudioPlayMode.Background)
                        btnComposeNew.Enabled = True
                        btnSave.Enabled = True
                        btnClose.Enabled = True
                        btnForest.Enabled = True
                        lbAccounts.Visible = False
                        txtPassword.Text = ""
                        labUserSelected.Text = User
                        btnLogIn.Text = "Sign out"
                        MsgBox("Welcom Back!")
                        reader.Close()
                        Exit Sub
                    ElseIf (reader.Item("pinCode").ToString IsNot txtPassword.Text) Then
                        MsgBox("Wrong Password.")
                        reader.Close()
                    End If


                End While
                reader.Close()

            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox("Sorry and error has occured." & Environment.NewLine & "                Try Again.")

        End Try
    End Sub

    Private Sub saveNewJournal(jDay As String, strText As String)
        Dim connectionString As String = "Provider=" & strProvider & ";Data Source=" & dbDir & ";"
        conn = New OleDbConnection(connectionString)
        conn.Open()

        Using cmdNewRecord As New OleDbCommand
            cmdNewRecord.Connection = conn
            cmdNewRecord.CommandType = CommandType.Text
            cmdNewRecord.CommandText = "INSERT INTO Submission ( LogInData, midDay, UserName) VALUES( @tday, @tempText, @un )"

            cmdNewRecord.Parameters.Add(New OleDbParameter("@tday", jDay))
            cmdNewRecord.Parameters.Add(New OleDbParameter("@tempText", strText))
            cmdNewRecord.Parameters.Add(New OleDbParameter("@un", User))
            cmdNewRecord.ExecuteNonQuery()
        End Using
        conn.Close()
    End Sub

    Private Sub saveHistoricalJournal(jDay As String, strText As String)
        Dim connectionString As String = "Provider=" & strProvider & ";Data Source=" & dbDir & ";"
        conn = New OleDbConnection(connectionString)
        conn.Open()

        Try
            Using cmdUpdate As New OleDbCommand

                With cmdUpdate
                    cmdUpdate.Connection = conn
                    cmdUpdate.CommandType = CommandType.Text
                    cmdUpdate.CommandText = "UPDATE Submission Set midDay = @userText WHERE (Submission.LogInData = @tempDay) AND (Submission.UserName = @tempUser )"

                    .Parameters.Add(New OleDbParameter("@userText", strText))
                    .Parameters.Add(New OleDbParameter("@tempDay", jDay))
                    .Parameters.Add(New OleDbParameter("@tempUser", User))
                    cmdUpdate.ExecuteNonQuery()
                End With
                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox("Sorry fatal error.")
        End Try
    End Sub

    Private Sub btnForest_Click(sender As Object, e As EventArgs) Handles btnForest.Click
        recentUserRecord()
    End Sub

    Private Sub recentUserRecord()
        Dim intRecords As Int32 = 0
        Dim connectionString As String = "Provider=" & strProvider & ";Data Source=" & dbDir & ";"
        conn = New OleDbConnection(connectionString)
        conn.Open()
        Try
            Using cmdForestCheck As New OleDbCommand
                With cmdForestCheck
                    cmdForestCheck.Connection = conn
                    cmdForestCheck.CommandText = "SELECT TOP 5 Submission.LogInData FROM Submission WHERE (Submission.UserName = @tempUserf) AND (Submission.LogInData > @fiveDaysAgo) ORDER BY Submission.LogInData DESC "

                    cmdForestCheck.Parameters.Add(New OleDbParameter("@tempUserf", User))
                    cmdForestCheck.Parameters.Add(New OleDbParameter("@fiveDaysAgo", System.DateTime.Today.AddDays(-5)))
                    reader = cmdForestCheck.ExecuteReader
                    If reader.HasRows Then

                        While reader.Read()
                            Dim strr As String = reader.Item("LogInData")
                            intRecords += 1
                        End While
                    End If
                    reader.Close()

                End With
            End Using
            conn.Close()
            setForestto(intRecords)

        Catch ex As Exception
            MsgBox("Sorry fatal error.")
        End Try
    End Sub


    Private Async Sub setForestto(stage As Int32)

        Dim childForest As New Forest
        childForest.MdiParent = Me ' when I click the button I will make a new clean journalEdit instace as its parent
        childForest.Opacity = 100
        intForestActive += 1 ' will keep track of how many MDI's are open


        Select Case stage
            Case 1
                childForest.PictureBox1.Image = My.Resources.forest_stage_01
                childForest.Text = "Your Forest like your thoughts are gone."
            Case 2
                childForest.PictureBox1.Image = My.Resources.forest_stage_02
                childForest.Text = "Keep on writing your thoughts more."
            Case 3
                childForest.PictureBox1.Image = My.Resources.forest_stage_3
                childForest.Text = "Your Forest like your thoughts are OK."
            Case 4
                childForest.PictureBox1.Image = My.Resources.forest_stage_04
                childForest.Text = "Your thoughts are having positive impact."
            Case 5
                childForest.PictureBox1.Image = My.Resources.forest_stage_05
                childForest.Text = "Your thoughts are having an awesome time."

            Case 6
                childForest.PictureBox1.Image = My.Resources.forest_stage_05
                childForest.Text = "Your Keep this up to have a clear conscious."
        End Select
        intForestActive += 1
        childForest.Show()



    End Sub

    Private Sub SearchDb()
        If btnLogIn.Text Like "Sign out" Then
            btnCloselist.Visible = True
            lbSearchResult.Visible = True
            Dim connectionString As String = "Provider=" & strProvider & ";Data Source=" & dbDir & ";"
            conn = New OleDbConnection(connectionString)
            conn.Open()
            Using cmdSearch As New OleDbCommand
                cmdSearch.Connection = conn
                Dim strSearch As String = txtSearch.Text.Trim
                cmdSearch.CommandText = "SELECT midDay FROM Submission WHERE UserName = @lbUser AND midDay CONTAINS '@phraseSearch' ORDER BY LogInData DESC"
                cmdSearch.Parameters.Add(New OleDbParameter("@lbUser", User))
                cmdSearch.Parameters.Add(New OleDbParameter("@phraseSearch", strSearch))
                reader = cmdSearch.ExecuteReader
                If reader.HasRows Then
                    While reader.Read
                        Dim stemp As String = reader.Item("midDay")
                        lbSearchResult.BeginUpdate()
                        lbSearchResult.Items.Add(reader.Item("midDay"))
                        lbSearchResult.EndUpdate()
                    End While


                End If

            End Using
        End If


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchDb()
    End Sub

    Private Sub btnCloselist_Click(sender As Object, e As EventArgs) Handles btnCloselist.Click
        lbSearchResult.Visible = False
        btnCloselist.Visible = False
        lbSearchResult.Items.Clear()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        lookupUsers()
    End Sub

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        Dim child As New newUser
        child.MdiParent = Me ' when I click the button I will make a new clean journalEdit instace as its parent
        child.Opacity = 100

        child.Location = New Point(300, 300)
        child.Show()
    End Sub

    Private Sub ForgotPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForgotPasswordToolStripMenuItem.Click

        Dim childForgotPass As New newUser
        childForgotPass.MdiParent = Me
        childForgotPass.Opacity = 100
        childForgotPass.Location = New Point(300, 300)

        childForgotPass.lbAccounts.Visible = True
        childForgotPass.Text = "Reset Password"
        childForgotPass.lbAccounts.Items.Clear()
        childForgotPass.txtFirstName.Visible = False
        childForgotPass.txtLastName.Visible = False
        childForgotPass.Label1.Visible = False
        childForgotPass.Label2.Text = "Select your acoount."
        childForgotPass.Label4.Text = "Enter new password."
        childForgotPass.Label3.Text = "Security question: Your favorite number."
        childForgotPass.btnAdd.Text = "Update"


        conn = New OleDbConnection("Provider=" & strProvider & ";Data Source=" & dbDir & ";")
        Try
            conn.Open()

        Catch ex As Exception
            MsgBox("Sorry fatal error")
        End Try

        Using cmd As New OleDbCommand("SELECT UserName FROM Accounts ", conn)
            reader = cmd.ExecuteReader()
            While reader.Read
                childForgotPass.lbAccounts.BeginUpdate()
                childForgotPass.lbAccounts.Items.Add(reader.Item("UserName"))
                childForgotPass.lbAccounts.EndUpdate()
            End While
            conn.Close()
            reader.Close()

        End Using
        childForgotPass.Show()

    End Sub

    Private Sub DeleteAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAccountToolStripMenuItem.Click
        Dim childForgotPass As New newUser
        childForgotPass.MdiParent = Me
        childForgotPass.Opacity = 100
        childForgotPass.Location = New Point(300, 300)

        childForgotPass.lbAccounts.Visible = True
        childForgotPass.Text = "Delete Account"
        childForgotPass.lbAccounts.Items.Clear()
        childForgotPass.txtFirstName.Visible = False
        childForgotPass.txtLastName.Visible = False
        childForgotPass.Label1.Visible = False
        childForgotPass.Label2.Text = "Select your acoount."
        childForgotPass.Label4.Text = "Enter your password."
        childForgotPass.Label3.Text = "Enter Security: Your favorite number."
        childForgotPass.btnAdd.Text = "Delete"


        conn = New OleDbConnection("Provider=" & strProvider & ";Data Source=" & dbDir & ";")
        Try
            conn.Open()

        Catch ex As Exception
            MsgBox("Sorry fatal error")
        End Try

        Using cmd As New OleDbCommand("SELECT UserName FROM Accounts ", conn)
            reader = cmd.ExecuteReader()
            While reader.Read
                childForgotPass.lbAccounts.BeginUpdate()
                childForgotPass.lbAccounts.Items.Add(reader.Item("UserName"))
                childForgotPass.lbAccounts.EndUpdate()
            End While
            conn.Close()
            reader.Close()

        End Using
        childForgotPass.Show()
    End Sub
End Class
