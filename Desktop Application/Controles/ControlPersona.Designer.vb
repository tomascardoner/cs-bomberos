<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPersona
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.MaskedTextBoxMatriculaNumeroDigitos = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonPersonaBorrar = New System.Windows.Forms.Button()
        Me.ButtonPersona = New System.Windows.Forms.Button()
        Me.ComboBoxApellidoNombre = New System.Windows.Forms.ComboBox()
        Me.TextBoxApellidoNombre = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'MaskedTextBoxMatriculaNumeroDigitos
        '
        Me.MaskedTextBoxMatriculaNumeroDigitos.Location = New System.Drawing.Point(0, 0)
        Me.MaskedTextBoxMatriculaNumeroDigitos.Mask = "999"
        Me.MaskedTextBoxMatriculaNumeroDigitos.Name = "MaskedTextBoxMatriculaNumeroDigitos"
        Me.MaskedTextBoxMatriculaNumeroDigitos.Size = New System.Drawing.Size(27, 20)
        Me.MaskedTextBoxMatriculaNumeroDigitos.TabIndex = 0
        Me.MaskedTextBoxMatriculaNumeroDigitos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonPersonaBorrar
        '
        Me.ButtonPersonaBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPersonaBorrar.Image = Global.CSBomberos.My.Resources.Resources.ImageCerrar16
        Me.ButtonPersonaBorrar.Location = New System.Drawing.Point(181, -1)
        Me.ButtonPersonaBorrar.Name = "ButtonPersonaBorrar"
        Me.ButtonPersonaBorrar.Size = New System.Drawing.Size(22, 22)
        Me.ButtonPersonaBorrar.TabIndex = 3
        Me.ButtonPersonaBorrar.UseVisualStyleBackColor = True
        '
        'ButtonPersona
        '
        Me.ButtonPersona.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPersona.Image = Global.CSBomberos.My.Resources.Resources.ImageBuscar16
        Me.ButtonPersona.Location = New System.Drawing.Point(161, -1)
        Me.ButtonPersona.Name = "ButtonPersona"
        Me.ButtonPersona.Size = New System.Drawing.Size(22, 22)
        Me.ButtonPersona.TabIndex = 2
        Me.ButtonPersona.UseVisualStyleBackColor = True
        '
        'ComboBoxApellidoNombre
        '
        Me.ComboBoxApellidoNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxApellidoNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxApellidoNombre.FormattingEnabled = True
        Me.ComboBoxApellidoNombre.Location = New System.Drawing.Point(26, 0)
        Me.ComboBoxApellidoNombre.Name = "ComboBoxApellidoNombre"
        Me.ComboBoxApellidoNombre.Size = New System.Drawing.Size(138, 21)
        Me.ComboBoxApellidoNombre.TabIndex = 1
        Me.ComboBoxApellidoNombre.Visible = False
        '
        'TextBoxApellidoNombre
        '
        Me.TextBoxApellidoNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxApellidoNombre.Location = New System.Drawing.Point(26, 0)
        Me.TextBoxApellidoNombre.Name = "TextBoxApellidoNombre"
        Me.TextBoxApellidoNombre.ReadOnly = True
        Me.TextBoxApellidoNombre.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxApellidoNombre.TabIndex = 1
        '
        'ControlPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.TextBoxApellidoNombre)
        Me.Controls.Add(Me.ComboBoxApellidoNombre)
        Me.Controls.Add(Me.ButtonPersonaBorrar)
        Me.Controls.Add(Me.ButtonPersona)
        Me.Controls.Add(Me.MaskedTextBoxMatriculaNumeroDigitos)
        Me.MaximumSize = New System.Drawing.Size(1000, 21)
        Me.MinimumSize = New System.Drawing.Size(150, 21)
        Me.Name = "ControlPersona"
        Me.Size = New System.Drawing.Size(202, 21)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaskedTextBoxMatriculaNumeroDigitos As MaskedTextBox
    Friend WithEvents ButtonPersonaBorrar As Button
    Friend WithEvents ButtonPersona As Button
    Friend WithEvents ComboBoxApellidoNombre As ComboBox
    Friend WithEvents TextBoxApellidoNombre As TextBox
End Class
