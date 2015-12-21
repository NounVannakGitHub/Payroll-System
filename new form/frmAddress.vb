Public Class frmAddress
    Private Sub frmAddress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelEx1.Height = 35
        btnClose.Width = 40
        TabControl1.ItemSize = New Size(72, 20)
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNewP.Click
        frmAddProvince.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEditP.Click
        frmAddProvince.ShowDialog()
    End Sub

    Private Sub btnAddNewD_Click(sender As Object, e As EventArgs) Handles btnAddNewD.Click
        frmAddDistrict.ShowDialog()
    End Sub

    Private Sub btnEditD_Click(sender As Object, e As EventArgs) Handles btnEditD.Click
        frmAddDistrict.ShowDialog()
    End Sub

    Private Sub btnSaveNewC_Click(sender As Object, e As EventArgs) Handles btnSaveNewC.Click
        frmAddCommune.ShowDialog()
    End Sub

    Private Sub btnEditC_Click(sender As Object, e As EventArgs) Handles btnEditC.Click
        frmAddCommune.ShowDialog()
    End Sub

    Private Sub btnSaveNewV_Click(sender As Object, e As EventArgs) Handles btnSaveNewV.Click
        frmAddVillage.ShowDialog()
    End Sub

    Private Sub btnEditV_Click(sender As Object, e As EventArgs) Handles btnEditV.Click
        frmAddVillage.ShowDialog()
    End Sub
End Class