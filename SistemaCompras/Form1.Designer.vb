<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
        Me.CheckedListBoxControl1 = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PopupContainerEdit1 = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.prod1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.prods = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.prod2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoProducto1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoAlfa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ComboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxEdit3 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxEdit4 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PopupContainerControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PopupContainerControl1.SuspendLayout
        CType(Me.CheckedListBoxControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.XpCollection1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PopupContainerEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.prod1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.prods,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridLookUpEdit1View,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.prod2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ComboBoxEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ComboBoxEdit2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ComboBoxEdit3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ComboBoxEdit4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.CheckedListBoxControl1)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(26, 58)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(221, 171)
        Me.PopupContainerControl1.TabIndex = 16
        '
        'CheckedListBoxControl1
        '
        Me.CheckedListBoxControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckedListBoxControl1.DataSource = Me.XpCollection1
        Me.CheckedListBoxControl1.DisplayMember = "RazonSocial"
        Me.CheckedListBoxControl1.Location = New System.Drawing.Point(0, 3)
        Me.CheckedListBoxControl1.MultiColumn = true
        Me.CheckedListBoxControl1.Name = "CheckedListBoxControl1"
        Me.CheckedListBoxControl1.Size = New System.Drawing.Size(218, 104)
        Me.CheckedListBoxControl1.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.CheckedListBoxControl1.TabIndex = 13
        Me.CheckedListBoxControl1.ValueMember = "IdProveedor"
        '
        'XpCollection1
        '
        Me.XpCollection1.DisplayableProperties = "IdProveedor;RazonSocial;Rubro"
        Me.XpCollection1.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Proveedores)
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(70, 268)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 14
        Me.SimpleButton1.Text = "enviar"
        '
        'PopupContainerEdit1
        '
        Me.PopupContainerEdit1.EditValue = "Seleccion de proveedor"
        Me.PopupContainerEdit1.Location = New System.Drawing.Point(26, 32)
        Me.PopupContainerEdit1.Name = "PopupContainerEdit1"
        Me.PopupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PopupContainerEdit1.Properties.PopupControl = Me.PopupContainerControl1
        Me.PopupContainerEdit1.Size = New System.Drawing.Size(232, 20)
        Me.PopupContainerEdit1.TabIndex = 15
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(52, 6)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(206, 20)
        Me.TextEdit1.TabIndex = 17
        '
        'prod1
        '
        Me.prod1.Location = New System.Drawing.Point(500, 6)
        Me.prod1.Name = "prod1"
        Me.prod1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.prod1.Properties.DataSource = Me.prods
        Me.prod1.Properties.DisplayMember = "CodigoProducto"
        Me.prod1.Properties.NullText = ""
        Me.prod1.Properties.ValueMember = "CodigoProducto"
        Me.prod1.Properties.View = Me.GridLookUpEdit1View
        Me.prod1.Size = New System.Drawing.Size(137, 20)
        Me.prod1.TabIndex = 18
        '
        'prods
        '
        Me.prods.ObjectType = GetType(SistemaCompras.MontagneAdministracion.ProductosProduccion)
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoProducto})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = false
        '
        'colCodigoProducto
        '
        Me.colCodigoProducto.FieldName = "CodigoProducto"
        Me.colCodigoProducto.Name = "colCodigoProducto"
        Me.colCodigoProducto.Visible = true
        Me.colCodigoProducto.VisibleIndex = 0
        '
        'prod2
        '
        Me.prod2.Location = New System.Drawing.Point(643, 6)
        Me.prod2.Name = "prod2"
        Me.prod2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.prod2.Properties.DataSource = Me.prods
        Me.prod2.Properties.DisplayMember = "CodigoProducto"
        Me.prod2.Properties.NullText = ""
        Me.prod2.Properties.ValueMember = "CodigoProducto"
        Me.prod2.Properties.View = Me.GridView1
        Me.prod2.Size = New System.Drawing.Size(137, 20)
        Me.prod2.TabIndex = 19
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoProducto1, Me.colProducto})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.CustomizationFormSearchBoxVisible = true
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.GridView1.OptionsView.ShowAutoFilterRow = true
        Me.GridView1.OptionsView.ShowGroupPanel = false
        '
        'colCodigoProducto1
        '
        Me.colCodigoProducto1.FieldName = "CodigoProducto"
        Me.colCodigoProducto1.Name = "colCodigoProducto1"
        Me.colCodigoProducto1.OptionsColumn.AllowEdit = false
        Me.colCodigoProducto1.Visible = true
        Me.colCodigoProducto1.VisibleIndex = 0
        Me.colCodigoProducto1.Width = 271
        '
        'colProducto
        '
        Me.colProducto.FieldName = "Producto"
        Me.colProducto.Name = "colProducto"
        Me.colProducto.Visible = true
        Me.colProducto.VisibleIndex = 1
        Me.colProducto.Width = 801
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"),System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(774, 55)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(82, 23)
        Me.SimpleButton2.TabIndex = 20
        Me.SimpleButton2.Text = "Imprimir"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.prods
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(868, 436)
        Me.GridControl1.TabIndex = 21
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoAlfa, Me.colDetalle})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = false
        Me.GridView2.OptionsCustomization.CustomizationFormSearchBoxVisible = true
        Me.GridView2.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.GridView2.OptionsFilter.ShowAllTableValuesInFilterPopup = true
        Me.GridView2.OptionsFilter.UseNewCustomFilterDialog = true
        Me.GridView2.OptionsFind.AlwaysVisible = true
        Me.GridView2.OptionsFind.FindDelay = 100
        Me.GridView2.OptionsFind.FindNullPrompt = "Escribe aca para buscar"
        Me.GridView2.OptionsFind.SearchInPreview = true
        Me.GridView2.OptionsSelection.MultiSelect = true
        Me.GridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridView2.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.GridView2.OptionsView.ShowAutoFilterRow = true
        Me.GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        '
        'colCodigoAlfa
        '
        Me.colCodigoAlfa.FieldName = "CodigoAlfa"
        Me.colCodigoAlfa.Name = "colCodigoAlfa"
        Me.colCodigoAlfa.Visible = true
        Me.colCodigoAlfa.VisibleIndex = 1
        '
        'colDetalle
        '
        Me.colDetalle.FieldName = "Detalle"
        Me.colDetalle.Name = "colDetalle"
        Me.colDetalle.Visible = true
        Me.colDetalle.VisibleIndex = 2
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(550, 58)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"Blanco", "Negro", "Azul", "Morado"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(87, 20)
        Me.ComboBoxEdit1.TabIndex = 23
        '
        'ComboBoxEdit2
        '
        Me.ComboBoxEdit2.Location = New System.Drawing.Point(643, 58)
        Me.ComboBoxEdit2.Name = "ComboBoxEdit2"
        Me.ComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit2.Properties.Items.AddRange(New Object() {"XXL", "XXXL", "L", "S", "M"})
        Me.ComboBoxEdit2.Size = New System.Drawing.Size(87, 20)
        Me.ComboBoxEdit2.TabIndex = 24
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(550, 45)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl1.TabIndex = 25
        Me.LabelControl1.Text = "Color"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(643, 45)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl2.TabIndex = 26
        Me.LabelControl2.Text = "Talle"
        '
        'ComboBoxEdit3
        '
        Me.ComboBoxEdit3.Location = New System.Drawing.Point(364, 58)
        Me.ComboBoxEdit3.Name = "ComboBoxEdit3"
        Me.ComboBoxEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit3.Properties.Items.AddRange(New Object() {"CAMPERA", "REMERA", "BUZO", "CAMISETA", "CHOMBA", "CAMISA", "MUSCULOSA", "ROMPEVIENTO", "POLERON", "PANTALON", "BOXER", "SLIP", "MEDIA", "GUANTES", "MOCHILA", "BERMUDA", "TRAJE DE BAÑO", "SHORT DE BAÑO", "CHALECO", "ROMPEVIENTO"})
        Me.ComboBoxEdit3.Size = New System.Drawing.Size(87, 20)
        Me.ComboBoxEdit3.TabIndex = 27
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(364, 45)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl3.TabIndex = 28
        Me.LabelControl3.Text = "Tipo"
        '
        'ComboBoxEdit4
        '
        Me.ComboBoxEdit4.Location = New System.Drawing.Point(457, 58)
        Me.ComboBoxEdit4.Name = "ComboBoxEdit4"
        Me.ComboBoxEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit4.Properties.Items.AddRange(New Object() {"HOMBRE", "MUJER"})
        Me.ComboBoxEdit4.Size = New System.Drawing.Size(87, 20)
        Me.ComboBoxEdit4.TabIndex = 29
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(457, 45)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl4.TabIndex = 30
        Me.LabelControl4.Text = "Sexo"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(272, 56)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(86, 23)
        Me.SimpleButton3.TabIndex = 31
        Me.SimpleButton3.Text = "Limpiar filtros"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 436)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.ComboBoxEdit4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.ComboBoxEdit3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ComboBoxEdit2)
        Me.Controls.Add(Me.ComboBoxEdit1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.prod2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.PopupContainerControl1)
        Me.Controls.Add(Me.PopupContainerEdit1)
        Me.Controls.Add(Me.prod1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PopupContainerControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PopupContainerControl1.ResumeLayout(false)
        CType(Me.CheckedListBoxControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XpCollection1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PopupContainerEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.prod1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.prods,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridLookUpEdit1View,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.prod2.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ComboBoxEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ComboBoxEdit2.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ComboBoxEdit3.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ComboBoxEdit4.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckedListBoxControl1 As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents PopupContainerEdit1 As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents prods As DevExpress.Xpo.XPCollection
    Friend WithEvents prod1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents prod2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCodigoProducto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoAlfa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit3 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit4 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
End Class
