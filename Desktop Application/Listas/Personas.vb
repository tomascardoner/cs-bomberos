Module ListasPersonas

    Friend Class PersonaSeleccionada
        Friend IDPersona As Integer
        Friend ApellidoNombre As String
    End Class

    Friend Function SeleccionarPersona(ByRef parent As Form) As PersonaSeleccionada
        Dim fps As New formPersonasSeleccionar(False, 0, False)
        Dim personaSeleccionada As PersonaSeleccionada

        If fps.ShowDialog(parent) = Windows.Forms.DialogResult.OK Then
            Dim rowSelected As PersonasObtenerConEstado_Result

            rowSelected = CType(fps.datagridviewMain.SelectedRows(0).DataBoundItem, PersonasObtenerConEstado_Result)
            personaSeleccionada = New PersonaSeleccionada() With {.IDPersona = rowSelected.IDPersona, .ApellidoNombre = rowSelected.ApellidoNombre}
        End If
        fps.Dispose()

        Return personaSeleccionada
    End Function

    Friend Function SeleccionarPersona(ByRef parent As Form, ByRef control As TextBox) As Boolean
        Dim personaSeleccionada As PersonaSeleccionada

        personaSeleccionada = SeleccionarPersona(parent)
        If personaSeleccionada IsNot Nothing Then
            control.Tag = personaSeleccionada.IDPersona
            control.Text = personaSeleccionada.ApellidoNombre
            Return True
        Else
            Return False
        End If
    End Function

    Friend Function SeleccionarPersonaBorrar(ByRef control As TextBox) As Boolean
        If control.Tag IsNot Nothing Then
            control.Tag = Nothing
            control.Text = String.Empty
            Return True
        Else
            Return False
        End If
    End Function

End Module
