Public Class formArea

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mAreaActual As Area

    Private mIsLoading As Boolean = False
    Private mIsNew As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDArea As Short)
        mIsLoading = True
        mEditMode = EditMode
        mIsNew = (IDArea = 0)

        If mIsNew Then
            ' Es Nuevo
            mAreaActual = New Area
            With mAreaActual
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Area.Add(mAreaActual)
        Else
            mAreaActual = mdbContext.Area.Find(IDArea)
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

        ' Toolbar
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        ' General
        textboxCodigo.ReadOnly = Not mEditMode
        textboxNombre.ReadOnly = Not mEditMode
        comboboxCuartel.Enabled = mEditMode
        checkboxMostrarEnInventario.Enabled = mEditMode
        checkboxMostrarEnCompras.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Cuartel(comboboxCuartel, False, False)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mAreaActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mAreaActual
            textboxCodigo.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Codigo).TrimEnd
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxCuartel, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDCuartel)
            checkboxMostrarEnInventario.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.MostrarEnInventario)
            checkboxMostrarEnCompras.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.MostrarEnCompras)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            If mIsNew Then
                textboxIDArea.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDArea.Text = String.Format(.IDArea.ToString, "G")
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
        With mAreaActual
            .Codigo = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCodigo.Text)
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .IDCuartel = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCuartel.SelectedValue).Value
            .MostrarEnInventario = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxMostrarEnInventario.CheckState)
            .MostrarEnCompras = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxMostrarEnCompras.CheckState)

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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxCodigo.GotFocus, textboxNombre.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub
#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.AREA_EDITAR) Then
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
        If comboboxCuartel.SelectedIndex = -1 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe ingresar especificar el Cuartel.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuartel.Focus()
            Exit Sub
        End If

        If Not mIsNew Then
            ' Si se cambió la opción de Mostrar en Inventario, se debe verificar que no haya Items con este Área
            If mAreaActual.MostrarEnInventario AndAlso checkboxMostrarEnInventario.Checked = False Then
                If mAreaActual.Inventario.Any() Then
                    MsgBox("No se puede dejar de Mostrar en Inventario porque hay ítems que hacen referencia a este Área.", MsgBoxStyle.Information, My.Application.Info.Title)
                    Exit Sub
                End If
            End If
            ' Si se cambió la opción de Mostrar en Compras, se debe verificar que no haya Compras con este Área
            If mAreaActual.MostrarEnCompras AndAlso checkboxMostrarEnCompras.Checked = False Then
                If mAreaActual.CompraOrdenDetalles.Any() Then
                    MsgBox("No se puede dejar de Mostrar en Compras porque hay Detalles que hacen referencia a este Área.", MsgBoxStyle.Information, My.Application.Info.Title)
                    Exit Sub
                End If
            End If
        End If

        ' Generar el ID nuevo
        If mIsNew Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.Area.Any() Then
                    mAreaActual.IDArea = dbcMaxID.Area.Max(Function(a) a.IDArea) + CByte(1)
                Else
                    mAreaActual.IDArea = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mAreaActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mAreaActual.FechaHoraModificacion = Now

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formAreas.RefreshData(mAreaActual.IDArea)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Área con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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

End Class