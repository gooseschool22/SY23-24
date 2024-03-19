Public Class Form1
    Dim movespeed As Integer = 10
    Dim isjumping As Boolean
    Dim p As Integer
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                TimerRight.Start()
            Case Keys.Left
                TimerLeft.Start()
            Case Keys.Up
                TimerUp.Start()
                isjumping = True
            Case Keys.Down
                TimerGravity.Interval = 25
            Case Keys.R
                reset()
            Case Keys.ShiftKey
                TimerRight.Interval = 50
                TimerLeft.Interval = 50
        End Select
    End Sub

    Private Sub TimerRight_Tick(sender As Object, e As EventArgs) Handles TimerRight.Tick
        centurion.Left += movespeed
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                TimerRight.Stop()
            Case Keys.Left
                TimerLeft.Stop()
            Case Keys.Up
                TimerUp.Stop()
                isjumping = False
            Case Keys.Down
                TimerGravity.Interval = 75
            Case Keys.ShiftKey
                TimerRight.Interval = 100
                TimerLeft.Interval = 100
        End Select
    End Sub

    Private Sub TimerLeft_Tick(sender As Object, e As EventArgs) Handles TimerLeft.Tick
        centurion.Left -= movespeed
    End Sub

    Private Sub TimerUp_Tick(sender As Object, e As EventArgs) Handles TimerUp.Tick
        centurion.Top -= movespeed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        TimerGameLogic.Start()
        TextBox1.Select()

    End Sub

    Private Sub TimerGameLogic_Tick(sender As Object, e As EventArgs) Handles TimerGameLogic.Tick
        score.Text = p
        If p < 0 Then
            p = 0
        End If
        If centurion.Bounds.IntersectsWith(ground.Bounds) Then
            TimerGravity.Stop()
        Else
            If isjumping = False Then
                TimerGravity.Start()
            End If
        End If
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = ("bound") Then
                    If centurion.Bounds.IntersectsWith(b.Bounds) Then
                        TimerGravity.Stop()
                    End If
                End If
                If b.Visible = True Then
                    If b.Tag = ("win") Then
                        If centurion.Bounds.IntersectsWith(b.Bounds) Then
                            solarflare.Visible = False
                            p = p + 1000
                        End If
                    End If
                End If
                If b.Tag = ("kill") Then
                        If centurion.Bounds.IntersectsWith(b.Bounds) Then
                        reset()
                        p = p - 250
                        End If
                    End If
                If b.Visible = True Then
                    If b.Tag = ("button") Then
                        If centurion.Bounds.IntersectsWith(b.Bounds) Then
                            killsecret1.Location = kill7.Location
                            killsecret2.Location = kill8.Location
                            secretplatform.Visible = True
                            secretbutton.Visible = False
                            secrettrophy.Visible = True
                            secretsun1.Visible = True
                            secretsun2.Visible = True
                        End If
                    End If
                End If
                If b.Visible = True Then
                    If b.Tag = ("secret") Then
                        If centurion.Bounds.IntersectsWith(b.Bounds) Then
                            secrettrophy.Visible = False
                            p = p + 2500
                        End If
                    End If
                End If
                If b.Visible = True Then
                        If b.Tag = ("sunflower") Then
                            If centurion.Bounds.IntersectsWith(b.Bounds) Then
                                p = p + 250
                                b.Visible = False
                            End If
                        End If
                    End If
                End If
        Next

    End Sub

    Private Sub TimerGravity_Tick(sender As Object, e As EventArgs) Handles TimerGravity.Tick
        centurion.Top += movespeed
    End Sub
    Sub reset()
        centurion.Location = spawn.location
        sunflower1.Visible = True
        sunflower2.Visible = True
        sunflower3.Visible = True
        sunflower4.Visible = True
        sunflower5.Visible = True
        sunflower6.Visible = True
        sunflower7.Visible = True
        sunflower8.Visible = True
        sunflower9.Visible = True
        solarflare.Visible = True
        killsecret1.Location = killsecret1location.Location
        killsecret2.Location = killsecret2location.Location
        secretsun1.Visible = False
        secretsun2.Visible = False
        secretplatform.Visible = False
        secrettrophy.Visible = False
        secretbutton.Visible = True
    End Sub
End Class
