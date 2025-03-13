<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSiniestroAsistencia
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
        Me.components = New System.ComponentModel.Container()
        Dim labelCuartel As System.Windows.Forms.Label
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.labelPersona = New System.Windows.Forms.Label()
        Me.labelNumero = New System.Windows.Forms.Label()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.textboxNumeroCompleto = New System.Windows.Forms.TextBox()
        Me.textboxCuartel = New System.Windows.Forms.TextBox()
        Me.textboxFecha = New System.Windows.Forms.TextBox()
        Me.labelAsistenciaTipo = New System.Windows.Forms.Label()
        Me.tooltipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.panelAsistencia = New System.Windows.Forms.FlowLayoutPanel()
        Me.controlpersonaPersona = New CSBomberos.ControlPersona()
        Me.checkBoxContinuarAlta = New System.Windows.Forms.CheckBox()
        labelCuartel = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelCuartel
        '
        labelCuartel.AutoSize = True
        labelCuartel.Location = New System.Drawing.Point(16, 66)
        labelCuartel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        labelCuartel.Name = "labelCuartel"
        labelCuartel.Size = New System.Drawing.Size(52, 16)
        labelCuartel.TabIndex = 6
        labelCuartel.Text = "Cuartel:"
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = Global.CSBomberos.My.Resources.Resources.ImageAceptar32
        Me.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(98, 36)
        Me.buttonGuardar.Text = "Guardar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.CSBomberos.My.Resources.Resources.ImageCancelar32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(102, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.CSBomberos.My.Resources.Resources.ImageEditar32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(84, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSBomberos.My.Resources.Resources.ImageCerrar32
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
        Me.toolstripMain.Size = New System.Drawing.Size(616, 39)
        Me.toolstripMain.TabIndex = 5
        '
        'labelPersona
        '
        Me.labelPersona.AutoSize = True
        Me.labelPersona.Location = New System.Drawing.Point(16, 180)
        Me.labelPersona.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelPersona.Name = "labelPersona"
        Me.labelPersona.Size = New System.Drawing.Size(61, 16)
        Me.labelPersona.TabIndex = 0
        Me.labelPersona.Text = "Persona:"
        '
        'labelNumero
        '
        Me.labelNumero.AutoSize = True
        Me.labelNumero.Location = New System.Drawing.Point(16, 98)
        Me.labelNumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNumero.Name = "labelNumero"
        Me.labelNumero.Size = New System.Drawing.Size(58, 16)
        Me.labelNumero.TabIndex = 8
        Me.labelNumero.Text = "Número:"
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(16, 130)
        Me.labelFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(48, 16)
        Me.labelFecha.TabIndex = 10
        Me.labelFecha.Text = "Fecha:"
        '
        'textboxNumeroCompleto
        '
        Me.textboxNumeroCompleto.Location = New System.Drawing.Point(101, 95)
        Me.textboxNumeroCompleto.Margin = New System.Windows.Forms.Padding(4)
        Me.textboxNumeroCompleto.Name = "textboxNumeroCompleto"
        Me.textboxNumeroCompleto.ReadOnly = True
        Me.textboxNumeroCompleto.Size = New System.Drawing.Size(132, 22)
        Me.textboxNumeroCompleto.TabIndex = 9
        '
        'textboxCuartel
        '
        Me.textboxCuartel.Location = New System.Drawing.Point(101, 63)
        Me.textboxCuartel.Margin = New System.Windows.Forms.Padding(4)
        Me.textboxCuartel.Name = "textboxCuartel"
        Me.textboxCuartel.ReadOnly = True
        Me.textboxCuartel.Size = New System.Drawing.Size(365, 22)
        Me.textboxCuartel.TabIndex = 7
        '
        'textboxFecha
        '
        Me.textboxFecha.Location = New System.Drawing.Point(101, 127)
        Me.textboxFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.textboxFecha.Name = "textboxFecha"
        Me.textboxFecha.ReadOnly = True
        Me.textboxFecha.Size = New System.Drawing.Size(132, 22)
        Me.textboxFecha.TabIndex = 11
        '
        'labelAsistenciaTipo
        '
        Me.labelAsistenciaTipo.AutoSize = True
        Me.labelAsistenciaTipo.Location = New System.Drawing.Point(16, 233)
        Me.labelAsistenciaTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelAsistenciaTipo.Name = "labelAsistenciaTipo"
        Me.labelAsistenciaTipo.Size = New System.Drawing.Size(72, 16)
        Me.labelAsistenciaTipo.TabIndex = 2
        Me.labelAsistenciaTipo.Text = "Asistencia:"
        '
        'panelAsistencia
        '
        Me.panelAsistencia.Location = New System.Drawing.Point(101, 223)
        Me.panelAsistencia.Margin = New System.Windows.Forms.Padding(4)
        Me.panelAsistencia.Name = "panelAsistencia"
        Me.panelAsistencia.Size = New System.Drawing.Size(499, 44)
        Me.panelAsistencia.TabIndex = 3
        '
        'controlpersonaPersona
        '
        Me.controlpersonaPersona.ApellidoNombre = Nothing
        Me.controlpersonaPersona.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.controlpersonaPersona.dbContext = Nothing
        Me.controlpersonaPersona.IDCuartel = Nothing
        Me.controlpersonaPersona.IDPersona = Nothing
        Me.controlpersonaPersona.Location = New System.Drawing.Point(101, 175)
        Me.controlpersonaPersona.Margin = New System.Windows.Forms.Padding(5)
        Me.controlpersonaPersona.MatriculaNumeroDigitos = Nothing
        Me.controlpersonaPersona.MaximumSize = New System.Drawing.Size(1333, 26)
        Me.controlpersonaPersona.MinimumSize = New System.Drawing.Size(200, 26)
        Me.controlpersonaPersona.Name = "controlpersonaPersona"
        Me.controlpersonaPersona.ReadOnlyText = False
        Me.controlpersonaPersona.Size = New System.Drawing.Size(501, 26)
        Me.controlpersonaPersona.SoloMostrarEnAsistencia = True
        Me.controlpersonaPersona.SoloMostrarEstadoActivo = True
        Me.controlpersonaPersona.TabIndex = 1
        '
        'checkBoxContinuarAlta
        '
        Me.checkBoxContinuarAlta.AutoSize = True
        Me.checkBoxContinuarAlta.Checked = True
        Me.checkBoxContinuarAlta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBoxContinuarAlta.Location = New System.Drawing.Point(16, 15)
        Me.checkBoxContinuarAlta.Margin = New System.Windows.Forms.Padding(4)
        Me.checkBoxContinuarAlta.Name = "checkBoxContinuarAlta"
        Me.checkBoxContinuarAlta.Size = New System.Drawing.Size(85, 20)
        Me.checkBoxContinuarAlta.TabIndex = 4
        Me.checkBoxContinuarAlta.Text = "No cerrar"
        Me.checkBoxContinuarAlta.UseVisualStyleBackColor = True
        '
        'formSiniestroAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 284)
        Me.Controls.Add(Me.checkBoxContinuarAlta)
        Me.Controls.Add(Me.panelAsistencia)
        Me.Controls.Add(Me.controlpersonaPersona)
        Me.Controls.Add(Me.labelAsistenciaTipo)
        Me.Controls.Add(Me.textboxFecha)
        Me.Controls.Add(Me.textboxCuartel)
        Me.Controls.Add(Me.textboxNumeroCompleto)
        Me.Controls.Add(labelCuartel)
        Me.Controls.Add(Me.labelNumero)
        Me.Controls.Add(Me.labelFecha)
        Me.Controls.Add(Me.labelPersona)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formSiniestroAsistencia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Asistencia a Siniestro"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents labelPersona As Label
    Friend WithEvents labelNumero As Label
    Friend WithEvents labelFecha As Label
    Friend WithEvents textboxNumeroCompleto As TextBox
    Friend WithEvents textboxCuartel As TextBox
    Friend WithEvents textboxFecha As TextBox
    Friend WithEvents labelAsistenciaTipo As Label
    Friend WithEvents tooltipMain As ToolTip
    Friend WithEvents controlpersonaPersona As ControlPersona
    Friend WithEvents panelAsistencia As FlowLayoutPanel
    Friend WithEvents checkBoxContinuarAlta As CheckBox
End Class
