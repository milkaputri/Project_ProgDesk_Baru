Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports SysDraw = System.Drawing

Public Class Form10
    Public originalId As String
    'Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
    '    ' Simpan ukuran asli panel
    '    Dim originalSize As Size = pnlCetak.Size

    '    ' Hitung tinggi konten sebenarnya
    '    Dim contentHeight As Integer = pnlCetak.DisplayRectangle.Height

    '    ' Nonaktifkan AutoScroll dan ubah ukuran panel agar seluruh konten terlihat
    '    pnlCetak.AutoScroll = False
    '    pnlCetak.Height = contentHeight

    '    ' Gambar panel ke bitmap
    '    ' Gambar panel ke bitmap
    '    Dim bmp As New Bitmap(pnlCetak.Width, contentHeight)
    '    pnlCetak.DrawToBitmap(bmp, New SysDraw.Rectangle(0, 0, pnlCetak.Width, contentHeight))


    '    ' Simpan PDF
    '    Dim saveFileDialog As New SaveFileDialog()
    '    saveFileDialog.Filter = "PDF Files|*.pdf"
    '    saveFileDialog.Title = "Simpan PDF"
    '    saveFileDialog.FileName = "CetakPanel.pdf"

    '    If saveFileDialog.ShowDialog() = DialogResult.OK Then
    '        Dim pdfDoc As New Document(PageSize.A4, 10, 10, 10, 10)
    '        Dim writer As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(saveFileDialog.FileName, FileMode.Create))
    '        pdfDoc.Open()

    '        Dim pageWidth As Integer = CInt(pdfDoc.PageSize.Width)
    '        Dim pageHeight As Integer = CInt(pdfDoc.PageSize.Height)

    '        Dim yOffset As Integer = 0
    '        While yOffset < bmp.Height
    '            Dim sliceHeight As Integer = Math.Min(pageHeight, bmp.Height - yOffset)
    '            Dim bmpSlice As New Bitmap(bmp.Width, sliceHeight)

    '            Using g As Graphics = Graphics.FromImage(bmpSlice)
    '                'g.DrawImage(
    '                '    bmp,
    '                '    New System.Drawing.Rectangle(0, 0, bmp.Width, sliceHeight),
    '                '    New System.Drawing.Rectangle(0, yOffset, bmp.Width, sliceHeight),
    '                '    GraphicsUnit.Pixel
    '                ')

    '                g.DrawImage(
    '                    bmp,
    '                    New SysDraw.Rectangle(0, 0, bmp.Width, sliceHeight),
    '                    New SysDraw.Rectangle(0, yOffset, bmp.Width, sliceHeight),
    '                    GraphicsUnit.Pixel
    '                )
    '            End Using

    '            Using ms As New MemoryStream()
    '                bmpSlice.Save(ms, Imaging.ImageFormat.Png)
    '                Dim img As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(ms.ToArray())
    '                img.ScaleToFit(pageWidth - 20, pageHeight - 20)
    '                img.Alignment = Element.ALIGN_CENTER
    '                pdfDoc.Add(img)
    '                If yOffset + sliceHeight < bmp.Height Then
    '                    pdfDoc.NewPage()
    '                End If
    '            End Using

    '            yOffset += sliceHeight
    '        End While

    '        pdfDoc.Close()
    '        MessageBox.Show("PDF berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If

    '    ' Kembalikan ukuran dan scroll ke semula
    '    pnlCetak.Size = originalSize
    '    pnlCetak.AutoScroll = True
    'End Sub
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        ' Simpan ukuran asli panel
        Dim originalSize = pnlCetak.Size

        ' Hitung tinggi konten sebenarnya
        Dim contentHeight = pnlCetak.DisplayRectangle.Height

        ' Nonaktifkan AutoScroll dan ubah ukuran panel agar seluruh konten terlihat
        pnlCetak.AutoScroll = False
        pnlCetak.Height = contentHeight

        ' Gambar panel ke bitmap
        Dim bmp As New Bitmap(pnlCetak.Width, contentHeight)
        pnlCetak.DrawToBitmap(bmp, New SysDraw.Rectangle(0, 0, bmp.Width, bmp.Height))

        ' Simpan PDF
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "PDF Files|*.pdf"
        saveFileDialog.Title = "Simpan PDF"
        saveFileDialog.FileName = "Invoice Pemesanan.pdf"

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
        pnlCetak.Size = originalSize
        pnlCetak.AutoScroll = True
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub TampilkanCetakan(ByVal jenis As String)
        ' Sembunyikan semua label terlebih dahulu
        lblLunas.Visible = False
        lblBayarLunas.Visible = False
        lblTglLunas.Visible = False

        lblCicilan1.Visible = False
        lblCicil1.Visible = False
        lblTglCicil1.Visible = False

        lblCicilan2.Visible = False
        lblCicil2.Visible = False
        lblTglCicil2.Visible = False

        lblCicilan3.Visible = False
        lblCicil3.Visible = False
        lblTglCicil3.Visible = False

        lblInvoice1.Visible = False
        lblTglInvoice1.Visible = False
        lblInvoiceCicil1.Visible = False

        lblInvoice2.Visible = False
        lblTglInvoice2.Visible = False
        lblInvoiceCicil3.Visible = False

        lblInvoice3.Visible = False
        lblTglInvoice3.Visible = False
        lblInvoiceCicil3.Visible = False

        ' Tampilkan sesuai tombol
        Select Case jenis
            Case "LUNAS"
                lblLunas.Visible = True
                lblBayarLunas.Visible = True
                lblTglLunas.Visible = True
            Case "CICIL1"
                lblCicilan1.Visible = True
                lblCicil1.Visible = True
                lblTglCicil1.Visible = True
            Case "CICIL2"
                lblCicilan2.Visible = True
                lblCicil2.Visible = True
                lblTglCicil2.Visible = True
            Case "CICIL3"
                lblCicilan3.Visible = True
                lblCicil3.Visible = True
                lblTglCicil3.Visible = True
            Case "INVOICE"
                pnlInvoice.Visible = True
                pnlCicil.Visible = False

                lblInvoice1.Visible = True
                lblTglInvoice1.Visible = True
                lblInvoiceCicil1.Visible = True

                lblInvoice2.Visible = True
                lblTglInvoice2.Visible = True
                lblInvoiceCicil3.Visible = True

                lblInvoice3.Visible = True
                lblTglInvoice3.Visible = True
                lblInvoiceCicil3.Visible = True
        End Select
    End Sub
    Public Sub tampilData()
        Dim sql As String = "select * from acara where id_acara = " & originalId
        myCommand.CommandText = sql
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            While myDataReader.Read()
                Dim tgl As Date = myDataReader("tanggal_pelaksanaan")
                lblNama.Text = myDataReader("nama_pemesan").ToString()
                lblNoHp1.Text = myDataReader("no_hp_pertama").ToString()
                lblNamaAcara.Text = myDataReader("nama_acara").ToString()
                lblTanggal.Text = tgl.ToString("dd-MM-yyyy")
            End While
            myDataReader.Close()
        End If
    End Sub
    Public Sub invoiceCicil(angka As Integer)
        Dim sql As String = "select * from pembayaran where id_acara = " & originalId
        myCommand.CommandText = sql
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            While myDataReader.Read()
                Dim total As Integer = myDataReader("total_pembayaran")
                Dim pinalty As Integer = myDataReader("nominal_pinalty")
                Dim sisaBayar As Integer = myDataReader("sisa_tagihan")
                If angka = 1 Then
                    Dim bayar1 As Integer = myDataReader("nominal_real_cicil1")
                    Dim tglbayar1 As Date = myDataReader("tgl_real_cicil1")
                    Dim sisaCicil1 As Integer = total - bayar1
                    lblTotalTagihan.Text = "Rp " & total.ToString("N0")
                    lblCicil1.Text = "Rp " & bayar1.ToString("N0")
                    lblTglCicil1.Text = tglbayar1.ToString("dd-MM-yyyy")
                    lblSisaTagihan.Text = "Rp " & sisaCicil1.ToString("N0")
                ElseIf angka = 2 Then
                    Dim bayar1 As Integer = myDataReader("nominal_real_cicil1")
                    Dim bayar2 As Integer = myDataReader("nominal_real_cicil2")
                    Dim tglbayar2 As Date = myDataReader("tgl_real_cicil2")
                    Dim sisaCicil2 As Integer = total - bayar1 - bayar2
                    lblTotalTagihan.Text = "Rp " & (total - bayar1).ToString("N0")
                    lblCicil2.Text = "Rp " & bayar2.ToString("N0")
                    lblTglCicil2.Text = tglbayar2.ToString("dd-MM-yyyy")
                    lblSisaTagihan.Text = "Rp " & sisaCicil2.ToString("N0")
                ElseIf angka = 3 Then
                    Dim bayar1 As Integer = myDataReader("nominal_real_cicil1")
                    Dim bayar2 As Integer = myDataReader("nominal_real_cicil2")
                    Dim bayar3 As Integer = myDataReader("nominal_real_cicil3")
                    Dim tglbayar3 As Date = myDataReader("tgl_real_cicil3")
                    Dim sisaCicil3 As Integer = total - bayar1 - bayar2 - bayar3
                    lblTotalTagihan.Text = "Rp " & (total + pinalty - bayar1 - bayar2).ToString("N0")
                    lblCicil3.Text = "Rp " & bayar3.ToString("N0")
                    lblTglCicil3.Text = tglbayar3.ToString("dd-MM-yyyy")
                    If sisaCicil3 <= 0 Then
                        lblSisaTagihan.Text = "Rp 0"
                    End If
                ElseIf angka = 4 Then
                    If myDataReader("tipe_pembayaran") = "Cicilan" Then
                        Dim bayar1 As Integer = myDataReader("nominal_real_cicil1")
                        Dim bayar2 As Integer = myDataReader("nominal_real_cicil2")
                        Dim bayar3 As Integer = myDataReader("nominal_real_cicil3")
                        Dim tglbayar1 As Date = myDataReader("tgl_real_cicil1")
                        Dim tglbayar2 As Date = myDataReader("tgl_real_cicil2")
                        Dim tglbayar3 As Date = myDataReader("tgl_real_cicil3")
                        lblInvoiceTotal1.Text = "Rp " & (total + pinalty).ToString("N0")
                        lblInvoiceCicil1.Text = "Rp " & bayar1.ToString("N0")
                        lblInvoiceCicil2.Text = "Rp " & bayar2.ToString("N0")
                        lblInvoiceCicil3.Text = "Rp " & bayar3.ToString("N0")
                        lblTglInvoice1.Text = tglbayar1.ToString("dd-MM-yyyy")
                        lblTglInvoice2.Text = tglbayar2.ToString("dd-MM-yyyy")
                        lblTglInvoice3.Text = tglbayar3.ToString("dd-MM-yyyy")
                        lblInvoiceSisa1.Text = "Rp 0"
                    Else
                        Dim tglLunas As Date = myDataReader("tgl_real_lunas")
                        lblTotalTagihan.Text = "Rp " & (total + pinalty).ToString("N0")
                        lblBayarLunas.Text = "Rp " & total.ToString("N0")
                        lblTglLunas.Text = tglLunas.ToString("dd-MM-yyyy")
                        lblSisaTagihan.Text = "Rp 0"
                    End If
                End If
            End While
            myDataReader.Close()
        End If
    End Sub

    Private Sub pnlCicil1_Paint(sender As Object, e As PaintEventArgs) Handles pnlCicil.Paint

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
    End Sub

    Private Sub lblCicil3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
