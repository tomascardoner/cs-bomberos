Partial Public Class Persona
    Private Const RutaPrefijo As String = "RUTA "
    Private Const RutaLeyendaKilometro As String = " Km. "

    Private Const CallePrefijo As String = "CALLE "
    Private Const CalleLeyendaNumero As String = " Nº "

    Private Const PisoPrefijo As String = " P."
    Private Const PisoSufijo As String = "º"

    Private Const DepartamentoPrefijo As String = " Dto. """
    Private Const DepartamentoSufijo As String = """"

    Private Const Calles2Separador As String = " esq. "

    Private Const Calles3PrimerSeparador As String = " entre "
    Private Const Calles3SegundoSeparador As String = " y "

    Public ReadOnly Property DomicilioParticularCalleCompleto() As String
        Get
            Dim DomicilioCompleto As String

            DomicilioCompleto = DomicilioParticularCalle1
            If Not DomicilioParticularCalle1 Is Nothing Then
                If Not DomicilioParticularNumero Is Nothing Then
                    If DomicilioParticularNumero.TrimStart.ToUpper.StartsWith(RutaPrefijo) Then
                        DomicilioCompleto &= RutaLeyendaKilometro & DomicilioParticularNumero
                    ElseIf DomicilioParticularNumero.TrimStart.ToUpper.StartsWith(CallePrefijo) Then
                        DomicilioCompleto &= CalleLeyendaNumero & DomicilioParticularNumero
                    Else
                        DomicilioCompleto &= " " & DomicilioParticularNumero
                    End If
                End If

                If Not DomicilioParticularPiso Is Nothing Then
                    If IsNumeric(DomicilioParticularPiso) Then
                        DomicilioCompleto &= PisoPrefijo & DomicilioParticularPiso & PisoSufijo
                    Else
                        DomicilioCompleto &= " " & DomicilioParticularPiso
                    End If
                End If

                If Not DomicilioParticularDepartamento Is Nothing Then
                    DomicilioCompleto &= DepartamentoPrefijo & DomicilioParticularDepartamento & DepartamentoSufijo
                End If

                If Not DomicilioParticularCalle2 Is Nothing Then
                    If Not DomicilioParticularCalle3 Is Nothing Then
                        DomicilioCompleto &= Calles3PrimerSeparador & DomicilioParticularCalle2 & Calles3SegundoSeparador & DomicilioParticularCalle3
                    Else
                        DomicilioCompleto &= Calles2Separador & DomicilioParticularCalle2
                    End If
                End If
            End If

            Return DomicilioCompleto
        End Get
    End Property

    Public ReadOnly Property LicenciaConducirCategoriasList As List(Of LicenciaConducirCategoria)
        Get
            Using dbc As New CSBomberosContext(True)
                Dim listPersonaLicenciaConducirCategorias As List(Of LicenciaConducirCategoria)

                listPersonaLicenciaConducirCategorias = (From plcc In PersonaLicenciaConducirCategorias
                                                         Join lcc In dbc.LicenciaConducirCategoria On plcc.IDLicenciaConducirCategoria Equals lcc.IDLicenciaConducirCategoria
                                                         Order By lcc.Codigo
                                                         Select lcc).ToList

                Return listPersonaLicenciaConducirCategorias
            End Using
        End Get
    End Property

    Public ReadOnly Property LicenciaConducirCategoriasDisplay As String
        Get
            Using dbc As New CSBomberosContext(True)
                Dim PersonaLicenciaConducirCategoriasCodigos As List(Of String)

                PersonaLicenciaConducirCategoriasCodigos = (From plcc In PersonaLicenciaConducirCategorias
                                                            Join lcc In dbc.LicenciaConducirCategoria On plcc.IDLicenciaConducirCategoria Equals lcc.IDLicenciaConducirCategoria
                                                            Order By lcc.Codigo
                                                            Select lcc.Codigo).ToList

                Return String.Join(", ", PersonaLicenciaConducirCategoriasCodigos)
            End Using
        End Get
    End Property
End Class