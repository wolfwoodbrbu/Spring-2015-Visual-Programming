<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Restraunt_Bill
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.quanity_TextBox = New System.Windows.Forms.TextBox()
        Me.menu_item_TextBox = New System.Windows.Forms.TextBox()
        Me.price_TextBox = New System.Windows.Forms.TextBox()
        Me.add_item_Button = New System.Windows.Forms.Button()
        Me.total_Button = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.quantity_ListBox = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.menu_item_ListBox = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.price_ListBox = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.total_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quantity:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Menu item:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Price:"
        '
        'quanity_TextBox
        '
        Me.quanity_TextBox.Location = New System.Drawing.Point(118, 22)
        Me.quanity_TextBox.Name = "quanity_TextBox"
        Me.quanity_TextBox.Size = New System.Drawing.Size(169, 26)
        Me.quanity_TextBox.TabIndex = 1
        '
        'menu_item_TextBox
        '
        Me.menu_item_TextBox.Location = New System.Drawing.Point(118, 54)
        Me.menu_item_TextBox.Name = "menu_item_TextBox"
        Me.menu_item_TextBox.Size = New System.Drawing.Size(169, 26)
        Me.menu_item_TextBox.TabIndex = 2
        '
        'price_TextBox
        '
        Me.price_TextBox.Location = New System.Drawing.Point(118, 86)
        Me.price_TextBox.Name = "price_TextBox"
        Me.price_TextBox.Size = New System.Drawing.Size(169, 26)
        Me.price_TextBox.TabIndex = 3
        '
        'add_item_Button
        '
        Me.add_item_Button.Location = New System.Drawing.Point(297, 22)
        Me.add_item_Button.Name = "add_item_Button"
        Me.add_item_Button.Size = New System.Drawing.Size(110, 30)
        Me.add_item_Button.TabIndex = 4
        Me.add_item_Button.Text = "Add Item"
        Me.add_item_Button.UseVisualStyleBackColor = True
        '
        'total_Button
        '
        Me.total_Button.Location = New System.Drawing.Point(297, 58)
        Me.total_Button.Name = "total_Button"
        Me.total_Button.Size = New System.Drawing.Size(110, 30)
        Me.total_Button.TabIndex = 5
        Me.total_Button.Text = "Total Bill"
        Me.total_Button.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Quantity:"
        '
        'quantity_ListBox
        '
        Me.quantity_ListBox.FormattingEnabled = True
        Me.quantity_ListBox.ItemHeight = 20
        Me.quantity_ListBox.Location = New System.Drawing.Point(29, 156)
        Me.quantity_ListBox.Name = "quantity_ListBox"
        Me.quantity_ListBox.Size = New System.Drawing.Size(83, 164)
        Me.quantity_ListBox.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(114, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Menu Item:"
        '
        'menu_item_ListBox
        '
        Me.menu_item_ListBox.FormattingEnabled = True
        Me.menu_item_ListBox.ItemHeight = 20
        Me.menu_item_ListBox.Location = New System.Drawing.Point(118, 156)
        Me.menu_item_ListBox.Name = "menu_item_ListBox"
        Me.menu_item_ListBox.Size = New System.Drawing.Size(169, 164)
        Me.menu_item_ListBox.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(293, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Price:"
        '
        'price_ListBox
        '
        Me.price_ListBox.FormattingEnabled = True
        Me.price_ListBox.ItemHeight = 20
        Me.price_ListBox.Location = New System.Drawing.Point(293, 156)
        Me.price_ListBox.Name = "price_ListBox"
        Me.price_ListBox.Size = New System.Drawing.Size(110, 164)
        Me.price_ListBox.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(193, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Cost:"
        '
        'total_Label
        '
        Me.total_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.total_Label.Location = New System.Drawing.Point(293, 323)
        Me.total_Label.Name = "total_Label"
        Me.total_Label.Size = New System.Drawing.Size(110, 25)
        Me.total_Label.TabIndex = 7
        '
        'Restraunt_Bill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 371)
        Me.Controls.Add(Me.total_Label)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.price_ListBox)
        Me.Controls.Add(Me.menu_item_ListBox)
        Me.Controls.Add(Me.quantity_ListBox)
        Me.Controls.Add(Me.total_Button)
        Me.Controls.Add(Me.add_item_Button)
        Me.Controls.Add(Me.price_TextBox)
        Me.Controls.Add(Me.menu_item_TextBox)
        Me.Controls.Add(Me.quanity_TextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Restraunt_Bill"
        Me.Text = "Restraunt Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents quanity_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents menu_item_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents price_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents add_item_Button As System.Windows.Forms.Button
    Friend WithEvents total_Button As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents quantity_ListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents menu_item_ListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents price_ListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents total_Label As System.Windows.Forms.Label

End Class
