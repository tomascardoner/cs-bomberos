USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author: Tomás A. Cardoner
-- Creation date: 2022-07-16
-- Description:	Agrega a la asistencia de un siniestro, a las personas activas y que tengan licencia o sanción.
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'SiniestroAgregarAsistenciaDePersonasConLicenciaOSancion') AND type in (N'P', N'PC'))
	 DROP PROCEDURE SiniestroAgregarAsistenciaDePersonasConLicenciaOSancion
GO

CREATE PROCEDURE SiniestroAgregarAsistenciaDePersonasConLicenciaOSancion
	@IDSiniestro int,
	@IDUsuario smallint
	AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @IDSiniestroAsistenciaTipoLicencia tinyint = (SELECT NumeroEntero FROM Parametro WHERE IDParametro = 'SINIESTRO_ASISTENCIATIPO_LICENCIA_ID')
	DECLARE @IDSiniestroAsistenciaTipoSuspension tinyint = (SELECT NumeroEntero FROM Parametro WHERE IDParametro = 'SINIESTRO_ASISTENCIATIPO_SUSPENSION_ID')
	DECLARE @IDAsistenciaMetodo tinyint = 4
	DECLARE @Fecha date
	DECLARE @IDCuartel tinyint
	DECLARE @Personas TABLE (IDPersona int PRIMARY KEY)

	SELECT @Fecha = Fecha, @IDCuartel = IDCuartel FROM Siniestro WHERE IDSiniestro = @IDSiniestro

	-- Obtengo las Personas activas al momento del siniestro
	INSERT INTO @Personas
		SELECT p.IDPersona
			FROM Persona AS p
				INNER JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
			WHERE p.EsActivo = 1 AND p.IDCuartel = @IDCuartel
				AND pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, @Fecha)
				AND pab.Tipo = 'A'

	-- Inserto las asistencias de las personas con Licencias
	INSERT INTO SiniestroAsistencia
		(IDSiniestro, IDPersona, IDSiniestroAsistenciaTipo, IDAsistenciaMetodo, IDUsuarioCreacion, FechaHoraCreacion, IDUsuarioModificacion, FechaHoraModificacion)
		SELECT @IDSiniestro, pl.IDPersona, @IDSiniestroAsistenciaTipoLicencia, @IDAsistenciaMetodo, @IDUsuario, GETDATE(), @IDUsuario, GETDATE()
			FROM PersonaLicencia AS pl
				INNER JOIN @Personas AS p ON pl.IDPersona = p.IDPersona
			WHERE pl.FechaDesde <= @Fecha
				AND ((pl.FechaInterrupcion IS NOT NULL AND pl.FechaInterrupcion >= @Fecha) OR (pl.FechaInterrupcion IS NULL AND pl.FechaHasta >= @Fecha))
				AND p.IDPersona NOT IN (SELECT IDPersona FROM SiniestroAsistencia WHERE IDSiniestro = @IDSiniestro)

	-- Inserto las asistencias de las personas con Licencias especiales
	INSERT INTO SiniestroAsistencia
		(IDSiniestro, IDPersona, IDSiniestroAsistenciaTipo, IDAsistenciaMetodo, IDUsuarioCreacion, FechaHoraCreacion, IDUsuarioModificacion, FechaHoraModificacion)
		SELECT @IDSiniestro, ple.IDPersona, @IDSiniestroAsistenciaTipoLicencia, @IDAsistenciaMetodo, @IDUsuario, GETDATE(), @IDUsuario, GETDATE()
			FROM PersonaLicenciaEspecial AS ple
				INNER JOIN @Personas AS p ON ple.IDPersona = p.IDPersona
			WHERE ple.FechaDesde <= @Fecha
				AND ple.FechaHasta >= @Fecha
				AND p.IDPersona NOT IN (SELECT IDPersona FROM SiniestroAsistencia WHERE IDSiniestro = @IDSiniestro)

	-- Inserto las asistencias de las personas con Sanciones
	INSERT INTO SiniestroAsistencia
		(IDSiniestro, IDPersona, IDSiniestroAsistenciaTipo, IDAsistenciaMetodo, IDUsuarioCreacion, FechaHoraCreacion, IDUsuarioModificacion, FechaHoraModificacion)
		SELECT @IDSiniestro, ps.IDPersona, @IDSiniestroAsistenciaTipoSuspension, @IDAsistenciaMetodo, @IDUsuario, GETDATE(), @IDUsuario, GETDATE()
			FROM PersonaSancion AS ps
				INNER JOIN @Personas AS p ON ps.IDPersona = p.IDPersona
				INNER JOIN SancionTipo AS st ON ps.ResolucionIDSancionTipo = st.IDSancionTipo
			WHERE ps.NotificacionFechaEfectiva <= @Fecha
				AND (st.CantidadDias IS NOT NULL)
				AND DATEADD(day, st.CantidadDias, ps.NotificacionFechaEfectiva) >= @Fecha
				AND p.IDPersona NOT IN (SELECT IDPersona FROM SiniestroAsistencia WHERE IDSiniestro = @IDSiniestro)

END
GO