Imports MySql.Data.MySqlClient
Public Class frm_mainCashier

    Private Sub frm_mainCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        txt_searchProBarcode.Focus()
        total()
        btn_pay.Enabled = False
        load_discount()
        txt_billNo.Text = getBillNo()

    End Sub

    Public Sub ADDLIST()
        Dim exist As Boolean = False, numrow As Integer = 0, numtext As Integer
        For Each itm As DataGridViewRow In DataGridView1.Rows
            If itm.Cells(0).Value IsNot Nothing Then
                If itm.Cells(1).Value.ToString = txt_searchProBarcode.Text Then
                    exist = True
                    numrow = itm.Index
                    numtext = CInt(itm.Cells(7).Value)
                    Exit For
                End If
            End If
        Next
        If exist = False Then
            Try
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM `tbl_products` WHERE `PROCODE`='" & txt_searchProBarcode.Text & "'", conn)
                dr = cmd.ExecuteReader
                While dr.Read()
                    If txt_searchProBarcode.Text = String.Empty Then
                        Return
                    Else
                        Dim proCode As String = dr.Item("PROCODE")
                        Dim proName As String = dr.Item("PRONAME")
                        Dim proGroup As String = dr.Item("PROGROUP")
                        Dim price As Decimal = dr.Item("PRICE")
                        Dim tax As Decimal = dr.Item("TAX")
                        Dim totalPrice As Decimal = dr.Item("TOTALPRICE")

                        Dim totalQtyPrice As New Decimal
                        totalQtyPrice = price * tax / 100 + price

                        DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, proCode, proName, proGroup, price, tax, totalPrice, 1, totalQtyPrice)

                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            DataGridView1.Rows(numrow).Cells(7).Value = CInt("1") + numtext
            DataGridView1.Rows(numrow).Cells(8).Value = DataGridView1.Rows(numrow).Cells(6).Value * DataGridView1.Rows(numrow).Cells(7).Value

        End If
    End Sub

    Private Sub txt_searchProBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_searchProBarcode.KeyDown
        If txt_searchProBarcode.Text = Nothing Then
        Else
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                ADDLIST()

                txt_searchProBarcode.Clear()
                txt_searchProBarcode.Focus()
            End If
        End If
    End Sub

    Public Sub total()
        lbl_noOfItems.Text = DataGridView1.Rows.Count - 1 + 1

        Dim sum As Double = 0
        Dim subTotal As Double = 0
        Dim tax As Double = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(8).Value
            tax = tax + DataGridView1.Rows(i).Cells(4).Value * DataGridView1.Rows(i).Cells(5).Value / 100 * DataGridView1.Rows(i).Cells(7).Value
            subTotal = subTotal + DataGridView1.Rows(i).Cells(4).Value * DataGridView1.Rows(i).Cells(7).Value
        Next
        Try
            lbl_subTotalPrice.Text = Format(CDec(subTotal), "#,##0.00")
            lbl_totalTax.Text = Format(CDec(tax), "#,##0.00")
            lbl_totalPrice.Text = Format(CDec(subTotal + tax), "#,##0.00")
            lbl_discount.Text = Format(CDec(txt_discount.Text * lbl_totalPrice.Text / 100), "#,##0.00")
            lbl_grandTotal.Text = Format(CDec(lbl_totalPrice.Text - lbl_discount.Text), "#,##0.00")

            lbl_overAllGrandTotal.Text = Format(CDec(lbl_grandTotal.Text), "#,##0.00")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        total()
    End Sub

    Private Sub txt_amountReceived_TextChanged(sender As Object, e As EventArgs) Handles txt_amountReceived.TextChanged
        Try
            lbl_change.Text = Format(CDec(txt_amountReceived.Text - lbl_grandTotal.Text), "#,##0.00")
            btn_pay.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Sub load_discount()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_discount`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                txt_discount.Text = dr.Item("DISCOUNT")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_setDiscount_Click(sender As Object, e As EventArgs)
        frm_discount.ShowDialog()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lbl_time.Text = Date.Now.ToString("hh:mm:ss tt")
        lbl_date.Text = Date.Now.ToString("dd-MMMM-yyyy DDDD")
    End Sub

    Sub saveBill()
        If cbo_payMode.Text = String.Empty Then
            MsgBox("Please choose a Payment Method", vbInformation)
            Return
        ElseIf txt_amountReceived.Text = String.Empty Then
            MsgBox("Please enter the Received Amount", vbInformation)
            Return
        ElseIf lbl_grandTotal.Text > txt_amountReceived.Text Then
            MsgBox("Insufficient Amount Received", vbExclamation)
            Return
        Else
            Try
                conn.Open()
                For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                    cmd = New MySqlCommand("INSERT INTO `tbl_pos`(`BILLNO`, `BILLDATE`, `BMONTH`, `BMONTHYEAR`, `PROCODE`, `PRONAME`, `PROGROUP`, `PRICE`, `TAX`, `TOTALPROPRICE`, `QTY`, `TOTALPRICEQTY`, `SUBTOTAL`, `TOTALTAX`, `DISCOUNT`, `GRANDTOTAL`, `PAYMODE`, `AMOUNTRECEIVED`, `BALANCE`) VALUES (@BILLNO, @BILLDATE, @BMONTH, @BMONTHYEAR, @PROCODE, @PRONAME, @PROGROUP, @PRICE, @TAX, @TOTALPROPRICE, @QTY, @TOTALPRICEQTY, @SUBTOTAL, @TOTALTAX, @DISCOUNT, @GRANDTOTAL, @PAYMODE, @AMOUNTRECEIVED, @BALANCE)", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@BILLNO", txt_billNo.Text)
                    cmd.Parameters.AddWithValue("@BILLDATE", CDate(btp_billDate.Text))
                    cmd.Parameters.AddWithValue("@BMONTH", Date.Now.ToString("MM"))
                    cmd.Parameters.AddWithValue("@BMONTHYEAR", Date.Now.ToString("MMMM-yyyy"))

                    cmd.Parameters.AddWithValue("@PROCODE", DataGridView1.Rows(j).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@PRONAME", DataGridView1.Rows(j).Cells(2).Value)
                    cmd.Parameters.AddWithValue("@PROGROUP", DataGridView1.Rows(j).Cells(3).Value)
                    cmd.Parameters.AddWithValue("@PRICE", DataGridView1.Rows(j).Cells(4).Value)
                    cmd.Parameters.AddWithValue("@TAX", DataGridView1.Rows(j).Cells(5).Value)
                    cmd.Parameters.AddWithValue("@TOTALPROPRICE", DataGridView1.Rows(j).Cells(6).Value)
                    cmd.Parameters.AddWithValue("@QTY", DataGridView1.Rows(j).Cells(7).Value)
                    cmd.Parameters.AddWithValue("@TOTALPRICEQTY", DataGridView1.Rows(j).Cells(8).Value)

                    cmd.Parameters.AddWithValue("@SUBTOTAL", CDec(lbl_subTotalPrice.Text))
                    cmd.Parameters.AddWithValue("@TOTALTAX", CDec(lbl_totalTax.Text))
                    cmd.Parameters.AddWithValue("@DISCOUNT", CDec(lbl_discount.Text))
                    cmd.Parameters.AddWithValue("@GRANDTOTAL", CDec(lbl_grandTotal.Text))
                    cmd.Parameters.AddWithValue("@PAYMODE", cbo_payMode.Text)
                    cmd.Parameters.AddWithValue("@AMOUNTRECEIVED", CDec(txt_amountReceived.Text))
                    cmd.Parameters.AddWithValue("@BALANCE", CDec(lbl_change.Text))

                    i = cmd.ExecuteNonQuery
                Next
                If i > 0 Then
                    MsgBox("Transaction Saved" & vbNewLine & "Bill No: " & txt_billNo.Text, vbInformation)
                    clear()

                Else
                    MsgBox("Transaction Failed!", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()

        End If
        conn.Close()
        txt_billNo.Text = getBillNo()
    End Sub

    Sub clear()

        btp_billDate.Text = Now
        txt_searchProBarcode.Clear()
        DataGridView1.Rows.Clear()
        lbl_change.Text = "0.00"
        lbl_discount.Text = ""
        lbl_grandTotal.Text = ""
        lbl_noOfItems.Text = "0"
        lbl_overAllGrandTotal.Text = ""
        lbl_subTotalPrice.Text = "0.00"
        lbl_totalPrice.Text = "0.00"
        lbl_totalTax.Text = "0.00"
        cbo_payMode.SelectedIndex = -1
        txt_amountReceived.Clear()

    End Sub

    Private Sub btn_pay_Click(sender As Object, e As EventArgs) Handles btn_pay.Click
        saveBill()
        txt_searchProBarcode.Focus()
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        clear()
        txt_billNo.Text = getBillNo()
    End Sub

    Private Sub btn_changePass_Click(sender As Object, e As EventArgs) Handles btn_changePass.Click
        frm_changePassword.ShowDialog()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        frm_login.Show()
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        DataGridView1.Rows.Remove(DataGridView1.SelectedRows.Item(0))
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        frm_cancelOrder.ShowDialog()
    End Sub
End Class