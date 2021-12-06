<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUsuarioGrupoPermisos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.labelUsuarioGrupo = New System.Windows.Forms.Label()
        Me.comboboxUsuarioGrupo = New System.Windows.Forms.ComboBox()
        Me.tabcontrolMain = New CSBomberos.CS_Control_TabControl()
        Me.tabpagePermisos = New System.Windows.Forms.TabPage()
        Me.tabpageReportes = New System.Windows.Forms.TabPage()
        Me.treeviewPermisos = New System.Windows.Forms.TreeView()
        Me.treeviewPermisosReportes = New System.Windows.Forms.TreeView()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpagePermisos.SuspendLayout()
        Me.tabpageReportes.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelUsuarioGrupo
        '
        Me.labelUsuarioGrupo.AutoSize = True
        Me.labelUsuarioGrupo.Location = New System.Drawing.Point(12, 15)
        Me.labelUsuarioGrupo.Name = "labelUsuarioGrupo"
        Me.labelUsuarioGrupo.Size = New System.Drawing.Size(98, 13)
        Me.labelUsuarioGrupo.TabIndex = 0
        Me.labelUsuarioGrupo.Text = "Grupo de Usuarios:"
        '
        'comboboxUsuarioGrupo
        '
        Me.comboboxUsuarioGrupo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboboxUsuarioGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxUsuarioGrupo.FormattingEnabled = True
        Me.comboboxUsuarioGrupo.Location = New System.Drawing.Point(134, 12)
        Me.comboboxUsuarioGrupo.Name = "comboboxUsuarioGrupo"
        Me.comboboxUsuarioGrupo.Size = New System.Drawing.Size(582, 21)
        Me.comboboxUsuarioGrupo.TabIndex = 1
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrolMain.Controls.Add(Me.tabpagePermisos)
        Me.tabcontrolMain.Controls.Add(Me.tabpageReportes)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 39)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(704, 422)
        Me.tabcontrolMain.TabIndex = 2
        '
        'tabpagePermisos
        '
        Me.tabpagePermisos.Controls.Add(Me.treeviewPermisos)
        Me.tabpagePermisos.Location = New System.Drawing.Point(4, 22)
        Me.tabpagePermisos.Name = "tabpagePermisos"
        Me.tabpagePermisos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpagePermisos.Size = New System.Drawing.Size(696, 396)
        Me.tabpagePermisos.TabIndex = 0
        Me.tabpagePermisos.Text = "Permisos"
        Me.tabpagePermisos.UseVisualStyleBackColor = True
        '
        'tabpageReportes
        '
        Me.tabpageReportes.Controls.Add(Me.treeviewPermisosReportes)
        Me.tabpageReportes.Location = New System.Drawing.Point(4, 22)
        Me.tabpageReportes.Name = "tabpageReportes"
        Me.tabpageReportes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageReportes.Size = New System.Drawing.Size(696, 396)
        Me.tabpageReportes.TabIndex = 1
        Me.tabpageReportes.Text = "Reportes"
        Me.tabpageReportes.UseVisualStyleBackColor = True
        '
        'treeviewPermisos
        '
        Me.treeviewPermisos.CheckBoxes = True
        Me.treeviewPermisos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeviewPermisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treeviewPermisos.Location = New System.Drawing.Point(3, 3)
        Me.treeviewPermisos.Name = "treeviewPermisos"
        Me.treeviewPermisos.Size = New System.Drawing.Size(690, 390)
        Me.treeviewPermisos.TabIndex = 0
        '
        'treeviewPermisosReportes
        '
        Me.treeviewPermisosReportes.CheckBoxes = True
        Me.treeviewPermisosReportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeviewPermisosReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treeviewPermisosReportes.Location = New System.Drawing.Point(3, 3)
        Me.treeviewPermisosReportes.Name = "treeviewPermisosReportes"
        Me.treeviewPermisosReportes.Size = New System.Drawing.Size(690, 390)
        Me.treeviewPermisosReportes.TabIndex = 1
        '
        'formUsuarioGrupoPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 473)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.comboboxUsuarioGrupo)
        Me.Controls.Add(Me.labelUsuarioGrupo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formUsuarioGrupoPermisos"
        Me.ShowInTaskbar = False
        Me.Text = "Permisos del Grupo de Usuarios"
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpagePermisos.ResumeLayout(False)
        Me.tabpageReportes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelUsuarioGrupo As System.Windows.Forms.Label
    Friend WithEvents comboboxUsuarioGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents tabcontrolMain As CS_Control_TabControl
    Friend WithEvents tabpagePermisos As TabPage
    Friend WithEvents treeviewPermisos As TreeView
    Friend WithEvents tabpageReportes As TabPage
    Friend WithEvents treeviewPermisosReportes As TreeView
End Class
