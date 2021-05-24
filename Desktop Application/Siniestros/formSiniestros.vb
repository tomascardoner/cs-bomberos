Public Class formSiniestros

#Region "Declarations"

    Private WithEvents datetimepickerFechaDesdeHost As ToolStripControlHost
    Private WithEvents datetimepickerFechaHastaHost As ToolStripControlHost

    Friend Class GridRowData
        Public Property IDSiniestro As Integer
        Public Property IDCuartel As Byte
        Public Property CuartelNombre As String
        Public Property NumeroCompleto As String
        Public Property IDSiniestroRubro As Byte
        Public Property SiniestroRubroNombre As String
        Public Property IDSiniestroTipo As Byte
        Public Property SiniestroTipoNombre As String
        Public Property Clave As String
        Public Property ClaveNombre As String
        Public Property Fecha As Date
        Public Property Anulado As Boolean
    End Class

    Private mContext As New CSBomberosContext(True)
    Private mlistSiniestrosBase As List(Of GridRowData)
    Private mlistSiniestrosFiltradaYOrdenada As List(Of GridRowData)

    Private mSkipFilterData As Boolean = False

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder

#End Region

#Region "Form stuff"

    Friend Sub SetAppearance()
        ' Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.IMAGE_Siniestros_32)

        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        pFillAndRefreshLists.Cuartel(comboboxCuartel.ComboBox, True, False)
        Siniestros.LlenarComboBoxRubros(mContext, comboboxSiniestroRubro.ComboBox, True, False)
        Siniestros.LlenarComboBoxClaves(comboboxClave.ComboBox, True)

        ' Filtro de período
        InicializarFiltroDeFechas()
        comboboxPeriodoTipo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, "Día:", "Semana:", "Mes:", "Fecha"})
        comboboxPeriodoTipo.SelectedIndex = 3

        comboboxAnulado.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxAnulado.SelectedIndex = 2

        mSkipFilterData = False

        mOrdenColumna = columnNumero
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

    Private Sub Me_Closed() Handles Me.FormClosed
        mContext.Dispose()
        mContext = Nothing
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub RefreshData(Optional ByVal PositionIDSiniestro As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
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
            mlistSiniestrosBase = (From s In mContext.Siniestro
                                   Join c In mContext.Cuartel On s.IDCuartel Equals c.IDCuartel
                                   Join sr In mContext.SiniestroRubro On s.IDSiniestroRubro Equals sr.IDSiniestroRubro
                                   Join st In mContext.SiniestroTipo On s.IDSiniestroRubro Equals st.IDSiniestroRubro And s.IDSiniestroTipo Equals st.IDSiniestroTipo
                                   Where s.Fecha >= FechaDesde And s.Fecha <= FechaHasta
                                   Select New GridRowData With {.IDSiniestro = s.IDSiniestro, .IDCuartel = c.IDCuartel, .CuartelNombre = c.Nombre, .NumeroCompleto = s.NumeroCompleto, .IDSiniestroRubro = s.IDSiniestroRubro, .SiniestroRubroNombre = sr.Nombre, .IDSiniestroTipo = s.IDSiniestroTipo, .SiniestroTipoNombre = st.Nombre, .Clave = s.Clave, .ClaveNombre = s.ClaveNombre, .Fecha = s.Fecha, .Anulado = s.Anulado}).ToList

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Siniestros.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDSiniestro = 0
            Else
                PositionIDSiniestro = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDSiniestro
            End If
        End If

        FilterData()

        If PositionIDSiniestro <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDSiniestro = PositionIDSiniestro Then
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
                mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosBase.ToList

                ' Filtro por Cuartel
                If comboboxCuartel.SelectedIndex > 0 Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.Where(Function(s) s.IDCuartel = CByte(comboboxCuartel.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Siniestro Rubro
                If comboboxSiniestroRubro.SelectedIndex > 0 Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.Where(Function(s) s.IDSiniestroRubro = CByte(comboboxSiniestroRubro.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Siniestro Tipo
                If comboboxSiniestroTipo.SelectedIndex > 0 Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.Where(Function(s) s.IDSiniestroTipo = CByte(comboboxSiniestroTipo.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Clave
                If comboboxClave.SelectedIndex > 0 Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.Where(Function(s) s.Clave = CStr(comboboxClave.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Anulado
                Select Case comboboxAnulado.SelectedIndex
                    Case 0      ' Todos
                    Case 1      ' Sí
                        mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.Where(Function(s) s.Anulado).ToList
                    Case 2      ' No
                        mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.Where(Function(s) Not s.Anulado).ToList
                End Select

                Select Case mlistSiniestrosFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Siniestros para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Siniestro.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Siniestros.", mlistSiniestrosFiltradaYOrdenada.Count)
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
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                Else
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                End If
            Case columnNumero.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                Else
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.NumeroCompleto).ToList
                End If
            Case columnFecha.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Fecha).ThenBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                Else
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Fecha).ThenBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                End If
            Case columnSiniestroRubro.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.SiniestroRubroNombre).ThenBy(Function(dgrd) dgrd.SiniestroTipoNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                Else
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.SiniestroRubroNombre).ThenBy(Function(dgrd) dgrd.SiniestroTipoNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                End If
            Case columnSiniestroTipo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.SiniestroTipoNombre).ThenBy(Function(dgrd) dgrd.SiniestroRubroNombre).ThenBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                Else
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.SiniestroTipoNombre).ThenBy(Function(dgrd) dgrd.SiniestroRubroNombre).ThenBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                End If
            Case columnClave.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.ClaveNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                Else
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.ClaveNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                End If
            Case columnAnulado.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Anulado).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                Else
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Anulado).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistSiniestrosFiltradaYOrdenada

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

    Private Sub CambioFiltros() Handles comboboxCuartel.SelectedIndexChanged, comboboxSiniestroTipo.SelectedIndexChanged, comboboxClave.SelectedIndexChanged, comboboxAnulado.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub CambioRubro() Handles comboboxSiniestroRubro.SelectedIndexChanged
        Siniestros.LlenarComboBoxTipos(mContext, comboboxSiniestroTipo.ComboBox, CByte(comboboxSiniestroRubro.ComboBox.SelectedValue), True, False)
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
        If Permisos.VerificarPermiso(Permisos.Unidad_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formSiniestro.LoadAndShow(True, Me, 0)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Siniestro para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                formSiniestro.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSiniestro)

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Siniestro para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.SINIESTRO_ELIMINAR) Then

                Me.Cursor = Cursors.WaitCursor

                Using dbContext = New CSBomberosContext(True)
                    Dim siniestroActual As Siniestro = dbContext.Siniestro.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSiniestro)
                    Dim Mensaje As String
                    Mensaje = String.Format("Se eliminará el Siniestro seleccionado.{0}{0}{1}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, siniestroActual.NumeroCompleto)
                    If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                        Try
                            dbContext.Siniestro.Remove(siniestroActual)
                            dbContext.SaveChanges()

                        Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                            Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                                Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                    MsgBox("No se puede eliminar el Siniestro porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                            End Select
                            Me.Cursor = Cursors.Default
                            Exit Sub

                        Catch ex As Exception
                            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar el Siniestro.")
                        End Try

                        RefreshData()
                    End If
                End Using

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Siniestro para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formSiniestro.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSiniestro)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class