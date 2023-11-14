<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formOrdenGeneral
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.TabControlMain = New CSBomberos.CS_Control_TabControl()
        Me.TabPageGeneral = New System.Windows.Forms.TabPage()
        Me.ComboBoxCategoria = New System.Windows.Forms.ComboBox()
        Me.LabelCategoria = New System.Windows.Forms.Label()
        Me.LabelPersonal = New System.Windows.Forms.Label()
        Me.TextBoxPersonal = New System.Windows.Forms.TextBox()
        Me.LabelDescripcion = New System.Windows.Forms.Label()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.NumericUpDownSubNumero = New System.Windows.Forms.NumericUpDown()
        Me.LabelSubNumero = New System.Windows.Forms.Label()
        Me.IntegerTextBoxNumero = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.LabelNumero = New System.Windows.Forms.Label()
        Me.ButtonNumeroSiguiente = New System.Windows.Forms.Button()
        Me.TabPageRelaciones = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanelRelaciones = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelRelacionadas = New System.Windows.Forms.Panel()
        Me.DataGridViewRelacionadas = New System.Windows.Forms.DataGridView()
        Me.LabelRelacionadas = New System.Windows.Forms.Label()
        Me.PanelRelacionantes = New System.Windows.Forms.Panel()
        Me.DataGridViewRelacionantes = New System.Windows.Forms.DataGridView()
        Me.ColumnRelacionantesRelacionTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnRelacionantesNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnRelacionantesFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnRelacionantesMotivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelRelacionantes = New System.Windows.Forms.Label()
        Me.TabPageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.ColumnRelacionadasTipoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnRelacionadasNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnRelacionadasFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnRelacionadasMotivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.TabControlMain.SuspendLayout()
        Me.TabPageGeneral.SuspendLayout()
        CType(Me.NumericUpDownSubNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntegerTextBoxNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageRelaciones.SuspendLayout()
        Me.TableLayoutPanelRelaciones.SuspendLayout()
        Me.PanelRelacionadas.SuspendLayout()
        CType(Me.DataGridViewRelacionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRelacionantes.SuspendLayout()
        CType(Me.DataGridViewRelacionantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelModificacion
        '
        labelModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(10, 236)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 21
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(10, 210)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 18
        labelCreacion.Text = "Creación:"
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
        Me.toolstripMain.Size = New System.Drawing.Size(542, 39)
        Me.toolstripMain.TabIndex = 1
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
        Me.textboxNotas.Size = New System.Drawing.Size(390, 169)
        Me.textboxNotas.TabIndex = 15
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(6, 9)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 14
        Me.labelNotas.Text = "Notas:"
        '
        'TabControlMain
        '
        Me.TabControlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControlMain.Controls.Add(Me.TabPageGeneral)
        Me.TabControlMain.Controls.Add(Me.TabPageRelaciones)
        Me.TabControlMain.Controls.Add(Me.TabPageNotasAuditoria)
        Me.TabControlMain.Location = New System.Drawing.Point(12, 42)
        Me.TabControlMain.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(518, 288)
        Me.TabControlMain.TabIndex = 0
        '
        'TabPageGeneral
        '
        Me.TabPageGeneral.Controls.Add(Me.ComboBoxCategoria)
        Me.TabPageGeneral.Controls.Add(Me.LabelCategoria)
        Me.TabPageGeneral.Controls.Add(Me.LabelPersonal)
        Me.TabPageGeneral.Controls.Add(Me.TextBoxPersonal)
        Me.TabPageGeneral.Controls.Add(Me.LabelDescripcion)
        Me.TabPageGeneral.Controls.Add(Me.TextBoxDescripcion)
        Me.TabPageGeneral.Controls.Add(Me.DateTimePickerFecha)
        Me.TabPageGeneral.Controls.Add(Me.LabelFecha)
        Me.TabPageGeneral.Controls.Add(Me.NumericUpDownSubNumero)
        Me.TabPageGeneral.Controls.Add(Me.LabelSubNumero)
        Me.TabPageGeneral.Controls.Add(Me.IntegerTextBoxNumero)
        Me.TabPageGeneral.Controls.Add(Me.LabelNumero)
        Me.TabPageGeneral.Controls.Add(Me.ButtonNumeroSiguiente)
        Me.TabPageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.TabPageGeneral.Name = "TabPageGeneral"
        Me.TabPageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGeneral.Size = New System.Drawing.Size(510, 259)
        Me.TabPageGeneral.TabIndex = 2
        Me.TabPageGeneral.Text = "General"
        Me.TabPageGeneral.UseVisualStyleBackColor = True
        '
        'ComboBoxCategoria
        '
        Me.ComboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCategoria.FormattingEnabled = True
        Me.ComboBoxCategoria.Location = New System.Drawing.Point(98, 228)
        Me.ComboBoxCategoria.Name = "ComboBoxCategoria"
        Me.ComboBoxCategoria.Size = New System.Drawing.Size(199, 21)
        Me.ComboBoxCategoria.TabIndex = 12
        '
        'LabelCategoria
        '
        Me.LabelCategoria.AutoSize = True
        Me.LabelCategoria.Location = New System.Drawing.Point(6, 231)
        Me.LabelCategoria.Name = "LabelCategoria"
        Me.LabelCategoria.Size = New System.Drawing.Size(57, 13)
        Me.LabelCategoria.TabIndex = 11
        Me.LabelCategoria.Text = "Categoría:"
        '
        'LabelPersonal
        '
        Me.LabelPersonal.AutoSize = True
        Me.LabelPersonal.Location = New System.Drawing.Point(6, 152)
        Me.LabelPersonal.Name = "LabelPersonal"
        Me.LabelPersonal.Size = New System.Drawing.Size(51, 13)
        Me.LabelPersonal.TabIndex = 9
        Me.LabelPersonal.Text = "Personal:"
        '
        'TextBoxPersonal
        '
        Me.TextBoxPersonal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPersonal.Location = New System.Drawing.Point(98, 149)
        Me.TextBoxPersonal.MaxLength = 0
        Me.TextBoxPersonal.Multiline = True
        Me.TextBoxPersonal.Name = "TextBoxPersonal"
        Me.TextBoxPersonal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxPersonal.Size = New System.Drawing.Size(406, 73)
        Me.TextBoxPersonal.TabIndex = 10
        '
        'LabelDescripcion
        '
        Me.LabelDescripcion.AutoSize = True
        Me.LabelDescripcion.Location = New System.Drawing.Point(6, 73)
        Me.LabelDescripcion.Name = "LabelDescripcion"
        Me.LabelDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.LabelDescripcion.TabIndex = 7
        Me.LabelDescripcion.Text = "Descripción:"
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(98, 70)
        Me.TextBoxDescripcion.MaxLength = 0
        Me.TextBoxDescripcion.Multiline = True
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(406, 73)
        Me.TextBoxDescripcion.TabIndex = 8
        '
        'DateTimePickerFecha
        '
        Me.DateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFecha.Location = New System.Drawing.Point(98, 44)
        Me.DateTimePickerFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
        Me.DateTimePickerFecha.ShowCheckBox = True
        Me.DateTimePickerFecha.Size = New System.Drawing.Size(138, 20)
        Me.DateTimePickerFecha.TabIndex = 6
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Location = New System.Drawing.Point(6, 47)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(40, 13)
        Me.LabelFecha.TabIndex = 5
        Me.LabelFecha.Text = "Fecha:"
        '
        'NumericUpDownSubNumero
        '
        Me.NumericUpDownSubNumero.Location = New System.Drawing.Point(339, 19)
        Me.NumericUpDownSubNumero.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownSubNumero.Name = "NumericUpDownSubNumero"
        Me.NumericUpDownSubNumero.Size = New System.Drawing.Size(47, 20)
        Me.NumericUpDownSubNumero.TabIndex = 4
        Me.NumericUpDownSubNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelSubNumero
        '
        Me.LabelSubNumero.AutoSize = True
        Me.LabelSubNumero.Location = New System.Drawing.Point(266, 22)
        Me.LabelSubNumero.Name = "LabelSubNumero"
        Me.LabelSubNumero.Size = New System.Drawing.Size(67, 13)
        Me.LabelSubNumero.TabIndex = 3
        Me.LabelSubNumero.Text = "Sub-número:"
        '
        'IntegerTextBoxNumero
        '
        Me.IntegerTextBoxNumero.BeforeTouchSize = New System.Drawing.Size(47, 20)
        Me.IntegerTextBoxNumero.IntegerValue = CType(1, Long)
        Me.IntegerTextBoxNumero.Location = New System.Drawing.Point(98, 18)
        Me.IntegerTextBoxNumero.MaxValue = CType(32767, Long)
        Me.IntegerTextBoxNumero.MinValue = CType(1, Long)
        Me.IntegerTextBoxNumero.Name = "IntegerTextBoxNumero"
        Me.IntegerTextBoxNumero.Size = New System.Drawing.Size(47, 20)
        Me.IntegerTextBoxNumero.TabIndex = 1
        Me.IntegerTextBoxNumero.Text = "1"
        Me.IntegerTextBoxNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelNumero
        '
        Me.LabelNumero.AutoSize = True
        Me.LabelNumero.Location = New System.Drawing.Point(6, 21)
        Me.LabelNumero.Name = "LabelNumero"
        Me.LabelNumero.Size = New System.Drawing.Size(47, 13)
        Me.LabelNumero.TabIndex = 0
        Me.LabelNumero.Text = "Número:"
        '
        'ButtonNumeroSiguiente
        '
        Me.ButtonNumeroSiguiente.Location = New System.Drawing.Point(151, 18)
        Me.ButtonNumeroSiguiente.Name = "ButtonNumeroSiguiente"
        Me.ButtonNumeroSiguiente.Size = New System.Drawing.Size(103, 21)
        Me.ButtonNumeroSiguiente.TabIndex = 2
        Me.ButtonNumeroSiguiente.Text = "Obtener siguiente"
        Me.ButtonNumeroSiguiente.UseVisualStyleBackColor = True
        '
        'TabPageRelaciones
        '
        Me.TabPageRelaciones.Controls.Add(Me.TableLayoutPanelRelaciones)
        Me.TabPageRelaciones.Location = New System.Drawing.Point(4, 25)
        Me.TabPageRelaciones.Name = "TabPageRelaciones"
        Me.TabPageRelaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageRelaciones.Size = New System.Drawing.Size(510, 259)
        Me.TabPageRelaciones.TabIndex = 3
        Me.TabPageRelaciones.Text = "Relaciones"
        Me.TabPageRelaciones.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelRelaciones
        '
        Me.TableLayoutPanelRelaciones.ColumnCount = 1
        Me.TableLayoutPanelRelaciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelRelaciones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelRelaciones.Controls.Add(Me.PanelRelacionadas, 0, 1)
        Me.TableLayoutPanelRelaciones.Controls.Add(Me.PanelRelacionantes, 0, 0)
        Me.TableLayoutPanelRelaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelRelaciones.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanelRelaciones.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanelRelaciones.Name = "TableLayoutPanelRelaciones"
        Me.TableLayoutPanelRelaciones.RowCount = 2
        Me.TableLayoutPanelRelaciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelRelaciones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelRelaciones.Size = New System.Drawing.Size(504, 253)
        Me.TableLayoutPanelRelaciones.TabIndex = 0
        '
        'PanelRelacionadas
        '
        Me.PanelRelacionadas.Controls.Add(Me.DataGridViewRelacionadas)
        Me.PanelRelacionadas.Controls.Add(Me.LabelRelacionadas)
        Me.PanelRelacionadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRelacionadas.Location = New System.Drawing.Point(0, 126)
        Me.PanelRelacionadas.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelRelacionadas.Name = "PanelRelacionadas"
        Me.PanelRelacionadas.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelRelacionadas.Size = New System.Drawing.Size(504, 127)
        Me.PanelRelacionadas.TabIndex = 1
        '
        'DataGridViewRelacionadas
        '
        Me.DataGridViewRelacionadas.AllowUserToAddRows = False
        Me.DataGridViewRelacionadas.AllowUserToDeleteRows = False
        Me.DataGridViewRelacionadas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.DataGridViewRelacionadas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewRelacionadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewRelacionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRelacionadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnRelacionadasTipoNombre, Me.ColumnRelacionadasNumero, Me.ColumnRelacionadasFecha, Me.ColumnRelacionadasMotivo})
        Me.DataGridViewRelacionadas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewRelacionadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewRelacionadas.Location = New System.Drawing.Point(3, 19)
        Me.DataGridViewRelacionadas.MultiSelect = False
        Me.DataGridViewRelacionadas.Name = "DataGridViewRelacionadas"
        Me.DataGridViewRelacionadas.ReadOnly = True
        Me.DataGridViewRelacionadas.RowHeadersVisible = False
        Me.DataGridViewRelacionadas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewRelacionadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewRelacionadas.Size = New System.Drawing.Size(498, 105)
        Me.DataGridViewRelacionadas.TabIndex = 2
        '
        'LabelRelacionadas
        '
        Me.LabelRelacionadas.AutoSize = True
        Me.LabelRelacionadas.Location = New System.Drawing.Point(6, 3)
        Me.LabelRelacionadas.Name = "LabelRelacionadas"
        Me.LabelRelacionadas.Size = New System.Drawing.Size(162, 13)
        Me.LabelRelacionadas.TabIndex = 1
        Me.LabelRelacionadas.Text = "Órdenes generales relacionadas:"
        '
        'PanelRelacionantes
        '
        Me.PanelRelacionantes.Controls.Add(Me.DataGridViewRelacionantes)
        Me.PanelRelacionantes.Controls.Add(Me.LabelRelacionantes)
        Me.PanelRelacionantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRelacionantes.Location = New System.Drawing.Point(0, 0)
        Me.PanelRelacionantes.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelRelacionantes.Name = "PanelRelacionantes"
        Me.PanelRelacionantes.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelRelacionantes.Size = New System.Drawing.Size(504, 126)
        Me.PanelRelacionantes.TabIndex = 0
        '
        'DataGridViewRelacionantes
        '
        Me.DataGridViewRelacionantes.AllowUserToAddRows = False
        Me.DataGridViewRelacionantes.AllowUserToDeleteRows = False
        Me.DataGridViewRelacionantes.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.DataGridViewRelacionantes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewRelacionantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewRelacionantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRelacionantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnRelacionantesRelacionTipo, Me.ColumnRelacionantesNumero, Me.ColumnRelacionantesFecha, Me.ColumnRelacionantesMotivo})
        Me.DataGridViewRelacionantes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewRelacionantes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewRelacionantes.Location = New System.Drawing.Point(3, 19)
        Me.DataGridViewRelacionantes.MultiSelect = False
        Me.DataGridViewRelacionantes.Name = "DataGridViewRelacionantes"
        Me.DataGridViewRelacionantes.ReadOnly = True
        Me.DataGridViewRelacionantes.RowHeadersVisible = False
        Me.DataGridViewRelacionantes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewRelacionantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewRelacionantes.Size = New System.Drawing.Size(498, 104)
        Me.DataGridViewRelacionantes.TabIndex = 2
        '
        'ColumnRelacionantesRelacionTipo
        '
        Me.ColumnRelacionantesRelacionTipo.DataPropertyName = "RelacionTipoNombre"
        Me.ColumnRelacionantesRelacionTipo.HeaderText = "Tipo"
        Me.ColumnRelacionantesRelacionTipo.Name = "ColumnRelacionantesRelacionTipo"
        Me.ColumnRelacionantesRelacionTipo.ReadOnly = True
        Me.ColumnRelacionantesRelacionTipo.Width = 53
        '
        'ColumnRelacionantesNumero
        '
        Me.ColumnRelacionantesNumero.DataPropertyName = "NumeroCompleto"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ColumnRelacionantesNumero.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColumnRelacionantesNumero.HeaderText = "Número"
        Me.ColumnRelacionantesNumero.Name = "ColumnRelacionantesNumero"
        Me.ColumnRelacionantesNumero.ReadOnly = True
        Me.ColumnRelacionantesNumero.Width = 69
        '
        'ColumnRelacionantesFecha
        '
        Me.ColumnRelacionantesFecha.DataPropertyName = "Fecha"
        Me.ColumnRelacionantesFecha.HeaderText = "Fecha"
        Me.ColumnRelacionantesFecha.Name = "ColumnRelacionantesFecha"
        Me.ColumnRelacionantesFecha.ReadOnly = True
        Me.ColumnRelacionantesFecha.Width = 62
        '
        'ColumnRelacionantesMotivo
        '
        Me.ColumnRelacionantesMotivo.DataPropertyName = "Motivo"
        Me.ColumnRelacionantesMotivo.HeaderText = "Motivo"
        Me.ColumnRelacionantesMotivo.Name = "ColumnRelacionantesMotivo"
        Me.ColumnRelacionantesMotivo.ReadOnly = True
        Me.ColumnRelacionantesMotivo.Width = 64
        '
        'LabelRelacionantes
        '
        Me.LabelRelacionantes.AutoSize = True
        Me.LabelRelacionantes.Location = New System.Drawing.Point(6, 3)
        Me.LabelRelacionantes.Name = "LabelRelacionantes"
        Me.LabelRelacionantes.Size = New System.Drawing.Size(165, 13)
        Me.LabelRelacionantes.TabIndex = 1
        Me.LabelRelacionantes.Text = "Órdenes generales relacionantes:"
        '
        'TabPageNotasAuditoria
        '
        Me.TabPageNotasAuditoria.Controls.Add(Me.LabelID)
        Me.TabPageNotasAuditoria.Controls.Add(Me.TextBoxID)
        Me.TabPageNotasAuditoria.Controls.Add(Me.textboxUsuarioModificacion)
        Me.TabPageNotasAuditoria.Controls.Add(Me.textboxUsuarioCreacion)
        Me.TabPageNotasAuditoria.Controls.Add(Me.textboxFechaHoraModificacion)
        Me.TabPageNotasAuditoria.Controls.Add(Me.textboxFechaHoraCreacion)
        Me.TabPageNotasAuditoria.Controls.Add(labelModificacion)
        Me.TabPageNotasAuditoria.Controls.Add(labelCreacion)
        Me.TabPageNotasAuditoria.Controls.Add(Me.textboxNotas)
        Me.TabPageNotasAuditoria.Controls.Add(Me.labelNotas)
        Me.TabPageNotasAuditoria.Location = New System.Drawing.Point(4, 25)
        Me.TabPageNotasAuditoria.Name = "TabPageNotasAuditoria"
        Me.TabPageNotasAuditoria.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageNotasAuditoria.Size = New System.Drawing.Size(510, 259)
        Me.TabPageNotasAuditoria.TabIndex = 1
        Me.TabPageNotasAuditoria.Text = "Notas y Auditoría"
        Me.TabPageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'LabelID
        '
        Me.LabelID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(10, 184)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(21, 13)
        Me.LabelID.TabIndex = 16
        Me.LabelID.Text = "ID:"
        '
        'TextBoxID
        '
        Me.TextBoxID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxID.Location = New System.Drawing.Point(118, 181)
        Me.TextBoxID.MaxLength = 10
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.ReadOnly = True
        Me.TextBoxID.Size = New System.Drawing.Size(72, 20)
        Me.TextBoxID.TabIndex = 17
        Me.TextBoxID.TabStop = False
        Me.TextBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(245, 233)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 23
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(245, 207)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 20
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(118, 233)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 22
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(118, 207)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 19
        '
        'ColumnRelacionadasTipoNombre
        '
        Me.ColumnRelacionadasTipoNombre.DataPropertyName = "RelacionTipoNombre"
        Me.ColumnRelacionadasTipoNombre.HeaderText = "Tipo"
        Me.ColumnRelacionadasTipoNombre.Name = "ColumnRelacionadasTipoNombre"
        Me.ColumnRelacionadasTipoNombre.ReadOnly = True
        Me.ColumnRelacionadasTipoNombre.Width = 53
        '
        'ColumnRelacionadasNumero
        '
        Me.ColumnRelacionadasNumero.DataPropertyName = "NumeroCompleto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ColumnRelacionadasNumero.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColumnRelacionadasNumero.HeaderText = "Número"
        Me.ColumnRelacionadasNumero.Name = "ColumnRelacionadasNumero"
        Me.ColumnRelacionadasNumero.ReadOnly = True
        Me.ColumnRelacionadasNumero.Width = 69
        '
        'ColumnRelacionadasFecha
        '
        Me.ColumnRelacionadasFecha.DataPropertyName = "Fecha"
        Me.ColumnRelacionadasFecha.HeaderText = "Fecha"
        Me.ColumnRelacionadasFecha.Name = "ColumnRelacionadasFecha"
        Me.ColumnRelacionadasFecha.ReadOnly = True
        Me.ColumnRelacionadasFecha.Width = 62
        '
        'ColumnRelacionadasMotivo
        '
        Me.ColumnRelacionadasMotivo.DataPropertyName = "Motivo"
        Me.ColumnRelacionadasMotivo.HeaderText = "Motivo"
        Me.ColumnRelacionadasMotivo.Name = "ColumnRelacionadasMotivo"
        Me.ColumnRelacionadasMotivo.ReadOnly = True
        Me.ColumnRelacionadasMotivo.Width = 64
        '
        'formOrdenGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 341)
        Me.Controls.Add(Me.TabControlMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formOrdenGeneral"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Órden general"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPageGeneral.ResumeLayout(False)
        Me.TabPageGeneral.PerformLayout()
        CType(Me.NumericUpDownSubNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntegerTextBoxNumero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageRelaciones.ResumeLayout(False)
        Me.TableLayoutPanelRelaciones.ResumeLayout(False)
        Me.PanelRelacionadas.ResumeLayout(False)
        Me.PanelRelacionadas.PerformLayout()
        CType(Me.DataGridViewRelacionadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRelacionantes.ResumeLayout(False)
        Me.PanelRelacionantes.PerformLayout()
        CType(Me.DataGridViewRelacionantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageNotasAuditoria.ResumeLayout(False)
        Me.TabPageNotasAuditoria.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents TabControlMain As CS_Control_TabControl
    Friend WithEvents TabPageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents LabelID As System.Windows.Forms.Label
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents TabPageGeneral As TabPage
    Friend WithEvents IntegerTextBoxNumero As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents LabelNumero As Label
    Friend WithEvents ButtonNumeroSiguiente As Button
    Friend WithEvents NumericUpDownSubNumero As NumericUpDown
    Friend WithEvents LabelSubNumero As Label
    Friend WithEvents DateTimePickerFecha As DateTimePicker
    Friend WithEvents LabelFecha As Label
    Friend WithEvents LabelDescripcion As Label
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents LabelPersonal As Label
    Friend WithEvents TextBoxPersonal As TextBox
    Friend WithEvents ComboBoxCategoria As ComboBox
    Friend WithEvents LabelCategoria As Label
    Friend WithEvents TabPageRelaciones As TabPage
    Friend WithEvents TableLayoutPanelRelaciones As TableLayoutPanel
    Friend WithEvents PanelRelacionantes As Panel
    Friend WithEvents LabelRelacionantes As Label
    Friend WithEvents PanelRelacionadas As Panel
    Friend WithEvents LabelRelacionadas As Label
    Friend WithEvents DataGridViewRelacionantes As DataGridView
    Friend WithEvents DataGridViewRelacionadas As DataGridView
    Friend WithEvents ColumnRelacionantesRelacionTipo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnRelacionantesNumero As DataGridViewTextBoxColumn
    Friend WithEvents ColumnRelacionantesFecha As DataGridViewTextBoxColumn
    Friend WithEvents ColumnRelacionantesMotivo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnRelacionadasTipoNombre As DataGridViewTextBoxColumn
    Friend WithEvents ColumnRelacionadasNumero As DataGridViewTextBoxColumn
    Friend WithEvents ColumnRelacionadasFecha As DataGridViewTextBoxColumn
    Friend WithEvents ColumnRelacionadasMotivo As DataGridViewTextBoxColumn
End Class
