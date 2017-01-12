<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrPermisos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrPermisos))
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.XpCollection2 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.XpCollection3 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.limpiafiltros = New DevExpress.XtraEditors.SimpleButton()
        Me.imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdRol = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdObjecto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPermiso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XpCollection1
        '
        Me.XpCollection1.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Permisos)
        '
        'XpCollection2
        '
        Me.XpCollection2.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Roles)
        '
        'XpCollection3
        '
        Me.XpCollection3.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Objetos)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar2.FloatLocation = New System.Drawing.Point(113, 441)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "AGREGAR"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "EDITAR"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "ELIMINAR"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(761, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 360)
        Me.barDockControlBottom.Size = New System.Drawing.Size(761, 26)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 360)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(761, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 360)
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
        '
        'limpiafiltros
        '
        Me.limpiafiltros.Location = New System.Drawing.Point(12, 13)
        Me.limpiafiltros.Name = "limpiafiltros"
        Me.limpiafiltros.Size = New System.Drawing.Size(75, 23)
        Me.limpiafiltros.TabIndex = 8
        Me.limpiafiltros.Text = "Limpiar Filtros"
        Me.limpiafiltros.ToolTip = "Limpia los filtros aplicados por columnas"
        '
        'imprimir
        '
        Me.imprimir.Location = New System.Drawing.Point(93, 13)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(75, 23)
        Me.imprimir.TabIndex = 7
        Me.imprimir.Text = "Imprimir"
        Me.imprimir.ToolTip = "Abre la previsualizacoion de impresion y exportacion, Imprime el contenido visual" &
    "izado en la grilla"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Rol", "Rol", 25, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.XpCollection2
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Rol"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "Id"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Objeto", "Objeto", 43, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.XpCollection3
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Objeto"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ValueMember = "Id"
        '
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Items.AddRange(New Object() {"L", "E", "N"})
        Me.RepositoryItemComboBox3.MaxLength = 1
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.XpCollection2
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "Rol"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "Id"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.XpCollection3
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "Objeto"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "Id"
        Me.RepositoryItemGridLookUpEdit2.View = Me.RepositoryItemGridLookUpEdit2View
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.DataSource = Me.XpCollection3
        Me.RepositoryItemGridLookUpEdit3.DisplayMember = "Objeto"
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.ValueMember = "Id"
        Me.RepositoryItemGridLookUpEdit3.View = Me.RepositoryItemGridLookUpEdit3View
        '
        'RepositoryItemGridLookUpEdit3View
        '
        Me.RepositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit3View.Name = "RepositoryItemGridLookUpEdit3View"
        Me.RepositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colIdRol, Me.colIdObjecto, Me.colPermiso})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GridView1.OptionsEditForm.EditFormColumnCount = 1
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 500
        Me.GridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindNullPrompt = "Ingrese el texto a buscar"
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colIdRol
        '
        Me.colIdRol.Caption = "Rol"
        Me.colIdRol.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colIdRol.FieldName = "IdRol"
        Me.colIdRol.Name = "colIdRol"
        Me.colIdRol.Visible = True
        Me.colIdRol.VisibleIndex = 0
        Me.colIdRol.Width = 215
        '
        'colIdObjecto
        '
        Me.colIdObjecto.Caption = "Objeto"
        Me.colIdObjecto.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colIdObjecto.FieldName = "IdObjeto"
        Me.colIdObjecto.Name = "colIdObjecto"
        Me.colIdObjecto.Visible = True
        Me.colIdObjecto.VisibleIndex = 1
        Me.colIdObjecto.Width = 392
        '
        'colPermiso
        '
        Me.colPermiso.Caption = "Permiso"
        Me.colPermiso.ColumnEdit = Me.RepositoryItemComboBox4
        Me.colPermiso.FieldName = "Permiso"
        Me.colPermiso.Name = "colPermiso"
        Me.colPermiso.Visible = True
        Me.colPermiso.VisibleIndex = 2
        Me.colPermiso.Width = 111
        '
        'RepositoryItemComboBox4
        '
        Me.RepositoryItemComboBox4.AutoHeight = False
        Me.RepositoryItemComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox4.Items.AddRange(New Object() {"L", "E", "N"})
        Me.RepositoryItemComboBox4.Name = "RepositoryItemComboBox4"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.XpCollection1
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridControl1.Location = New System.Drawing.Point(12, 42)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemComboBox2, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemComboBox3, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemGridLookUpEdit3, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit4, Me.RepositoryItemComboBox4})
        Me.GridControl1.Size = New System.Drawing.Size(737, 302)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.XpCollection2
        Me.RepositoryItemLookUpEdit3.DisplayMember = "Rol"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        Me.RepositoryItemLookUpEdit3.ValueMember = "Id"
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.DataSource = Me.XpCollection3
        Me.RepositoryItemLookUpEdit4.DisplayMember = "Objeto"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        Me.RepositoryItemLookUpEdit4.ValueMember = "Id"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(174, 13)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(29, 23)
        Me.SimpleButton2.TabIndex = 19
        Me.SimpleButton2.Text = "SimpleButton2"
        Me.SimpleButton2.ToolTip = "Ayuda"
        '
        'FrPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 386)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.limpiafiltros)
        Me.Controls.Add(Me.imprimir)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrPermisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PERMISOS A OBJETOS"
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents XpCollection2 As DevExpress.Xpo.XPCollection
    Friend WithEvents XpCollection3 As DevExpress.Xpo.XPCollection
    Friend WithEvents limpiafiltros As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdRol As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdObjecto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPermiso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
