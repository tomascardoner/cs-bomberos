Public Class formPersonaIdentificacionPin
    Private mPersona As Persona

    Friend Sub LoadAndShow(ByRef parentForm As Form, ByRef persona As Persona)
        mPersona = persona

        SetDataFromObjectToControls()

        Me.ShowDialog(parentForm)
    End Sub

    Friend Sub SetDataFromObjectToControls()
        If mPersona.IdentificacionPin.HasValue Then
            integertextboxIdentificacionPin.IntegerValue = mPersona.IdentificacionPin.Value
            integertextboxIdentificacionPinConfirma.IntegerValue = mPersona.IdentificacionPin.Value
        End If
    End Sub

    Friend Sub SetDataFromControlsToObject()
        If integertextboxIdentificacionPin.TextLength > 0 Then
            mPersona.IdentificacionPin = CShort(integertextboxIdentificacionPin.IntegerValue)
        Else
            mPersona.IdentificacionPin = Nothing
        End If
    End Sub

    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                buttonGuardar.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                buttonCancelar.PerformClick()
        End Select
    End Sub

    Private Sub Guardar() Handles buttonGuardar.Click
        If Not VerificarDatos() Then
            Return
        End If

        SetDataFromControlsToObject()

        Me.DialogResult = DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub Cancelar() Handles buttonCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Hide()
    End Sub

    Private Function VerificarDatos() As Boolean
        If integertextboxIdentificacionPin.TextLength > 0 Then
            If integertextboxIdentificacionPin.TextLength < 4 Then
                MessageBox.Show("Debe especificar los 4 dígitos del PIN.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                integertextboxIdentificacionPin.Focus()
                Return False
            End If
            If integertextboxIdentificacionPinConfirma.TextLength < 4 Then
                MessageBox.Show("Debe especificar los 4 dígitos de la confirmación del PIN.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                integertextboxIdentificacionPinConfirma.Focus()
                Return False
            End If
        End If
        If integertextboxIdentificacionPin.IntegerValue <> integertextboxIdentificacionPinConfirma.IntegerValue Then
            MessageBox.Show("El PIN y la confirmación del PIN no coinciden.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            integertextboxIdentificacionPin.Focus()
            Return False
        End If

        Return True
    End Function
End Class