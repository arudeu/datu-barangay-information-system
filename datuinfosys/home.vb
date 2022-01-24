Imports System.Data.SqlClient
Public Class home
    Private currentchildform As Form
    Dim CONSTRING As String = "Data Source=DESKTOP-9S3FKV6\SQLEXPRESS;Initial Catalog=datudb;Integrated Security=True"
    Private Sub OpenForm(childform As Form)
        If currentchildform IsNot Nothing Then
            currentchildform.Close()

        End If
        currentchildform = childform
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        desktop_pnl.Controls.Add(childform)
        desktop_pnl.Tag = childform
        childform.BringToFront()
        childform.Show()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        'HOME
        OpenForm(New homepanel)

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        'RESIDENTS
        OpenForm(New residentspanel)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) 
        'REQUESTS
        OpenForm(New requestspanel)
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        'SETTINGS
        OpenForm(New settingspanel)
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        'LOGOUT
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenForm(New homepanel)

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

        lbl_hello.Text = "Welcome, " & Form1.USER
    End Sub
End Class