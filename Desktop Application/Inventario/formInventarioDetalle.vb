Public Class formInventarioDetalle

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mInventarioActual As Inventario
    Private mIDCuartel As Byte

    Private mIsLoading As Boolean
    Private mIsNew As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDInventario As Integer)
        mIsLoading = True
        mEditMode = EditMode

        mIsNew = (IDInventario = 0)
        If mIsNew Then
            ' Es Nuevo
            mInventarioActual = New Inventario
            With mInventarioActual
                ' Si hay filtros aplicados en el form principal, uso esos valores como predeterminados
                If formInventario.comboboxCuartel.SelectedIndex > 0 Then
                    mIDCuartel = CByte(formInventario.comboboxCuartel.ComboBox.SelectedValue)
                End If
                If formInventario.comboboxArea.SelectedIndex > 0 Then
                    .IDArea = CShort(formInventario.comboboxArea.ComboBox.SelectedValue)
                End If
                If formInventario.comboboxUbicacion.SelectedIndex > 0 Then
                    If CShort(formInventario.comboboxUbicacion.ComboBox.SelectedValue) <> CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT Then
                        .IDUbicacion = CShort(formInventario.comboboxUbicacion.ComboBox.SelectedValue)
                    End If
                End If
                If formInventario.comboboxSubUbicacion.SelectedIndex > 0 Then
                    If CShort(formInventario.comboboxSubUbicacion.ComboBox.SelectedValue) <> CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT Then
                        .IDSubUbicacion = CShort(formInventario.comboboxSubUbicacion.ComboBox.SelectedValue)
                    End If
                End If

                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Inventario.Add(mInventarioActual)
        Else
            mInventarioActual = mdbContext.Inventario.Find(IDInventario)
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

        '  Toolbar
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        ' General
        comboboxCuartel.Enabled = mEditMode
        comboboxArea.Enabled = mEditMode
        MaskedTextBoxCodigo.ReadOnly = Not mEditMode
        buttonCodigoSiguiente.Visible = (mEditMode And mInventarioActual.IDInventario = 0)
        comboboxElemento.Enabled = mEditMode
        textboxDescripcionPropia.ReadOnly = Not mEditMode
        comboboxModoAdquisicion.Enabled = mEditMode
        datetimepickerFechaAdquisicion.Enabled = mEditMode
        comboboxUbicacion.Enabled = mEditMode
        comboboxSubUbicacion.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
        checkboxEsActivo.Enabled = mEditMode
        datetimepickerFechaBaja.Enabled = (mEditMode And Not checkboxEsActivo.Checked)
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        Using context As New CSBomberosContext(True)
            ListasComunes.LlenarComboBoxCuarteles(context, comboboxCuartel, False, False)
        End Using
        pFillAndRefreshLists.ElementoFill(comboboxElemento, False, False)

        pFillAndRefreshLists.ModoAdquisicion(comboboxModoAdquisicion, False, True)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageElemento32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mInventarioActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mInventarioActual
            If mIsNew Then
                CardonerSistemas.ComboBox.SetSelectedValue(comboboxCuartel, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mIDCuartel)
            Else
                CardonerSistemas.ComboBox.SetSelectedValue(comboboxCuartel, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .Area.IDCuartel)
            End If
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxArea, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDArea)
            MaskedTextBoxCodigo.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Codigo).TrimEnd
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxElemento, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .IDElemento)
            textboxDescripcionPropia.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DescripcionPropia)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxModoAdquisicion, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, .IDModoAdquisicion, 0)
            datetimepickerFechaAdquisicion.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaAdquicision, datetimepickerFechaAdquisicion)

            CardonerSistemas.ComboBox.SetSelectedValue(comboboxUbicacion, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, .IDUbicacion, 0)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxSubUbicacion, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, .IDSubUbicacion, 0)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            If checkboxEsActivo.Checked Then
                datetimepickerFechaBaja.Value = DateAndTime.Today
                datetimepickerFechaBaja.Checked = False
            Else
                datetimepickerFechaBaja.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaBaja, datetimepickerFechaBaja)
            End If
            If .IDElemento = 0 Then
                textboxIDInventario.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDInventario.Text = String.Format(.IDElemento.ToString, "G")
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
        With mInventarioActual
            .IDArea = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxArea.SelectedValue).Value
            .Codigo = CS_ValueTranslation.FromControlTextBoxToObjectString(MaskedTextBoxCodigo.Text)
            .IDElemento = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxElemento.SelectedValue).Value
            .DescripcionPropia = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDescripcionPropia.Text)
            .IDModoAdquisicion = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxModoAdquisicion.SelectedValue)
            .FechaAdquicision = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaAdquisicion.Value, datetimepickerFechaAdquisicion.Checked)

            .IDUbicacion = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxUbicacion.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            .IDSubUbicacion = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxSubUbicacion.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)

            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
            If checkboxEsActivo.Checked Then
                .FechaBaja = Nothing
            Else
                .FechaBaja = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaBaja.Value, datetimepickerFechaBaja.Checked)
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxDescripcionPropia.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub MaskedTextBoxCodigo_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBoxCodigo.LostFocus
        Dim result As Int32

        If Int32.TryParse(MaskedTextBoxCodigo.Text.Trim, result) Then
            MaskedTextBoxCodigo.Text = result.ToString(New String("0"c, 5))
        End If
    End Sub

    Private Sub ObtenerCodigoSiguiente() Handles buttonCodigoSiguiente.Click
        If comboboxCuartel.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Cuartel .", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuartel.Focus()
            Exit Sub
        End If
        If comboboxArea.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Area.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxArea.Focus()
            Exit Sub
        End If

        Using dbcMaxCodigo As New CSBomberosContext(True)
            Dim IDArea As Short = CShort(comboboxArea.SelectedValue)

            If dbcMaxCodigo.Inventario.Where(Function(e) e.IDArea = IDArea).Count = 0 Then
                MaskedTextBoxCodigo.Text = CStr(1).PadLeft(5, "0"c)
            Else
                MaskedTextBoxCodigo.Text = CStr(CInt(dbcMaxCodigo.Inventario.Where(Function(e) e.IDArea = IDArea).Max(Function(e) e.Codigo)) + 1).PadLeft(5, "0"c)
            End If
        End Using
    End Sub

    Private Sub CuartelCambio() Handles comboboxCuartel.SelectedIndexChanged
        ListasComunes.LlenarComboBoxAreas(mdbContext, comboboxArea, False, False, CByte(comboboxCuartel.SelectedValue), True)
        comboboxArea.SelectedItem = Nothing
        pFillAndRefreshLists.Ubicacion(comboboxUbicacion, False, True, CByte(comboboxCuartel.SelectedValue))
        MaskedTextBoxCodigo.Text = String.Empty
    End Sub

    Private Sub AreaCambio() Handles comboboxArea.SelectedIndexChanged
        MaskedTextBoxCodigo.Text = String.Empty
    End Sub

    Private Sub UbicacionCambio() Handles comboboxUbicacion.SelectedIndexChanged
        pFillAndRefreshLists.SubUbicacion(comboboxSubUbicacion, False, True, CShort(comboboxUbicacion.SelectedValue))
    End Sub

    Private Sub EsActivoCambio() Handles checkboxEsActivo.CheckedChanged
        datetimepickerFechaBaja.Enabled = (mEditMode And Not checkboxEsActivo.Checked)
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub Editar() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.INVENTARIO_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub CerrarOCancelar() Handles buttonCerrar.Click, buttonCancelar.Click
        If mdbContext.ChangeTracker.HasChanges Then
            If MsgBox(String.Format("Ha realizado cambios en los datos y seleccionó cancelar, los cambios se perderán.{0}{0}¿Confirma la pérdida de los cambios?", vbCrLf), CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Guardar() Handles buttonGuardar.Click
        If Not VerificarDatos() Then
            Return
        End If

        ' Generar el ID nuevo
        If mIsNew Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.Inventario.Any() Then
                    mInventarioActual.IDInventario = dbcMaxID.Inventario.Max(Function(i) i.IDInventario) + 1
                Else
                    mInventarioActual.IDInventario = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mInventarioActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mInventarioActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formInventario") Then
                    Dim formInventario As formInventario = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formInventario"), formInventario)
                    formInventario.RefreshData(mInventarioActual.IDInventario)
                    formInventario = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Elemento en el Inventario con el mismo Código.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        If comboboxCuartel.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Cuartel.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuartel.Focus()
            Return False
        End If
        If comboboxArea.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Area.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxArea.Focus()
            Return False
        End If

        If MaskedTextBoxCodigo.Text.Trim.Length = 0 Then
            MsgBox("Debe especificar el Punto de Venta.", MsgBoxStyle.Information, My.Application.Info.Title)
            MaskedTextBoxCodigo.Focus()
            Return False
        End If
        If Not Int32.TryParse(MaskedTextBoxCodigo.Text.Trim, New Int32) Then
            MsgBox("El Código debe ser un valor numérico.", MsgBoxStyle.Information, My.Application.Info.Title)
            MaskedTextBoxCodigo.Focus()
            Return False
        End If

        If comboboxElemento.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Elemento.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxElemento.Focus()
            Return False
        End If
        If Not comboboxModoAdquisicion.SelectedValue Is Nothing Then
            If Convert.ToByte(comboboxModoAdquisicion.SelectedValue) = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
                MsgBox("Debe especificar el Modo de Adquisición.", MsgBoxStyle.Information, My.Application.Info.Title)
                comboboxModoAdquisicion.Focus()
                Return False
            End If
        End If

        Return True
    End Function

#End Region

End Class