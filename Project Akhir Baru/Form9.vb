Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient
Imports System.IO
Imports SysDraw = System.Drawing

Public Class Form9
    Public originalIdAcara As String
    'Private Sub TampilData()
    '    Dim sql As String = "select * from acara where id_acara = " & originalIdAcara
    '    myCommand.CommandText = sql
    '    myDataReader = myCommand.ExecuteReader
    '    If myDataReader.HasRows Then
    '        While myDataReader.Read()
    '            lblNamaPemesan.Text = myDataReader("nama_pemesan").ToString()
    '            lblAlamat.Text = myDataReader("alamat_pemesan").ToString()
    '            lblNoHp1.Text = myDataReader("no_hp_pertama").ToString()
    '            lblNoHp2.Text = myDataReader("no_hp_kedua").ToString()
    '            lblNamaAcara.Text = myDataReader("nama_acara").ToString()
    '            lblTanggal.Text = myDataReader("tanggal_pelaksanaan").ToString("dd-MM-yyyy")
    '            lblWaktu.Text = myDataReader("waktu").ToString()
    '            lblLokasi.Text = myDataReader("lokasi").ToString()
    '        End While
    '        myDataReader.Close()
    '    End If
    'End Sub

    'Private Sub LoadDataDariDatabase(ByVal id As Integer)
    '    Dim connStr As String = "server=localhost;user id=root;password=;database=project_akhir;"
    '    Dim query As String = "SELECT * FROM acara WHERE id_acara = @id"

    '    Using conn As New MySqlConnection(connStr)
    '        Try
    '            conn.Open()
    '            Using cmd As New MySqlCommand(query, conn)
    '                cmd.Parameters.AddWithValue("@id", id)

    '                Using reader As MySqlDataReader = cmd.ExecuteReader()
    '                    If reader.Read() Then
    '                        lblNama.Text = reader("nama_acara").ToString()
    '                        lblAlamat.Text = reader("alamat_pemesan").ToString()
    '                        lblNoHp1.Text = reader("no_hp_pertama").ToString()
    '                        lblNoHp2.Text = reader("no_hp_kedua").ToString()
    '                        lblTanggal.Text = Convert.ToDateTime(reader("tanggal_pelaksanaan")).ToString("dd-MM-yyyy")
    '                        lblWaktu.Text = reader("waktu").ToString()
    '                        lblLokasi.Text = reader("lokasi").ToString()
    '                    Else
    '                        MessageBox.Show("Data tidak ditemukan.")
    '                    End If
    '                End Using
    '            End Using

    '        Catch ex As Exception
    '            MessageBox.Show("Error saat mengambil data: " & ex.Message)
    '        End Try
    '    End Using
    'End Sub
    Public Sub TampilDataPaket()
        Dim i
        i = 0
        Dim sql As String = "select * from pesanan join detail_paket on pesanan.id_paket = detail_paket.id_paket join detail_pesanan on pesanan.id_paket = detail_pesanan.id_paket where id_acara = " & originalIdAcara & " AND pesanan.id_paket BETWEEN 1 AND 10"
        myCommand.CommandText = sql
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            While myDataReader.Read()
                lblNamaPaket.Text = myDataReader("nama_paket")
                DataGridViewPaket.Rows.Add()
                DataGridViewPaket.Item(0, i).Value = myDataReader("sub_isi_paket")
                DataGridViewPaket.Item(1, i).Value = myDataReader("detail_sub_paket")
                DataGridViewPaket.Item(2, i).Value = "1"
                DataGridViewPaket.Item(3, i).Value = myDataReader("id_paket")
                lblHargaTotalPaket.Text = Convert.ToInt32(myDataReader("harga_paket")).ToString("N0")
                i = i + 1
            End While
            myDataReader.Close()
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If

    End Sub

    Public Sub TampilDataTambahan()
        Dim i
        i = 0
        Dim sql As String = "select * from pesanan join detail_paket on pesanan.id_paket = detail_paket.id_paket join detail_pesanan on pesanan.id_paket = detail_pesanan.id_paket where id_acara = " & originalIdAcara & " AND pesanan.id_paket BETWEEN 11 AND 51"
        myCommand.CommandText = sql
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            While myDataReader.Read()
                Dim harga As Integer = myDataReader("harga_paket")
                Dim jumlah As Integer = myDataReader("jumlah_paket")
                DataGridViewTambahan.Rows.Add()
                DataGridViewTambahan.Item(0, i).Value = myDataReader("sub_isi_paket")
                DataGridViewTambahan.Item(1, i).Value = myDataReader("detail_sub_paket")
                DataGridViewTambahan.Item(2, i).Value = jumlah
                DataGridViewTambahan.Item(3, i).Value = jumlah * harga
                DataGridViewTambahan.Item(4, i).Value = myDataReader("id_paket")
                i = i + 1
            End While
            Dim totalPengeluaran As Integer = 0
            For Each row As DataGridViewRow In DataGridViewTambahan.Rows
                If Not row.IsNewRow AndAlso Not IsDBNull(row.Cells("colTotalTambahan").Value) Then
                    totalPengeluaran += Convert.ToInt32(row.Cells("colTotalTambahan").Value)
                End If
            Next

            'lblTotalHargaTambahan.Text = totalPengeluaran.ToString("N0")
            myDataReader.Close()
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Public Sub TampilPembayaran()
        Dim sql As String = "select * from pembayaran where id_acara = " & originalIdAcara
        myCommand.CommandText = sql
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            While myDataReader.Read()
                Dim total As Integer = myDataReader("total_pembayaran")
                LblRpTagihan.Text = "Rp " & total.ToString("N0")
                'dateRealLunas.Enabled = False
                If myDataReader("tipe_pembayaran") = "Lunas" Then
                    Dim dateRlLunas As Date = myDataReader("tgl_real_lunas")
                    lblRpLunas.Text = "Rp " & total.ToString("N0")
                    'dateRealLunas.Value = Convert.ToDateTime(dateRlLunas)
                Else
                    Dim tglRealCicil3 As Date = myDataReader("tgl_real_cicil3")
                    lblRpLunas.Text = "Rp " & total.ToString("N0")
                    'dateRealLunas.Value = Convert.ToDateTime(tglRealCicil3)
                End If
            End While
            myDataReader.Close()
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs)
        ' Simpan ukuran asli panel
        Dim originalSize = panelCetak.Size

        ' Hitung tinggi konten sebenarnya
        Dim contentHeight = panelCetak.DisplayRectangle.Height

        ' Nonaktifkan AutoScroll dan ubah ukuran panel agar seluruh konten terlihat
        panelCetak.AutoScroll = False
        panelCetak.Height = contentHeight

        ' Gambar panel ke bitmap
        ' Gambar panel ke bitmap
        Dim bmp As New Bitmap(panelCetak.Width, contentHeight)
        panelCetak.DrawToBitmap(bmp, New SysDraw.Rectangle(0, 0, panelCetak.Width, contentHeight))


        ' Simpan PDF
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "PDF Files|*.pdf"
        saveFileDialog.Title = "Simpan PDF"
        saveFileDialog.FileName = "CetakPanel.pdf"

        If saveFileDialog.ShowDialog = DialogResult.OK Then
            Dim pdfDoc As New Document(PageSize.A4, 10, 10, 10, 10)
            Dim writer = PdfWriter.GetInstance(pdfDoc, New FileStream(saveFileDialog.FileName, FileMode.Create))
            pdfDoc.Open()

            Dim pageWidth As Integer = pdfDoc.PageSize.Width
            Dim pageHeight As Integer = pdfDoc.PageSize.Height

            Dim yOffset = 0
            While yOffset < bmp.Height
                Dim sliceHeight = Math.Min(pageHeight, bmp.Height - yOffset)
                Dim bmpSlice As New Bitmap(bmp.Width, sliceHeight)

                Using g = Graphics.FromImage(bmpSlice)
                    'g.DrawImage(
                    '    bmp,
                    '    New System.Drawing.Rectangle(0, 0, bmp.Width, sliceHeight),
                    '    New System.Drawing.Rectangle(0, yOffset, bmp.Width, sliceHeight),
                    '    GraphicsUnit.Pixel
                    ')

                    g.DrawImage(
                        bmp,
                        New SysDraw.Rectangle(0, 0, bmp.Width, sliceHeight),
                        New SysDraw.Rectangle(0, yOffset, bmp.Width, sliceHeight),
                        GraphicsUnit.Pixel
                    )
                End Using

                Using ms As New MemoryStream
                    bmpSlice.Save(ms, Imaging.ImageFormat.Png)
                    Dim img = Image.GetInstance(ms.ToArray)
                    img.ScaleToFit(pageWidth - 20, pageHeight - 20)
                    img.Alignment = Element.ALIGN_CENTER
                    pdfDoc.Add(img)
                    If yOffset + sliceHeight < bmp.Height Then
                        pdfDoc.NewPage()
                    End If
                End Using

                yOffset += sliceHeight
            End While

            pdfDoc.Close()
            MessageBox.Show("PDF berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Kembalikan ukuran dan scroll ke semula
        panelCetak.Size = originalSize
        panelCetak.AutoScroll = True
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadDataDariDatabase(1)
        'TampilDataPaket()
        'TampilDataTambahan()
        'Dim total_paket As Integer = lblHargaTotalPaket.Text
        'Dim total_tambahan As Integer = lblTotalHargaTambahan.Text
        'Dim hasil = total_paket + total_tambahan
    End Sub

    Private Sub DataGridViewPaket_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPaket.CellContentClick

    End Sub

    Private Sub panelCetak_Paint(sender As Object, e As PaintEventArgs) Handles panelCetak.Paint

    End Sub

    Private Sub pnlCicilan_Paint(sender As Object, e As PaintEventArgs) Handles pnlCicilan.Paint

    End Sub

    Private Sub DataGridViewTambahan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTambahan.CellContentClick

    End Sub

    Private Sub lblTotalHargaTambahan_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label128_Click(sender As Object, e As EventArgs)

    End Sub
End Class