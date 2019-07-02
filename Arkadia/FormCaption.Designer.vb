<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCaption
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCaption))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.BackButton = New System.Windows.Forms.PictureBox()
        Me.MenuButton = New System.Windows.Forms.PictureBox()
        Me.PlayButton = New System.Windows.Forms.PictureBox()
        Me.CaptionText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Arkadia.My.Resources.Resources.caption_background_paging_kosongan
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.MenuButton)
        Me.Panel1.Controls.Add(Me.PlayButton)
        Me.Panel1.Controls.Add(Me.CaptionText)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 741)
        Me.Panel1.TabIndex = 0
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(281, 668)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(331, 48)
        Me.AxWindowsMediaPlayer1.TabIndex = 16
        '
        'BackButton
        '
        Me.BackButton.Image = Global.Arkadia.My.Resources.Resources.back
        Me.BackButton.Location = New System.Drawing.Point(637, 663)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(161, 53)
        Me.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BackButton.TabIndex = 15
        Me.BackButton.TabStop = False
        '
        'MenuButton
        '
        Me.MenuButton.Image = Global.Arkadia.My.Resources.Resources.menu1
        Me.MenuButton.Location = New System.Drawing.Point(804, 663)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(161, 53)
        Me.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MenuButton.TabIndex = 14
        Me.MenuButton.TabStop = False
        '
        'PlayButton
        '
        Me.PlayButton.Image = Global.Arkadia.My.Resources.Resources.play
        Me.PlayButton.Location = New System.Drawing.Point(80, 663)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(161, 53)
        Me.PlayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PlayButton.TabIndex = 13
        Me.PlayButton.TabStop = False
        '
        'CaptionText
        '
        Me.CaptionText.BackColor = System.Drawing.Color.Transparent
        Me.CaptionText.Font = New System.Drawing.Font("Gotham", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaptionText.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CaptionText.Location = New System.Drawing.Point(120, 166)
        Me.CaptionText.Name = "CaptionText"
        Me.CaptionText.Size = New System.Drawing.Size(800, 450)
        Me.CaptionText.TabIndex = 0
        Me.CaptionText.Text = "Label1"
        Me.CaptionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(791, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 37)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormCaption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormCaption"
        Me.Text = "FormCaption"
        Me.Panel1.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CaptionText As Label
    Friend WithEvents PlayButton As PictureBox
    Friend WithEvents BackButton As PictureBox
    Friend WithEvents MenuButton As PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label1 As Label
End Class
