<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSiniestroAsistenciaPresencialConPin
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
        Me.labelPersona = New System.Windows.Forms.Label()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.maskedtextboxIdentificacionPin = New System.Windows.Forms.MaskedTextBox()
        Me.labelIdentificacionPin = New System.Windows.Forms.Label()
        Me.controlpersonaPersona = New CSBomberos.ControlPersona()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelPersona
        '
        Me.labelPersona.AutoSize = True
        Me.labelPersona.Location = New System.Drawing.Point(13, 62)
        Me.labelPersona.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelPersona.Name = "labelPersona"
        Me.labelPersona.Size = New System.Drawing.Size(61, 16)
        Me.labelPersona.TabIndex = 0
        Me.labelPersona.Text = "Persona:"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(613, 39)
        Me.toolstripMain.TabIndex = 4
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
        'maskedtextboxIdentificacionPin
        '
        Me.maskedtextboxIdentificacionPin.Location = New System.Drawing.Point(99, 90)
        Me.maskedtextboxIdentificacionPin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.maskedtextboxIdentificacionPin.Mask = "0000"
        Me.maskedtextboxIdentificacionPin.Name = "maskedtextboxIdentificacionPin"
        Me.maskedtextboxIdentificacionPin.Size = New System.Drawing.Size(57, 22)
        Me.maskedtextboxIdentificacionPin.TabIndex = 3
        Me.maskedtextboxIdentificacionPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.maskedtextboxIdentificacionPin.UseSystemPasswordChar = True
        '
        'labelIdentificacionPin
        '
        Me.labelIdentificacionPin.AutoSize = True
        Me.labelIdentificacionPin.Location = New System.Drawing.Point(16, 94)
        Me.labelIdentificacionPin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelIdentificacionPin.Name = "labelIdentificacionPin"
        Me.labelIdentificacionPin.Size = New System.Drawing.Size(32, 16)
        Me.labelIdentificacionPin.TabIndex = 2
        Me.labelIdentificacionPin.Text = "PIN:"
        '
        'controlpersonaPersona
        '
        Me.controlpersonaPersona.ApellidoNombre = Nothing
        Me.controlpersonaPersona.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.controlpersonaPersona.dbContext = Nothing
        Me.controlpersonaPersona.IDCuartel = Nothing
        Me.controlpersonaPersona.IDPersona = Nothing
        Me.controlpersonaPersona.Location = New System.Drawing.Point(99, 58)
        Me.controlpersonaPersona.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.controlpersonaPersona.MatriculaNumeroDigitos = Nothing
        Me.controlpersonaPersona.MaximumSize = New System.Drawing.Size(1333, 26)
        Me.controlpersonaPersona.MinimumSize = New System.Drawing.Size(200, 26)
        Me.controlpersonaPersona.Name = "controlpersonaPersona"
        Me.controlpersonaPersona.ReadOnlyText = False
        Me.controlpersonaPersona.Size = New System.Drawing.Size(499, 26)
        Me.controlpersonaPersona.SoloMostrarEnAsistencia = True
        Me.controlpersonaPersona.SoloMostrarEstadoActivo = True
        Me.controlpersonaPersona.TabIndex = 1
        '
        'formSiniestroAsistenciaPresencialConPin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 133)
        Me.Controls.Add(Me.controlpersonaPersona)
        Me.Controls.Add(Me.labelIdentificacionPin)
        Me.Controls.Add(Me.maskedtextboxIdentificacionPin)
        Me.Controls.Add(Me.toolstripMain)
        Me.Controls.Add(Me.labelPersona)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formSiniestroAsistenciaPresencialConPin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asistencia presencial a Siniestro con PIN"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelPersona As Label
    Friend WithEvents toolstripMain As ToolStrip
    Friend WithEvents buttonCancelar As ToolStripButton
    Friend WithEvents buttonGuardar As ToolStripButton
    Friend WithEvents maskedtextboxIdentificacionPin As MaskedTextBox
    Friend WithEvents labelIdentificacionPin As Label
    Friend WithEvents controlpersonaPersona As ControlPersona
End Class
