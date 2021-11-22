USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-10-31
-- Updates: 2021-11-21 - Actualizado a las nuevas funciones y tablas
-- Description:	Devuelve los datos de baja de la Personas
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_DatosParaBaja') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_DatosParaBaja
GO

CREATE PROCEDURE usp_Persona_DatosParaBaja
	@IDPersona1 int,
	@IDPersona2 int
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		DECLARE @IDPersonaBajaMotivoRenuncia tinyint = 1
		DECLARE @IDPersonaBajaMotivoDisciplinario tinyint = 2
		DECLARE @IDPersonaBajaMotivoFallecimiento tinyint = 3
		DECLARE @IDPersonaBajaMotivoReserva tinyint = 4

		SELECT 'SOCIEDAD DE BOMBEROS VOLUNTARIOS DE LOBOS' AS Asociacion, 'LOBOS' AS Partido,
				p.IDPersona, p.MatriculaNumero, p.Apellido, p.Nombre, p.DocumentoNumero,
				dbo.udf_StringPadLeft(DAY(p.FechaNacimiento), 2, '0') AS FechaNacimientoDia, dbo.udf_StringPadLeft(MONTH(p.FechaNacimiento), 2, '0') AS FechaNacimientoMes, dbo.udf_StringPadLeft(YEAR(p.FechaNacimiento) % 100, 2, '0') AS FechaNacimientoAnio,
				dbo.udf_EqualIntegerValuesAsXChar(dbo.PersonaObtenerSiEstadoEsActivo(pabanterior.Tipo), 1) AS EstadoActivo,
				dbo.udf_EqualIntegerValuesAsXChar(pabanterior.IDPersonaBajaMotivo, @IDPersonaBajaMotivoReserva) AS EstadoReserva,
				c.Nombre AS Cargo,
				(CASE dbo.PersonaObtenerSiEstadoEsActivo(pabanterior.IDAltaBaja) WHEN 1 THEN cj.Nombre ELSE '' END) AS JerarquiaActivo,
				(CASE pabanterior.IDPersonaBajaMotivo WHEN @IDPersonaBajaMotivoReserva THEN cj.Nombre ELSE '' END) AS JerarquiaReserva,
				p.DomicilioParticularCalle1, p.DomicilioParticularNumero, p.DomicilioParticularCodigoPostal, l.Nombre AS Localidad,
				dbo.udf_EqualStringValuesAsXChar(p.IOMATiene, 'T') AS IomaPorTrabajo, dbo.udf_EqualStringValuesAsXChar(p.IOMATiene, 'B') AS IomaPorBomberos,
				dbo.udf_EqualIntegerValuesAsXChar(pabbaja.IDPersonaBajaMotivo, @IDPersonaBajaMotivoRenuncia) AS BajaRenuncia,
				dbo.udf_EqualIntegerValuesAsXChar(pabbaja.IDPersonaBajaMotivo, @IDPersonaBajaMotivoFallecimiento) AS BajaFallecimiento,
				dbo.udf_EqualIntegerValuesAsXChar(pabbaja.IDPersonaBajaMotivo, @IDPersonaBajaMotivoDisciplinario) AS BajaDisciplinario,
				(CASE WHEN pabbaja.IDPersonaBajaMotivo NOT IN (@IDPersonaBajaMotivoRenuncia, @IDPersonaBajaMotivoFallecimiento, @IDPersonaBajaMotivoDisciplinario) THEN 'X' END) AS BajaOtros,
				dbo.udf_StringPadLeft(DAY(pabbaja.Fecha), 2, '0') AS BajaFechaDia, dbo.udf_StringPadLeft(MONTH(pabbaja.Fecha), 2, '0') AS BajaFechaMes, YEAR(pabbaja.Fecha) AS BajaFechaAnio,
				pabbaja.LibroNumero, pabbaja.ActaNumero
			FROM Persona AS p
				LEFT JOIN DocumentoTipo AS dt ON p.IDDocumentoTipo = dt.IDDocumentoTipo
				LEFT JOIN PersonaAltaBaja AS pabanterior ON p.IDPersona = pabanterior.IDPersona
				LEFT JOIN PersonaAltaBaja AS pabbaja ON p.IDPersona = pabbaja.IDPersona
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
				LEFT JOIN Cargo AS c ON pa.IDCargo = c.IDCargo
				LEFT JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
				LEFT JOIN Provincia AS pr ON p.DomicilioParticularIDProvincia = pr.IDProvincia
				LEFT JOIN Localidad AS l ON p.DomicilioParticularIDProvincia = l.IDProvincia AND p.DomicilioParticularIDLocalidad = l.IDLocalidad
			WHERE p.EsActivo = 1
				AND (p.IDPersona = @IDPersona1 OR p.IDPersona = @IDPersona2)
				AND (pabanterior.IDAltaBaja = dbo.PersonaObtenerIdAnteriorAUltimaBaja(p.IDPersona, NULL))
				AND (pabbaja.IDAltaBaja = dbo.PersonaObtenerIdUltimaBaja(p.IDPersona, NULL))
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, NULL))
	END
GO