Module ListasResponsables

    Friend Class ResponsableNombresClass
        Public Property IDResponsable As Byte
        Public Property IDResponsableTipo As Byte
        Public Property ResponsableTipoNombre As String
        Public Property IDCuartel As Byte?
        Public Property CuartelNombre As String
        Public Property IDPersona As Integer?
        Public Property PersonaMatriculaNumero As String
        Public Property PersonaApellidoNombre As String
    End Class

    Friend Sub LlenarComboBoxResponsableTipos(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal agregarItemTodos As Boolean, ByVal agregarItemNoEspecifica As Boolean)
        Dim listItems As List(Of ResponsableTipo)

        control.DisplayMember = "Nombre"
        control.ValueMember = "IDResponsableTipo"

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

    Private Sub LlenarComboBoxResponsables(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal agregarItemTodos As Boolean, ByVal agregarItemNoEspecifica As Boolean)
        Dim listItems As List(Of ResponsableNombresClass)

        control.DisplayMember = "ResponsableTipoNombre"

        listItems = (From r In context.Responsable
                     Join rt In context.ResponsableTipo On r.IDResponsableTipo Equals rt.IDResponsableTipo
                     Group Join p In context.Persona On r.IDPersona Equals p.IDPersona Into PersonaGroup = Group
                     From pg In PersonaGroup.DefaultIfEmpty
                     Group Join c In context.Cuartel On r.IDCuartel Equals c.IDCuartel Into CuartelGroup = Group
                     From cg In CuartelGroup.DefaultIfEmpty
                     Order By rt.Orden, rt.Nombre, pg.ApellidoNombre, r.PersonaOtra
                     Select New ResponsableNombresClass With {.IDResponsable = r.IDResponsable, .IDResponsableTipo = r.IDResponsableTipo, .ResponsableTipoNombre = rt.Nombre, .IDCuartel = If(cg Is Nothing, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, r.IDCuartel), .CuartelNombre = If(cg Is Nothing, "", cg.Nombre), .IDPersona = r.IDPersona, .PersonaMatriculaNumero = If(pg Is Nothing, String.Empty, pg.MatriculaNumero), .PersonaApellidoNombre = If(pg Is Nothing, r.PersonaOtra, pg.ApellidoNombre)}).ToList()

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

    Friend Sub LlenarComboBoxResponsableTiposConIDResponsable(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal agregarItemTodos As Boolean, ByVal agregarItemNoEspecifica As Boolean)
        control.ValueMember = "IDResponsable"

        LlenarComboBoxResponsables(context, control, agregarItemTodos, agregarItemNoEspecifica)
    End Sub

    Friend Sub LlenarComboBoxResponsableTiposConIDResponsableTipo(ByRef context As CSBomberosContext, ByRef control As ComboBox, ByVal agregarItemTodos As Boolean, ByVal agregarItemNoEspecifica As Boolean)
        control.ValueMember = "IDResponsableTipo"

        LlenarComboBoxResponsables(context, control, agregarItemTodos, agregarItemNoEspecifica)
    End Sub

End Module
