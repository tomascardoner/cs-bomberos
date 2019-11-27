<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaHorarioLaboral
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
        Dim labelTurno1Desde As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim labelTurno1Hasta As System.Windows.Forms.Label
        Dim labelTurno2Hasta As System.Windows.Forms.Label
        Dim labelTurno2Desde As System.Windows.Forms.Label
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.labelDiaSemana = New System.Windows.Forms.Label()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.comboboxDiaSemana = New System.Windows.Forms.ComboBox()
        Me.tabcontrolMain = New CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.datetimepickerTurno2Hasta = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerTurno2Desde = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerTurno1Hasta = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerTurno1Desde = New System.Windows.Forms.DateTimePicker()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        labelTurno1Desde = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelTurno1Hasta = New System.Windows.Forms.Label()
        labelTurno2Hasta = New System.Windows.Forms.Label()
        labelTurno2Desde = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTurno1Desde
        '
        labelTurno1Desde.AutoSize = True
        labelTurno1Desde.Location = New System.Drawing.Point(6, 49)
        labelTurno1Desde.Name = "labelTurno1Desde"
        labelTurno1Desde.Size = New System.Drawing.Size(87, 13)
        labelTurno1Desde.TabIndex = 2
        labelTurno1Desde.Text = "Turno 1 - Desde:"
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 145)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 21
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 119)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 18
        labelCreacion.Text = "Creación:"
        '
        'labelTurno1Hasta
        '
        labelTurno1Hasta.AutoSize = True
        labelTurno1Hasta.Location = New System.Drawing.Point(222, 49)
        labelTurno1Hasta.Name = "labelTurno1Hasta"
        labelTurno1Hasta.Size = New System.Drawing.Size(38, 13)
        labelTurno1Hasta.TabIndex = 4
        labelTurno1Hasta.Text = "Hasta:"
        '
        'labelTurno2Hasta
        '
        labelTurno2Hasta.AutoSize = True
        labelTurno2Hasta.Location = New System.Drawing.Point(222, 79)
        labelTurno2Hasta.Name = "labelTurno2Hasta"
        labelTurno2Hasta.Size = New System.Drawing.Size(38, 13)
        labelTurno2Hasta.TabIndex = 8
        labelTurno2Hasta.Text = "Hasta:"
        '
        'labelTurno2Desde
        '
        labelTurno2Desde.AutoSize = True
        labelTurno2Desde.Location = New System.Drawing.Point(6, 79)
        labelTurno2Desde.Name = "labelTurno2Desde"
        labelTurno2Desde.Size = New System.Drawing.Size(87, 13)
        labelTurno2Desde.TabIndex = 6
        labelTurno2Desde.Text = "Turno 2 - Desde:"
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
        'labelDiaSemana
        '
        Me.labelDiaSemana.AutoSize = True
        Me.labelDiaSemana.Location = New System.Drawing.Point(6, 16)
        Me.labelDiaSemana.Name = "labelDiaSemana"
        Me.labelDiaSemana.Size = New System.Drawing.Size(94, 13)
        Me.labelDiaSemana.TabIndex = 0
        Me.labelDiaSemana.Text = "Día de la semana:"
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(114, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(386, 104)
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
        'comboboxDiaSemana
        '
        Me.comboboxDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDiaSemana.FormattingEnabled = True
        Me.comboboxDiaSemana.Location = New System.Drawing.Point(106, 13)
        Me.comboboxDiaSemana.Name = "comboboxDiaSemana"
        Me.comboboxDiaSemana.Size = New System.Drawing.Size(160, 21)
        Me.comboboxDiaSemana.TabIndex = 1
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(518, 201)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerTurno2Hasta)
        Me.tabpageGeneral.Controls.Add(labelTurno2Hasta)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerTurno2Desde)
        Me.tabpageGeneral.Controls.Add(labelTurno2Desde)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerTurno1Hasta)
        Me.tabpageGeneral.Controls.Add(labelTurno1Hasta)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerTurno1Desde)
        Me.tabpageGeneral.Controls.Add(Me.labelDiaSemana)
        Me.tabpageGeneral.Controls.Add(labelTurno1Desde)
        Me.tabpageGeneral.Controls.Add(Me.comboboxDiaSemana)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(510, 172)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'datetimepickerTurno2Hasta
        '
        Me.datetimepickerTurno2Hasta.CustomFormat = "HH:mm"
        Me.datetimepickerTurno2Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickerTurno2Hasta.Location = New System.Drawing.Point(266, 75)
        Me.datetimepickerTurno2Hasta.Name = "datetimepickerTurno2Hasta"
        Me.datetimepickerTurno2Hasta.ShowCheckBox = True
        Me.datetimepickerTurno2Hasta.ShowUpDown = True
        Me.datetimepickerTurno2Hasta.Size = New System.Drawing.Size(80, 20)
        Me.datetimepickerTurno2Hasta.TabIndex = 9
        Me.datetimepickerTurno2Hasta.Value = New Date(1753, 1, 1, 0, 0, 0, 0)
        '
        'datetimepickerTurno2Desde
        '
        Me.datetimepickerTurno2Desde.CustomFormat = "HH:mm"
        Me.datetimepickerTurno2Desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickerTurno2Desde.Location = New System.Drawing.Point(106, 75)
        Me.datetimepickerTurno2Desde.Name = "datetimepickerTurno2Desde"
        Me.datetimepickerTurno2Desde.ShowCheckBox = True
        Me.datetimepickerTurno2Desde.ShowUpDown = True
        Me.datetimepickerTurno2Desde.Size = New System.Drawing.Size(80, 20)
        Me.datetimepickerTurno2Desde.TabIndex = 7
        Me.datetimepickerTurno2Desde.Value = New Date(1753, 1, 1, 0, 0, 0, 0)
        '
        'datetimepickerTurno1Hasta
        '
        Me.datetimepickerTurno1Hasta.CustomFormat = "HH:mm"
        Me.datetimepickerTurno1Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickerTurno1Hasta.Location = New System.Drawing.Point(266, 45)
        Me.datetimepickerTurno1Hasta.Name = "datetimepickerTurno1Hasta"
        Me.datetimepickerTurno1Hasta.ShowCheckBox = True
        Me.datetimepickerTurno1Hasta.ShowUpDown = True
        Me.datetimepickerTurno1Hasta.Size = New System.Drawing.Size(80, 20)
        Me.datetimepickerTurno1Hasta.TabIndex = 5
        Me.datetimepickerTurno1Hasta.Value = New Date(1753, 1, 1, 0, 0, 0, 0)
        '
        'datetimepickerTurno1Desde
        '
        Me.datetimepickerTurno1Desde.CustomFormat = "HH:mm"
        Me.datetimepickerTurno1Desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickerTurno1Desde.Location = New System.Drawing.Point(106, 45)
        Me.datetimepickerTurno1Desde.Name = "datetimepickerTurno1Desde"
        Me.datetimepickerTurno1Desde.ShowCheckBox = True
        Me.datetimepickerTurno1Desde.ShowUpDown = True
        Me.datetimepickerTurno1Desde.Size = New System.Drawing.Size(80, 20)
        Me.datetimepickerTurno1Desde.TabIndex = 3
        Me.datetimepickerTurno1Desde.Value = New Date(1753, 1, 1, 0, 0, 0, 0)
        '
        'tabpageNotasAuditoria
        '
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(510, 172)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 142)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 23
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 116)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 20
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 142)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 22
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 116)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 19
        '
        'formPersonaHorarioLaboral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 253)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPersonaHorarioLaboral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Horario Laboral de la Persona"
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
    Friend WithEvents labelDiaSemana As System.Windows.Forms.Label
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents comboboxDiaSemana As System.Windows.Forms.ComboBox
    Friend WithEvents tabcontrolMain As CS_Control_TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents datetimepickerTurno1Hasta As DateTimePicker
    Friend WithEvents datetimepickerTurno1Desde As DateTimePicker
    Friend WithEvents datetimepickerTurno2Hasta As DateTimePicker
    Friend WithEvents datetimepickerTurno2Desde As DateTimePicker
End Class
