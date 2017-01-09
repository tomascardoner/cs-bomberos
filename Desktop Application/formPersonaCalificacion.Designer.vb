<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaCalificacion
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
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.labelAnio = New System.Windows.Forms.Label()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.datagridviewCalificaciones = New System.Windows.Forms.DataGridView()
        Me.columnConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCalificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maskedtextboxAnio = New System.Windows.Forms.MaskedTextBox()
        Me.maskedtextboxInstanciaNumero = New System.Windows.Forms.MaskedTextBox()
        Me.labelConceptosCalificaciones = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        CType(Me.datagridviewCalificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_OK_32
        Me.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(85, 36)
        Me.buttonGuardar.Text = "Guardar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_CANCEL_32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_CLOSE_32
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
        Me.toolstripMain.Size = New System.Drawing.Size(473, 39)
        Me.toolstripMain.TabIndex = 6
        '
        'labelAnio
        '
        Me.labelAnio.AutoSize = True
        Me.labelAnio.Location = New System.Drawing.Point(12, 53)
        Me.labelAnio.Name = "labelAnio"
        Me.labelAnio.Size = New System.Drawing.Size(29, 13)
        Me.labelAnio.TabIndex = 0
        Me.labelAnio.Text = "Año:"
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(12, 79)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(108, 13)
        Me.labelFecha.TabIndex = 2
        Me.labelFecha.Text = "Número de Instancia:"
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
        Me.datagridviewCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewCalificaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnConcepto, Me.columnCalificacion})
        Me.datagridviewCalificaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.datagridviewCalificaciones.Location = New System.Drawing.Point(12, 127)
        Me.datagridviewCalificaciones.MultiSelect = False
        Me.datagridviewCalificaciones.Name = "datagridviewCalificaciones"
        Me.datagridviewCalificaciones.ReadOnly = True
        Me.datagridviewCalificaciones.RowHeadersVisible = False
        Me.datagridviewCalificaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewCalificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.datagridviewCalificaciones.Size = New System.Drawing.Size(449, 240)
        Me.datagridviewCalificaciones.TabIndex = 5
        '
        'columnConcepto
        '
        Me.columnConcepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnConcepto.DataPropertyName = "ConceptoAbreviaturaNombre"
        Me.columnConcepto.HeaderText = "Concepto"
        Me.columnConcepto.Name = "columnConcepto"
        Me.columnConcepto.ReadOnly = True
        Me.columnConcepto.Width = 78
        '
        'columnCalificacion
        '
        Me.columnCalificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnCalificacion.DataPropertyName = "Calificacion"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.columnCalificacion.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnCalificacion.HeaderText = "Calificación"
        Me.columnCalificacion.Name = "columnCalificacion"
        Me.columnCalificacion.ReadOnly = True
        Me.columnCalificacion.Width = 86
        '
        'maskedtextboxAnio
        '
        Me.maskedtextboxAnio.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxAnio.Location = New System.Drawing.Point(126, 50)
        Me.maskedtextboxAnio.Mask = "9999"
        Me.maskedtextboxAnio.Name = "maskedtextboxAnio"
        Me.maskedtextboxAnio.Size = New System.Drawing.Size(47, 20)
        Me.maskedtextboxAnio.TabIndex = 1
        Me.maskedtextboxAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.maskedtextboxAnio.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'maskedtextboxInstanciaNumero
        '
        Me.maskedtextboxInstanciaNumero.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxInstanciaNumero.Location = New System.Drawing.Point(126, 76)
        Me.maskedtextboxInstanciaNumero.Mask = "99"
        Me.maskedtextboxInstanciaNumero.Name = "maskedtextboxInstanciaNumero"
        Me.maskedtextboxInstanciaNumero.Size = New System.Drawing.Size(26, 20)
        Me.maskedtextboxInstanciaNumero.TabIndex = 3
        Me.maskedtextboxInstanciaNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.maskedtextboxInstanciaNumero.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'labelConceptosCalificaciones
        '
        Me.labelConceptosCalificaciones.AutoSize = True
        Me.labelConceptosCalificaciones.Location = New System.Drawing.Point(12, 111)
        Me.labelConceptosCalificaciones.Name = "labelConceptosCalificaciones"
        Me.labelConceptosCalificaciones.Size = New System.Drawing.Size(75, 13)
        Me.labelConceptosCalificaciones.TabIndex = 4
        Me.labelConceptosCalificaciones.Text = "Calificaciones:"
        '
        'formPersonaCalificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 379)
        Me.Controls.Add(Me.labelConceptosCalificaciones)
        Me.Controls.Add(Me.maskedtextboxInstanciaNumero)
        Me.Controls.Add(Me.maskedtextboxAnio)
        Me.Controls.Add(Me.datagridviewCalificaciones)
        Me.Controls.Add(Me.labelFecha)
        Me.Controls.Add(Me.labelAnio)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPersonaCalificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Instancia de Calificación de la Persona"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        CType(Me.datagridviewCalificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents labelAnio As System.Windows.Forms.Label
    Friend WithEvents labelFecha As System.Windows.Forms.Label
    Friend WithEvents datagridviewCalificaciones As System.Windows.Forms.DataGridView
    Friend WithEvents maskedtextboxAnio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents maskedtextboxInstanciaNumero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents labelConceptosCalificaciones As System.Windows.Forms.Label
    Friend WithEvents columnConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnCalificacion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
