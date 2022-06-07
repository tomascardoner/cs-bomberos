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
        Me.integertextboxIdentificacionPin = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.labelIdentificacionPin = New System.Windows.Forms.Label()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.integertextboxIdentificacionPinConfirma = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.labelIdentificacionPinConfirma = New System.Windows.Forms.Label()
        CType(Me.integertextboxIdentificacionPin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripMain.SuspendLayout()
        CType(Me.integertextboxIdentificacionPinConfirma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'integertextboxIdentificacionPin
        '
        Me.integertextboxIdentificacionPin.AllowNull = True
        Me.integertextboxIdentificacionPin.BeforeTouchSize = New System.Drawing.Size(44, 20)
        Me.integertextboxIdentificacionPin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.integertextboxIdentificacionPin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.integertextboxIdentificacionPin.IntegerValue = CType(0, Long)
        Me.integertextboxIdentificacionPin.Location = New System.Drawing.Point(89, 42)
        Me.integertextboxIdentificacionPin.MaxValue = CType(9999, Long)
        Me.integertextboxIdentificacionPin.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.integertextboxIdentificacionPin.MinMaxValidation = Syncfusion.Windows.Forms.Tools.MinMaxValidation.OnLostFocus
        Me.integertextboxIdentificacionPin.MinValue = CType(0, Long)
        Me.integertextboxIdentificacionPin.Name = "integertextboxIdentificacionPin"
        Me.integertextboxIdentificacionPin.NullString = ""
        Me.integertextboxIdentificacionPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.integertextboxIdentificacionPin.Size = New System.Drawing.Size(44, 20)
        Me.integertextboxIdentificacionPin.TabIndex = 15
        Me.integertextboxIdentificacionPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.integertextboxIdentificacionPin.UseSystemPasswordChar = True
        '
        'labelIdentificacionPin
        '
        Me.labelIdentificacionPin.AutoSize = True
        Me.labelIdentificacionPin.Location = New System.Drawing.Point(11, 45)
        Me.labelIdentificacionPin.Name = "labelIdentificacionPin"
        Me.labelIdentificacionPin.Size = New System.Drawing.Size(28, 13)
        Me.labelIdentificacionPin.TabIndex = 14
        Me.labelIdentificacionPin.Text = "PIN:"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(184, 39)
        Me.toolstripMain.TabIndex = 16
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
        'integertextboxIdentificacionPinConfirma
        '
        Me.integertextboxIdentificacionPinConfirma.AllowNull = True
        Me.integertextboxIdentificacionPinConfirma.BeforeTouchSize = New System.Drawing.Size(44, 20)
        Me.integertextboxIdentificacionPinConfirma.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.integertextboxIdentificacionPinConfirma.ForeColor = System.Drawing.SystemColors.WindowText
        Me.integertextboxIdentificacionPinConfirma.IntegerValue = CType(0, Long)
        Me.integertextboxIdentificacionPinConfirma.Location = New System.Drawing.Point(89, 68)
        Me.integertextboxIdentificacionPinConfirma.MaxValue = CType(9999, Long)
        Me.integertextboxIdentificacionPinConfirma.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.integertextboxIdentificacionPinConfirma.MinMaxValidation = Syncfusion.Windows.Forms.Tools.MinMaxValidation.OnLostFocus
        Me.integertextboxIdentificacionPinConfirma.MinValue = CType(0, Long)
        Me.integertextboxIdentificacionPinConfirma.Name = "integertextboxIdentificacionPinConfirma"
        Me.integertextboxIdentificacionPinConfirma.NullString = ""
        Me.integertextboxIdentificacionPinConfirma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.integertextboxIdentificacionPinConfirma.Size = New System.Drawing.Size(44, 20)
        Me.integertextboxIdentificacionPinConfirma.TabIndex = 18
        Me.integertextboxIdentificacionPinConfirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.integertextboxIdentificacionPinConfirma.UseSystemPasswordChar = True
        '
        'labelIdentificacionPinConfirma
        '
        Me.labelIdentificacionPinConfirma.AutoSize = True
        Me.labelIdentificacionPinConfirma.Location = New System.Drawing.Point(11, 71)
        Me.labelIdentificacionPinConfirma.Name = "labelIdentificacionPinConfirma"
        Me.labelIdentificacionPinConfirma.Size = New System.Drawing.Size(72, 13)
        Me.labelIdentificacionPinConfirma.TabIndex = 17
        Me.labelIdentificacionPinConfirma.Text = "Confirma PIN:"
        '
        'formPersonaIdentificacionPin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 100)
        Me.ControlBox = False
        Me.Controls.Add(Me.integertextboxIdentificacionPinConfirma)
        Me.Controls.Add(Me.labelIdentificacionPinConfirma)
        Me.Controls.Add(Me.toolstripMain)
        Me.Controls.Add(Me.integertextboxIdentificacionPin)
        Me.Controls.Add(Me.labelIdentificacionPin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "formPersonaIdentificacionPin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PIN"
        CType(Me.integertextboxIdentificacionPin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        CType(Me.integertextboxIdentificacionPinConfirma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents integertextboxIdentificacionPin As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents labelIdentificacionPin As Label
    Friend WithEvents toolstripMain As ToolStrip
    Friend WithEvents buttonCancelar As ToolStripButton
    Friend WithEvents buttonGuardar As ToolStripButton
    Friend WithEvents integertextboxIdentificacionPinConfirma As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents labelIdentificacionPinConfirma As Label
End Class
