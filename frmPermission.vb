Public Class frmPermission
    Dim permission As New Permission
    Dim user As IUser = New UserImpl
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = False Then
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
            CheckBox13.Checked = False
            CheckBox14.Checked = False
            CheckBox15.Checked = False
            CheckBox16.Checked = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = False Then
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked = False Then
            CheckBox18.Checked = False
            CheckBox19.Checked = False
            CheckBox28.Checked = False
        End If
    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
        If CheckBox21.Checked = False Then
            CheckBox22.Checked = False
            CheckBox23.Checked = False
            CheckBox24.Checked = False
            CheckBox25.Checked = False
        End If
    End Sub

    Private Sub CheckBox23_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked = False Then
            CheckBox24.Checked = False
            CheckBox25.Checked = False
        End If
    End Sub

    Private Sub CheckBox26_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox26.CheckedChanged
        If CheckBox26.Checked = False Then
            CheckBox27.Checked = False
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub frmPermission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetComboBox(cboPosition, "tblPosition", "Position")
        user.Show(dgvUser)
        permission.Show(dgvPermission)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        permission.Insert(cboPosition.Text, SetCheckBox(CheckBox1), SetCheckBox(CheckBox2), SetCheckBox(CheckBox3), SetCheckBox(CheckBox4), SetCheckBox(CheckBox5), SetCheckBox(CheckBox6), SetCheckBox(CheckBox7), SetCheckBox(CheckBox8), SetCheckBox(CheckBox9), SetCheckBox(CheckBox10), SetCheckBox(CheckBox11), SetCheckBox(CheckBox12), SetCheckBox(CheckBox13), SetCheckBox(CheckBox14), SetCheckBox(CheckBox15), SetCheckBox(CheckBox16), SetCheckBox(CheckBox17), SetCheckBox(CheckBox18), SetCheckBox(CheckBox19), SetCheckBox(CheckBox20), SetCheckBox(CheckBox21), SetCheckBox(CheckBox22), SetCheckBox(CheckBox23), SetCheckBox(CheckBox24), SetCheckBox(CheckBox25), SetCheckBox(CheckBox26), SetCheckBox(CheckBox27), SetCheckBox(CheckBox28))
        permission.Show(dgvPermission)
        ClearCheckBox(GroupBox2)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        permission.Update(PayrollUtils.GetValue, SetCheckBox(CheckBox1), SetCheckBox(CheckBox2), SetCheckBox(CheckBox3), SetCheckBox(CheckBox4), SetCheckBox(CheckBox5), SetCheckBox(CheckBox6), SetCheckBox(CheckBox7), SetCheckBox(CheckBox8), SetCheckBox(CheckBox9), SetCheckBox(CheckBox10), SetCheckBox(CheckBox11), SetCheckBox(CheckBox12), SetCheckBox(CheckBox13), SetCheckBox(CheckBox14), SetCheckBox(CheckBox15), SetCheckBox(CheckBox16), SetCheckBox(CheckBox17), SetCheckBox(CheckBox18), SetCheckBox(CheckBox19), SetCheckBox(CheckBox20), SetCheckBox(CheckBox21), SetCheckBox(CheckBox22), SetCheckBox(CheckBox23), SetCheckBox(CheckBox24), SetCheckBox(CheckBox25), SetCheckBox(CheckBox26), SetCheckBox(CheckBox27), SetCheckBox(CheckBox28))
        permission.Show(dgvPermission)
        ClearCheckBox(GroupBox2)
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        permission.Delete(PayrollUtils.GetValue)
        permission.Show(dgvPermission)
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub dgvPermission_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPermission.CellDoubleClick
        PayrollUtils.GetValue = GetIndexFromDataGridView(1, dgvPermission)
        Dim myChBox() As CheckBox = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6, CheckBox7, CheckBox8, CheckBox9, CheckBox10, CheckBox11, CheckBox12, CheckBox13, CheckBox14, CheckBox15, CheckBox16, CheckBox17, CheckBox18, CheckBox19, CheckBox20, CheckBox21, CheckBox22, CheckBox23, CheckBox24, CheckBox25, CheckBox26, CheckBox27, CheckBox28}
        SetFalseOrTrueCheckBox(myChBox, dgvPermission, 2)
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub
End Class