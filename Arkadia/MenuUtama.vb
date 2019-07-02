Public Class MenuUtama

    Dim FormSubMenu As New FormSubMenu
    Dim MenuName As String

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kebakaran.BackColor = Color.Transparent
        GempaBumi.BackColor = Color.Transparent
        AncamanBom.BackColor = Color.Transparent
        PemadamanListrik.BackColor = Color.Transparent
        Latihan.BackColor = Color.Transparent
        Pengetesan.BackColor = Color.Transparent
    End Sub

    Private Sub GempaBumi_Click(sender As Object, e As EventArgs) Handles GempaBumi.Click
        MenuName = "Gempa Bumi"
        FormSubMenu.MenuName = MenuName
        FormSubMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Kebakaran_Click(sender As Object, e As EventArgs) Handles Kebakaran.Click
        MenuName = "Kebakaran"
        FormSubMenu.MenuName = MenuName
        FormSubMenu.Show()
        Me.Hide()
    End Sub

    Private Sub AncamanBom_Click(sender As Object, e As EventArgs) Handles AncamanBom.Click
        MenuName = "Ancaman Bom"
        FormSubMenu.MenuName = MenuName
        FormSubMenu.Show()
        Me.Hide()
    End Sub

    Private Sub PemadamanListrik_Click(sender As Object, e As EventArgs) Handles PemadamanListrik.Click
        MenuName = "Pemadaman Listrik"
        FormSubMenu.MenuName = MenuName
        FormSubMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Latihan_Click(sender As Object, e As EventArgs) Handles Latihan.Click
        MenuName = "Latihan"
        FormSubMenu.MenuName = MenuName
        FormSubMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Pengetesan_Click(sender As Object, e As EventArgs) Handles Pengetesan.Click
        MenuName = "Pengetesan"
        FormSubMenu.MenuName = MenuName
        FormSubMenu.Show()
        Me.Hide()
    End Sub
End Class