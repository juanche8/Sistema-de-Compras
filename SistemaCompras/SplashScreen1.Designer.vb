<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.DetailsLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.MainLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.PictureEdit2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.DetailsLayoutPanel.SuspendLayout
        Me.MainLayoutPanel.SuspendLayout
        Me.SuspendLayout
        '
        'PictureEdit2
        '
        Me.PictureEdit2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit2.EditValue = CType(resources.GetObject("PictureEdit2.EditValue"),Object)
        Me.PictureEdit2.Location = New System.Drawing.Point(440, 3)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit2.Properties.ZoomAccelerationFactor = 8R
        Me.PictureEdit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PictureEdit2.Size = New System.Drawing.Size(37, 35)
        Me.PictureEdit2.TabIndex = 6
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"),Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(77, 3)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = true
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Properties.ZoomAccelerationFactor = 1R
        Me.PictureEdit1.Size = New System.Drawing.Size(333, 144)
        Me.PictureEdit1.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 16!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl2.Appearance.Options.UseFont = true
        Me.LabelControl2.Appearance.Options.UseForeColor = true
        Me.LabelControl2.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(283, 25)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "MONTAGNE OUTDOORS SA"
        '
        'DetailsLayoutPanel
        '
        Me.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.DetailsLayoutPanel.ColumnCount = 1
        Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DetailsLayoutPanel.Controls.Add(Me.Copyright, 0, 1)
        Me.DetailsLayoutPanel.Controls.Add(Me.Version, 0, 0)
        Me.DetailsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DetailsLayoutPanel.Location = New System.Drawing.Point(77, 176)
        Me.DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.41379!))
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.58621!))
        Me.DetailsLayoutPanel.Size = New System.Drawing.Size(357, 116)
        Me.DetailsLayoutPanel.TabIndex = 1
        '
        'Copyright
        '
        Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Copyright.Location = New System.Drawing.Point(30, 73)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(296, 24)
        Me.Copyright.TabIndex = 2
        Me.Copyright.Text = "Copyright Montagne Outdoors S.A."
        '
        'Version
        '
        Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold)
        Me.Version.Location = New System.Drawing.Point(111, 18)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(135, 17)
        Me.Version.TabIndex = 1
        Me.Version.Text = "Version {0}.{1:0}"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 13!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelControl1.Appearance.Options.UseFont = true
        Me.LabelControl1.Appearance.Options.UseForeColor = true
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(3, 153)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(175, 21)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "SISTEMA DE COMPRAS"
        '
        'MainLayoutPanel
        '
        Me.MainLayoutPanel.BackColor = System.Drawing.Color.White
        Me.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainLayoutPanel.ColumnCount = 3
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 363!))
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43!))
        Me.MainLayoutPanel.Controls.Add(Me.LabelControl1, 0, 1)
        Me.MainLayoutPanel.Controls.Add(Me.DetailsLayoutPanel, 1, 1)
        Me.MainLayoutPanel.Controls.Add(Me.LabelControl2, 0, 0)
        Me.MainLayoutPanel.Controls.Add(Me.PictureEdit2, 2, 0)
        Me.MainLayoutPanel.Controls.Add(Me.PictureEdit1, 1, 0)
        Me.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainLayoutPanel.Name = "MainLayoutPanel"
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106!))
        Me.MainLayoutPanel.Size = New System.Drawing.Size(480, 295)
        Me.MainLayoutPanel.TabIndex = 0
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 295)
        Me.ControlBox = false
        Me.Controls.Add(Me.MainLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "SplashScreen1"
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureEdit2.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.DetailsLayoutPanel.ResumeLayout(false)
        Me.MainLayoutPanel.ResumeLayout(false)
        Me.MainLayoutPanel.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DetailsLayoutPanel As TableLayoutPanel
    Friend WithEvents Copyright As Label
    Friend WithEvents Version As Label
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MainLayoutPanel As TableLayoutPanel
End Class
