<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaVehiculo
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
        Dim labelTipo As System.Windows.Forms.Label
        Dim labelMarca As System.Windows.Forms.Label
        Dim labelDominio As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim labelModelo As System.Windows.Forms.Label
        Dim labelCompaniaSeguro As System.Windows.Forms.Label
        Dim labelFolioNumero As System.Windows.Forms.Label
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.datetimepickerVerificacionVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.labelVerificacionVencimiento = New System.Windows.Forms.Label()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.comboboxTipo = New System.Windows.Forms.ComboBox()
        Me.comboboxMarca = New System.Windows.Forms.ComboBox()
        Me.textboxDominio = New System.Windows.Forms.TextBox()
        Me.tabcontrolMain = New CSBomberos.DesktopApplication.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.groupboxSeguro = New System.Windows.Forms.GroupBox()
        Me.datetimepickerSeguroVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.labelSeguroVencimiento = New System.Windows.Forms.Label()
        Me.comboboxCompaniaSeguro = New System.Windows.Forms.ComboBox()
        Me.textboxSeguroPolizaNumero = New System.Windows.Forms.TextBox()
        Me.maskedtextboxAnio = New System.Windows.Forms.MaskedTextBox()
        Me.labelAnio = New System.Windows.Forms.Label()
        Me.textboxModelo = New System.Windows.Forms.TextBox()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.labelIDVehiculo = New System.Windows.Forms.Label()
        Me.textboxIDVehiculo = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        labelTipo = New System.Windows.Forms.Label()
        labelMarca = New System.Windows.Forms.Label()
        labelDominio = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelModelo = New System.Windows.Forms.Label()
        labelCompaniaSeguro = New System.Windows.Forms.Label()
        labelFolioNumero = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.groupboxSeguro.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTipo
        '
        labelTipo.AutoSize = True
        labelTipo.Location = New System.Drawing.Point(6, 9)
        labelTipo.Name = "labelTipo"
        labelTipo.Size = New System.Drawing.Size(31, 13)
        labelTipo.TabIndex = 0
        labelTipo.Text = "Tipo:"
        '
        'labelMarca
        '
        labelMarca.AutoSize = True
        labelMarca.Location = New System.Drawing.Point(6, 62)
        labelMarca.Name = "labelMarca"
        labelMarca.Size = New System.Drawing.Size(40, 13)
        labelMarca.TabIndex = 4
        labelMarca.Text = "Marca:"
        '
        'labelDominio
        '
        labelDominio.AutoSize = True
        labelDominio.Location = New System.Drawing.Point(6, 36)
        labelDominio.Name = "labelDominio"
        labelDominio.Size = New System.Drawing.Size(48, 13)
        labelDominio.TabIndex = 2
        labelDominio.Text = "Dominio:"
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 257)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 21
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 231)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 18
        labelCreacion.Text = "Creación:"
        '
        'labelModelo
        '
        labelModelo.AutoSize = True
        labelModelo.Location = New System.Drawing.Point(6, 89)
        labelModelo.Name = "labelModelo"
        labelModelo.Size = New System.Drawing.Size(45, 13)
        labelModelo.TabIndex = 6
        labelModelo.Text = "Modelo:"
        '
        'labelCompaniaSeguro
        '
        labelCompaniaSeguro.AutoSize = True
        labelCompaniaSeguro.Location = New System.Drawing.Point(9, 22)
        labelCompaniaSeguro.Name = "labelCompaniaSeguro"
        labelCompaniaSeguro.Size = New System.Drawing.Size(59, 13)
        labelCompaniaSeguro.TabIndex = 0
        labelCompaniaSeguro.Text = "Compañía:"
        '
        'labelFolioNumero
        '
        labelFolioNumero.AutoSize = True
        labelFolioNumero.Location = New System.Drawing.Point(9, 49)
        labelFolioNumero.Name = "labelFolioNumero"
        labelFolioNumero.Size = New System.Drawing.Size(53, 13)
        labelFolioNumero.TabIndex = 2
        labelFolioNumero.Text = "Póliza N°:"
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
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(542, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'datetimepickerVerificacionVencimiento
        '
        Me.datetimepickerVerificacionVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerVerificacionVencimiento.Location = New System.Drawing.Point(140, 138)
        Me.datetimepickerVerificacionVencimiento.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerVerificacionVencimiento.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerVerificacionVencimiento.Name = "datetimepickerVerificacionVencimiento"
        Me.datetimepickerVerificacionVencimiento.ShowCheckBox = True
        Me.datetimepickerVerificacionVencimiento.Size = New System.Drawing.Size(135, 20)
        Me.datetimepickerVerificacionVencimiento.TabIndex = 11
        '
        'labelVerificacionVencimiento
        '
        Me.labelVerificacionVencimiento.AutoSize = True
        Me.labelVerificacionVencimiento.Location = New System.Drawing.Point(6, 141)
        Me.labelVerificacionVencimiento.Name = "labelVerificacionVencimiento"
        Me.labelVerificacionVencimiento.Size = New System.Drawing.Size(126, 13)
        Me.labelVerificacionVencimiento.TabIndex = 10
        Me.labelVerificacionVencimiento.Text = "Vencimiento Verificación:"
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(114, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(386, 190)
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
        'comboboxTipo
        '
        Me.comboboxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxTipo.FormattingEnabled = True
        Me.comboboxTipo.Location = New System.Drawing.Point(140, 6)
        Me.comboboxTipo.Name = "comboboxTipo"
        Me.comboboxTipo.Size = New System.Drawing.Size(340, 21)
        Me.comboboxTipo.TabIndex = 1
        '
        'comboboxMarca
        '
        Me.comboboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxMarca.FormattingEnabled = True
        Me.comboboxMarca.Location = New System.Drawing.Point(140, 59)
        Me.comboboxMarca.Name = "comboboxMarca"
        Me.comboboxMarca.Size = New System.Drawing.Size(340, 21)
        Me.comboboxMarca.TabIndex = 5
        '
        'textboxDominio
        '
        Me.textboxDominio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textboxDominio.Location = New System.Drawing.Point(140, 33)
        Me.textboxDominio.MaxLength = 7
        Me.textboxDominio.Name = "textboxDominio"
        Me.textboxDominio.Size = New System.Drawing.Size(74, 20)
        Me.textboxDominio.TabIndex = 3
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(518, 309)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.groupboxSeguro)
        Me.tabpageGeneral.Controls.Add(Me.maskedtextboxAnio)
        Me.tabpageGeneral.Controls.Add(Me.labelAnio)
        Me.tabpageGeneral.Controls.Add(labelModelo)
        Me.tabpageGeneral.Controls.Add(Me.textboxModelo)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerVerificacionVencimiento)
        Me.tabpageGeneral.Controls.Add(Me.labelVerificacionVencimiento)
        Me.tabpageGeneral.Controls.Add(labelTipo)
        Me.tabpageGeneral.Controls.Add(labelDominio)
        Me.tabpageGeneral.Controls.Add(Me.comboboxTipo)
        Me.tabpageGeneral.Controls.Add(Me.textboxDominio)
        Me.tabpageGeneral.Controls.Add(labelMarca)
        Me.tabpageGeneral.Controls.Add(Me.comboboxMarca)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(510, 280)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'groupboxSeguro
        '
        Me.groupboxSeguro.Controls.Add(Me.datetimepickerSeguroVencimiento)
        Me.groupboxSeguro.Controls.Add(Me.labelSeguroVencimiento)
        Me.groupboxSeguro.Controls.Add(labelCompaniaSeguro)
        Me.groupboxSeguro.Controls.Add(Me.comboboxCompaniaSeguro)
        Me.groupboxSeguro.Controls.Add(Me.textboxSeguroPolizaNumero)
        Me.groupboxSeguro.Controls.Add(labelFolioNumero)
        Me.groupboxSeguro.Location = New System.Drawing.Point(9, 164)
        Me.groupboxSeguro.Name = "groupboxSeguro"
        Me.groupboxSeguro.Size = New System.Drawing.Size(495, 106)
        Me.groupboxSeguro.TabIndex = 12
        Me.groupboxSeguro.TabStop = False
        Me.groupboxSeguro.Text = "Seguro:"
        '
        'datetimepickerSeguroVencimiento
        '
        Me.datetimepickerSeguroVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerSeguroVencimiento.Location = New System.Drawing.Point(131, 72)
        Me.datetimepickerSeguroVencimiento.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerSeguroVencimiento.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerSeguroVencimiento.Name = "datetimepickerSeguroVencimiento"
        Me.datetimepickerSeguroVencimiento.ShowCheckBox = True
        Me.datetimepickerSeguroVencimiento.Size = New System.Drawing.Size(135, 20)
        Me.datetimepickerSeguroVencimiento.TabIndex = 5
        '
        'labelSeguroVencimiento
        '
        Me.labelSeguroVencimiento.AutoSize = True
        Me.labelSeguroVencimiento.Location = New System.Drawing.Point(9, 75)
        Me.labelSeguroVencimiento.Name = "labelSeguroVencimiento"
        Me.labelSeguroVencimiento.Size = New System.Drawing.Size(68, 13)
        Me.labelSeguroVencimiento.TabIndex = 4
        Me.labelSeguroVencimiento.Text = "Vencimiento:"
        '
        'comboboxCompaniaSeguro
        '
        Me.comboboxCompaniaSeguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCompaniaSeguro.FormattingEnabled = True
        Me.comboboxCompaniaSeguro.Location = New System.Drawing.Point(131, 19)
        Me.comboboxCompaniaSeguro.Name = "comboboxCompaniaSeguro"
        Me.comboboxCompaniaSeguro.Size = New System.Drawing.Size(340, 21)
        Me.comboboxCompaniaSeguro.TabIndex = 1
        '
        'textboxSeguroPolizaNumero
        '
        Me.textboxSeguroPolizaNumero.Location = New System.Drawing.Point(131, 46)
        Me.textboxSeguroPolizaNumero.MaxLength = 50
        Me.textboxSeguroPolizaNumero.Name = "textboxSeguroPolizaNumero"
        Me.textboxSeguroPolizaNumero.Size = New System.Drawing.Size(234, 20)
        Me.textboxSeguroPolizaNumero.TabIndex = 3
        '
        'maskedtextboxAnio
        '
        Me.maskedtextboxAnio.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxAnio.Location = New System.Drawing.Point(140, 112)
        Me.maskedtextboxAnio.Mask = "9999"
        Me.maskedtextboxAnio.Name = "maskedtextboxAnio"
        Me.maskedtextboxAnio.Size = New System.Drawing.Size(47, 20)
        Me.maskedtextboxAnio.TabIndex = 9
        Me.maskedtextboxAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.maskedtextboxAnio.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'labelAnio
        '
        Me.labelAnio.AutoSize = True
        Me.labelAnio.Location = New System.Drawing.Point(6, 115)
        Me.labelAnio.Name = "labelAnio"
        Me.labelAnio.Size = New System.Drawing.Size(29, 13)
        Me.labelAnio.TabIndex = 8
        Me.labelAnio.Text = "Año:"
        '
        'textboxModelo
        '
        Me.textboxModelo.Location = New System.Drawing.Point(140, 86)
        Me.textboxModelo.MaxLength = 50
        Me.textboxModelo.Name = "textboxModelo"
        Me.textboxModelo.Size = New System.Drawing.Size(234, 20)
        Me.textboxModelo.TabIndex = 7
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelIDVehiculo)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxIDVehiculo)
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(510, 280)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelIDVehiculo
        '
        Me.labelIDVehiculo.AutoSize = True
        Me.labelIDVehiculo.Location = New System.Drawing.Point(6, 205)
        Me.labelIDVehiculo.Name = "labelIDVehiculo"
        Me.labelIDVehiculo.Size = New System.Drawing.Size(80, 13)
        Me.labelIDVehiculo.TabIndex = 16
        Me.labelIDVehiculo.Text = "ID de Vehiculo:"
        '
        'textboxIDVehiculo
        '
        Me.textboxIDVehiculo.Location = New System.Drawing.Point(114, 202)
        Me.textboxIDVehiculo.MaxLength = 10
        Me.textboxIDVehiculo.Name = "textboxIDVehiculo"
        Me.textboxIDVehiculo.ReadOnly = True
        Me.textboxIDVehiculo.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDVehiculo.TabIndex = 17
        Me.textboxIDVehiculo.TabStop = False
        Me.textboxIDVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 254)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 23
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 228)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 20
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 254)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 22
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 228)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 19
        '
        'formPersonaVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 362)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPersonaVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Vehículo de la Persona"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        Me.groupboxSeguro.ResumeLayout(False)
        Me.groupboxSeguro.PerformLayout()
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
    Friend WithEvents datetimepickerVerificacionVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelVerificacionVencimiento As System.Windows.Forms.Label
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents comboboxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxMarca As System.Windows.Forms.ComboBox
    Friend WithEvents textboxDominio As System.Windows.Forms.TextBox
    Friend WithEvents tabcontrolMain As CSBomberos.DesktopApplication.CS_Control_TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents labelIDVehiculo As System.Windows.Forms.Label
    Friend WithEvents textboxIDVehiculo As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxModelo As System.Windows.Forms.TextBox
    Friend WithEvents maskedtextboxAnio As MaskedTextBox
    Friend WithEvents labelAnio As Label
    Friend WithEvents groupboxSeguro As GroupBox
    Friend WithEvents comboboxCompaniaSeguro As ComboBox
    Friend WithEvents textboxSeguroPolizaNumero As TextBox
    Friend WithEvents datetimepickerSeguroVencimiento As DateTimePicker
    Friend WithEvents labelSeguroVencimiento As Label
End Class
