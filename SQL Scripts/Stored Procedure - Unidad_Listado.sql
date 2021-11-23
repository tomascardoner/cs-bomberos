USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-11
-- Description:	Devuelve los datos para el reporte de Unidades
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Unidad_Listado') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Unidad_Listado
GO

CREATE PROCEDURE usp_Unidad_Listado
	@IDCuartel tinyint,
	@IDUnidad smallint,
	@FechaDesde date,
	@FechaHasta date
	AS

	BEGIN
		SELECT u.IDUnidad, u.Numero, u.MarcaModelo, u.EsImportado, u.Anio, u.NumeroMotor, u.NumeroChasis, u.Dominio,
				ut.Nombre AS UnidadTipoNombre, uu.Nombre AS UnidadUsoNombre, ct.Nombre AS CombustibleTipoNombre, u.FechaAdquisicion,
				u.KilometrajeInicial, u.CapacidadAguaLitros, c.Nombre AS CuartelNombre, u.EsPropio, u.VerificacionVencimiento
			FROM Unidad AS u
				INNER JOIN UnidadTipo AS ut ON u.IDUnidadTipo = ut.IDUnidadTipo
				INNER JOIN UnidadUso AS uu ON u.IDUnidadUso = uu.IDUnidadUso
				LEFT JOIN CombustibleTipo AS ct ON u.IDCombustibleTipo = ct.IDCombustibleTipo
				INNER JOIN Cuartel AS c ON u.IDCuartel = c.IDCuartel
			WHERE u.EsActivo = 1
				AND (@IDCuartel IS NULL OR u.IDCuartel = @IDCuartel)
				AND (@IDUnidad IS NULL OR u.IDUnidad = @IDUnidad)
				AND (@FechaDesde IS NULL OR u.VerificacionVencimiento >= @FechaDesde)
				AND (@FechaHasta IS NULL OR u.VerificacionVencimiento <= @FechaHasta)
	END
GO