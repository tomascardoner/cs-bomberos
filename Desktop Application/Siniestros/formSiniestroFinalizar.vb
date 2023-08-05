Imports DPFP
Imports DPFP.Gui

Public Class formSiniestroFinalizar

#Region "Declaraciones"

    Private Class HuellaDigital
        Friend Property IDPersona As Integer
        Friend Property TemplateInDB As Byte()
        Friend Property Template As DPFP.Template
    End Class

    Private mdbContext As CSBomberosContext
    Private mSiniestro As Siniestro
    Private mlistHuellasDigitales As List(Of HuellaDigital)
    Private mIdTipoSalidaAnticipada As Byte
    Private mTipoSalidaAnticipadaNombre As String
    Private mIdTipoPresente As Byte
    Private mTipoPresenteNombre As String

    Friend Persona As Persona
    Friend HoraFin As Date

#End Region

#Region "Cosas del form"

    Friend Sub SetInitData(idTipoSalidaAnticipada As Byte, idTipoPresente As Byte, ByRef context As CSBomberosContext, ByRef siniestro As Siniestro)
        mIdTipoSalidaAnticipada = idTipoSalidaAnticipada
        mIdTipoPresente = idTipoPresente
        mdbContext = context
        mSiniestro = siniestro
    End Sub

    Friend Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetAppearance()

        ' Leo todas las huellas digitales desde la base de datos y convierto los templates
        Using context As New CSBomberosContext(True)
            mlistHuellasDigitales = (From p In context.Persona
                                     Join phd In context.PersonaHuellaDigital On p.IDPersona Equals phd.IDPersona
                                     Where p.EsActivo
                                     Select New HuellaDigital With {.IDPersona = p.IDPersona, .TemplateInDB = phd.Template}).ToList()
        End Using
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
        Persona = Nothing
    End Sub

#End Region

#Region "Eventos de los componentes"

    Private Sub verificationcontrolHuellas_OnComplete(Control As Object, FeatureSet As FeatureSet, ByRef EventHandlerStatus As EventHandlerStatus) Handles verificationcontrolHuellas.OnComplete
        Dim verifier As New DPFP.Verification.Verification()
        Dim result As New DPFP.Verification.Verification.Result()

        ' Una vez obtenida la huella desde el lector, busco en la base de datos a quien corresponde
        For Each huellaDigital As HuellaDigital In mlistHuellasDigitales
            verifier.Verify(FeatureSet, huellaDigital.Template, result)
            If result.Verified Then
                CerrarYAsistirPersona(huellaDigital.IDPersona)
                Return
            End If
        Next

        ' Por no encontrar coincidencias de huellas
        pictureboxFoto.Image = Nothing
        textboxPersona.Text = String.Empty
    End Sub

    Private Sub buttonAsignar_Click(sender As Object, e As EventArgs) Handles buttonAsignar.Click
        If controlPersonaAsignar.IDPersona.HasValue Then
            CerrarYAsistirPersona(controlPersonaAsignar.IDPersona.Value)
        End If
    End Sub

    Private Sub Cerrar(control As Object, e As EventArgs) Handles buttonCerrar.Click
        Me.Hide()
    End Sub

#End Region

#Region "Cosas extras"

    Private Sub CerrarYAsistirPersona(idPersona As Integer)
        Dim mensajeResultado As String

        Persona = mdbContext.Persona.Find(idPersona)
        pictureboxFoto.Image = CS_ValueTranslation.FromObjectImageToPictureBox(Persona.Foto)
        textboxPersona.Text = Persona.ApellidoNombre

        mSiniestro.HoraFin = New TimeSpan(Now.Hour, Now.Minute, 0)
        mSiniestro.IDPersonaFin = Persona.IDPersona
        If Siniestros.AsistirPersona(mdbContext, mSiniestro, mIdTipoSalidaAnticipada, mTipoSalidaAnticipadaNombre, mIdTipoPresente, mTipoPresenteNombre, idPersona, mensajeResultado) <> 2 Then
            Me.DialogResult = DialogResult.Yes
        Else
            Me.DialogResult = DialogResult.No
        End If
    End Sub

#End Region

End Class