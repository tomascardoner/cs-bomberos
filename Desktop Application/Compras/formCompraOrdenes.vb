Public Class formCompraOrdenes

#Region "Declarations"

    Private WithEvents datetimepickerFechaDesdeHost As ToolStripControlHost
    Private WithEvents datetimepickerFechaHastaHost As ToolStripControlHost

    Friend Class GridRowData
        Public Property IDCompraOrden As Integer
        Public Property IDCuartel As Byte
        Public Property CuartelNombre As String
        Public Property Numero As Integer
        Public Property Fecha As Date
        Public Property IDEntidad As Short
        Public Property EntidadNombre As String
        Public Property FacturaNumero As String
        Public Property Importe As Decimal?
        Public Property Cerrada As Boolean
    End Class

    Private mlistComprasBase As List(Of GridRowData)
    Private mlistComprasFiltradaYOrdenada As List(Of GridRowData)

    Private mSkipFilterData As Boolean
    Private mReportSelectionFormula As String

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder

#End Region

#Region "Form stuff"

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageOrdenCompra32)

        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        ' Filtro de período
        InicializarFiltroDeFechas()
        comboboxPeriodoTipo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, "Día:", "Semana:", "Mes:", "Fecha"})
        comboboxPeriodoTipo.SelectedIndex = 3

        Using context As New CSBomberosContext(True)
            ListasComun.LlenarComboBoxCuarteles(context, comboboxCuartel.ComboBox, True, False)
        End Using
        pFillAndRefreshLists.Entidad(comboboxEntidad.ComboBox, True, True)

        comboboxFacturaNumero.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_ITEM_COMPLETE_MALE, My.Resources.STRING_ITEM_EMPTY_MALE})
        comboboxFacturaNumero.SelectedIndex = 0

        comboboxCerrada.Items.AddRange({My.Resources.STRING_ITEM_ALL_FEMALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxCerrada.SelectedIndex = 0

        mSkipFilterData = False

        mOrdenColumna = columnCuartel
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

    Friend Sub RefreshData(Optional ByVal PositionIDCompraOrden As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim FechaDesde As Date
        Dim FechaHasta As Date

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
                mlistComprasBase = (From c In dbContext.CompraOrden
                                    Join cu In dbContext.Cuartel On c.IDCuartel Equals cu.IDCuartel
                                    Join p In dbContext.Entidad On c.IDEntidad Equals p.IDEntidad
                                    Where c.Fecha >= FechaDesde And c.Fecha <= FechaHasta
                                    Select New GridRowData With {.IDCompraOrden = c.IDCompraOrden, .IDCuartel = c.IDCuartel, .CuartelNombre = cu.Nombre, .Numero = c.Numero, .Fecha = c.Fecha, .IDEntidad = c.IDEntidad, .EntidadNombre = p.Nombre, .FacturaNumero = c.FacturaNumero, .Importe = c.CompraOrdenDetalles.Sum(Function(cd) cd.Importe), .Cerrada = c.Cerrada}).ToList
            End Using

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Ordenes de Compra.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDCompraOrden = 0
            Else
                PositionIDCompraOrden = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDCompraOrden
            End If
        End If

        FilterData()

        If PositionIDCompraOrden <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDCompraOrden = PositionIDCompraOrden Then
                    datagridviewMain.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub FilterData()

        If Not mSkipFilterData Then
            Me.Cursor = Cursors.WaitCursor

            Try
                ' Inicializo las variables
                mReportSelectionFormula = ""
                mlistComprasFiltradaYOrdenada = mlistComprasBase.ToList

                ' Filtro por Cuartel
                If comboboxCuartel.SelectedIndex > 0 Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.Where(Function(c) c.IDCuartel = CByte(comboboxCuartel.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Entidad
                If comboboxEntidad.SelectedIndex > 0 Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.Where(Function(c) c.IDEntidad = CShort(comboboxEntidad.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Número de Factura
                Select Case comboboxFacturaNumero.SelectedIndex
                    Case 0       ' Todas
                    Case 1       ' Completo
                        mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.Where(Function(c) c.FacturaNumero IsNot Nothing).ToList
                    Case 2       ' Vacío
                        mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.Where(Function(c) c.FacturaNumero Is Nothing).ToList
                End Select

                ' Filtro por Cerrada
                Select Case comboboxCerrada.SelectedIndex
                    Case CardonerSistemas.Constants.ComboBoxAllYesNo_AllListindex       ' Todas
                    Case CardonerSistemas.Constants.ComboBoxAllYesNo_YesListindex       ' Sí
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Compra.Cerrada} = 1"
                        mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.Where(Function(c) c.Cerrada).ToList
                    Case CardonerSistemas.Constants.ComboBoxAllYesNo_NoListindex        ' No
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Compra.Cerrada} = 0"
                        mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.Where(Function(c) Not c.Cerrada).ToList
                End Select

                Select Case mlistComprasFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Órdenes de Compra para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Órden de Compra.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Órdenes de Compra.", mlistComprasFiltradaYOrdenada.Count)
                End Select

            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al filtrar los datos.")
                Me.Cursor = Cursors.Default
                Exit Sub
            End Try

            OrderData()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub OrderData()
        ' Realizo las rutinas de ordenamiento
        Select Case mOrdenColumna.Name
            Case columnCuartel.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.Numero).ToList
                Else
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.CuartelNombre).ThenByDescending(Function(dgrd) dgrd.Numero).ToList
                End If
            Case columnNumero.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Numero).ThenBy(Function(dgrd) dgrd.CuartelNombre).ToList
                Else
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Numero).ThenByDescending(Function(dgrd) dgrd.CuartelNombre).ToList
                End If
            Case columnFecha.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Fecha).ThenBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.Numero).ToList
                Else
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Fecha).ThenByDescending(Function(dgrd) dgrd.CuartelNombre).ThenByDescending(Function(dgrd) dgrd.Numero).ToList
                End If
            Case columnEntidad.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.EntidadNombre).ThenBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.Numero).ToList
                Else
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.EntidadNombre).ThenByDescending(Function(dgrd) dgrd.CuartelNombre).ThenByDescending(Function(dgrd) dgrd.Numero).ToList
                End If
            Case columnFacturaNumero.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.FacturaNumero).ThenBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.Numero).ToList
                Else
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.FacturaNumero).ThenByDescending(Function(dgrd) dgrd.CuartelNombre).ThenByDescending(Function(dgrd) dgrd.Numero).ToList
                End If
            Case columnImporte.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Importe).ThenBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.Numero).ToList
                Else
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Importe).ThenByDescending(Function(dgrd) dgrd.CuartelNombre).ThenByDescending(Function(dgrd) dgrd.Numero).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistComprasFiltradaYOrdenada

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

    Private Sub CambioFiltros() Handles comboboxCuartel.SelectedIndexChanged, comboboxEntidad.SelectedIndexChanged, comboboxFacturaNumero.SelectedIndexChanged, comboboxCerrada.SelectedIndexChanged
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
            If mOrdenColumna IsNot Nothing Then
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
        If Permisos.VerificarPermiso(Permisos.COMPRAORDEN_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formCompraOrden.LoadAndShow(True, Me, 0)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Órden de Compra para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Not Permisos.VerificarPermiso(Permisos.COMPRAORDEN_EDITAR) Then
                Exit Sub
            End If

            If CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).Cerrada AndAlso Not Permisos.VerificarPermiso(Permisos.COMPRAORDEN_EDITAR_CERRADA, False) Then
                MsgBox("La Órden de Compra está cerrada y no tiene autorización para editarla.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formCompraOrden.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDCompraOrden)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Órden de Compra para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Not Permisos.VerificarPermiso(Permisos.COMPRAORDEN_ELIMINAR) Then
                Exit Sub
            End If

            If CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).Cerrada AndAlso Not Permisos.VerificarPermiso(Permisos.COMPRAORDEN_ELIMINAR_CERRADA, False) Then
                MsgBox("La Órden de Compra está cerrada y no tiene autorización para eliminarla.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            Using dbContext = New CSBomberosContext(True)
                Dim GridRowDataActual = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)
                Dim Mensaje As String

                Mensaje = String.Format("Se eliminará la Compra seleccionada.{0}{0}Número: {1}{0}Fecha: {2}{0}Entidad: {3}{0}Importe: {4}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.Numero, GridRowDataActual.Fecha.ToShortDateString(), GridRowDataActual.EntidadNombre, FormatCurrency(GridRowDataActual.Importe))
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                    Try
                        dbContext.CompraOrden.Remove(dbContext.CompraOrden.Find(GridRowDataActual.IDCompraOrden))
                        dbContext.SaveChanges()

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                            Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                MsgBox("No se puede eliminar la Órden de Compra porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Me.Cursor = Cursors.Default
                        Exit Sub

                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar la Órden de Compra.")
                    End Try

                    RefreshData()
                End If
            End Using

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Órden de Compra para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formCompraOrden.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDCompraOrden)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub menuitemImprimirOrdenCompra_Click(sender As Object, e As EventArgs) Handles buttonImprimir.ButtonClick, menuitemImprimirOrdenCompra.Click
        Dim CurrentRow As GridRowData

        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Compra para imprimir la Órden.", vbInformation, My.Application.Info.Title)
        Else

            If Not Permisos.VerificarPermiso(Permisos.COMPRAORDEN_IMPRIMIR) Then
                Exit Sub
            End If

            If CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).Cerrada AndAlso Not Permisos.VerificarPermiso(Permisos.COMPRAORDEN_IMPRIMIR_CERRADA, False) Then
                MsgBox("La Órden de Compra está cerrada y no tiene autorización para imprimirla.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Exit Sub
            End If

            CurrentRow = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)

            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            Using dbContext As New CSBomberosContext(True)
                Dim ParametroActual As New ReporteParametro
                Dim ReporteActual As New Reporte

                ReporteActual = dbContext.Reporte.Find(CS_Parameter_System.GetIntegerAsShort(Parametros.REPORTE_ID_COMPRA_ORDEN))
                ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.Trim() = "IDCompraOrden").Single.Valor = CurrentRow.IDCompraOrden

                ' Solicito que se especifique el Responsable de firmar
                ParametroActual = ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.Trim() = "IDResponsable").Single
                formReportesParametroComboBoxSimple.SetAppearance(ParametroActual, ParametroActual.Nombre)
                formReportesParametroComboBoxSimple.Text = "Especifique el firmante"
                If formReportesParametroComboBoxSimple.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    ReporteActual.Open(True, ReporteActual.Nombre & " - Nº " & CurrentRow.IDCompraOrden)
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