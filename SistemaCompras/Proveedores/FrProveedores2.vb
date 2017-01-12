Imports DevExpress.Xpo

Public Class FrProveedores2
    Public Session1 As Session = XpoHelper.GetNewSession()
    Private Sub FrProveedores2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Proveedores.Session = Session1
        Paises.Session = Session1
        Rubros.Session = Session1
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        GridView1.AddNewRow()
        GridView1.ShowEditForm()
    End Sub
    Private Sub GridViewShowingPopupEditForm(sender As Object, e As DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventArgs) Handles GridView1.ShowingPopupEditForm
        e.EditForm.StartPosition = FormStartPosition.CenterParent
    End Sub
    Private Sub SimpleButton16_Click(sender As Object, e As EventArgs)
        GridView1.ShowEditForm()
    End Sub

    Private Sub SimpleButton15_Click(sender As Object, e As EventArgs)
        GridView1.RefreshData()
    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs)
        GridView1.ActiveFilter.Clear()
    End Sub

    Private Sub SimpleButton13_Click(sender As Object, e As EventArgs)
        If GridControl1.MainView.ViewCaption = "GridView1" Then

            GridControl1.MainView.ViewCaption = "Layout1"
        Else
            GridControl1.MainView = GridView1
            GridControl1.MainView.ViewCaption = "GridView1"
        End If
    End Sub

    Private Sub SimpleButton14_Click(sender As Object, e As EventArgs)
        GridControl1.ShowRibbonPrintPreview()
    End Sub

    Private Sub SimpleButton12_Click(sender As Object, e As EventArgs)
        FrContactos.Show()
    End Sub

    Private Sub SimpleButton11_Click(sender As Object, e As EventArgs)
        FrListasPrecios.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        GridView1.ShowEditForm()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        FrListasPrecios.Show()
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        FrContactos.Show()
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        GridControl1.ShowRibbonPrintPreview()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        GridView1.AddNewRow()
        GridView1.ShowEditForm()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        GridView1.ActiveFilter.Clear()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        GridView1.RefreshData()
    End Sub
End Class





























' juan jose diaz yoris