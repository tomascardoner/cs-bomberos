USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Creation date: 2024-11-30
-- Description:	Devuelve los datos del familiar de la Persona
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'PersonaObtenerFamiliar') AND type in (N'P', N'PC'))
	 DROP PROCEDURE PersonaObtenerFamiliar
GO

CREATE PROCEDURE PersonaObtenerFamiliar
	@IDPersona int,
	@IDFamiliar tinyint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		-- Traigo los datos correspondientes
		SET LANGUAGE Spanish
		SELECT 'Lobos' AS Ciudad, GETDATE() AS Fecha, YEAR(GETDATE()) % 100 AS FechaAnio, DATENAME(MONTH, GETDATE()) AS FechaMes, DAY(GETDATE()) AS FechaDia, p.ApellidoNombre, p.DocumentoNumero, pf.ApellidoNombre AS FamiliarApellidoNombre, pf.DocumentoNumero AS FamiliarDocumentoNumero
			FROM Persona AS p
				INNER JOIN PersonaFamiliar AS pf ON p.IDPersona = pf.IDPersona
			WHERE p.IDPersona = @IDPersona AND pf.IDFamiliar = @IDFamiliar
	END
GO