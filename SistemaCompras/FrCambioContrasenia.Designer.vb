<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrCambioContrasenia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrCambioContrasenia))
        Me.ACTUAL = New DevExpress.XtraEditors.TextEdit()
        Me.NUEVA1 = New DevExpress.XtraEditors.TextEdit()
        Me.NUEVA2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.Usuario1 = New DevExpress.XtraEditors.TextEdit()
        CType(Me.ACTUAL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUEVA1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUEVA2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Usuario1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ACTUAL
        '
        Me.ACTUAL.EnterMoveNextControl = True
        Me.ACTUAL.Location = New System.Drawing.Point(220, 61)
        Me.ACTUAL.Name = "ACTUAL"
        Me.ACTUAL.Properties.MaxLength = 60
        Me.ACTUAL.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ACTUAL.Size = New System.Drawing.Size(179, 20)
        Me.ACTUAL.TabIndex = 1
        '
        'NUEVA1
        '
        Me.NUEVA1.EnterMoveNextControl = True
        Me.NUEVA1.Location = New System.Drawing.Point(220, 97)
        Me.NUEVA1.Name = "NUEVA1"
        Me.NUEVA1.Properties.MaxLength = 60
        Me.NUEVA1.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NUEVA1.Size = New System.Drawing.Size(179, 20)
        Me.NUEVA1.TabIndex = 2
        '
        'NUEVA2
        '
        Me.NUEVA2.EnterMoveNextControl = True
        Me.NUEVA2.Location = New System.Drawing.Point(220, 133)
        Me.NUEVA2.Name = "NUEVA2"
        Me.NUEVA2.Properties.MaxLength = 60
        Me.NUEVA2.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NUEVA2.Size = New System.Drawing.Size(179, 20)
        Me.NUEVA2.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(36, 64)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(178, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "INGRESE  SU  CONTRASEÑA ACTUAL"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(36, 100)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(165, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "INGRESE LA NUEVA CONTRASEÑA"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(36, 136)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(158, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "REPITA LA NUEVA CONTRASEÑA"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(118, 170)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(174, 23)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "EFECTUAR CAMBIO"
        Me.SimpleButton1.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(36, 26)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(175, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "INGRESE  SU  NOMBRE DE USUARIO"
        '
        'Usuario1
        '
        Me.Usuario1.Location = New System.Drawing.Point(220, 26)
        Me.Usuario1.Name = "Usuario1"
        Me.Usuario1.Properties.MaxLength = 30
        Me.Usuario1.Size = New System.Drawing.Size(179, 20)
        Me.Usuario1.TabIndex = 0
        '
        'FrCambioContrasenia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 225)
        Me.Controls.Add(Me.Usuario1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.NUEVA2)
        Me.Controls.Add(Me.NUEVA1)
        Me.Controls.Add(Me.ACTUAL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrCambioContrasenia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar Contraseña"
        CType(Me.ACTUAL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUEVA1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUEVA2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Usuario1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ACTUAL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NUEVA1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NUEVA2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Usuario1 As DevExpress.XtraEditors.TextEdit
End Class
