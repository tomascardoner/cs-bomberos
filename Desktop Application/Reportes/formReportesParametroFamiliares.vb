Public Class formReportesParametroFamiliares
    Friend Class Familiares_GridRowData
        Public Property IDFamiliar As Byte
        Public Property ParentescoNombre As String
        Public Property Apellido As String
        Public Property Nombre As String
    End Class

    Private MultiSeleccion As Boolean = False

    Friend Sub SetAppearance(ByVal idPersona As Integer, ByVal apellidoNombre As String)
        textboxPersona.Text = apellidoNombre

        DataGridSetAppearance(datagridviewMain)
        RefreshData(idPersona)
    End Sub

    Friend Sub EstablecerMultiseleccion(ByVal valor As Boolean)
        Multiseleccion = valor

        datagridviewMain.MultiSelect = Multiseleccion
    End Sub

    Friend Sub RefreshData(ByVal idPersona As Integer)
        Dim listFamiliares As List(Of Familiares_GridRowData)

        Me.Cursor = Cursors.WaitCursor

        Try

            Using dbContext As New CSBomberosContext(True)
                listFamiliares = (From pf In dbContext.PersonaFamiliar
                                  Group Join p In dbContext.Parentesco On pf.IDParentesco Equals p.IDParentesco Into Parentescos_Group = Group
                                  From pg In Parentescos_Group.DefaultIfEmpty
                                  Where pf.IDPersona = idPersona
                                  Order By pg.Orden, pf.ApellidoNombre
                                  Select New Familiares_GridRowData With {.IDFamiliar = pf.IDFamiliar, .ParentescoNombre = If(pg Is Nothing, My.Resources.STRING_ITEM_NOT_SPECIFIED, pg.Nombre), .Apellido = pf.Apellido, .Nombre = pf.Nombre}).ToList
            End Using
            datagridviewMain.AutoGenerateColumns = False
            datagridviewMain.DataSource = listFamiliares

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Familiares.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                buttonAceptar.PerformClick()
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                buttonCancelar.PerformClick()
        End Select
    End Sub

    Private Sub Seleccionar() Handles datagridviewMain.DoubleClick, buttonAceptar.Click
        If MultiSeleccion And datagridviewMain.SelectedRows.Count = 0 Then
            MsgBox("No se seleccionó ningún Familiar.", vbInformation, My.Application.Info.Title)
        ElseIf MultiSeleccion = False And datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Familiar para seleccionar.", vbInformation, My.Application.Info.Title)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub Cancelar(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class