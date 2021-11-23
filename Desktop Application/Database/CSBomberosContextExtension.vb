Imports System.Data.Entity

Partial Public Class CSBomberosContext
    Inherits DbContext

    Public Shared Property ConnectionString As String

#Disable Warning CA1801 ' Review unused parameters
    Public Sub New(ByVal UseCustomConnectionString As Boolean)
#Enable Warning CA1801 ' Review unused parameters
        MyBase.New(ConnectionString)
    End Sub
End Class


