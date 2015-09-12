Public Class frmConnect

    Private Sub frmConnect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServer(cboServer)
    End Sub

    Private Sub cboServer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServer.SelectedIndexChanged
        LoadDatabase(cboServer.Text, cboDatabase)
    End Sub

    Private Sub chbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chbShowPassword.CheckedChanged
        ShowPassword(chbShowPassword, txtPassword)
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        SetConnectionString(cboServer.Text, cboDatabase.Text, txtUser.Text, txtPassword.Text)
    End Sub
End Class