Public Class formOpciones
    Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkboxMostrarAvisosAlarmas.Checked = CS_Parameter_User.UsuarioGetBoolean(Parametros.USUARIO_INICIOSESION_ALARMA_AVISO_MOSTRAR, True).Value
    End Sub

    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                buttonGuardar.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                buttonCancelar.PerformClick()
        End Select
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles buttonGuardar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

End Class