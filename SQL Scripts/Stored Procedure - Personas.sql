USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-04-22
-- Description:	Devuelve las Personas
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Personas') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Personas
GO

CREATE PROCEDURE usp_Personas
	@EstadoDesconocidoLeyenda varchar(50),
	@EstadoActivoLeyenda varchar(50)
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT p.IDPersona, p.MatriculaNumero, p.ApellidoNombre, p.Apellido, p.Nombre, p.IDCuartel, c.Nombre AS CuartelNombre, (CASE ISNULL(pab.IDAltaBaja, 0) WHEN 0 THEN @EstadoDesconocidoLeyenda ELSE (CASE ISNULL(pab.BajaFecha, '') WHEN '' THEN @EstadoActivoLeyenda ELSE pbm.Nombre END) END) AS EstadoActual, (CASE ISNULL(pab.IDAltaBaja, 0) WHEN 0 THEN NULL ELSE (CASE ISNULL(pab.BajaFecha, '') WHEN '' THEN 0 ELSE pbm.IDPersonaBajaMotivo END) END) AS IDBajaMotivo
			FROM ((Persona AS p INNER JOIN Cuartel AS c ON p.IDCuartel = c.IDCuartel)
			LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona)
			LEFT JOIN PersonaBajaMotivo AS pbm ON pab.IDPersonaBajaMotivo = pbm.IDPersonaBajaMotivo
			WHERE pab.AltaFecha IS NULL OR pab.AltaFecha = (SELECT MAX(AltaFecha) FROM PersonaAltaBaja WHERE IDPersona = pab.IDPersona GROUP BY IDPersona)
	END