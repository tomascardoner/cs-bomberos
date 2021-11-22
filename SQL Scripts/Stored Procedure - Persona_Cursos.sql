USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-10-31
-- Description:	Devuelve los datos para el reporte de Cursos
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_Cursos') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_Cursos
GO

CREATE PROCEDURE usp_Persona_Cursos
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
		SELECT p.IDPersona, Cuartel.Nombre AS CuartelNombre, p.MatriculaNumero, p.ApellidoNombre,
				Cargo.Nombre AS CargoNombre, Cargo.Orden AS CargoOrden, CargoJerarquia.Nombre AS JerarquiaNombre, CargoJerarquia.Orden AS JerarquiaOrden,
				PersonaCapacitacion.Fecha AS CursoFecha, Curso.Nombre AS CursoNombre,
				(CASE ISNULL(PersonaCapacitacion.IDCapacitacionNivel, 254) WHEN 254 THEN PersonaCapacitacion.CapacitacionNivelOtro ELSE CapacitacionNivel.Nombre END) AS CapacitacionNivelNombre,
				CapacitacionNivel.SumaPuntos, PersonaCapacitacion.CantidadDias, PersonaCapacitacion.CantidadHoras
			FROM Persona AS p
				INNER JOIN Cuartel ON p.IDCuartel = Cuartel.IDCuartel
				INNER JOIN PersonaCapacitacion ON p.IDPersona = PersonaCapacitacion.IDPersona
				INNER JOIN Curso ON PersonaCapacitacion.IDCurso = Curso.IDCurso
				LEFT JOIN CapacitacionNivel ON PersonaCapacitacion.IDCapacitacionNivel = CapacitacionNivel.IDCapacitacionNivel
				LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				LEFT JOIN PersonaAscenso ON p.IDPersona = PersonaAscenso.IDPersona
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia
			WHERE p.EsActivo = 1
				AND (@IDCuartel IS NULL OR p.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (PersonaAscenso.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR PersonaAscenso.IDJerarquia = @IDJerarquia)))
				AND (pab.IDAltaBaja IS NULL OR pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, GETDATE()))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR dbo.PersonaObtenerSiEstadoEsActivo(pab.Tipo) = @EstadoActivo)
				AND (@IDPersonaBajaMotivo IS NULL OR pab.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
				AND (@IDPersona IS NULL OR p.IDPersona = @IDPersona)
				AND (@FechaDesde IS NULL OR PersonaCapacitacion.Fecha >= @FechaDesde)
				AND (@FechaHasta IS NULL OR PersonaCapacitacion.Fecha <= @FechaHasta)
	END
GO