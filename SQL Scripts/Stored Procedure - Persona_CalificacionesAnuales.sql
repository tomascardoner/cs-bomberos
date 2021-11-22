USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2017-04-23
-- Description:	Devuelve las calificaciones anuales finales de todas las Personas
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Personas_CalificacionesAnuales') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Personas_CalificacionesAnuales
GO

CREATE PROCEDURE usp_Personas_CalificacionesAnuales
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@EstadoActivo bit,
	@IDPersonaBajaMotivo tinyint,
	@AnioDesde smallint,
	@AnioHasta smallint,
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

		SELECT p.IDPersona, p.MatriculaNumero, p.ApellidoNombre, p.Apellido, p.Nombre, #PersonaOrden.Orden, Anio, CAST(AVG(Promedio)AS DECIMAL(4,2)) AS CalificacionAnual
			FROM 
				(SELECT IDPersona, Anio, CAST(AVG(CAST(Calificacion AS DECIMAL(4,2))) AS DECIMAL(4,2)) AS Promedio
					FROM PersonaCalificacion
					WHERE (@IDPersona IS NULL OR IDPersona = @IDPersona)
						AND (@AnioDesde IS NULL OR Anio >= @AnioDesde)
						AND (@AnioHasta IS NULL OR Anio <= @AnioHasta)
					GROUP BY IDPersona, Anio, IDCalificacionConcepto) AS pca
				INNER JOIN Persona AS p ON pca.IDPersona = p.IDPersona
				INNER JOIN #PersonaOrden ON p.IDPersona = #PersonaOrden.IDPersona
				LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
			WHERE (@IDCuartel IS NULL OR p.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (pa.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR pa.IDJerarquia = @IDJerarquia)))
				AND (pab.IDAltaBaja IS NULL OR pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, GETDATE()))
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR dbo.PersonaObtenerSiEstadoEsActivo(pab.Tipo) = @EstadoActivo)
				AND (@IDPersonaBajaMotivo IS NULL OR pab.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
			GROUP BY p.IDPersona, p.MatriculaNumero, p.ApellidoNombre, p.Apellido, p.Nombre, #PersonaOrden.Orden, Anio
			ORDER BY Anio
	END
GO