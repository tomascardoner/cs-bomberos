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
		SELECT Unidad.IDUnidad, Unidad.Numero, Unidad.MarcaModelo, Unidad.EsImportado, Unidad.Anio, Unidad.NumeroMotor, Unidad.NumeroChasis, Unidad.Dominio, UnidadTipo.Nombre AS UnidadTipoNombre, UnidadUso.Nombre AS UnidadUsoNombre, CombustibleTipo.Nombre AS CombustibleTipoNombre, Unidad.FechaAdquisicion, Unidad.KilometrajeInicial, Unidad.CapacidadAguaLitros, Cuartel.Nombre AS CuartelNombre, Unidad.EsPropio, Unidad.VerificacionVencimiento
			FROM (((Unidad INNER JOIN UnidadTipo ON Unidad.IDUnidadTipo = UnidadTipo.IDUnidadTipo) INNER JOIN UnidadUso ON Unidad.IDUnidadUso = UnidadUso.IDUnidadUso) LEFT JOIN CombustibleTipo ON Unidad.IDCombustibleTipo = CombustibleTipo.IDCombustibleTipo) INNER JOIN Cuartel ON Unidad.IDCuartel = Cuartel.IDCuartel
			WHERE Unidad.EsActivo = 1
				AND (@IDCuartel IS NULL OR Unidad.IDCuartel = @IDCuartel)
				AND (@IDUnidad IS NULL OR Unidad.IDUnidad = @IDUnidad)
				AND (@FechaDesde IS NULL OR Unidad.VerificacionVencimiento >= @FechaDesde)
				AND (@FechaHasta IS NULL OR Unidad.VerificacionVencimiento <= @FechaHasta)
	END
GO