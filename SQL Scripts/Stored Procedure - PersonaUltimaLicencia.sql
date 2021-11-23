USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-04-18
-- Updates: 2021-11-21 - Actualizado a las nuevas funciones y tablas
-- Description:	Devuelve las Personas con su última licencia
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'uspPersonaUltimaLicencia') AND type in (N'P', N'PC'))
	 DROP PROCEDURE uspPersonaUltimaLicencia
GO

CREATE PROCEDURE uspPersonaUltimaLicencia
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@FechaDesde date,
	@FechaHasta date
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		-- Ordeno las personas
		CREATE TABLE #PersonaOrden
			(IDPersona int NOT NULL, Orden smallint NOT NULL,
				CONSTRAINT PK__PersonaOrden PRIMARY KEY CLUSTERED 
					(IDPersona ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON))
		EXEC dbo.usp_FillPersonaOrderTable

		SELECT p.IDPersona, p.MatriculaNumero, p.Apellido, p.Nombre, p.ApellidoNombre, lc.Nombre AS LicenciaCausa, pl.FechaDesde, pl.FechaHasta, pl.FechaInterrupcion, #PersonaOrden.Orden
			FROM Persona AS p
				INNER JOIN #PersonaOrden ON p.IDPersona = #PersonaOrden.IDPersona
				LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
				LEFT JOIN PersonaLicencia AS pl ON p.IDPersona = pl.IDPersona
				LEFT JOIN LicenciaCausa AS lc ON pl.IDLicenciaCausa = lc.IDLicenciaCausa
			WHERE p.EsActivo = 1
				AND (@IDCuartel IS NULL OR p.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (pa.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR pa.IDJerarquia = @IDJerarquia)))
				AND (pab.IDAltaBaja IS NULL OR pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, NULL))
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, NULL))
				AND (pl.Fecha IS NULL OR pl.Fecha = dbo.PersonaObtenerFechaUltimaLicencia(p.IDPersona, NULL))
				AND (@FechaDesde IS NULL OR pl.Fecha >= @FechaDesde)
				AND (@FechaHasta IS NULL OR pl.Fecha <= @FechaHasta)
	END
GO