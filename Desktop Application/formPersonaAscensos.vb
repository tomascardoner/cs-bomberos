Public Class formPersonaAscensos

#Region "Declarations"
    Friend Class GridRowData
        Public Property IDAscenso As Byte
        Public Property Fecha As Date
        Public Property CargoNombre As String
        Public Property CargoJerarquiaNombre As String
    End Class

    Private mPersonaActual As New Persona
    Private listPersonaAscensoFiltradaYOrdenada As List(Of GridRowData)

    Private SkipFilterData As Boolean = False

    Private OrdenColumna As DataGridViewColumn
    Private OrdenTipo As SortOrder
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByRef ParentForm As Form, ByVal IDPersona As Integer)
        Using dbContext As New CSBomberosContext(True)
            mPersonaActual = dbContext.Persona.Find(IDPersona)
        End Using
        Me.MdiParent = formMDIMain
        CS_Form.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        RefreshData()
        Me.Show()
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Focus()
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        OrdenColumna = columnFecha
        OrdenTipo = SortOrder.Ascending
    End Sub

    Friend Sub SetAppearance()
        datagridviewAscensos.DefaultCellStyle.Font = My.Settings.GridsAndListsFont
        datagridviewAscensos.ColumnHeadersDefaultCellStyle.Font = My.Settings.GridsAndListsFont
    End Sub

    Private Sub Me_FormClosed() Handles Me.FormClosed
        listPersonaAscensoFiltradaYOrdenada = Nothing
        mPersonaActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub RefreshData(Optional ByVal PositionIDAscenso As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Me.Cursor = Cursors.WaitCursor

        textboxApellidoNombre.Text = mPersonaActual.ApellidoNombre

        Using dbContext As New CSBomberosContext(True)
            listPersonaAscensoFiltradaYOrdenada = (From pa In dbContext.PersonaAscenso
                                                   Join c In dbContext.Cargo On pa.IDCargo Equals c.IDCargo
                                                   Join cj In dbContext.CargoJerarquia On pa.IDCargo Equals cj.IDCargo And pa.IDJerarquia Equals cj.IDJerarquia
                                                   Where pa.IDPersona = mPersonaActual.IDPersona
                                                   Select New GridRowData With {.IDAscenso = pa.IDAscenso, .Fecha = pa.Fecha, .CargoNombre = c.Nombre, .CargoJerarquiaNombre = cj.Nombre}).ToList
        End Using

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewAscensos.CurrentRow Is Nothing Then
                PositionIDAscenso = 0
            Else
                PositionIDAscenso = CType(datagridviewAscensos.CurrentRow.DataBoundItem, GridRowData).IDAscenso
            End If
        End If

        FilterData()

        If PositionIDAscenso <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewAscensos.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDAscenso = PositionIDAscenso Then
                    datagridviewAscensos.CurrentCell = CurrentRowChecked.Cells(columnFecha.Name)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub FilterData()

        If Not SkipFilterData Then

            Me.Cursor = Cursors.WaitCursor

            Select Case listPersonaAscensoFiltradaYOrdenada.Count
                Case 0
                    statuslabelMain.Text = String.Format("No hay Ascensos para mostrar.")
                Case 1
                    statuslabelMain.Text = String.Format("Se muestra 1 Ascenso.")
                Case Else
                    statuslabelMain.Text = String.Format("Se muestran {0} Ascensos.", listPersonaAscensoFiltradaYOrdenada.Count)
            End Select

            OrderData()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub OrderData()
        ' Realizo las rutinas de ordenamiento
        Select Case OrdenColumna.Name
            Case columnFecha.Name
                If OrdenTipo = SortOrder.Ascending Then
                    listPersonaAscensoFiltradaYOrdenada = listPersonaAscensoFiltradaYOrdenada.OrderBy(Function(pa) pa.Fecha).ToList
                Else
                    listPersonaAscensoFiltradaYOrdenada = listPersonaAscensoFiltradaYOrdenada.OrderByDescending(Function(pa) pa.Fecha).ToList
                End If
            Case columnCargo.Name
                If OrdenTipo = SortOrder.Ascending Then
                    listPersonaAscensoFiltradaYOrdenada = listPersonaAscensoFiltradaYOrdenada.OrderBy(Function(pa) pa.CargoNombre).ThenBy(Function(pa) pa.Fecha).ToList
                Else
                    listPersonaAscensoFiltradaYOrdenada = listPersonaAscensoFiltradaYOrdenada.OrderByDescending(Function(pa) pa.CargoNombre).ThenByDescending(Function(pa) pa.Fecha).ToList
                End If
            Case columnJerarquia.Name
                If OrdenTipo = SortOrder.Ascending Then
                    listPersonaAscensoFiltradaYOrdenada = listPersonaAscensoFiltradaYOrdenada.OrderBy(Function(pa) pa.CargoJerarquiaNombre).ThenBy(Function(pa) pa.CargoNombre).ThenBy(Function(pa) pa.Fecha).ToList
                Else
                    listPersonaAscensoFiltradaYOrdenada = listPersonaAscensoFiltradaYOrdenada.OrderByDescending(Function(pa) pa.CargoJerarquiaNombre).ThenByDescending(Function(pa) pa.CargoNombre).ThenByDescending(Function(pa) pa.Fecha).ToList
                End If
        End Select

        datagridviewAscensos.AutoGenerateColumns = False
        datagridviewAscensos.DataSource = listPersonaAscensoFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        OrdenColumna.HeaderCell.SortGlyphDirection = OrdenTipo
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewAscensos.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewAscensos.Columns(e.ColumnIndex), DataGridViewColumn)

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

        OrderData()
    End Sub

#End Region

#Region "Main Toolbar"
    Private Sub Agregar_Click() Handles buttonAgregar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_Ascenso_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewAscensos.Enabled = False

            formPersonaAscenso.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0)

            datagridviewAscensos.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewAscensos.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Ascenso para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_Ascenso_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewAscensos.Enabled = False

                formPersonaAscenso.LoadAndShow(True, Me, mPersonaActual.IDPersona, CType(datagridviewAscensos.SelectedRows(0).DataBoundItem, GridRowData).IDAscenso)

                datagridviewAscensos.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub buttonEliminar_Click() Handles buttonEliminar.Click
        If datagridviewAscensos.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Ascenso para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_Ascenso_ELIMINAR) Then

                Dim GridRowDataActual As GridRowData = CType(datagridviewAscensos.SelectedRows(0).DataBoundItem, GridRowData)

                Dim Mensaje As String
                Mensaje = String.Format("Se eliminará el Ascenso seleccionado.{0}{0}Fecha: {1}{0}Cargo: {2}{0}Jerarquía: {3}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, FormatDateTime(GridRowDataActual.Fecha, DateFormat.ShortDate), GridRowDataActual.CargoNombre, GridRowDataActual.CargoJerarquiaNombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Try
                        Using dbContext As New CSBomberosContext(True)
                            Dim PersonaAscensoActual As PersonaAscenso
                            PersonaascensoActual = dbContext.PersonaAscenso.Find(mPersonaActual.IDPersona, GridRowDataActual.IDAscenso)
                            dbContext.PersonaAscenso.Remove(PersonaAscensoActual)
                            dbContext.SaveChanges()
                        End Using

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Me.Cursor = Cursors.Default
                        Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                            Case Errors.RelatedEntity
                                MsgBox("No se puede eliminar el Ascenso porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Exit Sub

                    Catch ex As Exception
                        CS_Error.ProcessError(ex, "Error al eliminar el Ascenso.")
                    End Try

                    RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewAscensos.DoubleClick
        If datagridviewAscensos.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Ascenso para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewAscensos.Enabled = False

            formPersonaAscenso.LoadAndShow(False, Me, mPersonaActual.IDPersona, CType(datagridviewAscensos.SelectedRows(0).DataBoundItem, GridRowData).IDAscenso)

            datagridviewAscensos.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class