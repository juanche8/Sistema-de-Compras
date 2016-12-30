Imports DevExpress.Xpo
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports SistemaCompras.MontagneAdministracion

Public Class FrUsuarioPorRol

    Public Session1 As Session = XpoHelper.GetNewSession()

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        GridView1.AddNewRow()
        GridView1.ShowEditForm()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        GridView1.ShowEditForm()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim bot As Integer
        bot = MsgBox("Desea eliminar este registro", 1, "Eliminacion de Registros")
        If bot = 1 Then
            Dim fila = GridView1.GetFocusedRowCellValue("Id")
            Dim usuariorol = XpoHelper.GetNewSession().GetObjectByKey(Of UsuarioRol)(fila)
            usuariorol.Delete()
            XpCollection1.Reload()
            GridControl1.RefreshDataSource()
        End If
    End Sub

    Private Sub FrUsuarioPorRol_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub FrUsuarioPorRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XpCollection1.Session = Session1
        XpCollection2.Session = Session1
        XpCollection3.Session = Session1
    End Sub

    Private Sub GridView1_ShowingPopupEditForm(sender As Object, e As DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventArgs) Handles GridView1.ShowingPopupEditForm
        e.EditForm.StartPosition = FormStartPosition.CenterParent
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
            .RtfReportHeader = "         ROLES Y USUARIOS
"
            .CreateDocument()
            .ShowPreview()
        End With
    End Sub

    Private Sub LimpiafiltrosClick(sender As Object, e As EventArgs) Handles limpiafiltros.Click
        GridView1.ActiveFilter.Clear()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim path = IO.Path.Combine(Application.StartupPath, "MontagneProduccion.chm")
        Help.ShowHelp(ParentForm, path, HelpNavigator.TableOfContents)
    End Sub
End Class