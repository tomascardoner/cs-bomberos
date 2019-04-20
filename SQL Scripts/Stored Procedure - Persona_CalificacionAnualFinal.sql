USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2017-01-09
-- Description:	Devuelve las calificaciones anuales finales de un Bombero
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_CalificacionAnualFinal') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_CalificacionAnualFinal
GO

CREATE PROCEDURE usp_Persona_CalificacionAnualFinal
	@IDPersona int
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT IDPersona, Anio, CAST(AVG(Promedio)AS DECIMAL(4,2)) AS CalificacionAnual
			FROM 
				(SELECT IDPersona, Anio, CAST(AVG(CAST(Calificacion AS DECIMAL(4,2))) AS DECIMAL(4,2)) AS Promedio
				FROM PersonaCalificacion
				WHERE IDPersona = @IDPersona
				GROUP BY IDPersona, Anio, IDCalificacionConcepto) AS PromediosConceptosAnuales
			GROUP BY IDPersona, Anio
			ORDER BY Anio
	END
GO