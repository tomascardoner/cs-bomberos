Module Constantes

    '//////////////////
    '    APLICACIÓN
    '//////////////////
    Friend Const APPLICATION_DATABASE_GUID As String = "{221CD8DA-7B56-44BA-9B49-AD9AA761A6EC}"
    Friend Const APPLICATION_DATABASE_VERSION As Integer = 1

    ' Hex Key - 128 bits
    Friend Const APPLICATION_LICENSE_PASSWORD As String = "B86F0161DE5AF8FDF45262AB2D805999"

    '//////////////////
    '    MODULO
    '//////////////////
    Friend Const MODULO_DOCUMENTACIONES_ID As Byte = 1
    Friend Const MODULO_DOCUMENTACIONES_NOMBRE As String = "Documentaciones"
    Friend Const MODULO_JEFATURA_ID As Byte = 2
    Friend Const MODULO_JEFATURA_NOMBRE As String = "Jefatura"
    Friend Const MODULO_COMISIONDIRECTIVA_ID As Byte = 3
    Friend Const MODULO_COMISIONDIRECTIVA_NOMBRE As String = "Comisión directiva"

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

    Friend Const PERSONA_ALTABAJA_TIPO_ALTA As String = "A"
    Friend Const PERSONA_ALTABAJA_TIPO_BAJA As String = "B"

    Friend Const ASISTENCIA_METODO_MANUAL_ID As Byte = 1

    '//////////////////
    '    SINIESTROS
    '//////////////////
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

    '//////////////
    '    CAMPOS
    '//////////////
    ' Nota: para los campos de fecha, se debe especificar el formato con los siguientes sufijos:
    '   _LITTLEENDIAN_SLASH => fecha en formato "dd/MM/yyyy"
    Friend Const CAMPOS_PERSONA_NUMEROAFILIADO As String = "[PERSONA_NUMEROAFILIADO]"
    Friend Const CAMPOS_PERSONA_GENERO_1CARACTER As String = "[PERSONA_GENERO1]"
    Friend Const CAMPOS_PERSONA_FECHANACIMIENTO_LITTLEENDIAN_SLASH As String = "[PERSONA_FECHANACIMIENTO_LITTLEENDIAN_SLASH]"
    Friend Const CAMPOS_PERSONA_NUMERODOCUMENTO As String = "[PERSONA_NUMERODOCUMENTO]"

End Module