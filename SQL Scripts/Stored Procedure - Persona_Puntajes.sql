USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Creation date: 2021-11-06
-- Description:	Devuelve los puntajes de siniestros de las Personas
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Personas_Puntajes') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Personas_Puntajes
GO

CREATE PROCEDURE usp_Personas_Puntajes
	@IDCuartel tinyint,
	@FechaDesde date,
	@FechaHasta date
	AS
BEGIN

	DECLARE @IDSiniestroAsistenciaTipo tinyint
	DECLARE @SiniestrosPuntajes table (IDSiniestro int not null PRIMARY KEY, Puntaje tinyint null, PorcentajeDescuentoPorSalidaAnticipada tinyint)
	DECLARE @SiniestrosPorClave table (Clave char(2) not null PRIMARY KEY, Cantidad int not null, Puntaje int not null)
	DECLARE @PersonasPuntajesPorClave table (IDPersona int not null, Clave char(2) not null, Cantidad int not null, Puntaje int not null, PRIMARY KEY (IDPersona, Clave))
	DECLARE @ResultadoFinal table (IDPersona int not null PRIMARY KEY, ClaveVACantidad int, ClaveVAPuntaje int, ClaveNCantidad int, ClaveNPuntaje int, ClaveRCantidad int, ClaveRPuntaje int)
	DECLARE @CantidadVA int, @CantidadN int, @CantidadR int
	DECLARE @PuntajeVA int, @PuntajeN int, @PuntajeR int

	-- OBTENGO EL ID DEL TIPO DE ASISTENCIA "PRESENTE" A SINIESTROS
	SELECT @IDSiniestroAsistenciaTipo = NumeroEntero
		FROM Parametro
		WHERE IDParametro = 'SINIESTRO_ASISTENCIATIPO_PRESENTE_ID'

	-- ASIGNO LOS PUNTAJES A CADA SINIESTRO
	INSERT INTO @SiniestrosPuntajes
		(IDSiniestro, Puntaje, PorcentajeDescuentoPorSalidaAnticipada)
		SELECT IDSiniestro, dbo.udf_GetPuntajeClaveSiniestro(Clave, Fecha), dbo.udf_GetPorcentajeDescuentoSiniestro(Clave, Fecha)
			FROM Siniestro
			WHERE Anulado = 0
				AND IDCuartel = @IDCuartel
				AND Fecha BETWEEN @FechaDesde AND @FechaHasta

	-- CALCULO LA CANTIDAD DE SINIESTROS Y PUNTAJE TOTAL POR CLAVE
	INSERT INTO @SiniestrosPorClave
		(Clave, Cantidad, Puntaje)
		SELECT dbo.udf_GetClaveSiniestroAgrupada(s.Clave), COUNT(s.IDSiniestro) AS Cantidad, SUM(sp.Puntaje) AS Puntaje
			FROM Siniestro AS s
				INNER JOIN @SiniestrosPuntajes AS sp ON s.IDSiniestro = sp.IDSiniestro
			GROUP BY dbo.udf_GetClaveSiniestroAgrupada(s.Clave)

	-- OBTENGO LOS VALORES DE CANTIDAD DE SINIESTROS POR CLAVE
	SELECT @CantidadVA = AV, @CantidadN = N, @CantidadR = R
	FROM
		(SELECT Clave, Cantidad
			FROM @SiniestrosPorClave) src
		PIVOT
		(MAX(Cantidad)
			FOR Clave IN (AV, N, R)
		) piv

	-- OBTENGO EL PUNTAJE TOTAL
	SELECT @PuntajeVA = AV, @PuntajeN = N, @PuntajeR = R
	FROM
		(SELECT Clave, Puntaje
			FROM @SiniestrosPorClave) src
		PIVOT
		(MAX(Puntaje)
			FOR Clave IN (AV, N, R)
		) piv

	-- SELECCIONO LAS PERSONAS ACTIVAS A LA FECHA HASTA
	INSERT INTO @ResultadoFinal
		(IDPersona)
		SELECT p.IDPersona
			FROM Persona AS p
				INNER JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
			WHERE p.EsActivo = 1
				AND p.IDCuartel = @IDCuartel
				AND pab.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(p.IDPersona, @FechaHasta)
				AND pab.BajaFecha IS NULL

	-- CALCULO LOS PUNTAJES POR CLAVE PARA CADA PERSONA
	INSERT INTO @PersonasPuntajesPorClave
		(IDPersona, Clave, Cantidad, Puntaje)
		SELECT rf.IDPersona, dbo.udf_GetClaveSiniestroAgrupada(s.Clave) AS Clave, COUNT(sa.IDPersona), ISNULL(SUM(dbo.udf_GetPuntajeClaveSiniestro(s.Clave, s.Fecha)), 0)
			FROM @ResultadoFinal AS rf
				LEFT JOIN (SiniestroAsistencia AS sa
				INNER JOIN Siniestro AS s ON sa.IDSiniestro = s.IDSiniestro
				INNER JOIN @SiniestrosPuntajes AS sp ON sa.IDSiniestro = sp.IDSiniestro) ON rf.IDPersona = sa.IDPersona
			GROUP BY rf.IDPersona, dbo.udf_GetClaveSiniestroAgrupada(s.Clave)

	-- INSERTO LOS RESULTADOS PARA LAS CLAVES VERDES Y AZULES
	UPDATE @ResultadoFinal
		SET ClaveVACantidad = Cantidad, ClaveVAPuntaje = Puntaje
			FROM @PersonasPuntajesPorClave AS pppc
				INNER JOIN @ResultadoFinal AS rf ON pppc.IDPersona = rf.IDPersona
			WHERE Clave = 'AV'

	-- ACTUALIZO LOS RESULTADOS PARA LA CLAVE NARANJA
	UPDATE @ResultadoFinal
		SET ClaveNCantidad = Cantidad, ClaveNPuntaje = Puntaje
			FROM @PersonasPuntajesPorClave AS pppc
				INNER JOIN @ResultadoFinal AS rf ON pppc.IDPersona = rf.IDPersona
			WHERE Clave = 'N'

	-- ACTUALIZO LOS RESULTADOS PARA LA CLAVE ROJA
	UPDATE @ResultadoFinal
		SET ClaveRCantidad = Cantidad, ClaveRPuntaje = Puntaje
			FROM @PersonasPuntajesPorClave AS pppc
				INNER JOIN @ResultadoFinal AS rf ON pppc.IDPersona = rf.IDPersona
			WHERE Clave = 'R'

	-- SELECCIONO LAS PERSONAS Y LOS PUNTAJES DE CADA SINIESTRO
	SELECT ISNULL(p.Orden, 0) AS Orden, p.MatriculaNumero, UPPER(p.ApellidoNombre) AS ApellidoNombre, @PuntajeVA + @PuntajeN + @PuntajeR AS PuntajeTotal, @CantidadVA AS ClaveVACantidadTotal, ISNULL(ClaveVACantidad, 0) AS ClaveVACantidad, ISNULL(ClaveVAPuntaje, 0) AS ClaveVAPuntaje, @CantidadN AS ClaveNCantidadTotal, ISNULL(ClaveNCantidad, 0) AS ClaveNCantidad, ISNULL(ClaveNPuntaje, 0) AS ClaveNPuntaje, @CantidadR AS ClaveRCantidadTotal, ISNULL(ClaveRCantidad, 0) AS ClaveRCantidad, ISNULL(ClaveRPuntaje, 0) AS ClaveRPuntaje, (CAST(ISNULL(ClaveVAPuntaje, 0) + ISNULL(ClaveNPuntaje, 0) + ISNULL(ClaveRPuntaje, 0) AS decimal) / (@PuntajeVA + @PuntajeN + @PuntajeR)) AS ProporcionPuntaje
		FROM @ResultadoFinal AS rf
			INNER JOIN Persona AS p ON rf.IDPersona = p.IDPersona
		ORDER BY ISNULL(ClaveVAPuntaje, 0) + ISNULL(ClaveNPuntaje, 0) + ISNULL(ClaveRPuntaje, 0) DESC, p.ApellidoNombre
END
GO