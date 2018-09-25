<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formInventario))
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.panelToolbars = New System.Windows.Forms.FlowLayoutPanel()
        Me.toolstripButtons = New System.Windows.Forms.ToolStrip()
        Me.buttonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripBuscar = New System.Windows.Forms.ToolStrip()
        Me.labelBuscar = New System.Windows.Forms.ToolStripLabel()
        Me.textboxBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.buttonBuscarBorrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripCuartel = New System.Windows.Forms.ToolStrip()
        Me.labelCuartel = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxCuartel = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripArea = New System.Windows.Forms.ToolStrip()
        Me.labelArea = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxArea = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripUbicacion = New System.Windows.Forms.ToolStrip()
        Me.labelUbicacion = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxUbicacion = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripSubUbicacion = New System.Windows.Forms.ToolStrip()
        Me.labelSubUbicacion = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxSubUbicacion = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripActivo = New System.Windows.Forms.ToolStrip()
        Me.labelActivo = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxActivo = New System.Windows.Forms.ToolStripComboBox()
        Me.columnCuartel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDescripcionPropia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnUbicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnSubUbicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnEsActivo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.statusstripMain.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelToolbars.SuspendLayout()
        Me.toolstripButtons.SuspendLayout()
        Me.toolstripBuscar.SuspendLayout()
        Me.toolstripCuartel.SuspendLayout()
        Me.toolstripArea.SuspendLayout()
        Me.toolstripUbicacion.SuspendLayout()
        Me.toolstripSubUbicacion.SuspendLayout()
        Me.toolstripActivo.SuspendLayout()
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
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnCuartel, Me.columnArea, Me.columnCodigo, Me.columnNombre, Me.columnDescripcionPropia, Me.columnUbicacion, Me.columnSubUbicacion, Me.columnEsActivo})
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
        Me.panelToolbars.Controls.Add(Me.toolstripBuscar)
        Me.panelToolbars.Controls.Add(Me.toolstripCuartel)
        Me.panelToolbars.Controls.Add(Me.toolstripArea)
        Me.panelToolbars.Controls.Add(Me.toolstripUbicacion)
        Me.panelToolbars.Controls.Add(Me.toolstripSubUbicacion)
        Me.panelToolbars.Controls.Add(Me.toolstripActivo)
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
        Me.toolstripButtons.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAgregar, Me.buttonEditar, Me.buttonEliminar})
        Me.toolstripButtons.Location = New System.Drawing.Point(0, 0)
        Me.toolstripButtons.Name = "toolstripButtons"
        Me.toolstripButtons.Size = New System.Drawing.Size(247, 39)
        Me.toolstripButtons.TabIndex = 1
        '
        'buttonAgregar
        '
        Me.buttonAgregar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAgregar.Name = "buttonAgregar"
        Me.buttonAgregar.Size = New System.Drawing.Size(85, 36)
        Me.buttonAgregar.Text = "Agregar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(86, 36)
        Me.buttonEliminar.Text = "Eliminar"
        '
        'toolstripBuscar
        '
        Me.toolstripBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripBuscar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripBuscar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelBuscar, Me.textboxBuscar, Me.buttonBuscarBorrar})
        Me.toolstripBuscar.Location = New System.Drawing.Point(247, 0)
        Me.toolstripBuscar.Name = "toolstripBuscar"
        Me.toolstripBuscar.Size = New System.Drawing.Size(193, 39)
        Me.toolstripBuscar.TabIndex = 17
        '
        'labelBuscar
        '
        Me.labelBuscar.Name = "labelBuscar"
        Me.labelBuscar.Size = New System.Drawing.Size(45, 36)
        Me.labelBuscar.Text = "Buscar:"
        '
        'textboxBuscar
        '
        Me.textboxBuscar.MaxLength = 100
        Me.textboxBuscar.Name = "textboxBuscar"
        Me.textboxBuscar.Size = New System.Drawing.Size(120, 39)
        '
        'buttonBuscarBorrar
        '
        Me.buttonBuscarBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonBuscarBorrar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_CLOSE_16
        Me.buttonBuscarBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonBuscarBorrar.Name = "buttonBuscarBorrar"
        Me.buttonBuscarBorrar.Size = New System.Drawing.Size(23, 36)
        Me.buttonBuscarBorrar.ToolTipText = "Limpiar búsqueda"
        '
        'toolstripCuartel
        '
        Me.toolstripCuartel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripCuartel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripCuartel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelCuartel, Me.comboboxCuartel})
        Me.toolstripCuartel.Location = New System.Drawing.Point(440, 0)
        Me.toolstripCuartel.Name = "toolstripCuartel"
        Me.toolstripCuartel.Size = New System.Drawing.Size(183, 39)
        Me.toolstripCuartel.TabIndex = 13
        '
        'labelCuartel
        '
        Me.labelCuartel.Name = "labelCuartel"
        Me.labelCuartel.Size = New System.Drawing.Size(48, 36)
        Me.labelCuartel.Text = "Cuartel:"
        '
        'comboboxCuartel
        '
        Me.comboboxCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCuartel.Name = "comboboxCuartel"
        Me.comboboxCuartel.Size = New System.Drawing.Size(130, 39)
        '
        'toolstripArea
        '
        Me.toolstripArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripArea.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripArea.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelArea, Me.comboboxArea})
        Me.toolstripArea.Location = New System.Drawing.Point(623, 0)
        Me.toolstripArea.Name = "toolstripArea"
        Me.toolstripArea.Size = New System.Drawing.Size(189, 39)
        Me.toolstripArea.TabIndex = 14
        '
        'labelArea
        '
        Me.labelArea.Name = "labelArea"
        Me.labelArea.Size = New System.Drawing.Size(34, 36)
        Me.labelArea.Text = "Area:"
        '
        'comboboxArea
        '
        Me.comboboxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxArea.Name = "comboboxArea"
        Me.comboboxArea.Size = New System.Drawing.Size(150, 39)
        '
        'toolstripUbicacion
        '
        Me.toolstripUbicacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripUbicacion.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripUbicacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelUbicacion, Me.comboboxUbicacion})
        Me.toolstripUbicacion.Location = New System.Drawing.Point(0, 39)
        Me.toolstripUbicacion.Name = "toolstripUbicacion"
        Me.toolstripUbicacion.Size = New System.Drawing.Size(268, 25)
        Me.toolstripUbicacion.TabIndex = 15
        '
        'labelUbicacion
        '
        Me.labelUbicacion.Name = "labelUbicacion"
        Me.labelUbicacion.Size = New System.Drawing.Size(63, 22)
        Me.labelUbicacion.Text = "Ubicación:"
        '
        'comboboxUbicacion
        '
        Me.comboboxUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxUbicacion.Name = "comboboxUbicacion"
        Me.comboboxUbicacion.Size = New System.Drawing.Size(200, 25)
        '
        'toolstripSubUbicacion
        '
        Me.toolstripSubUbicacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripSubUbicacion.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripSubUbicacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelSubUbicacion, Me.comboboxSubUbicacion})
        Me.toolstripSubUbicacion.Location = New System.Drawing.Point(268, 39)
        Me.toolstripSubUbicacion.Name = "toolstripSubUbicacion"
        Me.toolstripSubUbicacion.Size = New System.Drawing.Size(293, 25)
        Me.toolstripSubUbicacion.TabIndex = 16
        '
        'labelSubUbicacion
        '
        Me.labelSubUbicacion.Name = "labelSubUbicacion"
        Me.labelSubUbicacion.Size = New System.Drawing.Size(88, 22)
        Me.labelSubUbicacion.Text = "Sub-Ubicación:"
        '
        'comboboxSubUbicacion
        '
        Me.comboboxSubUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxSubUbicacion.Name = "comboboxSubUbicacion"
        Me.comboboxSubUbicacion.Size = New System.Drawing.Size(200, 25)
        '
        'toolstripActivo
        '
        Me.toolstripActivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripActivo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripActivo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelActivo, Me.comboboxActivo})
        Me.toolstripActivo.Location = New System.Drawing.Point(561, 39)
        Me.toolstripActivo.Name = "toolstripActivo"
        Me.toolstripActivo.Size = New System.Drawing.Size(124, 25)
        Me.toolstripActivo.TabIndex = 12
        '
        'labelActivo
        '
        Me.labelActivo.Name = "labelActivo"
        Me.labelActivo.Size = New System.Drawing.Size(44, 22)
        Me.labelActivo.Text = "Activo:"
        '
        'comboboxActivo
        '
        Me.comboboxActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxActivo.Name = "comboboxActivo"
        Me.comboboxActivo.Size = New System.Drawing.Size(75, 25)
        '
        'columnCuartel
        '
        Me.columnCuartel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnCuartel.DataPropertyName = "CuartelNombre"
        Me.columnCuartel.HeaderText = "Cuartel"
        Me.columnCuartel.Name = "columnCuartel"
        Me.columnCuartel.ReadOnly = True
        Me.columnCuartel.Width = 65
        '
        'columnArea
        '
        Me.columnArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnArea.DataPropertyName = "AreaNombre"
        Me.columnArea.HeaderText = "Area"
        Me.columnArea.Name = "columnArea"
        Me.columnArea.ReadOnly = True
        Me.columnArea.Width = 54
        '
        'columnCodigo
        '
        Me.columnCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnCodigo.DataPropertyName = "Codigo"
        Me.columnCodigo.HeaderText = "Código"
        Me.columnCodigo.Name = "columnCodigo"
        Me.columnCodigo.ReadOnly = True
        Me.columnCodigo.Width = 65
        '
        'columnNombre
        '
        Me.columnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnNombre.DataPropertyName = "Nombre"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnNombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnNombre.HeaderText = "Nombre"
        Me.columnNombre.Name = "columnNombre"
        Me.columnNombre.ReadOnly = True
        Me.columnNombre.Width = 69
        '
        'columnDescripcionPropia
        '
        Me.columnDescripcionPropia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnDescripcionPropia.DataPropertyName = "DescripcionPropia"
        Me.columnDescripcionPropia.HeaderText = "Descripción"
        Me.columnDescripcionPropia.Name = "columnDescripcionPropia"
        Me.columnDescripcionPropia.ReadOnly = True
        Me.columnDescripcionPropia.Width = 88
        '
        'columnUbicacion
        '
        Me.columnUbicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnUbicacion.DataPropertyName = "UbicacionNombre"
        Me.columnUbicacion.HeaderText = "Ubicación"
        Me.columnUbicacion.Name = "columnUbicacion"
        Me.columnUbicacion.ReadOnly = True
        Me.columnUbicacion.Width = 80
        '
        'columnSubUbicacion
        '
        Me.columnSubUbicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnSubUbicacion.DataPropertyName = "SubUbicacionNombre"
        Me.columnSubUbicacion.HeaderText = "Sub-Ubicación"
        Me.columnSubUbicacion.Name = "columnSubUbicacion"
        Me.columnSubUbicacion.ReadOnly = True
        Me.columnSubUbicacion.Width = 102
        '
        'columnEsActivo
        '
        Me.columnEsActivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnEsActivo.DataPropertyName = "EsActivo"
        Me.columnEsActivo.HeaderText = "Activo"
        Me.columnEsActivo.Name = "columnEsActivo"
        Me.columnEsActivo.ReadOnly = True
        Me.columnEsActivo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.columnEsActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.columnEsActivo.Width = 62
        '
        'formInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 411)
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.panelToolbars)
        Me.Controls.Add(Me.statusstripMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Inventario"
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelToolbars.ResumeLayout(False)
        Me.panelToolbars.PerformLayout()
        Me.toolstripButtons.ResumeLayout(False)
        Me.toolstripButtons.PerformLayout()
        Me.toolstripBuscar.ResumeLayout(False)
        Me.toolstripBuscar.PerformLayout()
        Me.toolstripCuartel.ResumeLayout(False)
        Me.toolstripCuartel.PerformLayout()
        Me.toolstripArea.ResumeLayout(False)
        Me.toolstripArea.PerformLayout()
        Me.toolstripUbicacion.ResumeLayout(False)
        Me.toolstripUbicacion.PerformLayout()
        Me.toolstripSubUbicacion.ResumeLayout(False)
        Me.toolstripSubUbicacion.PerformLayout()
        Me.toolstripActivo.ResumeLayout(False)
        Me.toolstripActivo.PerformLayout()
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
    Friend WithEvents toolstripActivo As System.Windows.Forms.ToolStrip
    Friend WithEvents labelActivo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxActivo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripCuartel As System.Windows.Forms.ToolStrip
    Friend WithEvents labelCuartel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxCuartel As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripArea As System.Windows.Forms.ToolStrip
    Friend WithEvents labelArea As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxArea As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripUbicacion As System.Windows.Forms.ToolStrip
    Friend WithEvents labelUbicacion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxUbicacion As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripSubUbicacion As System.Windows.Forms.ToolStrip
    Friend WithEvents labelSubUbicacion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxSubUbicacion As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripBuscar As System.Windows.Forms.ToolStrip
    Friend WithEvents labelBuscar As System.Windows.Forms.ToolStripLabel
    Friend WithEvents textboxBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents buttonBuscarBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents columnCuartel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnArea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnDescripcionPropia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnUbicacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnSubUbicacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnEsActivo As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
