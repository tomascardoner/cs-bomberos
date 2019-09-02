USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-08-27
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


		--PARSEO LAS PESADAS Y LAS GUARDO EN UNA TABLA LOCAL
		WHILE CHARINDEX(@Delimiter, @IDPersonas, @SeparatorPos + 1) > 0
			BEGIN
				SET @ValueLenght = CHARINDEX(@Delimiter, @IDPersonas, @SeparatorPos + 1) - @SeparatorPos
				SET @Value = SUBSTRING(@IDPersonas, @SeparatorPos, @ValueLenght)
					
				--ID PERSONA
				INSERT INTO @TableIDPersonas
					(IDPersona)
					VALUES (CAST(@Value AS int))
					
					SET @SeparatorPos = CHARINDEX(@Delimiter, @IDPersonas, @SeparatorPos + @ValueLenght) + 1
			END

		SELECT 'LOBOS' AS Partido, 'LOBOS' AS Ciudad, Persona.IDPersona, Persona.MatriculaNumero, Cuartel.Nombre AS CuartelNombre, Persona.Genero, Persona.Apellido, Persona.Nombre, Persona.ApellidoNombre, DocumentoTipo.Nombre AS DocumentoTipoNombre, Persona.DocumentoNumero, Persona.FechaNacimiento, (CASE ISNULL(PersonaAltaBaja.IDPersonaBajaMotivo, 0) WHEN 0 THEN 'Activo' ELSE PersonaBajaMotivo.Nombre END) AS Estado, dbo.udf_GetDomicilioCalleCompleto(Persona.DomicilioParticularCalle1, Persona.DomicilioParticularNumero, Persona.DomicilioParticularPiso, Persona.DomicilioParticularDepartamento, Persona.DomicilioParticularCalle2, Persona.DomicilioParticularCalle3) AS Domicilio, Localidad.Nombre AS LocalidadNombre, Persona.IOMATiene, Persona.IOMANumeroAfiliado, PersonaAltaBaja.AltaFecha
			FROM ((((((Persona INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				INNER JOIN @TableIDPersonas AS tidp ON Persona.IDPersona = tidp.IDPersona)
				LEFT JOIN DocumentoTipo ON Persona.IDDocumentoTipo = DocumentoTipo.IDDocumentoTipo)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaBajaMotivo ON PersonaAltaBaja.IDPersonaBajaMotivo = PersonaBajaMotivo.IDPersonaBajaMotivo)
				LEFT JOIN Provincia ON Persona.DomicilioParticularIDProvincia = Provincia.IDProvincia)
				LEFT JOIN Localidad ON Persona.DomicilioParticularIDProvincia = Localidad.IDProvincia AND Persona.DomicilioParticularIDLocalidad = Localidad.IDLocalidad
			WHERE Persona.EsActivo = 1
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, GETDATE()))
	END
GO