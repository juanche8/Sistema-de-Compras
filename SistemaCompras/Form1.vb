Imports System.Collections
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports System
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class Form1
    Dim i As Integer
    Public Session1 As Session = XpoHelper.GetNewSession()


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)


        For x = 0 To CheckedListBoxControl1.ItemCount - 1
            Try
                Dim email As String = Session1.ExecuteScalar("Select Email  from Proveedores where Email is not null AND Email <> ''  and RazonSocial like '" & CheckedListBoxControl1.GetDisplayItemValue(x) & "'").ToString
            Catch ex As Exception
                If x = 0 Then
                    MsgBox("Solo se enviaran mails a los Proveedores que quedan seleccionados " & vbNewLine & "debido a que el resto no poseen correos electronicos asignados", vbInformation)
                Else
                End If
                CheckedListBoxControl1.SetItemChecked(x, CheckState.Unchecked)
            End Try
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XpCollection1.Session = Session1
        prods.Session = Session1
    End Sub

    Private Sub PopupContainerEdit1_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckedListBoxControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxControl1.SelectedIndexChanged

    End Sub

    Sub CheckedListBoxControl1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBoxControl1.ItemCheck
        ' TextEdit1.Text = CheckedListBoxControl1.Text

    End Sub

    Private Sub CheckedListBoxControl1_ItemChecking(sender As Object, e As ItemCheckingEventArgs) Handles CheckedListBoxControl1.ItemChecking
        Dim i = CheckedListBoxControl1.Text

        TextEdit1.Text = i.ToString + "," + TextEdit1.Text
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Dim drv As String = Session1.ExecuteScalar("SELECT CONVERT(VARCHAR(25),DATEADD(DAY,-(DAY(GETDATE())), DATEADD(MONTH,1,GETDATE())+1),105) First_Date_Next_Month;")
        MsgBox(drv)
    End Sub 'Main

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim cod As String
        Dim cod2 As string
        Dim tags As New XtraReport1()
        Dim tool As ReportPrintTool = New ReportPrintTool(tags)
        cod = Session1.ExecuteScalar("select CodigoAlfa from ProductosProduccion where CodigoAlfa = '" & prod1.Text & "'")

        If GridView2.SelectedRowsCount = 1 Then

           tags.FilterString = "CodigoAlfa ='" & GridView2.GetFocusedRowCellDisplayText(colCodigoAlfa) & "'"
            tool.Report.ShowPreviewDialog()
           prods.reload()
        End if
        If GridView2.SelectedRowsCount > 1 Then
           Dim y As Integer = Session1.ExecuteScalar("Select Count(CodigoAlfa) from ProductosProduccion where CodigoAlfa between '" & prod1.Text & "' and  '" & prod2.Text & "'")
            'Dim z As ilist =  Session1.ExecuteScalar("Select CodigoProducto from Productos where CodigoProducto between '" & prod1.Text & "' and  '" & prod2.Text & "'")
            ' Dim x As ilist =  GridLookUpEdit1View.GetSelectedRows().ToList
            Dim stra As String
            'For s = 0 To y - 1
            '    try
            '        Dim lista = Session1.ExecuteScalar("Select CodigoAlfa from ProductosProduccion where CodigoAlfa = '" & stra & "'")
            '        stra = stra & "CodigoAlfa = '" & lista & "' or "
            '    Catch ex As Exception

            '    End try
            'Next
            Dim x As IList = GridView2.GetSelectedRows().ToList
           ' Dim stra As String
            For s = 0 To x.Count - 1

                Dim consulta = Session1.ExecuteScalar("Select CodigoAlfa from ProductosProduccion where CodigoAlfa = '" & GridView2.GetRowCellValue(x.Item(s), colCodigoAlfa) & "'")
                stra = stra & " CodigoAlfa = '" & consulta & "' or "
            Next

            stra = Mid(stra, 1, Len(stra) - 3)
            tags.FilterString = stra
            tool.Report.ShowPreviewDialog
            prods.Reload
        End If

    End Sub

    Private Sub prod1_EditValueChanged(sender As Object, e As EventArgs) Handles prod1.EditValueChanged

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged
       If ComboBoxEdit1.Text IsNot Nothing or ComboBoxEdit2.Text IsNot Nothing Or ComboBoxEdit3.Text IsNot Nothing Or ComboBoxEdit4.Text Isnot nothing  Then
            prods.CriteriaString = "Detalle like '%" &ComboBoxEdit1.Text &  "%' and Detalle like '%" & ComboBoxEdit2.Text & "%' and Detalle like '%" &ComboBoxEdit3.Text &  "%' and Detalle like '%" & ComboBoxEdit4.Text & "%'"
        End If
        
    End Sub

    Private Sub ComboBoxEdit2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit2.SelectedIndexChanged
        If ComboBoxEdit1.Text IsNot Nothing or ComboBoxEdit2.Text IsNot Nothing Or ComboBoxEdit3.Text IsNot Nothing Or ComboBoxEdit4.Text Isnot nothing  Then
            prods.CriteriaString = "Detalle like '%" &ComboBoxEdit1.Text &  "%' and Detalle like '%" & ComboBoxEdit2.Text & "%' and Detalle like '%" &ComboBoxEdit3.Text &  "%' and Detalle like '%" & ComboBoxEdit4.Text & "%'"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
      
    End Sub

    Private Sub ComboBoxEdit3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit3.SelectedIndexChanged
        If ComboBoxEdit1.Text IsNot Nothing or ComboBoxEdit2.Text IsNot Nothing Or ComboBoxEdit3.Text IsNot Nothing Or ComboBoxEdit4.Text Isnot nothing  Then
            prods.CriteriaString = "Detalle like '%" &ComboBoxEdit1.Text &  "%' and Detalle like '%" & ComboBoxEdit2.Text & "%' and Detalle like '%" &ComboBoxEdit3.Text &  "%' and Detalle like '%" & ComboBoxEdit4.Text & "%'"
        End If
    End Sub

    Private Sub ComboBoxEdit4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit4.SelectedIndexChanged
        If ComboBoxEdit1.Text IsNot Nothing or ComboBoxEdit2.Text IsNot Nothing Or ComboBoxEdit3.Text IsNot Nothing Or ComboBoxEdit4.Text Isnot nothing  Then
            prods.CriteriaString = "Detalle like '%" &ComboBoxEdit1.Text &  "%' and Detalle like '%" & ComboBoxEdit2.Text & "%' and Detalle like '%" &ComboBoxEdit3.Text &  "%' and Detalle like '%" & ComboBoxEdit4.Text & "%'"
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        ComboBoxEdit1.Text = ""
        ComboBoxEdit2.Text = ""
        ComboBoxEdit3.Text = ""
        ComboBoxEdit4.Text = ""

    End Sub
End Class