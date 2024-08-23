<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formResponsable
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
        Dim labelPersona As System.Windows.Forms.Label
        Me.labelResponsableTipo = New System.Windows.Forms.Label()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.tabcontrolMain = New System.Windows.Forms.TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.controlpersonaPersona = New CSBomberos.ControlPersona()
        Me.radiobuttonPersonaOtra = New System.Windows.Forms.RadioButton()
        Me.radiobuttonPersona = New System.Windows.Forms.RadioButton()
        Me.labelPersonaOtra = New System.Windows.Forms.Label()
        Me.textboxPersonaOtra = New System.Windows.Forms.TextBox()
        Me.comboboxResponsableTipo = New System.Windows.Forms.ComboBox()
        Me.comboboxCuartel = New System.Windows.Forms.ComboBox()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.labelID = New System.Windows.Forms.Label()
        Me.textboxID = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelCuartel = New System.Windows.Forms.Label()
        labelPersona = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(8, 139)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 7
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(8, 113)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 4
        labelCreacion.Text = "Creación:"
        '
        'labelCuartel
        '
        labelCuartel.AutoSize = True
        labelCuartel.Location = New System.Drawing.Point(6, 56)
        labelCuartel.Name = "labelCuartel"
        labelCuartel.Size = New System.Drawing.Size(43, 13)
        labelCuartel.TabIndex = 2
        labelCuartel.Text = "Cuartel:"
        '
        'labelPersona
        '
        labelPersona.AutoSize = True
        labelPersona.Location = New System.Drawing.Point(6, 92)
        labelPersona.Name = "labelPersona"
        labelPersona.Size = New System.Drawing.Size(49, 13)
        labelPersona.TabIndex = 4
        labelPersona.Text = "Persona:"
        '
        'labelResponsableTipo
        '
        Me.labelResponsableTipo.AutoSize = True
        Me.labelResponsableTipo.Location = New System.Drawing.Point(6, 20)
        Me.labelResponsableTipo.Name = "labelResponsableTipo"
        Me.labelResponsableTipo.Size = New System.Drawing.Size(31, 13)
        Me.labelResponsableTipo.TabIndex = 0
        Me.labelResponsableTipo.Text = "Tipo:"
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
        Me.toolstripMain.Size = New System.Drawing.Size(541, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(519, 196)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.controlpersonaPersona)
        Me.tabpageGeneral.Controls.Add(Me.radiobuttonPersonaOtra)
        Me.tabpageGeneral.Controls.Add(Me.radiobuttonPersona)
        Me.tabpageGeneral.Controls.Add(Me.labelPersonaOtra)
        Me.tabpageGeneral.Controls.Add(Me.textboxPersonaOtra)
        Me.tabpageGeneral.Controls.Add(labelPersona)
        Me.tabpageGeneral.Controls.Add(Me.comboboxResponsableTipo)
        Me.tabpageGeneral.Controls.Add(Me.comboboxCuartel)
        Me.tabpageGeneral.Controls.Add(labelCuartel)
        Me.tabpageGeneral.Controls.Add(Me.labelResponsableTipo)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(511, 167)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'controlpersonaPersona
        '
        Me.controlpersonaPersona.ApellidoNombre = Nothing
        Me.controlpersonaPersona.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.controlpersonaPersona.IDPersona = Nothing
        Me.controlpersonaPersona.Location = New System.Drawing.Point(87, 88)
        Me.controlpersonaPersona.MatriculaNumeroDigitos = Nothing
        Me.controlpersonaPersona.MaximumSize = New System.Drawing.Size(1000, 21)
        Me.controlpersonaPersona.MinimumSize = New System.Drawing.Size(150, 21)
        Me.controlpersonaPersona.Name = "controlpersonaPersona"
        Me.controlpersonaPersona.ReadOnlyText = False
        Me.controlpersonaPersona.Size = New System.Drawing.Size(418, 21)
        Me.controlpersonaPersona.TabIndex = 6
        '
        'radiobuttonPersonaOtra
        '
        Me.radiobuttonPersonaOtra.AutoSize = True
        Me.radiobuttonPersonaOtra.Location = New System.Drawing.Point(61, 119)
        Me.radiobuttonPersonaOtra.Name = "radiobuttonPersonaOtra"
        Me.radiobuttonPersonaOtra.Size = New System.Drawing.Size(14, 13)
        Me.radiobuttonPersonaOtra.TabIndex = 10
        Me.radiobuttonPersonaOtra.UseVisualStyleBackColor = True
        '
        'radiobuttonPersona
        '
        Me.radiobuttonPersona.AutoSize = True
        Me.radiobuttonPersona.Checked = True
        Me.radiobuttonPersona.Location = New System.Drawing.Point(61, 92)
        Me.radiobuttonPersona.Name = "radiobuttonPersona"
        Me.radiobuttonPersona.Size = New System.Drawing.Size(14, 13)
        Me.radiobuttonPersona.TabIndex = 5
        Me.radiobuttonPersona.TabStop = True
        Me.radiobuttonPersona.UseVisualStyleBackColor = True
        '
        'labelPersonaOtra
        '
        Me.labelPersonaOtra.AutoSize = True
        Me.labelPersonaOtra.Location = New System.Drawing.Point(6, 119)
        Me.labelPersonaOtra.Name = "labelPersonaOtra"
        Me.labelPersonaOtra.Size = New System.Drawing.Size(30, 13)
        Me.labelPersonaOtra.TabIndex = 9
        Me.labelPersonaOtra.Text = "Otra:"
        '
        'textboxPersonaOtra
        '
        Me.textboxPersonaOtra.Location = New System.Drawing.Point(87, 116)
        Me.textboxPersonaOtra.MaxLength = 100
        Me.textboxPersonaOtra.Name = "textboxPersonaOtra"
        Me.textboxPersonaOtra.Size = New System.Drawing.Size(418, 20)
        Me.textboxPersonaOtra.TabIndex = 11
        Me.textboxPersonaOtra.Visible = False
        '
        'comboboxResponsableTipo
        '
        Me.comboboxResponsableTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxResponsableTipo.FormattingEnabled = True
        Me.comboboxResponsableTipo.Location = New System.Drawing.Point(61, 17)
        Me.comboboxResponsableTipo.Name = "comboboxResponsableTipo"
        Me.comboboxResponsableTipo.Size = New System.Drawing.Size(444, 21)
        Me.comboboxResponsableTipo.TabIndex = 1
        '
        'comboboxCuartel
        '
        Me.comboboxCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCuartel.FormattingEnabled = True
        Me.comboboxCuartel.Location = New System.Drawing.Point(61, 53)
        Me.comboboxCuartel.Name = "comboboxCuartel"
        Me.comboboxCuartel.Size = New System.Drawing.Size(444, 21)
        Me.comboboxCuartel.TabIndex = 3
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelID)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxID)
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(511, 167)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelID
        '
        Me.labelID.AutoSize = True
        Me.labelID.Location = New System.Drawing.Point(8, 87)
        Me.labelID.Name = "labelID"
        Me.labelID.Size = New System.Drawing.Size(21, 13)
        Me.labelID.TabIndex = 2
        Me.labelID.Text = "ID:"
        '
        'textboxID
        '
        Me.textboxID.Location = New System.Drawing.Point(116, 84)
        Me.textboxID.MaxLength = 10
        Me.textboxID.Name = "textboxID"
        Me.textboxID.ReadOnly = True
        Me.textboxID.Size = New System.Drawing.Size(72, 20)
        Me.textboxID.TabIndex = 3
        Me.textboxID.TabStop = False
        Me.textboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(243, 136)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 9
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(243, 110)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 6
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(116, 136)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 8
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(116, 110)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 5
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(116, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(386, 72)
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
        'formResponsable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 247)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formResponsable"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Responsable"
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
    Friend WithEvents labelResponsableTipo As System.Windows.Forms.Label
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tabcontrolMain As System.Windows.Forms.TabControl
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
    Friend WithEvents comboboxCuartel As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxResponsableTipo As ComboBox
    Friend WithEvents labelPersonaOtra As Label
    Friend WithEvents textboxPersonaOtra As TextBox
    Friend WithEvents radiobuttonPersonaOtra As RadioButton
    Friend WithEvents radiobuttonPersona As RadioButton
    Friend WithEvents controlpersonaPersona As ControlPersona
End Class
