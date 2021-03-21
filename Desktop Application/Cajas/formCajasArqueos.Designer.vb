<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCajasArqueos
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.toolstripCuartel = New System.Windows.Forms.ToolStrip()
        Me.labelCaja = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxCaja = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripPeriodo = New System.Windows.Forms.ToolStrip()
        Me.labelFechaCierre = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxPeriodoTipo = New System.Windows.Forms.ToolStripComboBox()
        Me.comboboxPeriodoValor = New System.Windows.Forms.ToolStripComboBox()
        Me.labelPeriodoFechaY = New System.Windows.Forms.ToolStripLabel()
        Me.toolstripCerrada = New System.Windows.Forms.ToolStrip()
        Me.labelCerrada = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxCerrada = New System.Windows.Forms.ToolStripComboBox()
        Me.columnCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnIDArqueo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnSaldoInicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnImporteAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnSaldoActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFechaCierre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusstripMain.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelToolbars.SuspendLayout()
        Me.toolstripButtons.SuspendLayout()
        Me.toolstripCuartel.SuspendLayout()
        Me.toolstripPeriodo.SuspendLayout()
        Me.toolstripCerrada.SuspendLayout()
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
        Me.datagridviewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnCaja, Me.columnIDArqueo, Me.columnSaldoInicial, Me.columnImporteAsignado, Me.columnSaldoActual, Me.columnFechaCierre})
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
        Me.panelToolbars.Controls.Add(Me.toolstripCuartel)
        Me.panelToolbars.Controls.Add(Me.toolstripPeriodo)
        Me.panelToolbars.Controls.Add(Me.toolstripCerrada)
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
        Me.buttonAgregar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAgregar.Name = "buttonAgregar"
        Me.buttonAgregar.Size = New System.Drawing.Size(85, 36)
        Me.buttonAgregar.Text = "Agregar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(86, 36)
        Me.buttonEliminar.Text = "Eliminar"
        '
        'buttonImprimir
        '
        Me.buttonImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemImprimirOrdenCompra})
        Me.buttonImprimir.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_PRINT_32
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
        'toolstripCuartel
        '
        Me.toolstripCuartel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripCuartel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripCuartel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelCaja, Me.comboboxCaja})
        Me.toolstripCuartel.Location = New System.Drawing.Point(348, 0)
        Me.toolstripCuartel.Name = "toolstripCuartel"
        Me.toolstripCuartel.Size = New System.Drawing.Size(168, 39)
        Me.toolstripCuartel.TabIndex = 16
        '
        'labelCaja
        '
        Me.labelCaja.Name = "labelCaja"
        Me.labelCaja.Size = New System.Drawing.Size(33, 36)
        Me.labelCaja.Text = "Caja:"
        '
        'comboboxCaja
        '
        Me.comboboxCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCaja.Name = "comboboxCaja"
        Me.comboboxCaja.Size = New System.Drawing.Size(130, 39)
        '
        'toolstripPeriodo
        '
        Me.toolstripPeriodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripPeriodo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripPeriodo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripPeriodo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelFechaCierre, Me.comboboxPeriodoTipo, Me.comboboxPeriodoValor, Me.labelPeriodoFechaY})
        Me.toolstripPeriodo.Location = New System.Drawing.Point(516, 0)
        Me.toolstripPeriodo.Name = "toolstripPeriodo"
        Me.toolstripPeriodo.Size = New System.Drawing.Size(305, 39)
        Me.toolstripPeriodo.TabIndex = 15
        '
        'labelFechaCierre
        '
        Me.labelFechaCierre.Name = "labelFechaCierre"
        Me.labelFechaCierre.Size = New System.Drawing.Size(89, 36)
        Me.labelFechaCierre.Text = "Fecha de cierre:"
        '
        'comboboxPeriodoTipo
        '
        Me.comboboxPeriodoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxPeriodoTipo.Name = "comboboxPeriodoTipo"
        Me.comboboxPeriodoTipo.Size = New System.Drawing.Size(75, 39)
        '
        'comboboxPeriodoValor
        '
        Me.comboboxPeriodoValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxPeriodoValor.Name = "comboboxPeriodoValor"
        Me.comboboxPeriodoValor.Size = New System.Drawing.Size(121, 39)
        '
        'labelPeriodoFechaY
        '
        Me.labelPeriodoFechaY.Name = "labelPeriodoFechaY"
        Me.labelPeriodoFechaY.Size = New System.Drawing.Size(13, 36)
        Me.labelPeriodoFechaY.Text = "y"
        '
        'toolstripCerrada
        '
        Me.toolstripCerrada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripCerrada.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripCerrada.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelCerrada, Me.comboboxCerrada})
        Me.toolstripCerrada.Location = New System.Drawing.Point(0, 39)
        Me.toolstripCerrada.Name = "toolstripCerrada"
        Me.toolstripCerrada.Size = New System.Drawing.Size(131, 25)
        Me.toolstripCerrada.TabIndex = 12
        '
        'labelCerrada
        '
        Me.labelCerrada.Name = "labelCerrada"
        Me.labelCerrada.Size = New System.Drawing.Size(51, 22)
        Me.labelCerrada.Text = "Cerrada:"
        '
        'comboboxCerrada
        '
        Me.comboboxCerrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCerrada.Name = "comboboxCerrada"
        Me.comboboxCerrada.Size = New System.Drawing.Size(75, 25)
        '
        'columnCaja
        '
        Me.columnCaja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnCaja.DataPropertyName = "CajaNombre"
        Me.columnCaja.HeaderText = "Caja"
        Me.columnCaja.Name = "columnCaja"
        Me.columnCaja.ReadOnly = True
        Me.columnCaja.Width = 53
        '
        'columnIDArqueo
        '
        Me.columnIDArqueo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnIDArqueo.DataPropertyName = "IDArqueo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.columnIDArqueo.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnIDArqueo.HeaderText = "Número"
        Me.columnIDArqueo.Name = "columnIDArqueo"
        Me.columnIDArqueo.ReadOnly = True
        Me.columnIDArqueo.Width = 69
        '
        'columnSaldoInicial
        '
        Me.columnSaldoInicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnSaldoInicial.DataPropertyName = "SaldoInicial"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.columnSaldoInicial.DefaultCellStyle = DataGridViewCellStyle3
        Me.columnSaldoInicial.HeaderText = "Saldo inicial"
        Me.columnSaldoInicial.Name = "columnSaldoInicial"
        Me.columnSaldoInicial.ReadOnly = True
        Me.columnSaldoInicial.Width = 88
        '
        'columnImporteAsignado
        '
        Me.columnImporteAsignado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnImporteAsignado.DataPropertyName = "ImporteAsignado"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.columnImporteAsignado.DefaultCellStyle = DataGridViewCellStyle4
        Me.columnImporteAsignado.HeaderText = "Importe asignado"
        Me.columnImporteAsignado.Name = "columnImporteAsignado"
        Me.columnImporteAsignado.ReadOnly = True
        Me.columnImporteAsignado.Width = 104
        '
        'columnSaldoActual
        '
        Me.columnSaldoActual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnSaldoActual.DataPropertyName = "SaldoActual"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.columnSaldoActual.DefaultCellStyle = DataGridViewCellStyle5
        Me.columnSaldoActual.HeaderText = "Saldo actual"
        Me.columnSaldoActual.Name = "columnSaldoActual"
        Me.columnSaldoActual.ReadOnly = True
        Me.columnSaldoActual.Width = 84
        '
        'columnFechaCierre
        '
        Me.columnFechaCierre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnFechaCierre.DataPropertyName = "FechaCierre"
        Me.columnFechaCierre.HeaderText = "Fecha de cierre"
        Me.columnFechaCierre.Name = "columnFechaCierre"
        Me.columnFechaCierre.ReadOnly = True
        Me.columnFechaCierre.Width = 74
        '
        'formCajasArqueos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 411)
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.panelToolbars)
        Me.Controls.Add(Me.statusstripMain)
        Me.Name = "formCajasArqueos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Arqueos de cajas"
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelToolbars.ResumeLayout(False)
        Me.panelToolbars.PerformLayout()
        Me.toolstripButtons.ResumeLayout(False)
        Me.toolstripButtons.PerformLayout()
        Me.toolstripCuartel.ResumeLayout(False)
        Me.toolstripCuartel.PerformLayout()
        Me.toolstripPeriodo.ResumeLayout(False)
        Me.toolstripPeriodo.PerformLayout()
        Me.toolstripCerrada.ResumeLayout(False)
        Me.toolstripCerrada.PerformLayout()
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
    Friend WithEvents toolstripCerrada As System.Windows.Forms.ToolStrip
    Friend WithEvents labelCerrada As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxCerrada As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripPeriodo As ToolStrip
    Friend WithEvents labelFechaCierre As ToolStripLabel
    Friend WithEvents comboboxPeriodoTipo As ToolStripComboBox
    Friend WithEvents comboboxPeriodoValor As ToolStripComboBox
    Friend WithEvents labelPeriodoFechaY As ToolStripLabel
    Friend WithEvents buttonImprimir As ToolStripSplitButton
    Friend WithEvents menuitemImprimirOrdenCompra As ToolStripMenuItem
    Friend WithEvents toolstripCuartel As ToolStrip
    Friend WithEvents labelCaja As ToolStripLabel
    Friend WithEvents comboboxCaja As ToolStripComboBox
    Friend WithEvents columnCaja As DataGridViewTextBoxColumn
    Friend WithEvents columnIDArqueo As DataGridViewTextBoxColumn
    Friend WithEvents columnSaldoInicial As DataGridViewTextBoxColumn
    Friend WithEvents columnImporteAsignado As DataGridViewTextBoxColumn
    Friend WithEvents columnSaldoActual As DataGridViewTextBoxColumn
    Friend WithEvents columnFechaCierre As DataGridViewTextBoxColumn
End Class
