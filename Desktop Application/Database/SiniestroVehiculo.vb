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

Partial Public Class SiniestroVehiculo
    Public Property IdSiniestro As Integer
    Public Property IdVehiculo As Byte
    Public Property IdSiniestroVehiculoTipo As Byte
    Public Property IdSiniestroVehiculoMarca As Nullable(Of Short)
    Public Property Modelo As String
    Public Property Dominio As String

    Public Overridable Property SiniestroVehiculoMarca As SiniestroVehiculoMarca
    Public Overridable Property SiniestroVehiculoTipo As SiniestroVehiculoTipo
    Public Overridable Property Siniestro As Siniestro

End Class
