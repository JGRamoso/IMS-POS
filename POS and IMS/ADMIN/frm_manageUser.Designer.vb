<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_manageUser
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.cbo_role = New System.Windows.Forms.ComboBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Role"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Name"
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.DarkRed
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(315, 199)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(188, 42)
        Me.btn_cancel.TabIndex = 13
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_register
        '
        Me.btn_register.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_register.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_register.FlatAppearance.BorderSize = 0
        Me.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_register.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_register.ForeColor = System.Drawing.Color.White
        Me.btn_register.Location = New System.Drawing.Point(122, 199)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(188, 42)
        Me.btn_register.TabIndex = 12
        Me.btn_register.Text = "Register"
        Me.btn_register.UseVisualStyleBackColor = False
        '
        'cbo_role
        '
        Me.cbo_role.FormattingEnabled = True
        Me.cbo_role.Items.AddRange(New Object() {"ADMIN", "CASHIER"})
        Me.cbo_role.Location = New System.Drawing.Point(122, 157)
        Me.cbo_role.Name = "cbo_role"
        Me.cbo_role.Size = New System.Drawing.Size(381, 21)
        Me.cbo_role.TabIndex = 11
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(122, 72)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(381, 20)
        Me.txt_username.TabIndex = 9
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(122, 114)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(381, 20)
        Me.txt_password.TabIndex = 10
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(122, 31)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(381, 20)
        Me.txt_name.TabIndex = 8
        '
        'frm_manageUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 261)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_register)
        Me.Controls.Add(Me.cbo_role)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_name)
        Me.Name = "frm_manageUser"
        Me.Text = "Register User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_register As System.Windows.Forms.Button
    Friend WithEvents cbo_role As System.Windows.Forms.ComboBox
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
End Class
