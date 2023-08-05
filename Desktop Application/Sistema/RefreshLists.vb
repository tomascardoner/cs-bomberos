Module RefreshLists

    Friend Sub Siniestros(idSiniestro As Integer)
        Dim fs As formSiniestros = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), formSiniestros.Name), formSiniestros)
        fs?.RefreshData(idSiniestro)
    End Sub
End Module