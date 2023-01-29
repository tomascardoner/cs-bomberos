Public Class formReportesParametroComboBoxDoble

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mParametroPadre As ReporteParametro
    Private mParametroActual As ReporteParametro

#End Region

#Region "Form stuff"

    Friend Sub SetAppearance(ByRef ParametroPadre As ReporteParametro, ByRef ParametroActual As ReporteParametro)
        mParametroPadre = ParametroPadre
        mParametroActual = ParametroActual

        labelPadreValor.Text = mParametroPadre.Nombre & ":"
        labelValor.Text = ParametroActual.Nombre & ":"

        Select Case mParametroActual.Tipo
            Case Reportes.REPORTE_PARAMETRO_TIPO_JERARQUIA
                pFillAndRefreshLists.Cargo(comboboxPadreValor, False, False)
                If mParametroPadre.Valor IsNot Nothing Then
                    CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxPadreValor, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mParametroPadre.Valor)
                End If
            Case Reportes.REPORTE_PARAMETRO_TIPO_AREA, Reportes.REPORTE_PARAMETRO_TIPO_UBICACION
                Using context As New CSBomberosContext(True)
                    ListasComunes.LlenarComboBoxCuarteles(context, comboboxPadreValor, False, False)
                End Using
                If mParametroPadre.Valor IsNot Nothing Then
                    CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxPadreValor, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mParametroPadre.Valor)
                End If
        End Select
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mParametroPadre = Nothing
        mParametroActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Controls behavior"

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
                pFillAndRefreshLists.CargoJerarquia(comboboxValor, False, False, CByte(comboboxPadreValor.SelectedValue))
                If mParametroActual.Valor IsNot Nothing Then
                    CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxValor, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Reportes.REPORTE_PARAMETRO_TIPO_AREA
                ListasComunes.LlenarComboBoxAreas(mdbContext, comboboxValor, False, False, CByte(comboboxPadreValor.SelectedValue))
                If mParametroActual.Valor IsNot Nothing Then
                    CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxValor, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
            Case Reportes.REPORTE_PARAMETRO_TIPO_UBICACION
                pFillAndRefreshLists.Ubicacion(comboboxValor, False, False, CByte(comboboxPadreValor.SelectedValue))
                If mParametroActual.Valor IsNot Nothing Then
                    CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxValor, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mParametroActual.Valor)
                End If
        End Select
    End Sub

#End Region

#Region "Main Toolbar"

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

#End Region

End Class