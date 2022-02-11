Public Class formCompraFacturas

#Region "Declarations"

    Private WithEvents datetimepickerFechaDesdeHost As ToolStripControlHost
    Private WithEvents datetimepickerFechaHastaHost As ToolStripControlHost

    Friend Class GridRowData
        Public Property IDCompraFactura As Integer
        Public Property Fecha As Date
        Public Property IDProveedor As Short
        Public Property ProveedorNombre As String
        Public Property NumeroCompleto As String
        Public Property FechaVencimiento As Date?
        Public Property Importe As Decimal
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

        pFillAndRefreshLists.Proveedor(comboboxProveedor.ComboBox, True, True)

        mSkipFilterData = False

        mOrdenColumna = columnFecha
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

    Friend Sub RefreshData(Optional ByVal PositionIDCompraFactura As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
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
                mlistComprasBase = (From cf In dbContext.CompraFactura
                                    Join p In dbContext.Proveedor On cf.IDProveedor Equals p.IDProveedor
                                    Where cf.Fecha >= FechaDesde And cf.Fecha <= FechaHasta
                                    Select New GridRowData With {.IDCompraFactura = cf.IDCompraFactura, .Fecha = cf.Fecha, .IDProveedor = cf.IDProveedor, .ProveedorNombre = p.Nombre, .NumeroCompleto = cf.NumeroCompleto, .FechaVencimiento = cf.FechaVencimiento, .Importe = cf.Importe}).ToList
            End Using

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Facturas de Compra.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDCompraFactura = 0
            Else
                PositionIDCompraFactura = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDCompraFactura
            End If
        End If

        FilterData()

        If PositionIDCompraFactura <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDCompraFactura = PositionIDCompraFactura Then
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

                ' Filtro por Proveedor
                If comboboxProveedor.SelectedIndex > 0 Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.Where(Function(c) c.IDProveedor = CShort(comboboxProveedor.ComboBox.SelectedValue)).ToList
                End If

                Select Case mlistComprasFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Facturas de Compra para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Factura de Compra.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Facturas de Compra.", mlistComprasFiltradaYOrdenada.Count)
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
            Case columnFecha.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderBy(Function(c) c.Fecha).ThenBy(Function(c) c.ProveedorNombre).ThenBy(Function(c) c.NumeroCompleto).ToList
                Else
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderByDescending(Function(c) c.Fecha).ThenByDescending(Function(c) c.ProveedorNombre).ThenByDescending(Function(c) c.NumeroCompleto).ToList
                End If
            Case columnProveedor.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderBy(Function(c) c.ProveedorNombre).ThenBy(Function(c) c.NumeroCompleto).ToList
                Else
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderByDescending(Function(c) c.ProveedorNombre).ThenByDescending(Function(c) c.NumeroCompleto).ToList
                End If
            Case columnNumeroCompleto.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderBy(Function(c) c.NumeroCompleto).ThenBy(Function(c) c.ProveedorNombre).ToList
                Else
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderByDescending(Function(c) c.NumeroCompleto).ThenByDescending(Function(c) c.ProveedorNombre).ToList
                End If
            Case columnFechaVencimiento.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderBy(Function(c) c.FechaVencimiento).ThenBy(Function(c) c.ProveedorNombre).ThenBy(Function(c) c.NumeroCompleto).ToList
                Else
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderByDescending(Function(c) c.FechaVencimiento).ThenByDescending(Function(c) c.ProveedorNombre).ThenByDescending(Function(c) c.NumeroCompleto).ToList
                End If
            Case columnImporte.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderBy(Function(c) c.Importe).ThenBy(Function(c) c.ProveedorNombre).ThenBy(Function(c) c.NumeroCompleto).ToList
                Else
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderByDescending(Function(c) c.Importe).ThenByDescending(Function(c) c.ProveedorNombre).ThenByDescending(Function(c) c.NumeroCompleto).ToList
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

    Private Sub CambioFiltros() Handles comboboxProveedor.SelectedIndexChanged
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
        If Permisos.VerificarPermiso(Permisos.COMPRAFACTURA_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formCompraFactura.LoadAndShow(True, Me, 0)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Factura de Compra para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Not Permisos.VerificarPermiso(Permisos.CompraFactura_EDITAR) Then
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formCompraFactura.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDCompraFactura)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Factura de Compra para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Not Permisos.VerificarPermiso(Permisos.COMPRAFACTURA_ELIMINAR) Then
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            Using dbContext = New CSBomberosContext(True)
                Dim GridRowDataActual = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)
                Dim Mensaje As String

                Mensaje = String.Format("Se eliminará la Factura de Compra seleccionada.{0}{0}Número: {1}{0}Fecha: {2}{0}Proveedor: {3}{0}Importe: {4}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.IDCompraFactura, GridRowDataActual.Fecha.ToShortDateString(), GridRowDataActual.ProveedorNombre, FormatCurrency(GridRowDataActual.Importe))
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                    Try
                        dbContext.CompraFactura.Remove(dbContext.CompraFactura.Find(GridRowDataActual.IDCompraFactura))
                        dbContext.SaveChanges()

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                            Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                MsgBox("No se puede eliminar la Factura de Compra porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Me.Cursor = Cursors.Default
                        Exit Sub

                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar la Factura de Compra.")
                    End Try

                    RefreshData()
                End If
            End Using

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Factura de Compra para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formCompraFactura.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDCompraFactura)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class