USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-13
-- Description:	Devuelve los datos para la Foja de Servicio de un Bombero
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_FojaServicio') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_FojaServicio
GO

CREATE PROCEDURE usp_Persona_FojaServicio
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

		SELECT Persona.IDPersona, Cuartel.Nombre AS CuartelNombre, Persona.MatriculaNumero, Persona.Genero, Persona.Apellido, Persona.Nombre, DocumentoTipo.Nombre AS DocumentoTipoNombre, Persona.DocumentoNumero, Persona.FechaNacimiento, dbo.udf_GetPersonaPrimerFechaAlta(Persona.IDPersona) AS FechaIngreso, CargoJerarquia.Nombre AS Jerarquia, (CASE ISNULL(PersonaAltaBaja.IDPersonaBajaMotivo, 0) WHEN 0 THEN 'Activo' ELSE PersonaBajaMotivo.Nombre END) AS EstadoActual, dbo.udf_GetDomicilioCalleLocalidadCompleto(Persona.DomicilioParticularCalle1, Persona.DomicilioParticularNumero, Persona.DomicilioParticularPiso, Persona.DomicilioParticularDepartamento, Persona.DomicilioParticularCalle2, Persona.DomicilioParticularCalle3, Persona.DomicilioParticularIDProvincia, Persona.DomicilioParticularIDLocalidad) AS Domicilio
			FROM ((((((Persona INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				LEFT JOIN DocumentoTipo ON Persona.IDDocumentoTipo = DocumentoTipo.IDDocumentoTipo)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
				LEFT JOIN PersonaBajaMotivo ON PersonaAltaBaja.IDPersonaBajaMotivo = PersonaBajaMotivo.IDPersonaBajaMotivo
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