Public Class Form1
    Dim m As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReelControl1.spin()
        ReelControl2.spin()
        ReelControl3.spin()
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Label1.Text = ReelControl1.itemValue
        Label2.Text = ReelControl2.itemValue
        Label3.Text = ReelControl3.itemValue
        If ReelControl1.itemValue = ReelControl2.itemValue And ReelControl2.itemValue = ReelControl3.itemValue Then
            Me.BackColor = Color.Red
        End If

    End Sub
End Class
