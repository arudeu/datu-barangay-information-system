Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.Data.SqlClient
Imports System.IO
Imports QRCoder


Imports System.Text
Imports System.Drawing.Imaging

Public Class addresidentpanel
    Dim CONSTRING As String = "Data Source=DESKTOP-9S3FKV6\SQLEXPRESS;Initial Catalog=datudb;Integrated Security=True"
    Dim opf As New OpenFileDialog
    Dim CAMERA As VideoCaptureDevice
    Dim BMP As Bitmap
    Function RANDOMIDGENERATOR(R As Random)
        Dim QUERYSTR As String = "0123456789"
        Dim SB As New StringBuilder


        Dim COUNT As Integer = 9
        For I As Integer = 1 To COUNT
            Dim INDEX As Integer = R.Next(0, QUERYSTR.Length)
            SB.Append(QUERYSTR.Substring(INDEX, 1))
        Next
        Return SB.ToString
    End Function

    Private Sub btn_addres_Click(sender As Object, e As EventArgs) Handles btn_addres.Click
        ADDRESIDENT()
    End Sub

    Private Sub addresidentpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim YEAR As Integer = Date.Today.Year

        Dim R As New Random
        lbl_residentid.Text = YEAR.ToString() & RANDOMIDGENERATOR(R)

        GENERATEQR()
        CLEARFIELDS()
        btn_editres.Enabled = False

    End Sub

    Public Sub COMPUTEAGE(AGE AS INTEGER)

    End Sub
    Public Sub GENERATEQR()
        Dim GENERATE As New QRCodeGenerator
        Dim DATA = GENERATE.CreateQrCode(lbl_residentid.Text, QRCodeGenerator.ECCLevel.Q)
        Dim CODE As New QRCode(DATA)
        pb_qrcode.Image = CODE.GetGraphic(6)
    End Sub

    Public Sub CAMERASETUP()
        Dim CAM As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If CAM.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CAMERA = CAM.VideoDevice
            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf CAPS)
            CAMERA.Start()
        End If

    End Sub
    Public Sub CAPS(SENDER As Object, EVENTARGS As NewFrameEventArgs)
        BMP = DirectCast(EVENTARGS.Frame.Clone(), Bitmap)
        pb_liveshot.Image = DirectCast(EVENTARGS.Frame.Clone(), Bitmap)
    End Sub

    Private Sub icb_camera_Click(sender As Object, e As EventArgs) Handles icb_camera.Click
        CAMERASETUP()
    End Sub

    Private Sub icb_capture_Click(sender As Object, e As EventArgs) Handles icb_capture.Click
        pb_captured.Image = pb_liveshot.Image
    End Sub

    Public Sub UPDATERESIDENT()
        Dim RESIDENTID As String = lbl_residentid.Text
        Dim RESIDENTFNAME As String = tb_fname.Text
        Dim RESIDENTMNAME As String = tb_mname.Text
        Dim RESIDENTLNAME As String = tb_lname.Text
        Dim RESIDENTGENDER As String = cb_genderx.Text
        Dim RESIDENTDOB As Date = date_dob.Value
        Dim RESIDENTPOB As String = tb_pob.Text
        Dim RESIDENTSTATUS As String = cb_status.Text
        Dim RESIDENTERELIGION As String = cb_religion.Text
        Dim RESIDENTVOTER As String = cb_voter.Text
        Dim RESIDENTADDRESS As String = tb_address.Text
        Dim RESIDENTCONTACT As String = tb_contact.Text
        Dim RESIDENTAGEGGRROUP As String = lbl_agegroup.Text
        Dim RESIDENTIMG As Image = pb_captured.Image

        Dim RESIDENTQR As Image = pb_qrcode.Image



        Dim SQL As String = "UPDATE [RESIDENTS] SET FNAME = @FNAME, MNAME = @MNAME, LNAME = @LNAME, GENDER = @GENDER, DOB = @DOB, POB = @POB, CIVILSTATUS = @CIVILSTATUS,
RELIGION = @RELIGION, VOTER = @VOTER, ADDRESS = @ADDRESS, CONTACTNO = @CONTACTNO, AGEGROUP = @AGEGROUP, RESIDENTIMG = @RESIDENTIMG WHERE RESIDENTID = @RESIDENTID"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As New SqlCommand(SQL, CON)
                CMD.Parameters.AddWithValue("@RESIDENTID", RESIDENTID)
                CMD.Parameters.AddWithValue("@FNAME", RESIDENTFNAME)
                CMD.Parameters.AddWithValue("@MNAME", RESIDENTMNAME)
                CMD.Parameters.AddWithValue("@LNAME", RESIDENTLNAME)
                CMD.Parameters.AddWithValue("@GENDER", RESIDENTGENDER)
                CMD.Parameters.AddWithValue("@DOB", RESIDENTDOB)
                CMD.Parameters.AddWithValue("@POB", RESIDENTPOB)
                CMD.Parameters.AddWithValue("@CIVILSTATUS", RESIDENTSTATUS)
                CMD.Parameters.AddWithValue("@RELIGION", RESIDENTERELIGION)
                CMD.Parameters.AddWithValue("@VOTER", RESIDENTVOTER)
                CMD.Parameters.AddWithValue("@ADDRESS", RESIDENTADDRESS)
                CMD.Parameters.AddWithValue("@CONTACTNO", RESIDENTCONTACT)
                CMD.Parameters.AddWithValue("@AGEGROUP", RESIDENTAGEGGRROUP)

                Dim MS As New MemoryStream
                RESIDENTIMG.Save(MS, ImageFormat.Jpeg)
                Dim BT As Byte() = MS.ToArray()
                Dim P As New SqlParameter("@RESIDENTIMG", SqlDbType.Image)
                P.Value = BT
                CMD.Parameters.Add(P)

                CON.Open()
                CMD.ExecuteNonQuery()
                CON.Close()
                MessageBox.Show("Changes Saved!")
                CLEARFIELDS()
            End Using
        End Using
    End Sub

    Public Sub ADDRESIDENT()
        Dim RESIDENTID As String = lbl_residentid.Text
        Dim RESIDENTFNAME As String = tb_fname.Text
        Dim RESIDENTMNAME As String = tb_mname.Text
        Dim RESIDENTLNAME As String = tb_lname.Text
        Dim RESIDENTGENDER As String = cb_genderx.Text
        Dim RESIDENTDOB As Date = date_dob.Value
        Dim RESIDENTPOB As String = tb_pob.Text
        Dim RESIDENTSTATUS As String = cb_status.Text
        Dim RESIDENTERELIGION As String = cb_religion.Text
        Dim RESIDENTVOTER As String = cb_voter.Text
        Dim RESIDENTADDRESS As String = tb_address.Text
        Dim RESIDENTCONTACT As String = tb_contact.Text
        Dim RESIDENTAGEGGRROUP As String = lbl_agegroup.Text
        Dim RESIDENTIMG As Image = pb_captured.Image

        Dim RESIDENTQR As Image = pb_qrcode.Image



        Dim SQL As String = "INSERT INTO [RESIDENTS] VALUES (@RESIDENTID,@FNAME,@MNAME,@LNAME,@GENDER,@DOB,@POB,@CIVILSTATUS,@RELIGION,@VOTER,@ADDRESS,@CONTACTNO,@AGEGROUP,@RESIDENTIMG,@RESIDENTQR)"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As New SqlCommand(SQL, CON)
                CMD.Parameters.AddWithValue("@RESIDENTID", RESIDENTID)
                CMD.Parameters.AddWithValue("@FNAME", RESIDENTFNAME)
                CMD.Parameters.AddWithValue("@MNAME", RESIDENTMNAME)
                CMD.Parameters.AddWithValue("@LNAME", RESIDENTLNAME)
                CMD.Parameters.AddWithValue("@GENDER", RESIDENTGENDER)
                CMD.Parameters.AddWithValue("@DOB", RESIDENTDOB)
                CMD.Parameters.AddWithValue("@POB", RESIDENTPOB)
                CMD.Parameters.AddWithValue("@CIVILSTATUS", RESIDENTSTATUS)
                CMD.Parameters.AddWithValue("@RELIGION", RESIDENTERELIGION)
                CMD.Parameters.AddWithValue("@VOTER", RESIDENTVOTER)
                CMD.Parameters.AddWithValue("@ADDRESS", RESIDENTADDRESS)
                CMD.Parameters.AddWithValue("@CONTACTNO", RESIDENTCONTACT)
                CMD.Parameters.AddWithValue("@AGEGROUP", RESIDENTAGEGGRROUP)

                Dim MS As New MemoryStream
                RESIDENTIMG.Save(MS, ImageFormat.Jpeg)
                Dim BT As Byte() = MS.ToArray()
                Dim P As New SqlParameter("@RESIDENTIMG", SqlDbType.Image)
                P.Value = BT
                CMD.Parameters.Add(P)

                Dim MX As New MemoryStream
                RESIDENTQR.Save(MX, ImageFormat.Jpeg)
                Dim BX As Byte() = MX.ToArray()
                Dim X As New SqlParameter("@RESIDENTQR", SqlDbType.Image)
                X.Value = BX
                CMD.Parameters.Add(X)

                CON.Open()
                CMD.ExecuteNonQuery()
                CON.Close()
                MessageBox.Show("Changes Saved!")
                CLEARFIELDS()
            End Using
        End Using
    End Sub

    Private Sub date_dob_ValueChanged(sender As Object, e As EventArgs) Handles date_dob.ValueChanged
        Dim AGE As Integer
        AGE = Today.Year - Year(date_dob.Value)
        lbl_age.Text = AGE

        If AGE >= 0 And AGE < 12 Then
            lbl_agegroup.Text = "Kids"
        ElseIf AGE >= 12 And AGE < 18 Then
            lbl_agegroup.Text = "Teens"
        ElseIf AGE >= 18 And AGE < 60 Then
            lbl_agegroup.Text = "Adults"
        ElseIf AGE >= 60 Then
            lbl_agegroup.Text = "Senior"
        Else
            lbl_agegroup.Text = "None"
        End If
    End Sub

    Public Sub GETRESIDENTINFO()

        Dim SQL As String = "SELECT * FROM [RESIDENTS] WHERE RESIDENTID = @RESIDENTID"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    CMD.Parameters.AddWithValue("@RESIDENTID", SqlDbType.NVarChar).Value = tb_residentid.Text
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)
                        If DT.Rows.Count = 1 Then

                            Dim AGE As Integer
                            Dim YEARDOB As Date = DateTime.Parse(DT.Rows(0).Item(5))
                            AGE = Today.Year - Year(YEARDOB)
                            lbl_age.Text = AGE

                            If AGE >= 0 And AGE < 12 Then
                                lbl_agegroup.Text = "Kids"
                            ElseIf AGE >= 12 And AGE < 18 Then
                                lbl_agegroup.Text = "Teens"
                            ElseIf AGE >= 18 And AGE < 60 Then
                                lbl_agegroup.Text = "Adults"
                            ElseIf AGE >= 60 Then
                                lbl_agegroup.Text = "Senior"
                            Else
                                lbl_agegroup.Text = "None"
                            End If

                            tb_fname.Text = DT.Rows(0).Item(1)
                            tb_lname.Text = DT.Rows(0).Item(3)
                            tb_mname.Text = DT.Rows(0).Item(2)
                            lbl_residentid.Text = DT.Rows(0).Item(0)
                            cb_genderx.SelectedItem = DT.Rows(0).Item(4)
                            date_dob.Value = DT.Rows(0).Item(5)
                            tb_pob.Text = DT.Rows(0).Item(6)
                            cb_status.SelectedItem = DT.Rows(0).Item(7)
                            cb_religion.SelectedItem = DT.Rows(0).Item(8)
                            cb_voter.SelectedItem = DT.Rows(0).Item(9)
                            tb_address.Text = DT.Rows(0).Item(10)
                            tb_contact.Text = DT.Rows(0).Item(11)

                            Dim BA As Byte() = DT.Rows(0).Item(13)
                            Dim IMG As Image

                            Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream(BA)
                            IMG = System.Drawing.Image.FromStream(MS)


                            pb_captured.Image = IMG

                            Dim BB As Byte() = DT.Rows(0).Item(14)
                            Dim IMX As Image
                            Dim MX As System.IO.MemoryStream = New System.IO.MemoryStream(BB)
                            IMX = System.Drawing.Image.FromStream(MX)

                            pb_qrcode.Image = IMX
                            btn_addres.Enabled = False
                            btn_editres.Enabled = True
                            btn_deleteres.Enabled = True
                        Else
                            MsgBox("No records found!")
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub DELETERESIDENT()
        Dim RESIDENTID As String = tb_residentid.Text

        Dim SQL As String = "DELETE FROM [RESIDENTS] WHERE RESIDENTID = @RESIDENTID"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As New SqlCommand(SQL, CON)
                CMD.Parameters.AddWithValue("@RESIDENTID", RESIDENTID)

                CON.Open()
                CMD.ExecuteNonQuery()
                CON.Close()
                CLEARFIELDS()
                MessageBox.Show("Deleted Successfully!")
            End Using
        End Using
    End Sub

    Public Sub CLEARFIELDS()
        tb_fname.Text = ""
        tb_lname.Text = ""
        tb_mname.Text = ""
        lbl_residentid.Text = ""
        cb_genderx.SelectedItem = ""
        tb_pob.Text = ""
        cb_status.SelectedItem = ""
        cb_religion.SelectedItem = ""
        cb_voter.SelectedItem = ""
        tb_address.Text = ""
        tb_contact.Text = ""
        btn_addres.Enabled = True
        btn_editres.Enabled = False
        btn_deleteres.Enabled = False
    End Sub

    Private Sub btn_searchres_Click(sender As Object, e As EventArgs) Handles btn_searchres.Click
        GETRESIDENTINFO()

    End Sub

    Private Sub btn_editres_Click(sender As Object, e As EventArgs) Handles btn_editres.Click
        UPDATERESIDENT()

    End Sub

    Private Sub btn_deleteres_Click(sender As Object, e As EventArgs) Handles btn_deleteres.Click
        DELETERESIDENT()
    End Sub



    'RESIDENTID
    'FNAME
    'MNAME
    'LNAME
    'GENDER
    'DOB
    'CIVILSTATUS
    '//AGE
    'ADDRESS
    'CONTACTNO
    'RESIDENTIMAGE
    'RESIDENTQRCODE
End Class