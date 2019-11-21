USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-11-16
-- Description:	Devuelve los datos de la Persona y sus Hijos a cargo
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_DatosHijosACargo') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_DatosHijosACargo
GO

CREATE PROCEDURE usp_Persona_DatosHijosACargo
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

		SELECT 'Lobos' AS Partido, 'Lobos' AS Ciudad, DAY(GETDATE()) AS FechaDia, FORMAT(GETDATE(), 'MMMM', 'es-es') AS FechaMes, YEAR(GETDATE()) AS FechaAnio, FORMAT(GETDATE(), 'yy') AS FechaAnioCorto, FORMAT(GETDATE(), 'dd/MM/yyyy') AS Fecha, Cuartel.Nombre AS CuartelNombre, Persona.IDPersona, Persona.MatriculaNumero, Persona.Genero, Persona.Apellido, Persona.Nombre, Persona.ApellidoNombre, Persona.Nombre + ' ' + Persona.Apellido AS NombreApellido, DocumentoTipo.Nombre AS DocumentoTipoNombre, Persona.DocumentoNumero, EstadoCivil.Nombre AS EstadoCivil, CONVERT(varchar(10), Persona.FechaNacimiento, 103) AS FechaNacimiento, CONVERT(varchar(10), Persona.FechaCasamiento, 103) AS FechaCasamiento, Persona.Profesion, Persona.Nacionalidad, Cargo.Nombre AS Cargo, Cargo.Orden AS CargoOrden, CargoJerarquia.Nombre AS Jerarquia, CargoJerarquia.Orden AS JerarquiaOrden, (CASE ISNULL(PersonaAltaBaja.IDPersonaBajaMotivo, 0) WHEN 0 THEN 'Activo' ELSE PersonaBajaMotivo.Nombre END) AS Estado, Persona.DomicilioParticularCalle1, Persona.DomicilioParticularNumero, dbo.udf_GetDomicilioCalleCompleto(Persona.DomicilioParticularCalle1, Persona.DomicilioParticularNumero, Persona.DomicilioParticularPiso, Persona.DomicilioParticularDepartamento, Persona.DomicilioParticularCalle2, Persona.DomicilioParticularCalle3) AS Domicilio, Localidad.Nombre AS LocalidadNombre, Persona.IOMANumeroAfiliado, CONVERT(varchar(10), PersonaAltaBaja.AltaFecha, 103) AS AltaFecha, Hijo.Apellido AS HijoApellido, Hijo.Nombre AS HijoNombre, Hijo.ApellidoNombre AS HijoApellidoNombre, Hijo.Nombre + ' ' + Hijo.Apellido AS HijoNombreApellido, dbo.udf_GetDomicilioCalleCompleto(Hijo.DomicilioCalle1, Hijo.DomicilioNumero, Hijo.DomicilioPiso, Hijo.DomicilioDepartamento, Hijo.DomicilioCalle2, Hijo.DomicilioCalle3) AS HijoDomicilio, Hijo.IOMANumeroAfiliado AS HijoIOMANumeroAfiliado, Hijo.FechaNacimiento AS HijoFechaNacimiento, dbo.udf_GetElapsedCompleteYearsFromDates(Hijo.FechaNacimiento, GETDATE()) AS HijoEdad, HijoDocumentoTipo.Nombre AS HijoDocumentoTipoNombre, Hijo.DocumentoNumero AS HijoDocumentoNumero, Hijo.Notas AS HijoNotas
			FROM (((((((((((Persona INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				LEFT JOIN DocumentoTipo ON Persona.IDDocumentoTipo = DocumentoTipo.IDDocumentoTipo)
				LEFT JOIN EstadoCivil ON Persona.IDEstadoCivil = EstadoCivil.IDEstadoCivil)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
				LEFT JOIN PersonaBajaMotivo ON PersonaAltaBaja.IDPersonaBajaMotivo = PersonaBajaMotivo.IDPersonaBajaMotivo)
				LEFT JOIN Provincia ON Persona.DomicilioParticularIDProvincia = Provincia.IDProvincia)
				LEFT JOIN Localidad ON Persona.DomicilioParticularIDProvincia = Localidad.IDProvincia AND Persona.DomicilioParticularIDLocalidad = Localidad.IDLocalidad)
				INNER JOIN PersonaFamiliar AS Hijo ON Persona.IDPersona = Hijo.IDPersona)
				LEFT JOIN DocumentoTipo AS HijoDocumentoTipo ON Hijo.IDDocumentoTipo = HijoDocumentoTipo.IDDocumentoTipo
			WHERE Persona.EsActivo = 1
				AND Hijo.IDParentesco = 4
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