USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-08-27
-- Updates: 2021-11-21 - Actualizado a las nuevas funciones y tablas
-- Description:	Devuelve los datos de las Personas indicadas
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_DatosMultiples') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_DatosMultiples
GO

CREATE PROCEDURE usp_Persona_DatosMultiples
	@IDPersonas varchar(1000)
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		DECLARE @Delimiter char = '@'

		DECLARE @SeparatorPos int = 0
		DECLARE @DelimiterPosStart int = 0
		DECLARE @DelimiterPosEnd int = 0
		DECLARE @ValueLenght int
		DECLARE @Value varchar(5)

		DECLARE @TableIDPersonas TABLE (IDPersona int not null)


		-- Parseo los ID de Personas y los guardo en una tabla local
		WHILE CHARINDEX(@Delimiter, @IDPersonas, @SeparatorPos + 1) > 0
			BEGIN
			SET @ValueLenght = CHARINDEX(@Delimiter, @IDPersonas, @SeparatorPos + 1) - @SeparatorPos
			SET @Value = SUBSTRING(@IDPersonas, @SeparatorPos, @ValueLenght)
					
			-- ID de persona
			INSERT INTO @TableIDPersonas
				(IDPersona)
				VALUES (CAST(@Value AS int))
					
				SET @SeparatorPos = CHARINDEX(@Delimiter, @IDPersonas, @SeparatorPos + @ValueLenght) + 1
			END

		SELECT 'LOBOS' AS Partido, 'LOBOS' AS Ciudad, p.IDPersona, p.MatriculaNumero, c.Nombre AS CuartelNombre, p.Genero,
				p.Apellido, p.Nombre, p.ApellidoNombre, dt.Nombre AS DocumentoTipoNombre, p.DocumentoNumero, p.FechaNacimiento, 
				dbo.PersonaObtenerEstado(pab.Tipo, pbm.Nombre) AS Estado,
				dbo.udf_GetDomicilioCalleCompleto(p.DomicilioParticularCalle1, p.DomicilioParticularNumero, p.DomicilioParticularPiso, p.DomicilioParticularDepartamento, p.DomicilioParticularCalle2, p.DomicilioParticularCalle3) AS Domicilio,
				l.Nombre AS LocalidadNombre, p.IOMATiene, p.IOMANumeroAfiliado, dbo.PersonaObtenerFechaUltimaAlta(p.IDPersona, NULL) AS AltaFecha
			FROM Persona AS p
				INNER JOIN Cuartel AS c ON p.IDCuartel = c.IDCuartel
				INNER JOIN @TableIDPersonas AS tidp ON p.IDPersona = tidp.IDPersona
				LEFT JOIN DocumentoTipo AS dt ON p.IDDocumentoTipo = dt.IDDocumentoTipo
				LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				LEFT JOIN PersonaBajaMotivo AS pbm ON pab.IDPersonaBajaMotivo = pbm.IDPersonaBajaMotivo
				LEFT JOIN Provincia AS pr ON p.DomicilioParticularIDProvincia = pr.IDProvincia
				LEFT JOIN Localidad AS l ON p.DomicilioParticularIDProvincia = l.IDProvincia AND p.DomicilioParticularIDLocalidad = l.IDLocalidad
			WHERE p.EsActivo = 1
				AND (pab.IDAltaBaja IS NULL OR pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, NULL))
	END
GO