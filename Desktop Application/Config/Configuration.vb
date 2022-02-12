Imports System.IO

Module Configuration
    Private Const ConfigSubFolder As String = "Config"

    Private Const AppearanceFileName As String = "Appearance.json"
    Private Const DatabaseFileName As String = "Database.json"
    Private Const EmailFileName As String = "Email.json"
    Private Const GeneralFileName As String = "General.json"

    Friend Function LoadFiles() As Boolean
        Dim ConfigFolder As String

        ConfigFolder = Path.Combine(Application.StartupPath, ConfigSubFolder)

        If Not CardonerSistemas.ConfigurationJson.LoadFile(ConfigFolder, AppearanceFileName, pAppearanceConfig) Then
            Return False
        End If
        If Not CardonerSistemas.ConfigurationJson.LoadFile(ConfigFolder, DatabaseFileName, pDatabaseConfig) Then
            Return False
        End If
        If Not CardonerSistemas.ConfigurationJson.LoadFile(ConfigFolder, EmailFileName, pEmailConfig) Then
            Return False
        End If
        If Not CardonerSistemas.ConfigurationJson.LoadFile(ConfigFolder, GeneralFileName, pGeneralConfig) Then
            Return False
        End If
        pGeneralConfig.ReportsPath = CardonerSistemas.Files.ProcessFolderName(pGeneralConfig.ReportsPath)

        Return True
    End Function

    Friend Function SaveFileDatabase() As Boolean
        Dim ConfigFolder As String

        ConfigFolder = Path.Combine(Application.StartupPath, ConfigSubFolder)

        Return CardonerSistemas.ConfigurationJson.SaveFile(ConfigFolder, DatabaseFileName, StartUp.pDatabaseConfig, True)
    End Function

End Module
