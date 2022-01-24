<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homepanel
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_voter = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.IconPictureBox8 = New FontAwesome.Sharp.IconPictureBox()
        Me.lbl_senior = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.IconPictureBox7 = New FontAwesome.Sharp.IconPictureBox()
        Me.lbl_adults = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IconPictureBox6 = New FontAwesome.Sharp.IconPictureBox()
        Me.lbl_teens = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Me.lbl_kids = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.lbl_brgyaddress = New System.Windows.Forms.Label()
        Me.pb_brgylogo = New System.Windows.Forms.PictureBox()
        Me.lbl_brgyname = New System.Windows.Forms.Label()
        Me.dgv_brgyinfo = New System.Windows.Forms.DataGridView()
        Me.RESIDENTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIVILSTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESIDENTIMGDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.RESIDENTQRDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.RESIDENTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_brgyresidents = New datuinfosys.ds_brgyresidents()
        Me.lbl_female = New System.Windows.Forms.Label()
        Me.lbl_male = New System.Windows.Forms.Label()
        Me.lbl_population = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.Male = New System.Windows.Forms.Label()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.RESIDENTSTableAdapter = New datuinfosys.ds_brgyresidentsTableAdapters.RESIDENTSTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Ds_brgyofficials = New datuinfosys.Ds_brgyofficials()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New datuinfosys.Ds_brgyofficialsTableAdapters.Table1TableAdapter()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.OFFICIALIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSITIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNAMEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNAMEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMGLOCATIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_brgylogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_brgyinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RESIDENTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_brgyresidents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_brgyofficials, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.lbl_voter)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.IconPictureBox8)
        Me.Panel1.Controls.Add(Me.lbl_senior)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.IconPictureBox7)
        Me.Panel1.Controls.Add(Me.lbl_adults)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.IconPictureBox6)
        Me.Panel1.Controls.Add(Me.lbl_teens)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.IconPictureBox5)
        Me.Panel1.Controls.Add(Me.lbl_kids)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.IconPictureBox4)
        Me.Panel1.Controls.Add(Me.lbl_brgyaddress)
        Me.Panel1.Controls.Add(Me.pb_brgylogo)
        Me.Panel1.Controls.Add(Me.lbl_brgyname)
        Me.Panel1.Controls.Add(Me.dgv_brgyinfo)
        Me.Panel1.Controls.Add(Me.lbl_female)
        Me.Panel1.Controls.Add(Me.lbl_male)
        Me.Panel1.Controls.Add(Me.lbl_population)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.IconPictureBox3)
        Me.Panel1.Controls.Add(Me.Male)
        Me.Panel1.Controls.Add(Me.IconPictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.IconPictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 561)
        Me.Panel1.TabIndex = 0
        '
        'lbl_voter
        '
        Me.lbl_voter.AutoSize = True
        Me.lbl_voter.BackColor = System.Drawing.Color.White
        Me.lbl_voter.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_voter.ForeColor = System.Drawing.Color.Black
        Me.lbl_voter.Location = New System.Drawing.Point(388, 308)
        Me.lbl_voter.Name = "lbl_voter"
        Me.lbl_voter.Size = New System.Drawing.Size(21, 22)
        Me.lbl_voter.TabIndex = 39
        Me.lbl_voter.Text = "0"
        Me.lbl_voter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(388, 285)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 22)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Voters"
        '
        'IconPictureBox8
        '
        Me.IconPictureBox8.BackColor = System.Drawing.Color.White
        Me.IconPictureBox8.ForeColor = System.Drawing.Color.Fuchsia
        Me.IconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.VoteYea
        Me.IconPictureBox8.IconColor = System.Drawing.Color.Fuchsia
        Me.IconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconPictureBox8.IconSize = 61
        Me.IconPictureBox8.Location = New System.Drawing.Point(303, 282)
        Me.IconPictureBox8.Name = "IconPictureBox8"
        Me.IconPictureBox8.Size = New System.Drawing.Size(200, 61)
        Me.IconPictureBox8.TabIndex = 37
        Me.IconPictureBox8.TabStop = False
        '
        'lbl_senior
        '
        Me.lbl_senior.AutoSize = True
        Me.lbl_senior.BackColor = System.Drawing.Color.White
        Me.lbl_senior.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_senior.ForeColor = System.Drawing.Color.Black
        Me.lbl_senior.Location = New System.Drawing.Point(594, 308)
        Me.lbl_senior.Name = "lbl_senior"
        Me.lbl_senior.Size = New System.Drawing.Size(21, 22)
        Me.lbl_senior.TabIndex = 36
        Me.lbl_senior.Text = "0"
        Me.lbl_senior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(594, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 22)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Senior"
        '
        'IconPictureBox7
        '
        Me.IconPictureBox7.BackColor = System.Drawing.Color.White
        Me.IconPictureBox7.ForeColor = System.Drawing.Color.Fuchsia
        Me.IconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Male
        Me.IconPictureBox7.IconColor = System.Drawing.Color.Fuchsia
        Me.IconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconPictureBox7.IconSize = 61
        Me.IconPictureBox7.Location = New System.Drawing.Point(509, 282)
        Me.IconPictureBox7.Name = "IconPictureBox7"
        Me.IconPictureBox7.Size = New System.Drawing.Size(200, 61)
        Me.IconPictureBox7.TabIndex = 34
        Me.IconPictureBox7.TabStop = False
        '
        'lbl_adults
        '
        Me.lbl_adults.AutoSize = True
        Me.lbl_adults.BackColor = System.Drawing.Color.White
        Me.lbl_adults.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_adults.ForeColor = System.Drawing.Color.Black
        Me.lbl_adults.Location = New System.Drawing.Point(594, 241)
        Me.lbl_adults.Name = "lbl_adults"
        Me.lbl_adults.Size = New System.Drawing.Size(21, 22)
        Me.lbl_adults.TabIndex = 33
        Me.lbl_adults.Text = "0"
        Me.lbl_adults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(594, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 22)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Adults"
        '
        'IconPictureBox6
        '
        Me.IconPictureBox6.BackColor = System.Drawing.Color.White
        Me.IconPictureBox6.ForeColor = System.Drawing.Color.Fuchsia
        Me.IconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Male
        Me.IconPictureBox6.IconColor = System.Drawing.Color.Fuchsia
        Me.IconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconPictureBox6.IconSize = 61
        Me.IconPictureBox6.Location = New System.Drawing.Point(509, 215)
        Me.IconPictureBox6.Name = "IconPictureBox6"
        Me.IconPictureBox6.Size = New System.Drawing.Size(200, 61)
        Me.IconPictureBox6.TabIndex = 31
        Me.IconPictureBox6.TabStop = False
        '
        'lbl_teens
        '
        Me.lbl_teens.AutoSize = True
        Me.lbl_teens.BackColor = System.Drawing.Color.White
        Me.lbl_teens.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_teens.ForeColor = System.Drawing.Color.Black
        Me.lbl_teens.Location = New System.Drawing.Point(594, 174)
        Me.lbl_teens.Name = "lbl_teens"
        Me.lbl_teens.Size = New System.Drawing.Size(21, 22)
        Me.lbl_teens.TabIndex = 30
        Me.lbl_teens.Text = "0"
        Me.lbl_teens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(594, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 22)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Teens"
        '
        'IconPictureBox5
        '
        Me.IconPictureBox5.BackColor = System.Drawing.Color.White
        Me.IconPictureBox5.ForeColor = System.Drawing.Color.Fuchsia
        Me.IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Male
        Me.IconPictureBox5.IconColor = System.Drawing.Color.Fuchsia
        Me.IconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconPictureBox5.IconSize = 61
        Me.IconPictureBox5.Location = New System.Drawing.Point(509, 148)
        Me.IconPictureBox5.Name = "IconPictureBox5"
        Me.IconPictureBox5.Size = New System.Drawing.Size(200, 61)
        Me.IconPictureBox5.TabIndex = 28
        Me.IconPictureBox5.TabStop = False
        '
        'lbl_kids
        '
        Me.lbl_kids.AutoSize = True
        Me.lbl_kids.BackColor = System.Drawing.Color.White
        Me.lbl_kids.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kids.ForeColor = System.Drawing.Color.Black
        Me.lbl_kids.Location = New System.Drawing.Point(594, 107)
        Me.lbl_kids.Name = "lbl_kids"
        Me.lbl_kids.Size = New System.Drawing.Size(21, 22)
        Me.lbl_kids.TabIndex = 27
        Me.lbl_kids.Text = "0"
        Me.lbl_kids.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(594, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 22)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Kids"
        '
        'IconPictureBox4
        '
        Me.IconPictureBox4.BackColor = System.Drawing.Color.White
        Me.IconPictureBox4.ForeColor = System.Drawing.Color.Fuchsia
        Me.IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Male
        Me.IconPictureBox4.IconColor = System.Drawing.Color.Fuchsia
        Me.IconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconPictureBox4.IconSize = 61
        Me.IconPictureBox4.Location = New System.Drawing.Point(509, 81)
        Me.IconPictureBox4.Name = "IconPictureBox4"
        Me.IconPictureBox4.Size = New System.Drawing.Size(200, 61)
        Me.IconPictureBox4.TabIndex = 25
        Me.IconPictureBox4.TabStop = False
        '
        'lbl_brgyaddress
        '
        Me.lbl_brgyaddress.AutoSize = True
        Me.lbl_brgyaddress.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brgyaddress.Location = New System.Drawing.Point(298, 52)
        Me.lbl_brgyaddress.Name = "lbl_brgyaddress"
        Me.lbl_brgyaddress.Size = New System.Drawing.Size(231, 26)
        Me.lbl_brgyaddress.TabIndex = 24
        Me.lbl_brgyaddress.Text = "BARANGAY ADDRESS"
        '
        'pb_brgylogo
        '
        Me.pb_brgylogo.Location = New System.Drawing.Point(12, 15)
        Me.pb_brgylogo.Name = "pb_brgylogo"
        Me.pb_brgylogo.Size = New System.Drawing.Size(278, 272)
        Me.pb_brgylogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_brgylogo.TabIndex = 23
        Me.pb_brgylogo.TabStop = False
        '
        'lbl_brgyname
        '
        Me.lbl_brgyname.AutoSize = True
        Me.lbl_brgyname.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brgyname.Location = New System.Drawing.Point(296, 15)
        Me.lbl_brgyname.Name = "lbl_brgyname"
        Me.lbl_brgyname.Size = New System.Drawing.Size(181, 37)
        Me.lbl_brgyname.TabIndex = 22
        Me.lbl_brgyname.Text = "BARANGAY"
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_brgyinfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_brgyinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_brgyinfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RESIDENTIDDataGridViewTextBoxColumn, Me.FNAMEDataGridViewTextBoxColumn, Me.MNAMEDataGridViewTextBoxColumn, Me.LNAMEDataGridViewTextBoxColumn, Me.GENDERDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.CIVILSTATUSDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.CONTACTNODataGridViewTextBoxColumn, Me.RESIDENTIMGDataGridViewImageColumn, Me.RESIDENTQRDataGridViewImageColumn})
        Me.dgv_brgyinfo.DataSource = Me.RESIDENTSBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_brgyinfo.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_brgyinfo.EnableHeadersVisualStyles = False
        Me.dgv_brgyinfo.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_brgyinfo.Location = New System.Drawing.Point(12, 293)
        Me.dgv_brgyinfo.MultiSelect = False
        Me.dgv_brgyinfo.Name = "dgv_brgyinfo"
        Me.dgv_brgyinfo.ReadOnly = True
        Me.dgv_brgyinfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgv_brgyinfo.RowHeadersVisible = False
        Me.dgv_brgyinfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_brgyinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_brgyinfo.Size = New System.Drawing.Size(278, 256)
        Me.dgv_brgyinfo.TabIndex = 21
        '
        'RESIDENTIDDataGridViewTextBoxColumn
        '
        Me.RESIDENTIDDataGridViewTextBoxColumn.DataPropertyName = "RESIDENTID"
        Me.RESIDENTIDDataGridViewTextBoxColumn.HeaderText = "RESIDENTID"
        Me.RESIDENTIDDataGridViewTextBoxColumn.Name = "RESIDENTIDDataGridViewTextBoxColumn"
        Me.RESIDENTIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FNAMEDataGridViewTextBoxColumn
        '
        Me.FNAMEDataGridViewTextBoxColumn.DataPropertyName = "FNAME"
        Me.FNAMEDataGridViewTextBoxColumn.HeaderText = "FNAME"
        Me.FNAMEDataGridViewTextBoxColumn.Name = "FNAMEDataGridViewTextBoxColumn"
        Me.FNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.FNAMEDataGridViewTextBoxColumn.Visible = False
        '
        'MNAMEDataGridViewTextBoxColumn
        '
        Me.MNAMEDataGridViewTextBoxColumn.DataPropertyName = "MNAME"
        Me.MNAMEDataGridViewTextBoxColumn.HeaderText = "MNAME"
        Me.MNAMEDataGridViewTextBoxColumn.Name = "MNAMEDataGridViewTextBoxColumn"
        Me.MNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.MNAMEDataGridViewTextBoxColumn.Visible = False
        '
        'LNAMEDataGridViewTextBoxColumn
        '
        Me.LNAMEDataGridViewTextBoxColumn.DataPropertyName = "LNAME"
        Me.LNAMEDataGridViewTextBoxColumn.HeaderText = "LNAME"
        Me.LNAMEDataGridViewTextBoxColumn.Name = "LNAMEDataGridViewTextBoxColumn"
        Me.LNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.LNAMEDataGridViewTextBoxColumn.Visible = False
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
        'RESIDENTIMGDataGridViewImageColumn
        '
        Me.RESIDENTIMGDataGridViewImageColumn.DataPropertyName = "RESIDENTIMG"
        Me.RESIDENTIMGDataGridViewImageColumn.HeaderText = "RESIDENTIMG"
        Me.RESIDENTIMGDataGridViewImageColumn.Name = "RESIDENTIMGDataGridViewImageColumn"
        Me.RESIDENTIMGDataGridViewImageColumn.ReadOnly = True
        Me.RESIDENTIMGDataGridViewImageColumn.Visible = False
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
        'lbl_female
        '
        Me.lbl_female.AutoSize = True
        Me.lbl_female.BackColor = System.Drawing.Color.White
        Me.lbl_female.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_female.ForeColor = System.Drawing.Color.Black
        Me.lbl_female.Location = New System.Drawing.Point(388, 241)
        Me.lbl_female.Name = "lbl_female"
        Me.lbl_female.Size = New System.Drawing.Size(21, 22)
        Me.lbl_female.TabIndex = 8
        Me.lbl_female.Text = "0"
        Me.lbl_female.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_male
        '
        Me.lbl_male.AutoSize = True
        Me.lbl_male.BackColor = System.Drawing.Color.White
        Me.lbl_male.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_male.ForeColor = System.Drawing.Color.Black
        Me.lbl_male.Location = New System.Drawing.Point(388, 174)
        Me.lbl_male.Name = "lbl_male"
        Me.lbl_male.Size = New System.Drawing.Size(21, 22)
        Me.lbl_male.TabIndex = 7
        Me.lbl_male.Text = "0"
        Me.lbl_male.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_population
        '
        Me.lbl_population.AutoSize = True
        Me.lbl_population.BackColor = System.Drawing.Color.White
        Me.lbl_population.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_population.ForeColor = System.Drawing.Color.Black
        Me.lbl_population.Location = New System.Drawing.Point(388, 107)
        Me.lbl_population.Name = "lbl_population"
        Me.lbl_population.Size = New System.Drawing.Size(21, 22)
        Me.lbl_population.TabIndex = 6
        Me.lbl_population.Text = "0"
        Me.lbl_population.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(388, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Female"
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.White
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.Fuchsia
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Female
        Me.IconPictureBox3.IconColor = System.Drawing.Color.Fuchsia
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconPictureBox3.IconSize = 61
        Me.IconPictureBox3.Location = New System.Drawing.Point(303, 215)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(200, 61)
        Me.IconPictureBox3.TabIndex = 4
        Me.IconPictureBox3.TabStop = False
        '
        'Male
        '
        Me.Male.AutoSize = True
        Me.Male.BackColor = System.Drawing.Color.White
        Me.Male.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Male.ForeColor = System.Drawing.Color.Black
        Me.Male.Location = New System.Drawing.Point(388, 151)
        Me.Male.Name = "Male"
        Me.Male.Size = New System.Drawing.Size(50, 22)
        Me.Male.TabIndex = 3
        Me.Male.Text = "Male"
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.White
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.Fuchsia
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Male
        Me.IconPictureBox2.IconColor = System.Drawing.Color.Fuchsia
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconPictureBox2.IconSize = 61
        Me.IconPictureBox2.Location = New System.Drawing.Point(303, 148)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(200, 61)
        Me.IconPictureBox2.TabIndex = 2
        Me.IconPictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(388, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Population"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.White
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.Fuchsia
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserFriends
        Me.IconPictureBox1.IconColor = System.Drawing.Color.Fuchsia
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.IconPictureBox1.IconSize = 61
        Me.IconPictureBox1.Location = New System.Drawing.Point(303, 81)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(200, 61)
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
        '
        'RESIDENTSTableAdapter
        '
        Me.RESIDENTSTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OFFICIALIDDataGridViewTextBoxColumn, Me.POSITIONDataGridViewTextBoxColumn, Me.FNAMEDataGridViewTextBoxColumn1, Me.LNAMEDataGridViewTextBoxColumn1, Me.IMGLOCATIONDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Montserrat SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(715, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(513, 259)
        Me.DataGridView1.TabIndex = 40
        '
        'Ds_brgyofficials
        '
        Me.Ds_brgyofficials.DataSetName = "Ds_brgyofficials"
        Me.Ds_brgyofficials.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Ds_brgyofficials
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(708, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(280, 37)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Barangay Officials"
        '
        'OFFICIALIDDataGridViewTextBoxColumn
        '
        Me.OFFICIALIDDataGridViewTextBoxColumn.DataPropertyName = "OFFICIALID"
        Me.OFFICIALIDDataGridViewTextBoxColumn.HeaderText = "OFFICIALID"
        Me.OFFICIALIDDataGridViewTextBoxColumn.Name = "OFFICIALIDDataGridViewTextBoxColumn"
        Me.OFFICIALIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.OFFICIALIDDataGridViewTextBoxColumn.Visible = False
        '
        'POSITIONDataGridViewTextBoxColumn
        '
        Me.POSITIONDataGridViewTextBoxColumn.DataPropertyName = "POSITION"
        Me.POSITIONDataGridViewTextBoxColumn.FillWeight = 152.2843!
        Me.POSITIONDataGridViewTextBoxColumn.HeaderText = "POSITION"
        Me.POSITIONDataGridViewTextBoxColumn.Name = "POSITIONDataGridViewTextBoxColumn"
        Me.POSITIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FNAMEDataGridViewTextBoxColumn1
        '
        Me.FNAMEDataGridViewTextBoxColumn1.DataPropertyName = "FNAME"
        Me.FNAMEDataGridViewTextBoxColumn1.FillWeight = 73.85786!
        Me.FNAMEDataGridViewTextBoxColumn1.HeaderText = "FNAME"
        Me.FNAMEDataGridViewTextBoxColumn1.Name = "FNAMEDataGridViewTextBoxColumn1"
        Me.FNAMEDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'LNAMEDataGridViewTextBoxColumn1
        '
        Me.LNAMEDataGridViewTextBoxColumn1.DataPropertyName = "LNAME"
        Me.LNAMEDataGridViewTextBoxColumn1.FillWeight = 73.85786!
        Me.LNAMEDataGridViewTextBoxColumn1.HeaderText = "LNAME"
        Me.LNAMEDataGridViewTextBoxColumn1.Name = "LNAMEDataGridViewTextBoxColumn1"
        Me.LNAMEDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'IMGLOCATIONDataGridViewTextBoxColumn
        '
        Me.IMGLOCATIONDataGridViewTextBoxColumn.DataPropertyName = "IMGLOCATION"
        Me.IMGLOCATIONDataGridViewTextBoxColumn.HeaderText = "IMGLOCATION"
        Me.IMGLOCATIONDataGridViewTextBoxColumn.Name = "IMGLOCATIONDataGridViewTextBoxColumn"
        Me.IMGLOCATIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.IMGLOCATIONDataGridViewTextBoxColumn.Visible = False
        '
        'homepanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1240, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "homepanel"
        Me.Text = "homepanel"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_brgylogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_brgyinfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RESIDENTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_brgyresidents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_brgyofficials, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_female As Label
    Friend WithEvents lbl_male As Label
    Friend WithEvents lbl_population As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Male As Label
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents dgv_brgyinfo As DataGridView
    Friend WithEvents Ds_brgyresidents As ds_brgyresidents
    Friend WithEvents RESIDENTSBindingSource As BindingSource
    Friend WithEvents RESIDENTSTableAdapter As ds_brgyresidentsTableAdapters.RESIDENTSTableAdapter
    Friend WithEvents RESIDENTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GENDERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CIVILSTATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONTACTNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RESIDENTIMGDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents RESIDENTQRDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents lbl_brgyname As Label
    Friend WithEvents pb_brgylogo As PictureBox
    Friend WithEvents lbl_brgyaddress As Label
    Friend WithEvents lbl_voter As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents IconPictureBox8 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lbl_senior As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents IconPictureBox7 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lbl_adults As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents IconPictureBox6 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lbl_teens As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lbl_kids As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Ds_brgyofficials As Ds_brgyofficials
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As Ds_brgyofficialsTableAdapters.Table1TableAdapter
    Friend WithEvents Label13 As Label
    Friend WithEvents OFFICIALIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POSITIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FNAMEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LNAMEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IMGLOCATIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
