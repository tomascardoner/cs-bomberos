<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCompraOrden
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
        Dim labelCierreFecha As System.Windows.Forms.Label
        Dim labelCuartel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.labelNumero = New System.Windows.Forms.Label()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonImprimir = New System.Windows.Forms.ToolStripButton()
        Me.comboboxEntidad = New System.Windows.Forms.ComboBox()
        Me.tabcontrolMain = New CSBomberos.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.buttonCodigoSiguiente = New System.Windows.Forms.Button()
        Me.comboboxCuartel = New System.Windows.Forms.ComboBox()
        Me.datetimepickerCierreFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelEntidad = New System.Windows.Forms.Label()
        Me.datetimepickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.integertextboxNumero = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.checkboxCerrada = New System.Windows.Forms.CheckBox()
        Me.labelEsActivo = New System.Windows.Forms.Label()
        Me.tabpageDetalles = New System.Windows.Forms.TabPage()
        Me.datagridviewDetalles = New System.Windows.Forms.DataGridView()
        Me.columnFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripDetalles = New System.Windows.Forms.ToolStrip()
        Me.buttonDetallesAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonDetallesEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonDetallesEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.labelIDCompraOrden = New System.Windows.Forms.Label()
        Me.textboxIDCompraOrden = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelCierreFecha = New System.Windows.Forms.Label()
        labelCuartel = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
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
        labelModificacion.Location = New System.Drawing.Point(6, 163)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 7
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 137)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 4
        labelCreacion.Text = "Creación:"
        '
        'labelCierreFecha
        '
        labelCierreFecha.AutoSize = True
        labelCierreFecha.Location = New System.Drawing.Point(6, 160)
        labelCierreFecha.Name = "labelCierreFecha"
        labelCierreFecha.Size = New System.Drawing.Size(84, 13)
        labelCierreFecha.TabIndex = 12
        labelCierreFecha.Text = "Fecha de cierre:"
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
        Me.labelFecha.TabIndex = 5
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
        'comboboxEntidad
        '
        Me.comboboxEntidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboboxEntidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxEntidad.FormattingEnabled = True
        Me.comboboxEntidad.Location = New System.Drawing.Point(96, 94)
        Me.comboboxEntidad.Name = "comboboxEntidad"
        Me.comboboxEntidad.Size = New System.Drawing.Size(416, 21)
        Me.comboboxEntidad.TabIndex = 8
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
        Me.tabcontrolMain.Size = New System.Drawing.Size(664, 212)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.buttonCodigoSiguiente)
        Me.tabpageGeneral.Controls.Add(Me.comboboxCuartel)
        Me.tabpageGeneral.Controls.Add(labelCuartel)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerCierreFecha)
        Me.tabpageGeneral.Controls.Add(labelCierreFecha)
        Me.tabpageGeneral.Controls.Add(Me.labelEntidad)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFecha)
        Me.tabpageGeneral.Controls.Add(Me.integertextboxNumero)
        Me.tabpageGeneral.Controls.Add(Me.checkboxCerrada)
        Me.tabpageGeneral.Controls.Add(Me.labelEsActivo)
        Me.tabpageGeneral.Controls.Add(Me.comboboxEntidad)
        Me.tabpageGeneral.Controls.Add(Me.labelNumero)
        Me.tabpageGeneral.Controls.Add(Me.labelFecha)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(656, 183)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'buttonCodigoSiguiente
        '
        Me.buttonCodigoSiguiente.Location = New System.Drawing.Point(188, 41)
        Me.buttonCodigoSiguiente.Name = "buttonCodigoSiguiente"
        Me.buttonCodigoSiguiente.Size = New System.Drawing.Size(103, 22)
        Me.buttonCodigoSiguiente.TabIndex = 4
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
        'datetimepickerCierreFecha
        '
        Me.datetimepickerCierreFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerCierreFecha.Location = New System.Drawing.Point(96, 157)
        Me.datetimepickerCierreFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerCierreFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerCierreFecha.Name = "datetimepickerCierreFecha"
        Me.datetimepickerCierreFecha.ShowCheckBox = True
        Me.datetimepickerCierreFecha.Size = New System.Drawing.Size(148, 20)
        Me.datetimepickerCierreFecha.TabIndex = 13
        '
        'labelEntidad
        '
        Me.labelEntidad.AutoSize = True
        Me.labelEntidad.Location = New System.Drawing.Point(6, 97)
        Me.labelEntidad.Name = "labelEntidad"
        Me.labelEntidad.Size = New System.Drawing.Size(46, 13)
        Me.labelEntidad.TabIndex = 7
        Me.labelEntidad.Text = "Entidad:"
        '
        'datetimepickerFecha
        '
        Me.datetimepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFecha.Location = New System.Drawing.Point(96, 68)
        Me.datetimepickerFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFecha.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFecha.Name = "datetimepickerFecha"
        Me.datetimepickerFecha.Size = New System.Drawing.Size(113, 20)
        Me.datetimepickerFecha.TabIndex = 6
        '
        'integertextboxNumero
        '
        Me.integertextboxNumero.BeforeTouchSize = New System.Drawing.Size(86, 20)
        Me.integertextboxNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.integertextboxNumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.integertextboxNumero.IntegerValue = CType(0, Long)
        Me.integertextboxNumero.Location = New System.Drawing.Point(96, 42)
        Me.integertextboxNumero.MaxValue = CType(99999999, Long)
        Me.integertextboxNumero.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.integertextboxNumero.MinMaxValidation = Syncfusion.Windows.Forms.Tools.MinMaxValidation.OnLostFocus
        Me.integertextboxNumero.MinValue = CType(1, Long)
        Me.integertextboxNumero.Name = "integertextboxNumero"
        Me.integertextboxNumero.NullString = ""
        Me.integertextboxNumero.Size = New System.Drawing.Size(86, 20)
        Me.integertextboxNumero.TabIndex = 3
        Me.integertextboxNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'checkboxCerrada
        '
        Me.checkboxCerrada.AutoSize = True
        Me.checkboxCerrada.Location = New System.Drawing.Point(96, 137)
        Me.checkboxCerrada.Name = "checkboxCerrada"
        Me.checkboxCerrada.Size = New System.Drawing.Size(15, 14)
        Me.checkboxCerrada.TabIndex = 11
        Me.checkboxCerrada.UseVisualStyleBackColor = True
        '
        'labelEsActivo
        '
        Me.labelEsActivo.AutoSize = True
        Me.labelEsActivo.Location = New System.Drawing.Point(6, 137)
        Me.labelEsActivo.Name = "labelEsActivo"
        Me.labelEsActivo.Size = New System.Drawing.Size(47, 13)
        Me.labelEsActivo.TabIndex = 10
        Me.labelEsActivo.Text = "Cerrada:"
        '
        'tabpageDetalles
        '
        Me.tabpageDetalles.Controls.Add(Me.datagridviewDetalles)
        Me.tabpageDetalles.Controls.Add(Me.toolstripDetalles)
        Me.tabpageDetalles.Location = New System.Drawing.Point(4, 25)
        Me.tabpageDetalles.Name = "tabpageDetalles"
        Me.tabpageDetalles.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageDetalles.Size = New System.Drawing.Size(656, 183)
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
        Me.datagridviewDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagridviewDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnFactura, Me.columnArea, Me.columnDetalle, Me.columnImporte})
        Me.datagridviewDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewDetalles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewDetalles.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewDetalles.MultiSelect = False
        Me.datagridviewDetalles.Name = "datagridviewDetalles"
        Me.datagridviewDetalles.ReadOnly = True
        Me.datagridviewDetalles.RowHeadersVisible = False
        Me.datagridviewDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewDetalles.Size = New System.Drawing.Size(563, 177)
        Me.datagridviewDetalles.TabIndex = 8
        '
        'columnFactura
        '
        Me.columnFactura.DataPropertyName = "Factura"
        Me.columnFactura.HeaderText = "Factura"
        Me.columnFactura.Name = "columnFactura"
        Me.columnFactura.ReadOnly = True
        Me.columnFactura.Width = 68
        '
        'columnArea
        '
        Me.columnArea.DataPropertyName = "AreaNombre"
        Me.columnArea.HeaderText = "Área"
        Me.columnArea.Name = "columnArea"
        Me.columnArea.ReadOnly = True
        Me.columnArea.Width = 54
        '
        'columnDetalle
        '
        Me.columnDetalle.DataPropertyName = "Detalle"
        Me.columnDetalle.HeaderText = "Detalle"
        Me.columnDetalle.Name = "columnDetalle"
        Me.columnDetalle.ReadOnly = True
        Me.columnDetalle.Width = 65
        '
        'columnImporte
        '
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
        Me.toolstripDetalles.Size = New System.Drawing.Size(87, 177)
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
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelIDCompraOrden)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxIDCompraOrden)
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(656, 183)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelIDCompraOrden
        '
        Me.labelIDCompraOrden.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelIDCompraOrden.AutoSize = True
        Me.labelIDCompraOrden.Location = New System.Drawing.Point(6, 111)
        Me.labelIDCompraOrden.Name = "labelIDCompraOrden"
        Me.labelIDCompraOrden.Size = New System.Drawing.Size(21, 13)
        Me.labelIDCompraOrden.TabIndex = 2
        Me.labelIDCompraOrden.Text = "ID:"
        '
        'textboxIDCompraOrden
        '
        Me.textboxIDCompraOrden.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxIDCompraOrden.Location = New System.Drawing.Point(114, 108)
        Me.textboxIDCompraOrden.MaxLength = 10
        Me.textboxIDCompraOrden.Name = "textboxIDCompraOrden"
        Me.textboxIDCompraOrden.ReadOnly = True
        Me.textboxIDCompraOrden.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDCompraOrden.TabIndex = 3
        Me.textboxIDCompraOrden.TabStop = False
        Me.textboxIDCompraOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 160)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(409, 20)
        Me.textboxUsuarioModificacion.TabIndex = 9
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 134)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(409, 20)
        Me.textboxUsuarioCreacion.TabIndex = 6
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 160)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 8
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 134)
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
        Me.textboxNotas.Size = New System.Drawing.Size(542, 96)
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
        'formCompraOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 267)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formCompraOrden"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Órden de compra"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
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
    Friend WithEvents comboboxEntidad As System.Windows.Forms.ComboBox
    Friend WithEvents tabcontrolMain As CS_Control_TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents checkboxCerrada As CheckBox
    Friend WithEvents labelNumero As Label
    Friend WithEvents labelFecha As Label
    Friend WithEvents labelEntidad As Label
    Friend WithEvents datetimepickerFecha As DateTimePicker
    Friend WithEvents integertextboxNumero As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents labelEsActivo As Label
    Friend WithEvents tabpageDetalles As TabPage
    Friend WithEvents datagridviewDetalles As DataGridView
    Friend WithEvents toolstripDetalles As ToolStrip
    Friend WithEvents buttonDetallesAgregar As ToolStripButton
    Friend WithEvents buttonDetallesEditar As ToolStripButton
    Friend WithEvents buttonDetallesEliminar As ToolStripButton
    Friend WithEvents datetimepickerCierreFecha As DateTimePicker
    Friend WithEvents buttonImprimir As ToolStripButton
    Friend WithEvents labelIDCompraOrden As Label
    Friend WithEvents textboxIDCompraOrden As TextBox
    Friend WithEvents comboboxCuartel As ComboBox
    Friend WithEvents buttonCodigoSiguiente As Button
    Friend WithEvents columnFactura As DataGridViewTextBoxColumn
    Friend WithEvents columnArea As DataGridViewTextBoxColumn
    Friend WithEvents columnDetalle As DataGridViewTextBoxColumn
    Friend WithEvents columnImporte As DataGridViewTextBoxColumn
End Class
