Imports Microsoft.VisualBasic.ApplicationServices

Public Class mover
    Public Property speed As Integer
    Public Property interval As Integer = 500
    Public Property sprite As PictureBox
    Dim xdr As Integer = 1
    Dim ydr As Integer = 0

    Private Sub mover_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = interval
        Timer1.Enabled = True
        If Not sprite Is Nothing Then
            sprite.Left = Me.Left
            sprite.Top = Me.Top
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not sprite Is Nothing Then
            sprite.Left += xdr * speed
            sprite.Top += ydr * speed
            If sprite.Left > Me.Left + Me.Width And xdr = 1 Then
                xdr = 0
                ydr = 1
            End If
            If sprite.Left < Me.Left And xdr = -1 Then
                xdr = 0
                ydr = -1
            End If
            If sprite.Top > Me.Top + Me.Height And ydr = 1 Then
                xdr = -1
                ydr = 0
            End If
            If sprite.Top < Me.Top And ydr = -1 Then
                xdr = 1
                ydr = 0
            End If
        End If
    End Sub
End Class
