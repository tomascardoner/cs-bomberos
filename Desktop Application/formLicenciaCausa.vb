Public Class formLicenciaCausa

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mLicenciaCausaActual As LicenciaCausa

    Private mIsLoading As Boolean = False
    Private mIsNew As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDLicenciaCausa As Byte)
        mIsLoading = True
        mEditMode = EditMode
        mIsNew = (IDLicenciaCausa = 0)
        
        If mIsNew Then
            ' Es Nuevo
            mLicenciaCausaActual = New LicenciaCausa
            With mLicenciaCausaActual
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.LicenciaCausa.Add(mLicenciaCausaActual)
        Else
            mLicenciaCausaActual = mdbContext.LicenciaCausa.Find(IDLicenciaCausa)
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

        ' Toolbar
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        ' General
        textboxNombre.ReadOnly = Not mEditMode
        textboxNombreLegal.ReadOnly = Not mEditMode
        updownCantidadDias.Enabled = mEditMode
        updownCantidadDiasMaximoAnual.Enabled = mEditMode
        updownCantidadVecesMaximoAnual.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()
    End Sub

    Friend Sub SetAppearance()

    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mLicenciaCausaActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mLicenciaCausaActual
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            textboxNombreLegal.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.NombreLegal)
            updownCantidadDias.Value = CS_ValueTranslation.FromObjectShortToControlUpDown(.CantidadDias)
            updownCantidadDiasMaximoAnual.Value = CS_ValueTranslation.FromObjectShortToControlUpDown(.CantidadDiasMaximoAnual)
            updownCantidadVecesMaximoAnual.Value = CS_ValueTranslation.FromObjectShortToControlUpDown(.CantidadVecesMaximoAnual)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            If mIsNew Then
                textboxIDLicenciaCausa.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDLicenciaCausa.Text = String.Format(.IDLicenciaCausa.ToString, "G")
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
        With mLicenciaCausaActual
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .NombreLegal = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombreLegal.Text)
            .CantidadDias = CS_ValueTranslation.FromControlUpDownToObjectByte(updownCantidadDias.Value)
            .CantidadDiasMaximoAnual = CS_ValueTranslation.FromControlUpDownToObjectByte(updownCantidadDiasMaximoAnual.Value)
            .CantidadVecesMaximoAnual = CS_ValueTranslation.FromControlUpDownToObjectByte(updownCantidadVecesMaximoAnual.Value)

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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNombre.GotFocus, textboxNombreLegal.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.LICENCIACAUSA_EDITAR) Then
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
        If mIsNew Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.LicenciaCausa.Count = 0 Then
                    mLicenciaCausaActual.IDLicenciaCausa = 1
                Else
                    mLicenciaCausaActual.IDLicenciaCausa = dbcMaxID.LicenciaCausa.Max(Function(a) a.IDLicenciaCausa) + CByte(1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mLicenciaCausaActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mLicenciaCausaActual.FechaHoraModificacion = Now

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formLicenciaCausas.RefreshData(mLicenciaCausaActual.IDLicenciaCausa)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Causa de Licencia con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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