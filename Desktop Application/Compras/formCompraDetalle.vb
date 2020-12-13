Public Class formCompraDetalle

#Region "Declarations"

    Private mParentForm As Form
    Private mdbContext As New CSBomberosContext(True)
    Private mCompraActual As Compra
    Private mCompraDetalleActual As CompraDetalle

    Private mIsLoading As Boolean = False
    Private mParentEditMode As Boolean = False
    Private mEditMode As Boolean = False
    Private mIsNew As Boolean = False

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal ParentEditMode As Boolean, ByVal EditMode As Boolean, ByRef ParentForm As Form, ByRef CompraActual As Compra, ByVal IDDetalle As Byte)
        mParentForm = ParentForm
        mIsLoading = True
        mParentEditMode = ParentEditMode
        mEditMode = EditMode
        mIsNew = (IDDetalle = 0)

        mCompraActual = CompraActual
        If mIsNew Then
            ' Es Nuevo
            mCompraDetalleActual = New CompraDetalle
            mCompraActual.CompraDetalles.Add(mCompraDetalleActual)
        Else
            mCompraDetalleActual = mCompraActual.CompraDetalles.Single(Function(cd) cd.IDDetalle = IDDetalle)
        End If

        CS_Form.CenterToParent(mParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()

        mIsLoading = False

        ChangeMode()

        Me.ShowDialog(ParentForm)
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
        comboboxArea.Enabled = mEditMode
        textboxDetalle.ReadOnly = Not mEditMode
        currencytextboxImporte.ReadOnly = Not mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        If mCompraActual.IDCompra = 0 AndAlso CType(mParentForm, formCompra).comboboxCuartel.SelectedIndex > -1 Then
            pFillAndRefreshLists.AreaEnCompras(comboboxArea, False, False, CByte(CType(mParentForm, formCompra).comboboxCuartel.SelectedValue))
        Else
            pFillAndRefreshLists.AreaEnCompras(comboboxArea, False, False, mCompraActual.IDCuartel)
        End If
    End Sub

    Friend Sub SetAppearance()

    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mParentForm = Nothing
        mdbContext.Dispose()
        mdbContext = Nothing
        mCompraActual = Nothing
        mCompraDetalleActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mCompraDetalleActual
            ' Datos de la pestaña General
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxArea, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDArea)
            textboxDetalle.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Detalle)
            CS_ValueTranslation.FromValueDecimalToControlCurrencyTextBox(.Importe, currencytextboxImporte)

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
        With mCompraDetalleActual
            ' Datos de la pestaña General
            .IDArea = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxArea.SelectedValue).Value
            .Detalle = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDetalle.Text)
            .Importe = CS_ValueTranslation.FromControlCurrencyTextBoxToObjectDecimal(currencytextboxImporte)

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
        If comboboxArea.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Área.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxArea.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mIsNew Then
            If mCompraActual.CompraDetalles.Any() Then
                mCompraDetalleActual.IDDetalle = mCompraActual.CompraDetalles.Max(Function(cd) cd.IDDetalle) + CByte(1)
            Else
                mCompraDetalleActual.IDDetalle = 1
            End If
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Refresco la lista para mostrar los cambios
        CType(mParentForm, formCompra).DetallesRefreshData(mCompraDetalleActual.IDDetalle)

        Me.Close()
    End Sub

#End Region

End Class