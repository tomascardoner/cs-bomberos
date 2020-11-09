Public Class formCompra

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mCompraActual As Compra

    Private mIsLoading As Boolean = False
    Private mIsNew As Boolean = False
    Private mEditMode As Boolean = False

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDCompra As Integer)
        mIsLoading = True
        mEditMode = EditMode

        mIsNew = (IDCompra = 0)
        If mIsNew Then
            ' Es Nuevo
            mCompraActual = New Compra
            With mCompraActual
                ' Si hay filtros aplicados en el form principal, uso esos valores como predeterminados
                If formCompras.comboboxProveedor.SelectedIndex > 0 Then
                    .IDProveedor = CShort(formCompras.comboboxProveedor.ComboBox.SelectedValue)
                End If

                .Cerrada = False
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Compra.Add(mCompraActual)
        Else
            mCompraActual = mdbContext.Compra.Find(IDCompra)
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

        '  Toolbar
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        ' General
        integertextboxIDCompra.ReadOnly = True
        datetimepickerFecha.Enabled = mEditMode
        comboboxProveedor.Enabled = mEditMode
        datetimepickerFacturaFecha.Enabled = mEditMode
        textboxFacturaNumero.ReadOnly = Not mEditMode
        checkboxCerrada.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Proveedor(comboboxProveedor, False, True)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.IMAGE_COMPRAS_32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mCompraActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mCompraActual
            integertextboxIDCompra.IntegerValue = .IDCompra
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxProveedor, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, .IDProveedor, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            datetimepickerFacturaFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FacturaFecha, datetimepickerFacturaFecha)
            textboxFacturaNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.FacturaNumero)
            checkboxCerrada.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Cerrada)

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
        With mCompraActual
            .IDCompra = CShort(integertextboxIDCompra.IntegerValue)
            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFecha.Value).Value
            .IDProveedor = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxProveedor.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            .FacturaFecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFacturaFecha.Value, datetimepickerFacturaFecha.Checked)
            .FacturaNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxFacturaNumero.Text)
            .Cerrada = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxCerrada.CheckState)

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

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.COMPRA_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        If mdbContext.ChangeTracker.HasChanges Then
            If MsgBox("Ha realizado cambios en los datos y seleccionó cancelar, los cambios se perderán.{0}{0}¿Confirma la pérdida de los cambios?", CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If comboboxProveedor.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Proveedor.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxProveedor.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mCompraActual.IDCompra = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.Compra.Any() Then
                    mCompraActual.IDCompra = dbcMaxID.Compra.Max(Function(c) c.IDCompra) + 1
                Else
                    mCompraActual.IDCompra = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mCompraActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mCompraActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                If CS_Form.MDIChild_IsLoaded(CType(pFormMDIMain, Form), "formCompras") Then
                    Dim formCompras As formCompras = CType(CS_Form.MDIChild_GetInstance(CType(pFormMDIMain, Form), "formCompras"), formCompras)
                    formCompras.RefreshData(mCompraActual.IDCompra)
                    formCompras = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Compra con el mismo Número.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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