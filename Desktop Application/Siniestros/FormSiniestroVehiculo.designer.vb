<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSiniestroVehiculo
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
        Me.ToolStripButtonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripMain = New System.Windows.Forms.ToolStrip()
        Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTipo = New System.Windows.Forms.Label()
        Me.ComboBoxTipo = New System.Windows.Forms.ComboBox()
        Me.LabelMarca = New System.Windows.Forms.Label()
        Me.LabelModelo = New System.Windows.Forms.Label()
        Me.TextBoxModelo = New System.Windows.Forms.TextBox()
        Me.LabelDominio = New System.Windows.Forms.Label()
        Me.TextBoxDominio = New System.Windows.Forms.TextBox()
        Me.ComboBoxMarca = New System.Windows.Forms.ComboBox()
        Me.ToolStripMain.SuspendLayout()
        Me.TableLayoutPanelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripButtonGuardar
        '
        Me.ToolStripButtonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButtonGuardar.Image = Global.CSBomberos.My.Resources.Resources.ImageAceptar32
        Me.ToolStripButtonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonGuardar.Name = "ToolStripButtonGuardar"
        Me.ToolStripButtonGuardar.Size = New System.Drawing.Size(98, 36)
        Me.ToolStripButtonGuardar.Text = "Guardar"
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
        'ToolStripButtonEditar
        '
        Me.ToolStripButtonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButtonEditar.Image = Global.CSBomberos.My.Resources.Resources.ImageEditar32
        Me.ToolStripButtonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEditar.Name = "ToolStripButtonEditar"
        Me.ToolStripButtonEditar.Size = New System.Drawing.Size(84, 36)
        Me.ToolStripButtonEditar.Text = "Editar"
        '
        'ToolStripButtonCerrar
        '
        Me.ToolStripButtonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButtonCerrar.Image = Global.CSBomberos.My.Resources.Resources.ImageCerrar32
        Me.ToolStripButtonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCerrar.Name = "ToolStripButtonCerrar"
        Me.ToolStripButtonCerrar.Size = New System.Drawing.Size(85, 36)
        Me.ToolStripButtonCerrar.Text = "Cerrar"
        '
        'ToolStripMain
        '
        Me.ToolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonCerrar, Me.ToolStripButtonEditar, Me.ToolStripButtonCancelar, Me.ToolStripButtonGuardar})
        Me.ToolStripMain.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripMain.Name = "ToolStripMain"
        Me.ToolStripMain.Size = New System.Drawing.Size(616, 39)
        Me.ToolStripMain.TabIndex = 1
        '
        'TableLayoutPanelMain
        '
        Me.TableLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelMain.ColumnCount = 4
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelTipo, 1, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.ComboBoxTipo, 2, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelMarca, 1, 2)
        Me.TableLayoutPanelMain.Controls.Add(Me.ComboBoxMarca, 2, 2)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelModelo, 1, 3)
        Me.TableLayoutPanelMain.Controls.Add(Me.TextBoxModelo, 2, 3)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelDominio, 1, 4)
        Me.TableLayoutPanelMain.Controls.Add(Me.TextBoxDominio, 2, 4)
        Me.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelMain.Location = New System.Drawing.Point(0, 39)
        Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        Me.TableLayoutPanelMain.RowCount = 6
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.Size = New System.Drawing.Size(616, 165)
        Me.TableLayoutPanelMain.TabIndex = 0
        '
        'LabelTipo
        '
        Me.LabelTipo.AutoSize = True
        Me.LabelTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelTipo.Location = New System.Drawing.Point(23, 20)
        Me.LabelTipo.Name = "LabelTipo"
        Me.LabelTipo.Size = New System.Drawing.Size(60, 32)
        Me.LabelTipo.TabIndex = 0
        Me.LabelTipo.Text = "Tipo:"
        Me.LabelTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBoxTipo
        '
        Me.ComboBoxTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipo.FormattingEnabled = True
        Me.ComboBoxTipo.Location = New System.Drawing.Point(90, 24)
        Me.ComboBoxTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxTipo.Name = "ComboBoxTipo"
        Me.ComboBoxTipo.Size = New System.Drawing.Size(502, 24)
        Me.ComboBoxTipo.TabIndex = 1
        '
        'LabelMarca
        '
        Me.LabelMarca.AutoSize = True
        Me.LabelMarca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelMarca.Location = New System.Drawing.Point(23, 52)
        Me.LabelMarca.Name = "LabelMarca"
        Me.LabelMarca.Size = New System.Drawing.Size(60, 32)
        Me.LabelMarca.TabIndex = 2
        Me.LabelMarca.Text = "Marca:"
        Me.LabelMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelModelo
        '
        Me.LabelModelo.AutoSize = True
        Me.LabelModelo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelModelo.Location = New System.Drawing.Point(23, 84)
        Me.LabelModelo.Name = "LabelModelo"
        Me.LabelModelo.Size = New System.Drawing.Size(60, 28)
        Me.LabelModelo.TabIndex = 4
        Me.LabelModelo.Text = "Modelo:"
        Me.LabelModelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxModelo
        '
        Me.TextBoxModelo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxModelo.Location = New System.Drawing.Point(89, 87)
        Me.TextBoxModelo.MaxLength = 50
        Me.TextBoxModelo.Name = "TextBoxModelo"
        Me.TextBoxModelo.Size = New System.Drawing.Size(504, 22)
        Me.TextBoxModelo.TabIndex = 5
        '
        'LabelDominio
        '
        Me.LabelDominio.AutoSize = True
        Me.LabelDominio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelDominio.Location = New System.Drawing.Point(23, 112)
        Me.LabelDominio.Name = "LabelDominio"
        Me.LabelDominio.Size = New System.Drawing.Size(60, 30)
        Me.LabelDominio.TabIndex = 6
        Me.LabelDominio.Text = "Dominio:"
        Me.LabelDominio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxDominio
        '
        Me.TextBoxDominio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxDominio.Location = New System.Drawing.Point(90, 116)
        Me.TextBoxDominio.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxDominio.MaxLength = 7
        Me.TextBoxDominio.Name = "TextBoxDominio"
        Me.TextBoxDominio.Size = New System.Drawing.Size(80, 22)
        Me.TextBoxDominio.TabIndex = 7
        '
        'ComboBoxMarca
        '
        Me.ComboBoxMarca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMarca.Location = New System.Drawing.Point(90, 56)
        Me.ComboBoxMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxMarca.Name = "ComboBoxMarca"
        Me.ComboBoxMarca.Size = New System.Drawing.Size(502, 24)
        Me.ComboBoxMarca.TabIndex = 3
        '
        'FormSiniestroVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 204)
        Me.Controls.Add(Me.TableLayoutPanelMain)
        Me.Controls.Add(Me.ToolStripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSiniestroVehiculo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Vehículo del Siniestro"
        Me.ToolStripMain.ResumeLayout(False)
        Me.ToolStripMain.PerformLayout()
        Me.TableLayoutPanelMain.ResumeLayout(False)
        Me.TableLayoutPanelMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripButtonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
    Friend WithEvents LabelTipo As Label
    Friend WithEvents LabelMarca As Label
    Friend WithEvents LabelModelo As Label
    Friend WithEvents LabelDominio As Label
    Friend WithEvents ComboBoxTipo As ComboBox
    Friend WithEvents TextBoxModelo As TextBox
    Friend WithEvents ComboBoxMarca As ComboBox
    Friend WithEvents TextBoxDominio As TextBox
End Class
