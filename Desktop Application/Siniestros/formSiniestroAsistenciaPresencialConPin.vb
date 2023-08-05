Public Class formSiniestroAsistenciaPresencialConPin

#Region "Declarations"

    Private mdbContext As CSBomberosContext
    Private mSiniestro As Siniestro
    Private mPersona As Persona

    Private mIdTipoSalidaAnticipada As Byte
    Private mTipoSalidaAnticipadaNombre As String
    Private mIdTipoPresente As Byte
    Private mTipoPresenteNombre As String

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByRef parentForm As Form, ByRef dbContext As CSBomberosContext, ByRef siniestro As Siniestro, idTipoSalidaAnticipada As Byte, TipoSalidaAnticipadaNombre As String, idTipoPresente As Byte, TipoPresenteNombre As String)
        mdbContext = dbContext
        mSiniestro = siniestro
        controlpersonaPersona.dbContext = mdbContext

        mIdTipoSalidaAnticipada = idTipoSalidaAnticipada
        mTipoSalidaAnticipadaNombre = TipoSalidaAnticipadaNombre
        mIdTipoPresente = idTipoPresente
        mTipoPresenteNombre = TipoPresenteNombre

        Me.ShowDialog(parentForm)
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

    Private Sub controlpersonaPersona_TextChanged(sender As Object, e As EventArgs) Handles controlpersonaPersona.TextChanged
        maskedtextboxIdentificacionPin.Focus()
        If controlpersonaPersona.IDPersona.HasValue Then
            mPersona = mdbContext.Persona.Find(controlpersonaPersona.IDPersona.Value)
        End If
    End Sub

    Private Sub MaskedTextBoxes_GotFocus(sender As Object, e As EventArgs) Handles maskedtextboxIdentificacionPin.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
    End Sub

    Private Sub Guardar() Handles buttonGuardar.Click
        Dim mensajeResultado As String

        If Not VerificarDatos() Then
            Return
        End If

        If Siniestros.AsistirPersona(mdbContext, mSiniestro, mIdTipoSalidaAnticipada, mTipoSalidaAnticipadaNombre, mIdTipoPresente, mTipoPresenteNombre, controlpersonaPersona.IDPersona.Value, mensajeResultado) = 2 Then
            Return
        End If

        MessageBox.Show(mensajeResultado, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()
    End Sub

    Private Sub Cancelar() Handles buttonCancelar.Click
        Me.Close()
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        If Not controlpersonaPersona.IDPersona.HasValue Then
            MessageBox.Show("Debe seleccionar una persona.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            controlpersonaPersona.Focus()
            Return False
        End If
        If Not mPersona.IdentificacionPin.HasValue Then
            MessageBox.Show("La persona seleccionada no tiene especificado un PIN.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            controlpersonaPersona.Focus()
            Return False
        End If
        If maskedtextboxIdentificacionPin.Text.Length < 4 Then
            MessageBox.Show("Debe especificar los 4 dígitos del PIN.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            maskedtextboxIdentificacionPin.Focus()
            Return False
        End If
        If CShort(maskedtextboxIdentificacionPin.Text) <> mPersona.IdentificacionPin Then
            MessageBox.Show("El PIN ingresado es incorrecto.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            maskedtextboxIdentificacionPin.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class