<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MilesPerGallonForm
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
      Me.milesLabel = New System.Windows.Forms.Label
      Me.gallonsLabel = New System.Windows.Forms.Label
      Me.mpgLabel = New System.Windows.Forms.Label
      Me.milesTextBox = New System.Windows.Forms.TextBox
      Me.gallonsTextBox = New System.Windows.Forms.TextBox
      Me.outputLabel = New System.Windows.Forms.Label
      Me.calculateButton = New System.Windows.Forms.Button
      Me.SuspendLayout()
      '
      'milesLabel
      '
      Me.milesLabel.AutoSize = True
      Me.milesLabel.Location = New System.Drawing.Point(11, 15)
      Me.milesLabel.Name = "milesLabel"
      Me.milesLabel.Size = New System.Drawing.Size(74, 15)
      Me.milesLabel.TabIndex = 0
      Me.milesLabel.Text = "Miles driven:"
      '
      'gallonsLabel
      '
      Me.gallonsLabel.AutoSize = True
      Me.gallonsLabel.Location = New System.Drawing.Point(11, 50)
      Me.gallonsLabel.Name = "gallonsLabel"
      Me.gallonsLabel.Size = New System.Drawing.Size(77, 15)
      Me.gallonsLabel.TabIndex = 1
      Me.gallonsLabel.Text = "Gallons used:"
      '
      'mpgLabel
      '
      Me.mpgLabel.AutoSize = True
      Me.mpgLabel.Location = New System.Drawing.Point(11, 86)
      Me.mpgLabel.Name = "mpgLabel"
      Me.mpgLabel.Size = New System.Drawing.Size(94, 15)
      Me.mpgLabel.TabIndex = 2
      Me.mpgLabel.Text = "Miles per gallon:"
      '
      'milesTextBox
      '
      Me.milesTextBox.Location = New System.Drawing.Point(121, 12)
      Me.milesTextBox.Name = "milesTextBox"
      Me.milesTextBox.Size = New System.Drawing.Size(70, 23)
      Me.milesTextBox.TabIndex = 3
      Me.milesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'gallonsTextBox
      '
      Me.gallonsTextBox.Location = New System.Drawing.Point(121, 47)
      Me.gallonsTextBox.Name = "gallonsTextBox"
      Me.gallonsTextBox.Size = New System.Drawing.Size(70, 23)
      Me.gallonsTextBox.TabIndex = 4
      Me.gallonsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'outputLabel
      '
      Me.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.outputLabel.Location = New System.Drawing.Point(121, 82)
      Me.outputLabel.Name = "outputLabel"
      Me.outputLabel.Size = New System.Drawing.Size(70, 23)
      Me.outputLabel.TabIndex = 5
      Me.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'calculateButton
      '
      Me.calculateButton.Location = New System.Drawing.Point(98, 125)
      Me.calculateButton.Name = "calculateButton"
      Me.calculateButton.Size = New System.Drawing.Size(93, 23)
      Me.calculateButton.TabIndex = 6
      Me.calculateButton.Text = "Calculate MPG"
      Me.calculateButton.UseVisualStyleBackColor = True
      '
      'MilesPerGallonForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(203, 160)
      Me.Controls.Add(Me.calculateButton)
      Me.Controls.Add(Me.outputLabel)
      Me.Controls.Add(Me.gallonsTextBox)
      Me.Controls.Add(Me.milesTextBox)
      Me.Controls.Add(Me.mpgLabel)
      Me.Controls.Add(Me.gallonsLabel)
      Me.Controls.Add(Me.milesLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "MilesPerGallonForm"
      Me.Text = "Miles Per Gallon"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents milesLabel As System.Windows.Forms.Label
   Friend WithEvents gallonsLabel As System.Windows.Forms.Label
   Friend WithEvents mpgLabel As System.Windows.Forms.Label
   Friend WithEvents milesTextBox As System.Windows.Forms.TextBox
   Friend WithEvents gallonsTextBox As System.Windows.Forms.TextBox
   Friend WithEvents outputLabel As System.Windows.Forms.Label
   Friend WithEvents calculateButton As System.Windows.Forms.Button

End Class
