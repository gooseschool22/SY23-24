Public Class productControl
    Public Property productID As String
    Public Property price As Decimal
    Public Property count As Integer
    Public Property picture As Image

    Private Sub productControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = picture
        IDLabel.Text = productID
        PriceLabel.Text = price.ToString("C2")
    End Sub
    Public Sub buy()
        If count > 0 Then
            count = count - 1
        End If
        If count = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
