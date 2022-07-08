<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSiniestroAsistenciaPresencial
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
        Dim labelCuartel As System.Windows.Forms.Label
        Me.textboxFecha = New System.Windows.Forms.TextBox()
        Me.textboxCuartel = New System.Windows.Forms.TextBox()
        Me.textboxNumeroCompleto = New System.Windows.Forms.TextBox()
        Me.labelNumero = New System.Windows.Forms.Label()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.chechkboxLeerHuellas = New System.Windows.Forms.CheckBox()
        Me.buttonAsistirConPin = New System.Windows.Forms.Button()
        Me.textboxEstado = New System.Windows.Forms.TextBox()
        labelCuartel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelCuartel
        '
        labelCuartel.AutoSize = True
        labelCuartel.Location = New System.Drawing.Point(10, 15)
        labelCuartel.Name = "labelCuartel"
        labelCuartel.Size = New System.Drawing.Size(43, 13)
        labelCuartel.TabIndex = 3
        labelCuartel.Text = "Cuartel:"
        '
        'textboxFecha
        '
        Me.textboxFecha.Location = New System.Drawing.Point(512, 12)
        Me.textboxFecha.Name = "textboxFecha"
        Me.textboxFecha.ReadOnly = True
        Me.textboxFecha.Size = New System.Drawing.Size(100, 20)
        Me.textboxFecha.TabIndex = 8
        Me.textboxFecha.TabStop = False
        '
        'textboxCuartel
        '
        Me.textboxCuartel.Location = New System.Drawing.Point(59, 12)
        Me.textboxCuartel.Name = "textboxCuartel"
        Me.textboxCuartel.ReadOnly = True
        Me.textboxCuartel.Size = New System.Drawing.Size(212, 20)
        Me.textboxCuartel.TabIndex = 4
        Me.textboxCuartel.TabStop = False
        '
        'textboxNumeroCompleto
        '
        Me.textboxNumeroCompleto.Location = New System.Drawing.Point(343, 12)
        Me.textboxNumeroCompleto.Name = "textboxNumeroCompleto"
        Me.textboxNumeroCompleto.ReadOnly = True
        Me.textboxNumeroCompleto.Size = New System.Drawing.Size(100, 20)
        Me.textboxNumeroCompleto.TabIndex = 6
        Me.textboxNumeroCompleto.TabStop = False
        '
        'labelNumero
        '
        Me.labelNumero.AutoSize = True
        Me.labelNumero.Location = New System.Drawing.Point(290, 15)
        Me.labelNumero.Name = "labelNumero"
        Me.labelNumero.Size = New System.Drawing.Size(47, 13)
        Me.labelNumero.TabIndex = 5
        Me.labelNumero.Text = "Número:"
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(466, 15)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(40, 13)
        Me.labelFecha.TabIndex = 7
        Me.labelFecha.Text = "Fecha:"
        '
        'chechkboxLeerHuellas
        '
        Me.chechkboxLeerHuellas.Appearance = System.Windows.Forms.Appearance.Button
        Me.chechkboxLeerHuellas.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chechkboxLeerHuellas.Image = Global.CSBomberos.My.Resources.Resources.ImageIniciar64
        Me.chechkboxLeerHuellas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.chechkboxLeerHuellas.Location = New System.Drawing.Point(161, 69)
        Me.chechkboxLeerHuellas.Name = "chechkboxLeerHuellas"
        Me.chechkboxLeerHuellas.Size = New System.Drawing.Size(110, 100)
        Me.chechkboxLeerHuellas.TabIndex = 0
        Me.chechkboxLeerHuellas.Text = "Iniciar lectura de huellas digitales"
        Me.chechkboxLeerHuellas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chechkboxLeerHuellas.UseVisualStyleBackColor = True
        '
        'buttonAsistirConPin
        '
        Me.buttonAsistirConPin.Image = Global.CSBomberos.My.Resources.Resources.ImagePinCode64
        Me.buttonAsistirConPin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buttonAsistirConPin.Location = New System.Drawing.Point(343, 69)
        Me.buttonAsistirConPin.Name = "buttonAsistirConPin"
        Me.buttonAsistirConPin.Size = New System.Drawing.Size(110, 100)
        Me.buttonAsistirConPin.TabIndex = 1
        Me.buttonAsistirConPin.Text = "Asistir con PIN"
        Me.buttonAsistirConPin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.buttonAsistirConPin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.buttonAsistirConPin.UseVisualStyleBackColor = True
        '
        'textboxEstado
        '
        Me.textboxEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxEstado.Location = New System.Drawing.Point(13, 190)
        Me.textboxEstado.Name = "textboxEstado"
        Me.textboxEstado.ReadOnly = True
        Me.textboxEstado.Size = New System.Drawing.Size(599, 22)
        Me.textboxEstado.TabIndex = 2
        Me.textboxEstado.TabStop = False
        Me.textboxEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'formSiniestroAsistenciaPresencial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 228)
        Me.Controls.Add(Me.textboxEstado)
        Me.Controls.Add(Me.buttonAsistirConPin)
        Me.Controls.Add(Me.chechkboxLeerHuellas)
        Me.Controls.Add(Me.textboxFecha)
        Me.Controls.Add(Me.textboxCuartel)
        Me.Controls.Add(Me.textboxNumeroCompleto)
        Me.Controls.Add(labelCuartel)
        Me.Controls.Add(Me.labelNumero)
        Me.Controls.Add(Me.labelFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formSiniestroAsistenciaPresencial"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asistencia presencial a Siniestro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textboxFecha As TextBox
    Friend WithEvents textboxCuartel As TextBox
    Friend WithEvents textboxNumeroCompleto As TextBox
    Friend WithEvents labelNumero As Label
    Friend WithEvents labelFecha As Label
    Friend WithEvents chechkboxLeerHuellas As CheckBox
    Friend WithEvents buttonAsistirConPin As Button
    Friend WithEvents textboxEstado As TextBox
End Class
