Imports System.Data.Entity

Partial Public Class CSBomberosContext
    Inherits DbContext

    Public Shared Property ConnectionString As String

    Public Sub New(ByVal UseCustomConnectionString As Boolean)
        MyBase.New(ConnectionString)
    End Sub

    <DbFunctionAttribute("CSBomberosContext", "PersonaObtenerIdUltimaAltaBaja")>
    Public Function PersonaObtenerIdUltimaAltaBaja(ByVal IDPersona As Integer, ByVal FechaHasta As Date) As Byte
        Throw New NotSupportedException("Direct calls are not supported.")
    End Function
End Class


