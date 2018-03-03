<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaCambioUnidad
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
        Dim labelActaNumero As System.Windows.Forms.Label
        Dim labelLibroNumero As System.Windows.Forms.Label
        Dim labelFolioNumero As System.Windows.Forms.Label
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.textboxIDCambioDestino = New System.Windows.Forms.TextBox()
        Me.labelIDCambioDestino = New System.Windows.Forms.Label()
        Me.datetimepickerFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.labelFechaAlta = New System.Windows.Forms.Label()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.labelFechaBaja = New System.Windows.Forms.Label()
        Me.datetimepickerFechaBaja = New System.Windows.Forms.DateTimePicker()
        Me.textboxActaNumero = New System.Windows.Forms.TextBox()
        Me.textboxUnidadOrigen = New System.Windows.Forms.TextBox()
        Me.labelUnidadOrigen = New System.Windows.Forms.Label()
        Me.textboxUnidadDestino = New System.Windows.Forms.TextBox()
        Me.labelUnidadDestino = New System.Windows.Forms.Label()
        Me.textboxLibroNumero = New System.Windows.Forms.TextBox()
        Me.textboxFolioNumero = New System.Windows.Forms.TextBox()
        labelActaNumero = New System.Windows.Forms.Label()
        labelLibroNumero = New System.Windows.Forms.Label()
        labelFolioNumero = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelActaNumero
        '
        labelActaNumero.AutoSize = True
        labelActaNumero.Location = New System.Drawing.Point(197, 183)
        labelActaNumero.Name = "labelActaNumero"
        labelActaNumero.Size = New System.Drawing.Size(47, 13)
        labelActaNumero.TabIndex = 12
        labelActaNumero.Text = "Acta N°:"
        '
        'labelLibroNumero
        '
        labelLibroNumero.AutoSize = True
        labelLibroNumero.Location = New System.Drawing.Point(12, 183)
        labelLibroNumero.Name = "labelLibroNumero"
        labelLibroNumero.Size = New System.Drawing.Size(48, 13)
        labelLibroNumero.TabIndex = 10
        labelLibroNumero.Text = "Libro N°:"
        '
        'labelFolioNumero
        '
        labelFolioNumero.AutoSize = True
        labelFolioNumero.Location = New System.Drawing.Point(330, 183)
        labelFolioNumero.Name = "labelFolioNumero"
        labelFolioNumero.Size = New System.Drawing.Size(47, 13)
        labelFolioNumero.TabIndex = 14
        labelFolioNumero.Text = "Folio N°:"
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
        Me.toolstripMain.TabIndex = 18
        '
        'textboxIDCambioDestino
        '
        Me.textboxIDCambioDestino.Location = New System.Drawing.Point(117, 50)
        Me.textboxIDCambioDestino.MaxLength = 10
        Me.textboxIDCambioDestino.Name = "textboxIDCambioDestino"
        Me.textboxIDCambioDestino.ReadOnly = True
        Me.textboxIDCambioDestino.Size = New System.Drawing.Size(74, 20)
        Me.textboxIDCambioDestino.TabIndex = 1
        Me.textboxIDCambioDestino.TabStop = False
        Me.textboxIDCambioDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelIDCambioDestino
        '
        Me.labelIDCambioDestino.AutoSize = True
        Me.labelIDCambioDestino.Location = New System.Drawing.Point(12, 53)
        Me.labelIDCambioDestino.Name = "labelIDCambioDestino"
        Me.labelIDCambioDestino.Size = New System.Drawing.Size(21, 13)
        Me.labelIDCambioDestino.TabIndex = 0
        Me.labelIDCambioDestino.Text = "ID:"
        '
        'datetimepickerFechaAlta
        '
        Me.datetimepickerFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaAlta.Location = New System.Drawing.Point(117, 76)
        Me.datetimepickerFechaAlta.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaAlta.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaAlta.Name = "datetimepickerFechaAlta"
        Me.datetimepickerFechaAlta.Size = New System.Drawing.Size(116, 20)
        Me.datetimepickerFechaAlta.TabIndex = 3
        '
        'labelFechaAlta
        '
        Me.labelFechaAlta.AutoSize = True
        Me.labelFechaAlta.Location = New System.Drawing.Point(12, 82)
        Me.labelFechaAlta.Name = "labelFechaAlta"
        Me.labelFechaAlta.Size = New System.Drawing.Size(61, 13)
        Me.labelFechaAlta.TabIndex = 2
        Me.labelFechaAlta.Text = "Fecha Alta:"
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(117, 206)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(340, 47)
        Me.textboxNotas.TabIndex = 17
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(12, 209)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 16
        Me.labelNotas.Text = "Notas:"
        '
        'labelFechaBaja
        '
        Me.labelFechaBaja.AutoSize = True
        Me.labelFechaBaja.Location = New System.Drawing.Point(12, 134)
        Me.labelFechaBaja.Name = "labelFechaBaja"
        Me.labelFechaBaja.Size = New System.Drawing.Size(64, 13)
        Me.labelFechaBaja.TabIndex = 6
        Me.labelFechaBaja.Text = "Fecha Baja:"
        '
        'datetimepickerFechaBaja
        '
        Me.datetimepickerFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaBaja.Location = New System.Drawing.Point(117, 128)
        Me.datetimepickerFechaBaja.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaBaja.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaBaja.Name = "datetimepickerFechaBaja"
        Me.datetimepickerFechaBaja.ShowCheckBox = True
        Me.datetimepickerFechaBaja.Size = New System.Drawing.Size(139, 20)
        Me.datetimepickerFechaBaja.TabIndex = 7
        '
        'textboxActaNumero
        '
        Me.textboxActaNumero.Location = New System.Drawing.Point(250, 180)
        Me.textboxActaNumero.MaxLength = 10
        Me.textboxActaNumero.Name = "textboxActaNumero"
        Me.textboxActaNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxActaNumero.TabIndex = 13
        '
        'textboxUnidadOrigen
        '
        Me.textboxUnidadOrigen.Location = New System.Drawing.Point(117, 102)
        Me.textboxUnidadOrigen.MaxLength = 50
        Me.textboxUnidadOrigen.Name = "textboxUnidadOrigen"
        Me.textboxUnidadOrigen.Size = New System.Drawing.Size(340, 20)
        Me.textboxUnidadOrigen.TabIndex = 5
        '
        'labelUnidadOrigen
        '
        Me.labelUnidadOrigen.AutoSize = True
        Me.labelUnidadOrigen.Location = New System.Drawing.Point(12, 105)
        Me.labelUnidadOrigen.Name = "labelUnidadOrigen"
        Me.labelUnidadOrigen.Size = New System.Drawing.Size(93, 13)
        Me.labelUnidadOrigen.TabIndex = 4
        Me.labelUnidadOrigen.Text = "Unidad de Origen:"
        '
        'textboxUnidadDestino
        '
        Me.textboxUnidadDestino.Location = New System.Drawing.Point(117, 154)
        Me.textboxUnidadDestino.MaxLength = 50
        Me.textboxUnidadDestino.Name = "textboxUnidadDestino"
        Me.textboxUnidadDestino.Size = New System.Drawing.Size(340, 20)
        Me.textboxUnidadDestino.TabIndex = 9
        '
        'labelUnidadDestino
        '
        Me.labelUnidadDestino.AutoSize = True
        Me.labelUnidadDestino.Location = New System.Drawing.Point(12, 157)
        Me.labelUnidadDestino.Name = "labelUnidadDestino"
        Me.labelUnidadDestino.Size = New System.Drawing.Size(98, 13)
        Me.labelUnidadDestino.TabIndex = 8
        Me.labelUnidadDestino.Text = "Unidad de Destino:"
        '
        'textboxLibroNumero
        '
        Me.textboxLibroNumero.Location = New System.Drawing.Point(117, 180)
        Me.textboxLibroNumero.MaxLength = 10
        Me.textboxLibroNumero.Name = "textboxLibroNumero"
        Me.textboxLibroNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxLibroNumero.TabIndex = 11
        '
        'textboxFolioNumero
        '
        Me.textboxFolioNumero.Location = New System.Drawing.Point(383, 180)
        Me.textboxFolioNumero.MaxLength = 10
        Me.textboxFolioNumero.Name = "textboxFolioNumero"
        Me.textboxFolioNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxFolioNumero.TabIndex = 15
        '
        'formPersonaCambioUnidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 268)
        Me.Controls.Add(Me.textboxFolioNumero)
        Me.Controls.Add(labelFolioNumero)
        Me.Controls.Add(labelLibroNumero)
        Me.Controls.Add(Me.textboxLibroNumero)
        Me.Controls.Add(Me.textboxUnidadDestino)
        Me.Controls.Add(Me.labelUnidadDestino)
        Me.Controls.Add(Me.labelFechaBaja)
        Me.Controls.Add(Me.datetimepickerFechaBaja)
        Me.Controls.Add(labelActaNumero)
        Me.Controls.Add(Me.textboxActaNumero)
        Me.Controls.Add(Me.textboxUnidadOrigen)
        Me.Controls.Add(Me.labelUnidadOrigen)
        Me.Controls.Add(Me.textboxNotas)
        Me.Controls.Add(Me.labelNotas)
        Me.Controls.Add(Me.labelFechaAlta)
        Me.Controls.Add(Me.datetimepickerFechaAlta)
        Me.Controls.Add(Me.labelIDCambioDestino)
        Me.Controls.Add(Me.textboxIDCambioDestino)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPersonaCambioUnidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cambio de Destino de la Persona"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents textboxIDCambioDestino As System.Windows.Forms.TextBox
    Friend WithEvents labelIDCambioDestino As System.Windows.Forms.Label
    Friend WithEvents datetimepickerFechaAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelFechaAlta As System.Windows.Forms.Label
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents labelFechaBaja As System.Windows.Forms.Label
    Friend WithEvents datetimepickerFechaBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents textboxActaNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxUnidadOrigen As System.Windows.Forms.TextBox
    Friend WithEvents labelUnidadOrigen As System.Windows.Forms.Label
    Friend WithEvents textboxUnidadDestino As System.Windows.Forms.TextBox
    Friend WithEvents labelUnidadDestino As System.Windows.Forms.Label
    Friend WithEvents textboxLibroNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxFolioNumero As System.Windows.Forms.TextBox
End Class
