<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrObjetos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrObjetos))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObjeto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colTag = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.limpiafiltros = New DevExpress.XtraEditors.SimpleButton()
        Me.imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.XpCollection1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar2.FloatLocation = New System.Drawing.Point(162, 576)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, Me.BarButtonItem3, false)})
        Me.Bar2.OptionsBar.MultiLine = true
        Me.Bar2.OptionsBar.UseWholeRow = true
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
        Me.BarButtonItem3.Caption = "ELIMINAR"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = false
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(720, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = false
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 423)
        Me.barDockControlBottom.Size = New System.Drawing.Size(720, 26)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = false
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 423)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = false
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(720, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 423)
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.XpCollection1
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Visible = false
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false
        Me.GridControl1.Location = New System.Drawing.Point(13, 41)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3})
        Me.GridControl1.Size = New System.Drawing.Size(695, 367)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.UseEmbeddedNavigator = true
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'XpCollection1
        '
        Me.XpCollection1.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Objetos)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colObjeto, Me.colTag, Me.colDescripcion})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = true
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.GridView1.OptionsEditForm.EditFormColumnCount = 1
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 500
        Me.GridView1.OptionsFind.AlwaysVisible = true
        Me.GridView1.OptionsFind.FindNullPrompt = "Ingrese el texto a buscar"
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = true
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = true
        Me.GridView1.OptionsView.ShowAutoFilterRow = true
        Me.GridView1.OptionsView.ShowFooter = true
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colObjeto
        '
        Me.colObjeto.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colObjeto.FieldName = "Objeto"
        Me.colObjeto.Name = "colObjeto"
        Me.colObjeto.Visible = true
        Me.colObjeto.VisibleIndex = 0
        Me.colObjeto.Width = 225
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = false
        Me.RepositoryItemTextEdit1.MaxLength = 30
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colTag
        '
        Me.colTag.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colTag.FieldName = "Tag"
        Me.colTag.Name = "colTag"
        Me.colTag.Visible = true
        Me.colTag.VisibleIndex = 2
        Me.colTag.Width = 118
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = false
        Me.RepositoryItemTextEdit2.MaxLength = 5
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'colDescripcion
        '
        Me.colDescripcion.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = true
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 333
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = false
        Me.RepositoryItemTextEdit3.MaxLength = 150
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'limpiafiltros
        '
        Me.limpiafiltros.Location = New System.Drawing.Point(13, 12)
        Me.limpiafiltros.Name = "limpiafiltros"
        Me.limpiafiltros.Size = New System.Drawing.Size(75, 23)
        Me.limpiafiltros.TabIndex = 10
        Me.limpiafiltros.Text = "Limpiar Filtros"
        Me.limpiafiltros.ToolTip = "Limpia los filtros aplicados por columnas"
        '
        'imprimir
        '
        Me.imprimir.Location = New System.Drawing.Point(94, 12)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(75, 23)
        Me.imprimir.TabIndex = 9
        Me.imprimir.Text = "Imprimir"
        Me.imprimir.ToolTip = "Abre la previsualizacoion de impresion y exportacion, Imprime el contenido visual"& _ 
    "izado en la grilla"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(175, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(29, 23)
        Me.SimpleButton2.TabIndex = 19
        Me.SimpleButton2.Text = "SimpleButton2"
        Me.SimpleButton2.ToolTip = "Ayuda"
        '
        'FrObjetos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 449)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.limpiafiltros)
        Me.Controls.Add(Me.imprimir)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FrObjetos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TIPOS DE OBJETOS"
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XpCollection1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit3,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObjeto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colTag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents limpiafiltros As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
