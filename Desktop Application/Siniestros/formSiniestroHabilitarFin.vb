Imports DPFP
Imports DPFP.Gui

Public Class formSiniestroHabilitarFin

#Region "Declaraciones"

    Private Class HuellaDigital
        Friend Property IDPersona As Integer
        Friend Property TemplateInDB As Byte()
        Friend Property Template As DPFP.Template
    End Class

    Private huellasDigitales As List(Of HuellaDigital)
    Friend Persona As Persona

#End Region

#Region "Cosas del form"

    Friend Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetAppearance()

        ' Leo todas las huellas digitales desde la base de datos y convierto los templates
        Using context As New CSBomberosContext(True)
            huellasDigitales = (From p In context.Persona
                                Join phd In context.PersonaHuellaDigital On p.IDPersona Equals phd.IDPersona
                                Where p.EsActivo
                                Select New HuellaDigital With {.IDPersona = p.IDPersona, .TemplateInDB = phd.Template}).ToList()
        End Using
        For Each huellaDigital As HuellaDigital In huellasDigitales
            huellaDigital.Template = New DPFP.Template(New IO.MemoryStream(huellaDigital.TemplateInDB))
        Next
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageSiniestro32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        huellasDigitales = Nothing
    End Sub

#End Region

#Region "Eventos de los componentes"

    Private Sub verificationcontrolHuellas_OnComplete(Control As Object, FeatureSet As FeatureSet, ByRef EventHandlerStatus As EventHandlerStatus) Handles verificationcontrolHuellas.OnComplete
        Dim verifier As New DPFP.Verification.Verification()
        Dim result As New DPFP.Verification.Verification.Result()

        ' Una vez obtenida la huella desde el lector, busco en la base de datos a quien corresponde
        For Each huellaDigital As HuellaDigital In huellasDigitales
            verifier.Verify(FeatureSet, huellaDigital.Template, result)
            If result.Verified Then
                VerificarDatos(huellaDigital.IDPersona)
                Return
            End If
        Next

        ' Por no encontrar coincidencias de huellas
        pictureboxFoto.Image = Nothing
        textboxPersona.Text = String.Empty
    End Sub

    Private Sub Guardar(control As Object, e As EventArgs) Handles buttonGuardar.Click
        If Persona Is Nothing Then
            MessageBox.Show("No hay ninguna Persona identificada.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Me.DialogResult = DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub Cancelar(control As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Hide()
    End Sub

#End Region

#Region "Cosas extra"

    Private Sub VerificarDatos(idPersona As Integer)
        Using context As New CSBomberosContext(True)
            Persona = context.Persona.Find(idPersona)
            pictureboxFoto.Image = CS_ValueTranslation.FromObjectImageToPictureBox(Persona.Foto)
            textboxPersona.Text = Persona.ApellidoNombre
        End Using
    End Sub

#End Region

End Class