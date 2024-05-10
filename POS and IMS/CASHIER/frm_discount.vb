Imports MySql.Data.MySqlClient
Public Class frm_discount

    Private Sub frm_discount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

    End Sub

    Private Sub btn_updateDiscount_Click(sender As Object, e As EventArgs) Handles btn_updateDiscount.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE `tbl_discount` SET `DISCOUNT`=@DISCOUNT WHERE `DISCOUNTID`=@DISCOUNTID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@DISCOUNT", txt_discount.Text)
            cmd.Parameters.AddWithValue("@DISCOUNTID", "1001")
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Discount has been Applied", vbInformation)
            Else
                MsgBox("Discount Application Failed", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        txt_discount.Clear()
        frm_mainCashier.load_discount()
    End Sub
End Class