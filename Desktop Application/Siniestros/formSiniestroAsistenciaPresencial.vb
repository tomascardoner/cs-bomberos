Imports DPFP
Imports DPFP.Gui

Public Class formSiniestroAsistenciaPresencial

#Region "Declarations"

    Private Class HuellaDigital
        Friend Property IDPersona As Integer
        Friend Property TemplateInDB As Byte()
        Friend Property Template As DPFP.Template
    End Class

    Private mdbContext As New CSBomberosContext(True)
    Private mSiniestro As Siniestro
    Private mlistHuellasDigitales As List(Of HuellaDigital)
    Private mIdSiniestroAsistenciaTipoPresente As Byte

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(idSiniestro As Integer)
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

        mIdSiniestroAsistenciaTipoPresente = CS_Parameter_System.GetIntegerAsByte(Parametros.SINIESTRO_ASISTENCIATIPO_PRESENTE_ID, 0)
        If mIdSiniestroAsistenciaTipoPresente = 0 Then
            MessageBox.Show("No está especificado el ID de asistencia para Presente.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

#Region "Controls behavior"

    Private Sub AsistirConPin(sender As Object, e As EventArgs) Handles buttonAsistirConPin.Click
        Dim fmapcp = New formSiniestroAsistenciaPresencialConPin()
        fmapcp.LoadAndShow(Me, mdbContext, mSiniestro)
        fmapcp.Dispose()
    End Sub

    Private Sub verificationcontrolHuellas_OnComplete(Control As Object, FeatureSet As FeatureSet, ByRef EventHandlerStatus As EventHandlerStatus) Handles verificationcontrolHuellas.OnComplete
        Dim verifier As New DPFP.Verification.Verification()
        Dim result As New DPFP.Verification.Verification.Result()

        ' Una vez obtenida la huella desde el lector, busco en la base de datos a quien corresponde
        For Each huellaDigital As HuellaDigital In mlistHuellasDigitales
            verifier.Verify(FeatureSet, huellaDigital.Template, result)
            If result.Verified Then
                Dim persona As Persona = mdbContext.Persona.Find(huellaDigital.IDPersona)
                pictureboxFoto.Image = CS_ValueTranslation.FromObjectImageToPictureBox(persona.Foto)
                textboxPersona.Text = persona.ApellidoNombre
                If VerificarDatos(huellaDigital.IDPersona) Then
                    If GuardarDatos(huellaDigital.IDPersona) Then
                        textboxEstado.ForeColor = Color.Black
                        textboxEstado.Text = "Se ha registrado la asistencia."
                    End If
                End If
                Return
            End If
        Next

        ' Por no encontrar coincidencias de huellas
        pictureboxFoto.Image = Nothing
        textboxPersona.Text = String.Empty
        textboxEstado.ForeColor = Color.Red
        textboxEstado.Text = "La huella no coincide con ninguna de las registradas."
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos(idPersona As Integer) As Boolean
        If mSiniestro.SiniestrosAsistencias.Where(Function(sa) sa.IDPersona = idPersona).Any() Then
            textboxEstado.ForeColor = Color.Red
            textboxEstado.Text = "La persona ya tiene una asistencia al siniestro."
            Return False
        End If

        Return True
    End Function

    Private Function GuardarDatos(idPersona As Integer) As Boolean

        mSiniestro.SiniestrosAsistencias.Add(New SiniestroAsistencia() With {
                                             .IDPersona = idPersona,
                                             .IDSiniestroAsistenciaTipo = mIdSiniestroAsistenciaTipoPresente,
                                             .IDAsistenciaMetodo = Constantes.AsistenciaMetodoCodigoNumericoId,
                                             .IDUsuarioCreacion = pUsuario.IDUsuario,
                                             .FechaHoraCreacion = Now(),
                                             .IDUsuarioModificacion = pUsuario.IDUsuario,
                                             .FechaHoraModificacion = Now()})

        Try
            mdbContext.SaveChanges()
            Return True

        Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
            Me.Cursor = Cursors.Default
            Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                    MsgBox("No se pueden agregar la Asistencia porque ya existe.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Case CardonerSistemas.Database.EntityFramework.Errors.PrimaryKeyViolation
                    MsgBox("No se pueden guardar los cambios porque existe una Asistencia al Siniestro duplicada para una Persona.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Case Else
                    CardonerSistemas.ErrorHandler.ProcessError(CType(dbuex, Exception), My.Resources.STRING_ERROR_SAVING_CHANGES)
            End Select
            Return False

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
            Return False
        End Try

    End Function

#End Region

End Class