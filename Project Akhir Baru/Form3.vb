Imports MySql.Data.MySqlClient

Public Class Form3
    Private allEventPanels As New List(Of Panel)()
    Private Sub Form3_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LoadEvents()
    End Sub
    Private Sub btnTambahAcara_Click(sender As Object, e As EventArgs) Handles btnTambahAcara.Click
        Form5.Show()
        Me.Hide()


    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Form1.Show()
        Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEvents()
    End Sub
    Private Sub LoadEvents()
        Try
            ' Buka koneksi
            'myConn.Open()

            ' Query untuk mengambil data acara
            Dim sql As String = "SELECT nama_acara, tanggal_pelaksanaan, nama_pemesan FROM acara ORDER BY tanggal_pelaksanaan ASC"
            myCommand = New MySqlCommand(sql, myConn)
            myDataReader = myCommand.ExecuteReader()

            ' Bersihkan Panel sebelum menambahkan data
            FlowLayoutPanel1.Controls.Clear()
            allEventPanels.Clear()



            ' Loop melalui hasil query dan tampilkan data
            While myDataReader.Read()
                ' Ambil data dari database
                Dim namaAcara As String = myDataReader("nama_acara").ToString()
                Dim tanggalPelaksanaan As String = Convert.ToDateTime(myDataReader("tanggal_pelaksanaan")).ToString("d MMMM yyyy")
                Dim namaPemesan As String = myDataReader("nama_pemesan").ToString()

                ' Hitung H- berdasarkan tanggal pelaksanaan
                Dim hMinus As Integer = (Convert.ToDateTime(tanggalPelaksanaan) - DateTime.Now).Days

                If hMinus < 0 Then
                    Continue While ' Lewati acara yang sudah lewat
                End If

                ' Buat Panel untuk menampilkan acara
                Dim eventPanel As New Panel()
                eventPanel.Width = FlowLayoutPanel1.Width - 20
                eventPanel.Height = 60
                eventPanel.BackColor = Color.Beige
                eventPanel.Margin = New Padding(5)
                eventPanel.BorderStyle = BorderStyle.Fixed3D

                ' Buat Label untuk menampilkan informasi acara
                Dim lblAcara As New Label()
                lblAcara.Text = namaAcara
                lblAcara.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                lblAcara.AutoSize = True
                lblAcara.Location = New Point(10, 5)

                Dim lblInfo As New Label()
                lblInfo.Text = $"Tanggal Pelaksanaan: {tanggalPelaksanaan}          Pemesan: {namaPemesan}          H - {hMinus}"
                lblInfo.Font = New Font("Segoe UI Semibold", 9)
                lblInfo.Width = eventPanel.Width - 20  ' Beri ruang cukup untuk teks agar tidak turun ke bawah
                lblInfo.Height = 20  ' Sesuaikan tinggi agar tetap satu baris
                lblInfo.TextAlign = ContentAlignment.MiddleLeft  ' Pastikan teks tetap di kiri
                lblInfo.Location = New Point(10, 25)
                lblInfo.AutoSize = False  ' Cegah teks turun ke baris kedua

                AddHandler eventPanel.Click, Sub(sender, e) OpenForm5(namaAcara, tanggalPelaksanaan, namaPemesan, hMinus)

                ' Tambahkan label ke panel
                eventPanel.Controls.Add(lblAcara)
                eventPanel.Controls.Add(lblInfo)

                ' Tambahkan panel ke FlowLayoutPanel
                FlowLayoutPanel1.Controls.Add(eventPanel)
                allEventPanels.Add(eventPanel)
            End While

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Tutup koneksi
            If myDataReader IsNot Nothing AndAlso Not myDataReader.IsClosed Then
                myDataReader.Close()
            End If
            'myConn.Close()
        End Try
    End Sub
    Private Sub OpenForm5(namaAcara As String, tanggal As String, pemesan As String, hMinus As Integer)
        Dim form As New Form5()

        ' Kirim data ke Form3 (misalnya lewat Label di Form3)
        form.tbNamaKegiatan.Text = namaAcara
        'form.lblTanggal.Text = "Tanggal: " & tanggal
        form.tbNamaPemesan.Text = pemesan
        'form.lblHMinus.Text = "H - " & hMinus

        ' Tampilkan Form3
        form.Show()

        ' Sembunyikan Form1 (jika perlu)
        ' Me.Hide()
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
    End Sub
End Class