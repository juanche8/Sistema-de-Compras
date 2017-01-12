Imports DevExpress.Xpo
Imports DevExpress.XtraEditors

Partial Public Class FrProveedores
    Inherits DevExpress.XtraEditors.XtraForm

    Public Session1 As Session = XpoHelper.GetNewSession()
    Public Sub New()
        InitializeComponent()

    End Sub
    Private Sub WindowsUIButtonPanelButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanel.ButtonClick

        If e.Button.Properties.Caption = "AGREGAR" Then
            GridView1.AddNewRow()
            GridView1.ShowEditForm()
        End If
        If e.Button.Properties.Caption = "EDITAR" Then
            GridView1.ShowEditForm()
        End If
        If e.Button.Properties.Caption = "ELIMINAR" Then
            GridView1.DeleteRow(GridView1.FocusedRowHandle)
        End If
        If e.Button.Properties.Caption = "RECARGAR" Then
            GridView1.RefreshData()
        End If
        If e.Button.Properties.Caption = "CANCELAR" Then
            GridView1.CancelUpdateCurrentRow()
        End If
        If e.Button.Properties.Caption = "QUITAR FILTROS" Then
            GridView1.ActiveFilter.Clear()
        End If
        If e.Button.Properties.Caption = "IMPRIMIR" Then
            GridControl1.ShowRibbonPrintPreview()
        End If
        'If e.Button.Properties.Caption = "CONTACTOS" Then
        '    FrContactos.Show()
        'End If
        If e.Button.Properties.Caption = "CAMBIAR VISTA" Then
            If GridControl1.MainView.ViewCaption = "GridView1" Then
                GridControl1.MainView = LayoutView1
                GridControl1.MainView.ViewCaption = "Layout1"
            Else
                GridControl1.MainView = GridView1
                GridControl1.MainView.ViewCaption = "GridView1"
            End If
        End If
        If e.Button.Properties.Caption = "LISTAS DE PRECIOS" Then
            FrListasPrecios.Show()
        End If

    End Sub

    Private Sub XtraForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Proveedores.Session = Session1
        Paises.Session = Session1
        Rubros.Session = Session1
    End Sub


    'Private Sub GridViewShowingPopupEditForm(sender As Object, e As DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventArgs) Handles gridView.ShowingPopupEditForm
    '    e.EditForm.StartPosition = FormStartPosition.CenterParent
    'End Sub

    Private Sub windowsUIButtonPanel_Click(sender As Object, e As EventArgs) Handles windowsUIButtonPanel.Click

    End Sub
End Class
