<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainAdmin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_manageUsers = New System.Windows.Forms.Button()
        Me.btn_manageStock = New System.Windows.Forms.Button()
        Me.btn_manageProduct = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_report = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_salesToday = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_monthlySales = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_productsNo = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lbl_noOfSalesToday = New System.Windows.Forms.Label()
        Me.lbl_salesTodayNo = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lbl_noOfMonthlySales = New System.Windows.Forms.Label()
        Me.lbl_monthlySalesNo = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lblto = New System.Windows.Forms.Label()
        Me.lbl_usersNo = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1064, 73)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Inventory System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "POS"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_report, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_logout, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_manageUsers, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_manageStock, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_manageProduct, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(441, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(620, 70)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.Location = New System.Drawing.Point(499, 3)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(118, 64)
        Me.btn_logout.TabIndex = 4
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_manageUsers
        '
        Me.btn_manageUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_manageUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_manageUsers.FlatAppearance.BorderSize = 0
        Me.btn_manageUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btn_manageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manageUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manageUsers.Location = New System.Drawing.Point(251, 3)
        Me.btn_manageUsers.Name = "btn_manageUsers"
        Me.btn_manageUsers.Size = New System.Drawing.Size(118, 64)
        Me.btn_manageUsers.TabIndex = 2
        Me.btn_manageUsers.Text = "Manage Users"
        Me.btn_manageUsers.UseVisualStyleBackColor = True
        '
        'btn_manageStock
        '
        Me.btn_manageStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_manageStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_manageStock.FlatAppearance.BorderSize = 0
        Me.btn_manageStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btn_manageStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manageStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manageStock.Location = New System.Drawing.Point(127, 3)
        Me.btn_manageStock.Name = "btn_manageStock"
        Me.btn_manageStock.Size = New System.Drawing.Size(118, 64)
        Me.btn_manageStock.TabIndex = 1
        Me.btn_manageStock.Text = "Manage Stock"
        Me.btn_manageStock.UseVisualStyleBackColor = True
        '
        'btn_manageProduct
        '
        Me.btn_manageProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_manageProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_manageProduct.FlatAppearance.BorderSize = 0
        Me.btn_manageProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btn_manageProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_manageProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manageProduct.Location = New System.Drawing.Point(3, 3)
        Me.btn_manageProduct.Name = "btn_manageProduct"
        Me.btn_manageProduct.Size = New System.Drawing.Size(118, 64)
        Me.btn_manageProduct.TabIndex = 0
        Me.btn_manageProduct.Text = "Manage Products"
        Me.btn_manageProduct.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 587)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1064, 49)
        Me.Panel2.TabIndex = 1
        '
        'btn_report
        '
        Me.btn_report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_report.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_report.FlatAppearance.BorderSize = 0
        Me.btn_report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_report.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_report.Location = New System.Drawing.Point(375, 3)
        Me.btn_report.Name = "btn_report"
        Me.btn_report.Size = New System.Drawing.Size(118, 64)
        Me.btn_report.TabIndex = 5
        Me.btn_report.Text = "Sales Report"
        Me.btn_report.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(12, 139)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1040, 376)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1040, 48)
        Me.Panel4.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel8, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel7, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel6, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 48)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1040, 117)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 165)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1040, 50)
        Me.Panel5.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel11, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel10, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel9, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 215)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1040, 117)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.lbl_salesToday)
        Me.Panel6.Location = New System.Drawing.Point(211, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(202, 111)
        Me.Panel6.TabIndex = 0
        '
        'lbl_salesToday
        '
        Me.lbl_salesToday.AutoSize = True
        Me.lbl_salesToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_salesToday.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_salesToday.Location = New System.Drawing.Point(19, 18)
        Me.lbl_salesToday.Name = "lbl_salesToday"
        Me.lbl_salesToday.Size = New System.Drawing.Size(49, 24)
        Me.lbl_salesToday.TabIndex = 0
        Me.lbl_salesToday.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(20, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Sales Today"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.lbl_monthlySales)
        Me.Panel7.Location = New System.Drawing.Point(419, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(202, 111)
        Me.Panel7.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(20, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Monthly Sales"
        '
        'lbl_monthlySales
        '
        Me.lbl_monthlySales.AutoSize = True
        Me.lbl_monthlySales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monthlySales.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_monthlySales.Location = New System.Drawing.Point(19, 18)
        Me.lbl_monthlySales.Name = "lbl_monthlySales"
        Me.lbl_monthlySales.Size = New System.Drawing.Size(49, 24)
        Me.lbl_monthlySales.TabIndex = 0
        Me.lbl_monthlySales.Text = "0.00"
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.lbl_productsNo)
        Me.Panel8.Location = New System.Drawing.Point(627, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(202, 111)
        Me.Panel8.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(20, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "No. of Products"
        '
        'lbl_productsNo
        '
        Me.lbl_productsNo.AutoSize = True
        Me.lbl_productsNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productsNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_productsNo.Location = New System.Drawing.Point(19, 18)
        Me.lbl_productsNo.Name = "lbl_productsNo"
        Me.lbl_productsNo.Size = New System.Drawing.Size(49, 24)
        Me.lbl_productsNo.TabIndex = 0
        Me.lbl_productsNo.Text = "0.00"
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.lbl_noOfSalesToday)
        Me.Panel9.Controls.Add(Me.lbl_salesTodayNo)
        Me.Panel9.Location = New System.Drawing.Point(211, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(202, 111)
        Me.Panel9.TabIndex = 2
        '
        'lbl_noOfSalesToday
        '
        Me.lbl_noOfSalesToday.AutoSize = True
        Me.lbl_noOfSalesToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noOfSalesToday.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_noOfSalesToday.Location = New System.Drawing.Point(20, 75)
        Me.lbl_noOfSalesToday.Name = "lbl_noOfSalesToday"
        Me.lbl_noOfSalesToday.Size = New System.Drawing.Size(142, 16)
        Me.lbl_noOfSalesToday.TabIndex = 1
        Me.lbl_noOfSalesToday.Text = "No. of Sales Today"
        '
        'lbl_salesTodayNo
        '
        Me.lbl_salesTodayNo.AutoSize = True
        Me.lbl_salesTodayNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_salesTodayNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_salesTodayNo.Location = New System.Drawing.Point(19, 18)
        Me.lbl_salesTodayNo.Name = "lbl_salesTodayNo"
        Me.lbl_salesTodayNo.Size = New System.Drawing.Size(49, 24)
        Me.lbl_salesTodayNo.TabIndex = 0
        Me.lbl_salesTodayNo.Text = "0.00"
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.lbl_noOfMonthlySales)
        Me.Panel10.Controls.Add(Me.lbl_monthlySalesNo)
        Me.Panel10.Location = New System.Drawing.Point(419, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(202, 111)
        Me.Panel10.TabIndex = 2
        '
        'lbl_noOfMonthlySales
        '
        Me.lbl_noOfMonthlySales.AutoSize = True
        Me.lbl_noOfMonthlySales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noOfMonthlySales.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_noOfMonthlySales.Location = New System.Drawing.Point(20, 75)
        Me.lbl_noOfMonthlySales.Name = "lbl_noOfMonthlySales"
        Me.lbl_noOfMonthlySales.Size = New System.Drawing.Size(150, 16)
        Me.lbl_noOfMonthlySales.TabIndex = 1
        Me.lbl_noOfMonthlySales.Text = "No. of Monthly Sales"
        '
        'lbl_monthlySalesNo
        '
        Me.lbl_monthlySalesNo.AutoSize = True
        Me.lbl_monthlySalesNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monthlySalesNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_monthlySalesNo.Location = New System.Drawing.Point(19, 18)
        Me.lbl_monthlySalesNo.Name = "lbl_monthlySalesNo"
        Me.lbl_monthlySalesNo.Size = New System.Drawing.Size(49, 24)
        Me.lbl_monthlySalesNo.TabIndex = 0
        Me.lbl_monthlySalesNo.Text = "0.00"
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.lblto)
        Me.Panel11.Controls.Add(Me.lbl_usersNo)
        Me.Panel11.Location = New System.Drawing.Point(627, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(202, 111)
        Me.Panel11.TabIndex = 2
        '
        'lblto
        '
        Me.lblto.AutoSize = True
        Me.lblto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblto.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblto.Location = New System.Drawing.Point(20, 75)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(94, 16)
        Me.lblto.TabIndex = 1
        Me.lblto.Text = "No. of Users"
        '
        'lbl_usersNo
        '
        Me.lbl_usersNo.AutoSize = True
        Me.lbl_usersNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usersNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_usersNo.Location = New System.Drawing.Point(19, 18)
        Me.lbl_usersNo.Name = "lbl_usersNo"
        Me.lbl_usersNo.Size = New System.Drawing.Size(49, 24)
        Me.lbl_usersNo.TabIndex = 0
        Me.lbl_usersNo.Text = "0.00"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(558, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(452, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Bill Number"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Bill Date"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "BMonth"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Grand Total"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'frm_mainAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 636)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_mainAdmin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS and Inventory Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents btn_manageUsers As System.Windows.Forms.Button
    Friend WithEvents btn_manageStock As System.Windows.Forms.Button
    Friend WithEvents btn_manageProduct As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_report As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents lblto As System.Windows.Forms.Label
    Friend WithEvents lbl_usersNo As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents lbl_noOfMonthlySales As System.Windows.Forms.Label
    Friend WithEvents lbl_monthlySalesNo As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents lbl_noOfSalesToday As System.Windows.Forms.Label
    Friend WithEvents lbl_salesTodayNo As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_productsNo As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_monthlySales As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_salesToday As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
