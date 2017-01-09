<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonas
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPersonas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.toolstripButtons = New System.Windows.Forms.ToolStrip()
        Me.buttonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.dropdownbuttonOtros = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menuitemAccidentes = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemAscensos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemCalificaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemAltasBajas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemPenasDisciplinarias = New System.Windows.Forms.ToolStripMenuItem()
        Me.buttonImprimir = New System.Windows.Forms.ToolStripSplitButton()
        Me.menuitemImprimirFichaPersonal = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemImprimirListado = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.columnIDPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMatriculaNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCuartelNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bindingsourceMain = New System.Windows.Forms.BindingSource(Me.components)
        Me.panelToolbars = New System.Windows.Forms.FlowLayoutPanel()
        Me.toolstripBuscar = New System.Windows.Forms.ToolStrip()
        Me.labelBuscar = New System.Windows.Forms.ToolStripLabel()
        Me.textboxBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.buttonBuscarBorrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripCuartel = New System.Windows.Forms.ToolStrip()
        Me.labelCuartel = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxCuartel = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripActivo = New System.Windows.Forms.ToolStrip()
        Me.labelActivo = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxActivo = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripButtons.SuspendLayout()
        Me.statusstripMain.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelToolbars.SuspendLayout()
        Me.toolstripBuscar.SuspendLayout()
        Me.toolstripCuartel.SuspendLayout()
        Me.toolstripActivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolstripButtons
        '
        Me.toolstripButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripButtons.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAgregar, Me.buttonEditar, Me.buttonEliminar, Me.dropdownbuttonOtros, Me.buttonImprimir})
        Me.toolstripButtons.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.toolstripButtons.Location = New System.Drawing.Point(0, 0)
        Me.toolstripButtons.Name = "toolstripButtons"
        Me.toolstripButtons.Size = New System.Drawing.Size(444, 39)
        Me.toolstripButtons.TabIndex = 0
        '
        'buttonAgregar
        '
        Me.buttonAgregar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAgregar.Name = "buttonAgregar"
        Me.buttonAgregar.Size = New System.Drawing.Size(85, 36)
        Me.buttonAgregar.Text = "Agregar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(86, 36)
        Me.buttonEliminar.Text = "Eliminar"
        '
        'dropdownbuttonOtros
        '
        Me.dropdownbuttonOtros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemAccidentes, Me.menuitemAscensos, Me.menuitemCalificaciones, Me.menuitemAltasBajas, Me.menuitemPenasDisciplinarias})
        Me.dropdownbuttonOtros.Image = CType(resources.GetObject("dropdownbuttonOtros.Image"), System.Drawing.Image)
        Me.dropdownbuttonOtros.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.dropdownbuttonOtros.Name = "dropdownbuttonOtros"
        Me.dropdownbuttonOtros.Size = New System.Drawing.Size(65, 36)
        Me.dropdownbuttonOtros.Text = "Otros"
        '
        'menuitemAccidentes
        '
        Me.menuitemAccidentes.Name = "menuitemAccidentes"
        Me.menuitemAccidentes.Size = New System.Drawing.Size(204, 22)
        Me.menuitemAccidentes.Text = "Accidentes"
        '
        'menuitemAscensos
        '
        Me.menuitemAscensos.Name = "menuitemAscensos"
        Me.menuitemAscensos.Size = New System.Drawing.Size(204, 22)
        Me.menuitemAscensos.Text = "Ascensos - Promociones"
        '
        'menuitemCalificaciones
        '
        Me.menuitemCalificaciones.Name = "menuitemCalificaciones"
        Me.menuitemCalificaciones.Size = New System.Drawing.Size(204, 22)
        Me.menuitemCalificaciones.Text = "Calificaciones"
        '
        'menuitemAltasBajas
        '
        Me.menuitemAltasBajas.Name = "menuitemAltasBajas"
        Me.menuitemAltasBajas.Size = New System.Drawing.Size(204, 22)
        Me.menuitemAltasBajas.Text = "Altas - Bajas"
        '
        'menuitemPenasDisciplinarias
        '
        Me.menuitemPenasDisciplinarias.Name = "menuitemPenasDisciplinarias"
        Me.menuitemPenasDisciplinarias.Size = New System.Drawing.Size(204, 22)
        Me.menuitemPenasDisciplinarias.Text = "Penas Disciplinarias"
        '
        'buttonImprimir
        '
        Me.buttonImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemImprimirFichaPersonal, Me.menuitemImprimirListado})
        Me.buttonImprimir.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_PRINT_32
        Me.buttonImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonImprimir.Name = "buttonImprimir"
        Me.buttonImprimir.Size = New System.Drawing.Size(101, 36)
        Me.buttonImprimir.Text = "Imprimir"
        '
        'menuitemImprimirFichaPersonal
        '
        Me.menuitemImprimirFichaPersonal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuitemImprimirFichaPersonal.Name = "menuitemImprimirFichaPersonal"
        Me.menuitemImprimirFichaPersonal.Size = New System.Drawing.Size(150, 22)
        Me.menuitemImprimirFichaPersonal.Text = "Ficha Personal"
        '
        'menuitemImprimirListado
        '
        Me.menuitemImprimirListado.Name = "menuitemImprimirListado"
        Me.menuitemImprimirListado.Size = New System.Drawing.Size(150, 22)
        Me.menuitemImprimirListado.Text = "Listado"
        '
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabelMain})
        Me.statusstripMain.Location = New System.Drawing.Point(0, 347)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(1061, 22)
        Me.statusstripMain.TabIndex = 1
        '
        'statuslabelMain
        '
        Me.statuslabelMain.Name = "statuslabelMain"
        Me.statuslabelMain.Size = New System.Drawing.Size(1046, 17)
        Me.statuslabelMain.Spring = True
        Me.statuslabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'datagridviewMain
        '
        Me.datagridviewMain.AllowUserToAddRows = False
        Me.datagridviewMain.AllowUserToDeleteRows = False
        Me.datagridviewMain.AllowUserToOrderColumns = True
        Me.datagridviewMain.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewMain.AutoGenerateColumns = False
        Me.datagridviewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnIDPersona, Me.columnMatriculaNumero, Me.columnApellido, Me.columnNombre, Me.columnCuartelNombre})
        Me.datagridviewMain.DataSource = Me.bindingsourceMain
        Me.datagridviewMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewMain.Location = New System.Drawing.Point(0, 39)
        Me.datagridviewMain.MultiSelect = False
        Me.datagridviewMain.Name = "datagridviewMain"
        Me.datagridviewMain.ReadOnly = True
        Me.datagridviewMain.RowHeadersVisible = False
        Me.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewMain.Size = New System.Drawing.Size(1061, 308)
        Me.datagridviewMain.TabIndex = 0
        '
        'columnIDPersona
        '
        Me.columnIDPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnIDPersona.DataPropertyName = "IDPersona"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.columnIDPersona.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnIDPersona.HeaderText = "N° Persona"
        Me.columnIDPersona.Name = "columnIDPersona"
        Me.columnIDPersona.ReadOnly = True
        Me.columnIDPersona.Width = 86
        '
        'columnMatriculaNumero
        '
        Me.columnMatriculaNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnMatriculaNumero.DataPropertyName = "MatriculaNumero"
        Me.columnMatriculaNumero.HeaderText = "Matrícula"
        Me.columnMatriculaNumero.Name = "columnMatriculaNumero"
        Me.columnMatriculaNumero.ReadOnly = True
        Me.columnMatriculaNumero.Width = 77
        '
        'columnApellido
        '
        Me.columnApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnApellido.DataPropertyName = "Apellido"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnApellido.DefaultCellStyle = DataGridViewCellStyle3
        Me.columnApellido.HeaderText = "Apellidos"
        Me.columnApellido.Name = "columnApellido"
        Me.columnApellido.ReadOnly = True
        Me.columnApellido.Width = 74
        '
        'columnNombre
        '
        Me.columnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnNombre.DataPropertyName = "Nombre"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnNombre.DefaultCellStyle = DataGridViewCellStyle4
        Me.columnNombre.HeaderText = "Nombres"
        Me.columnNombre.Name = "columnNombre"
        Me.columnNombre.ReadOnly = True
        Me.columnNombre.Width = 74
        '
        'columnCuartelNombre
        '
        Me.columnCuartelNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnCuartelNombre.DataPropertyName = "CuartelNombre"
        Me.columnCuartelNombre.HeaderText = "Cuartel"
        Me.columnCuartelNombre.Name = "columnCuartelNombre"
        Me.columnCuartelNombre.ReadOnly = True
        Me.columnCuartelNombre.Width = 65
        '
        'panelToolbars
        '
        Me.panelToolbars.AutoSize = True
        Me.panelToolbars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelToolbars.Controls.Add(Me.toolstripButtons)
        Me.panelToolbars.Controls.Add(Me.toolstripBuscar)
        Me.panelToolbars.Controls.Add(Me.toolstripCuartel)
        Me.panelToolbars.Controls.Add(Me.toolstripActivo)
        Me.panelToolbars.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelToolbars.Location = New System.Drawing.Point(0, 0)
        Me.panelToolbars.Name = "panelToolbars"
        Me.panelToolbars.Size = New System.Drawing.Size(1061, 39)
        Me.panelToolbars.TabIndex = 2
        '
        'toolstripBuscar
        '
        Me.toolstripBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripBuscar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripBuscar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelBuscar, Me.textboxBuscar, Me.buttonBuscarBorrar})
        Me.toolstripBuscar.Location = New System.Drawing.Point(444, 0)
        Me.toolstripBuscar.Name = "toolstripBuscar"
        Me.toolstripBuscar.Size = New System.Drawing.Size(193, 39)
        Me.toolstripBuscar.TabIndex = 2
        '
        'labelBuscar
        '
        Me.labelBuscar.Name = "labelBuscar"
        Me.labelBuscar.Size = New System.Drawing.Size(45, 36)
        Me.labelBuscar.Text = "Buscar:"
        '
        'textboxBuscar
        '
        Me.textboxBuscar.MaxLength = 100
        Me.textboxBuscar.Name = "textboxBuscar"
        Me.textboxBuscar.Size = New System.Drawing.Size(120, 39)
        '
        'buttonBuscarBorrar
        '
        Me.buttonBuscarBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonBuscarBorrar.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_CLOSE_16
        Me.buttonBuscarBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonBuscarBorrar.Name = "buttonBuscarBorrar"
        Me.buttonBuscarBorrar.Size = New System.Drawing.Size(23, 36)
        Me.buttonBuscarBorrar.ToolTipText = "Limpiar búsqueda"
        '
        'toolstripCuartel
        '
        Me.toolstripCuartel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripCuartel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripCuartel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelCuartel, Me.comboboxCuartel})
        Me.toolstripCuartel.Location = New System.Drawing.Point(637, 0)
        Me.toolstripCuartel.Name = "toolstripCuartel"
        Me.toolstripCuartel.Size = New System.Drawing.Size(183, 39)
        Me.toolstripCuartel.TabIndex = 4
        '
        'labelCuartel
        '
        Me.labelCuartel.Name = "labelCuartel"
        Me.labelCuartel.Size = New System.Drawing.Size(48, 36)
        Me.labelCuartel.Text = "Cuartel:"
        '
        'comboboxCuartel
        '
        Me.comboboxCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCuartel.Name = "comboboxCuartel"
        Me.comboboxCuartel.Size = New System.Drawing.Size(130, 39)
        '
        'toolstripActivo
        '
        Me.toolstripActivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripActivo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripActivo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelActivo, Me.comboboxActivo})
        Me.toolstripActivo.Location = New System.Drawing.Point(820, 0)
        Me.toolstripActivo.Name = "toolstripActivo"
        Me.toolstripActivo.Size = New System.Drawing.Size(124, 39)
        Me.toolstripActivo.TabIndex = 3
        '
        'labelActivo
        '
        Me.labelActivo.Name = "labelActivo"
        Me.labelActivo.Size = New System.Drawing.Size(44, 36)
        Me.labelActivo.Text = "Activo:"
        '
        'comboboxActivo
        '
        Me.comboboxActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxActivo.Name = "comboboxActivo"
        Me.comboboxActivo.Size = New System.Drawing.Size(75, 39)
        '
        'formPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 369)
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.panelToolbars)
        Me.Controls.Add(Me.statusstripMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "formPersonas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Personas"
        Me.toolstripButtons.ResumeLayout(False)
        Me.toolstripButtons.PerformLayout()
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelToolbars.ResumeLayout(False)
        Me.panelToolbars.PerformLayout()
        Me.toolstripBuscar.ResumeLayout(False)
        Me.toolstripBuscar.PerformLayout()
        Me.toolstripCuartel.ResumeLayout(False)
        Me.toolstripCuartel.PerformLayout()
        Me.toolstripActivo.ResumeLayout(False)
        Me.toolstripActivo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripButtons As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents statusstripMain As System.Windows.Forms.StatusStrip
    Friend WithEvents statuslabelMain As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents datagridviewMain As System.Windows.Forms.DataGridView
    Friend WithEvents bindingsourceMain As System.Windows.Forms.BindingSource
    Friend WithEvents panelToolbars As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents toolstripBuscar As System.Windows.Forms.ToolStrip
    Friend WithEvents toolstripActivo As System.Windows.Forms.ToolStrip
    Friend WithEvents labelBuscar As System.Windows.Forms.ToolStripLabel
    Friend WithEvents textboxBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents buttonBuscarBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents labelActivo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxActivo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents dropdownbuttonOtros As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menuitemAccidentes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemAscensos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemCalificaciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemAltasBajas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemPenasDisciplinarias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolstripCuartel As System.Windows.Forms.ToolStrip
    Friend WithEvents labelCuartel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxCuartel As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents columnIDPersona As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnMatriculaNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnApellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnCuartelNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents buttonImprimir As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents menuitemImprimirFichaPersonal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemImprimirListado As System.Windows.Forms.ToolStripMenuItem
End Class
