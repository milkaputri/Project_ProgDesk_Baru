Imports MySql.Data.MySqlClient

Public Class Form5
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim sql As String = "insert into acara(nama_acara,tanggal_pelaksanaan,waktu,lokasi,nama_pemesan,alamat_pemesan,no_hp_pertama,no_hp_kedua) values ('" & tbNamaKegiatan.Text & "','" & tglPelaksanaan.SelectionStart.ToString("yyyy-MM-dd") & "','" & tbWaktu.Text & "','" & tbLokasi.Text & "','" & tbNamaPemesan.Text & "','" & tbAlamat.Text & "','" & tbNoHpPertama.Text & "','" & tbNoHpKedua.Text & "')"
        myCommand.CommandText = sql
        myCommand.ExecuteNonQuery()
        MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Code untuk CheckBox di Tab "Paket" '
    Private Sub cbJasmine_CheckedChanged(sender As Object, e As EventArgs) Handles cbJasmine.CheckedChanged
        If cbJasmine.Checked Then
            SembunyikanCheckboxLain(cbJasmine)
        Else
            TampilkanSemuaCheckbox()
        End If
    End Sub

    Private Sub cbTulip_CheckedChanged(sender As Object, e As EventArgs) Handles cbTulip.CheckedChanged
        If cbTulip.Checked Then
            SembunyikanCheckboxLain(cbTulip)
        Else
            TampilkanSemuaCheckbox()
        End If
    End Sub

    Private Sub cbOrchid_CheckedChanged(sender As Object, e As EventArgs) Handles cbOrchid.CheckedChanged
        If cbOrchid.Checked Then
            SembunyikanCheckboxLain(cbOrchid)
        Else
            TampilkanSemuaCheckbox()
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
            If nilai > 0 Then
                tbPrasA.Text = (nilai - 1).ToString()
            End If
        Else
            tbPrasA.Text = "0"
        End If
    End Sub

    Private Sub btnPlusPaketA_Click(sender As Object, e As EventArgs) Handles btnPlusPrasA.Click
        ' Menambahkan nilai di tbPaketA
        If IsNumeric(tbPrasA.Text) Then
            Dim nilai As Integer = Integer.Parse(tbPrasA.Text)
            tbPrasA.Text = (nilai + 1).ToString()
        Else
            tbPrasA.Text = "1"
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
    Private Sub btnMinPaketB_Click(sender As Object, e As EventArgs) Handles btnMinPrasA.Click
        ' Mengurangkan nilai di tbPaketB
        If IsNumeric(tbPrasB.Text) Then
            Dim nilai As Integer = Integer.Parse(tbPrasB.Text)
            If nilai > 0 Then
                tbPrasB.Text = (nilai - 1).ToString()
            End If
        Else
            tbPrasB.Text = "0"
        End If
    End Sub

    Private Sub btnPlusPaketB_Click(sender As Object, e As EventArgs) Handles btnPlusPrasB.Click
        ' Menambahkan nilai di tbPaketB
        If IsNumeric(tbPrasB.Text) Then
            Dim nilai As Integer = Integer.Parse(tbPrasB.Text)
            tbPrasB.Text = (nilai + 1).ToString()
        Else
            tbPrasB.Text = "1"
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
            If nilai > 0 Then
                tbPrasC.Text = (nilai - 1).ToString()
            End If
        Else
            tbPrasC.Text = "0"
        End If
    End Sub

    Private Sub btnPlusPrasC_Click(sender As Object, e As EventArgs) Handles btnPlusPrasC.Click
        ' Menambahkan nilai di tbPaketB
        If IsNumeric(tbPrasC.Text) Then
            Dim nilai As Integer = Integer.Parse(tbPrasC.Text)
            tbPrasC.Text = (nilai + 1).ToString()
        Else
            tbPrasC.Text = "1"
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
            If nilai > 0 Then
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
            tbStall1.Text = (nilai + 1).ToString()
        Else
            tbStall1.Text = "1"
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
            If nilai > 0 Then
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
            tbStall2.Text = (nilai + 1).ToString()
        Else
            tbStall2.Text = "1"
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
            If nilai > 0 Then
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
            tbStall3.Text = (nilai + 1).ToString()
        Else
            tbStall3.Text = "1"
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

    End Sub

    Private Sub Panel19_Paint(sender As Object, e As PaintEventArgs) Handles Panel19.Paint

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form2.Show()
        Hide()
    End Sub
End Class