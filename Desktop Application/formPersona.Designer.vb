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
        Dim labelCargoJerarquiaActual As System.Windows.Forms.Label
        Dim labelIOMANumeroAfiliado As System.Windows.Forms.Label
        Dim labelLicenciaConducirvencimiento As System.Windows.Forms.Label
        Dim labelLicenciaConducirNumero As System.Windows.Forms.Label
        Dim labelIOMATiene As System.Windows.Forms.Label
        Dim labelCantidadHijos As System.Windows.Forms.Label
        Dim labelNivelEstudio As System.Windows.Forms.Label
        Dim labelFactorRH As System.Windows.Forms.Label
        Dim labelGrupoSanguineo As System.Windows.Forms.Label
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim labelEsActivo As System.Windows.Forms.Label
        Dim labelNotas As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPersona))
        Me.labelIDPersona = New System.Windows.Forms.Label()
        Me.textboxApellido = New System.Windows.Forms.TextBox()
        Me.textboxIDPersona = New System.Windows.Forms.TextBox()
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.pictureboxFoto = New System.Windows.Forms.PictureBox()
        Me.menustripFoto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuitemFotoSeleccionarImagen = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemFotoEliminarImagen = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tooltipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.textboxMatriculaNumero = New System.Windows.Forms.TextBox()
        Me.openfiledialogFoto = New System.Windows.Forms.OpenFileDialog()
        Me.tabcontrolMain = New CSBomberos.DesktopApplication.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.textboxCargoJerarquiaActual = New System.Windows.Forms.TextBox()
        Me.textboxCantidadHijos = New System.Windows.Forms.TextBox()
        Me.textboxIOMANumeroAfiliado = New System.Windows.Forms.TextBox()
        Me.datetimepickerLicenciaConducirVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.buttonLicenciaConducirNumero = New System.Windows.Forms.Button()
        Me.textboxLicenciaConducirNumero = New System.Windows.Forms.TextBox()
        Me.comboboxIOMATiene = New System.Windows.Forms.ComboBox()
        Me.comboboxNivelEstudio = New System.Windows.Forms.ComboBox()
        Me.comboboxFactorRH = New System.Windows.Forms.ComboBox()
        Me.comboboxGrupoSanguineo = New System.Windows.Forms.ComboBox()
        Me.datetimepickerFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.comboboxGenero = New System.Windows.Forms.ComboBox()
        Me.comboboxDocumentoTipo = New System.Windows.Forms.ComboBox()
        Me.textboxDocumentoNumero = New System.Windows.Forms.TextBox()
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
        Me.tabpageAltasBajas = New System.Windows.Forms.TabPage()
        Me.datagridviewAltasBajas = New System.Windows.Forms.DataGridView()
        Me.columnAltasBajas_AltaFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnAltasBajas_BajaFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnaltasBajas_BajaMotivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripAltasBajas = New System.Windows.Forms.ToolStrip()
        Me.buttonAltasBajas_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAltasBajas_Editar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAltasBajas_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageAscensos = New System.Windows.Forms.TabPage()
        Me.datagridviewAscensos = New System.Windows.Forms.DataGridView()
        Me.columnFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnJerarquia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripAscensos = New System.Windows.Forms.ToolStrip()
        Me.buttonAscensos_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAscensos_Editar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAscensos_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageLicencias = New System.Windows.Forms.TabPage()
        Me.tabpageSanciones = New System.Windows.Forms.TabPage()
        Me.tabpageCursos = New System.Windows.Forms.TabPage()
        Me.tabpageCalificaciones = New System.Windows.Forms.TabPage()
        Me.datagridviewCalificaciones = New System.Windows.Forms.DataGridView()
        Me.columnAnioInstancia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnConceptosCalificaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripCalificaciones = New System.Windows.Forms.ToolStrip()
        Me.buttonCalificacinoes_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCalificacinoes_Editar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCalificacinoes_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageExamenes = New System.Windows.Forms.TabPage()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.datagridviewLicencias = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripLicencias = New System.Windows.Forms.ToolStrip()
        Me.buttonLicencias_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonLicencias_Editar = New System.Windows.Forms.ToolStripButton()
        Me.buttonLicencias_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.datagridviewSanciones = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripSanciones = New System.Windows.Forms.ToolStrip()
        Me.buttonSanciones_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonSanciones_Editar = New System.Windows.Forms.ToolStripButton()
        Me.buttonSanciones_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.datagridviewCursos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripCursos = New System.Windows.Forms.ToolStrip()
        Me.buttonCursos_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCursos_Editar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCursos_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.datagridviewExamenes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripExamenes = New System.Windows.Forms.ToolStrip()
        Me.buttonExamenes_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonExamenes_Editar = New System.Windows.Forms.ToolStripButton()
        Me.buttonExamenes_Eliminar = New System.Windows.Forms.ToolStripButton()
        labelApellido = New System.Windows.Forms.Label()
        labelNombre = New System.Windows.Forms.Label()
        labelMatriculaNumero = New System.Windows.Forms.Label()
        labelCargoJerarquiaActual = New System.Windows.Forms.Label()
        labelIOMANumeroAfiliado = New System.Windows.Forms.Label()
        labelLicenciaConducirvencimiento = New System.Windows.Forms.Label()
        labelLicenciaConducirNumero = New System.Windows.Forms.Label()
        labelIOMATiene = New System.Windows.Forms.Label()
        labelCantidadHijos = New System.Windows.Forms.Label()
        labelNivelEstudio = New System.Windows.Forms.Label()
        labelFactorRH = New System.Windows.Forms.Label()
        labelGrupoSanguineo = New System.Windows.Forms.Label()
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
        CType(Me.pictureboxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menustripFoto.SuspendLayout()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.tabpageParticular.SuspendLayout()
        Me.tabpageLaboral.SuspendLayout()
        Me.tabpageFamiliares.SuspendLayout()
        CType(Me.datagridviewFamiliares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripFamiliares.SuspendLayout()
        Me.tabpageAltasBajas.SuspendLayout()
        CType(Me.datagridviewAltasBajas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripAltasBajas.SuspendLayout()
        Me.tabpageAscensos.SuspendLayout()
        CType(Me.datagridviewAscensos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripAscensos.SuspendLayout()
        Me.tabpageLicencias.SuspendLayout()
        Me.tabpageSanciones.SuspendLayout()
        Me.tabpageCursos.SuspendLayout()
        Me.tabpageCalificaciones.SuspendLayout()
        CType(Me.datagridviewCalificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripCalificaciones.SuspendLayout()
        Me.tabpageExamenes.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        CType(Me.datagridviewLicencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripLicencias.SuspendLayout()
        CType(Me.datagridviewSanciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripSanciones.SuspendLayout()
        CType(Me.datagridviewCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripCursos.SuspendLayout()
        CType(Me.datagridviewExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripExamenes.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelApellido
        '
        labelApellido.AutoSize = True
        labelApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        labelApellido.Location = New System.Drawing.Point(119, 77)
        labelApellido.Name = "labelApellido"
        labelApellido.Size = New System.Drawing.Size(68, 16)
        labelApellido.TabIndex = 2
        labelApellido.Text = "Apellidos:"
        '
        'labelNombre
        '
        labelNombre.AutoSize = True
        labelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        labelNombre.Location = New System.Drawing.Point(119, 105)
        labelNombre.Name = "labelNombre"
        labelNombre.Size = New System.Drawing.Size(67, 16)
        labelNombre.TabIndex = 4
        labelNombre.Text = "Nombres:"
        '
        'labelMatriculaNumero
        '
        labelMatriculaNumero.AutoSize = True
        labelMatriculaNumero.Location = New System.Drawing.Point(312, 49)
        labelMatriculaNumero.Name = "labelMatriculaNumero"
        labelMatriculaNumero.Size = New System.Drawing.Size(55, 13)
        labelMatriculaNumero.TabIndex = 0
        labelMatriculaNumero.Text = "Matrícula:"
        '
        'labelIDPersona
        '
        Me.labelIDPersona.AutoSize = True
        Me.labelIDPersona.Location = New System.Drawing.Point(118, 49)
        Me.labelIDPersona.Name = "labelIDPersona"
        Me.labelIDPersona.Size = New System.Drawing.Size(79, 13)
        Me.labelIDPersona.TabIndex = 7
        Me.labelIDPersona.Text = "N° de Persona:"
        '
        'textboxApellido
        '
        Me.textboxApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxApellido.Location = New System.Drawing.Point(200, 74)
        Me.textboxApellido.MaxLength = 50
        Me.textboxApellido.Name = "textboxApellido"
        Me.textboxApellido.Size = New System.Drawing.Size(352, 22)
        Me.textboxApellido.TabIndex = 3
        '
        'textboxIDPersona
        '
        Me.textboxIDPersona.Location = New System.Drawing.Point(200, 46)
        Me.textboxIDPersona.MaxLength = 10
        Me.textboxIDPersona.Name = "textboxIDPersona"
        Me.textboxIDPersona.ReadOnly = True
        Me.textboxIDPersona.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDPersona.TabIndex = 8
        Me.textboxIDPersona.TabStop = False
        Me.textboxIDPersona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxNombre
        '
        Me.textboxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxNombre.Location = New System.Drawing.Point(200, 102)
        Me.textboxNombre.MaxLength = 50
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(352, 22)
        Me.textboxNombre.TabIndex = 5
        '
        'pictureboxFoto
        '
        Me.pictureboxFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureboxFoto.ContextMenuStrip = Me.menustripFoto
        Me.pictureboxFoto.Location = New System.Drawing.Point(12, 42)
        Me.pictureboxFoto.Name = "pictureboxFoto"
        Me.pictureboxFoto.Size = New System.Drawing.Size(90, 90)
        Me.pictureboxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureboxFoto.TabIndex = 93
        Me.pictureboxFoto.TabStop = False
        '
        'menustripFoto
        '
        Me.menustripFoto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemFotoSeleccionarImagen, Me.menuitemFotoEliminarImagen})
        Me.menustripFoto.Name = "menustripFoto"
        Me.menustripFoto.Size = New System.Drawing.Size(187, 48)
        '
        'menuitemFotoSeleccionarImagen
        '
        Me.menuitemFotoSeleccionarImagen.Name = "menuitemFotoSeleccionarImagen"
        Me.menuitemFotoSeleccionarImagen.Size = New System.Drawing.Size(186, 22)
        Me.menuitemFotoSeleccionarImagen.Text = "Seleccionar imagen..."
        '
        'menuitemFotoEliminarImagen
        '
        Me.menuitemFotoEliminarImagen.Name = "menuitemFotoEliminarImagen"
        Me.menuitemFotoEliminarImagen.Size = New System.Drawing.Size(186, 22)
        Me.menuitemFotoEliminarImagen.Text = "Quitar imagen"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(784, 39)
        Me.toolstripMain.TabIndex = 9
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
        Me.textboxMatriculaNumero.Location = New System.Drawing.Point(373, 46)
        Me.textboxMatriculaNumero.MaxLength = 6
        Me.textboxMatriculaNumero.Name = "textboxMatriculaNumero"
        Me.textboxMatriculaNumero.Size = New System.Drawing.Size(66, 20)
        Me.textboxMatriculaNumero.TabIndex = 1
        Me.tooltipMain.SetToolTip(Me.textboxMatriculaNumero, "Ingrese el Número de Documento sin utilizar puntos.")
        '
        'openfiledialogFoto
        '
        Me.openfiledialogFoto.Filter = "Archivos de imágenes|*.bmp;*.jpg;*.jpeg;*.gif|Todos los archivos (*.*)|*.*"
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageParticular)
        Me.tabcontrolMain.Controls.Add(Me.tabpageLaboral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageFamiliares)
        Me.tabcontrolMain.Controls.Add(Me.tabpageAltasBajas)
        Me.tabcontrolMain.Controls.Add(Me.tabpageAscensos)
        Me.tabcontrolMain.Controls.Add(Me.tabpageLicencias)
        Me.tabcontrolMain.Controls.Add(Me.tabpageSanciones)
        Me.tabcontrolMain.Controls.Add(Me.tabpageCursos)
        Me.tabcontrolMain.Controls.Add(Me.tabpageCalificaciones)
        Me.tabcontrolMain.Controls.Add(Me.tabpageExamenes)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 138)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(760, 411)
        Me.tabcontrolMain.TabIndex = 6
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.textboxCargoJerarquiaActual)
        Me.tabpageGeneral.Controls.Add(Me.textboxCantidadHijos)
        Me.tabpageGeneral.Controls.Add(labelCargoJerarquiaActual)
        Me.tabpageGeneral.Controls.Add(Me.textboxIOMANumeroAfiliado)
        Me.tabpageGeneral.Controls.Add(labelIOMANumeroAfiliado)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerLicenciaConducirVencimiento)
        Me.tabpageGeneral.Controls.Add(labelLicenciaConducirvencimiento)
        Me.tabpageGeneral.Controls.Add(Me.buttonLicenciaConducirNumero)
        Me.tabpageGeneral.Controls.Add(labelLicenciaConducirNumero)
        Me.tabpageGeneral.Controls.Add(Me.textboxLicenciaConducirNumero)
        Me.tabpageGeneral.Controls.Add(Me.comboboxIOMATiene)
        Me.tabpageGeneral.Controls.Add(labelIOMATiene)
        Me.tabpageGeneral.Controls.Add(labelCantidadHijos)
        Me.tabpageGeneral.Controls.Add(Me.comboboxNivelEstudio)
        Me.tabpageGeneral.Controls.Add(labelNivelEstudio)
        Me.tabpageGeneral.Controls.Add(Me.comboboxFactorRH)
        Me.tabpageGeneral.Controls.Add(labelFactorRH)
        Me.tabpageGeneral.Controls.Add(Me.comboboxGrupoSanguineo)
        Me.tabpageGeneral.Controls.Add(labelGrupoSanguineo)
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
        Me.tabpageGeneral.Size = New System.Drawing.Size(752, 382)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'textboxCargoJerarquiaActual
        '
        Me.textboxCargoJerarquiaActual.Location = New System.Drawing.Point(142, 351)
        Me.textboxCargoJerarquiaActual.MaxLength = 10
        Me.textboxCargoJerarquiaActual.Name = "textboxCargoJerarquiaActual"
        Me.textboxCargoJerarquiaActual.ReadOnly = True
        Me.textboxCargoJerarquiaActual.Size = New System.Drawing.Size(358, 20)
        Me.textboxCargoJerarquiaActual.TabIndex = 31
        Me.textboxCargoJerarquiaActual.TabStop = False
        Me.textboxCargoJerarquiaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxCantidadHijos
        '
        Me.textboxCantidadHijos.Location = New System.Drawing.Point(142, 323)
        Me.textboxCantidadHijos.MaxLength = 10
        Me.textboxCantidadHijos.Name = "textboxCantidadHijos"
        Me.textboxCantidadHijos.ReadOnly = True
        Me.textboxCantidadHijos.Size = New System.Drawing.Size(39, 20)
        Me.textboxCantidadHijos.TabIndex = 30
        Me.textboxCantidadHijos.TabStop = False
        Me.textboxCantidadHijos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelCargoJerarquiaActual
        '
        labelCargoJerarquiaActual.AutoSize = True
        labelCargoJerarquiaActual.Location = New System.Drawing.Point(6, 354)
        labelCargoJerarquiaActual.Name = "labelCargoJerarquiaActual"
        labelCargoJerarquiaActual.Size = New System.Drawing.Size(124, 13)
        labelCargoJerarquiaActual.TabIndex = 29
        labelCargoJerarquiaActual.Text = "Cargo - Jerarquía actual:"
        '
        'textboxIOMANumeroAfiliado
        '
        Me.textboxIOMANumeroAfiliado.Location = New System.Drawing.Point(365, 156)
        Me.textboxIOMANumeroAfiliado.MaxLength = 13
        Me.textboxIOMANumeroAfiliado.Name = "textboxIOMANumeroAfiliado"
        Me.textboxIOMANumeroAfiliado.Size = New System.Drawing.Size(115, 20)
        Me.textboxIOMANumeroAfiliado.TabIndex = 19
        Me.tooltipMain.SetToolTip(Me.textboxIOMANumeroAfiliado, "Ingrese el Número de Documento sin utilizar puntos.")
        '
        'labelIOMANumeroAfiliado
        '
        labelIOMANumeroAfiliado.AutoSize = True
        labelIOMANumeroAfiliado.Location = New System.Drawing.Point(286, 159)
        labelIOMANumeroAfiliado.Name = "labelIOMANumeroAfiliado"
        labelIOMANumeroAfiliado.Size = New System.Drawing.Size(73, 13)
        labelIOMANumeroAfiliado.TabIndex = 18
        labelIOMANumeroAfiliado.Text = "Nº de afiliado:"
        Me.tooltipMain.SetToolTip(labelIOMANumeroAfiliado, "Ingrese el Número de Documento sin utilizar puntos.")
        '
        'datetimepickerLicenciaConducirVencimiento
        '
        Me.datetimepickerLicenciaConducirVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerLicenciaConducirVencimiento.Location = New System.Drawing.Point(388, 37)
        Me.datetimepickerLicenciaConducirVencimiento.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerLicenciaConducirVencimiento.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerLicenciaConducirVencimiento.Name = "datetimepickerLicenciaConducirVencimiento"
        Me.datetimepickerLicenciaConducirVencimiento.ShowCheckBox = True
        Me.datetimepickerLicenciaConducirVencimiento.Size = New System.Drawing.Size(148, 20)
        Me.datetimepickerLicenciaConducirVencimiento.TabIndex = 7
        '
        'labelLicenciaConducirvencimiento
        '
        labelLicenciaConducirvencimiento.AutoSize = True
        labelLicenciaConducirvencimiento.Location = New System.Drawing.Point(314, 40)
        labelLicenciaConducirvencimiento.Name = "labelLicenciaConducirvencimiento"
        labelLicenciaConducirvencimiento.Size = New System.Drawing.Size(68, 13)
        labelLicenciaConducirvencimiento.TabIndex = 6
        labelLicenciaConducirvencimiento.Text = "Vencimiento:"
        Me.tooltipMain.SetToolTip(labelLicenciaConducirvencimiento, "Ingrese el Número de Documento sin utilizar puntos.")
        '
        'buttonLicenciaConducirNumero
        '
        Me.buttonLicenciaConducirNumero.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.buttonLicenciaConducirNumero.Location = New System.Drawing.Point(263, 36)
        Me.buttonLicenciaConducirNumero.Name = "buttonLicenciaConducirNumero"
        Me.buttonLicenciaConducirNumero.Size = New System.Drawing.Size(27, 21)
        Me.buttonLicenciaConducirNumero.TabIndex = 5
        Me.buttonLicenciaConducirNumero.Text = "Ã"
        Me.tooltipMain.SetToolTip(Me.buttonLicenciaConducirNumero, "Copiar número de documento")
        Me.buttonLicenciaConducirNumero.UseVisualStyleBackColor = True
        '
        'labelLicenciaConducirNumero
        '
        labelLicenciaConducirNumero.AutoSize = True
        labelLicenciaConducirNumero.Location = New System.Drawing.Point(6, 40)
        labelLicenciaConducirNumero.Name = "labelLicenciaConducirNumero"
        labelLicenciaConducirNumero.Size = New System.Drawing.Size(109, 13)
        labelLicenciaConducirNumero.TabIndex = 3
        labelLicenciaConducirNumero.Text = "Licencia de conducir:"
        Me.tooltipMain.SetToolTip(labelLicenciaConducirNumero, "Ingrese el Número de Documento sin utilizar puntos.")
        '
        'textboxLicenciaConducirNumero
        '
        Me.textboxLicenciaConducirNumero.Location = New System.Drawing.Point(142, 37)
        Me.textboxLicenciaConducirNumero.MaxLength = 11
        Me.textboxLicenciaConducirNumero.Name = "textboxLicenciaConducirNumero"
        Me.textboxLicenciaConducirNumero.Size = New System.Drawing.Size(115, 20)
        Me.textboxLicenciaConducirNumero.TabIndex = 4
        Me.tooltipMain.SetToolTip(Me.textboxLicenciaConducirNumero, "Ingrese el Número de Documento sin utilizar puntos.")
        '
        'comboboxIOMATiene
        '
        Me.comboboxIOMATiene.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxIOMATiene.FormattingEnabled = True
        Me.comboboxIOMATiene.Location = New System.Drawing.Point(142, 156)
        Me.comboboxIOMATiene.Name = "comboboxIOMATiene"
        Me.comboboxIOMATiene.Size = New System.Drawing.Size(121, 21)
        Me.comboboxIOMATiene.TabIndex = 17
        '
        'labelIOMATiene
        '
        labelIOMATiene.AutoSize = True
        labelIOMATiene.Location = New System.Drawing.Point(6, 159)
        labelIOMATiene.Name = "labelIOMATiene"
        labelIOMATiene.Size = New System.Drawing.Size(97, 13)
        labelIOMATiene.TabIndex = 16
        labelIOMATiene.Text = "Tiene I.O.M.A. por:"
        '
        'labelCantidadHijos
        '
        labelCantidadHijos.AutoSize = True
        labelCantidadHijos.Location = New System.Drawing.Point(6, 326)
        labelCantidadHijos.Name = "labelCantidadHijos"
        labelCantidadHijos.Size = New System.Drawing.Size(91, 13)
        labelCantidadHijos.TabIndex = 28
        labelCantidadHijos.Text = "Cantidad de hijos:"
        '
        'comboboxNivelEstudio
        '
        Me.comboboxNivelEstudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxNivelEstudio.FormattingEnabled = True
        Me.comboboxNivelEstudio.Location = New System.Drawing.Point(142, 195)
        Me.comboboxNivelEstudio.Name = "comboboxNivelEstudio"
        Me.comboboxNivelEstudio.Size = New System.Drawing.Size(275, 21)
        Me.comboboxNivelEstudio.TabIndex = 21
        '
        'labelNivelEstudio
        '
        labelNivelEstudio.AutoSize = True
        labelNivelEstudio.Location = New System.Drawing.Point(6, 198)
        labelNivelEstudio.Name = "labelNivelEstudio"
        labelNivelEstudio.Size = New System.Drawing.Size(91, 13)
        labelNivelEstudio.TabIndex = 20
        labelNivelEstudio.Text = "Nivel de estudios:"
        '
        'comboboxFactorRH
        '
        Me.comboboxFactorRH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxFactorRH.FormattingEnabled = True
        Me.comboboxFactorRH.Location = New System.Drawing.Point(315, 129)
        Me.comboboxFactorRH.Name = "comboboxFactorRH"
        Me.comboboxFactorRH.Size = New System.Drawing.Size(102, 21)
        Me.comboboxFactorRH.TabIndex = 15
        '
        'labelFactorRH
        '
        labelFactorRH.AutoSize = True
        labelFactorRH.Location = New System.Drawing.Point(250, 132)
        labelFactorRH.Name = "labelFactorRH"
        labelFactorRH.Size = New System.Drawing.Size(59, 13)
        labelFactorRH.TabIndex = 14
        labelFactorRH.Text = "Factor RH:"
        '
        'comboboxGrupoSanguineo
        '
        Me.comboboxGrupoSanguineo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxGrupoSanguineo.FormattingEnabled = True
        Me.comboboxGrupoSanguineo.Location = New System.Drawing.Point(142, 129)
        Me.comboboxGrupoSanguineo.Name = "comboboxGrupoSanguineo"
        Me.comboboxGrupoSanguineo.Size = New System.Drawing.Size(102, 21)
        Me.comboboxGrupoSanguineo.TabIndex = 13
        '
        'labelGrupoSanguineo
        '
        labelGrupoSanguineo.AutoSize = True
        labelGrupoSanguineo.Location = New System.Drawing.Point(6, 132)
        labelGrupoSanguineo.Name = "labelGrupoSanguineo"
        labelGrupoSanguineo.Size = New System.Drawing.Size(93, 13)
        labelGrupoSanguineo.TabIndex = 12
        labelGrupoSanguineo.Text = "Grupo sanguíneo:"
        '
        'labelFechaNacimiento
        '
        labelFechaNacimiento.AutoSize = True
        labelFechaNacimiento.Location = New System.Drawing.Point(6, 79)
        labelFechaNacimiento.Name = "labelFechaNacimiento"
        labelFechaNacimiento.Size = New System.Drawing.Size(109, 13)
        labelFechaNacimiento.TabIndex = 8
        labelFechaNacimiento.Text = "Fecha de nacimiento:"
        '
        'datetimepickerFechaNacimiento
        '
        Me.datetimepickerFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaNacimiento.Location = New System.Drawing.Point(142, 76)
        Me.datetimepickerFechaNacimiento.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaNacimiento.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaNacimiento.Name = "datetimepickerFechaNacimiento"
        Me.datetimepickerFechaNacimiento.ShowCheckBox = True
        Me.datetimepickerFechaNacimiento.Size = New System.Drawing.Size(148, 20)
        Me.datetimepickerFechaNacimiento.TabIndex = 9
        '
        'comboboxGenero
        '
        Me.comboboxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxGenero.FormattingEnabled = True
        Me.comboboxGenero.Location = New System.Drawing.Point(142, 102)
        Me.comboboxGenero.Name = "comboboxGenero"
        Me.comboboxGenero.Size = New System.Drawing.Size(102, 21)
        Me.comboboxGenero.TabIndex = 11
        '
        'labelGenero
        '
        labelGenero.AutoSize = True
        labelGenero.Location = New System.Drawing.Point(6, 105)
        labelGenero.Name = "labelGenero"
        labelGenero.Size = New System.Drawing.Size(45, 13)
        labelGenero.TabIndex = 10
        labelGenero.Text = "Género:"
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
        'textboxDocumentoNumero
        '
        Me.textboxDocumentoNumero.Location = New System.Drawing.Point(250, 10)
        Me.textboxDocumentoNumero.MaxLength = 11
        Me.textboxDocumentoNumero.Name = "textboxDocumentoNumero"
        Me.textboxDocumentoNumero.Size = New System.Drawing.Size(115, 20)
        Me.textboxDocumentoNumero.TabIndex = 2
        Me.tooltipMain.SetToolTip(Me.textboxDocumentoNumero, "Ingrese el Número de Documento sin utilizar puntos.")
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
        Me.maskedtextboxDocumentoNumero.TabIndex = 4
        Me.maskedtextboxDocumentoNumero.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'labelNacionalidad
        '
        labelNacionalidad.AutoSize = True
        labelNacionalidad.Location = New System.Drawing.Point(6, 251)
        labelNacionalidad.Name = "labelNacionalidad"
        labelNacionalidad.Size = New System.Drawing.Size(72, 13)
        labelNacionalidad.TabIndex = 24
        labelNacionalidad.Text = "Nacionalidad:"
        '
        'textboxNacionalidad
        '
        Me.textboxNacionalidad.Location = New System.Drawing.Point(142, 248)
        Me.textboxNacionalidad.MaxLength = 100
        Me.textboxNacionalidad.Name = "textboxNacionalidad"
        Me.textboxNacionalidad.Size = New System.Drawing.Size(358, 20)
        Me.textboxNacionalidad.TabIndex = 25
        '
        'labelProfesion
        '
        labelProfesion.AutoSize = True
        labelProfesion.Location = New System.Drawing.Point(6, 225)
        labelProfesion.Name = "labelProfesion"
        labelProfesion.Size = New System.Drawing.Size(54, 13)
        labelProfesion.TabIndex = 22
        labelProfesion.Text = "Profesión:"
        '
        'textboxProfesion
        '
        Me.textboxProfesion.Location = New System.Drawing.Point(142, 222)
        Me.textboxProfesion.MaxLength = 100
        Me.textboxProfesion.Name = "textboxProfesion"
        Me.textboxProfesion.Size = New System.Drawing.Size(358, 20)
        Me.textboxProfesion.TabIndex = 23
        '
        'labelCuartel
        '
        labelCuartel.AutoSize = True
        labelCuartel.Location = New System.Drawing.Point(6, 277)
        labelCuartel.Name = "labelCuartel"
        labelCuartel.Size = New System.Drawing.Size(43, 13)
        labelCuartel.TabIndex = 26
        labelCuartel.Text = "Cuartel:"
        '
        'comboboxCuartel
        '
        Me.comboboxCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCuartel.FormattingEnabled = True
        Me.comboboxCuartel.Location = New System.Drawing.Point(142, 274)
        Me.comboboxCuartel.Name = "comboboxCuartel"
        Me.comboboxCuartel.Size = New System.Drawing.Size(358, 21)
        Me.comboboxCuartel.TabIndex = 27
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
        Me.tabpageParticular.Size = New System.Drawing.Size(752, 382)
        Me.tabpageParticular.TabIndex = 1
        Me.tabpageParticular.Text = "Contacto Particular"
        Me.tabpageParticular.UseVisualStyleBackColor = True
        '
        'labelTelefonoParticular
        '
        labelTelefonoParticular.AutoSize = True
        labelTelefonoParticular.Location = New System.Drawing.Point(6, 229)
        labelTelefonoParticular.Name = "labelTelefonoParticular"
        labelTelefonoParticular.Size = New System.Drawing.Size(52, 13)
        labelTelefonoParticular.TabIndex = 18
        labelTelefonoParticular.Text = "Teléfono:"
        '
        'textboxTelefonoParticular
        '
        Me.textboxTelefonoParticular.Location = New System.Drawing.Point(72, 226)
        Me.textboxTelefonoParticular.MaxLength = 50
        Me.textboxTelefonoParticular.Name = "textboxTelefonoParticular"
        Me.textboxTelefonoParticular.Size = New System.Drawing.Size(170, 20)
        Me.textboxTelefonoParticular.TabIndex = 19
        '
        'labelCelularParticular
        '
        labelCelularParticular.AutoSize = True
        labelCelularParticular.Location = New System.Drawing.Point(6, 255)
        labelCelularParticular.Name = "labelCelularParticular"
        labelCelularParticular.Size = New System.Drawing.Size(42, 13)
        labelCelularParticular.TabIndex = 20
        labelCelularParticular.Text = "Celular:"
        '
        'textboxCelularParticular
        '
        Me.textboxCelularParticular.Location = New System.Drawing.Point(72, 252)
        Me.textboxCelularParticular.MaxLength = 50
        Me.textboxCelularParticular.Name = "textboxCelularParticular"
        Me.textboxCelularParticular.Size = New System.Drawing.Size(170, 20)
        Me.textboxCelularParticular.TabIndex = 21
        '
        'labelEmailParticular
        '
        labelEmailParticular.AutoSize = True
        labelEmailParticular.Location = New System.Drawing.Point(6, 281)
        labelEmailParticular.Name = "labelEmailParticular"
        labelEmailParticular.Size = New System.Drawing.Size(38, 13)
        labelEmailParticular.TabIndex = 22
        labelEmailParticular.Text = "E-mail:"
        '
        'textboxEmailParticular
        '
        Me.textboxEmailParticular.Location = New System.Drawing.Point(72, 278)
        Me.textboxEmailParticular.MaxLength = 50
        Me.textboxEmailParticular.Name = "textboxEmailParticular"
        Me.textboxEmailParticular.Size = New System.Drawing.Size(306, 20)
        Me.textboxEmailParticular.TabIndex = 23
        '
        'labelDomicilioParticularCalle3
        '
        labelDomicilioParticularCalle3.AutoSize = True
        labelDomicilioParticularCalle3.Location = New System.Drawing.Point(8, 91)
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
        'textboxDomicilioParticularCalle3
        '
        Me.textboxDomicilioParticularCalle3.Location = New System.Drawing.Point(72, 88)
        Me.textboxDomicilioParticularCalle3.MaxLength = 50
        Me.textboxDomicilioParticularCalle3.Name = "textboxDomicilioParticularCalle3"
        Me.textboxDomicilioParticularCalle3.Size = New System.Drawing.Size(258, 20)
        Me.textboxDomicilioParticularCalle3.TabIndex = 11
        '
        'textboxDomicilioParticularCalle2
        '
        Me.textboxDomicilioParticularCalle2.Location = New System.Drawing.Point(72, 62)
        Me.textboxDomicilioParticularCalle2.MaxLength = 50
        Me.textboxDomicilioParticularCalle2.Name = "textboxDomicilioParticularCalle2"
        Me.textboxDomicilioParticularCalle2.Size = New System.Drawing.Size(258, 20)
        Me.textboxDomicilioParticularCalle2.TabIndex = 9
        '
        'comboboxDomicilioParticularLocalidad
        '
        Me.comboboxDomicilioParticularLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDomicilioParticularLocalidad.FormattingEnabled = True
        Me.comboboxDomicilioParticularLocalidad.Location = New System.Drawing.Point(72, 141)
        Me.comboboxDomicilioParticularLocalidad.Name = "comboboxDomicilioParticularLocalidad"
        Me.comboboxDomicilioParticularLocalidad.Size = New System.Drawing.Size(258, 21)
        Me.comboboxDomicilioParticularLocalidad.TabIndex = 15
        '
        'comboboxDomicilioParticularProvincia
        '
        Me.comboboxDomicilioParticularProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDomicilioParticularProvincia.FormattingEnabled = True
        Me.comboboxDomicilioParticularProvincia.Location = New System.Drawing.Point(72, 114)
        Me.comboboxDomicilioParticularProvincia.Name = "comboboxDomicilioParticularProvincia"
        Me.comboboxDomicilioParticularProvincia.Size = New System.Drawing.Size(258, 21)
        Me.comboboxDomicilioParticularProvincia.TabIndex = 13
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
        'textboxDomicilioParticularCalle1
        '
        Me.textboxDomicilioParticularCalle1.Location = New System.Drawing.Point(72, 10)
        Me.textboxDomicilioParticularCalle1.MaxLength = 100
        Me.textboxDomicilioParticularCalle1.Name = "textboxDomicilioParticularCalle1"
        Me.textboxDomicilioParticularCalle1.Size = New System.Drawing.Size(258, 20)
        Me.textboxDomicilioParticularCalle1.TabIndex = 1
        '
        'labelDomicilioParticularCodigoPostal
        '
        labelDomicilioParticularCodigoPostal.AutoSize = True
        labelDomicilioParticularCodigoPostal.Location = New System.Drawing.Point(8, 171)
        labelDomicilioParticularCodigoPostal.Name = "labelDomicilioParticularCodigoPostal"
        labelDomicilioParticularCodigoPostal.Size = New System.Drawing.Size(59, 13)
        labelDomicilioParticularCodigoPostal.TabIndex = 16
        labelDomicilioParticularCodigoPostal.Text = "Cód. Post.:"
        '
        'textboxDomicilioParticularCodigoPostal
        '
        Me.textboxDomicilioParticularCodigoPostal.Location = New System.Drawing.Point(72, 168)
        Me.textboxDomicilioParticularCodigoPostal.MaxLength = 8
        Me.textboxDomicilioParticularCodigoPostal.Name = "textboxDomicilioParticularCodigoPostal"
        Me.textboxDomicilioParticularCodigoPostal.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioParticularCodigoPostal.TabIndex = 17
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
        'textboxDomicilioParticularDepartamento
        '
        Me.textboxDomicilioParticularDepartamento.Location = New System.Drawing.Point(280, 36)
        Me.textboxDomicilioParticularDepartamento.MaxLength = 10
        Me.textboxDomicilioParticularDepartamento.Name = "textboxDomicilioParticularDepartamento"
        Me.textboxDomicilioParticularDepartamento.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioParticularDepartamento.TabIndex = 7
        '
        'labelDomicilioParticularLocalidad
        '
        labelDomicilioParticularLocalidad.AutoSize = True
        labelDomicilioParticularLocalidad.Location = New System.Drawing.Point(6, 144)
        labelDomicilioParticularLocalidad.Name = "labelDomicilioParticularLocalidad"
        labelDomicilioParticularLocalidad.Size = New System.Drawing.Size(56, 13)
        labelDomicilioParticularLocalidad.TabIndex = 14
        labelDomicilioParticularLocalidad.Text = "Localidad:"
        '
        'labelDomicilioParticularProvincia
        '
        labelDomicilioParticularProvincia.AutoSize = True
        labelDomicilioParticularProvincia.Location = New System.Drawing.Point(6, 117)
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
        'textboxDomicilioParticularNumero
        '
        Me.textboxDomicilioParticularNumero.Location = New System.Drawing.Point(72, 36)
        Me.textboxDomicilioParticularNumero.MaxLength = 10
        Me.textboxDomicilioParticularNumero.Name = "textboxDomicilioParticularNumero"
        Me.textboxDomicilioParticularNumero.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioParticularNumero.TabIndex = 3
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
        Me.tabpageLaboral.Size = New System.Drawing.Size(752, 382)
        Me.tabpageLaboral.TabIndex = 9
        Me.tabpageLaboral.Text = "Contacto Laboral"
        Me.tabpageLaboral.UseVisualStyleBackColor = True
        '
        'labelTelefonoLaboral
        '
        labelTelefonoLaboral.AutoSize = True
        labelTelefonoLaboral.Location = New System.Drawing.Point(6, 229)
        labelTelefonoLaboral.Name = "labelTelefonoLaboral"
        labelTelefonoLaboral.Size = New System.Drawing.Size(52, 13)
        labelTelefonoLaboral.TabIndex = 18
        labelTelefonoLaboral.Text = "Teléfono:"
        '
        'textboxTelefonoLaboral
        '
        Me.textboxTelefonoLaboral.Location = New System.Drawing.Point(72, 226)
        Me.textboxTelefonoLaboral.MaxLength = 50
        Me.textboxTelefonoLaboral.Name = "textboxTelefonoLaboral"
        Me.textboxTelefonoLaboral.Size = New System.Drawing.Size(170, 20)
        Me.textboxTelefonoLaboral.TabIndex = 19
        '
        'labelCelularLaboral
        '
        labelCelularLaboral.AutoSize = True
        labelCelularLaboral.Location = New System.Drawing.Point(6, 255)
        labelCelularLaboral.Name = "labelCelularLaboral"
        labelCelularLaboral.Size = New System.Drawing.Size(42, 13)
        labelCelularLaboral.TabIndex = 20
        labelCelularLaboral.Text = "Celular:"
        '
        'textboxCelularLaboral
        '
        Me.textboxCelularLaboral.Location = New System.Drawing.Point(72, 252)
        Me.textboxCelularLaboral.MaxLength = 50
        Me.textboxCelularLaboral.Name = "textboxCelularLaboral"
        Me.textboxCelularLaboral.Size = New System.Drawing.Size(170, 20)
        Me.textboxCelularLaboral.TabIndex = 21
        '
        'labelEmailLaboral
        '
        labelEmailLaboral.AutoSize = True
        labelEmailLaboral.Location = New System.Drawing.Point(6, 281)
        labelEmailLaboral.Name = "labelEmailLaboral"
        labelEmailLaboral.Size = New System.Drawing.Size(38, 13)
        labelEmailLaboral.TabIndex = 22
        labelEmailLaboral.Text = "E-mail:"
        '
        'textboxEmailLaboral
        '
        Me.textboxEmailLaboral.Location = New System.Drawing.Point(72, 278)
        Me.textboxEmailLaboral.MaxLength = 50
        Me.textboxEmailLaboral.Name = "textboxEmailLaboral"
        Me.textboxEmailLaboral.Size = New System.Drawing.Size(306, 20)
        Me.textboxEmailLaboral.TabIndex = 23
        '
        'labelDomicilioLaboralCalle3
        '
        labelDomicilioLaboralCalle3.AutoSize = True
        labelDomicilioLaboralCalle3.Location = New System.Drawing.Point(8, 91)
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
        'textboxDomicilioLaboralCalle3
        '
        Me.textboxDomicilioLaboralCalle3.Location = New System.Drawing.Point(72, 88)
        Me.textboxDomicilioLaboralCalle3.MaxLength = 50
        Me.textboxDomicilioLaboralCalle3.Name = "textboxDomicilioLaboralCalle3"
        Me.textboxDomicilioLaboralCalle3.Size = New System.Drawing.Size(258, 20)
        Me.textboxDomicilioLaboralCalle3.TabIndex = 11
        '
        'textboxDomicilioLaboralCalle2
        '
        Me.textboxDomicilioLaboralCalle2.Location = New System.Drawing.Point(72, 62)
        Me.textboxDomicilioLaboralCalle2.MaxLength = 50
        Me.textboxDomicilioLaboralCalle2.Name = "textboxDomicilioLaboralCalle2"
        Me.textboxDomicilioLaboralCalle2.Size = New System.Drawing.Size(258, 20)
        Me.textboxDomicilioLaboralCalle2.TabIndex = 9
        '
        'comboboxDomicilioLaboralLocalidad
        '
        Me.comboboxDomicilioLaboralLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDomicilioLaboralLocalidad.FormattingEnabled = True
        Me.comboboxDomicilioLaboralLocalidad.Location = New System.Drawing.Point(72, 141)
        Me.comboboxDomicilioLaboralLocalidad.Name = "comboboxDomicilioLaboralLocalidad"
        Me.comboboxDomicilioLaboralLocalidad.Size = New System.Drawing.Size(258, 21)
        Me.comboboxDomicilioLaboralLocalidad.TabIndex = 15
        '
        'comboboxDomicilioLaboralProvincia
        '
        Me.comboboxDomicilioLaboralProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDomicilioLaboralProvincia.FormattingEnabled = True
        Me.comboboxDomicilioLaboralProvincia.Location = New System.Drawing.Point(72, 114)
        Me.comboboxDomicilioLaboralProvincia.Name = "comboboxDomicilioLaboralProvincia"
        Me.comboboxDomicilioLaboralProvincia.Size = New System.Drawing.Size(258, 21)
        Me.comboboxDomicilioLaboralProvincia.TabIndex = 13
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
        'textboxDomicilioLaboralCalle1
        '
        Me.textboxDomicilioLaboralCalle1.Location = New System.Drawing.Point(72, 10)
        Me.textboxDomicilioLaboralCalle1.MaxLength = 100
        Me.textboxDomicilioLaboralCalle1.Name = "textboxDomicilioLaboralCalle1"
        Me.textboxDomicilioLaboralCalle1.Size = New System.Drawing.Size(258, 20)
        Me.textboxDomicilioLaboralCalle1.TabIndex = 1
        '
        'labelDomicilioLaboralCodigoPostal
        '
        labelDomicilioLaboralCodigoPostal.AutoSize = True
        labelDomicilioLaboralCodigoPostal.Location = New System.Drawing.Point(8, 171)
        labelDomicilioLaboralCodigoPostal.Name = "labelDomicilioLaboralCodigoPostal"
        labelDomicilioLaboralCodigoPostal.Size = New System.Drawing.Size(59, 13)
        labelDomicilioLaboralCodigoPostal.TabIndex = 16
        labelDomicilioLaboralCodigoPostal.Text = "Cód. Post.:"
        '
        'textboxDomicilioLaboralCodigoPostal
        '
        Me.textboxDomicilioLaboralCodigoPostal.Location = New System.Drawing.Point(72, 168)
        Me.textboxDomicilioLaboralCodigoPostal.MaxLength = 8
        Me.textboxDomicilioLaboralCodigoPostal.Name = "textboxDomicilioLaboralCodigoPostal"
        Me.textboxDomicilioLaboralCodigoPostal.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioLaboralCodigoPostal.TabIndex = 17
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
        'textboxDomicilioLaboralDepartamento
        '
        Me.textboxDomicilioLaboralDepartamento.Location = New System.Drawing.Point(280, 36)
        Me.textboxDomicilioLaboralDepartamento.MaxLength = 10
        Me.textboxDomicilioLaboralDepartamento.Name = "textboxDomicilioLaboralDepartamento"
        Me.textboxDomicilioLaboralDepartamento.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioLaboralDepartamento.TabIndex = 7
        '
        'labelDomicilioLaboralLocalidad
        '
        labelDomicilioLaboralLocalidad.AutoSize = True
        labelDomicilioLaboralLocalidad.Location = New System.Drawing.Point(6, 144)
        labelDomicilioLaboralLocalidad.Name = "labelDomicilioLaboralLocalidad"
        labelDomicilioLaboralLocalidad.Size = New System.Drawing.Size(56, 13)
        labelDomicilioLaboralLocalidad.TabIndex = 14
        labelDomicilioLaboralLocalidad.Text = "Localidad:"
        '
        'labelDomicilioLaboralProvincia
        '
        labelDomicilioLaboralProvincia.AutoSize = True
        labelDomicilioLaboralProvincia.Location = New System.Drawing.Point(6, 117)
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
        'textboxDomicilioLaboralNumero
        '
        Me.textboxDomicilioLaboralNumero.Location = New System.Drawing.Point(72, 36)
        Me.textboxDomicilioLaboralNumero.MaxLength = 10
        Me.textboxDomicilioLaboralNumero.Name = "textboxDomicilioLaboralNumero"
        Me.textboxDomicilioLaboralNumero.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioLaboralNumero.TabIndex = 3
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
        Me.tabpageFamiliares.Size = New System.Drawing.Size(752, 382)
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
        Me.datagridviewFamiliares.Size = New System.Drawing.Size(659, 376)
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
        Me.toolstripFamiliares.Size = New System.Drawing.Size(87, 376)
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
        'tabpageAltasBajas
        '
        Me.tabpageAltasBajas.Controls.Add(Me.datagridviewAltasBajas)
        Me.tabpageAltasBajas.Controls.Add(Me.toolstripAltasBajas)
        Me.tabpageAltasBajas.Location = New System.Drawing.Point(4, 25)
        Me.tabpageAltasBajas.Name = "tabpageAltasBajas"
        Me.tabpageAltasBajas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageAltasBajas.Size = New System.Drawing.Size(752, 382)
        Me.tabpageAltasBajas.TabIndex = 11
        Me.tabpageAltasBajas.Text = "Altas - Bajas"
        Me.tabpageAltasBajas.UseVisualStyleBackColor = True
        '
        'datagridviewAltasBajas
        '
        Me.datagridviewAltasBajas.AllowUserToAddRows = False
        Me.datagridviewAltasBajas.AllowUserToDeleteRows = False
        Me.datagridviewAltasBajas.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewAltasBajas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.datagridviewAltasBajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewAltasBajas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnAltasBajas_AltaFecha, Me.columnAltasBajas_BajaFecha, Me.columnaltasBajas_BajaMotivo})
        Me.datagridviewAltasBajas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewAltasBajas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewAltasBajas.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewAltasBajas.MultiSelect = False
        Me.datagridviewAltasBajas.Name = "datagridviewAltasBajas"
        Me.datagridviewAltasBajas.ReadOnly = True
        Me.datagridviewAltasBajas.RowHeadersVisible = False
        Me.datagridviewAltasBajas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewAltasBajas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewAltasBajas.Size = New System.Drawing.Size(659, 376)
        Me.datagridviewAltasBajas.TabIndex = 8
        '
        'columnAltasBajas_AltaFecha
        '
        Me.columnAltasBajas_AltaFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnAltasBajas_AltaFecha.DataPropertyName = "AltaFecha"
        Me.columnAltasBajas_AltaFecha.HeaderText = "Fecha de alta"
        Me.columnAltasBajas_AltaFecha.Name = "columnAltasBajas_AltaFecha"
        Me.columnAltasBajas_AltaFecha.ReadOnly = True
        Me.columnAltasBajas_AltaFecha.Width = 97
        '
        'columnAltasBajas_BajaFecha
        '
        Me.columnAltasBajas_BajaFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnAltasBajas_BajaFecha.DataPropertyName = "BajaFecha"
        Me.columnAltasBajas_BajaFecha.HeaderText = "Fecha de baja"
        Me.columnAltasBajas_BajaFecha.Name = "columnAltasBajas_BajaFecha"
        Me.columnAltasBajas_BajaFecha.ReadOnly = True
        '
        'columnaltasBajas_BajaMotivo
        '
        Me.columnaltasBajas_BajaMotivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnaltasBajas_BajaMotivo.DataPropertyName = "BajaMotivoNombre"
        Me.columnaltasBajas_BajaMotivo.HeaderText = "Motivo de baja"
        Me.columnaltasBajas_BajaMotivo.Name = "columnaltasBajas_BajaMotivo"
        Me.columnaltasBajas_BajaMotivo.ReadOnly = True
        Me.columnaltasBajas_BajaMotivo.Width = 102
        '
        'toolstripAltasBajas
        '
        Me.toolstripAltasBajas.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripAltasBajas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripAltasBajas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAltasBajas_Agregar, Me.buttonAltasBajas_Editar, Me.buttonAltasBajas_Eliminar})
        Me.toolstripAltasBajas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripAltasBajas.Location = New System.Drawing.Point(3, 3)
        Me.toolstripAltasBajas.Name = "toolstripAltasBajas"
        Me.toolstripAltasBajas.Size = New System.Drawing.Size(87, 376)
        Me.toolstripAltasBajas.TabIndex = 9
        '
        'buttonAltasBajas_Agregar
        '
        Me.buttonAltasBajas_Agregar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonAltasBajas_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAltasBajas_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAltasBajas_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAltasBajas_Agregar.Name = "buttonAltasBajas_Agregar"
        Me.buttonAltasBajas_Agregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAltasBajas_Agregar.Text = "Agregar"
        '
        'buttonAltasBajas_Editar
        '
        Me.buttonAltasBajas_Editar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonAltasBajas_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAltasBajas_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAltasBajas_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAltasBajas_Editar.Name = "buttonAltasBajas_Editar"
        Me.buttonAltasBajas_Editar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAltasBajas_Editar.Text = "Editar"
        '
        'buttonAltasBajas_Eliminar
        '
        Me.buttonAltasBajas_Eliminar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonAltasBajas_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAltasBajas_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAltasBajas_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAltasBajas_Eliminar.Name = "buttonAltasBajas_Eliminar"
        Me.buttonAltasBajas_Eliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAltasBajas_Eliminar.Text = "Eliminar"
        '
        'tabpageAscensos
        '
        Me.tabpageAscensos.Controls.Add(Me.datagridviewAscensos)
        Me.tabpageAscensos.Controls.Add(Me.toolstripAscensos)
        Me.tabpageAscensos.Location = New System.Drawing.Point(4, 25)
        Me.tabpageAscensos.Name = "tabpageAscensos"
        Me.tabpageAscensos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageAscensos.Size = New System.Drawing.Size(752, 382)
        Me.tabpageAscensos.TabIndex = 12
        Me.tabpageAscensos.Text = "Ascensos"
        Me.tabpageAscensos.UseVisualStyleBackColor = True
        '
        'datagridviewAscensos
        '
        Me.datagridviewAscensos.AllowUserToAddRows = False
        Me.datagridviewAscensos.AllowUserToDeleteRows = False
        Me.datagridviewAscensos.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewAscensos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridviewAscensos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewAscensos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnFecha, Me.columnCargo, Me.columnJerarquia})
        Me.datagridviewAscensos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewAscensos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewAscensos.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewAscensos.MultiSelect = False
        Me.datagridviewAscensos.Name = "datagridviewAscensos"
        Me.datagridviewAscensos.ReadOnly = True
        Me.datagridviewAscensos.RowHeadersVisible = False
        Me.datagridviewAscensos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewAscensos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewAscensos.Size = New System.Drawing.Size(659, 376)
        Me.datagridviewAscensos.TabIndex = 2
        '
        'columnFecha
        '
        Me.columnFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnFecha.DataPropertyName = "Fecha"
        Me.columnFecha.HeaderText = "Fecha"
        Me.columnFecha.Name = "columnFecha"
        Me.columnFecha.ReadOnly = True
        Me.columnFecha.Width = 62
        '
        'columnCargo
        '
        Me.columnCargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnCargo.DataPropertyName = "CargoNombre"
        Me.columnCargo.HeaderText = "Cargo"
        Me.columnCargo.Name = "columnCargo"
        Me.columnCargo.ReadOnly = True
        Me.columnCargo.Width = 60
        '
        'columnJerarquia
        '
        Me.columnJerarquia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnJerarquia.DataPropertyName = "CargoJerarquiaNombre"
        Me.columnJerarquia.HeaderText = "Jerarquía"
        Me.columnJerarquia.Name = "columnJerarquia"
        Me.columnJerarquia.ReadOnly = True
        Me.columnJerarquia.Width = 77
        '
        'toolstripAscensos
        '
        Me.toolstripAscensos.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripAscensos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripAscensos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAscensos_Agregar, Me.buttonAscensos_Editar, Me.buttonAscensos_Eliminar})
        Me.toolstripAscensos.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripAscensos.Location = New System.Drawing.Point(3, 3)
        Me.toolstripAscensos.Name = "toolstripAscensos"
        Me.toolstripAscensos.Size = New System.Drawing.Size(87, 376)
        Me.toolstripAscensos.TabIndex = 3
        '
        'buttonAscensos_Agregar
        '
        Me.buttonAscensos_Agregar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonAscensos_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAscensos_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAscensos_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAscensos_Agregar.Name = "buttonAscensos_Agregar"
        Me.buttonAscensos_Agregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAscensos_Agregar.Text = "Agregar"
        '
        'buttonAscensos_Editar
        '
        Me.buttonAscensos_Editar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonAscensos_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAscensos_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAscensos_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAscensos_Editar.Name = "buttonAscensos_Editar"
        Me.buttonAscensos_Editar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAscensos_Editar.Text = "Editar"
        '
        'buttonAscensos_Eliminar
        '
        Me.buttonAscensos_Eliminar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonAscensos_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAscensos_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAscensos_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAscensos_Eliminar.Name = "buttonAscensos_Eliminar"
        Me.buttonAscensos_Eliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAscensos_Eliminar.Text = "Eliminar"
        '
        'tabpageLicencias
        '
        Me.tabpageLicencias.Controls.Add(Me.datagridviewLicencias)
        Me.tabpageLicencias.Controls.Add(Me.toolstripLicencias)
        Me.tabpageLicencias.Location = New System.Drawing.Point(4, 25)
        Me.tabpageLicencias.Name = "tabpageLicencias"
        Me.tabpageLicencias.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageLicencias.Size = New System.Drawing.Size(752, 382)
        Me.tabpageLicencias.TabIndex = 13
        Me.tabpageLicencias.Text = "Licencias"
        Me.tabpageLicencias.UseVisualStyleBackColor = True
        '
        'tabpageSanciones
        '
        Me.tabpageSanciones.Controls.Add(Me.datagridviewSanciones)
        Me.tabpageSanciones.Controls.Add(Me.toolstripSanciones)
        Me.tabpageSanciones.Location = New System.Drawing.Point(4, 25)
        Me.tabpageSanciones.Name = "tabpageSanciones"
        Me.tabpageSanciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageSanciones.Size = New System.Drawing.Size(752, 382)
        Me.tabpageSanciones.TabIndex = 14
        Me.tabpageSanciones.Text = "Sanciones"
        Me.tabpageSanciones.UseVisualStyleBackColor = True
        '
        'tabpageCursos
        '
        Me.tabpageCursos.Controls.Add(Me.datagridviewCursos)
        Me.tabpageCursos.Controls.Add(Me.toolstripCursos)
        Me.tabpageCursos.Location = New System.Drawing.Point(4, 25)
        Me.tabpageCursos.Name = "tabpageCursos"
        Me.tabpageCursos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageCursos.Size = New System.Drawing.Size(752, 382)
        Me.tabpageCursos.TabIndex = 15
        Me.tabpageCursos.Text = "Cursos"
        Me.tabpageCursos.UseVisualStyleBackColor = True
        '
        'tabpageCalificaciones
        '
        Me.tabpageCalificaciones.Controls.Add(Me.datagridviewCalificaciones)
        Me.tabpageCalificaciones.Controls.Add(Me.toolstripCalificaciones)
        Me.tabpageCalificaciones.Location = New System.Drawing.Point(4, 25)
        Me.tabpageCalificaciones.Name = "tabpageCalificaciones"
        Me.tabpageCalificaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageCalificaciones.Size = New System.Drawing.Size(752, 382)
        Me.tabpageCalificaciones.TabIndex = 16
        Me.tabpageCalificaciones.Text = "Calificaciónes"
        Me.tabpageCalificaciones.UseVisualStyleBackColor = True
        '
        'datagridviewCalificaciones
        '
        Me.datagridviewCalificaciones.AllowUserToAddRows = False
        Me.datagridviewCalificaciones.AllowUserToDeleteRows = False
        Me.datagridviewCalificaciones.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewCalificaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.datagridviewCalificaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.datagridviewCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewCalificaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnAnioInstancia, Me.columnConceptosCalificaciones})
        Me.datagridviewCalificaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewCalificaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewCalificaciones.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewCalificaciones.MultiSelect = False
        Me.datagridviewCalificaciones.Name = "datagridviewCalificaciones"
        Me.datagridviewCalificaciones.ReadOnly = True
        Me.datagridviewCalificaciones.RowHeadersVisible = False
        Me.datagridviewCalificaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewCalificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewCalificaciones.Size = New System.Drawing.Size(659, 376)
        Me.datagridviewCalificaciones.TabIndex = 6
        '
        'columnAnioInstancia
        '
        Me.columnAnioInstancia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnAnioInstancia.DataPropertyName = "AnioInstancia"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.columnAnioInstancia.DefaultCellStyle = DataGridViewCellStyle8
        Me.columnAnioInstancia.HeaderText = "Año - Instancia"
        Me.columnAnioInstancia.Name = "columnAnioInstancia"
        Me.columnAnioInstancia.ReadOnly = True
        Me.columnAnioInstancia.Width = 95
        '
        'columnConceptosCalificaciones
        '
        Me.columnConceptosCalificaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnConceptosCalificaciones.DataPropertyName = "ConceptosCalificaciones"
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.columnConceptosCalificaciones.DefaultCellStyle = DataGridViewCellStyle9
        Me.columnConceptosCalificaciones.HeaderText = "Conceptos y Calificaciones"
        Me.columnConceptosCalificaciones.Name = "columnConceptosCalificaciones"
        Me.columnConceptosCalificaciones.ReadOnly = True
        Me.columnConceptosCalificaciones.Width = 145
        '
        'toolstripCalificaciones
        '
        Me.toolstripCalificaciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripCalificaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripCalificaciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCalificacinoes_Agregar, Me.buttonCalificacinoes_Editar, Me.buttonCalificacinoes_Eliminar})
        Me.toolstripCalificaciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripCalificaciones.Location = New System.Drawing.Point(3, 3)
        Me.toolstripCalificaciones.Name = "toolstripCalificaciones"
        Me.toolstripCalificaciones.Size = New System.Drawing.Size(87, 376)
        Me.toolstripCalificaciones.TabIndex = 7
        '
        'buttonCalificacinoes_Agregar
        '
        Me.buttonCalificacinoes_Agregar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonCalificacinoes_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonCalificacinoes_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCalificacinoes_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCalificacinoes_Agregar.Name = "buttonCalificacinoes_Agregar"
        Me.buttonCalificacinoes_Agregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonCalificacinoes_Agregar.Text = "Agregar"
        '
        'buttonCalificacinoes_Editar
        '
        Me.buttonCalificacinoes_Editar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonCalificacinoes_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonCalificacinoes_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCalificacinoes_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCalificacinoes_Editar.Name = "buttonCalificacinoes_Editar"
        Me.buttonCalificacinoes_Editar.Size = New System.Drawing.Size(84, 36)
        Me.buttonCalificacinoes_Editar.Text = "Editar"
        '
        'buttonCalificacinoes_Eliminar
        '
        Me.buttonCalificacinoes_Eliminar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonCalificacinoes_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonCalificacinoes_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCalificacinoes_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCalificacinoes_Eliminar.Name = "buttonCalificacinoes_Eliminar"
        Me.buttonCalificacinoes_Eliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonCalificacinoes_Eliminar.Text = "Eliminar"
        '
        'tabpageExamenes
        '
        Me.tabpageExamenes.Controls.Add(Me.datagridviewExamenes)
        Me.tabpageExamenes.Controls.Add(Me.toolstripExamenes)
        Me.tabpageExamenes.Location = New System.Drawing.Point(4, 25)
        Me.tabpageExamenes.Name = "tabpageExamenes"
        Me.tabpageExamenes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageExamenes.Size = New System.Drawing.Size(752, 382)
        Me.tabpageExamenes.TabIndex = 17
        Me.tabpageExamenes.Text = "Exámenes"
        Me.tabpageExamenes.UseVisualStyleBackColor = True
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(752, 382)
        Me.tabpageNotasAuditoria.TabIndex = 7
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(114, 311)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 3
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'labelEsActivo
        '
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(6, 311)
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
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(114, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.Size = New System.Drawing.Size(632, 299)
        Me.textboxNotas.TabIndex = 1
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 356)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 9
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 330)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 6
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 356)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 8
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 330)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 5
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 359)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 7
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 337)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 4
        labelCreacion.Text = "Creación:"
        '
        'datagridviewLicencias
        '
        Me.datagridviewLicencias.AllowUserToAddRows = False
        Me.datagridviewLicencias.AllowUserToDeleteRows = False
        Me.datagridviewLicencias.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewLicencias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.datagridviewLicencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewLicencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.datagridviewLicencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewLicencias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewLicencias.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewLicencias.MultiSelect = False
        Me.datagridviewLicencias.Name = "datagridviewLicencias"
        Me.datagridviewLicencias.ReadOnly = True
        Me.datagridviewLicencias.RowHeadersVisible = False
        Me.datagridviewLicencias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewLicencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewLicencias.Size = New System.Drawing.Size(659, 376)
        Me.datagridviewLicencias.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 62
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CargoNombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cargo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CargoJerarquiaNombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Jerarquía"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 77
        '
        'toolstripLicencias
        '
        Me.toolstripLicencias.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripLicencias.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripLicencias.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonLicencias_Agregar, Me.buttonLicencias_Editar, Me.buttonLicencias_Eliminar})
        Me.toolstripLicencias.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripLicencias.Location = New System.Drawing.Point(3, 3)
        Me.toolstripLicencias.Name = "toolstripLicencias"
        Me.toolstripLicencias.Size = New System.Drawing.Size(87, 376)
        Me.toolstripLicencias.TabIndex = 5
        '
        'buttonLicencias_Agregar
        '
        Me.buttonLicencias_Agregar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonLicencias_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonLicencias_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonLicencias_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonLicencias_Agregar.Name = "buttonLicencias_Agregar"
        Me.buttonLicencias_Agregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonLicencias_Agregar.Text = "Agregar"
        '
        'buttonLicencias_Editar
        '
        Me.buttonLicencias_Editar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonLicencias_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonLicencias_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonLicencias_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonLicencias_Editar.Name = "buttonLicencias_Editar"
        Me.buttonLicencias_Editar.Size = New System.Drawing.Size(84, 36)
        Me.buttonLicencias_Editar.Text = "Editar"
        '
        'buttonLicencias_Eliminar
        '
        Me.buttonLicencias_Eliminar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonLicencias_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonLicencias_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonLicencias_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonLicencias_Eliminar.Name = "buttonLicencias_Eliminar"
        Me.buttonLicencias_Eliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonLicencias_Eliminar.Text = "Eliminar"
        '
        'datagridviewSanciones
        '
        Me.datagridviewSanciones.AllowUserToAddRows = False
        Me.datagridviewSanciones.AllowUserToDeleteRows = False
        Me.datagridviewSanciones.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewSanciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datagridviewSanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewSanciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.datagridviewSanciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewSanciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewSanciones.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewSanciones.MultiSelect = False
        Me.datagridviewSanciones.Name = "datagridviewSanciones"
        Me.datagridviewSanciones.ReadOnly = True
        Me.datagridviewSanciones.RowHeadersVisible = False
        Me.datagridviewSanciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewSanciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewSanciones.Size = New System.Drawing.Size(659, 376)
        Me.datagridviewSanciones.TabIndex = 6
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 62
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CargoNombre"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cargo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CargoJerarquiaNombre"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Jerarquía"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 77
        '
        'toolstripSanciones
        '
        Me.toolstripSanciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripSanciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripSanciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonSanciones_Agregar, Me.buttonSanciones_Editar, Me.buttonSanciones_Eliminar})
        Me.toolstripSanciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripSanciones.Location = New System.Drawing.Point(3, 3)
        Me.toolstripSanciones.Name = "toolstripSanciones"
        Me.toolstripSanciones.Size = New System.Drawing.Size(87, 376)
        Me.toolstripSanciones.TabIndex = 7
        '
        'buttonSanciones_Agregar
        '
        Me.buttonSanciones_Agregar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonSanciones_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonSanciones_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonSanciones_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonSanciones_Agregar.Name = "buttonSanciones_Agregar"
        Me.buttonSanciones_Agregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonSanciones_Agregar.Text = "Agregar"
        '
        'buttonSanciones_Editar
        '
        Me.buttonSanciones_Editar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonSanciones_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonSanciones_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonSanciones_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonSanciones_Editar.Name = "buttonSanciones_Editar"
        Me.buttonSanciones_Editar.Size = New System.Drawing.Size(84, 36)
        Me.buttonSanciones_Editar.Text = "Editar"
        '
        'buttonSanciones_Eliminar
        '
        Me.buttonSanciones_Eliminar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonSanciones_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonSanciones_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonSanciones_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonSanciones_Eliminar.Name = "buttonSanciones_Eliminar"
        Me.buttonSanciones_Eliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonSanciones_Eliminar.Text = "Eliminar"
        '
        'datagridviewCursos
        '
        Me.datagridviewCursos.AllowUserToAddRows = False
        Me.datagridviewCursos.AllowUserToDeleteRows = False
        Me.datagridviewCursos.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewCursos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.datagridviewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewCursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.datagridviewCursos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewCursos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewCursos.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewCursos.MultiSelect = False
        Me.datagridviewCursos.Name = "datagridviewCursos"
        Me.datagridviewCursos.ReadOnly = True
        Me.datagridviewCursos.RowHeadersVisible = False
        Me.datagridviewCursos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewCursos.Size = New System.Drawing.Size(659, 376)
        Me.datagridviewCursos.TabIndex = 6
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 62
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CargoNombre"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cargo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 60
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CargoJerarquiaNombre"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Jerarquía"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 77
        '
        'toolstripCursos
        '
        Me.toolstripCursos.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripCursos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripCursos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCursos_Agregar, Me.buttonCursos_Editar, Me.buttonCursos_Eliminar})
        Me.toolstripCursos.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripCursos.Location = New System.Drawing.Point(3, 3)
        Me.toolstripCursos.Name = "toolstripCursos"
        Me.toolstripCursos.Size = New System.Drawing.Size(87, 376)
        Me.toolstripCursos.TabIndex = 7
        '
        'buttonCursos_Agregar
        '
        Me.buttonCursos_Agregar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonCursos_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonCursos_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCursos_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCursos_Agregar.Name = "buttonCursos_Agregar"
        Me.buttonCursos_Agregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonCursos_Agregar.Text = "Agregar"
        '
        'buttonCursos_Editar
        '
        Me.buttonCursos_Editar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonCursos_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonCursos_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCursos_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCursos_Editar.Name = "buttonCursos_Editar"
        Me.buttonCursos_Editar.Size = New System.Drawing.Size(84, 36)
        Me.buttonCursos_Editar.Text = "Editar"
        '
        'buttonCursos_Eliminar
        '
        Me.buttonCursos_Eliminar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonCursos_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonCursos_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCursos_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCursos_Eliminar.Name = "buttonCursos_Eliminar"
        Me.buttonCursos_Eliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonCursos_Eliminar.Text = "Eliminar"
        '
        'datagridviewExamenes
        '
        Me.datagridviewExamenes.AllowUserToAddRows = False
        Me.datagridviewExamenes.AllowUserToDeleteRows = False
        Me.datagridviewExamenes.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewExamenes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.datagridviewExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewExamenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.datagridviewExamenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewExamenes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewExamenes.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewExamenes.MultiSelect = False
        Me.datagridviewExamenes.Name = "datagridviewExamenes"
        Me.datagridviewExamenes.ReadOnly = True
        Me.datagridviewExamenes.RowHeadersVisible = False
        Me.datagridviewExamenes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewExamenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewExamenes.Size = New System.Drawing.Size(659, 376)
        Me.datagridviewExamenes.TabIndex = 6
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 62
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CargoNombre"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Cargo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 60
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CargoJerarquiaNombre"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Jerarquía"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 77
        '
        'toolstripExamenes
        '
        Me.toolstripExamenes.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripExamenes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripExamenes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonExamenes_Agregar, Me.buttonExamenes_Editar, Me.buttonExamenes_Eliminar})
        Me.toolstripExamenes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripExamenes.Location = New System.Drawing.Point(3, 3)
        Me.toolstripExamenes.Name = "toolstripExamenes"
        Me.toolstripExamenes.Size = New System.Drawing.Size(87, 376)
        Me.toolstripExamenes.TabIndex = 7
        '
        'buttonExamenes_Agregar
        '
        Me.buttonExamenes_Agregar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonExamenes_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonExamenes_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonExamenes_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonExamenes_Agregar.Name = "buttonExamenes_Agregar"
        Me.buttonExamenes_Agregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonExamenes_Agregar.Text = "Agregar"
        '
        'buttonExamenes_Editar
        '
        Me.buttonExamenes_Editar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonExamenes_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonExamenes_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonExamenes_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonExamenes_Editar.Name = "buttonExamenes_Editar"
        Me.buttonExamenes_Editar.Size = New System.Drawing.Size(84, 36)
        Me.buttonExamenes_Editar.Text = "Editar"
        '
        'buttonExamenes_Eliminar
        '
        Me.buttonExamenes_Eliminar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonExamenes_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonExamenes_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonExamenes_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonExamenes_Eliminar.Name = "buttonExamenes_Eliminar"
        Me.buttonExamenes_Eliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonExamenes_Eliminar.Text = "Eliminar"
        '
        'formPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.toolstripMain)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.pictureboxFoto)
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
        CType(Me.pictureboxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menustripFoto.ResumeLayout(False)
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
        Me.tabpageAltasBajas.ResumeLayout(False)
        Me.tabpageAltasBajas.PerformLayout()
        CType(Me.datagridviewAltasBajas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripAltasBajas.ResumeLayout(False)
        Me.toolstripAltasBajas.PerformLayout()
        Me.tabpageAscensos.ResumeLayout(False)
        Me.tabpageAscensos.PerformLayout()
        CType(Me.datagridviewAscensos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripAscensos.ResumeLayout(False)
        Me.toolstripAscensos.PerformLayout()
        Me.tabpageLicencias.ResumeLayout(False)
        Me.tabpageLicencias.PerformLayout()
        Me.tabpageSanciones.ResumeLayout(False)
        Me.tabpageSanciones.PerformLayout()
        Me.tabpageCursos.ResumeLayout(False)
        Me.tabpageCursos.PerformLayout()
        Me.tabpageCalificaciones.ResumeLayout(False)
        Me.tabpageCalificaciones.PerformLayout()
        CType(Me.datagridviewCalificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripCalificaciones.ResumeLayout(False)
        Me.toolstripCalificaciones.PerformLayout()
        Me.tabpageExamenes.ResumeLayout(False)
        Me.tabpageExamenes.PerformLayout()
        Me.tabpageNotasAuditoria.ResumeLayout(False)
        Me.tabpageNotasAuditoria.PerformLayout()
        CType(Me.datagridviewLicencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripLicencias.ResumeLayout(False)
        Me.toolstripLicencias.PerformLayout()
        CType(Me.datagridviewSanciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripSanciones.ResumeLayout(False)
        Me.toolstripSanciones.PerformLayout()
        CType(Me.datagridviewCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripCursos.ResumeLayout(False)
        Me.toolstripCursos.PerformLayout()
        CType(Me.datagridviewExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripExamenes.ResumeLayout(False)
        Me.toolstripExamenes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textboxApellido As System.Windows.Forms.TextBox
    Friend WithEvents textboxIDPersona As System.Windows.Forms.TextBox
    Friend WithEvents textboxNombre As System.Windows.Forms.TextBox
    Friend WithEvents pictureboxFoto As System.Windows.Forms.PictureBox
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
    Friend WithEvents comboboxIOMATiene As System.Windows.Forms.ComboBox
    Friend WithEvents buttonLicenciaConducirNumero As System.Windows.Forms.Button
    Friend WithEvents textboxLicenciaConducirNumero As System.Windows.Forms.TextBox
    Friend WithEvents datetimepickerLicenciaConducirVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents menustripFoto As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menuitemFotoSeleccionarImagen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemFotoEliminarImagen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents textboxIOMANumeroAfiliado As System.Windows.Forms.TextBox
    Friend WithEvents openfiledialogFoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents textboxCargoJerarquiaActual As System.Windows.Forms.TextBox
    Friend WithEvents textboxCantidadHijos As System.Windows.Forms.TextBox
    Friend WithEvents tabpageAltasBajas As System.Windows.Forms.TabPage
    Friend WithEvents datagridviewAltasBajas As System.Windows.Forms.DataGridView
    Friend WithEvents toolstripAltasBajas As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonAltasBajas_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonAltasBajas_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonAltasBajas_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents columnAltasBajas_AltaFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnAltasBajas_BajaFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnaltasBajas_BajaMotivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabpageAscensos As System.Windows.Forms.TabPage
    Friend WithEvents tabpageLicencias As System.Windows.Forms.TabPage
    Friend WithEvents tabpageSanciones As System.Windows.Forms.TabPage
    Friend WithEvents tabpageCursos As System.Windows.Forms.TabPage
    Friend WithEvents tabpageCalificaciones As System.Windows.Forms.TabPage
    Friend WithEvents tabpageExamenes As System.Windows.Forms.TabPage
    Friend WithEvents datagridviewAscensos As System.Windows.Forms.DataGridView
    Friend WithEvents columnFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnJerarquia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents toolstripAscensos As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonAscensos_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonAscensos_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonAscensos_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents datagridviewCalificaciones As System.Windows.Forms.DataGridView
    Friend WithEvents columnAnioInstancia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnConceptosCalificaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents toolstripCalificaciones As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCalificacinoes_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCalificacinoes_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCalificacinoes_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents datagridviewLicencias As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents toolstripLicencias As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonLicencias_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonLicencias_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonLicencias_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents datagridviewSanciones As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents toolstripSanciones As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonSanciones_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonSanciones_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonSanciones_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents datagridviewCursos As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents toolstripCursos As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCursos_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCursos_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCursos_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents datagridviewExamenes As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents toolstripExamenes As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonExamenes_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonExamenes_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonExamenes_Eliminar As System.Windows.Forms.ToolStripButton
End Class
