Public Class formReportesParametroFamiliares
    Friend Class Familiares_GridRowData
        Public Property IDFamiliar As Byte
        Public Property ParentescoNombre As String
        Public Property Apellido As String
        Public Property Nombre As String
    End Class

    Private _MultiSeleccion As Boolean
    Private _IdParentesco As Byte?

    Public Sub New(idPersona As Integer, apellidoNombre As String, multiSeleccion As Boolean, idParentesco As Byte?)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        textboxPersona.Text = apellidoNombre

        _MultiSeleccion = multiSeleccion
        _IdParentesco = idParentesco
        datagridviewMain.MultiSelect = _MultiSeleccion
        DataGridSetAppearance(datagridviewMain)
        ReadData(idPersona)
    End Sub

    Private Sub ReadData(ByVal idPersona As Integer)
        Me.Cursor = Cursors.WaitCursor
        Try
            Using dbContext As New CSBomberosContext(True)
                Dim familiares As List(Of Familiares_GridRowData)
                familiares = (From pf In dbContext.PersonaFamiliar
                              Group Join p In dbContext.Parentesco On pf.IDParentesco Equals p.IDParentesco Into Parentescos_Group = Group
                              From pg In Parentescos_Group.DefaultIfEmpty
                              Where pf.IDPersona = idPersona AndAlso (_IdParentesco Is Nothing OrElse pf.IDParentesco = _IdParentesco.Value)
                              Order By pg.Orden, pf.ApellidoNombre
                              Select New Familiares_GridRowData With {.IDFamiliar = pf.IDFamiliar, .ParentescoNombre = If(pg Is Nothing, My.Resources.STRING_ITEM_NOT_SPECIFIED, pg.Nombre), .Apellido = pf.Apellido, .Nombre = pf.Nombre}).ToList()

                datagridviewMain.AutoGenerateColumns = False
                datagridviewMain.DataSource = familiares
            End Using
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Familiares.")
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
        If _MultiSeleccion AndAlso datagridviewMain.SelectedRows.Count = 0 Then
            MsgBox("No se seleccionó ningún Familiar.", vbInformation, My.Application.Info.Title)
        ElseIf Not _MultiSeleccion AndAlso datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Familiar para seleccionar.", vbInformation, My.Application.Info.Title)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub Cancelar(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class