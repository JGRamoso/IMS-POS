Imports MySql.Data.MySqlClient
Public Class frm_manageUser

    Private Sub frm_manageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

    End Sub

    Sub clear()
        txt_name.Clear()
        txt_password.Clear()
        txt_username.Clear()
        cbo_role.SelectedIndex = -1
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
        frm_mainAdmin.Show()
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO `tbl_user`(`name`, `username`, `password`, `role`) VALUES (@name, @username, @password, @role)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", txt_name.Text)
            cmd.Parameters.AddWithValue("@username", txt_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            cmd.Parameters.AddWithValue("@role", cbo_role.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New User Registered", vbInformation)
            Else
                MsgBox("Registration failed", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
    End Sub

    Private Sub txt_name_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged

    End Sub
End Class