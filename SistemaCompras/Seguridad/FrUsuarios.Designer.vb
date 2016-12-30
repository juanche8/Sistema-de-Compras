<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrUsuarios
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrUsuarios))
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUsuarioID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colContraseña = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colApellidos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colNombres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colTelfonoParticular = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colTelefonoCelular = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colArea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colSeccionOficina = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAprueba = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCotiza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHabilitado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colActualizo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.RepositoryItemTextEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.limpiafiltros = New DevExpress.XtraEditors.SimpleButton()
        Me.imprimir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.XpCollection1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemSpinEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemSpinEdit2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemHyperLinkEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit9,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit10,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'XpCollection1
        '
        Me.XpCollection1.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Usuarios)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.XpCollection1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Visible = false
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6, Me.RepositoryItemTextEdit7, Me.RepositoryItemTextEdit8, Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemTextEdit9, Me.RepositoryItemTextEdit10, Me.RepositoryItemSpinEdit1, Me.RepositoryItemSpinEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(1058, 455)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = true
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUsuarioID, Me.colContraseña, Me.colApellidos, Me.colNombres, Me.colTelfonoParticular, Me.colTelefonoCelular, Me.colArea, Me.colSeccionOficina, Me.colEmail, Me.colAprueba, Me.colCotiza, Me.colHabilitado, Me.colActualizo})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.GridView1.OptionsEditForm.EditFormColumnCount = 1
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 500
        Me.GridView1.OptionsFind.AlwaysVisible = true
        Me.GridView1.OptionsFind.FindNullPrompt = "Ingrese el texto a buscar"
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = true
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = true
        Me.GridView1.OptionsPrint.RtfPageHeader = resources.GetString("GridView1.OptionsPrint.RtfPageHeader")
        Me.GridView1.OptionsView.ShowAutoFilterRow = true
        Me.GridView1.OptionsView.ShowFooter = true
        '
        'colUsuarioID
        '
        Me.colUsuarioID.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colUsuarioID.FieldName = "UsuarioID"
        Me.colUsuarioID.Name = "colUsuarioID"
        Me.colUsuarioID.Visible = true
        Me.colUsuarioID.VisibleIndex = 0
        Me.colUsuarioID.Width = 81
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = false
        Me.RepositoryItemTextEdit1.MaxLength = 30
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colContraseña
        '
        Me.colContraseña.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colContraseña.FieldName = "Contraseña"
        Me.colContraseña.Name = "colContraseña"
        Me.colContraseña.Visible = true
        Me.colContraseña.VisibleIndex = 1
        Me.colContraseña.Width = 89
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = false
        Me.RepositoryItemTextEdit2.MaxLength = 60
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        '
        'colApellidos
        '
        Me.colApellidos.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colApellidos.FieldName = "Apellidos"
        Me.colApellidos.Name = "colApellidos"
        Me.colApellidos.Visible = true
        Me.colApellidos.VisibleIndex = 3
        Me.colApellidos.Width = 89
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = false
        Me.RepositoryItemTextEdit3.MaxLength = 30
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'colNombres
        '
        Me.colNombres.ColumnEdit = Me.RepositoryItemTextEdit4
        Me.colNombres.FieldName = "Nombres"
        Me.colNombres.Name = "colNombres"
        Me.colNombres.Visible = true
        Me.colNombres.VisibleIndex = 2
        Me.colNombres.Width = 89
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = false
        Me.RepositoryItemTextEdit4.MaxLength = 30
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'colTelfonoParticular
        '
        Me.colTelfonoParticular.ColumnEdit = Me.RepositoryItemTextEdit5
        Me.colTelfonoParticular.FieldName = "TelfonoParticular"
        Me.colTelfonoParticular.Name = "colTelfonoParticular"
        Me.colTelfonoParticular.Visible = true
        Me.colTelfonoParticular.VisibleIndex = 4
        Me.colTelfonoParticular.Width = 71
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = false
        Me.RepositoryItemTextEdit5.MaxLength = 10
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'colTelefonoCelular
        '
        Me.colTelefonoCelular.ColumnEdit = Me.RepositoryItemTextEdit6
        Me.colTelefonoCelular.FieldName = "TelefonoCelular"
        Me.colTelefonoCelular.Name = "colTelefonoCelular"
        Me.colTelefonoCelular.Visible = true
        Me.colTelefonoCelular.VisibleIndex = 5
        Me.colTelefonoCelular.Width = 90
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = false
        Me.RepositoryItemTextEdit6.MaxLength = 10
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'colArea
        '
        Me.colArea.ColumnEdit = Me.RepositoryItemTextEdit7
        Me.colArea.FieldName = "Area"
        Me.colArea.Name = "colArea"
        Me.colArea.Visible = true
        Me.colArea.VisibleIndex = 6
        Me.colArea.Width = 90
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = false
        Me.RepositoryItemTextEdit7.MaxLength = 30
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'colSeccionOficina
        '
        Me.colSeccionOficina.ColumnEdit = Me.RepositoryItemTextEdit8
        Me.colSeccionOficina.FieldName = "SeccionOficina"
        Me.colSeccionOficina.Name = "colSeccionOficina"
        Me.colSeccionOficina.Visible = true
        Me.colSeccionOficina.VisibleIndex = 7
        Me.colSeccionOficina.Width = 90
        '
        'RepositoryItemTextEdit8
        '
        Me.RepositoryItemTextEdit8.AutoHeight = false
        Me.RepositoryItemTextEdit8.MaxLength = 30
        Me.RepositoryItemTextEdit8.Name = "RepositoryItemTextEdit8"
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = true
        Me.colEmail.VisibleIndex = 8
        Me.colEmail.Width = 90
        '
        'colAprueba
        '
        Me.colAprueba.FieldName = "Aprueba"
        Me.colAprueba.Name = "colAprueba"
        Me.colAprueba.Visible = true
        Me.colAprueba.VisibleIndex = 9
        Me.colAprueba.Width = 90
        '
        'colCotiza
        '
        Me.colCotiza.FieldName = "Cotiza"
        Me.colCotiza.Name = "colCotiza"
        Me.colCotiza.Visible = true
        Me.colCotiza.VisibleIndex = 10
        Me.colCotiza.Width = 90
        '
        'colHabilitado
        '
        Me.colHabilitado.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colHabilitado.FieldName = "Habilitado"
        Me.colHabilitado.Name = "colHabilitado"
        Me.colHabilitado.Visible = true
        Me.colHabilitado.VisibleIndex = 11
        Me.colHabilitado.Width = 112
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = false
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'colActualizo
        '
        Me.colActualizo.Caption = "Actualizo"
        Me.colActualizo.ColumnEdit = Me.RepositoryItemSpinEdit2
        Me.colActualizo.FieldName = "Actualizo"
        Me.colActualizo.Name = "colActualizo"
        '
        'RepositoryItemSpinEdit2
        '
        Me.RepositoryItemSpinEdit2.AutoHeight = false
        Me.RepositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit2.MaxValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepositoryItemSpinEdit2.Name = "RepositoryItemSpinEdit2"
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = false
        Me.RepositoryItemHyperLinkEdit1.MaxLength = 30
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'RepositoryItemTextEdit9
        '
        Me.RepositoryItemTextEdit9.AutoHeight = false
        Me.RepositoryItemTextEdit9.MaxLength = 30
        Me.RepositoryItemTextEdit9.Name = "RepositoryItemTextEdit9"
        '
        'RepositoryItemTextEdit10
        '
        Me.RepositoryItemTextEdit10.AutoHeight = false
        Me.RepositoryItemTextEdit10.Name = "RepositoryItemTextEdit10"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.BarManager1.MaxItemId = 5
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar1.FloatLocation = New System.Drawing.Point(420, 588)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4)})
        Me.Bar1.Offset = 13
        Me.Bar1.Text = "Tools"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "AGREGAR"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "EDITAR"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "ELIMINAR"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = false
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1058, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = false
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 455)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1058, 24)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = false
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 455)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = false
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1058, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 455)
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "CANCELAR"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
        '
        'limpiafiltros
        '
        Me.limpiafiltros.Location = New System.Drawing.Point(496, 12)
        Me.limpiafiltros.Name = "limpiafiltros"
        Me.limpiafiltros.Size = New System.Drawing.Size(75, 23)
        Me.limpiafiltros.TabIndex = 6
        Me.limpiafiltros.Text = "Limpiar Filtros"
        Me.limpiafiltros.ToolTip = "Limpia los filtros aplicados por columnas"
        '
        'imprimir
        '
        Me.imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.imprimir.Location = New System.Drawing.Point(983, 456)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(75, 23)
        Me.imprimir.TabIndex = 5
        Me.imprimir.Text = "Imprimir"
        Me.imprimir.ToolTip = "Abre la previsualizacoion de impresion y exportacion, Imprime el contenido visual"& _ 
    "izado en la grilla"
        '
        'FrUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 479)
        Me.Controls.Add(Me.limpiafiltros)
        Me.Controls.Add(Me.imprimir)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FrUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.XpCollection1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemSpinEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemSpinEdit2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemHyperLinkEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit9,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit10,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemTextEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents limpiafiltros As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colUsuarioID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContraseña As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApellidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelfonoParticular As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefonoCelular As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeccionOficina As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAprueba As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCotiza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHabilitado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemTextEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colActualizo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
End Class
