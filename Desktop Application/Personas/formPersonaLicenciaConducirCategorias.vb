Public Class formPersonaLicenciaConducirCategorias

#Region "Declarations"
    Private mlistLicenciaConducirCategorias As List(Of LicenciaConducirCategoria)
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByRef ParentForm As Form, ByRef PersonaActual As Persona)
        RefreshData()

        Dim StartIndex As Integer = 0
        For Each PersonaLicenciaConducirCategoriaActual In PersonaActual.PersonaLicenciaConducirCategorias
            For Index = StartIndex To checkedlistboxLicenciaConducirCategorias.Items.Count - 1
                If PersonaLicenciaConducirCategoriaActual.IDLicenciaConducirCategoria = CType(checkedlistboxLicenciaConducirCategorias.Items(Index), LicenciaConducirCategoria).IDLicenciaConducirCategoria Then
                    checkedlistboxLicenciaConducirCategorias.SetItemChecked(Index, True)
                End If
            Next
        Next

        Me.ShowDialog(ParentForm)
    End Sub

    Friend Sub SetAppearance()
        checkedlistboxLicenciaConducirCategorias.Font = My.Settings.GridsAndListsFont
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        RefreshData()
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mlistLicenciaConducirCategorias = Nothing
        checkedlistboxLicenciaConducirCategorias.DataSource = Nothing
        checkedlistboxLicenciaConducirCategorias.Dispose()
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"
    Friend Sub RefreshData()

        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSBomberosContext(True)
                mlistLicenciaConducirCategorias = dbContext.LicenciaConducirCategoria.Where(Function(lcc) lcc.EsActivo = True).OrderBy(Function(lcc) lcc.Codigo).ToList

                checkedlistboxLicenciaConducirCategorias.BeginUpdate()

                checkedlistboxLicenciaConducirCategorias.DataSource = mlistLicenciaConducirCategorias
                checkedlistboxLicenciaConducirCategorias.ValueMember = "IDLicenciaConducirCategoria"
                checkedlistboxLicenciaConducirCategorias.DisplayMember = "Codigo"

                checkedlistboxLicenciaConducirCategorias.EndUpdate()
            End Using

        Catch ex As Exception

            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Categorías de Licencia de Conducir.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                buttonGuardar.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                buttonCancelar.PerformClick()
        End Select
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub Guardar() Handles buttonGuardar.Click
        Me.Tag = "SAVE"
        Me.Hide()
    End Sub

    Private Sub buttonCancelar_Click() Handles buttonCancelar.Click
        Me.Tag = "CANCEL"
        Me.Hide()
    End Sub
#End Region

End Class