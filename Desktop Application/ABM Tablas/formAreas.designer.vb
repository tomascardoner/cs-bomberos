<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAreas
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
        Me.toolstripCuartel = New System.Windows.Forms.ToolStrip()
        Me.labelCuartel = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxCuartel = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripActivo = New System.Windows.Forms.ToolStrip()
        Me.labelActivo = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxActivo = New System.Windows.Forms.ToolStripComboBox()
        Me.columnCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCuartel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMostrarEnInventario = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.columnMostrarEnCompras = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.columnEsActivo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.statusstripMain.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelToolbars.SuspendLayout()
        Me.toolstripButtons.SuspendLayout()
        Me.toolstripCuartel.SuspendLayout()
        Me.toolstripActivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'statuslabelMain
        '
        Me.statuslabelMain.Name = "statuslabelMain"
        Me.statuslabelMain.Size = New System.Drawing.Size(1017, 17)
        Me.statuslabelMain.Spring = True
        Me.statuslabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabelMain})
        Me.statusstripMain.Location = New System.Drawing.Point(0, 389)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(1032, 22)
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
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnCodigo, Me.columnNombre, Me.columnCuartel, Me.columnMostrarEnInventario, Me.columnMostrarEnCompras, Me.columnEsActivo})
        Me.datagridviewMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewMain.Location = New System.Drawing.Point(0, 39)
        Me.datagridviewMain.MultiSelect = False
        Me.datagridviewMain.Name = "datagridviewMain"
        Me.datagridviewMain.ReadOnly = True
        Me.datagridviewMain.RowHeadersVisible = False
        Me.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewMain.Size = New System.Drawing.Size(1032, 350)
        Me.datagridviewMain.TabIndex = 0
        '
        'panelToolbars
        '
        Me.panelToolbars.AutoSize = True
        Me.panelToolbars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelToolbars.Controls.Add(Me.toolstripButtons)
        Me.panelToolbars.Controls.Add(Me.toolstripCuartel)
        Me.panelToolbars.Controls.Add(Me.toolstripActivo)
        Me.panelToolbars.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelToolbars.Location = New System.Drawing.Point(0, 0)
        Me.panelToolbars.Name = "panelToolbars"
        Me.panelToolbars.Size = New System.Drawing.Size(1032, 39)
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
        'toolstripCuartel
        '
        Me.toolstripCuartel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripCuartel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripCuartel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelCuartel, Me.comboboxCuartel})
        Me.toolstripCuartel.Location = New System.Drawing.Point(247, 0)
        Me.toolstripCuartel.Name = "toolstripCuartel"
        Me.toolstripCuartel.Size = New System.Drawing.Size(183, 39)
        Me.toolstripCuartel.TabIndex = 15
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
        'toolstripActivo
        '
        Me.toolstripActivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripActivo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripActivo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelActivo, Me.comboboxActivo})
        Me.toolstripActivo.Location = New System.Drawing.Point(430, 0)
        Me.toolstripActivo.Name = "toolstripActivo"
        Me.toolstripActivo.Size = New System.Drawing.Size(124, 39)
        Me.toolstripActivo.TabIndex = 12
        '
        'labelActivo
        '
        Me.labelActivo.Name = "labelActivo"
        Me.labelActivo.Size = New System.Drawing.Size(44, 36)
        Me.labelActivo.Text = "Activo:"
        '
        'comboboxActivo
        '
        Me.comboboxActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxActivo.Name = "comboboxActivo"
        Me.comboboxActivo.Size = New System.Drawing.Size(75, 39)
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
        'columnCuartel
        '
        Me.columnCuartel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnCuartel.DataPropertyName = "CuartelNombre"
        Me.columnCuartel.HeaderText = "Cuartel"
        Me.columnCuartel.Name = "columnCuartel"
        Me.columnCuartel.ReadOnly = True
        Me.columnCuartel.Width = 65
        '
        'columnMostrarEnInventario
        '
        Me.columnMostrarEnInventario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnMostrarEnInventario.DataPropertyName = "MostrarEnInventario"
        Me.columnMostrarEnInventario.HeaderText = "Inventario"
        Me.columnMostrarEnInventario.Name = "columnMostrarEnInventario"
        Me.columnMostrarEnInventario.ReadOnly = True
        Me.columnMostrarEnInventario.Width = 60
        '
        'columnMostrarEnCompras
        '
        Me.columnMostrarEnCompras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnMostrarEnCompras.DataPropertyName = "MostrarEnCompras"
        Me.columnMostrarEnCompras.HeaderText = "Compras"
        Me.columnMostrarEnCompras.Name = "columnMostrarEnCompras"
        Me.columnMostrarEnCompras.ReadOnly = True
        Me.columnMostrarEnCompras.Width = 54
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
        'formAreas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 411)
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.panelToolbars)
        Me.Controls.Add(Me.statusstripMain)
        Me.KeyPreview = True
        Me.Name = "formAreas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Áreas"
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelToolbars.ResumeLayout(False)
        Me.panelToolbars.PerformLayout()
        Me.toolstripButtons.ResumeLayout(False)
        Me.toolstripButtons.PerformLayout()
        Me.toolstripCuartel.ResumeLayout(False)
        Me.toolstripCuartel.PerformLayout()
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
    Friend WithEvents toolstripCuartel As ToolStrip
    Friend WithEvents labelCuartel As ToolStripLabel
    Friend WithEvents comboboxCuartel As ToolStripComboBox
    Friend WithEvents columnCodigo As DataGridViewTextBoxColumn
    Friend WithEvents columnNombre As DataGridViewTextBoxColumn
    Friend WithEvents columnCuartel As DataGridViewTextBoxColumn
    Friend WithEvents columnMostrarEnInventario As DataGridViewCheckBoxColumn
    Friend WithEvents columnMostrarEnCompras As DataGridViewCheckBoxColumn
    Friend WithEvents columnEsActivo As DataGridViewCheckBoxColumn
End Class
