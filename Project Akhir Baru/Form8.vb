Imports System.Windows.Forms.AxHost

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
End Class