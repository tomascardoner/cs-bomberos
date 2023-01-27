Public Class formSanciones

#Region "Declarations"

    Private WithEvents datetimepickerFechaDesdeHost As ToolStripControlHost
    Private WithEvents datetimepickerFechaHastaHost As ToolStripControlHost
    Public WithEvents controlpersonaPersonaHost As ToolStripControlHost

    Friend Class GridRowData
        Public Property IDPersona As Integer
        Public Property IDSancion As Short
        Public Property ApellidoNombre As String
        Public Property IDCuartel As Byte
        Public Property SolicitudFecha As Date
        Public Property Estado As String
        Public Property EstadoNombre As String
        Public Property Motivo As String
    End Class

    Private mlistSancionesBase As List(Of GridRowData)
    Private mlistSancionesFiltradaYOrdenada As List(Of GridRowData)

    Private mSkipFilterData As Boolean
    Private mReportSelectionFormula As String

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder

#End Region

#Region "Form stuff"

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageSancion32)

        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        ' Filtro de período
        InicializarFiltroDeFechas()
        CardonerSistemas.DateTime.FillPeriodTypesComboBox(comboboxPeriodoTipo.ComboBox, CardonerSistemas.DateTime.PeriodTypes.Month)

        Using context As New CSBomberosContext(True)
            ListasComunes.LlenarComboBoxCuarteles(context, comboboxCuartel.ComboBox, True, False)
        End Using

        InicializarFiltroDePersonas()

        ListasSanciones.LlenarComboBoxEstadosSanciones(comboboxEstado.ComboBox, True, False)
        comboboxEstado.SelectedIndex = 1

        mSkipFilterData = False

        mOrdenColumna = columnFechaSolicitud
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

    Private Sub InicializarFiltroDePersonas()
        controlpersonaPersonaHost = New ToolStripControlHost(New ControlPersona()) With {
            .Width = 300,
            .DisplayStyle = ToolStripItemDisplayStyle.Text,
            .Visible = True
        }
        toolstripPersona.Items.Add(controlpersonaPersonaHost)
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub RefreshData(Optional ByVal PositionIDPersona As Integer = 0, Optional ByVal PositionIDSancion As Short = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim FechaDesde As Date
        Dim FechaHasta As Date

        Me.Cursor = Cursors.WaitCursor

        CardonerSistemas.DateTime.GetDatesFromPeriodTypeAndValue(CType(comboboxPeriodoTipo.SelectedIndex, CardonerSistemas.DateTime.PeriodTypes), CByte(comboboxPeriodoValor.SelectedIndex), FechaDesde, FechaHasta, CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value, CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Value)

        Try
            Using dbContext As New CSBomberosContext(True)
                mlistSancionesBase = (From ps In dbContext.PersonaSancion
                                      Join p In dbContext.Persona On ps.IDPersona Equals p.IDPersona
                                      Join c In dbContext.Cuartel On p.IDCuartel Equals c.IDCuartel
                                      Where ps.SolicitudFecha >= FechaDesde And ps.SolicitudFecha <= FechaHasta
                                      Select New GridRowData With {.IDPersona = ps.IDPersona, .IDSancion = ps.IDSancion, .ApellidoNombre = p.ApellidoNombre, .IDCuartel = c.IDCuartel, .SolicitudFecha = ps.SolicitudFecha, .Estado = ps.Estado, .EstadoNombre = ps.EstadoNombre, .Motivo = ps.SolicitudMotivo}).ToList
            End Using

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Sanciones.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDPersona = 0
                PositionIDSancion = 0
            Else
                PositionIDPersona = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDPersona
                PositionIDSancion = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDSancion
            End If
        End If

        FilterData()

        If PositionIDPersona <> 0 And PositionIDSancion <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDPersona = PositionIDPersona AndAlso CType(CurrentRowChecked.DataBoundItem, GridRowData).IDSancion = PositionIDSancion Then
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
                mlistSancionesFiltradaYOrdenada = mlistSancionesBase.ToList

                ' Filtro por Cuartel
                If comboboxCuartel.SelectedIndex > 0 Then
                    mlistSancionesFiltradaYOrdenada = mlistSancionesFiltradaYOrdenada.Where(Function(s) s.IDCuartel = CByte(comboboxCuartel.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Persona
                If CType(controlpersonaPersonaHost.Control, ControlPersona).IDPersona.HasValue Then
                    mlistSancionesFiltradaYOrdenada = mlistSancionesFiltradaYOrdenada.Where(Function(s) s.IDPersona = CType(controlpersonaPersonaHost.Control, ControlPersona).IDPersona.Value).ToList
                End If

                ' Filtro por Estado
                Select Case comboboxEstado.SelectedIndex
                    Case 0
                        ' Todos
                    Case 1
                        ' En proceso
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{PersonaSancion.Estado} = '" & Constantes.PersonaSancionEstadoEnProceso & "'"
                        mlistSancionesFiltradaYOrdenada = mlistSancionesFiltradaYOrdenada.Where(Function(s) s.Estado = Constantes.PersonaSancionEstadoEnProceso).ToList
                    Case 2
                        ' Aprobadas
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{PersonaSancion.Estado} = '" & Constantes.PersonaSancionEstadoAprobada & "'"
                        mlistSancionesFiltradaYOrdenada = mlistSancionesFiltradaYOrdenada.Where(Function(s) s.Estado = Constantes.PersonaSancionEstadoAprobada).ToList
                    Case 3
                        ' Desaprobadas
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{PersonaSancion.Estado} = '" & Constantes.PersonaSancionEstadoDesaprobada & "'"
                        mlistSancionesFiltradaYOrdenada = mlistSancionesFiltradaYOrdenada.Where(Function(s) s.Estado = Constantes.PersonaSancionEstadoDesaprobada).ToList
                End Select

                Select Case mlistSancionesFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Sanciones para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Sanción.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Sanciones.", mlistSancionesFiltradaYOrdenada.Count)
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
            Case columnPersona.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSancionesFiltradaYOrdenada = mlistSancionesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.ApellidoNombre).ThenBy(Function(dgrd) dgrd.SolicitudFecha).ToList
                Else
                    mlistSancionesFiltradaYOrdenada = mlistSancionesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.ApellidoNombre).ThenByDescending(Function(dgrd) dgrd.SolicitudFecha).ToList
                End If
            Case columnFechaSolicitud.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSancionesFiltradaYOrdenada = mlistSancionesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.SolicitudFecha).ThenBy(Function(dgrd) dgrd.ApellidoNombre).ToList
                Else
                    mlistSancionesFiltradaYOrdenada = mlistSancionesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.SolicitudFecha).ThenByDescending(Function(dgrd) dgrd.ApellidoNombre).ToList
                End If
            Case columnEstado.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSancionesFiltradaYOrdenada = mlistSancionesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.EstadoNombre).ThenBy(Function(dgrd) dgrd.SolicitudFecha).ThenBy(Function(dgrd) dgrd.ApellidoNombre).ToList
                Else
                    mlistSancionesFiltradaYOrdenada = mlistSancionesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.EstadoNombre).ThenByDescending(Function(dgrd) dgrd.SolicitudFecha).ThenByDescending(Function(dgrd) dgrd.ApellidoNombre).ToList
                End If
            Case columnMotivo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSancionesFiltradaYOrdenada = mlistSancionesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Motivo).ThenBy(Function(dgrd) dgrd.SolicitudFecha).ThenBy(Function(dgrd) dgrd.ApellidoNombre).ToList
                Else
                    mlistSancionesFiltradaYOrdenada = mlistSancionesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Motivo).ThenByDescending(Function(dgrd) dgrd.SolicitudFecha).ThenByDescending(Function(dgrd) dgrd.ApellidoNombre).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistSancionesFiltradaYOrdenada

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

    Private Sub FechaCambiar(sender As Object, e As EventArgs) Handles datetimepickerFechaDesdeHost.TextChanged, datetimepickerFechaHastaHost.TextChanged
        RefreshData()
    End Sub

    Private Sub CambioFiltros(sender As Object, e As EventArgs) Handles comboboxCuartel.SelectedIndexChanged, comboboxEstado.SelectedIndexChanged, controlpersonaPersonaHost.TextChanged
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
        If Not Permisos.VerificarPermiso(Permisos.SANCION_AGREGAR) Then
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        datagridviewMain.Enabled = False
        formSancion.LoadAndShow(False, True, Me, 0, 0)
        datagridviewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Sanción para editar.", vbInformation, My.Application.Info.Title)
        End If
        If Not Permisos.VerificarPermiso(Permisos.SANCION_EDITAR) Then
            Return
        End If
        If CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).Estado <> Constantes.PersonaSancionEstadoEnProceso AndAlso Not Permisos.VerificarPermiso(Permisos.SANCION_EDITAR_FINALIZADA, False) Then
            MsgBox("La Sanción está finalizada y no tiene autorización para editarla.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        datagridviewMain.Enabled = False
        formSancion.LoadAndShow(False, True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPersona, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSancion)
        datagridviewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Sanción para eliminar.", vbInformation, My.Application.Info.Title)
            Return
        End If
        If Not Permisos.VerificarPermiso(Permisos.SANCION_ELIMINAR) Then
            Return
        End If

        If CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).Estado <> Constantes.PersonaSancionEstadoEnProceso AndAlso Not Permisos.VerificarPermiso(Permisos.SANCION_ELIMINAR_FINALIZADA, False) Then
            MsgBox("La Sanción está cerrada y no tiene autorización para eliminarla.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        Using dbContext = New CSBomberosContext(True)
            Dim GridRowDataActual = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)
            Dim Mensaje As String

            Mensaje = String.Format("Se eliminará la Sanción seleccionada.{0}{0}Persona: {1}{0}Fecha de solicitud: {2}{0}Estado: {3}{0}Motivo: {4}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.ApellidoNombre, GridRowDataActual.SolicitudFecha.ToShortDateString(), GridRowDataActual.EstadoNombre, GridRowDataActual.Motivo)
            If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                Try
                    dbContext.PersonaSancion.Remove(dbContext.PersonaSancion.Find(GridRowDataActual.IDPersona, GridRowDataActual.IDSancion))
                    dbContext.SaveChanges()

                Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                    Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                        Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                            MsgBox("No se puede eliminar la Sanción porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    End Select
                    Me.Cursor = Cursors.Default
                    Exit Sub

                Catch ex As Exception
                    CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar la Sanción.")
                End Try
                RefreshData()
            End If
        End Using

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Sanción para ver.", vbInformation, My.Application.Info.Title)
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        datagridviewMain.Enabled = False
        formSancion.LoadAndShow(False, False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPersona, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSancion)
        datagridviewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Imprimir(sender As Object, e As EventArgs) Handles buttonImprimir.ButtonClick
        Dim CurrentRow As GridRowData

        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Sanción para imprimir.", vbInformation, My.Application.Info.Title)
        End If
        If Not Permisos.VerificarPermiso(Permisos.SANCION_IMPRIMIR) Then
            Exit Sub
        End If
        CurrentRow = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)
        Me.Cursor = Cursors.WaitCursor
        datagridviewMain.Enabled = False
        Using dbContext As New CSBomberosContext(True)
            Dim ReporteActual As Reporte
            ReporteActual = dbContext.Reporte.Find(CS_Parameter_System.GetIntegerAsShort(Parametros.REPORTE_ID_PERSONA_SANCIONDISCIPLINARIA))
            ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.TrimEnd = "IDPersona").Single.Valor = CurrentRow.IDPersona
            ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.TrimEnd = "IDSancion").Single.Valor = CurrentRow.IDSancion
            If ReporteActual.Open(True, ReporteActual.Nombre & " - " & CurrentRow.ApellidoNombre) Then
            End If
        End Using
        datagridviewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

#End Region

End Class