<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSancion
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
        Dim labelSolicitudMotivo As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim labelSolicitudPersona As System.Windows.Forms.Label
        Dim labelResolucionNumero As System.Windows.Forms.Label
        Dim labelResolucionSancionTipo As System.Windows.Forms.Label
        Dim labelPersona As System.Windows.Forms.Label
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.datetimepickerSolicitudFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.tabcontrolMain = New System.Windows.Forms.TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.controlpersonaAplicar = New CSBomberos.ControlPersona()
        Me.groupboxEncuadre = New System.Windows.Forms.GroupBox()
        Me.datetimepickerEncuadreFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelEncuadreTexto = New System.Windows.Forms.Label()
        Me.textboxEncuadreTexto = New System.Windows.Forms.TextBox()
        Me.labelEncuadreFecha = New System.Windows.Forms.Label()
        Me.groupboxSolicitud = New System.Windows.Forms.GroupBox()
        Me.controlpersonaSolicitud = New CSBomberos.ControlPersona()
        Me.textboxSolicitudPersonaTexto = New System.Windows.Forms.TextBox()
        Me.comboboxSolicitudResponsableTipo = New System.Windows.Forms.ComboBox()
        Me.comboboxSancionMotivo = New System.Windows.Forms.ComboBox()
        Me.checkboxObtenerTextos = New System.Windows.Forms.CheckBox()
        Me.buttonAplicarTextos = New System.Windows.Forms.Button()
        Me.textboxSolicitudMotivo = New System.Windows.Forms.TextBox()
        Me.tabpageResolucion = New System.Windows.Forms.TabPage()
        Me.groupboxTestimonio = New System.Windows.Forms.GroupBox()
        Me.datetimepickerTestimonioFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelTestimonioFecha = New System.Windows.Forms.Label()
        Me.labelTestimonioTexto = New System.Windows.Forms.Label()
        Me.textboxTestimonioTexto = New System.Windows.Forms.TextBox()
        Me.groupboxNotificacion = New System.Windows.Forms.GroupBox()
        Me.datetimepickerNotificacionFechaEfectiva = New System.Windows.Forms.DateTimePicker()
        Me.labelNotificacionFechaEfectiva = New System.Windows.Forms.Label()
        Me.datetimepickerNotificacionFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelNotificacionFecha = New System.Windows.Forms.Label()
        Me.groupboxResolucion = New System.Windows.Forms.GroupBox()
        Me.labelDesaprobadaCausa = New System.Windows.Forms.Label()
        Me.textboxDesaprobadaCausa = New System.Windows.Forms.TextBox()
        Me.radiobuttonEstadoDesaprobada = New System.Windows.Forms.RadioButton()
        Me.radiobuttonEstadoAprobada = New System.Windows.Forms.RadioButton()
        Me.radiobuttonEstadoEnProceso = New System.Windows.Forms.RadioButton()
        Me.textboxResolucionNumero = New System.Windows.Forms.TextBox()
        Me.comboboxResolucionSancionTipo = New System.Windows.Forms.ComboBox()
        Me.datetimepickerResolucionFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelResolucionFecha = New System.Windows.Forms.Label()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.labelIDSancion = New System.Windows.Forms.Label()
        Me.textboxIDSancion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        labelSolicitudMotivo = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelSolicitudPersona = New System.Windows.Forms.Label()
        labelResolucionNumero = New System.Windows.Forms.Label()
        labelResolucionSancionTipo = New System.Windows.Forms.Label()
        labelPersona = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.groupboxEncuadre.SuspendLayout()
        Me.groupboxSolicitud.SuspendLayout()
        Me.tabpageResolucion.SuspendLayout()
        Me.groupboxTestimonio.SuspendLayout()
        Me.groupboxNotificacion.SuspendLayout()
        Me.groupboxResolucion.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelSolicitudMotivo
        '
        labelSolicitudMotivo.AutoSize = True
        labelSolicitudMotivo.Location = New System.Drawing.Point(8, 150)
        labelSolicitudMotivo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        labelSolicitudMotivo.Name = "labelSolicitudMotivo"
        labelSolicitudMotivo.Size = New System.Drawing.Size(50, 16)
        labelSolicitudMotivo.TabIndex = 6
        labelSolicitudMotivo.Text = "Motivo:"
        '
        'labelModificacion
        '
        labelModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(8, 455)
        labelModificacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(127, 16)
        labelModificacion.TabIndex = 21
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(8, 423)
        labelCreacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(64, 16)
        labelCreacion.TabIndex = 18
        labelCreacion.Text = "Creación:"
        '
        'labelSolicitudPersona
        '
        labelSolicitudPersona.AutoSize = True
        labelSolicitudPersona.Location = New System.Drawing.Point(8, 27)
        labelSolicitudPersona.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        labelSolicitudPersona.Name = "labelSolicitudPersona"
        labelSolicitudPersona.Size = New System.Drawing.Size(31, 16)
        labelSolicitudPersona.TabIndex = 0
        labelSolicitudPersona.Text = "Por:"
        '
        'labelResolucionNumero
        '
        labelResolucionNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelResolucionNumero.AutoSize = True
        labelResolucionNumero.Location = New System.Drawing.Point(307, 197)
        labelResolucionNumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        labelResolucionNumero.Name = "labelResolucionNumero"
        labelResolucionNumero.Size = New System.Drawing.Size(96, 16)
        labelResolucionNumero.TabIndex = 9
        labelResolucionNumero.Text = "Resolución Nº:"
        '
        'labelResolucionSancionTipo
        '
        labelResolucionSancionTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelResolucionSancionTipo.AutoSize = True
        labelResolucionSancionTipo.Location = New System.Drawing.Point(8, 160)
        labelResolucionSancionTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        labelResolucionSancionTipo.Name = "labelResolucionSancionTipo"
        labelResolucionSancionTipo.Size = New System.Drawing.Size(38, 16)
        labelResolucionSancionTipo.TabIndex = 5
        labelResolucionSancionTipo.Text = "Tipo:"
        '
        'labelPersona
        '
        labelPersona.AutoSize = True
        labelPersona.Location = New System.Drawing.Point(16, 11)
        labelPersona.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        labelPersona.Name = "labelPersona"
        labelPersona.Size = New System.Drawing.Size(63, 16)
        labelPersona.TabIndex = 0
        labelPersona.Text = "Aplicar a:"
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = Global.CSBomberos.My.Resources.Resources.ImageAceptar32
        Me.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(98, 36)
        Me.buttonGuardar.Text = "Guardar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.CSBomberos.My.Resources.Resources.ImageCancelar32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(102, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.CSBomberos.My.Resources.Resources.ImageEditar32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(84, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSBomberos.My.Resources.Resources.ImageCerrar32
        Me.buttonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCerrar.Name = "buttonCerrar"
        Me.buttonCerrar.Size = New System.Drawing.Size(85, 36)
        Me.buttonCerrar.Text = "Cerrar"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(723, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'datetimepickerSolicitudFecha
        '
        Me.datetimepickerSolicitudFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.datetimepickerSolicitudFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerSolicitudFecha.Location = New System.Drawing.Point(83, 266)
        Me.datetimepickerSolicitudFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datetimepickerSolicitudFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerSolicitudFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerSolicitudFecha.Name = "datetimepickerSolicitudFecha"
        Me.datetimepickerSolicitudFecha.Size = New System.Drawing.Size(153, 22)
        Me.datetimepickerSolicitudFecha.TabIndex = 12
        '
        'labelFecha
        '
        Me.labelFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(8, 270)
        Me.labelFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(48, 16)
        Me.labelFecha.TabIndex = 11
        Me.labelFecha.Text = "Fecha:"
        '
        'textboxNotas
        '
        Me.textboxNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxNotas.Location = New System.Drawing.Point(152, 7)
        Me.textboxNotas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(513, 372)
        Me.textboxNotas.TabIndex = 15
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(8, 11)
        Me.labelNotas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(46, 16)
        Me.labelNotas.TabIndex = 14
        Me.labelNotas.Text = "Notas:"
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageResolucion)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(16, 52)
        Me.tabcontrolMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(691, 534)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.controlpersonaAplicar)
        Me.tabpageGeneral.Controls.Add(labelPersona)
        Me.tabpageGeneral.Controls.Add(Me.groupboxEncuadre)
        Me.tabpageGeneral.Controls.Add(Me.groupboxSolicitud)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 28)
        Me.tabpageGeneral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabpageGeneral.Size = New System.Drawing.Size(683, 502)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'controlpersonaAplicar
        '
        Me.controlpersonaAplicar.ApellidoNombre = Nothing
        Me.controlpersonaAplicar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.controlpersonaAplicar.dbContext = Nothing
        Me.controlpersonaAplicar.IDCuartel = Nothing
        Me.controlpersonaAplicar.IDPersona = Nothing
        Me.controlpersonaAplicar.Location = New System.Drawing.Point(91, 7)
        Me.controlpersonaAplicar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.controlpersonaAplicar.MatriculaNumeroDigitos = Nothing
        Me.controlpersonaAplicar.MaximumSize = New System.Drawing.Size(1333, 26)
        Me.controlpersonaAplicar.MinimumSize = New System.Drawing.Size(200, 26)
        Me.controlpersonaAplicar.Name = "controlpersonaAplicar"
        Me.controlpersonaAplicar.ReadOnlyText = False
        Me.controlpersonaAplicar.Size = New System.Drawing.Size(573, 26)
        Me.controlpersonaAplicar.SoloMostrarEnAsistencia = False
        Me.controlpersonaAplicar.SoloMostrarEstadoActivo = True
        Me.controlpersonaAplicar.TabIndex = 1
        '
        'groupboxEncuadre
        '
        Me.groupboxEncuadre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupboxEncuadre.Controls.Add(Me.datetimepickerEncuadreFecha)
        Me.groupboxEncuadre.Controls.Add(Me.labelEncuadreTexto)
        Me.groupboxEncuadre.Controls.Add(Me.textboxEncuadreTexto)
        Me.groupboxEncuadre.Controls.Add(Me.labelEncuadreFecha)
        Me.groupboxEncuadre.Location = New System.Drawing.Point(8, 345)
        Me.groupboxEncuadre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxEncuadre.Name = "groupboxEncuadre"
        Me.groupboxEncuadre.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxEncuadre.Size = New System.Drawing.Size(664, 144)
        Me.groupboxEncuadre.TabIndex = 5
        Me.groupboxEncuadre.TabStop = False
        Me.groupboxEncuadre.Text = "Encuadre:"
        '
        'datetimepickerEncuadreFecha
        '
        Me.datetimepickerEncuadreFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.datetimepickerEncuadreFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerEncuadreFecha.Location = New System.Drawing.Point(83, 111)
        Me.datetimepickerEncuadreFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datetimepickerEncuadreFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerEncuadreFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerEncuadreFecha.Name = "datetimepickerEncuadreFecha"
        Me.datetimepickerEncuadreFecha.ShowCheckBox = True
        Me.datetimepickerEncuadreFecha.Size = New System.Drawing.Size(183, 22)
        Me.datetimepickerEncuadreFecha.TabIndex = 3
        '
        'labelEncuadreTexto
        '
        Me.labelEncuadreTexto.AutoSize = True
        Me.labelEncuadreTexto.Location = New System.Drawing.Point(8, 27)
        Me.labelEncuadreTexto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelEncuadreTexto.Name = "labelEncuadreTexto"
        Me.labelEncuadreTexto.Size = New System.Drawing.Size(44, 16)
        Me.labelEncuadreTexto.TabIndex = 0
        Me.labelEncuadreTexto.Text = "Texto:"
        '
        'textboxEncuadreTexto
        '
        Me.textboxEncuadreTexto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxEncuadreTexto.Location = New System.Drawing.Point(83, 23)
        Me.textboxEncuadreTexto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxEncuadreTexto.MaxLength = 0
        Me.textboxEncuadreTexto.Multiline = True
        Me.textboxEncuadreTexto.Name = "textboxEncuadreTexto"
        Me.textboxEncuadreTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxEncuadreTexto.Size = New System.Drawing.Size(572, 79)
        Me.textboxEncuadreTexto.TabIndex = 1
        '
        'labelEncuadreFecha
        '
        Me.labelEncuadreFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelEncuadreFecha.AutoSize = True
        Me.labelEncuadreFecha.Location = New System.Drawing.Point(8, 114)
        Me.labelEncuadreFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelEncuadreFecha.Name = "labelEncuadreFecha"
        Me.labelEncuadreFecha.Size = New System.Drawing.Size(48, 16)
        Me.labelEncuadreFecha.TabIndex = 2
        Me.labelEncuadreFecha.Text = "Fecha:"
        '
        'groupboxSolicitud
        '
        Me.groupboxSolicitud.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupboxSolicitud.Controls.Add(Me.controlpersonaSolicitud)
        Me.groupboxSolicitud.Controls.Add(Me.textboxSolicitudPersonaTexto)
        Me.groupboxSolicitud.Controls.Add(Me.comboboxSolicitudResponsableTipo)
        Me.groupboxSolicitud.Controls.Add(Me.comboboxSancionMotivo)
        Me.groupboxSolicitud.Controls.Add(Me.checkboxObtenerTextos)
        Me.groupboxSolicitud.Controls.Add(Me.buttonAplicarTextos)
        Me.groupboxSolicitud.Controls.Add(Me.textboxSolicitudMotivo)
        Me.groupboxSolicitud.Controls.Add(labelSolicitudPersona)
        Me.groupboxSolicitud.Controls.Add(Me.datetimepickerSolicitudFecha)
        Me.groupboxSolicitud.Controls.Add(Me.labelFecha)
        Me.groupboxSolicitud.Controls.Add(labelSolicitudMotivo)
        Me.groupboxSolicitud.Location = New System.Drawing.Point(8, 39)
        Me.groupboxSolicitud.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxSolicitud.Name = "groupboxSolicitud"
        Me.groupboxSolicitud.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxSolicitud.Size = New System.Drawing.Size(664, 298)
        Me.groupboxSolicitud.TabIndex = 4
        Me.groupboxSolicitud.TabStop = False
        Me.groupboxSolicitud.Text = "Solicitud:"
        '
        'controlpersonaSolicitud
        '
        Me.controlpersonaSolicitud.ApellidoNombre = Nothing
        Me.controlpersonaSolicitud.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.controlpersonaSolicitud.dbContext = Nothing
        Me.controlpersonaSolicitud.IDCuartel = Nothing
        Me.controlpersonaSolicitud.IDPersona = Nothing
        Me.controlpersonaSolicitud.Location = New System.Drawing.Point(83, 57)
        Me.controlpersonaSolicitud.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.controlpersonaSolicitud.MatriculaNumeroDigitos = Nothing
        Me.controlpersonaSolicitud.MaximumSize = New System.Drawing.Size(1333, 26)
        Me.controlpersonaSolicitud.MinimumSize = New System.Drawing.Size(200, 26)
        Me.controlpersonaSolicitud.Name = "controlpersonaSolicitud"
        Me.controlpersonaSolicitud.ReadOnlyText = True
        Me.controlpersonaSolicitud.Size = New System.Drawing.Size(563, 26)
        Me.controlpersonaSolicitud.SoloMostrarEnAsistencia = False
        Me.controlpersonaSolicitud.SoloMostrarEstadoActivo = True
        Me.controlpersonaSolicitud.TabIndex = 2
        '
        'textboxSolicitudPersonaTexto
        '
        Me.textboxSolicitudPersonaTexto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxSolicitudPersonaTexto.Location = New System.Drawing.Point(83, 89)
        Me.textboxSolicitudPersonaTexto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxSolicitudPersonaTexto.MaxLength = 0
        Me.textboxSolicitudPersonaTexto.Multiline = True
        Me.textboxSolicitudPersonaTexto.Name = "textboxSolicitudPersonaTexto"
        Me.textboxSolicitudPersonaTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxSolicitudPersonaTexto.Size = New System.Drawing.Size(572, 47)
        Me.textboxSolicitudPersonaTexto.TabIndex = 5
        '
        'comboboxSolicitudResponsableTipo
        '
        Me.comboboxSolicitudResponsableTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxSolicitudResponsableTipo.DropDownWidth = 338
        Me.comboboxSolicitudResponsableTipo.FormattingEnabled = True
        Me.comboboxSolicitudResponsableTipo.Location = New System.Drawing.Point(83, 23)
        Me.comboboxSolicitudResponsableTipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.comboboxSolicitudResponsableTipo.Name = "comboboxSolicitudResponsableTipo"
        Me.comboboxSolicitudResponsableTipo.Size = New System.Drawing.Size(572, 24)
        Me.comboboxSolicitudResponsableTipo.TabIndex = 1
        '
        'comboboxSancionMotivo
        '
        Me.comboboxSancionMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxSancionMotivo.DropDownWidth = 338
        Me.comboboxSancionMotivo.FormattingEnabled = True
        Me.comboboxSancionMotivo.Location = New System.Drawing.Point(205, 145)
        Me.comboboxSancionMotivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.comboboxSancionMotivo.Name = "comboboxSancionMotivo"
        Me.comboboxSancionMotivo.Size = New System.Drawing.Size(323, 24)
        Me.comboboxSancionMotivo.TabIndex = 8
        Me.comboboxSancionMotivo.Visible = False
        '
        'checkboxObtenerTextos
        '
        Me.checkboxObtenerTextos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxObtenerTextos.AutoSize = True
        Me.checkboxObtenerTextos.Location = New System.Drawing.Point(83, 144)
        Me.checkboxObtenerTextos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkboxObtenerTextos.Name = "checkboxObtenerTextos"
        Me.checkboxObtenerTextos.Size = New System.Drawing.Size(103, 26)
        Me.checkboxObtenerTextos.TabIndex = 7
        Me.checkboxObtenerTextos.Text = "Obtener textos"
        Me.checkboxObtenerTextos.UseVisualStyleBackColor = True
        '
        'buttonAplicarTextos
        '
        Me.buttonAplicarTextos.Location = New System.Drawing.Point(537, 144)
        Me.buttonAplicarTextos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonAplicarTextos.Name = "buttonAplicarTextos"
        Me.buttonAplicarTextos.Size = New System.Drawing.Size(119, 28)
        Me.buttonAplicarTextos.TabIndex = 9
        Me.buttonAplicarTextos.Text = "Aplicar textos"
        Me.buttonAplicarTextos.UseVisualStyleBackColor = True
        Me.buttonAplicarTextos.Visible = False
        '
        'textboxSolicitudMotivo
        '
        Me.textboxSolicitudMotivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxSolicitudMotivo.Location = New System.Drawing.Point(83, 180)
        Me.textboxSolicitudMotivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxSolicitudMotivo.MaxLength = 0
        Me.textboxSolicitudMotivo.Multiline = True
        Me.textboxSolicitudMotivo.Name = "textboxSolicitudMotivo"
        Me.textboxSolicitudMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxSolicitudMotivo.Size = New System.Drawing.Size(572, 78)
        Me.textboxSolicitudMotivo.TabIndex = 10
        '
        'tabpageResolucion
        '
        Me.tabpageResolucion.Controls.Add(Me.groupboxTestimonio)
        Me.tabpageResolucion.Controls.Add(Me.groupboxNotificacion)
        Me.tabpageResolucion.Controls.Add(Me.groupboxResolucion)
        Me.tabpageResolucion.Location = New System.Drawing.Point(4, 28)
        Me.tabpageResolucion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabpageResolucion.Name = "tabpageResolucion"
        Me.tabpageResolucion.Size = New System.Drawing.Size(683, 502)
        Me.tabpageResolucion.TabIndex = 2
        Me.tabpageResolucion.Text = "Resolución y testimonio"
        Me.tabpageResolucion.UseVisualStyleBackColor = True
        '
        'groupboxTestimonio
        '
        Me.groupboxTestimonio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupboxTestimonio.Controls.Add(Me.datetimepickerTestimonioFecha)
        Me.groupboxTestimonio.Controls.Add(Me.labelTestimonioFecha)
        Me.groupboxTestimonio.Controls.Add(Me.labelTestimonioTexto)
        Me.groupboxTestimonio.Controls.Add(Me.textboxTestimonioTexto)
        Me.groupboxTestimonio.Location = New System.Drawing.Point(8, 310)
        Me.groupboxTestimonio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxTestimonio.Name = "groupboxTestimonio"
        Me.groupboxTestimonio.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxTestimonio.Size = New System.Drawing.Size(664, 182)
        Me.groupboxTestimonio.TabIndex = 2
        Me.groupboxTestimonio.TabStop = False
        Me.groupboxTestimonio.Text = "Testimonio:"
        '
        'datetimepickerTestimonioFecha
        '
        Me.datetimepickerTestimonioFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.datetimepickerTestimonioFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerTestimonioFecha.Location = New System.Drawing.Point(83, 150)
        Me.datetimepickerTestimonioFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datetimepickerTestimonioFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerTestimonioFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerTestimonioFecha.Name = "datetimepickerTestimonioFecha"
        Me.datetimepickerTestimonioFecha.ShowCheckBox = True
        Me.datetimepickerTestimonioFecha.Size = New System.Drawing.Size(183, 22)
        Me.datetimepickerTestimonioFecha.TabIndex = 3
        '
        'labelTestimonioFecha
        '
        Me.labelTestimonioFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelTestimonioFecha.AutoSize = True
        Me.labelTestimonioFecha.Location = New System.Drawing.Point(8, 154)
        Me.labelTestimonioFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelTestimonioFecha.Name = "labelTestimonioFecha"
        Me.labelTestimonioFecha.Size = New System.Drawing.Size(48, 16)
        Me.labelTestimonioFecha.TabIndex = 2
        Me.labelTestimonioFecha.Text = "Fecha:"
        '
        'labelTestimonioTexto
        '
        Me.labelTestimonioTexto.AutoSize = True
        Me.labelTestimonioTexto.Location = New System.Drawing.Point(8, 27)
        Me.labelTestimonioTexto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelTestimonioTexto.Name = "labelTestimonioTexto"
        Me.labelTestimonioTexto.Size = New System.Drawing.Size(44, 16)
        Me.labelTestimonioTexto.TabIndex = 0
        Me.labelTestimonioTexto.Text = "Texto:"
        '
        'textboxTestimonioTexto
        '
        Me.textboxTestimonioTexto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxTestimonioTexto.Location = New System.Drawing.Point(83, 23)
        Me.textboxTestimonioTexto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxTestimonioTexto.MaxLength = 0
        Me.textboxTestimonioTexto.Multiline = True
        Me.textboxTestimonioTexto.Name = "textboxTestimonioTexto"
        Me.textboxTestimonioTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxTestimonioTexto.Size = New System.Drawing.Size(572, 118)
        Me.textboxTestimonioTexto.TabIndex = 1
        '
        'groupboxNotificacion
        '
        Me.groupboxNotificacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupboxNotificacion.Controls.Add(Me.datetimepickerNotificacionFechaEfectiva)
        Me.groupboxNotificacion.Controls.Add(Me.labelNotificacionFechaEfectiva)
        Me.groupboxNotificacion.Controls.Add(Me.datetimepickerNotificacionFecha)
        Me.groupboxNotificacion.Controls.Add(Me.labelNotificacionFecha)
        Me.groupboxNotificacion.Location = New System.Drawing.Point(8, 242)
        Me.groupboxNotificacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxNotificacion.Name = "groupboxNotificacion"
        Me.groupboxNotificacion.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxNotificacion.Size = New System.Drawing.Size(664, 60)
        Me.groupboxNotificacion.TabIndex = 1
        Me.groupboxNotificacion.TabStop = False
        Me.groupboxNotificacion.Text = "Notificación:"
        '
        'datetimepickerNotificacionFechaEfectiva
        '
        Me.datetimepickerNotificacionFechaEfectiva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerNotificacionFechaEfectiva.Location = New System.Drawing.Point(423, 23)
        Me.datetimepickerNotificacionFechaEfectiva.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datetimepickerNotificacionFechaEfectiva.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerNotificacionFechaEfectiva.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerNotificacionFechaEfectiva.Name = "datetimepickerNotificacionFechaEfectiva"
        Me.datetimepickerNotificacionFechaEfectiva.ShowCheckBox = True
        Me.datetimepickerNotificacionFechaEfectiva.Size = New System.Drawing.Size(183, 22)
        Me.datetimepickerNotificacionFechaEfectiva.TabIndex = 3
        '
        'labelNotificacionFechaEfectiva
        '
        Me.labelNotificacionFechaEfectiva.AutoSize = True
        Me.labelNotificacionFechaEfectiva.Location = New System.Drawing.Point(307, 27)
        Me.labelNotificacionFechaEfectiva.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNotificacionFechaEfectiva.Name = "labelNotificacionFechaEfectiva"
        Me.labelNotificacionFechaEfectiva.Size = New System.Drawing.Size(98, 16)
        Me.labelNotificacionFechaEfectiva.TabIndex = 2
        Me.labelNotificacionFechaEfectiva.Text = "Fecha efectiva:"
        '
        'datetimepickerNotificacionFecha
        '
        Me.datetimepickerNotificacionFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerNotificacionFecha.Location = New System.Drawing.Point(83, 23)
        Me.datetimepickerNotificacionFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datetimepickerNotificacionFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerNotificacionFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerNotificacionFecha.Name = "datetimepickerNotificacionFecha"
        Me.datetimepickerNotificacionFecha.ShowCheckBox = True
        Me.datetimepickerNotificacionFecha.Size = New System.Drawing.Size(183, 22)
        Me.datetimepickerNotificacionFecha.TabIndex = 1
        '
        'labelNotificacionFecha
        '
        Me.labelNotificacionFecha.AutoSize = True
        Me.labelNotificacionFecha.Location = New System.Drawing.Point(8, 27)
        Me.labelNotificacionFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNotificacionFecha.Name = "labelNotificacionFecha"
        Me.labelNotificacionFecha.Size = New System.Drawing.Size(48, 16)
        Me.labelNotificacionFecha.TabIndex = 0
        Me.labelNotificacionFecha.Text = "Fecha:"
        '
        'groupboxResolucion
        '
        Me.groupboxResolucion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupboxResolucion.Controls.Add(Me.labelDesaprobadaCausa)
        Me.groupboxResolucion.Controls.Add(Me.textboxDesaprobadaCausa)
        Me.groupboxResolucion.Controls.Add(Me.radiobuttonEstadoDesaprobada)
        Me.groupboxResolucion.Controls.Add(Me.radiobuttonEstadoAprobada)
        Me.groupboxResolucion.Controls.Add(Me.radiobuttonEstadoEnProceso)
        Me.groupboxResolucion.Controls.Add(labelResolucionNumero)
        Me.groupboxResolucion.Controls.Add(Me.textboxResolucionNumero)
        Me.groupboxResolucion.Controls.Add(Me.comboboxResolucionSancionTipo)
        Me.groupboxResolucion.Controls.Add(labelResolucionSancionTipo)
        Me.groupboxResolucion.Controls.Add(Me.datetimepickerResolucionFecha)
        Me.groupboxResolucion.Controls.Add(Me.labelResolucionFecha)
        Me.groupboxResolucion.Location = New System.Drawing.Point(8, 7)
        Me.groupboxResolucion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxResolucion.Name = "groupboxResolucion"
        Me.groupboxResolucion.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxResolucion.Size = New System.Drawing.Size(664, 228)
        Me.groupboxResolucion.TabIndex = 0
        Me.groupboxResolucion.TabStop = False
        Me.groupboxResolucion.Text = "Resolución:"
        '
        'labelDesaprobadaCausa
        '
        Me.labelDesaprobadaCausa.AutoSize = True
        Me.labelDesaprobadaCausa.Location = New System.Drawing.Point(8, 63)
        Me.labelDesaprobadaCausa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelDesaprobadaCausa.Name = "labelDesaprobadaCausa"
        Me.labelDesaprobadaCausa.Size = New System.Drawing.Size(56, 16)
        Me.labelDesaprobadaCausa.TabIndex = 3
        Me.labelDesaprobadaCausa.Text = "Causas:"
        Me.labelDesaprobadaCausa.Visible = False
        '
        'textboxDesaprobadaCausa
        '
        Me.textboxDesaprobadaCausa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxDesaprobadaCausa.Location = New System.Drawing.Point(83, 59)
        Me.textboxDesaprobadaCausa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxDesaprobadaCausa.MaxLength = 0
        Me.textboxDesaprobadaCausa.Multiline = True
        Me.textboxDesaprobadaCausa.Name = "textboxDesaprobadaCausa"
        Me.textboxDesaprobadaCausa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxDesaprobadaCausa.Size = New System.Drawing.Size(572, 89)
        Me.textboxDesaprobadaCausa.TabIndex = 4
        Me.textboxDesaprobadaCausa.Visible = False
        '
        'radiobuttonEstadoDesaprobada
        '
        Me.radiobuttonEstadoDesaprobada.Appearance = System.Windows.Forms.Appearance.Button
        Me.radiobuttonEstadoDesaprobada.AutoSize = True
        Me.radiobuttonEstadoDesaprobada.Location = New System.Drawing.Point(207, 23)
        Me.radiobuttonEstadoDesaprobada.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radiobuttonEstadoDesaprobada.Name = "radiobuttonEstadoDesaprobada"
        Me.radiobuttonEstadoDesaprobada.Size = New System.Drawing.Size(102, 26)
        Me.radiobuttonEstadoDesaprobada.TabIndex = 2
        Me.radiobuttonEstadoDesaprobada.Text = "Desaprobada"
        Me.radiobuttonEstadoDesaprobada.UseVisualStyleBackColor = True
        '
        'radiobuttonEstadoAprobada
        '
        Me.radiobuttonEstadoAprobada.Appearance = System.Windows.Forms.Appearance.Button
        Me.radiobuttonEstadoAprobada.AutoSize = True
        Me.radiobuttonEstadoAprobada.Location = New System.Drawing.Point(115, 23)
        Me.radiobuttonEstadoAprobada.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radiobuttonEstadoAprobada.Name = "radiobuttonEstadoAprobada"
        Me.radiobuttonEstadoAprobada.Size = New System.Drawing.Size(78, 26)
        Me.radiobuttonEstadoAprobada.TabIndex = 1
        Me.radiobuttonEstadoAprobada.Text = "Aprobada"
        Me.radiobuttonEstadoAprobada.UseVisualStyleBackColor = True
        '
        'radiobuttonEstadoEnProceso
        '
        Me.radiobuttonEstadoEnProceso.Appearance = System.Windows.Forms.Appearance.Button
        Me.radiobuttonEstadoEnProceso.AutoSize = True
        Me.radiobuttonEstadoEnProceso.Location = New System.Drawing.Point(12, 23)
        Me.radiobuttonEstadoEnProceso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radiobuttonEstadoEnProceso.Name = "radiobuttonEstadoEnProceso"
        Me.radiobuttonEstadoEnProceso.Size = New System.Drawing.Size(86, 26)
        Me.radiobuttonEstadoEnProceso.TabIndex = 0
        Me.radiobuttonEstadoEnProceso.Text = "En proceso"
        Me.radiobuttonEstadoEnProceso.UseVisualStyleBackColor = True
        '
        'textboxResolucionNumero
        '
        Me.textboxResolucionNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxResolucionNumero.Location = New System.Drawing.Point(419, 193)
        Me.textboxResolucionNumero.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxResolucionNumero.MaxLength = 15
        Me.textboxResolucionNumero.Name = "textboxResolucionNumero"
        Me.textboxResolucionNumero.Size = New System.Drawing.Size(153, 22)
        Me.textboxResolucionNumero.TabIndex = 10
        '
        'comboboxResolucionSancionTipo
        '
        Me.comboboxResolucionSancionTipo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboboxResolucionSancionTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxResolucionSancionTipo.FormattingEnabled = True
        Me.comboboxResolucionSancionTipo.Location = New System.Drawing.Point(83, 156)
        Me.comboboxResolucionSancionTipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.comboboxResolucionSancionTipo.Name = "comboboxResolucionSancionTipo"
        Me.comboboxResolucionSancionTipo.Size = New System.Drawing.Size(572, 24)
        Me.comboboxResolucionSancionTipo.TabIndex = 6
        '
        'datetimepickerResolucionFecha
        '
        Me.datetimepickerResolucionFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.datetimepickerResolucionFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerResolucionFecha.Location = New System.Drawing.Point(83, 193)
        Me.datetimepickerResolucionFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datetimepickerResolucionFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerResolucionFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerResolucionFecha.Name = "datetimepickerResolucionFecha"
        Me.datetimepickerResolucionFecha.ShowCheckBox = True
        Me.datetimepickerResolucionFecha.Size = New System.Drawing.Size(183, 22)
        Me.datetimepickerResolucionFecha.TabIndex = 8
        '
        'labelResolucionFecha
        '
        Me.labelResolucionFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelResolucionFecha.AutoSize = True
        Me.labelResolucionFecha.Location = New System.Drawing.Point(8, 197)
        Me.labelResolucionFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelResolucionFecha.Name = "labelResolucionFecha"
        Me.labelResolucionFecha.Size = New System.Drawing.Size(48, 16)
        Me.labelResolucionFecha.TabIndex = 7
        Me.labelResolucionFecha.Text = "Fecha:"
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelIDSancion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxIDSancion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(labelModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(labelCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxNotas)
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelNotas)
        Me.tabpageNotasAuditoria.Location = New System.Drawing.Point(4, 28)
        Me.tabpageNotasAuditoria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabpageNotasAuditoria.Name = "tabpageNotasAuditoria"
        Me.tabpageNotasAuditoria.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(683, 502)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelIDSancion
        '
        Me.labelIDSancion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelIDSancion.AutoSize = True
        Me.labelIDSancion.Location = New System.Drawing.Point(8, 391)
        Me.labelIDSancion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelIDSancion.Name = "labelIDSancion"
        Me.labelIDSancion.Size = New System.Drawing.Size(94, 16)
        Me.labelIDSancion.TabIndex = 16
        Me.labelIDSancion.Text = "ID de Sanción:"
        '
        'textboxIDSancion
        '
        Me.textboxIDSancion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxIDSancion.Location = New System.Drawing.Point(152, 388)
        Me.textboxIDSancion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxIDSancion.MaxLength = 10
        Me.textboxIDSancion.Name = "textboxIDSancion"
        Me.textboxIDSancion.ReadOnly = True
        Me.textboxIDSancion.Size = New System.Drawing.Size(95, 22)
        Me.textboxIDSancion.TabIndex = 17
        Me.textboxIDSancion.TabStop = False
        Me.textboxIDSancion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(321, 452)
        Me.textboxUsuarioModificacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(344, 22)
        Me.textboxUsuarioModificacion.TabIndex = 23
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(321, 420)
        Me.textboxUsuarioCreacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(344, 22)
        Me.textboxUsuarioCreacion.TabIndex = 20
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(152, 452)
        Me.textboxFechaHoraModificacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(160, 22)
        Me.textboxFechaHoraModificacion.TabIndex = 22
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(152, 420)
        Me.textboxFechaHoraCreacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(160, 22)
        Me.textboxFechaHoraCreacion.TabIndex = 19
        '
        'formSancion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 599)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formSancion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sanción"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        Me.groupboxEncuadre.ResumeLayout(False)
        Me.groupboxEncuadre.PerformLayout()
        Me.groupboxSolicitud.ResumeLayout(False)
        Me.groupboxSolicitud.PerformLayout()
        Me.tabpageResolucion.ResumeLayout(False)
        Me.groupboxTestimonio.ResumeLayout(False)
        Me.groupboxTestimonio.PerformLayout()
        Me.groupboxNotificacion.ResumeLayout(False)
        Me.groupboxNotificacion.PerformLayout()
        Me.groupboxResolucion.ResumeLayout(False)
        Me.groupboxResolucion.PerformLayout()
        Me.tabpageNotasAuditoria.ResumeLayout(False)
        Me.tabpageNotasAuditoria.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents datetimepickerSolicitudFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelFecha As System.Windows.Forms.Label
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents tabcontrolMain As System.Windows.Forms.TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents labelIDSancion As System.Windows.Forms.Label
    Friend WithEvents textboxIDSancion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents labelEncuadreFecha As System.Windows.Forms.Label
    Friend WithEvents groupboxSolicitud As System.Windows.Forms.GroupBox
    Friend WithEvents groupboxEncuadre As System.Windows.Forms.GroupBox
    Friend WithEvents labelEncuadreTexto As System.Windows.Forms.Label
    Friend WithEvents textboxEncuadreTexto As System.Windows.Forms.TextBox
    Friend WithEvents datetimepickerEncuadreFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents textboxSolicitudMotivo As System.Windows.Forms.TextBox
    Friend WithEvents tabpageResolucion As TabPage
    Friend WithEvents groupboxNotificacion As GroupBox
    Friend WithEvents datetimepickerNotificacionFecha As DateTimePicker
    Friend WithEvents labelNotificacionFecha As Label
    Friend WithEvents groupboxResolucion As GroupBox
    Friend WithEvents textboxResolucionNumero As TextBox
    Friend WithEvents comboboxResolucionSancionTipo As ComboBox
    Friend WithEvents datetimepickerResolucionFecha As DateTimePicker
    Friend WithEvents labelResolucionFecha As Label
    Friend WithEvents groupboxTestimonio As GroupBox
    Friend WithEvents labelTestimonioTexto As Label
    Friend WithEvents textboxTestimonioTexto As TextBox
    Friend WithEvents datetimepickerTestimonioFecha As DateTimePicker
    Friend WithEvents labelTestimonioFecha As Label
    Friend WithEvents labelDesaprobadaCausa As Label
    Friend WithEvents textboxDesaprobadaCausa As TextBox
    Friend WithEvents radiobuttonEstadoDesaprobada As RadioButton
    Friend WithEvents radiobuttonEstadoAprobada As RadioButton
    Friend WithEvents radiobuttonEstadoEnProceso As RadioButton
    Friend WithEvents buttonAplicarTextos As Button
    Friend WithEvents checkboxObtenerTextos As CheckBox
    Friend WithEvents comboboxSancionMotivo As ComboBox
    Friend WithEvents comboboxSolicitudResponsableTipo As ComboBox
    Friend WithEvents textboxSolicitudPersonaTexto As TextBox
    Friend WithEvents datetimepickerNotificacionFechaEfectiva As DateTimePicker
    Friend WithEvents labelNotificacionFechaEfectiva As Label
    Friend WithEvents controlpersonaAplicar As ControlPersona
    Friend WithEvents controlpersonaSolicitud As ControlPersona
End Class
