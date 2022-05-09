<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSanciones
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
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.columnPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFechaSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMotivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelToolbars = New System.Windows.Forms.FlowLayoutPanel()
        Me.toolstripButtons = New System.Windows.Forms.ToolStrip()
        Me.buttonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.buttonImprimir = New System.Windows.Forms.ToolStripSplitButton()
        Me.toolstripPeriodo = New System.Windows.Forms.ToolStrip()
        Me.labelPeriodo = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxPeriodoTipo = New System.Windows.Forms.ToolStripComboBox()
        Me.comboboxPeriodoValor = New System.Windows.Forms.ToolStripComboBox()
        Me.labelPeriodoFechaY = New System.Windows.Forms.ToolStripLabel()
        Me.toolstripCuartel = New System.Windows.Forms.ToolStrip()
        Me.labelCuartel = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxCuartel = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripPersona = New System.Windows.Forms.ToolStrip()
        Me.labelPersona = New System.Windows.Forms.ToolStripLabel()
        Me.textboxPersona = New System.Windows.Forms.ToolStripTextBox()
        Me.buttonPersona = New System.Windows.Forms.ToolStripButton()
        Me.buttonPersonaBorrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripEstado = New System.Windows.Forms.ToolStrip()
        Me.labelEstado = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxEstado = New System.Windows.Forms.ToolStripComboBox()
        Me.statusstripMain.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelToolbars.SuspendLayout()
        Me.toolstripButtons.SuspendLayout()
        Me.toolstripPeriodo.SuspendLayout()
        Me.toolstripCuartel.SuspendLayout()
        Me.toolstripPersona.SuspendLayout()
        Me.toolstripEstado.SuspendLayout()
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
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnPersona, Me.columnFechaSolicitud, Me.columnEstado, Me.columnMotivo})
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
        'columnPersona
        '
        Me.columnPersona.DataPropertyName = "ApellidoNombre"
        Me.columnPersona.HeaderText = "Persona"
        Me.columnPersona.Name = "columnPersona"
        Me.columnPersona.ReadOnly = True
        Me.columnPersona.Width = 71
        '
        'columnFechaSolicitud
        '
        Me.columnFechaSolicitud.DataPropertyName = "SolicitudFecha"
        Me.columnFechaSolicitud.HeaderText = "Fecha solicitud"
        Me.columnFechaSolicitud.Name = "columnFechaSolicitud"
        Me.columnFechaSolicitud.ReadOnly = True
        Me.columnFechaSolicitud.Width = 95
        '
        'columnEstado
        '
        Me.columnEstado.DataPropertyName = "EstadoNombre"
        Me.columnEstado.HeaderText = "Estado"
        Me.columnEstado.Name = "columnEstado"
        Me.columnEstado.ReadOnly = True
        Me.columnEstado.Width = 65
        '
        'columnMotivo
        '
        Me.columnMotivo.DataPropertyName = "Motivo"
        Me.columnMotivo.HeaderText = "Motivo"
        Me.columnMotivo.Name = "columnMotivo"
        Me.columnMotivo.ReadOnly = True
        Me.columnMotivo.Width = 64
        '
        'panelToolbars
        '
        Me.panelToolbars.AutoSize = True
        Me.panelToolbars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelToolbars.Controls.Add(Me.toolstripButtons)
        Me.panelToolbars.Controls.Add(Me.toolstripPeriodo)
        Me.panelToolbars.Controls.Add(Me.toolstripCuartel)
        Me.panelToolbars.Controls.Add(Me.toolstripPersona)
        Me.panelToolbars.Controls.Add(Me.toolstripEstado)
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
        Me.buttonImprimir.Image = Global.CSBomberos.My.Resources.Resources.ImageImprimir32
        Me.buttonImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonImprimir.Name = "buttonImprimir"
        Me.buttonImprimir.Size = New System.Drawing.Size(101, 36)
        Me.buttonImprimir.Text = "Imprimir"
        '
        'toolstripPeriodo
        '
        Me.toolstripPeriodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripPeriodo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripPeriodo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripPeriodo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelPeriodo, Me.comboboxPeriodoTipo, Me.comboboxPeriodoValor, Me.labelPeriodoFechaY})
        Me.toolstripPeriodo.Location = New System.Drawing.Point(348, 0)
        Me.toolstripPeriodo.Name = "toolstripPeriodo"
        Me.toolstripPeriodo.Size = New System.Drawing.Size(267, 39)
        Me.toolstripPeriodo.TabIndex = 15
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
        'toolstripCuartel
        '
        Me.toolstripCuartel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripCuartel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripCuartel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelCuartel, Me.comboboxCuartel})
        Me.toolstripCuartel.Location = New System.Drawing.Point(615, 0)
        Me.toolstripCuartel.Name = "toolstripCuartel"
        Me.toolstripCuartel.Size = New System.Drawing.Size(183, 39)
        Me.toolstripCuartel.TabIndex = 16
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
        'toolstripPersona
        '
        Me.toolstripPersona.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripPersona.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripPersona.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelPersona, Me.textboxPersona, Me.buttonPersona, Me.buttonPersonaBorrar})
        Me.toolstripPersona.Location = New System.Drawing.Point(0, 39)
        Me.toolstripPersona.Name = "toolstripPersona"
        Me.toolstripPersona.Size = New System.Drawing.Size(353, 25)
        Me.toolstripPersona.TabIndex = 13
        '
        'labelPersona
        '
        Me.labelPersona.Name = "labelPersona"
        Me.labelPersona.Size = New System.Drawing.Size(52, 22)
        Me.labelPersona.Text = "Persona:"
        '
        'textboxPersona
        '
        Me.textboxPersona.Name = "textboxPersona"
        Me.textboxPersona.ReadOnly = True
        Me.textboxPersona.Size = New System.Drawing.Size(250, 25)
        '
        'buttonPersona
        '
        Me.buttonPersona.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonPersona.Image = Global.CSBomberos.My.Resources.Resources.ImageBuscar16
        Me.buttonPersona.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonPersona.Name = "buttonPersona"
        Me.buttonPersona.Size = New System.Drawing.Size(23, 22)
        '
        'buttonPersonaBorrar
        '
        Me.buttonPersonaBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonPersonaBorrar.Image = Global.CSBomberos.My.Resources.Resources.ImageCerrar16
        Me.buttonPersonaBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonPersonaBorrar.Name = "buttonPersonaBorrar"
        Me.buttonPersonaBorrar.Size = New System.Drawing.Size(23, 22)
        '
        'toolstripEstado
        '
        Me.toolstripEstado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripEstado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelEstado, Me.comboboxEstado})
        Me.toolstripEstado.Location = New System.Drawing.Point(353, 39)
        Me.toolstripEstado.Name = "toolstripEstado"
        Me.toolstripEstado.Size = New System.Drawing.Size(160, 25)
        Me.toolstripEstado.TabIndex = 18
        '
        'labelEstado
        '
        Me.labelEstado.Name = "labelEstado"
        Me.labelEstado.Size = New System.Drawing.Size(45, 22)
        Me.labelEstado.Text = "Estado:"
        '
        'comboboxEstado
        '
        Me.comboboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxEstado.Name = "comboboxEstado"
        Me.comboboxEstado.Size = New System.Drawing.Size(110, 25)
        '
        'formSanciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 411)
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.panelToolbars)
        Me.Controls.Add(Me.statusstripMain)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formSanciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sanciones"
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelToolbars.ResumeLayout(False)
        Me.panelToolbars.PerformLayout()
        Me.toolstripButtons.ResumeLayout(False)
        Me.toolstripButtons.PerformLayout()
        Me.toolstripPeriodo.ResumeLayout(False)
        Me.toolstripPeriodo.PerformLayout()
        Me.toolstripCuartel.ResumeLayout(False)
        Me.toolstripCuartel.PerformLayout()
        Me.toolstripPersona.ResumeLayout(False)
        Me.toolstripPersona.PerformLayout()
        Me.toolstripEstado.ResumeLayout(False)
        Me.toolstripEstado.PerformLayout()
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
    Friend WithEvents toolstripPersona As System.Windows.Forms.ToolStrip
    Friend WithEvents labelPersona As System.Windows.Forms.ToolStripLabel
    Friend WithEvents toolstripPeriodo As ToolStrip
    Friend WithEvents labelPeriodo As ToolStripLabel
    Friend WithEvents comboboxPeriodoTipo As ToolStripComboBox
    Friend WithEvents comboboxPeriodoValor As ToolStripComboBox
    Friend WithEvents labelPeriodoFechaY As ToolStripLabel
    Friend WithEvents buttonImprimir As ToolStripSplitButton
    Friend WithEvents toolstripCuartel As ToolStrip
    Friend WithEvents labelCuartel As ToolStripLabel
    Friend WithEvents comboboxCuartel As ToolStripComboBox
    Friend WithEvents textboxPersona As ToolStripTextBox
    Friend WithEvents buttonPersona As ToolStripButton
    Friend WithEvents buttonPersonaBorrar As ToolStripButton
    Friend WithEvents toolstripEstado As ToolStrip
    Friend WithEvents labelEstado As ToolStripLabel
    Friend WithEvents comboboxEstado As ToolStripComboBox
    Friend WithEvents columnPersona As DataGridViewTextBoxColumn
    Friend WithEvents columnFechaSolicitud As DataGridViewTextBoxColumn
    Friend WithEvents columnEstado As DataGridViewTextBoxColumn
    Friend WithEvents columnMotivo As DataGridViewTextBoxColumn
End Class
