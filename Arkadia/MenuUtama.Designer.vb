<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pengetesan = New System.Windows.Forms.PictureBox()
        Me.Latihan = New System.Windows.Forms.PictureBox()
        Me.PemadamanListrik = New System.Windows.Forms.PictureBox()
        Me.AncamanBom = New System.Windows.Forms.PictureBox()
        Me.GempaBumi = New System.Windows.Forms.PictureBox()
        Me.Kebakaran = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Pengetesan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Latihan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PemadamanListrik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AncamanBom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GempaBumi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kebakaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Arkadia.My.Resources.Resources.Menu_background_paging_system
        Me.Panel1.Controls.Add(Me.Pengetesan)
        Me.Panel1.Controls.Add(Me.Latihan)
        Me.Panel1.Controls.Add(Me.PemadamanListrik)
        Me.Panel1.Controls.Add(Me.AncamanBom)
        Me.Panel1.Controls.Add(Me.GempaBumi)
        Me.Panel1.Controls.Add(Me.Kebakaran)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 741)
        Me.Panel1.TabIndex = 0
        '
        'Pengetesan
        '
        Me.Pengetesan.Image = Global.Arkadia.My.Resources.Resources.pengetesan
        Me.Pengetesan.Location = New System.Drawing.Point(805, 571)
        Me.Pengetesan.Name = "Pengetesan"
        Me.Pengetesan.Size = New System.Drawing.Size(161, 53)
        Me.Pengetesan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Pengetesan.TabIndex = 5
        Me.Pengetesan.TabStop = False
        '
        'Latihan
        '
        Me.Latihan.Image = Global.Arkadia.My.Resources.Resources.latihan
        Me.Latihan.Location = New System.Drawing.Point(805, 499)
        Me.Latihan.Name = "Latihan"
        Me.Latihan.Size = New System.Drawing.Size(161, 53)
        Me.Latihan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Latihan.TabIndex = 4
        Me.Latihan.TabStop = False
        '
        'PemadamanListrik
        '
        Me.PemadamanListrik.Image = Global.Arkadia.My.Resources.Resources.pemadaman_listrik
        Me.PemadamanListrik.Location = New System.Drawing.Point(805, 427)
        Me.PemadamanListrik.Name = "PemadamanListrik"
        Me.PemadamanListrik.Size = New System.Drawing.Size(161, 53)
        Me.PemadamanListrik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PemadamanListrik.TabIndex = 3
        Me.PemadamanListrik.TabStop = False
        '
        'AncamanBom
        '
        Me.AncamanBom.Image = Global.Arkadia.My.Resources.Resources.ancaman_boom
        Me.AncamanBom.Location = New System.Drawing.Point(805, 355)
        Me.AncamanBom.Name = "AncamanBom"
        Me.AncamanBom.Size = New System.Drawing.Size(161, 53)
        Me.AncamanBom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AncamanBom.TabIndex = 2
        Me.AncamanBom.TabStop = False
        '
        'GempaBumi
        '
        Me.GempaBumi.Image = Global.Arkadia.My.Resources.Resources.gempa
        Me.GempaBumi.Location = New System.Drawing.Point(805, 284)
        Me.GempaBumi.Name = "GempaBumi"
        Me.GempaBumi.Size = New System.Drawing.Size(161, 53)
        Me.GempaBumi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.GempaBumi.TabIndex = 1
        Me.GempaBumi.TabStop = False
        '
        'Kebakaran
        '
        Me.Kebakaran.Image = Global.Arkadia.My.Resources.Resources.kebakaran
        Me.Kebakaran.Location = New System.Drawing.Point(805, 215)
        Me.Kebakaran.Name = "Kebakaran"
        Me.Kebakaran.Size = New System.Drawing.Size(161, 53)
        Me.Kebakaran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Kebakaran.TabIndex = 0
        Me.Kebakaran.TabStop = False
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MenuUtama"
        Me.Text = "MenuUtama"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Pengetesan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Latihan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PemadamanListrik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AncamanBom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GempaBumi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kebakaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Kebakaran As PictureBox
    Friend WithEvents Pengetesan As PictureBox
    Friend WithEvents Latihan As PictureBox
    Friend WithEvents PemadamanListrik As PictureBox
    Friend WithEvents AncamanBom As PictureBox
    Friend WithEvents GempaBumi As PictureBox
End Class
