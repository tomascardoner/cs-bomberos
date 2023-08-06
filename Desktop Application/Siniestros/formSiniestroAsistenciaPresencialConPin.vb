Public Class formSiniestroAsistenciaPresencialConPin

#Region "Cosas del form"

    Friend Sub SetInitData(ByRef context As CSBomberosContext)
        controlpersonaPersona.dbContext = context
    End Sub

#End Region

#Region "Eventos de los componentes"

    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                buttonGuardar.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                buttonCancelar.PerformClick()
        End Select
    End Sub

    Private Sub MaskedTextBoxes_GotFocus(sender As Object, e As EventArgs) Handles maskedtextboxIdentificacionPin.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
    End Sub

    Private Sub Guardar() Handles buttonGuardar.Click
        If Not VerificarDatos() Then
            Return
        End If

        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Cancelar() Handles buttonCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        Dim persona As Persona

        If Not controlpersonaPersona.IDPersona.HasValue Then
            MessageBox.Show("Debe seleccionar una persona.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            controlpersonaPersona.Focus()
            Return False
        End If
        persona = controlpersonaPersona.dbContext.Persona.Find(controlpersonaPersona.IDPersona.Value)
        If Not persona.IdentificacionPin.HasValue Then
            MessageBox.Show("La persona seleccionada no tiene especificado un PIN.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            controlpersonaPersona.Focus()
            Return False
        End If
        If maskedtextboxIdentificacionPin.Text.Length < 4 Then
            MessageBox.Show("Debe especificar los 4 dígitos del PIN.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            maskedtextboxIdentificacionPin.Focus()
            Return False
        End If
        If CShort(maskedtextboxIdentificacionPin.Text) <> persona.IdentificacionPin Then
            MessageBox.Show("El PIN ingresado es incorrecto.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            maskedtextboxIdentificacionPin.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class