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

Partial Public Class OrdenGeneral
    Public Property IDOrdenGeneral As Integer
    Public Property Numero As Short
    Public Property SubNumero As Nullable(Of Byte)
    Public Property Fecha As Nullable(Of Date)
    Public Property NumeroCompleto As String
    Public Property Descripcion As String
    Public Property Personal As String
    Public Property IDOrdenGeneralCategoria As Nullable(Of Byte)
    Public Property Notas As String
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property OrdenGeneralCategoria As OrdenGeneralCategoria
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property OrdenesGeneralesRelacionesRelacionadas As ICollection(Of OrdenGeneralRelacion) = New HashSet(Of OrdenGeneralRelacion)
    Public Overridable Property OrdenesGeneralesRelacionesRelacionantes As ICollection(Of OrdenGeneralRelacion) = New HashSet(Of OrdenGeneralRelacion)

End Class