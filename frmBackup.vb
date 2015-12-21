Public Class frmBackup
    Private Sub frmBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServer(cboServer)
    End Sub

    Private Sub cboServer_GotFocus(sender As Object, e As EventArgs) Handles cboServer.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub cboServer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServer.SelectedIndexChanged
        LoadDatabase(cboServer.Text, cboDatabase)
    End Sub

    Private Sub cboServer_TextChanged(sender As Object, e As EventArgs) Handles cboServer.TextChanged
        LoadDatabase(cboServer.Text, cboDatabase)
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Backup(cboDatabase.Text, dialogBackup, Timer1, pbBackup)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DoProgressBar(Timer1, pbBackup)
    End Sub

    Private Sub cboDatabase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDatabase.SelectedIndexChanged
        btnBackup.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class