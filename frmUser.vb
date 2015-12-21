Public Class frmUser
    Dim iUser As IUser = New UserImpl
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        PanelEx1.Height = 35
        pnlClose.Height = 35
        pnlClose.Width = 40
        iUser.Show(dgvUser)
    End Sub
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        frmAddUser.ShowDialog()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        iUser.Show(dgvUser)
    End Sub
    Private Sub pnlClose_Click(sender As Object, e As EventArgs) Handles pnlClose.Click
        Me.Close()
    End Sub
    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        frmChangePassword.ShowDialog()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        iUser.Search(txtSearch.Text, dgvUser)
    End Sub

    Private Sub dgvUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellClick
        btnDelete.Enabled = True
        PayrollUtils.GetValue = GetIndexFromDataGridView(1, dgvUser)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        iUser.Delete(PayrollUtils.GetValue.ToString)
        iUser.Show(dgvUser)
    End Sub

    Private Sub btnEmergency_Click(sender As Object, e As EventArgs)
        frmPasswordEmergency.ShowDialog()
    End Sub

    Private Sub btnPermission_Click(sender As Object, e As EventArgs)
        frmPermission.ShowDialog()
    End Sub
End Class