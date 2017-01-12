Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports MailBee.SmtpMail
Imports SistemaCompras.MontagneAdministracion

Public Class FrMasterDetailOrdCompras

    Public Session1 As Session = XpoHelper.GetNewSession()
    Public Idpedido As Integer
    Dim email As String
    Private Sub FrMasterDetailOrdCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OrdCompras.Session = Session1
        'DetalleOrdCompras.Session = Session1
        'Proveedores.Session = Session1
        'Monedas.Session = Session1
        'Productos.Session = Session1
        'Pedidos.Session = Session1
    End Sub
    ' 判断该控件是否有下属控件
    'Private Sub GridControl1_EmbeddedNavigator_ButtonClick(sender As Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles GridControl1.EmbeddedNavigator.ButtonClick
    '    If Not GridControl1.FocusedView.IsDetailView Then
    '        If (e.Button.ButtonType = NavigatorButtonType.Append) Then
    '            GridView1.AddNewRow()
    '            GridView1.ShowEditForm()
    '        End If
    '        If (e.Button.ButtonType = NavigatorButtonType.Edit) Then
    '            GridView1.ShowEditForm()
    '        End If
    '    End If
    'End Sub

    ' Private Sub GridView1_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs)
    '  If IsNothing(GridView1.GetFocusedRowCellValue(colIdProveedor)) Then
    ' Session1.ExecuteNonQuery("Delete OrdenesCompra where IdOrdenCompra = " & CInt(GridView1.GetFocusedRowCellValue(colIdOrdenCompra)))
    'OrdCompras.Reload()
    '    End If
    'End Sub

    'Private Sub LookUpEdit1_EditValueChanged(sender As Object, e As EventArgs)
    '    Try
    '        Dim z As Integer
    '  Dim idprovee = Session1.ExecuteQuery("Select IdProveedor from PedidosDetalles where IdPedido = " & LookUpEdit1.EditValue & " group by IdProveedor")
    '            For z = 0 To idprovee.ResultSet.First.Rows.Count - 1

    '                Dim cotiza = New OrdenesCompra(Session1)
    '                Dim provee = CInt(idprovee.ResultSet.First.Rows(z).Values(0))
    '                With cotiza
    '                    .Idproveedor = provee
    '                    .FechaCompra = CDate(Now.ToShortDateString)
    '                    .Moneda = 1
    '                    .Finalizada = 0
    '                    .Save()
    '                End With
    '                Dim idpedacopiar = Session1.ExecuteQuery("Select Cantidad, IdProducto, IdPedido from PedidosDetalles where IdProveedor = " & provee & " and IdPedido = " & LookUpEdit1.EditValue)
    '                Dim idoc As Integer = Session1.ExecuteScalar("Select max(IdOrdenCompra) from OrdenesCompra where IdProveedor = " & provee)

    '                For z1 = 0 To idpedacopiar.ResultSet.First.Rows.Count - 1
    '                    Dim oc = New OrdenCompraDetalles(Session1)
    '                    With oc
    '                        .Cantidad = CDec(idpedacopiar.ResultSet.First.Rows(z1).Values(0))
    '                        .IdProducto = CInt(idpedacopiar.ResultSet.First.Rows(z1).Values(1))
    '                        .IdPedido = CInt(idpedacopiar.ResultSet.First.Rows(z1).Values(2))
    '                        .Save()
    '                    End With
    '                Next
    '                Dim res = Session1.ExecuteNonQuery("update ordencompradetalles  Set IdOC = " & idoc & " where IdOC Is null")
    '            Next

    '            OrdCompras.Reload()
    '            GridView1.RefreshData()
    '            Dim res1 = Session1.ExecuteNonQuery("update Pedidos Set Estado = 5 where IdPedido = " & LookUpEdit1.EditValue)
    '            'Pedidos.Reload()
    '        Catch ex As Exception
    '            MsgBox("Hubo problemas al generar el pedido, esto puede ocurrir porque existen productos duplicados o ya existe ese pedido asignado al proveedor")
    '        End Try

    '    End Sub

    '    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
    '        'Dim asunto As String = CType("Solicitud de Compra Nro. " = GridView1.GetFocusedRowCellValue(colIdOrdenCompra).ToString, String)
    '        'Dim mailer As Smtp = New Smtp()
    '        'mailer.SmtpServers.Add("mail.domain.com", "username", "password").Port = 465
    '        'mailer.From.AsString = "xxxx@montagne.com>"
    '        'mailer.To.AsString = email
    '        'mailer.Subject = asunto
    '        'mailer.BodyHtmlText = "<html><body>Solicitamos el envio de los productos</body></html>"
    '        'mailer.AddAttachment("C: \Temp\details.doc")
    '        'mailer.Send()

    '        Dim ps = New PrintingSystem()
    '        Dim compositeLink = New CompositeLink() With {
    '            .PrintingSystem = ps
    '        }
    '        Dim link As PrintableComponentLink = New PrintableComponentLink() With {
    '                    .Component = GridControl1
    '                }
    '        With compositeLink
    '            .Links.Add(link)
    '            .RtfReportHeader = "         SOLICITUD DE COMPRA
    '"
    '            .CreateDocument()
    '            .ShowPreview()
    '        End With

    '    End Sub



End Class