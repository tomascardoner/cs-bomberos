Public Class formCajaArqueoDetalle

#Region "Declarations"

    Private mParentForm As Form
    Private mdbContext As New CSBomberosContext(True)
    Private mCajaArqueoActual As CajaArqueo
    Private mCajaArqueoDetalleActual As CajaArqueoDetalle

    Private mIsLoading As Boolean
    Private mParentEditMode As Boolean
    Private mEditMode As Boolean
    Private mIsNew As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal ParentEditMode As Boolean, ByVal EditMode As Boolean, ByRef ParentForm As Form, ByRef CajaArqueoActual As CajaArqueo, ByVal IDDetalle As Short)
        mParentForm = ParentForm
        mIsLoading = True
        mParentEditMode = ParentEditMode
        mEditMode = EditMode
        mIsNew = (IDDetalle = 0)

        mCajaArqueoActual = CajaArqueoActual
        If mIsNew Then
            ' Es Nuevo
            mCajaArqueoDetalleActual = New CajaArqueoDetalle With {.Fecha = Date.Today}
            mCajaArqueoActual.CajaArqueoDetalles.Add(mCajaArqueoDetalleActual)
        Else
            mCajaArqueoDetalleActual = mCajaArqueoActual.CajaArqueoDetalles.Single(Function(cad) cad.IDDetalle = IDDetalle)
        End If

        CardonerSistemas.Forms.CenterToParent(mParentForm, Me)
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
        buttonEditar.Visible = (mParentEditMode And Not mEditMode)
        buttonCerrar.Visible = Not mEditMode

        ' General
        textboxNumeroComprobante.ReadOnly = Not mEditMode
        datetimepickerFecha.Enabled = mEditMode
        textboxProveedor.ReadOnly = Not mEditMode
        comboboxArea.Enabled = mEditMode
        textboxDetalle.ReadOnly = Not mEditMode
        currencytextboxImporte.ReadOnly = Not mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        ListasComunes.LlenarComboBoxAreas(mdbContext, comboboxArea, False, False, , , True)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mParentForm = Nothing
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mCajaArqueoActual = Nothing
        mCajaArqueoDetalleActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mCajaArqueoDetalleActual
            ' Datos de la pestaña General
            textboxNumeroComprobante.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.NumeroComprobante)
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.Fecha)
            textboxProveedor.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Proveedor)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxArea, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDArea)
            textboxDetalle.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Detalle)
            CS_ValueTranslation_Syncfusion.FromValueDecimalToControlCurrencyTextBox(.Importe, currencytextboxImporte)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .IDDetalle = 0 Then
                textboxID.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxID.Text = String.Format(.IDDetalle.ToString, "G")
            End If
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mCajaArqueoDetalleActual
            ' Datos de la pestaña General
            .NumeroComprobante = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNumeroComprobante.Text)
            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFecha.Value).Value
            .Proveedor = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxProveedor.Text)
            .IDArea = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxArea.SelectedValue).Value
            .Detalle = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDetalle.Text)
            .Importe = CS_ValueTranslation_Syncfusion.FromControlCurrencyTextBoxToObjectDecimal(currencytextboxImporte).Value

            ' Datos de la pestaña Notas y Auditoría
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNumeroComprobante.GotFocus, textboxProveedor.GotFocus, textboxDetalle.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
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
        If comboboxArea.SelectedItem Is Nothing Then
            MsgBox("Debe especificar el área.", CType(MessageBoxButtons.OK + MessageBoxIcon.Information, MsgBoxStyle), My.Application.Info.Title)
            comboboxArea.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mIsNew Then
            If mCajaArqueoActual.CajaArqueoDetalles.Any() Then
                mCajaArqueoDetalleActual.IDDetalle = mCajaArqueoActual.CajaArqueoDetalles.Max(Function(cad) cad.IDDetalle) + CShort(1)
            Else
                mCajaArqueoDetalleActual.IDDetalle = 1
            End If
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Refresco la lista para mostrar los cambios
        CType(mParentForm, formCajaArqueo).DetallesRefreshData(mCajaArqueoDetalleActual.IDDetalle)

        Me.Close()
    End Sub

#End Region

End Class