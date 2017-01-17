Imports DevExpress.Xpo
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrNuevoItem
    Public Session1 As Session = XpoHelper.GetNewSession()
    Private Sub FrNuevoItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XpColDatosPedido.Session = Session1
        XpColProductos.Session = Session1

        XpColDatosPedido.CriteriaString = "IdPedido = " & IdPedido

        Labelnumeropedido.Text = IdPedido
        ControlBox =False
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If GridView1.RowCount = 1 Then
            MsgBox("Aun no tienes nada seleccionado", vbOKOnly, "Sin items")
            Return
        End If
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


                    Close
                Else
                    return
                End If
            Else
                MsgBox("Hay un item sin cantidad asignada.", vbInformation)
                GridView1.RefreshData()
            End If

        Catch ex As Exception
        End Try



        'For x = 0 To 0
        '    Dim res = Session1.ExecuteNonQuery("insert into PedidosDetalles (IdPedido, IdProducto, Cantidad, Observaciones) values ('" & IdPedido & "', '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdProducto) & "', '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colCantidad) & "', '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colObservaciones) & "')")
        'Next
    End Sub
    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetRowCellValue(e.RowHandle, "IdPedido", IdPedido)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim del = Session1.ExecuteNonQuery("DELETE From PedidosDetalles Where IdDetalle = " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, colIdDetalle))

        GridView1.RefreshData()
        GridView1.DeleteSelectedRows()
    End Sub
End Class