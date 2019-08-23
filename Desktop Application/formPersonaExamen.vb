Public Class formPersonaExamen

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaExamenActual As PersonaExamen

    Private mIsLoading As Boolean = False
    Private mIsNew As Boolean
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer, ByVal Anio As Short, ByVal InstanciaNumero As Byte)
        mIsNew = (Anio = 0)
        mIsLoading = True
        mEditMode = EditMode

        If mIsNew Then
            ' Es Nuevo
            mPersonaExamenActual = New PersonaExamen
            With mPersonaExamenActual
                .IDPersona = IDPersona

                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.PersonaExamen.Add(mPersonaExamenActual)
        Else
            mPersonaExamenActual = mdbContext.PersonaExamen.Find(IDPersona, Anio, InstanciaNumero)
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
        maskedtextboxAnio.ReadOnly = Not mEditMode
        maskedtextboxInstanciaNumero.ReadOnly = Not mEditMode
        doubletextboxCalificacion.ReadOnly = Not mEditMode

        ' Notas y Auditoría
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
        mPersonaExamenActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mPersonaExamenActual
            maskedtextboxAnio.Text = CS_ValueTranslation.FromObjectShortToControlTextBox(.Anio)
            maskedtextboxInstanciaNumero.Text = CS_ValueTranslation.FromObjectByteToControlTextBox(.InstanciaNumero)
            doubletextboxCalificacion.Text = CS_ValueTranslation.FromObjectDecimalToControlTextBox(.Calificacion)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
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
        With mPersonaExamenActual
            .Anio = CS_ValueTranslation.FromControlTextBoxToObjectShort(maskedtextboxAnio.Text).Value
            .InstanciaNumero = CS_ValueTranslation.FromControlTextBoxToObjectByte(maskedtextboxInstanciaNumero.Text).Value
            .Calificacion = CS_ValueTranslation.FromControlTextBoxToObjectDecimal(doubletextboxCalificacion.Text).Value

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

    Private Sub MaskedTextBoxs_GotFocus(sender As Object, e As EventArgs) Handles maskedtextboxAnio.GotFocus, maskedtextboxInstanciaNumero.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
    End Sub

    Private Sub DoubleTextBoxs_GotFocus(sender As Object, e As EventArgs) Handles doubletextboxCalificacion.GotFocus
        CType(sender, Syncfusion.Windows.Forms.Tools.DoubleTextBox).SelectAll()
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_EXAMEN_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        ' Año
        If maskedtextboxAnio.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Año.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxAnio.Focus()
            Exit Sub
        End If
        If CInt(maskedtextboxAnio.Text) < 1900 Or CInt(maskedtextboxAnio.Text) > DateAndTime.Now.Year Then
            MsgBox(String.Format("El Año debe ser estar entre {0} y {1}.", 1950, DateAndTime.Now.Year), MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxAnio.Focus()
            Exit Sub
        End If

        ' Instancia Número
        If maskedtextboxInstanciaNumero.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Número de Instancia.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxInstanciaNumero.Focus()
            Exit Sub
        End If
        If CByte(maskedtextboxInstanciaNumero.Text) < 1 Or CByte(maskedtextboxInstanciaNumero.Text) > 20 Then
            MsgBox(String.Format("El Número de Instancia debe ser estar entre 1 y {0}.", CS_Parameter_System.GetIntegerAsByte(Parametros.PERSONA_CALIFICACION_INSTANCIA_CANTIDAD, 1)), MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxInstanciaNumero.Focus()
            Exit Sub
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mPersonaExamenActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mPersonaExamenActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formPersona.Examenes_RefreshData(mPersonaExamenActual.Anio, mPersonaExamenActual.InstanciaNumero)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Examen con los mismos datos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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