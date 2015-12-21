Public Class frmTax
    Dim iTaxEmp As ITaxEmployee = New TaxEmployeeImpl
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        frmAddTax.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmAddTax.ShowDialog()
    End Sub

    Private Sub frmTax_Load(sender As Object, e As EventArgs) Handles Me.Load
        PanelEx1.Height = 35
        Label1.Height = 25
        iTaxEmp.Show(dgvTax)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        iTaxEmp.Search(txtSearch.Text, dgvTax)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        iTaxEmp.Show(dgvTax)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        iTaxEmp.Delete(PayrollUtils.GetValue.ToString)
        iTaxEmp.Show(dgvTax)
    End Sub

    Private Sub dgvTax_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTax.CellClick
        PayrollUtils.GetValue = GetIndexFromDataGridView(1, dgvTax)
    End Sub
End Class