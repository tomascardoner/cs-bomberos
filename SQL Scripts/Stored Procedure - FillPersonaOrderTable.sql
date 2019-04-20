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
	SELECT CONCAT('J', FORMAT(Cargo.Orden, '00'), FORMAT(CargoJerarquia.Orden, '00')) AS JerarquiaOrden
		FROM (PersonaAscenso INNER JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
			INNER JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia
		GROUP BY CONCAT('J', FORMAT(Cargo.Orden, '00'), FORMAT(CargoJerarquia.Orden, '00'))
) AS x;

SET @sql = 'INSERT INTO #PersonaOrden SELECT IDPersona, ROW_NUMBER() OVER (ORDER BY ' + STUFF(@columnsorderby, 1, 1, '') + ', FechaNacimiento) AS Orden FROM (
SELECT Persona.IDPersona, FORMAT(PersonaAscenso.Fecha, ''yyyyMMdd'') AS FechaAscenso, CONCAT(''J'', FORMAT(Cargo.Orden, ''00''), FORMAT(CargoJerarquia.Orden, ''00'')) AS JerarquiaOrden, Persona.FechaNacimiento
    FROM ((Persona INNER JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
			INNER JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
			INNER JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
		 AS j PIVOT (MIN(FechaAscenso) FOR JerarquiaOrden in 
	   (' + STUFF(@columns, 1, 1, '')+')) AS p;';

EXEC sys.sp_executesql @sql

END
GO