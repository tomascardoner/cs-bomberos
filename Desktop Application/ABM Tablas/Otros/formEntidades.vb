Public Class formEntidades

#Region "Declarations"

    Private WithEvents maskedtextboxCuitHost As ToolStripControlHost

    Private mlistEntidadesBase As List(Of Entidad)
    Private mlistEntidadesFiltradaYOrdenada As List(Of Entidad)

    Private mSkipFilterData As Boolean
    Private mReportSelectionFormula As String

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder

#End Region

#Region "Form stuff"

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)

        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        comboboxActivo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxActivo.SelectedIndex = 1

        InicializarFiltroDeCuit()

        mSkipFilterData = False

        mOrdenColumna = columnNombre
        mOrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub

    Private Sub InicializarFiltroDeCuit()
        maskedtextboxCuitHost = New ToolStripControlHost(New MaskedTextBox()) With {.Width = 99}
        CType(maskedtextboxCuitHost.Control, MaskedTextBox).Mask = "00-00000000-0"
        toolstripCuit.Items.Insert(1, maskedtextboxCuitHost)
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub RefreshData(Optional ByVal PositionIDEntidad As Short = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)

        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSBomberosContext(True)
                mlistEntidadesBase = dbContext.Entidad.ToList
            End Using

        Catch ex As Exception

            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Entidades.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDEntidad = 0
            Else
                PositionIDEntidad = CType(datagridviewMain.CurrentRow.DataBoundItem, Entidad).IDEntidad
            End If
        End If

        FilterData()

        If PositionIDEntidad <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, Entidad).IDEntidad = PositionIDEntidad Then
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
                mlistEntidadesFiltradaYOrdenada = mlistEntidadesBase.ToList

                ' Filtro por Activo
                Select Case comboboxActivo.SelectedIndex
                    Case 0      ' Todos
                    Case 1      ' Sí
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Entidad.EsActivo} = 1"
                        mlistEntidadesFiltradaYOrdenada = mlistEntidadesFiltradaYOrdenada.Where(Function(e) e.EsActivo).ToList
                    Case 2      ' No
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Entidad.EsActivo} = 0"
                        mlistEntidadesFiltradaYOrdenada = mlistEntidadesFiltradaYOrdenada.Where(Function(e) Not e.EsActivo).ToList
                End Select

                ' Filtro por Tipo
                If Not (buttonCompras.Checked And buttonVentas.Checked) Then
                    If buttonCompras.Checked Then
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Entidad.HabilitarCompra} = 1"
                        mlistEntidadesFiltradaYOrdenada = mlistEntidadesFiltradaYOrdenada.Where(Function(e) e.HabilitarCompra).ToList
                    End If
                    If buttonVentas.Checked Then
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Entidad.HabilitarVenta} = 1"
                        mlistEntidadesFiltradaYOrdenada = mlistEntidadesFiltradaYOrdenada.Where(Function(e) e.HabilitarVenta).ToList
                    End If
                End If

                ' Filtro por CUIT
                If maskedtextboxCuitHost.Text.RemoveNotNumbers() <> String.Empty Then
                    mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Entidad.Cuit} LIKE """ & maskedtextboxCuitHost.Text & """"
                    mlistEntidadesFiltradaYOrdenada = mlistEntidadesFiltradaYOrdenada.Where(Function(e) e.Cuit.HasValue AndAlso e.Cuit.Value.ToString.Contains(maskedtextboxCuitHost.Text.RemoveNotNumbers())).ToList
                End If

                Select Case mlistEntidadesFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Entidades para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Entidad.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Entidades.", mlistEntidadesFiltradaYOrdenada.Count)
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
                    mlistEntidadesFiltradaYOrdenada = mlistEntidadesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Nombre).ThenBy(Function(dgrd) dgrd.EsActivo).ToList
                Else
                    mlistEntidadesFiltradaYOrdenada = mlistEntidadesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Nombre).ThenBy(Function(dgrd) dgrd.EsActivo).ToList
                End If
            Case columnEsActivo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistEntidadesFiltradaYOrdenada = mlistEntidadesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistEntidadesFiltradaYOrdenada = mlistEntidadesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistEntidadesFiltradaYOrdenada

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

    Private Sub CambioFiltros(sender As Object, e As EventArgs) Handles comboboxActivo.SelectedIndexChanged, buttonCompras.Click, buttonVentas.Click
        FilterData()
    End Sub

    Private Sub CambioCuitEnter(sender As Object, e As KeyPressEventArgs) Handles maskedtextboxCuitHost.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            FilterData()
        End If
    End Sub

    Private Sub CambioCuitCompleto(sender As Object, e As KeyEventArgs) Handles maskedtextboxCuitHost.KeyUp
        If maskedtextboxCuitHost.Text.RemoveNotNumbers().Length = 11 Then
            FilterData()
        End If
    End Sub

    Private Sub BorrarCuit(sender As Object, e As EventArgs) Handles buttonCuitBorrar.Click
        If maskedtextboxCuitHost.Text.RemoveNotNumbers() <> String.Empty Then
            maskedtextboxCuitHost.Text = String.Empty
            FilterData()
        End If
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
        If Permisos.VerificarPermiso(Permisos.ENTIDAD_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formEntidad.LoadAndShow(True, Me, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Entidad para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.ENTIDAD_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formEntidad.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, Entidad).IDEntidad)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Entidad para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.ENTIDAD_ELIMINAR) Then
                Me.Cursor = Cursors.WaitCursor


                Dim Mensaje As String

                Mensaje = String.Format("Se eliminará la Entidad seleccionada.{0}{0}Nombre: {1}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, CType(datagridviewMain.SelectedRows(0).DataBoundItem, Entidad).Nombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                    Try
                        Using dbContext = New CSBomberosContext(True)
                            Dim EntidadEliminar As Entidad

                            EntidadEliminar = dbContext.Entidad.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, Entidad).IDEntidad)
                            dbContext.Entidad.Remove(EntidadEliminar)
                            dbContext.SaveChanges()
                            EntidadEliminar = Nothing
                        End Using

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                            Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                MsgBox("No se puede eliminar la Entidad porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Me.Cursor = Cursors.Default
                        Exit Sub

                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar la Entidad.")
                    End Try

                    RefreshData()

                End If

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Entidad para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formEntidad.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, Entidad).IDEntidad)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class