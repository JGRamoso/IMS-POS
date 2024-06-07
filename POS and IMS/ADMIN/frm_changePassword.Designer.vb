<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_changePassword
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
        Me.txt_oldPassword = New System.Windows.Forms.TextBox()
        Me.txt_newPassword = New System.Windows.Forms.TextBox()
        Me.txt_conPassword = New System.Windows.Forms.TextBox()
        Me.btn_changePass = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_oldPassword
        '
        Me.txt_oldPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_oldPassword.Location = New System.Drawing.Point(50, 78)
        Me.txt_oldPassword.Name = "txt_oldPassword"
        Me.txt_oldPassword.Size = New System.Drawing.Size(301, 26)
        Me.txt_oldPassword.TabIndex = 0
        Me.txt_oldPassword.UseSystemPasswordChar = True
        '
        'txt_newPassword
        '
        Me.txt_newPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_newPassword.Location = New System.Drawing.Point(50, 142)
        Me.txt_newPassword.Name = "txt_newPassword"
        Me.txt_newPassword.Size = New System.Drawing.Size(301, 26)
        Me.txt_newPassword.TabIndex = 1
        Me.txt_newPassword.UseSystemPasswordChar = True
        '
        'txt_conPassword
        '
        Me.txt_conPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_conPassword.Location = New System.Drawing.Point(50, 206)
        Me.txt_conPassword.Name = "txt_conPassword"
        Me.txt_conPassword.Size = New System.Drawing.Size(301, 26)
        Me.txt_conPassword.TabIndex = 2
        Me.txt_conPassword.UseSystemPasswordChar = True
        '
        'btn_changePass
        '
        Me.btn_changePass.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_changePass.FlatAppearance.BorderSize = 0
        Me.btn_changePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_changePass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_changePass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_changePass.ForeColor = System.Drawing.Color.White
        Me.btn_changePass.Location = New System.Drawing.Point(97, 255)
        Me.btn_changePass.Name = "btn_changePass"
        Me.btn_changePass.Size = New System.Drawing.Size(209, 60)
        Me.btn_changePass.TabIndex = 3
        Me.btn_changePass.Text = "Change Password"
        Me.btn_changePass.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter OLD Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter NEW Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Confirm NEW Password"
        '
        'frm_changePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(401, 360)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_changePass)
        Me.Controls.Add(Me.txt_conPassword)
        Me.Controls.Add(Me.txt_newPassword)
        Me.Controls.Add(Me.txt_oldPassword)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_changePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_oldPassword As System.Windows.Forms.TextBox
    Friend WithEvents txt_newPassword As System.Windows.Forms.TextBox
    Friend WithEvents txt_conPassword As System.Windows.Forms.TextBox
    Friend WithEvents btn_changePass As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
