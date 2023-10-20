Public Class formPersonaLicencia

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)
    Private mPersonaLicenciaActual As PersonaLicencia

    Private mIsLoading As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPersona As Integer, ByVal IDLicencia As Short)
        mIsLoading = True
        mEditMode = EditMode

        If IDLicencia = 0 Then
            ' Es Nuevo
            mPersonaLicenciaActual = New PersonaLicencia
            With mPersonaLicenciaActual
                .IDPersona = IDPersona

                .Fecha = DateTime.Today
                .FechaDesde = DateTime.Today
                .FechaHasta = DateTime.Today
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.PersonaLicencia.Add(mPersonaLicenciaActual)
        Else
            mPersonaLicenciaActual = mdbContext.PersonaLicencia.Find(IDPersona, IDLicencia)
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
        datetimepickerFecha.Enabled = mEditMode
        comboboxCausa.Enabled = mEditMode
        datetimepickerFechaDesde.Enabled = mEditMode
        NumericUpDownDias.Enabled = mEditMode
        datetimepickerFechaHasta.Enabled = mEditMode
        datetimepickerFechaInterrupcion.Enabled = mEditMode

        ' Notas y Auditoría
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        pFillAndRefreshLists.LicenciaCausa(comboboxCausa, False, False)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mPersonaLicenciaActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mPersonaLicenciaActual
            datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Fecha)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxCausa, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDLicenciaCausa)
            datetimepickerFechaDesde.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaDesde)
            NumericUpDownDias.Value = CalcularDiasEfectivos(.FechaDesde, .FechaHasta)
            datetimepickerFechaHasta.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaHasta)
            datetimepickerFechaInterrupcion.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaInterrupcion, datetimepickerFechaInterrupcion)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            If .IDLicencia = 0 Then
                textboxIDLicencia.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDLicencia.Text = String.Format(.IDLicencia.ToString, "G")
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
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mPersonaLicenciaActual
            .Fecha = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFecha.Value).Value
            .IDLicenciaCausa = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCausa.SelectedValue).Value
            .FechaDesde = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaDesde.Value).Value
            .FechaHasta = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaHasta.Value).Value
            .FechaInterrupcion = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaInterrupcion.Value, datetimepickerFechaInterrupcion.Checked)

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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub Causa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxCausa.SelectedIndexChanged
        CalcularFechaHasta()
    End Sub

    Private Sub FechaDesde_ValueChanged(sender As Object, e As EventArgs) Handles datetimepickerFechaDesde.ValueChanged
        CalcularFechaHasta()
        MostrarDiasEfectivos()
    End Sub

    Private Sub NumericUpDownDias_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownDias.ValueChanged
        datetimepickerFechaHasta.Value = datetimepickerFechaDesde.Value.AddDays(NumericUpDownDias.Value - 1)
    End Sub

    Private Sub Fechas_ValueChanged(sender As Object, e As EventArgs) Handles datetimepickerFechaHasta.ValueChanged, datetimepickerFechaInterrupcion.ValueChanged
        MostrarDiasEfectivos()
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.PERSONA_LICENCIA_EDITAR) Then
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
        If mPersonaLicenciaActual.IDLicencia = 0 Then
            Using dbcMaxID As New CSBomberosContext(True)
                Dim PersonaActual As Persona
                PersonaActual = dbcMaxID.Persona.Find(mPersonaLicenciaActual.IDPersona)
                If PersonaActual.PersonaLicencias.Any() Then
                    mPersonaLicenciaActual.IDLicencia = PersonaActual.PersonaLicencias.Max(Function(pl) pl.IDLicencia) + CShort(1)
                Else
                    mPersonaLicenciaActual.IDLicencia = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor
            mPersonaLicenciaActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mPersonaLicenciaActual.FechaHoraModificacion = Now

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formPersona.Licencias_RefreshData(mPersonaLicenciaActual.IDLicencia)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Licencia con la misma Fecha.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                End Select
                Exit Sub

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Return
            End Try
        End If

        Me.Close()
    End Sub

#End Region

#Region "Extra stuff"

    Private Function CalcularDiasEfectivos(fechaDesde As Date, fechaHasta As Date, Optional fechaInterrupcion As Date? = Nothing) As Long
        Return DateDiff(DateInterval.Day, fechaDesde.AddDays(-1), If(fechaInterrupcion, fechaHasta))
    End Function

    Private Function CalcularDiasEfectivos(fechaDesde As DateTimePicker, fechaHasta As DateTimePicker, Optional fechaInterrupcion As DateTimePicker = Nothing) As Long
        If fechaInterrupcion IsNot Nothing AndAlso fechaInterrupcion.Checked Then
            Return CalcularDiasEfectivos(fechaDesde.Value, fechaHasta.Value, fechaInterrupcion.Value)
        Else
            Return CalcularDiasEfectivos(fechaDesde.Value, fechaHasta.Value)
        End If
    End Function

    Private Sub CalcularFechaHasta()
        If comboboxCausa.SelectedIndex > -1 Then
            Dim causa As LicenciaCausa = CType(comboboxCausa.SelectedItem, LicenciaCausa)
            If causa.CantidadDias.HasValue Then
                NumericUpDownDias.Value = causa.CantidadDias.Value
                datetimepickerFechaHasta.Value = datetimepickerFechaDesde.Value.AddDays(causa.CantidadDias.Value - 1)
            End If
        End If
    End Sub

    Private Sub MostrarDiasEfectivos()
        labelDiasEfectivos.Text = CalcularDiasEfectivos(datetimepickerFechaDesde, datetimepickerFechaHasta, datetimepickerFechaInterrupcion).ToString()
    End Sub

    Private Function VerificarDatos() As Boolean
        If comboboxCausa.SelectedValue Is Nothing Then
            MsgBox("Debe especificar la Causa.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCausa.Focus()
            Return False
        End If

        ' Verifico las fechas (Fecha <= Fecha Desde < FechaHasta > FechaInterrupcion)
        If datetimepickerFecha.Value > datetimepickerFechaDesde.Value Then
            MsgBox("La Fecha de Solicitud de la Licencia no puede ser mayor a la Fecha Desde.", MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerFecha.Focus()
            Return False
        End If
        If datetimepickerFechaDesde.Value > datetimepickerFechaHasta.Value Then
            MsgBox("La Fecha Desde no puede ser mayor a la Fecha Hasta.", MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerFechaDesde.Focus()
            Return False
        End If
        If datetimepickerFechaInterrupcion.Checked AndAlso datetimepickerFechaInterrupcion.Value <= datetimepickerFechaDesde.Value Then
            MsgBox("La Fecha de Interrupción no puede ser menor o igual a la Fecha Desde.", MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerFechaInterrupcion.Focus()
            Return False
        End If
        If datetimepickerFechaInterrupcion.Checked AndAlso datetimepickerFechaInterrupcion.Value >= datetimepickerFechaHasta.Value Then
            MsgBox("La Fecha de Interrupción no puede ser mayor o igual a la Fecha Hasta.", MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerFechaInterrupcion.Focus()
            Return False
        End If

        If Not Permisos.VerificarPermiso(Permisos.PERSONA_LICENCIA_IGNORARRESTRICCIONFECHAS, False) Then
            Dim causa As LicenciaCausa = CType(comboboxCausa.SelectedItem, LicenciaCausa)

            If causa.CantidadDias IsNot Nothing AndAlso CalcularDiasEfectivos(datetimepickerFechaDesde.Value, datetimepickerFechaHasta.Value) <> causa.CantidadDias Then
                MessageBox.Show($"La cantidad de días de la Licencia debe ser igual a {causa.CantidadDias}.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                datetimepickerFechaHasta.Focus()
                Return False
            End If

            ' Es una licencia con limitación de cantidad de usos
            If causa.CantidadVecesMaximoTotal.HasValue AndAlso causa.CantidadVecesMaximoTotal.Value > 0 Then
                If mdbContext.PersonaLicencia.Count(Function(pl) pl.IDPersona = mPersonaLicenciaActual.IDPersona AndAlso pl.IDLicenciaCausa = causa.IDLicenciaCausa AndAlso pl.IDLicencia <> mPersonaLicenciaActual.IDLicencia) >= causa.CantidadVecesMaximoTotal Then
                    If causa.CantidadVecesMaximoTotal = 1 Then
                        MessageBox.Show($"Sólo se puede cargar 1 Licencia con esta causa.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        MessageBox.Show($"Sólo se pueden cargar {causa.CantidadVecesMaximoTotal} Licencias con esta causa.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                    comboboxCausa.Focus()
                    Return False
                End If
            End If

            ' Si corresponde, controlo la cantidad de días y veces anuales
            If Not (causa.CantidadDiasMaximoAnual Is Nothing AndAlso causa.CantidadVecesMaximoAnual IsNot Nothing) Then
                Dim dictPersonaLicenciaAniosDias As New Dictionary(Of Integer, Short)
                Dim dictPersonaLicenciaAniosVeces As New Dictionary(Of Integer, Byte)

                ' En primer lugar, tomo los datos de la Licencia actual y genero las entradas correpondientes a cada
                ' año en los diccionarios
                dictPersonaLicenciaAniosDias.Add(datetimepickerFechaDesde.Value.Year, 0)
                dictPersonaLicenciaAniosVeces.Add(datetimepickerFechaDesde.Value.Year, 0)
                If datetimepickerFechaDesde.Value.Year <> datetimepickerFechaHasta.Value.Year Then
                    If dictPersonaLicenciaAniosDias.ContainsKey(datetimepickerFechaHasta.Value.Year) Then
                        dictPersonaLicenciaAniosDias.Add(datetimepickerFechaHasta.Value.Year, 0)
                        dictPersonaLicenciaAniosVeces.Add(datetimepickerFechaHasta.Value.Year, 0)
                    End If
                End If
                CalcularDiasYVecesAnuales(datetimepickerFechaDesde.Value, datetimepickerFechaHasta.Value, dictPersonaLicenciaAniosDias, dictPersonaLicenciaAniosVeces)

                ' Obtengo todas las licencias del mismo tipo y que tengan el o los años en común
                ' para verificar la cantidad de días y veces anuales
                For Each PersonaLicenciaActual As PersonaLicencia In mdbContext.PersonaLicencia.Where(Function(pl) pl.IDPersona = mPersonaLicenciaActual.IDPersona AndAlso pl.IDLicenciaCausa = causa.IDLicenciaCausa AndAlso pl.IDLicencia <> mPersonaLicenciaActual.IDLicencia AndAlso (pl.FechaHasta.Year >= datetimepickerFechaDesde.Value.Year AndAlso pl.FechaDesde.Year <= datetimepickerFechaHasta.Value.Year))
                    CalcularDiasYVecesAnuales(PersonaLicenciaActual.FechaDesde, PersonaLicenciaActual.FechaHasta, dictPersonaLicenciaAniosDias, dictPersonaLicenciaAniosVeces)
                Next

                If causa.CantidadDiasMaximoAnual IsNot Nothing Then
                    For Each AnioDias As KeyValuePair(Of Integer, Short) In dictPersonaLicenciaAniosDias
                        If AnioDias.Value > causa.CantidadDiasMaximoAnual AndAlso MsgBox($"La cantidad de días excede al máximo anual para el tipo de Licencia.{vbCrLf}{vbCrLf}¿Desea corregir las fechas?", CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                            Return False
                        End If
                    Next
                End If

                If causa.CantidadVecesMaximoAnual IsNot Nothing Then
                    For Each AnioDias As KeyValuePair(Of Integer, Byte) In dictPersonaLicenciaAniosVeces
                        If AnioDias.Value > causa.CantidadVecesMaximoAnual AndAlso MsgBox($"La cantidad de veces excede al máximo anual para el tipo de Licencia.{vbCrLf}{vbCrLf}¿Desea corregir las fechas?", CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                            Return False
                        End If
                    Next
                End If
            End If
        End If

        Return True
    End Function

    Private Shared Sub CalcularDiasYVecesAnuales(ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByRef dictPersonaLicenciaAniosDias As Dictionary(Of Integer, Short), ByRef dictPersonaLicenciaAniosVeces As Dictionary(Of Integer, Byte))
        Select Case FechaDesde.Year - FechaHasta.Year
            Case 0
                ' Ambas fechas son del mismo año
                dictPersonaLicenciaAniosDias(FechaDesde.Year) += Convert.ToInt16(DateAndTime.DateDiff(DateInterval.Day, FechaDesde, FechaHasta))
                dictPersonaLicenciaAniosVeces(FechaDesde.Year) += Convert.ToByte(1)

            Case 1
                ' Las fechas son de años consecutivos
                ' Verifico que el año esté contemplado en la Licencia Actual
                If dictPersonaLicenciaAniosDias.ContainsKey(FechaDesde.Year) Then
                    dictPersonaLicenciaAniosDias(FechaDesde.Year) += Convert.ToByte(DateAndTime.DateDiff(DateInterval.Day, FechaDesde, New Date(FechaDesde.Year, 12, 31)))
                    dictPersonaLicenciaAniosVeces(FechaDesde.Year) += Convert.ToByte(1)
                End If
                ' Verifico que el año esté contemplado en la Licencia Actual
                If dictPersonaLicenciaAniosDias.ContainsKey(FechaHasta.Year) Then
                    dictPersonaLicenciaAniosDias(FechaHasta.Year) += Convert.ToByte(DateAndTime.DateDiff(DateInterval.Day, New Date(FechaHasta.Year, 1, 1), FechaHasta))
                    dictPersonaLicenciaAniosVeces(FechaHasta.Year) += Convert.ToByte(1)
                End If

            Case Else
                ' Las fechas son de más de 2 años!! WTF!!
                ' Verifico que el año esté contemplado en la Licencia Actual
                If dictPersonaLicenciaAniosDias.ContainsKey(FechaDesde.Year) Then
                    dictPersonaLicenciaAniosDias(FechaDesde.Year) += Convert.ToByte(DateAndTime.DateDiff(DateInterval.Day, FechaDesde, New Date(FechaDesde.Year, 12, 31)))
                    dictPersonaLicenciaAniosVeces(FechaDesde.Year) += Convert.ToByte(1)
                End If
                For Anio As Integer = FechaDesde.Year + 1 To FechaHasta.Year - 1
                    ' Verifico que el año esté contemplado en la Licencia Actual
                    If dictPersonaLicenciaAniosDias.ContainsKey(Anio) Then
                        If DateTime.IsLeapYear(Anio) Then
                            dictPersonaLicenciaAniosDias(Anio) += Convert.ToInt16(366)
                        Else
                            dictPersonaLicenciaAniosDias(Anio) += Convert.ToInt16(365)
                        End If
                        dictPersonaLicenciaAniosVeces(Anio) += Convert.ToByte(1)
                    End If
                Next
                ' Verifico que el año esté contemplado en la Licencia Actual
                If dictPersonaLicenciaAniosDias.ContainsKey(FechaHasta.Year) Then
                    dictPersonaLicenciaAniosDias(FechaHasta.Year) += Convert.ToByte(DateAndTime.DateDiff(DateInterval.Day, New Date(FechaHasta.Year, 1, 1), FechaHasta))
                    dictPersonaLicenciaAniosVeces(FechaHasta.Year) += Convert.ToByte(1)
                End If
        End Select
    End Sub

#End Region

End Class