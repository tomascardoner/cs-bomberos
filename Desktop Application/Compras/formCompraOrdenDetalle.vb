Public Class formCompraOrdenDetalle

#Region "Declarations"

    Private mParentForm As Form
    Private mdbContext As New CSBomberosContext(True)
    Private mCompraOrdenActual As CompraOrden
    Private mCompraOrdenDetalleActual As CompraOrdenDetalle

    Private mIsLoading As Boolean
    Private mParentEditMode As Boolean
    Private mEditMode As Boolean
    Private mIsNew As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal ParentEditMode As Boolean, ByVal EditMode As Boolean, ByRef ParentForm As Form, ByRef CompraOrdenActual As CompraOrden, ByVal IDDetalle As Byte)
        mParentForm = ParentForm
        mIsLoading = True
        mParentEditMode = ParentEditMode
        mEditMode = EditMode
        mIsNew = (IDDetalle = 0)

        mCompraOrdenActual = CompraOrdenActual
        If mIsNew Then
            ' Es Nuevo
            mCompraOrdenDetalleActual = New CompraOrdenDetalle
            mCompraOrdenActual.CompraOrdenDetalles.Add(mCompraOrdenDetalleActual)
        Else
            mCompraOrdenDetalleActual = mCompraOrdenActual.CompraOrdenDetalles.Single(Function(cd) cd.IDDetalle = IDDetalle)
        End If

        CardonerSistemas.Forms.CenterToParent(mParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()

        mIsLoading = False

        ChangeMode()

        Me.ShowDialog(mParentForm)
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Exit Sub
        End If

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mParentEditMode And Not mEditMode)
        buttonCerrar.Visible = Not mEditMode

        ' General
        comboBoxFactura.Enabled = mEditMode
        comboboxArea.Enabled = mEditMode
        textboxDetalle.ReadOnly = Not mEditMode
        currencytextboxImporte.ReadOnly = Not mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        ListasCompras.LlenarComboBoxFacturas(mdbContext, comboBoxFactura, mCompraOrdenActual.IDProveedor, False, True, True)
        If mCompraOrdenActual.IDCompraOrden = 0 AndAlso CType(mParentForm, formCompraOrden).comboboxCuartel.SelectedIndex > -1 Then
            pFillAndRefreshLists.AreaEnCompras(comboboxArea, False, False, CByte(CType(mParentForm, formCompraOrden).comboboxCuartel.SelectedValue))
        Else
            pFillAndRefreshLists.AreaEnCompras(comboboxArea, False, False, mCompraOrdenActual.IDCuartel)
        End If
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mParentForm = Nothing
        mdbContext.Dispose()
        mdbContext = Nothing
        mCompraOrdenActual = Nothing
        mCompraOrdenDetalleActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mCompraOrdenDetalleActual
            ' Datos de la pestaña General
            CardonerSistemas.ComboBox.SetSelectedValue(comboBoxFactura, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, .IDCompraFactura, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxArea, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDArea)
            textboxDetalle.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Detalle)
            CS_ValueTranslation_Syncfusion.FromValueDecimalToControlCurrencyTextBox(.Importe, currencytextboxImporte)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .IDDetalle = 0 Then
                textboxID.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxID.Text = String.Format(.IDDetalle.ToString, "G")
            End If
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mCompraOrdenDetalleActual
            ' Datos de la pestaña General
            .IDCompraFactura = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboBoxFactura.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER)
            .IDArea = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxArea.SelectedValue).Value
            .Detalle = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDetalle.Text)
            .Importe = CS_ValueTranslation_Syncfusion.FromControlCurrencyTextBoxToObjectDecimal(currencytextboxImporte)

            ' Datos de la pestaña Notas y Auditoría
            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
        End With
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxDetalle.GotFocus, textboxNotas.GotFocus
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
        If Not VerificarDatos() Then
            Return
        End If

        ' Generar el ID nuevo
        If mIsNew Then
            If mCompraOrdenActual.CompraOrdenDetalles.Any() Then
                mCompraOrdenDetalleActual.IDDetalle = mCompraOrdenActual.CompraOrdenDetalles.Max(Function(cd) cd.IDDetalle) + CByte(1)
            Else
                mCompraOrdenDetalleActual.IDDetalle = 1
            End If
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Refresco la lista para mostrar los cambios
        CType(mParentForm, formCompraOrden).DetallesRefreshData(mCompraOrdenDetalleActual.IDDetalle)

        Me.Close()
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        If comboBoxFactura.SelectedIndex = -1 Then
            MsgBox("Debe especificar la Factura.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboBoxFactura.Focus()
            Return False
        End If
        If comboboxArea.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Área.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxArea.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class