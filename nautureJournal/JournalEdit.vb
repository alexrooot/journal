'Imports for data access classes 
Imports System.Data.OleDb

Public Class JournalEdit

    'Assumes Microsoft Access database
    Const strProvider As String = "Microsoft.Jet.OLEDB.4.0"
    Public myConnectionDB As New OleDbConnection
    Public reader As OleDbDataReader = Nothing
    Public Property tempDir As String = Application.StartupPath + "\JournalDb.mdb"
    'to get the string you can open Data Sources menu then Configure data Resources on dB Then go to previous Then check make the show String

    Private Sub JournalEdit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim frm As Form1
        frm = CType(Me.MdiParent, Form1)
        frm.intComposeActive -= 1

    End Sub


    Private Sub JournalEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False
        labTodayDate.Text = System.DateTime.Today
        checkDbDate()
        bug()

    End Sub

    Private Sub CreateConnection()

        Dim reader As OleDbDataReader = Nothing
        Dim connectionString As String

        connectionString = "Provider=" & strProvider & ";Data Source=" & tempDir & ";"
        myConnectionDB = New OleDbConnection(connectionString)
        Try
            myConnectionDB.Open()
            Using cmd As New OleDbCommand

                With cmd
                    cmd.Connection = myConnectionDB
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = ("INSERT INTO Submission ( LogInData, UserName)" &
                    " VALUES( @tday, @un )")
                    .Parameters.Add(New OleDbParameter("@tday", System.DateTime.Today))
                    .Parameters.Add(New OleDbParameter("@un", Form1.User.ToString))
                    cmd.ExecuteNonQuery()
                End With
                myConnectionDB.Close()
            End Using
        Catch ex As Exception
            MsgBox("Sorry fatal error")
        End Try





    End Sub



    Public Sub checkDbDate()
        Try
            Dim conn As OleDbConnection = New OleDbConnection("Provider=" & strProvider & ";Data Source=" & tempDir & ";")
            conn.Open()

            Using getText As New OleDbCommand
                getText.CommandText = "SELECT midDay, LogInData FROM Submission WHERE (Submission.LogInData = @tempDay) AND (Submission.UserName = @lbUser)"
                getText.Connection = conn
                getText.Parameters.Add(New OleDbParameter("@tempDay", Me.Text))
                getText.Parameters.Add(New OleDbParameter("@lbUser", Form1.User))
                reader = getText.ExecuteReader()
                If reader.HasRows Then

                    While reader.Read
                        If (reader.Item("midDay").ToString IsNot Nothing) Then
                            txtJournalHalfDay.Text = reader.Item("midDay").ToString
                            Exit Sub
                        End If
                        conn.Close()

                    End While
                ElseIf reader.HasRows = False Then
                    txtJournalHalfDay.Text = ""
                    reader.Close()
                    conn.Close()

                End If
                conn.Close()
                reader.Close()

            End Using

        Catch ex As Exception
            MsgBox("Sorry fatal error")

            'reader.Close()
            Exit Sub

        End Try
    End Sub

    Private Async Sub Flash()
        'Todo something on tread

    End Sub

    Private Sub bug()
        If txtJournalHalfDay.Text Like "" Then
            PictureBox1.Visible = True
        End If


    End Sub

    Private Sub txtJournalHalfDay_TextChanged(sender As Object, e As EventArgs) Handles txtJournalHalfDay.TextChanged
        PictureBox1.Visible = False

    End Sub
End Class