Public Class frmAddbonus
    Dim bonus As New BonusImpl
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub frmAddbonus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetComboBox(cboEmpId, "tblEmployee", "EmployeeID")
        If frmBonus.btnNew.Pressed = True Then
            btnSave.Enabled = True
            btnEdit.Enabled = False
        Else
            btnEdit.Enabled = True
            btnSave.Enabled = False

            cboEmpId.Text = GetIndexFromDataGridView(1, frmBonus.dgvBonus)
            cboTypeBonus.Text = GetIndexFromDataGridView(4, frmBonus.dgvBonus)
            txtTime.Text = GetIndexFromDataGridView(5, frmBonus.dgvBonus)
            txtCost.Text = GetIndexFromDataGridView(6, frmBonus.dgvBonus)
            txtSubTotal.Text = GetIndexFromDataGridView(7, frmBonus.dgvBonus)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        bonus.Insert(New Bonus(cboEmpId.Text, dtpFrom.Text, dtpTo.Text, cboTypeBonus.Text, txtTime.Text, txtCost.Text, txtSubTotal.Text))
        ClearForm(GroupBox1)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        bonus.Update(PayrollUtils.GetValue, New Bonus(cboEmpId.Text, dtpFrom.Text, dtpTo.Text, cboTypeBonus.Text, txtTime.Text, txtCost.Text, txtSubTotal.Text))
        ClearForm(GroupBox1)
    End Sub
End Class