' Programmed by Faye Bickerton
Public Class AlarmClockForm
    ' Some globals
    Dim alarm_time As Date
    Dim current_time As Date
    Dim alarm_set As Boolean

    ' our tick event handler subroutine
    Private Sub alarmTimer_Tick(sender As Object, e As EventArgs) Handles alarmTimer.Tick
        ' get the current time
        current_time = Date.Now
        ' output it on the current time label in the form
        currentTimeLabel.Text = String.Format("{0:hh:mm:ss tt}", current_time)
        ' If the alarm is set do some stuff
        If alarm_set Then
            ' if the current time is equal to or greater then the set alarm time do stuff
            If current_time >= alarm_time Then
                alarm_set = False ' unmark the alarm as set
                Beep() ' Beep?
                MessageBox.Show("Alarm!", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ' Alarm User
                setButton.Enabled = True ' enable set button
                resetButton.Enabled = False ' disable reset button
            End If
        End If
    End Sub

    ' our set button click handler subroutine
    Private Sub setButton_Click(sender As Object, e As EventArgs) Handles setButton.Click
        alarm_time = alarm_DTP.Value ' get the alarm time from the form
        resetButton.Enabled = True ' enable the reset button
        setButton.Enabled = False ' disable the set button
        alarm_set = True ' mark the alarm as set
    End Sub

    ' Our reset button click handler subroutine
    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        setButton.Enabled = True ' enable the set button
        resetButton.Enabled = False ' disable the reset button
        alarm_set = False ' unmark the alarm as set
    End Sub

    ' on form load disable the reset button and display the time
    Private Sub AlarmClockForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        resetButton.Enabled = False
        currentTimeLabel.Text = String.Format("{0:hh:mm:ss tt}", Date.Now)
    End Sub
End Class ' AlarmClockForm

' **************************************************************************
' * (C) Copyright 1992-2013 by Deitel & Associates, Inc. and               *
' * Pearson Education, Inc. All Rights Reserved.                           *
' *                                                                        *
' * DISCLAIMER: The authors and publisher of this book have used their     *
' * best efforts in preparing the book. These efforts include the          *
' * development, research, and testing of the theories and programs        *
' * to determine their effectiveness. The authors and publisher make       *
' * no warranty of any kind, expressed or implied, with regard to these    *
' * programs or to the documentation contained in these books. The authors *
' * and publisher shall not be liable in any event for incidental or       *
' * consequential damages in connection with, or arising out of, the       *
' * furnishing, performance, or use of these programs.                     *
' **************************************************************************