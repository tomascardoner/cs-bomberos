Public Class formPersonasSeleccionar

#Region "Declarations"

    Private listPersonasBase As List(Of PersonasObtenerConEstadoYJerarquia_Result)
    Private listPersonasFiltradaYOrdenada As List(Of PersonasObtenerConEstadoYJerarquia_Result)

    Private ReadOnly SkipFilterData As Boolean
    Private BusquedaAplicada As Boolean
    Private ReadOnly FiltroSoloMostrarEnAsistencia As Boolean

    Private OrdenColumna As DataGridViewColumn
    Private OrdenTipo As SortOrder

    Private ReadOnly MultiSeleccion As Boolean

#End Region

#Region "Form stuff"

    Friend Sub SetAppearance()
        DataGridSetAppearance(datagridviewMain)
    End Sub

    Public Sub New(multiseleccion As Boolean, idCuartel As Byte?, soloMostrarActivos As Boolean, soloMostrarEnAsistencia As Boolean)
        InitializeComponent()

        SetAppearance()

        SkipFilterData = True

        ' Establezco los valores de la multi selección
        multiseleccion = multiseleccion
        datagridviewMain.MultiSelect = multiseleccion

        Using context As New CSBomberosContext(True)
            ListasComunes.LlenarComboBoxCuarteles(context, comboboxCuartel.ComboBox, True, False)
        End Using
        pFillAndRefreshLists.PersonaEstadoActual(comboboxEstadoActual.ComboBox, True)

        If idCuartel.HasValue Then
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxCuartel.ComboBox, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, idCuartel)
        End If
        If soloMostrarActivos Then
            comboboxEstadoActual.SelectedIndex = 2
        End If
        FiltroSoloMostrarEnAsistencia = soloMostrarEnAsistencia

        SkipFilterData = False

        OrdenColumna = columnApellido
        OrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub

    Private Sub Me_FormClosed() Handles Me.FormClosed
        listPersonasBase = Nothing
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub RefreshData()
        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSBomberosContext(True)
                listPersonasBase = dbContext.PersonasObtenerConEstadoYJerarquia().ToList
            End Using

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Personas.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        FilterData()
    End Sub

    Private Sub FilterData()

        If Not SkipFilterData Then

            Me.Cursor = Cursors.WaitCursor

            Try
                ' Inicializo las variables
                listPersonasFiltradaYOrdenada = listPersonasBase

                ' Filtro por Búsqueda en Matrícula o Apellido y Nombre
                If BusquedaAplicada Then
                    Dim valorBusqueda As String = textboxBuscar.Text.ToLower().RemoveDiacritics().Trim()
                    If valorBusqueda.Length = 3 AndAlso valorBusqueda.IsAllDigits Then
                        ' Matrícula
                        listPersonasFiltradaYOrdenada = listPersonasFiltradaYOrdenada.Where(Function(p) p.MatriculaNumero.TrimEnd().EndsWith(valorBusqueda)).ToList
                    Else
                        ' Apellido y Nombre
                        listPersonasFiltradaYOrdenada = listPersonasFiltradaYOrdenada.Where(Function(p) p.ApellidoNombre.ToLower().RemoveDiacritics().Contains(valorBusqueda)).ToList
                    End If
                End If

                ' Filtro por Cuartel
                If comboboxCuartel.SelectedIndex > 0 Then
                    listPersonasFiltradaYOrdenada = listPersonasFiltradaYOrdenada.Where(Function(p) p.IDCuartel = CByte(comboboxCuartel.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Estado actual
                Select Case comboboxEstadoActual.SelectedIndex
                    Case 0  ' Todos
                    Case 1  ' Desconocido
                        listPersonasFiltradaYOrdenada = listPersonasFiltradaYOrdenada.Where(Function(a) Not a.IDBajaMotivo.HasValue).ToList
                    Case 2  ' Activo
                        listPersonasFiltradaYOrdenada = listPersonasFiltradaYOrdenada.Where(Function(a) a.IDBajaMotivo.HasValue AndAlso a.IDBajaMotivo.Value = 0).ToList
                    Case 3  ' Inactivo
                        listPersonasFiltradaYOrdenada = listPersonasFiltradaYOrdenada.Where(Function(a) a.IDBajaMotivo.HasValue AndAlso a.IDBajaMotivo.Value > 0).ToList
                    Case Else
                        listPersonasFiltradaYOrdenada = listPersonasFiltradaYOrdenada.Where(Function(a) a.IDBajaMotivo.HasValue AndAlso a.IDBajaMotivo.Value = CByte(comboboxEstadoActual.ComboBox.SelectedValue)).ToList
                End Select

                ' Filtro por no Jerarquia Inferior
                If FiltroSoloMostrarEnAsistencia Then
                    listPersonasFiltradaYOrdenada = listPersonasFiltradaYOrdenada.Where(Function(p) Not p.JerarquiaInferior.Value).ToList
                End If

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
        If OrdenColumna Is columnApellido Then
            If OrdenTipo = SortOrder.Ascending Then
                listPersonasFiltradaYOrdenada = listPersonasFiltradaYOrdenada.OrderBy(Function(col) col.Apellido & col.Nombre).ToList
            Else
                listPersonasFiltradaYOrdenada = listPersonasFiltradaYOrdenada.OrderByDescending(Function(col) col.Apellido & col.Nombre).ToList
            End If
        ElseIf OrdenColumna Is columnNombre Then
            If OrdenTipo = SortOrder.Ascending Then
                listPersonasFiltradaYOrdenada = listPersonasFiltradaYOrdenada.OrderBy(Function(col) col.Nombre & col.Apellido).ToList
            Else
                listPersonasFiltradaYOrdenada = listPersonasFiltradaYOrdenada.OrderByDescending(Function(col) col.Nombre & col.Apellido).ToList
            End If
        End If
        bindingsourceMain.DataSource = listPersonasFiltradaYOrdenada

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
                        RowCurrent.Cells(columnApellido.Name).Selected = True
                        datagridviewMain.Focus()
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub textboxBuscar_GotFocus(sender As Object, e As EventArgs) Handles textboxBuscar.GotFocus
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

    Private Sub buttonBuscarBorrar_Click(sender As Object, e As EventArgs) Handles buttonBuscarBorrar.Click
        If BusquedaAplicada Then
            textboxBuscar.Clear()
            BusquedaAplicada = False
            FilterData()
        End If
    End Sub

    Private Sub CuartelChanged() Handles comboboxCuartel.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub EstadoActualChanged() Handles comboboxEstadoActual.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewMain.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewMain.Columns(e.ColumnIndex), DataGridViewColumn)

        If ClickedColumn Is columnApellido Or ClickedColumn Is columnNombre Then
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
                If OrdenColumna IsNot Nothing Then
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

    Private Sub Seleccionar(sender As Object, e As EventArgs) Handles datagridviewMain.DoubleClick, buttonSeleccionar.Click
        If MultiSeleccion And datagridviewMain.SelectedRows.Count = 0 Then
            MsgBox("No se seleccionó ninguna Persona.", vbInformation, My.Application.Info.Title)
        ElseIf MultiSeleccion = False And datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Persona para seleccionar.", vbInformation, My.Application.Info.Title)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub Cancelar(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub datagridviewMain_KeyDown(sender As Object, e As KeyEventArgs) Handles datagridviewMain.KeyDown
        If e.KeyCode = Keys.Enter Then
            buttonSeleccionar.PerformClick()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Escape Then
            buttonCancelar.PerformClick()
        End If
    End Sub

#End Region

End Class