USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-10-31
-- Description:	Devuelve los datos para el reporte de Sanciones Disciplinarias
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_Sanciones') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_Sanciones
GO

CREATE PROCEDURE usp_Persona_Sanciones
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@EstadoActivo bit,
	@IDPersonaBajaMotivo tinyint,
	@FechaDesde date,
	@FechaHasta date,
	@IDPersona int
	AS

	BEGIN
		SELECT Persona.IDPersona, Cuartel.Nombre AS CuartelNombre, Persona.MatriculaNumero, Persona.ApellidoNombre, Cargo.Nombre AS CargoNombre, Cargo.Orden AS CargoOrden, CargoJerarquia.Nombre AS JerarquiaNombre, CargoJerarquia.Orden AS JerarquiaOrden, PersonaSancion.ResolucionFecha, SancionTipo.Nombre AS SancionTipoNombre
			FROM ((((((Persona INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				INNER JOIN PersonaSancion ON Persona.IDPersona = PersonaSancion.IDPersona)
				INNER JOIN SancionTipo ON PersonaSancion.ResolucionIDSancionTipo = SancionTipo.IDSancionTipo)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia
			WHERE Persona.EsActivo = 1
				AND (@IDCuartel IS NULL OR Persona.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (PersonaAscenso.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR PersonaAscenso.IDJerarquia = @IDJerarquia)))
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, GETDATE()))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR (@EstadoActivo = 1 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NULL) OR (@EstadoActivo = 0 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NOT NULL))
				AND (@IDPersonaBajaMotivo IS NULL OR PersonaAltaBaja.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
				AND (@IDPersona IS NULL OR Persona.IDPersona = @IDPersona)
				AND (@FechaDesde IS NULL OR PersonaSancion.ResolucionFecha >= @FechaDesde)
				AND (@FechaHasta IS NULL OR PersonaSancion.ResolucionFecha <= @FechaHasta)
	END
GO