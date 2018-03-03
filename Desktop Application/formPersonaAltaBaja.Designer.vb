<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaAltaBaja
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
        Dim labelAltaFolioNumero As System.Windows.Forms.Label
        Dim labelAltaLibroNumero As System.Windows.Forms.Label
        Dim labelAltaActaNumero As System.Windows.Forms.Label
        Dim labelBajaFolioNumero As System.Windows.Forms.Label
        Dim labelBajaLibroNumero As System.Windows.Forms.Label
        Dim labelBajaActaNumero As System.Windows.Forms.Label
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.textboxIDAltaBaja = New System.Windows.Forms.TextBox()
        Me.labelIDAltaBaja = New System.Windows.Forms.Label()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.groupboxAlta = New System.Windows.Forms.GroupBox()
        Me.textboxAltaFolioNumero = New System.Windows.Forms.TextBox()
        Me.textboxAltaLibroNumero = New System.Windows.Forms.TextBox()
        Me.textboxAltaActaNumero = New System.Windows.Forms.TextBox()
        Me.labelAltaFecha = New System.Windows.Forms.Label()
        Me.datetimepickerAltaFecha = New System.Windows.Forms.DateTimePicker()
        Me.groupboxBaja = New System.Windows.Forms.GroupBox()
        Me.textboxBajaFolioNumero = New System.Windows.Forms.TextBox()
        Me.textboxBajaLibroNumero = New System.Windows.Forms.TextBox()
        Me.textboxBajaActaNumero = New System.Windows.Forms.TextBox()
        Me.labelBajaFecha = New System.Windows.Forms.Label()
        Me.datetimepickerBajaFecha = New System.Windows.Forms.DateTimePicker()
        labelAltaFolioNumero = New System.Windows.Forms.Label()
        labelAltaLibroNumero = New System.Windows.Forms.Label()
        labelAltaActaNumero = New System.Windows.Forms.Label()
        labelBajaFolioNumero = New System.Windows.Forms.Label()
        labelBajaLibroNumero = New System.Windows.Forms.Label()
        labelBajaActaNumero = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.groupboxAlta.SuspendLayout()
        Me.groupboxBaja.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelAltaFolioNumero
        '
        labelAltaFolioNumero.AutoSize = True
        labelAltaFolioNumero.Location = New System.Drawing.Point(297, 48)
        labelAltaFolioNumero.Name = "labelAltaFolioNumero"
        labelAltaFolioNumero.Size = New System.Drawing.Size(47, 13)
        labelAltaFolioNumero.TabIndex = 6
        labelAltaFolioNumero.Text = "Folio N°:"
        '
        'labelAltaLibroNumero
        '
        labelAltaLibroNumero.AutoSize = True
        labelAltaLibroNumero.Location = New System.Drawing.Point(8, 48)
        labelAltaLibroNumero.Name = "labelAltaLibroNumero"
        labelAltaLibroNumero.Size = New System.Drawing.Size(48, 13)
        labelAltaLibroNumero.TabIndex = 2
        labelAltaLibroNumero.Text = "Libro N°:"
        '
        'labelAltaActaNumero
        '
        labelAltaActaNumero.AutoSize = True
        labelAltaActaNumero.Location = New System.Drawing.Point(153, 48)
        labelAltaActaNumero.Name = "labelAltaActaNumero"
        labelAltaActaNumero.Size = New System.Drawing.Size(47, 13)
        labelAltaActaNumero.TabIndex = 4
        labelAltaActaNumero.Text = "Acta N°:"
        '
        'labelBajaFolioNumero
        '
        labelBajaFolioNumero.AutoSize = True
        labelBajaFolioNumero.Location = New System.Drawing.Point(297, 48)
        labelBajaFolioNumero.Name = "labelBajaFolioNumero"
        labelBajaFolioNumero.Size = New System.Drawing.Size(47, 13)
        labelBajaFolioNumero.TabIndex = 6
        labelBajaFolioNumero.Text = "Folio N°:"
        '
        'labelBajaLibroNumero
        '
        labelBajaLibroNumero.AutoSize = True
        labelBajaLibroNumero.Location = New System.Drawing.Point(8, 48)
        labelBajaLibroNumero.Name = "labelBajaLibroNumero"
        labelBajaLibroNumero.Size = New System.Drawing.Size(48, 13)
        labelBajaLibroNumero.TabIndex = 2
        labelBajaLibroNumero.Text = "Libro N°:"
        '
        'labelBajaActaNumero
        '
        labelBajaActaNumero.AutoSize = True
        labelBajaActaNumero.Location = New System.Drawing.Point(153, 48)
        labelBajaActaNumero.Name = "labelBajaActaNumero"
        labelBajaActaNumero.Size = New System.Drawing.Size(47, 13)
        labelBajaActaNumero.TabIndex = 4
        labelBajaActaNumero.Text = "Acta N°:"
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
        Me.toolstripMain.Size = New System.Drawing.Size(460, 39)
        Me.toolstripMain.TabIndex = 6
        '
        'textboxIDAltaBaja
        '
        Me.textboxIDAltaBaja.Location = New System.Drawing.Point(75, 50)
        Me.textboxIDAltaBaja.MaxLength = 10
        Me.textboxIDAltaBaja.Name = "textboxIDAltaBaja"
        Me.textboxIDAltaBaja.ReadOnly = True
        Me.textboxIDAltaBaja.Size = New System.Drawing.Size(74, 20)
        Me.textboxIDAltaBaja.TabIndex = 1
        Me.textboxIDAltaBaja.TabStop = False
        Me.textboxIDAltaBaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelIDAltaBaja
        '
        Me.labelIDAltaBaja.AutoSize = True
        Me.labelIDAltaBaja.Location = New System.Drawing.Point(20, 53)
        Me.labelIDAltaBaja.Name = "labelIDAltaBaja"
        Me.labelIDAltaBaja.Size = New System.Drawing.Size(21, 13)
        Me.labelIDAltaBaja.TabIndex = 0
        Me.labelIDAltaBaja.Text = "ID:"
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(75, 243)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(340, 47)
        Me.textboxNotas.TabIndex = 5
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(20, 246)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 4
        Me.labelNotas.Text = "Notas:"
        '
        'groupboxAlta
        '
        Me.groupboxAlta.Controls.Add(Me.textboxAltaFolioNumero)
        Me.groupboxAlta.Controls.Add(labelAltaFolioNumero)
        Me.groupboxAlta.Controls.Add(labelAltaLibroNumero)
        Me.groupboxAlta.Controls.Add(Me.textboxAltaLibroNumero)
        Me.groupboxAlta.Controls.Add(labelAltaActaNumero)
        Me.groupboxAlta.Controls.Add(Me.textboxAltaActaNumero)
        Me.groupboxAlta.Controls.Add(Me.labelAltaFecha)
        Me.groupboxAlta.Controls.Add(Me.datetimepickerAltaFecha)
        Me.groupboxAlta.Location = New System.Drawing.Point(12, 76)
        Me.groupboxAlta.Name = "groupboxAlta"
        Me.groupboxAlta.Size = New System.Drawing.Size(435, 72)
        Me.groupboxAlta.TabIndex = 2
        Me.groupboxAlta.TabStop = False
        Me.groupboxAlta.Text = "Alta:"
        '
        'textboxAltaFolioNumero
        '
        Me.textboxAltaFolioNumero.Location = New System.Drawing.Point(350, 45)
        Me.textboxAltaFolioNumero.MaxLength = 10
        Me.textboxAltaFolioNumero.Name = "textboxAltaFolioNumero"
        Me.textboxAltaFolioNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxAltaFolioNumero.TabIndex = 7
        '
        'textboxAltaLibroNumero
        '
        Me.textboxAltaLibroNumero.Location = New System.Drawing.Point(62, 45)
        Me.textboxAltaLibroNumero.MaxLength = 10
        Me.textboxAltaLibroNumero.Name = "textboxAltaLibroNumero"
        Me.textboxAltaLibroNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxAltaLibroNumero.TabIndex = 3
        '
        'textboxAltaActaNumero
        '
        Me.textboxAltaActaNumero.Location = New System.Drawing.Point(206, 45)
        Me.textboxAltaActaNumero.MaxLength = 10
        Me.textboxAltaActaNumero.Name = "textboxAltaActaNumero"
        Me.textboxAltaActaNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxAltaActaNumero.TabIndex = 5
        '
        'labelAltaFecha
        '
        Me.labelAltaFecha.AutoSize = True
        Me.labelAltaFecha.Location = New System.Drawing.Point(8, 22)
        Me.labelAltaFecha.Name = "labelAltaFecha"
        Me.labelAltaFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelAltaFecha.TabIndex = 0
        Me.labelAltaFecha.Text = "Fecha:"
        '
        'datetimepickerAltaFecha
        '
        Me.datetimepickerAltaFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerAltaFecha.Location = New System.Drawing.Point(62, 19)
        Me.datetimepickerAltaFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerAltaFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerAltaFecha.Name = "datetimepickerAltaFecha"
        Me.datetimepickerAltaFecha.Size = New System.Drawing.Size(116, 20)
        Me.datetimepickerAltaFecha.TabIndex = 1
        '
        'groupboxBaja
        '
        Me.groupboxBaja.Controls.Add(Me.textboxBajaFolioNumero)
        Me.groupboxBaja.Controls.Add(labelBajaFolioNumero)
        Me.groupboxBaja.Controls.Add(labelBajaLibroNumero)
        Me.groupboxBaja.Controls.Add(Me.textboxBajaLibroNumero)
        Me.groupboxBaja.Controls.Add(labelBajaActaNumero)
        Me.groupboxBaja.Controls.Add(Me.textboxBajaActaNumero)
        Me.groupboxBaja.Controls.Add(Me.labelBajaFecha)
        Me.groupboxBaja.Controls.Add(Me.datetimepickerBajaFecha)
        Me.groupboxBaja.Location = New System.Drawing.Point(12, 154)
        Me.groupboxBaja.Name = "groupboxBaja"
        Me.groupboxBaja.Size = New System.Drawing.Size(435, 72)
        Me.groupboxBaja.TabIndex = 3
        Me.groupboxBaja.TabStop = False
        Me.groupboxBaja.Text = "Baja:"
        '
        'textboxBajaFolioNumero
        '
        Me.textboxBajaFolioNumero.Location = New System.Drawing.Point(350, 45)
        Me.textboxBajaFolioNumero.MaxLength = 10
        Me.textboxBajaFolioNumero.Name = "textboxBajaFolioNumero"
        Me.textboxBajaFolioNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxBajaFolioNumero.TabIndex = 7
        '
        'textboxBajaLibroNumero
        '
        Me.textboxBajaLibroNumero.Location = New System.Drawing.Point(62, 45)
        Me.textboxBajaLibroNumero.MaxLength = 10
        Me.textboxBajaLibroNumero.Name = "textboxBajaLibroNumero"
        Me.textboxBajaLibroNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxBajaLibroNumero.TabIndex = 3
        '
        'textboxBajaActaNumero
        '
        Me.textboxBajaActaNumero.Location = New System.Drawing.Point(206, 45)
        Me.textboxBajaActaNumero.MaxLength = 10
        Me.textboxBajaActaNumero.Name = "textboxBajaActaNumero"
        Me.textboxBajaActaNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxBajaActaNumero.TabIndex = 5
        '
        'labelBajaFecha
        '
        Me.labelBajaFecha.AutoSize = True
        Me.labelBajaFecha.Location = New System.Drawing.Point(8, 22)
        Me.labelBajaFecha.Name = "labelBajaFecha"
        Me.labelBajaFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelBajaFecha.TabIndex = 0
        Me.labelBajaFecha.Text = "Fecha:"
        '
        'datetimepickerBajaFecha
        '
        Me.datetimepickerBajaFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerBajaFecha.Location = New System.Drawing.Point(62, 19)
        Me.datetimepickerBajaFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerBajaFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerBajaFecha.Name = "datetimepickerBajaFecha"
        Me.datetimepickerBajaFecha.ShowCheckBox = True
        Me.datetimepickerBajaFecha.Size = New System.Drawing.Size(138, 20)
        Me.datetimepickerBajaFecha.TabIndex = 1
        '
        'formPersonaAltaBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 304)
        Me.Controls.Add(Me.groupboxBaja)
        Me.Controls.Add(Me.groupboxAlta)
        Me.Controls.Add(Me.textboxNotas)
        Me.Controls.Add(Me.labelNotas)
        Me.Controls.Add(Me.labelIDAltaBaja)
        Me.Controls.Add(Me.textboxIDAltaBaja)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPersonaAltaBaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Alta-Baja de la Persona"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.groupboxAlta.ResumeLayout(False)
        Me.groupboxAlta.PerformLayout()
        Me.groupboxBaja.ResumeLayout(False)
        Me.groupboxBaja.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents textboxIDAltaBaja As System.Windows.Forms.TextBox
    Friend WithEvents labelIDAltaBaja As System.Windows.Forms.Label
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents groupboxAlta As System.Windows.Forms.GroupBox
    Friend WithEvents textboxAltaFolioNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxAltaLibroNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxAltaActaNumero As System.Windows.Forms.TextBox
    Friend WithEvents labelAltaFecha As System.Windows.Forms.Label
    Friend WithEvents datetimepickerAltaFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents groupboxBaja As System.Windows.Forms.GroupBox
    Friend WithEvents textboxBajaFolioNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxBajaLibroNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxBajaActaNumero As System.Windows.Forms.TextBox
    Friend WithEvents labelBajaFecha As System.Windows.Forms.Label
    Friend WithEvents datetimepickerBajaFecha As System.Windows.Forms.DateTimePicker
End Class
