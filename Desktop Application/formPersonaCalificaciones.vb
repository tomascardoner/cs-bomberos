Public Class formPersonaCalificaciones

#Region "Declarations"
    Friend Class ListDataItem
        Public Property Anio As Short
        Public Property InstanciaNumero As Byte
        Public Property IDConcepto As Byte
        Public Property ConceptoAbreviatura As String
        Public Property ConceptoNombre As String
        Public Property Calificacion As Byte?
    End Class

    Friend Class GridRowData
        Public Property Anio As Short
        Public Property InstanciaNumero As Byte
        Public Property AnioInstancia As String
        Public Property ConceptosCalificaciones As String = ""
    End Class

    Private mPersonaActual As New Persona
    Private mlistPersonaCalificacionBase As New List(Of GridRowData)
    Private mlistPersonaCalificacionFiltradaYOrdenada As List(Of GridRowData)

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

        OrdenColumna = columnAnioInstancia
        OrdenTipo = SortOrder.Ascending

        pFillAndRefreshLists.PersonaCalificacionAnio(comboboxAnio.ComboBox, mPersonaActual.IDPersona, True, False)
    End Sub

    Friend Sub SetAppearance()
        datagridviewCalificaciones.DefaultCellStyle.Font = My.Settings.GridsAndListsFont
        datagridviewCalificaciones.ColumnHeadersDefaultCellStyle.Font = My.Settings.GridsAndListsFont
    End Sub

    Private Sub Me_FormClosed() Handles Me.FormClosed
        mlistPersonaCalificacionFiltradaYOrdenada = Nothing
        mPersonaActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub RefreshData(Optional ByVal PositionAnio As Short = 0, Optional ByVal PositionInstanciaNumero As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listPersonaCalificacion As List(Of ListDataItem)
        Dim AnioInstanciaActual As String = ""
        Dim GridRowDataActual As New GridRowData

        Me.Cursor = Cursors.WaitCursor

        textboxApellidoNombre.Text = mPersonaActual.ApellidoNombre

        Using dbContext As New CSBomberosContext(True)
            listPersonaCalificacion = (From pc In dbContext.PersonaCalificacion
                                       Join cc In dbContext.CalificacionConcepto On pc.IDCalificacionConcepto Equals cc.IDCalificacionConcepto
                                       Where pc.IDPersona = mPersonaActual.IDPersona
                                       Order By pc.Anio, pc.InstanciaNumero, cc.Orden, cc.Nombre
                                       Select New ListDataItem With {.Anio = pc.Anio, .InstanciaNumero = pc.InstanciaNumero, .IDConcepto = cc.IDCalificacionConcepto, .ConceptoAbreviatura = cc.Abreviatura, .ConceptoNombre = cc.Nombre, .Calificacion = pc.Calificacion}).ToList
        End Using

        mlistPersonaCalificacionBase = New List(Of GridRowData)

        For Each ListDataItemActual As ListDataItem In listPersonaCalificacion
            With ListDataItemActual
                If AnioInstanciaActual <> .Anio & " - " & .InstanciaNumero Then
                    AnioInstanciaActual = .Anio & " - " & .InstanciaNumero
                    GridRowDataActual = New GridRowData
                    GridRowDataActual.Anio = .Anio
                    GridRowDataActual.InstanciaNumero = .InstanciaNumero
                    GridRowDataActual.AnioInstancia = AnioInstanciaActual
                    mlistPersonaCalificacionBase.Add(GridRowDataActual)
                End If
                ' Si no es el primer item, agrego un salto de línea
                If Not GridRowDataActual.ConceptosCalificaciones Is Nothing Then
                    GridRowDataActual.ConceptosCalificaciones &= vbCrLf
                End If
                If .ConceptoAbreviatura Is Nothing Then
                    GridRowDataActual.ConceptosCalificaciones &= String.Format("{1}: {2}", .ConceptoAbreviatura, .ConceptoNombre, .Calificacion)
                Else
                    GridRowDataActual.ConceptosCalificaciones &= String.Format("{0} - {1}: {2}", .ConceptoAbreviatura, .ConceptoNombre, .Calificacion)
                End If
            End With
        Next

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewCalificaciones.CurrentRow Is Nothing Then
                PositionAnio = 0
                PositionInstanciaNumero = 0
            Else
                PositionAnio = CType(datagridviewCalificaciones.CurrentRow.DataBoundItem, GridRowData).Anio
                PositionInstanciaNumero = CType(datagridviewCalificaciones.CurrentRow.DataBoundItem, GridRowData).InstanciaNumero
            End If
        End If

        FilterData()

        If PositionAnio <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewCalificaciones.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).Anio = PositionAnio And CType(CurrentRowChecked.DataBoundItem, GridRowData).InstanciaNumero = PositionInstanciaNumero Then
                    datagridviewCalificaciones.CurrentCell = CurrentRowChecked.Cells(columnAnioInstancia.Name)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub FilterData()

        If Not SkipFilterData Then

            Me.Cursor = Cursors.WaitCursor

            ' Inicializo las variables
            mlistPersonaCalificacionFiltradaYOrdenada = mlistPersonaCalificacionBase

            If comboboxAnio.SelectedIndex > 0 Then
                mlistPersonaCalificacionFiltradaYOrdenada = mlistPersonaCalificacionFiltradaYOrdenada.Where(Function(pc) pc.Anio = CShort(comboboxAnio.ComboBox.Text)).ToList
            End If

            Select Case mlistPersonaCalificacionFiltradaYOrdenada.Count
                Case 0
                    statuslabelMain.Text = String.Format("No hay Instancias de Calificaciones para mostrar.")
                Case 1
                    statuslabelMain.Text = String.Format("Se muestra 1 Instancia de Calificación.")
                Case Else
                    statuslabelMain.Text = String.Format("Se muestran {0} Instancias de Calificaciones.", mlistPersonaCalificacionFiltradaYOrdenada.Count)
            End Select

            OrderData()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub OrderData()
        ' Realizo las rutinas de ordenamiento
        Select Case OrdenColumna.Name
            Case columnAnioInstancia.Name
                If OrdenTipo = SortOrder.Ascending Then
                    mlistPersonaCalificacionFiltradaYOrdenada = mlistPersonaCalificacionFiltradaYOrdenada.OrderBy(Function(grd) grd.AnioInstancia).ToList
                Else
                    mlistPersonaCalificacionFiltradaYOrdenada = mlistPersonaCalificacionFiltradaYOrdenada.OrderByDescending(Function(grd) grd.AnioInstancia).ToList
                End If
        End Select

        datagridviewCalificaciones.AutoGenerateColumns = False
        datagridviewCalificaciones.DataSource = mlistPersonaCalificacionFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        OrdenColumna.HeaderCell.SortGlyphDirection = OrdenTipo
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub comboboxAnio_SelectedIndexChanged() Handles comboboxAnio.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewCalificaciones.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewCalificaciones.Columns(e.ColumnIndex), DataGridViewColumn)

        If ClickedColumn.Name = columnAnioInstancia.Name Then
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
        If Permisos.VerificarPermiso(Permisos.PERSONA_Calificacion_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewCalificaciones.Enabled = False

            formPersonaCalificacion.LoadAndShow(True, Me, mPersonaActual.IDPersona, 0, 0)

            datagridviewCalificaciones.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewCalificaciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Instancia de Calificacion para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_Calificacion_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewCalificaciones.Enabled = False

                formPersonaCalificacion.LoadAndShow(True, Me, mPersonaActual.IDPersona, CType(datagridviewCalificaciones.SelectedRows(0).DataBoundItem, GridRowData).Anio, CType(datagridviewCalificaciones.SelectedRows(0).DataBoundItem, GridRowData).InstanciaNumero)

                datagridviewCalificaciones.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub buttonEliminar_Click() Handles buttonEliminar.Click
        If datagridviewCalificaciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Instancia de Calificacion para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PERSONA_Calificacion_ELIMINAR) Then

                Dim GridRowDataActual As GridRowData = CType(datagridviewCalificaciones.SelectedRows(0).DataBoundItem, GridRowData)

                Dim Mensaje As String
                Mensaje = String.Format("Se eliminará la Instancia de Calificación seleccionada.{0}{0}Año: {1}{0}Instancia Número: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.Anio, GridRowDataActual.InstanciaNumero)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Try
                        Using dbContext As New CSBomberosContext(True)
                            For Each PersonaCalificacionActual As PersonaCalificacion In dbContext.PersonaCalificacion.Where(Function(pc) pc.IDPersona = mPersonaActual.IDPersona And pc.Anio = GridRowDataActual.Anio And pc.InstanciaNumero = GridRowDataActual.InstanciaNumero)
                                dbContext.PersonaCalificacion.Remove(PersonaCalificacionActual)
                            Next
                            dbContext.SaveChanges()
                        End Using

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Me.Cursor = Cursors.Default
                        Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                            Case Errors.RelatedEntity
                                MsgBox("No se puede eliminar la Instancia de Calificacion porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Exit Sub

                    Catch ex As Exception
                        CS_Error.ProcessError(ex, "Error al eliminar la Instancia de Calificacion.")
                    End Try

                    RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewCalificaciones.DoubleClick
        If datagridviewCalificaciones.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Instancia de Calificacion para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewCalificaciones.Enabled = False

            formPersonaCalificacion.LoadAndShow(False, Me, mPersonaActual.IDPersona, CType(datagridviewCalificaciones.SelectedRows(0).DataBoundItem, GridRowData).Anio, CType(datagridviewCalificaciones.SelectedRows(0).DataBoundItem, GridRowData).InstanciaNumero)

            datagridviewCalificaciones.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class