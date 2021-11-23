USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Creation date: 2021-11-23
-- Description:	Devuelve las personas activas para asistir a un siniestro
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'uspSiniestroObtenerPersonasParaAsistencia') AND type in (N'P', N'PC'))
	 DROP PROCEDURE uspSiniestroObtenerPersonasParaAsistencia
GO

CREATE PROCEDURE uspSiniestroObtenerPersonasParaAsistencia
	@IDSiniestro int,
	@Fecha date,
	@IDCuartel tinyint
	AS

	BEGIN

		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		-- Personas activas al momento del siniestro
		(SELECT p.IDPersona, p.ApellidoNombre
			FROM Persona AS p
				INNER JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
			WHERE p.EsActivo = 1
				AND p.IDCuartel = @IDCuartel
				AND pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, @Fecha)
				AND pab.Tipo = 'A')
		UNION
		-- Personas que ya están cargadas en el siniestro
		(SELECT p.IDPersona, p.ApellidoNombre
			FROM Persona AS p
				INNER JOIN SiniestroAsistencia AS sa ON p.IDPersona = sa.IDPersona
			WHERE sa.IDSiniestro = @IDSiniestro)
		ORDER BY ApellidoNombre
	END
GO