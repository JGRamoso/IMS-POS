﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_discount
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
        Me.txt_discount = New System.Windows.Forms.TextBox()
        Me.btn_updateDiscount = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_discount
        '
        Me.txt_discount.Location = New System.Drawing.Point(12, 39)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Size = New System.Drawing.Size(338, 22)
        Me.txt_discount.TabIndex = 0
        '
        'btn_updateDiscount
        '
        Me.btn_updateDiscount.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_updateDiscount.FlatAppearance.BorderSize = 0
        Me.btn_updateDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_updateDiscount.ForeColor = System.Drawing.Color.White
        Me.btn_updateDiscount.Location = New System.Drawing.Point(12, 67)
        Me.btn_updateDiscount.Name = "btn_updateDiscount"
        Me.btn_updateDiscount.Size = New System.Drawing.Size(338, 41)
        Me.btn_updateDiscount.TabIndex = 1
        Me.btn_updateDiscount.Text = "Update Discount"
        Me.btn_updateDiscount.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Discount %"
        '
        'frm_discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(366, 119)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_updateDiscount)
        Me.Controls.Add(Me.txt_discount)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_discount"
        Me.Text = "Discount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_discount As System.Windows.Forms.TextBox
    Friend WithEvents btn_updateDiscount As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
