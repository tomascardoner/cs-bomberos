<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAcademia
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
        Dim labelCuartel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tabcontrolMain = New CSBomberos.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.labelAcademiaTipoOtro = New System.Windows.Forms.Label()
        Me.textboxAcademiaTipoOtro = New System.Windows.Forms.TextBox()
        Me.labelAcademiaTipo = New System.Windows.Forms.Label()
        Me.comboboxAcademiaTipo = New System.Windows.Forms.ComboBox()
        Me.comboboxCuartel = New System.Windows.Forms.ComboBox()
        Me.datetimepickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.tabpageAsistencias = New System.Windows.Forms.TabPage()
        Me.datagridviewAsistencias = New System.Windows.Forms.DataGridView()
        Me.columnPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnAcademiaAsistenciaTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstripAsistencias = New System.Windows.Forms.ToolStrip()
        Me.buttonAsistenciasAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAsistenciasEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAsistenciasEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.labelIDAcademia = New System.Windows.Forms.Label()
        Me.textboxIDAcademia = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelCuartel = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
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
        labelModificacion.Location = New System.Drawing.Point(6, 275)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 9
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 249)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 6
        labelCreacion.Text = "Creación:"
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
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(6, 55)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelFecha.TabIndex = 2
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
        Me.tabcontrolMain.Size = New System.Drawing.Size(664, 324)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.labelAcademiaTipoOtro)
        Me.tabpageGeneral.Controls.Add(Me.textboxAcademiaTipoOtro)
        Me.tabpageGeneral.Controls.Add(Me.labelAcademiaTipo)
        Me.tabpageGeneral.Controls.Add(Me.comboboxAcademiaTipo)
        Me.tabpageGeneral.Controls.Add(Me.comboboxCuartel)
        Me.tabpageGeneral.Controls.Add(labelCuartel)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFecha)
        Me.tabpageGeneral.Controls.Add(Me.labelFecha)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(656, 295)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'labelAcademiaTipoOtro
        '
        Me.labelAcademiaTipoOtro.AutoSize = True
        Me.labelAcademiaTipoOtro.Location = New System.Drawing.Point(6, 118)
        Me.labelAcademiaTipoOtro.Name = "labelAcademiaTipoOtro"
        Me.labelAcademiaTipoOtro.Size = New System.Drawing.Size(30, 13)
        Me.labelAcademiaTipoOtro.TabIndex = 6
        Me.labelAcademiaTipoOtro.Text = "Otro:"
        Me.labelAcademiaTipoOtro.Visible = False
        '
        'textboxAcademiaTipoOtro
        '
        Me.textboxAcademiaTipoOtro.Location = New System.Drawing.Point(96, 115)
        Me.textboxAcademiaTipoOtro.MaxLength = 50
        Me.textboxAcademiaTipoOtro.Name = "textboxAcademiaTipoOtro"
        Me.textboxAcademiaTipoOtro.Size = New System.Drawing.Size(267, 20)
        Me.textboxAcademiaTipoOtro.TabIndex = 7
        Me.textboxAcademiaTipoOtro.Visible = False
        '
        'labelAcademiaTipo
        '
        Me.labelAcademiaTipo.AutoSize = True
        Me.labelAcademiaTipo.Location = New System.Drawing.Point(6, 91)
        Me.labelAcademiaTipo.Name = "labelAcademiaTipo"
        Me.labelAcademiaTipo.Size = New System.Drawing.Size(31, 13)
        Me.labelAcademiaTipo.TabIndex = 4
        Me.labelAcademiaTipo.Text = "Tipo:"
        '
        'comboboxAcademiaTipo
        '
        Me.comboboxAcademiaTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboboxAcademiaTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxAcademiaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxAcademiaTipo.FormattingEnabled = True
        Me.comboboxAcademiaTipo.Location = New System.Drawing.Point(96, 88)
        Me.comboboxAcademiaTipo.Name = "comboboxAcademiaTipo"
        Me.comboboxAcademiaTipo.Size = New System.Drawing.Size(267, 21)
        Me.comboboxAcademiaTipo.TabIndex = 5
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
        'datetimepickerFecha
        '
        Me.datetimepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFecha.Location = New System.Drawing.Point(96, 52)
        Me.datetimepickerFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFecha.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFecha.Name = "datetimepickerFecha"
        Me.datetimepickerFecha.Size = New System.Drawing.Size(113, 20)
        Me.datetimepickerFecha.TabIndex = 3
        '
        'tabpageAsistencias
        '
        Me.tabpageAsistencias.Controls.Add(Me.datagridviewAsistencias)
        Me.tabpageAsistencias.Controls.Add(Me.statusstripMain)
        Me.tabpageAsistencias.Controls.Add(Me.toolstripAsistencias)
        Me.tabpageAsistencias.Location = New System.Drawing.Point(4, 25)
        Me.tabpageAsistencias.Name = "tabpageAsistencias"
        Me.tabpageAsistencias.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageAsistencias.Size = New System.Drawing.Size(656, 295)
        Me.tabpageAsistencias.TabIndex = 2
        Me.tabpageAsistencias.Text = "Asistencias"
        Me.tabpageAsistencias.UseVisualStyleBackColor = True
        '
        'datagridviewAsistencias
        '
        Me.datagridviewAsistencias.AllowUserToAddRows = False
        Me.datagridviewAsistencias.AllowUserToDeleteRows = False
        Me.datagridviewAsistencias.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewAsistencias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewAsistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnPersona, Me.columnAcademiaAsistenciaTipo})
        Me.datagridviewAsistencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewAsistencias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewAsistencias.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewAsistencias.MultiSelect = False
        Me.datagridviewAsistencias.Name = "datagridviewAsistencias"
        Me.datagridviewAsistencias.ReadOnly = True
        Me.datagridviewAsistencias.RowHeadersVisible = False
        Me.datagridviewAsistencias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewAsistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewAsistencias.Size = New System.Drawing.Size(563, 267)
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
        'columnAcademiaAsistenciaTipo
        '
        Me.columnAcademiaAsistenciaTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnAcademiaAsistenciaTipo.DataPropertyName = "AcademiaAsistenciaTipoNombre"
        Me.columnAcademiaAsistenciaTipo.HeaderText = "Asistencia"
        Me.columnAcademiaAsistenciaTipo.Name = "columnAcademiaAsistenciaTipo"
        Me.columnAcademiaAsistenciaTipo.ReadOnly = True
        Me.columnAcademiaAsistenciaTipo.Width = 80
        '
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabelMain})
        Me.statusstripMain.Location = New System.Drawing.Point(90, 270)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(563, 22)
        Me.statusstripMain.SizingGrip = False
        Me.statusstripMain.TabIndex = 11
        '
        'statuslabelMain
        '
        Me.statuslabelMain.Name = "statuslabelMain"
        Me.statuslabelMain.Size = New System.Drawing.Size(548, 17)
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
        Me.toolstripAsistencias.Size = New System.Drawing.Size(87, 289)
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
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelIDAcademia)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxIDAcademia)
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(656, 295)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelIDAcademia
        '
        Me.labelIDAcademia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelIDAcademia.AutoSize = True
        Me.labelIDAcademia.Location = New System.Drawing.Point(6, 223)
        Me.labelIDAcademia.Name = "labelIDAcademia"
        Me.labelIDAcademia.Size = New System.Drawing.Size(21, 13)
        Me.labelIDAcademia.TabIndex = 4
        Me.labelIDAcademia.Text = "ID:"
        '
        'textboxIDAcademia
        '
        Me.textboxIDAcademia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxIDAcademia.Location = New System.Drawing.Point(114, 220)
        Me.textboxIDAcademia.MaxLength = 10
        Me.textboxIDAcademia.Name = "textboxIDAcademia"
        Me.textboxIDAcademia.ReadOnly = True
        Me.textboxIDAcademia.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDAcademia.TabIndex = 5
        Me.textboxIDAcademia.TabStop = False
        Me.textboxIDAcademia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 272)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 11
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 246)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 8
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 272)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 10
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 246)
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
        Me.textboxNotas.Size = New System.Drawing.Size(542, 208)
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
        'formAcademia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 379)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formAcademia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Academia"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
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
    Friend WithEvents datetimepickerFecha As DateTimePicker
    Friend WithEvents tabpageAsistencias As TabPage
    Friend WithEvents datagridviewAsistencias As DataGridView
    Friend WithEvents toolstripAsistencias As ToolStrip
    Friend WithEvents buttonAsistenciasAgregar As ToolStripButton
    Friend WithEvents buttonAsistenciasEditar As ToolStripButton
    Friend WithEvents buttonAsistenciasEliminar As ToolStripButton
    Friend WithEvents buttonImprimir As ToolStripButton
    Friend WithEvents labelIDAcademia As Label
    Friend WithEvents textboxIDAcademia As TextBox
    Friend WithEvents comboboxCuartel As ComboBox
    Friend WithEvents labelAcademiaTipo As Label
    Friend WithEvents comboboxAcademiaTipo As ComboBox
    Friend WithEvents labelAcademiaTipoOtro As Label
    Friend WithEvents textboxAcademiaTipoOtro As TextBox
    Friend WithEvents columnPersona As DataGridViewTextBoxColumn
    Friend WithEvents columnAcademiaAsistenciaTipo As DataGridViewTextBoxColumn
    Friend WithEvents statusstripMain As StatusStrip
    Friend WithEvents statuslabelMain As ToolStripStatusLabel
End Class
