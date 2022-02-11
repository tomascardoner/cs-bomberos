<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaCapacitacion
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
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.datetimepickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.comboboxCurso = New System.Windows.Forms.ComboBox()
        Me.textboxCapacitacionNivelOtro = New System.Windows.Forms.TextBox()
        Me.tabcontrolMain = New CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.maskedtextboxCantidadDias = New System.Windows.Forms.MaskedTextBox()
        Me.labelCantidadDias = New System.Windows.Forms.Label()
        Me.maskedtextboxCantidadHoras = New System.Windows.Forms.MaskedTextBox()
        Me.labelCantidadHoras = New System.Windows.Forms.Label()
        Me.comboboxCapacitacionTipo = New System.Windows.Forms.ComboBox()
        Me.textboxCapacitacionTipoOtro = New System.Windows.Forms.TextBox()
        Me.comboboxCapacitacionNivel = New System.Windows.Forms.ComboBox()
        Me.comboboxLocalidad = New System.Windows.Forms.ComboBox()
        Me.comboboxProvincia = New System.Windows.Forms.ComboBox()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.labelIDCapacitacion = New System.Windows.Forms.Label()
        Me.textboxIDCapacitacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.labelCurso = New System.Windows.Forms.Label()
        Me.labelProvincia = New System.Windows.Forms.Label()
        Me.labelLocalidad = New System.Windows.Forms.Label()
        Me.labelCapacitacionNivel = New System.Windows.Forms.Label()
        Me.labelCapacitacionNivelOtro = New System.Windows.Forms.Label()
        Me.labelCapacitacionTipo = New System.Windows.Forms.Label()
        Me.labelCapacitacionTipoOtro = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 309)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 21
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 283)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 18
        labelCreacion.Text = "Creación:"
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
        Me.toolstripMain.Size = New System.Drawing.Size(542, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'datetimepickerFecha
        '
        Me.datetimepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFecha.Location = New System.Drawing.Point(68, 10)
        Me.datetimepickerFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFecha.Name = "datetimepickerFecha"
        Me.datetimepickerFecha.Size = New System.Drawing.Size(116, 20)
        Me.datetimepickerFecha.TabIndex = 1
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(6, 16)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelFecha.TabIndex = 0
        Me.labelFecha.Text = "Fecha:"
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(114, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(386, 242)
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
        'comboboxCurso
        '
        Me.comboboxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCurso.FormattingEnabled = True
        Me.comboboxCurso.Location = New System.Drawing.Point(68, 46)
        Me.comboboxCurso.Name = "comboboxCurso"
        Me.comboboxCurso.Size = New System.Drawing.Size(340, 21)
        Me.comboboxCurso.TabIndex = 3
        '
        'textboxCapacitacionNivelOtro
        '
        Me.textboxCapacitacionNivelOtro.Location = New System.Drawing.Point(68, 174)
        Me.textboxCapacitacionNivelOtro.MaxLength = 200
        Me.textboxCapacitacionNivelOtro.Name = "textboxCapacitacionNivelOtro"
        Me.textboxCapacitacionNivelOtro.Size = New System.Drawing.Size(436, 20)
        Me.textboxCapacitacionNivelOtro.TabIndex = 11
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(518, 361)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.labelCapacitacionTipoOtro)
        Me.tabpageGeneral.Controls.Add(Me.labelCapacitacionTipo)
        Me.tabpageGeneral.Controls.Add(Me.labelCapacitacionNivelOtro)
        Me.tabpageGeneral.Controls.Add(Me.labelCapacitacionNivel)
        Me.tabpageGeneral.Controls.Add(Me.labelLocalidad)
        Me.tabpageGeneral.Controls.Add(Me.labelProvincia)
        Me.tabpageGeneral.Controls.Add(Me.labelCurso)
        Me.tabpageGeneral.Controls.Add(Me.maskedtextboxCantidadDias)
        Me.tabpageGeneral.Controls.Add(Me.labelCantidadDias)
        Me.tabpageGeneral.Controls.Add(Me.maskedtextboxCantidadHoras)
        Me.tabpageGeneral.Controls.Add(Me.labelCantidadHoras)
        Me.tabpageGeneral.Controls.Add(Me.comboboxCapacitacionTipo)
        Me.tabpageGeneral.Controls.Add(Me.textboxCapacitacionTipoOtro)
        Me.tabpageGeneral.Controls.Add(Me.comboboxCapacitacionNivel)
        Me.tabpageGeneral.Controls.Add(Me.comboboxLocalidad)
        Me.tabpageGeneral.Controls.Add(Me.comboboxProvincia)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFecha)
        Me.tabpageGeneral.Controls.Add(Me.labelFecha)
        Me.tabpageGeneral.Controls.Add(Me.comboboxCurso)
        Me.tabpageGeneral.Controls.Add(Me.textboxCapacitacionNivelOtro)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(510, 332)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'maskedtextboxCantidadDias
        '
        Me.maskedtextboxCantidadDias.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxCantidadDias.Location = New System.Drawing.Point(68, 299)
        Me.maskedtextboxCantidadDias.Mask = "999"
        Me.maskedtextboxCantidadDias.Name = "maskedtextboxCantidadDias"
        Me.maskedtextboxCantidadDias.Size = New System.Drawing.Size(37, 20)
        Me.maskedtextboxCantidadDias.TabIndex = 19
        Me.maskedtextboxCantidadDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.maskedtextboxCantidadDias.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'labelCantidadDias
        '
        Me.labelCantidadDias.AutoSize = True
        Me.labelCantidadDias.Location = New System.Drawing.Point(6, 302)
        Me.labelCantidadDias.Name = "labelCantidadDias"
        Me.labelCantidadDias.Size = New System.Drawing.Size(33, 13)
        Me.labelCantidadDias.TabIndex = 18
        Me.labelCantidadDias.Text = "Días:"
        '
        'maskedtextboxCantidadHoras
        '
        Me.maskedtextboxCantidadHoras.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxCantidadHoras.Location = New System.Drawing.Point(68, 273)
        Me.maskedtextboxCantidadHoras.Mask = "999"
        Me.maskedtextboxCantidadHoras.Name = "maskedtextboxCantidadHoras"
        Me.maskedtextboxCantidadHoras.Size = New System.Drawing.Size(37, 20)
        Me.maskedtextboxCantidadHoras.TabIndex = 17
        Me.maskedtextboxCantidadHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.maskedtextboxCantidadHoras.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'labelCantidadHoras
        '
        Me.labelCantidadHoras.AutoSize = True
        Me.labelCantidadHoras.Location = New System.Drawing.Point(6, 276)
        Me.labelCantidadHoras.Name = "labelCantidadHoras"
        Me.labelCantidadHoras.Size = New System.Drawing.Size(38, 13)
        Me.labelCantidadHoras.TabIndex = 16
        Me.labelCantidadHoras.Text = "Horas:"
        '
        'comboboxCapacitacionTipo
        '
        Me.comboboxCapacitacionTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCapacitacionTipo.FormattingEnabled = True
        Me.comboboxCapacitacionTipo.Location = New System.Drawing.Point(68, 210)
        Me.comboboxCapacitacionTipo.Name = "comboboxCapacitacionTipo"
        Me.comboboxCapacitacionTipo.Size = New System.Drawing.Size(435, 21)
        Me.comboboxCapacitacionTipo.TabIndex = 13
        '
        'textboxCapacitacionTipoOtro
        '
        Me.textboxCapacitacionTipoOtro.Location = New System.Drawing.Point(68, 237)
        Me.textboxCapacitacionTipoOtro.MaxLength = 200
        Me.textboxCapacitacionTipoOtro.Name = "textboxCapacitacionTipoOtro"
        Me.textboxCapacitacionTipoOtro.Size = New System.Drawing.Size(435, 20)
        Me.textboxCapacitacionTipoOtro.TabIndex = 15
        '
        'comboboxCapacitacionNivel
        '
        Me.comboboxCapacitacionNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCapacitacionNivel.FormattingEnabled = True
        Me.comboboxCapacitacionNivel.Location = New System.Drawing.Point(68, 147)
        Me.comboboxCapacitacionNivel.Name = "comboboxCapacitacionNivel"
        Me.comboboxCapacitacionNivel.Size = New System.Drawing.Size(436, 21)
        Me.comboboxCapacitacionNivel.TabIndex = 9
        '
        'comboboxLocalidad
        '
        Me.comboboxLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxLocalidad.FormattingEnabled = True
        Me.comboboxLocalidad.Location = New System.Drawing.Point(68, 110)
        Me.comboboxLocalidad.Name = "comboboxLocalidad"
        Me.comboboxLocalidad.Size = New System.Drawing.Size(340, 21)
        Me.comboboxLocalidad.TabIndex = 7
        '
        'comboboxProvincia
        '
        Me.comboboxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxProvincia.FormattingEnabled = True
        Me.comboboxProvincia.Location = New System.Drawing.Point(68, 83)
        Me.comboboxProvincia.Name = "comboboxProvincia"
        Me.comboboxProvincia.Size = New System.Drawing.Size(340, 21)
        Me.comboboxProvincia.TabIndex = 5
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelIDCapacitacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxIDCapacitacion)
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(510, 332)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelIDCapacitacion
        '
        Me.labelIDCapacitacion.AutoSize = True
        Me.labelIDCapacitacion.Location = New System.Drawing.Point(6, 257)
        Me.labelIDCapacitacion.Name = "labelIDCapacitacion"
        Me.labelIDCapacitacion.Size = New System.Drawing.Size(101, 13)
        Me.labelIDCapacitacion.TabIndex = 16
        Me.labelIDCapacitacion.Text = "ID de Capacitación:"
        '
        'textboxIDCapacitacion
        '
        Me.textboxIDCapacitacion.Location = New System.Drawing.Point(114, 254)
        Me.textboxIDCapacitacion.MaxLength = 10
        Me.textboxIDCapacitacion.Name = "textboxIDCapacitacion"
        Me.textboxIDCapacitacion.ReadOnly = True
        Me.textboxIDCapacitacion.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDCapacitacion.TabIndex = 17
        Me.textboxIDCapacitacion.TabStop = False
        Me.textboxIDCapacitacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 306)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 23
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 280)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 20
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 306)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 22
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 280)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 19
        '
        'labelCurso
        '
        Me.labelCurso.AutoSize = True
        Me.labelCurso.Location = New System.Drawing.Point(6, 49)
        Me.labelCurso.Name = "labelCurso"
        Me.labelCurso.Size = New System.Drawing.Size(37, 13)
        Me.labelCurso.TabIndex = 20
        Me.labelCurso.Text = "Curso:"
        '
        'labelProvincia
        '
        Me.labelProvincia.AutoSize = True
        Me.labelProvincia.Location = New System.Drawing.Point(6, 86)
        Me.labelProvincia.Name = "labelProvincia"
        Me.labelProvincia.Size = New System.Drawing.Size(54, 13)
        Me.labelProvincia.TabIndex = 21
        Me.labelProvincia.Text = "Provincia:"
        '
        'labelLocalidad
        '
        Me.labelLocalidad.AutoSize = True
        Me.labelLocalidad.Location = New System.Drawing.Point(6, 113)
        Me.labelLocalidad.Name = "labelLocalidad"
        Me.labelLocalidad.Size = New System.Drawing.Size(56, 13)
        Me.labelLocalidad.TabIndex = 22
        Me.labelLocalidad.Text = "Localidad:"
        '
        'labelCapacitacionNivel
        '
        Me.labelCapacitacionNivel.AutoSize = True
        Me.labelCapacitacionNivel.Location = New System.Drawing.Point(6, 150)
        Me.labelCapacitacionNivel.Name = "labelCapacitacionNivel"
        Me.labelCapacitacionNivel.Size = New System.Drawing.Size(34, 13)
        Me.labelCapacitacionNivel.TabIndex = 23
        Me.labelCapacitacionNivel.Text = "Nivel:"
        '
        'labelCapacitacionNivelOtro
        '
        Me.labelCapacitacionNivelOtro.AutoSize = True
        Me.labelCapacitacionNivelOtro.Location = New System.Drawing.Point(6, 177)
        Me.labelCapacitacionNivelOtro.Name = "labelCapacitacionNivelOtro"
        Me.labelCapacitacionNivelOtro.Size = New System.Drawing.Size(30, 13)
        Me.labelCapacitacionNivelOtro.TabIndex = 24
        Me.labelCapacitacionNivelOtro.Text = "Otro:"
        '
        'labelCapacitacionTipo
        '
        Me.labelCapacitacionTipo.AutoSize = True
        Me.labelCapacitacionTipo.Location = New System.Drawing.Point(6, 213)
        Me.labelCapacitacionTipo.Name = "labelCapacitacionTipo"
        Me.labelCapacitacionTipo.Size = New System.Drawing.Size(31, 13)
        Me.labelCapacitacionTipo.TabIndex = 25
        Me.labelCapacitacionTipo.Text = "Tipo:"
        '
        'labelCapacitacionTipoOtro
        '
        Me.labelCapacitacionTipoOtro.AutoSize = True
        Me.labelCapacitacionTipoOtro.Location = New System.Drawing.Point(6, 240)
        Me.labelCapacitacionTipoOtro.Name = "labelCapacitacionTipoOtro"
        Me.labelCapacitacionTipoOtro.Size = New System.Drawing.Size(30, 13)
        Me.labelCapacitacionTipoOtro.TabIndex = 26
        Me.labelCapacitacionTipoOtro.Text = "Otro:"
        '
        'formPersonaCapacitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 419)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPersonaCapacitacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Capacitación de la Persona"
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
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents datetimepickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelFecha As System.Windows.Forms.Label
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents comboboxCurso As System.Windows.Forms.ComboBox
    Friend WithEvents textboxCapacitacionNivelOtro As System.Windows.Forms.TextBox
    Friend WithEvents tabcontrolMain As CS_Control_TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents labelIDCapacitacion As System.Windows.Forms.Label
    Friend WithEvents textboxIDCapacitacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents comboboxLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxCapacitacionNivel As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxCapacitacionTipo As System.Windows.Forms.ComboBox
    Friend WithEvents textboxCapacitacionTipoOtro As System.Windows.Forms.TextBox
    Friend WithEvents maskedtextboxCantidadDias As System.Windows.Forms.MaskedTextBox
    Friend WithEvents labelCantidadDias As System.Windows.Forms.Label
    Friend WithEvents maskedtextboxCantidadHoras As System.Windows.Forms.MaskedTextBox
    Friend WithEvents labelCantidadHoras As System.Windows.Forms.Label
    Friend WithEvents labelCurso As System.Windows.Forms.Label
    Friend WithEvents labelCapacitacionTipoOtro As System.Windows.Forms.Label
    Friend WithEvents labelCapacitacionTipo As System.Windows.Forms.Label
    Friend WithEvents labelCapacitacionNivelOtro As System.Windows.Forms.Label
    Friend WithEvents labelCapacitacionNivel As System.Windows.Forms.Label
    Friend WithEvents labelLocalidad As System.Windows.Forms.Label
    Friend WithEvents labelProvincia As System.Windows.Forms.Label
End Class
