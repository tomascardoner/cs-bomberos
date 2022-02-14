Public Class formReportesParametroComboBoxSimple
    Private mParametroActual As ReporteParametro

    Friend Sub SetAppearance(ByRef ParametroActual As ReporteParametro, ByVal Title As String)
        mParametroActual = ParametroActual

        labelValor.Text = ParametroActual.Nombre & ":"

        Select Case mParametroActual.Tipo
            Case Reportes.REPORTE_PARAMETRO_TIPO_CUARTEL
                Using context As New CSBomberosContext(True)
                    ListasComun.LlenarComboBoxCuarteles(context, comboboxValor, False, False)
                End Using
                If Not mParametroActual.Valor Is Nothing Then
                    CardonerSistemas.ComboBox.SetSelectedValue(comboboxValor, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Reportes.REPORTE_PARAMETRO_TIPO_CARGO
                pFillAndRefreshLists.Cargo(comboboxValor, False, False)
                If Not mParametroActual.Valor Is Nothing Then
                    CardonerSistemas.ComboBox.SetSelectedValue(comboboxValor, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Reportes.REPORTE_PARAMETRO_TIPO_PERSONABAJAMOTIVO
                pFillAndRefreshLists.PersonaBajaMotivo(comboboxValor, False, False)
                If Not mParametroActual.Valor Is Nothing Then
                    CardonerSistemas.ComboBox.SetSelectedValue(comboboxValor, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Reportes.REPORTE_PARAMETRO_TIPO_UNIDAD
                pFillAndRefreshLists.Unidad(comboboxValor, False, False)
                If Not mParametroActual.Valor Is Nothing Then
                    CardonerSistemas.ComboBox.SetSelectedValue(comboboxValor, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Reportes.REPORTE_PARAMETRO_TIPO_RESPONSABLE
                pFillAndRefreshLists.Responsable(comboboxValor, "ResponsableTipoNombre", False, False)
                If Not mParametroActual.Valor Is Nothing Then
                    CardonerSistemas.ComboBox.SetSelectedValue(comboboxValor, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
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