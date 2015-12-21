Public Class frmAddPosition
    Dim pos As New Position
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        pos.Insert(txtPosition.Text)
        ClearForm(txtPosition)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        pos.Update(GetIndexFromDataGridView(0, frmPosition.dgvPosition), txtPosition.Text)
        ClearForm(txtPosition)
    End Sub

    Private Sub frmAddPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmPosition.btnAddNew.Pressed = True Then
            btnSave.Enabled = True
            btnUpdate.Enabled = False
        Else
            btnSave.Enabled = False
            btnUpdate.Enabled = True
        End If
    End Sub
End Class