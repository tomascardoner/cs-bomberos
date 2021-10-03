Module ListasComun

    Friend Sub LlenarComboBoxCuarteles(ByRef dbContext As CSBomberosContext, ByRef control As ComboBox, ByVal agregarItemTodos As Boolean, ByVal agregarItemNoEspecifica As Boolean)
        Dim listItems As List(Of Cuartel)

        control.ValueMember = "IDCuartel"
        control.DisplayMember = "Nombre"

        If pUsuario.IDCuartel.HasValue Then
            ' Tengo que limitar la lista al cuartel que tiene especificado
            listItems = New List(Of Cuartel)

            listItems.Insert(0, dbContext.Cuartel.Find(pUsuario.IDCuartel))
        Else
            listItems = dbContext.Cuartel.Where(Function(c) c.EsActivo).OrderBy(Function(cl) cl.Nombre).ToList

            If agregarItemTodos Then
                Dim Item_Todos As New Cuartel
                Item_Todos.IDCuartel = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE
                Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
                listItems.Insert(0, Item_Todos)
            End If
        End If

        If agregarItemNoEspecifica Then
            Dim Item_NoEspecifica As New Cuartel
            Item_NoEspecifica.IDCuartel = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        control.DataSource = listItems
    End Sub

End Module
