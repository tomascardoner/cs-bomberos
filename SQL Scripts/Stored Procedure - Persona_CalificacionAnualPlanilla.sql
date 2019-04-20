USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2017-01-11
-- Description:	Devuelve los datos para la Planilla Anual de Calificaciones de un Bombero
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_CalificacionAnualPlanilla') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_CalificacionAnualPlanilla
GO

CREATE PROCEDURE usp_Persona_CalificacionAnualPlanilla
	@IDPersona int,
	@Anio smallint
	AS

	BEGIN
		DECLARE @FechaAscenso date
		DECLARE @CargoJerarquiaNombre varchar(50)
		DECLARE @PromedioAnual decimal(4,2)

		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		-- OBTENGO LA ÚLTIMA JERARQUÍA PARA EL AÑO EN CUESTIÓN
		SET @FechaAscenso = (SELECT MAX(Fecha) FROM PersonaAscenso WHERE IDPersona = @IDPersona AND YEAR(Fecha) <= @Anio)
		SET @CargoJerarquiaNombre = (SELECT CargoJerarquia.Nombre FROM CargoJerarquia INNER JOIN PersonaAscenso ON CargoJerarquia.IDCargo = PersonaAscenso.IDCargo AND CargoJerarquia.IDJerarquia = PersonaAscenso.IDJerarquia WHERE PersonaAscenso.IDPersona = @IDPersona AND PersonaAscenso.Fecha = @FechaAscenso)

		-- OBTENGO EL PROMEDIO ANUAL GENERAL
		SET @PromedioAnual = (SELECT AVG(Promedio) AS PromedioAnual
								FROM (SELECT CAST(AVG(CAST(Calificacion AS DECIMAL(4,2))) AS DECIMAL(4,2)) AS Promedio
										FROM PersonaCalificacion
										WHERE IDPersona = @IDPersona and Anio = @Anio
										GROUP BY IDCalificacionConcepto) AS PromediosConceptosAnual)

		SELECT @CargoJerarquiaNombre AS JerarquiaNombre, Persona.ApellidoNombre, Persona.Apellido, Persona.Nombre, Persona.MatriculaNumero, CalificacionConcepto.Abreviatura AS ConceptoAbreviatura, CalificacionConcepto.Nombre AS ConceptoNombre, CalificacionConcepto.Descripcion AS ConceptoDescripcion, PersonaCalificacion.InstanciaNumero, PersonaCalificacion.Calificacion, @PromedioAnual AS PromedioAnual
			FROM (Persona LEFT JOIN PersonaCalificacion ON Persona.IDPersona = PersonaCalificacion.IDPersona) LEFT JOIN CalificacionConcepto ON PersonaCalificacion.IDCalificacionConcepto = CalificacionConcepto.IDCalificacionConcepto
			WHERE Persona.EsActivo = 1 AND Persona.IDPersona = @IDPersona AND PersonaCalificacion.Anio = @Anio
	END
GO
