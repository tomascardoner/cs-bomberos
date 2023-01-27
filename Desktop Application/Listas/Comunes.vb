Module ListasComunes

#Region "Áreas"

    Friend Class AreaConCuartelClass
        Public Property IDArea As Short
        Public Property IDCuartel As Byte
        Public Property Codigo As String
        Public Property Nombre As String
        Public Property CuartelNombre As String
        Public Property NombreYCuartel As String
        Public Property MostrarEnInventario As Boolean
        Public Property MostrarEnCompras As Boolean
    End Class

    Friend Sub LlenarComboBoxAreas(ByRef context As CSBomberosContext, ByRef control As ComboBox, agregarItemTodos As Boolean, agregarItemNoEspecifica As Boolean, Optional filtrarIDCuartel As Byte = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, Optional filtrarMostrarEnInventario As Boolean = False, Optional filtrarMostrarEnCompras As Boolean = False)
        Dim listItems As List(Of Area)

        control.ValueMember = "IDArea"
        control.DisplayMember = "Nombre"

        listItems = context.Area.Where(Function(a) a.EsActivo).OrderBy(Function(a) a.Nombre).ToList

        If filtrarIDCuartel <> CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = listItems.Where(Function(a) a.IDCuartel = filtrarIDCuartel).ToList()
        End If
        If filtrarMostrarEnInventario Then
            listItems = listItems.Where(Function(a) a.MostrarEnInventario).ToList()
        End If
        If filtrarMostrarEnCompras Then
            listItems = listItems.Where(Function(a) a.MostrarEnCompras).ToList()
        End If

        If agregarItemNoEspecifica Then
            listItems.Insert(0, New Area With {
                .IDArea = Short.MinValue,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            })
        End If
        If agregarItemTodos Then
            listItems.Insert(0, New Area With {
                .IDArea = 0,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            })
        End If

        control.DataSource = listItems
    End Sub

    Friend Sub LlenarComboBoxAreasConCuartel(ByRef context As CSBomberosContext, ByRef control As ComboBox, agregarItemTodos As Boolean, agregarItemNoEspecifica As Boolean, Optional filtrarIDCuartel As Byte = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, Optional filtrarMostrarEnInventario As Boolean = False, Optional filtrarMostrarEnCompras As Boolean = False)
        Dim listItems As List(Of AreaConCuartelClass)

        control.ValueMember = "IDArea"
        control.DisplayMember = "NombreYCuartel"

        listItems = (From a In context.Area
                     Join c In context.Cuartel On a.IDCuartel Equals c.IDCuartel
                     Where a.EsActivo AndAlso c.EsActivo
                     Order By a.Nombre, c.Nombre
                     Select New AreaConCuartelClass With {.IDArea = a.IDArea, .IDCuartel = a.IDCuartel, .Codigo = a.Codigo, .Nombre = a.Nombre, .CuartelNombre = c.Nombre, .NombreYCuartel = a.Nombre + " (" + c.Nombre + ")", .MostrarEnInventario = a.MostrarEnInventario, .MostrarEnCompras = a.MostrarEnCompras}).ToList()

        If filtrarIDCuartel <> CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = listItems.Where(Function(acc) acc.IDCuartel = filtrarIDCuartel).ToList()
        End If
        If filtrarMostrarEnInventario Then
            listItems = listItems.Where(Function(acc) acc.MostrarEnInventario).ToList()
        End If
        If filtrarMostrarEnCompras Then
            listItems = listItems.Where(Function(acc) acc.MostrarEnCompras).ToList()
        End If

        If agregarItemNoEspecifica Then
            listItems.Insert(0, New AreaConCuartelClass With {
                .IDArea = Short.MinValue,
                .NombreYCuartel = My.Resources.STRING_ITEM_NOT_SPECIFIED
            })
        End If
        If agregarItemTodos Then
            listItems.Insert(0, New AreaConCuartelClass With {
                .IDArea = 0,
                .NombreYCuartel = My.Resources.STRING_ITEM_ALL_FEMALE
            })
        End If

        control.DataSource = listItems
    End Sub



#End Region

    Friend Sub LlenarComboBoxCuarteles(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal agregarItemTodos As Boolean, ByVal agregarItemNoEspecifica As Boolean)
        Dim listItems As List(Of Cuartel)

        control.ValueMember = "IDCuartel"
        control.DisplayMember = "Nombre"

        If pUsuario.IDCuartel.HasValue Then
            ' Tengo que limitar la lista al cuartel que tiene especificado
            listItems = New List(Of Cuartel)

            listItems.Insert(0, context.Cuartel.Find(pUsuario.IDCuartel))
        Else
            listItems = context.Cuartel.Where(Function(c) c.EsActivo).OrderBy(Function(cl) cl.Nombre).ToList

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
