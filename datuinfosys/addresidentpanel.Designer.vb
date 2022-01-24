<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addresidentpanel
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
        Me.btn_addres = New FontAwesome.Sharp.IconButton()
        Me.lbl_residentid = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cb_genderx = New System.Windows.Forms.ComboBox()
        Me.btn_searchres = New FontAwesome.Sharp.IconButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tb_residentid = New System.Windows.Forms.TextBox()
        Me.btn_editres = New FontAwesome.Sharp.IconButton()
        Me.lbl_agegroup = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_age = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cb_voter = New System.Windows.Forms.ComboBox()
        Me.cb_religion = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_pob = New System.Windows.Forms.TextBox()
        Me.pb_qrcode = New System.Windows.Forms.PictureBox()
        Me.icb_camera = New FontAwesome.Sharp.IconButton()
        Me.icb_capture = New FontAwesome.Sharp.IconButton()
        Me.pb_captured = New System.Windows.Forms.PictureBox()
        Me.pb_liveshot = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_contact = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_address = New System.Windows.Forms.TextBox()
        Me.cb_status = New System.Windows.Forms.ComboBox()
        Me.date_dob = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_lname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_mname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_fname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_deleteres = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_qrcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_captured, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_liveshot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_addres
        '
        Me.btn_addres.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_addres.FlatAppearance.BorderSize = 0
        Me.btn_addres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_addres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_addres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addres.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addres.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btn_addres.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_addres.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_addres.IconSize = 20
        Me.btn_addres.Location = New System.Drawing.Point(694, 244)
        Me.btn_addres.Name = "btn_addres"
        Me.btn_addres.Size = New System.Drawing.Size(74, 61)
        Me.btn_addres.TabIndex = 8
        Me.btn_addres.Text = "Add"
        Me.btn_addres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_addres.UseVisualStyleBackColor = False
        '
        'lbl_residentid
        '
        Me.lbl_residentid.AutoSize = True
        Me.lbl_residentid.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_residentid.Location = New System.Drawing.Point(341, 41)
        Me.lbl_residentid.Name = "lbl_residentid"
        Me.lbl_residentid.Size = New System.Drawing.Size(134, 18)
        Me.lbl_residentid.TabIndex = 8
        Me.lbl_residentid.Text = "00000000000000"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.btn_deleteres)
        Me.Panel1.Controls.Add(Me.cb_genderx)
        Me.Panel1.Controls.Add(Me.btn_searchres)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.tb_residentid)
        Me.Panel1.Controls.Add(Me.btn_editres)
        Me.Panel1.Controls.Add(Me.lbl_agegroup)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.lbl_age)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.cb_voter)
        Me.Panel1.Controls.Add(Me.cb_religion)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.tb_pob)
        Me.Panel1.Controls.Add(Me.pb_qrcode)
        Me.Panel1.Controls.Add(Me.icb_camera)
        Me.Panel1.Controls.Add(Me.icb_capture)
        Me.Panel1.Controls.Add(Me.pb_captured)
        Me.Panel1.Controls.Add(Me.pb_liveshot)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.tb_contact)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.tb_address)
        Me.Panel1.Controls.Add(Me.cb_status)
        Me.Panel1.Controls.Add(Me.date_dob)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.tb_lname)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tb_mname)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tb_fname)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_addres)
        Me.Panel1.Controls.Add(Me.lbl_residentid)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 961)
        Me.Panel1.TabIndex = 9
        '
        'cb_genderx
        '
        Me.cb_genderx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_genderx.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_genderx.FormattingEnabled = True
        Me.cb_genderx.Items.AddRange(New Object() {"Male", "Female"})
        Me.cb_genderx.Location = New System.Drawing.Point(15, 151)
        Me.cb_genderx.Name = "cb_genderx"
        Me.cb_genderx.Size = New System.Drawing.Size(323, 30)
        Me.cb_genderx.TabIndex = 51
        '
        'btn_searchres
        '
        Me.btn_searchres.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_searchres.FlatAppearance.BorderSize = 0
        Me.btn_searchres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_searchres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_searchres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_searchres.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_searchres.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btn_searchres.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_searchres.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_searchres.IconSize = 20
        Me.btn_searchres.Location = New System.Drawing.Point(452, 397)
        Me.btn_searchres.Name = "btn_searchres"
        Me.btn_searchres.Size = New System.Drawing.Size(40, 40)
        Me.btn_searchres.TabIndex = 50
        Me.btn_searchres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_searchres.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 413)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 22)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Resident ID"
        '
        'tb_residentid
        '
        Me.tb_residentid.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_residentid.Location = New System.Drawing.Point(123, 410)
        Me.tb_residentid.Name = "tb_residentid"
        Me.tb_residentid.Size = New System.Drawing.Size(323, 27)
        Me.tb_residentid.TabIndex = 48
        '
        'btn_editres
        '
        Me.btn_editres.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_editres.FlatAppearance.BorderSize = 0
        Me.btn_editres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_editres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_editres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editres.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editres.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btn_editres.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_editres.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_editres.IconSize = 20
        Me.btn_editres.Location = New System.Drawing.Point(694, 311)
        Me.btn_editres.Name = "btn_editres"
        Me.btn_editres.Size = New System.Drawing.Size(74, 61)
        Me.btn_editres.TabIndex = 47
        Me.btn_editres.Text = "Edit"
        Me.btn_editres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_editres.UseVisualStyleBackColor = False
        '
        'lbl_agegroup
        '
        Me.lbl_agegroup.AutoSize = True
        Me.lbl_agegroup.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_agegroup.Location = New System.Drawing.Point(403, 315)
        Me.lbl_agegroup.Name = "lbl_agegroup"
        Me.lbl_agegroup.Size = New System.Drawing.Size(54, 22)
        Me.lbl_agegroup.TabIndex = 46
        Me.lbl_agegroup.Text = "None"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(403, 290)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 22)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Age Group"
        '
        'lbl_age
        '
        Me.lbl_age.AutoSize = True
        Me.lbl_age.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_age.Location = New System.Drawing.Point(345, 316)
        Me.lbl_age.Name = "lbl_age"
        Me.lbl_age.Size = New System.Drawing.Size(21, 22)
        Me.lbl_age.TabIndex = 44
        Me.lbl_age.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(340, 290)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 22)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Age"
        '
        'cb_voter
        '
        Me.cb_voter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_voter.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_voter.FormattingEnabled = True
        Me.cb_voter.Items.AddRange(New Object() {"Yes", "No"})
        Me.cb_voter.Location = New System.Drawing.Point(673, 202)
        Me.cb_voter.Name = "cb_voter"
        Me.cb_voter.Size = New System.Drawing.Size(323, 30)
        Me.cb_voter.TabIndex = 41
        '
        'cb_religion
        '
        Me.cb_religion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_religion.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_religion.FormattingEnabled = True
        Me.cb_religion.Items.AddRange(New Object() {"Roman Catholic", "Evangelical", "Inglesia ni Cristo", "Aglipayan", "Protestant", "Baptist", "Pentecostal", "Anglican", "Orthodox", "Methodist", "Seventh Day Adventist", "Islam", "Buddhism", "Tribal Religion", "None"})
        Me.cb_religion.Location = New System.Drawing.Point(344, 202)
        Me.cb_religion.Name = "cb_religion"
        Me.cb_religion.Size = New System.Drawing.Size(323, 30)
        Me.cb_religion.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(670, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 22)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Place of Birth"
        '
        'tb_pob
        '
        Me.tb_pob.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pob.Location = New System.Drawing.Point(673, 154)
        Me.tb_pob.Name = "tb_pob"
        Me.tb_pob.Size = New System.Drawing.Size(321, 27)
        Me.tb_pob.TabIndex = 37
        '
        'pb_qrcode
        '
        Me.pb_qrcode.BackColor = System.Drawing.Color.Transparent
        Me.pb_qrcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_qrcode.Location = New System.Drawing.Point(794, 244)
        Me.pb_qrcode.Name = "pb_qrcode"
        Me.pb_qrcode.Size = New System.Drawing.Size(200, 200)
        Me.pb_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_qrcode.TabIndex = 36
        Me.pb_qrcode.TabStop = False
        '
        'icb_camera
        '
        Me.icb_camera.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.icb_camera.FlatAppearance.BorderSize = 0
        Me.icb_camera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.icb_camera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.icb_camera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.icb_camera.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.icb_camera.IconChar = FontAwesome.Sharp.IconChar.Camera
        Me.icb_camera.IconColor = System.Drawing.Color.Fuchsia
        Me.icb_camera.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.icb_camera.IconSize = 20
        Me.icb_camera.Location = New System.Drawing.Point(1038, 450)
        Me.icb_camera.Name = "icb_camera"
        Me.icb_camera.Size = New System.Drawing.Size(40, 31)
        Me.icb_camera.TabIndex = 9
        Me.icb_camera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.icb_camera.UseVisualStyleBackColor = False
        '
        'icb_capture
        '
        Me.icb_capture.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.icb_capture.FlatAppearance.BorderSize = 0
        Me.icb_capture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.icb_capture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.icb_capture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.icb_capture.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.icb_capture.IconChar = FontAwesome.Sharp.IconChar.Circle
        Me.icb_capture.IconColor = System.Drawing.Color.Fuchsia
        Me.icb_capture.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.icb_capture.IconSize = 20
        Me.icb_capture.Location = New System.Drawing.Point(1084, 450)
        Me.icb_capture.Name = "icb_capture"
        Me.icb_capture.Size = New System.Drawing.Size(42, 31)
        Me.icb_capture.TabIndex = 10
        Me.icb_capture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.icb_capture.UseVisualStyleBackColor = False
        '
        'pb_captured
        '
        Me.pb_captured.BackColor = System.Drawing.Color.Black
        Me.pb_captured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_captured.Location = New System.Drawing.Point(1002, 244)
        Me.pb_captured.Name = "pb_captured"
        Me.pb_captured.Size = New System.Drawing.Size(200, 200)
        Me.pb_captured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_captured.TabIndex = 33
        Me.pb_captured.TabStop = False
        '
        'pb_liveshot
        '
        Me.pb_liveshot.BackColor = System.Drawing.Color.Black
        Me.pb_liveshot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_liveshot.Location = New System.Drawing.Point(1002, 38)
        Me.pb_liveshot.Name = "pb_liveshot"
        Me.pb_liveshot.Size = New System.Drawing.Size(200, 200)
        Me.pb_liveshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_liveshot.TabIndex = 32
        Me.pb_liveshot.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 287)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 22)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Contact No."
        '
        'tb_contact
        '
        Me.tb_contact.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_contact.Location = New System.Drawing.Point(16, 312)
        Me.tb_contact.Name = "tb_contact"
        Me.tb_contact.Size = New System.Drawing.Size(323, 27)
        Me.tb_contact.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 235)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 22)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Complete Address"
        '
        'tb_address
        '
        Me.tb_address.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_address.Location = New System.Drawing.Point(15, 260)
        Me.tb_address.Name = "tb_address"
        Me.tb_address.Size = New System.Drawing.Size(651, 27)
        Me.tb_address.TabIndex = 6
        '
        'cb_status
        '
        Me.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_status.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_status.FormattingEnabled = True
        Me.cb_status.Items.AddRange(New Object() {"Single", "Married", "Separated", "Widowed"})
        Me.cb_status.Location = New System.Drawing.Point(16, 202)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(323, 30)
        Me.cb_status.TabIndex = 5
        '
        'date_dob
        '
        Me.date_dob.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_dob.Location = New System.Drawing.Point(344, 154)
        Me.date_dob.Name = "date_dob"
        Me.date_dob.Size = New System.Drawing.Size(323, 27)
        Me.date_dob.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 22)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Civil Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(340, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 22)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Date of Birth"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(340, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 22)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Resident ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(669, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 22)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Last Name"
        '
        'tb_lname
        '
        Me.tb_lname.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_lname.Location = New System.Drawing.Point(673, 98)
        Me.tb_lname.Name = "tb_lname"
        Me.tb_lname.Size = New System.Drawing.Size(323, 27)
        Me.tb_lname.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 22)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(340, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 22)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Middle Name"
        '
        'tb_mname
        '
        Me.tb_mname.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_mname.Location = New System.Drawing.Point(344, 98)
        Me.tb_mname.Name = "tb_mname"
        Me.tb_mname.Size = New System.Drawing.Size(323, 27)
        Me.tb_mname.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 22)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "First Name"
        '
        'tb_fname
        '
        Me.tb_fname.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_fname.Location = New System.Drawing.Point(15, 98)
        Me.tb_fname.Name = "tb_fname"
        Me.tb_fname.Size = New System.Drawing.Size(323, 27)
        Me.tb_fname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 37)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Resident Information"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(669, 180)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(159, 22)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Registered Voter?"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(340, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 22)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Religion"
        '
        'btn_deleteres
        '
        Me.btn_deleteres.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_deleteres.FlatAppearance.BorderSize = 0
        Me.btn_deleteres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_deleteres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_deleteres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deleteres.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteres.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.btn_deleteres.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_deleteres.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_deleteres.IconSize = 20
        Me.btn_deleteres.Location = New System.Drawing.Point(694, 383)
        Me.btn_deleteres.Name = "btn_deleteres"
        Me.btn_deleteres.Size = New System.Drawing.Size(74, 61)
        Me.btn_deleteres.TabIndex = 52
        Me.btn_deleteres.Text = "Delete"
        Me.btn_deleteres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_deleteres.UseVisualStyleBackColor = False
        '
        'addresidentpanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1240, 961)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(1256, 1000)
        Me.MinimumSize = New System.Drawing.Size(1256, 1000)
        Me.Name = "addresidentpanel"
        Me.Text = "addresidentpanel"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pb_qrcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_captured, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_liveshot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_addres As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_residentid As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_lname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_mname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_fname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tb_contact As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tb_address As TextBox
    Friend WithEvents cb_status As ComboBox
    Friend WithEvents date_dob As DateTimePicker
    Friend WithEvents icb_camera As FontAwesome.Sharp.IconButton
    Friend WithEvents icb_capture As FontAwesome.Sharp.IconButton
    Friend WithEvents pb_captured As PictureBox
    Friend WithEvents pb_liveshot As PictureBox
    Friend WithEvents pb_qrcode As PictureBox
    Friend WithEvents lbl_agegroup As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lbl_age As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cb_voter As ComboBox
    Friend WithEvents cb_religion As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tb_pob As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents tb_residentid As TextBox
    Friend WithEvents btn_editres As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_searchres As FontAwesome.Sharp.IconButton
    Friend WithEvents cb_genderx As ComboBox
    Friend WithEvents btn_deleteres As FontAwesome.Sharp.IconButton
End Class
