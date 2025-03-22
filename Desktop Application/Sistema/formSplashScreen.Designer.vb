<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSplashScreen))
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.LabelLicensedTo = New System.Windows.Forms.Label()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelCompanyName = New System.Windows.Forms.Label()
        Me.LabelAppTitle = New System.Windows.Forms.Label()
        Me.TableLayoutPanelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelCopyright
        '
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.BackColor = System.Drawing.Color.Transparent
        Me.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCopyright.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCopyright.ForeColor = System.Drawing.Color.White
        Me.LabelCopyright.Location = New System.Drawing.Point(4, 369)
        Me.LabelCopyright.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(592, 18)
        Me.LabelCopyright.TabIndex = 2
        Me.LabelCopyright.Text = "Copyright"
        Me.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelLicensedTo
        '
        Me.LabelLicensedTo.AutoSize = True
        Me.LabelLicensedTo.BackColor = System.Drawing.Color.Transparent
        Me.LabelLicensedTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelLicensedTo.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLicensedTo.ForeColor = System.Drawing.Color.White
        Me.LabelLicensedTo.Location = New System.Drawing.Point(4, 221)
        Me.LabelLicensedTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelLicensedTo.Name = "LabelLicensedTo"
        Me.LabelLicensedTo.Size = New System.Drawing.Size(592, 33)
        Me.LabelLicensedTo.TabIndex = 4
        Me.LabelLicensedTo.Text = "LicensedTo"
        Me.LabelLicensedTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabelStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.ForeColor = System.Drawing.Color.White
        Me.LabelStatus.Location = New System.Drawing.Point(4, 331)
        Me.LabelStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(592, 18)
        Me.LabelStatus.TabIndex = 5
        Me.LabelStatus.Text = "Status"
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanelMain
        '
        Me.TableLayoutPanelMain.AutoSize = True
        Me.TableLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelMain.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanelMain.ColumnCount = 1
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelCompanyName, 0, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelAppTitle, 0, 2)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelLicensedTo, 0, 4)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelStatus, 0, 6)
        Me.TableLayoutPanelMain.Controls.Add(Me.LabelCopyright, 0, 8)
        Me.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanelMain.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        Me.TableLayoutPanelMain.RowCount = 10
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanelMain.Size = New System.Drawing.Size(600, 399)
        Me.TableLayoutPanelMain.TabIndex = 6
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.AutoSize = True
        Me.LabelCompanyName.BackColor = System.Drawing.Color.Transparent
        Me.LabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCompanyName.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCompanyName.ForeColor = System.Drawing.Color.Gold
        Me.LabelCompanyName.Location = New System.Drawing.Point(4, 48)
        Me.LabelCompanyName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.LabelCompanyName.Size = New System.Drawing.Size(592, 29)
        Me.LabelCompanyName.TabIndex = 2
        Me.LabelCompanyName.Text = "CompanyName"
        '
        'LabelAppTitle
        '
        Me.LabelAppTitle.AutoSize = True
        Me.LabelAppTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelAppTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelAppTitle.Font = New System.Drawing.Font("Tahoma", 38.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAppTitle.ForeColor = System.Drawing.Color.White
        Me.LabelAppTitle.Location = New System.Drawing.Point(4, 77)
        Me.LabelAppTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAppTitle.Name = "LabelAppTitle"
        Me.LabelAppTitle.Size = New System.Drawing.Size(592, 77)
        Me.LabelAppTitle.TabIndex = 3
        Me.LabelAppTitle.Text = "Title"
        '
        'FormSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "App.Title"
        Me.TableLayoutPanelMain.ResumeLayout(False)
        Me.TableLayoutPanelMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label
    Friend WithEvents LabelLicensedTo As System.Windows.Forms.Label
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
    Friend WithEvents LabelAppTitle As Label
    Friend WithEvents LabelCompanyName As Label
End Class
