Imports MySql.Data.MySqlClient
Public Class frm_changePassword

    Dim username As String
    Dim password As String
    Private Sub frm_changePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

        username = frm_login.txt_username.Text
        password = frm_login.txt_password.Text
    End Sub

    Private Sub btn_changePass_Click(sender As Object, e As EventArgs) Handles btn_changePass.Click
        If txt_oldPassword.Text = String.Empty Then
            MsgBox("Please Enter your Old Password", vbExclamation)
            Return
        ElseIf txt_newPassword.Text = String.Empty Or txt_conPassword.Text = String.Empty Then
            MsgBox("Please Enter your New Password", vbExclamation)
            Return
        ElseIf StrComp(txt_newPassword.Text, txt_conPassword.Text, CompareMethod.Binary) Then
            MsgBox("Password does not Match", vbExclamation)
            Return
        Else
            Try
                conn.Open()
                cmd = New MySqlCommand("UPDATE `tbl_user` SET`password`=@password WHERE `username`= '" & username & "'", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@password", txt_conPassword.Text)
                cmd.Parameters.AddWithValue("@password1", txt_oldPassword.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Password has been Changed", vbInformation)
                Else
                    MsgBox("Password Change Failed", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        End If
        txt_newPassword.Clear()
        txt_oldPassword.Clear()
        txt_conPassword.Clear()
    End Sub
End Class