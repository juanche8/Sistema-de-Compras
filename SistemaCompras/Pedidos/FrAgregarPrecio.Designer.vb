<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrAgregarPrecio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrAgregarPrecio))
        Me.PROVEEDOR = New DevExpress.XtraEditors.LabelControl()
        Me.PRODUCTO = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.leprov = New DevExpress.XtraEditors.LookUpEdit()
        Me.Proveedores = New DevExpress.Xpo.XPCollection(Me.components)
        Me.leprod = New DevExpress.XtraEditors.LookUpEdit()
        Me.productos = New DevExpress.Xpo.XPCollection(Me.components)
        Me.preciob = New DevExpress.XtraEditors.TextEdit()
        Me.preciou = New DevExpress.XtraEditors.TextEdit()
        Me.descuento = New DevExpress.XtraEditors.TextEdit()
        Me.fechamodif = New DevExpress.XtraEditors.DateEdit()
        Me.gridmoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.moneda = New DevExpress.Xpo.XPCollection(Me.components)
        Me.memobserv = New DevExpress.XtraEditors.MemoEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.leprov.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Proveedores,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.leprod.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.productos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.preciob.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.preciou.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.descuento.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.fechamodif.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.fechamodif.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gridmoneda.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.moneda,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.memobserv.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PROVEEDOR
        '
        Me.PROVEEDOR.Location = New System.Drawing.Point(65, 48)
        Me.PROVEEDOR.Name = "PROVEEDOR"
        Me.PROVEEDOR.Size = New System.Drawing.Size(54, 13)
        Me.PROVEEDOR.TabIndex = 0
        Me.PROVEEDOR.Text = "Proveedor:"
        '
        'PRODUCTO
        '
        Me.PRODUCTO.Location = New System.Drawing.Point(65, 84)
        Me.PRODUCTO.Name = "PRODUCTO"
        Me.PRODUCTO.Size = New System.Drawing.Size(47, 13)
        Me.PRODUCTO.TabIndex = 1
        Me.PRODUCTO.Text = "Producto:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(65, 121)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Precio Base:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(65, 161)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Precio Unitario:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(65, 198)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Descuento %:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(65, 237)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Fecha Modificación:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(65, 271)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl5.TabIndex = 6
        Me.LabelControl5.Text = "Moneda:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(328, 121)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl6.TabIndex = 7
        Me.LabelControl6.Text = "Observaciones:"
        '
        'leprov
        '
        Me.leprov.Location = New System.Drawing.Point(165, 45)
        Me.leprov.Name = "leprov"
        Me.leprov.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leprov.Properties.DataSource = Me.Proveedores
        Me.leprov.Properties.DisplayMember = "RazonSocial"
        Me.leprov.Properties.ValueMember = "IdProveedor"
        Me.leprov.Size = New System.Drawing.Size(165, 20)
        Me.leprov.TabIndex = 8
        '
        'Proveedores
        '
        Me.Proveedores.DisplayableProperties = "IdProveedor;RazonSocial"
        Me.Proveedores.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Proveedores)
        '
        'leprod
        '
        Me.leprod.Location = New System.Drawing.Point(165, 81)
        Me.leprod.Name = "leprod"
        Me.leprod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leprod.Properties.DataSource = Me.productos
        Me.leprod.Properties.DisplayMember = "Producto"
        Me.leprod.Properties.ValueMember = "Id"
        Me.leprod.Size = New System.Drawing.Size(165, 20)
        Me.leprod.TabIndex = 9
        '
        'productos
        '
        Me.productos.DisplayableProperties = "Id;Producto"
        Me.productos.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Productos)
        '
        'preciob
        '
        Me.preciob.EditValue = ""
        Me.preciob.Location = New System.Drawing.Point(165, 118)
        Me.preciob.Name = "preciob"
        Me.preciob.Properties.NullText = "[EditValue is null]"
        Me.preciob.Size = New System.Drawing.Size(92, 20)
        Me.preciob.TabIndex = 10
        '
        'preciou
        '
        Me.preciou.EditValue = ""
        Me.preciou.Location = New System.Drawing.Point(165, 158)
        Me.preciou.Name = "preciou"
        Me.preciou.Properties.NullText = "[EditValue is null]"
        Me.preciou.Size = New System.Drawing.Size(92, 20)
        Me.preciou.TabIndex = 12
        '
        'descuento
        '
        Me.descuento.EditValue = ""
        Me.descuento.Location = New System.Drawing.Point(165, 195)
        Me.descuento.Name = "descuento"
        Me.descuento.Properties.NullText = "[EditValue is null]"
        Me.descuento.Size = New System.Drawing.Size(92, 20)
        Me.descuento.TabIndex = 13
        '
        'fechamodif
        '
        Me.fechamodif.EditValue = ""
        Me.fechamodif.Location = New System.Drawing.Point(165, 234)
        Me.fechamodif.Name = "fechamodif"
        Me.fechamodif.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fechamodif.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fechamodif.Properties.DisplayFormat.FormatString = ""
        Me.fechamodif.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fechamodif.Properties.EditFormat.FormatString = ""
        Me.fechamodif.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fechamodif.Properties.Mask.EditMask = ""
        Me.fechamodif.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.fechamodif.Properties.NullText = "[EditValue is null]"
        Me.fechamodif.Size = New System.Drawing.Size(157, 20)
        Me.fechamodif.TabIndex = 14
        '
        'gridmoneda
        '
        Me.gridmoneda.Location = New System.Drawing.Point(165, 268)
        Me.gridmoneda.Name = "gridmoneda"
        Me.gridmoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gridmoneda.Properties.DataSource = Me.moneda
        Me.gridmoneda.Properties.DisplayMember = "Moneda"
        Me.gridmoneda.Properties.ValueMember = "IdMoneda"
        Me.gridmoneda.Size = New System.Drawing.Size(112, 20)
        Me.gridmoneda.TabIndex = 15
        '
        'moneda
        '
        Me.moneda.DisplayableProperties = "IdMoneda;Moneda"
        Me.moneda.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Monedas)
        '
        'memobserv
        '
        Me.memobserv.EditValue = ""
        Me.memobserv.Location = New System.Drawing.Point(328, 140)
        Me.memobserv.Name = "memobserv"
        Me.memobserv.Properties.NullText = "[EditValue is null]"
        Me.memobserv.Size = New System.Drawing.Size(235, 101)
        Me.memobserv.TabIndex = 16
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"),System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(405, 301)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(76, 67)
        Me.SimpleButton1.TabIndex = 17
        Me.SimpleButton1.Text = "Agregar"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"),System.Drawing.Image)
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(487, 301)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(76, 67)
        Me.SimpleButton2.TabIndex = 18
        Me.SimpleButton2.Text = "Cancelar"
        '
        'FrAgregarPrecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 380)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.descuento)
        Me.Controls.Add(Me.preciou)
        Me.Controls.Add(Me.leprod)
        Me.Controls.Add(Me.leprov)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.PRODUCTO)
        Me.Controls.Add(Me.PROVEEDOR)
        Me.Controls.Add(Me.preciob)
        Me.Controls.Add(Me.fechamodif)
        Me.Controls.Add(Me.gridmoneda)
        Me.Controls.Add(Me.memobserv)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FrAgregarPrecio"
        Me.Text = "AGREGAR PRECIOS"
        CType(Me.leprov.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Proveedores,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.leprod.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.productos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.preciob.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.preciou.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.descuento.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.fechamodif.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.fechamodif.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gridmoneda.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.moneda,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.memobserv.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PROVEEDOR As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PRODUCTO As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leprov As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Proveedores As DevExpress.Xpo.XPCollection
    Friend WithEvents leprod As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents productos As DevExpress.Xpo.XPCollection
    Friend WithEvents preciob As DevExpress.XtraEditors.TextEdit
    Friend WithEvents preciou As DevExpress.XtraEditors.TextEdit
    Friend WithEvents descuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents fechamodif As DevExpress.XtraEditors.DateEdit
    Friend WithEvents gridmoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents moneda As DevExpress.Xpo.XPCollection
    Friend WithEvents memobserv As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
