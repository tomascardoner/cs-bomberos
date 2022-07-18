Public Class formSiniestroAsistenciaPresencialConPin

#Region "Declarations"

    Private mdbContext As CSBomberosContext
    Private mSiniestro As Siniestro
    Private mPersona As Persona

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByRef parentForm As Form, ByRef dbContext As CSBomberosContext, ByRef siniestro As Siniestro)
        mdbContext = dbContext
        mSiniestro = siniestro

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

    Private Sub SeleccionarPersona() Handles buttonPersona.Click
        Dim fps As New formPersonasSeleccionar(False)

        If fps.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim PersonaSeleccionada As PersonasObtenerConEstado_Result

            PersonaSeleccionada = CType(fps.datagridviewMain.SelectedRows(0).DataBoundItem, PersonasObtenerConEstado_Result)
            textboxPersona.Tag = PersonaSeleccionada.IDPersona
            textboxPersona.Text = PersonaSeleccionada.ApellidoNombre

            mPersona = mdbContext.Persona.Find(PersonaSeleccionada.IDPersona)

            maskedtextboxIdentificacionPin.Focus()
        End If
        fps.Dispose()
    End Sub

    Private Sub MaskedTextBoxes_GotFocus(sender As Object, e As EventArgs) Handles maskedtextboxIdentificacionPin.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
    End Sub

    Private Sub Guardar() Handles buttonGuardar.Click
        If Not VerificarDatos() Then
            Return
        End If

        If Not GuardarDatos() Then
            Return
        End If

        MessageBox.Show($"Se cargó la asistencia de: {mPersona.ApellidoNombre}.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()
    End Sub

    Private Sub Cancelar() Handles buttonCancelar.Click
        Me.Close()
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        If textboxPersona.Tag Is Nothing Then
            MessageBox.Show("Debe seleccionar una persona.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            buttonPersona.Focus()
            Return False
        End If
        If mSiniestro.SiniestrosAsistencias.Where(Function(sa) sa.IDPersona = mPersona.IDPersona).Any() Then
            MessageBox.Show("La persona seleccionada ya tiene asistencia al siniestro.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            buttonPersona.Focus()
            Return False
        End If
        If Not mPersona.IdentificacionPin.HasValue Then
            MessageBox.Show("La persona seleccionada no tiene especificado un PIN.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            buttonPersona.Focus()
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

    Private Function GuardarDatos() As Boolean
        Dim idSiniestroAsistenciaTipo As Byte

        idSiniestroAsistenciaTipo = CS_Parameter_System.GetIntegerAsByte(Parametros.SINIESTRO_ASISTENCIATIPO_PRESENTE_ID, 0)
        If idSiniestroAsistenciaTipo = 0 Then
            MessageBox.Show("No se puedieron guardar los datos porque no está especificado el ID de asistencia para Presente.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        mSiniestro.SiniestrosAsistencias.Add(New SiniestroAsistencia() With {
                                             .IDPersona = mPersona.IDPersona,
                                             .IDSiniestroAsistenciaTipo = idSiniestroAsistenciaTipo,
                                             .IDAsistenciaMetodo = Constantes.AsistenciaMetodoCodigoNumericoId,
                                             .IDUsuarioCreacion = pUsuario.IDUsuario,
                                             .FechaHoraCreacion = Now(),
                                             .IDUsuarioModificacion = pUsuario.IDUsuario,
                                             .FechaHoraModificacion = Now()})

        Try
            mdbContext.SaveChanges()
            Return True

        Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
            Me.Cursor = Cursors.Default
            Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                    MsgBox("No se pueden agregar la Asistencia porque ya existe.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Case CardonerSistemas.Database.EntityFramework.Errors.PrimaryKeyViolation
                    MsgBox("No se pueden guardar los cambios porque existe una Asistencia al Siniestro duplicada para una Persona.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Case Else
                    CardonerSistemas.ErrorHandler.ProcessError(CType(dbuex, Exception), My.Resources.STRING_ERROR_SAVING_CHANGES)
            End Select
            Return False

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
            Return False
        End Try

    End Function

#End Region

End Class