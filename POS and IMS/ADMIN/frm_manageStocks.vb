Imports MySql.Data.MySqlClient
Public Class frm_manageStocks

    Dim j As New Integer
    Private Sub frm_manageStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        load_stocks()
    End Sub

    Sub load_stocks()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `PROCODE`, `PRONAME`, `PROGROUP`, `PRICE`, `TAX`, `TOTALPRICE`, `STOCK` FROM `tbl_products`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("PROCODE"), dr.Item("PRONAME"), dr.Item("PROGROUP"), dr.Item("PRICE"), dr.Item("TAX"), dr.Item("TOTALPRICE"), dr.Item("STOCK"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `PROCODE`, `PRONAME`, `PROGROUP`, `PRICE`, `TAX`, `TOTALPRICE`, `STOCK` FROM `tbl_products` WHERE PROCODE like '%" & txt_search.Text & "%' OR PRONAME like '%" & txt_search.Text & "%' OR PROGROUP like '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("PROCODE"), dr.Item("PRONAME"), dr.Item("PROGROUP"), dr.Item("PRICE"), dr.Item("TAX"), dr.Item("TOTALPRICE"), dr.Item("STOCK"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_updateStocks_Click(sender As Object, e As EventArgs) Handles btn_updateStocks.Click
        Try
            conn.Open()

            For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                cmd = New MySqlCommand("UPDATE `tbl_products` SET `STOCK`=@STOCK WHERE `PROCODE`=@PROCODE", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@STOCK", DataGridView1.Rows(j).Cells(7).Value.ToString)
                cmd.Parameters.AddWithValue("@PROCODE", DataGridView1.Rows(j).Cells(1).Value.ToString)
                i = cmd.ExecuteNonQuery

            Next
            If i > 0 Then
                MsgBox("Stock Updated", vbInformation)
            Else
                MsgBox("Stock Update Failed", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        load_stocks()
    End Sub
End Class