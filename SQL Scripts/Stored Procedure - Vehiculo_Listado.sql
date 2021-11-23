USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-04-19
-- Description:	Devuelve los datos para el reporte de Vehículos personales
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Vehiculo_Listado') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Vehiculo_Listado
GO

CREATE PROCEDURE usp_Vehiculo_Listado
	@IDCuartel tinyint,
	@IDPersona int,
	@FechaVencimientoVerificacionDesde date,
	@FechaVencimientoVerificacionHasta date,
	@FechaVencimientoSeguroDesde date,
	@FechaVencimientoSeguroHasta date
	AS

	BEGIN
		SELECT p.MatriculaNumero AS PersonaMatriculaNumero, p.ApellidoNombre AS PersonaApellidoNombre, pv.IDVehiculo, vt.Nombre AS VehiculoTipoNombre, pv.Dominio,
			vm.Nombre AS VehiculoMarcaNombre, pv.Modelo, pv.Anio, pv.VerificacionVencimiento, vcs.Nombre AS VehiculoCompaniaSeguroNombre, pv.SeguroPolizaNumero, pv.SeguroVencimiento
			FROM Persona AS p
				INNER JOIN PersonaVehiculo AS pv ON p.IDPersona = pv.IDPersona
				INNER JOIN VehiculoTipo AS vt ON pv.IDVehiculoTipo = vt.IDVehiculoTipo
				LEFT JOIN VehiculoMarca AS vm ON pv.IDVehiculoMarca = vm.IDVehiculoMarca
				LEFT JOIN VehiculoCompaniaSeguro AS vcs ON pv.IDVehiculoCompaniaSeguro = vcs.IDVehiculoCompaniaSeguro
			WHERE pv.EsActivo = 1
				AND (@IDCuartel IS NULL OR p.IDCuartel = @IDCuartel)
				AND (@IDPersona IS NULL OR p.IDPersona = @IDPersona)
				AND (@FechaVencimientoVerificacionDesde IS NULL OR pv.VerificacionVencimiento >= @FechaVencimientoVerificacionDesde)
				AND (@FechaVencimientoVerificacionHasta IS NULL OR pv.VerificacionVencimiento <= @FechaVencimientoVerificacionHasta)
				AND (@FechaVencimientoSeguroDesde IS NULL OR pv.SeguroVencimiento >= @FechaVencimientoSeguroDesde)
				AND (@FechaVencimientoSeguroHasta IS NULL OR pv.SeguroVencimiento <= @FechaVencimientoSeguroHasta)
	END
GO