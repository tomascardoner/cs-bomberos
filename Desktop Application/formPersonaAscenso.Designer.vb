<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaAscenso
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
        Dim labelCargo As System.Windows.Forms.Label
        Dim labelCargoJerarquia As System.Windows.Forms.Label
        Dim labelFolioNumero As System.Windows.Forms.Label
        Dim labelLibroNumero As System.Windows.Forms.Label
        Dim labelActaNumero As System.Windows.Forms.Label
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.textboxIDAscenso = New System.Windows.Forms.TextBox()
        Me.labelIDAscenso = New System.Windows.Forms.Label()
        Me.datetimepickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.comboboxCargo = New System.Windows.Forms.ComboBox()
        Me.comboboxCargoJerarquia = New System.Windows.Forms.ComboBox()
        Me.textboxFolioNumero = New System.Windows.Forms.TextBox()
        Me.textboxLibroNumero = New System.Windows.Forms.TextBox()
        Me.textboxActaNumero = New System.Windows.Forms.TextBox()
        labelCargo = New System.Windows.Forms.Label()
        labelCargoJerarquia = New System.Windows.Forms.Label()
        labelFolioNumero = New System.Windows.Forms.Label()
        labelLibroNumero = New System.Windows.Forms.Label()
        labelActaNumero = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelCargo
        '
        labelCargo.AutoSize = True
        labelCargo.Location = New System.Drawing.Point(12, 105)
        labelCargo.Name = "labelCargo"
        labelCargo.Size = New System.Drawing.Size(38, 13)
        labelCargo.TabIndex = 4
        labelCargo.Text = "Cargo:"
        '
        'labelCargoJerarquia
        '
        labelCargoJerarquia.AutoSize = True
        labelCargoJerarquia.Location = New System.Drawing.Point(12, 132)
        labelCargoJerarquia.Name = "labelCargoJerarquia"
        labelCargoJerarquia.Size = New System.Drawing.Size(55, 13)
        labelCargoJerarquia.TabIndex = 6
        labelCargoJerarquia.Text = "Jerarquía:"
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
        Me.toolstripMain.TabIndex = 16
        '
        'textboxIDAscenso
        '
        Me.textboxIDAscenso.Location = New System.Drawing.Point(117, 50)
        Me.textboxIDAscenso.MaxLength = 10
        Me.textboxIDAscenso.Name = "textboxIDAscenso"
        Me.textboxIDAscenso.ReadOnly = True
        Me.textboxIDAscenso.Size = New System.Drawing.Size(74, 20)
        Me.textboxIDAscenso.TabIndex = 1
        Me.textboxIDAscenso.TabStop = False
        Me.textboxIDAscenso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelIDAscenso
        '
        Me.labelIDAscenso.AutoSize = True
        Me.labelIDAscenso.Location = New System.Drawing.Point(12, 53)
        Me.labelIDAscenso.Name = "labelIDAscenso"
        Me.labelIDAscenso.Size = New System.Drawing.Size(21, 13)
        Me.labelIDAscenso.TabIndex = 0
        Me.labelIDAscenso.Text = "ID:"
        '
        'datetimepickerFecha
        '
        Me.datetimepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFecha.Location = New System.Drawing.Point(117, 76)
        Me.datetimepickerFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFecha.Name = "datetimepickerFecha"
        Me.datetimepickerFecha.Size = New System.Drawing.Size(116, 20)
        Me.datetimepickerFecha.TabIndex = 3
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(12, 82)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelFecha.TabIndex = 2
        Me.labelFecha.Text = "Fecha:"
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(117, 182)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(340, 47)
        Me.textboxNotas.TabIndex = 15
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(12, 185)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 14
        Me.labelNotas.Text = "Notas:"
        '
        'comboboxCargo
        '
        Me.comboboxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCargo.FormattingEnabled = True
        Me.comboboxCargo.Location = New System.Drawing.Point(117, 102)
        Me.comboboxCargo.Name = "comboboxCargo"
        Me.comboboxCargo.Size = New System.Drawing.Size(340, 21)
        Me.comboboxCargo.TabIndex = 5
        '
        'comboboxCargoJerarquia
        '
        Me.comboboxCargoJerarquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCargoJerarquia.FormattingEnabled = True
        Me.comboboxCargoJerarquia.Location = New System.Drawing.Point(117, 129)
        Me.comboboxCargoJerarquia.Name = "comboboxCargoJerarquia"
        Me.comboboxCargoJerarquia.Size = New System.Drawing.Size(340, 21)
        Me.comboboxCargoJerarquia.TabIndex = 7
        '
        'textboxFolioNumero
        '
        Me.textboxFolioNumero.Location = New System.Drawing.Point(250, 156)
        Me.textboxFolioNumero.MaxLength = 10
        Me.textboxFolioNumero.Name = "textboxFolioNumero"
        Me.textboxFolioNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxFolioNumero.TabIndex = 11
        '
        'labelFolioNumero
        '
        labelFolioNumero.AutoSize = True
        labelFolioNumero.Location = New System.Drawing.Point(197, 159)
        labelFolioNumero.Name = "labelFolioNumero"
        labelFolioNumero.Size = New System.Drawing.Size(47, 13)
        labelFolioNumero.TabIndex = 10
        labelFolioNumero.Text = "Folio N°:"
        '
        'labelLibroNumero
        '
        labelLibroNumero.AutoSize = True
        labelLibroNumero.Location = New System.Drawing.Point(12, 159)
        labelLibroNumero.Name = "labelLibroNumero"
        labelLibroNumero.Size = New System.Drawing.Size(48, 13)
        labelLibroNumero.TabIndex = 8
        labelLibroNumero.Text = "Libro N°:"
        '
        'textboxLibroNumero
        '
        Me.textboxLibroNumero.Location = New System.Drawing.Point(117, 156)
        Me.textboxLibroNumero.MaxLength = 10
        Me.textboxLibroNumero.Name = "textboxLibroNumero"
        Me.textboxLibroNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxLibroNumero.TabIndex = 9
        '
        'labelActaNumero
        '
        labelActaNumero.AutoSize = True
        labelActaNumero.Location = New System.Drawing.Point(330, 159)
        labelActaNumero.Name = "labelActaNumero"
        labelActaNumero.Size = New System.Drawing.Size(47, 13)
        labelActaNumero.TabIndex = 12
        labelActaNumero.Text = "Acta N°:"
        '
        'textboxActaNumero
        '
        Me.textboxActaNumero.Location = New System.Drawing.Point(383, 156)
        Me.textboxActaNumero.MaxLength = 10
        Me.textboxActaNumero.Name = "textboxActaNumero"
        Me.textboxActaNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxActaNumero.TabIndex = 13
        '
        'formPersonaAscenso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 247)
        Me.Controls.Add(Me.textboxFolioNumero)
        Me.Controls.Add(labelFolioNumero)
        Me.Controls.Add(labelLibroNumero)
        Me.Controls.Add(Me.textboxLibroNumero)
        Me.Controls.Add(labelActaNumero)
        Me.Controls.Add(Me.textboxActaNumero)
        Me.Controls.Add(Me.comboboxCargoJerarquia)
        Me.Controls.Add(labelCargoJerarquia)
        Me.Controls.Add(Me.comboboxCargo)
        Me.Controls.Add(labelCargo)
        Me.Controls.Add(Me.textboxNotas)
        Me.Controls.Add(Me.labelNotas)
        Me.Controls.Add(Me.labelFecha)
        Me.Controls.Add(Me.datetimepickerFecha)
        Me.Controls.Add(Me.labelIDAscenso)
        Me.Controls.Add(Me.textboxIDAscenso)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPersonaAscenso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ascenso - Promoción de la Persona"
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
    Friend WithEvents textboxIDAscenso As System.Windows.Forms.TextBox
    Friend WithEvents labelIDAscenso As System.Windows.Forms.Label
    Friend WithEvents datetimepickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelFecha As System.Windows.Forms.Label
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents comboboxCargo As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxCargoJerarquia As System.Windows.Forms.ComboBox
    Friend WithEvents textboxFolioNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxLibroNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxActaNumero As System.Windows.Forms.TextBox
End Class
