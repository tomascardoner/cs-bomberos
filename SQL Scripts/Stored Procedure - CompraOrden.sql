USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Creation date: 2020-11-11
-- Updates: 2021-11-21 - Actualizado a las nuevas funciones y tablas
--			2022-02-12 - Actualizado a las nuevas tablas
-- Description:	Devuelve los datos para la Orden de Compra
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'CompraObtenerOrden') AND type in (N'P', N'PC'))
	 DROP PROCEDURE CompraObtenerOrden
GO

CREATE PROCEDURE CompraObtenerOrden
	@IDCompraOrden int,
	@IDResponsableTipo tinyint
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
			WHERE r.IDResponsableTipo = @IDResponsableTipo

		-- Obtengo el Estado actual del Responsable
		IF @ResponsableIDPersona IS NULL
			SET @ResponsableEstadoActivo = 0
		ELSE
			SELECT @ResponsableEstadoActivo = dbo.PersonaObtenerSiEstadoEsActivo(pab.Tipo)
				FROM Persona AS p
					LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				WHERE p.IDPersona = @ResponsableIDPersona
					AND pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(@ResponsableIDPersona, GETDATE())

		-- Obtengo la Jerarquía del Responsable
		IF @ResponsableIDPersona IS NULL
			SET @ResponsableJerarquia = NULL
		ELSE
			SELECT @ResponsableJerarquia = cj.Nombre
				FROM PersonaAscenso AS pa
					INNER JOIN Cargo AS c ON pa.IDCargo = c.IDCargo
					INNER JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
				WHERE pa.IDPersona = @ResponsableIDPersona
					AND pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(@ResponsableIDPersona, GETDATE())

		-- Traigo los datos correspondientes
		SELECT co.IDCompraOrden, cu.Codigo AS CuartelCodigo, cu.Nombre AS CuartelNombre, co.Numero, co.Fecha, e.Nombre AS Proveedor, a.Nombre AS Area, cod.IDDetalle, cod.Detalle, cm.NumeroCompleto AS FacturaNumero, SUM(cod.Importe) AS Importe, @ResponsableApellidoNombre AS FirmanteApellidoNombre, @ResponsableEstadoActivo AS FirmanteEstadoActivo, @ResponsableJerarquia AS FirmanteJerarquia, @ResponsableTipo AS FirmanteCargo
			FROM CompraOrden AS co
				INNER JOIN Cuartel AS cu ON co.IDCuartel = cu.IDCuartel
				LEFT JOIN CompraOrdenDetalle AS cod ON co.IDCompraOrden = cod.IDCompraOrden
				LEFT JOIN Comprobante AS cm ON cod.IDComprobante = cm.IDComprobante
				LEFT JOIN Area AS a ON cod.IDArea = a.IDArea
				LEFT JOIN Entidad AS e ON co.IDEntidad = e.IDEntidad
			WHERE co.IDCompraOrden = @IDCompraOrden
			GROUP BY co.IDCompraOrden, cu.Codigo, cu.Nombre, co.Numero, co.Fecha, e.Nombre, a.Nombre, cod.IDDetalle, cod.Detalle, cm.NumeroCompleto
			ORDER BY cod.IDDetalle
	END
GO