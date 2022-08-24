<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formInventarioDetalle
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
        Dim labelCuartel As System.Windows.Forms.Label
        Dim labelSubUbicacion As System.Windows.Forms.Label
        Dim labelArea As System.Windows.Forms.Label
        Dim labelModoAdquisicion As System.Windows.Forms.Label
        Dim labelUbicacion As System.Windows.Forms.Label
        Dim labelEsActivo As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim labelFechaBaja As System.Windows.Forms.Label
        Dim labelFechaAdquisicion As System.Windows.Forms.Label
        Me.labelElemento = New System.Windows.Forms.Label()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.comboboxCuartel = New System.Windows.Forms.ComboBox()
        Me.comboboxSubUbicacion = New System.Windows.Forms.ComboBox()
        Me.comboboxArea = New System.Windows.Forms.ComboBox()
        Me.labelCodigo = New System.Windows.Forms.Label()
        Me.comboboxModoAdquisicion = New System.Windows.Forms.ComboBox()
        Me.comboboxUbicacion = New System.Windows.Forms.ComboBox()
        Me.buttonCodigoSiguiente = New System.Windows.Forms.Button()
        Me.comboboxElemento = New System.Windows.Forms.ComboBox()
        Me.tabcontrolMain = New CSBomberos.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.MaskedTextBoxCodigo = New System.Windows.Forms.MaskedTextBox()
        Me.datetimepickerFechaAdquisicion = New System.Windows.Forms.DateTimePicker()
        Me.labelDescripcionPropia = New System.Windows.Forms.Label()
        Me.textboxDescripcionPropia = New System.Windows.Forms.TextBox()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.datetimepickerFechaBaja = New System.Windows.Forms.DateTimePicker()
        Me.labelIDInventario = New System.Windows.Forms.Label()
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.textboxIDInventario = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        labelCuartel = New System.Windows.Forms.Label()
        labelSubUbicacion = New System.Windows.Forms.Label()
        labelArea = New System.Windows.Forms.Label()
        labelModoAdquisicion = New System.Windows.Forms.Label()
        labelUbicacion = New System.Windows.Forms.Label()
        labelEsActivo = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelFechaBaja = New System.Windows.Forms.Label()
        labelFechaAdquisicion = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelCuartel
        '
        labelCuartel.AutoSize = True
        labelCuartel.Location = New System.Drawing.Point(6, 9)
        labelCuartel.Name = "labelCuartel"
        labelCuartel.Size = New System.Drawing.Size(43, 13)
        labelCuartel.TabIndex = 0
        labelCuartel.Text = "Cuartel:"
        '
        'labelSubUbicacion
        '
        labelSubUbicacion.AutoSize = True
        labelSubUbicacion.Location = New System.Drawing.Point(6, 245)
        labelSubUbicacion.Name = "labelSubUbicacion"
        labelSubUbicacion.Size = New System.Drawing.Size(80, 13)
        labelSubUbicacion.TabIndex = 17
        labelSubUbicacion.Text = "Sub-Ubicación:"
        '
        'labelArea
        '
        labelArea.AutoSize = True
        labelArea.Location = New System.Drawing.Point(6, 36)
        labelArea.Name = "labelArea"
        labelArea.Size = New System.Drawing.Size(32, 13)
        labelArea.TabIndex = 2
        labelArea.Text = "Area:"
        '
        'labelModoAdquisicion
        '
        labelModoAdquisicion.AutoSize = True
        labelModoAdquisicion.Location = New System.Drawing.Point(6, 151)
        labelModoAdquisicion.Name = "labelModoAdquisicion"
        labelModoAdquisicion.Size = New System.Drawing.Size(109, 13)
        labelModoAdquisicion.TabIndex = 11
        labelModoAdquisicion.Text = "Modo de Adquisición:"
        '
        'labelUbicacion
        '
        labelUbicacion.AutoSize = True
        labelUbicacion.Location = New System.Drawing.Point(6, 218)
        labelUbicacion.Name = "labelUbicacion"
        labelUbicacion.Size = New System.Drawing.Size(58, 13)
        labelUbicacion.TabIndex = 15
        labelUbicacion.Text = "Ubicación:"
        '
        'labelEsActivo
        '
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(5, 134)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 2
        labelEsActivo.Text = "Activo:"
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 237)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 11
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 211)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 8
        labelCreacion.Text = "Creación:"
        '
        'labelFechaBaja
        '
        labelFechaBaja.AutoSize = True
        labelFechaBaja.Location = New System.Drawing.Point(6, 159)
        labelFechaBaja.Name = "labelFechaBaja"
        labelFechaBaja.Size = New System.Drawing.Size(79, 13)
        labelFechaBaja.TabIndex = 4
        labelFechaBaja.Text = "Fecha de Baja:"
        '
        'labelFechaAdquisicion
        '
        labelFechaAdquisicion.AutoSize = True
        labelFechaAdquisicion.Location = New System.Drawing.Point(6, 181)
        labelFechaAdquisicion.Name = "labelFechaAdquisicion"
        labelFechaAdquisicion.Size = New System.Drawing.Size(112, 13)
        labelFechaAdquisicion.TabIndex = 13
        labelFechaAdquisicion.Text = "Fecha de Adquisición:"
        '
        'labelElemento
        '
        Me.labelElemento.AutoSize = True
        Me.labelElemento.Location = New System.Drawing.Point(6, 89)
        Me.labelElemento.Name = "labelElemento"
        Me.labelElemento.Size = New System.Drawing.Size(54, 13)
        Me.labelElemento.TabIndex = 7
        Me.labelElemento.Text = "Elemento:"
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
        Me.toolstripMain.Size = New System.Drawing.Size(537, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'comboboxCuartel
        '
        Me.comboboxCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCuartel.FormattingEnabled = True
        Me.comboboxCuartel.Location = New System.Drawing.Point(124, 6)
        Me.comboboxCuartel.Name = "comboboxCuartel"
        Me.comboboxCuartel.Size = New System.Drawing.Size(267, 21)
        Me.comboboxCuartel.TabIndex = 1
        '
        'comboboxSubUbicacion
        '
        Me.comboboxSubUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxSubUbicacion.FormattingEnabled = True
        Me.comboboxSubUbicacion.Location = New System.Drawing.Point(124, 242)
        Me.comboboxSubUbicacion.Name = "comboboxSubUbicacion"
        Me.comboboxSubUbicacion.Size = New System.Drawing.Size(267, 21)
        Me.comboboxSubUbicacion.TabIndex = 18
        '
        'comboboxArea
        '
        Me.comboboxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxArea.FormattingEnabled = True
        Me.comboboxArea.Location = New System.Drawing.Point(124, 33)
        Me.comboboxArea.Name = "comboboxArea"
        Me.comboboxArea.Size = New System.Drawing.Size(267, 21)
        Me.comboboxArea.TabIndex = 3
        '
        'labelCodigo
        '
        Me.labelCodigo.AutoSize = True
        Me.labelCodigo.Location = New System.Drawing.Point(6, 63)
        Me.labelCodigo.Name = "labelCodigo"
        Me.labelCodigo.Size = New System.Drawing.Size(43, 13)
        Me.labelCodigo.TabIndex = 4
        Me.labelCodigo.Text = "Código:"
        '
        'comboboxModoAdquisicion
        '
        Me.comboboxModoAdquisicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxModoAdquisicion.FormattingEnabled = True
        Me.comboboxModoAdquisicion.Location = New System.Drawing.Point(124, 148)
        Me.comboboxModoAdquisicion.Name = "comboboxModoAdquisicion"
        Me.comboboxModoAdquisicion.Size = New System.Drawing.Size(267, 21)
        Me.comboboxModoAdquisicion.TabIndex = 12
        '
        'comboboxUbicacion
        '
        Me.comboboxUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxUbicacion.FormattingEnabled = True
        Me.comboboxUbicacion.Location = New System.Drawing.Point(124, 215)
        Me.comboboxUbicacion.Name = "comboboxUbicacion"
        Me.comboboxUbicacion.Size = New System.Drawing.Size(267, 21)
        Me.comboboxUbicacion.TabIndex = 16
        '
        'buttonCodigoSiguiente
        '
        Me.buttonCodigoSiguiente.Location = New System.Drawing.Point(175, 58)
        Me.buttonCodigoSiguiente.Name = "buttonCodigoSiguiente"
        Me.buttonCodigoSiguiente.Size = New System.Drawing.Size(103, 22)
        Me.buttonCodigoSiguiente.TabIndex = 6
        Me.buttonCodigoSiguiente.Text = "Obtener siguiente"
        Me.buttonCodigoSiguiente.UseVisualStyleBackColor = True
        '
        'comboboxElemento
        '
        Me.comboboxElemento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboboxElemento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxElemento.FormattingEnabled = True
        Me.comboboxElemento.Location = New System.Drawing.Point(124, 86)
        Me.comboboxElemento.Name = "comboboxElemento"
        Me.comboboxElemento.Size = New System.Drawing.Size(379, 21)
        Me.comboboxElemento.TabIndex = 8
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(517, 303)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.MaskedTextBoxCodigo)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFechaAdquisicion)
        Me.tabpageGeneral.Controls.Add(labelFechaAdquisicion)
        Me.tabpageGeneral.Controls.Add(Me.labelDescripcionPropia)
        Me.tabpageGeneral.Controls.Add(Me.textboxDescripcionPropia)
        Me.tabpageGeneral.Controls.Add(Me.comboboxCuartel)
        Me.tabpageGeneral.Controls.Add(Me.comboboxElemento)
        Me.tabpageGeneral.Controls.Add(Me.labelElemento)
        Me.tabpageGeneral.Controls.Add(Me.buttonCodigoSiguiente)
        Me.tabpageGeneral.Controls.Add(labelCuartel)
        Me.tabpageGeneral.Controls.Add(Me.comboboxUbicacion)
        Me.tabpageGeneral.Controls.Add(labelSubUbicacion)
        Me.tabpageGeneral.Controls.Add(labelUbicacion)
        Me.tabpageGeneral.Controls.Add(Me.comboboxSubUbicacion)
        Me.tabpageGeneral.Controls.Add(Me.comboboxModoAdquisicion)
        Me.tabpageGeneral.Controls.Add(labelArea)
        Me.tabpageGeneral.Controls.Add(labelModoAdquisicion)
        Me.tabpageGeneral.Controls.Add(Me.comboboxArea)
        Me.tabpageGeneral.Controls.Add(Me.labelCodigo)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(509, 274)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'MaskedTextBoxCodigo
        '
        Me.MaskedTextBoxCodigo.Location = New System.Drawing.Point(124, 60)
        Me.MaskedTextBoxCodigo.Mask = "00000"
        Me.MaskedTextBoxCodigo.Name = "MaskedTextBoxCodigo"
        Me.MaskedTextBoxCodigo.Size = New System.Drawing.Size(45, 20)
        Me.MaskedTextBoxCodigo.TabIndex = 5
        '
        'datetimepickerFechaAdquisicion
        '
        Me.datetimepickerFechaAdquisicion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaAdquisicion.Location = New System.Drawing.Point(124, 177)
        Me.datetimepickerFechaAdquisicion.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaAdquisicion.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaAdquisicion.Name = "datetimepickerFechaAdquisicion"
        Me.datetimepickerFechaAdquisicion.ShowCheckBox = True
        Me.datetimepickerFechaAdquisicion.Size = New System.Drawing.Size(138, 20)
        Me.datetimepickerFechaAdquisicion.TabIndex = 14
        '
        'labelDescripcionPropia
        '
        Me.labelDescripcionPropia.AutoSize = True
        Me.labelDescripcionPropia.Location = New System.Drawing.Point(6, 116)
        Me.labelDescripcionPropia.Name = "labelDescripcionPropia"
        Me.labelDescripcionPropia.Size = New System.Drawing.Size(98, 13)
        Me.labelDescripcionPropia.TabIndex = 9
        Me.labelDescripcionPropia.Text = "Descripción propia:"
        '
        'textboxDescripcionPropia
        '
        Me.textboxDescripcionPropia.Location = New System.Drawing.Point(124, 113)
        Me.textboxDescripcionPropia.MaxLength = 100
        Me.textboxDescripcionPropia.Name = "textboxDescripcionPropia"
        Me.textboxDescripcionPropia.Size = New System.Drawing.Size(379, 20)
        Me.textboxDescripcionPropia.TabIndex = 10
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.datetimepickerFechaBaja)
        Me.tabpageNotasAuditoria.Controls.Add(labelFechaBaja)
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelIDInventario)
        Me.tabpageNotasAuditoria.Controls.Add(Me.checkboxEsActivo)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxIDInventario)
        Me.tabpageNotasAuditoria.Controls.Add(labelEsActivo)
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(509, 274)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'datetimepickerFechaBaja
        '
        Me.datetimepickerFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaBaja.Location = New System.Drawing.Point(114, 156)
        Me.datetimepickerFechaBaja.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaBaja.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaBaja.Name = "datetimepickerFechaBaja"
        Me.datetimepickerFechaBaja.ShowCheckBox = True
        Me.datetimepickerFechaBaja.Size = New System.Drawing.Size(148, 20)
        Me.datetimepickerFechaBaja.TabIndex = 5
        '
        'labelIDInventario
        '
        Me.labelIDInventario.AutoSize = True
        Me.labelIDInventario.Location = New System.Drawing.Point(6, 185)
        Me.labelIDInventario.Name = "labelIDInventario"
        Me.labelIDInventario.Size = New System.Drawing.Size(21, 13)
        Me.labelIDInventario.TabIndex = 6
        Me.labelIDInventario.Text = "ID:"
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(114, 133)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 3
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'textboxIDInventario
        '
        Me.textboxIDInventario.Location = New System.Drawing.Point(114, 182)
        Me.textboxIDInventario.MaxLength = 10
        Me.textboxIDInventario.Name = "textboxIDInventario"
        Me.textboxIDInventario.ReadOnly = True
        Me.textboxIDInventario.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDInventario.TabIndex = 7
        Me.textboxIDInventario.TabStop = False
        Me.textboxIDInventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 234)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 13
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 208)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 10
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 234)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 12
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 208)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 9
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(114, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(386, 118)
        Me.textboxNotas.TabIndex = 1
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(4, 9)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 0
        Me.labelNotas.Text = "Notas:"
        '
        'formInventarioDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 358)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formInventarioDetalle"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle de Inventario"
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
    Friend WithEvents labelElemento As System.Windows.Forms.Label
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents comboboxCuartel As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxSubUbicacion As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxArea As System.Windows.Forms.ComboBox
    Friend WithEvents labelCodigo As System.Windows.Forms.Label
    Friend WithEvents comboboxModoAdquisicion As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxUbicacion As System.Windows.Forms.ComboBox
    Friend WithEvents buttonCodigoSiguiente As System.Windows.Forms.Button
    Friend WithEvents comboboxElemento As System.Windows.Forms.ComboBox
    Friend WithEvents tabcontrolMain As CS_Control_TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents datetimepickerFechaBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelIDInventario As System.Windows.Forms.Label
    Friend WithEvents checkboxEsActivo As System.Windows.Forms.CheckBox
    Friend WithEvents textboxIDInventario As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents labelDescripcionPropia As System.Windows.Forms.Label
    Friend WithEvents textboxDescripcionPropia As System.Windows.Forms.TextBox
    Friend WithEvents datetimepickerFechaAdquisicion As DateTimePicker
    Friend WithEvents MaskedTextBoxCodigo As MaskedTextBox
End Class
