<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frimage
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
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdPedido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObservaciones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecioProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colODCEnviada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colimage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        CType(Me.XpCollection1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemPictureEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'XpCollection1
        '
        Me.XpCollection1.ObjectType = GetType(SistemaCompras.MontagneAdministracion.PedidosDetalles)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.XpCollection1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(827, 301)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdDetalle, Me.colIdPedido, Me.colIdProducto, Me.colCantidad, Me.colObservaciones, Me.colPrecioProducto, Me.colIdProveedor, Me.colODCEnviada, Me.colimage})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colIdDetalle
        '
        Me.colIdDetalle.FieldName = "IdDetalle"
        Me.colIdDetalle.Name = "colIdDetalle"
        Me.colIdDetalle.Visible = true
        Me.colIdDetalle.VisibleIndex = 0
        '
        'colIdPedido
        '
        Me.colIdPedido.FieldName = "IdPedido"
        Me.colIdPedido.Name = "colIdPedido"
        Me.colIdPedido.Visible = true
        Me.colIdPedido.VisibleIndex = 1
        '
        'colIdProducto
        '
        Me.colIdProducto.FieldName = "IdProducto"
        Me.colIdProducto.Name = "colIdProducto"
        Me.colIdProducto.Visible = true
        Me.colIdProducto.VisibleIndex = 2
        '
        'colCantidad
        '
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = true
        Me.colCantidad.VisibleIndex = 3
        '
        'colObservaciones
        '
        Me.colObservaciones.FieldName = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.Visible = true
        Me.colObservaciones.VisibleIndex = 4
        '
        'colPrecioProducto
        '
        Me.colPrecioProducto.FieldName = "PrecioProducto"
        Me.colPrecioProducto.Name = "colPrecioProducto"
        Me.colPrecioProducto.Visible = true
        Me.colPrecioProducto.VisibleIndex = 5
        '
        'colIdProveedor
        '
        Me.colIdProveedor.FieldName = "IdProveedor"
        Me.colIdProveedor.Name = "colIdProveedor"
        Me.colIdProveedor.Visible = true
        Me.colIdProveedor.VisibleIndex = 6
        '
        'colODCEnviada
        '
        Me.colODCEnviada.FieldName = "ODCEnviada"
        Me.colODCEnviada.Name = "colODCEnviada"
        Me.colODCEnviada.Visible = true
        Me.colODCEnviada.VisibleIndex = 7
        '
        'colimage
        '
        Me.colimage.Caption = "img"
        Me.colimage.ColumnEdit = Me.RepositoryItemPictureEdit1
        Me.colimage.Name = "colimage"
        Me.colimage.Visible = true
        Me.colimage.VisibleIndex = 8
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        Me.RepositoryItemPictureEdit1.ZoomAccelerationFactor = 1R
        '
        'frimage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 301)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frimage"
        Me.Text = "frimage"
        CType(Me.XpCollection1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemPictureEdit1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdPedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colODCEnviada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colimage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
End Class
