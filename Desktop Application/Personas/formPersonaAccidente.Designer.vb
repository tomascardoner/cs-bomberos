<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaAccidente
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
        Dim labelDiagnostico As System.Windows.Forms.Label
        Dim labelFolioNumero As System.Windows.Forms.Label
        Dim labelLibroNumero As System.Windows.Forms.Label
        Dim labelActaNumero As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim labelCapacidad As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.datetimepickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.textboxFolioNumero = New System.Windows.Forms.TextBox()
        Me.textboxLibroNumero = New System.Windows.Forms.TextBox()
        Me.textboxActaNumero = New System.Windows.Forms.TextBox()
        Me.tabcontrolMain = New CSBomberos.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.labelIDAccidente = New System.Windows.Forms.Label()
        Me.textboxIDAccidente = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxDiagnostico = New System.Windows.Forms.TextBox()
        Me.textboxCapacidad = New System.Windows.Forms.TextBox()
        Me.datetimepickerFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.labelFechaAlta = New System.Windows.Forms.Label()
        Me.textboxDisminucionFisica = New System.Windows.Forms.TextBox()
        labelDiagnostico = New System.Windows.Forms.Label()
        labelFolioNumero = New System.Windows.Forms.Label()
        labelLibroNumero = New System.Windows.Forms.Label()
        labelActaNumero = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelCapacidad = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelDiagnostico
        '
        labelDiagnostico.AutoSize = True
        labelDiagnostico.Location = New System.Drawing.Point(6, 42)
        labelDiagnostico.Name = "labelDiagnostico"
        labelDiagnostico.Size = New System.Drawing.Size(66, 13)
        labelDiagnostico.TabIndex = 2
        labelDiagnostico.Text = "Diagnóstico:"
        '
        'labelFolioNumero
        '
        labelFolioNumero.AutoSize = True
        labelFolioNumero.Location = New System.Drawing.Point(188, 107)
        labelFolioNumero.Name = "labelFolioNumero"
        labelFolioNumero.Size = New System.Drawing.Size(47, 13)
        labelFolioNumero.TabIndex = 6
        labelFolioNumero.Text = "Folio N°:"
        '
        'labelLibroNumero
        '
        labelLibroNumero.AutoSize = True
        labelLibroNumero.Location = New System.Drawing.Point(6, 107)
        labelLibroNumero.Name = "labelLibroNumero"
        labelLibroNumero.Size = New System.Drawing.Size(48, 13)
        labelLibroNumero.TabIndex = 4
        labelLibroNumero.Text = "Libro N°:"
        '
        'labelActaNumero
        '
        labelActaNumero.AutoSize = True
        labelActaNumero.Location = New System.Drawing.Point(321, 107)
        labelActaNumero.Name = "labelActaNumero"
        labelActaNumero.Size = New System.Drawing.Size(47, 13)
        labelActaNumero.TabIndex = 8
        labelActaNumero.Text = "Acta N°:"
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 273)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 21
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 247)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 18
        labelCreacion.Text = "Creación:"
        '
        'labelCapacidad
        '
        labelCapacidad.AutoSize = True
        labelCapacidad.Location = New System.Drawing.Point(6, 166)
        labelCapacidad.Name = "labelCapacidad"
        labelCapacidad.Size = New System.Drawing.Size(61, 13)
        labelCapacidad.TabIndex = 12
        labelCapacidad.Text = "Capacidad:"
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
        Me.toolstripMain.Size = New System.Drawing.Size(542, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'datetimepickerFecha
        '
        Me.datetimepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFecha.Location = New System.Drawing.Point(108, 13)
        Me.datetimepickerFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFecha.Name = "datetimepickerFecha"
        Me.datetimepickerFecha.Size = New System.Drawing.Size(116, 20)
        Me.datetimepickerFecha.TabIndex = 1
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(6, 16)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelFecha.TabIndex = 0
        Me.labelFecha.Text = "Fecha:"
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(114, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(386, 206)
        Me.textboxNotas.TabIndex = 15
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(6, 9)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 14
        Me.labelNotas.Text = "Notas:"
        '
        'textboxFolioNumero
        '
        Me.textboxFolioNumero.Location = New System.Drawing.Point(241, 104)
        Me.textboxFolioNumero.MaxLength = 10
        Me.textboxFolioNumero.Name = "textboxFolioNumero"
        Me.textboxFolioNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxFolioNumero.TabIndex = 7
        '
        'textboxLibroNumero
        '
        Me.textboxLibroNumero.Location = New System.Drawing.Point(108, 104)
        Me.textboxLibroNumero.MaxLength = 10
        Me.textboxLibroNumero.Name = "textboxLibroNumero"
        Me.textboxLibroNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxLibroNumero.TabIndex = 5
        '
        'textboxActaNumero
        '
        Me.textboxActaNumero.Location = New System.Drawing.Point(374, 104)
        Me.textboxActaNumero.MaxLength = 10
        Me.textboxActaNumero.Name = "textboxActaNumero"
        Me.textboxActaNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxActaNumero.TabIndex = 9
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(518, 325)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.textboxDisminucionFisica)
        Me.tabpageGeneral.Controls.Add(Label1)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFechaAlta)
        Me.tabpageGeneral.Controls.Add(Me.labelFechaAlta)
        Me.tabpageGeneral.Controls.Add(Me.textboxCapacidad)
        Me.tabpageGeneral.Controls.Add(Me.textboxDiagnostico)
        Me.tabpageGeneral.Controls.Add(labelCapacidad)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFecha)
        Me.tabpageGeneral.Controls.Add(Me.textboxFolioNumero)
        Me.tabpageGeneral.Controls.Add(Me.labelFecha)
        Me.tabpageGeneral.Controls.Add(labelFolioNumero)
        Me.tabpageGeneral.Controls.Add(labelDiagnostico)
        Me.tabpageGeneral.Controls.Add(labelLibroNumero)
        Me.tabpageGeneral.Controls.Add(Me.textboxLibroNumero)
        Me.tabpageGeneral.Controls.Add(labelActaNumero)
        Me.tabpageGeneral.Controls.Add(Me.textboxActaNumero)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(510, 296)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelIDAccidente)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxIDAccidente)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(labelModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(labelCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxNotas)
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelNotas)
        Me.tabpageNotasAuditoria.Location = New System.Drawing.Point(4, 25)
        Me.tabpageNotasAuditoria.Name = "tabpageNotasAuditoria"
        Me.tabpageNotasAuditoria.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(510, 296)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelIDAccidente
        '
        Me.labelIDAccidente.AutoSize = True
        Me.labelIDAccidente.Location = New System.Drawing.Point(6, 221)
        Me.labelIDAccidente.Name = "labelIDAccidente"
        Me.labelIDAccidente.Size = New System.Drawing.Size(87, 13)
        Me.labelIDAccidente.TabIndex = 16
        Me.labelIDAccidente.Text = "ID de Accidente:"
        '
        'textboxIDAccidente
        '
        Me.textboxIDAccidente.Location = New System.Drawing.Point(114, 218)
        Me.textboxIDAccidente.MaxLength = 10
        Me.textboxIDAccidente.Name = "textboxIDAccidente"
        Me.textboxIDAccidente.ReadOnly = True
        Me.textboxIDAccidente.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDAccidente.TabIndex = 17
        Me.textboxIDAccidente.TabStop = False
        Me.textboxIDAccidente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 270)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 23
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 244)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 20
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 270)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 22
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 244)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 19
        '
        'textboxDiagnostico
        '
        Me.textboxDiagnostico.Location = New System.Drawing.Point(108, 39)
        Me.textboxDiagnostico.MaxLength = 500
        Me.textboxDiagnostico.Multiline = True
        Me.textboxDiagnostico.Name = "textboxDiagnostico"
        Me.textboxDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxDiagnostico.Size = New System.Drawing.Size(395, 59)
        Me.textboxDiagnostico.TabIndex = 3
        '
        'textboxCapacidad
        '
        Me.textboxCapacidad.Location = New System.Drawing.Point(108, 163)
        Me.textboxCapacidad.MaxLength = 500
        Me.textboxCapacidad.Multiline = True
        Me.textboxCapacidad.Name = "textboxCapacidad"
        Me.textboxCapacidad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxCapacidad.Size = New System.Drawing.Size(395, 59)
        Me.textboxCapacidad.TabIndex = 13
        '
        'datetimepickerFechaAlta
        '
        Me.datetimepickerFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaAlta.Location = New System.Drawing.Point(108, 137)
        Me.datetimepickerFechaAlta.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaAlta.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaAlta.Name = "datetimepickerFechaAlta"
        Me.datetimepickerFechaAlta.ShowCheckBox = True
        Me.datetimepickerFechaAlta.Size = New System.Drawing.Size(134, 20)
        Me.datetimepickerFechaAlta.TabIndex = 11
        '
        'labelFechaAlta
        '
        Me.labelFechaAlta.AutoSize = True
        Me.labelFechaAlta.Location = New System.Drawing.Point(6, 140)
        Me.labelFechaAlta.Name = "labelFechaAlta"
        Me.labelFechaAlta.Size = New System.Drawing.Size(75, 13)
        Me.labelFechaAlta.TabIndex = 10
        Me.labelFechaAlta.Text = "Fecha de alta:"
        '
        'textboxDisminucionFisica
        '
        Me.textboxDisminucionFisica.Location = New System.Drawing.Point(108, 228)
        Me.textboxDisminucionFisica.MaxLength = 500
        Me.textboxDisminucionFisica.Multiline = True
        Me.textboxDisminucionFisica.Name = "textboxDisminucionFisica"
        Me.textboxDisminucionFisica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxDisminucionFisica.Size = New System.Drawing.Size(395, 59)
        Me.textboxDisminucionFisica.TabIndex = 15
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(6, 231)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(96, 13)
        Label1.TabIndex = 14
        Label1.Text = "Dismunición física:"
        '
        'formPersonaAccidente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 379)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPersonaAccidente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Accidente de la Persona"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        Me.tabpageNotasAuditoria.ResumeLayout(False)
        Me.tabpageNotasAuditoria.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents datetimepickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelFecha As System.Windows.Forms.Label
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents textboxFolioNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxLibroNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxActaNumero As System.Windows.Forms.TextBox
    Friend WithEvents tabcontrolMain As CS_Control_TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents labelIDAccidente As System.Windows.Forms.Label
    Friend WithEvents textboxIDAccidente As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxDiagnostico As TextBox
    Friend WithEvents datetimepickerFechaAlta As DateTimePicker
    Friend WithEvents labelFechaAlta As Label
    Friend WithEvents textboxCapacidad As TextBox
    Friend WithEvents textboxDisminucionFisica As TextBox
End Class
