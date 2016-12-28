Public Class formUbicacion

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mUbicacionActual As Ubicacion

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDUbicacion As Short)
        mIsLoading = True
        mEditMode = EditMode

        If IDUbicacion = 0 Then
            ' Es Nuevo
            mUbicacionActual = New Ubicacion
            With mUbicacionActual
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Ubicacion.Add(mUbicacionActual)
        Else
            mUbicacionActual = mdbContext.Ubicacion.Find(IDUbicacion)
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

        textboxNombre.ReadOnly = Not mEditMode
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Cuartel(comboboxCuartel, False, False)
    End Sub

    Friend Sub SetAppearance()

    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mUbicacionActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mUbicacionActual
            If .IDUbicacion = 0 Then
                textboxIDUbicacion.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDUbicacion.Text = String.Format(.IDUbicacion.ToString, "G")
            End If
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            CS_Control_ComboBox.SetSelectedValue(comboboxCuartel, SelectedItemOptions.ValueOrFirst, .IDCuartel)
            CS_Control_ComboBox.SetSelectedValue(comboboxAutomotor, SelectedItemOptions.ValueOrFirst, .IDAutomotor)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mUbicacionActual
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .IDCuartel = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCuartel.SelectedValue).Value
            .IDAutomotor = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxAutomotor.SelectedValue)
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
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

    Private Sub comboboxCuartel_SelectedIndexChanged() Handles comboboxCuartel.SelectedIndexChanged
        pFillAndRefreshLists.Automotor(comboboxAutomotor, False, True, CByte(comboboxCuartel.SelectedValue))
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.Ubicacion_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If textboxNombre.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Nombre.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxNombre.Focus()
            Exit Sub
        End If

        If comboboxCuartel.SelectedIndex = 0 Then
            MsgBox("Debe especificar el Cuartel.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuartel.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mUbicacionActual.IDUbicacion = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.Ubicacion.Count = 0 Then
                    mUbicacionActual.IDUbicacion = 1
                Else
                    mUbicacionActual.IDUbicacion = dbcMaxID.Ubicacion.Max(Function(a) a.IDUbicacion) + CByte(1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mUbicacionActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mUbicacionActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                If CS_Form.MDIChild_IsLoaded(CType(formMDIMain, Form), "formUbicaciones") Then
                    Dim formUbicaciones As formUbicaciones = CType(CS_Form.MDIChild_GetInstance(CType(formMDIMain, Form), "formUbicaciones"), formUbicaciones)
                    formUbicaciones.RefreshData(mUbicacionActual.IDUbicacion)
                    formUbicaciones = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Ubicación con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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