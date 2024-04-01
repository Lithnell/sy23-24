Imports System.Threading
Public Class Form1
    Dim movespeed As Integer = 10
    Dim isjumping As Boolean
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                TimerRight.Start()
            Case Keys.Left
                TimerLeft.Start()
            Case Keys.Up
                TimerUp.Start()
                isjumping = True
        End Select
    End Sub

    Private Sub timerRight_Tick(sender As Object, e As EventArgs) Handles TimerRight.Tick
        PicPlayer.Left += 15
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                TimerRight.Stop()
            Case Keys.Left
                TimerLeft.Stop()
            Case Keys.Up
                TimerUp.Stop()
                isjumping = False
        End Select
    End Sub

    Private Sub timerLeft_Tick(sender As Object, e As EventArgs) Handles TimerLeft.Tick
        PicPlayer.Left -= movespeed
    End Sub

    Private Sub timerUp_Tick(sender As Object, e As EventArgs) Handles TimerUp.Tick
        PicPlayer.Top -= movespeed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerGameLogic.Start()
    End Sub

    Private Sub timerGameLogic_Tick(sender As Object, e As EventArgs) Handles TimerGameLogic.Tick
        If PicPlayer.Bounds.IntersectsWith(PicGround.Bounds) Then
            TimerGravity.Stop()
        Else
            If isjumping = False Then
                TimerGravity.Start()
            End If
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        TimerGravity.Stop()
                    End If
                End If
                If b.Tag = "restart" Then
                    If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        PicPlayer.Location = New Point(51, 252)
                    End If
                End If
                If b.Tag = "Gold" Then
                    If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        PicGold.Visible = False

                    End If
                End If
                If b.Tag = "enemy" Then
                    If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        If PicPlayer.Visible = True Then
                            Label3.Text = Label3.Text - 1
                        End If
                        If Label3.Text = -1 = True Then
                            TimerGravity.Stop()
                            PicPlayer.Visible = False
                            Label2.Text = "You Lose"
                            Label2.Visible = True
                        End If
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub timerGravity_Tick(sender As Object, e As EventArgs) Handles timerGravity.Tick
        picPlayer.Top += movespeed
    End Sub
End Class