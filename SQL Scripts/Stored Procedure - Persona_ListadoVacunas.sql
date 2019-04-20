USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-04-19
-- Description:	Devuelve los datos para los reportes de Vacunas
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_ListadoVacunas') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_ListadoVacunas
GO

CREATE PROCEDURE usp_Persona_ListadoVacunas
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@EstadoActivo bit,
	@IDPersonaBajaMotivo tinyint,
	@IDPersona int,
	@FechaDesde date,
	@FechaHasta date
	AS

	BEGIN

		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		-- ORDENO LAS PERSONAS - START
		CREATE TABLE #PersonaOrden
			(IDPersona int NOT NULL, Orden smallint NOT NULL,
				CONSTRAINT PK__PersonaOrden PRIMARY KEY CLUSTERED 
					(IDPersona ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON))
		EXEC dbo.usp_FillPersonaOrderTable
		-- ORDENO LAS PERSONAS - END

		SELECT Persona.IDPersona, Cuartel.Nombre AS CuartelNombre, Persona.MatriculaNumero, Persona.ApellidoNombre, Cargo.Nombre AS CargoNombre, CargoJerarquia.Nombre AS JerarquiaNombre, VacunaTipo.Nombre AS VacunaTipoNombre, PersonaVacuna.Lote, PersonaVacuna.DosisNumero, PersonaVacuna.Fecha, PersonaVacuna.Vencimiento, #PersonaOrden.Orden
			FROM ((((((Persona INNER JOIN #PersonaOrden ON Persona.IDPersona = #PersonaOrden.IDPersona)
				INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				INNER JOIN PersonaVacuna ON Persona.IDPersona = PersonaVacuna.IDPersona
				INNER JOIN VacunaTipo ON PersonaVacuna.IDVacunaTipo = VacunaTipo.IDVacunaTipo
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
			WHERE Persona.EsActivo = 1
				AND (@IDCuartel IS NULL OR Persona.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (PersonaAscenso.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR PersonaAscenso.IDJerarquia = @IDJerarquia)))
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, GETDATE()))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR (@EstadoActivo = 1 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NULL) OR (@EstadoActivo = 0 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NOT NULL))
				AND (@IDPersonaBajaMotivo IS NULL OR PersonaAltaBaja.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
				AND (@IDPersona IS NULL OR Persona.IDPersona = @IDPersona)
				AND (@FechaDesde IS NULL OR PersonaVacuna.Vencimiento >= @FechaDesde)
				AND (@FechaHasta IS NULL OR PersonaVacuna.Vencimiento <= @FechaHasta)
	END
GO