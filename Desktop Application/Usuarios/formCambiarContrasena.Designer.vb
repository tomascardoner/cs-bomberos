<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCambiarContrasena
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
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonAceptar = New System.Windows.Forms.ToolStripButton()
        Me.textboxPasswordConfirma = New System.Windows.Forms.TextBox()
        Me.labelPasswordConfirma = New System.Windows.Forms.Label()
        Me.textboxPasswordNueva = New System.Windows.Forms.TextBox()
        Me.textboxPasswordAnterior = New System.Windows.Forms.TextBox()
        Me.labelPassword = New System.Windows.Forms.Label()
        Me.labelPasswordAnterior = New System.Windows.Forms.Label()
        Me.pictureboxMain = New System.Windows.Forms.PictureBox()
        Me.toolstripMain.SuspendLayout()
        CType(Me.pictureboxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCancelar, Me.buttonAceptar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(389, 39)
        Me.toolstripMain.TabIndex = 6
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
        'buttonAceptar
        '
        Me.buttonAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonAceptar.Image = Global.CSBomberos.My.Resources.Resources.ImageAceptar32
        Me.buttonAceptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(84, 36)
        Me.buttonAceptar.Text = "Aceptar"
        '
        'textboxPasswordConfirma
        '
        Me.textboxPasswordConfirma.Location = New System.Drawing.Point(166, 122)
        Me.textboxPasswordConfirma.MaxLength = 30
        Me.textboxPasswordConfirma.Name = "textboxPasswordConfirma"
        Me.textboxPasswordConfirma.Size = New System.Drawing.Size(216, 20)
        Me.textboxPasswordConfirma.TabIndex = 5
        Me.textboxPasswordConfirma.UseSystemPasswordChar = True
        '
        'labelPasswordConfirma
        '
        Me.labelPasswordConfirma.AutoSize = True
        Me.labelPasswordConfirma.Location = New System.Drawing.Point(96, 125)
        Me.labelPasswordConfirma.Name = "labelPasswordConfirma"
        Me.labelPasswordConfirma.Size = New System.Drawing.Size(51, 13)
        Me.labelPasswordConfirma.TabIndex = 4
        Me.labelPasswordConfirma.Text = "Confirma:"
        '
        'textboxPasswordNueva
        '
        Me.textboxPasswordNueva.Location = New System.Drawing.Point(165, 89)
        Me.textboxPasswordNueva.MaxLength = 30
        Me.textboxPasswordNueva.Name = "textboxPasswordNueva"
        Me.textboxPasswordNueva.Size = New System.Drawing.Size(216, 20)
        Me.textboxPasswordNueva.TabIndex = 3
        Me.textboxPasswordNueva.UseSystemPasswordChar = True
        '
        'textboxPasswordAnterior
        '
        Me.textboxPasswordAnterior.Location = New System.Drawing.Point(165, 56)
        Me.textboxPasswordAnterior.MaxLength = 30
        Me.textboxPasswordAnterior.Name = "textboxPasswordAnterior"
        Me.textboxPasswordAnterior.Size = New System.Drawing.Size(216, 20)
        Me.textboxPasswordAnterior.TabIndex = 1
        Me.textboxPasswordAnterior.UseSystemPasswordChar = True
        '
        'labelPassword
        '
        Me.labelPassword.AutoSize = True
        Me.labelPassword.Location = New System.Drawing.Point(96, 92)
        Me.labelPassword.Name = "labelPassword"
        Me.labelPassword.Size = New System.Drawing.Size(42, 13)
        Me.labelPassword.TabIndex = 2
        Me.labelPassword.Text = "Nueva:"
        '
        'labelPasswordAnterior
        '
        Me.labelPasswordAnterior.AutoSize = True
        Me.labelPasswordAnterior.Location = New System.Drawing.Point(96, 59)
        Me.labelPasswordAnterior.Name = "labelPasswordAnterior"
        Me.labelPasswordAnterior.Size = New System.Drawing.Size(46, 13)
        Me.labelPasswordAnterior.TabIndex = 0
        Me.labelPasswordAnterior.Text = "Anterior:"
        '
        'pictureboxMain
        '
        Me.pictureboxMain.Image = Global.CSBomberos.My.Resources.Resources.ImageInicioSesion48
        Me.pictureboxMain.Location = New System.Drawing.Point(24, 73)
        Me.pictureboxMain.Name = "pictureboxMain"
        Me.pictureboxMain.Size = New System.Drawing.Size(48, 48)
        Me.pictureboxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureboxMain.TabIndex = 7
        Me.pictureboxMain.TabStop = False
        '
        'formCambiarContrasena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 153)
        Me.ControlBox = False
        Me.Controls.Add(Me.pictureboxMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.Controls.Add(Me.textboxPasswordConfirma)
        Me.Controls.Add(Me.labelPasswordConfirma)
        Me.Controls.Add(Me.textboxPasswordNueva)
        Me.Controls.Add(Me.textboxPasswordAnterior)
        Me.Controls.Add(Me.labelPassword)
        Me.Controls.Add(Me.labelPasswordAnterior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "formCambiarContrasena"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cambio de contraseña"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        CType(Me.pictureboxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents toolstripMain As ToolStrip
    Friend WithEvents buttonCancelar As ToolStripButton
    Friend WithEvents buttonAceptar As ToolStripButton
    Friend WithEvents textboxPasswordConfirma As TextBox
    Friend WithEvents labelPasswordConfirma As Label
    Friend WithEvents textboxPasswordNueva As TextBox
    Friend WithEvents textboxPasswordAnterior As TextBox
    Friend WithEvents labelPassword As Label
    Friend WithEvents labelPasswordAnterior As Label
    Friend WithEvents pictureboxMain As PictureBox
End Class
