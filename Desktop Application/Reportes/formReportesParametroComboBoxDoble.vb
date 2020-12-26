Public Class formReportesParametroComboBoxDoble
    Private mParametroPadre As ReporteParametro
    Private mParametroActual As ReporteParametro

    Friend Sub SetAppearance(ByRef ParametroPadre As ReporteParametro, ByRef ParametroActual As ReporteParametro, ByVal Title As String)
        mParametroPadre = ParametroPadre
        mParametroActual = ParametroActual

        labelPadreValor.Text = mParametroPadre.Nombre & ":"
        labelValor.Text = ParametroActual.Nombre & ":"

        Select Case mParametroActual.Tipo
            Case Reportes.REPORTE_PARAMETRO_TIPO_JERARQUIA
                pFillAndRefreshLists.Cargo(comboboxPadreValor, False, False)
                If Not mParametroPadre.Valor Is Nothing Then
                    CardonerSistemas.ComboBox.SetSelectedValue(comboboxPadreValor, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mParametroPadre.Valor)
                End If
            Case Reportes.REPORTE_PARAMETRO_TIPO_AREA, Reportes.REPORTE_PARAMETRO_TIPO_UBICACION
                pFillAndRefreshLists.Cuartel(comboboxPadreValor, False, False)
                If Not mParametroPadre.Valor Is Nothing Then
                    CardonerSistemas.ComboBox.SetSelectedValue(comboboxPadreValor, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mParametroPadre.Valor)
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

    Private Sub ComboPadreCambio(sender As Object, e As EventArgs) Handles comboboxPadreValor.SelectedIndexChanged
        If comboboxPadreValor.SelectedIndex = -1 Then
            comboboxValor.DataSource = Nothing
        End If
        Select Case mParametroActual.Tipo
            Case Reportes.REPORTE_PARAMETRO_TIPO_JERARQUIA
                pFillAndRefreshLists.CargoJerarquia(comboboxValor, False, False, Convert.ToByte(comboboxPadreValor.SelectedValue))
                If Not mParametroActual.Valor Is Nothing Then
                    CardonerSistemas.ComboBox.SetSelectedValue(comboboxValor, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Reportes.REPORTE_PARAMETRO_TIPO_AREA
                pFillAndRefreshLists.Area(comboboxValor, False, False, Convert.ToByte(comboboxPadreValor.SelectedValue))
                If Not mParametroActual.Valor Is Nothing Then
                    CardonerSistemas.ComboBox.SetSelectedValue(comboboxValor, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Reportes.REPORTE_PARAMETRO_TIPO_UBICACION
                pFillAndRefreshLists.Ubicacion(comboboxValor, False, False, Convert.ToByte(comboboxPadreValor.SelectedValue))
                If Not mParametroActual.Valor Is Nothing Then
                    CardonerSistemas.ComboBox.SetSelectedValue(comboboxValor, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
        End Select
    End Sub

    Private Sub Aceptar(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        mParametroPadre.Valor = comboboxPadreValor.SelectedValue
        mParametroPadre.ValorParaMostrar = comboboxPadreValor.Text
        mParametroActual.Valor = comboboxValor.SelectedValue
        mParametroActual.ValorParaMostrar = comboboxValor.Text

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Cancelar(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mParametroPadre = Nothing
        mParametroActual = Nothing
    End Sub
End Class