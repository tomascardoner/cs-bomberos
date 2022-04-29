Friend Class FillAndRefreshLists
    Implements IDisposable

#Region "Declarations..."

    Private mdbContext As CSBomberosContext

    Friend Class AreaNombresClass
        Public Property IDArea As Short
        Public Property IDCuartel As Byte
        Public Property Codigo As String
        Public Property Nombre As String
        Public Property CuartelNombre As String
        Public Property NombreYCuartel As String
        Public Property EsActivo As Boolean
    End Class

    Public Sub New()
        mdbContext = New CSBomberosContext(True)
    End Sub

    Protected Overrides Sub Finalize()
        mdbContext.Dispose()
        MyBase.Finalize()
    End Sub

#End Region

#Region "Personas"

    Friend Sub Persona(ByRef ComboBoxControl As ComboBox, ByVal MostrarInactivos As Boolean, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean, ByVal AgregarItem_Otra As Boolean)
        Dim listItems As List(Of Persona)

        ComboBoxControl.ValueMember = "IDPersona"
        ComboBoxControl.DisplayMember = "ApellidoNombre"

        If MostrarInactivos Then
            listItems = mdbContext.Persona.OrderBy(Function(p) p.ApellidoNombre).ToList
        Else
            listItems = mdbContext.Persona.Where(Function(p) p.EsActivo).OrderBy(Function(p) p.ApellidoNombre).ToList
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Persona With {
                .IDPersona = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER,
                .ApellidoNombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Otra Then
            Dim Item_Otra As New Persona With {
                .IDPersona = CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER,
                .ApellidoNombre = My.Resources.STRING_ITEM_OTHER_FEMALE
            }
            listItems.Insert(0, Item_Otra)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New Persona With {
                .IDPersona = CardonerSistemas.Constants.FIELD_VALUE_ALL_INTEGER,
                .ApellidoNombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub DocumentoTipo(ByRef ComboBoxControl As ComboBox, ByVal ShowUnspecifiedItem As Boolean)
        ComboBoxControl.ValueMember = "IDDocumentoTipo"
        ComboBoxControl.DisplayMember = "Nombre"

        Dim qryList = From tbl In mdbContext.DocumentoTipo
                      Where tbl.EsActivo
                      Order By tbl.Nombre

        Dim localList = qryList.ToList
        If ShowUnspecifiedItem Then
            Dim UnspecifiedItem As New DocumentoTipo With {
                .IDDocumentoTipo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED,
                .VerificaModulo11 = False
            }
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
            Dim UnspecifiedItem As New Provincia With {
                .IDProvincia = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
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
            Dim UnspecifiedItem As New Localidad With {
                .IDLocalidad = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            localList.Insert(0, UnspecifiedItem)
        End If

        ComboBoxControl.DataSource = localList
    End Sub

    Friend Shared Sub Genero(ByRef ComboBoxControl As ComboBox, ByVal ShowUnspecifiedItem As Boolean)
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

    Friend Shared Sub GrupoSanguineo(ByRef ComboBoxControl As ComboBox, ByVal ShowUnspecifiedItem As Boolean)
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

    Friend Shared Sub FactorRH(ByRef ComboBoxControl As ComboBox, ByVal ShowUnspecifiedItem As Boolean)
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

    Friend Sub NivelEstudio(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of NivelEstudio)

        ComboBoxControl.ValueMember = "IDNivelEstudio"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.NivelEstudio.Where(Function(ne) ne.EsActivo).OrderBy(Function(ne) ne.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New NivelEstudio With {
                .IDNivelEstudio = 0,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If
        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New NivelEstudio With {
                .IDNivelEstudio = 0,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub EstadoCivil(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of EstadoCivil)

        ComboBoxControl.ValueMember = "IDEstadoCivil"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.EstadoCivil.Where(Function(c) c.EsActivo).OrderBy(Function(c) c.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New EstadoCivil With {
                .IDEstadoCivil = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New EstadoCivil With {
                .IDEstadoCivil = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

#End Region

#Region "Calendario"

    Friend Shared Sub DiaSemana(ByRef ComboBoxControl As ComboBox, ByVal MostrarNombreDelDia As Boolean, ByVal NombreEnIdiomaDelSistema As Boolean, ByVal PrimerLetraEnMayusculas As Boolean, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        ComboBoxControl.Items.Clear()
        If MostrarNombreDelDia Then
            If NombreEnIdiomaDelSistema Then
                For DiaNumero As Integer = 1 To 7
                    If PrimerLetraEnMayusculas Then
                        ComboBoxControl.Items.Add(WeekdayName(DiaNumero).ElementAt(0).ToString.ToUpper & WeekdayName(DiaNumero).Substring(1).ToLower)
                    Else
                        ComboBoxControl.Items.Add(WeekdayName(DiaNumero))
                    End If
                Next
            Else
                If PrimerLetraEnMayusculas Then
                    ComboBoxControl.Items.AddRange({"Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"})
                Else
                    ComboBoxControl.Items.AddRange({"domingo", "lunes", "martes", "miércoles", "jueves", "viernes", "sábado"})
                End If
            End If
        Else
            ComboBoxControl.Items.AddRange({1, 2, 3, 4, 5, 6, 7})
        End If

        If AgregarItem_Todos Then
            ComboBoxControl.Items.Insert(0, My.Resources.STRING_ITEM_ALL_MALE)
        End If
        If AgregarItem_NoEspecifica Then
            ComboBoxControl.Items.Insert(0, My.Resources.STRING_ITEM_NOT_SPECIFIED)
        End If
    End Sub

    Friend Shared Sub Mes(ByRef ComboBoxControl As ComboBox, ByVal MostrarNombreDelMes As Boolean, ByVal NombreEnIdiomaDelSistema As Boolean, ByVal PrimerLetraEnMayusculas As Boolean, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        ComboBoxControl.Items.Clear()
        If MostrarNombreDelMes Then
            If NombreEnIdiomaDelSistema Then
                For MesNumero As Integer = 1 To 12
                    If PrimerLetraEnMayusculas Then
                        ComboBoxControl.Items.Add(MonthName(MesNumero).ElementAt(0).ToString.ToUpper & MonthName(MesNumero).Substring(1).ToLower)
                    Else
                        ComboBoxControl.Items.Add(MonthName(MesNumero))
                    End If
                Next
            Else
                If PrimerLetraEnMayusculas Then
                    ComboBoxControl.Items.AddRange({"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
                Else
                    ComboBoxControl.Items.AddRange({"enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"})
                End If
            End If
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

    Friend Shared Sub Anio(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim AnioInicioParametro As Integer

        ComboBoxControl.Items.Clear()

        AnioInicioParametro = CS_Parameter_System.GetIntegerAsInteger(Parametros.FILTER_ANIO_INICIAL, 1900)

        For AnioNumero As Integer = Today.Year() To AnioInicioParametro Step -1
            ComboBoxControl.Items.Add(AnioNumero)
        Next

        If AgregarItem_Todos Then
            ComboBoxControl.Items.Insert(0, My.Resources.STRING_ITEM_ALL_MALE)
        End If
        If AgregarItem_NoEspecifica Then
            ComboBoxControl.Items.Insert(0, My.Resources.STRING_ITEM_NOT_SPECIFIED)
        End If
    End Sub

#End Region

    Friend Sub SancionTipo(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of SancionTipo)

        ComboBoxControl.ValueMember = "IDSancionTipo"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.SancionTipo.Where(Function(st) st.EsActivo).OrderBy(Function(st) st.Nombre).ToList

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New SancionTipo With {
                .IDSancionTipo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New SancionTipo With {
                .IDSancionTipo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
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
            Dim Item_NoEspecifica As New Parentesco With {
                .IDParentesco = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New Parentesco With {
                .IDParentesco = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
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
            Dim Item_NoEspecifica As New PersonaBajaMotivo With {
                .IDPersonaBajaMotivo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New PersonaBajaMotivo With {
                .IDPersonaBajaMotivo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub PersonaEstadoActual(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean)
        Dim listItems As List(Of PersonaBajaMotivo)

        ComboBoxControl.ValueMember = "IDPersonaBajaMotivo"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.PersonaBajaMotivo.Where(Function(pbm) pbm.EsActivo).OrderBy(Function(pbm) pbm.Nombre).ToList

        Dim Item_Desconocido As New PersonaBajaMotivo With {
            .IDPersonaBajaMotivo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
            .Nombre = My.Resources.STRING_PERSONA_ESTADO_DESCONOCIDO
        }
        listItems.Insert(0, Item_Desconocido)
        Item_Desconocido = Nothing

        Dim Item_Activo As New PersonaBajaMotivo With {
            .IDPersonaBajaMotivo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
            .Nombre = My.Resources.STRING_PERSONA_ESTADO_ACTIVO
        }
        listItems.Insert(1, Item_Activo)
        Item_Activo = Nothing

        Dim Item_Inactivo As New PersonaBajaMotivo With {
            .IDPersonaBajaMotivo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
            .Nombre = My.Resources.STRING_PERSONA_ESTADO_INACTIVO
        }
        listItems.Insert(2, Item_Inactivo)
        Item_Inactivo = Nothing

        If AgregarItem_Todos Then
            Dim Item_Todos As New PersonaBajaMotivo With {
                .IDPersonaBajaMotivo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Area(ByRef ComboBoxControl As ComboBox, ByVal AgregarItemTodos As Boolean, ByVal AgregarItemNoEspecifica As Boolean, ByVal IDCuartel As Byte)
        Dim listItems As List(Of Area)

        ComboBoxControl.ValueMember = "IDArea"
        ComboBoxControl.DisplayMember = "Nombre"

        If IDCuartel = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = mdbContext.Area.Where(Function(a) a.EsActivo).OrderBy(Function(a) a.Nombre).ToList
        Else
            listItems = mdbContext.Area.Where(Function(a) a.EsActivo AndAlso a.IDCuartel = IDCuartel).OrderBy(Function(a) a.Nombre).ToList
        End If

        If AgregarItemNoEspecifica Then
            Dim Item_NoEspecifica As New Area With {
                .IDArea = Short.MinValue,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItemTodos Then
            Dim Item_Todos As New Area With {
                .IDArea = 0,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub AreaEnInventario(ByRef ComboBoxControl As ComboBox, ByVal AgregarItemTodos As Boolean, ByVal AgregarItemNoEspecifica As Boolean, ByVal IDCuartel As Byte)
        Dim listItems As List(Of Area)

        ComboBoxControl.ValueMember = "IDArea"
        ComboBoxControl.DisplayMember = "Nombre"

        If IDCuartel = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = mdbContext.Area.Where(Function(a) a.EsActivo AndAlso a.MostrarEnInventario).OrderBy(Function(a) a.Nombre).ToList
        Else
            listItems = mdbContext.Area.Where(Function(a) a.EsActivo AndAlso a.IDCuartel = IDCuartel AndAlso a.MostrarEnInventario).OrderBy(Function(a) a.Nombre).ToList
        End If

        If AgregarItemNoEspecifica Then
            Dim Item_NoEspecifica As New Area With {
                .IDArea = Short.MinValue,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItemTodos Then
            Dim Item_Todos As New Area With {
                .IDArea = 0,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub AreaEnCompras(ByRef ComboBoxControl As ComboBox, ByVal AgregarItemTodos As Boolean, ByVal AgregarItemNoEspecifica As Boolean, ByVal IDCuartel As Byte)
        Dim listItems As List(Of Area)

        ComboBoxControl.ValueMember = "IDArea"
        ComboBoxControl.DisplayMember = "Nombre"

        If IDCuartel = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = mdbContext.Area.Where(Function(a) a.EsActivo AndAlso a.MostrarEnCompras).OrderBy(Function(a) a.Nombre).ToList
        Else
            listItems = mdbContext.Area.Where(Function(a) a.EsActivo AndAlso a.IDCuartel = IDCuartel AndAlso a.MostrarEnCompras).OrderBy(Function(a) a.Nombre).ToList
        End If

        If AgregarItemNoEspecifica Then
            Dim Item_NoEspecifica As New Area With {
                .IDArea = Short.MinValue,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItemTodos Then
            Dim Item_Todos As New Area With {
                .IDArea = 0,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub AreaYCuartel(ByRef ComboBoxControl As ComboBox, ByVal AgregarItemTodos As Boolean, ByVal AgregarItemNoEspecifica As Boolean)
        Dim listItems As List(Of AreaNombresClass)

        ComboBoxControl.ValueMember = "IDArea"
        ComboBoxControl.DisplayMember = "NombreYCuartel"

        listItems = (From a In mdbContext.Area
                     Join c In mdbContext.Cuartel On a.IDCuartel Equals c.IDCuartel
                     Where a.EsActivo AndAlso c.EsActivo
                     Order By a.Nombre, c.Nombre
                     Select New AreaNombresClass With {.IDArea = a.IDArea, .IDCuartel = a.IDCuartel, .Codigo = a.Codigo, .Nombre = a.Nombre, .CuartelNombre = c.Nombre, .NombreYCuartel = a.Nombre + " (" + c.Nombre + ")", .EsActivo = a.EsActivo}).ToList()

        If AgregarItemNoEspecifica Then
            Dim Item_NoEspecifica As New AreaNombresClass With {
                .IDArea = Short.MinValue,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItemTodos Then
            Dim Item_Todos As New AreaNombresClass With {
                .IDArea = 0,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Caja(ByRef ComboBoxControl As ComboBox, ByVal AgregarItemTodos As Boolean, ByVal AgregarItemNoEspecifica As Boolean)
        Dim listItems As List(Of Caja)

        ComboBoxControl.ValueMember = "IDCaja"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.Caja.Where(Function(a) a.EsActivo).OrderBy(Function(a) a.Nombre).ToList

        If AgregarItemNoEspecifica Then
            Dim Item_NoEspecifica As New Caja With {
                .IDCaja = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItemTodos Then
            Dim Item_Todos As New Caja With {
                .IDCaja = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Ubicacion(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean, Optional ByVal IDCuartel As Byte = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
        Dim listItems As List(Of Ubicacion)

        ComboBoxControl.ValueMember = "IDUbicacion"
        ComboBoxControl.DisplayMember = "Nombre"

        If IDCuartel = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = mdbContext.Ubicacion.Where(Function(u) u.EsActivo).OrderBy(Function(cl) cl.Nombre).ToList
        Else
            listItems = mdbContext.Ubicacion.Where(Function(u) u.EsActivo And u.IDCuartel = IDCuartel).OrderBy(Function(u) u.Nombre).ToList
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Ubicacion With {
                .IDUbicacion = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New Ubicacion With {
                .IDUbicacion = 0,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            }
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
            Dim Item_NoEspecifica As New SubUbicacion With {
                .IDSubUbicacion = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New SubUbicacion With {
                .IDSubUbicacion = CardonerSistemas.Constants.FIELD_VALUE_ALL_SHORT,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            }
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
            Dim Item_NoEspecifica As New Rubro With {
                .IDRubro = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New Rubro With {
                .IDRubro = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            }
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
            Dim Item_NoEspecifica As New SubRubro With {
                .IDSubRubro = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New SubRubro With {
                .IDSubRubro = CardonerSistemas.Constants.FIELD_VALUE_ALL_SHORT,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Unidad(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean, Optional ByVal IDCuartel As Byte = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
        Dim listItems As List(Of Unidad)

        ComboBoxControl.ValueMember = "IDUnidad"
        ComboBoxControl.DisplayMember = "NumeroMarcaModelo"

        If IDCuartel = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = mdbContext.Unidad.Where(Function(a) a.EsActivo).OrderBy(Function(a) a.Numero).ToList
        Else
            listItems = mdbContext.Unidad.Where(Function(a) a.EsActivo And a.IDCuartel = IDCuartel).OrderBy(Function(a) a.Numero).ToList
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Unidad With {
                .IDUnidad = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT,
                .NumeroMarcaModelo = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New Unidad With {
                .IDUnidad = CardonerSistemas.Constants.FIELD_VALUE_ALL_SHORT,
                .NumeroMarcaModelo = My.Resources.STRING_ITEM_ALL_MALE
            }
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
            Dim Item_NoEspecifica As New ModoAdquisicion With {
                .IDModoAdquisicion = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New ModoAdquisicion With {
                .IDModoAdquisicion = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
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
            Dim Item_NoEspecifica As New Elemento With {
                .IDElemento = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New Elemento With {
                .IDElemento = CardonerSistemas.Constants.FIELD_VALUE_ALL_INTEGER,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

#End Region

#Region "Unidades"

    Friend Sub UnidadTipo(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of UnidadTipo)

        ComboBoxControl.ValueMember = "IDUnidadTipo"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.UnidadTipo.Where(Function(at) at.EsActivo).OrderBy(Function(at) at.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New UnidadTipo With {
                .IDUnidadTipo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New UnidadTipo With {
                .IDUnidadTipo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
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
            Dim Item_Todos As New UnidadUso With {
                .IDUnidadUso = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New UnidadUso With {
                .IDUnidadUso = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
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
            Dim Item_NoEspecifica As New UnidadBajaMotivo With {
                .IDUnidadBajaMotivo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If AgregarItem_Todos Then
            Dim Item_Todos As New UnidadBajaMotivo With {
                .IDUnidadBajaMotivo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
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
            Dim Item_Todos As New CombustibleTipo With {
                .IDCombustibleTipo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New CombustibleTipo With {
                .IDCombustibleTipo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

#End Region

#Region "Usuarios"

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
            Dim Item_Todos As New UsuarioGrupo With {
                .IDUsuarioGrupo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New UsuarioGrupo With {
                .IDUsuarioGrupo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

#End Region

#Region "Personas"

    Friend Sub Cargo(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Cargo)

        ComboBoxControl.ValueMember = "IDCargo"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.Cargo.Where(Function(c) c.EsActivo).OrderBy(Function(c) c.Orden).ThenBy(Function(c) c.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New Cargo With {
                .IDCargo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Cargo With {
                .IDCargo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub CargoJerarquia(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean, Optional ByVal IDCargo As Byte = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
        Dim listItems As List(Of CargoJerarquia)

        ComboBoxControl.ValueMember = "IDJerarquia"
        ComboBoxControl.DisplayMember = "Nombre"

        If IDCargo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = mdbContext.CargoJerarquia.Where(Function(cj) cj.EsActivo).OrderBy(Function(cj) cj.Cargo.Orden).ThenBy(Function(cj) cj.Orden).ThenBy(Function(cj) cj.Nombre).ToList
        Else
            listItems = mdbContext.CargoJerarquia.Where(Function(cj) cj.EsActivo And cj.IDCargo = IDCargo).OrderBy(Function(cj) cj.Orden).ThenBy(Function(cj) cj.Nombre).ToList
        End If

        If AgregarItem_Todos Then
            Dim Item_Todos As New CargoJerarquia With {
                .IDCargo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New CargoJerarquia With {
                .IDCargo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

#End Region

#Region "Vehículos"

    Friend Sub VehiculoTipo(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of VehiculoTipo)

        ComboBoxControl.ValueMember = "IDVehiculoTipo"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.VehiculoTipo.Where(Function(vt) vt.EsActivo).OrderBy(Function(vt) vt.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New VehiculoTipo With {
                .IDVehiculoTipo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New VehiculoTipo With {
                .IDVehiculoTipo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub VehiculoMarca(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of VehiculoMarca)

        ComboBoxControl.ValueMember = "IDVehiculoMarca"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.VehiculoMarca.Where(Function(vm) vm.EsActivo).OrderBy(Function(vm) vm.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New VehiculoMarca With {
                .IDVehiculoMarca = CardonerSistemas.Constants.FIELD_VALUE_ALL_SHORT,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New VehiculoMarca With {
                .IDVehiculoMarca = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub VehiculoCompaniaSeguro(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of VehiculoCompaniaSeguro)

        ComboBoxControl.ValueMember = "IDVehiculoCompaniaSeguro"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.VehiculoCompaniaSeguro.Where(Function(vcs) vcs.EsActivo).OrderBy(Function(vcs) vcs.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New VehiculoCompaniaSeguro With {
                .IDVehiculoCompaniaSeguro = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New VehiculoCompaniaSeguro With {
                .IDVehiculoCompaniaSeguro = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

#End Region

    Friend Sub VacunaTipo(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of VacunaTipo)

        ComboBoxControl.ValueMember = "IDVacunaTipo"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.VacunaTipo.Where(Function(vcs) vcs.EsActivo).OrderBy(Function(vcs) vcs.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New VacunaTipo With {
                .IDVacunaTipo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New VacunaTipo With {
                .IDVacunaTipo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
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
            Dim Item_Todos As New LicenciaCausa With {
                .IDLicenciaCausa = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New LicenciaCausa With {
                .IDLicenciaCausa = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
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
            Dim Item_Todos As New LicenciaConducirCategoria With {
                .IDLicenciaConducirCategoria = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New LicenciaConducirCategoria With {
                .IDLicenciaConducirCategoria = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
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
            Dim Item_Todos As New Curso With {
                .IDCurso = CardonerSistemas.Constants.FIELD_VALUE_ALL_SHORT,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Curso With {
                .IDCurso = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
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
            Dim Item_Todos As New CapacitacionNivel With {
                .IDCapacitacionNivel = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New CapacitacionNivel With {
                .IDCapacitacionNivel = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
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
            Dim Item_Todos As New CapacitacionTipo With {
                .IDCapacitacionTipo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New CapacitacionTipo With {
                .IDCapacitacionTipo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
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

    Public Sub Dispose() Implements IDisposable.Dispose
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        GC.SuppressFinalize(Me)
    End Sub

End Class