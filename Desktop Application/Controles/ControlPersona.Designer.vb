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
        Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaskedTextBoxMatriculaNumeroDigitos
        '
        Me.MaskedTextBoxMatriculaNumeroDigitos.Location = New System.Drawing.Point(0, 0)
        Me.MaskedTextBoxMatriculaNumeroDigitos.Margin = New System.Windows.Forms.Padding(0)
        Me.MaskedTextBoxMatriculaNumeroDigitos.Mask = "999"
        Me.MaskedTextBoxMatriculaNumeroDigitos.Name = "MaskedTextBoxMatriculaNumeroDigitos"
        Me.MaskedTextBoxMatriculaNumeroDigitos.Size = New System.Drawing.Size(40, 22)
        Me.MaskedTextBoxMatriculaNumeroDigitos.TabIndex = 0
        Me.MaskedTextBoxMatriculaNumeroDigitos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonPersonaBorrar
        '
        Me.ButtonPersonaBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPersonaBorrar.Image = Global.CSBomberos.My.Resources.Resources.ImageCerrar16
        Me.ButtonPersonaBorrar.Location = New System.Drawing.Point(171, 0)
        Me.ButtonPersonaBorrar.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPersonaBorrar.Name = "ButtonPersonaBorrar"
        Me.ButtonPersonaBorrar.Size = New System.Drawing.Size(29, 24)
        Me.ButtonPersonaBorrar.TabIndex = 3
        Me.ButtonPersonaBorrar.UseVisualStyleBackColor = True
        '
        'ButtonPersona
        '
        Me.ButtonPersona.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPersona.Image = Global.CSBomberos.My.Resources.Resources.ImageBuscar16
        Me.ButtonPersona.Location = New System.Drawing.Point(142, 0)
        Me.ButtonPersona.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPersona.Name = "ButtonPersona"
        Me.ButtonPersona.Size = New System.Drawing.Size(29, 24)
        Me.ButtonPersona.TabIndex = 2
        Me.ButtonPersona.UseVisualStyleBackColor = True
        '
        'ComboBoxApellidoNombre
        '
        Me.ComboBoxApellidoNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxApellidoNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxApellidoNombre.FormattingEnabled = True
        Me.ComboBoxApellidoNombre.Location = New System.Drawing.Point(0, 0)
        Me.ComboBoxApellidoNombre.Margin = New System.Windows.Forms.Padding(0)
        Me.ComboBoxApellidoNombre.Name = "ComboBoxApellidoNombre"
        Me.ComboBoxApellidoNombre.Size = New System.Drawing.Size(51, 24)
        Me.ComboBoxApellidoNombre.TabIndex = 1
        Me.ComboBoxApellidoNombre.Visible = False
        '
        'TextBoxApellidoNombre
        '
        Me.TextBoxApellidoNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxApellidoNombre.Location = New System.Drawing.Point(40, 0)
        Me.TextBoxApellidoNombre.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxApellidoNombre.Name = "TextBoxApellidoNombre"
        Me.TextBoxApellidoNombre.ReadOnly = True
        Me.TextBoxApellidoNombre.Size = New System.Drawing.Size(102, 22)
        Me.TextBoxApellidoNombre.TabIndex = 1
        '
        'TableLayoutPanelMain
        '
        Me.TableLayoutPanelMain.AutoSize = True
        Me.TableLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelMain.ColumnCount = 4
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.Controls.Add(Me.MaskedTextBoxMatriculaNumeroDigitos, 0, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.TextBoxApellidoNombre, 1, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.ButtonPersona, 2, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.ButtonPersonaBorrar, 3, 0)
        Me.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanelMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelMain.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        Me.TableLayoutPanelMain.RowCount = 1
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.Size = New System.Drawing.Size(200, 24)
        Me.TableLayoutPanelMain.TabIndex = 0
        '
        'ControlPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanelMain)
        Me.Controls.Add(Me.ComboBoxApellidoNombre)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(200, 0)
        Me.Name = "ControlPersona"
        Me.Size = New System.Drawing.Size(200, 24)
        Me.TableLayoutPanelMain.ResumeLayout(False)
        Me.TableLayoutPanelMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaskedTextBoxMatriculaNumeroDigitos As MaskedTextBox
    Friend WithEvents ButtonPersonaBorrar As Button
    Friend WithEvents ButtonPersona As Button
    Friend WithEvents ComboBoxApellidoNombre As ComboBox
    Friend WithEvents TextBoxApellidoNombre As TextBox
    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
End Class
