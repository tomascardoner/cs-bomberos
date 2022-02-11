Public Class formUsuarioGrupoPermisos

#Region "Declarations"

    Private mdbContext As New CSBomberosContext(True)

#End Region

#Region "Form stuff"

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        pFillAndRefreshLists.UsuarioGrupo(comboboxUsuarioGrupo, False, False, False)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub comboboxUsuarioGrupo_SelectedValueChanged() Handles comboboxUsuarioGrupo.SelectedValueChanged
        If comboboxUsuarioGrupo.SelectedValue Is Nothing Then
            Exit Sub
        End If
        Cursor.Current = Cursors.WaitCursor

        Permisos.CargarArbolDePermisos(treeviewPermisos, CByte(comboboxUsuarioGrupo.SelectedValue))
        Permisos.CargarArbolDePermisosDeReportes(mdbContext, treeviewPermisosReportes, CByte(comboboxUsuarioGrupo.SelectedValue))

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub treeviewPermisos_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles treeviewPermisos.AfterCheck
        Dim nodeCurrent As TreeNode
        Dim permisoCurrent As UsuarioGrupoPermiso

        If e.Action <> TreeViewAction.ByMouse And e.Action <> TreeViewAction.ByKeyboard Then
            Exit Sub
        End If

        nodeCurrent = e.Node

        If nodeCurrent.Checked Then
            ' Agregar permiso
            permisoCurrent = New UsuarioGrupoPermiso
            permisoCurrent.IDUsuarioGrupo = CByte(comboboxUsuarioGrupo.SelectedValue)
            permisoCurrent.IDPermiso = nodeCurrent.Name

            Try
                mdbContext.UsuarioGrupoPermiso.Add(permisoCurrent)
                mdbContext.SaveChanges()
            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al establecer el permiso.")
            End Try
        Else
            ' Quitar permiso
            Try
                permisoCurrent = mdbContext.UsuarioGrupoPermiso.Find(CByte(comboboxUsuarioGrupo.SelectedValue), nodeCurrent.Name)
                mdbContext.UsuarioGrupoPermiso.Remove(permisoCurrent)
                mdbContext.SaveChanges()
            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al quitar el permiso.")
            End Try
        End If
    End Sub

    Private Sub treeviewPermisosReportes_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles treeviewPermisosReportes.AfterCheck
        Dim nodeCurrent As TreeNode
        Dim reporteCurrent As Reporte
        Dim idReporte As Short

        If e.Action <> TreeViewAction.ByMouse And e.Action <> TreeViewAction.ByKeyboard Then
            Exit Sub
        End If

        nodeCurrent = e.Node
        If Not nodeCurrent.Name.StartsWith("REPORTE_") Then
            Exit Sub
        End If

        idReporte = CShort(nodeCurrent.Name.Substring(Len("REPORTE_")))
        reporteCurrent = mdbContext.Reporte.Find(idReporte)

        If nodeCurrent.Checked Then
            ' Agregar permiso
            reporteCurrent.IDReporte = idReporte
            Try
                mdbContext.UsuarioGrupo.Find(CByte(comboboxUsuarioGrupo.SelectedValue)).Reporte.Add(reporteCurrent)
                mdbContext.SaveChanges()
            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al establecer el permiso del reporte.")
            End Try
        Else
            ' Quitar permiso
            Try
                mdbContext.UsuarioGrupo.Find(CByte(comboboxUsuarioGrupo.SelectedValue)).Reporte.Remove(reporteCurrent)
                mdbContext.SaveChanges()
            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al quitar el permiso del reporte.")
            End Try
        End If
    End Sub

#End Region

End Class