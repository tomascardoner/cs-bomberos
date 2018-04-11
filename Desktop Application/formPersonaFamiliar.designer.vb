<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaFamiliar
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
        Dim labelApellido As System.Windows.Forms.Label
        Dim labelNombre As System.Windows.Forms.Label
        Dim labelIOMANumeroAfiliado As System.Windows.Forms.Label
        Dim labelIOMATiene As System.Windows.Forms.Label
        Dim labelFactorRH As System.Windows.Forms.Label
        Dim labelGrupoSanguineo As System.Windows.Forms.Label
        Dim labelParentesco As System.Windows.Forms.Label
        Dim labelVive As System.Windows.Forms.Label
        Dim labelFechaNacimiento As System.Windows.Forms.Label
        Dim labelGenero As System.Windows.Forms.Label
        Dim labelDocumento As System.Windows.Forms.Label
        Dim labelTelefono As System.Windows.Forms.Label
        Dim labelCelular As System.Windows.Forms.Label
        Dim labelEmail As System.Windows.Forms.Label
        Dim labelDomicilioCalle3 As System.Windows.Forms.Label
        Dim labelDomicilioCalle2 As System.Windows.Forms.Label
        Dim labelDomicilioCalle1 As System.Windows.Forms.Label
        Dim labelDomicilioCodigoPostal As System.Windows.Forms.Label
        Dim labelDomicilioDepartamento As System.Windows.Forms.Label
        Dim labelDomicilioLocalidad As System.Windows.Forms.Label
        Dim labelDomicilioProvincia As System.Windows.Forms.Label
        Dim labelDomicilioNumero As System.Windows.Forms.Label
        Dim labelDomicilioPiso As System.Windows.Forms.Label
        Dim labelEsActivo As System.Windows.Forms.Label
        Dim labelNotas As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.textboxApellido = New System.Windows.Forms.TextBox()
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.tabcontrolMain = New CSBomberos.DesktopApplication.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.textboxIOMANumeroAfiliado = New System.Windows.Forms.TextBox()
        Me.comboboxIOMATiene = New System.Windows.Forms.ComboBox()
        Me.comboboxFactorRH = New System.Windows.Forms.ComboBox()
        Me.comboboxGrupoSanguineo = New System.Windows.Forms.ComboBox()
        Me.comboboxParentesco = New System.Windows.Forms.ComboBox()
        Me.checkboxVive = New System.Windows.Forms.CheckBox()
        Me.datetimepickerFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.comboboxGenero = New System.Windows.Forms.ComboBox()
        Me.comboboxDocumentoTipo = New System.Windows.Forms.ComboBox()
        Me.textboxDocumentoNumero = New System.Windows.Forms.TextBox()
        Me.maskedtextboxDocumentoNumero = New System.Windows.Forms.MaskedTextBox()
        Me.tabpageContacto = New System.Windows.Forms.TabPage()
        Me.textboxTelefono = New System.Windows.Forms.TextBox()
        Me.textboxCelular = New System.Windows.Forms.TextBox()
        Me.textboxEmail = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioCalle3 = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioCalle2 = New System.Windows.Forms.TextBox()
        Me.comboboxDomicilioLocalidad = New System.Windows.Forms.ComboBox()
        Me.comboboxDomicilioProvincia = New System.Windows.Forms.ComboBox()
        Me.textboxDomicilioCalle1 = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioCodigoPostal = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioDepartamento = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioNumero = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioPiso = New System.Windows.Forms.TextBox()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.labelIDFamiliar = New System.Windows.Forms.Label()
        Me.textboxIDFamiliar = New System.Windows.Forms.TextBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        labelApellido = New System.Windows.Forms.Label()
        labelNombre = New System.Windows.Forms.Label()
        labelIOMANumeroAfiliado = New System.Windows.Forms.Label()
        labelIOMATiene = New System.Windows.Forms.Label()
        labelFactorRH = New System.Windows.Forms.Label()
        labelGrupoSanguineo = New System.Windows.Forms.Label()
        labelParentesco = New System.Windows.Forms.Label()
        labelVive = New System.Windows.Forms.Label()
        labelFechaNacimiento = New System.Windows.Forms.Label()
        labelGenero = New System.Windows.Forms.Label()
        labelDocumento = New System.Windows.Forms.Label()
        labelTelefono = New System.Windows.Forms.Label()
        labelCelular = New System.Windows.Forms.Label()
        labelEmail = New System.Windows.Forms.Label()
        labelDomicilioCalle3 = New System.Windows.Forms.Label()
        labelDomicilioCalle2 = New System.Windows.Forms.Label()
        labelDomicilioCalle1 = New System.Windows.Forms.Label()
        labelDomicilioCodigoPostal = New System.Windows.Forms.Label()
        labelDomicilioDepartamento = New System.Windows.Forms.Label()
        labelDomicilioLocalidad = New System.Windows.Forms.Label()
        labelDomicilioProvincia = New System.Windows.Forms.Label()
        labelDomicilioNumero = New System.Windows.Forms.Label()
        labelDomicilioPiso = New System.Windows.Forms.Label()
        labelEsActivo = New System.Windows.Forms.Label()
        labelNotas = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.tabpageContacto.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelApellido
        '
        labelApellido.AutoSize = True
        labelApellido.Location = New System.Drawing.Point(12, 61)
        labelApellido.Name = "labelApellido"
        labelApellido.Size = New System.Drawing.Size(52, 13)
        labelApellido.TabIndex = 0
        labelApellido.Text = "Apellidos:"
        '
        'labelNombre
        '
        labelNombre.AutoSize = True
        labelNombre.Location = New System.Drawing.Point(12, 87)
        labelNombre.Name = "labelNombre"
        labelNombre.Size = New System.Drawing.Size(52, 13)
        labelNombre.TabIndex = 2
        labelNombre.Text = "Nombres:"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(538, 39)
        Me.toolstripMain.TabIndex = 5
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_CLOSE_32
        Me.buttonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCerrar.Name = "buttonCerrar"
        Me.buttonCerrar.Size = New System.Drawing.Size(75, 36)
        Me.buttonCerrar.Text = "Cerrar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_CANCEL_32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_OK_32
        Me.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(85, 36)
        Me.buttonGuardar.Text = "Guardar"
        '
        'textboxApellido
        '
        Me.textboxApellido.Location = New System.Drawing.Point(94, 58)
        Me.textboxApellido.MaxLength = 50
        Me.textboxApellido.Name = "textboxApellido"
        Me.textboxApellido.Size = New System.Drawing.Size(239, 20)
        Me.textboxApellido.TabIndex = 1
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(94, 84)
        Me.textboxNombre.MaxLength = 50
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(239, 20)
        Me.textboxNombre.TabIndex = 3
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageContacto)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 121)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(514, 325)
        Me.tabcontrolMain.TabIndex = 4
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.textboxIOMANumeroAfiliado)
        Me.tabpageGeneral.Controls.Add(labelIOMANumeroAfiliado)
        Me.tabpageGeneral.Controls.Add(Me.comboboxIOMATiene)
        Me.tabpageGeneral.Controls.Add(labelIOMATiene)
        Me.tabpageGeneral.Controls.Add(Me.comboboxFactorRH)
        Me.tabpageGeneral.Controls.Add(labelFactorRH)
        Me.tabpageGeneral.Controls.Add(Me.comboboxGrupoSanguineo)
        Me.tabpageGeneral.Controls.Add(labelGrupoSanguineo)
        Me.tabpageGeneral.Controls.Add(labelParentesco)
        Me.tabpageGeneral.Controls.Add(Me.comboboxParentesco)
        Me.tabpageGeneral.Controls.Add(Me.checkboxVive)
        Me.tabpageGeneral.Controls.Add(labelVive)
        Me.tabpageGeneral.Controls.Add(labelFechaNacimiento)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFechaNacimiento)
        Me.tabpageGeneral.Controls.Add(Me.comboboxGenero)
        Me.tabpageGeneral.Controls.Add(labelGenero)
        Me.tabpageGeneral.Controls.Add(Me.comboboxDocumentoTipo)
        Me.tabpageGeneral.Controls.Add(Me.textboxDocumentoNumero)
        Me.tabpageGeneral.Controls.Add(labelDocumento)
        Me.tabpageGeneral.Controls.Add(Me.maskedtextboxDocumentoNumero)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(506, 296)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'textboxIOMANumeroAfiliado
        '
        Me.textboxIOMANumeroAfiliado.Location = New System.Drawing.Point(365, 161)
        Me.textboxIOMANumeroAfiliado.MaxLength = 13
        Me.textboxIOMANumeroAfiliado.Name = "textboxIOMANumeroAfiliado"
        Me.textboxIOMANumeroAfiliado.Size = New System.Drawing.Size(115, 20)
        Me.textboxIOMANumeroAfiliado.TabIndex = 16
        '
        'labelIOMANumeroAfiliado
        '
        labelIOMANumeroAfiliado.AutoSize = True
        labelIOMANumeroAfiliado.Location = New System.Drawing.Point(286, 164)
        labelIOMANumeroAfiliado.Name = "labelIOMANumeroAfiliado"
        labelIOMANumeroAfiliado.Size = New System.Drawing.Size(73, 13)
        labelIOMANumeroAfiliado.TabIndex = 15
        labelIOMANumeroAfiliado.Text = "Nº de afiliado:"
        '
        'comboboxIOMATiene
        '
        Me.comboboxIOMATiene.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxIOMATiene.FormattingEnabled = True
        Me.comboboxIOMATiene.Location = New System.Drawing.Point(142, 161)
        Me.comboboxIOMATiene.Name = "comboboxIOMATiene"
        Me.comboboxIOMATiene.Size = New System.Drawing.Size(121, 21)
        Me.comboboxIOMATiene.TabIndex = 14
        '
        'labelIOMATiene
        '
        labelIOMATiene.AutoSize = True
        labelIOMATiene.Location = New System.Drawing.Point(6, 164)
        labelIOMATiene.Name = "labelIOMATiene"
        labelIOMATiene.Size = New System.Drawing.Size(97, 13)
        labelIOMATiene.TabIndex = 13
        labelIOMATiene.Text = "Tiene I.O.M.A. por:"
        '
        'comboboxFactorRH
        '
        Me.comboboxFactorRH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxFactorRH.FormattingEnabled = True
        Me.comboboxFactorRH.Location = New System.Drawing.Point(365, 134)
        Me.comboboxFactorRH.Name = "comboboxFactorRH"
        Me.comboboxFactorRH.Size = New System.Drawing.Size(102, 21)
        Me.comboboxFactorRH.TabIndex = 12
        '
        'labelFactorRH
        '
        labelFactorRH.AutoSize = True
        labelFactorRH.Location = New System.Drawing.Point(286, 137)
        labelFactorRH.Name = "labelFactorRH"
        labelFactorRH.Size = New System.Drawing.Size(59, 13)
        labelFactorRH.TabIndex = 11
        labelFactorRH.Text = "Factor RH:"
        '
        'comboboxGrupoSanguineo
        '
        Me.comboboxGrupoSanguineo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxGrupoSanguineo.FormattingEnabled = True
        Me.comboboxGrupoSanguineo.Location = New System.Drawing.Point(142, 134)
        Me.comboboxGrupoSanguineo.Name = "comboboxGrupoSanguineo"
        Me.comboboxGrupoSanguineo.Size = New System.Drawing.Size(102, 21)
        Me.comboboxGrupoSanguineo.TabIndex = 10
        '
        'labelGrupoSanguineo
        '
        labelGrupoSanguineo.AutoSize = True
        labelGrupoSanguineo.Location = New System.Drawing.Point(6, 137)
        labelGrupoSanguineo.Name = "labelGrupoSanguineo"
        labelGrupoSanguineo.Size = New System.Drawing.Size(93, 13)
        labelGrupoSanguineo.TabIndex = 9
        labelGrupoSanguineo.Text = "Grupo sanguíneo:"
        '
        'labelParentesco
        '
        labelParentesco.AutoSize = True
        labelParentesco.Location = New System.Drawing.Point(6, 13)
        labelParentesco.Name = "labelParentesco"
        labelParentesco.Size = New System.Drawing.Size(64, 13)
        labelParentesco.TabIndex = 0
        labelParentesco.Text = "Parentesco:"
        '
        'comboboxParentesco
        '
        Me.comboboxParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxParentesco.FormattingEnabled = True
        Me.comboboxParentesco.Location = New System.Drawing.Point(142, 10)
        Me.comboboxParentesco.Name = "comboboxParentesco"
        Me.comboboxParentesco.Size = New System.Drawing.Size(161, 21)
        Me.comboboxParentesco.TabIndex = 1
        '
        'checkboxVive
        '
        Me.checkboxVive.AutoSize = True
        Me.checkboxVive.Location = New System.Drawing.Point(142, 188)
        Me.checkboxVive.Name = "checkboxVive"
        Me.checkboxVive.Size = New System.Drawing.Size(15, 14)
        Me.checkboxVive.TabIndex = 18
        Me.checkboxVive.UseVisualStyleBackColor = True
        '
        'labelVive
        '
        labelVive.AutoSize = True
        labelVive.Location = New System.Drawing.Point(6, 188)
        labelVive.Name = "labelVive"
        labelVive.Size = New System.Drawing.Size(31, 13)
        labelVive.TabIndex = 17
        labelVive.Text = "Vive:"
        '
        'labelFechaNacimiento
        '
        labelFechaNacimiento.AutoSize = True
        labelFechaNacimiento.Location = New System.Drawing.Point(6, 84)
        labelFechaNacimiento.Name = "labelFechaNacimiento"
        labelFechaNacimiento.Size = New System.Drawing.Size(111, 13)
        labelFechaNacimiento.TabIndex = 5
        labelFechaNacimiento.Text = "Fecha de Nacimiento:"
        '
        'datetimepickerFechaNacimiento
        '
        Me.datetimepickerFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaNacimiento.Location = New System.Drawing.Point(142, 81)
        Me.datetimepickerFechaNacimiento.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaNacimiento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaNacimiento.Name = "datetimepickerFechaNacimiento"
        Me.datetimepickerFechaNacimiento.ShowCheckBox = True
        Me.datetimepickerFechaNacimiento.Size = New System.Drawing.Size(148, 20)
        Me.datetimepickerFechaNacimiento.TabIndex = 6
        '
        'comboboxGenero
        '
        Me.comboboxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxGenero.FormattingEnabled = True
        Me.comboboxGenero.Location = New System.Drawing.Point(142, 107)
        Me.comboboxGenero.Name = "comboboxGenero"
        Me.comboboxGenero.Size = New System.Drawing.Size(102, 21)
        Me.comboboxGenero.TabIndex = 8
        '
        'labelGenero
        '
        labelGenero.AutoSize = True
        labelGenero.Location = New System.Drawing.Point(6, 110)
        labelGenero.Name = "labelGenero"
        labelGenero.Size = New System.Drawing.Size(45, 13)
        labelGenero.TabIndex = 7
        labelGenero.Text = "Género:"
        '
        'comboboxDocumentoTipo
        '
        Me.comboboxDocumentoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDocumentoTipo.FormattingEnabled = True
        Me.comboboxDocumentoTipo.Location = New System.Drawing.Point(142, 54)
        Me.comboboxDocumentoTipo.Name = "comboboxDocumentoTipo"
        Me.comboboxDocumentoTipo.Size = New System.Drawing.Size(102, 21)
        Me.comboboxDocumentoTipo.TabIndex = 3
        '
        'textboxDocumentoNumero
        '
        Me.textboxDocumentoNumero.Location = New System.Drawing.Point(250, 54)
        Me.textboxDocumentoNumero.MaxLength = 11
        Me.textboxDocumentoNumero.Name = "textboxDocumentoNumero"
        Me.textboxDocumentoNumero.Size = New System.Drawing.Size(115, 20)
        Me.textboxDocumentoNumero.TabIndex = 4
        '
        'labelDocumento
        '
        labelDocumento.AutoSize = True
        labelDocumento.Location = New System.Drawing.Point(6, 57)
        labelDocumento.Name = "labelDocumento"
        labelDocumento.Size = New System.Drawing.Size(65, 13)
        labelDocumento.TabIndex = 2
        labelDocumento.Text = "Documento:"
        '
        'maskedtextboxDocumentoNumero
        '
        Me.maskedtextboxDocumentoNumero.AllowPromptAsInput = False
        Me.maskedtextboxDocumentoNumero.AsciiOnly = True
        Me.maskedtextboxDocumentoNumero.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxDocumentoNumero.HidePromptOnLeave = True
        Me.maskedtextboxDocumentoNumero.Location = New System.Drawing.Point(250, 54)
        Me.maskedtextboxDocumentoNumero.Mask = "00-00000000-0"
        Me.maskedtextboxDocumentoNumero.Name = "maskedtextboxDocumentoNumero"
        Me.maskedtextboxDocumentoNumero.Size = New System.Drawing.Size(115, 20)
        Me.maskedtextboxDocumentoNumero.TabIndex = 5
        Me.maskedtextboxDocumentoNumero.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'tabpageContacto
        '
        Me.tabpageContacto.Controls.Add(labelTelefono)
        Me.tabpageContacto.Controls.Add(Me.textboxTelefono)
        Me.tabpageContacto.Controls.Add(labelCelular)
        Me.tabpageContacto.Controls.Add(Me.textboxCelular)
        Me.tabpageContacto.Controls.Add(labelEmail)
        Me.tabpageContacto.Controls.Add(Me.textboxEmail)
        Me.tabpageContacto.Controls.Add(labelDomicilioCalle3)
        Me.tabpageContacto.Controls.Add(labelDomicilioCalle2)
        Me.tabpageContacto.Controls.Add(Me.textboxDomicilioCalle3)
        Me.tabpageContacto.Controls.Add(Me.textboxDomicilioCalle2)
        Me.tabpageContacto.Controls.Add(Me.comboboxDomicilioLocalidad)
        Me.tabpageContacto.Controls.Add(Me.comboboxDomicilioProvincia)
        Me.tabpageContacto.Controls.Add(labelDomicilioCalle1)
        Me.tabpageContacto.Controls.Add(Me.textboxDomicilioCalle1)
        Me.tabpageContacto.Controls.Add(labelDomicilioCodigoPostal)
        Me.tabpageContacto.Controls.Add(Me.textboxDomicilioCodigoPostal)
        Me.tabpageContacto.Controls.Add(labelDomicilioDepartamento)
        Me.tabpageContacto.Controls.Add(Me.textboxDomicilioDepartamento)
        Me.tabpageContacto.Controls.Add(labelDomicilioLocalidad)
        Me.tabpageContacto.Controls.Add(labelDomicilioProvincia)
        Me.tabpageContacto.Controls.Add(labelDomicilioNumero)
        Me.tabpageContacto.Controls.Add(Me.textboxDomicilioNumero)
        Me.tabpageContacto.Controls.Add(labelDomicilioPiso)
        Me.tabpageContacto.Controls.Add(Me.textboxDomicilioPiso)
        Me.tabpageContacto.Location = New System.Drawing.Point(4, 25)
        Me.tabpageContacto.Name = "tabpageContacto"
        Me.tabpageContacto.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageContacto.Size = New System.Drawing.Size(506, 296)
        Me.tabpageContacto.TabIndex = 1
        Me.tabpageContacto.Text = "Contacto"
        Me.tabpageContacto.UseVisualStyleBackColor = True
        '
        'labelTelefono
        '
        labelTelefono.AutoSize = True
        labelTelefono.Location = New System.Drawing.Point(6, 220)
        labelTelefono.Name = "labelTelefono"
        labelTelefono.Size = New System.Drawing.Size(52, 13)
        labelTelefono.TabIndex = 18
        labelTelefono.Text = "Teléfono:"
        '
        'textboxTelefono
        '
        Me.textboxTelefono.Location = New System.Drawing.Point(72, 217)
        Me.textboxTelefono.MaxLength = 50
        Me.textboxTelefono.Name = "textboxTelefono"
        Me.textboxTelefono.Size = New System.Drawing.Size(170, 20)
        Me.textboxTelefono.TabIndex = 19
        '
        'labelCelular
        '
        labelCelular.AutoSize = True
        labelCelular.Location = New System.Drawing.Point(6, 246)
        labelCelular.Name = "labelCelular"
        labelCelular.Size = New System.Drawing.Size(42, 13)
        labelCelular.TabIndex = 20
        labelCelular.Text = "Celular:"
        '
        'textboxCelular
        '
        Me.textboxCelular.Location = New System.Drawing.Point(72, 243)
        Me.textboxCelular.MaxLength = 50
        Me.textboxCelular.Name = "textboxCelular"
        Me.textboxCelular.Size = New System.Drawing.Size(170, 20)
        Me.textboxCelular.TabIndex = 21
        '
        'labelEmail
        '
        labelEmail.AutoSize = True
        labelEmail.Location = New System.Drawing.Point(6, 272)
        labelEmail.Name = "labelEmail"
        labelEmail.Size = New System.Drawing.Size(38, 13)
        labelEmail.TabIndex = 22
        labelEmail.Text = "E-mail:"
        '
        'textboxEmail
        '
        Me.textboxEmail.Location = New System.Drawing.Point(72, 269)
        Me.textboxEmail.MaxLength = 50
        Me.textboxEmail.Name = "textboxEmail"
        Me.textboxEmail.Size = New System.Drawing.Size(306, 20)
        Me.textboxEmail.TabIndex = 23
        '
        'labelDomicilioCalle3
        '
        labelDomicilioCalle3.AutoSize = True
        labelDomicilioCalle3.Location = New System.Drawing.Point(6, 91)
        labelDomicilioCalle3.Name = "labelDomicilioCalle3"
        labelDomicilioCalle3.Size = New System.Drawing.Size(42, 13)
        labelDomicilioCalle3.TabIndex = 10
        labelDomicilioCalle3.Text = "Calle 3:"
        '
        'labelDomicilioCalle2
        '
        labelDomicilioCalle2.AutoSize = True
        labelDomicilioCalle2.Location = New System.Drawing.Point(6, 65)
        labelDomicilioCalle2.Name = "labelDomicilioCalle2"
        labelDomicilioCalle2.Size = New System.Drawing.Size(42, 13)
        labelDomicilioCalle2.TabIndex = 8
        labelDomicilioCalle2.Text = "Calle 2:"
        '
        'textboxDomicilioCalle3
        '
        Me.textboxDomicilioCalle3.Location = New System.Drawing.Point(72, 88)
        Me.textboxDomicilioCalle3.MaxLength = 50
        Me.textboxDomicilioCalle3.Name = "textboxDomicilioCalle3"
        Me.textboxDomicilioCalle3.Size = New System.Drawing.Size(258, 20)
        Me.textboxDomicilioCalle3.TabIndex = 11
        '
        'textboxDomicilioCalle2
        '
        Me.textboxDomicilioCalle2.Location = New System.Drawing.Point(72, 62)
        Me.textboxDomicilioCalle2.MaxLength = 50
        Me.textboxDomicilioCalle2.Name = "textboxDomicilioCalle2"
        Me.textboxDomicilioCalle2.Size = New System.Drawing.Size(258, 20)
        Me.textboxDomicilioCalle2.TabIndex = 9
        '
        'comboboxDomicilioLocalidad
        '
        Me.comboboxDomicilioLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDomicilioLocalidad.FormattingEnabled = True
        Me.comboboxDomicilioLocalidad.Location = New System.Drawing.Point(72, 141)
        Me.comboboxDomicilioLocalidad.Name = "comboboxDomicilioLocalidad"
        Me.comboboxDomicilioLocalidad.Size = New System.Drawing.Size(258, 21)
        Me.comboboxDomicilioLocalidad.TabIndex = 15
        '
        'comboboxDomicilioProvincia
        '
        Me.comboboxDomicilioProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDomicilioProvincia.FormattingEnabled = True
        Me.comboboxDomicilioProvincia.Location = New System.Drawing.Point(72, 114)
        Me.comboboxDomicilioProvincia.Name = "comboboxDomicilioProvincia"
        Me.comboboxDomicilioProvincia.Size = New System.Drawing.Size(258, 21)
        Me.comboboxDomicilioProvincia.TabIndex = 13
        '
        'labelDomicilioCalle1
        '
        labelDomicilioCalle1.AutoSize = True
        labelDomicilioCalle1.Location = New System.Drawing.Point(6, 13)
        labelDomicilioCalle1.Name = "labelDomicilioCalle1"
        labelDomicilioCalle1.Size = New System.Drawing.Size(33, 13)
        labelDomicilioCalle1.TabIndex = 0
        labelDomicilioCalle1.Text = "Calle:"
        '
        'textboxDomicilioCalle1
        '
        Me.textboxDomicilioCalle1.Location = New System.Drawing.Point(72, 10)
        Me.textboxDomicilioCalle1.MaxLength = 100
        Me.textboxDomicilioCalle1.Name = "textboxDomicilioCalle1"
        Me.textboxDomicilioCalle1.Size = New System.Drawing.Size(258, 20)
        Me.textboxDomicilioCalle1.TabIndex = 1
        '
        'labelDomicilioCodigoPostal
        '
        labelDomicilioCodigoPostal.AutoSize = True
        labelDomicilioCodigoPostal.Location = New System.Drawing.Point(6, 171)
        labelDomicilioCodigoPostal.Name = "labelDomicilioCodigoPostal"
        labelDomicilioCodigoPostal.Size = New System.Drawing.Size(59, 13)
        labelDomicilioCodigoPostal.TabIndex = 16
        labelDomicilioCodigoPostal.Text = "Cód. Post.:"
        '
        'textboxDomicilioCodigoPostal
        '
        Me.textboxDomicilioCodigoPostal.Location = New System.Drawing.Point(72, 168)
        Me.textboxDomicilioCodigoPostal.MaxLength = 8
        Me.textboxDomicilioCodigoPostal.Name = "textboxDomicilioCodigoPostal"
        Me.textboxDomicilioCodigoPostal.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioCodigoPostal.TabIndex = 17
        '
        'labelDomicilioDepartamento
        '
        labelDomicilioDepartamento.AutoSize = True
        labelDomicilioDepartamento.Location = New System.Drawing.Point(220, 39)
        labelDomicilioDepartamento.Name = "labelDomicilioDepartamento"
        labelDomicilioDepartamento.Size = New System.Drawing.Size(54, 13)
        labelDomicilioDepartamento.TabIndex = 6
        labelDomicilioDepartamento.Text = "Dto/Ofic.:"
        '
        'textboxDomicilioDepartamento
        '
        Me.textboxDomicilioDepartamento.Location = New System.Drawing.Point(280, 36)
        Me.textboxDomicilioDepartamento.MaxLength = 10
        Me.textboxDomicilioDepartamento.Name = "textboxDomicilioDepartamento"
        Me.textboxDomicilioDepartamento.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioDepartamento.TabIndex = 7
        '
        'labelDomicilioLocalidad
        '
        labelDomicilioLocalidad.AutoSize = True
        labelDomicilioLocalidad.Location = New System.Drawing.Point(6, 144)
        labelDomicilioLocalidad.Name = "labelDomicilioLocalidad"
        labelDomicilioLocalidad.Size = New System.Drawing.Size(56, 13)
        labelDomicilioLocalidad.TabIndex = 14
        labelDomicilioLocalidad.Text = "Localidad:"
        '
        'labelDomicilioProvincia
        '
        labelDomicilioProvincia.AutoSize = True
        labelDomicilioProvincia.Location = New System.Drawing.Point(6, 117)
        labelDomicilioProvincia.Name = "labelDomicilioProvincia"
        labelDomicilioProvincia.Size = New System.Drawing.Size(54, 13)
        labelDomicilioProvincia.TabIndex = 12
        labelDomicilioProvincia.Text = "Provincia:"
        '
        'labelDomicilioNumero
        '
        labelDomicilioNumero.AutoSize = True
        labelDomicilioNumero.Location = New System.Drawing.Point(6, 39)
        labelDomicilioNumero.Name = "labelDomicilioNumero"
        labelDomicilioNumero.Size = New System.Drawing.Size(47, 13)
        labelDomicilioNumero.TabIndex = 2
        labelDomicilioNumero.Text = "Número:"
        '
        'textboxDomicilioNumero
        '
        Me.textboxDomicilioNumero.Location = New System.Drawing.Point(72, 36)
        Me.textboxDomicilioNumero.MaxLength = 10
        Me.textboxDomicilioNumero.Name = "textboxDomicilioNumero"
        Me.textboxDomicilioNumero.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioNumero.TabIndex = 3
        '
        'labelDomicilioPiso
        '
        labelDomicilioPiso.AutoSize = True
        labelDomicilioPiso.Location = New System.Drawing.Point(128, 39)
        labelDomicilioPiso.Name = "labelDomicilioPiso"
        labelDomicilioPiso.Size = New System.Drawing.Size(30, 13)
        labelDomicilioPiso.TabIndex = 4
        labelDomicilioPiso.Text = "Piso:"
        '
        'textboxDomicilioPiso
        '
        Me.textboxDomicilioPiso.Location = New System.Drawing.Point(164, 36)
        Me.textboxDomicilioPiso.MaxLength = 10
        Me.textboxDomicilioPiso.Name = "textboxDomicilioPiso"
        Me.textboxDomicilioPiso.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioPiso.TabIndex = 5
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.checkboxEsActivo)
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelIDFamiliar)
        Me.tabpageNotasAuditoria.Controls.Add(labelEsActivo)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxIDFamiliar)
        Me.tabpageNotasAuditoria.Controls.Add(labelNotas)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxNotas)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(labelModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(labelCreacion)
        Me.tabpageNotasAuditoria.Location = New System.Drawing.Point(4, 25)
        Me.tabpageNotasAuditoria.Name = "tabpageNotasAuditoria"
        Me.tabpageNotasAuditoria.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(506, 296)
        Me.tabpageNotasAuditoria.TabIndex = 7
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(114, 198)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 3
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'labelIDFamiliar
        '
        Me.labelIDFamiliar.AutoSize = True
        Me.labelIDFamiliar.Location = New System.Drawing.Point(6, 221)
        Me.labelIDFamiliar.Name = "labelIDFamiliar"
        Me.labelIDFamiliar.Size = New System.Drawing.Size(74, 13)
        Me.labelIDFamiliar.TabIndex = 1
        Me.labelIDFamiliar.Text = "ID de Familiar:"
        '
        'labelEsActivo
        '
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(6, 198)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 2
        labelEsActivo.Text = "Activo:"
        '
        'textboxIDFamiliar
        '
        Me.textboxIDFamiliar.Location = New System.Drawing.Point(114, 218)
        Me.textboxIDFamiliar.MaxLength = 10
        Me.textboxIDFamiliar.Name = "textboxIDFamiliar"
        Me.textboxIDFamiliar.ReadOnly = True
        Me.textboxIDFamiliar.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDFamiliar.TabIndex = 2
        Me.textboxIDFamiliar.TabStop = False
        Me.textboxIDFamiliar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelNotas
        '
        labelNotas.AutoSize = True
        labelNotas.Location = New System.Drawing.Point(6, 9)
        labelNotas.Name = "labelNotas"
        labelNotas.Size = New System.Drawing.Size(38, 13)
        labelNotas.TabIndex = 0
        labelNotas.Text = "Notas:"
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(114, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.Size = New System.Drawing.Size(386, 186)
        Me.textboxNotas.TabIndex = 1
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 270)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 9
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 244)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 6
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 270)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 8
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 244)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 5
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 273)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 7
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 247)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 4
        labelCreacion.Text = "Creación:"
        '
        'formPersonaFamiliar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 458)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(labelApellido)
        Me.Controls.Add(Me.textboxApellido)
        Me.Controls.Add(labelNombre)
        Me.Controls.Add(Me.textboxNombre)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPersonaFamiliar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Familiar de la Persona"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        Me.tabpageContacto.ResumeLayout(False)
        Me.tabpageContacto.PerformLayout()
        Me.tabpageNotasAuditoria.ResumeLayout(False)
        Me.tabpageNotasAuditoria.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tabcontrolMain As CSBomberos.DesktopApplication.CS_Control_TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents checkboxVive As System.Windows.Forms.CheckBox
    Friend WithEvents datetimepickerFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents comboboxGenero As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxDocumentoTipo As System.Windows.Forms.ComboBox
    Friend WithEvents textboxDocumentoNumero As System.Windows.Forms.TextBox
    Friend WithEvents maskedtextboxDocumentoNumero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tabpageContacto As System.Windows.Forms.TabPage
    Friend WithEvents textboxTelefono As System.Windows.Forms.TextBox
    Friend WithEvents textboxCelular As System.Windows.Forms.TextBox
    Friend WithEvents textboxEmail As System.Windows.Forms.TextBox
    Friend WithEvents textboxDomicilioCalle3 As System.Windows.Forms.TextBox
    Friend WithEvents textboxDomicilioCalle2 As System.Windows.Forms.TextBox
    Friend WithEvents comboboxDomicilioLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxDomicilioProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents textboxDomicilioCalle1 As System.Windows.Forms.TextBox
    Friend WithEvents textboxDomicilioCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents textboxDomicilioDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents textboxDomicilioNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxDomicilioPiso As System.Windows.Forms.TextBox
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents checkboxEsActivo As System.Windows.Forms.CheckBox
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents labelIDFamiliar As System.Windows.Forms.Label
    Friend WithEvents textboxIDFamiliar As System.Windows.Forms.TextBox
    Friend WithEvents textboxApellido As System.Windows.Forms.TextBox
    Friend WithEvents textboxNombre As System.Windows.Forms.TextBox
    Friend WithEvents comboboxParentesco As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxFactorRH As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxGrupoSanguineo As System.Windows.Forms.ComboBox
    Friend WithEvents textboxIOMANumeroAfiliado As System.Windows.Forms.TextBox
    Friend WithEvents comboboxIOMATiene As System.Windows.Forms.ComboBox
End Class
