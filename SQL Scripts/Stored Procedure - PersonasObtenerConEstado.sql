USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-04-22
-- Updates: 2021-11-22 - Actualización para nuevo formato de Altas y Bajas
--			2021-11-23 - Se renombró de usp_Personas a uspPersonasObtenerConEstado
--			2022-07-17 - Se renombró de uspPersonasObtenerConEstado a PersonasObtenerConEstado
-- Description:	Devuelve las personas con su estado actual
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'PersonasObtenerConEstado') AND type in (N'P', N'PC'))
	 DROP PROCEDURE PersonasObtenerConEstado
GO

CREATE PROCEDURE PersonasObtenerConEstado
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT p.IDPersona, p.MatriculaNumero, p.ApellidoNombre, p.Apellido, p.Nombre, p.IDCuartel, c.Nombre AS CuartelNombre,
				dbo.PersonaObtenerEstado(pab.Tipo, pbm.Nombre) AS EstadoActual,
				dbo.PersonaObtenerIdBajaMotivo(pab.Tipo, pab.IDPersonaBajaMotivo) AS IDBajaMotivo
			FROM Persona AS p
				INNER JOIN Cuartel AS c ON p.IDCuartel = c.IDCuartel
				LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				LEFT JOIN PersonaBajaMotivo AS pbm ON pab.IDPersonaBajaMotivo = pbm.IDPersonaBajaMotivo
			WHERE (pab.IDAltaBaja IS NULL OR pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, NULL))
	END