Public Class formSiniestroAsistenciaPresencial

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mSiniestroActual As Siniestro

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByRef siniestroActual As Siniestro)
        mSiniestroActual = siniestroActual

        InitializeFormAndControls()

        CardonerSistemas.Forms.MdiChildPositionAndSizeToFit(CType(pFormMDIMain, Form), CType(Me, Form))
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If

        Me.Show()
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

End Class