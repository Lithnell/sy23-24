Imports System.Net.Security
Imports System.Threading

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Reelcontrol1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Reelcontrol1.spin()
        Reelcontrol2.spin()
        Reelcontrol3.spin()
        Timer1.Enabled = True
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 32 Then
            Reelcontrol1.spin()
            Reelcontrol2.spin()
            Reelcontrol3.spin()
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Reelcontrol1.ItemValue
        Label2.Text = Reelcontrol2.ItemValue
        Label3.Text = Reelcontrol3.ItemValue
        Timer1.Enabled = False
        If Reelcontrol1.ItemValue = Reelcontrol2.ItemValue And Reelcontrol2.ItemValue = Reelcontrol3.ItemValue Then
            Label5.Text = "You Win"
        Else
            Label5.Text = "Try again"
        End If

    End Sub
End Class
