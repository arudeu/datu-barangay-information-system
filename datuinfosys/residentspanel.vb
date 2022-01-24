Public Class residentspanel
    Private currentchildform As Form

    Private Sub OpenForm(childform As Form)
        If currentchildform IsNot Nothing Then
            currentchildform.Close()

        End If
        currentchildform = childform
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        subpnl_residents.Controls.Add(childform)
        subpnl_residents.Tag = childform
        childform.BringToFront()
        childform.Show()
    End Sub

    Private Sub btn_residentslist_Click(sender As Object, e As EventArgs) Handles btn_residentslist.Click
        OpenForm(New residentlistpanel)
    End Sub

    Private Sub btn_addresident_Click(sender As Object, e As EventArgs) Handles btn_addresident.Click
        OpenForm(New addresidentpanel)
    End Sub

    Private Sub residentspanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenForm(New residentlistpanel)
    End Sub
End Class