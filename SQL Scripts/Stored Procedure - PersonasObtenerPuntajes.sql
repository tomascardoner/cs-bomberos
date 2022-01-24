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
--			2021-12-07 - Bug fixes
--          2022-01-23 - Se agregaron los servicios especiales y las claves naranjas al 50%
-- Description:	Devuelve los puntajes de siniestros y academias de las Personas
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'uspPersonasObtenerPuntajes') AND type in (N'P', N'PC'))
	 DROP PROCEDURE uspPersonasObtenerPuntajes
GO

CREATE PROCEDURE uspPersonasObtenerPuntajes
	@IDCuartel tinyint,
	@FechaDesde date,
	@FechaHasta date
	AS
BEGIN
	-- Declaraciones comunes
	DECLARE @ResultadoFinal table (IDPersona int not null PRIMARY KEY, SiniestrosClaveVACantidad int, SiniestrosClaveVAPuntaje decimal(8,2), SiniestrosClaveSPCantidad int, SiniestrosClaveSPPuntaje decimal(8,2), SiniestrosClaveN100Cantidad int, SiniestrosClaveN100Puntaje decimal(8,2), SiniestrosClaveN50Cantidad int, SiniestrosClaveN50Puntaje decimal(8,2), SiniestrosClaveR100Cantidad int, SiniestrosClaveR100Puntaje decimal(8,2), SiniestrosClaveR50Cantidad int, SiniestrosClaveR50Puntaje decimal(8,2), AcademiasPCantidad int, AcademiasPPuntaje decimal(8,2), AcademiasFHCantidad int, AcademiasFHPuntaje decimal(8,2))

	-- Declaraciones para los siniestros
	DECLARE @IDSiniestroAsistenciaTipoPresente tinyint, @IDSiniestroAsistenciaTipoSalidaAnticipada tinyint
	DECLARE @SiniestrosPuntajes table (IDSiniestro int not null, IDSiniestroAsistenciaTipo tinyint not null, IDSiniestroAsistenciaTipoPuntaje tinyint null, Puntaje decimal(4,2) null, PRIMARY KEY (IDSiniestro, IDSiniestroAsistenciaTipo))
	DECLARE @SiniestrosPorClave table (Clave char(2) not null PRIMARY KEY, Cantidad int not null, Puntaje decimal(8,2) not null)
	DECLARE @SiniestrosPersonasPuntajesPorClave table (IDPersona int not null, Clave char(2) not null, Cantidad int not null, Puntaje decimal(8,2) not null, PRIMARY KEY (IDPersona, Clave))
	DECLARE @SiniestrosCantidadVA int, @SiniestrosCantidadSP int, @SiniestrosCantidadN int, @SiniestrosCantidadR int
	DECLARE @SiniestrosPuntajeVA decimal(8,2), @SiniestrosPuntajeSP decimal(8,2), @SiniestrosPuntajeN decimal(8,2), @SiniestrosPuntajeR decimal(8,2)

	-- Declaraciones para las academias
	DECLARE @IDAcademiaAsistenciaTipoPresente tinyint, @IDAcademiaAsistenciaTipoFueraHora tinyint
	DECLARE @AcademiasPuntajes table (IDAcademia int not null, IDAcademiaAsistenciaTipo tinyint not null, IDAcademiaAsistenciaTipoPuntaje tinyint null, Puntaje decimal(4,2) null, PRIMARY KEY (IDAcademia, IDAcademiaAsistenciaTipo))
	DECLARE @AcademiasPersonasPuntajesPorClave table (IDPersona int not null, Clave char(2) not null, Cantidad int not null, Puntaje decimal(8,2) not null, PRIMARY KEY (IDPersona, Clave))
	DECLARE @AcademiasCantidad int
	DECLARE @AcademiasPuntaje decimal(8,2)

	-- Común: obtengo las personas del cuerpo activo a la fecha hasta
	INSERT INTO @ResultadoFinal
		(IDPersona)
		SELECT p.IDPersona
			FROM Persona AS p
				INNER JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
			WHERE p.EsActivo = 1
				AND p.IDCuartel = @IDCuartel
				AND pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, @FechaHasta)
				AND pab.Tipo = 'A'

	-- Siniestros: obtengo el id del tipo de asistencia "Presente"
	SELECT @IDSiniestroAsistenciaTipoPresente = NumeroEntero
		FROM Parametro
		WHERE IDParametro = 'SINIESTRO_ASISTENCIATIPO_PRESENTE_ID'

	-- Siniestros: obtengo el id del tipo de asistencia "Salida anticipada"
	SELECT @IDSiniestroAsistenciaTipoSalidaAnticipada = NumeroEntero
		FROM Parametro
		WHERE IDParametro = 'SINIESTRO_ASISTENCIATIPO_SALIDAANTICIPADA_ID'

	-- Siniestros: agrego el id del puntaje por "Presente" vigente a la fecha de cada siniestro
	INSERT INTO @SiniestrosPuntajes
		(IDSiniestro, IDSiniestroAsistenciaTipo, IDSiniestroAsistenciaTipoPuntaje)
		SELECT s.IDSiniestro, @IDSiniestroAsistenciaTipoPresente, dbo.SiniestroObtenerIdPuntaje(@IDSiniestroAsistenciaTipoPresente, s.Fecha)
			FROM Siniestro AS s
			WHERE s.Anulado = 0
				AND s.IDCuartel = @IDCuartel
				AND s.Fecha BETWEEN @FechaDesde AND @FechaHasta

	-- Siniestros: agrego el id del puntaje por "Salida anticipada" vigente a la fecha de cada siniestro
	INSERT INTO @SiniestrosPuntajes
		(IDSiniestro, IDSiniestroAsistenciaTipo, IDSiniestroAsistenciaTipoPuntaje)
		SELECT s.IDSiniestro, @IDSiniestroAsistenciaTipoSalidaAnticipada, dbo.SiniestroObtenerIdPuntaje(@IDSiniestroAsistenciaTipoSalidaAnticipada, s.Fecha)
			FROM Siniestro AS s
			WHERE s.Anulado = 0
				AND s.IDCuartel = @IDCuartel
				AND s.Fecha BETWEEN @FechaDesde AND @FechaHasta

	-- Siniestros: asigno los puntajes correspondientes a cada siniestro
	UPDATE @SiniestrosPuntajes
		SET Puntaje = satpc.Puntaje
		FROM Siniestro AS s
			INNER JOIN @SiniestrosPuntajes AS sp ON s.IDSiniestro = sp.IDSiniestro
			INNER JOIN SiniestroAsistenciaTipoPuntajeClave AS satpc ON sp.IDSiniestroAsistenciaTipo = satpc.IDSiniestroAsistenciaTipo AND sp.IDSiniestroAsistenciaTipoPuntaje = satpc.IDSiniestroAsistenciaTipoPuntaje AND s.IDSiniestroClave = satpc.IDSiniestroClave

	-- Siniestros: calculo la cantidad de siniestros y el puntaje total de cada clave
	INSERT INTO @SiniestrosPorClave
		(Clave, Cantidad, Puntaje)
		SELECT dbo.SiniestroObtenerClaveAgrupada(s.IDSiniestroClave), COUNT(s.IDSiniestro) AS Cantidad, ISNULL(SUM(sp.Puntaje), 0) AS Puntaje
			FROM Siniestro AS s
				INNER JOIN @SiniestrosPuntajes AS sp ON s.IDSiniestro = sp.IDSiniestro
			WHERE sp.IDSiniestroAsistenciaTipo = @IDSiniestroAsistenciaTipoPresente
			GROUP BY dbo.SiniestroObtenerClaveAgrupada(s.IDSiniestroClave)

	-- Siniestros: asigno las cantidades de siniestros por cada clave a las variables
	SELECT @SiniestrosCantidadVA = AV, @SiniestrosCantidadN = N, @SiniestrosCantidadR = R
	FROM
		(SELECT Clave, Cantidad
			FROM @SiniestrosPorClave) src
		PIVOT
		(MAX(Cantidad)
			FOR Clave IN (AV, SP, N, R)
		) piv

	-- Siniestros: asigno los puntajes totales por cada clave a las variables
	SELECT @SiniestrosPuntajeVA = AV, @SiniestrosPuntajeN = N, @SiniestrosPuntajeR = R
	FROM
		(SELECT Clave, Puntaje
			FROM @SiniestrosPorClave) src
		PIVOT
		(MAX(Puntaje)
			FOR Clave IN (AV, SP, N, R)
		) piv

	-- Siniestros: calculo los puntajes de cada persona por cada clave
	INSERT INTO @SiniestrosPersonasPuntajesPorClave
		(IDPersona, Clave, Cantidad, Puntaje)
		SELECT rf.IDPersona, dbo.SiniestroObtenerClaveAgrupadaYPorcentaje(s.IDSiniestroClave, sa.IDSiniestroAsistenciaTipo, @IDSiniestroAsistenciaTipoPresente, @IDSiniestroAsistenciaTipoSalidaAnticipada) AS Clave, COUNT(sa.IDPersona), ISNULL(SUM(sp.Puntaje), 0)
			FROM @ResultadoFinal AS rf
				LEFT JOIN (SiniestroAsistencia AS sa
				INNER JOIN Siniestro AS s ON sa.IDSiniestro = s.IDSiniestro
				INNER JOIN @SiniestrosPuntajes AS sp ON sa.IDSiniestro = sp.IDSiniestro AND sa.IDSiniestroAsistenciaTipo = sp.IDSiniestroAsistenciaTipo) ON rf.IDPersona = sa.IDPersona
			GROUP BY rf.IDPersona, dbo.SiniestroObtenerClaveAgrupadaYPorcentaje(s.IDSiniestroClave, sa.IDSiniestroAsistenciaTipo, @IDSiniestroAsistenciaTipoPresente, @IDSiniestroAsistenciaTipoSalidaAnticipada)

	-- Siniestros: asigno las cantidades y puntajes de las personas para las claves verdes y azules
	UPDATE @ResultadoFinal
		SET SiniestrosClaveVACantidad = Cantidad, SiniestrosClaveVAPuntaje = Puntaje
			FROM @SiniestrosPersonasPuntajesPorClave AS spppc
				INNER JOIN @ResultadoFinal AS rf ON spppc.IDPersona = rf.IDPersona
			WHERE spppc.Clave = 'AV'

	-- Siniestros: asigno las cantidades y puntajes de las personas para las salidas programadas
	UPDATE @ResultadoFinal
		SET SiniestrosClaveSPCantidad = Cantidad, SiniestrosClaveSPPuntaje = Puntaje
			FROM @SiniestrosPersonasPuntajesPorClave AS spppc
				INNER JOIN @ResultadoFinal AS rf ON spppc.IDPersona = rf.IDPersona
			WHERE spppc.Clave = 'SP'

	-- Siniestros: asigno las cantidades y puntajes de las personas para las claves naranjas con "Presente"
	UPDATE @ResultadoFinal
		SET SiniestrosClaveN100Cantidad = Cantidad, SiniestrosClaveN100Puntaje = Puntaje
			FROM @SiniestrosPersonasPuntajesPorClave AS spppc
				INNER JOIN @ResultadoFinal AS rf ON spppc.IDPersona = rf.IDPersona
			WHERE spppc.Clave = 'N1'

	-- Siniestros: asigno las cantidades y puntajes de las personas para las claves naranjas con "Salida anticipada"
	UPDATE @ResultadoFinal
		SET SiniestrosClaveN50Cantidad = Cantidad, SiniestrosClaveN50Puntaje = Puntaje
			FROM @SiniestrosPersonasPuntajesPorClave AS spppc
				INNER JOIN @ResultadoFinal AS rf ON spppc.IDPersona = rf.IDPersona
			WHERE spppc.Clave = 'N5'

	-- Siniestros: asigno las cantidades y puntajes de las personas para las claves rojas con "Presente"
	UPDATE @ResultadoFinal
		SET SiniestrosClaveR100Cantidad = Cantidad, SiniestrosClaveR100Puntaje = Puntaje
			FROM @SiniestrosPersonasPuntajesPorClave AS spppc
				INNER JOIN @ResultadoFinal AS rf ON spppc.IDPersona = rf.IDPersona
			WHERE spppc.Clave = 'R1'

	-- -- Siniestros: asigno las cantidades y puntajes de las personas para las claves rojas con "Salida anticipada"
	UPDATE @ResultadoFinal
		SET SiniestrosClaveR50Cantidad = Cantidad, SiniestrosClaveR50Puntaje = Puntaje
			FROM @SiniestrosPersonasPuntajesPorClave AS spppc
				INNER JOIN @ResultadoFinal AS rf ON spppc.IDPersona = rf.IDPersona
			WHERE spppc.Clave = 'R5'

	-- Academias: obtengo el id del tipo de asistencia "Presente"
	SELECT @IDAcademiaAsistenciaTipoPresente = NumeroEntero
		FROM Parametro
		WHERE IDParametro = 'ACADEMIA_ASISTENCIATIPO_PRESENTE_ID'

	-- Academias: obtengo el id del tipo de asistencia "Fuera de hora"
	SELECT @IDAcademiaAsistenciaTipoFueraHora = NumeroEntero
		FROM Parametro
		WHERE IDParametro = 'ACADEMIA_ASISTENCIATIPO_FUERAHORA_ID'

	-- Academias: agrego el id del puntaje por "Presente" vigente a la fecha de cada academia
	INSERT INTO @AcademiasPuntajes
		(IDAcademia, IDAcademiaAsistenciaTipo, IDAcademiaAsistenciaTipoPuntaje)
		SELECT a.IDAcademia, @IDAcademiaAsistenciaTipoPresente, dbo.AcademiaObtenerIdPuntaje(@IDAcademiaAsistenciaTipoPresente, a.Fecha)
			FROM Academia AS a
			WHERE a.IDCuartel = @IDCuartel
				AND a.Fecha BETWEEN @FechaDesde AND @FechaHasta

	-- Academias: agrego el id del puntaje por "Fuera de hora" vigente a la fecha de cada academia
	INSERT INTO @AcademiasPuntajes
		(IDAcademia, IDAcademiaAsistenciaTipo, IDAcademiaAsistenciaTipoPuntaje)
		SELECT a.IDAcademia, @IDAcademiaAsistenciaTipoFueraHora, dbo.AcademiaObtenerIdPuntaje(@IDAcademiaAsistenciaTipoFueraHora, a.Fecha)
			FROM Academia AS a
			WHERE a.IDCuartel = @IDCuartel
				AND a.Fecha BETWEEN @FechaDesde AND @FechaHasta

	-- Academias: asigno los puntajes correspondientes a cada academia
	UPDATE @AcademiasPuntajes
		SET Puntaje = aatp.Puntaje
		FROM Academia AS a
			INNER JOIN @AcademiasPuntajes AS ap ON a.IDAcademia = ap.IDAcademia
			INNER JOIN AcademiaAsistenciaTipoPuntaje AS aatp ON ap.IDAcademiaAsistenciaTipo = aatp.IDAcademiaAsistenciaTipo AND ap.IDAcademiaAsistenciaTipoPuntaje = aatp.IDAcademiaAsistenciaTipoPuntaje

	-- Academias: calculo la cantidad de academias y el puntaje total
	SELECT @AcademiasCantidad = COUNT(a.IDAcademia), @AcademiasPuntaje = SUM(ISNULL(ap.Puntaje, 0))
		FROM Academia AS a
				INNER JOIN @AcademiasPuntajes AS ap ON a.IDAcademia = ap.IDAcademia
			WHERE ap.IDAcademiaAsistenciaTipo = @IDAcademiaAsistenciaTipoPresente

	-- Academias: calculo los puntajes de cada persona
	INSERT INTO @AcademiasPersonasPuntajesPorClave
		(IDPersona, Clave, Cantidad, Puntaje)
		SELECT rf.IDPersona, (CASE aa.IDAcademiaAsistenciaTipo WHEN @IDAcademiaAsistenciaTipoPresente THEN 'AP' WHEN @IDAcademiaAsistenciaTipoFueraHora THEN 'AF' ELSE '' END) AS Clave, COUNT(aa.IDPersona), ISNULL(SUM(ap.Puntaje), 0)
			FROM @ResultadoFinal AS rf
				LEFT JOIN (AcademiaAsistencia AS aa
				INNER JOIN Academia AS a ON aa.IDAcademia = a.IDAcademia
				INNER JOIN @AcademiasPuntajes AS ap ON aa.IDAcademia = ap.IDAcademia AND aa.IDAcademiaAsistenciaTipo = ap.IDAcademiaAsistenciaTipo) ON rf.IDPersona = aa.IDPersona
			GROUP BY rf.IDPersona, (CASE aa.IDAcademiaAsistenciaTipo WHEN @IDAcademiaAsistenciaTipoPresente THEN 'AP' WHEN @IDAcademiaAsistenciaTipoFueraHora THEN 'AF' ELSE '' END)

	-- Academias: asigno las cantidades y puntajes de las personas para la clave "Presente"
	UPDATE @ResultadoFinal
		SET AcademiasPCantidad = Cantidad, AcademiasPPuntaje = Puntaje
			FROM @AcademiasPersonasPuntajesPorClave AS apppc
				INNER JOIN @ResultadoFinal AS rf ON apppc.IDPersona = rf.IDPersona
			WHERE apppc.Clave = 'AP'

	-- Academias: asigno las cantidades y puntajes de las personas para la clave "Fuera de hora"
	UPDATE @ResultadoFinal
		SET AcademiasFHCantidad = Cantidad, AcademiasFHPuntaje = Puntaje
			FROM @AcademiasPersonasPuntajesPorClave AS apppc
				INNER JOIN @ResultadoFinal AS rf ON apppc.IDPersona = rf.IDPersona
			WHERE apppc.Clave = 'AF'

	-- Común: muestro las personas y los puntajes
	SELECT ISNULL(@SiniestrosCantidadVA, 0) AS SiniestrosClaveVACantidadTotal, ISNULL(@SiniestrosCantidadSP, 0) AS SiniestrosClaveSPCantidadTotal, ISNULL(@SiniestrosCantidadN, 0) AS SiniestrosClaveNCantidadTotal, ISNULL(@SiniestrosCantidadR, 0) AS SiniestrosClaveRCantidadTotal, @AcademiasCantidad AS AcademiasCantidadTotal, ISNULL(@SiniestrosPuntajeVA, 0) + ISNULL(@SiniestrosPuntajeN, 0) + ISNULL(@SiniestrosPuntajeR, 0) + ISNULL(@AcademiasPuntaje, 0) AS PuntajeMaximo,
			ROW_NUMBER() OVER (ORDER BY ISNULL(SiniestrosClaveVAPuntaje, 0) + ISNULL(SiniestrosClaveSPPuntaje, 0) + ISNULL(SiniestrosClaveN100Puntaje, 0) + ISNULL(SiniestrosClaveN50Puntaje, 0) + ISNULL(SiniestrosClaveR100Puntaje, 0) + ISNULL(SiniestrosClaveR50Puntaje, 0) + ISNULL(AcademiasPPuntaje, 0) + ISNULL(AcademiasFHPuntaje, 0) DESC, p.Orden) AS Orden, p.MatriculaNumero, UPPER(p.ApellidoNombre) AS ApellidoNombre,
			ISNULL(SiniestrosClaveVACantidad, 0) AS SiniestrosClaveVACantidad, ISNULL(SiniestrosClaveVAPuntaje, 0) AS SiniestrosClaveVAPuntaje,
			ISNULL(SiniestrosClaveSPCantidad, 0) AS SiniestrosClaveSPCantidad, ISNULL(SiniestrosClaveSPPuntaje, 0) AS SiniestrosClaveSPPuntaje,
			ISNULL(SiniestrosClaveN100Cantidad, 0) AS SiniestrosClaveN100Cantidad, ISNULL(SiniestrosClaveN100Puntaje, 0) AS SiniestrosClaveN100Puntaje,
			ISNULL(SiniestrosClaveN50Cantidad, 0) AS SiniestrosClaveN50Cantidad, ISNULL(SiniestrosClaveN50Puntaje, 0) AS SiniestrosClaveN50Puntaje,
			ISNULL(SiniestrosClaveR100Cantidad, 0) AS SiniestrosClaveR100Cantidad, ISNULL(SiniestrosClaveR100Puntaje, 0) AS SiniestrosClaveR100Puntaje,
			ISNULL(SiniestrosClaveR50Cantidad, 0) AS SiniestrosClaveR50Cantidad, ISNULL(SiniestrosClaveR50Puntaje, 0) AS SiniestrosClaveR50Puntaje,
			ISNULL(AcademiasPCantidad, 0) AS AcademiasPCantidad, ISNULL(AcademiasPPuntaje, 0) AS AcademiasPPuntaje,
			ISNULL(AcademiasFHCantidad, 0) AS AcademiasFHCantidad, ISNULL(AcademiasFHPuntaje, 0) AS AcademiasFHPuntaje,
			(CAST(ISNULL(SiniestrosClaveVAPuntaje, 0) + ISNULL(SiniestrosClaveSPPuntaje, 0) + ISNULL(SiniestrosClaveN100Puntaje, 0) + ISNULL(SiniestrosClaveN50Puntaje, 0) + ISNULL(SiniestrosClaveR100Puntaje, 0) + ISNULL(SiniestrosClaveR50Puntaje, 0) + ISNULL(AcademiasPPuntaje, 0) + ISNULL(AcademiasFHPuntaje, 0) AS decimal) / (ISNULL(@SiniestrosPuntajeVA, 0) + ISNULL(@SiniestrosPuntajeSP, 0) + ISNULL(@SiniestrosPuntajeN, 0) + ISNULL(@SiniestrosPuntajeR, 0) + ISNULL(@AcademiasPuntaje, 0)) * 100) AS ProporcionPuntajeMaximo,
			CAST(ISNULL(SiniestrosClaveVAPuntaje, 0) + ISNULL(SiniestrosClaveSPPuntaje, 0) + ISNULL(SiniestrosClaveN100Puntaje, 0) + ISNULL(SiniestrosClaveN50Puntaje, 0) + ISNULL(SiniestrosClaveR100Puntaje, 0) + ISNULL(SiniestrosClaveR50Puntaje, 0) + ISNULL(AcademiasPPuntaje, 0) + ISNULL(AcademiasFHPuntaje, 0) AS decimal) AS PuntajeTotal
		FROM @ResultadoFinal AS rf
			INNER JOIN Persona AS p ON rf.IDPersona = p.IDPersona
		ORDER BY ISNULL(SiniestrosClaveVAPuntaje, 0) + ISNULL(SiniestrosClaveSPPuntaje, 0) + ISNULL(SiniestrosClaveN100Puntaje, 0) + ISNULL(SiniestrosClaveN50Puntaje, 0) + ISNULL(SiniestrosClaveR100Puntaje, 0) + ISNULL(SiniestrosClaveR50Puntaje, 0) + ISNULL(AcademiasPPuntaje, 0) + ISNULL(AcademiasFHPuntaje, 0) DESC, p.Orden
END
GO