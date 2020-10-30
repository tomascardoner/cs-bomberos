USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2016-12-31
-- Description:	Devuelve los datos para la ficha de un Bombero
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_FichaPersonal') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_FichaPersonal
GO

CREATE PROCEDURE usp_Persona_FichaPersonal
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@EstadoActivo bit,
	@IDPersonaBajaMotivo tinyint,
	@IDPersona int
	AS

	BEGIN
		DECLARE @IDParentescoPadre tinyint
		DECLARE @IDParentescoMadre tinyint

		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SET @IDParentescoPadre = dbo.udf_GetParametro_NumeroEntero('PARENTESCO_ID_PADRE')
		SET	@IDParentescoMadre = dbo.udf_GetParametro_NumeroEntero('PARENTESCO_ID_MADRE')

		SELECT Persona.IDPersona, Cuartel.Nombre AS CuartelNombre, Persona.Genero, Persona.Apellido, Persona.Nombre, DocumentoTipo.Nombre AS DocumentoTipoNombre, Persona.DocumentoNumero, EstadoCivil.Nombre AS EstadoCivil, Persona.CUIL, Persona.CelularParticular, Localidad.Nombre AS Localidad, Partido.Nombre AS Partido, Persona.EmailParticular, NivelEstudio.Nombre AS NivelEstudio, Persona.IOMATiene, Persona.IOMANumeroAfiliado, Persona.CursoIngresoFecha, Persona.CursoIngresoMeses,Persona.CursoIngresoHoras, CursoIngresoResponsable.Apellido AS CursoIngresoResponsableApellido, CursoIngresoResponsable.Nombre AS CursoIngresoResponsableNombre, PersonaAltaBaja.AltaFecha, PersonaAltaBaja.AltaLibroNumero, PersonaAltaBaja.AltaFolioNumero, PersonaAltaBaja.AltaActaNumero, PersonaFamiliarPadre.Apellido AS PadreApellido, PersonaFamiliarPadre.Nombre AS PadreNombre, PersonaFamiliarMadre.Apellido AS MadreApellido, PersonaFamiliarMadre.Nombre AS MadreNombre, Persona.Profesion, Persona.FechaNacimiento, Persona.Nacionalidad, dbo.udf_GetDomicilioCalleLocalidadCompleto(Persona.DomicilioParticularCalle1, Persona.DomicilioParticularNumero, Persona.DomicilioParticularPiso, Persona.DomicilioParticularDepartamento, Persona.DomicilioParticularCalle2, Persona.DomicilioParticularCalle3, Persona.DomicilioParticularIDProvincia, Persona.DomicilioParticularIDLocalidad) AS Domicilio
			FROM ((((((((((Persona INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				LEFT JOIN DocumentoTipo ON Persona.IDDocumentoTipo = DocumentoTipo.IDDocumentoTipo)
				LEFT JOIN EstadoCivil ON Persona.IDEstadoCivil = EstadoCivil.IDEstadoCivil)
				LEFT JOIN Localidad ON Persona.DomicilioParticularIDProvincia = Localidad.IDProvincia AND Persona.DomicilioParticularIDLocalidad = Localidad.IDLocalidad)
				LEFT JOIN Partido ON Localidad.IDPartido = Partido.IDPartido)
				LEFT JOIN NivelEstudio ON Persona.IDNivelEstudio = NivelEstudio.IDNivelEstudio)
				LEFT JOIN Persona AS CursoIngresoResponsable ON Persona.CursoIngresoResponsableIDPersona = CursoIngresoResponsable.IDPersona)
				LEFT JOIN (SELECT IDPersona, Apellido, Nombre FROM PersonaFamiliar WHERE IDParentesco = @IDParentescoPadre) AS PersonaFamiliarPadre ON Persona.IDPersona = PersonaFamiliarPadre.IDPersona)
				LEFT JOIN (SELECT IDPersona, Apellido, Nombre FROM PersonaFamiliar WHERE IDParentesco = @IDParentescoMadre) AS PersonaFamiliarMadre ON Persona.IDPersona = PersonaFamiliarMadre.IDPersona)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona
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