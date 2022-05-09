Module ListasSanciones

    Friend Sub LlenarComboBoxTiposSanciones(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal agregarItemTodos As Boolean, ByVal agregarItemNoEspecifica As Boolean)
        Dim listItems As List(Of SancionTipo)

        control.ValueMember = "IDSancionTipo"
        control.DisplayMember = "Nombre"

        listItems = context.SancionTipo.Where(Function(st) st.EsActivo).OrderBy(Function(st) st.Nombre).ToList

        If agregarItemNoEspecifica Then
            listItems.Insert(0, New SancionTipo With {
                .IDSancionTipo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            })
        End If
        If agregarItemTodos Then
            listItems.Insert(0, New SancionTipo With {
                .IDSancionTipo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            })
        End If

        control.DataSource = listItems
    End Sub

    Friend Sub LlenarComboBoxMotivosSanciones(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal agregarItemTodos As Boolean, ByVal agregarItemNoEspecifica As Boolean)
        Dim listItems As List(Of SancionMotivo)

        control.ValueMember = "IDSancionMotivo"
        control.DisplayMember = "Nombre"

        listItems = context.SancionMotivo.OrderBy(Function(sm) sm.Nombre).ToList

        If agregarItemNoEspecifica Then
            listItems.Insert(0, New SancionMotivo With {
                .IDSancionMotivo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            })
        End If
        If agregarItemTodos Then
            listItems.Insert(0, New SancionMotivo With {
                .IDSancionMotivo = CardonerSistemas.Constants.FIELD_VALUE_ALL_SHORT,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            })
        End If

        control.DataSource = listItems
    End Sub

    Friend Sub LlenarComboBoxEstadosSanciones(ByRef control As ComboBox, ByVal agregarItemTodos As Boolean, ByVal agregarItemNoEspecifica As Boolean)

        If agregarItemTodos Then
            control.Items.Add(My.Resources.STRING_ITEM_ALL_MALE)
        End If

        If agregarItemNoEspecifica Then
            control.Items.Add(My.Resources.STRING_ITEM_NOT_SPECIFIED)
        End If

        control.Items.AddRange({Constantes.PersonaSancionEstadoEnProcesoNombre, Constantes.PersonaSancionEstadoAprobadaNombre, Constantes.PersonaSancionEstadoDesaprobadaNombre})
    End Sub

End Module
