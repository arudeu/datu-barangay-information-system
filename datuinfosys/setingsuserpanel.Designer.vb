<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class setingsuserpanel
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_deleteuser = New FontAwesome.Sharp.IconButton()
        Me.btn_edituser = New FontAwesome.Sharp.IconButton()
        Me.btn_adduser = New FontAwesome.Sharp.IconButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_passwordui = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_usernameui = New System.Windows.Forms.TextBox()
        Me.dgv_brgyofficials = New System.Windows.Forms.DataGridView()
        Me.OFFICIALID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb_usertypeui = New System.Windows.Forms.ComboBox()
        Me.cb_officialui = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsersdatudbDataSet = New datuinfosys.usersdatudbDataSet()
        Me.USERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USERSTableAdapter = New datuinfosys.usersdatudbDataSetTableAdapters.USERSTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_brgyofficials, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersdatudbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_deleteuser)
        Me.Panel1.Controls.Add(Me.btn_edituser)
        Me.Panel1.Controls.Add(Me.btn_adduser)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tb_passwordui)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tb_usernameui)
        Me.Panel1.Controls.Add(Me.dgv_brgyofficials)
        Me.Panel1.Controls.Add(Me.cb_usertypeui)
        Me.Panel1.Controls.Add(Me.cb_officialui)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 961)
        Me.Panel1.TabIndex = 0
        '
        'btn_deleteuser
        '
        Me.btn_deleteuser.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_deleteuser.FlatAppearance.BorderSize = 0
        Me.btn_deleteuser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_deleteuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_deleteuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deleteuser.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteuser.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.btn_deleteuser.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_deleteuser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_deleteuser.IconSize = 20
        Me.btn_deleteuser.Location = New System.Drawing.Point(512, 199)
        Me.btn_deleteuser.Name = "btn_deleteuser"
        Me.btn_deleteuser.Size = New System.Drawing.Size(74, 61)
        Me.btn_deleteuser.TabIndex = 40
        Me.btn_deleteuser.Text = "Delete"
        Me.btn_deleteuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_deleteuser.UseVisualStyleBackColor = False
        '
        'btn_edituser
        '
        Me.btn_edituser.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_edituser.FlatAppearance.BorderSize = 0
        Me.btn_edituser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_edituser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_edituser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edituser.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edituser.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btn_edituser.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_edituser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_edituser.IconSize = 20
        Me.btn_edituser.Location = New System.Drawing.Point(432, 199)
        Me.btn_edituser.Name = "btn_edituser"
        Me.btn_edituser.Size = New System.Drawing.Size(74, 61)
        Me.btn_edituser.TabIndex = 39
        Me.btn_edituser.Text = "Edit"
        Me.btn_edituser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_edituser.UseVisualStyleBackColor = False
        '
        'btn_adduser
        '
        Me.btn_adduser.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_adduser.FlatAppearance.BorderSize = 0
        Me.btn_adduser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_adduser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_adduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_adduser.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adduser.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btn_adduser.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_adduser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_adduser.IconSize = 20
        Me.btn_adduser.Location = New System.Drawing.Point(352, 199)
        Me.btn_adduser.Name = "btn_adduser"
        Me.btn_adduser.Size = New System.Drawing.Size(74, 61)
        Me.btn_adduser.TabIndex = 38
        Me.btn_adduser.Text = "Add"
        Me.btn_adduser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_adduser.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(348, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 22)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Password"
        '
        'tb_passwordui
        '
        Me.tb_passwordui.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_passwordui.Location = New System.Drawing.Point(352, 151)
        Me.tb_passwordui.Name = "tb_passwordui"
        Me.tb_passwordui.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_passwordui.Size = New System.Drawing.Size(323, 27)
        Me.tb_passwordui.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 22)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Username"
        '
        'tb_usernameui
        '
        Me.tb_usernameui.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_usernameui.Location = New System.Drawing.Point(19, 151)
        Me.tb_usernameui.Name = "tb_usernameui"
        Me.tb_usernameui.Size = New System.Drawing.Size(323, 27)
        Me.tb_usernameui.TabIndex = 34
        '
        'dgv_brgyofficials
        '
        Me.dgv_brgyofficials.AllowUserToAddRows = False
        Me.dgv_brgyofficials.AllowUserToDeleteRows = False
        Me.dgv_brgyofficials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_brgyofficials.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_brgyofficials.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_brgyofficials.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_brgyofficials.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_brgyofficials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_brgyofficials.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OFFICIALID})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_brgyofficials.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_brgyofficials.EnableHeadersVisualStyles = False
        Me.dgv_brgyofficials.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_brgyofficials.Location = New System.Drawing.Point(681, 12)
        Me.dgv_brgyofficials.MultiSelect = False
        Me.dgv_brgyofficials.Name = "dgv_brgyofficials"
        Me.dgv_brgyofficials.ReadOnly = True
        Me.dgv_brgyofficials.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgv_brgyofficials.RowHeadersVisible = False
        Me.dgv_brgyofficials.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_brgyofficials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_brgyofficials.Size = New System.Drawing.Size(547, 291)
        Me.dgv_brgyofficials.TabIndex = 33
        '
        'OFFICIALID
        '
        Me.OFFICIALID.DataPropertyName = "OFFICIALID"
        Me.OFFICIALID.HeaderText = "OFFICIALID"
        Me.OFFICIALID.Name = "OFFICIALID"
        Me.OFFICIALID.ReadOnly = True
        Me.OFFICIALID.Visible = False
        '
        'cb_usertypeui
        '
        Me.cb_usertypeui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_usertypeui.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_usertypeui.FormattingEnabled = True
        Me.cb_usertypeui.Items.AddRange(New Object() {"Super Admin", "Regular Admin"})
        Me.cb_usertypeui.Location = New System.Drawing.Point(352, 93)
        Me.cb_usertypeui.Name = "cb_usertypeui"
        Me.cb_usertypeui.Size = New System.Drawing.Size(323, 30)
        Me.cb_usertypeui.TabIndex = 21
        '
        'cb_officialui
        '
        Me.cb_officialui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_officialui.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_officialui.FormattingEnabled = True
        Me.cb_officialui.Location = New System.Drawing.Point(19, 93)
        Me.cb_officialui.Name = "cb_officialui"
        Me.cb_officialui.Size = New System.Drawing.Size(323, 30)
        Me.cb_officialui.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(348, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 22)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "User Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 22)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Select User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 37)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "User Information"
        '
        'UsersdatudbDataSet
        '
        Me.UsersdatudbDataSet.DataSetName = "usersdatudbDataSet"
        Me.UsersdatudbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USERSBindingSource
        '
        Me.USERSBindingSource.DataMember = "USERS"
        Me.USERSBindingSource.DataSource = Me.UsersdatudbDataSet
        '
        'USERSTableAdapter
        '
        Me.USERSTableAdapter.ClearBeforeFill = True
        '
        'setingsuserpanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1240, 961)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "setingsuserpanel"
        Me.Text = "setingsuserpanel"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_brgyofficials, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersdatudbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_officialui As ComboBox
    Friend WithEvents cb_usertypeui As ComboBox
    Friend WithEvents dgv_brgyofficials As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_passwordui As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_usernameui As TextBox
    Friend WithEvents btn_edituser As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_adduser As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_deleteuser As FontAwesome.Sharp.IconButton
    Friend WithEvents UsersdatudbDataSet As usersdatudbDataSet
    Friend WithEvents USERSBindingSource As BindingSource
    Friend WithEvents USERSTableAdapter As usersdatudbDataSetTableAdapters.USERSTableAdapter
    Friend WithEvents OFFICIALID As DataGridViewTextBoxColumn
End Class
