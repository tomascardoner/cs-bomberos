﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formSiniestroAsistenciaPresencial
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
        Dim labelCuartel As System.Windows.Forms.Label
        Me.textboxFecha = New System.Windows.Forms.TextBox()
        Me.textboxCuartel = New System.Windows.Forms.TextBox()
        Me.textboxNumeroCompleto = New System.Windows.Forms.TextBox()
        Me.labelNumero = New System.Windows.Forms.Label()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.buttonAsistirConPin = New System.Windows.Forms.Button()
        Me.textboxPersona = New System.Windows.Forms.TextBox()
        Me.verificationcontrolHuellas = New DPFP.Gui.Verification.VerificationControl()
        Me.pictureboxFoto = New System.Windows.Forms.PictureBox()
        Me.pictureboxFlecha = New System.Windows.Forms.PictureBox()
        Me.textboxEstado = New System.Windows.Forms.TextBox()
        labelCuartel = New System.Windows.Forms.Label()
        CType(Me.pictureboxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureboxFlecha, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'buttonAsistirConPin
        '
        Me.buttonAsistirConPin.Image = Global.CSBomberos.My.Resources.Resources.ImagePinCode64
        Me.buttonAsistirConPin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buttonAsistirConPin.Location = New System.Drawing.Point(271, 190)
        Me.buttonAsistirConPin.Name = "buttonAsistirConPin"
        Me.buttonAsistirConPin.Size = New System.Drawing.Size(85, 87)
        Me.buttonAsistirConPin.TabIndex = 1
        Me.buttonAsistirConPin.Text = "Asistir con PIN"
        Me.buttonAsistirConPin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.buttonAsistirConPin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.buttonAsistirConPin.UseVisualStyleBackColor = True
        '
        'textboxPersona
        '
        Me.textboxPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxPersona.Location = New System.Drawing.Point(227, 87)
        Me.textboxPersona.Name = "textboxPersona"
        Me.textboxPersona.ReadOnly = True
        Me.textboxPersona.Size = New System.Drawing.Size(388, 22)
        Me.textboxPersona.TabIndex = 2
        Me.textboxPersona.TabStop = False
        '
        'verificationcontrolHuellas
        '
        Me.verificationcontrolHuellas.Active = True
        Me.verificationcontrolHuellas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.verificationcontrolHuellas.Location = New System.Drawing.Point(13, 87)
        Me.verificationcontrolHuellas.Name = "verificationcontrolHuellas"
        Me.verificationcontrolHuellas.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000"
        Me.verificationcontrolHuellas.Size = New System.Drawing.Size(48, 48)
        Me.verificationcontrolHuellas.TabIndex = 9
        '
        'pictureboxFoto
        '
        Me.pictureboxFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureboxFoto.Location = New System.Drawing.Point(131, 66)
        Me.pictureboxFoto.Name = "pictureboxFoto"
        Me.pictureboxFoto.Size = New System.Drawing.Size(90, 90)
        Me.pictureboxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureboxFoto.TabIndex = 94
        Me.pictureboxFoto.TabStop = False
        '
        'pictureboxFlecha
        '
        Me.pictureboxFlecha.Image = Global.CSBomberos.My.Resources.Resources.ImageSiguiente24
        Me.pictureboxFlecha.Location = New System.Drawing.Point(80, 101)
        Me.pictureboxFlecha.Name = "pictureboxFlecha"
        Me.pictureboxFlecha.Size = New System.Drawing.Size(24, 24)
        Me.pictureboxFlecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureboxFlecha.TabIndex = 95
        Me.pictureboxFlecha.TabStop = False
        '
        'textboxEstado
        '
        Me.textboxEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxEstado.Location = New System.Drawing.Point(227, 113)
        Me.textboxEstado.Name = "textboxEstado"
        Me.textboxEstado.ReadOnly = True
        Me.textboxEstado.Size = New System.Drawing.Size(388, 22)
        Me.textboxEstado.TabIndex = 3
        Me.textboxEstado.TabStop = False
        '
        'formSiniestroAsistenciaPresencial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 289)
        Me.Controls.Add(Me.textboxEstado)
        Me.Controls.Add(Me.pictureboxFlecha)
        Me.Controls.Add(Me.pictureboxFoto)
        Me.Controls.Add(Me.verificationcontrolHuellas)
        Me.Controls.Add(Me.textboxPersona)
        Me.Controls.Add(Me.buttonAsistirConPin)
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
        CType(Me.pictureboxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureboxFlecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textboxFecha As TextBox
    Friend WithEvents textboxCuartel As TextBox
    Friend WithEvents textboxNumeroCompleto As TextBox
    Friend WithEvents labelNumero As Label
    Friend WithEvents labelFecha As Label
    Friend WithEvents buttonAsistirConPin As Button
    Friend WithEvents textboxPersona As TextBox
    Friend WithEvents verificationcontrolHuellas As DPFP.Gui.Verification.VerificationControl
    Friend WithEvents pictureboxFoto As PictureBox
    Friend WithEvents pictureboxFlecha As PictureBox
    Friend WithEvents textboxEstado As TextBox
End Class