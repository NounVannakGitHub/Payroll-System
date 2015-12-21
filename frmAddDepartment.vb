Public Class frmAddDepartment
    Dim depart As New Department
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        depart.Insert(txtDepartment.Text)
        ClearForm(txtDepartment)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        depart.Update(GetIndexFromDataGridView(0, frmDepartment.dgvDepartment), txtDepartment.Text)
        ClearForm(txtDepartment)
    End Sub

    Private Sub frmAddDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmDepartment.btnNew.Pressed = True Then
            btnSave.Enabled = True
            btnUpdate.Enabled = False
        Else
            btnSave.Enabled = False
            btnUpdate.Enabled = True
        End If
    End Sub
End Class