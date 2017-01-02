Public Class formPersonaAltaBaja

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaAltaBajaActual As PersonaAltaBaja

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer, ByVal IDAltaBaja As Byte)
        mIsLoading = True
        mEditMode = EditMode

        If IDAltaBaja = 0 Then
            ' Es Nuevo
            mPersonaAltaBajaActual = New PersonaAltaBaja
            With mPersonaAltaBajaActual
                .FechaAlta = DateTime.Today
                .IDPersona = IDPersona
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.PersonaAltaBaja.Add(mPersonaAltaBajaActual)
        Else
            mPersonaAltaBajaActual = mdbContext.PersonaAltaBaja.Find(IDPersona, IDAltaBaja)
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

        datetimepickerFechaAlta.Enabled = mEditMode
        textboxUnidadOrigen.ReadOnly = Not mEditMode

        textboxLibroNumero.ReadOnly = Not mEditMode
        textboxFolioNumero.ReadOnly = Not mEditMode
        textboxActaNumero.ReadOnly = Not mEditMode

        datetimepickerFechaBaja.Enabled = mEditMode
        textboxUnidadDestino.ReadOnly = Not mEditMode
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
        mPersonaAltaBajaActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mPersonaAltaBajaActual
            If .IDAltaBaja = 0 Then
                textboxIDAltaBaja.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDAltaBaja.Text = String.Format(.IDAltaBaja.ToString, "G")
            End If
            datetimepickerFechaAlta.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaAlta)
            textboxUnidadOrigen.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.UnidadOrigen)
            datetimepickerFechaBaja.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaBaja, datetimepickerFechaBaja)
            textboxUnidadDestino.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.UnidadDestino)
            textboxLibroNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.LibroNumero)
            textboxFolioNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.FolioNumero)
            textboxActaNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.ActaNumero)
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mPersonaAltaBajaActual
            .FechaAlta = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaAlta.Value).Value
            .UnidadOrigen = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxUnidadOrigen.Text)
            .FechaBaja = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaBaja.Value, datetimepickerFechaBaja.Checked)
            .UnidadDestino = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxUnidadDestino.Text)
            .LibroNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxLibroNumero.Text)
            .FolioNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxFolioNumero.Text)
            .ActaNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxActaNumero.Text)
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxLibroNumero.GotFocus, textboxFolioNumero.GotFocus, textboxActaNumero.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_ACCIDENTE_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If textboxUnidadOrigen.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Diagnósitoco.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxUnidadOrigen.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mPersonaAltaBajaActual.IDAltaBaja = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                Dim PersonaActual As Persona
                PersonaActual = dbcMaxID.Persona.Find(mPersonaAltaBajaActual.IDPersona)
                If PersonaActual.PersonaAltasBajas.Count = 0 Then
                    mPersonaAltaBajaActual.IDAltaBaja = 1
                Else
                    mPersonaAltaBajaActual.IDAltaBaja = PersonaActual.PersonaAltasBajas.Max(Function(pab) pab.IDAltaBaja) + CByte(1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mPersonaAltaBajaActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mPersonaAltaBajaActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                If CS_Form.MDIChild_IsLoaded(CType(formMDIMain, Form), "formPersonaAltasBajas") Then
                    Dim formPersonaAltasBajas As formPersonaAltasBajas = CType(CS_Form.MDIChild_GetInstance(CType(formMDIMain, Form), "formPersonaAltasBajas"), formPersonaAltasBajas)
                    formPersonaAltasBajas.RefreshData(mPersonaAltaBajaActual.IDAltaBaja)
                    formPersonaAltasBajas = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Accidente con los mismos datos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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