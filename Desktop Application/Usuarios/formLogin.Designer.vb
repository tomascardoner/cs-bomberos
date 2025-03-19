<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLogin))
        Me.PictureBoxMain = New System.Windows.Forms.PictureBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.ToolStripMain = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonAceptar = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.PictureBoxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripMain.SuspendLayout()
        Me.TableLayoutPanelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBoxMain
        '
        Me.PictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxMain.Image = Global.CSBomberos.My.Resources.Resources.ImageInicioSesion48
        Me.PictureBoxMain.Location = New System.Drawing.Point(24, 33)
        Me.PictureBoxMain.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxMain.Name = "PictureBoxMain"
        Me.TableLayoutPanelMain.SetRowSpan(Me.PictureBoxMain, 3)
        Me.PictureBoxMain.Size = New System.Drawing.Size(60, 72)
        Me.PictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxMain.TabIndex = 0
        Me.PictureBoxMain.TabStop = False
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelNombre.Location = New System.Drawing.Point(112, 29)
        Me.LabelNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(79, 30)
        Me.LabelNombre.TabIndex = 0
        Me.LabelNombre.Text = "Usuario:"
        Me.LabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelPassword.Location = New System.Drawing.Point(112, 74)
        Me.LabelPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(79, 35)
        Me.LabelPassword.TabIndex = 2
        Me.LabelPassword.Text = "Contraseña:"
        Me.LabelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxNombre.Location = New System.Drawing.Point(199, 33)
        Me.TextBoxNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNombre.MaxLength = 30
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(283, 22)
        Me.TextBoxNombre.TabIndex = 1
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxPassword.Location = New System.Drawing.Point(199, 78)
        Me.TextBoxPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(283, 22)
        Me.TextBoxPassword.TabIndex = 3
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'ToolStripMain
        '
        Me.ToolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonCancelar, Me.ToolStripButtonAceptar})
        Me.ToolStripMain.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripMain.Name = "ToolStripMain"
        Me.ToolStripMain.Size = New System.Drawing.Size(506, 39)
        Me.ToolStripMain.TabIndex = 1
        '
        'ToolStripButtonCancelar
        '
        Me.ToolStripButtonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButtonCancelar.Image = Global.CSBomberos.My.Resources.Resources.ImageCancelar32
        Me.ToolStripButtonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCancelar.Name = "ToolStripButtonCancelar"
        Me.ToolStripButtonCancelar.Size = New System.Drawing.Size(102, 36)
        Me.ToolStripButtonCancelar.Text = "Cancelar"
        '
        'ToolStripButtonAceptar
        '
        Me.ToolStripButtonAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButtonAceptar.Image = Global.CSBomberos.My.Resources.Resources.ImageAceptar32
        Me.ToolStripButtonAceptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAceptar.Name = "ToolStripButtonAceptar"
        Me.ToolStripButtonAceptar.Size = New System.Drawing.Size(97, 36)
        Me.ToolStripButtonAceptar.Text = "Aceptar"
        '
        'TableLayoutPanelMain
        '
        Me.TableLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelMain.ColumnCount = 6
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.Controls.Add(Me.PictureBoxMain, 1, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelNombre, 3, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.TextBoxNombre, 4, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelPassword, 3, 3)
        Me.TableLayoutPanelMain.Controls.Add(Me.TextBoxPassword, 4, 3)
        Me.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelMain.Location = New System.Drawing.Point(0, 39)
        Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        Me.TableLayoutPanelMain.RowCount = 5
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelMain.Size = New System.Drawing.Size(506, 138)
        Me.TableLayoutPanelMain.TabIndex = 0
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(506, 177)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanelMain)
        Me.Controls.Add(Me.ToolStripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "formLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inicio de sesión"
        CType(Me.PictureBoxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripMain.ResumeLayout(False)
        Me.ToolStripMain.PerformLayout()
        Me.TableLayoutPanelMain.ResumeLayout(False)
        Me.TableLayoutPanelMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxMain As System.Windows.Forms.PictureBox
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents LabelPassword As System.Windows.Forms.Label
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
End Class
