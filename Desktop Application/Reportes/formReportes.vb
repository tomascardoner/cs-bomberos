Public Class formReportes

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mIDModulo As Byte
    Private mModuloNombre As String

#End Region

#Region "Form stuff"

    Friend Sub SetValues(ByVal IDModulo As Byte, ByVal ModuloNombre As String)
        mIDModulo = IDModulo
        mModuloNombre = ModuloNombre
    End Sub

    Private Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageReporte32)
        Me.Text = "Reportes - " & mModuloNombre
    End Sub

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetAppearance()

        CargarListaReportes()

        treeviewReportes.Font = pAppearanceConfig.ListsFont
        listviewParametros.Font = pAppearanceConfig.ListsFont
    End Sub

    Private Sub Me_Unload() Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
    End Sub

#End Region

#Region "Reportes"

    Private Sub CargarListaReportes()
        Dim ReporteGrupoNodo As TreeNode = Nothing
        Dim ReporteGrupoNodoPrimero As TreeNode = Nothing
        Dim ReporteNodo As TreeNode
        Dim ReporteNodoPrimero As TreeNode = Nothing

        Try
            treeviewReportes.BeginUpdate()
            For Each reporteGrupo As ReporteGrupo In mdbContext.ReporteGrupo.Where(Function(rg) rg.IDModulo = mIDModulo).OrderBy(Function(rg) rg.Orden).ThenBy(Function(rg) rg.Nombre)
                If Not reporteGrupo.Reportes.Where(Function(r) r.MostrarEnVisor = True).Any() Then
                    Continue For
                End If

                For Each reporte As Reporte In reporteGrupo.Reportes.Where(Function(r) r.MostrarEnVisor = True).OrderBy(Function(r) r.Orden).ThenBy(Function(r) r.Nombre)
                    If Permisos.VerificarPermisoReporte(reporte.IDReporte, False) Then
                        ' Si no está creado el nodo del Grupo, lo creo
                        If ReporteGrupoNodo Is Nothing OrElse ReporteGrupoNodo.Text <> reporteGrupo.Nombre Then
                            ReporteGrupoNodo = New TreeNode(reporteGrupo.Nombre) With {.Tag = reporteGrupo}
                            treeviewReportes.Nodes.Add(ReporteGrupoNodo)

                            If ReporteGrupoNodoPrimero Is Nothing Then
                                ReporteGrupoNodoPrimero = ReporteGrupoNodo
                            End If
                        End If

                        ' Agrego el Reporte
                        ReporteNodo = New TreeNode(reporte.Nombre) With {.Tag = reporte}
                        ReporteGrupoNodo.Nodes.Add(ReporteNodo)

                        If ReporteNodoPrimero Is Nothing Then
                            ReporteNodoPrimero = ReporteNodo
                        End If
                    End If
                Next
            Next
            treeviewReportes.ExpandAll()
            If ReporteGrupoNodoPrimero IsNot Nothing Then
                treeviewReportes.TopNode = ReporteGrupoNodoPrimero
            End If
            If ReporteNodoPrimero IsNot Nothing Then
                treeviewReportes.SelectedNode = ReporteNodoPrimero
            End If

            treeviewReportes.EndUpdate()

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer la lista de Reportes.")
        End Try
    End Sub

    Private Sub Siguiente() Handles treeviewReportes.NodeMouseDoubleClick, buttonSiguiente.Click
        If treeviewReportes.SelectedNode Is Nothing Then
            MsgBox("No hay ningún Reporte seleccionado para imprimir.", vbInformation, My.Application.Info.Title)
        End If
        If treeviewReportes.SelectedNode.Level = 0 Then
            MsgBox("Debe seleccionar un Reporte (y no un Grupo) para imprimir.", vbInformation, My.Application.Info.Title)
            Exit Sub
        End If
        If Not Permisos.VerificarPermisoReporte(CType(treeviewReportes.SelectedNode.Tag, Reporte).IDReporte) Then
            Exit Sub
        End If

        CargarListaParametros()
        panelReportes.Hide()
        panelParametros.Show()
    End Sub

#End Region

#Region "Parámetros"

    Private Sub CargarListaParametros()
        Dim ReporteActual As Reporte
        Dim ParametroListViewItem As ListViewItem

        listviewParametros.Items.Clear()

        Try
            listviewParametros.BeginUpdate()
            ReporteActual = CType(treeviewReportes.SelectedNode.Tag, Reporte)

            labelParametrosTitulo.Text = $"Parámetros del Reporte: ""{treeviewReportes.SelectedNode.Parent.Text} - {ReporteActual.Nombre}"""

            For Each ParametroActual As ReporteParametro In ReporteActual.ReporteParametros.OrderBy(Function(rp) rp.Orden)

                With ParametroActual
                    ' Agrego el Parámetro si tiene especificado el Orden, si no, no
                    If .Orden IsNot Nothing Then

                        ParametroListViewItem = New ListViewItem(.Nombre)
                        ParametroListViewItem.Name = CardonerSistemas.Constants.KeyStringer & .IDParametro
                        If .Requerido Then
                            ParametroListViewItem.SubItems.Add("Sí")
                        Else
                            ParametroListViewItem.SubItems.Add("No")
                        End If

                        If VarType(.Valor) = vbEmpty Then
                            ParametroListViewItem.SubItems.Add("")
                        Else
                            ParametroListViewItem.SubItems.Add(.ValorParaMostrar)
                        End If

                        listviewParametros.Items.Add(ParametroListViewItem)
                    End If
                End With
            Next
            listviewParametros.EndUpdate()

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer la lista de Parámetros del Reporte.")
        End Try
    End Sub

    Private Sub EditarValorParametro(sender As Object, e As EventArgs) Handles menuParametroEditar.Click, listviewParametros.DoubleClick
        Dim ReporteActual As Reporte
        Dim ParametroActual As ReporteParametro
        Dim ListViewItemActual As ListViewItem

        If listviewParametros.SelectedItems.Count = 0 Then
            MsgBox("No hay ningún Parámetro seleccionado para modificar.", vbInformation, My.Application.Info.Title)
        Else
            ReporteActual = CType(treeviewReportes.SelectedNode.Tag, Reporte)
            ParametroActual = ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro = listviewParametros.SelectedItems(0).Name.Remove(0, CardonerSistemas.Constants.KeyStringer.Length)).First
            ListViewItemActual = listviewParametros.SelectedItems(0)

            Select Case ParametroActual.Tipo
                Case Reportes.REPORTE_PARAMETRO_TIPO_PERSONA
                    Dim personaSeleccionada As ListasPersonas.PersonaSeleccionada

                    personaSeleccionada = ListasPersonas.SeleccionarPersona(Me, False, Nothing, False)
                    If personaSeleccionada IsNot Nothing Then
                        ParametroActual.Valor = personaSeleccionada.IDPersona
                        ParametroActual.ValorParaMostrar = personaSeleccionada.ApellidoNombre
                        ListViewItemActual.SubItems(2).Text = ParametroActual.ValorParaMostrar
                    End If

                    BorrarValoresDeParametrosHijos(ParametroActual, ReporteActual)

                Case Reportes.REPORTE_PARAMETRO_TIPO_PERSONAMULTIPLE
                    Dim fps As New formPersonasSeleccionar(True, 0, False)

                    If fps.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        Const IDPersonaDelimiter As String = "@"
                        Const PersonaNombreDelimiter As String = " - "

                        Dim PersonaSeleccionada As PersonasObtenerConEstado_Result
                        Dim Valores As String = String.Empty
                        Dim ValorParaMostrar As String = String.Empty

                        For Each dataRow As DataGridViewRow In fps.datagridviewMain.SelectedRows
                            PersonaSeleccionada = CType(dataRow.DataBoundItem, PersonasObtenerConEstado_Result)
                            Valores = (PersonaSeleccionada.IDPersona & IDPersonaDelimiter & Valores)
                            ValorParaMostrar = (PersonaNombreDelimiter & PersonaSeleccionada.ApellidoNombre & ValorParaMostrar)
                        Next
                        ValorParaMostrar = ValorParaMostrar.Remove(0, PersonaNombreDelimiter.Length)
                        PersonaSeleccionada = Nothing

                        ParametroActual.Valor = Valores
                        ParametroActual.ValorParaMostrar = ValorParaMostrar
                        ListViewItemActual.SubItems(2).Text = ValorParaMostrar
                    End If
                    fps.Dispose()

                Case Reportes.REPORTE_PARAMETRO_TIPO_PERSONAFAMILIARMULTIPLE
                    Dim frpf As New formReportesParametroFamiliares
                    Dim ParametroPadre As ReporteParametro = Nothing

                    ' Busco si el parámetro actual tiene un parámetro padre
                    For Each currentReporteParametro As ReporteParametro In ReporteActual.ReporteParametros
                        If ParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_PERSONAFAMILIARMULTIPLE AndAlso currentReporteParametro.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_PERSONA Then
                            ParametroPadre = currentReporteParametro
                            If ParametroPadre.Valor Is Nothing Then
                                MsgBox("Debe seleccionar a la Persona para poder seleccionar los familiares.", MsgBoxStyle.Information, My.Application.Info.Title)
                                Exit Sub
                            End If
                        End If
                    Next

                    frpf.EstablecerMultiseleccion(True)
                    frpf.SetAppearance(Convert.ToInt32(ParametroPadre.Valor), ParametroPadre.ValorParaMostrar)
                    If frpf.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        Const IDFamiliarDelimiter As String = "@"
                        Const FamiliarNombreDelimiter As String = " - "

                        Dim PersonaFamiliarSeleccionada As formReportesParametroFamiliares.Familiares_GridRowData
                        Dim Valores As String = ""
                        Dim ValorParaMostrar As String = ""

                        For Each dataRow As DataGridViewRow In frpf.datagridviewMain.SelectedRows
                            PersonaFamiliarSeleccionada = CType(dataRow.DataBoundItem, formReportesParametroFamiliares.Familiares_GridRowData)
                            Valores = (PersonaFamiliarSeleccionada.IDFamiliar & IDFamiliarDelimiter & Valores)
                            ValorParaMostrar = (FamiliarNombreDelimiter & PersonaFamiliarSeleccionada.Apellido & ", " & PersonaFamiliarSeleccionada.Nombre) & ValorParaMostrar
                        Next
                        ValorParaMostrar = ValorParaMostrar.Remove(0, FamiliarNombreDelimiter.Length)
                        PersonaFamiliarSeleccionada = Nothing

                        ParametroActual.Valor = Valores
                        ParametroActual.ValorParaMostrar = ValorParaMostrar
                        ListViewItemActual.SubItems(2).Text = ValorParaMostrar
                    End If
                    frpf.Dispose()

                Case Reportes.REPORTE_PARAMETRO_TIPO_TITLE, Reportes.REPORTE_PARAMETRO_TIPO_TEXT
                    formReportesParametroTextBox.SetAppearance(ParametroActual, ListViewItemActual.Text)
                    If formReportesParametroTextBox.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        ListViewItemActual.SubItems(2).Text = ParametroActual.ValorParaMostrar
                    End If
                    formReportesParametroTextBox.Close()
                    formReportesParametroTextBox.Dispose()

                Case Reportes.REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER, Reportes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL, Reportes.REPORTE_PARAMETRO_TIPO_MONEY, Reportes.REPORTE_PARAMETRO_TIPO_DATETIME, Reportes.REPORTE_PARAMETRO_TIPO_DATE, Reportes.REPORTE_PARAMETRO_TIPO_TIME, Reportes.REPORTE_PARAMETRO_TIPO_YEAR
                    formReportesParametroVarios.SetAppearance(ParametroActual, ListViewItemActual.Text)
                    If formReportesParametroVarios.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        ListViewItemActual.SubItems(2).Text = ParametroActual.ValorParaMostrar
                    End If
                    formReportesParametroVarios.Close()
                    formReportesParametroVarios.Dispose()

                Case Reportes.REPORTE_PARAMETRO_TIPO_SINO, Reportes.REPORTE_PARAMETRO_TIPO_FILTER_TEXT_SHOW
                    formReportesParametroSiNo.SetAppearance(ParametroActual, ListViewItemActual.Text)
                    If formReportesParametroSiNo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        ListViewItemActual.SubItems(2).Text = ParametroActual.ValorParaMostrar
                    End If
                    formReportesParametroSiNo.Close()
                    formReportesParametroSiNo.Dispose()

                Case Reportes.REPORTE_PARAMETRO_TIPO_CUARTEL, Reportes.REPORTE_PARAMETRO_TIPO_CARGO, Reportes.REPORTE_PARAMETRO_TIPO_PERSONABAJAMOTIVO, Reportes.REPORTE_PARAMETRO_TIPO_UNIDAD, Reportes.REPORTE_PARAMETRO_TIPO_RESPONSABLE, Reportes.REPORTE_PARAMETRO_TIPO_ENTIDAD
                    formReportesParametroComboBoxSimple.SetAppearance(ParametroActual)
                    If formReportesParametroComboBoxSimple.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        ListViewItemActual.SubItems(2).Text = ParametroActual.ValorParaMostrar
                    End If
                    formReportesParametroComboBoxSimple.Close()
                    formReportesParametroComboBoxSimple.Dispose()

                    BorrarValoresDeParametrosHijos(ParametroActual, ReporteActual)

                Case Reportes.REPORTE_PARAMETRO_TIPO_JERARQUIA, Reportes.REPORTE_PARAMETRO_TIPO_AREA, Reportes.REPORTE_PARAMETRO_TIPO_UBICACION
                    Dim ParametroPadre As ReporteParametro = Nothing

                    ' Busco si el parámetro actual tiene un parámetro padre
                    For Each currentReporteParametro As ReporteParametro In ReporteActual.ReporteParametros
                        If (ParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_JERARQUIA AndAlso currentReporteParametro.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_CARGO) _
                            Or (ParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_AREA AndAlso currentReporteParametro.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_CUARTEL) _
                            Or (ParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_UBICACION AndAlso currentReporteParametro.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_CUARTEL) Then
                            ParametroPadre = currentReporteParametro
                        End If
                    Next

                    formReportesParametroComboBoxDoble.SetAppearance(ParametroPadre, ParametroActual, ListViewItemActual.Text)
                    If formReportesParametroComboBoxDoble.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        ListViewItemActual.SubItems(2).Text = ParametroActual.ValorParaMostrar
                        If ParametroPadre IsNot Nothing Then
                            listviewParametros.Items.Item(CardonerSistemas.Constants.KeyStringer & ParametroPadre.IDParametro).SubItems(2).Text = ParametroPadre.ValorParaMostrar
                        End If
                    End If
                    formReportesParametroComboBoxDoble.Close()
                    formReportesParametroComboBoxDoble.Dispose()

                    BorrarValoresDeParametrosHijos(ParametroActual, ReporteActual)

                Case Reportes.REPORTE_PARAMETRO_TIPO_SUBUBICACION
                    Dim ParametroAbuelo As ReporteParametro = Nothing
                    Dim ParametroPadre As ReporteParametro = Nothing

                    ' Busco si el parámetro actual tiene un parámetro abuelo y padre
                    For Each currentReporteParametro As ReporteParametro In ReporteActual.ReporteParametros
                        If (ParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_SUBUBICACION AndAlso currentReporteParametro.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_CUARTEL) Then
                            ParametroAbuelo = currentReporteParametro
                        End If
                        If (ParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_SUBUBICACION AndAlso currentReporteParametro.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_UBICACION) Then
                            ParametroPadre = currentReporteParametro
                        End If
                    Next

                    formReportesParametroComboBoxTriple.SetAppearance(ParametroAbuelo, ParametroPadre, ParametroActual, ListViewItemActual.Text)
                    If formReportesParametroComboBoxTriple.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        ListViewItemActual.SubItems(2).Text = ParametroActual.ValorParaMostrar
                        If ParametroAbuelo IsNot Nothing Then
                            listviewParametros.Items.Item(CardonerSistemas.Constants.KeyStringer & ParametroAbuelo.IDParametro).SubItems(2).Text = ParametroAbuelo.ValorParaMostrar
                        End If
                        If ParametroPadre IsNot Nothing Then
                            listviewParametros.Items.Item(CardonerSistemas.Constants.KeyStringer & ParametroPadre.IDParametro).SubItems(2).Text = ParametroPadre.ValorParaMostrar
                        End If
                    End If
                    formReportesParametroComboBoxTriple.Close()
                    formReportesParametroComboBoxTriple.Dispose()
            End Select
        End If
    End Sub

    Private Sub Parametros_KeyDown(sender As Object, e As KeyEventArgs) Handles listviewParametros.KeyDown
        If e.KeyCode = Keys.Delete Then
            menuParametroBorrar.PerformClick()
        End If
    End Sub

    Private Sub BorrarValorParametro(sender As Object, e As EventArgs) Handles menuParametroBorrar.Click
        Dim ReporteActual As Reporte
        Dim ParametroActual As ReporteParametro
        Dim ListViewItemActual As ListViewItem

        If listviewParametros.SelectedItems.Count > 0 Then
            ReporteActual = CType(treeviewReportes.SelectedNode.Tag, Reporte)
            ParametroActual = ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro = listviewParametros.SelectedItems(0).Name.Remove(0, CardonerSistemas.Constants.KeyStringer.Length)).First
            If ParametroActual.Valor IsNot Nothing Then
                ListViewItemActual = listviewParametros.SelectedItems(0)
                ParametroActual.Valor = Nothing
                ListViewItemActual.SubItems(2).Text = ""

                ' Si el parámetro que se borra es Padre o Abuelo de otro parámetro, hay que borrar el valor del parámetro Hijo y Nieto también
                If ParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_CUARTEL Or ParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_CARGO Or ParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_UBICACION Or ParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_PERSONA Then
                    BorrarValoresDeParametrosHijos(ParametroActual, ReporteActual)
                End If
            End If
        End If
    End Sub

    Private Sub BorrarValoresDeParametrosHijos(ByRef ParametroActual As ReporteParametro, ByRef ReporteActual As Reporte)

        For Each currentReporteParametro As ReporteParametro In ReporteActual.ReporteParametros

            If (ParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_CARGO AndAlso currentReporteParametro.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_JERARQUIA) _
                            Or (ParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_CUARTEL AndAlso currentReporteParametro.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_AREA) _
                            Or (ParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_CUARTEL AndAlso currentReporteParametro.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_UBICACION) _
                            Or (ParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_UBICACION AndAlso currentReporteParametro.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_SUBUBICACION) _
                            Or (ParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_PERSONA AndAlso currentReporteParametro.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_PERSONAFAMILIARMULTIPLE) Then
                Dim ParametroHijo As ReporteParametro = currentReporteParametro
                ParametroHijo.Valor = Nothing
                ParametroHijo.ValorParaMostrar = ""
                listviewParametros.Items.Item(CardonerSistemas.Constants.KeyStringer & ParametroHijo.IDParametro).SubItems(2).Text = ""
            End If

            If (ParametroActual.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_CUARTEL AndAlso currentReporteParametro.Tipo = Reportes.REPORTE_PARAMETRO_TIPO_SUBUBICACION) Then
                Dim ParametroNieto As ReporteParametro = currentReporteParametro
                ParametroNieto.Valor = Nothing
                ParametroNieto.ValorParaMostrar = ""
                listviewParametros.Items.Item(CardonerSistemas.Constants.KeyStringer & ParametroNieto.IDParametro).SubItems(2).Text = ""
            End If

        Next

    End Sub

    Private Sub Anterior() Handles buttonAnterior.Click
        panelReportes.Show()
        panelParametros.Hide()
    End Sub

#End Region

#Region "Mostrar Reporte"

    Private Sub MostrarReporte(sender As Object, e As EventArgs) Handles buttonImprimir.Click, buttonPrevisualizar.Click
        Dim ReporteActual As Reporte

        If sender.Equals(buttonImprimir) Then
            If MsgBox("Se va a imprimir directamente el Reporte seleccionado." & vbCrLf & vbCrLf & "¿Desea continuar?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        ReporteActual = CType(treeviewReportes.SelectedNode.Tag, Reporte)
        For Each ParametroActual In ReporteActual.ReporteParametros
            If ParametroActual.Requerido AndAlso ParametroActual.Valor Is Nothing Then
                MsgBox(ParametroActual.RequeridoLeyenda, MsgBoxStyle.Information, My.Application.Info.Title)
                listviewParametros.Focus()
                Exit Sub
            End If
        Next

        Me.Cursor = Cursors.WaitCursor

        If ReporteActual.Open(Not sender.Equals(buttonImprimir), ReporteActual.Nombre) Then
        End If

        Me.Cursor = Cursors.Default
    End Sub

#End Region

End Class