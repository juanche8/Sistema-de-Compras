Partial Public Class FrConsumo
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    '''
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrConsumo))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.labelControl = New DevExpress.XtraEditors.LabelControl()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdConsumo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSector = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.XpCollection2 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.XpCollection3 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMotivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colstock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.colIdConsumo1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colIdConsumo1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colSector1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colSector1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colIdProducto1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colIdProducto1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colCantidad1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colCantidad1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colFecha1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colFecha1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colMotivo1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colMotivo1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colStockeado = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colStockeado = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.layoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.itemLabel = New DevExpress.XtraLayout.LayoutControlItem()
        Me.itemGrid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.windowsUIButtonPanel = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.layoutControl.SuspendLayout()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colIdConsumo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colSector1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colIdProducto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colCantidad1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colFecha1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colMotivo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colStockeado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'layoutControl
        '
        Me.layoutControl.AllowCustomization = False
        Me.layoutControl.Controls.Add(Me.labelControl)
        Me.layoutControl.Controls.Add(Me.gridControl)
        Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layoutControl.Location = New System.Drawing.Point(0, 0)
        Me.layoutControl.Name = "layoutControl"
        Me.layoutControl.Root = Me.layoutControlGroup
        Me.layoutControl.Size = New System.Drawing.Size(903, 364)
        Me.layoutControl.TabIndex = 1
        '
        'labelControl
        '
        Me.labelControl.AllowHtmlString = True
        Me.labelControl.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.labelControl.Location = New System.Drawing.Point(40, 0)
        Me.labelControl.Name = "labelControl"
        Me.labelControl.Padding = New System.Windows.Forms.Padding(0, 3, 13, 6)
        Me.labelControl.Size = New System.Drawing.Size(823, 34)
        Me.labelControl.StyleController = Me.layoutControl
        Me.labelControl.TabIndex = 4
        Me.labelControl.Text = "CONSUMOS DE PRODUCTOS"
        '
        'gridControl
        '
        Me.gridControl.DataSource = Me.XpCollection1
        Me.gridControl.Location = New System.Drawing.Point(40, 34)
        Me.gridControl.MainView = Me.GridView1
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemMemoEdit1, Me.RepositoryItemSpinEdit1, Me.RepositoryItemCheckEdit1, Me.RepositoryItemGridLookUpEdit3})
        Me.gridControl.Size = New System.Drawing.Size(823, 330)
        Me.gridControl.TabIndex = 2
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.LayoutView1})
        '
        'XpCollection1
        '
        Me.XpCollection1.DisplayableProperties = "IdConsumo;Sector;IdProducto;Cantidad;Fecha;Motivo;Stockeado"
        Me.XpCollection1.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Consumos)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdConsumo, Me.colSector, Me.colIdProducto, Me.colCantidad, Me.colFecha, Me.colMotivo, Me.colstock})
        Me.GridView1.GridControl = Me.gridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowQuickHideColumns = False
        Me.GridView1.OptionsEditForm.EditFormColumnCount = 1
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 500
        Me.GridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindNullPrompt = "Ingrese el texto a buscar"
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowChildrenInGroupPanel = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.ViewCaption = "Gridview1"
        '
        'colIdConsumo
        '
        Me.colIdConsumo.FieldName = "IdConsumo"
        Me.colIdConsumo.Name = "colIdConsumo"
        '
        'colSector
        '
        Me.colSector.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colSector.FieldName = "Sector"
        Me.colSector.Name = "colSector"
        Me.colSector.Visible = True
        Me.colSector.VisibleIndex = 0
        Me.colSector.Width = 108
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.XpCollection2
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "Sector"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "Sector"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'XpCollection2
        '
        Me.XpCollection2.DisplayableProperties = "IdSector;Sector;Observaciones"
        Me.XpCollection2.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Sectores)
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colIdProducto
        '
        Me.colIdProducto.Caption = "Producto"
        Me.colIdProducto.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colIdProducto.FieldName = "IdProducto"
        Me.colIdProducto.Name = "colIdProducto"
        Me.colIdProducto.Visible = True
        Me.colIdProducto.VisibleIndex = 1
        Me.colIdProducto.Width = 272
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.XpCollection3
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "Producto"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = ""
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "Id"
        Me.RepositoryItemGridLookUpEdit2.View = Me.RepositoryItemGridLookUpEdit2View
        '
        'XpCollection3
        '
        Me.XpCollection3.DisplayableProperties = "Id;Rubro;Subrubro;CodigoProducto;Producto;Marca;Presentacion"
        Me.XpCollection3.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Productos)
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colCantidad
        '
        Me.colCantidad.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 2
        Me.colCantidad.Width = 62
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'colFecha
        '
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 3
        Me.colFecha.Width = 85
        '
        'colMotivo
        '
        Me.colMotivo.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colMotivo.FieldName = "Motivo"
        Me.colMotivo.Name = "colMotivo"
        Me.colMotivo.Visible = True
        Me.colMotivo.VisibleIndex = 4
        Me.colMotivo.Width = 203
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colstock
        '
        Me.colstock.Caption = "Pasado a Stock"
        Me.colstock.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colstock.FieldName = "Stockeado"
        Me.colstock.Name = "colstock"
        Me.colstock.OptionsColumn.ReadOnly = True
        Me.colstock.Visible = True
        Me.colstock.VisibleIndex = 5
        Me.colstock.Width = 89
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.DisplayValueChecked = "1"
        Me.RepositoryItemCheckEdit1.DisplayValueGrayed = "0"
        Me.RepositoryItemCheckEdit1.DisplayValueUnchecked = "0"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = 1
        Me.RepositoryItemCheckEdit1.ValueGrayed = 0
        Me.RepositoryItemCheckEdit1.ValueUnchecked = 0
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.DataSource = Me.XpCollection3
        Me.RepositoryItemGridLookUpEdit3.DisplayMember = "Producto"
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
        'LayoutView1
        '
        Me.LayoutView1.CardMinSize = New System.Drawing.Size(408, 208)
        Me.LayoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colIdConsumo1, Me.colSector1, Me.colIdProducto1, Me.colCantidad1, Me.colFecha1, Me.colMotivo1, Me.colStockeado})
        Me.LayoutView1.GridControl = Me.gridControl
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.TemplateCard = Me.LayoutViewCard1
        Me.LayoutView1.ViewCaption = "Layout1"
        '
        'colIdConsumo1
        '
        Me.colIdConsumo1.FieldName = "IdConsumo"
        Me.colIdConsumo1.LayoutViewField = Me.layoutViewField_colIdConsumo1
        Me.colIdConsumo1.Name = "colIdConsumo1"
        '
        'layoutViewField_colIdConsumo1
        '
        Me.layoutViewField_colIdConsumo1.EditorPreferredWidth = 318
        Me.layoutViewField_colIdConsumo1.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colIdConsumo1.Name = "layoutViewField_colIdConsumo1"
        Me.layoutViewField_colIdConsumo1.Size = New System.Drawing.Size(388, 24)
        Me.layoutViewField_colIdConsumo1.TextSize = New System.Drawing.Size(61, 13)
        '
        'colSector1
        '
        Me.colSector1.FieldName = "Sector"
        Me.colSector1.LayoutViewField = Me.layoutViewField_colSector1
        Me.colSector1.Name = "colSector1"
        '
        'layoutViewField_colSector1
        '
        Me.layoutViewField_colSector1.EditorPreferredWidth = 318
        Me.layoutViewField_colSector1.Location = New System.Drawing.Point(0, 24)
        Me.layoutViewField_colSector1.Name = "layoutViewField_colSector1"
        Me.layoutViewField_colSector1.Size = New System.Drawing.Size(388, 24)
        Me.layoutViewField_colSector1.TextSize = New System.Drawing.Size(61, 13)
        '
        'colIdProducto1
        '
        Me.colIdProducto1.ColumnEdit = Me.RepositoryItemGridLookUpEdit3
        Me.colIdProducto1.FieldName = "IdProducto"
        Me.colIdProducto1.LayoutViewField = Me.layoutViewField_colIdProducto1
        Me.colIdProducto1.Name = "colIdProducto1"
        '
        'layoutViewField_colIdProducto1
        '
        Me.layoutViewField_colIdProducto1.EditorPreferredWidth = 318
        Me.layoutViewField_colIdProducto1.Location = New System.Drawing.Point(0, 48)
        Me.layoutViewField_colIdProducto1.Name = "layoutViewField_colIdProducto1"
        Me.layoutViewField_colIdProducto1.Size = New System.Drawing.Size(388, 24)
        Me.layoutViewField_colIdProducto1.TextSize = New System.Drawing.Size(61, 13)
        '
        'colCantidad1
        '
        Me.colCantidad1.FieldName = "Cantidad"
        Me.colCantidad1.LayoutViewField = Me.layoutViewField_colCantidad1
        Me.colCantidad1.Name = "colCantidad1"
        '
        'layoutViewField_colCantidad1
        '
        Me.layoutViewField_colCantidad1.EditorPreferredWidth = 318
        Me.layoutViewField_colCantidad1.Location = New System.Drawing.Point(0, 72)
        Me.layoutViewField_colCantidad1.Name = "layoutViewField_colCantidad1"
        Me.layoutViewField_colCantidad1.Size = New System.Drawing.Size(388, 24)
        Me.layoutViewField_colCantidad1.TextSize = New System.Drawing.Size(61, 13)
        '
        'colFecha1
        '
        Me.colFecha1.FieldName = "Fecha"
        Me.colFecha1.LayoutViewField = Me.layoutViewField_colFecha1
        Me.colFecha1.Name = "colFecha1"
        '
        'layoutViewField_colFecha1
        '
        Me.layoutViewField_colFecha1.EditorPreferredWidth = 318
        Me.layoutViewField_colFecha1.Location = New System.Drawing.Point(0, 96)
        Me.layoutViewField_colFecha1.Name = "layoutViewField_colFecha1"
        Me.layoutViewField_colFecha1.Size = New System.Drawing.Size(388, 24)
        Me.layoutViewField_colFecha1.TextSize = New System.Drawing.Size(61, 13)
        '
        'colMotivo1
        '
        Me.colMotivo1.FieldName = "Motivo"
        Me.colMotivo1.LayoutViewField = Me.layoutViewField_colMotivo1
        Me.colMotivo1.Name = "colMotivo1"
        '
        'layoutViewField_colMotivo1
        '
        Me.layoutViewField_colMotivo1.EditorPreferredWidth = 318
        Me.layoutViewField_colMotivo1.Location = New System.Drawing.Point(0, 120)
        Me.layoutViewField_colMotivo1.Name = "layoutViewField_colMotivo1"
        Me.layoutViewField_colMotivo1.Size = New System.Drawing.Size(388, 24)
        Me.layoutViewField_colMotivo1.TextSize = New System.Drawing.Size(61, 13)
        '
        'colStockeado
        '
        Me.colStockeado.FieldName = "Stockeado"
        Me.colStockeado.LayoutViewField = Me.layoutViewField_colStockeado
        Me.colStockeado.Name = "colStockeado"
        '
        'layoutViewField_colStockeado
        '
        Me.layoutViewField_colStockeado.EditorPreferredWidth = 318
        Me.layoutViewField_colStockeado.Location = New System.Drawing.Point(0, 144)
        Me.layoutViewField_colStockeado.Name = "layoutViewField_colStockeado"
        Me.layoutViewField_colStockeado.Size = New System.Drawing.Size(388, 24)
        Me.layoutViewField_colStockeado.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colIdConsumo1, Me.layoutViewField_colSector1, Me.layoutViewField_colIdProducto1, Me.layoutViewField_colCantidad1, Me.layoutViewField_colFecha1, Me.layoutViewField_colMotivo1, Me.layoutViewField_colStockeado})
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        Me.LayoutViewCard1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutViewCard1.Text = "TemplateCard"
        '
        'layoutControlGroup
        '
        Me.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.layoutControlGroup.GroupBordersVisible = False
        Me.layoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.itemLabel, Me.itemGrid})
        Me.layoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.layoutControlGroup.Name = "layoutControlGroup"
        Me.layoutControlGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(40, 40, 0, 0)
        Me.layoutControlGroup.Size = New System.Drawing.Size(903, 364)
        Me.layoutControlGroup.TextVisible = False
        '
        'itemLabel
        '
        Me.itemLabel.Control = Me.labelControl
        Me.itemLabel.Location = New System.Drawing.Point(0, 0)
        Me.itemLabel.Name = "itemLabel"
        Me.itemLabel.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.itemLabel.Size = New System.Drawing.Size(823, 34)
        Me.itemLabel.TextSize = New System.Drawing.Size(0, 0)
        Me.itemLabel.TextVisible = False
        '
        'itemGrid
        '
        Me.itemGrid.Control = Me.gridControl
        Me.itemGrid.Location = New System.Drawing.Point(0, 34)
        Me.itemGrid.Name = "itemGrid"
        Me.itemGrid.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.itemGrid.Size = New System.Drawing.Size(823, 330)
        Me.itemGrid.TextSize = New System.Drawing.Size(0, 0)
        Me.itemGrid.TextVisible = False
        '
        'windowsUIButtonPanel
        '
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = True
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = True
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = True
        Me.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1
        Me.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = True
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = True
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = True
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = True
        Me.windowsUIButtonPanel.BackColor = System.Drawing.SystemColors.GrayText
        ToolTipItem1.Text = "Descuenta del stock aquellos insumos no marcados"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.windowsUIButtonPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("AGREGAR", CType(resources.GetObject("windowsUIButtonPanel.Buttons"), System.Drawing.Image), "New;Size32x32;GrayScaled", -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Permiite agregar un nuevo registro", True, -1, True, Nothing, True, False, True, Nothing, Nothing, -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("EDITAR", "Edit;Size32x32;GrayScaled", DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Permite modificar el registro seleccionado", True, -1, True, Nothing, True, False, True, Nothing, Nothing, -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("ELIMINAR", "Edit/Delete;Size32x32;GrayScaled", DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Permite eliminar el registro seleccionado", True, -1, True, Nothing, True, False, False, Nothing, Nothing, -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("RECARGAR", "Refresh;Size32x32;GrayScaled", DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Permite recargar la grilla para visualizar datos  que puedan haber sido agregados" &
                    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por otros usuarios", True, -1, True, Nothing, True, False, True, Nothing, Nothing, -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("CANCELAR", CType(resources.GetObject("windowsUIButtonPanel.Buttons1"), System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", True, -1, True, Nothing, True, False, False, Nothing, Nothing, -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("QUITAR FILTROS", CType(resources.GetObject("windowsUIButtonPanel.Buttons2"), System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Limpia los filtros de selección", True, -1, True, Nothing, True, False, True, Nothing, Nothing, -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("CAMBIAR VISTA", CType(resources.GetObject("windowsUIButtonPanel.Buttons3"), System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Cambia entre Vista Grilla y Ficha", True, -1, True, Nothing, True, False, True, Nothing, Nothing, -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("IMPRIMIR", "Preview;Size32x32;GrayScaled", DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Muestra el panel de impresión y exportación", True, -1, True, Nothing, True, False, True, Nothing, Nothing, -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("PASAR A STOCK", CType(resources.GetObject("windowsUIButtonPanel.Buttons4"), System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", True, -1, True, SuperToolTip1, True, False, True, Nothing, Nothing, -1, False, False)})
        Me.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.windowsUIButtonPanel.EnableImageTransparency = True
        Me.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White
        Me.windowsUIButtonPanel.Location = New System.Drawing.Point(0, 364)
        Me.windowsUIButtonPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.windowsUIButtonPanel.MaximumSize = New System.Drawing.Size(0, 60)
        Me.windowsUIButtonPanel.MinimumSize = New System.Drawing.Size(60, 60)
        Me.windowsUIButtonPanel.Name = "windowsUIButtonPanel"
        Me.windowsUIButtonPanel.Size = New System.Drawing.Size(903, 60)
        Me.windowsUIButtonPanel.TabIndex = 5
        Me.windowsUIButtonPanel.Text = "windowsUIButtonPanel"
        Me.windowsUIButtonPanel.UseButtonBackgroundImages = False
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
        '
        'FrConsumo
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 424)
        Me.Controls.Add(Me.layoutControl)
        Me.Controls.Add(Me.windowsUIButtonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrConsumo"
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.layoutControl.ResumeLayout(False)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colIdConsumo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colSector1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colIdProducto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colCantidad1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colFecha1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colMotivo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colStockeado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private layoutControl As DevExpress.XtraLayout.LayoutControl
    Private labelControl As DevExpress.XtraEditors.LabelControl
    Private layoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Private itemLabel As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents windowsUIButtonPanel As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents itemGrid As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colIdConsumo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSector As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMotivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XpCollection2 As DevExpress.Xpo.XPCollection
    Friend WithEvents XpCollection3 As DevExpress.Xpo.XPCollection
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colstock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colIdConsumo1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colSector1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colIdProducto1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCantidad1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colFecha1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colMotivo1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colStockeado As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_colIdConsumo1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colSector1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colIdProducto1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colCantidad1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colFecha1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colMotivo1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colStockeado As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
End Class
