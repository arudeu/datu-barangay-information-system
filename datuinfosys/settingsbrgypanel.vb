Imports System.Data.SqlClient
Public Class settingsbrgypanel
    Dim CONSTRING As String = "Data Source=DESKTOP-9S3FKV6\SQLEXPRESS;Initial Catalog=datudb;Integrated Security=True"
    Dim opf As New OpenFileDialog
    Private Sub btn_addbrgy_Click(sender As Object, e As EventArgs) Handles btn_addbrgy.Click
        Dim BARANGAY As String = tb_brgyname.Text
        Dim CITY As String = tb_city.Text
        Dim PROVINCE As String = tb_province.Text
        Dim ZIPCODE As String = tb_zipcode.Text
        Dim LOGO As String = tb_logolocation.Text



        Dim SQL As String = "INSERT INTO [Table] VALUES (@BARANGAY,@CITY,@PROVINCE,@ZIPCODE,@LOGO)"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As New SqlCommand(SQL, CON)
                CMD.Parameters.AddWithValue("@BARANGAY", BARANGAY)
                CMD.Parameters.AddWithValue("@CITY", CITY)
                CMD.Parameters.AddWithValue("@PROVINCE", PROVINCE)
                CMD.Parameters.AddWithValue("@ZIPCODE", ZIPCODE)
                CMD.Parameters.AddWithValue("@LOGO", LOGO)

                CON.Open()
                CMD.ExecuteNonQuery()
                CON.Close()
                tb_brgyname.Text = ""
                tb_city.Text = ""
                tb_province.Text = ""
                tb_city.Text = ""
                tb_zipcode.Text = ""
                MessageBox.Show("Changes Saved!")
                btn_addbrgy.Enabled = False
                BINDDATA(dgv_brgyinfo, "[Table]")
            End Using
        End Using
    End Sub

    Private Sub btn_editbrgy_Click(sender As Object, e As EventArgs) Handles btn_editbrgy.Click
        If tb_brgyname.Text = "" Or tb_city.Text = "" Or tb_province.Text = "" Or tb_zipcode.Text = "" Or tb_logolocation.Text = "" Then

            MessageBox.Show("Enter Required Fields!")
        Else
            Dim BARANGAY As String = tb_brgyname.Text
            Dim CITY As String = tb_city.Text
            Dim PROVINCE As String = tb_province.Text
            Dim ZIPCODE As String = tb_zipcode.Text
            Dim LOGO As String = tb_logolocation.Text
            Dim BARANGAYID As Integer = 1
            Dim SQL As String = "UPDATE [Table] SET BARANGAY = @BARANGAY, CITY = @CITY, PROVINCE = @PROVINCE, ZIPCODE = @ZIPCODE, LOGO = @LOGO WHERE BARANGAYID=@BARANGAYID"
            Using CON As SqlConnection = New SqlConnection(CONSTRING)
                Using CMD As New SqlCommand(SQL, CON)
                    CMD.Parameters.AddWithValue("@BARANGAY", BARANGAY)
                    CMD.Parameters.AddWithValue("@CITY", CITY)
                    CMD.Parameters.AddWithValue("@PROVINCE", PROVINCE)
                    CMD.Parameters.AddWithValue("@ZIPCODE", ZIPCODE)
                    CMD.Parameters.AddWithValue("@LOGO", LOGO)
                    CMD.Parameters.AddWithValue("@BARANGAYID", BARANGAYID)

                    CON.Open()
                    CMD.ExecuteNonQuery()
                    CON.Close()
                    MessageBox.Show("Changes Saved!")
                    btn_addbrgy.Enabled = False
                    BINDDATA(dgv_brgyinfo, "[Table]")
                End Using
            End Using
        End If

    End Sub
    Private Sub btn_attachbrgylogo_Click(sender As Object, e As EventArgs) Handles btn_attachbrgylogo.Click
        ATTACH(pb_brgylogo, tb_logolocation)
    End Sub

    Private Sub btn_addbo_Click(sender As Object, e As EventArgs) Handles btn_addbo.Click
        Dim LNAME As String = tb_lnamebo.Text
        Dim FNAME As String = tb_fnamebo.Text
        Dim POSITION As String = cb_positionbo.Text
        Dim IMGLOCATION As String = tb_imglocation.Text


        If tb_lnamebo.Text = "" Or tb_fnamebo.Text = "" Or cb_positionbo.Text = "" Or tb_imglocation.Text = "" Then

            MessageBox.Show("Enter Required Fields!")
        Else
            Dim SQL As String = "INSERT INTO [Table1] VALUES (@LNAME,@FNAME,@POSITION,@IMGLOCATION)"
            Using CON As SqlConnection = New SqlConnection(CONSTRING)
                Using CMD As New SqlCommand(SQL, CON)
                    CMD.Parameters.AddWithValue("@LNAME", LNAME)
                    CMD.Parameters.AddWithValue("@FNAME", FNAME)
                    CMD.Parameters.AddWithValue("@POSITION", POSITION)
                    CMD.Parameters.AddWithValue("@IMGLOCATION", IMGLOCATION)

                    CON.Open()
                    CMD.ExecuteNonQuery()
                    CON.Close()
                    tb_lnamebo.Text = ""
                    tb_fnamebo.Text = ""
                    cb_positionbo.Text = ""
                    tb_imglocation.Text = ""
                    MessageBox.Show("Changes Saved!")
                    BINDDATA(dgv_brgyofficials, "[Table1]")
                End Using
            End Using
        End If


    End Sub

    Private Sub btn_editbo_Click(sender As Object, e As EventArgs) Handles btn_editbo.Click
        If tb_lnamebo.Text = "" Or tb_fnamebo.Text = "" Or cb_positionbo.Text = "" Or tb_imglocation.Text = "" Then

            MessageBox.Show("Enter Required Fields!")
        Else
            Dim LNAME As String = tb_lnamebo.Text
            Dim FNAME As String = tb_fnamebo.Text
            Dim POSITION As String = cb_positionbo.Text
            Dim IMGLOCATION As String = tb_imglocation.Text
            Dim OFFICIALID As Integer = dgv_brgyofficials.SelectedRows(0).Cells(0).Value
            Dim SQL As String = "UPDATE [Table1] SET LNAME = @LNAME, FNAME = @FNAME, POSITION = @POSITION, IMGLOCATION = @IMGLOCATION WHERE OFFICIALID = @OFFICIALID"
            Using CON As SqlConnection = New SqlConnection(CONSTRING)
                Using CMD As New SqlCommand(SQL, CON)
                    CMD.Parameters.AddWithValue("@LNAME", LNAME)
                    CMD.Parameters.AddWithValue("@FNAME", FNAME)
                    CMD.Parameters.AddWithValue("@POSITION", POSITION)
                    CMD.Parameters.AddWithValue("@IMGLOCATION", IMGLOCATION)
                    CMD.Parameters.AddWithValue("@OFFICIALID", OFFICIALID)

                    CON.Open()
                    CMD.ExecuteNonQuery()
                    CON.Close()
                    MessageBox.Show("Changes Saved!")
                    BINDDATA(dgv_brgyofficials, "[Table1]")
                End Using
            End Using
        End If
    End Sub

    Private Sub btn_attachimglogobo_Click(sender As Object, e As EventArgs) Handles btn_attachimglogobo.Click
        ATTACH(pb_imglogo, tb_imglocation)
    End Sub

    Private Sub btn_deletebo_Click(sender As Object, e As EventArgs) Handles btn_deletebo.Click
        DELETEROW(dgv_brgyofficials, "[Table1]", "OFFICIALID")
    End Sub
    Private Sub btn_addbp_Click(sender As Object, e As EventArgs) Handles btn_addbp.Click
        Dim POSITION As String = tb_positionbp.Text
        If tb_positionbp.Text = "" Then
            MessageBox.Show("Enter Required Fields!")
        Else
            Dim SQL As String = "INSERT INTO [Table2] VALUES (@POSITION)"
            Using CON As SqlConnection = New SqlConnection(CONSTRING)
                Using CMD As New SqlCommand(SQL, CON)
                    CMD.Parameters.AddWithValue("@POSITION", POSITION)

                    CON.Open()
                    CMD.ExecuteNonQuery()
                    CON.Close()
                    tb_positionbp.Text = ""
                    MessageBox.Show("Changes Saved!")
                    BINDDATA(dgv_positions, "[Table2]")
                    GETPOSITIONS()
                End Using
            End Using
        End If
    End Sub
    Private Sub btn_editbp_Click(sender As Object, e As EventArgs) Handles btn_editbp.Click
        If tb_positionbp.Text = "" Then

            MessageBox.Show("Enter Required Fields!")
        Else
            Dim POSITION As String = tb_positionbp.Text
            Dim POSITIONID As Integer = dgv_positions.SelectedRows(0).Cells(0).Value
            Dim SQL As String = "UPDATE [Table2] SET POSITION = @POSITION WHERE POSITIONID = @POSITIONID"
            Using CON As SqlConnection = New SqlConnection(CONSTRING)
                Using CMD As New SqlCommand(SQL, CON)
                    CMD.Parameters.AddWithValue("@POSITION", POSITION)
                    CMD.Parameters.AddWithValue("@POSITIONID", POSITIONID)

                    CON.Open()
                    CMD.ExecuteNonQuery()
                    CON.Close()
                    MessageBox.Show("Changes Saved!")
                    BINDDATA(dgv_positions, "[Table2]")
                End Using
            End Using
        End If
    End Sub
    Private Sub btn_deletebp_Click(sender As Object, e As EventArgs) Handles btn_deletebp.Click
        DELETEROW(dgv_positions, "[Table2]", "POSITIONID")
    End Sub

    'PUBLIC SUBS

    Public Sub DELETEROW(DGV As DataGridView, TBL As String, ID As String)
        Dim IDS As Integer = DGV.SelectedRows(0).Cells(ID).Value

        Dim SQL As String = "DELETE FROM " & TBL & " WHERE " & ID & " = " & IDS.ToString
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As New SqlCommand(SQL, CON)

                CON.Open()
                CMD.ExecuteNonQuery()
                CON.Close()
                MessageBox.Show("Changes Saved!")
                BINDDATA(DGV, TBL)
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

    Public Sub GETROWS()
        Dim SQL As String = "SELECT * FROM [Table]"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)
                        If DT.Rows.Count = 1 Then
                            pb_brgylogo.ImageLocation = tb_logolocation.Text
                            btn_addbrgy.Enabled = False
                            btn_editbrgy.Enabled = True
                            tb_brgyname.Text = DT.Rows(0).Item(1)
                            tb_city.Text = DT.Rows(0).Item(2)
                            tb_province.Text = DT.Rows(0).Item(3)
                            tb_zipcode.Text = DT.Rows(0).Item(4)
                            tb_logolocation.Text = DT.Rows(0).Item(5)
                        Else
                            pb_brgylogo.ImageLocation = ""
                            tb_brgyname.Text = ""
                            tb_city.Text = ""
                            tb_province.Text = ""
                            tb_zipcode.Text = ""
                            tb_logolocation.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub ATTACH(PB As PictureBox, TB As TextBox)
        opf.Filter = "Choose logo(*.PNG)|*.png"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PB.ImageLocation = opf.FileName
            TB.Text = opf.FileName
        End If
    End Sub
    Public Sub GETPOSITIONS()
        cb_positionbo.DataSource = dgv_positions.DataSource
        cb_positionbo.DisplayMember = "POSITION"
        cb_positionbo.ValueMember = "POSITIONID"
    End Sub

    Private Sub settingsbrgypanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_brgypositions.Table2' table. You can move, or remove it, as needed.
        Me.Table2TableAdapter.Fill(Me.Ds_brgypositions.Table2)
        'TODO: This line of code loads data into the 'Ds_brgyofficials.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Ds_brgyofficials.Table1)


        btn_addbrgy.Enabled = True
        btn_editbrgy.Enabled = False
        pb_imglogo.ImageLocation = tb_imglocation.Text
        dgv_brgyofficials.Show()
        dgv_positions.Show()
        BINDDATA(dgv_brgyinfo, "[Table]")
        BINDDATA(dgv_brgyofficials, "[Table1]")
        BINDDATA(dgv_positions, "[Table2]")
        GETROWS()
        GETPOSITIONS()

    End Sub
End Class