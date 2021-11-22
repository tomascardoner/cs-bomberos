USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-11-06
-- Description:	Fills the PersonaOrden table
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.usp_FillPersonaOrderTable') AND type in (N'P', N'PC'))
	DROP PROCEDURE dbo.usp_FillPersonaOrderTable
GO

CREATE PROCEDURE usp_FillPersonaOrderTable
	AS
BEGIN

DECLARE @columns VARCHAR(MAX)
DECLARE @columnsorderby VARCHAR(MAX)
DECLARE @sql NVARCHAR(MAX)

SET @columns = ''
SET @columnsorderby = ''

SELECT @columns += ', ' + JerarquiaOrden, @columnsorderby += ', ISNULL(' + JerarquiaOrden + ', ''99999999'')'
FROM
(
	SELECT CONCAT('J', FORMAT(c.Orden, '00'), FORMAT(cj.Orden, '00')) AS JerarquiaOrden
		FROM PersonaAscenso AS pa
			INNER JOIN Cargo AS c ON pa.IDCargo = c.IDCargo
			INNER JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
		GROUP BY CONCAT('J', FORMAT(c.Orden, '00'), FORMAT(cj.Orden, '00'))
) AS x;

SET @sql = 'INSERT INTO #PersonaOrden
				SELECT IDPersona, ROW_NUMBER() OVER (ORDER BY ' + STUFF(@columnsorderby, 1, 1, '') + ', FechaNacimiento) AS Orden
					FROM (
						SELECT p.IDPersona, FORMAT(pa.Fecha, ''yyyyMMdd'') AS FechaAscenso, CONCAT(''J'', FORMAT(c.Orden, ''00''), FORMAT(cj.Orden, ''00'')) AS JerarquiaOrden, p.FechaNacimiento
						    FROM Persona AS p
								INNER JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
								INNER JOIN Cargo AS c ON pa.IDCargo = c.IDCargo
								INNER JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia) AS j
					PIVOT (MIN(FechaAscenso) FOR JerarquiaOrden in 
					(' + STUFF(@columns, 1, 1, '')+')) AS pi;';

EXEC sys.sp_executesql @sql

END
GO