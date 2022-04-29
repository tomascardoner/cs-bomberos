Partial Public Class ReporteParametro
    Private _Valor As Object = Nothing
    Private _ValorParaMostrar As String

    Public Property Valor As Object
        Get
            If _Valor Is Nothing Then
                ' El valor no está inicializado, así que verifico que no haya un valor predeterminado
                Select Case Me.Tipo
                    Case Reportes.REPORTE_PARAMETRO_TIPO_PERSONA
                    Case Reportes.REPORTE_PARAMETRO_TIPO_TITLE, Reportes.REPORTE_PARAMETRO_TIPO_TEXT
                        If Not Me.ValorPredeterminadoTexto Is Nothing Then
                            _Valor = Me.ValorPredeterminadoTexto
                        End If
                    Case Reportes.REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER, Reportes.REPORTE_PARAMETRO_TIPO_YEAR
                        If Not Me.ValorPredeterminadoNumeroEntero Is Nothing Then
                            _Valor = Me.ValorPredeterminadoNumeroEntero
                        End If
                    Case Reportes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL
                        If Not Me.ValorPredeterminadoNumeroDecimal Is Nothing Then
                            _Valor = Me.ValorPredeterminadoNumeroDecimal
                        End If
                    Case Reportes.REPORTE_PARAMETRO_TIPO_MONEY
                        If Not Me.ValorPredeterminadoMoneda Is Nothing Then
                            _Valor = Me.ValorPredeterminadoMoneda
                        End If
                    Case Reportes.REPORTE_PARAMETRO_TIPO_DATETIME, Reportes.REPORTE_PARAMETRO_TIPO_DATE, Reportes.REPORTE_PARAMETRO_TIPO_TIME
                        If Not Me.ValorPredeterminadoFechaHora Is Nothing Then
                            _Valor = Me.ValorPredeterminadoFechaHora
                        End If
                    Case Reportes.REPORTE_PARAMETRO_TIPO_YEAR_MONTH_FROM, Reportes.REPORTE_PARAMETRO_TIPO_YEAR_MONTH_TO
                    Case Reportes.REPORTE_PARAMETRO_TIPO_SINO, Reportes.REPORTE_PARAMETRO_TIPO_FILTER_TEXT_SHOW
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
                    Case Reportes.REPORTE_PARAMETRO_TIPO_PERSONA, Reportes.REPORTE_PARAMETRO_TIPO_CUARTEL, Reportes.REPORTE_PARAMETRO_TIPO_CARGO, Reportes.REPORTE_PARAMETRO_TIPO_JERARQUIA, Reportes.REPORTE_PARAMETRO_TIPO_PERSONABAJAMOTIVO, Reportes.REPORTE_PARAMETRO_TIPO_UNIDAD, Reportes.REPORTE_PARAMETRO_TIPO_AREA, Reportes.REPORTE_PARAMETRO_TIPO_UBICACION, Reportes.REPORTE_PARAMETRO_TIPO_SUBUBICACION, Reportes.REPORTE_PARAMETRO_TIPO_RESPONSABLE, Reportes.REPORTE_PARAMETRO_TIPO_COMPRA, Reportes.REPORTE_PARAMETRO_TIPO_ENTIDAD
                        Return _ValorParaMostrar
                    Case Reportes.REPORTE_PARAMETRO_TIPO_TITLE, Reportes.REPORTE_PARAMETRO_TIPO_TEXT
                        Return Convert.ToString(_Valor)
                    Case Reportes.REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER
                        Return FormatNumber(_Valor, 0)
                    Case Reportes.REPORTE_PARAMETRO_TIPO_YEAR
                        Return _Valor.ToString()
                    Case Reportes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL
                        Return FormatNumber(_Valor)
                    Case Reportes.REPORTE_PARAMETRO_TIPO_MONEY
                        Return FormatCurrency(_Valor)
                    Case Reportes.REPORTE_PARAMETRO_TIPO_DATETIME
                        Return FormatDateTime(CDate(_Valor), DateFormat.ShortDate) & " " & FormatDateTime(CDate(_Valor), DateFormat.ShortTime)
                    Case Reportes.REPORTE_PARAMETRO_TIPO_DATE
                        Return FormatDateTime(CDate(_Valor), DateFormat.ShortDate)
                    Case Reportes.REPORTE_PARAMETRO_TIPO_TIME
                        Return FormatDateTime(CDate(_Valor), DateFormat.ShortTime)
                    Case Reportes.REPORTE_PARAMETRO_TIPO_YEAR_MONTH_FROM
                        Return String.Empty
                    Case Reportes.REPORTE_PARAMETRO_TIPO_YEAR_MONTH_TO
                        Return String.Empty
                    Case Reportes.REPORTE_PARAMETRO_TIPO_SINO, Reportes.REPORTE_PARAMETRO_TIPO_FILTER_TEXT_SHOW
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