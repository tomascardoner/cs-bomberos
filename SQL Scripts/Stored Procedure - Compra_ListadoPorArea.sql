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
	@CierreFechaHasta date,
	@IDResponsable tinyint
	AS

	BEGIN
		DECLARE @ResponsableIDPersona int
		DECLARE @ResponsableApellidoNombre varchar(102)
		DECLARE @ResponsableEstadoActivo bit
		DECLARE @ResponsableJerarquia varchar(50)
		DECLARE @ResponsableTipo varchar(50)

		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		-- Obtengo el Cargo y el Apellido y nombre del Responsable firmante
		SELECT @ResponsableIDPersona = r.IDPersona, @ResponsableApellidoNombre = ISNULL(p.ApellidoNombre, r.PersonaOtra), @ResponsableTipo = rt.Nombre
			FROM Responsable AS r
				INNER JOIN ResponsableTipo AS rt ON r.IDResponsableTipo = rt.IDResponsableTipo
				LEFT JOIN Persona AS p ON r.IDPersona = p.IDPersona
			WHERE r.IDResponsable = @IDResponsable

		-- Obtengo el Estado actual del Responsable
		IF @ResponsableIDPersona IS NULL
			SET @ResponsableEstadoActivo = 0
		ELSE
			SELECT @ResponsableEstadoActivo = (CASE ISNULL(pab.IDAltaBaja, 0) WHEN 0 THEN 0 ELSE (CASE ISNULL(pab.BajaFecha, '') WHEN '' THEN 1 ELSE 0 END) END)
				FROM (Persona AS p
					LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona)
					LEFT JOIN PersonaBajaMotivo AS pbm ON pab.IDPersonaBajaMotivo = pbm.IDPersonaBajaMotivo
				WHERE p.IDPersona = @ResponsableIDPersona
					AND (pab.AltaFecha IS NULL OR pab.AltaFecha = (SELECT MAX(AltaFecha) FROM PersonaAltaBaja WHERE IDPersona = pab.IDPersona GROUP BY IDPersona))

		-- Obtengo la Jerarquía del Responsable
		IF @ResponsableIDPersona IS NULL
			SET @ResponsableJerarquia = NULL
		ELSE
			SELECT @ResponsableJerarquia = cj.Nombre
				FROM PersonaAscenso AS pa
					INNER JOIN Cargo AS c ON pa.IDCargo = c.IDCargo
					INNER JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
				WHERE pa.IDPersona = @ResponsableIDPersona
					AND (pa.Fecha IS NULL OR pa.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(@ResponsableIDPersona, GETDATE()))

		(SELECT c.IDCompra, cu.Codigo AS CuartelCodigo, cu.Nombre AS CuartelNombre, c.Numero, c.Fecha, p.Nombre AS Proveedor, cd.IDArea, a.Nombre AS Area, cd.IDDetalle, cd.Detalle, c.FacturaNumero, SUM(cd.Importe) AS Importe, @ResponsableApellidoNombre AS FirmanteApellidoNombre, @ResponsableEstadoActivo AS FirmanteEstadoActivo, @ResponsableJerarquia AS FirmanteJerarquia, @ResponsableTipo AS FirmanteCargo
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
			GROUP BY cd.IDArea, c.IDCompra, cu.Codigo, cu.Nombre, c.Numero, c.Fecha, p.Nombre, a.Nombre, cd.IDDetalle, cd.Detalle, c.FacturaNumero)
		UNION
		(SELECT 0 AS IDCompra, c.Codigo AS CuartelCodigo, c.Nombre AS CuartelNombre, 0 AS Numero, cad.Fecha AS Fecha, cad.Proveedor, cad.IDArea, a.Nombre AS Area, cad.IDDetalle, cad.Detalle, cad.NumeroComprobante AS FacturaNumero, SUM(cad.Importe) AS Importe, @ResponsableApellidoNombre AS FirmanteApellidoNombre, @ResponsableEstadoActivo AS FirmanteEstadoActivo, @ResponsableJerarquia AS FirmanteJerarquia, @ResponsableTipo AS FirmanteCargo
			FROM CajaArqueo AS ca
				INNER JOIN CajaArqueoDetalle AS cad ON ca.IDArqueo = cad.IDArqueo
				LEFT JOIN Area AS a ON a.IDArea = cad.IDArea
				LEFT JOIN Cuartel AS c ON a.IDCuartel = c.IDCuartel
			WHERE (@IDCuartel IS NULL OR a.IDCuartel = @IDCuartel)
				AND (@IDArea IS NULL OR cad.IDArea = @IDArea)
				AND (@FechaDesde IS NULL OR ca.FechaCierre >= @FechaDesde)
				AND (@FechaHasta IS NULL OR ca.FechaCierre <= @FechaHasta)
				AND (@CierreFechaDesde IS NULL OR ca.FechaCierre >= @CierreFechaDesde)
				AND (@CierreFechaHasta IS NULL OR ca.FechaCierre <= @CierreFechaHasta)
			GROUP BY cad.IDArea, ca.IDArqueo, c.Codigo, c.Nombre, cad.Fecha, cad.Proveedor, a.Nombre, cad.IDDetalle, cad.Detalle, cad.NumeroComprobante)
			ORDER BY IDArea, IDDetalle
	END
GO