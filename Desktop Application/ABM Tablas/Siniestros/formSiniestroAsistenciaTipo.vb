Public Class formSiniestroAsistenciaTipo

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mSiniestroAsistenciaTipoActual As SiniestroAsistenciaTipo

    Private mIsLoading As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDSiniestroAsistenciaTipo As Byte)
        mIsLoading = True
        mEditMode = EditMode

        If IDSiniestroAsistenciaTipo = 0 Then
            ' Es Nuevo
            mSiniestroAsistenciaTipoActual = New SiniestroAsistenciaTipo
            With mSiniestroAsistenciaTipoActual
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.SiniestroAsistenciaTipo.Add(mSiniestroAsistenciaTipoActual)
        Else
            mSiniestroAsistenciaTipoActual = mdbContext.SiniestroAsistenciaTipo.Find(IDSiniestroAsistenciaTipo)
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

        ' Toolbar
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        ' General
        textboxNombre.ReadOnly = Not mEditMode
        textboxAbreviatura.ReadOnly = Not mEditMode
        checkboxEsPresente.Enabled = mEditMode
        checkboxEsAusenciaJustificada.Enabled = mEditMode
        checkboxExcluyeDelTotal.Enabled = mEditMode
        updownOrden.Enabled = mEditMode

        ' Puntajes
        toolstripPuntajes.Enabled = mEditMode

        ' Notas y auditoría
        textboxNotas.ReadOnly = Not mEditMode
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mSiniestroAsistenciaTipoActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mSiniestroAsistenciaTipoActual
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            textboxAbreviatura.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Abreviatura)
            checkboxEsPresente.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsPresente)
            checkboxEsAusenciaJustificada.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsAusenciaJustificada)
            checkboxExcluyeDelTotal.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.ExcluyeDelTotal)
            updownOrden.Value = CS_ValueTranslation.FromObjectByteToControlUpDown(.Orden)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            If .IDSiniestroAsistenciaTipo = 0 Then
                textboxID.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxID.Text = String.Format(.IDSiniestroAsistenciaTipo.ToString, "G")
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

        PuntajesRefreshData()
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mSiniestroAsistenciaTipoActual
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .Abreviatura = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxAbreviatura.Text)
            .EsPresente = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsPresente.CheckState)
            .EsAusenciaJustificada = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsAusenciaJustificada.CheckState)
            .ExcluyeDelTotal = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxExcluyeDelTotal.CheckState)
            .Orden = CS_ValueTranslation.FromControlUpDownToObjectByte(updownOrden.Value)

            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNombre.GotFocus, textboxAbreviatura.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.SINIESTROASISTENCIATIPO_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If textboxNombre.Text.Trim.Length = 0 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe ingresar el Nombre.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxNombre.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mSiniestroAsistenciaTipoActual.IDSiniestroAsistenciaTipo = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.SiniestroAsistenciaTipo.Any() Then
                    mSiniestroAsistenciaTipoActual.IDSiniestroAsistenciaTipo = dbcMaxID.SiniestroAsistenciaTipo.Max(Function(a) a.IDSiniestroAsistenciaTipo) + CByte(1)
                Else
                    mSiniestroAsistenciaTipoActual.IDSiniestroAsistenciaTipo = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mSiniestroAsistenciaTipoActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mSiniestroAsistenciaTipoActual.FechaHoraModificacion = Now

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formSiniestroAsistenciaTipos.RefreshData(mSiniestroAsistenciaTipoActual.IDSiniestroAsistenciaTipo)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Tipo de Asistencia a Siniestros con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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

        Me.Close()
    End Sub

#End Region

#Region "Puntajes"

    Friend Sub PuntajesRefreshData(Optional ByVal PositionFechaInicio As Date = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_DATE, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listPuntajes As List(Of SiniestroAsistenciaTipoPuntaje)

        If RestoreCurrentPosition Then
            If datagridviewPuntajes.CurrentRow Is Nothing Then
                PositionFechaInicio = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_DATE
            Else
                PositionFechaInicio = CType(datagridviewPuntajes.CurrentRow.DataBoundItem, SiniestroAsistenciaTipoPuntaje).FechaInicio
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listPuntajes = mSiniestroAsistenciaTipoActual.SiniestrosAsistenciasTipoPuntajes.OrderBy(Function(satp) satp.FechaInicio).ToList()

            datagridviewPuntajes.AutoGenerateColumns = False
            datagridviewPuntajes.DataSource = listPuntajes

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Puntajes del Tipo de Asistencia a Siniestros.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PositionFechaInicio <> CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_DATE Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewPuntajes.Rows
                If CType(CurrentRowChecked.DataBoundItem, SiniestroAsistenciaTipoPuntaje).FechaInicio = PositionFechaInicio Then
                    datagridviewPuntajes.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub DetallesAgregar(sender As Object, e As EventArgs) Handles buttonPuntajesAgregar.Click
        Me.Cursor = Cursors.WaitCursor

        formSiniestroAsistenciaTipoPuntaje.LoadAndShow(True, True, Me, mSiniestroAsistenciaTipoActual, 0)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DetallesEditar(sender As Object, e As EventArgs) Handles buttonPuntajesEditar.Click
        If datagridviewPuntajes.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Puntaje del Tipo de Asistencia a Siniestros para editar.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formSiniestroAsistenciaTipoPuntaje.LoadAndShow(True, True, Me, mSiniestroAsistenciaTipoActual, CType(datagridviewPuntajes.SelectedRows(0).DataBoundItem, SiniestroAsistenciaTipoPuntaje).IDSiniestroAsistenciaTipoPuntaje)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub DetallesEliminar(sender As Object, e As EventArgs) Handles buttonPuntajesEliminar.Click
        If datagridviewPuntajes.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Puntaje del Tipo de Asistencia a Siniestros para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            Dim Mensaje As String

            Mensaje = String.Format("Se eliminará el Puntaje.{0}{0}Fecha de inicio: {1}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, CType(datagridviewPuntajes.SelectedRows(0).DataBoundItem, SiniestroAsistenciaTipoPuntaje).FechaInicio.ToShortDateString())
            If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                mSiniestroAsistenciaTipoActual.SiniestrosAsistenciasTipoPuntajes.Remove(mSiniestroAsistenciaTipoActual.SiniestrosAsistenciasTipoPuntajes.First(Function(satp) satp.FechaInicio = CType(datagridviewPuntajes.SelectedRows(0).DataBoundItem, SiniestroAsistenciaTipoPuntaje).FechaInicio))

                PuntajesRefreshData()

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub DetallesVer(sender As Object, e As EventArgs) Handles datagridviewPuntajes.DoubleClick
        If datagridviewPuntajes.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Puntaje del Tipo de Asistencia a Siniestros para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formSiniestroAsistenciaTipoPuntaje.LoadAndShow(mEditMode, False, Me, mSiniestroAsistenciaTipoActual, CType(datagridviewPuntajes.SelectedRows(0).DataBoundItem, SiniestroAsistenciaTipoPuntaje).IDSiniestroAsistenciaTipoPuntaje)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class