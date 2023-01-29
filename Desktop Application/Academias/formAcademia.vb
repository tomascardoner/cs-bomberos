Public Class formAcademia

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mAcademiaActual As Academia

    Private mIsLoading As Boolean
    Private mIsNew As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDAcademia As Integer)
        mIsLoading = True
        mEditMode = EditMode

        mIsNew = (IDAcademia = 0)
        If mIsNew Then
            ' Es Nuevo
            mAcademiaActual = New Academia
            With mAcademiaActual
                .Fecha = DateTime.Today

                ' Si hay filtros aplicados en el form principal, uso esos valores como predeterminados
                If formAcademias.comboboxCuartel.SelectedIndex > 0 Then
                    .IDCuartel = CByte(formAcademias.comboboxCuartel.ComboBox.SelectedValue)
                End If
                If formAcademias.comboboxAcademiaTipo.SelectedIndex > 0 Then
                    .IDAcademiaTipo = CByte(formAcademias.comboboxAcademiaTipo.ComboBox.SelectedValue)
                End If

                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Academia.Add(mAcademiaActual)
        Else
            mAcademiaActual = mdbContext.Academia.Find(IDAcademia)
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

        '  Toolbar
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)
        buttonImprimir.Visible = (mEditMode = False)

        ' General
        comboboxCuartel.Enabled = (mEditMode And (mIsNew Or Not mAcademiaActual.AcademiasAsistencias.Any()))
        datetimepickerFecha.Enabled = mEditMode
        comboboxAcademiaTipo.Enabled = mEditMode
        textboxAcademiaTipoOtro.ReadOnly = Not mEditMode

        ' Asistencias
        toolstripAsistencias.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        ListasComunes.LlenarComboBoxCuarteles(mdbContext, comboboxCuartel, False, False)
        ListasAcademias.LlenarComboBoxTipos(mdbContext, comboboxAcademiaTipo, False, False)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageAcademia32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mAcademiaActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mAcademiaActual
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxCuartel, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDCuartel)
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxAcademiaTipo, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IDAcademiaTipo)
            textboxAcademiaTipoOtro.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.AcademiaTipoOtro)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .IDAcademia = 0 Then
                textboxIDAcademia.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDAcademia.Text = String.Format(.IDAcademia.ToString, "G")
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
        With mAcademiaActual
            .IDCuartel = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCuartel.SelectedValue).Value
            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFecha.Value).Value
            .IDAcademiaTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxAcademiaTipo.SelectedValue).Value
            .AcademiaTipoOtro = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxAcademiaTipoOtro.Text)

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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxAcademiaTipoOtro.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub AcademiaTipoCambio(sender As Object, e As EventArgs) Handles comboboxAcademiaTipo.SelectedIndexChanged
        If comboboxAcademiaTipo.SelectedIndex > -1 Then
            Dim siniestroTipoActual As AcademiaTipo

            siniestroTipoActual = CType(comboboxAcademiaTipo.SelectedItem, AcademiaTipo)

            labelAcademiaTipoOtro.Visible = (siniestroTipoActual.IDAcademiaTipo = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE)
            textboxAcademiaTipoOtro.Visible = (siniestroTipoActual.IDAcademiaTipo = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE)
        Else
            labelAcademiaTipoOtro.Visible = False
            textboxAcademiaTipoOtro.Visible = False
        End If
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub Editar() Handles buttonEditar.Click
        If Not Permisos.VerificarPermiso(Permisos.ACADEMIA_EDITAR) Then
            Return
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
            If mdbContext.Academia.Any() Then
                mAcademiaActual.IDAcademia = mdbContext.Academia.Max(Function(s) s.IDAcademia) + 1
            Else
                mAcademiaActual.IDAcademia = 1
            End If
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mAcademiaActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mAcademiaActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formAcademias") Then
                    Dim formAcademias As formAcademias = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formAcademias"), formAcademias)
                    formAcademias.RefreshData(mAcademiaActual.IDAcademia)
                    formAcademias = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        tabcontrolMain.SelectedTab = tabpageGeneral
                        MsgBox("No se pueden guardar los cambios porque ya existe una Academia con el mismo Cuartel y Fecha.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Case CardonerSistemas.Database.EntityFramework.Errors.PrimaryKeyViolation
                        tabcontrolMain.SelectedTab = tabpageAsistencias
                        MsgBox("No se pueden guardar los cambios porque existe una Asistencia a la Academia duplicada para una Persona.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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

        If mIsNew Then
            Try
                mdbContext.AcademiaAgregarAsistenciaDePersonas(mAcademiaActual.IDAcademia, pUsuario.IDUsuario)
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al agregar las asistencias de Licencias y Sanciones a la Academia.")
            End Try
        End If

        Me.Close()
    End Sub

#End Region

#Region "Asistencias"

    Friend Class AsistenciasGridRowData
        Public Property IDPersona As Integer
        Public Property ApellidoNombre As String
        Public Property IDAcademiaAsistenciaTipo As Byte
        Public Property AcademiaAsistenciaTipoNombre As String
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
            listAsistencias = (From sa In mAcademiaActual.AcademiasAsistencias
                               Join p In mdbContext.Persona On sa.IDPersona Equals p.IDPersona
                               Join sat In mdbContext.AcademiaAsistenciaTipo On sa.IDAcademiaAsistenciaTipo Equals sat.IDAcademiaAsistenciaTipo
                               Order By p.ApellidoNombre
                               Select New AsistenciasGridRowData With {.IDPersona = sa.IDPersona, .ApellidoNombre = p.ApellidoNombre, .IDAcademiaAsistenciaTipo = sa.IDAcademiaAsistenciaTipo, .AcademiaAsistenciaTipoNombre = sat.Nombre}).ToList

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
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Asistencias de la Academia.")
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

        formAcademiaAsistencia.LoadAndShow(True, True, Me, mAcademiaActual, 0, CByte(comboboxCuartel.SelectedValue), comboboxCuartel.Text, datetimepickerFecha.Value.ToShortDateString())

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DetallesEditar(sender As Object, e As EventArgs) Handles buttonAsistenciasEditar.Click
        If datagridviewAsistencias.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Asistencia para editar.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formAcademiaAsistencia.LoadAndShow(True, True, Me, mAcademiaActual, CType(datagridviewAsistencias.SelectedRows(0).DataBoundItem, AsistenciasGridRowData).IDPersona, CByte(comboboxCuartel.SelectedValue), comboboxCuartel.Text, datetimepickerFecha.Value.ToShortDateString())

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

            Mensaje = String.Format("Se eliminará la Asistencia. Si está por eliminar una Asistencia duplicada de una Persona, tenga en cuenta que se eliminará la primera de la lista, y no necesariemente la que usted seleccionó. Verifique los datos luego de eliminar.{0}{0}Persona: {1}{0}Asistencia: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.ApellidoNombre, GridRowDataActual.AcademiaAsistenciaTipoNombre)
            If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                mAcademiaActual.AcademiasAsistencias.Remove(mAcademiaActual.AcademiasAsistencias.First(Function(sa) sa.IDPersona = GridRowDataActual.IDPersona))

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

            formAcademiaAsistencia.LoadAndShow(mEditMode, False, Me, mAcademiaActual, CType(datagridviewAsistencias.SelectedRows(0).DataBoundItem, AsistenciasGridRowData).IDPersona, CByte(comboboxCuartel.SelectedValue), comboboxCuartel.Text, datetimepickerFecha.Value.ToShortDateString())

            Me.Cursor = Cursors.Default
        End If
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
        If comboboxAcademiaTipo.SelectedValue Is Nothing Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe especificar el Tipo de Academia.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxAcademiaTipo.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class