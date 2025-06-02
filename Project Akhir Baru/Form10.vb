Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports SysDraw = System.Drawing

Public Class Form10
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        ' Simpan ukuran asli panel
        Dim originalSize As Size = pnlCetak.Size

        ' Hitung tinggi konten sebenarnya
        Dim contentHeight As Integer = pnlCetak.DisplayRectangle.Height

        ' Nonaktifkan AutoScroll dan ubah ukuran panel agar seluruh konten terlihat
        pnlCetak.AutoScroll = False
        pnlCetak.Height = contentHeight

        ' Gambar panel ke bitmap
        ' Gambar panel ke bitmap
        Dim bmp As New Bitmap(pnlCetak.Width, contentHeight)
        pnlCetak.DrawToBitmap(bmp, New SysDraw.Rectangle(0, 0, pnlCetak.Width, contentHeight))


        ' Simpan PDF
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF Files|*.pdf"
        saveFileDialog.Title = "Simpan PDF"
        saveFileDialog.FileName = "CetakPanel.pdf"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim pdfDoc As New Document(PageSize.A4, 10, 10, 10, 10)
            Dim writer As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(saveFileDialog.FileName, FileMode.Create))
            pdfDoc.Open()

            Dim pageWidth As Integer = CInt(pdfDoc.PageSize.Width)
            Dim pageHeight As Integer = CInt(pdfDoc.PageSize.Height)

            Dim yOffset As Integer = 0
            While yOffset < bmp.Height
                Dim sliceHeight As Integer = Math.Min(pageHeight, bmp.Height - yOffset)
                Dim bmpSlice As New Bitmap(bmp.Width, sliceHeight)

                Using g As Graphics = Graphics.FromImage(bmpSlice)
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

                Using ms As New MemoryStream()
                    bmpSlice.Save(ms, Imaging.ImageFormat.Png)
                    Dim img As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(ms.ToArray())
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

    Private Sub pnlCicil1_Paint(sender As Object, e As PaintEventArgs) Handles pnlCicil.Paint

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
        Form5.Show()
        Form5.TabControl1.SelectedTab = Form5.tpPembayaran
    End Sub
End Class
