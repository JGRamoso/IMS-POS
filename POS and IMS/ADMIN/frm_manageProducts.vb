Imports MySql.Data.MySqlClient
Imports System.IO
Imports MessagingToolkit.Barcode
Public Class frm_manageProducts

    Private Sub frm_manageProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

        DataGridView1.RowTemplate.Height = 30

        load_productGroup()
        load_products()
    End Sub

    Private Sub btn_addGroup_Click(sender As Object, e As EventArgs) Handles btn_addGroup.Click
        frm_addGroup.ShowDialog()
    End Sub

    Sub load_productGroup()
        cbo_group.Items.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_group`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                cbo_group.Items.Add(dr.Item("progroup").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    Sub load_products()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `PROCODE`, `PRONAME`, `PROGROUP`, `PRICE`, `TAX`, `TOTALPRICE`, `BARCODE` FROM `tbl_products`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("PROCODE"), dr.Item("PRONAME"), dr.Item("PROGROUP"), dr.Item("PRICE"), dr.Item("TAX"), dr.Item("TOTALPRICE"), dr.Item("BARCODE"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    Sub clear()
        txt_proCode.Clear()
        txt_proName.Clear()
        cbo_group.SelectedIndex = -1
        txt_proPrice.Clear()
        cbo_tax.SelectedIndex = -1
        txt_totalPrice.Clear()
        pic_barcode.Image = Nothing
    End Sub

    Private Sub txt_proCode_TextChanged(sender As Object, e As EventArgs) Handles txt_proCode.TextChanged
        Dim generator As New MessagingToolkit.Barcode.BarcodeEncoder
        generator.BackColor = Color.White
        Try
            pic_barcode.Image = New Bitmap(generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, txt_proCode.Text))
        Catch ex As Exception
            pic_barcode.Image = Nothing
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            conn.Open()

            Dim fileSize As UInt32
            Dim mstream As New System.IO.MemoryStream
            pic_barcode.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            fileSize = mstream.Length
            mstream.Close()

            cmd = New MySqlCommand("INSERT INTO `tbl_products`(`PROCODE`, `PRONAME`, `PROGROUP`, `PRICE`, `TAX`, `TOTALPRICE`, `BARCODE`) VALUES (@PROCODE, @PRONAME, @PROGROUP, @PRICE, @TAX, @TOTALPRICE, @BARCODE)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@PROCODE", txt_proCode.Text)
            cmd.Parameters.AddWithValue("@PRONAME", txt_proName.Text)
            cmd.Parameters.AddWithValue("@PROGROUP", cbo_group.Text)
            cmd.Parameters.AddWithValue("@PRICE", CDec(txt_proPrice.Text))
            cmd.Parameters.AddWithValue("@TAX", CDec(cbo_tax.Text))
            cmd.Parameters.AddWithValue("@TOTALPRICE", CDec(txt_totalPrice.Text))
            cmd.Parameters.AddWithValue("@BARCODE", arrImage)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Product Has Been Saved", vbInformation)
            Else
                MsgBox("New Product Save Failed", vbExclamation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
        clear()
        load_products()
        cbo_tax.Text = ""

    End Sub

    Private Sub cbo_tax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tax.SelectedIndexChanged
        Try
            txt_totalPrice.Text = CDec(txt_proPrice.Text * cbo_tax.Text / 100) + txt_proPrice.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_products` WHERE PROCODE like '%" & txt_search.Text & "%' OR PRONAME like '%" & txt_search.Text & "%' OR PROGROUP like '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("PROCODE"), dr.Item("PRONAME"), dr.Item("PROGROUP"), dr.Item("PRICE"), dr.Item("TAX"), dr.Item("TOTALPRICE"), dr.Item("BARCODE"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        txt_proCode.ReadOnly = True
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `PROCODE`, `PRONAME`, `PROGROUP`, `PRICE`, `TAX`, `TOTALPRICE`, `BARCODE` FROM `tbl_products` WHERE PROCODE like '%" & txt_searchProCode.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                txt_proCode.Text = dr.Item("PROCODE")
                txt_proName.Text = dr.Item("PRONAME")
                cbo_group.Text = dr.Item("PROGROUP")
                txt_proPrice.Text = dr.Item("PRICE")
                cbo_tax.Text = dr.Item("TAX")
                txt_totalPrice.Text = dr.Item("TOTALPRICE")
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE `tbl_products` SET `PRONAME`=@PRONAME,`PROGROUP`=@PROGROUP,`PRICE`=@PRICE,`TAX`=@TAX,`TOTALPRICE`=@TOTALPRICE WHERE `PROCODE`=@PROCODE", conn)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@PRONAME", txt_proName.Text)
            cmd.Parameters.AddWithValue("@PROGROUP", cbo_group.Text)
            cmd.Parameters.AddWithValue("@PRICE", CDec(txt_proPrice.Text))
            cmd.Parameters.AddWithValue("@TAX", CDec(cbo_tax.Text))
            cmd.Parameters.AddWithValue("@TOTALPRICE", CDec(txt_totalPrice.Text))
            cmd.Parameters.AddWithValue("@PROCODE", txt_proCode.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Product Updated", vbInformation)
            Else
                MsgBox("Product Update Failed", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
        txt_searchProCode.Clear()
        load_products()
        txt_proCode.ReadOnly = False
        cbo_tax.Text = ""

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Are you sure you want to Delete this product?", vbExclamation + vbYesNo) = vbYes Then
            Try
                conn.Open()
                cmd = New MySqlCommand("DELETE FROM `tbl_products` WHERE `PROCODE`=@PROCODE", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@PROCODE", txt_proCode.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Product Deleted", vbInformation)
                Else
                    MsgBox("Product Deletion Failed", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            clear()
            txt_searchProCode.Clear()
            load_products()
            txt_proCode.ReadOnly = False
            cbo_tax.Text = ""
        Else
            Return
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear()
        txt_searchProCode.Clear()
        txt_proCode.ReadOnly = False
        cbo_tax.Text = ""
    End Sub
End Class