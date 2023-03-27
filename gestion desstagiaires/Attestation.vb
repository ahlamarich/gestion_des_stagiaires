Public Class Attestation
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim crystal As New CrystalReport2()
        crystal.SetParameterValue("Nom_stg", TextBox1.Text)
        CrystalReportViewer1.ReportSource = crystal
        CrystalReportViewer1.Refresh()
    End Sub
End Class