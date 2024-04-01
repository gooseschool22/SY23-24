Imports System.Net.Security

Public Class Form2
    Public Property m As Integer = 500
    Public Property charge As Integer = 100

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moneylabel.Text = m
        chargelabel.Text = charge
    End Sub

    Private Sub workernumber_ValueChanged(sender As Object, e As EventArgs) Handles workernumber.ValueChanged
        If workernumber.Value = 1 Then
        End If
        If workernumber.Value = 2 Then
        End If
        If workernumber.Value = 3 Then
        End If
        If workernumber.Value = 4 Then
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "YES" Then
            charge = charge + 250
            chargelabel.Text = charge
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If PictureBox1.Image Is Nothing Then
            Me.Hide()
            Form3.Show()
        End If
    End Sub
    Sub reset()
        charge = 0
        chargelabel.Text = charge
        workernumber.Value = 1
        ComboBox1.SelectedItem = "CHOOSE"
        PictureBox1.Image = Nothing
    End Sub

    Private Sub resetbutton_Click(sender As Object, e As EventArgs) Handles resetbutton.Click
        reset()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PictureBox1.Image IsNot Nothing Then
            If m > charge Then
                Me.Close()
                Form4.Show()
            End If
        End If
    End Sub
End Class