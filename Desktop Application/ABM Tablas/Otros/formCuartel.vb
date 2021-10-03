Public Class formCuartel

#Region "Declarations"
    Private mdbContext As New CSBomberosContext(True)
    Private mCuartelActual As Cuartel

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDCuartel As Byte)
        mIsLoading = True
        mEditMode = EditMode

        If IDCuartel = 0 Then
            ' Es Nuevo
            mCuartelActual = New Cuartel
            With mCuartelActual
                .DomicilioIDProvincia = CS_Parameter_System.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID)
                .DomicilioIDLocalidad = CS_Parameter_System.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID)
                .DomicilioCodigoPostal = CS_Parameter_System.GetString(Parametros.DEFAULT_CODIGOPOSTAL)
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Cuartel.Add(mCuartelActual)
        Else
            mCuartelActual = mdbContext.Cuartel.Find(IDCuartel)
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
        textboxDescripcion.ReadOnly = Not mEditMode
        textboxDomicilioCalle1.ReadOnly = (mEditMode = False)
        textboxDomicilioNumero.ReadOnly = (mEditMode = False)
        textboxDomicilioPiso.ReadOnly = (mEditMode = False)
        textboxDomicilioDepartamento.ReadOnly = (mEditMode = False)
        textboxDomicilioCalle2.ReadOnly = (mEditMode = False)
        textboxDomicilioCalle3.ReadOnly = (mEditMode = False)
        comboboxDomicilioProvincia.Enabled = mEditMode
        comboboxDomicilioLocalidad.Enabled = mEditMode
        textboxDomicilioCodigoPostal.ReadOnly = (mEditMode = False)
        textboxTelefono.ReadOnly = (mEditMode = False)
        textboxCelular.ReadOnly = (mEditMode = False)
        textboxEmail.ReadOnly = (mEditMode = False)

        ' Extras
        maskedtextboxPrefijoSiniestro.ReadOnly = (mEditMode = False)

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Provincia(comboboxDomicilioProvincia, True)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.IMAGE_TABLAS_32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mCuartelActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mCuartelActual
            textboxCodigo.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Codigo).Trim()
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            textboxDescripcion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Descripcion)
            textboxDomicilioCalle1.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioCalle1)
            textboxDomicilioNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioNumero)
            textboxDomicilioPiso.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioPiso)
            textboxDomicilioDepartamento.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioDepartamento)
            textboxDomicilioCalle2.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioCalle2)
            textboxDomicilioCalle3.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioCalle3)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxDomicilioProvincia, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .DomicilioIDProvincia, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxDomicilioLocalidad, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .DomicilioIDLocalidad, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            textboxDomicilioCodigoPostal.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DomicilioCodigoPostal)
            textboxTelefono.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Telefono)
            textboxCelular.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Celular)
            textboxEmail.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Email)

            ' Datos de la pestaña Extras
            maskedtextboxPrefijoSiniestro.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.PrefijoSiniestro)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            If .IDCuartel = 0 Then
                textboxIDCuartel.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDCuartel.Text = String.Format(.IDCuartel.ToString, "G")
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
        With mCuartelActual
            .Codigo = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCodigo.Text)
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .Descripcion = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDescripcion.Text)
            .DomicilioCalle1 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioCalle1.Text)
            .DomicilioNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioNumero.Text)
            .DomicilioPiso = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioPiso.Text)
            .DomicilioDepartamento = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioDepartamento.Text)
            .DomicilioCalle2 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioCalle2.Text)
            .DomicilioCalle3 = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioCalle3.Text)
            .DomicilioIDProvincia = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxDomicilioProvincia.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            .DomicilioIDLocalidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxDomicilioLocalidad.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            .DomicilioCodigoPostal = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioCodigoPostal.Text)
            .Telefono = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxTelefono.Text)
            .Celular = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCelular.Text)
            .Email = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxEmail.Text)

            ' Datos de la pestaña Extras
            .PrefijoSiniestro = CS_ValueTranslation.FromControlTextBoxToObjectString(maskedtextboxPrefijoSiniestro.Text)

            ' Datos de la pestaña Notas y Auditoría
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxCodigo.GotFocus, textboxNombre.GotFocus, textboxDescripcion.GotFocus, textboxDomicilioCalle1.GotFocus, textboxDomicilioNumero.GotFocus, textboxDomicilioPiso.GotFocus, textboxDomicilioDepartamento.GotFocus, textboxDomicilioCalle2.GotFocus, textboxDomicilioCalle3.GotFocus, textboxDomicilioCodigoPostal.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub DomicilioProvincia_Cambio(sender As Object, e As EventArgs) Handles comboboxDomicilioProvincia.SelectedValueChanged
        If comboboxDomicilioProvincia.SelectedValue Is Nothing Then
            pFillAndRefreshLists.Localidad(comboboxDomicilioLocalidad, 0, True)
            comboboxDomicilioLocalidad.SelectedIndex = 0
        Else
            pFillAndRefreshLists.Localidad(comboboxDomicilioLocalidad, CByte(comboboxDomicilioProvincia.SelectedValue), True)
            If CByte(comboboxDomicilioProvincia.SelectedValue) = CS_Parameter_System.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID) Then
                CardonerSistemas.ComboBox.SetSelectedValue(comboboxDomicilioLocalidad, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, CS_Parameter_System.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID))
            End If
        End If
    End Sub

    Private Sub DomicilioLocalidad_Cambio(sender As Object, e As EventArgs) Handles comboboxDomicilioLocalidad.SelectedValueChanged
        If Not comboboxDomicilioLocalidad.SelectedValue Is Nothing Then
            textboxDomicilioCodigoPostal.Text = CType(comboboxDomicilioLocalidad.SelectedItem, Localidad).CodigoPostal.ToString()
        End If
    End Sub
#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.CUARTEL_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If textboxCodigo.Text.Trim.Length = 0 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe ingresar el Código.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxCodigo.Focus()
            Exit Sub
        End If
        If textboxNombre.Text.Trim.Length = 0 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe ingresar el Nombre.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxNombre.Focus()
            Exit Sub
        End If
        If maskedtextboxPrefijoSiniestro.Text.Trim.Length > 0 AndAlso maskedtextboxPrefijoSiniestro.Text.Trim.Length < 4 Then
            tabcontrolMain.SelectedTab = tabpageExtras
            MsgBox("Debe completar el prefijo para nº de siniestros o dejarlo vacío.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxPrefijoSiniestro.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mCuartelActual.IDCuartel = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.Cuartel.Any() Then
                    mCuartelActual.IDCuartel = dbcMaxID.Cuartel.Max(Function(a) a.IDCuartel) + CByte(1)
                Else
                    mCuartelActual.IDCuartel = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mCuartelActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mCuartelActual.FechaHoraModificacion = Now

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formCuarteles.RefreshData(mCuartelActual.IDCuartel)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Cuartel con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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