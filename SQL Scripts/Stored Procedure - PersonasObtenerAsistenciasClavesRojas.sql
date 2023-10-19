USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Creation date: 2022-03-01
-- Updates: 
-- Description:	Devuelve las asistencias e inasistencias a claves rojas
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'uspPersonasObtenerAsistenciasClavesRojas') AND type in (N'P', N'PC'))
	 DROP PROCEDURE uspPersonasObtenerAsistenciasClavesRojas
GO

CREATE PROCEDURE uspPersonasObtenerAsistenciasClavesRojas
	@IDCuartel tinyint,
	@FechaDesde date,
	@FechaHasta date
	AS
BEGIN
	DECLARE @ClavesRojasCantidad int, @ClavesRojas20PorCientoCantidad int, @ClavesRojas40PorCientoCantidad int
	DECLARE @ResultadoFinal table (IDPersona int not null PRIMARY KEY, PresenteCantidad int, AusenciaInjustificadaCantidad int, AusenciaCantidad int)
	DECLARE @Siniestros table (IDSiniestro int not null PRIMARY KEY)

	-- Obtengo las personas del cuerpo activo a la fecha hasta
	INSERT INTO @ResultadoFinal
		(IDPersona)
		SELECT p.IDPersona
			FROM Persona AS p
				INNER JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
				LEFT JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
			WHERE p.EsActivo = 1
				AND p.IDCuartel = @IDCuartel
				AND pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, @FechaHasta)
				AND pab.Tipo = 'A'
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, GETDATE()))
				AND cj.JerarquiaInferior = 0

	-- Agrego los siniestros según los filtros
	INSERT INTO @Siniestros
		(IDSiniestro)
		SELECT s.IDSiniestro
			FROM Siniestro AS s
				INNER JOIN SiniestroClave AS sc ON s.IDSiniestroClave = sc.IDSiniestroClave
			WHERE s.Anulado = 0
				AND sc.Grupo = 'R'
				AND s.IDCuartel = @IDCuartel
				AND s.Fecha BETWEEN @FechaDesde AND @FechaHasta

	-- Obtengo la cantidad de siniestros con clave roja
	SELECT @ClavesRojasCantidad = COUNT(IDSiniestro)
			FROM @Siniestros

	-- Calculo la cantidad por porcentaje con el redondeo correspondiente
	IF @ClavesRojasCantidad < 50
		-- Por ser menor a 50 la cantidad de claves rojas, redondeo para abajo
		BEGIN
		SET @ClavesRojas20PorCientoCantidad = FLOOR(@ClavesRojasCantidad * 0.2)
		SET @ClavesRojas40PorCientoCantidad = FLOOR(@ClavesRojasCantidad * 0.4)
		END
	ELSE
		-- Por ser mayor o igual a 50 la cantidad de claves rojas, redondeo para arriba
		BEGIN
		SET @ClavesRojas20PorCientoCantidad = CEILING(@ClavesRojasCantidad * 0.2)
		SET @ClavesRojas40PorCientoCantidad = CEILING(@ClavesRojasCantidad * 0.4)
		END

	-- Asigno la cantidad de presentes a cada persona
	UPDATE @ResultadoFinal
		SET PresenteCantidad = subqry.Cantidad
			FROM (SELECT sa.IDPersona, COUNT(s.IDSiniestro) AS Cantidad
					FROM @Siniestros AS s
					INNER JOIN SiniestroAsistencia AS sa ON s.IDSiniestro = sa.IDSiniestro
					INNER JOIN SiniestroAsistenciaTipo AS sat ON sa.IDSiniestroAsistenciaTipo = sat.IDSiniestroAsistenciaTipo
					WHERE sat.EsPresente = 1
					GROUP BY sa.IDPersona) AS subqry
				INNER JOIN @ResultadoFinal AS rf ON subqry.IDPersona = rf.IDPersona

	-- Asigno la cantidad de ausencias injustificadas a cada persona
	UPDATE @ResultadoFinal
		SET AusenciaInjustificadaCantidad = subqry.Cantidad
			FROM (SELECT sa.IDPersona, COUNT(s.IDSiniestro) AS Cantidad
					FROM @Siniestros AS s
					INNER JOIN SiniestroAsistencia AS sa ON s.IDSiniestro = sa.IDSiniestro
					INNER JOIN SiniestroAsistenciaTipo AS sat ON sa.IDSiniestroAsistenciaTipo = sat.IDSiniestroAsistenciaTipo
					WHERE sat.EsPresente = 0 AND sat.EsAusenciaJustificada = 0
					GROUP BY sa.IDPersona) AS subqry
				INNER JOIN @ResultadoFinal AS rf ON subqry.IDPersona = rf.IDPersona

	-- Asigno la cantidad de ausencias a cada persona
	UPDATE @ResultadoFinal
		SET AusenciaCantidad = subqry.Cantidad
			FROM (SELECT sa.IDPersona, COUNT(s.IDSiniestro) AS Cantidad
					FROM @Siniestros AS s
					INNER JOIN SiniestroAsistencia AS sa ON s.IDSiniestro = sa.IDSiniestro
					INNER JOIN SiniestroAsistenciaTipo AS sat ON sa.IDSiniestroAsistenciaTipo = sat.IDSiniestroAsistenciaTipo
					WHERE sat.EsPresente = 0
					GROUP BY sa.IDPersona) AS subqry
				INNER JOIN @ResultadoFinal AS rf ON subqry.IDPersona = rf.IDPersona

	-- Muestro las personas y los resultados
	SELECT ISNULL(@ClavesRojasCantidad, 0) AS ClavesRojasCantidad, ISNULL(@ClavesRojas20PorCientoCantidad, 0) AS ClavesRojas20PorCientoCantidad, ISNULL(@ClavesRojas40PorCientoCantidad, 0) AS ClavesRojas40PorCientoCantidad,
			ROW_NUMBER() OVER (ORDER BY p.Orden, p.ApellidoNombre) AS Orden, p.MatriculaNumero, UPPER(p.ApellidoNombre) AS ApellidoNombre,
			ISNULL(rf.AusenciaInjustificadaCantidad, 0) AS AusenciaInjustificadaCantidad, ISNULL(rf.AusenciaCantidad, 0) AS AusenciaCantidad, (CASE WHEN ISNULL(rf.PresenteCantidad, 0) < @ClavesRojas40PorCientoCantidad THEN CAST(ISNULL(rf.PresenteCantidad, 0) AS varchar(10)) ELSE CAST('--' AS varchar(10)) END) AS CantidadInferior40PorCiento
		FROM @ResultadoFinal AS rf
			INNER JOIN Persona AS p ON rf.IDPersona = p.IDPersona
		ORDER BY p.Orden
END
GO