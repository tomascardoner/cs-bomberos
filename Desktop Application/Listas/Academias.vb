Module Academias
    Friend Sub LlenarComboBoxTipos(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal mostrarItemTodos As Boolean, ByVal mostrarItemNoEspecifica As Boolean)
        Dim listItems As List(Of AcademiaTipo)

        control.ValueMember = "IDAcademiaTipo"
        control.DisplayMember = "Nombre"

        listItems = context.AcademiaTipo.Where(Function(st) st.EsActivo).OrderBy(Function(sr) sr.Nombre).ToList

        If mostrarItemTodos Then
            Dim todos As New AcademiaTipo
            todos.IDAcademiaTipo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE
            todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New AcademiaTipo
            noEspecifica.IDAcademiaTipo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE
            noEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, noEspecifica)
        End If

        control.DataSource = listItems
    End Sub

    Friend Sub LlenarComboBoxAsistenciaTipos(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal mostrarItemTodos As Boolean, ByVal mostrarItemNoEspecifica As Boolean)
        Dim listItems As List(Of AcademiaAsistenciaTipo)

        control.ValueMember = "IDAcademiaAsistenciaTipo"
        control.DisplayMember = "Nombre"

        listItems = context.AcademiaAsistenciaTipo.Where(Function(sat) sat.EsActivo).OrderBy(Function(sat) sat.Orden).ThenBy(Function(sat) sat.Nombre).ToList

        If mostrarItemTodos Then
            Dim todos As New AcademiaAsistenciaTipo
            todos.IDAcademiaAsistenciaTipo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE
            todos.Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            listItems.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New AcademiaAsistenciaTipo
            noEspecifica.IDAcademiaAsistenciaTipo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE
            noEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, noEspecifica)
        End If

        control.DataSource = listItems
    End Sub

End Module
