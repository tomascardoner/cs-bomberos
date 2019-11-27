Public Class formPersona

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaActual As Persona

    Private mIsLoading As Boolean = False
    Private mIsNew As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer)
        mIsLoading = True
        mIsNew = (IDPersona = 0)
        mEditMode = EditMode

        If mIsNew Then
            ' Es Nuevo
            mPersonaActual = New Persona
            With mPersonaActual
                .DomicilioParticularIDProvincia = CS_Parameter_System.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID)
                .DomicilioParticularIDLocalidad = CS_Parameter_System.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID)
                .DomicilioParticularCodigoPostal = CS_Parameter_System.GetString(Parametros.DEFAULT_CODIGOPOSTAL)
                .DomicilioLaboralIDProvincia = CS_Parameter_System.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID)
                .DomicilioLaboralIDLocalidad = CS_Parameter_System.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID)
                .DomicilioLaboralCodigoPostal = CS_Parameter_System.GetString(Parametros.DEFAULT_CODIGOPOSTAL)
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Persona.Add(mPersonaActual)
        Else
            mPersonaActual = mdbContext.Persona.Find(IDPersona)
        End If

        Me.MdiParent = pFormMDIMain
        CS_Form.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
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

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        If mEditMode Then
            pictureboxFoto.ContextMenuStrip = menustripFoto
        Else
            pictureboxFoto.ContextMenuStrip = Nothing
        End If
        textboxMatriculaNumero.ReadOnly = (mEditMode = False)
        textboxApellido.ReadOnly = (mEditMode = False)
        textboxNombre.ReadOnly = (mEditMode = False)

        ' General
        comboboxDocumentoTipo.Enabled = mEditMode
        textboxDocumentoNumero.ReadOnly = (mEditMode = False)
        maskedtextboxDocumentoNumero.ReadOnly = (mEditMode = False)
        datetimepickerFechaNacimiento.Enabled = mEditMode
        comboboxGenero.Enabled = mEditMode
        doubletextboxAltura.ReadOnly = (mEditMode = False)
        integertextboxPeso.ReadOnly = (mEditMode = False)
        comboboxGrupoSanguineo.Enabled = mEditMode
        comboboxFactorRH.Enabled = mEditMode
        comboboxEstadoCivil.Enabled = mEditMode
        datetimepickerFechaCasamiento.Enabled = mEditMode
        comboboxIOMATiene.Enabled = mEditMode
        textboxIOMANumeroAfiliado.ReadOnly = (mEditMode = False)
        datetimepickerIOMAVencimientoCredencial.Enabled = mEditMode
        comboboxNivelEstudio.Enabled = mEditMode
        textboxProfesion.ReadOnly = (mEditMode = False)
        textboxNacionalidad.ReadOnly = (mEditMode = False)
        comboboxCuartel.Enabled = mEditMode

        ' Contacto Particular
        textboxDomicilioParticularCalle1.ReadOnly = (mEditMode = False)
        textboxDomicilioParticularNumero.ReadOnly = (mEditMode = False)
        textboxDomicilioParticularPiso.ReadOnly = (mEditMode = False)
        textboxDomicilioParticularDepartamento.ReadOnly = (mEditMode = False)
        textboxDomicilioParticularCalle2.ReadOnly = (mEditMode = False)
        textboxDomicilioParticularCalle3.ReadOnly = (mEditMode = False)
        comboboxDomicilioParticularProvincia.Enabled = mEditMode
        comboboxDomicilioParticularLocalidad.Enabled = mEditMode
        textboxDomicilioParticularCodigoPostal.ReadOnly = (mEditMode = False)
        textboxTelefonoParticular.ReadOnly = (mEditMode = False)
        textboxCelularParticular.ReadOnly = (mEditMode = False)
        textboxEmailParticular.ReadOnly = (mEditMode = False)

        ' Contacto Laboral
        textboxDomicilioLaboralCalle1.ReadOnly = (mEditMode = False)
        textboxDomicilioLaboralNumero.ReadOnly = (mEditMode = False)
        textboxDomicilioLaboralPiso.ReadOnly = (mEditMode = False)
        textboxDomicilioLaboralDepartamento.ReadOnly = (mEditMode = False)
        textboxDomicilioLaboralCalle2.ReadOnly = (mEditMode = False)
        textboxDomicilioLaboralCalle3.ReadOnly = (mEditMode = False)
        comboboxDomicilioLaboralProvincia.Enabled = mEditMode
        comboboxDomicilioLaboralLocalidad.Enabled = mEditMode
        textboxDomicilioLaboralCodigoPostal.ReadOnly = (mEditMode = False)
        textboxTelefonoLaboral.ReadOnly = (mEditMode = False)
        textboxCelularLaboral.ReadOnly = (mEditMode = False)
        textboxEmailLaboral.ReadOnly = (mEditMode = False)

        ' Solapas grillas 1
        toolstripFamiliares.Enabled = Not mEditMode
        toolstripAltasBajas.Enabled = Not mEditMode
        toolstripAscensos.Enabled = Not mEditMode

        ' Horarios
        toolstripHorarioLaboral.Enabled = Not mEditMode
        textboxHorarioLaboralObservaciones.ReadOnly = (mEditMode = False)

        ' Vehículos
        buttonLicenciaConducirNumero.Visible = mEditMode
        textboxLicenciaConducirNumero.ReadOnly = (mEditMode = False)
        datetimepickerLicenciaConducirVencimiento.Enabled = mEditMode
        buttonLicenciaConducirCategoria.Visible = mEditMode
        toolstripVehiculos.Enabled = Not mEditMode

        ' Solapas grillas 1
        toolstripVacunas.Enabled = Not mEditMode
        toolstripLicencias.Enabled = Not mEditMode
        toolstripSanciones.Enabled = Not mEditMode
        toolstripCapacitaciones.Enabled = Not mEditMode
        toolstripCalificaciones.Enabled = Not mEditMode
        toolstripExamenes.Enabled = Not mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = (mEditMode = False)
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        ' Cargo los ComboBox
        pFillAndRefreshLists.DocumentoTipo(comboboxDocumentoTipo, True)
        pFillAndRefreshLists.Genero(comboboxGenero, False)
        pFillAndRefreshLists.GrupoSanguineo(comboboxGrupoSanguineo, True)
        pFillAndRefreshLists.FactorRH(comboboxFactorRH, True)
        pFillAndRefreshLists.EstadoCivil(comboboxEstadoCivil, False, True)
        comboboxIOMATiene.Items.AddRange({My.Resources.STRING_ITEM_NOT_SPECIFIED, PERSONA_TIENEIOMA_NOTIENE_NOMBRE, PERSONA_TIENEIOMA_PORBOMBEROS_NOMBRE, PERSONA_TIENEIOMA_PORTRABAJO_NOMBRE})
        pFillAndRefreshLists.NivelEstudio(comboboxNivelEstudio, False, True)
        pFillAndRefreshLists.Cuartel(comboboxCuartel, False, False)
        pFillAndRefreshLists.Provincia(comboboxDomicilioParticularProvincia, True)
        pFillAndRefreshLists.Provincia(comboboxDomicilioLaboralProvincia, True)
    End Sub

    Friend Sub SetAppearance()
        If Not Permisos.VerificarPermiso(Permisos.PERSONA_FAMILIAR, False) Then
            tabcontrolMain.HideTabPageByName(tabpageFamiliares.Name)
        End If
        If Not Permisos.VerificarPermiso(Permisos.PERSONA_ALTABAJA, False) Then
            tabcontrolMain.HideTabPageByName(tabpageAltasBajas.Name)
        End If
        If Not Permisos.VerificarPermiso(Permisos.PERSONA_ASCENSO, False) Then
            tabcontrolMain.HideTabPageByName(tabpageAscensos.Name)
        End If
        If Not Permisos.VerificarPermiso(Permisos.PERSONA_HORARIO, False) Then
            tabcontrolMain.HideTabPageByName(tabpageHorarioLaboral.Name)
        End If
        If Not Permisos.VerificarPermiso(Permisos.PERSONA_VEHICULO, False) Then
            tabcontrolMain.HideTabPageByName(tabpageVehiculos.Name)
        End If
        If Not Permisos.VerificarPermiso(Permisos.PERSONA_VACUNA, False) Then
            tabcontrolMain.HideTabPageByName(tabpageVacunas.Name)
        End If
        If Not Permisos.VerificarPermiso(Permisos.PERSONA_LICENCIA, False) Then
            tabcontrolMain.HideTabPageByName(tabpageLicencias.Name)
        End If
        If Not Permisos.VerificarPermiso(Permisos.PERSONA_SANCION, False) Then
            tabcontrolMain.HideTabPageByName(tabpageSanciones.Name)
        End If
        If Not Permisos.VerificarPermiso(Permisos.PERSONA_CAPACITACION, False) Then
            tabcontrolMain.HideTabPageByName(tabpageCapacitaciones.Name)
        End If
        If Not Permisos.VerificarPermiso(Permisos.PERSONA_CALIFICACION, False) Then
            tabcontrolMain.HideTabPageByName(tabpageCalificaciones.Name)
        End If
        If Not Permisos.VerificarPermiso(Permisos.PERSONA_EXAMEN, False) Then
            tabcontrolMain.HideTabPageByName(tabpageExamenes.Name)
        End If

        DataGridSetAppearance(datagridviewFamiliares)
        DataGridSetAppearance(datagridviewAltasBajas)
        DataGridSetAppearance(datagridviewAscensos)
        DataGridSetAppearance(datagridviewHorarioLaboral)
        DataGridSetAppearance(datagridviewVehiculos)
        DataGridSetAppearance(datagridviewVacunas)
        DataGridSetAppearance(datagridviewLicencias)
        DataGridSetAppearance(datagridviewSanciones)
        DataGridSetAppearance(datagridviewCapacitaciones)
        DataGridSetAppearance(datagridviewCalificaciones)
        DataGridSetAppearance(datagridviewExamenes)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mPersonaActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mPersonaActual
            ' Foto
            If .Foto Is Nothing Then
                pictureboxFoto.Image = Nothing
            Else
                Dim aFoto As Byte()
                aFoto = .Foto
                Dim memstr As New System.IO.MemoryStream(aFoto, 0, aFoto.Length)
                memstr.Write(aFoto, 0, aFoto.Length)
                pictureboxFoto.Image = Image.FromStream(memstr, True)
            End If

            ' Datos del Encabezado
            textboxMatriculaNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.MatriculaNumero).TrimEnd
            textboxApellido.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Apellido)
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)

            ' Datos de la pestaña General
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxDocumentoTipo, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, .IDDocumentoTipo, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            If CType(comboboxDocumentoTipo.SelectedItem, DocumentoTipo).VerificaModulo11 Then
                maskedtextboxDocumentoNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DocumentoNumero)
            Else
                textboxDocumentoNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DocumentoNumero)
            End If
            datetimepickerFechaNacimiento.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaNacimiento, datetimepickerFechaNacimiento)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxGenero, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .Genero, Constantes.PERSONA_GENERO_NOESPECIFICA)
            doubletextboxAltura.Text = CS_ValueTranslation.FromObjectDecimalToControlDoubleTextBox(.Altura)
            integertextboxPeso.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.Peso)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxGrupoSanguineo, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .GrupoSanguineo, "")
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxFactorRH, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .FactorRH, "")
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxEstadoCivil, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, .IDEstadoCivil, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            datetimepickerFechaCasamiento.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaCasamiento, datetimepickerFechaCasamiento)
            Select Case .IOMATiene
                Case ""
                    comboboxIOMATiene.SelectedIndex = 0
                Case PERSONA_TIENEIOMA_NOTIENE
                    comboboxIOMATiene.SelectedIndex = 1
                Case PERSONA_TIENEIOMA_PORBOMBEROS
                    comboboxIOMATiene.SelectedIndex = 2
                Case PERSONA_TIENEIOMA_PORTRABAJO
                    comboboxIOMATiene.SelectedIndex = 3
            End Select
            textboxIOMANumeroAfiliado.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.IOMANumeroAfiliado)
            datetimepickerIOMAVencimientoCredencial.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.IOMAVencimientoCredencial, datetimepickerIOMAVencimientoCredencial)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxNivelEstudio, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, .IDNivelEstudio)
            textboxProfesion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Profesion)
            textboxNacionalidad.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nacionalidad)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxCuartel, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDCuartel)
            MostrarCantidadHijos()
            MostrarUltimoCargoJerarquia()

            ' Datos de la pestaña Contacto Particular
            textboxDomicilioParticularCalle1.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularCalle1)
            textboxDomicilioParticularNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularNumero)
            textboxDomicilioParticularPiso.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularPiso)
            textboxDomicilioParticularDepartamento.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularDepartamento)
            textboxDomicilioParticularCalle2.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularCalle2)
            textboxDomicilioParticularCalle3.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularCalle3)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxDomicilioParticularProvincia, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .DomicilioParticularIDProvincia, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxDomicilioParticularLocalidad, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .DomicilioParticularIDLocalidad, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            textboxDomicilioParticularCodigoPostal.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularCodigoPostal)
            textboxTelefonoParticular.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.TelefonoParticular)
            textboxCelularParticular.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.CelularParticular)
            textboxEmailParticular.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.EmailParticular)

            ' Datos de la pestaña Contacto Laboral
            textboxDomicilioLaboralCalle1.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioLaboralCalle1)
            textboxDomicilioLaboralNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioLaboralNumero)
            textboxDomicilioLaboralPiso.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioLaboralPiso)
            textboxDomicilioLaboralDepartamento.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioLaboralDepartamento)
            textboxDomicilioLaboralCalle2.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioLaboralCalle2)
            textboxDomicilioLaboralCalle3.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioLaboralCalle3)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxDomicilioLaboralProvincia, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .DomicilioLaboralIDProvincia, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxDomicilioLaboralLocalidad, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .DomicilioLaboralIDLocalidad, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            textboxDomicilioLaboralCodigoPostal.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioLaboralCodigoPostal)
            textboxTelefonoLaboral.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.TelefonoLaboral)
            textboxCelularLaboral.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.CelularLaboral)
            textboxEmailLaboral.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.EmailLaboral)

            ' Datos de la pestaña Horarios
            textboxHorarioLaboralObservaciones.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.HorarioLaboralObservaciones)

            ' Datos de la pestaña Vehículos
            textboxLicenciaConducirNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.LicenciaConducirNumero)
            datetimepickerLicenciaConducirVencimiento.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.LicenciaConducirVencimiento, datetimepickerLicenciaConducirVencimiento)
            textboxLicenciaConducirCategoria.Text = .LicenciaConducirCategoriasDisplay

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            If mIsNew Then
                textboxIDPersona.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDPersona.Text = String.Format(.IDPersona.ToString, "G")
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
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mPersonaActual
            ' Foto
            If pictureboxFoto.Image Is Nothing Then
                .Foto = Nothing
            Else
                Dim memstr As New System.IO.MemoryStream()
                pictureboxFoto.Image.Save(memstr, pictureboxFoto.Image.RawFormat)
                Dim aFoto As Byte() = memstr.GetBuffer()
                .Foto = aFoto
            End If

            ' Datos del Encabezado
            .MatriculaNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxMatriculaNumero.Text)
            .Apellido = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxApellido.Text)
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)

            'Datos de la pestaña General
            .IDDocumentoTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxDocumentoTipo.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            If CType(comboboxDocumentoTipo.SelectedItem, DocumentoTipo).VerificaModulo11 Then
                .DocumentoNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(maskedtextboxDocumentoNumero.Text)
            Else
                .DocumentoNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDocumentoNumero.Text)
            End If

            .FechaNacimiento = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaNacimiento.Value, datetimepickerFechaNacimiento.Checked)
            .Genero = CS_ValueTranslation.FromControlComboBoxToObjectString(comboboxGenero.SelectedValue)
            .Altura = CS_ValueTranslation.FromControlDoubleTextBoxToObjectDecimal(doubletextboxAltura.Text)
            .Peso = CS_ValueTranslation.FromControlSyncfusionIntegerTextBoxToObjectByte(integertextboxPeso.Text)
            .GrupoSanguineo = CS_ValueTranslation.FromControlComboBoxToObjectString(comboboxGrupoSanguineo.SelectedValue)
            .FactorRH = CS_ValueTranslation.FromControlComboBoxToObjectString(comboboxFactorRH.SelectedValue)
            .IDEstadoCivil = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxEstadoCivil.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            .FechaCasamiento = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaCasamiento.Value, datetimepickerFechaCasamiento.Checked)
            Select Case comboboxIOMATiene.SelectedIndex
                Case 0
                    .IOMATiene = Nothing
                Case 1
                    .IOMATiene = PERSONA_TIENEIOMA_NOTIENE
                Case 2
                    .IOMATiene = PERSONA_TIENEIOMA_PORBOMBEROS
                Case 3
                    .IOMATiene = PERSONA_TIENEIOMA_PORTRABAJO
            End Select
            .IOMANumeroAfiliado = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxIOMANumeroAfiliado.Text)
            .IOMAVencimientoCredencial = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerIOMAVencimientoCredencial.Value, datetimepickerIOMAVencimientoCredencial.Checked)
            .IDNivelEstudio = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxNivelEstudio.SelectedValue)

            .Profesion = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxProfesion.Text)
            .Nacionalidad = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNacionalidad.Text)
            .IDCuartel = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCuartel.SelectedValue).Value

            ' Datos de la pestaña Contacto Particular
            .DomicilioParticularCalle1 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioParticularCalle1.Text)
            .DomicilioParticularNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioParticularNumero.Text)
            .DomicilioParticularPiso = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioParticularPiso.Text)
            .DomicilioParticularDepartamento = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioParticularDepartamento.Text)
            .DomicilioParticularCalle2 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioParticularCalle2.Text)
            .DomicilioParticularCalle3 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioParticularCalle3.Text)
            .DomicilioParticularIDProvincia = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxDomicilioParticularProvincia.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            .DomicilioParticularIDLocalidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxDomicilioParticularLocalidad.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            .DomicilioParticularCodigoPostal = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioParticularCodigoPostal.Text)
            .TelefonoParticular = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxTelefonoParticular.Text)
            .CelularParticular = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCelularParticular.Text)
            .EmailParticular = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxEmailParticular.Text)

            ' Datos de la pestaña Contacto Laboral
            .DomicilioLaboralCalle1 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioLaboralCalle1.Text)
            .DomicilioLaboralNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioLaboralNumero.Text)
            .DomicilioLaboralPiso = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioLaboralPiso.Text)
            .DomicilioLaboralDepartamento = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioLaboralDepartamento.Text)
            .DomicilioLaboralCalle2 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioLaboralCalle2.Text)
            .DomicilioLaboralCalle3 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioLaboralCalle3.Text)
            .DomicilioLaboralIDProvincia = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxDomicilioLaboralProvincia.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            .DomicilioLaboralIDLocalidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxDomicilioLaboralLocalidad.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            .DomicilioLaboralCodigoPostal = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioLaboralCodigoPostal.Text)
            .TelefonoLaboral = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxTelefonoLaboral.Text)
            .CelularLaboral = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCelularLaboral.Text)
            .EmailLaboral = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxEmailLaboral.Text)

            ' Datos de la pestaña Horarios
            .HorarioLaboralObservaciones = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxHorarioLaboralObservaciones.Text)

            ' Datos de la pestaña Vehículos
            .LicenciaConducirNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxLicenciaConducirNumero.Text)
            .LicenciaConducirVencimiento = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerLicenciaConducirVencimiento.Value, datetimepickerLicenciaConducirVencimiento.Checked)

            ' Datos de la pestaña Notas y Aditoría
            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
        End With
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                If mEditMode Then
                    buttonGuardar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                If mEditMode Then
                    buttonCancelar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
        End Select
    End Sub

    Private Sub SeleccionarFoto() Handles menuitemFotoSeleccionarImagen.Click
        If openfiledialogFoto.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            pictureboxFoto.ImageLocation = openfiledialogFoto.FileName
        End If
    End Sub

    Private Sub EliminarFoto() Handles menuitemFotoEliminarImagen.Click
        pictureboxFoto.Image = Nothing
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxMatriculaNumero.GotFocus, textboxApellido.GotFocus, textboxNombre.GotFocus, textboxDocumentoNumero.GotFocus, textboxIOMANumeroAfiliado.GotFocus, textboxProfesion.GotFocus, textboxNacionalidad.GotFocus, textboxDomicilioParticularCalle1.GotFocus, textboxDomicilioParticularNumero.GotFocus, textboxDomicilioParticularPiso.GotFocus, textboxDomicilioParticularDepartamento.GotFocus, textboxDomicilioParticularCalle2.GotFocus, textboxDomicilioParticularCalle3.GotFocus, textboxDomicilioParticularCodigoPostal.GotFocus, textboxDomicilioLaboralCalle1.GotFocus, textboxDomicilioLaboralNumero.GotFocus, textboxDomicilioLaboralPiso.GotFocus, textboxDomicilioLaboralDepartamento.GotFocus, textboxDomicilioLaboralCalle2.GotFocus, textboxDomicilioLaboralCalle3.GotFocus, textboxDomicilioLaboralCodigoPostal.GotFocus, textboxHorarioLaboralObservaciones.GotFocus, textboxLicenciaConducirNumero.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub MaskedTextBoxs_GotFocus(sender As Object, e As EventArgs) Handles maskedtextboxDocumentoNumero.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
    End Sub

    Private Sub TabControlChanged(sender As Object, e As EventArgs) Handles tabcontrolMain.SelectedIndexChanged
        If mPersonaActual.IDPersona > 0 Then
            Select Case tabcontrolMain.SelectedTab.Name
                Case tabpageFamiliares.Name
                    If tabpageFamiliares.Tag Is Nothing Then
                        Familiares_RefreshData()
                        tabpageFamiliares.Tag = "REFRESHED"
                    End If
                Case tabpageAltasBajas.Name
                    If tabpageAltasBajas.Tag Is Nothing Then
                        AltasBajas_RefreshData()
                        tabpageAltasBajas.Tag = "REFRESHED"
                    End If
                Case tabpageAscensos.Name
                    If tabpageAscensos.Tag Is Nothing Then
                        Ascensos_RefreshData()
                        tabpageAscensos.Tag = "REFRESHED"
                    End If
                Case tabpageHorarioLaboral.Name
                    If tabpageHorarioLaboral.Tag Is Nothing Then
                        HorarioLaboral_RefreshData()
                        tabpageHorarioLaboral.Tag = "REFRESHED"
                    End If
                Case tabpageVehiculos.Name
                    If tabpageVehiculos.Tag Is Nothing Then
                        Vehiculos_RefreshData()
                        tabpageVehiculos.Tag = "REFRESHED"
                    End If
                Case tabpageVacunas.Name
                    If tabpageVacunas.Tag Is Nothing Then
                        Vacunas_RefreshData()
                        tabpageVacunas.Tag = "REFRESHED"
                    End If
                Case tabpageLicencias.Name
                    If tabpageLicencias.Tag Is Nothing Then
                        Licencias_RefreshData()
                        tabpageLicencias.Tag = "REFRESHED"
                    End If
                Case tabpageSanciones.Name
                    If tabpageSanciones.Tag Is Nothing Then
                        Sanciones_RefreshData()
                        tabpageSanciones.Tag = "REFRESHED"
                    End If
                Case tabpageCapacitaciones.Name
                    If tabpageCapacitaciones.Tag Is Nothing Then
                        Capacitaciones_RefreshData()
                        tabpageCapacitaciones.Tag = "REFRESHED"
                    End If
                Case tabpageCalificaciones.Name
                    If tabpageCalificaciones.Tag Is Nothing Then
                        Calificaciones_RefreshData()
                        tabpageCalificaciones.Tag = "REFRESHED"
                    End If
                Case tabpageExamenes.Name
                    If tabpageExamenes.Tag Is Nothing Then
                        Examenes_RefreshData()
                        tabpageExamenes.Tag = "REFRESHED"
                    End If
            End Select
        End If
    End Sub

    Private Sub DocumentoTipo_Cambiar(sender As Object, e As EventArgs) Handles comboboxDocumentoTipo.SelectedIndexChanged
        If Not comboboxDocumentoTipo.SelectedItem Is Nothing Then
            textboxDocumentoNumero.Visible = (CByte(comboboxDocumentoTipo.SelectedValue) > 0 AndAlso Not CType(comboboxDocumentoTipo.SelectedItem, DocumentoTipo).VerificaModulo11)
            maskedtextboxDocumentoNumero.Visible = (CByte(comboboxDocumentoTipo.SelectedValue) > 0 AndAlso Not textboxDocumentoNumero.Visible)
        End If
    End Sub

    Private Sub DocumentoNumero_LimpiarCaracteres(sender As Object, e As EventArgs) Handles textboxDocumentoNumero.LostFocus
        CType(sender, TextBox).Text = CType(sender, TextBox).Text.Replace(".", "")
    End Sub

    Private Sub DomicilioParticularProvincia_Cambiar(sender As Object, e As EventArgs) Handles comboboxDomicilioParticularProvincia.SelectedValueChanged
        If comboboxDomicilioParticularProvincia.SelectedValue Is Nothing Then
            pFillAndRefreshLists.Localidad(comboboxDomicilioParticularLocalidad, 0, True)
            comboboxDomicilioParticularLocalidad.SelectedIndex = 0
        Else
            pFillAndRefreshLists.Localidad(comboboxDomicilioParticularLocalidad, CByte(comboboxDomicilioParticularProvincia.SelectedValue), True)
            If CByte(comboboxDomicilioParticularProvincia.SelectedValue) = CS_Parameter_System.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID) Then
                CardonerSistemas.ComboBox.SetSelectedValue(comboboxDomicilioParticularLocalidad, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, CS_Parameter_System.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID))
            End If
        End If
    End Sub

    Private Sub DomicilioParticularLocalidad_Cambiar(sender As Object, e As EventArgs) Handles comboboxDomicilioParticularLocalidad.SelectedValueChanged
        If Not comboboxDomicilioParticularLocalidad.SelectedValue Is Nothing Then
            textboxDomicilioParticularCodigoPostal.Text = CType(comboboxDomicilioParticularLocalidad.SelectedItem, Localidad).CodigoPostal.ToString()
        End If
    End Sub

    Private Sub DomicilioLaboralProvincia_Cambiar(sender As Object, e As EventArgs) Handles comboboxDomicilioLaboralProvincia.SelectedValueChanged
        If comboboxDomicilioLaboralProvincia.SelectedValue Is Nothing Then
            pFillAndRefreshLists.Localidad(comboboxDomicilioLaboralLocalidad, 0, True)
            comboboxDomicilioLaboralLocalidad.SelectedIndex = 0
        Else
            pFillAndRefreshLists.Localidad(comboboxDomicilioLaboralLocalidad, CByte(comboboxDomicilioLaboralProvincia.SelectedValue), True)
            If CByte(comboboxDomicilioLaboralProvincia.SelectedValue) = CS_Parameter_System.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID) Then
                CardonerSistemas.ComboBox.SetSelectedValue(comboboxDomicilioLaboralLocalidad, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, CS_Parameter_System.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID))
            End If
        End If
    End Sub

    Private Sub DomicilioLaboralLocalidad_Cambiar(sender As Object, e As EventArgs) Handles comboboxDomicilioLaboralLocalidad.SelectedValueChanged
        If Not comboboxDomicilioLaboralLocalidad.SelectedValue Is Nothing Then
            textboxDomicilioLaboralCodigoPostal.Text = CType(comboboxDomicilioLaboralLocalidad.SelectedItem, Localidad).CodigoPostal.ToString()
        End If
    End Sub

    Private Sub LicenciaConducirNumeroCopiarNumeroDocumento(sender As Object, e As EventArgs)
        If CType(comboboxDocumentoTipo.SelectedItem, DocumentoTipo).VerificaModulo11 Then
            textboxLicenciaConducirNumero.Text = maskedtextboxDocumentoNumero.Text
        Else
            textboxLicenciaConducirNumero.Text = textboxDocumentoNumero.Text
        End If
    End Sub

    Private Sub LicenciaConducirCategorias(sender As Object, e As EventArgs) Handles buttonLicenciaConducirCategoria.Click

        formPersonaLicenciaConducirCategorias.LoadAndShow(Me, mPersonaActual)

        If CStr(formPersonaLicenciaConducirCategorias.Tag) = "SAVE" Then
            Dim listLicenciaConducirCategoriaSeleccionadas As New List(Of LicenciaConducirCategoria)
            Dim listPersonaLicenciaConducirCategoria As New List(Of PersonaLicenciaConducirCategoria)

            For Each LicenciaConducirCategoriaActual As LicenciaConducirCategoria In formPersonaLicenciaConducirCategorias.checkedlistboxLicenciaConducirCategorias.CheckedItems
                listLicenciaConducirCategoriaSeleccionadas.Add(LicenciaConducirCategoriaActual)
            Next

            ' Paso 1: Buscar las que están cargadas en la base de datos y ya no están seleccionadas en la lista, para borrarlas
            listPersonaLicenciaConducirCategoria = mPersonaActual.PersonaLicenciaConducirCategorias.ToList
            If Not mIsNew Then
                For Each plcc As PersonaLicenciaConducirCategoria In listPersonaLicenciaConducirCategoria
                    If listLicenciaConducirCategoriaSeleccionadas.Find(Function(lcc) lcc.IDLicenciaConducirCategoria = plcc.IDLicenciaConducirCategoria) Is Nothing Then
                        ' No está en la lista de Categorías seleccionadas, por lo tanto, la elimino
                        mPersonaActual.PersonaLicenciaConducirCategorias.Remove(plcc)
                    End If
                Next
            End If

            ' Paso 2: Agregar las que están en el Combobox pero no en la base de datos
            For Each LicenciaConducirCategoriaSeleccionada As LicenciaConducirCategoria In listLicenciaConducirCategoriaSeleccionadas
                If mPersonaActual.PersonaLicenciaConducirCategorias.Where(Function(plcc) plcc.IDLicenciaConducirCategoria = LicenciaConducirCategoriaSeleccionada.IDLicenciaConducirCategoria).FirstOrDefault Is Nothing Then
                    Dim PersonaLicenciaConducirCategoriaAgregar As New PersonaLicenciaConducirCategoria
                    PersonaLicenciaConducirCategoriaAgregar.IDLicenciaConducirCategoria = LicenciaConducirCategoriaSeleccionada.IDLicenciaConducirCategoria
                    PersonaLicenciaConducirCategoriaAgregar.IDUsuarioCreacion = pUsuario.IDUsuario
                    PersonaLicenciaConducirCategoriaAgregar.FechaHoraCreacion = Now
                    mPersonaActual.PersonaLicenciaConducirCategorias.Add(PersonaLicenciaConducirCategoriaAgregar)
                    PersonaLicenciaConducirCategoriaAgregar = Nothing
                End If
            Next

            listLicenciaConducirCategoriaSeleccionadas = Nothing
            listPersonaLicenciaConducirCategoria = Nothing

            textboxLicenciaConducirCategoria.Text = mPersonaActual.LicenciaConducirCategoriasDisplay
        End If
        formPersonaLicenciaConducirCategorias.Close()
    End Sub

#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrar_Click() Handles buttonCerrar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        ' Verificar que estén todos los campos con datos coherentes
        If textboxMatriculaNumero.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar la Matrícula.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxMatriculaNumero.Focus()
            Exit Sub
        End If
        If textboxApellido.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Apellido.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxApellido.Focus()
            Exit Sub
        End If
        If textboxNombre.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Nombre.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxNombre.Focus()
            Exit Sub
        End If

        ' Verifico el Número de Documento
        If comboboxDocumentoTipo.SelectedIndex > 0 AndAlso textboxDocumentoNumero.Text.Length = 0 Then
            If CType(comboboxDocumentoTipo.SelectedItem, DocumentoTipo).VerificaModulo11 Then
                If maskedtextboxDocumentoNumero.Text.Length = 0 Then
                    tabcontrolMain.SelectedTab = tabpageGeneral
                    MsgBox("Si especifica el Tipo de Documento, también debe especificar el Número de Documento.", MsgBoxStyle.Information, My.Application.Info.Title)
                    maskedtextboxDocumentoNumero.Focus()
                    Exit Sub
                End If
                If maskedtextboxDocumentoNumero.Text.Trim.Length < 11 Then
                    tabcontrolMain.SelectedTab = tabpageGeneral
                    MsgBox("El Número de " & CType(comboboxDocumentoTipo.SelectedItem, DocumentoTipo).Nombre & " debe contener 11 dígitos (sin contar los guiones).", MsgBoxStyle.Information, My.Application.Info.Title)
                    maskedtextboxDocumentoNumero.Focus()
                    Exit Sub
                End If
                If Not CardonerSistemas.AFIP.VerificarCUIT(maskedtextboxDocumentoNumero.Text) Then
                    tabcontrolMain.SelectedTab = tabpageGeneral
                    MsgBox("El Número de " & CType(comboboxDocumentoTipo.SelectedItem, DocumentoTipo).Nombre & " ingresado es incorrecto.", MsgBoxStyle.Information, My.Application.Info.Title)
                    maskedtextboxDocumentoNumero.Focus()
                    Exit Sub
                End If
            Else
                If textboxDocumentoNumero.Text.Length = 0 Then
                    tabcontrolMain.SelectedTab = tabpageGeneral
                    MsgBox("Si especifica el Tipo de Documento, también debe especificar el Número de Documento.", MsgBoxStyle.Information, My.Application.Info.Title)
                    textboxDocumentoNumero.Focus()
                    Exit Sub
                End If
            End If
        End If

        ' Fecha de Nacimiento
        If datetimepickerFechaNacimiento.Checked And datetimepickerFechaNacimiento.Value.Year = Today.Year Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Se ha especificado una Fecha de Nacimiento que no parece ser válida ya que es del año actual.", MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerFechaNacimiento.Focus()
            Exit Sub
        End If

        ' Genero
        If comboboxGenero.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Género de la Persona.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxGenero.Focus()
            Exit Sub
        End If

        ' Cuartel
        If comboboxCuartel.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Cuartel al cual pertenece la Persona.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuartel.Focus()
            Exit Sub
        End If

        ' Direcciones de Email
        If textboxEmailParticular.Text.Trim.Length > 0 Then
            If Not CS_Email.IsValidEmail(textboxEmailParticular.Text.Trim, CS_Parameter_System.GetString(Parametros.EMAIL_VALIDATION_REGULAREXPRESSION)) Then
                tabcontrolMain.SelectedTab = tabpageParticular
                MsgBox("La dirección de E-mail Particular es incorrecta.", vbInformation, My.Application.Info.Title)
                textboxEmailParticular.Focus()
                Exit Sub
            End If
        End If
        If textboxEmailLaboral.Text.Trim.Length > 0 Then
            If Not CS_Email.IsValidEmail(textboxEmailLaboral.Text.Trim, CS_Parameter_System.GetString(Parametros.EMAIL_VALIDATION_REGULAREXPRESSION)) Then
                tabcontrolMain.SelectedTab = tabpageParticular
                MsgBox("La dirección de E-mail Laboral es incorrecta.", vbInformation, My.Application.Info.Title)
                textboxEmailLaboral.Focus()
                Exit Sub
            End If
        End If

        ' Generar el ID de la Persona nueva
        If mIsNew Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.Persona.Count = 0 Then
                    mPersonaActual.IDPersona = 1
                Else
                    mPersonaActual.IDPersona = (From p In dbcMaxID.Persona Select p.IDPersona).Max + 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mPersonaActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mPersonaActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista de Personaes para mostrar los cambios
                If CS_Form.MDIChild_IsLoaded(CType(pFormMDIMain, Form), "formPersonas") Then
                    Dim formPersonas As formPersonas = CType(CS_Form.MDIChild_GetInstance(CType(pFormMDIMain, Form), "formPersonas"), formPersonas)
                    formPersonas.RefreshData(mPersonaActual.IDPersona)
                    formPersonas = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Persona con la misma Matrícula o Apellido y Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Case CardonerSistemas.Database.EntityFramework.Errors.Unknown
                        CardonerSistemas.ErrorHandler.ProcessError(CType(dbuex, Exception), My.Resources.STRING_ERROR_SAVING_CHANGES)
                End Select
                Exit Sub

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Exit Sub
            End Try
        End If

        Me.Close()
    End Sub

    Private Sub buttonCancelar_Click() Handles buttonCancelar.Click
        If mdbContext.ChangeTracker.HasChanges Then
            If MsgBox("Ha realizado cambios en los datos y seleccionó cancelar, los cambios se perderán." & vbCr & vbCr & "¿Confirma la pérdida de los cambios?", CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub
#End Region

#Region "Familiares"
    Friend Class Familiares_GridRowData
        Public Property IDFamiliar As Byte
        Public Property ParentescoNombre As String
        Public Property Apellido As String
        Public Property Nombre As String
    End Class

    Friend Sub Familiares_RefreshData(Optional ByVal PositionIDFamiliar As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listFamiliares As List(Of Familiares_GridRowData)

        If RestoreCurrentPosition Then
            If datagridviewFamiliares.CurrentRow Is Nothing Then
                PositionIDFamiliar = 0
            Else
                PositionIDFamiliar = CType(datagridviewFamiliares.CurrentRow.DataBoundItem, Familiares_GridRowData).IDFamiliar
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listFamiliares = (From pf In mdbContext.PersonaFamiliar
                              Group Join p In mdbContext.Parentesco On pf.IDParentesco Equals p.IDParentesco Into Parentescos_Group = Group
                              From pg In Parentescos_Group.DefaultIfEmpty
                              Where pf.IDPersona = mPersonaActual.IDPersona
                              Order By pg.Orden, pf.ApellidoNombre
                              Select New Familiares_GridRowData With {.IDFamiliar = pf.IDFamiliar, .ParentescoNombre = If(pg Is Nothing, My.Resources.STRING_ITEM_NOT_SPECIFIED, pg.Nombre), .Apellido = pf.Apellido, .Nombre = pf.Nombre}).ToList

            datagridviewFamiliares.AutoGenerateColumns = False
            datagridviewFamiliares.DataSource = listFamiliares

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Familiares.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PositionIDFamiliar <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewFamiliares.Rows
                If CType(CurrentRowChecked.DataBoundItem, Familiares_GridRowData).IDFamiliar = PositionIDFamiliar Then
                    datagridviewFamiliares.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Familiares_Agregar(sender As Object, e As EventArgs) Handles buttonFamiliares_Agregar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_FAMILIAR_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formPersonaFamiliar.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0)
            MostrarCantidadHijos()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Familiares_Editar(sender As Object, e As EventArgs) Handles buttonFamiliares_Editar.Click
        If datagridviewFamiliares.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Familiar para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_FAMILIAR_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formPersonaFamiliar.LoadAndShow(True, Me, mPersonaActual.IDPersona, CType(datagridviewFamiliares.SelectedRows(0).DataBoundItem, Familiares_GridRowData).IDFamiliar)
                MostrarCantidadHijos()

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Familiares_Eliminar(sender As Object, e As EventArgs) Handles buttonFamiliares_Eliminar.Click
        If datagridviewFamiliares.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Familiar para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_FAMILIAR_ELIMINAR) Then
                Dim GridRowDataActual As Familiares_GridRowData
                Dim Mensaje As String

                GridRowDataActual = CType(datagridviewFamiliares.SelectedRows(0).DataBoundItem, Familiares_GridRowData)

                Mensaje = String.Format("Se eliminará el Familiar seleccionado.{0}{0}Parentesco: {1}{0}Apellido y Nombre: {2}, {3}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.ParentescoNombre, GridRowDataActual.Apellido, GridRowDataActual.Nombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Dim PersonaFamiliarEliminar As PersonaFamiliar
                    PersonaFamiliarEliminar = mdbContext.PersonaFamiliar.Find(mPersonaActual.IDPersona, GridRowDataActual.IDFamiliar)
                    mdbContext.PersonaFamiliar.Remove(PersonaFamiliarEliminar)
                    mdbContext.SaveChanges()
                    PersonaFamiliarEliminar = Nothing

                    Familiares_RefreshData()
                    MostrarCantidadHijos()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Familiares_Ver(sender As Object, e As EventArgs) Handles datagridviewFamiliares.DoubleClick
        If datagridviewFamiliares.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Familiar para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formPersonaFamiliar.LoadAndShow(mEditMode, Me, mPersonaActual.IDPersona, CType(datagridviewFamiliares.SelectedRows(0).DataBoundItem, Familiares_GridRowData).IDFamiliar)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Altas-Bajas"
    Friend Class AltasBajas_GridRowData
        Public Property IDAltaBaja As Byte
        Public Property AltaFecha As Date
        Public Property BajaFecha As Date?
        Public Property BajaMotivoNombre As String
    End Class

    Friend Sub AltasBajas_RefreshData(Optional ByVal PositionIDAltaBaja As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listAltasBajas As List(Of AltasBajas_GridRowData)

        If RestoreCurrentPosition Then
            If datagridviewAltasBajas.CurrentRow Is Nothing Then
                PositionIDAltaBaja = 0
            Else
                PositionIDAltaBaja = CType(datagridviewAltasBajas.CurrentRow.DataBoundItem, AltasBajas_GridRowData).IDAltaBaja
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listAltasBajas = (From pab In mdbContext.PersonaAltaBaja
                              Group Join pbm In mdbContext.PersonaBajaMotivo On pab.IDPersonaBajaMotivo Equals pbm.IDPersonaBajaMotivo Into PersonaBajaMotivo_Group = Group
                              From pbmg In PersonaBajaMotivo_Group.DefaultIfEmpty
                              Where pab.IDPersona = mPersonaActual.IDPersona
                              Order By pab.AltaFecha Descending
                              Select New AltasBajas_GridRowData With {.IDAltaBaja = pab.IDAltaBaja, .AltaFecha = pab.AltaFecha, .BajaFecha = pab.BajaFecha, .BajaMotivoNombre = If(pbmg Is Nothing, "", pbmg.Nombre)}).ToList

            datagridviewAltasBajas.AutoGenerateColumns = False
            datagridviewAltasBajas.DataSource = listAltasBajas

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Altas-Bajas.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PositionIDAltaBaja <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewAltasBajas.Rows
                If CType(CurrentRowChecked.DataBoundItem, AltasBajas_GridRowData).IDAltaBaja = PositionIDAltaBaja Then
                    datagridviewAltasBajas.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub AltasBajas_Agregar(sender As Object, e As EventArgs) Handles buttonAltasBajas_Agregar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_ALTABAJA_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formPersonaAltaBaja.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub AltasBajas_Editar(sender As Object, e As EventArgs) Handles buttonAltasBajas_Editar.Click
        If datagridviewAltasBajas.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Alta-Baja para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_ALTABAJA_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formPersonaAltaBaja.LoadAndShow(True, Me, mPersonaActual.IDPersona, CType(datagridviewAltasBajas.SelectedRows(0).DataBoundItem, AltasBajas_GridRowData).IDAltaBaja)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub AltasBajas_Eliminar(sender As Object, e As EventArgs) Handles buttonAltasBajas_Eliminar.Click
        If datagridviewAltasBajas.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Alta-Baja para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_ALTABAJA_ELIMINAR) Then
                Dim GridRowDataActual As AltasBajas_GridRowData
                Dim Mensaje As String

                GridRowDataActual = CType(datagridviewAltasBajas.SelectedRows(0).DataBoundItem, AltasBajas_GridRowData)


                Mensaje = String.Format("Se eliminará la Alta-Baja seleccionada.{0}{0}Fecha Alta: {1}{0}Fecha Baja: {2}{0}Motivo de Baja: {3}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.AltaFecha, GridRowDataActual.BajaFecha, GridRowDataActual.BajaMotivoNombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Dim PersonaAltaBajaEliminar As PersonaAltaBaja
                    PersonaAltaBajaEliminar = mdbContext.PersonaAltaBaja.Find(mPersonaActual.IDPersona, GridRowDataActual.IDAltaBaja)
                    mdbContext.PersonaAltaBaja.Remove(PersonaAltaBajaEliminar)
                    mdbContext.SaveChanges()
                    PersonaAltaBajaEliminar = Nothing

                    AltasBajas_RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub AltasBajas_Ver(sender As Object, e As EventArgs) Handles datagridviewAltasBajas.DoubleClick
        If datagridviewAltasBajas.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Alta-Baja para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formPersonaAltaBaja.LoadAndShow(mEditMode, Me, mPersonaActual.IDPersona, CType(datagridviewAltasBajas.SelectedRows(0).DataBoundItem, AltasBajas_GridRowData).IDAltaBaja)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Ascensos"
    Friend Class Ascensos_GridRowData
        Public Property IDAscenso As Byte
        Public Property Fecha As Date
        Public Property CargoNombre As String
        Public Property JerarquiaNombre As String
    End Class

    Friend Sub Ascensos_RefreshData(Optional ByVal PositionIDAscenso As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listAscensos As List(Of Ascensos_GridRowData)

        If RestoreCurrentPosition Then
            If datagridviewAscensos.CurrentRow Is Nothing Then
                PositionIDAscenso = 0
            Else
                PositionIDAscenso = CType(datagridviewAscensos.CurrentRow.DataBoundItem, Ascensos_GridRowData).IDAscenso
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listAscensos = (From pa In mdbContext.PersonaAscenso
                              Join c In mdbContext.Cargo On pa.IDCargo Equals c.IDCargo
                              Join cj In mdbContext.CargoJerarquia On pa.IDCargo Equals cj.IDCargo And pa.IDJerarquia Equals cj.IDJerarquia
                              Where pa.IDPersona = mPersonaActual.IDPersona
                              Order By pa.Fecha Descending
                              Select New Ascensos_GridRowData With {.IDAscenso = pa.IDAscenso, .Fecha = pa.Fecha, .CargoNombre = c.Nombre, .JerarquiaNombre = cj.Nombre}).ToList

            datagridviewAscensos.AutoGenerateColumns = False
            datagridviewAscensos.DataSource = listAscensos

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Ascensos.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PositionIDAscenso <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewAscensos.Rows
                If CType(CurrentRowChecked.DataBoundItem, Ascensos_GridRowData).IDAscenso = PositionIDAscenso Then
                    datagridviewAscensos.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Ascensos_Agregar(sender As Object, e As EventArgs) Handles buttonAscensos_Agregar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_ASCENSO_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formPersonaAscenso.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0)
            MostrarUltimoCargoJerarquia()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Ascensos_Editar(sender As Object, e As EventArgs) Handles buttonAscensos_Editar.Click
        If datagridviewAscensos.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Ascenso - Promoción para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_ASCENSO_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formPersonaAscenso.LoadAndShow(True, Me, mPersonaActual.IDPersona, CType(datagridviewAscensos.SelectedRows(0).DataBoundItem, Ascensos_GridRowData).IDAscenso)
                MostrarUltimoCargoJerarquia()

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Ascensos_Eliminar(sender As Object, e As EventArgs) Handles buttonAscensos_Eliminar.Click
        If datagridviewAscensos.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Ascenso - Promoción para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_ASCENSO_ELIMINAR) Then
                Dim GridRowDataActual As Ascensos_GridRowData
                Dim Mensaje As String

                GridRowDataActual = CType(datagridviewAscensos.SelectedRows(0).DataBoundItem, Ascensos_GridRowData)

                Mensaje = String.Format("Se eliminará el Ascenso - Promoción seleccionado.{0}{0}Fecha: {1}{0}Cargo: {2}{0}Jerarquía: {3}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.Fecha, GridRowDataActual.CargoNombre, GridRowDataActual.JerarquiaNombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Dim PersonaAscensoEliminar As PersonaAscenso
                    PersonaAscensoEliminar = mdbContext.PersonaAscenso.Find(mPersonaActual.IDPersona, GridRowDataActual.IDAscenso)
                    mdbContext.PersonaAscenso.Remove(PersonaAscensoEliminar)
                    mdbContext.SaveChanges()
                    PersonaAscensoEliminar = Nothing

                    Ascensos_RefreshData()
                    MostrarUltimoCargoJerarquia()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Ascensos_Ver(sender As Object, e As EventArgs) Handles datagridviewAscensos.DoubleClick
        If datagridviewAscensos.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Ascenso - Promoción para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formPersonaAscenso.LoadAndShow(mEditMode, Me, mPersonaActual.IDPersona, CType(datagridviewAscensos.SelectedRows(0).DataBoundItem, Ascensos_GridRowData).IDAscenso)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Horario Laboral"
    Friend Class HorarioLaboral_GridRowData
        Public Property DiaSemana As Byte
        Public Property DiaSemanaNombre As String
        Public Property Turno1Desde As System.TimeSpan?
        Public Property Turno1Hasta As System.TimeSpan?
        Public Property Turno2Desde As System.TimeSpan?
        Public Property Turno2Hasta As System.TimeSpan?
    End Class

    Friend Sub HorarioLaboral_RefreshData(Optional ByVal PositionDiaSemana As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listHorarioLaboral As List(Of HorarioLaboral_GridRowData)

        If RestoreCurrentPosition Then
            If datagridviewHorarioLaboral.CurrentRow Is Nothing Then
                PositionDiaSemana = 0
            Else
                PositionDiaSemana = CType(datagridviewHorarioLaboral.CurrentRow.DataBoundItem, HorarioLaboral_GridRowData).DiaSemana
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listHorarioLaboral = (From phl In mdbContext.PersonaHorarioLaboral
                                  Where phl.IDPersona = mPersonaActual.IDPersona
                                  Order By phl.DiaSemana
                                  Select New HorarioLaboral_GridRowData With {.DiaSemana = phl.DiaSemana, .Turno1Desde = phl.Turno1Desde, .Turno1Hasta = phl.Turno1Hasta, .Turno2Desde = phl.Turno2Desde, .Turno2Hasta = phl.Turno2Hasta}).ToList

            For Each HorarioLaboral_GridRowData_Actual As HorarioLaboral_GridRowData In listHorarioLaboral
                HorarioLaboral_GridRowData_Actual.DiaSemanaNombre = WeekdayName(HorarioLaboral_GridRowData_Actual.DiaSemana)
            Next

            datagridviewHorarioLaboral.AutoGenerateColumns = False
            datagridviewHorarioLaboral.DataSource = listHorarioLaboral

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Horarios Laborales.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PositionDiaSemana <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewHorarioLaboral.Rows
                If CType(CurrentRowChecked.DataBoundItem, HorarioLaboral_GridRowData).DiaSemana = PositionDiaSemana Then
                    datagridviewHorarioLaboral.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub HorarioLaboral_Agregar(sender As Object, e As EventArgs) Handles buttonHorarioLaboral_Agregar.ButtonClick
        If Permisos.VerificarPermiso(Permisos.PERSONA_HORARIO_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formPersonaHorarioLaboral.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub HorarioLaboral_AgregarMultiples(sender As Object, e As EventArgs) Handles menuitemHorarioLaboral_AgregarMultiples.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_HORARIO_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formPersonaHorarioLaboralAgregarMultiples.LoadAndShow(Me, mPersonaActual.IDPersona)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub HorarioLaboral_Editar(sender As Object, e As EventArgs) Handles buttonHorarioLaboral_Editar.Click
        If datagridviewHorarioLaboral.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Horario Laboral para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_HORARIO_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formPersonaHorarioLaboral.LoadAndShow(True, Me, mPersonaActual.IDPersona, CType(datagridviewHorarioLaboral.SelectedRows(0).DataBoundItem, HorarioLaboral_GridRowData).DiaSemana)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub HorarioLaboral_Eliminar(sender As Object, e As EventArgs) Handles buttonHorarioLaboral_Eliminar.Click
        If datagridviewHorarioLaboral.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Horario Laboral para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_HORARIO_ELIMINAR) Then
                Dim GridRowDataActual As HorarioLaboral_GridRowData
                Dim Mensaje As String

                GridRowDataActual = CType(datagridviewHorarioLaboral.SelectedRows(0).DataBoundItem, HorarioLaboral_GridRowData)

                Mensaje = String.Format("Se eliminará el Horario Laboral seleccionado.{0}{0}Día semana: {1}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.DiaSemanaNombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Dim PersonaHorarioEliminar As PersonaHorarioLaboral
                    PersonaHorarioEliminar = mdbContext.PersonaHorarioLaboral.Find(mPersonaActual.IDPersona, GridRowDataActual.DiaSemana)
                    mdbContext.PersonaHorarioLaboral.Remove(PersonaHorarioEliminar)
                    mdbContext.SaveChanges()
                    PersonaHorarioEliminar = Nothing

                    HorarioLaboral_RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub HorarioLaboral_Ver(sender As Object, e As EventArgs) Handles datagridviewHorarioLaboral.DoubleClick
        If datagridviewHorarioLaboral.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Horario Laboral para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formPersonaHorarioLaboral.LoadAndShow(mEditMode, Me, mPersonaActual.IDPersona, CType(datagridviewHorarioLaboral.SelectedRows(0).DataBoundItem, HorarioLaboral_GridRowData).DiaSemana)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub HorarioLaboral_Imprimir(sender As Object, e As EventArgs) Handles buttonHorarioLaboral_Imprimir.Click
        Dim GridRowDataActual As HorarioLaboral_GridRowData

        If datagridviewHorarioLaboral.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Horario Laboral para imprimir.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_HORARIO_IMPRIMIR) Then
                GridRowDataActual = CType(datagridviewHorarioLaboral.SelectedRows(0).DataBoundItem, HorarioLaboral_GridRowData)

                Me.Cursor = Cursors.WaitCursor

                datagridviewLicencias.Enabled = False

                Using dbContext As New CSBomberosContext(True)
                    Dim ReporteActual As New Reporte

                    ReporteActual = dbContext.Reporte.Find(CS_Parameter_System.GetIntegerAsShort(Parametros.REPORTE_ID_PERSONA_HORARIOLABORAL))
                    ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.TrimEnd = "IDPersona").Single.Valor = mPersonaActual.IDPersona
                    If ReporteActual.Open(True, ReporteActual.Nombre & " - " & mPersonaActual.ApellidoNombre) Then
                    End If
                End Using

                datagridviewLicencias.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub HorarioLaboral_FormatCellHorario(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles datagridviewHorarioLaboral.CellFormatting
        If datagridviewHorarioLaboral.Columns(e.ColumnIndex).Name.StartsWith("columnHorarioLaboral_Turno") Then
            If Not e.Value Is Nothing Then
                e.Value = e.Value.ToString().Substring(0, 5)
                e.FormattingApplied = True
            End If
        End If
    End Sub
#End Region

#Region "Vehiculos"
    Friend Class Vehiculos_GridRowData
        Public Property IDVehiculo As Byte
        Public Property TipoNombre As String
        Public Property Dominio As String
        Public Property MarcaNombre As String
        Public Property Modelo As String
        Public Property Anio As Short?
    End Class

    Friend Sub Vehiculos_RefreshData(Optional ByVal PositionIDVehiculo As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listVehiculos As List(Of Vehiculos_GridRowData)

        If RestoreCurrentPosition Then
            If datagridviewVehiculos.CurrentRow Is Nothing Then
                PositionIDVehiculo = 0
            Else
                PositionIDVehiculo = CType(datagridviewVehiculos.CurrentRow.DataBoundItem, Vehiculos_GridRowData).IDVehiculo
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listVehiculos = (From pv In mdbContext.PersonaVehiculo
                             Join vt In mdbContext.VehiculoTipo On pv.IDVehiculoTipo Equals vt.IDVehiculoTipo
                             Group Join vm In mdbContext.VehiculoMarca On pv.IDVehiculoMarca Equals vm.IDVehiculoMarca Into VehiculoMarca_Group = Group
                             From vmg In VehiculoMarca_Group.DefaultIfEmpty()
                             Where pv.IDPersona = mPersonaActual.IDPersona
                             Order By vt.Nombre, pv.IDVehiculo
                             Select New Vehiculos_GridRowData With {.IDVehiculo = pv.IDVehiculo, .TipoNombre = vt.Nombre, .Dominio = pv.Dominio, .MarcaNombre = If(vmg Is Nothing, "", vmg.Nombre), .Modelo = pv.Modelo, .Anio = pv.Anio}).ToList

            datagridviewVehiculos.AutoGenerateColumns = False
            datagridviewVehiculos.DataSource = listVehiculos

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Vehículos.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PositionIDVehiculo <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewVehiculos.Rows
                If CType(CurrentRowChecked.DataBoundItem, Vehiculos_GridRowData).IDVehiculo = PositionIDVehiculo Then
                    datagridviewVehiculos.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Vehiculos_Agregar(sender As Object, e As EventArgs) Handles buttonVehiculos_Agregar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_VEHICULO_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formPersonaVehiculo.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Vehiculos_Editar(sender As Object, e As EventArgs) Handles buttonVehiculos_Editar.Click
        If datagridviewVehiculos.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Vehículo para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_VEHICULO_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formPersonaVehiculo.LoadAndShow(True, Me, mPersonaActual.IDPersona, CType(datagridviewVehiculos.SelectedRows(0).DataBoundItem, Vehiculos_GridRowData).IDVehiculo)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Vehiculos_Eliminar(sender As Object, e As EventArgs) Handles buttonVehiculos_Eliminar.Click
        If datagridviewVehiculos.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Vehículo para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_VEHICULO_ELIMINAR) Then
                Dim GridRowDataActual As Vehiculos_GridRowData
                Dim Mensaje As String

                GridRowDataActual = CType(datagridviewVehiculos.SelectedRows(0).DataBoundItem, Vehiculos_GridRowData)

                Mensaje = String.Format("Se eliminará el Vehículo seleccionado.{0}{0}Tipo: {1}{0}Marca: {2}{0}Modelo: {3}{0}Dominio: {4}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.TipoNombre, GridRowDataActual.MarcaNombre, GridRowDataActual.Modelo, GridRowDataActual.Dominio)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Dim PersonaVehiculoEliminar As PersonaVehiculo
                    PersonaVehiculoEliminar = mdbContext.PersonaVehiculo.Find(mPersonaActual.IDPersona, GridRowDataActual.IDVehiculo)
                    mdbContext.PersonaVehiculo.Remove(PersonaVehiculoEliminar)
                    mdbContext.SaveChanges()
                    PersonaVehiculoEliminar = Nothing

                    Vehiculos_RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Vehiculos_Ver(sender As Object, e As EventArgs) Handles datagridviewVehiculos.DoubleClick
        If datagridviewVehiculos.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Vehículo para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formPersonaVehiculo.LoadAndShow(mEditMode, Me, mPersonaActual.IDPersona, CType(datagridviewVehiculos.SelectedRows(0).DataBoundItem, Vehiculos_GridRowData).IDVehiculo)

            Me.Cursor = Cursors.Default
        End If
    End Sub



#End Region

#Region "Vacunas"
    Friend Class Vacunas_GridRowData
        Public Property IDVacuna As Byte
        Public Property VacunaTipoNombre As String
        Public Property Lote As String
        Public Property DosisNumero As Byte?
        Public Property Fecha As Date?
        Public Property Vencimiento As Date?
    End Class

    Friend Sub Vacunas_RefreshData(Optional ByVal PositionIDVacuna As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listVacunas As List(Of Vacunas_GridRowData)

        If RestoreCurrentPosition Then
            If datagridviewVacunas.CurrentRow Is Nothing Then
                PositionIDVacuna = 0
            Else
                PositionIDVacuna = CType(datagridviewVacunas.CurrentRow.DataBoundItem, Vacunas_GridRowData).IDVacuna
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listVacunas = (From pv In mdbContext.PersonaVacuna
                           Join vt In mdbContext.VacunaTipo On pv.IDVacunaTipo Equals vt.IDVacunaTipo
                           Where pv.IDPersona = mPersonaActual.IDPersona
                           Order By pv.Fecha Descending
                           Select New Vacunas_GridRowData With {.IDVacuna = pv.IDVacuna, .VacunaTipoNombre = vt.Nombre, .Lote = pv.Lote, .DosisNumero = pv.DosisNumero, .Fecha = pv.Fecha, .Vencimiento = pv.Vencimiento}).ToList

            datagridviewVacunas.AutoGenerateColumns = False
            datagridviewVacunas.DataSource = listVacunas

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Vacunas.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PositionIDVacuna <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewVacunas.Rows
                If CType(CurrentRowChecked.DataBoundItem, Vacunas_GridRowData).IDVacuna = PositionIDVacuna Then
                    datagridviewVacunas.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Vacunas_Agregar(sender As Object, e As EventArgs) Handles buttonVacunas_Agregar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_VACUNA_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formPersonaVacuna.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Vacunas_Editar(sender As Object, e As EventArgs) Handles buttonVacunas_Editar.Click
        If datagridviewVacunas.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Vacuna para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_VACUNA_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formPersonaVacuna.LoadAndShow(True, Me, mPersonaActual.IDPersona, CType(datagridviewVacunas.SelectedRows(0).DataBoundItem, Vacunas_GridRowData).IDVacuna)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Vacunas_Eliminar(sender As Object, e As EventArgs) Handles buttonVacunas_Eliminar.Click
        If datagridviewVacunas.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Vacuna para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_VACUNA_ELIMINAR) Then
                Dim GridRowDataActual As Vacunas_GridRowData
                Dim Mensaje As String

                GridRowDataActual = CType(datagridviewVacunas.SelectedRows(0).DataBoundItem, Vacunas_GridRowData)

                Mensaje = String.Format("Se eliminará la Vacuna seleccionada.{0}{0}Tipo: {1}{0}Lote: {2}{0}Dosis nº: {3}{0}Fecha: {4}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.VacunaTipoNombre, GridRowDataActual.Lote, GridRowDataActual.DosisNumero, GridRowDataActual.Fecha.Value.ToShortDateString())
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Dim PersonaVacunaEliminar As PersonaVacuna
                    PersonaVacunaEliminar = mdbContext.PersonaVacuna.Find(mPersonaActual.IDPersona, GridRowDataActual.IDVacuna)
                    mdbContext.PersonaVacuna.Remove(PersonaVacunaEliminar)
                    mdbContext.SaveChanges()
                    PersonaVacunaEliminar = Nothing

                    Vacunas_RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Vacunas_Ver(sender As Object, e As EventArgs) Handles datagridviewVacunas.DoubleClick
        If datagridviewVacunas.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Vacuna para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formPersonaVacuna.LoadAndShow(mEditMode, Me, mPersonaActual.IDPersona, CType(datagridviewVacunas.SelectedRows(0).DataBoundItem, Vacunas_GridRowData).IDVacuna)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Licencias"
    Friend Class Licencias_GridRowData
        Public Property IDLicencia As Short
        Public Property Fecha As Date
        Public Property LicenciaCausaNombre As String
        Public Property FechaDesde As Date
        Public Property FechaHasta As Date
    End Class

    Friend Sub Licencias_RefreshData(Optional ByVal PositionIDLicencia As Short = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listLicencias As List(Of Licencias_GridRowData)

        If RestoreCurrentPosition Then
            If datagridviewLicencias.CurrentRow Is Nothing Then
                PositionIDLicencia = 0
            Else
                PositionIDLicencia = CType(datagridviewLicencias.CurrentRow.DataBoundItem, Licencias_GridRowData).IDLicencia
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listLicencias = (From pl In mdbContext.PersonaLicencia
                              Join lc In mdbContext.LicenciaCausa On pl.IDLicenciaCausa Equals lc.IDLicenciaCausa
                              Where pl.IDPersona = mPersonaActual.IDPersona
                              Order By pl.Fecha Descending
                              Select New Licencias_GridRowData With {.IDLicencia = pl.IDLicencia, .Fecha = pl.Fecha, .LicenciaCausaNombre = lc.Nombre, .FechaDesde = pl.FechaDesde, .FechaHasta = pl.FechaHasta}).ToList

            datagridviewLicencias.AutoGenerateColumns = False
            datagridviewLicencias.DataSource = listLicencias

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Licencias.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PositionIDLicencia <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewLicencias.Rows
                If CType(CurrentRowChecked.DataBoundItem, Licencias_GridRowData).IDLicencia = PositionIDLicencia Then
                    datagridviewLicencias.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Licencias_Agregar(sender As Object, e As EventArgs) Handles buttonLicencias_Agregar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_LICENCIA_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formPersonaLicencia.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Licencias_Editar(sender As Object, e As EventArgs) Handles buttonLicencias_Editar.Click
        If datagridviewLicencias.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Licencia para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_LICENCIA_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formPersonaLicencia.LoadAndShow(True, Me, mPersonaActual.IDPersona, CType(datagridviewLicencias.SelectedRows(0).DataBoundItem, Licencias_GridRowData).IDLicencia)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Licencias_Eliminar(sender As Object, e As EventArgs) Handles buttonLicencias_Eliminar.Click
        If datagridviewLicencias.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Licencia para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_LICENCIA_ELIMINAR) Then
                Dim GridRowDataActual As Licencias_GridRowData
                Dim Mensaje As String

                GridRowDataActual = CType(datagridviewLicencias.SelectedRows(0).DataBoundItem, Licencias_GridRowData)

                Mensaje = String.Format("Se eliminará la Licencia seleccionada.{0}{0}Fecha: {1}{0}Causa: {2}{0}Fecha desde: {3}{0}Fecha hasta: {4}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.Fecha.ToShortDateString, GridRowDataActual.LicenciaCausaNombre, GridRowDataActual.FechaDesde.ToShortDateString, GridRowDataActual.FechaHasta.ToShortDateString)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Dim PersonaLicenciaEliminar As PersonaLicencia
                    PersonaLicenciaEliminar = mdbContext.PersonaLicencia.Find(mPersonaActual.IDPersona, GridRowDataActual.IDLicencia)
                    mdbContext.PersonaLicencia.Remove(PersonaLicenciaEliminar)
                    mdbContext.SaveChanges()
                    PersonaLicenciaEliminar = Nothing

                    Licencias_RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Licencias_Ver(sender As Object, e As EventArgs) Handles datagridviewLicencias.DoubleClick
        If datagridviewLicencias.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Licencia para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formPersonaLicencia.LoadAndShow(mEditMode, Me, mPersonaActual.IDPersona, CType(datagridviewLicencias.SelectedRows(0).DataBoundItem, Licencias_GridRowData).IDLicencia)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Licencias_Imprimir(sender As Object, e As EventArgs) Handles buttonLicencias_Imprimir.Click
        Dim GridRowDataActual As Licencias_GridRowData

        If datagridviewLicencias.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Licencia para imprimir.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_LICENCIA_IMPRIMIR) Then
                GridRowDataActual = CType(datagridviewLicencias.SelectedRows(0).DataBoundItem, Licencias_GridRowData)

                Me.Cursor = Cursors.WaitCursor

                datagridviewLicencias.Enabled = False

                Using dbContext As New CSBomberosContext(True)
                    Dim ReporteActual As New Reporte

                    ReporteActual = dbContext.Reporte.Find(CS_Parameter_System.GetIntegerAsShort(Parametros.REPORTE_ID_PERSONA_LICENCIA))
                    ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.TrimEnd = "IDPersona").Single.Valor = mPersonaActual.IDPersona
                    ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.TrimEnd = "IDLicencia").Single.Valor = GridRowDataActual.IDLicencia
                    If ReporteActual.Open(True, ReporteActual.Nombre & " - " & mPersonaActual.ApellidoNombre & " - " & GridRowDataActual.LicenciaCausaNombre) Then
                    End If
                End Using

                datagridviewLicencias.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub
#End Region

#Region "Sanciones"
    Friend Class Sanciones_GridRowData
        Public Property IDSancion As Short
        Public Property SolicitudFecha As Date
        Public Property SancionTipoNombre As String
    End Class

    Friend Sub Sanciones_RefreshData(Optional ByVal PositionIDSancion As Short = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listSancions As List(Of Sanciones_GridRowData)

        If RestoreCurrentPosition Then
            If datagridviewSanciones.CurrentRow Is Nothing Then
                PositionIDSancion = 0
            Else
                PositionIDSancion = CType(datagridviewSanciones.CurrentRow.DataBoundItem, Sanciones_GridRowData).IDSancion
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listSancions = (From ps In mdbContext.PersonaSancion
                            Group Join st In mdbContext.SancionTipo On ps.ResolucionIDSancionTipo Equals st.IDSancionTipo Into SancionTipo_Group = Group
                            From stg In SancionTipo_Group.DefaultIfEmpty
                            Where ps.IDPersona = mPersonaActual.IDPersona
                            Order By ps.SolicitudFecha Descending
                            Select New Sanciones_GridRowData With {.IDSancion = ps.IDSancion, .SolicitudFecha = ps.SolicitudFecha, .SancionTipoNombre = If(stg Is Nothing, "", stg.Nombre)}).ToList

            datagridviewSanciones.AutoGenerateColumns = False
            datagridviewSanciones.DataSource = listSancions

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Sanciones.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PositionIDSancion <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewSanciones.Rows
                If CType(CurrentRowChecked.DataBoundItem, Sanciones_GridRowData).IDSancion = PositionIDSancion Then
                    datagridviewSanciones.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Sanciones_Agregar(sender As Object, e As EventArgs) Handles buttonSanciones_Agregar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_SANCION_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formPersonaSancion.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Sanciones_Editar(sender As Object, e As EventArgs) Handles buttonSanciones_Editar.Click
        If datagridviewSanciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Sanción para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_SANCION_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formPersonaSancion.LoadAndShow(True, Me, mPersonaActual.IDPersona, CType(datagridviewSanciones.SelectedRows(0).DataBoundItem, Sanciones_GridRowData).IDSancion)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Sanciones_Eliminar(sender As Object, e As EventArgs) Handles buttonSanciones_Eliminar.Click
        If datagridviewSanciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Sanción para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_SANCION_ELIMINAR) Then
                Dim GridRowDataActual As Sanciones_GridRowData
                Dim Mensaje As String

                GridRowDataActual = CType(datagridviewSanciones.SelectedRows(0).DataBoundItem, Sanciones_GridRowData)

                Mensaje = String.Format("Se eliminará la Sanción seleccionada.{0}{0}Fecha de solicitud: {1}{0}Tipo: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.SolicitudFecha, GridRowDataActual.SancionTipoNombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Dim PersonaSancionEliminar As PersonaSancion
                    PersonaSancionEliminar = mdbContext.PersonaSancion.Find(mPersonaActual.IDPersona, GridRowDataActual.IDSancion)
                    mdbContext.PersonaSancion.Remove(PersonaSancionEliminar)
                    mdbContext.SaveChanges()
                    PersonaSancionEliminar = Nothing

                    Sanciones_RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Sanciones_Ver(sender As Object, e As EventArgs) Handles datagridviewSanciones.DoubleClick
        If datagridviewSanciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Sanción para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formPersonaSancion.LoadAndShow(mEditMode, Me, mPersonaActual.IDPersona, CType(datagridviewSanciones.SelectedRows(0).DataBoundItem, Sanciones_GridRowData).IDSancion)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Sanciones_Imprimir(sender As Object, e As EventArgs) Handles buttonSanciones_Imprimir.Click
        Dim GridRowDataActual As Sanciones_GridRowData

        If datagridviewSanciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Sanción para imprimir.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_SANCION_IMPRIMIR) Then
                GridRowDataActual = CType(datagridviewSanciones.SelectedRows(0).DataBoundItem, Sanciones_GridRowData)

                Me.Cursor = Cursors.WaitCursor

                datagridviewSanciones.Enabled = False

                Using dbContext As New CSBomberosContext(True)
                    Dim ReporteActual As New Reporte

                    ReporteActual = dbContext.Reporte.Find(CS_Parameter_System.GetIntegerAsShort(Parametros.REPORTE_ID_PERSONA_SANCIONDISCIPLINARIA))
                    ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.TrimEnd = "IDPersona").Single.Valor = mPersonaActual.IDPersona
                    ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.TrimEnd = "IDSancion").Single.Valor = GridRowDataActual.IDSancion
                    If ReporteActual.Open(True, ReporteActual.Nombre & " - " & mPersonaActual.ApellidoNombre & " - " & GridRowDataActual.SancionTipoNombre) Then
                    End If
                End Using

                datagridviewSanciones.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

#End Region

#Region "Capacitaciones"
    Friend Class Capacitaciones_GridRowData
        Public Property IDCapacitacion As Short
        Public Property Fecha As Date
        Public Property CursoNombre As String
    End Class

    Friend Sub Capacitaciones_RefreshData(Optional ByVal PositionIDCurso As Short = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listCapacitaciones As List(Of Capacitaciones_GridRowData)

        If RestoreCurrentPosition Then
            If datagridviewCapacitaciones.CurrentRow Is Nothing Then
                PositionIDCurso = 0
            Else
                PositionIDCurso = CType(datagridviewCapacitaciones.CurrentRow.DataBoundItem, Capacitaciones_GridRowData).IDCapacitacion
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listCapacitaciones = (From pc In mdbContext.PersonaCapacitacion
                              Join c In mdbContext.Curso On pc.IDCurso Equals c.IDCurso
                              Where pc.IDPersona = mPersonaActual.IDPersona
                              Order By pc.Fecha Descending
                              Select New Capacitaciones_GridRowData With {.IDCapacitacion = pc.IDCapacitacion, .Fecha = pc.Fecha, .CursoNombre = c.Nombre}).ToList

            datagridviewCapacitaciones.AutoGenerateColumns = False
            datagridviewCapacitaciones.DataSource = listCapacitaciones

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Capacitaciones.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PositionIDCurso <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewCapacitaciones.Rows
                If CType(CurrentRowChecked.DataBoundItem, Capacitaciones_GridRowData).IDCapacitacion = PositionIDCurso Then
                    datagridviewCapacitaciones.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Capacitaciones_Agregar(sender As Object, e As EventArgs) Handles buttonCapacitaciones_Agregar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_CAPACITACION_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formPersonaCapacitacion.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Capacitaciones_Editar(sender As Object, e As EventArgs) Handles buttonCapacitaciones_Editar.Click
        If datagridviewCapacitaciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Capacitación para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_CAPACITACION_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formPersonaCapacitacion.LoadAndShow(True, Me, mPersonaActual.IDPersona, CType(datagridviewCapacitaciones.SelectedRows(0).DataBoundItem, Capacitaciones_GridRowData).IDCapacitacion)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Capacitaciones_Eliminar(sender As Object, e As EventArgs) Handles buttonCapacitaciones_Eliminar.Click
        If datagridviewCapacitaciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Capacitación para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_CAPACITACION_ELIMINAR) Then
                Dim GridRowDataActual As Capacitaciones_GridRowData
                Dim Mensaje As String

                GridRowDataActual = CType(datagridviewCapacitaciones.SelectedRows(0).DataBoundItem, Capacitaciones_GridRowData)

                Mensaje = String.Format("Se eliminará la Capacitación seleccionada.{0}{0}Fecha: {1}{0}Curso: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.Fecha, GridRowDataActual.CursoNombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Dim PersonaCapacitacionEliminar As PersonaCapacitacion
                    PersonaCapacitacionEliminar = mdbContext.PersonaCapacitacion.Find(mPersonaActual.IDPersona, GridRowDataActual.IDCapacitacion)
                    mdbContext.PersonaCapacitacion.Remove(PersonaCapacitacionEliminar)
                    mdbContext.SaveChanges()
                    PersonaCapacitacionEliminar = Nothing

                    Capacitaciones_RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Capacitaciones_Ver(sender As Object, e As EventArgs) Handles datagridviewCapacitaciones.DoubleClick
        If datagridviewCapacitaciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Capacitación para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formPersonaCapacitacion.LoadAndShow(mEditMode, Me, mPersonaActual.IDPersona, CType(datagridviewCapacitaciones.SelectedRows(0).DataBoundItem, Capacitaciones_GridRowData).IDCapacitacion)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Calificaciones"
    Friend Class Calificaciones_ListDataItem
        Public Property Anio As Short
        Public Property InstanciaNumero As Byte
        Public Property IDConcepto As Byte
        Public Property ConceptoAbreviatura As String
        Public Property ConceptoNombre As String
        Public Property Calificacion As Decimal?
    End Class

    Friend Class Calificaciones_GridRowData
        Public Property Anio As Short
        Public Property InstanciaNumero As Byte
        Public Property AnioInstancia As String
        Public Property ConceptosCalificaciones As String = ""
    End Class

    Friend Sub Calificaciones_RefreshData(Optional ByVal PositionAnio As Short = 0, Optional ByVal PositionInstanciaNumero As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listCalificaciones As List(Of Calificaciones_ListDataItem)
        Dim listCalificaciones_GridRowData = New List(Of Calificaciones_GridRowData)
        Dim AnioInstanciaActual As String = ""
        Dim GridRowDataActual As New Calificaciones_GridRowData

        If RestoreCurrentPosition Then
            If datagridviewCalificaciones.CurrentRow Is Nothing Then
                PositionAnio = 0
                PositionInstanciaNumero = 0
            Else
                PositionAnio = CType(datagridviewCalificaciones.CurrentRow.DataBoundItem, Calificaciones_GridRowData).Anio
                PositionInstanciaNumero = CType(datagridviewCalificaciones.CurrentRow.DataBoundItem, Calificaciones_GridRowData).InstanciaNumero
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listCalificaciones = (From pc In mdbContext.PersonaCalificacion
                                  Join cc In mdbContext.CalificacionConcepto On pc.IDCalificacionConcepto Equals cc.IDCalificacionConcepto
                                  Where pc.IDPersona = mPersonaActual.IDPersona
                                  Order By pc.Anio Descending, pc.InstanciaNumero Descending, cc.Abreviatura
                                  Select New Calificaciones_ListDataItem With {.Anio = pc.Anio, .InstanciaNumero = pc.InstanciaNumero, .IDConcepto = cc.IDCalificacionConcepto, .ConceptoAbreviatura = cc.Abreviatura, .ConceptoNombre = cc.Nombre, .Calificacion = pc.Calificacion}).ToList

            listCalificaciones_GridRowData = New List(Of Calificaciones_GridRowData)

            For Each ListDataItemActual As Calificaciones_ListDataItem In listCalificaciones
                With ListDataItemActual
                    If AnioInstanciaActual <> .Anio & " - " & .InstanciaNumero Then
                        AnioInstanciaActual = .Anio & " - " & .InstanciaNumero
                        GridRowDataActual = New Calificaciones_GridRowData
                        GridRowDataActual.Anio = .Anio
                        GridRowDataActual.InstanciaNumero = .InstanciaNumero
                        GridRowDataActual.AnioInstancia = AnioInstanciaActual
                        listCalificaciones_GridRowData.Add(GridRowDataActual)
                    End If
                    ' Si no es el primer item, agrego un salto de línea
                    If GridRowDataActual.ConceptosCalificaciones.Length > 0 Then
                        GridRowDataActual.ConceptosCalificaciones &= vbCrLf
                    End If
                    If .ConceptoAbreviatura Is Nothing Then
                        GridRowDataActual.ConceptosCalificaciones &= String.Format("{1}: {2}", .ConceptoAbreviatura, .ConceptoNombre, .Calificacion)
                    Else
                        GridRowDataActual.ConceptosCalificaciones &= String.Format("{0} - {1}: {2}", .ConceptoAbreviatura, .ConceptoNombre, .Calificacion)
                    End If
                End With
            Next

            ' Ordeno la lista y la adjunto a la Grilla
            datagridviewCalificaciones.AutoGenerateColumns = False
            datagridviewCalificaciones.DataSource = listCalificaciones_GridRowData

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Calificaciones.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewCalificaciones.CurrentRow Is Nothing Then
                PositionAnio = 0
                PositionInstanciaNumero = 0
            Else
                PositionAnio = CType(datagridviewCalificaciones.CurrentRow.DataBoundItem, Calificaciones_GridRowData).Anio
                PositionInstanciaNumero = CType(datagridviewCalificaciones.CurrentRow.DataBoundItem, Calificaciones_GridRowData).InstanciaNumero
            End If
        End If

        If PositionAnio <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewCalificaciones.Rows
                If CType(CurrentRowChecked.DataBoundItem, Calificaciones_GridRowData).Anio = PositionAnio And CType(CurrentRowChecked.DataBoundItem, Calificaciones_GridRowData).InstanciaNumero = PositionInstanciaNumero Then
                    datagridviewCalificaciones.CurrentCell = CurrentRowChecked.Cells(columnCalificaciones_AnioInstancia.Name)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Calificaciones_Agregar(sender As Object, e As EventArgs) Handles buttonCalificaciones_Agregar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_CALIFICACION_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formPersonaCalificacion.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Calificaciones_Editar(sender As Object, e As EventArgs) Handles buttonCalificaciones_Editar.Click
        If datagridviewCalificaciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Instancia de Calificación para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_CALIFICACION_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formPersonaCalificacion.LoadAndShow(True, Me, mPersonaActual.IDPersona, CType(datagridviewCalificaciones.SelectedRows(0).DataBoundItem, Calificaciones_GridRowData).Anio, CType(datagridviewCalificaciones.SelectedRows(0).DataBoundItem, Calificaciones_GridRowData).InstanciaNumero)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Calificaciones_Eliminar(sender As Object, e As EventArgs) Handles buttonCalificaciones_Eliminar.Click
        If datagridviewCalificaciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Instancia de Calificación para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_CALIFICACION_ELIMINAR) Then
                Dim GridRowDataActual As Calificaciones_GridRowData
                Dim Mensaje As String

                GridRowDataActual = CType(datagridviewCalificaciones.SelectedRows(0).DataBoundItem, Calificaciones_GridRowData)

                Mensaje = String.Format("Se eliminará la Instancia de Calificación seleccionada.{0}{0}Año: {1}{0}Instancia Número: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.Anio, GridRowDataActual.InstanciaNumero)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Try
                        For Each PersonaCalificacionEliminar As PersonaCalificacion In mdbContext.PersonaCalificacion.Where(Function(pc) pc.IDPersona = mPersonaActual.IDPersona And pc.Anio = GridRowDataActual.Anio And pc.InstanciaNumero = GridRowDataActual.InstanciaNumero)
                            mdbContext.PersonaCalificacion.Remove(PersonaCalificacionEliminar)
                        Next
                        mdbContext.SaveChanges()

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Me.Cursor = Cursors.Default
                        Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                            Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                MsgBox("No se puede eliminar la Instancia de Calificación porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Exit Sub

                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar la Instancia de Calificación.")
                    End Try

                    Calificaciones_RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Calificaciones_Ver(sender As Object, e As EventArgs) Handles datagridviewCalificaciones.DoubleClick
        If datagridviewCalificaciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Instancia de Calificación para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formPersonaCalificacion.LoadAndShow(False, Me, mPersonaActual.IDPersona, CType(datagridviewCalificaciones.SelectedRows(0).DataBoundItem, Calificaciones_GridRowData).Anio, CType(datagridviewCalificaciones.SelectedRows(0).DataBoundItem, Calificaciones_GridRowData).InstanciaNumero)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Calificaciones_Imprimir(sender As Object, e As EventArgs) Handles buttonCalificaciones_Imprimir.Click
        Dim GridRowDataActual As Calificaciones_GridRowData

        If datagridviewCalificaciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Caificación para imprimir la Ficha.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_CALIFICACION_IMPRIMIR) Then
                GridRowDataActual = CType(datagridviewCalificaciones.SelectedRows(0).DataBoundItem, Calificaciones_GridRowData)

                Me.Cursor = Cursors.WaitCursor

                datagridviewCalificaciones.Enabled = False

                Using dbContext As New CSBomberosContext(True)
                    Dim ReporteActual As New Reporte

                    ReporteActual = dbContext.Reporte.Find(CS_Parameter_System.GetIntegerAsShort(Parametros.REPORTE_ID_PERSONA_PLANILLAANUALCALIFICACIONES))
                    ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.TrimEnd = "IDPersona").Single.Valor = mPersonaActual.IDPersona
                    ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.TrimEnd = "Anio").Single.Valor = GridRowDataActual.Anio
                    If ReporteActual.Open(True, ReporteActual.Nombre & " - " & mPersonaActual.ApellidoNombre & " - " & GridRowDataActual.Anio) Then
                    End If
                End Using

                datagridviewCalificaciones.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

#End Region

#Region "Exámenes"
    Friend Class Examenes_GridRowData
        Public Property Anio As Short
        Public Property InstanciaNumero As Byte
        Public Property AnioInstancia As String
        Public Property Calificacion As Decimal
    End Class

    Friend Sub Examenes_RefreshData(Optional ByVal PositionAnio As Short = 0, Optional ByVal PositionInstanciaNumero As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listExamenes As List(Of Examenes_GridRowData)

        If RestoreCurrentPosition Then
            If datagridviewExamenes.CurrentRow Is Nothing Then
                PositionAnio = 0
                PositionInstanciaNumero = 0
            Else
                PositionAnio = CType(datagridviewExamenes.CurrentRow.DataBoundItem, Examenes_GridRowData).Anio
                PositionInstanciaNumero = CType(datagridviewExamenes.CurrentRow.DataBoundItem, Examenes_GridRowData).InstanciaNumero
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listExamenes = (From pe In mdbContext.PersonaExamen
                            Where pe.IDPersona = mPersonaActual.IDPersona
                            Order By pe.Anio Descending, pe.InstanciaNumero Descending
                            Select New Examenes_GridRowData With {.Anio = pe.Anio, .InstanciaNumero = pe.InstanciaNumero, .AnioInstancia = pe.Anio & " - " & pe.InstanciaNumero, .Calificacion = pe.Calificacion}).ToList

            datagridviewExamenes.AutoGenerateColumns = False
            datagridviewExamenes.DataSource = listExamenes

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Exámenes.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PositionAnio <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewExamenes.Rows
                If CType(CurrentRowChecked.DataBoundItem, Examenes_GridRowData).Anio = PositionAnio And CType(CurrentRowChecked.DataBoundItem, Examenes_GridRowData).InstanciaNumero = PositionInstanciaNumero Then
                    datagridviewExamenes.CurrentCell = CurrentRowChecked.Cells(columnExamenes_AnioInstancia.Name)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Examenes_Agregar(sender As Object, e As EventArgs) Handles buttonExamenes_Agregar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_EXAMEN_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formPersonaExamen.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Examenes_Editar(sender As Object, e As EventArgs) Handles buttonExamenes_Editar.Click
        If datagridviewExamenes.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Examen para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_EXAMEN_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formPersonaExamen.LoadAndShow(True, Me, mPersonaActual.IDPersona, CType(datagridviewExamenes.SelectedRows(0).DataBoundItem, Examenes_GridRowData).Anio, CType(datagridviewExamenes.SelectedRows(0).DataBoundItem, Examenes_GridRowData).InstanciaNumero)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Examenes_Eliminar(sender As Object, e As EventArgs) Handles buttonExamenes_Eliminar.Click
        If datagridviewExamenes.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Examen para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_EXAMEN_ELIMINAR) Then
                Dim GridRowDataActual As Examenes_GridRowData
                Dim Mensaje As String

                GridRowDataActual = CType(datagridviewExamenes.SelectedRows(0).DataBoundItem, Examenes_GridRowData)

                Mensaje = String.Format("Se eliminará el Examen seleccionado.{0}{0}Anio: {1}{0}Instancia: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.Anio, GridRowDataActual.InstanciaNumero)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                    Me.Cursor = Cursors.WaitCursor

                    Dim PersonaExamenEliminar As PersonaExamen
                    PersonaExamenEliminar = mdbContext.PersonaExamen.Find(mPersonaActual.IDPersona, GridRowDataActual.Anio, GridRowDataActual.InstanciaNumero)
                    mdbContext.PersonaExamen.Remove(PersonaExamenEliminar)
                    mdbContext.SaveChanges()
                    PersonaExamenEliminar = Nothing

                    Examenes_RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Examenes_Ver(sender As Object, e As EventArgs) Handles datagridviewExamenes.DoubleClick
        If datagridviewExamenes.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Examen para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formPersonaExamen.LoadAndShow(mEditMode, Me, mPersonaActual.IDPersona, CType(datagridviewExamenes.SelectedRows(0).DataBoundItem, Examenes_GridRowData).Anio, CType(datagridviewExamenes.SelectedRows(0).DataBoundItem, Examenes_GridRowData).InstanciaNumero)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Extra stuff"
    Private Sub MostrarCantidadHijos()
        Dim ParentescoIDHijo As Byte

        ParentescoIDHijo = CS_Parameter_System.GetIntegerAsByte(Parametros.PARENTESCO_ID_HIJO)

        Using dbContext As New CSBomberosContext(True)
            textboxCantidadHijos.Text = dbContext.PersonaFamiliar.Where(Function(pf) pf.IDPersona = mPersonaActual.IDPersona AndAlso (Not pf.IDParentesco Is Nothing) AndAlso pf.IDParentesco.Value = ParentescoIDHijo).Count().ToString
        End Using
    End Sub

    Private Sub MostrarUltimoCargoJerarquia()
        Using dbContext As New CSBomberosContext(True)
            Dim PersonaAscensoUltimo As PersonaAscenso

            PersonaAscensoUltimo = dbContext.PersonaAscenso.Where(Function(pf) pf.IDPersona = mPersonaActual.IDPersona).OrderByDescending(Function(pf) pf.Fecha).FirstOrDefault
            If PersonaAscensoUltimo Is Nothing Then
                textboxCargoJerarquiaActual.Text = ""
                textboxFechaUltimoAscenso.Text = ""
            Else
                textboxCargoJerarquiaActual.Text = PersonaAscensoUltimo.CargoJerarquia.Cargo.Nombre & " - " & PersonaAscensoUltimo.CargoJerarquia.Nombre
                textboxFechaUltimoAscenso.Text = PersonaAscensoUltimo.Fecha.ToShortDateString
            End If
        End Using
    End Sub
#End Region

End Class