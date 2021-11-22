USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-18
-- Updates: 2021-11-21 - Actualizado a las nuevas funciones y tablas
-- Description:	Devuelve los datos de la Persona con sus familiares a cargo
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_DatosYFamiliaresACargo') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_DatosYFamiliaresACargo
GO

CREATE PROCEDURE usp_Persona_DatosYFamiliaresACargo
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

		SELECT 'Lobos' AS Partido, 'Lobos' AS Ciudad, DAY(GETDATE()) AS FechaDia, FORMAT(GETDATE(), 'MMMM', 'es-es') AS FechaMes, YEAR(GETDATE()) AS FechaAnio, FORMAT(GETDATE(), 'yy') AS FechaAnioCorto,
				c.Nombre AS CuartelNombre, c.Descripcion AS CuartelDescripcion, p.IDPersona, p.MatriculaNumero, p.Genero, p.Apellido, p.Nombre, p.ApellidoNombre, p.Nombre + ' ' + p.Apellido AS NombreApellido,
				dt.Nombre AS DocumentoTipoNombre, p.DocumentoNumero, ec.Nombre AS EstadoCivil, CONVERT(varchar(10), p.FechaNacimiento, 103) AS FechaNacimiento,
				CONVERT(varchar(10), p.FechaCasamiento, 103) AS FechaCasamiento, p.Profesion, p.Nacionalidad, ca.Nombre AS Cargo, cj.Nombre AS Jerarquia,
				dbo.PersonaObtenerEstado(pab.Tipo, pab.IDPersonaBajaMotivo) AS Estado,
				dbo.udf_GetDomicilioCalleCompleto(p.DomicilioParticularCalle1, p.DomicilioParticularNumero, p.DomicilioParticularPiso, p.DomicilioParticularDepartamento, p.DomicilioParticularCalle2, p.DomicilioParticularCalle3) AS Domicilio,
				l.Nombre AS LocalidadNombre, p.IOMANumeroAfiliado, CONVERT(varchar(10), dbo.PersonaObtenerFechaUltimaAlta(p.IDPersona, NULL), 103) AS AltaFecha,
				par.Orden AS ParentescoOrden, par.Nombre AS ParentescoNombre, pf.Apellido AS FamiliarApellido, pf.Nombre AS FamiliarNombre, pf.ApellidoNombre AS FamiliarApellidoNombre, pf.Nombre + ' ' + pf.Apellido AS FamiliarNombreApellido,
				pf.Vive, dbo.udf_GetDomicilioCalleCompleto(pf.DomicilioCalle1, pf.DomicilioNumero, pf.DomicilioPiso, pf.DomicilioDepartamento, pf.DomicilioCalle2, pf.DomicilioCalle3) AS FamiliarDomicilio,
				CONVERT(varchar(10), pf.FechaNacimiento, 103) AS FamiliarFechaNacimiento, fdt.Nombre AS FamiliarDocumentoTipoNombre, pf.DocumentoNumero AS FamiliarDocumentoNumero, pf.Notas AS FamiliarNotas
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
				LEFT JOIN (SELECT * FROM PersonaFamiliar WHERE (@IOMAACargo = 0 AND ACargo = 1) OR (@IOMAACargo = 1 AND IOMAACargo = 1)) AS pf ON p.IDPersona = pf.IDPersona
				LEFT JOIN Parentesco AS par ON pf.IDParentesco = par.IDParentesco
				LEFT JOIN DocumentoTipo AS fdt ON pf.IDDocumentoTipo = fdt.IDDocumentoTipo
			WHERE p.EsActivo = 1
				AND (pf.IDParentesco IS NULL OR pf.IDParentesco < 254)
				AND (pf.ACargo IS NULL OR (@IOMAACargo = 0 AND pf.ACargo = 1) OR (@IOMAACargo = 1 AND pf.IOMAACargo = 1))
				AND (@IDPersona IS NULL OR p.IDPersona = @IDPersona)
				AND (@IDCuartel IS NULL OR p.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (pa.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR pa.IDJerarquia = @IDJerarquia)))
				AND (pab.Fecha IS NULL OR pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, GETDATE()))
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR dbo.PersonaObtenerSiEstadoEsActivo(pab.Tipo) = @EstadoActivo)
				AND (@IDPersonaBajaMotivo IS NULL OR pab.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
			ORDER BY p.IDPersona, pf.FechaNacimiento
	END
GO