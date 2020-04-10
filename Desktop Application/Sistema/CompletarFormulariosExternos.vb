Module CompletarFormulariosExternos

#Region "Persona"

    Friend Sub CompletarPersona(ByVal campos As String, ByRef persona As Persona)
        campos = ReemplazarCamposPersona(campos, persona)
        If campos.Length > 0 Then
            RealizarCambioDeVentanaActiva()

            ' Envío los campos
            SendKeys.Send(campos)
        End If
    End Sub

    Private Function ReemplazarCamposPersona(ByVal campos As String, ByRef persona As Persona) As String

        If campos.Length = 0 Then
            Return String.Empty
        End If

        campos = campos.Replace(Constantes.CAMPOS_PERSONA_NUMEROAFILIADO, persona.IOMANumeroAfiliado)
        campos = campos.Replace(Constantes.CAMPOS_PERSONA_GENERO_1CARACTER, persona.Genero)
        If persona.FechaNacimiento.HasValue Then
            campos = campos.Replace(Constantes.CAMPOS_PERSONA_FECHANACIMIENTO_LITTLEENDIAN_SLASH, persona.FechaNacimiento.Value.ToString("dd/MM/yyyy"))
        End If
        If persona.DocumentoNumero.Length > 0 Then
            campos = campos.Replace(Constantes.CAMPOS_PERSONA_NUMERODOCUMENTO, persona.DocumentoNumero)
        End If

        Return campos
    End Function

#End Region

#Region "Persona Familiar"

    Friend Sub CompletarPersonaFamiliar(ByVal campos As String, ByRef personaFamiliar As PersonaFamiliar)
        campos = ReemplazarCamposPersonaFamiliar(campos, personaFamiliar)
        If campos.Length > 0 Then
            RealizarCambioDeVentanaActiva()

            ' Envío los campos
            SendKeys.Send(campos)
        End If
    End Sub

    Private Function ReemplazarCamposPersonaFamiliar(ByVal campos As String, ByRef personaFamiliar As PersonaFamiliar) As String

        If campos.Length = 0 Then
            Return String.Empty
        End If

        campos = campos.Replace(Constantes.CAMPOS_PERSONA_NUMEROAFILIADO, personaFamiliar.IOMANumeroAfiliado)
        campos = campos.Replace(Constantes.CAMPOS_PERSONA_GENERO_1CARACTER, personaFamiliar.Genero)
        If personaFamiliar.FechaNacimiento.HasValue Then
            campos = campos.Replace(Constantes.CAMPOS_PERSONA_FECHANACIMIENTO_LITTLEENDIAN_SLASH, personaFamiliar.FechaNacimiento.Value.ToString("dd/MM/yyyy"))
        End If
        If personaFamiliar.DocumentoNumero.Length > 0 Then
            campos = campos.Replace(Constantes.CAMPOS_PERSONA_NUMERODOCUMENTO, personaFamiliar.DocumentoNumero)
        End If

        Return campos
    End Function

#End Region

#Region "Common"

    Private Sub RealizarCambioDeVentanaActiva()
        SendKeys.Send(CardonerSistemas.ConstantsKeys.ALT & CardonerSistemas.ConstantsKeys.TAB)
        Application.DoEvents()

        ' Wait for activation complete.
        ' This is necessary for certain applications that
        ' delay a time to activate
        Threading.Thread.Sleep(CS_Parameter_System.GetIntegerAsInteger(Parametros.ACTIVEWINDOW_CHANGE_WAIT_MILLISECONDS, 1000))
    End Sub

#End Region

End Module
