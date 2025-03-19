Module ListasSiniestros

    Friend Sub LlenarComboBoxRubros(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal mostrarItemTodos As Boolean, ByVal mostrarItemNoEspecifica As Boolean)
        Dim listItems As List(Of SiniestroRubro)

        control.ValueMember = "IDSiniestroRubro"
        control.DisplayMember = "Nombre"

        listItems = context.SiniestroRubro.Where(Function(sr) sr.EsActivo).OrderBy(Function(sr) sr.Nombre).ToList

        If mostrarItemTodos Then
            Dim todos As New SiniestroRubro With {
                .IDSiniestroRubro = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New SiniestroRubro With {
                .IDSiniestroRubro = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
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
            Dim todos As New SiniestroTipo With {
                .IDSiniestroTipo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New SiniestroTipo With {
                .IDSiniestroTipo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, noEspecifica)
        End If

        control.DataSource = listItems
    End Sub

    Friend Sub LlenarComboBoxClaves(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal mostrarItemTodos As Boolean, ByVal mostrarItemNoEspecifica As Boolean)
        Dim listItems As List(Of SiniestroClave)

        control.ValueMember = "IDSiniestroClave"
        control.DisplayMember = "Nombre"

        listItems = context.SiniestroClave.Where(Function(sc) sc.EsActivo).OrderBy(Function(sc) sc.Orden).ThenBy(Function(sc) sc.Nombre).ToList

        If mostrarItemTodos Then
            Dim todos As New SiniestroClave With {
                .IDSiniestroClave = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            }
            listItems.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New SiniestroClave With {
                .IDSiniestroClave = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, noEspecifica)
        End If

        control.DataSource = listItems
    End Sub

    Friend Sub LlenarComboBoxGruposDeClaves(ByRef control As ComboBox, ByVal mostrarItemTodos As Boolean, ByVal mostrarItemNoEspecifica As Boolean)
        Dim datatableTable As New DataTable("GruposClave")
        Dim datarowRow As DataRow

        control.ValueMember = "IDGrupo"
        control.DisplayMember = "Nombre"

        With datatableTable
            .Columns.Add("IDGrupo", System.Type.GetType("System.String"))
            .Columns.Add("Nombre", System.Type.GetType("System.String"))

            If mostrarItemNoEspecifica Then
                datarowRow = .NewRow
                datarowRow("IDGrupo") = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_STRING
                datarowRow("Nombre") = My.Resources.STRING_ITEM_NOT_SPECIFIED
                .Rows.Add(datarowRow)
            End If

            If mostrarItemTodos Then
                datarowRow = .NewRow
                datarowRow("IDGrupo") = CardonerSistemas.Constants.FIELD_VALUE_ALL_STRING
                datarowRow("Nombre") = My.Resources.STRING_ITEM_ALL_MALE
                .Rows.Add(datarowRow)
            End If

            datarowRow = .NewRow
            datarowRow("IDGrupo") = Constantes.SINIESTRO_CLAVEGRUPO_AZULVERDE
            datarowRow("Nombre") = Constantes.SINIESTRO_CLAVEGRUPO_AZULVERDE_NOMBRE
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDGrupo") = Constantes.SINIESTRO_CLAVEGRUPO_NARANJA
            datarowRow("Nombre") = Constantes.SINIESTRO_CLAVEGRUPO_NARANJA_NOMBRE
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDGrupo") = Constantes.SINIESTRO_CLAVEGRUPO_ROJA
            datarowRow("Nombre") = Constantes.SINIESTRO_CLAVEGRUPO_ROJA_NOMBRE
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDGrupo") = Constantes.SINIESTRO_CLAVEGRUPO_SERVICIOPROGRAMADO
            datarowRow("Nombre") = Constantes.SINIESTRO_CLAVEGRUPO_SERVICIOPROGRAMADO_NOMBRE
            .Rows.Add(datarowRow)
        End With

        control.DataSource = datatableTable
        If mostrarItemNoEspecifica Then
            control.SelectedIndex = 0
        Else
            control.SelectedIndex = -1
        End If
    End Sub

    Friend Sub LlenarComboBoxAsistenciaTipos(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal mostrarItemTodos As Boolean, ByVal mostrarItemNoEspecifica As Boolean)
        Dim listItems As List(Of SiniestroAsistenciaTipo)

        control.ValueMember = "IDSiniestroAsistenciaTipo"
        control.DisplayMember = "Nombre"

        listItems = context.SiniestroAsistenciaTipo.Where(Function(sat) sat.EsActivo).OrderBy(Function(sat) sat.Orden).ThenBy(Function(sat) sat.Nombre).ToList

        If mostrarItemTodos Then
            Dim todos As New SiniestroAsistenciaTipo With {
                .IDSiniestroAsistenciaTipo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            }
            listItems.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New SiniestroAsistenciaTipo With {
                .IDSiniestroAsistenciaTipo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, noEspecifica)
        End If

        control.DataSource = listItems
    End Sub

    Friend Sub LlenarComboBoxSolicitudFormas(ByRef context As CSBomberosContext, ByRef control As ComboBox, mostrarItemTodos As Boolean, mostrarItemNoEspecifica As Boolean)
        Dim listItems As List(Of SiniestroSolicitudForma)

        control.ValueMember = "IdSiniestroSolicitudForma"
        control.DisplayMember = "Nombre"

        listItems = context.SiniestroSolicitudForma.Where(Function(ssf) ssf.EsActivo).OrderBy(Function(ssf) ssf.Nombre).ToList

        If mostrarItemTodos Then
            Dim todos As New SiniestroSolicitudForma With {
                .IdSiniestroSolicitudForma = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            }
            listItems.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New SiniestroSolicitudForma With {
                .IdSiniestroSolicitudForma = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, noEspecifica)
        End If

        control.DataSource = listItems
    End Sub

    Friend Sub LlenarComboBoxUbicacionTipos(ByRef context As CSBomberosContext, ByRef control As ComboBox, mostrarItemTodos As Boolean, mostrarItemNoEspecifica As Boolean)
        Dim listItems As List(Of SiniestroUbicacionTipo)

        control.ValueMember = "IdSiniestroUbicacionTipo"
        control.DisplayMember = "Nombre"

        listItems = context.SiniestroUbicacionTipo.Where(Function(sut) sut.EsActivo).OrderBy(Function(sut) sut.Nombre).ToList

        If mostrarItemTodos Then
            Dim todos As New SiniestroUbicacionTipo With {
                .IdSiniestroUbicacionTipo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            }
            listItems.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New SiniestroUbicacionTipo With {
                .IdSiniestroUbicacionTipo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, noEspecifica)
        End If

        control.DataSource = listItems
    End Sub

    Friend Sub LlenarComboBoxDamnificadoEstados(ByRef context As CSBomberosContext, ByRef comboBox As ComboBox, mostrarItemTodos As Boolean, mostrarItemNoEspecifica As Boolean)
        Dim items As List(Of SiniestroDamnificadoEstado)

        comboBox.ValueMember = "IdSiniestroDamnificadoEstado"
        comboBox.DisplayMember = "Nombre"

        items = context.SiniestroDamnificadoEstado.Where(Function(sde) sde.EsActivo).OrderBy(Function(sde) sde.Nombre).ToList()

        If mostrarItemTodos Then
            Dim todos As New SiniestroDamnificadoEstado With {
                .IdSiniestroDamnificadoEstado = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            items.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New SiniestroDamnificadoEstado With {
                .IdSiniestroDamnificadoEstado = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            items.Insert(0, noEspecifica)
        End If

        comboBox.DataSource = items
    End Sub

    Friend Sub LlenarComboBoxVehiculoTipos(ByRef context As CSBomberosContext, ByRef comboBox As ComboBox, mostrarItemTodos As Boolean, mostrarItemNoEspecifica As Boolean)
        Dim items As List(Of SiniestroVehiculoTipo)

        comboBox.ValueMember = "IdSiniestroVehiculoTipo"
        comboBox.DisplayMember = "Nombre"

        items = context.SiniestroVehiculoTipo.Where(Function(sde) sde.EsActivo).OrderBy(Function(sde) sde.Nombre).ToList()

        If mostrarItemTodos Then
            Dim todos As New SiniestroVehiculoTipo With {
                .IdSiniestroVehiculoTipo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            items.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New SiniestroVehiculoTipo With {
                .IdSiniestroVehiculoTipo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            items.Insert(0, noEspecifica)
        End If

        comboBox.DataSource = items
    End Sub

    Friend Sub LlenarComboBoxVehiculoMarcas(ByRef context As CSBomberosContext, ByRef comboBox As ComboBox, mostrarItemTodos As Boolean, mostrarItemNoEspecifica As Boolean)
        Dim items As List(Of SiniestroVehiculoMarca)

        comboBox.ValueMember = "IdSiniestroVehiculoMarca"
        comboBox.DisplayMember = "Nombre"

        items = context.SiniestroVehiculoMarca.Where(Function(sde) sde.EsActivo).OrderBy(Function(sde) sde.Nombre).ToList()

        If mostrarItemTodos Then
            Dim todos As New SiniestroVehiculoMarca With {
                .IdSiniestroVehiculoMarca = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            items.Insert(0, todos)
        End If

        If mostrarItemNoEspecifica Then
            Dim noEspecifica As New SiniestroVehiculoMarca With {
                .IdSiniestroVehiculoMarca = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            items.Insert(0, noEspecifica)
        End If

        comboBox.DataSource = items
    End Sub
End Module
