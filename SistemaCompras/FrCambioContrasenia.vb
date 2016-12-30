Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports SistemaCompras.MontagneAdministracion

Public Class FrCambioContrasenia

    Public Session1 As Session = XpoHelper.GetNewSession()
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If NUEVA1.Text <> NUEVA2.Text Then
            MsgBox("LAS NUEVAS CONTRASEÑAS INGRESADAS NO COINCIDEN, REINGRESELAS DE NUEVO")
        Else
            Dim res = Session1.ExecuteNonQuery("Update usuarios set Contraseña = '" & NUEVA1.Text & "' where UsuarioID =  '" & Usuario1.Text & "'")
            If res > 0 Then
                MsgBox("La contraseña se cambio con exito")
                Me.Close()
            Else
                MsgBox("La contraseña no se cambio, reintentelo")
            End If
        End If

    End Sub

    Private Sub ActualLeave(sender As Object, e As EventArgs) Handles ACTUAL.Leave
        If ACTUAL.Text <> "" Then
            Dim getRecords As New XPCollection(Of Usuarios)(Session1, CriteriaOperator.Parse("UsuarioID >= '" & Usuario1.Text & "' And Contraseña = '" & ACTUAL.Text & "'"))
            If getRecords.Count = 0 Then
                MsgBox("Usuario inexistente o contraseña incorrecta, reingrese los datos")
                SimpleButton1.Visible = False
            Else
                SimpleButton1.Visible = True
            End If
        End If
    End Sub


End Class