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
        Dim labelResolucionNumero As System.Windows.Forms.Label
        Me.labelActaNumero = New System.Windows.Forms.Label()
        Me.labelLibroNumero = New System.Windows.Forms.Label()
        Me.labelFolioNumero = New System.Windows.Forms.Label()
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
        Me.radiobuttonTipoBaja = New System.Windows.Forms.RadioButton()
        Me.radiobuttonTipoAlta = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textboxResolucionNumero = New System.Windows.Forms.TextBox()
        Me.groupboxBaja = New System.Windows.Forms.GroupBox()
        Me.textboxBajaUnidadDestino = New System.Windows.Forms.TextBox()
        Me.comboboxBajaMotivo = New System.Windows.Forms.ComboBox()
        Me.labelOrdenGeneralNumero = New System.Windows.Forms.Label()
        Me.datetimepickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.textboxOrdenGeneralNumero = New System.Windows.Forms.TextBox()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.textboxFolioNumero = New System.Windows.Forms.TextBox()
        Me.textboxActaNumero = New System.Windows.Forms.TextBox()
        Me.textboxLibroNumero = New System.Windows.Forms.TextBox()
        Me.tabpageExtras = New System.Windows.Forms.TabPage()
        Me.labelIDAltaBaja = New System.Windows.Forms.Label()
        Me.textboxIDAltaBaja = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelResolucionNumero = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.groupboxBaja.SuspendLayout()
        Me.tabpageExtras.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelModificacion
        '
        labelModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(7, 168)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 7
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(7, 142)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 4
        labelCreacion.Text = "Creación:"
        '
        'labelResolucionNumero
        '
        labelResolucionNumero.AutoSize = True
        labelResolucionNumero.Location = New System.Drawing.Point(194, 85)
        labelResolucionNumero.Name = "labelResolucionNumero"
        labelResolucionNumero.Size = New System.Drawing.Size(78, 13)
        labelResolucionNumero.TabIndex = 13
        labelResolucionNumero.Text = "Resolución Nº:"
        '
        'labelActaNumero
        '
        Me.labelActaNumero.AutoSize = True
        Me.labelActaNumero.Location = New System.Drawing.Point(327, 59)
        Me.labelActaNumero.Name = "labelActaNumero"
        Me.labelActaNumero.Size = New System.Drawing.Size(47, 13)
        Me.labelActaNumero.TabIndex = 9
        Me.labelActaNumero.Text = "Acta Nº:"
        '
        'labelLibroNumero
        '
        Me.labelLibroNumero.AutoSize = True
        Me.labelLibroNumero.Location = New System.Drawing.Point(14, 59)
        Me.labelLibroNumero.Name = "labelLibroNumero"
        Me.labelLibroNumero.Size = New System.Drawing.Size(48, 13)
        Me.labelLibroNumero.TabIndex = 5
        Me.labelLibroNumero.Text = "Libro Nº:"
        '
        'labelFolioNumero
        '
        Me.labelFolioNumero.AutoSize = True
        Me.labelFolioNumero.Location = New System.Drawing.Point(194, 59)
        Me.labelFolioNumero.Name = "labelFolioNumero"
        Me.labelFolioNumero.Size = New System.Drawing.Size(47, 13)
        Me.labelFolioNumero.TabIndex = 7
        Me.labelFolioNumero.Text = "Folio Nº:"
        '
        'labelBajaMotivo
        '
        Me.labelBajaMotivo.AutoSize = True
        Me.labelBajaMotivo.Location = New System.Drawing.Point(8, 22)
        Me.labelBajaMotivo.Name = "labelBajaMotivo"
        Me.labelBajaMotivo.Size = New System.Drawing.Size(42, 13)
        Me.labelBajaMotivo.TabIndex = 0
        Me.labelBajaMotivo.Text = "Motivo:"
        '
        'labelBajaUnidadDestino
        '
        Me.labelBajaUnidadDestino.AutoSize = True
        Me.labelBajaUnidadDestino.Location = New System.Drawing.Point(8, 49)
        Me.labelBajaUnidadDestino.Name = "labelBajaUnidadDestino"
        Me.labelBajaUnidadDestino.Size = New System.Drawing.Size(83, 13)
        Me.labelBajaUnidadDestino.TabIndex = 2
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
        Me.textboxNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxNotas.Location = New System.Drawing.Point(115, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(373, 101)
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
        Me.tabcontrolMain.Size = New System.Drawing.Size(502, 220)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.radiobuttonTipoBaja)
        Me.tabpageGeneral.Controls.Add(Me.radiobuttonTipoAlta)
        Me.tabpageGeneral.Controls.Add(Me.Label1)
        Me.tabpageGeneral.Controls.Add(labelResolucionNumero)
        Me.tabpageGeneral.Controls.Add(Me.textboxResolucionNumero)
        Me.tabpageGeneral.Controls.Add(Me.groupboxBaja)
        Me.tabpageGeneral.Controls.Add(Me.labelOrdenGeneralNumero)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFecha)
        Me.tabpageGeneral.Controls.Add(Me.textboxOrdenGeneralNumero)
        Me.tabpageGeneral.Controls.Add(Me.labelFecha)
        Me.tabpageGeneral.Controls.Add(Me.textboxFolioNumero)
        Me.tabpageGeneral.Controls.Add(Me.textboxActaNumero)
        Me.tabpageGeneral.Controls.Add(Me.labelFolioNumero)
        Me.tabpageGeneral.Controls.Add(Me.labelActaNumero)
        Me.tabpageGeneral.Controls.Add(Me.labelLibroNumero)
        Me.tabpageGeneral.Controls.Add(Me.textboxLibroNumero)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(494, 191)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'radiobuttonTipoBaja
        '
        Me.radiobuttonTipoBaja.AutoSize = True
        Me.radiobuttonTipoBaja.Location = New System.Drawing.Point(163, 6)
        Me.radiobuttonTipoBaja.Name = "radiobuttonTipoBaja"
        Me.radiobuttonTipoBaja.Size = New System.Drawing.Size(46, 17)
        Me.radiobuttonTipoBaja.TabIndex = 2
        Me.radiobuttonTipoBaja.TabStop = True
        Me.radiobuttonTipoBaja.Text = "Baja"
        Me.radiobuttonTipoBaja.UseVisualStyleBackColor = True
        '
        'radiobuttonTipoAlta
        '
        Me.radiobuttonTipoAlta.AutoSize = True
        Me.radiobuttonTipoAlta.Location = New System.Drawing.Point(114, 6)
        Me.radiobuttonTipoAlta.Name = "radiobuttonTipoAlta"
        Me.radiobuttonTipoAlta.Size = New System.Drawing.Size(43, 17)
        Me.radiobuttonTipoAlta.TabIndex = 1
        Me.radiobuttonTipoAlta.TabStop = True
        Me.radiobuttonTipoAlta.Text = "Alta"
        Me.radiobuttonTipoAlta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo:"
        '
        'textboxResolucionNumero
        '
        Me.textboxResolucionNumero.Location = New System.Drawing.Point(278, 82)
        Me.textboxResolucionNumero.MaxLength = 15
        Me.textboxResolucionNumero.Name = "textboxResolucionNumero"
        Me.textboxResolucionNumero.Size = New System.Drawing.Size(116, 20)
        Me.textboxResolucionNumero.TabIndex = 14
        '
        'groupboxBaja
        '
        Me.groupboxBaja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupboxBaja.Controls.Add(Me.labelBajaUnidadDestino)
        Me.groupboxBaja.Controls.Add(Me.textboxBajaUnidadDestino)
        Me.groupboxBaja.Controls.Add(Me.comboboxBajaMotivo)
        Me.groupboxBaja.Controls.Add(Me.labelBajaMotivo)
        Me.groupboxBaja.Location = New System.Drawing.Point(6, 112)
        Me.groupboxBaja.Name = "groupboxBaja"
        Me.groupboxBaja.Size = New System.Drawing.Size(479, 73)
        Me.groupboxBaja.TabIndex = 15
        Me.groupboxBaja.TabStop = False
        Me.groupboxBaja.Text = "Baja:"
        Me.groupboxBaja.Visible = False
        '
        'textboxBajaUnidadDestino
        '
        Me.textboxBajaUnidadDestino.Location = New System.Drawing.Point(108, 46)
        Me.textboxBajaUnidadDestino.MaxLength = 50
        Me.textboxBajaUnidadDestino.Name = "textboxBajaUnidadDestino"
        Me.textboxBajaUnidadDestino.Size = New System.Drawing.Size(218, 20)
        Me.textboxBajaUnidadDestino.TabIndex = 3
        Me.textboxBajaUnidadDestino.Visible = False
        '
        'comboboxBajaMotivo
        '
        Me.comboboxBajaMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxBajaMotivo.FormattingEnabled = True
        Me.comboboxBajaMotivo.Location = New System.Drawing.Point(108, 19)
        Me.comboboxBajaMotivo.Name = "comboboxBajaMotivo"
        Me.comboboxBajaMotivo.Size = New System.Drawing.Size(362, 21)
        Me.comboboxBajaMotivo.TabIndex = 1
        '
        'labelOrdenGeneralNumero
        '
        Me.labelOrdenGeneralNumero.AutoSize = True
        Me.labelOrdenGeneralNumero.Location = New System.Drawing.Point(14, 85)
        Me.labelOrdenGeneralNumero.Name = "labelOrdenGeneralNumero"
        Me.labelOrdenGeneralNumero.Size = New System.Drawing.Size(94, 13)
        Me.labelOrdenGeneralNumero.TabIndex = 11
        Me.labelOrdenGeneralNumero.Text = "Orden General Nº:"
        '
        'datetimepickerFecha
        '
        Me.datetimepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFecha.Location = New System.Drawing.Point(114, 29)
        Me.datetimepickerFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFecha.Name = "datetimepickerFecha"
        Me.datetimepickerFecha.Size = New System.Drawing.Size(116, 20)
        Me.datetimepickerFecha.TabIndex = 4
        '
        'textboxOrdenGeneralNumero
        '
        Me.textboxOrdenGeneralNumero.Location = New System.Drawing.Point(114, 82)
        Me.textboxOrdenGeneralNumero.MaxLength = 10
        Me.textboxOrdenGeneralNumero.Name = "textboxOrdenGeneralNumero"
        Me.textboxOrdenGeneralNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxOrdenGeneralNumero.TabIndex = 12
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(14, 33)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelFecha.TabIndex = 3
        Me.labelFecha.Text = "Fecha:"
        '
        'textboxFolioNumero
        '
        Me.textboxFolioNumero.Location = New System.Drawing.Point(247, 56)
        Me.textboxFolioNumero.MaxLength = 10
        Me.textboxFolioNumero.Name = "textboxFolioNumero"
        Me.textboxFolioNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxFolioNumero.TabIndex = 8
        '
        'textboxActaNumero
        '
        Me.textboxActaNumero.Location = New System.Drawing.Point(380, 56)
        Me.textboxActaNumero.MaxLength = 10
        Me.textboxActaNumero.Name = "textboxActaNumero"
        Me.textboxActaNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxActaNumero.TabIndex = 10
        '
        'textboxLibroNumero
        '
        Me.textboxLibroNumero.Location = New System.Drawing.Point(114, 56)
        Me.textboxLibroNumero.MaxLength = 10
        Me.textboxLibroNumero.Name = "textboxLibroNumero"
        Me.textboxLibroNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxLibroNumero.TabIndex = 6
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
        Me.tabpageExtras.Size = New System.Drawing.Size(494, 191)
        Me.tabpageExtras.TabIndex = 1
        Me.tabpageExtras.Text = "Notas y auditoría"
        Me.tabpageExtras.UseVisualStyleBackColor = True
        '
        'labelIDAltaBaja
        '
        Me.labelIDAltaBaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelIDAltaBaja.AutoSize = True
        Me.labelIDAltaBaja.Location = New System.Drawing.Point(7, 116)
        Me.labelIDAltaBaja.Name = "labelIDAltaBaja"
        Me.labelIDAltaBaja.Size = New System.Drawing.Size(81, 13)
        Me.labelIDAltaBaja.TabIndex = 2
        Me.labelIDAltaBaja.Text = "ID de Alta-Baja:"
        '
        'textboxIDAltaBaja
        '
        Me.textboxIDAltaBaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxIDAltaBaja.Location = New System.Drawing.Point(115, 113)
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
        Me.textboxUsuarioModificacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(242, 165)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(246, 20)
        Me.textboxUsuarioModificacion.TabIndex = 9
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(242, 139)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(246, 20)
        Me.textboxUsuarioCreacion.TabIndex = 6
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(115, 165)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 8
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(115, 139)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 5
        '
        'formPersonaAltaBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 274)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPersonaAltaBaja"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Alta-Baja de la Persona"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
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
    Friend WithEvents textboxFolioNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxLibroNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxActaNumero As System.Windows.Forms.TextBox
    Friend WithEvents labelFecha As System.Windows.Forms.Label
    Friend WithEvents datetimepickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents groupboxBaja As System.Windows.Forms.GroupBox
    Friend WithEvents comboboxBajaMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents labelIDAltaBaja As System.Windows.Forms.Label
    Friend WithEvents textboxIDAltaBaja As System.Windows.Forms.TextBox
    Friend WithEvents textboxBajaUnidadDestino As System.Windows.Forms.TextBox
    Friend WithEvents labelBajaUnidadDestino As System.Windows.Forms.Label
    Friend WithEvents labelActaNumero As System.Windows.Forms.Label
    Friend WithEvents labelLibroNumero As System.Windows.Forms.Label
    Friend WithEvents labelFolioNumero As System.Windows.Forms.Label
    Friend WithEvents labelBajaMotivo As System.Windows.Forms.Label
    Friend WithEvents labelOrdenGeneralNumero As Label
    Friend WithEvents textboxOrdenGeneralNumero As TextBox
    Friend WithEvents textboxResolucionNumero As TextBox
    Friend WithEvents radiobuttonTipoBaja As RadioButton
    Friend WithEvents radiobuttonTipoAlta As RadioButton
    Friend WithEvents Label1 As Label
End Class
