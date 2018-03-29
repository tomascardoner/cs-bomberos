Public Class formPersona

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaActual As Persona

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer)
        mIsLoading = True
        mEditMode = EditMode

        If IDPersona = 0 Then
            ' Es Nuevo
            mPersonaActual = New Persona
            With mPersonaActual
                .DomicilioParticularIDProvincia = CS_Parameter.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID)
                .DomicilioParticularIDLocalidad = CS_Parameter.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID)
                .DomicilioParticularCodigoPostal = CS_Parameter.GetString(Parametros.DEFAULT_CODIGOPOSTAL)
                .DomicilioLaboralIDProvincia = CS_Parameter.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID)
                .DomicilioLaboralIDLocalidad = CS_Parameter.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID)
                .DomicilioLaboralCodigoPostal = CS_Parameter.GetString(Parametros.DEFAULT_CODIGOPOSTAL)
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

        Me.MdiParent = formMDIMain
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
        textboxLicenciaConducirNumero.ReadOnly = (mEditMode = False)
        datetimepickerLicenciaConducirVencimiento.Enabled = mEditMode

        datetimepickerFechaNacimiento.Enabled = mEditMode
        comboboxGenero.Enabled = mEditMode
        comboboxGrupoSanguineo.Enabled = mEditMode
        comboboxFactorRH.Enabled = mEditMode
        comboboxIOMATiene.Enabled = mEditMode
        textboxIOMANumeroAfiliado.ReadOnly = (mEditMode = False)
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

        ' Solapas grillas
        toolstripFamiliares.Enabled = Not mEditMode
        toolstripAltasBajas.Enabled = Not mEditMode
        toolstripAscensos.Enabled = Not mEditMode
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
            CS_Control_ComboBox.SetSelectedValue(comboboxDocumentoTipo, SelectedItemOptions.ValueOrFirst, .IDDocumentoTipo, CByte(0))
            If CType(comboboxDocumentoTipo.SelectedItem, DocumentoTipo).VerificaModulo11 Then
                maskedtextboxDocumentoNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DocumentoNumero)
            Else
                textboxDocumentoNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DocumentoNumero)
            End If
            textboxLicenciaConducirNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.LicenciaConducirNumero)
            datetimepickerLicenciaConducirVencimiento.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.LicenciaConducirVencimiento, datetimepickerLicenciaConducirVencimiento)

            datetimepickerFechaNacimiento.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaNacimiento, datetimepickerFechaNacimiento)
            CS_Control_ComboBox.SetSelectedValue(comboboxGenero, SelectedItemOptions.Value, .Genero, Constantes.PERSONA_GENERO_NOESPECIFICA)
            CS_Control_ComboBox.SetSelectedValue(comboboxGrupoSanguineo, SelectedItemOptions.Value, .GrupoSanguineo, "")
            CS_Control_ComboBox.SetSelectedValue(comboboxFactorRH, SelectedItemOptions.Value, .FactorRH, "")
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
            CS_Control_ComboBox.SetSelectedValue(comboboxNivelEstudio, SelectedItemOptions.ValueOrFirst, .IDNivelEstudio)

            textboxProfesion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Profesion)
            textboxNacionalidad.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nacionalidad)
            CS_Control_ComboBox.SetSelectedValue(comboboxCuartel, SelectedItemOptions.ValueOrFirstIfUnique, .IDCuartel)

            ' Info
            textboxCantidadHijos.Text = ""
            textboxCargoJerarquiaActual.Text = ""

            ' Datos de la pestaña Contacto Particular
            textboxDomicilioParticularCalle1.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularCalle1)
            textboxDomicilioParticularNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularNumero)
            textboxDomicilioParticularPiso.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularPiso)
            textboxDomicilioParticularDepartamento.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularDepartamento)
            textboxDomicilioParticularCalle2.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularCalle2)
            textboxDomicilioParticularCalle3.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularCalle3)
            CS_Control_ComboBox.SetSelectedValue(comboboxDomicilioParticularProvincia, SelectedItemOptions.Value, .DomicilioParticularIDProvincia, FIELD_VALUE_NOTSPECIFIED_BYTE)
            CS_Control_ComboBox.SetSelectedValue(comboboxDomicilioParticularLocalidad, SelectedItemOptions.Value, .DomicilioParticularIDLocalidad, FIELD_VALUE_NOTSPECIFIED_SHORT)
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
            CS_Control_ComboBox.SetSelectedValue(comboboxDomicilioLaboralProvincia, SelectedItemOptions.Value, .DomicilioLaboralIDProvincia, FIELD_VALUE_NOTSPECIFIED_BYTE)
            CS_Control_ComboBox.SetSelectedValue(comboboxDomicilioLaboralLocalidad, SelectedItemOptions.Value, .DomicilioLaboralIDLocalidad, FIELD_VALUE_NOTSPECIFIED_SHORT)
            textboxDomicilioLaboralCodigoPostal.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioLaboralCodigoPostal)
            textboxTelefonoLaboral.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.TelefonoLaboral)
            textboxCelularLaboral.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.CelularLaboral)
            textboxEmailLaboral.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.EmailLaboral)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            If .IDPersona = 0 Then
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
            .IDDocumentoTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxDocumentoTipo.SelectedValue, 0)
            If CType(comboboxDocumentoTipo.SelectedItem, DocumentoTipo).VerificaModulo11 Then
                .DocumentoNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(maskedtextboxDocumentoNumero.Text)
            Else
                .DocumentoNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDocumentoNumero.Text)
            End If
            .LicenciaConducirNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxLicenciaConducirNumero.Text)
            .LicenciaConducirVencimiento = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerLicenciaConducirVencimiento.Value, datetimepickerLicenciaConducirVencimiento.Checked)

            .FechaNacimiento = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaNacimiento.Value, datetimepickerFechaNacimiento.Checked)
            .Genero = CS_ValueTranslation.FromControlComboBoxToObjectString(comboboxGenero.SelectedValue)
            .GrupoSanguineo = CS_ValueTranslation.FromControlComboBoxToObjectString(comboboxGrupoSanguineo.SelectedValue)
            .FactorRH = CS_ValueTranslation.FromControlComboBoxToObjectString(comboboxFactorRH.SelectedValue)
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
            .DomicilioParticularIDProvincia = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxDomicilioParticularProvincia.SelectedValue, FIELD_VALUE_NOTSPECIFIED_BYTE)
            .DomicilioParticularIDLocalidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxDomicilioParticularLocalidad.SelectedValue, FIELD_VALUE_NOTSPECIFIED_SHORT)
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
            .DomicilioLaboralIDProvincia = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxDomicilioLaboralProvincia.SelectedValue, FIELD_VALUE_NOTSPECIFIED_BYTE)
            .DomicilioLaboralIDLocalidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxDomicilioLaboralLocalidad.SelectedValue, FIELD_VALUE_NOTSPECIFIED_SHORT)
            .DomicilioLaboralCodigoPostal = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioLaboralCodigoPostal.Text)
            .TelefonoLaboral = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxTelefonoLaboral.Text)
            .CelularLaboral = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCelularLaboral.Text)
            .EmailLaboral = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxEmailLaboral.Text)

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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxIDPersona.GotFocus, textboxMatriculaNumero.GotFocus, textboxApellido.GotFocus, textboxNombre.GotFocus, textboxDocumentoNumero.GotFocus, textboxProfesion.GotFocus, textboxNacionalidad.GotFocus, textboxDomicilioParticularCalle1.GotFocus, textboxDomicilioParticularNumero.GotFocus, textboxDomicilioParticularPiso.GotFocus, textboxDomicilioParticularDepartamento.GotFocus, textboxDomicilioParticularCalle2.GotFocus, textboxDomicilioParticularCalle3.GotFocus, textboxDomicilioParticularCodigoPostal.GotFocus, textboxDomicilioLaboralCalle1.GotFocus, textboxDomicilioLaboralNumero.GotFocus, textboxDomicilioLaboralPiso.GotFocus, textboxDomicilioLaboralDepartamento.GotFocus, textboxDomicilioLaboralCalle2.GotFocus, textboxDomicilioLaboralCalle3.GotFocus, textboxDomicilioLaboralCodigoPostal.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub MaskedTextBoxs_GotFocus(sender As Object, e As EventArgs) Handles maskedtextboxDocumentoNumero.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
    End Sub

    Private Sub TabControlChanged() Handles tabcontrolMain.SelectedIndexChanged
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

    Private Sub comboboxDocumentoTipo_SelectedIndexChanged() Handles comboboxDocumentoTipo.SelectedIndexChanged
        If Not comboboxDocumentoTipo.SelectedItem Is Nothing Then
            textboxDocumentoNumero.Visible = (CByte(comboboxDocumentoTipo.SelectedValue) > 0 AndAlso Not CType(comboboxDocumentoTipo.SelectedItem, DocumentoTipo).VerificaModulo11)
            maskedtextboxDocumentoNumero.Visible = (CByte(comboboxDocumentoTipo.SelectedValue) > 0 AndAlso Not textboxDocumentoNumero.Visible)
        End If
    End Sub

    Private Sub DocumentoNumero_LimpiarCaracteres(sender As Object, e As EventArgs) Handles textboxDocumentoNumero.LostFocus
        CType(sender, TextBox).Text = CType(sender, TextBox).Text.Replace(".", "")
    End Sub

    Private Sub LicenciaConducirNumeroCopiarNumeroDocumento() Handles buttonLicenciaConducirNumero.Click
        If CType(comboboxDocumentoTipo.SelectedItem, DocumentoTipo).VerificaModulo11 Then
            textboxLicenciaConducirNumero.Text = maskedtextboxDocumentoNumero.Text
        Else
            textboxLicenciaConducirNumero.Text = textboxDocumentoNumero.Text
        End If
    End Sub

    Private Sub DomicilioParticularProvincia_SelectedValueChanged() Handles comboboxDomicilioParticularProvincia.SelectedValueChanged
        If comboboxDomicilioParticularProvincia.SelectedValue Is Nothing Then
            pFillAndRefreshLists.Localidad(comboboxDomicilioParticularLocalidad, 0, True)
            comboboxDomicilioParticularLocalidad.SelectedIndex = 0
        Else
            pFillAndRefreshLists.Localidad(comboboxDomicilioParticularLocalidad, CByte(comboboxDomicilioParticularProvincia.SelectedValue), True)
            If CByte(comboboxDomicilioParticularProvincia.SelectedValue) = CS_Parameter.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID) Then
                CS_Control_ComboBox.SetSelectedValue(comboboxDomicilioParticularLocalidad, SelectedItemOptions.ValueOrFirst, CS_Parameter.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID))
            End If
        End If
    End Sub

    Private Sub DomicilioParticularLocalidad_SelectedValueChanged() Handles comboboxDomicilioParticularLocalidad.SelectedValueChanged
        If Not comboboxDomicilioParticularLocalidad.SelectedValue Is Nothing Then
            textboxDomicilioParticularCodigoPostal.Text = CType(comboboxDomicilioParticularLocalidad.SelectedItem, Localidad).CodigoPostal
        End If
    End Sub

    Private Sub DomicilioLaboralProvincia_SelectedValueChanged() Handles comboboxDomicilioLaboralProvincia.SelectedValueChanged
        If comboboxDomicilioLaboralProvincia.SelectedValue Is Nothing Then
            pFillAndRefreshLists.Localidad(comboboxDomicilioLaboralLocalidad, 0, True)
            comboboxDomicilioLaboralLocalidad.SelectedIndex = 0
        Else
            pFillAndRefreshLists.Localidad(comboboxDomicilioLaboralLocalidad, CByte(comboboxDomicilioLaboralProvincia.SelectedValue), True)
            If CByte(comboboxDomicilioLaboralProvincia.SelectedValue) = CS_Parameter.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID) Then
                CS_Control_ComboBox.SetSelectedValue(comboboxDomicilioLaboralLocalidad, SelectedItemOptions.ValueOrFirst, CS_Parameter.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID))
            End If
        End If
    End Sub

    Private Sub DomicilioLaboralLocalidad_SelectedValueChanged() Handles comboboxDomicilioLaboralLocalidad.SelectedValueChanged
        If Not comboboxDomicilioLaboralLocalidad.SelectedValue Is Nothing Then
            textboxDomicilioLaboralCodigoPostal.Text = CType(comboboxDomicilioLaboralLocalidad.SelectedItem, Localidad).CodigoPostal
        End If
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
                If Not CS_AFIP.VerificarCUIT(maskedtextboxDocumentoNumero.Text) Then
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
            If Not CS_Email.IsValidEmail(textboxEmailParticular.Text.Trim, CS_Parameter.GetString(Parametros.EMAIL_VALIDATION_REGULAREXPRESSION)) Then
                tabcontrolMain.SelectedTab = tabpageParticular
                MsgBox("La dirección de E-mail Particular es incorrecta.", vbInformation, My.Application.Info.Title)
                textboxEmailParticular.Focus()
                Exit Sub
            End If
        End If
        If textboxEmailLaboral.Text.Trim.Length > 0 Then
            If Not CS_Email.IsValidEmail(textboxEmailLaboral.Text.Trim, CS_Parameter.GetString(Parametros.EMAIL_VALIDATION_REGULAREXPRESSION)) Then
                tabcontrolMain.SelectedTab = tabpageParticular
                MsgBox("La dirección de E-mail Laboral es incorrecta.", vbInformation, My.Application.Info.Title)
                textboxEmailLaboral.Focus()
                Exit Sub
            End If
        End If

        ' Generar el ID de la Persona nueva
        If mPersonaActual.IDPersona = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.Persona.Count = 0 Then
                    mPersonaActual.IDPersona = 1
                Else
                    mPersonaActual.IDPersona = dbcMaxID.Persona.Max(Function(ent) ent.IDPersona) + 1
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
                If CS_Form.MDIChild_IsLoaded(CType(formMDIMain, Form), "formPersonas") Then
                    Dim formPersonas As formPersonas = CType(CS_Form.MDIChild_GetInstance(CType(formMDIMain, Form), "formPersonas"), formPersonas)
                    formPersonas.RefreshData(mPersonaActual.IDPersona)
                    formPersonas = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Persona con la misma Matrícula o Apellido y Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Case Errors.Unknown
                        CS_Error.ProcessError(CType(dbuex, Exception), My.Resources.STRING_ERROR_SAVING_CHANGES)
                End Select
                Exit Sub

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CS_Error.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
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
    Public Class Familiares_GridRowData
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
            CS_Error.ProcessError(ex, "Error al leer los Familiares.")
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

    Private Sub Familiares_Agregar() Handles buttonFamiliares_Agregar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_FAMILIAR_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewFamiliares.Enabled = False

            SetDataFromControlsToObject()

            Dim PersonaFamiliarNuevo As New PersonaFamiliar
            formPersonaFamiliar.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0)

            datagridviewFamiliares.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Familiares_Editar() Handles buttonFamiliares_Editar.Click
        If datagridviewFamiliares.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Familiar para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_FAMILIAR_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewFamiliares.Enabled = False

                Dim PersonaFamiliarActual As PersonaFamiliar

                PersonaFamiliarActual = mdbContext.PersonaFamiliar.Find(mPersonaActual.IDPersona, CType(datagridviewFamiliares.SelectedRows(0).DataBoundItem, Familiares_GridRowData).IDFamiliar)
                formPersonaFamiliar.LoadAndShow(True, Me, mPersonaActual.IDPersona, PersonaFamiliarActual.IDFamiliar)

                datagridviewFamiliares.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Familiares_Eliminar() Handles buttonFamiliares_Eliminar.Click
        If datagridviewFamiliares.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Familiar para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_FAMILIAR_ELIMINAR) Then
                Dim GridRowDataActual As Familiares_GridRowData
                Dim PersonaFamiliarEliminar As PersonaFamiliar

                GridRowDataActual = CType(datagridviewFamiliares.SelectedRows(0).DataBoundItem, Familiares_GridRowData)
                PersonaFamiliarEliminar = mdbContext.PersonaFamiliar.Find(mPersonaActual.IDPersona, GridRowDataActual.IDFamiliar)

                Dim Mensaje As String
                Mensaje = String.Format("Se eliminará el Familiar seleccionado.{0}{0}Parentesco: {1}{0}Apellido y Nombre: {2}, {3}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.ParentescoNombre, GridRowDataActual.Apellido, GridRowDataActual.Nombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    mPersonaActual.PersonaFamiliares.Remove(PersonaFamiliarEliminar)

                    Familiares_RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Familiares_Ver() Handles datagridviewFamiliares.DoubleClick
        If datagridviewFamiliares.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Familiar para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewFamiliares.Enabled = False

            Dim PersonaFamiliarActual As PersonaFamiliar

            PersonaFamiliarActual = mdbContext.PersonaFamiliar.Find(mPersonaActual.IDPersona, CType(datagridviewFamiliares.SelectedRows(0).DataBoundItem, Familiares_GridRowData).IDFamiliar)
            formPersonaFamiliar.LoadAndShow(mEditMode, Me, mPersonaActual.IDPersona, PersonaFamiliarActual.IDFamiliar)

            datagridviewFamiliares.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Altas-Bajas"
    Public Class AltasBajas_GridRowData
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
                              Order By pab.AltaFecha
                              Select New AltasBajas_GridRowData With {.IDAltaBaja = pab.IDAltaBaja, .AltaFecha = pab.AltaFecha, .BajaFecha = pab.BajaFecha, .BajaMotivoNombre = If(pbmg Is Nothing, "", pbmg.Nombre)}).ToList

            datagridviewAltasBajas.AutoGenerateColumns = False
            datagridviewAltasBajas.DataSource = listAltasBajas

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al leer las Altas-Bajas.")
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

    Private Sub AltasBajas_Agregar() Handles buttonAltasBajas_Agregar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_ALTABAJA_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewAltasBajas.Enabled = False

            SetDataFromControlsToObject()

            Dim PersonaAltaBajaNuevo As New PersonaAltaBaja
            formPersonaAltaBaja.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0)

            datagridviewAltasBajas.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub AltasBajas_Editar() Handles buttonAltasBajas_Editar.Click
        If datagridviewAltasBajas.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Alta-Baja para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_ALTABAJA_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewAltasBajas.Enabled = False

                Dim PersonaAltaBajaActual As PersonaAltaBaja

                PersonaAltaBajaActual = mdbContext.PersonaAltaBaja.Find(mPersonaActual.IDPersona, CType(datagridviewAltasBajas.SelectedRows(0).DataBoundItem, AltasBajas_GridRowData).IDAltaBaja)
                formPersonaAltaBaja.LoadAndShow(True, Me, mPersonaActual.IDPersona, PersonaAltaBajaActual.IDAltaBaja)

                datagridviewAltasBajas.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub AltasBajas_Eliminar() Handles buttonAltasBajas_Eliminar.Click
        If datagridviewAltasBajas.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Alta-Baja para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_ALTABAJA_ELIMINAR) Then
                Dim GridRowDataActual As AltasBajas_GridRowData
                Dim PersonaAltaBajaEliminar As PersonaAltaBaja

                GridRowDataActual = CType(datagridviewAltasBajas.SelectedRows(0).DataBoundItem, AltasBajas_GridRowData)
                PersonaAltaBajaEliminar = mdbContext.PersonaAltaBaja.Find(mPersonaActual.IDPersona, GridRowDataActual.IDAltaBaja)

                Dim Mensaje As String
                Mensaje = String.Format("Se eliminará la Alta-Baja seleccionada.{0}{0}Fecha Alta: {1}{0}Fecha Baja: {2}{0}Motivo de Baja: {3}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.AltaFecha, GridRowDataActual.BajaFecha, GridRowDataActual.BajaMotivoNombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    mPersonaActual.PersonaAltasBajas.Remove(PersonaAltaBajaEliminar)

                    AltasBajas_RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub AltasBajas_Ver() Handles datagridviewAltasBajas.DoubleClick
        If datagridviewAltasBajas.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Alta-Baja para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewAltasBajas.Enabled = False

            Dim PersonaAltaBajaActual As PersonaAltaBaja

            PersonaAltaBajaActual = mdbContext.PersonaAltaBaja.Find(mPersonaActual.IDPersona, CType(datagridviewAltasBajas.SelectedRows(0).DataBoundItem, AltasBajas_GridRowData).IDAltaBaja)
            formPersonaAltaBaja.LoadAndShow(mEditMode, Me, mPersonaActual.IDPersona, PersonaAltaBajaActual.IDAltaBaja)

            datagridviewAltasBajas.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Ascensos"
    Public Class Ascensos_GridRowData
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
                              Order By pa.Fecha
                              Select New Ascensos_GridRowData With {.IDAscenso = pa.IDAscenso, .Fecha = pa.Fecha, .CargoNombre = c.Nombre, .JerarquiaNombre = cj.Nombre}).ToList

            datagridviewAscensos.AutoGenerateColumns = False
            datagridviewAscensos.DataSource = listAscensos

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al leer los Ascensos.")
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

    Private Sub Ascensos_Agregar() Handles buttonAscensos_Agregar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_ASCENSO_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewAscensos.Enabled = False

            SetDataFromControlsToObject()

            Dim PersonaAscensoNuevo As New PersonaAscenso
            formPersonaAscenso.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0)

            datagridviewAscensos.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Ascensos_Editar() Handles buttonAscensos_Editar.Click
        If datagridviewAscensos.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Ascenso - Promoción para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_ASCENSO_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewAscensos.Enabled = False

                Dim PersonaAscensoActual As PersonaAscenso

                PersonaAscensoActual = mdbContext.PersonaAscenso.Find(mPersonaActual.IDPersona, CType(datagridviewAscensos.SelectedRows(0).DataBoundItem, Ascensos_GridRowData).IDAscenso)
                formPersonaAscenso.LoadAndShow(True, Me, mPersonaActual.IDPersona, PersonaAscensoActual.IDAscenso)

                datagridviewAscensos.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Ascensos_Eliminar() Handles buttonAscensos_Eliminar.Click
        If datagridviewAscensos.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Ascenso - Promoción para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_ASCENSO_ELIMINAR) Then
                Dim GridRowDataActual As Ascensos_GridRowData
                Dim PersonaAscensoEliminar As PersonaAscenso

                GridRowDataActual = CType(datagridviewAscensos.SelectedRows(0).DataBoundItem, Ascensos_GridRowData)
                PersonaAscensoEliminar = mdbContext.PersonaAscenso.Find(mPersonaActual.IDPersona, GridRowDataActual.IDAscenso)

                Dim Mensaje As String
                Mensaje = String.Format("Se eliminará el Ascenso - Promoción seleccionado.{0}{0}Fecha: {1}{0}Cargo: {2}{0}Jerarquía: {3}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.Fecha, GridRowDataActual.CargoNombre, GridRowDataActual.JerarquiaNombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    mPersonaActual.PersonaAscensos.Remove(PersonaAscensoEliminar)

                    Ascensos_RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Ascensos_Ver() Handles datagridviewAscensos.DoubleClick
        If datagridviewAscensos.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Ascenso - Promoción para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewAscensos.Enabled = False

            Dim PersonaAscensoActual As PersonaAscenso

            PersonaAscensoActual = mdbContext.PersonaAscenso.Find(mPersonaActual.IDPersona, CType(datagridviewAscensos.SelectedRows(0).DataBoundItem, Ascensos_GridRowData).IDAscenso)
            formPersonaAscenso.LoadAndShow(mEditMode, Me, mPersonaActual.IDPersona, PersonaAscensoActual.IDAscenso)

            datagridviewAscensos.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Licencias"
    Public Class Licencias_GridRowData
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
                              Order By pl.Fecha
                              Select New Licencias_GridRowData With {.IDLicencia = pl.IDLicencia, .Fecha = pl.Fecha, .LicenciaCausaNombre = lc.Nombre, .FechaDesde = pl.FechaDesde, .FechaHasta = pl.FechaHasta}).ToList

            datagridviewLicencias.AutoGenerateColumns = False
            datagridviewLicencias.DataSource = listLicencias

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al leer las Licencias.")
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

    Private Sub Licencias_Agregar() Handles buttonLicencias_Agregar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_LICENCIA_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewLicencias.Enabled = False

            SetDataFromControlsToObject()

            Dim PersonaLicenciaNuevo As New PersonaLicencia
            formPersonaLicencia.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0)

            datagridviewLicencias.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Licencias_Editar() Handles buttonLicencias_Editar.Click
        If datagridviewLicencias.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Licencia para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_LICENCIA_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewLicencias.Enabled = False

                Dim PersonaLicenciaActual As PersonaLicencia

                PersonaLicenciaActual = mdbContext.PersonaLicencia.Find(mPersonaActual.IDPersona, CType(datagridviewLicencias.SelectedRows(0).DataBoundItem, Licencias_GridRowData).IDLicencia)
                formPersonaLicencia.LoadAndShow(True, Me, mPersonaActual.IDPersona, PersonaLicenciaActual.IDLicencia)

                datagridviewLicencias.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Licencias_Eliminar() Handles buttonLicencias_Eliminar.Click
        If datagridviewLicencias.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Licencia para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_LICENCIA_ELIMINAR) Then
                Dim GridRowDataActual As Licencias_GridRowData
                Dim PersonaLicenciaEliminar As PersonaLicencia

                GridRowDataActual = CType(datagridviewLicencias.SelectedRows(0).DataBoundItem, Licencias_GridRowData)
                PersonaLicenciaEliminar = mdbContext.PersonaLicencia.Find(mPersonaActual.IDPersona, GridRowDataActual.IDLicencia)

                Dim Mensaje As String
                Mensaje = String.Format("Se eliminará la Licencia seleccionada.{0}{0}Fecha: {1}{0}Causa: {2}{0}Fecha desde: {3}{0}Fecha hasta: {4}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.Fecha, GridRowDataActual.LicenciaCausaNombre, GridRowDataActual.FechaDesde, GridRowDataActual.FechaHasta)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    mPersonaActual.PersonaLicencia.Remove(PersonaLicenciaEliminar)

                    Licencias_RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Licencias_Ver() Handles datagridviewLicencias.DoubleClick
        If datagridviewLicencias.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Licencia para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewLicencias.Enabled = False

            Dim PersonaLicenciaActual As PersonaLicencia

            PersonaLicenciaActual = mdbContext.PersonaLicencia.Find(mPersonaActual.IDPersona, CType(datagridviewLicencias.SelectedRows(0).DataBoundItem, Licencias_GridRowData).IDLicencia)
            formPersonaLicencia.LoadAndShow(mEditMode, Me, mPersonaActual.IDPersona, PersonaLicenciaActual.IDLicencia)

            datagridviewLicencias.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Sanciones"
    Public Class Sanciones_GridRowData
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
                            Order By ps.SolicitudFecha
                            Select New Sanciones_GridRowData With {.IDSancion = ps.IDSancion, .SolicitudFecha = ps.SolicitudFecha, .SancionTipoNombre = If(stg Is Nothing, "", stg.Nombre)}).ToList

            datagridviewSanciones.AutoGenerateColumns = False
            datagridviewSanciones.DataSource = listSancions

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al leer las Sanciones.")
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

    Private Sub Sanciones_Agregar() Handles buttonSanciones_Agregar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_SANCION_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewSanciones.Enabled = False

            SetDataFromControlsToObject()

            Dim PersonaSancionNuevo As New PersonaSancion
            formPersonaSancion.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0)

            datagridviewSanciones.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Sanciones_Editar() Handles buttonSanciones_Editar.Click
        If datagridviewSanciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Sanción para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_SANCION_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewSanciones.Enabled = False

                Dim PersonaSancionActual As PersonaSancion

                PersonaSancionActual = mdbContext.PersonaSancion.Find(mPersonaActual.IDPersona, CType(datagridviewSanciones.SelectedRows(0).DataBoundItem, Sanciones_GridRowData).IDSancion)
                formPersonaSancion.LoadAndShow(True, Me, mPersonaActual.IDPersona, PersonaSancionActual.IDSancion)

                datagridviewSanciones.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Sanciones_Eliminar() Handles buttonSanciones_Eliminar.Click
        If datagridviewSanciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Sanción para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_SANCION_ELIMINAR) Then
                Dim GridRowDataActual As Sanciones_GridRowData
                Dim PersonaSancionEliminar As PersonaSancion

                GridRowDataActual = CType(datagridviewSanciones.SelectedRows(0).DataBoundItem, Sanciones_GridRowData)
                PersonaSancionEliminar = mdbContext.PersonaSancion.Find(mPersonaActual.IDPersona, GridRowDataActual.IDSancion)

                Dim Mensaje As String
                Mensaje = String.Format("Se eliminará la Sanción seleccionada.{0}{0}Fecha de solicitud: {1}{0}Tipo: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.SolicitudFecha, GridRowDataActual.SancionTipoNombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    mPersonaActual.PersonaSancion.Remove(PersonaSancionEliminar)

                    Sanciones_RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Sanciones_Ver() Handles datagridviewSanciones.DoubleClick
        If datagridviewSanciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Sancion para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewSanciones.Enabled = False

            Dim PersonaSancionActual As PersonaSancion

            PersonaSancionActual = mdbContext.PersonaSancion.Find(mPersonaActual.IDPersona, CType(datagridviewSanciones.SelectedRows(0).DataBoundItem, Sanciones_GridRowData).IDSancion)
            formPersonaSancion.LoadAndShow(mEditMode, Me, mPersonaActual.IDPersona, PersonaSancionActual.IDSancion)

            datagridviewSanciones.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Capacitaciones"
    Public Class Capacitaciones_GridRowData
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
                              Order By pc.Fecha
                              Select New Capacitaciones_GridRowData With {.IDCapacitacion = pc.IDCapacitacion, .Fecha = pc.Fecha, .CursoNombre = c.Nombre}).ToList

            datagridviewCapacitaciones.AutoGenerateColumns = False
            datagridviewCapacitaciones.DataSource = listCapacitaciones

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al leer las Capacitacione.")
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

#End Region

#Region "Calificaciones"
    Public Class Calificaciones_GridRowData
        Public Property Anio As Short
        Public Property InstanciaNumero As Byte
        Public Property AnioInstancia As String
        Public Property ConceptosCalificaciones As String = ""
    End Class

    Friend Sub Calificaciones_RefreshData(Optional ByVal PositionAnio As Short = 0, Optional ByVal PositionInstanciaNumero As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listCalificaciones As List(Of Calificaciones_GridRowData)

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
            'listCalificaciones = (From pc In mdbContext.PersonaCalificacion
            '                      Join cc In mdbContext.CalificacionConcepto On pc.IDCalificacionConcepto Equals cc.IDCalificacionConcepto
            '                      Where pc.IDPersona = mPersonaActual.IDPersona
            '                      Order By pc.Anio, pc.InstanciaNumero
            '                      Select New GridRowData_Calificaciones With {.anio = pc.anio, .InstanciaNumero = pc.InstanciaNumero , .AnioInstancia  = pc., .FechaDesde = pl.FechaDesde, .FechaHasta = pl.FechaHasta}).ToList

            datagridviewCalificaciones.AutoGenerateColumns = False
            datagridviewCalificaciones.DataSource = listCalificaciones

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al leer las Calificaciones.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        'If PositionAnio <> 0 Then
        '    For Each CurrentRowChecked As DataGridViewRow In datagridviewCalificaciones.Rows
        '        If CType(CurrentRowChecked.DataBoundItem, GridRowData).Anio = PositionAnio And CType(CurrentRowChecked.DataBoundItem, GridRowData).InstanciaNumero = PositionInstanciaNumero Then
        '            datagridviewCalificaciones.CurrentCell = CurrentRowChecked.Cells(columnAnioInstancia.Name)
        '            Exit For
        '        End If
        '    Next
        'End If
    End Sub

#End Region

#Region "Exámenes"
    Public Class Examenes_GridRowData
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
                            Order By pe.Anio, pe.InstanciaNumero
                            Select New Examenes_GridRowData With {.Anio = pe.Anio, .InstanciaNumero = pe.InstanciaNumero, .Calificacion = pe.Calificacion}).ToList

            datagridviewExamenes.AutoGenerateColumns = False
            datagridviewExamenes.DataSource = listExamenes

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al leer los Exámenes.")
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

#End Region

#Region "Extra stuff"

#End Region

End Class