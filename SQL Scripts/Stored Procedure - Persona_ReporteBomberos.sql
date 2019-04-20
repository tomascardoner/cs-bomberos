USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-18
-- Description:	Devuelve los datos para la Planilla de Excel del Reporte de Bomberos
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_ReporteBomberos') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_ReporteBomberos
GO

CREATE PROCEDURE usp_Persona_ReporteBomberos
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@EstadoActivo bit,
	@IDPersonaBajaMotivo tinyint,
	@IDPersona int
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		-- ORDENO LAS PERSONAS - START
		CREATE TABLE #PersonaOrden
			(IDPersona int NOT NULL, Orden smallint NOT NULL,
				CONSTRAINT PK__PersonaOrden PRIMARY KEY CLUSTERED 
					(IDPersona ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
			)
		EXEC dbo.usp_FillPersonaOrderTable
		-- ORDENO LAS PERSONAS - END

		SELECT Persona.IDPersona, Persona.Apellido, Persona.Nombre, DocumentoTipo.Nombre AS DocumentoTipoNombre, Persona.DocumentoNumero, Persona.FechaNacimiento, Persona.MatriculaNumero, Persona.Altura, Persona.Peso, Persona.Genero, Provincia.Nombre AS ProvinciaNombre, Localidad.Nombre AS LocalidadNombre, dbo.udf_GetDomicilioCalleCompleto(Persona.DomicilioParticularCalle1, Persona.DomicilioParticularNumero, Persona.DomicilioParticularPiso, Persona.DomicilioParticularDepartamento, Persona.DomicilioParticularCalle2, Persona.DomicilioParticularCalle3) AS Domicilio, Persona.EmailParticular, Persona.CelularParticular, Persona.GrupoSanguineo, Persona.FactorRH, 'CFBVRA' AS Organizacion, 'Bombero' AS Formacion, Cargo.Nombre AS Cargo, CargoJerarquia.Nombre AS Jerarquia, NivelEstudio.Nombre AS NivelEstudioNombre, (CASE ISNULL(PersonaAltaBaja.IDPersonaBajaMotivo, 0) WHEN 0 THEN 'Activo' ELSE PersonaBajaMotivo.Nombre END) AS Estado, (CASE ISNULL(PersonaAltaBaja.BajaFecha, '') WHEN '' THEN PersonaAltaBaja.AltaFecha ELSE PersonaAltaBaja.BajaFecha END) AS FechaEstado, #PersonaOrden.Orden
			FROM (((((((((Persona INNER JOIN #PersonaOrden ON Persona.IDPersona = #PersonaOrden.IDPersona)
				LEFT JOIN DocumentoTipo ON Persona.IDDocumentoTipo = DocumentoTipo.IDDocumentoTipo)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
				LEFT JOIN PersonaBajaMotivo ON PersonaAltaBaja.IDPersonaBajaMotivo = PersonaBajaMotivo.IDPersonaBajaMotivo)
				LEFT JOIN Provincia ON Persona.DomicilioParticularIDProvincia = Provincia.IDProvincia)
				LEFT JOIN Localidad ON Persona.DomicilioParticularIDProvincia = Localidad.IDProvincia AND Persona.DomicilioLaboralIDLocalidad = Localidad.IDLocalidad)
				LEFT JOIN NivelEstudio ON Persona.IDNivelEstudio = NivelEstudio.IDNivelEstudio
			WHERE Persona.EsActivo = 1
				AND (@IDPersona IS NULL OR Persona.IDPersona = @IDPersona)
				AND (@IDCuartel IS NULL OR Persona.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (PersonaAscenso.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR PersonaAscenso.IDJerarquia = @IDJerarquia)))
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, GETDATE()))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR (@EstadoActivo = 1 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NULL) OR (@EstadoActivo = 0 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NOT NULL))
				AND (@IDPersonaBajaMotivo IS NULL OR PersonaAltaBaja.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
	END
GO