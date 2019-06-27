Imports System.IO
Imports System.Data.OleDb

Public Class newUser
    Public strUserupdate As String = ""


    Const strProvider As String = "Microsoft.Jet.OLEDB.4.0"
    'Public myConnectionDB As New OleDbConnection

    Private Sub newUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdateAccount()
        Dim dou As Boolean = False
        Dim temppass As String = txtPassword.Text
        Dim question As String = txtRecoveryQuestion.Text
        Dim connUpdate As OleDbConnection
        Dim connStr As String
        Dim reader As OleDbDataReader = Nothing
        Dim hasrows As Boolean = False

        connStr = "Provider=" & strProvider & ";Data Source=" & JournalEdit.tempDir & ";"
        connUpdate = New OleDbConnection(connStr)
        Try
            connUpdate.Open()
            Using cmd As New OleDbCommand
                cmd.Connection = connUpdate
                cmd.CommandText = "SELECT UserName, question1 FROM Accounts WHERE UserName = @un "
                cmd.Parameters.Add(New OleDbParameter("@un", strUserupdate))
                cmd.Parameters.Add(New OleDbParameter("@tempQ", txtRecoveryQuestion.Text))
                reader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read
                        If reader.Item("question1") Like txtRecoveryQuestion.Text Then
                            dou = True

                        End If

                    End While
                End If
                If dou Like False Then
                    MsgBox("Try again.")
                End If
                'connUpdate.Close()
                reader.Close()

            End Using
        Catch ex As Exception
            MsgBox("Sorry fatal Error.")
        End Try
        If dou And (Me.Text Like "Reset Password") Then
            doUpdate()
        End If

        If dou And (Me.Text Like "Delete Account") Then
            removeUser()
        End If

        connUpdate.Close()
    End Sub

    Private Sub doUpdate()
        Dim connStr As String = "Provider=" & strProvider & ";Data Source=" & JournalEdit.tempDir & ";"
        Dim conn As OleDbConnection = New OleDbConnection(connStr)
        conn.Open()

        Try
            Using cmdUpdate As New OleDbCommand

                With cmdUpdate
                    cmdUpdate.Connection = conn
                    cmdUpdate.CommandType = CommandType.Text
                    cmdUpdate.CommandText = "UPDATE Accounts Set pinCode = @pin WHERE (Accounts.UserName = @un) AND (Accounts.question1 = @tempQ )"
                    cmdUpdate.Parameters.Add(New OleDbParameter("@pin", txtPassword.Text))
                    cmdUpdate.Parameters.Add(New OleDbParameter("@un", strUserupdate))
                    cmdUpdate.Parameters.Add(New OleDbParameter("@tempQ", txtRecoveryQuestion.Text))
                    cmdUpdate.ExecuteNonQuery()
                End With

            End Using
        Catch ex As Exception
            conn.Close()

        End Try
        MsgBox("Thank you we will change your password.")
        conn.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text Like "Update" Then

            UpdateAccount()
            Exit Sub
        End If

        If Me.Text Like "Delete Account" Then
            UpdateAccount()

        End If
        SaveUser()
    End Sub

    Sub SaveUser()
        If DialogResult = Windows.Forms.DialogResult.OK Then
            Dim firstName As String = txtFirstName.Text
            Dim lastName As String = txtLastName.Text
            Dim temppass As String = txtPassword.Text
            Dim question As String = txtRecoveryQuestion.Text

            Dim cnnNew As OleDbConnection
            Dim connStr As String

            connStr = "Provider=" & strProvider & ";Data Source=" & JournalEdit.tempDir & ";"
            cnnNew = New OleDbConnection(connStr)
            Try
                cnnNew.Open()
                Using cmd As New OleDbCommand
                    With cmd
                        .Connection = cnnNew
                        .CommandType = CommandType.Text
                        .CommandText = "INSERT INTO Accounts ( UserName, firstName, lastName, pinCode, intialDay, tress, bushes, weeds, question1 )" &
                    " VALUES( @newUser, @fname, @lname, @pin, @iday, @tree, @bush, @weed, @q1 )"

                        .Parameters.Add(New OleDbParameter("@newUser", firstName + " " + lastName))
                        .Parameters.Add(New OleDbParameter("@fname", firstName))
                        .Parameters.Add(New OleDbParameter("@lname", lastName))
                        .Parameters.Add(New OleDbParameter("@pin", temppass))
                        .Parameters.Add(New OleDbParameter("@iday", System.DateTime.Today))
                        .Parameters.Add(New OleDbParameter("@tree", 0))
                        .Parameters.Add(New OleDbParameter("@bush", 0))
                        .Parameters.Add(New OleDbParameter("@weed", 10))
                        .Parameters.Add(New OleDbParameter("@q1", question))

                        cmd.ExecuteNonQuery()
                    End With

                End Using
                cnnNew.Close()

            Catch ex As Exception
                MsgBox("Sorry fatal error saving new User.")
            End Try



            Me.Close()



        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
    Private Sub removeUser()

        Dim connStr As String = "Provider=" & strProvider & ";Data Source=" & JournalEdit.tempDir & ";"
        Dim conn As OleDbConnection = New OleDbConnection(connStr)
        conn.Open()

        Try
            Using cmdUpdate As New OleDbCommand

                With cmdUpdate
                    cmdUpdate.Connection = conn
                    cmdUpdate.CommandType = CommandType.Text

                    cmdUpdate.CommandText = "DELETE FROM Accounts WHERE UserName = @un "
                    cmdUpdate.Parameters.Add(New OleDbParameter("@un", strUserupdate))
                    cmdUpdate.ExecuteNonQuery()
                End With

            End Using
        Catch ex As Exception
            conn.Close()

        End Try
        MsgBox("Thank you we are removing user.")
        conn.Close()
    End Sub

    Private Sub lbAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbAccounts.SelectedIndexChanged
        If lbAccounts.SelectedItems.Count > 0 Then
            Dim accountIndex As Integer
            accountIndex = lbAccounts.SelectedIndex()
            strUserupdate = lbAccounts.Items(accountIndex).ToString

        End If
    End Sub
End Class