Module RefreshLists

    Friend Sub Siniestros(idSiniestro As Integer)
        Dim fs As FormSiniestros = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), formSiniestros.Name), FormSiniestros)
        fs?.RefreshData(idSiniestro)
    End Sub
End Module