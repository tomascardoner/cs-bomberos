Public Class formUnidades

#Region "Declarations"
    Friend Class GridRowData
        Public Property IDUnidad As Short
        Public Property Numero As Short
        Public Property Marca As String
        Public Property Modelo As String
        Public Property Dominio As String
        Public Property IDUnidadTipo As Byte
        Public Property UnidadTipoNombre As String
        Public Property IDCuartel As Byte
        Public Property CuartelNombre As String
        Public Property EsActivo As Boolean
    End Class

    Private mlistUnidadesBase As List(Of GridRowData)
    Private mlistUnidadesFiltradaYOrdenada As List(Of GridRowData)

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

        pFillAndRefreshLists.UnidadTipo(comboboxUnidadTipo.ComboBox, True, False)
        pFillAndRefreshLists.Cuartel(comboboxCuartel.ComboBox, True, False)

        comboboxActivo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxActivo.SelectedIndex = 1

        mSkipFilterData = False

        mOrdenColumna = columnNumero
        mOrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub RefreshData(Optional ByVal PositionIDUnidad As Short = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)

        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSBomberosContext(True)
                mlistUnidadesBase = (From a In dbContext.Unidad
                                        Join at In dbContext.UnidadTipo On a.IDUnidadTipo Equals at.IDUnidadTipo
                                        Join c In dbContext.Cuartel On a.IDCuartel Equals c.IDCuartel
                                        Select New GridRowData With {.IDUnidad = a.IDUnidad, .Numero = a.Numero, .Marca = a.Marca, .Modelo = a.Modelo, .Dominio = a.Dominio, .IDUnidadTipo = a.IDUnidadTipo, .UnidadTipoNombre = at.Nombre, .IDCuartel = c.IDCuartel, .CuartelNombre = c.Nombre, .EsActivo = a.EsActivo}).ToList
            End Using

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Unidades.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDUnidad = 0
            Else
                PositionIDUnidad = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDUnidad
            End If
        End If

        FilterData()

        If PositionIDUnidad <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDUnidad = PositionIDUnidad Then
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
                mlistUnidadesFiltradaYOrdenada = mlistUnidadesBase.ToList

                ' Filtro por Unidad Tipo
                If comboboxUnidadTipo.SelectedIndex > 0 Then
                    mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.Where(Function(a) a.IDUnidadTipo = CByte(comboboxUnidadTipo.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Cuartel
                If comboboxCuartel.SelectedIndex > 0 Then
                    mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.Where(Function(a) a.IDCuartel = CByte(comboboxCuartel.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Activo
                Select Case comboboxActivo.SelectedIndex
                    Case 0      ' Todos
                    Case 1      ' Sí
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Unidad.EsActivo} = 1"
                        mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.Where(Function(a) a.EsActivo).ToList
                    Case 2      ' No
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Unidad.EsActivo} = 0"
                        mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.Where(Function(a) Not a.EsActivo).ToList
                End Select

                Select Case mlistUnidadesFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Unidades para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Unidad.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Unidades.", mlistUnidadesFiltradaYOrdenada.Count)
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
            Case columnNumero.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Numero).ToList
                Else
                    mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Numero).ToList
                End If
            Case columnMarca.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Marca).ThenBy(Function(dgrd) dgrd.Modelo).ThenBy(Function(dgrd) dgrd.Numero).ToList
                Else
                    mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Marca).ThenBy(Function(dgrd) dgrd.Modelo).ThenBy(Function(dgrd) dgrd.Numero).ToList
                End If
            Case columnModelo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Modelo).ThenBy(Function(dgrd) dgrd.Marca).ThenBy(Function(dgrd) dgrd.Numero).ToList
                Else
                    mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Modelo).ThenBy(Function(dgrd) dgrd.Marca).ThenBy(Function(dgrd) dgrd.Numero).ToList
                End If
            Case columnDominio.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Dominio).ThenBy(Function(dgrd) dgrd.Marca).ThenBy(Function(dgrd) dgrd.Modelo).ThenBy(Function(dgrd) dgrd.Numero).ToList
                Else
                    mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Dominio).ThenBy(Function(dgrd) dgrd.Marca).ThenBy(Function(dgrd) dgrd.Modelo).ThenBy(Function(dgrd) dgrd.Numero).ToList
                End If
            Case columnUnidadTipo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.UnidadTipoNombre).ThenBy(Function(dgrd) dgrd.Numero).ToList
                Else
                    mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.UnidadTipoNombre).ThenBy(Function(dgrd) dgrd.Numero).ToList
                End If
            Case columnCuartel.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.Numero).ToList
                Else
                    mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.Numero).ToList
                End If
            Case columnEsActivo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Numero).ToList
                Else
                    mlistUnidadesFiltradaYOrdenada = mlistUnidadesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Numero).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistUnidadesFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        mOrdenColumna.HeaderCell.SortGlyphDirection = mOrdenTipo
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub comboboxUnidadTipo_SelectedIndexChanged() Handles comboboxUnidadTipo.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub comboboxCuartel_SelectedIndexChanged() Handles comboboxCuartel.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub comboboxActivo_SelectedIndexChanged() Handles comboboxActivo.SelectedIndexChanged
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
        If Permisos.VerificarPermiso(Permisos.Unidad_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formUnidad.LoadAndShow(True, Me, 0)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Unidad para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.Unidad_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                formUnidad.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDUnidad)

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Unidad para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.Unidad_ELIMINAR) Then

                Me.Cursor = Cursors.WaitCursor

                Using dbContext = New CSBomberosContext(True)
                    Dim UnidadActual As Unidad = dbContext.Unidad.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDUnidad)
                    Dim Mensaje As String
                    Mensaje = String.Format("Se eliminará el Unidad seleccionado.{0}{0}{1}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, UnidadActual.NumeroMarcaModelo)
                    If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                        Try
                            dbContext.Unidad.Remove(UnidadActual)
                            dbContext.SaveChanges()

                        Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                            Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                                Case Errors.RelatedEntity
                                    MsgBox("No se puede eliminar el Unidad porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                            End Select
                            Me.Cursor = Cursors.Default
                            Exit Sub

                        Catch ex As Exception
                            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar el Unidad.")
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
            MsgBox("No hay ningún Unidad para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formUnidad.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDUnidad)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class