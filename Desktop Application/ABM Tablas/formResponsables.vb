Public Class formResponsables

#Region "Declarations"
    Friend Class GridRowData
        Public Property IDResponsable As Byte
        Public Property ResponsableTipoNombre As String
        Public Property IDCuartel As Byte
        Public Property CuartelNombre As String
        Public Property PersonaApellidoNombre As String
    End Class

    Private mlistResponsablesBase As List(Of GridRowData)
    Private mlistResponsablesFiltradaYOrdenada As List(Of GridRowData)

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

        pFillAndRefreshLists.Cuartel(comboboxCuartel.ComboBox, True, False)

        comboboxActivo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxActivo.SelectedIndex = 1

        mSkipFilterData = False

        mOrdenColumna = columnResponsableTipo
        mOrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub RefreshData(Optional ByVal PositionIDResponsable As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)

        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSBomberosContext(True)
                mlistResponsablesBase = (From r In dbContext.Responsable
                                         Join rt In dbContext.ResponsableTipo On r.IDResponsableTipo Equals rt.IDResponsableTipo
                                         Join p In dbContext.Persona On r.IDPersona Equals p.IDPersona
                                         Group Join c In dbContext.Cuartel On r.IDCuartel Equals c.IDCuartel Into Cuarteles_Group = Group
                                         From cg In Cuarteles_Group.DefaultIfEmpty
                                         Select New GridRowData With {.IDResponsable = r.IDResponsable, .ResponsableTipoNombre = rt.Nombre, .IDCuartel = If(cg Is Nothing, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, cg.IDCuartel), .CuartelNombre = If(cg Is Nothing, "", cg.Nombre), .PersonaApellidoNombre = p.ApellidoNombre}).ToList
            End Using

        Catch ex As Exception

            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Responsables.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDResponsable = 0
            Else
                PositionIDResponsable = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDResponsable
            End If
        End If

        FilterData()

        If PositionIDResponsable <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDResponsable = PositionIDResponsable Then
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
                mlistResponsablesFiltradaYOrdenada = mlistResponsablesBase.ToList

                ' Filtro por Cuartel
                If comboboxCuartel.SelectedIndex > 0 Then
                    mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Responsable.IDCuartel} = " & CByte(comboboxCuartel.ComboBox.SelectedValue)
                    mlistResponsablesFiltradaYOrdenada = mlistResponsablesFiltradaYOrdenada.Where(Function(a) a.IDCuartel = CByte(comboboxCuartel.ComboBox.SelectedValue)).ToList
                End If

                Select Case mlistResponsablesFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Responsables para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Responsable.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Responsables.", mlistResponsablesFiltradaYOrdenada.Count)
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
            Case columnResponsableTipo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistResponsablesFiltradaYOrdenada = mlistResponsablesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.ResponsableTipoNombre).ThenBy(Function(dgrd) dgrd.PersonaApellidoNombre).ToList
                Else
                    mlistResponsablesFiltradaYOrdenada = mlistResponsablesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.ResponsableTipoNombre).ThenByDescending(Function(dgrd) dgrd.PersonaApellidoNombre).ToList
                End If
            Case columnCuartel.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistResponsablesFiltradaYOrdenada = mlistResponsablesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.ResponsableTipoNombre).ToList
                Else
                    mlistResponsablesFiltradaYOrdenada = mlistResponsablesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.CuartelNombre).ThenByDescending(Function(dgrd) dgrd.ResponsableTipoNombre).ToList
                End If
            Case columnPersona.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistResponsablesFiltradaYOrdenada = mlistResponsablesFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.PersonaApellidoNombre).ThenBy(Function(dgrd) dgrd.ResponsableTipoNombre).ToList
                Else
                    mlistResponsablesFiltradaYOrdenada = mlistResponsablesFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.PersonaApellidoNombre).ThenByDescending(Function(dgrd) dgrd.ResponsableTipoNombre).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistResponsablesFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        mOrdenColumna.HeaderCell.SortGlyphDirection = mOrdenTipo
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub CambioFiltros() Handles comboboxCuartel.SelectedIndexChanged, comboboxActivo.SelectedIndexChanged
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
        If Permisos.VerificarPermiso(Permisos.RESPONSABLE_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formResponsable.LoadAndShow(True, Me, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Responsable para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.AREA_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formResponsable.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDResponsable)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Responsable para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.RESPONSABLE_ELIMINAR) Then
                Me.Cursor = Cursors.WaitCursor


                Dim Mensaje As String

                Mensaje = String.Format("Se eliminará el Responsable seleccionado.{0}{0}Tipo: {1}{0}Cuartel: {2}{0}Persona: {3}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).ResponsableTipoNombre, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).CuartelNombre, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).PersonaApellidoNombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                    Try
                        Using dbContext = New CSBomberosContext(True)
                            Dim ResponsableEliminar As Responsable

                            ResponsableEliminar = dbContext.Responsable.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDResponsable)
                            dbContext.Responsable.Remove(ResponsableEliminar)
                            dbContext.SaveChanges()
                            ResponsableEliminar = Nothing
                        End Using

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                            Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                MsgBox("No se puede eliminar el Responsable porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Me.Cursor = Cursors.Default
                        Exit Sub

                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar el Responsable.")
                    End Try

                    RefreshData()

                End If

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Responsable para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formResponsable.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDResponsable)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class