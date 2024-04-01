Public Class Form4
    Public Property add As Integer
    Public Property total As Integer
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moneylabel2.Text = Form2.m
        chargelable2.Text = Form2.charge
        addlabel.Text = add
        total = Form2.m - Form2.charge
        total = Form2.m + add
        totallabel.Text = total
    End Sub
End Class