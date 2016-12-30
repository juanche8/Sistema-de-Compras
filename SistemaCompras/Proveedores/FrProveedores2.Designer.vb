<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrProveedores2
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
        Dim PushTransition1 As DevExpress.Utils.Animation.PushTransition = New DevExpress.Utils.Animation.PushTransition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrProveedores2))
        Me.Proveedores = New DevExpress.Xpo.XPCollection(Me.components)
        Me.Paises = New DevExpress.Xpo.XPCollection(Me.components)
        Me.Rubros = New DevExpress.Xpo.XPCollection(Me.components)
        Me.colIdProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUIT_CUIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRazonSocial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreFantasia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaAlta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefonos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDomicilio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocalidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvincia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPais = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaginaWeb = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObservaciones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRubro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdProveedor1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUIT_CUIL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRazonSocial1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreFantasia1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaAlta1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefonos1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDomicilio1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocalidad1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvincia1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPais1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaginaWeb1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObservaciones1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRubro1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.WorkspaceManager1 = New DevExpress.Utils.WorkspaceManager()
        CType(Me.Proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paises, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rubros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Proveedores
        '
        Me.Proveedores.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Proveedores)
        '
        'Paises
        '
        Me.Paises.DisplayableProperties = "Pais"
        Me.Paises.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Paises)
        '
        'Rubros
        '
        Me.Rubros.DisplayableProperties = "Rubro;Subrubro"
        Me.Rubros.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Rubros)
        '
        'colIdProveedor
        '
        Me.colIdProveedor.FieldName = "IdProveedor"
        Me.colIdProveedor.Name = "colIdProveedor"
        Me.colIdProveedor.Visible = True
        Me.colIdProveedor.VisibleIndex = 0
        Me.colIdProveedor.Width = 40
        '
        'colCUIT_CUIL
        '
        Me.colCUIT_CUIL.FieldName = "CUIT_CUIL"
        Me.colCUIT_CUIL.Name = "colCUIT_CUIL"
        Me.colCUIT_CUIL.Visible = True
        Me.colCUIT_CUIL.VisibleIndex = 1
        Me.colCUIT_CUIL.Width = 85
        '
        'colRazonSocial
        '
        Me.colRazonSocial.FieldName = "RazonSocial"
        Me.colRazonSocial.Name = "colRazonSocial"
        Me.colRazonSocial.Visible = True
        Me.colRazonSocial.VisibleIndex = 2
        Me.colRazonSocial.Width = 116
        '
        'colNombreFantasia
        '
        Me.colNombreFantasia.FieldName = "NombreFantasia"
        Me.colNombreFantasia.Name = "colNombreFantasia"
        Me.colNombreFantasia.Visible = True
        Me.colNombreFantasia.VisibleIndex = 3
        Me.colNombreFantasia.Width = 93
        '
        'colFechaAlta
        '
        Me.colFechaAlta.FieldName = "FechaAlta"
        Me.colFechaAlta.Name = "colFechaAlta"
        Me.colFechaAlta.Visible = True
        Me.colFechaAlta.VisibleIndex = 13
        Me.colFechaAlta.Width = 58
        '
        'colTelefonos
        '
        Me.colTelefonos.FieldName = "Telefonos"
        Me.colTelefonos.Name = "colTelefonos"
        Me.colTelefonos.Visible = True
        Me.colTelefonos.VisibleIndex = 7
        Me.colTelefonos.Width = 82
        '
        'colDomicilio
        '
        Me.colDomicilio.FieldName = "Domicilio"
        Me.colDomicilio.Name = "colDomicilio"
        Me.colDomicilio.Visible = True
        Me.colDomicilio.VisibleIndex = 8
        Me.colDomicilio.Width = 82
        '
        'colLocalidad
        '
        Me.colLocalidad.FieldName = "Localidad"
        Me.colLocalidad.Name = "colLocalidad"
        Me.colLocalidad.Visible = True
        Me.colLocalidad.VisibleIndex = 5
        Me.colLocalidad.Width = 83
        '
        'colCP
        '
        Me.colCP.FieldName = "CP"
        Me.colCP.Name = "colCP"
        Me.colCP.Width = 64
        '
        'colProvincia
        '
        Me.colProvincia.FieldName = "Provincia"
        Me.colProvincia.Name = "colProvincia"
        Me.colProvincia.Visible = True
        Me.colProvincia.VisibleIndex = 9
        Me.colProvincia.Width = 79
        '
        'colPais
        '
        Me.colPais.FieldName = "Pais"
        Me.colPais.Name = "colPais"
        Me.colPais.Visible = True
        Me.colPais.VisibleIndex = 12
        Me.colPais.Width = 36
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 6
        Me.colEmail.Width = 78
        '
        'colPaginaWeb
        '
        Me.colPaginaWeb.FieldName = "PaginaWeb"
        Me.colPaginaWeb.Name = "colPaginaWeb"
        Me.colPaginaWeb.Visible = True
        Me.colPaginaWeb.VisibleIndex = 10
        Me.colPaginaWeb.Width = 67
        '
        'colObservaciones
        '
        Me.colObservaciones.FieldName = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.Visible = True
        Me.colObservaciones.VisibleIndex = 11
        Me.colObservaciones.Width = 66
        '
        'colRubro
        '
        Me.colRubro.FieldName = "Rubro"
        Me.colRubro.Name = "colRubro"
        Me.colRubro.Visible = True
        Me.colRubro.VisibleIndex = 4
        Me.colRubro.Width = 106
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.Proveedores
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.LookAndFeel.SkinName = "Money Twins"
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(1045, 295)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdProveedor1, Me.colCUIT_CUIL1, Me.colRazonSocial1, Me.colNombreFantasia1, Me.colFechaAlta1, Me.colTelefonos1, Me.colDomicilio1, Me.colLocalidad1, Me.colCP1, Me.colProvincia1, Me.colPais1, Me.colEmail1, Me.colPaginaWeb1, Me.colObservaciones1, Me.colRubro1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.GridView1.OptionsCustomization.CustomizationFormSearchBoxVisible = True
        Me.GridView1.OptionsEditForm.EditFormColumnCount = 2
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindNullPrompt = "Ingrese el texto a buscar..."
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowChildrenInGroupPanel = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colIdProveedor1
        '
        Me.colIdProveedor1.Caption = "ID"
        Me.colIdProveedor1.FieldName = "IdProveedor"
        Me.colIdProveedor1.Name = "colIdProveedor1"
        Me.colIdProveedor1.OptionsColumn.FixedWidth = True
        Me.colIdProveedor1.Visible = True
        Me.colIdProveedor1.VisibleIndex = 0
        Me.colIdProveedor1.Width = 37
        '
        'colCUIT_CUIL1
        '
        Me.colCUIT_CUIL1.FieldName = "CUIT_CUIL"
        Me.colCUIT_CUIL1.Name = "colCUIT_CUIL1"
        Me.colCUIT_CUIL1.Visible = True
        Me.colCUIT_CUIL1.VisibleIndex = 1
        Me.colCUIT_CUIL1.Width = 89
        '
        'colRazonSocial1
        '
        Me.colRazonSocial1.FieldName = "RazonSocial"
        Me.colRazonSocial1.Name = "colRazonSocial1"
        Me.colRazonSocial1.Visible = True
        Me.colRazonSocial1.VisibleIndex = 2
        Me.colRazonSocial1.Width = 139
        '
        'colNombreFantasia1
        '
        Me.colNombreFantasia1.FieldName = "NombreFantasia"
        Me.colNombreFantasia1.Name = "colNombreFantasia1"
        Me.colNombreFantasia1.Visible = True
        Me.colNombreFantasia1.VisibleIndex = 3
        Me.colNombreFantasia1.Width = 120
        '
        'colFechaAlta1
        '
        Me.colFechaAlta1.FieldName = "FechaAlta"
        Me.colFechaAlta1.Name = "colFechaAlta1"
        Me.colFechaAlta1.Visible = True
        Me.colFechaAlta1.VisibleIndex = 12
        Me.colFechaAlta1.Width = 111
        '
        'colTelefonos1
        '
        Me.colTelefonos1.FieldName = "Telefonos"
        Me.colTelefonos1.Name = "colTelefonos1"
        Me.colTelefonos1.Visible = True
        Me.colTelefonos1.VisibleIndex = 5
        Me.colTelefonos1.Width = 78
        '
        'colDomicilio1
        '
        Me.colDomicilio1.FieldName = "Domicilio"
        Me.colDomicilio1.Name = "colDomicilio1"
        Me.colDomicilio1.Visible = True
        Me.colDomicilio1.VisibleIndex = 10
        Me.colDomicilio1.Width = 58
        '
        'colLocalidad1
        '
        Me.colLocalidad1.FieldName = "Localidad"
        Me.colLocalidad1.Name = "colLocalidad1"
        Me.colLocalidad1.Visible = True
        Me.colLocalidad1.VisibleIndex = 9
        Me.colLocalidad1.Width = 77
        '
        'colCP1
        '
        Me.colCP1.FieldName = "CP"
        Me.colCP1.Name = "colCP1"
        Me.colCP1.Visible = True
        Me.colCP1.VisibleIndex = 11
        Me.colCP1.Width = 58
        '
        'colProvincia1
        '
        Me.colProvincia1.FieldName = "Provincia"
        Me.colProvincia1.Name = "colProvincia1"
        Me.colProvincia1.Visible = True
        Me.colProvincia1.VisibleIndex = 8
        Me.colProvincia1.Width = 68
        '
        'colPais1
        '
        Me.colPais1.FieldName = "Pais"
        Me.colPais1.Name = "colPais1"
        Me.colPais1.Visible = True
        Me.colPais1.VisibleIndex = 7
        Me.colPais1.Width = 82
        '
        'colEmail1
        '
        Me.colEmail1.FieldName = "Email"
        Me.colEmail1.Name = "colEmail1"
        Me.colEmail1.Visible = True
        Me.colEmail1.VisibleIndex = 6
        Me.colEmail1.Width = 107
        '
        'colPaginaWeb1
        '
        Me.colPaginaWeb1.FieldName = "PaginaWeb"
        Me.colPaginaWeb1.Name = "colPaginaWeb1"
        Me.colPaginaWeb1.Width = 82
        '
        'colObservaciones1
        '
        Me.colObservaciones1.FieldName = "Observaciones"
        Me.colObservaciones1.Name = "colObservaciones1"
        Me.colObservaciones1.Width = 40
        '
        'colRubro1
        '
        Me.colRubro1.FieldName = "Rubro"
        Me.colRubro1.Name = "colRubro1"
        Me.colRubro1.Visible = True
        Me.colRubro1.VisibleIndex = 4
        Me.colRubro1.Width = 121
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.Paises
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "Pais"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "Pais"
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
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.Rubros
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "Rubro"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "Rubro"
        Me.RepositoryItemGridLookUpEdit2.View = Me.RepositoryItemGridLookUpEdit2View
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7})
        Me.BarManager1.MaxItemId = 8
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Agregar"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Editar"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Recargar"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Quitar filtros"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Lista de precios"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Contactos"
        Me.BarButtonItem6.Id = 6
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Imprimir"
        Me.BarButtonItem7.Id = 7
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1045, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 295)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1045, 24)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 295)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1045, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 295)
        '
        'WorkspaceManager1
        '
        Me.WorkspaceManager1.TargetControl = Me
        Me.WorkspaceManager1.TransitionType = PushTransition1
        '
        'FrProveedores2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1045, 319)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrProveedores2"
        Me.Text = "PROVEEDORES"
        CType(Me.Proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paises, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rubros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Proveedores As DevExpress.Xpo.XPCollection
    Friend WithEvents Paises As DevExpress.Xpo.XPCollection
    Friend WithEvents Rubros As DevExpress.Xpo.XPCollection
    Friend WithEvents colIdProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUIT_CUIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRazonSocial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreFantasia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaAlta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefonos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDomicilio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocalidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvincia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPais As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaginaWeb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRubro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdProveedor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUIT_CUIL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRazonSocial1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreFantasia1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaAlta1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefonos1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDomicilio1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocalidad1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvincia1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPais1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaginaWeb1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservaciones1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRubro1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents WorkspaceManager1 As DevExpress.Utils.WorkspaceManager
End Class
