Public Class formMDIMain

#Region "Declarations"

    Private ReadOnly AFIP_TicketAcceso_Homo As String

#End Region

#Region "Form stuff"

    Private Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageAplicacionIcon300)
        Me.Text = My.Application.Info.Title
        labelStatus.Text = $"Se licencia el uso a: {pLicensedTo.ToUpper()}"
        Application.DoEvents()
    End Sub

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cambio el puntero del mouse para indicar que la aplicación está iniciando
        Me.Cursor = Cursors.AppStarting

        SetAppearance()

        ' Deshabilito el Form principal hasta que se cierre el SplashScreen
        Me.Enabled = False

        menuitemAyuda_AcercaDe.Text = "&Acerca de " & My.Application.Info.Title & "..."
    End Sub

    Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not (e.CloseReason = CloseReason.ApplicationExitCall Or e.CloseReason = CloseReason.TaskManagerClosing Or e.CloseReason = CloseReason.WindowsShutDown) Then
            If MsgBox("¿Desea salir de la aplicación?", CType(MsgBoxStyle.Information + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        TerminateApplication()
    End Sub

#End Region

#Region "Menu Archivo"

    Private Sub Opciones() Handles menuitemArchivo_Opciones.Click
        formOpciones.ShowDialog(Me)
    End Sub

    Private Sub UsuarioCerrarSesion() Handles menuitemArchivo_CerrarSesion.Click
        CerrarSesionUsuario()
    End Sub

    Private Sub UsuarioCambiarContrasena() Handles menuitemArchivo_CambiarContrasena.Click
        formCambiarContrasena.ShowDialog(Me)
    End Sub

    Private Sub ApplicacionSalir() Handles menuitemArchivo_Salir.Click
        Me.Close()
    End Sub

#End Region

#Region "Menú Sistema"

    Private Shared Sub CompletarCUILes() Handles menuitemSistema_CompletarCuiles.Click
        If Not Permisos.VerificarPermiso(Permisos.SISTEMA_COMPLETAR_CUIL) Then
            Exit Sub
        End If
        If MessageBox.Show("¿Desea completar los números de CUIL incompletos de las Personas?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Try
            Using dbContext As New CSBomberosContext(True)
                Dim cuil As String
                Dim count As Integer = 0
                Dim strBuilder As New System.Text.StringBuilder

                For Each p As Persona In dbContext.Persona.Where(Function(per) per.CUIL Is Nothing AndAlso per.DocumentoNumero IsNot Nothing)

                    Select Case p.Genero
                        Case Constantes.PERSONA_GENERO_FEMENINO
                            cuil = CardonerSistemas.Afip.ObtenerCuit(CardonerSistemas.Afip.TipoPersonas.Femenino, p.DocumentoNumero)
                        Case Constantes.PERSONA_GENERO_MASCULINO
                            cuil = CardonerSistemas.Afip.ObtenerCuit(CardonerSistemas.Afip.TipoPersonas.Masculino, p.DocumentoNumero)
                        Case Else
                            cuil = String.Empty
                    End Select
                    If cuil <> String.Empty Then
                        p.CUIL = cuil
                        count += 1
                        strBuilder.Append(String.Format("{0}- {1}", vbCrLf, p.ApellidoNombre))
                    End If
                Next

                If count > 0 Then
                    Dim mensajePlantilla As String
                    Dim mensajeFinal As String

                    If count = 1 Then
                        mensajePlantilla = "Se actualizará el número de CUIL de 1 Persona.{0}{2}{0}{0}¿Desea continuar?"
                    Else
                        mensajePlantilla = "Se actualizarán los números de CUIL de {1} Personas.{0}{2}{0}{0}¿Desea continuar?"
                    End If
                    mensajeFinal = String.Format(mensajePlantilla, vbCrLf, count, strBuilder.ToString())

                    If MessageBox.Show(mensajeFinal, My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        dbContext.SaveChanges()
                    End If
                Else
                    MessageBox.Show("No se encontraron Personas para actualizar el número de CUIL.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al completar los números de CUIL incompletos de las Personas.")
        End Try
    End Sub

    Private Shared Sub VerificarEdadFamiliares() Handles menuitemSistema_VerificarFamiliares.Click
        If Not Permisos.VerificarPermiso(Permisos.SISTEMA_VERIFICAR_FAMILIARACARGO) Then
            Exit Sub
        End If
        If MessageBox.Show("¿Desea verificar las edades de los Familiares a cargo de las Personas?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Try
            Using dbContext As New CSBomberosContext(True)
                Dim parentesco As New Parentesco
                Dim familiares As List(Of PersonaFamiliar)
                Dim count As Integer = 0
                Dim strBuilder As New System.Text.StringBuilder

                familiares = (From pf In dbContext.PersonaFamiliar
                              Join p In dbContext.Parentesco On pf.IDParentesco Equals p.IDParentesco
                              Where pf.ACargo AndAlso pf.FechaNacimiento IsNot Nothing AndAlso p.ACargoEdadMaxima IsNot Nothing
                              Order By pf.IDParentesco, pf.IDPersona
                              Select pf).ToList()

                For Each pf As PersonaFamiliar In familiares
                    Dim anios As Long

                    ' La lista de familiares está ordanada por IDParentesco,
                    ' para hacer un parentesco por vez
                    If parentesco.IDParentesco <> pf.IDParentesco Then
                        parentesco = dbContext.Parentesco.Find(pf.IDParentesco.Value)
                    End If
                    anios = CardonerSistemas.DateTime.GetElapsedCompleteYearsFromDates(pf.FechaNacimiento.Value, DateTime.Today)
                    If anios > parentesco.ACargoEdadMaxima Then
                        pf.ACargo = False
                        count += 1
                        strBuilder.Append(String.Format("{0}- {1} - ({2} años)", vbCrLf, pf.ApellidoNombre, anios))
                    End If
                Next

                If count > 0 Then
                    Dim mensajePlantilla As String
                    Dim mensajeFinal As String

                    If count = 1 Then
                        mensajePlantilla = "Se actualizará 1 Familiar a cargo por estar excedido en la edad.{0}{2}{0}{0}¿Desea continuar?"
                    Else
                        mensajePlantilla = "Se actualizarán {1} Familiares a cargo por estar excedidos en la edad.{0}{2}{0}{0}¿Desea continuar?"
                    End If
                    mensajeFinal = String.Format(mensajePlantilla, vbCrLf, count, strBuilder.ToString())

                    If MessageBox.Show(mensajeFinal, My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        dbContext.SaveChanges()
                    End If
                Else
                    MessageBox.Show("No se encontraron Familiares a cargo excedidos en la edad.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End Using

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al verificar las edades de los Familiares a cargo de las Personas.")
        End Try
    End Sub

#End Region

#Region "Menu Debug"


#End Region

#Region "Menu Ventana"

    Private Sub menuitemVentana_CerrarTodas_Click() Handles menuitemVentanaCerrarTodas.Click
        CardonerSistemas.Forms.MdiChildCloseAll(Me)
    End Sub

#End Region

#Region "Menu Ayuda"
    Private Sub menuitemAyuda_AcercaDe_Click(sender As Object, e As EventArgs) Handles menuitemAyuda_AcercaDe.Click
        formAboutBox.ShowDialog(Me)
    End Sub

#End Region

#Region "Left Toolbar - Tablas"

    ' PERSONAS

    Private Sub NivelesEstudio() Handles menuitemTablas_NivelesEstudio.Click
        ShowForm(Permisos.NIVELESTUDIO, CType(formNivelesEstudio, Form))
    End Sub

    Private Sub EstadosCiviles() Handles menuitemTablas_EstadosCiviles.Click
        ShowForm(Permisos.ESTADOCIVIL, CType(formEstadosCiviles, Form))
    End Sub

    Private Sub Parentescos() Handles menuitemTablas_Parentescos.Click
        ShowForm(Permisos.PARENTESCO, CType(formParentescos, Form))
    End Sub

    Private Sub PersonaBajaMotivos() Handles menuitemTablas_MotivosBajaPersonas.Click
        ShowForm(Permisos.PERSONABAJAMOTIVO, CType(formPersonaBajaMotivos, Form))
    End Sub

    Private Sub Cargos() Handles menuitemTablas_Cargos.Click
        ShowForm(Permisos.CARGO, CType(formCargos, Form))
    End Sub

    Private Sub CargosJerarquias() Handles menuitemTablas_CargosJerarquias.Click
        ShowForm(Permisos.CARGOJERARQUIA, CType(formCargosJerarquias, Form))
    End Sub

    Private Sub VehiculosTipos() Handles menuitemTablas_TiposVehiculo.Click
        ShowForm(Permisos.VEHICULOTIPO, CType(formVehiculoTipos, Form))
    End Sub

    Private Sub VehiculosMarcas() Handles menuitemTablas_MarcasVehiculo.Click
        ShowForm(Permisos.VEHICULOMARCA, CType(formVehiculoMarcas, Form))
    End Sub

    Private Sub VehiculosCompaniasSeguros() Handles menuitemTablas_CompaniasSegurosVehiculo.Click
        ShowForm(Permisos.VEHICULOCOMPANIASEGURO, CType(formVehiculoCompaniasSeguro, Form))
    End Sub

    Private Sub VacunaTipos() Handles menuitemTablas_TiposVacuna.Click
        ShowForm(Permisos.VACUNATIPO, CType(formVacunaTipos, Form))
    End Sub

    Private Sub LicenciaCausas() Handles menuitemTablas_CausalesLicenciaPersonas.Click
        ShowForm(Permisos.LICENCIACAUSA, CType(formLicenciaCausas, Form))
    End Sub

    Private Sub SancionTipos() Handles menuitemTablas_TiposSancion.Click
        ShowForm(Permisos.SANCIONTIPO, CType(formSancionTipos, Form))
    End Sub

    ' CAPACITACIONES

    Private Sub Cursos() Handles menuitemTablas_Cursos.Click
        ShowForm(Permisos.CURSO, CType(formCursos, Form))
    End Sub

    Private Sub CapacitacionNiveles() Handles menuitemTablas_NivelesCapacitacion.Click
        ShowForm(Permisos.CAPACITACIONNIVEL, CType(formCapacitacionNiveles, Form))
    End Sub

    Private Sub CapacitacionTipos() Handles menuitemTablas_TiposCapacitacion.Click
        ShowForm(Permisos.CAPACITACIONTIPO, CType(formCapacitacionTipos, Form))
    End Sub

    Private Sub CalificacionConceptos() Handles menuitemTablas_ConceptosCalificacion.Click
        ShowForm(Permisos.CALIFICACIONCONCEPTO, CType(formCalificacionConceptos, Form))
    End Sub

    ' UNIDADES

    Private Sub UnidadTipos() Handles menuitemTablas_TiposUnidad.Click
        ShowForm(Permisos.UNIDADTIPO, CType(formUnidadTipos, Form))
    End Sub

    Private Sub UnidadUsos() Handles menuitemTablas_UsosUnidad.Click
        ShowForm(Permisos.UNIDADUSO, CType(formUnidadUsos, Form))
    End Sub

    Private Sub UnidadMotivosBaja() Handles menuitemTablas_MotivosBajaUnidad.Click
        ShowForm(Permisos.UNIDADBAJAMOTIVO, CType(formUnidadBajaMotivos, Form))
    End Sub

    ' INVENTARIO

    Private Sub Rubros() Handles menuitemTablas_Rubros.Click
        ShowForm(Permisos.RUBRO, CType(formRubros, Form))
    End Sub

    Private Sub SubRubros() Handles menuitemTablas_SubRubros.Click
        ShowForm(Permisos.SUBRUBRO, CType(formSubRubros, Form))
    End Sub

    Private Sub Ubicaciones() Handles menuitemTablas_Ubicaciones.Click
        ShowForm(Permisos.UBICACION, CType(formUbicaciones, Form))
    End Sub

    Private Sub SubUbicaciones() Handles menuitemTablas_SubUbicaciones.Click
        ShowForm(Permisos.SUBUBICACION, CType(formSubUbicaciones, Form))
    End Sub

    ' ACADEMIAS 

    Private Sub AcademiasTipos() Handles menuitemTablas_AcademiasTipos.Click
        ShowForm(Permisos.ACADEMIATIPO, CType(formAcademiaTipos, Form))
    End Sub

    Private Sub AcademiasAsistenciasTipos() Handles menuitemTablas_AcademiasAsistenciasTipos.Click
        ShowForm(Permisos.ACADEMIAASISTENCIATIPO, CType(formAcademiaAsistenciaTipos, Form))
    End Sub

    ' SINIESTROS

    Private Sub SiniestrosRubros() Handles menuitemTablas_SiniestrosRubros.Click
        ShowForm(Permisos.SINIESTRORUBRO, CType(formSiniestroRubros, Form))
    End Sub

    Private Sub SiniestrosTipos() Handles menuitemTablas_SiniestrosTipos.Click
        ShowForm(Permisos.SINIESTROTIPO, CType(formSiniestroTipos, Form))
    End Sub

    Private Sub SiniestrosClaves() Handles menuitemTablas_SiniestrosClaves.Click
        ShowForm(Permisos.SINIESTROCLAVE, CType(formSiniestroClaves, Form))
    End Sub

    Private Sub SiniestrosAsistenciasTipos() Handles menuitemTablas_SiniestrosAsistenciasTipos.Click
        ShowForm(Permisos.SINIESTROASISTENCIATIPO, CType(formSiniestroAsistenciaTipos, Form))
    End Sub

    ' USUARIOS

    Private Sub GruposUsuario() Handles menuitemTablas_GruposUsuario.Click
        ShowForm(Permisos.USUARIOGRUPO, CType(formUsuarioGrupos, Form))
    End Sub

    Private Sub Usuarios() Handles menuitemTablas_Usuarios.Click
        ShowForm(Permisos.USUARIO, CType(formUsuarios, Form))
    End Sub

    Private Sub UsuarioGrupoPermisos() Handles menuitemTablas_Permisos.Click
        ShowForm(Permisos.USUARIOGRUPOPERMISO, CType(formUsuarioGrupoPermisos, Form))
    End Sub

    ' OTROS

    Private Sub Cuarteles() Handles menuitemTablas_Cuarteles.Click
        ShowForm(Permisos.CUARTEL, CType(formCuarteles, Form))
    End Sub

    Private Sub Areas() Handles menuitemTablas_Areas.Click
        ShowForm(Permisos.AREA, CType(formAreas, Form))
    End Sub

    Private Sub Alarmas() Handles menuitemTablas_Alarmas.Click
        ShowForm(Permisos.ALARMA, CType(formAlarmas, Form))
    End Sub

    Private Sub TiposResponsables() Handles menuitemTablas_TiposResponsables.Click
        ShowForm(Permisos.RESPONSABLETIPO, CType(formResponsableTipos, Form))
    End Sub

    Private Sub Responsables() Handles menuitemTablas_Responsables.Click
        ShowForm(Permisos.RESPONSABLE, CType(formResponsables, Form))
    End Sub

    Private Sub Proveedores() Handles menuitemTablas_Proveedores.Click
        ShowForm(Permisos.PROVEEDOR, CType(formProveedores, Form))
    End Sub

#End Region

#Region "Left Toolbar - Documentaciones"

    Private Sub Personas() Handles menuitemDocumentaciones_Personas.Click
        ShowForm(Permisos.PERSONA, CType(formPersonas, Form))
    End Sub

    Private Sub Unidades() Handles menuitemDocumentaciones_Unidades.Click
        ShowForm(Permisos.UNIDAD, CType(formUnidades, Form))
    End Sub

    Private Sub Inventario() Handles menuitemDocumentaciones_Inventario.Click
        ShowForm(Permisos.INVENTARIO, CType(formInventario, Form))
    End Sub

    Private Sub Elementos() Handles menuitemDocumentaciones_Inventario_Elementos.Click
        ShowForm(Permisos.ELEMENTO, CType(formElementos, Form))
    End Sub

    Private Sub Academias() Handles menuitemDocumentaciones_Academias.Click
        ShowForm(Permisos.ACADEMIA, CType(formAcademias, Form))
    End Sub

    Private Sub DocumentacionesReportes(sender As Object, e As EventArgs) Handles menuitemDocumentaciones_Reportes.Click
        ShowFormReportes(Permisos.REPORTE_DOCUMENTACIONES, Constantes.MODULO_DOCUMENTACIONES_ID, Constantes.MODULO_DOCUMENTACIONES_NOMBRE)
    End Sub
#End Region

#Region "Left Toolbar - Jefatura"

    Private Sub OrdenesCompra(sender As Object, e As EventArgs) Handles menuitemJefatura_OrdenesCompra.Click
        ShowForm(Permisos.COMPRAORDEN, CType(formCompraOrdenes, Form))
    End Sub

    Private Sub ArqueosCaja(sender As Object, e As EventArgs) Handles menuitemJefatura_ArqueosCaja.Click
        ShowForm(Permisos.CAJAARQUEO, CType(formCajasArqueos, Form))
    End Sub

    Private Sub JefaturaReportes(sender As Object, e As EventArgs) Handles menuitemJefatura_Reportes.Click
        ShowFormReportes(Permisos.REPORTE_JEFATURA, Constantes.MODULO_JEFATURA_ID, Constantes.MODULO_JEFATURA_NOMBRE)
    End Sub

#End Region

#Region "Left Toolbar - Comisión directiva"

    Private Sub FacturasCompra() Handles menuitemComisionDirectiva_FacturasCompra.Click
        ShowForm(Permisos.COMPRAFACTURA, CType(formCompraFacturas, Form))
    End Sub

    Private Sub ComisionDirectivaReportes(sender As Object, e As EventArgs) Handles menuitemComisionDirectiva_Reportes.Click
        ShowFormReportes(Permisos.REPORTE_COMISIONDIRECTIVA, Constantes.MODULO_COMISIONDIRECTIVA_ID, Constantes.MODULO_COMISIONDIRECTIVA_NOMBRE)
    End Sub

#End Region

#Region "Left Toolbar - Guardia"

    Private Sub Siniestros() Handles menuitemGuardia_Siniestros.Click
        ShowForm(Permisos.SINIESTRO, CType(formSiniestros, Form))
    End Sub

#End Region

#Region "Controls behavior"
    Private Sub labelUsuarioNombre_DoubleClick() Handles labelUsuarioNombre.MouseDown
        CerrarSesionUsuario()
    End Sub
#End Region

#Region "Extra stuff"

    Private Sub ShowForm(ByVal idPermiso As String, ByRef form As Form)
        If Permisos.VerificarPermiso(idPermiso) Then
            Me.Cursor = Cursors.WaitCursor

            CardonerSistemas.Forms.MdiChildPositionAndSizeToFit(Me, form)
            form.Show()
            If form.WindowState = FormWindowState.Minimized Then
                form.WindowState = FormWindowState.Normal
            End If
            form.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ShowFormReportes(ByVal idPermiso As String, ByVal IDModulo As Byte, ByVal ModuloNombre As String)
        If Permisos.VerificarPermiso(idPermiso) Then
            Me.Cursor = Cursors.WaitCursor

            CardonerSistemas.Forms.MdiChildPositionAndSizeToFit(Me, CType(formReportes, Form))
            formReportes.SetValues(IDModulo, ModuloNombre)
            formReportes.Show()
            If formReportes.WindowState = FormWindowState.Minimized Then
                formReportes.WindowState = FormWindowState.Normal
            End If
            formReportes.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub CerrarSesionUsuario()
        If MsgBox("¿Desea cerrar la sesión del Usuario actual?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
            CardonerSistemas.Forms.MdiChildCloseAll(Me)
            labelUsuarioNombre.Image = Nothing
            labelUsuarioNombre.Text = ""
            pUsuario = Nothing
            If Not formLogin.ShowDialog(Me) = DialogResult.OK Then
                Application.Exit()
                My.Application.Log.WriteEntry("La Aplicación ha finalizado porque el Usuario no ha iniciado sesión.", TraceEventType.Warning)
                Exit Sub
            End If
            formLogin.Close()
            formLogin.Dispose()
        End If
    End Sub

#End Region

End Class