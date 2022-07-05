<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSiniestroAsistenciaManual
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
        Dim labelCuartel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.labelNumero = New System.Windows.Forms.Label()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.textboxNumeroCompleto = New System.Windows.Forms.TextBox()
        Me.textboxCuartel = New System.Windows.Forms.TextBox()
        Me.textboxFecha = New System.Windows.Forms.TextBox()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.columnIDPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnPersonaApellidoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        labelCuartel = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelCuartel
        '
        labelCuartel.AutoSize = True
        labelCuartel.Location = New System.Drawing.Point(12, 54)
        labelCuartel.Name = "labelCuartel"
        labelCuartel.Size = New System.Drawing.Size(43, 13)
        labelCuartel.TabIndex = 2
        labelCuartel.Text = "Cuartel:"
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = Global.CSBomberos.My.Resources.Resources.ImageAceptar32
        Me.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(85, 36)
        Me.buttonGuardar.Text = "Guardar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.CSBomberos.My.Resources.Resources.ImageCancelar32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(634, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'labelNumero
        '
        Me.labelNumero.AutoSize = True
        Me.labelNumero.Location = New System.Drawing.Point(292, 54)
        Me.labelNumero.Name = "labelNumero"
        Me.labelNumero.Size = New System.Drawing.Size(47, 13)
        Me.labelNumero.TabIndex = 4
        Me.labelNumero.Text = "Número:"
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(468, 54)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelFecha.TabIndex = 6
        Me.labelFecha.Text = "Fecha:"
        '
        'textboxNumeroCompleto
        '
        Me.textboxNumeroCompleto.Location = New System.Drawing.Point(345, 51)
        Me.textboxNumeroCompleto.Name = "textboxNumeroCompleto"
        Me.textboxNumeroCompleto.ReadOnly = True
        Me.textboxNumeroCompleto.Size = New System.Drawing.Size(100, 20)
        Me.textboxNumeroCompleto.TabIndex = 5
        Me.textboxNumeroCompleto.TabStop = False
        '
        'textboxCuartel
        '
        Me.textboxCuartel.Location = New System.Drawing.Point(61, 51)
        Me.textboxCuartel.Name = "textboxCuartel"
        Me.textboxCuartel.ReadOnly = True
        Me.textboxCuartel.Size = New System.Drawing.Size(212, 20)
        Me.textboxCuartel.TabIndex = 3
        Me.textboxCuartel.TabStop = False
        '
        'textboxFecha
        '
        Me.textboxFecha.Location = New System.Drawing.Point(514, 51)
        Me.textboxFecha.Name = "textboxFecha"
        Me.textboxFecha.ReadOnly = True
        Me.textboxFecha.Size = New System.Drawing.Size(100, 20)
        Me.textboxFecha.TabIndex = 7
        Me.textboxFecha.TabStop = False
        '
        'datagridviewMain
        '
        Me.datagridviewMain.AllowUserToAddRows = False
        Me.datagridviewMain.AllowUserToDeleteRows = False
        Me.datagridviewMain.AllowUserToResizeColumns = False
        Me.datagridviewMain.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridviewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnIDPersona, Me.columnPersonaApellidoNombre})
        Me.datagridviewMain.Location = New System.Drawing.Point(12, 77)
        Me.datagridviewMain.MultiSelect = False
        Me.datagridviewMain.Name = "datagridviewMain"
        Me.datagridviewMain.RowHeadersVisible = False
        Me.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datagridviewMain.Size = New System.Drawing.Size(610, 278)
        Me.datagridviewMain.TabIndex = 0
        '
        'columnIDPersona
        '
        Me.columnIDPersona.Frozen = True
        Me.columnIDPersona.HeaderText = "IDPersona"
        Me.columnIDPersona.Name = "columnIDPersona"
        Me.columnIDPersona.Visible = False
        '
        'columnPersonaApellidoNombre
        '
        Me.columnPersonaApellidoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnPersonaApellidoNombre.Frozen = True
        Me.columnPersonaApellidoNombre.HeaderText = "Persona"
        Me.columnPersonaApellidoNombre.Name = "columnPersonaApellidoNombre"
        Me.columnPersonaApellidoNombre.ReadOnly = True
        Me.columnPersonaApellidoNombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.columnPersonaApellidoNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnPersonaApellidoNombre.Width = 52
        '
        'formSiniestroAsistenciaMultiple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(634, 367)
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.textboxFecha)
        Me.Controls.Add(Me.textboxCuartel)
        Me.Controls.Add(Me.textboxNumeroCompleto)
        Me.Controls.Add(labelCuartel)
        Me.Controls.Add(Me.labelNumero)
        Me.Controls.Add(Me.labelFecha)
        Me.Controls.Add(Me.toolstripMain)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formSiniestroAsistenciaMultiple"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asistencia múltiple a Siniestro"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents labelNumero As Label
    Friend WithEvents labelFecha As Label
    Friend WithEvents textboxNumeroCompleto As TextBox
    Friend WithEvents textboxCuartel As TextBox
    Friend WithEvents textboxFecha As TextBox
    Friend WithEvents datagridviewMain As DataGridView
    Friend WithEvents columnIDPersona As DataGridViewTextBoxColumn
    Friend WithEvents columnPersonaApellidoNombre As DataGridViewTextBoxColumn
End Class
