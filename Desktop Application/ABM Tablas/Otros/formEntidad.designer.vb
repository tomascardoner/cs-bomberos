<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formEntidad
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
        Dim labelEsActivo As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim labelCUIT As System.Windows.Forms.Label
        Dim labelTelefono1 As System.Windows.Forms.Label
        Dim labelTelefono2 As System.Windows.Forms.Label
        Dim labelEmail1 As System.Windows.Forms.Label
        Dim labelEmail2 As System.Windows.Forms.Label
        Dim labelDomicilioCalle3 As System.Windows.Forms.Label
        Dim labelDomicilioCalle2 As System.Windows.Forms.Label
        Dim labelDomicilioCalle1 As System.Windows.Forms.Label
        Dim labelDomicilioCodigoPostal As System.Windows.Forms.Label
        Dim labelDomicilioDepartamento As System.Windows.Forms.Label
        Dim labelDomicilioLocalidad As System.Windows.Forms.Label
        Dim labelDomicilioProvincia As System.Windows.Forms.Label
        Dim labelDomicilioNumero As System.Windows.Forms.Label
        Dim labelDomicilioPiso As System.Windows.Forms.Label
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.tabcontrolMain = New CSBomberos.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.textboxDomicilioCalle3 = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioCalle2 = New System.Windows.Forms.TextBox()
        Me.comboboxDomicilioLocalidad = New System.Windows.Forms.ComboBox()
        Me.comboboxDomicilioProvincia = New System.Windows.Forms.ComboBox()
        Me.textboxDomicilioCalle1 = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioCodigoPostal = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioDepartamento = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioNumero = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioPiso = New System.Windows.Forms.TextBox()
        Me.textboxEmail2 = New System.Windows.Forms.TextBox()
        Me.textboxEmail1 = New System.Windows.Forms.TextBox()
        Me.textboxTelefono2 = New System.Windows.Forms.TextBox()
        Me.maskedtextboxCUIT = New System.Windows.Forms.MaskedTextBox()
        Me.textboxTelefono1 = New System.Windows.Forms.TextBox()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.labelID = New System.Windows.Forms.Label()
        Me.textboxID = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        labelEsActivo = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelCUIT = New System.Windows.Forms.Label()
        labelTelefono1 = New System.Windows.Forms.Label()
        labelTelefono2 = New System.Windows.Forms.Label()
        labelEmail1 = New System.Windows.Forms.Label()
        labelEmail2 = New System.Windows.Forms.Label()
        labelDomicilioCalle3 = New System.Windows.Forms.Label()
        labelDomicilioCalle2 = New System.Windows.Forms.Label()
        labelDomicilioCalle1 = New System.Windows.Forms.Label()
        labelDomicilioCodigoPostal = New System.Windows.Forms.Label()
        labelDomicilioDepartamento = New System.Windows.Forms.Label()
        labelDomicilioLocalidad = New System.Windows.Forms.Label()
        labelDomicilioProvincia = New System.Windows.Forms.Label()
        labelDomicilioNumero = New System.Windows.Forms.Label()
        labelDomicilioPiso = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelEsActivo
        '
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(8, 264)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 2
        labelEsActivo.Text = "Activo:"
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(8, 342)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 9
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(8, 316)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 6
        labelCreacion.Text = "Creación:"
        '
        'labelCUIT
        '
        labelCUIT.AutoSize = True
        labelCUIT.Location = New System.Drawing.Point(6, 35)
        labelCUIT.Name = "labelCUIT"
        labelCUIT.Size = New System.Drawing.Size(35, 13)
        labelCUIT.TabIndex = 2
        labelCUIT.Text = "CUIT:"
        '
        'labelTelefono1
        '
        labelTelefono1.AutoSize = True
        labelTelefono1.Location = New System.Drawing.Point(6, 68)
        labelTelefono1.Name = "labelTelefono1"
        labelTelefono1.Size = New System.Drawing.Size(61, 13)
        labelTelefono1.TabIndex = 4
        labelTelefono1.Text = "Teléfono 1:"
        '
        'labelTelefono2
        '
        labelTelefono2.AutoSize = True
        labelTelefono2.Location = New System.Drawing.Point(6, 94)
        labelTelefono2.Name = "labelTelefono2"
        labelTelefono2.Size = New System.Drawing.Size(61, 13)
        labelTelefono2.TabIndex = 6
        labelTelefono2.Text = "Teléfono 2:"
        '
        'labelEmail1
        '
        labelEmail1.AutoSize = True
        labelEmail1.Location = New System.Drawing.Point(6, 127)
        labelEmail1.Name = "labelEmail1"
        labelEmail1.Size = New System.Drawing.Size(47, 13)
        labelEmail1.TabIndex = 8
        labelEmail1.Text = "E-mail 1:"
        '
        'labelEmail2
        '
        labelEmail2.AutoSize = True
        labelEmail2.Location = New System.Drawing.Point(6, 153)
        labelEmail2.Name = "labelEmail2"
        labelEmail2.Size = New System.Drawing.Size(47, 13)
        labelEmail2.TabIndex = 10
        labelEmail2.Text = "E-mail 2:"
        '
        'labelDomicilioCalle3
        '
        labelDomicilioCalle3.AutoSize = True
        labelDomicilioCalle3.Location = New System.Drawing.Point(6, 264)
        labelDomicilioCalle3.Name = "labelDomicilioCalle3"
        labelDomicilioCalle3.Size = New System.Drawing.Size(42, 13)
        labelDomicilioCalle3.TabIndex = 22
        labelDomicilioCalle3.Text = "Calle 3:"
        '
        'labelDomicilioCalle2
        '
        labelDomicilioCalle2.AutoSize = True
        labelDomicilioCalle2.Location = New System.Drawing.Point(6, 238)
        labelDomicilioCalle2.Name = "labelDomicilioCalle2"
        labelDomicilioCalle2.Size = New System.Drawing.Size(42, 13)
        labelDomicilioCalle2.TabIndex = 20
        labelDomicilioCalle2.Text = "Calle 2:"
        '
        'labelDomicilioCalle1
        '
        labelDomicilioCalle1.AutoSize = True
        labelDomicilioCalle1.Location = New System.Drawing.Point(6, 186)
        labelDomicilioCalle1.Name = "labelDomicilioCalle1"
        labelDomicilioCalle1.Size = New System.Drawing.Size(33, 13)
        labelDomicilioCalle1.TabIndex = 12
        labelDomicilioCalle1.Text = "Calle:"
        '
        'labelDomicilioCodigoPostal
        '
        labelDomicilioCodigoPostal.AutoSize = True
        labelDomicilioCodigoPostal.Location = New System.Drawing.Point(6, 344)
        labelDomicilioCodigoPostal.Name = "labelDomicilioCodigoPostal"
        labelDomicilioCodigoPostal.Size = New System.Drawing.Size(59, 13)
        labelDomicilioCodigoPostal.TabIndex = 28
        labelDomicilioCodigoPostal.Text = "Cód. Post.:"
        '
        'labelDomicilioDepartamento
        '
        labelDomicilioDepartamento.AutoSize = True
        labelDomicilioDepartamento.Location = New System.Drawing.Point(223, 212)
        labelDomicilioDepartamento.Name = "labelDomicilioDepartamento"
        labelDomicilioDepartamento.Size = New System.Drawing.Size(54, 13)
        labelDomicilioDepartamento.TabIndex = 18
        labelDomicilioDepartamento.Text = "Dto/Ofic.:"
        '
        'labelDomicilioLocalidad
        '
        labelDomicilioLocalidad.AutoSize = True
        labelDomicilioLocalidad.Location = New System.Drawing.Point(6, 317)
        labelDomicilioLocalidad.Name = "labelDomicilioLocalidad"
        labelDomicilioLocalidad.Size = New System.Drawing.Size(56, 13)
        labelDomicilioLocalidad.TabIndex = 26
        labelDomicilioLocalidad.Text = "Localidad:"
        '
        'labelDomicilioProvincia
        '
        labelDomicilioProvincia.AutoSize = True
        labelDomicilioProvincia.Location = New System.Drawing.Point(6, 290)
        labelDomicilioProvincia.Name = "labelDomicilioProvincia"
        labelDomicilioProvincia.Size = New System.Drawing.Size(54, 13)
        labelDomicilioProvincia.TabIndex = 24
        labelDomicilioProvincia.Text = "Provincia:"
        '
        'labelDomicilioNumero
        '
        labelDomicilioNumero.AutoSize = True
        labelDomicilioNumero.Location = New System.Drawing.Point(6, 212)
        labelDomicilioNumero.Name = "labelDomicilioNumero"
        labelDomicilioNumero.Size = New System.Drawing.Size(47, 13)
        labelDomicilioNumero.TabIndex = 14
        labelDomicilioNumero.Text = "Número:"
        '
        'labelDomicilioPiso
        '
        labelDomicilioPiso.AutoSize = True
        labelDomicilioPiso.Location = New System.Drawing.Point(131, 212)
        labelDomicilioPiso.Name = "labelDomicilioPiso"
        labelDomicilioPiso.Size = New System.Drawing.Size(30, 13)
        labelDomicilioPiso.TabIndex = 16
        labelDomicilioPiso.Text = "Piso:"
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(75, 6)
        Me.textboxNombre.MaxLength = 50
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(430, 20)
        Me.textboxNombre.TabIndex = 1
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Location = New System.Drawing.Point(6, 9)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(47, 13)
        Me.labelNombre.TabIndex = 0
        Me.labelNombre.Text = "Nombre:"
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = Global.CSBomberos.My.Resources.Resources.ImageAceptar32
        Me.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(85, 36)
        Me.buttonGuardar.Text = "Guardar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.CSBomberos.My.Resources.Resources.ImageCancelar32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.CSBomberos.My.Resources.Resources.ImageEditar32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSBomberos.My.Resources.Resources.ImageCerrar32
        Me.buttonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCerrar.Name = "buttonCerrar"
        Me.buttonCerrar.Size = New System.Drawing.Size(75, 36)
        Me.buttonCerrar.Text = "Cerrar"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(541, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(117, 263)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 3
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(519, 394)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(labelDomicilioCalle3)
        Me.tabpageGeneral.Controls.Add(labelDomicilioCalle2)
        Me.tabpageGeneral.Controls.Add(Me.textboxDomicilioCalle3)
        Me.tabpageGeneral.Controls.Add(Me.textboxDomicilioCalle2)
        Me.tabpageGeneral.Controls.Add(Me.comboboxDomicilioLocalidad)
        Me.tabpageGeneral.Controls.Add(Me.comboboxDomicilioProvincia)
        Me.tabpageGeneral.Controls.Add(labelDomicilioCalle1)
        Me.tabpageGeneral.Controls.Add(Me.textboxDomicilioCalle1)
        Me.tabpageGeneral.Controls.Add(labelDomicilioCodigoPostal)
        Me.tabpageGeneral.Controls.Add(Me.textboxDomicilioCodigoPostal)
        Me.tabpageGeneral.Controls.Add(labelDomicilioDepartamento)
        Me.tabpageGeneral.Controls.Add(Me.textboxDomicilioDepartamento)
        Me.tabpageGeneral.Controls.Add(labelDomicilioLocalidad)
        Me.tabpageGeneral.Controls.Add(labelDomicilioProvincia)
        Me.tabpageGeneral.Controls.Add(labelDomicilioNumero)
        Me.tabpageGeneral.Controls.Add(Me.textboxDomicilioNumero)
        Me.tabpageGeneral.Controls.Add(labelDomicilioPiso)
        Me.tabpageGeneral.Controls.Add(Me.textboxDomicilioPiso)
        Me.tabpageGeneral.Controls.Add(labelEmail2)
        Me.tabpageGeneral.Controls.Add(Me.textboxEmail2)
        Me.tabpageGeneral.Controls.Add(labelEmail1)
        Me.tabpageGeneral.Controls.Add(Me.textboxEmail1)
        Me.tabpageGeneral.Controls.Add(labelTelefono2)
        Me.tabpageGeneral.Controls.Add(Me.textboxTelefono2)
        Me.tabpageGeneral.Controls.Add(labelTelefono1)
        Me.tabpageGeneral.Controls.Add(Me.maskedtextboxCUIT)
        Me.tabpageGeneral.Controls.Add(Me.textboxTelefono1)
        Me.tabpageGeneral.Controls.Add(labelCUIT)
        Me.tabpageGeneral.Controls.Add(Me.textboxNombre)
        Me.tabpageGeneral.Controls.Add(Me.labelNombre)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(511, 365)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'textboxDomicilioCalle3
        '
        Me.textboxDomicilioCalle3.Location = New System.Drawing.Point(75, 261)
        Me.textboxDomicilioCalle3.MaxLength = 50
        Me.textboxDomicilioCalle3.Name = "textboxDomicilioCalle3"
        Me.textboxDomicilioCalle3.Size = New System.Drawing.Size(258, 20)
        Me.textboxDomicilioCalle3.TabIndex = 23
        '
        'textboxDomicilioCalle2
        '
        Me.textboxDomicilioCalle2.Location = New System.Drawing.Point(75, 235)
        Me.textboxDomicilioCalle2.MaxLength = 50
        Me.textboxDomicilioCalle2.Name = "textboxDomicilioCalle2"
        Me.textboxDomicilioCalle2.Size = New System.Drawing.Size(258, 20)
        Me.textboxDomicilioCalle2.TabIndex = 21
        '
        'comboboxDomicilioLocalidad
        '
        Me.comboboxDomicilioLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDomicilioLocalidad.FormattingEnabled = True
        Me.comboboxDomicilioLocalidad.Location = New System.Drawing.Point(75, 314)
        Me.comboboxDomicilioLocalidad.Name = "comboboxDomicilioLocalidad"
        Me.comboboxDomicilioLocalidad.Size = New System.Drawing.Size(258, 21)
        Me.comboboxDomicilioLocalidad.TabIndex = 27
        '
        'comboboxDomicilioProvincia
        '
        Me.comboboxDomicilioProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDomicilioProvincia.FormattingEnabled = True
        Me.comboboxDomicilioProvincia.Location = New System.Drawing.Point(75, 287)
        Me.comboboxDomicilioProvincia.Name = "comboboxDomicilioProvincia"
        Me.comboboxDomicilioProvincia.Size = New System.Drawing.Size(258, 21)
        Me.comboboxDomicilioProvincia.TabIndex = 25
        '
        'textboxDomicilioCalle1
        '
        Me.textboxDomicilioCalle1.Location = New System.Drawing.Point(75, 183)
        Me.textboxDomicilioCalle1.MaxLength = 100
        Me.textboxDomicilioCalle1.Name = "textboxDomicilioCalle1"
        Me.textboxDomicilioCalle1.Size = New System.Drawing.Size(258, 20)
        Me.textboxDomicilioCalle1.TabIndex = 13
        '
        'textboxDomicilioCodigoPostal
        '
        Me.textboxDomicilioCodigoPostal.Location = New System.Drawing.Point(75, 341)
        Me.textboxDomicilioCodigoPostal.MaxLength = 8
        Me.textboxDomicilioCodigoPostal.Name = "textboxDomicilioCodigoPostal"
        Me.textboxDomicilioCodigoPostal.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioCodigoPostal.TabIndex = 29
        '
        'textboxDomicilioDepartamento
        '
        Me.textboxDomicilioDepartamento.Location = New System.Drawing.Point(283, 209)
        Me.textboxDomicilioDepartamento.MaxLength = 10
        Me.textboxDomicilioDepartamento.Name = "textboxDomicilioDepartamento"
        Me.textboxDomicilioDepartamento.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioDepartamento.TabIndex = 19
        '
        'textboxDomicilioNumero
        '
        Me.textboxDomicilioNumero.Location = New System.Drawing.Point(75, 209)
        Me.textboxDomicilioNumero.MaxLength = 10
        Me.textboxDomicilioNumero.Name = "textboxDomicilioNumero"
        Me.textboxDomicilioNumero.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioNumero.TabIndex = 15
        '
        'textboxDomicilioPiso
        '
        Me.textboxDomicilioPiso.Location = New System.Drawing.Point(167, 209)
        Me.textboxDomicilioPiso.MaxLength = 10
        Me.textboxDomicilioPiso.Name = "textboxDomicilioPiso"
        Me.textboxDomicilioPiso.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioPiso.TabIndex = 17
        '
        'textboxEmail2
        '
        Me.textboxEmail2.Location = New System.Drawing.Point(75, 150)
        Me.textboxEmail2.MaxLength = 50
        Me.textboxEmail2.Name = "textboxEmail2"
        Me.textboxEmail2.Size = New System.Drawing.Size(306, 20)
        Me.textboxEmail2.TabIndex = 11
        '
        'textboxEmail1
        '
        Me.textboxEmail1.Location = New System.Drawing.Point(75, 124)
        Me.textboxEmail1.MaxLength = 50
        Me.textboxEmail1.Name = "textboxEmail1"
        Me.textboxEmail1.Size = New System.Drawing.Size(306, 20)
        Me.textboxEmail1.TabIndex = 9
        '
        'textboxTelefono2
        '
        Me.textboxTelefono2.Location = New System.Drawing.Point(75, 91)
        Me.textboxTelefono2.MaxLength = 50
        Me.textboxTelefono2.Name = "textboxTelefono2"
        Me.textboxTelefono2.Size = New System.Drawing.Size(170, 20)
        Me.textboxTelefono2.TabIndex = 7
        '
        'maskedtextboxCUIT
        '
        Me.maskedtextboxCUIT.AllowPromptAsInput = False
        Me.maskedtextboxCUIT.AsciiOnly = True
        Me.maskedtextboxCUIT.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxCUIT.HidePromptOnLeave = True
        Me.maskedtextboxCUIT.Location = New System.Drawing.Point(75, 32)
        Me.maskedtextboxCUIT.Mask = "00-00000000-0"
        Me.maskedtextboxCUIT.Name = "maskedtextboxCUIT"
        Me.maskedtextboxCUIT.Size = New System.Drawing.Size(99, 20)
        Me.maskedtextboxCUIT.TabIndex = 3
        Me.maskedtextboxCUIT.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'textboxTelefono1
        '
        Me.textboxTelefono1.Location = New System.Drawing.Point(75, 65)
        Me.textboxTelefono1.MaxLength = 50
        Me.textboxTelefono1.Name = "textboxTelefono1"
        Me.textboxTelefono1.Size = New System.Drawing.Size(170, 20)
        Me.textboxTelefono1.TabIndex = 5
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelID)
        Me.tabpageNotasAuditoria.Controls.Add(Me.checkboxEsActivo)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxID)
        Me.tabpageNotasAuditoria.Controls.Add(labelEsActivo)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(labelModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(labelCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxNotas)
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelNotas)
        Me.tabpageNotasAuditoria.Location = New System.Drawing.Point(4, 25)
        Me.tabpageNotasAuditoria.Name = "tabpageNotasAuditoria"
        Me.tabpageNotasAuditoria.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(511, 365)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelID
        '
        Me.labelID.AutoSize = True
        Me.labelID.Location = New System.Drawing.Point(8, 290)
        Me.labelID.Name = "labelID"
        Me.labelID.Size = New System.Drawing.Size(21, 13)
        Me.labelID.TabIndex = 4
        Me.labelID.Text = "ID:"
        '
        'textboxID
        '
        Me.textboxID.Location = New System.Drawing.Point(116, 287)
        Me.textboxID.MaxLength = 10
        Me.textboxID.Name = "textboxID"
        Me.textboxID.ReadOnly = True
        Me.textboxID.Size = New System.Drawing.Size(72, 20)
        Me.textboxID.TabIndex = 5
        Me.textboxID.TabStop = False
        Me.textboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(243, 339)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 11
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(243, 313)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 8
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(116, 339)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 10
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(116, 313)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 7
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(116, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(386, 251)
        Me.textboxNotas.TabIndex = 1
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(6, 9)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 0
        Me.labelNotas.Text = "Notas:"
        '
        'formProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 448)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formProveedor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Proveedor"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        Me.tabpageNotasAuditoria.ResumeLayout(False)
        Me.tabpageNotasAuditoria.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textboxNombre As System.Windows.Forms.TextBox
    Friend WithEvents labelNombre As System.Windows.Forms.Label
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents checkboxEsActivo As System.Windows.Forms.CheckBox
    Friend WithEvents tabcontrolMain As CS_Control_TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents labelID As System.Windows.Forms.Label
    Friend WithEvents textboxID As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents maskedtextboxCUIT As MaskedTextBox
    Friend WithEvents textboxTelefono2 As TextBox
    Friend WithEvents textboxTelefono1 As TextBox
    Friend WithEvents textboxEmail2 As TextBox
    Friend WithEvents textboxEmail1 As TextBox
    Friend WithEvents textboxDomicilioCalle3 As TextBox
    Friend WithEvents textboxDomicilioCalle2 As TextBox
    Friend WithEvents comboboxDomicilioLocalidad As ComboBox
    Friend WithEvents comboboxDomicilioProvincia As ComboBox
    Friend WithEvents textboxDomicilioCalle1 As TextBox
    Friend WithEvents textboxDomicilioCodigoPostal As TextBox
    Friend WithEvents textboxDomicilioDepartamento As TextBox
    Friend WithEvents textboxDomicilioNumero As TextBox
    Friend WithEvents textboxDomicilioPiso As TextBox
End Class
