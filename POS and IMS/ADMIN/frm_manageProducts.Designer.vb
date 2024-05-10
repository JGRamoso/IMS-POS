<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_manageProducts
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pic_barcode = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_totalPrice = New System.Windows.Forms.TextBox()
        Me.cbo_tax = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_addGroup = New System.Windows.Forms.Button()
        Me.cbo_group = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_searchProCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_proPrice = New System.Windows.Forms.TextBox()
        Me.txt_proName = New System.Windows.Forms.TextBox()
        Me.txt_proCode = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.pic_barcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 60)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(8, 15)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1012, 465)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 49)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1004, 478)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Product List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column4, Me.Column7, Me.Column8, Me.Column5, Me.Column9})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(998, 419)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 40
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Product Code"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 115
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Product Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Group"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 70
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Price"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 64
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Tax"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 56
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "Total Price"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 98
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Stock"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Barcode"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column9.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txt_search)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(998, 53)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Search"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(84, 16)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(470, 22)
        Me.txt_search.TabIndex = 11
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.pic_barcode)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txt_totalPrice)
        Me.TabPage2.Controls.Add(Me.cbo_tax)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.btn_addGroup)
        Me.TabPage2.Controls.Add(Me.cbo_group)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.btn_clear)
        Me.TabPage2.Controls.Add(Me.btn_edit)
        Me.TabPage2.Controls.Add(Me.btn_delete)
        Me.TabPage2.Controls.Add(Me.btn_save)
        Me.TabPage2.Controls.Add(Me.btn_search)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txt_searchProCode)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txt_proPrice)
        Me.TabPage2.Controls.Add(Me.txt_proName)
        Me.TabPage2.Controls.Add(Me.txt_proCode)
        Me.TabPage2.Location = New System.Drawing.Point(4, 49)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1004, 412)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Manage Products"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(561, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 20)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Barcode"
        '
        'pic_barcode
        '
        Me.pic_barcode.BackColor = System.Drawing.Color.White
        Me.pic_barcode.Location = New System.Drawing.Point(565, 191)
        Me.pic_barcode.Name = "pic_barcode"
        Me.pic_barcode.Size = New System.Drawing.Size(400, 129)
        Me.pic_barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barcode.TabIndex = 22
        Me.pic_barcode.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(561, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Total Price"
        '
        'txt_totalPrice
        '
        Me.txt_totalPrice.Location = New System.Drawing.Point(661, 126)
        Me.txt_totalPrice.Name = "txt_totalPrice"
        Me.txt_totalPrice.Size = New System.Drawing.Size(304, 22)
        Me.txt_totalPrice.TabIndex = 20
        '
        'cbo_tax
        '
        Me.cbo_tax.FormattingEnabled = True
        Me.cbo_tax.Items.AddRange(New Object() {"5", "9", "12", "18", "24", "28"})
        Me.cbo_tax.Location = New System.Drawing.Point(164, 296)
        Me.cbo_tax.Name = "cbo_tax"
        Me.cbo_tax.Size = New System.Drawing.Size(356, 24)
        Me.cbo_tax.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(33, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Tax %"
        '
        'btn_addGroup
        '
        Me.btn_addGroup.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_addGroup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addGroup.FlatAppearance.BorderSize = 0
        Me.btn_addGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addGroup.ForeColor = System.Drawing.Color.White
        Me.btn_addGroup.Location = New System.Drawing.Point(473, 210)
        Me.btn_addGroup.Name = "btn_addGroup"
        Me.btn_addGroup.Size = New System.Drawing.Size(46, 25)
        Me.btn_addGroup.TabIndex = 17
        Me.btn_addGroup.Text = "Add"
        Me.btn_addGroup.UseVisualStyleBackColor = False
        '
        'cbo_group
        '
        Me.cbo_group.FormattingEnabled = True
        Me.cbo_group.Location = New System.Drawing.Point(164, 211)
        Me.cbo_group.Name = "cbo_group"
        Me.cbo_group.Size = New System.Drawing.Size(304, 24)
        Me.cbo_group.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Product Group"
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Gray
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.White
        Me.btn_clear.Location = New System.Drawing.Point(847, 337)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(118, 51)
        Me.btn_clear.TabIndex = 14
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.Location = New System.Drawing.Point(599, 337)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(118, 51)
        Me.btn_edit.TabIndex = 13
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(723, 337)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(118, 51)
        Me.btn_delete.TabIndex = 12
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Green
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(475, 337)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(118, 51)
        Me.btn_save.TabIndex = 11
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.White
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Location = New System.Drawing.Point(718, 38)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(92, 33)
        Me.btn_search.TabIndex = 10
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(206, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Product Code"
        '
        'txt_searchProCode
        '
        Me.txt_searchProCode.Location = New System.Drawing.Point(330, 43)
        Me.txt_searchProCode.Name = "txt_searchProCode"
        Me.txt_searchProCode.Size = New System.Drawing.Size(371, 22)
        Me.txt_searchProCode.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Product Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Product Code"
        '
        'txt_proPrice
        '
        Me.txt_proPrice.Location = New System.Drawing.Point(164, 254)
        Me.txt_proPrice.Name = "txt_proPrice"
        Me.txt_proPrice.Size = New System.Drawing.Size(356, 22)
        Me.txt_proPrice.TabIndex = 2
        '
        'txt_proName
        '
        Me.txt_proName.Location = New System.Drawing.Point(164, 169)
        Me.txt_proName.Name = "txt_proName"
        Me.txt_proName.Size = New System.Drawing.Size(356, 22)
        Me.txt_proName.TabIndex = 1
        '
        'txt_proCode
        '
        Me.txt_proCode.Location = New System.Drawing.Point(164, 126)
        Me.txt_proCode.Name = "txt_proCode"
        Me.txt_proCode.Size = New System.Drawing.Size(356, 22)
        Me.txt_proCode.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Black
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1012, 60)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(3, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(950, 56)
        Me.Panel2.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(3, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(241, 31)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Manage Products"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_manageProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1012, 525)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_manageProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Products"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.pic_barcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_searchProCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_proPrice As System.Windows.Forms.TextBox
    Friend WithEvents txt_proName As System.Windows.Forms.TextBox
    Friend WithEvents txt_proCode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_tax As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_addGroup As System.Windows.Forms.Button
    Friend WithEvents cbo_group As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pic_barcode As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_totalPrice As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
