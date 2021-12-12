<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSiniestroAsistenciaTipoPuntaje
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
        Me.components = New System.ComponentModel.Container()
        Dim labelFechaInicio As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.tooltipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.datetimepickerFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.datagridviewPuntajes = New System.Windows.Forms.DataGridView()
        Me.columnIDSiniestroClave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnSiniestroClaveNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnPuntaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        labelFechaInicio = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        CType(Me.datagridviewPuntajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelFechaInicio
        '
        labelFechaInicio.AutoSize = True
        labelFechaInicio.Location = New System.Drawing.Point(12, 54)
        labelFechaInicio.Name = "labelFechaInicio"
        labelFechaInicio.Size = New System.Drawing.Size(82, 13)
        labelFechaInicio.TabIndex = 0
        labelFechaInicio.Text = "Fecha de inicio:"
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_OK_32
        Me.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(85, 36)
        Me.buttonGuardar.Text = "Guardar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_CANCEL_32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_CLOSE_32
        Me.buttonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCerrar.Name = "buttonCerrar"
        Me.buttonCerrar.Size = New System.Drawing.Size(75, 36)
        Me.buttonCerrar.Text = "Cerrar"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(299, 39)
        Me.toolstripMain.TabIndex = 10
        '
        'datetimepickerFechaInicio
        '
        Me.datetimepickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaInicio.Location = New System.Drawing.Point(100, 52)
        Me.datetimepickerFechaInicio.Name = "datetimepickerFechaInicio"
        Me.datetimepickerFechaInicio.Size = New System.Drawing.Size(94, 20)
        Me.datetimepickerFechaInicio.TabIndex = 1
        '
        'datagridviewPuntajes
        '
        Me.datagridviewPuntajes.AllowUserToAddRows = False
        Me.datagridviewPuntajes.AllowUserToDeleteRows = False
        Me.datagridviewPuntajes.AllowUserToResizeColumns = False
        Me.datagridviewPuntajes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewPuntajes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewPuntajes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridviewPuntajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewPuntajes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnIDSiniestroClave, Me.columnSiniestroClaveNombre, Me.columnPuntaje})
        Me.datagridviewPuntajes.Location = New System.Drawing.Point(12, 78)
        Me.datagridviewPuntajes.MultiSelect = False
        Me.datagridviewPuntajes.Name = "datagridviewPuntajes"
        Me.datagridviewPuntajes.RowHeadersVisible = False
        Me.datagridviewPuntajes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewPuntajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datagridviewPuntajes.Size = New System.Drawing.Size(275, 309)
        Me.datagridviewPuntajes.TabIndex = 2
        '
        'columnIDSiniestroClave
        '
        Me.columnIDSiniestroClave.DataPropertyName = "IDSiniestroClave"
        Me.columnIDSiniestroClave.HeaderText = "IDClave"
        Me.columnIDSiniestroClave.Name = "columnIDSiniestroClave"
        Me.columnIDSiniestroClave.Visible = False
        '
        'columnSiniestroClaveNombre
        '
        Me.columnSiniestroClaveNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnSiniestroClaveNombre.DataPropertyName = "SiniestroClaveNombre"
        Me.columnSiniestroClaveNombre.HeaderText = "Clave"
        Me.columnSiniestroClaveNombre.Name = "columnSiniestroClaveNombre"
        Me.columnSiniestroClaveNombre.ReadOnly = True
        Me.columnSiniestroClaveNombre.Width = 59
        '
        'columnPuntaje
        '
        Me.columnPuntaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.columnPuntaje.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnPuntaje.HeaderText = "Puntaje"
        Me.columnPuntaje.Name = "columnPuntaje"
        Me.columnPuntaje.Width = 68
        '
        'formSiniestroAsistenciaTipoPuntaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 399)
        Me.Controls.Add(Me.datagridviewPuntajes)
        Me.Controls.Add(Me.datetimepickerFechaInicio)
        Me.Controls.Add(labelFechaInicio)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formSiniestroAsistenciaTipoPuntaje"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Puntaje de Tipo de Asistencia a Siniestro"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        CType(Me.datagridviewPuntajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tooltipMain As ToolTip
    Friend WithEvents datetimepickerFechaInicio As DateTimePicker
    Friend WithEvents datagridviewPuntajes As DataGridView
    Friend WithEvents columnIDSiniestroClave As DataGridViewTextBoxColumn
    Friend WithEvents columnSiniestroClaveNombre As DataGridViewTextBoxColumn
    Friend WithEvents columnPuntaje As DataGridViewTextBoxColumn
End Class
