Public Class formComprobanteAplicacion

#Region "Declarations"

    Private mComprobanteActual As Comprobante
    Private mComprobanteTipoActual As ComprobanteTipo
    Private mComprobanteAplicacionActual As ComprobanteAplicacion

    Private mParentEditMode As Boolean = False
    Private mEditMode As Boolean = False

    Public Class GridRowData_Comprobante
        Public Property IDComprobante As Integer
        Public Property TipoNombre As String
        Public Property NumeroCompleto As String
        Public Property FechaEmision As Date
        Public Property ImporteTotal As Decimal
        Public Property ImporteAplicado As Decimal?
        Public Property ImporteSinAplicar As Decimal?
    End Class

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal ParentEditMode As Boolean, ByVal EditMode As Boolean, ByRef ParentForm As Form, ByRef ComprobanteActual As Comprobante, ByRef ComprobanteTipoActual As ComprobanteTipo, ByRef ComprobanteAplicacionActual As ComprobanteAplicacion)
        mParentEditMode = ParentEditMode
        mEditMode = EditMode

        mComprobanteActual = ComprobanteActual
        mComprobanteTipoActual = ComprobanteTipoActual
        mComprobanteAplicacionActual = ComprobanteAplicacionActual

        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()
        ChangeMode()

        Me.ShowDialog(ParentForm)
    End Sub

    Private Sub ChangeMode()
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mParentEditMode And Not mEditMode)
        buttonCerrar.Visible = Not mEditMode

        currencytextboxImporteAplicado.ReadOnly = (mEditMode = False)
    End Sub

    Friend Sub InitializeFormAndControls()
        ' Cargo los ComboBox
        FillList_Comprobante()
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mComprobanteActual = Nothing
        mComprobanteAplicacionActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub FillList_Comprobante()
        Dim listComprobantes As List(Of GridRowData_Comprobante)

        Using dbContext As New CSBomberosContext(True)
            If mComprobanteTipoActual.OperacionTipo = Constantes.OperacionTipoVenta Then
                listComprobantes = (From c In dbContext.Comprobante
                                    Group Join ca In dbContext.ComprobanteAplicacion On c.IDComprobante Equals ca.IDComprobanteAplicado Into ComprobanteAplicacion_join = Group
                                    From ca In ComprobanteAplicacion_join.DefaultIfEmpty()
                                    Where c.IDEntidad = mComprobanteActual.IDEntidad And c.IDUsuarioAnulacion Is Nothing And c.IDComprobanteTipo <> mComprobanteTipoActual.IDComprobanteTipo And c.ComprobanteTipo.OperacionTipo = mComprobanteTipoActual.OperacionTipo
                                    Group New With {c, c.ComprobanteTipo, ca} By c.IDComprobante, c.ComprobanteTipo.NombreConLetra, c.NumeroCompleto, c.Fecha, c.Importe Into g = Group
                                    Order By Fecha Descending, NumeroCompleto Descending
                                    Select New GridRowData_Comprobante With {.IDComprobante = IDComprobante, .TipoNombre = NombreConLetra, .NumeroCompleto = NumeroCompleto, .FechaEmision = Fecha, .ImporteTotal = Importe, .ImporteAplicado = If(CType(g.Sum(Function(p) p.ca.Importe), Decimal?) Is Nothing, 0, g.Sum(Function(p) p.ca.Importe)), .ImporteSinAplicar = (Importe - If(CType(g.Sum(Function(p) p.ca.Importe), Decimal?) Is Nothing, 0, g.Sum(Function(p) p.ca.Importe)))}).ToList
            Else
                listComprobantes = (From c In dbContext.Comprobante
                                    Group Join ca In dbContext.ComprobanteAplicacion On c.IDComprobante Equals ca.IDComprobanteAplicado Into ComprobanteAplicacion_join = Group
                                    From ca In ComprobanteAplicacion_join.DefaultIfEmpty()
                                    Where c.IDEntidad = mComprobanteActual.IDEntidad And c.IDUsuarioAnulacion Is Nothing And c.IDComprobanteTipo <> mComprobanteTipoActual.IDComprobanteTipo And c.ComprobanteTipo.OperacionTipo = mComprobanteTipoActual.OperacionTipo
                                    Group New With {c, c.ComprobanteTipo, ca} By c.IDComprobante, c.ComprobanteTipo.NombreConLetra, c.NumeroCompleto, c.Fecha, c.Importe Into g = Group
                                    Where (Importe - If(CType(g.Sum(Function(p) p.ca.Importe), Decimal?) Is Nothing, 0, g.Sum(Function(p) p.ca.Importe))) > 0
                                    Order By Fecha Descending, NumeroCompleto Descending
                                    Select New GridRowData_Comprobante With {.IDComprobante = IDComprobante, .TipoNombre = NombreConLetra, .NumeroCompleto = NumeroCompleto, .FechaEmision = Fecha, .ImporteTotal = Importe, .ImporteAplicado = If(CType(g.Sum(Function(p) p.ca.Importe), Decimal?) Is Nothing, 0, g.Sum(Function(p) p.ca.Importe)), .ImporteSinAplicar = (Importe - If(CType(g.Sum(Function(p) p.ca.Importe), Decimal?) Is Nothing, 0, g.Sum(Function(p) p.ca.Importe)))}).ToList
            End If
        End Using

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = listComprobantes
    End Sub

    Friend Sub SetDataFromObjectToControls()
        With mComprobanteAplicacionActual
            'currencytextboxImporteAplicado.Text = CS_ValueTranslation.FromObjectMoneyToControlTextBox(.Importe)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mComprobanteAplicacionActual
            .IDComprobanteAplicado = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData_Comprobante).IDComprobante
            .Importe = currencytextboxImporteAplicado.DecimalValue
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

    Private Sub AplicarComprobante() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow IsNot Nothing Then
            currencytextboxImporteAplicado.DecimalValue = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData_Comprobante).ImporteSinAplicar.Value
        End If
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub Editar() Handles buttonEditar.Click
        mEditMode = True
        ChangeMode()
    End Sub

    Private Sub CerrarOCancelar() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub Guardar() Handles buttonGuardar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Comprobante para aplicar.", vbInformation, My.Application.Info.Title)
            datagridviewMain.Focus()
            Exit Sub
        End If
        If (Not (mComprobanteTipoActual.OperacionTipo = Constantes.OperacionTipoVenta And mComprobanteTipoActual.MovimientoTipo = Constantes.MovimientoTipoCredito)) AndAlso currencytextboxImporteAplicado.DecimalValue <= 0 Then
            MsgBox("El Importe a aplicar debe ser mayor a cero.", MsgBoxStyle.Information, My.Application.Info.Title)
            currencytextboxImporteAplicado.Focus()
            Exit Sub
        End If

        If (Not (mComprobanteTipoActual.OperacionTipo = Constantes.OperacionTipoVenta And mComprobanteTipoActual.MovimientoTipo = Constantes.MovimientoTipoCredito)) AndAlso currencytextboxImporteAplicado.DecimalValue > CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData_Comprobante).ImporteSinAplicar Then
            MsgBox("El Importe a aplicar no puede ser mayor que el Importe pendiente.", MsgBoxStyle.Information, My.Application.Info.Title)
            currencytextboxImporteAplicado.Focus()
            Exit Sub
        End If

        ' Si es un nuevo item, busco el próximo Indice y agrego el objeto nuevo a la colección del parent
        If mComprobanteAplicacionActual.IDComprobanteAplicado = 0 Then
            mComprobanteActual.ComprobantesAplicados.Add(mComprobanteAplicacionActual)
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Refresco la lista para mostrar los cambios
        If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formComprobante") Then
            Dim formComprobante As formComprobante = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formComprobante"), formComprobante)
            formComprobante.RefreshData_Aplicaciones(mComprobanteAplicacionActual.IDComprobanteAplicado)
            formComprobante = Nothing
        End If

        Me.Close()
    End Sub

#End Region

End Class