Public Class formSiniestroAsistenciaTipoPuntaje

#Region "Declarations"

    Private mParentForm As Form
    Private mdbContext As New CSBomberosContext(True)
    Private mSiniestroAsistenciaTipoActual As SiniestroAsistenciaTipo
    Private mSiniestroAsistenciaTipoPuntajeActual As SiniestroAsistenciaTipoPuntaje

    Private mIsLoading As Boolean
    Private mParentEditMode As Boolean
    Private mEditMode As Boolean
    Private mIsNew As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal parentEditMode As Boolean, ByVal editMode As Boolean, ByRef parentForm As Form, ByRef siniestroAsistenciaTipoActual As SiniestroAsistenciaTipo, ByVal idSiniestroAsistenciaTipoPuntaje As Byte)
        mParentForm = parentForm
        mIsLoading = True
        mParentEditMode = parentEditMode
        mEditMode = editMode
        mIsNew = (idSiniestroAsistenciaTipoPuntaje = 0)

        mSiniestroAsistenciaTipoActual = siniestroAsistenciaTipoActual
        If mIsNew Then
            ' Es Nuevo
            mSiniestroAsistenciaTipoPuntajeActual = New SiniestroAsistenciaTipoPuntaje
            mSiniestroAsistenciaTipoPuntajeActual.FechaInicio = DateAndTime.Today
            mSiniestroAsistenciaTipoActual.SiniestrosAsistenciasTipoPuntajes.Add(mSiniestroAsistenciaTipoPuntajeActual)
        Else
            mSiniestroAsistenciaTipoPuntajeActual = mSiniestroAsistenciaTipoActual.SiniestrosAsistenciasTipoPuntajes.Single(Function(satp) satp.IDSiniestroAsistenciaTipoPuntaje = idSiniestroAsistenciaTipoPuntaje)
        End If

        CS_Form.CenterToParent(mParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()

        mIsLoading = False

        ChangeMode()

        Me.ShowDialog(mParentForm)
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Exit Sub
        End If

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mParentEditMode And mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        datetimepickerFechaInicio.Enabled = mEditMode
        doubletextboxPuntajeClaveVerde.Enabled = mEditMode
        doubletextboxPuntajeClaveAzul.Enabled = mEditMode
        doubletextboxPuntajeClaveNaranja.Enabled = mEditMode
        doubletextboxPuntajeClaveRoja.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.IMAGE_TABLAS_32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mParentForm = Nothing
        mdbContext.Dispose()
        mdbContext = Nothing
        mSiniestroAsistenciaTipoActual = Nothing
        mSiniestroAsistenciaTipoPuntajeActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mSiniestroAsistenciaTipoPuntajeActual
            datetimepickerFechaInicio.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaInicio)
            doubletextboxPuntajeClaveVerde.Text = CS_ValueTranslation.FromObjectDecimalToControlDoubleTextBox(.PuntajeClaveVerde)
            doubletextboxPuntajeClaveAzul.Text = CS_ValueTranslation.FromObjectDecimalToControlDoubleTextBox(.PuntajeClaveAzul)
            doubletextboxPuntajeClaveNaranja.Text = CS_ValueTranslation.FromObjectDecimalToControlDoubleTextBox(.PuntajeClaveNaranja)
            doubletextboxPuntajeClaveRoja.Text = CS_ValueTranslation.FromObjectDecimalToControlDoubleTextBox(.PuntajeClaveRoja)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mSiniestroAsistenciaTipoPuntajeActual
            .FechaInicio = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaInicio.Value).Value
            .PuntajeClaveVerde = CS_ValueTranslation_Syncfusion.FromControlDoubleTextBoxToObjectDecimal(doubletextboxPuntajeClaveVerde.Text).Value
            .PuntajeClaveAzul = CS_ValueTranslation_Syncfusion.FromControlDoubleTextBoxToObjectDecimal(doubletextboxPuntajeClaveAzul.Text).Value
            .PuntajeClaveNaranja = CS_ValueTranslation_Syncfusion.FromControlDoubleTextBoxToObjectDecimal(doubletextboxPuntajeClaveNaranja.Text).Value
            .PuntajeClaveRoja = CS_ValueTranslation_Syncfusion.FromControlDoubleTextBoxToObjectDecimal(doubletextboxPuntajeClaveRoja.Text).Value
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

    Private Sub UpDowns_Enter(sender As Object, e As EventArgs)
        Dim nud As NumericUpDown

        nud = CType(sender, NumericUpDown)
        nud.Select(0, nud.Text.Length)
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
        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Si es nuevo, asigno un id
        If mIsNew Then
            If mSiniestroAsistenciaTipoActual.SiniestrosAsistenciasTipoPuntajes.Any() Then
                mSiniestroAsistenciaTipoPuntajeActual.IDSiniestroAsistenciaTipoPuntaje = CByte(mSiniestroAsistenciaTipoActual.SiniestrosAsistenciasTipoPuntajes.Max(Function(satp) satp.IDSiniestroAsistenciaTipoPuntaje) + 1)
            Else
                mSiniestroAsistenciaTipoPuntajeActual.IDSiniestroAsistenciaTipoPuntaje = 1
            End If
        End If

        ' Refresco la lista para mostrar los cambios
        CType(mParentForm, formSiniestroAsistenciaTipo).PuntajesRefreshData(mSiniestroAsistenciaTipoPuntajeActual.FechaInicio)

        Me.Close()
    End Sub

#End Region

End Class