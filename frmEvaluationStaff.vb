Public Class frmEvaluationStaff
    Dim eva As New Evaluation
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmAddEvaluationStaff.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmAddEvaluationStaff.ShowDialog()
    End Sub

    Private Sub frmEvaluationStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        eva.Show(dgvEvaluationStaff)
    End Sub

    Private Sub dgvEvaluationStaff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEvaluationStaff.CellClick
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        PayrollUtils.GetValue = GetIndexFromDataGridView(1, dgvEvaluationStaff)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        eva.Show(dgvEvaluationStaff)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        eva.Delete(PayrollUtils.GetValue.ToString)
        eva.Show(dgvEvaluationStaff)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        eva.Search(txtSearch.Text, dgvEvaluationStaff)
    End Sub
End Class