<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrActualizaciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrActualizaciones))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.equipos = New DevExpress.Xpo.XPCollection(Me.components)
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreEquipo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualizo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.equipos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemSpinEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.equipos
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(508, 517)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colNombreEquipo, Me.colUsuario, Me.colActualizo})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'equipos
        '
        Me.equipos.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Equipos)
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Width = 35
        '
        'colNombreEquipo
        '
        Me.colNombreEquipo.FieldName = "NombreEquipo"
        Me.colNombreEquipo.Name = "colNombreEquipo"
        Me.colNombreEquipo.Visible = true
        Me.colNombreEquipo.VisibleIndex = 0
        Me.colNombreEquipo.Width = 355
        '
        'colUsuario
        '
        Me.colUsuario.FieldName = "Usuario"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.Visible = true
        Me.colUsuario.VisibleIndex = 1
        Me.colUsuario.Width = 483
        '
        'colActualizo
        '
        Me.colActualizo.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colActualizo.FieldName = "Actualizo"
        Me.colActualizo.Name = "colActualizo"
        Me.colActualizo.Visible = true
        Me.colActualizo.VisibleIndex = 2
        Me.colActualizo.Width = 233
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = false
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'FrActualizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 517)
        Me.Controls.Add(Me.GridControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FrActualizaciones"
        Me.Text = "Administrador de Actualizaciones"
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.equipos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemSpinEdit1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents equipos As DevExpress.Xpo.XPCollection
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreEquipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualizo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
End Class
