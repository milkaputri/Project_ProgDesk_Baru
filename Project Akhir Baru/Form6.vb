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

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form5.Show()
        Hide()
    End Sub
End Class