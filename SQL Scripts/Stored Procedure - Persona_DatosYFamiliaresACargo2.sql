USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-09-01
-- Updates: 2020-03-22 - se agregó el parámetro @FechaEmision e @Email
--			2021-11-21 - Actualizado a las nuevas funciones y tablas
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

		-- Parseo los ID de familiares y los guardo en una tabla local
		WHILE CHARINDEX(@Delimiter, @IDFamiliares, @SeparatorPos + 1) > 0
			BEGIN
			SET @ValueLenght = CHARINDEX(@Delimiter, @IDFamiliares, @SeparatorPos + 1) - @SeparatorPos
			SET @Value = SUBSTRING(@IDFamiliares, @SeparatorPos, @ValueLenght)
					
			-- ID Familiar
			INSERT INTO @TableIDFamiliares
				(IDFamiliar)
				VALUES (CAST(@Value AS int))
					
				SET @SeparatorPos = CHARINDEX(@Delimiter, @IDFamiliares, @SeparatorPos + @ValueLenght) + 1
			END

		SELECT 'SOCIEDAD DE BOMBEROS VOLUNTARIOS DE LOBOS' AS NombreEntidad, dbo.udf_BitAsXChar(@TipoAfiliadoDirecto) AS TipoAfiliadoDirecto,
				dbo.udf_BitAsXChar(@TipoAfiliadoACargo) AS TipoAfiliadoACargo, dbo.udf_BitAsXChar(@TipoAlta) AS TipoAlta, dbo.udf_BitAsXChar(@TipoModificaciones) AS TipoModificaciones,
				dbo.udf_BitAsXChar(@TipoRenovaciones) AS TipoRenovaciones, dbo.udf_BitAsXChar(@TipoContinuidad) AS TipoContinuidad, p.IDPersona, p.IOMANumeroAfiliado,
				p.ApellidoNombre, p.DomicilioParticularCalle1, p.DomicilioParticularNumero, l.Nombre AS LocalidadNombre, par.Nombre AS PartidoNombre,
				pr.Nombre AS ProvinciaNombre, p.CelularParticular, @Email AS EmailEspecificado, p.EmailParticular, REPLACE(CONVERT(varchar(8), p.FechaNacimiento, 3), '/', '') AS FechaNacimiento,
				dt.Nombre AS DocumentoTipoNombre, p.DocumentoNumero, CONVERT(varchar(10), dbo.udf_GetPersonaUltimaFechaAlta(p.IDPersona, NULL), 103) AS FechaIngreso,
				dbo.udf_EqualIntegerValuesAsXChar(p.IDEstadoCivil, 1) AS EstadoCivilSoltero, dbo.udf_EqualIntegerValuesAsXChar(p.IDEstadoCivil, 2) AS EstadoCivilCasado,
				dbo.udf_EqualIntegerValuesAsXChar(p.IDEstadoCivil, 3) AS EstadoCivilViudo, dbo.udf_EqualIntegerValuesAsXChar(p.IDEstadoCivil, 4) AS EstadoCivilDivorciado,
				dbo.udf_EqualIntegerValuesAsXChar(p.IDEstadoCivil, 5) AS EstadoCivilSeparacionLegal, dbo.udf_EqualIntegerValuesAsXChar(p.IDEstadoCivil, 6) AS EstadoCivilSeparacionHecho,
				'Ameghino' AS DomicilioEntidadCalle, '160' AS DomicilioEntidadNumero, 'Lobos' AS LocalidadEntidad, 'Buenos Aires' AS ProvinciaEntidad,
				'Lobos, ' + CONVERT(varchar(10), @FechaEmision, 103) AS LugarFecha, 
				pf.ApellidoNombre AS FamiliarApellidoNombre, dbo.udf_EqualIntegerValuesAsXChar(pf.IDEstadoCivil, 1) AS FamiliarEstadoCivilSoltero,
				dbo.udf_EqualIntegerValuesAsXChar(pf.IDEstadoCivil, 2) AS FamiliarEstadoCivilCasado, dbo.udf_EqualIntegerValuesAsXChar(pf.IDEstadoCivil, 7) AS FamiliarEstadoCivilConviviente,
				dbo.udf_StringPadLeft(DAY(pf.FechaNacimiento), 2, '0') AS FamiliarFechaNacimientoDia, dbo.udf_StringPadLeft(MONTH(pf.FechaNacimiento), 2, '0') AS FamiliarFechaNacimientoMes, dbo.udf_StringPadLeft(YEAR(pf.FechaNacimiento) % 100, 2, '0') AS FamiliarFechaNacimientoAnio,
				fdt.Nombre AS FamiliarDocumentoTipoNombre, pf.DocumentoNumero AS FamiliarDocumentoNumero
			FROM Persona AS p
				INNER JOIN Cuartel AS c ON p.IDCuartel = c.IDCuartel
				LEFT JOIN DocumentoTipo AS dt ON p.IDDocumentoTipo = dt.IDDocumentoTipo
				LEFT JOIN EstadoCivil AS ec ON p.IDEstadoCivil = ec.IDEstadoCivil
				LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
				LEFT JOIN Cargo AS ca ON pa.IDCargo = ca.IDCargo
				LEFT JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
				LEFT JOIN PersonaBajaMotivo AS pbm ON pab.IDPersonaBajaMotivo = pbm.IDPersonaBajaMotivo
				LEFT JOIN Provincia AS pr ON p.DomicilioParticularIDProvincia = pr.IDProvincia
				LEFT JOIN Localidad AS l ON p.DomicilioParticularIDProvincia = l.IDProvincia AND p.DomicilioParticularIDLocalidad = l.IDLocalidad
				LEFT JOIN Partido AS par ON l.IDPartido = par.IDPartido
				LEFT JOIN (SELECT PersonaFamiliar.*
							FROM PersonaFamiliar
								LEFT JOIN @TableIDFamiliares AS tidf ON PersonaFamiliar.IDFamiliar = tidf.IDFamiliar
							WHERE (@IDFamiliares IS NULL OR tidf.IDFamiliar IS NOT NULL)
								AND ((@IOMAACargo = 0 AND PersonaFamiliar.ACargo = 1) OR (@IOMAACargo = 1 AND PersonaFamiliar.IOMAACargo = 1))) AS pf ON p.IDPersona = pf.IDPersona
				LEFT JOIN Parentesco AS pare ON pf.IDParentesco = pare.IDParentesco
				LEFT JOIN DocumentoTipo AS fdt ON pf.IDDocumentoTipo = fdt.IDDocumentoTipo
			WHERE p.EsActivo = 1
				AND (pf.IDParentesco IS NULL OR pf.IDParentesco < 254)
				AND (pf.ACargo IS NULL OR (@IOMAACargo = 0 AND pf.ACargo = 1) OR (@IOMAACargo = 1 AND pf.IOMAACargo = 1))
				AND (@IDPersona IS NULL OR p.IDPersona = @IDPersona)
				AND (@IDCuartel IS NULL OR p.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (pa.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR pa.IDJerarquia = @IDJerarquia)))
				AND (pab.IDAltaBaja IS NULL OR pab.IDAltaBaja = dbo.udf_GetPersonaIDUltimaAltaBaja(p.IDPersona, GETDATE()))
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(p.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR dbo.udf_GetPersonaEstadoActivo(pab.Tipo) = @EstadoActivo)
				AND (@IDPersonaBajaMotivo IS NULL OR pab.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
			ORDER BY p.IDPersona, pf.FechaNacimiento
	END
GO