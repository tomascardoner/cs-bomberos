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
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_HorarioLaboral') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_HorarioLaboral
GO

CREATE PROCEDURE usp_Persona_HorarioLaboral
	@IDPersona int
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT Persona.IDPersona, Persona.MatriculaNumero, Persona.Genero, Persona.Apellido, Persona.Nombre, Persona.ApellidoNombre, CargoJerarquia.Nombre AS Jerarquia, Persona.Profesion, PersonaHorarioLaboral.DiaSemana, PersonaHorarioLaboral.Turno1Desde, PersonaHorarioLaboral.Turno1Hasta, PersonaHorarioLaboral.Turno2Desde, PersonaHorarioLaboral.Turno2Hasta, Persona.HorarioLaboralObservaciones
			FROM (((PersonaHorarioLaboral INNER JOIN Persona ON PersonaHorarioLaboral.IDPersona = Persona.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia
			WHERE PersonaHorarioLaboral.IDPersona = @IDPersona
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, GETDATE()))
	END
GO