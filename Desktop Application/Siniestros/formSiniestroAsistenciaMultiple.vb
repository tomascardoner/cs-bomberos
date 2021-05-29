Public Class formSiniestroAsistenciaMultiple

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mSiniestroActual As Siniestro

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByRef siniestroActual As Siniestro)
        mSiniestroActual = siniestroActual

        InitializeFormAndControls()

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
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.IMAGE_SINIESTRO_32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
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
                    .Name = "columnIDSiniestroAsistenciaTipo#" & tipo.IDSiniestroAsistenciaTipo.ToString()
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
        Dim listPersonasActivasDelCuartel As List(Of Persona)
        Dim listPersonasEnSiniestro As List(Of Persona)

        datagridviewMain.Visible = False

        Try
            ' Obtengo las personas que están activas (campo EsActivo) y que a la fecha del siniestro, están activas en el cuerpo
            listPersonasActivasDelCuartel = (From p In mdbContext.Persona
                                             Join pab In mdbContext.PersonaAltaBaja On p.IDPersona Equals pab.IDPersona
                                             Where p.EsActivo AndAlso p.IDCuartel = mSiniestroActual.IDCuartel AndAlso pab.AltaFecha <= mSiniestroActual.Fecha AndAlso (pab.BajaFecha Is Nothing Or pab.BajaFecha > mSiniestroActual.Fecha)
                                             Select p).ToList()

            ' Obtengo las personas que ya están asignadas al siniestro actual
            listPersonasEnSiniestro = (From p In mdbContext.Persona
                                       Join sa In mdbContext.SiniestroAsistencia On p.IDPersona Equals sa.IDPersona
                                       Where sa.IDSiniestro = mSiniestroActual.IDSiniestro
                                       Select p).ToList()

            For Each persona As Persona In listPersonasActivasDelCuartel.Union(listPersonasEnSiniestro).OrderBy(Function(p) p.Orden).ThenBy(Function(p) p.ApellidoNombre)
                Dim newRowId As Integer
                Dim newRow As New DataGridViewRow()

                newRowId = datagridviewMain.Rows.Add()
                newRow = datagridviewMain.Rows(newRowId)
                With newRow
                    .Cells("columnIDPersona").Value = persona.IDPersona
                    .Cells("columnPersonaApellidoNombre").Value = persona.ApellidoNombre
                End With
            Next
            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al obtener las Personas.")
            Return False

        Finally
            listPersonasActivasDelCuartel = Nothing
            listPersonasEnSiniestro = Nothing
            datagridviewMain.Visible = True
        End Try
    End Function

    Private Function FillData() As Boolean
        Dim listAsistenciasEnSiniestro As List(Of SiniestroAsistencia)

        textboxCuartel.Text = mSiniestroActual.Cuartel.Nombre
        textboxNumeroCompleto.Text = mSiniestroActual.NumeroCompleto
        textboxFecha.Text = mSiniestroActual.Fecha.ToShortDateString()

        Try
            datagridviewMain.Visible = False

            listAsistenciasEnSiniestro = (From p In mdbContext.Persona
                                          Join sa In mdbContext.SiniestroAsistencia On p.IDPersona Equals sa.IDPersona
                                          Where sa.IDSiniestro = mSiniestroActual.IDSiniestro
                                          Order By p.Orden, p.ApellidoNombre
                                          Select sa).ToList()

            Dim startRowIndex As Integer = 0
            Dim columnName As String

            For Each asistencia In listAsistenciasEnSiniestro
                For rowIndex As Integer = startRowIndex To datagridviewMain.Rows.Count - 1
                    If CInt(datagridviewMain.Rows(rowIndex).Cells("columnIDPersona").Value) = asistencia.IDPersona Then
                        columnName = "columnIDSiniestroAsistenciaTipo#" & asistencia.IDSiniestroAsistenciaTipo.ToString
                        datagridviewMain.Rows(rowIndex).Cells(columnName).Value = True
                        startRowIndex = rowIndex + 1
                    End If
                Next
            Next

            datagridviewMain.Visible = True
            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al obtener los Tipos de Asistencia.")
            Return False
        End Try
    End Function

#End Region

#Region "Main Toolbar"

    Private Sub buttonCancelar_Click() Handles buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        Me.Close()
    End Sub

#End Region

End Class