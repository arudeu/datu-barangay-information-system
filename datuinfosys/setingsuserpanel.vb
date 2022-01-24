Imports System.Data.SqlClient
Public Class setingsuserpanel
    Dim CONSTRING As String = "Data Source=DESKTOP-9S3FKV6\SQLEXPRESS;Initial Catalog=datudb;Integrated Security=True"
    Private Sub setingsuserpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UsersdatudbDataSet.USERS' table. You can move, or remove it, as needed.
        Me.USERSTableAdapter.Fill(Me.UsersdatudbDataSet.USERS)
        BINDDATA(dgv_brgyofficials, "[USERS]")
        GETOFFICIALS()
        cb_officialui.Text = ""
        tb_usernameui.Text = ""
        tb_passwordui.Text = ""
        cb_usertypeui.SelectedItem = ""
        btn_edituser.Enabled = False
        btn_adduser.Enabled = True
        btn_deleteuser.Enabled = False
        dgv_brgyofficials.Hide()
    End Sub
    Public Sub GETOFFICIALS()
        cb_officialui.DataSource = Nothing
        cb_officialui.DataSource = dgv_brgyofficials.DataSource
        cb_officialui.DisplayMember = "USERNAME"
        cb_officialui.ValueMember = "USERNAME"
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

    Private Sub btn_adduser_Click(sender As Object, e As EventArgs) Handles btn_adduser.Click
        Dim USERNAME As String = tb_usernameui.Text
        Dim PASSWORD As String = tb_passwordui.Text
        Dim USERTYPE As String = cb_usertypeui.Text



        Dim SQL As String = "INSERT INTO [USERS] VALUES (@USERLNAME,@USERNAME,@PASSWORD,@USERTYPE)"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As New SqlCommand(SQL, CON)
                CMD.Parameters.AddWithValue("@USERLNAME", USERNAME)
                CMD.Parameters.AddWithValue("@USERNAME", USERNAME)
                CMD.Parameters.AddWithValue("@PASSWORD", PASSWORD)
                CMD.Parameters.AddWithValue("@USERTYPE", USERTYPE)

                CON.Open()
                CMD.ExecuteNonQuery()
                CON.Close()
                tb_usernameui.Text = ""
                tb_passwordui.Text = ""
                tb_passwordui.Text = ""
                cb_officialui.SelectedItem = ""
                btn_adduser.Enabled = True
                btn_edituser.Enabled = False
                btn_deleteuser.Enabled = False
                GETOFFICIALS()
                Me.Refresh()
                cb_officialui.SelectedItem = -1
                MessageBox.Show("Changes Saved!")
            End Using
        End Using
    End Sub

    Private Sub btn_edituser_Click(sender As Object, e As EventArgs) Handles btn_edituser.Click
        UPDATEUSER()
    End Sub
    Private Sub btn_deleteuser_Click(sender As Object, e As EventArgs) Handles btn_deleteuser.Click
        DELTEUSER()
    End Sub
    Public Sub UPDATEUSER()
        Dim USER As String = tb_usernameui.Text
        Dim PASSWORD As String = tb_passwordui.Text
        Dim USERTYPE As String = cb_usertypeui.SelectedItem



        Dim SQL As String = "UPDATE [USERS] SET USERNAME = @USERNAME, PASSWORD = @PASSWORD, USERTYPE = @USERTYPE"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As New SqlCommand(SQL, CON)
                CMD.Parameters.AddWithValue("@USERNAME", USER)
                CMD.Parameters.AddWithValue("@PASSWORD", PASSWORD)
                CMD.Parameters.AddWithValue("@USERTYPE", USERTYPE)

                CON.Open()
                CMD.ExecuteNonQuery()
                CON.Close()
                btn_adduser.Enabled = False
                btn_edituser.Enabled = True
                btn_deleteuser.Enabled = True
                GETOFFICIALS()
                Me.Refresh()
                cb_officialui.SelectedItem = -1
                MessageBox.Show("Changes Saved!")
            End Using
        End Using
    End Sub

    Public Sub DELTEUSER()
        Dim USER As String = tb_usernameui.Text

        Dim SQL As String = "DELETE FROM [USERS] WHERE USERNAME = @USERNAME"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As New SqlCommand(SQL, CON)
                CMD.Parameters.AddWithValue("@USERNAME", USER)

                CON.Open()
                CMD.ExecuteNonQuery()
                CON.Close()

                tb_usernameui.Text = ""
                tb_passwordui.Text = ""
                cb_usertypeui.SelectedItem = ""
                btn_adduser.Enabled = False
                btn_edituser.Enabled = True
                btn_deleteuser.Enabled = True
                GETOFFICIALS()
                Me.Refresh()
                cb_officialui.SelectedItem = -1
                MessageBox.Show("Deleted Successfully!")

            End Using
        End Using
    End Sub
    Private Sub cb_officialui_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_officialui.SelectedIndexChanged
        Dim SQL As String = "SELECT * FROM [USERS] WHERE USERNAME = @USERNAME"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    CMD.Parameters.AddWithValue("@USERNAME", SqlDbType.NVarChar).Value = cb_officialui.Text
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)
                        If DT.Rows.Count = 1 Then

                            tb_usernameui.Text = DT.Rows(0).Item(2)
                            tb_passwordui.Text = DT.Rows(0).Item(3)
                            cb_usertypeui.SelectedItem = DT.Rows(0).Item(4)
                            btn_adduser.Enabled = False
                            btn_edituser.Enabled = True
                            btn_deleteuser.Enabled = True

                        Else
                            cb_officialui.SelectedItem = -1
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub


End Class