USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-09-26
-- Description:	Devuelve los datos para el reporte de Obras Sociales
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_ObraSocial') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_ObraSocial
GO

CREATE PROCEDURE usp_Persona_ObraSocial
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@EstadoActivo bit,
	@IDPersonaBajaMotivo tinyint,
	@FechaDesde date,
	@FechaHasta date,
	@IDPersona int
	AS

	BEGIN
		SELECT p.IDPersona, c.Nombre AS CuartelNombre, p.MatriculaNumero, p.ApellidoNombre,
				ca.Nombre AS CargoNombre, ca.Orden AS CargoOrden, cj.Nombre AS JerarquiaNombre, cj.Orden AS JerarquiaOrden,
				p.IOMAVencimientoCredencial AS PersonaIOMAVencimientoCredencial, pf.ApellidoNombre AS FamiliarApellidoNombre,
				pf.IOMAVencimientoCredencial AS PersonaFamiliarIOMAVencimientoCredencial
			FROM Persona AS p
				INNER JOIN Cuartel AS c ON p.IDCuartel = c.IDCuartel
				LEFT JOIN (SELECT IDPersona, IDFamiliar, ApellidoNombre, IOMAVencimientoCredencial
							FROM PersonaFamiliar
							WHERE EsActivo = 1
								AND (@FechaDesde IS NULL OR IOMAVencimientoCredencial >= @FechaDesde)
								AND (@FechaHasta IS NULL OR IOMAVencimientoCredencial <= @FechaHasta)) AS pf ON p.IDPersona = pf.IDPersona
				LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
				LEFT JOIN Cargo AS ca ON pa.IDCargo = ca.IDCargo
				LEFT JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
			WHERE p.EsActivo = 1
				AND (@IDCuartel IS NULL OR p.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (pa.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR pa.IDJerarquia = @IDJerarquia)))
				AND (pab.IDAltaBaja IS NULL OR pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, GETDATE()))
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR dbo.PersonaObtenerSiEstadoEsActivo(pab.Tipo) = @EstadoActivo)
				AND (@IDPersonaBajaMotivo IS NULL OR pab.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
				AND (@IDPersona IS NULL OR p.IDPersona = @IDPersona)
                AND (@FechaDesde IS NULL OR p.IOMAVencimientoCredencial >= @FechaDesde OR pf.IDPersona IS NOT NULL)
				AND (@FechaHasta IS NULL OR p.IOMAVencimientoCredencial <= @FechaHasta OR pf.IDPersona IS NOT NULL)
	END
GO