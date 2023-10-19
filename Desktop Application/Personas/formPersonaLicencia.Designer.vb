<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaLicencia
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
        Dim labelCausa As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.datetimepickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.comboboxCausa = New System.Windows.Forms.ComboBox()
        Me.tabcontrolMain = New CSBomberos.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.labelDiasEfectivos = New System.Windows.Forms.Label()
        Me.labelLabelDiasEfectivos = New System.Windows.Forms.Label()
        Me.datetimepickerFechaInterrupcion = New System.Windows.Forms.DateTimePicker()
        Me.labelFechaInterrupcion = New System.Windows.Forms.Label()
        Me.datetimepickerFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.labelFechaHasta = New System.Windows.Forms.Label()
        Me.datetimepickerFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.labelFechaDesde = New System.Windows.Forms.Label()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.labelIDLicencia = New System.Windows.Forms.Label()
        Me.textboxIDLicencia = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        labelCausa = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelCausa
        '
        labelCausa.AutoSize = True
        labelCausa.Location = New System.Drawing.Point(6, 49)
        labelCausa.Name = "labelCausa"
        labelCausa.Size = New System.Drawing.Size(40, 13)
        labelCausa.TabIndex = 2
        labelCausa.Text = "Causa:"
        '
        'labelModificacion
        '
        labelModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 169)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 21
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 143)
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
        'datetimepickerFecha
        '
        Me.datetimepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFecha.Location = New System.Drawing.Point(125, 13)
        Me.datetimepickerFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFecha.Name = "datetimepickerFecha"
        Me.datetimepickerFecha.Size = New System.Drawing.Size(116, 20)
        Me.datetimepickerFecha.TabIndex = 1
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(6, 16)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelFecha.TabIndex = 0
        Me.labelFecha.Text = "Fecha:"
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
        Me.textboxNotas.Size = New System.Drawing.Size(410, 102)
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
        'comboboxCausa
        '
        Me.comboboxCausa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCausa.FormattingEnabled = True
        Me.comboboxCausa.Location = New System.Drawing.Point(125, 46)
        Me.comboboxCausa.Name = "comboboxCausa"
        Me.comboboxCausa.Size = New System.Drawing.Size(379, 21)
        Me.comboboxCausa.TabIndex = 3
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(0, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(542, 244)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.labelDiasEfectivos)
        Me.tabpageGeneral.Controls.Add(Me.labelLabelDiasEfectivos)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFechaInterrupcion)
        Me.tabpageGeneral.Controls.Add(Me.labelFechaInterrupcion)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFechaHasta)
        Me.tabpageGeneral.Controls.Add(Me.labelFechaHasta)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFechaDesde)
        Me.tabpageGeneral.Controls.Add(Me.labelFechaDesde)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFecha)
        Me.tabpageGeneral.Controls.Add(Me.labelFecha)
        Me.tabpageGeneral.Controls.Add(labelCausa)
        Me.tabpageGeneral.Controls.Add(Me.comboboxCausa)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(534, 215)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'labelDiasEfectivos
        '
        Me.labelDiasEfectivos.AutoSize = True
        Me.labelDiasEfectivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDiasEfectivos.Location = New System.Drawing.Point(122, 187)
        Me.labelDiasEfectivos.Name = "labelDiasEfectivos"
        Me.labelDiasEfectivos.Size = New System.Drawing.Size(0, 13)
        Me.labelDiasEfectivos.TabIndex = 11
        '
        'labelLabelDiasEfectivos
        '
        Me.labelLabelDiasEfectivos.AutoSize = True
        Me.labelLabelDiasEfectivos.Location = New System.Drawing.Point(6, 187)
        Me.labelLabelDiasEfectivos.Name = "labelLabelDiasEfectivos"
        Me.labelLabelDiasEfectivos.Size = New System.Drawing.Size(79, 13)
        Me.labelLabelDiasEfectivos.TabIndex = 10
        Me.labelLabelDiasEfectivos.Text = "Días efectivos:"
        '
        'datetimepickerFechaInterrupcion
        '
        Me.datetimepickerFechaInterrupcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaInterrupcion.Location = New System.Drawing.Point(125, 151)
        Me.datetimepickerFechaInterrupcion.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaInterrupcion.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaInterrupcion.Name = "datetimepickerFechaInterrupcion"
        Me.datetimepickerFechaInterrupcion.ShowCheckBox = True
        Me.datetimepickerFechaInterrupcion.Size = New System.Drawing.Size(138, 20)
        Me.datetimepickerFechaInterrupcion.TabIndex = 9
        '
        'labelFechaInterrupcion
        '
        Me.labelFechaInterrupcion.AutoSize = True
        Me.labelFechaInterrupcion.Location = New System.Drawing.Point(6, 154)
        Me.labelFechaInterrupcion.Name = "labelFechaInterrupcion"
        Me.labelFechaInterrupcion.Size = New System.Drawing.Size(113, 13)
        Me.labelFechaInterrupcion.TabIndex = 8
        Me.labelFechaInterrupcion.Text = "Fecha de interrupción:"
        '
        'datetimepickerFechaHasta
        '
        Me.datetimepickerFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaHasta.Location = New System.Drawing.Point(125, 112)
        Me.datetimepickerFechaHasta.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaHasta.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaHasta.Name = "datetimepickerFechaHasta"
        Me.datetimepickerFechaHasta.Size = New System.Drawing.Size(116, 20)
        Me.datetimepickerFechaHasta.TabIndex = 7
        '
        'labelFechaHasta
        '
        Me.labelFechaHasta.AutoSize = True
        Me.labelFechaHasta.Location = New System.Drawing.Point(6, 115)
        Me.labelFechaHasta.Name = "labelFechaHasta"
        Me.labelFechaHasta.Size = New System.Drawing.Size(69, 13)
        Me.labelFechaHasta.TabIndex = 6
        Me.labelFechaHasta.Text = "Fecha hasta:"
        '
        'datetimepickerFechaDesde
        '
        Me.datetimepickerFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaDesde.Location = New System.Drawing.Point(125, 86)
        Me.datetimepickerFechaDesde.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaDesde.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaDesde.Name = "datetimepickerFechaDesde"
        Me.datetimepickerFechaDesde.Size = New System.Drawing.Size(116, 20)
        Me.datetimepickerFechaDesde.TabIndex = 5
        '
        'labelFechaDesde
        '
        Me.labelFechaDesde.AutoSize = True
        Me.labelFechaDesde.Location = New System.Drawing.Point(6, 89)
        Me.labelFechaDesde.Name = "labelFechaDesde"
        Me.labelFechaDesde.Size = New System.Drawing.Size(72, 13)
        Me.labelFechaDesde.TabIndex = 4
        Me.labelFechaDesde.Text = "Fecha desde:"
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelIDLicencia)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxIDLicencia)
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(534, 215)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelIDLicencia
        '
        Me.labelIDLicencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelIDLicencia.AutoSize = True
        Me.labelIDLicencia.Location = New System.Drawing.Point(6, 117)
        Me.labelIDLicencia.Name = "labelIDLicencia"
        Me.labelIDLicencia.Size = New System.Drawing.Size(79, 13)
        Me.labelIDLicencia.TabIndex = 16
        Me.labelIDLicencia.Text = "ID de Licencia:"
        '
        'textboxIDLicencia
        '
        Me.textboxIDLicencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxIDLicencia.Location = New System.Drawing.Point(114, 114)
        Me.textboxIDLicencia.MaxLength = 10
        Me.textboxIDLicencia.Name = "textboxIDLicencia"
        Me.textboxIDLicencia.ReadOnly = True
        Me.textboxIDLicencia.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDLicencia.TabIndex = 17
        Me.textboxIDLicencia.TabStop = False
        Me.textboxIDLicencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 166)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(283, 20)
        Me.textboxUsuarioModificacion.TabIndex = 23
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 140)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(283, 20)
        Me.textboxUsuarioCreacion.TabIndex = 20
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 166)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 22
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 140)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 19
        '
        'formPersonaLicencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 287)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPersonaLicencia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Licencia de la Persona"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
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
    Friend WithEvents datetimepickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelFecha As System.Windows.Forms.Label
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents comboboxCausa As System.Windows.Forms.ComboBox
    Friend WithEvents tabcontrolMain As CS_Control_TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents labelIDLicencia As System.Windows.Forms.Label
    Friend WithEvents textboxIDLicencia As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents datetimepickerFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelFechaHasta As System.Windows.Forms.Label
    Friend WithEvents datetimepickerFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelFechaDesde As System.Windows.Forms.Label
    Friend WithEvents datetimepickerFechaInterrupcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelFechaInterrupcion As System.Windows.Forms.Label
    Friend WithEvents labelLabelDiasEfectivos As Label
    Friend WithEvents labelDiasEfectivos As Label
End Class
