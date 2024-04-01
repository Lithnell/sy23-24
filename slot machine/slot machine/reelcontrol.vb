Imports System.IO
Imports System.Threading

Public Class reelcontrol

    Public Property ItemValue As Integer
    Public Property SpinTime As Integer = 8000
    Dim rand As New Random
    Sub spin()
        Dim rand As New Random
        Dim r As Integer
        r = rand.Next(3)
        PictureBox1.Image = ImageList1.Images(r)
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim r As Integer
        Dim T As Integer
        T = Timer1.Interval
        r = Rand.Next(ImageList1.Images.Count)
        PictureBox1.Image = ImageList1.Images(r)
        ItemValue = r
        Timer1.Interval = (1000) * (0.066) + T
    End Sub
    Private Sub reelcontrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Interval = SpinTime
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer1.Interval = 125
    End Sub
End Class
