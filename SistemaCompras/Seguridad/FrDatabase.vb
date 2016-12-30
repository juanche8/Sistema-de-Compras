Imports System.Data.SqlClient
Imports DevExpress.Xpo

Public Class FrDatabase
    Public Session1 As Session = XpoHelper.GetNewSession()
    Private Sub FrDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Pedidos.Session = Session1
        Detalles.Session = Session1
        list.Session = Session1
        ListaPrecios.Session = Session1
        SubSector.Session = Session1
        Monedas.Session = Session1
        Cotizaciones.Session = Session1
        CotizacionDetalle.Session = Session1
        Stock.Session = Session1
        BajasMateriales.Session = Session1
        Consumos.Session = Session1
        OrdenesCompra.Session = Session1
        OrdenCompraDetalles.Session = Session1
        MotivosBaja.Session = Session1
        RecepcionProductos.Session = Session1
        Rubros.Session = Session1
        Paises.Session = Session1
        Sectores.Session = Session1
        RemitoRecepcion.Session = Session1
        EstadosPedido.Session = Session1
        Productos.Session = Session1
        UsuarioRol.Session = Session1
        Roles.Session = Session1
        Usuarios.Session = Session1
        Proveedores.Session = Session1
        ContactosProveedores.Session = Session1

    End Sub
    Private Sub GridControl2_Click(sender As Object, e As EventArgs) Handles GridControl2.Click
        Try
            SimpleButton1.Enabled = False
            If GridView2.GetFocusedDisplayText = "PedidosDetalles" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = Detalles
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = "Tabla PedidosDetalles
IdPedido - Pedidos (IdPedido)
IdProducto - Productos (Id)
IdProveedor - Proveedores (IdProveedor)
PrecioProducto - ListaPrecios(PreciUnitario)"
                SimpleButton1.Enabled = True
            End If
            If GridView2.GetFocusedDisplayText = "Pedidos" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = Pedidos
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = "IdPedido -Varias Tablas que contengan IdPedido como Campo
Sector -Sector(IdSector)
Estado -Estados Pedido (IdEstado)
Responsable -Usuario(Apellidos + Nombre)"
            End If
            If GridView2.GetFocusedDisplayText = "ListasPrecios" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = ListaPrecios
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = "Tabla ListaPrecios
IdProveedor - Proveedores(IdProveedor)
IdProducto - Productos(Id)
PrecioUnitario - PedidosDetalles(PrecioProducto)"
            End If
            If GridView2.GetFocusedDisplayText = "SubSector" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = SubSector
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = ""
            End If
            If GridView2.GetFocusedDisplayText = "Monedas" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = Monedas
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = ""
            End If
            If GridView2.GetFocusedDisplayText = "Cotizaciones" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = Cotizaciones
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = ""
            End If
            If GridView2.GetFocusedDisplayText = "CotizacionDetalle" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = CotizacionDetalle
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = ""
            End If
            If GridView2.GetFocusedDisplayText = "Stock" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = Stock
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = "Tabla Stock
IdProducto - Productos(Id)
DelSector - Sectores(IdSector)"
            End If
            If GridView2.GetFocusedDisplayText = "BajasMateriales" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = BajasMateriales
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = ""
                

            End If
            If GridView2.GetFocusedDisplayText = "Consumos" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = Consumos
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = ""
            End If
            If GridView2.GetFocusedDisplayText = "OrdenesCompra" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = OrdenesCompra
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = "Tabla OrdenesCompra
IdProveedor - ListaPrecios(IdProveedor)
Moneda - Monedas(IdMoneda)"

            End If
            If GridView2.GetFocusedDisplayText = "OrdenCompraDetalles" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = OrdenCompraDetalles
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = "Tabla OrdenCompraDetalles
IdOC - OrdenesCompra(IdOrdenCompra)
IdProducto - ListaPrecios(IdProducto)
IdPedido - Pedidos(IdPedido)"

            End If
            If GridView2.GetFocusedDisplayText = "MotivosBaja" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = MotivosBaja
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = ""
            End If
            If GridView2.GetFocusedDisplayText = "RecepcionProductos" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = RecepcionProductos
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = ""
            End If
            If GridView2.GetFocusedDisplayText = "Rubros" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = Rubros
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = ""

            End If
            If GridView2.GetFocusedDisplayText = "Paises" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = Paises
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = ""

            End If
            If GridView2.GetFocusedDisplayText = "Sectores" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = Sectores
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = "Tabla Sectores
IdSector - Pedidos(Sector)"

            End If
            If GridView2.GetFocusedDisplayText = "RemitoRecepcion" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = RemitoRecepcion
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = ""
            End If
            If GridView2.GetFocusedDisplayText = "EstadosPedido" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = EstadosPedido
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = "Tabla EstadosPedido
IdEstado -Pedidos(Estado)"
            End If
            If GridView2.GetFocusedDisplayText = "Productos" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = Productos
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = "
Tabla Productos:
Id - ListaPrecios(IdProducto)
Id - PedidosDetalles(IdPedido)"

            End If
            If GridView2.GetFocusedDisplayText = "Permisos" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = Permiso
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = ""
            End If
            If GridView2.GetFocusedDisplayText = "Roles" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = Roles
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = ""

            End If
            If GridView2.GetFocusedDisplayText = "UsuarioRol" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = UsuarioRol
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = ""
            End If
            If GridView2.GetFocusedDisplayText = "Usuarios" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = Usuarios
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = ""
            End If
            If GridView2.GetFocusedDisplayText = "Proveedores" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = Proveedores
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = "Tabla Proveedores
IdProveedor - PedidosDetalles(IdProveedor), ListaPrecios(IdProveedor),
Pais - Paises(IdPais)"

            End If
            If GridView2.GetFocusedDisplayText = "ContactosProveedores" Then
                GridControl1.DataSource = Nothing
                GridControl1.DataSource = ContactosProveedores
                GridControl1.MainView.PopulateColumns()
                MemoEdit1.Text = "Tabla ContactosProveedores
IdProveedor - Proveedores(IdProveedor)"

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim del = Session1.ExecuteNonQuery("delete From " & GridView2.GetFocusedDisplayText & " Where IdDetalle = " & GridView1.GetFocusedDisplayText)
        GridView1.RefreshData()
        GridView1.DeleteSelectedRows()
    End Sub
End Class