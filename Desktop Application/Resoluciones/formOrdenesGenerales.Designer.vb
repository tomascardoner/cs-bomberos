<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formOrdenesGenerales
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
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.panelToolbars = New System.Windows.Forms.FlowLayoutPanel()
        Me.toolstripButtons = New System.Windows.Forms.ToolStrip()
        Me.buttonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripPeriodo = New System.Windows.Forms.ToolStrip()
        Me.labelPeriodo = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxPeriodoTipo = New System.Windows.Forms.ToolStripComboBox()
        Me.comboboxPeriodoValor = New System.Windows.Forms.ToolStripComboBox()
        Me.labelPeriodoFechaY = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripCategoria = New System.Windows.Forms.ToolStrip()
        Me.LabelCategoria = New System.Windows.Forms.ToolStripLabel()
        Me.ComboBoxCategoria = New System.Windows.Forms.ToolStripComboBox()
        Me.ColumnNumeroCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusstripMain.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelToolbars.SuspendLayout()
        Me.toolstripButtons.SuspendLayout()
        Me.toolstripPeriodo.SuspendLayout()
        Me.ToolStripCategoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'statuslabelMain
        '
        Me.statuslabelMain.Name = "statuslabelMain"
        Me.statuslabelMain.Size = New System.Drawing.Size(876, 17)
        Me.statuslabelMain.Spring = True
        Me.statuslabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabelMain})
        Me.statusstripMain.Location = New System.Drawing.Point(0, 389)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(891, 22)
        Me.statusstripMain.SizingGrip = False
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
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnNumeroCompleto, Me.ColumnFecha, Me.ColumnDescripcion})
        Me.datagridviewMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewMain.Location = New System.Drawing.Point(0, 39)
        Me.datagridviewMain.MultiSelect = False
        Me.datagridviewMain.Name = "datagridviewMain"
        Me.datagridviewMain.ReadOnly = True
        Me.datagridviewMain.RowHeadersVisible = False
        Me.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewMain.Size = New System.Drawing.Size(891, 350)
        Me.datagridviewMain.TabIndex = 0
        '
        'panelToolbars
        '
        Me.panelToolbars.AutoSize = True
        Me.panelToolbars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelToolbars.Controls.Add(Me.toolstripButtons)
        Me.panelToolbars.Controls.Add(Me.toolstripPeriodo)
        Me.panelToolbars.Controls.Add(Me.ToolStripCategoria)
        Me.panelToolbars.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelToolbars.Location = New System.Drawing.Point(0, 0)
        Me.panelToolbars.Name = "panelToolbars"
        Me.panelToolbars.Size = New System.Drawing.Size(891, 39)
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
        'toolstripPeriodo
        '
        Me.toolstripPeriodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripPeriodo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripPeriodo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripPeriodo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelPeriodo, Me.comboboxPeriodoTipo, Me.comboboxPeriodoValor, Me.labelPeriodoFechaY})
        Me.toolstripPeriodo.Location = New System.Drawing.Point(247, 0)
        Me.toolstripPeriodo.Name = "toolstripPeriodo"
        Me.toolstripPeriodo.Size = New System.Drawing.Size(267, 39)
        Me.toolstripPeriodo.TabIndex = 17
        '
        'labelPeriodo
        '
        Me.labelPeriodo.Name = "labelPeriodo"
        Me.labelPeriodo.Size = New System.Drawing.Size(51, 36)
        Me.labelPeriodo.Text = "Período:"
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
        'ToolStripCategoria
        '
        Me.ToolStripCategoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripCategoria.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripCategoria.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelCategoria, Me.ComboBoxCategoria})
        Me.ToolStripCategoria.Location = New System.Drawing.Point(514, 0)
        Me.ToolStripCategoria.Name = "ToolStripCategoria"
        Me.ToolStripCategoria.Size = New System.Drawing.Size(246, 39)
        Me.ToolStripCategoria.TabIndex = 14
        '
        'LabelCategoria
        '
        Me.LabelCategoria.Name = "LabelCategoria"
        Me.LabelCategoria.Size = New System.Drawing.Size(61, 36)
        Me.LabelCategoria.Text = "Categoría:"
        '
        'ComboBoxCategoria
        '
        Me.ComboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCategoria.Name = "ComboBoxCategoria"
        Me.ComboBoxCategoria.Size = New System.Drawing.Size(180, 39)
        '
        'ColumnNumeroCompleto
        '
        Me.ColumnNumeroCompleto.DataPropertyName = "NumeroCompleto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ColumnNumeroCompleto.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColumnNumeroCompleto.HeaderText = "Número"
        Me.ColumnNumeroCompleto.Name = "ColumnNumeroCompleto"
        Me.ColumnNumeroCompleto.ReadOnly = True
        Me.ColumnNumeroCompleto.Width = 69
        '
        'ColumnFecha
        '
        Me.ColumnFecha.DataPropertyName = "Fecha"
        Me.ColumnFecha.HeaderText = "Fecha"
        Me.ColumnFecha.Name = "ColumnFecha"
        Me.ColumnFecha.ReadOnly = True
        Me.ColumnFecha.Width = 62
        '
        'ColumnDescripcion
        '
        Me.ColumnDescripcion.DataPropertyName = "Descripcion"
        Me.ColumnDescripcion.HeaderText = "Descripción"
        Me.ColumnDescripcion.Name = "ColumnDescripcion"
        Me.ColumnDescripcion.ReadOnly = True
        Me.ColumnDescripcion.Width = 88
        '
        'formOrdenesGenerales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 411)
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.panelToolbars)
        Me.Controls.Add(Me.statusstripMain)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formOrdenesGenerales"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Órdenes Generales"
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelToolbars.ResumeLayout(False)
        Me.panelToolbars.PerformLayout()
        Me.toolstripButtons.ResumeLayout(False)
        Me.toolstripButtons.PerformLayout()
        Me.toolstripPeriodo.ResumeLayout(False)
        Me.toolstripPeriodo.PerformLayout()
        Me.ToolStripCategoria.ResumeLayout(False)
        Me.ToolStripCategoria.PerformLayout()
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
    Friend WithEvents ToolStripCategoria As System.Windows.Forms.ToolStrip
    Friend WithEvents LabelCategoria As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ComboBoxCategoria As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripPeriodo As ToolStrip
    Friend WithEvents labelPeriodo As ToolStripLabel
    Friend WithEvents comboboxPeriodoTipo As ToolStripComboBox
    Friend WithEvents comboboxPeriodoValor As ToolStripComboBox
    Friend WithEvents labelPeriodoFechaY As ToolStripLabel
    Friend WithEvents ColumnNumeroCompleto As DataGridViewTextBoxColumn
    Friend WithEvents ColumnFecha As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDescripcion As DataGridViewTextBoxColumn
End Class
