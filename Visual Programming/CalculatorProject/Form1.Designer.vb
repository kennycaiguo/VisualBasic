<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculator
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
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btn_sum = New System.Windows.Forms.Button()
        Me.btn_equals = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(98, 96)
        Me.txtDisplay.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(292, 29)
        Me.txtDisplay.TabIndex = 0
        '
        'btn_sum
        '
        Me.btn_sum.Location = New System.Drawing.Point(336, 185)
        Me.btn_sum.Name = "btn_sum"
        Me.btn_sum.Size = New System.Drawing.Size(54, 34)
        Me.btn_sum.TabIndex = 2
        Me.btn_sum.Text = "+"
        Me.btn_sum.UseVisualStyleBackColor = True
        '
        'btn_equals
        '
        Me.btn_equals.Location = New System.Drawing.Point(336, 240)
        Me.btn_equals.Name = "btn_equals"
        Me.btn_equals.Size = New System.Drawing.Size(54, 34)
        Me.btn_equals.TabIndex = 3
        Me.btn_equals.Text = "="
        Me.btn_equals.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.Location = New System.Drawing.Point(336, 307)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(54, 34)
        Me.clear.TabIndex = 4
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(172, 240)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(54, 34)
        Me.btn4.TabIndex = 5
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(98, 240)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(54, 34)
        Me.btn3.TabIndex = 6
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(245, 185)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(54, 34)
        Me.btn2.TabIndex = 7
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(172, 185)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(54, 34)
        Me.btn1.TabIndex = 8
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(98, 185)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(54, 34)
        Me.btn0.TabIndex = 9
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(245, 240)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(54, 34)
        Me.btn5.TabIndex = 10
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(172, 305)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(54, 34)
        Me.btn7.TabIndex = 11
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(98, 305)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(54, 34)
        Me.btn6.TabIndex = 12
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(245, 305)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(54, 34)
        Me.btn8.TabIndex = 13
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(172, 372)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(54, 34)
        Me.btn9.TabIndex = 14
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(511, 555)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.btn_equals)
        Me.Controls.Add(Me.btn_sum)
        Me.Controls.Add(Me.txtDisplay)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btn_sum As Button
    Friend WithEvents btn_equals As Button
    Friend WithEvents clear As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
End Class
