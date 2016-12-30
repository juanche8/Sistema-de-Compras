Imports DevExpress.Xpo

Public Class FrAgregarPrecio
    Public Session1 As Session = XpoHelper.GetNewSession()

    Private Sub FrAgregarPrecio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Proveedores.Session = Session1
        productos.Session = Session1
        moneda.Session = Session1
        'productos.CriteriaString = 
    End Sub
End Class