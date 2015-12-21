Public Class frmDepartment
    Dim depart As New Department
    Private Sub frmDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelEx1.Height = 35
        depart.Show(dgvDepartment)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmAddDepartment.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmAddDepartment.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        depart.Show(dgvDepartment)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        depart.Delete(GetIndexFromDataGridView(1, dgvDepartment))
        depart.Show(dgvDepartment)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        depart.Search(txtSearch.Tag, dgvDepartment)
    End Sub

    Private Sub dgvDepartment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartment.CellClick
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        PayrollUtils.GetValue = GetIndexFromDataGridView(1, dgvDepartment)
    End Sub
End Class