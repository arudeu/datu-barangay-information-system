Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports MessagingToolkit.QRCode.Codec
Imports System.Data.SqlClient
Imports System.IO

Public Class qrscanner
    Dim CAMERA As VideoCaptureDevice
    Dim BMP As Bitmap
    Dim READER As QRCodeDecoder

    Private Sub btn_cam_Click(sender As Object, e As EventArgs) Handles btn_cam.Click
        CAMERASETUP()
    End Sub
    Public Sub CAMERASETUP()
        Dim CAM As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If CAM.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CAMERA = CAM.VideoDevice
            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf CAPS)
            CAMERA.Start()
        End If
    End Sub

    Private Sub btn_capture_Click(sender As Object, e As EventArgs) Handles btn_capture.Click
        pb_captured.Image = pb_qrscanner.Image
    End Sub
    Public Sub CAPS(SENDER As Object, EVENTARGS As NewFrameEventArgs)
        BMP = DirectCast(EVENTARGS.Frame.Clone(), Bitmap)
        pb_qrscanner.Image = DirectCast(EVENTARGS.Frame.Clone(), Bitmap)
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click

        Try
            READER = New QRCodeDecoder
            residentlistpanel.tb_searchresident.Text = READER.Decode(New Data.QRCodeBitmapImage(pb_captured.Image))
            MsgBox("QR code detected!")
            Me.Hide()
        Catch ex As Exception
            MsgBox("Try Again")
        End Try
    End Sub
End Class