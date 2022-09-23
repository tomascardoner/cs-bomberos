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
                VerificarYGuardarDatos(huellaDigital.IDPersona)
                Return
            End If
        Next

        ' Por no encontrar coincidencias de huellas
        pictureboxFoto.Image = Nothing
        textboxPersona.Text = String.Empty
        textboxEstado.ForeColor = Color.Red
        textboxEstado.Text = "La huella no coincide con ninguna de las registradas."
    End Sub

    Private Sub buttonAsignar_Click(sender As Object, e As EventArgs) Handles buttonAsignar.Click
        If controlPersonaAsignar.IDPersona.HasValue Then
            VerificarYGuardarDatos(controlPersonaAsignar.IDPersona.Value)
        End If
    End Sub

#End Region

#Region "Extra stuff"

    Private Sub VerificarYGuardarDatos(idPersona As Integer)
        Dim persona As Persona
        Dim siniestroAsistencia As SiniestroAsistencia
        Dim mensaje As String

        persona = mdbContext.Persona.Find(idPersona)
        pictureboxFoto.Image = CS_ValueTranslation.FromObjectImageToPictureBox(persona.Foto)
        textboxPersona.Text = persona.ApellidoNombre

        siniestroAsistencia = mSiniestro.SiniestrosAsistencias.Where(Function(sa) sa.IDPersona = idPersona).FirstOrDefault()
        If siniestroAsistencia IsNot Nothing Then
            ' Ya hay una asistencia cargada
            If siniestroAsistencia.SiniestroAsistenciaTipo.EsPresente Then
                ' Es una asistencia de presente, se muestra advertencia y no se actualiza
                textboxEstado.ForeColor = Color.Red
                ' Debido a que el textbox está en ReadOnly, no cambia el color del texto sólo con ForeColor,
                ' sino que hay que agregar esta línea absurda para que funcione
                textboxEstado.BackColor = textboxEstado.BackColor
                textboxEstado.Text = "La persona ya tiene una asistencia al siniestro."
                Return
            Else
                ' Es una asistencia de ausente, se actualiza a Presente
                siniestroAsistencia.IDSiniestroAsistenciaTipo = mIdSiniestroAsistenciaTipoPresente
                siniestroAsistencia.IDUsuarioModificacion = pUsuario.IDUsuario
                siniestroAsistencia.FechaHoraModificacion = Now()
                mensaje = "Se actualizó la asistencia a Presente."
            End If
        Else
            ' No existe, así que la agrego
            mSiniestro.SiniestrosAsistencias.Add(New SiniestroAsistencia() With {
                                             .IDPersona = idPersona,
                                             .IDSiniestroAsistenciaTipo = mIdSiniestroAsistenciaTipoPresente,
                                             .IDAsistenciaMetodo = Constantes.AsistenciaMetodoCodigoNumericoId,
                                             .IDUsuarioCreacion = pUsuario.IDUsuario,
                                             .FechaHoraCreacion = Now(),
                                             .IDUsuarioModificacion = pUsuario.IDUsuario,
                                             .FechaHoraModificacion = Now()})
            mensaje = "Se registró la asistencia."

        End If

        ' Guardo los cambios
        Try
            mdbContext.SaveChanges()

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
            Return

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
            Return

        End Try

        textboxEstado.ForeColor = Color.Black
        textboxEstado.Text = mensaje
    End Sub

#End Region

End Class