Imports DevExpress.Xpo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrPedidos_IMP
    Dim nped As Integer
    Public Session1 As Session = XpoHelper.GetNewSession()
    Dim op = New MontagneAdministracion.Pedidos_Imp(Session1)
    Dim a As double
    Private Sub FrPedidos_IMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cabecera.Session = Session1
        Detalles.Session = Session1
        XpColProductos.Session = Session1
        XpColProveedores.Session = Session1



        '  Else
        ' labelestado.Text = "Aprobado"
        '  End If
        Labelresponsable.Text = Responsable                                  ' asignamos los valores a los controles del formulario
        Labelfechapedido.Text = Now.Date.ToShortDateString                   ' al label se le asigna la fecha actual en formato corto
   

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
        nped = Session1.ExecuteScalar("select max(IdPedido) from Pedidos_Imp")
        Labelnumeropedido.Text = nped
        GridView1.OptionsView.RowAutoHeight = True
    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetRowCellValue(e.RowHandle, "FechaPedido", Mid(Now.Date.ToShortDateString, 1, 10))
        GridView1.SetRowCellValue(e.RowHandle, "Sector", Sector)
        GridView1.SetRowCellValue(e.RowHandle, "Responsable", Responsable)
        GridView1.SetRowCellValue(e.RowHandle, "IdPedido", nped)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        MsgBox(a)
    End Sub

    Private Sub FrPedidos_IMP_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub
    Private Sub gridView1_CustomDrawFooterCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles GridView1.CustomDrawFooterCell
        Dim summary As GridSummaryItem = e.Info.SummaryItem
        ' Obtain the total summary's value.
        Dim summaryValue As Double = Convert.ToDouble(summary.SummaryValue)
        'Dim summaryText As String = String.Format("{0} {1} = {2:c2}", summary.SummaryType, e.Column.GetCaption(), summaryValue)
       ' e.Info.DisplayText = summaryText
        a = summaryValue
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If ComboBoxEdit2.text = "" Then
            MsgBox("Selecciona una forma de pago")
        End If
        If ComboBoxEdit2.Text = "30% - 70%" Then
            LabelControl11.Text =  a*.30
            LabelControl12.text = a*.70
        End If
         If ComboBoxEdit2.Text = "50% - 50%" Then
            LabelControl11.Text =  a*.50
            LabelControl12.text = a*.50
        End If
         If ComboBoxEdit2.Text = "100%" Then
            LabelControl12.Text =  a
            LabelControl11.Text = ""
            
        End If
    End Sub
End Class