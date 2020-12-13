Module Reportes

    Friend Sub PreviewCrystalReport(ByRef ReporteActual As Reporte, ByVal WindowText As String, Optional ByRef modalParent As Form = Nothing)
        Dim VisorReporte As New formReportesVisor

        pFormMDIMain.Cursor = Cursors.WaitCursor

        With VisorReporte
            .Text = WindowText
            .CRViewerMain.ReportSource = ReporteActual.CRReportObject
            If modalParent Is Nothing Then
                CS_Form.MDIChild_PositionAndSizeToFit(CType(pFormMDIMain, Form), CType(VisorReporte, Form))
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
