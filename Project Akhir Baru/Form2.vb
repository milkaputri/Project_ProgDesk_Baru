Imports System.Reflection.Emit

Public Class Form2
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
End Class