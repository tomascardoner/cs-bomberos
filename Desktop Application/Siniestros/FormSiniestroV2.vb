Public Class FormSiniestroV2

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mSiniestroActual As Siniestro

    Private mIsLoading As Boolean
    Private mIsNew As Boolean
    Private mEditMode As Boolean
    Private mPermisoEditarBasico As Boolean
    Private mPermisoEditarCompleto As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(EditMode As Boolean, ByRef ParentForm As Form, IDSiniestro As Integer)
        mIsLoading = True
        mEditMode = EditMode

        mIsNew = (IDSiniestro = 0)
        If mIsNew Then
            ' Es Nuevo
            mSiniestroActual = New Siniestro
            With mSiniestroActual
                .Fecha = DateTime.Today

                ' Si hay filtros aplicados en el form principal, uso esos valores como predeterminados
                If formSiniestros.comboboxCuartel.SelectedIndex > 0 Then
                    .IDCuartel = CByte(formSiniestros.comboboxCuartel.ComboBox.SelectedValue)
                End If
                If formSiniestros.comboboxSiniestroRubro.SelectedIndex > 0 Then
                    .IDSiniestroRubro = CByte(formSiniestros.comboboxSiniestroRubro.ComboBox.SelectedValue)
                End If
                If formSiniestros.comboboxSiniestroTipo.SelectedIndex > 0 Then
                    .IDSiniestroTipo = CByte(formSiniestros.comboboxSiniestroTipo.ComboBox.SelectedValue)
                End If
                If formSiniestros.comboboxClave.SelectedIndex > 0 Then
                    .IDSiniestroClave = CByte(formSiniestros.comboboxClave.ComboBox.SelectedValue)
                End If

                .UbicacionIDProvincia = CS_Parameter_System.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID)
                .UbicacionIDLocalidad = CS_Parameter_System.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID)

                .Anulado = False
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Siniestro.Add(mSiniestroActual)
        Else
            mSiniestroActual = mdbContext.Siniestro.Find(IDSiniestro)
        End If

        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()

        mIsLoading = False

        ChangeMode()

        Me.ShowDialog(ParentForm)
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Return
        End If

        '  Toolbar
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = Not mEditMode
        buttonCerrar.Visible = Not mEditMode
        buttonImprimir.Visible = Not mEditMode

        ' General
        ComboBoxCuartel.Enabled = (mEditMode AndAlso (mIsNew OrElse mSiniestroActual.SiniestrosAsistencias.Count = 0))
        maskedtextboxNumeroPrefijo.Enabled = mEditMode
        maskedtextboxNumero.Enabled = mEditMode
        buttonCodigoSiguiente.Visible = mEditMode
        datetimepickerFecha.Enabled = mEditMode
        comboboxSiniestroRubro.Enabled = mEditMode
        comboboxSiniestroTipo.Enabled = mEditMode
        textboxSiniestroTipoOtro.Enabled = mEditMode
        comboboxClave.Enabled = mEditMode
        datetimepickerHoraSalida.Enabled = mEditMode
        buttonHoraFinFinalizar.Visible = (Not mEditMode) AndAlso Not (mPermisoEditarCompleto OrElse mSiniestroActual.HoraFin.HasValue)
        datetimepickerHoraFin.Enabled = (mEditMode AndAlso mPermisoEditarCompleto)
        textboxPersonaFin.Visible = mSiniestroActual.HoraFin.HasValue
        datetimepickerHoraLlegadaUltimoCamion.Enabled = mEditMode

        CheckBoxTrasladoPorOtro.Enabled = mEditMode
        NumericUpDownTrasladoPorOtroCantidad.Enabled = mEditMode

        NumericUpDownIncendioForestalCantidadHa.Enabled = mEditMode
        NumericUpDownIncendioForestalCantidadPlanta.Enabled = mEditMode
        NumericUpDownIncendioForestalLargoMetro.Enabled = mEditMode
        NumericUpDownIncendioForestalAnchoMetro.Enabled = mEditMode
        NumericUpDownIncendioForestalSuperficieMetro.Enabled = mEditMode

        ControlPersonaEncargadoCuartel.ReadOnlyText = Not mEditMode
        ControlPersonaJefeGuardia.ReadOnlyText = Not mEditMode
        ControlPersonaRadioTelefonista.ReadOnlyText = Not mEditMode

        CheckBoxControlado.Enabled = mEditMode
        labelResumenAsistencias.Visible = Not mEditMode

        ComboBoxSolicitudForma.Enabled = mEditMode
        TextBoxSolicitanteNombre.Enabled = mEditMode
        TextBoxSolicitanteDireccion.Enabled = mEditMode
        ComboBoxSolicitanteDocumentoTipo.Enabled = mEditMode
        TextBoxSolicitanteDocumentoNumero.Enabled = mEditMode
        TextBoxSolicitanteTelefono.Enabled = mEditMode

        ComboBoxUbicacionTipo.Enabled = mEditMode
        TextBoxUbicacionDescripcion.Enabled = mEditMode
        ComboBoxUbicacionProvincia.Enabled = mEditMode
        ComboBoxUbicacionLocalidad.Enabled = mEditMode

        DataGridViewResumenAsistencias.Visible = Not mEditMode

        toolstripAsistencias.Enabled = (mEditMode AndAlso mPermisoEditarBasico)
        ToolStripDaminificados.Enabled = (mEditMode AndAlso mPermisoEditarBasico)
        ToolStripVehiculos.Enabled = (mEditMode AndAlso mPermisoEditarBasico)

        ' Notas y Auditoría
        textboxNotas.Enabled = mEditMode
        checkboxAnulado.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        ListasComunes.LlenarComboBoxCuarteles(mdbContext, ComboBoxCuartel, False, False)
        ListasSiniestros.LlenarComboBoxRubros(mdbContext, comboboxSiniestroRubro, False, False)
        ListasSiniestros.LlenarComboBoxClaves(mdbContext, comboboxClave, False, False)
        ListasSiniestros.LlenarComboBoxSolicitudFormas(mdbContext, ComboBoxSolicitudForma, False, True)
        pFillAndRefreshLists.DocumentoTipo(ComboBoxSolicitanteDocumentoTipo, True)
        ListasSiniestros.LlenarComboBoxUbicacionTipos(mdbContext, ComboBoxUbicacionTipo, False, True)
        pFillAndRefreshLists.Provincia(ComboBoxUbicacionProvincia, True)

        mPermisoEditarBasico = Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR_BASICO, False)
        mPermisoEditarCompleto = Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR_COMPLETO, False)

        LabelIncendioForestal.Font = New Font(LabelIncendioForestal.Font, FontStyle.Bold)

        LabelControlado.Visible = mPermisoEditarCompleto
        CheckBoxControlado.Visible = mPermisoEditarCompleto

        ControlPersonaEncargadoCuartel.dbContext = mdbContext
        ControlPersonaJefeGuardia.dbContext = mdbContext
        ControlPersonaRadioTelefonista.dbContext = mdbContext

        If Not mEditMode Then
            ResumenAsistenciasRefreshData()
        End If
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageSiniestro32)

        DataGridSetAppearance(DataGridViewResumenAsistencias)
        DataGridSetAppearance(DataGridViewDamnificados)
        DataGridSetAppearance(DataGridViewVehiculos)
        DataGridSetAppearance(datagridviewAsistencias)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mSiniestroActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Interface data"

    Friend Sub SetDataFromObjectToControls()
        With mSiniestroActual
            ' General
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxCuartel, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDCuartel)
            maskedtextboxNumeroPrefijo.Text = .NumeroPrefijo
            maskedtextboxNumero.Text = .Numero
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxSiniestroRubro, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IDSiniestroRubro)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxSiniestroTipo, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IDSiniestroTipo)
            textboxSiniestroTipoOtro.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.SiniestroTipoOtro)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxClave, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .IDSiniestroClave)
            datetimepickerHoraSalida.Value = CS_ValueTranslation.FromObjectTimeSpanToControlDateTimePicker(.HoraSalida, datetimepickerHoraSalida)
            datetimepickerHoraFin.Value = CS_ValueTranslation.FromObjectTimeSpanToControlDateTimePicker(.HoraFin, datetimepickerHoraFin)
            If .HoraFin.HasValue AndAlso .IDPersonaFin.HasValue Then
                textboxPersonaFin.Text = .PersonaFin.ApellidoNombre
            Else
                textboxPersonaFin.Text = String.Empty
            End If
            datetimepickerHoraLlegadaUltimoCamion.Value = CS_ValueTranslation.FromObjectTimeSpanToControlDateTimePicker(.HoraLlegadaUltimoCamion, datetimepickerHoraLlegadaUltimoCamion)

            CheckBoxTrasladoPorOtro.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.TrasladoPorOtro)
            If .TrasladoPorOtro AndAlso .TrasladoPorOtroCantidad.HasValue Then
                NumericUpDownTrasladoPorOtroCantidad.Value = .TrasladoPorOtroCantidad.Value
            Else
                NumericUpDownTrasladoPorOtroCantidad.Value = 0
            End If

            NumericUpDownIncendioForestalCantidadHa.Value = CS_ValueTranslation.FromObjectShortToControlUpDown(.IncendioForestalCantidadHa)
            NumericUpDownIncendioForestalCantidadPlanta.Value = CS_ValueTranslation.FromObjectShortToControlUpDown(.IncendioForestalCantidadPlanta)
            NumericUpDownIncendioForestalLargoMetro.Value = CS_ValueTranslation.FromObjectShortToControlUpDown(.IncendioForestalLargoMetro)
            NumericUpDownIncendioForestalAnchoMetro.Value = CS_ValueTranslation.FromObjectShortToControlUpDown(.IncendioForestalAnchoMetro)
            NumericUpDownIncendioForestalSuperficieMetro.Value = CS_ValueTranslation.FromObjectShortToControlUpDown(.IncendioForestalSuperficieMetro)

            ControlPersonaEncargadoCuartel.AsignarValores(.PersonaEncargadoCuartel)
            ControlPersonaJefeGuardia.AsignarValores(.PersonaJefeGuardia)
            ControlPersonaRadioTelefonista.AsignarValores(.PersonaRadioTelefonista)

            CheckBoxControlado.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Controlado)

            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxSolicitudForma, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IdSiniestroSolicitudForma)
            TextBoxSolicitanteNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.SolicitanteNombre)
            TextBoxSolicitanteDireccion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.SolicitanteDireccion)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxSolicitanteDocumentoTipo, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .SolicitanteIDDocumentoTipo)
            TextBoxSolicitanteDocumentoNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.SolicitanteDocumentoNumero)
            TextBoxSolicitanteTelefono.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.SolicitanteTelefono)

            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxUbicacionTipo, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IdSiniestroUbicacionTipo)
            TextBoxUbicacionDescripcion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.UbicacionDescripcion)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxUbicacionProvincia, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .UbicacionIDProvincia)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxUbicacionLocalidad, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .UbicacionIDLocalidad)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxAnulado.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Anulado)
            If .IDSiniestro = 0 Then
                textboxIDSiniestro.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDSiniestro.Text = String.Format(.IDSiniestro.ToString, "G")
            End If
            textboxFechaHoraCreacion.Text = .FechaHoraCreacion.ToShortDateString & " " & .FechaHoraCreacion.ToShortTimeString
            If .UsuarioCreacion Is Nothing Then
                textboxUsuarioCreacion.Text = ""
            Else
                textboxUsuarioCreacion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.UsuarioCreacion.Descripcion)
            End If
            textboxFechaHoraModificacion.Text = .FechaHoraModificacion.ToShortDateString & " " & .FechaHoraModificacion.ToShortTimeString
            If .UsuarioModificacion Is Nothing Then
                textboxUsuarioModificacion.Text = ""
            Else
                textboxUsuarioModificacion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.UsuarioModificacion.Descripcion)
            End If

            AsistenciasRefreshData()
            DamnificadosRefreshData()
            VehiculosRefreshData()
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mSiniestroActual
            .IDCuartel = CS_ValueTranslation.FromControlComboBoxToObjectByte(ComboBoxCuartel.SelectedValue).Value
            .NumeroPrefijo = maskedtextboxNumeroPrefijo.Text
            .Numero = maskedtextboxNumero.Text
            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFecha.Value).Value
            .IDSiniestroRubro = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxSiniestroRubro.SelectedValue).Value
            .IDSiniestroTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxSiniestroTipo.SelectedValue).Value
            .SiniestroTipoOtro = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxSiniestroTipoOtro.Text)
            .IDSiniestroClave = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxClave.SelectedValue).Value
            .HoraSalida = CS_ValueTranslation.FromControlDateTimePickerToObjectTimeSpan(datetimepickerHoraSalida.Value, datetimepickerHoraSalida.Checked)
            .HoraFin = CS_ValueTranslation.FromControlDateTimePickerToObjectTimeSpan(datetimepickerHoraFin.Value, datetimepickerHoraFin.Checked)
            .HoraLlegadaUltimoCamion = CS_ValueTranslation.FromControlDateTimePickerToObjectTimeSpan(datetimepickerHoraLlegadaUltimoCamion.Value, datetimepickerHoraLlegadaUltimoCamion.Checked)

            .TrasladoPorOtro = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(CheckBoxTrasladoPorOtro.CheckState)
            If CheckBoxTrasladoPorOtro.CheckState = CheckState.Checked Then
                .TrasladoPorOtroCantidad = CS_ValueTranslation.FromControlUpDownToObjectByte(NumericUpDownTrasladoPorOtroCantidad.Value)
            Else
                .TrasladoPorOtroCantidad = Nothing
            End If

            .IncendioForestalCantidadHa = CS_ValueTranslation.FromControlUpDownToObjectShort(NumericUpDownIncendioForestalCantidadHa.Value)
            .IncendioForestalCantidadPlanta = CS_ValueTranslation.FromControlUpDownToObjectShort(NumericUpDownIncendioForestalCantidadPlanta.Value)
            .IncendioForestalLargoMetro = CS_ValueTranslation.FromControlUpDownToObjectShort(NumericUpDownIncendioForestalLargoMetro.Value)
            .IncendioForestalAnchoMetro = CS_ValueTranslation.FromControlUpDownToObjectShort(NumericUpDownIncendioForestalAnchoMetro.Value)
            .IncendioForestalSuperficieMetro = CS_ValueTranslation.FromControlUpDownToObjectShort(NumericUpDownIncendioForestalSuperficieMetro.Value)

            .EncargadoCuartelIDPersona = ControlPersonaEncargadoCuartel.IDPersona
            .JefeGuardiaIDPersona = ControlPersonaJefeGuardia.IDPersona
            .RadioTelefonistaIDPersona = ControlPersonaRadioTelefonista.IDPersona

            .Controlado = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(CheckBoxControlado.CheckState)

            .IdSiniestroSolicitudForma = CS_ValueTranslation.FromControlComboBoxToObjectByte(ComboBoxSolicitudForma.SelectedValue)
            .SolicitanteNombre = CS_ValueTranslation.FromControlTextBoxToObjectString(TextBoxSolicitanteNombre.Text)
            .SolicitanteDireccion = CS_ValueTranslation.FromControlTextBoxToObjectString(TextBoxSolicitanteDireccion.Text)
            .SolicitanteIDDocumentoTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(ComboBoxSolicitanteDocumentoTipo.SelectedValue)
            .SolicitanteDocumentoNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(TextBoxSolicitanteDocumentoNumero.Text)
            .SolicitanteTelefono = CS_ValueTranslation.FromControlTextBoxToObjectString(TextBoxSolicitanteTelefono.Text)

            .IdSiniestroUbicacionTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(ComboBoxUbicacionTipo.SelectedValue)
            .UbicacionDescripcion = CS_ValueTranslation.FromControlTextBoxToObjectString(TextBoxUbicacionDescripcion.Text)
            .UbicacionIDProvincia = CS_ValueTranslation.FromControlComboBoxToObjectByte(ComboBoxUbicacionProvincia.SelectedValue)
            .UbicacionIDLocalidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(ComboBoxUbicacionLocalidad.SelectedValue)

            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
            .Anulado = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxAnulado.CheckState)
        End With
    End Sub

#End Region

#Region "Controls events"

    Private Sub Form_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Return)
                If mEditMode Then
                    buttonGuardar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
            Case ChrW(Keys.Escape)
                If mEditMode Then
                    buttonCancelar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
        End Select
    End Sub

    Private Sub Controls_GotFocus(sender As Object, e As EventArgs) Handles maskedtextboxNumeroPrefijo.GotFocus, maskedtextboxNumero.GotFocus, textboxSiniestroTipoOtro.GotFocus, NumericUpDownIncendioForestalCantidadHa.GotFocus, NumericUpDownIncendioForestalCantidadPlanta.GotFocus, TextBoxSolicitanteNombre.GotFocus, TextBoxSolicitanteDireccion.GotFocus, TextBoxSolicitanteDocumentoNumero.GotFocus, TextBoxSolicitanteTelefono.GotFocus, TextBoxUbicacionDescripcion.GotFocus, textboxNotas.GotFocus, NumericUpDownTrasladoPorOtroCantidad.Enter, NumericUpDownIncendioForestalSuperficieMetro.Enter, NumericUpDownIncendioForestalLargoMetro.Enter, NumericUpDownIncendioForestalCantidadPlanta.Enter, NumericUpDownIncendioForestalCantidadHa.Enter, NumericUpDownIncendioForestalAnchoMetro.Enter
        Common.SelectAllText(sender)
    End Sub

    Private Sub MaskedtextboxNumeroPrefijo_LostFocus(sender As Object, e As EventArgs) Handles maskedtextboxNumeroPrefijo.LostFocus
        maskedtextboxNumeroPrefijo.Text = maskedtextboxNumeroPrefijo.Text.PadLeft(Constantes.SINIESTRO_NUMEROPREFIJO_DIGITOS, "0"c)
    End Sub

    Private Sub MaskedtextboxNumero_LostFocus(sender As Object, e As EventArgs) Handles maskedtextboxNumero.LostFocus
        maskedtextboxNumero.Text = maskedtextboxNumero.Text.PadLeft(Constantes.SINIESTRO_NUMERO_DIGITOS, "0"c)
    End Sub

    Private Sub Cuartel_Cambio(sender As Object, e As EventArgs) Handles ComboBoxCuartel.SelectedValueChanged
        If ComboBoxCuartel.SelectedValue IsNot Nothing Then
            ControlPersonaEncargadoCuartel.IDCuartel = CType(ComboBoxCuartel.SelectedItem, Cuartel).IDCuartel
            ControlPersonaJefeGuardia.IDCuartel = CType(ComboBoxCuartel.SelectedItem, Cuartel).IDCuartel
            ControlPersonaRadioTelefonista.IDCuartel = CType(ComboBoxCuartel.SelectedItem, Cuartel).IDCuartel
        End If
    End Sub

    Private Sub CodigoSiguiente_Click(sender As Object, e As EventArgs) Handles buttonCodigoSiguiente.Click
        If ComboBoxCuartel.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Cuartel .", MsgBoxStyle.Information, My.Application.Info.Title)
            ComboBoxCuartel.Focus()
            Return
        End If

        Dim cuartel As Cuartel
        cuartel = CType(ComboBoxCuartel.SelectedItem, Cuartel)
        If cuartel.PrefijoSiniestro IsNot Nothing Then
            maskedtextboxNumeroPrefijo.Text = cuartel.PrefijoSiniestro
        End If

        If maskedtextboxNumeroPrefijo.Text.Length = 0 Then
            MsgBox("Debe ingresar el Prefijo del Número.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxNumeroPrefijo.Focus()
            Return
        End If

        Dim idCuartel As Byte = CByte(ComboBoxCuartel.SelectedValue)
        Dim numeroSiguiente As Integer

        If mdbContext.Siniestro.Any(Function(s) s.IDCuartel = idCuartel) Then
            Dim numeroUltimo As String

            numeroUltimo = mdbContext.Siniestro.Where(Function(s) s.IDCuartel = idCuartel AndAlso s.NumeroPrefijo = maskedtextboxNumeroPrefijo.Text).Max(Function(s) s.Numero)
            numeroSiguiente = CInt(numeroUltimo) + 1
        Else
            numeroSiguiente = 1
        End If

        maskedtextboxNumero.Text = numeroSiguiente.ToString().PadLeft(Constantes.SINIESTRO_NUMERO_DIGITOS, "0"c)
    End Sub

    Private Sub SiniestroRubroCambio(sender As Object, e As EventArgs) Handles comboboxSiniestroRubro.SelectedIndexChanged
        If comboboxSiniestroRubro.SelectedIndex >= 0 Then
            ListasSiniestros.LlenarComboBoxTipos(mdbContext, comboboxSiniestroTipo, CType(comboboxSiniestroRubro.SelectedItem, SiniestroRubro).IDSiniestroRubro, False, False)
        End If
    End Sub

    Private Sub SiniestroTipoCambio(sender As Object, e As EventArgs) Handles comboboxSiniestroTipo.SelectedIndexChanged
        If comboboxSiniestroTipo.SelectedIndex > -1 Then
            Dim siniestroTipoActual As SiniestroTipo = CType(comboboxSiniestroTipo.SelectedItem, SiniestroTipo)
            Dim siniestroTipoIncendioForestal As Boolean

            labelSiniestroTipoOtro.Visible = (siniestroTipoActual.IDSiniestroTipo = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE)
            textboxSiniestroTipoOtro.Visible = (siniestroTipoActual.IDSiniestroTipo = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE)
            If siniestroTipoActual.IDSiniestroClave.HasValue Then
                CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxClave, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, siniestroTipoActual.IDSiniestroClave)
            End If

            siniestroTipoIncendioForestal = siniestroTipoActual.IDSiniestroRubro = CS_Parameter_System.GetIntegerAsByte(Parametros.SINIESTRO_RUBRO_ID_INCENDIO) AndAlso siniestroTipoActual.IDSiniestroTipo = CS_Parameter_System.GetIntegerAsByte(Parametros.SINIESTRO_TIPO_ID_INCENDIO_FORESTAL)
            LabelIncendioForestal.Visible = siniestroTipoIncendioForestal
            LabelIncendioForestalCantidad.Visible = siniestroTipoIncendioForestal
            LabelIncendioForestalCantidadHa.Visible = siniestroTipoIncendioForestal
            NumericUpDownIncendioForestalCantidadHa.Visible = siniestroTipoIncendioForestal
            LabelIncendioForestalCantidadPlanta.Visible = siniestroTipoIncendioForestal
            NumericUpDownIncendioForestalCantidadPlanta.Visible = siniestroTipoIncendioForestal
            LabelIncendioForestalMedida.Visible = siniestroTipoIncendioForestal
            LabelIncendioForestalLargoMetro.Visible = siniestroTipoIncendioForestal
            NumericUpDownIncendioForestalLargoMetro.Visible = siniestroTipoIncendioForestal
            LabelIncendioForestalAnchoMetro.Visible = siniestroTipoIncendioForestal
            NumericUpDownIncendioForestalAnchoMetro.Visible = siniestroTipoIncendioForestal
            LabelIncendioForestalSuperficieMetro.Visible = siniestroTipoIncendioForestal
            NumericUpDownIncendioForestalSuperficieMetro.Visible = siniestroTipoIncendioForestal
        Else
            labelSiniestroTipoOtro.Visible = False
            textboxSiniestroTipoOtro.Visible = False
        End If
    End Sub

    Private Sub FinalizarSiniestro(sender As Object, e As EventArgs) Handles buttonHoraFinFinalizar.Click
        Dim IdSiniestroAsistenciaTipoSalidaAnticipada As Byte
        Dim IdSiniestroAsistenciaTipoPresente As Byte

        IdSiniestroAsistenciaTipoSalidaAnticipada = CS_Parameter_System.GetIntegerAsByte(Parametros.SINIESTRO_ASISTENCIATIPO_SALIDAANTICIPADA_ID, 0)
        If IdSiniestroAsistenciaTipoSalidaAnticipada = 0 Then
            MessageBox.Show("No se puede finalizar y asistir porque no está especificado el ID de asistencia para Salida Anticipada.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        IdSiniestroAsistenciaTipoPresente = CS_Parameter_System.GetIntegerAsByte(Parametros.SINIESTRO_ASISTENCIATIPO_PRESENTE_ID, 0)
        If IdSiniestroAsistenciaTipoPresente = 0 Then
            MessageBox.Show("No se puede finalizar y asistir porque no está especificado el ID de asistencia para Presente.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not (Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR_BASICO, False) OrElse Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR_COMPLETO, False)) Then
            Permisos.MostrarMensajeDeAviso()
            Return
        End If

        Dim finalizar As New formSiniestroFinalizar()
        finalizar.SetInitData(IdSiniestroAsistenciaTipoSalidaAnticipada, IdSiniestroAsistenciaTipoPresente, mdbContext, mSiniestroActual)
        If finalizar.ShowDialog(Me) = DialogResult.Yes Then
            ChangeMode()
            SetDataFromObjectToControls()
            RefreshLists.Siniestros(mSiniestroActual.IDSiniestro)
        End If
        finalizar.Close()
        finalizar = Nothing
    End Sub

    Private Sub CheckBoxTrasladoPorOtro_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTrasladoPorOtro.CheckedChanged
        NumericUpDownTrasladoPorOtroCantidad.Visible = CheckBoxTrasladoPorOtro.CheckState = CheckState.Checked
    End Sub

    Private Sub UbicacionProvincia_Cambiar(sender As Object, e As EventArgs) Handles ComboBoxUbicacionProvincia.SelectedValueChanged
        If ComboBoxUbicacionProvincia.SelectedValue Is Nothing Then
            pFillAndRefreshLists.Localidad(ComboBoxUbicacionLocalidad, 0, True)
            ComboBoxUbicacionLocalidad.SelectedIndex = 0
        Else
            pFillAndRefreshLists.Localidad(ComboBoxUbicacionLocalidad, CByte(ComboBoxUbicacionProvincia.SelectedValue), True)
            If CByte(ComboBoxUbicacionProvincia.SelectedValue) = CS_Parameter_System.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID) Then
                CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxUbicacionLocalidad, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, CS_Parameter_System.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID))
            End If
        End If
    End Sub

#End Region

#Region "Main toolbar events"

    Private Sub Editar(sender As Object, e As EventArgs) Handles buttonEditar.Click
        If Not (Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR_BASICO, False) OrElse Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR_COMPLETO, False)) Then
            Permisos.MostrarMensajeDeAviso()
            Return
        End If

        mEditMode = True
        ChangeMode()
    End Sub

    Private Sub CerrarOCancelar(sender As Object, e As EventArgs) Handles buttonCerrar.Click, buttonCancelar.Click
        If mdbContext.ChangeTracker.HasChanges Then
            If MsgBox(String.Format("Ha realizado cambios en los datos y seleccionó cancelar, los cambios se perderán.{0}{0}¿Confirma la pérdida de los cambios?", vbCrLf), CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Guardar(sender As Object, e As EventArgs) Handles buttonGuardar.Click
        If Not VerificarDatos() Then
            Return
        End If

        ' Generar el ID nuevo
        If mIsNew Then
            If mdbContext.Siniestro.Any() Then
                mSiniestroActual.IDSiniestro = mdbContext.Siniestro.Max(Function(s) s.IDSiniestro) + 1
            Else
                mSiniestroActual.IDSiniestro = 1
            End If
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mSiniestroActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mSiniestroActual.FechaHoraModificacion = Now

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                RefreshLists.Siniestros(mSiniestroActual.IDSiniestro)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        TabControlMain.SelectedTab = TabPageEncabezado
                        MsgBox("No se pueden guardar los cambios porque ya existe un Siniestro con el mismo Cuartel y Número.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Case CardonerSistemas.Database.EntityFramework.Errors.PrimaryKeyViolation
                        TabControlMain.SelectedTab = tabpageAsistencias
                        MsgBox("No se pueden guardar los cambios porque existe una Asistencia al Siniestro duplicada para una Persona.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Case Else
                        CardonerSistemas.ErrorHandler.ProcessError(CType(dbuex, Exception), My.Resources.STRING_ERROR_SAVING_CHANGES)
                End Select
                Return

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Return
            End Try
        End If

        If mIsNew AndAlso mSiniestroActual.SiniestroClave.Grupo = Constantes.SINIESTRO_CLAVEGRUPO_ROJA Then
            Try
                mdbContext.SiniestroAgregarAsistenciaDePersonas(mSiniestroActual.IDSiniestro, pUsuario.IDUsuario)
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al agregar las asistencias de Licencias y Sanciones al Siniestro.")
            End Try
        End If

        Me.Close()
    End Sub

#End Region

#Region "Damnificados"

    Friend Class DamnificadosGridRowData
        Public Property IdDamnificado As Byte
        Public Property ApellidoNombre As String
        Public Property Edad As Byte?
        Public Property EstadoNombre As String
    End Class

    Friend Sub DamnificadosRefreshData(Optional idDamnificado As Byte = 0, Optional restoreCurrentPosition As Boolean = False)
        Dim damnificados As List(Of DamnificadosGridRowData)

        If restoreCurrentPosition Then
            If DataGridViewDamnificados.CurrentRow Is Nothing Then
                idDamnificado = 0
            Else
                idDamnificado = CType(DataGridViewDamnificados.CurrentRow.DataBoundItem, DamnificadosGridRowData).IdDamnificado
            End If
        End If

        Cursor = Cursors.WaitCursor

        Try
            damnificados = (From sd In mSiniestroActual.SiniestroDamnificados
                            Join sde In mdbContext.SiniestroDamnificadoEstado On sd.IdSiniestroDaminificadoEstado Equals sde.IdSiniestroDamnificadoEstado
                            Order By sd.Apellido, sd.Nombre
                            Select New DamnificadosGridRowData With {.IdDamnificado = sd.IdDamnificado, .ApellidoNombre = sd.Apellido & ", " & sd.Nombre, .Edad = sd.Edad, .EstadoNombre = sde.Nombre}).ToList()

            DataGridViewDamnificados.AutoGenerateColumns = False
            DataGridViewDamnificados.DataSource = damnificados

            Select Case damnificados.Count
                Case 0
                    ToolStripStatusLabelDamnificados.Text = String.Format("No hay Damnificados para mostrar.")
                Case 1
                    ToolStripStatusLabelDamnificados.Text = String.Format("Se muestra 1 Damnificado.")
                Case Else
                    ToolStripStatusLabelDamnificados.Text = String.Format("Se muestran {0} Damnificados.", damnificados.Count)
            End Select

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Damnificados del Siniestro.")
            Cursor = Cursors.Default
            Return
        End Try

        Cursor = Cursors.Default

        If idDamnificado <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In DataGridViewDamnificados.Rows
                If CType(CurrentRowChecked.DataBoundItem, DamnificadosGridRowData).IdDamnificado = idDamnificado Then
                    DataGridViewDamnificados.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub DamnificadosAgregar(sender As Object, e As EventArgs) Handles ToolStripButtonDamnificadosAgregar.Click
        Cursor = Cursors.WaitCursor
        FormSiniestroDamnificado.LoadAndShow(True, True, Me, mSiniestroActual, 0)
        Cursor = Cursors.Default
    End Sub

    Private Sub DamnificadosEditar(sender As Object, e As EventArgs) Handles ToolStripButtonDamnificadosEditar.Click
        If DataGridViewDamnificados.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Damnificado para editar.", vbInformation, My.Application.Info.Title)
            Return
        End If
        Cursor = Cursors.WaitCursor
        FormSiniestroDamnificado.LoadAndShow(True, True, Me, mSiniestroActual, CType(DataGridViewDamnificados.SelectedRows(0).DataBoundItem, DamnificadosGridRowData).IdDamnificado)
        Cursor = Cursors.Default
    End Sub

    Private Sub DamnificadosEliminar(sender As Object, e As EventArgs) Handles ToolStripButtonDamnificadosBorrar.Click
        If DataGridViewDamnificados.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Damnificado para eliminar.", vbInformation, My.Application.Info.Title)
            Return
        End If
        Dim row As DamnificadosGridRowData
        Dim Mensaje As String
        Dim siniestroDamnificado As SiniestroDamnificado

        row = CType(DataGridViewDamnificados.SelectedRows(0).DataBoundItem, DamnificadosGridRowData)
        Mensaje = String.Format("Se eliminará el Damnificado.{0}{0}Apellido y nombre: {1}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, row.ApellidoNombre)
        If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
            Cursor = Cursors.WaitCursor
            siniestroDamnificado = mSiniestroActual.SiniestroDamnificados.FirstOrDefault(Function(sd) sd.IdDamnificado = row.IdDamnificado)
            If siniestroDamnificado IsNot Nothing Then
                mSiniestroActual.SiniestroDamnificados.Remove(siniestroDamnificado)
            End If
            DamnificadosRefreshData()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub DamnificadosVer(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDamnificados.CellDoubleClick
        If DataGridViewDamnificados.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Damnificado para ver.", vbInformation, My.Application.Info.Title)
            Return
        End If
        Cursor = Cursors.WaitCursor
        FormSiniestroDamnificado.LoadAndShow(mEditMode, False, Me, mSiniestroActual, CType(DataGridViewDamnificados.SelectedRows(0).DataBoundItem, DamnificadosGridRowData).IdDamnificado)
        Cursor = Cursors.Default
    End Sub

#End Region

#Region "Vehículos"

    Friend Class VehiculosGridRowData
        Public Property IdVehiculo As Byte
        Public Property TipoNombre As String
        Public Property MarcaNombre As String
        Public Property Modelo As String
        Public Property Dominio As String
    End Class

    Friend Sub VehiculosRefreshData(Optional idVehiculo As Byte = 0, Optional restoreCurrentPosition As Boolean = False)
        Dim vehiculos As List(Of VehiculosGridRowData)

        If restoreCurrentPosition Then
            If DataGridViewVehiculos.CurrentRow Is Nothing Then
                idVehiculo = 0
            Else
                idVehiculo = CType(DataGridViewVehiculos.CurrentRow.DataBoundItem, VehiculosGridRowData).IdVehiculo
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            vehiculos = (From sv In mSiniestroActual.SiniestroVehiculos
                         Join svt In mdbContext.SiniestroVehiculoTipo On sv.IdSiniestroVehiculoTipo Equals svt.IdSiniestroVehiculoTipo
                         Join svm In mdbContext.SiniestroVehiculoMarca On sv.IdSiniestroVehiculoMarca Equals svm.IdSiniestroVehiculoMarca
                         Order By svt.Nombre, svm.Nombre
                         Select New VehiculosGridRowData With {.IdVehiculo = sv.IdVehiculo, .TipoNombre = svt.Nombre, .MarcaNombre = svm.Nombre, .Modelo = sv.Modelo, .Dominio = sv.Dominio}).ToList()

            DataGridViewVehiculos.AutoGenerateColumns = False
            DataGridViewVehiculos.DataSource = vehiculos

            Select Case vehiculos.Count
                Case 0
                    ToolStripStatusLabelVehiculos.Text = String.Format("No hay Vehículos para mostrar.")
                Case 1
                    ToolStripStatusLabelVehiculos.Text = String.Format("Se muestra 1 Vehículo.")
                Case Else
                    ToolStripStatusLabelVehiculos.Text = String.Format("Se muestran {0} Vehículos.", vehiculos.Count)
            End Select

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Vehículos del Siniestro.")
            Me.Cursor = Cursors.Default
            Return
        End Try

        Me.Cursor = Cursors.Default

        If idVehiculo <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In DataGridViewVehiculos.Rows
                If CType(CurrentRowChecked.DataBoundItem, VehiculosGridRowData).IdVehiculo = idVehiculo Then
                    DataGridViewVehiculos.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub VehiculosAgregar(sender As Object, e As EventArgs) Handles ToolStripButtonVehiculosAgregar.Click
        Me.Cursor = Cursors.WaitCursor
        FormSiniestroVehiculo.LoadAndShow(True, True, Me, mSiniestroActual, 0)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub VehiculosEditar(sender As Object, e As EventArgs) Handles ToolStripButtonVehiculosEditar.Click
        If DataGridViewVehiculos.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Vehículo para editar.", vbInformation, My.Application.Info.Title)
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        FormSiniestroVehiculo.LoadAndShow(True, True, Me, mSiniestroActual, CType(DataGridViewVehiculos.SelectedRows(0).DataBoundItem, VehiculosGridRowData).IdVehiculo)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub VehiculosEliminar(sender As Object, e As EventArgs) Handles ToolStripButtonVehiculosBorrar.Click
        If DataGridViewVehiculos.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Vehículo para eliminar.", vbInformation, My.Application.Info.Title)
            Return
        End If
        Dim row As VehiculosGridRowData
        Dim Mensaje As String
        Dim siniestroVehiculo As SiniestroVehiculo

        row = CType(DataGridViewVehiculos.SelectedRows(0).DataBoundItem, VehiculosGridRowData)
        Mensaje = String.Format("Se eliminará el Vehículo.{0}{0}Tipo: {1}{0}Marca: {2}{0}Modelo: {3}{0}Dominio: {4}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, row.TipoNombre, row.MarcaNombre, row.Modelo, row.Dominio)
        If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            siniestroVehiculo = mSiniestroActual.SiniestroVehiculos.FirstOrDefault(Function(sd) sd.IdVehiculo = row.IdVehiculo)
            If siniestroVehiculo IsNot Nothing Then
                mSiniestroActual.SiniestroVehiculos.Remove(siniestroVehiculo)
            End If
            VehiculosRefreshData()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub VehiculosVer(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewVehiculos.CellDoubleClick
        If DataGridViewVehiculos.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Vehículo para ver.", vbInformation, My.Application.Info.Title)
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        FormSiniestroVehiculo.LoadAndShow(mEditMode, False, Me, mSiniestroActual, CType(DataGridViewVehiculos.SelectedRows(0).DataBoundItem, VehiculosGridRowData).IdVehiculo)
        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "Asistencias"

    Friend Class AsistenciasGridRowData
        Public Property IDPersona As Integer
        Public Property ApellidoNombre As String
        Public Property IDSiniestroAsistenciaTipo As Byte
        Public Property SiniestroAsistenciaTipoNombre As String
    End Class

    Friend Sub AsistenciasRefreshData(Optional ByVal PositionIDPersona As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listAsistencias As List(Of AsistenciasGridRowData)

        If RestoreCurrentPosition Then
            If datagridviewAsistencias.CurrentRow Is Nothing Then
                PositionIDPersona = 0
            Else
                PositionIDPersona = CType(datagridviewAsistencias.CurrentRow.DataBoundItem, AsistenciasGridRowData).IDPersona
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listAsistencias = (From sa In mSiniestroActual.SiniestrosAsistencias
                               Join p In mdbContext.Persona On sa.IDPersona Equals p.IDPersona
                               Join sat In mdbContext.SiniestroAsistenciaTipo On sa.IDSiniestroAsistenciaTipo Equals sat.IDSiniestroAsistenciaTipo
                               Order By p.ApellidoNombre
                               Select New AsistenciasGridRowData With {.IDPersona = sa.IDPersona, .ApellidoNombre = p.ApellidoNombre, .IDSiniestroAsistenciaTipo = sa.IDSiniestroAsistenciaTipo, .SiniestroAsistenciaTipoNombre = sat.Nombre}).ToList

            datagridviewAsistencias.AutoGenerateColumns = False
            datagridviewAsistencias.DataSource = listAsistencias

            Select Case listAsistencias.Count
                Case 0
                    ToolStripStatusLabelAsistencias.Text = String.Format("No hay Asistencias para mostrar.")
                Case 1
                    ToolStripStatusLabelAsistencias.Text = String.Format("Se muestra 1 Asistencia.")
                Case Else
                    ToolStripStatusLabelAsistencias.Text = String.Format("Se muestran {0} Asistencias.", listAsistencias.Count)
            End Select

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Asistencias del Siniestro.")
            Me.Cursor = Cursors.Default
            Return
        End Try

        Me.Cursor = Cursors.Default

        If PositionIDPersona <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewAsistencias.Rows
                If CType(CurrentRowChecked.DataBoundItem, AsistenciasGridRowData).IDPersona = PositionIDPersona Then
                    datagridviewAsistencias.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub AsistenciasAgregar(sender As Object, e As EventArgs) Handles buttonAsistenciasAgregar.Click
        Me.Cursor = Cursors.WaitCursor
        formSiniestroAsistencia.LoadAndShow(True, True, Me, mSiniestroActual, 0, CByte(ComboBoxCuartel.SelectedValue), ComboBoxCuartel.Text, maskedtextboxNumeroPrefijo.Text & "-" & maskedtextboxNumero.Text, datetimepickerFecha.Value.ToShortDateString())
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub AsistenciasEditar(sender As Object, e As EventArgs) Handles buttonAsistenciasEditar.Click
        If datagridviewAsistencias.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Asistencia para editar.", vbInformation, My.Application.Info.Title)
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        formSiniestroAsistencia.LoadAndShow(True, True, Me, mSiniestroActual, CType(datagridviewAsistencias.SelectedRows(0).DataBoundItem, AsistenciasGridRowData).IDPersona, CByte(ComboBoxCuartel.SelectedValue), ComboBoxCuartel.Text, maskedtextboxNumeroPrefijo.Text & "-" & maskedtextboxNumero.Text, datetimepickerFecha.Value.ToShortDateString())
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub AsistenciasEliminar(sender As Object, e As EventArgs) Handles buttonAsistenciasEliminar.Click
        If datagridviewAsistencias.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Asistencia para eliminar.", vbInformation, My.Application.Info.Title)
            Return
        End If
        Dim GridRowDataActual As AsistenciasGridRowData
        Dim Mensaje As String

        GridRowDataActual = CType(datagridviewAsistencias.SelectedRows(0).DataBoundItem, AsistenciasGridRowData)
        Mensaje = String.Format("Se eliminará la Asistencia. Si está por eliminar una Asistencia duplicada de una Persona, tenga en cuenta que se eliminará la primera de la lista, y no necesariemente la que usted seleccionó. Verifique los datos luego de eliminar.{0}{0}Persona: {1}{0}Asistencia: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.ApellidoNombre, GridRowDataActual.SiniestroAsistenciaTipoNombre)
        If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            mSiniestroActual.SiniestrosAsistencias.Remove(mSiniestroActual.SiniestrosAsistencias.First(Function(sa) sa.IDPersona = GridRowDataActual.IDPersona))
            AsistenciasRefreshData()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub AsistenciasVer(sender As Object, e As EventArgs) Handles datagridviewAsistencias.DoubleClick
        If datagridviewAsistencias.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Asistencia para ver.", vbInformation, My.Application.Info.Title)
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        formSiniestroAsistencia.LoadAndShow(mEditMode, False, Me, mSiniestroActual, CType(datagridviewAsistencias.SelectedRows(0).DataBoundItem, AsistenciasGridRowData).IDPersona, CByte(ComboBoxCuartel.SelectedValue), ComboBoxCuartel.Text, maskedtextboxNumeroPrefijo.Text & "-" & maskedtextboxNumero.Text, datetimepickerFecha.Value.ToShortDateString())
        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "Resumen"

    Public Class ResumenAsistenciasGridRowData
        Public Property AsistenciaTipoNombre As String
        Public Property Cantidad As Integer
    End Class

    Private Sub ResumenAsistenciasRefreshData()
        Dim listResumen As List(Of ResumenAsistenciasGridRowData)

        Me.Cursor = Cursors.WaitCursor

        Try
            listResumen = (From sa In mdbContext.SiniestroAsistencia
                           Join sat In mdbContext.SiniestroAsistenciaTipo On sa.IDSiniestroAsistenciaTipo Equals sat.IDSiniestroAsistenciaTipo
                           Where sa.IDSiniestro = mSiniestroActual.IDSiniestro
                           Group By AsistenciaTipoNombre = sat.Nombre Into sa_group = Group, Count()
                           Select New ResumenAsistenciasGridRowData With {.AsistenciaTipoNombre = AsistenciaTipoNombre, .Cantidad = sa_group.Count}).ToList

            DataGridViewResumenAsistencias.AutoGenerateColumns = False
            DataGridViewResumenAsistencias.DataSource = listResumen

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Cantidades de Asistencias al Siniestro.")
            Me.Cursor = Cursors.Default
            Return
        End Try

        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        If ComboBoxCuartel.SelectedValue Is Nothing Then
            TabControlMain.SelectedTab = TabPageEncabezado
            MsgBox("Debe especificar el Cuartel.", MsgBoxStyle.Information, My.Application.Info.Title)
            ComboBoxCuartel.Focus()
            Return False
        End If
        If maskedtextboxNumeroPrefijo.Text.Length = 0 Then
            TabControlMain.SelectedTab = TabPageEncabezado
            MsgBox("Debe ingresar el Prefijo del Número.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxNumeroPrefijo.Focus()
            Return False
        End If
        If maskedtextboxNumero.Text.Length = 0 Then
            TabControlMain.SelectedTab = TabPageEncabezado
            MsgBox("Debe ingresar el Número.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxNumero.Focus()
            Return False
        End If
        If comboboxSiniestroRubro.SelectedValue Is Nothing Then
            TabControlMain.SelectedTab = TabPageEncabezado
            MsgBox("Debe especificar el Rubro y Tipo de Siniestro.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxSiniestroRubro.Focus()
            Return False
        End If
        If comboboxSiniestroTipo.SelectedValue Is Nothing Then
            TabControlMain.SelectedTab = TabPageEncabezado
            MsgBox("Debe especificar el Tipo de Siniestro.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxSiniestroTipo.Focus()
            Return False
        End If
        If comboboxClave.SelectedValue Is Nothing Then
            TabControlMain.SelectedTab = TabPageEncabezado
            MsgBox("Debe especificar la Clave del Siniestro.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxClave.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class
