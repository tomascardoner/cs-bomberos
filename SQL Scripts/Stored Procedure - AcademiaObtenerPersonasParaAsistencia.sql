USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author: Tomás A. Cardoner
-- Creation date: 2021-11-23
-- Modifications: 2022-07-16 - Se eliminaron los parámetros Fecha y IDCuartel. Se cambió el nombre.
-- Description:	Devuelve las personas activas para asistir a una academia.
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'AcademiaObtenerPersonasParaAsistencia') AND type in (N'P', N'PC'))
	 DROP PROCEDURE AcademiaObtenerPersonasParaAsistencia
GO

CREATE PROCEDURE AcademiaObtenerPersonasParaAsistencia
	@IDAcademia int
	AS

	BEGIN

		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		DECLARE @Fecha date
		DECLARE @IDCuartel tinyint

		SELECT @Fecha = Fecha, @IDCuartel = IDCuartel FROM Academia WHERE IDAcademia = @IDAcademia

		-- Personas activas al momento de la academia
		(SELECT p.IDPersona, p.ApellidoNombre
			FROM Persona AS p
				INNER JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
			WHERE p.EsActivo = 1
				AND p.IDCuartel = @IDCuartel
				AND pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, @Fecha)
				AND pab.Tipo = 'A')
		UNION
		-- Personas que ya están cargadas en la academia
		(SELECT p.IDPersona, p.ApellidoNombre
			FROM Persona AS p
				INNER JOIN AcademiaAsistencia AS aa ON p.IDPersona = aa.IDPersona
			WHERE aa.IDAcademia = @IDAcademia)
		ORDER BY ApellidoNombre
	END
GO