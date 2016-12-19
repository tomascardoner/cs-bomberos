<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUbicacion
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
        Dim labelCuartel As System.Windows.Forms.Label
        Dim labelAutomotor As System.Windows.Forms.Label
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.textboxIDUbicacion = New System.Windows.Forms.TextBox()
        Me.labelIDUbicacion = New System.Windows.Forms.Label()
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.comboboxCuartel = New System.Windows.Forms.ComboBox()
        Me.comboboxAutomotor = New System.Windows.Forms.ComboBox()
        labelEsActivo = New System.Windows.Forms.Label()
        labelCuartel = New System.Windows.Forms.Label()
        labelAutomotor = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelEsActivo
        '
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(12, 159)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 8
        labelEsActivo.Text = "Activo:"
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(92, 76)
        Me.textboxNombre.MaxLength = 50
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(266, 20)
        Me.textboxNombre.TabIndex = 3
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Location = New System.Drawing.Point(12, 79)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(47, 13)
        Me.labelNombre.TabIndex = 2
        Me.labelNombre.Text = "Nombre:"
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_OK_32
        Me.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(85, 36)
        Me.buttonGuardar.Text = "Guardar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_CANCEL_32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_CLOSE_32
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
        Me.toolstripMain.Size = New System.Drawing.Size(371, 39)
        Me.toolstripMain.TabIndex = 10
        '
        'textboxIDUbicacion
        '
        Me.textboxIDUbicacion.Location = New System.Drawing.Point(92, 50)
        Me.textboxIDUbicacion.MaxLength = 10
        Me.textboxIDUbicacion.Name = "textboxIDUbicacion"
        Me.textboxIDUbicacion.ReadOnly = True
        Me.textboxIDUbicacion.Size = New System.Drawing.Size(74, 20)
        Me.textboxIDUbicacion.TabIndex = 1
        Me.textboxIDUbicacion.TabStop = False
        Me.textboxIDUbicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelIDUbicacion
        '
        Me.labelIDUbicacion.AutoSize = True
        Me.labelIDUbicacion.Location = New System.Drawing.Point(12, 53)
        Me.labelIDUbicacion.Name = "labelIDUbicacion"
        Me.labelIDUbicacion.Size = New System.Drawing.Size(21, 13)
        Me.labelIDUbicacion.TabIndex = 0
        Me.labelIDUbicacion.Text = "ID:"
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(92, 159)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 9
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'comboboxCuartel
        '
        Me.comboboxCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCuartel.FormattingEnabled = True
        Me.comboboxCuartel.Location = New System.Drawing.Point(92, 102)
        Me.comboboxCuartel.Name = "comboboxCuartel"
        Me.comboboxCuartel.Size = New System.Drawing.Size(267, 21)
        Me.comboboxCuartel.TabIndex = 5
        '
        'labelCuartel
        '
        labelCuartel.AutoSize = True
        labelCuartel.Location = New System.Drawing.Point(12, 105)
        labelCuartel.Name = "labelCuartel"
        labelCuartel.Size = New System.Drawing.Size(43, 13)
        labelCuartel.TabIndex = 4
        labelCuartel.Text = "Cuartel:"
        '
        'comboboxAutomotor
        '
        Me.comboboxAutomotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxAutomotor.FormattingEnabled = True
        Me.comboboxAutomotor.Location = New System.Drawing.Point(92, 129)
        Me.comboboxAutomotor.Name = "comboboxAutomotor"
        Me.comboboxAutomotor.Size = New System.Drawing.Size(267, 21)
        Me.comboboxAutomotor.TabIndex = 7
        '
        'labelAutomotor
        '
        labelAutomotor.AutoSize = True
        labelAutomotor.Location = New System.Drawing.Point(12, 132)
        labelAutomotor.Name = "labelAutomotor"
        labelAutomotor.Size = New System.Drawing.Size(58, 13)
        labelAutomotor.TabIndex = 6
        labelAutomotor.Text = "Automotor:"
        '
        'formUbicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 185)
        Me.Controls.Add(Me.comboboxAutomotor)
        Me.Controls.Add(labelAutomotor)
        Me.Controls.Add(Me.comboboxCuartel)
        Me.Controls.Add(labelCuartel)
        Me.Controls.Add(Me.checkboxEsActivo)
        Me.Controls.Add(labelEsActivo)
        Me.Controls.Add(Me.labelIDUbicacion)
        Me.Controls.Add(Me.textboxIDUbicacion)
        Me.Controls.Add(Me.textboxNombre)
        Me.Controls.Add(Me.labelNombre)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formUbicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ubicación"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
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
    Friend WithEvents textboxIDUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents labelIDUbicacion As System.Windows.Forms.Label
    Friend WithEvents checkboxEsActivo As System.Windows.Forms.CheckBox
    Friend WithEvents comboboxCuartel As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxAutomotor As System.Windows.Forms.ComboBox
End Class
