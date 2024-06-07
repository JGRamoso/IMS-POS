Imports MySql.Data.MySqlClient
Public Class frm_mainAdmin
    Private Sub frm_mainAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_salesToday()
    End Sub

    Private Sub btn_manageProduct_Click(sender As Object, e As EventArgs) Handles btn_manageProduct.Click
        frm_manageProducts.ShowDialog()

    End Sub

    Private Sub btn_manageStock_Click(sender As Object, e As EventArgs) Handles btn_manageStock.Click
        frm_manageStocks.ShowDialog()

    End Sub

    Private Sub btn_manageUsers_Click(sender As Object, e As EventArgs) Handles btn_manageUsers.Click
        frm_manageUser.ShowDialog()

    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        frm_login.Show()

    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        frm_report.ShowDialog()
    End Sub

    Sub load_salesToday()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_pos` WHERE `BILLDATE`='" & Date.Now.ToString("yyyy-MM-dd") & "' GROUP BY BILLNO", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("BILLNO"), dr.Item("BILLDATE"), dr.Item("BMONTH"), dr.Item("GRANDTOTAL"))
                Dim sum As Double = 0
                For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                    sum = sum + DataGridView1.Rows(i).Cells(3).Value
                Next
                lbl_salesToday.Text = Format(sum, "#,##0.00")
                lbl_salesTodayNo.Text = DataGridView1.Rows.Count - 1 + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

End Class