﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPersonaAscenso
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
        Dim labelCargo As System.Windows.Forms.Label
        Dim labelCargoJerarquia As System.Windows.Forms.Label
        Dim labelFolioNumero As System.Windows.Forms.Label
        Dim labelLibroNumero As System.Windows.Forms.Label
        Dim labelActaNumero As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim labelResolucionNumero As System.Windows.Forms.Label
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.datetimepickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.comboboxCargo = New System.Windows.Forms.ComboBox()
        Me.comboboxCargoJerarquia = New System.Windows.Forms.ComboBox()
        Me.textboxFolioNumero = New System.Windows.Forms.TextBox()
        Me.textboxLibroNumero = New System.Windows.Forms.TextBox()
        Me.textboxActaNumero = New System.Windows.Forms.TextBox()
        Me.tabcontrolMain = New System.Windows.Forms.TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.labelOrdenGeneralNumero = New System.Windows.Forms.Label()
        Me.textboxOrdenGeneralNumero = New System.Windows.Forms.TextBox()
        Me.textboxResolucionNumero = New System.Windows.Forms.TextBox()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.labelIDAscenso = New System.Windows.Forms.Label()
        Me.textboxIDAscenso = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        labelCargo = New System.Windows.Forms.Label()
        labelCargoJerarquia = New System.Windows.Forms.Label()
        labelFolioNumero = New System.Windows.Forms.Label()
        labelLibroNumero = New System.Windows.Forms.Label()
        labelActaNumero = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelResolucionNumero = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelCargo
        '
        labelCargo.AutoSize = True
        labelCargo.Location = New System.Drawing.Point(6, 49)
        labelCargo.Name = "labelCargo"
        labelCargo.Size = New System.Drawing.Size(38, 13)
        labelCargo.TabIndex = 2
        labelCargo.Text = "Cargo:"
        '
        'labelCargoJerarquia
        '
        labelCargoJerarquia.AutoSize = True
        labelCargoJerarquia.Location = New System.Drawing.Point(6, 76)
        labelCargoJerarquia.Name = "labelCargoJerarquia"
        labelCargoJerarquia.Size = New System.Drawing.Size(55, 13)
        labelCargoJerarquia.TabIndex = 4
        labelCargoJerarquia.Text = "Jerarquía:"
        '
        'labelFolioNumero
        '
        labelFolioNumero.AutoSize = True
        labelFolioNumero.Location = New System.Drawing.Point(186, 114)
        labelFolioNumero.Name = "labelFolioNumero"
        labelFolioNumero.Size = New System.Drawing.Size(47, 13)
        labelFolioNumero.TabIndex = 8
        labelFolioNumero.Text = "Folio Nº:"
        '
        'labelLibroNumero
        '
        labelLibroNumero.AutoSize = True
        labelLibroNumero.Location = New System.Drawing.Point(6, 114)
        labelLibroNumero.Name = "labelLibroNumero"
        labelLibroNumero.Size = New System.Drawing.Size(48, 13)
        labelLibroNumero.TabIndex = 6
        labelLibroNumero.Text = "Libro Nº:"
        '
        'labelActaNumero
        '
        labelActaNumero.AutoSize = True
        labelActaNumero.Location = New System.Drawing.Point(319, 114)
        labelActaNumero.Name = "labelActaNumero"
        labelActaNumero.Size = New System.Drawing.Size(47, 13)
        labelActaNumero.TabIndex = 10
        labelActaNumero.Text = "Acta Nº:"
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 145)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 21
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 119)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 18
        labelCreacion.Text = "Creación:"
        '
        'labelResolucionNumero
        '
        labelResolucionNumero.AutoSize = True
        labelResolucionNumero.Location = New System.Drawing.Point(186, 140)
        labelResolucionNumero.Name = "labelResolucionNumero"
        labelResolucionNumero.Size = New System.Drawing.Size(78, 13)
        labelResolucionNumero.TabIndex = 14
        labelResolucionNumero.Text = "Resolución Nº:"
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = Global.CSBomberos.My.Resources.Resources.ImageAceptar32
        Me.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(85, 36)
        Me.buttonGuardar.Text = "Guardar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.CSBomberos.My.Resources.Resources.ImageCancelar32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.CSBomberos.My.Resources.Resources.ImageEditar32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
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
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(542, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'datetimepickerFecha
        '
        Me.datetimepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFecha.Location = New System.Drawing.Point(106, 12)
        Me.datetimepickerFecha.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFecha.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFecha.Name = "datetimepickerFecha"
        Me.datetimepickerFecha.Size = New System.Drawing.Size(116, 20)
        Me.datetimepickerFecha.TabIndex = 1
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(6, 16)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelFecha.TabIndex = 0
        Me.labelFecha.Text = "Fecha:"
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(114, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(386, 78)
        Me.textboxNotas.TabIndex = 15
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(6, 9)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 14
        Me.labelNotas.Text = "Notas:"
        '
        'comboboxCargo
        '
        Me.comboboxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCargo.FormattingEnabled = True
        Me.comboboxCargo.Location = New System.Drawing.Point(106, 46)
        Me.comboboxCargo.Name = "comboboxCargo"
        Me.comboboxCargo.Size = New System.Drawing.Size(340, 21)
        Me.comboboxCargo.TabIndex = 3
        '
        'comboboxCargoJerarquia
        '
        Me.comboboxCargoJerarquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCargoJerarquia.FormattingEnabled = True
        Me.comboboxCargoJerarquia.Location = New System.Drawing.Point(106, 73)
        Me.comboboxCargoJerarquia.Name = "comboboxCargoJerarquia"
        Me.comboboxCargoJerarquia.Size = New System.Drawing.Size(340, 21)
        Me.comboboxCargoJerarquia.TabIndex = 5
        '
        'textboxFolioNumero
        '
        Me.textboxFolioNumero.Location = New System.Drawing.Point(239, 111)
        Me.textboxFolioNumero.MaxLength = 10
        Me.textboxFolioNumero.Name = "textboxFolioNumero"
        Me.textboxFolioNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxFolioNumero.TabIndex = 9
        '
        'textboxLibroNumero
        '
        Me.textboxLibroNumero.Location = New System.Drawing.Point(106, 111)
        Me.textboxLibroNumero.MaxLength = 10
        Me.textboxLibroNumero.Name = "textboxLibroNumero"
        Me.textboxLibroNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxLibroNumero.TabIndex = 7
        '
        'textboxActaNumero
        '
        Me.textboxActaNumero.Location = New System.Drawing.Point(372, 111)
        Me.textboxActaNumero.MaxLength = 10
        Me.textboxActaNumero.Name = "textboxActaNumero"
        Me.textboxActaNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxActaNumero.TabIndex = 11
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(518, 201)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.labelOrdenGeneralNumero)
        Me.tabpageGeneral.Controls.Add(Me.textboxOrdenGeneralNumero)
        Me.tabpageGeneral.Controls.Add(labelResolucionNumero)
        Me.tabpageGeneral.Controls.Add(Me.textboxResolucionNumero)
        Me.tabpageGeneral.Controls.Add(Me.datetimepickerFecha)
        Me.tabpageGeneral.Controls.Add(Me.textboxFolioNumero)
        Me.tabpageGeneral.Controls.Add(Me.labelFecha)
        Me.tabpageGeneral.Controls.Add(labelFolioNumero)
        Me.tabpageGeneral.Controls.Add(labelCargo)
        Me.tabpageGeneral.Controls.Add(labelLibroNumero)
        Me.tabpageGeneral.Controls.Add(Me.comboboxCargo)
        Me.tabpageGeneral.Controls.Add(Me.textboxLibroNumero)
        Me.tabpageGeneral.Controls.Add(labelCargoJerarquia)
        Me.tabpageGeneral.Controls.Add(labelActaNumero)
        Me.tabpageGeneral.Controls.Add(Me.comboboxCargoJerarquia)
        Me.tabpageGeneral.Controls.Add(Me.textboxActaNumero)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(510, 172)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'labelOrdenGeneralNumero
        '
        Me.labelOrdenGeneralNumero.AutoSize = True
        Me.labelOrdenGeneralNumero.Location = New System.Drawing.Point(6, 140)
        Me.labelOrdenGeneralNumero.Name = "labelOrdenGeneralNumero"
        Me.labelOrdenGeneralNumero.Size = New System.Drawing.Size(94, 13)
        Me.labelOrdenGeneralNumero.TabIndex = 12
        Me.labelOrdenGeneralNumero.Text = "Orden General Nº:"
        '
        'textboxOrdenGeneralNumero
        '
        Me.textboxOrdenGeneralNumero.Location = New System.Drawing.Point(106, 137)
        Me.textboxOrdenGeneralNumero.MaxLength = 10
        Me.textboxOrdenGeneralNumero.Name = "textboxOrdenGeneralNumero"
        Me.textboxOrdenGeneralNumero.Size = New System.Drawing.Size(74, 20)
        Me.textboxOrdenGeneralNumero.TabIndex = 13
        '
        'textboxResolucionNumero
        '
        Me.textboxResolucionNumero.Location = New System.Drawing.Point(270, 137)
        Me.textboxResolucionNumero.MaxLength = 15
        Me.textboxResolucionNumero.Name = "textboxResolucionNumero"
        Me.textboxResolucionNumero.Size = New System.Drawing.Size(116, 20)
        Me.textboxResolucionNumero.TabIndex = 15
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelIDAscenso)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxIDAscenso)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(labelModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(labelCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxNotas)
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelNotas)
        Me.tabpageNotasAuditoria.Location = New System.Drawing.Point(4, 25)
        Me.tabpageNotasAuditoria.Name = "tabpageNotasAuditoria"
        Me.tabpageNotasAuditoria.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(510, 172)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelIDAscenso
        '
        Me.labelIDAscenso.AutoSize = True
        Me.labelIDAscenso.Location = New System.Drawing.Point(6, 93)
        Me.labelIDAscenso.Name = "labelIDAscenso"
        Me.labelIDAscenso.Size = New System.Drawing.Size(80, 13)
        Me.labelIDAscenso.TabIndex = 16
        Me.labelIDAscenso.Text = "ID de Ascenso:"
        '
        'textboxIDAscenso
        '
        Me.textboxIDAscenso.Location = New System.Drawing.Point(114, 90)
        Me.textboxIDAscenso.MaxLength = 10
        Me.textboxIDAscenso.Name = "textboxIDAscenso"
        Me.textboxIDAscenso.ReadOnly = True
        Me.textboxIDAscenso.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDAscenso.TabIndex = 17
        Me.textboxIDAscenso.TabStop = False
        Me.textboxIDAscenso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(241, 142)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 23
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(241, 116)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 20
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 142)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 22
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 116)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 19
        '
        'formPersonaAscenso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 253)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPersonaAscenso"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ascenso - Promoción de la Persona"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        Me.tabpageNotasAuditoria.ResumeLayout(False)
        Me.tabpageNotasAuditoria.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents datetimepickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelFecha As System.Windows.Forms.Label
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents comboboxCargo As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxCargoJerarquia As System.Windows.Forms.ComboBox
    Friend WithEvents textboxFolioNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxLibroNumero As System.Windows.Forms.TextBox
    Friend WithEvents textboxActaNumero As System.Windows.Forms.TextBox
    Friend WithEvents tabcontrolMain As System.Windows.Forms.TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents labelIDAscenso As System.Windows.Forms.Label
    Friend WithEvents textboxIDAscenso As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxResolucionNumero As System.Windows.Forms.TextBox
    Friend WithEvents labelOrdenGeneralNumero As Label
    Friend WithEvents textboxOrdenGeneralNumero As TextBox
End Class
