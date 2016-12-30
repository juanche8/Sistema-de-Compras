<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrVerSeguridad
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataViewProperty1 As DevExpress.Xpo.DataViewProperty = New DevExpress.Xpo.DataViewProperty()
        Dim DataViewProperty2 As DevExpress.Xpo.DataViewProperty = New DevExpress.Xpo.DataViewProperty()
        Dim DataViewProperty3 As DevExpress.Xpo.DataViewProperty = New DevExpress.Xpo.DataViewProperty()
        Dim DataViewProperty4 As DevExpress.Xpo.DataViewProperty = New DevExpress.Xpo.DataViewProperty()
        Dim DataViewProperty5 As DevExpress.Xpo.DataViewProperty = New DevExpress.Xpo.DataViewProperty()
        Dim DataViewProperty6 As DevExpress.Xpo.DataViewProperty = New DevExpress.Xpo.DataViewProperty()
        Dim DataViewProperty7 As DevExpress.Xpo.DataViewProperty = New DevExpress.Xpo.DataViewProperty()
        Dim DataViewProperty8 As DevExpress.Xpo.DataViewProperty = New DevExpress.Xpo.DataViewProperty()
        Dim DataViewProperty9 As DevExpress.Xpo.DataViewProperty = New DevExpress.Xpo.DataViewProperty()
        Dim DataViewProperty10 As DevExpress.Xpo.DataViewProperty = New DevExpress.Xpo.DataViewProperty()
        Dim DataViewProperty11 As DevExpress.Xpo.DataViewProperty = New DevExpress.Xpo.DataViewProperty()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrVerSeguridad))
        Me.XpDataView1 = New DevExpress.Xpo.XPDataView(Me.components)
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.limpiafiltros = New DevExpress.XtraEditors.SimpleButton()
        Me.imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsuarioID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContraseña = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApellidos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdRol = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRol = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcionRol = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObjeto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcionObjeto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPermiso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        CType(Me.XpDataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XpDataView1
        '
        DataViewProperty1.Name = "Row"
        DataViewProperty1.ValueType = GetType(Long)
        DataViewProperty2.Name = "UsuarioID"
        DataViewProperty2.ValueType = GetType(String)
        DataViewProperty3.Name = "Contraseña"
        DataViewProperty3.ValueType = GetType(String)
        DataViewProperty4.Name = "Apellidos"
        DataViewProperty4.ValueType = GetType(String)
        DataViewProperty5.Name = "Nombres"
        DataViewProperty5.ValueType = GetType(String)
        DataViewProperty6.Name = "IdRol"
        DataViewProperty6.ValueType = GetType(Integer)
        DataViewProperty7.Name = "Rol"
        DataViewProperty7.ValueType = GetType(String)
        DataViewProperty8.Name = "DescripcionRol"
        DataViewProperty8.ValueType = GetType(String)
        DataViewProperty9.Name = "Objeto"
        DataViewProperty9.ValueType = GetType(String)
        DataViewProperty10.Name = "DescripcionObjeto"
        DataViewProperty10.ValueType = GetType(String)
        DataViewProperty11.Name = "Permiso"
        DataViewProperty11.ValueType = GetType(String)
        Me.XpDataView1.Properties.AddRange(New DevExpress.Xpo.DataViewProperty() {DataViewProperty1, DataViewProperty2, DataViewProperty3, DataViewProperty4, DataViewProperty5, DataViewProperty6, DataViewProperty7, DataViewProperty8, DataViewProperty9, DataViewProperty10, DataViewProperty11})
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
        '
        'limpiafiltros
        '
        Me.limpiafiltros.Location = New System.Drawing.Point(14, 13)
        Me.limpiafiltros.Name = "limpiafiltros"
        Me.limpiafiltros.Size = New System.Drawing.Size(75, 23)
        Me.limpiafiltros.TabIndex = 12
        Me.limpiafiltros.Text = "Limpiar Filtros"
        Me.limpiafiltros.ToolTip = "Limpia los filtros aplicados por columnas"
        '
        'imprimir
        '
        Me.imprimir.Location = New System.Drawing.Point(95, 13)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(75, 23)
        Me.imprimir.TabIndex = 11
        Me.imprimir.Text = "Imprimir"
        Me.imprimir.ToolTip = "Abre la previsualizacoion de impresion y exportacion, Imprime el contenido visual" &
    "izado en la grilla"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SimpleButton2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.limpiafiltros)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.imprimir)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1119, 481)
        Me.SplitContainerControl1.SplitterPosition = 43
        Me.SplitContainerControl1.TabIndex = 13
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(176, 13)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(29, 23)
        Me.SimpleButton2.TabIndex = 19
        Me.SimpleButton2.Text = "SimpleButton2"
        Me.SimpleButton2.ToolTip = "Ayuda"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.XpDataView1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(1119, 432)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRow, Me.colUsuarioID, Me.colContraseña, Me.colApellidos, Me.colNombres, Me.colIdRol, Me.colRol, Me.colDescripcionRol, Me.colObjeto, Me.colDescripcionObjeto, Me.colPermiso})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindNullPrompt = "Ingrese el texto a buscar"
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colRow
        '
        Me.colRow.FieldName = "Row"
        Me.colRow.Name = "colRow"
        '
        'colUsuarioID
        '
        Me.colUsuarioID.Caption = "Usuario"
        Me.colUsuarioID.FieldName = "UsuarioID"
        Me.colUsuarioID.Name = "colUsuarioID"
        Me.colUsuarioID.Visible = True
        Me.colUsuarioID.VisibleIndex = 0
        Me.colUsuarioID.Width = 107
        '
        'colContraseña
        '
        Me.colContraseña.FieldName = "Contraseña"
        Me.colContraseña.Name = "colContraseña"
        Me.colContraseña.Visible = True
        Me.colContraseña.VisibleIndex = 1
        Me.colContraseña.Width = 107
        '
        'colApellidos
        '
        Me.colApellidos.FieldName = "Apellidos"
        Me.colApellidos.Name = "colApellidos"
        Me.colApellidos.Visible = True
        Me.colApellidos.VisibleIndex = 2
        Me.colApellidos.Width = 130
        '
        'colNombres
        '
        Me.colNombres.FieldName = "Nombres"
        Me.colNombres.Name = "colNombres"
        Me.colNombres.Visible = True
        Me.colNombres.VisibleIndex = 3
        Me.colNombres.Width = 158
        '
        'colIdRol
        '
        Me.colIdRol.FieldName = "IdRol"
        Me.colIdRol.Name = "colIdRol"
        Me.colIdRol.Visible = True
        Me.colIdRol.VisibleIndex = 4
        Me.colIdRol.Width = 43
        '
        'colRol
        '
        Me.colRol.FieldName = "Rol"
        Me.colRol.Name = "colRol"
        Me.colRol.Visible = True
        Me.colRol.VisibleIndex = 5
        Me.colRol.Width = 103
        '
        'colDescripcionRol
        '
        Me.colDescripcionRol.FieldName = "DescripcionRol"
        Me.colDescripcionRol.Name = "colDescripcionRol"
        Me.colDescripcionRol.Visible = True
        Me.colDescripcionRol.VisibleIndex = 6
        Me.colDescripcionRol.Width = 103
        '
        'colObjeto
        '
        Me.colObjeto.FieldName = "Objeto"
        Me.colObjeto.Name = "colObjeto"
        Me.colObjeto.Visible = True
        Me.colObjeto.VisibleIndex = 7
        Me.colObjeto.Width = 103
        '
        'colDescripcionObjeto
        '
        Me.colDescripcionObjeto.FieldName = "DescripcionObjeto"
        Me.colDescripcionObjeto.Name = "colDescripcionObjeto"
        Me.colDescripcionObjeto.Visible = True
        Me.colDescripcionObjeto.VisibleIndex = 8
        Me.colDescripcionObjeto.Width = 169
        '
        'colPermiso
        '
        Me.colPermiso.FieldName = "Permiso"
        Me.colPermiso.Name = "colPermiso"
        Me.colPermiso.Visible = True
        Me.colPermiso.VisibleIndex = 9
        Me.colPermiso.Width = 52
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'FrVerSeguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 481)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrVerSeguridad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USUARIOS, ROLES Y PERMISOS"
        CType(Me.XpDataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XpDataView1 As DevExpress.Xpo.XPDataView
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents limpiafiltros As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuarioID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContraseña As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApellidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdRol As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRol As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcionRol As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObjeto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcionObjeto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPermiso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
