﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formComprobante
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
        Dim labelFechaServicioDesde As System.Windows.Forms.Label
        Dim labelFechaServicioHasta As System.Windows.Forms.Label
        Dim labelEnvioEmail As System.Windows.Forms.Label
        Dim labelNotas As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelArea As System.Windows.Forms.Label
        Dim labelEsBienUso As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formComprobante))
        Me.panelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tabcontrolMain = New System.Windows.Forms.TabControl()
        Me.tabpageDescripcion = New System.Windows.Forms.TabPage()
        Me.textboxDescripcion = New System.Windows.Forms.TextBox()
        Me.tabpageDetalle = New System.Windows.Forms.TabPage()
        Me.datagridviewDetalle = New System.Windows.Forms.DataGridView()
        Me.columnDetalle_Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDetalle_PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDetalle_PrecioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripDetalle = New System.Windows.Forms.ToolStrip()
        Me.buttonDetalle_Agregar = New System.Windows.Forms.ToolStripSplitButton()
        Me.buttonDetalle_AgregarMultiple = New System.Windows.Forms.ToolStripMenuItem()
        Me.buttonDetalle_Editar = New System.Windows.Forms.ToolStripButton()
        Me.buttonDetalle_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageAplicaciones = New System.Windows.Forms.TabPage()
        Me.datagridviewAplicaciones = New System.Windows.Forms.DataGridView()
        Me.columnAplicaciones_Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnAplicaciones_NumeroCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnAplicaciones_Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnAplicaciones_ImporteTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnAplicaciones_ImporteAplicado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripAplicaciones = New System.Windows.Forms.ToolStrip()
        Me.buttonAplicaciones_AplicarTodo = New System.Windows.Forms.ToolStripButton()
        Me.buttonAplicaciones_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAplicaciones_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageMediosPago = New System.Windows.Forms.TabPage()
        Me.datagridviewMediosPago = New System.Windows.Forms.DataGridView()
        Me.columnMedioPagos_MedioPagoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMedioPagos_Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMedioPagos_BancoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMedioPagos_Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMedioPagos_FechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripMediosPago = New System.Windows.Forms.ToolStrip()
        Me.buttonMediosPago_AgregarOtro = New System.Windows.Forms.ToolStripButton()
        Me.buttonMediosPago_AgregarCheque = New System.Windows.Forms.ToolStripButton()
        Me.buttonMediosPago_Editar = New System.Windows.Forms.ToolStripButton()
        Me.buttonMediosPago_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.textboxFechaHoraEnvioEmail = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioEnvioEmail = New System.Windows.Forms.TextBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.panelCabecera = New System.Windows.Forms.FlowLayoutPanel()
        Me.panelIdentificacion = New System.Windows.Forms.Panel()
        Me.MaskedTextBoxNumero = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxPuntoVenta = New System.Windows.Forms.MaskedTextBox()
        Me.labelPuntoVenta = New System.Windows.Forms.Label()
        Me.comboboxComprobanteTipo = New System.Windows.Forms.ComboBox()
        Me.labelComprobanteTipo = New System.Windows.Forms.Label()
        Me.labelComprobanteNumero = New System.Windows.Forms.Label()
        Me.datetimepickerFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.labelFechaEmision = New System.Windows.Forms.Label()
        Me.textboxIDComprobante = New System.Windows.Forms.TextBox()
        Me.labelIDComprobante = New System.Windows.Forms.Label()
        Me.panelFechas = New System.Windows.Forms.Panel()
        Me.datetimepickerFechaServicioHasta = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerFechaServicioDesde = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.labelFechaVencimiento = New System.Windows.Forms.Label()
        Me.panelEntidad = New System.Windows.Forms.Panel()
        Me.comboboxEntidad = New System.Windows.Forms.ComboBox()
        Me.labelEntidad = New System.Windows.Forms.Label()
        Me.panelDatoGasto = New System.Windows.Forms.Panel()
        Me.checkboxEsBienUso = New System.Windows.Forms.CheckBox()
        Me.comboboxArea = New System.Windows.Forms.ComboBox()
        Me.panelPie = New System.Windows.Forms.FlowLayoutPanel()
        Me.panelImporteTotal = New System.Windows.Forms.Panel()
        Me.currencytextboxImporteTotal = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.labelImporteTotal = New System.Windows.Forms.Label()
        Me.panelMediosPago_Subtotal = New System.Windows.Forms.Panel()
        Me.currencytextboxMediosPago_Subtotal = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.labelMediosPago_Subtotal = New System.Windows.Forms.Label()
        Me.panelAplicaciones_Subtotal = New System.Windows.Forms.Panel()
        Me.currencytextboxAplicaciones_Subtotal = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.labelAplicaciones_Subtotal = New System.Windows.Forms.Label()
        Me.panelDetalle_Subtotal = New System.Windows.Forms.Panel()
        Me.currencytextboxDetalle_Subtotal = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.labelDetalle_Subtotal = New System.Windows.Forms.Label()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAFIP = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menuitemAFIP_ObtenerCAE = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemAFIP_ObtenerQR = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemAFIP_VerificarDatos = New System.Windows.Forms.ToolStripMenuItem()
        labelFechaServicioDesde = New System.Windows.Forms.Label()
        labelFechaServicioHasta = New System.Windows.Forms.Label()
        labelEnvioEmail = New System.Windows.Forms.Label()
        labelNotas = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelArea = New System.Windows.Forms.Label()
        labelEsBienUso = New System.Windows.Forms.Label()
        Me.panelMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageDescripcion.SuspendLayout()
        Me.tabpageDetalle.SuspendLayout()
        CType(Me.datagridviewDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripDetalle.SuspendLayout()
        Me.tabpageAplicaciones.SuspendLayout()
        CType(Me.datagridviewAplicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripAplicaciones.SuspendLayout()
        Me.tabpageMediosPago.SuspendLayout()
        CType(Me.datagridviewMediosPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripMediosPago.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.panelCabecera.SuspendLayout()
        Me.panelIdentificacion.SuspendLayout()
        Me.panelFechas.SuspendLayout()
        Me.panelEntidad.SuspendLayout()
        Me.panelDatoGasto.SuspendLayout()
        Me.panelPie.SuspendLayout()
        Me.panelImporteTotal.SuspendLayout()
        CType(Me.currencytextboxImporteTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMediosPago_Subtotal.SuspendLayout()
        CType(Me.currencytextboxMediosPago_Subtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAplicaciones_Subtotal.SuspendLayout()
        CType(Me.currencytextboxAplicaciones_Subtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDetalle_Subtotal.SuspendLayout()
        CType(Me.currencytextboxDetalle_Subtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelFechaServicioDesde
        '
        labelFechaServicioDesde.AutoSize = True
        labelFechaServicioDesde.Location = New System.Drawing.Point(251, 6)
        labelFechaServicioDesde.Name = "labelFechaServicioDesde"
        labelFechaServicioDesde.Size = New System.Drawing.Size(133, 13)
        labelFechaServicioDesde.TabIndex = 2
        labelFechaServicioDesde.Text = "Período Facturado Desde:"
        '
        'labelFechaServicioHasta
        '
        labelFechaServicioHasta.AutoSize = True
        labelFechaServicioHasta.Location = New System.Drawing.Point(516, 6)
        labelFechaServicioHasta.Name = "labelFechaServicioHasta"
        labelFechaServicioHasta.Size = New System.Drawing.Size(38, 13)
        labelFechaServicioHasta.TabIndex = 4
        labelFechaServicioHasta.Text = "Hasta:"
        '
        'labelEnvioEmail
        '
        labelEnvioEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelEnvioEmail.AutoSize = True
        labelEnvioEmail.Location = New System.Drawing.Point(6, 207)
        labelEnvioEmail.Name = "labelEnvioEmail"
        labelEnvioEmail.Size = New System.Drawing.Size(115, 13)
        labelEnvioEmail.TabIndex = 10
        labelEnvioEmail.Text = "Ultimo envío de e-mail:"
        '
        'labelNotas
        '
        labelNotas.AutoSize = True
        labelNotas.Location = New System.Drawing.Point(6, 9)
        labelNotas.Name = "labelNotas"
        labelNotas.Size = New System.Drawing.Size(38, 13)
        labelNotas.TabIndex = 2
        labelNotas.Text = "Notas:"
        '
        'labelCreacion
        '
        labelCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 146)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 4
        labelCreacion.Text = "Creación:"
        '
        'labelModificacion
        '
        labelModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 172)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 7
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelArea
        '
        labelArea.AutoSize = True
        labelArea.Location = New System.Drawing.Point(3, 6)
        labelArea.Name = "labelArea"
        labelArea.Size = New System.Drawing.Size(32, 13)
        labelArea.TabIndex = 0
        labelArea.Text = "Area:"
        '
        'labelEsBienUso
        '
        labelEsBienUso.AutoSize = True
        labelEsBienUso.Location = New System.Drawing.Point(317, 6)
        labelEsBienUso.Name = "labelEsBienUso"
        labelEsBienUso.Size = New System.Drawing.Size(80, 13)
        labelEsBienUso.TabIndex = 2
        labelEsBienUso.Text = "Es bien de uso:"
        '
        'panelMain
        '
        Me.panelMain.AutoSize = True
        Me.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelMain.ColumnCount = 1
        Me.panelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panelMain.Controls.Add(Me.tabcontrolMain, 0, 1)
        Me.panelMain.Controls.Add(Me.panelCabecera, 0, 0)
        Me.panelMain.Controls.Add(Me.panelPie, 0, 2)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(0, 39)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.RowCount = 3
        Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panelMain.Size = New System.Drawing.Size(852, 423)
        Me.panelMain.TabIndex = 0
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Controls.Add(Me.tabpageDescripcion)
        Me.tabcontrolMain.Controls.Add(Me.tabpageDetalle)
        Me.tabcontrolMain.Controls.Add(Me.tabpageAplicaciones)
        Me.tabcontrolMain.Controls.Add(Me.tabpageMediosPago)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrolMain.Location = New System.Drawing.Point(3, 149)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(846, 221)
        Me.tabcontrolMain.TabIndex = 1
        '
        'tabpageDescripcion
        '
        Me.tabpageDescripcion.Controls.Add(Me.textboxDescripcion)
        Me.tabpageDescripcion.Location = New System.Drawing.Point(4, 22)
        Me.tabpageDescripcion.Name = "tabpageDescripcion"
        Me.tabpageDescripcion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageDescripcion.Size = New System.Drawing.Size(838, 195)
        Me.tabpageDescripcion.TabIndex = 6
        Me.tabpageDescripcion.Text = "Descripción"
        '
        'textboxDescripcion
        '
        Me.textboxDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textboxDescripcion.Location = New System.Drawing.Point(3, 3)
        Me.textboxDescripcion.MaxLength = 0
        Me.textboxDescripcion.Multiline = True
        Me.textboxDescripcion.Name = "textboxDescripcion"
        Me.textboxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxDescripcion.Size = New System.Drawing.Size(832, 189)
        Me.textboxDescripcion.TabIndex = 2
        '
        'tabpageDetalle
        '
        Me.tabpageDetalle.Controls.Add(Me.datagridviewDetalle)
        Me.tabpageDetalle.Controls.Add(Me.toolstripDetalle)
        Me.tabpageDetalle.Location = New System.Drawing.Point(4, 22)
        Me.tabpageDetalle.Name = "tabpageDetalle"
        Me.tabpageDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageDetalle.Size = New System.Drawing.Size(838, 195)
        Me.tabpageDetalle.TabIndex = 0
        Me.tabpageDetalle.Text = "Detalle"
        '
        'datagridviewDetalle
        '
        Me.datagridviewDetalle.AllowUserToAddRows = False
        Me.datagridviewDetalle.AllowUserToDeleteRows = False
        Me.datagridviewDetalle.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnDetalle_Descripcion, Me.columnDetalle_PrecioUnitario, Me.columnDetalle_PrecioTotal})
        Me.datagridviewDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewDetalle.Location = New System.Drawing.Point(101, 3)
        Me.datagridviewDetalle.MultiSelect = False
        Me.datagridviewDetalle.Name = "datagridviewDetalle"
        Me.datagridviewDetalle.ReadOnly = True
        Me.datagridviewDetalle.RowHeadersVisible = False
        Me.datagridviewDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewDetalle.Size = New System.Drawing.Size(734, 189)
        Me.datagridviewDetalle.TabIndex = 4
        '
        'columnDetalle_Descripcion
        '
        Me.columnDetalle_Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnDetalle_Descripcion.DataPropertyName = "DescripcionDisplay"
        Me.columnDetalle_Descripcion.HeaderText = "Descripción"
        Me.columnDetalle_Descripcion.Name = "columnDetalle_Descripcion"
        Me.columnDetalle_Descripcion.ReadOnly = True
        Me.columnDetalle_Descripcion.Width = 88
        '
        'columnDetalle_PrecioUnitario
        '
        Me.columnDetalle_PrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnDetalle_PrecioUnitario.DataPropertyName = "PrecioUnitario"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.columnDetalle_PrecioUnitario.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnDetalle_PrecioUnitario.HeaderText = "Precio Unitario"
        Me.columnDetalle_PrecioUnitario.Name = "columnDetalle_PrecioUnitario"
        Me.columnDetalle_PrecioUnitario.ReadOnly = True
        Me.columnDetalle_PrecioUnitario.Width = 101
        '
        'columnDetalle_PrecioTotal
        '
        Me.columnDetalle_PrecioTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnDetalle_PrecioTotal.DataPropertyName = "PrecioTotal"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.columnDetalle_PrecioTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.columnDetalle_PrecioTotal.HeaderText = "Precio Total"
        Me.columnDetalle_PrecioTotal.Name = "columnDetalle_PrecioTotal"
        Me.columnDetalle_PrecioTotal.ReadOnly = True
        Me.columnDetalle_PrecioTotal.Width = 89
        '
        'toolstripDetalle
        '
        Me.toolstripDetalle.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripDetalle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonDetalle_Agregar, Me.buttonDetalle_Editar, Me.buttonDetalle_Eliminar})
        Me.toolstripDetalle.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripDetalle.Location = New System.Drawing.Point(3, 3)
        Me.toolstripDetalle.Name = "toolstripDetalle"
        Me.toolstripDetalle.Size = New System.Drawing.Size(98, 189)
        Me.toolstripDetalle.TabIndex = 5
        '
        'buttonDetalle_Agregar
        '
        Me.buttonDetalle_Agregar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonDetalle_AgregarMultiple})
        Me.buttonDetalle_Agregar.Image = Global.CSBomberos.My.Resources.Resources.ImageAgregar32
        Me.buttonDetalle_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonDetalle_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonDetalle_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonDetalle_Agregar.Name = "buttonDetalle_Agregar"
        Me.buttonDetalle_Agregar.Size = New System.Drawing.Size(95, 36)
        Me.buttonDetalle_Agregar.Text = "Agregar"
        '
        'buttonDetalle_AgregarMultiple
        '
        Me.buttonDetalle_AgregarMultiple.Name = "buttonDetalle_AgregarMultiple"
        Me.buttonDetalle_AgregarMultiple.Size = New System.Drawing.Size(161, 22)
        Me.buttonDetalle_AgregarMultiple.Text = "Multiples cuotas"
        '
        'buttonDetalle_Editar
        '
        Me.buttonDetalle_Editar.Image = Global.CSBomberos.My.Resources.Resources.ImageEditar32
        Me.buttonDetalle_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonDetalle_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonDetalle_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonDetalle_Editar.Name = "buttonDetalle_Editar"
        Me.buttonDetalle_Editar.Size = New System.Drawing.Size(95, 36)
        Me.buttonDetalle_Editar.Text = "Editar"
        '
        'buttonDetalle_Eliminar
        '
        Me.buttonDetalle_Eliminar.Image = Global.CSBomberos.My.Resources.Resources.ImageBorrar32
        Me.buttonDetalle_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonDetalle_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonDetalle_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonDetalle_Eliminar.Name = "buttonDetalle_Eliminar"
        Me.buttonDetalle_Eliminar.Size = New System.Drawing.Size(95, 36)
        Me.buttonDetalle_Eliminar.Text = "Eliminar"
        '
        'tabpageAplicaciones
        '
        Me.tabpageAplicaciones.Controls.Add(Me.datagridviewAplicaciones)
        Me.tabpageAplicaciones.Controls.Add(Me.toolstripAplicaciones)
        Me.tabpageAplicaciones.Location = New System.Drawing.Point(4, 22)
        Me.tabpageAplicaciones.Name = "tabpageAplicaciones"
        Me.tabpageAplicaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageAplicaciones.Size = New System.Drawing.Size(838, 195)
        Me.tabpageAplicaciones.TabIndex = 2
        Me.tabpageAplicaciones.Text = "Aplicaciones"
        '
        'datagridviewAplicaciones
        '
        Me.datagridviewAplicaciones.AllowUserToAddRows = False
        Me.datagridviewAplicaciones.AllowUserToDeleteRows = False
        Me.datagridviewAplicaciones.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewAplicaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.datagridviewAplicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewAplicaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnAplicaciones_Tipo, Me.columnAplicaciones_NumeroCompleto, Me.columnAplicaciones_Fecha, Me.columnAplicaciones_ImporteTotal, Me.columnAplicaciones_ImporteAplicado})
        Me.datagridviewAplicaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewAplicaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewAplicaciones.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewAplicaciones.MultiSelect = False
        Me.datagridviewAplicaciones.Name = "datagridviewAplicaciones"
        Me.datagridviewAplicaciones.ReadOnly = True
        Me.datagridviewAplicaciones.RowHeadersVisible = False
        Me.datagridviewAplicaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewAplicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewAplicaciones.Size = New System.Drawing.Size(745, 189)
        Me.datagridviewAplicaciones.TabIndex = 9
        '
        'columnAplicaciones_Tipo
        '
        Me.columnAplicaciones_Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnAplicaciones_Tipo.DataPropertyName = "ComprobanteTipoNombre"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnAplicaciones_Tipo.DefaultCellStyle = DataGridViewCellStyle5
        Me.columnAplicaciones_Tipo.HeaderText = "Tipo"
        Me.columnAplicaciones_Tipo.Name = "columnAplicaciones_Tipo"
        Me.columnAplicaciones_Tipo.ReadOnly = True
        Me.columnAplicaciones_Tipo.Width = 53
        '
        'columnAplicaciones_NumeroCompleto
        '
        Me.columnAplicaciones_NumeroCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnAplicaciones_NumeroCompleto.DataPropertyName = "NumeroCompleto"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnAplicaciones_NumeroCompleto.DefaultCellStyle = DataGridViewCellStyle6
        Me.columnAplicaciones_NumeroCompleto.HeaderText = "Número"
        Me.columnAplicaciones_NumeroCompleto.Name = "columnAplicaciones_NumeroCompleto"
        Me.columnAplicaciones_NumeroCompleto.ReadOnly = True
        Me.columnAplicaciones_NumeroCompleto.Width = 69
        '
        'columnAplicaciones_Fecha
        '
        Me.columnAplicaciones_Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnAplicaciones_Fecha.DataPropertyName = "FechaEmision"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnAplicaciones_Fecha.DefaultCellStyle = DataGridViewCellStyle7
        Me.columnAplicaciones_Fecha.HeaderText = "Fecha"
        Me.columnAplicaciones_Fecha.Name = "columnAplicaciones_Fecha"
        Me.columnAplicaciones_Fecha.ReadOnly = True
        Me.columnAplicaciones_Fecha.Width = 62
        '
        'columnAplicaciones_ImporteTotal
        '
        Me.columnAplicaciones_ImporteTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnAplicaciones_ImporteTotal.DataPropertyName = "ImporteTotal"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.columnAplicaciones_ImporteTotal.DefaultCellStyle = DataGridViewCellStyle8
        Me.columnAplicaciones_ImporteTotal.HeaderText = "Importe Total"
        Me.columnAplicaciones_ImporteTotal.Name = "columnAplicaciones_ImporteTotal"
        Me.columnAplicaciones_ImporteTotal.ReadOnly = True
        Me.columnAplicaciones_ImporteTotal.Width = 87
        '
        'columnAplicaciones_ImporteAplicado
        '
        Me.columnAplicaciones_ImporteAplicado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnAplicaciones_ImporteAplicado.DataPropertyName = "ImporteAplicado"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.columnAplicaciones_ImporteAplicado.DefaultCellStyle = DataGridViewCellStyle9
        Me.columnAplicaciones_ImporteAplicado.HeaderText = "Importe aplicado"
        Me.columnAplicaciones_ImporteAplicado.Name = "columnAplicaciones_ImporteAplicado"
        Me.columnAplicaciones_ImporteAplicado.ReadOnly = True
        Me.columnAplicaciones_ImporteAplicado.Width = 101
        '
        'toolstripAplicaciones
        '
        Me.toolstripAplicaciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripAplicaciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripAplicaciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripAplicaciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAplicaciones_AplicarTodo, Me.buttonAplicaciones_Agregar, Me.buttonAplicaciones_Eliminar})
        Me.toolstripAplicaciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripAplicaciones.Location = New System.Drawing.Point(3, 3)
        Me.toolstripAplicaciones.Name = "toolstripAplicaciones"
        Me.toolstripAplicaciones.Size = New System.Drawing.Size(87, 189)
        Me.toolstripAplicaciones.TabIndex = 8
        '
        'buttonAplicaciones_AplicarTodo
        '
        Me.buttonAplicaciones_AplicarTodo.Image = Global.CSBomberos.My.Resources.Resources.ImageAgregar32
        Me.buttonAplicaciones_AplicarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAplicaciones_AplicarTodo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAplicaciones_AplicarTodo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAplicaciones_AplicarTodo.Name = "buttonAplicaciones_AplicarTodo"
        Me.buttonAplicaciones_AplicarTodo.Size = New System.Drawing.Size(107, 36)
        Me.buttonAplicaciones_AplicarTodo.Text = "Auto Aplicar"
        Me.buttonAplicaciones_AplicarTodo.Visible = False
        '
        'buttonAplicaciones_Agregar
        '
        Me.buttonAplicaciones_Agregar.Image = Global.CSBomberos.My.Resources.Resources.ImageAgregar32
        Me.buttonAplicaciones_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAplicaciones_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAplicaciones_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAplicaciones_Agregar.Name = "buttonAplicaciones_Agregar"
        Me.buttonAplicaciones_Agregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAplicaciones_Agregar.Text = "Agregar"
        '
        'buttonAplicaciones_Eliminar
        '
        Me.buttonAplicaciones_Eliminar.Image = Global.CSBomberos.My.Resources.Resources.ImageBorrar32
        Me.buttonAplicaciones_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAplicaciones_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAplicaciones_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAplicaciones_Eliminar.Name = "buttonAplicaciones_Eliminar"
        Me.buttonAplicaciones_Eliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAplicaciones_Eliminar.Text = "Eliminar"
        '
        'tabpageMediosPago
        '
        Me.tabpageMediosPago.Controls.Add(Me.datagridviewMediosPago)
        Me.tabpageMediosPago.Controls.Add(Me.toolstripMediosPago)
        Me.tabpageMediosPago.Location = New System.Drawing.Point(4, 22)
        Me.tabpageMediosPago.Name = "tabpageMediosPago"
        Me.tabpageMediosPago.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageMediosPago.Size = New System.Drawing.Size(838, 195)
        Me.tabpageMediosPago.TabIndex = 4
        Me.tabpageMediosPago.Text = "Medios de pago"
        '
        'datagridviewMediosPago
        '
        Me.datagridviewMediosPago.AllowUserToAddRows = False
        Me.datagridviewMediosPago.AllowUserToDeleteRows = False
        Me.datagridviewMediosPago.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewMediosPago.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.datagridviewMediosPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewMediosPago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnMedioPagos_MedioPagoNombre, Me.columnMedioPagos_Importe, Me.columnMedioPagos_BancoNombre, Me.columnMedioPagos_Numero, Me.columnMedioPagos_FechaVencimiento})
        Me.datagridviewMediosPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewMediosPago.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewMediosPago.Location = New System.Drawing.Point(133, 3)
        Me.datagridviewMediosPago.MultiSelect = False
        Me.datagridviewMediosPago.Name = "datagridviewMediosPago"
        Me.datagridviewMediosPago.ReadOnly = True
        Me.datagridviewMediosPago.RowHeadersVisible = False
        Me.datagridviewMediosPago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMediosPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewMediosPago.Size = New System.Drawing.Size(702, 189)
        Me.datagridviewMediosPago.TabIndex = 3
        '
        'columnMedioPagos_MedioPagoNombre
        '
        Me.columnMedioPagos_MedioPagoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnMedioPagos_MedioPagoNombre.DataPropertyName = "MedioPagoNombre"
        Me.columnMedioPagos_MedioPagoNombre.HeaderText = "Medio de Pago"
        Me.columnMedioPagos_MedioPagoNombre.Name = "columnMedioPagos_MedioPagoNombre"
        Me.columnMedioPagos_MedioPagoNombre.ReadOnly = True
        Me.columnMedioPagos_MedioPagoNombre.Width = 73
        '
        'columnMedioPagos_Importe
        '
        Me.columnMedioPagos_Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnMedioPagos_Importe.DataPropertyName = "Importe"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "C2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.columnMedioPagos_Importe.DefaultCellStyle = DataGridViewCellStyle11
        Me.columnMedioPagos_Importe.HeaderText = "Importe"
        Me.columnMedioPagos_Importe.Name = "columnMedioPagos_Importe"
        Me.columnMedioPagos_Importe.ReadOnly = True
        Me.columnMedioPagos_Importe.Width = 67
        '
        'columnMedioPagos_BancoNombre
        '
        Me.columnMedioPagos_BancoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnMedioPagos_BancoNombre.DataPropertyName = "BancoNombre"
        Me.columnMedioPagos_BancoNombre.HeaderText = "Banco"
        Me.columnMedioPagos_BancoNombre.Name = "columnMedioPagos_BancoNombre"
        Me.columnMedioPagos_BancoNombre.ReadOnly = True
        Me.columnMedioPagos_BancoNombre.Visible = False
        '
        'columnMedioPagos_Numero
        '
        Me.columnMedioPagos_Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnMedioPagos_Numero.DataPropertyName = "Numero"
        Me.columnMedioPagos_Numero.HeaderText = "Número"
        Me.columnMedioPagos_Numero.Name = "columnMedioPagos_Numero"
        Me.columnMedioPagos_Numero.ReadOnly = True
        Me.columnMedioPagos_Numero.Visible = False
        '
        'columnMedioPagos_FechaVencimiento
        '
        Me.columnMedioPagos_FechaVencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnMedioPagos_FechaVencimiento.DataPropertyName = "FechaVencimiento"
        DataGridViewCellStyle12.Format = "d"
        Me.columnMedioPagos_FechaVencimiento.DefaultCellStyle = DataGridViewCellStyle12
        Me.columnMedioPagos_FechaVencimiento.HeaderText = "Fecha de Vencimiento"
        Me.columnMedioPagos_FechaVencimiento.Name = "columnMedioPagos_FechaVencimiento"
        Me.columnMedioPagos_FechaVencimiento.ReadOnly = True
        Me.columnMedioPagos_FechaVencimiento.Visible = False
        '
        'toolstripMediosPago
        '
        Me.toolstripMediosPago.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripMediosPago.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMediosPago.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripMediosPago.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonMediosPago_AgregarOtro, Me.buttonMediosPago_AgregarCheque, Me.buttonMediosPago_Editar, Me.buttonMediosPago_Eliminar})
        Me.toolstripMediosPago.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripMediosPago.Location = New System.Drawing.Point(3, 3)
        Me.toolstripMediosPago.Name = "toolstripMediosPago"
        Me.toolstripMediosPago.Size = New System.Drawing.Size(130, 189)
        Me.toolstripMediosPago.TabIndex = 4
        '
        'buttonMediosPago_AgregarOtro
        '
        Me.buttonMediosPago_AgregarOtro.Image = Global.CSBomberos.My.Resources.Resources.ImageAgregar32
        Me.buttonMediosPago_AgregarOtro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonMediosPago_AgregarOtro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonMediosPago_AgregarOtro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonMediosPago_AgregarOtro.Name = "buttonMediosPago_AgregarOtro"
        Me.buttonMediosPago_AgregarOtro.Size = New System.Drawing.Size(127, 36)
        Me.buttonMediosPago_AgregarOtro.Text = "Agregar Otro"
        '
        'buttonMediosPago_AgregarCheque
        '
        Me.buttonMediosPago_AgregarCheque.Image = Global.CSBomberos.My.Resources.Resources.ImageAgregar32
        Me.buttonMediosPago_AgregarCheque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonMediosPago_AgregarCheque.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonMediosPago_AgregarCheque.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonMediosPago_AgregarCheque.Name = "buttonMediosPago_AgregarCheque"
        Me.buttonMediosPago_AgregarCheque.Size = New System.Drawing.Size(127, 36)
        Me.buttonMediosPago_AgregarCheque.Text = "Agregar Cheque"
        '
        'buttonMediosPago_Editar
        '
        Me.buttonMediosPago_Editar.Image = Global.CSBomberos.My.Resources.Resources.ImageEditar32
        Me.buttonMediosPago_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonMediosPago_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonMediosPago_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonMediosPago_Editar.Name = "buttonMediosPago_Editar"
        Me.buttonMediosPago_Editar.Size = New System.Drawing.Size(127, 36)
        Me.buttonMediosPago_Editar.Text = "Editar"
        '
        'buttonMediosPago_Eliminar
        '
        Me.buttonMediosPago_Eliminar.Image = Global.CSBomberos.My.Resources.Resources.ImageBorrar32
        Me.buttonMediosPago_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonMediosPago_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonMediosPago_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonMediosPago_Eliminar.Name = "buttonMediosPago_Eliminar"
        Me.buttonMediosPago_Eliminar.Size = New System.Drawing.Size(127, 36)
        Me.buttonMediosPago_Eliminar.Text = "Eliminar"
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(labelEnvioEmail)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraEnvioEmail)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioEnvioEmail)
        Me.tabpageNotasAuditoria.Controls.Add(labelNotas)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxNotas)
        Me.tabpageNotasAuditoria.Controls.Add(labelCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(labelModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioModificacion)
        Me.tabpageNotasAuditoria.Location = New System.Drawing.Point(4, 22)
        Me.tabpageNotasAuditoria.Name = "tabpageNotasAuditoria"
        Me.tabpageNotasAuditoria.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(838, 195)
        Me.tabpageNotasAuditoria.TabIndex = 5
        Me.tabpageNotasAuditoria.Text = "Notas y auditoría"
        '
        'textboxFechaHoraEnvioEmail
        '
        Me.textboxFechaHoraEnvioEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraEnvioEmail.Location = New System.Drawing.Point(127, 204)
        Me.textboxFechaHoraEnvioEmail.MaxLength = 0
        Me.textboxFechaHoraEnvioEmail.Name = "textboxFechaHoraEnvioEmail"
        Me.textboxFechaHoraEnvioEmail.ReadOnly = True
        Me.textboxFechaHoraEnvioEmail.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraEnvioEmail.TabIndex = 11
        Me.textboxFechaHoraEnvioEmail.TabStop = False
        '
        'textboxUsuarioEnvioEmail
        '
        Me.textboxUsuarioEnvioEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioEnvioEmail.Location = New System.Drawing.Point(254, 204)
        Me.textboxUsuarioEnvioEmail.MaxLength = 50
        Me.textboxUsuarioEnvioEmail.Name = "textboxUsuarioEnvioEmail"
        Me.textboxUsuarioEnvioEmail.ReadOnly = True
        Me.textboxUsuarioEnvioEmail.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioEnvioEmail.TabIndex = 12
        Me.textboxUsuarioEnvioEmail.TabStop = False
        '
        'textboxNotas
        '
        Me.textboxNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxNotas.Location = New System.Drawing.Point(127, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(711, 131)
        Me.textboxNotas.TabIndex = 3
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(127, 143)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 5
        Me.textboxFechaHoraCreacion.TabStop = False
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(254, 143)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 6
        Me.textboxUsuarioCreacion.TabStop = False
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(127, 169)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 8
        Me.textboxFechaHoraModificacion.TabStop = False
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(254, 169)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 9
        Me.textboxUsuarioModificacion.TabStop = False
        '
        'panelCabecera
        '
        Me.panelCabecera.AutoSize = True
        Me.panelCabecera.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelCabecera.Controls.Add(Me.panelIdentificacion)
        Me.panelCabecera.Controls.Add(Me.panelFechas)
        Me.panelCabecera.Controls.Add(Me.panelEntidad)
        Me.panelCabecera.Controls.Add(Me.panelDatoGasto)
        Me.panelCabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCabecera.Location = New System.Drawing.Point(3, 3)
        Me.panelCabecera.Name = "panelCabecera"
        Me.panelCabecera.Size = New System.Drawing.Size(846, 140)
        Me.panelCabecera.TabIndex = 0
        '
        'panelIdentificacion
        '
        Me.panelIdentificacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelIdentificacion.Controls.Add(Me.MaskedTextBoxNumero)
        Me.panelIdentificacion.Controls.Add(Me.MaskedTextBoxPuntoVenta)
        Me.panelIdentificacion.Controls.Add(Me.labelPuntoVenta)
        Me.panelIdentificacion.Controls.Add(Me.comboboxComprobanteTipo)
        Me.panelIdentificacion.Controls.Add(Me.labelComprobanteTipo)
        Me.panelIdentificacion.Controls.Add(Me.labelComprobanteNumero)
        Me.panelIdentificacion.Controls.Add(Me.datetimepickerFechaEmision)
        Me.panelIdentificacion.Controls.Add(Me.labelFechaEmision)
        Me.panelIdentificacion.Controls.Add(Me.textboxIDComprobante)
        Me.panelIdentificacion.Controls.Add(Me.labelIDComprobante)
        Me.panelIdentificacion.Location = New System.Drawing.Point(3, 3)
        Me.panelIdentificacion.Name = "panelIdentificacion"
        Me.panelIdentificacion.Size = New System.Drawing.Size(804, 29)
        Me.panelIdentificacion.TabIndex = 0
        '
        'MaskedTextBoxNumero
        '
        Me.MaskedTextBoxNumero.Location = New System.Drawing.Point(516, 3)
        Me.MaskedTextBoxNumero.Name = "MaskedTextBoxNumero"
        Me.MaskedTextBoxNumero.Size = New System.Drawing.Size(62, 20)
        Me.MaskedTextBoxNumero.TabIndex = 7
        '
        'MaskedTextBoxPuntoVenta
        '
        Me.MaskedTextBoxPuntoVenta.Location = New System.Drawing.Point(407, 3)
        Me.MaskedTextBoxPuntoVenta.Name = "MaskedTextBoxPuntoVenta"
        Me.MaskedTextBoxPuntoVenta.Size = New System.Drawing.Size(40, 20)
        Me.MaskedTextBoxPuntoVenta.TabIndex = 5
        '
        'labelPuntoVenta
        '
        Me.labelPuntoVenta.AutoSize = True
        Me.labelPuntoVenta.Location = New System.Drawing.Point(317, 6)
        Me.labelPuntoVenta.Name = "labelPuntoVenta"
        Me.labelPuntoVenta.Size = New System.Drawing.Size(84, 13)
        Me.labelPuntoVenta.TabIndex = 4
        Me.labelPuntoVenta.Text = "Punto de Venta:"
        '
        'comboboxComprobanteTipo
        '
        Me.comboboxComprobanteTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxComprobanteTipo.FormattingEnabled = True
        Me.comboboxComprobanteTipo.Location = New System.Drawing.Point(152, 3)
        Me.comboboxComprobanteTipo.Name = "comboboxComprobanteTipo"
        Me.comboboxComprobanteTipo.Size = New System.Drawing.Size(159, 21)
        Me.comboboxComprobanteTipo.TabIndex = 3
        '
        'labelComprobanteTipo
        '
        Me.labelComprobanteTipo.AutoSize = True
        Me.labelComprobanteTipo.Location = New System.Drawing.Point(110, 6)
        Me.labelComprobanteTipo.Name = "labelComprobanteTipo"
        Me.labelComprobanteTipo.Size = New System.Drawing.Size(31, 13)
        Me.labelComprobanteTipo.TabIndex = 2
        Me.labelComprobanteTipo.Text = "Tipo:"
        '
        'labelComprobanteNumero
        '
        Me.labelComprobanteNumero.AutoSize = True
        Me.labelComprobanteNumero.Location = New System.Drawing.Point(464, 6)
        Me.labelComprobanteNumero.Name = "labelComprobanteNumero"
        Me.labelComprobanteNumero.Size = New System.Drawing.Size(47, 13)
        Me.labelComprobanteNumero.TabIndex = 6
        Me.labelComprobanteNumero.Text = "Número:"
        '
        'datetimepickerFechaEmision
        '
        Me.datetimepickerFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaEmision.Location = New System.Drawing.Point(694, 3)
        Me.datetimepickerFechaEmision.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaEmision.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaEmision.Name = "datetimepickerFechaEmision"
        Me.datetimepickerFechaEmision.Size = New System.Drawing.Size(104, 20)
        Me.datetimepickerFechaEmision.TabIndex = 9
        '
        'labelFechaEmision
        '
        Me.labelFechaEmision.AutoSize = True
        Me.labelFechaEmision.Location = New System.Drawing.Point(595, 6)
        Me.labelFechaEmision.Name = "labelFechaEmision"
        Me.labelFechaEmision.Size = New System.Drawing.Size(94, 13)
        Me.labelFechaEmision.TabIndex = 8
        Me.labelFechaEmision.Text = "Fecha de Emisión:"
        '
        'textboxIDComprobante
        '
        Me.textboxIDComprobante.Location = New System.Drawing.Point(30, 3)
        Me.textboxIDComprobante.MaxLength = 10
        Me.textboxIDComprobante.Name = "textboxIDComprobante"
        Me.textboxIDComprobante.ReadOnly = True
        Me.textboxIDComprobante.Size = New System.Drawing.Size(74, 20)
        Me.textboxIDComprobante.TabIndex = 1
        Me.textboxIDComprobante.TabStop = False
        Me.textboxIDComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelIDComprobante
        '
        Me.labelIDComprobante.AutoSize = True
        Me.labelIDComprobante.Location = New System.Drawing.Point(3, 6)
        Me.labelIDComprobante.Name = "labelIDComprobante"
        Me.labelIDComprobante.Size = New System.Drawing.Size(21, 13)
        Me.labelIDComprobante.TabIndex = 0
        Me.labelIDComprobante.Text = "ID:"
        '
        'panelFechas
        '
        Me.panelFechas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelFechas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelFechas.Controls.Add(Me.datetimepickerFechaServicioHasta)
        Me.panelFechas.Controls.Add(labelFechaServicioHasta)
        Me.panelFechas.Controls.Add(Me.datetimepickerFechaServicioDesde)
        Me.panelFechas.Controls.Add(Me.datetimepickerFechaVencimiento)
        Me.panelFechas.Controls.Add(labelFechaServicioDesde)
        Me.panelFechas.Controls.Add(Me.labelFechaVencimiento)
        Me.panelFechas.Location = New System.Drawing.Point(3, 38)
        Me.panelFechas.Name = "panelFechas"
        Me.panelFechas.Size = New System.Drawing.Size(685, 29)
        Me.panelFechas.TabIndex = 1
        '
        'datetimepickerFechaServicioHasta
        '
        Me.datetimepickerFechaServicioHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaServicioHasta.Location = New System.Drawing.Point(560, 2)
        Me.datetimepickerFechaServicioHasta.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaServicioHasta.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaServicioHasta.Name = "datetimepickerFechaServicioHasta"
        Me.datetimepickerFechaServicioHasta.ShowCheckBox = True
        Me.datetimepickerFechaServicioHasta.Size = New System.Drawing.Size(120, 20)
        Me.datetimepickerFechaServicioHasta.TabIndex = 5
        '
        'datetimepickerFechaServicioDesde
        '
        Me.datetimepickerFechaServicioDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaServicioDesde.Location = New System.Drawing.Point(390, 2)
        Me.datetimepickerFechaServicioDesde.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaServicioDesde.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaServicioDesde.Name = "datetimepickerFechaServicioDesde"
        Me.datetimepickerFechaServicioDesde.ShowCheckBox = True
        Me.datetimepickerFechaServicioDesde.Size = New System.Drawing.Size(120, 20)
        Me.datetimepickerFechaServicioDesde.TabIndex = 3
        '
        'datetimepickerFechaVencimiento
        '
        Me.datetimepickerFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaVencimiento.Location = New System.Drawing.Point(125, 2)
        Me.datetimepickerFechaVencimiento.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaVencimiento.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaVencimiento.Name = "datetimepickerFechaVencimiento"
        Me.datetimepickerFechaVencimiento.ShowCheckBox = True
        Me.datetimepickerFechaVencimiento.Size = New System.Drawing.Size(120, 20)
        Me.datetimepickerFechaVencimiento.TabIndex = 1
        '
        'labelFechaVencimiento
        '
        Me.labelFechaVencimiento.AutoSize = True
        Me.labelFechaVencimiento.Location = New System.Drawing.Point(3, 6)
        Me.labelFechaVencimiento.Name = "labelFechaVencimiento"
        Me.labelFechaVencimiento.Size = New System.Drawing.Size(116, 13)
        Me.labelFechaVencimiento.TabIndex = 0
        Me.labelFechaVencimiento.Text = "Fecha de Vencimiento:"
        '
        'panelEntidad
        '
        Me.panelEntidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelEntidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEntidad.Controls.Add(Me.comboboxEntidad)
        Me.panelEntidad.Controls.Add(Me.labelEntidad)
        Me.panelEntidad.Location = New System.Drawing.Point(3, 73)
        Me.panelEntidad.Name = "panelEntidad"
        Me.panelEntidad.Size = New System.Drawing.Size(630, 29)
        Me.panelEntidad.TabIndex = 2
        '
        'comboboxEntidad
        '
        Me.comboboxEntidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboboxEntidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxEntidad.FormattingEnabled = True
        Me.comboboxEntidad.Location = New System.Drawing.Point(68, 3)
        Me.comboboxEntidad.Name = "comboboxEntidad"
        Me.comboboxEntidad.Size = New System.Drawing.Size(557, 21)
        Me.comboboxEntidad.TabIndex = 1
        '
        'labelEntidad
        '
        Me.labelEntidad.AutoSize = True
        Me.labelEntidad.Location = New System.Drawing.Point(3, 6)
        Me.labelEntidad.Name = "labelEntidad"
        Me.labelEntidad.Size = New System.Drawing.Size(46, 13)
        Me.labelEntidad.TabIndex = 0
        Me.labelEntidad.Text = "Entidad:"
        '
        'panelDatoGasto
        '
        Me.panelDatoGasto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDatoGasto.Controls.Add(Me.checkboxEsBienUso)
        Me.panelDatoGasto.Controls.Add(labelEsBienUso)
        Me.panelDatoGasto.Controls.Add(labelArea)
        Me.panelDatoGasto.Controls.Add(Me.comboboxArea)
        Me.panelDatoGasto.Location = New System.Drawing.Point(3, 108)
        Me.panelDatoGasto.Name = "panelDatoGasto"
        Me.panelDatoGasto.Size = New System.Drawing.Size(428, 29)
        Me.panelDatoGasto.TabIndex = 3
        '
        'checkboxEsBienUso
        '
        Me.checkboxEsBienUso.AutoSize = True
        Me.checkboxEsBienUso.Location = New System.Drawing.Point(403, 6)
        Me.checkboxEsBienUso.Name = "checkboxEsBienUso"
        Me.checkboxEsBienUso.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsBienUso.TabIndex = 3
        Me.checkboxEsBienUso.UseVisualStyleBackColor = True
        '
        'comboboxArea
        '
        Me.comboboxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxArea.FormattingEnabled = True
        Me.comboboxArea.Location = New System.Drawing.Point(41, 3)
        Me.comboboxArea.Name = "comboboxArea"
        Me.comboboxArea.Size = New System.Drawing.Size(270, 21)
        Me.comboboxArea.TabIndex = 1
        '
        'panelPie
        '
        Me.panelPie.AutoSize = True
        Me.panelPie.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelPie.Controls.Add(Me.panelImporteTotal)
        Me.panelPie.Controls.Add(Me.panelMediosPago_Subtotal)
        Me.panelPie.Controls.Add(Me.panelAplicaciones_Subtotal)
        Me.panelPie.Controls.Add(Me.panelDetalle_Subtotal)
        Me.panelPie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPie.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.panelPie.Location = New System.Drawing.Point(3, 376)
        Me.panelPie.Name = "panelPie"
        Me.panelPie.Padding = New System.Windows.Forms.Padding(4)
        Me.panelPie.Size = New System.Drawing.Size(846, 44)
        Me.panelPie.TabIndex = 2
        '
        'panelImporteTotal
        '
        Me.panelImporteTotal.AutoSize = True
        Me.panelImporteTotal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelImporteTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelImporteTotal.Controls.Add(Me.currencytextboxImporteTotal)
        Me.panelImporteTotal.Controls.Add(Me.labelImporteTotal)
        Me.panelImporteTotal.Location = New System.Drawing.Point(668, 7)
        Me.panelImporteTotal.Name = "panelImporteTotal"
        Me.panelImporteTotal.Size = New System.Drawing.Size(167, 29)
        Me.panelImporteTotal.TabIndex = 0
        '
        'currencytextboxImporteTotal
        '
        Me.currencytextboxImporteTotal.AllowNull = True
        Me.currencytextboxImporteTotal.BeforeTouchSize = New System.Drawing.Size(80, 20)
        Me.currencytextboxImporteTotal.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxImporteTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.currencytextboxImporteTotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.currencytextboxImporteTotal.Location = New System.Drawing.Point(57, 2)
        Me.currencytextboxImporteTotal.MaxValue = New Decimal(New Integer() {999999999, 0, 0, 131072})
        Me.currencytextboxImporteTotal.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.currencytextboxImporteTotal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxImporteTotal.Name = "currencytextboxImporteTotal"
        Me.currencytextboxImporteTotal.NullString = ""
        Me.currencytextboxImporteTotal.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.currencytextboxImporteTotal.ReadOnly = True
        Me.currencytextboxImporteTotal.Size = New System.Drawing.Size(105, 22)
        Me.currencytextboxImporteTotal.TabIndex = 1
        Me.currencytextboxImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labelImporteTotal
        '
        Me.labelImporteTotal.AutoSize = True
        Me.labelImporteTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelImporteTotal.Location = New System.Drawing.Point(3, 5)
        Me.labelImporteTotal.Name = "labelImporteTotal"
        Me.labelImporteTotal.Size = New System.Drawing.Size(48, 16)
        Me.labelImporteTotal.TabIndex = 4
        Me.labelImporteTotal.Text = "Total:"
        '
        'panelMediosPago_Subtotal
        '
        Me.panelMediosPago_Subtotal.AutoSize = True
        Me.panelMediosPago_Subtotal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelMediosPago_Subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMediosPago_Subtotal.Controls.Add(Me.currencytextboxMediosPago_Subtotal)
        Me.panelMediosPago_Subtotal.Controls.Add(Me.labelMediosPago_Subtotal)
        Me.panelMediosPago_Subtotal.Location = New System.Drawing.Point(481, 7)
        Me.panelMediosPago_Subtotal.Name = "panelMediosPago_Subtotal"
        Me.panelMediosPago_Subtotal.Size = New System.Drawing.Size(181, 29)
        Me.panelMediosPago_Subtotal.TabIndex = 6
        '
        'currencytextboxMediosPago_Subtotal
        '
        Me.currencytextboxMediosPago_Subtotal.AllowNull = True
        Me.currencytextboxMediosPago_Subtotal.BeforeTouchSize = New System.Drawing.Size(80, 20)
        Me.currencytextboxMediosPago_Subtotal.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxMediosPago_Subtotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.currencytextboxMediosPago_Subtotal.Location = New System.Drawing.Point(96, 4)
        Me.currencytextboxMediosPago_Subtotal.MaxValue = New Decimal(New Integer() {999999999, 0, 0, 131072})
        Me.currencytextboxMediosPago_Subtotal.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.currencytextboxMediosPago_Subtotal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxMediosPago_Subtotal.Name = "currencytextboxMediosPago_Subtotal"
        Me.currencytextboxMediosPago_Subtotal.NullString = ""
        Me.currencytextboxMediosPago_Subtotal.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.currencytextboxMediosPago_Subtotal.ReadOnly = True
        Me.currencytextboxMediosPago_Subtotal.Size = New System.Drawing.Size(80, 20)
        Me.currencytextboxMediosPago_Subtotal.TabIndex = 1
        Me.currencytextboxMediosPago_Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labelMediosPago_Subtotal
        '
        Me.labelMediosPago_Subtotal.AutoSize = True
        Me.labelMediosPago_Subtotal.Location = New System.Drawing.Point(3, 7)
        Me.labelMediosPago_Subtotal.Name = "labelMediosPago_Subtotal"
        Me.labelMediosPago_Subtotal.Size = New System.Drawing.Size(87, 13)
        Me.labelMediosPago_Subtotal.TabIndex = 0
        Me.labelMediosPago_Subtotal.Text = "Medios de Pago:"
        '
        'panelAplicaciones_Subtotal
        '
        Me.panelAplicaciones_Subtotal.AutoSize = True
        Me.panelAplicaciones_Subtotal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelAplicaciones_Subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelAplicaciones_Subtotal.Controls.Add(Me.currencytextboxAplicaciones_Subtotal)
        Me.panelAplicaciones_Subtotal.Controls.Add(Me.labelAplicaciones_Subtotal)
        Me.panelAplicaciones_Subtotal.Location = New System.Drawing.Point(311, 7)
        Me.panelAplicaciones_Subtotal.Name = "panelAplicaciones_Subtotal"
        Me.panelAplicaciones_Subtotal.Size = New System.Drawing.Size(164, 29)
        Me.panelAplicaciones_Subtotal.TabIndex = 5
        '
        'currencytextboxAplicaciones_Subtotal
        '
        Me.currencytextboxAplicaciones_Subtotal.AllowNull = True
        Me.currencytextboxAplicaciones_Subtotal.BeforeTouchSize = New System.Drawing.Size(80, 20)
        Me.currencytextboxAplicaciones_Subtotal.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxAplicaciones_Subtotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.currencytextboxAplicaciones_Subtotal.Location = New System.Drawing.Point(79, 4)
        Me.currencytextboxAplicaciones_Subtotal.MaxValue = New Decimal(New Integer() {999999999, 0, 0, 131072})
        Me.currencytextboxAplicaciones_Subtotal.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.currencytextboxAplicaciones_Subtotal.MinValue = New Decimal(New Integer() {999999999, 0, 0, -2147352576})
        Me.currencytextboxAplicaciones_Subtotal.Name = "currencytextboxAplicaciones_Subtotal"
        Me.currencytextboxAplicaciones_Subtotal.NullString = ""
        Me.currencytextboxAplicaciones_Subtotal.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.currencytextboxAplicaciones_Subtotal.ReadOnly = True
        Me.currencytextboxAplicaciones_Subtotal.Size = New System.Drawing.Size(80, 20)
        Me.currencytextboxAplicaciones_Subtotal.TabIndex = 2
        Me.currencytextboxAplicaciones_Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labelAplicaciones_Subtotal
        '
        Me.labelAplicaciones_Subtotal.AutoSize = True
        Me.labelAplicaciones_Subtotal.Location = New System.Drawing.Point(3, 7)
        Me.labelAplicaciones_Subtotal.Name = "labelAplicaciones_Subtotal"
        Me.labelAplicaciones_Subtotal.Size = New System.Drawing.Size(70, 13)
        Me.labelAplicaciones_Subtotal.TabIndex = 0
        Me.labelAplicaciones_Subtotal.Text = "Aplicaciones:"
        '
        'panelDetalle_Subtotal
        '
        Me.panelDetalle_Subtotal.AutoSize = True
        Me.panelDetalle_Subtotal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelDetalle_Subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDetalle_Subtotal.Controls.Add(Me.currencytextboxDetalle_Subtotal)
        Me.panelDetalle_Subtotal.Controls.Add(Me.labelDetalle_Subtotal)
        Me.panelDetalle_Subtotal.Location = New System.Drawing.Point(168, 7)
        Me.panelDetalle_Subtotal.Name = "panelDetalle_Subtotal"
        Me.panelDetalle_Subtotal.Size = New System.Drawing.Size(137, 29)
        Me.panelDetalle_Subtotal.TabIndex = 4
        '
        'currencytextboxDetalle_Subtotal
        '
        Me.currencytextboxDetalle_Subtotal.AllowNull = True
        Me.currencytextboxDetalle_Subtotal.BeforeTouchSize = New System.Drawing.Size(80, 20)
        Me.currencytextboxDetalle_Subtotal.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxDetalle_Subtotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.currencytextboxDetalle_Subtotal.Location = New System.Drawing.Point(52, 4)
        Me.currencytextboxDetalle_Subtotal.MaxValue = New Decimal(New Integer() {999999999, 0, 0, 131072})
        Me.currencytextboxDetalle_Subtotal.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.currencytextboxDetalle_Subtotal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxDetalle_Subtotal.Name = "currencytextboxDetalle_Subtotal"
        Me.currencytextboxDetalle_Subtotal.NullString = ""
        Me.currencytextboxDetalle_Subtotal.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.currencytextboxDetalle_Subtotal.ReadOnly = True
        Me.currencytextboxDetalle_Subtotal.Size = New System.Drawing.Size(80, 20)
        Me.currencytextboxDetalle_Subtotal.TabIndex = 1
        Me.currencytextboxDetalle_Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labelDetalle_Subtotal
        '
        Me.labelDetalle_Subtotal.AutoSize = True
        Me.labelDetalle_Subtotal.Location = New System.Drawing.Point(3, 7)
        Me.labelDetalle_Subtotal.Name = "labelDetalle_Subtotal"
        Me.labelDetalle_Subtotal.Size = New System.Drawing.Size(43, 13)
        Me.labelDetalle_Subtotal.TabIndex = 0
        Me.labelDetalle_Subtotal.Text = "Detalle:"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar, Me.buttonAFIP})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(852, 39)
        Me.toolstripMain.TabIndex = 0
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
        'buttonAFIP
        '
        Me.buttonAFIP.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonAFIP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonAFIP.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemAFIP_ObtenerCAE, Me.menuitemAFIP_ObtenerQR, Me.menuitemAFIP_VerificarDatos})
        Me.buttonAFIP.Image = Global.CSBomberos.My.Resources.Resources.ImageAfipChico
        Me.buttonAFIP.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAFIP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAFIP.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.buttonAFIP.Name = "buttonAFIP"
        Me.buttonAFIP.Size = New System.Drawing.Size(61, 36)
        Me.buttonAFIP.Text = "AFIP"
        '
        'menuitemAFIP_ObtenerCAE
        '
        Me.menuitemAFIP_ObtenerCAE.Name = "menuitemAFIP_ObtenerCAE"
        Me.menuitemAFIP_ObtenerCAE.Size = New System.Drawing.Size(178, 22)
        Me.menuitemAFIP_ObtenerCAE.Text = "Obtener CAE"
        '
        'menuitemAFIP_ObtenerQR
        '
        Me.menuitemAFIP_ObtenerQR.Name = "menuitemAFIP_ObtenerQR"
        Me.menuitemAFIP_ObtenerQR.Size = New System.Drawing.Size(178, 22)
        Me.menuitemAFIP_ObtenerQR.Text = "Obtener Código QR"
        '
        'menuitemAFIP_VerificarDatos
        '
        Me.menuitemAFIP_VerificarDatos.Name = "menuitemAFIP_VerificarDatos"
        Me.menuitemAFIP_VerificarDatos.Size = New System.Drawing.Size(178, 22)
        Me.menuitemAFIP_VerificarDatos.Text = "Verificar datos"
        '
        'formComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 462)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(690, 45)
        Me.Name = "formComprobante"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle del comprobante"
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageDescripcion.ResumeLayout(False)
        Me.tabpageDescripcion.PerformLayout()
        Me.tabpageDetalle.ResumeLayout(False)
        Me.tabpageDetalle.PerformLayout()
        CType(Me.datagridviewDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripDetalle.ResumeLayout(False)
        Me.toolstripDetalle.PerformLayout()
        Me.tabpageAplicaciones.ResumeLayout(False)
        Me.tabpageAplicaciones.PerformLayout()
        CType(Me.datagridviewAplicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripAplicaciones.ResumeLayout(False)
        Me.toolstripAplicaciones.PerformLayout()
        Me.tabpageMediosPago.ResumeLayout(False)
        Me.tabpageMediosPago.PerformLayout()
        CType(Me.datagridviewMediosPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripMediosPago.ResumeLayout(False)
        Me.toolstripMediosPago.PerformLayout()
        Me.tabpageNotasAuditoria.ResumeLayout(False)
        Me.tabpageNotasAuditoria.PerformLayout()
        Me.panelCabecera.ResumeLayout(False)
        Me.panelIdentificacion.ResumeLayout(False)
        Me.panelIdentificacion.PerformLayout()
        Me.panelFechas.ResumeLayout(False)
        Me.panelFechas.PerformLayout()
        Me.panelEntidad.ResumeLayout(False)
        Me.panelEntidad.PerformLayout()
        Me.panelDatoGasto.ResumeLayout(False)
        Me.panelDatoGasto.PerformLayout()
        Me.panelPie.ResumeLayout(False)
        Me.panelPie.PerformLayout()
        Me.panelImporteTotal.ResumeLayout(False)
        Me.panelImporteTotal.PerformLayout()
        CType(Me.currencytextboxImporteTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMediosPago_Subtotal.ResumeLayout(False)
        Me.panelMediosPago_Subtotal.PerformLayout()
        CType(Me.currencytextboxMediosPago_Subtotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAplicaciones_Subtotal.ResumeLayout(False)
        Me.panelAplicaciones_Subtotal.PerformLayout()
        CType(Me.currencytextboxAplicaciones_Subtotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDetalle_Subtotal.ResumeLayout(False)
        Me.panelDetalle_Subtotal.PerformLayout()
        CType(Me.currencytextboxDetalle_Subtotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panelCabecera As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents panelIdentificacion As System.Windows.Forms.Panel
    Friend WithEvents panelPie As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents panelImporteTotal As System.Windows.Forms.Panel
    Friend WithEvents labelImporteTotal As System.Windows.Forms.Label
    Friend WithEvents labelComprobanteNumero As System.Windows.Forms.Label
    Friend WithEvents datetimepickerFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelFechaEmision As System.Windows.Forms.Label
    Friend WithEvents textboxIDComprobante As System.Windows.Forms.TextBox
    Friend WithEvents labelIDComprobante As System.Windows.Forms.Label
    Friend WithEvents panelEntidad As System.Windows.Forms.Panel
    Friend WithEvents labelEntidad As System.Windows.Forms.Label
    Friend WithEvents labelComprobanteTipo As System.Windows.Forms.Label
    Friend WithEvents comboboxComprobanteTipo As System.Windows.Forms.ComboBox
    Friend WithEvents labelPuntoVenta As System.Windows.Forms.Label
    Friend WithEvents panelFechas As System.Windows.Forms.Panel
    Friend WithEvents datetimepickerFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelFechaVencimiento As System.Windows.Forms.Label
    Friend WithEvents datetimepickerFechaServicioHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents datetimepickerFechaServicioDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents datagridviewDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents toolstripDetalle As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonDetalle_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonDetalle_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents datagridviewMediosPago As System.Windows.Forms.DataGridView
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents tabcontrolMain As System.Windows.Forms.TabControl
    Friend WithEvents tabpageDetalle As System.Windows.Forms.TabPage
    Friend WithEvents tabpageAplicaciones As System.Windows.Forms.TabPage
    Friend WithEvents tabpageMediosPago As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents toolstripAplicaciones As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonAplicaciones_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonAplicaciones_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents datagridviewAplicaciones As System.Windows.Forms.DataGridView
    Friend WithEvents toolstripMediosPago As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonMediosPago_AgregarOtro As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonMediosPago_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonMediosPago_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonMediosPago_AgregarCheque As System.Windows.Forms.ToolStripButton
    Friend WithEvents textboxFechaHoraEnvioEmail As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioEnvioEmail As System.Windows.Forms.TextBox
    Friend WithEvents buttonAplicaciones_AplicarTodo As System.Windows.Forms.ToolStripButton
    Friend WithEvents panelDetalle_Subtotal As System.Windows.Forms.Panel
    Friend WithEvents labelDetalle_Subtotal As System.Windows.Forms.Label
    Friend WithEvents panelAplicaciones_Subtotal As System.Windows.Forms.Panel
    Friend WithEvents labelAplicaciones_Subtotal As System.Windows.Forms.Label
    Friend WithEvents panelMediosPago_Subtotal As System.Windows.Forms.Panel
    Friend WithEvents labelMediosPago_Subtotal As System.Windows.Forms.Label
    Friend WithEvents buttonDetalle_Agregar As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents buttonDetalle_AgregarMultiple As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents buttonAFIP As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menuitemAFIP_ObtenerCAE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemAFIP_VerificarDatos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents currencytextboxDetalle_Subtotal As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents currencytextboxAplicaciones_Subtotal As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents currencytextboxMediosPago_Subtotal As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents currencytextboxImporteTotal As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents menuitemAFIP_ObtenerQR As ToolStripMenuItem
    Friend WithEvents columnDetalle_Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents columnDetalle_PrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents columnDetalle_PrecioTotal As DataGridViewTextBoxColumn
    Friend WithEvents MaskedTextBoxNumero As MaskedTextBox
    Friend WithEvents MaskedTextBoxPuntoVenta As MaskedTextBox
    Friend WithEvents comboboxEntidad As ComboBox
    Friend WithEvents tabpageDescripcion As TabPage
    Friend WithEvents textboxDescripcion As TextBox
    Friend WithEvents columnAplicaciones_Tipo As DataGridViewTextBoxColumn
    Friend WithEvents columnAplicaciones_NumeroCompleto As DataGridViewTextBoxColumn
    Friend WithEvents columnAplicaciones_Fecha As DataGridViewTextBoxColumn
    Friend WithEvents columnAplicaciones_ImporteTotal As DataGridViewTextBoxColumn
    Friend WithEvents columnAplicaciones_ImporteAplicado As DataGridViewTextBoxColumn
    Friend WithEvents columnMedioPagos_MedioPagoNombre As DataGridViewTextBoxColumn
    Friend WithEvents columnMedioPagos_Importe As DataGridViewTextBoxColumn
    Friend WithEvents columnMedioPagos_BancoNombre As DataGridViewTextBoxColumn
    Friend WithEvents columnMedioPagos_Numero As DataGridViewTextBoxColumn
    Friend WithEvents columnMedioPagos_FechaVencimiento As DataGridViewTextBoxColumn
    Friend WithEvents panelDatoGasto As Panel
    Friend WithEvents checkboxEsBienUso As CheckBox
    Friend WithEvents comboboxArea As ComboBox
End Class
