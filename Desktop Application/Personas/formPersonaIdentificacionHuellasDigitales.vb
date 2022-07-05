Public Class formPersonaIdentificacionHuellasDigitales

#Region "Declarations"

    Private mPersona As Persona
    Private ReadOnly mDedos(9) As DPFP.Template

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByRef parentForm As Form, ByRef persona As Persona)
        mPersona = persona
        SetDataFromObjectToControls()

        Me.ShowDialog(parentForm)
    End Sub

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        For Each huella As PersonaHuellaDigital In mPersona.HuellasDigitales
            mDedos(huella.IndiceDedo - 1) = New DPFP.Template(New IO.MemoryStream(huella.Template))
            controlHuellas.EnrolledFingerMask = controlHuellas.EnrolledFingerMask Or CardonerSistemas.Fingerprint.GetEnrollmentMaskValue(huella.IndiceDedo)
        Next
    End Sub

    Friend Sub SetDataFromControlsToObject()
        Dim huellasVerificadas(9) As Boolean

        If mPersona.HuellasDigitales.Any() Then
            ' Hay información previa de huellas
            ' Verifico las existentes en la base de datos para borrar o actualizar
            For Each huella As PersonaHuellaDigital In mPersona.HuellasDigitales
                If mDedos(huella.IndiceDedo - 1) Is Nothing Then
                    mPersona.HuellasDigitales.Remove(huella)
                ElseIf Not huella.Template.SequenceEqual(mDedos(huella.IndiceDedo - 1).Bytes()) Then
                    huella.Template = mDedos(huella.IndiceDedo - 1).Bytes()
                End If
                huellasVerificadas(huella.IndiceDedo - 1) = True
            Next
        End If

        ' Verifico las huellas que no están en la base de datos para agregarlas
        For dedo As Byte = 1 To 10
            If mDedos(dedo - 1) IsNot Nothing AndAlso huellasVerificadas(dedo - 1) = False Then
                mPersona.HuellasDigitales.Add(New PersonaHuellaDigital With {.IndiceDedo = dedo, .Template = mDedos(dedo - 1).Bytes()})
            End If
        Next
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

    Sub controlHuellasOnEnroll(ByVal Control As Object, ByVal Finger As Integer, ByVal Template As DPFP.Template, ByRef EventHandlerStatus As DPFP.Gui.EventHandlerStatus) Handles controlHuellas.OnEnroll
        mDedos(Finger - 1) = Template
    End Sub

    Sub controlHuellasOnDelete(ByVal Control As Object, ByVal Finger As Integer, ByRef EventHandlerStatus As DPFP.Gui.EventHandlerStatus) Handles controlHuellas.OnDelete
        mDedos(Finger - 1) = Nothing
    End Sub

    Private Sub Guardar() Handles buttonGuardar.Click
        SetDataFromControlsToObject()

        Me.DialogResult = DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub Cancelar() Handles buttonCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Hide()
    End Sub

#End Region

End Class