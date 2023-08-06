Imports DPFP
Imports DPFP.Gui

Public Class formSiniestroAsistenciaPresencialMultiple

#Region "Declaraciones"

    Private Class GridRowData
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

    Private mdbContext As New CSBomberosContext(True)
    Private mlistSiniestros As List(Of GridRowData)
    Private mlistHuellasDigitales As List(Of HuellaDigital)
    Private mIdTipoSalidaAnticipada As Byte
    Private mTipoSalidaAnticipadaNombre As String
    Private mIdTipoPresente As Byte
    Private mTipoPresenteNombre As String

#End Region

#Region "Cosas del form"

    Friend Sub LoadAndShow(idTipoSalidaAnticipada As Byte, idTipoPresente As Byte)
        mIdTipoSalidaAnticipada = idTipoSalidaAnticipada
        mIdTipoPresente = idTipoPresente

        InitializeFormAndControls()
        RefreshData()

        Me.ShowDialog(ParentForm)
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        ' Leo todas las huellas digitales desde la base de datos y convierto los templates
        mlistHuellasDigitales = (From p In mdbContext.Persona
                                 Join phd In mdbContext.PersonaHuellaDigital On p.IDPersona Equals phd.IDPersona
                                 Where p.EsActivo
                                 Select New HuellaDigital With {.IDPersona = p.IDPersona, .TemplateInDB = phd.Template}).ToList()
        For Each huellaDigital As HuellaDigital In mlistHuellasDigitales
            huellaDigital.Template = New DPFP.Template(New IO.MemoryStream(huellaDigital.TemplateInDB))
        Next

        mTipoSalidaAnticipadaNombre = mdbContext.SiniestroAsistenciaTipo.Find(mIdTipoSalidaAnticipada).Nombre
        mTipoPresenteNombre = mdbContext.SiniestroAsistenciaTipo.Find(mIdTipoPresente).Nombre

        If pDebugMode Then
            controlPersonaAsignar.dbContext = mdbContext
            controlPersonaAsignar.Show()
            buttonAsignar.Show()
        End If
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageSiniestro32)

        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mlistHuellasDigitales = Nothing
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        Me.Dispose()
    End Sub

#End Region

#Region "Cargar y mostrar datos"

    Private Sub RefreshData()
        Dim fechaDesde As Date = Today.AddDays(-7)

        Me.Cursor = Cursors.WaitCursor

        Try
            mlistSiniestros = (From s In mdbContext.Siniestro
                               Join c In mdbContext.Cuartel On s.IDCuartel Equals c.IDCuartel
                               Join sc In mdbContext.SiniestroClave On s.IDSiniestroClave Equals sc.IDSiniestroClave
                               Where s.Fecha >= fechaDesde And Not (s.HoraFin.HasValue Or s.Anulado)
                               Order By c.Nombre, s.NumeroCompleto
                               Select New GridRowData With {.IDSiniestro = s.IDSiniestro, .IDCuartel = c.IDCuartel, .CuartelNombre = c.Nombre, .NumeroCompleto = s.NumeroCompleto, .ClaveNombre = sc.Nombre, .Fecha = s.Fecha}).ToList
            datagridviewMain.AutoGenerateColumns = False
            datagridviewMain.DataSource = mlistSiniestros
            TimerMain.Stop()
            TimerMain.Start()

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Siniestros.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "Eventos de los componentes"

    Private Sub AsistirConPin(sender As Object, e As EventArgs) Handles buttonAsistirConPin.Click
        If mlistHuellasDigitales.Count = 0 Then
            MessageBox.Show("No hay ningún Siniestro para asistir.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim fmapcp = New formSiniestroAsistenciaPresencialConPin()
        fmapcp.SetInitData(mdbContext)
        If fmapcp.ShowDialog(Me) = DialogResult.OK Then
            AsistirPersona(fmapcp.controlpersonaPersona.IDPersona.Value)
        End If
        fmapcp.Dispose()
    End Sub

    Private Sub verificationcontrolHuellas_OnComplete(Control As Object, FeatureSet As FeatureSet, ByRef EventHandlerStatus As EventHandlerStatus) Handles verificationcontrolHuellas.OnComplete
        Dim verifier As New DPFP.Verification.Verification()
        Dim result As New DPFP.Verification.Verification.Result()

        If mlistHuellasDigitales.Count = 0 Then
            MessageBox.Show("No hay ningún Siniestro para asistir.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        ' Una vez obtenida la huella desde el lector, busco en la base de datos a quien corresponde
        For Each huellaDigital As HuellaDigital In mlistHuellasDigitales
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
        textboxEstado.Text = "La huella no coincide con ninguna de las registradas."
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
        Dim mensajeResultado As String

        persona = mdbContext.Persona.Find(idPersona)
        pictureboxFoto.Image = CS_ValueTranslation.FromObjectImageToPictureBox(persona.Foto)
        textboxPersona.Text = persona.ApellidoNombre
        textboxEstado.Text = String.Empty

        RefreshData()
        For Each gridRow In mlistSiniestros
            siniestro = mdbContext.Siniestro.Find(gridRow.IDSiniestro)
            Siniestros.AsistirPersona(siniestro, mIdTipoSalidaAnticipada, mTipoSalidaAnticipadaNombre, mIdTipoPresente, mTipoPresenteNombre, idPersona, mensajeResultado)
            gridRow.Mensaje = mensajeResultado
        Next
        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistSiniestros

        If Not Siniestros.GuardarAsistencia(mdbContext) Then
            textboxEstado.Text = My.Resources.STRING_ERROR_SAVING_CHANGES
        End If
    End Sub

#End Region

End Class