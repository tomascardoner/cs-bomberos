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
            mSiniestroAsistenciaTipoPuntajeActual = New SiniestroAsistenciaTipoPuntaje With {
                .FechaInicio = DateAndTime.Today
            }
            mSiniestroAsistenciaTipoActual.SiniestrosAsistenciasTipoPuntajes.Add(mSiniestroAsistenciaTipoPuntajeActual)
        Else
            mSiniestroAsistenciaTipoPuntajeActual = mSiniestroAsistenciaTipoActual.SiniestrosAsistenciasTipoPuntajes.Single(Function(satp) satp.IDSiniestroAsistenciaTipoPuntaje = idSiniestroAsistenciaTipoPuntaje)
        End If

        CardonerSistemas.Forms.CenterToParent(mParentForm, Me)
        InitializeFormAndControls()

        CreateRows()
        FillData()

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

        datagridviewPuntajes.Enabled = mEditMode
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
        mSiniestroAsistenciaTipoActual = Nothing
        mSiniestroAsistenciaTipoPuntajeActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Grid data"

    Friend Function CreateRows() As Boolean
        Dim listClaves As List(Of SiniestroClave)

        datagridviewPuntajes.Visible = False

        Try
            listClaves = mdbContext.SiniestroClave.OrderBy(Function(sc) sc.Orden).ThenBy(Function(sc) sc.Nombre).ToList()

            For Each clave As SiniestroClave In listClaves
                Dim newRowId As Integer
                Dim newRow As New DataGridViewRow()

                newRowId = datagridviewPuntajes.Rows.Add()
                newRow = datagridviewPuntajes.Rows(newRowId)
                With newRow
                    .Cells(columnIDSiniestroClave.Name).Value = clave.IDSiniestroClave
                    .Cells(columnSiniestroClaveNombre.Name).Value = clave.Nombre
                End With
            Next
            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al obtener las Claves de Siniestros.")
            Return False

        Finally
            listClaves = Nothing
            datagridviewPuntajes.Visible = True
        End Try
    End Function

    Private Function FillData() As Boolean
        datetimepickerFechaInicio.Value = mSiniestroAsistenciaTipoPuntajeActual.FechaInicio

        datagridviewPuntajes.Visible = False

        Try
            Dim listPuntajes As List(Of SiniestroAsistenciaTipoPuntajeClave)

            listPuntajes = (From sc In mdbContext.SiniestroClave
                            Join satpc In mdbContext.SiniestroAsistenciaTipoPuntajeClave On sc.IDSiniestroClave Equals satpc.IDSiniestroClave
                            Where satpc.IDSiniestroAsistenciaTipo = mSiniestroAsistenciaTipoPuntajeActual.IDSiniestroAsistenciaTipo And satpc.IDSiniestroAsistenciaTipoPuntaje = mSiniestroAsistenciaTipoPuntajeActual.IDSiniestroAsistenciaTipoPuntaje
                            Order By sc.Orden, sc.Nombre
                            Select satpc).ToList()

            Dim startRowIndex As Integer = 0
            Dim columnName As String

            For Each puntaje As SiniestroAsistenciaTipoPuntajeClave In listPuntajes
                For rowIndex As Integer = startRowIndex To datagridviewPuntajes.RowCount - 1
                    If CInt(datagridviewPuntajes.Rows(rowIndex).Cells(columnIDSiniestroClave.Name).Value) = puntaje.IDSiniestroClave Then
                        datagridviewPuntajes.Rows(rowIndex).Cells(columnPuntaje.Name).Value = puntaje.Puntaje
                        startRowIndex = rowIndex + 1
                    End If
                Next
            Next

            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al obtener los Puntajes.")
            Return False

        Finally
            datagridviewPuntajes.Visible = True
        End Try
    End Function

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

    Private Sub datagridviewPuntajes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles datagridviewPuntajes.CellEndEdit
        Dim stringValue As String
        Dim decimalValue As Decimal

        ' Verifico que el texto ingresado sea un número
        If Not IsNumeric(datagridviewPuntajes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
            datagridviewPuntajes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Nothing
            Exit Sub
        End If

        ' Reemplazo el punto por el separador decimal
        stringValue = datagridviewPuntajes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
        stringValue = stringValue.Replace(".", My.Application.Culture.NumberFormat.NumberDecimalSeparator)

        ' Convierto el valor ingresado a un número decimal
        If Not Decimal.TryParse(stringValue, decimalValue) Then
            datagridviewPuntajes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Nothing
            Exit Sub
        End If

        ' Verifico que el valor esté dentro de los valores permitidos
        If decimalValue < -99.99 Then
            MsgBox("El puntaje debe ser mayor o igual a -99,99.", MsgBoxStyle.Information, My.Application.Info.Title)
            datagridviewPuntajes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Nothing
            Exit Sub
        End If
        If decimalValue > 99.99 Then
            MsgBox("El puntaje debe ser menor a 99,99.", MsgBoxStyle.Information, My.Application.Info.Title)
            datagridviewPuntajes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Nothing
            Exit Sub
        End If

        datagridviewPuntajes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = decimalValue
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

        ' Si es nuevo, asigno un id
        If mIsNew Then
            If mSiniestroAsistenciaTipoActual.SiniestrosAsistenciasTipoPuntajes.Any() Then
                mSiniestroAsistenciaTipoPuntajeActual.IDSiniestroAsistenciaTipoPuntaje = CByte(mSiniestroAsistenciaTipoActual.SiniestrosAsistenciasTipoPuntajes.Max(Function(satp) satp.IDSiniestroAsistenciaTipoPuntaje) + 1)
            Else
                mSiniestroAsistenciaTipoPuntajeActual.IDSiniestroAsistenciaTipoPuntaje = 1
            End If
        End If

        ' Establezco los datos
        mSiniestroAsistenciaTipoPuntajeActual.FechaInicio = datetimepickerFechaInicio.Value
        GuardarCambios()

        ' Refresco la lista para mostrar los cambios
        CType(mParentForm, formSiniestroAsistenciaTipo).PuntajesRefreshData(mSiniestroAsistenciaTipoPuntajeActual.FechaInicio)

        Me.Close()
    End Sub

#End Region

#Region "Extra stuff"

    Private Function BorrarPuntaje(ByVal idSiniestroClave As Byte) As Boolean
        Dim puntajeClave As SiniestroAsistenciaTipoPuntajeClave

        puntajeClave = mSiniestroAsistenciaTipoPuntajeActual.SiniestroAsistenciaTipoPuntajesClave.Where(Function(satpc) satpc.IDSiniestroClave = idSiniestroClave).FirstOrDefault()
        If puntajeClave IsNot Nothing Then
            mSiniestroAsistenciaTipoPuntajeActual.SiniestroAsistenciaTipoPuntajesClave.Remove(puntajeClave)
        End If

        Return True
    End Function

    Private Function AgregarOActualizarPuntaje(ByVal idSiniestroClave As Byte, ByVal puntaje As Decimal) As Boolean
        Try
            Dim puntajeClave As SiniestroAsistenciaTipoPuntajeClave

            puntajeClave = mSiniestroAsistenciaTipoPuntajeActual.SiniestroAsistenciaTipoPuntajesClave.Where(Function(satpc) satpc.IDSiniestroClave = idSiniestroClave).FirstOrDefault()
            If puntajeClave Is Nothing Then
                puntajeClave = New SiniestroAsistenciaTipoPuntajeClave With {
                    .IDSiniestroAsistenciaTipo = mSiniestroAsistenciaTipoActual.IDSiniestroAsistenciaTipo,
                    .IDSiniestroClave = idSiniestroClave,
                    .Puntaje = puntaje
                }
                mSiniestroAsistenciaTipoPuntajeActual.SiniestroAsistenciaTipoPuntajesClave.Add(puntajeClave)
            ElseIf puntajeClave.Puntaje <> puntaje Then
                puntajeClave.Puntaje = puntaje
            End If

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al actualizar el Puntaje.")
            Return False
        End Try

        Return True
    End Function

    Private Function GuardarCambios() As Boolean

        Me.Cursor = Cursors.WaitCursor

        For Each row As DataGridViewRow In datagridviewPuntajes.Rows
            Dim idSiniestroClave As Byte

            idSiniestroClave = CByte(row.Cells(columnIDSiniestroClave.Name).Value)

            If row.Cells(columnPuntaje.Name).Value Is Nothing Then
                If Not BorrarPuntaje(idSiniestroClave) Then
                    Me.Cursor = Cursors.Default
                    Return False
                End If
            Else
                ' Parsear la celda a Decimal
                If Not AgregarOActualizarPuntaje(idSiniestroClave, CDec(row.Cells(columnPuntaje.Name).Value)) Then
                    Me.Cursor = Cursors.Default
                    Return False
                End If
            End If
        Next
        Me.Cursor = Cursors.Default
        Return True
    End Function

#End Region

End Class