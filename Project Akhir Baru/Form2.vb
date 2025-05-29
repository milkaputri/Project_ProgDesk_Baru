Imports System.Reflection.Emit
Imports MySql.Data.MySqlClient
Imports System.Drawing


Public Class Form2
    Dim jumlahPerBulan(11) As Integer
    Dim jumlahPernikahan(11) As Integer
    Dim jumlahUmum(11) As Integer
    Private Sub btnTampilkanGrafik_Click(sender As Object, e As EventArgs) Handles btnTampilkanGrafik.Click
        AmbilDataDariMySQL()
        GambarLineChart()
    End Sub

    Private Sub AmbilDataDariMySQL()
        Array.Clear(jumlahPerBulan, 0, 12)
        Array.Clear(jumlahPernikahan, 0, 12)
        Array.Clear(jumlahUmum, 0, 12)

        Dim connStr As String = "server=localhost;userid=root;password=;database=project_akhir"
        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Dim query As String = "
                SELECT MONTH(tanggal_pelaksanaan) AS bulan, kategori_acara, COUNT(*) AS total
                FROM acara
                GROUP BY MONTH(tanggal_pelaksanaan), kategori_acara"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim bulan As Integer = reader.GetInt32("bulan") - 1
                Dim kategori As String = reader.GetString("kategori_acara").ToLower()
                Dim total As Integer = reader.GetInt32("total")

                jumlahPerBulan(bulan) += total

                If kategori.Contains("pernikahan") Then
                    jumlahPernikahan(bulan) = total
                Else
                    jumlahUmum(bulan) = total
                End If
            End While
        End Using
    End Sub

    Private Sub GambarLineChart()
        Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.Clear(Color.White)

        ' Nilai maksimum untuk skala sumbu Y
        ' Nilai maksimum untuk skala sumbu Y
        Dim maxY As Integer = 10 ' Rentang tetap 1–10
        Dim skalaY As Integer = 1 ' Langkah sumbu Y per angka

        ' Buat agar maxY bulat ke atas kelipatan skalaY
        maxY = Math.Ceiling(maxY / skalaY) * skalaY

        ' Koordinat awal
        Dim marginLeft As Integer = 50
        Dim marginBottom As Integer = 350
        Dim chartWidth As Integer = 700
        Dim chartHeight As Integer = 300
        Dim stepX As Integer = 60
        Dim pixelsPerUnitY As Double = chartHeight / maxY

        ' Sumbu Y dan garis bantu horizontal
        g.DrawLine(Pens.Black, marginLeft, marginBottom - chartHeight, marginLeft, marginBottom)
        For i As Integer = 0 To maxY Step skalaY
            Dim y As Integer = marginBottom - CInt(i * pixelsPerUnitY)
            g.DrawLine(Pens.LightGray, marginLeft, y, marginLeft + chartWidth, y)
            g.DrawString(i.ToString(), New Font("Arial", 8), Brushes.Black, 5, y - 7)
        Next

        ' Sumbu X dan label bulan
        g.DrawLine(Pens.Black, marginLeft, marginBottom, marginLeft + chartWidth, marginBottom)
        Dim bulan() As String = {"Jan", "Feb", "Mar", "Apr", "Mei", "Jun", "Jul", "Agu", "Sep", "Okt", "Nov", "Des"}
        For i As Integer = 0 To 11
            Dim x As Integer = marginLeft + i * stepX
            g.DrawString(bulan(i), New Font("Arial", 8), Brushes.Black, x - 10, marginBottom + 5)
        Next

        ' Gambar garis
        GambarGaris(g, jumlahPerBulan, Pens.Black, pixelsPerUnitY, marginLeft, marginBottom)
        GambarGaris(g, jumlahPernikahan, New Pen(Color.Blue, 2), pixelsPerUnitY, marginLeft, marginBottom, True)
        GambarGaris(g, jumlahUmum, New Pen(Color.Green, 2), pixelsPerUnitY, marginLeft, marginBottom, True)

        ' Legenda
        g.FillRectangle(Brushes.Black, 600, 20, 10, 10)
        g.DrawString("Total Acara", New Font("Arial", 8), Brushes.Black, 615, 18)

        g.FillRectangle(Brushes.Blue, 600, 40, 10, 10)
        g.DrawString("Pernikahan", New Font("Arial", 8), Brushes.Black, 615, 38)

        g.FillRectangle(Brushes.Green, 600, 60, 10, 10)
        g.DrawString("Umum", New Font("Arial", 8), Brushes.Black, 615, 58)

        PictureBox1.Image = bmp
    End Sub


    Private Sub GambarGaris(g As Graphics, data() As Integer, pena As Pen, pixelsPerUnitY As Double, marginLeft As Integer, marginBottom As Integer, Optional garisBantu As Boolean = False)
        For i As Integer = 0 To data.Length - 2
            Dim x1 As Integer = marginLeft + i * 60
            Dim y1 As Integer = marginBottom - CInt(data(i) * pixelsPerUnitY)
            Dim x2 As Integer = marginLeft + (i + 1) * 60
            Dim y2 As Integer = marginBottom - CInt(data(i + 1) * pixelsPerUnitY)
            g.DrawLine(pena, x1, y1, x2, y2)
        Next

        If garisBantu Then
            For i As Integer = 0 To data.Length - 1
                If data(i) > 0 Then
                    Dim x As Integer = marginLeft + i * 60
                    Dim y As Integer = marginBottom - CInt(data(i) * pixelsPerUnitY)
                    Dim dashPen As New Pen(Color.Gray) With {.DashStyle = Drawing2D.DashStyle.Dash}
                    g.DrawLine(dashPen, x, y, marginLeft, y)
                End If
            Next
        End If
    End Sub

    Private Sub btnBrosur1_Click_1(sender As Object, e As EventArgs) Handles btnBrosur1.Click
        Dim pdfPath As String = "C:\Users\Sharonnn\Documents\pdf\PL HNEY WEDDING_update JANUARI 2024.pdf" ' Ubah sesuai lokasi file kamu
        Dim chromePath As String = "C:\Program Files\Google\Chrome\Application\chrome.exe" ' Path default Chrome

        If System.IO.File.Exists(pdfPath) Then
            If System.IO.File.Exists(chromePath) Then
                Process.Start(chromePath, """" & pdfPath & """")
            Else
                MessageBox.Show("Google Chrome tidak ditemukan.")
            End If
        Else
            MessageBox.Show("File PDF tidak ditemukan.")
        End If
    End Sub

    Private Sub btnBrosur2_Click(sender As Object, e As EventArgs) Handles btnBrosur2.Click
        Dim pdfPath As String = "C:\Users\Sharonnn\Documents\pdf\BROSUR DEKORASI HNEY_pdf.pdf" ' Ubah sesuai lokasi file kamu
        Dim chromePath As String = "C:\Program Files\Google\Chrome\Application\chrome.exe" ' Path default Chrome

        If System.IO.File.Exists(pdfPath) Then
            If System.IO.File.Exists(chromePath) Then
                Process.Start(chromePath, """" & pdfPath & """")
            Else
                MessageBox.Show("Google Chrome tidak ditemukan.")
            End If
        Else
            MessageBox.Show("File PDF tidak ditemukan.")
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Form1.Show()
        Form1.tbNamaPengguna.Clear()
        Form1.tbKataSandi.Clear()
        Hide()
    End Sub

    Private Sub btnKegiatan_Click(sender As Object, e As EventArgs) Handles btnKegiatan.Click
        Form3.Show()
        Hide()
    End Sub

    Private Sub btnTentang_Click(sender As Object, e As EventArgs) Handles btnTentang.Click

    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class