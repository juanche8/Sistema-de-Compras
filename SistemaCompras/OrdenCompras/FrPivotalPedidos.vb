Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Public Class FrPivotPedidos

    Public Session1 As Session = XpoHelper.GetNewSession()
    Private Sub XtraForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resultSet As SelectedData = Session1.ExecuteQuery("SELECT * from VistaDatosPedidos")
        XpDataView1.LoadData(resultSet)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        PivotGridControl1.ShowPrintPreview()
    End Sub
End Class