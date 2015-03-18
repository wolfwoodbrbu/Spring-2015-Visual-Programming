' Programed by Faye Bickerton

Public Class PayRaiseForm
    ' Make some constants for the program.
    Private Const WEEKS As Integer = 52
    Private Const HOURS As Integer = 40

    Private Sub calculate_Button_Click(sender As Object, e As EventArgs) Handles calculate_Button.Click
        ' Get Values from Form
        Dim wage As Double = Val(wageTextBox.Text)
        Dim raise As Double = Val(raise_UpDown.Value)
        Dim years As Integer = Val(years_UpDown.Value)
        ' Make a total varible
        Dim total As Double = 0
        ' Make a string and fill it for the first line of the Text Box
        Dim resultString As String = "Year" & ControlChars.Tab & "Amount" & ControlChars.CrLf

        ' Get our base total
        total = wage * WEEKS * HOURS

        ' Make the raise percentage actually a percentage
        raise = raise / 100

        ' Loop for each year and add the new total to the resultString
        For i As Integer = 1 To years Step 1
            total = total + total * (raise * (i - 1))
            resultString = resultString & i.ToString & ControlChars.Tab & String.Format("{0:C}", total) & ControlChars.CrLf
        Next

        ' Display the resultString in the result_TextBox
        result_TextBox.Text = resultString

    End Sub
End Class ' PayRaiseForm

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