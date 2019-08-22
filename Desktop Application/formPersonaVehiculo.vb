Public Class formPersonaVehiculo

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaVehiculoActual As PersonaVehiculo

    Private mIsNew As Boolean
    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer, ByVal IDVehiculo As Byte)
        mIsLoading = True
        mEditMode = EditMode

        mIsNew = (IDVehiculo = 0)
        If mIsNew Then
            ' Es Nuevo
            mPersonaVehiculoActual = New PersonaVehiculo
            With mPersonaVehiculoActual
                .IDPersona = IDPersona

                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.PersonaVehiculo.Add(mPersonaVehiculoActual)
        Else
            mPersonaVehiculoActual = mdbContext.PersonaVehiculo.Find(IDPersona, IDVehiculo)
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
        textboxDominio.ReadOnly = Not mEditMode
        comboboxMarca.Enabled = mEditMode
        textboxModelo.ReadOnly = Not mEditMode
        maskedtextboxAnio.ReadOnly = Not mEditMode
        datetimepickerVerificacionVencimiento.Enabled = mEditMode
        comboboxCompaniaSeguro.Enabled = mEditMode
        textboxSeguroPolizaNumero.ReadOnly = Not mEditMode
        datetimepickerSeguroVencimiento.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.VehiculoTipo(comboboxTipo, False, False)
        pFillAndRefreshLists.VehiculoMarca(comboboxMarca, False, True)

        pFillAndRefreshLists.VehiculoCompaniaSeguro(comboboxCompaniaSeguro, False, True)
    End Sub

    Friend Sub SetAppearance()

    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mPersonaVehiculoActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mPersonaVehiculoActual
            CS_ComboBox.SetSelectedValue(comboboxTipo, SelectedItemOptions.ValueOrFirstIfUnique, .IDVehiculoTipo)
            textboxDominio.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Dominio)
            CS_ComboBox.SetSelectedValue(comboboxMarca, SelectedItemOptions.ValueOrFirst, .IDVehiculoMarca, CS_Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            textboxModelo.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Modelo)
            maskedtextboxAnio.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.Anio)
            If mIsNew Then
                datetimepickerVerificacionVencimiento.Value = Date.Today
                datetimepickerVerificacionVencimiento.Checked = False
            Else
                datetimepickerVerificacionVencimiento.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.VerificacionVencimiento)
            End If
            CS_ComboBox.SetSelectedValue(comboboxCompaniaSeguro, SelectedItemOptions.ValueOrFirst, .IDVehiculoCompaniaSeguro, CS_Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            textboxSeguroPolizaNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.SeguroPolizaNumero)
            If mIsNew Then
                datetimepickerSeguroVencimiento.Value = Date.Today
                datetimepickerSeguroVencimiento.Checked = False
            Else
                datetimepickerSeguroVencimiento.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.SeguroVencimiento)
            End If

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .IDVehiculo = 0 Then
                textboxIDVehiculo.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDVehiculo.Text = String.Format(.IDVehiculo.ToString, "G")
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
        With mPersonaVehiculoActual
            .IDVehiculoTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxTipo.SelectedValue).Value
            .Dominio = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDominio.Text)
            .IDVehiculoMarca = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxMarca.SelectedValue)
            .Modelo = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxModelo.Text)
            .Anio = CS_ValueTranslation.FromControlTextBoxToObjectShort(maskedtextboxAnio.Text)
            .VerificacionVencimiento = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerVerificacionVencimiento.Value).Value
            .IDVehiculoCompaniaSeguro = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCompaniaSeguro.SelectedValue)
            .SeguroPolizaNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxSeguroPolizaNumero.Text)
            .SeguroVencimiento = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerSeguroVencimiento.Value).Value

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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxDominio.GotFocus, textboxModelo.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub MaskedTextBoxs_GotFocus(sender As Object, e As EventArgs) Handles maskedtextboxAnio.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_VEHICULO_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If comboboxTipo.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Tipo.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxTipo.Focus()
            Exit Sub
        End If
        If Not datetimepickerVerificacionVencimiento.Checked Then
            MsgBox("Debe especificar la Fecha de Vencimiento de la Verificación.", MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerVerificacionVencimiento.Focus()
            Exit Sub
        End If
        If Not datetimepickerSeguroVencimiento.Checked Then
            MsgBox("Debe especificar la Fecha de Vencimiento del Seguro.", MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerSeguroVencimiento.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mPersonaVehiculoActual.IDVehiculo = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                Dim PersonaActual As Persona
                PersonaActual = dbcMaxID.Persona.Find(mPersonaVehiculoActual.IDPersona)
                If PersonaActual.PersonaVehiculos.Count = 0 Then
                    mPersonaVehiculoActual.IDVehiculo = 1
                Else
                    mPersonaVehiculoActual.IDVehiculo = PersonaActual.PersonaVehiculos.Max(Function(pa) pa.IDVehiculo) + CByte(1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mPersonaVehiculoActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mPersonaVehiculoActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formPersona.Vehiculos_RefreshData(mPersonaVehiculoActual.IDVehiculo)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Vehículo con los mismos datos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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