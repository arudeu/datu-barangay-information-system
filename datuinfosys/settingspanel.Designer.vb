<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class settingspanel
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.icb_settingsuser = New FontAwesome.Sharp.IconButton()
        Me.icb_settingsbrgy = New FontAwesome.Sharp.IconButton()
        Me.subpnl_settings = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.icb_settingsuser)
        Me.Panel1.Controls.Add(Me.icb_settingsbrgy)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 61)
        Me.Panel1.TabIndex = 1
        '
        'icb_settingsuser
        '
        Me.icb_settingsuser.Dock = System.Windows.Forms.DockStyle.Left
        Me.icb_settingsuser.FlatAppearance.BorderSize = 0
        Me.icb_settingsuser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.icb_settingsuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.icb_settingsuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.icb_settingsuser.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.icb_settingsuser.IconChar = FontAwesome.Sharp.IconChar.Male
        Me.icb_settingsuser.IconColor = System.Drawing.Color.Fuchsia
        Me.icb_settingsuser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.icb_settingsuser.IconSize = 30
        Me.icb_settingsuser.Location = New System.Drawing.Point(171, 0)
        Me.icb_settingsuser.Name = "icb_settingsuser"
        Me.icb_settingsuser.Size = New System.Drawing.Size(171, 61)
        Me.icb_settingsuser.TabIndex = 2
        Me.icb_settingsuser.Text = "Users"
        Me.icb_settingsuser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.icb_settingsuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.icb_settingsuser.UseVisualStyleBackColor = True
        '
        'icb_settingsbrgy
        '
        Me.icb_settingsbrgy.Dock = System.Windows.Forms.DockStyle.Left
        Me.icb_settingsbrgy.FlatAppearance.BorderSize = 0
        Me.icb_settingsbrgy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.icb_settingsbrgy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.icb_settingsbrgy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.icb_settingsbrgy.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.icb_settingsbrgy.IconChar = FontAwesome.Sharp.IconChar.Building
        Me.icb_settingsbrgy.IconColor = System.Drawing.Color.Fuchsia
        Me.icb_settingsbrgy.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.icb_settingsbrgy.IconSize = 30
        Me.icb_settingsbrgy.Location = New System.Drawing.Point(0, 0)
        Me.icb_settingsbrgy.Name = "icb_settingsbrgy"
        Me.icb_settingsbrgy.Size = New System.Drawing.Size(171, 61)
        Me.icb_settingsbrgy.TabIndex = 3
        Me.icb_settingsbrgy.Text = "Barangay"
        Me.icb_settingsbrgy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.icb_settingsbrgy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.icb_settingsbrgy.UseVisualStyleBackColor = True
        '
        'subpnl_settings
        '
        Me.subpnl_settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.subpnl_settings.Location = New System.Drawing.Point(0, 61)
        Me.subpnl_settings.Name = "subpnl_settings"
        Me.subpnl_settings.Size = New System.Drawing.Size(1256, 1000)
        Me.subpnl_settings.TabIndex = 2
        '
        'settingspanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1256, 1061)
        Me.Controls.Add(Me.subpnl_settings)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "settingspanel"
        Me.Text = "settingspanel"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents icb_settingsuser As FontAwesome.Sharp.IconButton
    Friend WithEvents subpnl_settings As Panel
    Friend WithEvents icb_settingsbrgy As FontAwesome.Sharp.IconButton
End Class
