<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class residentlistpanel
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(residentlistpanel))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_brgypermit = New FontAwesome.Sharp.IconButton()
        Me.btn_coi = New FontAwesome.Sharp.IconButton()
        Me.btn_brgyclear = New FontAwesome.Sharp.IconButton()
        Me.btn_brygid = New FontAwesome.Sharp.IconButton()
        Me.lbl_agegrpres = New System.Windows.Forms.Label()
        Me.lbl_ageres = New System.Windows.Forms.Label()
        Me.lbl_voterres = New System.Windows.Forms.Label()
        Me.lbl_religionres = New System.Windows.Forms.Label()
        Me.lbl_pobres = New System.Windows.Forms.Label()
        Me.pb_qrres = New System.Windows.Forms.PictureBox()
        Me.lbl_contactres = New System.Windows.Forms.Label()
        Me.lbl_addressres = New System.Windows.Forms.Label()
        Me.lbl_statusres = New System.Windows.Forms.Label()
        Me.lbl_dobres = New System.Windows.Forms.Label()
        Me.lbl_genderres = New System.Windows.Forms.Label()
        Me.lbl_idres = New System.Windows.Forms.Label()
        Me.lbl_nameres = New System.Windows.Forms.Label()
        Me.btn_showqr = New FontAwesome.Sharp.IconButton()
        Me.btn_searchres = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_searchresident = New System.Windows.Forms.TextBox()
        Me.pb_imgres = New System.Windows.Forms.PictureBox()
        Me.dgv_brgyinfo = New System.Windows.Forms.DataGridView()
        Me.RESIDENTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESIDENTIMGDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.FNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIVILSTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESIDENTQRDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.RESIDENTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_brgyresidents = New datuinfosys.ds_brgyresidents()
        Me.RESIDENTSTableAdapter = New datuinfosys.ds_brgyresidentsTableAdapters.RESIDENTSTableAdapter()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog3 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument4 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog4 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_qrres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_imgres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_brgyinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RESIDENTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_brgyresidents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btn_brgypermit)
        Me.Panel1.Controls.Add(Me.btn_coi)
        Me.Panel1.Controls.Add(Me.btn_brgyclear)
        Me.Panel1.Controls.Add(Me.btn_brygid)
        Me.Panel1.Controls.Add(Me.lbl_agegrpres)
        Me.Panel1.Controls.Add(Me.lbl_ageres)
        Me.Panel1.Controls.Add(Me.lbl_voterres)
        Me.Panel1.Controls.Add(Me.lbl_religionres)
        Me.Panel1.Controls.Add(Me.lbl_pobres)
        Me.Panel1.Controls.Add(Me.pb_qrres)
        Me.Panel1.Controls.Add(Me.lbl_contactres)
        Me.Panel1.Controls.Add(Me.lbl_addressres)
        Me.Panel1.Controls.Add(Me.lbl_statusres)
        Me.Panel1.Controls.Add(Me.lbl_dobres)
        Me.Panel1.Controls.Add(Me.lbl_genderres)
        Me.Panel1.Controls.Add(Me.lbl_idres)
        Me.Panel1.Controls.Add(Me.lbl_nameres)
        Me.Panel1.Controls.Add(Me.btn_showqr)
        Me.Panel1.Controls.Add(Me.btn_searchres)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tb_searchresident)
        Me.Panel1.Controls.Add(Me.pb_imgres)
        Me.Panel1.Controls.Add(Me.dgv_brgyinfo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 561)
        Me.Panel1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(125, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 22)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Voter?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(123, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 22)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Religion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(125, 309)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 22)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Contact No."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(125, 287)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 22)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 22)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Age Group"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 22)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 22)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "POB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 22)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 22)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "DOB"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 22)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Gender"
        '
        'btn_brgypermit
        '
        Me.btn_brgypermit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_brgypermit.FlatAppearance.BorderSize = 0
        Me.btn_brgypermit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_brgypermit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_brgypermit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_brgypermit.Font = New System.Drawing.Font("Montserrat SemiBold", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_brgypermit.IconChar = FontAwesome.Sharp.IconChar.IdCard
        Me.btn_brgypermit.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_brgypermit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_brgypermit.IconSize = 20
        Me.btn_brgypermit.Location = New System.Drawing.Point(1037, 349)
        Me.btn_brgypermit.Name = "btn_brgypermit"
        Me.btn_brgypermit.Size = New System.Drawing.Size(200, 40)
        Me.btn_brgypermit.TabIndex = 54
        Me.btn_brgypermit.Text = "Barangay Permit"
        Me.btn_brgypermit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_brgypermit.UseVisualStyleBackColor = False
        '
        'btn_coi
        '
        Me.btn_coi.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_coi.FlatAppearance.BorderSize = 0
        Me.btn_coi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_coi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_coi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_coi.Font = New System.Drawing.Font("Montserrat SemiBold", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_coi.IconChar = FontAwesome.Sharp.IconChar.IdCard
        Me.btn_coi.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_coi.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_coi.IconSize = 20
        Me.btn_coi.Location = New System.Drawing.Point(1037, 303)
        Me.btn_coi.Name = "btn_coi"
        Me.btn_coi.Size = New System.Drawing.Size(200, 40)
        Me.btn_coi.TabIndex = 53
        Me.btn_coi.Text = "Cert for Indigency"
        Me.btn_coi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_coi.UseVisualStyleBackColor = False
        '
        'btn_brgyclear
        '
        Me.btn_brgyclear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_brgyclear.FlatAppearance.BorderSize = 0
        Me.btn_brgyclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_brgyclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_brgyclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_brgyclear.Font = New System.Drawing.Font("Montserrat SemiBold", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_brgyclear.IconChar = FontAwesome.Sharp.IconChar.IdCard
        Me.btn_brgyclear.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_brgyclear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_brgyclear.IconSize = 20
        Me.btn_brgyclear.Location = New System.Drawing.Point(1037, 257)
        Me.btn_brgyclear.Name = "btn_brgyclear"
        Me.btn_brgyclear.Size = New System.Drawing.Size(200, 40)
        Me.btn_brgyclear.TabIndex = 52
        Me.btn_brgyclear.Text = "Barangay Clearance"
        Me.btn_brgyclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_brgyclear.UseVisualStyleBackColor = False
        '
        'btn_brygid
        '
        Me.btn_brygid.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_brygid.FlatAppearance.BorderSize = 0
        Me.btn_brygid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_brygid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_brygid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_brygid.Font = New System.Drawing.Font("Montserrat SemiBold", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_brygid.IconChar = FontAwesome.Sharp.IconChar.IdCard
        Me.btn_brygid.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_brygid.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_brygid.IconSize = 20
        Me.btn_brygid.Location = New System.Drawing.Point(1037, 211)
        Me.btn_brygid.Name = "btn_brygid"
        Me.btn_brygid.Size = New System.Drawing.Size(200, 40)
        Me.btn_brygid.TabIndex = 51
        Me.btn_brygid.Text = "Barangay ID"
        Me.btn_brygid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_brygid.UseVisualStyleBackColor = False
        '
        'lbl_agegrpres
        '
        Me.lbl_agegrpres.AutoSize = True
        Me.lbl_agegrpres.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_agegrpres.Location = New System.Drawing.Point(119, 189)
        Me.lbl_agegrpres.Name = "lbl_agegrpres"
        Me.lbl_agegrpres.Size = New System.Drawing.Size(98, 22)
        Me.lbl_agegrpres.TabIndex = 50
        Me.lbl_agegrpres.Text = "Age Group"
        '
        'lbl_ageres
        '
        Me.lbl_ageres.AutoSize = True
        Me.lbl_ageres.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ageres.Location = New System.Drawing.Point(119, 167)
        Me.lbl_ageres.Name = "lbl_ageres"
        Me.lbl_ageres.Size = New System.Drawing.Size(43, 22)
        Me.lbl_ageres.TabIndex = 49
        Me.lbl_ageres.Text = "Age"
        '
        'lbl_voterres
        '
        Me.lbl_voterres.AutoSize = True
        Me.lbl_voterres.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_voterres.Location = New System.Drawing.Point(238, 265)
        Me.lbl_voterres.Name = "lbl_voterres"
        Me.lbl_voterres.Size = New System.Drawing.Size(64, 22)
        Me.lbl_voterres.TabIndex = 48
        Me.lbl_voterres.Text = "Voter?"
        '
        'lbl_religionres
        '
        Me.lbl_religionres.AutoSize = True
        Me.lbl_religionres.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_religionres.Location = New System.Drawing.Point(236, 243)
        Me.lbl_religionres.Name = "lbl_religionres"
        Me.lbl_religionres.Size = New System.Drawing.Size(79, 22)
        Me.lbl_religionres.TabIndex = 47
        Me.lbl_religionres.Text = "Religion"
        '
        'lbl_pobres
        '
        Me.lbl_pobres.AutoSize = True
        Me.lbl_pobres.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pobres.Location = New System.Drawing.Point(119, 145)
        Me.lbl_pobres.Name = "lbl_pobres"
        Me.lbl_pobres.Size = New System.Drawing.Size(47, 22)
        Me.lbl_pobres.TabIndex = 46
        Me.lbl_pobres.Text = "POB"
        '
        'pb_qrres
        '
        Me.pb_qrres.BackColor = System.Drawing.Color.Transparent
        Me.pb_qrres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_qrres.Location = New System.Drawing.Point(19, 246)
        Me.pb_qrres.Name = "pb_qrres"
        Me.pb_qrres.Size = New System.Drawing.Size(100, 100)
        Me.pb_qrres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_qrres.TabIndex = 45
        Me.pb_qrres.TabStop = False
        '
        'lbl_contactres
        '
        Me.lbl_contactres.AutoSize = True
        Me.lbl_contactres.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contactres.Location = New System.Drawing.Point(238, 309)
        Me.lbl_contactres.Name = "lbl_contactres"
        Me.lbl_contactres.Size = New System.Drawing.Size(107, 22)
        Me.lbl_contactres.TabIndex = 44
        Me.lbl_contactres.Text = "Contact No."
        Me.lbl_contactres.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_addressres
        '
        Me.lbl_addressres.AutoSize = True
        Me.lbl_addressres.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_addressres.Location = New System.Drawing.Point(238, 287)
        Me.lbl_addressres.Name = "lbl_addressres"
        Me.lbl_addressres.Size = New System.Drawing.Size(77, 22)
        Me.lbl_addressres.TabIndex = 43
        Me.lbl_addressres.Text = "Address"
        '
        'lbl_statusres
        '
        Me.lbl_statusres.AutoSize = True
        Me.lbl_statusres.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusres.Location = New System.Drawing.Point(119, 211)
        Me.lbl_statusres.Name = "lbl_statusres"
        Me.lbl_statusres.Size = New System.Drawing.Size(63, 22)
        Me.lbl_statusres.TabIndex = 42
        Me.lbl_statusres.Text = "Status"
        '
        'lbl_dobres
        '
        Me.lbl_dobres.AutoSize = True
        Me.lbl_dobres.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dobres.Location = New System.Drawing.Point(118, 123)
        Me.lbl_dobres.Name = "lbl_dobres"
        Me.lbl_dobres.Size = New System.Drawing.Size(48, 22)
        Me.lbl_dobres.TabIndex = 41
        Me.lbl_dobres.Text = "DOB"
        '
        'lbl_genderres
        '
        Me.lbl_genderres.AutoSize = True
        Me.lbl_genderres.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_genderres.Location = New System.Drawing.Point(118, 101)
        Me.lbl_genderres.Name = "lbl_genderres"
        Me.lbl_genderres.Size = New System.Drawing.Size(71, 22)
        Me.lbl_genderres.TabIndex = 40
        Me.lbl_genderres.Text = "Gender"
        '
        'lbl_idres
        '
        Me.lbl_idres.AutoSize = True
        Me.lbl_idres.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idres.Location = New System.Drawing.Point(15, 49)
        Me.lbl_idres.Name = "lbl_idres"
        Me.lbl_idres.Size = New System.Drawing.Size(102, 22)
        Me.lbl_idres.TabIndex = 39
        Me.lbl_idres.Text = "ResidentID"
        '
        'lbl_nameres
        '
        Me.lbl_nameres.AutoSize = True
        Me.lbl_nameres.Font = New System.Drawing.Font("Montserrat SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nameres.Location = New System.Drawing.Point(12, 12)
        Me.lbl_nameres.Name = "lbl_nameres"
        Me.lbl_nameres.Size = New System.Drawing.Size(253, 37)
        Me.lbl_nameres.TabIndex = 38
        Me.lbl_nameres.Text = "Last, First Middle"
        '
        'btn_showqr
        '
        Me.btn_showqr.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_showqr.FlatAppearance.BorderSize = 0
        Me.btn_showqr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_showqr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_showqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_showqr.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_showqr.IconChar = FontAwesome.Sharp.IconChar.Qrcode
        Me.btn_showqr.IconColor = System.Drawing.Color.Fuchsia
        Me.btn_showqr.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_showqr.IconSize = 20
        Me.btn_showqr.Location = New System.Drawing.Point(499, 359)
        Me.btn_showqr.Name = "btn_showqr"
        Me.btn_showqr.Size = New System.Drawing.Size(40, 40)
        Me.btn_showqr.TabIndex = 37
        Me.btn_showqr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_showqr.UseVisualStyleBackColor = False
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
        Me.btn_searchres.Location = New System.Drawing.Point(453, 359)
        Me.btn_searchres.Name = "btn_searchres"
        Me.btn_searchres.Size = New System.Drawing.Size(40, 40)
        Me.btn_searchres.TabIndex = 36
        Me.btn_searchres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_searchres.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 368)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 22)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Resident ID"
        '
        'tb_searchresident
        '
        Me.tb_searchresident.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_searchresident.Location = New System.Drawing.Point(124, 365)
        Me.tb_searchresident.Name = "tb_searchresident"
        Me.tb_searchresident.Size = New System.Drawing.Size(323, 27)
        Me.tb_searchresident.TabIndex = 34
        '
        'pb_imgres
        '
        Me.pb_imgres.BackColor = System.Drawing.Color.Black
        Me.pb_imgres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_imgres.Location = New System.Drawing.Point(1037, 5)
        Me.pb_imgres.Name = "pb_imgres"
        Me.pb_imgres.Size = New System.Drawing.Size(200, 200)
        Me.pb_imgres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_imgres.TabIndex = 33
        Me.pb_imgres.TabStop = False
        '
        'dgv_brgyinfo
        '
        Me.dgv_brgyinfo.AllowUserToAddRows = False
        Me.dgv_brgyinfo.AllowUserToDeleteRows = False
        Me.dgv_brgyinfo.AutoGenerateColumns = False
        Me.dgv_brgyinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_brgyinfo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_brgyinfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_brgyinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_brgyinfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_brgyinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_brgyinfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RESIDENTIDDataGridViewTextBoxColumn, Me.RESIDENTIMGDataGridViewImageColumn, Me.FNAMEDataGridViewTextBoxColumn, Me.MNAMEDataGridViewTextBoxColumn, Me.LNAMEDataGridViewTextBoxColumn, Me.GENDERDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.CIVILSTATUSDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.CONTACTNODataGridViewTextBoxColumn, Me.RESIDENTQRDataGridViewImageColumn})
        Me.dgv_brgyinfo.DataSource = Me.RESIDENTSBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_brgyinfo.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_brgyinfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_brgyinfo.EnableHeadersVisualStyles = False
        Me.dgv_brgyinfo.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_brgyinfo.Location = New System.Drawing.Point(0, 407)
        Me.dgv_brgyinfo.MultiSelect = False
        Me.dgv_brgyinfo.Name = "dgv_brgyinfo"
        Me.dgv_brgyinfo.ReadOnly = True
        Me.dgv_brgyinfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgv_brgyinfo.RowHeadersVisible = False
        Me.dgv_brgyinfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_brgyinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_brgyinfo.Size = New System.Drawing.Size(1240, 154)
        Me.dgv_brgyinfo.TabIndex = 20
        '
        'RESIDENTIDDataGridViewTextBoxColumn
        '
        Me.RESIDENTIDDataGridViewTextBoxColumn.DataPropertyName = "RESIDENTID"
        Me.RESIDENTIDDataGridViewTextBoxColumn.HeaderText = "RESIDENTID"
        Me.RESIDENTIDDataGridViewTextBoxColumn.Name = "RESIDENTIDDataGridViewTextBoxColumn"
        Me.RESIDENTIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RESIDENTIMGDataGridViewImageColumn
        '
        Me.RESIDENTIMGDataGridViewImageColumn.DataPropertyName = "RESIDENTIMG"
        Me.RESIDENTIMGDataGridViewImageColumn.HeaderText = "RESIDENTIMG"
        Me.RESIDENTIMGDataGridViewImageColumn.Name = "RESIDENTIMGDataGridViewImageColumn"
        Me.RESIDENTIMGDataGridViewImageColumn.ReadOnly = True
        Me.RESIDENTIMGDataGridViewImageColumn.Visible = False
        '
        'FNAMEDataGridViewTextBoxColumn
        '
        Me.FNAMEDataGridViewTextBoxColumn.DataPropertyName = "FNAME"
        Me.FNAMEDataGridViewTextBoxColumn.HeaderText = "FNAME"
        Me.FNAMEDataGridViewTextBoxColumn.Name = "FNAMEDataGridViewTextBoxColumn"
        Me.FNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MNAMEDataGridViewTextBoxColumn
        '
        Me.MNAMEDataGridViewTextBoxColumn.DataPropertyName = "MNAME"
        Me.MNAMEDataGridViewTextBoxColumn.HeaderText = "MNAME"
        Me.MNAMEDataGridViewTextBoxColumn.Name = "MNAMEDataGridViewTextBoxColumn"
        Me.MNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LNAMEDataGridViewTextBoxColumn
        '
        Me.LNAMEDataGridViewTextBoxColumn.DataPropertyName = "LNAME"
        Me.LNAMEDataGridViewTextBoxColumn.HeaderText = "LNAME"
        Me.LNAMEDataGridViewTextBoxColumn.Name = "LNAMEDataGridViewTextBoxColumn"
        Me.LNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GENDERDataGridViewTextBoxColumn
        '
        Me.GENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.HeaderText = "GENDER"
        Me.GENDERDataGridViewTextBoxColumn.Name = "GENDERDataGridViewTextBoxColumn"
        Me.GENDERDataGridViewTextBoxColumn.ReadOnly = True
        Me.GENDERDataGridViewTextBoxColumn.Visible = False
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        Me.DOBDataGridViewTextBoxColumn.ReadOnly = True
        Me.DOBDataGridViewTextBoxColumn.Visible = False
        '
        'CIVILSTATUSDataGridViewTextBoxColumn
        '
        Me.CIVILSTATUSDataGridViewTextBoxColumn.DataPropertyName = "CIVILSTATUS"
        Me.CIVILSTATUSDataGridViewTextBoxColumn.HeaderText = "CIVILSTATUS"
        Me.CIVILSTATUSDataGridViewTextBoxColumn.Name = "CIVILSTATUSDataGridViewTextBoxColumn"
        Me.CIVILSTATUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.CIVILSTATUSDataGridViewTextBoxColumn.Visible = False
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        Me.ADDRESSDataGridViewTextBoxColumn.ReadOnly = True
        Me.ADDRESSDataGridViewTextBoxColumn.Visible = False
        '
        'CONTACTNODataGridViewTextBoxColumn
        '
        Me.CONTACTNODataGridViewTextBoxColumn.DataPropertyName = "CONTACTNO"
        Me.CONTACTNODataGridViewTextBoxColumn.HeaderText = "CONTACTNO"
        Me.CONTACTNODataGridViewTextBoxColumn.Name = "CONTACTNODataGridViewTextBoxColumn"
        Me.CONTACTNODataGridViewTextBoxColumn.ReadOnly = True
        Me.CONTACTNODataGridViewTextBoxColumn.Visible = False
        '
        'RESIDENTQRDataGridViewImageColumn
        '
        Me.RESIDENTQRDataGridViewImageColumn.DataPropertyName = "RESIDENTQR"
        Me.RESIDENTQRDataGridViewImageColumn.HeaderText = "RESIDENTQR"
        Me.RESIDENTQRDataGridViewImageColumn.Name = "RESIDENTQRDataGridViewImageColumn"
        Me.RESIDENTQRDataGridViewImageColumn.ReadOnly = True
        Me.RESIDENTQRDataGridViewImageColumn.Visible = False
        '
        'RESIDENTSBindingSource
        '
        Me.RESIDENTSBindingSource.DataMember = "RESIDENTS"
        Me.RESIDENTSBindingSource.DataSource = Me.Ds_brgyresidents
        '
        'Ds_brgyresidents
        '
        Me.Ds_brgyresidents.DataSetName = "ds_brgyresidents"
        Me.Ds_brgyresidents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RESIDENTSTableAdapter
        '
        Me.RESIDENTSTableAdapter.ClearBeforeFill = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument2
        '
        '
        'PrintPreviewDialog2
        '
        Me.PrintPreviewDialog2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog2.Enabled = True
        Me.PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog2.Name = "PrintPreviewDialog2"
        Me.PrintPreviewDialog2.Visible = False
        '
        'PrintDocument3
        '
        '
        'PrintPreviewDialog3
        '
        Me.PrintPreviewDialog3.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog3.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog3.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog3.Enabled = True
        Me.PrintPreviewDialog3.Icon = CType(resources.GetObject("PrintPreviewDialog3.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog3.Name = "PrintPreviewDialog3"
        Me.PrintPreviewDialog3.Visible = False
        '
        'PrintDocument4
        '
        '
        'PrintPreviewDialog4
        '
        Me.PrintPreviewDialog4.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog4.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog4.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog4.Enabled = True
        Me.PrintPreviewDialog4.Icon = CType(resources.GetObject("PrintPreviewDialog4.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog4.Name = "PrintPreviewDialog4"
        Me.PrintPreviewDialog4.Visible = False
        '
        'residentlistpanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 561)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(1256, 1000)
        Me.Name = "residentlistpanel"
        Me.Text = "residentlistpanel"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pb_qrres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_imgres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_brgyinfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RESIDENTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_brgyresidents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgv_brgyinfo As DataGridView
    Friend WithEvents Ds_brgyresidents As ds_brgyresidents
    Friend WithEvents RESIDENTSBindingSource As BindingSource
    Friend WithEvents RESIDENTSTableAdapter As ds_brgyresidentsTableAdapters.RESIDENTSTableAdapter
    Friend WithEvents RESIDENTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RESIDENTIMGDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents FNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GENDERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CIVILSTATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONTACTNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RESIDENTQRDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents pb_imgres As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_searchresident As TextBox
    Friend WithEvents btn_showqr As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_searchres As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_nameres As Label
    Friend WithEvents lbl_contactres As Label
    Friend WithEvents lbl_addressres As Label
    Friend WithEvents lbl_statusres As Label
    Friend WithEvents lbl_dobres As Label
    Friend WithEvents lbl_genderres As Label
    Friend WithEvents lbl_idres As Label
    Friend WithEvents pb_qrres As PictureBox
    Friend WithEvents lbl_agegrpres As Label
    Friend WithEvents lbl_ageres As Label
    Friend WithEvents lbl_voterres As Label
    Friend WithEvents lbl_religionres As Label
    Friend WithEvents lbl_pobres As Label
    Friend WithEvents btn_brgypermit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_coi As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_brgyclear As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_brygid As FontAwesome.Sharp.IconButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog2 As PrintPreviewDialog
    Friend WithEvents PrintDocument3 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog3 As PrintPreviewDialog
    Friend WithEvents PrintDocument4 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog4 As PrintPreviewDialog
End Class
