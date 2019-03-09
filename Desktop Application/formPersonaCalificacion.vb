Public Class formPersonaCalificacion

#Region "Declarations"
    Friend Class GridRowData
        Public Property IDCalificacionConcepto As Byte
        Public Property ConceptoAbreviaturaNombre As String
        Public Property Calificacion As Decimal
    End Class

    Private mdbContext As New CSBomberosContext(True)
    Private mlistPersonaCalificacion As List(Of PersonaCalificacion)
    Private mlistGridRowData As List(Of GridRowData)

    Private mIsLoading As Boolean = False
    Private mIsNew As Boolean
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer, ByVal Anio As Short, ByVal InstanciaNumero As Byte)
        mIsNew = (Anio = 0)
        mIsLoading = True
        mEditMode = EditMode

        If mIsNew Then
            ' Es Nuevo
            mlistPersonaCalificacion = New List(Of PersonaCalificacion)
            For Each CalificacionConceptoActual In mdbContext.CalificacionConcepto.Where(Function(cc) cc.EsActivo).OrderBy(Function(cc) cc.Orden).ToList
                Dim PersonaCalificacionActual As New PersonaCalificacion
                With PersonaCalificacionActual
                    .IDPersona = IDPersona

                    .IDCalificacionConcepto = CalificacionConceptoActual.IDCalificacionConcepto
                    .IDUsuarioCreacion = pUsuario.IDUsuario
                    .FechaHoraCreacion = Now
                    .IDUsuarioModificacion = pUsuario.IDUsuario
                    .FechaHoraModificacion = .FechaHoraCreacion
                End With
                mlistPersonaCalificacion.Add(PersonaCalificacionActual)
                mdbContext.PersonaCalificacion.Add(PersonaCalificacionActual)
            Next
        Else
            mlistPersonaCalificacion = mdbContext.PersonaCalificacion.Where(Function(pc) pc.IDPersona = IDPersona And pc.Anio = Anio And pc.InstanciaNumero = InstanciaNumero).OrderBy(Function(pc) pc.CalificacionConcepto.Orden).ToList
        End If

        Me.MdiParent = pFormMDIMain
        CS_Form.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()
        Me.Show()
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Focus()

        mIsLoading = False

        ChangeMode()
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Exit Sub
        End If

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        maskedtextboxAnio.ReadOnly = Not (mIsNew And mEditMode)
        maskedtextboxInstanciaNumero.ReadOnly = Not (mIsNew And mEditMode)

        datagridviewCalificaciones.ReadOnly = Not mEditMode
        columnConcepto.ReadOnly = True
        If mEditMode Then
            datagridviewCalificaciones.SelectionMode = DataGridViewSelectionMode.CellSelect
        Else
            datagridviewCalificaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
    End Sub

    Friend Sub InitializeFormAndControls()
        If CS_Parameter_System.GetIntegerAsByte(Parametros.PERSONA_CALIFICACION_INSTANCIA_CANTIDAD, 1) < 10 Then
            maskedtextboxInstanciaNumero.Mask = "9"
        Else
            maskedtextboxInstanciaNumero.Mask = "99"
        End If

        SetAppearance()
    End Sub

    Friend Sub SetAppearance()
        DataGridSetAppearance(datagridviewCalificaciones)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mlistPersonaCalificacion = Nothing
        mlistGridRowData = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        mlistGridRowData = (From pc In mlistPersonaCalificacion
                            Join cc In mdbContext.CalificacionConcepto On pc.IDCalificacionConcepto Equals cc.IDCalificacionConcepto
                            Order By cc.Orden
                            Select New GridRowData With {.IDCalificacionConcepto = cc.IDCalificacionConcepto, .ConceptoAbreviaturaNombre = If(cc.Abreviatura Is Nothing, cc.Nombre, cc.Abreviatura.TrimEnd & " - " & cc.Nombre), .Calificacion = pc.Calificacion}).ToList

        If mlistPersonaCalificacion.Count > 0 Then
            With mlistPersonaCalificacion.First
                If mIsNew Then
                    maskedtextboxAnio.Text = ""
                    maskedtextboxInstanciaNumero.Text = ""
                Else
                    maskedtextboxAnio.Text = CS_ValueTranslation.FromObjectShortToControlTextBox(.Anio)
                    maskedtextboxInstanciaNumero.Text = CS_ValueTranslation.FromObjectByteToControlTextBox(.InstanciaNumero)
                End If
            End With
        End If

        datagridviewCalificaciones.AutoGenerateColumns = False
        datagridviewCalificaciones.DataSource = mlistGridRowData
    End Sub

    Friend Sub SetDataFromControlsToObject()
        For Each GridRowDataActual As GridRowData In mlistGridRowData
            Dim PersonaCalificacionActual As PersonaCalificacion
            PersonaCalificacionActual = mlistPersonaCalificacion.Find(Function(pc) pc.IDCalificacionConcepto = GridRowDataActual.IDCalificacionConcepto)
            With PersonaCalificacionActual
                .Anio = CS_ValueTranslation.FromControlTextBoxToObjectShort(maskedtextboxAnio.Text).Value
                .InstanciaNumero = CS_ValueTranslation.FromControlTextBoxToObjectByte(maskedtextboxInstanciaNumero.Text).Value
                .Calificacion = GridRowDataActual.Calificacion
            End With
        Next
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

    Private Sub MaskedTextBoxs_GotFocus(sender As Object, e As EventArgs) Handles maskedtextboxAnio.GotFocus, maskedtextboxInstanciaNumero.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
    End Sub

    Private Sub Calificaciones_CellValidating(ByVal sender As Object, ByVal e As DataGridViewCellValidatingEventArgs) Handles datagridviewCalificaciones.CellValidating
        datagridviewCalificaciones.Rows(e.RowIndex).ErrorText = ""

        Dim newDecimal As Decimal

        ' Don't try to validate the 'new row' until finished 
        ' editing since there is not any point in validating its initial value.
        If datagridviewCalificaciones.Rows(e.RowIndex).IsNewRow Then
            Return
        End If

        If e.ColumnIndex = 1 AndAlso Not Decimal.TryParse(e.FormattedValue.ToString(), newDecimal) OrElse newDecimal < 0 OrElse newDecimal > 10 Then
            e.Cancel = True
            datagridviewCalificaciones.Rows(e.RowIndex).ErrorText = "La Calificación debe ser un número decimal entre 0 y 10"
            MsgBox("La Calificación debe ser un número decimal entre 0 y 10.", vbInformation, My.Application.Info.Title)
        End If
    End Sub

    Private Sub Calificaciones_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles datagridviewCalificaciones.DataError
        MsgBox("La Calificación debe ser un número decimal entre 0 y 10.", vbInformation, My.Application.Info.Title)
        e.ThrowException = False
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub Editar() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_CALIFICACION_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub CerrarOCancelar() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub Guardar() Handles buttonGuardar.Click
        ' Año
        If maskedtextboxAnio.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Año.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxAnio.Focus()
            Exit Sub
        End If
        If CInt(maskedtextboxAnio.Text) < 1900 Or CInt(maskedtextboxAnio.Text) > DateAndTime.Now.Year Then
            MsgBox(String.Format("El Año debe ser estar entre {0} y {1}.", 1950, DateAndTime.Now.Year), MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxAnio.Focus()
            Exit Sub
        End If

        ' Instancia Número
        If maskedtextboxInstanciaNumero.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Número de Instancia.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxInstanciaNumero.Focus()
            Exit Sub
        End If
        If CByte(maskedtextboxInstanciaNumero.Text) < 1 Or CByte(maskedtextboxInstanciaNumero.Text) > 20 Then
            MsgBox(String.Format("El Número de Instancia debe ser estar entre 1 y {0}.", CS_Parameter_System.GetIntegerAsByte(Parametros.PERSONA_CALIFICACION_INSTANCIA_CANTIDAD, 1)), MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxInstanciaNumero.Focus()
            Exit Sub
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formPersona.Calificaciones_RefreshData(mlistPersonaCalificacion.First.Anio, mlistPersonaCalificacion.First.InstanciaNumero)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Instancia de Calificación con los mismos datos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                End Select
                Exit Sub

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CS_Error.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Exit Sub
            End Try
        End If

        Me.Close()
    End Sub
#End Region

End Class