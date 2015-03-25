<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlarmClockForm
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
        Me.components = New System.ComponentModel.Container()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.setButton = New System.Windows.Forms.Button()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.alarmTimer = New System.Windows.Forms.Timer(Me.components)
        Me.alarmLabel = New System.Windows.Forms.Label()
        Me.currentTimeLabel = New System.Windows.Forms.Label()
        Me.alarm_DTP = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Location = New System.Drawing.Point(11, 15)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(45, 20)
        Me.timeLabel.TabIndex = 0
        Me.timeLabel.Text = "Time:"
        '
        'setButton
        '
        Me.setButton.Location = New System.Drawing.Point(173, 11)
        Me.setButton.Name = "setButton"
        Me.setButton.Size = New System.Drawing.Size(55, 23)
        Me.setButton.TabIndex = 2
        Me.setButton.Text = "Set"
        Me.setButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Enabled = False
        Me.resetButton.Location = New System.Drawing.Point(173, 47)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(55, 23)
        Me.resetButton.TabIndex = 3
        Me.resetButton.Text = "Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'alarmTimer
        '
        Me.alarmTimer.Enabled = True
        '
        'alarmLabel
        '
        Me.alarmLabel.AutoSize = True
        Me.alarmLabel.Location = New System.Drawing.Point(12, 50)
        Me.alarmLabel.Name = "alarmLabel"
        Me.alarmLabel.Size = New System.Drawing.Size(52, 20)
        Me.alarmLabel.TabIndex = 4
        Me.alarmLabel.Text = "Alarm:"
        '
        'currentTimeLabel
        '
        Me.currentTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.currentTimeLabel.Location = New System.Drawing.Point(59, 11)
        Me.currentTimeLabel.Name = "currentTimeLabel"
        Me.currentTimeLabel.Size = New System.Drawing.Size(85, 23)
        Me.currentTimeLabel.TabIndex = 5
        Me.currentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'alarm_DTP
        '
        Me.alarm_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.alarm_DTP.Location = New System.Drawing.Point(59, 45)
        Me.alarm_DTP.Name = "alarm_DTP"
        Me.alarm_DTP.ShowUpDown = True
        Me.alarm_DTP.Size = New System.Drawing.Size(85, 27)
        Me.alarm_DTP.TabIndex = 6
        '
        'AlarmClockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 79)
        Me.Controls.Add(Me.alarm_DTP)
        Me.Controls.Add(Me.currentTimeLabel)
        Me.Controls.Add(Me.alarmLabel)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.setButton)
        Me.Controls.Add(Me.timeLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AlarmClockForm"
        Me.Text = "Alarm Clock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timeLabel As System.Windows.Forms.Label
    Friend WithEvents setButton As System.Windows.Forms.Button
    Friend WithEvents resetButton As System.Windows.Forms.Button
    Friend WithEvents alarmTimer As System.Windows.Forms.Timer
    Friend WithEvents alarmLabel As System.Windows.Forms.Label
    Friend WithEvents currentTimeLabel As System.Windows.Forms.Label
    Friend WithEvents alarm_DTP As System.Windows.Forms.DateTimePicker

End Class
