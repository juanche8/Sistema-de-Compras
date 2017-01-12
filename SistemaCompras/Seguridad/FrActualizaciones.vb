Imports DevExpress.Xpo

Public Class FrActualizaciones
    Public Session1 As Session = XpoHelper.GetNewSession()
    
    Private Sub FrActualizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        equipos.session = session1
    End Sub
End Class