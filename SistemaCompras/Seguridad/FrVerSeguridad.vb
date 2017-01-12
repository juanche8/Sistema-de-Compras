Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports SistemaCompras.MontagneAdministracion

Public Class FrVerSeguridad

    Public Session1 As Session = XpoHelper.GetNewSession()
    Dim querylinq As New XPQuery(Of VerUsuariorolobjetopermiso)(Session1)

    Private Sub FrVerSeguridad_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub FrVerSeguridad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resultSet As SelectedData = Session1.ExecuteQuery("SELECT * from VerUsuariorolobjetopermiso")
        XpDataView1.LoadData(resultSet)
    End Sub

    Private Sub ImprimirClick(sender As Object, e As EventArgs) Handles imprimir.Click

        Dim ps = New PrintingSystem()
        Dim compositeLink = New CompositeLink() With {
            .PrintingSystem = ps
        }
        Dim link As PrintableComponentLink = New PrintableComponentLink() With {
                    .Component = GridControl1
                }
        With compositeLink
            .Links.Add(link)
            .RtfReportHeader = "         USUARIOS, ROLES Y PERMISOS
"
            .CreateDocument()
            .ShowPreview()
        End With
    End Sub

    Private Sub LimpiafiltrosClick(sender As Object, e As EventArgs) Handles limpiafiltros.Click
        GridView1.ClearColumnsFilter()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim path = IO.Path.Combine(Application.StartupPath, "MontagneProduccion.chm")
        Help.ShowHelp(ParentForm, path, HelpNavigator.TableOfContents)
    End Sub
End Class