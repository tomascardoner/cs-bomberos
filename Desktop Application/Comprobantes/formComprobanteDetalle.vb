Public Class formComprobanteDetalle

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)

    Private mComprobanteActual As Comprobante
    Private mComprobanteDetalleActual As ComprobanteDetalle
    Private mArticuloActual As Articulo
    Private mEntidad As Entidad

    Private mParentEditMode As Boolean
    Private mEditMode As Boolean

    Private mCambiandoDescuento As Boolean

    Private ReadOnly mLoading As Boolean
    Private mIsNew As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal ParentEditMode As Boolean, ByVal EditMode As Boolean, ByRef ParentForm As Form, ByRef ComprobanteActual As Comprobante, ByRef ComprobanteDetalleActual As ComprobanteDetalle)
        mParentEditMode = ParentEditMode
        mEditMode = EditMode

        mComprobanteActual = ComprobanteActual
        mComprobanteDetalleActual = ComprobanteDetalleActual
        mIsNew = (mComprobanteDetalleActual.Indice = 0)

        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()
        ChangeMode()

        Me.ShowDialog(ParentForm)
    End Sub

    Private Sub ChangeMode()
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mParentEditMode And Not mEditMode)
        buttonCerrar.Visible = Not mEditMode

        comboboxArticulo.Enabled = mEditMode
        doubletextboxCantidad.ReadOnly = (mEditMode = False)
        textboxUnidad.ReadOnly = (mEditMode = False)
        currencytextboxPrecioUnitario.ReadOnly = (mEditMode = False)
        percenttextboxPrecioUnitarioDescuentoPorcentaje.ReadOnly = (mEditMode = False)
        currencytextboxPrecioUnitarioDescuentoImporte.ReadOnly = (mEditMode = False)
    End Sub

    Friend Sub InitializeFormAndControls()
        ListasComprobantes.LlenarComboBoxArticulos(mdbContext, comboboxArticulo, False, False)
    End Sub

    Private Sub FormEnd(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mComprobanteActual = Nothing
        mComprobanteDetalleActual = Nothing
        mArticuloActual = Nothing
        mEntidad = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()

        With mComprobanteDetalleActual
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxArticulo, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .IDArticulo, CShort(0))
            doubletextboxCantidad.DoubleValue = .Cantidad
            textboxUnidad.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Unidad)

            'textboxDescripcion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DescripcionDisplay)

            currencytextboxPrecioUnitario.DecimalValue = .PrecioUnitario
            percenttextboxPrecioUnitarioDescuentoPorcentaje.PercentValue = .PrecioUnitarioDescuentoPorcentaje
            currencytextboxPrecioUnitarioDescuentoImporte.DecimalValue = .PrecioUnitarioDescuentoImporte
            currencytextboxPrecioUnitarioFinal.DecimalValue = .PrecioUnitarioFinal
            currencytextboxPrecioTotal.DecimalValue = .PrecioTotal
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mComprobanteDetalleActual
            .IDArticulo = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxArticulo.SelectedValue).Value
            .Cantidad = Convert.ToDecimal(doubletextboxCantidad.DoubleValue)
            .Unidad = CS_ValueTranslation.FromControlComboBoxToObjectString(textboxUnidad.Text)
            .PrecioUnitario = currencytextboxPrecioUnitario.DecimalValue
            .PrecioUnitarioDescuentoPorcentaje = Convert.ToDecimal(percenttextboxPrecioUnitarioDescuentoPorcentaje.PercentValue)
            .PrecioUnitarioDescuentoImporte = currencytextboxPrecioUnitarioDescuentoImporte.DecimalValue
            .PrecioUnitarioFinal = currencytextboxPrecioUnitarioFinal.DecimalValue
            .PrecioTotal = currencytextboxPrecioTotal.DecimalValue
        End With
    End Sub

    Private Sub CalcularPrecioFinal()
        If Not doubletextboxCantidad.IsNull Then
            currencytextboxPrecioTotal.DecimalValue = Convert.ToDecimal(doubletextboxCantidad.DoubleValue) * currencytextboxPrecioUnitarioFinal.DecimalValue
        End If
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                If mEditMode Then
                    buttonGuardar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                If mEditMode Then
                    buttonCancelar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
        End Select
    End Sub

    Private Sub CambioCantidad() Handles doubletextboxCantidad.DoubleValueChanged
        CalcularPrecioFinal()
    End Sub

    Private Sub PrecioUnitario_TextChanged() Handles currencytextboxPrecioUnitario.DecimalValueChanged
        CalcularDescuento()
    End Sub

    Private Sub CalcularDescuento() Handles percenttextboxPrecioUnitarioDescuentoPorcentaje.DoubleValueChanged
        If Not mCambiandoDescuento Then
            currencytextboxPrecioUnitarioDescuentoImporte.DecimalValue = currencytextboxPrecioUnitario.DecimalValue * Convert.ToDecimal(percenttextboxPrecioUnitarioDescuentoPorcentaje.DoubleValue)
            PrecioUnitarioDescuentoImporte_TextChanged()
        End If
    End Sub

    Private Sub PrecioUnitarioDescuentoImporte_KeyPressed() Handles currencytextboxPrecioUnitarioDescuentoImporte.KeyPress
        mCambiandoDescuento = True
        percenttextboxPrecioUnitarioDescuentoPorcentaje.DoubleValue = 0
        mCambiandoDescuento = False
    End Sub

    Private Sub PrecioUnitarioDescuentoImporte_TextChanged() Handles currencytextboxPrecioUnitarioDescuentoImporte.DecimalValueChanged
        currencytextboxPrecioUnitarioFinal.DecimalValue = currencytextboxPrecioUnitario.DecimalValue - currencytextboxPrecioUnitarioDescuentoImporte.DecimalValue
        CalcularPrecioFinal()
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxUnidad.GotFocus, textboxDescripcion.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        mEditMode = True
        ChangeMode()
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If comboboxArticulo.SelectedIndex = -1 Then
            MsgBox("Debe especificar el Artículo.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxArticulo.Focus()
            Exit Sub
        End If

        If doubletextboxCantidad.DoubleValue = 0 Then
            MsgBox("Debe ingresar la Cantidad.", MsgBoxStyle.Information, My.Application.Info.Title)
            doubletextboxCantidad.Focus()
            Exit Sub
        End If

        ' Si es un nuevo item, busco el próximo Indice y agrego el objeto nuevo a la colección del parent
        If mComprobanteDetalleActual.Indice = 0 Then
            If mComprobanteActual.ComprobanteDetalles.Count = 0 Then
                mComprobanteDetalleActual.Indice = 1
            Else
                mComprobanteDetalleActual.Indice = mComprobanteActual.ComprobanteDetalles.Max(Function(cmp) cmp.Indice) + CByte(1)
            End If
            mComprobanteActual.ComprobanteDetalles.Add(mComprobanteDetalleActual)
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Refresco la lista para mostrar los cambios
        If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formComprobante") Then
            Dim formComprobante As formComprobante = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formComprobante"), formComprobante)
            formComprobante.RefreshDataDetalle(mComprobanteDetalleActual.Indice)
            formComprobante = Nothing
        End If

        Me.Close()
    End Sub

#End Region

End Class