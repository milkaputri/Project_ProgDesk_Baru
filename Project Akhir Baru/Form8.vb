Imports System.Windows.Forms.AxHost
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO


Public Class Form8
    Public originalIdAcara As String
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilDataPaket()
        TampilDataTambahan()
        Dim total_paket As Integer = lblHargaTotalPaket.Text
        Dim total_tambahan As Integer = lblTotalHargaTambahan.Text
        Dim hasil = total_paket + total_tambahan
        'Dim hasil = lblHargaTotalPaket.Text + lblTotalHargaTambahan.Text
        lblTotalHargaSemua.Text = Convert.ToInt32(hasil).ToString("N0")
    End Sub
    Public Sub TampilDataPaket()
        Dim i
        i = 0
        Dim sql As String = "select * from pesanan join detail_paket on pesanan.id_paket = detail_paket.id_paket join detail_pesanan on pesanan.id_paket = detail_pesanan.id_paket where id_acara = " & originalIdAcara & " AND pesanan.id_paket"
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

            lblTotalHargaTambahan.Text = totalPengeluaran.ToString("N0")
            myDataReader.Close()
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
    End Sub

    Private Sub btnCetakPDF_Click(sender As Object, e As EventArgs) Handles btnCetakPDF.Click
        ' Simpan ukuran asli panel
        Dim originalSizePaket As Size = panelPaket.Size
        Dim originalSizeTambahan As Size = panelTambahan.Size

        ' Hitung ukuran isi sebenarnya (DisplayRectangle.Height)
        Dim paketContentHeight As Integer = panelPaket.DisplayRectangle.Height
        Dim tambahanContentHeight As Integer = panelTambahan.DisplayRectangle.Height

        ' Nonaktifkan scroll agar seluruh konten terlihat
        panelPaket.AutoScroll = False
        panelTambahan.AutoScroll = False
        panelPaket.Height = paketContentHeight
        panelTambahan.Height = tambahanContentHeight

        ' Gambar masing-masing panel ke Bitmap
        Dim bmpPaket As New Bitmap(panelPaket.Width, paketContentHeight)
        panelPaket.DrawToBitmap(bmpPaket, New System.Drawing.Rectangle(0, 0, panelPaket.Width, paketContentHeight))

        Dim bmpTambahan As New Bitmap(panelTambahan.Width, tambahanContentHeight)
        panelTambahan.DrawToBitmap(bmpTambahan, New System.Drawing.Rectangle(0, 0, panelTambahan.Width, tambahanContentHeight))

        ' --- Tambahan: pastikan ada data dalam DataGridViewTambahan sebelum lanjut
        If DataGridViewTambahan.Rows.Count = 0 Then
            MessageBox.Show("Panel Tambahan kosong, tidak bisa dicetak.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- Paksa ukuran panelTambahan menyesuaikan konten (jika tinggi terlalu kecil)
        Dim minHeight As Integer = 300 ' fallback default
        'Dim tambahanContentHeight As Integer = panelTambahan.DisplayRectangle.Height
        If tambahanContentHeight < minHeight Then tambahanContentHeight = minHeight

        panelTambahan.Height = tambahanContentHeight
        panelTambahan.AutoScroll = False

        'Dim bmpTambahan As New Bitmap(panelTambahan.Width, tambahanContentHeight)
        panelTambahan.DrawToBitmap(bmpTambahan, New System.Drawing.Rectangle(0, 0, panelTambahan.Width, tambahanContentHeight))


        ' Gabungkan gambar secara vertikal: Paket di atas, Tambahan di bawah
        Dim totalWidth As Integer = Math.Max(bmpPaket.Width, bmpTambahan.Width)
        Dim totalHeight As Integer = bmpPaket.Height + bmpTambahan.Height
        Dim bmpGabungan As New Bitmap(totalWidth, totalHeight)

        Using g As Graphics = Graphics.FromImage(bmpGabungan)
            g.Clear(Color.White)
            g.DrawImage(bmpPaket, 0, 0)
            g.DrawImage(bmpTambahan, 0, bmpPaket.Height)
        End Using

        ' Buat dokumen PDF
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF Files|*.pdf"
        saveFileDialog.Title = "Simpan PDF"
        saveFileDialog.FileName = "PanelGabungan.pdf"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim pdfDoc As New Document(PageSize.A4, 10, 10, 10, 10)
            Dim writer As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(saveFileDialog.FileName, FileMode.Create))
            pdfDoc.Open()

            Dim pageWidth As Integer = CInt(pdfDoc.PageSize.Width)
            Dim pageHeight As Integer = CInt(pdfDoc.PageSize.Height)

            Dim yOffset As Integer = 0
            While yOffset < bmpGabungan.Height
                Dim sliceHeight As Integer = Math.Min(pageHeight, bmpGabungan.Height - yOffset)
                Dim bmpSlice As New Bitmap(bmpGabungan.Width, sliceHeight)

                Using g As Graphics = Graphics.FromImage(bmpSlice)
                    g.DrawImage(
                        bmpGabungan,
                        New System.Drawing.Rectangle(0, 0, bmpGabungan.Width, sliceHeight),
                        New System.Drawing.Rectangle(0, yOffset, bmpGabungan.Width, sliceHeight),
                        GraphicsUnit.Pixel
                    )
                End Using

                Using ms As New MemoryStream()
                    bmpSlice.Save(ms, Imaging.ImageFormat.Png)
                    Dim img As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(ms.ToArray())
                    img.ScaleToFit(pageWidth - 20, pageHeight - 20)
                    img.Alignment = Element.ALIGN_CENTER
                    pdfDoc.Add(img)
                    If yOffset + sliceHeight < bmpGabungan.Height Then
                        pdfDoc.NewPage()
                    End If
                End Using

                yOffset += sliceHeight
            End While

            pdfDoc.Close()
            MessageBox.Show("PDF berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Kembalikan ukuran panel ke semula
        panelPaket.Size = originalSizePaket
        panelTambahan.Size = originalSizeTambahan
        panelPaket.AutoScroll = True
        panelTambahan.AutoScroll = True
    End Sub

    Private Sub DataGridViewPaket_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPaket.CellContentClick

    End Sub
End Class