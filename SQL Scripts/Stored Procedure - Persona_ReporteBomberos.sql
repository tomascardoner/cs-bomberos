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
-- Description:	Devuelve los datos para la Planilla de Excel del Reporte de Bomberos
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_ReporteBomberos') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_ReporteBomberos
GO

CREATE PROCEDURE usp_Persona_ReporteBomberos
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

		-- Ordeno las personas
		CREATE TABLE #PersonaOrden
			(IDPersona int NOT NULL, Orden smallint NOT NULL,
				CONSTRAINT PK__PersonaOrden PRIMARY KEY CLUSTERED 
					(IDPersona ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON))
		EXEC dbo.usp_FillPersonaOrderTable

		SELECT p.IDPersona, p.Apellido, p.Nombre, dt.Nombre AS DocumentoTipoNombre, p.DocumentoNumero, p.FechaNacimiento, p.MatriculaNumero, p.Altura, p.Peso, p.Genero,
			pr.Nombre AS ProvinciaNombre, l.Nombre AS LocalidadNombre,
			dbo.udf_GetDomicilioCalleCompleto(p.DomicilioParticularCalle1, p.DomicilioParticularNumero, p.DomicilioParticularPiso, p.DomicilioParticularDepartamento, p.DomicilioParticularCalle2, p.DomicilioParticularCalle3) AS Domicilio,
			p.EmailParticular, p.CelularParticular, p.GrupoSanguineo, p.FactorRH, 'CFBVRA' AS Organizacion, 'Bombero' AS Formacion, ca.Nombre AS Cargo, cj.Nombre AS Jerarquia,
			ne.Nombre AS NivelEstudioNombre, dbo.PersonaObtenerEstado(pab.Tipo, pbm.Nombre) AS Estado, pab.Fecha AS FechaEstado, #PersonaOrden.Orden
			FROM Persona AS p
				INNER JOIN #PersonaOrden ON p.IDPersona = #PersonaOrden.IDPersona
				LEFT JOIN DocumentoTipo AS dt ON p.IDDocumentoTipo = dt.IDDocumentoTipo
				LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
				LEFT JOIN Cargo AS ca ON pa.IDCargo = ca.IDCargo
				LEFT JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
				LEFT JOIN PersonaBajaMotivo AS pbm ON pab.IDPersonaBajaMotivo = pbm.IDPersonaBajaMotivo
				LEFT JOIN Provincia AS pr ON p.DomicilioParticularIDProvincia = pr.IDProvincia
				LEFT JOIN Localidad AS l ON p.DomicilioParticularIDProvincia = l.IDProvincia AND p.DomicilioLaboralIDLocalidad = l.IDLocalidad
				LEFT JOIN NivelEstudio AS ne ON p.IDNivelEstudio = ne.IDNivelEstudio
			WHERE p.EsActivo = 1
				AND (@IDPersona IS NULL OR p.IDPersona = @IDPersona)
				AND (@IDCuartel IS NULL OR p.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (pa.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR pa.IDJerarquia = @IDJerarquia)))
				AND (pab.IDAltaBaja IS NULL OR pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, GETDATE()))
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR dbo.PersonaObtenerSiEstadoEsActivo(pab.Tipo) = @EstadoActivo)
				AND (@IDPersonaBajaMotivo IS NULL OR pab.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
	END
GO