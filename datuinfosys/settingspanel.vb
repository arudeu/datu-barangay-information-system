Imports System.Data.SqlClient
Public Class settingspanel

    Private currentchildform As Form

    Private Sub OpenForm(childform As Form)
        If currentchildform IsNot Nothing Then
            currentchildform.Close()

        End If
        currentchildform = childform
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        subpnl_settings.Controls.Add(childform)
        subpnl_settings.Tag = childform
        childform.BringToFront()
        childform.Show()
    End Sub

    Private Sub icb_settingsuser_Click(sender As Object, e As EventArgs) Handles icb_settingsuser.Click
        OpenForm(New setingsuserpanel)
    End Sub

    Private Sub icb_settingsbrgy_Click(sender As Object, e As EventArgs) Handles icb_settingsbrgy.Click
        OpenForm(New settingsbrgypanel)
    End Sub

    Private Sub settingspanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.USERTYPE = "Regular Admin" Then
            icb_settingsuser.Hide()
        ElseIf Form1.USERTYPE = "Super Admin" Then
            icb_settingsuser.Show()
        Else
            icb_settingsuser.Hide()
        End If
        OpenForm(New settingsbrgypanel)
    End Sub
End Class