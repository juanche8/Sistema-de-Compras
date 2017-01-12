Imports DevExpress.Xpo
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports SistemaCompras.MontagneAdministracion

Public Class FrRoles

    Public Session1 As Session = XpoHelper.GetNewSession()
    Public Uow As UnitOfWork = XpoHelper.GetNewUnitOfWork()

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        GridView1.AddNewRow()
        GridView1.ShowEditForm()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        GridView1.ShowEditForm()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        FlyoutPanel1.ShowBeakForm()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Rol = GridView1.GetFocusedRowCellValue(colId)
        FrPermisos.Show()
    End Sub

    Private Sub FrRoles_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub FrRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XpCollection1.Session = Session1
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.GetFocusedRowCellValue("Rol") = "" Then
            MsgBox("El campo usuario no puede estar en blanco")
            Exit Sub
        End If
    End Sub

    Private Sub GridView1_ShowingPopupEditForm(sender As Object, e As DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventArgs) Handles GridView1.ShowingPopupEditForm
        e.EditForm.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        If GridView1.GetFocusedRowCellValue("Rol") = "" Then
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
            .RtfReportHeader = "         ROLES DE USUARIOS
"
            .CreateDocument()
            .ShowPreview()
        End With
    End Sub



    Private Sub LimpiafiltrosClick(sender As Object, e As EventArgs) Handles limpiafiltros.Click
        GridView1.ActiveFilter.Clear()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim querylinq As New XPQuery(Of Permisos)(Session1)
        Dim queryrol As New XPQuery(Of Roles)(Session1)

        Try

            Dim existerol = (From o In queryrol Where o.Rol = nuevorol.Text Select o.Id).ToList
            If existerol.Count > 0 Then
                MsgBox("Este rol ya existe")
                Exit Sub
            End If


            Using Uow

                Dim rol = New Roles(Session1)
                With rol
                    .Rol = nuevorol.Text
                    .Descripcion = descri.Text
                    .Save()
                End With

                Dim idrol = (From o In queryrol Where o.Rol = nuevorol.Text Select o.Id).ToArray
                Dim idrolacopiar = (From o In queryrol Where o.Rol = roldup.Text Select o.Id).ToArray


                Dim valu = Convert.ToInt32(idrolacopiar(0).ToString)
                Dim roli = Convert.ToInt32(idrol(0).ToString)
                Dim list = (From o In querylinq Where o.IdRol = valu Select o).ToArray

                For z = 0 To list.Count - 1
                    Dim permiso = New Permisos(Session1)
                    With permiso
                        .IdRol = roli
                        .Permiso = list(z).Permiso
                        .IdObjeto = list(z).IdObjeto
                        .Save()
                    End With

                Next
                Uow.CommitChanges()
                MsgBox("Perfil copiado correctamente")
            End Using
        Catch ex As Exception
            MsgBox("no se pudo copiar el perfil")
            Uow.RollbackTransaction()
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim path = IO.Path.Combine(Application.StartupPath, "MontagneProduccion.chm")
        Help.ShowHelp(ParentForm, path, HelpNavigator.TableOfContents)
    End Sub
End Class