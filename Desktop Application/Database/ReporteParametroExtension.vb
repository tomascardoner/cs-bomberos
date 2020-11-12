Partial Public Class ReporteParametro
    Private _Valor As Object = Nothing
    Private _ValorParaMostrar As String

    Public Property Valor As Object
        Get
            If _Valor Is Nothing Then
                ' El valor no está inicializado, así que verifico que no haya un valor predeterminado
                Select Case Me.Tipo
                    Case Constantes.REPORTE_PARAMETRO_TIPO_PERSONA
                    Case Constantes.REPORTE_PARAMETRO_TIPO_TITLE, Constantes.REPORTE_PARAMETRO_TIPO_TEXT
                        If Not Me.ValorPredeterminadoTexto Is Nothing Then
                            _Valor = Me.ValorPredeterminadoTexto
                        End If
                    Case Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER, Constantes.REPORTE_PARAMETRO_TIPO_YEAR
                        If Not Me.ValorPredeterminadoNumeroEntero Is Nothing Then
                            _Valor = Me.ValorPredeterminadoNumeroEntero
                        End If
                    Case Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL
                        If Not Me.ValorPredeterminadoNumeroDecimal Is Nothing Then
                            _Valor = Me.ValorPredeterminadoNumeroDecimal
                        End If
                    Case Constantes.REPORTE_PARAMETRO_TIPO_MONEY
                        If Not Me.ValorPredeterminadoMoneda Is Nothing Then
                            _Valor = Me.ValorPredeterminadoMoneda
                        End If
                    Case Constantes.REPORTE_PARAMETRO_TIPO_DATETIME, Constantes.REPORTE_PARAMETRO_TIPO_DATE, Constantes.REPORTE_PARAMETRO_TIPO_TIME
                        If Not Me.ValorPredeterminadoFechaHora Is Nothing Then
                            _Valor = Me.ValorPredeterminadoFechaHora
                        End If
                    Case Constantes.REPORTE_PARAMETRO_TIPO_YEAR_MONTH_FROM, Constantes.REPORTE_PARAMETRO_TIPO_YEAR_MONTH_TO
                    Case Constantes.REPORTE_PARAMETRO_TIPO_SINO, Constantes.REPORTE_PARAMETRO_TIPO_FILTER_TEXT_SHOW
                        If Not Me.ValorPredeterminadoSiNo Is Nothing Then
                            _Valor = Me.ValorPredeterminadoSiNo
                        End If
                    Case Else
                End Select
            End If
            Return _Valor
        End Get
        Set(value As Object)
            _Valor = value
        End Set
    End Property

    Public Property ValorParaMostrar As String
        Get
            If _Valor Is Nothing Then
                Return String.Empty
            Else
                Select Case Me.Tipo
                    Case Constantes.REPORTE_PARAMETRO_TIPO_PERSONA, Constantes.REPORTE_PARAMETRO_TIPO_CUARTEL, Constantes.REPORTE_PARAMETRO_TIPO_CARGO, Constantes.REPORTE_PARAMETRO_TIPO_JERARQUIA, Constantes.REPORTE_PARAMETRO_TIPO_PERSONABAJAMOTIVO, Constantes.REPORTE_PARAMETRO_TIPO_UNIDAD, Constantes.REPORTE_PARAMETRO_TIPO_AREA, Constantes.REPORTE_PARAMETRO_TIPO_UBICACION, Constantes.REPORTE_PARAMETRO_TIPO_SUBUBICACION, Constantes.REPORTE_PARAMETRO_TIPO_RESPONSABLE, Constantes.REPORTE_PARAMETRO_TIPO_COMPRA
                        Return _ValorParaMostrar
                    Case Constantes.REPORTE_PARAMETRO_TIPO_TITLE, Constantes.REPORTE_PARAMETRO_TIPO_TEXT
                        Return Convert.ToString(_Valor)
                    Case Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER
                        Return FormatNumber(_Valor, 0)
                    Case Constantes.REPORTE_PARAMETRO_TIPO_YEAR
                        Return _Valor.ToString()
                    Case Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL
                        Return FormatNumber(_Valor)
                    Case Constantes.REPORTE_PARAMETRO_TIPO_MONEY
                        Return FormatCurrency(_Valor)
                    Case Constantes.REPORTE_PARAMETRO_TIPO_DATETIME
                        Return FormatDateTime(CDate(_Valor), DateFormat.ShortDate) & " " & FormatDateTime(CDate(_Valor), DateFormat.ShortTime)
                    Case Constantes.REPORTE_PARAMETRO_TIPO_DATE
                        Return FormatDateTime(CDate(_Valor), DateFormat.ShortDate)
                    Case Constantes.REPORTE_PARAMETRO_TIPO_TIME
                        Return FormatDateTime(CDate(_Valor), DateFormat.ShortTime)
                    Case Constantes.REPORTE_PARAMETRO_TIPO_YEAR_MONTH_FROM
                        Return String.Empty
                    Case Constantes.REPORTE_PARAMETRO_TIPO_YEAR_MONTH_TO
                        Return String.Empty
                    Case Constantes.REPORTE_PARAMETRO_TIPO_SINO, Constantes.REPORTE_PARAMETRO_TIPO_FILTER_TEXT_SHOW
                        If CBool(_Valor) Then
                            Return My.Resources.STRING_YES
                        Else
                            Return My.Resources.STRING_NO
                        End If
                    Case Else
                        Return String.Empty
                End Select
            End If
        End Get

        Set(value As String)
            _ValorParaMostrar = value
        End Set
    End Property
End Class