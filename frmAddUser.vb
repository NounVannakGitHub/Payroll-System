Public Class frmAddUser
    Dim iUser As IUser = New UserImpl
    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelEx1.Height = 35
        ClearForm(gbUser)
        txtUserId.Text = SetAutoID(GetID("tblUser"), "USER-0000")
        SetComboBox(cboEmpId, "tblEmployee", "EmployeeID")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub cbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassword.CheckedChanged
        ShowPassword(cbShowPassword, txtConPassword)
        ShowPassword(cbShowPassword, txtPassword)
    End Sub

    Private Sub btnSaveUser_Click(sender As Object, e As EventArgs) Handles btnSaveUser.Click
        DoSetNA(gbUser)
        iUser.Insert(New User(txtUserId.Text, cboEmpId.Text, txtLastName.Text, txtFirstName.Text, txtPosition.Text, txtUserName.Text, txtPassword.Text, txtConPassword.Text, imgPhoto.ImageLocation))
        ClearForm(gbUser)
        txtUserId.Text = SetAutoID(GetID("tblUser"), "USER-0000")
    End Sub

    Private Sub cboEmpId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpId.SelectedIndexChanged
        txtLastName.Text = GetFieldValue("tblEmployee", "LastName", cboEmpId.Text)
        txtFirstName.Text = GetFieldValue("tblEmployee", "FirstName", cboEmpId.Text)
        txtPosition.Text = GetFieldValue("tblWorkInformation", "Position", cboEmpId.Text)
        imgPhoto.ImageLocation = GetImagePathFromDB(cboEmpId.Text)
    End Sub
End Class