Public Class MilesPerGallonForm

    ' The mpg function
    ' checks if gallons is 0 to negate NaN problems
    ' returns miles divided by gallons
    Private Function MilesPerGallon(miles As Double, gallons As Double)
        If gallons = 0 Then
            Return 0
        End If
        Return (miles / gallons)
    End Function



    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        ' make a var for mpg
        Dim mpg As Double = 0
        ' make vars for our textbox values and get there data
        Dim miles As Double = Val(milesTextBox.Text)
        Dim gallons As Double = Val(gallonsTextBox.Text)

        ' get the mpg
        mpg = MilesPerGallon(miles, gallons)

        ' Output the mpg with a fixed decimal persision of 2
        outputLabel.Text = String.Format("{0:F}", mpg)

    End Sub
End Class ' MilesPerGallonForm




' **************************************************************************
' * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
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