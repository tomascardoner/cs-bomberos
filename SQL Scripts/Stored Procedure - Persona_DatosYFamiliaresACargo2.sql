USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-09-01
-- Modifications: 2020-03-22 - se agregó el parámetro @FechaEmision e @Email
-- Description:	Devuelve los datos de la Persona con sus familiares a cargo
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_DatosYFamiliaresACargo2') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_DatosYFamiliaresACargo2
GO

CREATE PROCEDURE usp_Persona_DatosYFamiliaresACargo2
	@TipoAfiliadoDirecto bit,
	@TipoAfiliadoACargo bit,
	@TipoAlta bit,
	@TipoModificaciones bit,
	@TipoRenovaciones bit,
	@TipoContinuidad bit,
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@EstadoActivo bit,
	@IDPersonaBajaMotivo tinyint,
	@IDPersona int,
	@IDFamiliares varchar(1000),
	@FechaEmision date,
	@Email varchar(50),
	@IOMAACargo bit
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

		DECLARE @TableIDFamiliares TABLE (IDFamiliar tinyint not null)

		--PARSEO LAS PESADAS Y LAS GUARDO EN UNA TABLA LOCAL
		WHILE CHARINDEX(@Delimiter, @IDFamiliares, @SeparatorPos + 1) > 0
			BEGIN
				SET @ValueLenght = CHARINDEX(@Delimiter, @IDFamiliares, @SeparatorPos + 1) - @SeparatorPos
				SET @Value = SUBSTRING(@IDFamiliares, @SeparatorPos, @ValueLenght)
					
				--ID PERSONA
				INSERT INTO @TableIDFamiliares
					(IDFamiliar)
					VALUES (CAST(@Value AS int))
					
					SET @SeparatorPos = CHARINDEX(@Delimiter, @IDFamiliares, @SeparatorPos + @ValueLenght) + 1
			END

		SELECT 'SOCIEDAD DE BOMBEROS VOLUNTARIOS DE LOBOS' AS NombreEntidad, dbo.udf_BitAsXChar(@TipoAfiliadoDirecto) AS TipoAfiliadoDirecto, dbo.udf_BitAsXChar(@TipoAfiliadoACargo) AS TipoAfiliadoACargo, dbo.udf_BitAsXChar(@TipoAlta) AS TipoAlta, dbo.udf_BitAsXChar(@TipoModificaciones) AS TipoModificaciones, dbo.udf_BitAsXChar(@TipoRenovaciones) AS TipoRenovaciones, dbo.udf_BitAsXChar(@TipoContinuidad) AS TipoContinuidad, Persona.IDPersona, Persona.IOMANumeroAfiliado, Persona.ApellidoNombre,
			Persona.DomicilioParticularCalle1, Persona.DomicilioParticularNumero, Localidad.Nombre AS LocalidadNombre, Partido.Nombre AS PartidoNombre, Provincia.Nombre AS ProvinciaNombre, Persona.CelularParticular, @Email AS EmailEspecificado, Persona.EmailParticular, REPLACE(CONVERT(varchar(8), Persona.FechaNacimiento, 3), '/', '') AS FechaNacimiento, DocumentoTipo.Nombre AS DocumentoTipoNombre, Persona.DocumentoNumero, CONVERT(varchar(10), PersonaAltaBaja.AltaFecha, 103) AS FechaIngreso,
			dbo.udf_EqualValueAsXChar(Persona.IDEstadoCivil, 1) AS EstadoCivilSoltero, dbo.udf_EqualValueAsXChar(Persona.IDEstadoCivil, 2) AS EstadoCivilCasado, dbo.udf_EqualValueAsXChar(Persona.IDEstadoCivil, 3) AS EstadoCivilViudo, dbo.udf_EqualValueAsXChar(Persona.IDEstadoCivil, 4) AS EstadoCivilDivorciado, dbo.udf_EqualValueAsXChar(Persona.IDEstadoCivil, 5) AS EstadoCivilSeparacionLegal, dbo.udf_EqualValueAsXChar(Persona.IDEstadoCivil, 6) AS EstadoCivilSeparacionHecho,
			'Ameghino' AS DomicilioEntidadCalle, '160' AS DomicilioEntidadNumero, 'Lobos' AS LocalidadEntidad, 'Buenos Aires' AS ProvinciaEntidad, 'Lobos, ' + CONVERT(varchar(10), @FechaEmision, 103) AS LugarFecha, 
			PF.ApellidoNombre AS FamiliarApellidoNombre, dbo.udf_EqualValueAsXChar(PF.IDEstadoCivil, 1) AS FamiliarEstadoCivilSoltero, dbo.udf_EqualValueAsXChar(PF.IDEstadoCivil, 2) AS FamiliarEstadoCivilCasado, dbo.udf_EqualValueAsXChar(PF.IDEstadoCivil, 7) AS FamiliarEstadoCivilConviviente, dbo.udf_StringPadLeft(DAY(PF.FechaNacimiento), 2, '0') AS FamiliarFechaNacimientoDia, dbo.udf_StringPadLeft(MONTH(PF.FechaNacimiento), 2, '0') AS FamiliarFechaNacimientoMes, dbo.udf_StringPadLeft(YEAR(PF.FechaNacimiento) % 100, 2, '0') AS FamiliarFechaNacimientoAnio, FamiliarDocumentoTipo.Nombre AS FamiliarDocumentoTipoNombre, PF.DocumentoNumero AS FamiliarDocumentoNumero
			FROM (((((((((((((Persona INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				LEFT JOIN DocumentoTipo ON Persona.IDDocumentoTipo = DocumentoTipo.IDDocumentoTipo)
				LEFT JOIN EstadoCivil ON Persona.IDEstadoCivil = EstadoCivil.IDEstadoCivil)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
				LEFT JOIN PersonaBajaMotivo ON PersonaAltaBaja.IDPersonaBajaMotivo = PersonaBajaMotivo.IDPersonaBajaMotivo)
				LEFT JOIN Provincia ON Persona.DomicilioParticularIDProvincia = Provincia.IDProvincia)
				LEFT JOIN Localidad ON Persona.DomicilioParticularIDProvincia = Localidad.IDProvincia AND Persona.DomicilioParticularIDLocalidad = Localidad.IDLocalidad)
				LEFT JOIN Partido ON Localidad.IDPartido = Partido.IDPartido)
				LEFT JOIN (SELECT PersonaFamiliar.* FROM PersonaFamiliar LEFT JOIN @TableIDFamiliares AS tidf ON PersonaFamiliar.IDFamiliar = tidf.IDFamiliar WHERE (@IDFamiliares IS NULL OR tidf.IDFamiliar IS NOT NULL) AND ((@IOMAACargo = 0 AND PersonaFamiliar.ACargo = 1) OR (@IOMAACargo = 1 AND PersonaFamiliar.IOMAACargo = 1))) AS PF ON Persona.IDPersona = PF.IDPersona)
				LEFT JOIN Parentesco ON PF.IDParentesco = Parentesco.IDParentesco)
				LEFT JOIN DocumentoTipo AS FamiliarDocumentoTipo ON PF.IDDocumentoTipo = FamiliarDocumentoTipo.IDDocumentoTipo
			WHERE Persona.EsActivo = 1
				AND (PF.ACargo IS NULL OR (@IOMAACargo = 0 AND PF.ACargo = 1) OR (@IOMAACargo = 1 AND PF.IOMAACargo = 1))
				AND (@IDPersona IS NULL OR Persona.IDPersona = @IDPersona)
				AND (@IDCuartel IS NULL OR Persona.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (PersonaAscenso.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR PersonaAscenso.IDJerarquia = @IDJerarquia)))
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, GETDATE()))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR (@EstadoActivo = 1 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NULL) OR (@EstadoActivo = 0 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NOT NULL))
				AND (@IDPersonaBajaMotivo IS NULL OR PersonaAltaBaja.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
			ORDER BY Persona.IDPersona, PF.FechaNacimiento
	END
GO