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

Partial Public Class CompraFactura
    Public Property IDCompraFactura As Integer
    Public Property Fecha As Date
    Public Property FechaVencimiento As Nullable(Of Date)
    Public Property Tipo As String
    Public Property PuntoVenta As Integer
    Public Property Numero As Integer
    Public Property NumeroCompleto As String
    Public Property IDProveedor As Short
    Public Property Descripcion As String
    Public Property Importe As Decimal
    Public Property Notas As String
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Proveedor As Proveedor
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property CompraFacturasDetalles As ICollection(Of CompraFacturaDetalle) = New HashSet(Of CompraFacturaDetalle)
    Public Overridable Property CompraOrdenesFacturas As ICollection(Of CompraOrdenFactura) = New HashSet(Of CompraOrdenFactura)

End Class