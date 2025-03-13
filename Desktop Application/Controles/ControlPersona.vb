Public Class ControlPersona

#Region "Declarations - properties"

    Private _personas As IEnumerable(Of PersonasObtenerPorCuartelYEstado_Result)
    Private _IDPersona As Integer?
    Private _MatriculaNumeroDigitos As Short?
    Private _ApellidoNombre As String
    Private _ReadOnlyText As Boolean
    Private dbContextLocal As Boolean

    Public Property dbContext As CSBomberosContext
    Public Property IDCuartel As Byte?
    Public Property SoloMostrarEstadoActivo As Boolean = True
    Public Property SoloMostrarEnAsistencia As Boolean

    Public Property IDPersona As Integer?
        Get
            Return _IDPersona
        End Get
        Set(value As Integer?)
            _IDPersona = value
            OnTextChanged(New EventArgs)
        End Set
    End Property

    Public Sub SetMatriculaNumero(value As String)
        If value IsNot Nothing Then
            value = value.Trim()
            If value.Length >= Constantes.PersonaMatriculaCantidadDigitos Then
                value = value.Substring(value.Length - Constantes.PersonaMatriculaCantidadDigitos).RemoveNotNumbers()
                If value.Length = Constantes.PersonaMatriculaCantidadDigitos Then
                    MatriculaNumeroDigitos = CShort(value)
                End If
            Else
                MatriculaNumeroDigitos = Nothing
            End If
        Else
            MatriculaNumeroDigitos = Nothing
        End If
    End Sub

    Public Property MatriculaNumeroDigitos As Short?
        Get
            Return _MatriculaNumeroDigitos
        End Get
        Set(value As Short?)
            _MatriculaNumeroDigitos = value
            If value.HasValue Then
                MaskedTextBoxMatriculaNumeroDigitos.Text = value.Value.ToString(New String("0"c, Constantes.PersonaMatriculaCantidadDigitos))
            Else
                MaskedTextBoxMatriculaNumeroDigitos.Text = String.Empty
            End If
        End Set
    End Property

    Public Property ApellidoNombre As String
        Get
            Return _ApellidoNombre
        End Get
        Set(value As String)
            _ApellidoNombre = value
            If value IsNot Nothing Then
                TextBoxApellidoNombre.Text = value
            Else
                TextBoxApellidoNombre.Text = String.Empty
            End If
        End Set
    End Property

    Public Property ReadOnlyText As Boolean
        Get
            Return _ReadOnlyText
        End Get
        Set(value As Boolean)
            _ReadOnlyText = value
            MaskedTextBoxMatriculaNumeroDigitos.ReadOnly = value
            ButtonPersona.Visible = Not value
            ButtonPersonaBorrar.Visible = Not value
        End Set
    End Property

#End Region

#Region "Declarations - methods"

    Public Sub MostrarUnaPersona()
        ComboBoxApellidoNombre.Visible = False
        TableLayoutPanelMain.Controls.Remove(ComboBoxApellidoNombre)
        TableLayoutPanelMain.Controls.Add(TextBoxApellidoNombre, 1, 0)
        TextBoxApellidoNombre.Visible = True
    End Sub

    Public Sub MostrarMultiplesPersonas()
        TextBoxApellidoNombre.Visible = False
        TableLayoutPanelMain.Controls.Remove(TextBoxApellidoNombre)
        TableLayoutPanelMain.Controls.Add(ComboBoxApellidoNombre, 1, 0)
        ComboBoxApellidoNombre.Visible = True
    End Sub

    Public Overrides Sub ResetText()
        MostrarUnaPersona()
        IDPersona = Nothing
        MatriculaNumeroDigitos = Nothing
        ApellidoNombre = Nothing
    End Sub

    Public Sub AsignarValores(persona As PersonasObtenerPorCuartelYEstado_Result)
        If persona Is Nothing Then
            ResetText()
        Else
            AsignarValores(persona.IDPersona, persona.MatriculaNumero, persona.ApellidoNombre)
        End If
    End Sub

    Public Sub AsignarValores(persona As Persona)
        If persona Is Nothing Then
            ResetText()
        Else
            AsignarValores(persona.IDPersona, persona.MatriculaNumero, persona.ApellidoNombre)
        End If
    End Sub

    Public Sub AsignarValores(valorIDPersona As Integer, valorMatriculaNumero As String, valorApellidoNombre As String)
        MostrarUnaPersona()
        IDPersona = valorIDPersona
        SetMatriculaNumero(valorMatriculaNumero)
        ApellidoNombre = valorApellidoNombre
    End Sub

    Public Sub CopiarValores(ByRef origen As ControlPersona)
        MostrarUnaPersona()
        IDPersona = origen.IDPersona
        MatriculaNumeroDigitos = origen.MatriculaNumeroDigitos
        ApellidoNombre = origen.ApellidoNombre
    End Sub

    Public Sub BuscarPersonaPorId(idPersona As Integer?)
        If idPersona.HasValue Then
            CargarListaDePersonas()
            AsignarValores(_personas.FirstOrDefault(Function(p) p.IDPersona = idPersona.Value))
        Else
            ResetText()
        End If
    End Sub

    Public Sub BuscarPersonaPorMatricula(matriculaNumero As String)
        CargarListaDePersonas()
        Dim _personasEncontradas As List(Of PersonasObtenerPorCuartelYEstado_Result)
        _personasEncontradas = _personas.Where(Function(p) p.MatriculaNumero.TrimEnd().EndsWith(matriculaNumero)).ToList()
        Select Case _personasEncontradas.Count
            Case 0
                ResetText()
            Case 1
                AsignarValores(_personasEncontradas.First)
            Case Else
                ComboBoxApellidoNombre.DataSource = _personasEncontradas
                ComboBoxApellidoNombre.SelectedIndex = -1
                _IDPersona = Nothing
                ApellidoNombre = Nothing
                MostrarMultiplesPersonas()
        End Select
    End Sub

#End Region

#Region "Initialization and finish"

    Private Sub ControlPersona_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboBoxApellidoNombre.ValueMember = "IDPersona"
        ComboBoxApellidoNombre.DisplayMember = "ApellidoNombre"
    End Sub

    Private Sub ControlPersona_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        If _personas IsNot Nothing Then
            _personas = Nothing
        End If
        If dbContext IsNot Nothing AndAlso dbContextLocal Then
            dbContext.Dispose()
            dbContext = Nothing
        End If
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub MaskedTextBoxMatriculaNumeroDigitos_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBoxMatriculaNumeroDigitos.GotFocus
        MaskedTextBoxMatriculaNumeroDigitos.SelectAll()
    End Sub

    Private Sub MaskedTextBoxMatriculaNumeroDigitos_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBoxMatriculaNumeroDigitos.LostFocus
        If Not _ReadOnlyText AndAlso MaskedTextBoxMatriculaNumeroDigitos.Text.Trim.Length = 3 Then
            BuscarPersonaPorMatricula(MaskedTextBoxMatriculaNumeroDigitos.Text.Trim())
        End If
    End Sub

    Private Sub MaskedTextBoxMatriculaNumeroDigitos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedTextBoxMatriculaNumeroDigitos.KeyPress
        If Not _ReadOnlyText AndAlso e.KeyChar = ChrW(Keys.Return) Then
            e.Handled = True
            If MaskedTextBoxMatriculaNumeroDigitos.Text.Trim.Length < Constantes.PersonaMatriculaCantidadDigitos Then
                MessageBox.Show($"Se deben especificar {Constantes.PersonaMatriculaCantidadDigitos} dígitos para buscar la matrícula.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                MaskedTextBoxMatriculaNumeroDigitos.Focus()
            Else
                BuscarPersonaPorMatricula(MaskedTextBoxMatriculaNumeroDigitos.Text.Trim())
            End If
        End If
    End Sub

    Private Sub ComboBoxApellidoNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxApellidoNombre.SelectedIndexChanged
        If ComboBoxApellidoNombre.SelectedIndex > -1 Then
            AsignarValores(CType(ComboBoxApellidoNombre.SelectedItem, PersonasObtenerPorCuartelYEstado_Result))
            MostrarMultiplesPersonas()
        End If
    End Sub

    Private Sub ButtonPersona_Click(sender As Object, e As EventArgs) Handles ButtonPersona.Click
        If ListasPersonas.SeleccionarPersona(Me.ParentForm, Me) Then
            MostrarUnaPersona()
        End If
    End Sub

    Private Sub ButtonPersonaBorrar_Click(sender As Object, e As EventArgs) Handles ButtonPersonaBorrar.Click
        ResetText()
    End Sub

#End Region

#Region "Extra sttuff"

    Private Function AbrirDBContext() As Boolean
        Try
            dbContext = New CSBomberosContext(True)
            dbContextLocal = True
            Return True
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al abrir la conexión a la base de datos.")
            Return False
        End Try
    End Function

    Private Function CargarListaDePersonas() As Boolean
        If _personas Is Nothing Then
            If dbContext Is Nothing AndAlso Not AbrirDBContext() Then
                Return False
            End If
            Try
                _personas = dbContext.PersonasObtenerPorCuartelYEstado(IDCuartel, SoloMostrarEstadoActivo).ToList()
                Return True
            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al obtener la lista de Personas de la base de datos.")
                Return False
            End Try
        Else
            Return True
        End If
    End Function

#End Region

End Class
