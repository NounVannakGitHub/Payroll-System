Public Class frmPhoto

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmPhoto_Load(sender As Object, e As EventArgs) Handles Me.Load
        SBar.Text = ("Image Taken At - " & TimeString & " , On the - " & DateString)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim savePath As String
        With SaveFile
            .Title = "Save Image File!"
            .Filter = "BitMap files only (.bmp)|*.bmp"
            .InitialDirectory = Application.StartupPath & "/DCIM/"
            .ShowDialog()
            savePath = .FileName(.InitialDirectory & frmAddEmployee.txtEmpId.Text)
        End With
        imgPhoto.Image.Save(savePath)
        frmAddEmployee.imgEmployee.ImageLocation = savePath
    End Sub
End Class