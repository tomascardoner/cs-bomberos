USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-11
-- Description:	Devuelve los datos para el reporte de Antigüedades
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_ListadoAntiguedad') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_ListadoAntiguedad
GO

CREATE PROCEDURE usp_Persona_ListadoAntiguedad
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@EstadoActivo bit,
	@IDPersonaBajaMotivo tinyint,
	@FechaHasta date,
	@IDPersona int
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

		IF @FechaHasta IS NULL
			SET @FechaHasta = GETDATE()

		SELECT Persona.IDPersona, Cuartel.Nombre AS CuartelNombre, Persona.MatriculaNumero, Persona.ApellidoNombre, Cargo.Nombre AS CargoNombre, CargoJerarquia.Nombre AS JerarquiaNombre, dbo.udf_GetPersonaAntiguedadLeyenda(Persona.IDPersona, NULL, @FechaHasta) AS AntiguedadTotalLeyenda, #PersonaOrden.Orden
			FROM ((((((Persona INNER JOIN #PersonaOrden ON Persona.IDPersona = #PersonaOrden.IDPersona)
				INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
			WHERE Persona.EsActivo = 1
				AND (@IDCuartel IS NULL OR Persona.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (PersonaAscenso.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR PersonaAscenso.IDJerarquia = @IDJerarquia)))
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, @FechaHasta))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, @FechaHasta))
				AND (@EstadoActivo IS NULL OR (@EstadoActivo = 1 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NULL) OR (@EstadoActivo = 0 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NOT NULL))
				AND (@IDPersonaBajaMotivo IS NULL OR PersonaAltaBaja.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
				AND (@IDPersona IS NULL OR Persona.IDPersona = @IDPersona)
	END
GO