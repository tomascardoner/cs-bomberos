Public Class formReportesParametroVarios
    Private mParametroActual As ReporteParametro

    Friend Sub SetAppearance(ByRef ParametroActual As ReporteParametro, ByVal Title As String)
        mParametroActual = ParametroActual

        labelValor.Text = mParametroActual.Nombre & ":"

        doubletextboxValor.Visible = (mParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL Or mParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL)
        currencytextboxValor.Visible = (mParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_MONEY)
        datetimepickerValorFecha.Visible = (mParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_DATE Or mParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_DATETIME)
        datetimepickerValorHora.Visible = (mParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_TIME)
        comboboxValor.Visible = (mParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_YEAR)

        Select Case mParametroActual.Tipo
            Case Reportes.REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER, Reportes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL
                If Not mParametroActual.Valor Is Nothing Then
                    doubletextboxValor.Text = Convert.ToString(mParametroActual.Valor)
                End If
            Case Reportes.REPORTE_PARAMETRO_TIPO_MONEY
                If Not mParametroActual.Valor Is Nothing Then
                    currencytextboxValor.Text = Convert.ToString(mParametroActual.Valor)
                End If
            Case Reportes.REPORTE_PARAMETRO_TIPO_DATE
                If Not mParametroActual.Valor Is Nothing Then
                    datetimepickerValorFecha.Value = Convert.ToDateTime(mParametroActual.Valor)
                End If
            Case Reportes.REPORTE_PARAMETRO_TIPO_TIME
                If Not mParametroActual.Valor Is Nothing Then
                    datetimepickerValorHora.Value = Convert.ToDateTime(mParametroActual.Valor)
                End If
            Case Reportes.REPORTE_PARAMETRO_TIPO_YEAR
                pFillAndRefreshLists.Anio(comboboxValor, False, False)
                If Not mParametroActual.Valor Is Nothing Then
                    comboboxValor.Text = mParametroActual.Valor.ToString()
                End If
        End Select
    End Sub

    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                buttonAceptar.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                buttonCancelar.PerformClick()
        End Select
    End Sub

    Private Sub Aceptar(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        Select Case mParametroActual.Tipo
            Case Reportes.REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER, Reportes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL
                mParametroActual.Valor = doubletextboxValor.DoubleValue
            Case Reportes.REPORTE_PARAMETRO_TIPO_MONEY
                mParametroActual.Valor = currencytextboxValor.DecimalValue
            Case Reportes.REPORTE_PARAMETRO_TIPO_DATE
                mParametroActual.Valor = datetimepickerValorFecha.Value
            Case Reportes.REPORTE_PARAMETRO_TIPO_TIME
                mParametroActual.Valor = datetimepickerValorHora.Value
            Case Reportes.REPORTE_PARAMETRO_TIPO_YEAR
                If comboboxValor.SelectedIndex = -1 Then
                    MsgBox("Debe seleccionar un valor.", MsgBoxStyle.Information, My.Application.Info.Title)
                    comboboxValor.Focus()
                    Exit Sub
                End If
                mParametroActual.Valor = comboboxValor.Text
        End Select

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Cancelar(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mParametroActual = Nothing
    End Sub
End Class