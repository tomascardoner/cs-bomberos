<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersona
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
        Me.components = New System.ComponentModel.Container()
        Dim labelApellido As System.Windows.Forms.Label
        Dim labelNombre As System.Windows.Forms.Label
        Dim labelMatriculaNumero As System.Windows.Forms.Label
        Dim labelEstado As System.Windows.Forms.Label
        Dim labelFechaNacimiento As System.Windows.Forms.Label
        Dim labelGenero As System.Windows.Forms.Label
        Dim labelDocumento As System.Windows.Forms.Label
        Dim labelNacionalidad As System.Windows.Forms.Label
        Dim labelProfesion As System.Windows.Forms.Label
        Dim labelCuartel As System.Windows.Forms.Label
        Dim labelTelefonoParticular As System.Windows.Forms.Label
        Dim labelCelularParticular As System.Windows.Forms.Label
        Dim labelEmailParticular As System.Windows.Forms.Label
        Dim labelDomicilioParticularCalle3 As System.Windows.Forms.Label
        Dim labelDomicilioParticularCalle2 As System.Windows.Forms.Label
        Dim labelDomicilioParticularCalle1 As System.Windows.Forms.Label
        Dim labelDomicilioParticularCodigoPostal As System.Windows.Forms.Label
        Dim labelDomicilioParticularDepartamento As System.Windows.Forms.Label
        Dim labelDomicilioParticularLocalidad As System.Windows.Forms.Label
        Dim labelDomicilioParticularProvincia As System.Windows.Forms.Label
        Dim labelDomicilioParticularNumero As System.Windows.Forms.Label
        Dim labelDomicilioParticularPiso As System.Windows.Forms.Label
        Dim labelTelefonoLaboral As System.Windows.Forms.Label
        Dim labelCelularLaboral As System.Windows.Forms.Label
        Dim labelEmailLaboral As System.Windows.Forms.Label
        Dim labelDomicilioLaboralCalle3 As System.Windows.Forms.Label
        Dim labelDomicilioLaboralCalle2 As System.Windows.Forms.Label
        Dim labelDomicilioLaboralCalle1 As System.Windows.Forms.Label
        Dim labelDomicilioLaboralCodigoPostal As System.Windows.Forms.Label
        Dim labelDomicilioLaboralDepartamento As System.Windows.Forms.Label
        Dim labelDomicilioLaboralLocalidad As System.Windows.Forms.Label
        Dim labelDomicilioLaboralProvincia As System.Windows.Forms.Label
        Dim labelDomicilioLaboralNumero As System.Windows.Forms.Label
        Dim labelDomicilioLaboralPiso As System.Windows.Forms.Label
        Dim labelEsActivo As System.Windows.Forms.Label
        Dim labelNotas As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim labelGrupoSanguineo As System.Windows.Forms.Label
        Dim labelFactorRH As System.Windows.Forms.Label
        Dim labelNivelEstudio As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPersona))
        Me.labelIDPersona = New System.Windows.Forms.Label()
        Me.textboxApellido = New System.Windows.Forms.TextBox()
        Me.textboxIDPersona = New System.Windows.Forms.TextBox()
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.pictureboxMain = New System.Windows.Forms.PictureBox()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tooltipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.textboxMatriculaNumero = New System.Windows.Forms.TextBox()
        Me.textboxDocumentoNumero = New System.Windows.Forms.TextBox()
        Me.tabcontrolMain = New CSBomberos.DesktopApplication.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.comboboxEstado = New System.Windows.Forms.ComboBox()
        Me.datetimepickerFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.comboboxGenero = New System.Windows.Forms.ComboBox()
        Me.comboboxDocumentoTipo = New System.Windows.Forms.ComboBox()
        Me.maskedtextboxDocumentoNumero = New System.Windows.Forms.MaskedTextBox()
        Me.textboxNacionalidad = New System.Windows.Forms.TextBox()
        Me.textboxProfesion = New System.Windows.Forms.TextBox()
        Me.comboboxCuartel = New System.Windows.Forms.ComboBox()
        Me.tabpageParticular = New System.Windows.Forms.TabPage()
        Me.textboxTelefonoParticular = New System.Windows.Forms.TextBox()
        Me.textboxCelularParticular = New System.Windows.Forms.TextBox()
        Me.textboxEmailParticular = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioParticularCalle3 = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioParticularCalle2 = New System.Windows.Forms.TextBox()
        Me.comboboxDomicilioParticularLocalidad = New System.Windows.Forms.ComboBox()
        Me.comboboxDomicilioParticularProvincia = New System.Windows.Forms.ComboBox()
        Me.textboxDomicilioParticularCalle1 = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioParticularCodigoPostal = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioParticularDepartamento = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioParticularNumero = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioParticularPiso = New System.Windows.Forms.TextBox()
        Me.tabpageLaboral = New System.Windows.Forms.TabPage()
        Me.textboxTelefonoLaboral = New System.Windows.Forms.TextBox()
        Me.textboxCelularLaboral = New System.Windows.Forms.TextBox()
        Me.textboxEmailLaboral = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioLaboralCalle3 = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioLaboralCalle2 = New System.Windows.Forms.TextBox()
        Me.comboboxDomicilioLaboralLocalidad = New System.Windows.Forms.ComboBox()
        Me.comboboxDomicilioLaboralProvincia = New System.Windows.Forms.ComboBox()
        Me.textboxDomicilioLaboralCalle1 = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioLaboralCodigoPostal = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioLaboralDepartamento = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioLaboralNumero = New System.Windows.Forms.TextBox()
        Me.textboxDomicilioLaboralPiso = New System.Windows.Forms.TextBox()
        Me.tabpageFamiliares = New System.Windows.Forms.TabPage()
        Me.datagridviewFamiliares = New System.Windows.Forms.DataGridView()
        Me.columnFamiliares_Parentesco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFamiliares_Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFamiliares_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripFamiliares = New System.Windows.Forms.ToolStrip()
        Me.buttonFamiliares_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonFamiliares_Editar = New System.Windows.Forms.ToolStripButton()
        Me.buttonFamiliares_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.comboboxGrupoSanguineo = New System.Windows.Forms.ComboBox()
        Me.comboboxFactorRH = New System.Windows.Forms.ComboBox()
        Me.comboboxNivelEstudio = New System.Windows.Forms.ComboBox()
        labelApellido = New System.Windows.Forms.Label()
        labelNombre = New System.Windows.Forms.Label()
        labelMatriculaNumero = New System.Windows.Forms.Label()
        labelEstado = New System.Windows.Forms.Label()
        labelFechaNacimiento = New System.Windows.Forms.Label()
        labelGenero = New System.Windows.Forms.Label()
        labelDocumento = New System.Windows.Forms.Label()
        labelNacionalidad = New System.Windows.Forms.Label()
        labelProfesion = New System.Windows.Forms.Label()
        labelCuartel = New System.Windows.Forms.Label()
        labelTelefonoParticular = New System.Windows.Forms.Label()
        labelCelularParticular = New System.Windows.Forms.Label()
        labelEmailParticular = New System.Windows.Forms.Label()
        labelDomicilioParticularCalle3 = New System.Windows.Forms.Label()
        labelDomicilioParticularCalle2 = New System.Windows.Forms.Label()
        labelDomicilioParticularCalle1 = New System.Windows.Forms.Label()
        labelDomicilioParticularCodigoPostal = New System.Windows.Forms.Label()
        labelDomicilioParticularDepartamento = New System.Windows.Forms.Label()
        labelDomicilioParticularLocalidad = New System.Windows.Forms.Label()
        labelDomicilioParticularProvincia = New System.Windows.Forms.Label()
        labelDomicilioParticularNumero = New System.Windows.Forms.Label()
        labelDomicilioParticularPiso = New System.Windows.Forms.Label()
        labelTelefonoLaboral = New System.Windows.Forms.Label()
        labelCelularLaboral = New System.Windows.Forms.Label()
        labelEmailLaboral = New System.Windows.Forms.Label()
        labelDomicilioLaboralCalle3 = New System.Windows.Forms.Label()
        labelDomicilioLaboralCalle2 = New System.Windows.Forms.Label()
        labelDomicilioLaboralCalle1 = New System.Windows.Forms.Label()
        labelDomicilioLaboralCodigoPostal = New System.Windows.Forms.Label()
        labelDomicilioLaboralDepartamento = New System.Windows.Forms.Label()
        labelDomicilioLaboralLocalidad = New System.Windows.Forms.Label()
        labelDomicilioLaboralProvincia = New System.Windows.Forms.Label()
        labelDomicilioLaboralNumero = New System.Windows.Forms.Label()
        labelDomicilioLaboralPiso = New System.Windows.Forms.Label()
        labelEsActivo = New System.Windows.Forms.Label()
        labelNotas = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelGrupoSanguineo = New System.Windows.Forms.Label()
        labelFactorRH = New System.Windows.Forms.Label()
        labelNivelEstudio = New System.Windows.Forms.Label()
        CType(Me.pictureboxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.tabpageParticular.SuspendLayout()
        Me.tabpageLaboral.SuspendLayout()
        Me.tabpageFamiliares.SuspendLayout()
        CType(Me.datagridviewFamiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripFamiliares.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelApellido
        '
        labelApellido.AutoSize = True
        labelApellido.Location = New System.Drawing.Point(73, 80)
        labelApellido.Name = "labelApellido"
        labelApellido.Size = New System.Drawing.Size(52, 13)
        labelApellido.TabIndex = 5
        labelApellido.Text = "Apellidos:"
        '
        'labelNombre
        '
        labelNombre.AutoSize = True
        labelNombre.Location = New System.Drawing.Point(73, 106)
        labelNombre.Name = "labelNombre"
        labelNombre.Size = New System.Drawing.Size(52, 13)
        labelNombre.TabIndex = 7
        labelNombre.Text = "Nombres:"
        '
        'labelMatriculaNumero
        '
        labelMatriculaNumero.AutoSize = True
        labelMatriculaNumero.Location = New System.Drawing.Point(267, 52)
        labelMatriculaNumero.Name = "labelMatriculaNumero"
        labelMatriculaNumero.Size = New System.Drawing.Size(55, 13)
        labelMatriculaNumero.TabIndex = 3
        labelMatriculaNumero.Text = "Matrícula:"
        '
        'labelEstado
        '
        labelEstado.AutoSize = True
        labelEstado.Location = New System.Drawing.Point(6, 226)
        labelEstado.Name = "labelEstado"
        labelEstado.Size = New System.Drawing.Size(43, 13)
        labelEstado.TabIndex = 19
        labelEstado.Text = "Estado:"
        '
        'labelFechaNacimiento
        '
        labelFechaNacimiento.AutoSize = True
        labelFechaNacimiento.Location = New System.Drawing.Point(6, 40)
        labelFechaNacimiento.Name = "labelFechaNacimiento"
        labelFechaNacimiento.Size = New System.Drawing.Size(109, 13)
        labelFechaNacimiento.TabIndex = 3
        labelFechaNacimiento.Text = "Fecha de nacimiento:"
        '
        'labelGenero
        '
        labelGenero.AutoSize = True
        labelGenero.Location = New System.Drawing.Point(6, 66)
        labelGenero.Name = "labelGenero"
        labelGenero.Size = New System.Drawing.Size(45, 13)
        labelGenero.TabIndex = 5
        labelGenero.Text = "Género:"
        '
        'labelDocumento
        '
        labelDocumento.AutoSize = True
        labelDocumento.Location = New System.Drawing.Point(6, 13)
        labelDocumento.Name = "labelDocumento"
        labelDocumento.Size = New System.Drawing.Size(65, 13)
        labelDocumento.TabIndex = 0
        labelDocumento.Text = "Documento:"
        Me.tooltipMain.SetToolTip(labelDocumento, "Ingrese el Número de Documento sin utilizar puntos.")
        '
        'labelNacionalidad
        '
        labelNacionalidad.AutoSize = True
        labelNacionalidad.Location = New System.Drawing.Point(6, 173)
        labelNacionalidad.Name = "labelNacionalidad"
        labelNacionalidad.Size = New System.Drawing.Size(72, 13)
        labelNacionalidad.TabIndex = 15
        labelNacionalidad.Text = "Nacionalidad:"
        '
        'labelProfesion
        '
        labelProfesion.AutoSize = True
        labelProfesion.Location = New System.Drawing.Point(6, 147)
        labelProfesion.Name = "labelProfesion"
        labelProfesion.Size = New System.Drawing.Size(54, 13)
        labelProfesion.TabIndex = 13
        labelProfesion.Text = "Profesión:"
        '
        'labelCuartel
        '
        labelCuartel.AutoSize = True
        labelCuartel.Location = New System.Drawing.Point(6, 199)
        labelCuartel.Name = "labelCuartel"
        labelCuartel.Size = New System.Drawing.Size(43, 13)
        labelCuartel.TabIndex = 17
        labelCuartel.Text = "Cuartel:"
        '
        'labelTelefonoParticular
        '
        labelTelefonoParticular.AutoSize = True
        labelTelefonoParticular.Location = New System.Drawing.Point(6, 169)
        labelTelefonoParticular.Name = "labelTelefonoParticular"
        labelTelefonoParticular.Size = New System.Drawing.Size(52, 13)
        labelTelefonoParticular.TabIndex = 18
        labelTelefonoParticular.Text = "Teléfono:"
        '
        'labelCelularParticular
        '
        labelCelularParticular.AutoSize = True
        labelCelularParticular.Location = New System.Drawing.Point(6, 195)
        labelCelularParticular.Name = "labelCelularParticular"
        labelCelularParticular.Size = New System.Drawing.Size(42, 13)
        labelCelularParticular.TabIndex = 20
        labelCelularParticular.Text = "Celular:"
        '
        'labelEmailParticular
        '
        labelEmailParticular.AutoSize = True
        labelEmailParticular.Location = New System.Drawing.Point(6, 221)
        labelEmailParticular.Name = "labelEmailParticular"
        labelEmailParticular.Size = New System.Drawing.Size(38, 13)
        labelEmailParticular.TabIndex = 22
        labelEmailParticular.Text = "E-mail:"
        '
        'labelDomicilioParticularCalle3
        '
        labelDomicilioParticularCalle3.AutoSize = True
        labelDomicilioParticularCalle3.Location = New System.Drawing.Point(266, 65)
        labelDomicilioParticularCalle3.Name = "labelDomicilioParticularCalle3"
        labelDomicilioParticularCalle3.Size = New System.Drawing.Size(42, 13)
        labelDomicilioParticularCalle3.TabIndex = 10
        labelDomicilioParticularCalle3.Text = "Calle 3:"
        '
        'labelDomicilioParticularCalle2
        '
        labelDomicilioParticularCalle2.AutoSize = True
        labelDomicilioParticularCalle2.Location = New System.Drawing.Point(6, 65)
        labelDomicilioParticularCalle2.Name = "labelDomicilioParticularCalle2"
        labelDomicilioParticularCalle2.Size = New System.Drawing.Size(42, 13)
        labelDomicilioParticularCalle2.TabIndex = 8
        labelDomicilioParticularCalle2.Text = "Calle 2:"
        '
        'labelDomicilioParticularCalle1
        '
        labelDomicilioParticularCalle1.AutoSize = True
        labelDomicilioParticularCalle1.Location = New System.Drawing.Point(6, 13)
        labelDomicilioParticularCalle1.Name = "labelDomicilioParticularCalle1"
        labelDomicilioParticularCalle1.Size = New System.Drawing.Size(33, 13)
        labelDomicilioParticularCalle1.TabIndex = 0
        labelDomicilioParticularCalle1.Text = "Calle:"
        '
        'labelDomicilioParticularCodigoPostal
        '
        labelDomicilioParticularCodigoPostal.AutoSize = True
        labelDomicilioParticularCodigoPostal.Location = New System.Drawing.Point(384, 118)
        labelDomicilioParticularCodigoPostal.Name = "labelDomicilioParticularCodigoPostal"
        labelDomicilioParticularCodigoPostal.Size = New System.Drawing.Size(59, 13)
        labelDomicilioParticularCodigoPostal.TabIndex = 16
        labelDomicilioParticularCodigoPostal.Text = "Cód. Post.:"
        '
        'labelDomicilioParticularDepartamento
        '
        labelDomicilioParticularDepartamento.AutoSize = True
        labelDomicilioParticularDepartamento.Location = New System.Drawing.Point(220, 39)
        labelDomicilioParticularDepartamento.Name = "labelDomicilioParticularDepartamento"
        labelDomicilioParticularDepartamento.Size = New System.Drawing.Size(54, 13)
        labelDomicilioParticularDepartamento.TabIndex = 6
        labelDomicilioParticularDepartamento.Text = "Dto/Ofic.:"
        '
        'labelDomicilioParticularLocalidad
        '
        labelDomicilioParticularLocalidad.AutoSize = True
        labelDomicilioParticularLocalidad.Location = New System.Drawing.Point(6, 118)
        labelDomicilioParticularLocalidad.Name = "labelDomicilioParticularLocalidad"
        labelDomicilioParticularLocalidad.Size = New System.Drawing.Size(56, 13)
        labelDomicilioParticularLocalidad.TabIndex = 14
        labelDomicilioParticularLocalidad.Text = "Localidad:"
        '
        'labelDomicilioParticularProvincia
        '
        labelDomicilioParticularProvincia.AutoSize = True
        labelDomicilioParticularProvincia.Location = New System.Drawing.Point(6, 91)
        labelDomicilioParticularProvincia.Name = "labelDomicilioParticularProvincia"
        labelDomicilioParticularProvincia.Size = New System.Drawing.Size(54, 13)
        labelDomicilioParticularProvincia.TabIndex = 12
        labelDomicilioParticularProvincia.Text = "Provincia:"
        '
        'labelDomicilioParticularNumero
        '
        labelDomicilioParticularNumero.AutoSize = True
        labelDomicilioParticularNumero.Location = New System.Drawing.Point(6, 39)
        labelDomicilioParticularNumero.Name = "labelDomicilioParticularNumero"
        labelDomicilioParticularNumero.Size = New System.Drawing.Size(47, 13)
        labelDomicilioParticularNumero.TabIndex = 2
        labelDomicilioParticularNumero.Text = "Número:"
        '
        'labelDomicilioParticularPiso
        '
        labelDomicilioParticularPiso.AutoSize = True
        labelDomicilioParticularPiso.Location = New System.Drawing.Point(128, 39)
        labelDomicilioParticularPiso.Name = "labelDomicilioParticularPiso"
        labelDomicilioParticularPiso.Size = New System.Drawing.Size(30, 13)
        labelDomicilioParticularPiso.TabIndex = 4
        labelDomicilioParticularPiso.Text = "Piso:"
        '
        'labelTelefonoLaboral
        '
        labelTelefonoLaboral.AutoSize = True
        labelTelefonoLaboral.Location = New System.Drawing.Point(6, 169)
        labelTelefonoLaboral.Name = "labelTelefonoLaboral"
        labelTelefonoLaboral.Size = New System.Drawing.Size(52, 13)
        labelTelefonoLaboral.TabIndex = 18
        labelTelefonoLaboral.Text = "Teléfono:"
        '
        'labelCelularLaboral
        '
        labelCelularLaboral.AutoSize = True
        labelCelularLaboral.Location = New System.Drawing.Point(6, 195)
        labelCelularLaboral.Name = "labelCelularLaboral"
        labelCelularLaboral.Size = New System.Drawing.Size(42, 13)
        labelCelularLaboral.TabIndex = 20
        labelCelularLaboral.Text = "Celular:"
        '
        'labelEmailLaboral
        '
        labelEmailLaboral.AutoSize = True
        labelEmailLaboral.Location = New System.Drawing.Point(6, 221)
        labelEmailLaboral.Name = "labelEmailLaboral"
        labelEmailLaboral.Size = New System.Drawing.Size(38, 13)
        labelEmailLaboral.TabIndex = 22
        labelEmailLaboral.Text = "E-mail:"
        '
        'labelDomicilioLaboralCalle3
        '
        labelDomicilioLaboralCalle3.AutoSize = True
        labelDomicilioLaboralCalle3.Location = New System.Drawing.Point(266, 65)
        labelDomicilioLaboralCalle3.Name = "labelDomicilioLaboralCalle3"
        labelDomicilioLaboralCalle3.Size = New System.Drawing.Size(42, 13)
        labelDomicilioLaboralCalle3.TabIndex = 10
        labelDomicilioLaboralCalle3.Text = "Calle 3:"
        '
        'labelDomicilioLaboralCalle2
        '
        labelDomicilioLaboralCalle2.AutoSize = True
        labelDomicilioLaboralCalle2.Location = New System.Drawing.Point(6, 65)
        labelDomicilioLaboralCalle2.Name = "labelDomicilioLaboralCalle2"
        labelDomicilioLaboralCalle2.Size = New System.Drawing.Size(42, 13)
        labelDomicilioLaboralCalle2.TabIndex = 8
        labelDomicilioLaboralCalle2.Text = "Calle 2:"
        '
        'labelDomicilioLaboralCalle1
        '
        labelDomicilioLaboralCalle1.AutoSize = True
        labelDomicilioLaboralCalle1.Location = New System.Drawing.Point(6, 13)
        labelDomicilioLaboralCalle1.Name = "labelDomicilioLaboralCalle1"
        labelDomicilioLaboralCalle1.Size = New System.Drawing.Size(33, 13)
        labelDomicilioLaboralCalle1.TabIndex = 0
        labelDomicilioLaboralCalle1.Text = "Calle:"
        '
        'labelDomicilioLaboralCodigoPostal
        '
        labelDomicilioLaboralCodigoPostal.AutoSize = True
        labelDomicilioLaboralCodigoPostal.Location = New System.Drawing.Point(384, 118)
        labelDomicilioLaboralCodigoPostal.Name = "labelDomicilioLaboralCodigoPostal"
        labelDomicilioLaboralCodigoPostal.Size = New System.Drawing.Size(59, 13)
        labelDomicilioLaboralCodigoPostal.TabIndex = 16
        labelDomicilioLaboralCodigoPostal.Text = "Cód. Post.:"
        '
        'labelDomicilioLaboralDepartamento
        '
        labelDomicilioLaboralDepartamento.AutoSize = True
        labelDomicilioLaboralDepartamento.Location = New System.Drawing.Point(220, 39)
        labelDomicilioLaboralDepartamento.Name = "labelDomicilioLaboralDepartamento"
        labelDomicilioLaboralDepartamento.Size = New System.Drawing.Size(54, 13)
        labelDomicilioLaboralDepartamento.TabIndex = 6
        labelDomicilioLaboralDepartamento.Text = "Dto/Ofic.:"
        '
        'labelDomicilioLaboralLocalidad
        '
        labelDomicilioLaboralLocalidad.AutoSize = True
        labelDomicilioLaboralLocalidad.Location = New System.Drawing.Point(6, 118)
        labelDomicilioLaboralLocalidad.Name = "labelDomicilioLaboralLocalidad"
        labelDomicilioLaboralLocalidad.Size = New System.Drawing.Size(56, 13)
        labelDomicilioLaboralLocalidad.TabIndex = 14
        labelDomicilioLaboralLocalidad.Text = "Localidad:"
        '
        'labelDomicilioLaboralProvincia
        '
        labelDomicilioLaboralProvincia.AutoSize = True
        labelDomicilioLaboralProvincia.Location = New System.Drawing.Point(6, 91)
        labelDomicilioLaboralProvincia.Name = "labelDomicilioLaboralProvincia"
        labelDomicilioLaboralProvincia.Size = New System.Drawing.Size(54, 13)
        labelDomicilioLaboralProvincia.TabIndex = 12
        labelDomicilioLaboralProvincia.Text = "Provincia:"
        '
        'labelDomicilioLaboralNumero
        '
        labelDomicilioLaboralNumero.AutoSize = True
        labelDomicilioLaboralNumero.Location = New System.Drawing.Point(6, 39)
        labelDomicilioLaboralNumero.Name = "labelDomicilioLaboralNumero"
        labelDomicilioLaboralNumero.Size = New System.Drawing.Size(47, 13)
        labelDomicilioLaboralNumero.TabIndex = 2
        labelDomicilioLaboralNumero.Text = "Número:"
        '
        'labelDomicilioLaboralPiso
        '
        labelDomicilioLaboralPiso.AutoSize = True
        labelDomicilioLaboralPiso.Location = New System.Drawing.Point(128, 39)
        labelDomicilioLaboralPiso.Name = "labelDomicilioLaboralPiso"
        labelDomicilioLaboralPiso.Size = New System.Drawing.Size(30, 13)
        labelDomicilioLaboralPiso.TabIndex = 4
        labelDomicilioLaboralPiso.Text = "Piso:"
        '
        'labelEsActivo
        '
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(6, 172)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 2
        labelEsActivo.Text = "Activo:"
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
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 220)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 7
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 198)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 4
        labelCreacion.Text = "Creación:"
        '
        'labelIDPersona
        '
        Me.labelIDPersona.AutoSize = True
        Me.labelIDPersona.Location = New System.Drawing.Point(73, 52)
        Me.labelIDPersona.Name = "labelIDPersona"
        Me.labelIDPersona.Size = New System.Drawing.Size(79, 13)
        Me.labelIDPersona.TabIndex = 1
        Me.labelIDPersona.Text = "N° de Persona:"
        '
        'textboxApellido
        '
        Me.textboxApellido.Location = New System.Drawing.Point(155, 77)
        Me.textboxApellido.MaxLength = 50
        Me.textboxApellido.Name = "textboxApellido"
        Me.textboxApellido.Size = New System.Drawing.Size(239, 20)
        Me.textboxApellido.TabIndex = 6
        '
        'textboxIDPersona
        '
        Me.textboxIDPersona.Location = New System.Drawing.Point(155, 49)
        Me.textboxIDPersona.MaxLength = 10
        Me.textboxIDPersona.Name = "textboxIDPersona"
        Me.textboxIDPersona.ReadOnly = True
        Me.textboxIDPersona.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDPersona.TabIndex = 2
        Me.textboxIDPersona.TabStop = False
        Me.textboxIDPersona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(155, 103)
        Me.textboxNombre.MaxLength = 50
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(239, 20)
        Me.textboxNombre.TabIndex = 8
        '
        'pictureboxMain
        '
        Me.pictureboxMain.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ENTIDAD_48
        Me.pictureboxMain.Location = New System.Drawing.Point(12, 49)
        Me.pictureboxMain.Name = "pictureboxMain"
        Me.pictureboxMain.Size = New System.Drawing.Size(48, 48)
        Me.pictureboxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureboxMain.TabIndex = 93
        Me.pictureboxMain.TabStop = False
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(539, 39)
        Me.toolstripMain.TabIndex = 0
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
        'textboxMatriculaNumero
        '
        Me.textboxMatriculaNumero.Location = New System.Drawing.Point(328, 49)
        Me.textboxMatriculaNumero.MaxLength = 5
        Me.textboxMatriculaNumero.Name = "textboxMatriculaNumero"
        Me.textboxMatriculaNumero.Size = New System.Drawing.Size(66, 20)
        Me.textboxMatriculaNumero.TabIndex = 4
        Me.tooltipMain.SetToolTip(Me.textboxMatriculaNumero, "Ingrese el Número de Documento sin utilizar puntos.")
        '
        'textboxDocumentoNumero
        '
        Me.textboxDocumentoNumero.Location = New System.Drawing.Point(250, 10)
        Me.textboxDocumentoNumero.MaxLength = 11
        Me.textboxDocumentoNumero.Name = "textboxDocumentoNumero"
        Me.textboxDocumentoNumero.Size = New System.Drawing.Size(115, 20)
        Me.textboxDocumentoNumero.TabIndex = 2
        Me.tooltipMain.SetToolTip(Me.textboxDocumentoNumero, "Ingrese el Número de Documento sin utilizar puntos.")
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageParticular)
        Me.tabcontrolMain.Controls.Add(Me.tabpageLaboral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageFamiliares)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 138)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(514, 285)
        Me.tabcontrolMain.TabIndex = 9
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.comboboxNivelEstudio)
        Me.tabpageGeneral.Controls.Add(labelNivelEstudio)
        Me.tabpageGeneral.Controls.Add(Me.comboboxFactorRH)
        Me.tabpageGeneral.Controls.Add(labelFactorRH)
        Me.tabpageGeneral.Controls.Add(Me.comboboxGrupoSanguineo)
        Me.tabpageGeneral.Controls.Add(labelGrupoSanguineo)
        Me.tabpageGeneral.Controls.Add(Me.comboboxEstado)
        Me.tabpageGeneral.Controls.Add(labelEstado)
        Me.tabpageGeneral.Controls.Add(labelFechaNacimiento)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFechaNacimiento)
        Me.tabpageGeneral.Controls.Add(Me.comboboxGenero)
        Me.tabpageGeneral.Controls.Add(labelGenero)
        Me.tabpageGeneral.Controls.Add(Me.comboboxDocumentoTipo)
        Me.tabpageGeneral.Controls.Add(Me.textboxDocumentoNumero)
        Me.tabpageGeneral.Controls.Add(labelDocumento)
        Me.tabpageGeneral.Controls.Add(Me.maskedtextboxDocumentoNumero)
        Me.tabpageGeneral.Controls.Add(labelNacionalidad)
        Me.tabpageGeneral.Controls.Add(Me.textboxNacionalidad)
        Me.tabpageGeneral.Controls.Add(labelProfesion)
        Me.tabpageGeneral.Controls.Add(Me.textboxProfesion)
        Me.tabpageGeneral.Controls.Add(labelCuartel)
        Me.tabpageGeneral.Controls.Add(Me.comboboxCuartel)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(506, 256)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'comboboxEstado
        '
        Me.comboboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxEstado.FormattingEnabled = True
        Me.comboboxEstado.Location = New System.Drawing.Point(142, 223)
        Me.comboboxEstado.Name = "comboboxEstado"
        Me.comboboxEstado.Size = New System.Drawing.Size(102, 21)
        Me.comboboxEstado.TabIndex = 20
        '
        'datetimepickerFechaNacimiento
        '
        Me.datetimepickerFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaNacimiento.Location = New System.Drawing.Point(142, 37)
        Me.datetimepickerFechaNacimiento.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaNacimiento.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaNacimiento.Name = "datetimepickerFechaNacimiento"
        Me.datetimepickerFechaNacimiento.ShowCheckBox = True
        Me.datetimepickerFechaNacimiento.Size = New System.Drawing.Size(148, 20)
        Me.datetimepickerFechaNacimiento.TabIndex = 4
        '
        'comboboxGenero
        '
        Me.comboboxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxGenero.FormattingEnabled = True
        Me.comboboxGenero.Location = New System.Drawing.Point(142, 63)
        Me.comboboxGenero.Name = "comboboxGenero"
        Me.comboboxGenero.Size = New System.Drawing.Size(102, 21)
        Me.comboboxGenero.TabIndex = 6
        '
        'comboboxDocumentoTipo
        '
        Me.comboboxDocumentoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDocumentoTipo.FormattingEnabled = True
        Me.comboboxDocumentoTipo.Location = New System.Drawing.Point(142, 10)
        Me.comboboxDocumentoTipo.Name = "comboboxDocumentoTipo"
        Me.comboboxDocumentoTipo.Size = New System.Drawing.Size(102, 21)
        Me.comboboxDocumentoTipo.TabIndex = 1
        '
        'maskedtextboxDocumentoNumero
        '
        Me.maskedtextboxDocumentoNumero.AllowPromptAsInput = False
        Me.maskedtextboxDocumentoNumero.AsciiOnly = True
        Me.maskedtextboxDocumentoNumero.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxDocumentoNumero.HidePromptOnLeave = True
        Me.maskedtextboxDocumentoNumero.Location = New System.Drawing.Point(250, 10)
        Me.maskedtextboxDocumentoNumero.Mask = "00-00000000-0"
        Me.maskedtextboxDocumentoNumero.Name = "maskedtextboxDocumentoNumero"
        Me.maskedtextboxDocumentoNumero.Size = New System.Drawing.Size(115, 20)
        Me.maskedtextboxDocumentoNumero.TabIndex = 3
        Me.maskedtextboxDocumentoNumero.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'textboxNacionalidad
        '
        Me.textboxNacionalidad.Location = New System.Drawing.Point(142, 170)
        Me.textboxNacionalidad.MaxLength = 100
        Me.textboxNacionalidad.Name = "textboxNacionalidad"
        Me.textboxNacionalidad.Size = New System.Drawing.Size(358, 20)
        Me.textboxNacionalidad.TabIndex = 16
        '
        'textboxProfesion
        '
        Me.textboxProfesion.Location = New System.Drawing.Point(142, 144)
        Me.textboxProfesion.MaxLength = 100
        Me.textboxProfesion.Name = "textboxProfesion"
        Me.textboxProfesion.Size = New System.Drawing.Size(358, 20)
        Me.textboxProfesion.TabIndex = 14
        '
        'comboboxCuartel
        '
        Me.comboboxCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCuartel.FormattingEnabled = True
        Me.comboboxCuartel.Location = New System.Drawing.Point(142, 196)
        Me.comboboxCuartel.Name = "comboboxCuartel"
        Me.comboboxCuartel.Size = New System.Drawing.Size(358, 21)
        Me.comboboxCuartel.TabIndex = 21
        '
        'tabpageParticular
        '
        Me.tabpageParticular.Controls.Add(labelTelefonoParticular)
        Me.tabpageParticular.Controls.Add(Me.textboxTelefonoParticular)
        Me.tabpageParticular.Controls.Add(labelCelularParticular)
        Me.tabpageParticular.Controls.Add(Me.textboxCelularParticular)
        Me.tabpageParticular.Controls.Add(labelEmailParticular)
        Me.tabpageParticular.Controls.Add(Me.textboxEmailParticular)
        Me.tabpageParticular.Controls.Add(labelDomicilioParticularCalle3)
        Me.tabpageParticular.Controls.Add(labelDomicilioParticularCalle2)
        Me.tabpageParticular.Controls.Add(Me.textboxDomicilioParticularCalle3)
        Me.tabpageParticular.Controls.Add(Me.textboxDomicilioParticularCalle2)
        Me.tabpageParticular.Controls.Add(Me.comboboxDomicilioParticularLocalidad)
        Me.tabpageParticular.Controls.Add(Me.comboboxDomicilioParticularProvincia)
        Me.tabpageParticular.Controls.Add(labelDomicilioParticularCalle1)
        Me.tabpageParticular.Controls.Add(Me.textboxDomicilioParticularCalle1)
        Me.tabpageParticular.Controls.Add(labelDomicilioParticularCodigoPostal)
        Me.tabpageParticular.Controls.Add(Me.textboxDomicilioParticularCodigoPostal)
        Me.tabpageParticular.Controls.Add(labelDomicilioParticularDepartamento)
        Me.tabpageParticular.Controls.Add(Me.textboxDomicilioParticularDepartamento)
        Me.tabpageParticular.Controls.Add(labelDomicilioParticularLocalidad)
        Me.tabpageParticular.Controls.Add(labelDomicilioParticularProvincia)
        Me.tabpageParticular.Controls.Add(labelDomicilioParticularNumero)
        Me.tabpageParticular.Controls.Add(Me.textboxDomicilioParticularNumero)
        Me.tabpageParticular.Controls.Add(labelDomicilioParticularPiso)
        Me.tabpageParticular.Controls.Add(Me.textboxDomicilioParticularPiso)
        Me.tabpageParticular.Location = New System.Drawing.Point(4, 25)
        Me.tabpageParticular.Name = "tabpageParticular"
        Me.tabpageParticular.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageParticular.Size = New System.Drawing.Size(506, 248)
        Me.tabpageParticular.TabIndex = 1
        Me.tabpageParticular.Text = "Contacto Particular"
        Me.tabpageParticular.UseVisualStyleBackColor = True
        '
        'textboxTelefonoParticular
        '
        Me.textboxTelefonoParticular.Location = New System.Drawing.Point(72, 166)
        Me.textboxTelefonoParticular.MaxLength = 50
        Me.textboxTelefonoParticular.Name = "textboxTelefonoParticular"
        Me.textboxTelefonoParticular.Size = New System.Drawing.Size(170, 20)
        Me.textboxTelefonoParticular.TabIndex = 19
        '
        'textboxCelularParticular
        '
        Me.textboxCelularParticular.Location = New System.Drawing.Point(72, 192)
        Me.textboxCelularParticular.MaxLength = 50
        Me.textboxCelularParticular.Name = "textboxCelularParticular"
        Me.textboxCelularParticular.Size = New System.Drawing.Size(170, 20)
        Me.textboxCelularParticular.TabIndex = 21
        '
        'textboxEmailParticular
        '
        Me.textboxEmailParticular.Location = New System.Drawing.Point(72, 218)
        Me.textboxEmailParticular.MaxLength = 50
        Me.textboxEmailParticular.Name = "textboxEmailParticular"
        Me.textboxEmailParticular.Size = New System.Drawing.Size(306, 20)
        Me.textboxEmailParticular.TabIndex = 23
        '
        'textboxDomicilioParticularCalle3
        '
        Me.textboxDomicilioParticularCalle3.Location = New System.Drawing.Point(330, 62)
        Me.textboxDomicilioParticularCalle3.MaxLength = 50
        Me.textboxDomicilioParticularCalle3.Name = "textboxDomicilioParticularCalle3"
        Me.textboxDomicilioParticularCalle3.Size = New System.Drawing.Size(170, 20)
        Me.textboxDomicilioParticularCalle3.TabIndex = 11
        '
        'textboxDomicilioParticularCalle2
        '
        Me.textboxDomicilioParticularCalle2.Location = New System.Drawing.Point(72, 62)
        Me.textboxDomicilioParticularCalle2.MaxLength = 50
        Me.textboxDomicilioParticularCalle2.Name = "textboxDomicilioParticularCalle2"
        Me.textboxDomicilioParticularCalle2.Size = New System.Drawing.Size(170, 20)
        Me.textboxDomicilioParticularCalle2.TabIndex = 9
        '
        'comboboxDomicilioParticularLocalidad
        '
        Me.comboboxDomicilioParticularLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDomicilioParticularLocalidad.FormattingEnabled = True
        Me.comboboxDomicilioParticularLocalidad.Location = New System.Drawing.Point(72, 115)
        Me.comboboxDomicilioParticularLocalidad.Name = "comboboxDomicilioParticularLocalidad"
        Me.comboboxDomicilioParticularLocalidad.Size = New System.Drawing.Size(258, 21)
        Me.comboboxDomicilioParticularLocalidad.TabIndex = 15
        '
        'comboboxDomicilioParticularProvincia
        '
        Me.comboboxDomicilioParticularProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDomicilioParticularProvincia.FormattingEnabled = True
        Me.comboboxDomicilioParticularProvincia.Location = New System.Drawing.Point(72, 88)
        Me.comboboxDomicilioParticularProvincia.Name = "comboboxDomicilioParticularProvincia"
        Me.comboboxDomicilioParticularProvincia.Size = New System.Drawing.Size(258, 21)
        Me.comboboxDomicilioParticularProvincia.TabIndex = 13
        '
        'textboxDomicilioParticularCalle1
        '
        Me.textboxDomicilioParticularCalle1.Location = New System.Drawing.Point(72, 10)
        Me.textboxDomicilioParticularCalle1.MaxLength = 100
        Me.textboxDomicilioParticularCalle1.Name = "textboxDomicilioParticularCalle1"
        Me.textboxDomicilioParticularCalle1.Size = New System.Drawing.Size(258, 20)
        Me.textboxDomicilioParticularCalle1.TabIndex = 1
        '
        'textboxDomicilioParticularCodigoPostal
        '
        Me.textboxDomicilioParticularCodigoPostal.Location = New System.Drawing.Point(450, 115)
        Me.textboxDomicilioParticularCodigoPostal.MaxLength = 8
        Me.textboxDomicilioParticularCodigoPostal.Name = "textboxDomicilioParticularCodigoPostal"
        Me.textboxDomicilioParticularCodigoPostal.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioParticularCodigoPostal.TabIndex = 17
        '
        'textboxDomicilioParticularDepartamento
        '
        Me.textboxDomicilioParticularDepartamento.Location = New System.Drawing.Point(280, 36)
        Me.textboxDomicilioParticularDepartamento.MaxLength = 10
        Me.textboxDomicilioParticularDepartamento.Name = "textboxDomicilioParticularDepartamento"
        Me.textboxDomicilioParticularDepartamento.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioParticularDepartamento.TabIndex = 7
        '
        'textboxDomicilioParticularNumero
        '
        Me.textboxDomicilioParticularNumero.Location = New System.Drawing.Point(72, 36)
        Me.textboxDomicilioParticularNumero.MaxLength = 10
        Me.textboxDomicilioParticularNumero.Name = "textboxDomicilioParticularNumero"
        Me.textboxDomicilioParticularNumero.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioParticularNumero.TabIndex = 3
        '
        'textboxDomicilioParticularPiso
        '
        Me.textboxDomicilioParticularPiso.Location = New System.Drawing.Point(164, 36)
        Me.textboxDomicilioParticularPiso.MaxLength = 10
        Me.textboxDomicilioParticularPiso.Name = "textboxDomicilioParticularPiso"
        Me.textboxDomicilioParticularPiso.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioParticularPiso.TabIndex = 5
        '
        'tabpageLaboral
        '
        Me.tabpageLaboral.Controls.Add(labelTelefonoLaboral)
        Me.tabpageLaboral.Controls.Add(Me.textboxTelefonoLaboral)
        Me.tabpageLaboral.Controls.Add(labelCelularLaboral)
        Me.tabpageLaboral.Controls.Add(Me.textboxCelularLaboral)
        Me.tabpageLaboral.Controls.Add(labelEmailLaboral)
        Me.tabpageLaboral.Controls.Add(Me.textboxEmailLaboral)
        Me.tabpageLaboral.Controls.Add(labelDomicilioLaboralCalle3)
        Me.tabpageLaboral.Controls.Add(labelDomicilioLaboralCalle2)
        Me.tabpageLaboral.Controls.Add(Me.textboxDomicilioLaboralCalle3)
        Me.tabpageLaboral.Controls.Add(Me.textboxDomicilioLaboralCalle2)
        Me.tabpageLaboral.Controls.Add(Me.comboboxDomicilioLaboralLocalidad)
        Me.tabpageLaboral.Controls.Add(Me.comboboxDomicilioLaboralProvincia)
        Me.tabpageLaboral.Controls.Add(labelDomicilioLaboralCalle1)
        Me.tabpageLaboral.Controls.Add(Me.textboxDomicilioLaboralCalle1)
        Me.tabpageLaboral.Controls.Add(labelDomicilioLaboralCodigoPostal)
        Me.tabpageLaboral.Controls.Add(Me.textboxDomicilioLaboralCodigoPostal)
        Me.tabpageLaboral.Controls.Add(labelDomicilioLaboralDepartamento)
        Me.tabpageLaboral.Controls.Add(Me.textboxDomicilioLaboralDepartamento)
        Me.tabpageLaboral.Controls.Add(labelDomicilioLaboralLocalidad)
        Me.tabpageLaboral.Controls.Add(labelDomicilioLaboralProvincia)
        Me.tabpageLaboral.Controls.Add(labelDomicilioLaboralNumero)
        Me.tabpageLaboral.Controls.Add(Me.textboxDomicilioLaboralNumero)
        Me.tabpageLaboral.Controls.Add(labelDomicilioLaboralPiso)
        Me.tabpageLaboral.Controls.Add(Me.textboxDomicilioLaboralPiso)
        Me.tabpageLaboral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageLaboral.Name = "tabpageLaboral"
        Me.tabpageLaboral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageLaboral.Size = New System.Drawing.Size(506, 248)
        Me.tabpageLaboral.TabIndex = 9
        Me.tabpageLaboral.Text = "Contacto Laboral"
        Me.tabpageLaboral.UseVisualStyleBackColor = True
        '
        'textboxTelefonoLaboral
        '
        Me.textboxTelefonoLaboral.Location = New System.Drawing.Point(72, 166)
        Me.textboxTelefonoLaboral.MaxLength = 50
        Me.textboxTelefonoLaboral.Name = "textboxTelefonoLaboral"
        Me.textboxTelefonoLaboral.Size = New System.Drawing.Size(170, 20)
        Me.textboxTelefonoLaboral.TabIndex = 19
        '
        'textboxCelularLaboral
        '
        Me.textboxCelularLaboral.Location = New System.Drawing.Point(72, 192)
        Me.textboxCelularLaboral.MaxLength = 50
        Me.textboxCelularLaboral.Name = "textboxCelularLaboral"
        Me.textboxCelularLaboral.Size = New System.Drawing.Size(170, 20)
        Me.textboxCelularLaboral.TabIndex = 21
        '
        'textboxEmailLaboral
        '
        Me.textboxEmailLaboral.Location = New System.Drawing.Point(72, 218)
        Me.textboxEmailLaboral.MaxLength = 50
        Me.textboxEmailLaboral.Name = "textboxEmailLaboral"
        Me.textboxEmailLaboral.Size = New System.Drawing.Size(306, 20)
        Me.textboxEmailLaboral.TabIndex = 23
        '
        'textboxDomicilioLaboralCalle3
        '
        Me.textboxDomicilioLaboralCalle3.Location = New System.Drawing.Point(330, 62)
        Me.textboxDomicilioLaboralCalle3.MaxLength = 50
        Me.textboxDomicilioLaboralCalle3.Name = "textboxDomicilioLaboralCalle3"
        Me.textboxDomicilioLaboralCalle3.Size = New System.Drawing.Size(170, 20)
        Me.textboxDomicilioLaboralCalle3.TabIndex = 11
        '
        'textboxDomicilioLaboralCalle2
        '
        Me.textboxDomicilioLaboralCalle2.Location = New System.Drawing.Point(72, 62)
        Me.textboxDomicilioLaboralCalle2.MaxLength = 50
        Me.textboxDomicilioLaboralCalle2.Name = "textboxDomicilioLaboralCalle2"
        Me.textboxDomicilioLaboralCalle2.Size = New System.Drawing.Size(170, 20)
        Me.textboxDomicilioLaboralCalle2.TabIndex = 9
        '
        'comboboxDomicilioLaboralLocalidad
        '
        Me.comboboxDomicilioLaboralLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDomicilioLaboralLocalidad.FormattingEnabled = True
        Me.comboboxDomicilioLaboralLocalidad.Location = New System.Drawing.Point(72, 115)
        Me.comboboxDomicilioLaboralLocalidad.Name = "comboboxDomicilioLaboralLocalidad"
        Me.comboboxDomicilioLaboralLocalidad.Size = New System.Drawing.Size(258, 21)
        Me.comboboxDomicilioLaboralLocalidad.TabIndex = 15
        '
        'comboboxDomicilioLaboralProvincia
        '
        Me.comboboxDomicilioLaboralProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDomicilioLaboralProvincia.FormattingEnabled = True
        Me.comboboxDomicilioLaboralProvincia.Location = New System.Drawing.Point(72, 88)
        Me.comboboxDomicilioLaboralProvincia.Name = "comboboxDomicilioLaboralProvincia"
        Me.comboboxDomicilioLaboralProvincia.Size = New System.Drawing.Size(258, 21)
        Me.comboboxDomicilioLaboralProvincia.TabIndex = 13
        '
        'textboxDomicilioLaboralCalle1
        '
        Me.textboxDomicilioLaboralCalle1.Location = New System.Drawing.Point(72, 10)
        Me.textboxDomicilioLaboralCalle1.MaxLength = 100
        Me.textboxDomicilioLaboralCalle1.Name = "textboxDomicilioLaboralCalle1"
        Me.textboxDomicilioLaboralCalle1.Size = New System.Drawing.Size(258, 20)
        Me.textboxDomicilioLaboralCalle1.TabIndex = 1
        '
        'textboxDomicilioLaboralCodigoPostal
        '
        Me.textboxDomicilioLaboralCodigoPostal.Location = New System.Drawing.Point(450, 115)
        Me.textboxDomicilioLaboralCodigoPostal.MaxLength = 8
        Me.textboxDomicilioLaboralCodigoPostal.Name = "textboxDomicilioLaboralCodigoPostal"
        Me.textboxDomicilioLaboralCodigoPostal.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioLaboralCodigoPostal.TabIndex = 17
        '
        'textboxDomicilioLaboralDepartamento
        '
        Me.textboxDomicilioLaboralDepartamento.Location = New System.Drawing.Point(280, 36)
        Me.textboxDomicilioLaboralDepartamento.MaxLength = 10
        Me.textboxDomicilioLaboralDepartamento.Name = "textboxDomicilioLaboralDepartamento"
        Me.textboxDomicilioLaboralDepartamento.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioLaboralDepartamento.TabIndex = 7
        '
        'textboxDomicilioLaboralNumero
        '
        Me.textboxDomicilioLaboralNumero.Location = New System.Drawing.Point(72, 36)
        Me.textboxDomicilioLaboralNumero.MaxLength = 10
        Me.textboxDomicilioLaboralNumero.Name = "textboxDomicilioLaboralNumero"
        Me.textboxDomicilioLaboralNumero.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioLaboralNumero.TabIndex = 3
        '
        'textboxDomicilioLaboralPiso
        '
        Me.textboxDomicilioLaboralPiso.Location = New System.Drawing.Point(164, 36)
        Me.textboxDomicilioLaboralPiso.MaxLength = 10
        Me.textboxDomicilioLaboralPiso.Name = "textboxDomicilioLaboralPiso"
        Me.textboxDomicilioLaboralPiso.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioLaboralPiso.TabIndex = 5
        '
        'tabpageFamiliares
        '
        Me.tabpageFamiliares.Controls.Add(Me.datagridviewFamiliares)
        Me.tabpageFamiliares.Controls.Add(Me.toolstripFamiliares)
        Me.tabpageFamiliares.Location = New System.Drawing.Point(4, 25)
        Me.tabpageFamiliares.Name = "tabpageFamiliares"
        Me.tabpageFamiliares.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageFamiliares.Size = New System.Drawing.Size(506, 248)
        Me.tabpageFamiliares.TabIndex = 10
        Me.tabpageFamiliares.Text = "Familiares"
        Me.tabpageFamiliares.UseVisualStyleBackColor = True
        '
        'datagridviewFamiliares
        '
        Me.datagridviewFamiliares.AllowUserToAddRows = False
        Me.datagridviewFamiliares.AllowUserToDeleteRows = False
        Me.datagridviewFamiliares.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewFamiliares.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewFamiliares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewFamiliares.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnFamiliares_Parentesco, Me.columnFamiliares_Apellido, Me.columnFamiliares_Nombre})
        Me.datagridviewFamiliares.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewFamiliares.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewFamiliares.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewFamiliares.MultiSelect = False
        Me.datagridviewFamiliares.Name = "datagridviewFamiliares"
        Me.datagridviewFamiliares.ReadOnly = True
        Me.datagridviewFamiliares.RowHeadersVisible = False
        Me.datagridviewFamiliares.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewFamiliares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewFamiliares.Size = New System.Drawing.Size(413, 242)
        Me.datagridviewFamiliares.TabIndex = 6
        '
        'columnFamiliares_Parentesco
        '
        Me.columnFamiliares_Parentesco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnFamiliares_Parentesco.DataPropertyName = "Parentesco"
        Me.columnFamiliares_Parentesco.HeaderText = "Parentesco"
        Me.columnFamiliares_Parentesco.Name = "columnFamiliares_Parentesco"
        Me.columnFamiliares_Parentesco.ReadOnly = True
        Me.columnFamiliares_Parentesco.Width = 86
        '
        'columnFamiliares_Apellido
        '
        Me.columnFamiliares_Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnFamiliares_Apellido.DataPropertyName = "Apellido"
        Me.columnFamiliares_Apellido.HeaderText = "Appellidos"
        Me.columnFamiliares_Apellido.Name = "columnFamiliares_Apellido"
        Me.columnFamiliares_Apellido.ReadOnly = True
        Me.columnFamiliares_Apellido.Width = 80
        '
        'columnFamiliares_Nombre
        '
        Me.columnFamiliares_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnFamiliares_Nombre.DataPropertyName = "Nombre"
        Me.columnFamiliares_Nombre.HeaderText = "Nombres"
        Me.columnFamiliares_Nombre.Name = "columnFamiliares_Nombre"
        Me.columnFamiliares_Nombre.ReadOnly = True
        Me.columnFamiliares_Nombre.Width = 74
        '
        'toolstripFamiliares
        '
        Me.toolstripFamiliares.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripFamiliares.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripFamiliares.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonFamiliares_Agregar, Me.buttonFamiliares_Editar, Me.buttonFamiliares_Eliminar})
        Me.toolstripFamiliares.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripFamiliares.Location = New System.Drawing.Point(3, 3)
        Me.toolstripFamiliares.Name = "toolstripFamiliares"
        Me.toolstripFamiliares.Size = New System.Drawing.Size(87, 242)
        Me.toolstripFamiliares.TabIndex = 7
        '
        'buttonFamiliares_Agregar
        '
        Me.buttonFamiliares_Agregar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonFamiliares_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonFamiliares_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonFamiliares_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFamiliares_Agregar.Name = "buttonFamiliares_Agregar"
        Me.buttonFamiliares_Agregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonFamiliares_Agregar.Text = "Agregar"
        '
        'buttonFamiliares_Editar
        '
        Me.buttonFamiliares_Editar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonFamiliares_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonFamiliares_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonFamiliares_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFamiliares_Editar.Name = "buttonFamiliares_Editar"
        Me.buttonFamiliares_Editar.Size = New System.Drawing.Size(84, 36)
        Me.buttonFamiliares_Editar.Text = "Editar"
        '
        'buttonFamiliares_Eliminar
        '
        Me.buttonFamiliares_Eliminar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonFamiliares_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonFamiliares_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonFamiliares_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFamiliares_Eliminar.Name = "buttonFamiliares_Eliminar"
        Me.buttonFamiliares_Eliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonFamiliares_Eliminar.Text = "Eliminar"
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.checkboxEsActivo)
        Me.tabpageNotasAuditoria.Controls.Add(labelEsActivo)
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(506, 248)
        Me.tabpageNotasAuditoria.TabIndex = 7
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(114, 172)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 3
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(114, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.Size = New System.Drawing.Size(386, 155)
        Me.textboxNotas.TabIndex = 1
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 217)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 9
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 191)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 6
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 217)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 8
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 191)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 5
        '
        'comboboxGrupoSanguineo
        '
        Me.comboboxGrupoSanguineo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxGrupoSanguineo.FormattingEnabled = True
        Me.comboboxGrupoSanguineo.Location = New System.Drawing.Point(142, 90)
        Me.comboboxGrupoSanguineo.Name = "comboboxGrupoSanguineo"
        Me.comboboxGrupoSanguineo.Size = New System.Drawing.Size(102, 21)
        Me.comboboxGrupoSanguineo.TabIndex = 8
        '
        'labelGrupoSanguineo
        '
        labelGrupoSanguineo.AutoSize = True
        labelGrupoSanguineo.Location = New System.Drawing.Point(6, 93)
        labelGrupoSanguineo.Name = "labelGrupoSanguineo"
        labelGrupoSanguineo.Size = New System.Drawing.Size(93, 13)
        labelGrupoSanguineo.TabIndex = 7
        labelGrupoSanguineo.Text = "Grupo sanguíneo:"
        '
        'comboboxFactorRH
        '
        Me.comboboxFactorRH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxFactorRH.FormattingEnabled = True
        Me.comboboxFactorRH.Location = New System.Drawing.Point(315, 90)
        Me.comboboxFactorRH.Name = "comboboxFactorRH"
        Me.comboboxFactorRH.Size = New System.Drawing.Size(102, 21)
        Me.comboboxFactorRH.TabIndex = 10
        '
        'labelFactorRH
        '
        labelFactorRH.AutoSize = True
        labelFactorRH.Location = New System.Drawing.Point(250, 93)
        labelFactorRH.Name = "labelFactorRH"
        labelFactorRH.Size = New System.Drawing.Size(59, 13)
        labelFactorRH.TabIndex = 9
        labelFactorRH.Text = "Factor RH:"
        '
        'comboboxNivelEstudio
        '
        Me.comboboxNivelEstudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxNivelEstudio.FormattingEnabled = True
        Me.comboboxNivelEstudio.Location = New System.Drawing.Point(142, 117)
        Me.comboboxNivelEstudio.Name = "comboboxNivelEstudio"
        Me.comboboxNivelEstudio.Size = New System.Drawing.Size(275, 21)
        Me.comboboxNivelEstudio.TabIndex = 12
        '
        'labelNivelEstudio
        '
        labelNivelEstudio.AutoSize = True
        labelNivelEstudio.Location = New System.Drawing.Point(6, 120)
        labelNivelEstudio.Name = "labelNivelEstudio"
        labelNivelEstudio.Size = New System.Drawing.Size(91, 13)
        labelNivelEstudio.TabIndex = 11
        labelNivelEstudio.Text = "Nivel de estudios:"
        '
        'formPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 434)
        Me.Controls.Add(Me.toolstripMain)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.pictureboxMain)
        Me.Controls.Add(Me.labelIDPersona)
        Me.Controls.Add(Me.textboxIDPersona)
        Me.Controls.Add(labelApellido)
        Me.Controls.Add(Me.textboxApellido)
        Me.Controls.Add(labelNombre)
        Me.Controls.Add(Me.textboxNombre)
        Me.Controls.Add(labelMatriculaNumero)
        Me.Controls.Add(Me.textboxMatriculaNumero)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formPersona"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle de la Persona"
        CType(Me.pictureboxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        Me.tabpageParticular.ResumeLayout(False)
        Me.tabpageParticular.PerformLayout()
        Me.tabpageLaboral.ResumeLayout(False)
        Me.tabpageLaboral.PerformLayout()
        Me.tabpageFamiliares.ResumeLayout(False)
        Me.tabpageFamiliares.PerformLayout()
        CType(Me.datagridviewFamiliares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripFamiliares.ResumeLayout(False)
        Me.toolstripFamiliares.PerformLayout()
        Me.tabpageNotasAuditoria.ResumeLayout(False)
        Me.tabpageNotasAuditoria.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textboxApellido As System.Windows.Forms.TextBox
    Friend WithEvents textboxIDPersona As System.Windows.Forms.TextBox
    Friend WithEvents textboxNombre As System.Windows.Forms.TextBox
    Friend WithEvents pictureboxMain As System.Windows.Forms.PictureBox
    Friend WithEvents tabpageParticular As System.Windows.Forms.TabPage
    Friend WithEvents textboxDomicilioParticularCalle1 As System.Windows.Forms.TextBox
    Friend WithEvents textboxDomicilioParticularCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents textboxDomicilioParticularDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents textboxDomicilioParticularNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxDomicilioParticularPiso As System.Windows.Forms.TextBox
    Friend WithEvents comboboxDomicilioParticularProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxDomicilioParticularLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents textboxDomicilioParticularCalle3 As System.Windows.Forms.TextBox
    Friend WithEvents textboxDomicilioParticularCalle2 As System.Windows.Forms.TextBox
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tooltipMain As System.Windows.Forms.ToolTip
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents tabcontrolMain As CSBomberos.DesktopApplication.CS_Control_TabControl
    Friend WithEvents labelIDPersona As System.Windows.Forms.Label
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents datetimepickerFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents comboboxGenero As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxDocumentoTipo As System.Windows.Forms.ComboBox
    Friend WithEvents textboxDocumentoNumero As System.Windows.Forms.TextBox
    Friend WithEvents maskedtextboxDocumentoNumero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents textboxMatriculaNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxProfesion As System.Windows.Forms.TextBox
    Friend WithEvents textboxNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents tabpageLaboral As System.Windows.Forms.TabPage
    Friend WithEvents textboxEmailParticular As System.Windows.Forms.TextBox
    Friend WithEvents textboxTelefonoParticular As System.Windows.Forms.TextBox
    Friend WithEvents textboxCelularParticular As System.Windows.Forms.TextBox
    Friend WithEvents checkboxEsActivo As System.Windows.Forms.CheckBox
    Friend WithEvents textboxTelefonoLaboral As System.Windows.Forms.TextBox
    Friend WithEvents textboxCelularLaboral As System.Windows.Forms.TextBox
    Friend WithEvents textboxEmailLaboral As System.Windows.Forms.TextBox
    Friend WithEvents textboxDomicilioLaboralCalle3 As System.Windows.Forms.TextBox
    Friend WithEvents textboxDomicilioLaboralCalle2 As System.Windows.Forms.TextBox
    Friend WithEvents comboboxDomicilioLaboralLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxDomicilioLaboralProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents textboxDomicilioLaboralCalle1 As System.Windows.Forms.TextBox
    Friend WithEvents textboxDomicilioLaboralCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents textboxDomicilioLaboralDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents textboxDomicilioLaboralNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxDomicilioLaboralPiso As System.Windows.Forms.TextBox
    Friend WithEvents comboboxCuartel As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxEstado As System.Windows.Forms.ComboBox
    Friend WithEvents tabpageFamiliares As System.Windows.Forms.TabPage
    Friend WithEvents datagridviewFamiliares As System.Windows.Forms.DataGridView
    Friend WithEvents toolstripFamiliares As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonFamiliares_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonFamiliares_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonFamiliares_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents columnFamiliares_Parentesco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnFamiliares_Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnFamiliares_Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comboboxFactorRH As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxGrupoSanguineo As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxNivelEstudio As System.Windows.Forms.ComboBox
End Class
