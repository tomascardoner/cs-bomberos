Public Class formLogin
    Private mIntentos As Integer
    Private mdbContext As CSBomberosContext

    Private Sub Me_Load() Handles Me.Load
        mdbContext = New CSBomberosContext(True)

        If pAppearanceConfig.ShowLastLoggedInUser AndAlso My.Settings.LastLoggedInUser <> String.Empty Then
            TextBoxNombre.Text = My.Settings.LastLoggedInUser
            LabelPassword.TabIndex = 0
            TextBoxPassword.TabIndex = 1
            LabelNombre.TabIndex = 6
            TextBoxNombre.TabIndex = 7
        End If
    End Sub

    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            buttonAceptar_Click()
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            buttonCancelar_Click()
        End If
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
    End Sub

    Private Sub TextBoxNombre_GotFocus() Handles TextBoxNombre.GotFocus
        TextBoxNombre.SelectAll()
    End Sub

    Private Sub TextBoxPassword_GotFocus() Handles TextBoxPassword.GotFocus
        TextBoxPassword.SelectAll()
    End Sub

    Private Sub ButtonAceptar_Click() Handles ToolStripButtonAceptar.Click
        Dim UsuarioCurrent As Usuario

        TextBoxNombre.Text = TextBoxNombre.Text.Trim()

        If TextBoxNombre.TextLength = 0 Then
            MsgBox("Debe ingresar el Nombre del Usuario.", vbInformation, My.Application.Info.Title)
            TextBoxNombre.Focus()
            Return
        End If
        If TextBoxNombre.TextLength < 4 Then
            MsgBox("El Nombre del Usuario debe contener al menos 4 caracteres.", vbInformation, My.Application.Info.Title)
            TextBoxNombre.Focus()
            Return
        End If
        If TextBoxPassword.TextLength = 0 Then
            MsgBox("Debe ingresar la Contraseña.", vbInformation, My.Application.Info.Title)
            TextBoxPassword.Focus()
            Return
        End If
        If CS_Parameter_System.GetBoolean(Parametros.USER_PASSWORD_SECURE_REQUIRED, True) Then
            If TextBoxPassword.TextLength < CS_Parameter_System.GetIntegerAsByte(Parametros.USER_PASSWORD_MINIMUM_LENGHT, 8) Then
                MsgBox(String.Format("La Contraseña debe contener al menos {0} caracteres.", CS_Parameter_System.GetIntegerAsByte(Parametros.USER_PASSWORD_MINIMUM_LENGHT, 8)), vbInformation, My.Application.Info.Title)
                TextBoxPassword.Focus()
                Return
            End If
        Else
            If TextBoxPassword.TextLength < 4 Then
                MsgBox("La Contraseña debe contener al menos 4 caracteres.", vbInformation, My.Application.Info.Title)
                TextBoxPassword.Focus()
                Return
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        UsuarioCurrent = mdbContext.Usuario.Where(Function(usr) usr.Nombre = TextBoxNombre.Text).FirstOrDefault
        If UsuarioCurrent Is Nothing Then
            My.Application.Log.WriteEntry(String.Format("Se intentó iniciar sesión con el Usuario '{0}', pero es inexistente.", TextBoxNombre.Text.Trim), TraceEventType.Warning)
            MsgBox("El Nombre de Usuario ingresado no existe.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
            TextBoxNombre.SelectAll()
            TextBoxNombre.Focus()
            UsuarioCurrent = Nothing
            Me.Cursor = Cursors.Default
            mIntentos += 1
            If mIntentos > 3 Then
                Me.DialogResult = DialogResult.Cancel
            End If
            Return
        End If
        If String.Compare(TextBoxPassword.Text, UsuarioCurrent.Password, StringComparison.InvariantCulture) <> 0 Then
            My.Application.Log.WriteEntry(String.Format("Se intentó iniciar sesión con el Usuario '{0}', pero la Contraseña es incorrecta.", TextBoxNombre.Text.Trim), TraceEventType.Warning)
            MsgBox("La Contraseña ingresada es incorrecta.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
            TextBoxPassword.SelectAll()
            TextBoxPassword.Focus()
            UsuarioCurrent = Nothing
            Me.Cursor = Cursors.Default
            mIntentos += 1
            If mIntentos > 3 Then
                Me.DialogResult = DialogResult.Cancel
            End If
            Return
        End If

        pUsuario = UsuarioCurrent
        UsuarioCurrent = Nothing

        ' Guardo el Nombre de Usuario para mostrarlo la próxima vez
        My.Settings.LastLoggedInUser = pUsuario.Nombre
        My.Settings.Save()

        Appearance.UserLoggedIn()

        Me.Cursor = Cursors.Default
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub ButtonCancelar_Click() Handles ToolStripButtonCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class