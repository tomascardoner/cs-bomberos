Friend Class FillAndRefreshLists

#Region "Declarations..."
    Private mdbContext As CSBomberosContext

    Public Sub New()
        mdbContext = New CSBomberosContext(True)
    End Sub

    Protected Overrides Sub Finalize()
        mdbContext.Dispose()
        MyBase.Finalize()
    End Sub

#End Region

    Friend Sub DocumentoTipo(ByRef ComboBoxControl As ComboBox, ByVal ShowUnspecifiedItem As Boolean)
        ComboBoxControl.ValueMember = "IDDocumentoTipo"
        ComboBoxControl.DisplayMember = "Nombre"

        Dim qryList = From tbl In mdbContext.DocumentoTipo
                      Where tbl.EsActivo
                      Order By tbl.Nombre

        Dim localList = qryList.ToList
        If ShowUnspecifiedItem Then
            Dim UnspecifiedItem As New DocumentoTipo
            UnspecifiedItem.IDDocumentoTipo = FIELD_VALUE_NOTSPECIFIED_BYTE
            UnspecifiedItem.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            UnspecifiedItem.VerificaModulo11 = False
            localList.Insert(0, UnspecifiedItem)
        End If

        ComboBoxControl.DataSource = localList
    End Sub

    Friend Sub Provincia(ByRef ComboBoxControl As ComboBox, ByVal ShowUnspecifiedItem As Boolean)
        ComboBoxControl.ValueMember = "IDProvincia"
        ComboBoxControl.DisplayMember = "Nombre"

        Dim qryList = From tbl In mdbContext.Provincia
                          Order By tbl.Nombre

        Dim localList = qryList.ToList
        If ShowUnspecifiedItem Then
            Dim UnspecifiedItem As New Provincia
            UnspecifiedItem.IDProvincia = FIELD_VALUE_NOTSPECIFIED_BYTE
            UnspecifiedItem.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            localList.Insert(0, UnspecifiedItem)
        End If

        ComboBoxControl.DataSource = localList
    End Sub

    Friend Sub Localidad(ByRef ComboBoxControl As ComboBox, ByVal IDProvincia As Byte, ByVal ShowUnspecifiedItem As Boolean)
        ComboBoxControl.ValueMember = "IDLocalidad"
        ComboBoxControl.DisplayMember = "Nombre"

        Dim qryList = From tbl In mdbContext.Localidad
                          Where tbl.IDProvincia = IDProvincia
                          Order By tbl.Nombre

        Dim localList = qryList.ToList
        If ShowUnspecifiedItem Then
            Dim UnspecifiedItem As New Localidad
            UnspecifiedItem.IDLocalidad = FIELD_VALUE_NOTSPECIFIED_SHORT
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

    'Friend Sub Estado(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
    '    Dim datatableEstados As New DataTable("Estados")
    '    Dim datarowRow As DataRow

    '    ComboBoxControl.ValueMember = "IDEstado"
    '    ComboBoxControl.DisplayMember = "Nombre"

    '    With datatableEstados
    '        .Columns.Add("IDEstado", System.Type.GetType("System.String"))
    '        .Columns.Add("Nombre", System.Type.GetType("System.String"))

    '        If AgregarItem_Todos Then
    '            datarowRow = .NewRow
    '            datarowRow("IDEstado") = "-"
    '            datarowRow("Nombre") = My.Resources.STRING_ITEM_ALL_MALE
    '            .Rows.Add(datarowRow)
    '        End If
    '        If AgregarItem_NoEspecifica Then
    '            datarowRow = .NewRow
    '            datarowRow("IDEstado") = "-"
    '            datarowRow("Nombre") = My.Resources.STRING_ITEM_NOT_SPECIFIED
    '            .Rows.Add(datarowRow)
    '        End If

    '        datarowRow = .NewRow
    '        datarowRow("IDEstado") = Constantes.PERSONA_ESTADO_ACTIVO
    '        datarowRow("Nombre") = My.Resources.STRING_PERSONA_ESTADO_ACTIVO
    '        .Rows.Add(datarowRow)

    '        datarowRow = .NewRow
    '        datarowRow("IDEstado") = Constantes.PERSONA_ESTADO_RESERVA
    '        datarowRow("Nombre") = My.Resources.STRING_PERSONA_ESTADO_RESERVA
    '        .Rows.Add(datarowRow)

    '        datarowRow = .NewRow
    '        datarowRow("IDEstado") = Constantes.PERSONA_ESTADO_CUERPOAUXILIAR
    '        datarowRow("Nombre") = My.Resources.STRING_PERSONA_ESTADO_CUERPOAUXILIAR
    '        .Rows.Add(datarowRow)

    '        datarowRow = .NewRow
    '        datarowRow("IDEstado") = Constantes.PERSONA_ESTADO_BAJA
    '        datarowRow("Nombre") = My.Resources.STRING_PERSONA_ESTADO_BAJA
    '        .Rows.Add(datarowRow)
    '    End With

    '    ComboBoxControl.DataSource = datatableEstados
    '    If AgregarItem_Todos Or AgregarItem_NoEspecifica Then
    '        ComboBoxControl.SelectedIndex = -1
    '    Else
    '        ComboBoxControl.SelectedIndex = 0
    '    End If
    'End Sub

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

        listItems = mdbContext.NivelEstudio.Where(Function(ne) ne.EsActivo).OrderBy(Function(cl) cl.Nombre).ToList

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

        If pUsuario.IDCuartel.HasValue Then
            ' Tengo que limitar la lista al cuartel que tiene especificado
            listItems = New List(Of Cuartel)

            listItems.Insert(0, mdbContext.Cuartel.Find(pUsuario.IDCuartel))
        Else
            listItems = mdbContext.Cuartel.Where(Function(c) c.EsActivo).OrderBy(Function(cl) cl.Nombre).ToList

            If AgregarItem_Todos Then
                Dim Item_Todos As New Cuartel
                Item_Todos.IDCuartel = FIELD_VALUE_ALL_BYTE
                Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
                listItems.Insert(0, Item_Todos)
            End If
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Cuartel
            Item_NoEspecifica.IDCuartel = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Persona(ByRef ComboBoxControl As ComboBox, ByVal MostrarInactivos As Boolean, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Persona)

        ComboBoxControl.ValueMember = "IDPersona"
        ComboBoxControl.DisplayMember = "ApellidoNombre"

        If MostrarInactivos Then
            listItems = mdbContext.Persona.OrderBy(Function(p) p.ApellidoNombre).ToList
        Else
            listItems = mdbContext.Persona.Where(Function(p) p.EsActivo).OrderBy(Function(p) p.ApellidoNombre).ToList
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Persona
            Item_NoEspecifica.IDPersona = FIELD_VALUE_NOTSPECIFIED_INTEGER
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New Persona
            Item_Todos.IDPersona = FIELD_VALUE_ALL_INTEGER
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub SancionTipo(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of SancionTipo)

        ComboBoxControl.ValueMember = "IDSancionTipo"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.SancionTipo.Where(Function(st) st.EsActivo).OrderBy(Function(st) st.Nombre).ToList

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New SancionTipo
            Item_NoEspecifica.IDSancionTipo = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New SancionTipo
            Item_Todos.IDSancionTipo = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Parentesco(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Parentesco)

        ComboBoxControl.ValueMember = "IDParentesco"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.Parentesco.Where(Function(p) p.EsActivo).OrderBy(Function(pa) pa.Orden).ThenBy(Function(pa) pa.Nombre).ToList

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Parentesco
            Item_NoEspecifica.IDParentesco = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New Parentesco
            Item_Todos.IDParentesco = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub PersonaBajaMotivo(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of PersonaBajaMotivo)

        ComboBoxControl.ValueMember = "IDPersonaBajaMotivo"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.PersonaBajaMotivo.Where(Function(pbm) pbm.EsActivo).OrderBy(Function(pbm) pbm.Nombre).ToList

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New PersonaBajaMotivo
            Item_NoEspecifica.IDPersonaBajaMotivo = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New PersonaBajaMotivo
            Item_Todos.IDPersonaBajaMotivo = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Area(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean, ByVal IDCuartel As Byte)
        Dim listItems As List(Of Area)

        ComboBoxControl.ValueMember = "IDArea"
        ComboBoxControl.DisplayMember = "Nombre"

        If IDCuartel = CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = mdbContext.Area.Where(Function(a) a.EsActivo).OrderBy(Function(a) a.Nombre).ToList
        Else
            listItems = mdbContext.Area.Where(Function(a) a.EsActivo And a.IDCuartel = IDCuartel).OrderBy(Function(a) a.Nombre).ToList
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Area
            Item_NoEspecifica.IDArea = Short.MinValue
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New Area
            Item_Todos.IDArea = 0
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Ubicacion(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean, Optional ByVal IDCuartel As Byte = FIELD_VALUE_NOTSPECIFIED_BYTE)
        Dim listItems As List(Of Ubicacion)

        ComboBoxControl.ValueMember = "IDUbicacion"
        ComboBoxControl.DisplayMember = "Nombre"

        If IDCuartel = FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = mdbContext.Ubicacion.Where(Function(u) u.EsActivo).OrderBy(Function(cl) cl.Nombre).ToList
        Else
            listItems = mdbContext.Ubicacion.Where(Function(u) u.EsActivo And u.IDCuartel = IDCuartel).OrderBy(Function(u) u.Nombre).ToList
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Ubicacion
            Item_NoEspecifica.IDUbicacion = FIELD_VALUE_NOTSPECIFIED_SHORT
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New Ubicacion
            Item_Todos.IDUbicacion = 0
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub SubUbicacion(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean, ByVal IDUbicacion As Short)
        Dim listItems As List(Of SubUbicacion)

        ComboBoxControl.ValueMember = "IDSubUbicacion"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.SubUbicacion.Where(Function(su) su.EsActivo And su.IDUbicacion = IDUbicacion).OrderBy(Function(su) su.Nombre).ToList

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New SubUbicacion
            Item_NoEspecifica.IDSubUbicacion = FIELD_VALUE_NOTSPECIFIED_SHORT
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New SubUbicacion
            Item_Todos.IDSubUbicacion = FIELD_VALUE_ALL_SHORT
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Rubro(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Rubro)

        ComboBoxControl.ValueMember = "IDRubro"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.Rubro.Where(Function(r) r.EsActivo).OrderBy(Function(r) r.Nombre).ToList

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Rubro
            Item_NoEspecifica.IDRubro = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New Rubro
            Item_Todos.IDRubro = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub SubRubro(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean, ByVal IDRubro As Byte)
        Dim listItems As List(Of SubRubro)

        ComboBoxControl.ValueMember = "IDSubRubro"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.SubRubro.Where(Function(sr) sr.EsActivo And sr.IDRubro = IDRubro).OrderBy(Function(sr) sr.Nombre).ToList

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New SubRubro
            Item_NoEspecifica.IDSubRubro = FIELD_VALUE_NOTSPECIFIED_SHORT
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New SubRubro
            Item_Todos.IDSubRubro = FIELD_VALUE_ALL_SHORT
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Unidad(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean, Optional ByVal IDCuartel As Byte = FIELD_VALUE_NOTSPECIFIED_BYTE)
        Dim listItems As List(Of Unidad)

        ComboBoxControl.ValueMember = "IDUnidad"
        ComboBoxControl.DisplayMember = "NumeroMarcaModelo"

        If IDCuartel = FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = mdbContext.Unidad.Where(Function(a) a.EsActivo).OrderBy(Function(a) a.Numero).ToList
        Else
            listItems = mdbContext.Unidad.Where(Function(a) a.EsActivo And a.IDCuartel = IDCuartel).OrderBy(Function(a) a.Numero).ToList
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Unidad
            Item_NoEspecifica.IDUnidad = FIELD_VALUE_NOTSPECIFIED_SHORT
            Item_NoEspecifica.NumeroMarcaModelo = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New Unidad
            Item_Todos.IDUnidad = FIELD_VALUE_ALL_SHORT
            Item_Todos.NumeroMarcaModelo = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub ModoAdquisicion(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of ModoAdquisicion)

        ComboBoxControl.ValueMember = "IDModoAdquisicion"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.ModoAdquisicion.Where(Function(ma) ma.EsActivo).OrderBy(Function(ma) ma.Nombre).ToList

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New ModoAdquisicion
            Item_NoEspecifica.IDModoAdquisicion = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New ModoAdquisicion
            Item_Todos.IDModoAdquisicion = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

#Region "Elemento"

    Friend Sub ElementoFill(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Elemento)

        ComboBoxControl.ValueMember = "IDElemento"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.Elemento.Where(Function(e) e.EsActivo).OrderBy(Function(e) e.Nombre).ToList

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Elemento
            Item_NoEspecifica.IDElemento = FIELD_VALUE_NOTSPECIFIED_INTEGER
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New Elemento
            Item_Todos.IDElemento = FIELD_VALUE_ALL_INTEGER
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub ElementoRefresh()
        If Application.OpenForms().OfType(Of formElementos).Any Then
            'mdbContext.Unidad.Re()
        End If
        'mdbContext.Entry(formInventarioDetalle.comboboxElemento.DataSource).Reload()
    End Sub

#End Region

    Friend Sub UnidadTipo(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of UnidadTipo)

        ComboBoxControl.ValueMember = "IDUnidadTipo"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.UnidadTipo.Where(Function(at) at.EsActivo).OrderBy(Function(at) at.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New UnidadTipo
            Item_Todos.IDUnidadTipo = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New UnidadTipo
            Item_NoEspecifica.IDUnidadTipo = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub UnidadUso(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of UnidadUso)

        ComboBoxControl.ValueMember = "IDUnidadUso"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.UnidadUso.Where(Function(au) au.EsActivo).OrderBy(Function(au) au.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New UnidadUso
            Item_Todos.IDUnidadUso = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New UnidadUso
            Item_NoEspecifica.IDUnidadUso = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub UnidadBajaMotivo(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of UnidadBajaMotivo)

        ComboBoxControl.ValueMember = "IDUnidadBajaMotivo"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.UnidadBajaMotivo.Where(Function(pbm) pbm.EsActivo).OrderBy(Function(pbm) pbm.Nombre).ToList

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New UnidadBajaMotivo
            Item_NoEspecifica.IDUnidadBajaMotivo = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New UnidadBajaMotivo
            Item_Todos.IDUnidadBajaMotivo = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub CombustibleTipo(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of CombustibleTipo)

        ComboBoxControl.ValueMember = "IDCombustibleTipo"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.CombustibleTipo.Where(Function(ct) ct.EsActivo).OrderBy(Function(ct) ct.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New CombustibleTipo
            Item_Todos.IDCombustibleTipo = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New CombustibleTipo
            Item_NoEspecifica.IDCombustibleTipo = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub UsuarioGrupo(ByRef ComboBoxControl As ComboBox, ByVal MostrarGrupoAdministradores As Boolean, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of UsuarioGrupo)

        ComboBoxControl.ValueMember = "IDUsuarioGrupo"
        ComboBoxControl.DisplayMember = "Nombre"

        If MostrarGrupoAdministradores Then
            listItems = mdbContext.UsuarioGrupo.Where(Function(ug) ug.EsActivo).OrderBy(Function(ug) ug.Nombre).ToList
        Else
            listItems = mdbContext.UsuarioGrupo.Where(Function(ug) ug.EsActivo And ug.IDUsuarioGrupo <> USUARIOGRUPO_ADMINISTRADORES_ID).OrderBy(Function(ug) ug.Nombre).ToList
        End If

        If AgregarItem_Todos Then
            Dim Item_Todos As New UsuarioGrupo
            Item_Todos.IDUsuarioGrupo = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New UsuarioGrupo
            Item_NoEspecifica.IDUsuarioGrupo = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Cargo(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Cargo)

        ComboBoxControl.ValueMember = "IDCargo"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.Cargo.Where(Function(c) c.EsActivo).OrderBy(Function(c) c.Orden).ThenBy(Function(c) c.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New Cargo
            Item_Todos.IDCargo = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Cargo
            Item_NoEspecifica.IDCargo = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub CargoJerarquia(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean, Optional ByVal IDCargo As Byte = FIELD_VALUE_NOTSPECIFIED_BYTE)
        Dim listItems As List(Of CargoJerarquia)

        ComboBoxControl.ValueMember = "IDJerarquia"
        ComboBoxControl.DisplayMember = "Nombre"

        If IDCargo = FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = mdbContext.CargoJerarquia.Where(Function(cj) cj.EsActivo).OrderBy(Function(cj) cj.Cargo.Orden).ThenBy(Function(cj) cj.Orden).ThenBy(Function(cj) cj.Nombre).ToList
        Else
            listItems = mdbContext.CargoJerarquia.Where(Function(cj) cj.EsActivo And cj.IDCargo = IDCargo).OrderBy(Function(cj) cj.Orden).ThenBy(Function(cj) cj.Nombre).ToList
        End If

        If AgregarItem_Todos Then
            Dim Item_Todos As New CargoJerarquia
            Item_Todos.IDCargo = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New CargoJerarquia
            Item_NoEspecifica.IDCargo = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub LicenciaCausa(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of LicenciaCausa)

        ComboBoxControl.ValueMember = "IDLicenciaCausa"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.LicenciaCausa.Where(Function(lc) lc.EsActivo).OrderBy(Function(lc) lc.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New LicenciaCausa
            Item_Todos.IDLicenciaCausa = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New LicenciaCausa
            Item_NoEspecifica.IDLicenciaCausa = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub LicenciaConducirCategoria(ByRef ComboBoxControl As CheckedListBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of LicenciaConducirCategoria)

        ComboBoxControl.ValueMember = "IDLicenciaConducirCategoria"
        ComboBoxControl.DisplayMember = "Codigo"

        listItems = mdbContext.LicenciaConducirCategoria.Where(Function(lc) lc.EsActivo).OrderBy(Function(lc) lc.Codigo).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New LicenciaConducirCategoria
            Item_Todos.IDLicenciaConducirCategoria = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New LicenciaConducirCategoria
            Item_NoEspecifica.IDLicenciaConducirCategoria = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Curso(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Curso)

        ComboBoxControl.ValueMember = "IDCurso"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.Curso.Where(Function(c) c.EsActivo).OrderBy(Function(c) c.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New Curso
            Item_Todos.IDCurso = FIELD_VALUE_ALL_SHORT
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Curso
            Item_NoEspecifica.IDCurso = FIELD_VALUE_NOTSPECIFIED_SHORT
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub CapacitacionNivel(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of CapacitacionNivel)

        ComboBoxControl.ValueMember = "IDCapacitacionNivel"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.CapacitacionNivel.Where(Function(c) c.EsActivo).OrderBy(Function(c) c.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New CapacitacionNivel
            Item_Todos.IDCapacitacionNivel = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New CapacitacionNivel
            Item_NoEspecifica.IDCapacitacionNivel = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub CapacitacionTipo(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of CapacitacionTipo)

        ComboBoxControl.ValueMember = "IDCapacitacionTipo"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.CapacitacionTipo.Where(Function(c) c.EsActivo).OrderBy(Function(c) c.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New CapacitacionTipo
            Item_Todos.IDCapacitacionTipo = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New CapacitacionTipo
            Item_NoEspecifica.IDCapacitacionTipo = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub PersonaCalificacionAnio(ByRef ComboBoxControl As ComboBox, ByVal IDPersona As Integer, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of String)

        listItems = (From pc In mdbContext.PersonaCalificacion
                     Where pc.IDPersona = IDPersona
                     Order By pc.Anio
                     Select CStr(pc.Anio)).Distinct.ToList

        If AgregarItem_Todos Then
            listItems.Insert(0, My.Resources.STRING_ITEM_ALL_MALE)
        End If

        If AgregarItem_NoEspecifica Then
            listItems.Insert(0, My.Resources.STRING_ITEM_NOT_SPECIFIED)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub
End Class
