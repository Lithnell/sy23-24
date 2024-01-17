<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.field1 = New System.Windows.Forms.TextBox()
        Me.field4 = New System.Windows.Forms.TextBox()
        Me.field3 = New System.Windows.Forms.TextBox()
        Me.field2 = New System.Windows.Forms.TextBox()
        Me.field5 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FirstButton = New System.Windows.Forms.Button()
        Me.Prevbutton = New System.Windows.Forms.Button()
        Me.nextbutton = New System.Windows.Forms.Button()
        Me.Lastbutton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(37, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 87)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Genre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Creator"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Good with"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Subgenre"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "file"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.NewToolStripMenuItem.Text = "new"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.SaveToolStripMenuItem.Text = "save"
        '
        'field1
        '
        Me.field1.Location = New System.Drawing.Point(103, 133)
        Me.field1.Name = "field1"
        Me.field1.Size = New System.Drawing.Size(125, 27)
        Me.field1.TabIndex = 7
        '
        'field4
        '
        Me.field4.Location = New System.Drawing.Point(103, 232)
        Me.field4.Name = "field4"
        Me.field4.Size = New System.Drawing.Size(125, 27)
        Me.field4.TabIndex = 8
        '
        'field3
        '
        Me.field3.Location = New System.Drawing.Point(103, 199)
        Me.field3.Name = "field3"
        Me.field3.Size = New System.Drawing.Size(125, 27)
        Me.field3.TabIndex = 9
        '
        'field2
        '
        Me.field2.Location = New System.Drawing.Point(103, 166)
        Me.field2.Name = "field2"
        Me.field2.Size = New System.Drawing.Size(125, 27)
        Me.field2.TabIndex = 10
        '
        'field5
        '
        Me.field5.Location = New System.Drawing.Point(103, 265)
        Me.field5.Name = "field5"
        Me.field5.Size = New System.Drawing.Size(125, 27)
        Me.field5.TabIndex = 11
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FirstButton
        '
        Me.FirstButton.Location = New System.Drawing.Point(12, 409)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(94, 29)
        Me.FirstButton.TabIndex = 12
        Me.FirstButton.Text = "First"
        Me.FirstButton.UseVisualStyleBackColor = True
        '
        'Prevbutton
        '
        Me.Prevbutton.Location = New System.Drawing.Point(212, 409)
        Me.Prevbutton.Name = "Prevbutton"
        Me.Prevbutton.Size = New System.Drawing.Size(94, 29)
        Me.Prevbutton.TabIndex = 13
        Me.Prevbutton.Text = "Previous"
        Me.Prevbutton.UseVisualStyleBackColor = True
        '
        'nextbutton
        '
        Me.nextbutton.Location = New System.Drawing.Point(112, 409)
        Me.nextbutton.Name = "nextbutton"
        Me.nextbutton.Size = New System.Drawing.Size(94, 29)
        Me.nextbutton.TabIndex = 14
        Me.nextbutton.Text = "Next"
        Me.nextbutton.UseVisualStyleBackColor = True
        '
        'Lastbutton
        '
        Me.Lastbutton.Location = New System.Drawing.Point(312, 409)
        Me.Lastbutton.Name = "Lastbutton"
        Me.Lastbutton.Size = New System.Drawing.Size(94, 29)
        Me.Lastbutton.TabIndex = 15
        Me.Lastbutton.Text = "Last"
        Me.Lastbutton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lastbutton)
        Me.Controls.Add(Me.nextbutton)
        Me.Controls.Add(Me.Prevbutton)
        Me.Controls.Add(Me.FirstButton)
        Me.Controls.Add(Me.field5)
        Me.Controls.Add(Me.field2)
        Me.Controls.Add(Me.field3)
        Me.Controls.Add(Me.field4)
        Me.Controls.Add(Me.field1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents field1 As TextBox
    Friend WithEvents field4 As TextBox
    Friend WithEvents field3 As TextBox
    Friend WithEvents field2 As TextBox
    Friend WithEvents field5 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FirstButton As Button
    Friend WithEvents Prevbutton As Button
    Friend WithEvents nextbutton As Button
    Friend WithEvents Lastbutton As Button
End Class
