USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-04-17
-- Modification:
--				- 2021-06-06 se abrió el stored procedure en 2 para lus subreportes de familiares
-- Description:	Devuelve los datos para la ficha de actualización de un Bombero
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'uspPersonaActualizacionDatos') AND type in (N'P', N'PC'))
	 DROP PROCEDURE uspPersonaActualizacionDatos
GO

CREATE PROCEDURE uspPersonaActualizacionDatos
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

		SELECT p.IDPersona, p.MatriculaNumero, p.Apellido, p.Nombre, p.ApellidoNombre, dt.Nombre AS DocumentoTipo, p.DocumentoNumero, p.CUIL, p.FechaNacimiento, p.Genero, p.Altura, p.Peso, p.GrupoSanguineo, p.FactorRH, ec.Nombre AS EstadoCivil, p.FechaCasamiento,
			p.IOMATiene, p.IOMANumeroAfiliado, p.IOMAVencimientoCredencial,
			ne.Nombre AS NivelEstudio, p.TituloObtenido, p.Profesion, p.Nacionalidad, c.Nombre AS Cuartel,
			dbo.udf_GetDomicilioCalleCompleto(p.DomicilioParticularCalle1, p.DomicilioParticularNumero, p.DomicilioParticularPiso, p.DomicilioParticularDepartamento, p.DomicilioParticularCalle2, p.DomicilioParticularCalle3) AS DomicilioParticular, lp.Nombre AS LocalidadParticular,
			p.TelefonoParticular, p.CelularParticular, p.EmailParticular,
			dbo.udf_GetDomicilioCalleCompleto(p.DomicilioLaboralCalle1, p.DomicilioLaboralNumero, p.DomicilioLaboralPiso, p.DomicilioLaboralDepartamento, p.DomicilioLaboralCalle2, p.DomicilioLaboralCalle3) AS DomicilioLaboral, ll.Nombre AS LocalidadLaboral,
			p.TelefonoLaboral, p.CelularLaboral, p.EmailLaboral,
			pab.Fecha, p.LicenciaConducirNumero, p.LicenciaConducirVencimiento
			FROM (((((((Persona AS p
				INNER JOIN Cuartel AS c ON p.IDCuartel = c.IDCuartel)
				LEFT JOIN DocumentoTipo AS dt ON p.IDDocumentoTipo = dt.IDDocumentoTipo)
				LEFT JOIN EstadoCivil AS ec ON p.IDEstadoCivil = ec.IDEstadoCivil)
				LEFT JOIN Localidad AS lp ON p.DomicilioParticularIDProvincia = lp.IDProvincia AND p.DomicilioParticularIDLocalidad = lp.IDLocalidad)
				LEFT JOIN Localidad AS ll ON p.DomicilioLaboralIDProvincia = ll.IDProvincia AND p.DomicilioLaboralIDLocalidad = ll.IDLocalidad)
				LEFT JOIN NivelEstudio AS ne ON p.IDNivelEstudio = ne.IDNivelEstudio)
				LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona)
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
			WHERE p.EsActivo = 1
				AND (@IDPersona IS NULL OR p.IDPersona = @IDPersona)
				AND (@IDCuartel IS NULL OR p.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (pa.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR pa.IDJerarquia = @IDJerarquia)))
				AND (pab.Fecha IS NULL OR pab.IDAltaBaja = dbo.udf_GetPersonaUltimaAltaBaja(p.IDPersona, GETDATE()))
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(p.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR (@EstadoActivo = 1 AND pab.IDPersonaBajaMotivo IS NULL) OR (@EstadoActivo = 0 AND pab.IDPersonaBajaMotivo IS NOT NULL))
				AND (@IDPersonaBajaMotivo IS NULL OR pab.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
	END
GO



IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'uspPersonaActualizacionDatosFamiliares') AND type in (N'P', N'PC'))
	 DROP PROCEDURE uspPersonaActualizacionDatosFamiliares
GO

CREATE PROCEDURE uspPersonaActualizacionDatosFamiliares
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT f.IDPersona, f.IDParentesco, (CASE f.IDParentesco WHEN 254 THEN ISNULL(f.ParentescoOtro, fp.Nombre) ELSE fp.Nombre END) AS Parentesco, fp.Orden AS ParentescoOrden,
			f.Apellido AS FamiliarApellido, f.Nombre AS FamiliarNombre, f.ApellidoNombre AS FamiliarApellidoNombre, fdt.Nombre AS FamiliarDocumentoTipo, f.DocumentoNumero AS FamiliarDocumentoNumero, f.FechaNacimiento AS FamiliarFechaNacimiento,
			f.Genero AS FamiliarGenero, f.GrupoSanguineo AS FamiliarGrupoSanguineo, f.FactorRH AS FamiliarFactorRH, fec.Nombre AS FamiliarEstadoCivil,
			f.IOMATiene AS FamiliarIOMATiene, f.IOMANumeroAfiliado AS FamiliarIOMANumeroAfiliado, f.IOMAVencimientoCredencial AS FamiliarIOMAVencimientoCredencial, f.IOMAACargo AS FamiliarIOMAACargo,
			f.ACargo AS FamiliarACargo, f.Vive AS FamiliarVive, f.EsEmergencia AS FamiliarEsEmergencia,
			dbo.udf_GetDomicilioCalleCompleto(f.DomicilioCalle1, f.DomicilioNumero, f.DomicilioPiso, f.DomicilioDepartamento, f.DomicilioCalle2, f.DomicilioCalle3) AS FamiliarDomicilio, fl.Nombre AS FamiliarLocalidad,
			f.Telefono AS FamiliarTelefono
			FROM (((PersonaFamiliar AS f
				LEFT JOIN Parentesco AS fp ON f.IDParentesco = fp.IDParentesco)
				LEFT JOIN DocumentoTipo AS fdt ON f.IDDocumentoTipo = fdt.IDDocumentoTipo)
				LEFT JOIN EstadoCivil AS fec ON f.IDEstadoCivil = fec.IDEstadoCivil)
				LEFT JOIN Localidad AS fl ON f.DomicilioIDProvincia = fl.IDProvincia AND f.DomicilioIDLocalidad = fl.IDLocalidad
			WHERE f.Vive = 1
	END
GO