Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports SistemaCompras.MontagneAdministracion

Public Class FrMasterDetailRecepciones


    Public Session1 As Session = XpoHelper.GetNewSession()
    Public Idpedido As Integer
    Public Oc As Integer
    Public Remi As Integer
    Private Sub FrMasterDetailRecepciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemitoRecepcion.Session = Session1
        DetalleRecepcion.Session = Session1
        Proveedores.Session = Session1
        Sectores.Session = Session1
        Productos.Session = Session1
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim ps = New PrintingSystem()
        Dim compositeLink = New CompositeLink() With {
            .PrintingSystem = ps
        }
        Dim link As PrintableComponentLink = New PrintableComponentLink() With {
                    .Component = GridControl1
                }
        With compositeLink
            .Links.Add(link)
            .RtfReportHeader = "         RECEPCION DE PRODUCTOS
"
            .CreateDocument()
            .ShowPreview()
        End With
    End Sub



    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        Oc = CInt(GridView3.GetFocusedRowCellValue(colOC))
        Remi = CInt(GridView3.GetFocusedRowCellValue(colRemitoNro))
        If Remi > 0 Then
            DetalleRecepcion.CriteriaString = "Idremito = " & Remi
        End If
        Oc = CInt(GridView3.GetFocusedRowCellValue(colOC))
        Remi = CInt(GridView3.GetFocusedRowCellValue(colRemitoNro))
    End Sub

    Private Sub GridView3_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView3.RowUpdated
        Try
            If GridView3.IsMasterRowEmpty(e.RowHandle) Or e.RowHandle < 0 Then
                Dim querylinqrecep As New XPQuery(Of OrdenCompraDetalles)(Session1)
                Dim idrecepacopiar = (From o In querylinqrecep Where o.IdOC.ToString = Oc.ToString Select o).ToList
                For z = 0 To idrecepacopiar.Count - 1
                    Dim rp = New RecepcionProductos(Session1)
                    With rp
                        .Idremito = Remi
                        .Cantidad = CDec(idrecepacopiar(z).Cantidad.ToString)
                        .IdProducto = Convert.ToInt32(idrecepacopiar(z).IdProducto.ToString)
                        .Save()
                    End With
                Next
            End If
        Catch ex As Exception
            MsgBox("Hubo problemas al generar el pedido, esto puede ocurrir porque existen productos duplicados o ya existe ese pedido asignado al proveedor")
        End Try
        Oc = 0
        Remi = 0
        RemitoRecepcion.Reload()
        DetalleRecepcion.Reload()
        GridView3.RefreshData()
        GridView12.RefreshData()
    End Sub

    Private Sub GridView3_ValidateRow_1(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView3.ValidateRow
        Try
            Oc = CInt(GridView3.GetFocusedRowCellValue(colOC))
            Remi = CInt(GridView3.GetFocusedRowCellValue(colRemitoNro))
            If IsNothing(GridView3.GetFocusedRowCellValue(colRemitoNro)) Then
                Session1.ExecuteNonQuery("Delete RemitoRecepcion where RemitoNro = " & Remi)
                RemitoRecepcion.Reload()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GridView3.AddNewRow()
        GridView3.ShowEditForm()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If CInt(GridView3.GetFocusedRowCellValue(colStockeado)) = 0 Then
            Dim z As Integer
            For z = 0 To GridView12.RowCount - 1
                GridView12.FocusedRowHandle = z
                Dim getRecords As New XPCollection(Of Stock)(Session1, CriteriaOperator.Parse("IdProducto = " & CInt(GridView12.GetFocusedRowCellValue(colIdProducto1))))
                If getRecords.Count > 0 Then
                    With getRecords.First
                        .FechaModificacion = CDate(Now.Date.ToShortDateString)
                        .Stock1 = .Stock1 + CDec(GridView12.GetFocusedRowCellValue(colCantidad))
                        .Save()
                    End With
                End If
            Next
            GridView3.SetFocusedRowCellValue(colStockeado, 1)
            GridView3.UpdateCurrentRow()
        End If
    End Sub
End Class