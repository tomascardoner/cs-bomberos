﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUnidad
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
        Dim labelEsActivo As System.Windows.Forms.Label
        Dim labelCuartel As System.Windows.Forms.Label
        Dim labelUnidadTipo As System.Windows.Forms.Label
        Dim labelCombustibleTipo As System.Windows.Forms.Label
        Dim labelFechaAdquisicion As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim lalbelUnidadUso As System.Windows.Forms.Label
        Dim labelEsPropio As System.Windows.Forms.Label
        Dim labelEsImportado As System.Windows.Forms.Label
        Dim labelVerificacionVencimiento As System.Windows.Forms.Label
        Me.labelUnidadBajaMotivo = New System.Windows.Forms.Label()
        Me.textboxModelo = New System.Windows.Forms.TextBox()
        Me.labelModelo = New System.Windows.Forms.Label()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.comboboxCuartel = New System.Windows.Forms.ComboBox()
        Me.comboboxUnidadTipo = New System.Windows.Forms.ComboBox()
        Me.labelNumero = New System.Windows.Forms.Label()
        Me.textboxMarca = New System.Windows.Forms.TextBox()
        Me.labelMarca = New System.Windows.Forms.Label()
        Me.labelAnio = New System.Windows.Forms.Label()
        Me.textboxDominio = New System.Windows.Forms.TextBox()
        Me.labelDominio = New System.Windows.Forms.Label()
        Me.comboboxCombustibleTipo = New System.Windows.Forms.ComboBox()
        Me.labelKilometrajeInicial = New System.Windows.Forms.Label()
        Me.labelCapacidadAguaLitros = New System.Windows.Forms.Label()
        Me.datetimepickerFechaAdquisicion = New System.Windows.Forms.DateTimePicker()
        Me.maskedtextboxNumero = New System.Windows.Forms.MaskedTextBox()
        Me.maskedtextboxAnio = New System.Windows.Forms.MaskedTextBox()
        Me.maskedtextboxKilometrajeInicial = New System.Windows.Forms.MaskedTextBox()
        Me.maskedtextboxCapacidadAguaLitros = New System.Windows.Forms.MaskedTextBox()
        Me.buttonNumeroSiguiente = New System.Windows.Forms.Button()
        Me.tabcontrolMain = New System.Windows.Forms.TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.datetimepickerVerificacionVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.checkboxEsImportado = New System.Windows.Forms.CheckBox()
        Me.checkboxEsPropio = New System.Windows.Forms.CheckBox()
        Me.comboboxUnidadUso = New System.Windows.Forms.ComboBox()
        Me.labelNumeroChasis = New System.Windows.Forms.Label()
        Me.textboxNumeroChasis = New System.Windows.Forms.TextBox()
        Me.labelNumeroMotor = New System.Windows.Forms.Label()
        Me.textboxNumeroMotor = New System.Windows.Forms.TextBox()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.comboboxUnidadBajaMotivo = New System.Windows.Forms.ComboBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.labelIDUnidad = New System.Windows.Forms.Label()
        Me.textboxIDUnidad = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        labelEsActivo = New System.Windows.Forms.Label()
        labelCuartel = New System.Windows.Forms.Label()
        labelUnidadTipo = New System.Windows.Forms.Label()
        labelCombustibleTipo = New System.Windows.Forms.Label()
        labelFechaAdquisicion = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        lalbelUnidadUso = New System.Windows.Forms.Label()
        labelEsPropio = New System.Windows.Forms.Label()
        labelEsImportado = New System.Windows.Forms.Label()
        labelVerificacionVencimiento = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelEsActivo
        '
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(6, 332)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 2
        labelEsActivo.Text = "Activo:"
        '
        'labelCuartel
        '
        labelCuartel.AutoSize = True
        labelCuartel.Location = New System.Drawing.Point(7, 376)
        labelCuartel.Name = "labelCuartel"
        labelCuartel.Size = New System.Drawing.Size(43, 13)
        labelCuartel.TabIndex = 29
        labelCuartel.Text = "Cuartel:"
        '
        'labelUnidadTipo
        '
        labelUnidadTipo.AutoSize = True
        labelUnidadTipo.Location = New System.Drawing.Point(8, 217)
        labelUnidadTipo.Name = "labelUnidadTipo"
        labelUnidadTipo.Size = New System.Drawing.Size(31, 13)
        labelUnidadTipo.TabIndex = 17
        labelUnidadTipo.Text = "Tipo:"
        '
        'labelCombustibleTipo
        '
        labelCombustibleTipo.AutoSize = True
        labelCombustibleTipo.Location = New System.Drawing.Point(7, 271)
        labelCombustibleTipo.Name = "labelCombustibleTipo"
        labelCombustibleTipo.Size = New System.Drawing.Size(105, 13)
        labelCombustibleTipo.TabIndex = 21
        labelCombustibleTipo.Text = "Tipo de combustible:"
        '
        'labelFechaAdquisicion
        '
        labelFechaAdquisicion.AutoSize = True
        labelFechaAdquisicion.Location = New System.Drawing.Point(7, 297)
        labelFechaAdquisicion.Name = "labelFechaAdquisicion"
        labelFechaAdquisicion.Size = New System.Drawing.Size(111, 13)
        labelFechaAdquisicion.TabIndex = 23
        labelFechaAdquisicion.Text = "Fecha de adquisición:"
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 434)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 11
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 408)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 8
        labelCreacion.Text = "Creación:"
        '
        'lalbelUnidadUso
        '
        lalbelUnidadUso.AutoSize = True
        lalbelUnidadUso.Location = New System.Drawing.Point(8, 244)
        lalbelUnidadUso.Name = "lalbelUnidadUso"
        lalbelUnidadUso.Size = New System.Drawing.Size(29, 13)
        lalbelUnidadUso.TabIndex = 19
        lalbelUnidadUso.Text = "Uso:"
        '
        'labelEsPropio
        '
        labelEsPropio.AutoSize = True
        labelEsPropio.Location = New System.Drawing.Point(7, 403)
        labelEsPropio.Name = "labelEsPropio"
        labelEsPropio.Size = New System.Drawing.Size(54, 13)
        labelEsPropio.TabIndex = 31
        labelEsPropio.Text = "Es propio:"
        '
        'labelEsImportado
        '
        labelEsImportado.AutoSize = True
        labelEsImportado.Location = New System.Drawing.Point(7, 87)
        labelEsImportado.Name = "labelEsImportado"
        labelEsImportado.Size = New System.Drawing.Size(71, 13)
        labelEsImportado.TabIndex = 7
        labelEsImportado.Text = "Es importado:"
        '
        'labelVerificacionVencimiento
        '
        labelVerificacionVencimiento.AutoSize = True
        labelVerificacionVencimiento.Location = New System.Drawing.Point(7, 428)
        labelVerificacionVencimiento.Name = "labelVerificacionVencimiento"
        labelVerificacionVencimiento.Size = New System.Drawing.Size(126, 13)
        labelVerificacionVencimiento.TabIndex = 33
        labelVerificacionVencimiento.Text = "Vencimiento Verificación:"
        '
        'labelUnidadBajaMotivo
        '
        Me.labelUnidadBajaMotivo.AutoSize = True
        Me.labelUnidadBajaMotivo.Location = New System.Drawing.Point(6, 355)
        Me.labelUnidadBajaMotivo.Name = "labelUnidadBajaMotivo"
        Me.labelUnidadBajaMotivo.Size = New System.Drawing.Size(81, 13)
        Me.labelUnidadBajaMotivo.TabIndex = 4
        Me.labelUnidadBajaMotivo.Text = "Motivo de Baja:"
        '
        'textboxModelo
        '
        Me.textboxModelo.Location = New System.Drawing.Point(138, 58)
        Me.textboxModelo.MaxLength = 50
        Me.textboxModelo.Name = "textboxModelo"
        Me.textboxModelo.Size = New System.Drawing.Size(266, 20)
        Me.textboxModelo.TabIndex = 6
        '
        'labelModelo
        '
        Me.labelModelo.AutoSize = True
        Me.labelModelo.Location = New System.Drawing.Point(7, 61)
        Me.labelModelo.Name = "labelModelo"
        Me.labelModelo.Size = New System.Drawing.Size(45, 13)
        Me.labelModelo.TabIndex = 5
        Me.labelModelo.Text = "Modelo:"
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
        Me.toolstripMain.Size = New System.Drawing.Size(481, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(114, 332)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 3
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'comboboxCuartel
        '
        Me.comboboxCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCuartel.FormattingEnabled = True
        Me.comboboxCuartel.Location = New System.Drawing.Point(138, 373)
        Me.comboboxCuartel.Name = "comboboxCuartel"
        Me.comboboxCuartel.Size = New System.Drawing.Size(267, 21)
        Me.comboboxCuartel.TabIndex = 30
        '
        'comboboxUnidadTipo
        '
        Me.comboboxUnidadTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxUnidadTipo.FormattingEnabled = True
        Me.comboboxUnidadTipo.Location = New System.Drawing.Point(139, 214)
        Me.comboboxUnidadTipo.Name = "comboboxUnidadTipo"
        Me.comboboxUnidadTipo.Size = New System.Drawing.Size(267, 21)
        Me.comboboxUnidadTipo.TabIndex = 18
        '
        'labelNumero
        '
        Me.labelNumero.AutoSize = True
        Me.labelNumero.Location = New System.Drawing.Point(7, 9)
        Me.labelNumero.Name = "labelNumero"
        Me.labelNumero.Size = New System.Drawing.Size(47, 13)
        Me.labelNumero.TabIndex = 0
        Me.labelNumero.Text = "Número:"
        '
        'textboxMarca
        '
        Me.textboxMarca.Location = New System.Drawing.Point(138, 32)
        Me.textboxMarca.MaxLength = 50
        Me.textboxMarca.Name = "textboxMarca"
        Me.textboxMarca.Size = New System.Drawing.Size(266, 20)
        Me.textboxMarca.TabIndex = 4
        '
        'labelMarca
        '
        Me.labelMarca.AutoSize = True
        Me.labelMarca.Location = New System.Drawing.Point(7, 35)
        Me.labelMarca.Name = "labelMarca"
        Me.labelMarca.Size = New System.Drawing.Size(40, 13)
        Me.labelMarca.TabIndex = 3
        Me.labelMarca.Text = "Marca:"
        '
        'labelAnio
        '
        Me.labelAnio.AutoSize = True
        Me.labelAnio.Location = New System.Drawing.Point(8, 113)
        Me.labelAnio.Name = "labelAnio"
        Me.labelAnio.Size = New System.Drawing.Size(29, 13)
        Me.labelAnio.TabIndex = 9
        Me.labelAnio.Text = "Año:"
        '
        'textboxDominio
        '
        Me.textboxDominio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textboxDominio.Location = New System.Drawing.Point(139, 188)
        Me.textboxDominio.MaxLength = 7
        Me.textboxDominio.Name = "textboxDominio"
        Me.textboxDominio.Size = New System.Drawing.Size(74, 20)
        Me.textboxDominio.TabIndex = 16
        '
        'labelDominio
        '
        Me.labelDominio.AutoSize = True
        Me.labelDominio.Location = New System.Drawing.Point(8, 191)
        Me.labelDominio.Name = "labelDominio"
        Me.labelDominio.Size = New System.Drawing.Size(48, 13)
        Me.labelDominio.TabIndex = 15
        Me.labelDominio.Text = "Dominio:"
        '
        'comboboxCombustibleTipo
        '
        Me.comboboxCombustibleTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCombustibleTipo.FormattingEnabled = True
        Me.comboboxCombustibleTipo.Location = New System.Drawing.Point(138, 268)
        Me.comboboxCombustibleTipo.Name = "comboboxCombustibleTipo"
        Me.comboboxCombustibleTipo.Size = New System.Drawing.Size(267, 21)
        Me.comboboxCombustibleTipo.TabIndex = 22
        '
        'labelKilometrajeInicial
        '
        Me.labelKilometrajeInicial.AutoSize = True
        Me.labelKilometrajeInicial.Location = New System.Drawing.Point(7, 324)
        Me.labelKilometrajeInicial.Name = "labelKilometrajeInicial"
        Me.labelKilometrajeInicial.Size = New System.Drawing.Size(90, 13)
        Me.labelKilometrajeInicial.TabIndex = 25
        Me.labelKilometrajeInicial.Text = "Kilometraje inicial:"
        '
        'labelCapacidadAguaLitros
        '
        Me.labelCapacidadAguaLitros.AutoSize = True
        Me.labelCapacidadAguaLitros.Location = New System.Drawing.Point(7, 350)
        Me.labelCapacidadAguaLitros.Name = "labelCapacidadAguaLitros"
        Me.labelCapacidadAguaLitros.Size = New System.Drawing.Size(91, 13)
        Me.labelCapacidadAguaLitros.TabIndex = 27
        Me.labelCapacidadAguaLitros.Text = "Capacidad (litros):"
        '
        'datetimepickerFechaAdquisicion
        '
        Me.datetimepickerFechaAdquisicion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaAdquisicion.Location = New System.Drawing.Point(138, 295)
        Me.datetimepickerFechaAdquisicion.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaAdquisicion.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaAdquisicion.Name = "datetimepickerFechaAdquisicion"
        Me.datetimepickerFechaAdquisicion.ShowCheckBox = True
        Me.datetimepickerFechaAdquisicion.Size = New System.Drawing.Size(148, 20)
        Me.datetimepickerFechaAdquisicion.TabIndex = 24
        '
        'maskedtextboxNumero
        '
        Me.maskedtextboxNumero.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxNumero.Location = New System.Drawing.Point(138, 6)
        Me.maskedtextboxNumero.Mask = "99999"
        Me.maskedtextboxNumero.Name = "maskedtextboxNumero"
        Me.maskedtextboxNumero.Size = New System.Drawing.Size(74, 20)
        Me.maskedtextboxNumero.TabIndex = 1
        Me.maskedtextboxNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.maskedtextboxNumero.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxNumero.ValidatingType = GetType(Integer)
        '
        'maskedtextboxAnio
        '
        Me.maskedtextboxAnio.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxAnio.Location = New System.Drawing.Point(139, 110)
        Me.maskedtextboxAnio.Mask = "9999"
        Me.maskedtextboxAnio.Name = "maskedtextboxAnio"
        Me.maskedtextboxAnio.Size = New System.Drawing.Size(47, 20)
        Me.maskedtextboxAnio.TabIndex = 10
        Me.maskedtextboxAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.maskedtextboxAnio.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'maskedtextboxKilometrajeInicial
        '
        Me.maskedtextboxKilometrajeInicial.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxKilometrajeInicial.Location = New System.Drawing.Point(138, 321)
        Me.maskedtextboxKilometrajeInicial.Mask = "9999999"
        Me.maskedtextboxKilometrajeInicial.Name = "maskedtextboxKilometrajeInicial"
        Me.maskedtextboxKilometrajeInicial.Size = New System.Drawing.Size(74, 20)
        Me.maskedtextboxKilometrajeInicial.TabIndex = 26
        Me.maskedtextboxKilometrajeInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.maskedtextboxKilometrajeInicial.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'maskedtextboxCapacidadAguaLitros
        '
        Me.maskedtextboxCapacidadAguaLitros.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxCapacidadAguaLitros.Location = New System.Drawing.Point(138, 347)
        Me.maskedtextboxCapacidadAguaLitros.Mask = "999999"
        Me.maskedtextboxCapacidadAguaLitros.Name = "maskedtextboxCapacidadAguaLitros"
        Me.maskedtextboxCapacidadAguaLitros.Size = New System.Drawing.Size(74, 20)
        Me.maskedtextboxCapacidadAguaLitros.TabIndex = 28
        Me.maskedtextboxCapacidadAguaLitros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.maskedtextboxCapacidadAguaLitros.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'buttonNumeroSiguiente
        '
        Me.buttonNumeroSiguiente.Location = New System.Drawing.Point(218, 5)
        Me.buttonNumeroSiguiente.Name = "buttonNumeroSiguiente"
        Me.buttonNumeroSiguiente.Size = New System.Drawing.Size(103, 20)
        Me.buttonNumeroSiguiente.TabIndex = 2
        Me.buttonNumeroSiguiente.Text = "Obtener siguiente"
        Me.buttonNumeroSiguiente.UseVisualStyleBackColor = True
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(459, 486)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerVerificacionVencimiento)
        Me.tabpageGeneral.Controls.Add(labelVerificacionVencimiento)
        Me.tabpageGeneral.Controls.Add(Me.checkboxEsImportado)
        Me.tabpageGeneral.Controls.Add(labelEsImportado)
        Me.tabpageGeneral.Controls.Add(Me.checkboxEsPropio)
        Me.tabpageGeneral.Controls.Add(labelEsPropio)
        Me.tabpageGeneral.Controls.Add(lalbelUnidadUso)
        Me.tabpageGeneral.Controls.Add(Me.comboboxUnidadUso)
        Me.tabpageGeneral.Controls.Add(Me.labelNumeroChasis)
        Me.tabpageGeneral.Controls.Add(Me.textboxNumeroChasis)
        Me.tabpageGeneral.Controls.Add(Me.labelNumeroMotor)
        Me.tabpageGeneral.Controls.Add(Me.textboxNumeroMotor)
        Me.tabpageGeneral.Controls.Add(Me.maskedtextboxNumero)
        Me.tabpageGeneral.Controls.Add(Me.buttonNumeroSiguiente)
        Me.tabpageGeneral.Controls.Add(Me.labelModelo)
        Me.tabpageGeneral.Controls.Add(Me.maskedtextboxCapacidadAguaLitros)
        Me.tabpageGeneral.Controls.Add(Me.textboxModelo)
        Me.tabpageGeneral.Controls.Add(Me.maskedtextboxKilometrajeInicial)
        Me.tabpageGeneral.Controls.Add(labelCuartel)
        Me.tabpageGeneral.Controls.Add(Me.maskedtextboxAnio)
        Me.tabpageGeneral.Controls.Add(Me.comboboxCuartel)
        Me.tabpageGeneral.Controls.Add(labelUnidadTipo)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFechaAdquisicion)
        Me.tabpageGeneral.Controls.Add(Me.comboboxUnidadTipo)
        Me.tabpageGeneral.Controls.Add(labelFechaAdquisicion)
        Me.tabpageGeneral.Controls.Add(Me.labelNumero)
        Me.tabpageGeneral.Controls.Add(Me.labelCapacidadAguaLitros)
        Me.tabpageGeneral.Controls.Add(Me.labelMarca)
        Me.tabpageGeneral.Controls.Add(Me.labelKilometrajeInicial)
        Me.tabpageGeneral.Controls.Add(Me.textboxMarca)
        Me.tabpageGeneral.Controls.Add(Me.comboboxCombustibleTipo)
        Me.tabpageGeneral.Controls.Add(Me.labelAnio)
        Me.tabpageGeneral.Controls.Add(labelCombustibleTipo)
        Me.tabpageGeneral.Controls.Add(Me.labelDominio)
        Me.tabpageGeneral.Controls.Add(Me.textboxDominio)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(451, 457)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'datetimepickerVerificacionVencimiento
        '
        Me.datetimepickerVerificacionVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerVerificacionVencimiento.Location = New System.Drawing.Point(138, 426)
        Me.datetimepickerVerificacionVencimiento.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerVerificacionVencimiento.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerVerificacionVencimiento.Name = "datetimepickerVerificacionVencimiento"
        Me.datetimepickerVerificacionVencimiento.ShowCheckBox = True
        Me.datetimepickerVerificacionVencimiento.Size = New System.Drawing.Size(148, 20)
        Me.datetimepickerVerificacionVencimiento.TabIndex = 34
        '
        'checkboxEsImportado
        '
        Me.checkboxEsImportado.AutoSize = True
        Me.checkboxEsImportado.Location = New System.Drawing.Point(138, 87)
        Me.checkboxEsImportado.Name = "checkboxEsImportado"
        Me.checkboxEsImportado.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsImportado.TabIndex = 8
        Me.checkboxEsImportado.UseVisualStyleBackColor = True
        '
        'checkboxEsPropio
        '
        Me.checkboxEsPropio.AutoSize = True
        Me.checkboxEsPropio.Location = New System.Drawing.Point(139, 403)
        Me.checkboxEsPropio.Name = "checkboxEsPropio"
        Me.checkboxEsPropio.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsPropio.TabIndex = 32
        Me.checkboxEsPropio.UseVisualStyleBackColor = True
        '
        'comboboxUnidadUso
        '
        Me.comboboxUnidadUso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxUnidadUso.FormattingEnabled = True
        Me.comboboxUnidadUso.Location = New System.Drawing.Point(139, 241)
        Me.comboboxUnidadUso.Name = "comboboxUnidadUso"
        Me.comboboxUnidadUso.Size = New System.Drawing.Size(267, 21)
        Me.comboboxUnidadUso.TabIndex = 20
        '
        'labelNumeroChasis
        '
        Me.labelNumeroChasis.AutoSize = True
        Me.labelNumeroChasis.Location = New System.Drawing.Point(8, 165)
        Me.labelNumeroChasis.Name = "labelNumeroChasis"
        Me.labelNumeroChasis.Size = New System.Drawing.Size(70, 13)
        Me.labelNumeroChasis.TabIndex = 13
        Me.labelNumeroChasis.Text = "Nº de chasis:"
        '
        'textboxNumeroChasis
        '
        Me.textboxNumeroChasis.Location = New System.Drawing.Point(139, 162)
        Me.textboxNumeroChasis.MaxLength = 20
        Me.textboxNumeroChasis.Name = "textboxNumeroChasis"
        Me.textboxNumeroChasis.Size = New System.Drawing.Size(183, 20)
        Me.textboxNumeroChasis.TabIndex = 14
        '
        'labelNumeroMotor
        '
        Me.labelNumeroMotor.AutoSize = True
        Me.labelNumeroMotor.Location = New System.Drawing.Point(8, 139)
        Me.labelNumeroMotor.Name = "labelNumeroMotor"
        Me.labelNumeroMotor.Size = New System.Drawing.Size(66, 13)
        Me.labelNumeroMotor.TabIndex = 11
        Me.labelNumeroMotor.Text = "Nº de motor:"
        '
        'textboxNumeroMotor
        '
        Me.textboxNumeroMotor.Location = New System.Drawing.Point(139, 136)
        Me.textboxNumeroMotor.MaxLength = 20
        Me.textboxNumeroMotor.Name = "textboxNumeroMotor"
        Me.textboxNumeroMotor.Size = New System.Drawing.Size(183, 20)
        Me.textboxNumeroMotor.TabIndex = 12
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelUnidadBajaMotivo)
        Me.tabpageNotasAuditoria.Controls.Add(Me.comboboxUnidadBajaMotivo)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxNotas)
        Me.tabpageNotasAuditoria.Controls.Add(Me.checkboxEsActivo)
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelNotas)
        Me.tabpageNotasAuditoria.Controls.Add(labelEsActivo)
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelIDUnidad)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxIDUnidad)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(labelModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(labelCreacion)
        Me.tabpageNotasAuditoria.Location = New System.Drawing.Point(4, 25)
        Me.tabpageNotasAuditoria.Name = "tabpageNotasAuditoria"
        Me.tabpageNotasAuditoria.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(451, 457)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'comboboxUnidadBajaMotivo
        '
        Me.comboboxUnidadBajaMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxUnidadBajaMotivo.FormattingEnabled = True
        Me.comboboxUnidadBajaMotivo.Location = New System.Drawing.Point(114, 352)
        Me.comboboxUnidadBajaMotivo.Name = "comboboxUnidadBajaMotivo"
        Me.comboboxUnidadBajaMotivo.Size = New System.Drawing.Size(329, 21)
        Me.comboboxUnidadBajaMotivo.TabIndex = 5
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(114, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(329, 320)
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
        'labelIDUnidad
        '
        Me.labelIDUnidad.AutoSize = True
        Me.labelIDUnidad.Location = New System.Drawing.Point(6, 382)
        Me.labelIDUnidad.Name = "labelIDUnidad"
        Me.labelIDUnidad.Size = New System.Drawing.Size(21, 13)
        Me.labelIDUnidad.TabIndex = 6
        Me.labelIDUnidad.Text = "ID:"
        '
        'textboxIDUnidad
        '
        Me.textboxIDUnidad.Location = New System.Drawing.Point(114, 379)
        Me.textboxIDUnidad.MaxLength = 10
        Me.textboxIDUnidad.Name = "textboxIDUnidad"
        Me.textboxIDUnidad.ReadOnly = True
        Me.textboxIDUnidad.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDUnidad.TabIndex = 7
        Me.textboxIDUnidad.TabStop = False
        Me.textboxIDUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 431)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(202, 20)
        Me.textboxUsuarioModificacion.TabIndex = 13
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 405)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(202, 20)
        Me.textboxUsuarioCreacion.TabIndex = 10
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 431)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 12
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 405)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 9
        '
        'formUnidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 540)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formUnidad"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Unidad"
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
    Friend WithEvents textboxModelo As System.Windows.Forms.TextBox
    Friend WithEvents labelModelo As System.Windows.Forms.Label
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents checkboxEsActivo As System.Windows.Forms.CheckBox
    Friend WithEvents comboboxCuartel As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxUnidadTipo As System.Windows.Forms.ComboBox
    Friend WithEvents labelNumero As System.Windows.Forms.Label
    Friend WithEvents textboxMarca As System.Windows.Forms.TextBox
    Friend WithEvents labelMarca As System.Windows.Forms.Label
    Friend WithEvents labelAnio As System.Windows.Forms.Label
    Friend WithEvents textboxDominio As System.Windows.Forms.TextBox
    Friend WithEvents labelDominio As System.Windows.Forms.Label
    Friend WithEvents comboboxCombustibleTipo As System.Windows.Forms.ComboBox
    Friend WithEvents labelKilometrajeInicial As System.Windows.Forms.Label
    Friend WithEvents labelCapacidadAguaLitros As System.Windows.Forms.Label
    Friend WithEvents datetimepickerFechaAdquisicion As System.Windows.Forms.DateTimePicker
    Friend WithEvents maskedtextboxNumero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents maskedtextboxAnio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents maskedtextboxKilometrajeInicial As System.Windows.Forms.MaskedTextBox
    Friend WithEvents maskedtextboxCapacidadAguaLitros As System.Windows.Forms.MaskedTextBox
    Friend WithEvents buttonNumeroSiguiente As System.Windows.Forms.Button
    Friend WithEvents tabcontrolMain As System.Windows.Forms.TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents labelIDUnidad As System.Windows.Forms.Label
    Friend WithEvents textboxIDUnidad As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents labelNumeroChasis As System.Windows.Forms.Label
    Friend WithEvents textboxNumeroChasis As System.Windows.Forms.TextBox
    Friend WithEvents labelNumeroMotor As System.Windows.Forms.Label
    Friend WithEvents textboxNumeroMotor As System.Windows.Forms.TextBox
    Friend WithEvents checkboxEsPropio As System.Windows.Forms.CheckBox
    Friend WithEvents comboboxUnidadUso As System.Windows.Forms.ComboBox
    Friend WithEvents checkboxEsImportado As System.Windows.Forms.CheckBox
    Friend WithEvents datetimepickerVerificacionVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents comboboxUnidadBajaMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents labelUnidadBajaMotivo As System.Windows.Forms.Label
End Class
