<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formSiniestroAsistenciaTipo
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
        Dim labelEsActivo As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.tabcontrolMain = New CSBomberos.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.updownOrden = New System.Windows.Forms.NumericUpDown()
        Me.checkboxExcluyeDelTotal = New System.Windows.Forms.CheckBox()
        Me.checkboxEsPresente = New System.Windows.Forms.CheckBox()
        Me.checkboxEsAusenciaJustificada = New System.Windows.Forms.CheckBox()
        Me.labelOrden = New System.Windows.Forms.Label()
        Me.labelExcluyeDelTotal = New System.Windows.Forms.Label()
        Me.labelEsAusenciaJustificada = New System.Windows.Forms.Label()
        Me.labelEsPresente = New System.Windows.Forms.Label()
        Me.textboxAbreviatura = New System.Windows.Forms.TextBox()
        Me.labelAbreviatura = New System.Windows.Forms.Label()
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.tabpagePuntajes = New System.Windows.Forms.TabPage()
        Me.datagridviewPuntajes = New System.Windows.Forms.DataGridView()
        Me.toolstripPuntajes = New System.Windows.Forms.ToolStrip()
        Me.buttonPuntajesAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonPuntajesEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonPuntajesEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.labelID = New System.Windows.Forms.Label()
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.textboxID = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.columnFechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnPuntajeClaveVerde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnPuntajeClaveAzul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnPuntajeClaveNaranja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnPuntajeClaveRoja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnPorcentajeDescuentoPorSalidaAnticipada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        labelEsActivo = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        CType(Me.updownOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpagePuntajes.SuspendLayout()
        CType(Me.datagridviewPuntajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripPuntajes.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelEsActivo
        '
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(7, 85)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 2
        labelEsActivo.Text = "Activo:"
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(7, 163)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 9
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(7, 137)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 6
        labelCreacion.Text = "Creación:"
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
        Me.toolstripMain.Size = New System.Drawing.Size(599, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpagePuntajes)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(577, 271)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.updownOrden)
        Me.tabpageGeneral.Controls.Add(Me.checkboxExcluyeDelTotal)
        Me.tabpageGeneral.Controls.Add(Me.checkboxEsPresente)
        Me.tabpageGeneral.Controls.Add(Me.checkboxEsAusenciaJustificada)
        Me.tabpageGeneral.Controls.Add(Me.labelOrden)
        Me.tabpageGeneral.Controls.Add(Me.labelExcluyeDelTotal)
        Me.tabpageGeneral.Controls.Add(Me.labelEsAusenciaJustificada)
        Me.tabpageGeneral.Controls.Add(Me.labelEsPresente)
        Me.tabpageGeneral.Controls.Add(Me.textboxAbreviatura)
        Me.tabpageGeneral.Controls.Add(Me.labelAbreviatura)
        Me.tabpageGeneral.Controls.Add(Me.textboxNombre)
        Me.tabpageGeneral.Controls.Add(Me.labelNombre)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(569, 242)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'updownOrden
        '
        Me.updownOrden.Location = New System.Drawing.Point(133, 150)
        Me.updownOrden.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.updownOrden.Name = "updownOrden"
        Me.updownOrden.Size = New System.Drawing.Size(46, 20)
        Me.updownOrden.TabIndex = 11
        Me.updownOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'checkboxExcluyeDelTotal
        '
        Me.checkboxExcluyeDelTotal.AutoSize = True
        Me.checkboxExcluyeDelTotal.Location = New System.Drawing.Point(133, 124)
        Me.checkboxExcluyeDelTotal.Name = "checkboxExcluyeDelTotal"
        Me.checkboxExcluyeDelTotal.Size = New System.Drawing.Size(15, 14)
        Me.checkboxExcluyeDelTotal.TabIndex = 9
        Me.checkboxExcluyeDelTotal.UseVisualStyleBackColor = True
        '
        'checkboxEsPresente
        '
        Me.checkboxEsPresente.AutoSize = True
        Me.checkboxEsPresente.Location = New System.Drawing.Point(133, 76)
        Me.checkboxEsPresente.Name = "checkboxEsPresente"
        Me.checkboxEsPresente.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsPresente.TabIndex = 5
        Me.checkboxEsPresente.UseVisualStyleBackColor = True
        '
        'checkboxEsAusenciaJustificada
        '
        Me.checkboxEsAusenciaJustificada.AutoSize = True
        Me.checkboxEsAusenciaJustificada.Location = New System.Drawing.Point(133, 100)
        Me.checkboxEsAusenciaJustificada.Name = "checkboxEsAusenciaJustificada"
        Me.checkboxEsAusenciaJustificada.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsAusenciaJustificada.TabIndex = 7
        Me.checkboxEsAusenciaJustificada.UseVisualStyleBackColor = True
        '
        'labelOrden
        '
        Me.labelOrden.AutoSize = True
        Me.labelOrden.Location = New System.Drawing.Point(6, 152)
        Me.labelOrden.Name = "labelOrden"
        Me.labelOrden.Size = New System.Drawing.Size(39, 13)
        Me.labelOrden.TabIndex = 10
        Me.labelOrden.Text = "Orden:"
        '
        'labelExcluyeDelTotal
        '
        Me.labelExcluyeDelTotal.AutoSize = True
        Me.labelExcluyeDelTotal.Location = New System.Drawing.Point(6, 126)
        Me.labelExcluyeDelTotal.Name = "labelExcluyeDelTotal"
        Me.labelExcluyeDelTotal.Size = New System.Drawing.Size(87, 13)
        Me.labelExcluyeDelTotal.TabIndex = 8
        Me.labelExcluyeDelTotal.Text = "Excluye del total:"
        '
        'labelEsAusenciaJustificada
        '
        Me.labelEsAusenciaJustificada.AutoSize = True
        Me.labelEsAusenciaJustificada.Location = New System.Drawing.Point(6, 100)
        Me.labelEsAusenciaJustificada.Name = "labelEsAusenciaJustificada"
        Me.labelEsAusenciaJustificada.Size = New System.Drawing.Size(118, 13)
        Me.labelEsAusenciaJustificada.TabIndex = 6
        Me.labelEsAusenciaJustificada.Text = "Es ausencia justificada:"
        '
        'labelEsPresente
        '
        Me.labelEsPresente.AutoSize = True
        Me.labelEsPresente.Location = New System.Drawing.Point(6, 74)
        Me.labelEsPresente.Name = "labelEsPresente"
        Me.labelEsPresente.Size = New System.Drawing.Size(66, 13)
        Me.labelEsPresente.TabIndex = 4
        Me.labelEsPresente.Text = "Es presente:"
        '
        'textboxAbreviatura
        '
        Me.textboxAbreviatura.Location = New System.Drawing.Point(133, 45)
        Me.textboxAbreviatura.MaxLength = 5
        Me.textboxAbreviatura.Name = "textboxAbreviatura"
        Me.textboxAbreviatura.Size = New System.Drawing.Size(53, 20)
        Me.textboxAbreviatura.TabIndex = 3
        '
        'labelAbreviatura
        '
        Me.labelAbreviatura.AutoSize = True
        Me.labelAbreviatura.Location = New System.Drawing.Point(6, 48)
        Me.labelAbreviatura.Name = "labelAbreviatura"
        Me.labelAbreviatura.Size = New System.Drawing.Size(64, 13)
        Me.labelAbreviatura.TabIndex = 2
        Me.labelAbreviatura.Text = "Abreviatura:"
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(133, 19)
        Me.textboxNombre.MaxLength = 50
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(372, 20)
        Me.textboxNombre.TabIndex = 1
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Location = New System.Drawing.Point(6, 22)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(47, 13)
        Me.labelNombre.TabIndex = 0
        Me.labelNombre.Text = "Nombre:"
        '
        'tabpagePuntajes
        '
        Me.tabpagePuntajes.Controls.Add(Me.datagridviewPuntajes)
        Me.tabpagePuntajes.Controls.Add(Me.toolstripPuntajes)
        Me.tabpagePuntajes.Location = New System.Drawing.Point(4, 25)
        Me.tabpagePuntajes.Name = "tabpagePuntajes"
        Me.tabpagePuntajes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpagePuntajes.Size = New System.Drawing.Size(569, 242)
        Me.tabpagePuntajes.TabIndex = 2
        Me.tabpagePuntajes.Text = "Puntajes"
        Me.tabpagePuntajes.UseVisualStyleBackColor = True
        '
        'datagridviewPuntajes
        '
        Me.datagridviewPuntajes.AllowUserToAddRows = False
        Me.datagridviewPuntajes.AllowUserToDeleteRows = False
        Me.datagridviewPuntajes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewPuntajes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewPuntajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewPuntajes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnFechaInicio, Me.columnPuntajeClaveVerde, Me.columnPuntajeClaveAzul, Me.columnPuntajeClaveNaranja, Me.columnPuntajeClaveRoja, Me.columnPorcentajeDescuentoPorSalidaAnticipada})
        Me.datagridviewPuntajes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewPuntajes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewPuntajes.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewPuntajes.MultiSelect = False
        Me.datagridviewPuntajes.Name = "datagridviewPuntajes"
        Me.datagridviewPuntajes.ReadOnly = True
        Me.datagridviewPuntajes.RowHeadersVisible = False
        Me.datagridviewPuntajes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewPuntajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewPuntajes.Size = New System.Drawing.Size(476, 236)
        Me.datagridviewPuntajes.TabIndex = 10
        '
        'toolstripPuntajes
        '
        Me.toolstripPuntajes.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripPuntajes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripPuntajes.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripPuntajes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonPuntajesAgregar, Me.buttonPuntajesEditar, Me.buttonPuntajesEliminar})
        Me.toolstripPuntajes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripPuntajes.Location = New System.Drawing.Point(3, 3)
        Me.toolstripPuntajes.Name = "toolstripPuntajes"
        Me.toolstripPuntajes.Size = New System.Drawing.Size(87, 236)
        Me.toolstripPuntajes.TabIndex = 11
        '
        'buttonPuntajesAgregar
        '
        Me.buttonPuntajesAgregar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonPuntajesAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPuntajesAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonPuntajesAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonPuntajesAgregar.Name = "buttonPuntajesAgregar"
        Me.buttonPuntajesAgregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonPuntajesAgregar.Text = "Agregar"
        '
        'buttonPuntajesEditar
        '
        Me.buttonPuntajesEditar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonPuntajesEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPuntajesEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonPuntajesEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonPuntajesEditar.Name = "buttonPuntajesEditar"
        Me.buttonPuntajesEditar.Size = New System.Drawing.Size(84, 36)
        Me.buttonPuntajesEditar.Text = "Editar"
        '
        'buttonPuntajesEliminar
        '
        Me.buttonPuntajesEliminar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonPuntajesEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPuntajesEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonPuntajesEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonPuntajesEliminar.Name = "buttonPuntajesEliminar"
        Me.buttonPuntajesEliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonPuntajesEliminar.Text = "Eliminar"
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelID)
        Me.tabpageNotasAuditoria.Controls.Add(Me.checkboxEsActivo)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxID)
        Me.tabpageNotasAuditoria.Controls.Add(labelEsActivo)
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(569, 242)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelID
        '
        Me.labelID.AutoSize = True
        Me.labelID.Location = New System.Drawing.Point(7, 111)
        Me.labelID.Name = "labelID"
        Me.labelID.Size = New System.Drawing.Size(21, 13)
        Me.labelID.TabIndex = 4
        Me.labelID.Text = "ID:"
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(116, 137)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 3
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'textboxID
        '
        Me.textboxID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxID.Location = New System.Drawing.Point(115, 161)
        Me.textboxID.MaxLength = 10
        Me.textboxID.Name = "textboxID"
        Me.textboxID.ReadOnly = True
        Me.textboxID.Size = New System.Drawing.Size(72, 20)
        Me.textboxID.TabIndex = 5
        Me.textboxID.TabStop = False
        Me.textboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(242, 213)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 11
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(242, 187)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 8
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(115, 213)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 10
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(115, 187)
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
        Me.textboxNotas.Location = New System.Drawing.Point(116, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(444, 125)
        Me.textboxNotas.TabIndex = 1
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(6, 9)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 0
        Me.labelNotas.Text = "Notas:"
        '
        'columnFechaInicio
        '
        Me.columnFechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnFechaInicio.DataPropertyName = "FechaInicio"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.columnFechaInicio.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnFechaInicio.HeaderText = "Fecha de inicio"
        Me.columnFechaInicio.Name = "columnFechaInicio"
        Me.columnFechaInicio.ReadOnly = True
        Me.columnFechaInicio.Width = 74
        '
        'columnPuntajeClaveVerde
        '
        Me.columnPuntajeClaveVerde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnPuntajeClaveVerde.DataPropertyName = "PuntajeClaveVerde"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.columnPuntajeClaveVerde.DefaultCellStyle = DataGridViewCellStyle3
        Me.columnPuntajeClaveVerde.HeaderText = "Verde"
        Me.columnPuntajeClaveVerde.Name = "columnPuntajeClaveVerde"
        Me.columnPuntajeClaveVerde.ReadOnly = True
        Me.columnPuntajeClaveVerde.Width = 60
        '
        'columnPuntajeClaveAzul
        '
        Me.columnPuntajeClaveAzul.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnPuntajeClaveAzul.DataPropertyName = "PuntajeClaveAzul"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.columnPuntajeClaveAzul.DefaultCellStyle = DataGridViewCellStyle4
        Me.columnPuntajeClaveAzul.HeaderText = "Azul"
        Me.columnPuntajeClaveAzul.Name = "columnPuntajeClaveAzul"
        Me.columnPuntajeClaveAzul.ReadOnly = True
        Me.columnPuntajeClaveAzul.Width = 52
        '
        'columnPuntajeClaveNaranja
        '
        Me.columnPuntajeClaveNaranja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnPuntajeClaveNaranja.DataPropertyName = "PuntajeClaveNaranja"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.columnPuntajeClaveNaranja.DefaultCellStyle = DataGridViewCellStyle5
        Me.columnPuntajeClaveNaranja.HeaderText = "Naranja"
        Me.columnPuntajeClaveNaranja.Name = "columnPuntajeClaveNaranja"
        Me.columnPuntajeClaveNaranja.ReadOnly = True
        Me.columnPuntajeClaveNaranja.Width = 69
        '
        'columnPuntajeClaveRoja
        '
        Me.columnPuntajeClaveRoja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnPuntajeClaveRoja.DataPropertyName = "PuntajeClaveRoja"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.columnPuntajeClaveRoja.DefaultCellStyle = DataGridViewCellStyle6
        Me.columnPuntajeClaveRoja.HeaderText = "Roja"
        Me.columnPuntajeClaveRoja.Name = "columnPuntajeClaveRoja"
        Me.columnPuntajeClaveRoja.ReadOnly = True
        Me.columnPuntajeClaveRoja.Width = 54
        '
        'columnPorcentajeDescuentoPorSalidaAnticipada
        '
        Me.columnPorcentajeDescuentoPorSalidaAnticipada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnPorcentajeDescuentoPorSalidaAnticipada.DataPropertyName = "PorcentajeDescuentoPorSalidaAnticipada"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.columnPorcentajeDescuentoPorSalidaAnticipada.DefaultCellStyle = DataGridViewCellStyle7
        Me.columnPorcentajeDescuentoPorSalidaAnticipada.HeaderText = "% descuento por salida anticipada"
        Me.columnPorcentajeDescuentoPorSalidaAnticipada.Name = "columnPorcentajeDescuentoPorSalidaAnticipada"
        Me.columnPorcentajeDescuentoPorSalidaAnticipada.ReadOnly = True
        Me.columnPorcentajeDescuentoPorSalidaAnticipada.Width = 132
        '
        'formSiniestroAsistenciaTipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 325)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formSiniestroAsistenciaTipo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tipo de asistencia a siniestro"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        CType(Me.updownOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpagePuntajes.ResumeLayout(False)
        Me.tabpagePuntajes.PerformLayout()
        CType(Me.datagridviewPuntajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripPuntajes.ResumeLayout(False)
        Me.toolstripPuntajes.PerformLayout()
        Me.tabpageNotasAuditoria.ResumeLayout(False)
        Me.tabpageNotasAuditoria.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textboxNombre As System.Windows.Forms.TextBox
    Friend WithEvents labelNombre As System.Windows.Forms.Label
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents checkboxEsActivo As System.Windows.Forms.CheckBox
    Friend WithEvents tabcontrolMain As CS_Control_TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents labelID As System.Windows.Forms.Label
    Friend WithEvents textboxID As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents labelExcluyeDelTotal As Label
    Friend WithEvents labelEsAusenciaJustificada As Label
    Friend WithEvents labelEsPresente As Label
    Friend WithEvents textboxAbreviatura As TextBox
    Friend WithEvents labelAbreviatura As Label
    Friend WithEvents labelOrden As Label
    Friend WithEvents checkboxEsAusenciaJustificada As CheckBox
    Friend WithEvents checkboxExcluyeDelTotal As CheckBox
    Friend WithEvents checkboxEsPresente As CheckBox
    Friend WithEvents updownOrden As NumericUpDown
    Friend WithEvents tabpagePuntajes As TabPage
    Friend WithEvents datagridviewPuntajes As DataGridView
    Friend WithEvents toolstripPuntajes As ToolStrip
    Friend WithEvents buttonPuntajesAgregar As ToolStripButton
    Friend WithEvents buttonPuntajesEditar As ToolStripButton
    Friend WithEvents buttonPuntajesEliminar As ToolStripButton
    Friend WithEvents columnFechaInicio As DataGridViewTextBoxColumn
    Friend WithEvents columnPuntajeClaveVerde As DataGridViewTextBoxColumn
    Friend WithEvents columnPuntajeClaveAzul As DataGridViewTextBoxColumn
    Friend WithEvents columnPuntajeClaveNaranja As DataGridViewTextBoxColumn
    Friend WithEvents columnPuntajeClaveRoja As DataGridViewTextBoxColumn
    Friend WithEvents columnPorcentajeDescuentoPorSalidaAnticipada As DataGridViewTextBoxColumn
End Class
