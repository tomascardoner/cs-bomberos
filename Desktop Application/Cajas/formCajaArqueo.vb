Public Class formCajaArqueo

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mCajaArqueoActual As CajaArqueo

    Private mIsLoading As Boolean = False
    Private mIsNew As Boolean = False
    Private mEditMode As Boolean = False

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDCaja As Byte, ByVal IDArqueo As Integer)
        mIsLoading = True
        mEditMode = EditMode

        mIsNew = (IDArqueo = 0)
        If mIsNew Then
            ' Es Nuevo
            mCajaArqueoActual = New CajaArqueo
            With mCajaArqueoActual
                ' Si hay filtros aplicados en el form principal, uso esos valores como predeterminados
                If formCajasArqueos.comboboxCaja.SelectedIndex > 0 Then
                    .IDCaja = CByte(formCajasArqueos.comboboxCaja.ComboBox.SelectedValue)
                End If

                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.CajaArqueo.Add(mCajaArqueoActual)
        Else
            mCajaArqueoActual = mdbContext.CajaArqueo.Find(IDCaja, IDArqueo)
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
        comboboxCaja.Enabled = (mEditMode And mIsNew)
        currencytextboxSaldoInicial.ReadOnly = Not mEditMode
        buttonSaldoInicial.Visible = mEditMode
        currencytextboxImporteAsignado.ReadOnly = Not mEditMode
        datetimepickerCierreFecha.Enabled = (mEditMode)

        ' Detalles
        toolstripDetalles.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Caja(comboboxCaja, False, False)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageArqueoCaja32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mCajaArqueoActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mCajaArqueoActual
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxCaja, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDCaja)
            CS_ValueTranslation_Syncfusion.FromValueDecimalToControlCurrencyTextBox(.SaldoInicial, currencytextboxSaldoInicial)
            CS_ValueTranslation_Syncfusion.FromValueDecimalToControlCurrencyTextBox(.ImporteAsignado, currencytextboxImporteAsignado)
            datetimepickerCierreFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaCierre, datetimepickerCierreFecha)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If mIsNew Then
                textboxID.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxID.Text = String.Format(.IDArqueo.ToString, "G")
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
        With mCajaArqueoActual
            .IDCaja = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCaja.SelectedValue).Value
            .SaldoInicial = CS_ValueTranslation_Syncfusion.FromControlCurrencyTextBoxToObjectDecimal(currencytextboxSaldoInicial).Value
            .ImporteAsignado = CS_ValueTranslation_Syncfusion.FromControlCurrencyTextBoxToObjectDecimal(currencytextboxImporteAsignado).Value
            .FechaCierre = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerCierreFecha.Value, datetimepickerCierreFecha.Checked)

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

    Private Sub buttonCodigoSiguiente_Click() Handles buttonSaldoInicial.Click
        If comboboxCaja.SelectedValue Is Nothing Then
            MsgBox("Debe especificar la Caja .", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCaja.Focus()
            Exit Sub
        End If

        Using dbcCajaArqueoUltimo As New CSBomberosContext(True)
            Dim IDCaja As Byte = CByte(comboboxCaja.SelectedValue)
            Dim CajaArqueoUltimo As CajaArqueo

            If datetimepickerCierreFecha.Checked Then
                CajaArqueoUltimo = dbcCajaArqueoUltimo.CajaArqueo.Where(Function(ca) (Not (ca.IDCaja = mCajaArqueoActual.IDCaja AndAlso ca.IDArqueo = mCajaArqueoActual.IDArqueo)) AndAlso ca.FechaCierre.HasValue AndAlso ca.FechaCierre.Value <= Date.Today).FirstOrDefault()
            Else
                CajaArqueoUltimo = dbcCajaArqueoUltimo.CajaArqueo.Where(Function(ca) (Not (ca.IDCaja = mCajaArqueoActual.IDCaja AndAlso ca.IDArqueo = mCajaArqueoActual.IDArqueo)) AndAlso ca.FechaCierre.HasValue AndAlso ca.FechaCierre.Value <= datetimepickerCierreFecha.Value).FirstOrDefault()
            End If

            If CajaArqueoUltimo IsNot Nothing Then
                currencytextboxSaldoInicial.DecimalValue = CajaArqueoUltimo.SaldoFinal
            Else
                currencytextboxSaldoInicial.DecimalValue = 0
            End If
        End Using
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Not Permisos.VerificarPermiso(Permisos.CAJAARQUEO_EDITAR) Then
            Exit Sub
        End If

        If mCajaArqueoActual.FechaCierre IsNot Nothing AndAlso Not Permisos.VerificarPermiso(Permisos.CAJAARQUEO_EDITAR) Then
            MsgBox("El Arqueo de Caja está cerrado y no tiene autorización para editarlo.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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
        If comboboxCaja.SelectedValue Is Nothing Then
            MsgBox("Debe especificar la Caja.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCaja.Focus()
            Exit Sub
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Generar el ID nuevo
        If mIsNew Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.CajaArqueo.Where(Function(ca) ca.IDCaja = mCajaArqueoActual.IDCaja).Any() Then
                    mCajaArqueoActual.IDArqueo = dbcMaxID.CajaArqueo.Where(Function(ca) ca.IDCaja = mCajaArqueoActual.IDCaja).Max(Function(c) c.IDArqueo) + 1
                Else
                    mCajaArqueoActual.IDArqueo = 1
                End If
            End Using
        End If

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mCajaArqueoActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mCajaArqueoActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                If CS_Form.MDIChild_IsLoaded(CType(pFormMDIMain, Form), "formCajasArqueos") Then
                    Dim formCajasArqueos As formCajasArqueos = CType(CS_Form.MDIChild_GetInstance(CType(pFormMDIMain, Form), "formCajasArqueos"), formCajasArqueos)
                    formCajasArqueos.RefreshData(mCajaArqueoActual.IDCaja, mCajaArqueoActual.IDArqueo)
                    formCajasArqueos = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Arqueo de Caja con el mismo Número.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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
        If Not Permisos.VerificarPermiso(Permisos.CAJAARQUEO_IMPRIMIR) Then
            Exit Sub
        End If

        If mCajaArqueoActual.FechaCierre IsNot Nothing AndAlso Not Permisos.VerificarPermiso(Permisos.CAJAARQUEO_IMPRIMIR_CERRADA, False) Then
            MsgBox("El Arqueo de Caja está cerrado y no tiene autorización para imprimirlo.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Using dbContext As New CSBomberosContext(True)
            Dim ParametroActual As New ReporteParametro
            Dim ReporteActual As New Reporte

            ReporteActual = dbContext.Reporte.Find(CS_Parameter_System.GetIntegerAsShort(Parametros.REPORTE_ID_CAJAARQUEO))
            ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.Trim() = "IDCaja").Single.Valor = mCajaArqueoActual.IDCaja
            ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.Trim() = "IDArqueo").Single.Valor = mCajaArqueoActual.IDArqueo

            ' Solicito que se especifique el Responsable de firmar
            ParametroActual = ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.Trim() = "IDResponsable").Single
            formReportesParametroComboBoxSimple.SetAppearance(ParametroActual, ParametroActual.Nombre)
            formReportesParametroComboBoxSimple.Text = "Especifique el el firmante"
            If formReportesParametroComboBoxSimple.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                ReporteActual.Open(True, ReporteActual.Nombre, Me)
            End If
            formReportesParametroComboBoxSimple.Close()
            formReportesParametroComboBoxSimple.Dispose()
        End Using

        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "Detalles"
    Friend Sub DetallesRefreshData(Optional ByVal PositionIDDetalle As Short = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listDetalles As List(Of CajaArqueoDetalle)

        If RestoreCurrentPosition Then
            If datagridviewDetalles.CurrentRow Is Nothing Then
                PositionIDDetalle = 0
            Else
                PositionIDDetalle = CType(datagridviewDetalles.CurrentRow.DataBoundItem, CajaArqueoDetalle).IDDetalle
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listDetalles = mCajaArqueoActual.CajaArqueoDetalles.OrderBy(Function(cad) cad.IDDetalle).ToList()

            datagridviewDetalles.AutoGenerateColumns = False
            datagridviewDetalles.DataSource = listDetalles

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Detalles del Arqueo de Caja.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PositionIDDetalle <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewDetalles.Rows
                If CType(CurrentRowChecked.DataBoundItem, CajaArqueoDetalle).IDDetalle = PositionIDDetalle Then
                    datagridviewDetalles.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub DetallesAgregar(sender As Object, e As EventArgs) Handles buttonDetallesAgregar.Click
        Me.Cursor = Cursors.WaitCursor

        formCajaArqueoDetalle.LoadAndShow(True, True, Me, mCajaArqueoActual, 0)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DetallesEditar(sender As Object, e As EventArgs) Handles buttonDetallesEditar.Click
        If datagridviewDetalles.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Detalle para editar.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formCajaArqueoDetalle.LoadAndShow(True, True, Me, mCajaArqueoActual, CType(datagridviewDetalles.SelectedRows(0).DataBoundItem, CajaArqueoDetalle).IDDetalle)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub DetallesEliminar(sender As Object, e As EventArgs) Handles buttonDetallesEliminar.Click
        If datagridviewDetalles.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Detalle para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            Dim CajaArqueoDetalleActual As CajaArqueoDetalle
            Dim Mensaje As String

            CajaArqueoDetalleActual = CType(datagridviewDetalles.SelectedRows(0).DataBoundItem, CajaArqueoDetalle)

            Mensaje = String.Format("Se eliminará el Detalle seleccionado.{0}{0}Nº de comprobante: {1}{0}Fecha: {2}{0}Proveedor: {3}{0}Detalle: {4}{0}Importe: {5}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, CajaArqueoDetalleActual.NumeroComprobante, CajaArqueoDetalleActual.Fecha.ToShortDateString(), CajaArqueoDetalleActual.Proveedor, CajaArqueoDetalleActual.Detalle, FormatCurrency(CajaArqueoDetalleActual.Importe))
            If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                mCajaArqueoActual.CajaArqueoDetalles.Remove(mCajaArqueoActual.CajaArqueoDetalles.Single(Function(cad) cad.IDDetalle = CajaArqueoDetalleActual.IDDetalle))

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

            formCajaArqueoDetalle.LoadAndShow(mEditMode, False, Me, mCajaArqueoActual, CType(datagridviewDetalles.SelectedRows(0).DataBoundItem, CajaArqueoDetalle).IDDetalle)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class