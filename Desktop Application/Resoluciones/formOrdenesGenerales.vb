Public Class formOrdenesGenerales

#Region "Declarations"

    Private WithEvents datetimepickerFechaDesdeHost As ToolStripControlHost
    Private WithEvents datetimepickerFechaHastaHost As ToolStripControlHost

    Friend Class GridRowData
        Public Property IDOrdenGeneral As Integer
        Public Property Numero As Short
        Public Property SubNumero As Byte?
        Public Property Fecha As Date?
        Public Property NumeroCompleto As String
        Public Property Descripcion As String
        Public Property IDOrdenGeneralCategoria As Byte?
    End Class

    Private mdbContext As New CSBomberosContext(True)
    Private mlistOrdenesGeneralesBase As List(Of GridRowData)
    Private mlistOrdenesGeneralesFiltradaYOrdenada As List(Of GridRowData)

    Private mSkipFilterData As Boolean

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder

#End Region

#Region "Form stuff"

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageOrdenGeneral32)

        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        ListasResoluciones.LlenarComboBoxOrdenesGeneralesCategorias(mdbContext, ComboBoxCategoria.ComboBox, True, False, True)

        ' Filtro de período
        InicializarFiltroDeFechas()
        CardonerSistemas.DateTime.FillPeriodTypesComboBox(comboboxPeriodoTipo.ComboBox, CardonerSistemas.DateTime.PeriodTypes.Month)

        mSkipFilterData = False

        mOrdenColumna = ColumnNumeroCompleto
        mOrdenTipo = SortOrder.Descending

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

    Private Sub Me_Closed() Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If

        If datetimepickerFechaDesdeHost IsNot Nothing Then
            datetimepickerFechaDesdeHost.Control.Dispose()
            datetimepickerFechaDesdeHost.Dispose()
            datetimepickerFechaDesdeHost = Nothing
        End If
        If datetimepickerFechaHastaHost IsNot Nothing Then
            datetimepickerFechaHastaHost.Control.Dispose()
            datetimepickerFechaHastaHost.Dispose()
            datetimepickerFechaHastaHost = Nothing
        End If
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub RefreshData(Optional ByVal PositionIDOrdenGeneral As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim FechaDesde As Date
        Dim FechaHasta As Date

        Me.Cursor = Cursors.WaitCursor

        CardonerSistemas.DateTime.GetDatesFromPeriodTypeAndValue(CType(comboboxPeriodoTipo.SelectedIndex, CardonerSistemas.DateTime.PeriodTypes), CByte(comboboxPeriodoValor.SelectedIndex), FechaDesde, FechaHasta, CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value, CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Value)

        Try
            mlistOrdenesGeneralesBase = (From og In mdbContext.OrdenGeneral
                                         Where og.Fecha >= FechaDesde AndAlso og.Fecha <= FechaHasta
                                         Select New GridRowData With {.IDOrdenGeneral = og.IDOrdenGeneral, .Numero = og.Numero, .SubNumero = og.SubNumero, .Fecha = og.Fecha, .NumeroCompleto = og.NumeroCompleto, .Descripcion = og.Descripcion, .IDOrdenGeneralCategoria = og.IDOrdenGeneralCategoria}).ToList()

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Órdenes Generales.")
            Me.Cursor = Cursors.Default
            Return
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDOrdenGeneral = 0
            Else
                PositionIDOrdenGeneral = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDOrdenGeneral
            End If
        End If

        FilterData()

        If PositionIDOrdenGeneral <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDOrdenGeneral = PositionIDOrdenGeneral Then
                    datagridviewMain.CurrentCell = CurrentRowChecked.Cells(0)
                    Return
                End If
            Next
        End If
    End Sub

    Private Sub FilterData()

        If Not mSkipFilterData Then
            Me.Cursor = Cursors.WaitCursor

            Try
                ' Inicializo las variables
                mlistOrdenesGeneralesFiltradaYOrdenada = mlistOrdenesGeneralesBase

                ' Filtro por Categoría
                If ComboBoxCategoria.SelectedIndex > 0 Then
                    Select Case CType(ComboBoxCategoria.SelectedItem, OrdenGeneralCategoria).IDOrdenGeneralCategoria
                        Case CardonerSistemas.Constants.FIELD_VALUE_EMPTY_BYTE
                            mlistOrdenesGeneralesFiltradaYOrdenada = mlistOrdenesGeneralesFiltradaYOrdenada.Where(Function(og) Not og.IDOrdenGeneralCategoria.HasValue).ToList
                        Case Else
                            mlistOrdenesGeneralesFiltradaYOrdenada = mlistOrdenesGeneralesFiltradaYOrdenada.Where(Function(og) og.IDOrdenGeneralCategoria.HasValue AndAlso og.IDOrdenGeneralCategoria.Value = CByte(ComboBoxCategoria.ComboBox.SelectedValue)).ToList
                    End Select
                End If

                Select Case mlistOrdenesGeneralesFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = "No hay Órdenes Generales para mostrar."
                    Case 1
                        statuslabelMain.Text = "Se muestra 1 Órden General."
                    Case Else
                        statuslabelMain.Text = $"Se muestran {mlistOrdenesGeneralesFiltradaYOrdenada.Count} Órdenes Generales."
                End Select

            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al filtrar los datos.")
                Me.Cursor = Cursors.Default
                Return
            End Try

            OrderData()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub OrderData()
        ' Realizo las rutinas de ordenamiento
        Select Case mOrdenColumna.Name
            Case ColumnNumeroCompleto.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistOrdenesGeneralesFiltradaYOrdenada = mlistOrdenesGeneralesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Numero).ThenBy(Function(dgrd) dgrd.SubNumero).ToList
                Else
                    mlistOrdenesGeneralesFiltradaYOrdenada = mlistOrdenesGeneralesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Numero).ThenByDescending(Function(dgrd) dgrd.SubNumero).ToList
                End If
            Case ColumnFecha.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistOrdenesGeneralesFiltradaYOrdenada = mlistOrdenesGeneralesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Fecha).ThenBy(Function(dgrd) dgrd.Numero).ThenBy(Function(dgrd) dgrd.SubNumero).ToList
                Else
                    mlistOrdenesGeneralesFiltradaYOrdenada = mlistOrdenesGeneralesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Fecha).ThenByDescending(Function(dgrd) dgrd.Numero).ThenByDescending(Function(dgrd) dgrd.SubNumero).ToList
                End If
            Case ColumnDescripcion.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistOrdenesGeneralesFiltradaYOrdenada = mlistOrdenesGeneralesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Descripcion).ThenBy(Function(dgrd) dgrd.Numero).ThenBy(Function(dgrd) dgrd.SubNumero).ToList
                Else
                    mlistOrdenesGeneralesFiltradaYOrdenada = mlistOrdenesGeneralesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Descripcion).ThenByDescending(Function(dgrd) dgrd.Numero).ThenByDescending(Function(dgrd) dgrd.SubNumero).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistOrdenesGeneralesFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        mOrdenColumna.HeaderCell.SortGlyphDirection = mOrdenTipo
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub PeriodoTipoSeleccionar() Handles comboboxPeriodoTipo.SelectedIndexChanged
        CardonerSistemas.DateTime.FillPeriodValuesComboBox(comboboxPeriodoValor.ComboBox, CType(comboboxPeriodoTipo.SelectedIndex, CardonerSistemas.DateTime.PeriodTypes))
    End Sub

    Private Sub PeriodoValorSeleccionar() Handles comboboxPeriodoValor.SelectedIndexChanged
        datetimepickerFechaDesdeHost.Visible = (comboboxPeriodoTipo.SelectedIndex = CInt(CardonerSistemas.DateTime.PeriodTypes.Range))
        labelPeriodoFechaY.Visible = (comboboxPeriodoTipo.SelectedIndex = CInt(CardonerSistemas.DateTime.PeriodTypes.Range) AndAlso comboboxPeriodoValor.SelectedIndex = CInt(CardonerSistemas.DateTime.PeriodRangeValues.DateBetween))
        datetimepickerFechaHastaHost.Visible = labelPeriodoFechaY.Visible
        RefreshData()
    End Sub

    Private Sub FechaCambiar() Handles datetimepickerFechaDesdeHost.TextChanged, datetimepickerFechaHastaHost.TextChanged
        RefreshData()
    End Sub

    Private Sub CambioFiltros(sender As Object, e As EventArgs) Handles ComboBoxCategoria.SelectedIndexChanged
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
        If Not Permisos.VerificarPermiso(Permisos.ORDENGENERAL_AGREGAR) Then
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        datagridviewMain.Enabled = False
        formOrdenGeneral.LoadAndShow(True, Me, 0)
        datagridviewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Órden General para editar.", vbInformation, My.Application.Info.Title)
            Return
        End If
        If Not (Permisos.VerificarPermiso(Permisos.ORDENGENERAL_EDITAR)) Then
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        datagridviewMain.Enabled = False
        formOrdenGeneral.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDOrdenGeneral)
        datagridviewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        Dim ordenGeneralActual As OrdenGeneral
        Dim Mensaje As String

        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Órden General para eliminar.", vbInformation, My.Application.Info.Title)
            Return
        End If
        If Not Permisos.VerificarPermiso(Permisos.ORDENGENERAL_ELIMINAR) Then
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        ordenGeneralActual = mdbContext.OrdenGeneral.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDOrdenGeneral)
        Me.Cursor = Cursors.Default
        Mensaje = $"Se eliminará la Órden General seleccionada.{vbCrLf}{vbCrLf}Número: {ordenGeneralActual.NumeroCompleto}{vbCrLf}{vbCrLf}¿Confirma la eliminación definitiva?"
        If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.No Then
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            mdbContext.OrdenGeneral.Remove(ordenGeneralActual)
            mdbContext.SaveChanges()

        Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
            Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                    MsgBox("No se puede eliminar la Órden General porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
            End Select
            Me.Cursor = Cursors.Default
            Exit Sub

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar la Órden General.")
        End Try

        RefreshData()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Órden General para ver.", vbInformation, My.Application.Info.Title)
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        datagridviewMain.Enabled = False
        formOrdenGeneral.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDOrdenGeneral)
        datagridviewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

#End Region

End Class