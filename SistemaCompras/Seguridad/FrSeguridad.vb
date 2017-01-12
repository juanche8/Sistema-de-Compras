Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls
Imports SistemaCompras.MontagneAdministracion

Public Class FrSeguridad


    Public Session1 As Session = XpoHelper.GetNewSession()
    Dim querytags As New XPQuery(Of Usuariostags)(Session1)


    Private Sub FrSeguridad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inhabilitados = Session1.ExecuteScalar("select count (Habilitado )from Usuarios where Habilitado = 0")
        Dim list = From o In querytags Where o.UsuarioID = Usuario Select o.Tag, o.Permiso

        If inhabilitados = 0 Then

            'ToggleSwitch1.IsOn = False
            LabelControl1.Text = "Los usuarios estan HABILITADOS "
        Else
            'CheckEdit1.CheckState = CheckState.Unchecked
            LabelControl1.Text = "Los usuarios estan INHABILITADOS"
        End If
        'For Each item In list
        '    If TileControl1.GetTileGroupByName("TileGroup1").GetTileItemByName("USUARIOS").Tag = item.Tag And String.Compare(item.Permiso, "N", False) = 0 Then
        '        TileControl1.GetTileGroupByName("TileGroup1").GetTileItemByName("USUARIOS").Visible = False
        '    End If
        '    If TileControl1.GetTileGroupByName("TileGroup1").GetTileItemByName("ROLES").Tag = item.Tag And String.Compare(item.Permiso, "N", False) = 0 Then
        '        TileControl1.GetTileGroupByName("TileGroup1").GetTileItemByName("ROLES").Visible = False
        '    End If
        '    If TileControl1.GetTileGroupByName("TileGroup1").GetTileItemByName("OBJETOS").Tag = item.Tag And String.Compare(item.Permiso, "N", False) = 0 Then
        '        TileControl1.GetTileGroupByName("TileGroup1").GetTileItemByName("OBJETOS").Visible = False
        '    End If
        '    If TileControl1.GetTileGroupByName("TileGroup1").GetTileItemByName("PERMISOS").Tag = item.Tag And String.Compare(item.Permiso, "N", False) = 0 Then
        '        TileControl1.GetTileGroupByName("TileGroup1").GetTileItemByName("PERMISOS").Visible = False
        '    End If
        '    If TileControl1.GetTileGroupByName("TileGroup1").GetTileItemByName("USUARIOROL").Tag = item.Tag And String.Compare(item.Permiso, "N", False) = 0 Then
        '        TileControl1.GetTileGroupByName("TileGroup1").GetTileItemByName("USUARIOROL").Visible = False
        '    End If
        '    If TileControl1.GetTileGroupByName("TileGroup1").GetTileItemByName("VERTODO").Tag = item.Tag And String.Compare(item.Permiso, "N", False) = 0 Then
        '        TileControl1.GetTileGroupByName("TileGroup1").GetTileItemByName("VERTODO").Visible = False
        '    End If
        '    If TileControl1.GetTileGroupByName("TileGroup3").GetTileItemByName("AUDITORIA").Tag = item.Tag And String.Compare(item.Permiso, "N", False) = 0 Then
        '        TileControl1.GetTileGroupByName("TileGroup3").GetTileItemByName("AUDITORIA").Visible = False
        '    End If
        '    If TileControl1.GetTileGroupByName("TileGroup3").GetTileItemByName("AUDITORIACORTES").Tag = item.Tag And String.Compare(item.Permiso, "N", False) = 0 Then
        '        TileControl1.GetTileGroupByName("TileGroup3").GetTileItemByName("AUDITORIACORTES").Visible = False
        '    End If
        '    If TileControl1.GetTileGroupByName("TileGroup3").GetTileItemByName("BAJAOP").Tag = item.Tag And String.Compare(item.Permiso, "N", False) = 0 Then
        '        TileControl1.GetTileGroupByName("TileGroup3").GetTileItemByName("BAJAOP").Visible = False
        '    End If
        '    If TileControl1.GetTileGroupByName("TileGroup3").GetTileItemByName("MOVIMAVIOS").Tag = item.Tag And String.Compare(item.Permiso, "N", False) = 0 Then
        '        TileControl1.GetTileGroupByName("TileGroup3").GetTileItemByName("MOVIMAVIOS").Visible = False
        '    End If
        '    If TileControl1.GetTileGroupByName("TileGroup1").GetTileItemByName("AUTORIZACIONES").Tag = item.Tag And String.Compare(item.Permiso, "N", False) = 0 Then
        '        TileControl1.GetTileGroupByName("TileGroup1").GetTileItemByName("AUTORIZACIONES").Visible = False
        '    End If
        'Next
    End Sub

    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles USUARIOS.ItemClick
        FrUsuarios.Show()
    End Sub



    Private Sub TileItem2_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles ROLES.ItemClick
        FrRoles.Show()
    End Sub

    Private Sub TileItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles OBJETOS.ItemClick
        FrObjetos.Show()
    End Sub

    Private Sub TileItem4_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles PERMISOS.ItemClick
        FrPermisos.Show()
    End Sub

    Private Sub TileItem5_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles USUARIOROL.ItemClick
        FrUsuarioPorRol.Show()
    End Sub

    Private Sub VertodoItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles VERTODO.ItemClick
        FrVerSeguridad.Show()
    End Sub



    Private Sub FrSeguridad_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    '    Private Sub CheckEdit1_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckStateChanged
    '        If CheckEdit1.CheckState = CheckState.Checked Then
    '#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance

    '            If MsgBox("Se procedera a HABILITAR a los usuarios del Sistema de Compras", vbYesNo) = vbNo Then
    '                'CheckEdit1.CheckState = CheckState.Checked
    '                Return
    '            Else
    '                Dim activar = Session1.ExecuteNonQuery("Update [MontagneAdministracion].[dbo].[Usuarios] SET [Habilitado]='1' WHERE ([UsuarioID]<>'admin')")
    '                CheckEdit1.Text = "USUARIOS HABILITADOS!"

    '            End If
    '        ElseIf CheckEdit1.CheckState = CheckState.Unchecked Then

    '            If MsgBox("Se procedera a DESHABILITAR a los usuarios del Sistema de Compras", vbYesNo) = vbNo Then
    '                CheckEdit1.CheckState = CheckState.Unchecked
    '                Return
    '            Else
    '                Dim desactivar = Session1.ExecuteNonQuery("Update [MontagneAdministracion].[dbo].[Usuarios] SET [Habilitado]='0' WHERE ([UsuarioID]<>'admin')")
    '                CheckEdit1.Text = "USUARIOS INHABILITADOS"
    '            End If

    '        End If
    '    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckEdit1_EditValueChanging(sender As Object, e As ChangingEventArgs)

    End Sub

    Private Sub TrackBarControl1_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToggleSwitch1_Toggled(sender As Object, e As EventArgs) Handles ToggleSwitch1.Toggled
        If ToggleSwitch1.IsOn = True Then
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance

            If MsgBox("Se procedera a HABILITAR a los usuarios del Sistema de Compras", vbYesNo) = vbNo Then
                'CheckEdit1.CheckState = CheckState.Checked
                Return
            Else
                Dim activar = Session1.ExecuteNonQuery("Update [MontagneAdministracion].[dbo].[Usuarios] SET [Habilitado]='1' WHERE ([UsuarioID]<>'admin')")
                ' CheckEdit1.Text = "USUARIOS HABILITADOS!"
                LabelControl1.Text = "Los usuarios estan HABILITADOS"

            End If
        ElseIf ToggleSwitch1.IsOn = False Then

            If MsgBox("Se procedera a INHABILITAR a los usuarios del Sistema de Compras", vbYesNo) = vbNo Then
                'CheckEdit1.CheckState = CheckState.Unchecked
                Return
            Else
                Dim desactivar = Session1.ExecuteNonQuery("Update [MontagneAdministracion].[dbo].[Usuarios] SET [Habilitado]='0' WHERE ([UsuarioID]<>'admin')")
                LabelControl1.Text = "Los usuarios estan INHABILITADOS"
                '  CheckEdit1.Text = "USUARIOS INHABILITADOS"
            End If
        End If
    End Sub

    Private Sub TileItem1_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        FrDatabase.Show()
    End Sub

    Private Sub TileItem1_ItemClick_2(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem1.ItemClick
        FrDatabase.Show()
    End Sub

    Private Sub ToggleSwitch2_Toggled(sender As Object, e As EventArgs) Handles ToggleSwitch2.Toggled
        If ToggleSwitch2.IsOn = True Then
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance

            If MsgBox("Se lanzara la nueva version a los usuarios del Sistema de Compras", vbYesNo) = vbNo Then
                Return
            Else
                Dim activar = Session1.ExecuteNonQuery("Update [MontagneAdministracion].[dbo].[Equipos] SET [Actualizo]='0' WHERE ([Usuario]<>'admin')")
                LabelControl2.Text = "Actualizaciones Activadas!"
            End If
        ElseIf ToggleSwitch2.IsOn = False Then

            If MsgBox("Se desactivaran las actualizaciones a los usuarios del Sistema de Compras", vbYesNo) = vbNo Then
                Return
            Else
                Dim desactivar = Session1.ExecuteNonQuery("Update [MontagneAdministracion].[dbo].[Equipos] SET [Actualizo]='1' WHERE ([Usuario]<>'admin')")
                LabelControl2.Text = "Actualizaciones Desactivadas!"
            End If
        End If
    End Sub

    Private Sub TileItem3_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem3.ItemClick
        FrActualizaciones.show
    End Sub
End Class