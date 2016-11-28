Public Class formPersonaAccidente

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaAccidenteActual As PersonaAccidente

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer, ByVal IDAccidente As Byte)
        mIsLoading = True
        mEditMode = EditMode

        If IDAccidente = 0 Then
            ' Es Nuevo
            mPersonaAccidenteActual = New PersonaAccidente
            With mPersonaAccidenteActual
                .Fecha = DateTime.Today
                .IDPersona = IDPersona
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.PersonaAccidente.Add(mPersonaAccidenteActual)
        Else
            mPersonaAccidenteActual = mdbContext.PersonaAccidente.Find(IDPersona, IDAccidente)
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

        datetimepickerFecha.Enabled = mEditMode
        textboxDiagnostico.ReadOnly = Not mEditMode
        textboxActaNumero.ReadOnly = Not mEditMode
        datetimepickerFechaAlta.Enabled = mEditMode
        textboxCapacidad.ReadOnly = Not mEditMode
        textboxDisminucionFisica.ReadOnly = Not mEditMode
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()
    End Sub

    Friend Sub SetAppearance()

    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mPersonaAccidenteActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mPersonaAccidenteActual
            If .IDAccidente = 0 Then
                textboxIDAccidente.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDAccidente.Text = String.Format(.IDAccidente.ToString, "G")
            End If
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha)
            textboxDiagnostico.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Diagnostico)
            textboxActaNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.ActaNumero)
            datetimepickerFechaAlta.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaAlta, datetimepickerFechaAlta)
            textboxCapacidad.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Capacidad)
            textboxDisminucionFisica.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DisminucionFisica)
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mPersonaAccidenteActual
            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFecha.Value).Value
            .Diagnostico = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDiagnostico.Text)
            .ActaNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxActaNumero.Text)
            .FechaAlta = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaAlta.Value, datetimepickerFechaAlta.Checked)
            .Capacidad = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCapacidad.Text)
            .DisminucionFisica = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDisminucionFisica.Text)
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxDiagnostico.GotFocus, textboxActaNumero.GotFocus, textboxCapacidad.GotFocus, textboxDisminucionFisica.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_ACCIDENTE_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If textboxDiagnostico.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Diagnósitoco.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxDiagnostico.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mPersonaAccidenteActual.IDAccidente = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                Dim PersonaActual As Persona
                PersonaActual = dbcMaxID.Persona.Find(mPersonaAccidenteActual.IDPersona)
                If PersonaActual.PersonaAccidentes.Count = 0 Then
                    mPersonaAccidenteActual.IDAccidente = 1
                Else
                    mPersonaAccidenteActual.IDAccidente = PersonaActual.PersonaAccidentes.Max(Function(pa) pa.IDAccidente) + CByte(1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mPersonaAccidenteActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mPersonaAccidenteActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                If CS_Form.MDIChild_IsLoaded(CType(formMDIMain, Form), "formPersonaAccidentes") Then
                    Dim formPersonaAccidentes As formPersonaAccidentes = CType(CS_Form.MDIChild_GetInstance(CType(formMDIMain, Form), "formPersonaAccidentes"), formPersonaAccidentes)
                    formPersonaAccidentes.RefreshData(mPersonaAccidenteActual.IDAccidente)
                    formPersonaAccidentes = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Accidente con los mismos datos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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