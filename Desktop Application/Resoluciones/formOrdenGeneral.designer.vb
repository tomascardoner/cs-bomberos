<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formOrdenGeneral
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.TabControlMain = New CSBomberos.CS_Control_TabControl()
        Me.TabPageGeneral = New System.Windows.Forms.TabPage()
        Me.ComboBoxDeroga = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxCategoria = New System.Windows.Forms.ComboBox()
        Me.LabelCategoria = New System.Windows.Forms.Label()
        Me.LabelPersonal = New System.Windows.Forms.Label()
        Me.TextBoxPersonal = New System.Windows.Forms.TextBox()
        Me.LabelDescripcion = New System.Windows.Forms.Label()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.NumericUpDownSubNumero = New System.Windows.Forms.NumericUpDown()
        Me.LabelSubNumero = New System.Windows.Forms.Label()
        Me.IntegerTextBoxNumero = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.LabelNumero = New System.Windows.Forms.Label()
        Me.ButtonNumeroSiguiente = New System.Windows.Forms.Button()
        Me.TabPageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.TabControlMain.SuspendLayout()
        Me.TabPageGeneral.SuspendLayout()
        CType(Me.NumericUpDownSubNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntegerTextBoxNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelModificacion
        '
        labelModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(10, 236)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 21
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(10, 210)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 18
        labelCreacion.Text = "Creación:"
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
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.CSBomberos.My.Resources.Resources.ImageEditar32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSBomberos.My.Resources.Resources.ImageCerrar32
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
        'textboxNotas
        '
        Me.textboxNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxNotas.Location = New System.Drawing.Point(114, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(390, 169)
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
        'TabControlMain
        '
        Me.TabControlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControlMain.Controls.Add(Me.TabPageGeneral)
        Me.TabControlMain.Controls.Add(Me.TabPageNotasAuditoria)
        Me.TabControlMain.Location = New System.Drawing.Point(12, 42)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(518, 311)
        Me.TabControlMain.TabIndex = 0
        '
        'TabPageGeneral
        '
        Me.TabPageGeneral.Controls.Add(Me.ComboBoxDeroga)
        Me.TabPageGeneral.Controls.Add(Me.Label1)
        Me.TabPageGeneral.Controls.Add(Me.ComboBoxCategoria)
        Me.TabPageGeneral.Controls.Add(Me.LabelCategoria)
        Me.TabPageGeneral.Controls.Add(Me.LabelPersonal)
        Me.TabPageGeneral.Controls.Add(Me.TextBoxPersonal)
        Me.TabPageGeneral.Controls.Add(Me.LabelDescripcion)
        Me.TabPageGeneral.Controls.Add(Me.TextBoxDescripcion)
        Me.TabPageGeneral.Controls.Add(Me.DateTimePickerFecha)
        Me.TabPageGeneral.Controls.Add(Me.LabelFecha)
        Me.TabPageGeneral.Controls.Add(Me.NumericUpDownSubNumero)
        Me.TabPageGeneral.Controls.Add(Me.LabelSubNumero)
        Me.TabPageGeneral.Controls.Add(Me.IntegerTextBoxNumero)
        Me.TabPageGeneral.Controls.Add(Me.LabelNumero)
        Me.TabPageGeneral.Controls.Add(Me.ButtonNumeroSiguiente)
        Me.TabPageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.TabPageGeneral.Name = "TabPageGeneral"
        Me.TabPageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageGeneral.Size = New System.Drawing.Size(510, 282)
        Me.TabPageGeneral.TabIndex = 2
        Me.TabPageGeneral.Text = "General"
        Me.TabPageGeneral.UseVisualStyleBackColor = True
        '
        'ComboBoxDeroga
        '
        Me.ComboBoxDeroga.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxDeroga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDeroga.FormattingEnabled = True
        Me.ComboBoxDeroga.Location = New System.Drawing.Point(82, 255)
        Me.ComboBoxDeroga.Name = "ComboBoxDeroga"
        Me.ComboBoxDeroga.Size = New System.Drawing.Size(422, 21)
        Me.ComboBoxDeroga.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Deroga O.G.:"
        '
        'ComboBoxCategoria
        '
        Me.ComboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCategoria.FormattingEnabled = True
        Me.ComboBoxCategoria.Location = New System.Drawing.Point(82, 228)
        Me.ComboBoxCategoria.Name = "ComboBoxCategoria"
        Me.ComboBoxCategoria.Size = New System.Drawing.Size(199, 21)
        Me.ComboBoxCategoria.TabIndex = 12
        '
        'LabelCategoria
        '
        Me.LabelCategoria.AutoSize = True
        Me.LabelCategoria.Location = New System.Drawing.Point(6, 231)
        Me.LabelCategoria.Name = "LabelCategoria"
        Me.LabelCategoria.Size = New System.Drawing.Size(57, 13)
        Me.LabelCategoria.TabIndex = 11
        Me.LabelCategoria.Text = "Categoría:"
        '
        'LabelPersonal
        '
        Me.LabelPersonal.AutoSize = True
        Me.LabelPersonal.Location = New System.Drawing.Point(6, 152)
        Me.LabelPersonal.Name = "LabelPersonal"
        Me.LabelPersonal.Size = New System.Drawing.Size(51, 13)
        Me.LabelPersonal.TabIndex = 9
        Me.LabelPersonal.Text = "Personal:"
        '
        'TextBoxPersonal
        '
        Me.TextBoxPersonal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPersonal.Location = New System.Drawing.Point(82, 149)
        Me.TextBoxPersonal.MaxLength = 0
        Me.TextBoxPersonal.Multiline = True
        Me.TextBoxPersonal.Name = "TextBoxPersonal"
        Me.TextBoxPersonal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxPersonal.Size = New System.Drawing.Size(422, 73)
        Me.TextBoxPersonal.TabIndex = 10
        '
        'LabelDescripcion
        '
        Me.LabelDescripcion.AutoSize = True
        Me.LabelDescripcion.Location = New System.Drawing.Point(6, 73)
        Me.LabelDescripcion.Name = "LabelDescripcion"
        Me.LabelDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.LabelDescripcion.TabIndex = 7
        Me.LabelDescripcion.Text = "Descripción:"
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(82, 70)
        Me.TextBoxDescripcion.MaxLength = 0
        Me.TextBoxDescripcion.Multiline = True
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(422, 73)
        Me.TextBoxDescripcion.TabIndex = 8
        '
        'DateTimePickerFecha
        '
        Me.DateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFecha.Location = New System.Drawing.Point(82, 44)
        Me.DateTimePickerFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
        Me.DateTimePickerFecha.ShowCheckBox = True
        Me.DateTimePickerFecha.Size = New System.Drawing.Size(138, 20)
        Me.DateTimePickerFecha.TabIndex = 6
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Location = New System.Drawing.Point(6, 47)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(40, 13)
        Me.LabelFecha.TabIndex = 5
        Me.LabelFecha.Text = "Fecha:"
        '
        'NumericUpDownSubNumero
        '
        Me.NumericUpDownSubNumero.Location = New System.Drawing.Point(323, 19)
        Me.NumericUpDownSubNumero.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownSubNumero.Name = "NumericUpDownSubNumero"
        Me.NumericUpDownSubNumero.Size = New System.Drawing.Size(47, 20)
        Me.NumericUpDownSubNumero.TabIndex = 4
        Me.NumericUpDownSubNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelSubNumero
        '
        Me.LabelSubNumero.AutoSize = True
        Me.LabelSubNumero.Location = New System.Drawing.Point(250, 22)
        Me.LabelSubNumero.Name = "LabelSubNumero"
        Me.LabelSubNumero.Size = New System.Drawing.Size(67, 13)
        Me.LabelSubNumero.TabIndex = 3
        Me.LabelSubNumero.Text = "Sub-número:"
        '
        'IntegerTextBoxNumero
        '
        Me.IntegerTextBoxNumero.BeforeTouchSize = New System.Drawing.Size(47, 20)
        Me.IntegerTextBoxNumero.IntegerValue = CType(1, Long)
        Me.IntegerTextBoxNumero.Location = New System.Drawing.Point(82, 18)
        Me.IntegerTextBoxNumero.MaxValue = CType(32767, Long)
        Me.IntegerTextBoxNumero.MinValue = CType(1, Long)
        Me.IntegerTextBoxNumero.Name = "IntegerTextBoxNumero"
        Me.IntegerTextBoxNumero.Size = New System.Drawing.Size(47, 20)
        Me.IntegerTextBoxNumero.TabIndex = 1
        Me.IntegerTextBoxNumero.Text = "1"
        Me.IntegerTextBoxNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelNumero
        '
        Me.LabelNumero.AutoSize = True
        Me.LabelNumero.Location = New System.Drawing.Point(6, 21)
        Me.LabelNumero.Name = "LabelNumero"
        Me.LabelNumero.Size = New System.Drawing.Size(47, 13)
        Me.LabelNumero.TabIndex = 0
        Me.LabelNumero.Text = "Número:"
        '
        'ButtonNumeroSiguiente
        '
        Me.ButtonNumeroSiguiente.Location = New System.Drawing.Point(135, 18)
        Me.ButtonNumeroSiguiente.Name = "ButtonNumeroSiguiente"
        Me.ButtonNumeroSiguiente.Size = New System.Drawing.Size(103, 21)
        Me.ButtonNumeroSiguiente.TabIndex = 2
        Me.ButtonNumeroSiguiente.Text = "Obtener siguiente"
        Me.ButtonNumeroSiguiente.UseVisualStyleBackColor = True
        '
        'TabPageNotasAuditoria
        '
        Me.TabPageNotasAuditoria.Controls.Add(Me.LabelID)
        Me.TabPageNotasAuditoria.Controls.Add(Me.TextBoxID)
        Me.TabPageNotasAuditoria.Controls.Add(Me.textboxUsuarioModificacion)
        Me.TabPageNotasAuditoria.Controls.Add(Me.textboxUsuarioCreacion)
        Me.TabPageNotasAuditoria.Controls.Add(Me.textboxFechaHoraModificacion)
        Me.TabPageNotasAuditoria.Controls.Add(Me.textboxFechaHoraCreacion)
        Me.TabPageNotasAuditoria.Controls.Add(labelModificacion)
        Me.TabPageNotasAuditoria.Controls.Add(labelCreacion)
        Me.TabPageNotasAuditoria.Controls.Add(Me.textboxNotas)
        Me.TabPageNotasAuditoria.Controls.Add(Me.labelNotas)
        Me.TabPageNotasAuditoria.Location = New System.Drawing.Point(4, 25)
        Me.TabPageNotasAuditoria.Name = "TabPageNotasAuditoria"
        Me.TabPageNotasAuditoria.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageNotasAuditoria.Size = New System.Drawing.Size(510, 282)
        Me.TabPageNotasAuditoria.TabIndex = 1
        Me.TabPageNotasAuditoria.Text = "Notas y Auditoría"
        Me.TabPageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'LabelID
        '
        Me.LabelID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(10, 184)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(21, 13)
        Me.LabelID.TabIndex = 16
        Me.LabelID.Text = "ID:"
        '
        'TextBoxID
        '
        Me.TextBoxID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxID.Location = New System.Drawing.Point(118, 181)
        Me.TextBoxID.MaxLength = 10
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.ReadOnly = True
        Me.TextBoxID.Size = New System.Drawing.Size(72, 20)
        Me.TextBoxID.TabIndex = 17
        Me.TextBoxID.TabStop = False
        Me.TextBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(245, 233)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 23
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(245, 207)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 20
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(118, 233)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 22
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(118, 207)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 19
        '
        'formOrdenGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 364)
        Me.Controls.Add(Me.TabControlMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formOrdenGeneral"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Órden general"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPageGeneral.ResumeLayout(False)
        Me.TabPageGeneral.PerformLayout()
        CType(Me.NumericUpDownSubNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntegerTextBoxNumero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageNotasAuditoria.ResumeLayout(False)
        Me.TabPageNotasAuditoria.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents TabControlMain As CS_Control_TabControl
    Friend WithEvents TabPageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents LabelID As System.Windows.Forms.Label
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents TabPageGeneral As TabPage
    Friend WithEvents IntegerTextBoxNumero As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents LabelNumero As Label
    Friend WithEvents ButtonNumeroSiguiente As Button
    Friend WithEvents NumericUpDownSubNumero As NumericUpDown
    Friend WithEvents LabelSubNumero As Label
    Friend WithEvents DateTimePickerFecha As DateTimePicker
    Friend WithEvents LabelFecha As Label
    Friend WithEvents LabelDescripcion As Label
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents LabelPersonal As Label
    Friend WithEvents TextBoxPersonal As TextBox
    Friend WithEvents ComboBoxCategoria As ComboBox
    Friend WithEvents LabelCategoria As Label
    Friend WithEvents ComboBoxDeroga As ComboBox
    Friend WithEvents Label1 As Label
End Class
