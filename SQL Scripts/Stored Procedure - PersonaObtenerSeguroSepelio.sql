USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2022-11-28
-- Description:	Devuelve los datos de la Persona con sus familiares a cargo para el seguro de sepelio
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'PersonaObtenerSeguroSepelio') AND type in (N'P', N'PC'))
	 DROP PROCEDURE PersonaObtenerSeguroSepelio
GO

CREATE PROCEDURE PersonaObtenerSeguroSepelio
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

		DECLARE @IDParentescoHijo tinyint

		SET @IDParentescoHijo = dbo.udf_GetParametro_NumeroEntero('PARENTESCO_ID_HIJO')

		SELECT p.IDPersona, p.Genero, p.Apellido, p.Nombre, p.ApellidoNombre,
				dt.Nombre AS DocumentoTipoNombre, p.DocumentoNumero, CONVERT(varchar(10), p.FechaNacimiento, 103) AS FechaNacimiento,
				p.Profesion, p.Nacionalidad,
				dbo.udf_GetDomicilioCalleCompleto(p.DomicilioParticularCalle1, p.DomicilioParticularNumero, p.DomicilioParticularPiso, p.DomicilioParticularDepartamento, p.DomicilioParticularCalle2, p.DomicilioParticularCalle3) AS Domicilio,
				l.Nombre AS LocalidadNombre, CONVERT(varchar(10), dbo.PersonaObtenerFechaUltimaAlta(p.IDPersona, NULL), 103) AS AltaFecha,
				par.Orden AS ParentescoOrden, par.Nombre AS ParentescoNombre, pf.ApellidoNombre AS FamiliarApellidoNombre, pf.Apellido AS FamiliarApellido, pf.Nombre AS FamiliarNombre,
				pf.Vive AS FamiliarVive, dbo.udf_GetDomicilioCalleCompleto(pf.DomicilioCalle1, pf.DomicilioNumero, pf.DomicilioPiso, pf.DomicilioDepartamento, pf.DomicilioCalle2, pf.DomicilioCalle3) AS FamiliarDomicilio,
				pf.FechaNacimiento AS FamiliarFechaNacimiento, dbo.udf_GetElapsedCompleteYearsFromDates(pf.FechaNacimiento, GETDATE()) AS FamiliarEdad, fdt.Nombre AS FamiliarDocumentoTipoNombre, pf.DocumentoNumero AS FamiliarDocumentoNumero
			FROM Persona AS p
				LEFT JOIN DocumentoTipo AS dt ON p.IDDocumentoTipo = dt.IDDocumentoTipo
				LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
				LEFT JOIN Cargo AS ca ON pa.IDCargo = ca.IDCargo
				LEFT JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
				LEFT JOIN PersonaBajaMotivo AS pbm ON pab.IDPersonaBajaMotivo = pbm.IDPersonaBajaMotivo
				LEFT JOIN Provincia AS pr ON p.DomicilioParticularIDProvincia = pr.IDProvincia
				LEFT JOIN Localidad AS l ON p.DomicilioParticularIDProvincia = l.IDProvincia AND p.DomicilioParticularIDLocalidad = l.IDLocalidad
				LEFT JOIN (SELECT * FROM PersonaFamiliar WHERE ACargo = 1 AND (IDParentesco <> @IDParentescoHijo OR dbo.udf_GetElapsedCompleteYearsFromDates(FechaNacimiento, GETDATE()) < 21)) AS pf ON p.IDPersona = pf.IDPersona
				LEFT JOIN Parentesco AS par ON pf.IDParentesco = par.IDParentesco
				LEFT JOIN DocumentoTipo AS fdt ON pf.IDDocumentoTipo = fdt.IDDocumentoTipo
			WHERE p.EsActivo = 1
				AND (pf.IDPersona IS NULL OR pf.IDParentesco < 254)
				AND (@IDPersona IS NULL OR p.IDPersona = @IDPersona)
				AND (@IDCuartel IS NULL OR p.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (pa.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR pa.IDJerarquia = @IDJerarquia)))
				AND cj.JerarquiaInferior = 0
				AND (pab.Fecha IS NULL OR pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, GETDATE()))
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR dbo.PersonaObtenerSiEstadoEsActivo(pab.Tipo) = @EstadoActivo)
				AND (@IDPersonaBajaMotivo IS NULL OR pab.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
			ORDER BY p.IDPersona, pf.FechaNacimiento
	END
GO