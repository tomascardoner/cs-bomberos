Module ListasComunes

    Friend Class ResponsableNombresClass
        Public Property IDResponsable As Byte
        Public Property IDResponsableTipo As Byte
        Public Property ResponsableTipoNombre As String
        Public Property IDCuartel As Byte?
        Public Property CuartelNombre As String
        Public Property IDPersona As Integer?
        Public Property PersonaApellidoNombre As String
    End Class

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

    Friend Sub LlenarComboBoxResponsableTipos(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal agregarItemTodos As Boolean, ByVal agregarItemNoEspecifica As Boolean)
        Dim listItems As List(Of ResponsableTipo)

        control.ValueMember = "IDResponsableTipo"
        control.DisplayMember = "Nombre"

        listItems = context.ResponsableTipo.Where(Function(rt) rt.EsActivo).OrderBy(Function(rt) rt.Orden).ThenBy(Function(rt) rt.Nombre).ToList

        If agregarItemNoEspecifica Then
            listItems.Insert(0, New ResponsableTipo With {
                .IDResponsableTipo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            })
        End If

        If agregarItemTodos Then
            listItems.Insert(0, New ResponsableTipo With {
                .IDResponsableTipo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            })
        End If

        control.DataSource = listItems
    End Sub

    Friend Sub LlenarComboBoxResponsables(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal agregarItemTodos As Boolean, ByVal agregarItemNoEspecifica As Boolean)
        Dim listItems As List(Of ResponsableNombresClass)

        control.ValueMember = "IDResponsable"
        control.DisplayMember = "ResponsableTipoNombre"

        listItems = (From r In context.Responsable
                     Join rt In context.ResponsableTipo On r.IDResponsableTipo Equals rt.IDResponsableTipo
                     Group Join p In context.Persona On r.IDPersona Equals p.IDPersona Into PersonaGroup = Group
                     From pg In PersonaGroup.DefaultIfEmpty
                     Group Join c In context.Cuartel On r.IDCuartel Equals c.IDCuartel Into CuartelGroup = Group
                     From cg In CuartelGroup.DefaultIfEmpty
                     Order By rt.Orden, rt.Nombre, pg.ApellidoNombre, r.PersonaOtra
                     Select New ResponsableNombresClass With {.IDResponsable = r.IDResponsable, .IDResponsableTipo = r.IDResponsableTipo, .ResponsableTipoNombre = rt.Nombre, .IDCuartel = If(cg Is Nothing, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, r.IDCuartel), .CuartelNombre = If(cg Is Nothing, "", cg.Nombre), .IDPersona = r.IDPersona, .PersonaApellidoNombre = If(pg Is Nothing, r.PersonaOtra, pg.ApellidoNombre)}).ToList()

        If agregarItemNoEspecifica Then
            listItems.Insert(0, New ResponsableNombresClass With {
                .IDResponsable = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .ResponsableTipoNombre = My.Resources.STRING_ITEM_NOT_SPECIFIED,
                .PersonaApellidoNombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            })
        End If

        If agregarItemTodos Then
            listItems.Insert(0, New ResponsableNombresClass With {
                .IDResponsable = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .ResponsableTipoNombre = My.Resources.STRING_ITEM_ALL_MALE,
                .PersonaApellidoNombre = My.Resources.STRING_ITEM_ALL_MALE
            })
        End If

        control.DataSource = listItems
    End Sub

    Friend Sub LlenarComboBoxPeriodosTipos(ByRef control As ComboBox, ByVal agregarItemTodos As Boolean, ByVal agregarItemNoEspecifica As Boolean)

        If agregarItemTodos Then
            control.Items.Add(My.Resources.STRING_ITEM_ALL_MALE)
        End If

        If agregarItemNoEspecifica Then
            control.Items.Add(My.Resources.STRING_ITEM_NOT_SPECIFIED)
        End If

        control.Items.AddRange({"Día:", "Semana:", "Mes:", "Fecha"})
    End Sub

    Friend Sub LlenarComboBoxPeriodosValores(ByRef control As ComboBox, ByRef tipoControl As ComboBox)
        control.Items.Clear()
        Select Case tipoControl.SelectedIndex
            Case 0  ' Todas
                control.Items.Add(String.Empty)
            Case 1  ' Día
                control.Items.AddRange({"Hoy", "Ayer", "Anteayer", "Últimos 2", "Últimos 3", "Últimos 4"})
            Case 2  ' Semana
                control.Items.AddRange({"Actual", "Anterior", "Últimas 2", "Últimas 3"})
            Case 3  ' Mes
                control.Items.AddRange({"Actual", "Anterior", "Últimos 2", "Últimos 3"})
            Case 4  ' Fecha
                control.Items.AddRange({"es igual a:", "es posterior a:", "es anterior a:", "está entre:"})
        End Select
        control.Visible = tipoControl.SelectedIndex <> 0
        control.SelectedIndex = 0
    End Sub

End Module
