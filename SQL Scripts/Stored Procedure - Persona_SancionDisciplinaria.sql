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
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_SancionDisciplinaria') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_SancionDisciplinaria
GO

CREATE PROCEDURE usp_Persona_SancionDisciplinaria
	@IDPersona int,
	@IDSancion smallint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT Persona.IDPersona, Persona.MatriculaNumero, Persona.Genero, Persona.Apellido, Persona.Nombre, CargoJerarquia.Nombre AS Jerarquia, SolicitudPersona.Apellido AS SolicitudPersonaApellido, SolicitudPersona.Nombre AS SolicitudPersonaNombre, SolicitudCargoJerarquia.Nombre AS SolicitudJerarquia, PersonaSancion.SolicitudMotivo, PersonaSancion.SolicitudFecha, PersonaSancion.EncuadreTexto, PersonaSancion.EncuadreFecha, SancionTipo.Nombre AS ResolucionSancionTipoNombre, PersonaSancion.ResolucionFecha, PersonaSancion.NotificacionFecha
			FROM ((((((((PersonaSancion INNER JOIN Persona ON PersonaSancion.IDPersona = Persona.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
				INNER JOIN Persona AS SolicitudPersona ON PersonaSancion.SolicitudIDPersona = SolicitudPersona.IDPersona)
				LEFT JOIN PersonaAscenso AS SolicitudPersonaAscenso ON SolicitudPersona.IDPersona = SolicitudPersonaAscenso.IDPersona)
				LEFT JOIN Cargo AS SolicitudCargo ON SolicitudPersonaAscenso.IDCargo = SolicitudCargo.IDCargo)
				LEFT JOIN CargoJerarquia AS SolicitudCargoJerarquia ON SolicitudPersonaAscenso.IDCargo = SolicitudCargoJerarquia.IDCargo AND SolicitudPersonaAscenso.IDJerarquia = SolicitudCargoJerarquia.IDJerarquia)
				LEFT JOIN SancionTipo ON PersonaSancion.ResolucionIDSancionTipo = SancionTipo.IDSancionTipo
			WHERE PersonaSancion.IDPersona = @IDPersona AND PersonaSancion.IDSancion = @IDSancion
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, PersonaSancion.SolicitudFecha))
				AND (SolicitudPersonaAscenso.Fecha IS NULL OR SolicitudPersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(SolicitudPersona.IDPersona, PersonaSancion.SolicitudFecha))
	END
GO