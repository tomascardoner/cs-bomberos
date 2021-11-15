USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2017-01-09
-- Description:	Devuelve la calificación anual final dada la calificación promedio
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetCalificacionAnualFinal_Abreviada') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetCalificacionAnualFinal_Abreviada
GO

CREATE FUNCTION udf_GetCalificacionAnualFinal_Abreviada
(	
	@CalificacionAnual decimal(4,2)
) RETURNS varchar(2) AS
BEGIN
	RETURN (CASE 
				WHEN @CalificacionAnual < 4 THEN 'D'
				WHEN @CalificacionAnual >= 4 AND @CalificacionAnual < 6 THEN 'R'
				WHEN @CalificacionAnual >= 6 AND @CalificacionAnual < 7 THEN 'B'
				WHEN @CalificacionAnual >= 7 AND @CalificacionAnual < 9 THEN 'MB'
				WHEN @CalificacionAnual >= 9 THEN 'E'
			END)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-10-31
-- Description:	Devuelve la primer fecha de Alta
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetPersonaPrimerFechaAlta') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetPersonaPrimerFechaAlta
GO

CREATE FUNCTION udf_GetPersonaPrimerFechaAlta
(	
	@IDPersona int
) RETURNS date AS
BEGIN
	RETURN (SELECT MIN(AltaFecha) FROM PersonaAltaBaja WHERE IDPersona = @IDPersona)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-08
-- Description:	Devuelve la última fecha de Alta
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetPersonaUltimaFechaAlta') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetPersonaUltimaFechaAlta
GO

CREATE FUNCTION udf_GetPersonaUltimaFechaAlta
(	
	@IDPersona int,
	@FechaHasta date
) RETURNS date AS
BEGIN
	RETURN (SELECT MAX(AltaFecha) FROM PersonaAltaBaja WHERE IDPersona = @IDPersona AND AltaFecha <= @FechaHasta)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2020-10-30
-- Description:	Devuelve la última fecha de Baja
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetPersonaUltimaFechaBaja') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetPersonaUltimaFechaBaja
GO

CREATE FUNCTION udf_GetPersonaUltimaFechaBaja
(	
	@IDPersona int,
	@FechaHasta date
) RETURNS date AS
BEGIN
	RETURN (SELECT MAX(BajaFecha) FROM PersonaAltaBaja WHERE IDPersona = @IDPersona AND BajaFecha <= @FechaHasta)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-08
-- Description:	Devuelve la última fecha de Ascenso
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetPersonaUltimaFechaAscenso') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetPersonaUltimaFechaAscenso
GO

CREATE FUNCTION udf_GetPersonaUltimaFechaAscenso
(	
	@IDPersona int,
	@FechaHasta date
) RETURNS date AS
BEGIN
	RETURN (SELECT MAX(Fecha) FROM PersonaAscenso WHERE IDPersona = @IDPersona AND Fecha <= @FechaHasta)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-04-18
-- Description:	Devuelve la última fecha de Licencia
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetPersonaUltimaFechaLicencia') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetPersonaUltimaFechaLicencia
GO

CREATE FUNCTION udf_GetPersonaUltimaFechaLicencia
(	
	@IDPersona int,
	@FechaHasta date
) RETURNS date AS
BEGIN
	RETURN (SELECT MAX(Fecha) FROM PersonaLicencia WHERE IDPersona = @IDPersona AND Fecha <= @FechaHasta)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-10-04
-- Description:	Devuelve la antigüedad expresada en días,
--				de una Persona desde la FechaDesde hasta FechaHasta
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetPersonaAntiguedadDias') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetPersonaAntiguedadDias
GO

CREATE FUNCTION udf_GetPersonaAntiguedadDias
(
	@IDPersona int,
	@FechaDesde date,
	@FechaHasta date
) RETURNS int AS
BEGIN
	IF @FechaDesde IS NULL
		SET @FechaDesde = '1800-01-01'

	RETURN (
		SELECT SUM(DATEDIFF(DAY, (CASE WHEN AltaFecha < @FechaDesde THEN @FechaDesde ELSE AltaFecha END), ISNULL(BajaFecha, @FechaHasta)))
			FROM PersonaAltaBaja
			WHERE IDPersona = @IDPersona
				AND AltaFecha <= @FechaHasta
				AND (BajaFecha IS NULL OR BajaFecha > @FechaDesde)
			)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-10-04
-- Description:	Devuelve la antigüedad expresada en años, meses y días,
--				de una Persona desde la FechaDesde hasta FechaHasta
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetPersonaAntiguedadLeyenda') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetPersonaAntiguedadLeyenda
GO

CREATE FUNCTION udf_GetPersonaAntiguedadLeyenda
(
	@IDPersona int,
	@FechaDesde date,
	@FechaHasta date
) RETURNS varchar(100) AS
BEGIN
	DECLARE @FechaAlta date
	DECLARE @FechaBaja date

	DECLARE @AniosAcumulados smallint = 0
	DECLARE @MesesAcumulados smallint = 0
	DECLARE @DiasAcumulados smallint = 0

	IF @FechaDesde IS NULL
		SET @FechaDesde = '1800-01-01'
	IF @FechaHasta IS NULL
		SET @FechaHasta = GETDATE()

	DECLARE AltaBajaCursor CURSOR LOCAL FORWARD_ONLY STATIC FOR 
		SELECT (CASE WHEN AltaFecha < @FechaDesde THEN @FechaDesde ELSE AltaFecha END) AS FechaAlta, ISNULL(BajaFecha, @FechaHasta) AS FechaBaja
			FROM PersonaAltaBaja
			WHERE IDPersona = @IDPersona
				AND AltaFecha <= @FechaHasta
				AND (BajaFecha IS NULL OR BajaFecha > @FechaDesde)

	OPEN AltaBajaCursor
	FETCH NEXT FROM AltaBajaCursor INTO @FechaAlta, @FechaBaja

	WHILE @@FETCH_STATUS = 0
	BEGIN
		SELECT @AniosAcumulados = @AniosAcumulados + Years, @MesesAcumulados = @MesesAcumulados + Months, @DiasAcumulados = @DiasAcumulados + [Days]
			FROM dbo.udf_GetElapsedYearsMonthsAndDaysFromDatesAsTable(@FechaAlta, @FechaBaja)

		FETCH NEXT FROM AltaBajaCursor INTO @FechaAlta, @FechaBaja
	END

	CLOSE AltaBajaCursor

	DEALLOCATE AltaBajaCursor

	IF @DiasAcumulados >= 30
		BEGIN
		SET @MesesAcumulados = @MesesAcumulados + (@DiasAcumulados / 30)
		SET @DiasAcumulados = (@DiasAcumulados % 30)
		END

	IF @MesesAcumulados >= 12
		BEGIN
		SET @AniosAcumulados = @AniosAcumulados + (@MesesAcumulados / 12)
		SET @MesesAcumulados = (@MesesAcumulados % 12)
		END

	RETURN dbo.udf_FormatElapsedYearsMonthsAndDays(@AniosAcumulados, @MesesAcumulados, @DiasAcumulados)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-10-04
-- Description:	Devuelve la antigüedad expresada en días,
--				de una Persona en el último Cargo tomando como referencia la fecha hasta
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetPersonaAntiguedadEnCargoDias') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetPersonaAntiguedadEnCargoDias
GO

CREATE FUNCTION udf_GetPersonaAntiguedadEnCargoDias
(
	@IDPersona int,
	@FechaHasta date
) RETURNS int AS
BEGIN
	DECLARE @FechaInicioEnCargo date

	SET @FechaInicioEnCargo = dbo.udf_GetPersonaUltimaFechaAscenso(@IDPersona, @FechaHasta)

	RETURN (
		SELECT SUM(DATEDIFF(DAY, (CASE WHEN AltaFecha < @FechaInicioEnCargo THEN @FechaInicioEnCargo ELSE AltaFecha END), ISNULL(BajaFecha, @FechaHasta)))
			FROM PersonaAltaBaja
			WHERE IDPersona = @IDPersona
				AND AltaFecha <= @FechaHasta
				AND (BajaFecha IS NULL OR BajaFecha > @FechaInicioEnCargo)
			)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-10-04
-- Description:	Devuelve la antigüedad expresada en años, meses y días,
--				de una Persona en el último Cargo tomando como referencia la fecha hasta
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetPersonaAntiguedadEnCargoLeyenda') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetPersonaAntiguedadEnCargoLeyenda
GO

CREATE FUNCTION udf_GetPersonaAntiguedadEnCargoLeyenda
(
	@IDPersona int,
	@FechaHasta date
) RETURNS varchar(100) AS
BEGIN
	DECLARE @FechaAlta date
	DECLARE @FechaBaja date
	DECLARE @FechaInicioEnCargo date

	DECLARE @AniosAcumulados smallint = 0
	DECLARE @MesesAcumulados smallint = 0
	DECLARE @DiasAcumulados smallint = 0

	IF @FechaHasta IS NULL
		SET @FechaHasta = GETDATE()

	SET @FechaInicioEnCargo = dbo.udf_GetPersonaUltimaFechaAscenso(@IDPersona, @FechaHasta)

	DECLARE AltaBajaCursor CURSOR LOCAL FORWARD_ONLY STATIC FOR 
		SELECT (CASE WHEN AltaFecha < @FechaInicioEnCargo THEN @FechaInicioEnCargo ELSE AltaFecha END) AS FechaAlta, ISNULL(BajaFecha, @FechaHasta) AS FechaBaja
			FROM PersonaAltaBaja
			WHERE IDPersona = @IDPersona
				AND AltaFecha <= @FechaHasta
				AND (BajaFecha IS NULL OR BajaFecha > @FechaInicioEnCargo)

	OPEN AltaBajaCursor
	FETCH NEXT FROM AltaBajaCursor INTO @FechaAlta, @FechaBaja

	WHILE @@FETCH_STATUS = 0
	BEGIN
		SELECT @AniosAcumulados = @AniosAcumulados + Years, @MesesAcumulados = @MesesAcumulados + Months, @DiasAcumulados = @DiasAcumulados + [Days]
			FROM dbo.udf_GetElapsedYearsMonthsAndDaysFromDatesAsTable(@FechaAlta, @FechaBaja)

		FETCH NEXT FROM AltaBajaCursor INTO @FechaAlta, @FechaBaja
	END

	CLOSE AltaBajaCursor

	DEALLOCATE AltaBajaCursor

	IF @DiasAcumulados >= 30
		BEGIN
		SET @MesesAcumulados = @MesesAcumulados + (@DiasAcumulados / 30)
		SET @DiasAcumulados = (@DiasAcumulados % 30)
		END

	IF @MesesAcumulados >= 12
		BEGIN
		SET @AniosAcumulados = @AniosAcumulados + (@MesesAcumulados / 12)
		SET @MesesAcumulados = (@MesesAcumulados % 12)
		END

	RETURN dbo.udf_FormatElapsedYearsMonthsAndDays(@AniosAcumulados, @MesesAcumulados, @DiasAcumulados)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-04-19
-- Description:	Devuelve las Categorías de Licencia de Conducir para una Persona
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetPersonaLicenciaConducirCategorias') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetPersonaLicenciaConducirCategorias
GO

CREATE FUNCTION udf_GetPersonaLicenciaConducirCategorias
(
	@IDPersona int
) RETURNS varchar(MAX) AS
BEGIN
	DECLARE @ReturnValue varchar(MAX)

	SELECT @ReturnValue =
	STUFF((SELECT ', ' + LCC.Codigo
			FROM LicenciaConducirCategoria AS LCC INNER JOIN PersonaLicenciaConducirCategoria AS PLCC ON LCC.IDLicenciaConducirCategoria = PLCC.IDLicenciaConducirCategoria
			WHERE PLCC.IDPersona = P.IDPersona
			ORDER BY LCC.Codigo
			FOR XML PATH('')), 1, 2, '')
	FROM Persona AS P
	WHERE P.IDPersona = @IDPersona

	RETURN @ReturnValue
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-03
-- Description:	Devuelve el nombre de la Clave de un Siniestro
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetNombreClaveSiniestro') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetNombreClaveSiniestro
GO

CREATE FUNCTION udf_GetNombreClaveSiniestro
(	
	@Clave char(2)
) RETURNS varchar(12) AS
BEGIN
	RETURN (CASE 
				WHEN @Clave = 'V' THEN 'Verde'
				WHEN @Clave = 'A' THEN 'Azul'
				WHEN @Clave = 'AV' THEN 'Azul / Verde'
				WHEN @Clave = 'N' THEN 'Naranja'
				WHEN @Clave = 'R' THEN 'Roja'
				ELSE 'Desconocida'
			END)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-03
-- Description:	Devuelve el nombre en plural de la Clave de un Siniestro
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetNombreClaveSiniestroPlural') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetNombreClaveSiniestroPlural
GO

CREATE FUNCTION udf_GetNombreClaveSiniestroPlural
(	
	@Clave char(2)
) RETURNS varchar(15) AS
BEGIN
	RETURN (CASE 
				WHEN @Clave = 'V' THEN 'Verdes'
				WHEN @Clave = 'A' THEN 'Azules'
				WHEN @Clave = 'AV' THEN 'Azules / Verdes'
				WHEN @Clave = 'N' THEN 'Naranjas'
				WHEN @Clave = 'R' THEN 'Rojas'
				ELSE 'Desconocidas'
			END)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-03
-- Description:	Devuelve la Clave de un Siniestro juntando las verdes y azules
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetClaveSiniestroAgrupada') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetClaveSiniestroAgrupada
GO

CREATE FUNCTION udf_GetClaveSiniestroAgrupada
(	
	@Clave char(1)
) RETURNS char(2) AS
BEGIN
	RETURN (CASE 
				WHEN @Clave = 'V' THEN 'AV'
				WHEN @Clave = 'A' THEN 'AV'
				WHEN @Clave = 'N' THEN 'N'
				WHEN @Clave = 'R' THEN 'R'
				ELSE ''
			END)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-03
-- Description:	Devuelve el nombre de la Clave de un Siniestro juntando las verdes y azules
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetNombreClaveSiniestroAgrupada') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetNombreClaveSiniestroAgrupada
GO

CREATE FUNCTION udf_GetNombreClaveSiniestroAgrupada
(	
	@Clave char(1)
) RETURNS varchar(12) AS
BEGIN
	RETURN dbo.udf_GetNombreClaveSiniestro(dbo.udf_GetClaveSiniestroAgrupada(@Clave))
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-03
-- Description:	Devuelve el nombre en plural de la Clave de un Siniestro juntando las verdes y azules
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetNombreClaveSiniestroAgrupadaPlural') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetNombreClaveSiniestroAgrupadaPlural
GO

CREATE FUNCTION udf_GetNombreClaveSiniestroAgrupadaPlural
(	
	@Clave char(2)
) RETURNS varchar(15) AS
BEGIN
	RETURN dbo.udf_GetNombreClaveSiniestroPlural(dbo.udf_GetClaveSiniestroAgrupada(@Clave))
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-03
-- Description:	Devuelve el puntaje de Presente para una fecha de Siniestro
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetPuntajeClaveSiniestro') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetPuntajeClaveSiniestro
GO

CREATE FUNCTION udf_GetPuntajeClaveSiniestro
(	
	@Clave char(1),
	@Fecha date
) RETURNS tinyint AS
BEGIN

	DECLARE @IDSiniestroAsistenciaTipo tinyint

	SELECT @IDSiniestroAsistenciaTipo = NumeroEntero
		FROM Parametro
		WHERE IDParametro = 'SINIESTRO_ASISTENCIATIPO_PRESENTE_ID'

	RETURN (SELECT TOP 1 (CASE @Clave WHEN 'V' THEN PuntajeClaveVerde WHEN 'A' THEN PuntajeClaveAzul WHEN 'N' THEN PuntajeClaveNaranja WHEN 'R' THEN PuntajeClaveRoja ELSE 0 END)
		FROM SiniestroAsistenciaTipoPuntaje
		WHERE IDSiniestroAsistenciaTipo = @IDSiniestroAsistenciaTipo AND FechaInicio <= @Fecha
		ORDER BY FechaInicio DESC)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-08
-- Description:	Devuelve el porcentaje de descuento por salida anticipada de Presente para una fecha de Siniestro
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.udf_GetPorcentajeDescuentoSiniestro') AND type = N'FN')
	DROP FUNCTION dbo.udf_GetPorcentajeDescuentoSiniestro
GO

CREATE FUNCTION udf_GetPorcentajeDescuentoSiniestro
(	
	@Clave char(1),
	@Fecha date
) RETURNS tinyint AS
BEGIN

	DECLARE @IDSiniestroAsistenciaTipo tinyint

	SELECT @IDSiniestroAsistenciaTipo = NumeroEntero
		FROM Parametro
		WHERE IDParametro = 'SINIESTRO_ASISTENCIATIPO_PRESENTE_ID'

	RETURN (SELECT TOP 1 PorcentajeDescuentoPorSalidaAnticipada
		FROM SiniestroAsistenciaTipoPuntaje
		WHERE IDSiniestroAsistenciaTipo = @IDSiniestroAsistenciaTipo AND FechaInicio <= @Fecha
		ORDER BY FechaInicio DESC)
END
GO