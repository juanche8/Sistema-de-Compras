<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrRoles
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrRoles))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRol = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.limpiafiltros = New DevExpress.XtraEditors.SimpleButton()
        Me.imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.FlyoutPanel1 = New DevExpress.Utils.FlyoutPanel()
        Me.descri = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.roldup = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.nuevorol = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel1.SuspendLayout()
        CType(Me.descri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.roldup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuevorol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 5
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar2.FloatLocation = New System.Drawing.Point(139, 442)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "AGREGAR"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "EDITAR"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "COPIAR ROL"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "MODIFICAR ROL"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(743, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 345)
        Me.barDockControlBottom.Size = New System.Drawing.Size(743, 26)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 345)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(743, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 345)
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "MODIFICAR ROL"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'XpCollection1
        '
        Me.XpCollection1.ObjectType = GetType(MontagneAdministracion.Roles)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.XpCollection1
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridControl1.Location = New System.Drawing.Point(11, 37)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(718, 302)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colRol, Me.colDescripcion})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.GridView1.OptionsEditForm.EditFormColumnCount = 1
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 500
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindNullPrompt = "Ingrese el texto a buscar"
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colRol
        '
        Me.colRol.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colRol.FieldName = "Rol"
        Me.colRol.Name = "colRol"
        Me.colRol.Visible = True
        Me.colRol.VisibleIndex = 0
        Me.colRol.Width = 219
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.MaxLength = 30
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colDescripcion
        '
        Me.colDescripcion.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 480
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.MaxLength = 150
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'limpiafiltros
        '
        Me.limpiafiltros.Location = New System.Drawing.Point(12, 8)
        Me.limpiafiltros.Name = "limpiafiltros"
        Me.limpiafiltros.Size = New System.Drawing.Size(75, 23)
        Me.limpiafiltros.TabIndex = 8
        Me.limpiafiltros.Text = "Limpiar Filtros"
        Me.limpiafiltros.ToolTip = "Limpia los filtros aplicados por columnas"
        '
        'imprimir
        '
        Me.imprimir.Location = New System.Drawing.Point(93, 8)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(75, 23)
        Me.imprimir.TabIndex = 7
        Me.imprimir.Text = "Imprimir"
        Me.imprimir.ToolTip = "Abre la previsualizacoion de impresion y exportacion, Imprime el contenido visual" &
    "izado en la grilla"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(174, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(29, 23)
        Me.SimpleButton2.TabIndex = 20
        Me.SimpleButton2.Text = "SimpleButton2"
        Me.SimpleButton2.ToolTip = "Ayuda"
        '
        'FlyoutPanel1
        '
        Me.FlyoutPanel1.Controls.Add(Me.descri)
        Me.FlyoutPanel1.Controls.Add(Me.LabelControl3)
        Me.FlyoutPanel1.Controls.Add(Me.roldup)
        Me.FlyoutPanel1.Controls.Add(Me.LabelControl2)
        Me.FlyoutPanel1.Controls.Add(Me.nuevorol)
        Me.FlyoutPanel1.Controls.Add(Me.LabelControl1)
        Me.FlyoutPanel1.Controls.Add(Me.SimpleButton1)
        Me.FlyoutPanel1.Location = New System.Drawing.Point(81, 111)
        Me.FlyoutPanel1.Name = "FlyoutPanel1"
        Me.FlyoutPanel1.OwnerControl = Me.barDockControlBottom
        Me.FlyoutPanel1.Size = New System.Drawing.Size(296, 204)
        Me.FlyoutPanel1.TabIndex = 25
        '
        'descri
        '
        Me.descri.Location = New System.Drawing.Point(15, 22)
        Me.descri.MenuManager = Me.BarManager1
        Me.descri.Name = "descri"
        Me.descri.Properties.MaxLength = 150
        Me.descri.Size = New System.Drawing.Size(273, 53)
        Me.descri.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(15, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(129, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "DESCRIPCION NUEVO ROL"
        '
        'roldup
        '
        Me.roldup.EnterMoveNextControl = True
        Me.roldup.Location = New System.Drawing.Point(111, 119)
        Me.roldup.MenuManager = Me.BarManager1
        Me.roldup.Name = "roldup"
        Me.roldup.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.roldup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.roldup.Properties.DataSource = Me.XpCollection1
        Me.roldup.Properties.DisplayMember = "Rol"
        Me.roldup.Properties.NullText = ""
        Me.roldup.Properties.ValueMember = "Id"
        Me.roldup.Size = New System.Drawing.Size(177, 20)
        Me.roldup.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(15, 123)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "ROL A DUPLICAR"
        '
        'nuevorol
        '
        Me.nuevorol.Location = New System.Drawing.Point(111, 90)
        Me.nuevorol.MenuManager = Me.BarManager1
        Me.nuevorol.Name = "nuevorol"
        Me.nuevorol.Size = New System.Drawing.Size(177, 20)
        Me.nuevorol.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 93)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "NUEVO ROL"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(68, 162)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(163, 23)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "CREAR NUEVO ROL"
        '
        'FrRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 371)
        Me.Controls.Add(Me.FlyoutPanel1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.limpiafiltros)
        Me.Controls.Add(Me.imprimir)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrRoles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CATEGORIAS DE ROLES"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel1.ResumeLayout(False)
        Me.FlyoutPanel1.PerformLayout()
        CType(Me.descri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.roldup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuevorol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRol As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents limpiafiltros As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents FlyoutPanel1 As DevExpress.Utils.FlyoutPanel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents roldup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nuevorol As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents descri As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
End Class
