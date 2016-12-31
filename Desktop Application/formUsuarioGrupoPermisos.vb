Public Class formUsuarioGrupoPermisos
#Region "Form stuff"
    Friend Sub SetAppearance()
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        pFillAndRefreshLists.UsuarioGrupo(comboboxUsuarioGrupo, False, False)
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub comboboxUsuarioGrupo_SelectedValueChanged() Handles comboboxUsuarioGrupo.SelectedValueChanged
        Permisos.CargarArbolDePermisos(treeviewPermisos, CByte(comboboxUsuarioGrupo.SelectedValue))
    End Sub
#End Region

End Class