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

        If mostrarItemNoEspecifica Then
            localList.Insert(0, New ComprobanteTipo With {
                .IDComprobanteTipo = Byte.MinValue,
                .NombreConLetra = My.Resources.STRING_ITEM_NOT_SPECIFIED,
                .NombreCompleto = My.Resources.STRING_ITEM_NOT_SPECIFIED
            })
        End If
        If mostrarItemTodos Then
            localList.Insert(0, New ComprobanteTipo With {
                .IDComprobanteTipo = Byte.MaxValue,
                .NombreConLetra = My.Resources.STRING_ITEM_ALL_MALE,
                .NombreCompleto = My.Resources.STRING_ITEM_ALL_MALE
            })
        End If

        control.DataSource = localList
        control.SelectedIndex = -1
    End Sub

    Friend Sub LlenarComboBoxEntidades(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal operacionTipo As String, ByVal mostrarItemTodos As Boolean, ByVal mostrarItemNoEspecifica As Boolean)
        Dim listItems As List(Of Entidad)

        control.ValueMember = "IDEntidad"
        control.DisplayMember = "Nombre"

        If String.IsNullOrEmpty(operacionTipo) Then
            listItems = context.Entidad.Where(Function(p) p.EsActivo).OrderBy(Function(p) p.Nombre).ToList
        Else
            listItems = context.Entidad.Where(Function(p) p.EsActivo And ((operacionTipo = OperacionTipoCompra And p.HabilitarCompra) Or (operacionTipo = OperacionTipoVenta And p.HabilitarVenta))).OrderBy(Function(p) p.Nombre).ToList
        End If

        If mostrarItemNoEspecifica Then
            listItems.Insert(0, New Entidad With {
                .IDEntidad = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            })
        End If
        If mostrarItemTodos Then
            listItems.Insert(0, New Entidad With {
                .IDEntidad = CardonerSistemas.Constants.FIELD_VALUE_ALL_SHORT,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            })
        End If

        control.DataSource = listItems
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

    Friend Sub LlenarComboBoxMediosPago(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal mostrarItemNoEspecifica As Boolean, ByVal esChequeMostrar As Boolean, ByVal noEsChequeMostrar As Boolean)
        Dim listMediosPago As List(Of MedioPago)

        control.ValueMember = "IDMedioPago"
        control.DisplayMember = "Nombre"

        listMediosPago = (From mp In context.MedioPago
                          Where mp.EsActivo And (esChequeMostrar And mp.EsCheque) And (noEsChequeMostrar And Not mp.EsCheque)
                          Order By mp.Nombre).ToList

        If mostrarItemNoEspecifica Then
            listMediosPago.Insert(0, New MedioPago With {
                .IDMedioPago = 0,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            })
        End If

        control.DataSource = listMediosPago
    End Sub

    Friend Sub LlenarComboBoxBancos(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal mostrarItemNoEspecifica As Boolean)
        Dim listBancos As List(Of Banco)

        control.ValueMember = "IDBanco"
        control.DisplayMember = "Nombre"

        listBancos = context.Banco.Where(Function(b) b.EsActivo).OrderBy(Function(b) b.Nombre).ToList

        If mostrarItemNoEspecifica Then
            listBancos.Insert(0, New Banco With {
                .IDBanco = 0,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            })
        End If

        control.DataSource = listBancos
    End Sub

    Friend Sub LlenarComboBoxChequesMotivosRechazo(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal mostrarNombreCompleto As Boolean, ByVal mostrarItemTodos As Boolean)
        Dim listChequeMotivoRechazo As List(Of ChequeMotivoRechazo)

        control.ValueMember = "IDChequeMotivoRechazo"

        If mostrarNombreCompleto Then
            control.DisplayMember = "NombreCompleto"
            listChequeMotivoRechazo = context.ChequeMotivoRechazo.Where(Function(cmr) cmr.EsActivo).OrderBy(Function(cmr) cmr.NombreCompleto).ToList
        Else
            control.DisplayMember = "Nombre"
            listChequeMotivoRechazo = context.ChequeMotivoRechazo.Where(Function(cmr) cmr.EsActivo).OrderBy(Function(cmr) cmr.Nombre).ToList
        End If

        If mostrarItemTodos Then
            listChequeMotivoRechazo.Insert(0, New ChequeMotivoRechazo With {
                .IDChequeMotivoRechazo = 0,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE,
                .NombreCompleto = My.Resources.STRING_ITEM_ALL_MALE
            })
        End If

        control.DataSource = listChequeMotivoRechazo
    End Sub

    Friend Sub LlenarComboBoxArticulos(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal mostrarItemTodos As Boolean, ByVal mostrarItemNoEspecifica As Boolean)
        Dim listArticulos As List(Of Articulo)

        control.ValueMember = "IDArticulo"
        control.DisplayMember = "Nombre"

        listArticulos = context.Articulo.Where(Function(a) a.EsActivo).OrderBy(Function(a) a.Nombre).ToList

        If mostrarItemTodos Then
            listArticulos.Insert(0, New Articulo With {
                .IDArticulo = 0,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            })
        End If
        If mostrarItemNoEspecifica Then
            listArticulos.Insert(0, New Articulo With {
                .IDArticulo = 0,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            })
        End If

        control.DataSource = listArticulos
    End Sub

End Module
