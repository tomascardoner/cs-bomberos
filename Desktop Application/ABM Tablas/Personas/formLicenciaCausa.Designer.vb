<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLicenciaCausa
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
        Dim labelEsActivo As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.tabcontrolMain = New CSBomberos.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.updownCantidadVecesMaximoTotal = New System.Windows.Forms.NumericUpDown()
        Me.labelCantidadVecesMaximoTotal = New System.Windows.Forms.Label()
        Me.updownCantidadVecesMaximoAnual = New System.Windows.Forms.NumericUpDown()
        Me.labelCantidadVecesMaximoAnual = New System.Windows.Forms.Label()
        Me.updownCantidadDiasMaximoAnual = New System.Windows.Forms.NumericUpDown()
        Me.labelCantidadDiasMaximoAnual = New System.Windows.Forms.Label()
        Me.updownCantidadDias = New System.Windows.Forms.NumericUpDown()
        Me.labelCantidadDias = New System.Windows.Forms.Label()
        Me.textboxNombreLegal = New System.Windows.Forms.TextBox()
        Me.labelNombreLegal = New System.Windows.Forms.Label()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.labelIDLicenciaCausa = New System.Windows.Forms.Label()
        Me.textboxIDLicenciaCausa = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        labelEsActivo = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        CType(Me.updownCantidadVecesMaximoTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownCantidadVecesMaximoAnual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownCantidadDiasMaximoAnual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownCantidadDias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelEsActivo
        '
        labelEsActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(7, 100)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 2
        labelEsActivo.Text = "Activo:"
        '
        'labelModificacion
        '
        labelModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(7, 178)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 9
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(7, 152)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 6
        labelCreacion.Text = "Creación:"
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(88, 19)
        Me.textboxNombre.MaxLength = 100
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(272, 20)
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
        Me.toolstripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(565, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(141, 99)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 3
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(543, 252)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.updownCantidadVecesMaximoTotal)
        Me.tabpageGeneral.Controls.Add(Me.labelCantidadVecesMaximoTotal)
        Me.tabpageGeneral.Controls.Add(Me.updownCantidadVecesMaximoAnual)
        Me.tabpageGeneral.Controls.Add(Me.labelCantidadVecesMaximoAnual)
        Me.tabpageGeneral.Controls.Add(Me.updownCantidadDiasMaximoAnual)
        Me.tabpageGeneral.Controls.Add(Me.labelCantidadDiasMaximoAnual)
        Me.tabpageGeneral.Controls.Add(Me.updownCantidadDias)
        Me.tabpageGeneral.Controls.Add(Me.labelCantidadDias)
        Me.tabpageGeneral.Controls.Add(Me.textboxNombreLegal)
        Me.tabpageGeneral.Controls.Add(Me.labelNombreLegal)
        Me.tabpageGeneral.Controls.Add(Me.textboxNombre)
        Me.tabpageGeneral.Controls.Add(Me.labelNombre)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(535, 223)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'updownCantidadVecesMaximoTotal
        '
        Me.updownCantidadVecesMaximoTotal.Location = New System.Drawing.Point(188, 196)
        Me.updownCantidadVecesMaximoTotal.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.updownCantidadVecesMaximoTotal.Name = "updownCantidadVecesMaximoTotal"
        Me.updownCantidadVecesMaximoTotal.Size = New System.Drawing.Size(55, 20)
        Me.updownCantidadVecesMaximoTotal.TabIndex = 11
        Me.updownCantidadVecesMaximoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelCantidadVecesMaximoTotal
        '
        Me.labelCantidadVecesMaximoTotal.AutoSize = True
        Me.labelCantidadVecesMaximoTotal.Location = New System.Drawing.Point(6, 198)
        Me.labelCantidadVecesMaximoTotal.Name = "labelCantidadVecesMaximoTotal"
        Me.labelCantidadVecesMaximoTotal.Size = New System.Drawing.Size(166, 13)
        Me.labelCantidadVecesMaximoTotal.TabIndex = 10
        Me.labelCantidadVecesMaximoTotal.Text = "Máximo cantidad de veces (total):"
        '
        'updownCantidadVecesMaximoAnual
        '
        Me.updownCantidadVecesMaximoAnual.Location = New System.Drawing.Point(188, 160)
        Me.updownCantidadVecesMaximoAnual.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.updownCantidadVecesMaximoAnual.Name = "updownCantidadVecesMaximoAnual"
        Me.updownCantidadVecesMaximoAnual.Size = New System.Drawing.Size(55, 20)
        Me.updownCantidadVecesMaximoAnual.TabIndex = 9
        Me.updownCantidadVecesMaximoAnual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelCantidadVecesMaximoAnual
        '
        Me.labelCantidadVecesMaximoAnual.AutoSize = True
        Me.labelCantidadVecesMaximoAnual.Location = New System.Drawing.Point(6, 162)
        Me.labelCantidadVecesMaximoAnual.Name = "labelCantidadVecesMaximoAnual"
        Me.labelCantidadVecesMaximoAnual.Size = New System.Drawing.Size(176, 13)
        Me.labelCantidadVecesMaximoAnual.TabIndex = 8
        Me.labelCantidadVecesMaximoAnual.Text = "Máxima cantidad de veces por año:"
        '
        'updownCantidadDiasMaximoAnual
        '
        Me.updownCantidadDiasMaximoAnual.Location = New System.Drawing.Point(188, 124)
        Me.updownCantidadDiasMaximoAnual.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.updownCantidadDiasMaximoAnual.Name = "updownCantidadDiasMaximoAnual"
        Me.updownCantidadDiasMaximoAnual.Size = New System.Drawing.Size(55, 20)
        Me.updownCantidadDiasMaximoAnual.TabIndex = 7
        Me.updownCantidadDiasMaximoAnual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelCantidadDiasMaximoAnual
        '
        Me.labelCantidadDiasMaximoAnual.AutoSize = True
        Me.labelCantidadDiasMaximoAnual.Location = New System.Drawing.Point(6, 126)
        Me.labelCantidadDiasMaximoAnual.Name = "labelCantidadDiasMaximoAnual"
        Me.labelCantidadDiasMaximoAnual.Size = New System.Drawing.Size(168, 13)
        Me.labelCantidadDiasMaximoAnual.TabIndex = 6
        Me.labelCantidadDiasMaximoAnual.Text = "Máxima cantidad de días por año:"
        '
        'updownCantidadDias
        '
        Me.updownCantidadDias.Location = New System.Drawing.Point(188, 88)
        Me.updownCantidadDias.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.updownCantidadDias.Name = "updownCantidadDias"
        Me.updownCantidadDias.Size = New System.Drawing.Size(55, 20)
        Me.updownCantidadDias.TabIndex = 5
        Me.updownCantidadDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelCantidadDias
        '
        Me.labelCantidadDias.AutoSize = True
        Me.labelCantidadDias.Location = New System.Drawing.Point(6, 90)
        Me.labelCantidadDias.Name = "labelCantidadDias"
        Me.labelCantidadDias.Size = New System.Drawing.Size(91, 13)
        Me.labelCantidadDias.TabIndex = 4
        Me.labelCantidadDias.Text = "Cantidad de días:"
        '
        'textboxNombreLegal
        '
        Me.textboxNombreLegal.Location = New System.Drawing.Point(88, 53)
        Me.textboxNombreLegal.MaxLength = 200
        Me.textboxNombreLegal.Name = "textboxNombreLegal"
        Me.textboxNombreLegal.Size = New System.Drawing.Size(441, 20)
        Me.textboxNombreLegal.TabIndex = 3
        '
        'labelNombreLegal
        '
        Me.labelNombreLegal.AutoSize = True
        Me.labelNombreLegal.Location = New System.Drawing.Point(6, 56)
        Me.labelNombreLegal.Name = "labelNombreLegal"
        Me.labelNombreLegal.Size = New System.Drawing.Size(72, 13)
        Me.labelNombreLegal.TabIndex = 2
        Me.labelNombreLegal.Text = "Nombre legal:"
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelIDLicenciaCausa)
        Me.tabpageNotasAuditoria.Controls.Add(Me.checkboxEsActivo)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxIDLicenciaCausa)
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(535, 223)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelIDLicenciaCausa
        '
        Me.labelIDLicenciaCausa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelIDLicenciaCausa.AutoSize = True
        Me.labelIDLicenciaCausa.Location = New System.Drawing.Point(7, 126)
        Me.labelIDLicenciaCausa.Name = "labelIDLicenciaCausa"
        Me.labelIDLicenciaCausa.Size = New System.Drawing.Size(127, 13)
        Me.labelIDLicenciaCausa.TabIndex = 4
        Me.labelIDLicenciaCausa.Text = "ID de Causa de Licencia:"
        '
        'textboxIDLicenciaCausa
        '
        Me.textboxIDLicenciaCausa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxIDLicenciaCausa.Location = New System.Drawing.Point(140, 123)
        Me.textboxIDLicenciaCausa.MaxLength = 10
        Me.textboxIDLicenciaCausa.Name = "textboxIDLicenciaCausa"
        Me.textboxIDLicenciaCausa.ReadOnly = True
        Me.textboxIDLicenciaCausa.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDLicenciaCausa.TabIndex = 5
        Me.textboxIDLicenciaCausa.TabStop = False
        Me.textboxIDLicenciaCausa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(267, 175)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 11
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(267, 149)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 8
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(140, 175)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 10
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(140, 149)
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
        Me.textboxNotas.Location = New System.Drawing.Point(141, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(386, 87)
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
        'formLicenciaCausa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 306)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formLicenciaCausa"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Causa de Licencia"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        CType(Me.updownCantidadVecesMaximoTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownCantidadVecesMaximoAnual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownCantidadDiasMaximoAnual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownCantidadDias, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents labelIDLicenciaCausa As System.Windows.Forms.Label
    Friend WithEvents textboxIDLicenciaCausa As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxNombreLegal As System.Windows.Forms.TextBox
    Friend WithEvents labelNombreLegal As System.Windows.Forms.Label
    Friend WithEvents updownCantidadDias As System.Windows.Forms.NumericUpDown
    Friend WithEvents labelCantidadDias As System.Windows.Forms.Label
    Friend WithEvents updownCantidadVecesMaximoAnual As NumericUpDown
    Friend WithEvents labelCantidadVecesMaximoAnual As Label
    Friend WithEvents updownCantidadDiasMaximoAnual As NumericUpDown
    Friend WithEvents labelCantidadDiasMaximoAnual As Label
    Friend WithEvents updownCantidadVecesMaximoTotal As NumericUpDown
    Friend WithEvents labelCantidadVecesMaximoTotal As Label
End Class
