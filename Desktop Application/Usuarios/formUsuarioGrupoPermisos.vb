Public Class formUsuarioGrupoPermisos

#Region "Form stuff"
    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.IMAGE_TABLAS_32)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        pFillAndRefreshLists.UsuarioGrupo(comboboxUsuarioGrupo, False, False, False)
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub comboboxUsuarioGrupo_SelectedValueChanged() Handles comboboxUsuarioGrupo.SelectedValueChanged
        Cursor.Current = Cursors.WaitCursor

        Permisos.CargarArbolDePermisos(treeviewPermisos, CByte(comboboxUsuarioGrupo.SelectedValue))

        Cursor.Current = Cursors.Default
    End Sub
#End Region

End Class