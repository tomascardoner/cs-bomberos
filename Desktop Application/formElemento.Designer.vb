<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formElemento
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
        Dim labelSubRubro As System.Windows.Forms.Label
        Dim labelRubro As System.Windows.Forms.Label
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.textboxIDElemento = New System.Windows.Forms.TextBox()
        Me.labelIDElemento = New System.Windows.Forms.Label()
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.comboboxSubRubro = New System.Windows.Forms.ComboBox()
        Me.comboboxRubro = New System.Windows.Forms.ComboBox()
        labelEsActivo = New System.Windows.Forms.Label()
        labelSubRubro = New System.Windows.Forms.Label()
        labelRubro = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelEsActivo
        '
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(12, 182)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 8
        labelEsActivo.Text = "Activo:"
        '
        'labelSubRubro
        '
        labelSubRubro.AutoSize = True
        labelSubRubro.Location = New System.Drawing.Point(12, 143)
        labelSubRubro.Name = "labelSubRubro"
        labelSubRubro.Size = New System.Drawing.Size(61, 13)
        labelSubRubro.TabIndex = 6
        labelSubRubro.Text = "Sub-Rubro:"
        '
        'labelRubro
        '
        labelRubro.AutoSize = True
        labelRubro.Location = New System.Drawing.Point(12, 116)
        labelRubro.Name = "labelRubro"
        labelRubro.Size = New System.Drawing.Size(39, 13)
        labelRubro.TabIndex = 4
        labelRubro.Text = "Rubro:"
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(98, 76)
        Me.textboxNombre.MaxLength = 50
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(359, 20)
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
        Me.toolstripMain.Size = New System.Drawing.Size(473, 39)
        Me.toolstripMain.TabIndex = 10
        '
        'textboxIDElemento
        '
        Me.textboxIDElemento.Location = New System.Drawing.Point(98, 50)
        Me.textboxIDElemento.MaxLength = 10
        Me.textboxIDElemento.Name = "textboxIDElemento"
        Me.textboxIDElemento.ReadOnly = True
        Me.textboxIDElemento.Size = New System.Drawing.Size(74, 20)
        Me.textboxIDElemento.TabIndex = 1
        Me.textboxIDElemento.TabStop = False
        Me.textboxIDElemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelIDElemento
        '
        Me.labelIDElemento.AutoSize = True
        Me.labelIDElemento.Location = New System.Drawing.Point(12, 53)
        Me.labelIDElemento.Name = "labelIDElemento"
        Me.labelIDElemento.Size = New System.Drawing.Size(21, 13)
        Me.labelIDElemento.TabIndex = 0
        Me.labelIDElemento.Text = "ID:"
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(98, 182)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 9
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'comboboxSubRubro
        '
        Me.comboboxSubRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxSubRubro.FormattingEnabled = True
        Me.comboboxSubRubro.Location = New System.Drawing.Point(98, 140)
        Me.comboboxSubRubro.Name = "comboboxSubRubro"
        Me.comboboxSubRubro.Size = New System.Drawing.Size(267, 21)
        Me.comboboxSubRubro.TabIndex = 7
        '
        'comboboxRubro
        '
        Me.comboboxRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxRubro.FormattingEnabled = True
        Me.comboboxRubro.Location = New System.Drawing.Point(98, 113)
        Me.comboboxRubro.Name = "comboboxRubro"
        Me.comboboxRubro.Size = New System.Drawing.Size(267, 21)
        Me.comboboxRubro.TabIndex = 5
        '
        'formElemento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 213)
        Me.Controls.Add(Me.comboboxRubro)
        Me.Controls.Add(labelRubro)
        Me.Controls.Add(Me.comboboxSubRubro)
        Me.Controls.Add(labelSubRubro)
        Me.Controls.Add(Me.checkboxEsActivo)
        Me.Controls.Add(labelEsActivo)
        Me.Controls.Add(Me.labelIDElemento)
        Me.Controls.Add(Me.textboxIDElemento)
        Me.Controls.Add(Me.textboxNombre)
        Me.Controls.Add(Me.labelNombre)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formElemento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Elemento"
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
    Friend WithEvents textboxIDElemento As System.Windows.Forms.TextBox
    Friend WithEvents labelIDElemento As System.Windows.Forms.Label
    Friend WithEvents checkboxEsActivo As System.Windows.Forms.CheckBox
    Friend WithEvents comboboxSubRubro As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxRubro As System.Windows.Forms.ComboBox
End Class
