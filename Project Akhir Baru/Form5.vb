Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form5
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

    ' Stall 1 '
    Private Sub btnMinStall1_Click(sender As Object, e As EventArgs) Handles btnMinStall1.Click
        ' Mengurangkan nilai di tbPaketC
        If IsNumeric(tbStall1.Text) Then
            Dim nilai As Integer = Integer.Parse(tbStall1.Text)
            If nilai = 250 Then
                tbStall1.Text = "0"
            ElseIf nilai > 250 Then
                tbStall1.Text = (nilai - 1).ToString()
            End If
        Else
            tbStall1.Text = "0"
        End If
    End Sub

    Private Sub btnPlusStall1_Click(sender As Object, e As EventArgs) Handles btnPlusStall1.Click
        ' Menambahkan nilai di tbPaketB
        If IsNumeric(tbStall1.Text) Then
            Dim nilai As Integer = Integer.Parse(tbStall1.Text)
            If nilai = 0 Then
                tbStall1.Text = "250"
            ElseIf nilai >= 250 Then
                tbStall1.Text = (nilai + 1).ToString()
            End If
        Else
            tbStall1.Text = "250"
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketB
    Private Sub tbStall1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbStall1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbStall1_Leave(sender As Object, e As EventArgs) Handles tbStall1.Leave
        If String.IsNullOrWhiteSpace(tbStall1.Text) OrElse Not IsNumeric(tbStall1.Text) Then
            tbPrasB.Text = "0"
        End If
    End Sub

    ' Stall 2 '
    Private Sub btnMinStall2_Click(sender As Object, e As EventArgs) Handles btnMinStall2.Click
        ' Mengurangkan nilai di tbPaketC
        If IsNumeric(tbStall2.Text) Then
            Dim nilai As Integer = Integer.Parse(tbStall2.Text)
            If nilai = 250 Then
                tbStall2.Text = "0"
            ElseIf nilai > 250 Then
                tbStall2.Text = (nilai - 1).ToString()
            End If
        Else
            tbStall2.Text = "0"
        End If
    End Sub

    Private Sub btnPlusStall2_Click(sender As Object, e As EventArgs) Handles btnPlusStall2.Click
        ' Menambahkan nilai di tbPaketB
        If IsNumeric(tbStall2.Text) Then
            Dim nilai As Integer = Integer.Parse(tbStall2.Text)
            If nilai = 0 Then
                tbStall2.Text = "250"
            ElseIf nilai >= 250 Then
                tbStall2.Text = (nilai + 1).ToString()
            End If
        Else
            tbStall2.Text = "250"
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketB
    Private Sub tbStall2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbStall2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbStall2_Leave(sender As Object, e As EventArgs) Handles tbStall2.Leave
        If String.IsNullOrWhiteSpace(tbStall1.Text) OrElse Not IsNumeric(tbStall2.Text) Then
            tbStall2.Text = "0"
        End If
    End Sub

    ' Stall 3 '
    Private Sub btnMinStall3_Click(sender As Object, e As EventArgs) Handles btnMinStall3.Click
        ' Mengurangkan nilai di tbPaketC
        If IsNumeric(tbStall3.Text) Then
            Dim nilai As Integer = Integer.Parse(tbStall3.Text)
            If nilai = 250 Then
                tbStall3.Text = "0"
            ElseIf nilai > 250 Then
                tbStall3.Text = (nilai - 1).ToString()
            End If
        Else
            tbStall3.Text = "0"
        End If
    End Sub

    Private Sub btnPlusStall3_Click(sender As Object, e As EventArgs) Handles btnPlusStall3.Click
        ' Menambahkan nilai di tbPaketB
        If IsNumeric(tbStall3.Text) Then
            Dim nilai As Integer = Integer.Parse(tbStall3.Text)
            If nilai = 0 Then
                tbStall3.Text = "250"
            ElseIf nilai >= 250 Then
                tbStall3.Text = (nilai + 1).ToString()
            End If
        Else
            tbStall3.Text = "250"
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketB
    Private Sub tbStall3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbStall3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbStall3_Leave(sender As Object, e As EventArgs) Handles tbStall3.Leave
        If String.IsNullOrWhiteSpace(tbStall3.Text) OrElse Not IsNumeric(tbStall3.Text) Then
            tbStall3.Text = "0"
        End If
    End Sub

    ' Stall 4 '
    Private Sub btnMinStall4_Click(sender As Object, e As EventArgs) Handles btnMinStall4.Click
        ' Mengurangkan nilai di tbPaketC
        If IsNumeric(tbStall4.Text) Then
            Dim nilai As Integer = Integer.Parse(tbStall4.Text)
            If nilai > 0 Then
                tbStall4.Text = (nilai - 1).ToString()
            End If
        Else
            tbStall4.Text = "0"
        End If
    End Sub

    Private Sub btnPlusStall4_Click(sender As Object, e As EventArgs) Handles btnPlusStall4.Click
        ' Menambahkan nilai di tbPaketB
        If IsNumeric(tbStall4.Text) Then
            Dim nilai As Integer = Integer.Parse(tbStall4.Text)
            tbStall4.Text = (nilai + 1).ToString()
        Else
            tbStall4.Text = "1"
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketB
    Private Sub tbStall4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbStall4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbStall4_Leave(sender As Object, e As EventArgs) Handles tbStall4.Leave
        If String.IsNullOrWhiteSpace(tbStall4.Text) OrElse Not IsNumeric(tbStall4.Text) Then
            tbStall4.Text = "0"
        End If
    End Sub

    ' Stall 5 '
    Private Sub btnMinStall5_Click(sender As Object, e As EventArgs) Handles btnMinStall5.Click
        ' Mengurangkan nilai di tbPaketC
        If IsNumeric(tbStall5.Text) Then
            Dim nilai As Integer = Integer.Parse(tbStall5.Text)
            If nilai > 0 Then
                tbStall5.Text = (nilai - 1).ToString()
            End If
        Else
            tbStall5.Text = "0"
        End If
    End Sub

    Private Sub btnPlusStall5_Click(sender As Object, e As EventArgs) Handles btnPlusStall5.Click
        ' Menambahkan nilai di tbPaketB
        If IsNumeric(tbStall5.Text) Then
            Dim nilai As Integer = Integer.Parse(tbStall5.Text)
            tbStall5.Text = (nilai + 1).ToString()
        Else
            tbStall5.Text = "1"
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketB
    Private Sub tbStall5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbStall5.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbStall5_Leave(sender As Object, e As EventArgs) Handles tbStall5.Leave
        If String.IsNullOrWhiteSpace(tbStall5.Text) OrElse Not IsNumeric(tbStall5.Text) Then
            tbStall3.Text = "0"
        End If
    End Sub


    ' Stall 6 '
    Private Sub btnMinStall6_Click(sender As Object, e As EventArgs) Handles btnMinStall6.Click
        ' Mengurangkan nilai di tbPaketC
        If IsNumeric(tbStall6.Text) Then
            Dim nilai As Integer = Integer.Parse(tbStall6.Text)
            If nilai > 0 Then
                tbStall6.Text = (nilai - 1).ToString()
            End If
        Else
            tbStall6.Text = "0"
        End If
    End Sub

    Private Sub btnPlusStall6_Click(sender As Object, e As EventArgs) Handles btnPlusStall6.Click
        ' Menambahkan nilai di tbPaketB
        If IsNumeric(tbStall6.Text) Then
            Dim nilai As Integer = Integer.Parse(tbStall6.Text)
            tbStall6.Text = (nilai + 1).ToString()
        Else
            tbStall6.Text = "1"
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketB
    Private Sub tbStall6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbStall6.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbStall6_Leave(sender As Object, e As EventArgs) Handles tbStall3.Leave
        If String.IsNullOrWhiteSpace(tbStall3.Text) OrElse Not IsNumeric(tbStall3.Text) Then
            tbStall3.Text = "0"
        End If
    End Sub

    '  Syukur 1'
    Private Sub btnMinSyukur1_Click(sender As Object, e As EventArgs) Handles btnMinSyukur1.Click
        ' Mengurangkan nilai di tbPaketC
        If IsNumeric(tbSyukur1.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSyukur1.Text)
            If nilai > 0 Then
                tbSyukur1.Text = (nilai - 1).ToString()
            End If
        Else
            tbSyukur1.Text = "0"
        End If
    End Sub

    Private Sub btnPlusSyukur1_Click(sender As Object, e As EventArgs) Handles btnPlusSyukur1.Click
        ' Menambahkan nilai di tbSyukur1
        If IsNumeric(tbSyukur1.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSyukur1.Text)
            tbSyukur1.Text = (nilai + 1).ToString()
        Else
            tbSyukur1.Text = "1"
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketB
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


    '  Syukur 2'
    Private Sub btnMinSyukur2_Click(sender As Object, e As EventArgs) Handles btnMinSyukur2.Click
        ' Mengurangkan nilai di tbPaketC
        If IsNumeric(tbSyukur2.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSyukur2.Text)
            If nilai > 0 Then
                tbSyukur2.Text = (nilai - 1).ToString()
            End If
        Else
            tbSyukur2.Text = "0"
        End If
    End Sub

    Private Sub btnPlusSyukur2_Click(sender As Object, e As EventArgs) Handles btnPlusSyukur2.Click
        ' Menambahkan nilai di tbSyukur1
        If IsNumeric(tbSyukur2.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSyukur2.Text)
            tbSyukur2.Text = (nilai + 1).ToString()
        Else
            tbSyukur2.Text = "1"
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketB
    Private Sub tbSyukur2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSyukur2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbSyukur2_Leave(sender As Object, e As EventArgs) Handles tbSyukur2.Leave
        If String.IsNullOrWhiteSpace(tbSyukur2.Text) OrElse Not IsNumeric(tbSyukur2.Text) Then
            tbSyukur2.Text = "0"
        End If
    End Sub


    '  Syukur 3'
    Private Sub btnMinSyukur3_Click(sender As Object, e As EventArgs) Handles btnMinSyukur3.Click
        ' Mengurangkan nilai di tbPaketC
        If IsNumeric(tbSyukur3.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSyukur3.Text)
            If nilai > 0 Then
                tbSyukur3.Text = (nilai - 1).ToString()
            End If
        Else
            tbSyukur3.Text = "0"
        End If
    End Sub

    Private Sub btnPlusSyukur3_Click(sender As Object, e As EventArgs) Handles btnPlusSyukur3.Click
        ' Menambahkan nilai di tbSyukur1
        If IsNumeric(tbSyukur3.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSyukur3.Text)
            tbSyukur3.Text = (nilai + 1).ToString()
        Else
            tbSyukur3.Text = "1"
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketB
    Private Sub tbSyukur3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSyukur3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbSyukur3_Leave(sender As Object, e As EventArgs) Handles tbSyukur3.Leave
        If String.IsNullOrWhiteSpace(tbSyukur3.Text) OrElse Not IsNumeric(tbSyukur3.Text) Then
            tbSyukur3.Text = "0"
        End If
    End Sub

    '  Syukur 4'
    Private Sub btnMinSyukur4_Click(sender As Object, e As EventArgs) Handles btnMinSyukur4.Click
        ' Mengurangkan nilai di tbPaketC
        If IsNumeric(tbSyukur4.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSyukur4.Text)
            If nilai > 0 Then
                tbSyukur4.Text = (nilai - 1).ToString()
            End If
        Else
            tbSyukur4.Text = "0"
        End If
    End Sub

    Private Sub btnPlusSyukur4_Click(sender As Object, e As EventArgs) Handles btnPlusSyukur4.Click
        ' Menambahkan nilai di tbSyukur1
        If IsNumeric(tbSyukur4.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSyukur4.Text)
            tbSyukur4.Text = (nilai + 1).ToString()
        Else
            tbSyukur4.Text = "1"
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketB
    Private Sub tbSyukur4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSyukur4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbSyukur4_Leave(sender As Object, e As EventArgs) Handles tbSyukur4.Leave
        If String.IsNullOrWhiteSpace(tbSyukur4.Text) OrElse Not IsNumeric(tbSyukur4.Text) Then
            tbSyukur4.Text = "0"
        End If
    End Sub


    '  Dos 1'
    Private Sub btnMinDos1_Click(sender As Object, e As EventArgs) Handles btnMinDos1.Click
        ' Mengurangkan nilai di tbPaketC
        If IsNumeric(tbDos1.Text) Then
            Dim nilai As Integer = Integer.Parse(tbDos1.Text)
            If nilai > 0 Then
                tbDos1.Text = (nilai - 1).ToString()
            End If
        Else
            tbDos1.Text = "0"
        End If
    End Sub

    Private Sub btnPlusDos1_Click(sender As Object, e As EventArgs) Handles btnPlusDos1.Click
        ' Menambahkan nilai di tbSyukur1
        If IsNumeric(tbDos1.Text) Then
            Dim nilai As Integer = Integer.Parse(tbDos1.Text)
            tbDos1.Text = (nilai + 1).ToString()
        Else
            tbDos1.Text = "1"
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketB
    Private Sub tbDos1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDos1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbDos1_Leave(sender As Object, e As EventArgs) Handles tbDos1.Leave
        If String.IsNullOrWhiteSpace(tbDos1.Text) OrElse Not IsNumeric(tbDos1.Text) Then
            tbDos1.Text = "0"
        End If
    End Sub

    '  Dos 2'
    Private Sub btnMinDos2_Click(sender As Object, e As EventArgs) Handles btnMinDos2.Click
        ' Mengurangkan nilai di tbPaketC
        If IsNumeric(tbDos2.Text) Then
            Dim nilai As Integer = Integer.Parse(tbDos2.Text)
            If nilai > 0 Then
                tbDos2.Text = (nilai - 1).ToString()
            End If
        Else
            tbDos2.Text = "0"
        End If
    End Sub

    Private Sub btnPlusDos2_Click(sender As Object, e As EventArgs) Handles btnPlusDos2.Click
        ' Menambahkan nilai di tbSyukur1
        If IsNumeric(tbDos2.Text) Then
            Dim nilai As Integer = Integer.Parse(tbDos2.Text)
            tbDos2.Text = (nilai + 1).ToString()
        Else
            tbDos2.Text = "1"
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketB
    Private Sub tbDos2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDos2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbDos2_Leave(sender As Object, e As EventArgs) Handles tbDos2.Leave
        If String.IsNullOrWhiteSpace(tbDos1.Text) OrElse Not IsNumeric(tbDos2.Text) Then
            tbDos2.Text = "0"
        End If
    End Sub

    '  Dos 3'
    Private Sub btnMinDos3_Click(sender As Object, e As EventArgs) Handles btnMinDos3.Click
        ' Mengurangkan nilai di tbPaketC
        If IsNumeric(tbDos3.Text) Then
            Dim nilai As Integer = Integer.Parse(tbDos3.Text)
            If nilai > 0 Then
                tbDos3.Text = (nilai - 1).ToString()
            End If
        Else
            tbDos3.Text = "0"
        End If
    End Sub

    Private Sub btnPlusDos3_Click(sender As Object, e As EventArgs) Handles btnPlusDos3.Click
        ' Menambahkan nilai di tbSyukur1
        If IsNumeric(tbDos3.Text) Then
            Dim nilai As Integer = Integer.Parse(tbDos3.Text)
            tbDos3.Text = (nilai + 1).ToString()
        Else
            tbDos3.Text = "1"
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketB
    Private Sub tbDos3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDos3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbDos3_Leave(sender As Object, e As EventArgs) Handles tbDos3.Leave
        If String.IsNullOrWhiteSpace(tbDos3.Text) OrElse Not IsNumeric(tbDos3.Text) Then
            tbDos3.Text = "0"
        End If
    End Sub

    '  Snack 1'
    Private Sub btnMinSnack1_Click(sender As Object, e As EventArgs) Handles btnMinSnack1.Click
        ' Mengurangkan nilai di tbPaketC
        If IsNumeric(tbSnack1.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSnack1.Text)
            If nilai > 0 Then
                tbSnack1.Text = (nilai - 1).ToString()
            End If
        Else
            tbSnack1.Text = "0"
        End If
    End Sub

    Private Sub btnPlusSnack1_Click(sender As Object, e As EventArgs) Handles btnPlusSnack1.Click
        ' Menambahkan nilai di tbSyukur1
        If IsNumeric(tbSnack1.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSnack1.Text)
            tbSnack1.Text = (nilai + 1).ToString()
        Else
            tbSnack1.Text = "1"
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketB
    Private Sub tbSnack1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSnack1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbSnack1_Leave(sender As Object, e As EventArgs) Handles tbSnack1.Leave
        If String.IsNullOrWhiteSpace(tbSnack1.Text) OrElse Not IsNumeric(tbSnack1.Text) Then
            tbSnack1.Text = "0"
        End If
    End Sub

    '  Snack 2'
    Private Sub btnMinSnack2_Click(sender As Object, e As EventArgs) Handles btnMinSnack2.Click
        ' Mengurangkan nilai di tbPaketC
        If IsNumeric(tbSnack2.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSnack2.Text)
            If nilai > 0 Then
                tbSnack2.Text = (nilai - 1).ToString()
            End If
        Else
            tbSnack2.Text = "0"
        End If
    End Sub

    Private Sub btnPlusSnack2_Click(sender As Object, e As EventArgs) Handles btnPlusSnack2.Click
        ' Menambahkan nilai di tbSyukur1
        If IsNumeric(tbSnack2.Text) Then
            Dim nilai As Integer = Integer.Parse(tbSnack2.Text)
            tbSnack2.Text = (nilai + 1).ToString()
        Else
            tbSnack2.Text = "1"
        End If
    End Sub

    ' Validasi input hanya angka untuk tbPaketB
    Private Sub tbSnack2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSnack2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Handle ketika tbPaketA kehilangan fokus
    Private Sub tbSnack2_Leave(sender As Object, e As EventArgs) Handles tbSnack2.Leave
        If String.IsNullOrWhiteSpace(tbSnack2.Text) OrElse Not IsNumeric(tbSnack2.Text) Then
            tbSnack2.Text = "0"
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form3.Hide()

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

    Public originalIdAcara As String

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
    End Sub
    Private Sub btnSimpanPaket_Click(sender As Object, e As EventArgs) Handles btnSimpanPaket.Click
        Dim angka As Integer = Convert.ToInt32(lblTotalHargaPaket.Text.Replace(".", ""))
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
        Dim i
        i = 0
        Dim sql As String = "select * from pesanan join detail_paket on pesanan.id_paket = detail_paket.id_paket where id_acara = " & originalIdAcara & " AND pesanan.id_paket BETWEEN 11 AND 25"
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
                Dim sqlCek As String = "SELECT COUNT(*) FROM pesanan WHERE id_paket = '" & id_paket & "'"
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
                            tbPrasA.Text = ""
                        Case 12
                            tbPrasB.Text = ""
                        Case 13
                            tbPrasC.Text = ""
                    End Select
                    Exit For
                Else
                    MessageBox.Show("Data gagal dihapus.")
                End If
            Next
        Else
            MessageBox.Show("Silakan pilih baris yang ingin dihapus.")
        End If
    End Sub

    Private Sub CheckedListBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class