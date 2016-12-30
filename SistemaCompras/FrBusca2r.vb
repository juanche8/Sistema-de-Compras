Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraEditors.Controls
Public Class FrBusca2r
    Public Session1 As Session = XpoHelper.GetNewSession()
    Private Sub FrBusca2r_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        TextEdit1.Focus()
    End Sub
    Private Sub FrBusca2r_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xpsector.Session = Session1
        XpCollectionIdped.Session = Session1
        XpCollectionPedDet.Session = Session1
        XpCollectionestados.Session = Session1
        'Dim getrecords As SelectedData = Session1.ExecuteQuery("Select * from VistaPedidosDetalle")
        ''XpDataView1.LoadData(getrecords)
        'XpDataView1.LoadData(getrecords)
        Me.ActiveControl = textedit1
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        XpCollectionIdped.CriteriaString = "IdPedido = " &  Label1.Text
        XpCollectionPedDet.CriteriaString = "IdPedido = " &  Label1.Text
        BarCodeControl1.Text = Label1.text
    End Sub
   
    Private Sub textedit1_TextChanged(sender As Object, e As EventArgs) Handles textedit1.TextChanged
        
        If TextEdit1.Text.Length >3 Then
            
            Label1.text =TextEdit1.text 
             TextEdit1.SelectionStart = 0
            TextEdit1.SelectionLength = Label1.text.length
        Try
            
        XpCollectionIdped.CriteriaString = "IdPedido = " & Label1.text 
        XpCollectionPedDet.CriteriaString = "IdPedido = " &  Label1.text 
        BarCodeControl1.Text = Label1.text
                
           
         Catch ex As Exception      
            End try
        End If
         
    End Sub
      Private Sub Textedit1KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textedit1.KeyPress
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
    End Sub
End Class
