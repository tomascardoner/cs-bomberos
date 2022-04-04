Partial Public Class Comprobante
    Public ReadOnly Property LetraYNumeroCompleto(ByVal letra As String) As String
        Get
            If letra IsNot Nothing Then
                Return letra + "-" + NumeroCompleto
            Else
                Return NumeroCompleto
            End If
        End Get
    End Property
End Class
