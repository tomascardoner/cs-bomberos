﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSiniestros
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSiniestros))
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.columnCuartel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnSiniestroRubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnSiniestroTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnClave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCerrado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnControlado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.panelToolbars = New System.Windows.Forms.FlowLayoutPanel()
        Me.toolstripButtons = New System.Windows.Forms.ToolStrip()
        Me.buttonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAsistenciaPresencial = New System.Windows.Forms.ToolStripSplitButton()
        Me.menuitemAsistenciaPresencialIndividual = New System.Windows.Forms.ToolStripMenuItem()
        Me.buttonAsistenciaManual = New System.Windows.Forms.ToolStripButton()
        Me.toolstripCuartel = New System.Windows.Forms.ToolStrip()
        Me.labelCuartel = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxCuartel = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripSiniestroRubro = New System.Windows.Forms.ToolStrip()
        Me.labelSiniestroRubro = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxSiniestroRubro = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripSiniestroTipo = New System.Windows.Forms.ToolStrip()
        Me.labelSiniestroTipo = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxSiniestroTipo = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripClave = New System.Windows.Forms.ToolStrip()
        Me.labelClave = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxClave = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripPeriodo = New System.Windows.Forms.ToolStrip()
        Me.labelPeriodo = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxPeriodoTipo = New System.Windows.Forms.ToolStripComboBox()
        Me.comboboxPeriodoValor = New System.Windows.Forms.ToolStripComboBox()
        Me.labelPeriodoFechaY = New System.Windows.Forms.ToolStripLabel()
        Me.toolstripCerrado = New System.Windows.Forms.ToolStrip()
        Me.labelCerrado = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxCerrado = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripControlado = New System.Windows.Forms.ToolStrip()
        Me.LabelControlado = New System.Windows.Forms.ToolStripLabel()
        Me.ComboBoxControlado = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripAnulado = New System.Windows.Forms.ToolStrip()
        Me.labelAnulado = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxAnulado = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButtonNuevaVersion = New System.Windows.Forms.ToolStripButton()
        Me.statusstripMain.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelToolbars.SuspendLayout()
        Me.toolstripButtons.SuspendLayout()
        Me.toolstripCuartel.SuspendLayout()
        Me.toolstripSiniestroRubro.SuspendLayout()
        Me.toolstripSiniestroTipo.SuspendLayout()
        Me.toolstripClave.SuspendLayout()
        Me.toolstripPeriodo.SuspendLayout()
        Me.toolstripCerrado.SuspendLayout()
        Me.ToolStripControlado.SuspendLayout()
        Me.toolstripAnulado.SuspendLayout()
        Me.SuspendLayout()
        '
        'statuslabelMain
        '
        Me.statuslabelMain.Name = "statuslabelMain"
        Me.statuslabelMain.Size = New System.Drawing.Size(1168, 16)
        Me.statuslabelMain.Spring = True
        Me.statuslabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'statusstripMain
        '
        Me.statusstripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabelMain})
        Me.statusstripMain.Location = New System.Drawing.Point(0, 484)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.statusstripMain.Size = New System.Drawing.Size(1188, 22)
        Me.statusstripMain.SizingGrip = False
        Me.statusstripMain.TabIndex = 4
        '
        'datagridviewMain
        '
        Me.datagridviewMain.AllowUserToAddRows = False
        Me.datagridviewMain.AllowUserToDeleteRows = False
        Me.datagridviewMain.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagridviewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnCuartel, Me.columnNumero, Me.columnFecha, Me.columnSiniestroRubro, Me.columnSiniestroTipo, Me.columnClave, Me.columnCerrado, Me.ColumnControlado})
        Me.datagridviewMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewMain.Location = New System.Drawing.Point(0, 95)
        Me.datagridviewMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datagridviewMain.MultiSelect = False
        Me.datagridviewMain.Name = "datagridviewMain"
        Me.datagridviewMain.ReadOnly = True
        Me.datagridviewMain.RowHeadersVisible = False
        Me.datagridviewMain.RowHeadersWidth = 51
        Me.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewMain.Size = New System.Drawing.Size(1188, 389)
        Me.datagridviewMain.TabIndex = 0
        '
        'columnCuartel
        '
        Me.columnCuartel.DataPropertyName = "CuartelNombre"
        Me.columnCuartel.HeaderText = "Cuartel"
        Me.columnCuartel.MinimumWidth = 6
        Me.columnCuartel.Name = "columnCuartel"
        Me.columnCuartel.ReadOnly = True
        Me.columnCuartel.Width = 78
        '
        'columnNumero
        '
        Me.columnNumero.DataPropertyName = "NumeroCompleto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.columnNumero.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnNumero.HeaderText = "Número"
        Me.columnNumero.MinimumWidth = 6
        Me.columnNumero.Name = "columnNumero"
        Me.columnNumero.ReadOnly = True
        Me.columnNumero.Width = 84
        '
        'columnFecha
        '
        Me.columnFecha.DataPropertyName = "Fecha"
        Me.columnFecha.HeaderText = "Fecha"
        Me.columnFecha.MinimumWidth = 6
        Me.columnFecha.Name = "columnFecha"
        Me.columnFecha.ReadOnly = True
        Me.columnFecha.Width = 74
        '
        'columnSiniestroRubro
        '
        Me.columnSiniestroRubro.DataPropertyName = "SiniestroRubroNombre"
        Me.columnSiniestroRubro.HeaderText = "Rubro"
        Me.columnSiniestroRubro.MinimumWidth = 6
        Me.columnSiniestroRubro.Name = "columnSiniestroRubro"
        Me.columnSiniestroRubro.ReadOnly = True
        Me.columnSiniestroRubro.Width = 73
        '
        'columnSiniestroTipo
        '
        Me.columnSiniestroTipo.DataPropertyName = "SiniestroTipoNombre"
        Me.columnSiniestroTipo.HeaderText = "Tipo"
        Me.columnSiniestroTipo.MinimumWidth = 6
        Me.columnSiniestroTipo.Name = "columnSiniestroTipo"
        Me.columnSiniestroTipo.ReadOnly = True
        Me.columnSiniestroTipo.Width = 64
        '
        'columnClave
        '
        Me.columnClave.DataPropertyName = "ClaveNombre"
        Me.columnClave.HeaderText = "Clave"
        Me.columnClave.MinimumWidth = 6
        Me.columnClave.Name = "columnClave"
        Me.columnClave.ReadOnly = True
        Me.columnClave.Width = 71
        '
        'columnCerrado
        '
        Me.columnCerrado.DataPropertyName = "Cerrado"
        Me.columnCerrado.HeaderText = "Cerrado"
        Me.columnCerrado.MinimumWidth = 6
        Me.columnCerrado.Name = "columnCerrado"
        Me.columnCerrado.ReadOnly = True
        Me.columnCerrado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.columnCerrado.Width = 85
        '
        'ColumnControlado
        '
        Me.ColumnControlado.DataPropertyName = "Controlado"
        Me.ColumnControlado.HeaderText = "Controlado"
        Me.ColumnControlado.MinimumWidth = 6
        Me.ColumnControlado.Name = "ColumnControlado"
        Me.ColumnControlado.ReadOnly = True
        Me.ColumnControlado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnControlado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColumnControlado.Width = 102
        '
        'panelToolbars
        '
        Me.panelToolbars.AutoSize = True
        Me.panelToolbars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelToolbars.Controls.Add(Me.toolstripButtons)
        Me.panelToolbars.Controls.Add(Me.toolstripCuartel)
        Me.panelToolbars.Controls.Add(Me.toolstripSiniestroRubro)
        Me.panelToolbars.Controls.Add(Me.toolstripSiniestroTipo)
        Me.panelToolbars.Controls.Add(Me.toolstripClave)
        Me.panelToolbars.Controls.Add(Me.toolstripPeriodo)
        Me.panelToolbars.Controls.Add(Me.toolstripCerrado)
        Me.panelToolbars.Controls.Add(Me.ToolStripControlado)
        Me.panelToolbars.Controls.Add(Me.toolstripAnulado)
        Me.panelToolbars.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelToolbars.Location = New System.Drawing.Point(0, 0)
        Me.panelToolbars.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelToolbars.Name = "panelToolbars"
        Me.panelToolbars.Size = New System.Drawing.Size(1188, 95)
        Me.panelToolbars.TabIndex = 0
        '
        'toolstripButtons
        '
        Me.toolstripButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripButtons.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripButtons.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAgregar, Me.buttonEditar, Me.buttonEliminar, Me.buttonAsistenciaPresencial, Me.buttonAsistenciaManual, Me.ToolStripButtonNuevaVersion})
        Me.toolstripButtons.Location = New System.Drawing.Point(0, 0)
        Me.toolstripButtons.Name = "toolstripButtons"
        Me.toolstripButtons.Size = New System.Drawing.Size(791, 39)
        Me.toolstripButtons.TabIndex = 1
        '
        'buttonAgregar
        '
        Me.buttonAgregar.Image = Global.CSBomberos.My.Resources.Resources.ImageAgregar32
        Me.buttonAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAgregar.Name = "buttonAgregar"
        Me.buttonAgregar.Size = New System.Drawing.Size(99, 36)
        Me.buttonAgregar.Text = "Agregar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Image = Global.CSBomberos.My.Resources.Resources.ImageEditar32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(84, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Image = Global.CSBomberos.My.Resources.Resources.ImageBorrar32
        Me.buttonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(99, 36)
        Me.buttonEliminar.Text = "Eliminar"
        '
        'buttonAsistenciaPresencial
        '
        Me.buttonAsistenciaPresencial.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemAsistenciaPresencialIndividual})
        Me.buttonAsistenciaPresencial.Image = Global.CSBomberos.My.Resources.Resources.ImageAsistenciaPresencial32
        Me.buttonAsistenciaPresencial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAsistenciaPresencial.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAsistenciaPresencial.Name = "buttonAsistenciaPresencial"
        Me.buttonAsistenciaPresencial.Size = New System.Drawing.Size(197, 36)
        Me.buttonAsistenciaPresencial.Text = "Asistencia presencial"
        '
        'menuitemAsistenciaPresencialIndividual
        '
        Me.menuitemAsistenciaPresencialIndividual.Name = "menuitemAsistenciaPresencialIndividual"
        Me.menuitemAsistenciaPresencialIndividual.Size = New System.Drawing.Size(256, 26)
        Me.menuitemAsistenciaPresencialIndividual.Text = "Al siniestro seleccionado"
        '
        'buttonAsistenciaManual
        '
        Me.buttonAsistenciaManual.Image = Global.CSBomberos.My.Resources.Resources.ImageAsistenciaManual32
        Me.buttonAsistenciaManual.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAsistenciaManual.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAsistenciaManual.Name = "buttonAsistenciaManual"
        Me.buttonAsistenciaManual.Size = New System.Drawing.Size(164, 36)
        Me.buttonAsistenciaManual.Text = "Asistencia manual"
        '
        'toolstripCuartel
        '
        Me.toolstripCuartel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripCuartel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripCuartel.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripCuartel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelCuartel, Me.comboboxCuartel})
        Me.toolstripCuartel.Location = New System.Drawing.Point(791, 0)
        Me.toolstripCuartel.Name = "toolstripCuartel"
        Me.toolstripCuartel.Size = New System.Drawing.Size(236, 39)
        Me.toolstripCuartel.TabIndex = 13
        '
        'labelCuartel
        '
        Me.labelCuartel.Name = "labelCuartel"
        Me.labelCuartel.Size = New System.Drawing.Size(59, 36)
        Me.labelCuartel.Text = "Cuartel:"
        '
        'comboboxCuartel
        '
        Me.comboboxCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCuartel.Name = "comboboxCuartel"
        Me.comboboxCuartel.Size = New System.Drawing.Size(172, 39)
        '
        'toolstripSiniestroRubro
        '
        Me.toolstripSiniestroRubro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripSiniestroRubro.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripSiniestroRubro.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripSiniestroRubro.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelSiniestroRubro, Me.comboboxSiniestroRubro})
        Me.toolstripSiniestroRubro.Location = New System.Drawing.Point(0, 39)
        Me.toolstripSiniestroRubro.Name = "toolstripSiniestroRubro"
        Me.toolstripSiniestroRubro.Size = New System.Drawing.Size(296, 28)
        Me.toolstripSiniestroRubro.TabIndex = 14
        '
        'labelSiniestroRubro
        '
        Me.labelSiniestroRubro.Name = "labelSiniestroRubro"
        Me.labelSiniestroRubro.Size = New System.Drawing.Size(52, 25)
        Me.labelSiniestroRubro.Text = "Rubro:"
        '
        'comboboxSiniestroRubro
        '
        Me.comboboxSiniestroRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxSiniestroRubro.Name = "comboboxSiniestroRubro"
        Me.comboboxSiniestroRubro.Size = New System.Drawing.Size(239, 28)
        '
        'toolstripSiniestroTipo
        '
        Me.toolstripSiniestroTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripSiniestroTipo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripSiniestroTipo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripSiniestroTipo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelSiniestroTipo, Me.comboboxSiniestroTipo})
        Me.toolstripSiniestroTipo.Location = New System.Drawing.Point(296, 39)
        Me.toolstripSiniestroTipo.Name = "toolstripSiniestroTipo"
        Me.toolstripSiniestroTipo.Size = New System.Drawing.Size(286, 28)
        Me.toolstripSiniestroTipo.TabIndex = 15
        '
        'labelSiniestroTipo
        '
        Me.labelSiniestroTipo.Name = "labelSiniestroTipo"
        Me.labelSiniestroTipo.Size = New System.Drawing.Size(42, 25)
        Me.labelSiniestroTipo.Text = "Tipo:"
        '
        'comboboxSiniestroTipo
        '
        Me.comboboxSiniestroTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxSiniestroTipo.Name = "comboboxSiniestroTipo"
        Me.comboboxSiniestroTipo.Size = New System.Drawing.Size(239, 28)
        '
        'toolstripClave
        '
        Me.toolstripClave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripClave.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripClave.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripClave.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelClave, Me.comboboxClave})
        Me.toolstripClave.Location = New System.Drawing.Point(582, 39)
        Me.toolstripClave.Name = "toolstripClave"
        Me.toolstripClave.Size = New System.Drawing.Size(318, 28)
        Me.toolstripClave.TabIndex = 16
        '
        'labelClave
        '
        Me.labelClave.Name = "labelClave"
        Me.labelClave.Size = New System.Drawing.Size(48, 25)
        Me.labelClave.Text = "Clave:"
        '
        'comboboxClave
        '
        Me.comboboxClave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxClave.DropDownWidth = 75
        Me.comboboxClave.Name = "comboboxClave"
        Me.comboboxClave.Size = New System.Drawing.Size(265, 28)
        '
        'toolstripPeriodo
        '
        Me.toolstripPeriodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripPeriodo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripPeriodo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripPeriodo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelPeriodo, Me.comboboxPeriodoTipo, Me.comboboxPeriodoValor, Me.labelPeriodoFechaY})
        Me.toolstripPeriodo.Location = New System.Drawing.Point(0, 67)
        Me.toolstripPeriodo.Name = "toolstripPeriodo"
        Me.toolstripPeriodo.Size = New System.Drawing.Size(345, 28)
        Me.toolstripPeriodo.TabIndex = 17
        '
        'labelPeriodo
        '
        Me.labelPeriodo.Name = "labelPeriodo"
        Me.labelPeriodo.Size = New System.Drawing.Size(63, 25)
        Me.labelPeriodo.Text = "Período:"
        '
        'comboboxPeriodoTipo
        '
        Me.comboboxPeriodoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxPeriodoTipo.Name = "comboboxPeriodoTipo"
        Me.comboboxPeriodoTipo.Size = New System.Drawing.Size(99, 28)
        '
        'comboboxPeriodoValor
        '
        Me.comboboxPeriodoValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxPeriodoValor.Name = "comboboxPeriodoValor"
        Me.comboboxPeriodoValor.Size = New System.Drawing.Size(160, 28)
        '
        'labelPeriodoFechaY
        '
        Me.labelPeriodoFechaY.Name = "labelPeriodoFechaY"
        Me.labelPeriodoFechaY.Size = New System.Drawing.Size(16, 25)
        Me.labelPeriodoFechaY.Text = "y"
        '
        'toolstripCerrado
        '
        Me.toolstripCerrado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripCerrado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripCerrado.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripCerrado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelCerrado, Me.comboboxCerrado})
        Me.toolstripCerrado.Location = New System.Drawing.Point(345, 67)
        Me.toolstripCerrado.Name = "toolstripCerrado"
        Me.toolstripCerrado.Size = New System.Drawing.Size(169, 28)
        Me.toolstripCerrado.TabIndex = 18
        '
        'labelCerrado
        '
        Me.labelCerrado.Name = "labelCerrado"
        Me.labelCerrado.Size = New System.Drawing.Size(65, 25)
        Me.labelCerrado.Text = "Cerrado:"
        '
        'comboboxCerrado
        '
        Me.comboboxCerrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCerrado.Name = "comboboxCerrado"
        Me.comboboxCerrado.Size = New System.Drawing.Size(99, 28)
        '
        'ToolStripControlado
        '
        Me.ToolStripControlado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripControlado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripControlado.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripControlado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelControlado, Me.ComboBoxControlado})
        Me.ToolStripControlado.Location = New System.Drawing.Point(514, 67)
        Me.ToolStripControlado.Name = "ToolStripControlado"
        Me.ToolStripControlado.Size = New System.Drawing.Size(191, 28)
        Me.ToolStripControlado.TabIndex = 19
        '
        'LabelControlado
        '
        Me.LabelControlado.Name = "LabelControlado"
        Me.LabelControlado.Size = New System.Drawing.Size(87, 25)
        Me.LabelControlado.Text = "Controlado:"
        '
        'ComboBoxControlado
        '
        Me.ComboBoxControlado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxControlado.Name = "ComboBoxControlado"
        Me.ComboBoxControlado.Size = New System.Drawing.Size(99, 28)
        '
        'toolstripAnulado
        '
        Me.toolstripAnulado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripAnulado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripAnulado.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripAnulado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelAnulado, Me.comboboxAnulado})
        Me.toolstripAnulado.Location = New System.Drawing.Point(705, 67)
        Me.toolstripAnulado.Name = "toolstripAnulado"
        Me.toolstripAnulado.Size = New System.Drawing.Size(172, 28)
        Me.toolstripAnulado.TabIndex = 12
        '
        'labelAnulado
        '
        Me.labelAnulado.Name = "labelAnulado"
        Me.labelAnulado.Size = New System.Drawing.Size(68, 25)
        Me.labelAnulado.Text = "Anulado:"
        '
        'comboboxAnulado
        '
        Me.comboboxAnulado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxAnulado.Name = "comboboxAnulado"
        Me.comboboxAnulado.Size = New System.Drawing.Size(99, 28)
        '
        'ToolStripButtonNuevaVersion
        '
        Me.ToolStripButtonNuevaVersion.CheckOnClick = True
        Me.ToolStripButtonNuevaVersion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonNuevaVersion.Image = CType(resources.GetObject("ToolStripButtonNuevaVersion.Image"), System.Drawing.Image)
        Me.ToolStripButtonNuevaVersion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNuevaVersion.Name = "ToolStripButtonNuevaVersion"
        Me.ToolStripButtonNuevaVersion.Size = New System.Drawing.Size(106, 36)
        Me.ToolStripButtonNuevaVersion.Text = "Nueva versión"
        '
        'FormSiniestros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 506)
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.panelToolbars)
        Me.Controls.Add(Me.statusstripMain)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSiniestros"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Siniestros"
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelToolbars.ResumeLayout(False)
        Me.panelToolbars.PerformLayout()
        Me.toolstripButtons.ResumeLayout(False)
        Me.toolstripButtons.PerformLayout()
        Me.toolstripCuartel.ResumeLayout(False)
        Me.toolstripCuartel.PerformLayout()
        Me.toolstripSiniestroRubro.ResumeLayout(False)
        Me.toolstripSiniestroRubro.PerformLayout()
        Me.toolstripSiniestroTipo.ResumeLayout(False)
        Me.toolstripSiniestroTipo.PerformLayout()
        Me.toolstripClave.ResumeLayout(False)
        Me.toolstripClave.PerformLayout()
        Me.toolstripPeriodo.ResumeLayout(False)
        Me.toolstripPeriodo.PerformLayout()
        Me.toolstripCerrado.ResumeLayout(False)
        Me.toolstripCerrado.PerformLayout()
        Me.ToolStripControlado.ResumeLayout(False)
        Me.ToolStripControlado.PerformLayout()
        Me.toolstripAnulado.ResumeLayout(False)
        Me.toolstripAnulado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statuslabelMain As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusstripMain As System.Windows.Forms.StatusStrip
    Friend WithEvents datagridviewMain As System.Windows.Forms.DataGridView
    Friend WithEvents panelToolbars As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents toolstripButtons As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripAnulado As System.Windows.Forms.ToolStrip
    Friend WithEvents labelAnulado As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxAnulado As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripCuartel As System.Windows.Forms.ToolStrip
    Friend WithEvents labelCuartel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxCuartel As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripSiniestroRubro As System.Windows.Forms.ToolStrip
    Friend WithEvents labelSiniestroRubro As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxSiniestroRubro As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripSiniestroTipo As ToolStrip
    Friend WithEvents labelSiniestroTipo As ToolStripLabel
    Friend WithEvents comboboxSiniestroTipo As ToolStripComboBox
    Friend WithEvents toolstripClave As ToolStrip
    Friend WithEvents labelClave As ToolStripLabel
    Friend WithEvents comboboxClave As ToolStripComboBox
    Friend WithEvents toolstripPeriodo As ToolStrip
    Friend WithEvents labelPeriodo As ToolStripLabel
    Friend WithEvents comboboxPeriodoTipo As ToolStripComboBox
    Friend WithEvents comboboxPeriodoValor As ToolStripComboBox
    Friend WithEvents labelPeriodoFechaY As ToolStripLabel
    Friend WithEvents buttonAsistenciaManual As ToolStripButton
    Friend WithEvents toolstripCerrado As ToolStrip
    Friend WithEvents labelCerrado As ToolStripLabel
    Friend WithEvents comboboxCerrado As ToolStripComboBox
    Friend WithEvents buttonAsistenciaPresencial As ToolStripSplitButton
    Friend WithEvents menuitemAsistenciaPresencialIndividual As ToolStripMenuItem
    Friend WithEvents ToolStripControlado As ToolStrip
    Friend WithEvents LabelControlado As ToolStripLabel
    Friend WithEvents ComboBoxControlado As ToolStripComboBox
    Friend WithEvents columnCuartel As DataGridViewTextBoxColumn
    Friend WithEvents columnNumero As DataGridViewTextBoxColumn
    Friend WithEvents columnFecha As DataGridViewTextBoxColumn
    Friend WithEvents columnSiniestroRubro As DataGridViewTextBoxColumn
    Friend WithEvents columnSiniestroTipo As DataGridViewTextBoxColumn
    Friend WithEvents columnClave As DataGridViewTextBoxColumn
    Friend WithEvents columnCerrado As DataGridViewCheckBoxColumn
    Friend WithEvents ColumnControlado As DataGridViewCheckBoxColumn
    Friend WithEvents ToolStripButtonNuevaVersion As ToolStripButton
End Class
