Public Class formCompras

#Region "Declarations"
    Private WithEvents datetimepickerFechaDesdeHost As ToolStripControlHost
    Private WithEvents datetimepickerFechaHastaHost As ToolStripControlHost

    Friend Class GridRowData
        Public Property IDCompra As Integer
        Public Property Fecha As Date
        Public Property IDProveedor As Short
        Public Property ProveedorNombre As String
        Public Property FacturaNumero As String
        Public Property Importe As Decimal?
        Public Property Cerrada As Boolean
    End Class

    Private mlistComprasBase As List(Of GridRowData)
    Private mlistComprasFiltradaYOrdenada As List(Of GridRowData)

    Private mSkipFilterData As Boolean = False
    Private mBusquedaAplicada As Boolean = False
    Private mReportSelectionFormula As String

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder
#End Region

#Region "Form stuff"
    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.IMAGE_COMPRAS_32)

        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        ' Filtro de período
        InicializarFiltroDeFechas()
        comboboxPeriodoTipo.Items.AddRange({"Día:", "Semana:", "Mes:", "Fecha"})
        comboboxPeriodoTipo.SelectedIndex = 2

        pFillAndRefreshLists.Proveedor(comboboxProveedor.ComboBox, True, True)

        comboboxFacturaNumero.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_ITEM_COMPLETE_MALE, My.Resources.STRING_ITEM_EMPTY_MALE})
        comboboxFacturaNumero.SelectedIndex = 0

        comboboxCerrada.Items.AddRange({My.Resources.STRING_ITEM_ALL_FEMALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxCerrada.SelectedIndex = 0

        mSkipFilterData = False

        mOrdenColumna = columnIDCompra
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
    Friend Sub RefreshData(Optional ByVal PositionIDCompra As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim FechaDesde As Date
        Dim FechaHasta As Date

        Me.Cursor = Cursors.WaitCursor

        Select Case comboboxPeriodoTipo.SelectedIndex
            Case 0  ' Día
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
            Case 1  ' Semana
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
            Case 2  ' Mes
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
            Case 3  ' Fecha
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
                mlistComprasBase = (From c In dbContext.Compra
                                    Group Join p In dbContext.Proveedor On c.IDProveedor Equals p.IDProveedor Into Proveedores_Group = Group
                                    From pg In Proveedores_Group.DefaultIfEmpty
                                    Where c.Fecha >= FechaDesde And c.Fecha <= FechaHasta
                                    Select New GridRowData With {.IDCompra = c.IDCompra, .Fecha = c.Fecha, .IDProveedor = If(pg Is Nothing, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT, c.IDProveedor.Value), .ProveedorNombre = If(c.IDProveedor Is Nothing, "", pg.Nombre), .FacturaNumero = c.FacturaNumero, .Importe = c.CompraDetalles.Sum(Function(cd) cd.Importe), .Cerrada = c.Cerrada}).ToList
            End Using

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Compras.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDCompra = 0
            Else
                PositionIDCompra = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDCompra
            End If
        End If

        FilterData()

        If PositionIDCompra <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDCompra = PositionIDCompra Then
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
                    Case CardonerSistemas.Constants.COMBOBOX_ALLYESNO_ALL_LISTINDEX       ' Todas
                    Case CardonerSistemas.Constants.COMBOBOX_ALLYESNO_YES_LISTINDEX       ' Sí
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Compra.Cerrada} = 1"
                        mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.Where(Function(c) c.Cerrada).ToList
                    Case CardonerSistemas.Constants.COMBOBOX_ALLYESNO_NO_LISTINDEX        ' No
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Compra.Cerrada} = 0"
                        mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.Where(Function(c) Not c.Cerrada).ToList
                End Select

                Select Case mlistComprasFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Compras para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Compra.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Compras.", mlistComprasFiltradaYOrdenada.Count)
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
            Case columnIDCompra.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.IDCompra).ToList
                Else
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.IDCompra).ToList
                End If
            Case columnFecha.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Fecha).ThenBy(Function(dgrd) dgrd.IDCompra).ToList
                Else
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Fecha).ThenByDescending(Function(dgrd) dgrd.IDCompra).ToList
                End If
            Case columnProveedor.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.ProveedorNombre).ThenBy(Function(dgrd) dgrd.Fecha).ThenBy(Function(dgrd) dgrd.IDCompra).ToList
                Else
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.ProveedorNombre).ThenByDescending(Function(dgrd) dgrd.Fecha).ThenByDescending(Function(dgrd) dgrd.IDCompra).ToList
                End If
            Case columnFacturaNumero.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.FacturaNumero).ThenBy(Function(dgrd) dgrd.IDCompra).ToList
                Else
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.FacturaNumero).ThenByDescending(Function(dgrd) dgrd.IDCompra).ToList
                End If
            Case columnImporte.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Importe).ThenBy(Function(dgrd) dgrd.IDCompra).ToList
                Else
                    mlistComprasFiltradaYOrdenada = mlistComprasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Importe).ThenByDescending(Function(dgrd) dgrd.IDCompra).ToList
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
            Case 0  ' Día
                comboboxPeriodoValor.Items.AddRange({"Hoy", "Ayer", "Anteayer", "Últimos 2", "Últimos 3", "Últimos 4"})
            Case 1  ' Semana
                comboboxPeriodoValor.Items.AddRange({"Actual", "Anterior", "Últimas 2", "Últimas 3"})
            Case 2  ' Mes
                comboboxPeriodoValor.Items.AddRange({"Actual", "Anterior", "Últimos 2", "Últimos 3"})
            Case 3  ' Fecha
                comboboxPeriodoValor.Items.AddRange({"es igual a:", "es posterior a:", "es anterior a:", "está entre:"})
        End Select
        comboboxPeriodoValor.SelectedIndex = 0
    End Sub

    Private Sub PeriodoValorSeleccionar() Handles comboboxPeriodoValor.SelectedIndexChanged
        datetimepickerFechaDesdeHost.Visible = (comboboxPeriodoTipo.SelectedIndex = 3)
        labelPeriodoFechaY.Visible = (comboboxPeriodoTipo.SelectedIndex = 3 And comboboxPeriodoValor.SelectedIndex = 3)
        datetimepickerFechaHastaHost.Visible = (comboboxPeriodoTipo.SelectedIndex = 3 And comboboxPeriodoValor.SelectedIndex = 3)
        RefreshData()
    End Sub

    Private Sub FechaCambiar() Handles datetimepickerFechaDesdeHost.TextChanged, datetimepickerFechaHastaHost.TextChanged
        RefreshData()
    End Sub

    Private Sub CambioFiltros() Handles comboboxProveedor.SelectedIndexChanged, comboboxFacturaNumero.SelectedIndexChanged, comboboxCerrada.SelectedIndexChanged
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
        If Permisos.VerificarPermiso(Permisos.COMPRA_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formCompra.LoadAndShow(True, Me, 0)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Compra para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Not Permisos.VerificarPermiso(Permisos.COMPRA_EDITAR) Then
                Exit Sub
            End If

            If CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).Cerrada AndAlso Not Permisos.VerificarPermiso(Permisos.COMPRA_EDITAR_CERRADA, False) Then
                MsgBox("La Compra está cerrada y no tiene autorización para editarla.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formCompra.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDCompra)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Compra para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Not Permisos.VerificarPermiso(Permisos.COMPRA_ELIMINAR) Then
                Exit Sub
            End If

            If CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).Cerrada AndAlso Not Permisos.VerificarPermiso(Permisos.COMPRA_ELIMINAR_CERRADA, False) Then
                MsgBox("La Compra está cerrada y no tiene autorización para eliminarla.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            Using dbContext = New CSBomberosContext(True)
                Dim GridRowDataActual = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)
                Dim Mensaje As String

                Mensaje = String.Format("Se eliminará la Compra seleccionada.{0}{0}Número: {1}{0}Fecha: {2}{0}Proveedor: {3}{0}Importe: {4}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.IDCompra, GridRowDataActual.Fecha.ToShortDateString(), GridRowDataActual.ProveedorNombre, FormatCurrency(GridRowDataActual.Importe))
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                    Try
                        dbContext.Compra.Remove(dbContext.Compra.Find(GridRowDataActual.IDCompra))
                        dbContext.SaveChanges()

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                            Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                MsgBox("No se puede eliminar la Compra porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Me.Cursor = Cursors.Default
                        Exit Sub

                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar la Compra.")
                    End Try

                    RefreshData()
                End If
            End Using

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Compra para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formCompra.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDCompra)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class