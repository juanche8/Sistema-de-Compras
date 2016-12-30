Imports DevExpress.Xpo
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors

Partial Public Class FrSimple
    Inherits XtraForm

    Public Session1 As Session = XpoHelper.GetNewSession()
    Public Sub New()
        InitializeComponent()

    End Sub
    Private Sub WindowsUIButtonPanelButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanel.ButtonClick

        If e.Button.Properties.Caption = "AGREGAR" Then
            gridView.AddNewRow()
            gridView.ShowEditForm()
        End If
        If e.Button.Properties.Caption = "EDITAR" Then
            gridView.ShowEditForm()
        End If
        If e.Button.Properties.Caption = "ELIMINAR" Then
            gridView.DeleteRow(gridView.FocusedRowHandle)
        End If
        If e.Button.Properties.Caption = "RECARGAR" Then
            gridView.RefreshData()
        End If
        If e.Button.Properties.Caption = "CANCELAR" Then
            gridView.CancelUpdateCurrentRow()
        End If
        If e.Button.Properties.Caption = "QUITAR FILTROS" Then
            gridView.ActiveFilter.Clear()
        End If
        If e.Button.Properties.Caption = "IMPRIMIR" Then
            gridControl.ShowRibbonPrintPreview()
        End If
        If e.Button.Properties.Caption = "CAMBIAR VISTA" Then
            If gridControl.MainView.ViewCaption = "Gridview1" Then
                gridControl.MainView = LayoutView1
                gridControl.MainView.ViewCaption = "Layout1"
            Else
                gridControl.MainView = gridView
                gridControl.MainView.ViewCaption = "GridView1"
            End If
        End If


    End Sub

    Private Sub XtraForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XpCollection1.Session = Session1
    End Sub


    Private Sub GridViewShowingPopupEditForm(sender As Object, e As DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventArgs) Handles gridView.ShowingPopupEditForm
        e.EditForm.StartPosition = FormStartPosition.CenterParent
    End Sub
End Class
