Friend Class FillAndRefreshLists

#Region "Declarations..."
    Friend dbContext As CSBomberosContext

    Public Sub New()
        dbContext = New CSBomberosContext(True)
    End Sub

    Protected Overrides Sub Finalize()
        dbContext.Dispose()
        MyBase.Finalize()
    End Sub

#End Region

    Friend Sub DocumentoTipo(ByRef ComboBoxControl As ComboBox, ByVal ShowUnspecifiedItem As Boolean)
        ComboBoxControl.ValueMember = "IDDocumentoTipo"
        ComboBoxControl.DisplayMember = "Nombre"

        Dim qryList = From tbl In dbContext.DocumentoTipo
                          Where tbl.EsActivo
                          Order By tbl.Nombre

        Dim localList = qryList.ToList
        If ShowUnspecifiedItem Then
            Dim UnspecifiedItem As New DocumentoTipo
            UnspecifiedItem.IDDocumentoTipo = 0
            UnspecifiedItem.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            UnspecifiedItem.VerificaModulo11 = False
            localList.Insert(0, UnspecifiedItem)
        End If

        ComboBoxControl.DataSource = localList
    End Sub

    Friend Sub Provincia(ByRef ComboBoxControl As ComboBox, ByVal ShowUnspecifiedItem As Boolean)
        ComboBoxControl.ValueMember = "IDProvincia"
        ComboBoxControl.DisplayMember = "Nombre"

        Dim qryList = From tbl In dbContext.Provincia
                          Order By tbl.Nombre

        Dim localList = qryList.ToList
        If ShowUnspecifiedItem Then
            Dim UnspecifiedItem As New Provincia
            UnspecifiedItem.IDProvincia = Constantes.PROVINCIA_NOESPECIFICA
            UnspecifiedItem.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            localList.Insert(0, UnspecifiedItem)
        End If

        ComboBoxControl.DataSource = localList
    End Sub

    Friend Sub Localidad(ByRef ComboBoxControl As ComboBox, ByVal IDProvincia As Byte, ByVal ShowUnspecifiedItem As Boolean)
        ComboBoxControl.ValueMember = "IDLocalidad"
        ComboBoxControl.DisplayMember = "Nombre"

        Dim qryList = From tbl In dbContext.Localidad
                          Where tbl.IDProvincia = IDProvincia
                          Order By tbl.Nombre

        Dim localList = qryList.ToList
        If ShowUnspecifiedItem Then
            Dim UnspecifiedItem As New Localidad
            UnspecifiedItem.IDLocalidad = 0
            UnspecifiedItem.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            localList.Insert(0, UnspecifiedItem)
        End If

        ComboBoxControl.DataSource = localList
    End Sub

    Friend Sub Genero(ByRef ComboBoxControl As ComboBox, ByVal ShowUnspecifiedItem As Boolean)
        Dim datatableGeneros As New DataTable("Generos")
        Dim datarowRow As DataRow

        ComboBoxControl.ValueMember = "IDGenero"
        ComboBoxControl.DisplayMember = "Nombre"

        With datatableGeneros
            .Columns.Add("IDGenero", System.Type.GetType("System.String"))
            .Columns.Add("Nombre", System.Type.GetType("System.String"))

            If ShowUnspecifiedItem Then
                datarowRow = .NewRow
                datarowRow("IDGenero") = Constantes.PERSONA_GENERO_NOESPECIFICA
                datarowRow("Nombre") = My.Resources.STRING_ITEM_NOT_SPECIFIED
                .Rows.Add(datarowRow)
            End If

            datarowRow = .NewRow
            datarowRow("IDGenero") = Constantes.PERSONA_GENERO_MASCULINO
            datarowRow("Nombre") = My.Resources.STRING_GENERO_MASCULINO
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDGenero") = Constantes.PERSONA_GENERO_FEMENINO
            datarowRow("Nombre") = My.Resources.STRING_GENERO_FEMENINO
            .Rows.Add(datarowRow)
        End With

        ComboBoxControl.DataSource = datatableGeneros
        If ShowUnspecifiedItem Then
            ComboBoxControl.SelectedIndex = 0
        Else
            ComboBoxControl.SelectedIndex = -1
        End If
    End Sub

    Friend Sub GrupoSanguineo(ByRef ComboBoxControl As ComboBox, ByVal ShowUnspecifiedItem As Boolean)
        Dim datatableGrupoSanguineos As New DataTable("GrupoSanguineos")
        Dim datarowRow As DataRow

        ComboBoxControl.ValueMember = "IDGrupoSanguineo"
        ComboBoxControl.DisplayMember = "Nombre"

        With datatableGrupoSanguineos
            .Columns.Add("IDGrupoSanguineo", System.Type.GetType("System.String"))
            .Columns.Add("Nombre", System.Type.GetType("System.String"))

            If ShowUnspecifiedItem Then
                datarowRow = .NewRow
                datarowRow("IDGrupoSanguineo") = ""
                datarowRow("Nombre") = My.Resources.STRING_ITEM_NOT_SPECIFIED
                .Rows.Add(datarowRow)
            End If

            datarowRow = .NewRow
            datarowRow("IDGrupoSanguineo") = "0"
            datarowRow("Nombre") = "0"
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDGrupoSanguineo") = "A"
            datarowRow("Nombre") = "A"
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDGrupoSanguineo") = "B"
            datarowRow("Nombre") = "B"
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDGrupoSanguineo") = "AB"
            datarowRow("Nombre") = "AB"
            .Rows.Add(datarowRow)
        End With

        ComboBoxControl.DataSource = datatableGrupoSanguineos
        If ShowUnspecifiedItem Then
            ComboBoxControl.SelectedIndex = 0
        Else
            ComboBoxControl.SelectedIndex = -1
        End If
    End Sub

    Friend Sub FactorRH(ByRef ComboBoxControl As ComboBox, ByVal ShowUnspecifiedItem As Boolean)
        Dim datatableFactorRHs As New DataTable("FactorRHs")
        Dim datarowRow As DataRow

        ComboBoxControl.ValueMember = "IDFactorRH"
        ComboBoxControl.DisplayMember = "Nombre"

        With datatableFactorRHs
            .Columns.Add("IDFactorRH", System.Type.GetType("System.String"))
            .Columns.Add("Nombre", System.Type.GetType("System.String"))

            If ShowUnspecifiedItem Then
                datarowRow = .NewRow
                datarowRow("IDFactorRH") = ""
                datarowRow("Nombre") = My.Resources.STRING_ITEM_NOT_SPECIFIED
                .Rows.Add(datarowRow)
            End If

            datarowRow = .NewRow
            datarowRow("IDFactorRH") = "+"
            datarowRow("Nombre") = "+ (Positivo)"
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDFactorRH") = "-"
            datarowRow("Nombre") = "- (Negativo)"
            .Rows.Add(datarowRow)
        End With

        ComboBoxControl.DataSource = datatableFactorRHs
        If ShowUnspecifiedItem Then
            ComboBoxControl.SelectedIndex = 0
        Else
            ComboBoxControl.SelectedIndex = -1
        End If
    End Sub

    Friend Sub Estado(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim datatableEstados As New DataTable("Estados")
        Dim datarowRow As DataRow

        ComboBoxControl.ValueMember = "IDEstado"
        ComboBoxControl.DisplayMember = "Nombre"

        With datatableEstados
            .Columns.Add("IDEstado", System.Type.GetType("System.String"))
            .Columns.Add("Nombre", System.Type.GetType("System.String"))

            If AgregarItem_Todos Then
                datarowRow = .NewRow
                datarowRow("IDEstado") = "-"
                datarowRow("Nombre") = My.Resources.STRING_ITEM_ALL_MALE
                .Rows.Add(datarowRow)
            End If
            If AgregarItem_NoEspecifica Then
                datarowRow = .NewRow
                datarowRow("IDEstado") = "-"
                datarowRow("Nombre") = My.Resources.STRING_ITEM_NOT_SPECIFIED
                .Rows.Add(datarowRow)
            End If

            datarowRow = .NewRow
            datarowRow("IDEstado") = Constantes.PERSONA_ESTADO_ACTIVO
            datarowRow("Nombre") = My.Resources.STRING_PERSONA_ESTADO_ACTIVO
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDEstado") = Constantes.PERSONA_ESTADO_RESERVA
            datarowRow("Nombre") = My.Resources.STRING_PERSONA_ESTADO_RESERVA
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDEstado") = Constantes.PERSONA_ESTADO_CUERPOAUXILIAR
            datarowRow("Nombre") = My.Resources.STRING_PERSONA_ESTADO_CUERPOAUXILIAR
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDEstado") = Constantes.PERSONA_ESTADO_BAJA
            datarowRow("Nombre") = My.Resources.STRING_PERSONA_ESTADO_BAJA
            .Rows.Add(datarowRow)
        End With

        ComboBoxControl.DataSource = datatableEstados
        If AgregarItem_Todos Or AgregarItem_NoEspecifica Then
            ComboBoxControl.SelectedIndex = -1
        Else
            ComboBoxControl.SelectedIndex = 0
        End If
    End Sub

    Friend Sub Mes(ByRef ComboBoxControl As ComboBox, ByVal MostrarNombreDelMes As Boolean, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        If MostrarNombreDelMes Then
            ComboBoxControl.Items.AddRange({"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Else
            ComboBoxControl.Items.AddRange({1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12})
        End If

        If AgregarItem_Todos Then
            ComboBoxControl.Items.Insert(0, My.Resources.STRING_ITEM_ALL_MALE)
        End If
        If AgregarItem_NoEspecifica Then
            ComboBoxControl.Items.Insert(0, My.Resources.STRING_ITEM_NOT_SPECIFIED)
        End If
    End Sub

    Friend Sub NivelEstudio(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of NivelEstudio)

        ComboBoxControl.ValueMember = "IDNivelEstudio"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = dbContext.NivelEstudio.OrderBy(Function(cl) cl.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New NivelEstudio
            Item_Todos.IDNivelEstudio = 0
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If
        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New NivelEstudio
            Item_NoEspecifica.IDNivelEstudio = 0
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Cuartel(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Cuartel)

        ComboBoxControl.ValueMember = "IDCuartel"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = dbContext.Cuartel.OrderBy(Function(cl) cl.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New Cuartel
            Item_Todos.IDCuartel = 0
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If
        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Cuartel
            Item_NoEspecifica.IDCuartel = 0
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Parentesco(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Parentesco)

        ComboBoxControl.ValueMember = "IDParentesco"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = dbContext.Parentesco.OrderBy(Function(cl) cl.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New Parentesco
            Item_Todos.IDParentesco = 0
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If
        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Parentesco
            Item_NoEspecifica.IDParentesco = 0
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Ubicaciones(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Ubicacion)

        ComboBoxControl.ValueMember = "IDUbicacion"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = dbContext.Ubicacion.OrderBy(Function(cl) cl.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New Ubicacion
            Item_Todos.IDUbicacion = 0
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If
        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Ubicacion
            Item_NoEspecifica.IDUbicacion = 0
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Automotores(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean, Optional ByVal IDCuartel As Byte = 0)
        Dim listItems As List(Of Automotor)

        ComboBoxControl.ValueMember = "IDAutomotor"
        ComboBoxControl.DisplayMember = "NumeroMarcaModelo"

        If IDCuartel = 0 Then
            listItems = dbContext.Automotor.OrderBy(Function(aut) aut.NumeroMarcaModelo).ToList
        Else
            listItems = dbContext.Automotor.Where(Function(aut) aut.IDCuartel = IDCuartel).OrderBy(Function(aut) aut.NumeroMarcaModelo).ToList
        End If

        If AgregarItem_Todos Then
            Dim Item_Todos As New Automotor
            Item_Todos.IDAutomotor = 0
            Item_Todos.NumeroMarcaModelo = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If
        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Automotor
            Item_NoEspecifica.IDAutomotor = 0
            Item_NoEspecifica.NumeroMarcaModelo = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

End Class
