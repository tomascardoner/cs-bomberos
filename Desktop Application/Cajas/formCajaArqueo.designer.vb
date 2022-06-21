<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCajaArqueo
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
        Dim labelCaja As System.Windows.Forms.Label
        Dim labelCierreFecha As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.labelSaldoInicial = New System.Windows.Forms.Label()
        Me.labelImporteAsignado = New System.Windows.Forms.Label()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tabcontrolMain = New CSBomberos.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.currencytextboxImporteAsignado = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.currencytextboxSaldoInicial = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.buttonSaldoInicial = New System.Windows.Forms.Button()
        Me.comboboxCaja = New System.Windows.Forms.ComboBox()
        Me.datetimepickerCierreFecha = New System.Windows.Forms.DateTimePicker()
        Me.tabpageDetalles = New System.Windows.Forms.TabPage()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.datagridviewDetalles = New System.Windows.Forms.DataGridView()
        Me.columnNumeroComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        labelCaja = New System.Windows.Forms.Label()
        labelCierreFecha = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        CType(Me.currencytextboxImporteAsignado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currencytextboxSaldoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpageDetalles.SuspendLayout()
        Me.statusstripMain.SuspendLayout()
        CType(Me.datagridviewDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripDetalles.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 237)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 7
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 211)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 4
        labelCreacion.Text = "Creación:"
        '
        'labelCaja
        '
        labelCaja.AutoSize = True
        labelCaja.Location = New System.Drawing.Point(6, 18)
        labelCaja.Name = "labelCaja"
        labelCaja.Size = New System.Drawing.Size(31, 13)
        labelCaja.TabIndex = 0
        labelCaja.Text = "Caja:"
        '
        'labelCierreFecha
        '
        labelCierreFecha.AutoSize = True
        labelCierreFecha.Location = New System.Drawing.Point(6, 97)
        labelCierreFecha.Name = "labelCierreFecha"
        labelCierreFecha.Size = New System.Drawing.Size(84, 13)
        labelCierreFecha.TabIndex = 12
        labelCierreFecha.Text = "Fecha de cierre:"
        '
        'labelSaldoInicial
        '
        Me.labelSaldoInicial.AutoSize = True
        Me.labelSaldoInicial.Location = New System.Drawing.Point(6, 47)
        Me.labelSaldoInicial.Name = "labelSaldoInicial"
        Me.labelSaldoInicial.Size = New System.Drawing.Size(66, 13)
        Me.labelSaldoInicial.TabIndex = 2
        Me.labelSaldoInicial.Text = "Saldo inicial:"
        '
        'labelImporteAsignado
        '
        Me.labelImporteAsignado.AutoSize = True
        Me.labelImporteAsignado.Location = New System.Drawing.Point(6, 71)
        Me.labelImporteAsignado.Name = "labelImporteAsignado"
        Me.labelImporteAsignado.Size = New System.Drawing.Size(91, 13)
        Me.labelImporteAsignado.TabIndex = 5
        Me.labelImporteAsignado.Text = "Importe asignado:"
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
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar, Me.buttonImprimir})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(684, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'buttonImprimir
        '
        Me.buttonImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonImprimir.Image = Global.CSBomberos.My.Resources.Resources.ImageImprimir32
        Me.buttonImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonImprimir.Name = "buttonImprimir"
        Me.buttonImprimir.Size = New System.Drawing.Size(89, 36)
        Me.buttonImprimir.Text = "Imprimir"
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
        Me.tabcontrolMain.Size = New System.Drawing.Size(664, 286)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.currencytextboxImporteAsignado)
        Me.tabpageGeneral.Controls.Add(Me.currencytextboxSaldoInicial)
        Me.tabpageGeneral.Controls.Add(Me.buttonSaldoInicial)
        Me.tabpageGeneral.Controls.Add(Me.comboboxCaja)
        Me.tabpageGeneral.Controls.Add(labelCaja)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerCierreFecha)
        Me.tabpageGeneral.Controls.Add(labelCierreFecha)
        Me.tabpageGeneral.Controls.Add(Me.labelSaldoInicial)
        Me.tabpageGeneral.Controls.Add(Me.labelImporteAsignado)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(656, 257)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'currencytextboxImporteAsignado
        '
        Me.currencytextboxImporteAsignado.AllowNull = True
        Me.currencytextboxImporteAsignado.BeforeTouchSize = New System.Drawing.Size(119, 20)
        Me.currencytextboxImporteAsignado.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxImporteAsignado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.currencytextboxImporteAsignado.Location = New System.Drawing.Point(103, 68)
        Me.currencytextboxImporteAsignado.MaxValue = New Decimal(New Integer() {1410065407, 2, 0, 131072})
        Me.currencytextboxImporteAsignado.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.currencytextboxImporteAsignado.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxImporteAsignado.Name = "currencytextboxImporteAsignado"
        Me.currencytextboxImporteAsignado.NullString = ""
        Me.currencytextboxImporteAsignado.Size = New System.Drawing.Size(119, 20)
        Me.currencytextboxImporteAsignado.TabIndex = 15
        Me.currencytextboxImporteAsignado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'currencytextboxSaldoInicial
        '
        Me.currencytextboxSaldoInicial.AllowNull = True
        Me.currencytextboxSaldoInicial.BeforeTouchSize = New System.Drawing.Size(119, 20)
        Me.currencytextboxSaldoInicial.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxSaldoInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.currencytextboxSaldoInicial.Location = New System.Drawing.Point(103, 42)
        Me.currencytextboxSaldoInicial.MaxValue = New Decimal(New Integer() {1410065407, 2, 0, 131072})
        Me.currencytextboxSaldoInicial.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.currencytextboxSaldoInicial.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxSaldoInicial.Name = "currencytextboxSaldoInicial"
        Me.currencytextboxSaldoInicial.NullString = ""
        Me.currencytextboxSaldoInicial.Size = New System.Drawing.Size(119, 20)
        Me.currencytextboxSaldoInicial.TabIndex = 14
        Me.currencytextboxSaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'buttonSaldoInicial
        '
        Me.buttonSaldoInicial.Location = New System.Drawing.Point(228, 42)
        Me.buttonSaldoInicial.Name = "buttonSaldoInicial"
        Me.buttonSaldoInicial.Size = New System.Drawing.Size(66, 22)
        Me.buttonSaldoInicial.TabIndex = 4
        Me.buttonSaldoInicial.Text = "Obtener"
        Me.buttonSaldoInicial.UseVisualStyleBackColor = True
        '
        'comboboxCaja
        '
        Me.comboboxCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCaja.FormattingEnabled = True
        Me.comboboxCaja.Location = New System.Drawing.Point(103, 15)
        Me.comboboxCaja.Name = "comboboxCaja"
        Me.comboboxCaja.Size = New System.Drawing.Size(267, 21)
        Me.comboboxCaja.TabIndex = 1
        '
        'datetimepickerCierreFecha
        '
        Me.datetimepickerCierreFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerCierreFecha.Location = New System.Drawing.Point(103, 94)
        Me.datetimepickerCierreFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerCierreFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerCierreFecha.Name = "datetimepickerCierreFecha"
        Me.datetimepickerCierreFecha.ShowCheckBox = True
        Me.datetimepickerCierreFecha.Size = New System.Drawing.Size(148, 20)
        Me.datetimepickerCierreFecha.TabIndex = 13
        '
        'tabpageDetalles
        '
        Me.tabpageDetalles.Controls.Add(Me.datagridviewDetalles)
        Me.tabpageDetalles.Controls.Add(Me.statusstripMain)
        Me.tabpageDetalles.Controls.Add(Me.toolstripDetalles)
        Me.tabpageDetalles.Location = New System.Drawing.Point(4, 25)
        Me.tabpageDetalles.Name = "tabpageDetalles"
        Me.tabpageDetalles.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageDetalles.Size = New System.Drawing.Size(656, 257)
        Me.tabpageDetalles.TabIndex = 2
        Me.tabpageDetalles.Text = "Detalles"
        Me.tabpageDetalles.UseVisualStyleBackColor = True
        '
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabelMain})
        Me.statusstripMain.Location = New System.Drawing.Point(90, 232)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(563, 22)
        Me.statusstripMain.SizingGrip = False
        Me.statusstripMain.TabIndex = 10
        '
        'statuslabelMain
        '
        Me.statuslabelMain.Name = "statuslabelMain"
        Me.statuslabelMain.Size = New System.Drawing.Size(548, 17)
        Me.statuslabelMain.Spring = True
        Me.statuslabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.datagridviewDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnNumeroComprobante, Me.columnFecha, Me.columnProveedor, Me.columnDetalle, Me.columnImporte})
        Me.datagridviewDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewDetalles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewDetalles.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewDetalles.MultiSelect = False
        Me.datagridviewDetalles.Name = "datagridviewDetalles"
        Me.datagridviewDetalles.ReadOnly = True
        Me.datagridviewDetalles.RowHeadersVisible = False
        Me.datagridviewDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewDetalles.Size = New System.Drawing.Size(563, 229)
        Me.datagridviewDetalles.TabIndex = 8
        '
        'columnNumeroComprobante
        '
        Me.columnNumeroComprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnNumeroComprobante.DataPropertyName = "NumeroComprobante"
        Me.columnNumeroComprobante.HeaderText = "Nº comprobante"
        Me.columnNumeroComprobante.Name = "columnNumeroComprobante"
        Me.columnNumeroComprobante.ReadOnly = True
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
        'columnProveedor
        '
        Me.columnProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnProveedor.DataPropertyName = "Proveedor"
        Me.columnProveedor.HeaderText = "Proveedor"
        Me.columnProveedor.Name = "columnProveedor"
        Me.columnProveedor.ReadOnly = True
        Me.columnProveedor.Width = 81
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
        Me.toolstripDetalles.Size = New System.Drawing.Size(87, 251)
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(656, 257)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelID
        '
        Me.labelID.AutoSize = True
        Me.labelID.Location = New System.Drawing.Point(6, 185)
        Me.labelID.Name = "labelID"
        Me.labelID.Size = New System.Drawing.Size(21, 13)
        Me.labelID.TabIndex = 2
        Me.labelID.Text = "ID:"
        '
        'textboxID
        '
        Me.textboxID.Location = New System.Drawing.Point(114, 182)
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
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 234)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 9
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 208)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 6
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 234)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 8
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 208)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 5
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(114, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(386, 170)
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
        'formCajaArqueo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 341)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formCajaArqueo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Arqueo de caja"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        CType(Me.currencytextboxImporteAsignado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currencytextboxSaldoInicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpageDetalles.ResumeLayout(False)
        Me.tabpageDetalles.PerformLayout()
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
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
    Friend WithEvents tabcontrolMain As CS_Control_TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents labelSaldoInicial As Label
    Friend WithEvents labelImporteAsignado As Label
    Friend WithEvents tabpageDetalles As TabPage
    Friend WithEvents datagridviewDetalles As DataGridView
    Friend WithEvents toolstripDetalles As ToolStrip
    Friend WithEvents buttonDetallesAgregar As ToolStripButton
    Friend WithEvents buttonDetallesEditar As ToolStripButton
    Friend WithEvents buttonDetallesEliminar As ToolStripButton
    Friend WithEvents statusstripMain As StatusStrip
    Friend WithEvents statuslabelMain As ToolStripStatusLabel
    Friend WithEvents buttonImprimir As ToolStripButton
    Friend WithEvents labelID As Label
    Friend WithEvents textboxID As TextBox
    Friend WithEvents comboboxCaja As ComboBox
    Friend WithEvents buttonSaldoInicial As Button
    Friend WithEvents currencytextboxSaldoInicial As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents currencytextboxImporteAsignado As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents datetimepickerCierreFecha As DateTimePicker
    Friend WithEvents columnNumeroComprobante As DataGridViewTextBoxColumn
    Friend WithEvents columnFecha As DataGridViewTextBoxColumn
    Friend WithEvents columnProveedor As DataGridViewTextBoxColumn
    Friend WithEvents columnDetalle As DataGridViewTextBoxColumn
    Friend WithEvents columnImporte As DataGridViewTextBoxColumn
End Class
