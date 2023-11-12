Module ListasResoluciones
    Friend Sub LlenarComboBoxOrdenesGeneralesCategorias(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal mostrarItemTodos As Boolean, ByVal mostrarItemNoEspecifica As Boolean)
        Dim listItems As List(Of OrdenGeneralCategoria)

        control.ValueMember = "IDOrdenGeneralCategoria"
        control.DisplayMember = "Nombre"

        listItems = context.OrdenGeneralCategoria.Where(Function(ogc) ogc.EsActivo).OrderBy(Function(ogc) ogc.Nombre).ToList

        If mostrarItemTodos Then
            Dim todos As New OrdenGeneralCategoria With {
                .IDOrdenGeneralCategoria = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            }
            listItems.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New OrdenGeneralCategoria With {
                .IDOrdenGeneralCategoria = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, noEspecifica)
        End If

        control.DataSource = listItems
    End Sub
End Module
