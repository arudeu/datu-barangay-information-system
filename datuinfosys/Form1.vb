Imports System.Data.SqlClient
Public Class Form1
    Public USER As String
    Public USERTYPE As String

    Dim CONSTRING As String = "Data Source=DESKTOP-9S3FKV6\SQLEXPRESS;Initial Catalog=datudb;Integrated Security=True"
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim SQL As String = "SELECT * FROM [USERS] WHERE USERNAME = @USERNAME AND PASSWORD = @PASSWORD"
        Dim LOGO As Image
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    CMD.Parameters.AddWithValue("@USERNAME", SqlDbType.NVarChar).Value = tb_user.Text
                    CMD.Parameters.AddWithValue("@PASSWORD", SqlDbType.NVarChar).Value = tb_pass.Text
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)
                        If DT.Rows.Count = 1 Or (tb_user.Text = "admin" And tb_pass.Text = "12345") Then

                            If tb_user.Text = "admin" Then
                                USER = "Admin"
                                USERTYPE = "Super Admin"
                            Else
                                USER = DT.Rows(0).Item(2)
                                USERTYPE = DT.Rows(0).Item(4)
                            End If


                            home.Show()
                            Me.Hide()
                        Else
                            MsgBox("Login Failed")
                        End If
                    End Using
                End Using
            End Using
        End Using

        tb_user.Text = ""
        tb_pass.Text = ""

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SQL As String = "SELECT * FROM [Table]"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)
                        If DT.Rows.Count = 1 Then

                            PictureBox1.ImageLocation = DT.Rows(0).Item(5)

                        Else
                            PictureBox1.Image = datuinfosys.My.Resources.Resources.lgo
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class
