<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formInventarioAgregarMultiple
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
        Dim labelFechaAdquisicion As System.Windows.Forms.Label
        Dim labelCuartel As System.Windows.Forms.Label
        Dim labelSubUbicacion As System.Windows.Forms.Label
        Dim labelUbicacion As System.Windows.Forms.Label
        Dim labelArea As System.Windows.Forms.Label
        Dim labelModoAdquisicion As System.Windows.Forms.Label
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.LabelCantidad = New System.Windows.Forms.Label()
        Me.NumericUpDownCantidad = New System.Windows.Forms.NumericUpDown()
        Me.datetimepickerFechaAdquisicion = New System.Windows.Forms.DateTimePicker()
        Me.labelDescripcionPropia = New System.Windows.Forms.Label()
        Me.textboxDescripcionPropia = New System.Windows.Forms.TextBox()
        Me.comboboxCuartel = New System.Windows.Forms.ComboBox()
        Me.comboboxElemento = New System.Windows.Forms.ComboBox()
        Me.labelElemento = New System.Windows.Forms.Label()
        Me.buttonCodigoSiguiente = New System.Windows.Forms.Button()
        Me.comboboxUbicacion = New System.Windows.Forms.ComboBox()
        Me.comboboxSubUbicacion = New System.Windows.Forms.ComboBox()
        Me.comboboxModoAdquisicion = New System.Windows.Forms.ComboBox()
        Me.comboboxArea = New System.Windows.Forms.ComboBox()
        Me.labelPrimerCodigo = New System.Windows.Forms.Label()
        Me.MaskedTextBoxCodigo = New System.Windows.Forms.MaskedTextBox()
        labelFechaAdquisicion = New System.Windows.Forms.Label()
        labelCuartel = New System.Windows.Forms.Label()
        labelSubUbicacion = New System.Windows.Forms.Label()
        labelUbicacion = New System.Windows.Forms.Label()
        labelArea = New System.Windows.Forms.Label()
        labelModoAdquisicion = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        CType(Me.NumericUpDownCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelFechaAdquisicion
        '
        labelFechaAdquisicion.AutoSize = True
        labelFechaAdquisicion.Location = New System.Drawing.Point(11, 268)
        labelFechaAdquisicion.Name = "labelFechaAdquisicion"
        labelFechaAdquisicion.Size = New System.Drawing.Size(112, 13)
        labelFechaAdquisicion.TabIndex = 15
        labelFechaAdquisicion.Text = "Fecha de Adquisición:"
        '
        'labelCuartel
        '
        labelCuartel.AutoSize = True
        labelCuartel.Location = New System.Drawing.Point(11, 54)
        labelCuartel.Name = "labelCuartel"
        labelCuartel.Size = New System.Drawing.Size(43, 13)
        labelCuartel.TabIndex = 0
        labelCuartel.Text = "Cuartel:"
        '
        'labelSubUbicacion
        '
        labelSubUbicacion.AutoSize = True
        labelSubUbicacion.Location = New System.Drawing.Point(11, 332)
        labelSubUbicacion.Name = "labelSubUbicacion"
        labelSubUbicacion.Size = New System.Drawing.Size(80, 13)
        labelSubUbicacion.TabIndex = 19
        labelSubUbicacion.Text = "Sub-Ubicación:"
        '
        'labelUbicacion
        '
        labelUbicacion.AutoSize = True
        labelUbicacion.Location = New System.Drawing.Point(11, 305)
        labelUbicacion.Name = "labelUbicacion"
        labelUbicacion.Size = New System.Drawing.Size(58, 13)
        labelUbicacion.TabIndex = 17
        labelUbicacion.Text = "Ubicación:"
        '
        'labelArea
        '
        labelArea.AutoSize = True
        labelArea.Location = New System.Drawing.Point(11, 81)
        labelArea.Name = "labelArea"
        labelArea.Size = New System.Drawing.Size(32, 13)
        labelArea.TabIndex = 2
        labelArea.Text = "Area:"
        '
        'labelModoAdquisicion
        '
        labelModoAdquisicion.AutoSize = True
        labelModoAdquisicion.Location = New System.Drawing.Point(11, 238)
        labelModoAdquisicion.Name = "labelModoAdquisicion"
        labelModoAdquisicion.Size = New System.Drawing.Size(109, 13)
        labelModoAdquisicion.TabIndex = 13
        labelModoAdquisicion.Text = "Modo de Adquisición:"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(517, 39)
        Me.toolstripMain.TabIndex = 21
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
        'LabelCantidad
        '
        Me.LabelCantidad.AutoSize = True
        Me.LabelCantidad.Location = New System.Drawing.Point(11, 123)
        Me.LabelCantidad.Name = "LabelCantidad"
        Me.LabelCantidad.Size = New System.Drawing.Size(52, 13)
        Me.LabelCantidad.TabIndex = 4
        Me.LabelCantidad.Text = "Cantidad:"
        '
        'NumericUpDownCantidad
        '
        Me.NumericUpDownCantidad.Location = New System.Drawing.Point(129, 121)
        Me.NumericUpDownCantidad.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NumericUpDownCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownCantidad.Name = "NumericUpDownCantidad"
        Me.NumericUpDownCantidad.Size = New System.Drawing.Size(55, 20)
        Me.NumericUpDownCantidad.TabIndex = 5
        Me.NumericUpDownCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDownCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'datetimepickerFechaAdquisicion
        '
        Me.datetimepickerFechaAdquisicion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaAdquisicion.Location = New System.Drawing.Point(129, 264)
        Me.datetimepickerFechaAdquisicion.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaAdquisicion.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaAdquisicion.Name = "datetimepickerFechaAdquisicion"
        Me.datetimepickerFechaAdquisicion.ShowCheckBox = True
        Me.datetimepickerFechaAdquisicion.Size = New System.Drawing.Size(138, 20)
        Me.datetimepickerFechaAdquisicion.TabIndex = 16
        '
        'labelDescripcionPropia
        '
        Me.labelDescripcionPropia.AutoSize = True
        Me.labelDescripcionPropia.Location = New System.Drawing.Point(11, 203)
        Me.labelDescripcionPropia.Name = "labelDescripcionPropia"
        Me.labelDescripcionPropia.Size = New System.Drawing.Size(98, 13)
        Me.labelDescripcionPropia.TabIndex = 11
        Me.labelDescripcionPropia.Text = "Descripción propia:"
        '
        'textboxDescripcionPropia
        '
        Me.textboxDescripcionPropia.Location = New System.Drawing.Point(129, 200)
        Me.textboxDescripcionPropia.MaxLength = 100
        Me.textboxDescripcionPropia.Name = "textboxDescripcionPropia"
        Me.textboxDescripcionPropia.Size = New System.Drawing.Size(379, 20)
        Me.textboxDescripcionPropia.TabIndex = 12
        '
        'comboboxCuartel
        '
        Me.comboboxCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCuartel.FormattingEnabled = True
        Me.comboboxCuartel.Location = New System.Drawing.Point(129, 51)
        Me.comboboxCuartel.Name = "comboboxCuartel"
        Me.comboboxCuartel.Size = New System.Drawing.Size(267, 21)
        Me.comboboxCuartel.TabIndex = 1
        '
        'comboboxElemento
        '
        Me.comboboxElemento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboboxElemento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxElemento.FormattingEnabled = True
        Me.comboboxElemento.Location = New System.Drawing.Point(129, 173)
        Me.comboboxElemento.Name = "comboboxElemento"
        Me.comboboxElemento.Size = New System.Drawing.Size(379, 21)
        Me.comboboxElemento.TabIndex = 10
        '
        'labelElemento
        '
        Me.labelElemento.AutoSize = True
        Me.labelElemento.Location = New System.Drawing.Point(11, 176)
        Me.labelElemento.Name = "labelElemento"
        Me.labelElemento.Size = New System.Drawing.Size(54, 13)
        Me.labelElemento.TabIndex = 9
        Me.labelElemento.Text = "Elemento:"
        '
        'buttonCodigoSiguiente
        '
        Me.buttonCodigoSiguiente.Location = New System.Drawing.Point(180, 145)
        Me.buttonCodigoSiguiente.Name = "buttonCodigoSiguiente"
        Me.buttonCodigoSiguiente.Size = New System.Drawing.Size(103, 22)
        Me.buttonCodigoSiguiente.TabIndex = 8
        Me.buttonCodigoSiguiente.Text = "Obtener siguiente"
        Me.buttonCodigoSiguiente.UseVisualStyleBackColor = True
        '
        'comboboxUbicacion
        '
        Me.comboboxUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxUbicacion.FormattingEnabled = True
        Me.comboboxUbicacion.Location = New System.Drawing.Point(129, 302)
        Me.comboboxUbicacion.Name = "comboboxUbicacion"
        Me.comboboxUbicacion.Size = New System.Drawing.Size(267, 21)
        Me.comboboxUbicacion.TabIndex = 18
        '
        'comboboxSubUbicacion
        '
        Me.comboboxSubUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxSubUbicacion.FormattingEnabled = True
        Me.comboboxSubUbicacion.Location = New System.Drawing.Point(129, 329)
        Me.comboboxSubUbicacion.Name = "comboboxSubUbicacion"
        Me.comboboxSubUbicacion.Size = New System.Drawing.Size(267, 21)
        Me.comboboxSubUbicacion.TabIndex = 20
        '
        'comboboxModoAdquisicion
        '
        Me.comboboxModoAdquisicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxModoAdquisicion.FormattingEnabled = True
        Me.comboboxModoAdquisicion.Location = New System.Drawing.Point(129, 235)
        Me.comboboxModoAdquisicion.Name = "comboboxModoAdquisicion"
        Me.comboboxModoAdquisicion.Size = New System.Drawing.Size(267, 21)
        Me.comboboxModoAdquisicion.TabIndex = 14
        '
        'comboboxArea
        '
        Me.comboboxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxArea.FormattingEnabled = True
        Me.comboboxArea.Location = New System.Drawing.Point(129, 78)
        Me.comboboxArea.Name = "comboboxArea"
        Me.comboboxArea.Size = New System.Drawing.Size(267, 21)
        Me.comboboxArea.TabIndex = 3
        '
        'labelPrimerCodigo
        '
        Me.labelPrimerCodigo.AutoSize = True
        Me.labelPrimerCodigo.Location = New System.Drawing.Point(11, 150)
        Me.labelPrimerCodigo.Name = "labelPrimerCodigo"
        Me.labelPrimerCodigo.Size = New System.Drawing.Size(74, 13)
        Me.labelPrimerCodigo.TabIndex = 6
        Me.labelPrimerCodigo.Text = "Primer código:"
        '
        'MaskedTextBoxCodigo
        '
        Me.MaskedTextBoxCodigo.Location = New System.Drawing.Point(129, 147)
        Me.MaskedTextBoxCodigo.Mask = "00000"
        Me.MaskedTextBoxCodigo.Name = "MaskedTextBoxCodigo"
        Me.MaskedTextBoxCodigo.Size = New System.Drawing.Size(45, 20)
        Me.MaskedTextBoxCodigo.TabIndex = 7
        '
        'formInventarioAgregarMultiple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 363)
        Me.Controls.Add(Me.MaskedTextBoxCodigo)
        Me.Controls.Add(Me.LabelCantidad)
        Me.Controls.Add(Me.NumericUpDownCantidad)
        Me.Controls.Add(Me.datetimepickerFechaAdquisicion)
        Me.Controls.Add(labelFechaAdquisicion)
        Me.Controls.Add(Me.labelDescripcionPropia)
        Me.Controls.Add(Me.textboxDescripcionPropia)
        Me.Controls.Add(Me.comboboxCuartel)
        Me.Controls.Add(Me.comboboxElemento)
        Me.Controls.Add(Me.labelElemento)
        Me.Controls.Add(Me.buttonCodigoSiguiente)
        Me.Controls.Add(labelCuartel)
        Me.Controls.Add(Me.comboboxUbicacion)
        Me.Controls.Add(labelSubUbicacion)
        Me.Controls.Add(labelUbicacion)
        Me.Controls.Add(Me.comboboxSubUbicacion)
        Me.Controls.Add(Me.comboboxModoAdquisicion)
        Me.Controls.Add(labelArea)
        Me.Controls.Add(labelModoAdquisicion)
        Me.Controls.Add(Me.comboboxArea)
        Me.Controls.Add(Me.labelPrimerCodigo)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formInventarioAgregarMultiple"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar múltiples elementos al inventario"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        CType(Me.NumericUpDownCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents LabelCantidad As Label
    Friend WithEvents NumericUpDownCantidad As NumericUpDown
    Friend WithEvents datetimepickerFechaAdquisicion As DateTimePicker
    Friend WithEvents labelDescripcionPropia As Label
    Friend WithEvents textboxDescripcionPropia As TextBox
    Friend WithEvents comboboxCuartel As ComboBox
    Friend WithEvents comboboxElemento As ComboBox
    Friend WithEvents labelElemento As Label
    Friend WithEvents buttonCodigoSiguiente As Button
    Friend WithEvents comboboxUbicacion As ComboBox
    Friend WithEvents comboboxSubUbicacion As ComboBox
    Friend WithEvents comboboxModoAdquisicion As ComboBox
    Friend WithEvents comboboxArea As ComboBox
    Friend WithEvents labelPrimerCodigo As Label
    Friend WithEvents buttonCancelar As ToolStripButton
    Friend WithEvents buttonGuardar As ToolStripButton
    Friend WithEvents MaskedTextBoxCodigo As MaskedTextBox
End Class
