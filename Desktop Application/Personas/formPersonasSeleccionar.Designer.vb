<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonasSeleccionar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.columnMatrioculaNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bindingsourceMain = New System.Windows.Forms.BindingSource(Me.components)
        Me.panelToolbars = New System.Windows.Forms.FlowLayoutPanel()
        Me.toolstripBuscar = New System.Windows.Forms.ToolStrip()
        Me.labelBuscar = New System.Windows.Forms.ToolStripLabel()
        Me.textboxBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.buttonBuscarBorrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripCuartel = New System.Windows.Forms.ToolStrip()
        Me.labelCuartel = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxCuartel = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripEstado = New System.Windows.Forms.ToolStrip()
        Me.labelEstadoActual = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxEstadoActual = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripButtons = New System.Windows.Forms.ToolStrip()
        Me.buttonSeleccionar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelToolbars.SuspendLayout()
        Me.toolstripBuscar.SuspendLayout()
        Me.toolstripCuartel.SuspendLayout()
        Me.toolstripEstado.SuspendLayout()
        Me.toolstripButtons.SuspendLayout()
        Me.SuspendLayout()
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
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnMatrioculaNumero, Me.columnApellido, Me.columnNombre})
        Me.datagridviewMain.DataSource = Me.bindingsourceMain
        Me.datagridviewMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewMain.Location = New System.Drawing.Point(0, 64)
        Me.datagridviewMain.Name = "datagridviewMain"
        Me.datagridviewMain.ReadOnly = True
        Me.datagridviewMain.RowHeadersVisible = False
        Me.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewMain.Size = New System.Drawing.Size(613, 457)
        Me.datagridviewMain.TabIndex = 0
        '
        'columnMatrioculaNumero
        '
        Me.columnMatrioculaNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnMatrioculaNumero.DataPropertyName = "MatriculaNumero"
        Me.columnMatrioculaNumero.HeaderText = "Matrícula"
        Me.columnMatrioculaNumero.Name = "columnMatrioculaNumero"
        Me.columnMatrioculaNumero.ReadOnly = True
        Me.columnMatrioculaNumero.Width = 77
        '
        'columnApellido
        '
        Me.columnApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnApellido.DataPropertyName = "Apellido"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnApellido.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnApellido.HeaderText = "Apellidos"
        Me.columnApellido.Name = "columnApellido"
        Me.columnApellido.ReadOnly = True
        Me.columnApellido.Width = 74
        '
        'columnNombre
        '
        Me.columnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnNombre.DataPropertyName = "Nombre"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnNombre.DefaultCellStyle = DataGridViewCellStyle3
        Me.columnNombre.HeaderText = "Nombres"
        Me.columnNombre.Name = "columnNombre"
        Me.columnNombre.ReadOnly = True
        Me.columnNombre.Width = 74
        '
        'panelToolbars
        '
        Me.panelToolbars.AutoSize = True
        Me.panelToolbars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelToolbars.Controls.Add(Me.toolstripBuscar)
        Me.panelToolbars.Controls.Add(Me.toolstripCuartel)
        Me.panelToolbars.Controls.Add(Me.toolstripEstado)
        Me.panelToolbars.Controls.Add(Me.toolstripButtons)
        Me.panelToolbars.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelToolbars.Location = New System.Drawing.Point(0, 0)
        Me.panelToolbars.Name = "panelToolbars"
        Me.panelToolbars.Size = New System.Drawing.Size(613, 64)
        Me.panelToolbars.TabIndex = 3
        '
        'toolstripBuscar
        '
        Me.toolstripBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripBuscar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripBuscar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelBuscar, Me.textboxBuscar, Me.buttonBuscarBorrar})
        Me.toolstripBuscar.Location = New System.Drawing.Point(0, 0)
        Me.toolstripBuscar.Name = "toolstripBuscar"
        Me.toolstripBuscar.Size = New System.Drawing.Size(193, 25)
        Me.toolstripBuscar.TabIndex = 2
        '
        'labelBuscar
        '
        Me.labelBuscar.Name = "labelBuscar"
        Me.labelBuscar.Size = New System.Drawing.Size(45, 22)
        Me.labelBuscar.Text = "Buscar:"
        '
        'textboxBuscar
        '
        Me.textboxBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.textboxBuscar.MaxLength = 100
        Me.textboxBuscar.Name = "textboxBuscar"
        Me.textboxBuscar.Size = New System.Drawing.Size(120, 25)
        '
        'buttonBuscarBorrar
        '
        Me.buttonBuscarBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonBuscarBorrar.Image = Global.CSBomberos.My.Resources.Resources.ImageCerrar16
        Me.buttonBuscarBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonBuscarBorrar.Name = "buttonBuscarBorrar"
        Me.buttonBuscarBorrar.Size = New System.Drawing.Size(23, 22)
        Me.buttonBuscarBorrar.ToolTipText = "Limpiar búsqueda"
        '
        'toolstripCuartel
        '
        Me.toolstripCuartel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripCuartel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripCuartel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelCuartel, Me.comboboxCuartel})
        Me.toolstripCuartel.Location = New System.Drawing.Point(193, 0)
        Me.toolstripCuartel.Name = "toolstripCuartel"
        Me.toolstripCuartel.Size = New System.Drawing.Size(183, 25)
        Me.toolstripCuartel.TabIndex = 4
        '
        'labelCuartel
        '
        Me.labelCuartel.Name = "labelCuartel"
        Me.labelCuartel.Size = New System.Drawing.Size(48, 22)
        Me.labelCuartel.Text = "Cuartel:"
        '
        'comboboxCuartel
        '
        Me.comboboxCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCuartel.Name = "comboboxCuartel"
        Me.comboboxCuartel.Size = New System.Drawing.Size(130, 25)
        '
        'toolstripEstado
        '
        Me.toolstripEstado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripEstado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelEstadoActual, Me.comboboxEstadoActual})
        Me.toolstripEstado.Location = New System.Drawing.Point(376, 0)
        Me.toolstripEstado.Name = "toolstripEstado"
        Me.toolstripEstado.Size = New System.Drawing.Size(235, 25)
        Me.toolstripEstado.TabIndex = 3
        '
        'labelEstadoActual
        '
        Me.labelEstadoActual.Name = "labelEstadoActual"
        Me.labelEstadoActual.Size = New System.Drawing.Size(80, 22)
        Me.labelEstadoActual.Text = "Estado actual:"
        '
        'comboboxEstadoActual
        '
        Me.comboboxEstadoActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxEstadoActual.Name = "comboboxEstadoActual"
        Me.comboboxEstadoActual.Size = New System.Drawing.Size(150, 25)
        '
        'toolstripButtons
        '
        Me.toolstripButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripButtons.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonSeleccionar, Me.buttonCancelar})
        Me.toolstripButtons.Location = New System.Drawing.Point(0, 25)
        Me.toolstripButtons.Name = "toolstripButtons"
        Me.toolstripButtons.Size = New System.Drawing.Size(195, 39)
        Me.toolstripButtons.Stretch = True
        Me.toolstripButtons.TabIndex = 5
        '
        'buttonSeleccionar
        '
        Me.buttonSeleccionar.Image = Global.CSBomberos.My.Resources.Resources.ImageAceptar32
        Me.buttonSeleccionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonSeleccionar.Name = "buttonSeleccionar"
        Me.buttonSeleccionar.Size = New System.Drawing.Size(103, 36)
        Me.buttonSeleccionar.Text = "Seleccionar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Image = Global.CSBomberos.My.Resources.Resources.ImageCancelar32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'formPersonasSeleccionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.panelToolbars)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "formPersonasSeleccionar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seleccione una Persona"
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelToolbars.ResumeLayout(False)
        Me.panelToolbars.PerformLayout()
        Me.toolstripBuscar.ResumeLayout(False)
        Me.toolstripBuscar.PerformLayout()
        Me.toolstripCuartel.ResumeLayout(False)
        Me.toolstripCuartel.PerformLayout()
        Me.toolstripEstado.ResumeLayout(False)
        Me.toolstripEstado.PerformLayout()
        Me.toolstripButtons.ResumeLayout(False)
        Me.toolstripButtons.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents datagridviewMain As System.Windows.Forms.DataGridView
    Friend WithEvents bindingsourceMain As System.Windows.Forms.BindingSource
    Friend WithEvents columnMatrioculaNumero As DataGridViewTextBoxColumn
    Friend WithEvents columnApellido As DataGridViewTextBoxColumn
    Friend WithEvents columnNombre As DataGridViewTextBoxColumn
    Friend WithEvents panelToolbars As FlowLayoutPanel
    Friend WithEvents toolstripBuscar As ToolStrip
    Friend WithEvents labelBuscar As ToolStripLabel
    Friend WithEvents textboxBuscar As ToolStripTextBox
    Friend WithEvents buttonBuscarBorrar As ToolStripButton
    Friend WithEvents toolstripCuartel As ToolStrip
    Friend WithEvents labelCuartel As ToolStripLabel
    Friend WithEvents comboboxCuartel As ToolStripComboBox
    Friend WithEvents toolstripEstado As ToolStrip
    Friend WithEvents labelEstadoActual As ToolStripLabel
    Friend WithEvents comboboxEstadoActual As ToolStripComboBox
    Friend WithEvents toolstripButtons As ToolStrip
    Friend WithEvents buttonSeleccionar As ToolStripButton
    Friend WithEvents buttonCancelar As ToolStripButton
End Class
