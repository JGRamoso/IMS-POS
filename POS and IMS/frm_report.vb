Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frm_report
    Private Sub frm_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        load_report()
        total()
    End Sub

    Sub load_report()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `BILLNO`, `BILLDATE`, `BMONTH`, `BMONTHYEAR`, `GRANDTOTAL` FROM `tbl_pos` GROUP BY BILLNO", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("BILLNO"), dr.Item("BILLDATE"), dr.Item("BMONTH"), dr.Item("BMONTHYEAR"), dr.Item("GRANDTOTAL"))
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
            cmd = New MySqlCommand("SELECT `BILLNO`, `BILLDATE`, `BMONTH`, `BMONTHYEAR`, `GRANDTOTAL` FROM `tbl_pos` WHERE like '%" & txt_search.Text & "%' GROUP BY BILLNO", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("BILLNO"), dr.Item("BILLDATE"), dr.Item("BMONTH"), dr.Item("BMONTHYEAR"), dr.Item("GRANDTOTAL"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub rbtn_today_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_today.CheckedChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `BILLNO`, `BILLDATE`, `BMONTH`, `BMONTHYEAR`, `GRANDTOTAL` FROM `tbl_pos` WHERE BILLDATE like '%" & Date.Now.ToString("yyyy-MM-dd") & "%' GROUP BY BILLNO", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("BILLNO"), dr.Item("BILLDATE"), dr.Item("BMONTH"), dr.Item("BMONTHYEAR"), dr.Item("GRANDTOTAL"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub rbtn_currentMonth_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_currentMonth.CheckedChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `BILLNO`, `BILLDATE`, `BMONTH`, `BMONTHYEAR`, `GRANDTOTAL` FROM `tbl_pos` WHERE BMONTH like '%" & Date.Now.ToString("MM") & "%' GROUP BY BILLNO", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("BILLNO"), dr.Item("BILLDATE"), dr.Item("BMONTH"), dr.Item("BMONTHYEAR"), dr.Item("GRANDTOTAL"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `BILLNO`, `BILLDATE`, `BMONTH`, `BMONTHYEAR`, `GRANDTOTAL` FROM `tbl_pos` WHERE BILLDATE BETWEEN '" & date1 & "' and '" & date2 & "' GROUP BY BILLNO", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("BILLNO"), dr.Item("BILLDATE"), dr.Item("BMONTH"), dr.Item("BMONTHYEAR"), dr.Item("GRANDTOTAL"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub total()
        Try
            Dim sum As Double = 0
            For i As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                sum = sum + DataGridView1.Rows(i).Cells(5).Value
            Next
            lbl_totalDisplay.Text = Format(CDec(sum), "#,##0.00")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        total()
    End Sub
End Class