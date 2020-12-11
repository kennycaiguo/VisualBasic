<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVariables
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
        Me.txtVariables = New System.Windows.Forms.TextBox()
        Me.LabelTransfer = New System.Windows.Forms.Label()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtVariables
        '
        Me.txtVariables.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVariables.Location = New System.Drawing.Point(109, 97)
        Me.txtVariables.Name = "txtVariables"
        Me.txtVariables.Size = New System.Drawing.Size(100, 22)
        Me.txtVariables.TabIndex = 0
        '
        'LabelTransfer
        '
        Me.LabelTransfer.AutoSize = True
        Me.LabelTransfer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTransfer.Location = New System.Drawing.Point(106, 148)
        Me.LabelTransfer.Name = "LabelTransfer"
        Me.LabelTransfer.Size = New System.Drawing.Size(104, 16)
        Me.LabelTransfer.TabIndex = 1
        Me.LabelTransfer.Text = "Label Caption"
        '
        'btnTransfer
        '
        Me.btnTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.Location = New System.Drawing.Point(109, 200)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(100, 37)
        Me.btnTransfer.TabIndex = 2
        Me.btnTransfer.Text = "Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'frmVariables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 338)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.LabelTransfer)
        Me.Controls.Add(Me.txtVariables)
        Me.Name = "frmVariables"
        Me.Text = "Formulario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtVariables As TextBox
    Friend WithEvents LabelTransfer As Label
    Friend WithEvents btnTransfer As Button
End Class
