Partial Public Class Numerador
    Public ReadOnly Property PuntoVentaConFormato As String
        Get
            Return PuntoVenta.ToString(New String("0"c, Constantes.ComprobantePuntoVentaLongitud))
        End Get
    End Property

    Public ReadOnly Property NumeroConFormato As String
        Get
            Return Numero.ToString(New String("0"c, Constantes.ComprobanteNumeroLongitud))
        End Get
    End Property
End Class
