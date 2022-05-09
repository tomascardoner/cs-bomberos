'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class ComprobanteTipo
    Public Property IDComprobanteTipo As Byte
    Public Property OperacionTipo As String
    Public Property Sigla As String
    Public Property Nombre As String
    Public Property Letra As String
    Public Property NombreConLetra As String
    Public Property NombreCompleto As String
    Public Property CodigoAFIP As Byte
    Public Property MovimientoTipo As String
    Public Property EmisionElectronica As Boolean
    Public Property IDNumerador As Nullable(Of Short)
    Public Property UtilizaFechaVencimiento As Boolean
    Public Property UtilizaDescripcion As Boolean
    Public Property UtilizaDetalle As Boolean
    Public Property UtilizaAplicacion As Boolean
    Public Property UtilizaMedioPago As Boolean
    Public Property ReporteNombre As String
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property Comprobantes As ICollection(Of Comprobante) = New HashSet(Of Comprobante)
    Public Overridable Property CategoriasIVAFacturas As ICollection(Of CategoriaIVA) = New HashSet(Of CategoriaIVA)
    Public Overridable Property CategoriasIVANotasCredito As ICollection(Of CategoriaIVA) = New HashSet(Of CategoriaIVA)
    Public Overridable Property CategoriaIVANotasDebito As ICollection(Of CategoriaIVA) = New HashSet(Of CategoriaIVA)
    Public Overridable Property Numerador As Numerador

End Class