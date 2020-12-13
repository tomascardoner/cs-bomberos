USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Creation date: 2020-11-24
-- Description:	Devuelve los datos para el listado de compras por área
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Compra_ListadoPorArea') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Compra_ListadoPorArea
GO

CREATE PROCEDURE usp_Compra_ListadoPorArea
	@IDCuartel tinyint,
	@IDArea smallint,
	@FechaDesde date,
	@FechaHasta date,
	@Cerrada bit,
	@CierreFechaDesde date,
	@CierreFechaHasta date
	AS

	BEGIN

		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT c.IDCompra, cu.Codigo AS CuartelCodigo, cu.Nombre AS CuartelNombre, c.Numero, c.Fecha, p.Nombre AS Proveedor, a.Nombre AS Area, cd.IDDetalle, cd.Detalle, c.FacturaNumero, SUM(cd.Importe) AS Importe
			FROM Compra AS c
				INNER JOIN Cuartel AS cu ON c.IDCuartel = cu.IDCuartel
				LEFT JOIN CompraDetalle AS cd ON c.IDCompra = cd.IDCompra
				LEFT JOIN Area AS a ON cd.IDArea = a.IDArea
				LEFT JOIN Proveedor AS p ON c.IDProveedor = p.IDProveedor
			WHERE (@IDCuartel IS NULL OR a.IDCuartel = @IDCuartel)
				AND (@IDArea IS NULL OR cd.IDArea = @IDArea)
				AND (@FechaDesde IS NULL OR c.Fecha >= @FechaDesde)
				AND (@FechaHasta IS NULL OR c.Fecha <= @FechaHasta)
				AND (@Cerrada IS NULL OR c.Cerrada = @Cerrada)
				AND (@CierreFechaDesde IS NULL OR c.CierreFecha >= @CierreFechaDesde)
				AND (@CierreFechaHasta IS NULL OR c.CierreFecha <= @CierreFechaHasta)
			GROUP BY cd.IDArea, c.IDCompra, cu.Codigo, cu.Nombre, c.Numero, c.Fecha, p.Nombre, a.Nombre, cd.IDDetalle, cd.Detalle, c.FacturaNumero
			ORDER BY cd.IDArea, cd.IDDetalle
	END
GO