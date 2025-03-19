<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSiniestroDamnificado
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
        Me.LabelGenero = New System.Windows.Forms.Label()
        Me.ComboBoxGenero = New System.Windows.Forms.ComboBox()
        Me.LabelApellido = New System.Windows.Forms.Label()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.LabelDocumento = New System.Windows.Forms.Label()
        Me.TableLayoutPanelDocumento = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxDocumentoTipo = New System.Windows.Forms.ComboBox()
        Me.TextBoxDocumentoNumero = New System.Windows.Forms.TextBox()
        Me.LabelEdad = New System.Windows.Forms.Label()
        Me.NumericUpDownEdad = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanelEdad = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBoxEsMenor = New System.Windows.Forms.CheckBox()
        Me.LabelTrasladado = New System.Windows.Forms.Label()
        Me.CheckBoxTrasladado = New System.Windows.Forms.CheckBox()
        Me.LabelEstado = New System.Windows.Forms.Label()
        Me.ComboBoxEstado = New System.Windows.Forms.ComboBox()
        Me.ToolStripMain.SuspendLayout()
        Me.TableLayoutPanelMain.SuspendLayout()
        Me.TableLayoutPanelDocumento.SuspendLayout()
        CType(Me.NumericUpDownEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelEdad.SuspendLayout()
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
        Me.ToolStripMain.TabIndex = 5
        '
        'TableLayoutPanelMain
        '
        Me.TableLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelMain.ColumnCount = 4
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelGenero, 1, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.ComboBoxGenero, 2, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelApellido, 1, 2)
        Me.TableLayoutPanelMain.Controls.Add(Me.TextBoxApellido, 2, 2)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelNombre, 1, 3)
        Me.TableLayoutPanelMain.Controls.Add(Me.TextBoxNombre, 2, 3)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelDocumento, 1, 4)
        Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanelDocumento, 2, 4)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelEdad, 1, 5)
        Me.TableLayoutPanelMain.Controls.Add(Me.TableLayoutPanelEdad, 2, 5)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelTrasladado, 1, 6)
        Me.TableLayoutPanelMain.Controls.Add(Me.CheckBoxTrasladado, 2, 6)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelEstado, 1, 7)
        Me.TableLayoutPanelMain.Controls.Add(Me.ComboBoxEstado, 2, 7)
        Me.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelMain.Location = New System.Drawing.Point(0, 39)
        Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        Me.TableLayoutPanelMain.RowCount = 10
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMain.Size = New System.Drawing.Size(616, 247)
        Me.TableLayoutPanelMain.TabIndex = 6
        '
        'LabelGenero
        '
        Me.LabelGenero.AutoSize = True
        Me.LabelGenero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelGenero.Location = New System.Drawing.Point(23, 20)
        Me.LabelGenero.Name = "LabelGenero"
        Me.LabelGenero.Size = New System.Drawing.Size(81, 32)
        Me.LabelGenero.TabIndex = 0
        Me.LabelGenero.Text = "Género:"
        Me.LabelGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBoxGenero
        '
        Me.ComboBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGenero.FormattingEnabled = True
        Me.ComboBoxGenero.Location = New System.Drawing.Point(111, 24)
        Me.ComboBoxGenero.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxGenero.Name = "ComboBoxGenero"
        Me.ComboBoxGenero.Size = New System.Drawing.Size(135, 24)
        Me.ComboBoxGenero.TabIndex = 10
        '
        'LabelApellido
        '
        Me.LabelApellido.AutoSize = True
        Me.LabelApellido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelApellido.Location = New System.Drawing.Point(23, 52)
        Me.LabelApellido.Name = "LabelApellido"
        Me.LabelApellido.Size = New System.Drawing.Size(81, 28)
        Me.LabelApellido.TabIndex = 11
        Me.LabelApellido.Text = "Apellido:"
        Me.LabelApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxApellido.Location = New System.Drawing.Point(110, 55)
        Me.TextBoxApellido.MaxLength = 50
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(483, 22)
        Me.TextBoxApellido.TabIndex = 12
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelNombre.Location = New System.Drawing.Point(23, 80)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(81, 28)
        Me.LabelNombre.TabIndex = 13
        Me.LabelNombre.Text = "Nombre:"
        Me.LabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxNombre.Location = New System.Drawing.Point(110, 83)
        Me.TextBoxNombre.MaxLength = 50
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(483, 22)
        Me.TextBoxNombre.TabIndex = 14
        '
        'LabelDocumento
        '
        Me.LabelDocumento.AutoSize = True
        Me.LabelDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelDocumento.Location = New System.Drawing.Point(23, 108)
        Me.LabelDocumento.Name = "LabelDocumento"
        Me.LabelDocumento.Size = New System.Drawing.Size(81, 38)
        Me.LabelDocumento.TabIndex = 15
        Me.LabelDocumento.Text = "Documento:"
        Me.LabelDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanelDocumento
        '
        Me.TableLayoutPanelDocumento.AutoSize = True
        Me.TableLayoutPanelDocumento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelDocumento.ColumnCount = 2
        Me.TableLayoutPanelDocumento.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelDocumento.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelDocumento.Controls.Add(Me.TextBoxDocumentoNumero, 1, 0)
        Me.TableLayoutPanelDocumento.Controls.Add(Me.ComboBoxDocumentoTipo, 0, 0)
        Me.TableLayoutPanelDocumento.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelDocumento.Location = New System.Drawing.Point(110, 111)
        Me.TableLayoutPanelDocumento.Name = "TableLayoutPanelDocumento"
        Me.TableLayoutPanelDocumento.RowCount = 1
        Me.TableLayoutPanelDocumento.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelDocumento.Size = New System.Drawing.Size(303, 32)
        Me.TableLayoutPanelDocumento.TabIndex = 16
        '
        'ComboBoxDocumentoTipo
        '
        Me.ComboBoxDocumentoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDocumentoTipo.Location = New System.Drawing.Point(4, 4)
        Me.ComboBoxDocumentoTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxDocumentoTipo.Name = "ComboBoxDocumentoTipo"
        Me.ComboBoxDocumentoTipo.Size = New System.Drawing.Size(135, 24)
        Me.ComboBoxDocumentoTipo.TabIndex = 5
        '
        'TextBoxDocumentoNumero
        '
        Me.TextBoxDocumentoNumero.Location = New System.Drawing.Point(147, 4)
        Me.TextBoxDocumentoNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxDocumentoNumero.MaxLength = 11
        Me.TextBoxDocumentoNumero.Name = "TextBoxDocumentoNumero"
        Me.TextBoxDocumentoNumero.Size = New System.Drawing.Size(152, 22)
        Me.TextBoxDocumentoNumero.TabIndex = 6
        '
        'LabelEdad
        '
        Me.LabelEdad.AutoSize = True
        Me.LabelEdad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelEdad.Location = New System.Drawing.Point(23, 146)
        Me.LabelEdad.Name = "LabelEdad"
        Me.LabelEdad.Size = New System.Drawing.Size(81, 28)
        Me.LabelEdad.TabIndex = 17
        Me.LabelEdad.Text = "Edad:"
        Me.LabelEdad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDownEdad
        '
        Me.NumericUpDownEdad.Location = New System.Drawing.Point(3, 3)
        Me.NumericUpDownEdad.Maximum = New Decimal(New Integer() {110, 0, 0, 0})
        Me.NumericUpDownEdad.Name = "NumericUpDownEdad"
        Me.NumericUpDownEdad.Size = New System.Drawing.Size(60, 22)
        Me.NumericUpDownEdad.TabIndex = 18
        Me.NumericUpDownEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableLayoutPanelEdad
        '
        Me.TableLayoutPanelEdad.AutoSize = True
        Me.TableLayoutPanelEdad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelEdad.ColumnCount = 3
        Me.TableLayoutPanelEdad.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelEdad.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelEdad.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelEdad.Controls.Add(Me.NumericUpDownEdad, 0, 0)
        Me.TableLayoutPanelEdad.Controls.Add(Me.CheckBoxEsMenor, 2, 0)
        Me.TableLayoutPanelEdad.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelEdad.Location = New System.Drawing.Point(107, 146)
        Me.TableLayoutPanelEdad.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanelEdad.Name = "TableLayoutPanelEdad"
        Me.TableLayoutPanelEdad.RowCount = 1
        Me.TableLayoutPanelEdad.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelEdad.Size = New System.Drawing.Size(181, 28)
        Me.TableLayoutPanelEdad.TabIndex = 19
        '
        'CheckBoxEsMenor
        '
        Me.CheckBoxEsMenor.AutoSize = True
        Me.CheckBoxEsMenor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBoxEsMenor.Location = New System.Drawing.Point(89, 3)
        Me.CheckBoxEsMenor.Name = "CheckBoxEsMenor"
        Me.CheckBoxEsMenor.Size = New System.Drawing.Size(89, 20)
        Me.CheckBoxEsMenor.TabIndex = 19
        Me.CheckBoxEsMenor.Text = "Es menor:"
        Me.CheckBoxEsMenor.UseVisualStyleBackColor = True
        '
        'LabelTrasladado
        '
        Me.LabelTrasladado.AutoSize = True
        Me.LabelTrasladado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelTrasladado.Location = New System.Drawing.Point(23, 174)
        Me.LabelTrasladado.Name = "LabelTrasladado"
        Me.LabelTrasladado.Size = New System.Drawing.Size(81, 23)
        Me.LabelTrasladado.TabIndex = 20
        Me.LabelTrasladado.Text = "Trasladado:"
        Me.LabelTrasladado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBoxTrasladado
        '
        Me.CheckBoxTrasladado.AutoSize = True
        Me.CheckBoxTrasladado.Location = New System.Drawing.Point(110, 177)
        Me.CheckBoxTrasladado.Name = "CheckBoxTrasladado"
        Me.CheckBoxTrasladado.Size = New System.Drawing.Size(18, 17)
        Me.CheckBoxTrasladado.TabIndex = 21
        Me.CheckBoxTrasladado.UseVisualStyleBackColor = True
        '
        'LabelEstado
        '
        Me.LabelEstado.AutoSize = True
        Me.LabelEstado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelEstado.Location = New System.Drawing.Point(23, 197)
        Me.LabelEstado.Name = "LabelEstado"
        Me.LabelEstado.Size = New System.Drawing.Size(81, 32)
        Me.LabelEstado.TabIndex = 22
        Me.LabelEstado.Text = "Estado:"
        Me.LabelEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBoxEstado
        '
        Me.ComboBoxEstado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEstado.FormattingEnabled = True
        Me.ComboBoxEstado.Location = New System.Drawing.Point(111, 201)
        Me.ComboBoxEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxEstado.Name = "ComboBoxEstado"
        Me.ComboBoxEstado.Size = New System.Drawing.Size(481, 24)
        Me.ComboBoxEstado.TabIndex = 23
        '
        'FormSiniestroDamnificado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 286)
        Me.Controls.Add(Me.TableLayoutPanelMain)
        Me.Controls.Add(Me.ToolStripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSiniestroDamnificado"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Damnificado del Siniestro"
        Me.ToolStripMain.ResumeLayout(False)
        Me.ToolStripMain.PerformLayout()
        Me.TableLayoutPanelMain.ResumeLayout(False)
        Me.TableLayoutPanelMain.PerformLayout()
        Me.TableLayoutPanelDocumento.ResumeLayout(False)
        Me.TableLayoutPanelDocumento.PerformLayout()
        CType(Me.NumericUpDownEdad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelEdad.ResumeLayout(False)
        Me.TableLayoutPanelEdad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripButtonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
    Friend WithEvents LabelGenero As Label
    Friend WithEvents LabelApellido As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelDocumento As Label
    Friend WithEvents TableLayoutPanelDocumento As TableLayoutPanel
    Friend WithEvents LabelEdad As Label
    Friend WithEvents NumericUpDownEdad As NumericUpDown
    Friend WithEvents TableLayoutPanelEdad As TableLayoutPanel
    Friend WithEvents CheckBoxEsMenor As CheckBox
    Friend WithEvents LabelTrasladado As Label
    Friend WithEvents CheckBoxTrasladado As CheckBox
    Friend WithEvents LabelEstado As Label
    Friend WithEvents ComboBoxGenero As ComboBox
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents ComboBoxDocumentoTipo As ComboBox
    Friend WithEvents TextBoxDocumentoNumero As TextBox
    Friend WithEvents ComboBoxEstado As ComboBox
End Class
