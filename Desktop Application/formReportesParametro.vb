Public Class formReportesParametro
    Private mParametroActual As ReporteParametro

    Friend Sub SetAppearance(ByRef ParametroActual As ReporteParametro, ByVal Title As String)
        mParametroActual = ParametroActual

        ' Set appearance
        labelValor.Text = ParametroActual.Nombre & ":"

        textboxMoney.Visible = (mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_MONEY)
        textboxNumber.Visible = (mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL)
        datetimepickerValor.Visible = (mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_DATE Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_DATETIME)
        comboboxValor.Visible = (mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_CUARTEL Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_CARGO Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_JERARQUIA Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_PERSONABAJAMOTIVO Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_AUTOMOTOR)
        radiobuttonSi.Visible = (mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_SINO Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_FILTER_TEXT_SHOW)
        radiobuttonSi.Text = My.Resources.STRING_YES
        radiobuttonNo.Visible = (mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_SINO Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_FILTER_TEXT_SHOW)
        radiobuttonNo.Text = My.Resources.STRING_NO

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
            Case Constantes.REPORTE_PARAMETRO_TIPO_SINO, Constantes.REPORTE_PARAMETRO_TIPO_FILTER_TEXT_SHOW
                If Not mParametroActual.Valor Is Nothing Then
                    radiobuttonSi.Checked = CBool(mParametroActual.Valor)
                    radiobuttonNo.Checked = Not CBool(mParametroActual.Valor)
                End If
            Case Constantes.REPORTE_PARAMETRO_TIPO_CUARTEL
                pFillAndRefreshLists.Cuartel(comboboxValor, False, False)
                If Not mParametroActual.Valor Is Nothing Then
                    CS_ComboBox.SetSelectedValue(comboboxValor, SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Constantes.REPORTE_PARAMETRO_TIPO_CARGO
                pFillAndRefreshLists.Cargo(comboboxValor, False, False)
                If Not mParametroActual.Valor Is Nothing Then
                    CS_ComboBox.SetSelectedValue(comboboxValor, SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Constantes.REPORTE_PARAMETRO_TIPO_JERARQUIA
                pFillAndRefreshLists.CargoJerarquia(comboboxValor, False, False, CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
                If Not mParametroActual.Valor Is Nothing Then
                    CS_ComboBox.SetSelectedValue(comboboxValor, SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Constantes.REPORTE_PARAMETRO_TIPO_PERSONABAJAMOTIVO
                pFillAndRefreshLists.PersonaBajaMotivo(comboboxValor, False, False)
                If Not mParametroActual.Valor Is Nothing Then
                    CS_ComboBox.SetSelectedValue(comboboxValor, SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Constantes.REPORTE_PARAMETRO_TIPO_AUTOMOTOR
                pFillAndRefreshLists.Automotor(comboboxValor, False, False)
                If Not mParametroActual.Valor Is Nothing Then
                    CS_ComboBox.SetSelectedValue(comboboxValor, SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
        End Select
    End Sub

    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                buttonAceptar.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                buttonCancelar.PerformClick()
        End Select
    End Sub

    Private Sub buttonAceptar_Click(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        Select Case mParametroActual.Tipo
            Case Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER, Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL
                mParametroActual.Valor = textboxNumber.Value
            Case Constantes.REPORTE_PARAMETRO_TIPO_MONEY
                mParametroActual.Valor = textboxMoney.Value
            Case Constantes.REPORTE_PARAMETRO_TIPO_SINO, Constantes.REPORTE_PARAMETRO_TIPO_FILTER_TEXT_SHOW
                If radiobuttonSi.Checked = False And radiobuttonNo.Checked = False Then
                    MsgBox("Debe especificar un valor.", MsgBoxStyle.Information, My.Application.Info.Title)
                    Exit Sub
                End If
                mParametroActual.Valor = radiobuttonSi.Checked
            Case Constantes.REPORTE_PARAMETRO_TIPO_DATE
                mParametroActual.Valor = datetimepickerValor.Value
            Case Constantes.REPORTE_PARAMETRO_TIPO_CUARTEL, Constantes.REPORTE_PARAMETRO_TIPO_CARGO, Constantes.REPORTE_PARAMETRO_TIPO_JERARQUIA, Constantes.REPORTE_PARAMETRO_TIPO_PERSONABAJAMOTIVO, Constantes.REPORTE_PARAMETRO_TIPO_AUTOMOTOR
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