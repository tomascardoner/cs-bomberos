Module ListasCompras
    Friend Sub LlenarComboBoxFacturas(ByRef context As CSBomberosContext, ByRef control As ComboBox, idProveedor As Short, mostrarItemTodos As Boolean, mostrarItemNoEspecifica As Boolean, Optional ordenDescendente As Boolean = False)
        Dim listItems As List(Of CompraFactura)

        control.ValueMember = "IDCompraFactura"
        control.DisplayMember = "NumeroCompleto"

        If ordenDescendente Then
            listItems = context.CompraFactura.Where(Function(cf) cf.IDProveedor = idProveedor).OrderByDescending(Function(cf) cf.NumeroCompleto).ToList
        Else
            listItems = context.CompraFactura.Where(Function(cf) cf.IDProveedor = idProveedor).OrderBy(Function(cf) cf.NumeroCompleto).ToList
        End If

        If mostrarItemTodos Then
            Dim todos As New CompraFactura With {
                .IDCompraFactura = CardonerSistemas.Constants.FIELD_VALUE_ALL_INTEGER,
                .NumeroCompleto = My.Resources.STRING_ITEM_ALL_FEMALE
            }
            listItems.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New CompraFactura With {
                .IDCompraFactura = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER,
                .NumeroCompleto = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, noEspecifica)
        End If

        control.DataSource = listItems
    End Sub
End Module
