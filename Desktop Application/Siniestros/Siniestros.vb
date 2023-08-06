Module Siniestros

    Friend Function AsistirPersonaYGuardar(ByRef context As CSBomberosContext, ByRef siniestro As Siniestro, idTipoSalidaAnticipada As Byte, tipoSalidaAnticipadaNombre As String, idTipoPresente As Byte, tipoPresenteNombre As String, idPersona As Integer, ByRef mensajeResultado As String) As Byte
        If AsistirPersona(siniestro, idTipoSalidaAnticipada, tipoSalidaAnticipadaNombre, idTipoPresente, tipoPresenteNombre, idPersona, mensajeResultado) Then
            If GuardarAsistencia(context) Then
                Return 0
            Else
                Return 2
            End If
        Else
            Return 1
        End If
    End Function

    Friend Function AsistirPersona(ByRef siniestro As Siniestro, idTipoSalidaAnticipada As Byte, tipoSalidaAnticipadaNombre As String, idTipoPresente As Byte, tipoPresenteNombre As String, idPersona As Integer, ByRef mensajeResultado As String) As Boolean
        Dim idTipo As Byte
        Dim tipoNombre As String
        Dim siniestroAsistencia As SiniestroAsistencia

        ' Si no es clave roja o naranja, siempre asigno Presente
        If siniestro.HoraLlegadaUltimoCamion.HasValue Or (siniestro.SiniestroClave.Grupo <> Constantes.SINIESTRO_CLAVEGRUPO_ROJA And siniestro.SiniestroClave.Grupo <> Constantes.SINIESTRO_CLAVEGRUPO_NARANJA) Then
            idTipo = idTipoPresente
            tipoNombre = tipoPresenteNombre
        Else
            idTipo = idTipoSalidaAnticipada
            tipoNombre = tipoSalidaAnticipadaNombre
        End If

        siniestroAsistencia = siniestro.SiniestrosAsistencias.Where(Function(sa) sa.IDPersona = idPersona).FirstOrDefault()
        If siniestroAsistencia IsNot Nothing Then
            ' Ya hay una asistencia cargada
            If siniestroAsistencia.SiniestroAsistenciaTipo.EsPresente Then
                ' Es una asistencia de presente, no se actualiza
                mensajeResultado = "La persona ya tiene una asistencia al siniestro."
                Return False
            Else
                ' Es una asistencia de ausente, se actualiza a 50% o Presente, según corresponda
                siniestroAsistencia.IDSiniestroAsistenciaTipo = idTipo
                mensajeResultado = $"Se actualizó la asistencia a ""{tipoNombre}""."
                siniestroAsistencia.IDUsuarioModificacion = pUsuario.IDUsuario
                siniestroAsistencia.FechaHoraModificacion = Now()
                Return True
            End If
        Else
            ' No existe, así que la agrego
            siniestro.SiniestrosAsistencias.Add(New SiniestroAsistencia() With {
                                             .IDPersona = idPersona,
                                             .IDSiniestroAsistenciaTipo = idTipo,
                                             .IDAsistenciaMetodo = Constantes.AsistenciaMetodoCodigoNumericoId,
                                             .IDUsuarioCreacion = pUsuario.IDUsuario,
                                             .FechaHoraCreacion = Now(),
                                             .IDUsuarioModificacion = pUsuario.IDUsuario,
                                             .FechaHoraModificacion = Now()})
            mensajeResultado = $"Se registró la asistencia ""{tipoNombre}""."
            Return True
        End If
    End Function

    Friend Function GuardarAsistencia(ByRef context As CSBomberosContext) As Boolean

        If Not context.ChangeTracker.HasChanges Then
            Return True
        End If

        Try
            context.SaveChanges()
            Return True

        Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
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
            CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
            Return False

        End Try
    End Function
End Module