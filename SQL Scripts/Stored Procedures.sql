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

		SELECT Persona.IDPersona, Cuartel.Nombre AS CuartelNombre, Persona.Genero, Persona.Apellido, Persona.Nombre, DocumentoTipo.Nombre AS DocumentoTipoNombre, Persona.DocumentoNumero, PersonaAltaBaja.AltaFecha, PersonaAltaBaja.AltaLibroNumero, PersonaAltaBaja.AltaFolioNumero, PersonaAltaBaja.AltaActaNumero, PersonaFamiliarPadre.Apellido AS PadreApellido, PersonaFamiliarPadre.Nombre AS PadreNombre, PersonaFamiliarMadre.Apellido AS MadreApellido, PersonaFamiliarMadre.Nombre AS MadreNombre, Persona.Profesion, Persona.FechaNacimiento, Persona.Nacionalidad, dbo.udf_GetDomicilioCalleLocalidadCompleto(Persona.DomicilioParticularCalle1, Persona.DomicilioParticularNumero, Persona.DomicilioParticularPiso, Persona.DomicilioParticularDepartamento, Persona.DomicilioParticularCalle2, Persona.DomicilioParticularCalle3, Persona.DomicilioParticularIDProvincia, Persona.DomicilioParticularIDLocalidad) AS Domicilio
			FROM (((((Persona INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				LEFT JOIN DocumentoTipo ON Persona.IDDocumentoTipo = DocumentoTipo.IDDocumentoTipo)
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



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2017-01-09
-- Description:	Devuelve las calificaciones anuales finales de un Bombero
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_CalificacionAnualFinal') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_CalificacionAnualFinal
GO

CREATE PROCEDURE usp_Persona_CalificacionAnualFinal
	@IDPersona int
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT IDPersona, Anio, CAST(AVG(Promedio)AS DECIMAL(4,2)) AS CalificacionAnual
			FROM 
				(SELECT IDPersona, Anio, CAST(AVG(CAST(Calificacion AS DECIMAL(4,2))) AS DECIMAL(4,2)) AS Promedio
				FROM PersonaCalificacion
				WHERE IDPersona = @IDPersona
				GROUP BY IDPersona, Anio, IDCalificacionConcepto) AS PromediosConceptosAnuales
			GROUP BY IDPersona, Anio
			ORDER BY Anio
	END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2017-01-11
-- Description:	Devuelve los datos para la Planilla Anual de Calificaciones de un Bombero
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_CalificacionAnualPlanilla') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_CalificacionAnualPlanilla
GO

CREATE PROCEDURE usp_Persona_CalificacionAnualPlanilla
	@IDPersona int,
	@Anio smallint
	AS

	BEGIN
		DECLARE @FechaAscenso date
		DECLARE @CargoJerarquiaNombre varchar(50)
		DECLARE @PromedioAnual decimal(4,2)

		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		-- OBTENGO LA ÚLTIMA JERARQUÍA PARA EL AÑO EN CUESTIÓN
		SET @FechaAscenso = (SELECT MAX(Fecha) FROM PersonaAscenso WHERE IDPersona = @IDPersona AND YEAR(Fecha) <= @Anio)
		SET @CargoJerarquiaNombre = (SELECT CargoJerarquia.Nombre FROM CargoJerarquia INNER JOIN PersonaAscenso ON CargoJerarquia.IDCargo = PersonaAscenso.IDCargo AND CargoJerarquia.IDJerarquia = PersonaAscenso.IDJerarquia WHERE PersonaAscenso.IDPersona = @IDPersona AND PersonaAscenso.Fecha = @FechaAscenso)

		-- OBTENGO EL PROMEDIO ANUAL GENERAL
		SET @PromedioAnual = (SELECT AVG(Promedio) AS PromedioAnual
								FROM (SELECT CAST(AVG(CAST(Calificacion AS DECIMAL(4,2))) AS DECIMAL(4,2)) AS Promedio
										FROM PersonaCalificacion
										WHERE IDPersona = @IDPersona and Anio = @Anio
										GROUP BY IDCalificacionConcepto) AS PromediosConceptosAnual)

		SELECT @CargoJerarquiaNombre AS JerarquiaNombre, Persona.ApellidoNombre, Persona.Apellido, Persona.Nombre, Persona.MatriculaNumero, CalificacionConcepto.Abreviatura AS ConceptoAbreviatura, CalificacionConcepto.Nombre AS ConceptoNombre, CalificacionConcepto.Descripcion AS ConceptoDescripcion, PersonaCalificacion.InstanciaNumero, PersonaCalificacion.Calificacion, @PromedioAnual AS PromedioAnual
			FROM (Persona LEFT JOIN PersonaCalificacion ON Persona.IDPersona = PersonaCalificacion.IDPersona) LEFT JOIN CalificacionConcepto ON PersonaCalificacion.IDCalificacionConcepto = CalificacionConcepto.IDCalificacionConcepto
			WHERE Persona.EsActivo = 1 AND Persona.IDPersona = @IDPersona AND PersonaCalificacion.Anio = @Anio
	END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-09
-- Description:	Devuelve los datos para el reporte de Jerarquías
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_ListadoJerarquiaAntiguedad') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_ListadoJerarquiaAntiguedad
GO

CREATE PROCEDURE usp_Persona_ListadoJerarquiaAntiguedad
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@EstadoActivo bit,
	@IDPersonaBajaMotivo tinyint,
	@FechaHasta date,
	@IDPersona int
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		-- ORDENO LAS PERSONAS - START
		CREATE TABLE #PersonaOrden
			(IDPersona int NOT NULL, Orden smallint NOT NULL,
				CONSTRAINT PK__PersonaOrden PRIMARY KEY CLUSTERED 
					(IDPersona ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON))
		EXEC dbo.usp_FillPersonaOrderTable
		-- ORDENO LAS PERSONAS - END
		
		IF @FechaHasta IS NULL
			SET @FechaHasta = GETDATE()

		SELECT Persona.IDPersona, Cuartel.Nombre AS CuartelNombre, Persona.MatriculaNumero, Persona.ApellidoNombre, NivelEstudio.IncluyeSecundario AS SecundarioCompleto, Cargo.Nombre AS CargoNombre, CargoJerarquia.Nombre AS JerarquiaNombre, PersonaAscenso.Fecha AS FechaUltimoAscenso, dbo.udf_GetPersonaAntiguedadLeyenda(Persona.IDPersona, PersonaAscenso.Fecha, @FechaHasta) AS AntiguedadCargoLeyenda, #PersonaOrden.Orden
			FROM ((((((Persona INNER JOIN #PersonaOrden ON Persona.IDPersona = #PersonaOrden.IDPersona)
				INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
				LEFT JOIN NivelEstudio ON Persona.IDNivelEstudio = NivelEstudio.IDNivelEstudio
			WHERE Persona.EsActivo = 1
				AND (@IDCuartel IS NULL OR Persona.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (PersonaAscenso.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR PersonaAscenso.IDJerarquia = @IDJerarquia)))
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, @FechaHasta))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, @FechaHasta))
				AND (@EstadoActivo IS NULL OR (@EstadoActivo = 1 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NULL) OR (@EstadoActivo = 0 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NOT NULL))
				AND (@IDPersonaBajaMotivo IS NULL OR PersonaAltaBaja.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
				AND (@IDPersona IS NULL OR Persona.IDPersona = @IDPersona)
	END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-11
-- Description:	Devuelve los datos para el reporte de Vencimiento de Registros de Conducir
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_ListadoRegistroConducir') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_ListadoRegistroConducir
GO

CREATE PROCEDURE usp_Persona_ListadoRegistroConducir
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@EstadoActivo bit,
	@IDPersonaBajaMotivo tinyint,
	@FechaDesde date,
	@FechaHasta date
	AS

	BEGIN

		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		-- ORDENO LAS PERSONAS - START
		CREATE TABLE #PersonaOrden
			(IDPersona int NOT NULL, Orden smallint NOT NULL,
				CONSTRAINT PK__PersonaOrden PRIMARY KEY CLUSTERED 
					(IDPersona ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON))
		EXEC dbo.usp_FillPersonaOrderTable
		-- ORDENO LAS PERSONAS - END

		SELECT Persona.IDPersona, Cuartel.Nombre AS CuartelNombre, Persona.MatriculaNumero, Persona.ApellidoNombre, Cargo.Nombre AS CargoNombre, CargoJerarquia.Nombre AS JerarquiaNombre, Persona.LicenciaConducirNumero, Persona.LicenciaConducirVencimiento, dbo.udf_GetPersonaLicenciaConducirCategorias(Persona.IDPersona) AS LicenciaConducirCategorias, #PersonaOrden.Orden
			FROM ((((((Persona INNER JOIN #PersonaOrden ON Persona.IDPersona = #PersonaOrden.IDPersona)
				INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
			WHERE Persona.EsActivo = 1
				AND (@IDCuartel IS NULL OR Persona.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (PersonaAscenso.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR PersonaAscenso.IDJerarquia = @IDJerarquia)))
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, GETDATE()))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR (@EstadoActivo = 1 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NULL) OR (@EstadoActivo = 0 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NOT NULL))
				AND (@IDPersonaBajaMotivo IS NULL OR PersonaAltaBaja.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
				AND (@FechaDesde IS NULL OR Persona.LicenciaConducirVencimiento >= @FechaDesde)
				AND (@FechaHasta IS NULL OR Persona.LicenciaConducirVencimiento <= @FechaHasta)
	END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-04-19
-- Description:	Devuelve los datos para los reportes de Vacunas
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_ListadoVacunas') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_ListadoVacunas
GO

CREATE PROCEDURE usp_Persona_ListadoVacunas
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@EstadoActivo bit,
	@IDPersonaBajaMotivo tinyint,
	@FechaDesde date,
	@FechaHasta date
	AS

	BEGIN

		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		-- ORDENO LAS PERSONAS - START
		CREATE TABLE #PersonaOrden
			(IDPersona int NOT NULL, Orden smallint NOT NULL,
				CONSTRAINT PK__PersonaOrden PRIMARY KEY CLUSTERED 
					(IDPersona ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON))
		EXEC dbo.usp_FillPersonaOrderTable
		-- ORDENO LAS PERSONAS - END

		SELECT Persona.IDPersona, Cuartel.Nombre AS CuartelNombre, Persona.MatriculaNumero, Persona.ApellidoNombre, Cargo.Nombre AS CargoNombre, CargoJerarquia.Nombre AS JerarquiaNombre, VacunaTipo.Nombre AS VacunaTipoNombre, PersonaVacuna.Lote, PersonaVacuna.DosisNumero, PersonaVacuna.Fecha, PersonaVacuna.Vencimiento, #PersonaOrden.Orden
			FROM ((((((Persona INNER JOIN #PersonaOrden ON Persona.IDPersona = #PersonaOrden.IDPersona)
				INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				INNER JOIN PersonaVacuna ON Persona.IDPersona = PersonaVacuna.IDPersona
				INNER JOIN VacunaTipo ON PersonaVacuna.IDVacunaTipo = VacunaTipo.IDVacunaTipo
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
			WHERE Persona.EsActivo = 1
				AND (@IDCuartel IS NULL OR Persona.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (PersonaAscenso.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR PersonaAscenso.IDJerarquia = @IDJerarquia)))
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, GETDATE()))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR (@EstadoActivo = 1 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NULL) OR (@EstadoActivo = 0 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NOT NULL))
				AND (@IDPersonaBajaMotivo IS NULL OR PersonaAltaBaja.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
				AND (@FechaDesde IS NULL OR PersonaVacuna.Vencimiento >= @FechaDesde)
				AND (@FechaHasta IS NULL OR PersonaVacuna.Vencimiento <= @FechaHasta)
	END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-11
-- Description:	Devuelve los datos para el reporte de Antigüedades
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_ListadoAntiguedad') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_ListadoAntiguedad
GO

CREATE PROCEDURE usp_Persona_ListadoAntiguedad
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@EstadoActivo bit,
	@IDPersonaBajaMotivo tinyint,
	@FechaHasta date,
	@IDPersona int
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		-- ORDENO LAS PERSONAS - START
		CREATE TABLE #PersonaOrden
			(IDPersona int NOT NULL, Orden smallint NOT NULL,
				CONSTRAINT PK__PersonaOrden PRIMARY KEY CLUSTERED 
					(IDPersona ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON))
		EXEC dbo.usp_FillPersonaOrderTable
		-- ORDENO LAS PERSONAS - END

		IF @FechaHasta IS NULL
			SET @FechaHasta = GETDATE()

		SELECT Persona.IDPersona, Cuartel.Nombre AS CuartelNombre, Persona.MatriculaNumero, Persona.ApellidoNombre, Cargo.Nombre AS CargoNombre, CargoJerarquia.Nombre AS JerarquiaNombre, dbo.udf_GetPersonaAntiguedadLeyenda(Persona.IDPersona, NULL, @FechaHasta) AS AntiguedadTotalLeyenda, #PersonaOrden.Orden
			FROM ((((((Persona INNER JOIN #PersonaOrden ON Persona.IDPersona = #PersonaOrden.IDPersona)
				INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
			WHERE Persona.EsActivo = 1
				AND (@IDCuartel IS NULL OR Persona.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (PersonaAscenso.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR PersonaAscenso.IDJerarquia = @IDJerarquia)))
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, @FechaHasta))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, @FechaHasta))
				AND (@EstadoActivo IS NULL OR (@EstadoActivo = 1 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NULL) OR (@EstadoActivo = 0 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NOT NULL))
				AND (@IDPersonaBajaMotivo IS NULL OR PersonaAltaBaja.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
				AND (@IDPersona IS NULL OR Persona.IDPersona = @IDPersona)
	END
GO


-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-11-25
-- Description:	Devuelve los datos para el reporte de Teléfonos
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_ListadoTelefonos') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_ListadoTelefonos
GO

CREATE PROCEDURE usp_Persona_ListadoTelefonos
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

		-- ORDENO LAS PERSONAS - START
		CREATE TABLE #PersonaOrden
			(IDPersona int NOT NULL, Orden smallint NOT NULL,
				CONSTRAINT PK__PersonaOrden PRIMARY KEY CLUSTERED 
					(IDPersona ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON))
		EXEC dbo.usp_FillPersonaOrderTable
		-- ORDENO LAS PERSONAS - END
		
		SELECT Persona.IDPersona, Cuartel.Nombre AS CuartelNombre, Persona.MatriculaNumero, Persona.ApellidoNombre, Persona.TelefonoParticular, Persona.CelularParticular, Persona.TelefonoLaboral, Persona.CelularLaboral, #PersonaOrden.Orden
			FROM ((((((Persona INNER JOIN #PersonaOrden ON Persona.IDPersona = #PersonaOrden.IDPersona)
				INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
			WHERE Persona.EsActivo = 1
				AND (@IDCuartel IS NULL OR Persona.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (PersonaAscenso.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR PersonaAscenso.IDJerarquia = @IDJerarquia)))
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, GETDATE()))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR (@EstadoActivo = 1 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NULL) OR (@EstadoActivo = 0 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NOT NULL))
				AND (@IDPersonaBajaMotivo IS NULL OR PersonaAltaBaja.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
				AND (@IDPersona IS NULL OR Persona.IDPersona = @IDPersona)
	END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-11
-- Description:	Devuelve los datos para el reporte de Unidades
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Unidad_Listado') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Unidad_Listado
GO

CREATE PROCEDURE usp_Unidad_Listado
	@IDCuartel tinyint,
	@IDUnidad smallint,
	@FechaDesde date,
	@FechaHasta date
	AS

	BEGIN
		SELECT Unidad.IDUnidad, Unidad.Numero, Unidad.MarcaModelo, Unidad.EsImportado, Unidad.Anio, Unidad.NumeroMotor, Unidad.NumeroChasis, Unidad.Dominio, UnidadTipo.Nombre AS UnidadTipoNombre, UnidadUso.Nombre AS UnidadUsoNombre, CombustibleTipo.Nombre AS CombustibleTipoNombre, Unidad.FechaAdquisicion, Unidad.KilometrajeInicial, Unidad.CapacidadAguaLitros, Cuartel.Nombre AS CuartelNombre, Unidad.EsPropio, Unidad.VerificacionVencimiento
			FROM (((Unidad INNER JOIN UnidadTipo ON Unidad.IDUnidadTipo = UnidadTipo.IDUnidadTipo) INNER JOIN UnidadUso ON Unidad.IDUnidadUso = UnidadUso.IDUnidadUso) LEFT JOIN CombustibleTipo ON Unidad.IDCombustibleTipo = CombustibleTipo.IDCombustibleTipo) INNER JOIN Cuartel ON Unidad.IDCuartel = Cuartel.IDCuartel
			WHERE Unidad.EsActivo = 1
				AND (@IDCuartel IS NULL OR Unidad.IDCuartel = @IDCuartel)
				AND (@IDUnidad IS NULL OR Unidad.IDUnidad = @IDUnidad)
				AND (@FechaDesde IS NULL OR Unidad.VerificacionVencimiento >= @FechaDesde)
				AND (@FechaHasta IS NULL OR Unidad.VerificacionVencimiento <= @FechaHasta)
	END
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



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-18
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

		-- ORDENO LAS PERSONAS - START
		CREATE TABLE #PersonaOrden
			(IDPersona int NOT NULL, Orden smallint NOT NULL,
				CONSTRAINT PK__PersonaOrden PRIMARY KEY CLUSTERED 
					(IDPersona ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
			)
		EXEC dbo.usp_FillPersonaOrderTable
		-- ORDENO LAS PERSONAS - END

		SELECT Persona.IDPersona, Persona.Apellido, Persona.Nombre, DocumentoTipo.Nombre AS DocumentoTipoNombre, Persona.DocumentoNumero, Persona.FechaNacimiento, Persona.MatriculaNumero, Persona.Altura, Persona.Peso, Persona.Genero, Provincia.Nombre AS ProvinciaNombre, Localidad.Nombre AS LocalidadNombre, dbo.udf_GetDomicilioCalleCompleto(Persona.DomicilioParticularCalle1, Persona.DomicilioParticularNumero, Persona.DomicilioParticularPiso, Persona.DomicilioParticularDepartamento, Persona.DomicilioParticularCalle2, Persona.DomicilioParticularCalle3) AS Domicilio, Persona.EmailParticular, Persona.CelularParticular, Persona.GrupoSanguineo, Persona.FactorRH, 'CFBVRA' AS Organizacion, 'Bombero' AS Formacion, Cargo.Nombre AS Cargo, CargoJerarquia.Nombre AS Jerarquia, NivelEstudio.Nombre AS NivelEstudioNombre, (CASE ISNULL(PersonaAltaBaja.IDPersonaBajaMotivo, 0) WHEN 0 THEN 'Activo' ELSE PersonaBajaMotivo.Nombre END) AS Estado, (CASE ISNULL(PersonaAltaBaja.BajaFecha, '') WHEN '' THEN PersonaAltaBaja.AltaFecha ELSE PersonaAltaBaja.BajaFecha END) AS FechaEstado, #PersonaOrden.Orden
			FROM (((((((((Persona INNER JOIN #PersonaOrden ON Persona.IDPersona = #PersonaOrden.IDPersona)
				LEFT JOIN DocumentoTipo ON Persona.IDDocumentoTipo = DocumentoTipo.IDDocumentoTipo)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
				LEFT JOIN PersonaBajaMotivo ON PersonaAltaBaja.IDPersonaBajaMotivo = PersonaBajaMotivo.IDPersonaBajaMotivo)
				LEFT JOIN Provincia ON Persona.DomicilioParticularIDProvincia = Provincia.IDProvincia)
				LEFT JOIN Localidad ON Persona.DomicilioParticularIDProvincia = Localidad.IDProvincia AND Persona.DomicilioLaboralIDLocalidad = Localidad.IDLocalidad)
				LEFT JOIN NivelEstudio ON Persona.IDNivelEstudio = NivelEstudio.IDNivelEstudio
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



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-20
-- Description:	Devuelve los datos de la Persona
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_Datos') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_Datos
GO

CREATE PROCEDURE usp_Persona_Datos
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

		SELECT Persona.IDPersona, Persona.MatriculaNumero, Cuartel.Nombre AS CuartelNombre, Persona.Genero, Persona.Apellido, Persona.Nombre, DocumentoTipo.Nombre AS DocumentoTipoNombre, Persona.DocumentoNumero, Persona.FechaNacimiento, Cargo.Nombre AS Cargo, CargoJerarquia.Nombre AS Jerarquia, (CASE ISNULL(PersonaAltaBaja.IDPersonaBajaMotivo, 0) WHEN 0 THEN 'Activo' ELSE PersonaBajaMotivo.Nombre END) AS Estado, dbo.udf_GetDomicilioCalleCompleto(Persona.DomicilioParticularCalle1, Persona.DomicilioParticularNumero, Persona.DomicilioParticularPiso, Persona.DomicilioParticularDepartamento, Persona.DomicilioParticularCalle2, Persona.DomicilioParticularCalle3) AS Domicilio, Localidad.Nombre AS LocalidadNombre, Persona.IOMANumeroAfiliado, PersonaAltaBaja.AltaFecha
			FROM ((((((((Persona INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				LEFT JOIN DocumentoTipo ON Persona.IDDocumentoTipo = DocumentoTipo.IDDocumentoTipo)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
				LEFT JOIN PersonaBajaMotivo ON PersonaAltaBaja.IDPersonaBajaMotivo = PersonaBajaMotivo.IDPersonaBajaMotivo)
				LEFT JOIN Provincia ON Persona.DomicilioParticularIDProvincia = Provincia.IDProvincia)
				LEFT JOIN Localidad ON Persona.DomicilioParticularIDProvincia = Localidad.IDProvincia AND Persona.DomicilioParticularIDLocalidad = Localidad.IDLocalidad
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



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-18
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

		SELECT Persona.IDPersona, Persona.MatriculaNumero, Cuartel.Nombre AS CuartelNombre, Persona.Genero, Persona.Apellido, Persona.Nombre, Persona.ApellidoNombre, DocumentoTipo.Nombre AS DocumentoTipoNombre, Persona.DocumentoNumero, Persona.FechaNacimiento, Persona.Profesion, Persona.Nacionalidad, Cargo.Nombre AS Cargo, CargoJerarquia.Nombre AS Jerarquia, (CASE ISNULL(PersonaAltaBaja.IDPersonaBajaMotivo, 0) WHEN 0 THEN 'Activo' ELSE PersonaBajaMotivo.Nombre END) AS Estado, dbo.udf_GetDomicilioCalleCompleto(Persona.DomicilioParticularCalle1, Persona.DomicilioParticularNumero, Persona.DomicilioParticularPiso, Persona.DomicilioParticularDepartamento, Persona.DomicilioParticularCalle2, Persona.DomicilioParticularCalle3) AS Domicilio, Localidad.Nombre AS LocalidadNombre, Persona.IOMANumeroAfiliado, PersonaAltaBaja.AltaFecha, Parentesco.Orden AS ParentescoOrden, Parentesco.Nombre AS ParentescoNombre, PF.Apellido AS FamiliarApellido, PF.Nombre AS FamiliarNombre, PF.ApellidoNombre AS FamiliarApellidoNombre, PF.Vive, dbo.udf_GetDomicilioCalleCompleto(PF.DomicilioCalle1, PF.DomicilioNumero, PF.DomicilioPiso, PF.DomicilioDepartamento, PF.DomicilioCalle2, PF.DomicilioCalle3) AS FamiliarDomicilio, PF.FechaNacimiento AS FamiliarFechaNacimiento, FamiliarDocumentoTipo.Nombre AS FamiliarDocumentoTipoNombre, PF.DocumentoNumero AS FamiliarDocumentoNumero
			FROM (((((((((((Persona INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				LEFT JOIN DocumentoTipo ON Persona.IDDocumentoTipo = DocumentoTipo.IDDocumentoTipo)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
				LEFT JOIN PersonaBajaMotivo ON PersonaAltaBaja.IDPersonaBajaMotivo = PersonaBajaMotivo.IDPersonaBajaMotivo)
				LEFT JOIN Provincia ON Persona.DomicilioParticularIDProvincia = Provincia.IDProvincia)
				LEFT JOIN Localidad ON Persona.DomicilioParticularIDProvincia = Localidad.IDProvincia AND Persona.DomicilioParticularIDLocalidad = Localidad.IDLocalidad)
				LEFT JOIN (SELECT * FROM PersonaFamiliar WHERE (@IOMAACargo = 0 AND PersonaFamiliar.ACargo = 1) OR (@IOMAACargo = 1 AND PersonaFamiliar.IOMAACargo = 1)) AS PF ON Persona.IDPersona = PF.IDPersona)
				LEFT JOIN Parentesco ON PF.IDParentesco = Parentesco.IDParentesco)
				LEFT JOIN DocumentoTipo AS FamiliarDocumentoTipo ON PF.IDDocumentoTipo = FamiliarDocumentoTipo.IDDocumentoTipo
			WHERE Persona.EsActivo = 1
				AND (PF.ACargo IS NULL OR (@IOMAACargo = 0 AND PF.ACargo = 1) OR (@IOMAACargo = 1 AND PF.IOMAACargo = 1))
				AND (@IDPersona IS NULL OR Persona.IDPersona = @IDPersona)
				AND (@IDCuartel IS NULL OR Persona.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (PersonaAscenso.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR PersonaAscenso.IDJerarquia = @IDJerarquia)))
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, GETDATE()))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR (@EstadoActivo = 1 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NULL) OR (@EstadoActivo = 0 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NOT NULL))
				AND (@IDPersonaBajaMotivo IS NULL OR PersonaAltaBaja.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
	END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-22
-- Description:	Devuelve los datos para la Solicitud de Sanción Disciplinaria
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_SancionDisciplinaria') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_SancionDisciplinaria
GO

CREATE PROCEDURE usp_Persona_SancionDisciplinaria
	@IDPersona int,
	@IDSancion smallint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT Persona.IDPersona, Persona.MatriculaNumero, Persona.Genero, Persona.Apellido, Persona.Nombre, CargoJerarquia.Nombre AS Jerarquia, SolicitudPersona.Apellido AS SolicitudPersonaApellido, SolicitudPersona.Nombre AS SolicitudPersonaNombre, SolicitudCargoJerarquia.Nombre AS SolicitudJerarquia, PersonaSancion.SolicitudMotivo, PersonaSancion.SolicitudFecha, PersonaSancion.EncuadreTexto, PersonaSancion.EncuadreFecha, SancionTipo.Nombre AS ResolucionSancionTipoNombre, PersonaSancion.ResolucionFecha, PersonaSancion.NotificacionFecha
			FROM ((((((((PersonaSancion INNER JOIN Persona ON PersonaSancion.IDPersona = Persona.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
				INNER JOIN Persona AS SolicitudPersona ON PersonaSancion.SolicitudIDPersona = SolicitudPersona.IDPersona)
				LEFT JOIN PersonaAscenso AS SolicitudPersonaAscenso ON SolicitudPersona.IDPersona = SolicitudPersonaAscenso.IDPersona)
				LEFT JOIN Cargo AS SolicitudCargo ON SolicitudPersonaAscenso.IDCargo = SolicitudCargo.IDCargo)
				LEFT JOIN CargoJerarquia AS SolicitudCargoJerarquia ON SolicitudPersonaAscenso.IDCargo = SolicitudCargoJerarquia.IDCargo AND SolicitudPersonaAscenso.IDJerarquia = SolicitudCargoJerarquia.IDJerarquia)
				LEFT JOIN SancionTipo ON PersonaSancion.ResolucionIDSancionTipo = SancionTipo.IDSancionTipo
			WHERE PersonaSancion.IDPersona = @IDPersona AND PersonaSancion.IDSancion = @IDSancion
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, PersonaSancion.SolicitudFecha))
				AND (SolicitudPersonaAscenso.Fecha IS NULL OR SolicitudPersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(SolicitudPersona.IDPersona, PersonaSancion.SolicitudFecha))
	END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-22
-- Description:	Devuelve los datos para la Solicitud de Sanción Disciplinaria
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_PlanillaLicencia') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_PlanillaLicencia
GO

CREATE PROCEDURE usp_Persona_PlanillaLicencia
	@IDPersona int,
	@IDLicencia smallint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		DECLARE @LicenciaAnteriorFechaDesde date
		DECLARE @LicenciaAnteriorFechaHasta date
		DECLARE @LicenciaAnteriorFechaInterrupcion date
		DECLARE @LicenciaAnteriorCausaNombre varchar(100)

		SELECT TOP 1 @LicenciaAnteriorFechaDesde = PersonaLicencia.FechaDesde, @LicenciaAnteriorFechaHasta = PersonaLicencia.FechaHasta, @LicenciaAnteriorFechaInterrupcion = PersonaLicencia.FechaInterrupcion, @LicenciaAnteriorCausaNombre = LicenciaCausa.Nombre
			FROM PersonaLicencia INNER JOIN LicenciaCausa ON PersonaLicencia.IDLicenciaCausa = LicenciaCausa.IDLicenciaCausa
			WHERE IDPersona = @IDPersona AND Fecha < (SELECT Fecha FROM PersonaLicencia WHERE IDPersona = @IDPersona AND IDLicencia = @IDLicencia)
			ORDER BY Fecha DESC

		SELECT Persona.IDPersona, Persona.MatriculaNumero, Persona.Genero, Persona.Apellido, Persona.Nombre, CargoJerarquia.Nombre AS Jerarquia, PersonaAltaBaja.AltaFecha, dbo.udf_GetPersonaAntiguedadLeyenda(Persona.IDPersona, NULL, PersonaLicencia.Fecha) AS Antiguedad,  PersonaLicencia.Fecha, LicenciaCausa.Nombre AS LicenciaCausaNombre, PersonaLicencia.FechaDesde, PersonaLicencia.FechaHasta, PersonaLicencia.FechaInterrupcion, @LicenciaAnteriorFechaDesde AS PersonaLicenciaUltimaFechaDesde, @LicenciaAnteriorFechaHasta AS PersonaLicenciaUltimaFechaHasta, @LicenciaAnteriorFechaInterrupcion AS PersonaLicenciaUltimaFechaInterrupcion, @LicenciaAnteriorCausaNombre AS LicenciaCausaUltimaNombre
			FROM (((((PersonaLicencia INNER JOIN Persona ON PersonaLicencia.IDPersona = Persona.IDPersona)
				INNER JOIN LicenciaCausa ON PersonaLicencia.IDLicenciaCausa = LicenciaCausa.IDLicenciaCausa)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia
			WHERE PersonaLicencia.IDPersona = @IDPersona AND PersonaLicencia.IDLicencia = @IDLicencia
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, PersonaLicencia.Fecha))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, PersonaLicencia.Fecha))
	END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-10-31
-- Description:	Devuelve los datos para el reporte de Cursos
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_Cursos') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_Cursos
GO

CREATE PROCEDURE usp_Persona_Cursos
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@EstadoActivo bit,
	@IDPersonaBajaMotivo tinyint,
	@FechaDesde date,
	@FechaHasta date,
	@IDPersona int
	AS

	BEGIN
		SELECT Persona.IDPersona, Cuartel.Nombre AS CuartelNombre, Persona.MatriculaNumero, Persona.ApellidoNombre, Cargo.Nombre AS CargoNombre, Cargo.Orden AS CargoOrden, CargoJerarquia.Nombre AS JerarquiaNombre, CargoJerarquia.Orden AS JerarquiaOrden, PersonaCapacitacion.Fecha AS CursoFecha, Curso.Nombre AS CursoNombre
			FROM ((((((Persona INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				INNER JOIN PersonaCapacitacion ON Persona.IDPersona = PersonaCapacitacion.IDPersona)
				INNER JOIN Curso ON PersonaCapacitacion.IDCurso = Curso.IDCurso)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia
			WHERE Persona.EsActivo = 1
				AND (@IDCuartel IS NULL OR Persona.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (PersonaAscenso.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR PersonaAscenso.IDJerarquia = @IDJerarquia)))
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, GETDATE()))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR (@EstadoActivo = 1 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NULL) OR (@EstadoActivo = 0 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NOT NULL))
				AND (@IDPersonaBajaMotivo IS NULL OR PersonaAltaBaja.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
				AND (@IDPersona IS NULL OR Persona.IDPersona = @IDPersona)
				AND (@FechaDesde IS NULL OR PersonaCapacitacion.Fecha >= @FechaDesde)
				AND (@FechaHasta IS NULL OR PersonaCapacitacion.Fecha <= @FechaHasta)
	END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-10-31
-- Description:	Devuelve los datos para el reporte de Sanciones Disciplinarias
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_Sanciones') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_Sanciones
GO

CREATE PROCEDURE usp_Persona_Sanciones
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@EstadoActivo bit,
	@IDPersonaBajaMotivo tinyint,
	@FechaDesde date,
	@FechaHasta date,
	@IDPersona int
	AS

	BEGIN
		SELECT Persona.IDPersona, Cuartel.Nombre AS CuartelNombre, Persona.MatriculaNumero, Persona.ApellidoNombre, Cargo.Nombre AS CargoNombre, Cargo.Orden AS CargoOrden, CargoJerarquia.Nombre AS JerarquiaNombre, CargoJerarquia.Orden AS JerarquiaOrden, PersonaSancion.ResolucionFecha, SancionTipo.Nombre AS SancionTipoNombre
			FROM ((((((Persona INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				INNER JOIN PersonaSancion ON Persona.IDPersona = PersonaSancion.IDPersona)
				INNER JOIN SancionTipo ON PersonaSancion.ResolucionIDSancionTipo = SancionTipo.IDSancionTipo)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia
			WHERE Persona.EsActivo = 1
				AND (@IDCuartel IS NULL OR Persona.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (PersonaAscenso.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR PersonaAscenso.IDJerarquia = @IDJerarquia)))
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, GETDATE()))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR (@EstadoActivo = 1 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NULL) OR (@EstadoActivo = 0 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NOT NULL))
				AND (@IDPersonaBajaMotivo IS NULL OR PersonaAltaBaja.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
				AND (@IDPersona IS NULL OR Persona.IDPersona = @IDPersona)
				AND (@FechaDesde IS NULL OR PersonaSancion.ResolucionFecha >= @FechaDesde)
				AND (@FechaHasta IS NULL OR PersonaSancion.ResolucionFecha <= @FechaHasta)
	END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-04-19
-- Description:	Devuelve los datos para el reporte de Vehículos personales
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Vehiculo_Listado') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Vehiculo_Listado
GO

CREATE PROCEDURE usp_Vehiculo_Listado
	@IDCuartel tinyint,
	@IDPersona int,
	@FechaVencimientoVerificacionDesde date,
	@FechaVencimientoVerificacionHasta date,
	@FechaVencimientoSeguroDesde date,
	@FechaVencimientoSeguroHasta date
	AS

	BEGIN
		SELECT Persona.MatriculaNumero AS PersonaMatriculaNumero, Persona.ApellidoNombre AS PersonaApellidoNombre, PersonaVehiculo.IDVehiculo, VehiculoTipo.Nombre AS VehiculoTipoNombre, PersonaVehiculo.Dominio, VehiculoMarca.Nombre AS VehiculoMarcaNombre, PersonaVehiculo.Modelo, PersonaVehiculo.Anio, PersonaVehiculo.VerificacionVencimiento, VehiculoCompaniaSeguro.Nombre AS VehiculoCompaniaSeguroNombre, PersonaVehiculo.SeguroPolizaNumero, PersonaVehiculo.SeguroVencimiento
			FROM (((Persona INNER JOIN PersonaVehiculo ON Persona.IDPersona = PersonaVehiculo.IDPersona) INNER JOIN VehiculoTipo ON PersonaVehiculo.IDVehiculoTipo = VehiculoTipo.IDVehiculoTipo) LEFT JOIN VehiculoMarca ON PersonaVehiculo.IDVehiculoMarca = VehiculoMarca.IDVehiculoMarca) LEFT JOIN VehiculoCompaniaSeguro ON PersonaVehiculo.IDVehiculoCompaniaSeguro = VehiculoCompaniaSeguro.IDVehiculoCompaniaSeguro
			WHERE PersonaVehiculo.EsActivo = 1
				AND (@IDCuartel IS NULL OR Persona.IDCuartel = @IDCuartel)
				AND (@IDPersona IS NULL OR Persona.IDPersona = @IDPersona)
				AND (@FechaVencimientoVerificacionDesde IS NULL OR PersonaVehiculo.VerificacionVencimiento >= @FechaVencimientoVerificacionDesde)
				AND (@FechaVencimientoVerificacionHasta IS NULL OR PersonaVehiculo.VerificacionVencimiento <= @FechaVencimientoVerificacionHasta)
				AND (@FechaVencimientoSeguroDesde IS NULL OR PersonaVehiculo.SeguroVencimiento >= @FechaVencimientoSeguroDesde)
				AND (@FechaVencimientoSeguroHasta IS NULL OR PersonaVehiculo.SeguroVencimiento <= @FechaVencimientoSeguroHasta)
	END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-11-06
-- Description:	Fills the PersonaOrden table
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.usp_FillPersonaOrderTable') AND type in (N'P', N'PC'))
	DROP PROCEDURE dbo.usp_FillPersonaOrderTable
GO

CREATE PROCEDURE usp_FillPersonaOrderTable
	AS
BEGIN

DECLARE @columns VARCHAR(MAX)
DECLARE @columnsorderby VARCHAR(MAX)
DECLARE @sql NVARCHAR(MAX)

SET @columns = ''
SET @columnsorderby = ''

SELECT @columns += ', ' + JerarquiaOrden, @columnsorderby += ', ISNULL(' + JerarquiaOrden + ', ''99999999'')'
FROM
(
	SELECT CONCAT('J', FORMAT(Cargo.Orden, '00'), FORMAT(CargoJerarquia.Orden, '00')) AS JerarquiaOrden
		FROM (PersonaAscenso INNER JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
			INNER JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia
		GROUP BY CONCAT('J', FORMAT(Cargo.Orden, '00'), FORMAT(CargoJerarquia.Orden, '00'))
) AS x;

SET @sql = 'INSERT INTO #PersonaOrden SELECT IDPersona, ROW_NUMBER() OVER (ORDER BY ' + STUFF(@columnsorderby, 1, 1, '') + ', FechaNacimiento) AS Orden FROM (
SELECT Persona.IDPersona, FORMAT(PersonaAscenso.Fecha, ''yyyyMMdd'') AS FechaAscenso, CONCAT(''J'', FORMAT(Cargo.Orden, ''00''), FORMAT(CargoJerarquia.Orden, ''00'')) AS JerarquiaOrden, Persona.FechaNacimiento
    FROM ((Persona INNER JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
			INNER JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
			INNER JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
		 AS j PIVOT (MIN(FechaAscenso) FOR JerarquiaOrden in 
	   (' + STUFF(@columns, 1, 1, '')+')) AS p;';

EXEC sys.sp_executesql @sql

END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-12-01
-- Description:	Devuelve los Elementos del Inventario
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Inventario') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Inventario
GO

CREATE PROCEDURE usp_Inventario
	@IDCuartel tinyint,
	@IDArea smallint,
	@IDUbicacion smallint,
	@IDSubUbicacion smallint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT Cuartel.Nombre AS CuartelNombre, Area.Nombre AS AreaNombre, Area.Codigo + Inventario.Codigo AS Codigo, Elemento.Nombre + ISNULL(' ' + Inventario.DescripcionPropia , '') AS ElementoNombre, Ubicacion.Nombre AS UbicacionNombre, SubUbicacion.Nombre AS SubUbicacionNombre, ModoAdquisicion.Nombre AS ModoAdquisicionNombre
			FROM (((((Inventario INNER JOIN Area ON Inventario.IDArea = Area.IDArea)
				INNER JOIN Cuartel ON Area.IDCuartel = Cuartel.IDCuartel)
				INNER JOIN Elemento ON Inventario.IDElemento = Elemento.IDElemento)
				LEFT JOIN Ubicacion ON Inventario.IDUbicacion = Ubicacion.IDUbicacion)
				LEFT JOIN SubUbicacion ON Inventario.IDSubUbicacion = SubUbicacion.IDSubUbicacion)
				LEFT JOIN ModoAdquisicion ON Inventario.IDModoAdquisicion = ModoAdquisicion.IDModoAdquisicion
			WHERE Inventario.EsActivo = 1
				AND (@IDCuartel IS NULL OR Area.IDCuartel = @IDCuartel)
				AND (@IDArea IS NULL OR Inventario.IDArea = @IDArea)
				AND (@IDUbicacion IS NULL OR Inventario.IDUbicacion = @IDUbicacion)
				AND (@IDSubUbicacion IS NULL OR Inventario.IDSubUbicacion = @IDSubUbicacion)
	END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-03-21
-- Description:	Devuelve los Elementos del Inventario con la Cantidad
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Inventario_Cantidad') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Inventario_Cantidad
GO

CREATE PROCEDURE usp_Inventario_Cantidad
	@IDCuartel tinyint,
	@IDArea smallint,
	@IDUbicacion smallint,
	@IDSubUbicacion smallint
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT Cuartel.Nombre AS CuartelNombre, Area.Nombre AS AreaNombre, Elemento.Nombre + ISNULL(' ' + Inventario.DescripcionPropia , '') AS ElementoNombre, Ubicacion.Nombre AS UbicacionNombre, ModoAdquisicion.Nombre AS ModoAdquisicionNombre, SUM(ISNULL(Inventario.Cantidad, 1)) AS Cantidad
			FROM (((((Inventario INNER JOIN Area ON Inventario.IDArea = Area.IDArea)
				INNER JOIN Cuartel ON Area.IDCuartel = Cuartel.IDCuartel)
				INNER JOIN Elemento ON Inventario.IDElemento = Elemento.IDElemento)
				LEFT JOIN Ubicacion ON Inventario.IDUbicacion = Ubicacion.IDUbicacion)
				LEFT JOIN SubUbicacion ON Inventario.IDSubUbicacion = SubUbicacion.IDSubUbicacion)
				LEFT JOIN ModoAdquisicion ON Inventario.IDModoAdquisicion = ModoAdquisicion.IDModoAdquisicion
			WHERE Inventario.EsActivo = 1
				AND (@IDCuartel IS NULL OR Area.IDCuartel = @IDCuartel)
				AND (@IDArea IS NULL OR Inventario.IDArea = @IDArea)
				AND (@IDUbicacion IS NULL OR Inventario.IDUbicacion = @IDUbicacion)
				AND (@IDSubUbicacion IS NULL OR Inventario.IDSubUbicacion = @IDSubUbicacion)
			GROUP BY Cuartel.Nombre, Area.Nombre, Elemento.Nombre + ISNULL(' ' + Inventario.DescripcionPropia , ''), Ubicacion.Nombre, ModoAdquisicion.Nombre
	END
GO