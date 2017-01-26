Partial Public Class FrListasPrecios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrListasPrecios))
        Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.labelControl = New DevExpress.XtraEditors.LabelControl()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.Listas = New DevExpress.Xpo.XPCollection(Me.components)
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdLista = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.Proveedores = New DevExpress.Xpo.XPCollection(Me.components)
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.Productos = New DevExpress.Xpo.XPCollection(Me.components)
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrecioBase = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colPrecioUnitario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colDescuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colFechaModificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.Monedas = New DevExpress.Xpo.XPCollection(Me.components)
        Me.RepositoryItemGridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colObservaciones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.impuestos = New DevExpress.Xpo.XPCollection(Me.components)
        Me.RepositoryItemGridLookUpEdit4View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemRatingControl1 = New DevExpress.XtraEditors.Repository.RepositoryItemRatingControl()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.layoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.itemLabel = New DevExpress.XtraLayout.LayoutControlItem()
        Me.itemGrid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.windowsUIButtonPanel = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.layoutControl,System.ComponentModel.ISupportInitialize).BeginInit
        Me.layoutControl.SuspendLayout
        CType(Me.gridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Listas,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Proveedores,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit1View,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Productos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit2View,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemSpinEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemSpinEdit2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemSpinEdit3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemDateEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Monedas,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit3View,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.impuestos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit4View,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemRatingControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LayoutView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LayoutViewCard1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.layoutControlGroup,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.itemLabel,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.itemGrid,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'layoutControl
        '
        Me.layoutControl.AllowCustomization = false
        Me.layoutControl.Controls.Add(Me.labelControl)
        Me.layoutControl.Controls.Add(Me.gridControl)
        Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layoutControl.Location = New System.Drawing.Point(0, 0)
        Me.layoutControl.Name = "layoutControl"
        Me.layoutControl.Root = Me.layoutControlGroup
        Me.layoutControl.Size = New System.Drawing.Size(1065, 364)
        Me.layoutControl.TabIndex = 1
        '
        'labelControl
        '
        Me.labelControl.AllowHtmlString = true
        Me.labelControl.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140,Byte),Integer), CType(CType(140,Byte),Integer), CType(CType(140,Byte),Integer))
        Me.labelControl.Appearance.Options.UseFont = true
        Me.labelControl.Appearance.Options.UseForeColor = true
        Me.labelControl.Appearance.Options.UseTextOptions = true
        Me.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.labelControl.Location = New System.Drawing.Point(40, 0)
        Me.labelControl.Name = "labelControl"
        Me.labelControl.Padding = New System.Windows.Forms.Padding(0, 3, 13, 6)
        Me.labelControl.Size = New System.Drawing.Size(985, 34)
        Me.labelControl.StyleController = Me.layoutControl
        Me.labelControl.TabIndex = 4
        Me.labelControl.Text = "LISTA DE PRECIOS"
        '
        'gridControl
        '
        Me.gridControl.DataSource = Me.Listas
        Me.gridControl.Location = New System.Drawing.Point(40, 34)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemSpinEdit1, Me.RepositoryItemSpinEdit2, Me.RepositoryItemSpinEdit3, Me.RepositoryItemDateEdit1, Me.RepositoryItemGridLookUpEdit3, Me.RepositoryItemRatingControl1, Me.RepositoryItemGridLookUpEdit4})
        Me.gridControl.Size = New System.Drawing.Size(985, 330)
        Me.gridControl.TabIndex = 2
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView, Me.LayoutView1})
        '
        'Listas
        '
        Me.Listas.ObjectType = GetType(SistemaCompras.MontagneAdministracion.ListasPrecios)
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdLista, Me.GridColumn1, Me.GridColumn3, Me.colPrecioBase, Me.colPrecioUnitario, Me.colDescuento, Me.colFechaModificacion, Me.colMoneda, Me.colObservaciones, Me.GridColumn2})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.gridView.OptionsCustomization.AllowColumnMoving = false
        Me.gridView.OptionsCustomization.AllowGroup = false
        Me.gridView.OptionsCustomization.AllowQuickHideColumns = false
        Me.gridView.OptionsDetail.EnableMasterViewMode = false
        Me.gridView.OptionsEditForm.EditFormColumnCount = 1
        Me.gridView.OptionsFind.AlwaysVisible = true
        Me.gridView.OptionsFind.FindNullPrompt = "Ingrese el texto a buscar"
        Me.gridView.OptionsMenu.EnableColumnMenu = false
        Me.gridView.OptionsNavigation.AutoFocusNewRow = true
        Me.gridView.OptionsNavigation.EnterMoveNextColumn = true
        Me.gridView.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.gridView.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.gridView.OptionsView.ShowAutoFilterRow = true
        Me.gridView.OptionsView.ShowChildrenInGroupPanel = true
        Me.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.gridView.OptionsView.ShowFooter = true
        Me.gridView.OptionsView.ShowIndicator = false
        Me.gridView.ViewCaption = "Gridview1"
        '
        'colIdLista
        '
        Me.colIdLista.FieldName = "IdLista"
        Me.colIdLista.Name = "colIdLista"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Proveedor"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.GridColumn1.FieldName = "IdProveedor"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = true
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 192
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = false
        Me.RepositoryItemGridLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.Proveedores
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "RazonSocial"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "IdProveedor"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'Proveedores
        '
        Me.Proveedores.DisplayableProperties = "IdProveedor;Rubro;CUIT_CUIL;RazonSocial;NombreFantasia;Observaciones"
        Me.Proveedores.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Proveedores)
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Producto"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.GridColumn3.FieldName = "IdProducto"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = true
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 208
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = false
        Me.RepositoryItemGridLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.Productos
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "Producto"
        Me.RepositoryItemGridLookUpEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = ""
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "Id"
        Me.RepositoryItemGridLookUpEdit2.View = Me.RepositoryItemGridLookUpEdit2View
        '
        'Productos
        '
        Me.Productos.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Productos)
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false
        '
        'colPrecioBase
        '
        Me.colPrecioBase.Caption = "Precio Base"
        Me.colPrecioBase.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colPrecioBase.FieldName = "PrecioBase"
        Me.colPrecioBase.Name = "colPrecioBase"
        Me.colPrecioBase.Visible = true
        Me.colPrecioBase.VisibleIndex = 2
        Me.colPrecioBase.Width = 67
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = false
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'colPrecioUnitario
        '
        Me.colPrecioUnitario.Caption = "Precio Unitario"
        Me.colPrecioUnitario.ColumnEdit = Me.RepositoryItemSpinEdit2
        Me.colPrecioUnitario.FieldName = "PrecioUnitario"
        Me.colPrecioUnitario.Name = "colPrecioUnitario"
        Me.colPrecioUnitario.Visible = true
        Me.colPrecioUnitario.VisibleIndex = 3
        Me.colPrecioUnitario.Width = 86
        '
        'RepositoryItemSpinEdit2
        '
        Me.RepositoryItemSpinEdit2.AutoHeight = false
        Me.RepositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit2.Name = "RepositoryItemSpinEdit2"
        '
        'colDescuento
        '
        Me.colDescuento.ColumnEdit = Me.RepositoryItemSpinEdit3
        Me.colDescuento.FieldName = "Descuento"
        Me.colDescuento.Name = "colDescuento"
        Me.colDescuento.Visible = true
        Me.colDescuento.VisibleIndex = 5
        Me.colDescuento.Width = 76
        '
        'RepositoryItemSpinEdit3
        '
        Me.RepositoryItemSpinEdit3.AutoHeight = false
        Me.RepositoryItemSpinEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit3.Name = "RepositoryItemSpinEdit3"
        '
        'colFechaModificacion
        '
        Me.colFechaModificacion.Caption = "Fecha Modificación"
        Me.colFechaModificacion.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colFechaModificacion.FieldName = "FechaModificacion"
        Me.colFechaModificacion.Name = "colFechaModificacion"
        Me.colFechaModificacion.Visible = true
        Me.colFechaModificacion.VisibleIndex = 6
        Me.colFechaModificacion.Width = 109
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = false
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'colMoneda
        '
        Me.colMoneda.ColumnEdit = Me.RepositoryItemGridLookUpEdit3
        Me.colMoneda.FieldName = "Moneda"
        Me.colMoneda.Name = "colMoneda"
        Me.colMoneda.Visible = true
        Me.colMoneda.VisibleIndex = 7
        Me.colMoneda.Width = 68
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = false
        Me.RepositoryItemGridLookUpEdit3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.DataSource = Me.Monedas
        Me.RepositoryItemGridLookUpEdit3.DisplayMember = "Moneda"
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.NullText = ""
        Me.RepositoryItemGridLookUpEdit3.ValueMember = "IdMoneda"
        Me.RepositoryItemGridLookUpEdit3.View = Me.RepositoryItemGridLookUpEdit3View
        '
        'Monedas
        '
        Me.Monedas.DisplayableProperties = "IdMoneda;Moneda"
        Me.Monedas.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Monedas)
        '
        'RepositoryItemGridLookUpEdit3View
        '
        Me.RepositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit3View.Name = "RepositoryItemGridLookUpEdit3View"
        Me.RepositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = false
        '
        'colObservaciones
        '
        Me.colObservaciones.FieldName = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.Visible = true
        Me.colObservaciones.VisibleIndex = 8
        Me.colObservaciones.Width = 175
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "IVA"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemGridLookUpEdit4
        Me.GridColumn2.FieldName = "Iva"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = true
        Me.GridColumn2.VisibleIndex = 4
        '
        'RepositoryItemGridLookUpEdit4
        '
        Me.RepositoryItemGridLookUpEdit4.AutoHeight = false
        Me.RepositoryItemGridLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit4.DataSource = Me.impuestos
        Me.RepositoryItemGridLookUpEdit4.DisplayMember = "IVA"
        Me.RepositoryItemGridLookUpEdit4.Name = "RepositoryItemGridLookUpEdit4"
        Me.RepositoryItemGridLookUpEdit4.ValueMember = "Multiplo"
        Me.RepositoryItemGridLookUpEdit4.View = Me.RepositoryItemGridLookUpEdit4View
        '
        'impuestos
        '
        Me.impuestos.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Impuestos)
        '
        'RepositoryItemGridLookUpEdit4View
        '
        Me.RepositoryItemGridLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit4View.Name = "RepositoryItemGridLookUpEdit4View"
        Me.RepositoryItemGridLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.RepositoryItemGridLookUpEdit4View.OptionsView.ShowGroupPanel = false
        '
        'RepositoryItemRatingControl1
        '
        Me.RepositoryItemRatingControl1.AutoHeight = false
        Me.RepositoryItemRatingControl1.Name = "RepositoryItemRatingControl1"
        '
        'LayoutView1
        '
        Me.LayoutView1.GridControl = Me.gridControl
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.TemplateCard = Me.LayoutViewCard1
        Me.LayoutView1.ViewCaption = "Layout1"
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        '
        'layoutControlGroup
        '
        Me.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.layoutControlGroup.GroupBordersVisible = false
        Me.layoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.itemLabel, Me.itemGrid})
        Me.layoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.layoutControlGroup.Name = "layoutControlGroup"
        Me.layoutControlGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(40, 40, 0, 0)
        Me.layoutControlGroup.Size = New System.Drawing.Size(1065, 364)
        Me.layoutControlGroup.TextVisible = false
        '
        'itemLabel
        '
        Me.itemLabel.Control = Me.labelControl
        Me.itemLabel.Location = New System.Drawing.Point(0, 0)
        Me.itemLabel.Name = "itemLabel"
        Me.itemLabel.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.itemLabel.Size = New System.Drawing.Size(985, 34)
        Me.itemLabel.TextSize = New System.Drawing.Size(0, 0)
        Me.itemLabel.TextVisible = false
        '
        'itemGrid
        '
        Me.itemGrid.Control = Me.gridControl
        Me.itemGrid.Location = New System.Drawing.Point(0, 34)
        Me.itemGrid.Name = "itemGrid"
        Me.itemGrid.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.itemGrid.Size = New System.Drawing.Size(985, 330)
        Me.itemGrid.TextSize = New System.Drawing.Size(0, 0)
        Me.itemGrid.TextVisible = false
        '
        'windowsUIButtonPanel
        '
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(130,Byte),Integer), CType(CType(130,Byte),Integer), CType(CType(130,Byte),Integer))
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130,Byte),Integer), CType(CType(130,Byte),Integer), CType(CType(130,Byte),Integer))
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = true
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = true
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true
        Me.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1
        Me.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = true
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(159,Byte),Integer), CType(CType(159,Byte),Integer), CType(CType(159,Byte),Integer))
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159,Byte),Integer), CType(CType(159,Byte),Integer), CType(CType(159,Byte),Integer))
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = true
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = true
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true
        Me.windowsUIButtonPanel.BackColor = System.Drawing.SystemColors.GrayText
        Me.windowsUIButtonPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("AGREGAR", CType(resources.GetObject("windowsUIButtonPanel.Buttons"),System.Drawing.Image), "New;Size32x32;GrayScaled", -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Permiite agregar un nuevo registro", true, -1, true, Nothing, true, false, true, Nothing, Nothing, -1, false, false), New DevExpress.XtraBars.Docking2010.WindowsUIButton("EDITAR", "Edit;Size32x32;GrayScaled", DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Permite modificar el registro seleccionado", true, -1, true, Nothing, true, false, true, Nothing, Nothing, -1, false, false), New DevExpress.XtraBars.Docking2010.WindowsUIButton("ELIMINAR", "Edit/Delete;Size32x32;GrayScaled", DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Permite eliminar el registro seleccionado", true, -1, true, Nothing, true, false, false, Nothing, Nothing, -1, false, false), New DevExpress.XtraBars.Docking2010.WindowsUIButton("RECARGAR", "Refresh;Size32x32;GrayScaled", DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Permite recargar la grilla para visualizar datos  que puedan haber sido agregados"& _ 
                    ""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"por otros usuarios", true, -1, true, Nothing, true, false, true, Nothing, Nothing, -1, false, false), New DevExpress.XtraBars.Docking2010.WindowsUIButton("CANCELAR", CType(resources.GetObject("windowsUIButtonPanel.Buttons1"),System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, Nothing, true, false, false, Nothing, Nothing, -1, false, false), New DevExpress.XtraBars.Docking2010.WindowsUIButton("QUITAR FILTROS", CType(resources.GetObject("windowsUIButtonPanel.Buttons2"),System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Limpia los filtros de selección", true, -1, true, Nothing, true, false, true, Nothing, Nothing, -1, false, false), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("CAMBIAR VISTA", CType(resources.GetObject("windowsUIButtonPanel.Buttons3"),System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Cambia entre Vista Grilla y Ficha", true, -1, true, Nothing, true, false, true, Nothing, Nothing, -1, false, false), New DevExpress.XtraBars.Docking2010.WindowsUIButton("IMPRIMIR", "Preview;Size32x32;GrayScaled", DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Muestra el panel de impresión y exportación", true, -1, true, Nothing, true, false, true, Nothing, Nothing, -1, false, false)})
        Me.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.windowsUIButtonPanel.EnableImageTransparency = true
        Me.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White
        Me.windowsUIButtonPanel.Location = New System.Drawing.Point(0, 364)
        Me.windowsUIButtonPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.windowsUIButtonPanel.MaximumSize = New System.Drawing.Size(0, 60)
        Me.windowsUIButtonPanel.MinimumSize = New System.Drawing.Size(60, 60)
        Me.windowsUIButtonPanel.Name = "windowsUIButtonPanel"
        Me.windowsUIButtonPanel.Size = New System.Drawing.Size(1065, 60)
        Me.windowsUIButtonPanel.TabIndex = 5
        Me.windowsUIButtonPanel.Text = "windowsUIButtonPanel"
        Me.windowsUIButtonPanel.UseButtonBackgroundImages = false
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
        '
        'FrListasPrecios
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = true
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 424)
        Me.Controls.Add(Me.layoutControl)
        Me.Controls.Add(Me.windowsUIButtonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FrListasPrecios"
        CType(Me.layoutControl,System.ComponentModel.ISupportInitialize).EndInit
        Me.layoutControl.ResumeLayout(false)
        CType(Me.gridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Listas,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Proveedores,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit1View,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Productos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit2View,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemSpinEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemSpinEdit2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemSpinEdit3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemDateEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Monedas,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit3View,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.impuestos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit4View,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemRatingControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutViewCard1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.layoutControlGroup,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.itemLabel,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.itemGrid,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

#End Region

    Private layoutControl As DevExpress.XtraLayout.LayoutControl
    Private labelControl As DevExpress.XtraEditors.LabelControl
    Private layoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Private itemLabel As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents windowsUIButtonPanel As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents Listas As DevExpress.Xpo.XPCollection
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents itemGrid As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colIdLista As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents Proveedores As DevExpress.Xpo.XPCollection
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents Productos As DevExpress.Xpo.XPCollection
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPrecioBase As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colPrecioUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colFechaModificacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents Monedas As DevExpress.Xpo.XPCollection
    Friend WithEvents RepositoryItemGridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemRatingControl1 As DevExpress.XtraEditors.Repository.RepositoryItemRatingControl
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit4View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents impuestos As DevExpress.Xpo.XPCollection
End Class
