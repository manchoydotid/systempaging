Public Class FormCaption
    Public Property CapText As String
    Public Property AudioName As String
    Public Property MenuName As String
    Public Property SoundText As String

    Private Sub FormCaption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        CaptionText.Text = CapText
        AxWindowsMediaPlayer1.Hide()
        Label1.Text = SoundText

        PlayButton.BackColor = Color.Transparent
        BackButton.BackColor = Color.Transparent
        MenuButton.BackColor = Color.Transparent

    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        AxWindowsMediaPlayer1.URL = "D:\sound\" & AudioName
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        Dim FormSubMenu As New FormSubMenu
        FormSubMenu.MenuName = MenuName
        FormSubMenu.Show()
        Me.Hide()
    End Sub

    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        Dim FormMenu = New MenuUtama
        FormMenu.Show()
        Me.Hide()
    End Sub
End Class