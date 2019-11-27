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
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.labelBuscar = New System.Windows.Forms.ToolStripLabel()
        Me.textboxBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.buttonBuscarBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.labelActivo = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxActivo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.buttonSeleccionar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.bindingsourceMain = New System.Windows.Forms.BindingSource(Me.components)
        Me.columnMatrioculaNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripMain.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelBuscar, Me.textboxBuscar, Me.buttonBuscarBorrar, Me.ToolStripSeparator4, Me.labelActivo, Me.comboboxActivo, Me.ToolStripSeparator1, Me.buttonSeleccionar, Me.buttonCancelar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(520, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'labelBuscar
        '
        Me.labelBuscar.Name = "labelBuscar"
        Me.labelBuscar.Size = New System.Drawing.Size(45, 36)
        Me.labelBuscar.Text = "Buscar:"
        '
        'textboxBuscar
        '
        Me.textboxBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.textboxBuscar.MaxLength = 100
        Me.textboxBuscar.Name = "textboxBuscar"
        Me.textboxBuscar.Size = New System.Drawing.Size(120, 39)
        '
        'buttonBuscarBorrar
        '
        Me.buttonBuscarBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonBuscarBorrar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_CLOSE_16
        Me.buttonBuscarBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonBuscarBorrar.Name = "buttonBuscarBorrar"
        Me.buttonBuscarBorrar.Size = New System.Drawing.Size(23, 36)
        Me.buttonBuscarBorrar.ToolTipText = "Limpiar búsqueda"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'labelActivo
        '
        Me.labelActivo.Name = "labelActivo"
        Me.labelActivo.Size = New System.Drawing.Size(41, 36)
        Me.labelActivo.Text = "Activo"
        '
        'comboboxActivo
        '
        Me.comboboxActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxActivo.Name = "comboboxActivo"
        Me.comboboxActivo.Size = New System.Drawing.Size(75, 39)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'buttonSeleccionar
        '
        Me.buttonSeleccionar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_OK_32
        Me.buttonSeleccionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonSeleccionar.Name = "buttonSeleccionar"
        Me.buttonSeleccionar.Size = New System.Drawing.Size(103, 36)
        Me.buttonSeleccionar.Text = "Seleccionar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_CANCEL_32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
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
        Me.datagridviewMain.Location = New System.Drawing.Point(0, 39)
        Me.datagridviewMain.Name = "datagridviewMain"
        Me.datagridviewMain.ReadOnly = True
        Me.datagridviewMain.RowHeadersVisible = False
        Me.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewMain.Size = New System.Drawing.Size(520, 482)
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
        'formPersonasSeleccionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "formPersonasSeleccionar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seleccione una Persona"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents labelBuscar As System.Windows.Forms.ToolStripLabel
    Friend WithEvents textboxBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents buttonBuscarBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents labelActivo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxActivo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents datagridviewMain As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonSeleccionar As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingsourceMain As System.Windows.Forms.BindingSource
    Friend WithEvents columnMatrioculaNumero As DataGridViewTextBoxColumn
    Friend WithEvents columnApellido As DataGridViewTextBoxColumn
    Friend WithEvents columnNombre As DataGridViewTextBoxColumn
End Class
