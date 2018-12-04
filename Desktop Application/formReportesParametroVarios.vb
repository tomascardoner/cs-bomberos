Public Class formReportesParametroVarios
    Private mParametroActual As ReporteParametro

    Friend Sub SetAppearance(ByRef ParametroActual As ReporteParametro, ByVal Title As String)
        mParametroActual = ParametroActual

        labelValor.Text = mParametroActual.Nombre & ":"

        textboxMoney.Visible = (mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_MONEY)
        textboxNumber.Visible = (mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL)
        datetimepickerValor.Visible = (mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_DATE Or mParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_DATETIME)

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
            Case Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER, Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL
                mParametroActual.Valor = textboxNumber.Value
            Case Constantes.REPORTE_PARAMETRO_TIPO_MONEY
                mParametroActual.Valor = textboxMoney.Value
            Case Constantes.REPORTE_PARAMETRO_TIPO_DATE
                mParametroActual.Valor = datetimepickerValor.Value
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