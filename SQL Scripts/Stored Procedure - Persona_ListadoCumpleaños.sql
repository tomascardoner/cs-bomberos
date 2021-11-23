USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
    -- Author:		Tomás A. Cardoner
-- Create date: 2020-03-15
-- Description:	Devuelve los datos para el reporte de Cumpleaños
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_ListadoCumpleanios') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_ListadoCumpleanios
GO

CREATE PROCEDURE usp_Persona_ListadoCumpleanios
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@EstadoActivo bit,
	@IDPersonaBajaMotivo tinyint,
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

		SELECT p.IDPersona, c.Nombre AS CuartelNombre, p.MatriculaNumero, p.ApellidoNombre, ca.Nombre AS CargoNombre, cj.Nombre AS JerarquiaNombre, p.FechaNacimiento, #PersonaOrden.Orden
			FROM Persona AS p
				INNER JOIN #PersonaOrden ON p.IDPersona = #PersonaOrden.IDPersona
				INNER JOIN Cuartel AS c ON p.IDCuartel = c.IDCuartel
				LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
				LEFT JOIN Cargo AS ca ON pa.IDCargo = ca.IDCargo
				LEFT JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
			WHERE p.EsActivo = 1
				AND (@IDCuartel IS NULL OR p.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (pa.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR pa.IDJerarquia = @IDJerarquia)))
				AND (pab.IDAltaBaja IS NULL OR pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, GETDATE()))
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR dbo.PersonaObtenerSiEstadoEsActivo(pab.Tipo) = @EstadoActivo)
				AND (@IDPersonaBajaMotivo IS NULL OR pab.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
				AND (@FechaDesde IS NULL OR DATEADD(year, -YEAR(p.FechaNacimiento) + 1, p.FechaNacimiento) >= DATEADD(year, -YEAR(@FechaDesde) + 1, @FechaDesde))
				AND (@FechaHasta IS NULL OR DATEADD(year, -YEAR(p.FechaNacimiento) + 1, p.FechaNacimiento) <= DATEADD(year, -YEAR(@FechaHasta) + 1, @FechaHasta))
	END
GO