Public Class formCajasArqueos

#Region "Declarations"
    Private WithEvents datetimepickerFechaDesdeHost As ToolStripControlHost
    Private WithEvents datetimepickerFechaHastaHost As ToolStripControlHost

    Friend Class GridRowData
        Public Property IDCaja As Byte
        Public Property CajaNombre As String
        Public Property IDArqueo As Integer
        Public Property SaldoInicial As Decimal
        Public Property ImporteAsignado As Decimal
        Public Property SaldoActual As Decimal
        Public Property FechaCierre As Date?
    End Class

    Private mlistCajasArqueosBase As List(Of GridRowData)
    Private mlistCajasArqueosFiltradaYOrdenada As List(Of GridRowData)

    Private mSkipFilterData As Boolean = False
    Private mBusquedaAplicada As Boolean = False
    Private mReportSelectionFormula As String

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder
#End Region

#Region "Form stuff"
    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageArqueoCaja32)

        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        ' Filtro de período
        InicializarFiltroDeFechas()
        comboboxPeriodoTipo.Items.AddRange({My.Resources.STRING_ITEM_ALL_FEMALE, "Día:", "Semana:", "Mes:", "Fecha"})
        comboboxPeriodoTipo.SelectedIndex = 3

        pFillAndRefreshLists.Caja(comboboxCaja.ComboBox, True, False)

        comboboxCerrada.Items.AddRange({My.Resources.STRING_ITEM_ALL_FEMALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxCerrada.SelectedIndex = 0

        mSkipFilterData = False

        mOrdenColumna = columnCaja
        mOrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub

    Private Sub InicializarFiltroDeFechas()
        ' Create a new ToolStripControlHost, passing in a control.
        datetimepickerFechaDesdeHost = New ToolStripControlHost(New DateTimePicker())
        datetimepickerFechaHastaHost = New ToolStripControlHost(New DateTimePicker())

        ' Set the font on the ToolStripControlHost, this will affect the hosted control.
        'dateTimePickerHost.Font = New Font("Arial", 7.0F, FontStyle.Italic)

        ' Set the Width property, this will also affect the hosted control.
        datetimepickerFechaDesdeHost.Width = 100
        datetimepickerFechaDesdeHost.DisplayStyle = ToolStripItemDisplayStyle.Text
        datetimepickerFechaHastaHost.Width = 100
        datetimepickerFechaHastaHost.DisplayStyle = ToolStripItemDisplayStyle.Text

        ' Setting the Text property requires a string that converts to a  
        ' DateTime type since that is what the hosted control requires.
        datetimepickerFechaDesdeHost.Text = DateTime.Today.ToShortDateString
        datetimepickerFechaHastaHost.Text = DateTime.Today.ToShortDateString

        ' Cast the Control property back to the original type to set a  
        ' type-specific property. 
        CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Format = DateTimePickerFormat.Short
        CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Format = DateTimePickerFormat.Short

        ' Add the control host to the ToolStrip.
        toolstripPeriodo.Items.Insert(3, datetimepickerFechaDesdeHost)
        toolstripPeriodo.Items.Add(datetimepickerFechaHastaHost)

        datetimepickerFechaDesdeHost.Visible = False
        datetimepickerFechaHastaHost.Visible = False
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub RefreshData(Optional ByVal PositionIDCaja As Byte = 0, Optional PositionIDArqueo As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim FechaDesde As Date
        Dim FechaHasta As Date

        If mSkipFilterData Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Select Case comboboxPeriodoTipo.SelectedIndex
            Case 0  ' Todas
                FechaDesde = System.DateTime.MinValue
                FechaHasta = System.DateTime.MaxValue
            Case 1  ' Día
                Select Case comboboxPeriodoValor.SelectedIndex
                    Case 0  ' Hoy
                        FechaDesde = System.DateTime.Today
                        FechaHasta = System.DateTime.Today
                    Case 1  ' Ayer
                        FechaDesde = System.DateTime.Today.AddDays(-1)
                        FechaHasta = System.DateTime.Today.AddDays(-1)
                    Case 2  ' Anteayer
                        FechaDesde = System.DateTime.Today.AddDays(-2)
                        FechaHasta = System.DateTime.Today.AddDays(-2)
                    Case 3  ' Últimos 2
                        FechaDesde = System.DateTime.Today.AddDays(-1)
                        FechaHasta = System.DateTime.Today
                    Case 4  ' Últimos 3
                        FechaDesde = System.DateTime.Today.AddDays(-2)
                        FechaHasta = System.DateTime.Today
                    Case 5  ' Últimos 4
                        FechaDesde = System.DateTime.Today.AddDays(-3)
                        FechaHasta = System.DateTime.Today
                End Select
            Case 2  ' Semana
                Select Case comboboxPeriodoValor.SelectedIndex
                    Case 0  ' Actual
                        FechaDesde = System.DateTime.Today.AddDays(-System.DateTime.Today.DayOfWeek)
                        FechaHasta = System.DateTime.Today
                    Case 1  ' Anterior
                        FechaDesde = System.DateTime.Today.AddDays(-System.DateTime.Today.DayOfWeek - 7)
                        FechaHasta = System.DateTime.Today.AddDays(-System.DateTime.Today.DayOfWeek - 1)
                    Case 2  ' Últimas 2
                        FechaDesde = System.DateTime.Today.AddDays(-System.DateTime.Today.DayOfWeek - 7)
                        FechaHasta = System.DateTime.Today
                    Case 3  ' Últimas 3
                        FechaDesde = System.DateTime.Today.AddDays(-System.DateTime.Today.DayOfWeek - 14)
                        FechaHasta = System.DateTime.Today
                End Select
            Case 3  ' Mes
                Select Case comboboxPeriodoValor.SelectedIndex
                    Case 0  ' Actual
                        FechaDesde = New Date(System.DateTime.Today.Year, System.DateTime.Today.Month, 1)
                        FechaHasta = System.DateTime.Today
                    Case 1  ' Anterior
                        FechaDesde = New Date(System.DateTime.Today.Year, System.DateTime.Today.AddMonths(-1).Month, 1)
                        FechaHasta = New Date(System.DateTime.Today.Year, System.DateTime.Today.AddMonths(-1).Month, New System.Globalization.GregorianCalendar().GetDaysInMonth(System.DateTime.Today.Year, System.DateTime.Today.AddMonths(-1).Month))
                    Case 2  ' Últimos 2
                        FechaDesde = New Date(System.DateTime.Today.Year, System.DateTime.Today.AddMonths(-1).Month, 1)
                        FechaHasta = System.DateTime.Today
                    Case 3  ' Últimos 3
                        FechaDesde = New Date(System.DateTime.Today.Year, System.DateTime.Today.AddMonths(-2).Month, 1)
                        FechaHasta = System.DateTime.Today
                End Select
            Case 4  ' Fecha
                Select Case comboboxPeriodoValor.SelectedIndex
                    Case 0  ' igual
                        FechaDesde = CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value
                        FechaHasta = CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value
                    Case 1  ' posterior
                        FechaDesde = CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value
                        FechaHasta = Date.MaxValue
                    Case 2  ' anterior
                        FechaDesde = Date.MinValue
                        FechaHasta = CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value
                    Case 3  ' entre
                        FechaDesde = CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value
                        FechaHasta = CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Value
                End Select
        End Select

        Try
            Using dbContext As New CSBomberosContext(True)
                mlistCajasArqueosBase = (From ca In dbContext.CajaArqueo
                                         Join c In dbContext.Caja On ca.IDCaja Equals c.IDCaja
                                         Where ca.FechaCierre Is Nothing OrElse ca.FechaCierre >= FechaDesde And ca.FechaCierre <= FechaHasta
                                         Select New GridRowData With {.IDCaja = ca.IDCaja, .CajaNombre = c.Nombre, .IDArqueo = ca.IDArqueo, .SaldoInicial = ca.SaldoInicial, .ImporteAsignado = ca.ImporteAsignado, .SaldoActual = ca.SaldoInicial + ca.ImporteAsignado - If(ca.CajaArqueoDetalles.Any(), ca.CajaArqueoDetalles.Sum(Function(cad) cad.Importe), 0), .FechaCierre = ca.FechaCierre}).ToList
            End Using

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Arqueos de Caja.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDCaja = 0
                PositionIDArqueo = 0
            Else
                PositionIDCaja = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDCaja
                PositionIDArqueo = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDArqueo
            End If
        End If

        FilterData()

        If PositionIDCaja <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDCaja = PositionIDCaja AndAlso CType(CurrentRowChecked.DataBoundItem, GridRowData).IDArqueo = PositionIDArqueo Then
                    datagridviewMain.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub FilterData()

        If mSkipFilterData Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            ' Inicializo las variables
            mReportSelectionFormula = ""
            mlistCajasArqueosFiltradaYOrdenada = mlistCajasArqueosBase.ToList

            ' Filtro por Caja
            If comboboxCaja.SelectedIndex > 0 Then
                mlistCajasArqueosFiltradaYOrdenada = mlistCajasArqueosFiltradaYOrdenada.Where(Function(ca) ca.IDCaja = CByte(comboboxCaja.ComboBox.SelectedValue)).ToList
            End If

            ' Filtro por Cerrada
            Select Case comboboxCerrada.SelectedIndex
                Case CardonerSistemas.Constants.ComboBoxAllYesNo_AllListindex       ' Todas
                Case CardonerSistemas.Constants.ComboBoxAllYesNo_YesListindex       ' Sí
                    mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "Not IsNull({CajaArqueo.FechaCierre})"
                    mlistCajasArqueosFiltradaYOrdenada = mlistCajasArqueosFiltradaYOrdenada.Where(Function(ca) ca.FechaCierre IsNot Nothing).ToList
                Case CardonerSistemas.Constants.ComboBoxAllYesNo_NoListindex        ' No
                    mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "IsNull({CajaArqueo.FechaCierre})"
                    mlistCajasArqueosFiltradaYOrdenada = mlistCajasArqueosFiltradaYOrdenada.Where(Function(ca) ca.FechaCierre Is Nothing).ToList
            End Select

            Select Case mlistCajasArqueosFiltradaYOrdenada.Count
                Case 0
                    statuslabelMain.Text = String.Format("No hay Arqueos de Caja para mostrar.")
                Case 1
                    statuslabelMain.Text = String.Format("Se muestra 1 Arqueo de Caja.")
                Case Else
                    statuslabelMain.Text = String.Format("Se muestran {0} Arqueos de Caja.", mlistCajasArqueosFiltradaYOrdenada.Count)
            End Select

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al filtrar los datos.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        OrderData()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub OrderData()
        ' Realizo las rutinas de ordenamiento
        Select Case mOrdenColumna.Name
            Case columnCaja.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistCajasArqueosFiltradaYOrdenada = mlistCajasArqueosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.CajaNombre).ThenBy(Function(dgrd) dgrd.IDArqueo).ToList
                Else
                    mlistCajasArqueosFiltradaYOrdenada = mlistCajasArqueosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.CajaNombre).ThenByDescending(Function(dgrd) dgrd.IDArqueo).ToList
                End If
            Case columnIDArqueo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistCajasArqueosFiltradaYOrdenada = mlistCajasArqueosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.IDArqueo).ThenBy(Function(dgrd) dgrd.CajaNombre).ToList
                Else
                    mlistCajasArqueosFiltradaYOrdenada = mlistCajasArqueosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.IDArqueo).ThenByDescending(Function(dgrd) dgrd.CajaNombre).ToList
                End If
            Case columnSaldoInicial.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistCajasArqueosFiltradaYOrdenada = mlistCajasArqueosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.SaldoInicial).ThenBy(Function(dgrd) dgrd.CajaNombre).ThenBy(Function(dgrd) dgrd.IDArqueo).ToList
                Else
                    mlistCajasArqueosFiltradaYOrdenada = mlistCajasArqueosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.SaldoInicial).ThenByDescending(Function(dgrd) dgrd.CajaNombre).ThenByDescending(Function(dgrd) dgrd.IDArqueo).ToList
                End If
            Case columnFechaCierre.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistCajasArqueosFiltradaYOrdenada = mlistCajasArqueosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.FechaCierre).ThenBy(Function(dgrd) dgrd.CajaNombre).ThenBy(Function(dgrd) dgrd.IDArqueo).ToList
                Else
                    mlistCajasArqueosFiltradaYOrdenada = mlistCajasArqueosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.FechaCierre).ThenByDescending(Function(dgrd) dgrd.CajaNombre).ThenByDescending(Function(dgrd) dgrd.IDArqueo).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistCajasArqueosFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        mOrdenColumna.HeaderCell.SortGlyphDirection = mOrdenTipo
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub PeriodoTipoSeleccionar() Handles comboboxPeriodoTipo.SelectedIndexChanged
        comboboxPeriodoValor.Items.Clear()
        Select Case comboboxPeriodoTipo.SelectedIndex
            Case 0  ' Todas
                comboboxPeriodoValor.Items.AddRange({""})
            Case 1  ' Día
                comboboxPeriodoValor.Items.AddRange({"Hoy", "Ayer", "Anteayer", "Últimos 2", "Últimos 3", "Últimos 4"})
            Case 2  ' Semana
                comboboxPeriodoValor.Items.AddRange({"Actual", "Anterior", "Últimas 2", "Últimas 3"})
            Case 3  ' Mes
                comboboxPeriodoValor.Items.AddRange({"Actual", "Anterior", "Últimos 2", "Últimos 3"})
            Case 4  ' Fecha
                comboboxPeriodoValor.Items.AddRange({"es igual a:", "es posterior a:", "es anterior a:", "está entre:"})
        End Select
        comboboxPeriodoValor.Visible = comboboxPeriodoTipo.SelectedIndex <> 0
        comboboxPeriodoValor.SelectedIndex = 0
    End Sub

    Private Sub PeriodoValorSeleccionar() Handles comboboxPeriodoValor.SelectedIndexChanged
        datetimepickerFechaDesdeHost.Visible = (comboboxPeriodoTipo.SelectedIndex = 4)
        labelPeriodoFechaY.Visible = (comboboxPeriodoTipo.SelectedIndex = 4 And comboboxPeriodoValor.SelectedIndex = 3)
        datetimepickerFechaHastaHost.Visible = (comboboxPeriodoTipo.SelectedIndex = 4 And comboboxPeriodoValor.SelectedIndex = 3)
        RefreshData()
    End Sub

    Private Sub FechaCambiar() Handles datetimepickerFechaDesdeHost.TextChanged, datetimepickerFechaHastaHost.TextChanged
        RefreshData()
    End Sub

    Private Sub CambioFiltros() Handles comboboxCaja.SelectedIndexChanged, comboboxCerrada.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewMain.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewMain.Columns(e.ColumnIndex), DataGridViewColumn)

        If ClickedColumn Is mOrdenColumna Then
            ' La columna clickeada es la misma por la que ya estaba ordenado, así que cambio la dirección del orden
            If mOrdenTipo = SortOrder.Ascending Then
                mOrdenTipo = SortOrder.Descending
            Else
                mOrdenTipo = SortOrder.Ascending
            End If
        Else
            ' La columna clickeada es diferencte a la que ya estaba ordenada.
            ' En primer lugar saco el ícono de orden de la columna vieja
            If Not mOrdenColumna Is Nothing Then
                mOrdenColumna.HeaderCell.SortGlyphDirection = SortOrder.None
            End If

            ' Ahora preparo todo para la nueva columna
            mOrdenTipo = SortOrder.Ascending
            mOrdenColumna = ClickedColumn
        End If

        OrderData()
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub Agregar_Click() Handles buttonAgregar.Click
        If Permisos.VerificarPermiso(Permisos.CAJAARQUEO_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formCajaArqueo.LoadAndShow(True, Me, 0, 0)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Arqueo de Caja para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Not Permisos.VerificarPermiso(Permisos.CAJAARQUEO_EDITAR) Then
                Exit Sub
            End If

            If CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).FechaCierre IsNot Nothing AndAlso Not Permisos.VerificarPermiso(Permisos.CAJAARQUEO_EDITAR_CERRADA, False) Then
                MsgBox("El Arqueo de Caja está cerrado y no tiene autorización para editarlo.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formCajaArqueo.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDCaja, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDArqueo)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Arqueo de Caja para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Not Permisos.VerificarPermiso(Permisos.CAJAARQUEO_ELIMINAR) Then
                Exit Sub
            End If

            If CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).FechaCierre IsNot Nothing AndAlso Not Permisos.VerificarPermiso(Permisos.CAJAARQUEO_ELIMINAR_CERRADA, False) Then
                MsgBox("El Arqueo de Caja está cerrado y no tiene autorización para eliminarlo.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            Using dbContext = New CSBomberosContext(True)
                Dim GridRowDataActual = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)
                Dim Mensaje As String

                Mensaje = String.Format("Se eliminará el Arqueo de Caja seleccionado.{0}{0}Número: {1}{0}Saldo inicial: {2}{0}Fecha cierre: {3}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.IDArqueo, FormatCurrency(GridRowDataActual.SaldoInicial), If(GridRowDataActual.FechaCierre.HasValue, GridRowDataActual.FechaCierre.Value.ToShortDateString(), ""))
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                    Try
                        dbContext.CajaArqueo.Remove(dbContext.CajaArqueo.Find(GridRowDataActual.IDCaja, GridRowDataActual.IDArqueo))
                        dbContext.SaveChanges()

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                            Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                MsgBox("No se puede eliminar el Arqueo de Caja porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Me.Cursor = Cursors.Default
                        Exit Sub

                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar el Arqueo de Caja.")
                    End Try

                    RefreshData()
                End If
            End Using

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Arqueo de Caja para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formCajaArqueo.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDCaja, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDArqueo)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub menuitemImprimirOrdenCompra_Click(sender As Object, e As EventArgs) Handles buttonImprimir.ButtonClick, menuitemImprimirOrdenCompra.Click
        Dim CurrentRow As GridRowData

        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Arqueo de Caja para imprimir.", vbInformation, My.Application.Info.Title)
        Else

            If Not Permisos.VerificarPermiso(Permisos.CAJAARQUEO_IMPRIMIR) Then
                Exit Sub
            End If

            If CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).FechaCierre IsNot Nothing AndAlso Not Permisos.VerificarPermiso(Permisos.CAJAARQUEO_IMPRIMIR_CERRADA, False) Then
                MsgBox("El Arqueo de Caja está cerrado y no tiene autorización para imprimirlo.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Exit Sub
            End If

            CurrentRow = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)

            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            Using dbContext As New CSBomberosContext(True)
                Dim ParametroActual As New ReporteParametro
                Dim ReporteActual As New Reporte

                ReporteActual = dbContext.Reporte.Find(CS_Parameter_System.GetIntegerAsShort(Parametros.REPORTE_ID_CAJAARQUEO))
                ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.Trim() = "IDCaja").Single.Valor = CurrentRow.IDCaja
                ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.Trim() = "IDArqueo").Single.Valor = CurrentRow.IDArqueo

                ' Solicito que se especifique el Responsable de firmar
                ParametroActual = ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.Trim() = "IDResponsable").Single
                formReportesParametroComboBoxSimple.SetAppearance(ParametroActual, ParametroActual.Nombre)
                formReportesParametroComboBoxSimple.Text = "Especifique el el firmante"
                If formReportesParametroComboBoxSimple.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ReporteActual.Open(True, ReporteActual.Nombre & " - Nº " & CurrentRow.IDArqueo)
                End If
                formReportesParametroComboBoxSimple.Close()
                formReportesParametroComboBoxSimple.Dispose()
            End Using

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class