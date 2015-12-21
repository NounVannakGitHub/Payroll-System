Public Class frmChangePassword

    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearForm(gbChange)
        SetComboBox(cboUserId, "tblUser", "UserId")
        txtNewPassword.Enabled = False
        txtConNewPassword.Enabled = False
        imgNewPassword.Visible = False
    End Sub

    Private Sub cboUserId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUserId.SelectedIndexChanged
        txtOldPassword.Enabled = True
    End Sub

    Private Sub txtConNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConNewPassword.TextChanged
        imgNewPassword.Visible = DoImageEnabled(txtNewPassword.Text, txtConNewPassword.Text)
    End Sub

    Private Sub cbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassword.CheckedChanged
        ShowPassword(cbShowPassword, txtConNewPassword)
        ShowPassword(cbShowPassword, txtNewPassword)
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim iUser As IUser = New UserImpl
        iUser.ChangePassword(cboUserId.Text, txtNewPassword.Text, txtConNewPassword.Text)
        ClearForm(gbChange)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub txtOldPassword_TextChanged(sender As Object, e As EventArgs) Handles txtOldPassword.TextChanged
        Dim myBoolean As Boolean = DoImageEnabled(txtOldPassword.Text, MyString(DoDecode(GetFieldValue("tblUser", "Password", "UserId", cboUserId.Text))))
        imgOldPassword.Visible = myBoolean
        txtNewPassword.Enabled = myBoolean
        txtConNewPassword.Enabled = myBoolean
    End Sub
End Class