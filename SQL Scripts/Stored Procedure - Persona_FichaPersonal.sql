USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2016-12-31
-- Updates: 2021-11-21 - Actualizado a las nuevas funciones y tablas
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

		SELECT p.IDPersona, c.Nombre AS CuartelNombre, p.Genero, p.Apellido, p.Nombre, dt.Nombre AS DocumentoTipoNombre, p.DocumentoNumero, ec.Nombre AS EstadoCivil,
				p.CUIL, p.CelularParticular, l.Nombre AS Localidad, par.Nombre AS Partido, p.EmailParticular, ne.Nombre AS NivelEstudio, p.IOMATiene, p.IOMANumeroAfiliado,
				p.CursoIngresoFecha, p.CursoIngresoMeses,p.CursoIngresoHoras, cir.Apellido AS CursoIngresoResponsableApellido, cir.Nombre AS CursoIngresoResponsableNombre,
				p.ReingresoFormacionRealizada, p.ReingresoFormacionMeses, p.ReingresoFormacionHoras, rfr.Apellido AS ReingresoFormacionResponsableApellido, rfr.Nombre AS ReingresoFormacionResponsableNombre,
				pua.Fecha AS UltimaAltaFecha, pua.LibroNumero AS UltimaAltaLibroNumero, pua.FolioNumero AS UltimaAltaFolioNumero, pua.ActaNumero AS UltimaAltaActaNumero, dbo.udf_GetPersonaUltimaFechaBaja(p.IDPersona, GETDATE()) AS UltimaBajaFecha,
				pfp.Apellido AS PadreApellido, pfp.Nombre AS PadreNombre, pfm.Apellido AS MadreApellido, pfm.Nombre AS MadreNombre,
				p.Profesion, p.FechaNacimiento, p.Nacionalidad,
				dbo.udf_GetDomicilioCalleLocalidadCompleto(p.DomicilioParticularCalle1, p.DomicilioParticularNumero, p.DomicilioParticularPiso, p.DomicilioParticularDepartamento, p.DomicilioParticularCalle2, p.DomicilioParticularCalle3, p.DomicilioParticularIDProvincia, p.DomicilioParticularIDLocalidad) AS Domicilio
			FROM Persona AS p
				INNER JOIN Cuartel AS c ON p.IDCuartel = c.IDCuartel
				LEFT JOIN DocumentoTipo AS dt ON p.IDDocumentoTipo = dt.IDDocumentoTipo
				LEFT JOIN EstadoCivil AS ec ON p.IDEstadoCivil = ec.IDEstadoCivil
				LEFT JOIN Localidad AS l ON p.DomicilioParticularIDProvincia = l.IDProvincia AND p.DomicilioParticularIDLocalidad = l.IDLocalidad
				LEFT JOIN Partido AS par ON l.IDPartido = par.IDPartido
				LEFT JOIN NivelEstudio AS ne ON p.IDNivelEstudio = ne.IDNivelEstudio
				LEFT JOIN Persona AS cir ON p.CursoIngresoResponsableIDPersona = cir.IDPersona
				LEFT JOIN Persona AS rfr ON p.ReingresoFormacionResponsableIDPersona = rfr.IDPersona
				LEFT JOIN (SELECT IDPersona, Apellido, Nombre FROM PersonaFamiliar WHERE IDParentesco = @IDParentescoPadre) AS pfp ON p.IDPersona = pfp.IDPersona
				LEFT JOIN (SELECT IDPersona, Apellido, Nombre FROM PersonaFamiliar WHERE IDParentesco = @IDParentescoMadre) AS pfm ON p.IDPersona = pfm.IDPersona
				LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				LEFT JOIN PersonaAltaBaja AS pua ON p.IDPersona = pua.IDPersona
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
			WHERE p.EsActivo = 1
				AND (@IDPersona IS NULL OR p.IDPersona = @IDPersona)
				AND (@IDCuartel IS NULL OR p.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (pa.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR pa.IDJerarquia = @IDJerarquia)))
				AND (pab.Fecha IS NULL OR pab.IDAltaBaja = dbo.udf_GetPersonaIDUltimaAltaBaja(p.IDPersona, GETDATE()))
				AND (pua.Fecha IS NULL OR pua.IDAltaBaja = dbo.udf_GetPersonaIDUltimaAlta(p.IDPersona, GETDATE()))
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(p.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR (@EstadoActivo = 1 AND pab.IDPersonaBajaMotivo IS NULL) OR (@EstadoActivo = 0 AND pab.IDPersonaBajaMotivo IS NOT NULL))
				AND (@IDPersonaBajaMotivo IS NULL OR pab.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
	END
GO