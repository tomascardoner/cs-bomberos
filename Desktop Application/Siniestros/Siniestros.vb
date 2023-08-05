Module Siniestros

    Friend Function AsistirPersona(ByRef context As CSBomberosContext, ByRef siniestro As Siniestro, idTipoSalidaAnticipada As Byte, tipoSalidaAnticipadaNombre As String, idTipoPresente As Byte, tipoPresenteNombre As String, idPersona As Integer, ByRef mensajeResultado As String) As Byte
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
                Return 1
            Else
                ' Es una asistencia de ausente, se actualiza a 50% o Presente, según corresponda
                siniestroAsistencia.IDSiniestroAsistenciaTipo = idTipo
                mensajeResultado = $"Se actualizó la asistencia a ""{tipoNombre}""."
                siniestroAsistencia.IDUsuarioModificacion = pUsuario.IDUsuario
                siniestroAsistencia.FechaHoraModificacion = Now()
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

        End If

        ' Guardo los cambios
        Try
            context.SaveChanges()
            Return 0

        Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
            Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                    MsgBox("No se pueden agregar la Asistencia porque ya existe.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Case CardonerSistemas.Database.EntityFramework.Errors.PrimaryKeyViolation
                    MsgBox("No se pueden guardar los cambios porque existe una Asistencia al Siniestro duplicada para una Persona.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Case Else
                    CardonerSistemas.ErrorHandler.ProcessError(CType(dbuex, Exception), My.Resources.STRING_ERROR_SAVING_CHANGES)
            End Select
            Return 2

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
            Return 2

        End Try

    End Function
End Module