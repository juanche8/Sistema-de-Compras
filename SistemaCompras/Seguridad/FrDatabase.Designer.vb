<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrDatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrDatabase))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.list = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTabla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Pedidos = New DevExpress.Xpo.XPCollection(Me.components)
        Me.Detalles = New DevExpress.Xpo.XPCollection(Me.components)
        Me.ListaPrecios = New DevExpress.Xpo.XPCollection(Me.components)
        Me.SubSector = New DevExpress.Xpo.XPCollection(Me.components)
        Me.Monedas = New DevExpress.Xpo.XPCollection(Me.components)
        Me.Cotizaciones = New DevExpress.Xpo.XPCollection(Me.components)
        Me.CotizacionDetalle = New DevExpress.Xpo.XPCollection(Me.components)
        Me.Stock = New DevExpress.Xpo.XPCollection(Me.components)
        Me.BajasMateriales = New DevExpress.Xpo.XPCollection(Me.components)
        Me.Consumos = New DevExpress.Xpo.XPCollection(Me.components)
        Me.OrdenesCompra = New DevExpress.Xpo.XPCollection(Me.components)
        Me.OrdenCompraDetalles = New DevExpress.Xpo.XPCollection(Me.components)
        Me.MotivosBaja = New DevExpress.Xpo.XPCollection(Me.components)
        Me.RecepcionProductos = New DevExpress.Xpo.XPCollection(Me.components)
        Me.Rubros = New DevExpress.Xpo.XPCollection(Me.components)
        Me.Paises = New DevExpress.Xpo.XPCollection(Me.components)
        Me.Sectores = New DevExpress.Xpo.XPCollection(Me.components)
        Me.RemitoRecepcion = New DevExpress.Xpo.XPCollection(Me.components)
        Me.EstadosPedido = New DevExpress.Xpo.XPCollection(Me.components)
        Me.Productos = New DevExpress.Xpo.XPCollection(Me.components)
        Me.Roles = New DevExpress.Xpo.XPCollection(Me.components)
        Me.UsuarioRol = New DevExpress.Xpo.XPCollection(Me.components)
        Me.Usuarios = New DevExpress.Xpo.XPCollection(Me.components)
        Me.Proveedores = New DevExpress.Xpo.XPCollection(Me.components)
        Me.ContactosProveedores = New DevExpress.Xpo.XPCollection(Me.components)
        Me.XpCollection4 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.XpCollection5 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.XpCollection6 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        CType(Me.GridControl2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.list,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainerControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainerControl1.SuspendLayout
        CType(Me.MemoEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Pedidos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Detalles,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ListaPrecios,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SubSector,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Monedas,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Cotizaciones,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CotizacionDetalle,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Stock,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BajasMateriales,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Consumos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.OrdenesCompra,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.OrdenCompraDetalles,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MotivosBaja,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RecepcionProductos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Rubros,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Paises,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sectores,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RemitoRecepcion,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.EstadosPedido,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Productos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Roles,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UsuarioRol,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Usuarios,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Proveedores,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ContactosProveedores,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.XpCollection4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.XpCollection5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.XpCollection6,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridControl2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainerControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1198, 468)
        Me.SplitContainer1.SplitterDistance = 163
        Me.SplitContainer1.TabIndex = 0
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.list
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(163, 468)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'list
        '
        Me.list.DisplayableProperties = "id;Tabla"
        Me.list.ObjectType = GetType(SistemaCompras.MontagneAdministracion.ListaTablas)
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTabla})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = false
        Me.GridView2.OptionsView.ShowAutoFilterRow = true
        Me.GridView2.OptionsView.ShowFooter = true
        Me.GridView2.OptionsView.ShowGroupPanel = false
        Me.GridView2.OptionsView.ShowIndicator = false
        '
        'colTabla
        '
        Me.colTabla.FieldName = "Tabla"
        Me.colTabla.Name = "colTabla"
        Me.colTabla.Visible = true
        Me.colTabla.VisibleIndex = 0
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = false
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SimpleButton1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.MemoEdit1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1031, 468)
        Me.SplitContainerControl1.SplitterPosition = 58
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"),System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(890, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(129, 37)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Eliminar"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 3)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(418, 59)
        Me.MemoEdit1.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1031, 404)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowGroup = false
        Me.GridView1.OptionsCustomization.CustomizationFormSearchBoxVisible = true
        Me.GridView1.OptionsDetail.AllowZoomDetail = false
        Me.GridView1.OptionsDetail.EnableMasterViewMode = false
        Me.GridView1.OptionsDetail.ShowDetailTabs = false
        Me.GridView1.OptionsDetail.SmartDetailExpand = false
        Me.GridView1.OptionsFind.SearchInPreview = true
        Me.GridView1.OptionsView.AllowHtmlDrawHeaders = true
        Me.GridView1.OptionsView.ShowAutoFilterRow = true
        Me.GridView1.OptionsView.ShowFooter = true
        Me.GridView1.OptionsView.ShowGroupPanel = false
        '
        'Pedidos
        '
        Me.Pedidos.DisplayableProperties = "Sector;FechaPedido;Responsable;IdPedido;Estado;Observaciones;FechaRecepcion;Urgen"& _ 
    "te;AutorizadoPor;FechaAprobacion"
        Me.Pedidos.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Pedidos)
        '
        'Detalles
        '
        Me.Detalles.DisplayableProperties = "IdDetalle;IdPedido;IdProducto;Cantidad;Observaciones;PrecioProducto;IdProveedor;O"& _ 
    "DCEnviada"
        Me.Detalles.ObjectType = GetType(SistemaCompras.MontagneAdministracion.PedidosDetalles)
        '
        'ListaPrecios
        '
        Me.ListaPrecios.DisplayableProperties = "IdLista;IdProveedor;IdProducto;PrecioBase;PrecioUnitario;Descuento;FechaModificac"& _ 
    "ion;Observaciones;Moneda"
        Me.ListaPrecios.ObjectType = GetType(SistemaCompras.MontagneAdministracion.ListasPrecios)
        '
        'SubSector
        '
        Me.SubSector.DisplayableProperties = "IdSubSector;IdSector;SubSector1;ObservacionesSS"
        Me.SubSector.ObjectType = GetType(SistemaCompras.MontagneAdministracion.SubSector)
        '
        'Monedas
        '
        Me.Monedas.DisplayableProperties = "IdMoneda;Moneda"
        Me.Monedas.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Monedas)
        '
        'Cotizaciones
        '
        Me.Cotizaciones.DisplayableProperties = "IdCotizacion;IdPedido;IdProveedor;FechaCotizacion;Autorizada;Responsable;Moneda;C"& _ 
    "otizacionDetalles"
        Me.Cotizaciones.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Cotizaciones)
        '
        'CotizacionDetalle
        '
        Me.CotizacionDetalle.DisplayableProperties = "IdDetalleCot;IdCotizacion!;IdCotizacion!Key;IdCotizacion;IdProducto;Cantidad;Obse"& _ 
    "rvaciones"
        Me.CotizacionDetalle.ObjectType = GetType(SistemaCompras.MontagneAdministracion.CotizacionDetalle)
        '
        'Stock
        '
        Me.Stock.DisplayableProperties = "Id;StockMinimo;Stock1;FechaModificacion;IdProducto;DelSector"
        Me.Stock.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Stock)
        '
        'BajasMateriales
        '
        Me.BajasMateriales.DisplayableProperties = "IdBaja;Cantidad;FechaBaja;MotivoBaja;Observaciones;IdProducto;Sector"
        Me.BajasMateriales.ObjectType = GetType(SistemaCompras.MontagneAdministracion.BajasMateriales)
        '
        'Consumos
        '
        Me.Consumos.DisplayableProperties = "IdConsumo;Sector;IdProducto;Cantidad;Fecha;Motivo;Stockeado"
        Me.Consumos.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Consumos)
        '
        'OrdenesCompra
        '
        Me.OrdenesCompra.ObjectType = GetType(SistemaCompras.MontagneAdministracion.OrdenesCompra)
        '
        'OrdenCompraDetalles
        '
        Me.OrdenCompraDetalles.DisplayableProperties = "IdDetOC;IdOC!;IdProducto;Cantidad;IdPedido"
        Me.OrdenCompraDetalles.ObjectType = GetType(SistemaCompras.MontagneAdministracion.OrdenCompraDetalles)
        '
        'MotivosBaja
        '
        Me.MotivosBaja.DisplayableProperties = "IdMotivoBaja;MotivoBaja"
        Me.MotivosBaja.ObjectType = GetType(SistemaCompras.MontagneAdministracion.MotivosBaja)
        '
        'RecepcionProductos
        '
        Me.RecepcionProductos.DisplayableProperties = "IdRecepcion;IdProducto;Cantidad;Idremito"
        Me.RecepcionProductos.ObjectType = GetType(SistemaCompras.MontagneAdministracion.RecepcionProductos)
        '
        'Rubros
        '
        Me.Rubros.DisplayableProperties = "IdRubro;Rubro;Subrubro"
        Me.Rubros.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Rubros)
        '
        'Paises
        '
        Me.Paises.DisplayableProperties = "Pais;Idpais"
        Me.Paises.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Paises)
        '
        'Sectores
        '
        Me.Sectores.DisplayableProperties = "IdSector;Sector;Observaciones"
        Me.Sectores.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Sectores)
        '
        'RemitoRecepcion
        '
        Me.RemitoRecepcion.DisplayableProperties = "RemitoNro;IdProveedor;FechaRecepcion;FacturaNro;Responsable;OrdenCompraNro;Stocke"& _ 
    "ado"
        Me.RemitoRecepcion.ObjectType = GetType(SistemaCompras.MontagneAdministracion.RemitoRecepcion)
        '
        'EstadosPedido
        '
        Me.EstadosPedido.DisplayableProperties = "IdEstado;Estado"
        Me.EstadosPedido.ObjectType = GetType(SistemaCompras.MontagneAdministracion.EstadosPedido)
        '
        'Productos
        '
        Me.Productos.DisplayableProperties = "Id;Rubro;Subrubro;CodigoProducto;Producto;Marca;Presentacion"
        Me.Productos.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Productos)
        '
        'Roles
        '
        Me.Roles.DisplayableProperties = "Id;Rol;Descripcion"
        Me.Roles.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Roles)
        '
        'UsuarioRol
        '
        Me.UsuarioRol.DisplayableProperties = "Id;IdRol;UsuarioId"
        Me.UsuarioRol.ObjectType = GetType(SistemaCompras.MontagneAdministracion.UsuarioRol)
        '
        'Usuarios
        '
        Me.Usuarios.DisplayableProperties = "UsuarioID;Contraseña;Apellidos;Nombres;TelfonoParticular;TelefonoCelular;Area;Sec"& _ 
    "cionOficina;Email;Aprueba;Cotiza;Habilitado"
        Me.Usuarios.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Usuarios)
        '
        'Proveedores
        '
        Me.Proveedores.DisplayableProperties = "IdProveedor;CUIT_CUIL;RazonSocial;NombreFantasia;FechaAlta;Telefonos;Domicilio;Lo"& _ 
    "calidad;CP;Provincia;Pais;Email;PaginaWeb;Observaciones;Rubro"
        Me.Proveedores.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Proveedores)
        '
        'ContactosProveedores
        '
        Me.ContactosProveedores.DisplayableProperties = "IdContacto;Idproveedor;Apellidos;Nombres;Sector_Oficina;Telefonos;Email;Observaci"& _ 
    "ones"
        Me.ContactosProveedores.ObjectType = GetType(SistemaCompras.MontagneAdministracion.ContactosProveedores)
        '
        'XpCollection4
        '
        Me.XpCollection4.DisplayableProperties = "Id;IdRol;UsuarioId"
        Me.XpCollection4.ObjectType = GetType(SistemaCompras.MontagneAdministracion.UsuarioRol)
        '
        'XpCollection5
        '
        Me.XpCollection5.DisplayableProperties = "Id;IdRol;UsuarioId"
        Me.XpCollection5.ObjectType = GetType(SistemaCompras.MontagneAdministracion.UsuarioRol)
        '
        'XpCollection6
        '
        Me.XpCollection6.DisplayableProperties = "Id;IdRol;UsuarioId"
        Me.XpCollection6.ObjectType = GetType(SistemaCompras.MontagneAdministracion.UsuarioRol)
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
        '
        'FrDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 468)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FrDatabase"
        Me.Text = "Gestor de datos del Sistema de Compras"
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        CType(Me.GridControl2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.list,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SplitContainerControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainerControl1.ResumeLayout(false)
        CType(Me.MemoEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Pedidos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Detalles,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ListaPrecios,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SubSector,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Monedas,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Cotizaciones,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CotizacionDetalle,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Stock,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BajasMateriales,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Consumos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.OrdenesCompra,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.OrdenCompraDetalles,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MotivosBaja,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RecepcionProductos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Rubros,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Paises,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sectores,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RemitoRecepcion,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EstadosPedido,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Productos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Roles,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UsuarioRol,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Usuarios,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Proveedores,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ContactosProveedores,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XpCollection4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XpCollection5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XpCollection6,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Pedidos As DevExpress.Xpo.XPCollection
    Friend WithEvents list As DevExpress.Xpo.XPCollection
    Friend WithEvents Detalles As DevExpress.Xpo.XPCollection
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTabla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ListaPrecios As DevExpress.Xpo.XPCollection
    Friend WithEvents SubSector As DevExpress.Xpo.XPCollection
    Friend WithEvents Monedas As DevExpress.Xpo.XPCollection
    Friend WithEvents Cotizaciones As DevExpress.Xpo.XPCollection
    Friend WithEvents CotizacionDetalle As DevExpress.Xpo.XPCollection
    Friend WithEvents Stock As DevExpress.Xpo.XPCollection
    Friend WithEvents BajasMateriales As DevExpress.Xpo.XPCollection
    Friend WithEvents Consumos As DevExpress.Xpo.XPCollection
    Friend WithEvents OrdenesCompra As DevExpress.Xpo.XPCollection
    Friend WithEvents OrdenCompraDetalles As DevExpress.Xpo.XPCollection
    Friend WithEvents MotivosBaja As DevExpress.Xpo.XPCollection
    Friend WithEvents RecepcionProductos As DevExpress.Xpo.XPCollection
    Friend WithEvents Rubros As DevExpress.Xpo.XPCollection
    Friend WithEvents Paises As DevExpress.Xpo.XPCollection
    Friend WithEvents Sectores As DevExpress.Xpo.XPCollection
    Friend WithEvents RemitoRecepcion As DevExpress.Xpo.XPCollection
    Friend WithEvents EstadosPedido As DevExpress.Xpo.XPCollection
    Friend WithEvents Productos As DevExpress.Xpo.XPCollection
    Friend WithEvents Roles As DevExpress.Xpo.XPCollection
    Friend WithEvents UsuarioRol As DevExpress.Xpo.XPCollection
    Friend WithEvents Usuarios As DevExpress.Xpo.XPCollection
    Friend WithEvents Proveedores As DevExpress.Xpo.XPCollection
    Friend WithEvents ContactosProveedores As DevExpress.Xpo.XPCollection
    Friend WithEvents XpCollection4 As DevExpress.Xpo.XPCollection
    Friend WithEvents XpCollection5 As DevExpress.Xpo.XPCollection
    Friend WithEvents XpCollection6 As DevExpress.Xpo.XPCollection
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
