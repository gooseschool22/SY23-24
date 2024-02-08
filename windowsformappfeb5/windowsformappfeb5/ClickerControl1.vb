Public Class ClickerControl1
    Dim c As New Clicker
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        c.click()
        TextBox1.Text = c.count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        c.reset()
        TextBox1.Text = c.count
    End Sub
End Class
