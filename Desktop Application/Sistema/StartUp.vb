Module StartUp

    ' Config files
    Friend pAppearanceConfig As New AppearanceConfig
    Friend pDatabaseConfig As DatabaseConfig
    Friend pEmailConfig As EmailConfig
    Friend pGeneralConfig As GeneralConfig

    ' Database stuff
    Friend pDatabase As CardonerSistemas.Database.Ado.SQLServer
    Friend pFillAndRefreshLists As FillAndRefreshLists

    Friend pDebugMode As Boolean
    Friend pFormMDIMain As formMDIMain
    Friend pPermisos As List(Of UsuarioGrupoPermiso)
    Friend pPermisosReportes As List(Of Reporte)
    Friend pParametros As List(Of Parametro)
    Friend pUsuario As Usuario
    Friend pUsuarioParametros As List(Of UsuarioParametro)
    Friend pLicensedTo As String

    <STAThread()>
    Friend Sub Main()
        Dim StartupTime As Date

        Cursor.Current = Cursors.AppStarting

        My.Application.Log.WriteEntry("La Aplicación se está iniciando.", TraceEventType.Information)

        ' Cargo los archivos de configuración de la aplicación
        If Not Configuration.LoadFiles() Then
            TerminateApplication()
            Return
        End If

        ' Register Syncfusion License
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(CardonerSistemas.ConstantsSyncfusion.LicenseKey)

        ' Realizo la inicialización de la Aplicación
        If pAppearanceConfig.EnableVisualStyles Then
            Application.EnableVisualStyles()
        End If

        ' Muestro el SplashScreen y cambio el puntero del mouse para indicar que la aplicación está iniciando.
        formSplashScreen.Show()
        formSplashScreen.Cursor = Cursors.AppStarting
        formSplashScreen.LabelStatus.Text = "Obteniendo los parámetros de conexión a la Base de datos..."
        Application.DoEvents()

        ' Obtengo el Connection String para las conexiones de ADO .NET
        pDatabase = New CardonerSistemas.Database.Ado.SqlServer()
        If Not pDatabase.SetProperties(pDatabaseConfig.Datasource, pDatabaseConfig.Database, pDatabaseConfig.UserId, pDatabaseConfig.Password, pDatabaseConfig.ConnectTimeout, pDatabaseConfig.ConnectRetryCount, pDatabaseConfig.ConnectRetryInterval) Then
            TerminateApplication()
            Return
        End If
        If Not pDatabase.PasswordUnencrypt() Then
            TerminateApplication()
            Return
        End If
        pDatabase.CreateConnectionString()

        ' Verifico que se pueda establecer la conexión a la base de datos
        Dim newLoginData As Boolean = False
        If Not pDatabase.Connect(pDatabaseConfig, newLoginData) Then
            TerminateApplication()
            Return
        End If
        If newLoginData Then
            Configuration.SaveFileDatabase()
        End If

        ' Obtengo el Connection String para las conexiones de Entity Framework
        CSBomberosContext.ConnectionString = CardonerSistemas.Database.EntityFramework.CreateConnectionString(pDatabaseConfig.Provider, pDatabase.ConnectionString, "Database.CSBomberos")

        ' Cargos los Parámetros desde la Base de datos
        formSplashScreen.LabelStatus.Text = "Cargando los parámetros desde la Base de datos..."
        Application.DoEvents()
        If Not Parametros.LoadParameters() Then
            formSplashScreen.Close()
            formSplashScreen.Dispose()
            TerminateApplication()
            Return
        End If

        ' Verifico que la Base de Datos corresponda a esta Aplicación a través del GUID guardado en los Parámetros
        If CS_Parameter_System.GetString(Parametros.APPLICATION_DATABASE_GUID) <> Constantes.ApplicationDatabaseGuid Then
            MsgBox("La Base de Datos especificada no corresponde a esta aplicación.", MsgBoxStyle.Critical, My.Application.Info.Title)
            formSplashScreen.Close()
            formSplashScreen.Dispose()
            TerminateApplication()
            Return
        End If

        ' Verifico que la versión de la Base de Datos se igual a la de esta versión de la Aplicación
        Select Case CS_Parameter_System.GetIntegerAsInteger(Parametros.APPLICATION_DATABASE_VERSION)
            Case Is < Constantes.ApplicationDatabaseVersion
                MsgBox("La versión de la Base de Datos es anterior a la versión de la Aplicación.", MsgBoxStyle.Critical, My.Application.Info.Title)
                formSplashScreen.Close()
                formSplashScreen.Dispose()
                TerminateApplication()
                Return
            Case Is > Constantes.ApplicationDatabaseVersion
                MsgBox("La versión de la Aplicación está desactualizada.", MsgBoxStyle.Critical, My.Application.Info.Title)
                formSplashScreen.Close()
                formSplashScreen.Dispose()
                TerminateApplication()
                Return
        End Select

        ' Muestro el Nombre de la Compañía a la que está licenciada la Aplicación
        If Not CardonerSistemas.Encrypt.StringCipher.Decrypt(CS_Parameter_System.GetString(Parametros.LICENSE_COMPANY_NAME, "EMPTY"), Constantes.ApplicationLicensePassword, pLicensedTo) Then
            MsgBox("La Licencia especificada es incorrecta.", MsgBoxStyle.Critical, My.Application.Info.Title)
            formSplashScreen.Close()
            formSplashScreen.Dispose()
            TerminateApplication()
            Return
        End If
        formSplashScreen.LabelLicensedTo.Text = pLicensedTo
        Application.DoEvents()

        ' Preparo instancia de clase para llenar los ComboBox
        pFillAndRefreshLists = New FillAndRefreshLists

        ' Tomo el tiempo de inicio para controlar los segundos mínimos que se debe mostrar el Splash Screen
        StartupTime = Now

        ' Muestro el form MDI principal
        pFormMDIMain = New formMDIMain()
        pFormMDIMain.Show()

        formSplashScreen.Focus()
        formSplashScreen.LabelStatus.Text = "Todo completado."
        Application.DoEvents()

        ' Espero el tiempo mínimo para mostrar el Splash Screen y después lo cierro
        If Not CS_Instance.IsRunningUnderIDE Then
            Do While Now.Subtract(StartupTime).Seconds < pAppearanceConfig.MinimumSplashScreenDisplaySeconds
                Application.DoEvents()
            Loop
        End If
        formSplashScreen.Close()
        formSplashScreen.Dispose()

        If CS_Instance.IsRunningUnderIDE Then
            ' Como se está ejecutando dentro del IDE de Visual Studio, en lugar de pedir Usuario y contraseña, asumo que es el Administrador
            Using dbcontext As New CSBomberosContext(True)
                pUsuario = dbcontext.Usuario.Find(1)
                Appearance.UserLoggedIn()
            End Using
        Else
            If formLogin.ShowDialog(pFormMDIMain) = DialogResult.Cancel Then
                Application.Exit()
                My.Application.Log.WriteEntry("La Aplicación ha finalizado porque el Usuario no ha iniciado sesión.", TraceEventType.Warning)
                Return
            End If
            formLogin.Close()
            formLogin.Dispose()
        End If

        pFormMDIMain.Cursor = Cursors.Default
        pFormMDIMain.Enabled = True

        Cursor.Current = Cursors.Default

        ' Inicio el loop sobre el form MDI principal
        My.Application.Log.WriteEntry("La Aplicación se ha iniciado correctamente.", TraceEventType.Information)
        Application.Run(pFormMDIMain)
    End Sub

    Friend Sub TerminateApplication()
        If pFormMDIMain IsNot Nothing Then
            CardonerSistemas.Forms.MdiChildCloseAll(CType(pFormMDIMain, Form))
            CardonerSistemas.Forms.CloseAll("FormMDIMain")
        End If
        If pDatabase IsNot Nothing Then
            pDatabase.Close()
            pDatabase = Nothing
        End If

        pAppearanceConfig = Nothing
        pDatabaseConfig = Nothing
        pEmailConfig = Nothing
        pGeneralConfig = Nothing

        pDatabase = Nothing
        pFillAndRefreshLists = Nothing
        pPermisos = Nothing
        pPermisosReportes = Nothing
        pParametros = Nothing
        pLicensedTo = Nothing
        pUsuario = Nothing
    End Sub

End Module
