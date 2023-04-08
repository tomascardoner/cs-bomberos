Public Class formSancion

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaSancionActual As PersonaSancion

    Private mIsLoading As Boolean
    Private mIsNew As Boolean
    Private mEditMode As Boolean
    Private mVistaDesdeUnaPersona As Boolean
    Private mPermisoParaCambiarEstado As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal vistaDesdeUnaPersona As Boolean, ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer, ByVal IDSancion As Short)
        mIsLoading = True
        mIsNew = (IDSancion = 0)
        mEditMode = EditMode
        mVistaDesdeUnaPersona = vistaDesdeUnaPersona

        If mIsNew Then
            ' Es Nuevo
            mPersonaSancionActual = New PersonaSancion
            With mPersonaSancionActual
                ' Establezco la Persona si corresponde
                If mVistaDesdeUnaPersona Then
                    .IDPersona = IDPersona
                ElseIf CType(formSanciones.controlpersonaPersonaHost.Control, ControlPersona).IDPersona.HasValue Then
                    .IDPersona = CType(formSanciones.controlpersonaPersonaHost.Control, ControlPersona).IDPersona.Value
                End If

                .SolicitudFecha = DateTime.Today
                .Estado = Constantes.PersonaSancionEstadoEnProceso
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.PersonaSancion.Add(mPersonaSancionActual)
        Else
            mPersonaSancionActual = mdbContext.PersonaSancion.Find(IDPersona, IDSancion)
        End If

        If Not mVistaDesdeUnaPersona Then
            mPermisoParaCambiarEstado = Permisos.VerificarPermiso(SANCION_CAMBIARESTADO, False)
        End If

        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()

        mIsLoading = False

        ChangeMode()

        Me.ShowDialog(ParentForm)
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Exit Sub
        End If

        buttonGuardar.Visible = mEditMode And (Not mVistaDesdeUnaPersona)
        buttonCancelar.Visible = mEditMode And (Not mVistaDesdeUnaPersona)
        buttonEditar.Visible = (Not mEditMode) And (Not mVistaDesdeUnaPersona)
        buttonCerrar.Visible = (Not mEditMode) Or mVistaDesdeUnaPersona

        ' General
        controlpersonaAplicar.ReadOnlyText = Not mEditMode

        comboboxSolicitudResponsableTipo.Enabled = mEditMode
        textboxSolicitudPersonaTexto.ReadOnly = Not mEditMode
        checkboxObtenerTextos.Visible = mEditMode
        textboxSolicitudMotivo.ReadOnly = Not mEditMode
        datetimepickerSolicitudFecha.Enabled = mEditMode

        textboxEncuadreTexto.ReadOnly = Not mEditMode
        datetimepickerEncuadreFecha.Enabled = mEditMode

        ' Resolución y encuadre
        radiobuttonEstadoEnProceso.Visible = Not mVistaDesdeUnaPersona
        radiobuttonEstadoAprobada.Visible = Not mVistaDesdeUnaPersona
        radiobuttonEstadoDesaprobada.Visible = Not mVistaDesdeUnaPersona

        radiobuttonEstadoEnProceso.Enabled = mEditMode And mPermisoParaCambiarEstado
        radiobuttonEstadoAprobada.Enabled = mEditMode And mPermisoParaCambiarEstado
        radiobuttonEstadoDesaprobada.Enabled = mEditMode And mPermisoParaCambiarEstado

        textboxDesaprobadaCausa.ReadOnly = Not mEditMode

        comboboxResolucionSancionTipo.Enabled = mEditMode
        datetimepickerResolucionFecha.Enabled = mEditMode
        textboxResolucionNumero.Enabled = mEditMode

        datetimepickerNotificacionFecha.Enabled = mEditMode
        datetimepickerNotificacionFechaEfectiva.Enabled = mEditMode

        textboxTestimonioTexto.ReadOnly = Not mEditMode
        datetimepickerTestimonioFecha.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        controlpersonaAplicar.dbContext = mdbContext
        controlpersonaSolicitud.dbContext = mdbContext
        ListasResponsables.LlenarComboBoxResponsableTiposConIDResponsableTipo(mdbContext, comboboxSolicitudResponsableTipo, False, True)
        ListasSanciones.LlenarComboBoxMotivosSanciones(mdbContext, comboboxSancionMotivo, False, False)
        ListasSanciones.LlenarComboBoxTiposSanciones(mdbContext, comboboxResolucionSancionTipo, False, True)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mPersonaSancionActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mPersonaSancionActual
            ' Datos de la pestaña General
            If mVistaDesdeUnaPersona Or Not mIsNew Then
                controlpersonaAplicar.AsignarValores(.Persona)
            ElseIf CType(formSanciones.controlpersonaPersonaHost.Control, ControlPersona).IDPersona.HasValue Then
                controlpersonaAplicar.CopiarValores(CType(formSanciones.controlpersonaPersonaHost.Control, ControlPersona))
            Else
                controlpersonaAplicar.ResetText()
            End If

            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxSolicitudResponsableTipo, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .SolicitudIDResponsableTipo, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            If mIsNew Then
                controlpersonaSolicitud.ResetText()
            Else
                controlpersonaSolicitud.AsignarValores(.PersonaSolicita)
            End If
            textboxSolicitudPersonaTexto.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.SolicitudPersonaTexto)

            textboxSolicitudMotivo.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.SolicitudMotivo)
            datetimepickerSolicitudFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.SolicitudFecha)

            textboxEncuadreTexto.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.EncuadreTexto)
            datetimepickerEncuadreFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.EncuadreFecha, datetimepickerEncuadreFecha)

            ' Datos de la pestaña Resolución y testimonio
            radiobuttonEstadoEnProceso.Checked = (.Estado = Constantes.PersonaSancionEstadoEnProceso)
            radiobuttonEstadoAprobada.Checked = (.Estado = Constantes.PersonaSancionEstadoAprobada)
            radiobuttonEstadoDesaprobada.Checked = (.Estado = Constantes.PersonaSancionEstadoDesaprobada)

            If .Estado = Constantes.PersonaSancionEstadoDesaprobada Then
                textboxDesaprobadaCausa.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DesaprobadaCausa)
            Else
                textboxDesaprobadaCausa.Text = String.Empty
            End If

            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxResolucionSancionTipo, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .ResolucionIDSancionTipo)
            datetimepickerResolucionFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.ResolucionFecha, datetimepickerResolucionFecha)
            textboxResolucionNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.ResolucionNumero)

            datetimepickerNotificacionFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.NotificacionFecha, datetimepickerNotificacionFecha)
            datetimepickerNotificacionFechaEfectiva.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.NotificacionFechaEfectiva, datetimepickerNotificacionFechaEfectiva)

            textboxTestimonioTexto.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.TestimonioTexto)
            datetimepickerTestimonioFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.TestimonioFecha, datetimepickerTestimonioFecha)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .IDSancion = 0 Then
                textboxIDSancion.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDSancion.Text = String.Format(.IDSancion.ToString, "G")
            End If
            textboxFechaHoraCreacion.Text = .FechaHoraCreacion.ToShortDateString & " " & .FechaHoraCreacion.ToShortTimeString
            If .UsuarioCreacion Is Nothing Then
                textboxUsuarioCreacion.Text = ""
            Else
                textboxUsuarioCreacion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.UsuarioCreacion.Descripcion)
            End If
            textboxFechaHoraModificacion.Text = .FechaHoraModificacion.ToShortDateString & " " & .FechaHoraModificacion.ToShortTimeString
            If .UsuarioModificacion Is Nothing Then
                textboxUsuarioModificacion.Text = ""
            Else
                textboxUsuarioModificacion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.UsuarioModificacion.Descripcion)
            End If
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mPersonaSancionActual
            ' Datos de la pestaña General
            .IDPersona = controlpersonaAplicar.IDPersona.Value

            .SolicitudIDResponsableTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxSolicitudResponsableTipo.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            .SolicitudIDPersona = controlpersonaSolicitud.IDPersona.Value
            .SolicitudPersonaTexto = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxSolicitudPersonaTexto.Text.TrimAndReduce)
            .SolicitudMotivo = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxSolicitudMotivo.Text)
            .SolicitudFecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerSolicitudFecha.Value).Value

            .EncuadreTexto = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxEncuadreTexto.Text)
            .EncuadreFecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerEncuadreFecha.Value, datetimepickerEncuadreFecha.Checked)

            ' Datos de la pestaña Resolución y testimonio
            .Estado = CStr(Microsoft.VisualBasic.Switch(radiobuttonEstadoEnProceso.Checked, Constantes.PersonaSancionEstadoEnProceso, radiobuttonEstadoAprobada.Checked, Constantes.PersonaSancionEstadoAprobada, radiobuttonEstadoDesaprobada.Checked, Constantes.PersonaSancionEstadoDesaprobada))

            If radiobuttonEstadoDesaprobada.Checked Then
                .DesaprobadaCausa = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDesaprobadaCausa.Text)
            Else
                .DesaprobadaCausa = Nothing
            End If

            .ResolucionIDSancionTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxResolucionSancionTipo.SelectedValue)
            .ResolucionFecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerResolucionFecha.Value, datetimepickerResolucionFecha.Checked)
            .ResolucionNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxResolucionNumero.Text)

            .NotificacionFecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerNotificacionFecha.Value, datetimepickerNotificacionFecha.Checked)
            .NotificacionFechaEfectiva = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerNotificacionFechaEfectiva.Value, datetimepickerNotificacionFechaEfectiva.Checked)

            .TestimonioTexto = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxTestimonioTexto.Text)
            .TestimonioFecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerTestimonioFecha.Value, datetimepickerTestimonioFecha.Checked)

            ' Datos de la pestaña Notas y Auditoría
            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
        End With
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                If mEditMode Then
                    buttonGuardar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                If mEditMode Then
                    buttonCancelar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
        End Select
    End Sub

    Private Sub SolicitudResponsableTipoChanged(sender As Object, e As EventArgs) Handles comboboxSolicitudResponsableTipo.SelectedIndexChanged
        If comboboxSolicitudResponsableTipo.SelectedIndex > 0 Then
            Dim selectedItem As ListasResponsables.ResponsableNombresClass

            selectedItem = CType(comboboxSolicitudResponsableTipo.SelectedItem, ListasResponsables.ResponsableNombresClass)
            If selectedItem.IDResponsableTipo <> CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
                If selectedItem.IDPersona.HasValue Then
                    controlpersonaSolicitud.AsignarValores(selectedItem.IDPersona.Value, selectedItem.PersonaMatriculaNumero, selectedItem.PersonaApellidoNombre)
                Else
                    textboxSolicitudPersonaTexto.Text = selectedItem.PersonaApellidoNombre
                End If
            End If
        End If
    End Sub

    Private Sub HabilitarObtenerTextos(sender As Object, e As EventArgs) Handles checkboxObtenerTextos.CheckedChanged
        comboboxSancionMotivo.Visible = checkboxObtenerTextos.Checked
        buttonAplicarTextos.Visible = checkboxObtenerTextos.Checked
    End Sub

    Private Sub AplicarTextos(sender As Object, e As EventArgs) Handles buttonAplicarTextos.Click
        If comboboxSancionMotivo.SelectedIndex > -1 Then
            If MessageBox.Show("¿Confirma que desea copiar los textos del motivo de sanción seleccionado?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If
            Dim sancionMotivo As SancionMotivo

            sancionMotivo = CType(comboboxSancionMotivo.SelectedItem, SancionMotivo)
            textboxSolicitudMotivo.Text = sancionMotivo.Nombre
            textboxEncuadreTexto.Text = sancionMotivo.Encuadre
            textboxTestimonioTexto.Text = sancionMotivo.Testimonio
        End If
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxSolicitudPersonaTexto.GotFocus, textboxSolicitudMotivo.GotFocus, textboxEncuadreTexto.GotFocus, textboxTestimonioTexto.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub radiobuttonEstadoDesaprobada_CheckedChanged(sender As Object, e As EventArgs) Handles radiobuttonEstadoDesaprobada.CheckedChanged
        labelDesaprobadaCausa.Visible = radiobuttonEstadoDesaprobada.Checked AndAlso Not mVistaDesdeUnaPersona
        textboxDesaprobadaCausa.Visible = radiobuttonEstadoDesaprobada.Checked AndAlso Not mVistaDesdeUnaPersona
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Not mVistaDesdeUnaPersona Then
            If Permisos.VerificarPermiso(Permisos.SANCION_EDITAR) Then
                mEditMode = True
                ChangeMode()
            End If
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If Not VerificarDatos() Then
            Return
        End If

        ' Generar el ID nuevo
        If mPersonaSancionActual.IDSancion = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                Dim PersonaActual As Persona
                PersonaActual = dbcMaxID.Persona.Find(controlpersonaAplicar.IDPersona.Value)
                If PersonaActual.PersonaSanciones.Any() Then
                    mPersonaSancionActual.IDSancion = PersonaActual.PersonaSanciones.Max(Function(pl) pl.IDSancion) + CByte(1)
                Else
                    mPersonaSancionActual.IDSancion = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mPersonaSancionActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mPersonaSancionActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista de Sanciones para mostrar los cambios
                If mVistaDesdeUnaPersona Then
                    formPersona.Sanciones_RefreshData(mPersonaSancionActual.IDSancion)
                Else
                    If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formSanciones") Then
                        Dim formSanciones As formSanciones = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formSanciones"), formSanciones)
                        formSanciones.RefreshData(mPersonaSancionActual.IDPersona, mPersonaSancionActual.IDSancion)
                        formSanciones = Nothing
                    End If
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Sanción con los mismos datos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                End Select
                Exit Sub

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Exit Sub
            End Try
        End If

        Me.Close()
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        If Not controlpersonaAplicar.IDPersona.HasValue Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar a quién aplica la Sanción.", MsgBoxStyle.Information, My.Application.Info.Title)
            controlpersonaAplicar.Focus()
            Return False
        End If
        If Not controlpersonaSolicitud.IDPersona.HasValue Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar quién solicita la Sanción.", MsgBoxStyle.Information, My.Application.Info.Title)
            controlpersonaSolicitud.Focus()
            Return False
        End If
        If textboxSolicitudMotivo.Text.Trim.Length = 0 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Motivo de la Sanción.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxSolicitudMotivo.Focus()
            Return False
        End If
        If Not (radiobuttonEstadoEnProceso.Checked Or radiobuttonEstadoAprobada.Checked Or radiobuttonEstadoDesaprobada.Checked) Then
            tabcontrolMain.SelectedTab = tabpageResolucion
            MsgBox("Debe especificar el Estado de la Sanción.", MsgBoxStyle.Information, My.Application.Info.Title)
            Return False
        End If

        ' Verifico que la Persona que solicita la Sanción tenga especificado el Cargo y la Jerarquía
        If mIsNew Or mPersonaSancionActual.SolicitudIDPersona <> controlpersonaSolicitud.IDPersona.Value Then
            Dim PersonaAscensoUltimo As PersonaAscenso
            PersonaAscensoUltimo = mdbContext.PersonaAscenso.Where(Function(pa) pa.IDPersona = controlpersonaSolicitud.IDPersona.Value).OrderByDescending(Function(pa) pa.Fecha).FirstOrDefault()
            If PersonaAscensoUltimo Is Nothing Then
                Me.Cursor = Cursors.Default
                MsgBox("La Persona que solicita la Sanción no tiene especificado el Cargo y la Jerarquía.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Return False
            End If
            PersonaAscensoUltimo = Nothing
        End If

        Return True
    End Function

#End Region

End Class