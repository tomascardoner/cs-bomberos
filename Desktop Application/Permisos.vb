Module Permisos
    Friend Const PARENTESCO As String = "PARENTESCO"
    Friend Const PARENTESCO_AGREGAR As String = "PARENTESCO_AGREGAR"
    Friend Const PARENTESCO_EDITAR As String = "PARENTESCO_EDITAR"
    Friend Const PARENTESCO_ELIMINAR As String = "PARENTESCO_ELIMINAR"

    Friend Const PERSONA As String = "PERSONA"
    Friend Const PERSONA_AGREGAR As String = "PERSONA_AGREGAR"
    Friend Const PERSONA_EDITAR As String = "PERSONA_EDITAR"
    Friend Const PERSONA_ELIMINAR As String = "PERSONA_ELIMINAR"

    Friend Const PERSONA_ACCIDENTE As String = "PERSONA_ACCIDENTE"
    Friend Const PERSONA_ACCIDENTE_AGREGAR As String = "PERSONA_ACCIDENTE_AGREGAR"
    Friend Const PERSONA_ACCIDENTE_EDITAR As String = "PERSONA_ACCIDENTE_EDITAR"
    Friend Const PERSONA_ACCIDENTE_ELIMINAR As String = "PERSONA_ACCIDENTE_ELIMINAR"

    Friend Const UBICACION As String = "UBICACION"
    Friend Const UBICACION_AGREGAR As String = "UBICACION_AGREGAR"
    Friend Const UBICACION_EDITAR As String = "UBICACION_EDITAR"
    Friend Const UBICACION_ELIMINAR As String = "UBICACION_ELIMINAR"

    Friend Const SUBUBICACION As String = "SUBUBICACION"
    Friend Const SUBUBICACION_AGREGAR As String = "SUBUBICACION_AGREGAR"
    Friend Const SUBUBICACION_EDITAR As String = "SUBUBICACION_EDITAR"
    Friend Const SUBUBICACION_ELIMINAR As String = "SUBUBICACION_ELIMINAR"

    Friend Const ELEMENTO As String = "ELEMENTO"
    Friend Const ELEMENTO_AGREGAR As String = "ELEMENTO_AGREGAR"
    Friend Const ELEMENTO_EDITAR As String = "ELEMENTO_EDITAR"
    Friend Const ELEMENTO_ELIMINAR As String = "ELEMENTO_ELIMINAR"

    Friend Const REPORTE As String = "REPORTE"

    Friend Function VerificarPermiso(ByVal IDPermiso As String, Optional ByVal MostrarAviso As Boolean = True) As Boolean
        If pUsuario.IDUsuarioGrupo = 1 Then
            Return True
        Else
            If pPermisos.Find(Function(usrper) usrper.IDUsuarioGrupo = pUsuario.IDUsuarioGrupo And usrper.IDPermiso.TrimEnd = IDPermiso) Is Nothing Then
                If MostrarAviso Then
                    MsgBox("No tiene autorización para realizar esta acción.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                End If
                Return False
            Else
                Return True
            End If
        End If
    End Function
End Module
