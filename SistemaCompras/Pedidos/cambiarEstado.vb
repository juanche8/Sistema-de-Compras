Imports DevExpress.Xpo

Public Class cambiarEstado
    Public Session1 As Session = XpoHelper.GetNewSession()

    Private Sub cambiarEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      proyecto.Session = Session1
        DetallePedido.Session = session1
        Sectores.Session = Session1
        Estados.Session = Session1
        Productos.Session = Session1
        XpCollectionVistaDetalles.Session = Session1
        XpCollectionVistaDetalles2.Session = Session1
       proveedor.Session = Session1
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
         Try
            Dim consulta = GridView1.GetFocusedRowCellValue(colIdPedido)


            If consulta = 0 Then

            Else
                try
                    'DetallePedido.CriteriaString = "IdPedido = " & consulta
                    DetallePedido.CriteriaString = "IdPedido = " & consulta '& " And Sector = " & Sectorid
                    Dim direccion = Session1.ExecuteScalar("Select DireccionDeEnvio from Pedidos where IdPedido = " & GridView1.GetFocusedRowCellValue(colIdPedido))
                    Dim direccionfisica = Session1.ExecuteScalar("Select Direccion from DireccionesEntrega where Id = " & direccion)
                    If direccion <> 0 then
                        dirlabel.Text = "Direccion de entrega: " & direccionfisica
                    Else
                        dirlabel.Text = ""
                    End if
                   
                Catch ex As Exception
                End try
            End If
        Catch exp As Exception
            MessageBox.Show(exp.Message, "Se produjo un error, consulte con soporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        
        If e.Column().name = "colEstado" Then
MsgBox("cambio")
        End If
    End Sub
End Class