Module Constantes

    '##################
    '    APLICACIÓN
    '##################
    Friend Const ApplicationDatabaseGuid As String = "{221CD8DA-7B56-44BA-9B49-AD9AA761A6EC}"
    Friend Const ApplicationDatabaseVersion As Integer = 3

    ' Hex Key - 128 bits
    Friend Const ApplicationLicensePassword As String = "B86F0161DE5AF8FDF45262AB2D805999"

    '##################
    '    MODULO
    '##################
    Friend Const ModuloDocumentacionesId As Byte = 1
    Friend Const ModuloDocumentacionesNombre As String = "Documentaciones"
    Friend Const ModuloJefaturaId As Byte = 2
    Friend Const ModuloJefaturaNombre As String = "Jefatura"
    Friend Const ModulocomisionDirectivaId As Byte = 3
    Friend Const ModulocomisionDirectivaNombre As String = "Comisión directiva"

    '##################
    '    ALARMA
    '##################
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

    '##################
    '    PERSONA
    '##################
    Friend Const PERSONA_GENERO_NOESPECIFICA As String = "-"
    Friend Const PERSONA_GENERO_MASCULINO As String = "M"
    Friend Const PERSONA_GENERO_FEMENINO As String = "F"

    Friend Const PERSONA_TIENEIOMA_NOTIENE As String = "N"
    Friend Const PERSONA_TIENEIOMA_NOTIENE_NOMBRE As String = "No tiene"
    Friend Const PERSONA_TIENEIOMA_PORTRABAJO As String = "T"
    Friend Const PERSONA_TIENEIOMA_PORTRABAJO_NOMBRE As String = "Trabajo"
    Friend Const PERSONA_TIENEIOMA_PORBOMBEROS As String = "B"
    Friend Const PERSONA_TIENEIOMA_PORBOMBEROS_NOMBRE As String = "Bomberos"

    Friend Const PERSONA_ALTABAJA_TIPO_ALTA As String = "A"
    Friend Const PERSONA_ALTABAJA_TIPO_BAJA As String = "B"

    Friend Const AsistenciaMetodoManualId As Byte = 1
    Friend Const AsistenciaMetodoHuellaDigitalId As Byte = 2
    Friend Const AsistenciaMetodoCodigoNumericoId As Byte = 3

    Friend Const PersonaSancionEstadoEnProceso As String = "P"
    Friend Const PersonaSancionEstadoEnProcesoNombre As String = "En proceso"
    Friend Const PersonaSancionEstadoAprobada As String = "A"
    Friend Const PersonaSancionEstadoAprobadaNombre As String = "Aprobada"
    Friend Const PersonaSancionEstadoDesaprobada As String = "D"
    Friend Const PersonaSancionEstadoDesaprobadaNombre As String = "Desaprobada"

    '##################
    '   COMPROBANTES
    '##################
    Friend Const OperacionTipoCompra As String = "C"
    Friend Const OperacionTipoVenta As String = "V"

    Friend Const MovimientoTipoCredito As String = "C"
    Friend Const MovimientoTipoDebito As String = "D"

    Friend Const ComprobantePuntoVentaLongitud As Byte = 5
    Friend Const ComprobanteNumeroLongitud As Byte = 8

    Friend Const ComprobanteConceptoProductos As Byte = 1
    Friend Const ComprobanteConceptoServicios As Byte = 2
    Friend Const ComprobanteConceptoProductosYServicios As Byte = 3
    Friend Const ComprobanteConceptoOtros As Byte = 4

    Friend Const ComprobanteCodigoAfipFacturaA As Byte = 1
    Friend Const ComprobanteCodigoAfipNotaDebitoA As Byte = 2
    Friend Const ComprobanteCodigoAfipNotaCreditoA As Byte = 3
    Friend Const ComprobanteCodigoAfipFacturaB As Byte = 6
    Friend Const ComprobanteCodigoAfipNotaDebitoB As Byte = 7
    Friend Const ComprobanteCodigoAfipNotaCreditoB As Byte = 8
    Friend Const ComprobanteCodigoAfipFacturaC As Byte = 11
    Friend Const ComprobanteCodigoAfipNotaDebitoC As Byte = 12
    Friend Const ComprobanteCodigoAfipNotaCreditoC As Byte = 13

    '##################
    '    CHEQUES
    '##################
    Friend Const ChequeEstadoEnCartera As String = "EC"
    Friend Const ChequeEstadoEntregado As String = "ET"
    Friend Const ChequeEstadoEntregadoRechazado As String = "ER"
    Friend Const ChequeEstadoCobradoPorVentanilla As String = "CV"
    Friend Const ChequeEstadoNegociado As String = "NE"
    Friend Const ChequeEstadoDepositadoPendiente As String = "DP"
    Friend Const ChequeEstadoDepositadoAcreditado As String = "DA"
    Friend Const ChequeEstadoDepositadoRechazadoEnBanco As String = "DR"
    Friend Const ChequeEstadoDepositadoRechazadoEnCartera As String = "DC"
    Friend Const ChequeEstadoDepositadoRechazadoDevuelto As String = "DV"

    '##################
    '    SINIESTROS
    '##################
    Friend Const SINIESTRO_NUMEROPREFIJO_DIGITOS As Byte = 4
    Friend Const SINIESTRO_NUMERO_DIGITOS As Byte = 8

    Friend Const SINIESTRO_CLAVE_ROJA As String = "R"
    Friend Const SINIESTRO_CLAVE_ROJA_NOMBRE As String = "Roja"
    Friend Const SINIESTRO_CLAVE_NARANJA As String = "N"
    Friend Const SINIESTRO_CLAVE_NARANJA_NOMBRE As String = "Naranja"
    Friend Const SINIESTRO_CLAVE_AZUL As String = "A"
    Friend Const SINIESTRO_CLAVE_AZUL_NOMBRE As String = "Azul"
    Friend Const SINIESTRO_CLAVE_VERDE As String = "V"
    Friend Const SINIESTRO_CLAVE_VERDE_NOMBRE As String = "Verde"

    Friend Const SINIESTRO_CLAVEGRUPO_AZULVERDE As String = "AV"
    Friend Const SINIESTRO_CLAVEGRUPO_AZULVERDE_NOMBRE As String = "Azules y verdes"
    Friend Const SINIESTRO_CLAVEGRUPO_NARANJA As String = "N"
    Friend Const SINIESTRO_CLAVEGRUPO_NARANJA_NOMBRE As String = "Naranjas"
    Friend Const SINIESTRO_CLAVEGRUPO_ROJA As String = "R"
    Friend Const SINIESTRO_CLAVEGRUPO_ROJA_NOMBRE As String = "Rojas"
    Friend Const SINIESTRO_CLAVEGRUPO_SERVICIOPROGRAMADO As String = "SP"
    Friend Const SINIESTRO_CLAVEGRUPO_SERVICIOPROGRAMADO_NOMBRE As String = "Servicios programados"

    Friend Const USUARIOGRUPO_ADMINISTRADORES_ID As Byte = 1

    '##################
    '    CAMPOS
    '##################
    ' Nota: para los campos de fecha, se debe especificar el formato con los siguientes sufijos:
    '   _LITTLEENDIAN_SLASH => fecha en formato "dd/MM/yyyy"
    Friend Const CAMPOS_PERSONA_NUMEROAFILIADO As String = "[PERSONA_NUMEROAFILIADO]"
    Friend Const CAMPOS_PERSONA_GENERO_1CARACTER As String = "[PERSONA_GENERO1]"
    Friend Const CAMPOS_PERSONA_FECHANACIMIENTO_LITTLEENDIAN_SLASH As String = "[PERSONA_FECHANACIMIENTO_LITTLEENDIAN_SLASH]"
    Friend Const CAMPOS_PERSONA_NUMERODOCUMENTO As String = "[PERSONA_NUMERODOCUMENTO]"

End Module