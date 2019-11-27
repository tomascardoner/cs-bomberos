<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formReportesParametroFamiliares
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAceptar = New System.Windows.Forms.ToolStripButton()
        Me.labelPersona = New System.Windows.Forms.Label()
        Me.textboxPersona = New System.Windows.Forms.TextBox()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.columnFamiliares_Parentesco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFamiliares_Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFamiliares_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripMain.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCancelar, Me.buttonAceptar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(473, 39)
        Me.toolstripMain.TabIndex = 5
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_CANCEL_32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonAceptar
        '
        Me.buttonAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonAceptar.Image = Global.CSBomberos.My.Resources.Resources.IMAGE_OK_32
        Me.buttonAceptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAceptar.Text = "Aceptar"
        '
        'labelPersona
        '
        Me.labelPersona.AutoSize = True
        Me.labelPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPersona.Location = New System.Drawing.Point(12, 45)
        Me.labelPersona.Name = "labelPersona"
        Me.labelPersona.Size = New System.Drawing.Size(62, 16)
        Me.labelPersona.TabIndex = 6
        Me.labelPersona.Text = "Persona:"
        '
        'textboxPersona
        '
        Me.textboxPersona.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxPersona.Location = New System.Drawing.Point(80, 42)
        Me.textboxPersona.Name = "textboxPersona"
        Me.textboxPersona.ReadOnly = True
        Me.textboxPersona.Size = New System.Drawing.Size(381, 22)
        Me.textboxPersona.TabIndex = 7
        '
        'datagridviewMain
        '
        Me.datagridviewMain.AllowUserToAddRows = False
        Me.datagridviewMain.AllowUserToDeleteRows = False
        Me.datagridviewMain.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnFamiliares_Parentesco, Me.columnFamiliares_Apellido, Me.columnFamiliares_Nombre})
        Me.datagridviewMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewMain.Location = New System.Drawing.Point(12, 70)
        Me.datagridviewMain.MultiSelect = False
        Me.datagridviewMain.Name = "datagridviewMain"
        Me.datagridviewMain.ReadOnly = True
        Me.datagridviewMain.RowHeadersVisible = False
        Me.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewMain.Size = New System.Drawing.Size(449, 318)
        Me.datagridviewMain.TabIndex = 8
        '
        'columnFamiliares_Parentesco
        '
        Me.columnFamiliares_Parentesco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnFamiliares_Parentesco.DataPropertyName = "ParentescoNombre"
        Me.columnFamiliares_Parentesco.HeaderText = "Parentesco"
        Me.columnFamiliares_Parentesco.Name = "columnFamiliares_Parentesco"
        Me.columnFamiliares_Parentesco.ReadOnly = True
        Me.columnFamiliares_Parentesco.Width = 86
        '
        'columnFamiliares_Apellido
        '
        Me.columnFamiliares_Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnFamiliares_Apellido.DataPropertyName = "Apellido"
        Me.columnFamiliares_Apellido.HeaderText = "Appellidos"
        Me.columnFamiliares_Apellido.Name = "columnFamiliares_Apellido"
        Me.columnFamiliares_Apellido.ReadOnly = True
        Me.columnFamiliares_Apellido.Width = 80
        '
        'columnFamiliares_Nombre
        '
        Me.columnFamiliares_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnFamiliares_Nombre.DataPropertyName = "Nombre"
        Me.columnFamiliares_Nombre.HeaderText = "Nombres"
        Me.columnFamiliares_Nombre.Name = "columnFamiliares_Nombre"
        Me.columnFamiliares_Nombre.ReadOnly = True
        Me.columnFamiliares_Nombre.Width = 74
        '
        'formReportesParametroFamiliares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 400)
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.textboxPersona)
        Me.Controls.Add(Me.labelPersona)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formReportesParametroFamiliares"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Especifique los familiares"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents toolstripMain As ToolStrip
    Friend WithEvents buttonCancelar As ToolStripButton
    Friend WithEvents buttonAceptar As ToolStripButton
    Friend WithEvents labelPersona As Label
    Friend WithEvents textboxPersona As TextBox
    Friend WithEvents datagridviewMain As DataGridView
    Friend WithEvents columnFamiliares_Parentesco As DataGridViewTextBoxColumn
    Friend WithEvents columnFamiliares_Apellido As DataGridViewTextBoxColumn
    Friend WithEvents columnFamiliares_Nombre As DataGridViewTextBoxColumn
End Class
