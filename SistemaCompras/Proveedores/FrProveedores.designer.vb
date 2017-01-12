Partial Public Class FrProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrProveedores))
        Me.Proveedores = New DevExpress.Xpo.XPCollection(Me.components)
        Me.Rubros = New DevExpress.Xpo.XPCollection(Me.components)
        Me.Paises = New DevExpress.Xpo.XPCollection(Me.components)
        Me.windowsUIButtonPanel = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.colIdProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRazonSocial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreFantasia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUIT_CUIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaAlta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRubro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefonos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDomicilio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocalidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvincia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPais = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaginaWeb = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObservaciones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabFormDefaultManager1 = New DevExpress.XtraBars.TabFormDefaultManager()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.layoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.itemGrid = New DevExpress.XtraLayout.LayoutControlItem()
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
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.RepositoryItemHyperLinkEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.RepositoryItemMemoExEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.TabFormDefaultManager2 = New DevExpress.XtraBars.TabFormDefaultManager()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        CType(Me.Proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rubros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paises, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabFormDefaultManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.layoutControl.SuspendLayout()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabFormDefaultManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Proveedores
        '
        Me.Proveedores.DisplayableProperties = "IdProveedor;CUIT_CUIL;RazonSocial;NombreFantasia;FechaAlta;Telefonos;Domicilio;Lo" &
    "calidad;CP;Provincia;Pais;Email;PaginaWeb;Observaciones;Rubro"
        Me.Proveedores.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Proveedores)
        '
        'Rubros
        '
        Me.Rubros.DisplayableProperties = "Rubro;Subrubro"
        Me.Rubros.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Rubros)
        '
        'Paises
        '
        Me.Paises.DisplayableProperties = "Pais"
        Me.Paises.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Paises)
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
        Me.windowsUIButtonPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("AGREGAR", CType(resources.GetObject("windowsUIButtonPanel.Buttons"), System.Drawing.Image), "New;Size32x32;GrayScaled", -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Permiite agregar un nuevo registro", True, -1, True, Nothing, True, False, True, Nothing, Nothing, -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("EDITAR", "Edit;Size32x32;GrayScaled", DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Permite modificar el registro seleccionado", True, -1, True, Nothing, True, False, True, Nothing, Nothing, -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("ELIMINAR", "Edit/Delete;Size32x32;GrayScaled", DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Permite eliminar el registro seleccionado", True, -1, True, Nothing, True, False, False, Nothing, Nothing, -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("RECARGAR", "Refresh;Size32x32;GrayScaled", DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Permite recargar la grilla para visualizar datos  que puedan haber sido agregados" &
                    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por otros usuarios", True, -1, True, Nothing, True, False, True, Nothing, Nothing, -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("CANCELAR", CType(resources.GetObject("windowsUIButtonPanel.Buttons1"), System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", True, -1, True, Nothing, True, False, False, Nothing, Nothing, -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("QUITAR FILTROS", CType(resources.GetObject("windowsUIButtonPanel.Buttons2"), System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Limpia los filtros de selección", True, -1, True, Nothing, True, False, True, Nothing, Nothing, -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("CAMBIAR VISTA", CType(resources.GetObject("windowsUIButtonPanel.Buttons3"), System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Cambia entre Vista Grilla y Ficha", True, -1, True, Nothing, True, False, True, Nothing, Nothing, -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("IMPRIMIR", "Preview;Size32x32;GrayScaled", DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Muestra el panel de impresión y exportación", True, -1, True, Nothing, True, False, True, Nothing, Nothing, -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("CONTACTOS", CType(resources.GetObject("windowsUIButtonPanel.Buttons4"), System.Drawing.Image)), New DevExpress.XtraBars.Docking2010.WindowsUIButton("LISTAS DE PRECIOS", CType(resources.GetObject("windowsUIButtonPanel.Buttons5"), System.Drawing.Image))})
        Me.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.windowsUIButtonPanel.EnableImageTransparency = True
        Me.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White
        Me.windowsUIButtonPanel.Location = New System.Drawing.Point(0, 361)
        Me.windowsUIButtonPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.windowsUIButtonPanel.MaximumSize = New System.Drawing.Size(0, 60)
        Me.windowsUIButtonPanel.MinimumSize = New System.Drawing.Size(60, 60)
        Me.windowsUIButtonPanel.Name = "windowsUIButtonPanel"
        Me.windowsUIButtonPanel.Size = New System.Drawing.Size(1115, 60)
        Me.windowsUIButtonPanel.TabIndex = 5
        Me.windowsUIButtonPanel.Text = "windowsUIButtonPanel"
        Me.windowsUIButtonPanel.UseButtonBackgroundImages = False
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
        '
        'colIdProveedor
        '
        Me.colIdProveedor.FieldName = "IdProveedor"
        Me.colIdProveedor.Name = "colIdProveedor"
        '
        'colRazonSocial
        '
        Me.colRazonSocial.Caption = "Razón Social"
        Me.colRazonSocial.FieldName = "RazonSocial"
        Me.colRazonSocial.Name = "colRazonSocial"
        Me.colRazonSocial.Visible = True
        Me.colRazonSocial.VisibleIndex = 0
        Me.colRazonSocial.Width = 219
        '
        'colNombreFantasia
        '
        Me.colNombreFantasia.Caption = "Nombre Fantasía"
        Me.colNombreFantasia.FieldName = "NombreFantasia"
        Me.colNombreFantasia.Name = "colNombreFantasia"
        Me.colNombreFantasia.Visible = True
        Me.colNombreFantasia.VisibleIndex = 1
        Me.colNombreFantasia.Width = 223
        '
        'colCUIT_CUIL
        '
        Me.colCUIT_CUIL.FieldName = "CUIT_CUIL"
        Me.colCUIT_CUIL.Name = "colCUIT_CUIL"
        Me.colCUIT_CUIL.Visible = True
        Me.colCUIT_CUIL.VisibleIndex = 3
        Me.colCUIT_CUIL.Width = 72
        '
        'colFechaAlta
        '
        Me.colFechaAlta.FieldName = "FechaAlta"
        Me.colFechaAlta.Name = "colFechaAlta"
        Me.colFechaAlta.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colFechaAlta.Width = 52
        '
        'colRubro
        '
        Me.colRubro.FieldName = "Rubro"
        Me.colRubro.Name = "colRubro"
        Me.colRubro.Visible = True
        Me.colRubro.VisibleIndex = 2
        Me.colRubro.Width = 108
        '
        'colTelefonos
        '
        Me.colTelefonos.FieldName = "Telefonos"
        Me.colTelefonos.Name = "colTelefonos"
        Me.colTelefonos.Visible = True
        Me.colTelefonos.VisibleIndex = 4
        Me.colTelefonos.Width = 238
        '
        'colDomicilio
        '
        Me.colDomicilio.FieldName = "Domicilio"
        Me.colDomicilio.Name = "colDomicilio"
        Me.colDomicilio.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colDomicilio.Width = 49
        '
        'colLocalidad
        '
        Me.colLocalidad.FieldName = "Localidad"
        Me.colLocalidad.Name = "colLocalidad"
        Me.colLocalidad.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colLocalidad.Width = 49
        '
        'colCP
        '
        Me.colCP.Caption = "Código Postal"
        Me.colCP.FieldName = "CP"
        Me.colCP.Name = "colCP"
        Me.colCP.OptionsEditForm.Caption = "Código Postal"
        Me.colCP.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colCP.Width = 49
        '
        'colProvincia
        '
        Me.colProvincia.FieldName = "Provincia"
        Me.colProvincia.Name = "colProvincia"
        Me.colProvincia.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colProvincia.Width = 49
        '
        'colPais
        '
        Me.colPais.FieldName = "Pais"
        Me.colPais.Name = "colPais"
        Me.colPais.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colPais.Width = 49
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 5
        Me.colEmail.Width = 166
        '
        'colPaginaWeb
        '
        Me.colPaginaWeb.FieldName = "PaginaWeb"
        Me.colPaginaWeb.Name = "colPaginaWeb"
        Me.colPaginaWeb.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colPaginaWeb.Width = 49
        '
        'colObservaciones
        '
        Me.colObservaciones.FieldName = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colObservaciones.Width = 61
        '
        'TabFormDefaultManager1
        '
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlTop)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlBottom)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlLeft)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlRight)
        Me.TabFormDefaultManager1.Form = Me
        Me.TabFormDefaultManager1.MaxItemId = 0
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1115, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 421)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1115, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 421)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1115, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 421)
        '
        'layoutControlGroup
        '
        Me.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.layoutControlGroup.GroupBordersVisible = False
        Me.layoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1})
        Me.layoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.layoutControlGroup.Name = "Root"
        Me.layoutControlGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(40, 40, 0, 0)
        Me.layoutControlGroup.Size = New System.Drawing.Size(1110, 361)
        Me.layoutControlGroup.TextVisible = False
        '
        'itemGrid
        '
        Me.itemGrid.Control = Me.GridControl1
        Me.itemGrid.CustomizationFormText = "itemGrid"
        Me.itemGrid.Location = New System.Drawing.Point(0, 0)
        Me.itemGrid.Name = "itemGrid"
        Me.itemGrid.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.itemGrid.Size = New System.Drawing.Size(1004, 315)
        Me.itemGrid.TextSize = New System.Drawing.Size(0, 0)
        Me.itemGrid.TextVisible = False
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.Proveedores
        Me.GridControl1.Location = New System.Drawing.Point(53, 33)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemDateEdit1, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemGridLookUpEdit3, Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemHyperLinkEdit2, Me.RepositoryItemMemoExEdit2, Me.RepositoryItemComboBox1})
        Me.GridControl1.Size = New System.Drawing.Size(1004, 315)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.LayoutView1, Me.GridView5})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdProveedor1, Me.colCUIT_CUIL1, Me.colRazonSocial1, Me.colNombreFantasia1, Me.colFechaAlta1, Me.colTelefonos1, Me.colDomicilio1, Me.colLocalidad1, Me.colCP1, Me.colProvincia1, Me.colPais1, Me.colEmail1, Me.colPaginaWeb1, Me.colObservaciones1, Me.colRubro1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.GridView1.OptionsCustomization.CustomizationFormSearchBoxVisible = True
        Me.GridView1.OptionsEditForm.EditFormColumnCount = 1
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
        'colIdProveedor1
        '
        Me.colIdProveedor1.FieldName = "IdProveedor"
        Me.colIdProveedor1.Name = "colIdProveedor1"
        Me.colIdProveedor1.Visible = True
        Me.colIdProveedor1.VisibleIndex = 0
        '
        'colCUIT_CUIL1
        '
        Me.colCUIT_CUIL1.FieldName = "CUIT_CUIL"
        Me.colCUIT_CUIL1.Name = "colCUIT_CUIL1"
        Me.colCUIT_CUIL1.Visible = True
        Me.colCUIT_CUIL1.VisibleIndex = 1
        '
        'colRazonSocial1
        '
        Me.colRazonSocial1.FieldName = "RazonSocial"
        Me.colRazonSocial1.Name = "colRazonSocial1"
        Me.colRazonSocial1.Visible = True
        Me.colRazonSocial1.VisibleIndex = 2
        '
        'colNombreFantasia1
        '
        Me.colNombreFantasia1.FieldName = "NombreFantasia"
        Me.colNombreFantasia1.Name = "colNombreFantasia1"
        Me.colNombreFantasia1.Visible = True
        Me.colNombreFantasia1.VisibleIndex = 3
        '
        'colFechaAlta1
        '
        Me.colFechaAlta1.FieldName = "FechaAlta"
        Me.colFechaAlta1.Name = "colFechaAlta1"
        Me.colFechaAlta1.Visible = True
        Me.colFechaAlta1.VisibleIndex = 4
        '
        'colTelefonos1
        '
        Me.colTelefonos1.FieldName = "Telefonos"
        Me.colTelefonos1.Name = "colTelefonos1"
        Me.colTelefonos1.Visible = True
        Me.colTelefonos1.VisibleIndex = 5
        '
        'colDomicilio1
        '
        Me.colDomicilio1.FieldName = "Domicilio"
        Me.colDomicilio1.Name = "colDomicilio1"
        Me.colDomicilio1.Visible = True
        Me.colDomicilio1.VisibleIndex = 6
        '
        'colLocalidad1
        '
        Me.colLocalidad1.FieldName = "Localidad"
        Me.colLocalidad1.Name = "colLocalidad1"
        Me.colLocalidad1.Visible = True
        Me.colLocalidad1.VisibleIndex = 7
        '
        'colCP1
        '
        Me.colCP1.FieldName = "CP"
        Me.colCP1.Name = "colCP1"
        Me.colCP1.Visible = True
        Me.colCP1.VisibleIndex = 8
        '
        'colProvincia1
        '
        Me.colProvincia1.FieldName = "Provincia"
        Me.colProvincia1.Name = "colProvincia1"
        Me.colProvincia1.Visible = True
        Me.colProvincia1.VisibleIndex = 9
        '
        'colPais1
        '
        Me.colPais1.FieldName = "Pais"
        Me.colPais1.Name = "colPais1"
        Me.colPais1.Visible = True
        Me.colPais1.VisibleIndex = 10
        '
        'colEmail1
        '
        Me.colEmail1.FieldName = "Email"
        Me.colEmail1.Name = "colEmail1"
        Me.colEmail1.Visible = True
        Me.colEmail1.VisibleIndex = 11
        '
        'colPaginaWeb1
        '
        Me.colPaginaWeb1.FieldName = "PaginaWeb"
        Me.colPaginaWeb1.Name = "colPaginaWeb1"
        Me.colPaginaWeb1.Visible = True
        Me.colPaginaWeb1.VisibleIndex = 12
        '
        'colObservaciones1
        '
        Me.colObservaciones1.FieldName = "Observaciones"
        Me.colObservaciones1.Name = "colObservaciones1"
        Me.colObservaciones1.Visible = True
        Me.colObservaciones1.VisibleIndex = 13
        '
        'colRubro1
        '
        Me.colRubro1.FieldName = "Rubro"
        Me.colRubro1.Name = "colRubro1"
        Me.colRubro1.Visible = True
        Me.colRubro1.VisibleIndex = 14
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemTextEdit1.MaxLength = 80
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemTextEdit2.MaxLength = 80
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemTextEdit3.Mask.EditMask = "99-99999999-9"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RepositoryItemTextEdit3.MaxLength = 13
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "Rubro"
        Me.RepositoryItemGridLookUpEdit1.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "Rubro"
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemMemoExEdit1.MaxLength = 200
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemTextEdit4.MaxLength = 150
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemTextEdit5.MaxLength = 80
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemTextEdit6.MaxLength = 13
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.DisplayMember = "Pais"
        Me.RepositoryItemGridLookUpEdit3.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.NullText = ""
        Me.RepositoryItemGridLookUpEdit3.ValueMember = "Pais"
        Me.RepositoryItemGridLookUpEdit3.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemHyperLinkEdit1.MaxLength = 40
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'RepositoryItemHyperLinkEdit2
        '
        Me.RepositoryItemHyperLinkEdit2.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit2.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemHyperLinkEdit2.Name = "RepositoryItemHyperLinkEdit2"
        '
        'RepositoryItemMemoExEdit2
        '
        Me.RepositoryItemMemoExEdit2.AutoHeight = False
        Me.RepositoryItemMemoExEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit2.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemMemoExEdit2.Name = "RepositoryItemMemoExEdit2"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Buenos Aires", "Catamarca", "Chaco", "Chubut", "Córdoba", "Corrientes", "Entre Ríos", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan", "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego, Antártida e Islas del Atlántico Sur", "Tucumán"})
        Me.RepositoryItemComboBox1.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'LayoutView1
        '
        Me.LayoutView1.GridControl = Me.GridControl1
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.TemplateCard = Me.LayoutViewCard1
        Me.LayoutView1.ViewCaption = "Layout1"
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.GridControl1
        Me.GridView5.Name = "GridView5"
        '
        'layoutControl
        '
        Me.layoutControl.AllowCustomization = False
        Me.layoutControl.Controls.Add(Me.GridControl1)
        Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Left
        Me.layoutControl.Location = New System.Drawing.Point(0, 0)
        Me.layoutControl.Name = "layoutControl"
        Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(250, 185, 250, 350)
        Me.layoutControl.Root = Me.layoutControlGroup
        Me.layoutControl.Size = New System.Drawing.Size(1110, 361)
        Me.layoutControl.TabIndex = 1
        '
        'XpCollection1
        '
        Me.XpCollection1.DisplayableProperties = "IdProveedor;CUIT_CUIL;RazonSocial;NombreFantasia;FechaAlta;Telefonos;Domicilio;Lo" &
    "calidad;CP;Provincia;Pais;Email;PaginaWeb;Observaciones;Rubro"
        '
        'TabFormDefaultManager2
        '
        Me.TabFormDefaultManager2.DockControls.Add(Me.BarDockControl1)
        Me.TabFormDefaultManager2.DockControls.Add(Me.BarDockControl2)
        Me.TabFormDefaultManager2.DockControls.Add(Me.BarDockControl3)
        Me.TabFormDefaultManager2.DockControls.Add(Me.BarDockControl4)
        Me.TabFormDefaultManager2.Form = Me
        Me.TabFormDefaultManager2.MaxItemId = 0
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(1115, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 421)
        Me.BarDockControl2.Size = New System.Drawing.Size(1115, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 421)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1115, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 421)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.itemGrid})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1030, 361)
        '
        'FrProveedores
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 421)
        Me.Controls.Add(Me.layoutControl)
        Me.Controls.Add(Me.windowsUIButtonPanel)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrProveedores"
        CType(Me.Proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rubros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paises, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabFormDefaultManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.layoutControl.ResumeLayout(False)
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabFormDefaultManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private WithEvents windowsUIButtonPanel As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents Proveedores As DevExpress.Xpo.XPCollection
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents Paises As DevExpress.Xpo.XPCollection
    Friend WithEvents Rubros As DevExpress.Xpo.XPCollection
    Friend WithEvents colIdProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRazonSocial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreFantasia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUIT_CUIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaAlta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRubro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefonos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDomicilio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocalidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvincia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPais As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaginaWeb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabFormDefaultManager1 As DevExpress.XtraBars.TabFormDefaultManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Private WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
    Private WithEvents layoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemHyperLinkEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemMemoExEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents itemGrid As DevExpress.XtraLayout.LayoutControlItem
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
    Friend WithEvents TabFormDefaultManager2 As DevExpress.XtraBars.TabFormDefaultManager
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
End Class
