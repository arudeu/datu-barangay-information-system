<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qrscanner
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb_qrscanner = New System.Windows.Forms.PictureBox()
        Me.btn_cam = New FontAwesome.Sharp.IconButton()
        Me.btn_capture = New FontAwesome.Sharp.IconButton()
        Me.btn_next = New FontAwesome.Sharp.IconButton()
        Me.pb_captured = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_qrscanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_captured, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pb_captured)
        Me.Panel1.Controls.Add(Me.pb_qrscanner)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(396, 400)
        Me.Panel1.TabIndex = 0
        '
        'pb_qrscanner
        '
        Me.pb_qrscanner.BackColor = System.Drawing.Color.Black
        Me.pb_qrscanner.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb_qrscanner.Location = New System.Drawing.Point(0, 0)
        Me.pb_qrscanner.Name = "pb_qrscanner"
        Me.pb_qrscanner.Size = New System.Drawing.Size(396, 200)
        Me.pb_qrscanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_qrscanner.TabIndex = 0
        Me.pb_qrscanner.TabStop = False
        '
        'btn_cam
        '
        Me.btn_cam.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cam.FlatAppearance.BorderSize = 0
        Me.btn_cam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_cam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_cam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cam.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cam.IconChar = FontAwesome.Sharp.IconChar.Camera
        Me.btn_cam.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_cam.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_cam.IconSize = 20
        Me.btn_cam.Location = New System.Drawing.Point(89, 406)
        Me.btn_cam.Name = "btn_cam"
        Me.btn_cam.Size = New System.Drawing.Size(69, 56)
        Me.btn_cam.TabIndex = 7
        Me.btn_cam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_cam.UseVisualStyleBackColor = False
        '
        'btn_capture
        '
        Me.btn_capture.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_capture.FlatAppearance.BorderSize = 0
        Me.btn_capture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_capture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_capture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_capture.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_capture.IconChar = FontAwesome.Sharp.IconChar.Circle
        Me.btn_capture.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_capture.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_capture.IconSize = 20
        Me.btn_capture.Location = New System.Drawing.Point(164, 406)
        Me.btn_capture.Name = "btn_capture"
        Me.btn_capture.Size = New System.Drawing.Size(69, 56)
        Me.btn_capture.TabIndex = 8
        Me.btn_capture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_capture.UseVisualStyleBackColor = False
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_next.FlatAppearance.BorderSize = 0
        Me.btn_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.btn_next.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_next.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_next.IconSize = 20
        Me.btn_next.Location = New System.Drawing.Point(239, 406)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(69, 56)
        Me.btn_next.TabIndex = 9
        Me.btn_next.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'pb_captured
        '
        Me.pb_captured.BackColor = System.Drawing.Color.Black
        Me.pb_captured.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pb_captured.Location = New System.Drawing.Point(0, 200)
        Me.pb_captured.Name = "pb_captured"
        Me.pb_captured.Size = New System.Drawing.Size(396, 200)
        Me.pb_captured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_captured.TabIndex = 1
        Me.pb_captured.TabStop = False
        '
        'qrscanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(396, 539)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_capture)
        Me.Controls.Add(Me.btn_cam)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "qrscanner"
        Me.Text = "qrscanner"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb_qrscanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_captured, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pb_qrscanner As PictureBox
    Friend WithEvents btn_cam As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_capture As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_next As FontAwesome.Sharp.IconButton
    Friend WithEvents pb_captured As PictureBox
End Class
