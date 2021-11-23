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
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerCalificacionAnualFinalAbreviada') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerCalificacionAnualFinalAbreviada
GO

CREATE FUNCTION PersonaObtenerCalificacionAnualFinalAbreviada
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
-- Description:	Devuelve la primera fecha de Alta
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerFechaPrimeraAlta') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerFechaPrimeraAlta
GO

CREATE FUNCTION PersonaObtenerFechaPrimeraAlta
(	
	@IDPersona int
) RETURNS date AS
BEGIN
	RETURN (SELECT MIN(Fecha) FROM PersonaAltaBaja WHERE IDPersona = @IDPersona AND Tipo = 'A')
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-21
-- Description:	Devuelve el ID de la primera Alta
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerIdPrimeraAlta') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerIdPrimeraAlta
GO

CREATE FUNCTION PersonaObtenerIdPrimeraAlta
(	
	@IDPersona int
) RETURNS tinyint AS
BEGIN
	RETURN (SELECT TOP 1 IDAltaBaja FROM PersonaAltaBaja WHERE IDPersona = @IDPersona AND Tipo = 'A' ORDER BY Fecha)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-08
-- Description:	Devuelve la última fecha de Alta
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerFechaUltimaAlta') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerFechaUltimaAlta
GO

CREATE FUNCTION PersonaObtenerFechaUltimaAlta
(	
	@IDPersona int,
	@FechaHasta date
) RETURNS date AS
BEGIN
	RETURN (SELECT MAX(Fecha) FROM PersonaAltaBaja WHERE IDPersona = @IDPersona AND Tipo = 'A' AND Fecha <= ISNULL(@FechaHasta, GETDATE()))
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-21
-- Description:	Devuelve el ID de la última Alta
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerIdUltimaAlta') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerIdUltimaAlta
GO

CREATE FUNCTION PersonaObtenerIdUltimaAlta
(	
	@IDPersona int,
	@FechaHasta date
) RETURNS tinyint AS
BEGIN
	RETURN (SELECT TOP 1 IDAltaBaja FROM PersonaAltaBaja WHERE IDPersona = @IDPersona AND Tipo = 'A' AND Fecha <= ISNULL(@FechaHasta, GETDATE()) ORDER BY Fecha DESC)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2020-10-30
-- Description:	Devuelve la última fecha de Baja
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerFechaUltimaBaja') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerFechaUltimaBaja
GO

CREATE FUNCTION PersonaObtenerFechaUltimaBaja
(	
	@IDPersona int,
	@FechaHasta date
) RETURNS date AS
BEGIN
	RETURN (SELECT MAX(Fecha) FROM PersonaAltaBaja WHERE IDPersona = @IDPersona AND Tipo = 'B' AND Fecha <= ISNULL(@FechaHasta, GETDATE()))
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-21
-- Description:	Devuelve el ID de la última Baja
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerIdUltimaBaja') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerIdUltimaBaja
GO

CREATE FUNCTION PersonaObtenerIdUltimaBaja
(	
	@IDPersona int,
	@FechaHasta date
) RETURNS tinyint AS
BEGIN
	RETURN (SELECT TOP 1 IDAltaBaja FROM PersonaAltaBaja WHERE IDPersona = @IDPersona AND Tipo = 'B' AND Fecha <= ISNULL(@FechaHasta, GETDATE()) ORDER BY Fecha DESC)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-21
-- Description:	Devuelve el ID del Alta o Baja anterior a la última Baja
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerIdAnteriorAUltimaBaja') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerIdAnteriorAUltimaBaja
GO

CREATE FUNCTION PersonaObtenerIdAnteriorAUltimaBaja
(	
	@IDPersona int,
	@FechaHasta date
) RETURNS tinyint AS
BEGIN
	RETURN dbo.PersonaObtenerIdUltimaAltaBaja(@IDPersona, DATEADD(day, -1, dbo.PersonaObtenerFechaUltimaBaja(@IDPersona, NULL)))
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-20
-- Description:	Devuelve el ID de la última Alta o Baja
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerIdUltimaAltaBaja') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerIdUltimaAltaBaja
GO

CREATE FUNCTION PersonaObtenerIdUltimaAltaBaja
(	
	@IDPersona int,
	@FechaHasta date
) RETURNS tinyint AS
BEGIN
	RETURN (
		SELECT TOP 1 IDAltaBaja
			FROM PersonaAltaBaja
			WHERE IDPersona = @IDPersona AND Fecha <= ISNULL(@FechaHasta, GETDATE())
			ORDER BY Fecha DESC, Tipo ASC)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-08
-- Description:	Devuelve la última fecha de Ascenso
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerFechaUltimoAscenso') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerFechaUltimoAscenso
GO

CREATE FUNCTION PersonaObtenerFechaUltimoAscenso
(	
	@IDPersona int,
	@FechaHasta date
) RETURNS date AS
BEGIN
	RETURN (SELECT MAX(Fecha) FROM PersonaAscenso WHERE IDPersona = @IDPersona AND Fecha <= ISNULL(@FechaHasta, GETDATE()))
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-21
-- Description:	Devuelve la jerarquía según la última fecha de Ascenso
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerNombreJerarquiaUltimoAscenso') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerNombreJerarquiaUltimoAscenso
GO

CREATE FUNCTION PersonaObtenerNombreJerarquiaUltimoAscenso
(	
	@IDPersona int,
	@FechaHasta date
) RETURNS varchar(50) AS
BEGIN
	RETURN (SELECT cj.Nombre
				FROM PersonaAscenso AS pa
					INNER JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
					WHERE IDPersona = @IDPersona
						AND Fecha = dbo.PersonaObtenerFechaUltimoAscenso(@IDPersona, @FechaHasta))
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-04-18
-- Description:	Devuelve la última fecha de Licencia
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerFechaUltimaLicencia') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerFechaUltimaLicencia
GO

CREATE FUNCTION PersonaObtenerFechaUltimaLicencia
(	
	@IDPersona int,
	@FechaHasta date
) RETURNS date AS
BEGIN
	RETURN (SELECT MAX(Fecha) FROM PersonaLicencia WHERE IDPersona = @IDPersona AND Fecha <= ISNULL(@FechaHasta, GETDATE()))
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-10-04
-- Updates: 2021-11-21 - Se adaptó a la nueva estructura de la tabla de Altas y Bajas
--			2021-11-22 - Se actualizó para que tome en cuenta el tiempo en Reserva
-- Description:	Devuelve la antigüedad expresada en días,
--				de una Persona desde la FechaDesde hasta FechaHasta
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerAntiguedadEnDias') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerAntiguedadEnDias
GO

CREATE FUNCTION PersonaObtenerAntiguedadEnDias
(
	@IDPersona int,
	@FechaDesde date,
	@FechaHasta date
) RETURNS int AS

BEGIN
	DECLARE @IDPersonaBajaMotivoReserva tinyint = 4
	DECLARE @Dias int = 0
	DECLARE @TipoAnterior char(1), @FechaAnterior date, @IDPersonaBajaMotivoAnterior tinyint
	DECLARE @TipoActual char(1), @FechaActual date, @IDPersonaBajaMotivoActual tinyint

	-- Si está especificada la fecha desde, me fijo si el registro inmediato anterior no es un alta
	IF @FechaDesde IS NOT NULL
		SELECT TOP 1 @TipoAnterior = Tipo, @FechaAnterior = @FechaDesde, @IDPersonaBajaMotivoAnterior = IDPersonaBajaMotivo
			FROM PersonaAltaBaja
			WHERE IDPersona = @IDPersona
				AND Fecha < @FechaDesde
			ORDER BY Fecha DESC, Tipo ASC

	-- Creo un cursor para recorrer los registros
	DECLARE CursorAltasBajas CURSOR LOCAL FORWARD_ONLY STATIC FOR
		SELECT Tipo, Fecha, IDPersonaBajaMotivo
			FROM PersonaAltaBaja
			WHERE IDPersona = @IDPersona
				AND (@FechaDesde IS NULL OR Fecha >= @FechaDesde)
				AND (@FechaHasta IS NULL OR Fecha <= @FechaHasta)
			ORDER BY Fecha, Tipo DESC

	OPEN CursorAltasBajas
	FETCH NEXT FROM CursorAltasBajas INTO @TipoActual, @FechaActual, @IDPersonaBajaMotivoActual

	WHILE @@FETCH_STATUS = 0
		BEGIN
		IF @TipoActual = 'B' AND (@TipoAnterior = 'A' OR @IDPersonaBajaMotivoAnterior = @IDPersonaBajaMotivoReserva)
			SET @Dias = @Dias + DATEDIFF(DAY, @FechaAnterior, @FechaActual)

		SET @TipoAnterior = @TipoActual
		SET @FechaAnterior = @FechaActual
		SET @IDPersonaBajaMotivoAnterior = @IDPersonaBajaMotivoActual

		FETCH NEXT FROM CursorAltasBajas INTO @TipoActual, @FechaActual, @IDPersonaBajaMotivoActual
		END

	-- Si el último registro es un Alta, sumo los días transcurridos hasta la Fecha Hasta
	IF @TipoAnterior = 'A' OR @IDPersonaBajaMotivoAnterior = @IDPersonaBajaMotivoReserva
		SET @Dias = @Dias + DATEDIFF(DAY, @FechaAnterior, ISNULL(@FechaHasta, GETDATE()))

	RETURN @Dias
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-10-04
-- Updates: 2021-11-21 - Se modificó completamente para que utilice la función PersonaObtenerAntiguedadEnDias
-- Description:	Devuelve la antigüedad expresada en años, meses y días,
--				de una Persona desde la FechaDesde hasta FechaHasta
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerAntiguedadEnLetras') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerAntiguedadEnLetras
GO

CREATE FUNCTION PersonaObtenerAntiguedadEnLetras
(
	@IDPersona int,
	@FechaDesde date,
	@FechaHasta date
) RETURNS varchar(100) AS
BEGIN
	RETURN dbo.udf_GetElapsedYearsMonthsAndDaysFromDays(dbo.PersonaObtenerAntiguedadEnDias(@IDPersona, @FechaDesde, @FechaHasta))
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-10-04
-- Description:	Devuelve la antigüedad expresada en días,
--				de una Persona en el último Cargo tomando como referencia la fecha hasta
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerAntiguedadEnElCargoEnDias') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerAntiguedadEnElCargoEnDias
GO

CREATE FUNCTION PersonaObtenerAntiguedadEnElCargoEnDias
(
	@IDPersona int,
	@FechaHasta date
) RETURNS int AS
BEGIN
	DECLARE @FechaInicioEnCargo date

	SET @FechaInicioEnCargo = dbo.PersonaObtenerFechaUltimoAscenso(@IDPersona, @FechaHasta)

	RETURN dbo.PersonaObtenerAntiguedadEnDias(@IDPersona, @FechaInicioEnCargo, @FechaHasta)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-10-04
-- Updates: 2021-11-21 - Se modificó para que utilice la función PersonaObtenerAntiguedadEnElCargoEnDias
-- Description:	Devuelve la antigüedad expresada en años, meses y días,
--				de una Persona en el último Cargo tomando como referencia la fecha hasta
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerAntiguedadEnElCargoEnLetras') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerAntiguedadEnElCargoEnLetras
GO

CREATE FUNCTION PersonaObtenerAntiguedadEnElCargoEnLetras
(
	@IDPersona int,
	@FechaHasta date
) RETURNS varchar(100) AS
BEGIN
	RETURN dbo.udf_GetElapsedYearsMonthsAndDaysFromDays(dbo.PersonaObtenerAntiguedadEnElCargoEnDias(@IDPersona, @FechaHasta))
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2019-04-19
-- Description:	Devuelve las Categorías de Licencia de Conducir para una Persona
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerCategoriasLicenciaConducir') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerCategoriasLicenciaConducir
GO

CREATE FUNCTION PersonaObtenerCategoriasLicenciaConducir
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
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.SiniestroObtenerNombreClave') AND type = N'FN')
	DROP FUNCTION dbo.SiniestroObtenerNombreClave
GO

CREATE FUNCTION SiniestroObtenerNombreClave
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
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.SiniestroObtenerNombreClaveEnPlural') AND type = N'FN')
	DROP FUNCTION dbo.SiniestroObtenerNombreClaveEnPlural
GO

CREATE FUNCTION SiniestroObtenerNombreClaveEnPlural
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
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.SiniestroObtenerClaveAgrupada') AND type = N'FN')
	DROP FUNCTION dbo.SiniestroObtenerClaveAgrupada
GO

CREATE FUNCTION SiniestroObtenerClaveAgrupada
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
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.SiniestroObtenerNombreClaveAgrupada') AND type = N'FN')
	DROP FUNCTION dbo.SiniestroObtenerNombreClaveAgrupada
GO

CREATE FUNCTION SiniestroObtenerNombreClaveAgrupada
(	
	@Clave char(1)
) RETURNS varchar(12) AS
BEGIN
	RETURN dbo.SiniestroObtenerNombreClave(dbo.SiniestroObtenerClaveAgrupada(@Clave))
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-03
-- Description:	Devuelve el nombre en plural de la Clave de un Siniestro juntando las verdes y azules
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.SiniestroObtenerNombreClaveAgrupadaEnPlural') AND type = N'FN')
	DROP FUNCTION dbo.SiniestroObtenerNombreClaveAgrupadaEnPlural
GO

CREATE FUNCTION SiniestroObtenerNombreClaveAgrupadaEnPlural
(	
	@Clave char(2)
) RETURNS varchar(15) AS
BEGIN
	RETURN dbo.SiniestroObtenerNombreClaveEnPlural(dbo.SiniestroObtenerClaveAgrupada(@Clave))
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-17
-- Description:	Devuelve el id del puntaje para una fecha de Siniestro
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.SiniestroObtenerIdPuntajeClave') AND type = N'FN')
	DROP FUNCTION dbo.SiniestroObtenerIdPuntajeClave
GO

CREATE FUNCTION SiniestroObtenerIdPuntajeClave
(
	@IDSiniestroAsistenciaTipo tinyint,
	@Clave char(1),
	@Fecha date
) RETURNS tinyint AS
BEGIN

	RETURN (SELECT TOP 1 IDSiniestroAsistenciaTipoPuntaje
		FROM SiniestroAsistenciaTipoPuntaje
		WHERE IDSiniestroAsistenciaTipo = @IDSiniestroAsistenciaTipo AND FechaInicio <= @Fecha
		ORDER BY FechaInicio DESC)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-21
-- Description:	Devuelve el estado de la persona
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerEstado') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerEstado
GO

CREATE FUNCTION PersonaObtenerEstado
(	
	@Tipo char(1),
	@BajaMotivo varchar(50)
) RETURNS varchar(50) AS
BEGIN
	DECLARE @EstadoActivo varchar(6) = 'Activo'
	DECLARE @EstadoBaja varchar(17) = 'Baja (sin motivo)'
	DECLARE @EstadoDesconocido varchar(13) = '«Desconocido»'

	RETURN (CASE @Tipo WHEN 'A' THEN @EstadoActivo WHEN 'B' THEN ISNULL(@BajaMotivo, @EstadoBaja) ELSE @EstadoDesconocido END)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-21
-- Description:	Devuelve si la persona tiene estado activo
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerSiEstadoEsActivo') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerSiEstadoEsActivo
GO

CREATE FUNCTION PersonaObtenerSiEstadoEsActivo
(	
	@Tipo char(1)
) RETURNS bit AS
BEGIN
	RETURN (CASE @Tipo WHEN 'A' THEN 1 ELSE 0 END)
END
GO



-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2021-11-21
-- Description:	Devuelve el motivo de baja de la persona
-- =============================================
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.PersonaObtenerIdBajaMotivo') AND type = N'FN')
	DROP FUNCTION dbo.PersonaObtenerIdBajaMotivo
GO

CREATE FUNCTION PersonaObtenerIdBajaMotivo
(	
	@Tipo char(1),
	@IDBajaMotivo tinyint
) RETURNS tinyint AS
BEGIN
	RETURN (CASE @Tipo WHEN 'A' THEN 0 WHEN 'B' THEN ISNULL(@IDBajaMotivo, 255) ELSE NULL END)
END
GO