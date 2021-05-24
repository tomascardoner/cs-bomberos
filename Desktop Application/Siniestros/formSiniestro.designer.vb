<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSiniestro
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
        Dim labelHoraSalida As System.Windows.Forms.Label
        Dim labelCuartel As System.Windows.Forms.Label
        Dim labelHoraFin As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.labelNumero = New System.Windows.Forms.Label()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonImprimir = New System.Windows.Forms.ToolStripButton()
        Me.comboboxSiniestroRubro = New System.Windows.Forms.ComboBox()
        Me.tabcontrolMain = New CSBomberos.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.integertextboxNumeroPrefijo = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.datetimepickerHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.labelClave = New System.Windows.Forms.Label()
        Me.comboboxClave = New System.Windows.Forms.ComboBox()
        Me.labelSiniestroTipoOtro = New System.Windows.Forms.Label()
        Me.textboxSiniestroTipoOtro = New System.Windows.Forms.TextBox()
        Me.labelSiniestroTipo = New System.Windows.Forms.Label()
        Me.comboboxSiniestroTipo = New System.Windows.Forms.ComboBox()
        Me.buttonCodigoSiguiente = New System.Windows.Forms.Button()
        Me.comboboxCuartel = New System.Windows.Forms.ComboBox()
        Me.datetimepickerHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.labelSiniestroRubro = New System.Windows.Forms.Label()
        Me.datetimepickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.integertextboxNumero = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.tabpageDetalles = New System.Windows.Forms.TabPage()
        Me.datagridviewDetalles = New System.Windows.Forms.DataGridView()
        Me.columnPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnSiniestroAsistenciaTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripDetalles = New System.Windows.Forms.ToolStrip()
        Me.buttonDetallesAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonDetallesEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonDetallesEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.checkboxAnulado = New System.Windows.Forms.CheckBox()
        Me.labelAnulado = New System.Windows.Forms.Label()
        Me.labelIDSiniestro = New System.Windows.Forms.Label()
        Me.textboxIDSiniestro = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelHoraSalida = New System.Windows.Forms.Label()
        labelCuartel = New System.Windows.Forms.Label()
        labelHoraFin = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        CType(Me.integertextboxNumeroPrefijo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.integertextboxNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpageDetalles.SuspendLayout()
        CType(Me.datagridviewDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripDetalles.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelModificacion
        '
        labelModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 306)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 9
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 280)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 6
        labelCreacion.Text = "Creación:"
        '
        'labelHoraSalida
        '
        labelHoraSalida.AutoSize = True
        labelHoraSalida.Location = New System.Drawing.Point(6, 205)
        labelHoraSalida.Name = "labelHoraSalida"
        labelHoraSalida.Size = New System.Drawing.Size(78, 13)
        labelHoraSalida.TabIndex = 16
        labelHoraSalida.Text = "Hora de salida:"
        '
        'labelCuartel
        '
        labelCuartel.AutoSize = True
        labelCuartel.Location = New System.Drawing.Point(6, 18)
        labelCuartel.Name = "labelCuartel"
        labelCuartel.Size = New System.Drawing.Size(43, 13)
        labelCuartel.TabIndex = 0
        labelCuartel.Text = "Cuartel:"
        '
        'labelHoraFin
        '
        labelHoraFin.AutoSize = True
        labelHoraFin.Location = New System.Drawing.Point(6, 231)
        labelHoraFin.Name = "labelHoraFin"
        labelHoraFin.Size = New System.Drawing.Size(62, 13)
        labelHoraFin.TabIndex = 18
        labelHoraFin.Text = "Hora de fin:"
        '
        'labelNumero
        '
        Me.labelNumero.AutoSize = True
        Me.labelNumero.Location = New System.Drawing.Point(6, 47)
        Me.labelNumero.Name = "labelNumero"
        Me.labelNumero.Size = New System.Drawing.Size(47, 13)
        Me.labelNumero.TabIndex = 2
        Me.labelNumero.Text = "Número:"
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(6, 71)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelFecha.TabIndex = 6
        Me.labelFecha.Text = "Fecha:"
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
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar, Me.buttonImprimir})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(684, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'buttonImprimir
        '
        Me.buttonImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonImprimir.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_PRINT_32
        Me.buttonImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonImprimir.Name = "buttonImprimir"
        Me.buttonImprimir.Size = New System.Drawing.Size(89, 36)
        Me.buttonImprimir.Text = "Imprimir"
        '
        'comboboxSiniestroRubro
        '
        Me.comboboxSiniestroRubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboboxSiniestroRubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxSiniestroRubro.FormattingEnabled = True
        Me.comboboxSiniestroRubro.Location = New System.Drawing.Point(96, 94)
        Me.comboboxSiniestroRubro.Name = "comboboxSiniestroRubro"
        Me.comboboxSiniestroRubro.Size = New System.Drawing.Size(267, 21)
        Me.comboboxSiniestroRubro.TabIndex = 9
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageDetalles)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(664, 355)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.integertextboxNumeroPrefijo)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerHoraFin)
        Me.tabpageGeneral.Controls.Add(labelHoraFin)
        Me.tabpageGeneral.Controls.Add(Me.labelClave)
        Me.tabpageGeneral.Controls.Add(Me.comboboxClave)
        Me.tabpageGeneral.Controls.Add(Me.labelSiniestroTipoOtro)
        Me.tabpageGeneral.Controls.Add(Me.textboxSiniestroTipoOtro)
        Me.tabpageGeneral.Controls.Add(Me.labelSiniestroTipo)
        Me.tabpageGeneral.Controls.Add(Me.comboboxSiniestroTipo)
        Me.tabpageGeneral.Controls.Add(Me.buttonCodigoSiguiente)
        Me.tabpageGeneral.Controls.Add(Me.comboboxCuartel)
        Me.tabpageGeneral.Controls.Add(labelCuartel)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerHoraSalida)
        Me.tabpageGeneral.Controls.Add(labelHoraSalida)
        Me.tabpageGeneral.Controls.Add(Me.labelSiniestroRubro)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFecha)
        Me.tabpageGeneral.Controls.Add(Me.integertextboxNumero)
        Me.tabpageGeneral.Controls.Add(Me.comboboxSiniestroRubro)
        Me.tabpageGeneral.Controls.Add(Me.labelNumero)
        Me.tabpageGeneral.Controls.Add(Me.labelFecha)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(656, 326)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'integertextboxNumeroPrefijo
        '
        Me.integertextboxNumeroPrefijo.BeforeTouchSize = New System.Drawing.Size(86, 20)
        Me.integertextboxNumeroPrefijo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.integertextboxNumeroPrefijo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.integertextboxNumeroPrefijo.IntegerValue = CType(0, Long)
        Me.integertextboxNumeroPrefijo.Location = New System.Drawing.Point(96, 42)
        Me.integertextboxNumeroPrefijo.MaxValue = CType(9999, Long)
        Me.integertextboxNumeroPrefijo.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.integertextboxNumeroPrefijo.MinMaxValidation = Syncfusion.Windows.Forms.Tools.MinMaxValidation.OnLostFocus
        Me.integertextboxNumeroPrefijo.MinValue = CType(1, Long)
        Me.integertextboxNumeroPrefijo.Name = "integertextboxNumeroPrefijo"
        Me.integertextboxNumeroPrefijo.NullString = ""
        Me.integertextboxNumeroPrefijo.Size = New System.Drawing.Size(49, 20)
        Me.integertextboxNumeroPrefijo.TabIndex = 3
        Me.integertextboxNumeroPrefijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'datetimepickerHoraFin
        '
        Me.datetimepickerHoraFin.CustomFormat = "hh:MM"
        Me.datetimepickerHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickerHoraFin.Location = New System.Drawing.Point(96, 227)
        Me.datetimepickerHoraFin.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerHoraFin.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerHoraFin.Name = "datetimepickerHoraFin"
        Me.datetimepickerHoraFin.ShowCheckBox = True
        Me.datetimepickerHoraFin.Size = New System.Drawing.Size(86, 20)
        Me.datetimepickerHoraFin.TabIndex = 19
        '
        'labelClave
        '
        Me.labelClave.AutoSize = True
        Me.labelClave.Location = New System.Drawing.Point(6, 177)
        Me.labelClave.Name = "labelClave"
        Me.labelClave.Size = New System.Drawing.Size(37, 13)
        Me.labelClave.TabIndex = 14
        Me.labelClave.Text = "Clave:"
        '
        'comboboxClave
        '
        Me.comboboxClave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboboxClave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxClave.FormattingEnabled = True
        Me.comboboxClave.Location = New System.Drawing.Point(96, 174)
        Me.comboboxClave.Name = "comboboxClave"
        Me.comboboxClave.Size = New System.Drawing.Size(86, 21)
        Me.comboboxClave.TabIndex = 15
        '
        'labelSiniestroTipoOtro
        '
        Me.labelSiniestroTipoOtro.AutoSize = True
        Me.labelSiniestroTipoOtro.Location = New System.Drawing.Point(6, 151)
        Me.labelSiniestroTipoOtro.Name = "labelSiniestroTipoOtro"
        Me.labelSiniestroTipoOtro.Size = New System.Drawing.Size(30, 13)
        Me.labelSiniestroTipoOtro.TabIndex = 12
        Me.labelSiniestroTipoOtro.Text = "Otro:"
        '
        'textboxSiniestroTipoOtro
        '
        Me.textboxSiniestroTipoOtro.Location = New System.Drawing.Point(96, 148)
        Me.textboxSiniestroTipoOtro.MaxLength = 50
        Me.textboxSiniestroTipoOtro.Name = "textboxSiniestroTipoOtro"
        Me.textboxSiniestroTipoOtro.Size = New System.Drawing.Size(267, 20)
        Me.textboxSiniestroTipoOtro.TabIndex = 13
        '
        'labelSiniestroTipo
        '
        Me.labelSiniestroTipo.AutoSize = True
        Me.labelSiniestroTipo.Location = New System.Drawing.Point(6, 124)
        Me.labelSiniestroTipo.Name = "labelSiniestroTipo"
        Me.labelSiniestroTipo.Size = New System.Drawing.Size(31, 13)
        Me.labelSiniestroTipo.TabIndex = 10
        Me.labelSiniestroTipo.Text = "Tipo:"
        '
        'comboboxSiniestroTipo
        '
        Me.comboboxSiniestroTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboboxSiniestroTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxSiniestroTipo.FormattingEnabled = True
        Me.comboboxSiniestroTipo.Location = New System.Drawing.Point(96, 121)
        Me.comboboxSiniestroTipo.Name = "comboboxSiniestroTipo"
        Me.comboboxSiniestroTipo.Size = New System.Drawing.Size(267, 21)
        Me.comboboxSiniestroTipo.TabIndex = 11
        '
        'buttonCodigoSiguiente
        '
        Me.buttonCodigoSiguiente.Location = New System.Drawing.Point(243, 42)
        Me.buttonCodigoSiguiente.Name = "buttonCodigoSiguiente"
        Me.buttonCodigoSiguiente.Size = New System.Drawing.Size(103, 22)
        Me.buttonCodigoSiguiente.TabIndex = 5
        Me.buttonCodigoSiguiente.Text = "Obtener siguiente"
        Me.buttonCodigoSiguiente.UseVisualStyleBackColor = True
        '
        'comboboxCuartel
        '
        Me.comboboxCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCuartel.FormattingEnabled = True
        Me.comboboxCuartel.Location = New System.Drawing.Point(96, 15)
        Me.comboboxCuartel.Name = "comboboxCuartel"
        Me.comboboxCuartel.Size = New System.Drawing.Size(267, 21)
        Me.comboboxCuartel.TabIndex = 1
        '
        'datetimepickerHoraSalida
        '
        Me.datetimepickerHoraSalida.CustomFormat = "hh:MM"
        Me.datetimepickerHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickerHoraSalida.Location = New System.Drawing.Point(96, 201)
        Me.datetimepickerHoraSalida.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerHoraSalida.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerHoraSalida.Name = "datetimepickerHoraSalida"
        Me.datetimepickerHoraSalida.ShowCheckBox = True
        Me.datetimepickerHoraSalida.Size = New System.Drawing.Size(86, 20)
        Me.datetimepickerHoraSalida.TabIndex = 17
        '
        'labelSiniestroRubro
        '
        Me.labelSiniestroRubro.AutoSize = True
        Me.labelSiniestroRubro.Location = New System.Drawing.Point(6, 97)
        Me.labelSiniestroRubro.Name = "labelSiniestroRubro"
        Me.labelSiniestroRubro.Size = New System.Drawing.Size(39, 13)
        Me.labelSiniestroRubro.TabIndex = 8
        Me.labelSiniestroRubro.Text = "Rubro:"
        '
        'datetimepickerFecha
        '
        Me.datetimepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFecha.Location = New System.Drawing.Point(96, 68)
        Me.datetimepickerFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFecha.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFecha.Name = "datetimepickerFecha"
        Me.datetimepickerFecha.Size = New System.Drawing.Size(113, 20)
        Me.datetimepickerFecha.TabIndex = 7
        '
        'integertextboxNumero
        '
        Me.integertextboxNumero.BeforeTouchSize = New System.Drawing.Size(86, 20)
        Me.integertextboxNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.integertextboxNumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.integertextboxNumero.IntegerValue = CType(0, Long)
        Me.integertextboxNumero.Location = New System.Drawing.Point(151, 42)
        Me.integertextboxNumero.MaxValue = CType(99999999, Long)
        Me.integertextboxNumero.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.integertextboxNumero.MinMaxValidation = Syncfusion.Windows.Forms.Tools.MinMaxValidation.OnLostFocus
        Me.integertextboxNumero.MinValue = CType(1, Long)
        Me.integertextboxNumero.Name = "integertextboxNumero"
        Me.integertextboxNumero.NullString = ""
        Me.integertextboxNumero.Size = New System.Drawing.Size(86, 20)
        Me.integertextboxNumero.TabIndex = 4
        Me.integertextboxNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tabpageDetalles
        '
        Me.tabpageDetalles.Controls.Add(Me.datagridviewDetalles)
        Me.tabpageDetalles.Controls.Add(Me.toolstripDetalles)
        Me.tabpageDetalles.Location = New System.Drawing.Point(4, 25)
        Me.tabpageDetalles.Name = "tabpageDetalles"
        Me.tabpageDetalles.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageDetalles.Size = New System.Drawing.Size(656, 326)
        Me.tabpageDetalles.TabIndex = 2
        Me.tabpageDetalles.Text = "Detalles"
        Me.tabpageDetalles.UseVisualStyleBackColor = True
        '
        'datagridviewDetalles
        '
        Me.datagridviewDetalles.AllowUserToAddRows = False
        Me.datagridviewDetalles.AllowUserToDeleteRows = False
        Me.datagridviewDetalles.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewDetalles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnPersona, Me.columnSiniestroAsistenciaTipo})
        Me.datagridviewDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewDetalles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewDetalles.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewDetalles.MultiSelect = False
        Me.datagridviewDetalles.Name = "datagridviewDetalles"
        Me.datagridviewDetalles.ReadOnly = True
        Me.datagridviewDetalles.RowHeadersVisible = False
        Me.datagridviewDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewDetalles.Size = New System.Drawing.Size(563, 320)
        Me.datagridviewDetalles.TabIndex = 8
        '
        'columnPersona
        '
        Me.columnPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnPersona.DataPropertyName = "ApellidoNombre"
        Me.columnPersona.HeaderText = "Persona"
        Me.columnPersona.Name = "columnPersona"
        Me.columnPersona.ReadOnly = True
        Me.columnPersona.Width = 71
        '
        'columnSiniestroAsistenciaTipo
        '
        Me.columnSiniestroAsistenciaTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnSiniestroAsistenciaTipo.DataPropertyName = "SiniestroAsistenciaTipoNombre"
        Me.columnSiniestroAsistenciaTipo.HeaderText = "Asistencia"
        Me.columnSiniestroAsistenciaTipo.Name = "columnSiniestroAsistenciaTipo"
        Me.columnSiniestroAsistenciaTipo.ReadOnly = True
        Me.columnSiniestroAsistenciaTipo.Width = 80
        '
        'toolstripDetalles
        '
        Me.toolstripDetalles.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripDetalles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripDetalles.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripDetalles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonDetallesAgregar, Me.buttonDetallesEditar, Me.buttonDetallesEliminar})
        Me.toolstripDetalles.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripDetalles.Location = New System.Drawing.Point(3, 3)
        Me.toolstripDetalles.Name = "toolstripDetalles"
        Me.toolstripDetalles.Size = New System.Drawing.Size(87, 320)
        Me.toolstripDetalles.TabIndex = 9
        '
        'buttonDetallesAgregar
        '
        Me.buttonDetallesAgregar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonDetallesAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonDetallesAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonDetallesAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonDetallesAgregar.Name = "buttonDetallesAgregar"
        Me.buttonDetallesAgregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonDetallesAgregar.Text = "Agregar"
        '
        'buttonDetallesEditar
        '
        Me.buttonDetallesEditar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonDetallesEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonDetallesEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonDetallesEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonDetallesEditar.Name = "buttonDetallesEditar"
        Me.buttonDetallesEditar.Size = New System.Drawing.Size(84, 36)
        Me.buttonDetallesEditar.Text = "Editar"
        '
        'buttonDetallesEliminar
        '
        Me.buttonDetallesEliminar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonDetallesEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonDetallesEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonDetallesEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonDetallesEliminar.Name = "buttonDetallesEliminar"
        Me.buttonDetallesEliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonDetallesEliminar.Text = "Eliminar"
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.checkboxAnulado)
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelAnulado)
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelIDSiniestro)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxIDSiniestro)
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(656, 326)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'checkboxAnulado
        '
        Me.checkboxAnulado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.checkboxAnulado.AutoSize = True
        Me.checkboxAnulado.Location = New System.Drawing.Point(114, 231)
        Me.checkboxAnulado.Name = "checkboxAnulado"
        Me.checkboxAnulado.Size = New System.Drawing.Size(15, 14)
        Me.checkboxAnulado.TabIndex = 3
        Me.checkboxAnulado.UseVisualStyleBackColor = True
        '
        'labelAnulado
        '
        Me.labelAnulado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelAnulado.AutoSize = True
        Me.labelAnulado.Location = New System.Drawing.Point(6, 230)
        Me.labelAnulado.Name = "labelAnulado"
        Me.labelAnulado.Size = New System.Drawing.Size(49, 13)
        Me.labelAnulado.TabIndex = 2
        Me.labelAnulado.Text = "Anulado:"
        '
        'labelIDSiniestro
        '
        Me.labelIDSiniestro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelIDSiniestro.AutoSize = True
        Me.labelIDSiniestro.Location = New System.Drawing.Point(6, 254)
        Me.labelIDSiniestro.Name = "labelIDSiniestro"
        Me.labelIDSiniestro.Size = New System.Drawing.Size(21, 13)
        Me.labelIDSiniestro.TabIndex = 4
        Me.labelIDSiniestro.Text = "ID:"
        '
        'textboxIDSiniestro
        '
        Me.textboxIDSiniestro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxIDSiniestro.Location = New System.Drawing.Point(114, 251)
        Me.textboxIDSiniestro.MaxLength = 10
        Me.textboxIDSiniestro.Name = "textboxIDSiniestro"
        Me.textboxIDSiniestro.ReadOnly = True
        Me.textboxIDSiniestro.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDSiniestro.TabIndex = 5
        Me.textboxIDSiniestro.TabStop = False
        Me.textboxIDSiniestro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 303)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 11
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 277)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 8
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 303)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 10
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 277)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 7
        '
        'textboxNotas
        '
        Me.textboxNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxNotas.Location = New System.Drawing.Point(114, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(542, 219)
        Me.textboxNotas.TabIndex = 1
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(4, 9)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 0
        Me.labelNotas.Text = "Notas:"
        '
        'formSiniestro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 410)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formSiniestro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Siniestro"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        CType(Me.integertextboxNumeroPrefijo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.integertextboxNumero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpageDetalles.ResumeLayout(False)
        Me.tabpageDetalles.PerformLayout()
        CType(Me.datagridviewDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripDetalles.ResumeLayout(False)
        Me.toolstripDetalles.PerformLayout()
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
    Friend WithEvents comboboxSiniestroRubro As System.Windows.Forms.ComboBox
    Friend WithEvents tabcontrolMain As CS_Control_TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents labelNumero As Label
    Friend WithEvents labelFecha As Label
    Friend WithEvents labelSiniestroRubro As Label
    Friend WithEvents datetimepickerFecha As DateTimePicker
    Friend WithEvents integertextboxNumero As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents tabpageDetalles As TabPage
    Friend WithEvents datagridviewDetalles As DataGridView
    Friend WithEvents toolstripDetalles As ToolStrip
    Friend WithEvents buttonDetallesAgregar As ToolStripButton
    Friend WithEvents buttonDetallesEditar As ToolStripButton
    Friend WithEvents buttonDetallesEliminar As ToolStripButton
    Friend WithEvents datetimepickerHoraSalida As DateTimePicker
    Friend WithEvents buttonImprimir As ToolStripButton
    Friend WithEvents labelIDSiniestro As Label
    Friend WithEvents textboxIDSiniestro As TextBox
    Friend WithEvents comboboxCuartel As ComboBox
    Friend WithEvents buttonCodigoSiguiente As Button
    Friend WithEvents labelSiniestroTipo As Label
    Friend WithEvents comboboxSiniestroTipo As ComboBox
    Friend WithEvents labelClave As Label
    Friend WithEvents comboboxClave As ComboBox
    Friend WithEvents labelSiniestroTipoOtro As Label
    Friend WithEvents textboxSiniestroTipoOtro As TextBox
    Friend WithEvents checkboxAnulado As CheckBox
    Friend WithEvents labelAnulado As Label
    Friend WithEvents datetimepickerHoraFin As DateTimePicker
    Friend WithEvents integertextboxNumeroPrefijo As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents columnPersona As DataGridViewTextBoxColumn
    Friend WithEvents columnSiniestroAsistenciaTipo As DataGridViewTextBoxColumn
End Class
