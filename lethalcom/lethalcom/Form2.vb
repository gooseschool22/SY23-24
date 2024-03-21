Public Class Form2
    Dim m As Integer = 500
    Dim charge As Integer
    Dim chance As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moneylabel.Text = m
        chargelabel.Text = charge
        chancelabel.text = chance
    End Sub

    Private Sub workernumber_ValueChanged(sender As Object, e As EventArgs) Handles workernumber.ValueChanged
        If workernumber.Value = 1 Then
            chance = 90
            chancelabel.Text = chance
        End If
        If workernumber.Value = 2 Then
            chance = 75
            chancelabel.Text = chance
        End If
        If workernumber.Value = 3 Then
            chance = 50
            chancelabel.Text = chance
        End If
        If workernumber.Value = 4 Then
            chance = 25
            chancelabel.Text = chance
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "YES" Then
            charge = charge + 250
            chargelabel.Text = charge
            If workernumber.Value = 1 Then
                If chance = 90 Then
                    chance = chance + 10
                    chancelabel.Text = chance
                End If
            End If
            If workernumber.Value <> 1 Then
                chance = chance + 20
                chancelabel.Text = chance
                If chance > 100 Then
                    chance = 100
                    chancelabel.Text = chance
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class