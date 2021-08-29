Public Class formSiniestro

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mSiniestroActual As Siniestro

    Private mIsLoading As Boolean = False
    Private mIsNew As Boolean = False
    Private mEditMode As Boolean = False

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDSiniestro As Integer)
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
                    .Clave = CStr(formSiniestros.comboboxClave.ComboBox.SelectedValue)
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

        CS_Form.CenterToParent(ParentForm, Me)
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

        '  Toolbar
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)
        buttonImprimir.Visible = (mEditMode = False)

        ' General
        comboboxCuartel.Enabled = (mEditMode And (mIsNew Or Not mSiniestroActual.SiniestroAsistencias.Any()))
        maskedtextboxNumeroPrefijo.ReadOnly = Not mEditMode
        maskedtextboxNumero.ReadOnly = Not mEditMode
        buttonCodigoSiguiente.Visible = mEditMode
        datetimepickerFecha.Enabled = mEditMode
        comboboxSiniestroRubro.Enabled = mEditMode
        comboboxSiniestroTipo.Enabled = mEditMode
        textboxSiniestroTipoOtro.ReadOnly = Not mEditMode
        comboboxClave.Enabled = mEditMode
        datetimepickerHoraSalida.Enabled = mEditMode
        datetimepickerHoraFin.Enabled = mEditMode
        checkboxAnulado.Enabled = mEditMode

        ' Asistencias
        toolstripAsistencias.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Cuartel(comboboxCuartel, False, False)
        Siniestros.LlenarComboBoxRubros(mdbContext, comboboxSiniestroRubro, False, False)
        Siniestros.LlenarComboBoxClaves(comboboxClave, False, False)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.IMAGE_SINIESTRO_32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mSiniestroActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mSiniestroActual
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxCuartel, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDCuartel)
            maskedtextboxNumeroPrefijo.Text = .NumeroPrefijo
            maskedtextboxNumero.Text = .Numero
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxSiniestroRubro, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, .IDSiniestroRubro)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxSiniestroTipo, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, .IDSiniestroTipo)
            textboxSiniestroTipoOtro.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.SiniestroTipoOtro)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxClave, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .Clave, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_STRING)
            datetimepickerHoraSalida.Value = CS_ValueTranslation.FromObjectTimeSpanToControlDateTimePicker(.HoraSalida, datetimepickerHoraSalida)
            datetimepickerHoraFin.Value = CS_ValueTranslation.FromObjectTimeSpanToControlDateTimePicker(.HoraFin, datetimepickerHoraFin)
            checkboxAnulado.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Anulado)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
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
            .Clave = CS_ValueTranslation.FromControlComboBoxToObjectString(comboboxClave.SelectedValue)
            .HoraSalida = CS_ValueTranslation.FromControlDateTimePickerToObjectTimeSpan(datetimepickerHoraSalida.Value, datetimepickerHoraSalida.Checked)
            .HoraFin = CS_ValueTranslation.FromControlDateTimePickerToObjectTimeSpan(datetimepickerHoraFin.Value, datetimepickerHoraFin.Checked)
            .Anulado = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxAnulado.CheckState)

            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
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

    Private Sub buttonCodigoSiguiente_Click(sender As Object, e As EventArgs) Handles buttonCodigoSiguiente.Click
        If comboboxCuartel.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Cuartel .", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuartel.Focus()
            Exit Sub
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
            Siniestros.LlenarComboBoxTipos(mdbContext, comboboxSiniestroTipo, CType(comboboxSiniestroRubro.SelectedItem, SiniestroRubro).IDSiniestroRubro, False, False)
        End If
    End Sub

    Private Sub SiniestroTipoCambio(sender As Object, e As EventArgs) Handles comboboxSiniestroTipo.SelectedIndexChanged
        If comboboxSiniestroTipo.SelectedIndex > -1 Then
            Dim siniestroTipoActual As SiniestroTipo

            siniestroTipoActual = CType(comboboxSiniestroTipo.SelectedItem, SiniestroTipo)

            labelSiniestroTipoOtro.Visible = (siniestroTipoActual.IDSiniestroTipo = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE)
            textboxSiniestroTipoOtro.Visible = (siniestroTipoActual.IDSiniestroTipo = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE)
            If siniestroTipoActual.ClavePredeterminada <> Nothing Then
                CardonerSistemas.ComboBox.SetSelectedValue(comboboxClave, CardonerSistemas.ComboBox.SelectedItemOptions.Value, siniestroTipoActual.ClavePredeterminada)
            End If
        Else
            labelSiniestroTipoOtro.Visible = False
            textboxSiniestroTipoOtro.Visible = False
        End If
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Not Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR) Then
            Exit Sub
        End If

        mEditMode = True
        ChangeMode()
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        If mdbContext.ChangeTracker.HasChanges Then
            If MsgBox(String.Format("Ha realizado cambios en los datos y seleccionó cancelar, los cambios se perderán.{0}{0}¿Confirma la pérdida de los cambios?", vbCrLf), CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If comboboxCuartel.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Cuartel.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuartel.Focus()
            Exit Sub
        End If
        If maskedtextboxNumeroPrefijo.Text.Length = 0 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe ingresar el Prefijo del Número.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxNumeroPrefijo.Focus()
            Exit Sub
        End If
        If maskedtextboxNumero.Text.Length = 0 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe ingresar el Número.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxNumero.Focus()
            Exit Sub
        End If
        If comboboxSiniestroRubro.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Rubro y Tipo de Siniestro.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxSiniestroRubro.Focus()
            Exit Sub
        End If
        If comboboxSiniestroTipo.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Tipo de Siniestro.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxSiniestroTipo.Focus()
            Exit Sub
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
                If CS_Form.MDIChild_IsLoaded(CType(pFormMDIMain, Form), "formSiniestros") Then
                    Dim formSiniestros As formSiniestros = CType(CS_Form.MDIChild_GetInstance(CType(pFormMDIMain, Form), "formSiniestros"), formSiniestros)
                    formSiniestros.RefreshData(mSiniestroActual.IDSiniestro)
                    formSiniestros = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        tabcontrolMain.SelectedTab = tabpageGeneral
                        MsgBox("No se pueden guardar los cambios porque ya existe una Siniestro con el mismo Cuartel y Número.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Case CardonerSistemas.Database.EntityFramework.Errors.PrimaryKeyViolation
                        tabcontrolMain.SelectedTab = tabpageAsistencias
                        MsgBox("No se pueden guardar los cambios porque existe una Asistencia al Siniestro duplicada para una Persona.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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
            listAsistencias = (From sa In mSiniestroActual.SiniestroAsistencias
                               Join p In mdbContext.Persona On sa.IDPersona Equals p.IDPersona
                               Join sat In mdbContext.SiniestroAsistenciaTipo On sa.IDSiniestroAsistenciaTipo Equals sat.IDSiniestroAsistenciaTipo
                               Order By p.ApellidoNombre
                               Select New AsistenciasGridRowData With {.IDPersona = sa.IDPersona, .ApellidoNombre = p.ApellidoNombre, .IDSiniestroAsistenciaTipo = sa.IDSiniestroAsistenciaTipo, .SiniestroAsistenciaTipoNombre = sat.Nombre}).ToList

            datagridviewAsistencias.AutoGenerateColumns = False
            datagridviewAsistencias.DataSource = listAsistencias

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

        formSiniestroAsistencia.LoadAndShow(True, True, Me, mSiniestroActual, 0, comboboxCuartel.Text, maskedtextboxNumeroPrefijo.Text & "-" & maskedtextboxNumero.Text, datetimepickerFecha.Value.ToShortDateString())

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DetallesEditar(sender As Object, e As EventArgs) Handles buttonAsistenciasEditar.Click
        If datagridviewAsistencias.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Asistencia para editar.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formSiniestroAsistencia.LoadAndShow(True, True, Me, mSiniestroActual, CType(datagridviewAsistencias.SelectedRows(0).DataBoundItem, AsistenciasGridRowData).IDPersona, comboboxCuartel.Text, maskedtextboxNumeroPrefijo.Text & "-" & maskedtextboxNumero.Text, datetimepickerFecha.Value.ToShortDateString())

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub DetallesEliminar(sender As Object, e As EventArgs) Handles buttonAsistenciasEliminar.Click
        If datagridviewAsistencias.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Asistencia para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            Dim GridRowDataActual As AsistenciasGridRowData
            Dim Mensaje As String

            GridRowDataActual = CType(datagridviewAsistencias.SelectedRows(0).DataBoundItem, AsistenciasGridRowData)

            Mensaje = String.Format("Se eliminará la Asistencia. Si está por eliminar una Asistencia duplicada de una Persona, tenga en cuenta que se eliminará la primera de la lista, y no necesariemente la que usted seleccionó. Verifique los datos luego de eliminar.{0}{0}Persona: {1}{0}Asistencia: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.ApellidoNombre, GridRowDataActual.SiniestroAsistenciaTipoNombre)
            If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                mSiniestroActual.SiniestroAsistencias.Remove(mSiniestroActual.SiniestroAsistencias.First(Function(sa) sa.IDPersona = GridRowDataActual.IDPersona))

                AsistenciasRefreshData()

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Detalles_Ver(sender As Object, e As EventArgs) Handles datagridviewAsistencias.DoubleClick
        If datagridviewAsistencias.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Asistencia para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formSiniestroAsistencia.LoadAndShow(mEditMode, False, Me, mSiniestroActual, CType(datagridviewAsistencias.SelectedRows(0).DataBoundItem, AsistenciasGridRowData).IDPersona, comboboxCuartel.Text, maskedtextboxNumeroPrefijo.Text & "-" & maskedtextboxNumero.Text, datetimepickerFecha.Value.ToShortDateString())

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class