﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCompraOrdenDetalle
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
        Dim labelDetalle As System.Windows.Forms.Label
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.labelArea = New System.Windows.Forms.Label()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.comboboxArea = New System.Windows.Forms.ComboBox()
        Me.tabcontrolMain = New System.Windows.Forms.TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.labelFactura = New System.Windows.Forms.Label()
        Me.comboBoxFactura = New System.Windows.Forms.ComboBox()
        Me.currencytextboxImporte = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.textboxDetalle = New System.Windows.Forms.TextBox()
        Me.labelImporte = New System.Windows.Forms.Label()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.labelID = New System.Windows.Forms.Label()
        Me.textboxID = New System.Windows.Forms.TextBox()
        labelDetalle = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        CType(Me.currencytextboxImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelDetalle
        '
        labelDetalle.AutoSize = True
        labelDetalle.Location = New System.Drawing.Point(6, 63)
        labelDetalle.Name = "labelDetalle"
        labelDetalle.Size = New System.Drawing.Size(43, 13)
        labelDetalle.TabIndex = 4
        labelDetalle.Text = "Detalle:"
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
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(542, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'labelArea
        '
        Me.labelArea.AutoSize = True
        Me.labelArea.Location = New System.Drawing.Point(6, 36)
        Me.labelArea.Name = "labelArea"
        Me.labelArea.Size = New System.Drawing.Size(32, 13)
        Me.labelArea.TabIndex = 2
        Me.labelArea.Text = "Área:"
        '
        'textboxNotas
        '
        Me.textboxNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxNotas.Location = New System.Drawing.Point(50, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(454, 220)
        Me.textboxNotas.TabIndex = 1
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(6, 9)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 0
        Me.labelNotas.Text = "Notas:"
        '
        'comboboxArea
        '
        Me.comboboxArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboboxArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxArea.FormattingEnabled = True
        Me.comboboxArea.Location = New System.Drawing.Point(58, 33)
        Me.comboboxArea.Name = "comboboxArea"
        Me.comboboxArea.Size = New System.Drawing.Size(446, 21)
        Me.comboboxArea.TabIndex = 3
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(518, 287)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.labelFactura)
        Me.tabpageGeneral.Controls.Add(Me.comboBoxFactura)
        Me.tabpageGeneral.Controls.Add(Me.currencytextboxImporte)
        Me.tabpageGeneral.Controls.Add(Me.textboxDetalle)
        Me.tabpageGeneral.Controls.Add(Me.labelImporte)
        Me.tabpageGeneral.Controls.Add(Me.labelArea)
        Me.tabpageGeneral.Controls.Add(labelDetalle)
        Me.tabpageGeneral.Controls.Add(Me.comboboxArea)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(510, 258)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'labelFactura
        '
        Me.labelFactura.AutoSize = True
        Me.labelFactura.Location = New System.Drawing.Point(6, 9)
        Me.labelFactura.Name = "labelFactura"
        Me.labelFactura.Size = New System.Drawing.Size(46, 13)
        Me.labelFactura.TabIndex = 0
        Me.labelFactura.Text = "Factura:"
        '
        'comboBoxFactura
        '
        Me.comboBoxFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxFactura.FormattingEnabled = True
        Me.comboBoxFactura.Location = New System.Drawing.Point(58, 6)
        Me.comboBoxFactura.Name = "comboBoxFactura"
        Me.comboBoxFactura.Size = New System.Drawing.Size(159, 21)
        Me.comboBoxFactura.TabIndex = 1
        '
        'currencytextboxImporte
        '
        Me.currencytextboxImporte.AllowNull = True
        Me.currencytextboxImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.currencytextboxImporte.BeforeTouchSize = New System.Drawing.Size(119, 20)
        Me.currencytextboxImporte.DecimalValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxImporte.ForeColor = System.Drawing.SystemColors.WindowText
        Me.currencytextboxImporte.Location = New System.Drawing.Point(58, 235)
        Me.currencytextboxImporte.MaxValue = New Decimal(New Integer() {1410065407, 2, 0, 131072})
        Me.currencytextboxImporte.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.currencytextboxImporte.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxImporte.Name = "currencytextboxImporte"
        Me.currencytextboxImporte.NullString = ""
        Me.currencytextboxImporte.Size = New System.Drawing.Size(119, 20)
        Me.currencytextboxImporte.TabIndex = 7
        Me.currencytextboxImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'textboxDetalle
        '
        Me.textboxDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxDetalle.Location = New System.Drawing.Point(58, 60)
        Me.textboxDetalle.MaxLength = 0
        Me.textboxDetalle.Multiline = True
        Me.textboxDetalle.Name = "textboxDetalle"
        Me.textboxDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxDetalle.Size = New System.Drawing.Size(446, 169)
        Me.textboxDetalle.TabIndex = 5
        '
        'labelImporte
        '
        Me.labelImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelImporte.AutoSize = True
        Me.labelImporte.Location = New System.Drawing.Point(3, 239)
        Me.labelImporte.Name = "labelImporte"
        Me.labelImporte.Size = New System.Drawing.Size(45, 13)
        Me.labelImporte.TabIndex = 6
        Me.labelImporte.Text = "Importe:"
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelID)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxID)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxNotas)
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelNotas)
        Me.tabpageNotasAuditoria.Location = New System.Drawing.Point(4, 25)
        Me.tabpageNotasAuditoria.Name = "tabpageNotasAuditoria"
        Me.tabpageNotasAuditoria.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(510, 258)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelID
        '
        Me.labelID.AutoSize = True
        Me.labelID.Location = New System.Drawing.Point(6, 235)
        Me.labelID.Name = "labelID"
        Me.labelID.Size = New System.Drawing.Size(21, 13)
        Me.labelID.TabIndex = 2
        Me.labelID.Text = "ID:"
        '
        'textboxID
        '
        Me.textboxID.Location = New System.Drawing.Point(50, 232)
        Me.textboxID.MaxLength = 10
        Me.textboxID.Name = "textboxID"
        Me.textboxID.ReadOnly = True
        Me.textboxID.Size = New System.Drawing.Size(72, 20)
        Me.textboxID.TabIndex = 3
        Me.textboxID.TabStop = False
        Me.textboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'formCompraOrdenDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 341)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formCompraOrdenDetalle"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalle de la órden de compra"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        CType(Me.currencytextboxImporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpageNotasAuditoria.ResumeLayout(False)
        Me.tabpageNotasAuditoria.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents labelArea As System.Windows.Forms.Label
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents comboboxArea As System.Windows.Forms.ComboBox
    Friend WithEvents tabcontrolMain As System.Windows.Forms.TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents labelID As System.Windows.Forms.Label
    Friend WithEvents textboxID As System.Windows.Forms.TextBox
    Friend WithEvents labelImporte As Label
    Friend WithEvents textboxDetalle As TextBox
    Friend WithEvents currencytextboxImporte As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents labelFactura As Label
    Friend WithEvents comboBoxFactura As ComboBox
End Class
