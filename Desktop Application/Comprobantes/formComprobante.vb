Public Class formComprobante

#Region "Declarations"

    Private _TabControlExtension As CardonerSistemas.Controls.TabControlExtension

    Private mdbContext As New CSBomberosContext(True)
    Private mComprobanteActual As Comprobante

    Private mOperacionTipo As String
    Private mComprobanteTipoActual As ComprobanteTipo
    Private mNumerador As Numerador

    Private mIsNew As Boolean
    Private mIsLoading As Boolean
    Private mEditMode As Boolean

    Public Class GridRowDataAplicacion
        Public Property ComprobanteAplicacion As ComprobanteAplicacion
        Public Property Motivo As String
        Public Property ComprobanteTipoNombre As String
        Public Property MovimientoTipo As String
        Public Property NumeroCompleto As String
        Public Property FechaEmision As Date
        Public Property ImporteTotal As Decimal
        Public Property ImporteAplicado As Decimal
    End Class

    Public Class GridRowDataMedioPago
        Public Property ComprobanteMedioPago As ComprobanteMedioPago
        Public Property MedioPago As MedioPago
        Public Property MedioPagoNombre As String
        Public Property Importe As Decimal
        Public Property BancoNombre As String
        Public Property Numero As String
        Public Property FechaVencimiento As Date
    End Class

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByVal OperacionTipo As String, ByVal IDComprobante As Integer)
        mIsNew = (IDComprobante = 0)
        mIsLoading = True
        mEditMode = EditMode
        mOperacionTipo = OperacionTipo

        ' Antes que nada, cierro las ventanas hijas que pudieran haber quedado abiertas
        If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formComprobanteMedioPago") Then
            formComprobanteMedioPago.Close()
            formComprobanteMedioPago = Nothing
        End If

        If mIsNew Then
            ' Es Nuevo
            mComprobanteActual = New Comprobante With {
                .Fecha = DateAndTime.Today
            }
            mdbContext.Comprobante.Add(mComprobanteActual)
        Else
            mComprobanteActual = mdbContext.Comprobante.Find(IDComprobante)
        End If

        Me.MdiParent = pFormMDIMain
        CardonerSistemas.Forms.MdiChildPositionAndSizeToFit(CType(pFormMDIMain, Form), Me)
        InitializeFormAndControls()
        CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxComprobanteTipo, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, mComprobanteActual.IDComprobanteTipo)
        CambiarTipoComprobante()
        SetDataFromObjectToControls()
        Me.Show()
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Focus()

        mIsLoading = False

        ChangeMode()
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Exit Sub
        End If

        ' Main toolbar
        If mComprobanteTipoActual Is Nothing Then
            buttonAFIP.Visible = False
        Else
            buttonAFIP.Visible = (mEditMode = False And mComprobanteTipoActual.EmisionElectronica And mComprobanteActual.IDUsuarioAnulacion Is Nothing)
            menuitemAFIP_ObtenerCAE.Enabled = (mComprobanteActual.CAE Is Nothing)
            menuitemAFIP_VerificarDatos.Enabled = (mComprobanteActual.CAE IsNot Nothing)
        End If
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False And mComprobanteActual.CAE Is Nothing And mComprobanteActual.IDUsuarioAnulacion Is Nothing)
        buttonCerrar.Visible = (mEditMode = False)

        ' Datos del comprobante
        comboboxComprobanteTipo.Enabled = (mEditMode And mComprobanteActual.ComprobanteDetalles.Count = 0 And mComprobanteActual.ComprobantesAplicados.Count = 0 And mComprobanteActual.ComprobanteMediosPago.Count = 0)
        MaskedTextBoxPuntoVenta.ReadOnly = ((mNumerador IsNot Nothing) Or (Not mEditMode))
        MaskedTextBoxNumero.ReadOnly = ((mNumerador IsNot Nothing) Or (Not mEditMode))
        datetimepickerFechaEmision.Enabled = mEditMode

        ' Fechas del comprobante
        datetimepickerFechaVencimiento.Enabled = mEditMode
        datetimepickerFechaServicioDesde.Enabled = mEditMode
        datetimepickerFechaServicioHasta.Enabled = mEditMode

        comboboxEntidad.Enabled = (mEditMode And mComprobanteActual.ComprobantesAplicados.Count = 0)

        ' Datos del gasto
        comboboxArea.Enabled = mEditMode
        checkboxEsBienUso.Enabled = mEditMode

        textboxDescripcion.ReadOnly = (mEditMode = False)

        ' Toolbars de solapas
        toolstripDetalle.Enabled = mEditMode
        toolstripAplicaciones.Enabled = (mEditMode And mComprobanteTipoActual IsNot Nothing)
        toolstripAplicaciones.Visible = (mComprobanteTipoActual IsNot Nothing AndAlso mComprobanteTipoActual.UtilizaAplicado)
        toolstripMediosPago.Enabled = mEditMode

        textboxNotas.ReadOnly = (mEditMode = False)

        currencytextboxImporteTotal.ReadOnly = (mEditMode = False Or (mComprobanteTipoActual IsNot Nothing AndAlso (mComprobanteTipoActual.UtilizaDetalle Or mComprobanteTipoActual.UtilizaMedioPago)))
    End Sub

    Friend Sub InitializeFormAndControls()
        _TabControlExtension = New CardonerSistemas.Controls.TabControlExtension(tabcontrolMain)

        SetAppearance()

        MaskedTextBoxPuntoVenta.Mask = New String("0"c, Constantes.ComprobantePuntoVentaLongitud)
        MaskedTextBoxNumero.Mask = New String("0"c, Constantes.ComprobanteNumeroLongitud)

        ' Cargo los ComboBox
        ListasComprobantes.LlenarComboBoxComprobantesTipos(mdbContext, comboboxComprobanteTipo, mOperacionTipo, False, False)
        ListasComunes.LlenarComboBoxAreasConCuartel(mdbContext, comboboxArea, False, True, , , True)
    End Sub

    Friend Sub SetAppearance()
        If mOperacionTipo = Constantes.OperacionTipoCompra Then
            labelEntidad.Text = "Proveedor:"
        ElseIf mOperacionTipo = Constantes.OperacionTipoCompra Then
            labelEntidad.Text = "Cliente:"
        Else
            labelEntidad.Text = "Entidad:"
        End If

        datagridviewDetalle.DefaultCellStyle.Font = pAppearanceConfig.ListsFont
        datagridviewDetalle.ColumnHeadersDefaultCellStyle.Font = pAppearanceConfig.ListsFont

        datagridviewAplicaciones.DefaultCellStyle.Font = pAppearanceConfig.ListsFont
        datagridviewAplicaciones.ColumnHeadersDefaultCellStyle.Font = pAppearanceConfig.ListsFont

        datagridviewMediosPago.DefaultCellStyle.Font = pAppearanceConfig.ListsFont
        datagridviewMediosPago.ColumnHeadersDefaultCellStyle.Font = pAppearanceConfig.ListsFont
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mComprobanteActual = Nothing
        mComprobanteTipoActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mComprobanteActual
            ' Datos de la Identificación
            If mIsNew Then
                textboxIDComprobante.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDComprobante.Text = String.Format(.IDComprobante.ToString, "G")
            End If
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxComprobanteTipo, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .IDComprobanteTipo)
            MaskedTextBoxPuntoVenta.Text = .PuntoVenta.ToString(New String("0"c, Constantes.ComprobantePuntoVentaLongitud))
            MaskedTextBoxNumero.Text = .Numero.ToString(New String("0"c, Constantes.ComprobanteNumeroLongitud))
            datetimepickerFechaEmision.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.Fecha, datetimepickerFechaEmision)

            ' Fechas
            datetimepickerFechaVencimiento.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaVencimiento, datetimepickerFechaVencimiento)
            datetimepickerFechaServicioDesde.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaServicioDesde, datetimepickerFechaServicioDesde)
            datetimepickerFechaServicioHasta.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaServicioHasta, datetimepickerFechaServicioHasta)

            ' Entidad
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxEntidad, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDEntidad, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)

            ' Datos de gasto
            If mComprobanteTipoActual IsNot Nothing AndAlso mComprobanteTipoActual.UtilizaDatoGasto Then
                CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxArea, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .IDArea, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
                checkboxEsBienUso.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsBienUso)
            Else
                comboboxArea.SelectedIndex = 0
                checkboxEsBienUso.Checked = False
            End If

            ' Descripción
            textboxDescripcion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Descripcion)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .UsuarioCreacion Is Nothing Then
                textboxFechaHoraCreacion.Text = ""
                textboxUsuarioCreacion.Text = ""
            Else
                textboxFechaHoraCreacion.Text = .FechaHoraCreacion.ToShortDateString & " " & .FechaHoraCreacion.ToShortTimeString
                textboxUsuarioCreacion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.UsuarioCreacion.Descripcion)
            End If
            If .UsuarioModificacion Is Nothing Then
                textboxFechaHoraModificacion.Text = ""
                textboxUsuarioModificacion.Text = ""
            Else
                textboxFechaHoraModificacion.Text = .FechaHoraModificacion.ToShortDateString & " " & .FechaHoraModificacion.ToShortTimeString
                textboxUsuarioModificacion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.UsuarioModificacion.Descripcion)
            End If
            If .UsuarioEnvioEmail Is Nothing Then
                textboxFechaHoraEnvioEmail.Text = ""
                textboxUsuarioEnvioEmail.Text = ""
            Else
                If .FechaHoraEnvioEmail IsNot Nothing Then
                    textboxFechaHoraEnvioEmail.Text = .FechaHoraEnvioEmail.Value.ToShortDateString & " " & .FechaHoraEnvioEmail.Value.ToShortTimeString
                End If
                textboxUsuarioEnvioEmail.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.UsuarioEnvioEmail.Descripcion)
            End If

            ' Datos del Pie - Importes Totales
            currencytextboxDetalle_Subtotal.DecimalValue = 0
            currencytextboxAplicaciones_Subtotal.DecimalValue = 0
            currencytextboxMediosPago_Subtotal.DecimalValue = 0

            If Not mIsNew Then
                RefreshDataDetalle()
                If mComprobanteActual.ComprobanteTipo.UtilizaAplicado Or mComprobanteActual.ComprobanteTipo.UtilizaAplicante Then
                    RefreshData_Aplicaciones()
                End If
                If mComprobanteActual.ComprobanteTipo.UtilizaMedioPago Then
                    RefreshDataMediosPago()
                End If
            End If

            currencytextboxImporteTotal.DecimalValue = .Importe
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mComprobanteActual
            ' Datos de la Identificación
            .IDComprobanteTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxComprobanteTipo.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE).Value

            .PuntoVenta = CInt(MaskedTextBoxPuntoVenta.Text)
            .Numero = CInt(MaskedTextBoxNumero.Text)

            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaEmision.Value).Value

            ' Fechas
            .FechaVencimiento = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaVencimiento.Value, datetimepickerFechaVencimiento.Checked)
            .FechaServicioDesde = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaServicioDesde.Value, datetimepickerFechaServicioDesde.Checked)
            .FechaServicioHasta = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaServicioHasta.Value, datetimepickerFechaServicioHasta.Checked)

            ' Entidad
            Dim entidad As Entidad
            entidad = CType(comboboxEntidad.SelectedItem, Entidad)
            .IDEntidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxEntidad.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT).Value
            .EntidadNombre = entidad.Nombre
            .EntidadCuit = entidad.Cuit
            .EntidadIDCategoriaIVA = entidad.IDCategoriaIVA
            .EntidadDomicilio = entidad.DomicilioCalleCompleto
            .EntidadCodigoPostal = entidad.DomicilioCodigoPostal
            .EntidadIDProvincia = entidad.DomicilioIDProvincia
            .EntidadIDLocalidad = entidad.DomicilioIDLocalidad
            entidad = Nothing

            ' Datos de gasto
            If mComprobanteTipoActual.UtilizaDatoGasto Then
                .IDArea = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxArea.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
                .EsBienUso = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsBienUso.CheckState)
            Else
                .IDArea = Nothing
                .EsBienUso = False
            End If

            ' Descripción
            .Descripcion = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDescripcion.Text)

            ' Datos de la pestaña Notas y Aditoría
            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)

            ' Datos del Pie - Importes Totales
            .Importe = currencytextboxImporteTotal.DecimalValue
        End With

    End Sub

#End Region

#Region "Controls behavior"

    Private Sub ComprobanteTipoChanged() Handles comboboxComprobanteTipo.SelectedValueChanged
        If Not mIsLoading Then
            CambiarTipoComprobante()
            ChangeMode()
        End If
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxIDComprobante.GotFocus, textboxDescripcion.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub MaskedTextBoxs_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBoxPuntoVenta.GotFocus, MaskedTextBoxNumero.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
    End Sub

    Private Sub MaskedTextBoxPuntoVenta_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBoxPuntoVenta.LostFocus
        Dim result As Int32

        If Int32.TryParse(MaskedTextBoxPuntoVenta.Text.Trim, result) Then
            MaskedTextBoxPuntoVenta.Text = result.ToString(New String("0"c, Constantes.ComprobantePuntoVentaLongitud))
        End If
    End Sub

    Private Sub MaskedTextBoxNumero_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBoxNumero.LostFocus
        Dim result As Int32

        If Int32.TryParse(MaskedTextBoxNumero.Text.Trim, result) Then
            MaskedTextBoxNumero.Text = result.ToString(New String("0"c, Constantes.ComprobanteNumeroLongitud))
        End If
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click(sender As Object, e As EventArgs) Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.COMPROBANTE_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrar_Click(sender As Object, e As EventArgs) Handles buttonCerrar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click(sender As Object, e As EventArgs) Handles buttonGuardar.Click

        If Not VerificarDatosComprobante() Then
            Exit Sub
        End If

        If Not VerificarFechas() Then
            Exit Sub
        End If

        If Not VerificarEntidad() Then
            Exit Sub
        End If

        If Not VerificarImportes() Then
            Exit Sub
        End If

        If mIsNew Then
            If Not EstablecerValoresNuevoComprobante() Then
                Exit Sub
            End If
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mComprobanteActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mComprobanteActual.FechaHoraModificacion = Now

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Comprobante con el mismo ID.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Case CardonerSistemas.Database.EntityFramework.Errors.Unknown, CardonerSistemas.Database.EntityFramework.Errors.NoDBError
                        CardonerSistemas.ErrorHandler.ProcessError(dbuex.GetBaseException, My.Resources.STRING_ERROR_SAVING_CHANGES)
                    Case Else
                        CardonerSistemas.ErrorHandler.ProcessError(dbuex.GetBaseException, My.Resources.STRING_ERROR_SAVING_CHANGES)
                End Select
                Exit Sub

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Exit Sub
            End Try

            'AutorizarComprobanteEnAfip(False, False)

            ' Refresco la lista de Comprobantes para mostrar los cambios
            If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formComprobantes") Then
                Dim formComprobantes As formComprobantes = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formComprobantes"), formComprobantes)
                formComprobantes.RefreshData(mComprobanteActual.IDComprobante)
                formComprobantes = Nothing
            End If
        End If

        Me.Close()
    End Sub

    Private Sub menuitemAFIP_ObtenerCAE_Click(sender As Object, e As EventArgs) Handles menuitemAFIP_ObtenerCAE.Click
        'AutorizarComprobanteEnAfip(True, True)
    End Sub

    Private Sub menuitemAFIP_ObtenerQR_Click(sender As Object, e As EventArgs) Handles menuitemAFIP_ObtenerQR.Click
        'ObtenerCodigoQR()
    End Sub

    Private Sub menuitemAFIP_VerificarDatos_Click(sender As Object, e As EventArgs) Handles menuitemAFIP_VerificarDatos.Click
        'VerificarDatosComprobanteEnAfip()
    End Sub

    Private Sub Cancelar(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        If mdbContext.ChangeTracker.HasChanges Then
            If MsgBox("Ha realizado cambios en los datos y seleccionó cancelar, los cambios se perderán." & vbCr & vbCr & "¿Confirma la pérdida de los cambios?", CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

#End Region

#Region "Verificaciones"

    Private Function VerificarDatosComprobante() As Boolean
        If comboboxComprobanteTipo.SelectedIndex = -1 Then
            MsgBox("Debe especificar el Tipo de Comprobante.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxComprobanteTipo.Focus()
            Return False
        End If

        ' Punto de Venta
        If MaskedTextBoxPuntoVenta.Text.Trim.Length = 0 Then
            MsgBox("Debe especificar el Punto de Venta.", MsgBoxStyle.Information, My.Application.Info.Title)
            MaskedTextBoxPuntoVenta.Focus()
            Return False
        End If
        If Not Int32.TryParse(MaskedTextBoxPuntoVenta.Text.Trim, New Int32) Then
            MsgBox("El Punto de Venta debe ser un valor numérico.", MsgBoxStyle.Information, My.Application.Info.Title)
            MaskedTextBoxPuntoVenta.Focus()
            Return False
        End If

        ' Número
        If MaskedTextBoxNumero.Text.Trim.Length = 0 Then
            MsgBox("Debe especificar el Número de Comprobante.", MsgBoxStyle.Information, My.Application.Info.Title)
            MaskedTextBoxNumero.Focus()
            Return False
        End If
        If Not Int32.TryParse(MaskedTextBoxNumero.Text.Trim, New Int32) Then
            MsgBox("El Número de Comprobante debe ser un valor numérico.", MsgBoxStyle.Information, My.Application.Info.Title)
            MaskedTextBoxNumero.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function VerificarFechas() As Boolean
        ' Fecha de Vencimiento
        If datetimepickerFechaVencimiento.Checked AndAlso datetimepickerFechaVencimiento.Value.CompareTo(datetimepickerFechaEmision.Value) < 0 Then
            MsgBox("La Fecha de Vencimiento debe ser posterior o igual a la Fecha de Emisión.", MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerFechaVencimiento.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function VerificarEntidad() As Boolean
        Dim entidadActual As Entidad
        Dim leyenda As String

        If mOperacionTipo = Constantes.OperacionTipoCompra Then
            leyenda = "el Proveedor"
        ElseIf mOperacionTipo = Constantes.OperacionTipoCompra Then
            leyenda = "el Cliente"
        Else
            leyenda = "la Entidad"
        End If

        If comboboxEntidad.SelectedIndex = -1 Then
            MsgBox($"Debe especificar {leyenda}.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxEntidad.Focus()
            Return False
        End If

        entidadActual = CType(comboboxEntidad.SelectedItem, Entidad)

        If CType(comboboxComprobanteTipo.SelectedItem, ComprobanteTipo).OperacionTipo = Constantes.OperacionTipoVenta Then
            If entidadActual.IDCategoriaIVA Is Nothing Then
                MsgBox($"{CS_String.ToTitleCase(leyenda)} no tiene especificada la Categoría de IVA.", MsgBoxStyle.Information, My.Application.Info.Title)
                comboboxEntidad.Focus()
                Return False
            End If
            If Not entidadActual.Cuit.HasValue Then
                MsgBox($"{CS_String.ToTitleCase(leyenda)} no tiene especificado el CUIT.", MsgBoxStyle.Information, My.Application.Info.Title)
                comboboxEntidad.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Function VerificarImportes() As Boolean
        ' Importe Total
        If mComprobanteTipoActual.UtilizaDetalle = False And mComprobanteTipoActual.UtilizaMedioPago = False Then
            If currencytextboxImporteTotal.IsNull Or currencytextboxImporteTotal.DecimalValue <= 0 Then
                MsgBox("El Total debe ser mayor a cero.", MsgBoxStyle.Information, My.Application.Info.Title)
                currencytextboxImporteTotal.Focus()
                Return False
            End If
        End If

        ' Subtotales de cada solapa
        If mComprobanteTipoActual.UtilizaAplicado Then
            If currencytextboxAplicaciones_Subtotal.DecimalValue > 0 AndAlso currencytextboxAplicaciones_Subtotal.DecimalValue > currencytextboxImporteTotal.DecimalValue Then
                MsgBox("El Subtotal de los Comprobantes aplicados no puede ser mayor al Total del Comprobante actual.", MsgBoxStyle.Information, My.Application.Info.Title)
                Return False
            End If
        End If

        Return True
    End Function

#End Region

#Region "Detalles"

    Friend Sub RefreshDataDetalle(Optional ByVal PositionIndice As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim Total As Decimal = 0

        If RestoreCurrentPosition Then
            If datagridviewDetalle.CurrentRow Is Nothing Then
                PositionIndice = 0
            Else
                PositionIndice = CType(datagridviewDetalle.CurrentRow.DataBoundItem, ComprobanteDetalle).Indice
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            datagridviewDetalle.AutoGenerateColumns = False
            datagridviewDetalle.DataSource = mComprobanteActual.ComprobanteDetalles.ToList

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Detalles.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        For Each ComprobanteDetalleActual As ComprobanteDetalle In mComprobanteActual.ComprobanteDetalles
            Total += ComprobanteDetalleActual.PrecioTotal
        Next
        currencytextboxDetalle_Subtotal.DecimalValue = Total
        If mComprobanteTipoActual.UtilizaDetalle Then
            currencytextboxImporteTotal.DecimalValue = Total
        End If

        Me.Cursor = Cursors.Default

        If PositionIndice <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewDetalle.Rows
                If CType(datagridviewDetalle.CurrentRow.DataBoundItem, ComprobanteDetalle).Indice = PositionIndice Then
                    datagridviewDetalle.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If

        ChangeMode()
    End Sub

    Private Sub DetalleAgregar(sender As Object, e As EventArgs) Handles buttonDetalle_Agregar.ButtonClick
        If comboboxEntidad.SelectedIndex = -1 Then
            MsgBox("Antes de poder agregar Detalles, debe especificar la Entidad.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxEntidad.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        datagridviewDetalle.Enabled = False

        mComprobanteActual.IDEntidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxEntidad.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT).Value

        Dim ComprobanteDetalleNuevo As New ComprobanteDetalle
        formComprobanteDetalle.LoadAndShow(True, True, Me, mComprobanteActual, ComprobanteDetalleNuevo)

        datagridviewDetalle.Enabled = True

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DetalleEditar(sender As Object, e As EventArgs) Handles buttonDetalle_Editar.Click
        If datagridviewDetalle.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Detalle para editar.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewDetalle.Enabled = False

            Dim ComprobanteDetalleActual As ComprobanteDetalle

            ComprobanteDetalleActual = CType(datagridviewDetalle.SelectedRows(0).DataBoundItem, ComprobanteDetalle)
            formComprobanteDetalle.LoadAndShow(True, True, Me, mComprobanteActual, ComprobanteDetalleActual)

            datagridviewDetalle.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub DetalleEliminar(sender As Object, e As EventArgs) Handles buttonDetalle_Eliminar.Click
        If datagridviewDetalle.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Detalle para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            Dim ComprobanteDetalleEliminar As ComprobanteDetalle
            ComprobanteDetalleEliminar = CType(datagridviewDetalle.SelectedRows(0).DataBoundItem, ComprobanteDetalle)

            Dim Mensaje As String
            Mensaje = String.Format("Se eliminará el Detalle seleccionado.{0}{0}Descripción: {1}{0}Precio Unitario: {2}{0}Precio Total: {3}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, ComprobanteDetalleEliminar.Descripcion, FormatCurrency(ComprobanteDetalleEliminar.PrecioUnitario), FormatCurrency(ComprobanteDetalleEliminar.PrecioTotal))
            If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                mComprobanteActual.ComprobanteDetalles.Remove(ComprobanteDetalleEliminar)

                RefreshDataDetalle()

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub DetalleVer(sender As Object, e As EventArgs) Handles datagridviewDetalle.DoubleClick
        If datagridviewDetalle.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Detalle para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewDetalle.Enabled = False

            Dim ComprobanteDetalleActual As ComprobanteDetalle

            ComprobanteDetalleActual = CType(datagridviewDetalle.SelectedRows(0).DataBoundItem, ComprobanteDetalle)
            formComprobanteDetalle.LoadAndShow(mEditMode, False, Me, mComprobanteActual, ComprobanteDetalleActual)

            datagridviewDetalle.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Aplicaciones"

    Friend Sub RefreshData_Aplicaciones(Optional ByVal PositionIDComprobanteAplica As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listAplicaciones As List(Of GridRowDataAplicacion)
        Dim Total As Decimal = 0

        If RestoreCurrentPosition Then
            If datagridviewAplicaciones.CurrentRow Is Nothing Then
                PositionIDComprobanteAplica = 0
            Else
                If mComprobanteTipoActual.UtilizaAplicado Then
                    PositionIDComprobanteAplica = CType(datagridviewAplicaciones.CurrentRow.DataBoundItem, GridRowDataAplicacion).ComprobanteAplicacion.IDComprobanteAplicado
                Else
                    PositionIDComprobanteAplica = CType(datagridviewAplicaciones.CurrentRow.DataBoundItem, GridRowDataAplicacion).ComprobanteAplicacion.IDComprobanteAplicante
                End If
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listAplicaciones = New List(Of GridRowDataAplicacion)

            If (mComprobanteTipoActual.UtilizaAplicado AndAlso mComprobanteActual.ComprobantesAplicados.Count > 0) OrElse (mComprobanteTipoActual.UtilizaAplicante AndAlso mComprobanteActual.ComprobantesAplicantes.Count > 0) Then

                Using dbContext As New CSBomberosContext(True)

                    Dim ComprobantesAplica As ICollection(Of ComprobanteAplicacion)
                    If mComprobanteTipoActual.UtilizaAplicado Then
                        ComprobantesAplica = mComprobanteActual.ComprobantesAplicados
                    Else
                        ComprobantesAplica = mComprobanteActual.ComprobantesAplicantes
                    End If

                    For Each ca As ComprobanteAplicacion In ComprobantesAplica
                        Dim GridRowData As New GridRowDataAplicacion
                        Dim ComprobanteAplica As Comprobante

                        With GridRowData
                            .ComprobanteAplicacion = ca

                            ComprobanteAplica = dbContext.Comprobante.Find(IIf(mComprobanteTipoActual.UtilizaAplicado, ca.IDComprobanteAplicado, ca.IDComprobanteAplicante))
                            .ComprobanteTipoNombre = ComprobanteAplica.ComprobanteTipo.Nombre
                            .MovimientoTipo = ComprobanteAplica.ComprobanteTipo.MovimientoTipo

                            .NumeroCompleto = ComprobanteAplica.NumeroCompleto
                            .FechaEmision = ComprobanteAplica.Fecha
                            .ImporteTotal = ComprobanteAplica.Importe
                            .ImporteAplicado = ca.Importe
                        End With

                        listAplicaciones.Add(GridRowData)

                        ComprobanteAplica = Nothing
                        GridRowData = Nothing
                    Next
                    ComprobantesAplica = Nothing
                End Using

            End If

            datagridviewAplicaciones.AutoGenerateColumns = False
            datagridviewAplicaciones.DataSource = listAplicaciones

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Comprobantes " & CStr(IIf(mComprobanteTipoActual.UtilizaAplicado, "aplicados.", "aplicantes.")))
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        For Each GridRowData_AplicacionActual As GridRowDataAplicacion In listAplicaciones
            Select Case GridRowData_AplicacionActual.MovimientoTipo
                Case Constantes.MovimientoTipoCredito
                    Total += GridRowData_AplicacionActual.ImporteAplicado
                Case Constantes.MovimientoTipoDebito
                    Total -= GridRowData_AplicacionActual.ImporteAplicado
            End Select
        Next
        currencytextboxAplicaciones_Subtotal.DecimalValue = Total

        If mComprobanteTipoActual.UtilizaDetalle = False And mComprobanteTipoActual.UtilizaMedioPago = False Then
            currencytextboxImporteTotal.DecimalValue = Total
            currencytextboxImporteTotal.ReadOnly = (listAplicaciones.Count > 0)
        End If

        Me.Cursor = Cursors.Default

        If PositionIDComprobanteAplica <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewAplicaciones.Rows
                If (mComprobanteTipoActual.UtilizaAplicado AndAlso CType(datagridviewAplicaciones.CurrentRow.DataBoundItem, GridRowDataAplicacion).ComprobanteAplicacion.IDComprobanteAplicado = PositionIDComprobanteAplica) OrElse (mComprobanteTipoActual.UtilizaAplicante AndAlso CType(datagridviewAplicaciones.CurrentRow.DataBoundItem, GridRowDataAplicacion).ComprobanteAplicacion.IDComprobanteAplicante = PositionIDComprobanteAplica) Then
                    datagridviewAplicaciones.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If

        ChangeMode()
    End Sub

    Private Sub AplicacionAgregar(sender As Object, e As EventArgs) Handles buttonAplicaciones_Agregar.Click
        If comboboxEntidad.SelectedIndex = -1 Then
            MsgBox("Antes de poder agregar Aplicaciones, debe especificar la Entidad.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxEntidad.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        datagridviewAplicaciones.Enabled = False

        mComprobanteActual.IDEntidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxEntidad.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT).Value

        Dim ComprobanteAplicacionNuevo As New ComprobanteAplicacion
        formComprobanteAplicacion.LoadAndShow(True, True, Me, mComprobanteActual, mComprobanteTipoActual, ComprobanteAplicacionNuevo)

        datagridviewAplicaciones.Enabled = True

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Aplicacion_Eliminar(sender As Object, e As EventArgs) Handles buttonAplicaciones_Eliminar.Click
        If datagridviewAplicaciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Aplicación para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            Dim GridRowData_Aplicacion_Eliminar As GridRowDataAplicacion
            GridRowData_Aplicacion_Eliminar = CType(datagridviewAplicaciones.SelectedRows(0).DataBoundItem, GridRowDataAplicacion)

            Dim Mensaje As String
            Mensaje = String.Format("Se eliminará la Aplicación seleccionada.{0}{0}Tipo de Comprobante: {1}{0}Número de Comprobante: {2}{0}Importe: {3}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowData_Aplicacion_Eliminar.ComprobanteTipoNombre, GridRowData_Aplicacion_Eliminar.NumeroCompleto, FormatCurrency(GridRowData_Aplicacion_Eliminar.ImporteTotal))
            If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                mComprobanteActual.ComprobantesAplicados.Remove(GridRowData_Aplicacion_Eliminar.ComprobanteAplicacion)

                RefreshData_Aplicaciones()

                Me.Cursor = Cursors.Default
            End If
        End If

    End Sub

#End Region

#Region "Medios de Pago"

    Friend Sub RefreshDataMediosPago(Optional ByVal PositionIndice As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listMediosPago As List(Of GridRowDataMedioPago)
        Dim Total As Decimal = 0

        If RestoreCurrentPosition Then
            If datagridviewMediosPago.CurrentRow Is Nothing Then
                PositionIndice = 0
            Else
                PositionIndice = CType(datagridviewMediosPago.CurrentRow.DataBoundItem, GridRowDataMedioPago).ComprobanteMedioPago.Indice
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listMediosPago = (From cmp In mComprobanteActual.ComprobanteMediosPago
                              Join mp In mdbContext.MedioPago On cmp.IDMedioPago Equals mp.IDMedioPago
                              Select New GridRowDataMedioPago With {.ComprobanteMedioPago = cmp, .MedioPago = mp, .MedioPagoNombre = mp.Nombre, .Importe = cmp.Importe}).ToList

            datagridviewMediosPago.AutoGenerateColumns = False
            datagridviewMediosPago.DataSource = listMediosPago

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Medios de Pago.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        For Each GridRowData_MedioPagoCurrent As GridRowDataMedioPago In listMediosPago
            Total += GridRowData_MedioPagoCurrent.Importe
        Next
        currencytextboxMediosPago_Subtotal.DecimalValue = Total
        currencytextboxImporteTotal.DecimalValue = Total

        Me.Cursor = Cursors.Default

        If PositionIndice <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMediosPago.Rows
                If CType(datagridviewMediosPago.CurrentRow.DataBoundItem, GridRowDataMedioPago).ComprobanteMedioPago.Indice = PositionIndice Then
                    datagridviewMediosPago.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub MedioPagoAgregarOtro(sender As Object, e As EventArgs) Handles buttonMediosPago_AgregarOtro.Click
        Me.Cursor = Cursors.WaitCursor
        datagridviewMediosPago.Enabled = False
        If comboboxEntidad.SelectedIndex > -1 AndAlso mComprobanteActual.IDEntidad <> CType(comboboxEntidad.SelectedItem, Entidad).IDEntidad Then
            mComprobanteActual.IDEntidad = CType(comboboxEntidad.SelectedItem, Entidad).IDEntidad
        End If
        Dim ComprobanteMedioPagoNuevo As New ComprobanteMedioPago With {.FechaHora = DateTime.Now}
        formComprobanteMedioPago.LoadAndShow(True, True, Me, mComprobanteActual, ComprobanteMedioPagoNuevo)
        datagridviewMediosPago.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MedioPagoAgregarCheque(sender As Object, e As EventArgs) Handles buttonMediosPago_AgregarCheque.Click
        Me.Cursor = Cursors.WaitCursor

        datagridviewMediosPago.Enabled = False

        Dim ComprobanteMedioPagoNuevo As New ComprobanteMedioPago
        Dim ChequeNuevo As New Cheque With {
            .FechaEmision = DateTime.Today,
            .FechaPago = DateTime.Today
        }
        ComprobanteMedioPagoNuevo.Cheque = ChequeNuevo
        formCheque.LoadAndShow(True, Me, mdbContext, mComprobanteActual, ComprobanteMedioPagoNuevo)

        datagridviewMediosPago.Enabled = True

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MedioPagoEditar(sender As Object, e As EventArgs) Handles buttonMediosPago_Editar.Click
        If datagridviewMediosPago.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Medio de Pago para editar.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMediosPago.Enabled = False

            Dim ComprobanteMedioPagoActual As ComprobanteMedioPago
            Dim MedioPagoActual As MedioPago

            ComprobanteMedioPagoActual = CType(datagridviewMediosPago.SelectedRows(0).DataBoundItem, GridRowDataMedioPago).ComprobanteMedioPago
            MedioPagoActual = CType(datagridviewMediosPago.SelectedRows(0).DataBoundItem, GridRowDataMedioPago).MedioPago

            If MedioPagoActual.EsCheque Then
                formCheque.LoadAndShow(True, Me, mdbContext, mComprobanteActual, ComprobanteMedioPagoActual)
            Else
                formComprobanteMedioPago.LoadAndShow(True, True, Me, mComprobanteActual, ComprobanteMedioPagoActual)
            End If

            datagridviewMediosPago.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub MedioPago_Eliminar(sender As Object, e As EventArgs) Handles buttonMediosPago_Eliminar.Click
        If datagridviewMediosPago.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Medio de Pago para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            Dim GridRowData_MedioPago_Eliminar As GridRowDataMedioPago
            GridRowData_MedioPago_Eliminar = CType(datagridviewMediosPago.SelectedRows(0).DataBoundItem, GridRowDataMedioPago)

            Dim Mensaje As String
            Mensaje = String.Format("Se eliminará el Medio de Pago seleccionado.{0}{0}Medio de Pago: {1}{0}Importe: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowData_MedioPago_Eliminar.MedioPagoNombre, FormatCurrency(GridRowData_MedioPago_Eliminar.Importe))
            If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                mComprobanteActual.ComprobanteMediosPago.Remove(GridRowData_MedioPago_Eliminar.ComprobanteMedioPago)

                RefreshDataMediosPago()

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub MedioPago_Ver(sender As Object, e As EventArgs) Handles datagridviewMediosPago.DoubleClick
        If datagridviewMediosPago.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Medio de Pago para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMediosPago.Enabled = False

            Dim ComprobanteMedioPagoActual As ComprobanteMedioPago
            Dim MedioPagoActual As MedioPago

            ComprobanteMedioPagoActual = CType(datagridviewMediosPago.SelectedRows(0).DataBoundItem, GridRowDataMedioPago).ComprobanteMedioPago
            MedioPagoActual = CType(datagridviewMediosPago.SelectedRows(0).DataBoundItem, GridRowDataMedioPago).MedioPago

            If MedioPagoActual.EsCheque Then
                formCheque.LoadAndShow(mEditMode, Me, mdbContext, mComprobanteActual, ComprobanteMedioPagoActual)
            Else
                formComprobanteMedioPago.LoadAndShow(mEditMode, False, Me, mComprobanteActual, ComprobanteMedioPagoActual)
            End If

            datagridviewMediosPago.Enabled = True

            Me.Cursor = Cursors.Default
        End If

    End Sub

#End Region

#Region "Extra stuff"

    Private Sub CambiarTipoComprobante()
        If comboboxComprobanteTipo.SelectedIndex = -1 Then
            panelFechas.Visible = False
            _TabControlExtension.HidePage(tabcontrolMain, tabpageDescripcion)
            _TabControlExtension.HidePage(tabcontrolMain, tabpageDetalle)
            panelDetalle_Subtotal.Visible = False
            _TabControlExtension.HidePage(tabcontrolMain, tabpageAplicaciones)
            panelAplicaciones_Subtotal.Visible = False
            _TabControlExtension.HidePage(tabcontrolMain, tabpageMediosPago)
            panelMediosPago_Subtotal.Visible = False
            tabcontrolMain.SelectTab(0)
            Return
        End If

        mComprobanteTipoActual = CType(comboboxComprobanteTipo.SelectedItem, ComprobanteTipo)

        ' Verifico la asignación del número de comprobante
        If Not mComprobanteTipoActual.IDNumerador.HasValue Then
            ' No hay un numerador definido, habilito los campos de Punto de Venta y Numero
            mNumerador = Nothing
            MaskedTextBoxPuntoVenta.Text = String.Empty
            MaskedTextBoxNumero.Text = String.Empty
        Else
            ' Hay un numerador definido, así que si es un comprobante nuevo, establezco el número, como para ir mostrándolo, aunque antes de grabar, puede volver a cambiar
            Using context As New CSBomberosContext(True)
                mNumerador = context.Numerador.Find(mComprobanteTipoActual.IDNumerador.Value)
            End Using
            If mIsNew Then
                MaskedTextBoxPuntoVenta.Text = mNumerador.PuntoVentaConFormato
                MaskedTextBoxNumero.Text = mNumerador.NumeroConFormato
            End If
        End If

        ' Habilito los Controles según corresponda
        MaskedTextBoxPuntoVenta.TabStop = mNumerador Is Nothing
        MaskedTextBoxNumero.TabStop = mNumerador Is Nothing

        ' Entidades
        ListasComprobantes.LlenarComboBoxEntidades(mdbContext, comboboxEntidad, mComprobanteTipoActual.OperacionTipo, False, False)
        If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formComprobantes") Then
            Dim formComprobantes As formComprobantes = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formComprobantes"), formComprobantes)
            If formComprobantes.comboboxEntidad.SelectedIndex > 0 Then
                CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxEntidad, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, CType(formComprobantes.comboboxEntidad.SelectedItem, Entidad).IDEntidad, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            Else
                comboboxEntidad.SelectedIndex = -1
            End If
        Else
            comboboxEntidad.SelectedIndex = -1
        End If

        ' Utiliza datos de gasto
        panelDatoGasto.Visible = mComprobanteTipoActual.UtilizaDatoGasto

        ' Utiliza Descripción
        _TabControlExtension.PageVisible(tabcontrolMain, tabpageDescripcion, mComprobanteTipoActual.UtilizaDescripcion)

        ' Utiliza Detalle
        panelFechas.Visible = mComprobanteTipoActual.UtilizaDetalle
        _TabControlExtension.PageVisible(tabcontrolMain, tabpageDetalle, mComprobanteTipoActual.UtilizaDetalle)
        panelDetalle_Subtotal.Visible = mComprobanteTipoActual.UtilizaDetalle

        ' Utiliza Alicación
        _TabControlExtension.PageVisible(tabcontrolMain, tabpageAplicaciones, mComprobanteTipoActual.UtilizaAplicado OrElse mComprobanteTipoActual.UtilizaAplicante)
        panelAplicaciones_Subtotal.Visible = mComprobanteTipoActual.UtilizaAplicado OrElse mComprobanteTipoActual.UtilizaAplicante

        ' Utiliza Medio de Pago
        _TabControlExtension.PageVisible(tabcontrolMain, tabpageMediosPago, mComprobanteTipoActual.UtilizaMedioPago)
        panelMediosPago_Subtotal.Visible = mComprobanteTipoActual.UtilizaMedioPago

        ' Importe total
        currencytextboxImporteTotal.ReadOnly = (mComprobanteTipoActual.UtilizaDetalle OrElse mComprobanteTipoActual.UtilizaMedioPago OrElse Not mEditMode)
        tabcontrolMain.SelectTab(0)
    End Sub

    Private Function EstablecerValoresNuevoComprobante() As Boolean
        Try
            Using context As New CSBomberosContext(True)
                ' Calculo el nuevo ID
                If context.Comprobante.Any() Then
                    mComprobanteActual.IDComprobante = context.Comprobante.Max(Function(c) c.IDComprobante) + 1
                Else
                    mComprobanteActual.IDComprobante = 1
                End If

                ' Si corresponde, recalculo el Número del Comprobante por si otro usuario o proceso agregó un comprobante
                If mNumerador IsNot Nothing Then
                    Dim nuevoNumerador As Numerador
                    nuevoNumerador = context.Numerador.Find(mComprobanteTipoActual.IDNumerador.Value)
                    If nuevoNumerador.PuntoVenta <> mNumerador.PuntoVenta Or nuevoNumerador.Numero <> mNumerador.Numero Then
                        mNumerador = nuevoNumerador
                        MaskedTextBoxPuntoVenta.Text = mNumerador.PuntoVentaConFormato
                        MaskedTextBoxNumero.Text = mNumerador.NumeroConFormato
                    End If
                    ' Actualizo el numerador para que incremente el número anterior en 1
                    mdbContext.Numerador.Find(mNumerador.IDNumerador).Numero = mNumerador.Numero + 1
                End If
            End Using

            mComprobanteActual.IDUsuarioCreacion = pUsuario.IDUsuario
            mComprobanteActual.FechaHoraCreacion = Now
            Return True
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al establecer los valores del Comprobante nuevo.")
            Return False
        End Try

    End Function

#End Region

End Class