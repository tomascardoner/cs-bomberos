USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2022-04-25
-- Description:	Devuelve los datos para el resumen de cuenta de Entidades
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'EntidadObtenerComprobantes') AND type in (N'P', N'PC'))
	 DROP PROCEDURE EntidadObtenerComprobantes
GO

CREATE PROCEDURE EntidadObtenerComprobantes
	@IDEntidad int,
	@FechaDesde date,
    @FechaHasta date
	AS

	BEGIN
		DECLARE @resultado TABLE (IDComprobante int NOT NULL PRIMARY KEY, Fecha date NULL, Numero varchar(18) NULL, ImporteDebe money NOT NULL, ImporteHaber money NOT NULL, Importe money NOT NULL)

		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;
		
		-- Si corresponde, agrego el saldo anterior a la tabla temporaria
		IF @FechaDesde IS NOT NULL
			INSERT INTO @resultado
				(IDComprobante, Fecha, Numero, ImporteDebe, ImporteHaber, Importe)
				VALUES (0, NULL, 'Saldo anterior:', 0, 0,
					(SELECT ISNULL(SUM(CASE ct.MovimientoTipo WHEN 'C' THEN c.Importe ELSE c.Importe * -1 END), 0)
						FROM Entidad AS e
							INNER JOIN Comprobante AS c ON e.IDEntidad = c.IDEntidad
							INNER JOIN ComprobanteTipo AS ct ON c.IDComprobanteTipo = ct.IDComprobanteTipo
						WHERE e.IDEntidad = @IDEntidad
							AND c.FechaHoraAnulacion IS NULL
							AND c.Fecha < @FechaDesde))

		-- Agrego los comprobantes a la tabla temporaria
		INSERT INTO @resultado
			(IDComprobante, Fecha, Numero, ImporteDebe, ImporteHaber, Importe)
			SELECT c.IDComprobante, c.Fecha, RTRIM(ct.Sigla) + '-' + c.NumeroCompleto AS Numero,
				(CASE ct.MovimientoTipo WHEN 'D' THEN c.Importe ELSE 0 END) AS ImporteDebe,
				(CASE ct.MovimientoTipo WHEN 'C' THEN c.Importe ELSE 0 END) AS ImporteHaber,
				(CASE ct.MovimientoTipo WHEN 'C' THEN c.Importe ELSE c.Importe * -1 END) AS Importe
				FROM Entidad AS e
					INNER JOIN Comprobante AS c ON e.IDEntidad = c.IDEntidad
					INNER JOIN ComprobanteTipo AS ct ON c.IDComprobanteTipo = ct.IDComprobanteTipo
				WHERE e.IDEntidad = @IDEntidad
					AND c.FechaHoraAnulacion IS NULL
					AND (@FechaDesde IS NULL OR c.Fecha >= @FechaDesde)
					AND (@FechaHasta IS NULL OR c.Fecha <= @FechaHasta)
				ORDER BY Fecha, IDComprobante
	
		-- Muestro el resultado
		SELECT r.IDComprobante, e.Nombre, e.DomicilioCalleCompleto, dbo.udf_GetCodigoPostalLocalidad(e.DomicilioCodigoPostal, e.DomicilioIDProvincia, e.DomicilioIDLocalidad) AS DomicilioLocalidadCompleto,
				r.Fecha, r.Numero, r.ImporteDebe, r.ImporteHaber, r.Importe,
				SUM(r.Importe) OVER (ORDER BY r.Fecha, r.IDComprobante) AS ImporteAcumulado
			FROM @resultado AS r, Entidad AS e
			WHERE e.IDEntidad = @IDEntidad
			ORDER BY r.Fecha, r.IDComprobante
	END
GO