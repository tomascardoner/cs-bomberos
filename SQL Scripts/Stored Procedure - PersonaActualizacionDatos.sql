USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-04-17
-- Updates: 2021-06-06 se abrió el stored procedure en 2 para los subreportes de familiares
--			2021-11-21 - Actualizado a las nuevas funciones y tablas
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

		SELECT p.IDPersona, p.MatriculaNumero, p.Apellido, p.Nombre, p.ApellidoNombre, dt.Nombre AS DocumentoTipo, p.DocumentoNumero, p.CUIL, p.FechaNacimiento, p.Genero,
			p.Altura, p.Peso, p.GrupoSanguineo, p.FactorRH, ec.Nombre AS EstadoCivil, p.FechaCasamiento,
			p.IOMATiene, p.IOMANumeroAfiliado, p.IOMAVencimientoCredencial,
			ne.Nombre AS NivelEstudio, p.TituloObtenido, p.Profesion, p.Nacionalidad, c.Nombre AS Cuartel,
			dbo.udf_GetDomicilioCalleCompleto(p.DomicilioParticularCalle1, p.DomicilioParticularNumero, p.DomicilioParticularPiso, p.DomicilioParticularDepartamento, p.DomicilioParticularCalle2, p.DomicilioParticularCalle3) AS DomicilioParticular, lp.Nombre AS LocalidadParticular,
			p.TelefonoParticular, p.CelularParticular, p.EmailParticular,
			dbo.udf_GetDomicilioCalleCompleto(p.DomicilioLaboralCalle1, p.DomicilioLaboralNumero, p.DomicilioLaboralPiso, p.DomicilioLaboralDepartamento, p.DomicilioLaboralCalle2, p.DomicilioLaboralCalle3) AS DomicilioLaboral, ll.Nombre AS LocalidadLaboral,
			p.TelefonoLaboral, p.CelularLaboral, p.EmailLaboral,
			pab.Fecha, p.LicenciaConducirNumero, p.LicenciaConducirVencimiento
			FROM Persona AS p
				INNER JOIN Cuartel AS c ON p.IDCuartel = c.IDCuartel
				LEFT JOIN DocumentoTipo AS dt ON p.IDDocumentoTipo = dt.IDDocumentoTipo
				LEFT JOIN EstadoCivil AS ec ON p.IDEstadoCivil = ec.IDEstadoCivil
				LEFT JOIN Localidad AS lp ON p.DomicilioParticularIDProvincia = lp.IDProvincia AND p.DomicilioParticularIDLocalidad = lp.IDLocalidad
				LEFT JOIN Localidad AS ll ON p.DomicilioLaboralIDProvincia = ll.IDProvincia AND p.DomicilioLaboralIDLocalidad = ll.IDLocalidad
				LEFT JOIN NivelEstudio AS ne ON p.IDNivelEstudio = ne.IDNivelEstudio
				LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
			WHERE p.EsActivo = 1
				AND (@IDPersona IS NULL OR p.IDPersona = @IDPersona)
				AND (@IDCuartel IS NULL OR p.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (pa.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR pa.IDJerarquia = @IDJerarquia)))
				AND (pab.IDAltaBaja IS NULL OR pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, NULL))
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, NULL))
				AND (@EstadoActivo IS NULL OR dbo.PersonaObtenerSiEstadoEsActivo(pab.Tipo) = @EstadoActivo)
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

		SELECT pf.IDPersona, pf.IDParentesco, (CASE pf.IDParentesco WHEN 254 THEN ISNULL(pf.ParentescoOtro, fp.Nombre) ELSE fp.Nombre END) AS Parentesco, fp.Orden AS ParentescoOrden,
			pf.Apellido AS FamiliarApellido, pf.Nombre AS FamiliarNombre, pf.ApellidoNombre AS FamiliarApellidoNombre, fdt.Nombre AS FamiliarDocumentoTipo,
			pf.DocumentoNumero AS FamiliarDocumentoNumero, pf.FechaNacimiento AS FamiliarFechaNacimiento,
			pf.Genero AS FamiliarGenero, pf.GrupoSanguineo AS FamiliarGrupoSanguineo, pf.FactorRH AS FamiliarFactorRH, fec.Nombre AS FamiliarEstadoCivil,
			pf.IOMATiene AS FamiliarIOMATiene, pf.IOMANumeroAfiliado AS FamiliarIOMANumeroAfiliado, pf.IOMAVencimientoCredencial AS FamiliarIOMAVencimientoCredencial,
			pf.IOMAACargo AS FamiliarIOMAACargo, pf.ACargo AS FamiliarACargo, pf.Vive AS FamiliarVive, pf.EsEmergencia AS FamiliarEsEmergencia,
			dbo.udf_GetDomicilioCalleCompleto(pf.DomicilioCalle1, pf.DomicilioNumero, pf.DomicilioPiso, pf.DomicilioDepartamento, pf.DomicilioCalle2, pf.DomicilioCalle3) AS FamiliarDomicilio, fl.Nombre AS FamiliarLocalidad,
			pf.Telefono AS FamiliarTelefono
			FROM PersonaFamiliar AS pf
				LEFT JOIN Parentesco AS fp ON pf.IDParentesco = fp.IDParentesco
				LEFT JOIN DocumentoTipo AS fdt ON pf.IDDocumentoTipo = fdt.IDDocumentoTipo
				LEFT JOIN EstadoCivil AS fec ON pf.IDEstadoCivil = fec.IDEstadoCivil
				LEFT JOIN Localidad AS fl ON pf.DomicilioIDProvincia = fl.IDProvincia AND pf.DomicilioIDLocalidad = fl.IDLocalidad
			WHERE pf.Vive = 1
	END
GO