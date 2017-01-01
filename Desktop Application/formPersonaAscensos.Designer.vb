<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaAscensos
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
        Dim labelApellidoNombre As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.textboxApellidoNombre = New System.Windows.Forms.TextBox()
        Me.panelGrid = New System.Windows.Forms.Panel()
        Me.datagridviewAscensos = New System.Windows.Forms.DataGridView()
        Me.toolstripAccidentes = New System.Windows.Forms.ToolStrip()
        Me.buttonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.columnFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnJerarquia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        labelApellidoNombre = New System.Windows.Forms.Label()
        Me.panelGrid.SuspendLayout()
        CType(Me.datagridviewAscensos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripAccidentes.SuspendLayout()
        Me.statusstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelApellidoNombre
        '
        labelApellidoNombre.AutoSize = True
        labelApellidoNombre.Location = New System.Drawing.Point(12, 15)
        labelApellidoNombre.Name = "labelApellidoNombre"
        labelApellidoNombre.Size = New System.Drawing.Size(105, 13)
        labelApellidoNombre.TabIndex = 1
        labelApellidoNombre.Text = "Apellidos y Nombres:"
        '
        'textboxApellidoNombre
        '
        Me.textboxApellidoNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxApellidoNombre.Location = New System.Drawing.Point(123, 12)
        Me.textboxApellidoNombre.MaxLength = 50
        Me.textboxApellidoNombre.Name = "textboxApellidoNombre"
        Me.textboxApellidoNombre.ReadOnly = True
        Me.textboxApellidoNombre.Size = New System.Drawing.Size(764, 20)
        Me.textboxApellidoNombre.TabIndex = 2
        '
        'panelGrid
        '
        Me.panelGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelGrid.Controls.Add(Me.datagridviewAscensos)
        Me.panelGrid.Controls.Add(Me.toolstripAccidentes)
        Me.panelGrid.Location = New System.Drawing.Point(12, 52)
        Me.panelGrid.Name = "panelGrid"
        Me.panelGrid.Size = New System.Drawing.Size(875, 362)
        Me.panelGrid.TabIndex = 0
        '
        'datagridviewAscensos
        '
        Me.datagridviewAscensos.AllowUserToAddRows = False
        Me.datagridviewAscensos.AllowUserToDeleteRows = False
        Me.datagridviewAscensos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewAscensos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewAscensos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewAscensos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnFecha, Me.columnCargo, Me.columnJerarquia})
        Me.datagridviewAscensos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewAscensos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewAscensos.Location = New System.Drawing.Point(87, 0)
        Me.datagridviewAscensos.MultiSelect = False
        Me.datagridviewAscensos.Name = "datagridviewAscensos"
        Me.datagridviewAscensos.ReadOnly = True
        Me.datagridviewAscensos.RowHeadersVisible = False
        Me.datagridviewAscensos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewAscensos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewAscensos.Size = New System.Drawing.Size(788, 362)
        Me.datagridviewAscensos.TabIndex = 0
        '
        'toolstripAccidentes
        '
        Me.toolstripAccidentes.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripAccidentes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripAccidentes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAgregar, Me.buttonEditar, Me.buttonEliminar})
        Me.toolstripAccidentes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripAccidentes.Location = New System.Drawing.Point(0, 0)
        Me.toolstripAccidentes.Name = "toolstripAccidentes"
        Me.toolstripAccidentes.Size = New System.Drawing.Size(87, 362)
        Me.toolstripAccidentes.TabIndex = 1
        '
        'buttonAgregar
        '
        Me.buttonAgregar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAgregar.Name = "buttonAgregar"
        Me.buttonAgregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAgregar.Text = "Agregar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(84, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonEliminar.Text = "Eliminar"
        '
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabelMain})
        Me.statusstripMain.Location = New System.Drawing.Point(0, 425)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(899, 22)
        Me.statusstripMain.TabIndex = 3
        '
        'statuslabelMain
        '
        Me.statuslabelMain.Name = "statuslabelMain"
        Me.statuslabelMain.Size = New System.Drawing.Size(884, 17)
        Me.statuslabelMain.Spring = True
        Me.statuslabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'columnFecha
        '
        Me.columnFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnFecha.DataPropertyName = "Fecha"
        Me.columnFecha.HeaderText = "Fecha"
        Me.columnFecha.Name = "columnFecha"
        Me.columnFecha.ReadOnly = True
        Me.columnFecha.Width = 62
        '
        'columnCargo
        '
        Me.columnCargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnCargo.DataPropertyName = "CargoNombre"
        Me.columnCargo.HeaderText = "Cargo"
        Me.columnCargo.Name = "columnCargo"
        Me.columnCargo.ReadOnly = True
        Me.columnCargo.Width = 60
        '
        'columnJerarquia
        '
        Me.columnJerarquia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnJerarquia.DataPropertyName = "CargoJerarquiaNombre"
        Me.columnJerarquia.HeaderText = "Jerarquía"
        Me.columnJerarquia.Name = "columnJerarquia"
        Me.columnJerarquia.ReadOnly = True
        Me.columnJerarquia.Width = 77
        '
        'formPersonaAscensos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 447)
        Me.Controls.Add(Me.statusstripMain)
        Me.Controls.Add(Me.panelGrid)
        Me.Controls.Add(labelApellidoNombre)
        Me.Controls.Add(Me.textboxApellidoNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "formPersonaAscensos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ascensos de la Persona"
        Me.panelGrid.ResumeLayout(False)
        Me.panelGrid.PerformLayout()
        CType(Me.datagridviewAscensos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripAccidentes.ResumeLayout(False)
        Me.toolstripAccidentes.PerformLayout()
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textboxApellidoNombre As System.Windows.Forms.TextBox
    Friend WithEvents panelGrid As System.Windows.Forms.Panel
    Friend WithEvents datagridviewAscensos As System.Windows.Forms.DataGridView
    Friend WithEvents toolstripAccidentes As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents statusstripMain As System.Windows.Forms.StatusStrip
    Friend WithEvents statuslabelMain As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents columnFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnJerarquia As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
