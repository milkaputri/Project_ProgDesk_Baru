Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form5
    Public originalIdAcara As String
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim waktuInput As String = tbWaktu.Text
        Dim waktuValid As DateTime = Convert.ToDateTime(waktuInput)
        Dim kategoriAcara As String = cbKategori.SelectedItem.ToString()
        If DateTime.TryParse(waktuInput, waktuValid) Then
            Dim waktuUntukDb As String = waktuValid.ToString("HH:mm:ss")
            Dim sql As String = "insert into acara(nama_acara,tanggal_pelaksanaan,waktu,lokasi,nama_pemesan,alamat_pemesan,no_hp_pertama,no_hp_kedua, kategori_acara) values ('" & tbNamaKegiatan.Text & "','" & tglPelaksanaan.SelectionStart.ToString("yyyy-MM-dd") & "','" & waktuUntukDb & "','" & tbLokasi.Text & "','" & tbNamaPemesan.Text & "','" & tbAlamat.Text & "','" & tbNoHpPertama.Text & "','" & tbNoHpKedua.Text & "','" & kategoriAcara & "')"
            myCommand.CommandText = sql
            myCommand.ExecuteNonQuery()
            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Form3.Show()
        Else
            MessageBox.Show("Format waktu tidak valid. Contoh: 14:30 atau 2:30 PM", "Error")
        End If


    End Sub

    'Code untuk CheckBox di Tab "Paket" '
    Private Sub cbJasmine_CheckedChanged(sender As Object, e As EventArgs) Handles cbJasmine.CheckedChanged
        If cbJasmine.Checked Then
            SembunyikanCheckboxLain(cbJasmine)
            TampilPaket(1)
        Else
            TampilkanSemuaCheckbox()
            UncheckedBox(1)
        End If
    End Sub
    Private Sub cbOrchid_CheckedChanged(sender As Object, e As EventArgs) Handles cbOrchid.CheckedChanged
        If cbOrchid.Checked Then
            SembunyikanCheckboxLain(cbOrchid)
            TampilPaket(2)
        Else
            TampilkanSemuaCheckbox()
            UncheckedBox(2)
        End If
    End Sub

    Private Sub cbTulip_CheckedChanged(sender As Object, e As EventArgs) Handles cbTulip.CheckedChanged
        If cbTulip.Checked Then
            SembunyikanCheckboxLain(cbTulip)
            TampilPaket(3)
        Else
            TampilkanSemuaCheckbox()
            UncheckedBox(3)
        End If
    End Sub

    Private Sub cbCasablanca_CheckedChanged(sender As Object, e As EventArgs) Handles cbCasablanca.CheckedChanged
        If cbCasablanca.Checked Then
            SembunyikanCheckboxLain(cbCasablanca)
            TampilPaket(4)
        Else
            TampilkanSemuaCheckbox()
            UncheckedBox(4)
        End If
    End Sub
    Private Sub cbAkad_CheckedChanged(sender As Object, e As EventArgs) Handles cbAkad.CheckedChanged
        If cbAkad.Checked Then
            SembunyikanCheckboxLain(cbAkad)
            TampilPaket(5)
        Else
            TampilkanSemuaCheckbox()
            UncheckedBox(5)
        End If
    End Sub
    Private Sub cbGereja_CheckedChanged(sender As Object, e As EventArgs) Handles cbGereja.CheckedChanged
        If cbGereja.Checked Then
            SembunyikanCheckboxLain(cbGereja)
            TampilPaket(6)
        Else
            TampilkanSemuaCheckbox()
            UncheckedBox(6)
        End If
    End Sub

    Private Sub cbKrisan_CheckedChanged(sender As Object, e As EventArgs) Handles cbKrisan.CheckedChanged
        If cbKrisan.Checked Then
            SembunyikanCheckboxLain(cbKrisan)
            TampilPaket(7)
        Else
            TampilkanSemuaCheckbox()
            UncheckedBox(7)
        End If
    End Sub

    Private Sub cbGarbera_CheckedChanged(sender As Object, e As EventArgs) Handles cbGarbera.CheckedChanged
        If cbGarbera.Checked Then
            SembunyikanCheckboxLain(cbGarbera)
            TampilPaket(8)
        Else
            TampilkanSemuaCheckbox()
            UncheckedBox(8)
        End If
    End Sub

    Private Sub cbHorten_CheckedChanged(sender As Object, e As EventArgs) Handles cbHorten.CheckedChanged
        If cbHorten.Checked Then
            SembunyikanCheckboxLain(cbHorten)
            TampilPaket(9)
        Else
            TampilkanSemuaCheckbox()
            UncheckedBox(9)
        End If
    End Sub

    Private Sub cbKalalily_CheckedChanged(sender As Object, e As EventArgs) Handles cbKalalily.CheckedChanged
        If cbKalalily.Checked Then
            SembunyikanCheckboxLain(cbKalalily)
            TampilPaket(10)
        Else
            TampilkanSemuaCheckbox()
            UncheckedBox(10)
        End If
    End Sub

    Private Sub SembunyikanCheckboxLain(cbYangAktif As CheckBox)
        For Each ctrl As Control In Me.Controls
            SembunyikanDalamKontainer(ctrl, cbYangAktif)
        Next
    End Sub

    Private Sub SembunyikanDalamKontainer(container As Control, cbYangAktif As CheckBox)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is CheckBox AndAlso ctrl IsNot cbYangAktif Then
                ctrl.Visible = False
            End If
            If ctrl.HasChildren Then
                SembunyikanDalamKontainer(ctrl, cbYangAktif)
            End If
        Next
    End Sub

    Private Sub TampilkanSemuaCheckbox()
        For Each ctrl As Control In Me.Controls
            TampilkanCheckboxDalamKontainer(ctrl)
        Next
    End Sub

    Private Sub TampilkanCheckboxDalamKontainer(container As Control)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is CheckBox Then
                ctrl.Visible = True
            End If
            If ctrl.HasChildren Then
                TampilkanCheckboxDalamKontainer(ctrl)
            End If
        Next
    End Sub


    'Code untuk jumlah pembeliah di tab "Tambahan" '
    ' Pras A  '
    Private Sub btnMinPaketA_Click(sender As Object, e As EventArgs) Handles btnMinPrasA.Click
        ' Mengurangkan nilai di tbPaketA
        If IsNumeric(tbPrasA.Text) Then
            Dim nilai As Integer = Integer.Parse(tbPrasA.Text)
            If nilai = 300 Then
                tbPrasA.Text = "0"
                TampilTambahan("Prasmanan A", tbPrasA.Text.ToString(), 34500, 11)
                UpdateTotalHargaTambahan()
            ElseIf nilai > 300 Then
                tbPrasA.Text = (nilai - 1).ToString()
                TampilTambahan("Prasmanan A", tbPrasA.Text.ToString(), 34500, 11)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbPrasA.Text = "0"
        End If

    End Sub

    Private Sub btnPlusPaketA_Click(sender As Object, e As EventArgs) Handles btnPlusPrasA.Click
        ' Menambahkan nilai di tbPaketA
        If IsNumeric(tbPrasA.Text) Then
            Dim nilai As Integer = Integer.Parse(tbPrasA.Text)
            If nilai = 0 Then
                tbPrasA.Text = "300"
                TampilTambahan("Prasmanan A", tbPrasA.Text.ToString(), 34500, 11)
                UpdateTotalHargaTambahan()
            ElseIf nilai >= 300 Then
                tbPrasA.Text = (nilai + 1).ToString()
                TampilTambahan("Prasmanan A", tbPrasA.Text.ToString(), 34500, 11)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbPrasA.Text = "300"
            TampilTambahan("Prasmanan A", tbPrasA.Text.ToString(), 34500, 11)
            UpdateTotalHargaTambahan()
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketA
    Private Sub tbPaketA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPrasA.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbPaketA_Leave(sender As Object, e As EventArgs) Handles tbPrasA.Leave
        If String.IsNullOrWhiteSpace(tbPrasA.Text) OrElse Not IsNumeric(tbPrasA.Text) Then
            tbPrasA.Text = "0"
        End If
    End Sub

    ' Pras B '
    Private Sub btnMinPaketB_Click(sender As Object, e As EventArgs) Handles btnMinPrasB.Click
        ' Mengurangkan nilai di tbPaketB
        If IsNumeric(tbPrasB.Text) Then
            Dim nilai As Integer = Integer.Parse(tbPrasB.Text)
            If nilai = 300 Then
                tbPrasB.Text = "0"
                TampilTambahan("Prasmanan B", tbPrasB.Text.ToString(), 37000, 12)
                UpdateTotalHargaTambahan()
            ElseIf nilai > 300 Then
                tbPrasB.Text = (nilai - 1).ToString()
                TampilTambahan("Prasmanan B", tbPrasB.Text.ToString(), 37000, 12)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbPrasB.Text = "0"
        End If
    End Sub

    Private Sub btnPlusPaketB_Click(sender As Object, e As EventArgs) Handles btnPlusPrasB.Click
        ' Menambahkan nilai di tbPaketB
        If IsNumeric(tbPrasB.Text) Then
            Dim nilai As Integer = Integer.Parse(tbPrasB.Text)
            If nilai = 0 Then
                tbPrasB.Text = "300"
            ElseIf nilai >= 300 Then
                tbPrasB.Text = (nilai + 1).ToString()
                TampilTambahan("Prasmanan B", tbPrasB.Text.ToString(), 37000, 12)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbPrasB.Text = "300"
            TampilTambahan("Prasmanan B", tbPrasB.Text.ToString(), 37000, 12)
            UpdateTotalHargaTambahan()
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketB
    Private Sub tbPrassC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPrasB.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbPrassC_KeyPress(sender As Object, e As EventArgs) Handles tbPrasB.Leave
        If String.IsNullOrWhiteSpace(tbPrasB.Text) OrElse Not IsNumeric(tbPrasB.Text) Then
            tbPrasB.Text = "0"
        End If
    End Sub

    ' Pras C '
    Private Sub btnMinPrassC_Click(sender As Object, e As EventArgs) Handles btnMinPrasC.Click
        ' Mengurangkan nilai di tbPaketC
        If IsNumeric(tbPrasC.Text) Then
            Dim nilai As Integer = Integer.Parse(tbPrasC.Text)
            If nilai = 300 Then
                tbPrasC.Text = "0"
                TampilTambahan("Prasmanan C", tbPrasC.Text.ToString(), 40500, 13)
                UpdateTotalHargaTambahan()
            ElseIf nilai > 300 Then
                tbPrasC.Text = (nilai - 1).ToString()
                TampilTambahan("Prasmanan C", tbPrasC.Text.ToString(), 40500, 13)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbPrasC.Text = "0"
        End If
    End Sub

    Private Sub btnPlusPrasC_Click(sender As Object, e As EventArgs) Handles btnPlusPrasC.Click
        ' Menambahkan nilai di tbPaketB
        If IsNumeric(tbPrasC.Text) Then
            Dim nilai As Integer = Integer.Parse(tbPrasC.Text)
            If nilai = 0 Then
                tbPrasC.Text = "300"
            ElseIf nilai >= 300 Then
                tbPrasC.Text = (nilai + 1).ToString()
                TampilTambahan("Prasmanan C", tbPrasC.Text.ToString(), 40500, 13)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbPrasC.Text = "300"
            TampilTambahan("Prasmanan C", tbPrasC.Text.ToString(), 40500, 13)
            UpdateTotalHargaTambahan()
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketB
    Private Sub tbPaketB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPrasB.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbPaketB_Leave(sender As Object, e As EventArgs) Handles tbPrasB.Leave
        If String.IsNullOrWhiteSpace(tbPrasB.Text) OrElse Not IsNumeric(tbPrasB.Text) Then
            tbPrasB.Text = "0"
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form3.Hide()
        SetWarnaKontrolPembayaran(False, False)
        totalTagihan()
    End Sub

    Private Sub Panel19_Paint(sender As Object, e As PaintEventArgs) Handles Panel19.Paint

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form3.Show()
        Hide()
    End Sub
    Private Sub llJasmine_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llJasmine.LinkClicked
        ' Create an instance of Form6
        Dim detailForm As New Form6()

        ' Show Form6
        detailForm.Show()

        ' Make pnlDetailJasmine visible and hide other panels
        detailForm.pnlDetailJasmine.Visible = True
        detailForm.pnlDetailOrchid.Visible = False

        ' Optional: Bring the panel to front if there are overlapping controls
        detailForm.pnlDetailJasmine.BringToFront()

        'Me.Hide()
    End Sub

    Private Sub llOrchid_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llOrchid.LinkClicked
        ' Create an instance of Form6
        Dim detailForm As New Form6()

        ' Show Form6
        detailForm.Show()

        ' Make pnlDetailJasmine visible and hide other panels
        detailForm.pnlDetailJasmine.Visible = False
        detailForm.pnlDetailOrchid.Visible = True

        ' Optional: Bring the panel to front if there are overlapping controls
        detailForm.pnlDetailOrchid.BringToFront()
        'Me.Hide()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            ' Validate required fields
            If String.IsNullOrEmpty(tbNamaKegiatan.Text) Then
                MessageBox.Show("Nama kegiatan harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Prepare the SQL update command
            Dim sql As String = "UPDATE acara SET " &
                           "nama_acara = @nama_acara, " &
                           "tanggal_pelaksanaan = @tanggal, " &
                           "waktu = @waktu, " &
                           "lokasi = @lokasi, " &
                           "nama_pemesan = @pemesan, " &
                           "alamat_pemesan = @alamat, " &
                           "no_hp_pertama = @hp1, " &
                           "no_hp_kedua = @hp2 " &
                           "WHERE id_acara = @id_acara"

            ' Create and configure the command with parameters to prevent SQL injection
            myCommand.CommandText = sql
            myCommand.Parameters.Clear()
            myCommand.Parameters.AddWithValue("@nama_acara", tbNamaKegiatan.Text)
            myCommand.Parameters.AddWithValue("@tanggal", tglPelaksanaan.SelectionStart.ToString("yyyy-MM-dd"))
            myCommand.Parameters.AddWithValue("@waktu", tbWaktu.Text)
            myCommand.Parameters.AddWithValue("@lokasi", tbLokasi.Text)
            myCommand.Parameters.AddWithValue("@pemesan", tbNamaPemesan.Text)
            myCommand.Parameters.AddWithValue("@alamat", tbAlamat.Text)
            myCommand.Parameters.AddWithValue("@hp1", tbNoHpPertama.Text)
            myCommand.Parameters.AddWithValue("@hp2", tbNoHpKedua.Text)
            myCommand.Parameters.AddWithValue("@id_acara", originalIdAcara)

            ' Execute the update
            Dim rowsAffected As Integer = myCommand.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh data di Form3
                Dim form3 As Form3 = Application.OpenForms.OfType(Of Form3).FirstOrDefault()
                If form3 IsNot Nothing Then
                    form3.LoadEvents()
                    form3.Show() ' Tampilkan kembali Form3
                End If

                Me.Close() ' Tutup Form5

                ' Close the form or reset fields as needed
                form3.Show()
            Else
                MessageBox.Show("Tidak ada data yang diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error saat memperbarui data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myCommand.Parameters.Clear()
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tbNamaKegiatan.Text = ""
        originalIdAcara = ""
        tbNamaPemesan.Text = ""
        tbAlamat.Text = ""
        tbNoHpPertama.Text = ""
        tbNoHpKedua.Text = ""
        tbLokasi.Text = ""

    End Sub
    Private Sub TampilPaket(idPaket As Integer)
        Dim i
        i = 0
        Dim sqlPaket As String = "SELECT * FROM detail_paket where id_paket = " & idPaket
        myCommand.CommandText = sqlPaket
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            While myDataReader.Read()
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = myDataReader("nama_paket")
                DataGridView1.Item(1, i).Value = "1"
                DataGridView1.Item(2, i).Value = myDataReader("harga_paket")
                DataGridView1.Item(3, i).Value = idPaket.ToString
                Dim totalPaket As Integer = myDataReader("harga_paket")
                lblTotalHargaPaket.Text = totalPaket.ToString("N0")
                i = i + 1
            End While
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub
    Private Sub TampilTambahan(nama_paket As String, jumlah As Integer, harga As Integer, idTambahan As Integer)
        Dim found As Boolean = False
        For Each row As DataGridViewRow In DataGridView2.Rows
            If Not row.IsNewRow AndAlso row.Cells("colPaketTambahan").Value = nama_paket Then
                row.Cells("colJumlahTambahan").Value = jumlah
                row.Cells("colTotalTambahan").Value = jumlah * harga
                row.Cells("colIdTambahan").Value = idTambahan
                found = True
                If row.Cells("colJumlahTambahan").Value = 0 Then
                    DataGridView2.Rows.Remove(row)
                End If
                Exit For
            End If
        Next

        If Not found Then
            DataGridView2.Rows.Add(nama_paket, jumlah, jumlah * harga, idTambahan)
        End If
    End Sub

    Private Sub UpdateTotalHargaTambahan()
        Dim totalPengeluaran As Integer = 0
        For Each row As DataGridViewRow In DataGridView2.Rows
            If Not row.IsNewRow AndAlso Not IsDBNull(row.Cells("colTotalTambahan").Value) Then
                totalPengeluaran += Convert.ToInt32(row.Cells("colTotalTambahan").Value)
            End If
        Next

        lblTotalHargaTambahan.Text = totalPengeluaran.ToString("N0")
    End Sub
    Private Sub UncheckedBox(idPaket As Integer)
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow AndAlso Convert.ToInt32(row.Cells("ColId").Value) = idPaket Then
                DataGridView1.Rows.Remove(row)
                lblTotalHargaPaket.Text = "0"
                Exit For
            End If
        Next
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub
    Private Sub btnBersihkanPaket_Click(sender As Object, e As EventArgs) Handles btnBersihkanPaket.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                Dim idTerpilih As Integer = row.Cells("ColId").Value
                If Not row.IsNewRow Then
                    myDataReader.Close()
                    Dim sql1 As String = "DELETE FROM pesanan WHERE id_paket = " & idTerpilih & " AND id_acara = " & originalIdAcara
                    myCommand.CommandText = sql1
                    myCommand.ExecuteNonQuery()
                    DataGridView1.Rows.Remove(row)
                    lblTotalHargaPaket.Text = "0"
                    MessageBox.Show("Data berhasil dihapus.")
                    Select Case idTerpilih
                        Case "1"
                            cbJasmine.Checked = False
                            TampilkanSemuaCheckbox()
                            cbJasmine.Enabled = True
                        Case "2"
                            cbOrchid.Checked = False
                            TampilkanSemuaCheckbox()
                            cbOrchid.Enabled = True
                        Case "3"
                            cbTulip.Checked = False
                            TampilkanSemuaCheckbox()
                            cbTulip.Enabled = True
                        Case "4"
                            cbCasablanca.Checked = False
                            TampilkanSemuaCheckbox()
                            cbCasablanca.Enabled = True
                        Case "5"
                            cbAkad.Checked = False
                            TampilkanSemuaCheckbox()
                            cbAkad.Enabled = True
                        Case "6"
                            cbGereja.Checked = False
                            TampilkanSemuaCheckbox()
                            cbGereja.Enabled = True
                        Case "7"
                            cbKrisan.Checked = False
                            TampilkanSemuaCheckbox()
                            cbKrisan.Enabled = True
                        Case "8"
                            cbGarbera.Checked = False
                            TampilkanSemuaCheckbox()
                            cbGarbera.Enabled = True
                        Case "9"
                            cbHorten.Checked = False
                            TampilkanSemuaCheckbox()
                            cbHorten.Enabled = True
                        Case "10"
                            cbKalalily.Checked = False
                            TampilkanSemuaCheckbox()
                            cbKalalily.Enabled = True
                    End Select
                    Exit For
                Else
                    MessageBox.Show("Data gagal dihapus.")
                End If
            Next
        Else
            MessageBox.Show("Silakan pilih baris yang ingin dihapus.")
        End If
        totalTagihan()
    End Sub
    Private Sub btnSimpanPaket_Click(sender As Object, e As EventArgs) Handles btnSimpanPaket.Click
        Dim angka As Integer = Convert.ToInt32(lblTotalHargaPaket.Text.Replace(",", ""))
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim id_paket As Integer = Integer.Parse(row.Cells("colId").Value.ToString())
                Dim jumlah_paket As Integer = Integer.Parse(row.Cells("colJumlah").Value.ToString())
                Dim sql As String = "INSERT INTO pesanan (id_acara, id_paket, total_pengeluaran, jumlah_paket) VALUES ('" & originalIdAcara & "','" & id_paket & "','" & angka & "','" & jumlah_paket & "')"
                myCommand.CommandText = sql
                myCommand.ExecuteNonQuery()
                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Next
        If cbJasmine.Checked Then cbJasmine.Enabled = False
        If cbOrchid.Checked Then cbOrchid.Enabled = False
        If cbTulip.Checked Then cbTulip.Enabled = False
        If cbCasablanca.Checked Then cbCasablanca.Enabled = False
        If cbAkad.Checked Then cbAkad.Enabled = False
        If cbGereja.Checked Then cbGereja.Enabled = False
        If cbKrisan.Checked Then cbKrisan.Enabled = False
        If cbGarbera.Checked Then cbGarbera.Enabled = False
        If cbHorten.Checked Then cbHorten.Enabled = False
        If cbKalalily.Checked Then cbKalalily.Enabled = False
        totalTagihan()
    End Sub

    Public Sub TampilDataPaket()
        Dim i
        i = 0
        Dim sql As String = "select * from pesanan join detail_paket on pesanan.id_paket = detail_paket.id_paket where id_acara = " & originalIdAcara & " AND pesanan.id_paket BETWEEN 1 AND 10"
        myCommand.CommandText = sql
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            While myDataReader.Read()
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = myDataReader("nama_paket")
                DataGridView1.Item(1, i).Value = "1"
                DataGridView1.Item(2, i).Value = myDataReader("harga_paket")
                DataGridView1.Item(3, i).Value = myDataReader("id_paket")
                lblTotalHargaPaket.Text = myDataReader("harga_paket")
                i = i + 1
            End While
            myDataReader.Close()
        End If
        Select Case DataGridView1.Item(3, 0).Value
            Case "1"
                cbJasmine.Checked = True
                SembunyikanCheckboxLain(cbJasmine)
                cbJasmine.Enabled = False
            Case "2"
                cbOrchid.Checked = True
                SembunyikanCheckboxLain(cbOrchid)
                cbOrchid.Enabled = False
            Case "3"
                cbTulip.Checked = True
                SembunyikanCheckboxLain(cbTulip)
                cbTulip.Enabled = False
            Case "4"
                cbCasablanca.Checked = True
                SembunyikanCheckboxLain(cbCasablanca)
                cbCasablanca.Enabled = False
            Case "5"
                cbAkad.Checked = True
                SembunyikanCheckboxLain(cbAkad)
                cbAkad.Enabled = False
            Case "6"
                cbGereja.Checked = True
                SembunyikanCheckboxLain(cbGereja)
                cbGereja.Enabled = False
            Case "7"
                cbKrisan.Checked = True
                SembunyikanCheckboxLain(cbKrisan)
                cbKrisan.Enabled = False
            Case "8"
                cbGarbera.Checked = True
                SembunyikanCheckboxLain(cbGarbera)
                cbGarbera.Enabled = False
            Case "9"
                cbHorten.Checked = True
                SembunyikanCheckboxLain(cbHorten)
                cbHorten.Enabled = False
            Case "10"
                cbKalalily.Checked = True
                SembunyikanCheckboxLain(cbKalalily)
                cbKalalily.Enabled = False
        End Select
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Public Sub TampilDataTambahan()
        'Dim sudahAda As Boolean = False
        Dim i
        i = 0
        Dim sql As String = "select * from pesanan join detail_paket on pesanan.id_paket = detail_paket.id_paket where id_acara = " & originalIdAcara & " AND pesanan.id_paket BETWEEN 11 AND 51"
        myCommand.CommandText = sql
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            While myDataReader.Read()
                Dim harga As Integer = myDataReader("harga_paket")
                Dim jumlah As Integer = myDataReader("jumlah_paket")
                DataGridView2.Rows.Add()
                DataGridView2.Item(0, i).Value = myDataReader("nama_paket")
                DataGridView2.Item(1, i).Value = myDataReader("jumlah_paket")
                DataGridView2.Item(2, i).Value = harga * jumlah
                DataGridView2.Item(3, i).Value = myDataReader("id_paket")

                Select Case myDataReader("nama_paket")
                    Case "Prasmanan A"
                        tbPrasA.Text = jumlah.ToString()
                    Case "Prasmanan B"
                        tbPrasB.Text = jumlah.ToString()
                    Case "Prasmanan C"
                        tbPrasC.Text = jumlah.ToString()
                    Case "Stall 1 - Ice Puter + Agar-agar"
                        cbIcePuter.Checked = True
                        tbIcePuter.Text = jumlah.ToString()
                    Case "Stall 1 - Teh"
                        cbTeh.Checked = True
                        tbTeh.Text = jumlah.ToString()
                    Case "Stall 1 - Es Seruni"
                        cbEsSeruni.Checked = True
                        tbEsSeruni.Text = jumlah.ToString()
                    Case "Stall 1 - Buah Iris"
                        cbBuahIris.Checked = True
                        tbBuahIris.Text = jumlah.ToString()
                    Case "Stall 2 - Es Dawet"
                        cbEsDawet.Checked = True
                        tbEsDawet.Text = jumlah.ToString()
                    Case "Stall 2 - Es Selasih"
                        cbEsSelasih.Checked = True
                        tbEsSelasih.Text = jumlah.ToString()
                    Case "Stall 2 - Rujak Ice Cream"
                        cbRujak.Checked = True
                        tbRujak.Text = jumlah.ToString()
                    Case "Stall 2 - Jus Jeruk"
                        cbJusJeruk.Checked = True
                        tbJusJeruk.Text = jumlah.ToString()
                    Case "Stall 3 - Wedang Ronde"
                        cbWedangRonde.Checked = True
                        tbWedangRonde.Text = jumlah.ToString()
                    Case "Stall 3 - Es Doger"
                        cbEsDoger.Checked = True
                        tbEsDoger.Text = jumlah.ToString()
                    Case "Stall 3 - Pecel Pincuk"
                        cbPecelPincuk.Checked = True
                        tbPecelPincuk.Text = jumlah.ToString()
                    Case "Stall 4 - Bakso"
                        cbBakso.Checked = True
                        tbBakso.Text = jumlah.ToString()
                    Case "Stall 4 - Siomay"
                        cbSiomay.Checked = True
                        tbSiomay.Text = jumlah.ToString()
                    Case "Stall 4 - Salad Buah"
                        cbSaladBuah.Checked = True
                        tbSaladBuah.Text = jumlah.ToString()
                    Case "Stall 4 - Selat Solo"
                        cbSelatSolo.Checked = True
                        tbSelatSolo.Text = jumlah.ToString()
                    Case "Stall 5 - Empek-Empek"
                        cbEmpek.Checked = True
                        tbEmpek.Text = jumlah.ToString()
                    Case "Stall 5 - Gado-Gado"
                        cbGado.Checked = True
                        tbGado.Text = jumlah.ToString()
                    Case "Stall 5 - Sate ayam + lontong"
                        cbSateAyam.Checked = True
                        tbSate.Text = jumlah.ToString()
                    Case "Stall 5 - Mie Oriental"
                        cbMieOriental.Checked = True
                        tbMie.Text = jumlah.ToString()
                    Case "Stall 6 - Nasi Liwet Solo"
                        cbNasiLiwetSolo.Checked = True
                        tbNasiLiwet.Text = jumlah.ToString()
                    Case "Stall 6 - Nasi Rawon"
                        cbNasiRawon.Checked = True
                        tbNasiRawon.Text = jumlah.ToString()
                    Case "Stall 6 - Kebab"
                        cbKebab.Checked = True
                        tbKebab.Text = jumlah.ToString()
                    Case "Stall 6 - Dim Sum"
                        cbDimSum.Checked = True
                        tbDimSum.Text = jumlah.ToString()
                    Case "Nasi Dos Syukuran 1"
                        tbSyukur1.Text = jumlah.ToString()
                    Case "Nasi Dos Syukuran 2"
                        tbSyukur2.Text = jumlah.ToString()
                    Case "Nasi Dos Syukuran 3"
                        tbSyukur3.Text = jumlah.ToString()
                    Case "Nasi Dos Syukuran 4"
                        tbSyukur4.Text = jumlah.ToString()
                    Case "Nasi Dos 1"
                        tbDos1.Text = jumlah.ToString()
                    Case "Nasi Dos 2"
                        tbDos2.Text = jumlah.ToString()
                    Case "Nasi Dos 3"
                        tbDos3.Text = jumlah.ToString()
                    Case "Snack Box 1"
                        tbSnack1.Text = jumlah.ToString()
                    Case "Snack Box 2"
                        tbSnack2.Text = jumlah.ToString()
                End Select
                i = i + 1
            End While

            Dim totalPengeluaran As Integer = 0
            For Each row As DataGridViewRow In DataGridView2.Rows
                If Not row.IsNewRow AndAlso Not IsDBNull(row.Cells("colTotalTambahan").Value) Then
                    totalPengeluaran += Convert.ToInt32(row.Cells("colTotalTambahan").Value)
                End If
            Next

            lblTotalHargaTambahan.Text = totalPengeluaran.ToString("N0")
            myDataReader.Close()
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub btnSimpanTambahan_Click(sender As Object, e As EventArgs) Handles btnSimpanTambahan.Click
        For Each row As DataGridViewRow In DataGridView2.Rows
            If Not row.IsNewRow Then
                Dim id_paket As Integer = Integer.Parse(row.Cells("colIdTambahan").Value.ToString())
                Dim namaPaket As String = row.Cells("colPaketTambahan").Value.ToString()
                Dim jumlah_paket As Integer = Integer.Parse(row.Cells("colJumlahTambahan").Value.ToString())
                Dim totalPerTambahan As Integer = Integer.Parse(row.Cells("colTotalTambahan").Value.ToString())
                'Dim sqlCek As String = "SELECT COUNT(*) FROM pesanan WHERE id_paket = '" & id_paket & "'"
                Dim sqlCek As String = "SELECT COUNT(*) FROM pesanan WHERE id_acara = '" & originalIdAcara & "' AND id_paket = '" & id_paket & "'"
                myCommand.CommandText = sqlCek
                Dim count As Integer = Convert.ToInt32(myCommand.ExecuteScalar())

                If count > 0 Then
                    Dim sql As String = "UPDATE pesanan SET " &
                           "total_pengeluaran = " & totalPerTambahan & "," &
                           "jumlah_paket = " & jumlah_paket & " " &
                           "WHERE id_acara = " & originalIdAcara & " AND id_paket = " & id_paket
                    myCommand.CommandText = sql
                    myCommand.ExecuteNonQuery()
                Else
                    Dim sql As String = "INSERT INTO pesanan (id_acara, id_paket, total_pengeluaran, jumlah_paket) VALUES ('" & originalIdAcara & "','" & id_paket & "','" & totalPerTambahan & "','" & jumlah_paket & "')"
                    myCommand.CommandText = sql
                    myCommand.ExecuteNonQuery()
                End If
            End If
        Next
        MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        totalTagihan()
    End Sub

    Private Sub btnBersihkanTambahan_Click(sender As Object, e As EventArgs) Handles btnBersihkanTambahan.Click
        'DataGridView2.Rows.Clear()
        'lblTotalHargaTambahan.Text = "0"
        'tbPrasA.Text = ""
        'tbPrasB.Text = ""
        'tbPrasC.Text = ""
        If DataGridView2.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In DataGridView2.SelectedRows
                Dim idTerpilih As Integer = row.Cells("ColIdTambahan").Value
                If Not row.IsNewRow Then
                    myDataReader.Close()
                    Dim sql1 As String = "DELETE FROM pesanan WHERE id_paket = " & idTerpilih & " AND id_acara = " & originalIdAcara
                    myCommand.CommandText = sql1
                    myCommand.ExecuteNonQuery()
                    DataGridView2.Rows.Remove(row)
                    'lblTotalHargaPaket.Text = "0"
                    UpdateTotalHargaTambahan()
                    MessageBox.Show("Data berhasil dihapus.")
                    Select Case idTerpilih
                        Case 11
                            tbPrasA.Text = "0"
                        Case 12
                            tbPrasB.Text = "0"
                        Case 13
                            tbPrasC.Text = "0"
                    End Select
                    Exit For
                Else
                    MessageBox.Show("Data gagal dihapus.")
                End If
            Next
        Else
            MessageBox.Show("Silakan pilih baris yang ingin dihapus.")
        End If
        totalTagihan()
    End Sub

    Private Sub SembunyikanCheckboxLainStall(cbYangAktif As CheckBox)
        Dim selectedCheckBox As CheckBox = CType(cbYangAktif, CheckBox)
        For Each ctrl As Control In panelStall1.Controls
            If TypeOf ctrl Is CheckBox AndAlso ctrl IsNot selectedCheckBox Then
                ctrl.Visible = False
            End If
        Next
    End Sub

    'Private Sub TampilTambahanStall(nama_paket As String, jumlah As Integer, harga As Integer, idTambahan As Integer)
    '    Dim i
    '    i = 0
    '    Dim sql As String = "SELECT * FROM detail_paket where id_paket = " & idTambahan
    '    myCommand.CommandText = sql
    '    myDataReader = myCommand.ExecuteReader
    '    Dim found As Boolean = False
    '    For Each row As DataGridViewRow In DataGridView2.Rows
    '        If Not row.IsNewRow AndAlso row.Cells("colPaketTambahan").Value = nama_paket Then
    '            'row.Cells("colJumlahTambahan").Value = jumlah
    '            'row.Cells("colTotalTambahan").Value = jumlah * harga
    '            'row.Cells("colIdTambahan").Value = idTambahan
    '            found = True
    '            If row.Cells("colJumlahTambahan").Value = 0 Then
    '                DataGridView2.Rows.Remove(row)
    '            End If
    '            Exit For
    '        End If
    '        myDataReader.Close()
    '    Next

    '    If Not found Then
    '        DataGridView2.Rows.Add(nama_paket, jumlah, jumlah * harga, idTambahan)
    '    End If
    'End Sub

    'Private Sub TampilTambahanStall(nama_paket As String, jumlah As Integer, harga As Integer, idTambahan As Integer)
    '    Dim found As Boolean = False
    '    For Each row As DataGridViewRow In DataGridView2.Rows
    '        If Not row.IsNewRow AndAlso row.Cells("colPaketTambahan").Value = nama_paket Then
    '            'row.Cells("colJumlahTambahan").Value = jumlah
    '            'row.Cells("colTotalTambahan").Value = jumlah * harga
    '            'row.Cells("colIdTambahan").Value = idTambahan
    '            found = True
    '            If row.Cells("colJumlahTambahan").Value = 0 Then
    '                DataGridView2.Rows.Remove(row)
    '            End If
    '            Exit For
    '        End If
    '    Next

    '    If Not found Then
    '        DataGridView2.Rows.Add(nama_paket, jumlah, jumlah * harga, idTambahan)
    '    End If
    'End Sub



    ' PAKET SYUKURAN
    'Code untuk jumlah pembeliah di tab "Tambahan" '
    ' Syukur 1  '
    Private Sub btnMinSyukur1_Click(sender As Object, e As EventArgs) Handles btnMinSyukur1.Click
        ' Mengurangkan nilai di tbSyukur1
        If IsNumeric(tbSyukur1.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSyukur1.Text)
            If nilai = 250 Then
                tbSyukur1.Text = "0"
                TampilTambahan("Nasi Dos Syukuran 1", tbSyukur1.Text.ToString(), 35000, 20)
                UpdateTotalHargaTambahan()
            ElseIf nilai > 250 Then
                tbSyukur1.Text = (nilai - 1).ToString()
                TampilTambahan("Nasi Dos Syukuran 1", tbSyukur1.Text.ToString(), 35000, 20)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbSyukur1.Text = "0"
        End If

    End Sub

    Private Sub btnPlusSyukur1_Click(sender As Object, e As EventArgs) Handles btnPlusSyukur1.Click
        ' Menambahkan nilai di tbSyukur2
        If IsNumeric(tbSyukur1.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSyukur1.Text)
            If nilai = 0 Then
                tbSyukur1.Text = "250"
                TampilTambahan("Nasi Dos Syukuran 1", tbSyukur1.Text.ToString(), 34500, 20)
                UpdateTotalHargaTambahan()
            ElseIf nilai >= 300 Then
                tbSyukur1.Text = (nilai + 1).ToString()
                TampilTambahan("Nasi Dos Syukuran 1", tbSyukur1.Text.ToString(), 34500, 20)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbSyukur1.Text = "250"
            TampilTambahan("Nasi Dos Syukuran 1", tbSyukur1.Text.ToString(), 34500, 20)
            UpdateTotalHargaTambahan()
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketA
    Private Sub tbSyukur1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSyukur1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbSyukur1_Leave(sender As Object, e As EventArgs) Handles tbSyukur1.Leave
        If String.IsNullOrWhiteSpace(tbSyukur1.Text) OrElse Not IsNumeric(tbSyukur1.Text) Then
            tbSyukur1.Text = "0"
        End If
    End Sub



    ' Syukur 2  '
    Private Sub btnMinSyukur2_Click(sender As Object, e As EventArgs) Handles btnMinSyukur2.Click
        ' Mengurangkan nilai di tbSyukur2
        If IsNumeric(tbSyukur2.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSyukur2.Text)
            If nilai = 250 Then
                tbSyukur2.Text = "0"
                TampilTambahan("Nasi Dos Syukuran 2", tbSyukur2.Text.ToString(), 40000, 21)
                UpdateTotalHargaTambahan()
            ElseIf nilai > 250 Then
                tbSyukur2.Text = (nilai - 1).ToString()
                TampilTambahan("Nasi Dos Syukuran 2", tbSyukur2.Text.ToString(), 40000, 21)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbSyukur2.Text = "0"
        End If

    End Sub

    Private Sub btnPlusSyukur2_Click(sender As Object, e As EventArgs) Handles btnPlusSyukur2.Click
        ' Menambahkan nilai di tbSyukur2
        If IsNumeric(tbSyukur2.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSyukur2.Text)
            If nilai = 0 Then
                tbSyukur2.Text = "250"
                TampilTambahan("Nasi Dos Syukuran 2", tbSyukur2.Text.ToString(), 40000, 21)
                UpdateTotalHargaTambahan()
            ElseIf nilai >= 250 Then
                tbSyukur2.Text = (nilai + 1).ToString()
                TampilTambahan("Nasi Dos Syukuran 2", tbSyukur2.Text.ToString(), 40000, 21)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbSyukur2.Text = "250"
            TampilTambahan("Nasi Dos Syukuran 2", tbSyukur2.Text.ToString(), 40000, 21)
            UpdateTotalHargaTambahan()
        End If
    End Sub

    ' Validasi input hanya angka untuk tbSyukur2
    Private Sub tbSyukur2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSyukur2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbSyukur2 kehilangan fokus
    Private Sub tbSyukur2_Leave(sender As Object, e As EventArgs) Handles tbSyukur2.Leave
        If String.IsNullOrWhiteSpace(tbSyukur2.Text) OrElse Not IsNumeric(tbSyukur2.Text) Then
            tbSyukur2.Text = "0"
        End If
    End Sub



    ' Syukur 3  '
    Private Sub btnMinSyukur3_Click(sender As Object, e As EventArgs) Handles btnMinSyukur3.Click
        ' Mengurangkan nilai di tbSyukur3
        If IsNumeric(tbSyukur3.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSyukur3.Text)
            If nilai = 250 Then
                tbSyukur3.Text = "0"
                TampilTambahan("Nasi Dos Syukuran 3", tbSyukur3.Text.ToString(), 60000, 22)
                UpdateTotalHargaTambahan()
            ElseIf nilai > 250 Then
                tbSyukur3.Text = (nilai - 1).ToString()
                TampilTambahan("Nasi Dos Syukuran 3", tbSyukur3.Text.ToString(), 60000, 22)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbSyukur3.Text = "0"
        End If

    End Sub

    Private Sub btnPlusSyukur3_Click(sender As Object, e As EventArgs) Handles btnPlusSyukur3.Click
        ' Menambahkan nilai di tbSyukur3
        If IsNumeric(tbSyukur3.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSyukur3.Text)
            If nilai = 0 Then
                tbSyukur3.Text = "250"
                TampilTambahan("Nasi Dos Syukuran 3", tbSyukur3.Text.ToString(), 60000, 22)
                UpdateTotalHargaTambahan()
            ElseIf nilai >= 250 Then
                tbSyukur3.Text = (nilai + 1).ToString()
                TampilTambahan("Nasi Dos Syukuran 3", tbSyukur3.Text.ToString(), 60000, 22)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbSyukur3.Text = "250"
            TampilTambahan("Nasi Dos Syukuran 3", tbSyukur3.Text.ToString(), 60000, 22)
            UpdateTotalHargaTambahan()
        End If
    End Sub

    ' Validasi input hanya angka untuk tbSyukur3
    Private Sub tbSyukur3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSyukur3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbSyukur3 kehilangan fokus
    Private Sub tbSyukur3_Leave(sender As Object, e As EventArgs) Handles tbSyukur3.Leave
        If String.IsNullOrWhiteSpace(tbSyukur3.Text) OrElse Not IsNumeric(tbSyukur3.Text) Then
            tbSyukur3.Text = "0"
        End If
    End Sub


    ' Syukur 4  '
    Private Sub btnMinSyukur4_Click(sender As Object, e As EventArgs) Handles btnMinSyukur4.Click
        ' Mengurangkan nilai di tbSyukur4
        If IsNumeric(tbSyukur4.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSyukur4.Text)
            If nilai = 250 Then
                tbSyukur4.Text = "0"
                TampilTambahan("Nasi Dos Syukuran 4", tbSyukur4.Text.ToString(), 90000, 23)
                UpdateTotalHargaTambahan()
            ElseIf nilai > 250 Then
                tbSyukur4.Text = (nilai - 1).ToString()
                TampilTambahan("Nasi Dos Syukuran 4", tbSyukur4.Text.ToString(), 90000, 23)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbSyukur4.Text = "0"
        End If

    End Sub

    Private Sub btnPlusSyukur4_Click(sender As Object, e As EventArgs) Handles btnPlusSyukur4.Click
        ' Menambahkan nilai di tbSyukur4
        If IsNumeric(tbSyukur4.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSyukur4.Text)
            If nilai = 0 Then
                tbSyukur4.Text = "250"
                TampilTambahan("Nasi Dos Syukuran 4", tbSyukur4.Text.ToString(), 90000, 23)
                UpdateTotalHargaTambahan()
            ElseIf nilai >= 250 Then
                tbSyukur4.Text = (nilai + 1).ToString()
                TampilTambahan("Nasi Dos Syukuran 4", tbSyukur4.Text.ToString(), 90000, 23)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbSyukur4.Text = "250"
            TampilTambahan("Nasi Dos Syukuran 4", tbSyukur4.Text.ToString(), 90000, 23)
            UpdateTotalHargaTambahan()
        End If
    End Sub

    ' Validasi input hanya angka untuk tbSyukur4
    Private Sub tbSyukur4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSyukur4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbSyukur4 kehilangan fokus
    Private Sub tbSyukur4_Leave(sender As Object, e As EventArgs) Handles tbSyukur4.Leave
        If String.IsNullOrWhiteSpace(tbSyukur4.Text) OrElse Not IsNumeric(tbSyukur4.Text) Then
            tbSyukur4.Text = "0"
        End If
    End Sub



    ' Dos 1  '
    Private Sub btnMinDos1_Click(sender As Object, e As EventArgs) Handles btnMinDos1.Click
        ' Mengurangkan nilai di tbDos1
        If IsNumeric(tbDos1.Text) Then
            Dim nilai As Integer = Integer.Parse(tbDos1.Text)
            If nilai = 250 Then
                tbDos1.Text = "0"
                TampilTambahan("Nasi Dos 1", tbDos1.Text.ToString(), 22500, 24)
                UpdateTotalHargaTambahan()
            ElseIf nilai > 250 Then
                tbDos1.Text = (nilai - 1).ToString()
                TampilTambahan("Nasi Dos 1", tbDos1.Text.ToString(), 22500, 24)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbDos1.Text = "0"
        End If

    End Sub

    Private Sub btnPlusDos1_Click(sender As Object, e As EventArgs) Handles btnPlusDos1.Click
        ' Menambahkan nilai di tbDos1
        If IsNumeric(tbDos1.Text) Then
            Dim nilai As Integer = Integer.Parse(tbDos1.Text)
            If nilai = 0 Then
                tbDos1.Text = "250"
                TampilTambahan("Nasi Dos 1", tbDos1.Text.ToString(), 22500, 24)
                UpdateTotalHargaTambahan()
            ElseIf nilai >= 250 Then
                tbDos1.Text = (nilai + 1).ToString()
                TampilTambahan("Nasi Dos 1", tbDos1.Text.ToString(), 22500, 24)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbDos1.Text = "250"
            TampilTambahan("Nasi Dos 1", tbDos1.Text.ToString(), 22500, 24)
            UpdateTotalHargaTambahan()
        End If
    End Sub

    ' Validasi input hanya angka untuk tbDos1
    Private Sub tbDos1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDos1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbDos1 kehilangan fokus
    Private Sub tbDos1_Leave(sender As Object, e As EventArgs) Handles tbDos1.Leave
        If String.IsNullOrWhiteSpace(tbDos1.Text) OrElse Not IsNumeric(tbDos1.Text) Then
            tbDos1.Text = "0"
        End If
    End Sub



    ' Dos 2  '
    Private Sub btnMinDos2_Click(sender As Object, e As EventArgs) Handles btnMinDos2.Click
        ' Mengurangkan nilai di tbDos2
        If IsNumeric(tbDos2.Text) Then
            Dim nilai As Integer = Integer.Parse(tbDos2.Text)
            If nilai = 250 Then
                tbDos2.Text = "0"
                TampilTambahan("Nasi Dos 2", tbDos2.Text.ToString(), 26000, 25)
                UpdateTotalHargaTambahan()
            ElseIf nilai > 250 Then
                tbDos2.Text = (nilai - 1).ToString()
                TampilTambahan("Nasi Dos 2", tbDos2.Text.ToString(), 26000, 25)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbDos2.Text = "0"
        End If

    End Sub

    Private Sub btnPlusDos2_Click(sender As Object, e As EventArgs) Handles btnPlusDos2.Click
        ' Menambahkan nilai di tbDos2
        If IsNumeric(tbDos2.Text) Then
            Dim nilai As Integer = Integer.Parse(tbDos2.Text)
            If nilai = 0 Then
                tbDos2.Text = "250"
                TampilTambahan("Nasi Dos 2", tbDos2.Text.ToString(), 26000, 25)
                UpdateTotalHargaTambahan()
            ElseIf nilai >= 250 Then
                tbDos2.Text = (nilai + 1).ToString()
                TampilTambahan("Nasi Dos 2", tbDos2.Text.ToString(), 26000, 25)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbDos2.Text = "250"
            TampilTambahan("Nasi Dos 2", tbDos2.Text.ToString(), 26000, 25)
            UpdateTotalHargaTambahan()
        End If
    End Sub

    ' Validasi input hanya angka untuk tbDos2
    Private Sub tbDos2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDos2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbDos2 kehilangan fokus
    Private Sub tbDos2_Leave(sender As Object, e As EventArgs) Handles tbDos2.Leave
        If String.IsNullOrWhiteSpace(tbDos2.Text) OrElse Not IsNumeric(tbDos2.Text) Then
            tbDos2.Text = "0"
        End If
    End Sub


    ' Dos 3  '
    Private Sub btnMinDos3_Click(sender As Object, e As EventArgs) Handles btnMinDos3.Click
        ' Mengurangkan nilai di tbDos3
        If IsNumeric(tbDos3.Text) Then
            Dim nilai As Integer = Integer.Parse(tbDos3.Text)
            If nilai = 250 Then
                tbDos3.Text = "0"
                TampilTambahan("Nasi Dos 3", tbDos3.Text.ToString(), 30000, 26)
                UpdateTotalHargaTambahan()
            ElseIf nilai > 250 Then
                tbDos3.Text = (nilai - 1).ToString()
                TampilTambahan("Nasi Dos 3", tbDos3.Text.ToString(), 30000, 26)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbDos3.Text = "0"
        End If

    End Sub

    Private Sub btnPlusDos3_Click(sender As Object, e As EventArgs) Handles btnPlusDos3.Click
        ' Menambahkan nilai di tbDos3
        If IsNumeric(tbDos3.Text) Then
            Dim nilai As Integer = Integer.Parse(tbDos3.Text)
            If nilai = 0 Then
                tbDos3.Text = "250"
                TampilTambahan("Nasi Dos 3", tbDos3.Text.ToString(), 30000, 26)
                UpdateTotalHargaTambahan()
            ElseIf nilai >= 250 Then
                tbDos3.Text = (nilai + 1).ToString()
                TampilTambahan("Nasi Dos 3", tbDos3.Text.ToString(), 30000, 26)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbDos3.Text = "250"
            TampilTambahan("Nasi Dos 3", tbDos3.Text.ToString(), 30000, 26)
            UpdateTotalHargaTambahan()
        End If
    End Sub

    ' Validasi input hanya angka untuk tbDos3
    Private Sub tbDos3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDos3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbDos3 kehilangan fokus
    Private Sub tbDos3_Leave(sender As Object, e As EventArgs) Handles tbDos3.Leave
        If String.IsNullOrWhiteSpace(tbDos3.Text) OrElse Not IsNumeric(tbDos3.Text) Then
            tbDos3.Text = "0"
        End If
    End Sub



    ' Snack 1  '
    Private Sub btnMinSnack1_Click(sender As Object, e As EventArgs) Handles btnMinSnack1.Click
        ' Mengurangkan nilai di tbSnack1
        If IsNumeric(tbSnack1.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSnack1.Text)
            If nilai = 250 Then
                tbSnack1.Text = "0"
                TampilTambahan("Snack Box 1", tbSnack1.Text.ToString(), 12000, 27)
                UpdateTotalHargaTambahan()
            ElseIf nilai > 250 Then
                tbSnack1.Text = (nilai - 1).ToString()
                TampilTambahan("Snack Box 1", tbSnack1.Text.ToString(), 12000, 27)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbSnack1.Text = "0"
        End If

    End Sub

    Private Sub btnPlusSnack1_Click(sender As Object, e As EventArgs) Handles btnPlusSnack1.Click
        ' Menambahkan nilai di tbSnack1
        If IsNumeric(tbSnack1.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSnack1.Text)
            If nilai = 0 Then
                tbSnack1.Text = "250"
                TampilTambahan("Snack Box 1", tbSnack1.Text.ToString(), 12000, 27)
                UpdateTotalHargaTambahan()
            ElseIf nilai >= 250 Then
                tbSnack1.Text = (nilai + 1).ToString()
                TampilTambahan("Snack Box 1", tbSnack1.Text.ToString(), 12000, 27)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbSnack1.Text = "250"
            TampilTambahan("Snack Box 1", tbSnack1.Text.ToString(), 12000, 27)
            UpdateTotalHargaTambahan()
        End If
    End Sub

    ' Validasi input hanya angka untuk tbSnack1
    Private Sub tbSnack1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSnack1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbSnack1 kehilangan fokus
    Private Sub tbSnack1_Leave(sender As Object, e As EventArgs) Handles tbSnack1.Leave
        If String.IsNullOrWhiteSpace(tbSnack1.Text) OrElse Not IsNumeric(tbSnack1.Text) Then
            tbSnack1.Text = "0"
        End If
    End Sub

    Private Sub btnMinSnack2_Click(sender As Object, e As EventArgs) Handles btnMinSnack2.Click
        ' Mengurangkan nilai di tbSnack2
        If IsNumeric(tbSnack2.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSnack2.Text)
            If nilai = 250 Then
                tbSnack2.Text = "0"
                TampilTambahan("Snack Box 2", tbSnack2.Text.ToString(), 15000, 28)
                UpdateTotalHargaTambahan()
            ElseIf nilai > 250 Then
                tbSnack2.Text = (nilai - 1).ToString()
                TampilTambahan("Snack Box 2", tbSnack2.Text.ToString(), 15000, 28)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbSnack2.Text = "0"
        End If

    End Sub
    Private Sub btnPlusSnack2_Click(sender As Object, e As EventArgs) Handles btnPlusSnack2.Click
        ' Menambahkan nilai di tbSnack2
        If IsNumeric(tbSnack2.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSnack2.Text)
            If nilai = 0 Then
                tbSnack2.Text = "250"
                TampilTambahan("Snack Box 2", tbSnack2.Text.ToString(), 15000, 28)
                UpdateTotalHargaTambahan()
            ElseIf nilai >= 250 Then
                tbSnack2.Text = (nilai + 1).ToString()
                TampilTambahan("Snack Box 2", tbSnack2.Text.ToString(), 15000, 28)
                UpdateTotalHargaTambahan()
            End If
        Else
            tbSnack2.Text = "250"
            TampilTambahan("Snack Box 2", tbSnack2.Text.ToString(), 15000, 28)
            UpdateTotalHargaTambahan()
        End If
    End Sub
    ' Validasi input hanya angka untuk tbSnack2
    Private Sub tbSnack2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSnack2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Handle ketika tbSnack2 kehilangan fokus
    Private Sub tbSnack2_Leave(sender As Object, e As EventArgs) Handles tbSnack2.Leave
        If String.IsNullOrWhiteSpace(tbSnack2.Text) OrElse Not IsNumeric(tbSnack2.Text) Then
            tbSnack2.Text = "0"
        End If
    End Sub


    Private Sub HapusItemDariGrid(namaItem As String)
        For Each row As DataGridViewRow In DataGridView2.Rows
            If Not row.IsNewRow AndAlso row.Cells(0).Value IsNot Nothing Then
                If row.Cells(0).Value.ToString() = namaItem Then
                    DataGridView2.Rows.Remove(row)
                    Exit For
                End If
            End If
        Next
    End Sub


    ' Template Handler untuk item tambahan
    Private Sub HandleCheckbox(cb As CheckBox, tb As TextBox, namaItem As String, harga As Integer, id As Integer)
        If cb.Checked Then
            tb.Text = "250"
            TampilTambahan(namaItem, tb.Text, harga, id)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid(namaItem)
            tb.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub

    Private Sub HandleTextboxChanged(cb As CheckBox, tb As TextBox, namaItem As String, harga As Integer, id As Integer)
        If cb.Checked AndAlso IsNumeric(tb.Text) Then
            Dim jumlah As Integer = CInt(tb.Text)
            If jumlah >= 250 Then
                TampilTambahan(namaItem, jumlah.ToString(), harga, id)
                UpdateTotalHargaTambahan()
            End If
        End If
    End Sub

    Private Sub HandleTextboxKeyDown(tb As TextBox, e As KeyEventArgs, namaItem As String, harga As Integer, id As Integer)
        If e.KeyCode = Keys.Enter Then
            If IsNumeric(tb.Text) Then
                Dim nilai As Integer = CInt(tb.Text)
                If nilai < 250 Then
                    MsgBox("Jumlah minimal adalah 250!", MsgBoxStyle.Exclamation, "Peringatan")
                    tb.Text = "250"
                    tb.Focus()
                    tb.SelectAll()
                Else
                    TampilTambahan(namaItem, tb.Text, harga, id)
                    UpdateTotalHargaTambahan()
                End If
            Else
                MsgBox("Harap masukkan angka yang valid.", MsgBoxStyle.Critical, "Kesalahan")
                tb.Text = "250"
                tb.Focus()
                tb.SelectAll()
            End If
        End If
    End Sub

    ' === Teh ===
    Private Sub cbTeh_CheckedChanged(sender As Object, e As EventArgs) Handles cbTeh.CheckedChanged
        'HandleCheckbox(cbTeh, tbTeh, "Teh", 4500, 26)
        If cbTeh.Checked Then
            tbTeh.Text = "250"
            TampilTambahan("Stall 1 - Teh", tbTeh.Text.ToString(), 4500, 30)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 1 - Teh")
            tbTeh.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbTeh_TextChanged(sender As Object, e As EventArgs) Handles tbTeh.TextChanged
        HandleTextboxChanged(cbTeh, tbTeh, "Stall 1 - Teh", 4500, 30)
    End Sub
    Private Sub tbTeh_KeyDown(sender As Object, e As KeyEventArgs) Handles tbTeh.KeyDown
        HandleTextboxKeyDown(tbTeh, e, "Stall 1 - Teh", 4500, 30)
    End Sub

    ' === Ice Puter + Agar-agar ===
    Private Sub cbIcePuter_CheckedChanged(sender As Object, e As EventArgs) Handles cbIcePuter.CheckedChanged
        'HandleCheckbox(cbIcePuter, tbIcePuter, "Ice Puter + Agar-agar", 4500, 30)
        If cbIcePuter.Checked Then
            tbIcePuter.Text = "250"
            TampilTambahan("Stall 1 - Ice Puter + Agar-agar", tbIcePuter.Text.ToString(), 4500, 29)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 1 - Ice Puter + Agar-agar")
            tbIcePuter.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbIcePuter_TextChanged(sender As Object, e As EventArgs) Handles tbIcePuter.TextChanged
        HandleTextboxChanged(cbIcePuter, tbIcePuter, "Stall 1 - Ice Puter + Agar-agar", 4500, 29)
    End Sub
    Private Sub tbIcePuter_KeyDown(sender As Object, e As KeyEventArgs) Handles tbIcePuter.KeyDown
        HandleTextboxKeyDown(tbIcePuter, e, "Stall 1 - Ice Puter + Agar-agar", 4500, 29)
    End Sub

    ' === Es Seruni ===
    Private Sub cbEsSeruni_CheckedChanged(sender As Object, e As EventArgs) Handles cbEsSeruni.CheckedChanged
        If cbEsSeruni.Checked Then
            tbEsSeruni.Text = "250"
            TampilTambahan("Stall 1 - Es Seruni", tbEsSeruni.Text.ToString(), 4500, 31)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 1 - Es Seruni")
            tbEsSeruni.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbEsSeruni_TextChanged(sender As Object, e As EventArgs) Handles tbEsSeruni.TextChanged
        HandleTextboxChanged(cbEsSeruni, tbEsSeruni, "Stall 1 - Es Seruni", 4500, 31)
    End Sub
    Private Sub tbEsSeruni_KeyDown(sender As Object, e As KeyEventArgs) Handles tbEsSeruni.KeyDown
        HandleTextboxKeyDown(tbEsSeruni, e, "Stall 1 - Es Seruni", 4500, 31)
    End Sub

    ' === Buah Iris ===
    Private Sub cbBuahIris_CheckedChanged(sender As Object, e As EventArgs) Handles cbBuahIris.CheckedChanged
        If cbBuahIris.Checked Then
            tbBuahIris.Text = "250"
            TampilTambahan("Stall 1 - Buah Iris", tbBuahIris.Text.ToString(), 4500, 32)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 1 - Buah Iris")
            tbBuahIris.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbBuahIris_TextChanged(sender As Object, e As EventArgs) Handles tbBuahIris.TextChanged
        HandleTextboxChanged(cbBuahIris, tbBuahIris, "Stall 1 - Buah Iris", 4500, 32)
    End Sub
    Private Sub tbBuahIris_KeyDown(sender As Object, e As KeyEventArgs) Handles tbBuahIris.KeyDown
        HandleTextboxKeyDown(tbBuahIris, e, "Stall 1 - Buah Iris", 4500, 32)
    End Sub

    ' === Es Dawet ===
    Private Sub cbEsDawet_CheckedChanged(sender As Object, e As EventArgs) Handles cbEsDawet.CheckedChanged
        If cbEsDawet.Checked Then
            tbEsDawet.Text = "250"
            TampilTambahan("Stall 2 - Es Dawet", tbEsDawet.Text.ToString(), 6000, 33)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 2 - Es Dawet")
            tbEsDawet.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbEsDawet_TextChanged(sender As Object, e As EventArgs) Handles tbEsDawet.TextChanged
        HandleTextboxChanged(cbEsDawet, tbEsDawet, "Stall 2 - Es Dawet", 6000, 33)
    End Sub
    Private Sub tbEsDawet_KeyDown(sender As Object, e As KeyEventArgs) Handles tbEsDawet.KeyDown
        HandleTextboxKeyDown(tbEsDawet, e, "Stall 2 - Es Dawet", 6000, 33)
    End Sub

    ' === Es Selasih ===
    Private Sub cbEsSelasih_CheckedChanged(sender As Object, e As EventArgs) Handles cbEsSelasih.CheckedChanged
        If cbEsSelasih.Checked Then
            tbEsSelasih.Text = "250"
            TampilTambahan("Stall 2 - Es Selasih", tbEsSelasih.Text.ToString(), 6000, 34)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 2 - Es Selasih")
            tbEsSelasih.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbEsSelasih_TextChanged(sender As Object, e As EventArgs) Handles tbEsSelasih.TextChanged
        HandleTextboxChanged(cbEsSelasih, tbEsSelasih, "Stall 2 - Es Selasih", 6000, 34)
    End Sub
    Private Sub tbEsSelasih_KeyDown(sender As Object, e As KeyEventArgs) Handles tbEsSelasih.KeyDown
        HandleTextboxKeyDown(tbEsSelasih, e, "Stall 2 - Es Selasih", 6000, 34)
    End Sub

    ' === Rujak Ice Cream ===
    Private Sub cbRujak_CheckedChanged(sender As Object, e As EventArgs) Handles cbRujak.CheckedChanged
        If cbRujak.Checked Then
            tbRujak.Text = "250"
            TampilTambahan("Stall 2 - Rujak Ice Cream", tbRujak.Text.ToString(), 6000, 35)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 2 - Rujak Ice Cream")
            tbRujak.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbRujak_TextChanged(sender As Object, e As EventArgs) Handles tbRujak.TextChanged
        HandleTextboxChanged(cbRujak, tbRujak, "Stall 2 - Rujak Ice Cream", 6000, 35)
    End Sub
    Private Sub tbRujak_KeyDown(sender As Object, e As KeyEventArgs) Handles tbRujak.KeyDown
        HandleTextboxKeyDown(tbRujak, e, "Stall 2 - Rujak Ice Cream", 6000, 35)
    End Sub

    ' === Jus Jeruk ===
    Private Sub cbJusJeruk_CheckedChanged(sender As Object, e As EventArgs) Handles cbJusJeruk.CheckedChanged
        If cbJusJeruk.Checked Then
            tbJusJeruk.Text = "250"
            TampilTambahan("Stall 2 - Jus Jeruk", tbJusJeruk.Text.ToString(), 6000, 36)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 2 - Jus Jeruk")
            tbJusJeruk.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbJusJeruk_TextChanged(sender As Object, e As EventArgs) Handles tbJusJeruk.TextChanged
        HandleTextboxChanged(cbJusJeruk, tbJusJeruk, "Stall 2 - Jus Jeruk", 6000, 36)
    End Sub
    Private Sub tbJusJeruk_KeyDown(sender As Object, e As KeyEventArgs) Handles tbJusJeruk.KeyDown
        HandleTextboxKeyDown(tbJusJeruk, e, "Stall 2 - Jus Jeruk", 6000, 36)
    End Sub

    ' === Wedang Ronde ===
    Private Sub cbWedangRonde_CheckedChanged(sender As Object, e As EventArgs) Handles cbWedangRonde.CheckedChanged
        If cbWedangRonde.Checked Then
            tbWedangRonde.Text = "250"
            TampilTambahan("Stall 3 - Wedang Ronde", tbWedangRonde.Text.ToString(), 7000, 37)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 3 - Wedang Ronde")
            tbWedangRonde.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbWedangRonde_TextChanged(sender As Object, e As EventArgs) Handles tbWedangRonde.TextChanged
        HandleTextboxChanged(cbWedangRonde, tbWedangRonde, "Stall 3 - Wedang Ronde", 7000, 37)
    End Sub
    Private Sub tbWedangRonde_KeyDown(sender As Object, e As KeyEventArgs) Handles tbWedangRonde.KeyDown
        HandleTextboxKeyDown(tbWedangRonde, e, "Stall 3 - Wedang Ronde", 7000, 37)
    End Sub

    ' === Es Doger ===
    Private Sub cbEsDoger_CheckedChanged(sender As Object, e As EventArgs) Handles cbEsDoger.CheckedChanged
        If cbEsDoger.Checked Then
            tbEsDoger.Text = "250"
            TampilTambahan("Stall 3 - Es Doger", tbEsDoger.Text.ToString(), 7000, 38)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 3 - Es Doger")
            tbEsDoger.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbEsDoger_TextChanged(sender As Object, e As EventArgs) Handles tbEsDoger.TextChanged
        HandleTextboxChanged(cbEsDoger, tbEsDoger, "Stall 3 - Es Doger", 7000, 38)
    End Sub
    Private Sub tbEsDoger_KeyDown(sender As Object, e As KeyEventArgs) Handles tbEsDoger.KeyDown
        HandleTextboxKeyDown(tbEsDoger, e, "Stall 3 - Es Doger", 7000, 38)
    End Sub

    ' === Pecel Pincuk ===
    Private Sub cbPecelPincuk_CheckedChanged(sender As Object, e As EventArgs) Handles cbPecelPincuk.CheckedChanged
        If cbPecelPincuk.Checked Then
            tbPecelPincuk.Text = "250"
            TampilTambahan("Stall 3 - Pecel Pincuk", tbPecelPincuk.Text.ToString(), 7000, 39)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 3 - Pecel Pincuk")
            tbPecelPincuk.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbPecelPincuk_TextChanged(sender As Object, e As EventArgs) Handles tbPecelPincuk.TextChanged
        HandleTextboxChanged(cbPecelPincuk, tbPecelPincuk, "Stall 3 - Pecel Pincuk", 7000, 39)
    End Sub
    Private Sub tbPecelPincuk_KeyDown(sender As Object, e As KeyEventArgs) Handles tbPecelPincuk.KeyDown
        HandleTextboxKeyDown(tbPecelPincuk, e, "Stall 3 - Pecel Pincuk", 7000, 39)
    End Sub

    ' === Bakso ===
    Private Sub cbBakso_CheckedChanged(sender As Object, e As EventArgs) Handles cbBakso.CheckedChanged
        If cbBakso.Checked Then
            tbBakso.Text = "250"
            TampilTambahan("Stall 4 - Bakso", tbBakso.Text.ToString(), 11000, 40)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 4 - Bakso")
            tbBakso.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbBakso_TextChanged(sender As Object, e As EventArgs) Handles tbBakso.TextChanged
        HandleTextboxChanged(cbBakso, tbBakso, "Stall 4 - Bakso", 11000, 40)
    End Sub
    Private Sub tbBakso_KeyDown(sender As Object, e As KeyEventArgs) Handles tbBakso.KeyDown
        HandleTextboxKeyDown(tbBakso, e, "Stall 4 - Bakso", 11000, 40)
    End Sub

    ' === Siomay ===
    Private Sub cbSiomay_CheckedChanged(sender As Object, e As EventArgs) Handles cbSiomay.CheckedChanged
        If cbSiomay.Checked Then
            tbSiomay.Text = "250"
            TampilTambahan("Stall 4 - Siomay", tbSiomay.Text.ToString(), 11000, 41)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 4 - Siomay")
            tbSiomay.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbSiomay_TextChanged(sender As Object, e As EventArgs) Handles tbSiomay.TextChanged
        HandleTextboxChanged(cbSiomay, tbSiomay, "Stall 4 - Siomay", 11000, 41)
    End Sub
    Private Sub tbSiomay_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSiomay.KeyDown
        HandleTextboxKeyDown(tbSiomay, e, "Stall 4 - Siomay", 11000, 41)
    End Sub

    ' === Salad Buah ===
    Private Sub cbSaladBuah_CheckedChanged(sender As Object, e As EventArgs) Handles cbSaladBuah.CheckedChanged
        If cbSaladBuah.Checked Then
            tbSaladBuah.Text = "250"
            TampilTambahan("Stall 4 - Salad Buah", tbSaladBuah.Text.ToString(), 11000, 42)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 4 - Salad Buah")
            tbSaladBuah.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbSaladBuah_TextChanged(sender As Object, e As EventArgs) Handles tbSaladBuah.TextChanged
        HandleTextboxChanged(cbSaladBuah, tbSaladBuah, "Stall 4 - Salad Buah", 11000, 42)
    End Sub
    Private Sub tbSaladBuah_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSaladBuah.KeyDown
        HandleTextboxKeyDown(tbSaladBuah, e, "Stall 4 - Salad Buah", 11000, 42)
    End Sub

    ' === Selat Solo ===
    Private Sub cbSelatSolo_CheckedChanged(sender As Object, e As EventArgs) Handles cbSelatSolo.CheckedChanged
        If cbSelatSolo.Checked Then
            tbSelatSolo.Text = "250"
            TampilTambahan("Stall 4 - Selat Solo", tbSelatSolo.Text.ToString(), 11000, 43)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 4 - Selat Solo")
            tbSelatSolo.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbSelatSolo_TextChanged(sender As Object, e As EventArgs) Handles tbSelatSolo.TextChanged
        HandleTextboxChanged(cbSelatSolo, tbSelatSolo, "Stall 4 - Selat Solo", 11000, 43)
    End Sub
    Private Sub tbSelatSolo_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSelatSolo.KeyDown
        HandleTextboxKeyDown(tbSelatSolo, e, "Stall 4 - Selat Solo", 11000, 43)
    End Sub

    ' === Empek-Empek ===
    Private Sub cbEmpek_CheckedChanged(sender As Object, e As EventArgs) Handles cbEmpek.CheckedChanged
        If cbEmpek.Checked Then
            tbEmpek.Text = "250"
            TampilTambahan("Stall 5 - Empek-Empek", tbEmpek.Text.ToString(), 12000, 44)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 5 - Empek-Empek")
            tbEmpek.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbEmpek_TextChanged(sender As Object, e As EventArgs) Handles tbEmpek.TextChanged
        HandleTextboxChanged(cbEmpek, tbEmpek, "Stall 5 - Empek-Empek", 12000, 44)
    End Sub
    Private Sub tbEmpek_KeyDown(sender As Object, e As KeyEventArgs) Handles tbEmpek.KeyDown
        HandleTextboxKeyDown(tbEmpek, e, "Stall 5 - Empek-Empek", 12000, 44)
    End Sub

    ' === Gado-gado ===
    Private Sub cbGado_CheckedChanged(sender As Object, e As EventArgs) Handles cbGado.CheckedChanged
        If cbGado.Checked Then
            tbGado.Text = "250"
            TampilTambahan("Stall 5 - Gado-Gado", tbGado.Text.ToString(), 12000, 45)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 5 - Gado-Gado")
            tbGado.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbGado_TextChanged(sender As Object, e As EventArgs) Handles tbGado.TextChanged
        HandleTextboxChanged(cbGado, tbGado, "Stall 5 - Gado-Gado", 12000, 45)
    End Sub
    Private Sub tbGado_KeyDown(sender As Object, e As KeyEventArgs) Handles tbGado.KeyDown
        HandleTextboxKeyDown(tbGado, e, "Stall 5 - Gado-Gado", 12000, 45)
    End Sub

    ' === Sate ayam + lontong ===
    Private Sub cbSateAyam_CheckedChanged(sender As Object, e As EventArgs) Handles cbSateAyam.CheckedChanged
        If cbSateAyam.Checked Then
            tbSate.Text = "250"
            TampilTambahan("Stall 5 - Sate ayam + lontong", tbSate.Text.ToString(), 12000, 46)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 5 - Sate ayam + lontong")
            tbSate.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbSate_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSate.KeyDown
        HandleTextboxKeyDown(tbSate, e, "Stall 5 - Sate ayam + lontong", 12000, 46)
    End Sub
    Private Sub tbSate_TextChanged(sender As Object, e As EventArgs) Handles tbSate.TextChanged
        HandleTextboxChanged(cbSateAyam, tbSate, "Stall 5 - Sate ayam + lontong", 12000, 46)
    End Sub

    ' === Mie Oriental ===
    Private Sub cbMieOriental_CheckedChanged(sender As Object, e As EventArgs) Handles cbMieOriental.CheckedChanged
        If cbMieOriental.Checked Then
            tbMie.Text = "250"
            TampilTambahan("Stall 5 - Mie Oriental", tbMie.Text.ToString(), 12000, 47)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 5 - Mie Oriental")
            tbMie.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbMie_TextChanged(sender As Object, e As EventArgs) Handles tbMie.TextChanged
        HandleTextboxChanged(cbMieOriental, tbMie, "Stall 5 - Mie Oriental", 12000, 47)
    End Sub
    Private Sub tbMie_KeyDown(sender As Object, e As KeyEventArgs) Handles tbMie.KeyDown
        HandleTextboxKeyDown(tbMie, e, "Stall 5 - Mie Oriental", 12000, 47)
    End Sub

    ' === Nasi Liwet Solo ===
    Private Sub cbNasiLiwetSolo_CheckedChanged(sender As Object, e As EventArgs) Handles cbNasiLiwetSolo.CheckedChanged
        If cbNasiLiwetSolo.Checked Then
            tbNasiLiwet.Text = "250"
            TampilTambahan("Stall 6 - Nasi Liwet Solo", tbNasiLiwet.Text.ToString(), 15000, 48)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 6 - Nasi Liwet Solo")
            tbNasiLiwet.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbNasiLiwet_TextChanged(sender As Object, e As EventArgs) Handles tbNasiLiwet.TextChanged
        HandleTextboxChanged(cbNasiLiwetSolo, tbNasiLiwet, "Stall 6 - Nasi Liwet Solo", 15000, 48)
    End Sub
    Private Sub tbNasiLiwet_KeyDown(sender As Object, e As KeyEventArgs) Handles tbNasiLiwet.KeyDown
        HandleTextboxKeyDown(tbNasiLiwet, e, "Stall 6 - Nasi Liwet Solo", 15000, 48)
    End Sub

    ' === Nasi Rawon ===
    Private Sub cbNasiRawon_CheckedChanged(sender As Object, e As EventArgs) Handles cbNasiRawon.CheckedChanged
        If cbNasiRawon.Checked Then
            tbNasiRawon.Text = "250"
            TampilTambahan("Stall 6 - Nasi Rawon", tbNasiRawon.Text.ToString(), 15000, 49)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 6 - Nasi Rawon")
            tbNasiRawon.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbNasiRawon_TextChanged(sender As Object, e As EventArgs) Handles tbNasiRawon.TextChanged
        HandleTextboxChanged(cbNasiRawon, tbNasiRawon, "Stall 6 - Nasi Rawon", 15000, 49)
    End Sub
    Private Sub tbNasiRawon_KeyDown(sender As Object, e As KeyEventArgs) Handles tbNasiRawon.KeyDown
        HandleTextboxKeyDown(tbNasiRawon, e, "Stall 6 - Nasi Rawon", 15000, 49)
    End Sub

    ' === Kebab ===
    Private Sub cbKebab_CheckedChanged(sender As Object, e As EventArgs) Handles cbKebab.CheckedChanged
        If cbKebab.Checked Then
            tbKebab.Text = "250"
            TampilTambahan("Stall 6 - Kebab", tbKebab.Text.ToString(), 15000, 50)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 6 - Kebab")
            tbKebab.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbKebab_TextChanged(sender As Object, e As EventArgs) Handles tbKebab.TextChanged
        HandleTextboxChanged(cbKebab, tbKebab, "Stall 6 - Kebab", 15000, 50)
    End Sub
    Private Sub tbKebab_KeyDown(sender As Object, e As KeyEventArgs) Handles tbKebab.KeyDown
        HandleTextboxKeyDown(tbKebab, e, "Stall 6 - Kebab", 15000, 50)
    End Sub

    ' === Dim Sum ===
    Private Sub cbDimSum_CheckedChanged(sender As Object, e As EventArgs) Handles cbDimSum.CheckedChanged
        If cbDimSum.Checked Then
            tbDimSum.Text = "250"
            TampilTambahan("Stall 6 - Dim Sum", tbDimSum.Text.ToString(), 15000, 51)
            UpdateTotalHargaTambahan()
        Else
            HapusItemDariGrid("Stall 6 - Dim Sum")
            tbDimSum.Text = ""
            UpdateTotalHargaTambahan()
        End If
    End Sub
    Private Sub tbDimSum_TextChanged(sender As Object, e As EventArgs) Handles tbDimSum.TextChanged
        HandleTextboxChanged(cbDimSum, tbDimSum, "Stall 6 - Dim Sum", 15000, 51)
    End Sub
    Private Sub tbDimSum_KeyDown(sender As Object, e As KeyEventArgs) Handles tbDimSum.KeyDown
        HandleTextboxKeyDown(tbDimSum, e, "Stall 6 - Dim Sum", 15000, 51)
    End Sub

    Private Sub btnUploadBuktiBayar_Click(sender As Object, e As EventArgs) Handles btnUploadBuktiBayar.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Title = "Pilih Bukti Pembayaran"
        openFileDialog.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Menampilkan gambar ke PictureBox jika ada
            'PictureBoxBukti.Image = Image.FromFile(openFileDialog.FileName)
            'PictureBoxBukti.SizeMode = PictureBoxSizeMode.StretchImage

            ' Jika kamu mau simpan pathnya ke variable
            Dim pathGambar As String = openFileDialog.FileName
            ' Kamu bisa simpan ke database, atau copy ke folder tertentu, dll

            MessageBox.Show("Bukti pembayaran berhasil diupload!", "Upload Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub llPesananTersimpan_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llPesananTersimpan.LinkClicked
        Dim formPesanan As New Form8()
        formPesanan.originalIdAcara = originalIdAcara
        formPesanan.Show()
    End Sub

    Private Sub llPesananTersimpan2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llPesananTersimpan2.LinkClicked
        Dim formPesanan As New Form8()
        formPesanan.originalIdAcara = originalIdAcara
        formPesanan.Show()
    End Sub


    Private Function ParseCurrency(text As String) As Decimal
        Dim cleanText = text.Replace("Rp", "").Replace(",", "").Trim()
        Dim angka As Decimal
        Decimal.TryParse(cleanText, angka)
        Return angka
    End Function

    Private Sub SetNilaiCicilan(total As Decimal)
        lblTerminRpCicil1.Text = "Rp " & (total * 0.1D).ToString("N0")
        lblTerminRpCicil2.Text = "Rp " & (total * 0.8D).ToString("N0")
        lblTerminRpCicil3.Text = "Rp " & (total * 0.1D).ToString("N0")
    End Sub

    Private Sub SetNilaiPembayaran(pilihan As String, total As Decimal)
        Select Case pilihan.ToLower()
            Case "lunas"
                lblTerminRpLunas.Text = "Rp " & total.ToString("N0")
                lblTerminRpCicil1.Text = "Rp 0"
                lblTerminRpCicil2.Text = "Rp 0"
                lblTerminRpCicil3.Text = "Rp 0"
                SetWarnaKontrolPembayaran(True, False)

            Case "cicilan"
                lblTerminRpLunas.Text = "Rp 0"
                SetNilaiCicilan(total)
                SetWarnaKontrolPembayaran(False, True)

            Case Else
                lblTerminRpLunas.Text = "Rp 0"
                lblTerminRpCicil1.Text = "Rp 0"
                lblTerminRpCicil2.Text = "Rp 0"
                lblTerminRpCicil3.Text = "Rp 0"
                SetWarnaKontrolPembayaran(False, False)
        End Select

        UpdateSisaTagihan()
    End Sub



    Private Sub cbPilihBayar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPilihBayar.SelectedIndexChanged
        If cbPilihBayar.SelectedItem Is Nothing Then Exit Sub
        Dim pilihan As String = cbPilihBayar.SelectedItem.ToString()
        Dim total As Decimal = ParseCurrency(LblRpTagihan.Text)
        SetNilaiPembayaran(pilihan, total)


        'If pilihan = "lunas" Then
        '    lblTerminRpLunas.Text = "Rp " & total.ToString("N0")
        '    lblTerminRpCicil1.Text = "Rp 0"
        '    lblTerminRpCicil2.Text = "Rp 0"
        '    lblTerminRpCicil3.Text = "Rp 0"

        '    ' Aktifkan kontrol Lunas, nonaktifkan Cicilan
        '    SetWarnaKontrolPembayaran(True, False)

        'ElseIf pilihan = "cicilan" Then
        '    lblTerminRpLunas.Text = "Rp 0"
        '    lblTerminRpCicil1.Text = "Rp " & (total * 0.1D).ToString("N0")
        '    lblTerminRpCicil2.Text = "Rp " & (total * 0.8D).ToString("N0")
        '    lblTerminRpCicil3.Text = "Rp " & (total * 0.1D).ToString("N0")

        '    ' Aktifkan kontrol Cicilan, nonaktifkan Lunas
        '    SetWarnaKontrolPembayaran(False, True)
        'Else
        '    lblTerminRpLunas.Text = "Rp 0"
        '    lblTerminRpCicil1.Text = "Rp 0"
        '    lblTerminRpCicil2.Text = "Rp 0"
        '    lblTerminRpCicil3.Text = "Rp 0"

        '    ' Nonaktifkan semua kontrol
        '    SetWarnaKontrolPembayaran(False, False)
        'End If

        'UpdateSisaTagihan()
    End Sub

    Private Sub SetWarnaKontrolPembayaran(lunasAktif As Boolean, cicilAktif As Boolean)
        Dim warnaAktif As Color = Color.FromArgb(13, 64, 41) ' Warna teks aktif
        Dim warnaNonAktif As Color = Color.Gray
        Dim backAktif As Color = Color.FromArgb(250, 200, 8) ' Warna background aktif
        Dim backNonAktif As Color = Color.LightGray

        ' ===== Bagian Pembayaran Lunas =====
        lblLunas.ForeColor = If(lunasAktif, warnaAktif, warnaNonAktif)
        lblLunas2.ForeColor = If(lunasAktif, warnaAktif, warnaNonAktif)
        lblRpLunas.ForeColor = If(lunasAktif, warnaAktif, warnaNonAktif)
        lblRpLunas.BackColor = If(lunasAktif, backAktif, backNonAktif)
        lblTanggalLunas.ForeColor = If(lunasAktif, warnaAktif, warnaNonAktif)

        lblTerminRpLunas.ForeColor = If(lunasAktif, warnaAktif, warnaNonAktif)
        lblTerminRpLunas.BackColor = If(lunasAktif, backAktif, backNonAktif)

        ' ===== Termin/Cicilan =====
        ' Termin 1
        lblTermin1.ForeColor = If(cicilAktif, warnaAktif, warnaNonAktif)
        lblTerminRpCicil1.ForeColor = If(cicilAktif, warnaAktif, warnaNonAktif)
        lblTerminRpCicil1.BackColor = If(cicilAktif, backAktif, backNonAktif)
        lblTanggalTermin1.ForeColor = If(cicilAktif, warnaAktif, warnaNonAktif)


        lblRealisasiTermin1.ForeColor = If(cicilAktif, warnaAktif, warnaNonAktif)
        tbBayarCicil1.ForeColor = If(cicilAktif, warnaAktif, warnaNonAktif)
        tbBayarCicil1.BackColor = If(cicilAktif, backAktif, backNonAktif)

        ' Termin 2
        lblTermin2.ForeColor = If(cicilAktif, warnaAktif, warnaNonAktif)
        lblTerminRpCicil2.ForeColor = If(cicilAktif, warnaAktif, warnaNonAktif)
        lblTerminRpCicil2.BackColor = If(cicilAktif, backAktif, backNonAktif)
        lblTanggalTermin2.ForeColor = If(cicilAktif, warnaAktif, warnaNonAktif)

        lblRealisasiTermin2.ForeColor = If(cicilAktif, warnaAktif, warnaNonAktif)
        tbBayarCicil2.ForeColor = If(cicilAktif, warnaAktif, warnaNonAktif)
        tbBayarCicil2.BackColor = If(cicilAktif, backAktif, backNonAktif)


        ' Termin 3
        lblTermin3.ForeColor = If(cicilAktif, warnaAktif, warnaNonAktif)
        lblTerminRpCicil3.ForeColor = If(cicilAktif, warnaAktif, warnaNonAktif)
        lblTerminRpCicil3.BackColor = If(cicilAktif, backAktif, backNonAktif)
        lblTanggalTermin3.ForeColor = If(cicilAktif, warnaAktif, warnaNonAktif)

        lblRealisasiTermin3.ForeColor = If(cicilAktif, warnaAktif, warnaNonAktif)
        tbBayarCicil3.ForeColor = If(cicilAktif, warnaAktif, warnaNonAktif)
        tbBayarCicil3.BackColor = If(cicilAktif, backAktif, backNonAktif)
    End Sub

    Private Sub UpdateSisaTagihan()
        Dim totalTagihan As Decimal = ParseCurrency(LblRpTagihan.Text)
        Dim bayarLunas As Decimal = ParseCurrency(lblRpLunas.Text)
        Dim bayar1 As Decimal = ParseCurrency(tbBayarCicil1.Text)
        Dim bayar2 As Decimal = ParseCurrency(tbBayarCicil2.Text)
        Dim bayar3 As Decimal = ParseCurrency(tbBayarCicil3.Text)

        Dim totalBayar As Decimal = bayarLunas + bayar1 + bayar2 + bayar3
        Dim sisaTagihan As Decimal = totalTagihan - totalBayar
        If sisaTagihan < 0 Then sisaTagihan = 0

        lblRpSisa.Text = "Rp " & sisaTagihan.ToString("N0")

        lblRpLunas.Text = "Rp " & totalTagihan.ToString("N0")
    End Sub


    Private Sub lblRpPembayaran_TextChanged(sender As Object, e As EventArgs) _
    Handles lblRpLunas.TextChanged
        UpdateSisaTagihan()
    End Sub

    Private Sub totalTagihan(Optional updateNilaiPembayaran As Boolean = True)
        Dim sql As String = "SELECT * FROM pesanan WHERE id_acara = " & originalIdAcara
        myCommand.CommandText = sql
        myDataReader = myCommand.ExecuteReader

        If myDataReader.HasRows Then
            Dim hasil As Integer = 0
            While myDataReader.Read()
                hasil += Convert.ToInt32(myDataReader("total_pengeluaran"))
            End While
            LblRpTagihan.Text = "Rp " & hasil.ToString("N0")

            ' Jika diinginkan, perbarui nilai pembayaran
            If updateNilaiPembayaran AndAlso cbPilihBayar.SelectedItem IsNot Nothing Then
                Dim pilihan As String = cbPilihBayar.SelectedItem.ToString()
                SetNilaiPembayaran(pilihan, hasil)
            End If
        End If

        If Not myDataReader.IsClosed Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub btnSimpanPembayaran_Click(sender As Object, e As EventArgs)
        Dim tipeBayar As String = cbPilihBayar.SelectedItem.ToString()
        Dim sqlCek As String = "select count(*) from pembayaran where id_acara='" & originalIdAcara & "'"
        myCommand.CommandText = sqlCek
        Dim count As Integer = Convert.ToInt32(myCommand.ExecuteScalar())
        If count > 0 Then
            If tipeBayar = "Cicilan" Then
                Dim sql As String = "update pembayaran set " & ""
            End If
        End If

    End Sub
End Class