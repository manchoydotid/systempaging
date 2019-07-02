Public Class FormSubMenu
    Dim Cap1, Cap2, Cap3, Cap4, Cap5, Cap6, Cap7, Cap8, Cap9, Cap10 As String
    Dim FormCaption As New FormCaption
    Public Property MenuName As String

    Private Sub FormSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = MenuName

        Sound1.BackColor = Color.Transparent
        Sound2.BackColor = Color.Transparent
        Sound3.BackColor = Color.Transparent
        Sound4.BackColor = Color.Transparent
        Sound5.BackColor = Color.Transparent
        Sound6.BackColor = Color.Transparent
        Sound7.BackColor = Color.Transparent
        Sound8.BackColor = Color.Transparent
        Sound9.BackColor = Color.Transparent
        Sound10.BackColor = Color.Transparent
        BackToMenu.BackColor = Color.Transparent

        Select Case MenuName
'=====GEMPA BUMI======
            Case "Gempa Bumi"
                Sound1.BackgroundImage = My.Resources.gempa_pasca_gempa
                Sound2.BackgroundImage = My.Resources.gempa_evakuasi
                Sound3.BackgroundImage = My.Resources.gempa_evakuasi_pulang
                Sound4.BackgroundImage = My.Resources.gempa_tidak_evakuasi
                Sound5.BackgroundImage = My.Resources.gempa_assembly_area
                Sound6.BackgroundImage = My.Resources.gempa_segera_pulang
                Sound7.BackgroundImage = My.Resources.gempa_sarankan_pulang
                Sound8.BackgroundImage = My.Resources.gempa_kondisi_normal
                Sound9.Hide()
                Sound10.Hide()

                Sound1.Text = "Pasca Gempa"
                Sound1.Tag = "C1 GempaBumi1.wav"
                Cap1 = "Mohon Perhatian (2x)
Seperti Anda Ketahui, beberapa saat yang lalu telah terjadi gempa bumi.
Jangan panik dan  tetap di tempat . Jika terjadi gempa susulan, berlindunglah di bawah meja yang kokoh. Harap menjauh dari jendela, rak gantung dan partisi kaca.
Ikuti Petunjuk Pengawas Lantai Anda.

Saat  ini kami sedang melakukan pemeriksaan terhadap seluruh gedung dan menghubungi BMG untuk mengetahui kondisi lebih lanjut. Apabila diperlukan evakuasi, kami akan memberikan pengumuman lebih lanjut, Harap Anda tidak panik.
Terima kasih (dibacakan 2 kali)"

                Sound2.Text = "Evakuasi"
                Sound2.Tag = "C3 GempaBumi2.wav"
                Cap2 = "Mohon Perhatian
Mohon segera keluar dari gedung dan melakukan evakuasi melalui tangga darurat terdekat menuju Tempat Berkumpul atau Assembly Area.
Jangan menggunakan lift, harap tenang dan tidak panik.
Ikuti petunjuk Pengawas Lantai Anda
Terima kasih"

                Sound3.Text = "Evakuasi dan Pulang"
                Sound3.Tag = "C4 GempaBumi3.wav"
                Cap3 = "Mohon Perhatian 
Mengingat kondisi yang gedung yang belum aman untuk dihuni, maka disarankan kepada seluruh Penyewa untuk melakukan evakuasi dan segera meninggalkan Kompleks Arkadia green park.
Jangan Menggunakan Lift dan jangan panik.
Ikuti Petunjuk Lantai Anda.
Terima kasih.
(dibacakan 2 kali)"

                Sound4.Text = "Tidak Evakuasi"
                Sound4.Tag = "C5 GempaBumi4.wav"
                Cap4 = "Mohon Perhatian (2X)
Keadaan saat ini dinyatakan dalam kondisi aman, sehingga tidak diperlukan evakuasi.
Seluruh kegiatan dapat berlangsung normal kembali.
Terima kasih
(dibacakan 2 kali)"

                Sound5.Text = "Assembly Area"
                Sound5.Tag = "C6 GempaBumi5.wav"
                Cap5 = "Mohon Perhatian
Saat ini pihak kami sedang melakukan pemeriksaan atas kondisi fisik gedung dan peralatan.
Mohon untuk tetap berada di assembly area sampai ada pengumuman lebih lanjut.
Terima kasih
(dibacakan 2 kali)"

                Sound6.Text = "Segera Pulang"
                Sound6.Tag = "C7 GempaBumi6.wav"
                Cap6 = "Mohon Perhatian (2X)
Diberitahukan kepada seluruh Tenant, dapat kembali ke dalam gedung untuk mengambil barang yang diperlukan dan harus segera meninggalkan gedung.
Terima kasih
(dibacakan 2 kali)"

                Sound7.Text = "Sarankan Pulang"
                Sound7.Tag = "C8 GempaBumi7.wav"
                Cap7 = "Mohon Perhatian (2X)
Diberitahukan kepada seluruh Tenant, dapat kembali ke dalam gedung dan disarankan untuk pulang.
Terima kasih"

                Sound8.Text = "Kondisi Aman"
                Sound8.Tag = "C9 GempaBumi8.wav"
                Cap8 = "Mohon Perhatian
Diberitahukan kepada seluruh Tenant, dipersilakan kembali masuk kedalam gedung, keadaan saat ini dinyatakan dalam kondisi aman.
Terima kasih
(dibacakan 2 kali)"

'=====KEBAKARAN======
            Case "Kebakaran"

                Sound10.Hide()

                Label1.Text = MenuName
                Sound1.Text = "Evakuasi Kebakaran"
                Sound1.Tag = "C1 GempaBumi1.wav"
                Cap1 = "Mohon Perhatian (2x)
Tanda alarm telah dibunyikan
Harap segera keluar dari Gedung dan melakukan evakuasi melalui tangga darurat terdekat menuju ke Tempat Berkumpul atau Assembly Area.
Jangan menggunakan lift, Ikuti Petunjuk pengawas lantai anda.
Harap tidak panik
(dibacakan beberapa kali sesuai kondisi di lapangan)"

                Sound2.Text = "Api Dapat Dikuasai"
                Sound2.Tag = "C3 GempaBumi2.wav"
                Cap2 = "Mohon Perhatian (2x)
Telah terjadi kebakaran di area Arkadia Green Park
Api telah dipadamkan dan situasi dapat dikendalikan.
Harap anda tetap tenang dan tidak panik
Terima kasih
(dibacakan 2 kali)"

                Sound3.Text = "Alarm Aktif"
                Sound3.Tag = "C4 GempaBumi3.wav"
                Cap3 = "Mohon Perhatian (2x)
Beberapa saat yang lalu, alarm kebakaran telah berbunyi.
Saat ini kami sedang melakukan penyelidikan di seluruh area gedung, harap Anda tetap berada di tempat, mohon untuk mengikuti instruksi lebih lanjut.
Dimohon untuk  tetap tenang dan jangan panik.
Terima kasih
(dibacakan 2 kali)"

                Sound4.Text = "Evakuasi Kebakaran"
                Sound4.Tag = "C5 GempaBumi4.wav"
                Cap4 = "Mohon Perhatian (2x)
Segera keluar dari gedung dan melakukan evakuasi melalui tangga darurat terdekat menuju ke Tempat Berkumpul atau Assembly Area.
Jangan Menggunakan Lift dan jangan panik
Ikuti Petunjuk Pengawas Lantai Anda.
Terima kasih
(dibacakan 2 kali)"

                Sound5.Text = "Tidak Evakuasi"
                Sound5.Tag = "C6 GempaBumi5.wav"
                Cap5 = "Mohon Perhatian
Keadaan saat ini dinyatakan dalam kondisi aman, sehingga tidak diperlukan evakuasi.
Seluruh kegiatan dapat berlangsung normal kembali.
Terima kasih
(dibacakan 2 kali)"

                Sound6.Text = "Assembly Area"
                Sound6.Tag = "C7 GempaBumi6.wav"
                Cap6 = "Mohon Perhatian 
Saat ini Dinas Pemadam Kebakaran sedang melakukan pemadaman api di tempat kejadian serta melakukan pemeriksaan intensif di seluruh gedung.
Mohon anda tetap berada di tempat berkumpul sampai ada pengumuman lebih lanjut.
Terima kasih
(dibacakan beberapa kali melalui speaker Parkir)"

                Sound7.Text = "Meninggalkan Gedung"
                Sound7.Tag = "C8 GempaBumi6.wav"
                Cap7 = "Mohon Perhatian (2x)
Diberitahukan kepada Seluruh Penyewa, bahwa  saat ini kondisi gedung belum aman untuk dihuni dan  mohon Anda untuk segera meninggalkan Assembly Area dan keluar dari kompleks Arkadia Green Park.
Ikuti Petunjuk Pengawas Lantai Anda.
Terima kasih.
(dibacakan beberapa kali melalui speaker Parkir)"

                Sound8.Text = "Wajib Pulang"
                Sound8.Tag = "C9 GempaBumi7.wav"
                Cap8 = "Mohon Perhatian 
Diberitahukan kepada seluruh Tenant, dapat kembali ke dalam gedung untuk mengambil barang yang diperlukan dan harus segera meninggalkan gedung.
Terima kasih
(diinformasikan 2 kali)"

                Sound9.Text = "Kondisi Aman"
                Sound9.Tag = "C10 GempaBumi8.wav"
                Cap9 = "Mohon Perhatian 
Diberitahukan kepada seluruh Tenant, dipersilakan kembali masuk kedalam gedung, keadaan saat ini dinyatakan dalam kondisi aman.
Terima kasih
(diinformasikan 2 kali)"

                Sound10.Text = "Alarm Palsu"
                Sound10.Tag = "C10 GempaBumi9.wav"
                Cap10 = "Mohon Perhatian 
Diinformasikan bahwa telah terjadi kesalahan teknis sehingga alarm berbunyi. Mohon maaf atas ketidaknyamanan yang terjadi.
Terima kasih
(diinformasikan 2 kali)"

'=====ANCAMAN BOM======
            Case "Ancaman Bom"

                Sound7.Hide()
                Sound8.Hide()
                Sound9.Hide()
                Sound10.Hide()

                Label1.Text = MenuName
                Sound1.Text = "Ancaman Bom"
                Sound1.Tag = "C1 GempaBumi1.wav"
                Cap1 = "Mohon Perhatian (2x)
Salah satu penyewa kami telah menerima ancaman bom.
Kami mohon agar seluruh Penyewa dan tamu untuk segera melakukan evakuasi menuju ke Assembly Area melalui tangga darurat terdekat.
Jangan menggunakan lift dan jangan panik Ikuti Petunjuk Pengawas Lantai anda.
Terima kasih
(dibacakan 2 kali)"

                Sound2.Text = "Tidak Evakuasi"
                Sound2.Tag = "C3 GempaBumi2.wav"
                Cap2 = "Mohon Perhatian (2x)
Keadaan saat ini dinyatakan dalam kondisi aman, sehingga tidak diperlukan evakuasi.
Seluruh kegiatan dapat berlangsung normal kembali.
Terima kasih
(dibacakan 2 kali)"

                Sound3.Text = "Evakuasi"
                Sound3.Tag = "C4 GempaBumi3.wav"
                Cap3 = "Mohon Perhatian (2x)
Mohon segera keluar dari Gedung dan melakukan evakuasi melalui tangga darurat terdekat menuju ke Tempat Berkumpul atau Assembly Area.
Jangan menggunakan lift dan jangan panic, Ikuti Petunjuk pengawas lantai anda.
Terima kasih
(dibacakan beberapa kali sesuai kondisi di lapangan)"

                Sound4.Text = "Assembly Area"
                Sound4.Tag = "C5 GempaBumi4.wav"
                Cap4 = "Mohon Perhatian 
Saat ini pihak kami sedang melakukan pemeriksaan keadaan gedung.
Mohon untuk tetap berada di assembly area sampai ada pengumuman lebih lanjut.
Terima kasih
(dibacakan 2 kali)"

                Sound5.Text = "Wajib Pulang"
                Sound5.Tag = "C6 GempaBumi5.wav"
                Cap5 = "Mohon Perhatian (2x)
Diberitahukan kepada seluruh Tenant, dapat kembali ke dalam gedung untuk mengambil barang yang diperlukan dan harus segera meninggalkan gedung.
Terima kasih"

                Sound6.Text = "Kembali ke Gedung"
                Sound6.Tag = "C8 GempaBumi6.wav"
                Cap6 = "Mohon Perhatian 
Diberitahukan kepada seluruh Tenant, dipersilakan kembali masuk kedalam gedung, keadaan saat ini dinyatakan dalam kondisi aman.
Terima kasih
(dibacakan 2 kali)"

'=====PEMADAMAN LISTRIK======
            Case "Pemadaman Listrik"
                Sound6.Hide()
                Sound7.Hide()
                Sound8.Hide()
                Sound9.Hide()
                Sound10.Hide()

                Label1.Text = MenuName
                Sound1.Text = "Pemadaman Total"
                Sound1.Tag = "C1 GempaBumi1.wav"
                Cap1 = "Mohon Perhatian (2x)
Untuk keperluan perawatan gedung, maka dalam waktu 5 menit lagi, Pengelola Gedung akan memadamkan listrik secara total. Kami menghimbau Anda untuk mengantisipasi hal tersebut.
Terima kasih dan mohon maaf atas ketidaknyamanan ini
(dibacakan 2 kali)"

                Sound2.Text = "Transfer ke Genset"
                Sound2.Tag = "C3 GempaBumi2.wav"
                Cap2 = "Mohon Perhatian (2x)
Untuk keperluan perawatan gedung, maka dalam waktu 5 menit lagi, Pengelola Gedung akan memindahkan pasokan listrik  dari PLN ke genset. Mohon agar Anda dapat segera mengantisipasi hal ini karena listrik akan padam dalam beberapa detik.
Terima kasih dan mohon maaf atas ketidaknyamanan ini
(dibacakan 2 kali)"

                Sound3.Text = "Pemadaman dari PLN"
                Sound3.Tag = "C4 GempaBumi3.wav"
                Cap3 = "Mohon Perhatian (2x)
Diberitahukan bahwa beberapa waktu yang lalu telah terjadi pemutusan  aliran  listrik dari PLN  dan saat ini pasokan listrik di dalam gedung menggunakan genset.
Terima kasih dan mohon maaf atas ketidaknyamanan ini
(dibacakan 2 kali)"

                Sound4.Text = "Transfer dari Genset"
                Sound4.Tag = "C5 GempaBumi4.wav"
                Cap4 = "Mohon Perhatian (2x)
Diberitahukan bahwa dalam waktu 5 menit lagi, listrik akan dialihkan kembali dari genset ke PLN. Mohon agar Anda dapat segera mengantisipasi hal ini karena listrik akan padam dalam beberapa detik.
Terima kasih dan mohon maaf atas ketidaknyamanan ini
(dibacakan 2 kali)"

                Sound5.Text = "Listrik Kedip"
                Sound5.Tag = "C6 GempaBumi5.wav"
                Cap4 = "Mohon Perhatian (2x)
Kami informasikan bahwa aliran listrik mengalami kedip sesaat dari PLN.
Terima kasih dan mohon maaf atas ketidaknyamanan ini
(dibacakan 2 kali)"



'=====LATIHAN======
            Case "Latihan"

                Sound6.Hide()
                Sound7.Hide()
                Sound8.Hide()
                Sound9.Hide()
                Sound10.Hide()

                Label1.Text = MenuName
                Sound1.Text = "Kebakaran (Drill)"
                Sound1.Tag = "C1 GempaBumi1.wav"
                Cap1 = "Mohon Perhatian, Ini hanya latihan.
Tanda alarm telah dibunyikan
Mohon segera keluar dari Gedung dan melakukan evakuasi melalui tangga darurat terdekat menuju ke Tempat Berkumpul atau Assembly Area.
Jangan menggunakan lift dan jangan panik dan  Ikuti Petunjuk pengawas lantai anda.
Terima kasih
(dibacakan beberapa kali sesuai kondisi di lapangan)"

                Sound2.Text = "Gempa Bumi (Drill)"
                Sound2.Tag = "C3 GempaBumi2.wav"
                Cap2 = "Mohon Perhatian, Ini Hanya Latihan.
Seperti Anda Ketahui, beberapa saat yang lalu telah terjadi gempa bumi.
Jangan panik dan  tetap di tempat .
Jika terjadi gempa susulan, berlindunglah di bawah meja yang kokoh.
Harap menjauh dari jendela, rak gantung dan partisi kaca.
Ikuti Petunjuk Pengawas Lantai Anda.
Saat  ini kami sedang melakukan pemeriksaan terhadap seluruh gedung dan menghubungi BMG untuk mengetahui kondisi lebih lanjut.
Apabila diperlukan evakuasi, kami akan memberikan pengumuman lebih lanjut, Harap Anda tidak panik.
Terima kasih (dibacakan 2 kali)"

                Sound3.Text = "Ancaman Bom (Drill)"
                Sound3.Tag = "C5 GempaBumi4.wav"
                Cap3 = "Mohon Perhatian,
Ini hanya latihan.
Salah satu penyewa kami telah menerima ancaman bom.
Kami mohon agar seluruh Penyewa dan tamu untuk segera melakukan evakuasi menuju ke Assembly Area melalui tangga darurat terdekat.
Jangan menggunakan lift dan jangan panik Ikuti Petunjuk Pengawas Lantai anda.
Terima kasih
(dibacakan 2 kali)"

                Sound4.Text = "Latihan Evakuasi (Umum)"
                Sound4.Tag = "C6 GempaBumi5.wav"
                Cap4 = "Mohon Perhatian,
Ini Hanya Latihan.

Tanda alarm telah dibunyikan
Mohon segera keluar dari gedung dan melakukan evakuasi melalui tangga darurat terdekat menuju Tempat Berkumpul atau Assembly Area.
Jangan menggunakan lift, harap tenang dan tidak panik.
Ikuti petunjuk Pengawas Lantai Anda
Terima kasih
(dibacakan 2 kali)"

                Sound5.Text = "Kembali ke Gedung"
                Sound5.Tag = "C7 GempaBumi6.wav"
                Cap5 = "Mohon perhatian,
Kami memberitahukan  bahwa latihan evakuasi telah selesai, dan seluruh penyewa dipersilahkan kembali ke dalam Gedung.
Terima kasih atas partisipasi Anda selama latihan evakuasi berlangsung.
(dibacakan berkali-kali melalui PA Parkir)"

'=====PENGETESAN======
            Case "Pengetesan"

                Sound3.Hide()
                Sound4.Hide()
                Sound5.Hide()
                Sound6.Hide()
                Sound7.Hide()
                Sound8.Hide()
                Sound9.Hide()
                Sound10.Hide()

                Label1.Text = MenuName
                Sound1.Text = "Test Paging"
                Sound1.Tag = "C1 GempaBumi1.wav"
                Cap1 = "Mohon perhatian,
Diinformasikan bahwa, saat ini kami sedang melakukan test paging system.
Dimohon untuk tetap tenang
Terima kasih
(dibacakan berkali-kali, tergantung keperluan)"

                Sound2.Text = "Test Alarm"
                Sound2.Tag = "C3 GempaBumi2.wav"
                Cap2 = "Mohon perhatian,
Saat ini kami sedang melakukan test system alarm, dan beberapa saat lagi alarm di lantai anda akan berbunyi.
Mohon untuk tetap tenang
Terima kasih
(dibacakan berkali-kali, tergantung keperluan)"
        End Select
    End Sub

    Private Sub Sound1_Click(sender As Object, e As EventArgs) Handles Sound1.Click
        FormCaption.AudioName = Sound1.Tag
        FormCaption.CapText = Cap1
        FormCaption.MenuName = MenuName
        FormCaption.SoundText = Sound1.Text
        FormCaption.Show()
        Me.Dispose()

    End Sub

    Private Sub Sound2_Click(sender As Object, e As EventArgs) Handles Sound2.Click
        FormCaption.AudioName = Sound2.Tag
        FormCaption.CapText = Cap2
        FormCaption.MenuName = MenuName
        FormCaption.SoundText = Sound2.Text
        FormCaption.Show()
        Me.Dispose()
    End Sub

    Private Sub Sound3_Click(sender As Object, e As EventArgs) Handles Sound3.Click
        FormCaption.AudioName = Sound3.Tag
        FormCaption.CapText = Cap3
        FormCaption.MenuName = MenuName
        FormCaption.SoundText = Sound3.Text
        FormCaption.Show()
        Me.Dispose()

    End Sub
    Private Sub Sound4_Click(sender As Object, e As EventArgs) Handles Sound4.Click
        FormCaption.AudioName = Sound4.Tag
        FormCaption.CapText = Cap4
        FormCaption.MenuName = MenuName
        FormCaption.SoundText = Sound4.Text
        FormCaption.Show()
        Me.Dispose()

    End Sub
    Private Sub Sound5_Click(sender As Object, e As EventArgs) Handles Sound5.Click
        FormCaption.AudioName = Sound5.Tag
        FormCaption.CapText = Cap5
        FormCaption.MenuName = MenuName
        FormCaption.SoundText = Sound5.Text
        FormCaption.Show()
        Me.Dispose()

    End Sub
    Private Sub Sound6_Click(sender As Object, e As EventArgs) Handles Sound6.Click
        FormCaption.AudioName = Sound6.Tag
        FormCaption.CapText = Cap6
        FormCaption.MenuName = MenuName
        FormCaption.SoundText = Sound6.Text
        FormCaption.Show()
        Me.Dispose()

    End Sub
    Private Sub Sound7_Click(sender As Object, e As EventArgs) Handles Sound7.Click
        FormCaption.AudioName = Sound7.Tag
        FormCaption.CapText = Cap7
        FormCaption.MenuName = MenuName
        FormCaption.SoundText = Sound7.Text
        FormCaption.Show()
        Me.Dispose()
    End Sub

    Private Sub Sound8_Click(sender As Object, e As EventArgs) Handles Sound8.Click
        FormCaption.AudioName = Sound8.Tag
        FormCaption.CapText = Cap8
        FormCaption.MenuName = MenuName
        FormCaption.SoundText = Sound8.Text
        FormCaption.Show()
        Me.Dispose()
    End Sub

    Private Sub Sound9_Click(sender As Object, e As EventArgs) Handles Sound9.Click
        FormCaption.AudioName = Sound9.Tag
        FormCaption.CapText = Cap9
        FormCaption.MenuName = MenuName
        FormCaption.SoundText = Sound9.Text
        FormCaption.Show()
        Me.Dispose()
    End Sub

    Private Sub Sound10_Click(sender As Object, e As EventArgs) Handles Sound10.Click
        FormCaption.AudioName = Sound10.Tag
        FormCaption.CapText = Cap10
        FormCaption.MenuName = MenuName
        FormCaption.SoundText = Sound10.Text
        FormCaption.Show()
        Me.Dispose()

    End Sub


    'Button kembali ke menu utama
    Private Sub BackToMenu_Click(sender As Object, e As EventArgs) Handles BackToMenu.Click

        Dim Menu = New MenuUtama
        Menu.Show()
        Me.Dispose()
    End Sub


End Class