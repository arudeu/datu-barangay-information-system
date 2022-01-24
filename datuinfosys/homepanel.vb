Imports System.Data.SqlClient
Public Class homepanel
    Dim CONSTRING As String = "Data Source=DESKTOP-9S3FKV6\SQLEXPRESS;Initial Catalog=datudb;Integrated Security=True"

    Public Sub GETPOPULATION(DGV As DataGridView)



        Dim SQL As String = "SELECT * FROM [RESIDENTS]"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)
                        DGV.DataSource = DT

                        lbl_population.Text = DT.Rows.Count

                    End Using
                End Using
            End Using
        End Using

    End Sub
    Public Sub GETMALE()



        Dim SQL As String = "SELECT * FROM [RESIDENTS] WHERE gender = 'Male'"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)

                        Dim POP As Integer = Convert.ToInt32(lbl_population.Text)
                        lbl_male.Text = String.Format("{0:0.#}", (DT.Rows.Count / POP) * 100) & "%"

                    End Using
                End Using
            End Using
        End Using

    End Sub
    Public Sub GETFEMALE()
        Dim SQL As String = "SELECT * FROM [RESIDENTS] WHERE gender = 'Female'"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)

                        Dim POP As Integer = Convert.ToInt32(lbl_population.Text)
                        lbl_female.Text = String.Format("{0:0.#}", (DT.Rows.Count / POP) * 100) & "%"

                    End Using
                End Using
            End Using
        End Using

    End Sub

    Public Sub GETKIDS()
        Dim SQL As String = "SELECT * FROM [RESIDENTS] WHERE AGEGROUP = 'Kids'"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)

                        Dim POP As Integer = Convert.ToInt32(lbl_population.Text)
                        lbl_kids.Text = String.Format("{0:0.#}", (DT.Rows.Count / POP) * 100) & "%"

                    End Using
                End Using
            End Using
        End Using
    End Sub
    Public Sub GETTEENS()
        Dim SQL As String = "SELECT * FROM [RESIDENTS] WHERE AGEGROUP = 'Teens'"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)

                        Dim POP As Integer = Convert.ToInt32(lbl_population.Text)
                        lbl_teens.Text = String.Format("{0:0.#}", (DT.Rows.Count / POP) * 100) & "%"

                    End Using
                End Using
            End Using
        End Using
    End Sub
    Public Sub GETADULTS()
        Dim SQL As String = "SELECT * FROM [RESIDENTS] WHERE AGEGROUP = 'Adults'"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)

                        Dim POP As Integer = Convert.ToInt32(lbl_population.Text)
                        lbl_adults.Text = String.Format("{0:0.#}", (DT.Rows.Count / POP) * 100) & "%"

                    End Using
                End Using
            End Using
        End Using
    End Sub
    Public Sub GETSENIOR()
        Dim SQL As String = "SELECT * FROM [RESIDENTS] WHERE AGEGROUP = 'Senior'"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)

                        Dim POP As Integer = Convert.ToInt32(lbl_population.Text)
                        lbl_senior.Text = String.Format("{0:0.#}", (DT.Rows.Count / POP) * 100) & "%"

                    End Using
                End Using
            End Using
        End Using
    End Sub
    Public Sub GETVOTERS()
        Dim SQL As String = "SELECT * FROM [RESIDENTS] WHERE VOTER = 'Yes'"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)

                        Dim POP As Integer = Convert.ToInt32(lbl_population.Text)
                        lbl_voter.Text = String.Format("{0:0.#}", (DT.Rows.Count / POP) * 100) & "%"

                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub GETBBRGYINFO()
        Dim SQL As String = "SELECT * FROM [Table] WHERE BARANGAYID = 1"
        Using CON As SqlConnection = New SqlConnection(CONSTRING)
            Using CMD As SqlCommand = New SqlCommand(SQL, CON)
                Using ADAPTER As New SqlDataAdapter()
                    ADAPTER.SelectCommand = CMD
                    Using DT As New DataTable()
                        ADAPTER.Fill(DT)

                        If DT.Rows.Count = 1 Then
                            pb_brgylogo.ImageLocation = DT.Rows(0).Item(5)
                            lbl_brgyname.Text = DT.Rows(0).Item(1)
                            lbl_brgyaddress.Text = DT.Rows(0).Item(2) & ", " & DT.Rows(0).Item(3) & ", " & DT.Rows(0).Item(4)
                        Else
                            pb_brgylogo.Image = datuinfosys.My.Resources.Resources.lgo
                            lbl_brgyname.Text = "BARANGAY"
                            lbl_brgyaddress.Text = "ADDRESS"
                        End If


                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub homepanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_brgyofficials.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Ds_brgyofficials.Table1)
        'TODO: This line of code loads data into the 'Ds_brgyresidents.RESIDENTS' table. You can move, or remove it, as needed.
        Me.RESIDENTSTableAdapter.Fill(Me.Ds_brgyresidents.RESIDENTS)
        GETPOPULATION(dgv_brgyinfo)
        GETMALE()
        GETFEMALE()
        GETBBRGYINFO()
        GETADULTS()
        GETKIDS()
        GETTEENS()
        GETSENIOR()
        GETVOTERS()
    End Sub
End Class