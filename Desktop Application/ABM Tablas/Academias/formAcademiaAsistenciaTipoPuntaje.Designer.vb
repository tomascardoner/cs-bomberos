<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAcademiaAsistenciaTipoPuntaje
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
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.labelPuntaje = New System.Windows.Forms.Label()
        Me.tooltipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.datetimepickerFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.doubletextboxPuntaje = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        labelFechaInicio = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        CType(Me.doubletextboxPuntaje, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.toolstripMain.Size = New System.Drawing.Size(308, 39)
        Me.toolstripMain.TabIndex = 12
        '
        'labelPuntaje
        '
        Me.labelPuntaje.AutoSize = True
        Me.labelPuntaje.Location = New System.Drawing.Point(12, 79)
        Me.labelPuntaje.Name = "labelPuntaje"
        Me.labelPuntaje.Size = New System.Drawing.Size(46, 13)
        Me.labelPuntaje.TabIndex = 2
        Me.labelPuntaje.Text = "Puntaje:"
        '
        'datetimepickerFechaInicio
        '
        Me.datetimepickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaInicio.Location = New System.Drawing.Point(100, 51)
        Me.datetimepickerFechaInicio.Name = "datetimepickerFechaInicio"
        Me.datetimepickerFechaInicio.Size = New System.Drawing.Size(94, 20)
        Me.datetimepickerFechaInicio.TabIndex = 1
        '
        'doubletextboxPuntaje
        '
        Me.doubletextboxPuntaje.BeforeTouchSize = New System.Drawing.Size(36, 20)
        Me.doubletextboxPuntaje.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxPuntaje.DoubleValue = 0R
        Me.doubletextboxPuntaje.Location = New System.Drawing.Point(100, 77)
        Me.doubletextboxPuntaje.MaxValue = 99.99R
        Me.doubletextboxPuntaje.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxPuntaje.MinValue = 0R
        Me.doubletextboxPuntaje.Name = "doubletextboxPuntaje"
        Me.doubletextboxPuntaje.NullString = ""
        Me.doubletextboxPuntaje.Size = New System.Drawing.Size(36, 20)
        Me.doubletextboxPuntaje.TabIndex = 3
        Me.doubletextboxPuntaje.Text = "0,00"
        Me.doubletextboxPuntaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'formAcademiaAsistenciaTipoPuntaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 114)
        Me.Controls.Add(Me.doubletextboxPuntaje)
        Me.Controls.Add(Me.datetimepickerFechaInicio)
        Me.Controls.Add(labelFechaInicio)
        Me.Controls.Add(Me.labelPuntaje)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formAcademiaAsistenciaTipoPuntaje"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Puntaje de Tipo de Asistencia a Academia"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        CType(Me.doubletextboxPuntaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents labelPuntaje As Label
    Friend WithEvents tooltipMain As ToolTip
    Friend WithEvents datetimepickerFechaInicio As DateTimePicker
    Friend WithEvents doubletextboxPuntaje As Syncfusion.Windows.Forms.Tools.DoubleTextBox
End Class
