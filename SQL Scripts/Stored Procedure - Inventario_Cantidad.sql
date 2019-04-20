USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-03-21
-- Description:	Devuelve los Elementos del Inventario con la Cantidad
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Inventario_Cantidad') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Inventario_Cantidad
GO

CREATE PROCEDURE usp_Inventario_Cantidad
	@IDCuartel tinyint,
	@IDArea smallint,
	@IDUbicacion smallint,
	@IDSubUbicacion smallint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT Cuartel.Nombre AS CuartelNombre, Area.Nombre AS AreaNombre, Elemento.Nombre + ISNULL(' ' + Inventario.DescripcionPropia , '') AS ElementoNombre, Ubicacion.Nombre AS UbicacionNombre, ModoAdquisicion.Nombre AS ModoAdquisicionNombre, SUM(ISNULL(Inventario.Cantidad, 1)) AS Cantidad
			FROM (((((Inventario INNER JOIN Area ON Inventario.IDArea = Area.IDArea)
				INNER JOIN Cuartel ON Area.IDCuartel = Cuartel.IDCuartel)
				INNER JOIN Elemento ON Inventario.IDElemento = Elemento.IDElemento)
				LEFT JOIN Ubicacion ON Inventario.IDUbicacion = Ubicacion.IDUbicacion)
				LEFT JOIN SubUbicacion ON Inventario.IDSubUbicacion = SubUbicacion.IDSubUbicacion)
				LEFT JOIN ModoAdquisicion ON Inventario.IDModoAdquisicion = ModoAdquisicion.IDModoAdquisicion
			WHERE Inventario.EsActivo = 1
				AND (@IDCuartel IS NULL OR Area.IDCuartel = @IDCuartel)
				AND (@IDArea IS NULL OR Inventario.IDArea = @IDArea)
				AND (@IDUbicacion IS NULL OR Inventario.IDUbicacion = @IDUbicacion)
				AND (@IDSubUbicacion IS NULL OR Inventario.IDSubUbicacion = @IDSubUbicacion)
			GROUP BY Cuartel.Nombre, Area.Nombre, Elemento.Nombre + ISNULL(' ' + Inventario.DescripcionPropia , ''), Ubicacion.Nombre, ModoAdquisicion.Nombre
	END
GO