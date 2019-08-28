Module Constantes
    '//////////////////
    '    APLICACIÓN
    '//////////////////
    Friend Const APPLICATION_DATABASE_GUID As String = "{221CD8DA-7B56-44BA-9B49-AD9AA761A6EC}"

    ' Hex Key - 128 bits
    Friend Const APPLICATION_LICENSE_PASSWORD As String = "3920586483ee18cb0bdce3a7b20ec72f"

    '//////////////////
    '    ALARMA
    '//////////////////
    Friend Const ALARMA_FECHATIPO_FECHANACIMIENTOPERSONA As String = "PN"
    Friend Const ALARMA_FECHATIPO_FECHANACIMIENTOPERSONA_LISTINDEX As Integer = 0
    Friend Const ALARMA_FECHATIPO_FECHANACIMIENTOPERSONA_NOMBRE As String = "Fecha de Nacimiento de la Persona"

    Friend Const ALARMA_FECHATIPO_LICENCIACONDUCIRVENCIMIENTO As String = "LC"
    Friend Const ALARMA_FECHATIPO_LICENCIACONDUCIRVENCIMIENTO_LISTINDEX As Integer = 1
    Friend Const ALARMA_FECHATIPO_LICENCIACONDUCIRVENCIMIENTO_NOMBRE As String = "Fecha de Vencimiento de la Licencia de Conducir"

    Friend Const ALARMA_FECHATIPO_FECHANACIMIENTOFAMILIAR As String = "FN"
    Friend Const ALARMA_FECHATIPO_FECHANACIMIENTOFAMILIAR_LISTINDEX As Integer = 2
    Friend Const ALARMA_FECHATIPO_FECHANACIMIENTOFAMILIAR_NOMBRE As String = "Fecha de Nacimiento del Familiar"

    Friend Const ALARMA_FECHATIPO_FECHAALARMA As String = "FA"
    Friend Const ALARMA_FECHATIPO_FECHAALARMA_LISTINDEX As Integer = 3
    Friend Const ALARMA_FECHATIPO_FECHAALARMA_NOMBRE As String = "Fecha de Alarma"

    '//////////////////
    '    PERSONA
    '//////////////////
    Friend Const PERSONA_GENERO_NOESPECIFICA As String = "-"
    Friend Const PERSONA_GENERO_MASCULINO As String = "M"
    Friend Const PERSONA_GENERO_FEMENINO As String = "F"

    Friend Const PERSONA_TIENEIOMA_NOTIENE As String = "N"
    Friend Const PERSONA_TIENEIOMA_NOTIENE_NOMBRE As String = "No tiene"
    Friend Const PERSONA_TIENEIOMA_PORTRABAJO As String = "T"
    Friend Const PERSONA_TIENEIOMA_PORTRABAJO_NOMBRE As String = "Trabajo"
    Friend Const PERSONA_TIENEIOMA_PORBOMBEROS As String = "B"
    Friend Const PERSONA_TIENEIOMA_PORBOMBEROS_NOMBRE As String = "Bomberos"

    Friend Const USUARIOGRUPO_ADMINISTRADORES_ID As Byte = 1

    '///////////////////////////////////
    '    PARÁMETROS DE LOS REPORTES
    '///////////////////////////////////
    Friend Const REPORTE_PARAMETRO_TIPO_CUARTEL As String = "CTEL"
    Friend Const REPORTE_PARAMETRO_TIPO_CARGO As String = "CARG"
    Friend Const REPORTE_PARAMETRO_TIPO_JERARQUIA As String = "JERQ"
    Friend Const REPORTE_PARAMETRO_TIPO_PERSONABAJAMOTIVO As String = "PBMT"
    Friend Const REPORTE_PARAMETRO_TIPO_PERSONA As String = "PERS"
    Friend Const REPORTE_PARAMETRO_TIPO_PERSONAMULTIPLE As String = "PEMU"
    Friend Const REPORTE_PARAMETRO_TIPO_UNIDAD As String = "UNID"
    Friend Const REPORTE_PARAMETRO_TIPO_AREA As String = "AREA"
    Friend Const REPORTE_PARAMETRO_TIPO_UBICACION As String = "UBIC"
    Friend Const REPORTE_PARAMETRO_TIPO_SUBUBICACION As String = "SUBU"

    Friend Const REPORTE_PARAMETRO_TIPO_TEXT As String = "TEXT"
    Friend Const REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER As String = "NUIN"
    Friend Const REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL As String = "NUDE"
    Friend Const REPORTE_PARAMETRO_TIPO_MONEY As String = "MONY"
    Friend Const REPORTE_PARAMETRO_TIPO_DATETIME As String = "DATI"
    Friend Const REPORTE_PARAMETRO_TIPO_DATE As String = "DATE"
    Friend Const REPORTE_PARAMETRO_TIPO_TIME As String = "TIME"
    Friend Const REPORTE_PARAMETRO_TIPO_YEAR As String = "YEAR"
    Friend Const REPORTE_PARAMETRO_TIPO_YEAR_MONTH_FROM As String = "YMFR"
    Friend Const REPORTE_PARAMETRO_TIPO_YEAR_MONTH_TO As String = "YMTO"
    Friend Const REPORTE_PARAMETRO_TIPO_SINO As String = "BOOL"

    Friend Const REPORTE_PARAMETRO_TIPO_COMPANY As String = "CMNY"
    Friend Const REPORTE_PARAMETRO_TIPO_TITLE As String = "TITL"
    Friend Const REPORTE_PARAMETRO_TIPO_FILTER_TEXT As String = "FILT"
    Friend Const REPORTE_PARAMETRO_TIPO_FILTER_TEXT_SHOW As String = "FLSH"
End Module