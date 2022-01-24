Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class residentlistpanel
    Dim QR As New qrscanner
    Dim CONSTRING As String = "Data Source=DESKTOP-9S3FKV6\SQLEXPRESS;Initial Catalog=datudb;Integrated Security=True"
    Private Sub residentlistpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_brgyresidents.RESIDENTS' table. You can move, or remove it, as needed.
        Me.RESIDENTSTableAdapter.Fill(Me.Ds_brgyresidents.RESIDENTS)
        btn_coi.Enabled = False
        btn_brygid.Enabled = False
        btn_brgypermit.Enabled = False
        btn_brgyclear.Enabled = False
    End Sub

    Private Sub btn_showqr_Click(sender As Object, e As EventArgs) Handles btn_showqr.Click
        qrscanner.Show()
    End Sub

    Public Sub GETRESIDENTINFO(DGV As DataGridView)

        Dim SQL As String = "SELECT * FROM [RESIDENTS] WHERE RESIDENTID = @RESIDENTID"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    CMD.Parameters.AddWithValue("@RESIDENTID", SqlDbType.NVarChar).Value = tb_searchresident.Text
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)
                        DGV.DataSource = DT
                        If DT.Rows.Count = 1 Then

                            Dim AGE As Integer
                            Dim YEARDOB As Date = DateTime.Parse(DT.Rows(0).Item(5))
                            AGE = Today.Year - Year(YEARDOB)
                            lbl_ageres.Text = AGE

                            If AGE >= 0 And AGE < 12 Then
                                lbl_agegrpres.Text = "Kids"
                            ElseIf AGE >= 12 And AGE < 18 Then
                                lbl_agegrpres.Text = "Teens"
                            ElseIf AGE >= 18 And AGE < 60 Then
                                lbl_agegrpres.Text = "Adults"
                            ElseIf AGE >= 60 Then
                                lbl_agegrpres.Text = "Senior"
                            Else
                                lbl_agegrpres.Text = "None"
                            End If

                            lbl_nameres.Text = DT.Rows(0).Item(3) & ", " & DT.Rows(0).Item(1) & " " & DT.Rows(0).Item(2)
                            lbl_idres.Text = DT.Rows(0).Item(0)
                            lbl_genderres.Text = DT.Rows(0).Item(4)
                            lbl_dobres.Text = DT.Rows(0).Item(5)
                            lbl_pobres.Text = DT.Rows(0).Item(6)
                            lbl_statusres.Text = DT.Rows(0).Item(7)
                            lbl_religionres.Text = DT.Rows(0).Item(8)
                            lbl_voterres.Text = DT.Rows(0).Item(9)
                            lbl_addressres.Text = DT.Rows(0).Item(10)
                            lbl_contactres.Text = DT.Rows(0).Item(11)

                            Dim BA As Byte() = DT.Rows(0).Item(13)
                            Dim IMG As Image

                            Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream(BA)
                            IMG = System.Drawing.Image.FromStream(MS)


                            pb_imgres.Image = IMG

                            Dim BB As Byte() = DT.Rows(0).Item(14)
                            Dim IMX As Image
                            Dim MX As System.IO.MemoryStream = New System.IO.MemoryStream(BB)
                            IMX = System.Drawing.Image.FromStream(MX)

                            pb_qrres.Image = IMX

                            btn_brgyclear.Enabled = True
                            btn_brgypermit.Enabled = True
                            btn_brygid.Enabled = True
                            btn_coi.Enabled = True
                        Else
                            MsgBox("No records found!")
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub BINDDATA(DGV As DataGridView, TBL As String)
        Dim SQL As String = "SELECT * FROM" & TBL
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)
                        DGV.DataSource = DT
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub btn_searchres_Click(sender As Object, e As EventArgs) Handles btn_searchres.Click
        GETRESIDENTINFO(dgv_brgyinfo)
    End Sub

    Function LOG() As Image
        Dim SQL As String = "SELECT * FROM [Table] WHERE BARANGAYID = 1"
        Dim LOGO As Image
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)
                        If DT.Rows.Count = 1 Then
                            LOGO = Image.FromFile(DT.Rows(0).Item(5))

                            Return LOGO
                        Else
                            LOGO = datuinfosys.My.Resources.Resources.lgo
                            Return LOGO
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Function
    Function BRGYNAME() As Object
        Dim SQL As String = "SELECT * FROM [Table] WHERE BARANGAYID = 1"
        Dim BNAME As String
        Dim CITY As String
        Dim PROVINCE As String
        Dim ZIPCODE As String

        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)
                        If DT.Rows.Count = 1 Then
                            BNAME = DT.Rows(0).Item(1).ToString
                            CITY = DT.Rows(0).Item(2).ToString
                            PROVINCE = DT.Rows(0).Item(3).ToString
                            ZIPCODE = DT.Rows(0).Item(4).ToString

                            Return {BNAME, CITY, PROVINCE, ZIPCODE}
                        Else
                            BNAME = ""
                            Return BNAME
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Function


    Function RESINFO() As Object
        Dim SQL As String = "SELECT * FROM [RESIDENTS] WHERE RESIDENTID = @RESIDENTID"

        Dim FNAME As String
        Dim MNAME As String
        Dim LNAME As String
        Dim ID As String
        Dim GENDER As String
        Dim DOB As String
        Dim POB As String
        Dim ADDRESS As String
        Dim PROIMG As Image
        Dim QR As Image

        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    CMD.Parameters.AddWithValue("@RESIDENTID", SqlDbType.NVarChar).Value = tb_searchresident.Text
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)
                        dgv_brgyinfo.DataSource = DT
                        If DT.Rows.Count = 1 Then


                            FNAME = DT.Rows(0).Item(1)
                            MNAME = DT.Rows(0).Item(2)
                            LNAME = DT.Rows(0).Item(3)
                            ID = DT.Rows(0).Item(0)
                            GENDER = DT.Rows(0).Item(4)
                            DOB = DT.Rows(0).Item(5).ToString
                            POB = DT.Rows(0).Item(6)
                            ADDRESS = DT.Rows(0).Item(10)

                            Dim BA As Byte() = DT.Rows(0).Item(13)
                            Dim IMG As Image
                            Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream(BA)
                            IMG = System.Drawing.Image.FromStream(MS)


                            PROIMG = IMG

                            Dim BB As Byte() = DT.Rows(0).Item(14)
                            Dim IMX As Image
                            Dim MX As System.IO.MemoryStream = New System.IO.MemoryStream(BB)
                            IMX = System.Drawing.Image.FromStream(MX)

                            QR = IMX

                            Return {LNAME, FNAME, MNAME, ID, GENDER, DOB, POB, ADDRESS, PROIMG, QR}

                        Else
                            MsgBox("No records found!")
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Function

    Function BRGYCAP() As Object
        Dim SQL As String = "SELECT * FROM [Table1] WHERE POSITION LIKE '%captain%'"

        Dim FNAME As String
        Dim LNAME As String
        Dim POSITION As String
        Dim SIGN As String

        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)
                        dgv_brgyinfo.DataSource = DT
                        If DT.Rows.Count > 0 Then


                            FNAME = DT.Rows(0).Item(2)
                            LNAME = DT.Rows(0).Item(1)
                            POSITION = DT.Rows(0).Item(3)
                            SIGN = DT.Rows(0).Item(4)


                            Return {FNAME, LNAME, POSITION, SIGN}

                        Else
                            MsgBox("No records found!")
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Function

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim BRGY As Object = BRGYNAME()
        Dim RESIDENT As Object = RESINFO()
        Dim TITLE As Font = New Font("Montserrat", 7, FontStyle.Bold)
        Dim SUBTITLE1 As Font = New Font("Open Sans", 5, FontStyle.Bold)
        Dim SUBTITLE2 As Font = New Font("Open Sans", 3, FontStyle.Bold)
        Dim DT As Date = Date.Parse(RESIDENT(5).ToString)
        Dim DOB = DT.ToShortDateString()
        Dim WRAP As RectangleF = New RectangleF(220, 140, 100, 50)
        Dim BG As Image = My.Resources.IDBG
        Dim EXPIRY As Date = Today.AddDays(180)
        Dim CAPTAIN As Object = BRGYCAP()
        Dim SIGN As Image = Image.FromFile(BRGYCAP(3).ToString)
        Dim FORMAL As Font = New Font("Arial", 3)


        Dim SF As New StringFormat
        SF.LineAlignment = StringAlignment.Center
        SF.Alignment = StringAlignment.Center

        e.Graphics.DrawImage(BG, 0, 0, 318, 197)
        e.Graphics.DrawImage(LOG, 50, 5, 25, 25)
        e.Graphics.DrawString("REPUBLIC OF THE PHILIPPINES".ToString, TITLE, Brushes.Black, 159, 10, SF)
        e.Graphics.DrawString("BARANGAY " & BRGY(0).ToString.ToUpper, SUBTITLE1, Brushes.Black, 159, 20, SF)
        e.Graphics.DrawString(BRGY(1).ToString.ToUpper & ", " & BRGY(2).ToString.ToUpper & ", " & BRGY(3).ToString.ToUpper, SUBTITLE2, Brushes.Black, 159, 27, SF)

        e.Graphics.FillRectangle(Brushes.White, 0, 40, 318, 30)
        e.Graphics.DrawString("BARANGAY IDENTIFICATION CARD".ToString, TITLE, Brushes.Black, 159, 55, SF)

        e.Graphics.DrawImage(RESIDENT(8), 5, 80, 100, 100)
        e.Graphics.DrawImage(RESIDENT(9), 105, 80, 30, 30)
        e.Graphics.DrawString(RESIDENT(3).ToString, SUBTITLE2, Brushes.Black, 105, 110)

        e.Graphics.DrawImage(SIGN, 105, 150, 20, 20)
        e.Graphics.DrawString(CAPTAIN(0).ToString.ToUpper & " " & CAPTAIN(1).ToString.ToUpper, FORMAL, Brushes.Black, 105, 165)
        e.Graphics.DrawString(CAPTAIN(2).ToString.ToUpper, FORMAL, Brushes.Black, 105, 170)

        e.Graphics.DrawString("EXPIRY DATE: " & EXPIRY, SUBTITLE2, Brushes.Black, 5, 190)


        e.Graphics.DrawString("LAST NAME: ", SUBTITLE1, Brushes.Black, 159, 80)
        e.Graphics.DrawString(RESIDENT(0).ToString.ToUpper, SUBTITLE1, Brushes.Black, 220, 80)
        e.Graphics.DrawString("FIRST NAME: ", SUBTITLE1, Brushes.Black, 159, 90)
        e.Graphics.DrawString(RESIDENT(1).ToString.ToUpper, SUBTITLE1, Brushes.Black, 220, 90)
        e.Graphics.DrawString("MIDDLE NAME: ", SUBTITLE1, Brushes.Black, 159, 100)
        e.Graphics.DrawString(RESIDENT(2).ToString.ToUpper, SUBTITLE1, Brushes.Black, 220, 100)
        e.Graphics.DrawString("GENDER: ", SUBTITLE1, Brushes.Black, 159, 110)
        e.Graphics.DrawString(RESIDENT(4).ToString.ToUpper, SUBTITLE1, Brushes.Black, 220, 110)
        e.Graphics.DrawString("DOB: ", SUBTITLE1, Brushes.Black, 159, 120)
        e.Graphics.DrawString(DOB.ToUpper, SUBTITLE1, Brushes.Black, 220, 120)
        e.Graphics.DrawString("POB: ", SUBTITLE1, Brushes.Black, 159, 130)
        e.Graphics.DrawString(RESIDENT(6).ToString.ToUpper, SUBTITLE1, Brushes.Black, 220, 130)
        e.Graphics.DrawString("ADDRESS: ", SUBTITLE1, Brushes.Black, 159, 140)
        e.Graphics.DrawString(RESIDENT(7).ToString.ToUpper, SUBTITLE1, Brushes.Black, WRAP)


    End Sub
    Private Sub PrintDocument2_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim BRGY As Object = BRGYNAME()
        Dim RESIDENT As Object = RESINFO()
        Dim CAPTAIN As Object = BRGYCAP()
        Dim TITLE As Font = New Font("Montserrat", 20, FontStyle.Bold)
        Dim SUBTITLE1 As Font = New Font("Open Sans", 17, FontStyle.Bold)
        Dim SUBTITLE2 As Font = New Font("Open Sans", 13, FontStyle.Bold)
        Dim WRAP As RectangleF = New RectangleF(100, 250, 700, 1000)
        Dim DT As Date = Date.Parse(RESIDENT(5).ToString)
        Dim DOB = DT.ToLongDateString
        Dim FORMAL As Font = New Font("Arial", 12)
        Dim SIGN As Image = Image.FromFile(BRGYCAP(3).ToString)


        Dim SF As New StringFormat
        SF.LineAlignment = StringAlignment.Center
        SF.Alignment = StringAlignment.Center

        e.Graphics.DrawImage(LOG, 100, 20, 75, 75)
        e.Graphics.DrawString("REPUBLIC OF THE PHILIPPINES".ToString, TITLE, Brushes.Black, 408, 50, SF)
        e.Graphics.DrawString("BARANGAY " & BRGY(0).ToString.ToUpper, SUBTITLE1, Brushes.Black, 408, 70, SF)
        e.Graphics.DrawString(BRGY(1).ToString.ToUpper & ", " & BRGY(2).ToString.ToUpper & ", " & BRGY(3).ToString.ToUpper, SUBTITLE2, Brushes.Black, 408, 90, SF)

        e.Graphics.DrawString("BARANGAY CLEARANCE".ToString, TITLE, Brushes.Black, 408, 160, SF)

        e.Graphics.DrawString("To: ___________________" & vbNewLine & vbNewLine & vbTab & "This is to certify that " & RESIDENT(1).ToString.ToUpper & " " & RESIDENT(2).ToString.ToUpper & " " & RESIDENT(0).ToString.ToUpper & " who was born on " &
                              DOB.ToUpper & " in " & RESIDENT(6).ToString.ToUpper & " is a resident of " & RESIDENT(7).ToString.ToUpper & vbNewLine & vbNewLine & vbTab & "The above-mentioned name is known to have a Good Moral Character and a Law Abiding" &
                              " Citizen with No Derogatory Record in this barangay." & vbNewLine & vbNewLine & "Purpose: _________________" & vbNewLine & vbNewLine & vbTab & "Issued this " & Today.ToLongDateString & " at the BARANGAY " &
                              BRGY(0).ToString.ToUpper & ", " & BRGY(1).ToString.ToUpper & ", " & BRGY(2).ToString.ToUpper,
                              FORMAL, Brushes.Black, WRAP)

        e.Graphics.DrawRectangle(Pens.Black, 600, 800, 100, 100)

        e.Graphics.DrawImage(SIGN, 100, 700, 100, 100)
        e.Graphics.DrawLine(Pens.Black, 100, 800, 300, 800)
        e.Graphics.DrawString(CAPTAIN(0).ToString.ToUpper & " " & CAPTAIN(1).ToString.ToUpper, FORMAL, Brushes.Black, 120, 800)
        e.Graphics.DrawString(CAPTAIN(2).ToString.ToUpper, FORMAL, Brushes.Black, 120, 820)

        e.Graphics.DrawRectangle(Pens.Black, e.PageBounds)
    End Sub

    Private Sub PrintDocument3_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument3.PrintPage
        Dim BRGY As Object = BRGYNAME()
        Dim RESIDENT As Object = RESINFO()
        Dim CAPTAIN As Object = BRGYCAP()
        Dim TITLE As Font = New Font("Montserrat", 20, FontStyle.Bold)
        Dim SUBTITLE1 As Font = New Font("Open Sans", 17, FontStyle.Bold)
        Dim SUBTITLE2 As Font = New Font("Open Sans", 13, FontStyle.Bold)
        Dim WRAP As RectangleF = New RectangleF(100, 250, 700, 1000)
        Dim DT As Date = Date.Parse(RESIDENT(5).ToString)
        Dim DOB = DT.ToLongDateString
        Dim FORMAL As Font = New Font("Arial", 12)
        Dim SIGN As Image = Image.FromFile(BRGYCAP(3).ToString)


        Dim SF As New StringFormat
        SF.LineAlignment = StringAlignment.Center
        SF.Alignment = StringAlignment.Center

        e.Graphics.DrawImage(LOG, 100, 20, 75, 75)
        e.Graphics.DrawString("REPUBLIC OF THE PHILIPPINES".ToString, TITLE, Brushes.Black, 408, 50, SF)
        e.Graphics.DrawString("BARANGAY " & BRGY(0).ToString.ToUpper, SUBTITLE1, Brushes.Black, 408, 70, SF)
        e.Graphics.DrawString(BRGY(1).ToString.ToUpper & ", " & BRGY(2).ToString.ToUpper & ", " & BRGY(3).ToString.ToUpper, SUBTITLE2, Brushes.Black, 408, 90, SF)

        e.Graphics.DrawString("CERTIFICATE OF INDIGENCY".ToString, TITLE, Brushes.Black, 408, 160, SF)

        e.Graphics.DrawString("To: ___________________" & vbNewLine & vbNewLine & vbTab & "This is to certify that " & RESIDENT(1).ToString.ToUpper & " " & RESIDENT(2).ToString.ToUpper & " " & RESIDENT(0).ToString.ToUpper & ", a resident of this " &
                             "Barangay is one of the indigents in our barangay." & vbNewLine & vbNewLine & vbTab & "This certification is being issued upon the request of the above-named person for whatever legal purpose it may server his best." &
                               vbNewLine & vbNewLine & vbTab & "Issued this " & Today.ToLongDateString & " at the BARANGAY " &
                              BRGY(0).ToString.ToUpper & ", " & BRGY(1).ToString.ToUpper & ", " & BRGY(2).ToString.ToUpper,
                              FORMAL, Brushes.Black, WRAP)


        e.Graphics.DrawImage(SIGN, 100, 700, 100, 100)
        e.Graphics.DrawLine(Pens.Black, 100, 800, 300, 800)
        e.Graphics.DrawString(CAPTAIN(0).ToString.ToUpper & " " & CAPTAIN(1).ToString.ToUpper, FORMAL, Brushes.Black, 120, 800)
        e.Graphics.DrawString(CAPTAIN(2).ToString.ToUpper, FORMAL, Brushes.Black, 120, 820)

        e.Graphics.DrawRectangle(Pens.Black, e.PageBounds)
    End Sub

    Private Sub PrintDocument4_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument4.PrintPage
        Dim BUSINESS As String = Microsoft.VisualBasic.Interaction.InputBox("Enter business name", "Business name")
        Dim NATURE As String = Microsoft.VisualBasic.Interaction.InputBox("Enter nature of business", "Nature of Business")
        Dim BUSINESSADD As String = Microsoft.VisualBasic.Interaction.InputBox("Enter business address", "Business address")


        Dim BRGY As Object = BRGYNAME()
        Dim RESIDENT As Object = RESINFO()
        Dim CAPTAIN As Object = BRGYCAP()
        Dim TITLE As Font = New Font("Montserrat", 20, FontStyle.Bold)
        Dim SUBTITLE1 As Font = New Font("Open Sans", 17, FontStyle.Bold)
        Dim SUBTITLE2 As Font = New Font("Open Sans", 13, FontStyle.Bold)
        Dim WRAP As RectangleF = New RectangleF(100, 250, 700, 1000)
        Dim DT As Date = Date.Parse(RESIDENT(5).ToString)
        Dim DOB = DT.ToLongDateString
        Dim FORMAL As Font = New Font("Arial", 12)
        Dim SIGN As Image = Image.FromFile(BRGYCAP(3).ToString)


        Dim SF As New StringFormat
        SF.LineAlignment = StringAlignment.Center
        SF.Alignment = StringAlignment.Center

        e.Graphics.DrawImage(LOG, 100, 20, 75, 75)
        e.Graphics.DrawString("REPUBLIC OF THE PHILIPPINES".ToString, TITLE, Brushes.Black, 408, 50, SF)
        e.Graphics.DrawString("BARANGAY " & BRGY(0).ToString.ToUpper, SUBTITLE1, Brushes.Black, 408, 70, SF)
        e.Graphics.DrawString(BRGY(1).ToString.ToUpper & ", " & BRGY(2).ToString.ToUpper & ", " & BRGY(3).ToString.ToUpper, SUBTITLE2, Brushes.Black, 408, 90, SF)

        e.Graphics.DrawString("BARANGAY BUSINESS PERMIT".ToString, TITLE, Brushes.Black, 408, 160, SF)

        e.Graphics.DrawString("To: ___________________" & vbNewLine & vbNewLine & "This is to certify that: " & vbNewLine & vbNewLine &
            "NAME OF BUSINESS: " & BUSINESS.ToString.ToUpper & vbNewLine &
                             "NAME OF APPLICANT: " & RESIDENT(1).ToString.ToUpper & " " & RESIDENT(2).ToString.ToUpper & " " & RESIDENT(0).ToString.ToUpper & vbNewLine &
                             "TYPE OF BUSINESS: " & NATURE.ToString.ToUpper & vbNewLine &
                             "ADDRESS: " & BUSINESSADD.ToString.ToUpper & vbNewLine & vbNewLine &
                             vbNewLine & vbTab & "Which is an operating business at BARANGAY " &
                              BRGY(0).ToString.ToUpper & ", " & BRGY(1).ToString.ToUpper & ", " & BRGY(2).ToString.ToUpper &
                              " has undergone identification process and its operating conforms with the existing laws, rules, and regulation of this barangay." &
                              vbNewLine & vbNewLine & vbTab &
                              "This permit is issued under requirements of the Local Government Code (R.A.) 7160. Article 4, Section 152, Paragraph C, and upon request of the above-named for the purposes of applying for the Mayor's Permit License for the year " &
                              Today.Year, FORMAL, Brushes.Black, WRAP)


        e.Graphics.DrawImage(SIGN, 100, 700, 100, 100)
        e.Graphics.DrawLine(Pens.Black, 100, 800, 300, 800)
        e.Graphics.DrawString(CAPTAIN(0).ToString.ToUpper & " " & CAPTAIN(1).ToString.ToUpper, FORMAL, Brushes.Black, 120, 800)
        e.Graphics.DrawString(CAPTAIN(2).ToString.ToUpper, FORMAL, Brushes.Black, 120, 820)

        e.Graphics.DrawRectangle(Pens.Black, e.PageBounds)
    End Sub

    Private Sub btn_brygid_Click(sender As Object, e As EventArgs) Handles btn_brygid.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintDocument1.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("ID Size", 318, 197)
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btn_brgyclear_Click(sender As Object, e As EventArgs) Handles btn_brgyclear.Click
        PrintPreviewDialog2.Document = PrintDocument2
        PrintDocument1.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("Legal Size", 816, 1247)
        PrintPreviewDialog2.ShowDialog()
    End Sub

    Private Sub btn_coi_Click(sender As Object, e As EventArgs) Handles btn_coi.Click
        PrintPreviewDialog3.Document = PrintDocument3
        PrintDocument1.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("Legal Size", 816, 1247)
        PrintPreviewDialog3.ShowDialog()
    End Sub


    Private Sub btn_brgypermit_Click(sender As Object, e As EventArgs) Handles btn_brgypermit.Click
        PrintPreviewDialog4.Document = PrintDocument4
        PrintDocument4.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("Legal Size", 816, 1247)
        PrintPreviewDialog4.ShowDialog()
    End Sub
End Class