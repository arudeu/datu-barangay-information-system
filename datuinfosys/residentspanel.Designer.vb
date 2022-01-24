<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class residentspanel
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
        Me.btn_addresident = New FontAwesome.Sharp.IconButton()
        Me.btn_residentslist = New FontAwesome.Sharp.IconButton()
        Me.subpnl_residents = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btn_addresident)
        Me.Panel1.Controls.Add(Me.btn_residentslist)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1248, 61)
        Me.Panel1.TabIndex = 2
        '
        'btn_addresident
        '
        Me.btn_addresident.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_addresident.FlatAppearance.BorderSize = 0
        Me.btn_addresident.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_addresident.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_addresident.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addresident.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addresident.IconChar = FontAwesome.Sharp.IconChar.Male
        Me.btn_addresident.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_addresident.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_addresident.IconSize = 30
        Me.btn_addresident.Location = New System.Drawing.Point(171, 0)
        Me.btn_addresident.Name = "btn_addresident"
        Me.btn_addresident.Size = New System.Drawing.Size(213, 61)
        Me.btn_addresident.TabIndex = 2
        Me.btn_addresident.Text = "Add/Edit Resident"
        Me.btn_addresident.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_addresident.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_addresident.UseVisualStyleBackColor = True
        '
        'btn_residentslist
        '
        Me.btn_residentslist.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_residentslist.FlatAppearance.BorderSize = 0
        Me.btn_residentslist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_residentslist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_residentslist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_residentslist.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_residentslist.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.btn_residentslist.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_residentslist.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_residentslist.IconSize = 30
        Me.btn_residentslist.Location = New System.Drawing.Point(0, 0)
        Me.btn_residentslist.Name = "btn_residentslist"
        Me.btn_residentslist.Size = New System.Drawing.Size(171, 61)
        Me.btn_residentslist.TabIndex = 1
        Me.btn_residentslist.Text = "Resident List"
        Me.btn_residentslist.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_residentslist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_residentslist.UseVisualStyleBackColor = True
        '
        'subpnl_residents
        '
        Me.subpnl_residents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.subpnl_residents.Location = New System.Drawing.Point(0, 61)
        Me.subpnl_residents.Name = "subpnl_residents"
        Me.subpnl_residents.Size = New System.Drawing.Size(1248, 520)
        Me.subpnl_residents.TabIndex = 3
        '
        'residentspanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1248, 581)
        Me.Controls.Add(Me.subpnl_residents)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "residentspanel"
        Me.Text = "residentspanel"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_addresident As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_residentslist As FontAwesome.Sharp.IconButton
    Friend WithEvents subpnl_residents As Panel
End Class
