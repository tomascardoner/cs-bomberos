Public Class formElementos

#Region "Declarations"
    Friend Class GridRowData
        Public Property IDElemento As Integer
        Public Property Nombre As String
        Public Property IDRubro As Byte
        Public Property RubroNombre As String
        Public Property IDSubRubro As Short
        Public Property SubRubroNombre As String
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
        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        pFillAndRefreshLists.Rubro(comboboxRubro.ComboBox, True, True)

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
                                      Group Join r In dbContext.Rubro On e.IDRubro Equals r.IDRubro Into Rubros_Group = Group
                                      From rg In Rubros_Group.DefaultIfEmpty
                                      Group Join sr In dbContext.SubRubro On e.IDSubRubro Equals sr.IDSubRubro Into SubRubro_Group = Group
                                      From srg In SubRubro_Group.DefaultIfEmpty
                                      Select New GridRowData With {.IDElemento = e.IDElemento, .Nombre = e.Nombre, .IDRubro = If(rg Is Nothing, FIELD_VALUE_NOTSPECIFIED_BYTE, rg.IDRubro), .RubroNombre = If(rg Is Nothing, "", rg.Nombre), .IDSubRubro = If(srg Is Nothing, FIELD_VALUE_NOTSPECIFIED_SHORT, srg.IDSubRubro), .SubRubroNombre = If(srg Is Nothing, "", srg.Nombre), .EsActivo = e.EsActivo}).ToList
            End Using

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Elementos.")
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

                ' Filtro por Rubro
                If comboboxRubro.SelectedIndex > 0 Then
                    If CShort(comboboxRubro.ComboBox.SelectedValue) = FIELD_VALUE_NOTSPECIFIED_BYTE Then
                        mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.Where(Function(e) e.IDRubro = FIELD_VALUE_NOTSPECIFIED_BYTE).ToList
                    Else
                        mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.Where(Function(e) e.IDRubro = CByte(comboboxRubro.ComboBox.SelectedValue)).ToList
                    End If
                End If

                ' Filtro por Sub-Rubro
                If comboboxSubRubro.SelectedIndex > 0 Then
                    If CShort(comboboxSubRubro.ComboBox.SelectedValue) = FIELD_VALUE_NOTSPECIFIED_SHORT Then
                        mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.Where(Function(e) e.IDSubRubro = FIELD_VALUE_NOTSPECIFIED_SHORT).ToList
                    Else
                        mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.Where(Function(e) e.IDSubRubro = CShort(comboboxSubRubro.ComboBox.SelectedValue)).ToList
                    End If
                End If

                ' Filtro por Activo
                Select Case comboboxActivo.SelectedIndex
                    Case CS_Constants.COMBOBOX_ALLYESNO_ALL_LISTINDEX       ' Todos
                    Case CS_Constants.COMBOBOX_ALLYESNO_YES_LISTINDEX       ' Sí
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Elemento.EsActivo} = 1"
                        mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.Where(Function(a) a.EsActivo).ToList
                    Case CS_Constants.COMBOBOX_ALLYESNO_NO_LISTINDEX        ' No
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
            Case columnNombre.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnRubro.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.RubroNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.RubroNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnSubRubro.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.SubRubroNombre).ThenBy(Function(dgrd) dgrd.RubroNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistElementosFiltradaYOrdenada = mlistElementosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.SubRubroNombre).ThenBy(Function(dgrd) dgrd.RubroNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
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

    Private Sub comboboxRubro_SelectedIndexChanged() Handles comboboxRubro.SelectedIndexChanged
        pFillAndRefreshLists.SubRubro(comboboxSubRubro.ComboBox, True, True, CByte(comboboxRubro.ComboBox.SelectedValue))

        FilterData()
    End Sub

    Private Sub comboboxSubRubro_SelectedIndexChanged() Handles comboboxSubRubro.SelectedIndexChanged
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
        If Permisos.VerificarPermiso(Permisos.ELEMENTO_AGREGAR) Then
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
            If Permisos.VerificarPermiso(Permisos.ELEMENTO_EDITAR) Then
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
            If Permisos.VerificarPermiso(Permisos.ELEMENTO_ELIMINAR) Then

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
                            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar el Elemento.")
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
            MsgBox("No hay ningún Elemento para ver.", vbInformation, My.Application.Info.Title)
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