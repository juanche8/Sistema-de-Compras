Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraReports.UI

Public Class FrODC
    Public Session1 As Session = XpoHelper.GetNewSession()
    Dim report As New RpODC()
    Dim tool As ReportPrintTool = New ReportPrintTool(report)
    Dim resultSet As SelectedData = Session1.ExecuteQuery("SELECT * from VistaODC where AproboMartin = 0")
    Dim resultSet3 As SelectedData = Session1.ExecuteQuery("SELECT * from VistaODC where AproboMartin = 1 and ODCEnviada = 0")
    Dim resultSet4 As SelectedData = Session1.ExecuteQuery("SELECT * from VistaODC where AproboMartin = 2")

    Private Sub FrODC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView1.GroupPanelText = "Pendiente de Aprobacion"
        GridView3.GroupPanelText = "Aprobadas"
        GridView4.GroupPanelText = "Rechazadas"
        XpDataView2.LoadData(resultSet)
        XpDataView3.LoadData(resultSet3)
        XpDataView4.LoadData(resultSet4)
        Pedidos.Session = Session1
        PedidosDetalles.Session = Session1
        LabelControl5.Visible = True
        cboEmpresas.Visible = True
        LabelControl6.Visible = True
        cbopago.Visible = True
        SimpleButton1.Visible = true

        'XpDataView2.FilterString = "ODCEnviada = 0"

        'GridView2.Columns("colTotalProducto1").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "colTotalProducto1", "<Color=red>TOTAL</color>={0}")

        'If Sectorid = 14 Then
        '    XpDataView2.LoadData(resultSet2)
        '    verorden.Visible = true
        '    ' XpDataView2.FilterString = "AproboMartin = 0"
        '    XpDataView2.LoadData(resultSet2)
        'End If
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        'GridControl2.DataSource = Nothing
        GridControl2.DataSource = XpDataView2
        ' GridControl2.MainView.PopulateColumns()
        cboEmpresas.Enabled = false
        try
            If GridView1.RowCount = 0 Then
            Else

                Dim direccion = Session1.ExecuteScalar("Select DireccionDeEnvio from Pedidos where IdPedido = " & GridView1.GetFocusedRowCellValue(colIdPedido))
                Dim direccionfisica = Session1.ExecuteScalar("Select Direccion from DireccionesEntrega where Id = " & direccion)
                If direccion <> 0 then
                    dirlabel.Text = "Direccion de entrega: " & direccionfisica
                Else
                    dirlabel.Text = ""
                End if
            End if
        Catch ex As Exception
        End try
        lblCUIT.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colCUIT_CUIL)
        lbldomicilio.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colDomicilio)
        lblemail.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colEmail)
        lbllocalidad.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colLocalidad)
        
        'XpDataView1 = XpDataView2
        GridControl2.Enabled = false
        SimpleButton1.Enabled = false
        ' MsgBox(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdPedido1))
        ' GridView2.FindFilterText = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdPedido1).ToString
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ' GridView1.SetFocusedRowCellValue(colODCEnviada, 1)
        ' Session1.ExecuteNonQuery("Update Pedidos SET Estado = 5 where IdPedido = " & CInt(GridView1.GetFocusedRowCellValue(colIdPedido)))
        ' PedidosDetalles.CriteriaString = "ODCEnviada <> 1"
        ' PedidosDetalles.Reload()
        If lblemail.Text = "" Then
            MsgBox("El proveedor no tiene email asignado.", vbCritical)
            Return

        Else
            If MsgBox("Se procedera a enviar la Orden de compra al proveedor " & GridView3.GetFocusedRowCellValue(colRazonSocial3) & " desde la empresa " & cboEmpresas.Text & ". Desea continuar?", vbYesNo) = vbYes Then
                Empresa = cboEmpresas.text.ToUpper
                Formadepago = cbopago.text
                Dim firma As string
                If Empresa.Contains("MONTAGNE") then firma = "MONTAGNE OUTDOORS SA" & vbCrLf & "DPTO DE COMPRAS" & vbCrLf & "4773-0091 INT 1650" else firma = "DPTO DE COMPRAS " + Empresa                'aca se deben agregar el resto de informacion de las otras empresas
                report.FilterString = "IdPedido =" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3) & "and IdProveedor= " & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdProveedor3)
                report.CreateDocument()
                report.ExportTopdf("\\CENTRALMONTAGNE\softMtg\compras\Reportes\" + Empresa + " - " + GridView3.GetFocusedRowCellValue(colRazonSocial3) + " - " + GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3).ToString + ".pdf")
                tool.Report.ShowPreviewDialog()
                ' HASTA ACA COMENTAR PARA VOLVER A CREAR LOS REPORTES
                'Try    ' Aplica la condicion de si existe nombreFantasia de ese proveedor en la bd, si no, toma por defecto la RazonSocial
                '    ' si consigue nombreFantasia, el codigo salta a Else y continua asignando el mail con respecto a la razonSocial y adjunta la ODC 
                '    ' previamente almacenada en el server \\CentralMontagne\softMtg\compras\Reportes\xxx.pdf
                '    Dim nombrefantasia As String = Session1.ExecuteScalar("Select NombreFantasia from Proveedores where RazonSocial = '" & GridView3.GetRowCellDisplayText(GridView3.FocusedRowHandle, colRazonSocial3) & "'")
                '    If nombrefantasia Is Nothing Then
                '        Dim email1 As String = Session1.ExecuteScalar("Select Email  from Proveedores where Email is not null AND Email <> ''  and RazonSocial like '" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colRazonSocial3) & "'").ToString
                '        Sendmail("logger", "Orden de Compra - " & Empresa & " - " & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3), email1 & ", mtgcompras@montagne.com.ar, mtgcompras2@montagne.com.ar", "\\CENTRALMONTAGNE\softMtg\compras\Reportes\" + Empresa + " - " + GridView3.GetFocusedRowCellValue(colRazonSocial3) + " - " + GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3).ToString + ".pdf", "Buenas tardes, estimado " & GridView3.GetRowCellDisplayText(GridView3.FocusedRowHandle, colRazonSocial3) & vbCrLf & vbCrLf & "Enviamos adjunto a continuación la orden de compra nro" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3) & "en conformidad con el presupuesto ofrecido. En la misma se encuentran descriptas las condiciones de la operación, por lo que le solicitamos que nos comunique recepción y conformidad de las mismas." & vbCrLf & vbCrLf & "Quedo al aguardo fecha de entrega y queda a la disposición." & vbCrLf & "Saludos cordiales." & vbCrLf & vbCrLf & vbCrLf & firma)
                '    Else
                '        Dim email1 As String = Session1.ExecuteScalar("Select Email  from Proveedores where Email is not null AND Email <> ''  and RazonSocial like '" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colRazonSocial3) & "'").ToString
                '        Sendmail("logger", "Orden de Compra - " & Empresa & " - " & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3), email1 & ", mtgcompras@montagne.com.ar, mtgcompras2@montagne.com.ar", "\\CENTRALMONTAGNE\softMtg\compras\Reportes\" + Empresa + " - " + GridView3.GetFocusedRowCellValue(colRazonSocial3) + " - " + GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3).ToString + ".pdf", "Buenas tardes, estimado " + nombrefantasia & vbCrLf & vbCrLf & "Enviamos adjunto a continuación la orden de compra nro" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3) & "en conformidad con el presupuesto ofrecido. En la misma se encuentran descriptas las condiciones de la operación, por lo que le solicitamos que nos comunique recepción y conformidad de las mismas." & vbCrLf & vbCrLf & "Quedo al aguardo fecha de entrega y queda a la disposición." & vbCrLf & "Saludos cordiales." & vbCrLf & vbCrLf & vbCrLf & firma)
                '    End if
                '    MsgBox("El correo con la ORDEN DE COMPRA ha sido enviada al proveedor: " + GridView3.GetRowCellDisplayText(GridView3.FocusedRowHandle, colRazonSocial3) + ".", vbInformation)
                '    If CheckEdit1.CheckState = 1 Then
                '        Sendmail("logger", "Informacion de Retiro", "mtgexpedicion@montagne.com.ar, deboramedina@montagne.com.ar, tatyanamatiushenko@montagne.com.ar", "\\CENTRALMONTAGNE\softMtg\compras\Reportes\" + Empresa + " - " + GridView3.GetFocusedRowCellValue(colRazonSocial3) + " - " + GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3).ToString + ".pdf", TextEdit1.Text & vbCrLf & "Con fecha de retiro: " & fechaentrega.text)
                '        MsgBox("Se ha enviado el correo con la informacion del retiro", vbinformation)
                '    End If
                '    Session1.ExecuteNonQuery("Update PedidosDetalles SET ODCEnviada = 1 where IdPedido =" & CInt(GridView3.GetFocusedRowCellValue(colIdPedido2)) & "and IdProveedor = " & CInt(GridView3.GetFocusedRowCellValue(colIdProveedor3)))
                '    Session1.ExecuteNonQuery("Update Pedidos SET Estado = 5 where IdPedido =" & CInt(GridView2.GetFocusedRowCellValue(colIdPedido)))  'pendiente

                '    Dim resultSet3 As SelectedData = Session1.ExecuteQuery("SELECT * from VistaODC where AproboMartin = 1 and ODCEnviada = 0")
                '    'XpDataView2.LoadData(resultSet1)                      "SELECT * from VistaODC where AproboMartin = 1 and ODCEnviada = 0"
                '    ' XpDataView3.FilterString = "AproboMartin = 1 and ODCEnviada = 0 "
                '    XpDataView3.LoadData(resultSet3)
                '    ' Pedidos.Reload()
                '    ' Back = 1                                               ' estos dos ultimos son para cerrar y reabrir el formulario para actualizarlo
                '    '  Close()
                '    ' report.Dispose
                'catch ex As Exception
                'End try
                'HASTA ACA COMENTAR
            Else
                return
            End If
        End if
        lblemail.Text = ""
        lbllocalidad.Text = ""
        lbldomicilio.Text = ""
        lblCUIT.Text = ""
        cbopago.Text = ""
        cboEmpresas.Text = ""
        cbopago.Enabled = False
        cboEmpresas.Enabled = false
        SimpleButton1.Enabled = false
        CheckEdit1.CheckState = 0
        ''
    'sin codigo de prueba hasta aca <-

        ''
    End Sub

    Private Sub cboEmpresas_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboEmpresas.SelectedIndexChanged
        If cboEmpresas.Text IsNot Nothing Then
            cbopago.Enabled = true
        Else
            cbopago.Enabled = false
        End If
    End Sub

    Private Sub cbopago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopago.SelectedIndexChanged
        If cbopago.Text IsNot Nothing Then
            SimpleButton1.Enabled = True
        Else
            SimpleButton1.Enabled = false
        End If
    End Sub


    Private Sub FrODC_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Sectorid = 14 then
            Me.Dispose()
            Application.Exit()
        End If
    End Sub

    Private Sub GridControl3_Click_1(sender As Object, e As EventArgs) Handles GridControl3.Click
        'GridControl2.DataSource = Nothing
        GridControl2.DataSource = XpDataView3
        'GridControl2.MainView.PopulateColumns()
        ' gridcontrol2.mainview.populatecolumns(3)
        '
        try
            If GridView3.RowCount = 0 Then
            Else

                Dim direccion = Session1.ExecuteScalar("Select DireccionDeEnvio from Pedidos where IdPedido = " & GridView3.GetFocusedRowCellValue(colIdPedido2))
                Dim direccionfisica = Session1.ExecuteScalar("Select Direccion from DireccionesEntrega where Id = " & direccion)
                If direccion <> 0 then
                    dirlabel.Text = "Direccion de entrega: " & direccionfisica
                Else
                    dirlabel.Text = ""
                End if
            End if
        Catch ex As Exception
        End try
        lblCUIT.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colCUIT_CUIL)
        lbldomicilio.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colDomicilio)
        lblemail.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colEmail)
        lbllocalidad.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colLocalidad)
        ' XpDataView3 = XpDataView2
        If lblemail.Text <> "" Then
            cboEmpresas.Enabled = true
        End If
        GridControl2.Enabled = true
        If gridview3.RowCount = 0 Then
        else
            Dim consulta = GridView3.GetFocusedRowCellValue(colIdPedido2)
            XpDataView5.FilterString = "IdPedido = " & consulta
        End If
        ' MsgBox(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdPedido1))
        ' GridView2.FindFilterText = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdPedido1).ToString
    End Sub

    Private Sub GridControl4_Click_1(sender As Object, e As EventArgs) Handles GridControl4.Click
        ' GridControl2.DataSource = Nothing
        GridControl2.DataSource = XpDataView4
        ' GridControl2.MainView.PopulateColumns()
        try
            If GridView4.RowCount = 0 Then
            Else
                Dim direccion = Session1.ExecuteScalar("Select DireccionDeEnvio from Pedidos where IdPedido = " & GridView4.GetFocusedRowCellValue(colIdPedido))
                Dim direccionfisica = Session1.ExecuteScalar("Select Direccion from DireccionesEntrega where Id = " & direccion)
                If direccion <> 0 then
                    dirlabel.Text = "Direccion de entrega: " & direccionfisica
                Else
                    dirlabel.Text = ""
                End if
            End if
        Catch ex As Exception
        End try
        lblCUIT.Text = GridView4.GetRowCellValue(GridView4.FocusedRowHandle, colCUIT_CUIL)
        lbldomicilio.Text = GridView4.GetRowCellValue(GridView4.FocusedRowHandle, colDomicilio)
        lblemail.Text = GridView4.GetRowCellValue(GridView4.FocusedRowHandle, colEmail)
        lbllocalidad.Text = GridView4.GetRowCellValue(GridView4.FocusedRowHandle, colLocalidad)
        ' XpDataView4 = XpDataView2
        cboEmpresas.Enabled = false
        GridControl2.Enabled = false
        SimpleButton1.Enabled = false
        ' MsgBox(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdPedido1))
        ' GridView2.FindFilterText = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdPedido1).ToString
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.CheckState = 1 Then
            TextEdit1.Visible = True
            fechaentrega.Visible = true
        Else
            TextEdit1.Visible = false
            fechaentrega.Visible = false
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub fechaentrega_EditValueChanged(sender As Object, e As EventArgs) Handles fechaentrega.EditValueChanged
        'If fechaentrega.Text <> "" Then
        '     TextEdit1.text = fechaentrega.Text
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Empresa = cboEmpresas.text.ToUpper
        Formadepago = cbopago.text
        If CheckEdit1.CheckState = 1 Then
            Sendmail("logger", "Informacion de Retiro", "juanyoris@montagne.com.ar", "C:\Reportes\ODCs\" + Empresa + " - " + GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3).ToString + ".pdf", TextEdit1.Text & vbCrLf & "Con fecha de retiro: " & fechaentrega.text)
        End If
    End Sub

    Private Sub verorden_Click(sender As Object, e As EventArgs) Handles verorden.Click

    End Sub

    'Private Sub verorden_Click(sender As Object, e As EventArgs) Handles verorden.Click
    '    try
    '        Empresa = cboEmpresas.text.ToUpper
    '        Formadepago = cbopago.text
    '        report.FilterString = "IdPedido =" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdPedido) & "and IdProveedor= " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdProveedor)
    '        report.CreateDocument()
    '        report.ExportToPdf("C:\Reportes\ODCs\" + Empresa + " - " + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdPedido).ToString + ".pdf")
    '        tool.Report.ShowPreviewDialog()
    '    Catch ex As Exception
    '    End try
    '    If MsgBox("Deseas aprobar o cancelar el pedido? ", vbYesNoCancel) = vbyes Then

    '        Session1.ExecuteNonQuery("Update Pedidos SET AproboMartin = 1 where IdPedido =" & CInt(GridView2.GetFocusedRowCellValue(colIdPedido)))
    '    else

    '        Session1.ExecuteNonQuery("Update Pedidos SET AproboMartin = 0, Estado = 3 where IdPedido =" & CInt(GridView2.GetFocusedRowCellValue(colIdPedido)))

    '    End If
    '    Dim resultSet2 As SelectedData = Session1.ExecuteQuery("SELECT * from VistaODC where AproboMartin = 0 and Estado = 1")
    '    'XpDataView2.LoadData(resultSet1)
    '    'XpDataView2.FilterString = "AproboMartin = 0"
    '    XpDataView2.LoadData(resultSet2)
    '    Pedidos.Reload()
    'End Sub
End Class