Public Class formPersonaVacuna

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaVacunaActual As PersonaVacuna

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer, ByVal IDVacuna As Byte)
        mIsLoading = True
        mEditMode = EditMode

        If IDVacuna = 0 Then
            ' Es Nuevo
            mPersonaVacunaActual = New PersonaVacuna
            With mPersonaVacunaActual
                .IDPersona = IDPersona

                .DosisNumero = 1
                .Fecha = DateTime.Today
                .Vencimiento = DateTime.Today
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.PersonaVacuna.Add(mPersonaVacunaActual)
        Else
            mPersonaVacunaActual = mdbContext.PersonaVacuna.Find(IDPersona, IDVacuna)
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
        comboboxTipo.Enabled = mEditMode
        textboxLote.ReadOnly = Not mEditMode
        updownDosisNumero.Enabled = mEditMode
        datetimepickerFecha.Enabled = mEditMode
        datetimepickerFechaVencimiento.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.VacunaTipo(comboboxTipo, False, False)
    End Sub

    Friend Sub SetAppearance()

    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mPersonaVacunaActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mPersonaVacunaActual
            CS_ComboBox.SetSelectedValue(comboboxTipo, SelectedItemOptions.ValueOrFirstIfUnique, .IDVacunaTipo)
            textboxLote.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Lote)
            updownDosisNumero.Value = CS_ValueTranslation.FromObjectByteToControlUpDown(.DosisNumero)
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha)
            datetimepickerFechaVencimiento.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Vencimiento)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .IDVacuna = 0 Then
                textboxIDVacuna.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDVacuna.Text = String.Format(.IDVacuna.ToString, "G")
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
        With mPersonaVacunaActual
            .IDVacunaTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxTipo.SelectedValue).Value
            .Lote = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxLote.Text)
            .DosisNumero = CS_ValueTranslation.FromControlUpDownToObjectByte(updownDosisNumero.Value)
            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFecha.Value, datetimepickerFecha.Checked)
            .Vencimiento = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaVencimiento.Value, datetimepickerFechaVencimiento.Checked)

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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxLote.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_Vacuna_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If comboboxTipo.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Tipo de Vacuna.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxTipo.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mPersonaVacunaActual.IDVacuna = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                Dim PersonaActual As Persona
                PersonaActual = dbcMaxID.Persona.Find(mPersonaVacunaActual.IDPersona)
                If PersonaActual.PersonaVacunas.Count = 0 Then
                    mPersonaVacunaActual.IDVacuna = 1
                Else
                    mPersonaVacunaActual.IDVacuna = PersonaActual.PersonaVacunas.Max(Function(pa) pa.IDVacuna) + CByte(1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mPersonaVacunaActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mPersonaVacunaActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formPersona.Vacunas_RefreshData(mPersonaVacunaActual.IDVacuna)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Vacuna con los mismos datos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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