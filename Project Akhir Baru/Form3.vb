Imports MySql.Data.MySqlClient

Public Class Form3

    Private allEventPanels As New List(Of Panel)()
    Private Sub Form3_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LoadEvents("belum")
    End Sub
    Private Sub btnTambahAcara_Click(sender As Object, e As EventArgs) Handles btnTambahAcara.Click
        'Form5.Show()
        Me.Hide()

        ' Create an instance of Form5
        Dim detailForm5 As New Form5()

        ' Show Form5
        detailForm5.Show()

        ' Make pnlDetailJasmine visible and hide other panels
        detailForm5.lblBaru.Visible = True
        detailForm5.lblEdit.Visible = False

        detailForm5.btnTambah.Visible = True
        detailForm5.btnSimpan.Visible = False

        ' Optional: Bring the panel to front if there are overlapping controls
        detailForm5.lblBaru.BringToFront()
        detailForm5.btnTambah.BringToFront()

        detailForm5.TabControl1.TabPages.Remove(detailForm5.TabControl1.TabPages("tpPaket"))
        detailForm5.TabControl1.TabPages.Remove(detailForm5.TabControl1.TabPages("tpTambahan"))
        detailForm5.TabControl1.TabPages.Remove(detailForm5.TabControl1.TabPages("tpPembayaran"))
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Form1.Show()
        Form1.tbNamaPengguna.Clear()
        Form1.tbKataSandi.Clear()
        Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEvents()
        If cbWaktuKegiatan.Items.Count = 0 Then
            cbWaktuKegiatan.Items.Add("Belum dimulai")
            cbWaktuKegiatan.Items.Add("Sudah selesai")
        End If

        cbWaktuKegiatan.SelectedIndex = 0

    End Sub
    Public Sub LoadEvents(Optional statusWaktu As String = "belum")
        Try
            ' Query untuk mengambil data acara
            Dim sql As String = "SELECT * FROM acara ORDER BY tanggal_pelaksanaan ASC"
            myCommand = New MySqlCommand(sql, myConn)
            myDataReader = myCommand.ExecuteReader()

            ' Bersihkan Panel sebelum menambahkan data
            FlowLayoutPanel1.Controls.Clear()
            allEventPanels.Clear()

            ' Loop melalui hasil query dan tampilkan data
            While myDataReader.Read()
                ' Ambil data dari database
                Dim idAcara As String = myDataReader("id_acara").ToString()
                Dim namaAcara As String = myDataReader("nama_acara").ToString()
                Dim tanggalDb As DateTime = Convert.ToDateTime(myDataReader("tanggal_pelaksanaan"))
                Dim tanggalPelaksanaan As String = tanggalDb.ToString("d MMMM yyyy")
                Dim namaPemesan As String = myDataReader("nama_pemesan").ToString()
                Dim alamat As String = myDataReader("alamat_pemesan").ToString()
                Dim noHpPertama As String = myDataReader("no_hp_pertama").ToString()
                Dim noHpKedua As String = myDataReader("no_hp_kedua").ToString()
                Dim waktuDb As String = myDataReader("waktu").ToString()
                Dim waktuTampil As String = Convert.ToDateTime(waktuDb).ToString("HH:mm")
                Dim lokasiAcara As String = myDataReader("lokasi").ToString()
                Dim kategoriAcara As String = myDataReader("kategori_acara").ToString()

                ' Hitung selisih hari
                Dim hMinus As Integer = (tanggalDb.Date - DateTime.Now.Date).Days

                ' Filter berdasarkan status
                If statusWaktu = "belum" AndAlso hMinus < 0 Then
                    Continue While ' Lewati acara lampau jika status ingin "belum"
                ElseIf statusWaktu = "selesai" AndAlso hMinus >= 0 Then
                    Continue While ' Lewati acara mendatang jika status ingin "selesai"
                End If

                ' Buat Panel
                Dim eventPanel As New Panel()
                eventPanel.Width = FlowLayoutPanel1.Width - 20
                eventPanel.Height = 60
                eventPanel.BackColor = Color.Beige
                eventPanel.Margin = New Padding(5)
                eventPanel.BorderStyle = BorderStyle.Fixed3D

                ' Label Nama Acara
                Dim lblAcara As New Label()
                lblAcara.Text = namaAcara
                lblAcara.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                lblAcara.AutoSize = True
                lblAcara.Location = New Point(10, 5)

                ' Label Info Tengah
                Dim lblInfo As New Label()
                lblInfo.Text = String.Format("Tanggal : {0,-20}  Pemesan : {1}", tanggalPelaksanaan, namaPemesan)
                lblInfo.Font = New Font("Segoe UI Semibold", 9)
                lblInfo.Width = eventPanel.Width - 150
                lblInfo.Height = 20
                lblInfo.TextAlign = ContentAlignment.MiddleLeft
                lblInfo.Location = New Point(10, 25)
                lblInfo.AutoSize = False

                ' Label Countdown
                Dim lblCountdown As New Label()
                lblCountdown.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                lblCountdown.Width = 70
                lblCountdown.Height = eventPanel.Height
                lblCountdown.TextAlign = ContentAlignment.MiddleCenter
                lblCountdown.AutoSize = False
                lblCountdown.BackColor = Color.Transparent

                If hMinus = 0 Then
                    lblCountdown.Text = "Hari-H"
                    lblCountdown.ForeColor = Color.Green
                ElseIf hMinus < 0 Then
                    lblCountdown.Text = "Selesai"
                    lblCountdown.ForeColor = Color.Gray
                ElseIf hMinus <= 7 Then
                    lblCountdown.Text = "H - " & hMinus
                    lblCountdown.ForeColor = Color.Red
                Else
                    lblCountdown.Text = "H - " & hMinus
                    lblCountdown.ForeColor = Color.Black
                End If

                lblCountdown.Location = New Point(eventPanel.Width - lblCountdown.Width - 5, 0)


                ' Tombol Laporan
                Dim btnLaporan As New Button()
                btnLaporan.Text = "Laporan"
                btnLaporan.Width = 70
                btnLaporan.Height = 25
                btnLaporan.Font = New Font("Segoe UI", 8, FontStyle.Regular)
                ' Menyelaraskan vertikal tombol ke tengah countdown
                Dim verticalCenter As Integer = lblCountdown.Top + (lblCountdown.Height - btnLaporan.Height) \ 2
                btnLaporan.Location = New Point(lblCountdown.Left - btnLaporan.Width - 10, verticalCenter)

                btnLaporan.BackColor = Color.FromArgb(13, 64, 41)
                btnLaporan.ForeColor = Color.White

                ' Event handler klik tombol laporan
                AddHandler btnLaporan.Click, Sub(senderBtn, eBtn)
                                                 BukaForm9(idAcara, namaAcara, tanggalDb, namaPemesan, alamat, noHpPertama, noHpKedua, waktuTampil, lokasiAcara)
                                             End Sub

                eventPanel.Controls.Add(btnLaporan)


                ' Event handler klik
                Dim isReadOnly = (statusWaktu = "selesai")
                AddHandler eventPanel.Click, Sub(sender, e) OpenForm5(idAcara, namaAcara, tanggalDb, namaPemesan, alamat, noHpPertama, noHpKedua, waktuTampil, lokasiAcara, kategoriAcara, isReadOnly)


                eventPanel.Controls.Add(lblAcara)
                eventPanel.Controls.Add(lblInfo)
                eventPanel.Controls.Add(lblCountdown)

                FlowLayoutPanel1.Controls.Add(eventPanel)
                allEventPanels.Add(eventPanel)

                lblInfo.Width = eventPanel.Width - lblCountdown.Width - 20
            End While

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If myDataReader IsNot Nothing AndAlso Not myDataReader.IsClosed Then
                myDataReader.Close()
            End If
        End Try
    End Sub

    Private Sub BukaForm9(idAcara As String, namaAcara As String, tanggalDb As Date, namaPemesan As String, alamat As String, noHpPertama As String, noHpKedua As String, waktuTampil As String, lokasiAcara As String)
        Dim form As New Form9()
        form.lblNama.Text = namaPemesan
        form.lblAlamat.Text = alamat
        form.lblNoHp1.Text = noHpPertama
        form.lblNoHp2.Text = noHpKedua
        form.lblNamaAcara.Text = namaAcara
        form.lblTanggal.Text = tanggalDb.ToString("dd-MM-yyyy")
        form.lblWaktu.Text = waktuTampil
        form.lblLokasi.Text = lokasiAcara
        form.originalIdAcara = idAcara
        form.TampilDataPaket()
        form.TampilDataTambahan()
        form.TampilPembayaran()

        myDataReader.Close()
        form.ShowDialog()
    End Sub

    Private Sub OpenForm5(idAcara As String, namaAcara As String, tanggalDb As Date, namaPemesan As String, alamat As String, noHpPertama As String, noHpKedua As String, waktuTampil As String, lokasiAcara As String, kategoriAcara As String, Optional readonlyMode As Boolean = False)
        Dim form As New Form5()

        ' Kirim data ke Form5
        form.tbNamaKegiatan.Text = namaAcara
        form.originalIdAcara = idAcara
        form.tbNamaPemesan.Text = namaPemesan
        form.tbAlamat.Text = alamat
        form.tbNoHpPertama.Text = noHpPertama
        form.tbNoHpKedua.Text = noHpKedua
        form.tglPelaksanaan.SetDate(tanggalDb)
        form.tbWaktu.Text = waktuTampil
        form.tbLokasi.Text = lokasiAcara
        form.cbKategori.SelectedItem = kategoriAcara
        form.tanggalAcara = tanggalDb



        If kategoriAcara = "Lain-lain" Then
            form.TabControl1.TabPages.Remove(form.TabControl1.TabPages("tpPaket"))
        End If

        If readonlyMode Then
            ' Nonaktifkan semua kontrol input
            For Each ctrl As Control In form.Controls
                DisableControlsRecursive(ctrl)
            Next

            ' Sembunyikan tombol simpan, tambah
            form.btnTambah.Visible = False
            form.btnSimpan.Visible = False

            ' Tampilkan pesan bahwa ini hanya tampilan data
            form.lblEdit.Text = "Detail Acara (Sudah Selesai)"
            form.lblEdit.Visible = True
            form.lblEdit.ForeColor = Color.Gray
        End If

        form.TampilDataPaket()
        form.TampilDataTambahan()
        form.totalTagihan()
        form.Pembayaran()


        ' Atur tampilan Form5 untuk mode edit
        form.lblBaru.Visible = False
        form.lblEdit.Visible = True
        form.btnTambah.Visible = False
        form.btnSimpan.Visible = True
        form.lblEdit.BringToFront()
        form.btnSimpan.BringToFront()

        ' Tampilkan Form5 secara modal agar menunggu selesai
        form.ShowDialog()
        myDataReader.Close()
    End Sub

    Private Sub tbCariAcara_TextChanged(sender As Object, e As EventArgs) Handles tbCariAcara.TextChanged
        Dim keyword As String = tbCariAcara.Text.ToLower()

        FlowLayoutPanel1.Controls.Clear()

        For Each panel As Panel In allEventPanels
            ' Gabungkan semua teks yang akan dicari
            Dim allText As String = ""
            For Each ctrl As Control In panel.Controls
                If TypeOf ctrl Is Label Then
                    allText &= CType(ctrl, Label).Text.ToLower() & " "
                End If
            Next

            ' Cek apakah mengandung keyword
            If allText.Contains(keyword) Then
                FlowLayoutPanel1.Controls.Add(panel)
            End If
        Next
        myDataReader.Close()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form2.Show()
        Me.Hide()
    End Sub


    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs)
        Dim keyword = tbCariAcara.Text.ToLower

        FlowLayoutPanel1.Controls.Clear()

        For Each panel In allEventPanels
            ' Gabungkan semua teks yang akan dicari
            Dim allText = ""
            For Each ctrl As Control In panel.Controls
                If TypeOf ctrl Is Label Then
                    allText &= CType(ctrl, Label).Text.ToLower & " "
                End If
            Next

            ' Cek apakah mengandung keyword
            If allText.Contains(keyword) Then
                FlowLayoutPanel1.Controls.Add(panel)
            End If
        Next
        myDataReader.Close()
    End Sub

    Private Sub cbWaktuKegiatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbWaktuKegiatan.SelectedIndexChanged
        If cbWaktuKegiatan.SelectedItem.ToString().ToLower().Contains("selesai") Then
            LoadEvents("selesai")
        Else
            LoadEvents("belum")
        End If
    End Sub

    Private Sub DisableControlsRecursive(ctrl As Control)
        If TypeOf ctrl Is TextBox Then
            CType(ctrl, TextBox).ReadOnly = True

        ElseIf TypeOf ctrl Is ComboBox Then
            CType(ctrl, ComboBox).Enabled = False

        ElseIf TypeOf ctrl Is DateTimePicker Then
            CType(ctrl, DateTimePicker).Enabled = False

        ElseIf TypeOf ctrl Is Button Then
            ' Biarkan btnBack tetap aktif
            If ctrl.Name <> "btnBack" Then
                ctrl.Enabled = False

                ' Jika warna asli hijau tua RGB(13,64,41), ubah ke abu-abu
                Dim originalColor As Color = CType(ctrl, Button).BackColor
                If originalColor = Color.FromArgb(13, 64, 41) Then
                    CType(ctrl, Button).BackColor = Color.Gray
                End If
            End If

        ElseIf TypeOf ctrl Is Label Then
            ' Jika label punya warna hijau tua, biarkan saja
            If CType(ctrl, Label).BackColor = Color.FromArgb(13, 64, 41) Then
                ' Tidak lakukan apa-apa
            Else
                ctrl.Enabled = False
            End If

        ElseIf TypeOf ctrl Is TabControl OrElse TypeOf ctrl Is TabPage Then
            ctrl.Enabled = True ' Biarkan tab tetap bisa diakses

        ElseIf TypeOf ctrl Is DataGridView Then
            CType(ctrl, DataGridView).ReadOnly = True
            CType(ctrl, DataGridView).Enabled = False

        Else
            ctrl.Enabled = False
        End If

        ' Rekursif ke semua anak kontrol
        For Each child As Control In ctrl.Controls
            DisableControlsRecursive(child)
        Next
    End Sub





End Class