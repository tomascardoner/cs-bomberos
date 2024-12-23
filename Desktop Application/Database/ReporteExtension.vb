﻿Imports System.Data.SqlClient
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

    Friend Function Open(preview As Boolean, Optional titulo As String = "", Optional ByRef modalParent As Form = Nothing) As Boolean
        _PathAndFileName = Path.Combine(pGeneralConfig.ReportsPath, Archivo)

        If Not My.Computer.FileSystem.FileExists(_PathAndFileName) Then
            MessageBox.Show($"No se encontró el archivo del Reporte.{Environment.NewLine}{Environment.NewLine}Carpeta: {pGeneralConfig.ReportsPath}{Environment.NewLine}Archivo: {Archivo}", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        Cursor.Current = Cursors.WaitCursor

        If IsPdf Then
            Dim destinationFileName As String = CardonerSistemas.Files.GetTempFileName("pdf")
            If OpenPdf() AndAlso PdfSetParametersAndGetData() AndAlso PdfProcess(destinationFileName) Then
                Process.Start(destinationFileName)
                Return True
            End If
        Else
            If OpenCR() AndAlso CRSetParameters() AndAlso CRSetDatabaseConnection(pDatabase.Datasource, pDatabase.InitialCatalog, pDatabase.UserId, pDatabase.Password) Then
                If preview Then
                    Reportes.PreviewCrystalReport(Me, titulo, modalParent)
                Else
                    CRReportObject.PrintToPrinter(1, False, 1, 1000)
                End If
                Return True
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

        For Each ReporteParametro In Me.ReporteParametros.Where(Function(rp) (rp.Orden IsNot Nothing) AndAlso (rp.Valor IsNot Nothing) AndAlso rp.Tipo <> Reportes.REPORTE_PARAMETRO_TIPO_TITLE AndAlso rp.Tipo <> Reportes.REPORTE_PARAMETRO_TIPO_FILTER_TEXT AndAlso rp.Tipo <> Reportes.REPORTE_PARAMETRO_TIPO_FILTER_TEXT_SHOW).OrderBy(Function(rp) rp.Orden)
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
                                    If ParametroActual.Valor Is Nothing Then
                                        .CurrentValues.AddValue(String.Empty)
                                    Else
                                        .CurrentValues.AddValue(ParametroActual.Valor)
                                    End If
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
#Disable Warning S6562 ' Always set the "DateTimeKind" when creating new "DateTime" instances
                                                        .CurrentValues.AddValue(New Date(9999, 1, 1))
#Enable Warning S6562 ' Always set the "DateTimeKind" when creating new "DateTime" instances
                                                    Case ParameterType.StoreProcedureParameter
                                                        .CurrentValues.AddValue(Nothing)
                                                End Select
                                            Else
                                                .CurrentValues.AddValue(CDate(ParametroActual.Valor))
                                            End If
                                        Case ParameterValueKind.StringParameter
                                            If ParametroActual.Valor IsNot Nothing Then
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
            If String.IsNullOrWhiteSpace(OrigenDatos) Then
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
        Using command As New SqlCommand()
            Try
                If Not pDatabase.IsConnected AndAlso Not pDatabase.Connect() Then
                    Return False
                End If

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

            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al establecer los parámetros del reporte.")
                Return False

            End Try

            Try
                _DataReader = command.ExecuteReader(CommandBehavior.SingleResult)

                If _DataReader.HasRows Then
                    Return True
                Else
                    MsgBox("No hay datos para mostrar en el Reporte.", MsgBoxStyle.Information, My.Application.Info.Title)
                    Return False
                End If

            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al obtener los datos para el reporte.")
                Return False

            End Try
        End Using
    End Function

    Friend Function PdfProcess(ByVal destinationFileName As String) As Boolean

        Try
            Dim pdfReader As PdfReader
            Dim document As New Document

            Using fileStream = New FileStream(destinationFileName, FileMode.Create)
                Dim instance As PdfWriter = PdfWriter.GetInstance(document, fileStream)

                document.Open()

                Dim pdfContentByte As PdfContentByte = instance.DirectContent

                pdfReader = New PdfReader(_PathAndFileName)

                Dim pdfImportedPage As PdfImportedPage

                Dim font As Font
                Dim baseFont As BaseFont

                ' Si el reporte lo especifica, cargo la tipografía
                If IDTipografiaEstilo.HasValue AndAlso FontFactory.IsRegistered(TipografiaEstilo.Nombre) Then
                    font = FontFactory.GetFont(TipografiaEstilo.Nombre, BaseFont.WINANSI, False, TipografiaEstilo.Tamanio, TipografiaEstilo.Estilo)
                Else
                    font = FontFactory.GetFont(FontFactory.HELVETICA, FontFactory.DefaultEncoding, False)
                End If
                baseFont = font.BaseFont

                Dim valorCampoParaAgrupar As Object = Nothing
                Dim ordinalCampoParaAgrupar As Integer = -2
                Dim cantidadRegistros As Integer = 0
                Dim cantidadRegistrosGrupo As Integer = 0
                Dim cantidadPaginas As Integer = 0
                Dim crearPaginaNueva As Boolean

                Do While _DataReader.Read()
                    If Not String.IsNullOrEmpty(AgruparPorCampo) And ordinalCampoParaAgrupar = -2 Then
                        ordinalCampoParaAgrupar = CardonerSistemas.Database.Ado.SqlServer.GetOrdinalSafe(_DataReader, AgruparPorCampo)
                    End If

                    ' Determino si hay que empezar una página nueva
                    If String.IsNullOrEmpty(AgruparPorCampo) AndAlso (cantidadRegistrosGrupo = 0 Or (MaximoRegistrosDetalle.HasValue AndAlso cantidadRegistrosGrupo > MaximoRegistrosDetalle)) Then
                        crearPaginaNueva = True
                    End If
                    If (ordinalCampoParaAgrupar > -1 AndAlso Not Object.Equals(valorCampoParaAgrupar, _DataReader.GetValue(ordinalCampoParaAgrupar))) Or (MaximoRegistrosDetalle.HasValue AndAlso cantidadRegistrosGrupo > MaximoRegistrosDetalle) Then
                        crearPaginaNueva = True
                        valorCampoParaAgrupar = _DataReader.GetValue(ordinalCampoParaAgrupar)
                    End If

                    If crearPaginaNueva Then
                        ' Agregar una nueva página
                        document.NewPage()
                        pdfImportedPage = instance.GetImportedPage(pdfReader, 1)
                        pdfContentByte.AddTemplate(pdfImportedPage, 1.0F, 0F, 0F, 1.0F, 0F, 0F)
                        cantidadPaginas += 1
                        cantidadRegistrosGrupo = 1
                        crearPaginaNueva = False

                        ' Escribir todos los campos
                        PdfEscribirCampos(ReporteCampos.AsEnumerable, pdfContentByte, baseFont, cantidadRegistrosGrupo)
                    Else
                        ' Escribir solo los campos que se repiten
                        PdfEscribirCampos(ReporteCampos.Where(Function(rc) rc.EspaciadoY.HasValue), pdfContentByte, baseFont, cantidadRegistrosGrupo)
                    End If
                    cantidadRegistros += 1
                    cantidadRegistrosGrupo += 1
                Loop
                document.Close()
                pdfReader.Close()
            End Using
            Return True

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al completar el reporte en PDF.")
            Return False
        End Try
    End Function

    Private Sub PdfEscribirCampos(ByRef campos As IEnumerable(Of ReporteCampo), ByRef pdfContentByte As PdfContentByte, ByRef documentBaseFont As BaseFont, ByVal cantidadRegistrosGrupo As Integer)
        Dim ordinalCampoActual As Integer
        Dim valorCampoActual As Object

        Dim font As Font
        Dim baseFont As BaseFont

        Dim espaciadoY As Decimal

        For Each campo In campos
            ordinalCampoActual = CardonerSistemas.Database.ADO.SQLServer.GetOrdinalSafe(_DataReader, campo.Nombre)
            If ordinalCampoActual > -1 Then
                valorCampoActual = _DataReader.GetValue(ordinalCampoActual)

                If campo.IDTipografiaEstilo.HasValue AndAlso FontFactory.IsRegistered(campo.TipografiaEstilo.Nombre) Then
                    font = FontFactory.GetFont(TipografiaEstilo.Nombre, BaseFont.WINANSI, False, TipografiaEstilo.Tamanio, TipografiaEstilo.Estilo)
                    baseFont = font.BaseFont
                Else
                    baseFont = documentBaseFont
                End If

                If campo.EspaciadoY.HasValue Then
                    espaciadoY = campo.EspaciadoY.Value * -(cantidadRegistrosGrupo - 1)
                Else
                    espaciadoY = 0
                End If

                PdfEscribirCampo(pdfContentByte, baseFont, campo, espaciadoY, valorCampoActual)
            End If
        Next
    End Sub

    Private Sub PdfEscribirCampo(ByRef content As PdfContentByte, ByVal baseFont As BaseFont, ByRef campo As ReporteCampo, ByVal espaciadoY As Decimal, ByVal valor As Object)
        If campo.AlineadoDerecha.HasValue AndAlso campo.AlineadoDerecha AndAlso campo.CantidadCaracter.HasValue AndAlso valor.ToString().Length < campo.CantidadCaracter.Value Then
            ' Intenta alinear a la derecha agregando espacios a la izquierda,
            ' aunque debido a las tipografías de ancho variable, el efecto no es el esperado
            valor = valor.ToString().PadLeft(campo.CantidadCaracter.Value)
        End If

        If campo.OffsetCaracter.HasValue Then
            PdfEscribirCampoCaracterPorCaracter(content, baseFont, TipografiaEstilo.Tamanio, campo, espaciadoY, valor)
        Else
            PdfEscribirCampoEstandard(content, baseFont, TipografiaEstilo.Tamanio, campo, espaciadoY, valor)
        End If
    End Sub

    Private Shared Sub PdfEscribirCampoEstandard(ByRef content As PdfContentByte, ByVal baseFont As BaseFont, ByVal fontSize As Decimal, ByRef campo As ReporteCampo, ByVal espaciadoY As Decimal, ByVal valor As Object)
        content.BeginText()
        content.SetFontAndSize(baseFont, fontSize)

        content.SetTextMatrix(campo.PosicionX, campo.PosicionY + espaciadoY)

        If campo.EspaciadoIntercaracter.HasValue Then
            ' Aplico el el espaciado entre caracteres especificado
            content.SetCharacterSpacing(campo.EspaciadoIntercaracter.Value)
            content.ShowText(valor.ToString())
            content.SetCharacterSpacing(0)
        Else
            content.ShowText(valor.ToString())
        End If

        content.EndText()
    End Sub

    Private Shared Sub PdfEscribirCampoCaracterPorCaracter(ByRef content As PdfContentByte, ByVal baseFont As BaseFont, ByVal fontSize As Decimal, ByRef campo As ReporteCampo, ByVal espaciadoY As Decimal, ByVal valor As Object)
        Dim posicionX As Decimal

        content.BeginText()
        content.SetFontAndSize(baseFont, fontSize)

        posicionX = campo.PosicionX
        For Each caracter As Char In valor.ToString()
            content.SetTextMatrix(posicionX, campo.PosicionY + espaciadoY)
            content.ShowText(caracter)

            posicionX += campo.OffsetCaracter.Value
        Next

        content.EndText()
    End Sub

#End Region

End Class