Public Class formComprobantes

#Region "Declarations"

    Private WithEvents datetimepickerFechaDesdeHost As ToolStripControlHost
    Private WithEvents datetimepickerFechaHastaHost As ToolStripControlHost

    Friend Property OperacionTipo As String

    Friend Class GridRowData
        Public Property IDComprobante As Integer
        Public Property OperacionTipo As String
        Public Property OperacionTipoNombre As String
        Public Property IDComprobanteTipo As Byte
        Public Property ComprobanteTipoNombre As String
        Public Property Fecha As Date
        Public Property IDEntidad As Short
        Public Property EntidadNombre As String
        Public Property NumeroCompleto As String
        Public Property FechaVencimiento As Date?
        Public Property IDArea As Short?
        Public Property EsBienUso As Boolean
        Public Property Importe As Decimal
    End Class

    Private mlistComprobantesBase As List(Of GridRowData)
    Private mlistComprobantesFiltradaYOrdenada As List(Of GridRowData)

    Private mSkipFilterData As Boolean
    Private mReportSelectionFormula As String

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder

#End Region

#Region "Form stuff"

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageFacturaCompra32)
        If OperacionTipo = Constantes.OperacionTipoCompra Then
            Me.Text = "Comprobantes de " & My.Resources.STRING_OPERACIONTIPO_COMPRA
            labelEntidad.Text = "Proveedor:"
            columnEntidad.HeaderText = "Proveedor"
        ElseIf OperacionTipo = Constantes.OperacionTipoCompra Then
            Me.Text = "Comprobantes de " & My.Resources.STRING_OPERACIONTIPO_VENTA
            labelEntidad.Text = "Cliente:"
            columnEntidad.HeaderText = "Cliente"
        Else
            Me.Text = "Comprobantes"
            labelEntidad.Text = "Entidad:"
            columnEntidad.HeaderText = "Entidad"
        End If

        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        ' Filtro de Tipos de Comprobantes
        comboboxOperacionTipo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_OPERACIONTIPO_COMPRA, My.Resources.STRING_OPERACIONTIPO_VENTA})
        If String.IsNullOrWhiteSpace(OperacionTipo) Then
            comboboxOperacionTipo.SelectedIndex = 0
            comboboxOperacionTipo.Visible = True
        ElseIf OperacionTipo = Constantes.OperacionTipoCompra Then
            comboboxOperacionTipo.SelectedIndex = 1
            comboboxOperacionTipo.Visible = False
        ElseIf OperacionTipo = Constantes.OperacionTipoVenta Then
            comboboxOperacionTipo.SelectedIndex = 2
            comboboxOperacionTipo.Visible = False
        Else
            comboboxOperacionTipo.SelectedIndex = 0
            comboboxOperacionTipo.Visible = True
        End If

        ' Filtro de período
        InicializarFiltroDeFechas()
        comboboxPeriodoTipo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, "Día:", "Semana:", "Mes:", "Fecha"})
        comboboxPeriodoTipo.SelectedIndex = 3

        Using context As New CSBomberosContext(True)
            ListasComprobantes.LlenarComboBoxEntidades(context, comboboxEntidad.ComboBox, Constantes.OperacionTipoCompra, True, False)
            ListasComunes.LlenarComboBoxAreasConCuartel(context, comboboxArea.ComboBox, True, True, , , True)
        End Using
        comboboxEsBienUso.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxEsBienUso.SelectedIndex = 0

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

    Friend Sub RefreshData(Optional ByVal PositionIDComprobante As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
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
                If String.IsNullOrWhiteSpace(OperacionTipo) Then
                    mlistComprobantesBase = (From c In dbContext.Comprobante
                                             Join ct In dbContext.ComprobanteTipo On c.IDComprobanteTipo Equals ct.IDComprobanteTipo
                                             Join e In dbContext.Entidad On c.IDEntidad Equals e.IDEntidad
                                             Where c.Fecha >= FechaDesde And c.Fecha <= FechaHasta
                                             Select New GridRowData With {.IDComprobante = c.IDComprobante, .OperacionTipo = ct.OperacionTipo, .OperacionTipoNombre = CStr(If(ct.OperacionTipo = Constantes.OperacionTipoCompra, My.Resources.STRING_OPERACIONTIPO_COMPRA, My.Resources.STRING_OPERACIONTIPO_VENTA)), .IDComprobanteTipo = c.IDComprobanteTipo, .ComprobanteTipoNombre = ct.Nombre, .Fecha = c.Fecha, .IDEntidad = c.IDEntidad, .EntidadNombre = e.Nombre, .NumeroCompleto = CStr(If(ct.Letra Is Nothing, c.NumeroCompleto, ct.Letra + "-" + c.NumeroCompleto)), .FechaVencimiento = c.FechaVencimiento, .IDArea = c.IDArea, .EsBienUso = c.EsBienUso, .Importe = c.Importe}).ToList

                Else
                    mlistComprobantesBase = (From c In dbContext.Comprobante
                                             Join ct In dbContext.ComprobanteTipo On c.IDComprobanteTipo Equals ct.IDComprobanteTipo
                                             Join e In dbContext.Entidad On c.IDEntidad Equals e.IDEntidad
                                             Where ct.OperacionTipo = OperacionTipo And c.Fecha >= FechaDesde And c.Fecha <= FechaHasta
                                             Select New GridRowData With {.IDComprobante = c.IDComprobante, .OperacionTipo = ct.OperacionTipo, .OperacionTipoNombre = CStr(If(ct.OperacionTipo = Constantes.OperacionTipoCompra, My.Resources.STRING_OPERACIONTIPO_COMPRA, My.Resources.STRING_OPERACIONTIPO_VENTA)), .IDComprobanteTipo = c.IDComprobanteTipo, .ComprobanteTipoNombre = ct.Nombre, .Fecha = c.Fecha, .IDEntidad = c.IDEntidad, .EntidadNombre = e.Nombre, .NumeroCompleto = CStr(If(ct.Letra Is Nothing, c.NumeroCompleto, ct.Letra + "-" + c.NumeroCompleto)), .FechaVencimiento = c.FechaVencimiento, .IDArea = c.IDArea, .EsBienUso = c.EsBienUso, .Importe = c.Importe}).ToList
                End If

            End Using

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Comprobantes.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDComprobante = 0
            Else
                PositionIDComprobante = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDComprobante
            End If
        End If

        FilterData()

        If PositionIDComprobante <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDComprobante = PositionIDComprobante Then
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
                mlistComprobantesFiltradaYOrdenada = mlistComprobantesBase.ToList

                ' Filtro inicial por Tipos de Comprobante
                If comboboxOperacionTipo.SelectedIndex = 0 Then
                    ' Todos los tipos de comprobantes
                    mlistComprobantesFiltradaYOrdenada = mlistComprobantesBase.ToList
                ElseIf comboboxComprobanteTipo.SelectedIndex = 0 Then
                    ' Todos los comprobantes según la Operación (Compra o Venta)
                    mlistComprobantesFiltradaYOrdenada = mlistComprobantesBase.Where(Function(comp) comp.OperacionTipo = Choose(comboboxOperacionTipo.SelectedIndex, Constantes.OperacionTipoCompra, Constantes.OperacionTipoVenta).ToString).ToList
                Else
                    ' Tipo de comprobante seleccionado
                    mlistComprobantesFiltradaYOrdenada = mlistComprobantesBase.Where(Function(comp) comp.IDComprobanteTipo = CByte(comboboxComprobanteTipo.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Entidad
                If comboboxEntidad.SelectedIndex > 0 Then
                    mlistComprobantesFiltradaYOrdenada = mlistComprobantesFiltradaYOrdenada.Where(Function(c) c.IDEntidad = CShort(comboboxEntidad.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Áreas
                Select Case comboboxArea.SelectedIndex
                    Case 0
                    Case 1
                        mlistComprobantesFiltradaYOrdenada = mlistComprobantesFiltradaYOrdenada.Where(Function(c) c.IDArea Is Nothing).ToList
                    Case Else
                        mlistComprobantesFiltradaYOrdenada = mlistComprobantesFiltradaYOrdenada.Where(Function(c) c.IDArea.HasValue AndAlso c.IDArea.Value = CShort(comboboxArea.ComboBox.SelectedValue)).ToList
                End Select

                ' Filtro por Bien de uso
                Select Case comboboxEsBienUso.SelectedIndex
                    Case 0
                    Case 1
                        mlistComprobantesFiltradaYOrdenada = mlistComprobantesFiltradaYOrdenada.Where(Function(c) c.EsBienUso).ToList
                    Case 2
                        mlistComprobantesFiltradaYOrdenada = mlistComprobantesFiltradaYOrdenada.Where(Function(c) Not c.EsBienUso).ToList
                End Select

                Select Case mlistComprobantesFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = "No hay Comprobantes para mostrar."
                    Case 1
                        statuslabelMain.Text = "Se muestra 1 Comprobante."
                    Case Else
                        statuslabelMain.Text = $"Se muestran {mlistComprobantesFiltradaYOrdenada.Count} Comprobante."
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
                    mlistComprobantesFiltradaYOrdenada = mlistComprobantesFiltradaYOrdenada.OrderBy(Function(c) c.Fecha).ThenBy(Function(c) c.EntidadNombre).ThenBy(Function(c) c.NumeroCompleto).ToList
                Else
                    mlistComprobantesFiltradaYOrdenada = mlistComprobantesFiltradaYOrdenada.OrderByDescending(Function(c) c.Fecha).ThenByDescending(Function(c) c.EntidadNombre).ThenByDescending(Function(c) c.NumeroCompleto).ToList
                End If
            Case columnEntidad.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprobantesFiltradaYOrdenada = mlistComprobantesFiltradaYOrdenada.OrderBy(Function(c) c.EntidadNombre).ThenBy(Function(c) c.NumeroCompleto).ToList
                Else
                    mlistComprobantesFiltradaYOrdenada = mlistComprobantesFiltradaYOrdenada.OrderByDescending(Function(c) c.EntidadNombre).ThenByDescending(Function(c) c.NumeroCompleto).ToList
                End If
            Case columnNumeroCompleto.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprobantesFiltradaYOrdenada = mlistComprobantesFiltradaYOrdenada.OrderBy(Function(c) c.NumeroCompleto).ThenBy(Function(c) c.EntidadNombre).ToList
                Else
                    mlistComprobantesFiltradaYOrdenada = mlistComprobantesFiltradaYOrdenada.OrderByDescending(Function(c) c.NumeroCompleto).ThenByDescending(Function(c) c.EntidadNombre).ToList
                End If
            Case columnFechaVencimiento.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprobantesFiltradaYOrdenada = mlistComprobantesFiltradaYOrdenada.OrderBy(Function(c) c.FechaVencimiento).ThenBy(Function(c) c.EntidadNombre).ThenBy(Function(c) c.NumeroCompleto).ToList
                Else
                    mlistComprobantesFiltradaYOrdenada = mlistComprobantesFiltradaYOrdenada.OrderByDescending(Function(c) c.FechaVencimiento).ThenByDescending(Function(c) c.EntidadNombre).ThenByDescending(Function(c) c.NumeroCompleto).ToList
                End If
            Case columnImporte.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistComprobantesFiltradaYOrdenada = mlistComprobantesFiltradaYOrdenada.OrderBy(Function(c) c.Importe).ThenBy(Function(c) c.EntidadNombre).ThenBy(Function(c) c.NumeroCompleto).ToList
                Else
                    mlistComprobantesFiltradaYOrdenada = mlistComprobantesFiltradaYOrdenada.OrderByDescending(Function(c) c.Importe).ThenByDescending(Function(c) c.EntidadNombre).ThenByDescending(Function(c) c.NumeroCompleto).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistComprobantesFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        mOrdenColumna.HeaderCell.SortGlyphDirection = mOrdenTipo
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub OperacionTipoChanged() Handles comboboxOperacionTipo.SelectedIndexChanged
        Select Case comboboxOperacionTipo.SelectedIndex
            Case -1, 0
                comboboxComprobanteTipo.ComboBox.DataSource = Nothing
                comboboxComprobanteTipo.Items.Clear()
                comboboxComprobanteTipo.Enabled = False
            Case 1
                Using context As New CSBomberosContext(True)
                    ListasComprobantes.LlenarComboBoxComprobantesTipos(context, comboboxComprobanteTipo.ComboBox, Constantes.OperacionTipoCompra, True, False)
                End Using
                comboboxComprobanteTipo.Enabled = True
                comboboxComprobanteTipo.SelectedIndex = 0
            Case 2
                Using context As New CSBomberosContext(True)
                    ListasComprobantes.LlenarComboBoxComprobantesTipos(context, comboboxComprobanteTipo.ComboBox, Constantes.OperacionTipoVenta, True, False)
                End Using
                comboboxComprobanteTipo.Enabled = True
                comboboxComprobanteTipo.SelectedIndex = 0
        End Select
    End Sub

    Private Sub ComprobanteTipoChanged() Handles comboboxComprobanteTipo.SelectedIndexChanged
        FilterData()
    End Sub

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

    Private Sub CambioFiltros() Handles comboboxEntidad.SelectedIndexChanged, comboboxArea.SelectedIndexChanged, comboboxEsBienUso.SelectedIndexChanged
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
        If Permisos.VerificarPermiso(Permisos.COMPROBANTE_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formComprobante.LoadAndShow(True, Me, OperacionTipo, 0)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Comprobante para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Not Permisos.VerificarPermiso(Permisos.COMPROBANTE_EDITAR) Then
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formComprobante.LoadAndShow(True, Me, OperacionTipo, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDComprobante)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Comprobante para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Not Permisos.VerificarPermiso(Permisos.COMPROBANTE_ELIMINAR) Then
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            Using dbContext = New CSBomberosContext(True)
                Dim GridRowDataActual = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)
                Dim Mensaje As String

                Mensaje = String.Format("Se eliminará el Comprobante seleccionado.{0}{0}Operación: {1}{0}Tipo: {2}{0}Número: {3}{0}Fecha: {4}{0}Entidad: {5}{0}Importe: {6}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.OperacionTipoNombre, GridRowDataActual.ComprobanteTipoNombre, GridRowDataActual.NumeroCompleto, GridRowDataActual.Fecha.ToShortDateString(), GridRowDataActual.EntidadNombre, FormatCurrency(GridRowDataActual.Importe))
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                    Try
                        dbContext.Comprobante.Remove(dbContext.Comprobante.Find(GridRowDataActual.IDComprobante))
                        dbContext.SaveChanges()

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                            Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                MsgBox("No se puede eliminar el Comprobante porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Me.Cursor = Cursors.Default
                        Exit Sub

                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar el Comprobante.")
                    End Try

                    RefreshData()
                End If
            End Using

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Comprobante para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formComprobante.LoadAndShow(False, Me, OperacionTipo, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDComprobante)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class