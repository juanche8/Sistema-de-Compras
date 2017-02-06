<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrMasterDetailPedidos
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrMasterDetailPedidos))
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.XpCollectionVistaDetalles2 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSector = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.Sectores = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFechaPedido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResponsable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdPedido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.Estados = New DevExpress.Xpo.XPCollection(Me.components)
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colObservaciones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaRecepcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUrgente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAutorizadoPor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaAprobacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProyecto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.proyecto = New DevExpress.Xpo.XPCollection(Me.components)
        Me.RepositoryItemGridLookUpEdit8View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.Productos = New DevExpress.Xpo.XPCollection(Me.components)
        Me.RepositoryItemGridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemResourcesComboBox1 = New DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemResourcesComboBox2 = New DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemGridLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit4View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemGridLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit5View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSector1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaPedido1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResponsable1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdPedido1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObservaciones1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaRecepcion1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.dirlabel = New DevExpress.XtraEditors.LabelControl()
        Me.sbimprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.XpCollectionVistaDetalles = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSector2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaPedido2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResponsable2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObservaciones2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaRecepcion2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit6View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Observaciones1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecioProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRazonSocial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreFantasia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdPedido2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit7View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.GridView8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.XpCollectionVistaDetalles2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sectores,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Estados,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit2View,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.proyecto,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit8View,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemDateEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemMemoEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Productos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit3View,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemSpinEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemMemoEdit2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemDateEdit2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemResourcesComboBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemComboBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemResourcesComboBox2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit4View,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit5View,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainerControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainerControl1.SuspendLayout
        CType(Me.TextEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridControl2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.XpCollectionVistaDetalles,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit6View,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit7View,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView7,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GridView8
        '
        Me.GridView8.GridControl = Me.GridControl1
        Me.GridView8.Name = "GridView8"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.XpCollectionVistaDetalles2
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Enabled = false
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.Enabled = false
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemMemoEdit1, Me.RepositoryItemGridLookUpEdit3, Me.RepositoryItemSpinEdit1, Me.RepositoryItemMemoEdit2, Me.RepositoryItemDateEdit2, Me.RepositoryItemResourcesComboBox1, Me.RepositoryItemTextEdit2, Me.RepositoryItemComboBox1, Me.RepositoryItemResourcesComboBox2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6, Me.RepositoryItemTextEdit7, Me.RepositoryItemGridLookUpEdit4, Me.RepositoryItemGridLookUpEdit5, Me.RepositoryItemGridLookUpEdit8})
        Me.GridControl1.Size = New System.Drawing.Size(969, 403)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView4, Me.GridView6, Me.GridView2, Me.GridView8})
        '
        'XpCollectionVistaDetalles2
        '
        Me.XpCollectionVistaDetalles2.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Pedidos)
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Yellow
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = true
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = true
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = true
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSector, Me.colFechaPedido, Me.colResponsable, Me.colIdPedido, Me.colEstado, Me.colObservaciones, Me.colFechaRecepcion, Me.colUrgente, Me.colAutorizadoPor, Me.colFechaAprobacion, Me.colProyecto})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = true
        Me.GridView1.OptionsBehavior.Editable = false
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.CustomizationFormSearchBoxVisible = true
        Me.GridView1.OptionsDetail.AllowExpandEmptyDetails = true
        Me.GridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = true
        Me.GridView1.OptionsDetail.ShowEmbeddedDetailIndent = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
        Me.GridView1.OptionsEditForm.EditFormColumnCount = 1
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 500
        Me.GridView1.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = false
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = true
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = true
        Me.GridView1.OptionsView.RowAutoHeight = true
        Me.GridView1.OptionsView.ShowChildrenInGroupPanel = true
        Me.GridView1.OptionsView.ShowFooter = true
        Me.GridView1.OptionsView.ShowViewCaption = true
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colEstado, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.GridView1.ViewCaption = "PEDIDOS"
        '
        'colSector
        '
        Me.colSector.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colSector.FieldName = "Sector"
        Me.colSector.Name = "colSector"
        Me.colSector.Visible = true
        Me.colSector.VisibleIndex = 2
        Me.colSector.Width = 80
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = false
        Me.RepositoryItemGridLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.Sectores
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "Sector"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "IdSector"
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView3
        Me.RepositoryItemGridLookUpEdit1.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        '
        'Sectores
        '
        Me.Sectores.DisplayableProperties = "IdSector;Sector;Observaciones"
        Me.Sectores.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Sectores)
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.GridView3.OptionsView.ShowGroupPanel = false
        '
        'colFechaPedido
        '
        Me.colFechaPedido.FieldName = "FechaPedido"
        Me.colFechaPedido.Name = "colFechaPedido"
        Me.colFechaPedido.Visible = true
        Me.colFechaPedido.VisibleIndex = 3
        Me.colFechaPedido.Width = 94
        '
        'colResponsable
        '
        Me.colResponsable.FieldName = "Responsable"
        Me.colResponsable.Name = "colResponsable"
        Me.colResponsable.Visible = true
        Me.colResponsable.VisibleIndex = 1
        Me.colResponsable.Width = 102
        '
        'colIdPedido
        '
        Me.colIdPedido.Caption = "Nro."
        Me.colIdPedido.FieldName = "IdPedido"
        Me.colIdPedido.Name = "colIdPedido"
        Me.colIdPedido.Visible = true
        Me.colIdPedido.VisibleIndex = 0
        Me.colIdPedido.Width = 43
        '
        'colEstado
        '
        Me.colEstado.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.Visible = true
        Me.colEstado.VisibleIndex = 3
        Me.colEstado.Width = 104
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = false
        Me.RepositoryItemGridLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.Estados
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "Estado"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = ""
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "IdEstado"
        Me.RepositoryItemGridLookUpEdit2.View = Me.RepositoryItemGridLookUpEdit2View
        '
        'Estados
        '
        Me.Estados.DisplayableProperties = "IdEstado;Estado"
        Me.Estados.ObjectType = GetType(SistemaCompras.MontagneAdministracion.EstadosPedido)
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false
        '
        'colObservaciones
        '
        Me.colObservaciones.FieldName = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.Visible = true
        Me.colObservaciones.VisibleIndex = 8
        Me.colObservaciones.Width = 129
        '
        'colFechaRecepcion
        '
        Me.colFechaRecepcion.Caption = "Recep. estimada"
        Me.colFechaRecepcion.FieldName = "FechaRecepcion"
        Me.colFechaRecepcion.Name = "colFechaRecepcion"
        Me.colFechaRecepcion.Visible = true
        Me.colFechaRecepcion.VisibleIndex = 4
        Me.colFechaRecepcion.Width = 81
        '
        'colUrgente
        '
        Me.colUrgente.Caption = "Prioridad"
        Me.colUrgente.FieldName = "Urgente"
        Me.colUrgente.Name = "colUrgente"
        Me.colUrgente.Visible = true
        Me.colUrgente.VisibleIndex = 5
        Me.colUrgente.Width = 104
        '
        'colAutorizadoPor
        '
        Me.colAutorizadoPor.FieldName = "AutorizadoPor"
        Me.colAutorizadoPor.Name = "colAutorizadoPor"
        Me.colAutorizadoPor.Visible = true
        Me.colAutorizadoPor.VisibleIndex = 6
        Me.colAutorizadoPor.Width = 106
        '
        'colFechaAprobacion
        '
        Me.colFechaAprobacion.FieldName = "FechaAprobacion"
        Me.colFechaAprobacion.Name = "colFechaAprobacion"
        Me.colFechaAprobacion.Visible = true
        Me.colFechaAprobacion.VisibleIndex = 7
        Me.colFechaAprobacion.Width = 94
        '
        'colProyecto
        '
        Me.colProyecto.ColumnEdit = Me.RepositoryItemGridLookUpEdit8
        Me.colProyecto.FieldName = "Proyecto"
        Me.colProyecto.Name = "colProyecto"
        Me.colProyecto.Visible = true
        Me.colProyecto.VisibleIndex = 9
        Me.colProyecto.Width = 134
        '
        'RepositoryItemGridLookUpEdit8
        '
        Me.RepositoryItemGridLookUpEdit8.AutoHeight = false
        Me.RepositoryItemGridLookUpEdit8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit8.DataSource = Me.proyecto
        Me.RepositoryItemGridLookUpEdit8.DisplayMember = "NombreProyecto"
        Me.RepositoryItemGridLookUpEdit8.Name = "RepositoryItemGridLookUpEdit8"
        Me.RepositoryItemGridLookUpEdit8.ValueMember = "IdProyecto"
        Me.RepositoryItemGridLookUpEdit8.View = Me.RepositoryItemGridLookUpEdit8View
        '
        'proyecto
        '
        Me.proyecto.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Proyectos)
        '
        'RepositoryItemGridLookUpEdit8View
        '
        Me.RepositoryItemGridLookUpEdit8View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit8View.Name = "RepositoryItemGridLookUpEdit8View"
        Me.RepositoryItemGridLookUpEdit8View.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.RepositoryItemGridLookUpEdit8View.OptionsView.ShowGroupPanel = false
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemDateEdit1.AutoHeight = false
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.ValidateOnEnterKey = true
        Me.RepositoryItemDateEdit1.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.ShowMonthHeaders = false
        Me.RepositoryItemDateEdit1.ShowMonthNavigationButtons = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemDateEdit1.ShowYearNavigationButtons = DevExpress.Utils.DefaultBoolean.[False]
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = false
        Me.RepositoryItemTextEdit1.MaxLength = 80
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.DataSource = Me.Productos
        Me.RepositoryItemGridLookUpEdit3.DisplayMember = "Producto"
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.NullText = ""
        Me.RepositoryItemGridLookUpEdit3.ValueMember = "Id"
        Me.RepositoryItemGridLookUpEdit3.View = Me.RepositoryItemGridLookUpEdit3View
        '
        'Productos
        '
        Me.Productos.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Productos)
        '
        'RepositoryItemGridLookUpEdit3View
        '
        Me.RepositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit3View.Name = "RepositoryItemGridLookUpEdit3View"
        Me.RepositoryItemGridLookUpEdit3View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemGridLookUpEdit3View.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.RepositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowChildrenInGroupPanel = true
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = false
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = false
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = false
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'RepositoryItemResourcesComboBox1
        '
        Me.RepositoryItemResourcesComboBox1.AutoHeight = false
        Me.RepositoryItemResourcesComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemResourcesComboBox1.Name = "RepositoryItemResourcesComboBox1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = false
        Me.RepositoryItemTextEdit2.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = false
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemResourcesComboBox2
        '
        Me.RepositoryItemResourcesComboBox2.AutoHeight = false
        Me.RepositoryItemResourcesComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemResourcesComboBox2.Name = "RepositoryItemResourcesComboBox2"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = false
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = false
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatString = "d"
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = false
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = false
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = false
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'RepositoryItemGridLookUpEdit4
        '
        Me.RepositoryItemGridLookUpEdit4.AutoHeight = false
        Me.RepositoryItemGridLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit4.Name = "RepositoryItemGridLookUpEdit4"
        Me.RepositoryItemGridLookUpEdit4.View = Me.RepositoryItemGridLookUpEdit4View
        '
        'RepositoryItemGridLookUpEdit4View
        '
        Me.RepositoryItemGridLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit4View.Name = "RepositoryItemGridLookUpEdit4View"
        Me.RepositoryItemGridLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.RepositoryItemGridLookUpEdit4View.OptionsView.ShowGroupPanel = false
        '
        'RepositoryItemGridLookUpEdit5
        '
        Me.RepositoryItemGridLookUpEdit5.AutoHeight = false
        Me.RepositoryItemGridLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit5.Name = "RepositoryItemGridLookUpEdit5"
        Me.RepositoryItemGridLookUpEdit5.View = Me.RepositoryItemGridLookUpEdit5View
        '
        'RepositoryItemGridLookUpEdit5View
        '
        Me.RepositoryItemGridLookUpEdit5View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit5View.Name = "RepositoryItemGridLookUpEdit5View"
        Me.RepositoryItemGridLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.RepositoryItemGridLookUpEdit5View.OptionsView.ShowGroupPanel = false
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSector1, Me.colFechaPedido1, Me.colResponsable1, Me.colIdPedido1, Me.colEstado1, Me.colObservaciones1, Me.colFechaRecepcion1})
        Me.GridView4.GridControl = Me.GridControl1
        Me.GridView4.Name = "GridView4"
        '
        'colSector1
        '
        Me.colSector1.FieldName = "Sector"
        Me.colSector1.Name = "colSector1"
        '
        'colFechaPedido1
        '
        Me.colFechaPedido1.FieldName = "FechaPedido"
        Me.colFechaPedido1.Name = "colFechaPedido1"
        '
        'colResponsable1
        '
        Me.colResponsable1.FieldName = "Responsable"
        Me.colResponsable1.Name = "colResponsable1"
        '
        'colIdPedido1
        '
        Me.colIdPedido1.ColumnEdit = Me.RepositoryItemGridLookUpEdit3
        Me.colIdPedido1.FieldName = "IdPedido"
        Me.colIdPedido1.Name = "colIdPedido1"
        Me.colIdPedido1.Visible = true
        Me.colIdPedido1.VisibleIndex = 0
        '
        'colEstado1
        '
        Me.colEstado1.FieldName = "Estado"
        Me.colEstado1.Name = "colEstado1"
        '
        'colObservaciones1
        '
        Me.colObservaciones1.FieldName = "Observaciones"
        Me.colObservaciones1.Name = "colObservaciones1"
        Me.colObservaciones1.Visible = true
        Me.colObservaciones1.VisibleIndex = 1
        '
        'colFechaRecepcion1
        '
        Me.colFechaRecepcion1.FieldName = "FechaRecepcion"
        Me.colFechaRecepcion1.Name = "colFechaRecepcion1"
        '
        'GridView6
        '
        Me.GridView6.GridControl = Me.GridControl1
        Me.GridView6.Name = "GridView6"
        '
        'GridView2
        '
        Me.GridView2.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.White
        Me.GridView2.Appearance.TopNewRow.BorderColor = System.Drawing.Color.White
        Me.GridView2.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.GridView2.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.ViewCaption.Options.UseBackColor = true
        Me.GridView2.Appearance.ViewCaption.Options.UseFont = true
        Me.GridView2.Appearance.ViewCaption.Options.UseForeColor = true
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.GridView2.OptionsBehavior.ReadOnly = true
        Me.GridView2.OptionsDetail.ShowDetailTabs = false
        Me.GridView2.OptionsDetail.SmartDetailExpand = false
        Me.GridView2.OptionsEditForm.EditFormColumnCount = 2
        Me.GridView2.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsFind.AlwaysVisible = true
        Me.GridView2.OptionsFind.SearchInPreview = true
        Me.GridView2.OptionsNavigation.AutoFocusNewRow = true
        Me.GridView2.OptionsNavigation.EnterMoveNextColumn = true
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView2.OptionsView.ShowDetailButtons = false
        Me.GridView2.OptionsView.ShowGroupPanelColumnsAsSingleRow = true
        Me.GridView2.ViewCaption = "DETALLES DEL PEDIDO"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = false
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(969, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = false
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 466)
        Me.barDockControlBottom.Size = New System.Drawing.Size(969, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = false
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 466)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = false
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(969, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 466)
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CaptionImageUri.Uri = "AlignVerticalCenter"
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = false
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SimpleButton2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.dirlabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.sbimprimir)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SimpleButton1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.TextEdit1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GridControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(969, 466)
        Me.SplitContainerControl1.SplitterPosition = 403
        Me.SplitContainerControl1.TabIndex = 7
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"),System.Drawing.Image)
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(819, 3)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(66, 56)
        Me.SimpleButton2.TabIndex = 10
        Me.SimpleButton2.Text = "Recibido!"
        Me.SimpleButton2.Visible = false
        '
        'dirlabel
        '
        Me.dirlabel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dirlabel.Appearance.Options.UseFont = true
        Me.dirlabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.dirlabel.Location = New System.Drawing.Point(315, 36)
        Me.dirlabel.Name = "dirlabel"
        Me.dirlabel.Size = New System.Drawing.Size(0, 16)
        Me.dirlabel.TabIndex = 9
        '
        'sbimprimir
        '
        Me.sbimprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.sbimprimir.Image = CType(resources.GetObject("sbimprimir.Image"),System.Drawing.Image)
        Me.sbimprimir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.sbimprimir.Location = New System.Drawing.Point(891, 3)
        Me.sbimprimir.Name = "sbimprimir"
        Me.sbimprimir.Size = New System.Drawing.Size(66, 56)
        Me.sbimprimir.TabIndex = 8
        Me.sbimprimir.Text = "Imprimir"
        Me.sbimprimir.Visible = false
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(317, 36)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "Buscar Pedido"
        Me.SimpleButton1.Visible = false
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(241, 39)
        Me.TextEdit1.MenuManager = Me.BarManager1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(70, 20)
        Me.TextEdit1.TabIndex = 3
        Me.TextEdit1.Visible = false
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.XpCollectionVistaDetalles
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView5
        Me.GridControl2.MenuManager = Me.BarManager1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit6, Me.RepositoryItemGridLookUpEdit7})
        Me.GridControl2.Size = New System.Drawing.Size(969, 57)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5, Me.GridView7})
        '
        'XpCollectionVistaDetalles
        '
        Me.XpCollectionVistaDetalles.CriteriaString = "[Row] = -1L"
        Me.XpCollectionVistaDetalles.ObjectType = GetType(SistemaCompras.MontagneAdministracion.VistaPedidosDetalle)
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSector2, Me.colFechaPedido2, Me.colResponsable2, Me.colEstado2, Me.colObservaciones2, Me.colFechaRecepcion2, Me.colProducto, Me.colCantidad, Me.Observaciones1, Me.colPrecioProducto, Me.colRazonSocial, Me.colNombreFantasia, Me.colIdPedido2})
        Me.GridView5.GridControl = Me.GridControl2
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.Editable = false
        Me.GridView5.OptionsBehavior.ReadOnly = true
        Me.GridView5.OptionsLayout.Columns.AddNewColumns = false
        Me.GridView5.OptionsMenu.EnableColumnMenu = false
        Me.GridView5.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView5.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView5.OptionsView.ShowFooter = true
        Me.GridView5.OptionsView.ShowGroupPanel = false
        '
        'colSector2
        '
        Me.colSector2.FieldName = "Sector"
        Me.colSector2.Name = "colSector2"
        '
        'colFechaPedido2
        '
        Me.colFechaPedido2.FieldName = "FechaPedido"
        Me.colFechaPedido2.Name = "colFechaPedido2"
        '
        'colResponsable2
        '
        Me.colResponsable2.FieldName = "Responsable"
        Me.colResponsable2.Name = "colResponsable2"
        '
        'colEstado2
        '
        Me.colEstado2.FieldName = "Estado"
        Me.colEstado2.Name = "colEstado2"
        '
        'colObservaciones2
        '
        Me.colObservaciones2.FieldName = "Observaciones"
        Me.colObservaciones2.Name = "colObservaciones2"
        '
        'colFechaRecepcion2
        '
        Me.colFechaRecepcion2.FieldName = "FechaRecepcion"
        Me.colFechaRecepcion2.Name = "colFechaRecepcion2"
        '
        'colProducto
        '
        Me.colProducto.ColumnEdit = Me.RepositoryItemGridLookUpEdit6
        Me.colProducto.FieldName = "Producto"
        Me.colProducto.Name = "colProducto"
        Me.colProducto.Visible = true
        Me.colProducto.VisibleIndex = 0
        Me.colProducto.Width = 399
        '
        'RepositoryItemGridLookUpEdit6
        '
        Me.RepositoryItemGridLookUpEdit6.AutoHeight = false
        Me.RepositoryItemGridLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemGridLookUpEdit6.DataSource = Me.Productos
        Me.RepositoryItemGridLookUpEdit6.DisplayMember = "Producto"
        Me.RepositoryItemGridLookUpEdit6.Name = "RepositoryItemGridLookUpEdit6"
        Me.RepositoryItemGridLookUpEdit6.ValueMember = "Producto"
        Me.RepositoryItemGridLookUpEdit6.View = Me.RepositoryItemGridLookUpEdit6View
        '
        'RepositoryItemGridLookUpEdit6View
        '
        Me.RepositoryItemGridLookUpEdit6View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit6View.Name = "RepositoryItemGridLookUpEdit6View"
        Me.RepositoryItemGridLookUpEdit6View.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.RepositoryItemGridLookUpEdit6View.OptionsView.ShowGroupPanel = false
        '
        'colCantidad
        '
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = true
        Me.colCantidad.VisibleIndex = 1
        Me.colCantidad.Width = 74
        '
        'Observaciones1
        '
        Me.Observaciones1.Caption = "Observaciones del Pedido"
        Me.Observaciones1.FieldName = "Obsb1"
        Me.Observaciones1.Name = "Observaciones1"
        Me.Observaciones1.OptionsColumn.AllowEdit = false
        Me.Observaciones1.OptionsEditForm.Caption = "Observaciones del Item"
        Me.Observaciones1.Visible = true
        Me.Observaciones1.VisibleIndex = 2
        Me.Observaciones1.Width = 599
        '
        'colPrecioProducto
        '
        Me.colPrecioProducto.FieldName = "PrecioProducto"
        Me.colPrecioProducto.Name = "colPrecioProducto"
        '
        'colRazonSocial
        '
        Me.colRazonSocial.FieldName = "RazonSocial"
        Me.colRazonSocial.Name = "colRazonSocial"
        '
        'colNombreFantasia
        '
        Me.colNombreFantasia.FieldName = "NombreFantasia"
        Me.colNombreFantasia.Name = "colNombreFantasia"
        '
        'colIdPedido2
        '
        Me.colIdPedido2.FieldName = "IdPedido"
        Me.colIdPedido2.Name = "colIdPedido2"
        Me.colIdPedido2.OptionsEditForm.Caption = "Nro. Pedido"
        '
        'RepositoryItemGridLookUpEdit7
        '
        Me.RepositoryItemGridLookUpEdit7.AutoHeight = false
        Me.RepositoryItemGridLookUpEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit7.DataSource = Me.XpCollectionVistaDetalles
        Me.RepositoryItemGridLookUpEdit7.DisplayMember = "Obsb1"
        Me.RepositoryItemGridLookUpEdit7.Name = "RepositoryItemGridLookUpEdit7"
        Me.RepositoryItemGridLookUpEdit7.ValueMember = "Obsb1"
        Me.RepositoryItemGridLookUpEdit7.View = Me.RepositoryItemGridLookUpEdit7View
        '
        'RepositoryItemGridLookUpEdit7View
        '
        Me.RepositoryItemGridLookUpEdit7View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit7View.Name = "RepositoryItemGridLookUpEdit7View"
        Me.RepositoryItemGridLookUpEdit7View.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.RepositoryItemGridLookUpEdit7View.OptionsView.ShowGroupPanel = false
        '
        'GridView7
        '
        Me.GridView7.GridControl = Me.GridControl2
        Me.GridView7.Name = "GridView7"
        Me.GridView7.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
        '
        'FrMasterDetailPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 466)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FrMasterDetailPedidos"
        Me.Text = "VISUALIZAR PEDIDOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridView8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XpCollectionVistaDetalles2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sectores,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Estados,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit2View,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.proyecto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit8View,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemDateEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemMemoEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Productos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit3View,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemSpinEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemMemoEdit2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemDateEdit2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemResourcesComboBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemComboBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemResourcesComboBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit4View,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit5View,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SplitContainerControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainerControl1.ResumeLayout(false)
        CType(Me.TextEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridControl2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XpCollectionVistaDetalles,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit6View,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit7View,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView7,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents Sectores As DevExpress.Xpo.XPCollection
    Friend WithEvents Estados As DevExpress.Xpo.XPCollection
    Friend WithEvents Productos As DevExpress.Xpo.XPCollection
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemResourcesComboBox1 As DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemResourcesComboBox2 As DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemGridLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit4View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit5View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSector1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaPedido1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResponsable1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdPedido1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservaciones1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaRecepcion1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit6View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XpCollectionVistaDetalles As DevExpress.Xpo.XPCollection
    Friend WithEvents colSector2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaPedido2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResponsable2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservaciones2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaRecepcion2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Observaciones1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRazonSocial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreFantasia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdPedido2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XpCollectionVistaDetalles2 As DevExpress.Xpo.XPCollection
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit7View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents sbimprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents proyecto As DevExpress.Xpo.XPCollection
    Friend WithEvents colSector As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaPedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResponsable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdPedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaRecepcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUrgente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAutorizadoPor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaAprobacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProyecto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit8View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dirlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
