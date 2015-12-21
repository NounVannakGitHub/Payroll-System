Public Class frmAddress
    Dim addr As New Address
    Private Sub frmAddress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelEx4.Height = 35
        PictureBox1.Height = 35
        PictureBox1.Width = 40
        addr.Show("tblCity", dCity)
        addr.Show("tblDistrict", dDistrict)
        addr.Show("tblCommune", dCommune)
        addr.Show("tblVillage", dVillage)
    End Sub
    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        addr.Show("tblCity", dCity)
        addr.Show("tblDistrict", dDistrict)
        addr.Show("tblCommune", dCommune)
        addr.Show("tblVillage", dVillage)
    End Sub

    Private Sub dCity_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dCity.CellDoubleClick
        frmCity.ShowDialog()
    End Sub

    Private Sub dDistrict_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dDistrict.CellDoubleClick
        frmDistrict.ShowDialog()
    End Sub

    Private Sub dCommune_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dCommune.CellDoubleClick
        frmCommune.ShowDialog()
    End Sub

    Private Sub dVillage_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dVillage.CellDoubleClick
        frmVillage.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class