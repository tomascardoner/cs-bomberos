Public Class formMDIMain

#Region "Declarations"
    Friend Form_ClientSize As Size
    Private AFIP_TicketAcceso_Homo As String
#End Region

#Region "Form stuff"
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cambio el puntero del mouse para indicar que la aplicación está iniciando
        Me.Cursor = Cursors.AppStarting

        ' Deshabilito el Form principal hasta que se cierre el SplashScreen
        Me.Enabled = False

        Me.Text = My.Application.Info.Title

        menuitemAyuda_AcercaDe.Text = "&Acerca de " & My.Application.Info.Title & "..."
    End Sub

    Private Sub formMDIMain_Resize() Handles Me.Resize
        If Not Me.WindowState = FormWindowState.Minimized Then

            'OBTENGO LAS MEDIDAS DEL CLIENT AREA DEL FORM MDI
            Form_ClientSize = New Size(Me.ClientSize.Width - toolstripMain.Width - pAppearanceConfig.MdiFormMargin, Me.ClientSize.Height - menustripMain.Height - statusstripMain.Height - pAppearanceConfig.MdiFormMargin)

            'HAGO UN RESIZE DE TODOS LOS CHILDS QUE ESTÉN ABIERTOS
            For Each FormCurrent As Form In Me.MdiChildren
                If FormCurrent.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable Then
                    If FormCurrent.Name = "formComprobante" Then
                        CS_Form.MDIChild_CenterToClientArea(FormCurrent, Form_ClientSize)
                    Else
                        CS_Form.MDIChild_PositionAndSizeToFit(Me, FormCurrent)
                    End If
                Else
                    CS_Form.MDIChild_CenterToClientArea(FormCurrent, Form_ClientSize)
                End If
            Next
        End If
    End Sub

    Private Sub MDIMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not (e.CloseReason = CloseReason.ApplicationExitCall Or e.CloseReason = CloseReason.TaskManagerClosing Or e.CloseReason = CloseReason.WindowsShutDown) Then
            If MsgBox("¿Desea salir de la aplicación?", CType(MsgBoxStyle.Information + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If
        End If
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

    Private Sub ApplicacionSalir() Handles menuitemArchivo_Salir.Click
        Me.Close()
    End Sub
#End Region

#Region "Menu Debug"
#End Region

#Region "Menu Ventana"
    Private Sub menuitemVentana_MosaicoHorizontal_Click() Handles menuitemVentanaMosaicoHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub menuitemVentana_MosaicoVertical_Click() Handles menuitemVentanaMosaicoVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub menuitemVentana_Cascada_Click() Handles menuitemVentanaCascada.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub menuitemVentana_OrganizarIconos_Click() Handles menuitemVentanaOrganizarIconos.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub menuitemVentana_EncajarEnVentana_Click() Handles menuitemVentanaEncajarEnVentana.Click
        If Not Me.ActiveMdiChild Is Nothing Then
            Me.ActiveMdiChild.Left = 0
            Me.ActiveMdiChild.Top = 0
            Me.ActiveMdiChild.Size = Form_ClientSize
        End If
    End Sub

    Private Sub menuitemVentana_CerrarTodas_Click() Handles menuitemVentanaCerrarTodas.Click
        CS_Form.MDIChild_CloseAll(Me)
    End Sub
#End Region

#Region "Menu Ayuda"
    Private Sub menuitemAyuda_AcercaDe_Click(sender As Object, e As EventArgs) Handles menuitemAyuda_AcercaDe.Click
        formAboutBox.ShowDialog(Me)
    End Sub

#End Region

#Region "Left Toolbar - Tablas"

    Private Sub NivelesEstudio() Handles menuitemTablas_NivelesEstudio.Click
        ShowForm(Permisos.NIVELESTUDIO, CType(formNivelesEstudio, Form))
    End Sub

    Private Sub Parentescos() Handles menuitemTablas_Parentescos.Click
        ShowForm(Permisos.PARENTESCO, CType(formParentescos, Form))
    End Sub

    Private Sub EstadosCiviles() Handles menuitemTablas_EstadosCiviles.Click
        ShowForm(Permisos.ESTADOCIVIL, CType(formEstadosCiviles, Form))
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

    Private Sub UnidadTipos() Handles menuitemTablas_TiposUnidad.Click
        ShowForm(Permisos.UNIDADTIPO, CType(formUnidadTipos, Form))
    End Sub

    Private Sub UnidadUsos() Handles menuitemTablas_UsosUnidad.Click
        ShowForm(Permisos.UNIDADUSO, CType(formUnidadUsos, Form))
    End Sub

    Private Sub UnidadMotivosBaja() Handles menuitemTablas_MotivosBajaUnidad.Click
        ShowForm(Permisos.UNIDADBAJAMOTIVO, CType(formUnidadBajaMotivos, Form))
    End Sub

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

    Private Sub Usuarios() Handles menuitemTablas_Usuarios.Click
        ShowForm(Permisos.USUARIO, CType(formUsuarios, Form))
    End Sub

    Private Sub UsuarioGrupoPermisos() Handles menuitemTablas_Permisos.Click
        ShowForm(Permisos.USUARIOGRUPO, CType(formUsuarioGrupoPermisos, Form))
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

    Private Sub Responsables() Handles menuitemTablas_Responsables.Click
        ShowForm(Permisos.RESPONSABLE, CType(formResponsables, Form))
    End Sub

#End Region

#Region "Left Toolbar - Personas"
    Private Sub Personas() Handles buttonPersonas.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formPersonas, Form))
            formPersonas.Show()
            If formPersonas.WindowState = FormWindowState.Minimized Then
                formPersonas.WindowState = FormWindowState.Normal
            End If
            formPersonas.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Left Toolbar - Unidades"
    Private Sub Unidades() Handles buttonUnidades.Click
        If Permisos.VerificarPermiso(Permisos.UNIDAD) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formUnidades, Form))
            formUnidades.Show()
            If formUnidades.WindowState = FormWindowState.Minimized Then
                formUnidades.WindowState = FormWindowState.Normal
            End If
            formUnidades.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Left Toolbar - Inventario"
    Private Sub Elementos() Handles menuitemInventario_Elementos.Click
        If Permisos.VerificarPermiso(Permisos.ELEMENTO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formElementos, Form))
            formElementos.Show()
            If formElementos.WindowState = FormWindowState.Minimized Then
                formElementos.WindowState = FormWindowState.Normal
            End If
            formElementos.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Inventario() Handles buttonInventario.ButtonClick
        If Permisos.VerificarPermiso(Permisos.INVENTARIO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formInventario, Form))
            formInventario.Show()
            If formInventario.WindowState = FormWindowState.Minimized Then
                formInventario.WindowState = FormWindowState.Normal
            End If
            formInventario.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Left Toolbar - Reportes"
    Private Sub buttonReportes_Click(sender As Object, e As EventArgs) Handles buttonReportes.Click
        If Permisos.VerificarPermiso(Permisos.REPORTE) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formReportes, Form))
            formReportes.Show()
            If formReportes.WindowState = FormWindowState.Minimized Then
                formReportes.WindowState = FormWindowState.Normal
            End If
            formReportes.Focus()

            Me.Cursor = Cursors.Default
        End If
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

            CS_Form.MDIChild_PositionAndSizeToFit(Me, form)
            form.Show()
            If form.WindowState = FormWindowState.Minimized Then
                form.WindowState = FormWindowState.Normal
            End If
            form.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub CerrarSesionUsuario()
        If MsgBox("¿Desea cerrar la sesión del Usuario actual?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
            CS_Form.MDIChild_CloseAll(Me)
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