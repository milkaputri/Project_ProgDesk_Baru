Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient
Imports System.IO
Imports SysDraw = System.Drawing

Public Class Form9
    Public originalIdAcara As String


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

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadDataDariDatabase(1)
        'TampilDataPaket()
        'TampilDataTambahan()
        'Dim total_paket As Integer = lblHargaTotalPaket.Text
        'Dim total_tambahan As Integer = lblTotalHargaTambahan.Text
        'Dim hasil = total_paket + total_tambahan
    End Sub



    Private Sub btnCetak_Click_1(sender As Object, e As EventArgs) Handles btnCetak.Click
        ' Simpan ukuran asli panel
        Dim originalSize = panelCetak.Size

        ' Hitung tinggi konten sebenarnya
        Dim contentHeight = panelCetak.DisplayRectangle.Height

        ' Nonaktifkan AutoScroll dan ubah ukuran panel agar seluruh konten terlihat
        panelCetak.AutoScroll = False
        panelCetak.Height = contentHeight

        ' Gambar panel ke bitmap
        Dim bmp As New Bitmap(panelCetak.Width, contentHeight)
        panelCetak.DrawToBitmap(bmp, New SysDraw.Rectangle(0, 0, bmp.Width, bmp.Height))

        ' Simpan PDF
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "PDF Files|*.pdf"
        saveFileDialog.Title = "Simpan PDF"
        saveFileDialog.FileName = "CetakPanel.pdf"

        If saveFileDialog.ShowDialog = DialogResult.OK Then
            ' Gunakan halaman landscape
            Dim pdfDoc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            Dim writer = PdfWriter.GetInstance(pdfDoc, New FileStream(saveFileDialog.FileName, FileMode.Create))
            pdfDoc.Open()

            Using ms As New MemoryStream()
                bmp.Save(ms, Imaging.ImageFormat.Png)
                Dim img = iTextSharp.text.Image.GetInstance(ms.ToArray())

                ' Hitung skala agar seluruh gambar muat ke 1 halaman
                Dim pageWidth = pdfDoc.PageSize.Width - 20
                Dim pageHeight = pdfDoc.PageSize.Height - 20

                Dim scaleX As Single = pageWidth / img.Width
                Dim scaleY As Single = pageHeight / img.Height
                Dim scale As Single = Math.Min(scaleX, scaleY)

                img.ScaleAbsolute(img.Width * scale, img.Height * scale)
                img.Alignment = Element.ALIGN_CENTER

                pdfDoc.Add(img)
            End Using

            pdfDoc.Close()
            MessageBox.Show("PDF berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Kembalikan ukuran dan scroll ke semula
        panelCetak.Size = originalSize
        panelCetak.AutoScroll = True
    End Sub

End Class