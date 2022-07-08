Public Class formPersonaIdentificacionPin

#Region "Declarations"

    Private mPersona As Persona

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByRef parentForm As Form, ByRef persona As Persona)
        mPersona = persona

        SetDataFromObjectToControls()

        Me.ShowDialog(parentForm)
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        If mPersona.IdentificacionPin.HasValue Then
            maskedtextboxIdentificacionPin.Text = CS_ValueTranslation.FromObjectShortToControlTextBox(mPersona.IdentificacionPin)
            maskedtextboxIdentificacionPinConfirma.Text = CS_ValueTranslation.FromObjectShortToControlTextBox(mPersona.IdentificacionPin.Value)
        End If
    End Sub

    Friend Sub SetDataFromControlsToObject()
        If maskedtextboxIdentificacionPin.TextLength > 0 Then
            mPersona.IdentificacionPin = CS_ValueTranslation.FromControlTextBoxToObjectShort(maskedtextboxIdentificacionPin.Text)
        Else
            mPersona.IdentificacionPin = Nothing
        End If
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                buttonGuardar.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                buttonCancelar.PerformClick()
        End Select
    End Sub

    Private Sub MaskedTextBoxes_GotFocus(sender As Object, e As EventArgs) Handles maskedtextboxIdentificacionPin.GotFocus, maskedtextboxIdentificacionPinConfirma.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
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

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        If maskedtextboxIdentificacionPin.Text.Length > 0 Then
            If maskedtextboxIdentificacionPin.Text.Length < 4 Then
                MessageBox.Show("Debe especificar los 4 dígitos del PIN.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                maskedtextboxIdentificacionPin.Focus()
                Return False
            End If
            If maskedtextboxIdentificacionPinConfirma.Text.Length < 4 Then
                MessageBox.Show("Debe especificar los 4 dígitos de la confirmación del PIN.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                maskedtextboxIdentificacionPinConfirma.Focus()
                Return False
            End If
        End If
        If maskedtextboxIdentificacionPin.Text <> maskedtextboxIdentificacionPinConfirma.Text Then
            MessageBox.Show("El PIN y la confirmación del PIN no coinciden.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            maskedtextboxIdentificacionPin.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class