﻿Partial Public Class FrSectores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrSectores))
        Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.labelControl = New DevExpress.XtraEditors.LabelControl()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.SubSectores = New DevExpress.Xpo.XPCollection(Me.components)
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdSubSector = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdSector = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.Sectores = New DevExpress.Xpo.XPCollection(Me.components)
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSubSector1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObservacionesSS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.layoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.itemLabel = New DevExpress.XtraLayout.LayoutControlItem()
        Me.itemGrid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.windowsUIButtonPanel = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.layoutControl,System.ComponentModel.ISupportInitialize).BeginInit
        Me.layoutControl.SuspendLayout
        CType(Me.gridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SubSectores,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Sectores,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit1View,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemMemoEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LayoutView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LayoutViewCard1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.layoutControlGroup,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.itemLabel,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.itemGrid,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemTextEdit3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'layoutControl
        '
        Me.layoutControl.AllowCustomization = false
        Me.layoutControl.Controls.Add(Me.labelControl)
        Me.layoutControl.Controls.Add(Me.gridControl)
        Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layoutControl.Location = New System.Drawing.Point(0, 0)
        Me.layoutControl.Name = "layoutControl"
        Me.layoutControl.Root = Me.layoutControlGroup
        Me.layoutControl.Size = New System.Drawing.Size(784, 364)
        Me.layoutControl.TabIndex = 1
        '
        'labelControl
        '
        Me.labelControl.AllowHtmlString = true
        Me.labelControl.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140,Byte),Integer), CType(CType(140,Byte),Integer), CType(CType(140,Byte),Integer))
        Me.labelControl.Appearance.Options.UseFont = true
        Me.labelControl.Appearance.Options.UseForeColor = true
        Me.labelControl.Appearance.Options.UseTextOptions = true
        Me.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.labelControl.Location = New System.Drawing.Point(40, 0)
        Me.labelControl.Name = "labelControl"
        Me.labelControl.Padding = New System.Windows.Forms.Padding(0, 3, 13, 6)
        Me.labelControl.Size = New System.Drawing.Size(704, 34)
        Me.labelControl.StyleController = Me.layoutControl
        Me.labelControl.TabIndex = 4
        Me.labelControl.Text = "SECTORES"
        '
        'gridControl
        '
        Me.gridControl.DataSource = Me.SubSectores
        Me.gridControl.Location = New System.Drawing.Point(40, 34)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3})
        Me.gridControl.Size = New System.Drawing.Size(704, 330)
        Me.gridControl.TabIndex = 2
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView, Me.LayoutView1})
        '
        'SubSectores
        '
        Me.SubSectores.ObjectType = GetType(SistemaCompras.MontagneAdministracion.SubSector)
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdSubSector, Me.colIdSector, Me.colSubSector1, Me.colObservacionesSS})
        Me.gridView.GridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.gridView.OptionsCustomization.AllowColumnMoving = false
        Me.gridView.OptionsCustomization.AllowGroup = false
        Me.gridView.OptionsCustomization.AllowQuickHideColumns = false
        Me.gridView.OptionsEditForm.EditFormColumnCount = 1
        Me.gridView.OptionsFind.AlwaysVisible = true
        Me.gridView.OptionsFind.FindNullPrompt = "Ingrese el texto a buscar"
        Me.gridView.OptionsMenu.EnableColumnMenu = false
        Me.gridView.OptionsNavigation.AutoFocusNewRow = true
        Me.gridView.OptionsNavigation.EnterMoveNextColumn = true
        Me.gridView.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.gridView.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.gridView.OptionsView.ShowAutoFilterRow = true
        Me.gridView.OptionsView.ShowChildrenInGroupPanel = true
        Me.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        Me.gridView.OptionsView.ShowFooter = true
        Me.gridView.OptionsView.ShowIndicator = false
        Me.gridView.ViewCaption = "Gridview1"
        '
        'colIdSubSector
        '
        Me.colIdSubSector.FieldName = "IdSubSector"
        Me.colIdSubSector.Name = "colIdSubSector"
        '
        'colIdSector
        '
        Me.colIdSector.Caption = "Sector"
        Me.colIdSector.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colIdSector.FieldName = "IdSector"
        Me.colIdSector.Name = "colIdSector"
        Me.colIdSector.Visible = true
        Me.colIdSector.VisibleIndex = 0
        Me.colIdSector.Width = 136
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = false
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.Sectores
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "Sector"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "IdSector"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'Sectores
        '
        Me.Sectores.DisplayableProperties = "IdSector;Sector;Observaciones"
        Me.Sectores.ObjectType = GetType(SistemaCompras.MontagneAdministracion.Sectores)
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false
        '
        'colSubSector1
        '
        Me.colSubSector1.Caption = "Area"
        Me.colSubSector1.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colSubSector1.FieldName = "SubSector1"
        Me.colSubSector1.Name = "colSubSector1"
        Me.colSubSector1.Visible = true
        Me.colSubSector1.VisibleIndex = 1
        Me.colSubSector1.Width = 475
        '
        'colObservacionesSS
        '
        Me.colObservacionesSS.Caption = "Observaciones"
        Me.colObservacionesSS.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colObservacionesSS.FieldName = "ObservacionesSS"
        Me.colObservacionesSS.Name = "colObservacionesSS"
        Me.colObservacionesSS.Visible = true
        Me.colObservacionesSS.VisibleIndex = 2
        Me.colObservacionesSS.Width = 475
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = false
        Me.RepositoryItemTextEdit1.MaxLength = 80
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'LayoutView1
        '
        Me.LayoutView1.GridControl = Me.gridControl
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.TemplateCard = Me.LayoutViewCard1
        Me.LayoutView1.ViewCaption = "Layout1"
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        '
        'layoutControlGroup
        '
        Me.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.layoutControlGroup.GroupBordersVisible = false
        Me.layoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.itemLabel, Me.itemGrid})
        Me.layoutControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.layoutControlGroup.Name = "layoutControlGroup"
        Me.layoutControlGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(40, 40, 0, 0)
        Me.layoutControlGroup.Size = New System.Drawing.Size(784, 364)
        Me.layoutControlGroup.TextVisible = false
        '
        'itemLabel
        '
        Me.itemLabel.Control = Me.labelControl
        Me.itemLabel.Location = New System.Drawing.Point(0, 0)
        Me.itemLabel.Name = "itemLabel"
        Me.itemLabel.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.itemLabel.Size = New System.Drawing.Size(704, 34)
        Me.itemLabel.TextSize = New System.Drawing.Size(0, 0)
        Me.itemLabel.TextVisible = false
        '
        'itemGrid
        '
        Me.itemGrid.Control = Me.gridControl
        Me.itemGrid.Location = New System.Drawing.Point(0, 34)
        Me.itemGrid.Name = "itemGrid"
        Me.itemGrid.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.itemGrid.Size = New System.Drawing.Size(704, 330)
        Me.itemGrid.TextSize = New System.Drawing.Size(0, 0)
        Me.itemGrid.TextVisible = false
        '
        'windowsUIButtonPanel
        '
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(130,Byte),Integer), CType(CType(130,Byte),Integer), CType(CType(130,Byte),Integer))
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130,Byte),Integer), CType(CType(130,Byte),Integer), CType(CType(130,Byte),Integer))
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = true
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = true
        Me.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true
        Me.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1
        Me.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = true
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(159,Byte),Integer), CType(CType(159,Byte),Integer), CType(CType(159,Byte),Integer))
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159,Byte),Integer), CType(CType(159,Byte),Integer), CType(CType(159,Byte),Integer))
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = true
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = true
        Me.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true
        Me.windowsUIButtonPanel.BackColor = System.Drawing.SystemColors.GrayText
        Me.windowsUIButtonPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("AGREGAR", CType(resources.GetObject("windowsUIButtonPanel.Buttons"),System.Drawing.Image), "New;Size32x32;GrayScaled", -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Permiite agregar un nuevo registro", true, -1, true, Nothing, true, false, true, Nothing, Nothing, -1, false, false), New DevExpress.XtraBars.Docking2010.WindowsUIButton("EDITAR", "Edit;Size32x32;GrayScaled", DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Permite modificar el registro seleccionado", true, -1, true, Nothing, true, false, true, Nothing, Nothing, -1, false, false), New DevExpress.XtraBars.Docking2010.WindowsUIButton("ELIMINAR", "Edit/Delete;Size32x32;GrayScaled", DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Permite eliminar el registro seleccionado", true, -1, true, Nothing, true, false, false, Nothing, Nothing, -1, false, false), New DevExpress.XtraBars.Docking2010.WindowsUIButton("RECARGAR", "Refresh;Size32x32;GrayScaled", DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Permite recargar la grilla para visualizar datos  que puedan haber sido agregados"& _ 
                    ""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"por otros usuarios", true, -1, true, Nothing, true, false, true, Nothing, Nothing, -1, false, false), New DevExpress.XtraBars.Docking2010.WindowsUIButton("CANCELAR", CType(resources.GetObject("windowsUIButtonPanel.Buttons1"),System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, Nothing, true, false, false, Nothing, Nothing, -1, false, false), New DevExpress.XtraBars.Docking2010.WindowsUIButton("QUITAR FILTROS", CType(resources.GetObject("windowsUIButtonPanel.Buttons2"),System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Limpia los filtros de selección", true, -1, true, Nothing, true, false, true, Nothing, Nothing, -1, false, false), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("CAMBIAR VISTA", CType(resources.GetObject("windowsUIButtonPanel.Buttons3"),System.Drawing.Image), -1, DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Cambia entre Vista Grilla y Ficha", true, -1, true, Nothing, true, false, true, Nothing, Nothing, -1, false, false), New DevExpress.XtraBars.Docking2010.WindowsUIButton("IMPRIMIR", "Preview;Size32x32;GrayScaled", DevExpress.XtraBars.Docking2010.ImageLocation.[Default], DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Muestra el panel de impresión y exportación", true, -1, true, Nothing, true, false, true, Nothing, Nothing, -1, false, false)})
        Me.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.windowsUIButtonPanel.EnableImageTransparency = true
        Me.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White
        Me.windowsUIButtonPanel.Location = New System.Drawing.Point(0, 364)
        Me.windowsUIButtonPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.windowsUIButtonPanel.MaximumSize = New System.Drawing.Size(0, 60)
        Me.windowsUIButtonPanel.MinimumSize = New System.Drawing.Size(60, 60)
        Me.windowsUIButtonPanel.Name = "windowsUIButtonPanel"
        Me.windowsUIButtonPanel.Size = New System.Drawing.Size(784, 60)
        Me.windowsUIButtonPanel.TabIndex = 5
        Me.windowsUIButtonPanel.Text = "windowsUIButtonPanel"
        Me.windowsUIButtonPanel.UseButtonBackgroundImages = false
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = false
        Me.RepositoryItemTextEdit2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = false
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'FrSectores
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = true
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 424)
        Me.Controls.Add(Me.layoutControl)
        Me.Controls.Add(Me.windowsUIButtonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "FrSectores"
        CType(Me.layoutControl,System.ComponentModel.ISupportInitialize).EndInit
        Me.layoutControl.ResumeLayout(false)
        CType(Me.gridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SubSectores,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Sectores,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit1View,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemMemoEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutViewCard1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.layoutControlGroup,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.itemLabel,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.itemGrid,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit3,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

#End Region

    Private layoutControl As DevExpress.XtraLayout.LayoutControl
    Private labelControl As DevExpress.XtraEditors.LabelControl
    Private layoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Private itemLabel As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents windowsUIButtonPanel As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents Sectores As DevExpress.Xpo.XPCollection
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Private WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Private WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents itemGrid As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents SubSectores As DevExpress.Xpo.XPCollection
    Friend WithEvents colIdSubSector As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdSector As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSubSector1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservacionesSS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
