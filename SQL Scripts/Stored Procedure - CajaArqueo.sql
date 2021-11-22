USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Creation date: 2020-12-21
-- Updates: 2021-11-21 - Se hicieron los cambios para la nueva estructura de la tabla PersonaAltaBaja
-- Description:	Devuelve los datos para el Arqueo de Caja
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_CajaArqueo') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_CajaArqueo
GO

CREATE PROCEDURE usp_CajaArqueo
	@IDCaja tinyint,
	@IDArqueo int,
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

		SELECT ca.IDCaja, ca.IDArqueo, c.Nombre AS CajaNombre, ca.SaldoInicial, ca.ImporteAsignado, ca.FechaCierre, cad.IDDetalle, cad.NumeroComprobante, cad.Fecha,
				cad.Proveedor, cad.Detalle, cad.Importe, @ResponsableApellidoNombre AS FirmanteApellidoNombre, @ResponsableEstadoActivo AS FirmanteEstadoActivo,
				@ResponsableJerarquia AS FirmanteJerarquia, @ResponsableTipo AS FirmanteCargo
			FROM CajaArqueo AS ca
				INNER JOIN Caja AS c ON ca.IDCaja = c.IDCaja
				LEFT JOIN CajaArqueoDetalle AS cad ON ca.IDCaja = cad.IDCaja AND ca.IDArqueo = cad.IDArqueo
			WHERE ca.IDCaja = @IDCaja AND ca.IDArqueo = @IDArqueo
			ORDER BY cad.IDDetalle
	END
GO