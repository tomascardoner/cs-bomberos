Public Class formAcademiaAsistenciaTipos

#Region "Declarations"

    Private mlistAcademiaAsistenciaTiposBase As List(Of AcademiaAsistenciaTipo)
    Private mlistAcademiaAsistenciaTiposFiltradaYOrdenada As List(Of AcademiaAsistenciaTipo)

    Private mSkipFilterData As Boolean = False
    Private mBusquedaAplicada As Boolean = False
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

    Friend Sub RefreshData(Optional ByVal PositionIDAcademiaAsistenciaTipo As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)

        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSBomberosContext(True)
                mlistAcademiaAsistenciaTiposBase = dbContext.AcademiaAsistenciaTipo.ToList
            End Using

        Catch ex As Exception

            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Tipos de Asistencia a Academias.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDAcademiaAsistenciaTipo = 0
            Else
                PositionIDAcademiaAsistenciaTipo = CType(datagridviewMain.CurrentRow.DataBoundItem, AcademiaAsistenciaTipo).IDAcademiaAsistenciaTipo
            End If
        End If

        FilterData()

        If PositionIDAcademiaAsistenciaTipo <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, AcademiaAsistenciaTipo).IDAcademiaAsistenciaTipo = PositionIDAcademiaAsistenciaTipo Then
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
                mlistAcademiaAsistenciaTiposFiltradaYOrdenada = mlistAcademiaAsistenciaTiposBase.ToList

                'Filtro por Activo
                Select Case comboboxActivo.SelectedIndex
                    Case 0      ' Todos
                    Case 1      ' Sí
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{AcademiaAsistenciaTipo.EsActivo} = 1"
                        mlistAcademiaAsistenciaTiposFiltradaYOrdenada = mlistAcademiaAsistenciaTiposFiltradaYOrdenada.Where(Function(a) a.EsActivo).ToList
                    Case 2      ' No
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{AcademiaAsistenciaTipo.EsActivo} = 0"
                        mlistAcademiaAsistenciaTiposFiltradaYOrdenada = mlistAcademiaAsistenciaTiposFiltradaYOrdenada.Where(Function(a) Not a.EsActivo).ToList
                End Select

                Select Case mlistAcademiaAsistenciaTiposFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Tipos de Asistencia a Academias para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Tipo de Asistencia a Academias.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Tipos de Asistencia a Academias.", mlistAcademiaAsistenciaTiposFiltradaYOrdenada.Count)
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
                    mlistAcademiaAsistenciaTiposFiltradaYOrdenada = mlistAcademiaAsistenciaTiposFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistAcademiaAsistenciaTiposFiltradaYOrdenada = mlistAcademiaAsistenciaTiposFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnOrden.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistAcademiaAsistenciaTiposFiltradaYOrdenada = mlistAcademiaAsistenciaTiposFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Orden).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistAcademiaAsistenciaTiposFiltradaYOrdenada = mlistAcademiaAsistenciaTiposFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Orden).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
            Case columnEsActivo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistAcademiaAsistenciaTiposFiltradaYOrdenada = mlistAcademiaAsistenciaTiposFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                Else
                    mlistAcademiaAsistenciaTiposFiltradaYOrdenada = mlistAcademiaAsistenciaTiposFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.EsActivo).ThenBy(Function(dgrd) dgrd.Nombre).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistAcademiaAsistenciaTiposFiltradaYOrdenada

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
        If Permisos.VerificarPermiso(Permisos.ACADEMIAASISTENCIATIPO_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formAcademiaAsistenciaTipo.LoadAndShow(True, Me, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Tipo de Asistencia a Academias para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.ACADEMIAASISTENCIATIPO_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formAcademiaAsistenciaTipo.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, AcademiaAsistenciaTipo).IDAcademiaAsistenciaTipo)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Tipo de Asistencia a Academias para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.ACADEMIAASISTENCIATIPO_ELIMINAR) Then
                Me.Cursor = Cursors.WaitCursor


                Dim Mensaje As String

                Mensaje = String.Format("Se eliminará el Tipo de Asistencia a Academias seleccionado.{0}{0}Nombre: {1}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, CType(datagridviewMain.SelectedRows(0).DataBoundItem, AcademiaAsistenciaTipo).Nombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                    Try
                        Using dbContext = New CSBomberosContext(True)
                            Dim AcademiaAsistenciaTipoEliminar As AcademiaAsistenciaTipo

                            AcademiaAsistenciaTipoEliminar = dbContext.AcademiaAsistenciaTipo.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, AcademiaAsistenciaTipo).IDAcademiaAsistenciaTipo)
                            dbContext.AcademiaAsistenciaTipo.Remove(AcademiaAsistenciaTipoEliminar)
                            dbContext.SaveChanges()
                            AcademiaAsistenciaTipoEliminar = Nothing
                        End Using

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                            Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                MsgBox("No se puede eliminar el Tipo de Asistencia a Academias porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Me.Cursor = Cursors.Default
                        Exit Sub

                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar el Tipo de Asistencia a Academias.")
                    End Try

                    RefreshData()

                End If

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Tipo de Asistencia a Academias para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formAcademiaAsistenciaTipo.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, AcademiaAsistenciaTipo).IDAcademiaAsistenciaTipo)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class