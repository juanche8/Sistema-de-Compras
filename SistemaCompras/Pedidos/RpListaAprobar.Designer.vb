<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RpListaAprobar
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim Join2 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RpListaAprobar))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrCrossBandBox1 = New DevExpress.XtraReports.UI.XRCrossBandBox()
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7, Me.XrLabel2, Me.XrLabel6})
        Me.Detail.Dpi = 100!
        Me.Detail.HeightF = 24.20832!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.AutoWidth = true
        Me.XrLabel7.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel7.BorderColor = System.Drawing.Color.Black
        Me.XrLabel7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.BorderWidth = 1!
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Pedidos.Producto")})
        Me.XrLabel7.Dpi = 100!
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9!)
        Me.XrLabel7.ForeColor = System.Drawing.Color.Black
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel7.Multiline = true
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(187.5002!, 21.04165!)
        Me.XrLabel7.StylePriority.UseBackColor = false
        Me.XrLabel7.StylePriority.UseBorderColor = false
        Me.XrLabel7.StylePriority.UseBorderDashStyle = false
        Me.XrLabel7.StylePriority.UseBorders = false
        Me.XrLabel7.StylePriority.UseBorderWidth = false
        Me.XrLabel7.StylePriority.UseFont = false
        Me.XrLabel7.StylePriority.UseForeColor = false
        Me.XrLabel7.StylePriority.UsePadding = false
        Me.XrLabel7.StylePriority.UseTextAlignment = false
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.BorderColor = System.Drawing.Color.Black
        Me.XrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.BorderWidth = 1!
        Me.XrLabel2.CanGrow = false
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Pedidos.Cantidad")})
        Me.XrLabel2.Dpi = 100!
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9!)
        Me.XrLabel2.ForeColor = System.Drawing.Color.Black
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(187.5002!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(81.51187!, 21.04165!)
        Me.XrLabel2.StylePriority.UseBackColor = false
        Me.XrLabel2.StylePriority.UseBorderColor = false
        Me.XrLabel2.StylePriority.UseBorderDashStyle = false
        Me.XrLabel2.StylePriority.UseBorders = false
        Me.XrLabel2.StylePriority.UseBorderWidth = false
        Me.XrLabel2.StylePriority.UseFont = false
        Me.XrLabel2.StylePriority.UseForeColor = false
        Me.XrLabel2.StylePriority.UsePadding = false
        Me.XrLabel2.StylePriority.UseTextAlignment = false
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.AutoWidth = true
        Me.XrLabel6.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel6.BorderColor = System.Drawing.Color.Black
        Me.XrLabel6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.BorderWidth = 1!
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Pedidos.Observaciones")})
        Me.XrLabel6.Dpi = 100!
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9!)
        Me.XrLabel6.ForeColor = System.Drawing.Color.Black
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(269.012!, 1.083342!)
        Me.XrLabel6.Multiline = true
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(160.5113!, 19.95831!)
        Me.XrLabel6.StylePriority.UseBackColor = false
        Me.XrLabel6.StylePriority.UseBorderColor = false
        Me.XrLabel6.StylePriority.UseBorderDashStyle = false
        Me.XrLabel6.StylePriority.UseBorders = false
        Me.XrLabel6.StylePriority.UseBorderWidth = false
        Me.XrLabel6.StylePriority.UseFont = false
        Me.XrLabel6.StylePriority.UseForeColor = false
        Me.XrLabel6.StylePriority.UsePadding = false
        Me.XrLabel6.StylePriority.UseTextAlignment = false
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel4.BorderColor = System.Drawing.Color.Black
        Me.XrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.BorderWidth = 1!
        Me.XrLabel4.CanGrow = false
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Pedidos.IdPedido")})
        Me.XrLabel4.Dpi = 100!
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9!)
        Me.XrLabel4.ForeColor = System.Drawing.Color.Black
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(90.625!, 11.29163!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(52.33336!, 23!)
        Me.XrLabel4.StylePriority.UseBackColor = false
        Me.XrLabel4.StylePriority.UseBorderColor = false
        Me.XrLabel4.StylePriority.UseBorderDashStyle = false
        Me.XrLabel4.StylePriority.UseBorders = false
        Me.XrLabel4.StylePriority.UseBorderWidth = false
        Me.XrLabel4.StylePriority.UseFont = false
        Me.XrLabel4.StylePriority.UseForeColor = false
        Me.XrLabel4.StylePriority.UsePadding = false
        Me.XrLabel4.StylePriority.UseTextAlignment = false
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel8.BorderColor = System.Drawing.Color.Black
        Me.XrLabel8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.BorderWidth = 1!
        Me.XrLabel8.CanGrow = false
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Pedidos.Responsable")})
        Me.XrLabel8.Dpi = 100!
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9!)
        Me.XrLabel8.ForeColor = System.Drawing.Color.Black
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(155.4583!, 11.29163!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(193.8567!, 23.00001!)
        Me.XrLabel8.StylePriority.UseBackColor = false
        Me.XrLabel8.StylePriority.UseBorderColor = false
        Me.XrLabel8.StylePriority.UseBorderDashStyle = false
        Me.XrLabel8.StylePriority.UseBorders = false
        Me.XrLabel8.StylePriority.UseBorderWidth = false
        Me.XrLabel8.StylePriority.UseFont = false
        Me.XrLabel8.StylePriority.UseForeColor = false
        Me.XrLabel8.StylePriority.UsePadding = false
        Me.XrLabel8.StylePriority.UseTextAlignment = false
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 100!
        Me.TopMargin.HeightF = 100!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 100!
        Me.BottomMargin.HeightF = 100!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "centralmontagne_sistemaadministracion_Connection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression1.ColumnName = "IdPedido"
        Table1.MetaSerializable = "220|30|125|180"
        Table1.Name = "PedidosDetalles"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "Sector"
        Table2.MetaSerializable = "30|30|125|240"
        Table2.Name = "Pedidos"
        ColumnExpression2.Table = Table2
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "Responsable"
        ColumnExpression3.Table = Table2
        Column3.Expression = ColumnExpression3
        ColumnExpression4.ColumnName = "Producto"
        Table3.MetaSerializable = "375|30|125|180"
        Table3.Name = "Productos"
        ColumnExpression4.Table = Table3
        Column4.Expression = ColumnExpression4
        ColumnExpression5.ColumnName = "Cantidad"
        ColumnExpression5.Table = Table1
        Column5.Expression = ColumnExpression5
        ColumnExpression6.ColumnName = "Observaciones"
        ColumnExpression6.Table = Table1
        Column6.Expression = ColumnExpression6
        ColumnExpression7.ColumnName = "Estado"
        ColumnExpression7.Table = Table2
        Column7.Expression = ColumnExpression7
        ColumnExpression8.ColumnName = "IdDetalle"
        ColumnExpression8.Table = Table1
        Column8.Expression = ColumnExpression8
        ColumnExpression9.ColumnName = "FechaPedido"
        ColumnExpression9.Table = Table2
        Column9.Expression = ColumnExpression9
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Columns.Add(Column3)
        SelectQuery1.Columns.Add(Column4)
        SelectQuery1.Columns.Add(Column5)
        SelectQuery1.Columns.Add(Column6)
        SelectQuery1.Columns.Add(Column7)
        SelectQuery1.Columns.Add(Column8)
        SelectQuery1.Columns.Add(Column9)
        SelectQuery1.FilterString = "[Pedidos.Estado] = 7"
        SelectQuery1.Name = "Pedidos"
        RelationColumnInfo1.NestedKeyColumn = "IdPedido"
        RelationColumnInfo1.ParentKeyColumn = "IdPedido"
        Join1.KeyColumns.Add(RelationColumnInfo1)
        Join1.Nested = Table1
        Join1.Parent = Table2
        RelationColumnInfo2.NestedKeyColumn = "Id"
        RelationColumnInfo2.ParentKeyColumn = "IdProducto"
        Join2.KeyColumns.Add(RelationColumnInfo2)
        Join2.Nested = Table3
        Join2.Parent = Table1
        SelectQuery1.Relations.Add(Join1)
        SelectQuery1.Relations.Add(Join2)
        SelectQuery1.Tables.Add(Table2)
        SelectQuery1.Tables.Add(Table1)
        SelectQuery1.Tables.Add(Table3)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'XrLabel14
        '
        Me.XrLabel14.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel14.BorderColor = System.Drawing.Color.Black
        Me.XrLabel14.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel14.BorderWidth = 1!
        Me.XrLabel14.CanGrow = false
        Me.XrLabel14.Dpi = 100!
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 10!)
        Me.XrLabel14.ForeColor = System.Drawing.Color.Black
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(0!, 46!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(187.5002!, 23.00002!)
        Me.XrLabel14.StylePriority.UseBackColor = false
        Me.XrLabel14.StylePriority.UseBorderColor = false
        Me.XrLabel14.StylePriority.UseBorderDashStyle = false
        Me.XrLabel14.StylePriority.UseBorders = false
        Me.XrLabel14.StylePriority.UseBorderWidth = false
        Me.XrLabel14.StylePriority.UseFont = false
        Me.XrLabel14.StylePriority.UseForeColor = false
        Me.XrLabel14.StylePriority.UsePadding = false
        Me.XrLabel14.StylePriority.UseTextAlignment = false
        Me.XrLabel14.Text = "Producto"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel9.BorderColor = System.Drawing.Color.Black
        Me.XrLabel9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel9.BorderWidth = 1!
        Me.XrLabel9.CanGrow = false
        Me.XrLabel9.Dpi = 100!
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 10!)
        Me.XrLabel9.ForeColor = System.Drawing.Color.Black
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(187.5002!, 46!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(79.16678!, 23.00002!)
        Me.XrLabel9.StylePriority.UseBackColor = false
        Me.XrLabel9.StylePriority.UseBorderColor = false
        Me.XrLabel9.StylePriority.UseBorderDashStyle = false
        Me.XrLabel9.StylePriority.UseBorders = false
        Me.XrLabel9.StylePriority.UseBorderWidth = false
        Me.XrLabel9.StylePriority.UseFont = false
        Me.XrLabel9.StylePriority.UseForeColor = false
        Me.XrLabel9.StylePriority.UsePadding = false
        Me.XrLabel9.StylePriority.UseTextAlignment = false
        Me.XrLabel9.Text = "Cantidad"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel13.BorderColor = System.Drawing.Color.Black
        Me.XrLabel13.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel13.BorderWidth = 1!
        Me.XrLabel13.CanGrow = false
        Me.XrLabel13.Dpi = 100!
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 10!)
        Me.XrLabel13.ForeColor = System.Drawing.Color.Black
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(266.6669!, 46!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(162.8564!, 23.00002!)
        Me.XrLabel13.StylePriority.UseBackColor = false
        Me.XrLabel13.StylePriority.UseBorderColor = false
        Me.XrLabel13.StylePriority.UseBorderDashStyle = false
        Me.XrLabel13.StylePriority.UseBorders = false
        Me.XrLabel13.StylePriority.UseBorderWidth = false
        Me.XrLabel13.StylePriority.UseFont = false
        Me.XrLabel13.StylePriority.UseForeColor = false
        Me.XrLabel13.StylePriority.UsePadding = false
        Me.XrLabel13.StylePriority.UseTextAlignment = false
        Me.XrLabel13.Text = "Observaciones"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3})
        Me.XrTableRow1.Dpi = 100!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Dpi = 100!
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "XrTableCell1"
        Me.XrTableCell1.Weight = 1R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Dpi = 100!
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "XrTableCell2"
        Me.XrTableCell2.Weight = 1R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Dpi = 100!
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "XrTableCell3"
        Me.XrTableCell3.Weight = 1R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6})
        Me.XrTableRow2.Dpi = 100!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Dpi = 100!
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "XrTableCell4"
        Me.XrTableCell4.Weight = 1R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Dpi = 100!
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "XrTableCell5"
        Me.XrTableCell5.Weight = 1R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Dpi = 100!
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "XrTableCell6"
        Me.XrTableCell6.Weight = 1R
        '
        'PageFooterBand1
        '
        Me.PageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.PageFooterBand1.Dpi = 100!
        Me.PageFooterBand1.HeightF = 35!
        Me.PageFooterBand1.Name = "PageFooterBand1"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Dpi = 100!
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(5.999996!, 5.999996!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(168.0553!, 23!)
        Me.XrPageInfo1.StyleName = "PageInfo"
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrLabel1})
        Me.ReportHeaderBand1.Dpi = 100!
        Me.ReportHeaderBand1.HeightF = 53!
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 100!
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 15!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(316.9287!, 6.00001!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(252.8212!, 31.00001!)
        Me.XrLabel3.StyleName = "Title"
        Me.XrLabel3.StylePriority.UseFont = false
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 100!
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 15!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6.00001!, 6.00001!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(310.9287!, 35!)
        Me.XrLabel1.StyleName = "Title"
        Me.XrLabel1.StylePriority.UseFont = false
        Me.XrLabel1.Text = "Listado de pedidos por Autorizar   -"
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1!
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 21!)
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
        Me.FieldCaption.BorderColor = System.Drawing.Color.Black
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.FieldCaption.BorderWidth = 1!
        Me.FieldCaption.Font = New System.Drawing.Font("Times New Roman", 10!)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Black
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.Transparent
        Me.PageInfo.BorderColor = System.Drawing.Color.Black
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1!
        Me.PageInfo.Font = New System.Drawing.Font("Arial", 8!)
        Me.PageInfo.ForeColor = System.Drawing.Color.Black
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.Transparent
        Me.DataField.BorderColor = System.Drawing.Color.Black
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1!
        Me.DataField.Font = New System.Drawing.Font("Arial", 9!)
        Me.DataField.ForeColor = System.Drawing.Color.Black
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        '
        'XrLabel5
        '
        Me.XrLabel5.Dpi = 100!
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(1.041667!, 11.29163!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(89.58334!, 23!)
        Me.XrLabel5.Text = "Nro de Pedido:"
        '
        'FormattingRule1
        '
        Me.FormattingRule1.DataMember = "Pedidos"
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel15, Me.XrLabel12, Me.XrLabel11, Me.XrLabel5, Me.XrLabel8, Me.XrLabel4, Me.XrLabel14, Me.XrLabel9, Me.XrLabel13})
        Me.GroupHeader1.Dpi = 100!
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("IdPedido", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("Responsable", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 72.91666!
        Me.GroupHeader1.Level = 1
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel15
        '
        Me.XrLabel15.Dpi = 100!
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(349.315!, 11.29163!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(100.6433!, 23!)
        Me.XrLabel15.Text = "Fecha del pedido:"
        '
        'XrLabel12
        '
        Me.XrLabel12.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel12.BorderColor = System.Drawing.Color.Black
        Me.XrLabel12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.BorderWidth = 1!
        Me.XrLabel12.CanGrow = false
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Pedidos.FechaPedido", "{0:dd/MM/yyyy}")})
        Me.XrLabel12.Dpi = 100!
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 9!)
        Me.XrLabel12.ForeColor = System.Drawing.Color.Black
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(449.9583!, 11.29163!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(86.565!, 23.00001!)
        Me.XrLabel12.StylePriority.UseBackColor = false
        Me.XrLabel12.StylePriority.UseBorderColor = false
        Me.XrLabel12.StylePriority.UseBorderDashStyle = false
        Me.XrLabel12.StylePriority.UseBorders = false
        Me.XrLabel12.StylePriority.UseBorderWidth = false
        Me.XrLabel12.StylePriority.UseFont = false
        Me.XrLabel12.StylePriority.UseForeColor = false
        Me.XrLabel12.StylePriority.UsePadding = false
        Me.XrLabel12.StylePriority.UseTextAlignment = false
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Dpi = 100!
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(142.9584!, 10.00001!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(12.49997!, 23!)
        Me.XrLabel11.Text = "-"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.XrLine2})
        Me.GroupFooter1.Dpi = 100!
        Me.GroupFooter1.HeightF = 47.66668!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel10
        '
        Me.XrLabel10.Dpi = 100!
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(476!, 17.29162!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(93.74994!, 23!)
        Me.XrLabel10.Text = "AUTORIZADO"
        '
        'XrLine2
        '
        Me.XrLine2.Dpi = 100!
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(438.5!, 2.624957!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(179.1666!, 14.66667!)
        '
        'XrCrossBandBox1
        '
        Me.XrCrossBandBox1.BorderWidth = 1!
        Me.XrCrossBandBox1.Dpi = 100!
        Me.XrCrossBandBox1.EndBand = Me.GroupFooter1
        Me.XrCrossBandBox1.EndPointFloat = New DevExpress.Utils.PointFloat(0!, 40.29168!)
        Me.XrCrossBandBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
        Me.XrCrossBandBox1.Name = "XrCrossBandBox1"
        Me.XrCrossBandBox1.StartBand = Me.GroupHeader1
        Me.XrCrossBandBox1.StartPointFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
        Me.XrCrossBandBox1.WidthF = 641!
        '
        'RpListaAprobar
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooterBand1, Me.ReportHeaderBand1, Me.GroupHeader1, Me.GroupFooter1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.CrossBandControls.AddRange(New DevExpress.XtraReports.UI.XRCrossBandControl() {Me.XrCrossBandBox1})
        Me.DataMember = "Pedidos"
        Me.DataSource = Me.SqlDataSource1
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1})
        Me.Margins = New System.Drawing.Printing.Margins(99, 100, 100, 100)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "16.1"
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrCrossBandBox1 As DevExpress.XtraReports.UI.XRCrossBandBox
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
End Class
