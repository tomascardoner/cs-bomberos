Public Class formOrdenGeneral

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mOrdenGeneralActual As OrdenGeneral

    Private mIsLoading As Boolean
    Private mIsNew As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDOrdenGeneral As Integer)
        mIsLoading = True
        mIsNew = (IDOrdenGeneral = 0)
        mEditMode = EditMode

        If mIsNew Then
            ' Es Nuevo
            mOrdenGeneralActual = New OrdenGeneral
            With mOrdenGeneralActual
                If mdbContext.OrdenGeneral.Any() Then
                    .Numero = mdbContext.OrdenGeneral.Max(Function(og) og.Numero) + CShort(1)
                Else
                    IntegerTextBoxNumero.IntegerValue = 1
                End If
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.OrdenGeneral.Add(mOrdenGeneralActual)
        Else
            mOrdenGeneralActual = mdbContext.OrdenGeneral.Find(IDOrdenGeneral)
        End If

        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()

        mIsLoading = False

        ChangeMode()

        Me.ShowDialog(ParentForm)
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Return
        End If

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = Not mEditMode
        buttonCerrar.Visible = Not mEditMode

        ' General
        IntegerTextBoxNumero.ReadOnly = Not mEditMode
        ButtonNumeroSiguiente.Visible = (mEditMode AndAlso mIsNew)
        NumericUpDownSubNumero.ReadOnly = Not mEditMode
        DateTimePickerFecha.Enabled = mEditMode
        TextBoxDescripcion.ReadOnly = Not mEditMode
        TextBoxPersonal.ReadOnly = Not mEditMode
        ComboBoxCategoria.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        ListasResoluciones.LlenarComboBoxOrdenesGeneralesCategorias(mdbContext, ComboBoxCategoria, False, True, False)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mOrdenGeneralActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mOrdenGeneralActual
            ' Datos de la pestaña General
            CS_ValueTranslation_Syncfusion.FromValueToControl(.Numero, IntegerTextBoxNumero)
            NumericUpDownSubNumero.Value = CS_ValueTranslation.FromObjectByteToControlUpDown(.SubNumero)
            DateTimePickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha)
            TextBoxDescripcion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Descripcion)
            TextBoxPersonal.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Personal)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxCategoria, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IDOrdenGeneralCategoria, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .IDOrdenGeneral = 0 Then
                TextBoxID.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                TextBoxID.Text = String.Format(.IDOrdenGeneral.ToString, "G")
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

        RefreshDataRelacionantes()
        RefreshDataRelacionadas()
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mOrdenGeneralActual
            ' Datos de la pestaña General
            .Numero = CS_ValueTranslation_Syncfusion.FromControlToShort(IntegerTextBoxNumero).Value
            .SubNumero = CS_ValueTranslation.FromControlUpDownToObjectByte(NumericUpDownSubNumero.Value)
            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(DateTimePickerFecha.Value)
            .Descripcion = CS_ValueTranslation.FromControlTextBoxToObjectString(TextBoxDescripcion.Text.TrimAndReduce)
            .Personal = CS_ValueTranslation.FromControlTextBoxToObjectString(TextBoxPersonal.Text.TrimAndReduce)
            .IDOrdenGeneralCategoria = CS_ValueTranslation.FromControlComboBoxToObjectByte(ComboBoxCategoria.SelectedValue)

            ' Datos de la pestaña Notas y Auditoría
            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
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

    Private Sub ButtonNumeroSiguiente_Click(sender As Object, e As EventArgs) Handles ButtonNumeroSiguiente.Click
        Using dbcMaxNumero As New CSBomberosContext(True)
            If dbcMaxNumero.OrdenGeneral.Any() Then
                IntegerTextBoxNumero.IntegerValue = dbcMaxNumero.OrdenGeneral.Max(Function(og) og.Numero) + 1
            Else
                IntegerTextBoxNumero.IntegerValue = 1
            End If
        End Using
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles TextBoxDescripcion.GotFocus, TextBoxPersonal.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.ORDENGENERAL_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If Not VerificarDatos() Then
            Return
        End If

        ' Generar el ID nuevo
        If mOrdenGeneralActual.IDOrdenGeneral = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                If dbcMaxID.OrdenGeneral.Any() Then
                    mOrdenGeneralActual.IDOrdenGeneral = dbcMaxID.OrdenGeneral.Max(Function(og) og.IDOrdenGeneral) + 1
                Else
                    mOrdenGeneralActual.IDOrdenGeneral = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mOrdenGeneralActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mOrdenGeneralActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista de OrdenesGenerales para mostrar los cambios
                If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formOrdenesGenerales") Then
                    Dim formOrdenesGenerales As formOrdenesGenerales = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formOrdenesGenerales"), formOrdenesGenerales)
                    formOrdenesGenerales.RefreshData(mOrdenGeneralActual.IDOrdenGeneral)
                    formOrdenesGenerales = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Órden General con los mismos datos.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                End Select
                Return

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Return
            End Try
        End If

        Me.Close()
    End Sub

#End Region

#Region "Relaciones"

    Friend Class GridRowDataRelacion
        Public Property IDOrdenGeneral As Integer
        Public Property RelacionTipoNombre As String
        Public Property NumeroCompleto As String
        Public Property Fecha As Date?
        Public Property Motivo As String
    End Class

    Friend Sub RefreshDataRelacionantes()
        DataGridViewRelacionantes.AutoGenerateColumns = False
        DataGridViewRelacionantes.DataSource = (From ogr In mOrdenGeneralActual.OrdenesGeneralesRelacionesRelacionadas
                                                Join og In mdbContext.OrdenGeneral On ogr.IDOrdenGeneralRelacionante Equals og.IDOrdenGeneral
                                                Order By og.Numero, og.SubNumero
                                                Select New GridRowDataRelacion With {.IDOrdenGeneral = og.IDOrdenGeneral, .RelacionTipoNombre = ObtenerNombreTipoRelacion(ogr.RelacionTipo, True), .NumeroCompleto = og.NumeroCompleto, .Fecha = og.Fecha, .Motivo = ogr.Motivo}).ToList()
    End Sub

    Friend Sub RefreshDataRelacionadas()
        DataGridViewRelacionadas.AutoGenerateColumns = False
        DataGridViewRelacionadas.DataSource = (From ogr In mOrdenGeneralActual.OrdenesGeneralesRelacionesRelacionantes
                                               Join og In mdbContext.OrdenGeneral On ogr.IDOrdenGeneralRelacionada Equals og.IDOrdenGeneral
                                               Order By og.Numero, og.SubNumero
                                               Select New GridRowDataRelacion With {.IDOrdenGeneral = og.IDOrdenGeneral, .RelacionTipoNombre = ObtenerNombreTipoRelacion(ogr.RelacionTipo, False), .NumeroCompleto = og.NumeroCompleto, .Fecha = og.Fecha, .Motivo = ogr.Motivo}).ToList()
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        Return True
    End Function

    Private Function ObtenerNombreTipoRelacion(tipo As String, relacionante As Boolean) As String
        Select Case tipo
            Case Constantes.OrdenGeneralRelacionTipoDeroga
                If relacionante Then
                    Return Constantes.OrdenGeneralRelacionTipoDerogadaNombre
                Else
                    Return OrdenGeneralRelacionTipoDerogaNombre
                End If
            Case Constantes.OrdenGeneralRelacionTipoModifica
                If relacionante Then
                    Return Constantes.OrdenGeneralRelacionTipoModificadaNombre
                Else
                    Return OrdenGeneralRelacionTipoModificaNombre
                End If
            Case Else
                Return String.Empty
        End Select
    End Function

#End Region

End Class