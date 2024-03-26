Public Class UserControl1
    Public Property moon As Integer

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If moon = 0 Then
            PictureBox1.Image = ImageList2.Images(0)
        End If
        If moon = 1 Then
            PictureBox1.Image = ImageList2.Images(1)
        End If
        If moon = 2 Then
            PictureBox1.Image = ImageList2.Images(2)
        End If
        If moon = 3 Then
            PictureBox1.Image = ImageList2.Images(3)
        End If
        If moon = 4 Then
            PictureBox1.Image = ImageList2.Images(4)
        End If
        If moon = 5 Then
            PictureBox1.Image = ImageList2.Images(5)
        End If
        If moon = 6 Then
            PictureBox1.Image = ImageList2.Images(6)
        End If
        If moon = 7 Then
            PictureBox1.Image = ImageList2.Images(7)
        End If
    End Sub
End Class
