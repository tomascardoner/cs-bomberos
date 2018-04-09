Public Class formPersonaLicencia

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaLicenciaActual As PersonaLicencia

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer, ByVal IDLicencia As Short)
        mIsLoading = True
        mEditMode = EditMode

        If IDLicencia = 0 Then
            ' Es Nuevo
            mPersonaLicenciaActual = New PersonaLicencia
            With mPersonaLicenciaActual
                .IDPersona = IDPersona

                .Fecha = DateTime.Today
                .FechaDesde = DateTime.Today
                .FechaHasta = DateTime.Today
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.PersonaLicencia.Add(mPersonaLicenciaActual)
        Else
            mPersonaLicenciaActual = mdbContext.PersonaLicencia.Find(IDPersona, IDLicencia)
        End If

        CS_Form.CenterToParent(ParentForm, Me)
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
        comboboxCausa.Enabled = mEditMode
        datetimepickerFechaDesde.Enabled = mEditMode
        datetimepickerFechaHasta.Enabled = mEditMode
        datetimepickerFechaInterrupcion.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.LicenciaCausa(comboboxCausa, False, False)
    End Sub

    Friend Sub SetAppearance()

    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mPersonaLicenciaActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mPersonaLicenciaActual
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha)
            CS_ComboBox.SetSelectedValue(comboboxCausa, SelectedItemOptions.ValueOrFirstIfUnique, .IDLicenciaCausa)
            datetimepickerFechaDesde.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaDesde)
            datetimepickerFechaHasta.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaHasta)
            datetimepickerFechaInterrupcion.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaInterrupcion, datetimepickerFechaInterrupcion)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .IDLicencia = 0 Then
                textboxIDLicencia.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDLicencia.Text = String.Format(.IDLicencia.ToString, "G")
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
        With mPersonaLicenciaActual
            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFecha.Value).Value
            .IDLicenciaCausa = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCausa.SelectedValue).Value
            .FechaDesde = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaDesde.Value).Value
            .FechaHasta = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaHasta.Value).Value
            .FechaInterrupcion = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaInterrupcion.Value, datetimepickerFechaInterrupcion.Checked)

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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_LICENCIA_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If comboboxCausa.SelectedValue Is Nothing Then
            MsgBox("Debe especificar la Causa.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCausa.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mPersonaLicenciaActual.IDLicencia = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                Dim PersonaActual As Persona
                PersonaActual = dbcMaxID.Persona.Find(mPersonaLicenciaActual.IDPersona)
                If PersonaActual.PersonaLicencias.Count = 0 Then
                    mPersonaLicenciaActual.IDLicencia = 1
                Else
                    mPersonaLicenciaActual.IDLicencia = PersonaActual.PersonaLicencias.Max(Function(pl) pl.IDLicencia) + CByte(1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mPersonaLicenciaActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mPersonaLicenciaActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formPersona.Licencias_RefreshData(mPersonaLicenciaActual.IDLicencia)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Licencia con los mismos datos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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
#End Region

End Class