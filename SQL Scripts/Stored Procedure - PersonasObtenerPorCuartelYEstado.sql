USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2022-09-06
-- Description:	Devuelve las personas de un cuartel (o no) con estado activo (o no)
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'PersonasObtenerPorCuartelYEstado') AND type in (N'P', N'PC'))
	 DROP PROCEDURE PersonasObtenerPorCuartelYEstado
GO

CREATE PROCEDURE PersonasObtenerPorCuartelYEstado
	@IDCuartel tinyint,
	@SoloEstadoActivo bit
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT p.IDPersona, p.MatriculaNumero, p.ApellidoNombre, p.Apellido, p.Nombre, p.IDCuartel, c.Nombre AS CuartelNombre,
				dbo.PersonaObtenerIdBajaMotivo(pab.Tipo, pab.IDPersonaBajaMotivo) AS IDBajaMotivo
			FROM Persona AS p
				INNER JOIN Cuartel AS c ON p.IDCuartel = c.IDCuartel
				LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
			WHERE p.EsActivo = 1
				AND (@IDCuartel IS NULL OR p.IDCuartel = @IDCuartel)
				AND (pab.IDAltaBaja IS NULL OR (pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, NULL) AND (@SoloEstadoActivo = 0 OR pab.Tipo = 'A')))
	END