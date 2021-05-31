Module Siniestros

    Friend Sub LlenarComboBoxRubros(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal mostrarItemTodos As Boolean, ByVal mostrarItemNoEspecifica As Boolean)
        Dim listItems As List(Of SiniestroRubro)

        control.ValueMember = "IDSiniestroRubro"
        control.DisplayMember = "Nombre"

        listItems = context.SiniestroRubro.Where(Function(sr) sr.EsActivo).OrderBy(Function(sr) sr.Nombre).ToList

        If mostrarItemTodos Then
            Dim todos As New SiniestroRubro
            todos.IDSiniestroRubro = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE
            todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New SiniestroRubro
            noEspecifica.IDSiniestroRubro = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE
            noEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, noEspecifica)
        End If

        control.DataSource = listItems
    End Sub

    Friend Sub LlenarComboBoxTipos(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal IDSiniestroRubro As Byte, ByVal mostrarItemTodos As Boolean, ByVal mostrarItemNoEspecifica As Boolean)
        Dim listItems As List(Of SiniestroTipo)

        control.ValueMember = "IDSiniestroTipo"
        control.DisplayMember = "Nombre"

        listItems = context.SiniestroTipo.Where(Function(st) st.EsActivo AndAlso st.IDSiniestroRubro = IDSiniestroRubro).OrderBy(Function(sr) sr.Nombre).ToList

        If mostrarItemTodos Then
            Dim todos As New SiniestroTipo
            todos.IDSiniestroTipo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE
            todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New SiniestroTipo
            noEspecifica.IDSiniestroTipo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE
            noEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, noEspecifica)
        End If

        control.DataSource = listItems
    End Sub

    Friend Sub LlenarComboBoxClaves(ByRef control As ComboBox, ByVal mostrarItemTodos As Boolean, ByVal mostrarItemNoEspecifica As Boolean)
        Dim datatableClaves As New DataTable("Claves")
        Dim datarowRow As DataRow

        control.ValueMember = "IDClave"
        control.DisplayMember = "Nombre"

        With datatableClaves
            .Columns.Add("IDClave", System.Type.GetType("System.String"))
            .Columns.Add("Nombre", System.Type.GetType("System.String"))

            If mostrarItemTodos Then
                datarowRow = .NewRow
                datarowRow("IDClave") = CardonerSistemas.Constants.FIELD_VALUE_ALL_STRING
                datarowRow("Nombre") = My.Resources.STRING_ITEM_ALL_FEMALE
                .Rows.Add(datarowRow)
            End If

            If mostrarItemNoEspecifica Then
                datarowRow = .NewRow
                datarowRow("IDClave") = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_STRING
                datarowRow("Nombre") = My.Resources.STRING_ITEM_NOT_SPECIFIED
                .Rows.Add(datarowRow)
            End If

            datarowRow = .NewRow
            datarowRow("IDClave") = Constantes.SINIESTRO_CLAVE_VERDE
            datarowRow("Nombre") = Constantes.SINIESTRO_CLAVE_VERDE_NOMBRE
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDClave") = Constantes.SINIESTRO_CLAVE_AZUL
            datarowRow("Nombre") = Constantes.SINIESTRO_CLAVE_AZUL_NOMBRE
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDClave") = Constantes.SINIESTRO_CLAVE_NARANJA
            datarowRow("Nombre") = Constantes.SINIESTRO_CLAVE_NARANJA_NOMBRE
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDClave") = Constantes.SINIESTRO_CLAVE_ROJA
            datarowRow("Nombre") = Constantes.SINIESTRO_CLAVE_ROJA_NOMBRE
            .Rows.Add(datarowRow)
        End With

        control.DataSource = datatableClaves
    End Sub

    Friend Sub LlenarComboBoxAsistenciaTipos(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal mostrarItemTodos As Boolean, ByVal mostrarItemNoEspecifica As Boolean)
        Dim listItems As List(Of SiniestroAsistenciaTipo)

        control.ValueMember = "IDSiniestroAsistenciaTipo"
        control.DisplayMember = "Nombre"

        listItems = context.SiniestroAsistenciaTipo.Where(Function(sat) sat.EsActivo).OrderBy(Function(sat) sat.Orden).ThenBy(Function(sat) sat.Nombre).ToList

        If mostrarItemTodos Then
            Dim todos As New SiniestroAsistenciaTipo
            todos.IDSiniestroAsistenciaTipo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE
            todos.Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            listItems.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New SiniestroAsistenciaTipo
            noEspecifica.IDSiniestroAsistenciaTipo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE
            noEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, noEspecifica)
        End If

        control.DataSource = listItems
    End Sub

End Module
