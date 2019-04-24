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
	@AnioDesde smallint,
	@AnioHasta smallint,
	@IDPersona int
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT Persona.IDPersona, Persona.ApellidoNombre, Persona.Apellido, Persona.Nombre, Anio, CAST(AVG(Promedio)AS DECIMAL(4,2)) AS CalificacionAnual
			FROM 
				(SELECT IDPersona, Anio, CAST(AVG(CAST(Calificacion AS DECIMAL(4,2))) AS DECIMAL(4,2)) AS Promedio
				FROM PersonaCalificacion
				WHERE (@IDPersona IS NULL OR IDPersona = @IDPersona)
					AND (@AnioDesde IS NULL OR Anio >= @AnioDesde)
					AND (@AnioHasta IS NULL OR Anio <= @AnioHasta)
				GROUP BY IDPersona, Anio, IDCalificacionConcepto) AS PromediosConceptosAnuales
				INNER JOIN Persona ON PromediosConceptosAnuales.IDPersona = Persona.IDPersona
			GROUP BY Persona.IDPersona, Persona.ApellidoNombre, Persona.Apellido, Persona.Nombre, Anio
			ORDER BY Anio
	END
GO