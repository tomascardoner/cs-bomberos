﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSiniestroV2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim labelCreacion As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Me.labelHoraSalida = New System.Windows.Forms.Label()
        Me.labelHoraFin = New System.Windows.Forms.Label()
        Me.labelHoraLlegadaUltimoCamion = New System.Windows.Forms.Label()
        Me.LabelCuartel = New System.Windows.Forms.Label()
        Me.LabelSolicitudForma = New System.Windows.Forms.Label()
        Me.LabelSolicitanteNombre = New System.Windows.Forms.Label()
        Me.LabelSolicitanteDireccion = New System.Windows.Forms.Label()
        Me.LabelSolicitanteDocumento = New System.Windows.Forms.Label()
        Me.LabelSolicitanteTelefono = New System.Windows.Forms.Label()
        Me.LabelUbicacionTipo = New System.Windows.Forms.Label()
        Me.LabelUbicacionDescripcion = New System.Windows.Forms.Label()
        Me.LabelUbicacionProvincia = New System.Windows.Forms.Label()
        Me.LabelUbicacionLocalidad = New System.Windows.Forms.Label()
        Me.LabelIncendioForestalCantidadHa = New System.Windows.Forms.Label()
        Me.LabelIncendioForestalCantidadPlanta = New System.Windows.Forms.Label()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonImprimir = New System.Windows.Forms.ToolStripButton()
        Me.comboboxSiniestroRubro = New System.Windows.Forms.ComboBox()
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.TabPageEncabezado = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanelEncabezadoMain = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelEncabezado = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelNumero = New System.Windows.Forms.Label()
        Me.ComboBoxCuartel = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanelNumero = New System.Windows.Forms.TableLayoutPanel()
        Me.maskedtextboxNumeroPrefijo = New System.Windows.Forms.MaskedTextBox()
        Me.labelNumeroSeparador = New System.Windows.Forms.Label()
        Me.maskedtextboxNumero = New System.Windows.Forms.MaskedTextBox()
        Me.buttonCodigoSiguiente = New System.Windows.Forms.Button()
        Me.datetimepickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelSiniestroRubro = New System.Windows.Forms.Label()
        Me.labelSiniestroTipo = New System.Windows.Forms.Label()
        Me.comboboxSiniestroTipo = New System.Windows.Forms.ComboBox()
        Me.labelSiniestroTipoOtro = New System.Windows.Forms.Label()
        Me.textboxSiniestroTipoOtro = New System.Windows.Forms.TextBox()
        Me.labelClave = New System.Windows.Forms.Label()
        Me.comboboxClave = New System.Windows.Forms.ComboBox()
        Me.datetimepickerHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerHoraLlegadaUltimoCamion = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanelHoraFin = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonHoraFinFinalizar = New System.Windows.Forms.Button()
        Me.datetimepickerHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.textboxPersonaFin = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanelLlamadoUbicacion = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxUbicacionLocalidad = New System.Windows.Forms.ComboBox()
        Me.ComboBoxUbicacionProvincia = New System.Windows.Forms.ComboBox()
        Me.TextBoxUbicacionDescripcion = New System.Windows.Forms.TextBox()
        Me.ComboBoxUbicacionTipo = New System.Windows.Forms.ComboBox()
        Me.TextBoxSolicitanteTelefono = New System.Windows.Forms.TextBox()
        Me.TextBoxSolicitanteDireccion = New System.Windows.Forms.TextBox()
        Me.TextBoxSolicitanteNombre = New System.Windows.Forms.TextBox()
        Me.ComboBoxSolicitudForma = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanelGeneralSolicitanteDocumento = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxSolicitanteDocumentoNumero = New System.Windows.Forms.TextBox()
        Me.ComboBoxSolicitanteDocumentoTipo = New System.Windows.Forms.ComboBox()
        Me.TabPageGeneral = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanelPieMain = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelPie = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBoxControlado = New System.Windows.Forms.CheckBox()
        Me.LabelControlado = New System.Windows.Forms.Label()
        Me.LabelRadioTelefonista = New System.Windows.Forms.Label()
        Me.LabelJefeGuardia = New System.Windows.Forms.Label()
        Me.LabelEncargadoCuartel = New System.Windows.Forms.Label()
        Me.NumericUpDownIncendioForestalSuperficieMetro = New System.Windows.Forms.NumericUpDown()
        Me.LabelIncendioForestalSuperficieMetro = New System.Windows.Forms.Label()
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie = New System.Windows.Forms.TableLayoutPanel()
        Me.NumericUpDownIncendioForestalAnchoMetro = New System.Windows.Forms.NumericUpDown()
        Me.LabelIncendioForestalAnchoMetro = New System.Windows.Forms.Label()
        Me.LabelIncendioForestalLargoMetro = New System.Windows.Forms.Label()
        Me.NumericUpDownIncendioForestalLargoMetro = New System.Windows.Forms.NumericUpDown()
        Me.LabelIncendioForestalMedida = New System.Windows.Forms.Label()
        Me.LabelTrasladoPorOtro = New System.Windows.Forms.Label()
        Me.TableLayoutPanelTrasladoPorOtro = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBoxTrasladoPorOtro = New System.Windows.Forms.CheckBox()
        Me.NumericUpDownTrasladoPorOtroCantidad = New System.Windows.Forms.NumericUpDown()
        Me.LabelIncendioForestal = New System.Windows.Forms.Label()
        Me.LabelIncendioForestalCantidad = New System.Windows.Forms.Label()
        Me.TableLayoutPanelIncendioForestalCantidad = New System.Windows.Forms.TableLayoutPanel()
        Me.NumericUpDownIncendioForestalCantidadPlanta = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownIncendioForestalCantidadHa = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanelResumenAsistencias = New System.Windows.Forms.TableLayoutPanel()
        Me.labelResumenAsistencias = New System.Windows.Forms.Label()
        Me.DataGridViewResumenAsistencias = New System.Windows.Forms.DataGridView()
        Me.columnResumenAsistenciaTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnResumenCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPageDamnificado = New System.Windows.Forms.TabPage()
        Me.DataGridViewDamnificados = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumnDamnificadosApellidoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumnDamnificadosEdad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumnDamnificadosEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStripDamnificados = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelDamnificados = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDaminificados = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonDamnificadosAgregar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonDamnificadosEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonDamnificadosBorrar = New System.Windows.Forms.ToolStripButton()
        Me.TabPageVehiculo = New System.Windows.Forms.TabPage()
        Me.DataGridViewVehiculos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumnVehiculosTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumnDataGridViewTextBoxColumnVehiculosMarca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumnVehiculosModelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumnVehiculosDominio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStripVehiculos = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelVehiculos = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripVehiculos = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonVehiculosAgregar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonVehiculosEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonVehiculosBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageAsistencias = New System.Windows.Forms.TabPage()
        Me.datagridviewAsistencias = New System.Windows.Forms.DataGridView()
        Me.columnPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnSiniestroAsistenciaTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStripAsistencias = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelAsistencias = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstripAsistencias = New System.Windows.Forms.ToolStrip()
        Me.buttonAsistenciasAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAsistenciasEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAsistenciasEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanelNotasAuditoria = New System.Windows.Forms.TableLayoutPanel()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelAnulado = New System.Windows.Forms.Label()
        Me.checkboxAnulado = New System.Windows.Forms.CheckBox()
        Me.labelIDSiniestro = New System.Windows.Forms.Label()
        Me.textboxIDSiniestro = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanelCreacion = New System.Windows.Forms.TableLayoutPanel()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanelUltimaModificacion = New System.Windows.Forms.TableLayoutPanel()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.ControlPersonaRadioTelefonista = New CSBomberos.ControlPersona()
        Me.ControlPersonaJefeGuardia = New CSBomberos.ControlPersona()
        Me.ControlPersonaEncargadoCuartel = New CSBomberos.ControlPersona()
        labelCreacion = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.TabControlMain.SuspendLayout()
        Me.TabPageEncabezado.SuspendLayout()
        Me.TableLayoutPanelEncabezadoMain.SuspendLayout()
        Me.TableLayoutPanelEncabezado.SuspendLayout()
        Me.TableLayoutPanelNumero.SuspendLayout()
        Me.TableLayoutPanelHoraFin.SuspendLayout()
        Me.TableLayoutPanelLlamadoUbicacion.SuspendLayout()
        Me.TableLayoutPanelGeneralSolicitanteDocumento.SuspendLayout()
        Me.TabPageGeneral.SuspendLayout()
        Me.TableLayoutPanelPieMain.SuspendLayout()
        Me.TableLayoutPanelPie.SuspendLayout()
        CType(Me.NumericUpDownIncendioForestalSuperficieMetro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.SuspendLayout()
        CType(Me.NumericUpDownIncendioForestalAnchoMetro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownIncendioForestalLargoMetro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelTrasladoPorOtro.SuspendLayout()
        CType(Me.NumericUpDownTrasladoPorOtroCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelIncendioForestalCantidad.SuspendLayout()
        CType(Me.NumericUpDownIncendioForestalCantidadPlanta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownIncendioForestalCantidadHa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelResumenAsistencias.SuspendLayout()
        CType(Me.DataGridViewResumenAsistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageDamnificado.SuspendLayout()
        CType(Me.DataGridViewDamnificados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStripDamnificados.SuspendLayout()
        Me.ToolStripDaminificados.SuspendLayout()
        Me.TabPageVehiculo.SuspendLayout()
        CType(Me.DataGridViewVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStripVehiculos.SuspendLayout()
        Me.ToolStripVehiculos.SuspendLayout()
        Me.tabpageAsistencias.SuspendLayout()
        CType(Me.datagridviewAsistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStripAsistencias.SuspendLayout()
        Me.toolstripAsistencias.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.TableLayoutPanelNotasAuditoria.SuspendLayout()
        Me.TableLayoutPanelCreacion.SuspendLayout()
        Me.TableLayoutPanelUltimaModificacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelHoraSalida
        '
        Me.labelHoraSalida.AutoSize = True
        Me.labelHoraSalida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelHoraSalida.Location = New System.Drawing.Point(4, 222)
        Me.labelHoraSalida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelHoraSalida.Name = "labelHoraSalida"
        Me.labelHoraSalida.Size = New System.Drawing.Size(145, 30)
        Me.labelHoraSalida.TabIndex = 14
        Me.labelHoraSalida.Text = "Hora de salida:"
        Me.labelHoraSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelHoraFin
        '
        Me.labelHoraFin.AutoSize = True
        Me.labelHoraFin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelHoraFin.Location = New System.Drawing.Point(4, 282)
        Me.labelHoraFin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelHoraFin.Name = "labelHoraFin"
        Me.labelHoraFin.Size = New System.Drawing.Size(145, 34)
        Me.labelHoraFin.TabIndex = 18
        Me.labelHoraFin.Text = "Hora de fin:"
        Me.labelHoraFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelHoraLlegadaUltimoCamion
        '
        Me.labelHoraLlegadaUltimoCamion.AutoSize = True
        Me.labelHoraLlegadaUltimoCamion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelHoraLlegadaUltimoCamion.Location = New System.Drawing.Point(4, 252)
        Me.labelHoraLlegadaUltimoCamion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelHoraLlegadaUltimoCamion.Name = "labelHoraLlegadaUltimoCamion"
        Me.labelHoraLlegadaUltimoCamion.Size = New System.Drawing.Size(145, 30)
        Me.labelHoraLlegadaUltimoCamion.TabIndex = 16
        Me.labelHoraLlegadaUltimoCamion.Text = "Llegada último camión:"
        Me.labelHoraLlegadaUltimoCamion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCuartel
        '
        Me.LabelCuartel.AutoSize = True
        Me.LabelCuartel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCuartel.Location = New System.Drawing.Point(4, 0)
        Me.LabelCuartel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCuartel.Name = "LabelCuartel"
        Me.LabelCuartel.Size = New System.Drawing.Size(145, 32)
        Me.LabelCuartel.TabIndex = 0
        Me.LabelCuartel.Text = "Cuartel:"
        Me.LabelCuartel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelSolicitudForma
        '
        Me.LabelSolicitudForma.AutoSize = True
        Me.LabelSolicitudForma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelSolicitudForma.Location = New System.Drawing.Point(4, 0)
        Me.LabelSolicitudForma.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSolicitudForma.Name = "LabelSolicitudForma"
        Me.LabelSolicitudForma.Size = New System.Drawing.Size(120, 32)
        Me.LabelSolicitudForma.TabIndex = 0
        Me.LabelSolicitudForma.Text = "Forma de llamado:"
        Me.LabelSolicitudForma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelSolicitanteNombre
        '
        Me.LabelSolicitanteNombre.AutoSize = True
        Me.LabelSolicitanteNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelSolicitanteNombre.Location = New System.Drawing.Point(4, 32)
        Me.LabelSolicitanteNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSolicitanteNombre.Name = "LabelSolicitanteNombre"
        Me.LabelSolicitanteNombre.Size = New System.Drawing.Size(120, 30)
        Me.LabelSolicitanteNombre.TabIndex = 2
        Me.LabelSolicitanteNombre.Text = "Solicitante:"
        Me.LabelSolicitanteNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelSolicitanteDireccion
        '
        Me.LabelSolicitanteDireccion.AutoSize = True
        Me.LabelSolicitanteDireccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelSolicitanteDireccion.Location = New System.Drawing.Point(4, 62)
        Me.LabelSolicitanteDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSolicitanteDireccion.Name = "LabelSolicitanteDireccion"
        Me.LabelSolicitanteDireccion.Size = New System.Drawing.Size(120, 30)
        Me.LabelSolicitanteDireccion.TabIndex = 4
        Me.LabelSolicitanteDireccion.Text = "Dirección:"
        Me.LabelSolicitanteDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelSolicitanteDocumento
        '
        Me.LabelSolicitanteDocumento.AutoSize = True
        Me.LabelSolicitanteDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelSolicitanteDocumento.Location = New System.Drawing.Point(4, 92)
        Me.LabelSolicitanteDocumento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSolicitanteDocumento.Name = "LabelSolicitanteDocumento"
        Me.LabelSolicitanteDocumento.Size = New System.Drawing.Size(120, 32)
        Me.LabelSolicitanteDocumento.TabIndex = 6
        Me.LabelSolicitanteDocumento.Text = "Documento:"
        Me.LabelSolicitanteDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelSolicitanteTelefono
        '
        Me.LabelSolicitanteTelefono.AutoSize = True
        Me.LabelSolicitanteTelefono.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelSolicitanteTelefono.Location = New System.Drawing.Point(4, 124)
        Me.LabelSolicitanteTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSolicitanteTelefono.Name = "LabelSolicitanteTelefono"
        Me.LabelSolicitanteTelefono.Size = New System.Drawing.Size(120, 30)
        Me.LabelSolicitanteTelefono.TabIndex = 8
        Me.LabelSolicitanteTelefono.Text = "Teléfono:"
        Me.LabelSolicitanteTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelUbicacionTipo
        '
        Me.LabelUbicacionTipo.AutoSize = True
        Me.LabelUbicacionTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelUbicacionTipo.Location = New System.Drawing.Point(4, 174)
        Me.LabelUbicacionTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUbicacionTipo.Name = "LabelUbicacionTipo"
        Me.LabelUbicacionTipo.Size = New System.Drawing.Size(120, 32)
        Me.LabelUbicacionTipo.TabIndex = 10
        Me.LabelUbicacionTipo.Text = "Tipo de ubicación:"
        Me.LabelUbicacionTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelUbicacionDescripcion
        '
        Me.LabelUbicacionDescripcion.AutoSize = True
        Me.LabelUbicacionDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelUbicacionDescripcion.Location = New System.Drawing.Point(4, 206)
        Me.LabelUbicacionDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUbicacionDescripcion.Name = "LabelUbicacionDescripcion"
        Me.LabelUbicacionDescripcion.Size = New System.Drawing.Size(120, 74)
        Me.LabelUbicacionDescripcion.TabIndex = 12
        Me.LabelUbicacionDescripcion.Text = "Ubicación:"
        Me.LabelUbicacionDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelUbicacionProvincia
        '
        Me.LabelUbicacionProvincia.AutoSize = True
        Me.LabelUbicacionProvincia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelUbicacionProvincia.Location = New System.Drawing.Point(4, 280)
        Me.LabelUbicacionProvincia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUbicacionProvincia.Name = "LabelUbicacionProvincia"
        Me.LabelUbicacionProvincia.Size = New System.Drawing.Size(120, 32)
        Me.LabelUbicacionProvincia.TabIndex = 14
        Me.LabelUbicacionProvincia.Text = "Provincia:"
        Me.LabelUbicacionProvincia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelUbicacionLocalidad
        '
        Me.LabelUbicacionLocalidad.AutoSize = True
        Me.LabelUbicacionLocalidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelUbicacionLocalidad.Location = New System.Drawing.Point(4, 312)
        Me.LabelUbicacionLocalidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUbicacionLocalidad.Name = "LabelUbicacionLocalidad"
        Me.LabelUbicacionLocalidad.Size = New System.Drawing.Size(120, 32)
        Me.LabelUbicacionLocalidad.TabIndex = 16
        Me.LabelUbicacionLocalidad.Text = "Localidad:"
        Me.LabelUbicacionLocalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelIncendioForestalCantidadHa
        '
        Me.LabelIncendioForestalCantidadHa.AutoSize = True
        Me.LabelIncendioForestalCantidadHa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelIncendioForestalCantidadHa.Location = New System.Drawing.Point(4, 0)
        Me.LabelIncendioForestalCantidadHa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelIncendioForestalCantidadHa.Name = "LabelIncendioForestalCantidadHa"
        Me.LabelIncendioForestalCantidadHa.Size = New System.Drawing.Size(62, 28)
        Me.LabelIncendioForestalCantidadHa.TabIndex = 22
        Me.LabelIncendioForestalCantidadHa.Text = "Has:"
        Me.LabelIncendioForestalCantidadHa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelIncendioForestalCantidadPlanta
        '
        Me.LabelIncendioForestalCantidadPlanta.AutoSize = True
        Me.LabelIncendioForestalCantidadPlanta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelIncendioForestalCantidadPlanta.Location = New System.Drawing.Point(180, 0)
        Me.LabelIncendioForestalCantidadPlanta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelIncendioForestalCantidadPlanta.Name = "LabelIncendioForestalCantidadPlanta"
        Me.LabelIncendioForestalCantidadPlanta.Size = New System.Drawing.Size(62, 28)
        Me.LabelIncendioForestalCantidadPlanta.TabIndex = 23
        Me.LabelIncendioForestalCantidadPlanta.Text = "Plantas:"
        Me.LabelIncendioForestalCantidadPlanta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelFecha.Location = New System.Drawing.Point(4, 66)
        Me.labelFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(145, 30)
        Me.labelFecha.TabIndex = 4
        Me.labelFecha.Text = "Fecha:"
        Me.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = Global.CSBomberos.My.Resources.Resources.ImageAceptar32
        Me.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(98, 36)
        Me.buttonGuardar.Text = "Guardar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.CSBomberos.My.Resources.Resources.ImageCancelar32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(102, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.CSBomberos.My.Resources.Resources.ImageEditar32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(84, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSBomberos.My.Resources.Resources.ImageCerrar32
        Me.buttonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCerrar.Name = "buttonCerrar"
        Me.buttonCerrar.Size = New System.Drawing.Size(85, 36)
        Me.buttonCerrar.Text = "Cerrar"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar, Me.buttonImprimir})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(1019, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'buttonImprimir
        '
        Me.buttonImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonImprimir.Image = Global.CSBomberos.My.Resources.Resources.ImageImprimir32
        Me.buttonImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonImprimir.Name = "buttonImprimir"
        Me.buttonImprimir.Size = New System.Drawing.Size(102, 36)
        Me.buttonImprimir.Text = "Imprimir"
        '
        'comboboxSiniestroRubro
        '
        Me.comboboxSiniestroRubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboboxSiniestroRubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxSiniestroRubro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.comboboxSiniestroRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxSiniestroRubro.FormattingEnabled = True
        Me.comboboxSiniestroRubro.Location = New System.Drawing.Point(157, 100)
        Me.comboboxSiniestroRubro.Margin = New System.Windows.Forms.Padding(4)
        Me.comboboxSiniestroRubro.Name = "comboboxSiniestroRubro"
        Me.comboboxSiniestroRubro.Size = New System.Drawing.Size(328, 24)
        Me.comboboxSiniestroRubro.TabIndex = 7
        '
        'TabControlMain
        '
        Me.TabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControlMain.Controls.Add(Me.TabPageEncabezado)
        Me.TabControlMain.Controls.Add(Me.TabPageGeneral)
        Me.TabControlMain.Controls.Add(Me.TabPageDamnificado)
        Me.TabControlMain.Controls.Add(Me.TabPageVehiculo)
        Me.TabControlMain.Controls.Add(Me.tabpageAsistencias)
        Me.TabControlMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlMain.Location = New System.Drawing.Point(0, 39)
        Me.TabControlMain.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(1019, 488)
        Me.TabControlMain.TabIndex = 0
        '
        'TabPageEncabezado
        '
        Me.TabPageEncabezado.Controls.Add(Me.TableLayoutPanelEncabezadoMain)
        Me.TabPageEncabezado.Location = New System.Drawing.Point(4, 28)
        Me.TabPageEncabezado.Name = "TabPageEncabezado"
        Me.TabPageEncabezado.Size = New System.Drawing.Size(1011, 456)
        Me.TabPageEncabezado.TabIndex = 3
        Me.TabPageEncabezado.Text = "Encabezado"
        Me.TabPageEncabezado.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelEncabezadoMain
        '
        Me.TableLayoutPanelEncabezadoMain.ColumnCount = 3
        Me.TableLayoutPanelEncabezadoMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelEncabezadoMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelEncabezadoMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelEncabezadoMain.Controls.Add(Me.TableLayoutPanelEncabezado, 0, 0)
        Me.TableLayoutPanelEncabezadoMain.Controls.Add(Me.TableLayoutPanelLlamadoUbicacion, 2, 0)
        Me.TableLayoutPanelEncabezadoMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelEncabezadoMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelEncabezadoMain.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelEncabezadoMain.Name = "TableLayoutPanelEncabezadoMain"
        Me.TableLayoutPanelEncabezadoMain.RowCount = 1
        Me.TableLayoutPanelEncabezadoMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelEncabezadoMain.Size = New System.Drawing.Size(1011, 456)
        Me.TableLayoutPanelEncabezadoMain.TabIndex = 0
        '
        'TableLayoutPanelEncabezado
        '
        Me.TableLayoutPanelEncabezado.AutoSize = True
        Me.TableLayoutPanelEncabezado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelEncabezado.ColumnCount = 2
        Me.TableLayoutPanelEncabezado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelEncabezado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.LabelNumero, 0, 1)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.ComboBoxCuartel, 1, 0)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.LabelCuartel, 0, 0)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.TableLayoutPanelNumero, 1, 1)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.labelFecha, 0, 2)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.datetimepickerFecha, 1, 2)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.labelSiniestroRubro, 0, 3)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.comboboxSiniestroRubro, 1, 3)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.labelSiniestroTipo, 0, 4)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.comboboxSiniestroTipo, 1, 4)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.labelSiniestroTipoOtro, 0, 5)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.textboxSiniestroTipoOtro, 1, 5)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.labelClave, 0, 6)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.comboboxClave, 1, 6)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.labelHoraSalida, 0, 7)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.datetimepickerHoraSalida, 1, 7)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.labelHoraLlegadaUltimoCamion, 0, 8)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.datetimepickerHoraLlegadaUltimoCamion, 1, 8)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.labelHoraFin, 0, 9)
        Me.TableLayoutPanelEncabezado.Controls.Add(Me.TableLayoutPanelHoraFin, 1, 9)
        Me.TableLayoutPanelEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelEncabezado.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelEncabezado.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanelEncabezado.Name = "TableLayoutPanelEncabezado"
        Me.TableLayoutPanelEncabezado.RowCount = 11
        Me.TableLayoutPanelEncabezado.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelEncabezado.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelEncabezado.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelEncabezado.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelEncabezado.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelEncabezado.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelEncabezado.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelEncabezado.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelEncabezado.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelEncabezado.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelEncabezado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelEncabezado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelEncabezado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelEncabezado.Size = New System.Drawing.Size(489, 450)
        Me.TableLayoutPanelEncabezado.TabIndex = 0
        '
        'LabelNumero
        '
        Me.LabelNumero.AutoSize = True
        Me.LabelNumero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelNumero.Location = New System.Drawing.Point(4, 32)
        Me.LabelNumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNumero.Name = "LabelNumero"
        Me.LabelNumero.Size = New System.Drawing.Size(145, 34)
        Me.LabelNumero.TabIndex = 2
        Me.LabelNumero.Text = "Número:"
        Me.LabelNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBoxCuartel
        '
        Me.ComboBoxCuartel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCuartel.FormattingEnabled = True
        Me.ComboBoxCuartel.Location = New System.Drawing.Point(157, 4)
        Me.ComboBoxCuartel.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxCuartel.Name = "ComboBoxCuartel"
        Me.ComboBoxCuartel.Size = New System.Drawing.Size(328, 24)
        Me.ComboBoxCuartel.TabIndex = 1
        '
        'TableLayoutPanelNumero
        '
        Me.TableLayoutPanelNumero.AutoSize = True
        Me.TableLayoutPanelNumero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelNumero.ColumnCount = 4
        Me.TableLayoutPanelNumero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelNumero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelNumero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelNumero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelNumero.Controls.Add(Me.maskedtextboxNumeroPrefijo, 0, 0)
        Me.TableLayoutPanelNumero.Controls.Add(Me.labelNumeroSeparador, 1, 0)
        Me.TableLayoutPanelNumero.Controls.Add(Me.maskedtextboxNumero, 2, 0)
        Me.TableLayoutPanelNumero.Controls.Add(Me.buttonCodigoSiguiente, 3, 0)
        Me.TableLayoutPanelNumero.Location = New System.Drawing.Point(153, 32)
        Me.TableLayoutPanelNumero.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanelNumero.Name = "TableLayoutPanelNumero"
        Me.TableLayoutPanelNumero.RowCount = 1
        Me.TableLayoutPanelNumero.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelNumero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanelNumero.Size = New System.Drawing.Size(311, 34)
        Me.TableLayoutPanelNumero.TabIndex = 3
        '
        'maskedtextboxNumeroPrefijo
        '
        Me.maskedtextboxNumeroPrefijo.HidePromptOnLeave = True
        Me.maskedtextboxNumeroPrefijo.Location = New System.Drawing.Point(4, 4)
        Me.maskedtextboxNumeroPrefijo.Margin = New System.Windows.Forms.Padding(4)
        Me.maskedtextboxNumeroPrefijo.Mask = "0000"
        Me.maskedtextboxNumeroPrefijo.Name = "maskedtextboxNumeroPrefijo"
        Me.maskedtextboxNumeroPrefijo.Size = New System.Drawing.Size(53, 22)
        Me.maskedtextboxNumeroPrefijo.TabIndex = 0
        Me.maskedtextboxNumeroPrefijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelNumeroSeparador
        '
        Me.labelNumeroSeparador.AutoSize = True
        Me.labelNumeroSeparador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelNumeroSeparador.Location = New System.Drawing.Point(65, 0)
        Me.labelNumeroSeparador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNumeroSeparador.Name = "labelNumeroSeparador"
        Me.labelNumeroSeparador.Size = New System.Drawing.Size(11, 34)
        Me.labelNumeroSeparador.TabIndex = 1
        Me.labelNumeroSeparador.Text = "-"
        Me.labelNumeroSeparador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'maskedtextboxNumero
        '
        Me.maskedtextboxNumero.HidePromptOnLeave = True
        Me.maskedtextboxNumero.Location = New System.Drawing.Point(84, 4)
        Me.maskedtextboxNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.maskedtextboxNumero.Mask = "00000000"
        Me.maskedtextboxNumero.Name = "maskedtextboxNumero"
        Me.maskedtextboxNumero.Size = New System.Drawing.Size(93, 22)
        Me.maskedtextboxNumero.TabIndex = 2
        Me.maskedtextboxNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'buttonCodigoSiguiente
        '
        Me.buttonCodigoSiguiente.AutoSize = True
        Me.buttonCodigoSiguiente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonCodigoSiguiente.Location = New System.Drawing.Point(185, 4)
        Me.buttonCodigoSiguiente.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonCodigoSiguiente.Name = "buttonCodigoSiguiente"
        Me.buttonCodigoSiguiente.Size = New System.Drawing.Size(122, 26)
        Me.buttonCodigoSiguiente.TabIndex = 3
        Me.buttonCodigoSiguiente.Text = "Obtener siguiente"
        Me.buttonCodigoSiguiente.UseVisualStyleBackColor = True
        '
        'datetimepickerFecha
        '
        Me.datetimepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFecha.Location = New System.Drawing.Point(157, 70)
        Me.datetimepickerFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.datetimepickerFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFecha.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFecha.Name = "datetimepickerFecha"
        Me.datetimepickerFecha.Size = New System.Drawing.Size(150, 22)
        Me.datetimepickerFecha.TabIndex = 5
        '
        'labelSiniestroRubro
        '
        Me.labelSiniestroRubro.AutoSize = True
        Me.labelSiniestroRubro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelSiniestroRubro.Location = New System.Drawing.Point(4, 96)
        Me.labelSiniestroRubro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelSiniestroRubro.Name = "labelSiniestroRubro"
        Me.labelSiniestroRubro.Size = New System.Drawing.Size(145, 32)
        Me.labelSiniestroRubro.TabIndex = 6
        Me.labelSiniestroRubro.Text = "Rubro:"
        Me.labelSiniestroRubro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelSiniestroTipo
        '
        Me.labelSiniestroTipo.AutoSize = True
        Me.labelSiniestroTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelSiniestroTipo.Location = New System.Drawing.Point(4, 128)
        Me.labelSiniestroTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelSiniestroTipo.Name = "labelSiniestroTipo"
        Me.labelSiniestroTipo.Size = New System.Drawing.Size(145, 32)
        Me.labelSiniestroTipo.TabIndex = 8
        Me.labelSiniestroTipo.Text = "Tipo:"
        Me.labelSiniestroTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'comboboxSiniestroTipo
        '
        Me.comboboxSiniestroTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboboxSiniestroTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxSiniestroTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.comboboxSiniestroTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxSiniestroTipo.FormattingEnabled = True
        Me.comboboxSiniestroTipo.Location = New System.Drawing.Point(157, 132)
        Me.comboboxSiniestroTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.comboboxSiniestroTipo.Name = "comboboxSiniestroTipo"
        Me.comboboxSiniestroTipo.Size = New System.Drawing.Size(328, 24)
        Me.comboboxSiniestroTipo.TabIndex = 9
        '
        'labelSiniestroTipoOtro
        '
        Me.labelSiniestroTipoOtro.AutoSize = True
        Me.labelSiniestroTipoOtro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelSiniestroTipoOtro.Location = New System.Drawing.Point(4, 160)
        Me.labelSiniestroTipoOtro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelSiniestroTipoOtro.Name = "labelSiniestroTipoOtro"
        Me.labelSiniestroTipoOtro.Size = New System.Drawing.Size(145, 30)
        Me.labelSiniestroTipoOtro.TabIndex = 10
        Me.labelSiniestroTipoOtro.Text = "Otro:"
        Me.labelSiniestroTipoOtro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.labelSiniestroTipoOtro.Visible = False
        '
        'textboxSiniestroTipoOtro
        '
        Me.textboxSiniestroTipoOtro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textboxSiniestroTipoOtro.Location = New System.Drawing.Point(157, 164)
        Me.textboxSiniestroTipoOtro.Margin = New System.Windows.Forms.Padding(4)
        Me.textboxSiniestroTipoOtro.MaxLength = 50
        Me.textboxSiniestroTipoOtro.Name = "textboxSiniestroTipoOtro"
        Me.textboxSiniestroTipoOtro.Size = New System.Drawing.Size(328, 22)
        Me.textboxSiniestroTipoOtro.TabIndex = 11
        Me.textboxSiniestroTipoOtro.Visible = False
        '
        'labelClave
        '
        Me.labelClave.AutoSize = True
        Me.labelClave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelClave.Location = New System.Drawing.Point(4, 190)
        Me.labelClave.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelClave.Name = "labelClave"
        Me.labelClave.Size = New System.Drawing.Size(145, 32)
        Me.labelClave.TabIndex = 12
        Me.labelClave.Text = "Clave:"
        Me.labelClave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'comboboxClave
        '
        Me.comboboxClave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboboxClave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxClave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxClave.FormattingEnabled = True
        Me.comboboxClave.Location = New System.Drawing.Point(157, 194)
        Me.comboboxClave.Margin = New System.Windows.Forms.Padding(4)
        Me.comboboxClave.Name = "comboboxClave"
        Me.comboboxClave.Size = New System.Drawing.Size(180, 24)
        Me.comboboxClave.TabIndex = 13
        '
        'datetimepickerHoraSalida
        '
        Me.datetimepickerHoraSalida.CustomFormat = "HH:mm"
        Me.datetimepickerHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickerHoraSalida.Location = New System.Drawing.Point(157, 226)
        Me.datetimepickerHoraSalida.Margin = New System.Windows.Forms.Padding(4)
        Me.datetimepickerHoraSalida.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerHoraSalida.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerHoraSalida.Name = "datetimepickerHoraSalida"
        Me.datetimepickerHoraSalida.ShowCheckBox = True
        Me.datetimepickerHoraSalida.Size = New System.Drawing.Size(113, 22)
        Me.datetimepickerHoraSalida.TabIndex = 15
        '
        'datetimepickerHoraLlegadaUltimoCamion
        '
        Me.datetimepickerHoraLlegadaUltimoCamion.CustomFormat = "HH:mm"
        Me.datetimepickerHoraLlegadaUltimoCamion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickerHoraLlegadaUltimoCamion.Location = New System.Drawing.Point(157, 256)
        Me.datetimepickerHoraLlegadaUltimoCamion.Margin = New System.Windows.Forms.Padding(4)
        Me.datetimepickerHoraLlegadaUltimoCamion.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerHoraLlegadaUltimoCamion.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerHoraLlegadaUltimoCamion.Name = "datetimepickerHoraLlegadaUltimoCamion"
        Me.datetimepickerHoraLlegadaUltimoCamion.ShowCheckBox = True
        Me.datetimepickerHoraLlegadaUltimoCamion.Size = New System.Drawing.Size(113, 22)
        Me.datetimepickerHoraLlegadaUltimoCamion.TabIndex = 17
        '
        'TableLayoutPanelHoraFin
        '
        Me.TableLayoutPanelHoraFin.AutoSize = True
        Me.TableLayoutPanelHoraFin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelHoraFin.ColumnCount = 3
        Me.TableLayoutPanelHoraFin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelHoraFin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelHoraFin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelHoraFin.Controls.Add(Me.buttonHoraFinFinalizar, 0, 0)
        Me.TableLayoutPanelHoraFin.Controls.Add(Me.datetimepickerHoraFin, 1, 0)
        Me.TableLayoutPanelHoraFin.Controls.Add(Me.textboxPersonaFin, 2, 0)
        Me.TableLayoutPanelHoraFin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelHoraFin.Location = New System.Drawing.Point(153, 282)
        Me.TableLayoutPanelHoraFin.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanelHoraFin.Name = "TableLayoutPanelHoraFin"
        Me.TableLayoutPanelHoraFin.RowCount = 1
        Me.TableLayoutPanelHoraFin.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelHoraFin.Size = New System.Drawing.Size(336, 34)
        Me.TableLayoutPanelHoraFin.TabIndex = 19
        '
        'buttonHoraFinFinalizar
        '
        Me.buttonHoraFinFinalizar.AutoSize = True
        Me.buttonHoraFinFinalizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonHoraFinFinalizar.Location = New System.Drawing.Point(4, 4)
        Me.buttonHoraFinFinalizar.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonHoraFinFinalizar.Name = "buttonHoraFinFinalizar"
        Me.buttonHoraFinFinalizar.Size = New System.Drawing.Size(67, 26)
        Me.buttonHoraFinFinalizar.TabIndex = 0
        Me.buttonHoraFinFinalizar.Text = "Finalizar"
        Me.buttonHoraFinFinalizar.UseVisualStyleBackColor = True
        '
        'datetimepickerHoraFin
        '
        Me.datetimepickerHoraFin.CustomFormat = "HH:mm"
        Me.datetimepickerHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickerHoraFin.Location = New System.Drawing.Point(79, 4)
        Me.datetimepickerHoraFin.Margin = New System.Windows.Forms.Padding(4)
        Me.datetimepickerHoraFin.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerHoraFin.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerHoraFin.Name = "datetimepickerHoraFin"
        Me.datetimepickerHoraFin.ShowCheckBox = True
        Me.datetimepickerHoraFin.Size = New System.Drawing.Size(113, 22)
        Me.datetimepickerHoraFin.TabIndex = 1
        '
        'textboxPersonaFin
        '
        Me.textboxPersonaFin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textboxPersonaFin.Location = New System.Drawing.Point(200, 4)
        Me.textboxPersonaFin.Margin = New System.Windows.Forms.Padding(4)
        Me.textboxPersonaFin.Name = "textboxPersonaFin"
        Me.textboxPersonaFin.ReadOnly = True
        Me.textboxPersonaFin.Size = New System.Drawing.Size(132, 22)
        Me.textboxPersonaFin.TabIndex = 2
        Me.textboxPersonaFin.TabStop = False
        '
        'TableLayoutPanelLlamadoUbicacion
        '
        Me.TableLayoutPanelLlamadoUbicacion.ColumnCount = 2
        Me.TableLayoutPanelLlamadoUbicacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelLlamadoUbicacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.ComboBoxUbicacionLocalidad, 1, 9)
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.LabelUbicacionLocalidad, 0, 9)
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.ComboBoxUbicacionProvincia, 1, 8)
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.LabelUbicacionProvincia, 0, 8)
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.TextBoxUbicacionDescripcion, 1, 7)
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.LabelUbicacionDescripcion, 0, 7)
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.ComboBoxUbicacionTipo, 1, 6)
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.LabelUbicacionTipo, 0, 6)
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.TextBoxSolicitanteTelefono, 1, 4)
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.LabelSolicitanteTelefono, 0, 4)
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.LabelSolicitanteDocumento, 0, 3)
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.TextBoxSolicitanteDireccion, 1, 2)
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.LabelSolicitanteDireccion, 0, 2)
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.TextBoxSolicitanteNombre, 1, 1)
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.LabelSolicitanteNombre, 0, 1)
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.ComboBoxSolicitudForma, 1, 0)
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.LabelSolicitudForma, 0, 0)
        Me.TableLayoutPanelLlamadoUbicacion.Controls.Add(Me.TableLayoutPanelGeneralSolicitanteDocumento, 1, 3)
        Me.TableLayoutPanelLlamadoUbicacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelLlamadoUbicacion.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelLlamadoUbicacion.Location = New System.Drawing.Point(518, 3)
        Me.TableLayoutPanelLlamadoUbicacion.Name = "TableLayoutPanelLlamadoUbicacion"
        Me.TableLayoutPanelLlamadoUbicacion.RowCount = 11
        Me.TableLayoutPanelLlamadoUbicacion.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelLlamadoUbicacion.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelLlamadoUbicacion.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelLlamadoUbicacion.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelLlamadoUbicacion.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelLlamadoUbicacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelLlamadoUbicacion.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelLlamadoUbicacion.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelLlamadoUbicacion.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelLlamadoUbicacion.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelLlamadoUbicacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelLlamadoUbicacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelLlamadoUbicacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelLlamadoUbicacion.Size = New System.Drawing.Size(490, 450)
        Me.TableLayoutPanelLlamadoUbicacion.TabIndex = 1
        '
        'ComboBoxUbicacionLocalidad
        '
        Me.ComboBoxUbicacionLocalidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxUbicacionLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUbicacionLocalidad.FormattingEnabled = True
        Me.ComboBoxUbicacionLocalidad.Location = New System.Drawing.Point(132, 316)
        Me.ComboBoxUbicacionLocalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxUbicacionLocalidad.Name = "ComboBoxUbicacionLocalidad"
        Me.ComboBoxUbicacionLocalidad.Size = New System.Drawing.Size(354, 24)
        Me.ComboBoxUbicacionLocalidad.TabIndex = 17
        '
        'ComboBoxUbicacionProvincia
        '
        Me.ComboBoxUbicacionProvincia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxUbicacionProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUbicacionProvincia.FormattingEnabled = True
        Me.ComboBoxUbicacionProvincia.Location = New System.Drawing.Point(132, 284)
        Me.ComboBoxUbicacionProvincia.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxUbicacionProvincia.Name = "ComboBoxUbicacionProvincia"
        Me.ComboBoxUbicacionProvincia.Size = New System.Drawing.Size(354, 24)
        Me.ComboBoxUbicacionProvincia.TabIndex = 15
        '
        'TextBoxUbicacionDescripcion
        '
        Me.TextBoxUbicacionDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxUbicacionDescripcion.Location = New System.Drawing.Point(132, 210)
        Me.TextBoxUbicacionDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxUbicacionDescripcion.MaxLength = 200
        Me.TextBoxUbicacionDescripcion.Multiline = True
        Me.TextBoxUbicacionDescripcion.Name = "TextBoxUbicacionDescripcion"
        Me.TextBoxUbicacionDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxUbicacionDescripcion.Size = New System.Drawing.Size(354, 66)
        Me.TextBoxUbicacionDescripcion.TabIndex = 13
        '
        'ComboBoxUbicacionTipo
        '
        Me.ComboBoxUbicacionTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxUbicacionTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxUbicacionTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxUbicacionTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUbicacionTipo.FormattingEnabled = True
        Me.ComboBoxUbicacionTipo.Location = New System.Drawing.Point(132, 178)
        Me.ComboBoxUbicacionTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxUbicacionTipo.Name = "ComboBoxUbicacionTipo"
        Me.ComboBoxUbicacionTipo.Size = New System.Drawing.Size(354, 24)
        Me.ComboBoxUbicacionTipo.TabIndex = 11
        '
        'TextBoxSolicitanteTelefono
        '
        Me.TextBoxSolicitanteTelefono.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSolicitanteTelefono.Location = New System.Drawing.Point(132, 128)
        Me.TextBoxSolicitanteTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxSolicitanteTelefono.MaxLength = 50
        Me.TextBoxSolicitanteTelefono.Name = "TextBoxSolicitanteTelefono"
        Me.TextBoxSolicitanteTelefono.Size = New System.Drawing.Size(354, 22)
        Me.TextBoxSolicitanteTelefono.TabIndex = 9
        '
        'TextBoxSolicitanteDireccion
        '
        Me.TextBoxSolicitanteDireccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSolicitanteDireccion.Location = New System.Drawing.Point(132, 66)
        Me.TextBoxSolicitanteDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxSolicitanteDireccion.MaxLength = 200
        Me.TextBoxSolicitanteDireccion.Name = "TextBoxSolicitanteDireccion"
        Me.TextBoxSolicitanteDireccion.Size = New System.Drawing.Size(354, 22)
        Me.TextBoxSolicitanteDireccion.TabIndex = 5
        '
        'TextBoxSolicitanteNombre
        '
        Me.TextBoxSolicitanteNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSolicitanteNombre.Location = New System.Drawing.Point(132, 36)
        Me.TextBoxSolicitanteNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxSolicitanteNombre.MaxLength = 100
        Me.TextBoxSolicitanteNombre.Name = "TextBoxSolicitanteNombre"
        Me.TextBoxSolicitanteNombre.Size = New System.Drawing.Size(354, 22)
        Me.TextBoxSolicitanteNombre.TabIndex = 3
        '
        'ComboBoxSolicitudForma
        '
        Me.ComboBoxSolicitudForma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxSolicitudForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSolicitudForma.FormattingEnabled = True
        Me.ComboBoxSolicitudForma.Location = New System.Drawing.Point(132, 4)
        Me.ComboBoxSolicitudForma.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxSolicitudForma.Name = "ComboBoxSolicitudForma"
        Me.ComboBoxSolicitudForma.Size = New System.Drawing.Size(354, 24)
        Me.ComboBoxSolicitudForma.TabIndex = 1
        '
        'TableLayoutPanelGeneralSolicitanteDocumento
        '
        Me.TableLayoutPanelGeneralSolicitanteDocumento.AutoSize = True
        Me.TableLayoutPanelGeneralSolicitanteDocumento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelGeneralSolicitanteDocumento.ColumnCount = 2
        Me.TableLayoutPanelGeneralSolicitanteDocumento.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelGeneralSolicitanteDocumento.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelGeneralSolicitanteDocumento.Controls.Add(Me.TextBoxSolicitanteDocumentoNumero, 1, 0)
        Me.TableLayoutPanelGeneralSolicitanteDocumento.Controls.Add(Me.ComboBoxSolicitanteDocumentoTipo, 0, 0)
        Me.TableLayoutPanelGeneralSolicitanteDocumento.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelGeneralSolicitanteDocumento.Location = New System.Drawing.Point(128, 92)
        Me.TableLayoutPanelGeneralSolicitanteDocumento.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanelGeneralSolicitanteDocumento.Name = "TableLayoutPanelGeneralSolicitanteDocumento"
        Me.TableLayoutPanelGeneralSolicitanteDocumento.RowCount = 1
        Me.TableLayoutPanelGeneralSolicitanteDocumento.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelGeneralSolicitanteDocumento.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanelGeneralSolicitanteDocumento.Size = New System.Drawing.Size(303, 32)
        Me.TableLayoutPanelGeneralSolicitanteDocumento.TabIndex = 7
        '
        'TextBoxSolicitanteDocumentoNumero
        '
        Me.TextBoxSolicitanteDocumentoNumero.Location = New System.Drawing.Point(147, 4)
        Me.TextBoxSolicitanteDocumentoNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxSolicitanteDocumentoNumero.MaxLength = 11
        Me.TextBoxSolicitanteDocumentoNumero.Name = "TextBoxSolicitanteDocumentoNumero"
        Me.TextBoxSolicitanteDocumentoNumero.Size = New System.Drawing.Size(152, 22)
        Me.TextBoxSolicitanteDocumentoNumero.TabIndex = 1
        '
        'ComboBoxSolicitanteDocumentoTipo
        '
        Me.ComboBoxSolicitanteDocumentoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSolicitanteDocumentoTipo.FormattingEnabled = True
        Me.ComboBoxSolicitanteDocumentoTipo.Location = New System.Drawing.Point(4, 4)
        Me.ComboBoxSolicitanteDocumentoTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxSolicitanteDocumentoTipo.Name = "ComboBoxSolicitanteDocumentoTipo"
        Me.ComboBoxSolicitanteDocumentoTipo.Size = New System.Drawing.Size(135, 24)
        Me.ComboBoxSolicitanteDocumentoTipo.TabIndex = 0
        '
        'TabPageGeneral
        '
        Me.TabPageGeneral.Controls.Add(Me.TableLayoutPanelPieMain)
        Me.TabPageGeneral.Location = New System.Drawing.Point(4, 28)
        Me.TabPageGeneral.Name = "TabPageGeneral"
        Me.TabPageGeneral.Size = New System.Drawing.Size(1011, 456)
        Me.TabPageGeneral.TabIndex = 5
        Me.TabPageGeneral.Text = "General"
        Me.TabPageGeneral.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelPieMain
        '
        Me.TableLayoutPanelPieMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelPieMain.ColumnCount = 3
        Me.TableLayoutPanelPieMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelPieMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelPieMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelPieMain.Controls.Add(Me.TableLayoutPanelPie, 0, 0)
        Me.TableLayoutPanelPieMain.Controls.Add(Me.TableLayoutPanelResumenAsistencias, 2, 0)
        Me.TableLayoutPanelPieMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelPieMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelPieMain.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelPieMain.Name = "TableLayoutPanelPieMain"
        Me.TableLayoutPanelPieMain.RowCount = 1
        Me.TableLayoutPanelPieMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPieMain.Size = New System.Drawing.Size(1011, 456)
        Me.TableLayoutPanelPieMain.TabIndex = 0
        '
        'TableLayoutPanelPie
        '
        Me.TableLayoutPanelPie.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelPie.ColumnCount = 2
        Me.TableLayoutPanelPie.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelPie.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPie.Controls.Add(Me.CheckBoxControlado, 1, 11)
        Me.TableLayoutPanelPie.Controls.Add(Me.LabelControlado, 0, 11)
        Me.TableLayoutPanelPie.Controls.Add(Me.ControlPersonaRadioTelefonista, 1, 9)
        Me.TableLayoutPanelPie.Controls.Add(Me.LabelRadioTelefonista, 0, 9)
        Me.TableLayoutPanelPie.Controls.Add(Me.ControlPersonaJefeGuardia, 1, 8)
        Me.TableLayoutPanelPie.Controls.Add(Me.LabelJefeGuardia, 0, 8)
        Me.TableLayoutPanelPie.Controls.Add(Me.ControlPersonaEncargadoCuartel, 1, 7)
        Me.TableLayoutPanelPie.Controls.Add(Me.LabelEncargadoCuartel, 0, 7)
        Me.TableLayoutPanelPie.Controls.Add(Me.NumericUpDownIncendioForestalSuperficieMetro, 1, 5)
        Me.TableLayoutPanelPie.Controls.Add(Me.LabelIncendioForestalSuperficieMetro, 0, 5)
        Me.TableLayoutPanelPie.Controls.Add(Me.TableLayoutPanelGeneralIncendioForestalSuperficie, 1, 4)
        Me.TableLayoutPanelPie.Controls.Add(Me.LabelIncendioForestalMedida, 0, 4)
        Me.TableLayoutPanelPie.Controls.Add(Me.LabelTrasladoPorOtro, 0, 0)
        Me.TableLayoutPanelPie.Controls.Add(Me.TableLayoutPanelTrasladoPorOtro, 1, 0)
        Me.TableLayoutPanelPie.Controls.Add(Me.LabelIncendioForestal, 0, 2)
        Me.TableLayoutPanelPie.Controls.Add(Me.LabelIncendioForestalCantidad, 0, 3)
        Me.TableLayoutPanelPie.Controls.Add(Me.TableLayoutPanelIncendioForestalCantidad, 1, 3)
        Me.TableLayoutPanelPie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelPie.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelPie.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanelPie.Name = "TableLayoutPanelPie"
        Me.TableLayoutPanelPie.RowCount = 13
        Me.TableLayoutPanelPie.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelPie.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelPie.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelPie.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelPie.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelPie.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelPie.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelPie.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelPie.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelPie.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelPie.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelPie.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelPie.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPie.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelPie.Size = New System.Drawing.Size(484, 450)
        Me.TableLayoutPanelPie.TabIndex = 0
        '
        'CheckBoxControlado
        '
        Me.CheckBoxControlado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxControlado.AutoSize = True
        Me.CheckBoxControlado.Location = New System.Drawing.Point(154, 306)
        Me.CheckBoxControlado.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxControlado.Name = "CheckBoxControlado"
        Me.CheckBoxControlado.Size = New System.Drawing.Size(18, 17)
        Me.CheckBoxControlado.TabIndex = 41
        Me.CheckBoxControlado.UseVisualStyleBackColor = True
        '
        'LabelControlado
        '
        Me.LabelControlado.AutoSize = True
        Me.LabelControlado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControlado.Location = New System.Drawing.Point(4, 302)
        Me.LabelControlado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelControlado.Name = "LabelControlado"
        Me.LabelControlado.Size = New System.Drawing.Size(142, 25)
        Me.LabelControlado.TabIndex = 40
        Me.LabelControlado.Text = "Controlado:"
        Me.LabelControlado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelRadioTelefonista
        '
        Me.LabelRadioTelefonista.AutoSize = True
        Me.LabelRadioTelefonista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelRadioTelefonista.Location = New System.Drawing.Point(4, 246)
        Me.LabelRadioTelefonista.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelRadioTelefonista.Name = "LabelRadioTelefonista"
        Me.LabelRadioTelefonista.Size = New System.Drawing.Size(142, 36)
        Me.LabelRadioTelefonista.TabIndex = 38
        Me.LabelRadioTelefonista.Text = "Radio telefonista:"
        Me.LabelRadioTelefonista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelJefeGuardia
        '
        Me.LabelJefeGuardia.AutoSize = True
        Me.LabelJefeGuardia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelJefeGuardia.Location = New System.Drawing.Point(4, 210)
        Me.LabelJefeGuardia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelJefeGuardia.Name = "LabelJefeGuardia"
        Me.LabelJefeGuardia.Size = New System.Drawing.Size(142, 36)
        Me.LabelJefeGuardia.TabIndex = 36
        Me.LabelJefeGuardia.Text = "Jefe de guardia:"
        Me.LabelJefeGuardia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelEncargadoCuartel
        '
        Me.LabelEncargadoCuartel.AutoSize = True
        Me.LabelEncargadoCuartel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelEncargadoCuartel.Location = New System.Drawing.Point(4, 174)
        Me.LabelEncargadoCuartel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelEncargadoCuartel.Name = "LabelEncargadoCuartel"
        Me.LabelEncargadoCuartel.Size = New System.Drawing.Size(142, 36)
        Me.LabelEncargadoCuartel.TabIndex = 34
        Me.LabelEncargadoCuartel.Text = "Encargado del cuartel:"
        Me.LabelEncargadoCuartel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDownIncendioForestalSuperficieMetro
        '
        Me.NumericUpDownIncendioForestalSuperficieMetro.Location = New System.Drawing.Point(153, 129)
        Me.NumericUpDownIncendioForestalSuperficieMetro.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.NumericUpDownIncendioForestalSuperficieMetro.Name = "NumericUpDownIncendioForestalSuperficieMetro"
        Me.NumericUpDownIncendioForestalSuperficieMetro.Size = New System.Drawing.Size(80, 22)
        Me.NumericUpDownIncendioForestalSuperficieMetro.TabIndex = 33
        Me.NumericUpDownIncendioForestalSuperficieMetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownIncendioForestalSuperficieMetro.ThousandsSeparator = True
        '
        'LabelIncendioForestalSuperficieMetro
        '
        Me.LabelIncendioForestalSuperficieMetro.AutoSize = True
        Me.LabelIncendioForestalSuperficieMetro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelIncendioForestalSuperficieMetro.Location = New System.Drawing.Point(4, 126)
        Me.LabelIncendioForestalSuperficieMetro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelIncendioForestalSuperficieMetro.Name = "LabelIncendioForestalSuperficieMetro"
        Me.LabelIncendioForestalSuperficieMetro.Size = New System.Drawing.Size(142, 28)
        Me.LabelIncendioForestalSuperficieMetro.TabIndex = 32
        Me.LabelIncendioForestalSuperficieMetro.Text = "Superficie (m²):"
        Me.LabelIncendioForestalSuperficieMetro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanelGeneralIncendioForestalSuperficie
        '
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.AutoSize = True
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.ColumnCount = 5
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.Controls.Add(Me.NumericUpDownIncendioForestalAnchoMetro, 4, 0)
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.Controls.Add(Me.LabelIncendioForestalAnchoMetro, 3, 0)
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.Controls.Add(Me.LabelIncendioForestalLargoMetro, 0, 0)
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.Controls.Add(Me.NumericUpDownIncendioForestalLargoMetro, 1, 0)
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.Location = New System.Drawing.Point(150, 98)
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.Name = "TableLayoutPanelGeneralIncendioForestalSuperficie"
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.RowCount = 1
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.Size = New System.Drawing.Size(332, 28)
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.TabIndex = 30
        '
        'NumericUpDownIncendioForestalAnchoMetro
        '
        Me.NumericUpDownIncendioForestalAnchoMetro.Location = New System.Drawing.Point(249, 3)
        Me.NumericUpDownIncendioForestalAnchoMetro.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.NumericUpDownIncendioForestalAnchoMetro.Name = "NumericUpDownIncendioForestalAnchoMetro"
        Me.NumericUpDownIncendioForestalAnchoMetro.Size = New System.Drawing.Size(80, 22)
        Me.NumericUpDownIncendioForestalAnchoMetro.TabIndex = 24
        Me.NumericUpDownIncendioForestalAnchoMetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownIncendioForestalAnchoMetro.ThousandsSeparator = True
        '
        'LabelIncendioForestalAnchoMetro
        '
        Me.LabelIncendioForestalAnchoMetro.AutoSize = True
        Me.LabelIncendioForestalAnchoMetro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelIncendioForestalAnchoMetro.Location = New System.Drawing.Point(180, 0)
        Me.LabelIncendioForestalAnchoMetro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelIncendioForestalAnchoMetro.Name = "LabelIncendioForestalAnchoMetro"
        Me.LabelIncendioForestalAnchoMetro.Size = New System.Drawing.Size(62, 28)
        Me.LabelIncendioForestalAnchoMetro.TabIndex = 23
        Me.LabelIncendioForestalAnchoMetro.Text = "Ancho:"
        Me.LabelIncendioForestalAnchoMetro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelIncendioForestalLargoMetro
        '
        Me.LabelIncendioForestalLargoMetro.AutoSize = True
        Me.LabelIncendioForestalLargoMetro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelIncendioForestalLargoMetro.Location = New System.Drawing.Point(4, 0)
        Me.LabelIncendioForestalLargoMetro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelIncendioForestalLargoMetro.Name = "LabelIncendioForestalLargoMetro"
        Me.LabelIncendioForestalLargoMetro.Size = New System.Drawing.Size(62, 28)
        Me.LabelIncendioForestalLargoMetro.TabIndex = 22
        Me.LabelIncendioForestalLargoMetro.Text = "Largo:"
        Me.LabelIncendioForestalLargoMetro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDownIncendioForestalLargoMetro
        '
        Me.NumericUpDownIncendioForestalLargoMetro.Location = New System.Drawing.Point(73, 3)
        Me.NumericUpDownIncendioForestalLargoMetro.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.NumericUpDownIncendioForestalLargoMetro.Name = "NumericUpDownIncendioForestalLargoMetro"
        Me.NumericUpDownIncendioForestalLargoMetro.Size = New System.Drawing.Size(80, 22)
        Me.NumericUpDownIncendioForestalLargoMetro.TabIndex = 8
        Me.NumericUpDownIncendioForestalLargoMetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownIncendioForestalLargoMetro.ThousandsSeparator = True
        '
        'LabelIncendioForestalMedida
        '
        Me.LabelIncendioForestalMedida.AutoSize = True
        Me.LabelIncendioForestalMedida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelIncendioForestalMedida.Location = New System.Drawing.Point(4, 98)
        Me.LabelIncendioForestalMedida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelIncendioForestalMedida.Name = "LabelIncendioForestalMedida"
        Me.LabelIncendioForestalMedida.Size = New System.Drawing.Size(142, 28)
        Me.LabelIncendioForestalMedida.TabIndex = 29
        Me.LabelIncendioForestalMedida.Text = "Medidas (m):"
        Me.LabelIncendioForestalMedida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelTrasladoPorOtro
        '
        Me.LabelTrasladoPorOtro.AutoSize = True
        Me.LabelTrasladoPorOtro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelTrasladoPorOtro.Location = New System.Drawing.Point(4, 0)
        Me.LabelTrasladoPorOtro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTrasladoPorOtro.Name = "LabelTrasladoPorOtro"
        Me.LabelTrasladoPorOtro.Size = New System.Drawing.Size(142, 28)
        Me.LabelTrasladoPorOtro.TabIndex = 24
        Me.LabelTrasladoPorOtro.Text = "Traslado por otro:"
        Me.LabelTrasladoPorOtro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanelTrasladoPorOtro
        '
        Me.TableLayoutPanelTrasladoPorOtro.AutoSize = True
        Me.TableLayoutPanelTrasladoPorOtro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelTrasladoPorOtro.ColumnCount = 2
        Me.TableLayoutPanelTrasladoPorOtro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelTrasladoPorOtro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelTrasladoPorOtro.Controls.Add(Me.CheckBoxTrasladoPorOtro, 0, 0)
        Me.TableLayoutPanelTrasladoPorOtro.Controls.Add(Me.NumericUpDownTrasladoPorOtroCantidad, 1, 0)
        Me.TableLayoutPanelTrasladoPorOtro.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelTrasladoPorOtro.Location = New System.Drawing.Point(150, 0)
        Me.TableLayoutPanelTrasladoPorOtro.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanelTrasladoPorOtro.Name = "TableLayoutPanelTrasladoPorOtro"
        Me.TableLayoutPanelTrasladoPorOtro.RowCount = 1
        Me.TableLayoutPanelTrasladoPorOtro.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelTrasladoPorOtro.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanelTrasladoPorOtro.Size = New System.Drawing.Size(90, 28)
        Me.TableLayoutPanelTrasladoPorOtro.TabIndex = 25
        '
        'CheckBoxTrasladoPorOtro
        '
        Me.CheckBoxTrasladoPorOtro.AutoSize = True
        Me.CheckBoxTrasladoPorOtro.Location = New System.Drawing.Point(3, 3)
        Me.CheckBoxTrasladoPorOtro.Name = "CheckBoxTrasladoPorOtro"
        Me.CheckBoxTrasladoPorOtro.Size = New System.Drawing.Size(18, 17)
        Me.CheckBoxTrasladoPorOtro.TabIndex = 7
        Me.CheckBoxTrasladoPorOtro.UseVisualStyleBackColor = True
        '
        'NumericUpDownTrasladoPorOtroCantidad
        '
        Me.NumericUpDownTrasladoPorOtroCantidad.Location = New System.Drawing.Point(27, 3)
        Me.NumericUpDownTrasladoPorOtroCantidad.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownTrasladoPorOtroCantidad.Name = "NumericUpDownTrasladoPorOtroCantidad"
        Me.NumericUpDownTrasladoPorOtroCantidad.Size = New System.Drawing.Size(60, 22)
        Me.NumericUpDownTrasladoPorOtroCantidad.TabIndex = 8
        Me.NumericUpDownTrasladoPorOtroCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownTrasladoPorOtroCantidad.Visible = False
        '
        'LabelIncendioForestal
        '
        Me.LabelIncendioForestal.AutoSize = True
        Me.LabelIncendioForestal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelIncendioForestal.Location = New System.Drawing.Point(4, 48)
        Me.LabelIncendioForestal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 6)
        Me.LabelIncendioForestal.Name = "LabelIncendioForestal"
        Me.LabelIncendioForestal.Size = New System.Drawing.Size(142, 16)
        Me.LabelIncendioForestal.TabIndex = 26
        Me.LabelIncendioForestal.Text = "Incendio forestal"
        Me.LabelIncendioForestal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelIncendioForestalCantidad
        '
        Me.LabelIncendioForestalCantidad.AutoSize = True
        Me.LabelIncendioForestalCantidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelIncendioForestalCantidad.Location = New System.Drawing.Point(4, 70)
        Me.LabelIncendioForestalCantidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelIncendioForestalCantidad.Name = "LabelIncendioForestalCantidad"
        Me.LabelIncendioForestalCantidad.Size = New System.Drawing.Size(142, 28)
        Me.LabelIncendioForestalCantidad.TabIndex = 27
        Me.LabelIncendioForestalCantidad.Text = "Cantidad:"
        Me.LabelIncendioForestalCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanelIncendioForestalCantidad
        '
        Me.TableLayoutPanelIncendioForestalCantidad.AutoSize = True
        Me.TableLayoutPanelIncendioForestalCantidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelIncendioForestalCantidad.ColumnCount = 5
        Me.TableLayoutPanelIncendioForestalCantidad.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanelIncendioForestalCantidad.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelIncendioForestalCantidad.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelIncendioForestalCantidad.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanelIncendioForestalCantidad.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelIncendioForestalCantidad.Controls.Add(Me.NumericUpDownIncendioForestalCantidadPlanta, 4, 0)
        Me.TableLayoutPanelIncendioForestalCantidad.Controls.Add(Me.LabelIncendioForestalCantidadPlanta, 3, 0)
        Me.TableLayoutPanelIncendioForestalCantidad.Controls.Add(Me.LabelIncendioForestalCantidadHa, 0, 0)
        Me.TableLayoutPanelIncendioForestalCantidad.Controls.Add(Me.NumericUpDownIncendioForestalCantidadHa, 1, 0)
        Me.TableLayoutPanelIncendioForestalCantidad.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelIncendioForestalCantidad.Location = New System.Drawing.Point(150, 70)
        Me.TableLayoutPanelIncendioForestalCantidad.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanelIncendioForestalCantidad.Name = "TableLayoutPanelIncendioForestalCantidad"
        Me.TableLayoutPanelIncendioForestalCantidad.RowCount = 1
        Me.TableLayoutPanelIncendioForestalCantidad.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelIncendioForestalCantidad.Size = New System.Drawing.Size(332, 28)
        Me.TableLayoutPanelIncendioForestalCantidad.TabIndex = 27
        '
        'NumericUpDownIncendioForestalCantidadPlanta
        '
        Me.NumericUpDownIncendioForestalCantidadPlanta.Location = New System.Drawing.Point(249, 3)
        Me.NumericUpDownIncendioForestalCantidadPlanta.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.NumericUpDownIncendioForestalCantidadPlanta.Name = "NumericUpDownIncendioForestalCantidadPlanta"
        Me.NumericUpDownIncendioForestalCantidadPlanta.Size = New System.Drawing.Size(80, 22)
        Me.NumericUpDownIncendioForestalCantidadPlanta.TabIndex = 24
        Me.NumericUpDownIncendioForestalCantidadPlanta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownIncendioForestalCantidadPlanta.ThousandsSeparator = True
        '
        'NumericUpDownIncendioForestalCantidadHa
        '
        Me.NumericUpDownIncendioForestalCantidadHa.Location = New System.Drawing.Point(73, 3)
        Me.NumericUpDownIncendioForestalCantidadHa.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.NumericUpDownIncendioForestalCantidadHa.Name = "NumericUpDownIncendioForestalCantidadHa"
        Me.NumericUpDownIncendioForestalCantidadHa.Size = New System.Drawing.Size(80, 22)
        Me.NumericUpDownIncendioForestalCantidadHa.TabIndex = 8
        Me.NumericUpDownIncendioForestalCantidadHa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownIncendioForestalCantidadHa.ThousandsSeparator = True
        '
        'TableLayoutPanelResumenAsistencias
        '
        Me.TableLayoutPanelResumenAsistencias.ColumnCount = 1
        Me.TableLayoutPanelResumenAsistencias.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelResumenAsistencias.Controls.Add(Me.labelResumenAsistencias, 0, 0)
        Me.TableLayoutPanelResumenAsistencias.Controls.Add(Me.DataGridViewResumenAsistencias, 0, 1)
        Me.TableLayoutPanelResumenAsistencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelResumenAsistencias.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelResumenAsistencias.Location = New System.Drawing.Point(523, 3)
        Me.TableLayoutPanelResumenAsistencias.Name = "TableLayoutPanelResumenAsistencias"
        Me.TableLayoutPanelResumenAsistencias.RowCount = 2
        Me.TableLayoutPanelResumenAsistencias.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelResumenAsistencias.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelResumenAsistencias.Size = New System.Drawing.Size(485, 450)
        Me.TableLayoutPanelResumenAsistencias.TabIndex = 1
        '
        'labelResumenAsistencias
        '
        Me.labelResumenAsistencias.AutoSize = True
        Me.labelResumenAsistencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelResumenAsistencias.Location = New System.Drawing.Point(4, 0)
        Me.labelResumenAsistencias.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelResumenAsistencias.Name = "labelResumenAsistencias"
        Me.labelResumenAsistencias.Size = New System.Drawing.Size(477, 16)
        Me.labelResumenAsistencias.TabIndex = 31
        Me.labelResumenAsistencias.Text = "Resumen de asistencias:"
        Me.labelResumenAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridViewResumenAsistencias
        '
        Me.DataGridViewResumenAsistencias.AllowUserToAddRows = False
        Me.DataGridViewResumenAsistencias.AllowUserToDeleteRows = False
        Me.DataGridViewResumenAsistencias.AllowUserToResizeColumns = False
        Me.DataGridViewResumenAsistencias.AllowUserToResizeRows = False
        Me.DataGridViewResumenAsistencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewResumenAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewResumenAsistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnResumenAsistenciaTipo, Me.columnResumenCantidad})
        Me.DataGridViewResumenAsistencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewResumenAsistencias.Location = New System.Drawing.Point(4, 20)
        Me.DataGridViewResumenAsistencias.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewResumenAsistencias.MultiSelect = False
        Me.DataGridViewResumenAsistencias.Name = "DataGridViewResumenAsistencias"
        Me.DataGridViewResumenAsistencias.ReadOnly = True
        Me.DataGridViewResumenAsistencias.RowHeadersVisible = False
        Me.DataGridViewResumenAsistencias.RowHeadersWidth = 51
        Me.DataGridViewResumenAsistencias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewResumenAsistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewResumenAsistencias.ShowEditingIcon = False
        Me.DataGridViewResumenAsistencias.Size = New System.Drawing.Size(477, 426)
        Me.DataGridViewResumenAsistencias.TabIndex = 28
        '
        'columnResumenAsistenciaTipo
        '
        Me.columnResumenAsistenciaTipo.DataPropertyName = "AsistenciaTipoNombre"
        Me.columnResumenAsistenciaTipo.HeaderText = "Tipo de asistencia"
        Me.columnResumenAsistenciaTipo.MinimumWidth = 6
        Me.columnResumenAsistenciaTipo.Name = "columnResumenAsistenciaTipo"
        Me.columnResumenAsistenciaTipo.ReadOnly = True
        Me.columnResumenAsistenciaTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnResumenAsistenciaTipo.Width = 112
        '
        'columnResumenCantidad
        '
        Me.columnResumenCantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.columnResumenCantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.columnResumenCantidad.HeaderText = "Cantidad"
        Me.columnResumenCantidad.MinimumWidth = 6
        Me.columnResumenCantidad.Name = "columnResumenCantidad"
        Me.columnResumenCantidad.ReadOnly = True
        Me.columnResumenCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.columnResumenCantidad.Width = 67
        '
        'TabPageDamnificado
        '
        Me.TabPageDamnificado.Controls.Add(Me.DataGridViewDamnificados)
        Me.TabPageDamnificado.Controls.Add(Me.StatusStripDamnificados)
        Me.TabPageDamnificado.Controls.Add(Me.ToolStripDaminificados)
        Me.TabPageDamnificado.Location = New System.Drawing.Point(4, 28)
        Me.TabPageDamnificado.Name = "TabPageDamnificado"
        Me.TabPageDamnificado.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDamnificado.Size = New System.Drawing.Size(1011, 456)
        Me.TabPageDamnificado.TabIndex = 4
        Me.TabPageDamnificado.Text = "Damnificados"
        Me.TabPageDamnificado.UseVisualStyleBackColor = True
        '
        'DataGridViewDamnificados
        '
        Me.DataGridViewDamnificados.AllowUserToAddRows = False
        Me.DataGridViewDamnificados.AllowUserToDeleteRows = False
        Me.DataGridViewDamnificados.AllowUserToResizeColumns = False
        Me.DataGridViewDamnificados.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.DataGridViewDamnificados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewDamnificados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewDamnificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDamnificados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumnDamnificadosApellidoNombre, Me.DataGridViewTextBoxColumnDamnificadosEdad, Me.DataGridViewTextBoxColumnDamnificadosEstado})
        Me.DataGridViewDamnificados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewDamnificados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewDamnificados.Location = New System.Drawing.Point(103, 3)
        Me.DataGridViewDamnificados.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewDamnificados.MultiSelect = False
        Me.DataGridViewDamnificados.Name = "DataGridViewDamnificados"
        Me.DataGridViewDamnificados.ReadOnly = True
        Me.DataGridViewDamnificados.RowHeadersVisible = False
        Me.DataGridViewDamnificados.RowHeadersWidth = 51
        Me.DataGridViewDamnificados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewDamnificados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewDamnificados.Size = New System.Drawing.Size(905, 428)
        Me.DataGridViewDamnificados.TabIndex = 14
        '
        'DataGridViewTextBoxColumnDamnificadosApellidoNombre
        '
        Me.DataGridViewTextBoxColumnDamnificadosApellidoNombre.DataPropertyName = "ApellidoNombre"
        Me.DataGridViewTextBoxColumnDamnificadosApellidoNombre.HeaderText = "Apellido y nombre"
        Me.DataGridViewTextBoxColumnDamnificadosApellidoNombre.MinimumWidth = 6
        Me.DataGridViewTextBoxColumnDamnificadosApellidoNombre.Name = "DataGridViewTextBoxColumnDamnificadosApellidoNombre"
        Me.DataGridViewTextBoxColumnDamnificadosApellidoNombre.ReadOnly = True
        Me.DataGridViewTextBoxColumnDamnificadosApellidoNombre.Width = 92
        '
        'DataGridViewTextBoxColumnDamnificadosEdad
        '
        Me.DataGridViewTextBoxColumnDamnificadosEdad.DataPropertyName = "Edad"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumnDamnificadosEdad.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumnDamnificadosEdad.HeaderText = "Edad"
        Me.DataGridViewTextBoxColumnDamnificadosEdad.MinimumWidth = 6
        Me.DataGridViewTextBoxColumnDamnificadosEdad.Name = "DataGridViewTextBoxColumnDamnificadosEdad"
        Me.DataGridViewTextBoxColumnDamnificadosEdad.ReadOnly = True
        Me.DataGridViewTextBoxColumnDamnificadosEdad.Width = 69
        '
        'DataGridViewTextBoxColumnDamnificadosEstado
        '
        Me.DataGridViewTextBoxColumnDamnificadosEstado.DataPropertyName = "EstadoNombre"
        Me.DataGridViewTextBoxColumnDamnificadosEstado.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumnDamnificadosEstado.MinimumWidth = 6
        Me.DataGridViewTextBoxColumnDamnificadosEstado.Name = "DataGridViewTextBoxColumnDamnificadosEstado"
        Me.DataGridViewTextBoxColumnDamnificadosEstado.ReadOnly = True
        Me.DataGridViewTextBoxColumnDamnificadosEstado.Width = 79
        '
        'StatusStripDamnificados
        '
        Me.StatusStripDamnificados.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStripDamnificados.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelDamnificados})
        Me.StatusStripDamnificados.Location = New System.Drawing.Point(103, 431)
        Me.StatusStripDamnificados.Name = "StatusStripDamnificados"
        Me.StatusStripDamnificados.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStripDamnificados.Size = New System.Drawing.Size(905, 22)
        Me.StatusStripDamnificados.SizingGrip = False
        Me.StatusStripDamnificados.TabIndex = 15
        '
        'ToolStripStatusLabelDamnificados
        '
        Me.ToolStripStatusLabelDamnificados.Name = "ToolStripStatusLabelDamnificados"
        Me.ToolStripStatusLabelDamnificados.Size = New System.Drawing.Size(885, 16)
        Me.ToolStripStatusLabelDamnificados.Spring = True
        Me.ToolStripStatusLabelDamnificados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripDaminificados
        '
        Me.ToolStripDaminificados.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStripDaminificados.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripDaminificados.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripDaminificados.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonDamnificadosAgregar, Me.ToolStripButtonDamnificadosEditar, Me.ToolStripButtonDamnificadosBorrar})
        Me.ToolStripDaminificados.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStripDaminificados.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripDaminificados.Name = "ToolStripDaminificados"
        Me.ToolStripDaminificados.Size = New System.Drawing.Size(100, 450)
        Me.ToolStripDaminificados.TabIndex = 13
        '
        'ToolStripButtonDamnificadosAgregar
        '
        Me.ToolStripButtonDamnificadosAgregar.Image = Global.CSBomberos.My.Resources.Resources.ImageAgregar32
        Me.ToolStripButtonDamnificadosAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButtonDamnificadosAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonDamnificadosAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDamnificadosAgregar.Name = "ToolStripButtonDamnificadosAgregar"
        Me.ToolStripButtonDamnificadosAgregar.Size = New System.Drawing.Size(97, 36)
        Me.ToolStripButtonDamnificadosAgregar.Text = "Agregar"
        '
        'ToolStripButtonDamnificadosEditar
        '
        Me.ToolStripButtonDamnificadosEditar.Image = Global.CSBomberos.My.Resources.Resources.ImageEditar32
        Me.ToolStripButtonDamnificadosEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButtonDamnificadosEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonDamnificadosEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDamnificadosEditar.Name = "ToolStripButtonDamnificadosEditar"
        Me.ToolStripButtonDamnificadosEditar.Size = New System.Drawing.Size(97, 36)
        Me.ToolStripButtonDamnificadosEditar.Text = "Editar"
        '
        'ToolStripButtonDamnificadosBorrar
        '
        Me.ToolStripButtonDamnificadosBorrar.Image = Global.CSBomberos.My.Resources.Resources.ImageBorrar32
        Me.ToolStripButtonDamnificadosBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButtonDamnificadosBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonDamnificadosBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDamnificadosBorrar.Name = "ToolStripButtonDamnificadosBorrar"
        Me.ToolStripButtonDamnificadosBorrar.Size = New System.Drawing.Size(97, 36)
        Me.ToolStripButtonDamnificadosBorrar.Text = "Eliminar"
        '
        'TabPageVehiculo
        '
        Me.TabPageVehiculo.Controls.Add(Me.DataGridViewVehiculos)
        Me.TabPageVehiculo.Controls.Add(Me.StatusStripVehiculos)
        Me.TabPageVehiculo.Controls.Add(Me.ToolStripVehiculos)
        Me.TabPageVehiculo.Location = New System.Drawing.Point(4, 28)
        Me.TabPageVehiculo.Name = "TabPageVehiculo"
        Me.TabPageVehiculo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageVehiculo.Size = New System.Drawing.Size(1011, 456)
        Me.TabPageVehiculo.TabIndex = 6
        Me.TabPageVehiculo.Text = "Vehículos"
        Me.TabPageVehiculo.UseVisualStyleBackColor = True
        '
        'DataGridViewVehiculos
        '
        Me.DataGridViewVehiculos.AllowUserToAddRows = False
        Me.DataGridViewVehiculos.AllowUserToDeleteRows = False
        Me.DataGridViewVehiculos.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.DataGridViewVehiculos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVehiculos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumnVehiculosTipo, Me.DataGridViewTextBoxColumnDataGridViewTextBoxColumnVehiculosMarca, Me.DataGridViewTextBoxColumnVehiculosModelo, Me.DataGridViewTextBoxColumnVehiculosDominio})
        Me.DataGridViewVehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewVehiculos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewVehiculos.Location = New System.Drawing.Point(103, 3)
        Me.DataGridViewVehiculos.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewVehiculos.MultiSelect = False
        Me.DataGridViewVehiculos.Name = "DataGridViewVehiculos"
        Me.DataGridViewVehiculos.ReadOnly = True
        Me.DataGridViewVehiculos.RowHeadersVisible = False
        Me.DataGridViewVehiculos.RowHeadersWidth = 51
        Me.DataGridViewVehiculos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVehiculos.Size = New System.Drawing.Size(905, 428)
        Me.DataGridViewVehiculos.TabIndex = 15
        '
        'DataGridViewTextBoxColumnVehiculosTipo
        '
        Me.DataGridViewTextBoxColumnVehiculosTipo.DataPropertyName = "TipoNombre"
        Me.DataGridViewTextBoxColumnVehiculosTipo.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumnVehiculosTipo.MinimumWidth = 6
        Me.DataGridViewTextBoxColumnVehiculosTipo.Name = "DataGridViewTextBoxColumnVehiculosTipo"
        Me.DataGridViewTextBoxColumnVehiculosTipo.ReadOnly = True
        Me.DataGridViewTextBoxColumnVehiculosTipo.Width = 64
        '
        'DataGridViewTextBoxColumnDataGridViewTextBoxColumnVehiculosMarca
        '
        Me.DataGridViewTextBoxColumnDataGridViewTextBoxColumnVehiculosMarca.DataPropertyName = "MarcaNombre"
        Me.DataGridViewTextBoxColumnDataGridViewTextBoxColumnVehiculosMarca.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumnDataGridViewTextBoxColumnVehiculosMarca.MinimumWidth = 6
        Me.DataGridViewTextBoxColumnDataGridViewTextBoxColumnVehiculosMarca.Name = "DataGridViewTextBoxColumnDataGridViewTextBoxColumnVehiculosMarca"
        Me.DataGridViewTextBoxColumnDataGridViewTextBoxColumnVehiculosMarca.ReadOnly = True
        Me.DataGridViewTextBoxColumnDataGridViewTextBoxColumnVehiculosMarca.Width = 74
        '
        'DataGridViewTextBoxColumnVehiculosModelo
        '
        Me.DataGridViewTextBoxColumnVehiculosModelo.DataPropertyName = "Modelo"
        Me.DataGridViewTextBoxColumnVehiculosModelo.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumnVehiculosModelo.MinimumWidth = 6
        Me.DataGridViewTextBoxColumnVehiculosModelo.Name = "DataGridViewTextBoxColumnVehiculosModelo"
        Me.DataGridViewTextBoxColumnVehiculosModelo.ReadOnly = True
        Me.DataGridViewTextBoxColumnVehiculosModelo.Width = 82
        '
        'DataGridViewTextBoxColumnVehiculosDominio
        '
        Me.DataGridViewTextBoxColumnVehiculosDominio.DataPropertyName = "Dominio"
        Me.DataGridViewTextBoxColumnVehiculosDominio.HeaderText = "Dominio"
        Me.DataGridViewTextBoxColumnVehiculosDominio.MinimumWidth = 6
        Me.DataGridViewTextBoxColumnVehiculosDominio.Name = "DataGridViewTextBoxColumnVehiculosDominio"
        Me.DataGridViewTextBoxColumnVehiculosDominio.ReadOnly = True
        Me.DataGridViewTextBoxColumnVehiculosDominio.Width = 86
        '
        'StatusStripVehiculos
        '
        Me.StatusStripVehiculos.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStripVehiculos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelVehiculos})
        Me.StatusStripVehiculos.Location = New System.Drawing.Point(103, 431)
        Me.StatusStripVehiculos.Name = "StatusStripVehiculos"
        Me.StatusStripVehiculos.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStripVehiculos.Size = New System.Drawing.Size(905, 22)
        Me.StatusStripVehiculos.SizingGrip = False
        Me.StatusStripVehiculos.TabIndex = 16
        '
        'ToolStripStatusLabelVehiculos
        '
        Me.ToolStripStatusLabelVehiculos.Name = "ToolStripStatusLabelVehiculos"
        Me.ToolStripStatusLabelVehiculos.Size = New System.Drawing.Size(885, 16)
        Me.ToolStripStatusLabelVehiculos.Spring = True
        Me.ToolStripStatusLabelVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripVehiculos
        '
        Me.ToolStripVehiculos.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStripVehiculos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripVehiculos.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripVehiculos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonVehiculosAgregar, Me.ToolStripButtonVehiculosEditar, Me.ToolStripButtonVehiculosBorrar})
        Me.ToolStripVehiculos.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStripVehiculos.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripVehiculos.Name = "ToolStripVehiculos"
        Me.ToolStripVehiculos.Size = New System.Drawing.Size(100, 450)
        Me.ToolStripVehiculos.TabIndex = 14
        '
        'ToolStripButtonVehiculosAgregar
        '
        Me.ToolStripButtonVehiculosAgregar.Image = Global.CSBomberos.My.Resources.Resources.ImageAgregar32
        Me.ToolStripButtonVehiculosAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButtonVehiculosAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonVehiculosAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonVehiculosAgregar.Name = "ToolStripButtonVehiculosAgregar"
        Me.ToolStripButtonVehiculosAgregar.Size = New System.Drawing.Size(97, 36)
        Me.ToolStripButtonVehiculosAgregar.Text = "Agregar"
        '
        'ToolStripButtonVehiculosEditar
        '
        Me.ToolStripButtonVehiculosEditar.Image = Global.CSBomberos.My.Resources.Resources.ImageEditar32
        Me.ToolStripButtonVehiculosEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButtonVehiculosEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonVehiculosEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonVehiculosEditar.Name = "ToolStripButtonVehiculosEditar"
        Me.ToolStripButtonVehiculosEditar.Size = New System.Drawing.Size(97, 36)
        Me.ToolStripButtonVehiculosEditar.Text = "Editar"
        '
        'ToolStripButtonVehiculosBorrar
        '
        Me.ToolStripButtonVehiculosBorrar.Image = Global.CSBomberos.My.Resources.Resources.ImageBorrar32
        Me.ToolStripButtonVehiculosBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButtonVehiculosBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonVehiculosBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonVehiculosBorrar.Name = "ToolStripButtonVehiculosBorrar"
        Me.ToolStripButtonVehiculosBorrar.Size = New System.Drawing.Size(97, 36)
        Me.ToolStripButtonVehiculosBorrar.Text = "Eliminar"
        '
        'tabpageAsistencias
        '
        Me.tabpageAsistencias.Controls.Add(Me.datagridviewAsistencias)
        Me.tabpageAsistencias.Controls.Add(Me.StatusStripAsistencias)
        Me.tabpageAsistencias.Controls.Add(Me.toolstripAsistencias)
        Me.tabpageAsistencias.Location = New System.Drawing.Point(4, 28)
        Me.tabpageAsistencias.Name = "tabpageAsistencias"
        Me.tabpageAsistencias.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageAsistencias.Size = New System.Drawing.Size(1011, 456)
        Me.tabpageAsistencias.TabIndex = 2
        Me.tabpageAsistencias.Text = "Asistencias"
        Me.tabpageAsistencias.UseVisualStyleBackColor = True
        '
        'datagridviewAsistencias
        '
        Me.datagridviewAsistencias.AllowUserToAddRows = False
        Me.datagridviewAsistencias.AllowUserToDeleteRows = False
        Me.datagridviewAsistencias.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewAsistencias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datagridviewAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewAsistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnPersona, Me.columnSiniestroAsistenciaTipo})
        Me.datagridviewAsistencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewAsistencias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewAsistencias.Location = New System.Drawing.Point(103, 3)
        Me.datagridviewAsistencias.Margin = New System.Windows.Forms.Padding(4)
        Me.datagridviewAsistencias.MultiSelect = False
        Me.datagridviewAsistencias.Name = "datagridviewAsistencias"
        Me.datagridviewAsistencias.ReadOnly = True
        Me.datagridviewAsistencias.RowHeadersVisible = False
        Me.datagridviewAsistencias.RowHeadersWidth = 51
        Me.datagridviewAsistencias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewAsistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewAsistencias.Size = New System.Drawing.Size(905, 428)
        Me.datagridviewAsistencias.TabIndex = 8
        '
        'columnPersona
        '
        Me.columnPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnPersona.DataPropertyName = "ApellidoNombre"
        Me.columnPersona.HeaderText = "Persona"
        Me.columnPersona.MinimumWidth = 6
        Me.columnPersona.Name = "columnPersona"
        Me.columnPersona.ReadOnly = True
        Me.columnPersona.Width = 87
        '
        'columnSiniestroAsistenciaTipo
        '
        Me.columnSiniestroAsistenciaTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnSiniestroAsistenciaTipo.DataPropertyName = "SiniestroAsistenciaTipoNombre"
        Me.columnSiniestroAsistenciaTipo.HeaderText = "Asistencia"
        Me.columnSiniestroAsistenciaTipo.MinimumWidth = 6
        Me.columnSiniestroAsistenciaTipo.Name = "columnSiniestroAsistenciaTipo"
        Me.columnSiniestroAsistenciaTipo.ReadOnly = True
        Me.columnSiniestroAsistenciaTipo.Width = 98
        '
        'StatusStripAsistencias
        '
        Me.StatusStripAsistencias.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStripAsistencias.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelAsistencias})
        Me.StatusStripAsistencias.Location = New System.Drawing.Point(103, 431)
        Me.StatusStripAsistencias.Name = "StatusStripAsistencias"
        Me.StatusStripAsistencias.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStripAsistencias.Size = New System.Drawing.Size(905, 22)
        Me.StatusStripAsistencias.SizingGrip = False
        Me.StatusStripAsistencias.TabIndex = 10
        '
        'ToolStripStatusLabelAsistencias
        '
        Me.ToolStripStatusLabelAsistencias.Name = "ToolStripStatusLabelAsistencias"
        Me.ToolStripStatusLabelAsistencias.Size = New System.Drawing.Size(885, 16)
        Me.ToolStripStatusLabelAsistencias.Spring = True
        Me.ToolStripStatusLabelAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'toolstripAsistencias
        '
        Me.toolstripAsistencias.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripAsistencias.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripAsistencias.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripAsistencias.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAsistenciasAgregar, Me.buttonAsistenciasEditar, Me.buttonAsistenciasEliminar})
        Me.toolstripAsistencias.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripAsistencias.Location = New System.Drawing.Point(3, 3)
        Me.toolstripAsistencias.Name = "toolstripAsistencias"
        Me.toolstripAsistencias.Size = New System.Drawing.Size(100, 450)
        Me.toolstripAsistencias.TabIndex = 9
        '
        'buttonAsistenciasAgregar
        '
        Me.buttonAsistenciasAgregar.Image = Global.CSBomberos.My.Resources.Resources.ImageAgregar32
        Me.buttonAsistenciasAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAsistenciasAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAsistenciasAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAsistenciasAgregar.Name = "buttonAsistenciasAgregar"
        Me.buttonAsistenciasAgregar.Size = New System.Drawing.Size(97, 36)
        Me.buttonAsistenciasAgregar.Text = "Agregar"
        '
        'buttonAsistenciasEditar
        '
        Me.buttonAsistenciasEditar.Image = Global.CSBomberos.My.Resources.Resources.ImageEditar32
        Me.buttonAsistenciasEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAsistenciasEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAsistenciasEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAsistenciasEditar.Name = "buttonAsistenciasEditar"
        Me.buttonAsistenciasEditar.Size = New System.Drawing.Size(97, 36)
        Me.buttonAsistenciasEditar.Text = "Editar"
        '
        'buttonAsistenciasEliminar
        '
        Me.buttonAsistenciasEliminar.Image = Global.CSBomberos.My.Resources.Resources.ImageBorrar32
        Me.buttonAsistenciasEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonAsistenciasEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAsistenciasEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAsistenciasEliminar.Name = "buttonAsistenciasEliminar"
        Me.buttonAsistenciasEliminar.Size = New System.Drawing.Size(97, 36)
        Me.buttonAsistenciasEliminar.Text = "Eliminar"
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.TableLayoutPanelNotasAuditoria)
        Me.tabpageNotasAuditoria.Location = New System.Drawing.Point(4, 28)
        Me.tabpageNotasAuditoria.Margin = New System.Windows.Forms.Padding(4)
        Me.tabpageNotasAuditoria.Name = "tabpageNotasAuditoria"
        Me.tabpageNotasAuditoria.Padding = New System.Windows.Forms.Padding(4)
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(1011, 456)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelNotasAuditoria
        '
        Me.TableLayoutPanelNotasAuditoria.AutoSize = True
        Me.TableLayoutPanelNotasAuditoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelNotasAuditoria.ColumnCount = 2
        Me.TableLayoutPanelNotasAuditoria.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelNotasAuditoria.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNotasAuditoria.Controls.Add(Me.TableLayoutPanelUltimaModificacion, 1, 4)
        Me.TableLayoutPanelNotasAuditoria.Controls.Add(labelModificacion, 0, 4)
        Me.TableLayoutPanelNotasAuditoria.Controls.Add(labelCreacion, 0, 3)
        Me.TableLayoutPanelNotasAuditoria.Controls.Add(Me.textboxIDSiniestro, 1, 2)
        Me.TableLayoutPanelNotasAuditoria.Controls.Add(Me.labelIDSiniestro, 0, 2)
        Me.TableLayoutPanelNotasAuditoria.Controls.Add(Me.checkboxAnulado, 1, 1)
        Me.TableLayoutPanelNotasAuditoria.Controls.Add(Me.labelAnulado, 0, 1)
        Me.TableLayoutPanelNotasAuditoria.Controls.Add(Me.textboxNotas, 1, 0)
        Me.TableLayoutPanelNotasAuditoria.Controls.Add(Me.labelNotas, 0, 0)
        Me.TableLayoutPanelNotasAuditoria.Controls.Add(Me.TableLayoutPanelCreacion, 1, 3)
        Me.TableLayoutPanelNotasAuditoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelNotasAuditoria.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelNotasAuditoria.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanelNotasAuditoria.Name = "TableLayoutPanelNotasAuditoria"
        Me.TableLayoutPanelNotasAuditoria.RowCount = 5
        Me.TableLayoutPanelNotasAuditoria.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelNotasAuditoria.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelNotasAuditoria.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelNotasAuditoria.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelNotasAuditoria.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelNotasAuditoria.Size = New System.Drawing.Size(1003, 448)
        Me.TableLayoutPanelNotasAuditoria.TabIndex = 12
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelNotas.Location = New System.Drawing.Point(4, 0)
        Me.labelNotas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(127, 333)
        Me.labelNotas.TabIndex = 1
        Me.labelNotas.Text = "Notas:"
        '
        'textboxNotas
        '
        Me.textboxNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxNotas.Location = New System.Drawing.Point(139, 4)
        Me.textboxNotas.Margin = New System.Windows.Forms.Padding(4)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(860, 325)
        Me.textboxNotas.TabIndex = 2
        '
        'labelAnulado
        '
        Me.labelAnulado.AutoSize = True
        Me.labelAnulado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelAnulado.Location = New System.Drawing.Point(4, 333)
        Me.labelAnulado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelAnulado.Name = "labelAnulado"
        Me.labelAnulado.Size = New System.Drawing.Size(127, 25)
        Me.labelAnulado.TabIndex = 3
        Me.labelAnulado.Text = "Anulado:"
        Me.labelAnulado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'checkboxAnulado
        '
        Me.checkboxAnulado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.checkboxAnulado.AutoSize = True
        Me.checkboxAnulado.Location = New System.Drawing.Point(139, 337)
        Me.checkboxAnulado.Margin = New System.Windows.Forms.Padding(4)
        Me.checkboxAnulado.Name = "checkboxAnulado"
        Me.checkboxAnulado.Size = New System.Drawing.Size(18, 17)
        Me.checkboxAnulado.TabIndex = 4
        Me.checkboxAnulado.UseVisualStyleBackColor = True
        '
        'labelIDSiniestro
        '
        Me.labelIDSiniestro.AutoSize = True
        Me.labelIDSiniestro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelIDSiniestro.Location = New System.Drawing.Point(4, 358)
        Me.labelIDSiniestro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelIDSiniestro.Name = "labelIDSiniestro"
        Me.labelIDSiniestro.Size = New System.Drawing.Size(127, 30)
        Me.labelIDSiniestro.TabIndex = 5
        Me.labelIDSiniestro.Text = "ID:"
        Me.labelIDSiniestro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textboxIDSiniestro
        '
        Me.textboxIDSiniestro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxIDSiniestro.Location = New System.Drawing.Point(139, 362)
        Me.textboxIDSiniestro.Margin = New System.Windows.Forms.Padding(4)
        Me.textboxIDSiniestro.MaxLength = 10
        Me.textboxIDSiniestro.Name = "textboxIDSiniestro"
        Me.textboxIDSiniestro.ReadOnly = True
        Me.textboxIDSiniestro.Size = New System.Drawing.Size(95, 22)
        Me.textboxIDSiniestro.TabIndex = 6
        Me.textboxIDSiniestro.TabStop = False
        Me.textboxIDSiniestro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Dock = System.Windows.Forms.DockStyle.Fill
        labelCreacion.Location = New System.Drawing.Point(4, 388)
        labelCreacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(127, 30)
        labelCreacion.TabIndex = 7
        labelCreacion.Text = "Creación:"
        labelCreacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanelCreacion
        '
        Me.TableLayoutPanelCreacion.AutoSize = True
        Me.TableLayoutPanelCreacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelCreacion.ColumnCount = 2
        Me.TableLayoutPanelCreacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelCreacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelCreacion.Controls.Add(Me.textboxUsuarioCreacion, 1, 0)
        Me.TableLayoutPanelCreacion.Controls.Add(Me.textboxFechaHoraCreacion, 0, 0)
        Me.TableLayoutPanelCreacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelCreacion.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelCreacion.Location = New System.Drawing.Point(135, 388)
        Me.TableLayoutPanelCreacion.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanelCreacion.Name = "TableLayoutPanelCreacion"
        Me.TableLayoutPanelCreacion.RowCount = 1
        Me.TableLayoutPanelCreacion.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelCreacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelCreacion.Size = New System.Drawing.Size(868, 30)
        Me.TableLayoutPanelCreacion.TabIndex = 8
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(4, 4)
        Me.textboxFechaHoraCreacion.Margin = New System.Windows.Forms.Padding(4)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(160, 22)
        Me.textboxFechaHoraCreacion.TabIndex = 8
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(172, 4)
        Me.textboxUsuarioCreacion.Margin = New System.Windows.Forms.Padding(4)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(692, 22)
        Me.textboxUsuarioCreacion.TabIndex = 9
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Dock = System.Windows.Forms.DockStyle.Fill
        labelModificacion.Location = New System.Drawing.Point(4, 418)
        labelModificacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(127, 30)
        labelModificacion.TabIndex = 10
        labelModificacion.Text = "Ultima Modificación:"
        labelModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanelUltimaModificacion
        '
        Me.TableLayoutPanelUltimaModificacion.AutoSize = True
        Me.TableLayoutPanelUltimaModificacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelUltimaModificacion.ColumnCount = 2
        Me.TableLayoutPanelUltimaModificacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelUltimaModificacion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelUltimaModificacion.Controls.Add(Me.textboxUsuarioModificacion, 1, 0)
        Me.TableLayoutPanelUltimaModificacion.Controls.Add(Me.textboxFechaHoraModificacion, 0, 0)
        Me.TableLayoutPanelUltimaModificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelUltimaModificacion.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelUltimaModificacion.Location = New System.Drawing.Point(135, 418)
        Me.TableLayoutPanelUltimaModificacion.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanelUltimaModificacion.Name = "TableLayoutPanelUltimaModificacion"
        Me.TableLayoutPanelUltimaModificacion.RowCount = 1
        Me.TableLayoutPanelUltimaModificacion.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelUltimaModificacion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelUltimaModificacion.Size = New System.Drawing.Size(868, 30)
        Me.TableLayoutPanelUltimaModificacion.TabIndex = 11
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(4, 4)
        Me.textboxFechaHoraModificacion.Margin = New System.Windows.Forms.Padding(4)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(160, 22)
        Me.textboxFechaHoraModificacion.TabIndex = 11
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(172, 4)
        Me.textboxUsuarioModificacion.Margin = New System.Windows.Forms.Padding(4)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(692, 22)
        Me.textboxUsuarioModificacion.TabIndex = 12
        '
        'ControlPersonaRadioTelefonista
        '
        Me.ControlPersonaRadioTelefonista.ApellidoNombre = Nothing
        Me.ControlPersonaRadioTelefonista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ControlPersonaRadioTelefonista.dbContext = Nothing
        Me.ControlPersonaRadioTelefonista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlPersonaRadioTelefonista.IDCuartel = Nothing
        Me.ControlPersonaRadioTelefonista.IDPersona = Nothing
        Me.ControlPersonaRadioTelefonista.Location = New System.Drawing.Point(155, 251)
        Me.ControlPersonaRadioTelefonista.Margin = New System.Windows.Forms.Padding(5)
        Me.ControlPersonaRadioTelefonista.MatriculaNumeroDigitos = Nothing
        Me.ControlPersonaRadioTelefonista.MaximumSize = New System.Drawing.Size(1333, 26)
        Me.ControlPersonaRadioTelefonista.MinimumSize = New System.Drawing.Size(200, 26)
        Me.ControlPersonaRadioTelefonista.Name = "ControlPersonaRadioTelefonista"
        Me.ControlPersonaRadioTelefonista.ReadOnlyText = False
        Me.ControlPersonaRadioTelefonista.Size = New System.Drawing.Size(324, 26)
        Me.ControlPersonaRadioTelefonista.SoloMostrarEnAsistencia = True
        Me.ControlPersonaRadioTelefonista.SoloMostrarEstadoActivo = True
        Me.ControlPersonaRadioTelefonista.TabIndex = 39
        '
        'ControlPersonaJefeGuardia
        '
        Me.ControlPersonaJefeGuardia.ApellidoNombre = Nothing
        Me.ControlPersonaJefeGuardia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ControlPersonaJefeGuardia.dbContext = Nothing
        Me.ControlPersonaJefeGuardia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlPersonaJefeGuardia.IDCuartel = Nothing
        Me.ControlPersonaJefeGuardia.IDPersona = Nothing
        Me.ControlPersonaJefeGuardia.Location = New System.Drawing.Point(155, 215)
        Me.ControlPersonaJefeGuardia.Margin = New System.Windows.Forms.Padding(5)
        Me.ControlPersonaJefeGuardia.MatriculaNumeroDigitos = Nothing
        Me.ControlPersonaJefeGuardia.MaximumSize = New System.Drawing.Size(1333, 26)
        Me.ControlPersonaJefeGuardia.MinimumSize = New System.Drawing.Size(200, 26)
        Me.ControlPersonaJefeGuardia.Name = "ControlPersonaJefeGuardia"
        Me.ControlPersonaJefeGuardia.ReadOnlyText = False
        Me.ControlPersonaJefeGuardia.Size = New System.Drawing.Size(324, 26)
        Me.ControlPersonaJefeGuardia.SoloMostrarEnAsistencia = True
        Me.ControlPersonaJefeGuardia.SoloMostrarEstadoActivo = True
        Me.ControlPersonaJefeGuardia.TabIndex = 37
        '
        'ControlPersonaEncargadoCuartel
        '
        Me.ControlPersonaEncargadoCuartel.ApellidoNombre = Nothing
        Me.ControlPersonaEncargadoCuartel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ControlPersonaEncargadoCuartel.dbContext = Nothing
        Me.ControlPersonaEncargadoCuartel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlPersonaEncargadoCuartel.IDCuartel = Nothing
        Me.ControlPersonaEncargadoCuartel.IDPersona = Nothing
        Me.ControlPersonaEncargadoCuartel.Location = New System.Drawing.Point(155, 179)
        Me.ControlPersonaEncargadoCuartel.Margin = New System.Windows.Forms.Padding(5)
        Me.ControlPersonaEncargadoCuartel.MatriculaNumeroDigitos = Nothing
        Me.ControlPersonaEncargadoCuartel.MaximumSize = New System.Drawing.Size(1333, 26)
        Me.ControlPersonaEncargadoCuartel.MinimumSize = New System.Drawing.Size(200, 26)
        Me.ControlPersonaEncargadoCuartel.Name = "ControlPersonaEncargadoCuartel"
        Me.ControlPersonaEncargadoCuartel.ReadOnlyText = False
        Me.ControlPersonaEncargadoCuartel.Size = New System.Drawing.Size(324, 26)
        Me.ControlPersonaEncargadoCuartel.SoloMostrarEnAsistencia = True
        Me.ControlPersonaEncargadoCuartel.SoloMostrarEstadoActivo = True
        Me.ControlPersonaEncargadoCuartel.TabIndex = 35
        '
        'FormSiniestroV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1019, 527)
        Me.Controls.Add(Me.TabControlMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSiniestroV2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Siniestro"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPageEncabezado.ResumeLayout(False)
        Me.TableLayoutPanelEncabezadoMain.ResumeLayout(False)
        Me.TableLayoutPanelEncabezadoMain.PerformLayout()
        Me.TableLayoutPanelEncabezado.ResumeLayout(False)
        Me.TableLayoutPanelEncabezado.PerformLayout()
        Me.TableLayoutPanelNumero.ResumeLayout(False)
        Me.TableLayoutPanelNumero.PerformLayout()
        Me.TableLayoutPanelHoraFin.ResumeLayout(False)
        Me.TableLayoutPanelHoraFin.PerformLayout()
        Me.TableLayoutPanelLlamadoUbicacion.ResumeLayout(False)
        Me.TableLayoutPanelLlamadoUbicacion.PerformLayout()
        Me.TableLayoutPanelGeneralSolicitanteDocumento.ResumeLayout(False)
        Me.TableLayoutPanelGeneralSolicitanteDocumento.PerformLayout()
        Me.TabPageGeneral.ResumeLayout(False)
        Me.TableLayoutPanelPieMain.ResumeLayout(False)
        Me.TableLayoutPanelPie.ResumeLayout(False)
        Me.TableLayoutPanelPie.PerformLayout()
        CType(Me.NumericUpDownIncendioForestalSuperficieMetro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.ResumeLayout(False)
        Me.TableLayoutPanelGeneralIncendioForestalSuperficie.PerformLayout()
        CType(Me.NumericUpDownIncendioForestalAnchoMetro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownIncendioForestalLargoMetro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelTrasladoPorOtro.ResumeLayout(False)
        Me.TableLayoutPanelTrasladoPorOtro.PerformLayout()
        CType(Me.NumericUpDownTrasladoPorOtroCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelIncendioForestalCantidad.ResumeLayout(False)
        Me.TableLayoutPanelIncendioForestalCantidad.PerformLayout()
        CType(Me.NumericUpDownIncendioForestalCantidadPlanta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownIncendioForestalCantidadHa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelResumenAsistencias.ResumeLayout(False)
        Me.TableLayoutPanelResumenAsistencias.PerformLayout()
        CType(Me.DataGridViewResumenAsistencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageDamnificado.ResumeLayout(False)
        Me.TabPageDamnificado.PerformLayout()
        CType(Me.DataGridViewDamnificados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStripDamnificados.ResumeLayout(False)
        Me.StatusStripDamnificados.PerformLayout()
        Me.ToolStripDaminificados.ResumeLayout(False)
        Me.ToolStripDaminificados.PerformLayout()
        Me.TabPageVehiculo.ResumeLayout(False)
        Me.TabPageVehiculo.PerformLayout()
        CType(Me.DataGridViewVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStripVehiculos.ResumeLayout(False)
        Me.StatusStripVehiculos.PerformLayout()
        Me.ToolStripVehiculos.ResumeLayout(False)
        Me.ToolStripVehiculos.PerformLayout()
        Me.tabpageAsistencias.ResumeLayout(False)
        Me.tabpageAsistencias.PerformLayout()
        CType(Me.datagridviewAsistencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStripAsistencias.ResumeLayout(False)
        Me.StatusStripAsistencias.PerformLayout()
        Me.toolstripAsistencias.ResumeLayout(False)
        Me.toolstripAsistencias.PerformLayout()
        Me.tabpageNotasAuditoria.ResumeLayout(False)
        Me.tabpageNotasAuditoria.PerformLayout()
        Me.TableLayoutPanelNotasAuditoria.ResumeLayout(False)
        Me.TableLayoutPanelNotasAuditoria.PerformLayout()
        Me.TableLayoutPanelCreacion.ResumeLayout(False)
        Me.TableLayoutPanelCreacion.PerformLayout()
        Me.TableLayoutPanelUltimaModificacion.ResumeLayout(False)
        Me.TableLayoutPanelUltimaModificacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents comboboxSiniestroRubro As System.Windows.Forms.ComboBox
    Friend WithEvents TabControlMain As System.Windows.Forms.TabControl
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents datetimepickerFecha As DateTimePicker
    Friend WithEvents tabpageAsistencias As TabPage
    Friend WithEvents datagridviewAsistencias As DataGridView
    Friend WithEvents toolstripAsistencias As ToolStrip
    Friend WithEvents buttonAsistenciasAgregar As ToolStripButton
    Friend WithEvents buttonAsistenciasEditar As ToolStripButton
    Friend WithEvents buttonAsistenciasEliminar As ToolStripButton
    Friend WithEvents datetimepickerHoraSalida As DateTimePicker
    Friend WithEvents buttonImprimir As ToolStripButton
    Friend WithEvents comboboxSiniestroTipo As ComboBox
    Friend WithEvents comboboxClave As ComboBox
    Friend WithEvents textboxSiniestroTipoOtro As TextBox
    Friend WithEvents datetimepickerHoraFin As DateTimePicker
    Friend WithEvents columnPersona As DataGridViewTextBoxColumn
    Friend WithEvents columnSiniestroAsistenciaTipo As DataGridViewTextBoxColumn
    Friend WithEvents maskedtextboxNumero As MaskedTextBox
    Friend WithEvents maskedtextboxNumeroPrefijo As MaskedTextBox
    Friend WithEvents StatusStripAsistencias As StatusStrip
    Friend WithEvents ToolStripStatusLabelAsistencias As ToolStripStatusLabel
    Friend WithEvents datetimepickerHoraLlegadaUltimoCamion As DateTimePicker
    Friend WithEvents buttonHoraFinFinalizar As Button
    Friend WithEvents textboxPersonaFin As TextBox
    Friend WithEvents TabPageEncabezado As TabPage
    Friend WithEvents TableLayoutPanelEncabezadoMain As TableLayoutPanel
    Friend WithEvents TableLayoutPanelEncabezado As TableLayoutPanel
    Friend WithEvents TableLayoutPanelNumero As TableLayoutPanel
    Friend WithEvents TableLayoutPanelHoraFin As TableLayoutPanel
    Friend WithEvents TableLayoutPanelLlamadoUbicacion As TableLayoutPanel
    Friend WithEvents TextBoxSolicitanteDireccion As TextBox
    Friend WithEvents TextBoxSolicitanteNombre As TextBox
    Friend WithEvents ComboBoxSolicitudForma As ComboBox
    Friend WithEvents TableLayoutPanelGeneralSolicitanteDocumento As TableLayoutPanel
    Friend WithEvents ComboBoxSolicitanteDocumentoTipo As ComboBox
    Friend WithEvents TextBoxSolicitanteDocumentoNumero As TextBox
    Friend WithEvents TextBoxSolicitanteTelefono As TextBox
    Friend WithEvents ComboBoxUbicacionTipo As ComboBox
    Friend WithEvents TextBoxUbicacionDescripcion As TextBox
    Friend WithEvents ComboBoxUbicacionProvincia As ComboBox
    Friend WithEvents ComboBoxUbicacionLocalidad As ComboBox
    Friend WithEvents TableLayoutPanelIncendioForestalCantidad As TableLayoutPanel
    Friend WithEvents NumericUpDownIncendioForestalCantidadHa As NumericUpDown
    Friend WithEvents NumericUpDownIncendioForestalCantidadPlanta As NumericUpDown
    Private WithEvents labelHoraSalida As Label
    Private WithEvents labelHoraFin As Label
    Private WithEvents labelHoraLlegadaUltimoCamion As Label
    Private WithEvents LabelCuartel As Label
    Private WithEvents LabelSolicitudForma As Label
    Private WithEvents LabelSolicitanteNombre As Label
    Private WithEvents LabelSolicitanteDireccion As Label
    Private WithEvents LabelSolicitanteDocumento As Label
    Private WithEvents LabelSolicitanteTelefono As Label
    Private WithEvents LabelUbicacionTipo As Label
    Private WithEvents LabelUbicacionDescripcion As Label
    Private WithEvents LabelUbicacionProvincia As Label
    Private WithEvents LabelUbicacionLocalidad As Label
    Private WithEvents LabelIncendioForestalCantidadHa As Label
    Private WithEvents LabelIncendioForestalCantidadPlanta As Label
    Private WithEvents labelFecha As Label
    Private WithEvents labelSiniestroRubro As Label
    Private WithEvents labelSiniestroTipo As Label
    Private WithEvents labelClave As Label
    Private WithEvents labelSiniestroTipoOtro As Label
    Private WithEvents labelNumeroSeparador As Label
    Private WithEvents LabelNumero As Label
    Private WithEvents ComboBoxCuartel As ComboBox
    Private WithEvents buttonCodigoSiguiente As Button
    Friend WithEvents TabPageDamnificado As TabPage
    Friend WithEvents TabPageGeneral As TabPage
    Friend WithEvents TableLayoutPanelPieMain As TableLayoutPanel
    Friend WithEvents TableLayoutPanelPie As TableLayoutPanel
    Private WithEvents LabelTrasladoPorOtro As Label
    Friend WithEvents TableLayoutPanelTrasladoPorOtro As TableLayoutPanel
    Friend WithEvents CheckBoxTrasladoPorOtro As CheckBox
    Friend WithEvents NumericUpDownTrasladoPorOtroCantidad As NumericUpDown
    Private WithEvents LabelIncendioForestal As Label
    Private WithEvents LabelIncendioForestalCantidad As Label
    Friend WithEvents TableLayoutPanelGeneralIncendioForestalSuperficie As TableLayoutPanel
    Friend WithEvents NumericUpDownIncendioForestalAnchoMetro As NumericUpDown
    Private WithEvents LabelIncendioForestalAnchoMetro As Label
    Private WithEvents LabelIncendioForestalLargoMetro As Label
    Friend WithEvents NumericUpDownIncendioForestalLargoMetro As NumericUpDown
    Private WithEvents LabelIncendioForestalMedida As Label
    Private WithEvents LabelEncargadoCuartel As Label
    Friend WithEvents NumericUpDownIncendioForestalSuperficieMetro As NumericUpDown
    Private WithEvents LabelIncendioForestalSuperficieMetro As Label
    Friend WithEvents ControlPersonaJefeGuardia As ControlPersona
    Private WithEvents LabelJefeGuardia As Label
    Friend WithEvents ControlPersonaEncargadoCuartel As ControlPersona
    Private WithEvents LabelControlado As Label
    Friend WithEvents ControlPersonaRadioTelefonista As ControlPersona
    Private WithEvents LabelRadioTelefonista As Label
    Friend WithEvents CheckBoxControlado As CheckBox
    Friend WithEvents TableLayoutPanelResumenAsistencias As TableLayoutPanel
    Private WithEvents labelResumenAsistencias As Label
    Friend WithEvents DataGridViewResumenAsistencias As DataGridView
    Friend WithEvents columnResumenAsistenciaTipo As DataGridViewTextBoxColumn
    Friend WithEvents columnResumenCantidad As DataGridViewTextBoxColumn
    Friend WithEvents TabPageVehiculo As TabPage
    Friend WithEvents DataGridViewVehiculos As DataGridView
    Friend WithEvents DataGridViewTextBoxColumnVehiculosTipo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumnDataGridViewTextBoxColumnVehiculosMarca As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumnVehiculosModelo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumnVehiculosDominio As DataGridViewTextBoxColumn
    Friend WithEvents StatusStripVehiculos As StatusStrip
    Friend WithEvents ToolStripStatusLabelVehiculos As ToolStripStatusLabel
    Friend WithEvents ToolStripVehiculos As ToolStrip
    Friend WithEvents ToolStripButtonVehiculosAgregar As ToolStripButton
    Friend WithEvents ToolStripButtonVehiculosEditar As ToolStripButton
    Friend WithEvents ToolStripButtonVehiculosBorrar As ToolStripButton
    Friend WithEvents DataGridViewDamnificados As DataGridView
    Friend WithEvents DataGridViewTextBoxColumnDamnificadosApellidoNombre As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumnDamnificadosEdad As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumnDamnificadosEstado As DataGridViewTextBoxColumn
    Friend WithEvents StatusStripDamnificados As StatusStrip
    Friend WithEvents ToolStripStatusLabelDamnificados As ToolStripStatusLabel
    Friend WithEvents ToolStripDaminificados As ToolStrip
    Friend WithEvents ToolStripButtonDamnificadosAgregar As ToolStripButton
    Friend WithEvents ToolStripButtonDamnificadosEditar As ToolStripButton
    Friend WithEvents ToolStripButtonDamnificadosBorrar As ToolStripButton
    Friend WithEvents TableLayoutPanelNotasAuditoria As TableLayoutPanel
    Friend WithEvents textboxIDSiniestro As TextBox
    Friend WithEvents labelIDSiniestro As Label
    Friend WithEvents checkboxAnulado As CheckBox
    Friend WithEvents labelAnulado As Label
    Friend WithEvents textboxNotas As TextBox
    Friend WithEvents labelNotas As Label
    Friend WithEvents TableLayoutPanelCreacion As TableLayoutPanel
    Friend WithEvents textboxUsuarioCreacion As TextBox
    Friend WithEvents textboxFechaHoraCreacion As TextBox
    Friend WithEvents TableLayoutPanelUltimaModificacion As TableLayoutPanel
    Friend WithEvents textboxUsuarioModificacion As TextBox
    Friend WithEvents textboxFechaHoraModificacion As TextBox
End Class
