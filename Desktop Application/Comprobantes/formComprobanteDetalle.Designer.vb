<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formComprobanteDetalle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.labelArticulo = New System.Windows.Forms.Label()
        Me.comboboxArticulo = New System.Windows.Forms.ComboBox()
        Me.labelCantidad = New System.Windows.Forms.Label()
        Me.textboxUnidad = New System.Windows.Forms.TextBox()
        Me.labelUnidad = New System.Windows.Forms.Label()
        Me.textboxDescripcion = New System.Windows.Forms.TextBox()
        Me.labelDescripcion = New System.Windows.Forms.Label()
        Me.labelPrecioUnitario = New System.Windows.Forms.Label()
        Me.labelPrecioUnitarioDescuentoPorcentaje = New System.Windows.Forms.Label()
        Me.labelPrecioUnitarioDescuentoImporte = New System.Windows.Forms.Label()
        Me.labelPrecioUnitarioFinal = New System.Windows.Forms.Label()
        Me.labelPrecioTotal = New System.Windows.Forms.Label()
        Me.doubletextboxCantidad = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.currencytextboxPrecioUnitario = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.percenttextboxPrecioUnitarioDescuentoPorcentaje = New Syncfusion.Windows.Forms.Tools.PercentTextBox()
        Me.currencytextboxPrecioUnitarioDescuentoImporte = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.currencytextboxPrecioUnitarioFinal = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.currencytextboxPrecioTotal = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.toolstripMain.SuspendLayout()
        CType(Me.doubletextboxCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currencytextboxPrecioUnitario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.percenttextboxPrecioUnitarioDescuentoPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currencytextboxPrecioUnitarioDescuentoImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currencytextboxPrecioUnitarioFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currencytextboxPrecioTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(553, 39)
        Me.toolstripMain.TabIndex = 25
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSBomberos.My.Resources.Resources.ImageCerrar32
        Me.buttonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCerrar.Name = "buttonCerrar"
        Me.buttonCerrar.Size = New System.Drawing.Size(75, 36)
        Me.buttonCerrar.Text = "Cerrar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.CSBomberos.My.Resources.Resources.ImageEditar32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
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
        'labelArticulo
        '
        Me.labelArticulo.AutoSize = True
        Me.labelArticulo.Location = New System.Drawing.Point(12, 54)
        Me.labelArticulo.Name = "labelArticulo"
        Me.labelArticulo.Size = New System.Drawing.Size(47, 13)
        Me.labelArticulo.TabIndex = 0
        Me.labelArticulo.Text = "Artículo:"
        '
        'comboboxArticulo
        '
        Me.comboboxArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboboxArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxArticulo.FormattingEnabled = True
        Me.comboboxArticulo.Location = New System.Drawing.Point(123, 51)
        Me.comboboxArticulo.Name = "comboboxArticulo"
        Me.comboboxArticulo.Size = New System.Drawing.Size(416, 21)
        Me.comboboxArticulo.TabIndex = 1
        '
        'labelCantidad
        '
        Me.labelCantidad.AutoSize = True
        Me.labelCantidad.Location = New System.Drawing.Point(12, 81)
        Me.labelCantidad.Name = "labelCantidad"
        Me.labelCantidad.Size = New System.Drawing.Size(52, 13)
        Me.labelCantidad.TabIndex = 2
        Me.labelCantidad.Text = "Cantidad:"
        '
        'textboxUnidad
        '
        Me.textboxUnidad.Location = New System.Drawing.Point(123, 104)
        Me.textboxUnidad.MaxLength = 10
        Me.textboxUnidad.Name = "textboxUnidad"
        Me.textboxUnidad.Size = New System.Drawing.Size(69, 20)
        Me.textboxUnidad.TabIndex = 5
        '
        'labelUnidad
        '
        Me.labelUnidad.AutoSize = True
        Me.labelUnidad.Location = New System.Drawing.Point(12, 107)
        Me.labelUnidad.Name = "labelUnidad"
        Me.labelUnidad.Size = New System.Drawing.Size(97, 13)
        Me.labelUnidad.TabIndex = 4
        Me.labelUnidad.Text = "Unidad de Medida:"
        '
        'textboxDescripcion
        '
        Me.textboxDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxDescripcion.Location = New System.Drawing.Point(123, 130)
        Me.textboxDescripcion.MaxLength = 100
        Me.textboxDescripcion.Name = "textboxDescripcion"
        Me.textboxDescripcion.Size = New System.Drawing.Size(416, 20)
        Me.textboxDescripcion.TabIndex = 14
        '
        'labelDescripcion
        '
        Me.labelDescripcion.AutoSize = True
        Me.labelDescripcion.Location = New System.Drawing.Point(12, 133)
        Me.labelDescripcion.Name = "labelDescripcion"
        Me.labelDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.labelDescripcion.TabIndex = 13
        Me.labelDescripcion.Text = "Descripción:"
        '
        'labelPrecioUnitario
        '
        Me.labelPrecioUnitario.AutoSize = True
        Me.labelPrecioUnitario.Location = New System.Drawing.Point(12, 159)
        Me.labelPrecioUnitario.Name = "labelPrecioUnitario"
        Me.labelPrecioUnitario.Size = New System.Drawing.Size(79, 13)
        Me.labelPrecioUnitario.TabIndex = 15
        Me.labelPrecioUnitario.Text = "Precio Unitario:"
        '
        'labelPrecioUnitarioDescuentoPorcentaje
        '
        Me.labelPrecioUnitarioDescuentoPorcentaje.AutoSize = True
        Me.labelPrecioUnitarioDescuentoPorcentaje.Location = New System.Drawing.Point(12, 185)
        Me.labelPrecioUnitarioDescuentoPorcentaje.Name = "labelPrecioUnitarioDescuentoPorcentaje"
        Me.labelPrecioUnitarioDescuentoPorcentaje.Size = New System.Drawing.Size(73, 13)
        Me.labelPrecioUnitarioDescuentoPorcentaje.TabIndex = 17
        Me.labelPrecioUnitarioDescuentoPorcentaje.Text = "% Descuento:"
        '
        'labelPrecioUnitarioDescuentoImporte
        '
        Me.labelPrecioUnitarioDescuentoImporte.AutoSize = True
        Me.labelPrecioUnitarioDescuentoImporte.Location = New System.Drawing.Point(12, 211)
        Me.labelPrecioUnitarioDescuentoImporte.Name = "labelPrecioUnitarioDescuentoImporte"
        Me.labelPrecioUnitarioDescuentoImporte.Size = New System.Drawing.Size(100, 13)
        Me.labelPrecioUnitarioDescuentoImporte.TabIndex = 19
        Me.labelPrecioUnitarioDescuentoImporte.Text = "Importe Descuento:"
        '
        'labelPrecioUnitarioFinal
        '
        Me.labelPrecioUnitarioFinal.AutoSize = True
        Me.labelPrecioUnitarioFinal.Location = New System.Drawing.Point(12, 237)
        Me.labelPrecioUnitarioFinal.Name = "labelPrecioUnitarioFinal"
        Me.labelPrecioUnitarioFinal.Size = New System.Drawing.Size(104, 13)
        Me.labelPrecioUnitarioFinal.TabIndex = 21
        Me.labelPrecioUnitarioFinal.Text = "Precio Unitario Final:"
        '
        'labelPrecioTotal
        '
        Me.labelPrecioTotal.AutoSize = True
        Me.labelPrecioTotal.Location = New System.Drawing.Point(12, 263)
        Me.labelPrecioTotal.Name = "labelPrecioTotal"
        Me.labelPrecioTotal.Size = New System.Drawing.Size(67, 13)
        Me.labelPrecioTotal.TabIndex = 23
        Me.labelPrecioTotal.Text = "Precio Total:"
        '
        'doubletextboxCantidad
        '
        Me.doubletextboxCantidad.BeforeTouchSize = New System.Drawing.Size(69, 20)
        Me.doubletextboxCantidad.DoubleValue = 1.0R
        Me.doubletextboxCantidad.Location = New System.Drawing.Point(123, 78)
        Me.doubletextboxCantidad.MaxValue = 999999.99R
        Me.doubletextboxCantidad.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxCantidad.MinValue = 0R
        Me.doubletextboxCantidad.Name = "doubletextboxCantidad"
        Me.doubletextboxCantidad.NullString = ""
        Me.doubletextboxCantidad.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxCantidad.Size = New System.Drawing.Size(69, 20)
        Me.doubletextboxCantidad.TabIndex = 3
        Me.doubletextboxCantidad.Text = "1,00"
        Me.doubletextboxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'currencytextboxPrecioUnitario
        '
        Me.currencytextboxPrecioUnitario.BeforeTouchSize = New System.Drawing.Size(69, 20)
        Me.currencytextboxPrecioUnitario.DecimalValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.currencytextboxPrecioUnitario.Location = New System.Drawing.Point(123, 156)
        Me.currencytextboxPrecioUnitario.MaxValue = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.currencytextboxPrecioUnitario.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.currencytextboxPrecioUnitario.MinValue = New Decimal(New Integer() {99999999, 0, 0, -2147352576})
        Me.currencytextboxPrecioUnitario.Name = "currencytextboxPrecioUnitario"
        Me.currencytextboxPrecioUnitario.NullString = ""
        Me.currencytextboxPrecioUnitario.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.currencytextboxPrecioUnitario.Size = New System.Drawing.Size(100, 20)
        Me.currencytextboxPrecioUnitario.TabIndex = 16
        Me.currencytextboxPrecioUnitario.Text = "$ 0,00"
        Me.currencytextboxPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'percenttextboxPrecioUnitarioDescuentoPorcentaje
        '
        Me.percenttextboxPrecioUnitarioDescuentoPorcentaje.BeforeTouchSize = New System.Drawing.Size(69, 20)
        Me.percenttextboxPrecioUnitarioDescuentoPorcentaje.DoubleValue = 0R
        Me.percenttextboxPrecioUnitarioDescuentoPorcentaje.Location = New System.Drawing.Point(123, 182)
        Me.percenttextboxPrecioUnitarioDescuentoPorcentaje.MaxValue = 100.0R
        Me.percenttextboxPrecioUnitarioDescuentoPorcentaje.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.percenttextboxPrecioUnitarioDescuentoPorcentaje.MinValue = 0R
        Me.percenttextboxPrecioUnitarioDescuentoPorcentaje.Name = "percenttextboxPrecioUnitarioDescuentoPorcentaje"
        Me.percenttextboxPrecioUnitarioDescuentoPorcentaje.NullString = ""
        Me.percenttextboxPrecioUnitarioDescuentoPorcentaje.PercentNegativePattern = 1
        Me.percenttextboxPrecioUnitarioDescuentoPorcentaje.PercentPositivePattern = 1
        Me.percenttextboxPrecioUnitarioDescuentoPorcentaje.Size = New System.Drawing.Size(69, 20)
        Me.percenttextboxPrecioUnitarioDescuentoPorcentaje.TabIndex = 18
        Me.percenttextboxPrecioUnitarioDescuentoPorcentaje.Text = "0,00%"
        Me.percenttextboxPrecioUnitarioDescuentoPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'currencytextboxPrecioUnitarioDescuentoImporte
        '
        Me.currencytextboxPrecioUnitarioDescuentoImporte.BeforeTouchSize = New System.Drawing.Size(69, 20)
        Me.currencytextboxPrecioUnitarioDescuentoImporte.DecimalValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.currencytextboxPrecioUnitarioDescuentoImporte.Location = New System.Drawing.Point(123, 208)
        Me.currencytextboxPrecioUnitarioDescuentoImporte.MaxValue = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.currencytextboxPrecioUnitarioDescuentoImporte.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.currencytextboxPrecioUnitarioDescuentoImporte.MinValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.currencytextboxPrecioUnitarioDescuentoImporte.Name = "currencytextboxPrecioUnitarioDescuentoImporte"
        Me.currencytextboxPrecioUnitarioDescuentoImporte.NullString = ""
        Me.currencytextboxPrecioUnitarioDescuentoImporte.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.currencytextboxPrecioUnitarioDescuentoImporte.Size = New System.Drawing.Size(100, 20)
        Me.currencytextboxPrecioUnitarioDescuentoImporte.TabIndex = 20
        Me.currencytextboxPrecioUnitarioDescuentoImporte.Text = "$ 0,00"
        Me.currencytextboxPrecioUnitarioDescuentoImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'currencytextboxPrecioUnitarioFinal
        '
        Me.currencytextboxPrecioUnitarioFinal.BeforeTouchSize = New System.Drawing.Size(69, 20)
        Me.currencytextboxPrecioUnitarioFinal.DecimalValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.currencytextboxPrecioUnitarioFinal.Location = New System.Drawing.Point(123, 234)
        Me.currencytextboxPrecioUnitarioFinal.MaxValue = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.currencytextboxPrecioUnitarioFinal.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.currencytextboxPrecioUnitarioFinal.MinValue = New Decimal(New Integer() {99999999, 0, 0, -2147352576})
        Me.currencytextboxPrecioUnitarioFinal.Name = "currencytextboxPrecioUnitarioFinal"
        Me.currencytextboxPrecioUnitarioFinal.NullString = ""
        Me.currencytextboxPrecioUnitarioFinal.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.currencytextboxPrecioUnitarioFinal.ReadOnly = True
        Me.currencytextboxPrecioUnitarioFinal.Size = New System.Drawing.Size(100, 20)
        Me.currencytextboxPrecioUnitarioFinal.TabIndex = 22
        Me.currencytextboxPrecioUnitarioFinal.Text = "$ 0,00"
        Me.currencytextboxPrecioUnitarioFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'currencytextboxPrecioTotal
        '
        Me.currencytextboxPrecioTotal.BeforeTouchSize = New System.Drawing.Size(69, 20)
        Me.currencytextboxPrecioTotal.DecimalValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.currencytextboxPrecioTotal.Location = New System.Drawing.Point(123, 260)
        Me.currencytextboxPrecioTotal.MaxValue = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.currencytextboxPrecioTotal.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.currencytextboxPrecioTotal.MinValue = New Decimal(New Integer() {99999999, 0, 0, -2147352576})
        Me.currencytextboxPrecioTotal.Name = "currencytextboxPrecioTotal"
        Me.currencytextboxPrecioTotal.NullString = ""
        Me.currencytextboxPrecioTotal.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.currencytextboxPrecioTotal.ReadOnly = True
        Me.currencytextboxPrecioTotal.Size = New System.Drawing.Size(100, 20)
        Me.currencytextboxPrecioTotal.TabIndex = 24
        Me.currencytextboxPrecioTotal.Text = "$ 0,00"
        Me.currencytextboxPrecioTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'formComprobanteDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 290)
        Me.Controls.Add(Me.currencytextboxPrecioTotal)
        Me.Controls.Add(Me.currencytextboxPrecioUnitarioFinal)
        Me.Controls.Add(Me.currencytextboxPrecioUnitarioDescuentoImporte)
        Me.Controls.Add(Me.percenttextboxPrecioUnitarioDescuentoPorcentaje)
        Me.Controls.Add(Me.currencytextboxPrecioUnitario)
        Me.Controls.Add(Me.doubletextboxCantidad)
        Me.Controls.Add(Me.labelPrecioTotal)
        Me.Controls.Add(Me.labelPrecioUnitarioFinal)
        Me.Controls.Add(Me.labelPrecioUnitarioDescuentoImporte)
        Me.Controls.Add(Me.labelPrecioUnitarioDescuentoPorcentaje)
        Me.Controls.Add(Me.labelPrecioUnitario)
        Me.Controls.Add(Me.labelDescripcion)
        Me.Controls.Add(Me.textboxDescripcion)
        Me.Controls.Add(Me.textboxUnidad)
        Me.Controls.Add(Me.labelUnidad)
        Me.Controls.Add(Me.labelCantidad)
        Me.Controls.Add(Me.comboboxArticulo)
        Me.Controls.Add(Me.labelArticulo)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formComprobanteDetalle"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalle"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        CType(Me.doubletextboxCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currencytextboxPrecioUnitario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.percenttextboxPrecioUnitarioDescuentoPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currencytextboxPrecioUnitarioDescuentoImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currencytextboxPrecioUnitarioFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currencytextboxPrecioTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents labelArticulo As System.Windows.Forms.Label
    Friend WithEvents comboboxArticulo As System.Windows.Forms.ComboBox
    Friend WithEvents labelCantidad As System.Windows.Forms.Label
    Friend WithEvents textboxUnidad As System.Windows.Forms.TextBox
    Friend WithEvents labelUnidad As System.Windows.Forms.Label
    Friend WithEvents textboxDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents labelDescripcion As System.Windows.Forms.Label
    Friend WithEvents labelPrecioUnitario As System.Windows.Forms.Label
    Friend WithEvents labelPrecioUnitarioDescuentoPorcentaje As System.Windows.Forms.Label
    Friend WithEvents labelPrecioUnitarioDescuentoImporte As System.Windows.Forms.Label
    Friend WithEvents labelPrecioUnitarioFinal As System.Windows.Forms.Label
    Friend WithEvents labelPrecioTotal As System.Windows.Forms.Label
    Friend WithEvents doubletextboxCantidad As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents currencytextboxPrecioUnitario As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents percenttextboxPrecioUnitarioDescuentoPorcentaje As Syncfusion.Windows.Forms.Tools.PercentTextBox
    Friend WithEvents currencytextboxPrecioUnitarioDescuentoImporte As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents currencytextboxPrecioUnitarioFinal As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents currencytextboxPrecioTotal As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
End Class
