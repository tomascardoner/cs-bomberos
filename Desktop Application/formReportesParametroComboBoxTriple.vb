Public Class formReportesParametroComboBoxTriple
    Private mParametroAbuelo As ReporteParametro
    Private mParametroPadre As ReporteParametro
    Private mParametroActual As ReporteParametro

    Friend Sub SetAppearance(ByRef ParametroAbuelo As ReporteParametro, ByRef ParametroPadre As ReporteParametro, ByRef ParametroActual As ReporteParametro, ByVal Title As String)
        mParametroAbuelo = ParametroAbuelo
        mParametroPadre = ParametroPadre
        mParametroActual = ParametroActual

        labelAbueloValor.Text = mParametroAbuelo.Nombre & ":"
        labelPadreValor.Text = mParametroPadre.Nombre & ":"
        labelValor.Text = ParametroActual.Nombre & ":"

        Select Case mParametroActual.Tipo
            Case Constantes.REPORTE_PARAMETRO_TIPO_SUBUBICACION
                pFillAndRefreshLists.Cuartel(comboboxAbueloValor, False, False)
                If Not mParametroAbuelo.Valor Is Nothing Then
                    CS_ComboBox.SetSelectedValue(comboboxAbueloValor, SelectedItemOptions.ValueOrFirstIfUnique, mParametroAbuelo.Valor)
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

    Private Sub ComboAbueloCambio(sender As Object, e As EventArgs) Handles comboboxAbueloValor.SelectedIndexChanged
        If comboboxAbueloValor.SelectedIndex = -1 Then
            comboboxPadreValor.DataSource = Nothing
            comboboxValor.DataSource = Nothing
        End If
        Select Case mParametroActual.Tipo
            Case Constantes.REPORTE_PARAMETRO_TIPO_SUBUBICACION
                pFillAndRefreshLists.Ubicacion(comboboxPadreValor, False, False, Convert.ToByte(comboboxAbueloValor.SelectedValue))
                If Not mParametroPadre.Valor Is Nothing Then
                    CS_ComboBox.SetSelectedValue(comboboxPadreValor, SelectedItemOptions.ValueOrFirstIfUnique, mParametroPadre.Valor)
                End If
        End Select
    End Sub

    Private Sub ComboPadreCambio(sender As Object, e As EventArgs) Handles comboboxPadreValor.SelectedIndexChanged
        If comboboxPadreValor.SelectedIndex = -1 Then
            comboboxValor.DataSource = Nothing
        End If
        Select Case mParametroActual.Tipo
            Case Constantes.REPORTE_PARAMETRO_TIPO_SUBUBICACION
                pFillAndRefreshLists.SubUbicacion(comboboxValor, False, False, Convert.ToInt16(comboboxPadreValor.SelectedValue))
                If Not mParametroActual.Valor Is Nothing Then
                    CS_ComboBox.SetSelectedValue(comboboxValor, SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
        End Select
    End Sub

    Private Sub Aceptar(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        mParametroAbuelo.Valor = comboboxAbueloValor.SelectedValue
        mParametroAbuelo.ValorParaMostrar = comboboxAbueloValor.Text
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
        mParametroAbuelo = Nothing
        mParametroPadre = Nothing
        mParametroActual = Nothing
    End Sub
End Class