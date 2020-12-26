Partial Public Class CajaArqueo
    Public ReadOnly Property SaldoFinal() As Decimal
        Get
            Return SaldoInicial + ImporteAsignado + CajaArqueoDetalles.Sum(Function(cad) cad.Importe)
        End Get
    End Property
End Class
