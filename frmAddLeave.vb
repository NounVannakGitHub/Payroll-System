Public Class frmAddLeave
    Dim leave As New LeaveImpl
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged, CheckBox3.CheckedChanged, CheckBox2.CheckedChanged, CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            txtAnnual.Text = AutoDate()
            txtSick.Text = ""
            txtSpecial.Text = ""
            txtMaternity.Text = ""
        ElseIf CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            txtAnnual.Text = ""
            txtSick.Text = AutoDate()
            txtSpecial.Text = ""
            txtMaternity.Text = ""
        ElseIf CheckBox3.Checked = True Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox4.Checked = False
            txtAnnual.Text = ""
            txtSick.Text = ""
            txtSpecial.Text = AutoDate()
            txtMaternity.Text = ""
        ElseIf CheckBox4.Checked = True Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            CheckBox2.Checked = False
            txtAnnual.Text = ""
            txtSick.Text = ""
            txtSpecial.Text = ""
            txtMaternity.Text = AutoDate()
        End If
    End Sub

    Private Sub frmAddLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetComboBox(cboEmployeeId, "tblEmployee", "EmployeeID")
        If frmLeave.tBtnAdd.Pressed = True Then
            btnSave.Enabled = True
            btnEdit.Enabled = False
        Else
            btnSave.Enabled = False
            btnEdit.Enabled = True
        End If
    End Sub

    Private Sub cboEmployeeId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmployeeId.SelectedIndexChanged
        txtName.Text = GetFieldValue("tblEmployee", "LatinName", cboEmployeeId.Text)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        leave.Insert(cboEmployeeId.Text, txtName.Text, txtAnnual.Text, txtSick.Text, txtSpecial.Text, txtMaternity.Text, txtDay.Text, txtRemark.Text)
        ClearForm(gbLeave)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        leave.Update(PayrollUtils.GetValue, txtName.Text, txtAnnual.Text, txtSick.Text, txtSpecial.Text, txtMaternity.Text, txtDay.Text, txtRemark.Text)
        ClearForm(gbLeave)
    End Sub

    Private Sub txtDay_GotFocus(sender As Object, e As EventArgs) Handles txtDay.GotFocus
        SwitchLanguage("en")
    End Sub
End Class