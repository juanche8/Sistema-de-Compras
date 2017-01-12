Imports DevExpress.Xpo
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
'Imports MontagneProduccion.Montprod
Imports SistemaCompras.MontagneAdministracion

Public Class FrUsuarios

    Public Session1 As Session = XpoHelper.GetNewSession()

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        GridView1.AddNewRow()
        GridView1.ShowEditForm()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        GridView1.ShowEditForm()
    End Sub


    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim bot As Integer
        bot = MsgBox("Desea eliminar este registro", 1, "Eliminacion de Registros")
        If bot = 1 Then
            Dim fila = GridView1.GetFocusedRowCellValue("UsuarioID")
            Dim usuario = Session1.GetObjectByKey(Of Usuarios)(fila)
            usuario.Delete()
            XpCollection1.Reload()
            GridControl1.RefreshDataSource()
        End If
    End Sub

    Private Sub FrUsuarios_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub FrUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XpCollection1.Session = Session1
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.GetFocusedRowCellValue("UsuarioID") = "" Then
            MsgBox("El campo usuario no puede estar en blanco")
            Exit Sub
        End If
    End Sub

    Private Sub GridView1_ShowingPopupEditForm(sender As Object, e As DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventArgs) Handles GridView1.ShowingPopupEditForm
        e.EditForm.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        If GridView1.GetFocusedRowCellValue("UsuarioID") = "" Then
            GridView1.CancelUpdateCurrentRow()
        End If
    End Sub

    Private Sub ImprimirClick(sender As Object, e As EventArgs) Handles imprimir.Click
        Dim ps = New PrintingSystem()
        Dim compositeLink = New CompositeLink() With {
            .PrintingSystem = ps
        }
        Dim link As PrintableComponentLink = New PrintableComponentLink() With {
                    .Component = GridControl1
                }
        With compositeLink
            .Links.Add(link)
            .RtfReportHeader = "         USUARIOS DEL SISTEMA
"
            .CreateDocument()
            .ShowPreview()
        End With
    End Sub

    Private Sub LimpiafiltrosClick(sender As Object, e As EventArgs) Handles limpiafiltros.Click
        GridView1.ActiveFilter.Clear()
    End Sub

    'Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
    '    Dim path = IO.Path.Combine(Application.StartupPath, "MontagneProduccion.chm")
    '    Help.ShowHelp(ParentForm, path, HelpNavigator.TableOfContents)
    'End Sub
End Class