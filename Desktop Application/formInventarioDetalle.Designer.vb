<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formInventarioDetalle
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
        Dim labelSubUbicacion As System.Windows.Forms.Label
        Dim labelArea As System.Windows.Forms.Label
        Dim labelModoAdquisicion As System.Windows.Forms.Label
        Dim labelUbicacion As System.Windows.Forms.Label
        Dim labelFechaBaja As System.Windows.Forms.Label
        Me.labelElemento = New System.Windows.Forms.Label()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.textboxIDInventario = New System.Windows.Forms.TextBox()
        Me.labelIDInventario = New System.Windows.Forms.Label()
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.comboboxCuartel = New System.Windows.Forms.ComboBox()
        Me.comboboxSubUbicacion = New System.Windows.Forms.ComboBox()
        Me.comboboxArea = New System.Windows.Forms.ComboBox()
        Me.textboxCodigo = New System.Windows.Forms.TextBox()
        Me.labelCodigo = New System.Windows.Forms.Label()
        Me.comboboxModoAdquisicion = New System.Windows.Forms.ComboBox()
        Me.comboboxUbicacion = New System.Windows.Forms.ComboBox()
        Me.buttonCodigoSiguiente = New System.Windows.Forms.Button()
        Me.datetimepickerFechaBaja = New System.Windows.Forms.DateTimePicker()
        Me.comboboxElemento = New System.Windows.Forms.ComboBox()
        labelEsActivo = New System.Windows.Forms.Label()
        labelCuartel = New System.Windows.Forms.Label()
        labelSubUbicacion = New System.Windows.Forms.Label()
        labelArea = New System.Windows.Forms.Label()
        labelModoAdquisicion = New System.Windows.Forms.Label()
        labelUbicacion = New System.Windows.Forms.Label()
        labelFechaBaja = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelEsActivo
        '
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(12, 307)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 17
        labelEsActivo.Text = "Activo:"
        '
        'labelCuartel
        '
        labelCuartel.AutoSize = True
        labelCuartel.Location = New System.Drawing.Point(12, 79)
        labelCuartel.Name = "labelCuartel"
        labelCuartel.Size = New System.Drawing.Size(43, 13)
        labelCuartel.TabIndex = 2
        labelCuartel.Text = "Cuartel:"
        '
        'labelSubUbicacion
        '
        labelSubUbicacion.AutoSize = True
        labelSubUbicacion.Location = New System.Drawing.Point(12, 255)
        labelSubUbicacion.Name = "labelSubUbicacion"
        labelSubUbicacion.Size = New System.Drawing.Size(80, 13)
        labelSubUbicacion.TabIndex = 15
        labelSubUbicacion.Text = "Sub-Ubicación:"
        '
        'labelArea
        '
        labelArea.AutoSize = True
        labelArea.Location = New System.Drawing.Point(12, 106)
        labelArea.Name = "labelArea"
        labelArea.Size = New System.Drawing.Size(32, 13)
        labelArea.TabIndex = 4
        labelArea.Text = "Area:"
        '
        'labelModoAdquisicion
        '
        labelModoAdquisicion.AutoSize = True
        labelModoAdquisicion.Location = New System.Drawing.Point(12, 185)
        labelModoAdquisicion.Name = "labelModoAdquisicion"
        labelModoAdquisicion.Size = New System.Drawing.Size(109, 13)
        labelModoAdquisicion.TabIndex = 11
        labelModoAdquisicion.Text = "Modo de Adquisición:"
        '
        'labelUbicacion
        '
        labelUbicacion.AutoSize = True
        labelUbicacion.Location = New System.Drawing.Point(12, 228)
        labelUbicacion.Name = "labelUbicacion"
        labelUbicacion.Size = New System.Drawing.Size(58, 13)
        labelUbicacion.TabIndex = 13
        labelUbicacion.Text = "Ubicación:"
        '
        'labelFechaBaja
        '
        labelFechaBaja.AutoSize = True
        labelFechaBaja.Location = New System.Drawing.Point(12, 332)
        labelFechaBaja.Name = "labelFechaBaja"
        labelFechaBaja.Size = New System.Drawing.Size(79, 13)
        labelFechaBaja.TabIndex = 19
        labelFechaBaja.Text = "Fecha de Baja:"
        '
        'labelElemento
        '
        Me.labelElemento.AutoSize = True
        Me.labelElemento.Location = New System.Drawing.Point(12, 159)
        Me.labelElemento.Name = "labelElemento"
        Me.labelElemento.Size = New System.Drawing.Size(54, 13)
        Me.labelElemento.TabIndex = 9
        Me.labelElemento.Text = "Elemento:"
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
        Me.toolstripMain.Size = New System.Drawing.Size(496, 39)
        Me.toolstripMain.TabIndex = 21
        '
        'textboxIDInventario
        '
        Me.textboxIDInventario.Location = New System.Drawing.Point(125, 50)
        Me.textboxIDInventario.MaxLength = 10
        Me.textboxIDInventario.Name = "textboxIDInventario"
        Me.textboxIDInventario.ReadOnly = True
        Me.textboxIDInventario.Size = New System.Drawing.Size(74, 20)
        Me.textboxIDInventario.TabIndex = 1
        Me.textboxIDInventario.TabStop = False
        Me.textboxIDInventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelIDInventario
        '
        Me.labelIDInventario.AutoSize = True
        Me.labelIDInventario.Location = New System.Drawing.Point(12, 53)
        Me.labelIDInventario.Name = "labelIDInventario"
        Me.labelIDInventario.Size = New System.Drawing.Size(21, 13)
        Me.labelIDInventario.TabIndex = 0
        Me.labelIDInventario.Text = "ID:"
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(125, 307)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 18
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'comboboxCuartel
        '
        Me.comboboxCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCuartel.FormattingEnabled = True
        Me.comboboxCuartel.Location = New System.Drawing.Point(125, 76)
        Me.comboboxCuartel.Name = "comboboxCuartel"
        Me.comboboxCuartel.Size = New System.Drawing.Size(267, 21)
        Me.comboboxCuartel.TabIndex = 3
        '
        'comboboxSubUbicacion
        '
        Me.comboboxSubUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxSubUbicacion.FormattingEnabled = True
        Me.comboboxSubUbicacion.Location = New System.Drawing.Point(125, 252)
        Me.comboboxSubUbicacion.Name = "comboboxSubUbicacion"
        Me.comboboxSubUbicacion.Size = New System.Drawing.Size(267, 21)
        Me.comboboxSubUbicacion.TabIndex = 16
        '
        'comboboxArea
        '
        Me.comboboxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxArea.FormattingEnabled = True
        Me.comboboxArea.Location = New System.Drawing.Point(125, 103)
        Me.comboboxArea.Name = "comboboxArea"
        Me.comboboxArea.Size = New System.Drawing.Size(267, 21)
        Me.comboboxArea.TabIndex = 5
        '
        'textboxCodigo
        '
        Me.textboxCodigo.Location = New System.Drawing.Point(125, 130)
        Me.textboxCodigo.MaxLength = 5
        Me.textboxCodigo.Name = "textboxCodigo"
        Me.textboxCodigo.Size = New System.Drawing.Size(74, 20)
        Me.textboxCodigo.TabIndex = 7
        '
        'labelCodigo
        '
        Me.labelCodigo.AutoSize = True
        Me.labelCodigo.Location = New System.Drawing.Point(12, 133)
        Me.labelCodigo.Name = "labelCodigo"
        Me.labelCodigo.Size = New System.Drawing.Size(43, 13)
        Me.labelCodigo.TabIndex = 6
        Me.labelCodigo.Text = "Código:"
        '
        'comboboxModoAdquisicion
        '
        Me.comboboxModoAdquisicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxModoAdquisicion.FormattingEnabled = True
        Me.comboboxModoAdquisicion.Location = New System.Drawing.Point(125, 182)
        Me.comboboxModoAdquisicion.Name = "comboboxModoAdquisicion"
        Me.comboboxModoAdquisicion.Size = New System.Drawing.Size(267, 21)
        Me.comboboxModoAdquisicion.TabIndex = 12
        '
        'comboboxUbicacion
        '
        Me.comboboxUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxUbicacion.FormattingEnabled = True
        Me.comboboxUbicacion.Location = New System.Drawing.Point(125, 225)
        Me.comboboxUbicacion.Name = "comboboxUbicacion"
        Me.comboboxUbicacion.Size = New System.Drawing.Size(267, 21)
        Me.comboboxUbicacion.TabIndex = 14
        '
        'buttonCodigoSiguiente
        '
        Me.buttonCodigoSiguiente.Location = New System.Drawing.Point(205, 130)
        Me.buttonCodigoSiguiente.Name = "buttonCodigoSiguiente"
        Me.buttonCodigoSiguiente.Size = New System.Drawing.Size(103, 20)
        Me.buttonCodigoSiguiente.TabIndex = 8
        Me.buttonCodigoSiguiente.Text = "Obtener siguiente"
        Me.buttonCodigoSiguiente.UseVisualStyleBackColor = True
        '
        'datetimepickerFechaBaja
        '
        Me.datetimepickerFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaBaja.Location = New System.Drawing.Point(125, 330)
        Me.datetimepickerFechaBaja.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaBaja.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaBaja.Name = "datetimepickerFechaBaja"
        Me.datetimepickerFechaBaja.ShowCheckBox = True
        Me.datetimepickerFechaBaja.Size = New System.Drawing.Size(148, 20)
        Me.datetimepickerFechaBaja.TabIndex = 20
        '
        'comboboxElemento
        '
        Me.comboboxElemento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboboxElemento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxElemento.FormattingEnabled = True
        Me.comboboxElemento.Location = New System.Drawing.Point(125, 156)
        Me.comboboxElemento.Name = "comboboxElemento"
        Me.comboboxElemento.Size = New System.Drawing.Size(359, 21)
        Me.comboboxElemento.TabIndex = 10
        '
        'formInventarioDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 366)
        Me.Controls.Add(Me.comboboxElemento)
        Me.Controls.Add(Me.datetimepickerFechaBaja)
        Me.Controls.Add(labelFechaBaja)
        Me.Controls.Add(Me.buttonCodigoSiguiente)
        Me.Controls.Add(Me.comboboxUbicacion)
        Me.Controls.Add(labelUbicacion)
        Me.Controls.Add(Me.comboboxModoAdquisicion)
        Me.Controls.Add(labelModoAdquisicion)
        Me.Controls.Add(Me.textboxCodigo)
        Me.Controls.Add(Me.labelCodigo)
        Me.Controls.Add(Me.comboboxArea)
        Me.Controls.Add(labelArea)
        Me.Controls.Add(Me.comboboxSubUbicacion)
        Me.Controls.Add(labelSubUbicacion)
        Me.Controls.Add(Me.comboboxCuartel)
        Me.Controls.Add(labelCuartel)
        Me.Controls.Add(Me.checkboxEsActivo)
        Me.Controls.Add(labelEsActivo)
        Me.Controls.Add(Me.labelIDInventario)
        Me.Controls.Add(Me.textboxIDInventario)
        Me.Controls.Add(Me.labelElemento)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formInventarioDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle de Inventario"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelElemento As System.Windows.Forms.Label
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents textboxIDInventario As System.Windows.Forms.TextBox
    Friend WithEvents labelIDInventario As System.Windows.Forms.Label
    Friend WithEvents checkboxEsActivo As System.Windows.Forms.CheckBox
    Friend WithEvents comboboxCuartel As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxSubUbicacion As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxArea As System.Windows.Forms.ComboBox
    Friend WithEvents textboxCodigo As System.Windows.Forms.TextBox
    Friend WithEvents labelCodigo As System.Windows.Forms.Label
    Friend WithEvents comboboxModoAdquisicion As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxUbicacion As System.Windows.Forms.ComboBox
    Friend WithEvents buttonCodigoSiguiente As System.Windows.Forms.Button
    Friend WithEvents datetimepickerFechaBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents comboboxElemento As System.Windows.Forms.ComboBox
End Class
