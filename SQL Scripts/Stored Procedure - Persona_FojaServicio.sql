USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-13
-- Updates: 2021-11-21 - Actualizado a las nuevas funciones y tablas
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

		SELECT p.IDPersona, c.Nombre AS CuartelNombre, p.MatriculaNumero, p.Genero, p.Apellido, p.Nombre, dt.Nombre AS DocumentoTipoNombre, p.DocumentoNumero, p.FechaNacimiento,
				dbo.PersonaObtenerFechaPrimeraAlta(p.IDPersona) AS FechaIngreso, cj.Nombre AS Jerarquia,
				dbo.PersonaObtenerEstado(pab.Tipo, pab.IDPersonaBajaMotivo) AS EstadoActual,
				dbo.udf_GetDomicilioCalleLocalidadCompleto(p.DomicilioParticularCalle1, p.DomicilioParticularNumero, p.DomicilioParticularPiso, p.DomicilioParticularDepartamento, p.DomicilioParticularCalle2, p.DomicilioParticularCalle3, p.DomicilioParticularIDProvincia, p.DomicilioParticularIDLocalidad) AS Domicilio
			FROM Persona AS p
				INNER JOIN Cuartel AS c ON p.IDCuartel = c.IDCuartel
				LEFT JOIN DocumentoTipo AS dt ON p.IDDocumentoTipo = dt.IDDocumentoTipo
				LEFT JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
				LEFT JOIN Cargo AS ca ON pa.IDCargo = ca.IDCargo
				LEFT JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
				LEFT JOIN PersonaBajaMotivo AS pbm ON pab.IDPersonaBajaMotivo = pbm.IDPersonaBajaMotivo
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