USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-10-31
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
			dbo.udf_EqualIntegerValuesAsXChar(ISNULL(paba.IDPersonaBajaMotivo, 0), 0) AS EstadoActivo,
			dbo.udf_EqualIntegerValuesAsXChar(paba.IDPersonaBajaMotivo, @IDPersonaBajaMotivoReserva) AS EstadoReserva,
			Cargo.Nombre AS Cargo,
			(CASE WHEN paba.IDPersonaBajaMotivo IS NULL THEN CargoJerarquia.Nombre ELSE '' END) AS JerarquiaActivo,
			(CASE paba.IDPersonaBajaMotivo WHEN @IDPersonaBajaMotivoReserva THEN CargoJerarquia.Nombre ELSE '' END) AS JerarquiaReserva,
			p.DomicilioParticularCalle1, p.DomicilioParticularNumero, p.DomicilioParticularCodigoPostal, Localidad.Nombre AS Localidad,
			dbo.udf_EqualStringValuesAsXChar(p.IOMATiene, 'T') AS IomaPorTrabajo, dbo.udf_EqualStringValuesAsXChar(p.IOMATiene, 'B') AS IomaPorBomberos,
			dbo.udf_EqualIntegerValuesAsXChar(pabb.IDPersonaBajaMotivo, @IDPersonaBajaMotivoRenuncia) AS BajaRenuncia,
			dbo.udf_EqualIntegerValuesAsXChar(pabb.IDPersonaBajaMotivo, @IDPersonaBajaMotivoFallecimiento) AS BajaFallecimiento,
			dbo.udf_EqualIntegerValuesAsXChar(pabb.IDPersonaBajaMotivo, @IDPersonaBajaMotivoDisciplinario) AS BajaDisciplinario,
			(CASE WHEN pabb.IDPersonaBajaMotivo NOT IN (@IDPersonaBajaMotivoRenuncia, @IDPersonaBajaMotivoFallecimiento, @IDPersonaBajaMotivoDisciplinario) THEN 'X' END) AS BajaOtros,
			dbo.udf_StringPadLeft(DAY(pabb.BajaFecha), 2, '0') AS BajaFechaDia, dbo.udf_StringPadLeft(MONTH(pabb.BajaFecha), 2, '0') AS BajaFechaMes, YEAR(pabb.BajaFecha) AS BajaFechaAnio,
			pabb.BajaLibroNumero, pabb.BajaActaNumero
			FROM (((((((((Persona AS p
				LEFT JOIN DocumentoTipo ON p.IDDocumentoTipo = DocumentoTipo.IDDocumentoTipo)
				LEFT JOIN PersonaAltaBaja AS paba ON p.IDPersona = paba.IDPersona)
				LEFT JOIN PersonaAltaBaja AS pabb ON p.IDPersona = pabb.IDPersona)
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona)
				LEFT JOIN Cargo ON pa.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON pa.IDCargo = CargoJerarquia.IDCargo AND pa.IDJerarquia = CargoJerarquia.IDJerarquia)
				LEFT JOIN PersonaBajaMotivo AS pbma ON paba.IDPersonaBajaMotivo = pbma.IDPersonaBajaMotivo)
				LEFT JOIN PersonaBajaMotivo AS pbmb ON pabb.IDPersonaBajaMotivo = pbmb.IDPersonaBajaMotivo)
				LEFT JOIN Provincia ON p.DomicilioParticularIDProvincia = Provincia.IDProvincia)
				LEFT JOIN Localidad ON p.DomicilioParticularIDProvincia = Localidad.IDProvincia AND p.DomicilioParticularIDLocalidad = Localidad.IDLocalidad
			WHERE p.EsActivo = 1
				AND (p.IDPersona = @IDPersona1 OR p.IDPersona = @IDPersona2)
				AND (paba.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(p.IDPersona, GETDATE()))
				AND (pabb.BajaFecha = dbo.udf_GetPersonaUltimaFechaBaja(p.IDPersona, GETDATE()))
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(p.IDPersona, GETDATE()))
	END
GO