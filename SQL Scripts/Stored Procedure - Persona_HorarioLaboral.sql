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
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_HorarioLaboral') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_HorarioLaboral
GO

CREATE PROCEDURE usp_Persona_HorarioLaboral
	@IDPersona int
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT p.IDPersona, p.MatriculaNumero, p.Genero, p.Apellido, p.Nombre, p.ApellidoNombre, cj.Nombre AS Jerarquia, p.Profesion, phl.DiaSemana,
				CAST(phl.Turno1Desde AS char(5)) AS Turno1Desde, CAST(phl.Turno1Hasta AS char(5)) AS Turno1Hasta,
				CAST(phl.Turno2Desde AS char(5)) AS Turno2Desde, CAST(phl.Turno2Hasta AS char(5)) AS Turno2Hasta,
				p.HorarioLaboralObservaciones
			FROM Persona AS p
				INNER JOIN PersonaHorarioLaboral AS phl ON p.IDPersona = phl.IDPersona
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
				LEFT JOIN Cargo AS c ON pa.IDCargo = c.IDCargo
				LEFT JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
			WHERE phl.IDPersona = @IDPersona
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, GETDATE()))
	END
GO