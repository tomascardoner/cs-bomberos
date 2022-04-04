<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formComprobantes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.panelToolbars = New System.Windows.Forms.FlowLayoutPanel()
        Me.toolstripButtons = New System.Windows.Forms.ToolStrip()
        Me.buttonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.buttonImprimir = New System.Windows.Forms.ToolStripSplitButton()
        Me.menuitemImprimirOrdenCompra = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstripComprobanteTipo = New System.Windows.Forms.ToolStrip()
        Me.labelComprobanteTipo = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxOperacionTipo = New System.Windows.Forms.ToolStripComboBox()
        Me.comboboxComprobanteTipo = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripPeriodo = New System.Windows.Forms.ToolStrip()
        Me.labelPeriodo = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxPeriodoTipo = New System.Windows.Forms.ToolStripComboBox()
        Me.comboboxPeriodoValor = New System.Windows.Forms.ToolStripComboBox()
        Me.labelPeriodoFechaY = New System.Windows.Forms.ToolStripLabel()
        Me.toolstripEntidad = New System.Windows.Forms.ToolStrip()
        Me.labelEntidad = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxEntidad = New System.Windows.Forms.ToolStripComboBox()
        Me.columnFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnNumeroCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusstripMain.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelToolbars.SuspendLayout()
        Me.toolstripButtons.SuspendLayout()
        Me.toolstripComprobanteTipo.SuspendLayout()
        Me.toolstripPeriodo.SuspendLayout()
        Me.toolstripEntidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'statuslabelMain
        '
        Me.statuslabelMain.Name = "statuslabelMain"
        Me.statuslabelMain.Size = New System.Drawing.Size(845, 17)
        Me.statuslabelMain.Spring = True
        Me.statuslabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabelMain})
        Me.statusstripMain.Location = New System.Drawing.Point(0, 389)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(860, 22)
        Me.statusstripMain.TabIndex = 4
        '
        'datagridviewMain
        '
        Me.datagridviewMain.AllowUserToAddRows = False
        Me.datagridviewMain.AllowUserToDeleteRows = False
        Me.datagridviewMain.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagridviewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnFecha, Me.columnEntidad, Me.columnOperacion, Me.columnTipo, Me.columnNumeroCompleto, Me.columnFechaVencimiento, Me.columnImporte})
        Me.datagridviewMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewMain.Location = New System.Drawing.Point(0, 64)
        Me.datagridviewMain.MultiSelect = False
        Me.datagridviewMain.Name = "datagridviewMain"
        Me.datagridviewMain.ReadOnly = True
        Me.datagridviewMain.RowHeadersVisible = False
        Me.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewMain.Size = New System.Drawing.Size(860, 325)
        Me.datagridviewMain.TabIndex = 0
        '
        'panelToolbars
        '
        Me.panelToolbars.AutoSize = True
        Me.panelToolbars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelToolbars.Controls.Add(Me.toolstripButtons)
        Me.panelToolbars.Controls.Add(Me.toolstripComprobanteTipo)
        Me.panelToolbars.Controls.Add(Me.toolstripPeriodo)
        Me.panelToolbars.Controls.Add(Me.toolstripEntidad)
        Me.panelToolbars.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelToolbars.Location = New System.Drawing.Point(0, 0)
        Me.panelToolbars.Name = "panelToolbars"
        Me.panelToolbars.Size = New System.Drawing.Size(860, 64)
        Me.panelToolbars.TabIndex = 0
        '
        'toolstripButtons
        '
        Me.toolstripButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripButtons.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAgregar, Me.buttonEditar, Me.buttonEliminar, Me.buttonImprimir})
        Me.toolstripButtons.Location = New System.Drawing.Point(0, 0)
        Me.toolstripButtons.Name = "toolstripButtons"
        Me.toolstripButtons.Size = New System.Drawing.Size(348, 39)
        Me.toolstripButtons.TabIndex = 1
        '
        'buttonAgregar
        '
        Me.buttonAgregar.Image = Global.CSBomberos.My.Resources.Resources.ImageAgregar32
        Me.buttonAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAgregar.Name = "buttonAgregar"
        Me.buttonAgregar.Size = New System.Drawing.Size(85, 36)
        Me.buttonAgregar.Text = "Agregar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Image = Global.CSBomberos.My.Resources.Resources.ImageEditar32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Image = Global.CSBomberos.My.Resources.Resources.ImageBorrar32
        Me.buttonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(86, 36)
        Me.buttonEliminar.Text = "Eliminar"
        '
        'buttonImprimir
        '
        Me.buttonImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemImprimirOrdenCompra})
        Me.buttonImprimir.Image = Global.CSBomberos.My.Resources.Resources.ImageImprimir32
        Me.buttonImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonImprimir.Name = "buttonImprimir"
        Me.buttonImprimir.Size = New System.Drawing.Size(101, 36)
        Me.buttonImprimir.Text = "Imprimir"
        '
        'menuitemImprimirOrdenCompra
        '
        Me.menuitemImprimirOrdenCompra.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuitemImprimirOrdenCompra.Name = "menuitemImprimirOrdenCompra"
        Me.menuitemImprimirOrdenCompra.Size = New System.Drawing.Size(167, 22)
        Me.menuitemImprimirOrdenCompra.Text = "Orden de compra"
        '
        'toolstripComprobanteTipo
        '
        Me.toolstripComprobanteTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripComprobanteTipo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripComprobanteTipo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripComprobanteTipo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelComprobanteTipo, Me.comboboxOperacionTipo, Me.comboboxComprobanteTipo})
        Me.toolstripComprobanteTipo.Location = New System.Drawing.Point(348, 0)
        Me.toolstripComprobanteTipo.Name = "toolstripComprobanteTipo"
        Me.toolstripComprobanteTipo.Size = New System.Drawing.Size(265, 39)
        Me.toolstripComprobanteTipo.TabIndex = 16
        '
        'labelComprobanteTipo
        '
        Me.labelComprobanteTipo.Name = "labelComprobanteTipo"
        Me.labelComprobanteTipo.Size = New System.Drawing.Size(33, 36)
        Me.labelComprobanteTipo.Text = "Tipo:"
        '
        'comboboxOperacionTipo
        '
        Me.comboboxOperacionTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxOperacionTipo.Name = "comboboxOperacionTipo"
        Me.comboboxOperacionTipo.Size = New System.Drawing.Size(75, 39)
        '
        'comboboxComprobanteTipo
        '
        Me.comboboxComprobanteTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxComprobanteTipo.Name = "comboboxComprobanteTipo"
        Me.comboboxComprobanteTipo.Size = New System.Drawing.Size(150, 39)
        '
        'toolstripPeriodo
        '
        Me.toolstripPeriodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripPeriodo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripPeriodo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripPeriodo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelPeriodo, Me.comboboxPeriodoTipo, Me.comboboxPeriodoValor, Me.labelPeriodoFechaY})
        Me.toolstripPeriodo.Location = New System.Drawing.Point(0, 39)
        Me.toolstripPeriodo.Name = "toolstripPeriodo"
        Me.toolstripPeriodo.Size = New System.Drawing.Size(267, 25)
        Me.toolstripPeriodo.TabIndex = 15
        '
        'labelPeriodo
        '
        Me.labelPeriodo.Name = "labelPeriodo"
        Me.labelPeriodo.Size = New System.Drawing.Size(51, 22)
        Me.labelPeriodo.Text = "Período:"
        '
        'comboboxPeriodoTipo
        '
        Me.comboboxPeriodoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxPeriodoTipo.Name = "comboboxPeriodoTipo"
        Me.comboboxPeriodoTipo.Size = New System.Drawing.Size(75, 25)
        '
        'comboboxPeriodoValor
        '
        Me.comboboxPeriodoValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxPeriodoValor.Name = "comboboxPeriodoValor"
        Me.comboboxPeriodoValor.Size = New System.Drawing.Size(121, 25)
        '
        'labelPeriodoFechaY
        '
        Me.labelPeriodoFechaY.Name = "labelPeriodoFechaY"
        Me.labelPeriodoFechaY.Size = New System.Drawing.Size(13, 22)
        Me.labelPeriodoFechaY.Text = "y"
        '
        'toolstripEntidad
        '
        Me.toolstripEntidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripEntidad.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripEntidad.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelEntidad, Me.comboboxEntidad})
        Me.toolstripEntidad.Location = New System.Drawing.Point(267, 39)
        Me.toolstripEntidad.Name = "toolstripEntidad"
        Me.toolstripEntidad.Size = New System.Drawing.Size(369, 25)
        Me.toolstripEntidad.TabIndex = 13
        '
        'labelEntidad
        '
        Me.labelEntidad.Name = "labelEntidad"
        Me.labelEntidad.Size = New System.Drawing.Size(64, 22)
        Me.labelEntidad.Text = "Proveedor:"
        '
        'comboboxEntidad
        '
        Me.comboboxEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxEntidad.Name = "comboboxEntidad"
        Me.comboboxEntidad.Size = New System.Drawing.Size(300, 25)
        '
        'columnFecha
        '
        Me.columnFecha.DataPropertyName = "Fecha"
        Me.columnFecha.HeaderText = "Fecha"
        Me.columnFecha.Name = "columnFecha"
        Me.columnFecha.ReadOnly = True
        Me.columnFecha.Width = 62
        '
        'columnEntidad
        '
        Me.columnEntidad.DataPropertyName = "EntidadNombre"
        Me.columnEntidad.HeaderText = "Entidad"
        Me.columnEntidad.Name = "columnEntidad"
        Me.columnEntidad.ReadOnly = True
        Me.columnEntidad.Width = 68
        '
        'columnOperacion
        '
        Me.columnOperacion.DataPropertyName = "OperacionTipoNombre"
        Me.columnOperacion.HeaderText = "Operación"
        Me.columnOperacion.Name = "columnOperacion"
        Me.columnOperacion.ReadOnly = True
        Me.columnOperacion.Width = 81
        '
        'columnTipo
        '
        Me.columnTipo.DataPropertyName = "ComprobanteTipoNombre"
        Me.columnTipo.HeaderText = "Tipo"
        Me.columnTipo.Name = "columnTipo"
        Me.columnTipo.ReadOnly = True
        Me.columnTipo.Width = 53
        '
        'columnNumeroCompleto
        '
        Me.columnNumeroCompleto.DataPropertyName = "NumeroCompleto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.columnNumeroCompleto.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnNumeroCompleto.HeaderText = "Número"
        Me.columnNumeroCompleto.Name = "columnNumeroCompleto"
        Me.columnNumeroCompleto.ReadOnly = True
        Me.columnNumeroCompleto.Width = 69
        '
        'columnFechaVencimiento
        '
        Me.columnFechaVencimiento.DataPropertyName = "FechaVencimiento"
        Me.columnFechaVencimiento.HeaderText = "Vencimiento"
        Me.columnFechaVencimiento.Name = "columnFechaVencimiento"
        Me.columnFechaVencimiento.ReadOnly = True
        Me.columnFechaVencimiento.Width = 90
        '
        'columnImporte
        '
        Me.columnImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.columnImporte.DefaultCellStyle = DataGridViewCellStyle3
        Me.columnImporte.HeaderText = "Importe"
        Me.columnImporte.Name = "columnImporte"
        Me.columnImporte.ReadOnly = True
        Me.columnImporte.Width = 67
        '
        'formComprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 411)
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.panelToolbars)
        Me.Controls.Add(Me.statusstripMain)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formComprobantes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Comprobantes"
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelToolbars.ResumeLayout(False)
        Me.panelToolbars.PerformLayout()
        Me.toolstripButtons.ResumeLayout(False)
        Me.toolstripButtons.PerformLayout()
        Me.toolstripComprobanteTipo.ResumeLayout(False)
        Me.toolstripComprobanteTipo.PerformLayout()
        Me.toolstripPeriodo.ResumeLayout(False)
        Me.toolstripPeriodo.PerformLayout()
        Me.toolstripEntidad.ResumeLayout(False)
        Me.toolstripEntidad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statuslabelMain As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusstripMain As System.Windows.Forms.StatusStrip
    Friend WithEvents datagridviewMain As System.Windows.Forms.DataGridView
    Friend WithEvents panelToolbars As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents toolstripButtons As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripEntidad As System.Windows.Forms.ToolStrip
    Friend WithEvents labelEntidad As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxEntidad As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripPeriodo As ToolStrip
    Friend WithEvents labelPeriodo As ToolStripLabel
    Friend WithEvents comboboxPeriodoTipo As ToolStripComboBox
    Friend WithEvents comboboxPeriodoValor As ToolStripComboBox
    Friend WithEvents labelPeriodoFechaY As ToolStripLabel
    Friend WithEvents buttonImprimir As ToolStripSplitButton
    Friend WithEvents menuitemImprimirOrdenCompra As ToolStripMenuItem
    Friend WithEvents toolstripComprobanteTipo As ToolStrip
    Friend WithEvents labelComprobanteTipo As ToolStripLabel
    Friend WithEvents comboboxOperacionTipo As ToolStripComboBox
    Friend WithEvents comboboxComprobanteTipo As ToolStripComboBox
    Friend WithEvents columnFecha As DataGridViewTextBoxColumn
    Friend WithEvents columnEntidad As DataGridViewTextBoxColumn
    Friend WithEvents columnOperacion As DataGridViewTextBoxColumn
    Friend WithEvents columnTipo As DataGridViewTextBoxColumn
    Friend WithEvents columnNumeroCompleto As DataGridViewTextBoxColumn
    Friend WithEvents columnFechaVencimiento As DataGridViewTextBoxColumn
    Friend WithEvents columnImporte As DataGridViewTextBoxColumn
End Class
