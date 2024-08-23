<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formSiniestro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim labelHoraSalida As System.Windows.Forms.Label
        Dim labelCuartel As System.Windows.Forms.Label
        Dim labelHoraFin As System.Windows.Forms.Label
        Dim labelHoraLlegadaUltimoCamion As System.Windows.Forms.Label
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
        Me.comboboxSiniestroRubro = New System.Windows.Forms.ComboBox()
        Me.tabcontrolMain = New System.Windows.Forms.TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.buttonHoraFinFinalizar = New System.Windows.Forms.Button()
        Me.labelResumenAsistencias = New System.Windows.Forms.Label()
        Me.datagridviewResumenAsistencias = New System.Windows.Forms.DataGridView()
        Me.columnResumenAsistenciaTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnResumenCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetimepickerHoraLlegadaUltimoCamion = New System.Windows.Forms.DateTimePicker()
        Me.labelNumeroSeparador = New System.Windows.Forms.Label()
        Me.maskedtextboxNumero = New System.Windows.Forms.MaskedTextBox()
        Me.maskedtextboxNumeroPrefijo = New System.Windows.Forms.MaskedTextBox()
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
        Me.textboxPersonaFin = New System.Windows.Forms.TextBox()
        Me.tabpageAsistencias = New System.Windows.Forms.TabPage()
        Me.datagridviewAsistencias = New System.Windows.Forms.DataGridView()
        Me.columnPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnSiniestroAsistenciaTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstripAsistencias = New System.Windows.Forms.ToolStrip()
        Me.buttonAsistenciasAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAsistenciasEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAsistenciasEliminar = New System.Windows.Forms.ToolStripButton()
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
        Me.CheckBoxControlado = New System.Windows.Forms.CheckBox()
        Me.LabelControlado = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelHoraSalida = New System.Windows.Forms.Label()
        labelCuartel = New System.Windows.Forms.Label()
        labelHoraFin = New System.Windows.Forms.Label()
        labelHoraLlegadaUltimoCamion = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        CType(Me.datagridviewResumenAsistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpageAsistencias.SuspendLayout()
        CType(Me.datagridviewAsistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusstripMain.SuspendLayout()
        Me.toolstripAsistencias.SuspendLayout()
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
        labelHoraSalida.TabIndex = 17
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
        labelHoraFin.Location = New System.Drawing.Point(6, 257)
        labelHoraFin.Name = "labelHoraFin"
        labelHoraFin.Size = New System.Drawing.Size(62, 13)
        labelHoraFin.TabIndex = 21
        labelHoraFin.Text = "Hora de fin:"
        '
        'labelHoraLlegadaUltimoCamion
        '
        labelHoraLlegadaUltimoCamion.AutoSize = True
        labelHoraLlegadaUltimoCamion.Location = New System.Drawing.Point(6, 231)
        labelHoraLlegadaUltimoCamion.Name = "labelHoraLlegadaUltimoCamion"
        labelHoraLlegadaUltimoCamion.Size = New System.Drawing.Size(167, 13)
        labelHoraLlegadaUltimoCamion.TabIndex = 19
        labelHoraLlegadaUltimoCamion.Text = "Hora de llegada de último camión:"
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
        Me.labelFecha.TabIndex = 7
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
        Me.toolstripMain.Size = New System.Drawing.Size(734, 39)
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
        'comboboxSiniestroRubro
        '
        Me.comboboxSiniestroRubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboboxSiniestroRubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxSiniestroRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxSiniestroRubro.FormattingEnabled = True
        Me.comboboxSiniestroRubro.Location = New System.Drawing.Point(184, 94)
        Me.comboboxSiniestroRubro.Name = "comboboxSiniestroRubro"
        Me.comboboxSiniestroRubro.Size = New System.Drawing.Size(267, 21)
        Me.comboboxSiniestroRubro.TabIndex = 10
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageAsistencias)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(714, 355)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.CheckBoxControlado)
        Me.tabpageGeneral.Controls.Add(Me.LabelControlado)
        Me.tabpageGeneral.Controls.Add(Me.buttonHoraFinFinalizar)
        Me.tabpageGeneral.Controls.Add(Me.labelResumenAsistencias)
        Me.tabpageGeneral.Controls.Add(Me.datagridviewResumenAsistencias)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerHoraLlegadaUltimoCamion)
        Me.tabpageGeneral.Controls.Add(labelHoraLlegadaUltimoCamion)
        Me.tabpageGeneral.Controls.Add(Me.labelNumeroSeparador)
        Me.tabpageGeneral.Controls.Add(Me.maskedtextboxNumero)
        Me.tabpageGeneral.Controls.Add(Me.maskedtextboxNumeroPrefijo)
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
        Me.tabpageGeneral.Controls.Add(Me.comboboxSiniestroRubro)
        Me.tabpageGeneral.Controls.Add(Me.labelNumero)
        Me.tabpageGeneral.Controls.Add(Me.labelFecha)
        Me.tabpageGeneral.Controls.Add(Me.textboxPersonaFin)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(706, 326)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'buttonHoraFinFinalizar
        '
        Me.buttonHoraFinFinalizar.Location = New System.Drawing.Point(184, 253)
        Me.buttonHoraFinFinalizar.Name = "buttonHoraFinFinalizar"
        Me.buttonHoraFinFinalizar.Size = New System.Drawing.Size(86, 22)
        Me.buttonHoraFinFinalizar.TabIndex = 22
        Me.buttonHoraFinFinalizar.Text = "Finalizar"
        Me.buttonHoraFinFinalizar.UseVisualStyleBackColor = True
        '
        'labelResumenAsistencias
        '
        Me.labelResumenAsistencias.AutoSize = True
        Me.labelResumenAsistencias.Location = New System.Drawing.Point(457, 76)
        Me.labelResumenAsistencias.Name = "labelResumenAsistencias"
        Me.labelResumenAsistencias.Size = New System.Drawing.Size(125, 13)
        Me.labelResumenAsistencias.TabIndex = 27
        Me.labelResumenAsistencias.Text = "Resumen de asistencias:"
        '
        'datagridviewResumenAsistencias
        '
        Me.datagridviewResumenAsistencias.AllowUserToAddRows = False
        Me.datagridviewResumenAsistencias.AllowUserToDeleteRows = False
        Me.datagridviewResumenAsistencias.AllowUserToResizeColumns = False
        Me.datagridviewResumenAsistencias.AllowUserToResizeRows = False
        Me.datagridviewResumenAsistencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagridviewResumenAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewResumenAsistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnResumenAsistenciaTipo, Me.columnResumenCantidad})
        Me.datagridviewResumenAsistencias.Location = New System.Drawing.Point(457, 94)
        Me.datagridviewResumenAsistencias.MultiSelect = False
        Me.datagridviewResumenAsistencias.Name = "datagridviewResumenAsistencias"
        Me.datagridviewResumenAsistencias.ReadOnly = True
        Me.datagridviewResumenAsistencias.RowHeadersVisible = False
        Me.datagridviewResumenAsistencias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewResumenAsistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewResumenAsistencias.ShowEditingIcon = False
        Me.datagridviewResumenAsistencias.Size = New System.Drawing.Size(248, 232)
        Me.datagridviewResumenAsistencias.TabIndex = 28
        '
        'columnResumenAsistenciaTipo
        '
        Me.columnResumenAsistenciaTipo.DataPropertyName = "AsistenciaTipoNombre"
        Me.columnResumenAsistenciaTipo.HeaderText = "Tipo de asistencia"
        Me.columnResumenAsistenciaTipo.Name = "columnResumenAsistenciaTipo"
        Me.columnResumenAsistenciaTipo.ReadOnly = True
        Me.columnResumenAsistenciaTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnResumenAsistenciaTipo.Width = 89
        '
        'columnResumenCantidad
        '
        Me.columnResumenCantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.columnResumenCantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.columnResumenCantidad.HeaderText = "Cantidad"
        Me.columnResumenCantidad.Name = "columnResumenCantidad"
        Me.columnResumenCantidad.ReadOnly = True
        Me.columnResumenCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnResumenCantidad.Width = 55
        '
        'datetimepickerHoraLlegadaUltimoCamion
        '
        Me.datetimepickerHoraLlegadaUltimoCamion.CustomFormat = "HH:mm"
        Me.datetimepickerHoraLlegadaUltimoCamion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickerHoraLlegadaUltimoCamion.Location = New System.Drawing.Point(184, 228)
        Me.datetimepickerHoraLlegadaUltimoCamion.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerHoraLlegadaUltimoCamion.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerHoraLlegadaUltimoCamion.Name = "datetimepickerHoraLlegadaUltimoCamion"
        Me.datetimepickerHoraLlegadaUltimoCamion.ShowCheckBox = True
        Me.datetimepickerHoraLlegadaUltimoCamion.Size = New System.Drawing.Size(86, 20)
        Me.datetimepickerHoraLlegadaUltimoCamion.TabIndex = 20
        '
        'labelNumeroSeparador
        '
        Me.labelNumeroSeparador.AutoSize = True
        Me.labelNumeroSeparador.Location = New System.Drawing.Point(228, 47)
        Me.labelNumeroSeparador.Name = "labelNumeroSeparador"
        Me.labelNumeroSeparador.Size = New System.Drawing.Size(10, 13)
        Me.labelNumeroSeparador.TabIndex = 4
        Me.labelNumeroSeparador.Text = "-"
        '
        'maskedtextboxNumero
        '
        Me.maskedtextboxNumero.HidePromptOnLeave = True
        Me.maskedtextboxNumero.Location = New System.Drawing.Point(239, 42)
        Me.maskedtextboxNumero.Mask = "00000000"
        Me.maskedtextboxNumero.Name = "maskedtextboxNumero"
        Me.maskedtextboxNumero.Size = New System.Drawing.Size(71, 20)
        Me.maskedtextboxNumero.TabIndex = 5
        Me.maskedtextboxNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'maskedtextboxNumeroPrefijo
        '
        Me.maskedtextboxNumeroPrefijo.HidePromptOnLeave = True
        Me.maskedtextboxNumeroPrefijo.Location = New System.Drawing.Point(184, 42)
        Me.maskedtextboxNumeroPrefijo.Mask = "0000"
        Me.maskedtextboxNumeroPrefijo.Name = "maskedtextboxNumeroPrefijo"
        Me.maskedtextboxNumeroPrefijo.Size = New System.Drawing.Size(41, 20)
        Me.maskedtextboxNumeroPrefijo.TabIndex = 3
        Me.maskedtextboxNumeroPrefijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'datetimepickerHoraFin
        '
        Me.datetimepickerHoraFin.CustomFormat = "HH:mm"
        Me.datetimepickerHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickerHoraFin.Location = New System.Drawing.Point(184, 254)
        Me.datetimepickerHoraFin.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerHoraFin.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerHoraFin.Name = "datetimepickerHoraFin"
        Me.datetimepickerHoraFin.ShowCheckBox = True
        Me.datetimepickerHoraFin.Size = New System.Drawing.Size(86, 20)
        Me.datetimepickerHoraFin.TabIndex = 23
        '
        'labelClave
        '
        Me.labelClave.AutoSize = True
        Me.labelClave.Location = New System.Drawing.Point(6, 177)
        Me.labelClave.Name = "labelClave"
        Me.labelClave.Size = New System.Drawing.Size(37, 13)
        Me.labelClave.TabIndex = 15
        Me.labelClave.Text = "Clave:"
        '
        'comboboxClave
        '
        Me.comboboxClave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboboxClave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxClave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxClave.FormattingEnabled = True
        Me.comboboxClave.Location = New System.Drawing.Point(184, 174)
        Me.comboboxClave.Name = "comboboxClave"
        Me.comboboxClave.Size = New System.Drawing.Size(267, 21)
        Me.comboboxClave.TabIndex = 16
        '
        'labelSiniestroTipoOtro
        '
        Me.labelSiniestroTipoOtro.AutoSize = True
        Me.labelSiniestroTipoOtro.Location = New System.Drawing.Point(6, 151)
        Me.labelSiniestroTipoOtro.Name = "labelSiniestroTipoOtro"
        Me.labelSiniestroTipoOtro.Size = New System.Drawing.Size(30, 13)
        Me.labelSiniestroTipoOtro.TabIndex = 13
        Me.labelSiniestroTipoOtro.Text = "Otro:"
        Me.labelSiniestroTipoOtro.Visible = False
        '
        'textboxSiniestroTipoOtro
        '
        Me.textboxSiniestroTipoOtro.Location = New System.Drawing.Point(184, 148)
        Me.textboxSiniestroTipoOtro.MaxLength = 50
        Me.textboxSiniestroTipoOtro.Name = "textboxSiniestroTipoOtro"
        Me.textboxSiniestroTipoOtro.Size = New System.Drawing.Size(267, 20)
        Me.textboxSiniestroTipoOtro.TabIndex = 14
        Me.textboxSiniestroTipoOtro.Visible = False
        '
        'labelSiniestroTipo
        '
        Me.labelSiniestroTipo.AutoSize = True
        Me.labelSiniestroTipo.Location = New System.Drawing.Point(6, 124)
        Me.labelSiniestroTipo.Name = "labelSiniestroTipo"
        Me.labelSiniestroTipo.Size = New System.Drawing.Size(31, 13)
        Me.labelSiniestroTipo.TabIndex = 11
        Me.labelSiniestroTipo.Text = "Tipo:"
        '
        'comboboxSiniestroTipo
        '
        Me.comboboxSiniestroTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboboxSiniestroTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxSiniestroTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxSiniestroTipo.FormattingEnabled = True
        Me.comboboxSiniestroTipo.Location = New System.Drawing.Point(184, 121)
        Me.comboboxSiniestroTipo.Name = "comboboxSiniestroTipo"
        Me.comboboxSiniestroTipo.Size = New System.Drawing.Size(267, 21)
        Me.comboboxSiniestroTipo.TabIndex = 12
        '
        'buttonCodigoSiguiente
        '
        Me.buttonCodigoSiguiente.Location = New System.Drawing.Point(317, 42)
        Me.buttonCodigoSiguiente.Name = "buttonCodigoSiguiente"
        Me.buttonCodigoSiguiente.Size = New System.Drawing.Size(103, 22)
        Me.buttonCodigoSiguiente.TabIndex = 6
        Me.buttonCodigoSiguiente.Text = "Obtener siguiente"
        Me.buttonCodigoSiguiente.UseVisualStyleBackColor = True
        '
        'comboboxCuartel
        '
        Me.comboboxCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCuartel.FormattingEnabled = True
        Me.comboboxCuartel.Location = New System.Drawing.Point(184, 15)
        Me.comboboxCuartel.Name = "comboboxCuartel"
        Me.comboboxCuartel.Size = New System.Drawing.Size(267, 21)
        Me.comboboxCuartel.TabIndex = 1
        '
        'datetimepickerHoraSalida
        '
        Me.datetimepickerHoraSalida.CustomFormat = "HH:mm"
        Me.datetimepickerHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickerHoraSalida.Location = New System.Drawing.Point(184, 202)
        Me.datetimepickerHoraSalida.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerHoraSalida.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerHoraSalida.Name = "datetimepickerHoraSalida"
        Me.datetimepickerHoraSalida.ShowCheckBox = True
        Me.datetimepickerHoraSalida.Size = New System.Drawing.Size(86, 20)
        Me.datetimepickerHoraSalida.TabIndex = 18
        '
        'labelSiniestroRubro
        '
        Me.labelSiniestroRubro.AutoSize = True
        Me.labelSiniestroRubro.Location = New System.Drawing.Point(6, 97)
        Me.labelSiniestroRubro.Name = "labelSiniestroRubro"
        Me.labelSiniestroRubro.Size = New System.Drawing.Size(39, 13)
        Me.labelSiniestroRubro.TabIndex = 9
        Me.labelSiniestroRubro.Text = "Rubro:"
        '
        'datetimepickerFecha
        '
        Me.datetimepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFecha.Location = New System.Drawing.Point(184, 68)
        Me.datetimepickerFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFecha.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFecha.Name = "datetimepickerFecha"
        Me.datetimepickerFecha.Size = New System.Drawing.Size(113, 20)
        Me.datetimepickerFecha.TabIndex = 8
        '
        'textboxPersonaFin
        '
        Me.textboxPersonaFin.Location = New System.Drawing.Point(276, 254)
        Me.textboxPersonaFin.Name = "textboxPersonaFin"
        Me.textboxPersonaFin.ReadOnly = True
        Me.textboxPersonaFin.Size = New System.Drawing.Size(175, 20)
        Me.textboxPersonaFin.TabIndex = 24
        Me.textboxPersonaFin.TabStop = False
        '
        'tabpageAsistencias
        '
        Me.tabpageAsistencias.Controls.Add(Me.datagridviewAsistencias)
        Me.tabpageAsistencias.Controls.Add(Me.statusstripMain)
        Me.tabpageAsistencias.Controls.Add(Me.toolstripAsistencias)
        Me.tabpageAsistencias.Location = New System.Drawing.Point(4, 25)
        Me.tabpageAsistencias.Name = "tabpageAsistencias"
        Me.tabpageAsistencias.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageAsistencias.Size = New System.Drawing.Size(706, 326)
        Me.tabpageAsistencias.TabIndex = 2
        Me.tabpageAsistencias.Text = "Asistencias"
        Me.tabpageAsistencias.UseVisualStyleBackColor = True
        '
        'datagridviewAsistencias
        '
        Me.datagridviewAsistencias.AllowUserToAddRows = False
        Me.datagridviewAsistencias.AllowUserToDeleteRows = False
        Me.datagridviewAsistencias.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewAsistencias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.datagridviewAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewAsistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnPersona, Me.columnSiniestroAsistenciaTipo})
        Me.datagridviewAsistencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewAsistencias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewAsistencias.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewAsistencias.MultiSelect = False
        Me.datagridviewAsistencias.Name = "datagridviewAsistencias"
        Me.datagridviewAsistencias.ReadOnly = True
        Me.datagridviewAsistencias.RowHeadersVisible = False
        Me.datagridviewAsistencias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewAsistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewAsistencias.Size = New System.Drawing.Size(613, 298)
        Me.datagridviewAsistencias.TabIndex = 8
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
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabelMain})
        Me.statusstripMain.Location = New System.Drawing.Point(90, 301)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(613, 22)
        Me.statusstripMain.SizingGrip = False
        Me.statusstripMain.TabIndex = 10
        '
        'statuslabelMain
        '
        Me.statuslabelMain.Name = "statuslabelMain"
        Me.statuslabelMain.Size = New System.Drawing.Size(598, 17)
        Me.statuslabelMain.Spring = True
        Me.statuslabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'toolstripAsistencias
        '
        Me.toolstripAsistencias.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripAsistencias.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripAsistencias.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripAsistencias.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAsistenciasAgregar, Me.buttonAsistenciasEditar, Me.buttonAsistenciasEliminar})
        Me.toolstripAsistencias.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripAsistencias.Location = New System.Drawing.Point(3, 3)
        Me.toolstripAsistencias.Name = "toolstripAsistencias"
        Me.toolstripAsistencias.Size = New System.Drawing.Size(87, 320)
        Me.toolstripAsistencias.TabIndex = 9
        '
        'buttonAsistenciasAgregar
        '
        Me.buttonAsistenciasAgregar.Image = Global.CSBomberos.My.Resources.Resources.ImageAgregar32
        Me.buttonAsistenciasAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAsistenciasAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAsistenciasAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAsistenciasAgregar.Name = "buttonAsistenciasAgregar"
        Me.buttonAsistenciasAgregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAsistenciasAgregar.Text = "Agregar"
        '
        'buttonAsistenciasEditar
        '
        Me.buttonAsistenciasEditar.Image = Global.CSBomberos.My.Resources.Resources.ImageEditar32
        Me.buttonAsistenciasEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAsistenciasEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAsistenciasEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAsistenciasEditar.Name = "buttonAsistenciasEditar"
        Me.buttonAsistenciasEditar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAsistenciasEditar.Text = "Editar"
        '
        'buttonAsistenciasEliminar
        '
        Me.buttonAsistenciasEliminar.Image = Global.CSBomberos.My.Resources.Resources.ImageBorrar32
        Me.buttonAsistenciasEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAsistenciasEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAsistenciasEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAsistenciasEliminar.Name = "buttonAsistenciasEliminar"
        Me.buttonAsistenciasEliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAsistenciasEliminar.Text = "Eliminar"
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(706, 326)
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
        Me.textboxNotas.Size = New System.Drawing.Size(592, 219)
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
        'CheckBoxControlado
        '
        Me.CheckBoxControlado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxControlado.AutoSize = True
        Me.CheckBoxControlado.Location = New System.Drawing.Point(184, 283)
        Me.CheckBoxControlado.Name = "CheckBoxControlado"
        Me.CheckBoxControlado.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlado.TabIndex = 26
        Me.CheckBoxControlado.UseVisualStyleBackColor = True
        '
        'LabelControlado
        '
        Me.LabelControlado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControlado.AutoSize = True
        Me.LabelControlado.Location = New System.Drawing.Point(6, 283)
        Me.LabelControlado.Name = "LabelControlado"
        Me.LabelControlado.Size = New System.Drawing.Size(61, 13)
        Me.LabelControlado.TabIndex = 25
        Me.LabelControlado.Text = "Controlado:"
        '
        'formSiniestro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 410)
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
        CType(Me.datagridviewResumenAsistencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpageAsistencias.ResumeLayout(False)
        Me.tabpageAsistencias.PerformLayout()
        CType(Me.datagridviewAsistencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        Me.toolstripAsistencias.ResumeLayout(False)
        Me.toolstripAsistencias.PerformLayout()
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
    Friend WithEvents tabcontrolMain As System.Windows.Forms.TabControl
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
    Friend WithEvents tabpageAsistencias As TabPage
    Friend WithEvents datagridviewAsistencias As DataGridView
    Friend WithEvents toolstripAsistencias As ToolStrip
    Friend WithEvents buttonAsistenciasAgregar As ToolStripButton
    Friend WithEvents buttonAsistenciasEditar As ToolStripButton
    Friend WithEvents buttonAsistenciasEliminar As ToolStripButton
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
    Friend WithEvents columnPersona As DataGridViewTextBoxColumn
    Friend WithEvents columnSiniestroAsistenciaTipo As DataGridViewTextBoxColumn
    Friend WithEvents labelNumeroSeparador As Label
    Friend WithEvents maskedtextboxNumero As MaskedTextBox
    Friend WithEvents maskedtextboxNumeroPrefijo As MaskedTextBox
    Friend WithEvents statusstripMain As StatusStrip
    Friend WithEvents statuslabelMain As ToolStripStatusLabel
    Friend WithEvents datetimepickerHoraLlegadaUltimoCamion As DateTimePicker
    Friend WithEvents datagridviewResumenAsistencias As DataGridView
    Friend WithEvents columnResumenAsistenciaTipo As DataGridViewTextBoxColumn
    Friend WithEvents columnResumenCantidad As DataGridViewTextBoxColumn
    Friend WithEvents labelResumenAsistencias As Label
    Friend WithEvents buttonHoraFinFinalizar As Button
    Friend WithEvents textboxPersonaFin As TextBox
    Friend WithEvents CheckBoxControlado As CheckBox
    Friend WithEvents LabelControlado As Label
End Class
