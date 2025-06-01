Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Form10
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Try
            ' Tentukan lokasi dan nama file PDF
            Dim savePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Cetak Invoice.pdf")

            ' Membuat dokumen baru
            Dim doc As New Document(PageSize.A4, 40, 40, 40, 40)
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(savePath, FileMode.Create))
            doc.Open()

            ' Menambahkan judul
            Dim titleFont As New Font(Font.FontFamily.HELVETICA, 18, Font.Bold)
            Dim paragraph As New Paragraph("Invoice Pembayaran", titleFont)
            paragraph.Alignment = Element.ALIGN_CENTER
            doc.Add(paragraph)

            doc.Add(New Paragraph(" ")) ' Spasi

            ' Isi Contoh Invoice
            doc.Add(New Paragraph("Nama Pemesan: John Doe"))
            doc.Add(New Paragraph("Tanggal       : " & DateTime.Now.ToString("dd-MM-yyyy")))
            doc.Add(New Paragraph("Jumlah Tagihan: Rp 1.500.000"))
            doc.Add(New Paragraph("Status        : Lunas"))

            doc.Close()
            writer.Close()

            MessageBox.Show("Invoice berhasil dicetak ke Desktop sebagai 'Cetak Invoice.pdf'", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Gagal mencetak invoice: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
