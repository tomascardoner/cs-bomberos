USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-22
-- Description:	Devuelve los datos para la Solicitud de Sanción Disciplinaria
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_PlanillaLicencia') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_PlanillaLicencia
GO

CREATE PROCEDURE usp_Persona_PlanillaLicencia
	@IDPersona int,
	@IDLicencia smallint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		DECLARE @LicenciaAnteriorFechaDesde date
		DECLARE @LicenciaAnteriorFechaHasta date
		DECLARE @LicenciaAnteriorFechaInterrupcion date
		DECLARE @LicenciaAnteriorCausaNombre varchar(100)

		SELECT TOP 1 @LicenciaAnteriorFechaDesde = PersonaLicencia.FechaDesde, @LicenciaAnteriorFechaHasta = PersonaLicencia.FechaHasta, @LicenciaAnteriorFechaInterrupcion = PersonaLicencia.FechaInterrupcion, @LicenciaAnteriorCausaNombre = LicenciaCausa.Nombre
			FROM PersonaLicencia INNER JOIN LicenciaCausa ON PersonaLicencia.IDLicenciaCausa = LicenciaCausa.IDLicenciaCausa
			WHERE IDPersona = @IDPersona AND Fecha < (SELECT Fecha FROM PersonaLicencia WHERE IDPersona = @IDPersona AND IDLicencia = @IDLicencia)
			ORDER BY Fecha DESC

		SELECT Persona.IDPersona, Persona.MatriculaNumero, Persona.Genero, Persona.Apellido, Persona.Nombre, CargoJerarquia.Nombre AS Jerarquia, PersonaAltaBaja.AltaFecha, dbo.udf_GetPersonaAntiguedadLeyenda(Persona.IDPersona, NULL, PersonaLicencia.Fecha) AS Antiguedad,  PersonaLicencia.Fecha, LicenciaCausa.Nombre AS LicenciaCausaNombre, PersonaLicencia.FechaDesde, PersonaLicencia.FechaHasta, PersonaLicencia.FechaInterrupcion, @LicenciaAnteriorFechaDesde AS PersonaLicenciaUltimaFechaDesde, @LicenciaAnteriorFechaHasta AS PersonaLicenciaUltimaFechaHasta, @LicenciaAnteriorFechaInterrupcion AS PersonaLicenciaUltimaFechaInterrupcion, @LicenciaAnteriorCausaNombre AS LicenciaCausaUltimaNombre
			FROM (((((PersonaLicencia INNER JOIN Persona ON PersonaLicencia.IDPersona = Persona.IDPersona)
				INNER JOIN LicenciaCausa ON PersonaLicencia.IDLicenciaCausa = LicenciaCausa.IDLicenciaCausa)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia
			WHERE PersonaLicencia.IDPersona = @IDPersona AND PersonaLicencia.IDLicencia = @IDLicencia
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, PersonaLicencia.Fecha))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, PersonaLicencia.Fecha))
	END
GO