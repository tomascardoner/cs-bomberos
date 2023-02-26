Public Class formAcademias

#Region "Declarations"

    Private WithEvents datetimepickerFechaDesdeHost As ToolStripControlHost
    Private WithEvents datetimepickerFechaHastaHost As ToolStripControlHost

    Friend Class GridRowData
        Public Property IDAcademia As Integer
        Public Property IDCuartel As Byte
        Public Property CuartelNombre As String
        Public Property IDAcademiaTipo As Byte
        Public Property AcademiaTipoNombre As String
        Public Property Fecha As Date
    End Class

    Private mdbContext As New CSBomberosContext(True)
    Private mlistAcademiasBase As List(Of GridRowData)
    Private mlistAcademiasFiltradaYOrdenada As List(Of GridRowData)

    Private mSkipFilterData As Boolean

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder

#End Region

#Region "Form stuff"

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageAcademia32)

        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        ListasComunes.LlenarComboBoxCuarteles(mdbContext, comboboxCuartel.ComboBox, True, False)

        ' Filtro de período
        InicializarFiltroDeFechas()
        CardonerSistemas.DateTime.FillPeriodTypesComboBox(comboboxPeriodoTipo.ComboBox, CardonerSistemas.DateTime.PeriodTypes.Month)

        ListasAcademias.LlenarComboBoxTipos(mdbContext, comboboxAcademiaTipo.ComboBox, True, False)

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

    Friend Sub RefreshData(Optional ByVal PositionIDAcademia As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim FechaDesde As Date
        Dim FechaHasta As Date

        Me.Cursor = Cursors.WaitCursor

        CardonerSistemas.DateTime.GetDatesFromPeriodTypeAndValue(CType(comboboxPeriodoTipo.SelectedIndex, CardonerSistemas.DateTime.PeriodTypes), CByte(comboboxPeriodoValor.SelectedIndex), FechaDesde, FechaHasta, CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value, CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Value)

        Try
            mlistAcademiasBase = (From a In mdbContext.Academia
                                  Join c In mdbContext.Cuartel On a.IDCuartel Equals c.IDCuartel
                                  Join at In mdbContext.AcademiaTipo On a.IDAcademiaTipo Equals at.IDAcademiaTipo
                                  Where a.Fecha >= FechaDesde And a.Fecha <= FechaHasta
                                  Select New GridRowData With {.IDAcademia = a.IDAcademia, .IDCuartel = c.IDCuartel, .CuartelNombre = c.Nombre, .IDAcademiaTipo = a.IDAcademiaTipo, .AcademiaTipoNombre = at.Nombre, .Fecha = a.Fecha}).ToList

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Academias.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDAcademia = 0
            Else
                PositionIDAcademia = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDAcademia
            End If
        End If

        FilterData()

        If PositionIDAcademia <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDAcademia = PositionIDAcademia Then
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
                mlistAcademiasFiltradaYOrdenada = mlistAcademiasBase.ToList

                ' Filtro por Cuartel
                If comboboxCuartel.SelectedIndex > 0 Then
                    mlistAcademiasFiltradaYOrdenada = mlistAcademiasFiltradaYOrdenada.Where(Function(s) s.IDCuartel = CByte(comboboxCuartel.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Academia Tipo
                If comboboxAcademiaTipo.SelectedIndex > 0 Then
                    mlistAcademiasFiltradaYOrdenada = mlistAcademiasFiltradaYOrdenada.Where(Function(s) s.IDAcademiaTipo = CByte(comboboxAcademiaTipo.ComboBox.SelectedValue)).ToList
                End If

                Select Case mlistAcademiasFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Academias para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Academia.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Academias.", mlistAcademiasFiltradaYOrdenada.Count)
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
                    mlistAcademiasFiltradaYOrdenada = mlistAcademiasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.Fecha).ToList
                Else
                    mlistAcademiasFiltradaYOrdenada = mlistAcademiasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.Fecha).ToList
                End If
            Case columnFecha.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistAcademiasFiltradaYOrdenada = mlistAcademiasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Fecha).ThenBy(Function(dgrd) dgrd.CuartelNombre).ToList
                Else
                    mlistAcademiasFiltradaYOrdenada = mlistAcademiasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Fecha).ThenBy(Function(dgrd) dgrd.CuartelNombre).ToList
                End If
            Case columnAcademiaTipo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistAcademiasFiltradaYOrdenada = mlistAcademiasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.AcademiaTipoNombre).ThenBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.Fecha).ToList
                Else
                    mlistAcademiasFiltradaYOrdenada = mlistAcademiasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.AcademiaTipoNombre).ThenBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.Fecha).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistAcademiasFiltradaYOrdenada

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
        labelPeriodoFechaY.Visible = (comboboxPeriodoTipo.SelectedIndex = CInt(CardonerSistemas.DateTime.PeriodTypes.Range) And comboboxPeriodoValor.SelectedIndex = CInt(CardonerSistemas.DateTime.PeriodRangeValues.DateBetween))
        datetimepickerFechaHastaHost.Visible = labelPeriodoFechaY.Visible
        RefreshData()
    End Sub

    Private Sub FechaCambiar() Handles datetimepickerFechaDesdeHost.TextChanged, datetimepickerFechaHastaHost.TextChanged
        RefreshData()
    End Sub

    Private Sub CambioFiltros() Handles comboboxCuartel.SelectedIndexChanged, comboboxAcademiaTipo.SelectedIndexChanged
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
        If Permisos.VerificarPermiso(Permisos.ACADEMIA_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formAcademia.LoadAndShow(True, Me, 0)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Academia para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.ACADEMIA_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                formAcademia.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDAcademia)

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Academia para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.ACADEMIA_ELIMINAR) Then

                Me.Cursor = Cursors.WaitCursor

                Dim academiaActual As Academia = mdbContext.Academia.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDAcademia)
                Dim Mensaje As String

                Mensaje = String.Format("Se eliminará la Academia seleccionada.{0}{0}Fecha: {1}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, academiaActual.Fecha)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                    Try
                        mdbContext.Academia.Remove(academiaActual)
                        mdbContext.SaveChanges()

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                            Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                MsgBox("No se puede eliminar la Academia porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Me.Cursor = Cursors.Default
                        Exit Sub

                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar la Academia.")
                    End Try

                    RefreshData()
                End If

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Academia para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formAcademia.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDAcademia)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Asistencia_Click() Handles buttonAsistenciaMultiple.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Academia para asistir.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.ACADEMIA_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                formAcademiaAsistenciaManual.LoadAndShow(mdbContext.Academia.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDAcademia))

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

#End Region

End Class