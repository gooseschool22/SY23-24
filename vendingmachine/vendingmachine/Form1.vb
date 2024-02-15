Public Class Form1
    Dim WithEvents cs As New coinslot
    Private Sub dollarButton_Click(sender As Object, e As EventArgs) Handles dollarButton.Click
        cs.insertdollar()
        totallabel.Text = cs.total.ToString("C2")
    End Sub
    Private Sub quarterButton_Click(sender As Object, e As EventArgs) Handles quarterButton.Click
        cs.insertquarter()
        totallabel.Text = cs.total.ToString("C2")
    End Sub
    Private Sub dimeButton_Click(sender As Object, e As EventArgs) Handles dimeButton.Click
        cs.insertdime()
        totallabel.Text = cs.total.ToString("C2")
    End Sub

    Private Sub nickelButton_Click(sender As Object, e As EventArgs) Handles nickelButton.Click
        cs.insertnickel()
        totallabel.Text = cs.total.ToString("C2")
    End Sub

    Private Sub coinreturnButton_Click(sender As Object, e As EventArgs) Handles coinreturnButton.Click
        cs.coinreturn()
        totallabel.Text = cs.total.ToString("C2")
    End Sub
    Private Sub cs_coinreturnevent(d As Integer, q As Integer, dm As Integer, n As Integer) Handles cs.coinreturnevent
        If d > 0 Then
            DollarPictureBox.Visible = True
        Else
            DollarPictureBox.Visible = False
        End If
        If q > 0 Then
            QuarterPictureBox.Visible = True
        Else
            QuarterPictureBox.Visible = False
        End If
        If dm > 0 Then
            DimePictureBox.Visible = True
        Else
            DimePictureBox.Visible = False
        End If
        If n > 0 Then
            NickelPictureBox.Visible = True
        Else
            NickelPictureBox.Visible = False
        End If
    End Sub

    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        Select Case IDTextBox.Text
            Case ProductControl1.productID
                cs.buy(ProductControl1)
            Case ProductControl2.productID
                cs.buy(ProductControl2)
            Case ProductControl3.productID
                cs.buy(ProductControl3)
            Case ProductControl4.productID
                cs.buy(ProductControl4)
            Case ProductControl5.productID
                cs.buy(ProductControl5)
            Case ProductControl6.productID
                cs.buy(ProductControl6)
            Case ProductControl7.productID
                cs.buy(ProductControl7)
            Case ProductControl8.productID
                cs.buy(ProductControl8)
            Case ProductControl9.productID
                cs.buy(ProductControl9)
            Case ProductControl10.productID
                cs.buy(ProductControl10)
            Case ProductControl11.productID
                cs.buy(ProductControl11)
            Case ProductControl12.productID
                cs.buy(ProductControl12)
            Case ProductControl13.productID
                cs.buy(ProductControl13)
            Case ProductControl14.productID
                cs.buy(ProductControl14)
            Case ProductControl15.productID
                cs.buy(ProductControl15)
            Case ProductControl16.productID
                cs.buy(ProductControl16)

            Case Else
        End Select
        totallabel.Text = cs.total.ToString("C2")
    End Sub

    Private Sub cs_dispenseevent(p As Image) Handles cs.dispenseevent
        ProductPictureBox.Image = p
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totallabel.Text = cs.total.ToString("C2")
    End Sub
End Class
