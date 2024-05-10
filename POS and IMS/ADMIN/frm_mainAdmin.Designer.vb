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
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.Panel2.Location = New System.Drawing.Point(0, 549)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1064, 49)
        Me.Panel2.TabIndex = 1
        '
        'frm_mainAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 598)
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
End Class
