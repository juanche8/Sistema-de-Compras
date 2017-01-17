Imports DevExpress.Xpo
Imports SistemaCompras.MontagneAdministracion
Imports DevExpress.XtraBars.Alerter
Imports System.IO


Public Class FrPrincipalCompras
    Public Shared ReadOnly Property Today As Date
    Dim loPSI As New ProcessStartInfo
    Dim loProceso As New Process
    Public Session1 As Session = XpoHelper.GetNewSession()
    Dim querylinq As New XPQuery(Of Usuarios)(Session1)
    Dim vencer = Session1.ExecuteScalar("SELECT count(*) from Pedidos where Estado = 2 and AutorizadoPor is not null  and FechaRecepcion <> CURRENT_TIMESTAMP and FechaRecepcion < DATEADD(day,3,CURRENT_TIMESTAMP) ")
    Dim aprobados = Session1.ExecuteScalar("SELECT count(*) from Pedidos where  Estado = 2 AND FechaAprobacion < GETDATE()-1")


    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem1.ItemClick
        FrMonedas.Show()
    End Sub
    Private Sub TileItem2_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem2.ItemClick
        Idprod = Nothing
        FrProductos.show()
    End Sub

    Private Sub TileItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem3.ItemClick
        FrRubros.show()
    End Sub

    Private Sub TileItem4_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem4.ItemClick
        FrMotivosBaja.Show()
    End Sub

    Private Sub TileItem6_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem6.ItemClick
        Do

            Dim frmpedidos As FrPedidos = New FrPedidos
            frmpedidos.ShowDialog()
        Loop While Back <> 0

        'FrPedidos.Show()
    End Sub

    Private Sub TileItem9_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem9.ItemClick
        FrProveedores2.Show()
    End Sub

    Private Sub TileItem11_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem11.ItemClick
        FrContactos.Show()
    End Sub

    Private Sub TileItem12_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem12.ItemClick
        FrListasPrecios.Show()
    End Sub

    Private Sub TileItem5_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem5.ItemClick
        FrSectores.Show()
    End Sub

    Private Sub TileItem10_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem10.ItemClick
        FrConsumo.Show()
    End Sub

    Private Sub TileItem7_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem7.ItemClick
        FrBajasMateriales.Show()
    End Sub

    Private Sub TileItem8_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem8.ItemClick
        FrStock.Show()
    End Sub

    Private Sub TileItem13_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem13.ItemClick
        FrMasterDetailRecepciones.Show()
    End Sub

    Private Sub TileItem14_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem14.ItemClick
        Do

            Dim frmpresupuestos As FrPresupuestos = New FrPresupuestos
            frmpresupuestos.ShowDialog()
        Loop While Back <> 0
        'FrPresupuestos.Show()
    End Sub

    Private Sub TileItem15_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem15.ItemClick
        FrPedidosValorizados.Show()
    End Sub

    Private Sub TileItem16_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem16.ItemClick
        ' Aprobar = 1
        FrPedidosValorizados.Show()
    End Sub

    Private Sub TileItem17_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem17.ItemClick
        FrODC.show()
        'Do

        '    Dim frodc As FrODC = New FrODC
        '    frodc.ShowDialog()
        'Loop While Back <> 0
    End Sub

    Private Sub TileItem18_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        FrMasterDetailRecepciones.Show()
    End Sub

    Private Sub TileItem19_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        FrConsumo.Show()
    End Sub

    Private Sub TileItem20_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem20.ItemClick
        FrPivotPedidos.Show()
    End Sub

    Private Sub TileControl1_Click(sender As Object, e As EventArgs) Handles TileControl1.Click
        ' Dim habilitado As Integer
        Dim inhabilitado = Session1.ExecuteScalar("select Habilitado from Usuarios where UsuarioID = '" & Usuario & "'")
        If inhabilitado = 0 Then
            MsgBox("Se ha inhabilitado tu cuenta temporalmente!", vbExclamation)
            LoginForm1.Show()
            Me.Hide()


        End If
    End Sub

    Private Sub TileItem18_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem18.ItemClick
        FrSeguridad.ShowDialog()
    End Sub

    Private Sub TileItem19_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem19.ItemClick
        FrMasterDetailPedidos.Show()
    End Sub
    Private Sub FrPrincipalCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Disable Warning BC40000
        Me.Text = "SISTEMA DE COMPRAS - " & Sector.ToUpper
        If Cotiza = 1 Then
            LabelControl1.Text = "Bienvenida, " & Responsable
            'LabelControl4.Text = "Bienvenida, " & Responsable
        Else
            LabelControl1.Text = "Bienvenido, " & Responsable
            ' LabelControl4.Text = "Bienvenida, " & Responsable
        End If
       
        If Cotiza = 0 Then
            PARAMETRICAS.Visible = False
            TileGroup3.Visible = False
            CONSUMOS.Visible = False
            Scale(0.5, 0.5)
        Else
            If Cotiza = 3 Then
                CONSUMOS.Visible = False
                PARAMETRICAS.Visible = False
                Scale(0.7, 0.7)
            End If
        End If
        If Cotiza = 1 Then
            TileItem16.Visible = False
            TileItem25.Visible = False
            labelvencimiento.Visible = True
            SimpleButton1.Visible = True
            SimpleButton2.Visible = True
            ' TileItem16.Visible = True
            'AlertControl1.Show(vencer)
            Dim info As AlertInfo = New AlertInfo("Solicitudes pendientes", "Tenés <Color=red>" & vencer & "</color> solicitud aprobada por vencer.")
            Dim info2 As AlertInfo = New AlertInfo("Solicitudes pendientes", "Tenés <Color=red>" & vencer & "</color> solicitudes aprobadas por vencer.")

            'AlertControl1.Show(Me, info)
            If vencer = 0 Then
            Else
                If vencer = 1 Then
                    AlertControl1.Show(Me, info)
                    labelvencimiento.Text = "Tenés <Color=red>" & vencer & "</color> solicitud aprobada a punto por vencer."
                Else
                    AlertControl1.Show(Me, info2)
                    labelvencimiento.Text = "Tenés <Color=red>" & vencer & "</color> solicitudes aprobadas a punto vencer."
                End If
            End If

        End If
         If Sectorid = 14 Then
            PARAMETRICAS.Visible = False
            Tileitem5.Visible = False
            Tileitem8.Visible = False
            CONSUMOS.Visible = False
            TileItem16.Visible = False
            TileItem25.Visible = False
            PEDIDOS.Visible = False

            TileItem27.Visible = true
            TileItem28.Visible = true
            Scale(0.5, 0.5)
        End If
        If Responsable = "Diaz Juan J" Then
            admbutton.Visible = True
            LabelControl1.Text = "Bienvenido, " & Responsable
            TileItem25.Visible = True
            TileItem16.Visible = True
            TileItem25.Visible = True
            SimpleButton4.Visible = True
            SimpleButton5.Visible = True
        End If
    End Sub


    Private Sub FrPrincipalCompras_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        FrBusca2r.Show()

    End Sub

    Private Sub TileItem25_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem25.ItemClick
        FrBusca2r.Show()
    End Sub

    Private Sub AlertControl1_BeforeFormShow(sender As Object, e As AlertFormEventArgs) Handles AlertControl1.BeforeFormShow
        e.AlertForm.OpacityLevel = 1

    End Sub

    Private Sub AlertControl1_ButtonClick(sender As Object, e As AlertButtonClickEventArgs) Handles AlertControl1.ButtonClick
        FrPresupuestos.Show()
    End Sub

    Private Sub FrPrincipalCompras_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Refresh()
    End Sub

    Private Sub FrPrincipalCompras_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Refresh()
    End Sub

    Private Sub ColorPickEdit1_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ColorEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles ColorEdit1.EditValueChanged
        BackColor = ColorEdit1.EditValue
        SimpleButton1.BackColor = BackColor

        SimpleButton2.BackColor = BackColor
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim nuevos = Session1.ExecuteScalar("SELECT count(*) from Pedidos where  Estado = 2 and AutorizadoPor is not null AND FechaAprobacion < GETDATE()")
        Dim vencer3 = nuevos
        If Cotiza = 1 Then
            labelvencimiento.Refresh()
            Dim info As AlertInfo = New AlertInfo("<b>Solicitud nueva!</b>", "Tienes <Color=red>" & vencer3 & "</color> solicitud autorizada.")
            Dim info2 As AlertInfo = New AlertInfo("<b>Solicitudes nuevas!</b>", "Hay un total de <Color=red>" & vencer3 & "</color> solicitudes Autorizadas.")
            Dim info3 As AlertInfo = New AlertInfo("<b>Solicitudes nuevas!</b>", "No hay solicitudes nuevas!")
            If vencer3 = 0 Then
            Else
                If vencer3 = 1 Then
                    AlertControl2.Show(Me, info)
                Else
                    AlertControl2.Show(Me, info2)
                    If nuevos = 0 Then
                        AlertControl2.Show(Me, info3)
                    End If
                End If
            End If
            If nuevos = 0 Then
                AlertControl2.Show(Me, info3)
            End If
        End If
        labelvencimiento.Refresh()
        Dim vencer = Session1.ExecuteScalar("SELECT count(*) from Pedidos where Estado = 2 and AutorizadoPor is not null  and FechaRecepcion <> CURRENT_TIMESTAMP and FechaRecepcion < DATEADD(day,3,CURRENT_TIMESTAMP) ")

        If vencer = 1 Then

            labelvencimiento.Text = "Tenés <Color=red>" & vencer & "</color> solicitud aprobada a punto por vencer."
        Else

            labelvencimiento.Text = "Tenés <Color=red>" & vencer & "</color> solicitudes aprobadas a punto vencer."
        End If

        'Dim myStream As Stream = Nothing
        'Dim openFileDialog1 As New OpenFileDialog()

        'openFileDialog1.InitialDirectory = "c:\"
        'openFileDialog1.Filter = "archivos de imagen (*.png)|*.png|All files (*.*)|*.*"
        'openFileDialog1.FilterIndex = 2
        'openFileDialog1.RestoreDirectory = True

        'If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    Try
        '        myStream = openFileDialog1.OpenFile()
        '        If (myStream IsNot Nothing) Then
        '            ' Insert code to read the stream here.

        '        End If
        '    Catch Ex As Exception
        '        MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
        '    Finally
        '        ' Check this again, since we need to make sure we didn't throw an exception on open.
        '        If (myStream IsNot Nothing) Then
        '            myStream.Close()
        '        End If
        '    End Try
        'End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If Cotiza = 1 Then
        '    Dim vencer = Session1.ExecuteScalar("SELECT count(*) from Pedidos where FechaRecepcion >= CURRENT_TIMESTAMP and FechaRecepcion < DATEADD(day,3,CURRENT_TIMESTAMP) and Estado = 2")
        '    TileItem16.Visible = False
        '    TileItem25.Visible = False
        '    labelvencimiento.Visible = True
        '    'AlertControl1.Show(vencer)
        '    Dim info As AlertInfo = New AlertInfo("Solicitudes pendientes", "Tenés <Color=red>" & vencer & "</color> solicitud aprobada por vencer.")
        '    Dim info2 As AlertInfo = New AlertInfo("Solicitudes pendientes", "Tenés <Color=red>" & vencer & "</color> solicitudes aprobadas por vencer.")

        '    'AlertControl1.Show(Me, info)
        '    If vencer = 0  Then
        '    Else
        '        If vencer = 1 Then
        '            AlertControl1.Show(Me, info)
        '            labelvencimiento.Text = "Tenés <Color=red>" & vencer & "</color> solicitud aprobada a punto por vencer."
        '        Else
        '            AlertControl1.Show(Me, info2)
        '            labelvencimiento.Text = "Tenés <Color=red>" & vencer & "</color> solicitudes aprobadas a punto vencer."
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        FlyoutPanel1.ShowPopup()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim cpytxt = CalcEdit1.Value

        My.Computer.Clipboard.SetText(cpytxt)

        ' MsgBox("Se ha copiado al portapapeles el numero: " & CStr(cpytxt))
        FlyoutPanel2.ShowBeakForm()
        LabelControl5.Text = "Se ha copiado el numero: " & CStr(cpytxt)
    End Sub

    Private Sub TileItem26_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem26.ItemClick

    End Sub

    Private Sub admbutton_Click(sender As Object, e As EventArgs) Handles admbutton.Click
        FrSeguridad.Show()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        diseñador.Show()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        frimage.Show()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles helpbutton.Click
        If Cotiza = 0 Then
            loPSI.FileName = Application.StartupPath & "\ayudahtml1\index.htm"
            Try
                loProceso = Process.Start(loPSI)
            Catch exp As Exception
                MessageBox.Show(exp.Message, "Se produjo un error, consulte con soporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        If Cotiza = 3 Then
            loPSI.FileName = Application.StartupPath & "\ayudahtml2\index.htm"
            Try
                loProceso = Process.Start(loPSI)
            Catch exp As Exception
                MessageBox.Show(exp.Message, "Se produjo un error, consulte con soporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        If Cotiza = 1 Then
            loPSI.FileName = Application.StartupPath & "\ayudahtml3\index.htm"
            Try
                loProceso = Process.Start(loPSI)
            Catch exp As Exception
                MessageBox.Show(exp.Message, "Se produjo un error, consulte con soporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub RatingControl1_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click
        MsgBox("Ver: " & System.Reflection. _
  Assembly.GetExecutingAssembly. _
  GetName.Version.Major & " Rev: " & System.Reflection. _
  Assembly.GetExecutingAssembly. _
  GetName.Version.Revision,, "VERSION")
    End Sub

    Private Sub TileItem27_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem27.ItemClick
        FrAprobarODC.show
    End Sub
End Class