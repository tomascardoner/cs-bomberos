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
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim labelAltaResolucionNumero As System.Windows.Forms.Label
        Dim labelBajaResolucionNumero As System.Windows.Forms.Label
        Me.labelAltaActaNumero = New System.Windows.Forms.Label()
        Me.labelAltaLibroNumero = New System.Windows.Forms.Label()
        Me.labelAltaFolioNumero = New System.Windows.Forms.Label()
        Me.labelBajaActaNumero = New System.Windows.Forms.Label()
        Me.labelBajaLibroNumero = New System.Windows.Forms.Label()
        Me.labelBajaFolioNumero = New System.Windows.Forms.Label()
        Me.labelBajaMotivo = New System.Windows.Forms.Label()
        Me.labelBajaUnidadDestino = New System.Windows.Forms.Label()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.tabcontrolMain = New CSBomberos.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.groupboxAlta = New System.Windows.Forms.GroupBox()
        Me.textboxAltaFolioNumero = New System.Windows.Forms.TextBox()
        Me.textboxAltaLibroNumero = New System.Windows.Forms.TextBox()
        Me.textboxAltaActaNumero = New System.Windows.Forms.TextBox()
        Me.labelAltaFecha = New System.Windows.Forms.Label()
        Me.datetimepickerAltaFecha = New System.Windows.Forms.DateTimePicker()
        Me.groupboxBaja = New System.Windows.Forms.GroupBox()
        Me.textboxBajaUnidadDestino = New System.Windows.Forms.TextBox()
        Me.comboboxBajaMotivo = New System.Windows.Forms.ComboBox()
        Me.textboxBajaFolioNumero = New System.Windows.Forms.TextBox()
        Me.textboxBajaLibroNumero = New System.Windows.Forms.TextBox()
        Me.textboxBajaActaNumero = New System.Windows.Forms.TextBox()
        Me.labelBajaFecha = New System.Windows.Forms.Label()
        Me.datetimepickerBajaFecha = New System.Windows.Forms.DateTimePicker()
        Me.tabpageExtras = New System.Windows.Forms.TabPage()
        Me.labelIDAltaBaja = New System.Windows.Forms.Label()
        Me.textboxIDAltaBaja = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.labelAltaOrdenGeneralNumero = New System.Windows.Forms.Label()
        Me.textboxAltaOrdenGeneralNumero = New System.Windows.Forms.TextBox()
        Me.textboxAltaResolucionNumero = New System.Windows.Forms.TextBox()
        Me.textboxBajaResolucionNumero = New System.Windows.Forms.TextBox()
        Me.labelBajaOrdenGeneralNumero = New System.Windows.Forms.Label()
        Me.textboxBajaOrdenGeneralNumero = New System.Windows.Forms.TextBox()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelAltaResolucionNumero = New System.Windows.Forms.Label()
        labelBajaResolucionNumero = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.groupboxAlta.SuspendLayout()
        Me.groupboxBaja.SuspendLayout()
        Me.tabpageExtras.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(7, 248)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 7
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(7, 222)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 4
        labelCreacion.Text = "Creación:"
        '
        'labelAltaActaNumero
        '
        Me.labelAltaActaNumero.AutoSize = True
        Me.labelAltaActaNumero.Location = New System.Drawing.Point(321, 48)
        Me.labelAltaActaNumero.Name = "labelAltaActaNumero"
        Me.labelAltaActaNumero.Size = New System.Drawing.Size(47, 13)
        Me.labelAltaActaNumero.TabIndex = 6
        Me.labelAltaActaNumero.Text = "Acta Nº:"
        '
        'labelAltaLibroNumero
        '
        Me.labelAltaLibroNumero.AutoSize = True
        Me.labelAltaLibroNumero.Location = New System.Drawing.Point(8, 48)
        Me.labelAltaLibroNumero.Name = "labelAltaLibroNumero"
        Me.labelAltaLibroNumero.Size = New System.Drawing.Size(48, 13)
        Me.labelAltaLibroNumero.TabIndex = 2
        Me.labelAltaLibroNumero.Text = "Libro Nº:"
        '
        'labelAltaFolioNumero
        '
        Me.labelAltaFolioNumero.AutoSize = True
        Me.labelAltaFolioNumero.Location = New System.Drawing.Point(188, 48)
        Me.labelAltaFolioNumero.Name = "labelAltaFolioNumero"
        Me.labelAltaFolioNumero.Size = New System.Drawing.Size(47, 13)
        Me.labelAltaFolioNumero.TabIndex = 4
        Me.labelAltaFolioNumero.Text = "Folio Nº:"
        '
        'labelBajaActaNumero
        '
        Me.labelBajaActaNumero.AutoSize = True
        Me.labelBajaActaNumero.Location = New System.Drawing.Point(321, 48)
        Me.labelBajaActaNumero.Name = "labelBajaActaNumero"
        Me.labelBajaActaNumero.Size = New System.Drawing.Size(47, 13)
        Me.labelBajaActaNumero.TabIndex = 6
        Me.labelBajaActaNumero.Text = "Acta Nº:"
        '
        'labelBajaLibroNumero
        '
        Me.labelBajaLibroNumero.AutoSize = True
        Me.labelBajaLibroNumero.Location = New System.Drawing.Point(8, 48)
        Me.labelBajaLibroNumero.Name = "labelBajaLibroNumero"
        Me.labelBajaLibroNumero.Size = New System.Drawing.Size(48, 13)
        Me.labelBajaLibroNumero.TabIndex = 2
        Me.labelBajaLibroNumero.Text = "Libro Nº:"
        '
        'labelBajaFolioNumero
        '
        Me.labelBajaFolioNumero.AutoSize = True
        Me.labelBajaFolioNumero.Location = New System.Drawing.Point(188, 48)
        Me.labelBajaFolioNumero.Name = "labelBajaFolioNumero"
        Me.labelBajaFolioNumero.Size = New System.Drawing.Size(47, 13)
        Me.labelBajaFolioNumero.TabIndex = 4
        Me.labelBajaFolioNumero.Text = "Folio Nº:"
        '
        'labelBajaMotivo
        '
        Me.labelBajaMotivo.AutoSize = True
        Me.labelBajaMotivo.Location = New System.Drawing.Point(8, 100)
        Me.labelBajaMotivo.Name = "labelBajaMotivo"
        Me.labelBajaMotivo.Size = New System.Drawing.Size(42, 13)
        Me.labelBajaMotivo.TabIndex = 12
        Me.labelBajaMotivo.Text = "Motivo:"
        '
        'labelBajaUnidadDestino
        '
        Me.labelBajaUnidadDestino.AutoSize = True
        Me.labelBajaUnidadDestino.Location = New System.Drawing.Point(8, 127)
        Me.labelBajaUnidadDestino.Name = "labelBajaUnidadDestino"
        Me.labelBajaUnidadDestino.Size = New System.Drawing.Size(83, 13)
        Me.labelBajaUnidadDestino.TabIndex = 14
        Me.labelBajaUnidadDestino.Text = "Unidad Destino:"
        Me.labelBajaUnidadDestino.Visible = False
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
        Me.toolstripMain.Size = New System.Drawing.Size(524, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(115, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(373, 181)
        Me.textboxNotas.TabIndex = 1
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(7, 9)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 0
        Me.labelNotas.Text = "Notas:"
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageExtras)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(502, 300)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.groupboxAlta)
        Me.tabpageGeneral.Controls.Add(Me.groupboxBaja)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(494, 271)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'groupboxAlta
        '
        Me.groupboxAlta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupboxAlta.Controls.Add(labelAltaResolucionNumero)
        Me.groupboxAlta.Controls.Add(Me.textboxAltaResolucionNumero)
        Me.groupboxAlta.Controls.Add(Me.labelAltaOrdenGeneralNumero)
        Me.groupboxAlta.Controls.Add(Me.textboxAltaOrdenGeneralNumero)
        Me.groupboxAlta.Controls.Add(Me.textboxAltaFolioNumero)
        Me.groupboxAlta.Controls.Add(Me.labelAltaFolioNumero)
        Me.groupboxAlta.Controls.Add(Me.labelAltaLibroNumero)
        Me.groupboxAlta.Controls.Add(Me.textboxAltaLibroNumero)
        Me.groupboxAlta.Controls.Add(Me.labelAltaActaNumero)
        Me.groupboxAlta.Controls.Add(Me.textboxAltaActaNumero)
        Me.groupboxAlta.Controls.Add(Me.labelAltaFecha)
        Me.groupboxAlta.Controls.Add(Me.datetimepickerAltaFecha)
        Me.groupboxAlta.Location = New System.Drawing.Point(6, 6)
        Me.groupboxAlta.Name = "groupboxAlta"
        Me.groupboxAlta.Size = New System.Drawing.Size(479, 100)
        Me.groupboxAlta.TabIndex = 0
        Me.groupboxAlta.TabStop = False
        Me.groupboxAlta.Text = "Alta:"
        '
        'textboxAltaFolioNumero
        '
        Me.textboxAltaFolioNumero.Location = New System.Drawing.Point(241, 45)
        Me.textboxAltaFolioNumero.MaxLength = 10
        Me.textboxAltaFolioNumero.Name = "textboxAltaFolioNumero"
        Me.textboxAltaFolioNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxAltaFolioNumero.TabIndex = 5
        '
        'textboxAltaLibroNumero
        '
        Me.textboxAltaLibroNumero.Location = New System.Drawing.Point(108, 45)
        Me.textboxAltaLibroNumero.MaxLength = 10
        Me.textboxAltaLibroNumero.Name = "textboxAltaLibroNumero"
        Me.textboxAltaLibroNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxAltaLibroNumero.TabIndex = 3
        '
        'textboxAltaActaNumero
        '
        Me.textboxAltaActaNumero.Location = New System.Drawing.Point(374, 45)
        Me.textboxAltaActaNumero.MaxLength = 10
        Me.textboxAltaActaNumero.Name = "textboxAltaActaNumero"
        Me.textboxAltaActaNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxAltaActaNumero.TabIndex = 7
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
        Me.datetimepickerAltaFecha.Location = New System.Drawing.Point(108, 18)
        Me.datetimepickerAltaFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerAltaFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerAltaFecha.Name = "datetimepickerAltaFecha"
        Me.datetimepickerAltaFecha.Size = New System.Drawing.Size(116, 20)
        Me.datetimepickerAltaFecha.TabIndex = 1
        '
        'groupboxBaja
        '
        Me.groupboxBaja.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupboxBaja.Controls.Add(labelBajaResolucionNumero)
        Me.groupboxBaja.Controls.Add(Me.textboxBajaResolucionNumero)
        Me.groupboxBaja.Controls.Add(Me.labelBajaOrdenGeneralNumero)
        Me.groupboxBaja.Controls.Add(Me.textboxBajaOrdenGeneralNumero)
        Me.groupboxBaja.Controls.Add(Me.labelBajaUnidadDestino)
        Me.groupboxBaja.Controls.Add(Me.textboxBajaUnidadDestino)
        Me.groupboxBaja.Controls.Add(Me.comboboxBajaMotivo)
        Me.groupboxBaja.Controls.Add(Me.labelBajaMotivo)
        Me.groupboxBaja.Controls.Add(Me.textboxBajaFolioNumero)
        Me.groupboxBaja.Controls.Add(Me.labelBajaFolioNumero)
        Me.groupboxBaja.Controls.Add(Me.labelBajaLibroNumero)
        Me.groupboxBaja.Controls.Add(Me.textboxBajaLibroNumero)
        Me.groupboxBaja.Controls.Add(Me.labelBajaActaNumero)
        Me.groupboxBaja.Controls.Add(Me.textboxBajaActaNumero)
        Me.groupboxBaja.Controls.Add(Me.labelBajaFecha)
        Me.groupboxBaja.Controls.Add(Me.datetimepickerBajaFecha)
        Me.groupboxBaja.Location = New System.Drawing.Point(6, 112)
        Me.groupboxBaja.Name = "groupboxBaja"
        Me.groupboxBaja.Size = New System.Drawing.Size(479, 153)
        Me.groupboxBaja.TabIndex = 1
        Me.groupboxBaja.TabStop = False
        Me.groupboxBaja.Text = "Baja:"
        '
        'textboxBajaUnidadDestino
        '
        Me.textboxBajaUnidadDestino.Location = New System.Drawing.Point(108, 124)
        Me.textboxBajaUnidadDestino.MaxLength = 50
        Me.textboxBajaUnidadDestino.Name = "textboxBajaUnidadDestino"
        Me.textboxBajaUnidadDestino.Size = New System.Drawing.Size(218, 20)
        Me.textboxBajaUnidadDestino.TabIndex = 15
        Me.textboxBajaUnidadDestino.Visible = False
        '
        'comboboxBajaMotivo
        '
        Me.comboboxBajaMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxBajaMotivo.FormattingEnabled = True
        Me.comboboxBajaMotivo.Location = New System.Drawing.Point(108, 97)
        Me.comboboxBajaMotivo.Name = "comboboxBajaMotivo"
        Me.comboboxBajaMotivo.Size = New System.Drawing.Size(362, 21)
        Me.comboboxBajaMotivo.TabIndex = 13
        '
        'textboxBajaFolioNumero
        '
        Me.textboxBajaFolioNumero.Location = New System.Drawing.Point(241, 45)
        Me.textboxBajaFolioNumero.MaxLength = 10
        Me.textboxBajaFolioNumero.Name = "textboxBajaFolioNumero"
        Me.textboxBajaFolioNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxBajaFolioNumero.TabIndex = 5
        '
        'textboxBajaLibroNumero
        '
        Me.textboxBajaLibroNumero.Location = New System.Drawing.Point(108, 45)
        Me.textboxBajaLibroNumero.MaxLength = 10
        Me.textboxBajaLibroNumero.Name = "textboxBajaLibroNumero"
        Me.textboxBajaLibroNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxBajaLibroNumero.TabIndex = 3
        '
        'textboxBajaActaNumero
        '
        Me.textboxBajaActaNumero.Location = New System.Drawing.Point(374, 45)
        Me.textboxBajaActaNumero.MaxLength = 10
        Me.textboxBajaActaNumero.Name = "textboxBajaActaNumero"
        Me.textboxBajaActaNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxBajaActaNumero.TabIndex = 7
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
        Me.datetimepickerBajaFecha.Location = New System.Drawing.Point(108, 17)
        Me.datetimepickerBajaFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerBajaFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerBajaFecha.Name = "datetimepickerBajaFecha"
        Me.datetimepickerBajaFecha.ShowCheckBox = True
        Me.datetimepickerBajaFecha.Size = New System.Drawing.Size(138, 20)
        Me.datetimepickerBajaFecha.TabIndex = 1
        '
        'tabpageExtras
        '
        Me.tabpageExtras.Controls.Add(Me.labelIDAltaBaja)
        Me.tabpageExtras.Controls.Add(Me.textboxIDAltaBaja)
        Me.tabpageExtras.Controls.Add(Me.textboxUsuarioModificacion)
        Me.tabpageExtras.Controls.Add(Me.textboxUsuarioCreacion)
        Me.tabpageExtras.Controls.Add(Me.textboxFechaHoraModificacion)
        Me.tabpageExtras.Controls.Add(Me.textboxFechaHoraCreacion)
        Me.tabpageExtras.Controls.Add(labelModificacion)
        Me.tabpageExtras.Controls.Add(labelCreacion)
        Me.tabpageExtras.Controls.Add(Me.textboxNotas)
        Me.tabpageExtras.Controls.Add(Me.labelNotas)
        Me.tabpageExtras.Location = New System.Drawing.Point(4, 25)
        Me.tabpageExtras.Name = "tabpageExtras"
        Me.tabpageExtras.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageExtras.Size = New System.Drawing.Size(494, 271)
        Me.tabpageExtras.TabIndex = 1
        Me.tabpageExtras.Text = "Notas y auditoría"
        Me.tabpageExtras.UseVisualStyleBackColor = True
        '
        'labelIDAltaBaja
        '
        Me.labelIDAltaBaja.AutoSize = True
        Me.labelIDAltaBaja.Location = New System.Drawing.Point(7, 196)
        Me.labelIDAltaBaja.Name = "labelIDAltaBaja"
        Me.labelIDAltaBaja.Size = New System.Drawing.Size(81, 13)
        Me.labelIDAltaBaja.TabIndex = 2
        Me.labelIDAltaBaja.Text = "ID de Alta-Baja:"
        '
        'textboxIDAltaBaja
        '
        Me.textboxIDAltaBaja.Location = New System.Drawing.Point(115, 193)
        Me.textboxIDAltaBaja.MaxLength = 10
        Me.textboxIDAltaBaja.Name = "textboxIDAltaBaja"
        Me.textboxIDAltaBaja.ReadOnly = True
        Me.textboxIDAltaBaja.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDAltaBaja.TabIndex = 3
        Me.textboxIDAltaBaja.TabStop = False
        Me.textboxIDAltaBaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(242, 245)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(202, 20)
        Me.textboxUsuarioModificacion.TabIndex = 9
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(242, 219)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(202, 20)
        Me.textboxUsuarioCreacion.TabIndex = 6
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(115, 245)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 8
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(115, 219)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 5
        '
        'labelAltaOrdenGeneralNumero
        '
        Me.labelAltaOrdenGeneralNumero.AutoSize = True
        Me.labelAltaOrdenGeneralNumero.Location = New System.Drawing.Point(8, 74)
        Me.labelAltaOrdenGeneralNumero.Name = "labelAltaOrdenGeneralNumero"
        Me.labelAltaOrdenGeneralNumero.Size = New System.Drawing.Size(94, 13)
        Me.labelAltaOrdenGeneralNumero.TabIndex = 8
        Me.labelAltaOrdenGeneralNumero.Text = "Orden General Nº:"
        '
        'textboxAltaOrdenGeneralNumero
        '
        Me.textboxAltaOrdenGeneralNumero.Location = New System.Drawing.Point(108, 71)
        Me.textboxAltaOrdenGeneralNumero.MaxLength = 10
        Me.textboxAltaOrdenGeneralNumero.Name = "textboxAltaOrdenGeneralNumero"
        Me.textboxAltaOrdenGeneralNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxAltaOrdenGeneralNumero.TabIndex = 9
        '
        'labelAltaResolucionNumero
        '
        labelAltaResolucionNumero.AutoSize = True
        labelAltaResolucionNumero.Location = New System.Drawing.Point(188, 74)
        labelAltaResolucionNumero.Name = "labelAltaResolucionNumero"
        labelAltaResolucionNumero.Size = New System.Drawing.Size(78, 13)
        labelAltaResolucionNumero.TabIndex = 10
        labelAltaResolucionNumero.Text = "Resolución Nº:"
        '
        'textboxAltaResolucionNumero
        '
        Me.textboxAltaResolucionNumero.Location = New System.Drawing.Point(272, 71)
        Me.textboxAltaResolucionNumero.MaxLength = 15
        Me.textboxAltaResolucionNumero.Name = "textboxAltaResolucionNumero"
        Me.textboxAltaResolucionNumero.Size = New System.Drawing.Size(116, 20)
        Me.textboxAltaResolucionNumero.TabIndex = 11
        '
        'labelBajaResolucionNumero
        '
        labelBajaResolucionNumero.AutoSize = True
        labelBajaResolucionNumero.Location = New System.Drawing.Point(188, 74)
        labelBajaResolucionNumero.Name = "labelBajaResolucionNumero"
        labelBajaResolucionNumero.Size = New System.Drawing.Size(78, 13)
        labelBajaResolucionNumero.TabIndex = 10
        labelBajaResolucionNumero.Text = "Resolución Nº:"
        '
        'textboxBajaResolucionNumero
        '
        Me.textboxBajaResolucionNumero.Location = New System.Drawing.Point(272, 71)
        Me.textboxBajaResolucionNumero.MaxLength = 15
        Me.textboxBajaResolucionNumero.Name = "textboxBajaResolucionNumero"
        Me.textboxBajaResolucionNumero.Size = New System.Drawing.Size(116, 20)
        Me.textboxBajaResolucionNumero.TabIndex = 11
        '
        'labelBajaOrdenGeneralNumero
        '
        Me.labelBajaOrdenGeneralNumero.AutoSize = True
        Me.labelBajaOrdenGeneralNumero.Location = New System.Drawing.Point(8, 74)
        Me.labelBajaOrdenGeneralNumero.Name = "labelBajaOrdenGeneralNumero"
        Me.labelBajaOrdenGeneralNumero.Size = New System.Drawing.Size(94, 13)
        Me.labelBajaOrdenGeneralNumero.TabIndex = 8
        Me.labelBajaOrdenGeneralNumero.Text = "Orden General Nº:"
        '
        'textboxBajaOrdenGeneralNumero
        '
        Me.textboxBajaOrdenGeneralNumero.Location = New System.Drawing.Point(108, 71)
        Me.textboxBajaOrdenGeneralNumero.MaxLength = 10
        Me.textboxBajaOrdenGeneralNumero.Name = "textboxBajaOrdenGeneralNumero"
        Me.textboxBajaOrdenGeneralNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxBajaOrdenGeneralNumero.TabIndex = 9
        '
        'formPersonaAltaBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 354)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPersonaAltaBaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Alta-Baja de la Persona"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.groupboxAlta.ResumeLayout(False)
        Me.groupboxAlta.PerformLayout()
        Me.groupboxBaja.ResumeLayout(False)
        Me.groupboxBaja.PerformLayout()
        Me.tabpageExtras.ResumeLayout(False)
        Me.tabpageExtras.PerformLayout()
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
    Friend WithEvents tabcontrolMain As CS_Control_TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageExtras As System.Windows.Forms.TabPage
    Friend WithEvents groupboxAlta As System.Windows.Forms.GroupBox
    Friend WithEvents textboxAltaFolioNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxAltaLibroNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxAltaActaNumero As System.Windows.Forms.TextBox
    Friend WithEvents labelAltaFecha As System.Windows.Forms.Label
    Friend WithEvents datetimepickerAltaFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents groupboxBaja As System.Windows.Forms.GroupBox
    Friend WithEvents comboboxBajaMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents textboxBajaFolioNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxBajaLibroNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxBajaActaNumero As System.Windows.Forms.TextBox
    Friend WithEvents labelBajaFecha As System.Windows.Forms.Label
    Friend WithEvents datetimepickerBajaFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents labelIDAltaBaja As System.Windows.Forms.Label
    Friend WithEvents textboxIDAltaBaja As System.Windows.Forms.TextBox
    Friend WithEvents textboxBajaUnidadDestino As System.Windows.Forms.TextBox
    Friend WithEvents labelBajaUnidadDestino As System.Windows.Forms.Label
    Friend WithEvents labelAltaActaNumero As System.Windows.Forms.Label
    Friend WithEvents labelAltaLibroNumero As System.Windows.Forms.Label
    Friend WithEvents labelAltaFolioNumero As System.Windows.Forms.Label
    Friend WithEvents labelBajaActaNumero As System.Windows.Forms.Label
    Friend WithEvents labelBajaLibroNumero As System.Windows.Forms.Label
    Friend WithEvents labelBajaFolioNumero As System.Windows.Forms.Label
    Friend WithEvents labelBajaMotivo As System.Windows.Forms.Label
    Friend WithEvents labelAltaOrdenGeneralNumero As Label
    Friend WithEvents textboxAltaOrdenGeneralNumero As TextBox
    Friend WithEvents textboxAltaResolucionNumero As TextBox
    Friend WithEvents textboxBajaResolucionNumero As TextBox
    Friend WithEvents labelBajaOrdenGeneralNumero As Label
    Friend WithEvents textboxBajaOrdenGeneralNumero As TextBox
End Class
