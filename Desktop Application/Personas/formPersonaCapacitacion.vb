Public Class formPersonaCapacitacion

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaCapacitacionActual As PersonaCapacitacion

    Private mIsLoading As Boolean
    Private mEditMode As Boolean
#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer, ByVal IDCapacitacion As Short)
        mIsLoading = True
        mEditMode = EditMode

        If IDCapacitacion = 0 Then
            ' Es Nuevo
            mPersonaCapacitacionActual = New PersonaCapacitacion
            With mPersonaCapacitacionActual
                .IDPersona = IDPersona

                .Fecha = DateTime.Today
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.PersonaCapacitacion.Add(mPersonaCapacitacionActual)
        Else
            mPersonaCapacitacionActual = mdbContext.PersonaCapacitacion.Find(IDPersona, IDCapacitacion)
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
            Exit Sub
        End If

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        ' General
        datetimepickerFecha.Enabled = mEditMode
        comboboxCurso.Enabled = mEditMode
        comboboxProvincia.Enabled = mEditMode
        comboboxLocalidad.Enabled = mEditMode
        comboboxCapacitacionNivel.Enabled = mEditMode
        textboxCapacitacionNivelOtro.ReadOnly = Not mEditMode
        comboboxCapacitacionTipo.Enabled = mEditMode
        textboxCapacitacionTipoOtro.ReadOnly = Not mEditMode
        maskedtextboxCantidadHoras.ReadOnly = Not mEditMode
        maskedtextboxCantidadDias.ReadOnly = Not mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        pFillAndRefreshLists.Curso(comboboxCurso, False, False)
        pFillAndRefreshLists.Provincia(comboboxProvincia, True)
        pFillAndRefreshLists.CapacitacionNivel(comboboxCapacitacionNivel, False, True)
        pFillAndRefreshLists.CapacitacionTipo(comboboxCapacitacionTipo, False, True)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mPersonaCapacitacionActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mPersonaCapacitacionActual
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxCurso, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDCurso)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxProvincia, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .IDProvincia, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxLocalidad, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .IDLocalidad, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxCapacitacionNivel, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, .IDCapacitacionNivel)
            If .IDCapacitacionNivel = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE Then
                textboxCapacitacionNivelOtro.Text = .CapacitacionNivelOtro
            Else
                textboxCapacitacionNivelOtro.Text = ""
            End If
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxCapacitacionTipo, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, .IDCapacitacionTipo)
            If .IDCapacitacionTipo = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE Then
                textboxCapacitacionTipoOtro.Text = .CapacitacionTipoOtro
            Else
                textboxCapacitacionTipoOtro.Text = ""
            End If
            maskedtextboxCantidadHoras.Text = CS_ValueTranslation.FromObjectShortToControlTextBox(.CantidadHoras)
            maskedtextboxCantidadDias.Text = CS_ValueTranslation.FromObjectShortToControlTextBox(.CantidadDias)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .IDCapacitacion = 0 Then
                textboxIDCapacitacion.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDCapacitacion.Text = String.Format(.IDCapacitacion.ToString, "G")
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
        With mPersonaCapacitacionActual
            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFecha.Value).Value
            .IDCurso = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxCurso.SelectedValue).Value
            .IDProvincia = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxProvincia.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            .IDLocalidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxLocalidad.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            .IDCapacitacionNivel = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCapacitacionNivel.SelectedValue)
            If .IDCapacitacionNivel = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE Then
                .CapacitacionNivelOtro = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCapacitacionNivelOtro.Text)
            Else
                .CapacitacionNivelOtro = Nothing
            End If
            .IDCapacitacionTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCapacitacionTipo.SelectedValue)
            If .IDCapacitacionTipo = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE Then
                .CapacitacionTipoOtro = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCapacitacionTipoOtro.Text)
            Else
                .CapacitacionTipoOtro = Nothing
            End If
            .CantidadHoras = CS_ValueTranslation.FromControlTextBoxToObjectShort(maskedtextboxCantidadHoras.Text)
            .CantidadDias = CS_ValueTranslation.FromControlTextBoxToObjectShort(maskedtextboxCantidadDias.Text)

            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxCapacitacionNivelOtro.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub Provincia_SelectedValueChanged() Handles comboboxProvincia.SelectedValueChanged
        If comboboxProvincia.SelectedValue Is Nothing Then
            pFillAndRefreshLists.Localidad(comboboxLocalidad, 0, True)
            comboboxLocalidad.SelectedIndex = 0
        Else
            pFillAndRefreshLists.Localidad(comboboxLocalidad, CByte(comboboxProvincia.SelectedValue), True)
            If CByte(comboboxProvincia.SelectedValue) = CS_Parameter_System.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID) Then
                CardonerSistemas.ComboBox.SetSelectedValue(comboboxLocalidad, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, CS_Parameter_System.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID))
            End If
        End If
    End Sub

    Private Sub CapacitacionNivel_SelectedValueChanged() Handles comboboxCapacitacionNivel.SelectedValueChanged
        labelCapacitacionNivelOtro.Visible = (CByte(comboboxCapacitacionNivel.SelectedValue) = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE)
        textboxCapacitacionNivelOtro.Visible = (CByte(comboboxCapacitacionNivel.SelectedValue) = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE)
    End Sub

    Private Sub CapacitacionTipo_SelectedValueChanged() Handles comboboxCapacitacionTipo.SelectedValueChanged
        labelCapacitacionTipoOtro.Visible = (CByte(comboboxCapacitacionTipo.SelectedValue) = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE)
        textboxCapacitacionTipoOtro.Visible = (CByte(comboboxCapacitacionTipo.SelectedValue) = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE)
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_Capacitacion_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If comboboxCurso.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Curso.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCurso.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mPersonaCapacitacionActual.IDCapacitacion = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                Dim PersonaActual As Persona
                PersonaActual = dbcMaxID.Persona.Find(mPersonaCapacitacionActual.IDPersona)
                If PersonaActual.PersonaCapacitaciones.Count = 0 Then
                    mPersonaCapacitacionActual.IDCapacitacion = 1
                Else
                    mPersonaCapacitacionActual.IDCapacitacion = PersonaActual.PersonaCapacitaciones.Max(Function(pa) pa.IDCapacitacion) + CByte(1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mPersonaCapacitacionActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mPersonaCapacitacionActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formPersona.Capacitaciones_RefreshData(mPersonaCapacitacionActual.IDCapacitacion)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Capacitación con los mismos datos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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