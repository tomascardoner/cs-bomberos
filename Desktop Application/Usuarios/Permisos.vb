Module Permisos

#Region "Definición de constantes"

    ' SISTEMA
    Friend Const SISTEMA_COMPLETAR_CUIL As String = "SISTEMA_COMPLETAR_CUIL"
    Friend Const SISTEMA_VERIFICAR_FAMILIARACARGO As String = "SISTEMA_VERIFICAR_FAMILIARACARGO"

    Friend Const CUARTEL As String = "CUARTEL"
    Friend Const CUARTEL_AGREGAR As String = "CUARTEL_AGREGAR"
    Friend Const CUARTEL_EDITAR As String = "CUARTEL_EDITAR"
    Friend Const CUARTEL_ELIMINAR As String = "CUARTEL_ELIMINAR"

    Friend Const NIVELESTUDIO As String = "NIVELESTUDIO"
    Friend Const NIVELESTUDIO_AGREGAR As String = "NIVELESTUDIO_AGREGAR"
    Friend Const NIVELESTUDIO_EDITAR As String = "NIVELESTUDIO_EDITAR"
    Friend Const NIVELESTUDIO_ELIMINAR As String = "NIVELESTUDIO_ELIMINAR"

    Friend Const ESTADOCIVIL As String = "ESTADOCIVIL"
    Friend Const ESTADOCIVIL_AGREGAR As String = "ESTADOCIVIL_AGREGAR"
    Friend Const ESTADOCIVIL_EDITAR As String = "ESTADOCIVIL_EDITAR"
    Friend Const ESTADOCIVIL_ELIMINAR As String = "ESTADOCIVIL_ELIMINAR"

    Friend Const PARENTESCO As String = "PARENTESCO"
    Friend Const PARENTESCO_AGREGAR As String = "PARENTESCO_AGREGAR"
    Friend Const PARENTESCO_EDITAR As String = "PARENTESCO_EDITAR"
    Friend Const PARENTESCO_ELIMINAR As String = "PARENTESCO_ELIMINAR"

    Friend Const PERSONABAJAMOTIVO As String = "PERSONABAJAMOTIVO"
    Friend Const PERSONABAJAMOTIVO_AGREGAR As String = "PERSONABAJAMOTIVO_AGREGAR"
    Friend Const PERSONABAJAMOTIVO_EDITAR As String = "PERSONABAJAMOTIVO_EDITAR"
    Friend Const PERSONABAJAMOTIVO_ELIMINAR As String = "PERSONABAJAMOTIVO_ELIMINAR"

    Friend Const CARGO As String = "CARGO"
    Friend Const CARGO_AGREGAR As String = "CARGO_AGREGAR"
    Friend Const CARGO_EDITAR As String = "CARGO_EDITAR"
    Friend Const CARGO_ELIMINAR As String = "CARGO_ELIMINAR"

    Friend Const CARGOJERARQUIA As String = "CARGOJERARQUIA"
    Friend Const CARGOJERARQUIA_AGREGAR As String = "CARGOJERARQUIA_AGREGAR"
    Friend Const CARGOJERARQUIA_EDITAR As String = "CARGOJERARQUIA_EDITAR"
    Friend Const CARGOJERARQUIA_ELIMINAR As String = "CARGOJERARQUIA_ELIMINAR"

    Friend Const LICENCIACAUSA As String = "LICENCIACAUSA"
    Friend Const LICENCIACAUSA_AGREGAR As String = "LICENCIACAUSA_AGREGAR"
    Friend Const LICENCIACAUSA_EDITAR As String = "LICENCIACAUSA_EDITAR"
    Friend Const LICENCIACAUSA_ELIMINAR As String = "LICENCIACAUSA_ELIMINAR"

    Friend Const SANCIONTIPO As String = "SANCIONTIPO"
    Friend Const SANCIONTIPO_AGREGAR As String = "SANCIONTIPO_AGREGAR"
    Friend Const SANCIONTIPO_EDITAR As String = "SANCIONTIPO_EDITAR"
    Friend Const SANCIONTIPO_ELIMINAR As String = "SANCIONTIPO_ELIMINAR"

    Friend Const CURSO As String = "CURSO"
    Friend Const CURSO_AGREGAR As String = "CURSO_AGREGAR"
    Friend Const CURSO_EDITAR As String = "CURSO_EDITAR"
    Friend Const CURSO_ELIMINAR As String = "CURSO_ELIMINAR"

    Friend Const CAPACITACIONNIVEL As String = "CAPACITACIONNIVEL"
    Friend Const CAPACITACIONNIVEL_AGREGAR As String = "CAPACITACIONNIVEL_AGREGAR"
    Friend Const CAPACITACIONNIVEL_EDITAR As String = "CAPACITACIONNIVEL_EDITAR"
    Friend Const CAPACITACIONNIVEL_ELIMINAR As String = "CAPACITACIONNIVEL_ELIMINAR"

    Friend Const CAPACITACIONTIPO As String = "CAPACITACIONTIPO"
    Friend Const CAPACITACIONTIPO_AGREGAR As String = "CAPACITACIONTIPO_AGREGAR"
    Friend Const CAPACITACIONTIPO_EDITAR As String = "CAPACITACIONTIPO_EDITAR"
    Friend Const CAPACITACIONTIPO_ELIMINAR As String = "CAPACITACIONTIPO_ELIMINAR"

    Friend Const CALIFICACIONCONCEPTO As String = "CALIFICACIONCONCEPTO"
    Friend Const CALIFICACIONCONCEPTO_AGREGAR As String = "CALIFICACIONCONCEPTO_AGREGAR"
    Friend Const CALIFICACIONCONCEPTO_EDITAR As String = "CALIFICACIONCONCEPTO_EDITAR"
    Friend Const CALIFICACIONCONCEPTO_ELIMINAR As String = "CALIFICACIONCONCEPTO_ELIMINAR"

    Friend Const VEHICULOTIPO As String = "VEHICULOTIPO"
    Friend Const VEHICULOTIPO_AGREGAR As String = "VEHICULOTIPO_AGREGAR"
    Friend Const VEHICULOTIPO_EDITAR As String = "VEHICULOTIPO_EDITAR"
    Friend Const VEHICULOTIPO_ELIMINAR As String = "VEHICULOTIPO_ELIMINAR"

    Friend Const VEHICULOMARCA As String = "VEHICULOMARCA"
    Friend Const VEHICULOMARCA_AGREGAR As String = "VEHICULOMARCA_AGREGAR"
    Friend Const VEHICULOMARCA_EDITAR As String = "VEHICULOMARCA_EDITAR"
    Friend Const VEHICULOMARCA_ELIMINAR As String = "VEHICULOMARCA_ELIMINAR"

    Friend Const VEHICULOCOMPANIASEGURO As String = "VEHICULOCOMPANIASEGURO"
    Friend Const VEHICULOCOMPANIASEGURO_AGREGAR As String = "VEHICULOCOMPANIASEGURO_AGREGAR"
    Friend Const VEHICULOCOMPANIASEGURO_EDITAR As String = "VEHICULOCOMPANIASEGURO_EDITAR"
    Friend Const VEHICULOCOMPANIASEGURO_ELIMINAR As String = "VEHICULOCOMPANIASEGURO_ELIMINAR"

    Friend Const VACUNATIPO As String = "VACUNATIPO"
    Friend Const VACUNATIPO_AGREGAR As String = "VACUNATIPO_AGREGAR"
    Friend Const VACUNATIPO_EDITAR As String = "VACUNATIPO_EDITAR"
    Friend Const VACUNATIPO_ELIMINAR As String = "VACUNATIPO_ELIMINAR"

    Friend Const UNIDADTIPO As String = "UNIDADTIPO"
    Friend Const UNIDADTIPO_AGREGAR As String = "UNIDADTIPO_AGREGAR"
    Friend Const UNIDADTIPO_EDITAR As String = "UNIDADTIPO_EDITAR"
    Friend Const UNIDADTIPO_ELIMINAR As String = "UNIDADTIPO_ELIMINAR"

    Friend Const UNIDADUSO As String = "UNIDADUSO"
    Friend Const UNIDADUSO_AGREGAR As String = "UNIDADUSO_AGREGAR"
    Friend Const UNIDADUSO_EDITAR As String = "UNIDADUSO_EDITAR"
    Friend Const UNIDADUSO_ELIMINAR As String = "UNIDADUSO_ELIMINAR"

    Friend Const UNIDADBAJAMOTIVO As String = "UNIDADBAJAMOTIVO"
    Friend Const UNIDADBAJAMOTIVO_AGREGAR As String = "UNIDADBAJAMOTIVO_AGREGAR"
    Friend Const UNIDADBAJAMOTIVO_EDITAR As String = "UNIDADBAJAMOTIVO_EDITAR"
    Friend Const UNIDADBAJAMOTIVO_ELIMINAR As String = "UNIDADBAJAMOTIVO_ELIMINAR"

    Friend Const RUBRO As String = "RUBRO"
    Friend Const RUBRO_AGREGAR As String = "RUBRO_AGREGAR"
    Friend Const RUBRO_EDITAR As String = "RUBRO_EDITAR"
    Friend Const RUBRO_ELIMINAR As String = "RUBRO_ELIMINAR"

    Friend Const SUBRUBRO As String = "SUBRUBRO"
    Friend Const SUBRUBRO_AGREGAR As String = "SUBRUBRO_AGREGAR"
    Friend Const SUBRUBRO_EDITAR As String = "SUBRUBRO_EDITAR"
    Friend Const SUBRUBRO_ELIMINAR As String = "SUBRUBRO_ELIMINAR"

    Friend Const AREA As String = "AREA"
    Friend Const AREA_AGREGAR As String = "AREA_AGREGAR"
    Friend Const AREA_EDITAR As String = "AREA_EDITAR"
    Friend Const AREA_ELIMINAR As String = "AREA_ELIMINAR"

    Friend Const UBICACION As String = "UBICACION"
    Friend Const UBICACION_AGREGAR As String = "UBICACION_AGREGAR"
    Friend Const UBICACION_EDITAR As String = "UBICACION_EDITAR"
    Friend Const UBICACION_ELIMINAR As String = "UBICACION_ELIMINAR"

    Friend Const SUBUBICACION As String = "SUBUBICACION"
    Friend Const SUBUBICACION_AGREGAR As String = "SUBUBICACION_AGREGAR"
    Friend Const SUBUBICACION_EDITAR As String = "SUBUBICACION_EDITAR"
    Friend Const SUBUBICACION_ELIMINAR As String = "SUBUBICACION_ELIMINAR"

    Friend Const RESPONSABLE As String = "RESPONSABLE"
    Friend Const RESPONSABLE_AGREGAR As String = "RESPONSABLE_AGREGAR"
    Friend Const RESPONSABLE_EDITAR As String = "RESPONSABLE_EDITAR"
    Friend Const RESPONSABLE_ELIMINAR As String = "RESPONSABLE_ELIMINAR"

    Friend Const RESPONSABLETIPO As String = "RESPONSABLETIPO"
    Friend Const RESPONSABLETIPO_AGREGAR As String = "RESPONSABLETIPO_AGREGAR"
    Friend Const RESPONSABLETIPO_EDITAR As String = "RESPONSABLETIPO_EDITAR"
    Friend Const RESPONSABLETIPO_ELIMINAR As String = "RESPONSABLETIPO_ELIMINAR"

    Friend Const USUARIOGRUPO As String = "USUARIOGRUPO"
    Friend Const USUARIOGRUPO_AGREGAR As String = "USUARIOGRUPO_AGREGAR"
    Friend Const USUARIOGRUPO_EDITAR As String = "USUARIOGRUPO_EDITAR"
    Friend Const USUARIOGRUPO_ELIMINAR As String = "USUARIOGRUPO_ELIMINAR"

    Friend Const USUARIO As String = "USUARIO"
    Friend Const USUARIO_AGREGAR As String = "USUARIO_AGREGAR"
    Friend Const USUARIO_EDITAR As String = "USUARIO_EDITAR"
    Friend Const USUARIO_ELIMINAR As String = "USUARIO_ELIMINAR"
    Friend Const USUARIO_CAMBIARCLAVE As String = "USUARIO_CAMBIARCLAVE"

    Friend Const USUARIOGRUPOPERMISO As String = "USUARIOGRUPOPERMISO"

    Friend Const ALARMA As String = "ALARMA"
    Friend Const ALARMA_AGREGAR As String = "ALARMA_AGREGAR"
    Friend Const ALARMA_EDITAR As String = "ALARMA_EDITAR"
    Friend Const ALARMA_ELIMINAR As String = "ALARMA_ELIMINAR"

    Friend Const PROVEEDOR As String = "PROVEEDOR"
    Friend Const PROVEEDOR_AGREGAR As String = "PROVEEDOR_AGREGAR"
    Friend Const PROVEEDOR_EDITAR As String = "PROVEEDOR_EDITAR"
    Friend Const PROVEEDOR_ELIMINAR As String = "PROVEEDOR_ELIMINAR"

    Friend Const PERSONA As String = "PERSONA"
    Friend Const PERSONA_AGREGAR As String = "PERSONA_AGREGAR"
    Friend Const PERSONA_EDITAR As String = "PERSONA_EDITAR"
    Friend Const PERSONA_ELIMINAR As String = "PERSONA_ELIMINAR"
    Friend Const PERSONA_IMPRIMIR As String = "PERSONA_IMPRIMIR"

    Friend Const PERSONA_FAMILIAR As String = "PERSONA_FAMILIAR"
    Friend Const PERSONA_FAMILIAR_AGREGAR As String = "PERSONA_FAMILIAR_AGREGAR"
    Friend Const PERSONA_FAMILIAR_EDITAR As String = "PERSONA_FAMILIAR_EDITAR"
    Friend Const PERSONA_FAMILIAR_ELIMINAR As String = "PERSONA_FAMILIAR_ELIMINAR"

    Friend Const PERSONA_ALTABAJA As String = "PERSONA_ALTABAJA"
    Friend Const PERSONA_ALTABAJA_AGREGAR As String = "PERSONA_ALTABAJA_AGREGAR"
    Friend Const PERSONA_ALTABAJA_EDITAR As String = "PERSONA_ALTABAJA_EDITAR"
    Friend Const PERSONA_ALTABAJA_ELIMINAR As String = "PERSONA_ALTABAJA_ELIMINAR"

    Friend Const PERSONA_ACCIDENTE As String = "PERSONA_ACCIDENTE"
    Friend Const PERSONA_ACCIDENTE_AGREGAR As String = "PERSONA_ACCIDENTE_AGREGAR"
    Friend Const PERSONA_ACCIDENTE_EDITAR As String = "PERSONA_ACCIDENTE_EDITAR"
    Friend Const PERSONA_ACCIDENTE_ELIMINAR As String = "PERSONA_ACCIDENTE_ELIMINAR"

    Friend Const PERSONA_ASCENSO As String = "PERSONA_ASCENSO"
    Friend Const PERSONA_ASCENSO_AGREGAR As String = "PERSONA_ASCENSO_AGREGAR"
    Friend Const PERSONA_ASCENSO_EDITAR As String = "PERSONA_ASCENSO_EDITAR"
    Friend Const PERSONA_ASCENSO_ELIMINAR As String = "PERSONA_ASCENSO_ELIMINAR"

    Friend Const PERSONA_HORARIO As String = "PERSONA_HORARIO"
    Friend Const PERSONA_HORARIO_AGREGAR As String = "PERSONA_HORARIO_AGREGAR"
    Friend Const PERSONA_HORARIO_EDITAR As String = "PERSONA_HORARIO_EDITAR"
    Friend Const PERSONA_HORARIO_ELIMINAR As String = "PERSONA_HORARIO_ELIMINAR"
    Friend Const PERSONA_HORARIO_IMPRIMIR As String = "PERSONA_HORARIO_IMPRIMIR"

    Friend Const PERSONA_VEHICULO As String = "PERSONA_VEHICULO"
    Friend Const PERSONA_VEHICULO_AGREGAR As String = "PERSONA_VEHICULO_AGREGAR"
    Friend Const PERSONA_VEHICULO_EDITAR As String = "PERSONA_VEHICULO_EDITAR"
    Friend Const PERSONA_VEHICULO_ELIMINAR As String = "PERSONA_VEHICULO_ELIMINAR"

    Friend Const PERSONA_VACUNA As String = "PERSONA_VACUNA"
    Friend Const PERSONA_VACUNA_AGREGAR As String = "PERSONA_VACUNA_AGREGAR"
    Friend Const PERSONA_VACUNA_EDITAR As String = "PERSONA_VACUNA_EDITAR"
    Friend Const PERSONA_VACUNA_ELIMINAR As String = "PERSONA_VACUNA_ELIMINAR"

    Friend Const PERSONA_LICENCIA As String = "PERSONA_LICENCIA"
    Friend Const PERSONA_LICENCIA_AGREGAR As String = "PERSONA_LICENCIA_AGREGAR"
    Friend Const PERSONA_LICENCIA_EDITAR As String = "PERSONA_LICENCIA_EDITAR"
    Friend Const PERSONA_LICENCIA_ELIMINAR As String = "PERSONA_LICENCIA_ELIMINAR"
    Friend Const PERSONA_LICENCIA_IGNORARRESTRICCIONFECHAS As String = "PERSONA_LICENCIA_IGNORARRESTRICCIONFECHAS"
    Friend Const PERSONA_LICENCIA_IMPRIMIR As String = "PERSONA_LICENCIA_IMPRIMIR"

    Friend Const PERSONA_LICENCIAESPECIAL As String = "PERSONA_LICENCIAESPECIAL"
    Friend Const PERSONA_LICENCIAESPECIAL_AGREGAR As String = "PERSONA_LICENCIAESPECIAL_AGREGAR"
    Friend Const PERSONA_LICENCIAESPECIAL_EDITAR As String = "PERSONA_LICENCIAESPECIAL_EDITAR"
    Friend Const PERSONA_LICENCIAESPECIAL_ELIMINAR As String = "PERSONA_LICENCIAESPECIAL_ELIMINAR"

    Friend Const PERSONA_SANCION As String = "PERSONA_SANCION"
    Friend Const PERSONA_SANCION_AGREGAR As String = "PERSONA_SANCION_AGREGAR"
    Friend Const PERSONA_SANCION_EDITAR As String = "PERSONA_SANCION_EDITAR"
    Friend Const PERSONA_SANCION_ELIMINAR As String = "PERSONA_SANCION_ELIMINAR"
    Friend Const PERSONA_SANCION_IMPRIMIR As String = "PERSONA_SANCION_IMPRIMIR"

    Friend Const PERSONA_CAPACITACION As String = "PERSONA_CAPACITACION"
    Friend Const PERSONA_CAPACITACION_AGREGAR As String = "PERSONA_CAPACITACION_AGREGAR"
    Friend Const PERSONA_CAPACITACION_EDITAR As String = "PERSONA_CAPACITACION_EDITAR"
    Friend Const PERSONA_CAPACITACION_ELIMINAR As String = "PERSONA_CAPACITACION_ELIMINAR"

    Friend Const PERSONA_CALIFICACION As String = "PERSONA_CALIFICACION"
    Friend Const PERSONA_CALIFICACION_AGREGAR As String = "PERSONA_CALIFICACION_AGREGAR"
    Friend Const PERSONA_CALIFICACION_EDITAR As String = "PERSONA_CALIFICACION_EDITAR"
    Friend Const PERSONA_CALIFICACION_ELIMINAR As String = "PERSONA_CALIFICACION_ELIMINAR"
    Friend Const PERSONA_CALIFICACION_IMPRIMIR As String = "PERSONA_CALIFICACION_IMPRIMIR"

    Friend Const PERSONA_EXAMEN As String = "PERSONA_EXAMEN"
    Friend Const PERSONA_EXAMEN_AGREGAR As String = "PERSONA_EXAMEN_AGREGAR"
    Friend Const PERSONA_EXAMEN_EDITAR As String = "PERSONA_EXAMEN_EDITAR"
    Friend Const PERSONA_EXAMEN_ELIMINAR As String = "PERSONA_EXAMEN_ELIMINAR"

    Friend Const ELEMENTO As String = "ELEMENTO"
    Friend Const ELEMENTO_AGREGAR As String = "ELEMENTO_AGREGAR"
    Friend Const ELEMENTO_EDITAR As String = "ELEMENTO_EDITAR"
    Friend Const ELEMENTO_ELIMINAR As String = "ELEMENTO_ELIMINAR"

    Friend Const INVENTARIO As String = "INVENTARIO"
    Friend Const INVENTARIO_AGREGAR As String = "INVENTARIO_AGREGAR"
    Friend Const INVENTARIO_EDITAR As String = "INVENTARIO_EDITAR"
    Friend Const INVENTARIO_ELIMINAR As String = "INVENTARIO_ELIMINAR"

    Friend Const UNIDAD As String = "UNIDAD"
    Friend Const UNIDAD_AGREGAR As String = "UNIDAD_AGREGAR"
    Friend Const UNIDAD_EDITAR As String = "UNIDAD_EDITAR"
    Friend Const UNIDAD_ELIMINAR As String = "UNIDAD_ELIMINAR"

    Friend Const COMPRA As String = "COMPRA"
    Friend Const COMPRA_AGREGAR As String = "COMPRA_AGREGAR"
    Friend Const COMPRA_EDITAR As String = "COMPRA_EDITAR"
    Friend Const COMPRA_EDITAR_CERRADA As String = "COMPRA_EDITAR_CERRADA"
    Friend Const COMPRA_ELIMINAR As String = "COMPRA_ELIMINAR"
    Friend Const COMPRA_ELIMINAR_CERRADA As String = "COMPRA_ELIMINAR_CERRADA"
    Friend Const COMPRA_IMPRIMIR As String = "COMPRA_IMPRIMIR"
    Friend Const COMPRA_IMPRIMIR_CERRADA As String = "COMPRA_IMPRIMIR_CERRADA"

    Friend Const CAJAARQUEO As String = "CAJAARQUEO"
    Friend Const CAJAARQUEO_AGREGAR As String = "CAJAARQUEO_AGREGAR"
    Friend Const CAJAARQUEO_EDITAR As String = "CAJAARQUEO_EDITAR"
    Friend Const CAJAARQUEO_EDITAR_CERRADA As String = "CAJAARQUEO_EDITAR_CERRADA"
    Friend Const CAJAARQUEO_ELIMINAR As String = "CAJAARQUEO_ELIMINAR"
    Friend Const CAJAARQUEO_ELIMINAR_CERRADA As String = "CAJAARQUEO_ELIMINAR_CERRADA"
    Friend Const CAJAARQUEO_IMPRIMIR As String = "CAJAARQUEO_IMPRIMIR"
    Friend Const CAJAARQUEO_IMPRIMIR_CERRADA As String = "CAJAARQUEO_IMPRIMIR_CERRADA"

    Friend Const SINIESTRORUBRO As String = "SINIESTRORUBRO"
    Friend Const SINIESTRORUBRO_AGREGAR As String = "SINIESTRORUBRO_AGREGAR"
    Friend Const SINIESTRORUBRO_EDITAR As String = "SINIESTRORUBRO_EDITAR"
    Friend Const SINIESTRORUBRO_ELIMINAR As String = "SINIESTRORUBRO_ELIMINAR"

    Friend Const SINIESTROTIPO As String = "SINIESTROTIPO"
    Friend Const SINIESTROTIPO_AGREGAR As String = "SINIESTROTIPO_AGREGAR"
    Friend Const SINIESTROTIPO_EDITAR As String = "SINIESTROTIPO_EDITAR"
    Friend Const SINIESTROTIPO_ELIMINAR As String = "SINIESTROTIPO_ELIMINAR"

    Friend Const SINIESTROCLAVE As String = "SINIESTROCLAVE"
    Friend Const SINIESTROCLAVE_AGREGAR As String = "SINIESTROCLAVE_AGREGAR"
    Friend Const SINIESTROCLAVE_EDITAR As String = "SINIESTROCLAVE_EDITAR"
    Friend Const SINIESTROCLAVE_ELIMINAR As String = "SINIESTROCLAVE_ELIMINAR"

    Friend Const SINIESTROASISTENCIATIPO As String = "SINIESTROASISTENCIATIPO"
    Friend Const SINIESTROASISTENCIATIPO_AGREGAR As String = "SINIESTROASISTENCIATIPO_AGREGAR"
    Friend Const SINIESTROASISTENCIATIPO_EDITAR As String = "SINIESTROASISTENCIATIPO_EDITAR"
    Friend Const SINIESTROASISTENCIATIPO_ELIMINAR As String = "SINIESTROASISTENCIATIPO_ELIMINAR"

    Friend Const SINIESTRO As String = "SINIESTRO"
    Friend Const SINIESTRO_AGREGAR As String = "SINIESTRO_AGREGAR"
    Friend Const SINIESTRO_EDITAR As String = "SINIESTRO_EDITAR"
    Friend Const SINIESTRO_ELIMINAR As String = "SINIESTRO_ELIMINAR"

    Friend Const ACADEMIATIPO As String = "ACADEMIATIPO"
    Friend Const ACADEMIATIPO_AGREGAR As String = "ACADEMIATIPO_AGREGAR"
    Friend Const ACADEMIATIPO_EDITAR As String = "ACADEMIATIPO_EDITAR"
    Friend Const ACADEMIATIPO_ELIMINAR As String = "ACADEMIATIPO_ELIMINAR"

    Friend Const ACADEMIAASISTENCIATIPO As String = "ACADEMIAASISTENCIATIPO"
    Friend Const ACADEMIAASISTENCIATIPO_AGREGAR As String = "ACADEMIAASISTENCIATIPO_AGREGAR"
    Friend Const ACADEMIAASISTENCIATIPO_EDITAR As String = "ACADEMIAASISTENCIATIPO_EDITAR"
    Friend Const ACADEMIAASISTENCIATIPO_ELIMINAR As String = "ACADEMIAASISTENCIATIPO_ELIMINAR"

    Friend Const ACADEMIA As String = "ACADEMIA"
    Friend Const ACADEMIA_AGREGAR As String = "ACADEMIA_AGREGAR"
    Friend Const ACADEMIA_EDITAR As String = "ACADEMIA_EDITAR"
    Friend Const ACADEMIA_ELIMINAR As String = "ACADEMIA_ELIMINAR"

    Friend Const REPORTE_DOCUMENTACIONES As String = "REPORTE_DOCUMENTACIONES"
    Friend Const REPORTE_JEFATURA As String = "REPORTE_JEFATURA"

    Friend Const DESCRIPCION_AGREGAR As String = "Agregar"
    Friend Const DESCRIPCION_EDITAR As String = "Editar"
    Friend Const DESCRIPCION_ELIMINAR As String = "Eliminar"
    Friend Const DESCRIPCION_IMPRIMIR As String = "Imprimir"

#End Region

#Region "Verificación de permisos"

    Friend Function VerificarPermiso(ByVal IDPermiso As String, Optional ByVal MostrarAviso As Boolean = True) As Boolean
        If pUsuario.IDUsuarioGrupo = USUARIOGRUPO_ADMINISTRADORES_ID Then
            Return True
        Else
            If pPermisos.Find(Function(p) p.IDPermiso.TrimEnd = IDPermiso) Is Nothing Then
                If MostrarAviso Then
                    MsgBox("No tiene autorización para realizar esta acción.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                End If
                Return False
            Else
                Return True
            End If
        End If
    End Function

    Friend Function VerificarPermisoReporte(ByVal IDReporte As Short, Optional ByVal MostrarAviso As Boolean = True) As Boolean
        If pUsuario.IDUsuarioGrupo = USUARIOGRUPO_ADMINISTRADORES_ID Then
            Return True
        Else
            If Not pPermisosReportes.Any(Function(p) p.IDReporte = IDReporte) Then
                If MostrarAviso Then
                    MsgBox("No tiene autorización para ver este Reporte.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                End If
                Return False
            Else
                Return True
            End If
        End If
    End Function

#End Region

#Region "Asignación de permisos comunes"

    Friend Function AgregarNodos(ByRef parent As TreeNode, ByVal permissionKey As String, ByVal permissionDisplay As String, ByVal permissionAddKey As String, ByVal permissionAddDisplay As String, ByVal permissionEditKey As String, ByVal permissionEditDisplay As String, ByVal permissionDeleteKey As String, ByVal permissionDeleteDisplay As String) As TreeNode
        Dim newNode = parent.Nodes.Add(permissionKey, permissionDisplay)

        With newNode
            .Nodes.Add(permissionAddKey, permissionAddDisplay)
            .Nodes.Add(permissionEditKey, permissionEditDisplay)
            .Nodes.Add(permissionDeleteKey, permissionDeleteDisplay)
        End With
        Return newNode
    End Function

    Friend Sub CargarArbolDePermisos(ByRef Arbol As TreeView, ByVal IDUsuarioGrupo As Byte)
        Dim nodeRoot As TreeNode
        Dim nodeParent As TreeNode
        Dim nodeCurrent As TreeNode

        Arbol.SuspendLayout()
        Application.DoEvents()

        Arbol.Nodes.Clear()

        ' TABLAS
        nodeRoot = Arbol.Nodes.Add("TABLAS", "Tablas")

        ' TABLAS - PERSONAS
        nodeParent = nodeRoot.Nodes.Add("TABLAS_PERSONAS", "Personas")
        AgregarNodos(nodeParent, NIVELESTUDIO, "Niveles de Estudio", NIVELESTUDIO_AGREGAR, DESCRIPCION_AGREGAR, NIVELESTUDIO_EDITAR, DESCRIPCION_EDITAR, NIVELESTUDIO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, ESTADOCIVIL, "Estados Civiles", ESTADOCIVIL_AGREGAR, DESCRIPCION_AGREGAR, ESTADOCIVIL_EDITAR, DESCRIPCION_EDITAR, ESTADOCIVIL_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, PARENTESCO, "Parentescos", PARENTESCO_AGREGAR, DESCRIPCION_AGREGAR, PARENTESCO_EDITAR, DESCRIPCION_EDITAR, PARENTESCO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, PERSONABAJAMOTIVO, "Motivos de baja de personas", PERSONABAJAMOTIVO_AGREGAR, DESCRIPCION_AGREGAR, PERSONABAJAMOTIVO_EDITAR, DESCRIPCION_EDITAR, PERSONABAJAMOTIVO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, CARGO, "Cargos", CARGO_AGREGAR, DESCRIPCION_AGREGAR, CARGO_EDITAR, DESCRIPCION_EDITAR, CARGO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, CARGOJERARQUIA, "Jerarquías", CARGOJERARQUIA_AGREGAR, DESCRIPCION_AGREGAR, CARGOJERARQUIA_EDITAR, DESCRIPCION_EDITAR, CARGOJERARQUIA_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, VEHICULOTIPO, "Tipos de vehículos", VEHICULOTIPO_AGREGAR, DESCRIPCION_AGREGAR, VEHICULOTIPO_EDITAR, DESCRIPCION_EDITAR, VEHICULOTIPO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, VEHICULOMARCA, "Marcas de vehículos", VEHICULOMARCA_AGREGAR, DESCRIPCION_AGREGAR, VEHICULOMARCA_EDITAR, DESCRIPCION_EDITAR, VEHICULOMARCA_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, VEHICULOCOMPANIASEGURO, "Compañías de seguros de vehículos", VEHICULOCOMPANIASEGURO_AGREGAR, DESCRIPCION_AGREGAR, VEHICULOCOMPANIASEGURO_EDITAR, DESCRIPCION_EDITAR, VEHICULOCOMPANIASEGURO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, VACUNATIPO, "Tipos de vacunas", VACUNATIPO_AGREGAR, DESCRIPCION_AGREGAR, VACUNATIPO_EDITAR, DESCRIPCION_EDITAR, VACUNATIPO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, LICENCIACAUSA, "Causales de licencia", LICENCIACAUSA_AGREGAR, DESCRIPCION_AGREGAR, LICENCIACAUSA_EDITAR, DESCRIPCION_EDITAR, LICENCIACAUSA_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, SANCIONTIPO, "Tipos de sanción", SANCIONTIPO_AGREGAR, DESCRIPCION_AGREGAR, SANCIONTIPO_EDITAR, DESCRIPCION_EDITAR, SANCIONTIPO_ELIMINAR, DESCRIPCION_ELIMINAR)

        ' TABLAS - CAPACITACIONES
        nodeParent = nodeRoot.Nodes.Add("TABLAS_CAPACITACIONES", "Capacitaciones")
        AgregarNodos(nodeParent, CURSO, "Cursos", CURSO_AGREGAR, DESCRIPCION_AGREGAR, CURSO_EDITAR, DESCRIPCION_EDITAR, CURSO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, CAPACITACIONNIVEL, "Niveles de capacitación", CAPACITACIONNIVEL_AGREGAR, DESCRIPCION_AGREGAR, CAPACITACIONNIVEL_EDITAR, DESCRIPCION_EDITAR, CAPACITACIONNIVEL_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, CAPACITACIONTIPO, "Tipos de capacitación", CAPACITACIONTIPO_AGREGAR, DESCRIPCION_AGREGAR, CAPACITACIONTIPO_EDITAR, DESCRIPCION_EDITAR, CAPACITACIONTIPO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, CALIFICACIONCONCEPTO, "Conceptos de calificación", CALIFICACIONCONCEPTO_AGREGAR, DESCRIPCION_AGREGAR, CALIFICACIONCONCEPTO_EDITAR, DESCRIPCION_EDITAR, CALIFICACIONCONCEPTO_ELIMINAR, DESCRIPCION_ELIMINAR)

        ' TABLAS - UNIDADES
        nodeParent = nodeRoot.Nodes.Add("TABLAS_UNIDADES", "Unidades")
        AgregarNodos(nodeParent, UNIDADTIPO, "Tipos de automotor", UNIDADTIPO_AGREGAR, DESCRIPCION_AGREGAR, UNIDADTIPO_EDITAR, DESCRIPCION_EDITAR, UNIDADTIPO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, UNIDADUSO, "Usos de automotor", UNIDADUSO_AGREGAR, DESCRIPCION_AGREGAR, UNIDADUSO_EDITAR, DESCRIPCION_EDITAR, UNIDADUSO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, UNIDADBAJAMOTIVO, "Motivos de baja de automotor", UNIDADBAJAMOTIVO_AGREGAR, DESCRIPCION_AGREGAR, UNIDADBAJAMOTIVO_EDITAR, DESCRIPCION_EDITAR, UNIDADBAJAMOTIVO_ELIMINAR, DESCRIPCION_ELIMINAR)

        ' TABLAS - INVENTARIO
        nodeParent = nodeRoot.Nodes.Add("TABLAS_INVENTARIO", "Inventario")
        AgregarNodos(nodeParent, RUBRO, "Rubros de elementos", RUBRO_AGREGAR, DESCRIPCION_AGREGAR, RUBRO_EDITAR, DESCRIPCION_EDITAR, RUBRO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, SUBRUBRO, "Sub-rubros de elementos", SUBRUBRO_AGREGAR, DESCRIPCION_AGREGAR, SUBRUBRO_EDITAR, DESCRIPCION_EDITAR, SUBRUBRO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, UBICACION, "Ubicaciones", UBICACION_AGREGAR, DESCRIPCION_AGREGAR, UBICACION_EDITAR, DESCRIPCION_EDITAR, UBICACION_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, SUBUBICACION, "Sub-ubicaciones", SUBUBICACION_AGREGAR, DESCRIPCION_AGREGAR, SUBUBICACION_EDITAR, DESCRIPCION_EDITAR, SUBUBICACION_ELIMINAR, DESCRIPCION_ELIMINAR)

        ' TABLAS - ACADEMIAS
        nodeParent = nodeRoot.Nodes.Add("TABLAS_ACADEMIAS", "Academias")
        AgregarNodos(nodeParent, ACADEMIATIPO, "Tipos de Academias", ACADEMIATIPO_AGREGAR, DESCRIPCION_AGREGAR, ACADEMIATIPO_EDITAR, DESCRIPCION_EDITAR, ACADEMIATIPO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, ACADEMIAASISTENCIATIPO, "Tipos de Asistencia a Academias", ACADEMIAASISTENCIATIPO_AGREGAR, DESCRIPCION_AGREGAR, ACADEMIAASISTENCIATIPO_EDITAR, DESCRIPCION_EDITAR, ACADEMIAASISTENCIATIPO_ELIMINAR, DESCRIPCION_ELIMINAR)

        ' TABLAS - SINIESTROS
        nodeParent = nodeRoot.Nodes.Add("TABLAS_GUARDIA", "Guardia")
        AgregarNodos(nodeParent, SINIESTRORUBRO, "Rubros de Siniestros", SINIESTRORUBRO_AGREGAR, DESCRIPCION_AGREGAR, SINIESTRORUBRO_EDITAR, DESCRIPCION_EDITAR, SINIESTRORUBRO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, SINIESTROTIPO, "Tipos de Siniestros", SINIESTROTIPO_AGREGAR, DESCRIPCION_AGREGAR, SINIESTROTIPO_EDITAR, DESCRIPCION_EDITAR, SINIESTROTIPO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, SINIESTROCLAVE, "Claves de Siniestros", SINIESTROCLAVE_AGREGAR, DESCRIPCION_AGREGAR, SINIESTROCLAVE_EDITAR, DESCRIPCION_EDITAR, SINIESTROCLAVE_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, SINIESTROASISTENCIATIPO, "Tipos de Asistencia a Siniestros", SINIESTROASISTENCIATIPO_AGREGAR, DESCRIPCION_AGREGAR, SINIESTROASISTENCIATIPO_EDITAR, DESCRIPCION_EDITAR, SINIESTROASISTENCIATIPO_ELIMINAR, DESCRIPCION_ELIMINAR)

        ' TABLAS - USUARIOS
        nodeParent = nodeRoot.Nodes.Add("TABLAS_USUARIOS", "Usuarios")
        AgregarNodos(nodeParent, USUARIOGRUPO, "Grupos de usuarios", USUARIOGRUPO_AGREGAR, DESCRIPCION_AGREGAR, USUARIOGRUPO_EDITAR, DESCRIPCION_EDITAR, USUARIOGRUPO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, USUARIO, "Usuarios", USUARIO_AGREGAR, DESCRIPCION_AGREGAR, USUARIO_EDITAR, DESCRIPCION_EDITAR, USUARIO_ELIMINAR, DESCRIPCION_ELIMINAR)
        nodeParent.Nodes.Add(USUARIOGRUPOPERMISO, "Permisos")

        ' TABLAS - OTROS
        nodeParent = nodeRoot.Nodes.Add("TABLAS_OTROS", "Otros")
        AgregarNodos(nodeParent, CUARTEL, "Cuarteles", CUARTEL_AGREGAR, DESCRIPCION_AGREGAR, CUARTEL_EDITAR, DESCRIPCION_EDITAR, CUARTEL_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, AREA, "Áreas", AREA_AGREGAR, DESCRIPCION_AGREGAR, AREA_EDITAR, DESCRIPCION_EDITAR, AREA_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, ALARMA, "Alarmas", ALARMA_AGREGAR, DESCRIPCION_AGREGAR, ALARMA_EDITAR, DESCRIPCION_EDITAR, ALARMA_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, RESPONSABLETIPO, "Tipos de Responsable", RESPONSABLETIPO_AGREGAR, DESCRIPCION_AGREGAR, RESPONSABLETIPO_EDITAR, DESCRIPCION_EDITAR, RESPONSABLETIPO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, RESPONSABLE, "Responsables", RESPONSABLE_AGREGAR, DESCRIPCION_AGREGAR, RESPONSABLE_EDITAR, DESCRIPCION_EDITAR, RESPONSABLE_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, PROVEEDOR, "Proveedores", PROVEEDOR_AGREGAR, DESCRIPCION_AGREGAR, PROVEEDOR_EDITAR, DESCRIPCION_EDITAR, PROVEEDOR_ELIMINAR, DESCRIPCION_ELIMINAR)

        ' DOCUMENTACIONES
        nodeRoot = Arbol.Nodes.Add("DOCUMENTACIONES", "Documentaciones")

        ' DOCUMENTACIONES - PERSONAS
        nodeCurrent = AgregarNodos(nodeRoot, PERSONA, "Personas", PERSONA_AGREGAR, DESCRIPCION_AGREGAR, PERSONA_EDITAR, DESCRIPCION_EDITAR, PERSONA_ELIMINAR, DESCRIPCION_ELIMINAR)
        nodeCurrent.Nodes.Add(PERSONA_IMPRIMIR, DESCRIPCION_IMPRIMIR)
        nodeParent = nodeCurrent
        AgregarNodos(nodeParent, PERSONA_FAMILIAR, "Familiares", PERSONA_FAMILIAR_AGREGAR, DESCRIPCION_AGREGAR, PERSONA_FAMILIAR_EDITAR, DESCRIPCION_EDITAR, PERSONA_FAMILIAR_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, PERSONA_ALTABAJA, "Altas y Bajas", PERSONA_ALTABAJA_AGREGAR, DESCRIPCION_AGREGAR, PERSONA_ALTABAJA_EDITAR, DESCRIPCION_EDITAR, PERSONA_ALTABAJA_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, PERSONA_ASCENSO, "Ascensos", PERSONA_ASCENSO_AGREGAR, DESCRIPCION_AGREGAR, PERSONA_ASCENSO_EDITAR, DESCRIPCION_EDITAR, PERSONA_ASCENSO_ELIMINAR, DESCRIPCION_ELIMINAR)
        nodeCurrent = AgregarNodos(nodeParent, PERSONA_HORARIO, "Horarios", PERSONA_HORARIO_AGREGAR, DESCRIPCION_AGREGAR, PERSONA_HORARIO_EDITAR, DESCRIPCION_EDITAR, PERSONA_HORARIO_ELIMINAR, DESCRIPCION_ELIMINAR)
        nodeCurrent.Nodes.Add(PERSONA_HORARIO_IMPRIMIR, DESCRIPCION_IMPRIMIR)
        AgregarNodos(nodeParent, PERSONA_VEHICULO, "Vehículos", PERSONA_VEHICULO_AGREGAR, DESCRIPCION_AGREGAR, PERSONA_VEHICULO_EDITAR, DESCRIPCION_EDITAR, PERSONA_VEHICULO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, PERSONA_VACUNA, "Vacunas", PERSONA_VACUNA_AGREGAR, DESCRIPCION_AGREGAR, PERSONA_VACUNA_EDITAR, DESCRIPCION_EDITAR, PERSONA_VACUNA_ELIMINAR, DESCRIPCION_ELIMINAR)
        nodeCurrent = AgregarNodos(nodeParent, PERSONA_LICENCIA, "Licencias", PERSONA_LICENCIA_AGREGAR, DESCRIPCION_AGREGAR, PERSONA_LICENCIA_EDITAR, DESCRIPCION_EDITAR, PERSONA_LICENCIA_ELIMINAR, DESCRIPCION_ELIMINAR)
        nodeCurrent.Nodes.Add(PERSONA_LICENCIA_IGNORARRESTRICCIONFECHAS, "Ignorar restricciones de fechas y veces anuales")
        nodeCurrent.Nodes.Add(PERSONA_LICENCIA_IMPRIMIR, DESCRIPCION_IMPRIMIR)
        AgregarNodos(nodeParent, PERSONA_LICENCIAESPECIAL, "Licencias especiales", PERSONA_LICENCIAESPECIAL_AGREGAR, DESCRIPCION_AGREGAR, PERSONA_LICENCIAESPECIAL_EDITAR, DESCRIPCION_EDITAR, PERSONA_LICENCIAESPECIAL_ELIMINAR, DESCRIPCION_ELIMINAR)
        nodeCurrent = AgregarNodos(nodeParent, PERSONA_SANCION, "Sanciones", PERSONA_SANCION_AGREGAR, DESCRIPCION_AGREGAR, PERSONA_SANCION_EDITAR, DESCRIPCION_EDITAR, PERSONA_SANCION_ELIMINAR, DESCRIPCION_ELIMINAR)
        nodeCurrent.Nodes.Add(PERSONA_SANCION_IMPRIMIR, DESCRIPCION_IMPRIMIR)
        AgregarNodos(nodeParent, PERSONA_CAPACITACION, "Capacitaciones", PERSONA_CAPACITACION_AGREGAR, DESCRIPCION_AGREGAR, PERSONA_CAPACITACION_EDITAR, DESCRIPCION_EDITAR, PERSONA_CAPACITACION_ELIMINAR, DESCRIPCION_ELIMINAR)
        nodeCurrent = AgregarNodos(nodeParent, PERSONA_CALIFICACION, "Calificaciones", PERSONA_CALIFICACION_AGREGAR, DESCRIPCION_AGREGAR, PERSONA_CALIFICACION_EDITAR, DESCRIPCION_EDITAR, PERSONA_CALIFICACION_ELIMINAR, DESCRIPCION_ELIMINAR)
        nodeCurrent.Nodes.Add(PERSONA_CALIFICACION_IMPRIMIR, DESCRIPCION_IMPRIMIR)
        AgregarNodos(nodeParent, PERSONA_EXAMEN, "Exámenes", PERSONA_EXAMEN_AGREGAR, DESCRIPCION_AGREGAR, PERSONA_EXAMEN_EDITAR, DESCRIPCION_EDITAR, PERSONA_EXAMEN_ELIMINAR, DESCRIPCION_ELIMINAR)

        ' DOCUMENTACIONES - UNIDADES
        AgregarNodos(nodeRoot, UNIDAD, "Unidades", UNIDAD_AGREGAR, DESCRIPCION_AGREGAR, UNIDAD_EDITAR, DESCRIPCION_EDITAR, UNIDAD_ELIMINAR, DESCRIPCION_ELIMINAR)

        ' DOCUMENTACIONES - INVENTARIO
        nodeParent = AgregarNodos(nodeRoot, INVENTARIO, "Inventario", INVENTARIO_AGREGAR, DESCRIPCION_AGREGAR, INVENTARIO_EDITAR, DESCRIPCION_EDITAR, INVENTARIO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, ELEMENTO, "Elementos", ELEMENTO_AGREGAR, DESCRIPCION_AGREGAR, ELEMENTO_EDITAR, DESCRIPCION_EDITAR, ELEMENTO_ELIMINAR, DESCRIPCION_ELIMINAR)

        ' DOCUMENTACIONES - REPORTES
        nodeParent = nodeRoot.Nodes.Add(REPORTE_DOCUMENTACIONES, "Reportes")

        ' JEFATURA
        nodeRoot = Arbol.Nodes.Add("JEFATURA", "Jefatura")

        ' JEFATURA - COMPRAS
        nodeCurrent = AgregarNodos(nodeRoot, COMPRA, "Compras", COMPRA_AGREGAR, DESCRIPCION_AGREGAR, COMPRA_EDITAR, DESCRIPCION_EDITAR, COMPRA_ELIMINAR, DESCRIPCION_ELIMINAR)
        nodeCurrent.Nodes.Add(COMPRA_IMPRIMIR, DESCRIPCION_IMPRIMIR)
        nodeCurrent.Nodes.Add(COMPRA_EDITAR_CERRADA, DESCRIPCION_EDITAR & " compra cerrada")
        nodeCurrent.Nodes.Add(COMPRA_ELIMINAR_CERRADA, DESCRIPCION_ELIMINAR & " compra cerrada")
        nodeCurrent.Nodes.Add(COMPRA_IMPRIMIR_CERRADA, DESCRIPCION_IMPRIMIR & " compra cerrada")

        ' JEFATURA - ARQUEOS DE CAJA
        nodeCurrent = AgregarNodos(nodeRoot, CAJAARQUEO, "Arqueos de caja", CAJAARQUEO_AGREGAR, DESCRIPCION_AGREGAR, CAJAARQUEO_EDITAR, DESCRIPCION_EDITAR, CAJAARQUEO_ELIMINAR, DESCRIPCION_ELIMINAR)
        nodeCurrent.Nodes.Add(CAJAARQUEO_IMPRIMIR, DESCRIPCION_IMPRIMIR)
        nodeCurrent.Nodes.Add(CAJAARQUEO_EDITAR_CERRADA, DESCRIPCION_EDITAR & " arqueo de caja cerrado")
        nodeCurrent.Nodes.Add(CAJAARQUEO_ELIMINAR_CERRADA, DESCRIPCION_ELIMINAR & " arqueo de caja cerrado")
        nodeCurrent.Nodes.Add(CAJAARQUEO_IMPRIMIR_CERRADA, DESCRIPCION_IMPRIMIR & " arqueo de caja cerrado")

        ' JEFATURA - REPORTES
        nodeParent = nodeRoot.Nodes.Add(REPORTE_JEFATURA, "Reportes")

        ' GUARDIA
        nodeRoot = Arbol.Nodes.Add("GUARDIA", "Guardia")

        ' GUARDIA - SINIESTROS
        AgregarNodos(nodeRoot, SINIESTRO, "Siniestros", SINIESTRO_AGREGAR, DESCRIPCION_AGREGAR, SINIESTRO_EDITAR, DESCRIPCION_EDITAR, SINIESTRO_ELIMINAR, DESCRIPCION_ELIMINAR)

        Arbol.TopNode = Arbol.Nodes(0)

        ' Muestro los permisos asignados
        MostrarPermisosEstablecidos(Arbol, IDUsuarioGrupo)

        Arbol.ResumeLayout()
    End Sub

    Private Sub MostrarPermisosEstablecidos(ByRef Arbol As TreeView, ByVal IDUsuarioGrupo As Byte)
        Dim listPermisos As List(Of UsuarioGrupoPermiso)

        ' Obtengo la lista de permisos para el Grupo de Usuarios
        Using dbcontext As New CSBomberosContext(True)
            Try
                listPermisos = dbcontext.UsuarioGrupoPermiso.Where(Function(ugp) ugp.IDUsuarioGrupo = IDUsuarioGrupo).OrderBy(Function(ugp) ugp.IDPermiso).ToList()
            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer la lista de permisos efectivos.")
                Exit Sub
            End Try
        End Using

        ' Marco los items del Tree View que tienen asignado el permiso
        For Each permiso As UsuarioGrupoPermiso In listPermisos
            ' Arbol.Nodes.Item(permiso.IDPermiso.Trim()).Checked = True
            Arbol.Nodes.Find(permiso.IDPermiso.Trim(), True).First.Checked = True
        Next

        listPermisos = Nothing
    End Sub

#End Region

#Region "Asignación de permisos de reportes"

    Friend Sub CargarArbolDePermisosDeReportes(ByRef context As CSBomberosContext, ByRef arbol As TreeView, ByVal idUsuarioGrupo As Byte)
        Dim ModuloNodo As TreeNode
        Dim ReporteGrupoNodo As TreeNode
        Dim ReporteNodo As TreeNode

        Try
            arbol.SuspendLayout()
            Application.DoEvents()

            arbol.Nodes.Clear()

            For Each modulo As Modulo In context.Modulo.Where(Function(m) m.EsActivo).OrderBy(Function(m) m.Orden).ThenBy(Function(m) m.Nombre)
                ' Agrego los nodos de los módulos
                ModuloNodo = arbol.Nodes.Add("MODULO_" & modulo.IDModulo, modulo.Nombre)

                For Each reporteGrupo As ReporteGrupo In modulo.ReporteGrupos.OrderBy(Function(rg) rg.Orden).ThenBy(Function(rg) rg.Nombre)
                    If Not reporteGrupo.Reportes.Where(Function(r) r.MostrarEnVisor = True).Any() Then
                        Continue For
                    End If

                    ' Agrego el Grupo de Reportes
                    ReporteGrupoNodo = ModuloNodo.Nodes.Add("GRUPO_" & reporteGrupo.IDReporteGrupo, reporteGrupo.Nombre)

                    For Each reporte As Reporte In reporteGrupo.Reportes.Where(Function(r) r.MostrarEnVisor = True).OrderBy(Function(r) r.Orden).ThenBy(Function(r) r.Nombre)
                        If Permisos.VerificarPermisoReporte(reporte.IDReporte, False) Then
                            ' Agrego el Reporte
                            ReporteNodo = ReporteGrupoNodo.Nodes.Add("REPORTE_" & reporte.IDReporte, reporte.Nombre)
                        End If
                    Next
                Next
            Next

            arbol.TopNode = arbol.Nodes(0)

            ' Muestro los permisos asignados
            MostrarPermisosEstablecidosDeReportes(context, arbol, idUsuarioGrupo)

            arbol.ResumeLayout()

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer la lista de Reportes.")
        End Try

    End Sub

    Private Sub MostrarPermisosEstablecidosDeReportes(ByRef context As CSBomberosContext, ByRef arbol As TreeView, ByVal idUsuarioGrupo As Byte)
        Dim listReportes As List(Of Reporte)

        ' Obtengo la lista de permisos de reportes para el Grupo de Usuarios
        Try
            listReportes = context.UsuarioGrupo.Find(idUsuarioGrupo).Reporte.OrderBy(Function(r) r.IDReporte).ToList()
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer la lista de permisos de reportes efectivos.")
            Exit Sub
        End Try

        ' Marco los items del Tree View que tienen asignado el permiso
        For Each reporte As Reporte In listReportes
            arbol.Nodes.Find("REPORTE_" & reporte.IDReporte, True).First.Checked = True
        Next

        listReportes = Nothing
    End Sub

#End Region

End Module
