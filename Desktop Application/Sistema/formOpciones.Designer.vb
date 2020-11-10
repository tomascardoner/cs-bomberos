<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formOpciones
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
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.groupboxInicioSesion = New System.Windows.Forms.GroupBox()
        Me.checkboxMostrarAvisosAlarmas = New System.Windows.Forms.CheckBox()
        Me.toolstripMain.SuspendLayout()
        Me.groupboxInicioSesion.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(207, 39)
        Me.toolstripMain.TabIndex = 2
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
        'groupboxInicioSesion
        '
        Me.groupboxInicioSesion.Controls.Add(Me.checkboxMostrarAvisosAlarmas)
        Me.groupboxInicioSesion.Location = New System.Drawing.Point(12, 42)
        Me.groupboxInicioSesion.Name = "groupboxInicioSesion"
        Me.groupboxInicioSesion.Size = New System.Drawing.Size(183, 57)
        Me.groupboxInicioSesion.TabIndex = 4
        Me.groupboxInicioSesion.TabStop = False
        Me.groupboxInicioSesion.Text = "Inicio de sesión:"
        '
        'checkboxMostrarAvisosAlarmas
        '
        Me.checkboxMostrarAvisosAlarmas.AutoSize = True
        Me.checkboxMostrarAvisosAlarmas.Location = New System.Drawing.Point(13, 22)
        Me.checkboxMostrarAvisosAlarmas.Name = "checkboxMostrarAvisosAlarmas"
        Me.checkboxMostrarAvisosAlarmas.Size = New System.Drawing.Size(143, 17)
        Me.checkboxMostrarAvisosAlarmas.TabIndex = 5
        Me.checkboxMostrarAvisosAlarmas.Text = "Mostrar aviso de alarmas"
        Me.checkboxMostrarAvisosAlarmas.UseVisualStyleBackColor = True
        '
        'formOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 111)
        Me.Controls.Add(Me.groupboxInicioSesion)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "formOpciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Opciones"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.groupboxInicioSesion.ResumeLayout(False)
        Me.groupboxInicioSesion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents groupboxInicioSesion As System.Windows.Forms.GroupBox
    Friend WithEvents checkboxMostrarAvisosAlarmas As System.Windows.Forms.CheckBox
End Class
