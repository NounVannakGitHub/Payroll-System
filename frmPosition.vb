Public Class frmPosition
    Dim pos As New Position
    Private Sub frmPosition_Load(sender As Object, e As EventArgs) Handles Me.Load
        PanelEx1.Height = 35
        btnClose.Width = 40
        pos.Show(dgvPosition)
    End Sub
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        frmAddPosition.ShowDialog()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmAddPosition.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        pos.Delete(PayrollUtils.GetValue)
        pos.Show(dgvPosition)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        pos.Show(dgvPosition)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        pos.Search(txtSearch.Text, dgvPosition)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        pos.Search(txtSearch.Text, dgvPosition)
    End Sub

    Private Sub dgvPosition_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPosition.CellClick
        btnDelete.Enabled = True
        btnEdit.Enabled = True
        PayrollUtils.GetValue = GetIndexFromDataGridView(0, dgvPosition)
    End Sub
End Class