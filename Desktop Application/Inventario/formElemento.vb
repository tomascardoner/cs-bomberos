Public Class formElemento

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mElementoActual As Elemento

    Private mIsLoading As Boolean
    Private mEditMode As Boolean
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
                If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formElementos") Then
                    Dim formElementos As formElementos = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formElementos"), formElementos)
                    If formElementos.comboboxRubro.SelectedIndex > 0 Then
                        If CShort(formElementos.comboboxRubro.ComboBox.SelectedValue) <> CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
                            .IDRubro = CByte(formElementos.comboboxRubro.ComboBox.SelectedValue)
                        End If
                    End If
                    If formElementos.comboboxSubRubro.SelectedIndex > 0 Then
                        If CShort(formElementos.comboboxSubRubro.ComboBox.SelectedValue) <> CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT Then
                            .IDSubRubro = CShort(formElementos.comboboxSubRubro.ComboBox.SelectedValue)
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

        Me.MdiParent = pFormMDIMain
        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
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

        comboboxRubro.Enabled = mEditMode
        comboboxSubRubro.Enabled = mEditMode

        textboxNotas.ReadOnly = Not mEditMode
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Rubro(comboboxRubro, False, True)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mElementoActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mElementoActual
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)

            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxRubro, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IDRubro, 0)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxSubRubro, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IDSubRubro, 0)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            If .IDElemento = 0 Then
                textboxIDElemento.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDElemento.Text = String.Format(.IDElemento.ToString, "G")
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
        With mElementoActual
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)

            .IDRubro = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxRubro.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            .IDSubRubro = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxSubRubro.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)

            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNombre.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub comboboxRubro_SelectedIndexChanged() Handles comboboxRubro.SelectedIndexChanged
        pFillAndRefreshLists.SubRubro(comboboxSubRubro, False, True, CByte(comboboxRubro.SelectedValue))
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.ELEMENTO_EDITAR) Then
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

        ' Generar el ID nuevo
        If mElementoActual.IDElemento = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.Elemento.Any() Then
                    mElementoActual.IDElemento = dbcMaxID.Elemento.Max(Function(e) e.IDElemento) + CByte(1)
                Else
                    mElementoActual.IDElemento = 1
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
                If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formElementos") Then
                    Dim formElementos As formElementos = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formElementos"), formElementos)
                    formElementos.RefreshData(mElementoActual.IDElemento)
                    formElementos = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Elemento con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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