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
        Me.tabcontrolMain = New CSBomberos.DesktopApplication.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
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
        CType(Me.updownCantidadVecesMaximoAnual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownCantidadDiasMaximoAnual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownCantidadDias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelEsActivo
        '
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(9, 105)
        labelEsActivo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(50, 17)
        labelEsActivo.TabIndex = 2
        labelEsActivo.Text = "Activo:"
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(9, 201)
        labelModificacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(133, 17)
        labelModificacion.TabIndex = 9
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(9, 169)
        labelCreacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(68, 17)
        labelCreacion.TabIndex = 6
        labelCreacion.Text = "Creación:"
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(117, 23)
        Me.textboxNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxNombre.MaxLength = 100
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(361, 22)
        Me.textboxNombre.TabIndex = 1
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Location = New System.Drawing.Point(8, 27)
        Me.labelNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(62, 17)
        Me.labelNombre.TabIndex = 0
        Me.labelNombre.Text = "Nombre:"
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_OK_32
        Me.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(98, 36)
        Me.buttonGuardar.Text = "Guardar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_CANCEL_32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(102, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(84, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_CLOSE_32
        Me.buttonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCerrar.Name = "buttonCerrar"
        Me.buttonCerrar.Size = New System.Drawing.Size(85, 36)
        Me.buttonCerrar.Text = "Cerrar"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(753, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(188, 103)
        Me.checkboxEsActivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(18, 17)
        Me.checkboxEsActivo.TabIndex = 3
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(16, 52)
        Me.tabcontrolMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(724, 268)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
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
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 28)
        Me.tabpageGeneral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabpageGeneral.Size = New System.Drawing.Size(716, 236)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'updownCantidadVecesMaximoAnual
        '
        Me.updownCantidadVecesMaximoAnual.Location = New System.Drawing.Point(251, 196)
        Me.updownCantidadVecesMaximoAnual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.updownCantidadVecesMaximoAnual.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.updownCantidadVecesMaximoAnual.Name = "updownCantidadVecesMaximoAnual"
        Me.updownCantidadVecesMaximoAnual.Size = New System.Drawing.Size(73, 22)
        Me.updownCantidadVecesMaximoAnual.TabIndex = 9
        Me.updownCantidadVecesMaximoAnual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelCantidadVecesMaximoAnual
        '
        Me.labelCantidadVecesMaximoAnual.AutoSize = True
        Me.labelCantidadVecesMaximoAnual.Location = New System.Drawing.Point(8, 198)
        Me.labelCantidadVecesMaximoAnual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelCantidadVecesMaximoAnual.Name = "labelCantidadVecesMaximoAnual"
        Me.labelCantidadVecesMaximoAnual.Size = New System.Drawing.Size(231, 17)
        Me.labelCantidadVecesMaximoAnual.TabIndex = 8
        Me.labelCantidadVecesMaximoAnual.Text = "Máxima cantidad de veces por año:"
        '
        'updownCantidadDiasMaximoAnual
        '
        Me.updownCantidadDiasMaximoAnual.Location = New System.Drawing.Point(251, 153)
        Me.updownCantidadDiasMaximoAnual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.updownCantidadDiasMaximoAnual.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.updownCantidadDiasMaximoAnual.Name = "updownCantidadDiasMaximoAnual"
        Me.updownCantidadDiasMaximoAnual.Size = New System.Drawing.Size(73, 22)
        Me.updownCantidadDiasMaximoAnual.TabIndex = 7
        Me.updownCantidadDiasMaximoAnual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelCantidadDiasMaximoAnual
        '
        Me.labelCantidadDiasMaximoAnual.AutoSize = True
        Me.labelCantidadDiasMaximoAnual.Location = New System.Drawing.Point(8, 155)
        Me.labelCantidadDiasMaximoAnual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelCantidadDiasMaximoAnual.Name = "labelCantidadDiasMaximoAnual"
        Me.labelCantidadDiasMaximoAnual.Size = New System.Drawing.Size(220, 17)
        Me.labelCantidadDiasMaximoAnual.TabIndex = 6
        Me.labelCantidadDiasMaximoAnual.Text = "Máxima cantidad de días por año:"
        '
        'updownCantidadDias
        '
        Me.updownCantidadDias.Location = New System.Drawing.Point(251, 108)
        Me.updownCantidadDias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.updownCantidadDias.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.updownCantidadDias.Name = "updownCantidadDias"
        Me.updownCantidadDias.Size = New System.Drawing.Size(73, 22)
        Me.updownCantidadDias.TabIndex = 5
        Me.updownCantidadDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelCantidadDias
        '
        Me.labelCantidadDias.AutoSize = True
        Me.labelCantidadDias.Location = New System.Drawing.Point(8, 111)
        Me.labelCantidadDias.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelCantidadDias.Name = "labelCantidadDias"
        Me.labelCantidadDias.Size = New System.Drawing.Size(118, 17)
        Me.labelCantidadDias.TabIndex = 4
        Me.labelCantidadDias.Text = "Cantidad de días:"
        '
        'textboxNombreLegal
        '
        Me.textboxNombreLegal.Location = New System.Drawing.Point(117, 65)
        Me.textboxNombreLegal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxNombreLegal.MaxLength = 200
        Me.textboxNombreLegal.Name = "textboxNombreLegal"
        Me.textboxNombreLegal.Size = New System.Drawing.Size(587, 22)
        Me.textboxNombreLegal.TabIndex = 3
        '
        'labelNombreLegal
        '
        Me.labelNombreLegal.AutoSize = True
        Me.labelNombreLegal.Location = New System.Drawing.Point(8, 69)
        Me.labelNombreLegal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNombreLegal.Name = "labelNombreLegal"
        Me.labelNombreLegal.Size = New System.Drawing.Size(96, 17)
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
        Me.tabpageNotasAuditoria.Location = New System.Drawing.Point(4, 28)
        Me.tabpageNotasAuditoria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabpageNotasAuditoria.Name = "tabpageNotasAuditoria"
        Me.tabpageNotasAuditoria.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(716, 236)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelIDLicenciaCausa
        '
        Me.labelIDLicenciaCausa.AutoSize = True
        Me.labelIDLicenciaCausa.Location = New System.Drawing.Point(9, 137)
        Me.labelIDLicenciaCausa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelIDLicenciaCausa.Name = "labelIDLicenciaCausa"
        Me.labelIDLicenciaCausa.Size = New System.Drawing.Size(165, 17)
        Me.labelIDLicenciaCausa.TabIndex = 4
        Me.labelIDLicenciaCausa.Text = "ID de Causa de Licencia:"
        '
        'textboxIDLicenciaCausa
        '
        Me.textboxIDLicenciaCausa.Location = New System.Drawing.Point(187, 133)
        Me.textboxIDLicenciaCausa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxIDLicenciaCausa.MaxLength = 10
        Me.textboxIDLicenciaCausa.Name = "textboxIDLicenciaCausa"
        Me.textboxIDLicenciaCausa.ReadOnly = True
        Me.textboxIDLicenciaCausa.Size = New System.Drawing.Size(95, 22)
        Me.textboxIDLicenciaCausa.TabIndex = 5
        Me.textboxIDLicenciaCausa.TabStop = False
        Me.textboxIDLicenciaCausa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(356, 197)
        Me.textboxUsuarioModificacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(344, 22)
        Me.textboxUsuarioModificacion.TabIndex = 11
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(356, 165)
        Me.textboxUsuarioCreacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(344, 22)
        Me.textboxUsuarioCreacion.TabIndex = 8
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(187, 197)
        Me.textboxFechaHoraModificacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(160, 22)
        Me.textboxFechaHoraModificacion.TabIndex = 10
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(187, 165)
        Me.textboxFechaHoraCreacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(160, 22)
        Me.textboxFechaHoraCreacion.TabIndex = 7
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(188, 7)
        Me.textboxNotas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(513, 88)
        Me.textboxNotas.TabIndex = 1
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(8, 11)
        Me.labelNotas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(49, 17)
        Me.labelNotas.TabIndex = 0
        Me.labelNotas.Text = "Notas:"
        '
        'formLicenciaCausa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 335)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formLicenciaCausa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Causa de Licencia"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
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
    Friend WithEvents tabcontrolMain As CSBomberos.DesktopApplication.CS_Control_TabControl
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
End Class
