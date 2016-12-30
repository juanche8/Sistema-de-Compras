Public Class RpListaAprobar
    Private Sub XrLabel3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel3.BeforePrint
        XrLabel3.Text = Responsable
    End Sub
End Class