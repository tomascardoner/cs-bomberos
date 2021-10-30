Public Class formAcademiaAsistenciaTipoPuntaje

#Region "Declarations"

    Private mParentForm As Form
    Private mdbContext As New CSBomberosContext(True)
    Private mAcademiaAsistenciaTipoActual As AcademiaAsistenciaTipo
    Private mAcademiaAsistenciaTipoPuntajeActual As AcademiaAsistenciaTipoPuntaje

    Private mIsLoading As Boolean
    Private mParentEditMode As Boolean
    Private mEditMode As Boolean
    Private mIsNew As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal parentEditMode As Boolean, ByVal editMode As Boolean, ByRef parentForm As Form, ByRef AcademiaAsistenciaTipoActual As AcademiaAsistenciaTipo, ByVal fechaInicio As Date)
        mParentForm = parentForm
        mIsLoading = True
        mParentEditMode = parentEditMode
        mEditMode = editMode
        mIsNew = (fechaInicio = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_DATE)

        mAcademiaAsistenciaTipoActual = AcademiaAsistenciaTipoActual
        If mIsNew Then
            ' Es Nuevo
            mAcademiaAsistenciaTipoPuntajeActual = New AcademiaAsistenciaTipoPuntaje
            mAcademiaAsistenciaTipoPuntajeActual.FechaInicio = DateAndTime.Today
            mAcademiaAsistenciaTipoActual.AcademiasAsistenciasTipoPuntajes.Add(mAcademiaAsistenciaTipoPuntajeActual)
        Else
            mAcademiaAsistenciaTipoPuntajeActual = mAcademiaAsistenciaTipoActual.AcademiasAsistenciasTipoPuntajes.Single(Function(satp) satp.FechaInicio = fechaInicio)
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
        updownPuntaje.Enabled = mEditMode
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
        mAcademiaAsistenciaTipoActual = Nothing
        mAcademiaAsistenciaTipoPuntajeActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mAcademiaAsistenciaTipoPuntajeActual
            datetimepickerFechaInicio.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaInicio)
            updownPuntaje.Value = CS_ValueTranslation.FromObjectByteToControlUpDown(.Puntaje)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mAcademiaAsistenciaTipoPuntajeActual
            If mIsNew Then
                .FechaInicio = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaInicio.Value).Value
            End If
            .Puntaje = CS_ValueTranslation.FromControlUpDownToObjectByte(updownPuntaje.Value, -1).Value
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

    Private Sub UpDowns_Enter(sender As Object, e As EventArgs) Handles updownPuntaje.Enter
        Dim nud As NumericUpDown

        nud = CType(sender, NumericUpDown)
        nud.Select(0, nud.Text.Length)
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
        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Refresco la lista para mostrar los cambios
        CType(mParentForm, formAcademiaAsistenciaTipo).PuntajesRefreshData(mAcademiaAsistenciaTipoPuntajeActual.FechaInicio)

        Me.Close()
    End Sub

#End Region

End Class