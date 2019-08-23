Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Partial Public Class Reporte

#Region "Declarations"

    Private _PathAndFileName As String
    Private _CRRecordSelectionFormula As String

    Private _DataReader As SqlDataReader

    Friend Property CRReportObject As ReportDocument

#End Region

#Region "Common"

    Friend ReadOnly Property IsPdf() As Boolean
        Get
            Return Me.Archivo.EndsWith(".pdf", StringComparison.InvariantCultureIgnoreCase)
        End Get
    End Property

    Friend Function Open(ByVal preview As Boolean, Optional ByVal titulo As String = "") As Boolean
        _PathAndFileName = My.Settings.ReportsPath & "\" & Archivo

        If Not My.Computer.FileSystem.FileExists(_PathAndFileName) Then
            MsgBox(String.Format("No se encontró el archivo del Reporte.{0}{0}Carpeta: {1}{0}Archivo: {2}", vbCrLf, My.Settings.ReportsPath, Archivo), MsgBoxStyle.Exclamation, My.Application.Info.Title)
            Return False
        End If

        Cursor.Current = Cursors.WaitCursor

        If IsPdf Then
            If OpenPdf() Then
                If PdfSetParametersAndGetData() Then
                    Dim destinationFileName As String = CardonerSistemas.SpecialFolders.GetTempFileName("pdf")

                    If PdfProcess(destinationFileName) Then
                        Process.Start(destinationFileName)
                        Return True
                    End If
                End If
            End If
        Else
            If OpenCR() Then
                If CRSetParameters() Then
                    If CRSetDatabaseConnection(pDatabase.DataSource, pDatabase.InitialCatalog, pDatabase.UserID, pDatabase.Password) Then
                        If preview Then
                            MiscFunctions.PreviewCrystalReport(Me, titulo)
                        Else
                            CRReportObject.PrintToPrinter(1, False, 1, 1000)
                        End If
                        Return True
                    End If
                End If
            End If
        End If
        Return False

        Cursor.Current = Cursors.Default
    End Function

#End Region

#Region "CrystalReports"

    Friend Property CRRecordSelectionFormula() As String
        Get
            Return _CRRecordSelectionFormula
        End Get
        Set(ByVal value As String)
            _CRRecordSelectionFormula = value
            CRReportObject.RecordSelectionFormula = value
        End Set
    End Property

    Private Function CRGetConditionText() As String
        Dim ReporteParametro As ReporteParametro
        Dim ResultText As String = ""

        For Each ReporteParametro In Me.ReporteParametros.Where(Function(rp) (Not rp.Orden Is Nothing) AndAlso (Not rp.Valor Is Nothing) AndAlso rp.Tipo <> Constantes.REPORTE_PARAMETRO_TIPO_FILTER_TEXT AndAlso rp.Tipo <> Constantes.REPORTE_PARAMETRO_TIPO_FILTER_TEXT_SHOW).OrderBy(Function(rp) rp.Orden)
            ResultText &= CStr(IIf(ResultText = "", "", ", ")) & ReporteParametro.Nombre & ": " & ReporteParametro.ValorParaMostrar
        Next ReporteParametro
        ReporteParametro = Nothing

        Return "Filtros aplicados: " & ResultText
    End Function


    Friend Function OpenCR() As Boolean
        Try
            CRReportObject = New ReportDocument

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al crear el objeto del reporte." & vbCrLf & "Probablemente, esto se deba a que no estan correctamente instaladas las librerías de Crystal Reports.")
            Return False
        End Try

        Try
            CRReportObject.Load(_PathAndFileName)

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al cargar el reporte.")
            Return False
        End Try

        Return True
    End Function

    Friend Function CRSetParameters() As Boolean

        Try

            For Each ParametroActual As ReporteParametro In Me.ReporteParametros
                For Each ParameterFieldActual As ParameterField In CRReportObject.ParameterFields
                    With ParameterFieldActual
                        If CStr(IIf(.ParameterType = ParameterType.StoreProcedureParameter, "@", "")) & ParametroActual.IDParametro.TrimEnd = .ParameterFieldName Then
                            Select Case ParametroActual.Tipo
                                Case REPORTE_PARAMETRO_TIPO_COMPANY
                                    .CurrentValues.AddValue(pLicensedTo)
                                Case REPORTE_PARAMETRO_TIPO_TITLE
                                    .CurrentValues.AddValue(ParametroActual.Valor)
                                Case REPORTE_PARAMETRO_TIPO_FILTER_TEXT
                                    .CurrentValues.AddValue(CRGetConditionText())
                                Case Else
                                    Select Case .ParameterValueType
                                        Case ParameterValueKind.CurrencyParameter, ParameterValueKind.NumberParameter
                                            If ParametroActual.Valor Is Nothing Then
                                                .CurrentValues.AddValue(Nothing)
                                            Else
                                                .CurrentValues.AddValue(CDec(ParametroActual.Valor))
                                            End If
                                        Case ParameterValueKind.DateTimeParameter, ParameterValueKind.DateParameter, ParameterValueKind.TimeParameter
                                            If ParametroActual.Valor Is Nothing Then
                                                Select Case .ParameterType
                                                    Case ParameterType.ReportParameter
                                                        .CurrentValues.AddValue(New Date(9999, 1, 1))
                                                    Case ParameterType.StoreProcedureParameter
                                                        .CurrentValues.AddValue(Nothing)
                                                End Select
                                            Else
                                                Select Case ParametroActual.Tipo
                                                    Case Constantes.REPORTE_PARAMETRO_TIPO_DATETIME
                                                        .CurrentValues.AddValue(CDate(ParametroActual.Valor))
                                                    Case Constantes.REPORTE_PARAMETRO_TIPO_DATE
                                                        .CurrentValues.AddValue(CDate(ParametroActual.Valor))
                                                    Case Constantes.REPORTE_PARAMETRO_TIPO_TIME
                                                        .CurrentValues.AddValue(CDate("1900/01/01 " & CStr(ParametroActual.Valor)))
                                                    Case Constantes.REPORTE_PARAMETRO_TIPO_YEAR_MONTH_FROM, Constantes.REPORTE_PARAMETRO_TIPO_YEAR_MONTH_TO
                                                        .CurrentValues.AddValue(CDate(ParametroActual.Valor))
                                                End Select
                                            End If
                                        Case ParameterValueKind.StringParameter
                                            If Not ParametroActual.Valor Is Nothing Then
                                                .CurrentValues.AddValue(CStr(ParametroActual.Valor))
                                            End If
                                        Case ParameterValueKind.BooleanParameter
                                            If ParametroActual.Valor Is Nothing AndAlso .EnableNullValue Then
                                                .CurrentValues.AddValue(Nothing)
                                            Else
                                                .CurrentValues.AddValue(CBool(ParametroActual.Valor))
                                            End If
                                    End Select
                            End Select
                            Exit For
                        End If
                    End With
                Next
            Next

            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al establecer los parámetros del reporte.")
            Return False

        End Try
    End Function

    Friend Function CRSetDatabaseConnection(ByVal ServerName As String, ByVal DatabaseName As String, ByVal UserID As String, ByVal Password As String) As Boolean
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table

        With crConnectionInfo
            .ServerName = ServerName
            .DatabaseName = DatabaseName
            .UserID = UserID
            .Password = Password
        End With

        Try
            CrTables = CRReportObject.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next
            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al establecer la conexión a la base de datos del Reporte.")
            Return False
        End Try
    End Function

#End Region

#Region "Pdf"

    Friend Function OpenPdf() As Boolean

        Try
            If OrigenDatos = "" Then
                MsgBox("No se ha especificado el Origen de los Datos del Reporte.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                Return False
            End If

            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al abrir el reporte en PDF.")
            Return False

        End Try
    End Function

    Friend Function PdfSetParametersAndGetData() As Boolean

        Try
            If Not pDatabase.IsConnected Then
                If Not pDatabase.Connect() Then
                    Return False
                End If
            End If

            Dim command As SqlCommand = New SqlCommand()
            command.Connection = pDatabase.Connection
            command.CommandText = OrigenDatos
            command.CommandType = CommandType.StoredProcedure

            For Each parametroActual As ReporteParametro In Me.ReporteParametros
                If parametroActual.Valor Is Nothing Then
                    command.Parameters.AddWithValue("@" & parametroActual.IDParametro.TrimEnd, DBNull.Value)
                Else
                    command.Parameters.AddWithValue("@" & parametroActual.IDParametro.TrimEnd, parametroActual.Valor)
                End If
            Next

            _DataReader = command.ExecuteReader(CommandBehavior.SingleResult)
            command.Dispose()
            command = Nothing

            If _DataReader.HasRows Then
                Return True
            Else
                MsgBox("No hay datos para mostrar en el Reporte.", MsgBoxStyle.Information, My.Application.Info.Title)
                Return False
            End If

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al establecer los parámetros del reporte.")
            Return False

        End Try
    End Function

    Friend Function PdfProcess(ByVal destinationFileName As String) As Boolean

        Try
            Dim pdfReader As PdfReader
            Dim document As New Document

            Dim fileStream As FileStream = New FileStream(destinationFileName, FileMode.Create)
            Dim instance As PdfWriter = PdfWriter.GetInstance(document, fileStream)

            document.Open()

            Dim pdfContentByte As PdfContentByte = instance.DirectContent

            pdfReader = New PdfReader(_PathAndFileName)

            Dim pdfImportedPage As PdfImportedPage

            Dim font As Font
            Dim baseFont As BaseFont

            ' Si el reporte lo especifica, cargo la tipografía
            If IDTipografiaEstilo.HasValue Then
                If FontFactory.IsRegistered(TipografiaEstilo.Nombre) Then
                    font = FontFactory.GetFont(TipografiaEstilo.Nombre, BaseFont.WINANSI, False, TipografiaEstilo.Tamanio, TipografiaEstilo.Estilo)
                    baseFont = font.BaseFont
                End If
            End If

            Dim valorCampoParaAgrupar As Object = Nothing
            Dim ordinalCampoParaAgrupar As Integer = -2
            Dim cantidadRegistros As Integer = 0
            Dim cantidadRegistrosGrupo As Integer = 0
            Dim cantidadPaginas As Integer = 0

            Dim ordinalCampoActual As Integer
            Dim valorCampoActual As Object

            Do While _DataReader.Read()
                If Not String.IsNullOrEmpty(AgruparPorCampo) And ordinalCampoParaAgrupar = -2 Then
                    ordinalCampoParaAgrupar = CardonerSistemas.Database.ADO.SQLServer.GetOrdinalSafe(_DataReader, AgruparPorCampo)
                End If
                If ordinalCampoParaAgrupar > -1 AndAlso Not Object.Equals(valorCampoParaAgrupar, _DataReader.GetValue(ordinalCampoParaAgrupar)) Then
                    valorCampoParaAgrupar = _DataReader.GetValue(ordinalCampoParaAgrupar)

                    ' Agregar una nueva página
                    document.NewPage()
                    pdfImportedPage = instance.GetImportedPage(pdfReader, 1)
                    pdfContentByte.AddTemplate(pdfImportedPage, 1.0F, 0F, 0F, 1.0F, 0F, 0F)
                    cantidadPaginas += 1
                    cantidadRegistrosGrupo = 0

                    ' Escribir todos los campos
                    For Each campo In ReporteCampos
                        ordinalCampoActual = CardonerSistemas.Database.ADO.SQLServer.GetOrdinalSafe(_DataReader, campo.Nombre)
                        If ordinalCampoActual > -1 Then
                            valorCampoActual = _DataReader.GetValue(ordinalCampoActual)

                            ' Escribir el valor en el PDF
                            PdfCompletarDetalle(pdfContentByte, baseFont, TipografiaEstilo.Tamanio, campo, 0, valorCampoActual)
                        End If
                    Next
                Else
                    ' Escribir solo los campos que se repiten
                    For Each campo In ReporteCampos.Where(Function(rc) rc.EspaciadoY.HasValue)
                        ordinalCampoActual = CardonerSistemas.Database.ADO.SQLServer.GetOrdinalSafe(_DataReader, campo.Nombre)
                        If ordinalCampoActual > -1 Then
                            valorCampoActual = _DataReader.GetValue(ordinalCampoActual)

                            ' Escribir el valor en el PDF
                            PdfCompletarDetalle(pdfContentByte, baseFont, TipografiaEstilo.Tamanio, campo, campo.EspaciadoY.Value * -cantidadRegistrosGrupo, valorCampoActual)
                        End If
                    Next
                End If
                cantidadRegistros += 1
                cantidadRegistrosGrupo += 1

            Loop

            document.Close()
            pdfReader.Close()
            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al completar el reporte en PDF.")
            Return False
        End Try
    End Function

    Private Sub PdfCompletarDetalle(ByRef content As PdfContentByte, ByVal baseFont As BaseFont, ByVal fontSize As Single, ByRef campo As ReporteCampo, ByVal espaciadoY As Integer, ByVal valor As Object)
        content.BeginText()
        content.SetFontAndSize(baseFont, fontSize)

        content.SetTextMatrix(campo.PosicionX, campo.PosicionY + espaciadoY)
        content.ShowText(valor.ToString())

        content.EndText()
    End Sub

#End Region

End Class