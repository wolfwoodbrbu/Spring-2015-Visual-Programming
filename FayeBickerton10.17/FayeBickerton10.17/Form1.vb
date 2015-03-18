' Programed by Faye Bickerton

Public Class Restraunt_Bill
    Private Sub add_item_Button_Click(sender As Object, e As EventArgs) Handles add_item_Button.Click
        ' Get Form Data
        Dim quanity As Integer = Val(quanity_TextBox.Text)
        Dim item As String = menu_item_TextBox.Text
        Dim price As Double = Val(price_TextBox.Text)
        ' This flag is used to display the error message box if the input is invalid
        Dim flag As Boolean = True

        ' validate item has a name
        If Not item = String.Empty Then
            ' validate there is a quantity greater then 0
            If quanity > 0 Then
                ' Validate there is a price that's greater then 0
                If price > 0 Then
                    ' Add the data to the List Box
                    quantity_ListBox.Items.Add(quanity)
                    menu_item_ListBox.Items.Add(item)
                    price_ListBox.Items.Add(price)
                    ' mark the flag to not display the error message
                    flag = False

                    ' clear the text boxes
                    quanity_TextBox.Text = String.Empty
                    menu_item_TextBox.Text = String.Empty
                    price_TextBox.Text = String.Empty
                End If
            End If
        End If

        ' display a error message if the item is invalid
        If flag Then
            MessageBox.Show("Invalid Item!", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub total_Button_Click(sender As Object, e As EventArgs) Handles total_Button.Click
        Dim total As Double = 0
        Dim count As Integer = 0

        'get the count of how many items are in the lists 
        count = quantity_ListBox.Items.Count

        ' calculate the total from each line
        For i As Integer = 0 To (count - 1) Step 1
            total = total + (Val(quantity_ListBox.Items.Item(i) * Val(price_ListBox.Items.Item(i))))
        Next

        ' Display the total
        total_Label.Text = String.Format("{0:C}", total)

    End Sub

End Class
