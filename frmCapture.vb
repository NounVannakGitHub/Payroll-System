Public Class frmCapture
    Dim iCam As New iCam
    Private Sub frmCapture_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        iCam.initCam(Me.imgCapture.Handle.ToInt64)
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        iCam.closeCam()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        iCam.resetCam()
    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        If iCam.iRunning Then
            Dim frmPhoto As New frmPhoto
            frmPhoto.imgPhoto.Image = iCam.copyFrame(Me.imgCapture, New RectangleF(0, 0, Me.imgCapture.Width, Me.imgCapture.Height))
            frmPhoto.Show()
        Else
            SetProcessStatus("Camera Is Not Running!")
        End If
    End Sub

    Private Sub tmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick
        With sBar
            .Text = ("Curent FPS = " & iCam.FPS & "   " & _
                    "Running Status = " & iCam.iRunning)
        End With
    End Sub
End Class