Public Class FormSplashScreen
    Private Sub SplashScreen_Load() Handles MyBase.Load
        Me.Icon = My.Resources.IconAplicacion
        Me.Text = My.Application.Info.Title
        LabelCompanyName.Text = My.Application.Info.CompanyName
        LabelAppTitle.Text = My.Application.Info.Title
        LabelLicensedTo.Text = ""
        LabelStatus.Text = "Iniciando..."
        LabelCopyright.Text = My.Application.Info.Copyright
    End Sub
End Class
