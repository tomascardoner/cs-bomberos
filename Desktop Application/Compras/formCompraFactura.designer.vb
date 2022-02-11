<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCompraFactura
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
        Dim labelFechaVencimiento As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.comboboxProveedor = New System.Windows.Forms.ComboBox()
        Me.tabcontrolMain = New CSBomberos.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.currencytextboxImporte = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.labelImporte = New System.Windows.Forms.Label()
        Me.textBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.labelDescripcion = New System.Windows.Forms.Label()
        Me.maskedTextBoxTipo = New System.Windows.Forms.MaskedTextBox()
        Me.maskedTextBoxNumero = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelSeparadorTipoPuntoVenta = New System.Windows.Forms.Label()
        Me.maskedTextBoxPuntoVenta = New System.Windows.Forms.MaskedTextBox()
        Me.dateTimePickerFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.labelProveedor = New System.Windows.Forms.Label()
        Me.datetimepickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelNumeroCompleto = New System.Windows.Forms.Label()
        Me.tabpageDetalles = New System.Windows.Forms.TabPage()
        Me.datagridviewDetalles = New System.Windows.Forms.DataGridView()
        Me.columnArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripDetalles = New System.Windows.Forms.ToolStrip()
        Me.buttonDetallesAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonDetallesEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonDetallesEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.labelID = New System.Windows.Forms.Label()
        Me.textboxID = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelFechaVencimiento = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        CType(Me.currencytextboxImporte, System.ComponentModel.ISupportInitialize).BeginInit()
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
        labelModificacion.Location = New System.Drawing.Point(6, 230)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 7
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 204)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 4
        labelCreacion.Text = "Creación:"
        '
        'labelFechaVencimiento
        '
        labelFechaVencimiento.AutoSize = True
        labelFechaVencimiento.Location = New System.Drawing.Point(6, 43)
        labelFechaVencimiento.Name = "labelFechaVencimiento"
        labelFechaVencimiento.Size = New System.Drawing.Size(115, 13)
        labelFechaVencimiento.TabIndex = 2
        labelFechaVencimiento.Text = "Fecha de vencimiento:"
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(6, 17)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelFecha.TabIndex = 0
        Me.labelFecha.Text = "Fecha:"
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
        Me.toolstripMain.Size = New System.Drawing.Size(627, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'comboboxProveedor
        '
        Me.comboboxProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboboxProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboboxProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxProveedor.FormattingEnabled = True
        Me.comboboxProveedor.Location = New System.Drawing.Point(127, 92)
        Me.comboboxProveedor.Name = "comboboxProveedor"
        Me.comboboxProveedor.Size = New System.Drawing.Size(466, 21)
        Me.comboboxProveedor.TabIndex = 11
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
        Me.tabcontrolMain.Size = New System.Drawing.Size(607, 282)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.currencytextboxImporte)
        Me.tabpageGeneral.Controls.Add(Me.labelImporte)
        Me.tabpageGeneral.Controls.Add(Me.textBoxDescripcion)
        Me.tabpageGeneral.Controls.Add(Me.labelDescripcion)
        Me.tabpageGeneral.Controls.Add(Me.maskedTextBoxTipo)
        Me.tabpageGeneral.Controls.Add(Me.maskedTextBoxNumero)
        Me.tabpageGeneral.Controls.Add(Me.Label1)
        Me.tabpageGeneral.Controls.Add(Me.labelSeparadorTipoPuntoVenta)
        Me.tabpageGeneral.Controls.Add(Me.maskedTextBoxPuntoVenta)
        Me.tabpageGeneral.Controls.Add(Me.dateTimePickerFechaVencimiento)
        Me.tabpageGeneral.Controls.Add(labelFechaVencimiento)
        Me.tabpageGeneral.Controls.Add(Me.labelProveedor)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFecha)
        Me.tabpageGeneral.Controls.Add(Me.comboboxProveedor)
        Me.tabpageGeneral.Controls.Add(Me.labelNumeroCompleto)
        Me.tabpageGeneral.Controls.Add(Me.labelFecha)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(599, 253)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'currencytextboxImporte
        '
        Me.currencytextboxImporte.AllowNull = True
        Me.currencytextboxImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.currencytextboxImporte.BeforeTouchSize = New System.Drawing.Size(119, 20)
        Me.currencytextboxImporte.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxImporte.ForeColor = System.Drawing.SystemColors.WindowText
        Me.currencytextboxImporte.Location = New System.Drawing.Point(127, 229)
        Me.currencytextboxImporte.MaxValue = New Decimal(New Integer() {1410065407, 2, 0, 131072})
        Me.currencytextboxImporte.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.currencytextboxImporte.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxImporte.Name = "currencytextboxImporte"
        Me.currencytextboxImporte.NullString = ""
        Me.currencytextboxImporte.Size = New System.Drawing.Size(119, 20)
        Me.currencytextboxImporte.TabIndex = 15
        Me.currencytextboxImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labelImporte
        '
        Me.labelImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelImporte.AutoSize = True
        Me.labelImporte.Location = New System.Drawing.Point(6, 233)
        Me.labelImporte.Name = "labelImporte"
        Me.labelImporte.Size = New System.Drawing.Size(45, 13)
        Me.labelImporte.TabIndex = 14
        Me.labelImporte.Text = "Importe:"
        '
        'textBoxDescripcion
        '
        Me.textBoxDescripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxDescripcion.Location = New System.Drawing.Point(127, 119)
        Me.textBoxDescripcion.MaxLength = 0
        Me.textBoxDescripcion.Multiline = True
        Me.textBoxDescripcion.Name = "textBoxDescripcion"
        Me.textBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBoxDescripcion.Size = New System.Drawing.Size(466, 104)
        Me.textBoxDescripcion.TabIndex = 13
        '
        'labelDescripcion
        '
        Me.labelDescripcion.AutoSize = True
        Me.labelDescripcion.Location = New System.Drawing.Point(6, 122)
        Me.labelDescripcion.Name = "labelDescripcion"
        Me.labelDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.labelDescripcion.TabIndex = 12
        Me.labelDescripcion.Text = "Descripción:"
        '
        'maskedTextBoxTipo
        '
        Me.maskedTextBoxTipo.AsciiOnly = True
        Me.maskedTextBoxTipo.Location = New System.Drawing.Point(127, 66)
        Me.maskedTextBoxTipo.Mask = "L"
        Me.maskedTextBoxTipo.Name = "maskedTextBoxTipo"
        Me.maskedTextBoxTipo.Size = New System.Drawing.Size(22, 20)
        Me.maskedTextBoxTipo.TabIndex = 5
        Me.maskedTextBoxTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.maskedTextBoxTipo.ValidatingType = GetType(Integer)
        '
        'maskedTextBoxNumero
        '
        Me.maskedTextBoxNumero.Location = New System.Drawing.Point(235, 66)
        Me.maskedTextBoxNumero.Mask = "00000000"
        Me.maskedTextBoxNumero.Name = "maskedTextBoxNumero"
        Me.maskedTextBoxNumero.Size = New System.Drawing.Size(63, 20)
        Me.maskedTextBoxNumero.TabIndex = 9
        Me.maskedTextBoxNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.maskedTextBoxNumero.ValidatingType = GetType(Integer)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "-"
        '
        'labelSeparadorTipoPuntoVenta
        '
        Me.labelSeparadorTipoPuntoVenta.AutoSize = True
        Me.labelSeparadorTipoPuntoVenta.Location = New System.Drawing.Point(155, 69)
        Me.labelSeparadorTipoPuntoVenta.Name = "labelSeparadorTipoPuntoVenta"
        Me.labelSeparadorTipoPuntoVenta.Size = New System.Drawing.Size(10, 13)
        Me.labelSeparadorTipoPuntoVenta.TabIndex = 6
        Me.labelSeparadorTipoPuntoVenta.Text = "-"
        '
        'maskedTextBoxPuntoVenta
        '
        Me.maskedTextBoxPuntoVenta.Location = New System.Drawing.Point(171, 66)
        Me.maskedTextBoxPuntoVenta.Mask = "00000"
        Me.maskedTextBoxPuntoVenta.Name = "maskedTextBoxPuntoVenta"
        Me.maskedTextBoxPuntoVenta.Size = New System.Drawing.Size(42, 20)
        Me.maskedTextBoxPuntoVenta.TabIndex = 7
        Me.maskedTextBoxPuntoVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.maskedTextBoxPuntoVenta.ValidatingType = GetType(Integer)
        '
        'dateTimePickerFechaVencimiento
        '
        Me.dateTimePickerFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTimePickerFechaVencimiento.Location = New System.Drawing.Point(127, 40)
        Me.dateTimePickerFechaVencimiento.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dateTimePickerFechaVencimiento.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.dateTimePickerFechaVencimiento.Name = "dateTimePickerFechaVencimiento"
        Me.dateTimePickerFechaVencimiento.ShowCheckBox = True
        Me.dateTimePickerFechaVencimiento.Size = New System.Drawing.Size(139, 20)
        Me.dateTimePickerFechaVencimiento.TabIndex = 3
        '
        'labelProveedor
        '
        Me.labelProveedor.AutoSize = True
        Me.labelProveedor.Location = New System.Drawing.Point(6, 95)
        Me.labelProveedor.Name = "labelProveedor"
        Me.labelProveedor.Size = New System.Drawing.Size(59, 13)
        Me.labelProveedor.TabIndex = 10
        Me.labelProveedor.Text = "Proveedor:"
        '
        'datetimepickerFecha
        '
        Me.datetimepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFecha.Location = New System.Drawing.Point(127, 14)
        Me.datetimepickerFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFecha.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFecha.Name = "datetimepickerFecha"
        Me.datetimepickerFecha.Size = New System.Drawing.Size(113, 20)
        Me.datetimepickerFecha.TabIndex = 1
        '
        'labelNumeroCompleto
        '
        Me.labelNumeroCompleto.AutoSize = True
        Me.labelNumeroCompleto.Location = New System.Drawing.Point(6, 69)
        Me.labelNumeroCompleto.Name = "labelNumeroCompleto"
        Me.labelNumeroCompleto.Size = New System.Drawing.Size(77, 13)
        Me.labelNumeroCompleto.TabIndex = 4
        Me.labelNumeroCompleto.Text = "Tipo y número:"
        '
        'tabpageDetalles
        '
        Me.tabpageDetalles.Controls.Add(Me.datagridviewDetalles)
        Me.tabpageDetalles.Controls.Add(Me.toolstripDetalles)
        Me.tabpageDetalles.Location = New System.Drawing.Point(4, 25)
        Me.tabpageDetalles.Name = "tabpageDetalles"
        Me.tabpageDetalles.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageDetalles.Size = New System.Drawing.Size(599, 253)
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
        Me.datagridviewDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnArea, Me.columnDetalle, Me.columnImporte})
        Me.datagridviewDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewDetalles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewDetalles.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewDetalles.MultiSelect = False
        Me.datagridviewDetalles.Name = "datagridviewDetalles"
        Me.datagridviewDetalles.ReadOnly = True
        Me.datagridviewDetalles.RowHeadersVisible = False
        Me.datagridviewDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewDetalles.Size = New System.Drawing.Size(506, 247)
        Me.datagridviewDetalles.TabIndex = 8
        '
        'columnArea
        '
        Me.columnArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnArea.DataPropertyName = "AreaNombre"
        Me.columnArea.HeaderText = "Área"
        Me.columnArea.Name = "columnArea"
        Me.columnArea.ReadOnly = True
        Me.columnArea.Width = 54
        '
        'columnDetalle
        '
        Me.columnDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnDetalle.DataPropertyName = "Detalle"
        Me.columnDetalle.HeaderText = "Detalle"
        Me.columnDetalle.Name = "columnDetalle"
        Me.columnDetalle.ReadOnly = True
        Me.columnDetalle.Width = 65
        '
        'columnImporte
        '
        Me.columnImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.columnImporte.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnImporte.HeaderText = "Importe"
        Me.columnImporte.Name = "columnImporte"
        Me.columnImporte.ReadOnly = True
        Me.columnImporte.Width = 67
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
        Me.toolstripDetalles.Size = New System.Drawing.Size(87, 247)
        Me.toolstripDetalles.TabIndex = 9
        '
        'buttonDetallesAgregar
        '
        Me.buttonDetallesAgregar.Image = Global.CSBomberos.My.Resources.Resources.ImageAgregar32
        Me.buttonDetallesAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonDetallesAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonDetallesAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonDetallesAgregar.Name = "buttonDetallesAgregar"
        Me.buttonDetallesAgregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonDetallesAgregar.Text = "Agregar"
        '
        'buttonDetallesEditar
        '
        Me.buttonDetallesEditar.Image = Global.CSBomberos.My.Resources.Resources.ImageEditar32
        Me.buttonDetallesEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonDetallesEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonDetallesEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonDetallesEditar.Name = "buttonDetallesEditar"
        Me.buttonDetallesEditar.Size = New System.Drawing.Size(84, 36)
        Me.buttonDetallesEditar.Text = "Editar"
        '
        'buttonDetallesEliminar
        '
        Me.buttonDetallesEliminar.Image = Global.CSBomberos.My.Resources.Resources.ImageBorrar32
        Me.buttonDetallesEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonDetallesEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonDetallesEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonDetallesEliminar.Name = "buttonDetallesEliminar"
        Me.buttonDetallesEliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonDetallesEliminar.Text = "Eliminar"
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelID)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxID)
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(599, 253)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelID
        '
        Me.labelID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelID.AutoSize = True
        Me.labelID.Location = New System.Drawing.Point(6, 178)
        Me.labelID.Name = "labelID"
        Me.labelID.Size = New System.Drawing.Size(21, 13)
        Me.labelID.TabIndex = 2
        Me.labelID.Text = "ID:"
        '
        'textboxID
        '
        Me.textboxID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxID.Location = New System.Drawing.Point(114, 175)
        Me.textboxID.MaxLength = 10
        Me.textboxID.Name = "textboxID"
        Me.textboxID.ReadOnly = True
        Me.textboxID.Size = New System.Drawing.Size(72, 20)
        Me.textboxID.TabIndex = 3
        Me.textboxID.TabStop = False
        Me.textboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 227)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 9
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 201)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 6
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 227)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 8
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 201)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 5
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
        Me.textboxNotas.Size = New System.Drawing.Size(479, 163)
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
        'formCompraFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 337)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formCompraFactura"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Factura de compra"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        CType(Me.currencytextboxImporte, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents comboboxProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents tabcontrolMain As CS_Control_TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents labelFecha As Label
    Friend WithEvents labelProveedor As Label
    Friend WithEvents datetimepickerFecha As DateTimePicker
    Friend WithEvents tabpageDetalles As TabPage
    Friend WithEvents datagridviewDetalles As DataGridView
    Friend WithEvents columnArea As DataGridViewTextBoxColumn
    Friend WithEvents columnDetalle As DataGridViewTextBoxColumn
    Friend WithEvents columnImporte As DataGridViewTextBoxColumn
    Friend WithEvents toolstripDetalles As ToolStrip
    Friend WithEvents buttonDetallesAgregar As ToolStripButton
    Friend WithEvents buttonDetallesEditar As ToolStripButton
    Friend WithEvents buttonDetallesEliminar As ToolStripButton
    Friend WithEvents labelID As Label
    Friend WithEvents textboxID As TextBox
    Friend WithEvents maskedTextBoxTipo As MaskedTextBox
    Friend WithEvents maskedTextBoxNumero As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents labelSeparadorTipoPuntoVenta As Label
    Friend WithEvents maskedTextBoxPuntoVenta As MaskedTextBox
    Friend WithEvents dateTimePickerFechaVencimiento As DateTimePicker
    Friend WithEvents labelNumeroCompleto As Label
    Friend WithEvents textBoxDescripcion As TextBox
    Friend WithEvents labelDescripcion As Label
    Friend WithEvents currencytextboxImporte As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents labelImporte As Label
End Class
