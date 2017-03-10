﻿Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraReports.UI

Public Class FrODC
    Public Session1 As Session = XpoHelper.GetNewSession()
    Dim report As New RpODC()
    Dim tool As ReportPrintTool = New ReportPrintTool(report)
    Dim resultSet As SelectedData = Session1.ExecuteQuery("SELECT * from VistaODC where AproboMartin = 0")
    Dim resultSet3 As SelectedData = Session1.ExecuteQuery("SELECT * from VistaODC where AproboMartin = 1 and ODCEnviada = 0")
    Dim resultSet4 As SelectedData = Session1.ExecuteQuery("SELECT * from VistaODC where AproboMartin = 2")
    Dim resultSet5 As SelectedData = Session1.ExecuteQuery("SELECT * from VistaODC where AproboMartin = 1 and ODCEnviada = 0") ' este no se usa pero no se borra hasta otra compilacion y testeo

    Private Sub FrODC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView1.GroupPanelText = "Pendiente de Aprobacion"   ''' les cambia el texto al header del gridview
        GridView3.GroupPanelText = "Aprobadas"
        GridView4.GroupPanelText = "Rechazadas"
        XpDataView2.LoadData(resultSet)
        XpDataView3.LoadData(resultSet3)
        XpDataView4.LoadData(resultSet4)
        XpDataView6.LoadData(resultSet5)                       ''' no se usa el resulset5 pero no se borra por las dudas hasta la proxima compilacion.
        Pedidos.Session = Session1
        PedidosDetalles.Session = Session1
        LabelControl5.Visible = True
        cboEmpresas.Visible = True
        LabelControl6.Visible = True
        cbopago.Visible = True
        SimpleButton1.Visible = true

        'XpDataView2.FilterString = "ODCEnviada = 0"

        GridView2.Columns("GridColumn2").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "GridColumn2", "<Color=red>TOTAL FINAL</color>= {0}")
        '''^ totaliza la columna GridColumn2 que tiene los totales de cada producto en el footer con el texto TOTAL FINAL
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
        cboEmpresas.Enabled = false '' inhabilita el combo empresas hasta que ocurra un evento que lo valide.
        try
            If GridView1.RowCount = 0 Then ''' verifica si hay alguna fila seleccionada en el gridview
            Else

                Dim direccion = Session1.ExecuteScalar("Select DireccionDeEnvio from Pedidos where IdPedido = " & GridView1.GetFocusedRowCellValue(colIdPedido))
                Dim direccionfisica = Session1.ExecuteScalar("Select Direccion from DireccionesEntrega where Id = " & direccion)
                If direccion <> 0 then                              '''carga la direccion de id pedido del foco del gridview1 en una variable y verifica si existe direccion
                    dirlabel.Text = "Direccion de entrega: " & direccionfisica
                Else                'para luego cargarlo en el label de direccion, o dejarlo en limpio.
                    dirlabel.Text = ""
                End if
            End if
        Catch ex As Exception
        End try
        lblCUIT.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colCUIT_CUIL)
        lbldomicilio.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colDomicilio)
        lblemail.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colEmail)
        lbllocalidad.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colLocalidad)
        '' se establecen pases de parametros de controles a las etiquetas. ocurre cuando se selecciona un row en el gridview1
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
        Dim a = Nothing
        If lblemail.Text = "" Then   ' si se cargo un precio de producto a un proveedor que no tenia mail esta condicion verifica y advierte para que se le cargue mail.
            MsgBox("El proveedor no tiene email asignado.", vbCritical)
            Return
            'cboEmpresas.Properties.CharacterCasing = CharacterCasing.Upper
            'GridColumn1.AppearanceCell.
        Else
            If MsgBox("Se procedera a enviar la Orden de compra al proveedor " & GridView3.GetFocusedRowCellValue(colRazonSocial3) & " desde la empresa " & cboEmpresas.Text & ". Desea continuar?", vbYesNo) = vbYes Then
                Empresa = cboEmpresas.text.ToUpper
                Formadepago = cbopago.text
                Dim firma As string
                Moneda = Session1.ExecuteScalar("Select Moneda from ListasPrecios where IdProducto = " & GridView2.GetFocusedRowCellValue(colIdProducto1))
                If Empresa.Contains("MONTAGNE") then firma = "MONTAGNE OUTDOORS SA" & vbCrLf & "DPTO DE COMPRAS" & vbCrLf & "4773-0091 INT 1650" else firma = "DPTO DE COMPRAS " + Empresa                'aca se deben agregar el resto de informacion de las otras empresas para las firmas
                report.FilterString = "IdPedido =" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3) & "and IdProveedor= " & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdProveedor3)
                report.CreateDocument()
                report.ExportTopdf("\\CENTRALMONTAGNE\softMtg\compras\Reportes\" + Empresa + " - " + GridView3.GetFocusedRowCellValue(colRazonSocial3) + " - " + GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3).ToString + ".pdf")
                tool.Report.ShowPreviewDialog()  
                ' HASTA ACA COMENTAR PARA VOLVER A CREAR LOS REPORTES
                Try    ' Aplica la condicion de si existe nombreFantasia de ese proveedor en la bd, si no, toma por defecto la RazonSocial
                    ' si consigue nombreFantasia, el codigo salta a Else y continua asignando el mail con respecto a la razonSocial y adjunta la ODC 
                    ' previamente almacenada en el server \\CentralMontagne\softMtg\compras\Reportes\xxx.pdf
                    'aca ocurre el proceso de validacion y envio de mail a los proveedores por id de pedido para asi fragmentar las ordenes de compras por proveedores
                    Dim nombrefantasia As String = Session1.ExecuteScalar("Select NombreFantasia from Proveedores where RazonSocial = '" & GridView3.GetRowCellDisplayText(GridView3.FocusedRowHandle, colRazonSocial3) & "'")
                    If nombrefantasia Is Nothing Then
                        Dim email1 As String = Session1.ExecuteScalar("Select Email  from Proveedores where Email is not null AND Email <> ''  and RazonSocial like '" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colRazonSocial3) & "'").ToString
                        Sendmail("logger", "Orden de Compra - " & Empresa & " - " & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3), email1 & ", mtgcompras@montagne.com.ar", "\\CENTRALMONTAGNE\softMtg\compras\Reportes\" + Empresa + " - " + GridView3.GetFocusedRowCellValue(colRazonSocial3) + " - " + GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3).ToString + ".pdf","\\CENTRALMONTAGNE\softMtg\compras\images\1.jpg" , "Buenas tardes, estimado " & GridView3.GetRowCellDisplayText(GridView3.FocusedRowHandle, colRazonSocial3) & vbCrLf & vbCrLf & "Enviamos adjunto a continuación la orden de compra nro" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3) & "en conformidad con el presupuesto ofrecido. En la misma se encuentran descriptas las condiciones de la operación, por lo que le solicitamos que nos comunique recepción y conformidad de las mismas." & vbCrLf & vbCrLf & "Quedo al aguardo fecha de entrega y queda a la disposición." & vbCrLf & "Saludos cordiales." & vbCrLf & vbCrLf & vbCrLf & firma)
                    Else
                        Dim email1 As String = Session1.ExecuteScalar("Select Email  from Proveedores where Email is not null AND Email <> ''  and RazonSocial like '" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colRazonSocial3) & "'").ToString
                        Sendmail("logger", "Orden de Compra - " & Empresa & " - " & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3), email1 & ", mtgcompras@montagne.com.ar", "\\CENTRALMONTAGNE\softMtg\compras\Reportes\" + Empresa + " - " + GridView3.GetFocusedRowCellValue(colRazonSocial3) + " - " + GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3).ToString + ".pdf","\\CENTRALMONTAGNE\softMtg\compras\images\1.jpg" , "Buenas tardes, estimado " + nombrefantasia & vbCrLf & vbCrLf & "Enviamos adjunto a continuación la orden de compra nro" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3) & "en conformidad con el presupuesto ofrecido. En la misma se encuentran descriptas las condiciones de la operación, por lo que le solicitamos que nos comunique recepción y conformidad de las mismas." & vbCrLf & vbCrLf & "Quedo al aguardo fecha de entrega y queda a la disposición." & vbCrLf & "Saludos cordiales." & vbCrLf & vbCrLf & vbCrLf & firma)
                    End if
                    MsgBox("El correo con la ORDEN DE COMPRA ha sido enviada al proveedor: " + GridView3.GetRowCellDisplayText(GridView3.FocusedRowHandle, colRazonSocial3) + ".", vbInformation)
                    If CheckEdit1.CheckState = 1 Then
                        Sendmail("logger", "Informacion de Retiro", "mtgexpedicion@montagne.com.ar, deboramedina@montagne.com.ar, tatyanamatiushenko@montagne.com.ar", "\\CENTRALMONTAGNE\softMtg\compras\Reportes\" + Empresa + " - " + GridView3.GetFocusedRowCellValue(colRazonSocial3) + " - " + GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3).ToString + ".pdf", "\\CENTRALMONTAGNE\softMtg\compras\images\1.jpg", TextEdit1.Text & vbCrLf & "Con fecha de retiro: " & fechaentrega.text)
                        MsgBox("Se ha enviado el correo con la informacion del retiro", vbinformation)
                    End If
                    Session1.ExecuteNonQuery("Update PedidosDetalles SET ODCEnviada = 1 where IdPedido =" & CInt(GridView3.GetFocusedRowCellValue(colIdPedido2)) & "and IdProveedor = " & CInt(GridView3.GetFocusedRowCellValue(colIdProveedor3)))
                    Session1.ExecuteNonQuery("Update Pedidos SET Estado = 5 where IdPedido =" & CInt(GridView2.GetFocusedRowCellValue(colIdPedido)))  'pendiente
                    
                    Dim resultSet3 As SelectedData = Session1.ExecuteQuery("SELECT * from VistaODC where AproboMartin = 1 and ODCEnviada = 0")
                    'XpDataView2.LoadData(resultSet1)                      "SELECT * from VistaODC where AproboMartin = 1 and ODCEnviada = 0"
                    ' XpDataView3.FilterString = "AproboMartin = 1 and ODCEnviada = 0 "
                    XpDataView3.LoadData(resultSet3)
                    ' Pedidos.Reload()
                    ' Back = 1                                               ' estos dos ultimos son para cerrar y reabrir el formulario para actualizarlo
                    '  Close()
                    ' report.Dispose
                catch ex As Exception
                End try
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
        Moneda = Nothing
        '' se limpian todos los controles al finalizar el envio de las ordenes de compras.
        'sin codigo de prueba hasta aca <-

        ''
    End Sub

    Private Sub cboEmpresas_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboEmpresas.SelectedIndexChanged
        If cboEmpresas.Text IsNot Nothing Then
            cbopago.Enabled = true  ' verifica si el combo de pago a proveedores esta habilitado
        Else
            cbopago.Enabled = false
        End If
    End Sub

    Private Sub cbopago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopago.SelectedIndexChanged
        If cbopago.Text IsNot Nothing Then
            SimpleButton1.Enabled = True   ' verifica si el combopago no tiene texto para hacer las siguientes funciones
        Else
            SimpleButton1.Enabled = false
        End If
    End Sub


    Private Sub FrODC_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Sectorid = 14 then  ' si el sectorid =14 (es decir presidencia) se cierra toda la aplicacion, esto se debe modificar si martin llega a querer otras pantallas.
            Me.Dispose()
            Application.Exit()
        End If
    End Sub

    Private Sub GridControl3_Click_1(sender As Object, e As EventArgs) Handles GridControl3.Click

        'GridControl2.DataSource = Nothing
        GridControl2.DataSource = XpDataView6  'carga el datasource del gridcontrol2 con el xpdataview6
        try
            if GridView3.RowCount = 0 then      'verifica si no hay 0 filas seleccionadas 
            else

                Try
                    Dim a = GridView3.GetFocusedRowCellValue(colidpedido2)  'asigna a la variable el numero de pedido de la fila seleccionada
                    If a IsNot Nothing then
                        
                    XpDataView6.FilterString = "IdPedido = " & a   'filtra el dataview6 con a
                        Else   ' si no hay nada en a, deshabilitan los campos necesarios para el envio de la odc
                        cboEmpresas.Enabled = False
                        cbopago.enabled = False
                        SimpleButton1.Enabled = false
                        Return
                        End if
                    
                Catch ex As exception
                    MsgBox(ex.message)
                End try
            End if
        Catch ex As Exception
        End try
        
        try         'intenta hacer el siguiente procedimiento, que si existe alguna excepcion la va a capturar, es decir, esta a prueba de errores.
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
        GridControl2.Enabled = true     ' habilita el gridcontrol2 
        If gridview3.RowCount = 0 Then  ' comprueba si no existen filas seleccionadas , aplica el filtro del idpedido al xpdataview5.
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
        lblCUIT.Text = GridView4.GetRowCellValue(GridView4.FocusedRowHandle, colCUIT_CUIL)  ' habilita o deshabilita filtros en los labels
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
            TextEdit1.Visible = True        ' oculta o muestra controles dependiendo del estado del control
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
        Empresa = cboEmpresas.text.ToUpper  'pasa a mayusculas el cbo empresas
        Formadepago = cbopago.text
        If CheckEdit1.CheckState = 1 Then  'informacion de retiro en prueba para r00t y me envia mail con reporte
            Sendmail("logger", "Informacion de Retiro", "juanyoris@montagne.com.ar", "C:\Reportes\ODCs\" + Empresa + " - " + GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido3).ToString + ".pdf",Nothing, TextEdit1.Text & vbCrLf & "Con fecha de retiro: " & fechaentrega.text)
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