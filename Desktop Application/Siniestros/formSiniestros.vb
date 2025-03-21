﻿Public Class FormSiniestros

#Region "Declarations"

    Private WithEvents DateTimePickerFechaDesdeHost As ToolStripControlHost
    Private WithEvents DateTimePickerFechaHastaHost As ToolStripControlHost

    Friend Class GridRowData
        Public Property IDSiniestro As Integer
        Public Property IDCuartel As Byte
        Public Property CuartelNombre As String
        Public Property NumeroCompleto As String
        Public Property IDSiniestroRubro As Byte
        Public Property SiniestroRubroNombre As String
        Public Property IDSiniestroTipo As Byte
        Public Property SiniestroTipoNombre As String
        Public Property IDSiniestroClave As Byte
        Public Property ClaveNombre As String
        Public Property Fecha As Date
        Public Property HoraSalida As TimeSpan?
        Public Property HoraFin As TimeSpan?
        Public Property Cerrado As Boolean
        Public Property Controlado As Boolean
        Public Property Anulado As Boolean
    End Class

    Private mdbContext As New CSBomberosContext(True)
    Private mlistSiniestrosBase As List(Of GridRowData)
    Private mlistSiniestrosFiltradaYOrdenada As List(Of GridRowData)
    Private IdSiniestroAsistenciaTipoSalidaAnticipada As Byte
    Private IdSiniestroAsistenciaTipoPresente As Byte

    Private mSkipFilterData As Boolean

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder

#End Region

#Region "Form stuff"

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageSiniestro32)

        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        InitializeForm()

        mSkipFilterData = False

        mOrdenColumna = columnNumero
        mOrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub

    Private Sub InitializeForm()
        ToolStripButtonNuevaVersion.Visible = (pUsuario.IDUsuario = 4 OrElse pUsuario.IDUsuario = Constantes.USUARIO_ADMINISTRADOR_ID)

        ListasComunes.LlenarComboBoxCuarteles(mdbContext, comboboxCuartel.ComboBox, True, False)
        ListasSiniestros.LlenarComboBoxRubros(mdbContext, comboboxSiniestroRubro.ComboBox, True, False)
        ListasSiniestros.LlenarComboBoxClaves(mdbContext, comboboxClave.ComboBox, True, False)

        ' Filtro de período
        InicializarFiltroDeFechas()
        CardonerSistemas.DateTime.FillPeriodTypesComboBox(comboboxPeriodoTipo.ComboBox, CardonerSistemas.DateTime.PeriodTypes.Month)

        comboboxCerrado.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxCerrado.SelectedIndex = 0

        ToolStripControlado.Visible = Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR_COMPLETO, False)
        ComboBoxControlado.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        ComboBoxControlado.SelectedIndex = 0
        ColumnControlado.Visible = Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR_COMPLETO, False)

        comboboxAnulado.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxAnulado.SelectedIndex = 2

        IdSiniestroAsistenciaTipoSalidaAnticipada = CS_Parameter_System.GetIntegerAsByte(Parametros.SINIESTRO_ASISTENCIATIPO_SALIDAANTICIPADA_ID, 0)
        IdSiniestroAsistenciaTipoPresente = CS_Parameter_System.GetIntegerAsByte(Parametros.SINIESTRO_ASISTENCIATIPO_PRESENTE_ID, 0)
    End Sub

    Private Sub InicializarFiltroDeFechas()
        ' Create a new ToolStripControlHost, passing in a control.
        DateTimePickerFechaDesdeHost = New ToolStripControlHost(New DateTimePicker())
        DateTimePickerFechaHastaHost = New ToolStripControlHost(New DateTimePicker())

        ' Set the font on the ToolStripControlHost, this will affect the hosted control.
        'dateTimePickerHost.Font = New Font("Arial", 7.0F, FontStyle.Italic)

        ' Set the Width property, this will also affect the hosted control.
        DateTimePickerFechaDesdeHost.Width = 100
        DateTimePickerFechaDesdeHost.DisplayStyle = ToolStripItemDisplayStyle.Text
        DateTimePickerFechaHastaHost.Width = 100
        DateTimePickerFechaHastaHost.DisplayStyle = ToolStripItemDisplayStyle.Text

        ' Setting the Text property requires a string that converts to a  
        ' DateTime type since that is what the hosted control requires.
        DateTimePickerFechaDesdeHost.Text = DateTime.Today.ToShortDateString
        DateTimePickerFechaHastaHost.Text = DateTime.Today.ToShortDateString

        ' Cast the Control property back to the original type to set a  
        ' type-specific property. 
        CType(DateTimePickerFechaDesdeHost.Control, DateTimePicker).Format = DateTimePickerFormat.Short
        CType(DateTimePickerFechaHastaHost.Control, DateTimePicker).Format = DateTimePickerFormat.Short

        ' Add the control host to the ToolStrip.
        toolstripPeriodo.Items.Insert(3, DateTimePickerFechaDesdeHost)
        toolstripPeriodo.Items.Add(DateTimePickerFechaHastaHost)

        DateTimePickerFechaDesdeHost.Visible = False
        DateTimePickerFechaHastaHost.Visible = False
    End Sub

    Private Sub Me_Closed() Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If

        If DateTimePickerFechaDesdeHost IsNot Nothing Then
            DateTimePickerFechaDesdeHost.Control.Dispose()
            DateTimePickerFechaDesdeHost.Dispose()
            DateTimePickerFechaDesdeHost = Nothing
        End If
        If DateTimePickerFechaHastaHost IsNot Nothing Then
            DateTimePickerFechaHastaHost.Control.Dispose()
            DateTimePickerFechaHastaHost.Dispose()
            DateTimePickerFechaHastaHost = Nothing
        End If
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub RefreshData(Optional ByVal PositionIDSiniestro As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim FechaDesde As Date
        Dim FechaHasta As Date

        Me.Cursor = Cursors.WaitCursor

        CardonerSistemas.DateTime.GetDatesFromPeriodTypeAndValue(CType(comboboxPeriodoTipo.SelectedIndex, CardonerSistemas.DateTime.PeriodTypes), CByte(comboboxPeriodoValor.SelectedIndex), FechaDesde, FechaHasta, CType(DateTimePickerFechaDesdeHost.Control, DateTimePicker).Value, CType(DateTimePickerFechaHastaHost.Control, DateTimePicker).Value)

        Try
            mlistSiniestrosBase = (From s In mdbContext.Siniestro
                                   Join c In mdbContext.Cuartel On s.IDCuartel Equals c.IDCuartel
                                   Join sr In mdbContext.SiniestroRubro On s.IDSiniestroRubro Equals sr.IDSiniestroRubro
                                   Join st In mdbContext.SiniestroTipo On s.IDSiniestroRubro Equals st.IDSiniestroRubro And s.IDSiniestroTipo Equals st.IDSiniestroTipo
                                   Join sc In mdbContext.SiniestroClave On s.IDSiniestroClave Equals sc.IDSiniestroClave
                                   Where s.Fecha >= FechaDesde AndAlso s.Fecha <= FechaHasta
                                   Select New GridRowData With {.IDSiniestro = s.IDSiniestro, .IDCuartel = c.IDCuartel, .CuartelNombre = c.Nombre, .NumeroCompleto = s.NumeroCompleto, .IDSiniestroRubro = s.IDSiniestroRubro, .SiniestroRubroNombre = sr.Nombre, .IDSiniestroTipo = s.IDSiniestroTipo, .SiniestroTipoNombre = st.Nombre, .IDSiniestroClave = s.IDSiniestroClave, .ClaveNombre = sc.Nombre, .Fecha = s.Fecha, .HoraSalida = s.HoraSalida, .HoraFin = s.HoraFin, .Cerrado = s.HoraFin.HasValue, .Controlado = s.Controlado, .Anulado = s.Anulado}).ToList

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Siniestros.")
            Me.Cursor = Cursors.Default
            Return
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDSiniestro = 0
            Else
                PositionIDSiniestro = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDSiniestro
            End If
        End If

        FilterData()

        If PositionIDSiniestro <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDSiniestro = PositionIDSiniestro Then
                    datagridviewMain.CurrentCell = CurrentRowChecked.Cells(0)
                    Return
                End If
            Next
        End If
    End Sub

    Private Sub FilterData()

        If Not mSkipFilterData Then
            Me.Cursor = Cursors.WaitCursor

            Try
                ' Inicializo las variables
                mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosBase.ToList

                ' Filtro por Cuartel
                If comboboxCuartel.SelectedIndex > 0 Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.Where(Function(s) s.IDCuartel = CByte(comboboxCuartel.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Siniestro Rubro
                If comboboxSiniestroRubro.SelectedIndex > 0 Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.Where(Function(s) s.IDSiniestroRubro = CByte(comboboxSiniestroRubro.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Siniestro Tipo
                If comboboxSiniestroTipo.SelectedIndex > 0 Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.Where(Function(s) s.IDSiniestroTipo = CByte(comboboxSiniestroTipo.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Clave
                If comboboxClave.SelectedIndex > 0 Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.Where(Function(s) s.IDSiniestroClave = CByte(comboboxClave.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Cerrado
                Select Case comboboxCerrado.SelectedIndex
                    Case 0      ' Todos
                    Case 1      ' Sí
                        mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.Where(Function(s) s.Cerrado).ToList
                    Case 2      ' No
                        mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.Where(Function(s) Not s.Cerrado).ToList
                End Select

                ' Filtro por Controlado
                Select Case ComboBoxControlado.SelectedIndex
                    Case 0      ' Todos
                    Case 1      ' Sí
                        mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.Where(Function(s) s.Controlado).ToList
                    Case 2      ' No
                        mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.Where(Function(s) Not s.Controlado).ToList
                End Select

                ' Filtro por Anulado
                Select Case comboboxAnulado.SelectedIndex
                    Case 0      ' Todos
                    Case 1      ' Sí
                        mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.Where(Function(s) s.Anulado).ToList
                    Case 2      ' No
                        mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.Where(Function(s) Not s.Anulado).ToList
                End Select

                Select Case mlistSiniestrosFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Siniestros para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Siniestro.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Siniestros.", mlistSiniestrosFiltradaYOrdenada.Count)
                End Select

            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al filtrar los datos.")
                Me.Cursor = Cursors.Default
                Return
            End Try

            OrderData()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub OrderData()
        ' Realizo las rutinas de ordenamiento
        Select Case mOrdenColumna.Name
            Case columnCuartel.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                Else
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                End If
            Case columnNumero.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                Else
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.NumeroCompleto).ToList
                End If
            Case columnFecha.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Fecha).ThenBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                Else
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Fecha).ThenBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                End If
            Case columnSiniestroRubro.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.SiniestroRubroNombre).ThenBy(Function(dgrd) dgrd.SiniestroTipoNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                Else
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.SiniestroRubroNombre).ThenBy(Function(dgrd) dgrd.SiniestroTipoNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                End If
            Case columnSiniestroTipo.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.SiniestroTipoNombre).ThenBy(Function(dgrd) dgrd.SiniestroRubroNombre).ThenBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                Else
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.SiniestroTipoNombre).ThenBy(Function(dgrd) dgrd.SiniestroRubroNombre).ThenBy(Function(dgrd) dgrd.CuartelNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                End If
            Case columnClave.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.ClaveNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                Else
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.ClaveNombre).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                End If
            Case columnCerrado.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Cerrado).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                Else
                    mlistSiniestrosFiltradaYOrdenada = mlistSiniestrosFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Cerrado).ThenBy(Function(dgrd) dgrd.NumeroCompleto).ToList
                End If
        End Select

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistSiniestrosFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        mOrdenColumna.HeaderCell.SortGlyphDirection = mOrdenTipo
    End Sub
#End Region

#Region "Controls events"

    Private Sub PeriodoTipoSeleccionar() Handles comboboxPeriodoTipo.SelectedIndexChanged
        CardonerSistemas.DateTime.FillPeriodValuesComboBox(comboboxPeriodoValor.ComboBox, CType(comboboxPeriodoTipo.SelectedIndex, CardonerSistemas.DateTime.PeriodTypes))
    End Sub

    Private Sub PeriodoValorSeleccionar() Handles comboboxPeriodoValor.SelectedIndexChanged
        DateTimePickerFechaDesdeHost.Visible = (comboboxPeriodoTipo.SelectedIndex = CInt(CardonerSistemas.DateTime.PeriodTypes.Range))
        labelPeriodoFechaY.Visible = (comboboxPeriodoTipo.SelectedIndex = CInt(CardonerSistemas.DateTime.PeriodTypes.Range) AndAlso comboboxPeriodoValor.SelectedIndex = CInt(CardonerSistemas.DateTime.PeriodRangeValues.DateBetween))
        DateTimePickerFechaHastaHost.Visible = labelPeriodoFechaY.Visible
        RefreshData()
    End Sub

    Private Sub FechaCambiar() Handles DateTimePickerFechaDesdeHost.TextChanged, DateTimePickerFechaHastaHost.TextChanged
        RefreshData()
    End Sub

    Private Sub CambioFiltros(sender As Object, e As EventArgs) Handles comboboxCuartel.SelectedIndexChanged, comboboxSiniestroTipo.SelectedIndexChanged, comboboxClave.SelectedIndexChanged, comboboxCerrado.SelectedIndexChanged, ComboBoxControlado.SelectedIndexChanged, comboboxAnulado.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub CambioRubro(sender As Object, e As EventArgs) Handles comboboxSiniestroRubro.SelectedIndexChanged
        ListasSiniestros.LlenarComboBoxTipos(mdbContext, comboboxSiniestroTipo.ComboBox, CByte(comboboxSiniestroRubro.ComboBox.SelectedValue), True, False)
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
            If mOrdenColumna IsNot Nothing Then
                mOrdenColumna.HeaderCell.SortGlyphDirection = SortOrder.None
            End If

            mOrdenTipo = SortOrder.Ascending
            mOrdenColumna = ClickedColumn
        End If

        OrderData()
    End Sub

#End Region

#Region "Main toolbar events"

    Private Sub Agregar_Click() Handles buttonAgregar.Click
        If Not Permisos.VerificarPermiso(Permisos.SINIESTRO_AGREGAR) Then
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        datagridviewMain.Enabled = False
        If ToolStripButtonNuevaVersion.Checked Then
            FormSiniestroV2.LoadAndShow(True, Me, 0)
        Else
            formSiniestro.LoadAndShow(True, Me, 0)
        End If
        datagridviewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Siniestro para editar.", vbInformation, My.Application.Info.Title)
            Return
        End If
        If Not (Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR_BASICO, False) OrElse Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR_COMPLETO, False)) Then
            Permisos.MostrarMensajeDeAviso()
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        datagridviewMain.Enabled = False
        If ToolStripButtonNuevaVersion.Checked Then
            FormSiniestroV2.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSiniestro)
        Else
            formSiniestro.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSiniestro)
        End If
        datagridviewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        Dim siniestroActual As Siniestro
        Dim Mensaje As String

        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Siniestro para eliminar.", vbInformation, My.Application.Info.Title)
            Return
        End If
        If Not Permisos.VerificarPermiso(Permisos.SINIESTRO_ELIMINAR) Then
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        siniestroActual = mdbContext.Siniestro.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSiniestro)
        Me.Cursor = Cursors.Default
        Mensaje = $"Se eliminará el Siniestro seleccionado.{vbCrLf}{vbCrLf}Número: {siniestroActual.NumeroCompleto}{vbCrLf}{vbCrLf}¿Confirma la eliminación definitiva?"
        If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.No Then
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            mdbContext.Siniestro.Remove(siniestroActual)
            mdbContext.SaveChanges()

        Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
            Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                    MsgBox("No se puede eliminar el Siniestro porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
            End Select
            Me.Cursor = Cursors.Default
            Return

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar el Siniestro.")
        End Try

        RefreshData()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Siniestro para ver.", vbInformation, My.Application.Info.Title)
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        datagridviewMain.Enabled = False
        If ToolStripButtonNuevaVersion.Checked Then
            FormSiniestroV2.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSiniestro)
        Else
            formSiniestro.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSiniestro)
        End If
        datagridviewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub AsistenciaPresencialMultiple(sender As Object, e As EventArgs) Handles buttonAsistenciaPresencial.ButtonClick
        If IdSiniestroAsistenciaTipoSalidaAnticipada = 0 Then
            MessageBox.Show("No se puede asistir porque no está especificado el ID de asistencia para Salida Anticipada.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If IdSiniestroAsistenciaTipoPresente = 0 Then
            MessageBox.Show("No se puede asistir porque no está especificado el ID de asistencia para Presente.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Permisos.VerificarPermiso(Permisos.SINIESTRO_ASISTIR_PRESENCIAL) Then
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            formSiniestroAsistenciaPresencialMultiple.LoadAndShow(IdSiniestroAsistenciaTipoSalidaAnticipada, IdSiniestroAsistenciaTipoPresente)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("No se pudo crear una instancia del componente de huellas digitales. Probablemente se deba a que no están instaladas las librerías necesarias.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AsistenciaPresencialIndividual(sender As Object, e As EventArgs) Handles menuitemAsistenciaPresencialIndividual.Click
        Dim rowData As GridRowData

        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Siniestro para asistir.", vbInformation, My.Application.Info.Title)
            Return
        End If
        rowData = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)
        If rowData.Anulado Then
            MessageBox.Show("El Siniestro está anulado.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If rowData.HoraFin.HasValue Then
            MessageBox.Show("El Siniestro está finalizado.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If IdSiniestroAsistenciaTipoSalidaAnticipada = 0 Then
            MessageBox.Show("No se puede asistir porque no está especificado el ID de asistencia para Salida Anticipada.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If IdSiniestroAsistenciaTipoPresente = 0 Then
            MessageBox.Show("No se puede asistir porque no está especificado el ID de asistencia para Presente.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Permisos.VerificarPermiso(Permisos.SINIESTRO_ASISTIR_PRESENCIAL) Then
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            formSiniestroAsistenciaPresencial.LoadAndShow(IdSiniestroAsistenciaTipoSalidaAnticipada, IdSiniestroAsistenciaTipoPresente, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSiniestro)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("No se pudo crear una instancia del componente de huellas digitales. Probablemente se deba a que no están instaladas las librerías necesarias.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AsistenciaManual(sender As Object, e As EventArgs) Handles buttonAsistenciaManual.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Siniestro para asistir.", vbInformation, My.Application.Info.Title)
            Return
        End If
        If CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).Anulado Then
            MessageBox.Show("El Siniestro está anulado.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If Not Permisos.VerificarPermiso(Permisos.SINIESTRO_ASISTIR_MANUAL) Then
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        formSiniestroAsistenciaManual.LoadAndShow(mdbContext.Siniestro.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDSiniestro))
        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "Extra stuff"

    Private Sub CambiarColorAFilaAnulada(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles datagridviewMain.RowPostPaint
        If e.RowIndex < datagridviewMain.RowCount - 1 Then
            Dim DataGridViewRowActual As DataGridViewRow

            DataGridViewRowActual = datagridviewMain.Rows(e.RowIndex)
            If CType(DataGridViewRowActual.DataBoundItem, GridRowData).Anulado Then
                DataGridViewRowActual.DefaultCellStyle.ForeColor = Color.DarkGray
                DataGridViewRowActual.DefaultCellStyle.Font = New System.Drawing.Font(pAppearanceConfig.ListsFont, FontStyle.Strikeout)
            End If
        End If
    End Sub

#End Region

End Class
