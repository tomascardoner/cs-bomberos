Public Class formPersonaHorarioLaboral

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaHorarioLaboralActual As PersonaHorarioLaboral

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer, ByVal DiaSemana As Byte)
        mIsLoading = True
        mEditMode = EditMode

        If DiaSemana = 0 Then
            ' Es Nuevo
            mPersonaHorarioLaboralActual = New PersonaHorarioLaboral
            With mPersonaHorarioLaboralActual
                .IDPersona = IDPersona

                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.PersonaHorarioLaboral.Add(mPersonaHorarioLaboralActual)
        Else
            mPersonaHorarioLaboralActual = mdbContext.PersonaHorarioLaboral.Find(IDPersona, DiaSemana)
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
        comboboxDiaSemana.Enabled = (mPersonaHorarioLaboralActual.DiaSemana = 0 And mEditMode)
        datetimepickerTurno1Desde.Enabled = mEditMode
        datetimepickerTurno1Hasta.Enabled = mEditMode
        datetimepickerTurno2Desde.Enabled = mEditMode
        datetimepickerTurno2Hasta.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.DiaSemana(comboboxDiaSemana, True, False, True, False, False)

        datetimepickerTurno1Desde.Value = CS_Constants.DATETIMEPICKER_MINIMUM_VALUE
        datetimepickerTurno1Desde.Checked = False
        datetimepickerTurno1Hasta.Value = CS_Constants.DATETIMEPICKER_MINIMUM_VALUE
        datetimepickerTurno1Hasta.Checked = False
        datetimepickerTurno2Desde.Value = CS_Constants.DATETIMEPICKER_MINIMUM_VALUE
        datetimepickerTurno2Desde.Checked = False
        datetimepickerTurno2Hasta.Value = CS_Constants.DATETIMEPICKER_MINIMUM_VALUE
        datetimepickerTurno2Hasta.Checked = False
    End Sub

    Friend Sub SetAppearance()

    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mPersonaHorarioLaboralActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mPersonaHorarioLaboralActual
            comboboxDiaSemana.SelectedIndex = Convert.ToInt16(.DiaSemana - 1)
            datetimepickerTurno1Desde.Value = CS_ValueTranslation.FromObjectTimeSpanToControlDateTimePicker(.Turno1Desde, datetimepickerTurno1Desde)
            datetimepickerTurno1Hasta.Value = CS_ValueTranslation.FromObjectTimeSpanToControlDateTimePicker(.Turno1Hasta, datetimepickerTurno1Hasta)
            datetimepickerTurno2Desde.Value = CS_ValueTranslation.FromObjectTimeSpanToControlDateTimePicker(.Turno2Desde, datetimepickerTurno2Desde)
            datetimepickerTurno2Hasta.Value = CS_ValueTranslation.FromObjectTimeSpanToControlDateTimePicker(.Turno2Hasta, datetimepickerTurno2Hasta)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
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
        With mPersonaHorarioLaboralActual
            .DiaSemana = Convert.ToByte(comboboxDiaSemana.SelectedIndex + 1)
            .Turno1Desde = CS_ValueTranslation.FromControlDateTimePickerToObjectTimeSpan(datetimepickerTurno1Desde.Value, datetimepickerTurno1Desde.Checked)
            .Turno1Hasta = CS_ValueTranslation.FromControlDateTimePickerToObjectTimeSpan(datetimepickerTurno1Hasta.Value, datetimepickerTurno1Hasta.Checked)
            .Turno2Desde = CS_ValueTranslation.FromControlDateTimePickerToObjectTimeSpan(datetimepickerTurno2Desde.Value, datetimepickerTurno2Desde.Checked)
            .Turno2Hasta = CS_ValueTranslation.FromControlDateTimePickerToObjectTimeSpan(datetimepickerTurno2Hasta.Value, datetimepickerTurno2Hasta.Checked)

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
        If Permisos.VerificarPermiso(Permisos.PERSONA_HORARIO_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If comboboxDiaSemana.SelectedIndex = -1 Then
            MsgBox("Debe especificar el Día de la Semana.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxDiaSemana.Focus()
            Exit Sub
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mPersonaHorarioLaboralActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mPersonaHorarioLaboralActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formPersona.HorarioLaboral_RefreshData(mPersonaHorarioLaboralActual.DiaSemana)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity, Errors.PrimaryKeyViolation
                        MsgBox("No se pueden guardar los cambios porque ya existe un Horario Laboral para el Día de la Semana.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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