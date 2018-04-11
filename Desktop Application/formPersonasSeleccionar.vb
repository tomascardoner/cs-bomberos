Public Class formPersonasSeleccionar

#Region "Declarations"
    Private listPersonaBase As List(Of Persona)
    Private listPersonaFiltradaYOrdenada As List(Of Persona)

    Private SkipFilterData As Boolean = False
    Private BusquedaAplicada As Boolean = False

    Private OrdenColumna As DataGridViewColumn
    Private OrdenTipo As SortOrder

    Friend Const COLUMNA_IDPersona As String = "columnIDPersona"
    Private Const COLUMNA_APELLIDO As String = "columnApellido"
    Private Const COLUMNA_NOMBRE As String = "columnNombre"
#End Region

#Region "Form stuff"
    Friend Sub SetAppearance()
        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub formPersonaesSeleccionar_Load() Handles Me.Load
        SetAppearance()

        SkipFilterData = True

        comboboxActivo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxActivo.SelectedIndex = 1

        SkipFilterData = False

        OrdenColumna = columnApellido
        OrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub

    Private Sub formPersonaes_FormClosed() Handles Me.FormClosed
        listPersonaBase = Nothing
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub RefreshData(Optional ByVal PositionIDPersona As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Me.Cursor = Cursors.WaitCursor

        Using dbcontext As New CSBomberosContext(True)
            listPersonaBase = dbcontext.Persona.ToList
        End Using

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDPersona = 0
            Else
                PositionIDPersona = CInt(datagridviewMain.CurrentRow.Cells(COLUMNA_IDPersona).Value)
            End If
        End If

        FilterData()

        If PositionIDPersona <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CInt(CurrentRowChecked.Cells(COLUMNA_IDPersona).Value) = PositionIDPersona Then
                    datagridviewMain.CurrentCell = CurrentRowChecked.Cells(COLUMNA_IDPersona)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub FilterData()

        If Not SkipFilterData Then

            Me.Cursor = Cursors.WaitCursor

            If BusquedaAplicada Then
                listPersonaFiltradaYOrdenada = (From ent In listPersonaBase
                                   Where ent.ApellidoNombre.ToLower.Contains(textboxBuscar.Text.ToLower.Trim) And (comboboxActivo.SelectedIndex = 0 Or (comboboxActivo.SelectedIndex = 1 And ent.EsActivo) Or (comboboxActivo.SelectedIndex = 2 And Not ent.EsActivo))
                                    Select ent).ToList
            Else
                listPersonaFiltradaYOrdenada = (From ent In listPersonaBase
                                   Where comboboxActivo.SelectedIndex = 0 Or (comboboxActivo.SelectedIndex = 1 And ent.EsActivo) Or (comboboxActivo.SelectedIndex = 2 And Not ent.EsActivo)
                                   Select ent).ToList
            End If

            OrderData()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub OrderData()
        ' Realizo las rutinas de ordenamiento
        Select Case OrdenColumna.Name
            Case COLUMNA_IDPersona
                If OrdenTipo = SortOrder.Ascending Then
                    listPersonaFiltradaYOrdenada = listPersonaFiltradaYOrdenada.OrderBy(Function(col) col.IDPersona).ToList
                Else
                    listPersonaFiltradaYOrdenada = listPersonaFiltradaYOrdenada.OrderByDescending(Function(col) col.IDPersona).ToList
                End If
            Case COLUMNA_APELLIDO
                If OrdenTipo = SortOrder.Ascending Then
                    listPersonaFiltradaYOrdenada = listPersonaFiltradaYOrdenada.OrderBy(Function(col) col.Apellido & col.Nombre).ToList
                Else
                    listPersonaFiltradaYOrdenada = listPersonaFiltradaYOrdenada.OrderByDescending(Function(col) col.Apellido & col.Nombre).ToList
                End If
            Case COLUMNA_NOMBRE
                If OrdenTipo = SortOrder.Ascending Then
                    listPersonaFiltradaYOrdenada = listPersonaFiltradaYOrdenada.OrderBy(Function(col) col.Nombre & col.Apellido).ToList
                Else
                    listPersonaFiltradaYOrdenada = listPersonaFiltradaYOrdenada.OrderByDescending(Function(col) col.Nombre & col.Apellido).ToList
                End If
        End Select
        bindingsourceMain.DataSource = listPersonaFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        OrdenColumna.HeaderCell.SortGlyphDirection = OrdenTipo
    End Sub

#End Region

#Region "Controls behavior"
    Private Sub formPersonaesSeleccionar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Not textboxBuscar.Focused Then
            If Char.IsLetter(e.KeyChar) Then
                For Each RowCurrent As DataGridViewRow In datagridviewMain.Rows
                    If RowCurrent.Cells(COLUMNA_APELLIDO).Value.ToString.StartsWith(e.KeyChar, StringComparison.CurrentCultureIgnoreCase) Then
                        RowCurrent.Cells(COLUMNA_IDPersona).Selected = True
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
                BusquedaAplicada = True
                FilterData()
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub buttonBuscarBorrar_Click() Handles buttonBuscarBorrar.Click
        If BusquedaAplicada Then
            textboxBuscar.Clear()
            BusquedaAplicada = False
            FilterData()
        End If
    End Sub

    Private Sub comboboxActivo_SelectedIndexChanged() Handles comboboxActivo.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewMain.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewMain.Columns(e.ColumnIndex), DataGridViewColumn)

        If ClickedColumn.Name = COLUMNA_IDPersona Or ClickedColumn.Name = COLUMNA_APELLIDO Or ClickedColumn.Name = COLUMNA_NOMBRE Then
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
    Private Sub Seleccionar() Handles datagridviewMain.DoubleClick, buttonSeleccionar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Persona para seleccionar.", vbInformation, My.Application.Info.Title)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub Cancelar() Handles buttonCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub datagridviewMain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles datagridviewMain.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Seleccionar()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Cancelar()
        End If
    End Sub

#End Region

End Class