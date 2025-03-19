Public Class FormSiniestroVehiculo

#Region "Declarations"

    Private _parentForm As Form
    Private _dbContext As New CSBomberosContext(True)
    Private _siniestro As Siniestro
    Private _idVehiculo As Byte
    Private _siniestroVehiculo As SiniestroVehiculo

    Private _isLoading As Boolean
    Private _parentEditMode As Boolean
    Private _editMode As Boolean
    Private _isNew As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(parentEditMode As Boolean, editMode As Boolean, ByRef parentForm As Form, ByRef siniestro As Siniestro, idVehiculo As Byte)
        _parentForm = parentForm
        _isLoading = True
        _parentEditMode = parentEditMode
        _editMode = editMode
        _isNew = (idVehiculo = 0)

        _siniestro = siniestro
        If _isNew Then
            _siniestroVehiculo = New SiniestroVehiculo
            _siniestro.SiniestroVehiculos.Add(_siniestroVehiculo)
        Else
            _siniestroVehiculo = _siniestro.SiniestroVehiculos.FirstOrDefault(Function(sv) sv.IdVehiculo = idVehiculo)
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

        ComboBoxTipo.Enabled = _editMode
        ComboBoxMarca.Enabled = _editMode
        TextBoxModelo.Enabled = _editMode
        TextBoxDominio.Enabled = _editMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        ListasSiniestros.LlenarComboBoxVehiculoTipos(_dbContext, ComboBoxTipo, False, False)
        ListasSiniestros.LlenarComboBoxVehiculoMarcas(_dbContext, ComboBoxMarca, False, True)
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
        _siniestroVehiculo = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With _siniestroVehiculo
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxTipo, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .IdSiniestroVehiculoTipo)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxMarca, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IdSiniestroVehiculoMarca, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            TextBoxModelo.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Modelo)
            TextBoxDominio.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Dominio)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With _siniestroVehiculo
            .IdSiniestroVehiculoTipo = CS_ValueTranslation.FromControlComboBoxToObjectByte(ComboBoxTipo.SelectedValue).Value
            .IdSiniestroVehiculoMarca = CS_ValueTranslation.FromControlComboBoxToObjectByte(ComboBoxMarca.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            .Modelo = CS_ValueTranslation.FromControlTextBoxToObjectString(TextBoxModelo.Text)
            .Dominio = CS_ValueTranslation.FromControlTextBoxToObjectString(TextBoxDominio.Text)
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

    Private Sub Controls_GotFocus(sender As Object, e As EventArgs) Handles TextBoxModelo.GotFocus, TextBoxDominio.GotFocus
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
            _siniestro.SiniestroVehiculos.Remove(_siniestroVehiculo)
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
            If _siniestro.SiniestroVehiculos.Count = 0 Then
                _siniestroVehiculo.IdVehiculo = 1
            Else
                _siniestroVehiculo.IdVehiculo = Convert.ToByte(_siniestro.SiniestroVehiculos.Max(Function(sd) sd.IdVehiculo) + 1)
            End If
        End If

        ' Refresco la lista para mostrar los cambios
        CType(_parentForm, FormSiniestroV2).VehiculosRefreshData(_siniestroVehiculo.IdVehiculo)

        Close()
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        If ComboBoxTipo.SelectedIndex = -1 Then
            MessageBox.Show("Debe especificar el Tipo.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxTipo.Focus()
            Return False
        End If
        If ComboBoxMarca.SelectedIndex = -1 Then
            MessageBox.Show("Debe especificar la Marca.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxMarca.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class
