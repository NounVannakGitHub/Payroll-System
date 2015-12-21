Public Class frmPasswordEmergency
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub frmPasswordEmergency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetComboBox(cboUserId, "tblUser", "UserId")
    End Sub

    Private Sub cboUserId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUserId.SelectedIndexChanged
        txtPassword.Text = MyString(DoDecode(GetFieldValue("tblUser", "Password", "UserId", cboUserId.Text)))
    End Sub
End Class