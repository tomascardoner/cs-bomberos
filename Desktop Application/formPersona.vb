Public Class formPersona

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaActual As Persona

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False

    Public Class GridRowData_Familiar
        Public Property IDFamiliar As Byte
        Public Property Parentesco As String
        Public Property Apellido As String
        Public Property Nombre As String
    End Class
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

        textboxMatriculaNumero.ReadOnly = (mEditMode = False)
        textboxApellido.ReadOnly = (mEditMode = False)
        textboxNombre.ReadOnly = (mEditMode = False)

        ' General
        comboboxDocumentoTipo.Enabled = mEditMode
        textboxDocumentoNumero.ReadOnly = (mEditMode = False)
        maskedtextboxDocumentoNumero.ReadOnly = (mEditMode = False)
        datetimepickerFechaNacimiento.Enabled = mEditMode
        comboboxGenero.Enabled = mEditMode
        comboboxGrupoSanguineo.Enabled = mEditMode
        comboboxFactorRH.Enabled = mEditMode
        comboboxNivelEstudio.Enabled = mEditMode
        textboxProfesion.ReadOnly = (mEditMode = False)
        textboxNacionalidad.ReadOnly = (mEditMode = False)
        comboboxCuartel.Enabled = mEditMode
        comboboxEstado.Enabled = mEditMode
        comboboxCantidadHijos.Enabled = mEditMode

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

        ' Familiares
        toolstripFamiliares.Enabled = mEditMode

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
        pFillAndRefreshLists.NivelEstudio(comboboxNivelEstudio, False, True)
        pFillAndRefreshLists.Cuartel(comboboxCuartel, False, False)
        comboboxCantidadHijos.Items.AddRange({My.Resources.STRING_ITEM_NOT_SPECIFIED, "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        pFillAndRefreshLists.Estado(comboboxEstado, False, False)
        pFillAndRefreshLists.Provincia(comboboxDomicilioParticularProvincia, True)
        pFillAndRefreshLists.Provincia(comboboxDomicilioLaboralProvincia, True)

        textboxMatriculaNumero.MaxLength = CS_Parameter.GetIntegerAsByte(Parametros.PERSONA_CODIGO_DIGITOS, 5)
    End Sub

    Friend Sub SetAppearance()
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
            ' Datos del Encabezado
            If .IDPersona = 0 Then
                textboxIDPersona.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDPersona.Text = String.Format(.IDPersona.ToString, "G")
            End If

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
            datetimepickerFechaNacimiento.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaNacimiento, datetimepickerFechaNacimiento)
            CS_Control_ComboBox.SetSelectedValue(comboboxGenero, SelectedItemOptions.Value, .Genero, Constantes.PERSONA_GENERO_NOESPECIFICA)
            CS_Control_ComboBox.SetSelectedValue(comboboxGrupoSanguineo, SelectedItemOptions.Value, .GrupoSanguineo, "")
            CS_Control_ComboBox.SetSelectedValue(comboboxFactorRH, SelectedItemOptions.Value, .FactorRH, "")
            CS_Control_ComboBox.SetSelectedValue(comboboxNivelEstudio, SelectedItemOptions.ValueOrFirst, .IDNivelEstudio)

            textboxProfesion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Profesion)
            textboxNacionalidad.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nacionalidad)
            CS_Control_ComboBox.SetSelectedValue(comboboxCuartel, SelectedItemOptions.ValueOrFirstIfUnique, .IDCuartel)
            CS_Control_ComboBox.SetSelectedValue(comboboxEstado, SelectedItemOptions.Value, .Estado)
            If .CantidadHijos Is Nothing Then
                comboboxCantidadHijos.SelectedIndex = 0
            Else
                comboboxCantidadHijos.SelectedIndex = .CantidadHijos.Value
            End If

            ' Datos de la pestaña Contacto Particular
            textboxDomicilioParticularCalle1.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularCalle1)
            textboxDomicilioParticularNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularNumero)
            textboxDomicilioParticularPiso.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularPiso)
            textboxDomicilioParticularDepartamento.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularDepartamento)
            textboxDomicilioParticularCalle2.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularCalle2)
            textboxDomicilioParticularCalle3.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioParticularCalle3)
            CS_Control_ComboBox.SetSelectedValue(comboboxDomicilioParticularProvincia, SelectedItemOptions.Value, .DomicilioParticularIDProvincia, Constantes.PROVINCIA_NOESPECIFICA)
            CS_Control_ComboBox.SetSelectedValue(comboboxDomicilioParticularLocalidad, SelectedItemOptions.Value, .DomicilioParticularIDLocalidad, 0)
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
            CS_Control_ComboBox.SetSelectedValue(comboboxDomicilioLaboralProvincia, SelectedItemOptions.Value, .DomicilioLaboralIDProvincia, Constantes.PROVINCIA_NOESPECIFICA)
            CS_Control_ComboBox.SetSelectedValue(comboboxDomicilioLaboralLocalidad, SelectedItemOptions.Value, .DomicilioLaboralIDLocalidad, 0)
            textboxDomicilioLaboralCodigoPostal.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioLaboralCodigoPostal)
            textboxTelefonoLaboral.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.TelefonoLaboral)
            textboxCelularLaboral.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.CelularLaboral)
            textboxEmailLaboral.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.EmailLaboral)

            ' Datos de la pestaña Familiares
            If .IDPersona > 0 Then
                RefreshData_Familiares()
            End If

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
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
            .FechaNacimiento = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaNacimiento.Value, datetimepickerFechaNacimiento.Checked)
            .Genero = CS_ValueTranslation.FromControlComboBoxToObjectString(comboboxGenero.SelectedValue)
            .GrupoSanguineo = CS_ValueTranslation.FromControlComboBoxToObjectString(comboboxGrupoSanguineo.SelectedValue)
            .FactorRH = CS_ValueTranslation.FromControlComboBoxToObjectString(comboboxFactorRH.SelectedValue)
            .IDNivelEstudio = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxNivelEstudio.SelectedValue)

            .Profesion = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxProfesion.Text)
            .Nacionalidad = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNacionalidad.Text)
            .IDCuartel = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCuartel.SelectedValue).Value
            .Estado = CS_ValueTranslation.FromControlComboBoxToObjectString(comboboxEstado.SelectedValue)
            If comboboxCantidadHijos.SelectedIndex = 0 Then
                .CantidadHijos = Nothing
            Else
                .CantidadHijos = CByte(comboboxCantidadHijos.SelectedIndex)
            End If

            ' Datos de la pestaña Contacto Particular
            .DomicilioParticularCalle1 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioParticularCalle1.Text)
            .DomicilioParticularNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioParticularNumero.Text)
            .DomicilioParticularPiso = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioParticularPiso.Text)
            .DomicilioParticularDepartamento = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioParticularDepartamento.Text)
            .DomicilioParticularCalle2 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioParticularCalle2.Text)
            .DomicilioParticularCalle3 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioParticularCalle3.Text)
            .DomicilioParticularIDProvincia = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxDomicilioParticularProvincia.SelectedValue, Constantes.PROVINCIA_NOESPECIFICA)
            .DomicilioParticularIDLocalidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxDomicilioParticularLocalidad.SelectedValue, 0)
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
            .DomicilioLaboralIDProvincia = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxDomicilioLaboralProvincia.SelectedValue, Constantes.PROVINCIA_NOESPECIFICA)
            .DomicilioLaboralIDLocalidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxDomicilioLaboralLocalidad.SelectedValue, 0)
            .DomicilioLaboralCodigoPostal = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioLaboralCodigoPostal.Text)
            .TelefonoLaboral = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxTelefonoLaboral.Text)
            .CelularLaboral = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCelularLaboral.Text)
            .EmailLaboral = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxEmailLaboral.Text)

            ' Datos de la pestaña Notas y Aditoría
            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
        End With
    End Sub

    Friend Sub RefreshData_Familiares(Optional ByVal PositionIDFamiliar As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listFamiliares As List(Of GridRowData_Familiar)

        If RestoreCurrentPosition Then
            If datagridviewFamiliares.CurrentRow Is Nothing Then
                PositionIDFamiliar = 0
            Else
                PositionIDFamiliar = CType(datagridviewFamiliares.CurrentRow.DataBoundItem, GridRowData_Familiar).IDFamiliar
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listFamiliares = (From pf In mPersonaActual.PersonaFamiliares
                              Group Join p In mdbContext.Parentesco On pf.IDParentesco Equals p.IDParentesco Into Parentescos_Group = Group
                              From pg In Parentescos_Group.DefaultIfEmpty
                              Select New GridRowData_Familiar With {.IDFamiliar = pf.IDFamiliar, .Parentesco = If(pg Is Nothing, My.Resources.STRING_ITEM_NOT_SPECIFIED, pg.Nombre), .Apellido = pf.Apellido, .Nombre = pf.Nombre}).ToList

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
                If CType(datagridviewFamiliares.CurrentRow.DataBoundItem, GridRowData_Familiar).IDFamiliar = PositionIDFamiliar Then
                    datagridviewFamiliares.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

#End Region

#Region "Controls behavior"
    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxIDPersona.GotFocus, textboxMatriculaNumero.GotFocus, textboxApellido.GotFocus, textboxNombre.GotFocus, textboxDocumentoNumero.GotFocus, textboxProfesion.GotFocus, textboxNacionalidad.GotFocus, textboxDomicilioParticularCalle1.GotFocus, textboxDomicilioParticularNumero.GotFocus, textboxDomicilioParticularPiso.GotFocus, textboxDomicilioParticularDepartamento.GotFocus, textboxDomicilioParticularCalle2.GotFocus, textboxDomicilioParticularCalle3.GotFocus, textboxDomicilioParticularCodigoPostal.GotFocus, textboxDomicilioLaboralCalle1.GotFocus, textboxDomicilioLaboralNumero.GotFocus, textboxDomicilioLaboralPiso.GotFocus, textboxDomicilioLaboralDepartamento.GotFocus, textboxDomicilioLaboralCalle2.GotFocus, textboxDomicilioLaboralCalle3.GotFocus, textboxDomicilioLaboralCodigoPostal.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub MaskedTextBoxs_GotFocus(sender As Object, e As EventArgs) Handles maskedtextboxDocumentoNumero.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
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

    Private Sub DomicilioParticularProvincia_SelectedValueChanged() Handles comboboxDomicilioParticularProvincia.SelectedValueChanged
        If comboboxDomicilioParticularProvincia.SelectedValue Is Nothing Then
            comboboxDomicilioParticularLocalidad.DataSource = Nothing
        Else
            pFillAndRefreshLists.Localidad(comboboxDomicilioParticularLocalidad, CByte(comboboxDomicilioParticularProvincia.SelectedValue), False)
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
            comboboxDomicilioLaboralLocalidad.DataSource = Nothing
        Else
            pFillAndRefreshLists.Localidad(comboboxDomicilioLaboralLocalidad, CByte(comboboxDomicilioLaboralProvincia.SelectedValue), False)
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
        ElseIf textboxMatriculaNumero.Text.Trim.Length <> CS_Parameter.GetIntegerAsByte(Parametros.PERSONA_CODIGO_DIGITOS, 5) Then
            MsgBox(String.Format("La Matrícula debe contener {0} dígitos.", CS_Parameter.GetIntegerAsByte(Parametros.PERSONA_CODIGO_DIGITOS, 5)), MsgBoxStyle.Information, My.Application.Info.Title)
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

        ' Estado
        If comboboxEstado.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Estado de la Persona.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxEstado.Focus()
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
                        MsgBox("No se pueden guardar los cambios porque ya existe una Persona con el mismo Apellido y Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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

#Region "Familiares Toolbar"
    Private Sub Familiares_Agregar() Handles buttonFamiliares_Agregar.Click
        Me.Cursor = Cursors.WaitCursor

        datagridviewFamiliares.Enabled = False

        SetDataFromControlsToObject()

        Dim PersonaFamiliarNuevo As New PersonaFamiliar
        formPersonaFamiliar.LoadAndShow(True, True, Me, mPersonaActual, PersonaFamiliarNuevo)

        datagridviewFamiliares.Enabled = True

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Familiares_Editar() Handles buttonFamiliares_Editar.Click
        If datagridviewFamiliares.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Familiar para editar.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewFamiliares.Enabled = False

            Dim PersonaFamiliarActual As PersonaFamiliar

            PersonaFamiliarActual = mdbContext.PersonaFamiliar.Find(mPersonaActual.IDPersona, CType(datagridviewFamiliares.SelectedRows(0).DataBoundItem, GridRowData_Familiar).IDFamiliar)
            formPersonaFamiliar.LoadAndShow(True, True, Me, mPersonaActual, PersonaFamiliarActual)

            datagridviewFamiliares.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Familiares_Eliminar() Handles buttonFamiliares_Eliminar.Click
        If datagridviewFamiliares.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Familiar para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            Dim PersonaFamiliarEliminar As PersonaFamiliar
            PersonaFamiliarEliminar = mdbContext.PersonaFamiliar.Find(mPersonaActual.IDPersona, CType(datagridviewFamiliares.SelectedRows(0).DataBoundItem, GridRowData_Familiar).IDFamiliar)

            Dim Mensaje As String
            Mensaje = String.Format("Se eliminará el Familiar seleccionado.{0}{0}Parentesco: {1}{0}Apellido y Nombre: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, PersonaFamiliarEliminar.Parentesco.Nombre, PersonaFamiliarEliminar.ApellidoNombre)
            If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                mPersonaActual.PersonaFamiliares.Remove(PersonaFamiliarEliminar)

                RefreshData_Familiares()

                Me.Cursor = Cursors.Default
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

            PersonaFamiliarActual = mdbContext.PersonaFamiliar.Find(mPersonaActual.IDPersona, CType(datagridviewFamiliares.SelectedRows(0).DataBoundItem, GridRowData_Familiar).IDFamiliar)
            formPersonaFamiliar.LoadAndShow(mEditMode, False, Me, mPersonaActual, PersonaFamiliarActual)

            datagridviewFamiliares.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Extra stuff"

#End Region

End Class