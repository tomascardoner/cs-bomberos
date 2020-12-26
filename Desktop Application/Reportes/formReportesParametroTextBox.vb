Public Class formReportesParametroTextBox
    Private mParametroActual As ReporteParametro

    Friend Sub SetAppearance(ByRef ParametroActual As ReporteParametro, ByVal Title As String)
        mParametroActual = ParametroActual

        labelValor.Text = mParametroActual.Nombre & ":"

        Select Case mParametroActual.Tipo
            Case Reportes.REPORTE_PARAMETRO_TIPO_TITLE
                textboxText.MaxLength = 100
                If Not mParametroActual.Valor Is Nothing Then
                    textboxText.Text = CStr(mParametroActual.Valor)
                End If
            Case Reportes.REPORTE_PARAMETRO_TIPO_TEXT
                textboxText.MaxLength = 32767
                If Not mParametroActual.Valor Is Nothing Then
                    textboxText.Text = CStr(mParametroActual.Valor)
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
            Case Reportes.REPORTE_PARAMETRO_TIPO_TITLE, Reportes.REPORTE_PARAMETRO_TIPO_TEXT
                mParametroActual.Valor = textboxText.Text.Trim()
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