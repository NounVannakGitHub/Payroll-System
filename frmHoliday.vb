Public Class frmHoliday
    Dim holiday As New Holiday
    Private Sub frmHoliday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelEx1.Height = 35
        Label1.Height = 25
        holiday.Show(dgvHoliday)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmAddHoliday.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmAddHoliday.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        holiday.Show(dgvHoliday)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        holiday.Delete(PayrollUtils.GetValue)
        holiday.Show(dgvHoliday)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        holiday.Search(txtSearch.Text, dgvHoliday)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        holiday.Search(txtSearch.Text, dgvHoliday)
    End Sub

    Private Sub dgvHoliday_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHoliday.CellClick
        btnDelete.Enabled = True
        btnEdit.Enabled = True
        PayrollUtils.GetValue = GetIndexFromDataGridView(0, dgvHoliday)
    End Sub
End Class