Module Permisos
    Friend Const PARENTESCO As String = "PARENTESCO"
    Friend Const PARENTESCO_AGREGAR As String = "PARENTESCO_AGREGAR"
    Friend Const PARENTESCO_EDITAR As String = "PARENTESCO_EDITAR"
    Friend Const PARENTESCO_ELIMINAR As String = "PARENTESCO_ELIMINAR"

    Friend Const PERSONA As String = "PERSONA"
    Friend Const PERSONA_AGREGAR As String = "PERSONA_AGREGAR"
    Friend Const PERSONA_EDITAR As String = "PERSONA_EDITAR"
    Friend Const PERSONA_ELIMINAR As String = "PERSONA_ELIMINAR"
    Friend Const PERSONA_IMPRIMIR As String = "PERSONA_IMPRIMIR"

    Friend Const PERSONA_ACCIDENTE As String = "PERSONA_ACCIDENTE"
    Friend Const PERSONA_ACCIDENTE_AGREGAR As String = "PERSONA_ACCIDENTE_AGREGAR"
    Friend Const PERSONA_ACCIDENTE_EDITAR As String = "PERSONA_ACCIDENTE_EDITAR"
    Friend Const PERSONA_ACCIDENTE_ELIMINAR As String = "PERSONA_ACCIDENTE_ELIMINAR"

    Friend Const PERSONA_ASCENSO As String = "PERSONA_ASCENSO"
    Friend Const PERSONA_ASCENSO_AGREGAR As String = "PERSONA_ASCENSO_AGREGAR"
    Friend Const PERSONA_ASCENSO_EDITAR As String = "PERSONA_ASCENSO_EDITAR"
    Friend Const PERSONA_ASCENSO_ELIMINAR As String = "PERSONA_ASCENSO_ELIMINAR"

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

    Friend Const AUTOMOTOR As String = "AUTOMOTOR"
    Friend Const AUTOMOTOR_AGREGAR As String = "AUTOMOTOR_AGREGAR"
    Friend Const AUTOMOTOR_EDITAR As String = "AUTOMOTOR_EDITAR"
    Friend Const AUTOMOTOR_ELIMINAR As String = "AUTOMOTOR_ELIMINAR"

    Friend Const REPORTE As String = "REPORTE"

    Friend Const DESCRIPCION_AGREGAR As String = "Agregar"
    Friend Const DESCRIPCION_EDITAR As String = "Editar"
    Friend Const DESCRIPCION_ELIMINAR As String = "Eliminar"
    Friend Const DESCRIPCION_IMPRIMIR As String = "Imprimir"

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

    Friend Sub CargarArbolDePermisos(ByRef Arbol As TreeView, ByVal IDUsuarioGrupo As Byte)
        Dim RootNode As TreeNode

        Arbol.SuspendLayout()

        Arbol.Nodes.Clear()

        RootNode = Arbol.Nodes.Add(PARENTESCO, "Parentescos")
        With RootNode
            .Nodes.Add(PARENTESCO_AGREGAR, DESCRIPCION_AGREGAR)
            .Nodes.Add(PARENTESCO_EDITAR, DESCRIPCION_EDITAR)
            .Nodes.Add(PARENTESCO_ELIMINAR, DESCRIPCION_ELIMINAR)
        End With

        RootNode = Arbol.Nodes.Add(UBICACION, "Ubicaciones")
        With RootNode
            .Nodes.Add(UBICACION_AGREGAR, DESCRIPCION_AGREGAR)
            .Nodes.Add(UBICACION_EDITAR, DESCRIPCION_EDITAR)
            .Nodes.Add(UBICACION_ELIMINAR, DESCRIPCION_ELIMINAR)
        End With

        RootNode = Arbol.Nodes.Add(SUBUBICACION, "Sub-Ubicaciones")
        With RootNode
            .Nodes.Add(SUBUBICACION_AGREGAR, DESCRIPCION_AGREGAR)
            .Nodes.Add(SUBUBICACION_EDITAR, DESCRIPCION_EDITAR)
            .Nodes.Add(SUBUBICACION_ELIMINAR, DESCRIPCION_ELIMINAR)
        End With

        RootNode = Arbol.Nodes.Add(PERSONA, "Personas")
        With RootNode
            .Nodes.Add(PERSONA_AGREGAR, DESCRIPCION_AGREGAR)
            .Nodes.Add(PERSONA_EDITAR, DESCRIPCION_EDITAR)
            .Nodes.Add(PERSONA_ELIMINAR, DESCRIPCION_ELIMINAR)
            .Nodes.Add(PERSONA_IMPRIMIR, DESCRIPCION_IMPRIMIR)
        End With

        RootNode = Arbol.Nodes.Add(PERSONA_ACCIDENTE, "Personas - Accidentes")
        With RootNode
            .Nodes.Add(PERSONA_ACCIDENTE_AGREGAR, DESCRIPCION_AGREGAR)
            .Nodes.Add(PERSONA_ACCIDENTE_EDITAR, DESCRIPCION_EDITAR)
            .Nodes.Add(PERSONA_ACCIDENTE_ELIMINAR, DESCRIPCION_ELIMINAR)
        End With

        RootNode = Arbol.Nodes.Add(PERSONA_ASCENSO, "Personas - Ascensos")
        With RootNode
            .Nodes.Add(PERSONA_ASCENSO_AGREGAR, DESCRIPCION_AGREGAR)
            .Nodes.Add(PERSONA_ASCENSO_EDITAR, DESCRIPCION_EDITAR)
            .Nodes.Add(PERSONA_ASCENSO_ELIMINAR, DESCRIPCION_ELIMINAR)
        End With

        RootNode = Arbol.Nodes.Add(AUTOMOTOR, "Automotores")
        With RootNode
            .Nodes.Add(AUTOMOTOR_AGREGAR, DESCRIPCION_AGREGAR)
            .Nodes.Add(AUTOMOTOR_EDITAR, DESCRIPCION_EDITAR)
            .Nodes.Add(AUTOMOTOR_ELIMINAR, DESCRIPCION_ELIMINAR)
        End With

        RootNode = Arbol.Nodes.Add(ELEMENTO, "Elementos")
        With RootNode
            .Nodes.Add(ELEMENTO_AGREGAR, DESCRIPCION_AGREGAR)
            .Nodes.Add(ELEMENTO_EDITAR, DESCRIPCION_EDITAR)
            .Nodes.Add(ELEMENTO_ELIMINAR, DESCRIPCION_ELIMINAR)
        End With

        RootNode = Arbol.Nodes.Add(REPORTE, "Reportes")

        Arbol.ExpandAll()

        Arbol.ResumeLayout()
    End Sub
End Module
