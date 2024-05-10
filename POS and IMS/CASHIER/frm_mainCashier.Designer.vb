<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainCashier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btp_billDate = New System.Windows.Forms.DateTimePicker()
        Me.txt_searchProBarcode = New System.Windows.Forms.TextBox()
        Me.txt_billNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_changePass = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_setDiscount = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_subTotalPrice = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_change = New System.Windows.Forms.Label()
        Me.cbo_payMode = New System.Windows.Forms.ComboBox()
        Me.txt_amountReceived = New System.Windows.Forms.TextBox()
        Me.lbl_grandTotal = New System.Windows.Forms.Label()
        Me.lbl_discount = New System.Windows.Forms.Label()
        Me.lbl_totalTax = New System.Windows.Forms.Label()
        Me.lbl_totalPrice = New System.Windows.Forms.Label()
        Me.lbl_noOfItems = New System.Windows.Forms.Label()
        Me.btn_pay = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_discount = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_overAllGrandTotal = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_time)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(970, 52)
        Me.Panel1.TabIndex = 0
        '
        'lbl_time
        '
        Me.lbl_time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_time.Location = New System.Drawing.Point(714, 15)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(241, 23)
        Me.lbl_time.TabIndex = 4
        Me.lbl_time.Text = "00.00"
        Me.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Inventory System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "POS"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_date)
        Me.Panel2.Controls.Add(Me.btp_billDate)
        Me.Panel2.Controls.Add(Me.txt_searchProBarcode)
        Me.Panel2.Controls.Add(Me.txt_billNo)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(970, 83)
        Me.Panel2.TabIndex = 1
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lbl_date.Location = New System.Drawing.Point(705, 7)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(253, 23)
        Me.lbl_date.TabIndex = 33
        Me.lbl_date.Text = "00.00"
        Me.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btp_billDate
        '
        Me.btp_billDate.Location = New System.Drawing.Point(367, 12)
        Me.btp_billDate.Name = "btp_billDate"
        Me.btp_billDate.Size = New System.Drawing.Size(178, 20)
        Me.btp_billDate.TabIndex = 8
        '
        'txt_searchProBarcode
        '
        Me.txt_searchProBarcode.Location = New System.Drawing.Point(90, 46)
        Me.txt_searchProBarcode.Name = "txt_searchProBarcode"
        Me.txt_searchProBarcode.Size = New System.Drawing.Size(455, 20)
        Me.txt_searchProBarcode.TabIndex = 7
        '
        'txt_billNo
        '
        Me.txt_billNo.Location = New System.Drawing.Point(90, 13)
        Me.txt_billNo.Name = "txt_billNo"
        Me.txt_billNo.Size = New System.Drawing.Size(198, 20)
        Me.txt_billNo.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 32)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Product /" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Barcode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(294, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Bill Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Bill NO:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_logout, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_changePass, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_new, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_setDiscount, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 514)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(970, 56)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.Location = New System.Drawing.Point(831, 3)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(136, 50)
        Me.btn_logout.TabIndex = 15
        Me.btn_logout.Text = "LOGOUT"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_changePass
        '
        Me.btn_changePass.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_changePass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_changePass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_changePass.FlatAppearance.BorderSize = 0
        Me.btn_changePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_changePass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_changePass.ForeColor = System.Drawing.Color.White
        Me.btn_changePass.Location = New System.Drawing.Point(693, 3)
        Me.btn_changePass.Name = "btn_changePass"
        Me.btn_changePass.Size = New System.Drawing.Size(132, 50)
        Me.btn_changePass.TabIndex = 14
        Me.btn_changePass.Text = "CHANGE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PASSWORD"
        Me.btn_changePass.UseVisualStyleBackColor = False
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_new.FlatAppearance.BorderSize = 0
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.ForeColor = System.Drawing.Color.White
        Me.btn_new.Location = New System.Drawing.Point(3, 3)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(132, 50)
        Me.btn_new.TabIndex = 9
        Me.btn_new.Text = "NEW"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'btn_setDiscount
        '
        Me.btn_setDiscount.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_setDiscount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_setDiscount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_setDiscount.FlatAppearance.BorderSize = 0
        Me.btn_setDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_setDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_setDiscount.ForeColor = System.Drawing.Color.White
        Me.btn_setDiscount.Location = New System.Drawing.Point(141, 3)
        Me.btn_setDiscount.Name = "btn_setDiscount"
        Me.btn_setDiscount.Size = New System.Drawing.Size(132, 50)
        Me.btn_setDiscount.TabIndex = 11
        Me.btn_setDiscount.Text = "SET" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DISCOUNT"
        Me.btn_setDiscount.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lbl_subTotalPrice)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.lbl_change)
        Me.Panel3.Controls.Add(Me.cbo_payMode)
        Me.Panel3.Controls.Add(Me.txt_amountReceived)
        Me.Panel3.Controls.Add(Me.lbl_grandTotal)
        Me.Panel3.Controls.Add(Me.lbl_discount)
        Me.Panel3.Controls.Add(Me.lbl_totalTax)
        Me.Panel3.Controls.Add(Me.lbl_totalPrice)
        Me.Panel3.Controls.Add(Me.lbl_noOfItems)
        Me.Panel3.Controls.Add(Me.btn_pay)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txt_discount)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.lbl_overAllGrandTotal)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(661, 135)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(309, 379)
        Me.Panel3.TabIndex = 3
        '
        'lbl_subTotalPrice
        '
        Me.lbl_subTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subTotalPrice.ForeColor = System.Drawing.Color.Black
        Me.lbl_subTotalPrice.Location = New System.Drawing.Point(149, 74)
        Me.lbl_subTotalPrice.Name = "lbl_subTotalPrice"
        Me.lbl_subTotalPrice.Size = New System.Drawing.Size(145, 23)
        Me.lbl_subTotalPrice.TabIndex = 31
        Me.lbl_subTotalPrice.Text = "00.00"
        Me.lbl_subTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(32, 78)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 16)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Sub Total:"
        '
        'lbl_change
        '
        Me.lbl_change.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_change.ForeColor = System.Drawing.Color.Black
        Me.lbl_change.Location = New System.Drawing.Point(127, 271)
        Me.lbl_change.Name = "lbl_change"
        Me.lbl_change.Size = New System.Drawing.Size(167, 23)
        Me.lbl_change.TabIndex = 29
        Me.lbl_change.Text = "00.00"
        Me.lbl_change.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbo_payMode
        '
        Me.cbo_payMode.FormattingEnabled = True
        Me.cbo_payMode.Items.AddRange(New Object() {"CASH", "CREDIT CARD", "DEBIT CARD"})
        Me.cbo_payMode.Location = New System.Drawing.Point(148, 217)
        Me.cbo_payMode.Name = "cbo_payMode"
        Me.cbo_payMode.Size = New System.Drawing.Size(146, 21)
        Me.cbo_payMode.TabIndex = 28
        '
        'txt_amountReceived
        '
        Me.txt_amountReceived.Location = New System.Drawing.Point(148, 245)
        Me.txt_amountReceived.Name = "txt_amountReceived"
        Me.txt_amountReceived.Size = New System.Drawing.Size(146, 20)
        Me.txt_amountReceived.TabIndex = 27
        '
        'lbl_grandTotal
        '
        Me.lbl_grandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grandTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_grandTotal.Location = New System.Drawing.Point(127, 186)
        Me.lbl_grandTotal.Name = "lbl_grandTotal"
        Me.lbl_grandTotal.Size = New System.Drawing.Size(167, 23)
        Me.lbl_grandTotal.TabIndex = 26
        Me.lbl_grandTotal.Text = "00.00"
        Me.lbl_grandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_discount
        '
        Me.lbl_discount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_discount.ForeColor = System.Drawing.Color.Black
        Me.lbl_discount.Location = New System.Drawing.Point(165, 159)
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Size = New System.Drawing.Size(129, 23)
        Me.lbl_discount.TabIndex = 25
        Me.lbl_discount.Text = "00.00"
        Me.lbl_discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_totalTax
        '
        Me.lbl_totalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalTax.ForeColor = System.Drawing.Color.Black
        Me.lbl_totalTax.Location = New System.Drawing.Point(149, 102)
        Me.lbl_totalTax.Name = "lbl_totalTax"
        Me.lbl_totalTax.Size = New System.Drawing.Size(145, 23)
        Me.lbl_totalTax.TabIndex = 24
        Me.lbl_totalTax.Text = "00.00"
        Me.lbl_totalTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_totalPrice
        '
        Me.lbl_totalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalPrice.ForeColor = System.Drawing.Color.Black
        Me.lbl_totalPrice.Location = New System.Drawing.Point(149, 130)
        Me.lbl_totalPrice.Name = "lbl_totalPrice"
        Me.lbl_totalPrice.Size = New System.Drawing.Size(145, 23)
        Me.lbl_totalPrice.TabIndex = 23
        Me.lbl_totalPrice.Text = "00.00"
        Me.lbl_totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_noOfItems
        '
        Me.lbl_noOfItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noOfItems.ForeColor = System.Drawing.Color.Black
        Me.lbl_noOfItems.Location = New System.Drawing.Point(149, 49)
        Me.lbl_noOfItems.Name = "lbl_noOfItems"
        Me.lbl_noOfItems.Size = New System.Drawing.Size(145, 23)
        Me.lbl_noOfItems.TabIndex = 22
        Me.lbl_noOfItems.Text = "00.00"
        Me.lbl_noOfItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_pay
        '
        Me.btn_pay.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_pay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pay.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_pay.FlatAppearance.BorderSize = 0
        Me.btn_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pay.ForeColor = System.Drawing.Color.White
        Me.btn_pay.Location = New System.Drawing.Point(0, 329)
        Me.btn_pay.Name = "btn_pay"
        Me.btn_pay.Size = New System.Drawing.Size(309, 50)
        Me.btn_pay.TabIndex = 21
        Me.btn_pay.Text = "F9 - Pay"
        Me.btn_pay.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(32, 275)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 16)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Change"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(32, 246)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(115, 16)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Amount Received"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(32, 218)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 16)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Payment Mode"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(32, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 16)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Grand Total"
        '
        'txt_discount
        '
        Me.txt_discount.Location = New System.Drawing.Point(105, 162)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Size = New System.Drawing.Size(26, 20)
        Me.txt_discount.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(32, 163)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Discount %"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(32, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Total Tax:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(32, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Total Price:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(32, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "No of Items:"
        '
        'lbl_overAllGrandTotal
        '
        Me.lbl_overAllGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_overAllGrandTotal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_overAllGrandTotal.Location = New System.Drawing.Point(22, 11)
        Me.lbl_overAllGrandTotal.Name = "lbl_overAllGrandTotal"
        Me.lbl_overAllGrandTotal.Size = New System.Drawing.Size(276, 23)
        Me.lbl_overAllGrandTotal.TabIndex = 0
        Me.lbl_overAllGrandTotal.Text = "00.00"
        Me.lbl_overAllGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 135)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(661, 379)
        Me.DataGridView1.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 39
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Product Code"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 97
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Product Name"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Product Group"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 101
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Price"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 56
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Tax %"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 61
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Sub Total"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 78
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "Qty"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 48
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Total"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 56
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'frm_mainCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(970, 570)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_mainCashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS and Inventory Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btp_billDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_searchProBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txt_billNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents btn_changePass As System.Windows.Forms.Button
    Friend WithEvents btn_setDiscount As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents lbl_change As System.Windows.Forms.Label
    Friend WithEvents cbo_payMode As System.Windows.Forms.ComboBox
    Friend WithEvents txt_amountReceived As System.Windows.Forms.TextBox
    Friend WithEvents lbl_grandTotal As System.Windows.Forms.Label
    Friend WithEvents lbl_discount As System.Windows.Forms.Label
    Friend WithEvents lbl_totalTax As System.Windows.Forms.Label
    Friend WithEvents lbl_totalPrice As System.Windows.Forms.Label
    Friend WithEvents lbl_noOfItems As System.Windows.Forms.Label
    Friend WithEvents btn_pay As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_discount As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_overAllGrandTotal As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_subTotalPrice As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
