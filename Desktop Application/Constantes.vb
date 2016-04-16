Module Constantes
    '//////////////////
    '    APLICACIÓN
    '//////////////////
    Friend Const APPLICATION_DATABASE_GUID As String = "{221CD8DA-7B56-44BA-9B49-AD9AA761A6EC}"
    Friend Const FILTER_ACTIVO_LIST_INDEX As Long = 1
    Friend Const ENCRYPTION_PASSWORD As String = "CmcaTlMdmA,aTmP,am2CyalhdEb"
    Friend Const ENCRYPTION_VECTOR As String = "DaVsmpca#Tmd1Bv@"

    '//////////////////
    '    BÁSICAS
    '//////////////////
    Friend Const KEY_STRINGER As String = "@"
    Friend Const KEY_DELIMITER As String = "|@|"

    Friend Const STRING_LIST_SEPARATOR As String = "|"
    Friend Const STRING_LIST_DELIMITER As String = "¬"

    Friend Const DATE_TIME_FIELD_NULL_VALUE As Date = #12:00:00 AM#

    '//////////////////
    '    VARIOS
    '//////////////////
    Friend Const PERSONA_GENERO_NOESPECIFICA As String = "-"
    Friend Const PERSONA_GENERO_MASCULINO As String = "M"
    Friend Const PERSONA_GENERO_FEMENINO As String = "F"

    Friend Const PROVINCIA_NOESPECIFICA As Byte = 255

    Friend Const PERSONA_ESTADO_ACTIVO As String = "A"
    Friend Const PERSONA_ESTADO_RESERVA As String = "R"
    Friend Const PERSONA_ESTADO_CUERPOAUXILIAR As String = "C"
    Friend Const PERSONA_ESTADO_BAJA As String = "B"

    Friend Const OPERACIONTIPO_COMPRA As String = "C"
    Friend Const OPERACIONTIPO_VENTA As String = "V"

    Friend Const MOVIMIENTOTIPO_CREDITO As String = "C"
    Friend Const MOVIMIENTOTIPO_DEBITO As String = "D"

    Friend Const COMPROBANTE_PUNTOVENTA_CARACTERES As Byte = 4
    Friend Const COMPROBANTE_NUMERO_CARACTERES As Byte = 8

    Friend Const COMPROBANTE_CONCEPTO_PRODUCTO As Byte = 1
    Friend Const COMPROBANTE_CONCEPTO_SERVICIOS As Byte = 2
    Friend Const COMPROBANTE_CONCEPTO_PRODUCTOSYSERVICIOS As Byte = 3
    Friend Const COMPROBANTE_CONCEPTO_OTROS As Byte = 4

    '//////////////////
    '    E-MAIL
    '//////////////////
    Friend Const EMAIL_CLIENT_NETDLL As String = "NETCLIENT"
    Friend Const EMAIL_CLIENT_MSOUTLOOK As String = "MSOUTLOOK"
    Friend Const EMAIL_CLIENT_CRYSTALREPORTSMAPI As String = "CRYSTALMAPI"

    '///////////////////////////////////
    '    PARÁMETROS DE LOS REPORTES
    '///////////////////////////////////
    Friend Const REPORTE_PARAMETRO_PERSONA As String = "PERS"

    Friend Const REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER As String = "NUIN"
    Friend Const REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL As String = "NUDE"
    Friend Const REPORTE_PARAMETRO_TIPO_MONEY As String = "MONY"
    Friend Const REPORTE_PARAMETRO_TIPO_DATETIME As String = "DATI"
    Friend Const REPORTE_PARAMETRO_TIPO_DATE As String = "DATE"
    Friend Const REPORTE_PARAMETRO_TIPO_TIME As String = "TIME"
    Friend Const REPORTE_PARAMETRO_TIPO_YEAR_MONTH_FROM As String = "YMFR"
    Friend Const REPORTE_PARAMETRO_TIPO_YEAR_MONTH_TO As String = "YMTO"
    Friend Const REPORTE_PARAMETRO_TIPO_SINO As String = "SINO"
End Module