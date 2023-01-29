Public Class formResponsable

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mResponsableActual As Responsable

    Private mIsLoading As Boolean
    Private mIsNew As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDResponsable As Short)
        mIsLoading = True
        mEditMode = EditMode
        mIsNew = (IDResponsable = 0)

        If mIsNew Then
            ' Es Nuevo
            mResponsableActual = New Responsable
            With mResponsableActual
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Responsable.Add(mResponsableActual)
        Else
            mResponsableActual = mdbContext.Responsable.Find(IDResponsable)
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

        ' Toolbar
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        ' General
        comboboxResponsableTipo.Enabled = mEditMode
        comboboxCuartel.Enabled = mEditMode
        radiobuttonPersona.Visible = mEditMode
        radiobuttonPersonaOtra.Visible = mEditMode
        controlpersonaPersona.ReadOnlyText = Not mEditMode
        textboxPersonaOtra.ReadOnly = Not mEditMode
        MostrarControlesPersonas()

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        ListasResponsables.LlenarComboBoxResponsableTipos(mdbContext, comboboxResponsableTipo, False, False)
        ListasComunes.LlenarComboBoxCuarteles(mdbContext, comboboxCuartel, False, True)
        controlpersonaPersona.dbContext = mdbContext
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mResponsableActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mResponsableActual
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxResponsableTipo, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDResponsableTipo)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxCuartel, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IDCuartel, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)

            ' Personas
            If mIsNew Then
                radiobuttonPersona.Checked = True
            Else
                radiobuttonPersona.Checked = .IDPersona.HasValue
                radiobuttonPersonaOtra.Checked = Not .IDPersona.HasValue
            End If
            If .IDPersona IsNot Nothing Then
                controlpersonaPersona.AsignarValores(.Persona)
                textboxPersonaOtra.Text = String.Empty
            Else
                controlpersonaPersona.ResetText()
                textboxPersonaOtra.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.PersonaOtra)
            End If

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If mIsNew Then
                textboxID.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxID.Text = String.Format(.IDResponsable.ToString, "G")
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
        With mResponsableActual
            .IDResponsableTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxResponsableTipo.SelectedValue).Value
            .IDCuartel = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCuartel.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)

            ' Personas
            If radiobuttonPersona.Checked Then
                .IDPersona = controlpersonaPersona.IDPersona.Value
                .PersonaOtra = Nothing
            Else
                .IDPersona = Nothing
                .PersonaOtra = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxPersonaOtra.Text.TrimAndReduce)
            End If

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

    Private Sub PersonaOtraCheckedChanged(sender As Object, e As EventArgs) Handles radiobuttonPersona.CheckedChanged, radiobuttonPersonaOtra.CheckedChanged
        MostrarControlesPersonas()
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxPersonaOtra.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.AREA_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If Not VerificarDatos() Then
            Return
        End If

        ' Generar el ID nuevo
        If mIsNew Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.Responsable.Any() Then
                    mResponsableActual.IDResponsable = dbcMaxID.Responsable.Max(Function(a) a.IDResponsable) + CByte(1)
                Else
                    mResponsableActual.IDResponsable = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mResponsableActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mResponsableActual.FechaHoraModificacion = Now

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formResponsables.RefreshData(mResponsableActual.IDResponsable)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Responsable con el mismo Tipo.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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

    Private Sub MostrarControlesPersonas()
        controlpersonaPersona.Visible = radiobuttonPersona.Checked
        textboxPersonaOtra.Visible = radiobuttonPersonaOtra.Checked
    End Sub

    Private Function VerificarDatos() As Boolean
        If comboboxResponsableTipo.SelectedIndex = -1 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Tipo de Responsable.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxResponsableTipo.Focus()
            Return False
        End If
        If comboboxCuartel.SelectedIndex = -1 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Cuartel.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuartel.Focus()
            Return False
        End If
        If radiobuttonPersona.Checked AndAlso Not controlpersonaPersona.IDPersona.HasValue Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar la Persona.", MsgBoxStyle.Information, My.Application.Info.Title)
            Return False
        End If
        If radiobuttonPersonaOtra.Checked AndAlso String.IsNullOrWhiteSpace(textboxPersonaOtra.Text.TrimAndReduce) Then
            If textboxPersonaOtra.Text.Trim.Length = 0 Then
                tabcontrolMain.SelectedTab = tabpageGeneral
                MsgBox("Debe especificar la Persona Otra.", MsgBoxStyle.Information, My.Application.Info.Title)
                textboxPersonaOtra.Focus()
                Return False
            End If
        End If

        Return True
    End Function

#End Region

End Class