Public Class formPersonaAltasBajas

#Region "Declarations"
    Private mPersonaActual As New Persona
    Private listPersonaAltaBajaFiltradaYOrdenada As List(Of PersonaAltaBaja)

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

        OrdenColumna = columnFechaAlta
        OrdenTipo = SortOrder.Ascending
    End Sub

    Friend Sub SetAppearance()
        datagridviewAltasBajas.DefaultCellStyle.Font = My.Settings.GridsAndListsFont
        datagridviewAltasBajas.ColumnHeadersDefaultCellStyle.Font = My.Settings.GridsAndListsFont
    End Sub

    Private Sub Me_FormClosed() Handles Me.FormClosed
        listPersonaAltaBajaFiltradaYOrdenada = Nothing
        mPersonaActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub RefreshData(Optional ByVal PositionIDAltaBaja As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Me.Cursor = Cursors.WaitCursor

        textboxApellidoNombre.Text = mPersonaActual.ApellidoNombre

        Using dbContext As New CSBomberosContext(True)
            listPersonaAltaBajaFiltradaYOrdenada = dbContext.PersonaAltaBaja.Where(Function(p) p.IDPersona = mPersonaActual.IDPersona).ToList
        End Using

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewAltasBajas.CurrentRow Is Nothing Then
                PositionIDAltaBaja = 0
            Else
                PositionIDAltaBaja = CType(datagridviewAltasBajas.CurrentRow.DataBoundItem, PersonaAltaBaja).IDAltaBaja
            End If
        End If

        FilterData()

        If PositionIDAltaBaja <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewAltasBajas.Rows
                If CType(CurrentRowChecked.DataBoundItem, PersonaAltaBaja).IDAltaBaja = PositionIDAltaBaja Then
                    datagridviewAltasBajas.CurrentCell = CurrentRowChecked.Cells(columnFechaAlta.Name)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub FilterData()

        If Not SkipFilterData Then

            Me.Cursor = Cursors.WaitCursor

            listPersonaAltaBajaFiltradaYOrdenada = (From pab In listPersonaAltaBajaFiltradaYOrdenada
                                                    Order By pab.FechaAlta Descending
                                                    Select pab).ToList

            Select Case listPersonaAltaBajaFiltradaYOrdenada.Count
                Case 0
                    statuslabelMain.Text = String.Format("No hay Altas-Bajas para mostrar.")
                Case 1
                    statuslabelMain.Text = String.Format("Se muestra 1 Alta-Baja.")
                Case Else
                    statuslabelMain.Text = String.Format("Se muestran {0} Altas-Bajas.", listPersonaAltaBajaFiltradaYOrdenada.Count)
            End Select

            OrderData()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub OrderData()
        ' Realizo las rutinas de ordenamiento
        Select Case OrdenColumna.Name
            Case columnFechaAlta.Name
                If OrdenTipo = SortOrder.Ascending Then
                    listPersonaAltaBajaFiltradaYOrdenada = listPersonaAltaBajaFiltradaYOrdenada.OrderBy(Function(pab) pab.FechaAlta).ThenBy(Function(pab) pab.UnidadOrigen).ToList
                Else
                    listPersonaAltaBajaFiltradaYOrdenada = listPersonaAltaBajaFiltradaYOrdenada.OrderByDescending(Function(pab) pab.FechaAlta).ThenByDescending(Function(pab) pab.UnidadOrigen).ToList
                End If
            Case columnUnidadOrigen.Name
                If OrdenTipo = SortOrder.Ascending Then
                    listPersonaAltaBajaFiltradaYOrdenada = listPersonaAltaBajaFiltradaYOrdenada.OrderBy(Function(pab) pab.UnidadOrigen).ThenBy(Function(pab) pab.FechaAlta).ToList
                Else
                    listPersonaAltaBajaFiltradaYOrdenada = listPersonaAltaBajaFiltradaYOrdenada.OrderByDescending(Function(pab) pab.UnidadOrigen).ThenByDescending(Function(pab) pab.FechaAlta).ToList
                End If
            Case columnFechaBaja.Name
                If OrdenTipo = SortOrder.Ascending Then
                    listPersonaAltaBajaFiltradaYOrdenada = listPersonaAltaBajaFiltradaYOrdenada.OrderBy(Function(pab) pab.FechaBaja).ThenBy(Function(pab) pab.UnidadDestino).ToList
                Else
                    listPersonaAltaBajaFiltradaYOrdenada = listPersonaAltaBajaFiltradaYOrdenada.OrderByDescending(Function(pab) pab.FechaBaja).ThenByDescending(Function(pab) pab.UnidadDestino).ToList
                End If
            Case columnUnidadDestino.Name
                If OrdenTipo = SortOrder.Ascending Then
                    listPersonaAltaBajaFiltradaYOrdenada = listPersonaAltaBajaFiltradaYOrdenada.OrderBy(Function(pab) pab.UnidadDestino).ThenBy(Function(pab) pab.FechaBaja).ToList
                Else
                    listPersonaAltaBajaFiltradaYOrdenada = listPersonaAltaBajaFiltradaYOrdenada.OrderByDescending(Function(pab) pab.UnidadDestino).ThenByDescending(Function(pab) pab.FechaBaja).ToList
                End If
        End Select

        datagridviewAltasBajas.AutoGenerateColumns = False
        datagridviewAltasBajas.DataSource = listPersonaAltaBajaFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        OrdenColumna.HeaderCell.SortGlyphDirection = OrdenTipo
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewAltasBajas.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewAltasBajas.Columns(e.ColumnIndex), DataGridViewColumn)

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
        If Permisos.VerificarPermiso(Permisos.PERSONA_ACCIDENTE_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewAltasBajas.Enabled = False

            formPersonaAltaBaja.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0)

            datagridviewAltasBajas.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewAltasBajas.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Accidente para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_ACCIDENTE_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewAltasBajas.Enabled = False

                Dim PersonaAltaBajaActual As PersonaAltaBaja = CType(datagridviewAltasBajas.SelectedRows(0).DataBoundItem, PersonaAltaBaja)
                formPersonaAltaBaja.LoadAndShow(True, Me, mPersonaActual.IDPersona, PersonaAltaBajaActual.IDAltaBaja)

                datagridviewAltasBajas.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub buttonEliminar_Click() Handles buttonEliminar.Click
        If datagridviewAltasBajas.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Alta-Baja para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_ACCIDENTE_ELIMINAR) Then

                Dim PersonaAltaBajaActual As PersonaAltaBaja = CType(datagridviewAltasBajas.SelectedRows(0).DataBoundItem, PersonaAltaBaja)

                Dim Mensaje As String
                Mensaje = String.Format("Se eliminará le Alta-Baja seleccionado.{0}{0}Fecha Alta: {1}{0}Unidad Origen: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, FormatDateTime(PersonaAltaBajaActual.FechaAlta, DateFormat.ShortDate), PersonaAltaBajaActual.UnidadOrigen)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Try
                        Using dbContext As New CSBomberosContext(True)
                            dbContext.PersonaAltaBaja.Remove(PersonaAltaBajaActual)
                            dbContext.SaveChanges()
                        End Using

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Me.Cursor = Cursors.Default
                        Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                            Case Errors.RelatedEntity
                                MsgBox("No se puede eliminar la Alta-Baja porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Exit Sub

                    Catch ex As Exception
                        CS_Error.ProcessError(ex, "Error al eliminar la Alta-Baja.")
                    End Try

                    RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewAltasBajas.DoubleClick
        If datagridviewAltasBajas.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Alta-Baja para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewAltasBajas.Enabled = False

            Dim PersonaAltaBajaActual As PersonaAltaBaja = CType(datagridviewAltasBajas.SelectedRows(0).DataBoundItem, PersonaAltaBaja)
            formPersonaAltaBaja.LoadAndShow(False, Me, mPersonaActual.IDPersona, PersonaAltaBajaActual.IDAltaBaja)

            datagridviewAltasBajas.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class