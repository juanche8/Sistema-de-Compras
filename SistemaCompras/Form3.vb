Imports System.IO

Public Class visor

    Dim direct = Application.StartupPath & "\Dashboards"
    Private Sub visor_load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cargacombo()
    End Sub

    Private Sub Cargacombo()

        Dim fileEntries() As String = Directory.GetFiles(direct, "*.xml")
        ComboBoxEdit1.Properties.Items.Clear()
        For Each fileName As String In fileEntries
            ComboBoxEdit1.Properties.Items.Add(Path.GetFileName(fileName))
        Next
    End Sub
    Private Sub ComboBoxEdit1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.SelectedValueChanged
       Try
            DashboardViewer1.DashboardSource = direct & "\" & ComboBoxEdit1.Text
            Catch ex As Exception
            End try
    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged

    End Sub
End Class