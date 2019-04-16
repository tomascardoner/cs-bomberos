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
            Form_ClientSize = New Size(Me.ClientSize.Width - toolstripMain.Width - My.Settings.MDIFormMargin, Me.ClientSize.Height - menustripMain.Height - statusstripMain.Height - My.Settings.MDIFormMargin)

            'HAGO UN RESIZE DE TODOS LOS CHILDS QUE ESTÉN ABIERTOS
            For Each FormCurrent As Form In Me.MdiChildren
                If FormCurrent.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable Then
                    If FormCurrent.Name = "formComprobante" Then
                        CS_Form.MDIChild_CenterToClientArea(Me, FormCurrent, Form_ClientSize)
                    Else
                        CS_Form.MDIChild_PositionAndSizeToFit(Me, FormCurrent)
                    End If
                Else
                    CS_Form.MDIChild_CenterToClientArea(Me, FormCurrent, Form_ClientSize)
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
        If Permisos.VerificarPermiso(Permisos.PARENTESCO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formNivelesEstudio, Form))
            formNivelesEstudio.Show()
            If formNivelesEstudio.WindowState = FormWindowState.Minimized Then
                formNivelesEstudio.WindowState = FormWindowState.Normal
            End If
            formNivelesEstudio.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Parentescos() Handles menuitemTablas_Parentescos.Click
        If Permisos.VerificarPermiso(Permisos.PARENTESCO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formParentescos, Form))
            formParentescos.Show()
            If formParentescos.WindowState = FormWindowState.Minimized Then
                formParentescos.WindowState = FormWindowState.Normal
            End If
            formParentescos.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub PersonaBajaMotivos() Handles menuitemTablas_MotivosBajaPersonas.Click
        If Permisos.VerificarPermiso(Permisos.PERSONABAJAMOTIVO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formPersonaBajaMotivos, Form))
            formPersonaBajaMotivos.Show()
            If formPersonaBajaMotivos.WindowState = FormWindowState.Minimized Then
                formPersonaBajaMotivos.WindowState = FormWindowState.Normal
            End If
            formPersonaBajaMotivos.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Cargos() Handles menuitemTablas_Cargos.Click
        If Permisos.VerificarPermiso(Permisos.CARGO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formCargos, Form))
            formCargos.Show()
            If formCargos.WindowState = FormWindowState.Minimized Then
                formCargos.WindowState = FormWindowState.Normal
            End If
            formCargos.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub CargosJerarquias() Handles menuitemTablas_CargosJerarquias.Click
        If Permisos.VerificarPermiso(Permisos.CARGOJERARQUIA) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formCargosJerarquias, Form))
            formCargosJerarquias.Show()
            If formCargosJerarquias.WindowState = FormWindowState.Minimized Then
                formCargosJerarquias.WindowState = FormWindowState.Normal
            End If
            formCargosJerarquias.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub VehiculoTipos() Handles menuitemTablas_TiposVehiculo.Click
        If Permisos.VerificarPermiso(Permisos.VEHICULOTIPO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formVehiculoTipos, Form))
            formVehiculoTipos.Show()
            If formVehiculoTipos.WindowState = FormWindowState.Minimized Then
                formVehiculoTipos.WindowState = FormWindowState.Normal
            End If
            formVehiculoTipos.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub LicenciaCausas() Handles menuitemTablas_CausalesLicenciaPersonas.Click
        If Permisos.VerificarPermiso(Permisos.LICENCIACAUSA) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formLicenciaCausas, Form))
            formLicenciaCausas.Show()
            If formLicenciaCausas.WindowState = FormWindowState.Minimized Then
                formLicenciaCausas.WindowState = FormWindowState.Normal
            End If
            formLicenciaCausas.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub SancionTipos() Handles menuitemTablas_TiposSancion.Click
        If Permisos.VerificarPermiso(Permisos.SANCIONTIPO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formSancionTipos, Form))
            formSancionTipos.Show()
            If formSancionTipos.WindowState = FormWindowState.Minimized Then
                formSancionTipos.WindowState = FormWindowState.Normal
            End If
            formSancionTipos.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Cursos() Handles menuitemTablas_Cursos.Click
        If Permisos.VerificarPermiso(Permisos.CURSO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formCursos, Form))
            formCursos.Show()
            If formCursos.WindowState = FormWindowState.Minimized Then
                formCursos.WindowState = FormWindowState.Normal
            End If
            formCursos.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub CapacitacionNiveles() Handles menuitemTablas_NivelesCapacitacion.Click
        If Permisos.VerificarPermiso(Permisos.CURSO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formCapacitacionNiveles, Form))
            formCapacitacionNiveles.Show()
            If formCapacitacionNiveles.WindowState = FormWindowState.Minimized Then
                formCapacitacionNiveles.WindowState = FormWindowState.Normal
            End If
            formCapacitacionNiveles.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub CapacitacionTipos() Handles menuitemTablas_TiposCapacitacion.Click
        If Permisos.VerificarPermiso(Permisos.CURSO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formCapacitacionTipos, Form))
            formCapacitacionTipos.Show()
            If formCapacitacionTipos.WindowState = FormWindowState.Minimized Then
                formCapacitacionTipos.WindowState = FormWindowState.Normal
            End If
            formCapacitacionTipos.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub CalificacionConceptos() Handles menuitemTablas_ConceptosCalificacion.Click
        If Permisos.VerificarPermiso(Permisos.CALIFICACIONCONCEPTO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formCalificacionConceptos, Form))
            formCalificacionConceptos.Show()
            If formCalificacionConceptos.WindowState = FormWindowState.Minimized Then
                formCalificacionConceptos.WindowState = FormWindowState.Normal
            End If
            formCalificacionConceptos.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub UnidadTipos() Handles menuitemTablas_TiposUnidad.Click
        If Permisos.VerificarPermiso(Permisos.UNIDADTIPO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formUnidadTipos, Form))
            formUnidadTipos.Show()
            If formUnidadTipos.WindowState = FormWindowState.Minimized Then
                formUnidadTipos.WindowState = FormWindowState.Normal
            End If
            formUnidadTipos.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub UnidadUsos() Handles menuitemTablas_UsosUnidad.Click
        If Permisos.VerificarPermiso(Permisos.UNIDADUSO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formUnidadUsos, Form))
            formUnidadUsos.Show()
            If formUnidadUsos.WindowState = FormWindowState.Minimized Then
                formUnidadUsos.WindowState = FormWindowState.Normal
            End If
            formUnidadUsos.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub UnidadMotivosBaja() Handles menuitemTablas_MotivosBajaUnidad.Click
        If Permisos.VerificarPermiso(Permisos.UNIDADBAJAMOTIVO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formUnidadBajaMotivos, Form))
            formUnidadBajaMotivos.Show()
            If formUnidadBajaMotivos.WindowState = FormWindowState.Minimized Then
                formUnidadBajaMotivos.WindowState = FormWindowState.Normal
            End If
            formUnidadBajaMotivos.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Rubros() Handles menuitemTablas_Rubros.Click
        If Permisos.VerificarPermiso(Permisos.RUBRO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formRubros, Form))
            formRubros.Show()
            If formRubros.WindowState = FormWindowState.Minimized Then
                formRubros.WindowState = FormWindowState.Normal
            End If
            formRubros.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub SubRubros() Handles menuitemTablas_SubRubros.Click
        If Permisos.VerificarPermiso(Permisos.SUBRUBRO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formSubRubros, Form))
            formSubRubros.Show()
            If formSubRubros.WindowState = FormWindowState.Minimized Then
                formSubRubros.WindowState = FormWindowState.Normal
            End If
            formSubRubros.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Areas() Handles menuitemTablas_Areas.Click
        If Permisos.VerificarPermiso(Permisos.AREA) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formAreas, Form))
            formAreas.Show()
            If formAreas.WindowState = FormWindowState.Minimized Then
                formAreas.WindowState = FormWindowState.Normal
            End If
            formAreas.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Ubicaciones() Handles menuitemTablas_Ubicaciones.Click
        If Permisos.VerificarPermiso(Permisos.UBICACION) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formUbicaciones, Form))
            formUbicaciones.Show()
            If formUbicaciones.WindowState = FormWindowState.Minimized Then
                formUbicaciones.WindowState = FormWindowState.Normal
            End If
            formUbicaciones.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub SubUbicaciones() Handles menuitemTablas_SubUbicaciones.Click
        If Permisos.VerificarPermiso(Permisos.SUBUBICACION) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formSubUbicaciones, Form))
            formSubUbicaciones.Show()
            If formSubUbicaciones.WindowState = FormWindowState.Minimized Then
                formSubUbicaciones.WindowState = FormWindowState.Normal
            End If
            formSubUbicaciones.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub UsuarioGrupoPermisos() Handles menuitemTablas_Permisos.Click
        If Permisos.VerificarPermiso(Permisos.USUARIOGRUPO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formUsuarioGrupoPermisos, Form))
            formUsuarioGrupoPermisos.Show()
            If formUsuarioGrupoPermisos.WindowState = FormWindowState.Minimized Then
                formUsuarioGrupoPermisos.WindowState = FormWindowState.Normal
            End If
            formUsuarioGrupoPermisos.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Alarmas() Handles menuitemTablas_Alarmas.Click
        If Permisos.VerificarPermiso(Permisos.ALARMA) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formAlarmas, Form))
            formAlarmas.Show()
            If formAlarmas.WindowState = FormWindowState.Minimized Then
                formAlarmas.WindowState = FormWindowState.Normal
            End If
            formAlarmas.Focus()

            Me.Cursor = Cursors.Default
        End If
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