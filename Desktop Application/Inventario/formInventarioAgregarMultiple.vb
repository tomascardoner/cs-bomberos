Public Class formInventarioAgregarMultiple

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mIDCuartel As Byte
    Private mIsLoading As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByRef ParentForm As Form)
        mIsLoading = True

        ' Si hay filtros aplicados en el form principal, uso esos valores como predeterminados
        If formInventario.comboboxCuartel.SelectedIndex > 0 Then
            mIDCuartel = CByte(formInventario.comboboxCuartel.ComboBox.SelectedValue)
        End If

        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()

        mIsLoading = False

        Me.ShowDialog(ParentForm)
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        Using context As New CSBomberosContext(True)
            ListasComunes.LlenarComboBoxCuarteles(context, comboboxCuartel, False, False)
        End Using
        CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxCuartel, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, mIDCuartel)
        pFillAndRefreshLists.ElementoFill(comboboxElemento, False, False)
        pFillAndRefreshLists.ModoAdquisicion(comboboxModoAdquisicion, False, True)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageElemento32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        Me.Dispose()
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                buttonGuardar.PerformClick()
        End Select
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxDescripcionPropia.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub MaskedTextBoxCodigo_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBoxCodigo.GotFocus
        MaskedTextBoxCodigo.SelectAll()
    End Sub

    Private Sub MaskedTextBoxCodigo_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBoxCodigo.LostFocus
        Dim result As Int32

        If Int32.TryParse(MaskedTextBoxCodigo.Text.Trim, result) Then
            MaskedTextBoxCodigo.Text = result.ToString(New String("0"c, 5))
        End If
    End Sub

    Private Sub ObtenerCodigoSiguiente(ender As Object, e As EventArgs) Handles buttonCodigoSiguiente.Click
        If comboboxCuartel.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Cuartel .", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuartel.Focus()
            Exit Sub
        End If
        If comboboxArea.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Area.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxArea.Focus()
            Exit Sub
        End If

        Using dbcMaxCodigo As New CSBomberosContext(True)
            Dim IDArea As Short = CShort(comboboxArea.SelectedValue)

            If dbcMaxCodigo.Inventario.Where(Function(i) i.IDArea = IDArea).Any() Then
                MaskedTextBoxCodigo.Text = CStr(CInt(dbcMaxCodigo.Inventario.Where(Function(i) i.IDArea = IDArea).Max(Function(i) i.Codigo)) + 1).PadLeft(5, "0"c)
            Else
                MaskedTextBoxCodigo.Text = CStr(1).PadLeft(5, "0"c)
            End If
        End Using
    End Sub

    Private Sub CuartelCambio(ender As Object, e As EventArgs) Handles comboboxCuartel.SelectedIndexChanged
        ListasComunes.LlenarComboBoxAreas(mdbContext, comboboxArea, False, False, CByte(comboboxCuartel.SelectedValue), True)
        comboboxArea.SelectedItem = Nothing
        pFillAndRefreshLists.Ubicacion(comboboxUbicacion, False, True, CByte(comboboxCuartel.SelectedValue))
        MaskedTextBoxCodigo.Text = String.Empty
    End Sub

    Private Sub AreaCambio(ender As Object, e As EventArgs) Handles comboboxArea.SelectedIndexChanged
        MaskedTextBoxCodigo.Text = String.Empty
    End Sub

    Private Sub UbicacionCambio(ender As Object, e As EventArgs) Handles comboboxUbicacion.SelectedIndexChanged
        pFillAndRefreshLists.SubUbicacion(comboboxSubUbicacion, False, True, CShort(comboboxUbicacion.SelectedValue))
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub Guardar(ender As Object, e As EventArgs) Handles buttonGuardar.Click
        If Not VerificarDatos() Then
            Return
        End If

        If MessageBox.Show($"Se agregarán {NumericUpDownCantidad.Value} elementos al inventario.{Environment.NewLine}{Environment.NewLine}¿Desea continuar?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        ' Agrego los objetos
        If Not AgregarElementos() Then
            Return
        End If

        Me.Close()
    End Sub

    Private Sub Cancelar(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.Close()
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        If comboboxCuartel.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Cuartel.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCuartel.Focus()
            Return False
        End If
        If comboboxArea.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Area.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxArea.Focus()
            Return False
        End If

        If MaskedTextBoxCodigo.Text.Trim.Length = 0 Then
            MsgBox("Debe especificar el Punto de Venta.", MsgBoxStyle.Information, My.Application.Info.Title)
            MaskedTextBoxCodigo.Focus()
            Return False
        End If
        If Not Int32.TryParse(MaskedTextBoxCodigo.Text.Trim, New Int32) Then
            MsgBox("El Código debe ser un valor numérico.", MsgBoxStyle.Information, My.Application.Info.Title)
            MaskedTextBoxCodigo.Focus()
            Return False
        End If

        If comboboxElemento.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Elemento.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxElemento.Focus()
            Return False
        End If
        If comboboxModoAdquisicion.SelectedValue IsNot Nothing Then
            If CByte(comboboxModoAdquisicion.SelectedValue) = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
                MsgBox("Debe especificar el Modo de Adquisición.", MsgBoxStyle.Information, My.Application.Info.Title)
                comboboxModoAdquisicion.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Friend Function AgregarElementos() As Boolean
        Dim idInventarioNuevoInicial As Integer
        Dim idInventarioNuevo As Integer
        Dim codigoNuevo As Integer

        Me.Cursor = Cursors.WaitCursor

        Try
            ' Obtener el ID nuevo
            If mdbContext.Inventario.Any() Then
                idInventarioNuevoInicial = mdbContext.Inventario.Max(Function(i) i.IDInventario) + 1
            Else
                idInventarioNuevoInicial = 1
            End If

            idInventarioNuevo = idInventarioNuevoInicial
            If Not Integer.TryParse(MaskedTextBoxCodigo.Text.Trim, codigoNuevo) Then
                MsgBox("El Primer Código debe ser un valor numérico.", MsgBoxStyle.Information, My.Application.Info.Title)
                Return False
            End If

            For index = 1 To NumericUpDownCantidad.Value
                mdbContext.Inventario.Add(New Inventario With {
                        .IDInventario = idInventarioNuevo,
                        .IDArea = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxArea.SelectedValue).Value,
                        .Codigo = codigoNuevo.ToString(New String("0"c, 5)),
                        .IDElemento = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxElemento.SelectedValue).Value,
                        .DescripcionPropia = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDescripcionPropia.Text),
                        .IDModoAdquisicion = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxModoAdquisicion.SelectedValue),
                        .FechaAdquicision = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaAdquisicion.Value, datetimepickerFechaAdquisicion.Checked),
                        .IDUbicacion = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxUbicacion.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT),
                        .IDSubUbicacion = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxSubUbicacion.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT),
                        .EsActivo = True,
                        .IDUsuarioCreacion = pUsuario.IDUsuario,
                        .FechaHoraCreacion = Now,
                        .IDUsuarioModificacion = pUsuario.IDUsuario,
                        .FechaHoraModificacion = .FechaHoraCreacion})

                idInventarioNuevo += 1
                codigoNuevo += 1
            Next

            ' Guardo los cambios
            mdbContext.SaveChanges()

            ' Refresco la lista para mostrar los cambios
            If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formInventario") Then
                Dim formInventario As formInventario = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formInventario"), formInventario)
                formInventario.RefreshData(idInventarioNuevoInicial)
                formInventario = Nothing
            End If

        Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
            Me.Cursor = Cursors.Default
            Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                    MsgBox("No se pueden guardar los cambios porque ya existe un Elemento en el Inventario con el mismo Código.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
            End Select
            Return False

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
            Return False

        End Try

        Me.Cursor = Cursors.Default

        Return True

    End Function

#End Region

End Class