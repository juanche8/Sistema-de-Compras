Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports SistemaCompras.MontagneAdministracion

Partial Public Class FrConsumo
    Inherits XtraForm

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
            gridControl.ShowRibbonPrintPreview()
        End If
        If e.Button.Properties.Caption = "CAMBIAR VISTA" Then
            If gridControl.MainView.ViewCaption = "GridView1" Then
                gridControl.MainView = LayoutView1
                gridControl.MainView.ViewCaption = "Layout1"
            Else
                gridControl.MainView = GridView1
                gridControl.MainView.ViewCaption = "GridView1"
            End If
        End If
        If e.Button.Properties.Caption = "PASAR A STOCK" Then

            Dim z As Integer
                For z = 0 To GridView1.RowCount - 1
                GridView1.FocusedRowHandle = z
                If CInt(GridView1.GetFocusedRowCellValue(colstock)) = 0 Then
                    Dim getRecords As New XPCollection(Of Stock)(Session1, CriteriaOperator.Parse("IdProducto = " & CInt(GridView1.GetFocusedRowCellValue(colIdProducto))))
                    If getRecords.Count > 0 Then
                        With getRecords.First
                            .FechaModificacion = CDate(Now.Date.ToShortDateString)
                            .Stock1 = .Stock1 - CDec(GridView1.GetFocusedRowCellValue(colCantidad))
                            .Save()
                        End With
                    End If
                    GridView1.SetFocusedRowCellValue(colstock, 1)
                    GridView1.UpdateCurrentRow()
                End If
            Next
            End If


    End Sub

    Private Sub XtraForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XpCollection1.Session = Session1
        XpCollection2.Session = Session1
        XpCollection3.Session = Session1
    End Sub


    Private Sub GridViewShowingPopupEditForm(sender As Object, e As DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventArgs) Handles GridView1.ShowingPopupEditForm
        e.EditForm.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub windowsUIButtonPanel_Click(sender As Object, e As EventArgs) Handles windowsUIButtonPanel.Click

    End Sub
End Class
