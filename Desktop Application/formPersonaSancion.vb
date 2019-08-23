Public Class formPersonaSancion

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaSancionActual As PersonaSancion

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer, ByVal IDSancion As Short)
        mIsLoading = True
        mEditMode = EditMode

        If IDSancion = 0 Then
            ' Es Nuevo
            mPersonaSancionActual = New PersonaSancion
            With mPersonaSancionActual
                .IDPersona = IDPersona

                .SolicitudFecha = DateTime.Today
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.PersonaSancion.Add(mPersonaSancionActual)
        Else
            mPersonaSancionActual = mdbContext.PersonaSancion.Find(IDPersona, IDSancion)
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
        comboboxSolicitudPersona.Enabled = mEditMode
        textboxSolicitudMotivo.ReadOnly = Not mEditMode
        datetimepickerSolicitudFecha.Enabled = mEditMode

        textboxEncuadreTexto.ReadOnly = Not mEditMode
        datetimepickerEncuadreFecha.Enabled = mEditMode

        comboboxResolucionSancionTipo.Enabled = mEditMode
        datetimepickerResolucionFecha.Enabled = mEditMode

        datetimepickerNotificacionFecha.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Persona(comboboxSolicitudPersona, False, False, False)
        pFillAndRefreshLists.SancionTipo(comboboxResolucionSancionTipo, False, True)
    End Sub

    Friend Sub SetAppearance()

    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mPersonaSancionActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mPersonaSancionActual
            CS_ComboBox.SetSelectedValue(comboboxSolicitudPersona, SelectedItemOptions.ValueOrFirstIfUnique, .SolicitudIDPersona)
            textboxSolicitudMotivo.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.SolicitudMotivo)
            datetimepickerSolicitudFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.SolicitudFecha)

            textboxEncuadreTexto.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.EncuadreTexto)
            datetimepickerEncuadreFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.EncuadreFecha, datetimepickerEncuadreFecha)

            CS_ComboBox.SetSelectedValue(comboboxResolucionSancionTipo, SelectedItemOptions.ValueOrFirst, .ResolucionIDSancionTipo)
            datetimepickerResolucionFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.ResolucionFecha, datetimepickerResolucionFecha)

            datetimepickerNotificacionFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.NotificacionFecha, datetimepickerNotificacionFecha)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .IDSancion = 0 Then
                textboxIDSancion.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDSancion.Text = String.Format(.IDSancion.ToString, "G")
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
        With mPersonaSancionActual
            .SolicitudIDPersona = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxSolicitudPersona.SelectedValue).Value
            .SolicitudMotivo = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxSolicitudMotivo.Text)
            .SolicitudFecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerSolicitudFecha.Value).Value

            .EncuadreTexto = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxEncuadreTexto.Text)
            .EncuadreFecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerEncuadreFecha.Value, datetimepickerEncuadreFecha.Checked)

            .ResolucionIDSancionTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxResolucionSancionTipo.SelectedValue)
            .ResolucionFecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerResolucionFecha.Value, datetimepickerResolucionFecha.Checked)

            .NotificacionFecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerNotificacionFecha.Value, datetimepickerNotificacionFecha.Checked)

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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxSolicitudMotivo.GotFocus, textboxEncuadreTexto.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_SANCION_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If comboboxSolicitudPersona.SelectedValue Is Nothing Then
            MsgBox("Debe especificar quien Solicita la Sanción.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxSolicitudPersona.Focus()
            Exit Sub
        End If
        If textboxSolicitudMotivo.Text.Trim.Length = 0 Then
            MsgBox("Debe especificar el Motivo de la Sanción.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxSolicitudMotivo.Focus()
            Exit Sub
        End If

        ' Busco el Cargo y Jerarquía de la Persona que solicita la Sanción
        Dim SolicitudIDPersonaActual As Integer
        SolicitudIDPersonaActual = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxSolicitudPersona.SelectedValue).Value
        If mPersonaSancionActual.IDSancion = 0 Or mPersonaSancionActual.SolicitudIDPersona <> SolicitudIDPersonaActual Then
            Dim PersonaAscensoUltimo As PersonaAscenso
            PersonaAscensoUltimo = mdbContext.PersonaAscenso.Where(Function(pa) pa.IDPersona = SolicitudIDPersonaActual).OrderByDescending(Function(pa) pa.Fecha).First
            If PersonaAscensoUltimo Is Nothing Then
                Me.Cursor = Cursors.Default
                MsgBox("La Persona que solicita la Sanción no tiene especificado el Cargo y la Jerarquía.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Exit Sub
            End If
            PersonaAscensoUltimo = Nothing
        End If

        ' Generar el ID nuevo
        If mPersonaSancionActual.IDSancion = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                Dim PersonaActual As Persona
                PersonaActual = dbcMaxID.Persona.Find(mPersonaSancionActual.IDPersona)
                If PersonaActual.PersonaSanciones.Count = 0 Then
                    mPersonaSancionActual.IDSancion = 1
                Else
                    mPersonaSancionActual.IDSancion = PersonaActual.PersonaSanciones.Max(Function(pl) pl.IDSancion) + CByte(1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mPersonaSancionActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mPersonaSancionActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formPersona.Sanciones_RefreshData(mPersonaSancionActual.IDSancion)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Sanción con los mismos datos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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