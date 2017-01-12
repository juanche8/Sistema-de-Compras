Imports DevExpress.Xpo
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors

Partial Public Class FrStock
    Inherits XtraForm

    Public Session1 As Session = XpoHelper.GetNewSession()
    Public Sub New()
        InitializeComponent()

    End Sub
    Private Sub XtraForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XpCollection1.Session = Session1
        XpCollection3.Session = Session1
        delsector.Session = Session1
        XpCollection1.CriteriaString = "DelSector = " & Sectorid
        If Sectorid = 1 Then
            ' Productos.CriteriaString = "Rubro = 'SISTEMAS'"
        End If
        If Sectorid = 3 Then
            ' Productos.CriteriaString = "Rubro =  'SISTEMAS' or Rubro = 'FERRETERIA'"
            '  XpColProductos.CriteriaString = "Rubro =  'FERRETERIA'"
        End If
    End Sub
    Private Sub WindowsUIButtonPanelButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles windowsUIButtonPanel.ButtonClick
        'MsgBox(Sectorid)
        If e.Button.Properties.Caption = "AGREGAR" Then

            If Sectorid = 3 Then
                XpCollection3.CriteriaString = "Rubro = 'FERRETERIA' or  Rubro = 'POLIRUBRO' or Rubro = 'ALIMENTACION'"
                XpCollection1.CriteriaString = "DelSector = " & Sectorid
            End If
            If Sectorid = 1 Then
                XpCollection3.CriteriaString = "Rubro = 'SISTEMAS' or  Rubro = 'POLIRUBRO' Or Rubro = 'ALIMENTACION'"
            End If
            If Sectorid = 2 Then
                XpCollection3.CriteriaString = "Rubro = 'LIBRERIA' or  Rubro = 'POLIRUBRO' Or Rubro = 'ALIMENTACION'"
            End If
            If Sectorid = 7 Then
                XpCollection3.CriteriaString = "Rubro = 'SISTEMAS' or  Rubro = 'POLIRUBRO' Or Rubro = 'ALIMENTACION'"
            End If
            gridView.AddNewRow()
            gridView.ShowEditForm()
        End If
        If e.Button.Properties.Caption = "EDITAR" Then
            If Sectorid = 3 Then
                XpCollection3.CriteriaString = "Rubro = 'FERRETERIA' or  Rubro = 'POLIRUBRO' or Rubro = 'ALIMENTACION'"
                XpCollection1.CriteriaString = "DelSector = " & Sectorid
            End If
            If Sectorid = 1 Then
                XpCollection3.CriteriaString = "Rubro = 'SISTEMAS' or  Rubro = 'POLIRUBRO' Or Rubro = 'ALIMENTACION'"
            End If
            If Sectorid = 2 Then
                XpCollection3.CriteriaString = "Rubro = 'LIBRERIA' or  Rubro = 'POLIRUBRO' Or Rubro = 'ALIMENTACION'"
            End If
            If Sectorid = 7 Then
                XpCollection3.CriteriaString = "Rubro = 'SISTEMAS' or  Rubro = 'POLIRUBRO' Or Rubro = 'ALIMENTACION'"
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




    Private Sub GridViewShowingPopupEditForm(sender As Object, e As DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventArgs) Handles gridView.ShowingPopupEditForm
        e.EditForm.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub GridViewInitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gridView.InitNewRow
        gridView.SetRowCellValue(e.RowHandle, "DelSector", Sectorid)
    End Sub
End Class
