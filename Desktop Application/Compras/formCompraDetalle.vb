Public Class formCompraDetalle

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mCompraDetalleActual As CompraDetalle

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
    Private mIsNew As Boolean = False

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDCompra As Integer, ByVal IDDetalle As Byte)
        mIsLoading = True
        mEditMode = EditMode
        mIsNew = (IDDetalle = 0)

        If mIsNew Then
            ' Es Nuevo
            mCompraDetalleActual = New CompraDetalle
            With mCompraDetalleActual
                .IDCompra = IDCompra
            End With
            mdbContext.CompraDetalle.Add(mCompraDetalleActual)
        Else
            mCompraDetalleActual = mdbContext.CompraDetalle.Find(IDCompra, IDDetalle)
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
        comboboxArea.Enabled = mEditMode
        textboxDetalle.ReadOnly = Not mEditMode
        currencytextboxImporte.ReadOnly = Not mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Area(comboboxArea, False, False, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, True)
    End Sub

    Friend Sub SetAppearance()

    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mCompraDetalleActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mCompraDetalleActual
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxArea, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDCargo)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxCargoJerarquia, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDJerarquia)
            textboxLibroNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.LibroNumero)
            textboxFolioNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.FolioNumero)
            textboxActaNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.ActaNumero)
            textboxOrdenGeneralNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.OrdenGeneralNumero)
            textboxResolucionNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.ResolucionNumero)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .IDAscenso = 0 Then
                textboxID.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxID.Text = String.Format(.IDAscenso.ToString, "G")
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
        With mCompraDetalleActual
            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFecha.Value).Value
            .IDCargo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxArea.SelectedValue).Value
            .IDJerarquia = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCargoJerarquia.SelectedValue).Value
            .LibroNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxLibroNumero.Text)
            .FolioNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxFolioNumero.Text)
            .ActaNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxActaNumero.Text)
            .OrdenGeneralNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxOrdenGeneralNumero.Text)
            .ResolucionNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxResolucionNumero.Text)

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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub comboboxCargo_SelectedIndexChanged() Handles comboboxArea.SelectedIndexChanged
        pFillAndRefreshLists.CargoJerarquia(comboboxCargoJerarquia, False, False, CByte(comboboxArea.SelectedValue))
        comboboxCargoJerarquia.SelectedItem = Nothing
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_ASCENSO_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If comboboxArea.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Cargo.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxArea.Focus()
            Exit Sub
        End If
        If comboboxCargoJerarquia.SelectedValue Is Nothing Then
            MsgBox("Debe especificar la Jerarquía.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCargoJerarquia.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mCompraDetalleActual.IDAscenso = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                Dim PersonaActual As Persona
                PersonaActual = dbcMaxID.Persona.Find(mCompraDetalleActual.IDPersona)
                If PersonaActual.CompraDetalles.Count = 0 Then
                    mCompraDetalleActual.IDAscenso = 1
                Else
                    mCompraDetalleActual.IDAscenso = PersonaActual.CompraDetalles.Max(Function(pa) pa.IDAscenso) + CByte(1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mCompraDetalleActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mCompraDetalleActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formPersona.Ascensos_RefreshData(mCompraDetalleActual.IDAscenso)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Ascenso - Promoción con los mismos datos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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