Public Class frmVillage

    Private Sub frmVillage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetComboBox(cboCity, "tblCity", "City")
    End Sub

    Private Sub txtVillage_GotFocus(sender As Object, e As EventArgs) Handles txtVillage.GotFocus
        SwitchLanguage("kh")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim addr As New Address
        addr.Insert("Village", txtVillage.Text, "CommuneID", cboCommune.SelectedIndex + 1)
        ClearForm(txtVillage)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub cboCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCity.SelectedIndexChanged
        SetComboBox(cboDistrict, cboCity, "tblDistrict", "District", "CityID")
    End Sub

    Private Sub cboDistrict_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDistrict.SelectedIndexChanged
        SetComboBox(cboCommune, cboDistrict, "tblCommune", "Commune", "DistrictID")
    End Sub
End Class