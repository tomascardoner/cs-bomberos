<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formComprobanteMedioPago
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
        Me.labelCuentaBancariaCbuAlias = New System.Windows.Forms.Label()
        Me.labelCuentaBancariaCbu = New System.Windows.Forms.Label()
        Me.labelCuentaBancariaTipo = New System.Windows.Forms.Label()
        Me.labelBanco = New System.Windows.Forms.Label()
        Me.labelCuentaBancariaNumero = New System.Windows.Forms.Label()
        Me.labelCuentaBancariaSucursal = New System.Windows.Forms.Label()
        Me.labelMedioPago = New System.Windows.Forms.Label()
        Me.comboboxMedioPago = New System.Windows.Forms.ComboBox()
        Me.labelImporte = New System.Windows.Forms.Label()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.labelFechaHora = New System.Windows.Forms.Label()
        Me.datetimepickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerHora = New System.Windows.Forms.DateTimePicker()
        Me.labelNumero = New System.Windows.Forms.Label()
        Me.textboxNumero = New System.Windows.Forms.TextBox()
        Me.currencytextboxImporte = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.groupboxDatosBancarios = New System.Windows.Forms.GroupBox()
        Me.labelCuentaBancariaCuit = New System.Windows.Forms.Label()
        Me.maskedtextboxCuentaBancariaCuit = New System.Windows.Forms.MaskedTextBox()
        Me.maskedtextboxCuentaBancariaSucursal = New System.Windows.Forms.MaskedTextBox()
        Me.maskedtextboxCuentaBancariaCbu = New System.Windows.Forms.MaskedTextBox()
        Me.textboxCuentaBancariaCbuAlias = New System.Windows.Forms.TextBox()
        Me.comboboxCuentaBancariaTipo = New System.Windows.Forms.ComboBox()
        Me.comboboxBanco = New System.Windows.Forms.ComboBox()
        Me.textboxCuentaBancariaNumero = New System.Windows.Forms.TextBox()
        Me.textboxTitular = New System.Windows.Forms.TextBox()
        Me.labelTitular = New System.Windows.Forms.Label()
        Me.buttonCopiarDatosBancarios = New System.Windows.Forms.Button()
        Me.toolstripMain.SuspendLayout()
        CType(Me.currencytextboxImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupboxDatosBancarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelCuentaBancariaCbuAlias
        '
        Me.labelCuentaBancariaCbuAlias.AutoSize = True
        Me.labelCuentaBancariaCbuAlias.Location = New System.Drawing.Point(6, 157)
        Me.labelCuentaBancariaCbuAlias.Name = "labelCuentaBancariaCbuAlias"
        Me.labelCuentaBancariaCbuAlias.Size = New System.Drawing.Size(57, 13)
        Me.labelCuentaBancariaCbuAlias.TabIndex = 10
        Me.labelCuentaBancariaCbuAlias.Text = "CBU Alias:"
        '
        'labelCuentaBancariaCbu
        '
        Me.labelCuentaBancariaCbu.AutoSize = True
        Me.labelCuentaBancariaCbu.Location = New System.Drawing.Point(6, 131)
        Me.labelCuentaBancariaCbu.Name = "labelCuentaBancariaCbu"
        Me.labelCuentaBancariaCbu.Size = New System.Drawing.Size(32, 13)
        Me.labelCuentaBancariaCbu.TabIndex = 8
        Me.labelCuentaBancariaCbu.Text = "CBU:"
        '
        'labelCuentaBancariaTipo
        '
        Me.labelCuentaBancariaTipo.AutoSize = True
        Me.labelCuentaBancariaTipo.Location = New System.Drawing.Point(6, 53)
        Me.labelCuentaBancariaTipo.Name = "labelCuentaBancariaTipo"
        Me.labelCuentaBancariaTipo.Size = New System.Drawing.Size(31, 13)
        Me.labelCuentaBancariaTipo.TabIndex = 2
        Me.labelCuentaBancariaTipo.Text = "Tipo:"
        '
        'labelBanco
        '
        Me.labelBanco.AutoSize = True
        Me.labelBanco.Location = New System.Drawing.Point(6, 26)
        Me.labelBanco.Name = "labelBanco"
        Me.labelBanco.Size = New System.Drawing.Size(41, 13)
        Me.labelBanco.TabIndex = 0
        Me.labelBanco.Text = "Banco:"
        '
        'labelCuentaBancariaNumero
        '
        Me.labelCuentaBancariaNumero.AutoSize = True
        Me.labelCuentaBancariaNumero.Location = New System.Drawing.Point(6, 105)
        Me.labelCuentaBancariaNumero.Name = "labelCuentaBancariaNumero"
        Me.labelCuentaBancariaNumero.Size = New System.Drawing.Size(47, 13)
        Me.labelCuentaBancariaNumero.TabIndex = 6
        Me.labelCuentaBancariaNumero.Text = "Número:"
        '
        'labelCuentaBancariaSucursal
        '
        Me.labelCuentaBancariaSucursal.AutoSize = True
        Me.labelCuentaBancariaSucursal.Location = New System.Drawing.Point(6, 79)
        Me.labelCuentaBancariaSucursal.Name = "labelCuentaBancariaSucursal"
        Me.labelCuentaBancariaSucursal.Size = New System.Drawing.Size(51, 13)
        Me.labelCuentaBancariaSucursal.TabIndex = 4
        Me.labelCuentaBancariaSucursal.Text = "Sucursal:"
        '
        'labelMedioPago
        '
        Me.labelMedioPago.AutoSize = True
        Me.labelMedioPago.Location = New System.Drawing.Point(12, 53)
        Me.labelMedioPago.Name = "labelMedioPago"
        Me.labelMedioPago.Size = New System.Drawing.Size(31, 13)
        Me.labelMedioPago.TabIndex = 0
        Me.labelMedioPago.Text = "Tipo:"
        '
        'comboboxMedioPago
        '
        Me.comboboxMedioPago.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboboxMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxMedioPago.FormattingEnabled = True
        Me.comboboxMedioPago.Location = New System.Drawing.Point(86, 50)
        Me.comboboxMedioPago.Name = "comboboxMedioPago"
        Me.comboboxMedioPago.Size = New System.Drawing.Size(344, 21)
        Me.comboboxMedioPago.TabIndex = 1
        '
        'labelImporte
        '
        Me.labelImporte.AutoSize = True
        Me.labelImporte.Location = New System.Drawing.Point(12, 401)
        Me.labelImporte.Name = "labelImporte"
        Me.labelImporte.Size = New System.Drawing.Size(45, 13)
        Me.labelImporte.TabIndex = 10
        Me.labelImporte.Text = "Importe:"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(442, 39)
        Me.toolstripMain.TabIndex = 12
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
        'labelFechaHora
        '
        Me.labelFechaHora.AutoSize = True
        Me.labelFechaHora.Location = New System.Drawing.Point(12, 94)
        Me.labelFechaHora.Name = "labelFechaHora"
        Me.labelFechaHora.Size = New System.Drawing.Size(68, 13)
        Me.labelFechaHora.TabIndex = 2
        Me.labelFechaHora.Text = "Fecha/Hora:"
        '
        'datetimepickerFecha
        '
        Me.datetimepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFecha.Location = New System.Drawing.Point(86, 91)
        Me.datetimepickerFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFecha.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFecha.Name = "datetimepickerFecha"
        Me.datetimepickerFecha.Size = New System.Drawing.Size(110, 20)
        Me.datetimepickerFecha.TabIndex = 3
        '
        'datetimepickerHora
        '
        Me.datetimepickerHora.CustomFormat = "HH:mm"
        Me.datetimepickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickerHora.Location = New System.Drawing.Point(202, 91)
        Me.datetimepickerHora.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerHora.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerHora.Name = "datetimepickerHora"
        Me.datetimepickerHora.ShowUpDown = True
        Me.datetimepickerHora.Size = New System.Drawing.Size(62, 20)
        Me.datetimepickerHora.TabIndex = 4
        Me.datetimepickerHora.Value = New Date(2015, 8, 1, 0, 0, 0, 0)
        '
        'labelNumero
        '
        Me.labelNumero.AutoSize = True
        Me.labelNumero.Location = New System.Drawing.Point(12, 120)
        Me.labelNumero.Name = "labelNumero"
        Me.labelNumero.Size = New System.Drawing.Size(47, 13)
        Me.labelNumero.TabIndex = 5
        Me.labelNumero.Text = "Número:"
        '
        'textboxNumero
        '
        Me.textboxNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textboxNumero.Location = New System.Drawing.Point(86, 117)
        Me.textboxNumero.MaxLength = 20
        Me.textboxNumero.Name = "textboxNumero"
        Me.textboxNumero.Size = New System.Drawing.Size(134, 20)
        Me.textboxNumero.TabIndex = 6
        '
        'currencytextboxImporte
        '
        Me.currencytextboxImporte.BeforeTouchSize = New System.Drawing.Size(99, 20)
        Me.currencytextboxImporte.DecimalValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.currencytextboxImporte.Location = New System.Drawing.Point(86, 397)
        Me.currencytextboxImporte.MaxValue = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.currencytextboxImporte.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.currencytextboxImporte.MinValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.currencytextboxImporte.Name = "currencytextboxImporte"
        Me.currencytextboxImporte.NullString = ""
        Me.currencytextboxImporte.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.currencytextboxImporte.Size = New System.Drawing.Size(99, 20)
        Me.currencytextboxImporte.TabIndex = 11
        Me.currencytextboxImporte.Text = "$ 0,00"
        Me.currencytextboxImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'groupboxDatosBancarios
        '
        Me.groupboxDatosBancarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupboxDatosBancarios.Controls.Add(Me.buttonCopiarDatosBancarios)
        Me.groupboxDatosBancarios.Controls.Add(Me.labelCuentaBancariaCuit)
        Me.groupboxDatosBancarios.Controls.Add(Me.maskedtextboxCuentaBancariaCuit)
        Me.groupboxDatosBancarios.Controls.Add(Me.maskedtextboxCuentaBancariaSucursal)
        Me.groupboxDatosBancarios.Controls.Add(Me.maskedtextboxCuentaBancariaCbu)
        Me.groupboxDatosBancarios.Controls.Add(Me.labelCuentaBancariaCbuAlias)
        Me.groupboxDatosBancarios.Controls.Add(Me.textboxCuentaBancariaCbuAlias)
        Me.groupboxDatosBancarios.Controls.Add(Me.labelCuentaBancariaCbu)
        Me.groupboxDatosBancarios.Controls.Add(Me.comboboxCuentaBancariaTipo)
        Me.groupboxDatosBancarios.Controls.Add(Me.labelCuentaBancariaTipo)
        Me.groupboxDatosBancarios.Controls.Add(Me.comboboxBanco)
        Me.groupboxDatosBancarios.Controls.Add(Me.labelBanco)
        Me.groupboxDatosBancarios.Controls.Add(Me.labelCuentaBancariaNumero)
        Me.groupboxDatosBancarios.Controls.Add(Me.textboxCuentaBancariaNumero)
        Me.groupboxDatosBancarios.Controls.Add(Me.labelCuentaBancariaSucursal)
        Me.groupboxDatosBancarios.Location = New System.Drawing.Point(12, 150)
        Me.groupboxDatosBancarios.Name = "groupboxDatosBancarios"
        Me.groupboxDatosBancarios.Size = New System.Drawing.Size(418, 206)
        Me.groupboxDatosBancarios.TabIndex = 7
        Me.groupboxDatosBancarios.TabStop = False
        Me.groupboxDatosBancarios.Text = "Cuenta bancaria"
        '
        'labelCuentaBancariaCuit
        '
        Me.labelCuentaBancariaCuit.AutoSize = True
        Me.labelCuentaBancariaCuit.Location = New System.Drawing.Point(6, 183)
        Me.labelCuentaBancariaCuit.Name = "labelCuentaBancariaCuit"
        Me.labelCuentaBancariaCuit.Size = New System.Drawing.Size(35, 13)
        Me.labelCuentaBancariaCuit.TabIndex = 12
        Me.labelCuentaBancariaCuit.Text = "CUIT:"
        '
        'maskedtextboxCuentaBancariaCuit
        '
        Me.maskedtextboxCuentaBancariaCuit.AllowPromptAsInput = False
        Me.maskedtextboxCuentaBancariaCuit.AsciiOnly = True
        Me.maskedtextboxCuentaBancariaCuit.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxCuentaBancariaCuit.HidePromptOnLeave = True
        Me.maskedtextboxCuentaBancariaCuit.Location = New System.Drawing.Point(74, 180)
        Me.maskedtextboxCuentaBancariaCuit.Mask = "00-00000000-0"
        Me.maskedtextboxCuentaBancariaCuit.Name = "maskedtextboxCuentaBancariaCuit"
        Me.maskedtextboxCuentaBancariaCuit.Size = New System.Drawing.Size(94, 20)
        Me.maskedtextboxCuentaBancariaCuit.TabIndex = 13
        Me.maskedtextboxCuentaBancariaCuit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'maskedtextboxCuentaBancariaSucursal
        '
        Me.maskedtextboxCuentaBancariaSucursal.AllowPromptAsInput = False
        Me.maskedtextboxCuentaBancariaSucursal.AsciiOnly = True
        Me.maskedtextboxCuentaBancariaSucursal.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxCuentaBancariaSucursal.HidePromptOnLeave = True
        Me.maskedtextboxCuentaBancariaSucursal.Location = New System.Drawing.Point(74, 76)
        Me.maskedtextboxCuentaBancariaSucursal.Mask = "9999"
        Me.maskedtextboxCuentaBancariaSucursal.Name = "maskedtextboxCuentaBancariaSucursal"
        Me.maskedtextboxCuentaBancariaSucursal.Size = New System.Drawing.Size(40, 20)
        Me.maskedtextboxCuentaBancariaSucursal.TabIndex = 5
        Me.maskedtextboxCuentaBancariaSucursal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'maskedtextboxCuentaBancariaCbu
        '
        Me.maskedtextboxCuentaBancariaCbu.AllowPromptAsInput = False
        Me.maskedtextboxCuentaBancariaCbu.AsciiOnly = True
        Me.maskedtextboxCuentaBancariaCbu.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxCuentaBancariaCbu.HidePromptOnLeave = True
        Me.maskedtextboxCuentaBancariaCbu.Location = New System.Drawing.Point(74, 128)
        Me.maskedtextboxCuentaBancariaCbu.Margin = New System.Windows.Forms.Padding(2)
        Me.maskedtextboxCuentaBancariaCbu.Mask = "0000000-0 0000000000000-0"
        Me.maskedtextboxCuentaBancariaCbu.Name = "maskedtextboxCuentaBancariaCbu"
        Me.maskedtextboxCuentaBancariaCbu.Size = New System.Drawing.Size(153, 20)
        Me.maskedtextboxCuentaBancariaCbu.TabIndex = 9
        Me.maskedtextboxCuentaBancariaCbu.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'textboxCuentaBancariaCbuAlias
        '
        Me.textboxCuentaBancariaCbuAlias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textboxCuentaBancariaCbuAlias.Location = New System.Drawing.Point(74, 154)
        Me.textboxCuentaBancariaCbuAlias.MaxLength = 50
        Me.textboxCuentaBancariaCbuAlias.Name = "textboxCuentaBancariaCbuAlias"
        Me.textboxCuentaBancariaCbuAlias.Size = New System.Drawing.Size(150, 20)
        Me.textboxCuentaBancariaCbuAlias.TabIndex = 11
        '
        'comboboxCuentaBancariaTipo
        '
        Me.comboboxCuentaBancariaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCuentaBancariaTipo.FormattingEnabled = True
        Me.comboboxCuentaBancariaTipo.Location = New System.Drawing.Point(74, 49)
        Me.comboboxCuentaBancariaTipo.Name = "comboboxCuentaBancariaTipo"
        Me.comboboxCuentaBancariaTipo.Size = New System.Drawing.Size(150, 21)
        Me.comboboxCuentaBancariaTipo.TabIndex = 3
        '
        'comboboxBanco
        '
        Me.comboboxBanco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboboxBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxBanco.FormattingEnabled = True
        Me.comboboxBanco.Location = New System.Drawing.Point(74, 22)
        Me.comboboxBanco.Name = "comboboxBanco"
        Me.comboboxBanco.Size = New System.Drawing.Size(338, 21)
        Me.comboboxBanco.TabIndex = 1
        '
        'textboxCuentaBancariaNumero
        '
        Me.textboxCuentaBancariaNumero.Location = New System.Drawing.Point(74, 102)
        Me.textboxCuentaBancariaNumero.MaxLength = 50
        Me.textboxCuentaBancariaNumero.Name = "textboxCuentaBancariaNumero"
        Me.textboxCuentaBancariaNumero.Size = New System.Drawing.Size(150, 20)
        Me.textboxCuentaBancariaNumero.TabIndex = 7
        '
        'textboxTitular
        '
        Me.textboxTitular.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxTitular.Location = New System.Drawing.Point(86, 365)
        Me.textboxTitular.MaxLength = 50
        Me.textboxTitular.Name = "textboxTitular"
        Me.textboxTitular.Size = New System.Drawing.Size(344, 20)
        Me.textboxTitular.TabIndex = 9
        '
        'labelTitular
        '
        Me.labelTitular.AutoSize = True
        Me.labelTitular.Location = New System.Drawing.Point(12, 368)
        Me.labelTitular.Name = "labelTitular"
        Me.labelTitular.Size = New System.Drawing.Size(39, 13)
        Me.labelTitular.TabIndex = 8
        Me.labelTitular.Text = "Titular:"
        '
        'buttonCopiarDatosBancarios
        '
        Me.buttonCopiarDatosBancarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonCopiarDatosBancarios.Location = New System.Drawing.Point(303, 91)
        Me.buttonCopiarDatosBancarios.Name = "buttonCopiarDatosBancarios"
        Me.buttonCopiarDatosBancarios.Size = New System.Drawing.Size(109, 41)
        Me.buttonCopiarDatosBancarios.TabIndex = 14
        Me.buttonCopiarDatosBancarios.Text = "Obtener datos del proveedor"
        Me.buttonCopiarDatosBancarios.UseVisualStyleBackColor = True
        '
        'formComprobanteMedioPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 427)
        Me.Controls.Add(Me.textboxTitular)
        Me.Controls.Add(Me.labelTitular)
        Me.Controls.Add(Me.groupboxDatosBancarios)
        Me.Controls.Add(Me.currencytextboxImporte)
        Me.Controls.Add(Me.textboxNumero)
        Me.Controls.Add(Me.labelNumero)
        Me.Controls.Add(Me.datetimepickerHora)
        Me.Controls.Add(Me.datetimepickerFecha)
        Me.Controls.Add(Me.labelFechaHora)
        Me.Controls.Add(Me.toolstripMain)
        Me.Controls.Add(Me.labelImporte)
        Me.Controls.Add(Me.comboboxMedioPago)
        Me.Controls.Add(Me.labelMedioPago)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formComprobanteMedioPago"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalle del Medio de Pago"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        CType(Me.currencytextboxImporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupboxDatosBancarios.ResumeLayout(False)
        Me.groupboxDatosBancarios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelMedioPago As System.Windows.Forms.Label
    Friend WithEvents comboboxMedioPago As System.Windows.Forms.ComboBox
    Friend WithEvents labelImporte As System.Windows.Forms.Label
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents labelFechaHora As System.Windows.Forms.Label
    Friend WithEvents datetimepickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents datetimepickerHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelNumero As System.Windows.Forms.Label
    Friend WithEvents textboxNumero As System.Windows.Forms.TextBox
    Friend WithEvents currencytextboxImporte As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents groupboxDatosBancarios As GroupBox
    Private WithEvents textboxTitular As TextBox
    Private WithEvents labelTitular As Label
    Private WithEvents labelCuentaBancariaCuit As Label
    Friend WithEvents maskedtextboxCuentaBancariaCuit As MaskedTextBox
    Private WithEvents maskedtextboxCuentaBancariaSucursal As MaskedTextBox
    Friend WithEvents maskedtextboxCuentaBancariaCbu As MaskedTextBox
    Friend WithEvents textboxCuentaBancariaCbuAlias As TextBox
    Friend WithEvents comboboxCuentaBancariaTipo As ComboBox
    Friend WithEvents comboboxBanco As ComboBox
    Friend WithEvents textboxCuentaBancariaNumero As TextBox
    Friend WithEvents labelCuentaBancariaCbuAlias As Label
    Friend WithEvents labelCuentaBancariaCbu As Label
    Friend WithEvents labelCuentaBancariaTipo As Label
    Friend WithEvents labelBanco As Label
    Friend WithEvents labelCuentaBancariaNumero As Label
    Friend WithEvents labelCuentaBancariaSucursal As Label
    Friend WithEvents buttonCopiarDatosBancarios As Button
End Class
