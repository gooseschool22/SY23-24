Public Class UserControl1
    Public Property moon As Integer

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If moon = 0 Then
            PictureBox1.BackColor = Color.Green
        End If
        If moon = 1 Then
            PictureBox1.BackColor = Color.Gold
        End If
        If moon = 2 Then
            PictureBox1.BackColor = Color.Blue
        End If
    End Sub
End Class
