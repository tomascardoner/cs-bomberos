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
        Me.updownPuntajeClaveVerde = New System.Windows.Forms.NumericUpDown()
        Me.updownPuntajeClaveAzul = New System.Windows.Forms.NumericUpDown()
        Me.updownPuntajeClaveNaranja = New System.Windows.Forms.NumericUpDown()
        Me.updownPuntajeClaveRoja = New System.Windows.Forms.NumericUpDown()
        Me.updownPorcentajeDescuentoPorSalidaAnticipada = New System.Windows.Forms.NumericUpDown()
        Me.labelPorcentajeDescuentoPorSalidaAnticipada = New System.Windows.Forms.Label()
        labelFechaInicio = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        CType(Me.updownPuntajeClaveVerde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownPuntajeClaveAzul, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownPuntajeClaveNaranja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownPuntajeClaveRoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownPorcentajeDescuentoPorSalidaAnticipada, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.toolstripMain.Size = New System.Drawing.Size(462, 39)
        Me.toolstripMain.TabIndex = 12
        '
        'labelPuntajeClaveNaranja
        '
        Me.labelPuntajeClaveNaranja.AutoSize = True
        Me.labelPuntajeClaveNaranja.Location = New System.Drawing.Point(12, 131)
        Me.labelPuntajeClaveNaranja.Name = "labelPuntajeClaveNaranja"
        Me.labelPuntajeClaveNaranja.Size = New System.Drawing.Size(110, 13)
        Me.labelPuntajeClaveNaranja.TabIndex = 6
        Me.labelPuntajeClaveNaranja.Text = "Puntos clave naranja:"
        '
        'labelPuntajeClaveVerde
        '
        Me.labelPuntajeClaveVerde.AutoSize = True
        Me.labelPuntajeClaveVerde.Location = New System.Drawing.Point(12, 79)
        Me.labelPuntajeClaveVerde.Name = "labelPuntajeClaveVerde"
        Me.labelPuntajeClaveVerde.Size = New System.Drawing.Size(102, 13)
        Me.labelPuntajeClaveVerde.TabIndex = 2
        Me.labelPuntajeClaveVerde.Text = "Puntos clave verde:"
        '
        'labelPuntajeClaveAzul
        '
        Me.labelPuntajeClaveAzul.AutoSize = True
        Me.labelPuntajeClaveAzul.Location = New System.Drawing.Point(12, 105)
        Me.labelPuntajeClaveAzul.Name = "labelPuntajeClaveAzul"
        Me.labelPuntajeClaveAzul.Size = New System.Drawing.Size(94, 13)
        Me.labelPuntajeClaveAzul.TabIndex = 4
        Me.labelPuntajeClaveAzul.Text = "Puntos clave azul:"
        '
        'labelPuntajeClaveRoja
        '
        Me.labelPuntajeClaveRoja.AutoSize = True
        Me.labelPuntajeClaveRoja.Location = New System.Drawing.Point(12, 157)
        Me.labelPuntajeClaveRoja.Name = "labelPuntajeClaveRoja"
        Me.labelPuntajeClaveRoja.Size = New System.Drawing.Size(92, 13)
        Me.labelPuntajeClaveRoja.TabIndex = 8
        Me.labelPuntajeClaveRoja.Text = "Puntos clave roja:"
        '
        'datetimepickerFechaInicio
        '
        Me.datetimepickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaInicio.Location = New System.Drawing.Point(207, 51)
        Me.datetimepickerFechaInicio.Name = "datetimepickerFechaInicio"
        Me.datetimepickerFechaInicio.Size = New System.Drawing.Size(92, 20)
        Me.datetimepickerFechaInicio.TabIndex = 1
        '
        'updownPuntajeClaveVerde
        '
        Me.updownPuntajeClaveVerde.Location = New System.Drawing.Point(207, 77)
        Me.updownPuntajeClaveVerde.Name = "updownPuntajeClaveVerde"
        Me.updownPuntajeClaveVerde.Size = New System.Drawing.Size(46, 20)
        Me.updownPuntajeClaveVerde.TabIndex = 3
        Me.updownPuntajeClaveVerde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'updownPuntajeClaveAzul
        '
        Me.updownPuntajeClaveAzul.Location = New System.Drawing.Point(207, 103)
        Me.updownPuntajeClaveAzul.Name = "updownPuntajeClaveAzul"
        Me.updownPuntajeClaveAzul.Size = New System.Drawing.Size(46, 20)
        Me.updownPuntajeClaveAzul.TabIndex = 5
        Me.updownPuntajeClaveAzul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'updownPuntajeClaveNaranja
        '
        Me.updownPuntajeClaveNaranja.Location = New System.Drawing.Point(207, 129)
        Me.updownPuntajeClaveNaranja.Name = "updownPuntajeClaveNaranja"
        Me.updownPuntajeClaveNaranja.Size = New System.Drawing.Size(46, 20)
        Me.updownPuntajeClaveNaranja.TabIndex = 7
        Me.updownPuntajeClaveNaranja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'updownPuntajeClaveRoja
        '
        Me.updownPuntajeClaveRoja.Location = New System.Drawing.Point(207, 155)
        Me.updownPuntajeClaveRoja.Name = "updownPuntajeClaveRoja"
        Me.updownPuntajeClaveRoja.Size = New System.Drawing.Size(46, 20)
        Me.updownPuntajeClaveRoja.TabIndex = 9
        Me.updownPuntajeClaveRoja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'updownPorcentajeDescuentoPorSalidaAnticipada
        '
        Me.updownPorcentajeDescuentoPorSalidaAnticipada.Location = New System.Drawing.Point(207, 181)
        Me.updownPorcentajeDescuentoPorSalidaAnticipada.Name = "updownPorcentajeDescuentoPorSalidaAnticipada"
        Me.updownPorcentajeDescuentoPorSalidaAnticipada.Size = New System.Drawing.Size(46, 20)
        Me.updownPorcentajeDescuentoPorSalidaAnticipada.TabIndex = 11
        Me.updownPorcentajeDescuentoPorSalidaAnticipada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelPorcentajeDescuentoPorSalidaAnticipada
        '
        Me.labelPorcentajeDescuentoPorSalidaAnticipada.AutoSize = True
        Me.labelPorcentajeDescuentoPorSalidaAnticipada.Location = New System.Drawing.Point(12, 183)
        Me.labelPorcentajeDescuentoPorSalidaAnticipada.Name = "labelPorcentajeDescuentoPorSalidaAnticipada"
        Me.labelPorcentajeDescuentoPorSalidaAnticipada.Size = New System.Drawing.Size(186, 13)
        Me.labelPorcentajeDescuentoPorSalidaAnticipada.TabIndex = 10
        Me.labelPorcentajeDescuentoPorSalidaAnticipada.Text = "% de descuento por salida anticipada:"
        '
        'formSiniestroAsistenciaTipoPuntaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 217)
        Me.Controls.Add(Me.updownPorcentajeDescuentoPorSalidaAnticipada)
        Me.Controls.Add(Me.labelPorcentajeDescuentoPorSalidaAnticipada)
        Me.Controls.Add(Me.updownPuntajeClaveRoja)
        Me.Controls.Add(Me.updownPuntajeClaveNaranja)
        Me.Controls.Add(Me.updownPuntajeClaveAzul)
        Me.Controls.Add(Me.updownPuntajeClaveVerde)
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
        CType(Me.updownPuntajeClaveVerde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownPuntajeClaveAzul, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownPuntajeClaveNaranja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownPuntajeClaveRoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownPorcentajeDescuentoPorSalidaAnticipada, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents updownPuntajeClaveVerde As NumericUpDown
    Friend WithEvents updownPuntajeClaveAzul As NumericUpDown
    Friend WithEvents updownPuntajeClaveNaranja As NumericUpDown
    Friend WithEvents updownPuntajeClaveRoja As NumericUpDown
    Friend WithEvents updownPorcentajeDescuentoPorSalidaAnticipada As NumericUpDown
    Friend WithEvents labelPorcentajeDescuentoPorSalidaAnticipada As Label
End Class
