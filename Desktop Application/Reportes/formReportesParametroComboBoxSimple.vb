Public Class formReportesParametroComboBoxSimple
    Private mParametroActual As ReporteParametro

    Friend Sub SetAppearance(ByRef ParametroActual As ReporteParametro, ByVal Title As String)
        mParametroActual = ParametroActual

        labelValor.Text = ParametroActual.Nombre & ":"

        Using context As New CSBomberosContext(True)
            Select Case mParametroActual.Tipo
                Case Reportes.REPORTE_PARAMETRO_TIPO_CUARTEL
                    ListasComun.LlenarComboBoxCuarteles(context, comboboxValor, False, False)
                Case Reportes.REPORTE_PARAMETRO_TIPO_CARGO
                    pFillAndRefreshLists.Cargo(comboboxValor, False, False)
                Case Reportes.REPORTE_PARAMETRO_TIPO_PERSONABAJAMOTIVO
                    pFillAndRefreshLists.PersonaBajaMotivo(comboboxValor, False, False)
                Case Reportes.REPORTE_PARAMETRO_TIPO_UNIDAD
                    pFillAndRefreshLists.Unidad(comboboxValor, False, False)
                Case Reportes.REPORTE_PARAMETRO_TIPO_RESPONSABLE
                    ListasComun.LlenarComboBoxResponsables(context, comboboxValor, False, False)
                Case Reportes.REPORTE_PARAMETRO_TIPO_ENTIDAD
                    ListasComprobantes.LlenarComboBoxEntidades(context, comboboxValor, Nothing, False, False)
            End Select
            If mParametroActual.Valor IsNot Nothing Then
                CardonerSistemas.ComboBox.SetSelectedValue(comboboxValor, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
            End If
        End Using
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
        mParametroActual.Valor = comboboxValor.SelectedValue
        mParametroActual.ValorParaMostrar = comboboxValor.Text

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Cancelar(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mParametroActual = Nothing
    End Sub
End Class