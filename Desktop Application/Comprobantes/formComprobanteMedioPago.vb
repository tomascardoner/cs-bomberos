Public Class formComprobanteMedioPago

#Region "Declarations"

    Private mComprobanteActual As Comprobante
    Private mComprobanteMedioPagoActual As ComprobanteMedioPago
    Private mMedioPagoCurrent As MedioPago

    Private mParentEditMode As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal ParentEditMode As Boolean, ByVal EditMode As Boolean, ByRef ParentForm As Form, ByRef ComprobanteActual As Comprobante, ByRef ComprobanteMedioPagoActual As ComprobanteMedioPago)
        mParentEditMode = ParentEditMode
        mEditMode = EditMode

        mComprobanteActual = ComprobanteActual
        mComprobanteMedioPagoActual = ComprobanteMedioPagoActual

        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()

        ChangeMode()
        Me.ShowDialog(ParentForm)
    End Sub

    Private Sub ChangeMode()
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mParentEditMode And Not mEditMode)
        buttonCerrar.Visible = Not mEditMode

        comboboxMedioPago.Enabled = mEditMode
        datetimepickerFecha.Enabled = mEditMode
        datetimepickerHora.Enabled = mEditMode
        textboxNumero.ReadOnly = (mEditMode = False)

        ' Datos bancarios
        comboboxBanco.Enabled = mEditMode
        comboboxCuentaBancariaTipo.Enabled = mEditMode
        maskedtextboxCuentaBancariaSucursal.ReadOnly = Not mEditMode
        textboxCuentaBancariaNumero.ReadOnly = Not mEditMode
        maskedtextboxCuentaBancariaCbu.ReadOnly = Not mEditMode
        textboxCuentaBancariaCbuAlias.ReadOnly = Not mEditMode
        maskedtextboxCuentaBancariaCuit.ReadOnly = Not mEditMode
        textboxTitular.ReadOnly = Not mEditMode

        currencytextboxImporte.ReadOnly = (mEditMode = False)
    End Sub

    Friend Sub InitializeFormAndControls()
        ' Cargo los ComboBox
        Using context As New CSBomberosContext(True)
            ListasComprobantes.LlenarComboBoxMediosPago(context, comboboxMedioPago, False, False, False, True)
            ListasComprobantes.LlenarComboBoxBancos(context, comboboxBanco, False, True)
            ListasComprobantes.LlenarComboBoxCuentasBancariasTipos(context, comboboxCuentaBancariaTipo, False, True)
        End Using

        ' Oculto todos los controles por default
        labelFechaHora.Hide()
        datetimepickerFecha.Hide()
        datetimepickerHora.Hide()

        labelNumero.Hide()
        textboxNumero.Hide()

        groupboxDatosBancarios.Hide()
        labelBanco.Hide()
        comboboxBanco.Hide()
        labelCuentaBancariaTipo.Hide()
        comboboxCuentaBancariaTipo.Hide()
        labelCuentaBancariaSucursal.Hide()
        maskedtextboxCuentaBancariaSucursal.Hide()
        labelCuentaBancariaNumero.Hide()
        textboxCuentaBancariaNumero.Hide()
        labelCuentaBancariaCbu.Hide()
        maskedtextboxCuentaBancariaCbu.Hide()
        labelCuentaBancariaCbuAlias.Hide()
        textboxCuentaBancariaCbuAlias.Hide()
        labelCuentaBancariaCuit.Hide()
        maskedtextboxCuentaBancariaCuit.Hide()

        labelTitular.Hide()
        textboxTitular.Hide()
    End Sub

    Private Sub FormEnd(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mComprobanteActual = Nothing
        mComprobanteMedioPagoActual = Nothing
        mMedioPagoCurrent = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mComprobanteMedioPagoActual
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxMedioPago, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .IDMedioPago, CByte(0))

            If mMedioPagoCurrent.UtilizaFechaHora Then
                datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaHora)
                datetimepickerHora.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaHora)
            Else
                datetimepickerFecha.Value = DateTime.Today
                datetimepickerHora.Value = DateTime.Now
            End If
            If mMedioPagoCurrent.UtilizaNumero Then
                textboxNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Numero)
            Else
                textboxNumero.Text = String.Empty
            End If
            If mMedioPagoCurrent.UtilizaBanco Then
                CardonerSistemas.ComboBox.SetSelectedValue(comboboxBanco, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .IDBanco, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            Else
                comboboxBanco.SelectedIndex = 0
            End If
            If mMedioPagoCurrent.UtilizaCuenta Then
                CardonerSistemas.ComboBox.SetSelectedValue(comboboxCuentaBancariaTipo, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .IDTipo, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
                maskedtextboxCuentaBancariaSucursal.Text = CS_ValueTranslation.FromObjectShortToControlTextBox(.Sucursal)
                textboxCuentaBancariaNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Cuenta)
                maskedtextboxCuentaBancariaCbu.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Cbu)
                textboxCuentaBancariaCbuAlias.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.CbuAlias)
            Else
                comboboxCuentaBancariaTipo.SelectedIndex = 0
                maskedtextboxCuentaBancariaSucursal.Text = String.Empty
                textboxCuentaBancariaNumero.Text = String.Empty
                maskedtextboxCuentaBancariaCbu.Text = String.Empty
                textboxCuentaBancariaCbuAlias.Text = String.Empty
            End If
            If mMedioPagoCurrent.UtilizaTitular Then
                textboxTitular.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Titular)
            Else
                textboxTitular.Text = String.Empty
            End If

            currencytextboxImporte.DecimalValue = .Importe
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mComprobanteMedioPagoActual
            .IDMedioPago = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxMedioPago.SelectedValue, 0).Value

            If mMedioPagoCurrent.UtilizaFechaHora Then
                .FechaHora = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFecha.Value.Date + datetimepickerHora.Value.TimeOfDay)
            Else
                .FechaHora = Nothing
            End If
            If mMedioPagoCurrent.UtilizaNumero Then
                .Numero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNumero.Text)
            Else
                .Numero = Nothing
            End If
            If mMedioPagoCurrent.UtilizaBanco Then
                .IDBanco = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxBanco.SelectedValue, 0)
            Else
                .IDBanco = Nothing
            End If
            If mMedioPagoCurrent.UtilizaCuenta Then
                .IDTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCuentaBancariaTipo.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
                .Sucursal = CS_ValueTranslation.FromControlTextBoxToObjectShort(maskedtextboxCuentaBancariaSucursal.Text)
                .Cuenta = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCuentaBancariaNumero.Text)
                .Cbu = CS_ValueTranslation.FromControlTextBoxToObjectString(maskedtextboxCuentaBancariaCbu.Text)
                .CbuAlias = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCuentaBancariaCbuAlias.Text)
                .Cuit = CS_ValueTranslation.FromControlTextBoxToObjectLong(maskedtextboxCuentaBancariaCuit.Text)
            Else
                .IDTipo = Nothing
                .Sucursal = Nothing
                .Cuenta = Nothing
                .Cbu = Nothing
                .CbuAlias = Nothing
                .Cuit = Nothing
            End If
            If mMedioPagoCurrent.UtilizaTitular Then
                .Titular = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxTitular.Text)
            Else
                .Titular = Nothing
            End If

            .Importe = currencytextboxImporte.DecimalValue
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

    Private Sub MedioPago_Selected() Handles comboboxMedioPago.SelectedValueChanged
        If comboboxMedioPago.SelectedIndex = -1 Then
            Exit Sub
        End If

        mMedioPagoCurrent = CType(comboboxMedioPago.SelectedItem, MedioPago)

        labelFechaHora.Visible = mMedioPagoCurrent.UtilizaFechaHora
        datetimepickerFecha.Visible = mMedioPagoCurrent.UtilizaFechaHora
        datetimepickerHora.Visible = mMedioPagoCurrent.UtilizaFechaHora

        labelNumero.Visible = mMedioPagoCurrent.UtilizaNumero
        textboxNumero.Visible = mMedioPagoCurrent.UtilizaNumero

        groupboxDatosBancarios.Visible = mMedioPagoCurrent.UtilizaCuenta

        labelBanco.Visible = mMedioPagoCurrent.UtilizaBanco
        comboboxBanco.Visible = mMedioPagoCurrent.UtilizaBanco

        labelCuentaBancariaTipo.Visible = mMedioPagoCurrent.UtilizaCuenta
        comboboxCuentaBancariaTipo.Visible = mMedioPagoCurrent.UtilizaCuenta

        labelCuentaBancariaSucursal.Visible = mMedioPagoCurrent.UtilizaCuenta
        maskedtextboxCuentaBancariaSucursal.Visible = mMedioPagoCurrent.UtilizaCuenta

        labelCuentaBancariaNumero.Visible = mMedioPagoCurrent.UtilizaCuenta
        textboxCuentaBancariaNumero.Visible = mMedioPagoCurrent.UtilizaCuenta

        labelCuentaBancariaCbu.Visible = mMedioPagoCurrent.UtilizaCuenta
        maskedtextboxCuentaBancariaCbu.Visible = mMedioPagoCurrent.UtilizaCuenta

        labelCuentaBancariaCbuAlias.Visible = mMedioPagoCurrent.UtilizaCuenta
        textboxCuentaBancariaCbuAlias.Visible = mMedioPagoCurrent.UtilizaCuenta

        labelCuentaBancariaCuit.Visible = mMedioPagoCurrent.UtilizaCuenta
        maskedtextboxCuentaBancariaCuit.Visible = mMedioPagoCurrent.UtilizaCuenta

        buttonCopiarDatosBancarios.Visible = mMedioPagoCurrent.UtilizaCuenta And mEditMode

        labelTitular.Visible = mMedioPagoCurrent.UtilizaTitular
        textboxTitular.Visible = mMedioPagoCurrent.UtilizaTitular

    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNumero.GotFocus, textboxCuentaBancariaNumero.GotFocus, textboxCuentaBancariaCbuAlias.GotFocus, textboxTitular.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub MaskedTextBoxs_GotFocus(sender As Object, e As EventArgs) Handles maskedtextboxCuentaBancariaSucursal.GotFocus, maskedtextboxCuentaBancariaCbu.GotFocus, maskedtextboxCuentaBancariaCuit.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
    End Sub

    Private Sub CopiarDatosBancarios(sender As Object, e As EventArgs) Handles buttonCopiarDatosBancarios.Click
        If mMedioPagoCurrent Is Nothing OrElse Not mMedioPagoCurrent.UtilizaCuenta Then
            Exit Sub
        End If
        If mComprobanteActual.IDEntidad > 0 Then
            Using context As New CSBomberosContext(True)
                Dim entidad As Entidad

                entidad = context.Entidad.Find(mComprobanteActual.IDEntidad)

                CardonerSistemas.ComboBox.SetSelectedValue(comboboxBanco, CardonerSistemas.ComboBox.SelectedItemOptions.Value, entidad.CuentaBancariaIDBanco, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
                CardonerSistemas.ComboBox.SetSelectedValue(comboboxCuentaBancariaTipo, CardonerSistemas.ComboBox.SelectedItemOptions.Value, entidad.CuentaBancariaIDTipo, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
                maskedtextboxCuentaBancariaSucursal.Text = CS_ValueTranslation.FromObjectShortToControlTextBox(entidad.CuentaBancariaSucursal)
                textboxCuentaBancariaNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(entidad.CuentaBancariaNumero)
                maskedtextboxCuentaBancariaCbu.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(entidad.CuentaBancariaCbu)
                textboxCuentaBancariaCbuAlias.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(entidad.CuentaBancariaCbuAlias)
                maskedtextboxCuentaBancariaCuit.Text = CS_ValueTranslation.FromObjectLongToControlTextBox(entidad.CuentaBancariaCuit)
                textboxTitular.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(entidad.CuentaBancariaTitular)

                entidad = Nothing
            End Using
        End If
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        mEditMode = True
        ChangeMode()
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If Not VerificarDatos() Then
            Return
        End If

        ' Si es un nuevo item, busco el próximo Indice y agrego el objeto nuevo a la colección del parent
        If mComprobanteMedioPagoActual.Indice = 0 Then
            If mComprobanteActual.ComprobanteMediosPago.Count = 0 Then
                mComprobanteMedioPagoActual.Indice = 1
            Else
                mComprobanteMedioPagoActual.Indice = mComprobanteActual.ComprobanteMediosPago.Max(Function(cmp) cmp.Indice) + CByte(1)
            End If
            mComprobanteActual.ComprobanteMediosPago.Add(mComprobanteMedioPagoActual)
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Refresco la lista para mostrar los cambios
        If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formComprobante") Then
            Dim formComprobante As formComprobante = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formComprobante"), formComprobante)
            formComprobante.RefreshDataMediosPago(mComprobanteMedioPagoActual.Indice)
            formComprobante = Nothing
        End If

        Me.Close()
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        If comboboxMedioPago.SelectedIndex = -1 Then
            MsgBox("Debe especificar el Medio de Pago.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxMedioPago.Focus()
            Return False
        End If
        If currencytextboxImporte.DecimalValue <= 0 Then
            MsgBox("El Importe debe ser mayor a cero.", MsgBoxStyle.Information, My.Application.Info.Title)
            currencytextboxImporte.Focus()
            Return False
        End If

        ' Datos bancarios - CBU
        If maskedtextboxCuentaBancariaCbu.Visible AndAlso maskedtextboxCuentaBancariaCbu.Text.Length > 0 Then
            If maskedtextboxCuentaBancariaCbu.Text.Length < 22 Then
                MessageBox.Show("Debe especificar los 22 dígitos del CBU.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                maskedtextboxCuentaBancariaCbu.Focus()
                Return False
            End If
            Select Case CardonerSistemas.Bank.VerificarCBU(maskedtextboxCuentaBancariaCbu.Text)
                Case 0
                    MessageBox.Show("El CBU ingresado es incorrecto.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    maskedtextboxCuentaBancariaCbu.Focus()
                    Return False
                Case 1
                    MessageBox.Show("El CBU ingresado tiene un error en el 1er. bloque.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    maskedtextboxCuentaBancariaCbu.Focus()
                    Return False
                Case 2
                    MessageBox.Show("El CBU ingresado tiene un error en el 2do. bloque.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    maskedtextboxCuentaBancariaCbu.Focus()
                    Return False
            End Select
        End If

        ' Datos bancarios - CUIT
        If maskedtextboxCuentaBancariaCuit.Visible AndAlso maskedtextboxCuentaBancariaCuit.Text.Length > 0 Then
            If maskedtextboxCuentaBancariaCuit.Text.Trim.Length < 11 Then
                MsgBox("El CUIT de la cuenta bancaria debe contener 11 dígitos (sin contar los guiones).", MsgBoxStyle.Information, My.Application.Info.Title)
                maskedtextboxCuentaBancariaCuit.Focus()
                Return False
            End If
            If Not CardonerSistemas.Afip.VerificarCuit(maskedtextboxCuentaBancariaCuit.Text) Then
                MsgBox("El CUIT de la cuenta bancaria ingresado es incorrecto.", MsgBoxStyle.Information, My.Application.Info.Title)
                maskedtextboxCuentaBancariaCuit.Focus()
                Return False
            End If
        End If

        Return True
    End Function

#End Region

End Class