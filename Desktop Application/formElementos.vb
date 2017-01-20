﻿Public Class formElementos

#Region "Declarations"
    Friend Class GridRowData
        Public Property IDElemento As Integer
        Public Property IDCuartel As Byte
        Public Property CuartelNombre As String
        Public Property IDArea As Short
        Public Property AreaNombre As String
        Public Property AreaCodigo As String
        Public Property Nombre As String
        Public Property IDUbicacion As Short
        Public Property UbicacionNombre As String
        Public Property IDSubUbicacion As Short
        Public Property SubUbicacionNombre As String
        Public Property EsActivo As Boolean
    End Class

    Private mlistElementosBase As List(Of GridRowData)
    Private mlistElementosFiltradaYOrdenada As List(Of GridRowData)

    Private mSkipFilterData As Boolean = False
    Private mBusquedaAplicada As Boolean = False
    Private mReportSelectionFormula As String

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder
#End Region

#Region "Form stuff"
    Friend Sub SetAppearance()
        datagridviewMain.DefaultCellStyle.Font = My.Settings.GridsAndListsFont
        datagridviewMain.ColumnHeadersDefaultCellStyle.Font = My.Settings.GridsAndListsFont
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
    Friend Sub RefreshData(Optional ByVal PositionIDElemento As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)

        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSBomberosContext(True)
                mlistElementosBase = (From e In dbContext.Elemento
                                      Join a In dbContext.Area On e.IDArea Equals a.IDArea
                                      Join c In dbContext.Cuartel On a.IDCuartel Equals c.IDCuartel
                                      Group Join u In dbContext.Ubicacion On e.IDUbicacion Equals u.IDUbicacion Into Ubicaciones_Group = Group
                                      From ug In Ubicaciones_Group.DefaultIfEmpty
                                      Group Join su In dbContext.SubUbicacion On e.IDSubUbicacion Equals su.IDSubUbicacion Into SubUbicaciones_Group = Group
                                      From sug In SubUbicaciones_Group.DefaultIfEmpty
                                      Select New GridRowData With {.IDElemento = e.IDElemento, .IDCuartel = a.IDCuartel, .CuartelNombre = c.Nombre, .IDArea = e.IDArea, .AreaNombre = a.Nombre, .AreaCodigo = a.Codigo & e.Codigo, .Nombre = e.Nombre, .IDUbicacion = If(ug Is Nothing, FIELD_VALUE_NOTSPECIFIED_SHORT, ug.IDUbicacion), .UbicacionNombre = If(ug Is Nothing, "", ug.Nombre), .IDSubUbicacion = If(sug Is Nothing, FIELD_VALUE_NOTSPECIFIED_SHORT, sug.IDSubUbicacion), .SubUbicacionNombre = If(sug Is Nothing, "", sug.Nombre), .EsActivo = e.EsActivo}).ToList
            End Using

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al leer los Elementos.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDElemento = 0
            Else
                PositionIDElemento = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDElemento
            End If
        End If

        FilterData()

        If PositionIDElemento <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDElemento = PositionIDElemento Then
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
                mlistElementosFiltradaYOrdenada = mlistElementosBase.ToList

                ' Filtro por texto de búsqueda en el Nombre
                If mBusquedaAplicada Then
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.Where(Function(e) e.Nombre.ToLower.Contains(textboxBuscar.Text.ToLower.Trim)).ToList
                End If

                ' Filtro por Cuartel
                If comboboxCuartel.SelectedIndex > 0 Then
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.Where(Function(e) e.IDCuartel = CByte(comboboxCuartel.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Area
                If comboboxArea.SelectedIndex > 0 Then
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.Where(Function(e) e.IDArea = CShort(comboboxArea.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Ubicación
                If comboboxUbicacion.SelectedIndex > 0 Then
                    If CShort(comboboxUbicacion.ComboBox.SelectedValue) = FIELD_VALUE_NOTSPECIFIED_SHORT Then
                        mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.Where(Function(e) e.IDUbicacion = FIELD_VALUE_NOTSPECIFIED_SHORT).ToList
                    Else
                        mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.Where(Function(e) e.IDUbicacion = CShort(comboboxUbicacion.ComboBox.SelectedValue)).ToList
                    End If
                End If

                ' Filtro por Sub-Ubicación
                If comboboxSubUbicacion.SelectedIndex > 0 Then
                    If CShort(comboboxSubUbicacion.ComboBox.SelectedValue) = FIELD_VALUE_NOTSPECIFIED_SHORT Then
                        mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.Where(Function(e) e.IDSubUbicacion = FIELD_VALUE_NOTSPECIFIED_SHORT).ToList
                    Else
                        mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.Where(Function(e) e.IDSubUbicacion = CShort(comboboxSubUbicacion.ComboBox.SelectedValue)).ToList
                    End If
                End If

                ' Filtro por Activo
                Select Case comboboxActivo.SelectedIndex
                    Case 0      ' Todos
                    Case FILTER_ACTIVO_YES_LISTINDEX       ' Sí
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Elemento.EsActivo} = 1"
                        mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.Where(Function(a) a.EsActivo).ToList
                    Case FILTER_ACTIVO_NO_LISTINDEX       ' No
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Elemento.EsActivo} = 0"
                        mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.Where(Function(a) Not a.EsActivo).ToList
                End Select

                Select Case mlistElementosFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Elementos para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Elemento.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Elementos.", mlistElementosFiltradaYOrdenada.Count)
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
            Case columnCuartel.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.AreaNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.CuartelNombre).ThenByDescending(Function(dgrd) dgrd.AreaNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnArea.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.AreaNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.AreaNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnAreaCodigo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.AreaCodigo).ThenBy(Function(dgrd) dgrd.AreaNombre).ToList
                Else
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.AreaCodigo).ThenBy(Function(dgrd) dgrd.AreaNombre).ToList
                End If
            Case columnNombre.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Nombre).ThenBy(Function(dgrd) dgrd.AreaNombre).ToList
                Else
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Nombre).ThenBy(Function(dgrd) dgrd.AreaNombre).ToList
                End If
            Case columnUbicacion.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.UbicacionNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.UbicacionNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnSubUbicacion.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.SubUbicacionNombre).ThenBy(Function(dgrd) dgrd.UbicacionNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.SubUbicacionNombre).ThenBy(Function(dgrd) dgrd.UbicacionNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnEsActivo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistElementosFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        mOrdenColumna.HeaderCell.SortGlyphDirection = mOrdenTipo
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub textboxBuscar_GotFocus() Handles textboxBuscar.GotFocus
        textboxBuscar.SelectAll()
    End Sub

    Private Sub textboxBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            If textboxBuscar.Text.Trim.Length < 3 Then
                MsgBox("Se deben especificar al menos 3 letras para buscar.", MsgBoxStyle.Information, My.Application.Info.Title)
                textboxBuscar.Focus()
            Else
                mBusquedaAplicada = True
                FilterData()
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub buttonBuscarBorrar_Click() Handles buttonBuscarBorrar.Click
        If mBusquedaAplicada Then
            textboxBuscar.Clear()
            mBusquedaAplicada = False
            FilterData()
        End If
    End Sub

    Private Sub comboboxCuartel_SelectedIndexChanged() Handles comboboxCuartel.SelectedIndexChanged
        pFillAndRefreshLists.Area(comboboxArea.ComboBox, True, False, CByte(comboboxCuartel.ComboBox.SelectedValue))
        pFillAndRefreshLists.Ubicacion(comboboxUbicacion.ComboBox, True, True, CByte(comboboxCuartel.ComboBox.SelectedValue))

        FilterData()
    End Sub

    Private Sub comboboxArea_SelectedIndexChanged() Handles comboboxArea.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub comboboxUbicacion_SelectedIndexChanged() Handles comboboxUbicacion.SelectedIndexChanged
        pFillAndRefreshLists.SubUbicacion(comboboxSubUbicacion.ComboBox, True, True, CShort(comboboxUbicacion.ComboBox.SelectedValue))

        FilterData()
    End Sub

    Private Sub comboboxSubUbicacion_SelectedIndexChanged() Handles comboboxSubUbicacion.SelectedIndexChanged
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
        If Permisos.VerificarPermiso(Permisos.Elemento_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formElemento.LoadAndShow(True, Me, 0)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningun Elemento para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.Elemento_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                formElemento.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDElemento)

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Elemento para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.Elemento_ELIMINAR) Then

                Me.Cursor = Cursors.WaitCursor

                Using dbContext = New CSBomberosContext(True)
                    Dim ElementoActual As Elemento = dbContext.Elemento.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDElemento)
                    Dim Mensaje As String
                    Mensaje = String.Format("Se eliminará el Elemento seleccionado.{0}{0}{1}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, ElementoActual.Nombre)
                    If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                        Try
                            dbContext.Elemento.Remove(ElementoActual)
                            dbContext.SaveChanges()

                        Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                            Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                                Case Errors.RelatedEntity
                                    MsgBox("No se puede eliminar el Elemento porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                            End Select
                            Me.Cursor = Cursors.Default
                            Exit Sub

                        Catch ex As Exception
                            CS_Error.ProcessError(ex, "Error al eliminar el Elemento.")
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
            MsgBox("No hay ninguna Ubicación para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formElemento.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDElemento)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class