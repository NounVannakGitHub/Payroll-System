Public Class frmUniversity
    Private Shared Shadows UNIVERSITY As String = "SELECT FullName FROM tblUniversity"
    Private Shared Shadows MAJOR As String = "SELECT MajorName FROM tblMajor"
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub

    Private Sub frmUniversity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetComboBoxValue(cboUniversity, frmUniversity.UNIVERSITY)
        SetComboBoxValue(cboMajor, frmUniversity.MAJOR)
    End Sub
End Class