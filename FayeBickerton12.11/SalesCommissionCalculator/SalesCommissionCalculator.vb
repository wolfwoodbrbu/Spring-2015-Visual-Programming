Public Class SalesCommissionCalculatorForm
    Private Const UNIT_PRICE As Double = 10.0 ' The price of each unit

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim units As Integer = Val(itemsTextBox.Text)   ' Get the number of items
        Dim commission As Double = 0                    ' make a var for the % commision
        Dim gross As Double = units * UNIT_PRICE        ' Calculate the gross sales of the sale
        Dim earnings As Double = 0                      ' make  a var for the earnings

        salesResultLabel.Text = String.Format("{0:C}", gross)   ' output the gross

        Select Case units   ' Our Case statement to select the commission rate
            Case 1 To 10
                commission = 0.01
                commissionResultLabel.Text() = (100 * commission)
            Case 10 To 40
                commission = 0.02
                commissionResultLabel.Text() = (100 * commission)
            Case 41 To 100
                commission = 0.04
                commissionResultLabel.Text() = (100 * commission)
            Case Is > 100
                commission = 0.08
                commissionResultLabel.Text() = (100 * commission)
            Case Else
                commission = 0
                commissionResultLabel.Text() = (100 * commission)
        End Select

        earnings = gross * commission   ' Calculate our sales persons earnings

        earningsResultLabel.Text = String.Format("{0:C}", earnings) ' display the earnings

    End Sub


    
    Private Sub itemsTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles itemsTextBox.KeyDown
        ' handles an Enter press when in the items textbox
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            calculateButton_Click(sender, e)
        End If
    End Sub
End Class ' SalesCommissionCalculatorForm

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