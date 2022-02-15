Public Class formAcademiaAsistenciaMultiple

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mAcademiaActual As Academia

    Private mTipoAsistenciaFirstColumnIndex As Integer

    Private Const ColumnNameAsistenciaTipoPrefijo As String = "columnIDAcademiaAsistenciaTipo#"

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByRef siniestroActual As Academia)
        mAcademiaActual = siniestroActual

        InitializeFormAndControls()

        mTipoAsistenciaFirstColumnIndex = datagridviewMain.ColumnCount

        CreateColumns()
        CreateRows()
        FillData()

        CardonerSistemas.Forms.MdiChildPositionAndSizeToFit(CType(pFormMDIMain, Form), CType(Me, Form))
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If

        Me.Show()
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageAcademia32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mAcademiaActual = Nothing
        mdbContext.Dispose()
        mdbContext = Nothing
        mAcademiaActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Grid data"

    Friend Function CreateColumns() As Boolean
        Dim listTiposActivos As List(Of AcademiaAsistenciaTipo)
        Dim listTiposEnAcademia As List(Of AcademiaAsistenciaTipo)

        datagridviewMain.Visible = False

        Try
            ' Obtengo todos los tipos de asistencia que estén activos
            listTiposActivos = mdbContext.AcademiaAsistenciaTipo.Where(Function(sat) sat.EsActivo).ToList()

            ' Obtengo los tipos de asistencia que ya están asignados al siniestro actual
            listTiposEnAcademia = (From sa In mdbContext.AcademiaAsistencia
                                   Join sat In mdbContext.AcademiaAsistenciaTipo On sa.IDAcademiaAsistenciaTipo Equals sat.IDAcademiaAsistenciaTipo
                                   Where sa.IDAcademia = mAcademiaActual.IDAcademia
                                   Select sat
                                   Distinct).ToList()

            For Each tipo As AcademiaAsistenciaTipo In listTiposActivos.Union(listTiposEnAcademia).OrderBy(Function(sat) sat.Orden).ThenBy(Function(sat) sat.Nombre)
                Dim newColumn As New DataGridViewCheckBoxColumn()

                With newColumn
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    .HeaderText = tipo.Nombre
                    .Name = ColumnNameAsistenciaTipoPrefijo & tipo.IDAcademiaAsistenciaTipo.ToString()
                    .Tag = tipo.IDAcademiaAsistenciaTipo
                End With
                datagridviewMain.Columns.Add(newColumn)
            Next
            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al obtener los Tipos de Asistencia.")
            Return False

        Finally
            listTiposActivos = Nothing
            listTiposEnAcademia = Nothing
            datagridviewMain.Visible = True
        End Try
    End Function

    Friend Function CreateRows() As Boolean
        Dim listPersonas As List(Of uspAcademiaObtenerPersonasParaAsistencia_Result)

        datagridviewMain.Visible = False

        Try
            listPersonas = mdbContext.uspAcademiaObtenerPersonasParaAsistencia(mAcademiaActual.IDAcademia, mAcademiaActual.Fecha, mAcademiaActual.IDCuartel).ToList()

            For Each persona As uspAcademiaObtenerPersonasParaAsistencia_Result In listPersonas
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
        textboxCuartel.Text = mAcademiaActual.Cuartel.Nombre
        textboxFecha.Text = mAcademiaActual.Fecha.ToShortDateString()

        datagridviewMain.Visible = False

        Try
            Dim listAsistenciasEnAcademia As List(Of AcademiaAsistencia)

            listAsistenciasEnAcademia = (From p In mdbContext.Persona
                                         Join sa In mdbContext.AcademiaAsistencia On p.IDPersona Equals sa.IDPersona
                                         Where sa.IDAcademia = mAcademiaActual.IDAcademia
                                         Order By p.Orden, p.ApellidoNombre
                                         Select sa).ToList()

            Dim startRowIndex As Integer = 0
            Dim columnName As String

            For Each asistencia As AcademiaAsistencia In listAsistenciasEnAcademia
                For rowIndex As Integer = startRowIndex To datagridviewMain.RowCount - 1
                    If CInt(datagridviewMain.Rows(rowIndex).Cells(columnIDPersona.Name).Value) = asistencia.IDPersona Then
                        columnName = ColumnNameAsistenciaTipoPrefijo & asistencia.IDAcademiaAsistenciaTipo.ToString
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
            Dim sa As AcademiaAsistencia

            sa = mdbContext.AcademiaAsistencia.Find(mAcademiaActual.IDAcademia, idPersona)
            If sa IsNot Nothing Then
                mdbContext.AcademiaAsistencia.Remove(sa)
                mdbContext.SaveChanges()
            End If

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al borrar la Asistencia de la base de datos.")
            Return False
        End Try

        Return True
    End Function

    Private Function AgregarOActualizarAsistenciaEnBD(ByVal idPersona As Integer, ByVal idAcademiaAsistenciaTipo As Byte) As Boolean
        Try
            Dim sa As AcademiaAsistencia

            sa = mdbContext.AcademiaAsistencia.Find(mAcademiaActual.IDAcademia, idPersona)
            If sa Is Nothing Then
                sa = New AcademiaAsistencia With {
                    .IDAcademia = mAcademiaActual.IDAcademia,
                    .IDPersona = idPersona,
                    .IDAcademiaAsistenciaTipo = idAcademiaAsistenciaTipo,
                    .IDAsistenciaMetodo = Constantes.ASISTENCIA_METODO_MANUAL_ID,
                    .IDUsuarioCreacion = pUsuario.IDUsuario,
                    .FechaHoraCreacion = Now,
                    .IDUsuarioModificacion = pUsuario.IDUsuario,
                    .FechaHoraModificacion = Now
                }
                mdbContext.AcademiaAsistencia.Add(sa)
                mdbContext.SaveChanges()
            ElseIf sa.IDAcademiaAsistenciaTipo <> idAcademiaAsistenciaTipo Then
                sa.IDAcademiaAsistenciaTipo = idAcademiaAsistenciaTipo
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
            Dim idAcademiaAsistenciaTipo As Byte

            idPersona = CInt(row.Cells(columnIDPersona.Name).Value)
            idAcademiaAsistenciaTipo = ObtenerAsistenciaTipoEnFila(row)

            If idAcademiaAsistenciaTipo = 0 Then
                If Not BorrarAsistenciaEnBD(idPersona) Then
                    Me.Cursor = Cursors.Default
                    Return False
                End If
            Else
                If Not AgregarOActualizarAsistenciaEnBD(idPersona, idAcademiaAsistenciaTipo) Then
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