Imports DevExpress.Xpo
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors

Partial Public Class FrProductos
    Inherits XtraForm

    Public Session1 As Session = XpoHelper.GetNewSession()
    Public Sub New()
        InitializeComponent()

    End Sub
    Private Sub WindowsUIButtonPanelButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanel.ButtonClick

        If e.Button.Properties.Caption = "AGREGAR" Then
            If Sectorid = 3 Then
                Rubros.CriteriaString = "Rubro = 'FERRETERIA' or  Rubro = 'POLIRUBRO' or Rubro = 'ALIMENTACION'"

            End If
            If Sectorid = 1 Then
                Rubros.CriteriaString = "Rubro = 'SISTEMAS' or  Rubro = 'POLIRUBRO' Or Rubro = 'ALIMENTACION'"
            End If
            If Sectorid = 2 Then
                Rubros.CriteriaString = "Rubro = 'LIBRERIA' or  Rubro = 'POLIRUBRO' Or Rubro = 'ALIMENTACION'"
            End If
            If Sectorid = 7 Then
                Rubros.CriteriaString = "Rubro = 'SISTEMAS' or  Rubro = 'POLIRUBRO' Or Rubro = 'ALIMENTACION'"
            End If
            gridView.AddNewRow()
            gridView.ShowEditForm()

        End If
        If e.Button.Properties.Caption = "EDITAR" Then
            If Sectorid = 3 Then
                Rubros.CriteriaString = "Rubro = 'FERRETERIA' or  Rubro = 'POLIRUBRO' or Rubro = 'ALIMENTACION'"

            End If
            If Sectorid = 1 Then
                Rubros.CriteriaString = "Rubro = 'SISTEMAS' or  Rubro = 'POLIRUBRO' Or Rubro = 'ALIMENTACION'"
            End If
            If Sectorid = 2 Then
                Rubros.CriteriaString = "Rubro = 'LIBRERIA' or  Rubro = 'POLIRUBRO' Or Rubro = 'ALIMENTACION'"
            End If
            If Sectorid = 7 Then
                Rubros.CriteriaString = "Rubro = 'SISTEMAS' or  Rubro = 'POLIRUBRO' Or Rubro = 'ALIMENTACION'"
            End If
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
            If gridControl.MainView.ViewCaption = "GridView1" Then
                gridControl.MainView = LayoutView1
                gridControl.MainView.ViewCaption = "Layout1"
            Else
                gridControl.MainView = gridView
                gridControl.MainView.ViewCaption = "GridView1"
            End If
        End If


    End Sub

    Private Sub XtraForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Idprod = Nothing then

            Productos.Session = Session1
            Rubros.Session = Session1
            If Sectorid = 1 Then
                Productos.CriteriaString = "Rubro = 'SISTEMAS'"
            End If
            If Sectorid = 3 Then

                Productos.CriteriaString = "Rubro =  'SISTEMAS' or Rubro = 'FERRETERIA'"
                '  XpColProductos.CriteriaString = "Rubro =  'FERRETERIA'"
            End If
        else
            Productos.Session = Session1
            Rubros.Session = Session1
            Productos.CriteriaString = "Id = "& Idprod
        End if
        Idprod = Nothing
    End Sub


    Private Sub GridViewShowingPopupEditForm(sender As Object, e As DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventArgs) Handles gridView.ShowingPopupEditForm
        e.EditForm.StartPosition = FormStartPosition.CenterParent
    End Sub


    Private Sub FrProductos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.CheckState = CheckState.Checked Then
            Productos.CriteriaString = Nothing
            Productos.Reload()
        Else
            If Sectorid = 1 Then
                Productos.CriteriaString = "Rubro = 'SISTEMAS'"
            End If
            If Sectorid = 3 Then
                Productos.CriteriaString = "Rubro =  'SISTEMAS' or Rubro = 'FERRETERIA'"
                '  XpColProductos.CriteriaString = "Rubro =  'FERRETERIA'"
            End If
        End If
    End Sub
End Class
