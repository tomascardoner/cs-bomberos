Module ListasResoluciones

    Friend Class OrdenGeneralItem
        Public Property IDOrdenGeneral As Integer
        Public Property NumeroDescripcion As String
    End Class

    Friend Sub LlenarComboBoxOrdenesGeneralesCategorias(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal mostrarItemTodos As Boolean, ByVal mostrarItemNoEspecifica As Boolean, ByVal mostrarItemVacio As Boolean)
        Dim listItems As List(Of OrdenGeneralCategoria)

        control.ValueMember = "IDOrdenGeneralCategoria"
        control.DisplayMember = "Nombre"

        listItems = context.OrdenGeneralCategoria.Where(Function(ogc) ogc.EsActivo).OrderBy(Function(ogc) ogc.Nombre).ToList

        If mostrarItemVacio Then
            Dim vacio As New OrdenGeneralCategoria With {
                .IDOrdenGeneralCategoria = CardonerSistemas.Constants.FIELD_VALUE_EMPTY_BYTE,
                .Nombre = My.Resources.STRING_ITEM_EMPTY_FEMALE
            }
            listItems.Insert(0, vacio)
        End If

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

    Friend Sub LlenarComboBoxOrdenesGenerales(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal mostrarItemTodos As Boolean, ByVal mostrarItemNoEspecifica As Boolean)
        Dim listItems As List(Of OrdenGeneralItem)

        control.ValueMember = "IDOrdenGeneral"
        control.DisplayMember = "NumeroDescripcion"

        listItems = context.OrdenGeneral.OrderBy(Function(og) og.Numero).ThenBy(Function(og) og.SubNumero).Select(Function(og) New OrdenGeneralItem With {.IDOrdenGeneral = og.IDOrdenGeneral, .NumeroDescripcion = og.NumeroCompleto & If(og.Descripcion = Nothing, "", " - " & og.Descripcion)}).ToList

        If mostrarItemTodos Then
            Dim todos As New OrdenGeneralItem With {
                .IDOrdenGeneral = CardonerSistemas.Constants.FIELD_VALUE_ALL_INTEGER,
                .NumeroDescripcion = My.Resources.STRING_ITEM_ALL_FEMALE
            }
            listItems.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New OrdenGeneralItem With {
                .IDOrdenGeneral = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER,
                .NumeroDescripcion = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, noEspecifica)
        End If

        control.DataSource = listItems
    End Sub

    Friend Sub LlenarComboBoxMotivoRelacion(ByRef ComboBoxControl As ComboBox, mostrarItemTodos As Boolean, mostrarItemNoEspecifica As Boolean)
        Dim datatableMotivos As New DataTable("Motivos")
        Dim datarowRow As DataRow
        Const ValueColumn As String = "IDMotivo"
        Const DisplayColumn As String = "Nombre"

        ComboBoxControl.ValueMember = ValueColumn
        ComboBoxControl.DisplayMember = DisplayColumn

        With datatableMotivos
            .Columns.Add(ValueColumn, System.Type.GetType("System.String"))
            .Columns.Add(DisplayColumn, System.Type.GetType("System.String"))

            If mostrarItemTodos Then
                datarowRow = .NewRow
                datarowRow(ValueColumn) = CardonerSistemas.Constants.FIELD_VALUE_ALL_STRING
                datarowRow(DisplayColumn) = My.Resources.STRING_ITEM_ALL_MALE
                .Rows.Add(datarowRow)
            End If

            If mostrarItemNoEspecifica Then
                datarowRow = .NewRow
                datarowRow(ValueColumn) = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_STRING
                datarowRow(DisplayColumn) = My.Resources.STRING_ITEM_NOT_SPECIFIED
                .Rows.Add(datarowRow)
            End If

            datarowRow = .NewRow
            datarowRow(ValueColumn) = Constantes.ORDENGENERAL_RELACIONMOTIVO_DEROGA
            datarowRow(DisplayColumn) = Constantes.ORDENGENERAL_RELACIONMOTIVO_DEROGA_NOMBRE
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow(ValueColumn) = Constantes.ORDENGENERAL_RELACIONMOTIVO_MODIFICA
            datarowRow(DisplayColumn) = Constantes.ORDENGENERAL_RELACIONMOTIVO_MODIFICA_NOMBRE
            .Rows.Add(datarowRow)
        End With

        ComboBoxControl.DataSource = datatableMotivos
        If mostrarItemNoEspecifica Then
            ComboBoxControl.SelectedIndex = 0
        Else
            ComboBoxControl.SelectedIndex = -1
        End If
    End Sub

End Module
