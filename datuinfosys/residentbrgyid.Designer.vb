<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class residentbrgyid
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
        Me.tb_print = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tb_print)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(851, 584)
        Me.Panel1.TabIndex = 0
        '
        'tb_print
        '
        Me.tb_print.Dock = System.Windows.Forms.DockStyle.Top
        Me.tb_print.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_print.Location = New System.Drawing.Point(0, 0)
        Me.tb_print.Multiline = True
        Me.tb_print.Name = "tb_print"
        Me.tb_print.Size = New System.Drawing.Size(851, 492)
        Me.tb_print.TabIndex = 0
        '
        'residentbrgyid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 584)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(867, 623)
        Me.MinimumSize = New System.Drawing.Size(867, 623)
        Me.Name = "residentbrgyid"
        Me.Text = "residentbrgyid"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tb_print As TextBox
End Class
