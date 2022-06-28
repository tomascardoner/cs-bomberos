Friend Module Parametros

#Region "Constantes"

    'SISTEMA
    Friend Const INTERNET_PROXY As String = "INTERNET_PROXY"

    ' APLICACIÓN
    Friend Const APPLICATION_DATABASE_GUID As String = "APPLICATION_DATABASE_GUID"
    Friend Const APPLICATION_DATABASE_VERSION As String = "APPLICATION_DATABASE_VERSION"
    Friend Const LICENSE_COMPANY_NAME As String = "LICENSE_COMPANY_NAME"
    Friend Const USER_PASSWORD_MINIMUM_LENGHT As String = "USER_PASSWORD_MINIMUM_LENGHT"
    Friend Const USER_PASSWORD_SECURE_REQUIRED As String = "USER_PASSWORD_SECURE_REQUIRED"
    Friend Const EMAIL_VALIDATION_REGULAREXPRESSION As String = "EMAIL_VALIDATION_REGULAREXPRESSION"

    ' FINE TUNNING
    Friend Const ACTIVEWINDOW_CHANGE_WAIT_MILLISECONDS As String = "ACTIVEWINDOW_CHANGE_WAIT_MILLISECONDS"

    ' VALORES PREDETERMINADOS
    Friend Const DEFAULT_PROVINCIA_ID As String = "DEFAULT_PROVINCIA_ID"
    Friend Const DEFAULT_LOCALIDAD_ID As String = "DEFAULT_LOCALIDAD_ID"
    Friend Const DEFAULT_CODIGOPOSTAL As String = "DEFAULT_CODIGOPOSTAL"
    Friend Const DEFAULT_CATEGORIAIVA_ID As String = "DEFAULT_CATEGORIAIVA_ID"
    Friend Const DEFAULT_MONEDA_ID As String = "DEFAULT_MONEDA_ID"
    Friend Const DEFAULT_DOCUMENTOTIPO_ID As String = "DEFAULT_DOCUMENTOTIPO_ID"

    ' VARIOS
    Friend Const COMPROBANTE_ENTIDAD_MAYUSCULAS As String = "COMPROBANTE_ENTIDAD_MAYUSCULAS"
    Friend Const CONSUMIDORFINAL_DOCUMENTOTIPO_ID As String = "CONSUMIDORFINAL_DOCUMENTOTIPO_ID"
    Friend Const CONSUMIDORFINAL_DOCUMENTONUMERO As String = "CONSUMIDORFINAL_DOCUMENTONUMERO"
    Friend Const PERSONA_CALIFICACION_INSTANCIA_CANTIDAD As String = "PERSONA_CALIFICACION_INSTANCIA_CANTIDAD"
    Friend Const FILTER_ANIO_INICIAL As String = "FILTER_ANIO_INICIAL"

    ' AFIP WEB SERVICES
    Friend Const AFIP_WS_AA_HOMOLOGACION As String = "AFIP_WS_AA_HOMOLOGACION"
    Friend Const AFIP_WS_AA_PRODUCCION As String = "AFIP_WS_AA_PRODUCCION"
    Friend Const AFIP_WS_FE_HOMOLOGACION As String = "AFIP_WS_FE_HOMOLOGACION"
    Friend Const AFIP_WS_FE_PRODUCCION As String = "AFIP_WS_FE_PRODUCCION"

    ' EMPRESA
    Friend Const EMPRESA_CUIT As String = "EMPRESA_CUIT"
    Friend Const EMPRESA_RAZONSOCIAL As String = "EMPRESA_RAZONSOCIAL"
    Friend Const EMPRESA_DOMICILIOFISCAL_DIRECCION As String = "EMPRESA_DOMICILIOFISCAL_DIRECCION"
    Friend Const EMPRESA_DOMICILIOFISCAL_CODIGOPOSTAL As String = "EMPRESA_DOMICILIOFISCAL_CODIGOPOSTAL"
    Friend Const EMPRESA_DOMICILIOFISCAL_LOCALIDAD_ID As String = "EMPRESA_DOMICILIOFISCAL_LOCALIDAD_ID"
    Friend Const EMPRESA_DOMICILIOFISCAL_PROVINCIA_ID As String = "EMPRESA_DOMICILIOFISCAL_PROVINCIA_ID"
    Friend Const EMPRESA_CATEGORIAIVA_ID As String = "EMPRESA_CATEGORIAIVA_ID"
    Friend Const EMPRESA_IIBB_NUMERO As String = "EMPRESA_IIBB_NUMERO"
    Friend Const EMPRESA_INICIO_ACTIVIDAD As String = "EMPRESA_INICIO_ACTIVIDAD"

    ' PARENTESCOS
    Friend Const PARENTESCO_ID_PADRE As String = "PARENTESCO_ID_PADRE"
    Friend Const PARENTESCO_ID_MADRE As String = "PARENTESCO_ID_MADRE"
    Friend Const PARENTESCO_ID_HIJO As String = "PARENTESCO_ID_HIJO"

    ' REPORTES
    Friend Const REPORTE_ID_PERSONA_FICHA As String = "REPORTE_ID_PERSONA_FICHA"
    Friend Const REPORTE_ID_PERSONA_PLANILLAANUALCALIFICACIONES As String = "REPORTE_ID_PERSONA_PLANILLAANUALCALIFICACIONES"
    Friend Const REPORTE_ID_PERSONA_SANCIONDISCIPLINARIA As String = "REPORTE_ID_PERSONA_SANCIONDISCIPLINARIA"
    Friend Const REPORTE_ID_PERSONA_LICENCIA As String = "REPORTE_ID_PERSONA_LICENCIA"
    Friend Const REPORTE_ID_PERSONA_HORARIOLABORAL As String = "REPORTE_ID_PERSONA_HORARIOLABORAL"
    Friend Const REPORTE_ID_COMPRA_ORDEN As String = "REPORTE_ID_COMPRA_ORDEN"
    Friend Const REPORTE_ID_CAJAARQUEO As String = "REPORTE_ID_CAJAARQUEO"

    ' DIRECCIONES
    Friend Const IOMA_CERTIFICACION_DIRECCION As String = "IOMA_CERTIFICACION_DIRECCION"
    Friend Const IOMA_CERTIFICACION_CAMPOS As String = "IOMA_CERTIFICACION_CAMPOS"
    Friend Const IOMA_PADRON_DIRECCION As String = "IOMA_PADRON_DIRECCION"
    Friend Const IOMA_PADRON_CAMPOS As String = "IOMA_PADRON_CAMPOS"

    ' USUARIOS
    Friend Const USUARIO_INICIOSESION_ALARMA_AVISO_MOSTRAR As String = "USUARIO_INICIOSESION_ALARMA_AVISO_MOSTRAR"

#End Region

    Friend Function LoadParameters() As Boolean
        Dim newLoginData As Boolean

        Do While True
            Try
                Using dbcontext As New CSBomberosContext(True)
                    pParametros = dbcontext.Parametro.ToList
                End Using
                If newLoginData Then
                    Configuration.SaveFileDatabase()
                End If
                Return True
            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al conectarse a la base de datos.")
                Return False
            End Try
        Loop
    End Function

    Friend Function LoadUsuarioPermisosAndParametros() As Boolean
        Try
            Using dbcontext As New CSBomberosContext(True)
                pPermisos = dbcontext.UsuarioGrupoPermiso.Where(Function(p) p.IDUsuarioGrupo = pUsuario.IDUsuarioGrupo).ToList
                pPermisosReportes = dbcontext.UsuarioGrupo.Find(pUsuario.IDUsuarioGrupo).Reportes.ToList
                pUsuarioParametros = dbcontext.UsuarioParametro.Where(Function(up) up.IDUsuario = pUsuario.IDUsuario).ToList
            End Using
            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al cargar los Permisos y los Parámetros del Usuario.")
            Return False

        End Try
    End Function

    Friend Function SaveParameter(parametro As Parametro) As Boolean
        Try
            Using dbcontext As New CSBomberosContext(True)
                Dim parametroExistente As Parametro
                parametroExistente = dbcontext.Parametro.Find(parametro.IDParametro)
                If parametroExistente Is Nothing Then
                    dbcontext.Parametro.Append(parametro)
                Else
                    parametroExistente.Texto = parametro.Texto
                    parametroExistente.NumeroEntero = parametro.NumeroEntero
                    parametroExistente.NumeroDecimal = parametro.NumeroDecimal
                    parametroExistente.Moneda = parametro.Moneda
                    parametroExistente.FechaHora = parametro.FechaHora
                    parametroExistente.SiNo = parametro.SiNo
                    parametroExistente.Notas = parametro.Notas
                End If
                If dbcontext.ChangeTracker.HasChanges() Then
                    dbcontext.SaveChanges()
                End If
            End Using
            Return True
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al conectarse a la base de datos.")
            Return False
        End Try
    End Function

End Module
