Imports MySql.Data.MySqlClient
Public Class frm_cancelOrder

    Private Sub frm_cancelOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_cancelOrder()

    End Sub

    Sub load_cancelOrder()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_pos` GROUP BY BILLNO", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("BILLNO"), dr.Item("BILLDATE"), dr.Item("GRANDTOTAL"))
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
            cmd = New MySqlCommand("SELECT * FROM `tbl_pos` WHERE BILLNO '%'" & txt_search.Text & "&' GROUP BY BILLNO", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("BILLNO"), dr.Item("BILLDATE"), dr.Item("GRANDTOTAL"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "colDel" Then
            If MsgBox("Are you sure you want to delete this Transaction?", vbQuestion + vbYesNo) = vbYes Then
                Try
                    conn.Open()
                    cmd = New MySqlCommand("Delete from tbl_pos WHERE BILLNO='" & DataGridView1.CurrentRow.Cells(1).Value & "'", conn)
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MsgBox("Bill Deleted.", vbInformation)
                    Else
                        MsgBox("Bill Deletion Failed", vbExclamation)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                conn.Close()
            Else
                Return
            End If
        End If
        load_cancelOrder()
    End Sub
End Class