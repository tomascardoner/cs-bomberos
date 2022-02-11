Public Class formSiniestroAsistenciaMultiple

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mSiniestroActual As Siniestro

    Private mTipoAsistenciaFirstColumnIndex As Integer

    Private Const ColumnNameAsistenciaTipoPrefijo As String = "columnIDSiniestroAsistenciaTipo#"

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByRef siniestroActual As Siniestro)
        mSiniestroActual = siniestroActual

        InitializeFormAndControls()

        mTipoAsistenciaFirstColumnIndex = datagridviewMain.ColumnCount

        CreateColumns()
        CreateRows()
        FillData()

        CS_Form.MDIChild_PositionAndSizeToFit(CType(pFormMDIMain, Form), CType(Me, Form))
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If

        Me.Show()
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageSiniestro32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mSiniestroActual = Nothing
        mdbContext.Dispose()
        mdbContext = Nothing
        mSiniestroActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Grid data"

    Friend Function CreateColumns() As Boolean
        Dim listTiposActivos As List(Of SiniestroAsistenciaTipo)
        Dim listTiposEnSiniestro As List(Of SiniestroAsistenciaTipo)

        datagridviewMain.Visible = False

        Try
            ' Obtengo todos los tipos de asistencia que estén activos
            listTiposActivos = mdbContext.SiniestroAsistenciaTipo.Where(Function(sat) sat.EsActivo).ToList()

            ' Obtengo los tipos de asistencia que ya están asignados al siniestro actual
            listTiposEnSiniestro = (From sa In mdbContext.SiniestroAsistencia
                                    Join sat In mdbContext.SiniestroAsistenciaTipo On sa.IDSiniestroAsistenciaTipo Equals sat.IDSiniestroAsistenciaTipo
                                    Where sa.IDSiniestro = mSiniestroActual.IDSiniestro
                                    Select sat
                                    Distinct).ToList()

            For Each tipo As SiniestroAsistenciaTipo In listTiposActivos.Union(listTiposEnSiniestro).OrderBy(Function(sat) sat.Orden).ThenBy(Function(sat) sat.Nombre)
                Dim newColumn As New DataGridViewCheckBoxColumn()

                With newColumn
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    .HeaderText = tipo.Nombre
                    .Name = ColumnNameAsistenciaTipoPrefijo & tipo.IDSiniestroAsistenciaTipo.ToString()
                    .Tag = tipo.IDSiniestroAsistenciaTipo
                End With
                datagridviewMain.Columns.Add(newColumn)
            Next
            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al obtener los Tipos de Asistencia.")
            Return False

        Finally
            listTiposActivos = Nothing
            listTiposEnSiniestro = Nothing
            datagridviewMain.Visible = True
        End Try
    End Function

    Friend Function CreateRows() As Boolean
        Dim listPersonas As List(Of uspSiniestroObtenerPersonasParaAsistencia_Result)

        datagridviewMain.Visible = False

        Try
            ' Obtengo las personas que están activas (campo EsActivo) y que a la fecha del siniestro, están activas en el cuerpo
            listPersonas = mdbContext.uspSiniestroObtenerPersonasParaAsistencia(mSiniestroActual.IDSiniestro, mSiniestroActual.Fecha, mSiniestroActual.IDCuartel).ToList()

            For Each persona As uspSiniestroObtenerPersonasParaAsistencia_Result In listPersonas
                Dim newRowId As Integer
                Dim newRow As New DataGridViewRow()

                newRowId = datagridviewMain.Rows.Add()
                newRow = datagridviewMain.Rows(newRowId)
                With newRow
                    .Cells(columnIDPersona.Name).Value = persona.IDPersona
                    .Cells(columnPersonaApellidoNombre.Name).Value = persona.ApellidoNombre
                End With
            Next
            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al obtener las Personas.")
            Return False

        Finally
            listPersonas = Nothing
            datagridviewMain.Visible = True
        End Try
    End Function

    Private Function FillData() As Boolean
        textboxCuartel.Text = mSiniestroActual.Cuartel.Nombre
        textboxNumeroCompleto.Text = mSiniestroActual.NumeroCompleto
        textboxFecha.Text = mSiniestroActual.Fecha.ToShortDateString()

        datagridviewMain.Visible = False

        Try
            Dim listAsistenciasEnSiniestro As List(Of SiniestroAsistencia)

            listAsistenciasEnSiniestro = (From p In mdbContext.Persona
                                          Join sa In mdbContext.SiniestroAsistencia On p.IDPersona Equals sa.IDPersona
                                          Where sa.IDSiniestro = mSiniestroActual.IDSiniestro
                                          Order By p.Orden, p.ApellidoNombre
                                          Select sa).ToList()

            Dim startRowIndex As Integer = 0
            Dim columnName As String

            For Each asistencia In listAsistenciasEnSiniestro
                For rowIndex As Integer = startRowIndex To datagridviewMain.RowCount - 1
                    If CInt(datagridviewMain.Rows(rowIndex).Cells(columnIDPersona.Name).Value) = asistencia.IDPersona Then
                        columnName = ColumnNameAsistenciaTipoPrefijo & asistencia.IDSiniestroAsistenciaTipo.ToString
                        datagridviewMain.Rows(rowIndex).Cells(columnName).Value = True
                        startRowIndex = rowIndex + 1
                    End If
                Next
            Next

            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al obtener las Asistencias.")
            Return False

        Finally
            datagridviewMain.Visible = True
        End Try
    End Function

#End Region

#Region "Controls behavior"

    ' Este evento lo tengo que capturar y hacer commit para que se dispare el evento CellValueChanged
    ' Aparentemente, esta es la solución propuesta por Microsoft
    Private Sub datagridviewMain_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridviewMain.CellContentClick
        datagridviewMain.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub

    Private Sub datagridviewMain_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles datagridviewMain.CellValueChanged
        VerificarAsistenciaUnicaEnFila(e.ColumnIndex, e.RowIndex)
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonCancelar_Click() Handles buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If MessageBox.Show("¿Desea guardar los cambios?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If GuardarCambios() Then
                Me.Close()
            End If
        End If
    End Sub

#End Region

#Region "Extra stuff"

    Private Sub VerificarAsistenciaUnicaEnFila(ByVal columnIndex As Integer, ByVal rowIndex As Integer)
        If columnIndex < mTipoAsistenciaFirstColumnIndex Or rowIndex < 0 Then
            Exit Sub
        End If

        If CBool(datagridviewMain.Rows(rowIndex).Cells(columnIndex).Value) Then
            For verifyColumnIndex As Integer = mTipoAsistenciaFirstColumnIndex To datagridviewMain.ColumnCount - 1
                If verifyColumnIndex <> columnIndex AndAlso CBool(datagridviewMain.Rows(rowIndex).Cells(verifyColumnIndex).Value) Then
                    datagridviewMain.Rows(rowIndex).Cells(verifyColumnIndex).Value = False
                End If
            Next
        End If
    End Sub

    Private Function ObtenerAsistenciaTipoEnFila(ByRef row As DataGridViewRow) As Byte
        For verifyColumnIndex As Integer = mTipoAsistenciaFirstColumnIndex To datagridviewMain.ColumnCount - 1
            If CBool(row.Cells(verifyColumnIndex).Value) Then
                Return CByte(datagridviewMain.Columns(verifyColumnIndex).Tag)
            End If
        Next

        Return 0
    End Function

    Private Function BorrarAsistenciaEnBD(ByVal idPersona As Integer) As Boolean
        Try
            Dim sa As SiniestroAsistencia

            sa = mdbContext.SiniestroAsistencia.Find(mSiniestroActual.IDSiniestro, idPersona)
            If sa IsNot Nothing Then
                mdbContext.SiniestroAsistencia.Remove(sa)
                mdbContext.SaveChanges()
            End If

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al borrar la Asistencia de la base de datos.")
            Return False
        End Try

        Return True
    End Function

    Private Function AgregarOActualizarAsistenciaEnBD(ByVal idPersona As Integer, ByVal idSiniestroAsistenciaTipo As Byte) As Boolean
        Try
            Dim sa As SiniestroAsistencia

            sa = mdbContext.SiniestroAsistencia.Find(mSiniestroActual.IDSiniestro, idPersona)
            If sa Is Nothing Then
                sa = New SiniestroAsistencia With {
                    .IDSiniestro = mSiniestroActual.IDSiniestro,
                    .IDPersona = idPersona,
                    .IDSiniestroAsistenciaTipo = idSiniestroAsistenciaTipo,
                    .IDAsistenciaMetodo = Constantes.ASISTENCIA_METODO_MANUAL_ID,
                    .IDUsuarioCreacion = pUsuario.IDUsuario,
                    .FechaHoraCreacion = Now,
                    .IDUsuarioModificacion = pUsuario.IDUsuario,
                    .FechaHoraModificacion = Now
                }
                mdbContext.SiniestroAsistencia.Add(sa)
                mdbContext.SaveChanges()
            ElseIf sa.IDSiniestroAsistenciaTipo <> idSiniestroAsistenciaTipo Then
                sa.IDSiniestroAsistenciaTipo = idSiniestroAsistenciaTipo
                sa.IDAsistenciaMetodo = Constantes.ASISTENCIA_METODO_MANUAL_ID
                sa.IDUsuarioModificacion = pUsuario.IDUsuario
                sa.FechaHoraModificacion = Now
                mdbContext.SaveChanges()
            End If

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al actualizar la Asistencia en la base de datos.")
            Return False
        End Try

        Return True
    End Function

    Private Function GuardarCambios() As Boolean

        Me.Cursor = Cursors.WaitCursor

        For Each row As DataGridViewRow In datagridviewMain.Rows
            Dim idPersona As Integer
            Dim idSiniestroAsistenciaTipo As Byte

            idPersona = CInt(row.Cells(columnIDPersona.Name).Value)
            idSiniestroAsistenciaTipo = ObtenerAsistenciaTipoEnFila(row)

            If idSiniestroAsistenciaTipo = 0 Then
                If Not BorrarAsistenciaEnBD(idPersona) Then
                    Me.Cursor = Cursors.Default
                    Return False
                End If
            Else
                If Not AgregarOActualizarAsistenciaEnBD(idPersona, idSiniestroAsistenciaTipo) Then
                    Me.Cursor = Cursors.Default
                    Return False
                End If
            End If
        Next
        Me.Cursor = Cursors.Default
        Return True
    End Function

#End Region

End Class