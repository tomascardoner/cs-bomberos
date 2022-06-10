<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaIdentificacionPin
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
        Me.labelIdentificacionPin = New System.Windows.Forms.Label()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.labelIdentificacionPinConfirma = New System.Windows.Forms.Label()
        Me.maskedtextboxIdentificacionPin = New System.Windows.Forms.MaskedTextBox()
        Me.maskedtextboxIdentificacionPinConfirma = New System.Windows.Forms.MaskedTextBox()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelIdentificacionPin
        '
        Me.labelIdentificacionPin.AutoSize = True
        Me.labelIdentificacionPin.Location = New System.Drawing.Point(11, 45)
        Me.labelIdentificacionPin.Name = "labelIdentificacionPin"
        Me.labelIdentificacionPin.Size = New System.Drawing.Size(28, 13)
        Me.labelIdentificacionPin.TabIndex = 0
        Me.labelIdentificacionPin.Text = "PIN:"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(184, 39)
        Me.toolstripMain.TabIndex = 4
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
        'labelIdentificacionPinConfirma
        '
        Me.labelIdentificacionPinConfirma.AutoSize = True
        Me.labelIdentificacionPinConfirma.Location = New System.Drawing.Point(11, 71)
        Me.labelIdentificacionPinConfirma.Name = "labelIdentificacionPinConfirma"
        Me.labelIdentificacionPinConfirma.Size = New System.Drawing.Size(72, 13)
        Me.labelIdentificacionPinConfirma.TabIndex = 2
        Me.labelIdentificacionPinConfirma.Text = "Confirma PIN:"
        '
        'maskedtextboxIdentificacionPin
        '
        Me.maskedtextboxIdentificacionPin.Location = New System.Drawing.Point(89, 42)
        Me.maskedtextboxIdentificacionPin.Mask = "0000"
        Me.maskedtextboxIdentificacionPin.Name = "maskedtextboxIdentificacionPin"
        Me.maskedtextboxIdentificacionPin.Size = New System.Drawing.Size(44, 20)
        Me.maskedtextboxIdentificacionPin.TabIndex = 1
        Me.maskedtextboxIdentificacionPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.maskedtextboxIdentificacionPin.UseSystemPasswordChar = True
        '
        'maskedtextboxIdentificacionPinConfirma
        '
        Me.maskedtextboxIdentificacionPinConfirma.Location = New System.Drawing.Point(89, 68)
        Me.maskedtextboxIdentificacionPinConfirma.Mask = "0000"
        Me.maskedtextboxIdentificacionPinConfirma.Name = "maskedtextboxIdentificacionPinConfirma"
        Me.maskedtextboxIdentificacionPinConfirma.Size = New System.Drawing.Size(44, 20)
        Me.maskedtextboxIdentificacionPinConfirma.TabIndex = 3
        Me.maskedtextboxIdentificacionPinConfirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.maskedtextboxIdentificacionPinConfirma.UseSystemPasswordChar = True
        '
        'formPersonaIdentificacionPin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 100)
        Me.ControlBox = False
        Me.Controls.Add(Me.maskedtextboxIdentificacionPinConfirma)
        Me.Controls.Add(Me.maskedtextboxIdentificacionPin)
        Me.Controls.Add(Me.labelIdentificacionPinConfirma)
        Me.Controls.Add(Me.toolstripMain)
        Me.Controls.Add(Me.labelIdentificacionPin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "formPersonaIdentificacionPin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PIN"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelIdentificacionPin As Label
    Friend WithEvents toolstripMain As ToolStrip
    Friend WithEvents buttonCancelar As ToolStripButton
    Friend WithEvents buttonGuardar As ToolStripButton
    Friend WithEvents labelIdentificacionPinConfirma As Label
    Friend WithEvents maskedtextboxIdentificacionPin As MaskedTextBox
    Friend WithEvents maskedtextboxIdentificacionPinConfirma As MaskedTextBox
End Class
