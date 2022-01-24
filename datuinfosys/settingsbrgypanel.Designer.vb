<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class settingsbrgypanel
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.subpnl_settings = New System.Windows.Forms.Panel()
        Me.dgv_brgyinfo = New System.Windows.Forms.DataGridView()
        Me.dgv_positions = New System.Windows.Forms.DataGridView()
        Me.POSITIONID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_brgyofficials = New System.Windows.Forms.DataGridView()
        Me.OFFICIALID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_deletebp = New FontAwesome.Sharp.IconButton()
        Me.btn_editbp = New FontAwesome.Sharp.IconButton()
        Me.btn_addbp = New FontAwesome.Sharp.IconButton()
        Me.btn_deletebo = New FontAwesome.Sharp.IconButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_imglocation = New System.Windows.Forms.TextBox()
        Me.btn_attachimglogobo = New FontAwesome.Sharp.IconButton()
        Me.pb_imglogo = New System.Windows.Forms.PictureBox()
        Me.btn_editbo = New FontAwesome.Sharp.IconButton()
        Me.btn_addbo = New FontAwesome.Sharp.IconButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_logolocation = New System.Windows.Forms.TextBox()
        Me.btn_attachbrgylogo = New FontAwesome.Sharp.IconButton()
        Me.pb_brgylogo = New System.Windows.Forms.PictureBox()
        Me.btn_editbrgy = New FontAwesome.Sharp.IconButton()
        Me.btn_addbrgy = New FontAwesome.Sharp.IconButton()
        Me.tb_positionbp = New System.Windows.Forms.TextBox()
        Me.cb_positionbo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_fnamebo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_lnamebo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_zipcode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_province = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_city = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_brgyname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Table2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_brgypositions = New datuinfosys.Ds_brgypositions()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_brgyofficials = New datuinfosys.Ds_brgyofficials()
        Me.Table1TableAdapter = New datuinfosys.Ds_brgyofficialsTableAdapters.Table1TableAdapter()
        Me.Table2TableAdapter = New datuinfosys.Ds_brgypositionsTableAdapters.Table2TableAdapter()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_brgyinfo = New datuinfosys.ds_brgyinfo()
        Me.TableTableAdapter = New datuinfosys.ds_brgyinfoTableAdapters.TableTableAdapter()
        Me.subpnl_settings.SuspendLayout()
        CType(Me.dgv_brgyinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_positions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_brgyofficials, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_imglogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_brgylogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_brgypositions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_brgyofficials, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_brgyinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'subpnl_settings
        '
        Me.subpnl_settings.AutoScroll = True
        Me.subpnl_settings.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.subpnl_settings.Controls.Add(Me.dgv_brgyinfo)
        Me.subpnl_settings.Controls.Add(Me.dgv_positions)
        Me.subpnl_settings.Controls.Add(Me.dgv_brgyofficials)
        Me.subpnl_settings.Controls.Add(Me.btn_deletebp)
        Me.subpnl_settings.Controls.Add(Me.btn_editbp)
        Me.subpnl_settings.Controls.Add(Me.btn_addbp)
        Me.subpnl_settings.Controls.Add(Me.btn_deletebo)
        Me.subpnl_settings.Controls.Add(Me.Label12)
        Me.subpnl_settings.Controls.Add(Me.tb_imglocation)
        Me.subpnl_settings.Controls.Add(Me.btn_attachimglogobo)
        Me.subpnl_settings.Controls.Add(Me.pb_imglogo)
        Me.subpnl_settings.Controls.Add(Me.btn_editbo)
        Me.subpnl_settings.Controls.Add(Me.btn_addbo)
        Me.subpnl_settings.Controls.Add(Me.Label8)
        Me.subpnl_settings.Controls.Add(Me.tb_logolocation)
        Me.subpnl_settings.Controls.Add(Me.btn_attachbrgylogo)
        Me.subpnl_settings.Controls.Add(Me.pb_brgylogo)
        Me.subpnl_settings.Controls.Add(Me.btn_editbrgy)
        Me.subpnl_settings.Controls.Add(Me.btn_addbrgy)
        Me.subpnl_settings.Controls.Add(Me.tb_positionbp)
        Me.subpnl_settings.Controls.Add(Me.cb_positionbo)
        Me.subpnl_settings.Controls.Add(Me.Label9)
        Me.subpnl_settings.Controls.Add(Me.Label10)
        Me.subpnl_settings.Controls.Add(Me.tb_fnamebo)
        Me.subpnl_settings.Controls.Add(Me.Label11)
        Me.subpnl_settings.Controls.Add(Me.tb_lnamebo)
        Me.subpnl_settings.Controls.Add(Me.Label7)
        Me.subpnl_settings.Controls.Add(Me.tb_zipcode)
        Me.subpnl_settings.Controls.Add(Me.Label6)
        Me.subpnl_settings.Controls.Add(Me.tb_province)
        Me.subpnl_settings.Controls.Add(Me.Label5)
        Me.subpnl_settings.Controls.Add(Me.tb_city)
        Me.subpnl_settings.Controls.Add(Me.Label4)
        Me.subpnl_settings.Controls.Add(Me.tb_brgyname)
        Me.subpnl_settings.Controls.Add(Me.Label3)
        Me.subpnl_settings.Controls.Add(Me.Label2)
        Me.subpnl_settings.Controls.Add(Me.Label1)
        Me.subpnl_settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.subpnl_settings.Location = New System.Drawing.Point(0, 0)
        Me.subpnl_settings.Name = "subpnl_settings"
        Me.subpnl_settings.Size = New System.Drawing.Size(1240, 961)
        Me.subpnl_settings.TabIndex = 3
        '
        'dgv_brgyinfo
        '
        Me.dgv_brgyinfo.AllowUserToAddRows = False
        Me.dgv_brgyinfo.AllowUserToDeleteRows = False
        Me.dgv_brgyinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_brgyinfo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_brgyinfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_brgyinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_brgyinfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_brgyinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_brgyinfo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_brgyinfo.EnableHeadersVisualStyles = False
        Me.dgv_brgyinfo.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_brgyinfo.Location = New System.Drawing.Point(677, 0)
        Me.dgv_brgyinfo.MultiSelect = False
        Me.dgv_brgyinfo.Name = "dgv_brgyinfo"
        Me.dgv_brgyinfo.ReadOnly = True
        Me.dgv_brgyinfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgv_brgyinfo.RowHeadersVisible = False
        Me.dgv_brgyinfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_brgyinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_brgyinfo.Size = New System.Drawing.Size(559, 291)
        Me.dgv_brgyinfo.TabIndex = 19
        '
        'dgv_positions
        '
        Me.dgv_positions.AllowUserToAddRows = False
        Me.dgv_positions.AllowUserToDeleteRows = False
        Me.dgv_positions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_positions.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_positions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_positions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_positions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_positions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_positions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.POSITIONID})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_positions.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_positions.EnableHeadersVisualStyles = False
        Me.dgv_positions.Location = New System.Drawing.Point(669, 839)
        Me.dgv_positions.MultiSelect = False
        Me.dgv_positions.Name = "dgv_positions"
        Me.dgv_positions.ReadOnly = True
        Me.dgv_positions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgv_positions.RowHeadersVisible = False
        Me.dgv_positions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_positions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_positions.ShowCellErrors = False
        Me.dgv_positions.ShowCellToolTips = False
        Me.dgv_positions.ShowEditingIcon = False
        Me.dgv_positions.ShowRowErrors = False
        Me.dgv_positions.Size = New System.Drawing.Size(559, 259)
        Me.dgv_positions.TabIndex = 33
        '
        'POSITIONID
        '
        Me.POSITIONID.DataPropertyName = "POSITIONID"
        Me.POSITIONID.HeaderText = "POSITIONID"
        Me.POSITIONID.Name = "POSITIONID"
        Me.POSITIONID.ReadOnly = True
        Me.POSITIONID.Visible = False
        '
        'dgv_brgyofficials
        '
        Me.dgv_brgyofficials.AllowUserToAddRows = False
        Me.dgv_brgyofficials.AllowUserToDeleteRows = False
        Me.dgv_brgyofficials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_brgyofficials.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_brgyofficials.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_brgyofficials.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_brgyofficials.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_brgyofficials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_brgyofficials.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OFFICIALID})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_brgyofficials.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_brgyofficials.EnableHeadersVisualStyles = False
        Me.dgv_brgyofficials.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_brgyofficials.Location = New System.Drawing.Point(677, 428)
        Me.dgv_brgyofficials.MultiSelect = False
        Me.dgv_brgyofficials.Name = "dgv_brgyofficials"
        Me.dgv_brgyofficials.ReadOnly = True
        Me.dgv_brgyofficials.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgv_brgyofficials.RowHeadersVisible = False
        Me.dgv_brgyofficials.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_brgyofficials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_brgyofficials.Size = New System.Drawing.Size(559, 291)
        Me.dgv_brgyofficials.TabIndex = 32
        '
        'OFFICIALID
        '
        Me.OFFICIALID.DataPropertyName = "OFFICIALID"
        Me.OFFICIALID.HeaderText = "OFFICIALID"
        Me.OFFICIALID.Name = "OFFICIALID"
        Me.OFFICIALID.ReadOnly = True
        Me.OFFICIALID.Visible = False
        '
        'btn_deletebp
        '
        Me.btn_deletebp.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_deletebp.FlatAppearance.BorderSize = 0
        Me.btn_deletebp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_deletebp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_deletebp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deletebp.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deletebp.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.btn_deletebp.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_deletebp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_deletebp.IconSize = 20
        Me.btn_deletebp.Location = New System.Drawing.Point(385, 921)
        Me.btn_deletebp.Name = "btn_deletebp"
        Me.btn_deletebp.Size = New System.Drawing.Size(74, 61)
        Me.btn_deletebp.TabIndex = 36
        Me.btn_deletebp.Text = "Delete"
        Me.btn_deletebp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_deletebp.UseVisualStyleBackColor = False
        '
        'btn_editbp
        '
        Me.btn_editbp.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_editbp.FlatAppearance.BorderSize = 0
        Me.btn_editbp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_editbp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_editbp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editbp.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editbp.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btn_editbp.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_editbp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_editbp.IconSize = 20
        Me.btn_editbp.Location = New System.Drawing.Point(305, 921)
        Me.btn_editbp.Name = "btn_editbp"
        Me.btn_editbp.Size = New System.Drawing.Size(74, 61)
        Me.btn_editbp.TabIndex = 35
        Me.btn_editbp.Text = "Edit"
        Me.btn_editbp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_editbp.UseVisualStyleBackColor = False
        '
        'btn_addbp
        '
        Me.btn_addbp.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_addbp.FlatAppearance.BorderSize = 0
        Me.btn_addbp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_addbp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_addbp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addbp.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addbp.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btn_addbp.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_addbp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_addbp.IconSize = 20
        Me.btn_addbp.Location = New System.Drawing.Point(225, 921)
        Me.btn_addbp.Name = "btn_addbp"
        Me.btn_addbp.Size = New System.Drawing.Size(74, 61)
        Me.btn_addbp.TabIndex = 34
        Me.btn_addbp.Text = "Add"
        Me.btn_addbp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_addbp.UseVisualStyleBackColor = False
        '
        'btn_deletebo
        '
        Me.btn_deletebo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_deletebo.FlatAppearance.BorderSize = 0
        Me.btn_deletebo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_deletebo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_deletebo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deletebo.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deletebo.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.btn_deletebo.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_deletebo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_deletebo.IconSize = 20
        Me.btn_deletebo.Location = New System.Drawing.Point(465, 658)
        Me.btn_deletebo.Name = "btn_deletebo"
        Me.btn_deletebo.Size = New System.Drawing.Size(74, 61)
        Me.btn_deletebo.TabIndex = 31
        Me.btn_deletebo.Text = "Delete"
        Me.btn_deletebo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_deletebo.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(221, 595)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 22)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Signature Location"
        '
        'tb_imglocation
        '
        Me.tb_imglocation.Enabled = False
        Me.tb_imglocation.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_imglocation.Location = New System.Drawing.Point(225, 620)
        Me.tb_imglocation.Name = "tb_imglocation"
        Me.tb_imglocation.Size = New System.Drawing.Size(323, 27)
        Me.tb_imglocation.TabIndex = 25
        '
        'btn_attachimglogobo
        '
        Me.btn_attachimglogobo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_attachimglogobo.FlatAppearance.BorderSize = 0
        Me.btn_attachimglogobo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_attachimglogobo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_attachimglogobo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_attachimglogobo.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_attachimglogobo.IconChar = FontAwesome.Sharp.IconChar.Paperclip
        Me.btn_attachimglogobo.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_attachimglogobo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_attachimglogobo.IconSize = 20
        Me.btn_attachimglogobo.Location = New System.Drawing.Point(225, 658)
        Me.btn_attachimglogobo.Name = "btn_attachimglogobo"
        Me.btn_attachimglogobo.Size = New System.Drawing.Size(74, 61)
        Me.btn_attachimglogobo.TabIndex = 26
        Me.btn_attachimglogobo.Text = "Attach"
        Me.btn_attachimglogobo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_attachimglogobo.UseVisualStyleBackColor = False
        '
        'pb_imglogo
        '
        Me.pb_imglogo.BackColor = System.Drawing.Color.Transparent
        Me.pb_imglogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb_imglogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_imglogo.Location = New System.Drawing.Point(19, 595)
        Me.pb_imglogo.MaximumSize = New System.Drawing.Size(200, 200)
        Me.pb_imglogo.MinimumSize = New System.Drawing.Size(200, 200)
        Me.pb_imglogo.Name = "pb_imglogo"
        Me.pb_imglogo.Size = New System.Drawing.Size(200, 200)
        Me.pb_imglogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_imglogo.TabIndex = 29
        Me.pb_imglogo.TabStop = False
        '
        'btn_editbo
        '
        Me.btn_editbo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_editbo.FlatAppearance.BorderSize = 0
        Me.btn_editbo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_editbo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_editbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editbo.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editbo.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btn_editbo.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_editbo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_editbo.IconSize = 20
        Me.btn_editbo.Location = New System.Drawing.Point(385, 658)
        Me.btn_editbo.Name = "btn_editbo"
        Me.btn_editbo.Size = New System.Drawing.Size(74, 61)
        Me.btn_editbo.TabIndex = 28
        Me.btn_editbo.Text = "Edit"
        Me.btn_editbo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_editbo.UseVisualStyleBackColor = False
        '
        'btn_addbo
        '
        Me.btn_addbo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_addbo.FlatAppearance.BorderSize = 0
        Me.btn_addbo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_addbo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_addbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addbo.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addbo.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btn_addbo.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_addbo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_addbo.IconSize = 20
        Me.btn_addbo.Location = New System.Drawing.Point(305, 658)
        Me.btn_addbo.Name = "btn_addbo"
        Me.btn_addbo.Size = New System.Drawing.Size(74, 61)
        Me.btn_addbo.TabIndex = 27
        Me.btn_addbo.Text = "Add"
        Me.btn_addbo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_addbo.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(221, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 22)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Logo Location"
        '
        'tb_logolocation
        '
        Me.tb_logolocation.Enabled = False
        Me.tb_logolocation.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_logolocation.Location = New System.Drawing.Point(225, 218)
        Me.tb_logolocation.Name = "tb_logolocation"
        Me.tb_logolocation.Size = New System.Drawing.Size(323, 27)
        Me.tb_logolocation.TabIndex = 4
        '
        'btn_attachbrgylogo
        '
        Me.btn_attachbrgylogo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_attachbrgylogo.FlatAppearance.BorderSize = 0
        Me.btn_attachbrgylogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_attachbrgylogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_attachbrgylogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_attachbrgylogo.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_attachbrgylogo.IconChar = FontAwesome.Sharp.IconChar.Paperclip
        Me.btn_attachbrgylogo.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_attachbrgylogo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_attachbrgylogo.IconSize = 20
        Me.btn_attachbrgylogo.Location = New System.Drawing.Point(225, 256)
        Me.btn_attachbrgylogo.Name = "btn_attachbrgylogo"
        Me.btn_attachbrgylogo.Size = New System.Drawing.Size(74, 61)
        Me.btn_attachbrgylogo.TabIndex = 5
        Me.btn_attachbrgylogo.Text = "Attach"
        Me.btn_attachbrgylogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_attachbrgylogo.UseVisualStyleBackColor = False
        '
        'pb_brgylogo
        '
        Me.pb_brgylogo.BackColor = System.Drawing.Color.Transparent
        Me.pb_brgylogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb_brgylogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_brgylogo.Location = New System.Drawing.Point(19, 193)
        Me.pb_brgylogo.MaximumSize = New System.Drawing.Size(200, 200)
        Me.pb_brgylogo.MinimumSize = New System.Drawing.Size(200, 200)
        Me.pb_brgylogo.Name = "pb_brgylogo"
        Me.pb_brgylogo.Size = New System.Drawing.Size(200, 200)
        Me.pb_brgylogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_brgylogo.TabIndex = 21
        Me.pb_brgylogo.TabStop = False
        '
        'btn_editbrgy
        '
        Me.btn_editbrgy.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_editbrgy.FlatAppearance.BorderSize = 0
        Me.btn_editbrgy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_editbrgy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_editbrgy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editbrgy.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editbrgy.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btn_editbrgy.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_editbrgy.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_editbrgy.IconSize = 20
        Me.btn_editbrgy.Location = New System.Drawing.Point(385, 256)
        Me.btn_editbrgy.Name = "btn_editbrgy"
        Me.btn_editbrgy.Size = New System.Drawing.Size(74, 61)
        Me.btn_editbrgy.TabIndex = 7
        Me.btn_editbrgy.Text = "Edit"
        Me.btn_editbrgy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_editbrgy.UseVisualStyleBackColor = False
        '
        'btn_addbrgy
        '
        Me.btn_addbrgy.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_addbrgy.FlatAppearance.BorderSize = 0
        Me.btn_addbrgy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_addbrgy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_addbrgy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addbrgy.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addbrgy.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btn_addbrgy.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_addbrgy.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_addbrgy.IconSize = 20
        Me.btn_addbrgy.Location = New System.Drawing.Point(305, 256)
        Me.btn_addbrgy.Name = "btn_addbrgy"
        Me.btn_addbrgy.Size = New System.Drawing.Size(74, 61)
        Me.btn_addbrgy.TabIndex = 6
        Me.btn_addbrgy.Text = "Add"
        Me.btn_addbrgy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_addbrgy.UseVisualStyleBackColor = False
        '
        'tb_positionbp
        '
        Me.tb_positionbp.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_positionbp.Location = New System.Drawing.Point(19, 888)
        Me.tb_positionbp.Name = "tb_positionbp"
        Me.tb_positionbp.Size = New System.Drawing.Size(440, 27)
        Me.tb_positionbp.TabIndex = 18
        '
        'cb_positionbo
        '
        Me.cb_positionbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_positionbo.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_positionbo.FormattingEnabled = True
        Me.cb_positionbo.Location = New System.Drawing.Point(19, 549)
        Me.cb_positionbo.Name = "cb_positionbo"
        Me.cb_positionbo.Size = New System.Drawing.Size(323, 30)
        Me.cb_positionbo.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 524)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 22)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Position"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(344, 468)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 22)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "First Name"
        '
        'tb_fnamebo
        '
        Me.tb_fnamebo.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fnamebo.Location = New System.Drawing.Point(348, 493)
        Me.tb_fnamebo.Name = "tb_fnamebo"
        Me.tb_fnamebo.Size = New System.Drawing.Size(323, 27)
        Me.tb_fnamebo.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 468)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 22)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Last Name"
        '
        'tb_lnamebo
        '
        Me.tb_lnamebo.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_lnamebo.Location = New System.Drawing.Point(19, 493)
        Me.tb_lnamebo.Name = "tb_lnamebo"
        Me.tb_lnamebo.Size = New System.Drawing.Size(323, 27)
        Me.tb_lnamebo.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(344, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 22)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Zip Code"
        '
        'tb_zipcode
        '
        Me.tb_zipcode.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_zipcode.Location = New System.Drawing.Point(348, 149)
        Me.tb_zipcode.Name = "tb_zipcode"
        Me.tb_zipcode.Size = New System.Drawing.Size(323, 27)
        Me.tb_zipcode.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Province"
        '
        'tb_province
        '
        Me.tb_province.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_province.Location = New System.Drawing.Point(19, 149)
        Me.tb_province.Name = "tb_province"
        Me.tb_province.Size = New System.Drawing.Size(323, 27)
        Me.tb_province.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(344, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "City/Municipality"
        '
        'tb_city
        '
        Me.tb_city.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_city.Location = New System.Drawing.Point(348, 93)
        Me.tb_city.Name = "tb_city"
        Me.tb_city.Size = New System.Drawing.Size(323, 27)
        Me.tb_city.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Barangay"
        '
        'tb_brgyname
        '
        Me.tb_brgyname.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_brgyname.Location = New System.Drawing.Point(19, 93)
        Me.tb_brgyname.Name = "tb_brgyname"
        Me.tb_brgyname.Size = New System.Drawing.Size(323, 27)
        Me.tb_brgyname.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 845)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Barangay Positions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 410)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Barangay Officials"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barangay Information"
        '
        'Table2BindingSource
        '
        Me.Table2BindingSource.DataMember = "Table2"
        Me.Table2BindingSource.DataSource = Me.Ds_brgypositions
        '
        'Ds_brgypositions
        '
        Me.Ds_brgypositions.DataSetName = "Ds_brgypositions"
        Me.Ds_brgypositions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Ds_brgyofficials
        '
        'Ds_brgyofficials
        '
        Me.Ds_brgyofficials.DataSetName = "Ds_brgyofficials"
        Me.Ds_brgyofficials.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'Table2TableAdapter
        '
        Me.Table2TableAdapter.ClearBeforeFill = True
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.Ds_brgyinfo
        '
        'Ds_brgyinfo
        '
        Me.Ds_brgyinfo.DataSetName = "ds_brgyinfo"
        Me.Ds_brgyinfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'settingsbrgypanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1240, 961)
        Me.Controls.Add(Me.subpnl_settings)
        Me.Name = "settingsbrgypanel"
        Me.Text = "settingsbrgypanel"
        Me.subpnl_settings.ResumeLayout(False)
        Me.subpnl_settings.PerformLayout()
        CType(Me.dgv_brgyinfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_positions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_brgyofficials, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_imglogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_brgylogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_brgypositions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_brgyofficials, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_brgyinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents subpnl_settings As Panel
    Friend WithEvents btn_deletebp As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_editbp As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_addbp As FontAwesome.Sharp.IconButton
    Friend WithEvents dgv_positions As DataGridView
    Friend WithEvents POSITIONID As DataGridViewTextBoxColumn
    Friend WithEvents dgv_brgyofficials As DataGridView
    Friend WithEvents OFFICIALID As DataGridViewTextBoxColumn
    Friend WithEvents btn_deletebo As FontAwesome.Sharp.IconButton
    Friend WithEvents Label12 As Label
    Friend WithEvents tb_imglocation As TextBox
    Friend WithEvents btn_attachimglogobo As FontAwesome.Sharp.IconButton
    Friend WithEvents pb_imglogo As PictureBox
    Friend WithEvents btn_editbo As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_addbo As FontAwesome.Sharp.IconButton
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_logolocation As TextBox
    Friend WithEvents btn_attachbrgylogo As FontAwesome.Sharp.IconButton
    Friend WithEvents pb_brgylogo As PictureBox
    Friend WithEvents btn_editbrgy As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_addbrgy As FontAwesome.Sharp.IconButton
    Friend WithEvents dgv_brgyinfo As DataGridView
    Friend WithEvents tb_positionbp As TextBox
    Friend WithEvents cb_positionbo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tb_fnamebo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tb_lnamebo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_zipcode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_province As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_city As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_brgyname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Table2BindingSource As BindingSource
    Friend WithEvents Ds_brgypositions As Ds_brgypositions
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Ds_brgyofficials As Ds_brgyofficials
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents Ds_brgyinfo As ds_brgyinfo
    Friend WithEvents TableTableAdapter As ds_brgyinfoTableAdapters.TableTableAdapter
    Friend WithEvents Table1TableAdapter As Ds_brgyofficialsTableAdapters.Table1TableAdapter
    Friend WithEvents Table2TableAdapter As Ds_brgypositionsTableAdapters.Table2TableAdapter
End Class
