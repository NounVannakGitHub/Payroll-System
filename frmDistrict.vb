Public Class frmDistrict

    Private Sub frmDistrict_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetComboBox(cboCity, "tblCity", "City")
    End Sub

    Private Sub txtDistrict_GotFocus(sender As Object, e As EventArgs) Handles txtDistrict.GotFocus
        SwitchLanguage("kh")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim addr As New Address
        addr.Insert("District", txtDistrict.Text, "CityID", cboCity.SelectedIndex + 1)
        ClearForm(txtDistrict)
    End Sub
End Class