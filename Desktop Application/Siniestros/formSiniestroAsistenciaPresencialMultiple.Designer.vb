<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formSiniestroAsistenciaPresencialMultiple
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBoxHuellaDigital = New System.Windows.Forms.GroupBox()
        Me.buttonAsignar = New System.Windows.Forms.Button()
        Me.textboxEstado = New System.Windows.Forms.TextBox()
        Me.pictureboxFlecha = New System.Windows.Forms.PictureBox()
        Me.pictureboxFoto = New System.Windows.Forms.PictureBox()
        Me.verificationcontrolHuellas = New DPFP.Gui.Verification.VerificationControl()
        Me.textboxPersona = New System.Windows.Forms.TextBox()
        Me.GroupBoxPin = New System.Windows.Forms.GroupBox()
        Me.buttonAsistirConPin = New System.Windows.Forms.Button()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.ColumnSeleccionado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.columnCuartel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnClave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMensaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.controlPersonaAsignar = New CSBomberos.ControlPersona()
        Me.toolstripMain.SuspendLayout()
        Me.GroupBoxHuellaDigital.SuspendLayout()
        CType(Me.pictureboxFlecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureboxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxPin.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(645, 39)
        Me.toolstripMain.TabIndex = 3
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSBomberos.My.Resources.Resources.ImageCerrar32
        Me.buttonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCerrar.Name = "buttonCerrar"
        Me.buttonCerrar.Size = New System.Drawing.Size(75, 36)
        Me.buttonCerrar.Text = "Cerrar"
        '
        'GroupBoxHuellaDigital
        '
        Me.GroupBoxHuellaDigital.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxHuellaDigital.Controls.Add(Me.controlPersonaAsignar)
        Me.GroupBoxHuellaDigital.Controls.Add(Me.buttonAsignar)
        Me.GroupBoxHuellaDigital.Controls.Add(Me.textboxEstado)
        Me.GroupBoxHuellaDigital.Controls.Add(Me.pictureboxFlecha)
        Me.GroupBoxHuellaDigital.Controls.Add(Me.pictureboxFoto)
        Me.GroupBoxHuellaDigital.Controls.Add(Me.verificationcontrolHuellas)
        Me.GroupBoxHuellaDigital.Controls.Add(Me.textboxPersona)
        Me.GroupBoxHuellaDigital.Location = New System.Drawing.Point(12, 210)
        Me.GroupBoxHuellaDigital.Name = "GroupBoxHuellaDigital"
        Me.GroupBoxHuellaDigital.Size = New System.Drawing.Size(621, 116)
        Me.GroupBoxHuellaDigital.TabIndex = 1
        Me.GroupBoxHuellaDigital.TabStop = False
        Me.GroupBoxHuellaDigital.Text = "Con huella digital"
        '
        'buttonAsignar
        '
        Me.buttonAsignar.Location = New System.Drawing.Point(544, 82)
        Me.buttonAsignar.Name = "buttonAsignar"
        Me.buttonAsignar.Size = New System.Drawing.Size(66, 21)
        Me.buttonAsignar.TabIndex = 4
        Me.buttonAsignar.Text = "Asignar"
        Me.buttonAsignar.UseVisualStyleBackColor = True
        Me.buttonAsignar.Visible = False
        '
        'textboxEstado
        '
        Me.textboxEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxEstado.Location = New System.Drawing.Point(222, 54)
        Me.textboxEstado.Name = "textboxEstado"
        Me.textboxEstado.ReadOnly = True
        Me.textboxEstado.Size = New System.Drawing.Size(388, 22)
        Me.textboxEstado.TabIndex = 2
        Me.textboxEstado.TabStop = False
        '
        'pictureboxFlecha
        '
        Me.pictureboxFlecha.Image = Global.CSBomberos.My.Resources.Resources.ImageSiguiente24
        Me.pictureboxFlecha.Location = New System.Drawing.Point(75, 54)
        Me.pictureboxFlecha.Name = "pictureboxFlecha"
        Me.pictureboxFlecha.Size = New System.Drawing.Size(24, 24)
        Me.pictureboxFlecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureboxFlecha.TabIndex = 102
        Me.pictureboxFlecha.TabStop = False
        '
        'pictureboxFoto
        '
        Me.pictureboxFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureboxFoto.Location = New System.Drawing.Point(126, 19)
        Me.pictureboxFoto.Name = "pictureboxFoto"
        Me.pictureboxFoto.Size = New System.Drawing.Size(90, 90)
        Me.pictureboxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureboxFoto.TabIndex = 101
        Me.pictureboxFoto.TabStop = False
        '
        'verificationcontrolHuellas
        '
        Me.verificationcontrolHuellas.Active = True
        Me.verificationcontrolHuellas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.verificationcontrolHuellas.Location = New System.Drawing.Point(8, 40)
        Me.verificationcontrolHuellas.Name = "verificationcontrolHuellas"
        Me.verificationcontrolHuellas.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000"
        Me.verificationcontrolHuellas.Size = New System.Drawing.Size(48, 48)
        Me.verificationcontrolHuellas.TabIndex = 0
        '
        'textboxPersona
        '
        Me.textboxPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxPersona.Location = New System.Drawing.Point(222, 28)
        Me.textboxPersona.Name = "textboxPersona"
        Me.textboxPersona.ReadOnly = True
        Me.textboxPersona.Size = New System.Drawing.Size(388, 22)
        Me.textboxPersona.TabIndex = 1
        Me.textboxPersona.TabStop = False
        '
        'GroupBoxPin
        '
        Me.GroupBoxPin.Controls.Add(Me.buttonAsistirConPin)
        Me.GroupBoxPin.Location = New System.Drawing.Point(12, 332)
        Me.GroupBoxPin.Name = "GroupBoxPin"
        Me.GroupBoxPin.Size = New System.Drawing.Size(621, 115)
        Me.GroupBoxPin.TabIndex = 2
        Me.GroupBoxPin.TabStop = False
        Me.GroupBoxPin.Text = "Con PIN"
        '
        'buttonAsistirConPin
        '
        Me.buttonAsistirConPin.Image = Global.CSBomberos.My.Resources.Resources.ImagePinCode64
        Me.buttonAsistirConPin.Location = New System.Drawing.Point(9, 23)
        Me.buttonAsistirConPin.Name = "buttonAsistirConPin"
        Me.buttonAsistirConPin.Size = New System.Drawing.Size(80, 80)
        Me.buttonAsistirConPin.TabIndex = 0
        Me.buttonAsistirConPin.UseVisualStyleBackColor = True
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
        Me.datagridviewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagridviewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnSeleccionado, Me.columnCuartel, Me.columnNumero, Me.columnFecha, Me.columnClave, Me.columnMensaje})
        Me.datagridviewMain.Location = New System.Drawing.Point(12, 42)
        Me.datagridviewMain.MultiSelect = False
        Me.datagridviewMain.Name = "datagridviewMain"
        Me.datagridviewMain.RowHeadersVisible = False
        Me.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewMain.Size = New System.Drawing.Size(621, 162)
        Me.datagridviewMain.TabIndex = 4
        '
        'TimerMain
        '
        Me.TimerMain.Interval = 30000
        '
        'ColumnSeleccionado
        '
        Me.ColumnSeleccionado.DataPropertyName = "Seleccionado"
        Me.ColumnSeleccionado.HeaderText = ""
        Me.ColumnSeleccionado.Name = "ColumnSeleccionado"
        Me.ColumnSeleccionado.Width = 5
        '
        'columnCuartel
        '
        Me.columnCuartel.DataPropertyName = "CuartelNombre"
        Me.columnCuartel.HeaderText = "Cuartel"
        Me.columnCuartel.Name = "columnCuartel"
        Me.columnCuartel.ReadOnly = True
        Me.columnCuartel.Width = 65
        '
        'columnNumero
        '
        Me.columnNumero.DataPropertyName = "NumeroCompleto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.columnNumero.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnNumero.HeaderText = "Número"
        Me.columnNumero.Name = "columnNumero"
        Me.columnNumero.ReadOnly = True
        Me.columnNumero.Width = 69
        '
        'columnFecha
        '
        Me.columnFecha.DataPropertyName = "Fecha"
        Me.columnFecha.HeaderText = "Fecha"
        Me.columnFecha.Name = "columnFecha"
        Me.columnFecha.ReadOnly = True
        Me.columnFecha.Width = 62
        '
        'columnClave
        '
        Me.columnClave.DataPropertyName = "ClaveNombre"
        Me.columnClave.HeaderText = "Clave"
        Me.columnClave.Name = "columnClave"
        Me.columnClave.ReadOnly = True
        Me.columnClave.Width = 59
        '
        'columnMensaje
        '
        Me.columnMensaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnMensaje.DataPropertyName = "Mensaje"
        Me.columnMensaje.HeaderText = "Mensaje"
        Me.columnMensaje.Name = "columnMensaje"
        Me.columnMensaje.ReadOnly = True
        '
        'controlPersonaAsignar
        '
        Me.controlPersonaAsignar.ApellidoNombre = Nothing
        Me.controlPersonaAsignar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.controlPersonaAsignar.dbContext = Nothing
        Me.controlPersonaAsignar.IDCuartel = Nothing
        Me.controlPersonaAsignar.IDPersona = Nothing
        Me.controlPersonaAsignar.Location = New System.Drawing.Point(222, 82)
        Me.controlPersonaAsignar.MatriculaNumeroDigitos = Nothing
        Me.controlPersonaAsignar.MaximumSize = New System.Drawing.Size(1000, 21)
        Me.controlPersonaAsignar.MinimumSize = New System.Drawing.Size(150, 21)
        Me.controlPersonaAsignar.Name = "controlPersonaAsignar"
        Me.controlPersonaAsignar.ReadOnlyText = False
        Me.controlPersonaAsignar.Size = New System.Drawing.Size(316, 21)
        Me.controlPersonaAsignar.SoloMostrarEnAsistencia = False
        Me.controlPersonaAsignar.SoloMostrarEstadoActivo = True
        Me.controlPersonaAsignar.TabIndex = 3
        Me.controlPersonaAsignar.Visible = False
        '
        'formSiniestroAsistenciaPresencialMultiple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 459)
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.GroupBoxPin)
        Me.Controls.Add(Me.GroupBoxHuellaDigital)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formSiniestroAsistenciaPresencialMultiple"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asistencia presencial a Siniestro"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.GroupBoxHuellaDigital.ResumeLayout(False)
        Me.GroupBoxHuellaDigital.PerformLayout()
        CType(Me.pictureboxFlecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureboxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxPin.ResumeLayout(False)
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripMain As ToolStrip
    Friend WithEvents buttonCerrar As ToolStripButton
    Friend WithEvents GroupBoxHuellaDigital As GroupBox
    Friend WithEvents controlPersonaAsignar As ControlPersona
    Friend WithEvents buttonAsignar As Button
    Friend WithEvents textboxEstado As TextBox
    Friend WithEvents pictureboxFlecha As PictureBox
    Friend WithEvents pictureboxFoto As PictureBox
    Friend WithEvents verificationcontrolHuellas As DPFP.Gui.Verification.VerificationControl
    Friend WithEvents textboxPersona As TextBox
    Friend WithEvents GroupBoxPin As GroupBox
    Friend WithEvents buttonAsistirConPin As Button
    Friend WithEvents datagridviewMain As DataGridView
    Friend WithEvents TimerMain As Timer
    Friend WithEvents ColumnSeleccionado As DataGridViewCheckBoxColumn
    Friend WithEvents columnCuartel As DataGridViewTextBoxColumn
    Friend WithEvents columnNumero As DataGridViewTextBoxColumn
    Friend WithEvents columnFecha As DataGridViewTextBoxColumn
    Friend WithEvents columnClave As DataGridViewTextBoxColumn
    Friend WithEvents columnMensaje As DataGridViewTextBoxColumn
End Class
