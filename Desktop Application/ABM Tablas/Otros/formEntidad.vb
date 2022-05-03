Public Class formEntidad

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mEntidadActual As Entidad

    Private mIsLoading As Boolean
    Private mIsNew As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDEntidad As Short)
        mIsLoading = True
        mEditMode = EditMode
        mIsNew = (IDEntidad = 0)

        If mIsNew Then
            ' Es Nuevo
            mEntidadActual = New Entidad
            With mEntidadActual
                .DomicilioIDProvincia = CS_Parameter_System.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID)
                .DomicilioIDLocalidad = CS_Parameter_System.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID)
                .HabilitarCompra = True
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Entidad.Add(mEntidadActual)
        Else
            mEntidadActual = mdbContext.Entidad.Find(IDEntidad)
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
        buttonEditar.Visible = Not mEditMode
        buttonCerrar.Visible = Not mEditMode

        ' General
        textboxNombre.ReadOnly = Not mEditMode
        maskedtextboxCUIT.ReadOnly = Not mEditMode
        textboxTelefono1.ReadOnly = Not mEditMode
        textboxTelefono2.ReadOnly = Not mEditMode
        textboxEmail1.ReadOnly = Not mEditMode
        textboxEmail2.ReadOnly = Not mEditMode
        textboxDomicilioCalle1.ReadOnly = Not mEditMode
        textboxDomicilioNumero.ReadOnly = Not mEditMode
        textboxDomicilioPiso.ReadOnly = Not mEditMode
        textboxDomicilioDepartamento.ReadOnly = Not mEditMode
        textboxDomicilioCalle2.ReadOnly = Not mEditMode
        textboxDomicilioCalle3.ReadOnly = Not mEditMode
        comboboxDomicilioProvincia.Enabled = mEditMode
        comboboxDomicilioLocalidad.Enabled = mEditMode
        textboxDomicilioCodigoPostal.ReadOnly = Not mEditMode
        checkboxHabilitarCompra.Enabled = mEditMode
        checkboxHabilitarVenta.Enabled = mEditMode

        ' Datos bancarios
        comboboxCuentaBancariaBanco.Enabled = mEditMode
        comboboxCuentaBancariaTipo.Enabled = mEditMode
        maskedtextboxCuentaBancariaSucursal.ReadOnly = Not mEditMode
        textboxCuentaBancariaNumero.ReadOnly = Not mEditMode
        maskedtextboxCuentaBancariaCbu.ReadOnly = Not mEditMode
        textboxCuentaBancariaCbuAlias.ReadOnly = Not mEditMode
        maskedtextboxCuentaBancariaCuit.ReadOnly = Not mEditMode
        textboxCuentaBancariaTitular.ReadOnly = Not mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Provincia(comboboxDomicilioProvincia, True)
        pFillAndRefreshLists.Provincia(comboboxDomicilioProvincia, True)
        ListasComprobantes.LlenarComboBoxBancos(mdbContext, comboboxCuentaBancariaBanco, False, True)
        ListasComprobantes.LlenarComboBoxCuentasBancariasTipos(mdbContext, comboboxCuentaBancariaTipo, False, True)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mEntidadActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mEntidadActual
            ' Datos de la pestaña General
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            maskedtextboxCUIT.Text = CS_ValueTranslation.FromObjectLongToControlTextBox(.Cuit)
            textboxTelefono1.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Telefono1)
            textboxTelefono2.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Telefono2)
            textboxEmail1.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Email1)
            textboxEmail2.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Email2)
            textboxDomicilioCalle1.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioCalle1)
            textboxDomicilioNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioNumero)
            textboxDomicilioPiso.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioPiso)
            textboxDomicilioDepartamento.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioDepartamento)
            textboxDomicilioCalle2.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioCalle2)
            textboxDomicilioCalle3.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioCalle3)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxDomicilioProvincia, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .DomicilioIDProvincia, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxDomicilioLocalidad, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .DomicilioIDLocalidad, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            textboxDomicilioCodigoPostal.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioCodigoPostal)
            checkboxHabilitarCompra.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.HabilitarCompra)
            checkboxHabilitarVenta.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.HabilitarVenta)

            ' Datos de la pestaña Datos bancarios
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxCuentaBancariaBanco, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .CuentaBancariaIDBanco, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxCuentaBancariaTipo, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .CuentaBancariaIDTipo, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            maskedtextboxCuentaBancariaSucursal.Text = CS_ValueTranslation.FromObjectShortToControlTextBox(.CuentaBancariaSucursal)
            textboxCuentaBancariaNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.CuentaBancariaNumero)
            maskedtextboxCuentaBancariaCbu.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.CuentaBancariaCbu)
            textboxCuentaBancariaCbuAlias.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.CuentaBancariaCbuAlias)
            maskedtextboxCuentaBancariaCuit.Text = CS_ValueTranslation.FromObjectLongToControlTextBox(.CuentaBancariaCuit)
            textboxCuentaBancariaTitular.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.CuentaBancariaTitular)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            If mIsNew Then
                textboxID.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxID.Text = String.Format(.IDEntidad.ToString, "G")
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
        With mEntidadActual
            ' Datos de la pestaña General
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .Cuit = CS_ValueTranslation.FromControlTextBoxToObjectLong(maskedtextboxCUIT.Text)
            .Telefono1 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxTelefono1.Text)
            .Telefono2 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxTelefono2.Text)
            .Email1 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxEmail1.Text)
            .Email2 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxEmail2.Text)
            .DomicilioCalle1 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioCalle1.Text)
            .DomicilioNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioNumero.Text)
            .DomicilioPiso = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioPiso.Text)
            .DomicilioDepartamento = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioDepartamento.Text)
            .DomicilioCalle2 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioCalle2.Text)
            .DomicilioCalle3 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioCalle3.Text)
            .DomicilioIDProvincia = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxDomicilioProvincia.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            .DomicilioIDLocalidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxDomicilioLocalidad.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            .DomicilioCodigoPostal = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioCodigoPostal.Text)
            .HabilitarCompra = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxHabilitarCompra.CheckState)
            .HabilitarVenta = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxHabilitarVenta.CheckState)

            ' Datos de la pestaña Datos bancarios
            .CuentaBancariaIDBanco = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxCuentaBancariaBanco.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            .CuentaBancariaIDTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCuentaBancariaTipo.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            .CuentaBancariaSucursal = CS_ValueTranslation.FromControlComboBoxToObjectShort(maskedtextboxCuentaBancariaSucursal.Text)
            .CuentaBancariaNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCuentaBancariaNumero.Text)
            .CuentaBancariaCbu = CS_ValueTranslation.FromControlTextBoxToObjectString(maskedtextboxCuentaBancariaCbu.Text)
            .CuentaBancariaCbuAlias = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCuentaBancariaCbuAlias.Text)
            .CuentaBancariaCuit = CS_ValueTranslation.FromControlTextBoxToObjectLong(maskedtextboxCuentaBancariaCuit.Text)
            .CuentaBancariaTitular = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCuentaBancariaTitular.Text)

            ' Datos de la pestaña Notas y Auditoría
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNombre.GotFocus, textboxTelefono1.GotFocus, textboxTelefono2.GotFocus, textboxEmail1.GotFocus, textboxEmail2.GotFocus, textboxDomicilioCalle1.GotFocus, textboxDomicilioNumero.GotFocus, textboxDomicilioPiso.GotFocus, textboxDomicilioDepartamento.GotFocus, textboxDomicilioCalle2.GotFocus, textboxDomicilioCalle3.GotFocus, textboxDomicilioCodigoPostal.GotFocus, textboxCuentaBancariaNumero.GotFocus, textboxCuentaBancariaCbuAlias.GotFocus, textboxCuentaBancariaTitular.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub MaskedTextBoxs_GotFocus(sender As Object, e As EventArgs) Handles maskedtextboxCUIT.GotFocus, maskedtextboxCuentaBancariaSucursal.GotFocus, maskedtextboxCuentaBancariaCbu.GotFocus, maskedtextboxCuentaBancariaCuit.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
    End Sub

    Private Sub DomicilioProvincia_Cambiar(sender As Object, e As EventArgs) Handles comboboxDomicilioProvincia.SelectedValueChanged
        If comboboxDomicilioProvincia.SelectedValue Is Nothing Then
            pFillAndRefreshLists.Localidad(comboboxDomicilioLocalidad, 0, True)
            comboboxDomicilioLocalidad.SelectedIndex = 0
        Else
            pFillAndRefreshLists.Localidad(comboboxDomicilioLocalidad, CByte(comboboxDomicilioProvincia.SelectedValue), True)
            If CByte(comboboxDomicilioProvincia.SelectedValue) = CS_Parameter_System.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID) Then
                CardonerSistemas.ComboBox.SetSelectedValue(comboboxDomicilioLocalidad, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, CS_Parameter_System.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID))
            End If
        End If
    End Sub

    Private Sub DomicilioLocalidad_Cambiar(sender As Object, e As EventArgs) Handles comboboxDomicilioLocalidad.SelectedValueChanged
        If Not comboboxDomicilioLocalidad.SelectedValue Is Nothing Then
            textboxDomicilioCodigoPostal.Text = CType(comboboxDomicilioLocalidad.SelectedItem, Localidad).CodigoPostal.ToString()
        End If
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.ENTIDAD_EDITAR) Then
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
                If dbcMaxID.Entidad.Any() Then
                    mEntidadActual.IDEntidad = dbcMaxID.Entidad.Max(Function(a) a.IDEntidad) + CByte(1)
                Else
                    mEntidadActual.IDEntidad = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mEntidadActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mEntidadActual.FechaHoraModificacion = Now

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formEntidades.RefreshData(mEntidadActual.IDEntidad)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Entidad con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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

    Private Function VerificarDatos() As Boolean
        If textboxNombre.Text.Trim.Length = 0 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe ingresar el Nombre.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxNombre.Focus()
            Return False
        End If

        ' CUIT
        If maskedtextboxCUIT.Text.Length > 0 Then
            If maskedtextboxCUIT.Text.Trim.Length < 11 Then
                tabcontrolMain.SelectedTab = tabpageGeneral
                MsgBox("El CUIT debe contener 11 dígitos (sin contar los guiones).", MsgBoxStyle.Information, My.Application.Info.Title)
                maskedtextboxCUIT.Focus()
                Return False
            End If
            If Not CardonerSistemas.Afip.VerificarCuit(maskedtextboxCUIT.Text) Then
                tabcontrolMain.SelectedTab = tabpageGeneral
                MsgBox("El CUIT ingresado es incorrecto.", MsgBoxStyle.Information, My.Application.Info.Title)
                maskedtextboxCUIT.Focus()
                Return False
            End If
        End If

        ' Direcciones de Email
        If textboxEmail1.Text.Trim.Length > 0 Then
            If Not CS_Email.IsValidEmail(textboxEmail1.Text.Trim, CS_Parameter_System.GetString(Parametros.EMAIL_VALIDATION_REGULAREXPRESSION)) Then
                tabcontrolMain.SelectedTab = tabpageGeneral
                MsgBox("La dirección de E-mail 1 es incorrecta.", vbInformation, My.Application.Info.Title)
                textboxEmail1.Focus()
                Return False
            End If
        End If
        If textboxEmail2.Text.Trim.Length > 0 Then
            If Not CS_Email.IsValidEmail(textboxEmail2.Text.Trim, CS_Parameter_System.GetString(Parametros.EMAIL_VALIDATION_REGULAREXPRESSION)) Then
                tabcontrolMain.SelectedTab = tabpageGeneral
                MsgBox("La dirección de E-mail 2 es incorrecta.", vbInformation, My.Application.Info.Title)
                textboxEmail2.Focus()
                Return False
            End If
        End If

        ' Datos bancarios - CBU
        If maskedtextboxCuentaBancariaCbu.Text.Length > 0 Then
            If maskedtextboxCuentaBancariaCbu.Text.Length < 22 Then
                tabcontrolMain.SelectedTab = tabpageDatosBancarios
                MessageBox.Show("Debe especificar los 22 dígitos del CBU.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                maskedtextboxCuentaBancariaCbu.Focus()
                Return False
            End If
            Select Case CardonerSistemas.Bank.VerificarCBU(maskedtextboxCuentaBancariaCbu.Text)
                Case 0
                    tabcontrolMain.SelectedTab = tabpageDatosBancarios
                    MessageBox.Show("El CBU ingresado es incorrecto.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    maskedtextboxCuentaBancariaCbu.Focus()
                    Return False
                Case 1
                    tabcontrolMain.SelectedTab = tabpageDatosBancarios
                    MessageBox.Show("El CBU ingresado tiene un error en el 1er. bloque.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    maskedtextboxCuentaBancariaCbu.Focus()
                    Return False
                Case 2
                    tabcontrolMain.SelectedTab = tabpageDatosBancarios
                    MessageBox.Show("El CBU ingresado tiene un error en el 2do. bloque.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    maskedtextboxCuentaBancariaCbu.Focus()
                    Return False
            End Select
        End If

        ' Datos bancarios - CUIT
        If maskedtextboxCuentaBancariaCuit.Text.Length > 0 Then
            If maskedtextboxCuentaBancariaCuit.Text.Trim.Length < 11 Then
                tabcontrolMain.SelectedTab = tabpageDatosBancarios
                MsgBox("El CUIT de la cuenta bancaria debe contener 11 dígitos (sin contar los guiones).", MsgBoxStyle.Information, My.Application.Info.Title)
                maskedtextboxCuentaBancariaCuit.Focus()
                Return False
            End If
            If Not CardonerSistemas.Afip.VerificarCuit(maskedtextboxCuentaBancariaCuit.Text) Then
                tabcontrolMain.SelectedTab = tabpageDatosBancarios
                MsgBox("El CUIT de la cuenta bancaria ingresado es incorrecto.", MsgBoxStyle.Information, My.Application.Info.Title)
                maskedtextboxCuentaBancariaCuit.Focus()
                Return False
            End If
        End If


        Return True
    End Function

#End Region

End Class