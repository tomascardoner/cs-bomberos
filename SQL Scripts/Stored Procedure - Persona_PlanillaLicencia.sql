USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-22
-- Updates: 2021-11-21 - Actualizado a las nuevas funciones y tablas
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

		SELECT TOP 1 @LicenciaAnteriorFechaDesde = pl.FechaDesde, @LicenciaAnteriorFechaHasta = pl.FechaHasta, @LicenciaAnteriorFechaInterrupcion = pl.FechaInterrupcion, @LicenciaAnteriorCausaNombre = lc.Nombre
			FROM PersonaLicencia AS pl
				INNER JOIN LicenciaCausa AS lc ON pl.IDLicenciaCausa = lc.IDLicenciaCausa
			WHERE pl.IDPersona = @IDPersona
				AND pl.Fecha < (SELECT Fecha FROM PersonaLicencia WHERE IDPersona = @IDPersona AND IDLicencia = @IDLicencia)
			ORDER BY pl.Fecha DESC

		SELECT p.IDPersona, p.MatriculaNumero, p.Genero, p.Apellido, p.Nombre, cj.Nombre AS Jerarquia, pab.Fecha AS AltaFecha,
				dbo.PersonaObtenerAntiguedadEnLetras(p.IDPersona, NULL, pl.Fecha) AS Antiguedad,  pl.Fecha, lc.Nombre AS LicenciaCausaNombre, 
				pl.FechaDesde, pl.FechaHasta, pl.FechaInterrupcion, @LicenciaAnteriorFechaDesde AS PersonaLicenciaUltimaFechaDesde,
				@LicenciaAnteriorFechaHasta AS PersonaLicenciaUltimaFechaHasta, @LicenciaAnteriorFechaInterrupcion AS PersonaLicenciaUltimaFechaInterrupcion,
				@LicenciaAnteriorCausaNombre AS LicenciaCausaUltimaNombre
			FROM PersonaLicencia AS pl
				INNER JOIN Persona AS p ON pl.IDPersona = p.IDPersona
				INNER JOIN LicenciaCausa AS lc ON pl.IDLicenciaCausa = lc.IDLicenciaCausa
				LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
				LEFT JOIN Cargo AS ca ON pa.IDCargo = ca.IDCargo
				LEFT JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
			WHERE pl.IDPersona = @IDPersona
				AND pl.IDLicencia = @IDLicencia
				AND (pab.IDAltaBaja IS NULL OR pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, GETDATE()))
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, GETDATE()))
	END
GO