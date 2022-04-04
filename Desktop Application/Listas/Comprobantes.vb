Module ListasComprobantes

    Friend Sub LlenarComboBoxComprobanteTipos(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal operacionTipo As String, ByVal mostrarItemTodos As Boolean, ByVal mostrarItemNoEspecifica As Boolean)
        Dim localList As List(Of ComprobanteTipo)

        control.ValueMember = "IDComprobanteTipo"

        If String.IsNullOrEmpty(operacionTipo) Then
            control.DisplayMember = "NombreCompleto"

            localList = context.ComprobanteTipo.Where(Function(ct) ct.EsActivo).OrderBy(Function(ct) ct.NombreCompleto).ToList()
        Else
            control.DisplayMember = "NombreConLetra"

            localList = context.ComprobanteTipo.Where(Function(ct) ct.EsActivo).OrderBy(Function(ct) ct.NombreConLetra).ToList()
        End If

        If mostrarItemTodos Then
            localList.Insert(0, New ComprobanteTipo With {
                .IDComprobanteTipo = Byte.MaxValue,
                .NombreConLetra = My.Resources.STRING_ITEM_ALL_MALE,
                .NombreCompleto = My.Resources.STRING_ITEM_ALL_MALE
            })
        End If
        If mostrarItemNoEspecifica Then
            localList.Insert(0, New ComprobanteTipo With {
                .IDComprobanteTipo = Byte.MinValue,
                .NombreConLetra = My.Resources.STRING_ITEM_NOT_SPECIFIED,
                .NombreCompleto = My.Resources.STRING_ITEM_NOT_SPECIFIED
            })
        End If

        control.DataSource = localList
        control.SelectedIndex = -1
    End Sub

    Friend Sub LlenarComboBoxComprobantes(ByRef context As CSBomberosContext, ByRef control As ComboBox, idEntidad As Short, operacionTipo As String, movimientoTipo As String, utilizaFechaVencimiento As Boolean?, utilizaAplicacion As Boolean?, utilizaMedioPago As Boolean?, mostrarItemTodos As Boolean, mostrarItemNoEspecifica As Boolean, Optional ordenDescendente As Boolean = False)
        Dim listItems As List(Of Comprobante)

        control.ValueMember = "IDComprobante"
        control.DisplayMember = "NumeroCompleto"

        listItems = (From c In context.Comprobante
                     Join ct In context.ComprobanteTipo On c.IDComprobanteTipo Equals ct.IDComprobanteTipo
                     Where c.IDEntidad = idEntidad And (operacionTipo Is Nothing Or ct.OperacionTipo = operacionTipo) And (movimientoTipo Is Nothing Or ct.MovimientoTipo = movimientoTipo) And (utilizaFechaVencimiento Is Nothing Or ct.UtilizaFechaVencimiento = utilizaFechaVencimiento) And (utilizaAplicacion Is Nothing Or ct.UtilizaAplicacion = utilizaAplicacion) And (utilizaMedioPago Is Nothing Or ct.UtilizaMedioPago = utilizaMedioPago)
                     Select c).ToList()

        If ordenDescendente Then
            listItems = listItems.OrderByDescending(Function(cf) cf.NumeroCompleto).ToList
        Else
            listItems = listItems.OrderBy(Function(cf) cf.NumeroCompleto).ToList
        End If

        If mostrarItemTodos Then
            Dim todos As New Comprobante With {
                .IDComprobante = CardonerSistemas.Constants.FIELD_VALUE_ALL_INTEGER,
                .NumeroCompleto = My.Resources.STRING_ITEM_ALL_FEMALE
            }
            listItems.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New Comprobante With {
                .IDComprobante = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER,
                .NumeroCompleto = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, noEspecifica)
        End If

        control.DataSource = listItems

    End Sub

    Friend Sub LlenarComboBoxComprobantes(ByRef context As CSBomberosContext, ByRef control As ComboBox, idEntidad As Short, mostrarItemTodos As Boolean, mostrarItemNoEspecifica As Boolean, Optional ordenDescendente As Boolean = False)
        LlenarComboBoxComprobantes(context, control, idEntidad, Nothing, Nothing, Nothing, Nothing, Nothing, mostrarItemTodos, mostrarItemNoEspecifica, ordenDescendente)
    End Sub
End Module
