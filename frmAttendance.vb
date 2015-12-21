Public Class frmAttendance
    Dim att As New AttEmp
    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelEx1.Height = 35
        Label1.Height = 25
        att.Show(dgvAttendance)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        frmAttEmployee.ShowDialog()
    End Sub

    Private Sub tbnRefresh_Click(sender As Object, e As EventArgs) Handles tbnRefresh.Click
        att.Show(dgvAttendance)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        att.Search(txtSearch.Text, dgvAttendance)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        att.Search(txtSearch.Text, dgvAttendance)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        att.Delete(PayrollUtils.GetValue)
        att.Show(dgvAttendance)
    End Sub

    Private Sub dgvAttendance_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAttendance.CellClick
        btnDelete.Enabled = True
        PayrollUtils.GetValue = GetIndexFromDataGridView(0, dgvAttendance)
    End Sub
End Class