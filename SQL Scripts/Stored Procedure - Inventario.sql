USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-12-01
-- Description:	Devuelve los Elementos del Inventario
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Inventario') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Inventario
GO

CREATE PROCEDURE usp_Inventario
	@IDCuartel tinyint,
	@IDArea smallint,
	@IDUbicacion smallint,
	@IDSubUbicacion smallint,
	@Baja bit,
	@FechaBaja date
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT Cuartel.IDCuartel, Cuartel.Nombre AS CuartelNombre, Area.IDArea, Area.Codigo AS AreaCodigo, Area.Nombre AS AreaNombre,
				Inventario.Codigo AS InventarioCodigo, Area.Codigo + Inventario.Codigo AS AreaInventarioCodigo, Elemento.Nombre AS ElementoNombre,
				Inventario.DescripcionPropia AS InventarioDescripcionPropia, 
				Elemento.Nombre + ISNULL(' ' + Inventario.DescripcionPropia, '') AS ElementoNombreInventarioDescripcionPropia, 
				Rubro.Nombre AS Rubro, SubRubro.Nombre AS SubRubro, 
				Ubicacion.IDUbicacion, Ubicacion.Nombre AS UbicacionNombre, SubUbicacion.IDSubUbicacion, SubUbicacion.Nombre AS SubUbicacionNombre, 
				ModoAdquisicion.IDModoAdquisicion, ModoAdquisicion.Nombre AS ModoAdquisicionNombre, ISNULL(Inventario.Cantidad, 1) AS Cantidad, Inventario.FechaBaja
			FROM Inventario INNER JOIN Area ON Inventario.IDArea = Area.IDArea
				INNER JOIN Cuartel ON Area.IDCuartel = Cuartel.IDCuartel
				INNER JOIN Elemento ON Inventario.IDElemento = Elemento.IDElemento
				LEFT JOIN Rubro ON Elemento.IDRubro = Rubro.IDRubro
				LEFT JOIN SubRubro ON Elemento.IDSubRubro = SubRubro.IDSubRubro
				LEFT JOIN Ubicacion ON Inventario.IDUbicacion = Ubicacion.IDUbicacion
				LEFT JOIN SubUbicacion ON Inventario.IDSubUbicacion = SubUbicacion.IDSubUbicacion
				LEFT JOIN ModoAdquisicion ON Inventario.IDModoAdquisicion = ModoAdquisicion.IDModoAdquisicion
			WHERE (@IDCuartel IS NULL OR Area.IDCuartel = @IDCuartel)
				AND (@IDArea IS NULL OR Inventario.IDArea = @IDArea)
				AND (@IDUbicacion IS NULL OR Inventario.IDUbicacion = @IDUbicacion)
				AND (@IDSubUbicacion IS NULL OR Inventario.IDSubUbicacion = @IDSubUbicacion)
				AND (@Baja IS NULL OR Inventario.EsActivo <> @Baja)
				AND (@FechaBaja IS NULL OR Inventario.FechaBaja = @FechaBaja)
	END
GO