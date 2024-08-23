USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Creation date: 2024-07-03
-- Updates: 
-- Description:	Devuelve datos de la asistencia a claves rojas
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'PersonasObtenerDatosAsistenciasClavesRojas') AND type in (N'P', N'PC'))
	 DROP PROCEDURE PersonasObtenerDatosAsistenciasClavesRojas
GO

CREATE PROCEDURE PersonasObtenerDatosAsistenciasClavesRojas
	@IDCuartel tinyint,
	@FechaDesde date,
	@FechaHasta date,
	@IDPersona int
	AS
BEGIN

	SELECT s.Numero, s.Fecha, CAST(s.HoraSalida AS datetime) AS HoraSalida, CAST(s.HoraFin AS datetime) AS HoraFin, p.MatriculaNumero, p.ApellidoNombre, sat.Abreviatura AS AsistenciaTipo
		FROM 
			(SELECT 
		Siniestro AS s
			INNER JOIN SiniestroClave AS sc ON s.IDSiniestroClave = sc.IDSiniestroClave
			INNER JOIN SiniestroAsistencia AS sa ON s.IDSiniestro = sa.IDSiniestro
			INNER JOIN SiniestroAsistenciaTipo AS sat ON sa.IDSiniestroAsistenciaTipo = sat.IDSiniestroAsistenciaTipo
			INNER JOIN Persona AS p ON sa.IDPersona = p.IDPersona
			INNER JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
			LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
			LEFT JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
		WHERE s.Anulado = 0
			AND sc.Grupo = 'R'
			AND s.IDCuartel = @IDCuartel
			AND s.Fecha BETWEEN @FechaDesde AND @FechaHasta
			AND (@IDPersona IS NULL OR p.IDPersona = @IDPersona)
			AND p.EsActivo = 1
			AND pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, @FechaHasta)
			AND pab.Tipo = 'A'
			AND (pa.Fecha IS NULL OR pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, GETDATE()))
			AND cj.JerarquiaInferior = 0
		ORDER BY s.NumeroCompleto, p.ApellidoNombre
END
GO