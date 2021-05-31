Public Class formSiniestroAsistenciaTipoPuntaje

#Region "Declarations"

    Private mParentForm As Form
    Private mdbContext As New CSBomberosContext(True)
    Private mSiniestroAsistenciaTipoActual As SiniestroAsistenciaTipo
    Private mSiniestroAsistenciaTipoPuntajeActual As SiniestroAsistenciaTipoPuntaje

    Private mIsLoading As Boolean = False
    Private mParentEditMode As Boolean = False
    Private mEditMode As Boolean = False
    Private mIsNew As Boolean = False

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal parentEditMode As Boolean, ByVal editMode As Boolean, ByRef parentForm As Form, ByRef siniestroAsistenciaTipoActual As SiniestroAsistenciaTipo, ByVal fechaInicio As Date)
        mParentForm = parentForm
        mIsLoading = True
        mParentEditMode = parentEditMode
        mEditMode = editMode
        mIsNew = (fechaInicio = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_DATE)

        mSiniestroAsistenciaTipoActual = siniestroAsistenciaTipoActual
        If mIsNew Then
            ' Es Nuevo
            mSiniestroAsistenciaTipoPuntajeActual = New SiniestroAsistenciaTipoPuntaje
            mSiniestroAsistenciaTipoPuntajeActual.FechaInicio = DateAndTime.Today
            mSiniestroAsistenciaTipoActual.SiniestrosAsistenciasTipoPuntajes.Add(mSiniestroAsistenciaTipoPuntajeActual)
        Else
            mSiniestroAsistenciaTipoPuntajeActual = mSiniestroAsistenciaTipoActual.SiniestrosAsistenciasTipoPuntajes.Single(Function(satp) satp.FechaInicio = fechaInicio)
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

        datetimepickerFechaInicio.Enabled = (mIsNew And mEditMode)
        updownPuntajeClaveVerde.Enabled = mEditMode
        updownPuntajeClaveAzul.Enabled = mEditMode
        updownPuntajeClaveNaranja.Enabled = mEditMode
        updownPuntajeClaveRoja.Enabled = mEditMode
        updownPorcentajeDescuentoPorSalidaAnticipada.Enabled = mEditMode
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
            updownPuntajeClaveVerde.Value = CS_ValueTranslation.FromObjectByteToControlUpDown(.PuntosClaveVerde)
            updownPuntajeClaveAzul.Value = CS_ValueTranslation.FromObjectByteToControlUpDown(.PuntosClaveAzul)
            updownPuntajeClaveNaranja.Value = CS_ValueTranslation.FromObjectByteToControlUpDown(.PuntosClaveNaranja)
            updownPuntajeClaveRoja.Value = CS_ValueTranslation.FromObjectByteToControlUpDown(.PuntosClaveRoja)
            updownPorcentajeDescuentoPorSalidaAnticipada.Value = CS_ValueTranslation.FromObjectByteToControlUpDown(.PorcentajeDescuentoPorSalidaAnticipada)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mSiniestroAsistenciaTipoPuntajeActual
            If mIsNew Then
                .FechaInicio = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaInicio.Value).Value
            End If
            .PuntosClaveVerde = CS_ValueTranslation.FromControlUpDownToObjectByte(updownPuntajeClaveVerde.Value, -1).Value
            .PuntosClaveAzul = CS_ValueTranslation.FromControlUpDownToObjectByte(updownPuntajeClaveAzul.Value, -1).Value
            .PuntosClaveNaranja = CS_ValueTranslation.FromControlUpDownToObjectByte(updownPuntajeClaveNaranja.Value, -1).Value
            .PuntosClaveRoja = CS_ValueTranslation.FromControlUpDownToObjectByte(updownPuntajeClaveRoja.Value, -1).Value
            .PorcentajeDescuentoPorSalidaAnticipada = CS_ValueTranslation.FromControlUpDownToObjectByte(updownPorcentajeDescuentoPorSalidaAnticipada.Value, -1).Value
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

    Private Sub UpDowns_Enter(sender As Object, e As EventArgs) Handles updownPuntajeClaveVerde.Enter, updownPuntajeClaveAzul.Enter, updownPuntajeClaveNaranja.Enter, updownPuntajeClaveRoja.Enter, updownPorcentajeDescuentoPorSalidaAnticipada.Enter
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

        ' Refresco la lista para mostrar los cambios
        CType(mParentForm, formSiniestroAsistenciaTipo).PuntajesRefreshData(mSiniestroAsistenciaTipoPuntajeActual.FechaInicio)

        Me.Close()
    End Sub

#End Region

End Class