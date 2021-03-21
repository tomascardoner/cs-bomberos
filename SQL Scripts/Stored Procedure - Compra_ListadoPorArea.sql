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
		DECLARE @ResponsableJerarquia varchar(50)
		DECLARE @ResponsableTipo varchar(50)

		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		-- Obtengo el Cargo y el Apellido y nombre del Responsable firmante
		SELECT @ResponsableIDPersona = r.IDPersona, @ResponsableApellidoNombre = p.ApellidoNombre, @ResponsableTipo = rt.Nombre
			FROM Responsable AS r
				INNER JOIN ResponsableTipo AS rt ON r.IDResponsableTipo = rt.IDResponsableTipo
				INNER JOIN Persona AS p ON r.IDPersona = p.IDPersona
			WHERE r.IDResponsable = @IDResponsable

		-- Obtengo la Jerarquía del Responsable
		SELECT @ResponsableJerarquia = cj.Nombre
			FROM PersonaAscenso AS pa
				INNER JOIN Cargo AS c ON pa.IDCargo = c.IDCargo
				INNER JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
			WHERE pa.IDPersona = @ResponsableIDPersona
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(@ResponsableIDPersona, GETDATE()))

		SELECT c.IDCompra, cu.Codigo AS CuartelCodigo, cu.Nombre AS CuartelNombre, c.Numero, c.Fecha, p.Nombre AS Proveedor, a.Nombre AS Area, cd.IDDetalle, cd.Detalle, c.FacturaNumero, SUM(cd.Importe) AS Importe, @ResponsableApellidoNombre AS FirmanteApellidoNombre, @ResponsableJerarquia AS FirmanteJerarquia, @ResponsableTipo AS FirmanteCargo
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