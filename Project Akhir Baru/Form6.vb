Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize form with pnlDetailJasmine hidden by default
        pnlDetailJasmine.Visible = False
        pnlDetailOrchid.Visible = False
    End Sub

    Private Sub pnlDetailJasmine_Paint(sender As Object, e As PaintEventArgs) Handles pnlDetailJasmine.Paint
        ' Paint code if needed
    End Sub

    Private Sub pnlDetailOrchid_Paint(sender As Object, e As PaintEventArgs) Handles pnlDetailOrchid.Paint
        ' Paint code if needed
    End Sub


    Private Sub btnHome_Click_1(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim form5 As New Form5()

        ' Langsung pilih tab berdasarkan name-nya
        form5.TabControl1.SelectTab("tpPaket")

        'form5.Show()
        Me.Hide()
    End Sub
End Class