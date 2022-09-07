Module ListasPersonas

    Friend Class PersonaSeleccionada
        Friend IDPersona As Integer
        Friend MatriculaNumero As String
        Friend ApellidoNombre As String
    End Class

    Friend Function SeleccionarPersona(ByRef parent As Form, multiseleccion As Boolean, idCuartel As Byte?, mostrarSoloActivos As Boolean) As PersonaSeleccionada
        Dim fps As New formPersonasSeleccionar(multiseleccion, idCuartel, mostrarSoloActivos)
        Dim personaSeleccionada As PersonaSeleccionada

        If fps.ShowDialog(parent) = Windows.Forms.DialogResult.OK Then
            Dim rowSelected As PersonasObtenerConEstado_Result

            rowSelected = CType(fps.datagridviewMain.SelectedRows(0).DataBoundItem, PersonasObtenerConEstado_Result)
            personaSeleccionada = New PersonaSeleccionada() With {.IDPersona = rowSelected.IDPersona, .MatriculaNumero = rowSelected.MatriculaNumero, .ApellidoNombre = rowSelected.ApellidoNombre}
        End If
        fps.Dispose()

        Return personaSeleccionada
    End Function

    Friend Function SeleccionarPersona(ByRef parent As Form, ByRef control As ControlPersona) As Boolean
        Dim personaSeleccionada As PersonaSeleccionada

        personaSeleccionada = SeleccionarPersona(parent, False, control.IDCuartel, control.MostrarSoloEstadoActivo)
        If personaSeleccionada IsNot Nothing Then
            control.IDPersona = personaSeleccionada.IDPersona
            control.SetMatriculaNumero(personaSeleccionada.MatriculaNumero)
            control.ApellidoNombre = personaSeleccionada.ApellidoNombre
            Return True
        Else
            Return False
        End If
    End Function

End Module
