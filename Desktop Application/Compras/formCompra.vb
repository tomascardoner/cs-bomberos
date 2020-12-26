Public Class formCompra

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mCompraActual As Compra

    Private mIsLoading As Boolean = False
    Private mIsNew As Boolean = False
    Private mEditMode As Boolean = False

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDCompra As Integer)
        mIsLoading = True
        mEditMode = EditMode

        mIsNew = (IDCompra = 0)
        If mIsNew Then
            ' Es Nuevo
            mCompraActual = New Compra
            With mCompraActual
                .Fecha = DateTime.Today

                ' Si hay filtros aplicados en el form principal, uso esos valores como predeterminados
                If formCompras.comboboxCuartel.SelectedIndex > 0 Then
                    .IDCuartel = CByte(formCompras.comboboxCuartel.ComboBox.SelectedValue)
                End If
                If formCompras.comboboxProveedor.SelectedIndex > 0 Then
                    .IDProveedor = CShort(formCompras.comboboxProveedor.ComboBox.SelectedValue)
                End If

                .Cerrada = False
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Compra.Add(mCompraActual)
        Else
            mCompraActual = mdbContext.Compra.Find(IDCompra)
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
        buttonImprimir.Visible = (mEditMode = False)

        ' General
        comboboxCuartel.Enabled = (mEditMode And (mIsNew Or Not mCompraActual.CompraDetalles.Any()))
        integertextboxNumero.ReadOnly = Not mEditMode
        buttonCodigoSiguiente.Visible = mEditMode
        datetimepickerFecha.Enabled = mEditMode
        comboboxProveedor.Enabled = mEditMode
        datetimepickerFacturaFecha.Enabled = mEditMode
        textboxFacturaNumero.ReadOnly = Not mEditMode
        checkboxCerrada.Enabled = mEditMode
        datetimepickerCierreFecha.Enabled = (mEditMode And checkboxCerrada.Checked)

        ' Detalles
        toolstripDetalles.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Cuartel(comboboxCuartel, False, False)
        pFillAndRefreshLists.Proveedor(comboboxProveedor, False, True)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.IMAGE_COMPRAS_32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mCompraActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mCompraActual
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxCuartel, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDCuartel)
            integertextboxNumero.IntegerValue = .Numero
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxProveedor, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, .IDProveedor, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            datetimepickerFacturaFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FacturaFecha, datetimepickerFacturaFecha)
            textboxFacturaNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.FacturaNumero)
            checkboxCerrada.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Cerrada)
            If checkboxCerrada.Checked Then
                datetimepickerCierreFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.CierreFecha, datetimepickerCierreFecha)
            Else
                datetimepickerCierreFecha.Value = DateAndTime.Today
                datetimepickerCierreFecha.Checked = False
            End If

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .IDCompra = 0 Then
                textboxIDCompra.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDCompra.Text = String.Format(.IDCompra.ToString, "G")
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

            DetallesRefreshData()
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mCompraActual
            .IDCuartel = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCuartel.SelectedValue).Value
            .Numero = CInt(integertextboxNumero.IntegerValue)
            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFecha.Value).Value
            .IDProveedor = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxProveedor.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            .FacturaFecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFacturaFecha.Value, datetimepickerFacturaFecha.Checked)
            .FacturaNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxFacturaNumero.Text)
            .Cerrada = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxCerrada.CheckState)
            If checkboxCerrada.Checked Then
                .CierreFecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerCierreFecha.Value, datetimepickerCierreFecha.Checked)
            Else
                .CierreFecha = Nothing
            End If

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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub buttonCodigoSiguiente_Click() Handles buttonCodigoSiguiente.Click
        If comboboxCuartel.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Cuartel .", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuartel.Focus()
            Exit Sub
        End If

        Using dbcMaxCodigo As New CSBomberosContext(True)
            Dim IDCuartel As Byte = CByte(comboboxCuartel.SelectedValue)

            If dbcMaxCodigo.Compra.Any(Function(c) c.IDCuartel = IDCuartel) Then
                integertextboxNumero.IntegerValue = CInt(dbcMaxCodigo.Compra.Where(Function(c) c.IDCuartel = IDCuartel).Max(Function(c) c.Numero)) + 1
            Else
                integertextboxNumero.IntegerValue = 1
            End If
        End Using
    End Sub

    Private Sub checkboxCerrada_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxCerrada.CheckedChanged
        datetimepickerCierreFecha.Enabled = (mEditMode And checkboxCerrada.Checked)
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Not Permisos.VerificarPermiso(Permisos.COMPRA_EDITAR) Then
            Exit Sub
        End If

        If mCompraActual.Cerrada AndAlso Not Permisos.VerificarPermiso(Permisos.COMPRA_EDITAR) Then
            MsgBox("La Compra está cerrada y no tiene autorización para editarla.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
            Exit Sub
        End If

        mEditMode = True
        ChangeMode()
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        If mdbContext.ChangeTracker.HasChanges Then
            If MsgBox(String.Format("Ha realizado cambios en los datos y seleccionó cancelar, los cambios se perderán.{0}{0}¿Confirma la pérdida de los cambios?", vbCrLf), CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If comboboxCuartel.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Cuartel.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuartel.Focus()
            Exit Sub
        End If
        If integertextboxNumero.Text.Length = 0 Then
            MsgBox("Debe ingresar el Número.", MsgBoxStyle.Information, My.Application.Info.Title)
            integertextboxNumero.Focus()
            Exit Sub
        End If
        If comboboxProveedor.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Proveedor.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxProveedor.Focus()
            Exit Sub
        End If

        If checkboxCerrada.Checked AndAlso datetimepickerCierreFecha.Checked AndAlso datetimepickerCierreFecha.Value < datetimepickerFecha.Value Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("La fecha de cierre no puede ser anterior a la fecha de la compra.", MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerCierreFecha.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mIsNew Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.Compra.Any() Then
                    mCompraActual.IDCompra = dbcMaxID.Compra.Max(Function(c) c.IDCompra) + 1
                Else
                    mCompraActual.IDCompra = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mCompraActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mCompraActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                If CS_Form.MDIChild_IsLoaded(CType(pFormMDIMain, Form), "formCompras") Then
                    Dim formCompras As formCompras = CType(CS_Form.MDIChild_GetInstance(CType(pFormMDIMain, Form), "formCompras"), formCompras)
                    formCompras.RefreshData(mCompraActual.IDCompra)
                    formCompras = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Compra con el mismo Cuartel y Número.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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

    Private Sub buttonImprimir_Click(sender As Object, e As EventArgs) Handles buttonImprimir.Click
        If Not Permisos.VerificarPermiso(Permisos.COMPRA_IMPRIMIR) Then
            Exit Sub
        End If

        If mCompraActual.Cerrada AndAlso Not Permisos.VerificarPermiso(Permisos.COMPRA_IMPRIMIR_CERRADA, False) Then
            MsgBox("La Compra está cerrada y no tiene autorización para imprimirla.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Using dbContext As New CSBomberosContext(True)
            Dim ParametroActual As New ReporteParametro
            Dim ReporteActual As New Reporte

            ReporteActual = dbContext.Reporte.Find(CS_Parameter_System.GetIntegerAsShort(Parametros.REPORTE_ID_COMPRA_ORDEN))
            ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.Trim() = "IDCompra").Single.Valor = mCompraActual.IDCompra

            ' Solicito que se especifique el Responsable de firmar
            ParametroActual = ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.Trim() = "IDResponsable").Single
            formReportesParametroComboBoxSimple.SetAppearance(ParametroActual, ParametroActual.Nombre)
            formReportesParametroComboBoxSimple.Text = "Especifique el el firmante"
            If formReportesParametroComboBoxSimple.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                ReporteActual.Open(True, ReporteActual.Nombre & " - Nº " & mCompraActual.IDCompra, Me)
            End If
            formReportesParametroComboBoxSimple.Close()
            formReportesParametroComboBoxSimple.Dispose()
        End Using

        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "Detalles"
    Friend Class DetallesGridRowData
        Public Property IDDetalle As Byte
        Public Property AreaNombre As String
        Public Property Detalle As String
        Public Property Importe As Decimal?
    End Class

    Friend Sub DetallesRefreshData(Optional ByVal PositionIDDetalle As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listDetalles As List(Of DetallesGridRowData)

        If RestoreCurrentPosition Then
            If datagridviewDetalles.CurrentRow Is Nothing Then
                PositionIDDetalle = 0
            Else
                PositionIDDetalle = CType(datagridviewDetalles.CurrentRow.DataBoundItem, DetallesGridRowData).IDDetalle
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listDetalles = (From cd In mCompraActual.CompraDetalles
                            Join a In mdbContext.Area On cd.IDArea Equals a.IDArea
                            Order By cd.IDDetalle
                            Select New DetallesGridRowData With {.IDDetalle = cd.IDDetalle, .AreaNombre = a.Nombre + " (" + a.Cuartel.Nombre + ")", .Detalle = cd.Detalle, .Importe = cd.Importe}).ToList

            datagridviewDetalles.AutoGenerateColumns = False
            datagridviewDetalles.DataSource = listDetalles

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Detalles de la Compra.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PositionIDDetalle <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewDetalles.Rows
                If CType(CurrentRowChecked.DataBoundItem, DetallesGridRowData).IDDetalle = PositionIDDetalle Then
                    datagridviewDetalles.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub DetallesAgregar(sender As Object, e As EventArgs) Handles buttonDetallesAgregar.Click
        Me.Cursor = Cursors.WaitCursor

        formCompraDetalle.LoadAndShow(True, True, Me, mCompraActual, 0)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DetallesEditar(sender As Object, e As EventArgs) Handles buttonDetallesEditar.Click
        If datagridviewDetalles.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Detalle para editar.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formCompraDetalle.LoadAndShow(True, True, Me, mCompraActual, CType(datagridviewDetalles.SelectedRows(0).DataBoundItem, DetallesGridRowData).IDDetalle)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub DetallesEliminar(sender As Object, e As EventArgs) Handles buttonDetallesEliminar.Click
        If datagridviewDetalles.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Detalle para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            Dim GridRowDataActual As DetallesGridRowData
            Dim Mensaje As String

            GridRowDataActual = CType(datagridviewDetalles.SelectedRows(0).DataBoundItem, DetallesGridRowData)

            Mensaje = String.Format("Se eliminará el Detalle seleccionado.{0}{0}Área: {1}{0}Detalle: {2}{0}Importe: {3}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.AreaNombre, GridRowDataActual.Detalle, FormatCurrency(GridRowDataActual.Importe))
            If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                mCompraActual.CompraDetalles.Remove(mCompraActual.CompraDetalles.Single(Function(cd) cd.IDDetalle = GridRowDataActual.IDDetalle))

                DetallesRefreshData()

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Detalles_Ver(sender As Object, e As EventArgs) Handles datagridviewDetalles.DoubleClick
        If datagridviewDetalles.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Detalle para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formCompraDetalle.LoadAndShow(mEditMode, False, Me, mCompraActual, CType(datagridviewDetalles.SelectedRows(0).DataBoundItem, DetallesGridRowData).IDDetalle)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class