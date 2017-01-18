Imports System.Collections
Imports System.IO
Imports System.Net.Mail
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports SistemaCompras.MontagneAdministracion
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraPrintingLinks
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.CodeParser
Imports DevExpress.Utils.WaitDialogForm
Imports DevExpress.XtraSplashScreen
Imports DevExpress.Data

Public Class FrPresupuestos
    Dim ids As String
    Dim vec(500) As String
    Dim consulta As integer

    'Dim report As New RpSolicitudCotizacion()
    'Dim tool As ReportPrintTool = New ReportPrintTool(report)

    Public Session1 As Session = XpoHelper.GetNewSession()
    Dim querylinq1 As New XPQuery(Of MontagneAdministracion.Pedidos)(Session1)
    Dim querylinq2 As New XPQuery(Of MontagneAdministracion.Usuarios)(Session1)
    'Dim querylinq3 As New XPQuery(Of MontagneAdministracion.Proveedores)(Session1)
    'Dim nped = Session1.ExecuteScalar("select max(IdPedido) from Pedidos")          ' selecciona y asigna el ultimo idpedido de la tabla pedidos
    'Dim report As New RpPedidos()                                                 ' lineas para habilitar la asignacion de datos e impresion del reporte 
    'Dim email = Session1.ExecuteScalar("Select from Proveedores WHERE Email = " & CheckedComboBoxEdit1.EditValue)
    ' Dim tool As ReportPrintTool = New ReportPrintTool(report)

    'Public Idpedido As Integer
    Public Property RichEditControl1 As Object

    Private Sub FrPresupuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XpCollection1.Session = Session1
        Pedidos.Session = Session1
        DetallePedido.Session = Session1
        Sectores.Session = Session1
        Estados.Session = Session1
        Productos.Session = Session1
        Proveedores.Session = Session1
        vistadetallepedido.Session = Session1
        proyecto.Session = Session1

        If Cotiza = 1 Then
            Pedidos.CriteriaString = "Estado = 2 and AutorizadoPor is not null "
            PictureBox1.Visible = True
            SimpleButton6.Visible = true
            SimpleButton5.Visible = true
        End If
        Proveedores.CriteriaString = "Email  Is Not null"
        Proveedores.CriteriaString = "Rubro  Is Not null"
        Back = 0
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim pedido = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido)
        Dim prov = CheckedListBoxControl1.Text
        Dim querylinq As New XPQuery(Of Proveedores)(Session1)
        If CheckedListBoxControl1.CheckedItemsCount = Nothing Then
            MsgBox("Debes seleccionar al menos un proveedor para verificar si pose correo electronico asignado")
        Else
            Dim dlg As DevExpress.Utils.WaitDialogForm
            dlg = New DevExpress.Utils.WaitDialogForm("Validando direcciones de correo...")
            'With CheckedListBoxControl1.CheckedItemsCount > 0
            For x = 0 To CheckedListBoxControl1.ItemCount - 1
                Try
                    Dim email As String = Session1.ExecuteScalar("Select Email from Proveedores where Email Is Not null And Email <> ''  and RazonSocial like '" & CheckedListBoxControl1.GetDisplayItemValue(x) & "'").ToString
                Catch ex As Exception
                    If x = 0 Then
                    Else
                        CheckedListBoxControl1.SetItemChecked(x, CheckState.Unchecked)
                    End If
                End Try
            Next
            dlg.Close()
            MsgBox("Solo podran recibir la solicitud de cotizacion los proveedores que quedaron marcados. ", vbInformation)
            ' End With
            'Dim nn
            'For nn = 0 To vec.Rank
            '    PopupContainerEdit1.Text = PopupContainerEdit1.Text & vec(nn) & ", "
            'Next
            'PopupContainerEdit1.Text = Mid(PopupContainerEdit1.Text, 1, Len(PopupContainerEdit1.Text) - 2)
        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim tal As String
        tal = GridView3.GetFocusedRowCellDisplayText(colResponsable)
        If MsgBox("Segura que deseas anular la solicitud de " & tal & ".?", vbYesNo) = vbNo Then
        Else
            GridView3.SetFocusedRowCellValue(colEstado, 3)
            GridView3.SetFocusedRowCellValue(colObservaciones, "Anulado por compras el dia: " & Today & " a las: " & TimeOfDay)
            GridView3.UpdateCurrentRow()
        End If
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        Try
            consulta = GridView3.GetFocusedRowCellValue(colIdPedido)
            If consulta = 0 Then
            Else
                Productos.CriteriaString = "IdPedido = " & consulta '& " And Sector = " & Sectorid
                Dim direccion = Session1.ExecuteScalar("Select DireccionDeEnvio from Pedidos where IdPedido = " & GridView1.GetFocusedRowCellValue(colIdPedido))
                Dim direccionfisica = Session1.ExecuteScalar("Select Direccion from DireccionesEntrega where Id = " & direccion)
                If direccion <> 0 Then
                    dirlabel.Text = "Direccion de entrega: " & direccionfisica
                Else
                    dirlabel.Text = ""
                End If
            End If
        Catch exp As Exception
            MessageBox.Show(exp.Message, "Se produjo un error, consulte con soporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub GridView3_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridView3.RowStyle
        Dim view As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim urgente As String = view.GetRowCellDisplayText(e.RowHandle, view.Columns("Urgente"))
            If urgente = "Urgente" Then
                e.Appearance.BackColor = Color.Red
                e.Appearance.ForeColor = Color.White
            Else
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        PopupContainerEdit1.Text = ""
        Empresa = cboEmpresas.Text.ToUpper
        If CheckedListBoxControl1.CheckedItemsCount = Nothing Then
            MsgBox("Debes seleccionar al menos un proveedor para enviar el correo.")
        Else
            Dim dlg As DevExpress.Utils.WaitDialogForm
            dlg = New DevExpress.Utils.WaitDialogForm("Enviando correos electronicos...")
            'SplashScreenManager.ShowDefaultSplashScreen()
            For x = 0 To CheckedListBoxControl1.ItemCount - 1
                Try
                    Dim email As String = Session1.ExecuteScalar("Select Email  from Proveedores where Email is not null AND Email <> ''  and RazonSocial like '" & CheckedListBoxControl1.GetDisplayItemValue(x) & "'").ToString
                Catch ex As Exception
                    If x = 0 Then
                        MsgBox("Solo quedaran marcados los proveedores con direcciones de correos asignados ", vbInformation, vbExclamation)
                    End If
                    CheckedListBoxControl1.SetItemChecked(x, CheckState.Unchecked)
                End Try
            Next
            Dim t As Integer
            Dim report As New RpSolicitudCotizacion()
            report.FilterString = "IdPedido =" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido)
            report.CreateDocument()
            report.ExportToXls("C:\Reportes\Pedidos\" & Empresa + " - " + GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido).ToString + ".xls")

            For t = 0 To CheckedListBoxControl1.CheckedIndices.Count - 1
                Dim m = CheckedListBoxControl1.CheckedIndices.Item(t)
                vec(t) = CheckedListBoxControl1.GetItemText(m).ToString
                Dim email1 As String = Session1.ExecuteScalar("Select Email  from Proveedores where Email is not null AND Email <> ''  and RazonSocial like '" & CheckedListBoxControl1.GetItemText(m).ToString & "'").ToString
                Sendmail("logger", "Solicitud de cotizacion - " & Empresa, email1, "C:\Reportes\Pedidos\" & Empresa + " - " + GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido).ToString & ".xls", "Saludos " + vec(t) + ", por favor cotizar los siguientes productos mostrados en el adjunto de este correo." & vbCrLf & "Departamento de Compras " & Empresa & ".")
            Next
            If CheckedListBoxControl1.CheckedItemsCount = Nothing Then
                MsgBox("El proveedor que seleccionaste no poseia Email registrado, no se envio el correo!", vbInformation, "Atencion!")
            Else
                dlg.Close()
                '  SplashScreenManager.CloseForm()
                MsgBox("El correo electronico ha sido enviado a los proveedores seleccionados", vbInformation, "Envio Exitoso")
                GridView3.SetFocusedRowCellValue(colEstado, 1)
                GridView3.UpdateCurrentRow()
            End If
        End If
        PopupContainerEdit1.Text = ""
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        For t = 0 To CheckedListBoxControl1.SelectedIndices.Count - 1
            Dim m = CheckedListBoxControl1.SelectedIndices.Item(t)
            Dim telefono As String = Session1.ExecuteScalar("Select Telefonos from Proveedores where RazonSocial like '" & CheckedListBoxControl1.GetItemText(m) & "'")
            If telefono Is Nothing Then
                MsgBox("El proveedor " & CheckedListBoxControl1.GetItemText(m) & " no posee telefono registrado")
            Else
                MsgBox("El numero telefonico de " & CheckedListBoxControl1.GetItemText(m) & " es " & telefono)
            End If
        Next
    End Sub
    Private Sub cboEmpresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpresas.SelectedIndexChanged
        If cboEmpresas.Text IsNot Nothing Then
            PopupContainerEdit1.Enabled = True
        End If
    End Sub

    Private Sub GridControl2_Click(sender As Object, e As EventArgs) Handles GridControl2.Click
        If GridView1.RowCount >= 1 Then
            SimpleButton6.Enabled = true
        Else
            SimpleButton6.Enabled = false
        End If

    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As RowClickEventArgs) Handles GridView1.RowClick
        If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colProducto) Is Nothing Then
        Else
            Try
                Dim leerimg = Session1.ExecuteScalar("Select ImagenUrl from PedidosDetalles Where IdDetalle = " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdDetalle))
                If leerimg IsNot Nothing Then
                    'SimpleButton3.Visible = True
                    PictureBox1.Image = Image.FromFile(leerimg)
                Else
                    PictureBox1.Image = Nothing
                End If
            Catch ex As Exception
            End Try
        End If

    End Sub
    Private Sub FrPresupuestos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        try
            If GridView1.RowCount = 0 Then
            Else
                Dim prod = Session1.ExecuteScalar("Select Id from Productos where Producto = '" & GridView1.GetFocusedRowCellValue(colProducto) & "'")
                Idprod = prod

            End if
        Catch ex As Exception
        End try
        FrProductos.show()
        Productos.Reload
        GridView3.RefreshData
        'Productos = Nothing
        'Productos.Session = Session1
        'Back = 1                                               ' estos dos ultimos son para cerrar y reabrir el formulario para actualizarlo
        'Close()
        'GridView3.MoveBy(IdPedido)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        IdPedido = Session1.ExecuteScalar("Select IdPedido from Pedidos where IdPedido = " & GridView1.GetFocusedRowCellValue(colIdPedido))
        FrNuevoItem.showdialog()
        Productos.Reload
        Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If GridView1.SelectedRowsCount = 1 Then

            Dim pedido = Session1.ExecuteScalar("Select IdPedido from PedidosDetalles where IdPedido = " & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido))
            Dim item = Session1.ExecuteScalar("Select IdDetalle from PedidosDetalles where IdDetalle = " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridColumn3))
            Dim report As New RpSolicitudCotizacion()
            Dim tool As ReportPrintTool = New ReportPrintTool(report)
            report.FilterString = "IdPedido = " & pedido & " and IdDetalle = " & item
            report.CreateDocument
            tool.report.ShowPreviewDialog()

            ' Pedidos.Reload()
            ' GridView2.CheckLoaded 
            GridView1.ClearSelection
        ElseIf GridView1.SelectedRowsCount > 1 Then
            Dim x As IList = GridView1.GetSelectedRows().ToList
            Dim stra As String
            For s = 0 To x.Count - 1

                Dim consulta = Session1.ExecuteScalar("Select IdDetalle from PedidosDetalles where IdDetalle = " & GridView1.GetRowCellValue(x.Item(s), GridColumn3))
                stra = stra & " IdDetalle = " & consulta & " or "
            Next
            stra = Mid(stra, 1, Len(stra) - 3) 
            Dim report As New RpSolicitudCotizacion()
            Dim tool As ReportPrintTool = New ReportPrintTool(report)
            report.FilterString = stra
            report.ShowPreviewDialog()
            Pedidos.Reload()
        End If
    End Sub

    'Private Sub form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles .KeyDown

    '    If e.KeyData = Keys.F5 Then
    '        Me.Refresh()
    '    End If

    'End Sub

    Private Sub Button2_KeyDown(sender As Object, e As KeyEventArgs) Handles Button2.KeyDown
        If e.KeyData = Keys.F5 Then
            GridView1.UpdateCurrentRow()
            Productos.Reload
            GridView3.RefreshData
            Refresh()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class