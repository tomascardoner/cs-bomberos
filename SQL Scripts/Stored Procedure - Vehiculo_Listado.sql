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
		SELECT Persona.MatriculaNumero AS PersonaMatriculaNumero, Persona.ApellidoNombre AS PersonaApellidoNombre, PersonaVehiculo.IDVehiculo, VehiculoTipo.Nombre AS VehiculoTipoNombre, PersonaVehiculo.Dominio, VehiculoMarca.Nombre AS VehiculoMarcaNombre, PersonaVehiculo.Modelo, PersonaVehiculo.Anio, PersonaVehiculo.VerificacionVencimiento, VehiculoCompaniaSeguro.Nombre AS VehiculoCompaniaSeguroNombre, PersonaVehiculo.SeguroPolizaNumero, PersonaVehiculo.SeguroVencimiento
			FROM (((Persona INNER JOIN PersonaVehiculo ON Persona.IDPersona = PersonaVehiculo.IDPersona) INNER JOIN VehiculoTipo ON PersonaVehiculo.IDVehiculoTipo = VehiculoTipo.IDVehiculoTipo) LEFT JOIN VehiculoMarca ON PersonaVehiculo.IDVehiculoMarca = VehiculoMarca.IDVehiculoMarca) LEFT JOIN VehiculoCompaniaSeguro ON PersonaVehiculo.IDVehiculoCompaniaSeguro = VehiculoCompaniaSeguro.IDVehiculoCompaniaSeguro
			WHERE PersonaVehiculo.EsActivo = 1
				AND (@IDCuartel IS NULL OR Persona.IDCuartel = @IDCuartel)
				AND (@IDPersona IS NULL OR Persona.IDPersona = @IDPersona)
				AND (@FechaVencimientoVerificacionDesde IS NULL OR PersonaVehiculo.VerificacionVencimiento >= @FechaVencimientoVerificacionDesde)
				AND (@FechaVencimientoVerificacionHasta IS NULL OR PersonaVehiculo.VerificacionVencimiento <= @FechaVencimientoVerificacionHasta)
				AND (@FechaVencimientoSeguroDesde IS NULL OR PersonaVehiculo.SeguroVencimiento >= @FechaVencimientoSeguroDesde)
				AND (@FechaVencimientoSeguroHasta IS NULL OR PersonaVehiculo.SeguroVencimiento <= @FechaVencimientoSeguroHasta)
	END
GO