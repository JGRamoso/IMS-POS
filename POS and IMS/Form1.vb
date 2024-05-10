Imports MySql.Data.MySqlClient
Public Class frm_login
    Dim name As String
    Dim username As String
    Dim password As String
    Dim role As String
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MsgBox("Are you sure you want to exit?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            conn.Open()
            Dim found As Boolean = False
            cmd = New MySqlCommand("SELECT * FROM `tbl_user` WHERE `username`='" & txt_username.Text & "' AND `password`='" & txt_password.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                found = True
                name = dr.Item("name").ToString
                username = dr.Item("username").ToString
                password = dr.Item("password").ToString
                role = dr.Item("role").ToString
            Else
                found = False
                name = ""
                username = ""
                password = ""
                role = ""

            End If
            If found = True Then
                If StrComp(txt_username.Text, username, CompareMethod.Binary) Or StrComp(txt_password.Text, password, CompareMethod.Binary) Then
                    MsgBox("Wrong Username or Password", vbExclamation)
                    Return
                Else
                    If UCase(role) = "ADMIN" Then
                        Me.Hide()
                        frm_mainAdmin.Show()
                    ElseIf UCase(role) = "CASHIER" Then
                        Me.Hide()
                        frm_mainCashier.Show()

                    End If
                End If
            Else
                MsgBox("Wrong Username or Password", vbExclamation)
                
            End If
            txt_password.Clear()
            txt_username.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
End Class
