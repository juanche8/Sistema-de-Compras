﻿Imports System.ComponentModel
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports SistemaCompras.MontagneAdministracion

Public Class FrMasterDetailPedidos
    Public Shared ReadOnly Property Today As Date

    Public Session1 As Session = XpoHelper.GetNewSession()
    Public oc As Integer



    Private Sub FrMasterDetailPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load, GridView1.HiddenEditor
        proyecto.Session = Session1

        Sectores.Session = Session1
        Estados.Session = Session1
        Productos.Session = Session1
        XpCollectionVistaDetalles.Session = Session1
        XpCollectionVistaDetalles2.Session = Session1
        pedidosdetalles.Session = session1
        If Sectorid <> 5 Then
            XpCollectionVistaDetalles2.CriteriaString = "Sector = " & Sectorid
            'XpCollectionVistaDetalles2.CriteriaString = "Estado <= 3 "
            If Responsable = "Paulo Gregoretti" Then
                XpCollectionVistaDetalles2.CriteriaString = "Sector = 12 or Sector = 3 or Sector = 13"
            End If
            If Cotiza = 0 Then
                XpCollectionVistaDetalles2.CriteriaString = "Responsable like '" & Responsable & "%'"
            Else

            End If
        End If
        If Cotiza = 3 Then

            sbimprimir.Visible = True

        End If
    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        'If CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colEstado).ToString) <> 1 Then
        '    GridView1.SetFocusedRowCellValue(colEstado, 7)
        'End If
        'If Permiso = "1" Then
        '    GridView1.SetFocusedRowCellValue(colEstado, 2)
        'Else
        ' End If

    End Sub
    Private Sub GridView1_MasterRowExpanded(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles GridView1.MasterRowExpanded
        'If CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colEstado).ToString) <> 1 Then
        '    MsgBox("Este pedido no puede modificarse")
        'End If
    End Sub

    Private Sub GridView2_EditFormShowing(sender As Object, e As EditFormShowingEventArgs)
        'If CInt(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colEstado).ToString) <> 1 Then
        '    e.Allow = False
        'End If
    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        'GridView1.SetRowCellValue(e.RowHandle, "FechaPedido", Mid(Now.Date.ToShortDateString, 1, 10))
        'GridView1.SetRowCellValue(e.RowHandle, "Sector", Sectorid)
        'GridView1.SetRowCellValue(e.RowHandle, "Responsable", Responsable)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'Dim consulta = Session1.ExecuteNonQuery("Select IdPedido from VistaPedidosDetalle where IdPedido = " & TextEdit1.EditValue & " ")
        'If consulta <> "" Then
        '    XpCollectionVistaDetalles.CriteriaString = "IdPedido = " & consulta '& " And Sector = " & Sectorid
        '    XpCollectionVistaDetalles.CriteriaString = "Sector = " & Sectorid
        '    XpCollectionVistaDetalles2.CriteriaString = "IdPedido = " & consulta '& " And Sector = " & Sectorid
        '    XpCollectionVistaDetalles2.CriteriaString = "Sector = " & Sectorid
        'ElseIf consulta = ""
        '    Refresh()
        'End If


        ''''''''If colIdPedido1.ToString = TextEdit1.Text Then
        ''''''''    MsgBox("no se encuentra pedido")
        ''''''''Else GridView5.GetDetailView(rowHandle:=1, relationIndex:=1)

        ''''''''End If
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        SimpleButton3.Enabled= False
        Try
            Dim consulta = GridView1.GetFocusedRowCellValue(colIdPedido)


            If consulta = 0 Then

            Else
                try
                    pedidosdetalles.CriteriaString = "IdPedido = " & consulta '& " And Sector = " & Sectorid
                    Dim direccion = Session1.ExecuteScalar("Select DireccionDeEnvio from Pedidos where IdPedido = " & GridView1.GetFocusedRowCellValue(colIdPedido))
                    Dim direccionfisica = Session1.ExecuteScalar("Select Direccion from DireccionesEntrega where Id = " & direccion)
                    If direccion <> 0 then
                        dirlabel.Text = "Direccion de entrega: " & direccionfisica
                    Else
                        dirlabel.Text = ""
                    End if
                    If GridView1.GetFocusedRowCellValue(colResponsable) = Responsable And GridView1.GetFocusedRowCellValue(colEstado) = 5 Then
                        SimpleButton2.Visible = true
                    Else
                        SimpleButton2.Visible = false
                    End if
                Catch ex As Exception
                End try
            End If
        Catch exp As Exception
            MessageBox.Show(exp.Message, "Se produjo un error, consulte con soporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'Private Sub FrMasterDetailPedidos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
    '    'Dim x
    '    For x = 0 To GridView1.RowCount - 1
    '        ' MsgBox(DateDiff(DateInterval.Day, Now.Date, GridView1.GetRowCellValue(x, colFechaRecepcion)))

    '        If DateDiff(DateInterval.Day, Now.Date, GridView1.GetRowCellValue(x, colFechaRecepcion)) < -8 Then
    '            GridView1.Appearance.Row.BackColor = Color.DeepPink
    '        Else
    '            GridView1.Appearance.Row.BackColor = Color.Coral
    '        End If

    '    Next
    'End Sub

    Private Sub GridView1_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridView1.RowStyle
        Dim view As GridView = sender
        Vencer = DateDiff(DateInterval.Day, Now.Date, GridView1.GetRowCellValue(e.RowHandle, colFechaRecepcion)) >= 15
        If Vencer = True Then
        Else
            e.Appearance.ForeColor = Color.DarkRed
        End If
        If (e.RowHandle >= 0) Then
            Dim urgente As String = view.GetRowCellDisplayText(e.RowHandle, view.Columns("Urgente"))
            If urgente = "Urgente" Then
                e.Appearance.BackColor = Color.Red
                e.Appearance.BackColor2 = Color.salmon
                e.Appearance.ForeColor = Color.White
                
            Else
            End If
        End If
    End Sub

    Private Sub sbimprimir_Click(sender As Object, e As EventArgs) Handles sbimprimir.Click
        If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdPedido) Is Nothing Then
            MsgBox("Selecciona una fila para imprimir.")
        Else
            Dim report As New RpPedidos()
            Dim tool As ReportPrintTool = New ReportPrintTool(report)
            report.FilterString = "IdPedido =" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdPedido)
            tool.Report.ShowPreviewDialog()
            XpCollectionVistaDetalles2.Reload()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        For I As Integer = 0 To GridView5.RowCount - 1
            Dim a = GridView5.GetRowCellDisplayText(I,colProdRecibido)
            If a = "" Then
                MsgBox("Debes marcar como recibido todos los productos")
                Return
            Else
                SimpleButton2.Visible = true
            End If
        Next
        If MsgBox("Confirmas que tu pedido ha llegado? ", vbYesNo) = vbYes then
            ' Session1.ExecuteNonQuery("Update Pedidos SET Estado = 6 where IdPedido =" & CInt(GridView1.GetFocusedRowCellValue(colIdPedido)))
            GridView1.SetFocusedRowCellValue(colEstado, 6)
            GridView1.UpdateCurrentRow()
            MsgBox("El estado de tu pedido se ha cambiado a 'RECIBIDO'")
        Else
            Return
        End If

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

        If MsgBox("Confirmas la recepcion del producto? ", vbYesNo) = vbYes then
            '  Session1.ExecuteNonQuery("update PedidosDetalles SET ProdRecibido = '"& DateTime.Now & "' where IdDetalle = "& GridView5.GetFocusedRowCellValue(colIdDetalle))
            '  XpCollectionVistaDetalles.Reload()
            GridView5.SetFocusedRowCellValue(colProdRecibido, DateTime.Now)
            GridView5.UpdateCurrentRow()
            ' GridControl2.Update
            ' GridControl2.Refresh
            'GridControl2.DataSource = XpCollectionVistaDetalles
        Else
            Return
        End If
    End Sub
  
    Private Sub GridControl2_Click(sender As Object, e As EventArgs) Handles GridControl2.Click
        SimpleButton3.Enabled = false
        Dim estado = Session1.ExecuteScalar("Select Estado from Pedidos where IdPedido = " & GridView1.GetFocusedRowCellValue(colIdPedido))
        If GridView5.RowCount >= 1 and estado = 5 then
            SimpleButton3.Enabled = true
        End If
        'For I As Integer = 0 To GridView5.RowCount - 1
        '    Dim a = GridView5.GetFocusedRowCellValue(colProdRecibido)
        '    If a = "" Then
        '        SimpleButton2.Visible = False
        '    Else
        '        SimpleButton2.Visible = true
        '    End If
        'Next

    End Sub
End Class