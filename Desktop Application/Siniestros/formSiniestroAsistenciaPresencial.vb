Public Class formSiniestroAsistenciaPresencial

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mSiniestroActual As Siniestro

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByRef siniestroActual As Siniestro)
        mSiniestroActual = siniestroActual

        InitializeFormAndControls()

        Me.ShowDialog(ParentForm)
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageSiniestro32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mSiniestroActual = Nothing
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mSiniestroActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub LeerHuellasChanged(sender As Object, e As EventArgs) Handles chechkboxLeerHuellas.CheckedChanged
        If chechkboxLeerHuellas.Checked Then
            chechkboxLeerHuellas.Image = My.Resources.ImageDetener64
            chechkboxLeerHuellas.Text = "Detener lectura de huellas digitales"
        Else
            chechkboxLeerHuellas.Image = My.Resources.ImageIniciar64
            chechkboxLeerHuellas.Text = "Iniciar lectura de huellas digitales"
        End If
    End Sub

    Private Sub buttonAsistirConPin_Click(sender As Object, e As EventArgs) Handles buttonAsistirConPin.Click
        Dim fmapcp = New formSiniestroAsistenciaPresencialConPin()
        fmapcp.LoadAndShow(Me, mSiniestroActual.IDSiniestro)
        fmapcp.Dispose()
    End Sub

#End Region

End Class