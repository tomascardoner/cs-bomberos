Public Class formSubUbicaciones

#Region "Declarations"
    Friend Class GridRowData
        Public Property IDSubUbicacion As Short
        Public Property Nombre As String
        Public Property IDCuartel As Byte
        Public Property CuartelNombre As String
        Public Property IDUbicacion As Short
        Public Property UbicacionNombre As String
        Public Property EsActivo As Boolean
    End Class

    Private mlistSubUbicacionesBase As List(Of GridRowData)
    Private mlistSubUbicacionesFiltradaYOrdenada As List(Of GridRowData)

    Private mSkipFilterData As Boolean = False
    Private mBusquedaAplicada As Boolean = False
    Private mReportSelectionFormula As String

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder
#End Region

#Region "Form stuff"
    Friend Sub SetAppearance()
        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        pFillAndRefreshLists.Cuartel(comboboxCuartel.ComboBox, True, False)

        comboboxActivo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxActivo.SelectedIndex = 1

        mSkipFilterData = False

        mOrdenColumna = columnNombre
        mOrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub RefreshData(Optional ByVal PositionIDSubUbicacion As Short = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)

        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSBomberosContext(True)
                mlistSubUbicacionesBase = (From su In dbContext.SubUbicacion
                                           Join u In dbContext.Ubicacion On su.IDUbicacion Equals u.IDUbicacion
                                           Join c In dbContext.Cuartel On u.IDCuartel Equals c.IDCuartel
                                           Select New GridRowData With {.IDSubUbicacion = su.IDSubUbicacion, .Nombre = su.Nombre, .IDCuartel = u.IDCuartel, .CuartelNombre = c.Nombre, .IDUbicacion = su.IDUbicacion, .UbicacionNombre = u.Nombre, .EsActivo = su.EsActivo}).ToList
            End Using

        Catch ex As Exception

            CS_Error.ProcessError(ex, "Error al leer las Sub-Ubicaciones.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDSubUbicacion = 0
            Else
                PositionIDSubUbicacion = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDSubUbicacion
            End If
        End If

        FilterData()

        If PositionIDSubUbicacion <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDSubUbicacion = PositionIDSubUbicacion Then
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
                mlistSubUbicacionesFiltradaYOrdenada = mlistSubUbicacionesBase.ToList

                ' Filtro por Cuartel
                If comboboxCuartel.SelectedIndex > 0 Then
                    mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Ubicacion.IDCuartel} = " & CByte(comboboxCuartel.ComboBox.SelectedValue)
                    mlistSubUbicacionesFiltradaYOrdenada = mlistSubUbicacionesFiltradaYOrdenada.Where(Function(p) p.IDCuartel = CByte(comboboxCuartel.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Ubicación
                If comboboxUbicacion.SelectedIndex > 0 Then
                    mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Ubicacion.IDUbicacion} = " & CShort(comboboxUbicacion.ComboBox.SelectedValue)
                    mlistSubUbicacionesFiltradaYOrdenada = mlistSubUbicacionesFiltradaYOrdenada.Where(Function(p) p.IDUbicacion = CShort(comboboxUbicacion.ComboBox.SelectedValue)).ToList
                End If

                'Filtro por Activo
                Select Case comboboxActivo.SelectedIndex
                    Case 0      ' Todos
                    Case 1      ' Sí
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{SubUbicacion.EsActivo} = 1"
                        mlistSubUbicacionesFiltradaYOrdenada = mlistSubUbicacionesFiltradaYOrdenada.Where(Function(a) a.EsActivo).ToList
                    Case 2      ' No
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{SubUbicacion.EsActivo} = 0"
                        mlistSubUbicacionesFiltradaYOrdenada = mlistSubUbicacionesFiltradaYOrdenada.Where(Function(a) Not a.EsActivo).ToList
                End Select

                Select Case mlistSubUbicacionesFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Sub-Ubicaciones para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Sub-Ubicación.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Sub-Ubicaciones.", mlistSubUbicacionesFiltradaYOrdenada.Count)
                End Select

            Catch ex As Exception
                CS_Error.ProcessError(ex, "Error al filtrar los datos.")
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
            Case columnNombre.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSubUbicacionesFiltradaYOrdenada = mlistSubUbicacionesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Nombre).ThenBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.UbicacionNombre).ToList
                Else
                    mlistSubUbicacionesFiltradaYOrdenada = mlistSubUbicacionesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Nombre).ThenByDescending(Function(dgrd) dgrd.CuartelNombre).ThenByDescending(Function(dgrd) dgrd.UbicacionNombre).ToList
                End If
            Case columnCuartel.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSubUbicacionesFiltradaYOrdenada = mlistSubUbicacionesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.UbicacionNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistSubUbicacionesFiltradaYOrdenada = mlistSubUbicacionesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.CuartelNombre).ThenByDescending(Function(dgrd) dgrd.UbicacionNombre).ThenByDescending(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnUbicacion.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSubUbicacionesFiltradaYOrdenada = mlistSubUbicacionesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.UbicacionNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistSubUbicacionesFiltradaYOrdenada = mlistSubUbicacionesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.UbicacionNombre).ThenByDescending(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnEsActivo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSubUbicacionesFiltradaYOrdenada = mlistSubUbicacionesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistSubUbicacionesFiltradaYOrdenada = mlistSubUbicacionesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistSubUbicacionesFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        mOrdenColumna.HeaderCell.SortGlyphDirection = mOrdenTipo
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            For Each RowCurrent As DataGridViewRow In datagridviewMain.Rows
                If RowCurrent.Cells(columnNombre.Name).Value.ToString.StartsWith(e.KeyChar, StringComparison.CurrentCultureIgnoreCase) Then
                    RowCurrent.Cells(columnNombre.Name).Selected = True
                    datagridviewMain.Focus()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub CambioCuartel() Handles comboboxCuartel.SelectedIndexChanged
        pFillAndRefreshLists.Ubicacion(comboboxUbicacion.ComboBox, True, False, CByte(comboboxCuartel.ComboBox.SelectedValue))
    End Sub

    Private Sub CambioFiltros() Handles comboboxUbicacion.SelectedIndexChanged, comboboxActivo.SelectedIndexChanged
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
        If Permisos.VerificarPermiso(Permisos.SUBUBICACION_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formSubUbicacion.LoadAndShow(True, Me, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Sub-Ubicación para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.SUBUBICACION_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formSubUbicacion.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSubUbicacion)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Sub-Ubicación para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.SUBUBICACION_ELIMINAR) Then
                Me.Cursor = Cursors.WaitCursor

                Dim Mensaje As String

                Mensaje = String.Format("Se eliminará la Sub-Ubicación seleccionada.{0}{0}Nombre: {1}{0}Ubicación: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).Nombre, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).UbicacionNombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                    Try
                        Using dbContext = New CSBomberosContext(True)
                            Dim SubUbicacionEliminar As SubUbicacion

                            SubUbicacionEliminar = dbContext.SubUbicacion.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSubUbicacion)
                            dbContext.SubUbicacion.Remove(SubUbicacionEliminar)
                            dbContext.SaveChanges()
                            SubUbicacionEliminar = Nothing
                        End Using

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                            Case Errors.RelatedEntity
                                MsgBox("No se puede eliminar la Sub-Ubicación porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Me.Cursor = Cursors.Default
                        Exit Sub

                    Catch ex As Exception
                        CS_Error.ProcessError(ex, "Error al eliminar la Sub-Ubicación.")
                    End Try

                    RefreshData()

                End If

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Sub-Ubicación para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formSubUbicacion.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSubUbicacion)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class