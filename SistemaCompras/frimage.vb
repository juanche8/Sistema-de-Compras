Imports DevExpress.Xpo

Public Class frimage
    Public Session1 As Session = XpoHelper.GetNewSession()
    Private Sub frimage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XpCollection1.Session = Session1
    End Sub
End Class