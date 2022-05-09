USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-10-31
-- Updates: 2021-11-21 - Actualizado a las nuevas funciones y tablas
-- Description:	Devuelve los datos para el reporte de Sanciones Disciplinarias
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_Sanciones') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_Sanciones
GO

CREATE PROCEDURE usp_Persona_Sanciones
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
		SELECT p.IDPersona, c.Nombre AS CuartelNombre, p.MatriculaNumero, p.ApellidoNombre, ca.Nombre AS CargoNombre, ca.Orden AS CargoOrden,
				cj.Nombre AS JerarquiaNombre, cj.Orden AS JerarquiaOrden, ps.ResolucionFecha, st.Nombre AS SancionTipoNombre
			FROM Persona AS p
				INNER JOIN PersonaSancion AS ps ON p.IDPersona = ps.IDPersona
				INNER JOIN SancionTipo AS st ON ps.ResolucionIDSancionTipo = st.IDSancionTipo
				INNER JOIN Cuartel AS c ON p.IDCuartel = c.IDCuartel
				LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
				LEFT JOIN Cargo AS ca ON pa.IDCargo = ca.IDCargo
				LEFT JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
			WHERE p.EsActivo = 1 AND ps.Estado = 'A'
				AND (@IDCuartel IS NULL OR p.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (pa.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR pa.IDJerarquia = @IDJerarquia)))
				AND (pab.IDAltaBaja IS NULL OR pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, NULL))
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, NULL))
				AND (@EstadoActivo IS NULL OR dbo.PersonaObtenerSiEstadoEsActivo(pab.Tipo) = @EstadoActivo)
				AND (@IDPersonaBajaMotivo IS NULL OR pab.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
				AND (@IDPersona IS NULL OR p.IDPersona = @IDPersona)
				AND (@FechaDesde IS NULL OR ps.ResolucionFecha >= @FechaDesde)
				AND (@FechaHasta IS NULL OR ps.ResolucionFecha <= @FechaHasta)
	END
GO