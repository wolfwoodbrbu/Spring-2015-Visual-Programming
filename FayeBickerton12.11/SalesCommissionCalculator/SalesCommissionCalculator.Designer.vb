<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesCommissionCalculatorForm
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
        Me.itemsLabel = New System.Windows.Forms.Label()
        Me.salesLabel = New System.Windows.Forms.Label()
        Me.commissionLabel = New System.Windows.Forms.Label()
        Me.earningsLabel = New System.Windows.Forms.Label()
        Me.salesResultLabel = New System.Windows.Forms.Label()
        Me.commissionResultLabel = New System.Windows.Forms.Label()
        Me.earningsResultLabel = New System.Windows.Forms.Label()
        Me.itemsTextBox = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'itemsLabel
        '
        Me.itemsLabel.AutoSize = True
        Me.itemsLabel.Location = New System.Drawing.Point(14, 19)
        Me.itemsLabel.Name = "itemsLabel"
        Me.itemsLabel.Size = New System.Drawing.Size(156, 20)
        Me.itemsLabel.TabIndex = 0
        Me.itemsLabel.Text = "Number of items sold:"
        '
        'salesLabel
        '
        Me.salesLabel.AutoSize = True
        Me.salesLabel.Location = New System.Drawing.Point(14, 54)
        Me.salesLabel.Name = "salesLabel"
        Me.salesLabel.Size = New System.Drawing.Size(84, 20)
        Me.salesLabel.TabIndex = 1
        Me.salesLabel.Text = "Gross sales:"
        '
        'commissionLabel
        '
        Me.commissionLabel.AutoSize = True
        Me.commissionLabel.Location = New System.Drawing.Point(14, 88)
        Me.commissionLabel.Name = "commissionLabel"
        Me.commissionLabel.Size = New System.Drawing.Size(119, 20)
        Me.commissionLabel.TabIndex = 2
        Me.commissionLabel.Text = "Commission (%):"
        '
        'earningsLabel
        '
        Me.earningsLabel.AutoSize = True
        Me.earningsLabel.Location = New System.Drawing.Point(14, 123)
        Me.earningsLabel.Name = "earningsLabel"
        Me.earningsLabel.Size = New System.Drawing.Size(68, 20)
        Me.earningsLabel.TabIndex = 3
        Me.earningsLabel.Text = "Earnings:"
        '
        'salesResultLabel
        '
        Me.salesResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.salesResultLabel.Location = New System.Drawing.Point(147, 50)
        Me.salesResultLabel.Name = "salesResultLabel"
        Me.salesResultLabel.Size = New System.Drawing.Size(75, 23)
        Me.salesResultLabel.TabIndex = 4
        Me.salesResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'commissionResultLabel
        '
        Me.commissionResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.commissionResultLabel.Location = New System.Drawing.Point(147, 84)
        Me.commissionResultLabel.Name = "commissionResultLabel"
        Me.commissionResultLabel.Size = New System.Drawing.Size(75, 23)
        Me.commissionResultLabel.TabIndex = 5
        Me.commissionResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'earningsResultLabel
        '
        Me.earningsResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.earningsResultLabel.Location = New System.Drawing.Point(147, 119)
        Me.earningsResultLabel.Name = "earningsResultLabel"
        Me.earningsResultLabel.Size = New System.Drawing.Size(75, 23)
        Me.earningsResultLabel.TabIndex = 6
        Me.earningsResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'itemsTextBox
        '
        Me.itemsTextBox.Location = New System.Drawing.Point(147, 16)
        Me.itemsTextBox.Name = "itemsTextBox"
        Me.itemsTextBox.Size = New System.Drawing.Size(75, 27)
        Me.itemsTextBox.TabIndex = 7
        Me.itemsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(147, 165)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 8
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'SalesCommissionCalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 204)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.itemsTextBox)
        Me.Controls.Add(Me.earningsResultLabel)
        Me.Controls.Add(Me.commissionResultLabel)
        Me.Controls.Add(Me.salesResultLabel)
        Me.Controls.Add(Me.earningsLabel)
        Me.Controls.Add(Me.commissionLabel)
        Me.Controls.Add(Me.salesLabel)
        Me.Controls.Add(Me.itemsLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SalesCommissionCalculatorForm"
        Me.Text = "Sales Commission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents itemsLabel As System.Windows.Forms.Label
   Friend WithEvents salesLabel As System.Windows.Forms.Label
   Friend WithEvents commissionLabel As System.Windows.Forms.Label
   Friend WithEvents earningsLabel As System.Windows.Forms.Label
   Friend WithEvents salesResultLabel As System.Windows.Forms.Label
   Friend WithEvents commissionResultLabel As System.Windows.Forms.Label
   Friend WithEvents earningsResultLabel As System.Windows.Forms.Label
   Friend WithEvents itemsTextBox As System.Windows.Forms.TextBox
   Friend WithEvents calculateButton As System.Windows.Forms.Button

End Class
