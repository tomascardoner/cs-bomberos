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

Partial Public Class PersonaAscenso
    Public Property IDPersona As Integer
    Public Property IDAscenso As Byte
    Public Property Fecha As Date
    Public Property IDCargo As Byte
    Public Property IDJerarquia As Byte
    Public Property Notas As String
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property CargoJerarquia As CargoJerarquia
    Public Overridable Property Persona As Persona
    Public Overridable Property Usuario As Usuario
    Public Overridable Property Usuario1 As Usuario

End Class