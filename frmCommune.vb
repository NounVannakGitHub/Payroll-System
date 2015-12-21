Public Class frmCommune
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim addr As New Address
        addr.Insert("Commune", txtCommune.Text, "DistrictID", cboDistrict.SelectedIndex + 1)
        ClearForm(txtCommune)
    End Sub
    Private Sub frmCommune_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetComboBox(cboCity, "tblCity", "City")
    End Sub

    Private Sub txtCommune_GotFocus(sender As Object, e As EventArgs)
        SwitchLanguage("kh")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub cboCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCity.SelectedIndexChanged
        SetComboBox(cboDistrict, cboCity, "tblDistrict", "District", "CityID")
    End Sub
End Class