Public Class formCheque

#Region "Declarations"

    Private mdbContext As CSBomberosContext
    Private mComprobanteActual As Comprobante
    Private mComprobanteMedioPagoActual As ComprobanteMedioPago

    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal parentEditMode As Boolean, ByVal EditMode As Boolean, ByRef ParentForm As Form, ByRef dbContext As CSBomberosContext, ByRef ComprobanteActual As Comprobante, ByRef ComprobanteMedioPagoActual As ComprobanteMedioPago)
        mEditMode = EditMode

        mdbContext = dbContext
        mComprobanteActual = ComprobanteActual
        mComprobanteMedioPagoActual = ComprobanteMedioPagoActual

        'Me.MdiParent = pFormMDIMain
        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()
        ChangeMode()

        Me.ShowDialog(ParentForm)
        'If Me.WindowState = FormWindowState.Minimized Then
        '    Me.WindowState = FormWindowState.Normal
        'End If
        'Me.Focus()
    End Sub

    Private Sub ChangeMode()
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = Not mEditMode
        buttonCerrar.Visible = Not mEditMode

        labelEstado.Visible = False
        textboxEstado.Visible = False
        labelMotivoRechazo.Visible = False
        comboboxMotivoRechazo.Visible = False

        CardonerSistemas.Forms.ControlsChangeStateEnabled(Me.Controls, mEditMode, True, True, True, toolstripMain.Name)
    End Sub

    Friend Sub InitializeFormAndControls()
        ' Cargo los ComboBox
        ListasComprobantes.LlenarComboBoxMediosPago(mdbContext, comboboxMedioPago, False, True, False, False)
        ListasComprobantes.LlenarComboBoxBancos(mdbContext, comboboxBanco, False, True)
        ListasComprobantes.LlenarComboBoxChequesMotivosRechazo(mdbContext, comboboxMotivoRechazo, True, False, True)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mComprobanteActual = Nothing
        mComprobanteMedioPagoActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mComprobanteMedioPagoActual
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxMedioPago, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDMedioPago, CByte(0))
        End With
        With mComprobanteMedioPagoActual.Cheque
            If .IDCheque = 0 Then
                textboxIDCheque.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDCheque.Text = String.Format(.IDCheque.ToString, "G")
            End If
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxBanco, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .IDBanco, CShort(0))
            datetimepickerFechaEmision.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaEmision)
            datetimepickerFechaPago.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaPago)
            MaskedTextBoxNumero.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.Numero)
            currencytextboxImporte.DecimalValue = .Importe
            MaskedTextBoxCuenta.Text = CS_ValueTranslation.FromObjectLongToControlTextBox(.Cuenta)
            maskedtextboxCUIT.Text = CS_ValueTranslation.FromObjectLongToControlTextBox(.Cuit)
            textboxTitular.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Titular)
            MaskedTextBoxCodigoPostal.Text = CS_ValueTranslation.FromObjectShortToControlTextBox(.CodigoPostal)

            'textboxEstado.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Estado)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxMotivoRechazo, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .IDChequeMotivoRechazo, CShort(0))
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mComprobanteMedioPagoActual
            .IDMedioPago = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxMedioPago.SelectedValue, 0).Value
            .Numero = CS_ValueTranslation.FromControlTextBoxToObjectString(MaskedTextBoxNumero.Text)
            .IDBanco = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxBanco.SelectedValue, 0).Value
            .Cuenta = CS_ValueTranslation.FromControlTextBoxToObjectString(MaskedTextBoxCuenta.Text)
            .Titular = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxTitular.Text)
            .Importe = currencytextboxImporte.DecimalValue
        End With
        With mComprobanteMedioPagoActual.Cheque
            .IDBanco = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxBanco.SelectedValue, 0).Value
            .FechaEmision = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaEmision.Value)
            .FechaPago = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaPago.Value)
            .Numero = CS_ValueTranslation.FromControlTextBoxToObjectInteger(MaskedTextBoxNumero.Text)
            .Importe = currencytextboxImporte.DecimalValue
            .Cuenta = CS_ValueTranslation.FromControlTextBoxToObjectLong(MaskedTextBoxCuenta.Text)
            .Cuit = CS_ValueTranslation.FromControlTextBoxToObjectLong(maskedtextboxCUIT.Text)
            .Titular = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxTitular.Text)
            .CodigoPostal = CS_ValueTranslation.FromControlTextBoxToObjectShort(MaskedTextBoxCodigoPostal.Text)

            '.Estado= CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCuenta.Text)
            '.IDChequeMotivoRechazo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxMotivoRechazo.SelectedValue, 0).Value
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs)
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub Editar() Handles buttonEditar.Click
        mEditMode = True
        ChangeMode()
    End Sub

    Private Sub CerrarOCancelar() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub Guardar() Handles buttonGuardar.Click
        If comboboxBanco.SelectedIndex = -1 Then
            MsgBox("Debe especificar el Banco.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxBanco.Focus()
            Exit Sub
        End If

        If datetimepickerFechaPago.Value.CompareTo(datetimepickerFechaEmision.Value) < 0 Then
            MsgBox("La Fecha de Pago, debe ser posterior o igual a la Fecha de Emisión.", MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerFechaPago.Focus()
            Exit Sub
        End If

        If currencytextboxImporte.DecimalValue = 0 Then
            MsgBox("Debe ingresar el Importe del Cheque.", MsgBoxStyle.Information, My.Application.Info.Title)
            currencytextboxImporte.Focus()
            Exit Sub
        End If

        ' Si es un nuevo cheque...
        If mComprobanteMedioPagoActual.Cheque.IDCheque = 0 Then
            Dim IDChequeMaxEnObjeto As Integer
            Dim IDChequeMaxEnBaseDatos As Integer

            mComprobanteMedioPagoActual.Cheque.Estado = Constantes.ChequeEstadoEnCartera
            ' Obtengo el máximo ID en la base de datos
            If mdbContext.Cheque.Count = 0 Then
                ' No hay ningún cheque cargado aún en la base de datos
                IDChequeMaxEnBaseDatos = 0
            Else
                ' Hay cheques en la base de datos
                IDChequeMaxEnBaseDatos = mdbContext.Cheque.Max(Function(chq) chq.IDCheque)
            End If
            ' Obtengo el máximo ID en los Medios de Pago del Comprobante actual
            If mComprobanteActual.ComprobanteMediosPago.Where(Function(cmp) cmp.IDCheque.HasValue).Count = 0 Then
                ' No hay ningún cheque cargado en los Medios de Pago del Comprobante actual
                IDChequeMaxEnObjeto = 0
            Else
                ' Ya hay algún cheque cargado en los Medios de Pago del Comprobante actual
                IDChequeMaxEnObjeto = mComprobanteActual.ComprobanteMediosPago.Where(Function(cmp) cmp.IDCheque.HasValue).Max(Function(cmp) cmp.Cheque.IDCheque)
            End If
            ' Asigno el ID que corresponda
            If IDChequeMaxEnObjeto > IDChequeMaxEnBaseDatos Then
                mComprobanteMedioPagoActual.Cheque.IDCheque = IDChequeMaxEnObjeto + CInt(1)
            Else
                mComprobanteMedioPagoActual.Cheque.IDCheque = IDChequeMaxEnBaseDatos + CInt(1)
            End If
            mComprobanteMedioPagoActual.IDCheque = mComprobanteMedioPagoActual.Cheque.IDCheque
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

End Class