Public Class formComprobante

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mComprobanteActual As Comprobante
    Private mOperacionTipo As String

    Private mIsLoading As Boolean
    Private mIsNew As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal operacionTipo As String, ByVal IDComprobante As Integer)
        mIsLoading = True
        mEditMode = EditMode
        mOperacionTipo = operacionTipo

        mIsNew = (IDComprobante = 0)
        If mIsNew Then
            ' Es Nuevo
            mComprobanteActual = New Comprobante
            With mComprobanteActual
                .Fecha = DateTime.Today

                ' Si hay filtros aplicados en el form principal, uso esos valores como predeterminados
                If formComprobantes.comboboxEntidad.SelectedIndex > 0 Then
                    .IDEntidad = CShort(formComprobantes.comboboxEntidad.ComboBox.SelectedValue)
                End If

                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Comprobante.Add(mComprobanteActual)
        Else
            mComprobanteActual = mdbContext.Comprobante.Find(IDComprobante)
        End If

        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
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
        comboBoxTipo.Enabled = mEditMode
        maskedTextBoxPuntoVenta.Enabled = mEditMode
        maskedTextBoxNumero.Enabled = mEditMode
        comboBoxEntidad.Enabled = mEditMode
        textBoxDescripcion.Enabled = mEditMode
        currencyTextBoxImporte.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        ListasComprobantes.LlenarComboBoxComprobanteTipos(mdbContext, comboBoxTipo, mOperacionTipo, False, False)
        pFillAndRefreshLists.Entidad(comboBoxEntidad, False, False)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageFacturaCompra32)
        If String.IsNullOrWhiteSpace(mOperacionTipo) Then
            Me.Text = "Comprobante"
        ElseIf mOperacionTipo = Constantes.OperacionTipoCompra Then
            Me.Text = "Comprobante de " & My.Resources.STRING_OPERACIONTIPO_COMPRA
        ElseIf mOperacionTipo = Constantes.OperacionTipoCompra Then
            Me.Text = "Comprobante de " & My.Resources.STRING_OPERACIONTIPO_VENTA
        Else
            Me.Text = "Comprobante"
        End If
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mComprobanteActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mComprobanteActual
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha)
            dateTimePickerFechaVencimiento.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaVencimiento, dateTimePickerFechaVencimiento)
            CardonerSistemas.ComboBox.SetSelectedValue(comboBoxTipo, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDComprobanteTipo, CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE)
            maskedTextBoxPuntoVenta.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.PuntoVenta, 5)
            maskedTextBoxNumero.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.Numero, 8)
            CardonerSistemas.ComboBox.SetSelectedValue(comboBoxEntidad, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDEntidad, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            textBoxDescripcion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Descripcion)
            CS_ValueTranslation_Syncfusion.FromValueDecimalToControlCurrencyTextBox(.Importe, currencyTextBoxImporte)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .IDComprobante = 0 Then
                textboxID.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxID.Text = String.Format(.IDComprobante.ToString, "G")
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
        With mComprobanteActual
            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFecha.Value).Value
            .FechaVencimiento = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(dateTimePickerFechaVencimiento.Value)
            .IDComprobanteTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboBoxTipo.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE).Value
            .PuntoVenta = CS_ValueTranslation.FromControlComboBoxToObjectInteger(maskedTextBoxPuntoVenta.Text, -1).Value
            .Numero = CS_ValueTranslation.FromControlComboBoxToObjectInteger(maskedTextBoxNumero.Text, -1).Value
            .IDEntidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboBoxEntidad.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT).Value
            .Descripcion = CS_ValueTranslation.FromControlTextBoxToObjectString(textBoxDescripcion.Text)
            .Importe = CS_ValueTranslation_Syncfusion.FromControlCurrencyTextBoxToObjectDecimal(currencyTextBoxImporte).Value

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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textBoxDescripcion.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub MaskedTextBoxs_GotFocus(sender As Object, e As EventArgs) Handles maskedTextBoxPuntoVenta.GotFocus, maskedTextBoxNumero.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
    End Sub

    Private Sub PuntoVenta_LeaveFocus(sender As Object, e As EventArgs) Handles maskedTextBoxPuntoVenta.Leave
        maskedTextBoxPuntoVenta.Text = maskedTextBoxPuntoVenta.Text.PadLeft(5, "0"c)
    End Sub

    Private Sub Numero_LeaveFocus(sender As Object, e As EventArgs) Handles maskedTextBoxNumero.Leave
        maskedTextBoxNumero.Text = maskedTextBoxNumero.Text.PadLeft(8, "0"c)
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Not Permisos.VerificarPermiso(Permisos.COMPROBANTE_EDITAR) Then
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
                If dbcMaxID.Comprobante.Any() Then
                    mComprobanteActual.IDComprobante = dbcMaxID.Comprobante.Max(Function(c) c.IDComprobante) + 1
                Else
                    mComprobanteActual.IDComprobante = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mComprobanteActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mComprobanteActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formComprobantes") Then
                    Dim formComprobantes As formComprobantes = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formComprobantes"), formComprobantes)
                    formComprobantes.RefreshData(mComprobanteActual.IDComprobante)
                    formComprobantes = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Comprobante de la misma Entidad, del mismo Tipo y con el mismo Número.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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
        If comboBoxTipo.SelectedIndex = -1 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Tipo de Comprobante.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboBoxTipo.Focus()
            Return False
        End If
        If comboBoxEntidad.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Entidad.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboBoxEntidad.Focus()
            Return False
        End If
        If currencyTextBoxImporte.Text = String.Empty Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Importe.", MsgBoxStyle.Information, My.Application.Info.Title)
            currencyTextBoxImporte.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class