Public Class formSiniestro

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mSiniestroActual As Siniestro

    Private mIsLoading As Boolean
    Private mIsNew As Boolean
    Private mEditMode As Boolean
    Private mPermisoEditarBasico As Boolean
    Private mPermisoEditarCompleto As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(EditMode As Boolean, ByRef ParentForm As Form, IDSiniestro As Integer)
        mIsLoading = True
        mEditMode = EditMode

        mIsNew = (IDSiniestro = 0)
        If mIsNew Then
            ' Es Nuevo
            mSiniestroActual = New Siniestro
            With mSiniestroActual
                .Fecha = DateTime.Today

                ' Si hay filtros aplicados en el form principal, uso esos valores como predeterminados
                If formSiniestros.comboboxCuartel.SelectedIndex > 0 Then
                    .IDCuartel = CByte(formSiniestros.comboboxCuartel.ComboBox.SelectedValue)
                End If
                If formSiniestros.comboboxSiniestroRubro.SelectedIndex > 0 Then
                    .IDSiniestroRubro = CByte(formSiniestros.comboboxSiniestroRubro.ComboBox.SelectedValue)
                End If
                If formSiniestros.comboboxSiniestroTipo.SelectedIndex > 0 Then
                    .IDSiniestroTipo = CByte(formSiniestros.comboboxSiniestroTipo.ComboBox.SelectedValue)
                End If
                If formSiniestros.comboboxClave.SelectedIndex > 0 Then
                    .IDSiniestroClave = CByte(formSiniestros.comboboxClave.ComboBox.SelectedValue)
                End If

                .Anulado = False
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Siniestro.Add(mSiniestroActual)
        Else
            mSiniestroActual = mdbContext.Siniestro.Find(IDSiniestro)
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
            Return
        End If

        '  Toolbar
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = Not mEditMode
        buttonCerrar.Visible = Not mEditMode
        buttonImprimir.Visible = Not mEditMode

        ' General
        comboboxCuartel.Enabled = (mEditMode AndAlso (mIsNew OrElse Not mSiniestroActual.SiniestrosAsistencias.Any()))
        maskedtextboxNumeroPrefijo.ReadOnly = Not mEditMode
        maskedtextboxNumero.ReadOnly = Not mEditMode
        buttonCodigoSiguiente.Visible = mEditMode
        datetimepickerFecha.Enabled = mEditMode
        comboboxSiniestroRubro.Enabled = mEditMode
        comboboxSiniestroTipo.Enabled = mEditMode
        textboxSiniestroTipoOtro.ReadOnly = Not mEditMode
        comboboxClave.Enabled = mEditMode
        datetimepickerHoraSalida.Enabled = mEditMode
        buttonHoraFinFinalizar.Visible = (Not mEditMode) AndAlso Not (mPermisoEditarCompleto OrElse mSiniestroActual.HoraFin.HasValue)
        datetimepickerHoraFin.Enabled = (mEditMode AndAlso mPermisoEditarCompleto)
        textboxPersonaFin.Visible = mSiniestroActual.HoraFin.HasValue
        datetimepickerHoraLlegadaUltimoCamion.Enabled = mEditMode
        CheckBoxControlado.Enabled = mEditMode
        labelResumenAsistencias.Visible = Not mEditMode
        datagridviewResumenAsistencias.Visible = Not mEditMode

        ' Asistencias
        toolstripAsistencias.Enabled = (mEditMode AndAlso mPermisoEditarCompleto)

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
        checkboxAnulado.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        ListasComunes.LlenarComboBoxCuarteles(mdbContext, comboboxCuartel, False, False)
        ListasSiniestros.LlenarComboBoxRubros(mdbContext, comboboxSiniestroRubro, False, False)
        ListasSiniestros.LlenarComboBoxClaves(mdbContext, comboboxClave, False, False)

        mPermisoEditarBasico = Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR_BASICO, False)
        mPermisoEditarCompleto = Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR_COMPLETO, False)

        LabelControlado.Visible = mPermisoEditarCompleto
        CheckBoxControlado.Visible = mPermisoEditarCompleto

        If Not mEditMode Then
            ResumenAsistenciasRefreshData()
        End If
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageSiniestro32)

        DataGridSetAppearance(datagridviewResumenAsistencias)
        DataGridSetAppearance(datagridviewAsistencias)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mSiniestroActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mSiniestroActual
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxCuartel, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDCuartel)
            maskedtextboxNumeroPrefijo.Text = .NumeroPrefijo
            maskedtextboxNumero.Text = .Numero
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxSiniestroRubro, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IDSiniestroRubro)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxSiniestroTipo, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IDSiniestroTipo)
            textboxSiniestroTipoOtro.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.SiniestroTipoOtro)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxClave, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .IDSiniestroClave)
            datetimepickerHoraSalida.Value = CS_ValueTranslation.FromObjectTimeSpanToControlDateTimePicker(.HoraSalida, datetimepickerHoraSalida)
            datetimepickerHoraFin.Value = CS_ValueTranslation.FromObjectTimeSpanToControlDateTimePicker(.HoraFin, datetimepickerHoraFin)
            If .HoraFin.HasValue And .IDPersonaFin.HasValue Then
                textboxPersonaFin.Text = .PersonaFin.ApellidoNombre
            Else
                textboxPersonaFin.Text = String.Empty
            End If
            datetimepickerHoraLlegadaUltimoCamion.Value = CS_ValueTranslation.FromObjectTimeSpanToControlDateTimePicker(.HoraLlegadaUltimoCamion, datetimepickerHoraLlegadaUltimoCamion)
            CheckBoxControlado.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Controlado)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxAnulado.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Anulado)
            If .IDSiniestro = 0 Then
                textboxIDSiniestro.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDSiniestro.Text = String.Format(.IDSiniestro.ToString, "G")
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

            AsistenciasRefreshData()
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mSiniestroActual
            .IDCuartel = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCuartel.SelectedValue).Value
            .NumeroPrefijo = maskedtextboxNumeroPrefijo.Text
            .Numero = maskedtextboxNumero.Text
            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFecha.Value).Value
            .IDSiniestroRubro = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxSiniestroRubro.SelectedValue).Value
            .IDSiniestroTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxSiniestroTipo.SelectedValue).Value
            .SiniestroTipoOtro = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxSiniestroTipoOtro.Text)
            .IDSiniestroClave = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxClave.SelectedValue).Value
            .HoraSalida = CS_ValueTranslation.FromControlDateTimePickerToObjectTimeSpan(datetimepickerHoraSalida.Value, datetimepickerHoraSalida.Checked)
            .HoraFin = CS_ValueTranslation.FromControlDateTimePickerToObjectTimeSpan(datetimepickerHoraFin.Value, datetimepickerHoraFin.Checked)
            .HoraLlegadaUltimoCamion = CS_ValueTranslation.FromControlDateTimePickerToObjectTimeSpan(datetimepickerHoraLlegadaUltimoCamion.Value, datetimepickerHoraLlegadaUltimoCamion.Checked)
            .Controlado = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(CheckBoxControlado.CheckState)

            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
            .Anulado = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxAnulado.CheckState)
        End With
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Return)
                If mEditMode Then
                    buttonGuardar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
            Case ChrW(Keys.Escape)
                If mEditMode Then
                    buttonCancelar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
        End Select
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxSiniestroTipoOtro.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub maskedtextboxNumeroPrefijo_LostFocus(sender As Object, e As EventArgs) Handles maskedtextboxNumeroPrefijo.LostFocus
        maskedtextboxNumeroPrefijo.Text = maskedtextboxNumeroPrefijo.Text.PadLeft(Constantes.SINIESTRO_NUMEROPREFIJO_DIGITOS, "0"c)
    End Sub

    Private Sub maskedtextboxNumero_LostFocus(sender As Object, e As EventArgs) Handles maskedtextboxNumero.LostFocus
        maskedtextboxNumero.Text = maskedtextboxNumero.Text.PadLeft(Constantes.SINIESTRO_NUMERO_DIGITOS, "0"c)
    End Sub

    Private Sub CodigoSiguiente_Click(sender As Object, e As EventArgs) Handles buttonCodigoSiguiente.Click
        If comboboxCuartel.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Cuartel .", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuartel.Focus()
            Exit Sub
        End If

        Dim cuartel As Cuartel
        cuartel = CType(comboboxCuartel.SelectedItem, Cuartel)
        If cuartel.PrefijoSiniestro IsNot Nothing Then
            maskedtextboxNumeroPrefijo.Text = cuartel.PrefijoSiniestro
        End If

        If maskedtextboxNumeroPrefijo.Text.Length = 0 Then
            MsgBox("Debe ingresar el Prefijo del Número.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxNumeroPrefijo.Focus()
            Exit Sub
        End If

        Dim idCuartel As Byte = CByte(comboboxCuartel.SelectedValue)
        Dim numeroSiguiente As Integer

        If mdbContext.Siniestro.Any(Function(s) s.IDCuartel = idCuartel) Then
            Dim numeroUltimo As String

            numeroUltimo = mdbContext.Siniestro.Where(Function(s) s.IDCuartel = idCuartel And s.NumeroPrefijo = maskedtextboxNumeroPrefijo.Text).Max(Function(s) s.Numero)
            numeroSiguiente = CInt(numeroUltimo) + 1
        Else
            numeroSiguiente = 1
        End If

        maskedtextboxNumero.Text = numeroSiguiente.ToString().PadLeft(Constantes.SINIESTRO_NUMERO_DIGITOS, "0"c)
    End Sub

    Private Sub SiniestroRubroCambio(sender As Object, e As EventArgs) Handles comboboxSiniestroRubro.SelectedIndexChanged
        If comboboxSiniestroRubro.SelectedIndex >= 0 Then
            ListasSiniestros.LlenarComboBoxTipos(mdbContext, comboboxSiniestroTipo, CType(comboboxSiniestroRubro.SelectedItem, SiniestroRubro).IDSiniestroRubro, False, False)
        End If
    End Sub

    Private Sub SiniestroTipoCambio(sender As Object, e As EventArgs) Handles comboboxSiniestroTipo.SelectedIndexChanged
        If comboboxSiniestroTipo.SelectedIndex > -1 Then
            Dim siniestroTipoActual As SiniestroTipo

            siniestroTipoActual = CType(comboboxSiniestroTipo.SelectedItem, SiniestroTipo)

            labelSiniestroTipoOtro.Visible = (siniestroTipoActual.IDSiniestroTipo = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE)
            textboxSiniestroTipoOtro.Visible = (siniestroTipoActual.IDSiniestroTipo = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE)
            If siniestroTipoActual.IDSiniestroClave.HasValue Then
                CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxClave, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, siniestroTipoActual.IDSiniestroClave)
            End If
        Else
            labelSiniestroTipoOtro.Visible = False
            textboxSiniestroTipoOtro.Visible = False
        End If
    End Sub

    Private Sub FinalizarSiniestro(sender As Object, e As EventArgs) Handles buttonHoraFinFinalizar.Click
        Dim IdSiniestroAsistenciaTipoSalidaAnticipada As Byte
        Dim IdSiniestroAsistenciaTipoPresente As Byte

        IdSiniestroAsistenciaTipoSalidaAnticipada = CS_Parameter_System.GetIntegerAsByte(Parametros.SINIESTRO_ASISTENCIATIPO_SALIDAANTICIPADA_ID, 0)
        If IdSiniestroAsistenciaTipoSalidaAnticipada = 0 Then
            MessageBox.Show("No se puede finalizar y asistir porque no está especificado el ID de asistencia para Salida Anticipada.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        IdSiniestroAsistenciaTipoPresente = CS_Parameter_System.GetIntegerAsByte(Parametros.SINIESTRO_ASISTENCIATIPO_PRESENTE_ID, 0)
        If IdSiniestroAsistenciaTipoPresente = 0 Then
            MessageBox.Show("No se puede finalizar y asistir porque no está especificado el ID de asistencia para Presente.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not (Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR_BASICO, False) OrElse Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR_COMPLETO, False)) Then
            Permisos.MostrarMensajeDeAviso()
            Return
        End If

        Dim finalizar As New formSiniestroFinalizar()
        finalizar.SetInitData(IdSiniestroAsistenciaTipoSalidaAnticipada, IdSiniestroAsistenciaTipoPresente, mdbContext, mSiniestroActual)
        If finalizar.ShowDialog(Me) = DialogResult.Yes Then
            ChangeMode()
            SetDataFromObjectToControls()
            RefreshLists.Siniestros(mSiniestroActual.IDSiniestro)
        End If
        finalizar.Close()
        finalizar = Nothing
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub Editar() Handles buttonEditar.Click
        If Not (Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR_BASICO, False) OrElse Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR_COMPLETO, False)) Then
            Permisos.MostrarMensajeDeAviso()
            Exit Sub
        End If

        mEditMode = True
        ChangeMode()
    End Sub

    Private Sub CerrarOCancelar() Handles buttonCerrar.Click, buttonCancelar.Click
        If mdbContext.ChangeTracker.HasChanges Then
            If MsgBox(String.Format("Ha realizado cambios en los datos y seleccionó cancelar, los cambios se perderán.{0}{0}¿Confirma la pérdida de los cambios?", vbCrLf), CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Guardar() Handles buttonGuardar.Click
        If Not VerificarDatos() Then
            Return
        End If

        ' Generar el ID nuevo
        If mIsNew Then
            If mdbContext.Siniestro.Any() Then
                mSiniestroActual.IDSiniestro = mdbContext.Siniestro.Max(Function(s) s.IDSiniestro) + 1
            Else
                mSiniestroActual.IDSiniestro = 1
            End If
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mSiniestroActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mSiniestroActual.FechaHoraModificacion = Now

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                RefreshLists.Siniestros(mSiniestroActual.IDSiniestro)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        tabcontrolMain.SelectedTab = tabpageGeneral
                        MsgBox("No se pueden guardar los cambios porque ya existe un Siniestro con el mismo Cuartel y Número.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Case CardonerSistemas.Database.EntityFramework.Errors.PrimaryKeyViolation
                        tabcontrolMain.SelectedTab = tabpageAsistencias
                        MsgBox("No se pueden guardar los cambios porque existe una Asistencia al Siniestro duplicada para una Persona.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Case Else
                        CardonerSistemas.ErrorHandler.ProcessError(CType(dbuex, Exception), My.Resources.STRING_ERROR_SAVING_CHANGES)
                End Select
                Exit Sub

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Exit Sub
            End Try
        End If

        If mIsNew AndAlso mSiniestroActual.SiniestroClave.Grupo = Constantes.SINIESTRO_CLAVEGRUPO_ROJA Then
            Try
                mdbContext.SiniestroAgregarAsistenciaDePersonas(mSiniestroActual.IDSiniestro, pUsuario.IDUsuario)
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al agregar las asistencias de Licencias y Sanciones al Siniestro.")
            End Try
        End If

        Me.Close()
    End Sub

#End Region

#Region "Asistencias"

    Friend Class AsistenciasGridRowData
        Public Property IDPersona As Integer
        Public Property ApellidoNombre As String
        Public Property IDSiniestroAsistenciaTipo As Byte
        Public Property SiniestroAsistenciaTipoNombre As String
    End Class

    Friend Sub AsistenciasRefreshData(Optional ByVal PositionIDPersona As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listAsistencias As List(Of AsistenciasGridRowData)

        If RestoreCurrentPosition Then
            If datagridviewAsistencias.CurrentRow Is Nothing Then
                PositionIDPersona = 0
            Else
                PositionIDPersona = CType(datagridviewAsistencias.CurrentRow.DataBoundItem, AsistenciasGridRowData).IDPersona
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listAsistencias = (From sa In mSiniestroActual.SiniestrosAsistencias
                               Join p In mdbContext.Persona On sa.IDPersona Equals p.IDPersona
                               Join sat In mdbContext.SiniestroAsistenciaTipo On sa.IDSiniestroAsistenciaTipo Equals sat.IDSiniestroAsistenciaTipo
                               Order By p.ApellidoNombre
                               Select New AsistenciasGridRowData With {.IDPersona = sa.IDPersona, .ApellidoNombre = p.ApellidoNombre, .IDSiniestroAsistenciaTipo = sa.IDSiniestroAsistenciaTipo, .SiniestroAsistenciaTipoNombre = sat.Nombre}).ToList

            datagridviewAsistencias.AutoGenerateColumns = False
            datagridviewAsistencias.DataSource = listAsistencias

            Select Case listAsistencias.Count
                Case 0
                    statuslabelMain.Text = String.Format("No hay Asistencias para mostrar.")
                Case 1
                    statuslabelMain.Text = String.Format("Se muestra 1 Asistencia.")
                Case Else
                    statuslabelMain.Text = String.Format("Se muestran {0} Asistencias.", listAsistencias.Count)
            End Select

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Asistencias del Siniestro.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PositionIDPersona <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewAsistencias.Rows
                If CType(CurrentRowChecked.DataBoundItem, AsistenciasGridRowData).IDPersona = PositionIDPersona Then
                    datagridviewAsistencias.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub DetallesAgregar(sender As Object, e As EventArgs) Handles buttonAsistenciasAgregar.Click
        Me.Cursor = Cursors.WaitCursor
        formSiniestroAsistencia.LoadAndShow(True, True, Me, mSiniestroActual, 0, CByte(comboboxCuartel.SelectedValue), comboboxCuartel.Text, maskedtextboxNumeroPrefijo.Text & "-" & maskedtextboxNumero.Text, datetimepickerFecha.Value.ToShortDateString())
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DetallesEditar(sender As Object, e As EventArgs) Handles buttonAsistenciasEditar.Click
        If datagridviewAsistencias.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Asistencia para editar.", vbInformation, My.Application.Info.Title)
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        formSiniestroAsistencia.LoadAndShow(True, True, Me, mSiniestroActual, CType(datagridviewAsistencias.SelectedRows(0).DataBoundItem, AsistenciasGridRowData).IDPersona, CByte(comboboxCuartel.SelectedValue), comboboxCuartel.Text, maskedtextboxNumeroPrefijo.Text & "-" & maskedtextboxNumero.Text, datetimepickerFecha.Value.ToShortDateString())
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DetallesEliminar(sender As Object, e As EventArgs) Handles buttonAsistenciasEliminar.Click
        If datagridviewAsistencias.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Asistencia para eliminar.", vbInformation, My.Application.Info.Title)
            Return
        End If
        Dim GridRowDataActual As AsistenciasGridRowData
        Dim Mensaje As String

        GridRowDataActual = CType(datagridviewAsistencias.SelectedRows(0).DataBoundItem, AsistenciasGridRowData)
        Mensaje = String.Format("Se eliminará la Asistencia. Si está por eliminar una Asistencia duplicada de una Persona, tenga en cuenta que se eliminará la primera de la lista, y no necesariemente la que usted seleccionó. Verifique los datos luego de eliminar.{0}{0}Persona: {1}{0}Asistencia: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.ApellidoNombre, GridRowDataActual.SiniestroAsistenciaTipoNombre)
        If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            mSiniestroActual.SiniestrosAsistencias.Remove(mSiniestroActual.SiniestrosAsistencias.First(Function(sa) sa.IDPersona = GridRowDataActual.IDPersona))
            AsistenciasRefreshData()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Detalles_Ver(sender As Object, e As EventArgs) Handles datagridviewAsistencias.DoubleClick
        If datagridviewAsistencias.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Asistencia para ver.", vbInformation, My.Application.Info.Title)
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        formSiniestroAsistencia.LoadAndShow(mEditMode, False, Me, mSiniestroActual, CType(datagridviewAsistencias.SelectedRows(0).DataBoundItem, AsistenciasGridRowData).IDPersona, CByte(comboboxCuartel.SelectedValue), comboboxCuartel.Text, maskedtextboxNumeroPrefijo.Text & "-" & maskedtextboxNumero.Text, datetimepickerFecha.Value.ToShortDateString())
        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "Resumen"

    Public Class ResumenAsistenciasGridRowData
        Public Property AsistenciaTipoNombre As String
        Public Property Cantidad As Integer
    End Class

    Private Sub ResumenAsistenciasRefreshData()
        Dim listResumen As List(Of ResumenAsistenciasGridRowData)

        Me.Cursor = Cursors.WaitCursor

        Try
            listResumen = (From sa In mdbContext.SiniestroAsistencia
                           Join sat In mdbContext.SiniestroAsistenciaTipo On sa.IDSiniestroAsistenciaTipo Equals sat.IDSiniestroAsistenciaTipo
                           Where sa.IDSiniestro = mSiniestroActual.IDSiniestro
                           Group By AsistenciaTipoNombre = sat.Nombre Into sa_group = Group, Count()
                           Select New ResumenAsistenciasGridRowData With {.AsistenciaTipoNombre = AsistenciaTipoNombre, .Cantidad = sa_group.Count}).ToList

            datagridviewResumenAsistencias.AutoGenerateColumns = False
            datagridviewResumenAsistencias.DataSource = listResumen

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Cantidades de Asistencias al Siniestro.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        If comboboxCuartel.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Cuartel.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuartel.Focus()
            Return False
        End If
        If maskedtextboxNumeroPrefijo.Text.Length = 0 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe ingresar el Prefijo del Número.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxNumeroPrefijo.Focus()
            Return False
        End If
        If maskedtextboxNumero.Text.Length = 0 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe ingresar el Número.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxNumero.Focus()
            Return False
        End If
        If comboboxSiniestroRubro.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Rubro y Tipo de Siniestro.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxSiniestroRubro.Focus()
            Return False
        End If
        If comboboxSiniestroTipo.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Tipo de Siniestro.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxSiniestroTipo.Focus()
            Return False
        End If
        If comboboxClave.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar la Clave del Siniestro.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxClave.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class