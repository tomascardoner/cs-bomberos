Module Reportes

    '//////////////////
    '    PARÁMETROS 
    '//////////////////
    Friend Const REPORTE_PARAMETRO_TIPO_CUARTEL As String = "CTEL"
    Friend Const REPORTE_PARAMETRO_TIPO_CARGO As String = "CARG"
    Friend Const REPORTE_PARAMETRO_TIPO_JERARQUIA As String = "JERQ"
    Friend Const REPORTE_PARAMETRO_TIPO_PERSONABAJAMOTIVO As String = "PBMT"
    Friend Const REPORTE_PARAMETRO_TIPO_PERSONA As String = "PERS"
    Friend Const REPORTE_PARAMETRO_TIPO_PERSONAMULTIPLE As String = "PEMU"
    Friend Const REPORTE_PARAMETRO_TIPO_PERSONAFAMILIARMULTIPLE As String = "PEFM"
    Friend Const REPORTE_PARAMETRO_TIPO_UNIDAD As String = "UNID"
    Friend Const REPORTE_PARAMETRO_TIPO_AREA As String = "AREA"
    Friend Const REPORTE_PARAMETRO_TIPO_UBICACION As String = "UBIC"
    Friend Const REPORTE_PARAMETRO_TIPO_SUBUBICACION As String = "SUBU"
    Friend Const REPORTE_PARAMETRO_TIPO_RESPONSABLE As String = "RESP"
    Friend Const REPORTE_PARAMETRO_TIPO_COMPRA As String = "COMP"
    Friend Const REPORTE_PARAMETRO_TIPO_CAJA As String = "CAJA"
    Friend Const REPORTE_PARAMETRO_TIPO_CAJAARQUEO As String = "CJAR"

    Friend Const REPORTE_PARAMETRO_TIPO_TEXT As String = "TEXT"
    Friend Const REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER As String = "NUIN"
    Friend Const REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL As String = "NUDE"
    Friend Const REPORTE_PARAMETRO_TIPO_MONEY As String = "MONY"
    Friend Const REPORTE_PARAMETRO_TIPO_DATETIME As String = "DATI"
    Friend Const REPORTE_PARAMETRO_TIPO_DATE As String = "DATE"
    Friend Const REPORTE_PARAMETRO_TIPO_TIME As String = "TIME"
    Friend Const REPORTE_PARAMETRO_TIPO_YEAR As String = "YEAR"
    Friend Const REPORTE_PARAMETRO_TIPO_YEAR_MONTH_FROM As String = "YMFR"
    Friend Const REPORTE_PARAMETRO_TIPO_YEAR_MONTH_TO As String = "YMTO"
    Friend Const REPORTE_PARAMETRO_TIPO_SINO As String = "BOOL"

    Friend Const REPORTE_PARAMETRO_TIPO_COMPANY As String = "CMNY"
    Friend Const REPORTE_PARAMETRO_TIPO_TITLE As String = "TITL"
    Friend Const REPORTE_PARAMETRO_TIPO_FILTER_TEXT As String = "FILT"
    Friend Const REPORTE_PARAMETRO_TIPO_FILTER_TEXT_SHOW As String = "FLSH"

    Friend Sub PreviewCrystalReport(ByRef ReporteActual As Reporte, ByVal WindowText As String, Optional ByRef modalParent As Form = Nothing)
        Dim VisorReporte As New formReportesVisor

        pFormMDIMain.Cursor = Cursors.WaitCursor

        With VisorReporte
            .Text = WindowText
            .CRViewerMain.ReportSource = ReporteActual.CRReportObject
            If modalParent Is Nothing Then
                CardonerSistemas.Forms.MdiChildPositionAndSizeToFit(CType(pFormMDIMain, Form), CType(VisorReporte, Form))
                .Show()
            Else
                .WindowState = FormWindowState.Maximized
                .ShowDialog(modalParent)
            End If
            If .WindowState = FormWindowState.Minimized Then
                .WindowState = FormWindowState.Normal
            End If
            .Focus()
        End With

        pFormMDIMain.Cursor = Cursors.Default
    End Sub

End Module
