Public Class formReportes

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
#End Region

#Region "Form stuff"
    Private Sub formReportes_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarListaReportes()

        treeviewReportes.Font = My.Settings.GridsAndListsFont
        listviewParametros.Font = My.Settings.GridsAndListsFont
    End Sub

    Private Sub formReportes_Unload() Handles Me.FormClosed
        mdbContext.Dispose()
    End Sub
#End Region

#Region "Reportes"
    Private Sub CargarListaReportes()
        Dim ReporteGrupoNode As TreeNode
        Dim ReporteNode As TreeNode

        Try
            treeviewReportes.BeginUpdate()
            For Each ReporteGrupoActual As ReporteGrupo In mdbContext.ReporteGrupo.OrderBy(Function(rg) rg.Orden).ThenBy(Function(rg) rg.Nombre)
                ' Agrego el Grupo de Reportes
                ReporteGrupoNode = New TreeNode(ReporteGrupoActual.Nombre)
                ReporteGrupoNode.Tag = ReporteGrupoActual
                treeviewReportes.Nodes.Add(ReporteGrupoNode)

                For Each ReporteActual As Reporte In ReporteGrupoActual.Reportes.Where(Function(r) r.MostrarEnVisor = True).OrderBy(Function(r) r.Orden).ThenBy(Function(r) r.Nombre)
                    ' Agrego el Reporte
                    ReporteNode = New TreeNode(ReporteActual.Nombre)
                    ReporteNode.Tag = ReporteActual
                    ReporteGrupoNode.Nodes.Add(ReporteNode)
                Next
            Next
            treeviewReportes.ExpandAll()
            treeviewReportes.EndUpdate()

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al leer la lista de Reportes.")
        End Try
    End Sub

    Private Sub Siguiente() Handles treeviewReportes.NodeMouseDoubleClick, buttonSiguiente.Click
        If treeviewReportes.SelectedNode Is Nothing Then
            MsgBox("No hay ningún Reporte seleccionado para imprimir.", vbInformation, My.Application.Info.Title)
        Else
            If treeviewReportes.SelectedNode.Level = 0 Then
                MsgBox("Debe seleccionar un Reporte (y no un Grupo) para imprimir.", vbInformation, My.Application.Info.Title)
            Else
                CargarListaParametros()
                panelReportes.Hide()
                panelParametros.Show()
            End If
        End If
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

            labelParametrosTitulo.Text = String.Format("Parámetros del Reporte: ""{0} - {1}""", treeviewReportes.SelectedNode.Parent.Text, ReporteActual.Nombre)

            For Each ParametroActual As ReporteParametro In ReporteActual.ReporteParametros.OrderBy(Function(rp) rp.Orden)

                With ParametroActual
                    ' Agrego el Parámetro si tiene especificado el Orden, si no, no
                    If Not .Orden Is Nothing Then

                        ParametroListViewItem = New ListViewItem(.Nombre)
                        ParametroListViewItem.Name = CS_Constants.KEY_STRINGER & .IDParametro
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
            CS_Error.ProcessError(ex, "Error al leer la lista de Parámetros del Reporte.")
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
            ParametroActual = ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro = listviewParametros.SelectedItems(0).Name.Remove(0, CS_Constants.KEY_STRINGER.Length)).First
            ListViewItemActual = listviewParametros.SelectedItems(0)

            Select Case ParametroActual.Tipo
                Case Constantes.REPORTE_PARAMETRO_TIPO_PERSONA
                    If formPersonasSeleccionar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        Dim PersonaSeleccionada As Persona

                        PersonaSeleccionada = CType(formPersonasSeleccionar.datagridviewMain.SelectedRows(0).DataBoundItem, Persona)
                        ParametroActual.Valor = PersonaSeleccionada.IDPersona
                        ParametroActual.ValorParaMostrar = PersonaSeleccionada.ApellidoNombre
                        ListViewItemActual.SubItems(2).Text = ParametroActual.ValorParaMostrar

                        PersonaSeleccionada = Nothing
                    End If
                    formPersonasSeleccionar.Dispose()

                Case Constantes.REPORTE_PARAMETRO_TIPO_TITLE, Constantes.REPORTE_PARAMETRO_TIPO_TEXT
                    formReportesParametroTextBox.SetAppearance(ParametroActual, ListViewItemActual.Text)
                    If formReportesParametroTextBox.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        ListViewItemActual.SubItems(2).Text = ParametroActual.ValorParaMostrar
                    End If
                    formReportesParametroTextBox.Close()
                    formReportesParametroTextBox.Dispose()

                Case Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER, Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL, Constantes.REPORTE_PARAMETRO_TIPO_MONEY, Constantes.REPORTE_PARAMETRO_TIPO_DATETIME, Constantes.REPORTE_PARAMETRO_TIPO_DATE, Constantes.REPORTE_PARAMETRO_TIPO_TIME, Constantes.REPORTE_PARAMETRO_TIPO_YEAR
                    formReportesParametroVarios.SetAppearance(ParametroActual, ListViewItemActual.Text)
                    If formReportesParametroVarios.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        ListViewItemActual.SubItems(2).Text = ParametroActual.ValorParaMostrar
                    End If
                    formReportesParametroVarios.Close()
                    formReportesParametroVarios.Dispose()

                Case Constantes.REPORTE_PARAMETRO_TIPO_SINO, Constantes.REPORTE_PARAMETRO_TIPO_FILTER_TEXT_SHOW
                    formReportesParametroSiNo.SetAppearance(ParametroActual, ListViewItemActual.Text)
                    If formReportesParametroSiNo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        ListViewItemActual.SubItems(2).Text = ParametroActual.ValorParaMostrar
                    End If
                    formReportesParametroSiNo.Close()
                    formReportesParametroSiNo.Dispose()

                Case Constantes.REPORTE_PARAMETRO_TIPO_CUARTEL, Constantes.REPORTE_PARAMETRO_TIPO_CARGO, Constantes.REPORTE_PARAMETRO_TIPO_PERSONABAJAMOTIVO, Constantes.REPORTE_PARAMETRO_TIPO_UNIDAD
                    formReportesParametroComboBoxSimple.SetAppearance(ParametroActual, ListViewItemActual.Text)
                    If formReportesParametroComboBoxSimple.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        ListViewItemActual.SubItems(2).Text = ParametroActual.ValorParaMostrar
                    End If
                    formReportesParametroComboBoxSimple.Close()
                    formReportesParametroComboBoxSimple.Dispose()

                    BorrarValoresDeParametrosHijos(ParametroActual, ReporteActual)

                Case Constantes.REPORTE_PARAMETRO_TIPO_JERARQUIA, Constantes.REPORTE_PARAMETRO_TIPO_AREA, Constantes.REPORTE_PARAMETRO_TIPO_UBICACION
                    Dim ParametroPadre As ReporteParametro = Nothing

                    ' Busco si el parámetro actual tiene un parámetro padre
                    For Each currentReporteParametro As ReporteParametro In ReporteActual.ReporteParametros
                        If (ParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_JERARQUIA AndAlso currentReporteParametro.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_CARGO) _
                            Or (ParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_AREA AndAlso currentReporteParametro.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_CUARTEL) _
                            Or (ParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_UBICACION AndAlso currentReporteParametro.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_CUARTEL) Then
                            ParametroPadre = currentReporteParametro
                        End If
                    Next

                    formReportesParametroComboBoxDoble.SetAppearance(ParametroPadre, ParametroActual, ListViewItemActual.Text)
                    If formReportesParametroComboBoxDoble.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        ListViewItemActual.SubItems(2).Text = ParametroActual.ValorParaMostrar
                        If Not ParametroPadre Is Nothing Then
                            listviewParametros.Items.Item(CS_Constants.KEY_STRINGER & ParametroPadre.IDParametro).SubItems(2).Text = ParametroPadre.ValorParaMostrar
                        End If
                    End If
                    formReportesParametroComboBoxDoble.Close()
                    formReportesParametroComboBoxDoble.Dispose()

                    BorrarValoresDeParametrosHijos(ParametroActual, ReporteActual)

                Case Constantes.REPORTE_PARAMETRO_TIPO_SUBUBICACION
                    Dim ParametroAbuelo As ReporteParametro = Nothing
                    Dim ParametroPadre As ReporteParametro = Nothing

                    ' Busco si el parámetro actual tiene un parámetro abuelo y padre
                    For Each currentReporteParametro As ReporteParametro In ReporteActual.ReporteParametros
                        If (ParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_SUBUBICACION AndAlso currentReporteParametro.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_CUARTEL) Then
                            ParametroAbuelo = currentReporteParametro
                        End If
                        If (ParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_SUBUBICACION AndAlso currentReporteParametro.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_UBICACION) Then
                            ParametroPadre = currentReporteParametro
                        End If
                    Next

                    formReportesParametroComboBoxTriple.SetAppearance(ParametroAbuelo, ParametroPadre, ParametroActual, ListViewItemActual.Text)
                    If formReportesParametroComboBoxTriple.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        ListViewItemActual.SubItems(2).Text = ParametroActual.ValorParaMostrar
                        If Not ParametroAbuelo Is Nothing Then
                            listviewParametros.Items.Item(CS_Constants.KEY_STRINGER & ParametroAbuelo.IDParametro).SubItems(2).Text = ParametroAbuelo.ValorParaMostrar
                        End If
                        If Not ParametroPadre Is Nothing Then
                            listviewParametros.Items.Item(CS_Constants.KEY_STRINGER & ParametroPadre.IDParametro).SubItems(2).Text = ParametroPadre.ValorParaMostrar
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
            ParametroActual = ReporteActual.ReporteParametros.Where(Function(rp) rp.IDParametro = listviewParametros.SelectedItems(0).Name.Remove(0, CS_Constants.KEY_STRINGER.Length)).First
            If Not ParametroActual.Valor Is Nothing Then
                ListViewItemActual = listviewParametros.SelectedItems(0)
                ParametroActual.Valor = Nothing
                ListViewItemActual.SubItems(2).Text = ""

                ' Si el parámetro que se borra es Padre o Abuelo de otro parámetro, hay que borrar el valor del parámetro Hijo y Nieto también
                If ParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_CUARTEL Or ParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_CARGO Or ParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_UBICACION Then
                    BorrarValoresDeParametrosHijos(ParametroActual, ReporteActual)
                End If
            End If
        End If
    End Sub

    Private Sub BorrarValoresDeParametrosHijos(ByRef ParametroActual As ReporteParametro, ByRef ReporteActual As Reporte)
        Dim ParametroHijo As ReporteParametro = Nothing
        Dim ParametroNieto As ReporteParametro = Nothing

        For Each currentReporteParametro As ReporteParametro In ReporteActual.ReporteParametros
            If (ParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_CARGO AndAlso currentReporteParametro.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_JERARQUIA) _
                            Or (ParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_CUARTEL AndAlso currentReporteParametro.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_AREA) _
                            Or (ParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_CUARTEL AndAlso currentReporteParametro.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_UBICACION) _
                            Or (ParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_UBICACION AndAlso currentReporteParametro.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_SUBUBICACION) Then
                ParametroHijo = currentReporteParametro
                ParametroHijo.Valor = Nothing
                ParametroHijo.ValorParaMostrar = ""
                listviewParametros.Items.Item(CS_Constants.KEY_STRINGER & ParametroHijo.IDParametro).SubItems(2).Text = ""
            End If
            If (ParametroActual.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_CUARTEL AndAlso currentReporteParametro.Tipo = Constantes.REPORTE_PARAMETRO_TIPO_SUBUBICACION) Then
                ParametroNieto = currentReporteParametro
                ParametroNieto.Valor = Nothing
                ParametroNieto.ValorParaMostrar = ""
                listviewParametros.Items.Item(CS_Constants.KEY_STRINGER & ParametroNieto.IDParametro).SubItems(2).Text = ""
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

        If ReporteActual.Open(My.Settings.ReportsPath & "\" & ReporteActual.Archivo) Then
            If ReporteActual.SetDatabaseConnection(pDatabase.DataSource, pDatabase.InitialCatalog, pDatabase.UserID, pDatabase.Password) Then
                If sender.Equals(buttonImprimir) Then
                    ReporteActual.ReportObject.PrintToPrinter(1, False, 1, 1000)
                Else
                    MiscFunctions.PreviewCrystalReport(ReporteActual, ReporteActual.Nombre)
                End If
            End If
        End If

        Me.Cursor = Cursors.Default
    End Sub
#End Region

End Class