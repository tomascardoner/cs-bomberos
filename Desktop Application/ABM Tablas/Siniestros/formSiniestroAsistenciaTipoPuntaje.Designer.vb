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
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.labelPuntajeClaveNaranja = New System.Windows.Forms.Label()
        Me.labelPuntajeClaveVerde = New System.Windows.Forms.Label()
        Me.labelPuntajeClaveAzul = New System.Windows.Forms.Label()
        Me.labelPuntajeClaveRoja = New System.Windows.Forms.Label()
        Me.tooltipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.datetimepickerFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.doubletextboxPuntajeClaveVerde = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.doubletextboxPuntajeClaveAzul = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.doubletextboxPuntajeClaveNaranja = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.doubletextboxPuntajeClaveRoja = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        labelFechaInicio = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        CType(Me.doubletextboxPuntajeClaveVerde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxPuntajeClaveAzul, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxPuntajeClaveNaranja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxPuntajeClaveRoja, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.toolstripMain.Size = New System.Drawing.Size(276, 39)
        Me.toolstripMain.TabIndex = 10
        '
        'labelPuntajeClaveNaranja
        '
        Me.labelPuntajeClaveNaranja.AutoSize = True
        Me.labelPuntajeClaveNaranja.Location = New System.Drawing.Point(12, 131)
        Me.labelPuntajeClaveNaranja.Name = "labelPuntajeClaveNaranja"
        Me.labelPuntajeClaveNaranja.Size = New System.Drawing.Size(113, 13)
        Me.labelPuntajeClaveNaranja.TabIndex = 6
        Me.labelPuntajeClaveNaranja.Text = "Puntaje clave naranja:"
        '
        'labelPuntajeClaveVerde
        '
        Me.labelPuntajeClaveVerde.AutoSize = True
        Me.labelPuntajeClaveVerde.Location = New System.Drawing.Point(12, 79)
        Me.labelPuntajeClaveVerde.Name = "labelPuntajeClaveVerde"
        Me.labelPuntajeClaveVerde.Size = New System.Drawing.Size(105, 13)
        Me.labelPuntajeClaveVerde.TabIndex = 2
        Me.labelPuntajeClaveVerde.Text = "Puntaje clave verde:"
        '
        'labelPuntajeClaveAzul
        '
        Me.labelPuntajeClaveAzul.AutoSize = True
        Me.labelPuntajeClaveAzul.Location = New System.Drawing.Point(12, 105)
        Me.labelPuntajeClaveAzul.Name = "labelPuntajeClaveAzul"
        Me.labelPuntajeClaveAzul.Size = New System.Drawing.Size(97, 13)
        Me.labelPuntajeClaveAzul.TabIndex = 4
        Me.labelPuntajeClaveAzul.Text = "Puntaje clave azul:"
        '
        'labelPuntajeClaveRoja
        '
        Me.labelPuntajeClaveRoja.AutoSize = True
        Me.labelPuntajeClaveRoja.Location = New System.Drawing.Point(12, 157)
        Me.labelPuntajeClaveRoja.Name = "labelPuntajeClaveRoja"
        Me.labelPuntajeClaveRoja.Size = New System.Drawing.Size(95, 13)
        Me.labelPuntajeClaveRoja.TabIndex = 8
        Me.labelPuntajeClaveRoja.Text = "Puntaje clave roja:"
        '
        'datetimepickerFechaInicio
        '
        Me.datetimepickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaInicio.Location = New System.Drawing.Point(139, 52)
        Me.datetimepickerFechaInicio.Name = "datetimepickerFechaInicio"
        Me.datetimepickerFechaInicio.Size = New System.Drawing.Size(94, 20)
        Me.datetimepickerFechaInicio.TabIndex = 1
        '
        'doubletextboxPuntajeClaveVerde
        '
        Me.doubletextboxPuntajeClaveVerde.BeforeTouchSize = New System.Drawing.Size(36, 20)
        Me.doubletextboxPuntajeClaveVerde.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxPuntajeClaveVerde.DoubleValue = 0R
        Me.doubletextboxPuntajeClaveVerde.Location = New System.Drawing.Point(139, 78)
        Me.doubletextboxPuntajeClaveVerde.MaxValue = 99.99R
        Me.doubletextboxPuntajeClaveVerde.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxPuntajeClaveVerde.MinValue = 0R
        Me.doubletextboxPuntajeClaveVerde.Name = "doubletextboxPuntajeClaveVerde"
        Me.doubletextboxPuntajeClaveVerde.NullString = ""
        Me.doubletextboxPuntajeClaveVerde.Size = New System.Drawing.Size(36, 20)
        Me.doubletextboxPuntajeClaveVerde.TabIndex = 3
        Me.doubletextboxPuntajeClaveVerde.Text = "0,00"
        Me.doubletextboxPuntajeClaveVerde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'doubletextboxPuntajeClaveAzul
        '
        Me.doubletextboxPuntajeClaveAzul.BeforeTouchSize = New System.Drawing.Size(36, 20)
        Me.doubletextboxPuntajeClaveAzul.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxPuntajeClaveAzul.DoubleValue = 0R
        Me.doubletextboxPuntajeClaveAzul.Location = New System.Drawing.Point(139, 104)
        Me.doubletextboxPuntajeClaveAzul.MaxValue = 99.99R
        Me.doubletextboxPuntajeClaveAzul.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxPuntajeClaveAzul.MinValue = 0R
        Me.doubletextboxPuntajeClaveAzul.Name = "doubletextboxPuntajeClaveAzul"
        Me.doubletextboxPuntajeClaveAzul.NullString = ""
        Me.doubletextboxPuntajeClaveAzul.Size = New System.Drawing.Size(36, 20)
        Me.doubletextboxPuntajeClaveAzul.TabIndex = 5
        Me.doubletextboxPuntajeClaveAzul.Text = "0,00"
        Me.doubletextboxPuntajeClaveAzul.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'doubletextboxPuntajeClaveNaranja
        '
        Me.doubletextboxPuntajeClaveNaranja.BeforeTouchSize = New System.Drawing.Size(36, 20)
        Me.doubletextboxPuntajeClaveNaranja.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxPuntajeClaveNaranja.DoubleValue = 0R
        Me.doubletextboxPuntajeClaveNaranja.Location = New System.Drawing.Point(139, 130)
        Me.doubletextboxPuntajeClaveNaranja.MaxValue = 99.99R
        Me.doubletextboxPuntajeClaveNaranja.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxPuntajeClaveNaranja.MinValue = 0R
        Me.doubletextboxPuntajeClaveNaranja.Name = "doubletextboxPuntajeClaveNaranja"
        Me.doubletextboxPuntajeClaveNaranja.NullString = ""
        Me.doubletextboxPuntajeClaveNaranja.Size = New System.Drawing.Size(36, 20)
        Me.doubletextboxPuntajeClaveNaranja.TabIndex = 7
        Me.doubletextboxPuntajeClaveNaranja.Text = "0,00"
        Me.doubletextboxPuntajeClaveNaranja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'doubletextboxPuntajeClaveRoja
        '
        Me.doubletextboxPuntajeClaveRoja.BeforeTouchSize = New System.Drawing.Size(36, 20)
        Me.doubletextboxPuntajeClaveRoja.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxPuntajeClaveRoja.DoubleValue = 0R
        Me.doubletextboxPuntajeClaveRoja.Location = New System.Drawing.Point(139, 156)
        Me.doubletextboxPuntajeClaveRoja.MaxValue = 99.99R
        Me.doubletextboxPuntajeClaveRoja.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxPuntajeClaveRoja.MinValue = 0R
        Me.doubletextboxPuntajeClaveRoja.Name = "doubletextboxPuntajeClaveRoja"
        Me.doubletextboxPuntajeClaveRoja.NullString = ""
        Me.doubletextboxPuntajeClaveRoja.Size = New System.Drawing.Size(36, 20)
        Me.doubletextboxPuntajeClaveRoja.TabIndex = 9
        Me.doubletextboxPuntajeClaveRoja.Text = "0,00"
        Me.doubletextboxPuntajeClaveRoja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'formSiniestroAsistenciaTipoPuntaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 185)
        Me.Controls.Add(Me.doubletextboxPuntajeClaveRoja)
        Me.Controls.Add(Me.doubletextboxPuntajeClaveNaranja)
        Me.Controls.Add(Me.doubletextboxPuntajeClaveAzul)
        Me.Controls.Add(Me.doubletextboxPuntajeClaveVerde)
        Me.Controls.Add(Me.datetimepickerFechaInicio)
        Me.Controls.Add(Me.labelPuntajeClaveRoja)
        Me.Controls.Add(labelFechaInicio)
        Me.Controls.Add(Me.labelPuntajeClaveVerde)
        Me.Controls.Add(Me.labelPuntajeClaveAzul)
        Me.Controls.Add(Me.labelPuntajeClaveNaranja)
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
        CType(Me.doubletextboxPuntajeClaveVerde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxPuntajeClaveAzul, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxPuntajeClaveNaranja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxPuntajeClaveRoja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents labelPuntajeClaveNaranja As Label
    Friend WithEvents labelPuntajeClaveVerde As Label
    Friend WithEvents labelPuntajeClaveAzul As Label
    Friend WithEvents labelPuntajeClaveRoja As Label
    Friend WithEvents tooltipMain As ToolTip
    Friend WithEvents datetimepickerFechaInicio As DateTimePicker
    Friend WithEvents doubletextboxPuntajeClaveVerde As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents doubletextboxPuntajeClaveAzul As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents doubletextboxPuntajeClaveNaranja As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents doubletextboxPuntajeClaveRoja As Syncfusion.Windows.Forms.Tools.DoubleTextBox
End Class
