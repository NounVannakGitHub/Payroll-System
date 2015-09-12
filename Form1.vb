Public Class Form1
    Dim employee As New Employee
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        PictureBox1.ImageLocation = DoSelectPictureBackground(OpenFileDialog1)
    End Sub
End Class
