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
-- Description:	Devuelve las asistencias e inasistencias a Adacemias
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'uspPersonasObtenerAsistenciasAcademias') AND type in (N'P', N'PC'))
	 DROP PROCEDURE uspPersonasObtenerAsistenciasAcademias
GO

CREATE PROCEDURE uspPersonasObtenerAsistenciasAcademias
	@IDCuartel tinyint,
	@FechaDesde date,
	@FechaHasta date
	AS
BEGIN
	DECLARE @AcademiasCantidad int, @Academias60PorCientoCantidad int
	DECLARE @ResultadoFinal table (IDPersona int not null PRIMARY KEY, AusenciaCantidad int, FueraHoraCantidad int)
	DECLARE @Academias table (IDAcademia int not null PRIMARY KEY)

	-- Obtengo las personas del cuerpo activo a la fecha hasta
	INSERT INTO @ResultadoFinal
		(IDPersona)
		SELECT p.IDPersona
			FROM Persona AS p
				INNER JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
			WHERE p.EsActivo = 1
				AND p.IDCuartel = @IDCuartel
				AND pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, @FechaHasta)
				AND pab.Tipo = 'A'

	-- Agrego los siniestros según los filtros
	INSERT INTO @Academias
		(IDAcademia)
		SELECT IDAcademia
			FROM Academia
			WHERE IDCuartel = @IDCuartel
				AND Fecha BETWEEN @FechaDesde AND @FechaHasta

	-- Obtengo la cantidad de siniestros con clave roja
	SELECT @AcademiasCantidad = COUNT(IDAcademia)
			FROM @Academias

	-- Calculo la cantidad por porcentaje con el redondeo correspondiente
	SET @Academias60PorCientoCantidad = ROUND(@AcademiasCantidad * 0.6, 0)

	-- Asigno la cantidad de ausencias a cada persona
	UPDATE @ResultadoFinal
		SET AusenciaCantidad = subqry.Cantidad
			FROM (SELECT aa.IDPersona, COUNT(a.IDAcademia) AS Cantidad
					FROM @Academias AS a
					INNER JOIN AcademiaAsistencia AS aa ON a.IDAcademia = aa.IDAcademia
					INNER JOIN AcademiaAsistenciaTipo AS aat ON aa.IDAcademiaAsistenciaTipo = aat.IDAcademiaAsistenciaTipo
					WHERE aat.EsPresente = 1
					GROUP BY aa.IDPersona) AS subqry
				INNER JOIN @ResultadoFinal AS rf ON subqry.IDPersona = rf.IDPersona

	-- Asigno la cantidad de fuera de hora a cada persona
	UPDATE @ResultadoFinal
		SET AusenciaCantidad = subqry.Cantidad
			FROM (SELECT aa.IDPersona, COUNT(a.IDAcademia) AS Cantidad
					FROM @Academias AS a
					INNER JOIN AcademiaAsistencia AS aa ON a.IDAcademia = aa.IDAcademia
					WHERE aa.IDAcademiaAsistenciaTipo = 12
					GROUP BY aa.IDPersona) AS subqry
				INNER JOIN @ResultadoFinal AS rf ON subqry.IDPersona = rf.IDPersona

	-- Muestro las personas y los resultados
	SELECT ISNULL(@AcademiasCantidad, 0) AS AcademiasCantidad, ISNULL(@Academias60PorCientoCantidad, 0) AS Academias60PorCientoCantidad,
			ROW_NUMBER() OVER (ORDER BY p.Orden, p.ApellidoNombre) AS Orden, p.MatriculaNumero, UPPER(p.ApellidoNombre) AS ApellidoNombre,
			ISNULL(rf.AusenciaCantidad, 0) AS AusenciaCantidad, ISNULL(rf.FueraHoraCantidad, 0) AS FueraHoraCantidad, (CASE WHEN ISNULL(rf.AusenciaCantidad, 0) < @Academias60PorCientoCantidad THEN CAST(ISNULL(rf.AusenciaCantidad, 0) AS varchar(10)) ELSE CAST('--' AS varchar(10)) END) AS CantidadInferior60PorCiento
		FROM @ResultadoFinal AS rf
			INNER JOIN Persona AS p ON rf.IDPersona = p.IDPersona
		ORDER BY p.Orden
END
GO