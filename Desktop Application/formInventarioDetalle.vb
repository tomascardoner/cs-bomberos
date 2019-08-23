Public Class formInventarioDetalle

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mInventarioActual As Inventario
    Private mIDCuartel As Byte

    Private mIsLoading As Boolean = False
    Private mIsNew As Boolean = False
    Private mEditMode As Boolean = False
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
                    If CShort(formInventario.comboboxUbicacion.ComboBox.SelectedValue) <> FIELD_VALUE_NOTSPECIFIED_SHORT Then
                        .IDUbicacion = CShort(formInventario.comboboxUbicacion.ComboBox.SelectedValue)
                    End If
                End If
                If formInventario.comboboxSubUbicacion.SelectedIndex > 0 Then
                    If CShort(formInventario.comboboxSubUbicacion.ComboBox.SelectedValue) <> FIELD_VALUE_NOTSPECIFIED_SHORT Then
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

        '  Toolbar
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        ' General
        comboboxCuartel.Enabled = mEditMode
        comboboxArea.Enabled = mEditMode
        textboxCodigo.ReadOnly = Not mEditMode
        buttonCodigoSiguiente.Visible = (mEditMode And mInventarioActual.IDInventario = 0)
        comboboxElemento.Enabled = mEditMode
        textboxDescripcionPropia.ReadOnly = Not mEditMode
        comboboxModoAdquisicion.Enabled = mEditMode
        comboboxUbicacion.Enabled = mEditMode
        comboboxSubUbicacion.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
        checkboxEsActivo.Enabled = mEditMode
        datetimepickerFechaBaja.Enabled = (mEditMode And Not checkboxEsActivo.Checked)
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Cuartel(comboboxCuartel, False, False)
        pFillAndRefreshLists.ElementoFill(comboboxElemento, False, False)

        pFillAndRefreshLists.ModoAdquisicion(comboboxModoAdquisicion, False, True)
    End Sub

    Friend Sub SetAppearance()

    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mInventarioActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mInventarioActual
            If mIsNew Then
                CS_ComboBox.SetSelectedValue(comboboxCuartel, SelectedItemOptions.ValueOrFirstIfUnique, mIDCuartel)
            Else
                CS_ComboBox.SetSelectedValue(comboboxCuartel, SelectedItemOptions.ValueOrFirstIfUnique, .Area.IDCuartel)
            End If
            CS_ComboBox.SetSelectedValue(comboboxArea, SelectedItemOptions.ValueOrFirstIfUnique, .IDArea)
            textboxCodigo.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Codigo).TrimEnd
            CS_ComboBox.SetSelectedValue(comboboxElemento, SelectedItemOptions.Value, .IDElemento)
            textboxDescripcionPropia.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DescripcionPropia)
            CS_ComboBox.SetSelectedValue(comboboxModoAdquisicion, SelectedItemOptions.ValueOrFirst, .IDModoAdquisicion, 0)

            CS_ComboBox.SetSelectedValue(comboboxUbicacion, SelectedItemOptions.ValueOrFirst, .IDUbicacion, 0)
            CS_ComboBox.SetSelectedValue(comboboxSubUbicacion, SelectedItemOptions.ValueOrFirst, .IDSubUbicacion, 0)

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
            .Codigo = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCodigo.Text)
            .IDElemento = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxElemento.SelectedValue).Value
            .DescripcionPropia = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDescripcionPropia.Text)
            .IDModoAdquisicion = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxModoAdquisicion.SelectedValue)

            .IDUbicacion = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxUbicacion.SelectedValue, FIELD_VALUE_NOTSPECIFIED_SHORT)
            .IDSubUbicacion = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxSubUbicacion.SelectedValue, FIELD_VALUE_NOTSPECIFIED_SHORT)

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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxCodigo.GotFocus, textboxDescripcionPropia.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub buttonCodigoSiguiente_Click() Handles buttonCodigoSiguiente.Click
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
                textboxCodigo.Text = CStr(1).PadLeft(5, "0"c)
            Else
                textboxCodigo.Text = CStr(CInt(dbcMaxCodigo.Inventario.Where(Function(e) e.IDArea = IDArea).Max(Function(e) e.Codigo)) + 1).PadLeft(5, "0"c)
            End If
        End Using
    End Sub

    Private Sub comboboxCuartel_SelectedIndexChanged() Handles comboboxCuartel.SelectedIndexChanged
        pFillAndRefreshLists.Area(comboboxArea, False, False, CByte(comboboxCuartel.SelectedValue))
        comboboxArea.SelectedItem = Nothing
        pFillAndRefreshLists.Ubicacion(comboboxUbicacion, False, True, CByte(comboboxCuartel.SelectedValue))
        textboxCodigo.Text = ""
    End Sub

    Private Sub comboboxArea_SelectedIndexChanged() Handles comboboxArea.SelectedIndexChanged
        textboxCodigo.Text = ""
    End Sub

    Private Sub comboboxUbicacion_SelectedIndexChanged() Handles comboboxUbicacion.SelectedIndexChanged
        pFillAndRefreshLists.SubUbicacion(comboboxSubUbicacion, False, True, CShort(comboboxUbicacion.SelectedValue))
    End Sub

    Private Sub checkboxEsActivo_Checked() Handles checkboxEsActivo.CheckedChanged
        datetimepickerFechaBaja.Enabled = (mEditMode And Not checkboxEsActivo.Checked)
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.INVENTARIO_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If comboboxCuartel.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Cuartel.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuartel.Focus()
            Exit Sub
        End If
        If comboboxArea.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Area.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxArea.Focus()
            Exit Sub
        End If
        If textboxCodigo.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Código.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxCodigo.Focus()
            Exit Sub
        End If
        If textboxCodigo.Text.Trim.Length < 5 Then
            MsgBox("El Código debe contener 5 dígitos.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxCodigo.Focus()
            Exit Sub
        End If
        If comboboxElemento.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Elemento.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxElemento.Focus()
            Exit Sub
        End If
        If Not comboboxModoAdquisicion.SelectedValue Is Nothing Then
            If Convert.ToByte(comboboxModoAdquisicion.SelectedValue) = CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
                MsgBox("Debe especificar el Modo de Adquisición.", MsgBoxStyle.Information, My.Application.Info.Title)
                comboboxModoAdquisicion.Focus()
                Exit Sub
            End If
        End If

        ' Generar el ID nuevo
        If mInventarioActual.IDInventario = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.Inventario.Count = 0 Then
                    mInventarioActual.IDInventario = 1
                Else
                    mInventarioActual.IDInventario = (From i In dbcMaxID.Inventario Select i.IDInventario).Max + 1 + CByte(1)
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
                If CS_Form.MDIChild_IsLoaded(CType(pFormMDIMain, Form), "formInventario") Then
                    Dim formInventario As formInventario = CType(CS_Form.MDIChild_GetInstance(CType(pFormMDIMain, Form), "formInventario"), formInventario)
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

End Class