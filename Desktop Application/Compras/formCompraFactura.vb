Public Class formCompraFactura

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mCompraFacturaActual As CompraFactura

    Private mIsLoading As Boolean
    Private mIsNew As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDCompraFactura As Integer)
        mIsLoading = True
        mEditMode = EditMode

        mIsNew = (IDCompraFactura = 0)
        If mIsNew Then
            ' Es Nuevo
            mCompraFacturaActual = New CompraFactura
            With mCompraFacturaActual
                .Fecha = DateTime.Today

                ' Si hay filtros aplicados en el form principal, uso esos valores como predeterminados
                If formCompraFacturas.comboboxProveedor.SelectedIndex > 0 Then
                    .IDProveedor = CShort(formCompraFacturas.comboboxProveedor.ComboBox.SelectedValue)
                End If

                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.CompraFactura.Add(mCompraFacturaActual)
        Else
            mCompraFacturaActual = mdbContext.CompraFactura.Find(IDCompraFactura)
        End If

        CS_Form.CenterToParent(ParentForm, Me)
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

        '  Toolbar
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        ' General
        datetimepickerFecha.Enabled = mEditMode
        dateTimePickerFechaVencimiento.Enabled = mEditMode
        maskedTextBoxTipo.Enabled = mEditMode
        maskedTextBoxPuntoVenta.Enabled = mEditMode
        maskedTextBoxNumero.Enabled = mEditMode
        comboboxProveedor.Enabled = mEditMode
        textBoxDescripcion.Enabled = mEditMode
        currencytextboxImporte.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Proveedor(comboboxProveedor, False, False)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageFacturaCompra32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mCompraFacturaActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mCompraFacturaActual
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha)
            dateTimePickerFechaVencimiento.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaVencimiento, dateTimePickerFechaVencimiento)
            maskedTextBoxTipo.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Tipo)
            maskedTextBoxPuntoVenta.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.PuntoVenta, 5)
            maskedTextBoxNumero.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.Numero, 8)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxProveedor, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDProveedor, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            textBoxDescripcion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Descripcion)
            CS_ValueTranslation_Syncfusion.FromValueDecimalToControlCurrencyTextBox(.Importe, currencytextboxImporte)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .IDCompraFactura = 0 Then
                textboxID.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxID.Text = String.Format(.IDCompraFactura.ToString, "G")
            End If
            textboxFechaHoraCreacion.Text = .FechaHoraCreacion.ToShortDateString & " " & .FechaHoraCreacion.ToShortTimeString
            If .UsuarioCreacion Is Nothing Then
                textboxUsuarioCreacion.Text = ""
            Else
                textboxUsuarioCreacion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.UsuarioCreacion.Descripcion)
            End If
            textboxFechaHoraModificacion.Text = .FechaHoraModificacion.ToShortDateString & " " & .FechaHoraModificacion.ToShortTimeString
            If .UsuarioModificacion Is Nothing Then
                textboxUsuarioModificacion.Text = ""
            Else
                textboxUsuarioModificacion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.UsuarioModificacion.Descripcion)
            End If
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mCompraFacturaActual
            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFecha.Value).Value
            .FechaVencimiento = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(dateTimePickerFechaVencimiento.Value)
            .Tipo = CS_ValueTranslation.FromControlTextBoxToObjectString(maskedTextBoxTipo.Text)
            .PuntoVenta = CS_ValueTranslation.FromControlComboBoxToObjectInteger(maskedTextBoxPuntoVenta.Text, -1).Value
            .Numero = CS_ValueTranslation.FromControlComboBoxToObjectInteger(maskedTextBoxNumero.Text, -1).Value
            .IDProveedor = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxProveedor.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT).Value
            .Descripcion = CS_ValueTranslation.FromControlTextBoxToObjectString(textBoxDescripcion.Text)
            .Importe = CS_ValueTranslation_Syncfusion.FromControlCurrencyTextBoxToObjectDecimal(currencytextboxImporte).Value

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

    Private Sub maskedTextBoxTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles maskedTextBoxTipo.KeyPress
        If Char.IsLetter(e.KeyChar) AndAlso Not Char.IsUpper(e.KeyChar) Then
            e.KeyChar = CChar(CStr(e.KeyChar).ToUpper())
        End If
    End Sub

    Private Sub MaskedTextBoxs_GotFocus(sender As Object, e As EventArgs) Handles maskedTextBoxTipo.GotFocus, maskedTextBoxPuntoVenta.GotFocus, maskedTextBoxNumero.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
    End Sub

    Private Sub PuntoVenta_LeaveFocus(sender As Object, e As EventArgs) Handles maskedTextBoxPuntoVenta.Leave
        maskedTextBoxPuntoVenta.Text = maskedTextBoxPuntoVenta.Text.PadLeft(5, "0"c)
    End Sub

    Private Sub Numero_LeaveFocus(sender As Object, e As EventArgs) Handles maskedTextBoxNumero.Leave
        maskedTextBoxNumero.Text = maskedTextBoxNumero.Text.PadLeft(8, "0"c)
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textBoxDescripcion.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Not Permisos.VerificarPermiso(Permisos.COMPRAFACTURA_EDITAR) Then
            Exit Sub
        End If

        mEditMode = True
        ChangeMode()
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        If mdbContext.ChangeTracker.HasChanges Then
            If MsgBox(String.Format(My.Resources.STRING_CONFIRMAR_CANCELACION_DATOS, vbCrLf), CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If Not VerificarDatos() Then
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mIsNew Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.CompraFactura.Any() Then
                    mCompraFacturaActual.IDCompraFactura = dbcMaxID.CompraFactura.Max(Function(c) c.IDCompraFactura) + 1
                Else
                    mCompraFacturaActual.IDCompraFactura = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mCompraFacturaActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mCompraFacturaActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                If CS_Form.MDIChild_IsLoaded(CType(pFormMDIMain, Form), "formCompraFacturas") Then
                    Dim formCompraFacturas As formCompraFacturas = CType(CS_Form.MDIChild_GetInstance(CType(pFormMDIMain, Form), "formCompraFacturas"), formCompraFacturas)
                    formCompraFacturas.RefreshData(mCompraFacturaActual.IDCompraFactura)
                    formCompraFacturas = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Factura de Compra del mismo Proveedor con el mismo Número.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Case Else
                        CardonerSistemas.ErrorHandler.ProcessError(CType(dbuex, Exception), My.Resources.STRING_ERROR_SAVING_CHANGES)
                End Select
                Exit Sub

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Exit Sub
            End Try
        End If

        Me.Close()
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        If maskedTextBoxTipo.Text.Length = 0 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Tipo de Factura.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedTextBoxTipo.Focus()
            Return False
        End If
        If comboboxProveedor.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Proveedor.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxProveedor.Focus()
            Return False
        End If
        If currencytextboxImporte.Text = String.Empty Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Importe.", MsgBoxStyle.Information, My.Application.Info.Title)
            currencytextboxImporte.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class