Public Class formSiniestroTipos

#Region "Declarations"

    Friend Class GridRowData
        Public Property IDSiniestroRubro As Byte
        Public Property RubroNombre As String
        Public Property IDSiniestroTipo As Byte
        Public Property Nombre As String
        Public Property ClavePredeterminadaNombre As String
        Public Property EsActivo As Boolean
    End Class

    Private mlistSiniestroTiposBase As List(Of GridRowData)
    Private mlistSiniestroTiposFiltradaYOrdenada As List(Of GridRowData)

    Private mSkipFilterData As Boolean = False
    Private mReportSelectionFormula As String

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder

#End Region

#Region "Form stuff"

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.IMAGE_TABLAS_32)

        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        Using context As New CSBomberosContext(True)
            ListasSiniestros.LlenarComboBoxRubros(context, comboboxRubro.ComboBox, True, False)
        End Using

        comboboxActivo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxActivo.SelectedIndex = 1

        mSkipFilterData = False

        mOrdenColumna = columnSiniestroRubro
        mOrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub RefreshData(Optional ByVal PositionIDSiniestroRubro As Byte = 0, Optional ByVal PositionIDSiniestroTipo As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)

        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSBomberosContext(True)
                mlistSiniestroTiposBase = (From st In dbContext.SiniestroTipo
                                           Join sr In dbContext.SiniestroRubro On st.IDSiniestroRubro Equals sr.IDSiniestroRubro
                                           Where st.IDSiniestroTipo <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE
                                           Select New GridRowData With {.IDSiniestroRubro = st.IDSiniestroRubro, .RubroNombre = sr.Nombre, .IDSiniestroTipo = st.IDSiniestroTipo, .Nombre = st.Nombre, .ClavePredeterminadaNombre = st.ClavePredeterminadaNombre, .EsActivo = st.EsActivo}).ToList

            End Using

        Catch ex As Exception

            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Tipos de Siniestros.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDSiniestroRubro = 0
                PositionIDSiniestroTipo = 0
            Else
                PositionIDSiniestroRubro = CType(datagridviewMain.CurrentRow.DataBoundItem, SiniestroTipo).IDSiniestroRubro
                PositionIDSiniestroTipo = CType(datagridviewMain.CurrentRow.DataBoundItem, SiniestroTipo).IDSiniestroTipo
            End If
        End If

        FilterData()

        If PositionIDSiniestroRubro <> 0 And PositionIDSiniestroTipo <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDSiniestroRubro = PositionIDSiniestroRubro And CType(CurrentRowChecked.DataBoundItem, GridRowData).IDSiniestroTipo = PositionIDSiniestroTipo Then
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
                mlistSiniestroTiposFiltradaYOrdenada = mlistSiniestroTiposBase.ToList

                ' Filtro por Rubro
                If comboboxRubro.SelectedIndex > 0 Then
                    mlistSiniestroTiposFiltradaYOrdenada = mlistSiniestroTiposFiltradaYOrdenada.Where(Function(p) p.IDSiniestroRubro = CByte(comboboxRubro.ComboBox.SelectedValue)).ToList
                End If

                'Filtro por Activo
                Select Case comboboxActivo.SelectedIndex
                    Case 0      ' Todos
                    Case 1      ' Sí
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{SiniestroTipo.EsActivo} = 1"
                        mlistSiniestroTiposFiltradaYOrdenada = mlistSiniestroTiposFiltradaYOrdenada.Where(Function(a) a.EsActivo).ToList
                    Case 2      ' No
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{SiniestroTipo.EsActivo} = 0"
                        mlistSiniestroTiposFiltradaYOrdenada = mlistSiniestroTiposFiltradaYOrdenada.Where(Function(a) Not a.EsActivo).ToList
                End Select

                Select Case mlistSiniestroTiposFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Tipos de Siniestros para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Tipo de Siniestro.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Tipos de Siniestros.", mlistSiniestroTiposFiltradaYOrdenada.Count)
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
            Case columnSiniestroRubro.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestroTiposFiltradaYOrdenada = mlistSiniestroTiposFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.RubroNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistSiniestroTiposFiltradaYOrdenada = mlistSiniestroTiposFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.RubroNombre).ThenByDescending(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnNombre.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestroTiposFiltradaYOrdenada = mlistSiniestroTiposFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Nombre).ThenBy(Function(dgrd) dgrd.RubroNombre).ToList
                Else
                    mlistSiniestroTiposFiltradaYOrdenada = mlistSiniestroTiposFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Nombre).ThenBy(Function(dgrd) dgrd.RubroNombre).ToList
                End If
            Case columnClavePredeterminada.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestroTiposFiltradaYOrdenada = mlistSiniestroTiposFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.ClavePredeterminadaNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistSiniestroTiposFiltradaYOrdenada = mlistSiniestroTiposFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.ClavePredeterminadaNombre).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnEsActivo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestroTiposFiltradaYOrdenada = mlistSiniestroTiposFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistSiniestroTiposFiltradaYOrdenada = mlistSiniestroTiposFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistSiniestroTiposFiltradaYOrdenada

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

    Private Sub CambioFiltros() Handles comboboxRubro.SelectedIndexChanged, comboboxActivo.SelectedIndexChanged
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
        If Permisos.VerificarPermiso(Permisos.SINIESTROTIPO_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formSiniestroTipo.LoadAndShow(True, Me, 0, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Tipo de Siniestro para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.SINIESTROTIPO_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formSiniestroTipo.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSiniestroRubro, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSiniestroTipo)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Tipo de Siniestro para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.SINIESTROTIPO_ELIMINAR) Then
                Me.Cursor = Cursors.WaitCursor

                Dim row As GridRowData
                Dim Mensaje As String

                row = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)
                Mensaje = String.Format("Se eliminará el Tipo de Siniestro seleccionado.{0}{0}Rubro: {1}{0}Nombre: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, row.RubroNombre, row.Nombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                    Try
                        Using dbContext = New CSBomberosContext(True)
                            Dim SiniestroTipoEliminar As SiniestroTipo

                            SiniestroTipoEliminar = dbContext.SiniestroTipo.Find(row.IDSiniestroRubro, row.IDSiniestroTipo)
                            dbContext.SiniestroTipo.Remove(SiniestroTipoEliminar)
                            dbContext.SaveChanges()
                            SiniestroTipoEliminar = Nothing
                        End Using

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                            Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                MsgBox("No se puede eliminar el Tipo de Siniestro porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Me.Cursor = Cursors.Default
                        Exit Sub

                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar el Tipo de Siniestro.")
                    End Try

                    RefreshData()

                End If

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Tipo de Siniestro para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formSiniestroTipo.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSiniestroRubro, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSiniestroTipo)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class