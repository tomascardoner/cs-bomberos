<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCompra
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.labelCuartel = New System.Windows.Forms.Label()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.labelFacturaFecha = New System.Windows.Forms.Label()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.comboboxProveedor = New System.Windows.Forms.ComboBox()
        Me.tabcontrolMain = New CSBomberos.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.groupboxFactura = New System.Windows.Forms.GroupBox()
        Me.textboxFacturaNumero = New System.Windows.Forms.TextBox()
        Me.labelFacturaNumero = New System.Windows.Forms.Label()
        Me.datetimepickerFacturaFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelProveedor = New System.Windows.Forms.Label()
        Me.datetimepickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.integertextboxIDCompra = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.checkboxCerrada = New System.Windows.Forms.CheckBox()
        Me.labelEsActivo = New System.Windows.Forms.Label()
        Me.tabpageDetalles = New System.Windows.Forms.TabPage()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.datagridviewDetalles = New System.Windows.Forms.DataGridView()
        Me.columnArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripDetalles = New System.Windows.Forms.ToolStrip()
        Me.buttonDetallesAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonDetallesEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonDetallesEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.groupboxFactura.SuspendLayout()
        CType(Me.integertextboxIDCompra, System.ComponentModel.ISupportInitialize).BeginInit()
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
        labelModificacion.TabIndex = 11
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 211)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 8
        labelCreacion.Text = "Creación:"
        '
        'labelCuartel
        '
        Me.labelCuartel.AutoSize = True
        Me.labelCuartel.Location = New System.Drawing.Point(6, 9)
        Me.labelCuartel.Name = "labelCuartel"
        Me.labelCuartel.Size = New System.Drawing.Size(46, 13)
        Me.labelCuartel.TabIndex = 0
        Me.labelCuartel.Text = "Nº O.C.:"
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(6, 33)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelFecha.TabIndex = 2
        Me.labelFecha.Text = "Fecha:"
        '
        'labelFacturaFecha
        '
        Me.labelFacturaFecha.AutoSize = True
        Me.labelFacturaFecha.Location = New System.Drawing.Point(6, 23)
        Me.labelFacturaFecha.Name = "labelFacturaFecha"
        Me.labelFacturaFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelFacturaFecha.TabIndex = 13
        Me.labelFacturaFecha.Text = "Fecha:"
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
        Me.toolstripMain.Size = New System.Drawing.Size(684, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'comboboxProveedor
        '
        Me.comboboxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxProveedor.FormattingEnabled = True
        Me.comboboxProveedor.Location = New System.Drawing.Point(79, 56)
        Me.comboboxProveedor.Name = "comboboxProveedor"
        Me.comboboxProveedor.Size = New System.Drawing.Size(416, 21)
        Me.comboboxProveedor.TabIndex = 1
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
        Me.tabpageGeneral.Controls.Add(Me.groupboxFactura)
        Me.tabpageGeneral.Controls.Add(Me.labelProveedor)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFecha)
        Me.tabpageGeneral.Controls.Add(Me.integertextboxIDCompra)
        Me.tabpageGeneral.Controls.Add(Me.checkboxCerrada)
        Me.tabpageGeneral.Controls.Add(Me.labelEsActivo)
        Me.tabpageGeneral.Controls.Add(Me.comboboxProveedor)
        Me.tabpageGeneral.Controls.Add(Me.labelCuartel)
        Me.tabpageGeneral.Controls.Add(Me.labelFecha)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(656, 257)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'groupboxFactura
        '
        Me.groupboxFactura.Controls.Add(Me.textboxFacturaNumero)
        Me.groupboxFactura.Controls.Add(Me.labelFacturaNumero)
        Me.groupboxFactura.Controls.Add(Me.labelFacturaFecha)
        Me.groupboxFactura.Controls.Add(Me.datetimepickerFacturaFecha)
        Me.groupboxFactura.Location = New System.Drawing.Point(9, 83)
        Me.groupboxFactura.Name = "groupboxFactura"
        Me.groupboxFactura.Size = New System.Drawing.Size(273, 75)
        Me.groupboxFactura.TabIndex = 20
        Me.groupboxFactura.TabStop = False
        Me.groupboxFactura.Text = "Factura:"
        '
        'textboxFacturaNumero
        '
        Me.textboxFacturaNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textboxFacturaNumero.Location = New System.Drawing.Point(70, 46)
        Me.textboxFacturaNumero.MaxLength = 16
        Me.textboxFacturaNumero.Name = "textboxFacturaNumero"
        Me.textboxFacturaNumero.Size = New System.Drawing.Size(138, 20)
        Me.textboxFacturaNumero.TabIndex = 16
        '
        'labelFacturaNumero
        '
        Me.labelFacturaNumero.AutoSize = True
        Me.labelFacturaNumero.Location = New System.Drawing.Point(6, 49)
        Me.labelFacturaNumero.Name = "labelFacturaNumero"
        Me.labelFacturaNumero.Size = New System.Drawing.Size(47, 13)
        Me.labelFacturaNumero.TabIndex = 15
        Me.labelFacturaNumero.Text = "Número:"
        '
        'datetimepickerFacturaFecha
        '
        Me.datetimepickerFacturaFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFacturaFecha.Location = New System.Drawing.Point(70, 20)
        Me.datetimepickerFacturaFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFacturaFecha.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFacturaFecha.Name = "datetimepickerFacturaFecha"
        Me.datetimepickerFacturaFecha.ShowCheckBox = True
        Me.datetimepickerFacturaFecha.Size = New System.Drawing.Size(138, 20)
        Me.datetimepickerFacturaFecha.TabIndex = 14
        '
        'labelProveedor
        '
        Me.labelProveedor.AutoSize = True
        Me.labelProveedor.Location = New System.Drawing.Point(6, 59)
        Me.labelProveedor.Name = "labelProveedor"
        Me.labelProveedor.Size = New System.Drawing.Size(59, 13)
        Me.labelProveedor.TabIndex = 19
        Me.labelProveedor.Text = "Proveedor:"
        '
        'datetimepickerFecha
        '
        Me.datetimepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFecha.Location = New System.Drawing.Point(79, 30)
        Me.datetimepickerFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFecha.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFecha.Name = "datetimepickerFecha"
        Me.datetimepickerFecha.Size = New System.Drawing.Size(113, 20)
        Me.datetimepickerFecha.TabIndex = 18
        '
        'integertextboxIDCompra
        '
        Me.integertextboxIDCompra.BeforeTouchSize = New System.Drawing.Size(86, 20)
        Me.integertextboxIDCompra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.integertextboxIDCompra.ForeColor = System.Drawing.SystemColors.WindowText
        Me.integertextboxIDCompra.IntegerValue = CType(0, Long)
        Me.integertextboxIDCompra.Location = New System.Drawing.Point(79, 4)
        Me.integertextboxIDCompra.MaxValue = CType(99999999, Long)
        Me.integertextboxIDCompra.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.integertextboxIDCompra.MinMaxValidation = Syncfusion.Windows.Forms.Tools.MinMaxValidation.OnLostFocus
        Me.integertextboxIDCompra.MinValue = CType(1, Long)
        Me.integertextboxIDCompra.Name = "integertextboxIDCompra"
        Me.integertextboxIDCompra.NullString = ""
        Me.integertextboxIDCompra.Size = New System.Drawing.Size(86, 20)
        Me.integertextboxIDCompra.TabIndex = 17
        Me.integertextboxIDCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'checkboxCerrada
        '
        Me.checkboxCerrada.AutoSize = True
        Me.checkboxCerrada.Location = New System.Drawing.Point(79, 167)
        Me.checkboxCerrada.Name = "checkboxCerrada"
        Me.checkboxCerrada.Size = New System.Drawing.Size(15, 14)
        Me.checkboxCerrada.TabIndex = 16
        Me.checkboxCerrada.UseVisualStyleBackColor = True
        '
        'labelEsActivo
        '
        Me.labelEsActivo.AutoSize = True
        Me.labelEsActivo.Location = New System.Drawing.Point(6, 167)
        Me.labelEsActivo.Name = "labelEsActivo"
        Me.labelEsActivo.Size = New System.Drawing.Size(47, 13)
        Me.labelEsActivo.TabIndex = 15
        Me.labelEsActivo.Text = "Cerrada:"
        '
        'tabpageDetalles
        '
        Me.tabpageDetalles.Controls.Add(Me.statusstripMain)
        Me.tabpageDetalles.Controls.Add(Me.datagridviewDetalles)
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
        Me.datagridviewDetalles.Size = New System.Drawing.Size(563, 251)
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
        Me.toolstripDetalles.Size = New System.Drawing.Size(87, 251)
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
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 234)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 13
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 208)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 10
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 234)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 12
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 208)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 9
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(114, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(386, 196)
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
        'formCompra
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
        Me.Name = "formCompra"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Compra"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        Me.groupboxFactura.ResumeLayout(False)
        Me.groupboxFactura.PerformLayout()
        CType(Me.integertextboxIDCompra, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents datetimepickerFacturaFecha As DateTimePicker
    Friend WithEvents checkboxCerrada As CheckBox
    Friend WithEvents labelCuartel As Label
    Friend WithEvents labelFecha As Label
    Friend WithEvents labelFacturaFecha As Label
    Friend WithEvents groupboxFactura As GroupBox
    Friend WithEvents labelFacturaNumero As Label
    Friend WithEvents labelProveedor As Label
    Friend WithEvents datetimepickerFecha As DateTimePicker
    Friend WithEvents integertextboxIDCompra As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents labelEsActivo As Label
    Friend WithEvents textboxFacturaNumero As TextBox
    Friend WithEvents tabpageDetalles As TabPage
    Friend WithEvents datagridviewDetalles As DataGridView
    Friend WithEvents columnArea As DataGridViewTextBoxColumn
    Friend WithEvents columnDetalle As DataGridViewTextBoxColumn
    Friend WithEvents columnImporte As DataGridViewTextBoxColumn
    Friend WithEvents toolstripDetalles As ToolStrip
    Friend WithEvents buttonDetallesAgregar As ToolStripButton
    Friend WithEvents buttonDetallesEditar As ToolStripButton
    Friend WithEvents buttonDetallesEliminar As ToolStripButton
    Friend WithEvents statusstripMain As StatusStrip
    Friend WithEvents statuslabelMain As ToolStripStatusLabel
End Class
