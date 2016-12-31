Public Class formElemento

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mElementoActual As Elemento
    Private mIDCuartel As Byte

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDElemento As Integer)
        mIsLoading = True
        mEditMode = EditMode

        If IDElemento = 0 Then
            ' Es Nuevo
            mElementoActual = New Elemento
            With mElementoActual
                ' Si hay filtros aplicados en el form principal, uso esos valores como predeterminados
                If CS_Form.MDIChild_IsLoaded(CType(formMDIMain, Form), "formElementos") Then
                    Dim formElementos As formElementos = CType(CS_Form.MDIChild_GetInstance(CType(formMDIMain, Form), "formElementos"), formElementos)
                    If formElementos.comboboxCuartel.SelectedIndex > 0 Then
                        mIDCuartel = CByte(formElementos.comboboxCuartel.ComboBox.SelectedValue)
                    End If
                    If formElementos.comboboxArea.SelectedIndex > 0 Then
                        .IDArea = CShort(formElementos.comboboxArea.ComboBox.SelectedValue)
                    End If
                    If formElementos.comboboxUbicacion.SelectedIndex > 0 Then
                        If CShort(formElementos.comboboxUbicacion.ComboBox.SelectedValue) <> FIELD_VALUE_NOTSPECIFIED_BYTE Then
                            .IDUbicacion = CShort(formElementos.comboboxUbicacion.ComboBox.SelectedValue)
                        End If
                    End If
                    If formElementos.comboboxSubUbicacion.SelectedIndex > 0 Then
                        If CShort(formElementos.comboboxSubUbicacion.ComboBox.SelectedValue) <> FIELD_VALUE_NOTSPECIFIED_SHORT Then
                            .IDSubUbicacion = CShort(formElementos.comboboxSubUbicacion.ComboBox.SelectedValue)
                        End If
                    End If
                    formElementos = Nothing
                End If

                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Elemento.Add(mElementoActual)
        Else
            mElementoActual = mdbContext.Elemento.Find(IDElemento)
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

        comboboxCuartel.Enabled = mEditMode
        comboboxArea.Enabled = mEditMode
        textboxCodigo.ReadOnly = Not mEditMode
        buttonCodigoSiguiente.Visible = (mEditMode And mElementoActual.IDElemento = 0)
        textboxNombre.ReadOnly = Not mEditMode
        comboboxModoAdquisicion.Enabled = mEditMode

        comboboxUbicacion.Enabled = mEditMode
        comboboxSubUbicacion.Enabled = mEditMode

        checkboxEsActivo.Enabled = mEditMode
        datetimepickerFechaBaja.Enabled = (mEditMode And Not checkboxEsActivo.Checked)
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Cuartel(comboboxCuartel, False, False)
        pFillAndRefreshLists.ModoAdquisicion(comboboxModoAdquisicion, False, True)
    End Sub

    Friend Sub SetAppearance()

    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mElementoActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mElementoActual
            If .IDElemento = 0 Then
                textboxIDElemento.Text = My.Resources.STRING_ITEM_NEW_MALE
                CS_Control_ComboBox.SetSelectedValue(comboboxCuartel, SelectedItemOptions.ValueOrFirstIfUnique, mIDCuartel)
            Else
                textboxIDElemento.Text = String.Format(.IDElemento.ToString, "G")
                CS_Control_ComboBox.SetSelectedValue(comboboxCuartel, SelectedItemOptions.ValueOrFirstIfUnique, .Area.IDCuartel)
            End If
            CS_Control_ComboBox.SetSelectedValue(comboboxArea, SelectedItemOptions.ValueOrFirstIfUnique, .IDArea)
            textboxCodigo.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Codigo).TrimEnd
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            CS_Control_ComboBox.SetSelectedValue(comboboxModoAdquisicion, SelectedItemOptions.ValueOrFirst, .IDModoAdquisicion, 0)

            CS_Control_ComboBox.SetSelectedValue(comboboxUbicacion, SelectedItemOptions.ValueOrFirst, .IDUbicacion, 0)
            CS_Control_ComboBox.SetSelectedValue(comboboxSubUbicacion, SelectedItemOptions.ValueOrFirst, .IDSubUbicacion, 0)

            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            If checkboxEsActivo.Checked Then
                datetimepickerFechaBaja.Value = DateAndTime.Today
                datetimepickerFechaBaja.Checked = False
            Else
                datetimepickerFechaBaja.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaBaja, datetimepickerFechaBaja)
            End If
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mElementoActual
            .IDArea = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxArea.SelectedValue).Value
            .Codigo = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCodigo.Text)
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .IDModoAdquisicion = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxModoAdquisicion.SelectedValue)

            .IDUbicacion = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxUbicacion.SelectedValue, Short.MinValue)
            .IDSubUbicacion = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxSubUbicacion.SelectedValue, Short.MinValue)

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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNombre.GotFocus
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

            If dbcMaxCodigo.Elemento.Where(Function(e) e.IDArea = IDArea).Count = 0 Then
                textboxCodigo.Text = CStr(1).PadLeft(5, "0"c)
            Else
                textboxCodigo.Text = CStr(CInt(dbcMaxCodigo.Elemento.Where(Function(e) e.IDArea = IDArea).Max(Function(e) e.Codigo)) + 1).PadLeft(5, "0"c)
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
        If Permisos.VerificarPermiso(Permisos.Elemento_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
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
        If textboxNombre.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Nombre.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxNombre.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mElementoActual.IDElemento = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.Elemento.Count = 0 Then
                    mElementoActual.IDElemento = 1
                Else
                    mElementoActual.IDElemento = dbcMaxID.Elemento.Max(Function(a) a.IDElemento) + CByte(1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mElementoActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mElementoActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                If CS_Form.MDIChild_IsLoaded(CType(formMDIMain, Form), "formElementos") Then
                    Dim formElementos As formElementos = CType(CS_Form.MDIChild_GetInstance(CType(formMDIMain, Form), "formElementos"), formElementos)
                    formElementos.RefreshData(mElementoActual.IDElemento)
                    formElementos = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Elemento con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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