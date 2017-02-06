Imports System.ComponentModel
Imports System.IO
Imports DevExpress.Data
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Public Class FrPedidos
    'TRUNCATE TABLE (Transact-SQL) Quita todas las filas de una tabla sin registrar las eliminaciones individuales de filas. TRUNCATE TABLE es similar a la instrucción DELETE sin una cláusula WHERE; no obstante, TRUNCATE TABLE es más rápida y utiliza menos recursos de registros de transacciones y de sistema.
    'Public shared sub Addemployee (photoFilePath As string, connectionString As string)
    Dim nped As Integer
    Dim imagedir As String
    Dim photo() as Byte = GetPhoto(imagedir)
    Dim Opcion As Boolean = True
    Public Idpedido As Integer
    Public Session1 As Session = XpoHelper.GetNewSession()
    Dim querylinq1 As New XPQuery(Of MontagneAdministracion.Pedidos)(Session1)
    Dim querylinq2 As New XPQuery(Of MontagneAdministracion.Usuarios)(Session1)
    Dim op = New MontagneAdministracion.Pedidos(Session1)
    ' selecciona y asigna el ultimo idpedido de la tabla pedidos
    Dim report As New RpPedidos()                                                 ' lineas para habilitar la asignacion de datos e impresion del reporte 
    Dim tool As ReportPrintTool = New ReportPrintTool(report)

    Private Sub FrPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        XpColDatosPedido.Session = Session1                                   ' se le asignan los xpcolection a la sesion iniciada (session1)
        XpColDetallePedido.Session = Session1
        XpColUsuario.Session = Session1
        XpColEstado.Session = Session1
        XpColProductos.Session = Session1
        XpColProveedores.Session = Session1
        proyecto.Session = Session1
        direccionxp.Session = Session1
        If Cotiza = 1 Then                                              ' si el permiso es diferente a 1 (seccionoficina) se establecen los labels
            labelestado.Text = "Aprobado"
            labelautor.Visible = True
            comboautor.Visible = True
        Else
            labelestado.Text = "Pendiente de aprobacion"
        End If
        If Cotiza = 3 Then
            GridLookUpEdit1View.OptionsBehavior.AllowAddRows = true
            GridLookUpEdit1View.OptionsView.NewItemRowPosition = 2
        End if
        '  Else
        ' labelestado.Text = "Aprobado"
        '  End If
        Labelresponsable.Text = Responsable                                  ' asignamos los valores a los controles del formulario
        Labelfechapedido.Text = Now.Date.ToShortDateString                   ' al label se le asigna la fecha actual en formato corto
        Labelsector.Text = Sector

        fechaentrega.EditValue = Today.Date.AddDays(15) ' al datetime se le asigna el dia de hoy como valor inicial
        'If CheckEdit2.CheckState.Unchecked Then
        '  prioridad.Text = "Urgente"
        ' Else
        prioridad.Text = "Normal"
        'End If

        '''''''''''' 
        'selecciona la tabla pedidos a la session1
        With op
            .Sector = Sectorid                                'se asignan los datos a los campos de la tabla pedidos desde el control correspondiente
            .FechaPedido = Labelfechapedido.Text
            .Responsable = Labelresponsable.Text

            ' .Observaciones = memobserv.Text
            ' .FechaRecepcion = fechaentrega.DateTime

            ' .Urgente = prioridad.text

            '.Urgente = "Urgente"


            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If labelestado.Text = "Aprobado" Then              ' si el label es aprobado, va a guardar en el campo estado el numero 2(APROBADO)
                .Estado = "2"
            Else
                .Estado = "7"                                  ' si no, guarda el 7, que por defecto es en espera de aprobacion.
            End If
            .Save()                                            ' guarda los objetos en la datastore     
        End With
        '''''''''''''
        Back = 0
        nped = Session1.ExecuteScalar("select max(IdPedido) from Pedidos")
        Labelnumeropedido.Text = nped
        GridView1.OptionsView.RowAutoHeight = true
    End Sub
    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetRowCellValue(e.RowHandle, "FechaPedido", Mid(Now.Date.ToShortDateString, 1, 10))
        GridView1.SetRowCellValue(e.RowHandle, "Sector", Sector)
        GridView1.SetRowCellValue(e.RowHandle, "Responsable", Responsable)
        GridView1.SetRowCellValue(e.RowHandle, "IdPedido", nped)
        'dim obs = GridView1.GetFocusedRowCellDisplayText(colObservaciones).ToString.ToUpper
        'GridView1.SetRowCellValue(e.rowhandle, colObservaciones, obs )
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click       'Verifica si el usuario tiene elementos seleccionados en la grilla
        If GridView1.RowCount = 1 Then
            MsgBox("Aun no tienes nada seleccionado", vbOKOnly, "Sin items")
            Return
        End If
        If combodirecc.Text = "" Then
            MsgBox("Debes indicar la direccion de recepcion del pedido", vbOKOnly, "Sin Direccion de envio")
            Return
        End If
        If TextEdit1.Text = "" Then
            MsgBox("Debes ingresar la sucursal")
            Me.Focus
            return
        End If
        If Cotiza = 1 And comboautor.Text = "" Then
            MsgBox("Debes estar autorizada para hacer esta solicitud.", vbInformation)
            Return
        End If
        For x = 0 To 0 'Step CheckedListBoxControl1.CheckedItems(CheckState.Checked)
            Try
                Dim producto As String = Session1.ExecuteScalar("Select IdProducto from PedidosDetalles where IdProducto = 0")
                Dim cantidad As String = Session1.ExecuteScalar("Select * from PedidosDetalles where Cantidad = .00")
                GridView1.RefreshData()


                If producto = "0" Then
                    MsgBox("Un campo no tiene producto asignado!", vbInformation)
                    Return
                End If


                If cantidad Is Nothing Then
                    If MsgBox("Seguro que desea finalizar el pedido?", vbYesNo, "Finalizar pedido?") = vbYes Then
                        'Botonimprimir.Enabled = True
                        GridControl1.Enabled = False
                        'MsgBox("Ahora puede imprimir su pedido!", vbInformation)
                        SimpleButton1.Enabled = False
                        '  CheckEdit3.Enabled = False
                        ' comboautor.Enabled = False
                    End If
                Else
                    MsgBox("Hay un item sin cantidad asignada.", vbInformation)

                    GridView1.RefreshData()
                    return
                End If
                'If CheckEdit3.CheckState = CheckState.Unchecked Then
                '    GridLookUpEdit1View.GetFocusedRowCellValue(1)
                'End If
            Catch ex As Exception
            End Try
        Next

        '' desde aca la unificacion de los dos botones


        Dim querylinq1 As New XPQuery(Of MontagneAdministracion.Pedidos)(Session1)
        Dim aq = New MontagneAdministracion.Pedidos(Session1) 'selecciona la tabla pedidos a la session1
        With op
            '.IdPedido = GridView1.GetRowCellValue(0, colIdPedido)
            ' .Sector = Sectorid                                'se asignan los datos a los campos de la tabla pedidos desde el control correspondiente
            '.FechaPedido = Labelfechapedido.Text
            '.Responsable = Labelresponsable.Text
            .Observaciones = memobserv.Text
            .FechaRecepcion = fechaentrega.DateTime
            .urgente = prioridad.Text.ToUpper
            .DireccionDeEnvio = combodirecc.EditValue
            .AproboMartin = 0

            If Cotiza = 1 Then
                .AutorizadoPor = comboautor.Text.ToUpper
                .Fechaaprobacion = Now
            End If

            'If CheckEdit3.CheckState = CheckState.Unchecked Then
            '    .Proyecto = 1
            '    CheckEdit3.Text = "Stock"
            'Else
            .Proyecto = GridLookUpEdit1View.GetFocusedRowCellValue(colIdProyecto)
            'End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'If nped = nped Then
            '    .IdPedido = nped
            'Else
            '    .IdPedido = nped + 1

            'End If

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'If labelestado.Text = "Aprobado" Then              ' si el label es aprobado, va a guardar en el campo estado el numero 2(APROBADO)
            '    .Estado = "2"
            'Else
            '    .Estado = "7"                                  ' si no, guarda el 7, que por defecto es en espera de aprobacion.
            'End If
            .Save()

        End With
        report.FilterString = "IdPedido =" & nped
        report.CreateDocument()
        report.ExportToPdf("c:\Reportes\Mis Pedidos\" & nped & " - " & TextEdit1.text + " - " + Responsable + ".pdf")
        If MsgBox(Responsable & ", Deseas imprimir el Pedido?", vbQuestion + vbYesNo) = vbYes
            report.FilterString = "IdPedido =" & nped           ' se hace el filterstring con el IDPEDIDO de la tabla, y traigo el campo Pedido cargado en el load
            tool.Report.ShowPreviewDialog()                        ' luego muestro el preview del reporte
            SimpleButton1.Enabled = True
            'Back = 1                                               ' estos dos ultimos son para cerrar y reabrir el formulario para actualizarlo
            'Close()
            Labelnumeropedido.Text = "1"
        Else

            Labelnumeropedido.Text = "1"
        End If
        back = 1                                               ' estos dos ultimos son para cerrar y reabrir el formulario para actualizarlo
        Close()
    End Sub
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        FrProductos.Show()
    End Sub
    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        '  MsgBox(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdDetalle))
        Dim del = Session1.ExecuteNonQuery("DELETE From PedidosDetalles Where IdDetalle = " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdDetalle))
        'Pedido = Pedido(del)2"
        GridView1.RefreshData()
        GridView1.DeleteSelectedRows()
    End Sub
    'Private Sub BotonimprimirClick(sender As Object, e As EventArgs) Handles Botonimprimir.Click
    '    Dim querylinq1 As New XPQuery(Of MontagneAdministracion.Pedidos)(Session1)
    '    Dim aq = New MontagneAdministracion.Pedidos(Session1) 'selecciona la tabla pedidos a la session1
    '    With op
    '        '.IdPedido = GridView1.GetRowCellValue(0, colIdPedido)
    '        ' .Sector = Sectorid                                'se asignan los datos a los campos de la tabla pedidos desde el control correspondiente
    '        '.FechaPedido = Labelfechapedido.Text
    '        '.Responsable = Labelresponsable.Text
    '        .Observaciones = memobserv.Text
    '        .FechaRecepcion = fechaentrega.DateTime
    '        .urgente = prioridad.Text
    '        .DireccionDeEnvio = combodirecc.EditValue
    '        .AproboMartin = 0

    '        If Cotiza = 1 Then
    '            .AutorizadoPor = comboautor.Text
    '            .Fechaaprobacion = Now
    '        End If

    '        If CheckEdit3.CheckState = CheckState.Unchecked Then
    '            .Proyecto = 1
    '        Else
    '            .Proyecto = GridLookUpEdit1View.GetFocusedRowCellValue(colIdProyecto)
    '        End If
    '        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '        'If nped = nped Then
    '        '    .IdPedido = nped
    '        'Else
    '        '    .IdPedido = nped + 1

    '        'End If

    '        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '        'If labelestado.Text = "Aprobado" Then              ' si el label es aprobado, va a guardar en el campo estado el numero 2(APROBADO)
    '        '    .Estado = "2"
    '        'Else
    '        '    .Estado = "7"                                  ' si no, guarda el 7, que por defecto es en espera de aprobacion.
    '        'End If
    '        .Save()

    '    End With
    '    report.FilterString = "IdPedido =" & nped           ' se hace el filterstring con el IDPEDIDO de la tabla, y traigo el campo Pedido cargado en el load
    '    tool.Report.ShowPreviewDialog()                        ' luego muestro el preview del reporte
    '    SimpleButton1.Enabled = True
    '    Back = 1                                               ' estos dos ultimos son para cerrar y reabrir el formulario para actualizarlo
    '    Close()
    'End Sub
    Private Sub FrPedidos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing ' advierte que pierde datos si no imprime, si acepta, se borran los registros de los pedidos seleccionados en la grid de la bdd
        If SimpleButton1.Enabled = False And Botonimprimir.Enabled = True Then
            If MsgBox("Debes imprimir el Comprobante para guardar los datos del pedido. ¿Desesas salir?", vbYesNo, "Atencion!") = vbNo Then
                e.Cancel = True
            Else
                'Dim del = Session1.ExecuteNonQuery("DELETE From PedidosDetalles Where IdPedido = " & nped)
                'Dim del1 = Session1.ExecuteNonQuery("DELETE From Pedidos Where IdPedido = " & nped)
                e.Cancel = False
            End If

        End If

    End Sub
    Private Sub fechaentrega_Validating(sender As Object, e As CancelEventArgs) Handles fechaentrega.Validating
        If fechaentrega.DateTime >= Today.Date.AddDays(15) Then
        Else
            MsgBox("Esta es una fecha estimada de entrega. No puede ser menor a 15 dias. Elegí una mayor a: " & Today.Date.AddDays(15), vbExclamation, "ERROR")
            fechaentrega.EditValue = Today.Date.AddDays(15)
            fechaentrega.Focus()
            If fechaentrega.DateTime < Date.Today Then
                MsgBox("No es posible esta seleccion.")
            End If
        End If
    End Sub
    Private Sub FrPedidos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing


        If Labelnumeropedido.text = "1" Then

        else

            Dim del = Session1.ExecuteNonQuery("DELETE From PedidosDetalles Where IdPedido = " & Labelnumeropedido.Text)
            Dim del1 = Session1.ExecuteNonQuery("DELETE From Pedidos Where IdPedido = " & Labelnumeropedido.Text)
            e.Cancel = False
        End If



    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        picturebox1.image = nothing
        Using O As New OpenFileDialog With {.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico", .Multiselect = False, .Title = "Selecciona una imagen para cargar al Producto"}
            If O.ShowDialog = 1 Then
                imagedir = O.FileName
                dim imgserver = "\\CENTRALMONTAGNE\softMtg\compras\images\" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, coliddetalle) & ".jpg"
                My.Computer.FileSystem.CopyFile(imagedir, imgserver, FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
                ' Dim picture As Buffer 
                PictureBox1.Image = Image.FromFile(imgserver)

                'Try
                '    Dim photo() as Byte = GetPhoto(imagedir)
                '    'photo = photo.Length()
                Dim guardarimg = Session1.ExecuteNonQuery("update PedidosDetalles set ImagenUrl ='" & imgserver & "' Where IdDetalle = " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdDetalle))
                'imgserver = Nothing
                '    ' XpColDatosPedido.Reload
                '    Dim leerimg = Session1.ExecuteQuery("Select Imagen from PedidosDetalles Where IdDetalle = " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdDetalle))
                '    PictureEdit1.EditValue = leerimg
                '    GridView1.SetFocusedRowCellValue(colimagen,leerimg)
                '    PictureEdit1.Refresh
                '    ' GridView1.RefreshData()
                '    GridView1.UpdateCurrentRow()
                'Catch ex As Exception
                '    MsgBox(ex)
                'End Try
            End If
        End Using
    End Sub
    Public Shared Function GetPhoto(filePath As String) As Byte()
        try
            Dim stream As FileStream = New FileStream( _
           filePath, FileMode.Open, FileAccess.Read)
            Dim reader As BinaryReader = New BinaryReader(stream)
            Dim photo() As Byte = reader.ReadBytes(stream.Length)
            reader.Close()
            stream.Close()
            Return photo
        Catch ex As Exception
        End try
    End Function
    Function imgtoarr(ByVal URLimagen As String) As Byte()
        Dim img As Image = Image.FromFile(URLimagen)
        Dim ms As New System.IO.MemoryStream
        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function
    ''' <summary>
    ''' desde aca se haran los filtros de rubros por sector
    ''' pendiente de modificaciones
    ''' </summary>
    Private Sub GridControl1_Load(sender As Object, e As EventArgs) Handles GridControl1.Load   '''******* pendiente por seguir para clasificar rubros por sector******
        If Sectorid = 1 Then
            XpColProductos.CriteriaString = "Rubro = 'SISTEMAS'"
        End If
        If Sectorid = 3 Then
            XpColProductos.CriteriaString = "Rubro =  'SISTEMAS' or Rubro = 'FERRETERIA'"
            '  XpColProductos.CriteriaString = "Rubro =  'FERRETERIA'"
        End If
    End Sub
    Private Sub FrPedidos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.CheckState = CheckState.Checked Then
            XpColProductos.CriteriaString = Nothing
            'XpColProductos.Reload()
        Else
            If Sectorid = 1 Then
                XpColProductos.CriteriaString = "Rubro = 'SISTEMAS'"
            End If
            If Sectorid = 3 Then
                XpColProductos.CriteriaString = "Rubro =  'SISTEMAS' or Rubro = 'FERRETERIA'"
                '  XpColProductos.CriteriaString = "Rubro =  'FERRETERIA'"
            End If
        End If
    End Sub
    Private Sub RepositoryItemGridLookUpEdit1_BeforePopup(sender As Object, e As EventArgs) Handles RepositoryItemGridLookUpEdit1.BeforePopup
        XpColProductos.Reload()
    End Sub

    Private Sub CheckEdit2_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckStateChanged
        If CheckEdit2.Checked Then
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance

            MsgBox("Se procedera a establecer la solicitud con motivo de urgencia", vbOKCancel)
            fechaentrega.CausesValidation = False
            fechaentrega.EditValue = Today
            imagurgente.Visible = True
            prioridad.Text = "Urgente"
            CheckEdit2.Text = "Prioridad: Urgente!"
            If fechaentrega.DateTime < Date.Today Then
                MsgBox("No es posible esta seleccion.")
            End If
        Else
            fechaentrega.CausesValidation = True
            If fechaentrega.DateTime >= Today.Date.AddDays(15) Then
            Else
                fechaentrega.EditValue = Today.Date.AddDays(15)
                fechaentrega.Focus()
                If fechaentrega.DateTime < Date.Today Then
                    MsgBox("No es posible esta seleccion.")
                End If
            End If

            imagurgente.Visible = False
            prioridad.Text = "Normal"
            CheckEdit2.Text = "Prioridad: Normal"
        End If
    End Sub


    Private Sub CheckEdit3_CheckedChanged(sender As Object, e As EventArgs)

        'FlyoutPanel1.ShowPopup()
        ' If TextEdit1.Text <> "" Then 
        '  CheckEdit3.Text = TextEdit1.Text
        'End If
    End Sub

    Private Sub TextEdit1_Click(sender As Object, e As EventArgs) Handles TextEdit1.Click
        'CheckEdit3.Text = TextEdit1.Text
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit1.EditValueChanged
        '   CheckEdit3.Text = TextEdit1.Text
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        'colimagen.Image = img
        'Try
        '    Dim leerimg = Session1.ExecuteScalar("Select ImagenUrl from PedidosDetalles Where IdDetalle = " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdDetalle))
        '    If leerimg IsNot nothing Then
        '        SimpleButton3.Visible = True
        '        PictureBox1.Image = Image.FromFile(leerimg)
        '    End If
        'Catch ex As Exception
        'End Try

        'PictureBox1.Image= Nothing


    End Sub

    Private Sub FlyoutPanelControl1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)
        'FlyoutPanel2.ShowPopup()

    End Sub

    Private Sub FlyoutPanel2_Hidden(sender As Object, e As DevExpress.Utils.FlyoutPanelEventArgs)
        'PictureBox1.Image = nothing
    End Sub

    Private Sub PictureBox1_ImageChanged(sender As Object, e As EventArgs) Handles PictureBox1.ImageChanged
        'dim imgserver = "\\192.168.189.26\c$\update\images\" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, coliddetalle) & ".jpg"
        'My.Computer.FileSystem.CopyFile(PictureBox1. ,imgserver, FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
        'PictureBox1.Image = Image.FromFile(imgserver)
        'Dim guardarimg = Session1.ExecuteNonQuery("update PedidosDetalles set ImagenUrl ='" & imgserver & "' Where IdDetalle = " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdDetalle))
    End Sub
    Private Sub GridView1_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If gridview1.GetRowCellValue(gridview1.FocusedRowHandle, colIdDetalle) is nothing Then
            SimpleButton2.Enabled = false
        else
            Try
                SimpleButton2.Enabled = true
                Dim leerimg = Session1.ExecuteScalar("Select ImagenUrl from PedidosDetalles Where IdDetalle = " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdDetalle))
                If leerimg IsNot nothing Then
                    'SimpleButton3.Visible = True
                    PictureBox1.Image = Image.FromFile(leerimg)
                Else
                    PictureBox1.Image = Nothing
                End If
            Catch ex As Exception
            End Try
        end if
    End Sub




    Private Sub GridControl1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GridControl1.KeyPress

    End Sub

    Private Sub GridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GridView1.KeyPress

    End Sub

    Private Sub GridView1_GotFocus(sender As Object, e As EventArgs) Handles GridView1.GotFocus
     
    End Sub
End Class