Public Class formCambiarContrasena

#Region "Declarations"

    Private context As New CSBomberosContext(True)

    Private intentos As Integer = 0

#End Region

#Region "Form stuff"

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        context.Dispose()
        context = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Return)
                buttonAceptar.PerformClick()
            Case ChrW(Keys.Escape)
                buttonCancelar.PerformClick()
        End Select
    End Sub

    Private Sub TextBoxs_Enter(sender As Object, e As EventArgs) Handles textboxPasswordAnterior.Enter, textboxPasswordNueva.Enter, textboxPasswordConfirma.Enter
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub TextBoxs_Leave(sender As Object, e As EventArgs) Handles textboxPasswordAnterior.Leave, textboxPasswordNueva.Leave, textboxPasswordConfirma.Leave
        Dim textBox As TextBox = CType(sender, TextBox)
        textBox.Text = textBox.Text.Trim()
    End Sub

#End Region

#Region "Main toolbar"

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        ' Verifico la contraseña anterior
        textboxPasswordAnterior.Text = textboxPasswordAnterior.Text.Trim()
        If textboxPasswordAnterior.TextLength = 0 Then
            MessageBox.Show("Debe ingresar la contraseña anterior.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textboxPasswordAnterior.Focus()
            Return
        End If

        ' Verifico la contraseña nueva
        textboxPasswordNueva.Text = textboxPasswordNueva.Text.Trim()
        If textboxPasswordNueva.TextLength = 0 Then
            MessageBox.Show("Debe ingresar la contraseña nueva.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textboxPasswordNueva.Focus()
            Return
        End If
        If CS_Parameter_System.GetBoolean(Parametros.USER_PASSWORD_SECURE_REQUIRED, True) Then
            If textboxPasswordNueva.TextLength < CS_Parameter_System.GetIntegerAsByte(Parametros.USER_PASSWORD_MINIMUM_LENGHT, 8) Then
                MsgBox($"La Contraseña debe contener al menos {CS_Parameter_System.GetIntegerAsByte(Parametros.USER_PASSWORD_MINIMUM_LENGHT, 8)} caracteres.", vbInformation, My.Application.Info.Title)
                textboxPasswordNueva.Focus()
                Exit Sub
            End If
        Else
            If textboxPasswordNueva.TextLength < 4 Then
                MsgBox("La Contraseña debe contener al menos 4 caracteres.", vbInformation, My.Application.Info.Title)
                textboxPasswordNueva.Focus()
                Exit Sub
            End If
        End If

        ' Verifico la confirmación de la contraseña nueva
        textboxPasswordConfirma.Text = textboxPasswordConfirma.Text.Trim()
        If textboxPasswordConfirma.TextLength = 0 Then
            MessageBox.Show("Debe ingresar la confirmación de la nueva contraseña.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textboxPasswordConfirma.Focus()
            Return
        End If
        If String.Compare(textboxPasswordNueva.Text, textboxPasswordConfirma.Text, StringComparison.InvariantCulture) <> 0 Then
            MessageBox.Show("La nueva contraseña es diferente a la confirmación.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textboxPasswordConfirma.Focus()
            Return
        End If

        ' Verifico que la nueva contraseña sea diferente a la anterior
        If String.Compare(textboxPasswordAnterior.Text, textboxPasswordNueva.Text, StringComparison.InvariantCulture) = 0 Then
            MessageBox.Show("La contraseña nueva debe ser diferente a la anterior.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textboxPasswordNueva.Focus()
            Return
        End If

        ' Comparo la contraseña anterior ingresada con la del usuario
        If String.Compare(textboxPasswordAnterior.Text, pUsuario.Password, StringComparison.InvariantCulture) <> 0 Then
            MessageBox.Show("La contraseña anterior ingresada es incorrecta.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            textboxPasswordAnterior.SelectAll()
            textboxPasswordAnterior.Focus()
            Me.Cursor = Cursors.Default
            intentos += 1
            If intentos > 3 Then
                Me.DialogResult = DialogResult.Cancel
            End If
            Return
        End If

        ' Están todos los datos bien así que los guardo
        Try
            context.Usuario.Attach(pUsuario)
            pUsuario.Password = textboxPasswordNueva.Text
            context.SaveChanges()
            MessageBox.Show("Se ha cambiado la contraseña del usuario.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al modificar la contraseña del usuario.")
            Me.Cursor = Cursors.Default
            Return
        End Try

        Me.Cursor = Cursors.Default

        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

#End Region

End Class