Public Class formReportesParametro
    Private mParametroActual As ReporteParametro

    Friend Sub SetAppearance(ByRef ParametroActual As ReporteParametro, ByVal Title As String)
        labelValor.Text = ParametroActual.Nombre & ":"

        mParametroActual = ParametroActual

        textboxMoney.Visible = (mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_MONEY)
        datetimepickerValor.Visible = (mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_DATE Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_DATETIME)
        comboboxValor.Visible = (mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_CUARTEL Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_CARGO Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_JERARQUIA Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_ESTADO Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_PERSONABAJAMOTIVO)

        Select Case mParametroActual.Tipo
            Case Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER, Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL
                If Not mParametroActual.Valor Is Nothing Then
                    textboxNumber.Text = CStr(mParametroActual.Valor)
                End If
            Case Constantes.REPORTE_PARAMETRO_TIPO_MONEY
                If Not mParametroActual.Valor Is Nothing Then
                    textboxMoney.Text = CStr(mParametroActual.Valor)
                End If
            Case Constantes.REPORTE_PARAMETRO_TIPO_DATE
                If Not mParametroActual.Valor Is Nothing Then
                    datetimepickerValor.Value = CDate(mParametroActual.Valor)
                End If
            Case Constantes.REPORTE_PARAMETRO_CUARTEL
                pFillAndRefreshLists.Cuartel(comboboxValor, False, False)
                If Not mParametroActual.Valor Is Nothing Then
                    CS_ComboBox.SetSelectedValue(comboboxValor, SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Constantes.REPORTE_PARAMETRO_CARGO
                pFillAndRefreshLists.Cargo(comboboxValor, False, False)
                If Not mParametroActual.Valor Is Nothing Then
                    CS_ComboBox.SetSelectedValue(comboboxValor, SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Constantes.REPORTE_PARAMETRO_JERARQUIA
                pFillAndRefreshLists.CargoJerarquia(comboboxValor, False, False, CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
                If Not mParametroActual.Valor Is Nothing Then
                    CS_ComboBox.SetSelectedValue(comboboxValor, SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Constantes.REPORTE_PARAMETRO_ESTADO
                'pFillAndRefreshLists.esta(comboboxValor, False, False, CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
                'If Not mParametroActual.Valor Is Nothing Then
                '    CS_ComboBox.SetSelectedValue(comboboxValor, SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                'End If
            Case Constantes.REPORTE_PARAMETRO_PERSONABAJAMOTIVO
                pFillAndRefreshLists.PersonaBajaMotivo(comboboxValor, False, False)
                If Not mParametroActual.Valor Is Nothing Then
                    CS_ComboBox.SetSelectedValue(comboboxValor, SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
        End Select
    End Sub

    Private Sub buttonAceptar_Click(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        Select Case mParametroActual.Tipo
            Case Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER, Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL
                mParametroActual.Valor = textboxNumber.Value
            Case Constantes.REPORTE_PARAMETRO_TIPO_MONEY
                mParametroActual.Valor = textboxMoney.Value
            Case Constantes.REPORTE_PARAMETRO_TIPO_DATE
                mParametroActual.Valor = datetimepickerValor.Value
            Case Constantes.REPORTE_PARAMETRO_CUARTEL, REPORTE_PARAMETRO_CARGO, REPORTE_PARAMETRO_JERARQUIA, REPORTE_PARAMETRO_ESTADO, REPORTE_PARAMETRO_PERSONABAJAMOTIVO
                mParametroActual.Valor = comboboxValor.SelectedValue
                mParametroActual.ValorParaMostrar = comboboxValor.Text
        End Select

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub buttonCancelar_Click(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub formReportesParametro_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mParametroActual = Nothing
    End Sub
End Class