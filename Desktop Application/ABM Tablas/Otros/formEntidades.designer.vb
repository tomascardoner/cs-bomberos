<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formEntidades
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEntidades))
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.columnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnEsActivo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.panelToolbars = New System.Windows.Forms.FlowLayoutPanel()
        Me.toolstripButtons = New System.Windows.Forms.ToolStrip()
        Me.buttonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripActivo = New System.Windows.Forms.ToolStrip()
        Me.labelActivo = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxActivo = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripCompraVenta = New System.Windows.Forms.ToolStrip()
        Me.buttonCompras = New System.Windows.Forms.ToolStripButton()
        Me.buttonVentas = New System.Windows.Forms.ToolStripButton()
        Me.toolstripCuit = New System.Windows.Forms.ToolStrip()
        Me.labelCuit = New System.Windows.Forms.ToolStripLabel()
        Me.buttonCuitBorrar = New System.Windows.Forms.ToolStripButton()
        Me.statusstripMain.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelToolbars.SuspendLayout()
        Me.toolstripButtons.SuspendLayout()
        Me.toolstripActivo.SuspendLayout()
        Me.toolstripCompraVenta.SuspendLayout()
        Me.toolstripCuit.SuspendLayout()
        Me.SuspendLayout()
        '
        'statuslabelMain
        '
        Me.statuslabelMain.Name = "statuslabelMain"
        Me.statuslabelMain.Size = New System.Drawing.Size(787, 17)
        Me.statuslabelMain.Spring = True
        Me.statuslabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabelMain})
        Me.statusstripMain.Location = New System.Drawing.Point(0, 370)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(802, 22)
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
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnNombre, Me.columnCuit, Me.columnEsActivo})
        Me.datagridviewMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewMain.Location = New System.Drawing.Point(0, 39)
        Me.datagridviewMain.MultiSelect = False
        Me.datagridviewMain.Name = "datagridviewMain"
        Me.datagridviewMain.ReadOnly = True
        Me.datagridviewMain.RowHeadersVisible = False
        Me.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewMain.Size = New System.Drawing.Size(802, 331)
        Me.datagridviewMain.TabIndex = 0
        '
        'columnNombre
        '
        Me.columnNombre.DataPropertyName = "Nombre"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnNombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnNombre.HeaderText = "Nombre"
        Me.columnNombre.Name = "columnNombre"
        Me.columnNombre.ReadOnly = True
        Me.columnNombre.Width = 69
        '
        'columnCuit
        '
        Me.columnCuit.DataPropertyName = "Cuit"
        DataGridViewCellStyle3.Format = "00-00000000-0"
        Me.columnCuit.DefaultCellStyle = DataGridViewCellStyle3
        Me.columnCuit.HeaderText = "CUIT"
        Me.columnCuit.Name = "columnCuit"
        Me.columnCuit.ReadOnly = True
        Me.columnCuit.Width = 57
        '
        'columnEsActivo
        '
        Me.columnEsActivo.DataPropertyName = "EsActivo"
        Me.columnEsActivo.HeaderText = "Activo"
        Me.columnEsActivo.Name = "columnEsActivo"
        Me.columnEsActivo.ReadOnly = True
        Me.columnEsActivo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.columnEsActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.columnEsActivo.Width = 62
        '
        'panelToolbars
        '
        Me.panelToolbars.AutoSize = True
        Me.panelToolbars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelToolbars.Controls.Add(Me.toolstripButtons)
        Me.panelToolbars.Controls.Add(Me.toolstripActivo)
        Me.panelToolbars.Controls.Add(Me.toolstripCompraVenta)
        Me.panelToolbars.Controls.Add(Me.toolstripCuit)
        Me.panelToolbars.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelToolbars.Location = New System.Drawing.Point(0, 0)
        Me.panelToolbars.Name = "panelToolbars"
        Me.panelToolbars.Size = New System.Drawing.Size(802, 39)
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
        'toolstripActivo
        '
        Me.toolstripActivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripActivo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripActivo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelActivo, Me.comboboxActivo})
        Me.toolstripActivo.Location = New System.Drawing.Point(247, 0)
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
        'toolstripCompraVenta
        '
        Me.toolstripCompraVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripCompraVenta.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripCompraVenta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCompras, Me.buttonVentas})
        Me.toolstripCompraVenta.Location = New System.Drawing.Point(371, 0)
        Me.toolstripCompraVenta.Name = "toolstripCompraVenta"
        Me.toolstripCompraVenta.Size = New System.Drawing.Size(133, 39)
        Me.toolstripCompraVenta.TabIndex = 13
        '
        'buttonCompras
        '
        Me.buttonCompras.AutoSize = False
        Me.buttonCompras.Checked = True
        Me.buttonCompras.CheckOnClick = True
        Me.buttonCompras.CheckState = System.Windows.Forms.CheckState.Checked
        Me.buttonCompras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.buttonCompras.Image = CType(resources.GetObject("buttonCompras.Image"), System.Drawing.Image)
        Me.buttonCompras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCompras.Name = "buttonCompras"
        Me.buttonCompras.Size = New System.Drawing.Size(65, 36)
        Me.buttonCompras.Text = "Compras"
        '
        'buttonVentas
        '
        Me.buttonVentas.AutoSize = False
        Me.buttonVentas.Checked = True
        Me.buttonVentas.CheckOnClick = True
        Me.buttonVentas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.buttonVentas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.buttonVentas.Image = CType(resources.GetObject("buttonVentas.Image"), System.Drawing.Image)
        Me.buttonVentas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonVentas.Name = "buttonVentas"
        Me.buttonVentas.Size = New System.Drawing.Size(65, 36)
        Me.buttonVentas.Text = "Ventas"
        '
        'toolstripCuit
        '
        Me.toolstripCuit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripCuit.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripCuit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelCuit, Me.buttonCuitBorrar})
        Me.toolstripCuit.Location = New System.Drawing.Point(504, 0)
        Me.toolstripCuit.Name = "toolstripCuit"
        Me.toolstripCuit.Size = New System.Drawing.Size(61, 39)
        Me.toolstripCuit.TabIndex = 14
        '
        'labelCuit
        '
        Me.labelCuit.Name = "labelCuit"
        Me.labelCuit.Size = New System.Drawing.Size(35, 36)
        Me.labelCuit.Text = "CUIT:"
        '
        'buttonCuitBorrar
        '
        Me.buttonCuitBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonCuitBorrar.Image = Global.CSBomberos.My.Resources.Resources.ImageCerrar16
        Me.buttonCuitBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCuitBorrar.Name = "buttonCuitBorrar"
        Me.buttonCuitBorrar.Size = New System.Drawing.Size(23, 36)
        '
        'formEntidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 392)
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.panelToolbars)
        Me.Controls.Add(Me.statusstripMain)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formEntidades"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Entidades"
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelToolbars.ResumeLayout(False)
        Me.panelToolbars.PerformLayout()
        Me.toolstripButtons.ResumeLayout(False)
        Me.toolstripButtons.PerformLayout()
        Me.toolstripActivo.ResumeLayout(False)
        Me.toolstripActivo.PerformLayout()
        Me.toolstripCompraVenta.ResumeLayout(False)
        Me.toolstripCompraVenta.PerformLayout()
        Me.toolstripCuit.ResumeLayout(False)
        Me.toolstripCuit.PerformLayout()
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
    Friend WithEvents toolstripCompraVenta As ToolStrip
    Friend WithEvents buttonCompras As ToolStripButton
    Friend WithEvents buttonVentas As ToolStripButton
    Friend WithEvents toolstripCuit As ToolStrip
    Friend WithEvents labelCuit As ToolStripLabel
    Friend WithEvents buttonCuitBorrar As ToolStripButton
    Friend WithEvents columnNombre As DataGridViewTextBoxColumn
    Friend WithEvents columnCuit As DataGridViewTextBoxColumn
    Friend WithEvents columnEsActivo As DataGridViewCheckBoxColumn
End Class
