USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-11-15
-- Description:	Devuelve los datos de la Persona y su cónyugue con sus Hijo a cargo
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_DatosConyugueEHijosACargo') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_DatosConyugueEHijosACargo
GO

CREATE PROCEDURE usp_Persona_DatosConyugueEHijosACargo
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@EstadoActivo bit,
	@IDPersonaBajaMotivo tinyint,
	@IDPersona int,
	@IOMAACargo bit
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT 'Lobos' AS Partido, 'Lobos' AS Ciudad, DAY(GETDATE()) AS FechaDia, FORMAT(GETDATE(), 'MMMM', 'es-es') AS FechaMes, YEAR(GETDATE()) AS FechaAnio, FORMAT(GETDATE(), 'yy') AS FechaAnioCorto, FORMAT(GETDATE(), 'dd/MM/yyyy') AS Fecha, Cuartel.Nombre AS CuartelNombre, Persona.IDPersona, Persona.MatriculaNumero, Persona.Genero, Persona.Apellido, Persona.Nombre, Persona.ApellidoNombre, Persona.Nombre + ' ' + Persona.Apellido AS NombreApellido, DocumentoTipo.Nombre AS DocumentoTipoNombre, Persona.DocumentoNumero, EstadoCivil.Nombre AS EstadoCivil, CONVERT(varchar(10), Persona.FechaNacimiento, 103) AS FechaNacimiento, CONVERT(varchar(10), Persona.FechaCasamiento, 103) AS FechaCasamiento, Persona.Profesion, Persona.Nacionalidad, Cargo.Nombre AS Cargo, CargoJerarquia.Nombre AS Jerarquia, (CASE ISNULL(PersonaAltaBaja.IDPersonaBajaMotivo, 0) WHEN 0 THEN 'Activo' ELSE PersonaBajaMotivo.Nombre END) AS Estado, Persona.DomicilioParticularCalle1, Persona.DomicilioParticularNumero, dbo.udf_GetDomicilioCalleCompleto(Persona.DomicilioParticularCalle1, Persona.DomicilioParticularNumero, Persona.DomicilioParticularPiso, Persona.DomicilioParticularDepartamento, Persona.DomicilioParticularCalle2, Persona.DomicilioParticularCalle3) AS Domicilio, Localidad.Nombre AS LocalidadNombre, Persona.IOMANumeroAfiliado, CONVERT(varchar(10), PersonaAltaBaja.AltaFecha, 103) AS AltaFecha, Conyugue.Apellido AS ConyugueApellido, Conyugue.Nombre AS ConyugueNombre, Conyugue.ApellidoNombre AS ConyugueApellidoNombre, Conyugue.Nombre + ' ' + Conyugue.Apellido AS ConyugueNombreApellido, dbo.udf_GetDomicilioCalleCompleto(Conyugue.DomicilioCalle1, Conyugue.DomicilioNumero, Conyugue.DomicilioPiso, Conyugue.DomicilioDepartamento, Conyugue.DomicilioCalle2, Conyugue.DomicilioCalle3) AS ConyugueDomicilio, Conyugue.IOMANumeroAfiliado AS ConyugueIOMANumeroAfiliado, CONVERT(varchar(10), Conyugue.FechaNacimiento, 103) AS ConyugueFechaNacimiento, ConyugueDocumentoTipo.Nombre AS ConyugueDocumentoTipoNombre, Conyugue.DocumentoNumero AS ConyugueDocumentoNumero, Conyugue.Notas AS ConyugueNotas, Hijo.Apellido AS HijoApellido, Hijo.Nombre AS HijoNombre, Hijo.ApellidoNombre AS HijoApellidoNombre, Hijo.Nombre + ' ' + Hijo.Apellido AS HijoNombreApellido, dbo.udf_GetDomicilioCalleCompleto(Hijo.DomicilioCalle1, Hijo.DomicilioNumero, Hijo.DomicilioPiso, Hijo.DomicilioDepartamento, Hijo.DomicilioCalle2, Hijo.DomicilioCalle3) AS HijoDomicilio, Hijo.IOMANumeroAfiliado AS HijoIOMANumeroAfiliado, CONVERT(varchar(10), Hijo.FechaNacimiento, 103) AS HijoFechaNacimiento, HijoDocumentoTipo.Nombre AS HijoDocumentoTipoNombre, Hijo.DocumentoNumero AS HijoDocumentoNumero, Hijo.Notas AS HijoNotas
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
				LEFT JOIN (SELECT * FROM PersonaFamiliar WHERE PersonaFamiliar.IDParentesco = 3 AND ((@IOMAACargo = 0 AND PersonaFamiliar.ACargo = 1) OR (@IOMAACargo = 1 AND PersonaFamiliar.IOMAACargo = 1))) AS Conyugue ON Persona.IDPersona = Conyugue.IDPersona)
				LEFT JOIN (SELECT * FROM PersonaFamiliar WHERE PersonaFamiliar.IDParentesco = 4 AND ((@IOMAACargo = 0 AND PersonaFamiliar.ACargo = 1) OR (@IOMAACargo = 1 AND PersonaFamiliar.IOMAACargo = 1))) AS Hijo ON Persona.IDPersona = Hijo.IDPersona)
				LEFT JOIN DocumentoTipo AS ConyugueDocumentoTipo ON Conyugue.IDDocumentoTipo = ConyugueDocumentoTipo.IDDocumentoTipo)
				LEFT JOIN DocumentoTipo AS HijoDocumentoTipo ON Hijo.IDDocumentoTipo = HijoDocumentoTipo.IDDocumentoTipo
			WHERE Persona.EsActivo = 1
				AND (Conyugue.ACargo IS NULL OR (@IOMAACargo = 0 AND Conyugue.ACargo = 1) OR (@IOMAACargo = 1 AND Conyugue.IOMAACargo = 1))
				AND (Hijo.ACargo IS NULL OR (@IOMAACargo = 0 AND Hijo.ACargo = 1) OR (@IOMAACargo = 1 AND Hijo.IOMAACargo = 1))
				AND (@IDPersona IS NULL OR Persona.IDPersona = @IDPersona)
				AND (@IDCuartel IS NULL OR Persona.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (PersonaAscenso.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR PersonaAscenso.IDJerarquia = @IDJerarquia)))
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, GETDATE()))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR (@EstadoActivo = 1 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NULL) OR (@EstadoActivo = 0 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NOT NULL))
				AND (@IDPersonaBajaMotivo IS NULL OR PersonaAltaBaja.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
			ORDER BY Persona.IDPersona, Hijo.FechaNacimiento
	END
GO