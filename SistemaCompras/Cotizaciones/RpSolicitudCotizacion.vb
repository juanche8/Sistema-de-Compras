Public Class RpSolicitudCotizacion
    Private Sub ReportHeaderBand1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles ReportHeaderBand1.BeforePrint
        If Empresa = "MONTAGNE"
            XrPictureBox1.Visible = true
        End If
    End Sub
End Class