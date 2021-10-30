<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaSancion
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
        Dim labelResolucionSancionTipo As System.Windows.Forms.Label
        Dim labelResolucionNumero As System.Windows.Forms.Label
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.datetimepickerSolicitudFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.tabcontrolMain = New CSBomberos.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.groupboxNotificacion = New System.Windows.Forms.GroupBox()
        Me.datetimepickerNotificacionFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelNotificacionFecha = New System.Windows.Forms.Label()
        Me.groupboxResolucion = New System.Windows.Forms.GroupBox()
        Me.comboboxResolucionSancionTipo = New System.Windows.Forms.ComboBox()
        Me.datetimepickerResolucionFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelResolucionFecha = New System.Windows.Forms.Label()
        Me.groupboxEncuadre = New System.Windows.Forms.GroupBox()
        Me.datetimepickerEncuadreFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelEncuadreTexto = New System.Windows.Forms.Label()
        Me.textboxEncuadreTexto = New System.Windows.Forms.TextBox()
        Me.labelEncuadreFecha = New System.Windows.Forms.Label()
        Me.groupboxSolicitud = New System.Windows.Forms.GroupBox()
        Me.textboxSolicitudMotivo = New System.Windows.Forms.TextBox()
        Me.comboboxSolicitudPersona = New System.Windows.Forms.ComboBox()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.labelIDSancion = New System.Windows.Forms.Label()
        Me.textboxIDSancion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxResolucionNumero = New System.Windows.Forms.TextBox()
        labelSolicitudMotivo = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelSolicitudPersona = New System.Windows.Forms.Label()
        labelResolucionSancionTipo = New System.Windows.Forms.Label()
        labelResolucionNumero = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.groupboxNotificacion.SuspendLayout()
        Me.groupboxResolucion.SuspendLayout()
        Me.groupboxEncuadre.SuspendLayout()
        Me.groupboxSolicitud.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelSolicitudMotivo
        '
        labelSolicitudMotivo.AutoSize = True
        labelSolicitudMotivo.Location = New System.Drawing.Point(6, 49)
        labelSolicitudMotivo.Name = "labelSolicitudMotivo"
        labelSolicitudMotivo.Size = New System.Drawing.Size(42, 13)
        labelSolicitudMotivo.TabIndex = 2
        labelSolicitudMotivo.Text = "Motivo:"
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 397)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 21
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 371)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 18
        labelCreacion.Text = "Creación:"
        '
        'labelSolicitudPersona
        '
        labelSolicitudPersona.AutoSize = True
        labelSolicitudPersona.Location = New System.Drawing.Point(6, 22)
        labelSolicitudPersona.Name = "labelSolicitudPersona"
        labelSolicitudPersona.Size = New System.Drawing.Size(26, 13)
        labelSolicitudPersona.TabIndex = 0
        labelSolicitudPersona.Text = "Por:"
        '
        'labelResolucionSancionTipo
        '
        labelResolucionSancionTipo.AutoSize = True
        labelResolucionSancionTipo.Location = New System.Drawing.Point(6, 22)
        labelResolucionSancionTipo.Name = "labelResolucionSancionTipo"
        labelResolucionSancionTipo.Size = New System.Drawing.Size(31, 13)
        labelResolucionSancionTipo.TabIndex = 0
        labelResolucionSancionTipo.Text = "Tipo:"
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_OK_32
        Me.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(85, 36)
        Me.buttonGuardar.Text = "Guardar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_CANCEL_32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_CLOSE_32
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
        Me.toolstripMain.Size = New System.Drawing.Size(542, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'datetimepickerSolicitudFecha
        '
        Me.datetimepickerSolicitudFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerSolicitudFecha.Location = New System.Drawing.Point(62, 113)
        Me.datetimepickerSolicitudFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerSolicitudFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerSolicitudFecha.Name = "datetimepickerSolicitudFecha"
        Me.datetimepickerSolicitudFecha.Size = New System.Drawing.Size(116, 20)
        Me.datetimepickerSolicitudFecha.TabIndex = 5
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(6, 116)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelFecha.TabIndex = 4
        Me.labelFecha.Text = "Fecha:"
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(114, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(386, 330)
        Me.textboxNotas.TabIndex = 15
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(6, 9)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 14
        Me.labelNotas.Text = "Notas:"
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(518, 449)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.groupboxNotificacion)
        Me.tabpageGeneral.Controls.Add(Me.groupboxResolucion)
        Me.tabpageGeneral.Controls.Add(Me.groupboxEncuadre)
        Me.tabpageGeneral.Controls.Add(Me.groupboxSolicitud)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(510, 420)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'groupboxNotificacion
        '
        Me.groupboxNotificacion.Controls.Add(Me.datetimepickerNotificacionFecha)
        Me.groupboxNotificacion.Controls.Add(Me.labelNotificacionFecha)
        Me.groupboxNotificacion.Location = New System.Drawing.Point(6, 365)
        Me.groupboxNotificacion.Name = "groupboxNotificacion"
        Me.groupboxNotificacion.Size = New System.Drawing.Size(498, 49)
        Me.groupboxNotificacion.TabIndex = 3
        Me.groupboxNotificacion.TabStop = False
        Me.groupboxNotificacion.Text = "Notificación:"
        '
        'datetimepickerNotificacionFecha
        '
        Me.datetimepickerNotificacionFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerNotificacionFecha.Location = New System.Drawing.Point(62, 19)
        Me.datetimepickerNotificacionFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerNotificacionFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerNotificacionFecha.Name = "datetimepickerNotificacionFecha"
        Me.datetimepickerNotificacionFecha.ShowCheckBox = True
        Me.datetimepickerNotificacionFecha.Size = New System.Drawing.Size(138, 20)
        Me.datetimepickerNotificacionFecha.TabIndex = 1
        '
        'labelNotificacionFecha
        '
        Me.labelNotificacionFecha.AutoSize = True
        Me.labelNotificacionFecha.Location = New System.Drawing.Point(6, 22)
        Me.labelNotificacionFecha.Name = "labelNotificacionFecha"
        Me.labelNotificacionFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelNotificacionFecha.TabIndex = 0
        Me.labelNotificacionFecha.Text = "Fecha:"
        '
        'groupboxResolucion
        '
        Me.groupboxResolucion.Controls.Add(labelResolucionNumero)
        Me.groupboxResolucion.Controls.Add(Me.textboxResolucionNumero)
        Me.groupboxResolucion.Controls.Add(Me.comboboxResolucionSancionTipo)
        Me.groupboxResolucion.Controls.Add(labelResolucionSancionTipo)
        Me.groupboxResolucion.Controls.Add(Me.datetimepickerResolucionFecha)
        Me.groupboxResolucion.Controls.Add(Me.labelResolucionFecha)
        Me.groupboxResolucion.Location = New System.Drawing.Point(6, 279)
        Me.groupboxResolucion.Name = "groupboxResolucion"
        Me.groupboxResolucion.Size = New System.Drawing.Size(498, 80)
        Me.groupboxResolucion.TabIndex = 2
        Me.groupboxResolucion.TabStop = False
        Me.groupboxResolucion.Text = "Resolución:"
        '
        'comboboxResolucionSancionTipo
        '
        Me.comboboxResolucionSancionTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxResolucionSancionTipo.FormattingEnabled = True
        Me.comboboxResolucionSancionTipo.Location = New System.Drawing.Point(62, 19)
        Me.comboboxResolucionSancionTipo.Name = "comboboxResolucionSancionTipo"
        Me.comboboxResolucionSancionTipo.Size = New System.Drawing.Size(430, 21)
        Me.comboboxResolucionSancionTipo.TabIndex = 1
        '
        'datetimepickerResolucionFecha
        '
        Me.datetimepickerResolucionFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerResolucionFecha.Location = New System.Drawing.Point(62, 49)
        Me.datetimepickerResolucionFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerResolucionFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerResolucionFecha.Name = "datetimepickerResolucionFecha"
        Me.datetimepickerResolucionFecha.ShowCheckBox = True
        Me.datetimepickerResolucionFecha.Size = New System.Drawing.Size(138, 20)
        Me.datetimepickerResolucionFecha.TabIndex = 3
        '
        'labelResolucionFecha
        '
        Me.labelResolucionFecha.AutoSize = True
        Me.labelResolucionFecha.Location = New System.Drawing.Point(6, 52)
        Me.labelResolucionFecha.Name = "labelResolucionFecha"
        Me.labelResolucionFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelResolucionFecha.TabIndex = 2
        Me.labelResolucionFecha.Text = "Fecha:"
        '
        'groupboxEncuadre
        '
        Me.groupboxEncuadre.Controls.Add(Me.datetimepickerEncuadreFecha)
        Me.groupboxEncuadre.Controls.Add(Me.labelEncuadreTexto)
        Me.groupboxEncuadre.Controls.Add(Me.textboxEncuadreTexto)
        Me.groupboxEncuadre.Controls.Add(Me.labelEncuadreFecha)
        Me.groupboxEncuadre.Location = New System.Drawing.Point(6, 154)
        Me.groupboxEncuadre.Name = "groupboxEncuadre"
        Me.groupboxEncuadre.Size = New System.Drawing.Size(498, 119)
        Me.groupboxEncuadre.TabIndex = 1
        Me.groupboxEncuadre.TabStop = False
        Me.groupboxEncuadre.Text = "Encuadre:"
        '
        'datetimepickerEncuadreFecha
        '
        Me.datetimepickerEncuadreFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerEncuadreFecha.Location = New System.Drawing.Point(62, 89)
        Me.datetimepickerEncuadreFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerEncuadreFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerEncuadreFecha.Name = "datetimepickerEncuadreFecha"
        Me.datetimepickerEncuadreFecha.ShowCheckBox = True
        Me.datetimepickerEncuadreFecha.Size = New System.Drawing.Size(138, 20)
        Me.datetimepickerEncuadreFecha.TabIndex = 3
        '
        'labelEncuadreTexto
        '
        Me.labelEncuadreTexto.AutoSize = True
        Me.labelEncuadreTexto.Location = New System.Drawing.Point(6, 22)
        Me.labelEncuadreTexto.Name = "labelEncuadreTexto"
        Me.labelEncuadreTexto.Size = New System.Drawing.Size(37, 13)
        Me.labelEncuadreTexto.TabIndex = 0
        Me.labelEncuadreTexto.Text = "Texto:"
        '
        'textboxEncuadreTexto
        '
        Me.textboxEncuadreTexto.Location = New System.Drawing.Point(62, 19)
        Me.textboxEncuadreTexto.MaxLength = 0
        Me.textboxEncuadreTexto.Multiline = True
        Me.textboxEncuadreTexto.Name = "textboxEncuadreTexto"
        Me.textboxEncuadreTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxEncuadreTexto.Size = New System.Drawing.Size(430, 61)
        Me.textboxEncuadreTexto.TabIndex = 1
        '
        'labelEncuadreFecha
        '
        Me.labelEncuadreFecha.AutoSize = True
        Me.labelEncuadreFecha.Location = New System.Drawing.Point(6, 92)
        Me.labelEncuadreFecha.Name = "labelEncuadreFecha"
        Me.labelEncuadreFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelEncuadreFecha.TabIndex = 2
        Me.labelEncuadreFecha.Text = "Fecha:"
        '
        'groupboxSolicitud
        '
        Me.groupboxSolicitud.Controls.Add(Me.textboxSolicitudMotivo)
        Me.groupboxSolicitud.Controls.Add(Me.comboboxSolicitudPersona)
        Me.groupboxSolicitud.Controls.Add(labelSolicitudPersona)
        Me.groupboxSolicitud.Controls.Add(Me.datetimepickerSolicitudFecha)
        Me.groupboxSolicitud.Controls.Add(Me.labelFecha)
        Me.groupboxSolicitud.Controls.Add(labelSolicitudMotivo)
        Me.groupboxSolicitud.Location = New System.Drawing.Point(6, 6)
        Me.groupboxSolicitud.Name = "groupboxSolicitud"
        Me.groupboxSolicitud.Size = New System.Drawing.Size(498, 142)
        Me.groupboxSolicitud.TabIndex = 0
        Me.groupboxSolicitud.TabStop = False
        Me.groupboxSolicitud.Text = "Solicitud:"
        '
        'textboxSolicitudMotivo
        '
        Me.textboxSolicitudMotivo.Location = New System.Drawing.Point(62, 46)
        Me.textboxSolicitudMotivo.MaxLength = 0
        Me.textboxSolicitudMotivo.Multiline = True
        Me.textboxSolicitudMotivo.Name = "textboxSolicitudMotivo"
        Me.textboxSolicitudMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxSolicitudMotivo.Size = New System.Drawing.Size(430, 61)
        Me.textboxSolicitudMotivo.TabIndex = 3
        '
        'comboboxSolicitudPersona
        '
        Me.comboboxSolicitudPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxSolicitudPersona.FormattingEnabled = True
        Me.comboboxSolicitudPersona.Location = New System.Drawing.Point(62, 19)
        Me.comboboxSolicitudPersona.Name = "comboboxSolicitudPersona"
        Me.comboboxSolicitudPersona.Size = New System.Drawing.Size(430, 21)
        Me.comboboxSolicitudPersona.TabIndex = 1
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
        Me.tabpageNotasAuditoria.Location = New System.Drawing.Point(4, 25)
        Me.tabpageNotasAuditoria.Name = "tabpageNotasAuditoria"
        Me.tabpageNotasAuditoria.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(510, 420)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelIDSancion
        '
        Me.labelIDSancion.AutoSize = True
        Me.labelIDSancion.Location = New System.Drawing.Point(6, 345)
        Me.labelIDSancion.Name = "labelIDSancion"
        Me.labelIDSancion.Size = New System.Drawing.Size(78, 13)
        Me.labelIDSancion.TabIndex = 16
        Me.labelIDSancion.Text = "ID de Sanción:"
        '
        'textboxIDSancion
        '
        Me.textboxIDSancion.Location = New System.Drawing.Point(114, 342)
        Me.textboxIDSancion.MaxLength = 10
        Me.textboxIDSancion.Name = "textboxIDSancion"
        Me.textboxIDSancion.ReadOnly = True
        Me.textboxIDSancion.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDSancion.TabIndex = 17
        Me.textboxIDSancion.TabStop = False
        Me.textboxIDSancion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 394)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 23
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 368)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 20
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 394)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 22
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 368)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 19
        '
        'labelResolucionNumero
        '
        labelResolucionNumero.AutoSize = True
        labelResolucionNumero.Location = New System.Drawing.Point(230, 52)
        labelResolucionNumero.Name = "labelResolucionNumero"
        labelResolucionNumero.Size = New System.Drawing.Size(78, 13)
        labelResolucionNumero.TabIndex = 4
        labelResolucionNumero.Text = "Resolución Nº:"
        '
        'textboxResolucionNumero
        '
        Me.textboxResolucionNumero.Location = New System.Drawing.Point(314, 49)
        Me.textboxResolucionNumero.MaxLength = 15
        Me.textboxResolucionNumero.Name = "textboxResolucionNumero"
        Me.textboxResolucionNumero.Size = New System.Drawing.Size(116, 20)
        Me.textboxResolucionNumero.TabIndex = 5
        '
        'formPersonaSancion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 502)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPersonaSancion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sanción de la Persona"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.groupboxNotificacion.ResumeLayout(False)
        Me.groupboxNotificacion.PerformLayout()
        Me.groupboxResolucion.ResumeLayout(False)
        Me.groupboxResolucion.PerformLayout()
        Me.groupboxEncuadre.ResumeLayout(False)
        Me.groupboxEncuadre.PerformLayout()
        Me.groupboxSolicitud.ResumeLayout(False)
        Me.groupboxSolicitud.PerformLayout()
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
    Friend WithEvents tabcontrolMain As CS_Control_TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents labelIDSancion As System.Windows.Forms.Label
    Friend WithEvents textboxIDSancion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents labelEncuadreFecha As System.Windows.Forms.Label
    Friend WithEvents datetimepickerResolucionFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelResolucionFecha As System.Windows.Forms.Label
    Friend WithEvents groupboxSolicitud As System.Windows.Forms.GroupBox
    Friend WithEvents comboboxSolicitudPersona As System.Windows.Forms.ComboBox
    Friend WithEvents groupboxEncuadre As System.Windows.Forms.GroupBox
    Friend WithEvents labelEncuadreTexto As System.Windows.Forms.Label
    Friend WithEvents textboxEncuadreTexto As System.Windows.Forms.TextBox
    Friend WithEvents groupboxResolucion As System.Windows.Forms.GroupBox
    Friend WithEvents comboboxResolucionSancionTipo As System.Windows.Forms.ComboBox
    Friend WithEvents datetimepickerEncuadreFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents groupboxNotificacion As System.Windows.Forms.GroupBox
    Friend WithEvents datetimepickerNotificacionFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelNotificacionFecha As System.Windows.Forms.Label
    Friend WithEvents textboxSolicitudMotivo As System.Windows.Forms.TextBox
    Friend WithEvents textboxResolucionNumero As TextBox
End Class
