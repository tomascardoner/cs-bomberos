Public Class formSiniestroClaves

#Region "Declarations"

    Private mlistSiniestroClavesBase As List(Of SiniestroClave)
    Private mlistSiniestroClavesFiltradaYOrdenada As List(Of SiniestroClave)

    Private mSkipFilterData As Boolean
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

        comboboxActivo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxActivo.SelectedIndex = 1

        mSkipFilterData = False

        mOrdenColumna = columnOrden
        mOrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub RefreshData(Optional ByVal PositionIDSiniestroClave As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)

        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSBomberosContext(True)
                mlistSiniestroClavesBase = dbContext.SiniestroClave.ToList
            End Using

        Catch ex As Exception

            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Claves de Sinietros.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDSiniestroClave = 0
            Else
                PositionIDSiniestroClave = CType(datagridviewMain.CurrentRow.DataBoundItem, SiniestroClave).IDSiniestroClave
            End If
        End If

        FilterData()

        If PositionIDSiniestroClave <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, SiniestroClave).IDSiniestroClave = PositionIDSiniestroClave Then
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
                mlistSiniestroClavesFiltradaYOrdenada = mlistSiniestroClavesBase.ToList

                'Filtro por Activo
                Select Case comboboxActivo.SelectedIndex
                    Case 0      ' Todos
                    Case 1      ' Sí
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{SiniestroClave.EsActivo} = 1"
                        mlistSiniestroClavesFiltradaYOrdenada = mlistSiniestroClavesFiltradaYOrdenada.Where(Function(a) a.EsActivo).ToList
                    Case 2      ' No
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{SiniestroClave.EsActivo} = 0"
                        mlistSiniestroClavesFiltradaYOrdenada = mlistSiniestroClavesFiltradaYOrdenada.Where(Function(a) Not a.EsActivo).ToList
                End Select

                Select Case mlistSiniestroClavesFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Claves de Siniestros para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Clave de Siniestro.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Claves de Siniestros.", mlistSiniestroClavesFiltradaYOrdenada.Count)
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
                    mlistSiniestroClavesFiltradaYOrdenada = mlistSiniestroClavesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistSiniestroClavesFiltradaYOrdenada = mlistSiniestroClavesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnOrden.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestroClavesFiltradaYOrdenada = mlistSiniestroClavesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Orden).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistSiniestroClavesFiltradaYOrdenada = mlistSiniestroClavesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Orden).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnEsActivo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestroClavesFiltradaYOrdenada = mlistSiniestroClavesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistSiniestroClavesFiltradaYOrdenada = mlistSiniestroClavesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistSiniestroClavesFiltradaYOrdenada

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
        If Permisos.VerificarPermiso(Permisos.SINIESTROCLAVE_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formSiniestroClave.LoadAndShow(True, Me, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Clave de Siniestro para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.SINIESTROCLAVE_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formSiniestroClave.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, SiniestroClave).IDSiniestroClave)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninga Clave de Siniestro para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.SINIESTROCLAVE_ELIMINAR) Then
                Me.Cursor = Cursors.WaitCursor


                Dim Mensaje As String

                Mensaje = String.Format("Se eliminará la Clave de Siniestro seleccionada.{0}{0}Nombre: {1}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, CType(datagridviewMain.SelectedRows(0).DataBoundItem, SiniestroClave).Nombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                    Try
                        Using dbContext = New CSBomberosContext(True)
                            Dim SiniestroClaveEliminar As SiniestroClave

                            SiniestroClaveEliminar = dbContext.SiniestroClave.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, SiniestroClave).IDSiniestroClave)
                            dbContext.SiniestroClave.Remove(SiniestroClaveEliminar)
                            dbContext.SaveChanges()
                            SiniestroClaveEliminar = Nothing
                        End Using

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                            Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                MsgBox("No se puede eliminar la Clave de Siniestro porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Me.Cursor = Cursors.Default
                        Exit Sub

                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar la Clave de Siniestro.")
                    End Try

                    RefreshData()

                End If

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Clave de Siniestro para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formSiniestroClave.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, SiniestroClave).IDSiniestroClave)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class