Public Class formPersonaLicenciaEspecial

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaLicenciaEspecialActual As PersonaLicenciaEspecial

    Private mIsLoading As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer, ByVal IDLicenciaEspecial As Short)
        mIsLoading = True
        mEditMode = EditMode

        If IDLicenciaEspecial = 0 Then
            ' Es Nuevo
            mPersonaLicenciaEspecialActual = New PersonaLicenciaEspecial
            With mPersonaLicenciaEspecialActual
                .IDPersona = IDPersona

                .Fecha = DateTime.Today
                .FechaDesde = DateTime.Today
                .FechaHasta = DateTime.Today
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.PersonaLicenciaEspecial.Add(mPersonaLicenciaEspecialActual)
        Else
            mPersonaLicenciaEspecialActual = mdbContext.PersonaLicenciaEspecial.Find(IDPersona, IDLicenciaEspecial)
        End If

        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
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
        datetimepickerFechaDesde.Enabled = mEditMode
        datetimepickerFechaHasta.Enabled = mEditMode
        checkboxPresentaCertificado.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mPersonaLicenciaEspecialActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mPersonaLicenciaEspecialActual
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha)
            datetimepickerFechaDesde.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaDesde)
            datetimepickerFechaHasta.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaHasta)
            checkboxPresentaCertificado.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.PresentaCertificado)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .IDLicenciaEspecial = 0 Then
                textboxID.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxID.Text = String.Format(.IDLicenciaEspecial.ToString, "G")
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
        With mPersonaLicenciaEspecialActual
            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFecha.Value).Value
            .FechaDesde = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaDesde.Value).Value
            .FechaHasta = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaHasta.Value).Value
            .PresentaCertificado = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxPresentaCertificado.CheckState)

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
        If Permisos.VerificarPermiso(Permisos.PERSONA_LICENCIAESPECIAL_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        ' Verifico las fechas (Fecha <= Fecha Desde < FechaHasta)
        If datetimepickerFecha.Value > datetimepickerFechaDesde.Value Then
            MsgBox("La Fecha de Solicitud de la Licencia Especial no puede ser mayor a la Fecha desde.", MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerFecha.Focus()
            Exit Sub
        End If
        If datetimepickerFechaDesde.Value >= datetimepickerFechaHasta.Value Then
            MsgBox("La Fecha desde no puede ser mayor o igual a la Fecha hasta.", MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerFechaDesde.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mPersonaLicenciaEspecialActual.IDLicenciaEspecial = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                Dim PersonaActual As Persona
                PersonaActual = dbcMaxID.Persona.Find(mPersonaLicenciaEspecialActual.IDPersona)
                If PersonaActual.PersonasLicenciasEspeciales.Any() Then
                    mPersonaLicenciaEspecialActual.IDLicenciaEspecial = PersonaActual.PersonasLicenciasEspeciales.Max(Function(pl) pl.IDLicenciaEspecial) + CShort(1)
                Else
                    mPersonaLicenciaEspecialActual.IDLicenciaEspecial = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mPersonaLicenciaEspecialActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mPersonaLicenciaEspecialActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formPersona.LicenciasEspeciales_RefreshData(mPersonaLicenciaEspecialActual.IDLicenciaEspecial)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Licencia Especial con la misma Fecha desde.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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