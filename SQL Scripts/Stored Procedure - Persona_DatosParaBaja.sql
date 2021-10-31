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
			Persona.IDPersona, Persona.MatriculaNumero, Persona.Apellido, Persona.Nombre, Persona.DocumentoNumero,
			dbo.udf_StringPadLeft(DAY(Persona.FechaNacimiento), 2, '0') AS FechaNacimientoDia, dbo.udf_StringPadLeft(MONTH(Persona.FechaNacimiento), 2, '0') AS FechaNacimientoMes, dbo.udf_StringPadLeft(YEAR(Persona.FechaNacimiento) % 100, 2, '0') AS FechaNacimientoAnio,
			dbo.udf_EqualIntegerValuesAsXChar(ISNULL(paba.IDPersonaBajaMotivo, 0), 0) AS EstadoActivo,
			dbo.udf_EqualIntegerValuesAsXChar(paba.IDPersonaBajaMotivo, @IDPersonaBajaMotivoReserva) AS EstadoReserva,
			Cargo.Nombre AS Cargo,
			(CASE WHEN paba.IDPersonaBajaMotivo IS NULL THEN CargoJerarquia.Nombre ELSE '' END) AS JerarquiaActivo,
			(CASE paba.IDPersonaBajaMotivo WHEN @IDPersonaBajaMotivoReserva THEN CargoJerarquia.Nombre ELSE '' END) AS JerarquiaReserva,
			Persona.DomicilioParticularCalle1, Persona.DomicilioParticularNumero, Persona.DomicilioParticularCodigoPostal, Localidad.Nombre AS Localidad,
			dbo.udf_EqualStringValuesAsXChar(Persona.IOMATiene, 'T') AS IomaPorTrabajo, dbo.udf_EqualStringValuesAsXChar(Persona.IOMATiene, 'B') AS IomaPorBomberos,
			dbo.udf_EqualIntegerValuesAsXChar(pabb.IDPersonaBajaMotivo, @IDPersonaBajaMotivoRenuncia) AS BajaRenuncia,
			dbo.udf_EqualIntegerValuesAsXChar(pabb.IDPersonaBajaMotivo, @IDPersonaBajaMotivoFallecimiento) AS BajaFallecimiento,
			dbo.udf_EqualIntegerValuesAsXChar(pabb.IDPersonaBajaMotivo, @IDPersonaBajaMotivoDisciplinario) AS BajaDisciplinario,
			(CASE WHEN pabb.IDPersonaBajaMotivo NOT IN (@IDPersonaBajaMotivoRenuncia, @IDPersonaBajaMotivoFallecimiento, @IDPersonaBajaMotivoDisciplinario) THEN 'X' END) AS BajaOtros,
			dbo.udf_StringPadLeft(DAY(pabb.BajaFecha), 2, '0') AS BajaFechaDia, dbo.udf_StringPadLeft(MONTH(pabb.BajaFecha), 2, '0') AS BajaFechaMes, YEAR(pabb.BajaFecha) AS BajaFechaAnio,
			pabb.BajaLibroNumero, pabb.BajaActaNumero
			FROM (((((((((Persona
				LEFT JOIN DocumentoTipo ON Persona.IDDocumentoTipo = DocumentoTipo.IDDocumentoTipo)
				LEFT JOIN PersonaAltaBaja AS paba ON Persona.IDPersona = paba.IDPersona)
				LEFT JOIN PersonaAltaBaja AS pabb ON Persona.IDPersona = pabb.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
				LEFT JOIN PersonaBajaMotivo AS pbma ON paba.IDPersonaBajaMotivo = pbma.IDPersonaBajaMotivo)
				LEFT JOIN PersonaBajaMotivo AS pbmb ON pabb.IDPersonaBajaMotivo = pbmb.IDPersonaBajaMotivo)
				LEFT JOIN Provincia ON Persona.DomicilioParticularIDProvincia = Provincia.IDProvincia)
				LEFT JOIN Localidad ON Persona.DomicilioParticularIDProvincia = Localidad.IDProvincia AND Persona.DomicilioParticularIDLocalidad = Localidad.IDLocalidad
			WHERE Persona.EsActivo = 1
				AND (Persona.IDPersona = @IDPersona1 OR Persona.IDPersona = @IDPersona2)
				AND (paba.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, GETDATE()))
				AND (pabb.BajaFecha = dbo.udf_GetPersonaUltimaFechaBaja(Persona.IDPersona, GETDATE()))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, GETDATE()))
	END
GO