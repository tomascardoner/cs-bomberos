USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Creation date: 2021-11-06
-- Updates: 2021-11-21 - Actualizado a las nuevas funciones y tablas
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

	DECLARE @IDSiniestroAsistenciaTipoPresente tinyint, @IDSiniestroAsistenciaTipoSalidaAnticipada tinyint
	DECLARE @SiniestrosPuntajes table (IDSiniestro int not null, IDSiniestroAsistenciaTipo tinyint not null, IDSiniestroAsistenciaTipoPuntaje tinyint null, Puntaje decimal(4,2) null, PRIMARY KEY (IDSiniestro, IDSiniestroAsistenciaTipo))
	DECLARE @SiniestrosPorClave table (Clave char(2) not null PRIMARY KEY, Cantidad int not null, Puntaje decimal(8,2) not null)
	DECLARE @PersonasPuntajesPorClave table (IDPersona int not null, Clave char(2) not null, Cantidad int not null, Puntaje decimal(8,2) not null, PRIMARY KEY (IDPersona, Clave))
	DECLARE @ResultadoFinal table (IDPersona int not null PRIMARY KEY, ClaveVACantidad int, ClaveVAPuntaje decimal(8,2), ClaveNCantidad int, ClaveNPuntaje decimal(8,2), ClaveRCantidad int, ClaveRPuntaje decimal(8,2))
	DECLARE @CantidadVA int, @CantidadN int, @CantidadR int
	DECLARE @PuntajeVA decimal(8,2), @PuntajeN decimal(8,2), @PuntajeR decimal(8,2)

	-- OBTENGO EL ID DEL TIPO DE ASISTENCIA "PRESENTE" A SINIESTROS
	SELECT @IDSiniestroAsistenciaTipoPresente = NumeroEntero
		FROM Parametro
		WHERE IDParametro = 'SINIESTRO_ASISTENCIATIPO_PRESENTE_ID'

	-- OBTENGO EL ID DEL TIPO DE ASISTENCIA "PRESENTE CON SALIDA ANTICIPADA" A SINIESTROS
	SELECT @IDSiniestroAsistenciaTipoSalidaAnticipada = NumeroEntero
		FROM Parametro
		WHERE IDParametro = 'SINIESTRO_ASISTENCIATIPO_SALIDAANTICIPADA_ID'

	-- AGREGO EL ID DEL PUNTAJE VIGENTE A LA FECHA DE CADA SINIESTRO PARA PRESENTE
	INSERT INTO @SiniestrosPuntajes
		(IDSiniestro, IDSiniestroAsistenciaTipo, IDSiniestroAsistenciaTipoPuntaje)
		SELECT s.IDSiniestro, @IDSiniestroAsistenciaTipoPresente, dbo.SiniestroObtenerIdPuntajeClave(@IDSiniestroAsistenciaTipoPresente, s.Clave, s.Fecha)
			FROM Siniestro AS s
			WHERE s.Anulado = 0
				AND s.IDCuartel = @IDCuartel
				AND s.Fecha BETWEEN @FechaDesde AND @FechaHasta

	-- ASIGNO EL ID DEL PUNTAJE VIGENTE A LA FECHA DE CADA SINIESTRO PARA SALIDA ANTICIPADA
	INSERT INTO @SiniestrosPuntajes
		(IDSiniestro, IDSiniestroAsistenciaTipo, IDSiniestroAsistenciaTipoPuntaje)
		SELECT s.IDSiniestro, @IDSiniestroAsistenciaTipoSalidaAnticipada, dbo.SiniestroObtenerIdPuntajeClave(@IDSiniestroAsistenciaTipoSalidaAnticipada, s.Clave, s.Fecha)
			FROM Siniestro AS s
			WHERE s.Anulado = 0
				AND s.IDCuartel = @IDCuartel
				AND s.Fecha BETWEEN @FechaDesde AND @FechaHasta

	-- ASIGNO LOS PUNTAJES CORRESPONDIENTES
	UPDATE @SiniestrosPuntajes
		SET Puntaje = (CASE s.Clave WHEN 'V' THEN PuntajeClaveVerde WHEN 'A' THEN PuntajeClaveAzul WHEN 'N' THEN PuntajeClaveNaranja WHEN 'R' THEN PuntajeClaveRoja ELSE 0 END)
		FROM Siniestro AS s
			INNER JOIN @SiniestrosPuntajes AS sp ON s.IDSiniestro = sp.IDSiniestro
			INNER JOIN SiniestroAsistenciaTipoPuntaje AS satp ON sp.IDSiniestroAsistenciaTipo = satp.IDSiniestroAsistenciaTipo AND sp.IDSiniestroAsistenciaTipoPuntaje = satp.IDSiniestroAsistenciaTipoPuntaje

	-- CALCULO LA CANTIDAD DE SINIESTROS Y PUNTAJE TOTAL DE PRESENTE POR CLAVE
	INSERT INTO @SiniestrosPorClave
		(Clave, Cantidad, Puntaje)
		SELECT dbo.SiniestroObtenerClaveAgrupada(s.Clave), COUNT(s.IDSiniestro) AS Cantidad, SUM(sp.Puntaje) AS Puntaje
			FROM Siniestro AS s
				INNER JOIN @SiniestrosPuntajes AS sp ON s.IDSiniestro = sp.IDSiniestro
			WHERE sp.IDSiniestroAsistenciaTipo = @IDSiniestroAsistenciaTipoPresente
			GROUP BY dbo.SiniestroObtenerClaveAgrupada(s.Clave)

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
				AND pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, @FechaHasta)
				AND pab.Tipo = 'A'

	-- CALCULO LOS PUNTAJES POR CLAVE PARA CADA PERSONA
	INSERT INTO @PersonasPuntajesPorClave
		(IDPersona, Clave, Cantidad, Puntaje)
		SELECT rf.IDPersona, dbo.SiniestroObtenerClaveAgrupada(s.Clave) AS Clave, COUNT(sa.IDPersona), ISNULL(SUM(sp.Puntaje), 0)
			FROM @ResultadoFinal AS rf
				LEFT JOIN (SiniestroAsistencia AS sa
				INNER JOIN Siniestro AS s ON sa.IDSiniestro = s.IDSiniestro
				INNER JOIN @SiniestrosPuntajes AS sp ON sa.IDSiniestro = sp.IDSiniestro AND sa.IDSiniestroAsistenciaTipo = sp.IDSiniestroAsistenciaTipo) ON rf.IDPersona = sa.IDPersona
			GROUP BY rf.IDPersona, dbo.SiniestroObtenerClaveAgrupada(s.Clave)

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
	SELECT ISNULL(p.Orden, 0) AS Orden, p.MatriculaNumero, UPPER(p.ApellidoNombre) AS ApellidoNombre, @PuntajeVA + @PuntajeN + @PuntajeR AS PuntajeTotal,
			@CantidadVA AS ClaveVACantidadTotal, ISNULL(ClaveVACantidad, 0) AS ClaveVACantidad, ISNULL(ClaveVAPuntaje, 0) AS ClaveVAPuntaje, @CantidadN AS ClaveNCantidadTotal,
			ISNULL(ClaveNCantidad, 0) AS ClaveNCantidad, ISNULL(ClaveNPuntaje, 0) AS ClaveNPuntaje, @CantidadR AS ClaveRCantidadTotal, ISNULL(ClaveRCantidad, 0) AS ClaveRCantidad,
			ISNULL(ClaveRPuntaje, 0) AS ClaveRPuntaje,
			(CAST(ISNULL(ClaveVAPuntaje, 0) + ISNULL(ClaveNPuntaje, 0) + ISNULL(ClaveRPuntaje, 0) AS decimal) / (@PuntajeVA + @PuntajeN + @PuntajeR)) AS ProporcionPuntaje
		FROM @ResultadoFinal AS rf
			INNER JOIN Persona AS p ON rf.IDPersona = p.IDPersona
		ORDER BY ISNULL(ClaveVAPuntaje, 0) + ISNULL(ClaveNPuntaje, 0) + ISNULL(ClaveRPuntaje, 0) DESC, p.ApellidoNombre
END
GO