Public Class frmBonus
    Dim bonus As New BonusImpl
    Private Sub frmBonus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlBonus.Height = 35
        Label1.Height = 25
        btnClosePnl.Width = 40
        bonus.Show(dgvBonus)
    End Sub

    Private Sub btnClosePnl_Click(sender As Object, e As EventArgs) Handles btnClosePnl.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmAddbonus.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmAddbonus.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        bonus.Delete(PayrollUtils.GetValue)
        bonus.Show(dgvBonus)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        bonus.Show(dgvBonus)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        bonus.Search(txtSearch.Text, dgvBonus)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        bonus.Search(txtSearch.Text, dgvBonus)
    End Sub

    Private Sub dgvBonus_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBonus.CellClick
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        PayrollUtils.GetValue = GetIndexFromDataGridView(0, dgvBonus)
    End Sub
End Class