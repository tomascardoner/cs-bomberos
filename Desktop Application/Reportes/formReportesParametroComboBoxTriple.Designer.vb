<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formReportesParametroComboBoxTriple
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
        Me.comboboxValor = New System.Windows.Forms.ComboBox()
        Me.labelValor = New System.Windows.Forms.Label()
        Me.comboboxPadreValor = New System.Windows.Forms.ComboBox()
        Me.labelPadreValor = New System.Windows.Forms.Label()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAceptar = New System.Windows.Forms.ToolStripButton()
        Me.comboboxAbueloValor = New System.Windows.Forms.ComboBox()
        Me.labelAbueloValor = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'comboboxValor
        '
        Me.comboboxValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxValor.FormattingEnabled = True
        Me.comboboxValor.Location = New System.Drawing.Point(117, 134)
        Me.comboboxValor.Name = "comboboxValor"
        Me.comboboxValor.Size = New System.Drawing.Size(244, 21)
        Me.comboboxValor.TabIndex = 5
        '
        'labelValor
        '
        Me.labelValor.AutoSize = True
        Me.labelValor.Location = New System.Drawing.Point(12, 137)
        Me.labelValor.Name = "labelValor"
        Me.labelValor.Size = New System.Drawing.Size(34, 13)
        Me.labelValor.TabIndex = 4
        Me.labelValor.Text = "Valor:"
        '
        'comboboxPadreValor
        '
        Me.comboboxPadreValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxPadreValor.FormattingEnabled = True
        Me.comboboxPadreValor.Location = New System.Drawing.Point(117, 95)
        Me.comboboxPadreValor.Name = "comboboxPadreValor"
        Me.comboboxPadreValor.Size = New System.Drawing.Size(244, 21)
        Me.comboboxPadreValor.TabIndex = 3
        '
        'labelPadreValor
        '
        Me.labelPadreValor.AutoSize = True
        Me.labelPadreValor.Location = New System.Drawing.Point(12, 98)
        Me.labelPadreValor.Name = "labelPadreValor"
        Me.labelPadreValor.Size = New System.Drawing.Size(34, 13)
        Me.labelPadreValor.TabIndex = 2
        Me.labelPadreValor.Text = "Valor:"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCancelar, Me.buttonAceptar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(375, 39)
        Me.toolstripMain.TabIndex = 6
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
        'buttonAceptar
        '
        Me.buttonAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonAceptar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_OK_32
        Me.buttonAceptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAceptar.Text = "Aceptar"
        '
        'comboboxAbueloValor
        '
        Me.comboboxAbueloValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxAbueloValor.FormattingEnabled = True
        Me.comboboxAbueloValor.Location = New System.Drawing.Point(117, 56)
        Me.comboboxAbueloValor.Name = "comboboxAbueloValor"
        Me.comboboxAbueloValor.Size = New System.Drawing.Size(244, 21)
        Me.comboboxAbueloValor.TabIndex = 1
        '
        'labelAbueloValor
        '
        Me.labelAbueloValor.AutoSize = True
        Me.labelAbueloValor.Location = New System.Drawing.Point(12, 59)
        Me.labelAbueloValor.Name = "labelAbueloValor"
        Me.labelAbueloValor.Size = New System.Drawing.Size(34, 13)
        Me.labelAbueloValor.TabIndex = 0
        Me.labelAbueloValor.Text = "Valor:"
        '
        'formReportesParametroComboBoxTriple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 168)
        Me.Controls.Add(Me.comboboxAbueloValor)
        Me.Controls.Add(Me.labelAbueloValor)
        Me.Controls.Add(Me.comboboxValor)
        Me.Controls.Add(Me.labelValor)
        Me.Controls.Add(Me.comboboxPadreValor)
        Me.Controls.Add(Me.labelPadreValor)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formReportesParametroComboBoxTriple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Especifique el valor"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboboxValor As ComboBox
    Friend WithEvents labelValor As Label
    Friend WithEvents comboboxPadreValor As ComboBox
    Friend WithEvents labelPadreValor As Label
    Friend WithEvents toolstripMain As ToolStrip
    Friend WithEvents buttonCancelar As ToolStripButton
    Friend WithEvents buttonAceptar As ToolStripButton
    Friend WithEvents comboboxAbueloValor As ComboBox
    Friend WithEvents labelAbueloValor As Label
End Class
