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

    Friend Sub LoadAndShow(ByVal parentEditMode As Boolean, ByVal editMode As Boolean, ByRef parentForm As Form, ByRef AcademiaAsistenciaTipoActual As AcademiaAsistenciaTipo, ByVal idAcademiaAsistenciaTipoPuntaje As Byte)
        mParentForm = parentForm
        mIsLoading = True
        mParentEditMode = parentEditMode
        mEditMode = editMode
        mIsNew = (idAcademiaAsistenciaTipoPuntaje = 0)

        mAcademiaAsistenciaTipoActual = AcademiaAsistenciaTipoActual
        If mIsNew Then
            ' Es Nuevo
            mAcademiaAsistenciaTipoPuntajeActual = New AcademiaAsistenciaTipoPuntaje With {
                .FechaInicio = DateAndTime.Today
            }
            mAcademiaAsistenciaTipoActual.AcademiasAsistenciasTipoPuntajes.Add(mAcademiaAsistenciaTipoPuntajeActual)
        Else
            mAcademiaAsistenciaTipoPuntajeActual = mAcademiaAsistenciaTipoActual.AcademiasAsistenciasTipoPuntajes.Single(Function(satp) satp.IDAcademiaAsistenciaTipoPuntaje = idAcademiaAsistenciaTipoPuntaje)
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
        doubletextboxPuntaje.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)
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
            doubletextboxPuntaje.Text = CS_ValueTranslation.FromObjectDecimalToControlDoubleTextBox(.Puntaje)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mAcademiaAsistenciaTipoPuntajeActual
            .FechaInicio = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaInicio.Value).Value
            .Puntaje = CS_ValueTranslation_Syncfusion.FromControlDoubleTextBoxToObjectDecimal(doubletextboxPuntaje.Text).Value
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

        ' Si es nuevo, asigno un id
        If mIsNew Then
            If mAcademiaAsistenciaTipoActual.AcademiasAsistenciasTipoPuntajes.Any() Then
                mAcademiaAsistenciaTipoPuntajeActual.IDAcademiaAsistenciaTipoPuntaje = CByte(mAcademiaAsistenciaTipoActual.AcademiasAsistenciasTipoPuntajes.Max(Function(aatp) aatp.IDAcademiaAsistenciaTipoPuntaje) + 1)
            Else
                mAcademiaAsistenciaTipoPuntajeActual.IDAcademiaAsistenciaTipoPuntaje = 1
            End If
        End If

        ' Refresco la lista para mostrar los cambios
        CType(mParentForm, formAcademiaAsistenciaTipo).PuntajesRefreshData(mAcademiaAsistenciaTipoPuntajeActual.IDAcademiaAsistenciaTipoPuntaje)

        Me.Close()
    End Sub

#End Region

End Class