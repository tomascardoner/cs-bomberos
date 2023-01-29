Public Class formAcademiaAsistencia

#Region "Declarations"

    Private mParentForm As Form
    Private mdbContext As New CSBomberosContext(True)
    Private mAcademiaActual As Academia
    Private mIDCuartel As Byte
    Private mCuartelNombre As String
    Private mFecha As String
    Private mAcademiaAsistenciaActual As AcademiaAsistencia

    Private mIsLoading As Boolean
    Private mParentEditMode As Boolean
    Private mEditMode As Boolean
    Private mIsNew As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal parentEditMode As Boolean, ByVal editMode As Boolean, ByRef parentForm As Form, ByRef siniestroActual As Academia, ByVal idPersona As Integer, ByVal idCuartel As Byte, ByVal CuartelNombre As String, ByVal Fecha As String)
        mParentForm = parentForm
        mIsLoading = True
        mParentEditMode = parentEditMode
        mEditMode = editMode
        mIsNew = (idPersona = 0)

        mAcademiaActual = siniestroActual
        mIDCuartel = idCuartel
        mCuartelNombre = CuartelNombre
        mFecha = Fecha
        If mIsNew Then
            CrearNuevoObjeto()
        Else
            mAcademiaAsistenciaActual = mAcademiaActual.AcademiasAsistencias.Single(Function(sa) sa.IDPersona = idPersona)
        End If

        CardonerSistemas.Forms.CenterToParent(mParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()

        mIsLoading = False

        ChangeMode()

        Me.ShowDialog(mParentForm)
    End Sub

    Private Sub CrearNuevoObjeto()
        mAcademiaAsistenciaActual = New AcademiaAsistencia With {
                .IDAsistenciaMetodo = Constantes.AsistenciaMetodoManualId,
                .IDUsuarioCreacion = pUsuario.IDUsuario,
                .FechaHoraCreacion = Now,
                .IDUsuarioModificacion = pUsuario.IDUsuario,
                .FechaHoraModificacion = Now
                }
        mAcademiaActual.AcademiasAsistencias.Add(mAcademiaAsistenciaActual)
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Exit Sub
        End If

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mParentEditMode And mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        controlpersonaPersona.ReadOnlyText = Not mIsNew
        panelAsistencia.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        controlpersonaPersona.dbContext = mdbContext
        controlpersonaPersona.IDCuartel = mIDCuartel

        checkBoxContinuarAlta.Visible = mIsNew

        Dim listAcademiaAsistenciaTipo As List(Of CardonerSistemas.Controls.RadioButton.ValueForList)
        If Permisos.VerificarPermiso(Permisos.ACADEMIAASISTENCIATIPO_MOSTRARTODOS, False) Then
            listAcademiaAsistenciaTipo = (From aat In mdbContext.AcademiaAsistenciaTipo
                                          Where aat.EsActivo
                                          Order By aat.Orden, aat.Nombre
                                          Select New CardonerSistemas.Controls.RadioButton.ValueForList With {.IdValue = CStr(aat.IDAcademiaAsistenciaTipo), .DisplayValue = aat.Nombre}).ToList()
        Else
            listAcademiaAsistenciaTipo = (From aat In mdbContext.AcademiaAsistenciaTipo
                                          Where aat.EsActivo And Not aat.MostrarSegunPermiso
                                          Order By aat.Orden, aat.Nombre
                                          Select New CardonerSistemas.Controls.RadioButton.ValueForList With {.IdValue = CStr(aat.IDAcademiaAsistenciaTipo), .DisplayValue = aat.Nombre}).ToList()
        End If
        CardonerSistemas.Controls.RadioButton.CreateArray(Me, CType(panelAsistencia, Panel), 250, listAcademiaAsistenciaTipo, Nothing, CardonerSistemas.Controls.RadioButton.WidthSizeModes.AutoSizeByTextIndividually, 50, 30, Windows.Forms.Appearance.Button)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageAcademia32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mParentForm = Nothing
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mAcademiaActual = Nothing
        mAcademiaAsistenciaActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mAcademiaAsistenciaActual
            textboxCuartel.Text = mCuartelNombre
            textboxFecha.Text = mFecha

            If mIsNew Then
                controlpersonaPersona.ResetText()
            Else
                controlpersonaPersona.AsignarValores(mAcademiaAsistenciaActual.Persona)
            End If

            CS_ValueTranslation.FromObjectIdValueToControlsArray(panelAsistencia.Controls, .IDAcademiaAsistenciaTipo)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mAcademiaAsistenciaActual
            If mIsNew Then
                .IDPersona = controlpersonaPersona.IDPersona.Value
            End If
            .IDAcademiaAsistenciaTipo = CS_ValueTranslation.FromControlArrayToByte(panelAsistencia.Controls)
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
        If Permisos.VerificarPermiso(Permisos.ACADEMIA_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        If mIsNew Then
            mAcademiaActual.AcademiasAsistencias.Remove(mAcademiaAsistenciaActual)
        End If
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If Not VerificarDatos() Then
            Return
        End If

        mAcademiaAsistenciaActual.IDUsuarioModificacion = pUsuario.IDUsuario
        mAcademiaAsistenciaActual.FechaHoraModificacion = Now

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Refresco la lista para mostrar los cambios
        CType(mParentForm, formAcademia).AsistenciasRefreshData(mAcademiaAsistenciaActual.IDPersona)

        If mIsNew AndAlso checkBoxContinuarAlta.Checked Then
            CrearNuevoObjeto()
            SetDataFromObjectToControls()
        Else
            Me.Close()
        End If
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        Dim academiaAsistencia As AcademiaAsistencia

        If mIsNew Then
            If Not controlpersonaPersona.IDPersona.HasValue Then
                MessageBox.Show("Debe especificar la Persona.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                controlpersonaPersona.Focus()
                Return False
            End If
        End If

        Dim AsistenciaTipoEstablecida As Boolean
        For Each control As Control In panelAsistencia.Controls
            AsistenciaTipoEstablecida = CType(control, RadioButton).Checked
            If AsistenciaTipoEstablecida Then
                Exit For
            End If
        Next
        If Not AsistenciaTipoEstablecida Then
            MessageBox.Show("Debe especificar el tipo de Asistencia.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        ' Verifico si ya tiene una asistencia cargada
        If mIsNew Then
            academiaAsistencia = mAcademiaActual.AcademiasAsistencias.Where(Function(aa) aa.IDPersona = controlpersonaPersona.IDPersona.Value).FirstOrDefault()

            If academiaAsistencia IsNot Nothing Then
                ' Ya hay una asistencia cargada
                If academiaAsistencia.AcademiaAsistenciaTipo.EsPresente Then
                    ' Es una asistencia de presente, se muestra advertencia y no se actualiza
                    MessageBox.Show($"No se puede cargar la asistencia porque la persona ya tiene una asistencia a la academia ({academiaAsistencia.AcademiaAsistenciaTipo.Nombre}).", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                Else
                    ' Es una asistencia de ausente, así que reemplazo la nueva por la existente
                    mAcademiaActual.AcademiasAsistencias.Remove(mAcademiaAsistenciaActual)
                    mAcademiaAsistenciaActual = academiaAsistencia
                End If
            End If
        End If

        Return True
    End Function

#End Region

End Class