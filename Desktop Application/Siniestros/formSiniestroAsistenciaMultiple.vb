Public Class formSiniestroAsistenciaMultiple

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mSiniestroActual As Siniestro

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByRef siniestroActual As Siniestro)
        mSiniestroActual = siniestroActual

        CreateColumns()

        FillData()
    End Sub

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitializeFormAndControls()
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.IMAGE_SINIESTRO_32)
    End Sub

    Friend Function CreateColumns() As Boolean
        Try
            datagridviewMain.Visible = False

            For Each tipo As SiniestroAsistenciaTipo In mdbContext.SiniestroAsistenciaTipo.Where(Function(sat) sat.EsActivo).OrderBy(Function(sat) sat.Orden).ThenBy(Function(sat) sat.Nombre)
                Dim newColumn As New DataGridViewCheckBoxColumn()

                With newColumn
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    .HeaderText = tipo.Nombre
                    .Name = "@" & tipo.IDSiniestroAsistenciaTipo
                End With
                datagridviewMain.Columns.Add(newColumn)
            Next

            datagridviewMain.Visible = True
            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al obtener los Tipos de Asistencia.")
            Return False
        End Try
    End Function

    Friend Function CreateRows() As Boolean
        Try
            datagridviewMain.Visible = False

            For Each tipo As SiniestroAsistenciaTipo In mdbContext.SiniestroAsistenciaTipo.Where(Function(sat) sat.EsActivo).OrderBy(Function(sat) sat.Orden).ThenBy(Function(sat) sat.Nombre)
                Dim newColumn As New DataGridViewCheckBoxColumn()

                With newColumn
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    .HeaderText = tipo.Nombre
                    .Name = "@" & tipo.IDSiniestroAsistenciaTipo
                End With
                datagridviewMain.Columns.Add(newColumn)
            Next

            datagridviewMain.Visible = True
            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al obtener los Tipos de Asistencia.")
            Return False
        End Try
    End Function

    Private Function FillData() As Boolean
        textboxCuartel.Text = mSiniestroActual.Cuartel.Nombre
        textboxNumeroCompleto.Text = mSiniestroActual.NumeroCompleto
        textboxFecha.Text = mSiniestroActual.Fecha.ToShortDateString()

        Try
            datagridviewMain.Visible = False

            Dim listAsistencias As New List(Of SiniestroAsistencia)

            For Each asistencia In mdbContext.SiniestroAsistencia.Where(Function(sa) sa.IDSiniestro = mSiniestroActual.IDSiniestro)

            Next

            datagridviewMain.DataSource
            datagridviewMain.Visible = True
            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al obtener los Tipos de Asistencia.")
            Return False
        End Try
    End Function

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mSiniestroActual = Nothing
        Me.Dispose()
    End Sub

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