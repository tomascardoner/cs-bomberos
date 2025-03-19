Public Class FormSiniestroDamnificado

#Region "Declarations"

    Private _parentForm As Form
    Private _dbContext As New CSBomberosContext(True)
    Private _siniestro As Siniestro
    Private _idDamnificado As Byte
    Private _siniestroDamnificado As SiniestroDamnificado

    Private _isLoading As Boolean
    Private _parentEditMode As Boolean
    Private _editMode As Boolean
    Private _isNew As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(parentEditMode As Boolean, editMode As Boolean, ByRef parentForm As Form, ByRef siniestro As Siniestro, idDamnificado As Byte)
        _parentForm = parentForm
        _isLoading = True
        _parentEditMode = parentEditMode
        _editMode = editMode
        _isNew = (idDamnificado = 0)

        _siniestro = siniestro
        If _isNew Then
            _siniestroDamnificado = New SiniestroDamnificado
            _siniestro.SiniestroDamnificados.Add(_siniestroDamnificado)
        Else
            _siniestroDamnificado = _siniestro.SiniestroDamnificados.FirstOrDefault(Function(sd) sd.IdDamnificado = idDamnificado)
        End If

        CardonerSistemas.Forms.CenterToParent(_parentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()

        _isLoading = False

        ChangeMode()

        Me.ShowDialog(_parentForm)
    End Sub

    Private Sub ChangeMode()
        If _isLoading Then
            Return
        End If

        ToolStripButtonGuardar.Visible = _editMode
        ToolStripButtonCancelar.Visible = _editMode
        ToolStripButtonEditar.Visible = _parentEditMode AndAlso Not _editMode
        ToolStripButtonCerrar.Visible = Not _editMode

        ComboBoxGenero.Enabled = _editMode
        TextBoxApellido.Enabled = _editMode
        TextBoxNombre.Enabled = _editMode
        ComboBoxDocumentoTipo.Enabled = _editMode
        TextBoxDocumentoNumero.Enabled = _editMode
        NumericUpDownEdad.Enabled = _editMode
        CheckBoxEsMenor.Enabled = _editMode
        CheckBoxTrasladado.Enabled = _editMode
        ComboBoxEstado.Enabled = _editMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        FillAndRefreshLists.Genero(ComboBoxGenero, True)
        pFillAndRefreshLists.DocumentoTipo(ComboBoxDocumentoTipo, True)
        ListasSiniestros.LlenarComboBoxDamnificadoEstados(_dbContext, ComboBoxEstado, False, True)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageSiniestro32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        _parentForm = Nothing
        If _dbContext IsNot Nothing Then
            _dbContext.Dispose()
            _dbContext = Nothing
        End If
        _siniestro = Nothing
        _siniestroDamnificado = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With _siniestroDamnificado
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxGenero, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .Genero, Constantes.PERSONA_GENERO_NOESPECIFICA)
            TextBoxApellido.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Apellido)
            TextBoxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxDocumentoTipo, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IdDocumentoTipo, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            TextBoxDocumentoNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DocumentoNumero)
            NumericUpDownEdad.Value = CS_ValueTranslation.FromObjectByteToControlUpDown(.Edad)
            CheckBoxEsMenor.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsMenor)
            CheckBoxTrasladado.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Trasladado)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxEstado, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IdSiniestroDaminificadoEstado, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With _siniestroDamnificado
            .Genero = CS_ValueTranslation.FromControlComboBoxToObjectString(ComboBoxGenero.SelectedValue)
            .Apellido = CS_ValueTranslation.FromControlTextBoxToObjectString(TextBoxApellido.Text)
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(TextBoxNombre.Text)
            .IdDocumentoTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(ComboBoxDocumentoTipo.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            .DocumentoNumero = CS_ValueTranslation.FromControlTextBoxToObjectString(TextBoxDocumentoNumero.Text)
            .Edad = CS_ValueTranslation.FromControlUpDownToObjectByte(NumericUpDownEdad.Value)
            .EsMenor = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(CheckBoxEsMenor.CheckState)
            .Trasladado = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(CheckBoxTrasladado.CheckState)
            .IdSiniestroDaminificadoEstado = CS_ValueTranslation.FromControlComboBoxToObjectByte(ComboBoxEstado.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE).Value
        End With
    End Sub

#End Region

#Region "Controls events"

    Private Sub Form_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                If _editMode Then
                    ToolStripButtonGuardar.PerformClick()
                Else
                    ToolStripButtonCerrar.PerformClick()
                End If
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                If _editMode Then
                    ToolStripButtonCancelar.PerformClick()
                Else
                    ToolStripButtonCerrar.PerformClick()
                End If
        End Select
    End Sub

    Private Sub Controls_GotFocus(sender As Object, e As EventArgs) Handles TextBoxApellido.GotFocus, TextBoxNombre.GotFocus, TextBoxDocumentoNumero.GotFocus, NumericUpDownEdad.GotFocus
        Common.SelectAllText(sender)
    End Sub

#End Region

#Region "Main toolbar events"

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEditar.Click
        If Permisos.VerificarPermiso(Permisos.SINIESTRO_EDITAR_COMPLETO) Then
            _editMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub CerrarOCancelar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCerrar.Click, ToolStripButtonCancelar.Click
        If _isNew Then
            _siniestro.SiniestroDamnificados.Remove(_siniestroDamnificado)
        End If
        Close()
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonGuardar.Click
        If Not VerificarDatos() Then
            Return
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If _isNew Then
            If _siniestro.SiniestroDamnificados.Count = 0 Then
                _siniestroDamnificado.IdDamnificado = 1
            Else
                _siniestroDamnificado.IdDamnificado = Convert.ToByte(_siniestro.SiniestroDamnificados.Max(Function(sd) sd.IdDamnificado) + 1)
            End If
        End If

        ' Refresco la lista para mostrar los cambios
        CType(_parentForm, FormSiniestroV2).DamnificadosRefreshData(_siniestroDamnificado.IdDamnificado)

        Close()
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        If ComboBoxGenero.SelectedIndex = -1 Then
            MessageBox.Show("Debe especificar el Género.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxGenero.Focus()
            Return False
        End If
        If ComboBoxEstado.SelectedIndex = -1 Then
            MessageBox.Show("Debe especificar el Estado.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxEstado.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class
