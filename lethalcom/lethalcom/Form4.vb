Public Class Form4
    Public Property add As Integer
    Public Property total As Integer
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form2.workernumber.Value = 1 Then
            add = add + 50
            addlabel.Text = add
        ElseIf Form2.workernumber.Value = 2 Then
            add = add + 100
            addlabel.Text = add
        ElseIf Form2.workernumber.Value = 3 Then
            add = add + 150
            addlabel.Text = add
        ElseIf Form2.workernumber.Value = 4 Then
            add = add + 200
            addlabel.Text = add
        End If
        moneylabel2.Text = Form2.m
        chargelable2.Text = Form2.charge
        total = Form2.m - Form2.charge + addlabel.Text
        totallabel.Text = total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
        Form2.m = 450
        Form2.moneylabel.Text = Form2.m
    End Sub
End Class