Public Class frmCity
    Dim addr As New Address
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        addr.Insert("City", txtCity.Text)
        ClearForm(txtCity)
    End Sub
    Private Sub txtCity_GotFocus(sender As Object, e As EventArgs) Handles txtCity.GotFocus
        SwitchLanguage("kh")
    End Sub
End Class