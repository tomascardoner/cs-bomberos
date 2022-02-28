Public Class formAcademiaAsistenciaTipo

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mAcademiaAsistenciaTipoActual As AcademiaAsistenciaTipo

    Private mIsLoading As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDAcademiaAsistenciaTipo As Byte)
        mIsLoading = True
        mEditMode = EditMode

        If IDAcademiaAsistenciaTipo = 0 Then
            ' Es Nuevo
            mAcademiaAsistenciaTipoActual = New AcademiaAsistenciaTipo
            With mAcademiaAsistenciaTipoActual
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.AcademiaAsistenciaTipo.Add(mAcademiaAsistenciaTipoActual)
        Else
            mAcademiaAsistenciaTipoActual = mdbContext.AcademiaAsistenciaTipo.Find(IDAcademiaAsistenciaTipo)
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

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mAcademiaAsistenciaTipoActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mAcademiaAsistenciaTipoActual
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            textboxAbreviatura.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Abreviatura)
            checkboxEsPresente.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsPresente)
            updownOrden.Value = CS_ValueTranslation.FromObjectByteToControlUpDown(.Orden)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            If .IDAcademiaAsistenciaTipo = 0 Then
                textboxID.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxID.Text = String.Format(.IDAcademiaAsistenciaTipo.ToString, "G")
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
        With mAcademiaAsistenciaTipoActual
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .Abreviatura = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxAbreviatura.Text)
            .EsPresente = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsPresente.CheckState)
            .Orden = CS_ValueTranslation.FromControlUpDownToObjectByte(updownOrden.Value)

            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
        End With
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNotas.GotFocus, textboxNombre.GotFocus, textboxAbreviatura.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.ACADEMIAASISTENCIATIPO_EDITAR) Then
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
        If mAcademiaAsistenciaTipoActual.IDAcademiaAsistenciaTipo = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.AcademiaAsistenciaTipo.Any() Then
                    mAcademiaAsistenciaTipoActual.IDAcademiaAsistenciaTipo = dbcMaxID.AcademiaAsistenciaTipo.Max(Function(aat) aat.IDAcademiaAsistenciaTipo) + CByte(1)
                Else
                    mAcademiaAsistenciaTipoActual.IDAcademiaAsistenciaTipo = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mAcademiaAsistenciaTipoActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mAcademiaAsistenciaTipoActual.FechaHoraModificacion = Now

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formAcademiaAsistenciaTipos.RefreshData(mAcademiaAsistenciaTipoActual.IDAcademiaAsistenciaTipo)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Tipo de Asistencia a Academias con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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

    Friend Sub PuntajesRefreshData(Optional ByVal PositionIDAcademiaAsistenciaTipoPuntaje As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listPuntajes As List(Of AcademiaAsistenciaTipoPuntaje)

        If RestoreCurrentPosition Then
            If datagridviewPuntajes.CurrentRow Is Nothing Then
                PositionIDAcademiaAsistenciaTipoPuntaje = 0
            Else
                PositionIDAcademiaAsistenciaTipoPuntaje = CType(datagridviewPuntajes.CurrentRow.DataBoundItem, AcademiaAsistenciaTipoPuntaje).IDAcademiaAsistenciaTipoPuntaje
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listPuntajes = mAcademiaAsistenciaTipoActual.AcademiasAsistenciasTipoPuntajes.OrderBy(Function(satp) satp.FechaInicio).ToList()

            datagridviewPuntajes.AutoGenerateColumns = False
            datagridviewPuntajes.DataSource = listPuntajes

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Puntajes del Tipo de Asistencia a Academias.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PositionIDAcademiaAsistenciaTipoPuntaje <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewPuntajes.Rows
                If CType(CurrentRowChecked.DataBoundItem, AcademiaAsistenciaTipoPuntaje).IDAcademiaAsistenciaTipoPuntaje = PositionIDAcademiaAsistenciaTipoPuntaje Then
                    datagridviewPuntajes.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub DetallesAgregar(sender As Object, e As EventArgs) Handles buttonPuntajesAgregar.Click
        Me.Cursor = Cursors.WaitCursor

        formAcademiaAsistenciaTipoPuntaje.LoadAndShow(True, True, Me, mAcademiaAsistenciaTipoActual, 0)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DetallesEditar(sender As Object, e As EventArgs) Handles buttonPuntajesEditar.Click
        If datagridviewPuntajes.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Puntaje del Tipo de Asistencia a Academias para editar.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formAcademiaAsistenciaTipoPuntaje.LoadAndShow(True, True, Me, mAcademiaAsistenciaTipoActual, CType(datagridviewPuntajes.SelectedRows(0).DataBoundItem, AcademiaAsistenciaTipoPuntaje).IDAcademiaAsistenciaTipoPuntaje)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub DetallesEliminar(sender As Object, e As EventArgs) Handles buttonPuntajesEliminar.Click
        If datagridviewPuntajes.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Puntaje del Tipo de Asistencia a Academias para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            Dim Mensaje As String

            Mensaje = String.Format("Se eliminará el Puntaje.{0}{0}Fecha de inicio: {1}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, CType(datagridviewPuntajes.SelectedRows(0).DataBoundItem, AcademiaAsistenciaTipoPuntaje).FechaInicio.ToShortDateString())
            If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                mAcademiaAsistenciaTipoActual.AcademiasAsistenciasTipoPuntajes.Remove(mAcademiaAsistenciaTipoActual.AcademiasAsistenciasTipoPuntajes.First(Function(satp) satp.IDAcademiaAsistenciaTipoPuntaje = CType(datagridviewPuntajes.SelectedRows(0).DataBoundItem, AcademiaAsistenciaTipoPuntaje).IDAcademiaAsistenciaTipoPuntaje))

                PuntajesRefreshData()

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub DetallesVer(sender As Object, e As EventArgs) Handles datagridviewPuntajes.DoubleClick
        If datagridviewPuntajes.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Puntaje del Tipo de Asistencia a Academias para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formAcademiaAsistenciaTipoPuntaje.LoadAndShow(mEditMode, False, Me, mAcademiaAsistenciaTipoActual, CType(datagridviewPuntajes.SelectedRows(0).DataBoundItem, AcademiaAsistenciaTipoPuntaje).IDAcademiaAsistenciaTipoPuntaje)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class