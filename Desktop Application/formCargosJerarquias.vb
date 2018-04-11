Public Class formCargosJerarquias

#Region "Declarations"
    Friend Class GridRowData
        Public Property IDCargo As Byte
        Public Property CargoNombre As String
        Public Property CargoOrden As Byte?
        Public Property IDJerarquia As Byte
        Public Property Nombre As String
        Public Property Orden As Byte?
        Public Property EsActivo As Boolean
    End Class

    Private mlistCargosJerarquiasBase As List(Of GridRowData)
    Private mlistCargosJerarquiasFiltradaYOrdenada As List(Of GridRowData)

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

        comboboxActivo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxActivo.SelectedIndex = 1

        mSkipFilterData = False

        mOrdenColumna = columnCargo
        mOrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub RefreshData(Optional ByVal PositionIDCargo As Byte = 0, Optional ByVal PositionIDJerarquia As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)

        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSBomberosContext(True)
                mlistCargosJerarquiasBase = (From cj In dbContext.CargoJerarquia
                                             Join c In dbContext.Cargo On cj.IDCargo Equals c.IDCargo
                                             Select New GridRowData With {.IDCargo = cj.IDCargo, .CargoNombre = c.Nombre, .CargoOrden = c.Orden, .IDJerarquia = cj.IDJerarquia, .Nombre = cj.Nombre, .Orden = cj.Orden, .EsActivo = cj.EsActivo}).ToList

            End Using

        Catch ex As Exception

            CS_Error.ProcessError(ex, "Error al leer las Jerarquías.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDCargo = 0
                PositionIDJerarquia = 0
            Else
                PositionIDCargo = CType(datagridviewMain.CurrentRow.DataBoundItem, CargoJerarquia).IDCargo
                PositionIDJerarquia = CType(datagridviewMain.CurrentRow.DataBoundItem, CargoJerarquia).IDJerarquia
            End If
        End If

        FilterData()

        If PositionIDCargo <> 0 And PositionIDJerarquia <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDCargo = PositionIDCargo And CType(CurrentRowChecked.DataBoundItem, GridRowData).IDJerarquia = PositionIDJerarquia Then
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
                mlistCargosJerarquiasFiltradaYOrdenada = mlistCargosJerarquiasBase.ToList

                'Filtro por Activo
                Select Case comboboxActivo.SelectedIndex
                    Case 0      ' Todos
                    Case 1      ' Sí
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{CargoJerarquia.EsActivo} = 1"
                        mlistCargosJerarquiasFiltradaYOrdenada = mlistCargosJerarquiasFiltradaYOrdenada.Where(Function(a) a.EsActivo).ToList
                    Case 2      ' No
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{CargoJerarquia.EsActivo} = 0"
                        mlistCargosJerarquiasFiltradaYOrdenada = mlistCargosJerarquiasFiltradaYOrdenada.Where(Function(a) Not a.EsActivo).ToList
                End Select

                Select Case mlistCargosJerarquiasFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Jerarquías para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Jerarquía.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Jerarquías.", mlistCargosJerarquiasFiltradaYOrdenada.Count)
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
            Case columnCargo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistCargosJerarquiasFiltradaYOrdenada = mlistCargosJerarquiasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.CargoOrden).ThenBy(Function(dgrd) dgrd.Orden).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistCargosJerarquiasFiltradaYOrdenada = mlistCargosJerarquiasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.CargoOrden).ThenByDescending(Function(dgrd) dgrd.Orden).ThenByDescending(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnNombre.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistCargosJerarquiasFiltradaYOrdenada = mlistCargosJerarquiasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Nombre).ThenBy(Function(dgrd) dgrd.CargoNombre).ToList
                Else
                    mlistCargosJerarquiasFiltradaYOrdenada = mlistCargosJerarquiasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Nombre).ThenBy(Function(dgrd) dgrd.CargoNombre).ToList
                End If
            Case columnOrden.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistCargosJerarquiasFiltradaYOrdenada = mlistCargosJerarquiasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Orden).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistCargosJerarquiasFiltradaYOrdenada = mlistCargosJerarquiasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Orden).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnEsActivo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistCargosJerarquiasFiltradaYOrdenada = mlistCargosJerarquiasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistCargosJerarquiasFiltradaYOrdenada = mlistCargosJerarquiasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistCargosJerarquiasFiltradaYOrdenada

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

    Private Sub CambioFiltros() Handles comboboxActivo.SelectedIndexChanged
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
        If Permisos.VerificarPermiso(Permisos.CARGOJERARQUIA_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formCargoJerarquia.LoadAndShow(True, Me, 0, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Jerarquía para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.CARGOJERARQUIA_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formCargoJerarquia.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDCargo, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDJerarquia)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Jerarquía para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.CARGOJERARQUIA_ELIMINAR) Then
                Me.Cursor = Cursors.WaitCursor


                Dim Mensaje As String

                Mensaje = String.Format("Se eliminará el Jerarquía seleccionado.{0}{0}Cargo: {1}{0}Nombre: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).CargoNombre, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).Nombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                    Try
                        Using dbContext = New CSBomberosContext(True)
                            Dim CargoJerarquiaEliminar As CargoJerarquia

                            CargoJerarquiaEliminar = dbContext.CargoJerarquia.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDCargo, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDJerarquia)
                            dbContext.CargoJerarquia.Remove(CargoJerarquiaEliminar)
                            dbContext.SaveChanges()
                            CargoJerarquiaEliminar = Nothing
                        End Using

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                            Case Errors.RelatedEntity
                                MsgBox("No se puede eliminar el Jerarquía porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Me.Cursor = Cursors.Default
                        Exit Sub

                    Catch ex As Exception
                        CS_Error.ProcessError(ex, "Error al eliminar el Jerarquía.")
                    End Try

                    RefreshData()

                End If

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Jerarquía para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formCargoJerarquia.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDCargo, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDJerarquia)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class