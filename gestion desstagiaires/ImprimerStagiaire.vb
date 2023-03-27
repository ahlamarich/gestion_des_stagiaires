Imports CrystalDecisions.CrystalReports.Engine

Public Class ImprimerStagiaire
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim crystal As New CrystalReportStagiaire()

        CrystalReportViewer1.ReportSource = crystal
        CrystalReportViewer1.Refresh()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If WindowState = FormWindowState.Normal Then

            WindowState = FormWindowState.Maximized
        Else

            WindowState = FormWindowState.Normal



        End If
    End Sub


End Class