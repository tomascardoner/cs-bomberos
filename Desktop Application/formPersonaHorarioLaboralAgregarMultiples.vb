Public Class formPersonaHorarioLaboralAgregarMultiples

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mIDPersona As Integer
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByRef ParentForm As Form, ByVal IDPersona As Integer)
        mIDPersona = IDPersona

        CS_Form.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()

        Me.ShowDialog(ParentForm)
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

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
        Me.Dispose()
    End Sub
#End Region

#Region "Set Data"
    Friend Sub SetDataFromControlsToObject()
        If checkboxDiaSemana1.Checked Then
            AddPersonaHorarioLaboral(1)
        End If
        If checkboxDiaSemana2.Checked Then
            AddPersonaHorarioLaboral(2)
        End If
        If checkboxDiaSemana3.Checked Then
            AddPersonaHorarioLaboral(3)
        End If
        If checkboxDiaSemana4.Checked Then
            AddPersonaHorarioLaboral(4)
        End If
        If checkboxDiaSemana5.Checked Then
            AddPersonaHorarioLaboral(5)
        End If
        If checkboxDiaSemana6.Checked Then
            AddPersonaHorarioLaboral(6)
        End If
        If checkboxDiaSemana7.Checked Then
            AddPersonaHorarioLaboral(7)
        End If
    End Sub

    Private Sub AddPersonaHorarioLaboral(ByVal DiaSemana As Byte)
        Dim PersonaHorarioLaboralNuevo = New PersonaHorarioLaboral

        With PersonaHorarioLaboralNuevo
            .IDPersona = mIDPersona

            .DiaSemana = DiaSemana
            .Turno1Desde = CS_ValueTranslation.FromControlDateTimePickerToObjectTimeSpan(datetimepickerTurno1Desde.Value, datetimepickerTurno1Desde.Checked)
            .Turno1Hasta = CS_ValueTranslation.FromControlDateTimePickerToObjectTimeSpan(datetimepickerTurno1Hasta.Value, datetimepickerTurno1Hasta.Checked)
            .Turno2Desde = CS_ValueTranslation.FromControlDateTimePickerToObjectTimeSpan(datetimepickerTurno2Desde.Value, datetimepickerTurno2Desde.Checked)
            .Turno2Hasta = CS_ValueTranslation.FromControlDateTimePickerToObjectTimeSpan(datetimepickerTurno2Hasta.Value, datetimepickerTurno2Hasta.Checked)

            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
            .IDUsuarioCreacion = pUsuario.IDUsuario
            .FechaHoraCreacion = Now
            .IDUsuarioModificacion = pUsuario.IDUsuario
            .FechaHoraModificacion = .FechaHoraCreacion
        End With
        mdbContext.PersonaHorarioLaboral.Add(PersonaHorarioLaboralNuevo)
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                buttonGuardar.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                buttonCancelar.PerformClick()
        End Select
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"
    Private Sub buttonCancelar_Click() Handles buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If Not (checkboxDiaSemana1.Checked Or checkboxDiaSemana2.Checked Or checkboxDiaSemana3.Checked Or checkboxDiaSemana4.Checked Or checkboxDiaSemana5.Checked Or checkboxDiaSemana6.Checked Or checkboxDiaSemana7.Checked) Then
            MsgBox("Debe especificar algún Día de la Semana.", MsgBoxStyle.Information, My.Application.Info.Title)
            Exit Sub
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formPersona.HorarioLaboral_RefreshData(0)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity, Errors.PrimaryKeyViolation
                        MsgBox("No se pueden guardar los cambios porque ya existe un Horario Laboral para el Día de la Semana.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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