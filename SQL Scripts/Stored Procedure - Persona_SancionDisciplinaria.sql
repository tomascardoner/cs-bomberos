USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-22
-- Updates: 2021-11-21 - Actualizado a las nuevas funciones y tablas
--			2022-05-08 - Se agregaron las columnas Estado, EstadoNombre, DesaprobadaCausa, TestimonioTexto y TestimonioFecha
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

		SELECT p.IDPersona, p.MatriculaNumero, p.Genero, p.Apellido, p.Nombre, cj.Nombre AS Jerarquia, sp.Apellido AS SolicitudPersonaApellido,
				sp.Nombre AS SolicitudPersonaNombre, scj.Nombre AS SolicitudJerarquia, ps.SolicitudMotivo, ps.SolicitudFecha, ps.EncuadreTexto, ps.EncuadreFecha,
				ps.Estado, ps.EstadoNombre, ps.DesaprobadaCausa, st.Nombre AS ResolucionSancionTipoNombre, ps.ResolucionFecha, ps.NotificacionFecha, ps.TestimonioTexto, ps.TestimonioFecha
			FROM PersonaSancion AS ps
				INNER JOIN Persona AS p ON ps.IDPersona = p.IDPersona
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
				LEFT JOIN Cargo AS ca ON pa.IDCargo = ca.IDCargo
				LEFT JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
				INNER JOIN Persona AS sp ON ps.SolicitudIDPersona = sp.IDPersona
				LEFT JOIN PersonaAscenso AS spa ON sp.IDPersona = spa.IDPersona
				LEFT JOIN Cargo AS sca ON spa.IDCargo = sca.IDCargo
				LEFT JOIN CargoJerarquia AS scj ON spa.IDCargo = scj.IDCargo AND spa.IDJerarquia = scj.IDJerarquia
				LEFT JOIN SancionTipo AS st ON ps.ResolucionIDSancionTipo = st.IDSancionTipo
			WHERE ps.IDPersona = @IDPersona AND ps.IDSancion = @IDSancion
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, ps.SolicitudFecha))
				AND (spa.Fecha IS NULL OR spa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(sp.IDPersona, ps.SolicitudFecha))
	END
GO