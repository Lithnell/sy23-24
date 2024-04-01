<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TimerUp = New System.Windows.Forms.Timer(Me.components)
        Me.TimerRight = New System.Windows.Forms.Timer(Me.components)
        Me.TimerLeft = New System.Windows.Forms.Timer(Me.components)
        Me.TimerGravity = New System.Windows.Forms.Timer(Me.components)
        Me.TimerGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PicGold = New System.Windows.Forms.PictureBox()
        Me.PicGround = New System.Windows.Forms.PictureBox()
        Me.PicPlayer = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerUp
        '
        '
        'TimerRight
        '
        '
        'TimerLeft
        '
        '
        'TimerGameLogic
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.platforner_game.My.Resources.Resources.grapes
        Me.PictureBox1.Location = New System.Drawing.Point(623, 163)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "restart"
        '
        'PicGold
        '
        Me.PicGold.Image = Global.platforner_game.My.Resources.Resources.bar
        Me.PicGold.Location = New System.Drawing.Point(59, 31)
        Me.PicGold.Name = "PicGold"
        Me.PicGold.Size = New System.Drawing.Size(72, 50)
        Me.PicGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicGold.TabIndex = 2
        Me.PicGold.TabStop = False
        Me.PicGold.Tag = "Gold"
        '
        'PicGround
        '
        Me.PicGround.Image = Global.platforner_game.My.Resources.Resources.cat
        Me.PicGround.Location = New System.Drawing.Point(12, 341)
        Me.PicGround.Name = "PicGround"
        Me.PicGround.Size = New System.Drawing.Size(776, 205)
        Me.PicGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicGround.TabIndex = 1
        Me.PicGround.TabStop = False
        '
        'PicPlayer
        '
        Me.PicPlayer.Image = Global.platforner_game.My.Resources.Resources.enderio
        Me.PicPlayer.Location = New System.Drawing.Point(51, 252)
        Me.PicPlayer.Name = "PicPlayer"
        Me.PicPlayer.Size = New System.Drawing.Size(80, 83)
        Me.PicPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicPlayer.TabIndex = 0
        Me.PicPlayer.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(740, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(740, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(740, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PicGold)
        Me.Controls.Add(Me.PicGround)
        Me.Controls.Add(Me.PicPlayer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimerUp As Timer
    Friend WithEvents TimerRight As Timer
    Friend WithEvents TimerLeft As Timer
    Friend WithEvents TimerGravity As Timer
    Friend WithEvents PicPlayer As PictureBox
    Friend WithEvents TimerGameLogic As Timer
    Friend WithEvents PicGround As PictureBox
    Friend WithEvents PicGold As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
