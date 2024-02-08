Public Class Form1
    Dim cs As New coinslot
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
End Class
