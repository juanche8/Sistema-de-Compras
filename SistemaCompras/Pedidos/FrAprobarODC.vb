Imports System.Collections
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraReports.UI

Public Class FrAprobarODC
    Public Session1 As Session = XpoHelper.GetNewSession()
    Dim report As New RpODC()
    Dim tool As ReportPrintTool = New ReportPrintTool(report)
    '  Dim resultSet2 As SelectedData = Session1.ExecuteQuery("SELECT * from VistaODC where AproboMartin = 0 and Estado = 1")



    Private Sub FrAprobarODC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        XpCollection1.Session = Session1
        'verorden.Visible = true
        ' XpDataView2.FilterString = "AproboMartin = 0"
        XpCollection1.CriteriaString = "AproboMartin = 0"

    End Sub

    Private Sub verorden_Click(sender As Object, e As EventArgs) Handles verorden.Click
        Try
            Empresa = ""
            Formadepago = ""
            If gridview3.SelectedRowsCount = 0 Then
                MsgBox(Responsable & ", por favor selecciona un pedido para Ver.", vbInformation)
                exit sub
            else

                report.FilterString = "IdPedido =" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido)
                report.CreateDocument()
                ' report.ExportToPdf("C:\Reportes\ODCs\" + Empresa + " - " + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdPedido).ToString + ".pdf")
                tool.Report.ShowPreviewDialog()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
    Private Sub FrAprobarODC_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If gridview3.SelectedRowsCount = 0 Then
            MsgBox("Debes seleccionar un pedido para Cancelar.", vbInformation)
            else
            If MsgBox("Deseas CANCELAR los pedidos seleccionados?", vbYesNo) = vbYes Then
                If GridView3.SelectedRowsCount = 1 Then
                    Dim consulta = Session1.ExecuteScalar("Update TotalODC SET AproboMartin = 2 where IdPedido = " & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido))
                    ' report.FilterString = "IdPedido = " & consulta & " And Sector = " & Sectorid
                    'tool.Report.ShowPreviewDialog()
                    XpCollection1.Reload()

                ElseIf GridView3.SelectedRowsCount > 1 Then
                    Dim x As IList = GridView3.GetSelectedRows().ToList
                    For s = 0 To x.Count - 1
                        Dim consulta = Session1.ExecuteScalar("Update TotalODC SET AproboMartin = 2 where IdPedido = " & GridView3.GetRowCellValue(x.Item(s), colIdPedido))
                    Next
                    XpCollection1.Reload()
                End If

            else
                return
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If gridview3.SelectedRowsCount = 0 Then
            MsgBox("Debes seleccionar al menos una orden para aprobar", vbInformation)
        else

            If MsgBox("Deseas Aprobar los pedidos seleccionados?", vbYesNo) = vbYes Then
                If GridView3.SelectedRowsCount = 1 Then
                    Dim consulta = Session1.ExecuteScalar("Update TotalODC SET AproboMartin = 1 where IdPedido = " & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, colIdPedido))
                    ' report.FilterString = "IdPedido = " & consulta & " And Sector = " & Sectorid
                    'tool.Report.ShowPreviewDialog()
                    XpCollection1.Reload()

                ElseIf GridView3.SelectedRowsCount > 1 Then
                    Dim x As IList = GridView3.GetSelectedRows().ToList
                    For s = 0 To x.Count - 1
                        Dim consulta = Session1.ExecuteScalar("Update TotalODC SET AproboMartin = 1 where IdPedido = " & GridView3.GetRowCellValue(x.Item(s), colIdPedido))
                    Next
                    XpCollection1.Reload()
                End If

            else
                return
            End If
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        XpCollection1.Reload()
    End Sub
End Class