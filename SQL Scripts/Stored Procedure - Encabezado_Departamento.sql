USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2020-03-22
-- Modifications: 
-- Description:	Devuelve los datos del encabezado del Departamento
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Encabezado_Departamento') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Encabezado_Departamento
GO

CREATE PROCEDURE usp_Encabezado_Departamento
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT (SELECT Texto FROM Parametro WHERE IDParametro = 'ENCABEZADO_DEPARTAMENTO_LINEA1') AS Linea1,
				(SELECT Texto FROM Parametro WHERE IDParametro = 'ENCABEZADO_DEPARTAMENTO_LINEA2') AS Linea2,
				(SELECT Texto FROM Parametro WHERE IDParametro = 'ENCABEZADO_DEPARTAMENTO_LINEA3') AS Linea3
	END
GO