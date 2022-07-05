Public Class formPersonaFamiliar

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaFamiliarActual As PersonaFamiliar

    Private mIsLoading As Boolean
    Private mEditMode As Boolean
#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer, ByVal IDFamiliar As Byte)
        mIsLoading = True
        mEditMode = EditMode

        If IDFamiliar = 0 Then
            ' Es Nuevo
            mPersonaFamiliarActual = New PersonaFamiliar
            With mPersonaFamiliarActual
                .IDPersona = IDPersona

                .ACargo = True
                .Vive = True
                .EsEmergencia = False
                .DomicilioIDProvincia = CS_Parameter_System.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID)
                .DomicilioIDLocalidad = CS_Parameter_System.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID)
                .DomicilioCodigoPostal = CS_Parameter_System.GetString(Parametros.DEFAULT_CODIGOPOSTAL)
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.PersonaFamiliar.Add(mPersonaFamiliarActual)
        Else
            mPersonaFamiliarActual = mdbContext.PersonaFamiliar.Find(IDPersona, IDFamiliar)
        End If

        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()

        mIsLoading = False

        ChangeMode()

        Me.ShowDialog(ParentForm)
    End Sub

    Private Sub ChangeMode()
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = Not mEditMode
        buttonCerrar.Visible = Not mEditMode

        textboxApellido.ReadOnly = (mEditMode = False)
        textboxNombre.ReadOnly = (mEditMode = False)

        ' General
        comboboxParentesco.Enabled = mEditMode
        comboboxDocumentoTipo.Enabled = mEditMode
        textboxDocumentoNumero.ReadOnly = (mEditMode = False)
        maskedtextboxDocumentoNumero.ReadOnly = (mEditMode = False)
        datetimepickerFechaNacimiento.Enabled = mEditMode
        comboboxGenero.Enabled = mEditMode
        comboboxGrupoSanguineo.Enabled = mEditMode
        comboboxFactorRH.Enabled = mEditMode
        comboboxEstadoCivil.Enabled = mEditMode
        comboboxIOMATiene.Enabled = mEditMode
        textboxIOMANumeroAfiliado.ReadOnly = (mEditMode = False)
        checkboxIOMAACargo.Enabled = mEditMode
        datetimepickerIOMAVencimientoCredencial.Enabled = mEditMode
        labelIOMACertificacion.Visible = (mEditMode = False)
        buttonIOMACertificacionAbrir.Visible = (mEditMode = False)
        buttonIOMACertificacionCompletar.Visible = (mEditMode = False)
        checkboxACargo.Enabled = mEditMode
        checkboxVive.Enabled = mEditMode
        checkboxEsEmergencia.Enabled = mEditMode

        ' Contacto
        textboxDomicilioCalle1.ReadOnly = (mEditMode = False)
        textboxDomicilioNumero.ReadOnly = (mEditMode = False)
        textboxDomicilioPiso.ReadOnly = (mEditMode = False)
        textboxDomicilioDepartamento.ReadOnly = (mEditMode = False)
        textboxDomicilioCalle2.ReadOnly = (mEditMode = False)
        textboxDomicilioCalle3.ReadOnly = (mEditMode = False)
        comboboxDomicilioProvincia.Enabled = mEditMode
        comboboxDomicilioLocalidad.Enabled = mEditMode
        textboxDomicilioCodigoPostal.ReadOnly = (mEditMode = False)
        textboxTelefono.ReadOnly = (mEditMode = False)
        textboxCelular.ReadOnly = (mEditMode = False)
        textboxEmail.ReadOnly = (mEditMode = False)

        ' Notas y Auditoría
        textboxNotas.ReadOnly = (mEditMode = False)
        checkboxEsActivo.Enabled = mEditMode

    End Sub

    Friend Sub InitializeFormAndControls()
        ' Cargo los ComboBox
        pFillAndRefreshLists.Parentesco(comboboxParentesco, False, True)
        pFillAndRefreshLists.DocumentoTipo(comboboxDocumentoTipo, True)
        FillAndRefreshLists.Genero(comboboxGenero, False)
        FillAndRefreshLists.GrupoSanguineo(comboboxGrupoSanguineo, True)
        FillAndRefreshLists.FactorRH(comboboxFactorRH, True)
        pFillAndRefreshLists.EstadoCivil(comboboxEstadoCivil, False, True)
        comboboxIOMATiene.Items.AddRange({My.Resources.STRING_ITEM_NOT_SPECIFIED, PERSONA_TIENEIOMA_NOTIENE_NOMBRE, PERSONA_TIENEIOMA_PORBOMBEROS_NOMBRE, PERSONA_TIENEIOMA_PORTRABAJO_NOMBRE})
        pFillAndRefreshLists.Provincia(comboboxDomicilioProvincia, True)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mPersonaFamiliarActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mPersonaFamiliarActual
            ' Datos del Encabezado
            textboxApellido.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Apellido)
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)

            ' Datos de la pestaña General
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxParentesco, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDParentesco, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            If .IDParentesco = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE Then
                textboxParentescoOtro.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.ParentescoOtro)
            Else
                textboxParentescoOtro.Text = ""
            End If
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxDocumentoTipo, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, .IDDocumentoTipo, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            If CType(comboboxDocumentoTipo.SelectedItem, DocumentoTipo).VerificaModulo11 Then
                maskedtextboxDocumentoNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DocumentoNumero)
            Else
                textboxDocumentoNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DocumentoNumero)
            End If
            datetimepickerFechaNacimiento.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaNacimiento, datetimepickerFechaNacimiento)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxGenero, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .Genero, Constantes.PERSONA_GENERO_NOESPECIFICA)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxGrupoSanguineo, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .GrupoSanguineo, "")
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxFactorRH, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .FactorRH, "")
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxEstadoCivil, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, .IDEstadoCivil, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
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
            checkboxIOMAACargo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.IOMAACargo)
            datetimepickerIOMAVencimientoCredencial.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.IOMAVencimientoCredencial, datetimepickerIOMAVencimientoCredencial)
            checkboxACargo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.ACargo)
            checkboxVive.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Vive)
            checkboxEsEmergencia.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsEmergencia)

            ' Datos de la pestaña Contacto Particular
            textboxDomicilioCalle1.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioCalle1)
            textboxDomicilioNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioNumero)
            textboxDomicilioPiso.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioPiso)
            textboxDomicilioDepartamento.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioDepartamento)
            textboxDomicilioCalle2.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioCalle2)
            textboxDomicilioCalle3.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioCalle3)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxDomicilioProvincia, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .DomicilioIDProvincia, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxDomicilioLocalidad, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .DomicilioIDLocalidad, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            textboxDomicilioCodigoPostal.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioCodigoPostal)
            textboxTelefono.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Telefono)
            textboxCelular.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Celular)
            textboxEmail.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Email)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            If .IDFamiliar = 0 Then
                textboxIDFamiliar.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDFamiliar.Text = String.Format(.IDFamiliar.ToString, "G")
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
        With mPersonaFamiliarActual
            ' Datos del Encabezado
            .Apellido = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxApellido.Text)
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)

            ' Datos de la pestaña General
            .IDParentesco = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxParentesco.SelectedValue)
            If CByte(comboboxParentesco.SelectedValue) = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE Then
                .ParentescoOtro = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxParentescoOtro.Text)
            Else
                .ParentescoOtro = Nothing
            End If
            .IDDocumentoTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxDocumentoTipo.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            If CType(comboboxDocumentoTipo.SelectedItem, DocumentoTipo).VerificaModulo11 Then
                .DocumentoNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(maskedtextboxDocumentoNumero.Text)
            Else
                .DocumentoNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDocumentoNumero.Text)
            End If
            .FechaNacimiento = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaNacimiento.Value, datetimepickerFechaNacimiento.Checked)
            .Genero = CS_ValueTranslation.FromControlComboBoxToObjectString(comboboxGenero.SelectedValue)
            .GrupoSanguineo = CS_ValueTranslation.FromControlComboBoxToObjectString(comboboxGrupoSanguineo.SelectedValue)
            .FactorRH = CS_ValueTranslation.FromControlComboBoxToObjectString(comboboxFactorRH.SelectedValue)
            .IDEstadoCivil = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxEstadoCivil.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
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
            .IOMAACargo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxIOMAACargo.CheckState)
            .IOMAVencimientoCredencial = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerIOMAVencimientoCredencial.Value, datetimepickerIOMAVencimientoCredencial.Checked)
            .ACargo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxACargo.CheckState)
            .Vive = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxVive.CheckState)
            .EsEmergencia = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsEmergencia.CheckState)

            ' Datos de la pestaña Contacto
            .DomicilioCalle1 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioCalle1.Text)
            .DomicilioNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioNumero.Text)
            .DomicilioPiso = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioPiso.Text)
            .DomicilioDepartamento = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioDepartamento.Text)
            .DomicilioCalle2 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioCalle2.Text)
            .DomicilioCalle3 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioCalle3.Text)
            .DomicilioIDProvincia = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxDomicilioProvincia.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            .DomicilioIDLocalidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxDomicilioLocalidad.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            .DomicilioCodigoPostal = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioCodigoPostal.Text)
            .Telefono = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxTelefono.Text)
            .Celular = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCelular.Text)
            .Email = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxEmail.Text)

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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxApellido.GotFocus, textboxNombre.GotFocus, textboxDocumentoNumero.GotFocus, textboxDomicilioCalle1.GotFocus, textboxDomicilioNumero.GotFocus, textboxDomicilioPiso.GotFocus, textboxDomicilioDepartamento.GotFocus, textboxDomicilioCalle2.GotFocus, textboxDomicilioCalle3.GotFocus, textboxDomicilioCodigoPostal.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub MaskedTextBoxs_GotFocus(sender As Object, e As EventArgs) Handles maskedtextboxDocumentoNumero.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
    End Sub

    Private Sub Parentesco_Cambio(sender As Object, e As EventArgs) Handles comboboxParentesco.SelectedIndexChanged
        If comboboxParentesco.SelectedItem IsNot Nothing Then
            textboxParentescoOtro.Visible = (CByte(comboboxParentesco.SelectedValue) = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE)
        End If
    End Sub

    Private Sub IOMACertificacionAbrir(sender As Object, e As EventArgs) Handles buttonIOMACertificacionAbrir.Click
        CardonerSistemas.Process.Start(CS_Parameter_System.GetString(Parametros.IOMA_CERTIFICACION_DIRECCION))
    End Sub

    Private Sub IOMACertificacionCompletar(sender As Object, e As EventArgs) Handles buttonIOMACertificacionCompletar.Click
        CompletarFormulariosExternos.CompletarPersonaFamiliar(CS_Parameter_System.GetString(Parametros.IOMA_CERTIFICACION_CAMPOS), mPersonaFamiliarActual)
    End Sub

    Private Sub DocumentoTipo_Cambio(sender As Object, e As EventArgs) Handles comboboxDocumentoTipo.SelectedIndexChanged
        If comboboxDocumentoTipo.SelectedItem IsNot Nothing Then
            textboxDocumentoNumero.Visible = (CByte(comboboxDocumentoTipo.SelectedValue) > 0 AndAlso Not CType(comboboxDocumentoTipo.SelectedItem, DocumentoTipo).VerificaModulo11)
            maskedtextboxDocumentoNumero.Visible = (CByte(comboboxDocumentoTipo.SelectedValue) > 0 AndAlso Not textboxDocumentoNumero.Visible)
        End If
    End Sub

    Private Sub DocumentoNumero_LimpiarCaracteres(sender As Object, e As EventArgs) Handles textboxDocumentoNumero.LostFocus
        CType(sender, TextBox).Text = CType(sender, TextBox).Text.Replace(".", "")
    End Sub

    Private Sub DomicilioProvincia_Cambio(sender As Object, e As EventArgs) Handles comboboxDomicilioProvincia.SelectedValueChanged
        If comboboxDomicilioProvincia.SelectedValue Is Nothing Then
            pFillAndRefreshLists.Localidad(comboboxDomicilioLocalidad, 0, True)
            comboboxDomicilioLocalidad.SelectedIndex = 0
        Else
            pFillAndRefreshLists.Localidad(comboboxDomicilioLocalidad, CByte(comboboxDomicilioProvincia.SelectedValue), True)
            If CByte(comboboxDomicilioProvincia.SelectedValue) = CS_Parameter_System.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID) Then
                CardonerSistemas.ComboBox.SetSelectedValue(comboboxDomicilioLocalidad, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, CS_Parameter_System.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID))
            End If
        End If
    End Sub

    Private Sub DomicilioLocalidad_Cambio(sender As Object, e As EventArgs) Handles comboboxDomicilioLocalidad.SelectedValueChanged
        If comboboxDomicilioLocalidad.SelectedValue IsNot Nothing Then
            textboxDomicilioCodigoPostal.Text = CType(comboboxDomicilioLocalidad.SelectedItem, Localidad).CodigoPostal.ToString()
        End If
    End Sub

#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_FAMILIAR_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
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

        ' Parentesco
        If comboboxGenero.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Género.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxGenero.Focus()
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
        If datetimepickerFechaNacimiento.Checked And datetimepickerFechaNacimiento.Value.Year > Today.Year Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("La fecha de nacimiento especificada es mayor al año actual.", MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerFechaNacimiento.Focus()
            Exit Sub
        End If

        ' Genero
        If comboboxGenero.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Género del Familiar.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxGenero.Focus()
            Exit Sub
        End If

        ' Dirección de Email
        If textboxEmail.Text.Trim.Length > 0 Then
            If Not CS_Email.IsValidEmail(textboxEmail.Text.Trim, CS_Parameter_System.GetString(Parametros.EMAIL_VALIDATION_REGULAREXPRESSION)) Then
                tabcontrolMain.SelectedTab = tabpageContacto
                MsgBox("La dirección de E-mail es incorrecta.", vbInformation, My.Application.Info.Title)
                textboxEmail.Focus()
                Exit Sub
            End If
        End If

        ' Generar el ID nuevo
        If mPersonaFamiliarActual.IDFamiliar = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                Dim PersonaActual As Persona
                PersonaActual = dbcMaxID.Persona.Find(mPersonaFamiliarActual.IDPersona)
                If PersonaActual.PersonaFamiliares.Count = 0 Then
                    mPersonaFamiliarActual.IDFamiliar = 1
                Else
                    mPersonaFamiliarActual.IDFamiliar = PersonaActual.PersonaFamiliares.Max(Function(pf) pf.IDFamiliar) + CByte(1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mPersonaFamiliarActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mPersonaFamiliarActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formPersona") Then
                    Dim formPersona As formPersona = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formPersona"), formPersona)
                    formPersona.Familiares_RefreshData(mPersonaFamiliarActual.IDFamiliar)
                    formPersona = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Familiar con los mismos datos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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
#End Region

End Class