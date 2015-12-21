Public Class frmRestore

    Private Sub frmRestore_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadServer(cboServer)
    End Sub

    Private Sub cboServer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServer.SelectedIndexChanged
        LoadDatabase(cboServer.Text, cboDatabase)
    End Sub

    Private Sub cboDatabase_GotFocus(sender As Object, e As EventArgs) Handles cboDatabase.GotFocus
        SwitchLanguage("en")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DoProgressBar(Timer1, pbRestore)
    End Sub

    Private Sub cboDatabase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDatabase.SelectedIndexChanged
        btnRestore.Enabled = True
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Restore(cboDatabase.Text, dialogRestore, Timer1, pbRestore)
    End Sub
End Class