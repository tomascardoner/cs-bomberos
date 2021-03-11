<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formReportesParametroVarios
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
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAceptar = New System.Windows.Forms.ToolStripButton()
        Me.labelValor = New System.Windows.Forms.Label()
        Me.datetimepickerValorFecha = New System.Windows.Forms.DateTimePicker()
        Me.doubletextboxValor = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.currencytextboxValor = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.comboboxValor = New System.Windows.Forms.ComboBox()
        Me.datetimepickerValorHora = New System.Windows.Forms.DateTimePicker()
        Me.toolstripMain.SuspendLayout()
        CType(Me.doubletextboxValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currencytextboxValor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCancelar, Me.buttonAceptar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(315, 39)
        Me.toolstripMain.TabIndex = 7
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
        'labelValor
        '
        Me.labelValor.AutoSize = True
        Me.labelValor.Location = New System.Drawing.Point(12, 68)
        Me.labelValor.Name = "labelValor"
        Me.labelValor.Size = New System.Drawing.Size(34, 13)
        Me.labelValor.TabIndex = 0
        Me.labelValor.Text = "Valor:"
        '
        'datetimepickerValorFecha
        '
        Me.datetimepickerValorFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerValorFecha.Location = New System.Drawing.Point(183, 66)
        Me.datetimepickerValorFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerValorFecha.MinDate = New Date(1901, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerValorFecha.Name = "datetimepickerValorFecha"
        Me.datetimepickerValorFecha.Size = New System.Drawing.Size(120, 20)
        Me.datetimepickerValorFecha.TabIndex = 31
        '
        'doubletextboxValor
        '
        Me.doubletextboxValor.BeforeTouchSize = New System.Drawing.Size(69, 20)
        Me.doubletextboxValor.DoubleValue = 0R
        Me.doubletextboxValor.Location = New System.Drawing.Point(234, 66)
        Me.doubletextboxValor.MaxValue = 999999.99R
        Me.doubletextboxValor.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxValor.MinValue = 0R
        Me.doubletextboxValor.Name = "doubletextboxValor"
        Me.doubletextboxValor.NullString = ""
        Me.doubletextboxValor.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxValor.Size = New System.Drawing.Size(69, 20)
        Me.doubletextboxValor.TabIndex = 35
        Me.doubletextboxValor.Text = "0,00"
        Me.doubletextboxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'currencytextboxValor
        '
        Me.currencytextboxValor.BeforeTouchSize = New System.Drawing.Size(69, 20)
        Me.currencytextboxValor.DecimalValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.currencytextboxValor.Location = New System.Drawing.Point(203, 66)
        Me.currencytextboxValor.MaxValue = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.currencytextboxValor.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.currencytextboxValor.MinValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.currencytextboxValor.Name = "currencytextboxValor"
        Me.currencytextboxValor.NullString = ""
        Me.currencytextboxValor.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.currencytextboxValor.Size = New System.Drawing.Size(100, 20)
        Me.currencytextboxValor.TabIndex = 34
        Me.currencytextboxValor.Text = "$ 0,00"
        Me.currencytextboxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'comboboxValor
        '
        Me.comboboxValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxValor.FormattingEnabled = True
        Me.comboboxValor.Location = New System.Drawing.Point(183, 65)
        Me.comboboxValor.Name = "comboboxValor"
        Me.comboboxValor.Size = New System.Drawing.Size(120, 21)
        Me.comboboxValor.TabIndex = 36
        '
        'datetimepickerValorHora
        '
        Me.datetimepickerValorHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.datetimepickerValorHora.Location = New System.Drawing.Point(221, 66)
        Me.datetimepickerValorHora.MaxDate = New Date(1900, 1, 1, 23, 59, 59, 0)
        Me.datetimepickerValorHora.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerValorHora.Name = "datetimepickerValorHora"
        Me.datetimepickerValorHora.ShowUpDown = True
        Me.datetimepickerValorHora.Size = New System.Drawing.Size(82, 20)
        Me.datetimepickerValorHora.TabIndex = 37
        Me.datetimepickerValorHora.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'formReportesParametroVarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 101)
        Me.Controls.Add(Me.datetimepickerValorHora)
        Me.Controls.Add(Me.doubletextboxValor)
        Me.Controls.Add(Me.currencytextboxValor)
        Me.Controls.Add(Me.datetimepickerValorFecha)
        Me.Controls.Add(Me.comboboxValor)
        Me.Controls.Add(Me.labelValor)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formReportesParametroVarios"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Especifique el valor"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        CType(Me.doubletextboxValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currencytextboxValor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents labelValor As System.Windows.Forms.Label
    Friend WithEvents datetimepickerValorFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents doubletextboxValor As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents currencytextboxValor As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents comboboxValor As ComboBox
    Friend WithEvents datetimepickerValorHora As DateTimePicker
End Class
