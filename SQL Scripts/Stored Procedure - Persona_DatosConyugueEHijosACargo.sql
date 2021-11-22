USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-11-15
-- Updates: 2021-11-21 - Actualizado a las nuevas funciones y tablas
-- Description:	Devuelve los datos de la Persona y su cónyugue con sus Hijos a cargo
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
	@FechaEmision date,
	@IOMAACargo bit
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		DECLARE @IDParentescoHijo tinyint

		SET @IDParentescoHijo = dbo.udf_GetParametro_NumeroEntero('PARENTESCO_ID_HIJO')

		SELECT 'Lobos' AS Partido, 'Lobos' AS Ciudad,
				DAY(@FechaEmision) AS FechaDia, FORMAT(@FechaEmision, 'MMMM', 'es-es') AS FechaMes, YEAR(@FechaEmision) AS FechaAnio,
				FORMAT(@FechaEmision, 'yy') AS FechaAnioCorto, FORMAT(@FechaEmision, 'dd/MM/yyyy') AS Fecha,
				c.Nombre AS CuartelNombre, p.IDPersona, p.MatriculaNumero, p.Genero, p.Apellido, p.Nombre, p.ApellidoNombre, p.Nombre + ' ' + p.Apellido AS NombreApellido,
				dt.Nombre AS DocumentoTipoNombre, p.DocumentoNumero, ec.Nombre AS EstadoCivil, CONVERT(varchar(10), p.FechaNacimiento, 103) AS FechaNacimiento,
				CONVERT(varchar(10), p.FechaCasamiento, 103) AS FechaCasamiento, p.Profesion, p.Nacionalidad,
				ca.Nombre AS Cargo, ca.Orden AS CargoOrden, cj.Nombre AS Jerarquia, cj.Orden AS JerarquiaOrden,
				dbo.PersonaObtenerEstado(pab.Tipo, pbm.Nombre) AS Estado,
				p.DomicilioParticularCalle1, p.DomicilioParticularNumero, dbo.udf_GetDomicilioCalleCompleto(p.DomicilioParticularCalle1, p.DomicilioParticularNumero, p.DomicilioParticularPiso, p.DomicilioParticularDepartamento, p.DomicilioParticularCalle2, p.DomicilioParticularCalle3) AS Domicilio,
				l.Nombre AS LocalidadNombre, p.IOMANumeroAfiliado, CONVERT(varchar(10), dbo.PersonaObtenerFechaUltimaAlta(p.IDPersona, NULL), 103) AS AltaFecha,
				Conyugue.Apellido AS ConyugueApellido, Conyugue.Nombre AS ConyugueNombre, Conyugue.ApellidoNombre AS ConyugueApellidoNombre, Conyugue.Nombre + ' ' + Conyugue.Apellido AS ConyugueNombreApellido,
				dbo.udf_GetDomicilioCalleCompleto(Conyugue.DomicilioCalle1, Conyugue.DomicilioNumero, Conyugue.DomicilioPiso, Conyugue.DomicilioDepartamento, Conyugue.DomicilioCalle2, Conyugue.DomicilioCalle3) AS ConyugueDomicilio,
				Conyugue.IOMANumeroAfiliado AS ConyugueIOMANumeroAfiliado, CONVERT(varchar(10), Conyugue.FechaNacimiento, 103) AS ConyugueFechaNacimiento,
				cdt.Nombre AS ConyugueDocumentoTipoNombre, Conyugue.DocumentoNumero AS ConyugueDocumentoNumero, Conyugue.Notas AS ConyugueNotas,
				Hijo.Apellido AS HijoApellido, Hijo.Nombre AS HijoNombre, Hijo.ApellidoNombre AS HijoApellidoNombre, Hijo.Nombre + ' ' + Hijo.Apellido AS HijoNombreApellido,
				dbo.udf_GetDomicilioCalleCompleto(Hijo.DomicilioCalle1, Hijo.DomicilioNumero, Hijo.DomicilioPiso, Hijo.DomicilioDepartamento, Hijo.DomicilioCalle2, Hijo.DomicilioCalle3) AS HijoDomicilio,
				Hijo.IOMANumeroAfiliado AS HijoIOMANumeroAfiliado, Hijo.FechaNacimiento AS HijoFechaNacimiento,
				hdt.Nombre AS HijoDocumentoTipoNombre, Hijo.DocumentoNumero AS HijoDocumentoNumero, Hijo.Notas AS HijoNotas
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
				LEFT JOIN (SELECT * FROM PersonaFamiliar WHERE IDParentesco = 7 AND ((@IOMAACargo = 0 AND ACargo = 1) OR (@IOMAACargo = 1 AND IOMAACargo = 1))) AS Conyugue ON p.IDPersona = Conyugue.IDPersona
				LEFT JOIN (SELECT * FROM PersonaFamiliar WHERE IDParentesco = @IDParentescoHijo AND ((@IOMAACargo = 0 AND ACargo = 1) OR (@IOMAACargo = 1 AND IOMAACargo = 1))) AS Hijo ON p.IDPersona = Hijo.IDPersona
				LEFT JOIN DocumentoTipo AS cdt ON Conyugue.IDDocumentoTipo = cdt.IDDocumentoTipo
				LEFT JOIN DocumentoTipo AS hdt ON Hijo.IDDocumentoTipo = hdt.IDDocumentoTipo
			WHERE p.EsActivo = 1
				AND (Conyugue.ACargo IS NULL OR (@IOMAACargo = 0 AND Conyugue.ACargo = 1) OR (@IOMAACargo = 1 AND Conyugue.IOMAACargo = 1))
				AND (Hijo.ACargo IS NULL OR (@IOMAACargo = 0 AND Hijo.ACargo = 1) OR (@IOMAACargo = 1 AND Hijo.IOMAACargo = 1))
				AND (@IDPersona IS NULL OR p.IDPersona = @IDPersona)
				AND (@IDCuartel IS NULL OR p.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (pa.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR pa.IDJerarquia = @IDJerarquia)))
				AND (pab.IDAltaBaja IS NULL OR pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, GETDATE()))
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR dbo.PersonaObtenerSiEstadoEsActivo(pab.Tipo) = @EstadoActivo)
				AND (@IDPersonaBajaMotivo IS NULL OR pab.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
			ORDER BY p.IDPersona, Hijo.FechaNacimiento
	END
GO