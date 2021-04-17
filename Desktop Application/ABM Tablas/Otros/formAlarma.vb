Public Class formAlarma

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mAlarmaActual As Alarma

    Private mIsLoading As Boolean = False
    Private mIsNew As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDAlarma As Short)
        mIsLoading = True
        mEditMode = EditMode
        mIsNew = (IDAlarma = 0)

        If mIsNew Then
            ' Es Nuevo
            mAlarmaActual = New Alarma
            With mAlarmaActual
                .Fecha = DateTime.Today
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Alarma.Add(mAlarmaActual)
        Else
            mAlarmaActual = mdbContext.Alarma.Find(IDAlarma)
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
        comboboxFechaTipo.Enabled = mEditMode
        datetimepickerFecha.Enabled = mEditMode
        updownAvisoDias.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        comboboxFechaTipo.Items.AddRange({ALARMA_FECHATIPO_FECHANACIMIENTOPERSONA_NOMBRE, ALARMA_FECHATIPO_LICENCIACONDUCIRVENCIMIENTO_NOMBRE, ALARMA_FECHATIPO_FECHANACIMIENTOFAMILIAR_NOMBRE, ALARMA_FECHATIPO_FECHAALARMA_NOMBRE})
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.IMAGE_TABLAS_32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mAlarmaActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mAlarmaActual
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            Select Case .FechaTipo
                Case ALARMA_FECHATIPO_FECHANACIMIENTOPERSONA
                    comboboxFechaTipo.SelectedIndex = ALARMA_FECHATIPO_FECHANACIMIENTOPERSONA_LISTINDEX
                Case ALARMA_FECHATIPO_LICENCIACONDUCIRVENCIMIENTO
                    comboboxFechaTipo.SelectedIndex = ALARMA_FECHATIPO_LICENCIACONDUCIRVENCIMIENTO_LISTINDEX
                Case ALARMA_FECHATIPO_FECHANACIMIENTOFAMILIAR
                    comboboxFechaTipo.SelectedIndex = ALARMA_FECHATIPO_FECHANACIMIENTOFAMILIAR_LISTINDEX
                Case ALARMA_FECHATIPO_FECHAALARMA
                    comboboxFechaTipo.SelectedIndex = ALARMA_FECHATIPO_FECHAALARMA_LISTINDEX
            End Select
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha, datetimepickerFecha)
            updownAvisoDias.Value = CS_ValueTranslation.FromObjectShortToControlUpDown(.AvisoDias)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            If mIsNew Then
                textboxIDAlarma.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDAlarma.Text = String.Format(.IDAlarma.ToString, "G")
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
        With mAlarmaActual
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            Select Case comboboxFechaTipo.SelectedIndex
                Case ALARMA_FECHATIPO_FECHANACIMIENTOPERSONA_LISTINDEX
                    .FechaTipo = ALARMA_FECHATIPO_FECHANACIMIENTOPERSONA
                Case ALARMA_FECHATIPO_LICENCIACONDUCIRVENCIMIENTO_LISTINDEX
                    .FechaTipo = ALARMA_FECHATIPO_LICENCIACONDUCIRVENCIMIENTO
                Case ALARMA_FECHATIPO_FECHANACIMIENTOFAMILIAR_LISTINDEX
                    .FechaTipo = ALARMA_FECHATIPO_FECHANACIMIENTOFAMILIAR
                Case ALARMA_FECHATIPO_FECHAALARMA_LISTINDEX
                    .FechaTipo = ALARMA_FECHATIPO_FECHAALARMA
            End Select
            .AvisoDias = CS_ValueTranslation.FromControlUpDownToObjectShort(updownAvisoDias.Value)

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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNombre.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub FechaTipo_Changed(sender As Object, e As EventArgs) Handles comboboxFechaTipo.SelectedIndexChanged
        labelFecha.Visible = (comboboxFechaTipo.SelectedIndex = ALARMA_FECHATIPO_FECHAALARMA_LISTINDEX)
        datetimepickerFecha.Visible = (comboboxFechaTipo.SelectedIndex = ALARMA_FECHATIPO_FECHAALARMA_LISTINDEX)
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.ALARMA_EDITAR) Then
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
                If dbcMaxID.Alarma.Count = 0 Then
                    mAlarmaActual.IDAlarma = 1
                Else
                    mAlarmaActual.IDAlarma = dbcMaxID.Alarma.Max(Function(a) a.IDAlarma) + CByte(1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mAlarmaActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mAlarmaActual.FechaHoraModificacion = Now

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formAlarmas.RefreshData(mAlarmaActual.IDAlarma)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Alarma con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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