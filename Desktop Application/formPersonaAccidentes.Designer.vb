<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaAccidentes
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.textboxApellidoNombre = New System.Windows.Forms.TextBox()
        Me.panelGrid = New System.Windows.Forms.Panel()
        Me.datagridviewAccidentes = New System.Windows.Forms.DataGridView()
        Me.columnFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDianostico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnActaNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripAccidentes = New System.Windows.Forms.ToolStrip()
        Me.buttonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        labelApellidoNombre = New System.Windows.Forms.Label()
        Me.panelGrid.SuspendLayout()
        CType(Me.datagridviewAccidentes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.textboxApellidoNombre.Location = New System.Drawing.Point(123, 12)
        Me.textboxApellidoNombre.MaxLength = 50
        Me.textboxApellidoNombre.Name = "textboxApellidoNombre"
        Me.textboxApellidoNombre.ReadOnly = True
        Me.textboxApellidoNombre.Size = New System.Drawing.Size(491, 20)
        Me.textboxApellidoNombre.TabIndex = 2
        '
        'panelGrid
        '
        Me.panelGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelGrid.Controls.Add(Me.datagridviewAccidentes)
        Me.panelGrid.Controls.Add(Me.toolstripAccidentes)
        Me.panelGrid.Location = New System.Drawing.Point(12, 52)
        Me.panelGrid.Name = "panelGrid"
        Me.panelGrid.Size = New System.Drawing.Size(602, 254)
        Me.panelGrid.TabIndex = 0
        '
        'datagridviewAccidentes
        '
        Me.datagridviewAccidentes.AllowUserToAddRows = False
        Me.datagridviewAccidentes.AllowUserToDeleteRows = False
        Me.datagridviewAccidentes.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewAccidentes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.datagridviewAccidentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewAccidentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnFecha, Me.columnDianostico, Me.columnActaNumero, Me.columnFechaAlta})
        Me.datagridviewAccidentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewAccidentes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewAccidentes.Location = New System.Drawing.Point(87, 0)
        Me.datagridviewAccidentes.MultiSelect = False
        Me.datagridviewAccidentes.Name = "datagridviewAccidentes"
        Me.datagridviewAccidentes.ReadOnly = True
        Me.datagridviewAccidentes.RowHeadersVisible = False
        Me.datagridviewAccidentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewAccidentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewAccidentes.Size = New System.Drawing.Size(515, 254)
        Me.datagridviewAccidentes.TabIndex = 0
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
        'columnDianostico
        '
        Me.columnDianostico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnDianostico.DataPropertyName = "Diagnostico"
        Me.columnDianostico.HeaderText = "Diagnóstico"
        Me.columnDianostico.Name = "columnDianostico"
        Me.columnDianostico.ReadOnly = True
        Me.columnDianostico.Width = 88
        '
        'columnActaNumero
        '
        Me.columnActaNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnActaNumero.DataPropertyName = "ActaNumero"
        Me.columnActaNumero.HeaderText = "Nº de Acta"
        Me.columnActaNumero.Name = "columnActaNumero"
        Me.columnActaNumero.ReadOnly = True
        Me.columnActaNumero.Width = 84
        '
        'columnFechaAlta
        '
        Me.columnFechaAlta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnFechaAlta.DataPropertyName = "FechaAlta"
        Me.columnFechaAlta.HeaderText = "Fecha de Alta"
        Me.columnFechaAlta.Name = "columnFechaAlta"
        Me.columnFechaAlta.ReadOnly = True
        Me.columnFechaAlta.Width = 98
        '
        'toolstripAccidentes
        '
        Me.toolstripAccidentes.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripAccidentes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripAccidentes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAgregar, Me.buttonEditar, Me.buttonEliminar})
        Me.toolstripAccidentes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripAccidentes.Location = New System.Drawing.Point(0, 0)
        Me.toolstripAccidentes.Name = "toolstripAccidentes"
        Me.toolstripAccidentes.Size = New System.Drawing.Size(87, 254)
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
        Me.statusstripMain.Location = New System.Drawing.Point(0, 317)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(626, 22)
        Me.statusstripMain.TabIndex = 3
        '
        'statuslabelMain
        '
        Me.statuslabelMain.Name = "statuslabelMain"
        Me.statuslabelMain.Size = New System.Drawing.Size(611, 17)
        Me.statuslabelMain.Spring = True
        Me.statuslabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'formPersonaAccidentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 339)
        Me.Controls.Add(Me.statusstripMain)
        Me.Controls.Add(Me.panelGrid)
        Me.Controls.Add(labelApellidoNombre)
        Me.Controls.Add(Me.textboxApellidoNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "formPersonaAccidentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Accidentes de la Persona"
        Me.panelGrid.ResumeLayout(False)
        Me.panelGrid.PerformLayout()
        CType(Me.datagridviewAccidentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripAccidentes.ResumeLayout(False)
        Me.toolstripAccidentes.PerformLayout()
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textboxApellidoNombre As System.Windows.Forms.TextBox
    Friend WithEvents panelGrid As System.Windows.Forms.Panel
    Friend WithEvents datagridviewAccidentes As System.Windows.Forms.DataGridView
    Friend WithEvents toolstripAccidentes As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents columnFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnDianostico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnActaNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnFechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents statusstripMain As System.Windows.Forms.StatusStrip
    Friend WithEvents statuslabelMain As System.Windows.Forms.ToolStripStatusLabel
End Class
