<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaCalificaciones
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
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.panelToolbars = New System.Windows.Forms.FlowLayoutPanel()
        Me.toolstripApellidoNombre = New System.Windows.Forms.ToolStrip()
        Me.labelApellidoNombre = New System.Windows.Forms.ToolStripLabel()
        Me.textboxApellidoNombre = New System.Windows.Forms.ToolStripTextBox()
        Me.toolstripButtons = New System.Windows.Forms.ToolStrip()
        Me.buttonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.buttonImprimir = New System.Windows.Forms.ToolStripSplitButton()
        Me.toolstripAnio = New System.Windows.Forms.ToolStrip()
        Me.labelAnio = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxAnio = New System.Windows.Forms.ToolStripComboBox()
        Me.datagridviewCalificaciones = New System.Windows.Forms.DataGridView()
        Me.columnAnioInstancia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnConceptosCalificaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusstripMain.SuspendLayout()
        Me.panelToolbars.SuspendLayout()
        Me.toolstripApellidoNombre.SuspendLayout()
        Me.toolstripButtons.SuspendLayout()
        Me.toolstripAnio.SuspendLayout()
        CType(Me.datagridviewCalificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabelMain})
        Me.statusstripMain.Location = New System.Drawing.Point(0, 504)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(980, 22)
        Me.statusstripMain.TabIndex = 3
        '
        'statuslabelMain
        '
        Me.statuslabelMain.Name = "statuslabelMain"
        Me.statuslabelMain.Size = New System.Drawing.Size(965, 17)
        Me.statuslabelMain.Spring = True
        Me.statuslabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelToolbars
        '
        Me.panelToolbars.AutoSize = True
        Me.panelToolbars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelToolbars.Controls.Add(Me.toolstripApellidoNombre)
        Me.panelToolbars.Controls.Add(Me.toolstripButtons)
        Me.panelToolbars.Controls.Add(Me.toolstripAnio)
        Me.panelToolbars.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelToolbars.Location = New System.Drawing.Point(0, 0)
        Me.panelToolbars.Name = "panelToolbars"
        Me.panelToolbars.Size = New System.Drawing.Size(980, 39)
        Me.panelToolbars.TabIndex = 4
        '
        'toolstripApellidoNombre
        '
        Me.toolstripApellidoNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripApellidoNombre.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripApellidoNombre.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelApellidoNombre, Me.textboxApellidoNombre})
        Me.toolstripApellidoNombre.Location = New System.Drawing.Point(0, 0)
        Me.toolstripApellidoNombre.Name = "toolstripApellidoNombre"
        Me.toolstripApellidoNombre.Size = New System.Drawing.Size(425, 39)
        Me.toolstripApellidoNombre.TabIndex = 5
        '
        'labelApellidoNombre
        '
        Me.labelApellidoNombre.Name = "labelApellidoNombre"
        Me.labelApellidoNombre.Size = New System.Drawing.Size(120, 36)
        Me.labelApellidoNombre.Text = "Apellidos y Nombres:"
        '
        'textboxApellidoNombre
        '
        Me.textboxApellidoNombre.Name = "textboxApellidoNombre"
        Me.textboxApellidoNombre.ReadOnly = True
        Me.textboxApellidoNombre.Size = New System.Drawing.Size(300, 39)
        '
        'toolstripButtons
        '
        Me.toolstripButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripButtons.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAgregar, Me.buttonEditar, Me.buttonEliminar, Me.buttonImprimir})
        Me.toolstripButtons.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.toolstripButtons.Location = New System.Drawing.Point(425, 0)
        Me.toolstripButtons.Name = "toolstripButtons"
        Me.toolstripButtons.Size = New System.Drawing.Size(346, 39)
        Me.toolstripButtons.TabIndex = 0
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
        'buttonImprimir
        '
        Me.buttonImprimir.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_PRINT_32
        Me.buttonImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonImprimir.Name = "buttonImprimir"
        Me.buttonImprimir.Size = New System.Drawing.Size(101, 36)
        Me.buttonImprimir.Text = "Imprimir"
        '
        'toolstripAnio
        '
        Me.toolstripAnio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripAnio.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripAnio.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelAnio, Me.comboboxAnio})
        Me.toolstripAnio.Location = New System.Drawing.Point(771, 0)
        Me.toolstripAnio.Name = "toolstripAnio"
        Me.toolstripAnio.Size = New System.Drawing.Size(127, 39)
        Me.toolstripAnio.TabIndex = 6
        '
        'labelAnio
        '
        Me.labelAnio.Name = "labelAnio"
        Me.labelAnio.Size = New System.Drawing.Size(32, 36)
        Me.labelAnio.Text = "Año:"
        '
        'comboboxAnio
        '
        Me.comboboxAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxAnio.Name = "comboboxAnio"
        Me.comboboxAnio.Size = New System.Drawing.Size(90, 39)
        '
        'datagridviewCalificaciones
        '
        Me.datagridviewCalificaciones.AllowUserToAddRows = False
        Me.datagridviewCalificaciones.AllowUserToDeleteRows = False
        Me.datagridviewCalificaciones.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewCalificaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewCalificaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.datagridviewCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewCalificaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnAnioInstancia, Me.columnConceptosCalificaciones})
        Me.datagridviewCalificaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewCalificaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewCalificaciones.Location = New System.Drawing.Point(0, 39)
        Me.datagridviewCalificaciones.MultiSelect = False
        Me.datagridviewCalificaciones.Name = "datagridviewCalificaciones"
        Me.datagridviewCalificaciones.ReadOnly = True
        Me.datagridviewCalificaciones.RowHeadersVisible = False
        Me.datagridviewCalificaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewCalificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewCalificaciones.Size = New System.Drawing.Size(980, 465)
        Me.datagridviewCalificaciones.TabIndex = 5
        '
        'columnAnioInstancia
        '
        Me.columnAnioInstancia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnAnioInstancia.DataPropertyName = "AnioInstancia"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.columnAnioInstancia.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnAnioInstancia.HeaderText = "Año - Instancia"
        Me.columnAnioInstancia.Name = "columnAnioInstancia"
        Me.columnAnioInstancia.ReadOnly = True
        Me.columnAnioInstancia.Width = 95
        '
        'columnConceptosCalificaciones
        '
        Me.columnConceptosCalificaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnConceptosCalificaciones.DataPropertyName = "ConceptosCalificaciones"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.columnConceptosCalificaciones.DefaultCellStyle = DataGridViewCellStyle3
        Me.columnConceptosCalificaciones.HeaderText = "Conceptos y Calificaciones"
        Me.columnConceptosCalificaciones.Name = "columnConceptosCalificaciones"
        Me.columnConceptosCalificaciones.ReadOnly = True
        Me.columnConceptosCalificaciones.Width = 145
        '
        'formPersonaCalificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 526)
        Me.Controls.Add(Me.datagridviewCalificaciones)
        Me.Controls.Add(Me.panelToolbars)
        Me.Controls.Add(Me.statusstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "formPersonaCalificaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Calificaciones de la Persona"
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        Me.panelToolbars.ResumeLayout(False)
        Me.panelToolbars.PerformLayout()
        Me.toolstripApellidoNombre.ResumeLayout(False)
        Me.toolstripApellidoNombre.PerformLayout()
        Me.toolstripButtons.ResumeLayout(False)
        Me.toolstripButtons.PerformLayout()
        Me.toolstripAnio.ResumeLayout(False)
        Me.toolstripAnio.PerformLayout()
        CType(Me.datagridviewCalificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusstripMain As System.Windows.Forms.StatusStrip
    Friend WithEvents statuslabelMain As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents panelToolbars As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents toolstripButtons As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonImprimir As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents toolstripApellidoNombre As System.Windows.Forms.ToolStrip
    Friend WithEvents labelApellidoNombre As System.Windows.Forms.ToolStripLabel
    Friend WithEvents textboxApellidoNombre As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents toolstripAnio As System.Windows.Forms.ToolStrip
    Friend WithEvents labelAnio As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxAnio As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents datagridviewCalificaciones As System.Windows.Forms.DataGridView
    Friend WithEvents columnAnioInstancia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnConceptosCalificaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
