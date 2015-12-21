Public Class frmLeave
    Dim leave As New LeaveImpl
    Private Sub btnClosePanel_Click(sender As Object, e As EventArgs) Handles btnClosePanel.Click
        Me.Close()
    End Sub

    Private Sub frmLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlEmployeeInfo.Height = 35
        btnClosePanel.Width = 40
        AddNewLabel.Height = 25
        leave.Show(dgvLeave)
    End Sub

    Private Sub tBtnAdd_Click(sender As Object, e As EventArgs) Handles tBtnAdd.Click
        frmAddLeave.ShowDialog()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        leave.Search(txtSearch.Text, dgvLeave)
        tBtnEdit.Enabled = False
        tBtnDelete.Enabled = False
    End Sub

    Private Sub tBtnRefresh_Click(sender As Object, e As EventArgs) Handles tBtnRefresh.Click
        leave.Show(dgvLeave)
        tBtnEdit.Enabled = False
        tBtnDelete.Enabled = False
    End Sub

    Private Sub tBtnDelete_Click(sender As Object, e As EventArgs) Handles tBtnDelete.Click
        leave.Delete(PayrollUtils.GetValue)
        leave.Show(dgvLeave)
    End Sub

    Private Sub tBtnEdit_Click(sender As Object, e As EventArgs) Handles tBtnEdit.Click
        frmAddLeave.ShowDialog()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        leave.Search(txtSearch.Text, dgvLeave)
    End Sub

    Private Sub dgvLeave_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeave.CellClick
        PayrollUtils.GetValue = GetIndexFromDataGridView(1, dgvLeave)
        tBtnEdit.Enabled = True
        tBtnDelete.Enabled = True
    End Sub
End Class