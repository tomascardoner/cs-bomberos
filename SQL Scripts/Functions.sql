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
	DECLARE @Result varchar(2)

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