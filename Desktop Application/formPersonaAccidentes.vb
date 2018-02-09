Public Class formPersonaAccidentes

#Region "Declarations"
    Private mPersonaActual As New Persona
    Private listPersonaAccidenteFiltradaYOrdenada As List(Of PersonaAccidente)

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
        datagridviewAccidentes.DefaultCellStyle.Font = My.Settings.GridsAndListsFont
        datagridviewAccidentes.ColumnHeadersDefaultCellStyle.Font = My.Settings.GridsAndListsFont
    End Sub

    Private Sub Me_FormClosed() Handles Me.FormClosed
        listPersonaAccidenteFiltradaYOrdenada = Nothing
        mPersonaActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub RefreshData(Optional ByVal PositionIDAccidente As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Me.Cursor = Cursors.WaitCursor

        textboxApellidoNombre.Text = mPersonaActual.ApellidoNombre

        Using dbContext As New CSBomberosContext(True)
            listPersonaAccidenteFiltradaYOrdenada = dbContext.PersonaAccidente.Where(Function(p) p.IDPersona = mPersonaActual.IDPersona).ToList
        End Using

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewAccidentes.CurrentRow Is Nothing Then
                PositionIDAccidente = 0
            Else
                PositionIDAccidente = CType(datagridviewAccidentes.CurrentRow.DataBoundItem, PersonaAccidente).IDAccidente
            End If
        End If

        FilterData()

        If PositionIDAccidente <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewAccidentes.Rows
                If CType(CurrentRowChecked.DataBoundItem, PersonaAccidente).IDAccidente = PositionIDAccidente Then
                    datagridviewAccidentes.CurrentCell = CurrentRowChecked.Cells(columnFecha.Name)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub FilterData()

        If Not SkipFilterData Then

            Me.Cursor = Cursors.WaitCursor

            listPersonaAccidenteFiltradaYOrdenada = (From pa In listPersonaAccidenteFiltradaYOrdenada
                                                     Order By pa.Fecha Descending
                                                     Select pa).ToList

            Select Case listPersonaAccidenteFiltradaYOrdenada.Count
                Case 0
                    statuslabelMain.Text = String.Format("No hay Accidentes para mostrar.")
                Case 1
                    statuslabelMain.Text = String.Format("Se muestra 1 Accidente.")
                Case Else
                    statuslabelMain.Text = String.Format("Se muestran {0} Accidentes.", listPersonaAccidenteFiltradaYOrdenada.Count)
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
                    listPersonaAccidenteFiltradaYOrdenada = listPersonaAccidenteFiltradaYOrdenada.OrderBy(Function(pa) pa.Fecha).ThenBy(Function(pa) pa.Diagnostico).ToList
                Else
                    listPersonaAccidenteFiltradaYOrdenada = listPersonaAccidenteFiltradaYOrdenada.OrderByDescending(Function(pa) pa.Fecha).ThenByDescending(Function(pa) pa.Diagnostico).ToList
                End If
            Case columnDianostico.Name
                If OrdenTipo = SortOrder.Ascending Then
                    listPersonaAccidenteFiltradaYOrdenada = listPersonaAccidenteFiltradaYOrdenada.OrderBy(Function(pa) pa.Diagnostico).ThenBy(Function(pa) pa.Fecha).ToList
                Else
                    listPersonaAccidenteFiltradaYOrdenada = listPersonaAccidenteFiltradaYOrdenada.OrderByDescending(Function(pa) pa.Diagnostico).ThenByDescending(Function(pa) pa.Fecha).ToList
                End If
            Case columnActaNumero.Name
                If OrdenTipo = SortOrder.Ascending Then
                    listPersonaAccidenteFiltradaYOrdenada = listPersonaAccidenteFiltradaYOrdenada.OrderBy(Function(pa) pa.ActaNumero).ThenBy(Function(pa) pa.Fecha).ToList
                Else
                    listPersonaAccidenteFiltradaYOrdenada = listPersonaAccidenteFiltradaYOrdenada.OrderByDescending(Function(pa) pa.ActaNumero).ThenByDescending(Function(pa) pa.Fecha).ToList
                End If
            Case columnFechaAlta.Name
                If OrdenTipo = SortOrder.Ascending Then
                    listPersonaAccidenteFiltradaYOrdenada = listPersonaAccidenteFiltradaYOrdenada.OrderBy(Function(pa) pa.FechaAlta).ThenBy(Function(pa) pa.Fecha).ToList
                Else
                    listPersonaAccidenteFiltradaYOrdenada = listPersonaAccidenteFiltradaYOrdenada.OrderByDescending(Function(pa) pa.FechaAlta).ThenByDescending(Function(pa) pa.Fecha).ToList
                End If
        End Select

        datagridviewAccidentes.AutoGenerateColumns = False
        datagridviewAccidentes.DataSource = listPersonaAccidenteFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        OrdenColumna.HeaderCell.SortGlyphDirection = OrdenTipo
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewAccidentes.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewAccidentes.Columns(e.ColumnIndex), DataGridViewColumn)

        If ClickedColumn.Name = columnFecha.Name Or ClickedColumn.Name = columnDianostico.Name Or ClickedColumn.Name = columnActaNumero.Name Or ClickedColumn.Name = columnFechaAlta.Name Then
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
        If Permisos.VerificarPermiso(Permisos.PERSONA_ACCIDENTE_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewAccidentes.Enabled = False

            formPersonaAccidente.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0)

            datagridviewAccidentes.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewAccidentes.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Accidente para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_ACCIDENTE_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewAccidentes.Enabled = False

                Dim PersonaAccidenteActual As PersonaAccidente = CType(datagridviewAccidentes.SelectedRows(0).DataBoundItem, PersonaAccidente)
                formPersonaAccidente.LoadAndShow(True, Me, mPersonaActual.IDPersona, PersonaAccidenteActual.IDAccidente)

                datagridviewAccidentes.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub buttonEliminar_Click() Handles buttonEliminar.Click
        If datagridviewAccidentes.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Accidente para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_ACCIDENTE_ELIMINAR) Then

                Dim PersonaAccidenteActual As PersonaAccidente = CType(datagridviewAccidentes.SelectedRows(0).DataBoundItem, PersonaAccidente)

                Dim Mensaje As String
                Mensaje = String.Format("Se eliminará el Accidente seleccionado.{0}{0}Fecha: {1}{0}Diagnóstico: {2}{0}Acta N°: {3}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, FormatDateTime(PersonaAccidenteActual.Fecha, DateFormat.ShortDate), PersonaAccidenteActual.Diagnostico, PersonaAccidenteActual.ActaNumero)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Try
                        Using dbContext As New CSBomberosContext(True)
                            Dim PersonaAccidenteEliminar As PersonaAccidente
                            PersonaAccidenteEliminar = dbContext.PersonaAccidente.Find(mPersonaActual.IDPersona, PersonaAccidenteActual.IDAccidente)
                            dbContext.PersonaAccidente.Remove(PersonaAccidenteActual)
                            dbContext.SaveChanges()
                        End Using

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Me.Cursor = Cursors.Default
                        Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                            Case Errors.RelatedEntity
                                MsgBox("No se puede eliminar el Accidente porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Exit Sub

                    Catch ex As Exception
                        CS_Error.ProcessError(ex, "Error al eliminar el Accidente.")
                    End Try

                    RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewAccidentes.DoubleClick
        If datagridviewAccidentes.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Accidente para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewAccidentes.Enabled = False

            Dim PersonaAccidenteActual As PersonaAccidente = CType(datagridviewAccidentes.SelectedRows(0).DataBoundItem, PersonaAccidente)
            formPersonaAccidente.LoadAndShow(False, Me, mPersonaActual.IDPersona, PersonaAccidenteActual.IDaccidente)

            datagridviewAccidentes.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class