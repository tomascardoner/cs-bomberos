Public Class formPersonaAltaBaja

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaAltaBajaActual As PersonaAltaBaja
    Private mPersonaBajaMotivo As PersonaBajaMotivo

    Private mIsNew As Boolean
    Private mIsLoading As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer, ByVal IDAltaBaja As Byte)
        mIsNew = (IDAltaBaja = 0)
        mIsLoading = True
        mEditMode = EditMode

        If mIsNew Then
            ' Es Nuevo
            mPersonaAltaBajaActual = New PersonaAltaBaja
            With mPersonaAltaBajaActual
                .IDPersona = IDPersona

                .Fecha = DateTime.Today
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.PersonaAltaBaja.Add(mPersonaAltaBajaActual)
        Else
            mPersonaAltaBajaActual = mdbContext.PersonaAltaBaja.Find(IDPersona, IDAltaBaja)
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

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        radiobuttonTipoAlta.Enabled = mEditMode
        radiobuttonTipoBaja.Enabled = mEditMode
        datetimepickerFecha.Enabled = mEditMode
        textboxLibroNumero.ReadOnly = Not mEditMode
        textboxFolioNumero.ReadOnly = Not mEditMode
        textboxActaNumero.ReadOnly = Not mEditMode
        textboxOrdenGeneralNumero.ReadOnly = Not mEditMode
        textboxResolucionNumero.ReadOnly = Not mEditMode

        comboboxBajaMotivo.Enabled = mEditMode
        textboxBajaUnidadDestino.ReadOnly = Not mEditMode

        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        ' Cargo los ComboBox
        pFillAndRefreshLists.PersonaBajaMotivo(comboboxBajaMotivo, False, True)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mPersonaAltaBajaActual = Nothing
        mPersonaBajaMotivo = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mPersonaAltaBajaActual
            radiobuttonTipoAlta.Checked = (.Tipo = Constantes.PERSONA_ALTABAJA_TIPO_ALTA)
            radiobuttonTipoBaja.Checked = (.Tipo = Constantes.PERSONA_ALTABAJA_TIPO_BAJA)
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha)
            textboxLibroNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.LibroNumero)
            textboxFolioNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.FolioNumero)
            textboxActaNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.ActaNumero)
            textboxOrdenGeneralNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.OrdenGeneralNumero)
            textboxResolucionNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.ResolucionNumero)

            ' Baja
            If .Tipo = Constantes.PERSONA_ALTABAJA_TIPO_ALTA Then
                comboboxBajaMotivo.SelectedIndex = -1
                textboxBajaUnidadDestino.Text = String.Empty
            Else
                CardonerSistemas.ComboBox.SetSelectedValue(comboboxBajaMotivo, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDPersonaBajaMotivo, CByte(0))
                If (mPersonaBajaMotivo IsNot Nothing) AndAlso mPersonaBajaMotivo.EspecificaDestino Then
                    textboxBajaUnidadDestino.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.BajaUnidadDestino)
                Else
                    textboxBajaUnidadDestino.Text = ""
                End If
            End If

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .IDAltaBaja = 0 Then
                textboxIDAltaBaja.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDAltaBaja.Text = String.Format(.IDAltaBaja.ToString, "G")
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
        With mPersonaAltaBajaActual
            .Tipo = If(radiobuttonTipoAlta.Checked, Constantes.PERSONA_ALTABAJA_TIPO_ALTA, Constantes.PERSONA_ALTABAJA_TIPO_BAJA)
            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFecha.Value).Value
            .LibroNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxLibroNumero.Text)
            .FolioNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxFolioNumero.Text)
            .ActaNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxActaNumero.Text)
            .OrdenGeneralNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxOrdenGeneralNumero.Text)
            .ResolucionNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxResolucionNumero.Text)

            ' Baja
            If radiobuttonTipoAlta.Checked Then
                .IDPersonaBajaMotivo = Nothing
                .BajaUnidadDestino = Nothing
            Else
                .IDPersonaBajaMotivo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxBajaMotivo.SelectedValue)
                If (mPersonaBajaMotivo IsNot Nothing) AndAlso mPersonaBajaMotivo.EspecificaDestino Then
                    .BajaUnidadDestino = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxBajaUnidadDestino.Text)
                Else
                    .BajaUnidadDestino = Nothing
                End If
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

    Private Sub RadioButtons_CheckedChanged(sender As Object, e As EventArgs) Handles radiobuttonTipoAlta.CheckedChanged, radiobuttonTipoBaja.CheckedChanged
        groupboxBaja.Visible = radiobuttonTipoBaja.Checked
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxLibroNumero.GotFocus, textboxFolioNumero.GotFocus, textboxActaNumero.GotFocus, textboxOrdenGeneralNumero.GotFocus, textboxResolucionNumero.GotFocus, textboxBajaUnidadDestino.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub comboboxBajaMotivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxBajaMotivo.SelectedIndexChanged
        If comboboxBajaMotivo.SelectedItem IsNot Nothing Then
            mPersonaBajaMotivo = CType(comboboxBajaMotivo.SelectedItem, PersonaBajaMotivo)

            labelBajaUnidadDestino.Visible = mPersonaBajaMotivo.EspecificaDestino
            textboxBajaUnidadDestino.Visible = mPersonaBajaMotivo.EspecificaDestino
        End If
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_ALTABAJA_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If Not (radiobuttonTipoAlta.Checked Or radiobuttonTipoBaja.Checked) Then
            MsgBox("Debe indicar si es un Alta o una Baja.", MsgBoxStyle.Information, My.Application.Info.Title)
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
                formPersona.AltasBajas_RefreshData(mPersonaAltaBajaActual.IDAltaBaja)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Alta o una Baja con los mismos datos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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