Public Class formPersonas

#Region "Declarations"
    Friend Class GridRowData
        Public Property IDPersona As Integer
        Public Property MatriculaNumero As String
        Public Property Apellido As String
        Public Property Nombre As String
        Public Property ApellidoNombre As String
        Public Property IDCuartel As Byte
        Public Property CuartelNombre As String
        Public Property EsActivo As Boolean
    End Class

    Private mlistPersonaBase As List(Of GridRowData)
    Private mlistPersonaFiltradaYOrdenada As List(Of GridRowData)

    Private mSkipFilterData As Boolean = False
    Private mBusquedaAplicada As Boolean = False
    Private mReportSelectionFormula As String

    Private OrdenColumna As DataGridViewColumn
    Private OrdenTipo As SortOrder
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

        OrdenColumna = columnApellido
        OrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub

    Private Sub Me_FormClosed() Handles Me.FormClosed
        mlistPersonaBase = Nothing
        mlistPersonaFiltradaYOrdenada = Nothing
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub RefreshData(Optional ByVal PositionIDPersona As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSBomberosContext(True)
                mlistPersonaBase = (From p In dbContext.Persona
                                   Join c In dbContext.Cuartel On p.IDCuartel Equals c.IDCuartel
                                   Select New GridRowData With {.IDPersona = p.IDPersona, .MatriculaNumero = p.MatriculaNumero, .Apellido = p.Apellido, .Nombre = p.Nombre, .ApellidoNombre = p.ApellidoNombre, .IDCuartel = p.IDCuartel, .CuartelNombre = c.Nombre, .EsActivo = p.EsActivo}).ToList
            End Using

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al leer las Personas.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDPersona = 0
            Else
                PositionIDPersona = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPersona
            End If
        End If

        FilterData()

        If PositionIDPersona <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDPersona = PositionIDPersona Then
                    datagridviewMain.CurrentCell = CurrentRowChecked.Cells(columnMatriculaNumero.Name)
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
                mlistPersonaFiltradaYOrdenada = mlistPersonaBase

                ' Filtro por Cuartel
                If comboboxCuartel.SelectedIndex > 0 Then
                    mlistPersonaFiltradaYOrdenada = mlistPersonaFiltradaYOrdenada.Where(Function(p) p.IDCuartel = CByte(comboboxCuartel.ComboBox.SelectedValue)).ToList
                    mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Persona.IDCuartel} = " & comboboxCuartel.ComboBox.SelectedValue.ToString
                End If

                ' Filtro por Búsqueda en Apellido y Nombre
                If mBusquedaAplicada Then
                    mlistPersonaFiltradaYOrdenada = mlistPersonaFiltradaYOrdenada.Where(Function(p) p.ApellidoNombre.ToLower.Contains(textboxBuscar.Text.ToLower.Trim)).ToList
                End If

                ' Filtro por Activo
                Select Case comboboxActivo.SelectedIndex
                    Case CS_Constants.COMBOBOX_ALLYESNO_ALL_LISTINDEX      ' Todos
                    Case CS_Constants.COMBOBOX_ALLYESNO_YES_LISTINDEX      ' Sí
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Persona.EsActivo} = True"
                        mlistPersonaFiltradaYOrdenada = mlistPersonaFiltradaYOrdenada.Where(Function(a) a.EsActivo).ToList
                    Case CS_Constants.COMBOBOX_ALLYESNO_NO_LISTINDEX       ' No
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Persona.EsActivo} = False"
                        mlistPersonaFiltradaYOrdenada = mlistPersonaFiltradaYOrdenada.Where(Function(a) Not a.EsActivo).ToList
                End Select

                Select Case mlistPersonaFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Personas para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Persona.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Personas.", mlistPersonaFiltradaYOrdenada.Count)
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
        Select Case OrdenColumna.Name
            Case columnMatriculaNumero.Name
                If OrdenTipo = SortOrder.Ascending Then
                    mlistPersonaFiltradaYOrdenada = mlistPersonaFiltradaYOrdenada.OrderBy(Function(col) col.MatriculaNumero).ToList
                Else
                    mlistPersonaFiltradaYOrdenada = mlistPersonaFiltradaYOrdenada.OrderByDescending(Function(col) col.MatriculaNumero).ToList
                End If
            Case columnApellido.Name
                If OrdenTipo = SortOrder.Ascending Then
                    mlistPersonaFiltradaYOrdenada = mlistPersonaFiltradaYOrdenada.OrderBy(Function(col) col.Apellido).ThenBy(Function(col) col.Nombre).ToList
                Else
                    mlistPersonaFiltradaYOrdenada = mlistPersonaFiltradaYOrdenada.OrderByDescending(Function(col) col.Apellido).ThenByDescending(Function(col) col.Nombre).ToList
                End If
            Case columnNombre.Name
                If OrdenTipo = SortOrder.Ascending Then
                    mlistPersonaFiltradaYOrdenada = mlistPersonaFiltradaYOrdenada.OrderBy(Function(col) col.Nombre).ThenBy(Function(col) col.Apellido).ToList
                Else
                    mlistPersonaFiltradaYOrdenada = mlistPersonaFiltradaYOrdenada.OrderByDescending(Function(col) col.Nombre).ThenByDescending(Function(col) col.Apellido).ToList
                End If
            Case columnCuartelNombre.Name
                If OrdenTipo = SortOrder.Ascending Then
                    mlistPersonaFiltradaYOrdenada = mlistPersonaFiltradaYOrdenada.OrderBy(Function(col) col.CuartelNombre).ThenBy(Function(col) col.Apellido).ThenBy(Function(col) col.Nombre).ToList
                Else
                    mlistPersonaFiltradaYOrdenada = mlistPersonaFiltradaYOrdenada.OrderByDescending(Function(col) col.CuartelNombre).ThenByDescending(Function(col) col.Apellido).ThenByDescending(Function(col) col.Nombre).ToList
                End If
        End Select
        bindingsourceMain.DataSource = mlistPersonaFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        OrdenColumna.HeaderCell.SortGlyphDirection = OrdenTipo
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Not textboxBuscar.Focused Then
            If Char.IsLetter(e.KeyChar) Then
                For Each RowCurrent As DataGridViewRow In datagridviewMain.Rows
                    If RowCurrent.Cells(columnApellido.Name).Value.ToString.StartsWith(e.KeyChar, StringComparison.CurrentCultureIgnoreCase) Then
                        RowCurrent.Cells(columnMatriculaNumero.Name).Selected = True
                        datagridviewMain.Focus()
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub

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
        FilterData()
    End Sub

    Private Sub comboboxActivo_SelectedIndexChanged() Handles comboboxActivo.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewMain.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewMain.Columns(e.ColumnIndex), DataGridViewColumn)

        If ClickedColumn.Name = columnMatriculaNumero.Name Or ClickedColumn.Name = columnApellido.Name Or ClickedColumn.Name = columnNombre.Name Then
            If ClickedColumn Is OrdenColumna Then
                ' La columna clickeada es la misma por la que ya estaba ordenado, así que cambio la dirección del orden
                If OrdenTipo = SortOrder.Ascending Then
                    OrdenTipo = SortOrder.Descending
                Else
                    OrdenTipo = SortOrder.Ascending
                End If
            Else
                ' La columna clickeada es diferencte a la que ya estaba ordenada.
                ' En primer lugar saco el ícono de orden de la columna vieja
                If Not OrdenColumna Is Nothing Then
                    OrdenColumna.HeaderCell.SortGlyphDirection = SortOrder.None
                End If

                ' Ahora preparo todo para la nueva columna
                OrdenTipo = SortOrder.Ascending
                OrdenColumna = ClickedColumn
            End If
        End If

        OrderData()
    End Sub

#End Region

#Region "Main Toolbar"
    Private Sub Agregar_Click() Handles buttonAgregar.Click
        If Permisos.VerificarPermiso(Permisos.Persona_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formPersona.LoadAndShow(True, Me, 0)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Persona para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.Persona_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                formPersona.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPersona)

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Persona para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_ELIMINAR) Then
                If MsgBox("Se eliminará la Persona seleccionada." & vbCrLf & vbCrLf & CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).ApellidoNombre & vbCrLf & vbCrLf & "¿Confirma la eliminación definitiva?", CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Try
                        Using dbContext = New CSBomberosContext(True)
                            Dim PersonaActual As Persona
                            PersonaActual = dbContext.Persona.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPersona)

                            dbContext.Persona.Attach(PersonaActual)
                            dbContext.Persona.Remove(PersonaActual)
                            dbContext.SaveChanges()
                        End Using

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Me.Cursor = Cursors.Default
                        Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                            Case Errors.RelatedEntity
                                MsgBox("No se puede eliminar la Persona porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Exit Sub

                    Catch ex As Exception
                        CS_Error.ProcessError(ex, "Error al eliminar la Persona.")
                    End Try

                    RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Persona para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formPersona.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPersona)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Imprimir_FichaPersonal(sender As Object, e As EventArgs) Handles buttonImprimir.ButtonClick, menuitemImprimirFichaPersonal.Click
        Dim CurrentRow As GridRowData

        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Persona para imprimir la Ficha.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_IMPRIMIR) Then
                CurrentRow = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)

                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                Using dbContext As New CSBomberosContext(True)
                    Dim ReporteActual As New Reporte

                    ReporteActual = dbContext.Reporte.Find(CS_Parameter_System.GetIntegerAsShort(Parametros.REPORTE_ID_PERSONA_FICHA))
                    ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro.Trim() = "IDPersona").Single.Valor = CurrentRow.IDPersona
                    If ReporteActual.Open(My.Settings.ReportsPath & "\" & ReporteActual.Archivo) Then
                        If ReporteActual.SetDatabaseConnection(pDatabase.DataSource, pDatabase.InitialCatalog, pDatabase.UserID, pDatabase.Password) Then
                            MiscFunctions.PreviewCrystalReport(ReporteActual, ReporteActual.Titulo & " - " & CurrentRow.ApellidoNombre)
                        End If
                    End If
                End Using

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Imprimir_Listado() Handles menuitemImprimirListado.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Persona para imprimir el Listado.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_IMPRIMIR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                Using dbContext As New CSBomberosContext(True)
                    Dim ReporteActual As New Reporte

                    ReporteActual = dbContext.Reporte.Find(CS_Parameter_System.GetIntegerAsShort(Parametros.REPORTE_ID_PERSONA_LISTADO))
                    If ReporteActual.Open(My.Settings.ReportsPath & "\" & ReporteActual.Archivo) Then
                        If ReporteActual.SetDatabaseConnection(pDatabase.DataSource, pDatabase.InitialCatalog, pDatabase.UserID, pDatabase.Password) Then
                            ReporteActual.RecordSelectionFormula = mReportSelectionFormula

                            MiscFunctions.PreviewCrystalReport(ReporteActual, "Listado de Personas")
                        End If
                    End If
                End Using

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub


#End Region

End Class