<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaHorarioLaboralAgregarMultiples
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
        Dim labelTurno1Desde As System.Windows.Forms.Label
        Dim labelTurno1Hasta As System.Windows.Forms.Label
        Dim labelTurno2Hasta As System.Windows.Forms.Label
        Dim labelTurno2Desde As System.Windows.Forms.Label
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.labelDiaSemana = New System.Windows.Forms.Label()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.tabcontrolMain = New System.Windows.Forms.TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.checkboxDiaSemana1 = New System.Windows.Forms.CheckBox()
        Me.checkboxDiaSemana7 = New System.Windows.Forms.CheckBox()
        Me.checkboxDiaSemana6 = New System.Windows.Forms.CheckBox()
        Me.checkboxDiaSemana5 = New System.Windows.Forms.CheckBox()
        Me.checkboxDiaSemana4 = New System.Windows.Forms.CheckBox()
        Me.checkboxDiaSemana3 = New System.Windows.Forms.CheckBox()
        Me.checkboxDiaSemana2 = New System.Windows.Forms.CheckBox()
        Me.datetimepickerTurno2Hasta = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerTurno2Desde = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerTurno1Hasta = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerTurno1Desde = New System.Windows.Forms.DateTimePicker()
        Me.tabpageNotas = New System.Windows.Forms.TabPage()
        labelTurno1Desde = New System.Windows.Forms.Label()
        labelTurno1Hasta = New System.Windows.Forms.Label()
        labelTurno2Hasta = New System.Windows.Forms.Label()
        labelTurno2Desde = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.tabpageNotas.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTurno1Desde
        '
        labelTurno1Desde.AutoSize = True
        labelTurno1Desde.Location = New System.Drawing.Point(6, 75)
        labelTurno1Desde.Name = "labelTurno1Desde"
        labelTurno1Desde.Size = New System.Drawing.Size(87, 13)
        labelTurno1Desde.TabIndex = 2
        labelTurno1Desde.Text = "Turno 1 - Desde:"
        '
        'labelTurno1Hasta
        '
        labelTurno1Hasta.AutoSize = True
        labelTurno1Hasta.Location = New System.Drawing.Point(227, 75)
        labelTurno1Hasta.Name = "labelTurno1Hasta"
        labelTurno1Hasta.Size = New System.Drawing.Size(38, 13)
        labelTurno1Hasta.TabIndex = 4
        labelTurno1Hasta.Text = "Hasta:"
        '
        'labelTurno2Hasta
        '
        labelTurno2Hasta.AutoSize = True
        labelTurno2Hasta.Location = New System.Drawing.Point(227, 105)
        labelTurno2Hasta.Name = "labelTurno2Hasta"
        labelTurno2Hasta.Size = New System.Drawing.Size(38, 13)
        labelTurno2Hasta.TabIndex = 8
        labelTurno2Hasta.Text = "Hasta:"
        '
        'labelTurno2Desde
        '
        labelTurno2Desde.AutoSize = True
        labelTurno2Desde.Location = New System.Drawing.Point(6, 105)
        labelTurno2Desde.Name = "labelTurno2Desde"
        labelTurno2Desde.Size = New System.Drawing.Size(87, 13)
        labelTurno2Desde.TabIndex = 6
        labelTurno2Desde.Text = "Turno 2 - Desde:"
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
        Me.toolstripMain.Size = New System.Drawing.Size(542, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'labelDiaSemana
        '
        Me.labelDiaSemana.AutoSize = True
        Me.labelDiaSemana.Location = New System.Drawing.Point(6, 25)
        Me.labelDiaSemana.Name = "labelDiaSemana"
        Me.labelDiaSemana.Size = New System.Drawing.Size(99, 13)
        Me.labelDiaSemana.TabIndex = 0
        Me.labelDiaSemana.Text = "Días de la semana:"
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(50, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(450, 121)
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
        'tabcontrolMain
        '
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotas)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(518, 162)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.checkboxDiaSemana1)
        Me.tabpageGeneral.Controls.Add(Me.checkboxDiaSemana7)
        Me.tabpageGeneral.Controls.Add(Me.checkboxDiaSemana6)
        Me.tabpageGeneral.Controls.Add(Me.checkboxDiaSemana5)
        Me.tabpageGeneral.Controls.Add(Me.checkboxDiaSemana4)
        Me.tabpageGeneral.Controls.Add(Me.checkboxDiaSemana3)
        Me.tabpageGeneral.Controls.Add(Me.checkboxDiaSemana2)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerTurno2Hasta)
        Me.tabpageGeneral.Controls.Add(labelTurno2Hasta)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerTurno2Desde)
        Me.tabpageGeneral.Controls.Add(labelTurno2Desde)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerTurno1Hasta)
        Me.tabpageGeneral.Controls.Add(labelTurno1Hasta)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerTurno1Desde)
        Me.tabpageGeneral.Controls.Add(Me.labelDiaSemana)
        Me.tabpageGeneral.Controls.Add(labelTurno1Desde)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(510, 133)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'checkboxDiaSemana1
        '
        Me.checkboxDiaSemana1.AutoSize = True
        Me.checkboxDiaSemana1.Location = New System.Drawing.Point(180, 38)
        Me.checkboxDiaSemana1.Name = "checkboxDiaSemana1"
        Me.checkboxDiaSemana1.Size = New System.Drawing.Size(68, 17)
        Me.checkboxDiaSemana1.TabIndex = 16
        Me.checkboxDiaSemana1.Text = "Domingo"
        Me.checkboxDiaSemana1.UseVisualStyleBackColor = True
        '
        'checkboxDiaSemana7
        '
        Me.checkboxDiaSemana7.AutoSize = True
        Me.checkboxDiaSemana7.Location = New System.Drawing.Point(111, 38)
        Me.checkboxDiaSemana7.Name = "checkboxDiaSemana7"
        Me.checkboxDiaSemana7.Size = New System.Drawing.Size(63, 17)
        Me.checkboxDiaSemana7.TabIndex = 15
        Me.checkboxDiaSemana7.Text = "Sábado"
        Me.checkboxDiaSemana7.UseVisualStyleBackColor = True
        '
        'checkboxDiaSemana6
        '
        Me.checkboxDiaSemana6.AutoSize = True
        Me.checkboxDiaSemana6.Location = New System.Drawing.Point(379, 15)
        Me.checkboxDiaSemana6.Name = "checkboxDiaSemana6"
        Me.checkboxDiaSemana6.Size = New System.Drawing.Size(61, 17)
        Me.checkboxDiaSemana6.TabIndex = 14
        Me.checkboxDiaSemana6.Text = "Viernes"
        Me.checkboxDiaSemana6.UseVisualStyleBackColor = True
        '
        'checkboxDiaSemana5
        '
        Me.checkboxDiaSemana5.AutoSize = True
        Me.checkboxDiaSemana5.Location = New System.Drawing.Point(313, 15)
        Me.checkboxDiaSemana5.Name = "checkboxDiaSemana5"
        Me.checkboxDiaSemana5.Size = New System.Drawing.Size(60, 17)
        Me.checkboxDiaSemana5.TabIndex = 13
        Me.checkboxDiaSemana5.Text = "Jueves"
        Me.checkboxDiaSemana5.UseVisualStyleBackColor = True
        '
        'checkboxDiaSemana4
        '
        Me.checkboxDiaSemana4.AutoSize = True
        Me.checkboxDiaSemana4.Location = New System.Drawing.Point(236, 15)
        Me.checkboxDiaSemana4.Name = "checkboxDiaSemana4"
        Me.checkboxDiaSemana4.Size = New System.Drawing.Size(71, 17)
        Me.checkboxDiaSemana4.TabIndex = 12
        Me.checkboxDiaSemana4.Text = "Miércoles"
        Me.checkboxDiaSemana4.UseVisualStyleBackColor = True
        '
        'checkboxDiaSemana3
        '
        Me.checkboxDiaSemana3.AutoSize = True
        Me.checkboxDiaSemana3.Location = New System.Drawing.Point(172, 15)
        Me.checkboxDiaSemana3.Name = "checkboxDiaSemana3"
        Me.checkboxDiaSemana3.Size = New System.Drawing.Size(58, 17)
        Me.checkboxDiaSemana3.TabIndex = 11
        Me.checkboxDiaSemana3.Text = "Martes"
        Me.checkboxDiaSemana3.UseVisualStyleBackColor = True
        '
        'checkboxDiaSemana2
        '
        Me.checkboxDiaSemana2.AutoSize = True
        Me.checkboxDiaSemana2.Location = New System.Drawing.Point(111, 15)
        Me.checkboxDiaSemana2.Name = "checkboxDiaSemana2"
        Me.checkboxDiaSemana2.Size = New System.Drawing.Size(55, 17)
        Me.checkboxDiaSemana2.TabIndex = 10
        Me.checkboxDiaSemana2.Text = "Lunes"
        Me.checkboxDiaSemana2.UseVisualStyleBackColor = True
        '
        'datetimepickerTurno2Hasta
        '
        Me.datetimepickerTurno2Hasta.CustomFormat = "HH:mm"
        Me.datetimepickerTurno2Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickerTurno2Hasta.Location = New System.Drawing.Point(271, 101)
        Me.datetimepickerTurno2Hasta.Name = "datetimepickerTurno2Hasta"
        Me.datetimepickerTurno2Hasta.ShowCheckBox = True
        Me.datetimepickerTurno2Hasta.ShowUpDown = True
        Me.datetimepickerTurno2Hasta.Size = New System.Drawing.Size(80, 20)
        Me.datetimepickerTurno2Hasta.TabIndex = 9
        Me.datetimepickerTurno2Hasta.Value = New Date(1753, 1, 1, 0, 0, 0, 0)
        '
        'datetimepickerTurno2Desde
        '
        Me.datetimepickerTurno2Desde.CustomFormat = "HH:mm"
        Me.datetimepickerTurno2Desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickerTurno2Desde.Location = New System.Drawing.Point(111, 101)
        Me.datetimepickerTurno2Desde.Name = "datetimepickerTurno2Desde"
        Me.datetimepickerTurno2Desde.ShowCheckBox = True
        Me.datetimepickerTurno2Desde.ShowUpDown = True
        Me.datetimepickerTurno2Desde.Size = New System.Drawing.Size(80, 20)
        Me.datetimepickerTurno2Desde.TabIndex = 7
        Me.datetimepickerTurno2Desde.Value = New Date(1753, 1, 1, 0, 0, 0, 0)
        '
        'datetimepickerTurno1Hasta
        '
        Me.datetimepickerTurno1Hasta.CustomFormat = "HH:mm"
        Me.datetimepickerTurno1Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickerTurno1Hasta.Location = New System.Drawing.Point(271, 71)
        Me.datetimepickerTurno1Hasta.Name = "datetimepickerTurno1Hasta"
        Me.datetimepickerTurno1Hasta.ShowCheckBox = True
        Me.datetimepickerTurno1Hasta.ShowUpDown = True
        Me.datetimepickerTurno1Hasta.Size = New System.Drawing.Size(80, 20)
        Me.datetimepickerTurno1Hasta.TabIndex = 5
        Me.datetimepickerTurno1Hasta.Value = New Date(1753, 1, 1, 0, 0, 0, 0)
        '
        'datetimepickerTurno1Desde
        '
        Me.datetimepickerTurno1Desde.CustomFormat = "HH:mm"
        Me.datetimepickerTurno1Desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickerTurno1Desde.Location = New System.Drawing.Point(111, 71)
        Me.datetimepickerTurno1Desde.Name = "datetimepickerTurno1Desde"
        Me.datetimepickerTurno1Desde.ShowCheckBox = True
        Me.datetimepickerTurno1Desde.ShowUpDown = True
        Me.datetimepickerTurno1Desde.Size = New System.Drawing.Size(80, 20)
        Me.datetimepickerTurno1Desde.TabIndex = 3
        Me.datetimepickerTurno1Desde.Value = New Date(1753, 1, 1, 0, 0, 0, 0)
        '
        'tabpageNotas
        '
        Me.tabpageNotas.Controls.Add(Me.textboxNotas)
        Me.tabpageNotas.Controls.Add(Me.labelNotas)
        Me.tabpageNotas.Location = New System.Drawing.Point(4, 25)
        Me.tabpageNotas.Name = "tabpageNotas"
        Me.tabpageNotas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageNotas.Size = New System.Drawing.Size(510, 133)
        Me.tabpageNotas.TabIndex = 1
        Me.tabpageNotas.Text = "Notas"
        Me.tabpageNotas.UseVisualStyleBackColor = True
        '
        'formPersonaHorarioLaboralAgregarMultiples
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 215)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPersonaHorarioLaboralAgregarMultiples"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar Múltiples Horarios Laborales de la Persona"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        Me.tabpageNotas.ResumeLayout(False)
        Me.tabpageNotas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents labelDiaSemana As System.Windows.Forms.Label
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents tabcontrolMain As System.Windows.Forms.TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotas As System.Windows.Forms.TabPage
    Friend WithEvents datetimepickerTurno1Hasta As DateTimePicker
    Friend WithEvents datetimepickerTurno1Desde As DateTimePicker
    Friend WithEvents datetimepickerTurno2Hasta As DateTimePicker
    Friend WithEvents datetimepickerTurno2Desde As DateTimePicker
    Friend WithEvents checkboxDiaSemana1 As CheckBox
    Friend WithEvents checkboxDiaSemana7 As CheckBox
    Friend WithEvents checkboxDiaSemana6 As CheckBox
    Friend WithEvents checkboxDiaSemana5 As CheckBox
    Friend WithEvents checkboxDiaSemana4 As CheckBox
    Friend WithEvents checkboxDiaSemana3 As CheckBox
    Friend WithEvents checkboxDiaSemana2 As CheckBox
End Class
