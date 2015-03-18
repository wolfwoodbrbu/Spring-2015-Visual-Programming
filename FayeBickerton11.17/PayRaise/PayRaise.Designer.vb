<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayRaiseForm
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
        Me.wageLabel = New System.Windows.Forms.Label()
        Me.wageTextBox = New System.Windows.Forms.TextBox()
        Me.raiseLabel = New System.Windows.Forms.Label()
        Me.yearsLabel = New System.Windows.Forms.Label()
        Me.calculate_Button = New System.Windows.Forms.Button()
        Me.earningsLabel = New System.Windows.Forms.Label()
        Me.raise_UpDown = New System.Windows.Forms.NumericUpDown()
        Me.years_UpDown = New System.Windows.Forms.NumericUpDown()
        Me.result_TextBox = New System.Windows.Forms.TextBox()
        CType(Me.raise_UpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.years_UpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wageLabel
        '
        Me.wageLabel.AutoSize = True
        Me.wageLabel.Location = New System.Drawing.Point(13, 19)
        Me.wageLabel.Name = "wageLabel"
        Me.wageLabel.Size = New System.Drawing.Size(198, 25)
        Me.wageLabel.TabIndex = 0
        Me.wageLabel.Text = "Starting wage per hour:"
        '
        'wageTextBox
        '
        Me.wageTextBox.Location = New System.Drawing.Point(150, 16)
        Me.wageTextBox.Name = "wageTextBox"
        Me.wageTextBox.Size = New System.Drawing.Size(60, 31)
        Me.wageTextBox.TabIndex = 1
        Me.wageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'raiseLabel
        '
        Me.raiseLabel.AutoSize = True
        Me.raiseLabel.Location = New System.Drawing.Point(13, 52)
        Me.raiseLabel.Name = "raiseLabel"
        Me.raiseLabel.Size = New System.Drawing.Size(193, 25)
        Me.raiseLabel.TabIndex = 2
        Me.raiseLabel.Text = "Amount of raise (in %):"
        '
        'yearsLabel
        '
        Me.yearsLabel.AutoSize = True
        Me.yearsLabel.Location = New System.Drawing.Point(13, 87)
        Me.yearsLabel.Name = "yearsLabel"
        Me.yearsLabel.Size = New System.Drawing.Size(58, 25)
        Me.yearsLabel.TabIndex = 3
        Me.yearsLabel.Text = "Years:"
        '
        'calculate_Button
        '
        Me.calculate_Button.Location = New System.Drawing.Point(234, 16)
        Me.calculate_Button.Name = "calculate_Button"
        Me.calculate_Button.Size = New System.Drawing.Size(75, 23)
        Me.calculate_Button.TabIndex = 6
        Me.calculate_Button.Text = "Calculate"
        Me.calculate_Button.UseVisualStyleBackColor = True
        '
        'earningsLabel
        '
        Me.earningsLabel.AutoSize = True
        Me.earningsLabel.Location = New System.Drawing.Point(13, 132)
        Me.earningsLabel.Name = "earningsLabel"
        Me.earningsLabel.Size = New System.Drawing.Size(135, 25)
        Me.earningsLabel.TabIndex = 7
        Me.earningsLabel.Text = "Yearly earnings:"
        '
        'raise_UpDown
        '
        Me.raise_UpDown.DecimalPlaces = 1
        Me.raise_UpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.raise_UpDown.Location = New System.Drawing.Point(150, 47)
        Me.raise_UpDown.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.raise_UpDown.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.raise_UpDown.Name = "raise_UpDown"
        Me.raise_UpDown.Size = New System.Drawing.Size(61, 31)
        Me.raise_UpDown.TabIndex = 8
        Me.raise_UpDown.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'years_UpDown
        '
        Me.years_UpDown.Location = New System.Drawing.Point(150, 80)
        Me.years_UpDown.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.years_UpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.years_UpDown.Name = "years_UpDown"
        Me.years_UpDown.Size = New System.Drawing.Size(61, 31)
        Me.years_UpDown.TabIndex = 9
        Me.years_UpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'result_TextBox
        '
        Me.result_TextBox.Location = New System.Drawing.Point(18, 160)
        Me.result_TextBox.Multiline = True
        Me.result_TextBox.Name = "result_TextBox"
        Me.result_TextBox.ReadOnly = True
        Me.result_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.result_TextBox.Size = New System.Drawing.Size(295, 116)
        Me.result_TextBox.TabIndex = 10
        '
        'PayRaiseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 288)
        Me.Controls.Add(Me.result_TextBox)
        Me.Controls.Add(Me.years_UpDown)
        Me.Controls.Add(Me.raise_UpDown)
        Me.Controls.Add(Me.earningsLabel)
        Me.Controls.Add(Me.calculate_Button)
        Me.Controls.Add(Me.yearsLabel)
        Me.Controls.Add(Me.raiseLabel)
        Me.Controls.Add(Me.wageTextBox)
        Me.Controls.Add(Me.wageLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PayRaiseForm"
        Me.Text = "Pay Raise Calculator"
        CType(Me.raise_UpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.years_UpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wageLabel As System.Windows.Forms.Label
    Friend WithEvents wageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents raiseLabel As System.Windows.Forms.Label
    Friend WithEvents yearsLabel As System.Windows.Forms.Label
    Friend WithEvents calculate_Button As System.Windows.Forms.Button
    Friend WithEvents earningsLabel As System.Windows.Forms.Label
    Friend WithEvents raise_UpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents years_UpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents result_TextBox As System.Windows.Forms.TextBox

End Class
