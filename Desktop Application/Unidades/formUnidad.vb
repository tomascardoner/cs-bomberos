Public Class formUnidad

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mUnidadActual As Unidad

    Private mIsLoading As Boolean
    Private mEditMode As Boolean
    
#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDUnidad As Short)
        mIsLoading = True
        mEditMode = EditMode

        If IDUnidad = 0 Then
            ' Es Nuevo
            mUnidadActual = New Unidad
            With mUnidadActual
                .EsPropio = True
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Unidad.Add(mUnidadActual)
        Else
            mUnidadActual = mdbContext.Unidad.Find(IDUnidad)
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

        maskedtextboxNumero.ReadOnly = Not mEditMode
        buttonNumeroSiguiente.Visible = (mEditMode And mUnidadActual.IDUnidad = 0)
        textboxMarca.ReadOnly = Not mEditMode
        textboxModelo.ReadOnly = Not mEditMode
        checkboxEsImportado.Enabled = mEditMode
        maskedtextboxAnio.ReadOnly = Not mEditMode
        textboxNumeroMotor.ReadOnly = Not mEditMode
        textboxNumeroChasis.ReadOnly = Not mEditMode
        textboxDominio.ReadOnly = Not mEditMode
        comboboxUnidadTipo.Enabled = mEditMode
        comboboxUnidadUso.Enabled = mEditMode
        comboboxCombustibleTipo.Enabled = mEditMode
        datetimepickerFechaAdquisicion.Enabled = mEditMode
        maskedtextboxKilometrajeInicial.ReadOnly = Not mEditMode
        maskedtextboxCapacidadAguaLitros.ReadOnly = Not mEditMode
        comboboxCuartel.Enabled = mEditMode
        checkboxEsPropio.Enabled = mEditMode
        datetimepickerVerificacionVencimiento.Enabled = mEditMode

        textboxNotas.ReadOnly = Not mEditMode
        checkboxEsActivo.Enabled = mEditMode
        comboboxUnidadBajaMotivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.UnidadTipo(comboboxUnidadTipo, False, False)
        pFillAndRefreshLists.UnidadUso(comboboxUnidadUso, False, False)
        pFillAndRefreshLists.CombustibleTipo(comboboxCombustibleTipo, False, True)
        ListasComunes.LlenarComboBoxCuarteles(mdbContext, comboboxCuartel, False, False)
        pFillAndRefreshLists.UnidadBajaMotivo(comboboxUnidadBajaMotivo, False, True)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageUnidad32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mUnidadActual = Nothing
        Me.Dispose()
    End Sub
    
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mUnidadActual
            If .IDUnidad = 0 Then
                maskedtextboxNumero.Text = ""
                maskedtextboxAnio.Text = ""
            Else
                maskedtextboxNumero.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.Numero)
                maskedtextboxAnio.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.Anio)
            End If
            textboxMarca.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Marca)
            textboxModelo.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Modelo)
            checkboxEsImportado.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsImportado)
            textboxNumeroMotor.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.NumeroMotor)
            textboxNumeroChasis.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.NumeroChasis)
            textboxDominio.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Dominio)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxUnidadTipo, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDUnidadTipo)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxUnidadUso, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDUnidadUso)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxCombustibleTipo, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, .IDCombustibleTipo)
            datetimepickerFechaAdquisicion.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaAdquisicion, datetimepickerFechaAdquisicion)
            maskedtextboxKilometrajeInicial.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.KilometrajeInicial)
            maskedtextboxCapacidadAguaLitros.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.CapacidadAguaLitros)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxCuartel, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDCuartel)
            checkboxEsPropio.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsPropio)
            datetimepickerVerificacionVencimiento.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.VerificacionVencimiento, datetimepickerVerificacionVencimiento)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxUnidadBajaMotivo, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, .IDUnidadBajaMotivo)
            If .IDUnidad = 0 Then
                textboxIDUnidad.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDUnidad.Text = String.Format(.IDUnidad.ToString, "G")
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
        With mUnidadActual
            .Numero = CS_ValueTranslation.FromControlTextBoxToObjectShort(maskedtextboxNumero.Text).Value
            .Marca = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxMarca.Text)
            .Modelo = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxModelo.Text)
            .EsImportado = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsImportado.CheckState)
            .Anio = CS_ValueTranslation.FromControlTextBoxToObjectShort(maskedtextboxAnio.Text).Value
            .NumeroMotor = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNumeroMotor.Text)
            .NumeroChasis = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNumeroChasis.Text)
            .Dominio = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDominio.Text)
            .IDUnidadTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxUnidadTipo.SelectedValue).Value
            .IDUnidadUso = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxUnidadUso.SelectedValue).Value
            .IDCombustibleTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCombustibleTipo.SelectedValue)
            .FechaAdquisicion = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaAdquisicion.Value, datetimepickerFechaAdquisicion.Checked)
            .KilometrajeInicial = CS_ValueTranslation.FromControlTextBoxToObjectInteger(maskedtextboxKilometrajeInicial.Text)
            .CapacidadAguaLitros = CS_ValueTranslation.FromControlTextBoxToObjectInteger(maskedtextboxCapacidadAguaLitros.Text)
            .IDCuartel = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCuartel.SelectedValue).Value
            .EsPropio = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsPropio.CheckState)
            .VerificacionVencimiento = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerVerificacionVencimiento.Value, datetimepickerVerificacionVencimiento.Checked)

            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
            If .EsActivo Then
                .IDUnidadBajaMotivo = Nothing
            Else
                .IDUnidadBajaMotivo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxUnidadBajaMotivo.SelectedValue)
            End If
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxMarca.GotFocus, textboxModelo.GotFocus, textboxDominio.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub MaskedTextBoxs_GotFocus(sender As Object, e As EventArgs) Handles maskedtextboxNumero.GotFocus, maskedtextboxAnio.GotFocus, maskedtextboxKilometrajeInicial.GotFocus, maskedtextboxCapacidadAguaLitros.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
    End Sub

    Private Sub buttonNumeroSiguiente_Click() Handles buttonNumeroSiguiente.Click
        Using dbcMaxNumero As New CSBomberosContext(True)
            If dbcMaxNumero.Unidad.Any() Then
                maskedtextboxNumero.Text = CStr(CInt(dbcMaxNumero.Unidad.Max(Function(a) a.Numero)) + 1)
            Else
                maskedtextboxNumero.Text = CStr(1)
            End If
        End Using
    End Sub

    Private Sub EsActivoCheckedChanged(sender As Object, e As EventArgs) Handles checkboxEsActivo.CheckedChanged
        labelUnidadBajaMotivo.Visible = Not checkboxEsActivo.Checked
        comboboxUnidadBajaMotivo.Visible = Not checkboxEsActivo.Checked
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.Unidad_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        If mdbContext.ChangeTracker.HasChanges Then
            If MsgBox("Ha realizado cambios en los datos y seleccionó cancelar, los cambios se perderán.{0}{0}¿Confirma la pérdida de los cambios?", CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        ' Verifico el Número
        If maskedtextboxNumero.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Número.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxNumero.Focus()
            Exit Sub
        End If
        If CInt(maskedtextboxNumero.Text) <= 0 Then
            MsgBox("El Número debe ser mayor a cero.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxNumero.Focus()
            Exit Sub
        End If
        If CInt(maskedtextboxNumero.Text) > Short.MaxValue Then
            MsgBox(String.Format("El Número debe ser menor o igual a {0}.", Short.MaxValue), MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxNumero.Focus()
            Exit Sub
        End If

        ' Marca y Modelo
        If textboxMarca.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar la Marca.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxMarca.Focus()
            Exit Sub
        End If
        If textboxModelo.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Modelo.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxModelo.Focus()
            Exit Sub
        End If

        ' Año
        If maskedtextboxAnio.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Año.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxAnio.Focus()
            Exit Sub
        End If
        If CInt(maskedtextboxAnio.Text) < 1900 Or CInt(maskedtextboxAnio.Text) > DateAndTime.Now.Year Then
            MsgBox(String.Format("El Año debe ser estar entre {0} y {1}.", 1900, DateAndTime.Now.Year), MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxAnio.Focus()
            Exit Sub
        End If

        ' Tipo y Uso de Unidad
        If comboboxUnidadTipo.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Tipo de Unidad.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxUnidadTipo.Focus()
            Exit Sub
        End If
        If comboboxUnidadUso.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Uso del Unidad.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxUnidadUso.Focus()
            Exit Sub
        End If

        ' Fecha de Adquisición
        If datetimepickerFechaAdquisicion.Checked And datetimepickerFechaAdquisicion.Value > Today Then
            MsgBox("La Fecha de Adquisición debe ser igual o anterior a la fecha actual.", MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerFechaAdquisicion.Focus()
            Exit Sub
        End If

        ' Kilometraje Inicial
        If maskedtextboxKilometrajeInicial.Text.Trim.Length > 0 Then
            If CInt(maskedtextboxKilometrajeInicial.Text) < 0 Then
                MsgBox("El Kilometraje Inicial debe estar vacío o ser mayor o igual a cero.", MsgBoxStyle.Information, My.Application.Info.Title)
                maskedtextboxKilometrajeInicial.Focus()
                Exit Sub
            End If
        End If

        ' Capacidad Agua Litros
        If maskedtextboxCapacidadAguaLitros.Text.Trim.Length > 0 Then
            If CInt(maskedtextboxCapacidadAguaLitros.Text) < 0 Then
                MsgBox("La Capacidad de Agua debe estar vacío o ser mayor a cero.", MsgBoxStyle.Information, My.Application.Info.Title)
                maskedtextboxCapacidadAguaLitros.Focus()
                Exit Sub
            End If
        End If

        ' Cuartel
        If comboboxCuartel.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Cuartel.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuartel.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mUnidadActual.IDUnidad = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.Unidad.Any() Then
                    mUnidadActual.IDUnidad = dbcMaxID.Unidad.Max(Function(a) a.IDUnidad) + CByte(1)
                Else
                    mUnidadActual.IDUnidad = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mUnidadActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mUnidadActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formUnidades.RefreshData(mUnidadActual.IDUnidad)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Unidad con los mismos datos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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