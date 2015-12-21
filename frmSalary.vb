Public Class frmSalary
    Dim iSalary As ISalary = New SalaryImpl
    Private Sub pnlClose_Click(sender As Object, e As EventArgs) Handles pnlClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmSalaryPaySlip.ShowDialog()
    End Sub

    Private Sub frmSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelEx1.Height = 35
        pnlClose.Height = 35
        pnlClose.Width = 40
        iSalary.Show(dgvSalary)
    End Sub

    Private Sub dgvSalary_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        PayrollUtils.GetValue = GetIndexFromDataGridView(0, dgvSalary)
        btnDelete.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        iSalary.Delete(PayrollUtils.GetValue.ToString)
        iSalary.Show(dgvSalary)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        iSalary.Show(dgvSalary)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        iSalary.Search(txtSearch.Text, dgvSalary)
    End Sub
End Class