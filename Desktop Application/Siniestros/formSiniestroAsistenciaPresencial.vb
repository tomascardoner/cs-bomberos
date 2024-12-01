Imports DPFP
Imports DPFP.Gui

Public Class formSiniestroAsistenciaPresencial

#Region "Declaraciones"

    Private Class HuellaDigital
        Friend Property IDPersona As Integer
        Friend Property TemplateInDB As Byte()
        Friend Property Template As DPFP.Template
    End Class

    Private mdbContext As New CSBomberosContext(True)
    Private mSiniestro As Siniestro
    Private mlistHuellasDigitales As List(Of HuellaDigital)
    Private mIdTipoSalidaAnticipada As Byte
    Private mTipoSalidaAnticipadaNombre As String
    Private mIdTipoPresente As Byte
    Private mTipoPresenteNombre As String

#End Region

#Region "Cosas del form"

    Friend Sub LoadAndShow(idTipoSalidaAnticipada As Byte, idTipoPresente As Byte, idSiniestro As Integer)
        mIdTipoSalidaAnticipada = idTipoSalidaAnticipada
        mIdTipoPresente = idTipoPresente
        mSiniestro = mdbContext.Siniestro.Find(idSiniestro)

        InitializeFormAndControls()

        Me.ShowDialog(ParentForm)
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        textboxCuartel.Text = mSiniestro.Cuartel.Nombre
        textboxNumeroCompleto.Text = mSiniestro.NumeroCompleto
        textboxFecha.Text = mSiniestro.Fecha.ToString("dd/MM/yyyy")

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
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mlistHuellasDigitales = Nothing
        mSiniestro = Nothing
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        Me.Dispose()
    End Sub

#End Region

#Region "Eventos de los componentes"

    Private Sub AsistirConPin(sender As Object, e As EventArgs) Handles buttonAsistirConPin.Click
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

    Private Sub Cerrar(control As Object, e As EventArgs) Handles buttonCerrar.Click
        Me.Close()
    End Sub

#End Region

#Region "Cosas extras"

    Private Sub AsistirPersona(idPersona As Integer)
        Dim persona As Persona
        Dim mensajeResultado As String = String.Empty

        persona = mdbContext.Persona.Find(idPersona)
        pictureboxFoto.Image = CS_ValueTranslation.FromObjectImageToPictureBox(persona.Foto)
        textboxPersona.Text = persona.ApellidoNombre
        Select Case FuncionesSiniestros.AsistirPersonaYGuardar(mdbContext, mSiniestro, mIdTipoSalidaAnticipada, mTipoSalidaAnticipadaNombre, mIdTipoPresente, mTipoPresenteNombre, idPersona, mensajeResultado)
            Case 0
                ' Se asistió a la Persona
                textboxEstado.ForeColor = Color.Black
            Case 1
                ' Ya tiene una asistencia al siniestro
                textboxEstado.ForeColor = Color.Red
            Case 2
                ' Error al guardar los datos
                textboxEstado.ForeColor = Color.Black
        End Select
        ' Debido a que el textbox está en ReadOnly, no cambia el color del texto sólo con ForeColor,
        ' sino que hay que agregar esta línea absurda para que funcione
        textboxEstado.BackColor = textboxEstado.BackColor
        textboxEstado.Text = mensajeResultado
    End Sub

#End Region

End Class