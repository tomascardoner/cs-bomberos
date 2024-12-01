Imports DPFP
Imports DPFP.Gui

Public Class formSiniestroAsistenciaPresencialMultiple

#Region "Declaraciones"

    Private Class GridRowData
        Public Property Seleccionado As Boolean
        Public Property IDSiniestro As Integer
        Public Property IDCuartel As Byte
        Public Property CuartelNombre As String
        Public Property NumeroCompleto As String
        Public Property Fecha As Date
        Public Property ClaveNombre As String
        Public Property Mensaje As String
    End Class

    Private Class HuellaDigital
        Friend Property IDPersona As Integer
        Friend Property TemplateInDB As Byte()
        Friend Property Template As DPFP.Template
    End Class

    Private dbContext As New CSBomberosContext(True)
    Private Siniestros As New List(Of GridRowData)
    Private SiniestrosSeleccion As New Dictionary(Of Integer, Boolean)
    Private HuellasDigitales As List(Of HuellaDigital)
    Private IdTipoSalidaAnticipada As Byte
    Private TipoSalidaAnticipadaNombre As String
    Private IdTipoPresente As Byte
    Private TipoPresenteNombre As String

#End Region

#Region "Cosas del form"

    Friend Sub LoadAndShow(idTipoSalidaAnticipadaOrigen As Byte, idTipoPresenteOrigen As Byte)
        IdTipoSalidaAnticipada = idTipoSalidaAnticipadaOrigen
        IdTipoPresente = idTipoPresenteOrigen

        InitializeFormAndControls()
        RefreshData()

        Me.ShowDialog(ParentForm)
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        ' Leo todas las huellas digitales desde la base de datos y convierto los templates
        HuellasDigitales = (From p In dbContext.Persona
                            Join phd In dbContext.PersonaHuellaDigital On p.IDPersona Equals phd.IDPersona
                            Where p.EsActivo
                            Select New HuellaDigital With {.IDPersona = p.IDPersona, .TemplateInDB = phd.Template}).ToList()
        For Each huellaDigital As HuellaDigital In HuellasDigitales
            huellaDigital.Template = New DPFP.Template(New IO.MemoryStream(huellaDigital.TemplateInDB))
        Next

        TipoSalidaAnticipadaNombre = dbContext.SiniestroAsistenciaTipo.Find(IdTipoSalidaAnticipada).Nombre
        TipoPresenteNombre = dbContext.SiniestroAsistenciaTipo.Find(IdTipoPresente).Nombre

        If pDebugMode Then
            controlPersonaAsignar.dbContext = dbContext
            controlPersonaAsignar.Show()
            buttonAsignar.Show()
        End If
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageSiniestro32)

        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        HuellasDigitales = Nothing
        If dbContext IsNot Nothing Then
            dbContext.Dispose()
            dbContext = Nothing
        End If
        Me.Dispose()
    End Sub

#End Region

#Region "Cargar y mostrar datos"

    Private Sub RefreshData()
        Dim idSiniestroSeleccionado As Integer
        Dim fechaDesde As Date = Today.AddDays(-7)

        Me.Cursor = Cursors.WaitCursor

        ' Guardo la posición actual de la grilla
        If datagridviewMain.CurrentRow Is Nothing Then
            idSiniestroSeleccionado = 0
        Else
            idSiniestroSeleccionado = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData).IDSiniestro
        End If

        ' Guardo la selección de siniestros
        For Each dataRow As GridRowData In Siniestros
            If SiniestrosSeleccion.ContainsKey(dataRow.IDSiniestro) Then
                SiniestrosSeleccion(dataRow.IDSiniestro) = dataRow.Seleccionado
            Else
                SiniestrosSeleccion.Add(dataRow.IDSiniestro, dataRow.Seleccionado)
            End If
        Next

        Try
            ' Obtengo los siniestros abiertos desde la base de datos
            Siniestros = (From s In dbContext.Siniestro
                          Join c In dbContext.Cuartel On s.IDCuartel Equals c.IDCuartel
                          Join sc In dbContext.SiniestroClave On s.IDSiniestroClave Equals sc.IDSiniestroClave
                          Where s.Fecha >= fechaDesde AndAlso Not (s.HoraFin.HasValue OrElse s.Anulado)
                          Order By c.Nombre, s.NumeroCompleto
                          Select New GridRowData With {.Seleccionado = True, .IDSiniestro = s.IDSiniestro, .IDCuartel = c.IDCuartel, .CuartelNombre = c.Nombre, .NumeroCompleto = s.NumeroCompleto, .ClaveNombre = sc.Nombre, .Fecha = s.Fecha}).ToList

            ' Actualizo las filas de los siniestros seleccionados previamente
            For Each gridRowData As GridRowData In Siniestros.Join(SiniestrosSeleccion, Function(s) s.IDSiniestro, Function(ss) ss.Key, Function(s, ss) s)
                gridRowData.Seleccionado = SiniestrosSeleccion(gridRowData.IDSiniestro)
            Next

            datagridviewMain.AutoGenerateColumns = False
            datagridviewMain.DataSource = Siniestros
            TimerMain.Stop()
            TimerMain.Start()

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Siniestros.")
            Me.Cursor = Cursors.Default
            Return
        End Try

        ' Restauro la posición actual de la grilla
        If idSiniestroSeleccionado > 0 Then
            For Each row As DataGridViewRow In datagridviewMain.Rows
                If CType(row.DataBoundItem, GridRowData).IDSiniestro = idSiniestroSeleccionado Then
                    datagridviewMain.CurrentCell = row.Cells(0)
                    Exit For
                End If
            Next
        End If

        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "Eventos de los componentes"

    Private Sub datagridviewMain_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridviewMain.CellContentClick
        datagridviewMain.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub

    Private Sub AsistirConPin(sender As Object, e As EventArgs) Handles buttonAsistirConPin.Click
        If HuellasDigitales.Count = 0 Then
            MessageBox.Show("No hay ningún Siniestro para asistir.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim fmapcp = New formSiniestroAsistenciaPresencialConPin()
        fmapcp.SetInitData(dbContext)
        If fmapcp.ShowDialog(Me) = DialogResult.OK Then
            AsistirPersona(fmapcp.controlpersonaPersona.IDPersona.Value)
        End If
        fmapcp.Dispose()
    End Sub

    Private Sub verificationcontrolHuellas_OnComplete(Control As Object, FeatureSet As FeatureSet, ByRef EventHandlerStatus As EventHandlerStatus) Handles verificationcontrolHuellas.OnComplete
        Dim verifier As New DPFP.Verification.Verification()
        Dim result As New DPFP.Verification.Verification.Result()

        If HuellasDigitales.Count = 0 Then
            MessageBox.Show("No hay ningún Siniestro para asistir.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Una vez obtenida la huella desde el lector, busco en la base de datos a quien corresponde
        For Each huellaDigital As HuellaDigital In HuellasDigitales
            verifier.Verify(FeatureSet, huellaDigital.Template, result)
            If result.Verified Then
                AsistirPersona(huellaDigital.IDPersona)
                Return
            End If
        Next

        ' Por no encontrar coincidencias de huellas
        pictureboxFoto.Image = Nothing
        textboxPersona.Text = String.Empty
        textboxEstado.ForeColor = Color.Red
        textboxEstado.Text = "La huella digital no coincide con ninguna de las registradas."
    End Sub

    Private Sub Asignar_Click(sender As Object, e As EventArgs) Handles buttonAsignar.Click
        If controlPersonaAsignar.IDPersona.HasValue Then
            AsistirPersona(controlPersonaAsignar.IDPersona.Value)
        End If
    End Sub

    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        RefreshData()
    End Sub

    Private Sub Cerrar(control As Object, e As EventArgs) Handles buttonCerrar.Click
        Me.Close()
    End Sub

#End Region

#Region "Cosas extras"

    Private Sub AsistirPersona(idPersona As Integer)
        Dim persona As Persona
        Dim siniestro As Siniestro
        Dim mensajeResultado As String = String.Empty

        persona = dbContext.Persona.Find(idPersona)
        pictureboxFoto.Image = CS_ValueTranslation.FromObjectImageToPictureBox(persona.Foto)
        textboxPersona.Text = persona.ApellidoNombre
        textboxEstado.Text = String.Empty

        RefreshData()
        For Each gridRow As GridRowData In Siniestros
            If gridRow.Seleccionado Then
                siniestro = dbContext.Siniestro.Find(gridRow.IDSiniestro)
                FuncionesSiniestros.AsistirPersona(siniestro, IdTipoSalidaAnticipada, TipoSalidaAnticipadaNombre, IdTipoPresente, TipoPresenteNombre, idPersona, mensajeResultado)
                gridRow.Mensaje = mensajeResultado
            Else
                gridRow.Mensaje = String.Empty
            End If
        Next
        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = Siniestros

        If Not FuncionesSiniestros.GuardarAsistencia(dbContext) Then
            textboxEstado.Text = My.Resources.STRING_ERROR_SAVING_CHANGES
        End If
    End Sub

#End Region

End Class