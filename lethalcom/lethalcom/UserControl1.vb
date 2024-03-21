Public Class UserControl1
    Public Property moon As Integer

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If moon = 0 Then
            PictureBox1.BackColor = Color.Green
        End If
    End Sub
End Class
