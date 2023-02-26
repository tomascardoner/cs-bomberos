Public Class formReportesParametroSiNo
    Private mParametroActual As ReporteParametro

    Friend Sub SetAppearance(ByRef ParametroActual As ReporteParametro, ByVal Title As String)
        mParametroActual = ParametroActual

        labelValor.Text = ParametroActual.Nombre & ":"

        radiobuttonSi.Visible = (mParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_SINO Or mParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_FILTER_TEXT_SHOW)
        radiobuttonSi.Text = My.Resources.STRING_YES
        radiobuttonNo.Visible = (mParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_SINO Or mParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_FILTER_TEXT_SHOW)
        radiobuttonNo.Text = My.Resources.STRING_NO

        If mParametroActual.Valor IsNot Nothing Then
            radiobuttonSi.Checked = CBool(mParametroActual.Valor)
            radiobuttonNo.Checked = Not CBool(mParametroActual.Valor)
        End If
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
        If radiobuttonSi.Checked = False And radiobuttonNo.Checked = False Then
            MsgBox("Debe especificar un valor.", MsgBoxStyle.Information, My.Application.Info.Title)
            Exit Sub
        End If
        mParametroActual.Valor = radiobuttonSi.Checked

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Cancelar(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mParametroActual = Nothing
    End Sub
End Class